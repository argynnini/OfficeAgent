Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices
Imports System.Text
Imports Markdig

' window.external 経由でJavaScriptからフォームに高さを通知するブリッジ
<ComVisible(True)>
Public Class ScriptingHelper
    Private ReadOnly _form As ResponseBalloonForm
    Sub New(f As ResponseBalloonForm)
        _form = f
    End Sub
    Public Sub ReportHeight(height As Integer)
        _form.OnBrowserHeightReport(height)
    End Sub
End Class

Public Class ResponseBalloonForm
    Inherits Form

    Private WithEvents _closeBtn As Button
    Private WithEvents _copyBtn As Button
    Private WithEvents _browser As WebBrowser
    Private WithEvents _updateTimer As New Timer With {.Interval = 150}
    Private WithEvents _copyFeedbackTimer As New Timer With {.Interval = 1200}
    Private ReadOnly _fullText As New StringBuilder()
    Private ReadOnly _pipeline As MarkdownPipeline = New MarkdownPipelineBuilder().UseAdvancedExtensions().Build()
    Private _agL As Integer, _agT As Integer, _mag As Single
    Private _pendingUpdate As Boolean = False

    Private Const BrowserTop As Integer = 4
    Private Const BtnH As Integer = 26
    Private Const BtnW As Integer = 90
    Private Const BtnGap As Integer = 20
    Private Const BtnBottomMargin As Integer = 8
    Private Const BtnArea As Integer = BtnH + BtnBottomMargin + 6
    Private Const TailH As Integer = 14
    Private Const MaxBodyH As Integer = 450
    Private Const MinBodyH As Integer = 72

    Protected Overrides ReadOnly Property ShowWithoutActivation As Boolean
        Get
            Return True
        End Get
    End Property

    Public Sub New()
        _closeBtn = New Button()
        _copyBtn = New Button()
        _browser = New WebBrowser()

        SuspendLayout()

        ShowInTaskbar = False
        FormBorderStyle = FormBorderStyle.None
        StartPosition = FormStartPosition.Manual
        ' 【重要】TopMost=Trueは、ShowWithoutActivation=Trueのフォームに設定したままにすると
        ' Wordのキーボードフォーカス管理を壊す（Alt+Tabするまでショートカットが効かない）ことが
        ' 実機検証で判明した。そのため常時ONにせず、OnVisibleChangedで実際に表示している間だけONにする
        DoubleBuffered = True
        BackColor = Drawing.Color.FromArgb(255, 255, 154)

        Dim w = 390
        Dim bodyH = MinBodyH

        _browser.Location = New Drawing.Point(4, BrowserTop)
        _browser.Size = New Drawing.Size(w - 8, bodyH - BrowserTop - BtnArea)
        _browser.ScrollBarsEnabled = True
        _browser.ScriptErrorsSuppressed = True
        _browser.IsWebBrowserContextMenuEnabled = False
        _browser.WebBrowserShortcutsEnabled = True
        _browser.ObjectForScripting = New ScriptingHelper(Me)
        Controls.Add(_browser)

        Dim btnRowX = (w - (BtnW * 2 + BtnGap)) \ 2

        _copyBtn.Text = "コピー"
        _copyBtn.Size = New Drawing.Size(BtnW, BtnH)
        _copyBtn.Location = New Drawing.Point(btnRowX, bodyH - BtnBottomMargin - BtnH)
        _copyBtn.BackColor = Drawing.Color.FromArgb(240, 200, 30)
        _copyBtn.FlatStyle = FlatStyle.Flat
        _copyBtn.FlatAppearance.BorderColor = Drawing.Color.FromArgb(160, 130, 30)
        Controls.Add(_copyBtn)

        _closeBtn.Text = "閉じる"
        _closeBtn.Size = New Drawing.Size(BtnW, BtnH)
        _closeBtn.Location = New Drawing.Point(btnRowX + BtnW + BtnGap, bodyH - BtnBottomMargin - BtnH)
        _closeBtn.BackColor = Drawing.Color.FromArgb(240, 200, 30)
        _closeBtn.FlatStyle = FlatStyle.Flat
        _closeBtn.FlatAppearance.BorderColor = Drawing.Color.FromArgb(160, 130, 30)
        Controls.Add(_closeBtn)

        ClientSize = New Drawing.Size(w, bodyH + TailH)
        Region = New Drawing.Region(CreateBalloonPath(w, bodyH + TailH))

        ResumeLayout(False)
    End Sub

    ' 【重要】TopMostは実際に表示している間だけON。非表示中もONのままにしておくと、
    ' ShowWithoutActivation=Trueと組み合わさってWordのキーボードフォーカス管理を壊すため
    Protected Overrides Sub OnVisibleChanged(e As EventArgs)
        MyBase.OnVisibleChanged(e)
        TopMost = Visible
    End Sub

    Public Sub StartResponse(initialText As String, agentLogicalLeft As Integer, agentLogicalTop As Integer, mag As Single)
        _fullText.Clear()
        _fullText.Append(initialText)
        _agL = agentLogicalLeft : _agT = agentLogicalTop : _mag = mag
        _updateTimer.Stop()
        _pendingUpdate = False
        _browser.DocumentText = BuildHtml(ToHtml())
        ApplyLocation()
        BringToFront()
        Show()
    End Sub

    Public Sub AppendChunk(text As String, agentLogicalLeft As Integer, agentLogicalTop As Integer, mag As Single)
        _fullText.Append(text)
        _agL = agentLogicalLeft : _agT = agentLogicalTop : _mag = mag
        _pendingUpdate = True
        If Not _updateTimer.Enabled Then _updateTimer.Start()
    End Sub

    Public Sub MoveToAgent(agentLogicalLeft As Integer, agentLogicalTop As Integer, mag As Single)
        _agL = agentLogicalLeft : _agT = agentLogicalTop : _mag = mag
        ApplyLocation()
    End Sub

    ' JavaScriptのonloadからwindow.external経由で呼ばれる
    Friend Sub OnBrowserHeightReport(height As Integer)
        If InvokeRequired Then
            BeginInvoke(Sub() ResizeBalloon(height))
        Else
            ResizeBalloon(height)
        End If
    End Sub

    ' 150msごとにDocumentText全体を更新（InnerHtml不使用でMarkdown表示問題を回避）
    Private Sub UpdateTimer_Tick(sender As Object, e As EventArgs) Handles _updateTimer.Tick
        If Not _pendingUpdate Then
            _updateTimer.Stop()
            Return
        End If
        _pendingUpdate = False
        _browser.DocumentText = BuildHtml(ToHtml())
    End Sub

    ' http/https リンクのみ外部ブラウザへ。about:blank や内部URLは通す
    Private Sub Browser_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles _browser.Navigating
        Dim url = e.Url.ToString()
        If url.StartsWith("http://") OrElse url.StartsWith("https://") Then
            e.Cancel = True
            Diagnostics.Process.Start(New Diagnostics.ProcessStartInfo(url) With {.UseShellExecute = True})
        End If
    End Sub

    Private Sub ResizeBalloon(contentH As Integer)
        Dim w = ClientSize.Width
        Dim bodyH = Math.Max(MinBodyH, Math.Min(MaxBodyH, BrowserTop + contentH + BtnArea))
        Dim totalH = bodyH + TailH
        If totalH = ClientSize.Height Then Return

        SuspendLayout()
        _browser.Size = New Drawing.Size(w - 8, bodyH - BrowserTop - BtnArea)
        _copyBtn.Location = New Drawing.Point(_copyBtn.Location.X, bodyH - BtnBottomMargin - BtnH)
        _closeBtn.Location = New Drawing.Point(_closeBtn.Location.X, bodyH - BtnBottomMargin - BtnH)
        ClientSize = New Drawing.Size(w, totalH)
        Region = New Drawing.Region(CreateBalloonPath(w, totalH))
        ApplyLocation()
        ResumeLayout(True)
    End Sub

    Private Sub ApplyLocation()
        Dim totalH = ClientSize.Height
        Location = New Drawing.Point(CInt(_agL * _mag) - 207, CInt(_agT * _mag) - totalH + TailH)
    End Sub

    Private Function ToHtml() As String
        Return Markdown.ToHtml(_fullText.ToString(), _pipeline)
    End Function

    Private Function BuildHtml(htmlContent As String) As String
        ' bodyのonloadでJavaScriptがwindow.external.ReportHeightを呼び高さを通知する
        ' InvokeScript不使用のため Navigating イベントを汚染しない
        Return "<!DOCTYPE html><html><head>" &
               "<meta http-equiv=""X-UA-Compatible"" content=""IE=Edge"">" &
               "<style>" &
               "body{font-family:'Yu Gothic UI',sans-serif;font-size:10pt;background:#FFFF9A;" &
               "margin:0;padding:4px 6px;word-wrap:break-word;overflow-wrap:break-word;}" &
               "code{background:rgba(0,0,0,.1);padding:1px 3px;border-radius:3px;" &
               "font-family:Consolas,monospace;font-size:9pt;}" &
               "pre{background:rgba(0,0,0,.08);padding:6px 8px;border-radius:4px;margin:4px 0;overflow-x:auto;}" &
               "pre code{background:none;padding:0;}" &
               "h1,h2,h3{margin:4px 0 2px;font-size:11pt;}" &
               "ul,ol{margin:2px 0;padding-left:18px;}li{margin:1px 0;}" &
               "p{margin:3px 0;}" &
               "blockquote{border-left:3px solid #c8a000;margin:4px 0 4px 8px;padding-left:8px;color:#555;}" &
               "table{border-collapse:collapse;margin:4px 0;}" &
               "td,th{border:1px solid #c8a000;padding:2px 6px;}" &
               "</style></head>" &
               "<body onload=""try{if(window.external)window.external.ReportHeight(document.body.scrollHeight)}catch(e){}"">" &
               "<div id=""content"">" & htmlContent & "</div></body></html>"
    End Function

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles _closeBtn.Click
        Hide()
    End Sub

    Private Sub CopyBtn_Click(sender As Object, e As EventArgs) Handles _copyBtn.Click
        If _fullText.Length = 0 Then Return

        SetClipboardMultiFormat(_fullText.ToString(), BuildCfHtml(ToHtml()))

        _copyFeedbackTimer.Stop()
        _copyBtn.Text = "コピー ✓"
        _copyFeedbackTimer.Start()
    End Sub

    ' Word/Outlook等がリッチテキストとして貼り付けられるよう、CF_HTML形式でラップする
    Private Shared Function BuildCfHtml(bodyHtmlFragment As String) As String
        Const HeaderTemplate As String =
            "Version:0.9" & vbCrLf &
            "StartHTML:{0:D10}" & vbCrLf &
            "EndHTML:{1:D10}" & vbCrLf &
            "StartFragment:{2:D10}" & vbCrLf &
            "EndFragment:{3:D10}" & vbCrLf

        Dim htmlPrefix = "<html><body>" & vbCrLf & "<!--StartFragment-->"
        Dim htmlSuffix = "<!--EndFragment-->" & vbCrLf & "</body></html>" & vbCrLf

        Dim headerLen = Encoding.UTF8.GetByteCount(String.Format(HeaderTemplate, 0, 0, 0, 0))
        Dim startHtml = headerLen
        Dim startFragment = startHtml + Encoding.UTF8.GetByteCount(htmlPrefix)
        Dim endFragment = startFragment + Encoding.UTF8.GetByteCount(bodyHtmlFragment)
        Dim endHtml = endFragment + Encoding.UTF8.GetByteCount(htmlSuffix)

        Dim header = String.Format(HeaderTemplate, startHtml, endHtml, startFragment, endFragment)
        Return header & htmlPrefix & bodyHtmlFragment & htmlSuffix
    End Function

    ' .NETのDataObject.SetText(TextDataFormat.Html)はANSIコードページで再エンコードしてしまい
    ' 日本語などマルチバイト文字が文字化けするため、Win32 APIで直接UTF-8バイト列を書き込む
    Private Const GMEM_MOVEABLE As UInteger = &H2
    Private Const CF_UNICODETEXT As UInteger = 13

    <DllImport("user32.dll")>
    Private Shared Function OpenClipboard(hWndNewOwner As IntPtr) As Boolean
    End Function

    <DllImport("user32.dll")>
    Private Shared Function CloseClipboard() As Boolean
    End Function

    <DllImport("user32.dll")>
    Private Shared Function EmptyClipboard() As Boolean
    End Function

    <DllImport("user32.dll")>
    Private Shared Function SetClipboardData(uFormat As UInteger, hMem As IntPtr) As IntPtr
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Unicode)>
    Private Shared Function RegisterClipboardFormat(lpszFormat As String) As UInteger
    End Function

    <DllImport("kernel32.dll")>
    Private Shared Function GlobalAlloc(uFlags As UInteger, dwBytes As IntPtr) As IntPtr
    End Function

    <DllImport("kernel32.dll")>
    Private Shared Function GlobalLock(hMem As IntPtr) As IntPtr
    End Function

    <DllImport("kernel32.dll")>
    Private Shared Function GlobalUnlock(hMem As IntPtr) As Boolean
    End Function

    <DllImport("kernel32.dll")>
    Private Shared Function GlobalFree(hMem As IntPtr) As IntPtr
    End Function

    Private Shared Function CreateGlobalMemoryUnicode(text As String) As IntPtr
        Dim byteCount = (text.Length + 1) * 2
        Dim hGlobal = GlobalAlloc(GMEM_MOVEABLE, CType(byteCount, IntPtr))
        If hGlobal = IntPtr.Zero Then Return IntPtr.Zero
        Dim ptr = GlobalLock(hGlobal)
        If ptr = IntPtr.Zero Then
            GlobalFree(hGlobal)
            Return IntPtr.Zero
        End If
        Try
            Marshal.Copy(text.ToCharArray(), 0, ptr, text.Length)
            Marshal.WriteInt16(ptr, text.Length * 2, 0)
        Finally
            GlobalUnlock(hGlobal)
        End Try
        Return hGlobal
    End Function

    Private Shared Function CreateGlobalMemoryBytes(data As Byte()) As IntPtr
        Dim hGlobal = GlobalAlloc(GMEM_MOVEABLE, CType(data.Length + 1, IntPtr))
        If hGlobal = IntPtr.Zero Then Return IntPtr.Zero
        Dim ptr = GlobalLock(hGlobal)
        If ptr = IntPtr.Zero Then
            GlobalFree(hGlobal)
            Return IntPtr.Zero
        End If
        Try
            Marshal.Copy(data, 0, ptr, data.Length)
            Marshal.WriteByte(ptr, data.Length, 0)
        Finally
            GlobalUnlock(hGlobal)
        End Try
        Return hGlobal
    End Function

    Private Sub SetClipboardMultiFormat(plainText As String, cfHtml As String)
        If Not OpenClipboard(Handle) Then Return
        Try
            EmptyClipboard()

            Dim hText = CreateGlobalMemoryUnicode(plainText)
            If hText <> IntPtr.Zero AndAlso SetClipboardData(CF_UNICODETEXT, hText) = IntPtr.Zero Then
                GlobalFree(hText)
            End If

            Dim htmlFormatId = RegisterClipboardFormat("HTML Format")
            Dim hHtml = CreateGlobalMemoryBytes(Encoding.UTF8.GetBytes(cfHtml))
            If hHtml <> IntPtr.Zero AndAlso SetClipboardData(htmlFormatId, hHtml) = IntPtr.Zero Then
                GlobalFree(hHtml)
            End If
        Finally
            CloseClipboard()
        End Try
    End Sub

    Private Sub CopyFeedbackTimer_Tick(sender As Object, e As EventArgs) Handles _copyFeedbackTimer.Tick
        _copyFeedbackTimer.Stop()
        _copyBtn.Text = "コピー"
    End Sub

    Private Function CreateBalloonPath(w As Integer, h As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        Dim r = 15
        Dim bh = h - TailH
        Dim tailCx = w \ 2
        Dim tailW = 9
        Dim tailTipX = tailCx + 12

        path.AddArc(0, 0, r * 2, r * 2, 180, 90)
        path.AddArc(w - r * 2, 0, r * 2, r * 2, 270, 90)
        path.AddArc(w - r * 2, bh - r * 2, r * 2, r * 2, 0, 90)
        path.AddLine(w - r, bh, tailCx + tailW, bh)
        path.AddLine(tailCx + tailW, bh, tailTipX, h)
        path.AddLine(tailTipX, h, tailCx - tailW, bh)
        path.AddArc(0, bh - r * 2, r * 2, r * 2, 90, 90)
        path.CloseFigure()

        Return path
    End Function

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Using path = CreateBalloonPath(ClientSize.Width, ClientSize.Height)
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
            Using pen As New Drawing.Pen(Drawing.Color.FromArgb(160, 130, 30), 2.0F)
                e.Graphics.DrawPath(pen, path)
            End Using
        End Using
    End Sub

End Class
