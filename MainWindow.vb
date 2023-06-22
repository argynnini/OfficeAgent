Imports System.Runtime.InteropServices
Imports OpenAI_API

Public Class MainWindow
    '生命、宇宙、そして万物についての究極の疑問の答え = 42

    Public response As String = Nothing

    <StructLayout(LayoutKind.Sequential)>
    Structure RECT
        Public Left As Integer
        Public Top As Integer
        Public Right As Integer
        Public Bottom As Integer
    End Structure

    'ウィンドウの座標取得API
    <DllImport("user32.dll", EntryPoint:="GetWindowRect")>
    Private Shared Function GetWindowRect(hWnd As Integer, ByRef lpRect As RECT) As Integer
    End Function

    'ウィンドウのプロセスID取得API
    <DllImport("user32.dll", EntryPoint:="GetWindowThreadProcessId")>
    Private Shared Function GetWindowThreadProcessId(<[In]()> hWnd As IntPtr, ByRef lpdwProcessId As Integer) As Integer
    End Function

    'アクティブウィンドウのハンドラ取得API
    <DllImport("user32.dll", EntryPoint:="GetForegroundWindow")>
    Private Shared Function GetForegroundWindow() As IntPtr
    End Function

    'キー入力状態取得API
    <DllImport("user32.dll", EntryPoint:="GetAsyncKeyState")>
    Private Shared Function GetAsyncKeyState(vKey As Keys) As Short
    End Function

    'ウィンドウ検索API
    <DllImport("user32.dll", EntryPoint:="FindWindow")>
    Private Shared Function FindWindow(lpClassName As String, lpWindowName As String) As Integer
    End Function

    'ウィンドウのアイコン化取得API
    <DllImport("user32.dll", EntryPoint:="IsIconic")>
    Private Shared Function IsIconic(hwnd As Long) As Long
    End Function

    '起動監視ソフト名
    Private ReadOnly Watch_Process As String() = New String() {'"OfficeAgent", "AgentSvr",
                                                "WINWORD", "EXCEL", "POWERPNT",
                                                "OUTLOOK", "MSACCESS", "MSPUB",
                                                "VISIO", "ONENOTEIM", "FRONTPAGE",
                                                "INFOPATH"}

    '検索サイト
    Private ReadOnly Search_Name(,) As String = New String(,) {
                                               {"Google", "https://www.google.co.jp/search?q="},
                                               {"Yahoo!", "https://search.yahoo.co.jp/search?p="},
                                               {"YouTube", "https://www.youtube.com/search?q="},
                                               {"ニコニコ動画", "https://www.nicovideo.jp/search/"},
                                               {"Twitter", "https://twitter.com/search?q="},
                                               {"Googleマップ", "https://www.google.com/maps/search/"},
                                               {"Amazon", "https://www.amazon.co.jp/s?k="},
                                               {"楽天市場", "https://search.rakuten.co.jp/search/mall/"},
                                               {"ヤフオク！", "https://auctions.yahoo.co.jp/search/search?p="},
                                               {"メルカリ", "https://www.mercari.com/jp/search/?keyword="},
                                               {"Wikipedia", "https://ja.wikipedia.org/wiki/"}}

    '起動時
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AxAgent.Characters.Load("OfficeAgent", "DOLPHIN.ACS") 'DOLPHIN.ACSを読み込み
        With AxAgent.Characters("OfficeAgent") 'Agentに対して
            .Balloon.Style = 3 '吹き出しの表示スタイルを設定
            .LanguageID = &H411 '言語を日本語に設定
            .Balloon.FontCharSet = 128 '吹き出しのフォントを日本語に設定
            .Balloon.Visible = False '吹き出しを非表示にする
            .AutoPopupMenu = False 'デフォルトの右クリックメニューを無効にする
            .SoundEffectsOn = True '音を有効にする
            .Top = Screen.PrimaryScreen.Bounds.Height - .OriginalHeight - 100 'AgentのY座標をスクリーンの高さ-Agentの高さ-100に設定
            .Left = Screen.PrimaryScreen.Bounds.Width - .OriginalWidth - 50 'AgentのX座標をスクリーンの幅-Agentの幅-50に設定
            .Balloon.FontCharSet = 128
            .Hide(True) 'イルカを出す
        End With 'Agentに対して終了
        ShowInTaskbar = False 'タスクバーに非表示
        FormBorderStyle = FormBorderStyle.None 'フォームの境界線をなくす
        Size = New Size(300, 170) '大きさを変更
        StartPosition = FormStartPosition.Manual 'フォームの表示位置をマニュアルに設定
        Location = New Point(AxAgent.Characters("OfficeAgent").Left - 150,
                             AxAgent.Characters("OfficeAgent").Top - 150) 'Agentを表示
        Search.BackColor = Color.FromArgb(255, 255, 154) '検索ボタンの背景色を設定
        CloseApp.BackColor = Color.FromArgb(255, 255, 154) '閉じるボタンの背景色を設定
        Label1.BackColor = Color.FromArgb(255, 255, 154) '検索ボタンの背景色を設定
        Dim bmp As New Bitmap(My.Resources.Ballon) '画像を読み込む
        Dim transColor As Color = bmp.GetPixel(0, 0) '透明にする色
        bmp.MakeTransparent(transColor) '画像を透明に
        BackgroundImage = bmp '背景画像を指定
        BackColor = transColor '背景色を指定
        TransparencyKey = transColor '透明を指定
        TopMost = True '一番手前に表示
        Hide()
        AxAgent.Characters("OfficeAgent").SoundEffectsOn = My.Settings.DefaultSound
        SearchEngine.Items.Clear()
        SearchEngine.BeginUpdate() '再描画しないようにする
        For i = 0 To (Search_Name.Length / 2) - 1
            SearchEngine.Items.Add(Search_Name(i, 0)) '配列の内容を一つ一つ追加する
        Next
        SearchEngine.EndUpdate() '再描画するようにする
        SearchEngine.SelectedIndex = My.Settings.DefaultSearchEngine
        If My.Settings.DefaultGPT Then
            ToolTip.SetToolTip(Search, "Chat GPT で検索します")
        Else
            ToolTip.SetToolTip(Search, SearchEngine.Text.ToString & " で検索します")
        End If
        ToolTip.SetToolTip(CloseApp, "吹き出しを閉じます")
        AgentMenu.ShowItemToolTips = True
        SearchEngine.ToolTipText = "検索エンジンを変更します"
        MenuSetting.ToolTipText = "検索方法などを設定します"
        NotifyIcon.ContextMenuStrip = AgentMenu
        With Animation 'アニメーションボタン
            .Items.Add("アニメーション") 'アニメーション（何もしない）を追加
            For Each AnimationList In AxAgent.Characters("OfficeAgent").AnimationNames 'イルカのアニメーションを登録
                .Items.Add(AnimationList)
            Next
            .SelectedIndex = .Items.Count() - 1 'アニメーションを既定の選択にする
        End With
        Opacity = 0
        KeyPreview = True
        Timer1.Start()
    End Sub

    '検索ボックス入力時
    Private Sub SearchBox_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs） Handles SearchBox.KeyPress
        If e.KeyChar = vbCr Then e.Handled = True
    End Sub

    '検索ボックス入力時
    Private Sub SearchBox_TextUpdate(ByVal sender As Object, ByVal e As EventArgs） Handles SearchBox.KeyPress
        With AxAgent.Characters("OfficeAgent")
            .Balloon.Visible = False
            .Play("Writing")
        End With
    End Sub

    'Agentクリック時
    Private Sub Agent_ActivateInput(sender As Object, e As AxAgentObjects._AgentEvents_ClickEvent) Handles AxAgent.ClickEvent
        With AxAgent.Characters("OfficeAgent")
            .StopAll()
            .Play("RestPose")
            .Balloon.Visible = False
        End With
        Select Case e.button
            Case 1 '左クリック時
                Location = New Point(AxAgent.Characters("OfficeAgent").Left - 150, AxAgent.Characters("OfficeAgent").Top - 150)
                AgentMenu.Hide()
                Me.Opacity = 100
                Show()
                Exit Select
            Case 2 '右クリック時
                Animation.SelectedIndex = Animation.Items.Count() - 1 'アニメーションを既定の選択にする
                AgentMenu.Show(Cursor.Position.X, Cursor.Position.Y)
                Exit Select
            Case 4 '真中クリック時
                Clipboard.SetText(response)
                AxAgent.Characters("OfficeAgent").Play("GestureDown")
                Exit Select
        End Select
    End Sub

    'Agentドラッグ時
    Private Sub Agent_Dragstart(sender As Object, e As AxAgentObjects._AgentEvents_DragStartEvent) Handles AxAgent.DragStart
        AxAgent.Characters("OfficeAgent").Balloon.Visible = False
        Hide()
    End Sub

    'Agentドラッグ終了時
    Private Sub Agent_DragEnd(sender As Object, e As AxAgentObjects._AgentEvents_DragCompleteEvent) Handles AxAgent.DragComplete
        Location = New Point(AxAgent.Characters("OfficeAgent").Left - 150, AxAgent.Characters("OfficeAgent").Top - 150)
        'Show()
    End Sub

    '検索クリック時
    Private Async Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        With AxAgent.Characters("OfficeAgent")
            If My.Settings.DefaultGPT Then ' GPTのとき
                ' APIキー
                Dim api = New OpenAIAPI(apiKeys:=My.Settings.API_KEY)
                Dim chat = api.Chat.CreateConversation()

                ' イルカのふりをさせる
                chat.AppendSystemMessage(My.Settings.GPT_RULE)

                ' 質問
                chat.AppendUserInput(SearchBox.Text.ToString)

                .Balloon.FontSize = 10
                Hide()
                .StopAll()
                ' バルーンの表示文字数変更(行数の値は 1 ~ 128 で、1 行あたりの文字数は 8 から 255 の範囲にする必要があります。)
                .Balloon.Style = (.Balloon.Style And &HFFFFFF) + (1 * (2 ^ 24)) ' 行数
                .Balloon.Style = (.Balloon.Style And &HFF00FFFF) + (20 * (2 ^ 16)) ' 文字数(日本語の場合半分になる)
                .Think("考え中．．．")
                .Play("Thinking")

                ' 回答
                response = Await chat.GetResponseFromChatbotAsync()
                .Balloon.FontSize = 12
                Hide()
                .StopAll()
                .Play("RestPose")
                ' バルーンの表示文字数変更(行数の値は 1 ~ 128 で、1 行あたりの文字数は 8 から 255 の範囲にする必要があります。)
                .Balloon.Style = (.Balloon.Style And &HFFFFFF) + (50 * (2 ^ 24)) ' 行数
                .Balloon.Style = (.Balloon.Style And &HFF00FFFF) + (64 * (2 ^ 16)) ' 文字数(日本語の場合半分になる)
                ' しゃべる
                .Speak(response)

                Console.WriteLine(response) ' 回答内容

            Else ' 普通に検索のとき
                Hide()
                .StopAll()
                If SearchBox.Text.Trim = "" Then
                    .Play("RestPose")
                    Return
                End If
                If SearchBox.Text = "お前を消す方法" Then
                    Hide()
                    .Balloon.FontSize = 12
                    .Speak("質問の意味がわかりません。")
                    .Play("wave")
                End If
                '選択された検索エンジン
                Debug.WriteLine(SearchEngine.SelectedIndex)
                Process.Start(Search_Name(SearchEngine.SelectedIndex, 1).ToString & Web.HttpUtility.UrlEncode(SearchBox.Text.ToString))
                .Play("RestPose")
            End If
        End With
    End Sub

    '閉じるクリック時
    Private Sub Close_Click(sender As Object, e As EventArgs) Handles CloseApp.Click
        With AxAgent.Characters("OfficeAgent")
            .StopAll()
            .Balloon.Visible = False
            .Play("RestPose")
        End With
        Hide()
    End Sub

    '設定クリック時
    Private Sub MenuSetting_Click(sender As Object, e As EventArgs) Handles MenuSetting.Click
        SettingWindow.Show()
        ' フォーム閉じるハンドラ作成
        AddHandler SettingWindow.FormClosed, AddressOf SettingWindow_FormClosed
    End Sub

    ' 設定の閉じるクリック時
    Private Sub SettingWindow_FormClosed(sender As Object, e As FormClosedEventArgs)
        AxAgent.Characters("OfficeAgent").SoundEffectsOn = My.Settings.DefaultSound
    End Sub

    '終了クリック時
    Private Sub MenuExit_Click(sender As Object, e As EventArgs) Handles MenuExit.Click
        Hide()
        AgentMenu.Hide()
        Timer1.Stop()
        With AxAgent.Characters("OfficeAgent")
            .StopAll()
            .Balloon.Visible = False
            .Play("GoodBye")
            .Hide(True)
        End With
        Do While AxAgent.Characters("OfficeAgent").Visible = True
            Threading.Thread.Sleep(50)
        Loop
        Application.Exit()
    End Sub

    'アニメーション
    Private Sub Animation_Click(sender As Object, e As EventArgs) Handles Animation.DropDownClosed
        With AxAgent.Characters("OfficeAgent")
            .StopAll()
            .Balloon.Visible = False 'イルカの吹き出しを隠す
            Hide()
            AgentMenu.Hide()
            If Animation.Text = "アニメーション" Then
                .Play("RestPose")
                Exit Sub
            Else
                .Play(Animation.SelectedItem.ToString)
            End If
        End With
    End Sub

    'タスクアイコンクリック時
    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon.MouseClick
        If e.Button = MouseButtons.Left Then
            With AxAgent.Characters("OfficeAgent")
                .Balloon.Visible = False
                .StopAll()
                .Play("RestPose")
            End With
            If Visible = False Then
                Show()
            Else Hide()
            End If
        End If
    End Sub

    '検索エンジン変更時
    Private Sub SearchEngine_Changed(sender As Object, e As EventArgs) Handles SearchEngine.SelectedIndexChanged
        My.Settings.DefaultSearchEngine = SearchEngine.SelectedIndex
        My.Settings.Save()
        If My.Settings.DefaultGPT Then
            ToolTip.SetToolTip(Search, "Chat GPT で検索します")
        Else
            ToolTip.SetToolTip(Search, SearchEngine.Text.ToString & " で検索します")
        End If
    End Sub

    '検索ボックス選択時
    Private Sub TextBox_Active(sender As Object, e As EventArgs) Handles SearchBox.GotFocus, SearchBox.MouseClick
        SearchBox.SelectAll()
    End Sub

    'アプリ起動監視
    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim process_is_launch As Boolean = False
        For Each var In Watch_Process
            process_is_launch = process_is_launch Or (Process.GetProcessesByName(var).Length > 0)
        Next
        If process_is_launch = True Then
            If AxAgent.Characters("OfficeAgent").Visible = False Then 'イルカが既出でない場合
                With AxAgent.Characters("OfficeAgent")
                    .Show(True) 'イルカを出す
                    .Play("Greeting")
                End With
            End If
            Timer1.Interval = 150
            Dim ProcessID As IntPtr = 0
            Dim udtWindowRect As RECT
            GetWindowRect(GetForegroundWindow(), udtWindowRect)     'アクティブウィンドウの座標取得
            GetWindowThreadProcessId(GetForegroundWindow(), ProcessID)     'アクティブウィンドウの取得
            With udtWindowRect
                'Debug.WriteLine(Process.GetProcessById(ProcessID).ProcessName &
                '                ".exe (" & .Left & "," & .Top & ")-" & "(" & .Right & "," & .Bottom & ")")
            End With
            If 0 <= Array.IndexOf(Watch_Process, Process.GetProcessById(ProcessID).ProcessName) Then 'ウィンドウがアクティブのとき
                If GetAsyncKeyState(Keys.ControlKey) < 0 And GetAsyncKeyState(Keys.S) < 0 Then     '保存
                    With AxAgent.Characters("OfficeAgent")
                        .StopAll()
                        .Play("Save")
                    End With
                ElseIf GetAsyncKeyState(Keys.ControlKey) < 0 And GetAsyncKeyState(Keys.P) < 0 Then '印刷
                    With AxAgent.Characters("OfficeAgent")
                        .StopAll()
                        .Play("Print")
                    End With
                ElseIf GetAsyncKeyState(Keys.ControlKey) < 0 And GetAsyncKeyState(Keys.A) < 0 Then '全選択
                    With AxAgent.Characters("OfficeAgent")
                        .StopAll()
                        .Play("LookUp")
                    End With
                ElseIf GetAsyncKeyState(Keys.ControlKey) < 0 And GetAsyncKeyState(Keys.O) < 0 Then '開く
                    With AxAgent.Characters("OfficeAgent")
                        .StopAll()
                        .Play("GetAttention")
                        .Play("GetAttention")
                    End With
                ElseIf GetAsyncKeyState(Keys.ControlKey) < 0 And GetAsyncKeyState(Keys.F) < 0 Then '検索
                    With AxAgent.Characters("OfficeAgent")
                        .StopAll()
                        .Play("Processing")
                    End With
                ElseIf GetAsyncKeyState(Keys.ControlKey) < 0 And GetAsyncKeyState(Keys.N) < 0 Then '新規
                    With AxAgent.Characters("OfficeAgent")
                        .StopAll()
                        .Play("Alert")
                    End With
                ElseIf GetAsyncKeyState(Keys.ControlKey) < 0 And GetAsyncKeyState(Keys.W) < 0 Then '閉切
                    With AxAgent.Characters("OfficeAgent")
                        .StopAll()
                        .Play("GetWizardy")
                    End With
                ElseIf GetAsyncKeyState(Keys.ControlKey) < 0 And GetAsyncKeyState(Keys.D) < 0 Then '複製
                    With AxAgent.Characters("OfficeAgent")
                        .StopAll()
                        .Play("GestureRight")
                    End With
                    'ElseIf GetAsyncKeyState(Keys.ControlKey) < 0 And GetAsyncKeyState(Keys.C) < 0 Then '複写
                    '    With AxAgent.Characters("OfficeAgent")
                    '        .StopAll()
                    '        .Play("Alert")
                    '    End With
                ElseIf GetAsyncKeyState(Keys.ControlKey) < 0 And GetAsyncKeyState(Keys.X) < 0 Then '切取
                    With AxAgent.Characters("OfficeAgent")
                        .StopAll()
                        .Play("LookRight")
                    End With
                    'ElseIf GetAsyncKeyState(Keys.ControlKey) < 0 And GetAsyncKeyState(Keys.V) < 0 Then '貼付
                    '    With AxAgent.Characters("OfficeAgent")
                    '        .StopAll()
                    '        .Play("LookRight")
                    '    End With
                ElseIf GetAsyncKeyState(Keys.ControlKey) < 0 And GetAsyncKeyState(Keys.Y) < 0 Then '再度
                    With AxAgent.Characters("OfficeAgent")
                        .StopAll()
                        .Play("GestureDown")
                    End With
                ElseIf GetAsyncKeyState(Keys.F1) < 0 Then                                          '援助
                    With AxAgent.Characters("OfficeAgent")
                        .StopAll()
                        .Play("Explain")
                    End With
                ElseIf GetAsyncKeyState(Keys.F12) < 0 Then                                         '名前をつけて保存
                    With AxAgent.Characters("OfficeAgent")
                        .StopAll()
                        .Play("Wave")
                    End With
                End If
            End If
        Else
            If AxAgent.Characters("OfficeAgent").Visible = True Then 'イルカが既出な場合
                With AxAgent.Characters("OfficeAgent")
                    .Balloon.Visible = False
                    .Play("Goodbye")
                    .Hide(True) 'イルカを隠す
                End With
            End If
            Hide() '吹き出しを隠す
            Timer1.Interval = 800
        End If
    End Sub
End Class