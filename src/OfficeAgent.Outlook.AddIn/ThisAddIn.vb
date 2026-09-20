Imports OfficeAgent.Core

Partial Public Class ThisAddIn

    Private _agentForm As OfficeAgent.Core.AgentFloatingForm
    Private _settingsTaskPane As Microsoft.Office.Tools.CustomTaskPane

    ' メール本文を選択範囲扱いで渡すときの最大文字数（長大なスレッドをAIへ送りすぎないため）
    Private Const MaxBodyLength As Integer = 4000

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

    ' Outlookのタスクペインはウィンドウ（Explorer/Inspector）ごとに持つため、
    ' 設定はメインウィンドウ（ActiveExplorer）に表示する。初めて「設定」が開かれるまで生成を遅延させる
    Private Function EnsureSettingsTaskPane() As Microsoft.Office.Tools.CustomTaskPane
        If _settingsTaskPane IsNot Nothing Then Return _settingsTaskPane
        Dim pane As New OfficeAgent.Core.AgentSettingsPane() With {.HostApp = AnimationEvents.HostApp.Outlook}
        _settingsTaskPane = Me.CustomTaskPanes.Add(pane, "OfficeAgent 設定", Me.Application.ActiveExplorer())
        _settingsTaskPane.Width = 260
        Return _settingsTaskPane
    End Function

    ' カイル右クリックの「設定」から呼ばれる：閉じていれば開くだけ（トグルしない）
    Public Sub ShowSettingsPane()
        Try
            Dim pane = EnsureSettingsTaskPane()
            DirectCast(pane.Control, OfficeAgent.Core.AgentSettingsPane).LoadSettings()
            pane.Visible = True
        Catch ex As Exception
            ' ActiveExplorerが無い（Inspectorのみ表示中など）／ペイン破棄済みの場合は、次回作り直せるようにして無視する
            _settingsTaskPane = Nothing
        End Try
    End Sub

    ' 初回表示位置を「Officeウィンドウがあるモニタ」基準にするため、メインウィンドウハンドルを返す
    Private Function GetHostWindowHandle() As IntPtr
        Try
            Return System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle
        Catch ex As Exception
            Return IntPtr.Zero
        End Try
    End Function

    ' カイル右クリックの「選択範囲について」から呼ばれる：
    ' メール編集/閲覧ウィンドウで選択中の文字列、無ければ一覧で選択中のメール本文を返す
    Private Function GetSelectedText() As String
        Try
            Dim inspector = Me.Application.ActiveInspector()
            If inspector IsNot Nothing AndAlso inspector.EditorType = Microsoft.Office.Interop.Outlook.OlEditorType.olEditorWord Then
                Dim text As String = inspector.WordEditor.Application.Selection.Text
                If Not String.IsNullOrWhiteSpace(text) Then Return text.Trim(ControlChars.Cr, ControlChars.Lf, ControlChars.Tab, " "c)
            End If

            Dim explorer = Me.Application.ActiveExplorer()
            If explorer IsNot Nothing AndAlso explorer.Selection.Count > 0 Then
                Dim mail = TryCast(explorer.Selection(1), Microsoft.Office.Interop.Outlook.MailItem)
                If mail IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(mail.Body) Then
                    Dim body = mail.Body.Trim()
                    Return If(body.Length > MaxBodyLength, body.Substring(0, MaxBodyLength), body)
                End If
            End If
        Catch ex As Exception
            ' 選択状態の取得中の一時的なCOM例外は無視する
        End Try
        Return Nothing
    End Function

    Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown
        OfficeAgent.Core.AgentFloatingForm.OpenSettingsPaneAction = Nothing
        OfficeAgent.Core.AgentFloatingForm.GetSelectedTextAction = Nothing
        OfficeAgent.Core.AgentFloatingForm.GetHostWindowHandleFunc = Nothing

        _settingsTaskPane = Nothing

        If _agentForm IsNot Nothing Then
            ' 選ばれているキャラクターが.act（Actor）の場合もCharacterHostCoordinatorが振り分ける
            CharacterHostCoordinator.Hide(AgentSettings.CharacterId, checkOtherApps:=True)
            _agentForm.Dispose()
            _agentForm = Nothing
        End If
    End Sub

End Class
