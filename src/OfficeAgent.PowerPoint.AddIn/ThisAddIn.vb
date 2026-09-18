Imports System.Drawing
Imports System.Windows.Forms
Imports OfficeAgent.Core

Partial Public Class ThisAddIn

    Private _agentForm As OfficeAgent.Core.AgentFloatingForm
    Private _settingsTaskPane As Microsoft.Office.Tools.CustomTaskPane
    Private _slideShowStopwatch As Diagnostics.Stopwatch

    ' スピーカーノート中の<slide .../>タグ（発話中操作）が、AgentFloatingForm側の
    ' Bookmarkイベントハンドラから呼ばれた時点で使う「今アクティブなスライドショーウィンドウ」。
    ' コールバックのタイミングでは元のイベント引数(wn)を持っていないため、直近のスライドショー
    ' イベントで受け取ったものを覚えておく
    Private _activeSlideShowWindow As Microsoft.Office.Interop.PowerPoint.SlideShowWindow

    ' SlideShowNextSlideイベントは、1回のスライド送りに対して複数回連続で発火することがある
    ' （PowerPoint Interopの既知の癖）。同じスライドに対してSpeakSlideNotes（内部でStopAll→Speak
    ' し直す）が短時間に連続で呼ばれると、SAPIエンジン側の再生位置がずれて冒頭が読まれず
    ' 後半だけ聞こえる、という症状が起きるため、直前に読み上げたスライド番号を覚えておき
    ' 同じスライドに対する重複呼び出しをスキップする
    Private _lastSpokenSlideNotesIndex As Integer = -1

    ' 「移動(オブジェクト)」「指し示す(オブジェクト)」タグ挿入用：直近にスライド上で選択されて
    ' いたシェイプの名前。ノートの編集欄をクリックした瞬間にPowerPointの選択がテキストへ
    ' 切り替わり、シェイプの選択情報が失われてしまう（＝シェイプ選択→ノートにカーソルを
    ' 移動→挿入ボタンを押す、という自然な操作順序ではSelectionから直接は取得できない）ため、
    ' WindowSelectionChangeイベントで選択がシェイプに変わるたびにここへ保存しておき、
    ' GetSelectedShapeNameで「今の選択」が無ければこちらにフォールバックする
    Private _lastSelectedShapeName As String

    Protected Overrides Function CreateRibbonExtensibilityObject() As Microsoft.Office.Core.IRibbonExtensibility
        Return New AgentRibbon()
    End Function

    Private Sub ThisAddIn_Startup() Handles Me.Startup
        OfficeAgent.Core.AssemblyRedirectHelper.EnsureRegistered()

        Try
            _agentForm = New OfficeAgent.Core.AgentFloatingForm()
        Catch ex As Exception When OfficeAgent.Core.MsAgentRuntimeRecovery.IsMsAgentRuntimeMissing(ex)
            OfficeAgent.Core.MsAgentRuntimeRecovery.HandleMissingRuntime()
            Return
        End Try

        ' _agentForm.Show()はフォームのハンドル未作成時に同期的にLoadイベントを発火させる。
        ' AgentFloatingForm_Load内で初回表示位置の計算にGetHostWindowHandleFuncを使うため、
        ' Show()より前に登録しておく必要がある（Show()の後だとLoad時点では常に未登録
        ' 扱いになり、初回表示位置がプライマリモニタ基準にフォールバックしてしまう）
        OfficeAgent.Core.AgentFloatingForm.OpenSettingsPaneAction = AddressOf ShowSettingsPane
        OfficeAgent.Core.AgentFloatingForm.GetSelectedTextAction = AddressOf GetSelectedText
        AgentRibbon.IsSettingsPaneVisibleFunc = Function() IsSettingsPaneVisible
        AgentRibbon.ToggleSettingsPaneAction = AddressOf ToggleSettingsPane
        AgentRibbon.InsertSapiTagAction = AddressOf InsertSapiTagIntoSelection
        AgentRibbon.GetSelectedShapeNameFunc = AddressOf GetSelectedShapeName
        OfficeAgent.Core.AgentFloatingForm.PerformSlideActionAction = AddressOf PerformSlideAction
        OfficeAgent.Core.AgentFloatingForm.PerformScreenActionAction = AddressOf PerformScreenAction
        OfficeAgent.Core.AgentFloatingForm.PerformLaserActionAction = AddressOf PerformLaserAction
        OfficeAgent.Core.AgentFloatingForm.GetSlideVariablesFunc = AddressOf GetSlideVariables
        OfficeAgent.Core.AgentFloatingForm.GetHostWindowHandleFunc = AddressOf GetHostWindowHandle
        OfficeAgent.Core.AgentFloatingForm.GetSlideShowWindowHandleFunc = AddressOf GetSlideShowWindowHandle
        OfficeAgent.Core.AgentFloatingForm.GetShapeScreenBoundsFunc = AddressOf GetShapeScreenBounds

        _agentForm.Show()

        AddHandler Me.Application.WindowSelectionChange, AddressOf OnWindowSelectionChange
        AddHandler Me.Application.PresentationBeforeSave, AddressOf OnBeforeSave
        AddHandler Me.Application.PresentationSave, AddressOf OnAfterSave
        AddHandler Me.Application.PresentationPrint, AddressOf OnAfterPrint
        AddHandler Me.Application.SlideShowBegin, AddressOf OnSlideShowBegin
        AddHandler Me.Application.SlideShowEnd, AddressOf OnSlideShowEnd
        AddHandler Me.Application.SlideShowNextSlide, AddressOf OnSlideShowNextSlide
        AddHandler Me.Application.NewPresentation, AddressOf OnOpen
        AddHandler Me.Application.PresentationOpen, AddressOf OnOpen
        AddHandler Me.Application.PresentationBeforeClose, AddressOf OnBeforeClose
        AddHandler Me.Application.ProtectedViewWindowOpen, AddressOf OnProtectedViewWindowOpen
        AddHandler Me.Application.PresentationNewSlide, AddressOf OnPresentationNewSlide
    End Sub

    ' 設定タスクパネル（AgentSettingsPane）はCustomTaskPanes.Addのコストが実測200～460msあり、
    ' 起動時には使わない機能のため、初めて「設定」が開かれるタイミングまで生成を遅延させる
    Private Function EnsureSettingsTaskPane() As Microsoft.Office.Tools.CustomTaskPane
        If _settingsTaskPane IsNot Nothing Then Return _settingsTaskPane
        Dim pane As New OfficeAgent.Core.AgentSettingsPane() With {.HostApp = AnimationEvents.HostApp.PowerPoint}
        _settingsTaskPane = Me.CustomTaskPanes.Add(pane, "OfficeAgent 設定")
        _settingsTaskPane.Width = 260
        _settingsTaskPane.Visible = False
        AddHandler _settingsTaskPane.VisibleChanged, AddressOf SettingsPane_VisibleChanged
        Return _settingsTaskPane
    End Function

    Public ReadOnly Property IsSettingsPaneVisible As Boolean
        Get
            If _settingsTaskPane Is Nothing Then Return False
            Try
                Return _settingsTaskPane.Visible
            Catch ex As ObjectDisposedException
                Return False
            End Try
        End Get
    End Property

    Public Sub ToggleSettingsPane()
        Dim pane = EnsureSettingsTaskPane()
        Try
            If Not pane.Visible Then
                DirectCast(pane.Control, OfficeAgent.Core.AgentSettingsPane).LoadSettings()
                pane.Visible = True
            Else
                pane.Visible = False
            End If
        Catch ex As ObjectDisposedException
            _settingsTaskPane = Nothing
        End Try
    End Sub

    ' カイル右クリックの「設定」から呼ばれる：閉じていれば開くだけ（トグルしない）
    Public Sub ShowSettingsPane()
        Dim pane = EnsureSettingsTaskPane()
        Try
            DirectCast(pane.Control, OfficeAgent.Core.AgentSettingsPane).LoadSettings()
            pane.Visible = True
        Catch ex As ObjectDisposedException
            _settingsTaskPane = Nothing
        End Try
    End Sub

    Private Sub SettingsPane_VisibleChanged(sender As Object, e As EventArgs)
        AgentRibbon.Instance?.InvalidateRibbon()
    End Sub

    ' カイル右クリックの「選択範囲について」から呼ばれる：選択中のテキスト（または選択中の図形が持つテキスト）を返す
    ' （未選択・テキストを含まない選択ならNothing）
    Private Function GetSelectedText() As String
        Try
            Dim selection = Me.Application.ActiveWindow?.Selection
            If selection Is Nothing Then Return Nothing

            Select Case selection.Type
                Case Microsoft.Office.Interop.PowerPoint.PpSelectionType.ppSelectionText
                    Dim text = selection.TextRange?.Text
                    Return If(String.IsNullOrWhiteSpace(text), Nothing, text.Trim())

                Case Microsoft.Office.Interop.PowerPoint.PpSelectionType.ppSelectionShapes
                    Dim sb As New System.Text.StringBuilder()
                    For Each shape As Microsoft.Office.Interop.PowerPoint.Shape In selection.ShapeRange
                        If shape.HasTextFrame = Microsoft.Office.Core.MsoTriState.msoTrue AndAlso
                           shape.TextFrame.HasText = Microsoft.Office.Core.MsoTriState.msoTrue Then
                            sb.AppendLine(shape.TextFrame.TextRange.Text)
                        End If
                    Next
                    Dim combined = sb.ToString().Trim()
                    Return If(combined.Length = 0, Nothing, combined)

                Case Else
                    Return Nothing
            End Select
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    ' PowerPointの選択状態が変わるたびに発火する。ノートの編集欄にカーソルを合わせた瞬間
    ' 選択がテキストへ切り替わりシェイプの選択情報が失われてしまうため、シェイプが選択された
    ' 時点でその名前を_lastSelectedShapeNameへ保存しておき、GetSelectedShapeNameからの
    ' フォールバック先として使えるようにする
    Private Sub OnWindowSelectionChange(sel As Microsoft.Office.Interop.PowerPoint.Selection)
        Try
            If sel IsNot Nothing AndAlso sel.Type = Microsoft.Office.Interop.PowerPoint.PpSelectionType.ppSelectionShapes AndAlso
               sel.ShapeRange IsNot Nothing AndAlso sel.ShapeRange.Count > 0 Then
                _lastSelectedShapeName = sel.ShapeRange(1).Name
            End If
        Catch ex As Exception
        End Try
    End Sub

    ' リボンの「移動(オブジェクト)」「指し示す(オブジェクト)」タグ挿入から呼ばれる：現在
    ' スライド上で選択されているシェイプの名前を返す（複数選択時は先頭のシェイプ）。
    ' 今の選択がシェイプでない場合（ノートにカーソルを移してから挿入ボタンを押す、という
    ' 自然な操作順序では大抵ここに来る）は、OnWindowSelectionChangeで記憶しておいた
    ' 直近の選択シェイプ名にフォールバックする
    Private Function GetSelectedShapeName() As String
        Try
            Dim selection = Me.Application.ActiveWindow?.Selection
            If selection IsNot Nothing AndAlso selection.Type = Microsoft.Office.Interop.PowerPoint.PpSelectionType.ppSelectionShapes AndAlso
               selection.ShapeRange IsNot Nothing AndAlso selection.ShapeRange.Count > 0 Then
                Return selection.ShapeRange(1).Name
            End If
        Catch ex As Exception
        End Try
        Return _lastSelectedShapeName
    End Function

    ' リボンの「タグ挿入」メニューから呼ばれる：ノート編集中に選択している文字列を
    ' 指定のSAPI5 XMLタグで挟む（選択が無い場合はカーソル位置にタグのペアだけ挿入する）。
    ' テキスト選択（ppSelectionText）以外のとき（図形選択・スライド一覧表示中等）は
    ' 挿入先が不明なため何もせず案内を出す
    Private Sub InsertSapiTagIntoSelection(openTag As String, closeTag As String)
        Try
            Dim selection = Me.Application.ActiveWindow?.Selection
            If selection Is Nothing OrElse selection.Type <> Microsoft.Office.Interop.PowerPoint.PpSelectionType.ppSelectionText Then
                Windows.Forms.MessageBox.Show(
                    "ノートの編集欄でテキストを選択するか、挿入したい位置にカーソルを置いてから使用してください。",
                    "OfficeAgent", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)
                Return
            End If

            Dim textRange = selection.TextRange
            Dim selectedText = textRange.Text
            If String.IsNullOrEmpty(selectedText) Then
                textRange.InsertAfter(openTag & closeTag)
            Else
                textRange.Text = openTag & selectedText & closeTag
            End If
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(
                "タグを挿入できませんでした。" & Environment.NewLine & ex.Message,
                "OfficeAgent", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Warning)
        End Try
    End Sub

    ' AgentFloatingForm側のGetHostWindowHandleFuncから呼ばれる：エージェントの初回表示位置を
    ' 「Officeウィンドウがあるモニタ」基準にするため、PowerPointのメインウィンドウハンドルを返す
    Private Function GetHostWindowHandle() As IntPtr
        Try
            Return New IntPtr(Me.Application.HWND)
        Catch ex As Exception
            Return IntPtr.Zero
        End Try
    End Function

    ' AgentFloatingForm側のGetSlideShowWindowHandleFuncから呼ばれる：発表者が実際に見ている
    ' スライドショーウィンドウのハンドルを返す（発表者スクリーン側のモニタへエージェントを
    ' 移動させる基準にするため）。スライドショー中以外はIntPtr.Zeroを返す
    Private Function GetSlideShowWindowHandle() As IntPtr
        Try
            Dim wn = _activeSlideShowWindow
            If wn Is Nothing Then Return IntPtr.Zero
            Return New IntPtr(wn.HWND)
        Catch ex As Exception
            Return IntPtr.Zero
        End Try
    End Function

    ' AgentFloatingForm側のGetShapeScreenBoundsFuncから呼ばれる：<agent op="move|gesture"
    ' obj="シェイプ名" .../>タグの基準にするため、指定した名前のシェイプの矩形をスクリーン座標
    ' （物理ピクセル）で返す。編集中はDocumentWindow.PointsToScreenPixelsX/Y（PowerPoint自身が
    ' ズーム・スクロール位置を考慮して変換してくれる）を使う。スライドショー中はSlideShowWindow
    ' に同等のAPIが無いため、ShapeBoundsInSlideShowで自前計算する。
    ' 該当スライド・シェイプが見つからない場合はNothingを返す
    Private Function GetShapeScreenBounds(objectName As String) As Rectangle?
        Try
            Dim wnShow = _activeSlideShowWindow
            If wnShow IsNot Nothing Then
                Dim shp = FindShapeOnSlide(wnShow.View.Slide, objectName)
                If shp Is Nothing Then Return Nothing
                Return ShapeBoundsInSlideShow(wnShow, shp)
            End If

            Dim wnDoc = Me.Application.ActiveWindow
            If wnDoc Is Nothing Then Return Nothing
            Dim slide = TryCast(wnDoc.View.Slide, Microsoft.Office.Interop.PowerPoint.Slide)
            If slide Is Nothing Then Return Nothing
            Dim editShp = FindShapeOnSlide(slide, objectName)
            If editShp Is Nothing Then Return Nothing
            Return Rectangle.FromLTRB(
                wnDoc.PointsToScreenPixelsX(editShp.Left),
                wnDoc.PointsToScreenPixelsY(editShp.Top),
                wnDoc.PointsToScreenPixelsX(editShp.Left + editShp.Width),
                wnDoc.PointsToScreenPixelsY(editShp.Top + editShp.Height))
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    ' スライド直下のトップレベルシェイプから名前で検索する（グループ内の要素は対象外）。
    ' 見つからない場合（存在しない名前・COMException）はNothingを返す
    Private Function FindShapeOnSlide(slide As Microsoft.Office.Interop.PowerPoint.Slide, name As String) As Microsoft.Office.Interop.PowerPoint.Shape
        Try
            Return slide.Shapes.Item(name)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    ' ウィンドウの実際のクライアント領域を取得するためのWin32 API。Screen.FromHandle().Boundsは
    ' 呼び出し元プロセス（本アドイン＝PowerPoint本体側のDPI Awareness設定）によってはOSに
    ' 仮想化された値を返すことがあり、SlideShowWindow.Width/Height（ポイント単位）との
    ' 単位が食い違って座標がずれる不具合が実機で確認された。
    ' GetClientRect／ClientToScreenは対象ウィンドウ自身の実ピクセルサイズ・位置を返すため、
    ' 「同じウィンドウ」のポイント⇔ピクセル比を直接計算でき、モニタのDPI設定に左右されない
    <Runtime.InteropServices.StructLayout(Runtime.InteropServices.LayoutKind.Sequential)>
    Private Structure RECT
        Public Left As Integer
        Public Top As Integer
        Public Right As Integer
        Public Bottom As Integer
    End Structure

    <Runtime.InteropServices.StructLayout(Runtime.InteropServices.LayoutKind.Sequential)>
    Private Structure POINT
        Public X As Integer
        Public Y As Integer
    End Structure

    <Runtime.InteropServices.DllImport("user32.dll")>
    Private Shared Function GetClientRect(hWnd As IntPtr, ByRef lpRect As RECT) As Boolean
    End Function

    <Runtime.InteropServices.DllImport("user32.dll")>
    Private Shared Function ClientToScreen(hWnd As IntPtr, ByRef lpPoint As POINT) As Boolean
    End Function

    ' スライドショー中のシェイプ矩形をスクリーン座標（物理ピクセル）で計算する。
    ' SlideShowWindowにはDocumentWindow.PointsToScreenPixelsX/Yに相当するAPIが無いため、
    ' 自前で計算する：
    '   1. HWNDから、そのウィンドウ自身のクライアント領域の実ピクセルサイズ・位置を
    '      GetClientRect／ClientToScreenで取得する（上記コメント参照）
    '   2. SlideShowWindow.Width/Height（ポイント単位、Windowオブジェクト共通の慣例に従う）と
    '      1のピクセル幅から、ポイント→ピクセルの倍率を逆算する
    '   3. スライドとウィンドウのアスペクト比が異なる場合、PowerPointはスライドを中央に
    '      フィットさせ上下または左右に均等な余白（レターボックス）を入れるため、その分の
    '      オフセットも計算に含める
    Private Function ShapeBoundsInSlideShow(wn As Microsoft.Office.Interop.PowerPoint.SlideShowWindow,
                                             shp As Microsoft.Office.Interop.PowerPoint.Shape) As Rectangle?
        If wn.Width <= 0 OrElse wn.Height <= 0 Then Return Nothing

        Dim slideWidthPt = wn.Presentation.PageSetup.SlideWidth
        Dim slideHeightPt = wn.Presentation.PageSetup.SlideHeight
        If slideWidthPt <= 0 OrElse slideHeightPt <= 0 Then Return Nothing

        Dim hwnd = New IntPtr(wn.HWND)
        Dim clientRect As RECT
        If Not GetClientRect(hwnd, clientRect) Then Return Nothing
        Dim clientWidthPx = clientRect.Right - clientRect.Left
        Dim clientHeightPx = clientRect.Bottom - clientRect.Top
        If clientWidthPx <= 0 OrElse clientHeightPx <= 0 Then Return Nothing

        Dim origin As New POINT With {.X = 0, .Y = 0}
        If Not ClientToScreen(hwnd, origin) Then Return Nothing
        Dim screenBounds = New Rectangle(origin.X, origin.Y, clientWidthPx, clientHeightPx)
        Dim pxPerPt = screenBounds.Width / wn.Width

        Dim windowAspect = wn.Width / wn.Height
        Dim slideAspect = slideWidthPt / slideHeightPt
        Dim slideDisplayWidthPt As Double, slideDisplayHeightPt As Double
        Dim slideOffsetXPt As Double, slideOffsetYPt As Double
        If slideAspect > windowAspect Then
            slideDisplayWidthPt = wn.Width
            slideDisplayHeightPt = wn.Width / slideAspect
            slideOffsetXPt = 0
            slideOffsetYPt = (wn.Height - slideDisplayHeightPt) / 2
        Else
            slideDisplayHeightPt = wn.Height
            slideDisplayWidthPt = wn.Height * slideAspect
            slideOffsetYPt = 0
            slideOffsetXPt = (wn.Width - slideDisplayWidthPt) / 2
        End If
        Dim scale = slideDisplayWidthPt / slideWidthPt

        Dim left = screenBounds.Left + (slideOffsetXPt + shp.Left * scale) * pxPerPt
        Dim top = screenBounds.Top + (slideOffsetYPt + shp.Top * scale) * pxPerPt
        Dim right = left + shp.Width * scale * pxPerPt
        Dim bottom = top + shp.Height * scale * pxPerPt

        Return Rectangle.FromLTRB(CInt(left), CInt(top), CInt(right), CInt(bottom))
    End Function

    Private Sub OnBeforeSave(pres As Microsoft.Office.Interop.PowerPoint.Presentation, ByRef cancel As Boolean)
        ' If _agentForm IsNot Nothing Then _agentForm.PlayAnimation("GetAttention")
    End Sub

    Private Sub OnAfterSave(pres As Microsoft.Office.Interop.PowerPoint.Presentation)
        If Not WindowHelper.IsAutoSaveOn(pres) AndAlso _agentForm IsNot Nothing Then _agentForm.PlayConfiguredAnimation("Save")
    End Sub

    ' PresentationPrintは印刷が実際に実行された後にしか発火しない
    Private Sub OnAfterPrint(pres As Microsoft.Office.Interop.PowerPoint.Presentation)
        If _agentForm IsNot Nothing Then _agentForm.PlayConfiguredAnimation("Print")
    End Sub

    Private Sub OnSlideShowBegin(wn As Microsoft.Office.Interop.PowerPoint.SlideShowWindow)
        _slideShowStopwatch = Diagnostics.Stopwatch.StartNew()
        _lastSpokenSlideNotesIndex = -1
        _activeSlideShowWindow = wn
        If _agentForm Is Nothing Then Return

        ' 発表者が実際に見ているスクリーン（発表者ツールを別モニタに出している場合はそちら）に
        ' エージェントを移動させる。元の位置はOnSlideShowEndで復元する
        _agentForm.MoveToSlideShowScreen()

        ' 発表中は非表示（HideAgentDuringSlideShow）とスピーカーノート読み上げは機能上
        ' 競合する（非表示にすると、この後のSpeakCurrentSlideNotesIfEnabled呼び出しに
        ' 到達できず、最初のスライドのノートが読み上げられない）。リボン側でチェックボックスを
        ' グレーアウトしているが、以前チェックを入れたまま読み上げをONにしたケースにも
        ' 対応できるよう、ここでも機能的に無効化しておく
        If AgentSettings.HideAgentDuringSlideShow AndAlso Not AgentSettings.SpeakSlideNotesDuringSlideShow Then
            _agentForm.HideForSlideShow()
        Else
            _agentForm.PlayConfiguredAnimation("SlideShowBegin")
            _agentForm.StartSlideShowOverlay(wn.Presentation.Slides.Count, wn.View.Slide.SlideIndex)
            SpeakCurrentSlideNotesIfEnabled(wn)
        End If
    End Sub

    ' スライドが切り替わるたびに、オーバーレイのスライド番号・ラップタイムを更新し、
    ' 設定がONならそのスライドのスピーカーノートを読み上げる
    Private Sub OnSlideShowNextSlide(wn As Microsoft.Office.Interop.PowerPoint.SlideShowWindow)
        _activeSlideShowWindow = wn
        If _agentForm Is Nothing Then Return
        _agentForm.NotifySlideShowSlideChanged(wn.View.Slide.SlideIndex)
        SpeakCurrentSlideNotesIfEnabled(wn)
    End Sub

    ' AgentFloatingForm側のBookmarkイベントハンドラから呼ばれる：スピーカーノート中の
    ' <slide op="click|page" dir="next|prev|N"/>タグを、実際のスライドショー操作に変換する。
    ' dirに数値（スライド番号）が指定されていた場合、AgentFloatingForm側でdir="goto"・
    ' indexにその番号が入れられて渡ってくる。この場合はopに関わらず常にGotoSlideで直接
    ' ジャンプする（View.Next()/.Previous()には任意スライドへ跳ぶ手段が無いため）。
    ' dirが"next"／"prev"のときは、opによって挙動が変わる：
    ' op="click"は.View.Next()/.Previous()を使う（現在のスライドに未実行のアニメーション
    ' ビルドが残っていればそれを1つ進め（戻し）、無ければ結果的に次（前）のスライドへ進む＝
    ' 発表者が普段キーボード等で送っているのと同じ挙動）。
    ' op="page"は「純粋なスライド切り替え」としてGotoSlideを使う（現在のスライドに未実行の
    ' アニメーションビルドが残っていても無視して次/前のスライドへ直接移動する）。
    ' （範囲外・スライドショー終了後などは何もしない）
    Private Sub PerformSlideAction(op As String, dir As String, index As Integer)
        Dim wn = _activeSlideShowWindow
        If wn Is Nothing Then Return
        Try
            ' dirが数値（dir="goto"）の場合は、opがclick／pageのどちらでも常にGotoSlideで
            ' 直接ジャンプする（View.Next()/.Previous()には任意スライドへ跳ぶ手段が無いため）
            If dir = "goto" Then
                If index >= 1 AndAlso index <= wn.Presentation.Slides.Count Then wn.View.GotoSlide(index)
                Return
            End If
            If op = "page" Then
                Dim currentIndex = wn.View.Slide.SlideIndex
                Select Case dir
                    Case "next"
                        If currentIndex < wn.Presentation.Slides.Count Then wn.View.GotoSlide(currentIndex + 1)
                    Case "prev", "previous"
                        If currentIndex > 1 Then wn.View.GotoSlide(currentIndex - 1)
                End Select
            Else
                Select Case dir
                    Case "next"
                        wn.View.Next()
                    Case "prev", "previous"
                        wn.View.Previous()
                End Select
            End If
        Catch ex As Exception
            ' スライドショーが既に終了している等、操作できないタイミングであれば黙って無視する
        End Try
    End Sub

    ' AgentFloatingForm側のBookmarkイベントハンドラから呼ばれる：スピーカーノート中の
    ' <screen op="blackout|whiteout|resume"/>タグを、スライドショーウィンドウ自体の
    ' 状態操作に変換する
    Private Sub PerformScreenAction(op As String)
        Dim wn = _activeSlideShowWindow
        If wn Is Nothing Then Return
        Try
            Select Case op
                Case "blackout"
                    wn.View.State = Microsoft.Office.Interop.PowerPoint.PpSlideShowState.ppSlideShowBlackScreen
                Case "whiteout"
                    wn.View.State = Microsoft.Office.Interop.PowerPoint.PpSlideShowState.ppSlideShowWhiteScreen
                Case "resume"
                    wn.View.State = Microsoft.Office.Interop.PowerPoint.PpSlideShowState.ppSlideShowRunning
            End Select
        Catch ex As Exception
            ' スライドショーが既に終了している等、操作できないタイミングであれば黙って無視する
        End Try
    End Sub

    ' AgentFloatingForm側のBookmarkイベントハンドラから呼ばれる：スピーカーノート中の
    ' <laser op="on|off"/>タグを、レーザーポインター表示のON/OFFに変換する。座標指定は
    ' できず（Interopにその手段が無い）、ONにした後の実際の位置は現在のマウス位置に追従する
    Private Sub PerformLaserAction(op As String)
        Dim wn = _activeSlideShowWindow
        If wn Is Nothing Then Return
        Try
            Select Case op
                Case "on"
                    wn.View.LaserPointerEnabled = True
                Case "off"
                    wn.View.LaserPointerEnabled = False
            End Select
        Catch ex As Exception
            ' スライドショーが既に終了している等、操作できないタイミングであれば黙って無視する
        End Try
    End Sub

    ' AgentFloatingForm側のResolveVariablesから呼ばれる：スピーカーノート中の<var name="..."/>
    ' タグに埋め込むPowerPoint固有の値をまとめて返す。個々の値の取得はそれぞれ独立してTryで
    ' 保護し、1つ失敗しても他の値は返せるようにする
    Private Function GetSlideVariables() As Dictionary(Of String, String)
        Dim values As New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)
        Dim wn = _activeSlideShowWindow
        If wn Is Nothing Then Return values

        Try
            values("slideNumber") = wn.View.Slide.SlideIndex.ToString()
            values("slideCount") = wn.Presentation.Slides.Count.ToString()
            values("slidesRemaining") = (wn.Presentation.Slides.Count - wn.View.Slide.SlideIndex).ToString()
        Catch ex As Exception
        End Try

        Try
            ' Presentation.Nameは拡張子付き（例："発表.pptx"）で返るため、読み上げ用途では
            ' 不要な拡張子を取り除く
            values("fileName") = IO.Path.GetFileNameWithoutExtension(wn.Presentation.Name)
        Catch ex As Exception
        End Try

        Try
            values("author") = CStr(wn.Presentation.BuiltInDocumentProperties("Author").Value)
        Catch ex As Exception
        End Try

        Try
            values("slideTitle") = wn.View.Slide.Shapes.Title.TextFrame.TextRange.Text
        Catch ex As Exception
            ' タイトルプレースホルダーが無いスライドでは例外になる
        End Try

        Try
            ' SectionIndex／SectionPropertiesは、このプロジェクトが同梱する古いPIAの型定義には
            ' 無いが（Slide/Presentationクラスをリフレクションで確認済み）、実際にインストール
            ' されているPowerPoint（2010以降）のCOMオブジェクト自体には存在するため、
            ' 遅延バインディング（Option Strict Offの後期バインディング呼び出し）で試す。
            ' セクション未使用のプレゼンテーションや、万一メソッドが本当に無い場合は例外になり、
            ' その場合はsectionNameを設定しない（空のまま）
            Dim lateSlide As Object = wn.View.Slide
            Dim sectionIndex As Integer = lateSlide.SectionIndex
            If sectionIndex >= 1 Then
                Dim latePres As Object = wn.Presentation
                values("sectionName") = latePres.SectionProperties.Name(sectionIndex)
            End If
        Catch ex As Exception
        End Try

        Return values
    End Function

    Private Sub SpeakCurrentSlideNotesIfEnabled(wn As Microsoft.Office.Interop.PowerPoint.SlideShowWindow)
        If Not AgentSettings.SpeakSlideNotesDuringSlideShow Then Return
        ' エージェントが非表示（HideForSlideShowによる発表中非表示・リボンの「終了」操作の
        ' いずれも含む）の間は、読み上げそのものだけでなく、ノート中の<slide>/<screen>/<laser>
        ' タグによるスライド送り・ブラックアウト・レーザーポインター操作も一切行わない。
        ' 「非表示＝エージェント機能は丸ごとOFF」という直感に反し、見えないところで
        ' スライドが勝手に動いてしまう不具合が実機で確認されたため、ここで一括ガードする
        If Not CharacterHostCoordinator.IsVisible(AgentSettings.CharacterId) Then Return

        Dim slideIndex = wn.View.Slide.SlideIndex
        If slideIndex = _lastSpokenSlideNotesIndex Then Return
        _lastSpokenSlideNotesIndex = slideIndex

        Dim notesText = GetSlideNotesText(wn.View.Slide)
        If Not String.IsNullOrWhiteSpace(notesText) Then _agentForm.SpeakSlideNotes(notesText)
    End Sub

    ' ノートプレースホルダーが無いスライド（一度もノートを入力していない等）では
    ' Placeholders(2)へのアクセスが例外になるため、その場合は空文字列として扱う
    Private Function GetSlideNotesText(slide As Microsoft.Office.Interop.PowerPoint.Slide) As String
        Try
            Return slide.NotesPage.Shapes.Placeholders(2).TextFrame.TextRange.Text
        Catch
            Return ""
        End Try
    End Function

    Private Sub OnSlideShowEnd(pres As Microsoft.Office.Interop.PowerPoint.Presentation)
        If _agentForm IsNot Nothing Then
            _agentForm.StopSlideShowOverlay()
            ' 最後のスライドのノート読み上げが終わっていなくても、発表終了のアナウンスを
            ' 優先して即座に始められるよう、読み上げ中のキューを打ち切る
            _agentForm.StopSpeaking()
            ' 発表前の位置へ戻してから（非表示にしていた場合は）再表示する
            _agentForm.RestorePositionAfterSlideShow()
            If AgentSettings.HideAgentDuringSlideShow Then _agentForm.ShowAfterSlideShow()
            _activeSlideShowWindow = Nothing

            ' 発表時間の吹き出しを先に表示してから、その再生キューに続けて
            ' 「スライド終了」アニメーション（既定Congratulate）を再生する
            Dim announced = False
            If _slideShowStopwatch IsNot Nothing Then
                _slideShowStopwatch.Stop()
                _agentForm.AnnouncePresentationTime(_slideShowStopwatch.Elapsed)
                _slideShowStopwatch = Nothing
                announced = True
            End If
            _agentForm.PlayConfiguredAnimation("SlideShowEnd", stopFirst:=Not announced)
        End If
    End Sub

    Private Sub OnOpen(pres As Microsoft.Office.Interop.PowerPoint.Presentation)
        If _agentForm IsNot Nothing Then _agentForm.PlayConfiguredAnimation("Open")
    End Sub

    Private Sub OnBeforeClose(pres As Microsoft.Office.Interop.PowerPoint.Presentation, ByRef cancel As Boolean)
        If _agentForm IsNot Nothing Then _agentForm.PlayConfiguredAnimation("Close")
    End Sub

    Private Sub OnProtectedViewWindowOpen(protViewWindow As Microsoft.Office.Interop.PowerPoint.ProtectedViewWindow)
        If _agentForm IsNot Nothing Then _agentForm.PlayConfiguredAnimation("ProtectedViewWindowOpen")
    End Sub

    Private Sub OnPresentationNewSlide(sld As Microsoft.Office.Interop.PowerPoint.Slide)
        If _agentForm IsNot Nothing Then _agentForm.PlayConfiguredAnimation("PresentationNewSlide")
    End Sub

    Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown
        OfficeAgent.Core.AgentFloatingForm.OpenSettingsPaneAction = Nothing
        OfficeAgent.Core.AgentFloatingForm.GetSelectedTextAction = Nothing
        AgentRibbon.IsSettingsPaneVisibleFunc = Nothing
        AgentRibbon.ToggleSettingsPaneAction = Nothing
        AgentRibbon.InsertSapiTagAction = Nothing
        AgentRibbon.GetSelectedShapeNameFunc = Nothing
        OfficeAgent.Core.AgentFloatingForm.PerformSlideActionAction = Nothing
        OfficeAgent.Core.AgentFloatingForm.PerformScreenActionAction = Nothing
        OfficeAgent.Core.AgentFloatingForm.PerformLaserActionAction = Nothing
        OfficeAgent.Core.AgentFloatingForm.GetSlideVariablesFunc = Nothing
        OfficeAgent.Core.AgentFloatingForm.GetHostWindowHandleFunc = Nothing
        OfficeAgent.Core.AgentFloatingForm.GetSlideShowWindowHandleFunc = Nothing
        OfficeAgent.Core.AgentFloatingForm.GetShapeScreenBoundsFunc = Nothing

        If _settingsTaskPane IsNot Nothing Then
            RemoveHandler _settingsTaskPane.VisibleChanged, AddressOf SettingsPane_VisibleChanged
            _settingsTaskPane = Nothing
        End If

        If _agentForm IsNot Nothing Then
            ' 実際に選ばれているキャラクターが.act（Actor）の場合は、Kyle（AxAgent）ではなく
            ' ActorFloatingForm側にGoodbyeアニメーション再生・非表示を委ねる
            ' （CharacterHostCoordinator.Hide参照。起動時のCharacterHostCoordinator.Showと対）
            OfficeAgent.Core.CharacterHostCoordinator.Hide(AgentSettings.CharacterId, checkOtherApps:=True)
            _agentForm.Dispose()
            _agentForm = Nothing
        End If
    End Sub

End Class
