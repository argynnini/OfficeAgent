Imports OfficeAgent.Core

Partial Public Class ThisAddIn

    Private _agentForm As OfficeAgent.Core.AgentFloatingForm
    Private _settingsWindow As OfficeAgent.Core.SettingsPaneWindow

    ' 選択範囲として渡す最大タスク数（大量選択時にAIへの送信量を抑えるため）
    Private Const MaxSelectedTasks As Integer = 200

    Private Sub ThisAddIn_Startup() Handles Me.Startup
        OfficeAgent.Core.AssemblyRedirectHelper.EnsureRegistered()

        Try
            _agentForm = New OfficeAgent.Core.AgentFloatingForm()
        Catch ex As Exception When OfficeAgent.Core.MsAgentRuntimeRecovery.IsMsAgentRuntimeMissing(ex)
            OfficeAgent.Core.MsAgentRuntimeRecovery.HandleMissingRuntime()
            Return
        End Try

        ' Show()より前に登録する（初回表示位置の計算でGetHostWindowHandleFuncが使われるため）
        OfficeAgent.Core.AgentFloatingForm.OpenSettingsPaneAction = AddressOf ShowSettingsPane
        OfficeAgent.Core.AgentFloatingForm.GetSelectedTextAction = AddressOf GetSelectedText
        OfficeAgent.Core.AgentFloatingForm.GetHostWindowHandleFunc = AddressOf GetHostWindowHandle

        _agentForm.Show()
    End Sub

    ' カスタムタスクペインが使えないホストのため、設定は単独のツールウィンドウで表示する
    Public Sub ShowSettingsPane()
        If _settingsWindow Is Nothing OrElse _settingsWindow.IsDisposed Then
            _settingsWindow = New OfficeAgent.Core.SettingsPaneWindow(AnimationEvents.HostApp.Project)
        End If
        _settingsWindow.ShowSettings()
    End Sub

    ' 初回表示位置を「Officeウィンドウがあるモニタ」基準にするため、メインウィンドウハンドルを返す
    Private Function GetHostWindowHandle() As IntPtr
        Try
            Return System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle
        Catch ex As Exception
            Return IntPtr.Zero
        End Try
    End Function

    ' カイル右クリックの「選択範囲について」から呼ばれる：選択中タスクの名前を改行区切りで返す
    Private Function GetSelectedText() As String
        Try
            Dim tasks = Me.Application.ActiveSelection?.Tasks
            If tasks Is Nothing OrElse tasks.Count = 0 OrElse tasks.Count > MaxSelectedTasks Then Return Nothing

            Dim names As New List(Of String)
            For Each t As Microsoft.Office.Interop.MSProject.Task In tasks
                If t IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(t.Name) Then names.Add(t.Name.Trim())
            Next
            Dim text = String.Join(vbLf, names)
            Return If(text.Length = 0, Nothing, text)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown
        OfficeAgent.Core.AgentFloatingForm.OpenSettingsPaneAction = Nothing
        OfficeAgent.Core.AgentFloatingForm.GetSelectedTextAction = Nothing
        OfficeAgent.Core.AgentFloatingForm.GetHostWindowHandleFunc = Nothing

        If _settingsWindow IsNot Nothing Then
            _settingsWindow.Dispose()
            _settingsWindow = Nothing
        End If

        If _agentForm IsNot Nothing Then
            ' 選ばれているキャラクターが.act（Actor）の場合もCharacterHostCoordinatorが振り分ける
            CharacterHostCoordinator.Hide(AgentSettings.CharacterId, checkOtherApps:=True)
            _agentForm.Dispose()
            _agentForm = Nothing
        End If
    End Sub

End Class
