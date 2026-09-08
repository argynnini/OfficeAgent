Imports OfficeAgent.Core

Partial Public Class ThisAddIn

    Private _agentForm As OfficeAgent.Core.AgentFloatingForm
    Private _settingsTaskPane As Microsoft.Office.Tools.CustomTaskPane
    Private _slideShowStopwatch As Diagnostics.Stopwatch

    ' SlideShowNextSlideイベントは、1回のスライド送りに対して複数回連続で発火することがある
    ' （PowerPoint Interopの既知の癖）。同じスライドに対してSpeakSlideNotes（内部でStopAll→Speak
    ' し直す）が短時間に連続で呼ばれると、SAPIエンジン側の再生位置がずれて冒頭が読まれず
    ' 後半だけ聞こえる、という症状が起きるため、直前に読み上げたスライド番号を覚えておき
    ' 同じスライドに対する重複呼び出しをスキップする
    Private _lastSpokenSlideNotesIndex As Integer = -1

    Protected Overrides Function CreateRibbonExtensibilityObject() As Microsoft.Office.Core.IRibbonExtensibility
        Return New AgentRibbon()
    End Function

    Private Sub ThisAddIn_Startup() Handles Me.Startup
        OfficeAgent.Core.AssemblyRedirectHelper.EnsureRegistered()

        _agentForm = New OfficeAgent.Core.AgentFloatingForm()
        _agentForm.Show()

        OfficeAgent.Core.AgentFloatingForm.OpenSettingsPaneAction = AddressOf ShowSettingsPane
        OfficeAgent.Core.AgentFloatingForm.GetSelectedTextAction = AddressOf GetSelectedText
        AgentRibbon.IsSettingsPaneVisibleFunc = Function() IsSettingsPaneVisible
        AgentRibbon.ToggleSettingsPaneAction = AddressOf ToggleSettingsPane
        AgentRibbon.InsertSapiTagAction = AddressOf InsertSapiTagIntoSelection

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
        If _agentForm Is Nothing Then Return

        If AgentSettings.HideAgentDuringSlideShow Then
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
        If _agentForm Is Nothing Then Return
        _agentForm.NotifySlideShowSlideChanged(wn.View.Slide.SlideIndex)
        SpeakCurrentSlideNotesIfEnabled(wn)
    End Sub

    Private Sub SpeakCurrentSlideNotesIfEnabled(wn As Microsoft.Office.Interop.PowerPoint.SlideShowWindow)
        If Not AgentSettings.SpeakSlideNotesDuringSlideShow Then Return

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
            If AgentSettings.HideAgentDuringSlideShow Then _agentForm.ShowAfterSlideShow()

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

        If _settingsTaskPane IsNot Nothing Then
            RemoveHandler _settingsTaskPane.VisibleChanged, AddressOf SettingsPane_VisibleChanged
            _settingsTaskPane = Nothing
        End If

        If _agentForm IsNot Nothing Then
            _agentForm.HideAgent(checkOtherApps:=True)
            _agentForm.Dispose()
            _agentForm = Nothing
        End If
    End Sub

End Class
