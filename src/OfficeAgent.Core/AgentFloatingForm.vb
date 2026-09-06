Imports System.Runtime.InteropServices
Imports System.Text
Imports OpenAI.Chat
Imports System.Windows.Forms
Imports System.Diagnostics

Public Class AgentFloatingForm
    Inherits Form

    Public Shared Instance As AgentFloatingForm

    ' 各Officeアドイン（ThisAddIn_Startup）が自身の設定用タスクパネルを開く処理を登録する
    ' （カイル右クリックの「設定」から、ホストアプリのタスクパネルを開くために使用）
    Public Shared OpenSettingsPaneAction As Action

    ' 各Officeアドイン（ThisAddIn_Startup）が、ホストアプリで現在選択中のテキストを返す処理を登録する
    ' （カイル右クリックの「選択範囲について」から、選択中の文章をAIに渡すために使用）
    Public Shared GetSelectedTextAction As Func(Of String)

    Protected Overrides ReadOnly Property ShowWithoutActivation As Boolean
        Get
            Return True
        End Get
    End Property

    Public response As String = Nothing
    Private _responseBalloon As ResponseBalloonForm
    Private _responseBalloonWasVisible As Boolean

    ' カイル左クリックで表示する検索吹き出し。「Word起動直後はショートカットが効かない」不具合の
    ' 調査の一環として、AxAgent（MS Agent ActiveX）を抱える本フォームからは完全に分離してある
    Private _searchBalloon As SearchBalloonForm

    ' 発表時間の吹き出し（AnnouncePresentationTime）を一定時間で自動的に閉じるためのタイマー
    Private Const PresentationBalloonLifetimeMs As Integer = 30000
    Private WithEvents _presentationBalloonTimer As New Windows.Forms.Timer With {.Interval = PresentationBalloonLifetimeMs}

    ' Word/Excel/PowerPointの実行ファイル名。キャラクターは複数のOfficeプロセス間で共有されるため、
    ' 「自分のプロセスだけ」ではなくこれらのいずれかが起動中かどうかで判定する
    Private Shared ReadOnly HostProcessNames() As String = {"WINWORD", "EXCEL", "POWERPNT"}

    ' コード中に直接名前で埋め込んでいるアニメーション（Greeting/Goodbye/Thinkingなど）は、
    ' キャラクターによって収録されている名前が異なる（例: FinFinには"Greeting"が無く"Greet"がある）ため、
    ' 論理名からキャラクターごとの実際のアニメーション名を引く小さなテーブルを介して再生する。
    ' 候補を複数指定した場合はその中からランダムに1つを選ぶ（FinFinの登場・帰りに変化をつけるため）
    Private Shared ReadOnly _animationRandom As New Random()

    Private Shared ReadOnly CharacterAnimationOverrides As New Dictionary(Of AnimationEvents.CharacterId, Dictionary(Of String, String())) From {
        {AnimationEvents.CharacterId.Dolphin, New Dictionary(Of String, String()) From {
            {"Greeting", {"Greeting"}},
            {"Goodbye", {"Goodbye"}},
            {"Thinking", {"Thinking"}}
        }},
        {AnimationEvents.CharacterId.FinFin, New Dictionary(Of String, String()) From {
            {"Greeting", {"NestOut", "Show"}},
            {"Goodbye", {"NestIn", "Hide"}},
            {"Thinking", {"Process"}}
        }}
    }

    ' FinFinはTTS音声が割り当てられており、.Speak()を使うと吹き出しの内容を音声でしゃべってしまう
    ' （Dolphinは対応するTTS音声が無いため今まで無音だった）。Think()は音声を一切使わず
    ' 吹き出し（見た目は思考の雲形になる）だけを表示するため、FinFinのときはこちらを使う
    Private Sub SpeakOrThink(text As String)
        With AxAgent.Characters("OfficeAgent")
            If AgentSettings.CharacterId = AnimationEvents.CharacterId.FinFin Then
                .Think(text)
            Else
                .Speak(text)
            End If
        End With
    End Sub

    Private Function ResolveCharacterAnimation(logicalName As String) As String
        Dim table As Dictionary(Of String, String()) = Nothing
        Dim candidates As String() = Nothing
        If CharacterAnimationOverrides.TryGetValue(AgentSettings.CharacterId, table) AndAlso table.TryGetValue(logicalName, candidates) AndAlso candidates.Length > 0 Then
            Return candidates(_animationRandom.Next(candidates.Length))
        End If
        Return logicalName
    End Function

    Function GetWindowMag() As Single
        Using g = Drawing.Graphics.FromHwnd(IntPtr.Zero)
            Return g.DpiX / 96.0F
        End Using
    End Function

    ' 検索吹き出し（SearchBalloonForm）を隠す。AI問い合わせや検索実行後など、
    ' 吹き出しを閉じてOfficeへ視覚的な注意を戻したい場面で呼ぶ。
    ' 一度も表示されておらずウィンドウハンドルが未作成の場合、BeginInvokeが例外を投げるため、
    ' その場合は何もしない（そもそも隠す必要のある表示状態ではない）
    Private Sub HideAndRestoreOfficeFocus()
        If Not _searchBalloon.IsHandleCreated Then Return
        _searchBalloon.BeginInvoke(Sub() _searchBalloon.Hide())
    End Sub

    Public Sub UpdateSoundEffects()
        AxAgent.Characters("OfficeAgent").SoundEffectsOn = AgentSettings.DefaultSound
    End Sub

    ' 検索吹き出し（Search button）のツールチップを更新する。検索吹き出し自体は
    ' 別フォーム（SearchBalloonForm）に分離されているため、そちらへ委譲する
    Public Sub UpdateSearchTooltip()
        _searchBalloon?.SetSearchTooltip(GetSearchTooltip())
    End Sub

    ' 設定タスクパネルで検索エンジン一覧が編集された時に呼ばれる（選択中の項目名を維持する）
    Public Sub UpdateSearchEngineList()
        Dim selectedName = TryCast(SearchEngine.SelectedItem, String)
        PopulateSearchEngineCombo(0)
        If selectedName IsNot Nothing Then
            Dim keepIndex = SearchEngine.Items.IndexOf(selectedName)
            If keepIndex >= 0 Then SearchEngine.SelectedIndex = keepIndex
        End If
        UpdateSearchTooltip()
    End Sub

    ' 設定タスクパネルの「デフォルト検索サイト」で選択が変わった時に呼ばれる
    Public Sub SetDefaultSearchEngine(index As Integer)
        If SearchEngine.Items.Count = 0 Then Return
        SearchEngine.SelectedIndex = Math.Max(0, Math.Min(index, SearchEngine.Items.Count - 1))
    End Sub

    Private Sub PopulateSearchEngineCombo(preferredIndex As Integer)
        Dim engines = SearchEngines.List
        SearchEngine.Items.Clear()
        SearchEngine.BeginUpdate()
        For i = 0 To engines.GetLength(0) - 1
            SearchEngine.Items.Add(engines(i, 0))
        Next
        SearchEngine.EndUpdate()
        SearchEngine.SelectedIndex = Math.Max(0, Math.Min(preferredIndex, SearchEngine.Items.Count - 1))
    End Sub

    Private Function AcsFileNameFor(character As AnimationEvents.CharacterId) As String
        Return If(character = AnimationEvents.CharacterId.FinFin, "FINFIN.ACS", "DOLPHIN.ACS")
    End Function

    ' キャラクターごとの.acsファイルの場所を解決する。
    ' 素のファイル名だけをCharacters.Loadに渡すと、MS Agentが独自に
    ' C:\Windows\msagent\chars を検索してしまう（DOLPHIN.ACSはOS標準でそこに
    ' 存在することが多いため今まで気づかれなかったが、FINFIN.ACSは無いため失敗する）。
    ' そのため、実際にファイルが存在する候補フォルダを順に確認し、見つかった絶対パスを渡す。
    ' インストーラでは.acsをWord/Excel/PowerPoint個別のフォルダに重複配置せず、
    ' 共通の "..\assets"（各アドインの1つ上の階層）にまとめて置く想定なので、
    ' アセンブリと同じフォルダに加えてその候補も探す
    Private Function ResolveAcsPath(character As AnimationEvents.CharacterId) As String
        Dim fileName = AcsFileNameFor(character)
        Dim assemblyDir = IO.Path.GetDirectoryName(GetType(AgentFloatingForm).Assembly.Location)
        Dim appBaseDir = AppDomain.CurrentDomain.BaseDirectory.TrimEnd(IO.Path.DirectorySeparatorChar)

        Dim candidateDirs As New List(Of String) From {
            assemblyDir,
            IO.Path.Combine(assemblyDir, "..\assets"),
            appBaseDir,
            IO.Path.Combine(appBaseDir, "..\assets"),
            Environment.CurrentDirectory
        }

        For Each candidateDir In candidateDirs
            If String.IsNullOrEmpty(candidateDir) Then Continue For
            Dim candidate = IO.Path.Combine(candidateDir, fileName)
            If IO.File.Exists(candidate) Then
                Return candidate
            End If
        Next

        ' どこにも見つからなかった場合のみ、素のファイル名でMS Agent自身の検索に委ねる
        ' （通常はC:\Windows\msagent\charsを見に行くが、ここに来た時点で正規の配置場所には無い）
        Return fileName
    End Function

    Private Sub AgentFloatingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Instance = Me
        _searchBalloon = New SearchBalloonForm(Me)

        ' 設定されているキャラクターの.acsがこのアプリのフォルダに無い場合
        ' （例: FinFin切り替え後、他のOfficeアプリのアドインフォルダにはFINFIN.ACSが未配置）、
        ' 起動時にクラッシュさせずDolphinにフォールバックする
        Dim character = AgentSettings.CharacterId
        Dim acsPath = ResolveAcsPath(character)
        If Not IO.File.Exists(acsPath) Then
            MessageBox.Show(
                $"{AcsFileNameFor(character)} が見つからないため、Dolphinで起動します。" & Environment.NewLine &
                $"想定パス: {acsPath}",
                "OfficeAgent", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            character = AnimationEvents.CharacterId.Dolphin
            AgentSettings.CharacterId = character
            acsPath = ResolveAcsPath(character)
        End If
        AxAgent.Characters.Load("OfficeAgent", acsPath)

        ' キャラクターはOfficeプロセス間で共有されるため、既に他のOfficeアプリが
        ' 表示中であれば、ここで強制的に非表示にしてしまわないようにする
        Dim wasAlreadyVisible = AxAgent.Characters("OfficeAgent").Visible

        With AxAgent.Characters("OfficeAgent")
            .Balloon.Style = 3
            .LanguageID = &H411
            .Balloon.FontCharSet = 128
            .Balloon.Visible = False
            .AutoPopupMenu = False
            .SoundEffectsOn = AgentSettings.DefaultSound
            .IdleOn = True
            If Not wasAlreadyVisible Then
                .Top = (Screen.PrimaryScreen.Bounds.Height - .OriginalHeight - 100) / GetWindowMag()
                .Left = (Screen.PrimaryScreen.Bounds.Width - .OriginalWidth - 50) / GetWindowMag()
            End If
            .Balloon.FontCharSet = 128
            If Not wasAlreadyVisible Then .Hide(True)
        End With

        ShowInTaskbar = False
        FormBorderStyle = FormBorderStyle.None
        StartPosition = FormStartPosition.Manual
        Opacity = 0

        PopulateSearchEngineCombo(AgentSettings.DefaultSearchEngine)
        UpdateSearchTooltip()

        AgentMenu.ShowItemToolTips = True
        SearchEngine.ToolTipText = "検索エンジンを変更します"
        MenuSetting.ToolTipText = "検索方法などを設定します"

        With Animation
            .Items.Add("アニメーション")
            For Each AnimationList In AxAgent.Characters("OfficeAgent").AnimationNames
                .Items.Add(AnimationList)
            Next
            .SelectedIndex = .Items.Count() - 1
        End With

        _responseBalloon = New ResponseBalloonForm()

        ' 「起動時に表示」が有効な場合のみ、Office起動と同時にエージェントを表示する
        If AgentSettings.ShowOnStartup Then
            ShowAgent()
        End If

        ' Loadが完了した後にフォームを隠す（AxAgentホスト自体は画面に見せる必要が無いため）
        BeginInvoke(Sub()
                        Opacity = 1.0  ' TransparencyKeyと競合しないよう先にOpacityを戻す
                        Hide()
                    End Sub)
    End Sub

    ' カイル君が現在画面に表示されているかどうか（リボンの表示/終了ボタン用）
    Public ReadOnly Property IsCharacterVisible As Boolean
        Get
            Return AxAgent.Characters("OfficeAgent").Visible
        End Get
    End Property

    ' Officeが起動したらエージェントを表示（ThisAddIn_Startupから呼ぶ）
    Public Sub ShowAgent()
        With AxAgent.Characters("OfficeAgent")
            If Not .Visible Then
                .Show(True)
                .Play(ResolveCharacterAnimation("Greeting"))
            End If
        End With
    End Sub

    ' スライドショー開始時、非表示にするかどうか元々の表示状態を覚えておくためのフラグ
    Private _wasVisibleBeforeSlideShow As Boolean

    ' PowerPointのスライドショー開始時に呼ぶ（「発表中は非表示にする」設定が有効な場合のみThisAddIn側から呼ばれる）。
    ' 挨拶やGoodbyeのアニメーションを再生せず、吹き出しごと即座に隠す
    Public Sub HideForSlideShow()
        _wasVisibleBeforeSlideShow = AxAgent.Characters("OfficeAgent").Visible
        If Not _wasVisibleBeforeSlideShow Then Return
        _responseBalloon.Hide()
        _searchBalloon.Hide()
        With AxAgent.Characters("OfficeAgent")
            .StopAll()
            .Balloon.Visible = False
            .Hide(True)
        End With
    End Sub

    ' PowerPointのスライドショー終了時に呼ぶ。HideForSlideShowで隠す前に表示されていた場合のみ再表示する
    Public Sub ShowAfterSlideShow()
        If Not _wasVisibleBeforeSlideShow Then Return
        AxAgent.Characters("OfficeAgent").Show(False)
    End Sub

    ' 設定タスクパネルの「キャラクター」欄から呼ばれる：表示中のキャラクター（.acs）を差し替える。
    ' 同じ名前("OfficeAgent")のまま中身だけ入れ替えるので、以降の呼び出し側コードは変更不要。
    ' .acsファイルが見つからない・読み込みに失敗した場合はメッセージを出し、元のキャラクターのまま何もしない
    Public Function SwitchCharacter(character As AnimationEvents.CharacterId) As Boolean
        Dim acsPath = ResolveAcsPath(character)
        If Not IO.File.Exists(acsPath) Then
            MessageBox.Show(
                $"{AcsFileNameFor(character)} が見つかりません。" & Environment.NewLine &
                $"想定パス: {acsPath}" & Environment.NewLine & Environment.NewLine &
                "assetsフォルダに.acsファイルを配置してください。",
                "キャラクターの切り替えに失敗しました", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Dim current = AxAgent.Characters("OfficeAgent")
        Dim wasVisible = current.Visible
        Dim leftPos = current.Left
        Dim topPos = current.Top
        current.StopAll()

        Try
            AxAgent.Characters.Unload("OfficeAgent")
            AxAgent.Characters.Load("OfficeAgent", acsPath)
        Catch ex As Exception
            MessageBox.Show(
                $"{AcsFileNameFor(character)} の読み込みに失敗しました。" & Environment.NewLine & ex.Message,
                "キャラクターの切り替えに失敗しました", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ' 元のキャラクターに戻す（失敗した場合、キャラクターが消えたままにならないように）
            AxAgent.Characters.Load("OfficeAgent", ResolveAcsPath(AgentSettings.CharacterId))
            Return False
        End Try

        With AxAgent.Characters("OfficeAgent")
            .Balloon.Style = 3
            .LanguageID = &H411
            .Balloon.FontCharSet = 128
            .Balloon.Visible = False
            .AutoPopupMenu = False
            .SoundEffectsOn = AgentSettings.DefaultSound
            .IdleOn = True
            .Left = leftPos
            .Top = topPos
            If wasVisible Then
                .Show(False)
            Else
                .Hide(False)
            End If
        End With
        Return True
    End Function

    ' 他のOfficeアプリ（Word/Excel/PowerPoint）がまだ起動中かどうかを確認する
    ' （MS Agentのキャラクターは全プロセスで共有されるため、1つのアプリの終了で
    '   他のアプリがまだ使用中のキャラクターを消してしまわないようにするため）
    Private Function OtherOfficeAppsRunning() As Boolean
        Dim currentId = Process.GetCurrentProcess().Id
        For Each procName In HostProcessNames
            For Each p In Process.GetProcessesByName(procName)
                Using p
                    If p.Id <> currentId Then Return True
                End Using
            Next
        Next
        Return False
    End Function

    ' Officeが終了するときにエージェントを非表示（ThisAddIn_Shutdownから呼ぶ）
    ' checkOtherApps:=True の場合、他のOfficeアプリが起動中であれば
    ' 共有キャラクターへのGoodbye再生・非表示をスキップする
    Public Sub HideAgent(Optional checkOtherApps As Boolean = False)
        _responseBalloon.Hide()
        _searchBalloon.Hide()
        Hide()

        If checkOtherApps AndAlso OtherOfficeAppsRunning() Then
            Return
        End If

        Dim hideRequestId As Integer = -1
        Dim hideCompleted As Boolean = False
        Dim handler As AxAgentObjects._AgentEvents_RequestCompleteEventHandler =
            Sub(sender As Object, e As AxAgentObjects._AgentEvents_RequestCompleteEvent)
                Dim completedRequest = TryCast(e.request, AgentObjects.IAgentCtlRequest)
                If completedRequest IsNot Nothing AndAlso completedRequest.ID = hideRequestId Then hideCompleted = True
            End Sub
        AddHandler AxAgent.RequestComplete, handler

        Try
            With AxAgent.Characters("OfficeAgent")
                .Balloon.Visible = False
                .Play(ResolveCharacterAnimation("Goodbye"))
                hideRequestId = .Hide(True).ID
            End With
            ' HideのRequestCompleteイベント（＝GoodbyeアニメーションとHideが完了した通知）を待つ。
            ' 万一イベントが来ない場合に備え、Visible監視と30秒タイムアウトもフォールバックとして残す
            Dim sw = Diagnostics.Stopwatch.StartNew()
            While Not hideCompleted AndAlso sw.ElapsedMilliseconds < 30000 AndAlso AxAgent.Characters("OfficeAgent").Visible
                Application.DoEvents()
                Threading.Thread.Sleep(16)
            End While
        Finally
            RemoveHandler AxAgent.RequestComplete, handler
        End Try
        Hide()
    End Sub

    ' 検索吹き出し（SearchBalloonForm）から呼ばれる：入力中の合図としてWritingアニメーションを再生する
    Public Sub PlayWritingAnimation()
        With AxAgent.Characters("OfficeAgent")
            .Balloon.Visible = False
            .Play("Writing")
        End With
    End Sub

    ' 検索吹き出し（SearchBalloonForm）の「閉じる」から呼ばれる
    Public Sub StopAndRest()
        Try
            With AxAgent.Characters("OfficeAgent")
                .StopAll()
                .Balloon.Visible = False
                .Play("RestPose")
            End With
        Catch ex As COMException
            ' 全Officeウィンドウ最小化時などAxAgentの描画サーフェスが無効な状態で
            ' 呼ばれることがあるため、失敗は無視する
        End Try
    End Sub

    'Agentクリック時
    Private Sub Agent_ActivateInput(sender As Object, e As AxAgentObjects._AgentEvents_ClickEvent) Handles AxAgent.ClickEvent
        With AxAgent.Characters("OfficeAgent")
            .StopAll()
            .Play("RestPose")
            .Balloon.Visible = False
            Select Case e.button
                Case 1
                    _responseBalloon.Hide()
                    AgentMenu.Hide()
                    _searchBalloon.ShowNear(.Left, .Top, GetWindowMag())
                Case 2
                    Animation.SelectedIndex = Animation.Items.Count() - 1
                    AgentMenu.Show(Cursor.Position.X, Cursor.Position.Y)
                Case 4
                    If response IsNot Nothing Then
                        Clipboard.SetText(response)
                        .Balloon.FontSize = 10
                        HideAndRestoreOfficeFocus()
                        .StopAll()
                        .Balloon.Style = (.Balloon.Style And &HFFFFFF) + (1 * (2 ^ 24))
                        .Balloon.Style = (.Balloon.Style And &HFF00FFFF) + (22 * (2 ^ 16))
                        SpeakOrThink("コピーしました！")
                        .Play("GestureDown")
                    End If
            End Select
        End With
    End Sub

    'Agentドラッグ時
    Private Sub Agent_Dragstart(sender As Object, e As AxAgentObjects._AgentEvents_DragStartEvent) Handles AxAgent.DragStart
        _searchBalloon.Hide()
        _responseBalloonWasVisible = _responseBalloon.Visible
        _responseBalloon.Hide()
    End Sub

    'Agentドラッグ終了時
    Private Sub Agent_DragEnd(sender As Object, e As AxAgentObjects._AgentEvents_DragCompleteEvent) Handles AxAgent.DragComplete
        Dim agL2 = AxAgent.Characters("OfficeAgent").Left
        Dim agT2 = AxAgent.Characters("OfficeAgent").Top
        Dim mag3 = GetWindowMag()
        _searchBalloon.RepositionNear(agL2, agT2, mag3)
        If _responseBalloonWasVisible Then
            _responseBalloon.MoveToAgent(agL2, agT2, mag3)
            _responseBalloon.Show()
        End If
    End Sub

    ' 検索吹き出し（SearchBalloonForm）の検索ボタンから呼ばれる：AIプロバイダ設定に応じて
    ' AIへ問い合わせるか、Webブラウザで検索するかを振り分けて実行する
    Public Async Function ExecuteSearch(searchText As String) As Task
        Net.ServicePointManager.SecurityProtocol = Net.SecurityProtocolType.Tls12 Or Net.SecurityProtocolType.Tls13
        Try
            Dim engineIndex = SearchEngine.SelectedIndex

            If AgentSettings.AiProvider > 0 Then
                Await RunAiQuery(BuildAiPrompt(searchText))
            Else
                ' ウェブ検索（全てUIスレッドで同期実行）
                With AxAgent.Characters("OfficeAgent")
                    HideAndRestoreOfficeFocus()
                    .StopAll()
                    If searchText.Trim = "" Then
                        .Play("RestPose")
                        Return
                    End If
                    If searchText = "お前を消す方法" Then
                        .Balloon.FontSize = 12
                        SpeakOrThink("質問の意味がわかりません。")
                        .Play("wave")
                    End If
                    Dim engines = SearchEngines.List
                    Dim url = engines(engineIndex, 1) & Web.HttpUtility.UrlEncode(searchText.Replace(Environment.NewLine, " ")) & engines(engineIndex, 2)
                    Dim psi As New ProcessStartInfo(url) With {
                        .UseShellExecute = True
                    }
                    Process.Start(psi)
                    .Play("RestPose")
                End With
            End If
        Catch ex As Exception
            ShowSearchError(ex)
        End Try
    End Function

    ' 設定タスクパネルの「検索に選択範囲を含める」が有効な場合、検索吹き出しからの質問に
    ' ホストアプリで現在選択中のテキストを追記する。未選択・機能オフの場合はsearchTextをそのまま返す
    Private Function BuildAiPrompt(searchText As String) As String
        If Not AgentSettings.IncludeSelectionInSearch Then Return searchText

        Dim selectedText = GetSelectedTextAction?.Invoke()
        If String.IsNullOrWhiteSpace(selectedText) Then Return searchText

        If selectedText.Length > MaxSelectionLength Then
            selectedText = selectedText.Substring(0, MaxSelectionLength) & vbCrLf & "…（長いため以降省略）"
        End If
        Return searchText & vbCrLf & vbCrLf & "【選択中のテキスト】" & vbCrLf & selectedText
    End Function

    ' AIプロバイダ（OpenAI/Groq）へ1件問い合わせ、応答をストリーミングで吹き出しに表示する。
    ' 検索吹き出しからの質問・選択範囲コマンドの両方から呼ばれる共通処理
    Private Async Function RunAiQuery(userPrompt As String) As Task
        Dim client = AiChatClientFactory.CreateClient()

        ' Await前のUI操作（UIスレッドで安全）
        With AxAgent.Characters("OfficeAgent")
            HideAndRestoreOfficeFocus()
            _responseBalloon.Hide()
            .StopAll()
            .Play(ResolveCharacterAnimation("Thinking"))
        End With

        Dim messages As New List(Of ChatMessage) From {
            New SystemChatMessage(AgentSettings.GPT_RULE),
            New UserChatMessage(userPrompt)
        }

        ' Await前にエージェント座標を取得
        Dim agL = AxAgent.Characters("OfficeAgent").Left
        Dim agT = AxAgent.Characters("OfficeAgent").Top
        Dim capturedMag = GetWindowMag()

        ' ストリーミング
        Dim fullText As New StringBuilder()
        Dim isFirst = True
        Dim stream = client.CompleteChatStreamingAsync(messages)
        Dim enumerator = stream.GetAsyncEnumerator(Threading.CancellationToken.None)
        While Await enumerator.MoveNextAsync()
            Dim update = enumerator.Current
            Dim chunk = String.Concat(update.ContentUpdate.Select(Function(p) p.Text))
            If chunk.Length > 0 Then
                fullText.Append(chunk)
                If isFirst Then
                    isFirst = False
                    Dim localText = fullText.ToString()
                    BeginInvoke(Sub()
                                    With AxAgent.Characters("OfficeAgent")
                                        .StopAll()
                                        .Play("RestPose")
                                    End With
                                    _responseBalloon.StartResponse(localText, agL, agT, capturedMag)
                                End Sub)
                Else
                    Dim localChunk = chunk
                    BeginInvoke(Sub() _responseBalloon.AppendChunk(localChunk, agL, agT, capturedMag))
                End If
            End If
        End While
        Await enumerator.DisposeAsync()

        Invoke(Sub() response = fullText.ToString())
    End Function

    ' 上限文字数を超える選択範囲は切り詰める（トークン消費・応答時間の抑制のため）
    Private Const MaxSelectionLength As Integer = 8000

    '「選択範囲について」サブメニュー（要約する／翻訳する／解説する／誤字脱字をチェックする）クリック時
    Private Async Sub SelectionCommand_Click(sender As Object, e As EventArgs) _
        Handles MenuSelectionSummarize.Click, MenuSelectionTranslate.Click,
                MenuSelectionExplain.Click, MenuSelectionProofread.Click

        Dim promptPrefix = CStr(DirectCast(sender, ToolStripMenuItem).Tag)

        Net.ServicePointManager.SecurityProtocol = Net.SecurityProtocolType.Tls12 Or Net.SecurityProtocolType.Tls13
        Try
            If AgentSettings.AiProvider = 0 Then
                SpeakNotice("この機能を使うには、設定でChatGPTかGroqを選んでね。")
                Return
            End If

            Dim selectedText = GetSelectedTextAction?.Invoke()
            If String.IsNullOrWhiteSpace(selectedText) Then
                SpeakNotice("先に文章を選択してから使ってね。")
                Return
            End If

            If selectedText.Length > MaxSelectionLength Then
                selectedText = selectedText.Substring(0, MaxSelectionLength) & vbCrLf & "…（長いため以降省略）"
            End If

            Await RunAiQuery(promptPrefix & vbCrLf & vbCrLf & selectedText)
        Catch ex As Exception
            ShowSearchError(ex)
        End Try
    End Sub

    ' PowerPointのスライドショー終了時に発表時間を教えてもらう（ThisAddIn_Startupから登録されたSlideShowEndハンドラから呼ぶ）。
    ' PlayConfiguredAnimation("SlideShowEnd", stopFirst:=False)より前に呼ぶことを想定しており、
    ' このSpeakのキューに続けてアニメーションを再生することで、吹き出し表示後にアニメーションが再生される
    Public Sub AnnouncePresentationTime(elapsed As TimeSpan)
        Dim parts As New List(Of String)
        If elapsed.Hours > 0 Then parts.Add($"{elapsed.Hours}時間")
        If elapsed.Hours > 0 OrElse elapsed.Minutes > 0 Then parts.Add($"{elapsed.Minutes}分")
        parts.Add($"{elapsed.Seconds}秒")
        With AxAgent.Characters("OfficeAgent")
            .StopAll()
            .Balloon.FontSize = 12
            SpeakOrThink($"発表時間は{String.Join("", parts)}でした！お疲れさま！")
        End With

        _presentationBalloonTimer.Stop()
        _presentationBalloonTimer.Start()
    End Sub

    ' 発表時間の吹き出しを表示してから約30秒経ったら自動的に閉じる
    Private Sub PresentationBalloonTimer_Tick(sender As Object, e As EventArgs) Handles _presentationBalloonTimer.Tick
        _presentationBalloonTimer.Stop()
        Try
            AxAgent.Characters("OfficeAgent").Balloon.Visible = False
        Catch ex As COMException
            ' 全Officeウィンドウ最小化時などAxAgentの描画サーフェスが無効な状態で
            ' 呼ばれることがあるため、失敗は無視する
        End Try
    End Sub

    ' カイル君にひとこと吹き出しで喋らせる（選択範囲コマンドが使えない状況の案内用）
    Private Sub SpeakNotice(text As String)
        With AxAgent.Characters("OfficeAgent")
            AgentMenu.Hide()
            HideAndRestoreOfficeFocus()
            .StopAll()
            .Balloon.Visible = False
            .Balloon.FontSize = 12
            SpeakOrThink(text)
            .Play("GetAttention")
        End With
    End Sub

    ' 検索中に発生した例外の内容をクリップボードにコピーしつつダイアログで表示する
    Private Sub ShowSearchError(ex As Exception)
        Dim msg = ex.Message
        Dim inner = ex.InnerException
        While inner IsNot Nothing
            msg &= Environment.NewLine & "→ " & inner.GetType().Name & ": " & inner.Message
            inner = inner.InnerException
        End While
        Invoke(Sub()
                   Clipboard.SetText(msg)
                   MessageBox.Show(msg & Environment.NewLine & Environment.NewLine & "（クリップボードにコピー済み）", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
               End Sub)
    End Sub

    '設定クリック時（ホストアプリのタスクパネルを開く）
    Private Sub MenuSetting_Click(sender As Object, e As EventArgs) Handles MenuSetting.Click
        OpenSettingsPaneAction?.Invoke()
    End Sub

    ' 終了クリック時（VSTOではアプリを終了しない。エージェントを非表示にするだけ）
    Private Sub MenuExit_Click(sender As Object, e As EventArgs) Handles MenuExit.Click
        HideAgent()
    End Sub

    'アニメーション
    Private Sub Animation_Click(sender As Object, e As EventArgs) Handles Animation.DropDownClosed
        With AxAgent.Characters("OfficeAgent")
            .StopAll()
            .Balloon.Visible = False
            HideAndRestoreOfficeFocus()
            AgentMenu.Hide()
            If Animation.Text = "アニメーション" Then
                .Play("RestPose")
            Else
                .Play(Animation.SelectedItem.ToString)
            End If
        End With
    End Sub

    '検索エンジン変更時
    Private Sub SearchEngine_Changed(sender As Object, e As EventArgs) Handles SearchEngine.SelectedIndexChanged
        AgentSettings.DefaultSearchEngine = SearchEngine.SelectedIndex
        UpdateSearchTooltip()
    End Sub

    ' stopFirst:=Falseの場合、StopAll()を呼ばずに現在のキューの末尾に再生を追加する
    ' （吹き出し（Speak）の直後に続けてアニメーションを再生したい場合、間にStopAll()を挟むと
    ' 　Speakのキューごと消えてしまうため）
    Public Sub PlayAnimation(name As String, Optional stopFirst As Boolean = True)
        Try
            With AxAgent.Characters("OfficeAgent")
                If stopFirst Then .StopAll()
                .Play(name)
            End With
        Catch ex As COMException
            ' 全Officeウィンドウ最小化時などAxAgentの描画サーフェスが無効な状態で
            ' 呼ばれることがあるため、アニメーション再生の失敗は無視する
        End Try
    End Sub

    ' 設定タスクパネルの「アニメーション設定」で編集されたeventKeyの設定（有効/無効・アニメーション名）に
    ' 従ってアニメーションを再生する。各ThisAddIn側のイベントハンドラから呼ぶ
    Public Sub PlayConfiguredAnimation(eventKey As String, Optional stopFirst As Boolean = True)
        Dim setting = AnimationEvents.GetSetting(eventKey, AgentSettings.CharacterId)
        If Not setting.Enabled Then Return
        PlayAnimation(setting.Animation, stopFirst)
    End Sub

    ' 設定タスクパネルの「アニメーション」列に候補として表示する、実際に再生可能なアニメーション名の一覧
    Public Function GetAvailableAnimationNames() As String()
        Dim names As New List(Of String)
        For Each n In AxAgent.Characters("OfficeAgent").AnimationNames
            names.Add(CStr(n))
        Next
        names.Sort(StringComparer.OrdinalIgnoreCase)
        Return names.ToArray()
    End Function

    ' targetHwndのウィンドウがエージェント自身より画面上でどちら側にあるかを見て、
    ' Look(Up/Down)(Left/Right)系のアニメーションを再生する。
    ' エージェントの中心Xが対象ウィンドウの幅の範囲内にあれば上下のみ、
    ' 中心Yが対象ウィンドウの高さの範囲内にあれば左右のみ、
    ' どちらでもなければ斜め方向にする。
    ' 注意: このキャラクターは左右が名前と逆になっている（"LookRight"で見た目上は左、
    ' "LookLeft"で見た目上は右を向く）ため、水平方向のトークンだけ反転させている。
    ' 上下方向はそのまま（"LookUp"で見た目上も上）。
    Public Sub PlayLookAnimationTowardWindow(targetHwnd As IntPtr)
        Dim targetBounds = WindowHelper.GetWindowBounds(targetHwnd)
        If targetBounds Is Nothing Then Return

        Dim myCenterX = Me.Left + Me.Width \ 2
        Dim myCenterY = Me.Top + Me.Height \ 2
        Dim targetCenterX = targetBounds.Value.Left + targetBounds.Value.Width \ 2
        Dim targetCenterY = targetBounds.Value.Top + targetBounds.Value.Height \ 2

        Dim horizontalToken = If(targetCenterX < myCenterX, "Right", "Left")
        Dim verticalToken = If(targetCenterY < myCenterY, "Up", "Down")

        Dim withinWidth = myCenterX >= targetBounds.Value.Left AndAlso myCenterX <= targetBounds.Value.Right
        Dim withinHeight = myCenterY >= targetBounds.Value.Top AndAlso myCenterY <= targetBounds.Value.Bottom

        Dim animationName As String
        If withinWidth Then
            animationName = "Look" & verticalToken
        ElseIf withinHeight Then
            animationName = "Look" & horizontalToken
        Else
            animationName = "Look" & verticalToken & horizontalToken
        End If

        PlayAnimation(animationName)
    End Sub

    Private Function GetSearchTooltip() As String
        Select Case AgentSettings.AiProvider
            Case 2 : Return ProviderTooltip("OpenAI", AgentSettings.OPENAI_MODEL)
            Case 1 : Return ProviderTooltip("Groq", AgentSettings.GROQ_MODEL)
            Case Else : Return SearchEngine.Text & " で検索します"
        End Select
    End Function

    Private Function ProviderTooltip(provider As String, model As String) As String
        If String.IsNullOrWhiteSpace(model) Then Return provider & " で検索します"
        Return $"{provider}（{model}）で検索します"
    End Function


End Class
