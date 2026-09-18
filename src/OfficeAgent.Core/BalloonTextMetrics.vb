Imports System.Runtime.InteropServices

''' <summary>
''' MS Agentの吹き出し(Balloon)の自動高さ計算で使うWin32 GDIラッパー。
''' MS Agent本体(agentsvr.exe、AgentCtl.dllはこれとDCOM経由で通信するプロキシに過ぎない)を
''' 逆コンパイルして特定した、吹き出し矩形サイズの実際の計算式(FUN_010074c6)は以下の通り：
'''   幅(px)  = CharsPerLine × GetTextMetrics().tmAveCharWidth
'''   高さ(px) = NumberOfLines × (GetTextMetrics().tmHeight + 2) + 0x12
''' CharsPerLineは「半角の代表的な1文字("0"等)の実測幅」ではなく、Win32標準のTEXTMETRIC
''' 構造体が返すtmAveCharWidth（主に英字アルファベットの統計から算出される平均文字幅）を
''' 基準にしている。Graphics.MeasureString（GDI+）ではこの値を再現できず、GDIとGDI+は
''' フォントのレンダリング・文字幅計算アルゴリズムが微妙に異なり、特に全角文字（日本語）で
''' 無視できない誤差が生じることが実機で確認されたため、GetTextMetrics／GetTextExtentPoint32Wを
''' P/Invokeで直接呼ぶ
''' </summary>
Friend Module BalloonTextMetrics

    <DllImport("gdi32.dll", CharSet:=CharSet.Unicode)>
    Private Function GetTextMetrics(hdc As IntPtr, ByRef lptm As TEXTMETRIC) As Boolean
    End Function

    <DllImport("gdi32.dll", CharSet:=CharSet.Unicode)>
    Private Function GetTextExtentPoint32W(hdc As IntPtr, lpString As String, c As Integer, ByRef psizl As WIN32_SIZE) As Boolean
    End Function

    <DllImport("user32.dll")>
    Private Function GetDC(hWnd As IntPtr) As IntPtr
    End Function

    <DllImport("user32.dll")>
    Private Function ReleaseDC(hWnd As IntPtr, hDC As IntPtr) As Integer
    End Function

    <DllImport("gdi32.dll")>
    Private Function SelectObject(hdc As IntPtr, hgdiobj As IntPtr) As IntPtr
    End Function

    <DllImport("gdi32.dll")>
    Private Function DeleteObject(hObject As IntPtr) As Boolean
    End Function

    <StructLayout(LayoutKind.Sequential)>
    Private Structure WIN32_SIZE
        Public cx As Integer
        Public cy As Integer
    End Structure

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)>
    Private Structure TEXTMETRIC
        Public tmHeight As Integer
        Public tmAscent As Integer
        Public tmDescent As Integer
        Public tmInternalLeading As Integer
        Public tmExternalLeading As Integer
        Public tmAveCharWidth As Integer
        Public tmMaxCharWidth As Integer
        Public tmWeight As Integer
        Public tmOverhang As Integer
        Public tmDigitizedAspectX As Integer
        Public tmDigitizedAspectY As Integer
        Public tmFirstChar As Char
        Public tmLastChar As Char
        Public tmDefaultChar As Char
        Public tmBreakChar As Char
        Public tmItalic As Byte
        Public tmUnderlined As Byte
        Public tmStruckOut As Byte
        Public tmPitchAndFamily As Byte
        Public tmCharSet As Byte
    End Structure

    ' フォントを一時的にHDCへ選択した状態でactionを実行する。GetTextMetricsや
    ' GetTextExtentPoint32Wは「HDCに現在選択されているフォント」に対して計測するため、
    ' 呼び出しの前後でフォントの生成・選択・復元・破棄を必ずセットで行う必要がある
    Private Sub UsingFontSelectedIntoDC(hdc As IntPtr, font As Drawing.Font, action As Action)
        Dim hFont = font.ToHfont()
        Try
            Dim oldFont = SelectObject(hdc, hFont)
            Try
                action()
            Finally
                SelectObject(hdc, oldFont)
            End Try
        Finally
            DeleteObject(hFont)
        End Try
    End Sub

    ' fontのtmAveCharWidth（吹き出し幅の計算に使う）とtmHeight（高さの計算に使う）を取得する。
    ' 呼び出し元は、この後CountWrappedLinesも呼ぶ場合、必ず同じhdcを渡すこと
    ' （別々にGetDCしたHDCだと、モニタや状況によってDPI基準が食い違い、CharsPerLine×
    ' tmAveCharWidthで求めた吹き出し幅と実測の行幅の比較が噛み合わなくなるおそれがあるため）
    Public Function TryGetFontMetrics(hdc As IntPtr, font As Drawing.Font, ByRef aveCharWidthPx As Integer, ByRef heightPx As Integer) As Boolean
        Dim tm As New TEXTMETRIC()
        Dim ok = False
        UsingFontSelectedIntoDC(hdc, font, Sub() ok = GetTextMetrics(hdc, tm))
        aveCharWidthPx = tm.tmAveCharWidth
        heightPx = tm.tmHeight
        Return ok AndAlso aveCharWidthPx > 0
    End Function

    ' textをfontで描画したときにmaxWidthPxの幅の吹き出しの中で何行に折り返されるかを計算する。
    ' 「行全体の幅の合計 ÷ 行幅」の切り上げでは、大きい文字（全角）が続く場合に実際より
    ' 少ない行数を計算してしまう（例：行幅100pxに対し幅60pxの文字が3つ並ぶと、合計180pxから
    ' ceil(180/100)=2行と計算されるが、実際には2文字目で120px>100pxとなり1文字ずつしか
    ' 入らないため3行必要になる）。文字は分割できない（途中で折り返せない）という制約が
    ' あるため、面積（合計）ベースの計算では正しい行数を求められず、MS Agent本体と同様に
    ' 1文字ずつ幅を加算していき、はみ出た時点で次の行に送る逐次計算が必要
    Public Function CountWrappedLines(hdc As IntPtr, text As String, font As Drawing.Font, maxWidthPx As Integer) As Integer
        If text.Length = 0 OrElse maxWidthPx <= 0 Then Return 0
        Dim lineCount = 1
        Dim currentWidthPx = 0
        UsingFontSelectedIntoDC(hdc, font,
            Sub()
                Dim sz As New WIN32_SIZE()
                For Each c In text
                    GetTextExtentPoint32W(hdc, c.ToString(), 1, sz)
                    Dim charWidthPx = sz.cx
                    If currentWidthPx > 0 AndAlso currentWidthPx + charWidthPx > maxWidthPx Then
                        lineCount += 1
                        currentWidthPx = charWidthPx
                    Else
                        currentWidthPx += charWidthPx
                    End If
                Next
            End Sub)
        Return lineCount
    End Function

    ' 現在の画面のDCを取得してactionに渡し、終わったら解放する
    Public Sub UsingScreenDC(action As Action(Of IntPtr))
        Dim hdc = GetDC(IntPtr.Zero)
        If hdc = IntPtr.Zero Then Return
        Try
            action(hdc)
        Finally
            ReleaseDC(IntPtr.Zero, hdc)
        End Try
    End Sub

End Module
