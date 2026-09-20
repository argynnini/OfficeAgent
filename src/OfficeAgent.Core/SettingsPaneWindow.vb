Imports System.Windows.Forms

' カスタムタスクペインが使えないホスト（Visio / Project）向けに、AgentSettingsPaneを
' 単独のツールウィンドウとして表示する。閉じても破棄せず非表示にするだけで、再度開けば同じ窓を使い回す
Public Class SettingsPaneWindow
    Inherits Form

    Private ReadOnly _pane As AgentSettingsPane

    Public Sub New(host As AnimationEvents.HostApp)
        _pane = New AgentSettingsPane() With {.HostApp = host, .Dock = DockStyle.Fill}
        Text = "OfficeAgent 設定"
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        StartPosition = FormStartPosition.CenterScreen
        ShowInTaskbar = False
        ClientSize = New Drawing.Size(280, 600)
        Controls.Add(_pane)
    End Sub

    Public Sub ShowSettings()
        _pane.LoadSettings()
        If Not Visible Then Show()
        Activate()
    End Sub

    Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Hide()
            Return
        End If
        MyBase.OnFormClosing(e)
    End Sub
End Class
