Imports OfficeAgent.Core

Partial Public Class ThisAddIn

    Private _agentForm As OfficeAgent.Core.AgentFloatingForm
    Private _settingsTaskPane As Microsoft.Office.Tools.CustomTaskPane
    Private _slideShowStopwatch As Diagnostics.Stopwatch

    Protected Overrides Function CreateRibbonExtensibilityObject() As Microsoft.Office.Core.IRibbonExtensibility
        Return New AgentRibbon()
    End Function

    Private Sub ThisAddIn_Startup() Handles Me.Startup
        OfficeAgent.Core.AssemblyRedirectHelper.EnsureRegistered()

        _agentForm = New OfficeAgent.Core.AgentFloatingForm()
        _agentForm.Show()

        Dim pane As New OfficeAgent.Core.AgentSettingsPane() With {.HostApp = AnimationEvents.HostApp.PowerPoint}
        _settingsTaskPane = Me.CustomTaskPanes.Add(pane, "OfficeAgent 設定")
        _settingsTaskPane.Width = 260
        _settingsTaskPane.Visible = False
        AddHandler _settingsTaskPane.VisibleChanged, AddressOf SettingsPane_VisibleChanged

        OfficeAgent.Core.AgentFloatingForm.OpenSettingsPaneAction = AddressOf ShowSettingsPane
        OfficeAgent.Core.AgentFloatingForm.GetSelectedTextAction = AddressOf GetSelectedText
        AgentRibbon.IsSettingsPaneVisibleFunc = Function() IsSettingsPaneVisible
        AgentRibbon.ToggleSettingsPaneAction = AddressOf ToggleSettingsPane

        AddHandler Me.Application.PresentationBeforeSave, AddressOf OnBeforeSave
        AddHandler Me.Application.PresentationSave, AddressOf OnAfterSave
        AddHandler Me.Application.PresentationPrint, AddressOf OnAfterPrint
        AddHandler Me.Application.SlideShowBegin, AddressOf OnSlideShowBegin
        AddHandler Me.Application.SlideShowEnd, AddressOf OnSlideShowEnd
        AddHandler Me.Application.NewPresentation, AddressOf OnOpen
        AddHandler Me.Application.PresentationOpen, AddressOf OnOpen
        AddHandler Me.Application.PresentationBeforeClose, AddressOf OnBeforeClose
        AddHandler Me.Application.ProtectedViewWindowOpen, AddressOf OnProtectedViewWindowOpen
        AddHandler Me.Application.PresentationNewSlide, AddressOf OnPresentationNewSlide
        AddHandler Me.Application.WindowActivate, AddressOf OnWindowActivateOrDeactivate
    End Sub

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
        If _settingsTaskPane Is Nothing Then Return
        Try
            If Not _settingsTaskPane.Visible Then
                DirectCast(_settingsTaskPane.Control, OfficeAgent.Core.AgentSettingsPane).LoadSettings()
                _settingsTaskPane.Visible = True
            Else
                _settingsTaskPane.Visible = False
            End If
        Catch ex As ObjectDisposedException
            _settingsTaskPane = Nothing
        End Try
    End Sub

    ' カイル右クリックの「設定」から呼ばれる：閉じていれば開くだけ（トグルしない）
    Public Sub ShowSettingsPane()
        If _settingsTaskPane Is Nothing Then Return
        Try
            DirectCast(_settingsTaskPane.Control, OfficeAgent.Core.AgentSettingsPane).LoadSettings()
            _settingsTaskPane.Visible = True
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
        If _agentForm Is Nothing Then Return

        If AgentSettings.HideAgentDuringSlideShow Then
            _agentForm.HideForSlideShow()
        Else
            _agentForm.PlayConfiguredAnimation("SlideShowBegin")
        End If
    End Sub

    Private Sub OnSlideShowEnd(pres As Microsoft.Office.Interop.PowerPoint.Presentation)
        If _agentForm IsNot Nothing Then
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

    Private Sub OnWindowActivateOrDeactivate(pres As Microsoft.Office.Interop.PowerPoint.Presentation, wn As Microsoft.Office.Interop.PowerPoint.DocumentWindow)
        If _agentForm IsNot Nothing Then _agentForm.PlayLookAnimationTowardWindow(New IntPtr(CInt(wn.HWND)))
    End Sub

    Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown
        OfficeAgent.Core.AgentFloatingForm.OpenSettingsPaneAction = Nothing
        OfficeAgent.Core.AgentFloatingForm.GetSelectedTextAction = Nothing
        AgentRibbon.IsSettingsPaneVisibleFunc = Nothing
        AgentRibbon.ToggleSettingsPaneAction = Nothing

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
