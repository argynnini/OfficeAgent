Imports AxAgentObjects

Public Class SettingWindow

    ' 設定画面起動時
    Private Sub SettingWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LinkLabelGitHub.Text = My.Application.Info.AssemblyName + " " + My.Application.Info.Version.ToString
        Debug.WriteLine("起動")
        ' 設定読み込み
        CheckBoxSound.Checked = My.Settings.DefaultSound
        If My.Settings.DefaultGPT = True Then
            ComboBoxSearch.SelectedIndex = 0
        Else
            ComboBoxSearch.SelectedIndex = 1
        End If
        TextBoxAPI.Text = My.Settings.API_KEY
        TextBoxRule.Text = My.Settings.GPT_RULE
        If ComboBoxSearch.SelectedIndex = 0 Then
            TextBoxAPI.Enabled = True
            TextBoxRule.Enabled = True
        Else
            TextBoxAPI.Enabled = False
            TextBoxRule.Enabled = False
        End If
        ToolTipset.SetToolTip(CheckBoxSound, "イルカの音を設定します")
        ToolTipset.SetToolTip(TextBoxAPI, "OpenAI API キーを設定します")
        ToolTipset.SetToolTip(TextBoxRule, "Chat GPT のルールを設定します")
        ToolTipset.SetToolTip(ButtonClose, "設定を保存します")
    End Sub


    ' 閉じるボタンクリック時
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        My.Settings.DefaultSound = CheckBoxSound.Checked
        If ComboBoxSearch.SelectedIndex = 0 Then
            My.Settings.DefaultGPT = True
        Else
            My.Settings.DefaultGPT = False
        End If
        My.Settings.API_KEY = TextBoxAPI.Text
        My.Settings.GPT_RULE = TextBoxRule.Text
        Close()
    End Sub

    ' 検索方法変更時
    Private Sub ComboBoxSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSearch.SelectedIndexChanged
        If ComboBoxSearch.SelectedIndex = 0 Then
            TextBoxAPI.Enabled = True
            TextBoxRule.Enabled = True
        Else
            TextBoxAPI.Enabled = False
            TextBoxRule.Enabled = False
        End If
    End Sub

    ' バージョンクリック時
    Private Sub LinkLabelGitHub_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelGitHub.LinkClicked
        Process.Start("https://github.com/argynnini/OfficeAgent")
    End Sub

    ' API取得クリック時
    Private Sub LinkAPI_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkAPI.LinkClicked
        Process.Start("https://openai.com/blog/openai-api")
    End Sub
End Class