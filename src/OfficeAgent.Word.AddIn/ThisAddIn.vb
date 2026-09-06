Imports OfficeAgent.Core

Partial Public Class ThisAddIn

    Private _agentForm As OfficeAgent.Core.AgentFloatingForm
    Private _settingsTaskPane As Microsoft.Office.Tools.CustomTaskPane
    Private _saveWatchTimer As System.Windows.Forms.Timer
    Private _saveWatchDoc As Microsoft.Office.Interop.Word.Document
    Private _saveWatchAttemptsLeft As Integer

    Protected Overrides Function CreateRibbonExtensibilityObject() As Microsoft.Office.Core.IRibbonExtensibility
        Return New AgentRibbon()
    End Function

    Private Sub ThisAddIn_Startup() Handles Me.Startup
        OfficeAgent.Core.AssemblyRedirectHelper.EnsureRegistered()

        Dim pane As New OfficeAgent.Core.AgentSettingsPane() With {.HostApp = AnimationEvents.HostApp.Word}
        _settingsTaskPane = Me.CustomTaskPanes.Add(pane, "OfficeAgent 設定")
        _settingsTaskPane.Width = 260
        _settingsTaskPane.Visible = False
        AddHandler _settingsTaskPane.VisibleChanged, AddressOf SettingsPane_VisibleChanged

        OfficeAgent.Core.AgentFloatingForm.OpenSettingsPaneAction = AddressOf ShowSettingsPane
        OfficeAgent.Core.AgentFloatingForm.GetSelectedTextAction = AddressOf GetSelectedText
        AgentRibbon.IsSettingsPaneVisibleFunc = Function() IsSettingsPaneVisible
        AgentRibbon.ToggleSettingsPaneAction = AddressOf ToggleSettingsPane

        AddHandler Me.Application.DocumentBeforeSave, AddressOf OnBeforeSave
        AddHandler Me.Application.DocumentBeforePrint, AddressOf OnBeforePrint
        AddHandler Me.Application.NewDocument, AddressOf OnOpen
        AddHandler Me.Application.DocumentOpen, AddressOf OnOpen
        AddHandler Me.Application.DocumentBeforeClose, AddressOf OnBeforeClose
        AddHandler Me.Application.ProtectedViewWindowOpen, AddressOf OnProtectedViewWindowOpen
        AddHandler Me.Application.WindowActivate, AddressOf OnWindowActivateOrDeactivate

        _agentForm = New OfficeAgent.Core.AgentFloatingForm()
        _agentForm.Show()
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

    ' カイル右クリックの「選択範囲について」から呼ばれる：現在選択中の文字列を返す（未選択・空ならNothing）
    Private Function GetSelectedText() As String
        Try
            Dim text = Me.Application.Selection?.Text
            If String.IsNullOrEmpty(text) Then Return Nothing
            Return text.Trim(vbCr, vbLf, vbTab, " "c)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    ' Word には Application レベルの AfterSave イベントが無いため、SaveAsUI が絡む
    ' （＝ダイアログが出てキャンセルされ得る）保存だけはポーリングで成功を確認してから再生する。
    Private Sub OnBeforeSave(doc As Microsoft.Office.Interop.Word.Document, ByRef saveAsUI As Boolean, ByRef cancel As Boolean)
        ' Wordでの自動保存判定は誤検知が気になるため一旦無効化
        ' If WindowHelper.IsAutoSaveOn(doc) Then Return

        ' If _agentForm IsNot Nothing Then _agentForm.PlayAnimation("GetAttention")

        If Not saveAsUI Then
            If _agentForm IsNot Nothing Then _agentForm.PlayConfiguredAnimation("Save")
            Return
        End If

        _saveWatchDoc = doc
        _saveWatchAttemptsLeft = 75 ' 400ms間隔 × 75 = 30秒でタイムアウト
        If _saveWatchTimer Is Nothing Then
            _saveWatchTimer = New System.Windows.Forms.Timer With {.Interval = 400}
            AddHandler _saveWatchTimer.Tick, AddressOf OnSaveWatchTick
        End If
        _saveWatchTimer.Start()
    End Sub

    Private Sub OnSaveWatchTick(sender As Object, e As EventArgs)
        _saveWatchAttemptsLeft -= 1
        Dim doc = _saveWatchDoc
        Dim stillWatching = doc IsNot Nothing AndAlso _saveWatchAttemptsLeft > 0
        Try
            If doc IsNot Nothing AndAlso doc.Saved Then
                If _agentForm IsNot Nothing Then _agentForm.PlayConfiguredAnimation("Save")
                stillWatching = False
            End If
        Catch ex As Exception
            stillWatching = False
        End Try

        If Not stillWatching Then
            _saveWatchTimer.Stop()
            _saveWatchDoc = Nothing
        End If
    End Sub

    Private Sub OnBeforePrint()
        If _agentForm IsNot Nothing Then _agentForm.PlayConfiguredAnimation("Print")
    End Sub

    Private Sub OnOpen(doc As Microsoft.Office.Interop.Word.Document)
        If _agentForm IsNot Nothing Then _agentForm.PlayConfiguredAnimation("Open")
    End Sub

    Private Sub OnBeforeClose(doc As Microsoft.Office.Interop.Word.Document, ByRef cancel As Boolean)
        If _agentForm IsNot Nothing Then _agentForm.PlayConfiguredAnimation("Close")
    End Sub

    Private Sub OnProtectedViewWindowOpen(pvWindow As Microsoft.Office.Interop.Word.ProtectedViewWindow)
        If _agentForm IsNot Nothing Then _agentForm.PlayConfiguredAnimation("ProtectedViewWindowOpen")
    End Sub

    Private Sub OnWindowActivateOrDeactivate(doc As Microsoft.Office.Interop.Word.Document, wn As Microsoft.Office.Interop.Word.Window)
        If _agentForm IsNot Nothing Then _agentForm.PlayLookAnimationTowardWindow(New IntPtr(CInt(wn.Hwnd)))
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

        If _saveWatchTimer IsNot Nothing Then
            _saveWatchTimer.Stop()
            _saveWatchTimer.Dispose()
            _saveWatchTimer = Nothing
        End If
    End Sub

End Class
