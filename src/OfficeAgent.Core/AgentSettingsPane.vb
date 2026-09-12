Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Linq

Public Class AgentSettingsPane
    Inherits System.Windows.Forms.UserControl

    <DllImport("user32.dll", CharSet:=CharSet.Unicode)>
    Private Shared Function SendMessage(hWnd As IntPtr, msg As Integer, wParam As Integer, lParam As String) As IntPtr
    End Function
    Private Const EM_SETCUEBANNER = &H1501
    Private Const QueryPlaceholder As String = "(検索内容)"

    ' 各要素間の余白
    Private Const GapLabel As Integer = 4
    Private Const GapField As Integer = 14
    Private Const GapSection As Integer = 18

    ' RelayoutForHost()が計算する、動的に表示切替する領域（検索方法より下）の開始Y座標。
    ' 「キャラクター」選択欄や「発表中は非表示にする」チェックボックスの有無で上の高さが変わるため、
    ' ContentTopは固定値ではなくRelayoutForHost()で都度算出する
    Private _contentTop As Integer

    Private _openAiKey As String = String.Empty
    Private _groqKey As String = String.Empty
    Private _prevIndex As Integer = 0
    Private _loading As Boolean = True

    ' 「キャラクター」コンボボックスの項目一覧。探索パス上に見つかった.acsから毎回作り直すため、
    ' 選択中インデックスに対応するキャラクターID（.acsファイル名由来）はこのリストを介して引く
    Private _characters As New List(Of AgentCharacterCatalog.CharacterInfo)

    ' 各ThisAddIn_Startupが生成直後に設定する、自分のアプリ種別。
    ' アニメーション設定グリッドで、そのアプリに関係するイベントだけを表示するために使う
    Public Property HostApp As AnimationEvents.HostApp?

    Public Sub New()
        InitializeComponent()
        ApplyTheme()
        SetupToolTips()
    End Sub

    Private Sub SetupToolTips()
        ToolTipset.SetToolTip(CheckBoxShowOnStartup, "起動時に自動表示")
        ToolTipset.SetToolTip(CheckBoxSound, "動作音を再生")
        ToolTipset.SetToolTip(CheckBoxHideDuringSlideShow, "スライドショー中は非表示")
        ToolTipset.SetToolTip(ComboBoxCharacter, "表示するキャラクターを切替")
        ToolTipset.SetToolTip(ComboBoxSearch, "質問の処理方法（ウェブ検索・Groq・OpenAI）")
        ToolTipset.SetToolTip(LinkAPI, "APIキー取得ページを開く")
        ToolTipset.SetToolTip(TextBoxModel, "例: gpt-4o、llama-3.3-70b-versatile")
        ToolTipset.SetToolTip(CheckBoxIncludeSelection, "選択中のテキストも一緒にAIへ送信")
        ToolTipset.SetToolTip(TextBoxRule, "AIへの指示（プロンプト）")
        ToolTipset.SetToolTip(LinkResetRule, "性格設定を既定の文章に戻す")
        ToolTipset.SetToolTip(ComboBoxDefaultSearchEngine, "既定の検索サイト")
        ToolTipset.SetToolTip(DataGridViewSearchEngines, "検索サイト一覧の編集")
        ToolTipset.SetToolTip(DataGridViewAnimationEvents, "イベントごとのアニメーション設定")
        ToolTipset.SetToolTip(LabelVersion, "クリックでGitHubを開く")

        ColName.ToolTipText = "検索サイトの表示名"
        ColPrefix.ToolTipText = "検索語の前に付くURL部分"
        ColQuery.ToolTipText = "検索語の挿入位置（編集不可）"
        ColSuffix.ToolTipText = "検索語の後に付くURL部分"

        ColAnimEnabled.ToolTipText = "再生するかどうか"
        ColAnimName.ToolTipText = "イベント種別（編集不可）"
        ColAnimAnimation.ToolTipText = "再生するアニメーション"
        ColAnimPreview.ToolTipText = "試しに再生"
    End Sub

    Private Shared Function IsSystemDarkTheme() As Boolean
        Try
            Using key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Themes\Personalize")
                Dim value = key?.GetValue("AppsUseLightTheme")
                If value IsNot Nothing Then Return CInt(value) = 0
            End Using
        Catch
        End Try
        Return False
    End Function

    Private Sub ApplyTheme()
        Dim dark = IsSystemDarkTheme()
        Dim back = If(dark, Color.FromArgb(32, 32, 32), Color.White)
        Dim fieldBack = If(dark, Color.FromArgb(45, 45, 45), Color.White)
        Dim textMain = If(dark, Color.FromArgb(240, 240, 240), Color.FromArgb(50, 49, 48))
        Dim textSub = If(dark, Color.FromArgb(190, 188, 186), Color.FromArgb(96, 94, 92))
        Dim accent = If(dark, Color.FromArgb(76, 180, 255), Color.FromArgb(0, 120, 212))
        Dim separator = If(dark, Color.FromArgb(64, 64, 64), Color.FromArgb(225, 223, 221))
        Dim gridLine = If(dark, Color.FromArgb(64, 64, 64), Color.FromArgb(225, 223, 221))
        Dim headerBack = If(dark, Color.FromArgb(45, 45, 45), Color.FromArgb(243, 242, 241))

        Me.BackColor = back

        SectionAgent.ForeColor = accent
        SectionSearch.ForeColor = accent
        SectionPersonality.ForeColor = accent

        SeparatorAgent.BackColor = separator

        LabelCharacter.ForeColor = textSub
        LabelSearchMethod.ForeColor = textSub
        LabelAPI.ForeColor = textSub
        LabelModel.ForeColor = textSub
        Label1.ForeColor = textSub
        LabelDefaultSearchEngine.ForeColor = textSub
        LabelSearchEngines.ForeColor = textSub
        SectionAnimation.ForeColor = textSub

        CheckBoxSound.ForeColor = textMain
        CheckBoxShowOnStartup.ForeColor = textMain
        CheckBoxHideDuringSlideShow.ForeColor = textMain
        CheckBoxIncludeSelection.ForeColor = textMain

        ComboBoxCharacter.BackColor = fieldBack
        ComboBoxCharacter.ForeColor = textMain
        ComboBoxSearch.BackColor = fieldBack
        ComboBoxSearch.ForeColor = textMain
        ComboBoxDefaultSearchEngine.BackColor = fieldBack
        ComboBoxDefaultSearchEngine.ForeColor = textMain

        TextBoxAPI.BackColor = fieldBack
        TextBoxAPI.ForeColor = textMain
        TextBoxModel.BackColor = fieldBack
        TextBoxModel.ForeColor = textMain
        TextBoxRule.BackColor = fieldBack
        TextBoxRule.ForeColor = textMain

        DataGridViewSearchEngines.BackgroundColor = back
        DataGridViewSearchEngines.GridColor = gridLine
        DataGridViewSearchEngines.DefaultCellStyle.BackColor = fieldBack
        DataGridViewSearchEngines.DefaultCellStyle.ForeColor = textMain
        DataGridViewSearchEngines.DefaultCellStyle.SelectionBackColor = accent
        DataGridViewSearchEngines.DefaultCellStyle.SelectionForeColor = Color.White
        DataGridViewSearchEngines.ColumnHeadersDefaultCellStyle.BackColor = headerBack
        DataGridViewSearchEngines.ColumnHeadersDefaultCellStyle.ForeColor = textSub
        DataGridViewSearchEngines.EnableHeadersVisualStyles = False
        ColQuery.DefaultCellStyle.ForeColor = textSub

        DataGridViewAnimationEvents.BackgroundColor = back
        DataGridViewAnimationEvents.GridColor = gridLine
        DataGridViewAnimationEvents.DefaultCellStyle.BackColor = fieldBack
        DataGridViewAnimationEvents.DefaultCellStyle.ForeColor = textMain
        DataGridViewAnimationEvents.DefaultCellStyle.SelectionBackColor = accent
        DataGridViewAnimationEvents.DefaultCellStyle.SelectionForeColor = Color.White
        DataGridViewAnimationEvents.ColumnHeadersDefaultCellStyle.BackColor = headerBack
        DataGridViewAnimationEvents.ColumnHeadersDefaultCellStyle.ForeColor = textSub
        DataGridViewAnimationEvents.EnableHeadersVisualStyles = False
        ColAnimName.DefaultCellStyle.ForeColor = textSub

        LinkAPI.LinkColor = accent
        LinkResetRule.LinkColor = accent
        LabelVersion.LinkColor = textSub
    End Sub

    ' 探索パス上に見つかった.acsから「キャラクター」コンボボックスの項目を作り直す。
    ' 現在保存されているCharacterIdが一覧に無い場合（.acsが後から削除された等）も、
    ' 一覧の先頭（通常はカイル）を暫定選択にしておく
    Private Sub PopulateCharacterCombo()
        _characters = AgentCharacterCatalog.DiscoverCharacters()
        ComboBoxCharacter.Items.Clear()
        ComboBoxCharacter.BeginUpdate()
        For i = 0 To _characters.Count - 1
            Dim info = _characters(i)
            ' 表示名は、既知のテーブルではなく.acsに実際に埋め込まれた名前を優先する
            ' （一度読み込んだ.acsはAgentCharacterCatalog側でキャッシュされ、以降は再読み込みしない）。
            ' .act（Actor）はAxAgent経由で読めないため常にNothingが返るだけで無駄なので、
            ' DiscoverCharactersが付けた"(Actor)"付きの表示名をそのまま使う
            If info.Format = AgentCharacterCatalog.CharacterFormat.Acs Then
                info.DisplayName = AgentCharacterCatalog.ResolveLiveDisplayName(info)
                _characters(i) = info
            End If
            ComboBoxCharacter.Items.Add(info.DisplayName)
        Next
        ComboBoxCharacter.EndUpdate()

        If ComboBoxCharacter.Items.Count = 0 Then Return
        Dim index = _characters.FindIndex(Function(c) String.Equals(c.Id, AgentSettings.CharacterId, StringComparison.OrdinalIgnoreCase))
        ComboBoxCharacter.SelectedIndex = Math.Max(0, Math.Min(If(index >= 0, index, 0), ComboBoxCharacter.Items.Count - 1))
    End Sub

    Public Sub LoadSettings()
        _loading = True
        ApplyTheme()

        Dim asm = Assembly.GetExecutingAssembly().GetName()
        LabelVersion.Text = asm.Name & " " & asm.Version.ToString()

        _openAiKey = AgentSettings.API_KEY
        _groqKey = AgentSettings.GROQ_API_KEY
        _prevIndex = AgentSettings.AiProvider

        CheckBoxSound.Checked = AgentSettings.DefaultSound
        CheckBoxShowOnStartup.Checked = AgentSettings.ShowOnStartup
        CheckBoxHideDuringSlideShow.Checked = AgentSettings.HideAgentDuringSlideShow
        CheckBoxIncludeSelection.Checked = AgentSettings.IncludeSelectionInSearch
        PopulateCharacterCombo()
        RelayoutForHost()
        TextBoxRule.Text = AgentSettings.GPT_RULE
        LoadSearchEngineGrid()
        UpdateDefaultSearchEngineCombo()
        ComboBoxSearch.SelectedIndex = AgentSettings.AiProvider
        LoadAnimationEventsGrid()

        UpdateModeUI()
        _loading = False
    End Sub

    Private Sub UpdateModeUI()
        Dim isSearchMode = ComboBoxSearch.SelectedIndex = 0

        LabelAPI.Visible = Not isSearchMode
        LinkAPI.Visible = Not isSearchMode
        TextBoxAPI.Visible = Not isSearchMode
        LabelModel.Visible = Not isSearchMode
        TextBoxModel.Visible = Not isSearchMode
        CheckBoxIncludeSelection.Visible = Not isSearchMode
        SectionPersonality.Visible = Not isSearchMode
        Label1.Visible = Not isSearchMode
        TextBoxRule.Visible = Not isSearchMode

        LabelDefaultSearchEngine.Visible = isSearchMode
        ComboBoxDefaultSearchEngine.Visible = isSearchMode
        LabelSearchEngines.Visible = isSearchMode
        DataGridViewSearchEngines.Visible = isSearchMode

        If Not isSearchMode Then
            Select Case ComboBoxSearch.SelectedIndex
                Case 2
                    LabelAPI.Text = "OpenAI API キー"
                    TextBoxAPI.Text = _openAiKey
                    TextBoxModel.Text = AgentSettings.OPENAI_MODEL
                    SendMessage(TextBoxAPI.Handle, EM_SETCUEBANNER, 1, "sk-...")
                    SendMessage(TextBoxModel.Handle, EM_SETCUEBANNER, 1, "例: gpt-4o")
                    ToolTipset.SetToolTip(TextBoxAPI, "OpenAIのAPIキーを入力します（sk-... で始まります）")
                Case Else ' 1 = Groq
                    LabelAPI.Text = "Groq API キー"
                    TextBoxAPI.Text = _groqKey
                    TextBoxModel.Text = AgentSettings.GROQ_MODEL
                    SendMessage(TextBoxAPI.Handle, EM_SETCUEBANNER, 1, "gsk_...")
                    SendMessage(TextBoxModel.Handle, EM_SETCUEBANNER, 1, "例: llama-3.3-70b-versatile")
                    ToolTipset.SetToolTip(TextBoxAPI, "GroqのAPIキーを入力します（gsk_... で始まります）")
            End Select
            LinkAPI.Text = "APIキーの取得"
        End If

        RelayoutDynamic(isSearchMode)
    End Sub

    Private Function StackY(ctrl As Control, y As Integer, gapAfter As Integer) As Integer
        If Not ctrl.Visible Then Return y
        ctrl.Top = y
        Return y + ctrl.Height + gapAfter
    End Function

    ' Agentの設定～検索設定の上部を上から順に詰めて配置する。「発表中は非表示にする」は
    ' PowerPointの場合のみ表示するため、それ以降の要素はホストによって位置が変わる
    Private Sub RelayoutForHost()
        CheckBoxHideDuringSlideShow.Visible = HostApp = AnimationEvents.HostApp.PowerPoint

        Dim y = 14
        y = StackY(SectionAgent, y, 12)
        y = StackY(LabelCharacter, y, GapLabel)
        y = StackY(ComboBoxCharacter, y, GapField)
        y = StackY(CheckBoxShowOnStartup, y, 6)
        y = StackY(CheckBoxSound, y, 6)
        y = StackY(CheckBoxHideDuringSlideShow, y, 6)
        y = StackY(SectionAnimation, y, GapLabel + 6)
        DataGridViewAnimationEvents.Top = y
        y += DataGridViewAnimationEvents.Height + GapField
        SeparatorAgent.Top = y
        y += SeparatorAgent.Height + 9
        y = StackY(SectionSearch, y, GapField + 6)
        y = StackY(LabelSearchMethod, y, GapLabel)
        ComboBoxSearch.Top = y
        y += ComboBoxSearch.Height + GapSection

        _contentTop = y
    End Sub

    Private Sub RelayoutDynamic(isSearchMode As Boolean)
        Dim y = _contentTop
        If isSearchMode Then
            y = StackY(LabelDefaultSearchEngine, y, GapLabel)
            y = StackY(ComboBoxDefaultSearchEngine, y, GapSection)
            y = StackY(LabelSearchEngines, y, GapLabel)
            y = StackY(DataGridViewSearchEngines, y, GapField)
        Else
            y = StackY(LabelAPI, y, GapLabel)
            LinkAPI.Top = LabelAPI.Top + 1
            y = StackY(TextBoxAPI, y, GapField)
            y = StackY(LabelModel, y, GapLabel)
            y = StackY(TextBoxModel, y, GapField)
            y = StackY(CheckBoxIncludeSelection, y, GapSection)
            y = StackY(SectionPersonality, y, GapLabel)
            LinkResetRule.Top = SectionPersonality.Top + 1
            y = StackY(Label1, y, GapLabel)
            y = StackY(TextBoxRule, y, GapField)
        End If
        LabelVersion.Top = y
    End Sub

    Private Sub LoadSearchEngineGrid()
        DataGridViewSearchEngines.Rows.Clear()
        Dim entries = SearchEngines.List
        For i = 0 To entries.GetLength(0) - 1
            DataGridViewSearchEngines.Rows.Add(entries(i, 0), entries(i, 1), QueryPlaceholder, entries(i, 2))
        Next
    End Sub

    Private Sub SaveSearchEngineGrid()
        Dim rows As New Collections.Generic.List(Of String())()
        For Each row As DataGridViewRow In DataGridViewSearchEngines.Rows
            If row.IsNewRow Then Continue For
            Dim name = CStr(If(row.Cells(ColName.Index).Value, "")).Trim()
            Dim prefix = CStr(If(row.Cells(ColPrefix.Index).Value, "")).Trim()
            Dim suffix = CStr(If(row.Cells(ColSuffix.Index).Value, "")).Trim()
            If name.Length = 0 OrElse prefix.Length = 0 Then Continue For
            rows.Add({name, prefix, suffix})
        Next

        If rows.Count = 0 Then
            AgentSettings.SearchEngineListText = ""
        Else
            Dim arr(rows.Count - 1, 2) As String
            For i = 0 To rows.Count - 1
                arr(i, 0) = rows(i)(0)
                arr(i, 1) = rows(i)(1)
                arr(i, 2) = rows(i)(2)
            Next
            AgentSettings.SearchEngineListText = SearchEngines.ToText(arr)
        End If

        AgentFloatingForm.Instance?.UpdateSearchEngineList()
        UpdateDefaultSearchEngineCombo()
    End Sub

    Private Sub LoadAnimationEventsGrid()
        Dim rows = AnimationEvents.GetAll(HostApp, AgentSettings.CharacterId)

        Dim items As New List(Of String)
        Dim animationNames = AgentFloatingForm.Instance?.GetAvailableAnimationNames()
        If animationNames IsNot Nothing Then items.AddRange(animationNames)

        ' カイル・フィンフィン以外の未知キャラクターは、既定アニメーション名がDolphinのもの
        ' （GetAttention/Save等）にフォールバックする。そのキャラクターが同名のアニメーションを
        ' 収録していない場合、セルの値がComboBoxColumnのItemsに存在しなくなりDataErrorの原因になるため、
        ' 実在しない値でも一覧に足しておく（保存された値をそのまま表示・維持できるようにする）
        For Each r In rows
            If Not String.IsNullOrEmpty(r.Animation) AndAlso Not items.Contains(r.Animation, StringComparer.OrdinalIgnoreCase) Then
                items.Add(r.Animation)
            End If
        Next

        ColAnimAnimation.Items.Clear()
        ColAnimAnimation.Items.AddRange(items.ToArray())

        DataGridViewAnimationEvents.Rows.Clear()
        For Each row In rows
            Dim idx = DataGridViewAnimationEvents.Rows.Add(row.Enabled, row.Def.DisplayName, row.Animation)
            DataGridViewAnimationEvents.Rows(idx).Tag = row.Def.EventKey
        Next
    End Sub

    Private Sub SaveAnimationEventsGrid()
        Dim rows As New Collections.Generic.List(Of (EventKey As String, Enabled As Boolean, Animation As String))
        For Each row As DataGridViewRow In DataGridViewAnimationEvents.Rows
            If row.IsNewRow Then Continue For
            Dim eventKey = CStr(row.Tag)
            Dim enabled = CBool(If(row.Cells(ColAnimEnabled.Index).Value, False))
            Dim animation = CStr(If(row.Cells(ColAnimAnimation.Index).Value, ""))
            rows.Add((eventKey, enabled, animation))
        Next
        AnimationEvents.SaveAll(rows, AgentSettings.CharacterId)
    End Sub

    Private Sub UpdateDefaultSearchEngineCombo()
        Dim selectedName = TryCast(ComboBoxDefaultSearchEngine.SelectedItem, String)
        Dim entries = SearchEngines.List

        ComboBoxDefaultSearchEngine.BeginUpdate()
        ComboBoxDefaultSearchEngine.Items.Clear()
        For i = 0 To entries.GetLength(0) - 1
            ComboBoxDefaultSearchEngine.Items.Add(entries(i, 0))
        Next
        ComboBoxDefaultSearchEngine.EndUpdate()

        Dim keepIndex = If(selectedName IsNot Nothing, ComboBoxDefaultSearchEngine.Items.IndexOf(selectedName), -1)
        ComboBoxDefaultSearchEngine.SelectedIndex = If(keepIndex >= 0, keepIndex,
            Math.Max(0, Math.Min(AgentSettings.DefaultSearchEngine, ComboBoxDefaultSearchEngine.Items.Count - 1)))
    End Sub

    Private Sub ComboBoxSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSearch.SelectedIndexChanged
        If _loading Then Return
        SaveCurrentKey()
        _prevIndex = ComboBoxSearch.SelectedIndex
        AgentSettings.AiProvider = ComboBoxSearch.SelectedIndex
        UpdateModeUI()

        Dim form = AgentFloatingForm.Instance
        If form IsNot Nothing Then form.UpdateSearchTooltip()
    End Sub

    Private Sub SaveCurrentKey()
        Select Case _prevIndex
            Case 2 : _openAiKey = TextBoxAPI.Text
            Case 1 : _groqKey = TextBoxAPI.Text
        End Select
    End Sub

    Private Sub CheckBoxSound_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSound.CheckedChanged
        If _loading Then Return
        AgentSettings.DefaultSound = CheckBoxSound.Checked
        Dim form = AgentFloatingForm.Instance
        If form IsNot Nothing Then form.UpdateSoundEffects()
    End Sub

    Private Sub CheckBoxShowOnStartup_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxShowOnStartup.CheckedChanged
        If _loading Then Return
        AgentSettings.ShowOnStartup = CheckBoxShowOnStartup.Checked
    End Sub

    Private Sub CheckBoxHideDuringSlideShow_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxHideDuringSlideShow.CheckedChanged
        If _loading Then Return
        AgentSettings.HideAgentDuringSlideShow = CheckBoxHideDuringSlideShow.Checked
        AgentRibbon.Instance?.InvalidateRibbon()
    End Sub

    Private Sub CheckBoxIncludeSelection_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxIncludeSelection.CheckedChanged
        If _loading Then Return
        AgentSettings.IncludeSelectionInSearch = CheckBoxIncludeSelection.Checked
    End Sub

    ' キャラクター切り替え：設定を保存し、実際に表示中のキャラクターを差し替える。
    ' .acs（Microsoft Agent／AxAgent）と.act（Microsoft Actor／FrontierActorControl）は
    ' 完全に別エンジンのため、選択した形式に応じてどちらのフォームを表示するか切り替え、
    ' 元々表示中だった側は隠す。GPTルール既定文・アニメーション設定グリッドは.acs専用の
    ' 概念（発話タグ・アニメーション名連携）のため、.act選択時は更新しない（フェーズ1では未対応）
    Private Sub ComboBoxCharacter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCharacter.SelectedIndexChanged
        If _loading Then Return
        If ComboBoxCharacter.SelectedIndex < 0 OrElse ComboBoxCharacter.SelectedIndex >= _characters.Count Then Return
        Dim previousCharacter = AgentSettings.CharacterId
        Dim info = _characters(ComboBoxCharacter.SelectedIndex)
        Dim character = info.Id

        Dim succeeded As Boolean
        If info.Format = AgentCharacterCatalog.CharacterFormat.Act Then
            Dim wasAgentVisible = AgentFloatingForm.Instance IsNot Nothing AndAlso AgentFloatingForm.Instance.IsCharacterVisible
            If wasAgentVisible Then AgentFloatingForm.Instance.HideAgent()
            If ActorFloatingForm.Instance Is Nothing Then ActorFloatingForm.Instance = New ActorFloatingForm()
            succeeded = ActorFloatingForm.Instance.SwitchCharacter(info.AcsPath)
            If succeeded AndAlso wasAgentVisible Then ActorFloatingForm.Instance.ShowActorAgent()
        Else
            Dim wasActorVisible = ActorFloatingForm.Instance IsNot Nothing AndAlso ActorFloatingForm.Instance.IsActorVisible
            If wasActorVisible Then ActorFloatingForm.Instance.HideActorAgent()
            succeeded = AgentFloatingForm.Instance IsNot Nothing AndAlso AgentFloatingForm.Instance.SwitchCharacter(character)
            If succeeded AndAlso wasActorVisible Then AgentFloatingForm.Instance.ShowAgent()
        End If

        If Not succeeded Then
            _loading = True
            Dim previousIndex = _characters.FindIndex(Function(c) String.Equals(c.Id, previousCharacter, StringComparison.OrdinalIgnoreCase))
            ComboBoxCharacter.SelectedIndex = Math.Max(0, previousIndex)
            _loading = False
            Return
        End If

        AgentSettings.CharacterId = character

        If info.Format = AgentCharacterCatalog.CharacterFormat.Acs Then
            ' GPTルールがまだ切替前キャラクターの既定文のままなら（＝ユーザーが未編集なら）、
            ' 新しいキャラクターに合わせた既定文に更新する。ユーザーが自分で編集済みの内容は上書きしない
            If TextBoxRule.Text = AgentSettings.DefaultRuleFor(previousCharacter) Then
                AgentSettings.GPT_RULE = AgentSettings.DefaultRuleFor(character)
                _loading = True
                TextBoxRule.Text = AgentSettings.GPT_RULE
                _loading = False
            End If

            LoadAnimationEventsGrid()
        End If
    End Sub

    Private Sub TextBoxAPI_TextChanged(sender As Object, e As EventArgs) Handles TextBoxAPI.TextChanged
        If _loading Then Return
        Select Case ComboBoxSearch.SelectedIndex
            Case 2
                _openAiKey = TextBoxAPI.Text
                AgentSettings.API_KEY = _openAiKey
            Case 1
                _groqKey = TextBoxAPI.Text
                AgentSettings.GROQ_API_KEY = _groqKey
        End Select
    End Sub

    Private Sub TextBoxModel_TextChanged(sender As Object, e As EventArgs) Handles TextBoxModel.TextChanged
        If _loading Then Return
        Select Case ComboBoxSearch.SelectedIndex
            Case 2 : AgentSettings.OPENAI_MODEL = TextBoxModel.Text
            Case 1 : AgentSettings.GROQ_MODEL = TextBoxModel.Text
        End Select
        AgentFloatingForm.Instance?.UpdateSearchTooltip()
    End Sub

    Private Sub TextBoxRule_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRule.TextChanged
        If _loading Then Return
        AgentSettings.GPT_RULE = TextBoxRule.Text
    End Sub

    ' 性格設定（GPTルール）を、現在のキャラクターの既定文章に戻す。
    ' 自由記述で上書きしてしまった内容が消えるため、実行前に確認を挟む
    Private Sub LinkResetRule_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkResetRule.LinkClicked
        Dim confirm = MessageBox.Show(
            "性格設定を既定の文章に戻します。現在の内容は失われます。よろしいですか？",
            "性格設定のリセット", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If confirm <> DialogResult.OK Then Return

        Dim defaultRule = AgentSettings.DefaultRuleFor(AgentSettings.CharacterId)
        AgentSettings.GPT_RULE = defaultRule
        _loading = True
        TextBoxRule.Text = defaultRule
        _loading = False
    End Sub

    Private Sub ComboBoxDefaultSearchEngine_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDefaultSearchEngine.SelectedIndexChanged
        If _loading Then Return
        AgentSettings.DefaultSearchEngine = ComboBoxDefaultSearchEngine.SelectedIndex
        AgentFloatingForm.Instance?.SetDefaultSearchEngine(ComboBoxDefaultSearchEngine.SelectedIndex)
    End Sub

    Private Sub DataGridViewSearchEngines_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewSearchEngines.CellEndEdit
        If _loading Then Return
        SaveSearchEngineGrid()
    End Sub

    Private Sub DataGridViewSearchEngines_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles DataGridViewSearchEngines.UserDeletedRow
        If _loading Then Return
        SaveSearchEngineGrid()
    End Sub

    Private Sub DataGridViewSearchEngines_DefaultValuesNeeded(sender As Object, e As DataGridViewRowEventArgs) Handles DataGridViewSearchEngines.DefaultValuesNeeded
        e.Row.Cells(ColQuery.Index).Value = QueryPlaceholder
    End Sub

    ' チェックボックス列はクリック直後は未コミット状態のため、CellValueChangedが飛ぶよう即座にコミットする
    Private Sub DataGridViewAnimationEvents_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles DataGridViewAnimationEvents.CurrentCellDirtyStateChanged
        If DataGridViewAnimationEvents.IsCurrentCellDirty Then
            DataGridViewAnimationEvents.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub DataGridViewAnimationEvents_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewAnimationEvents.CellValueChanged
        If _loading OrElse e.RowIndex < 0 Then Return
        SaveAnimationEventsGrid()
        AgentRibbon.Instance?.InvalidateRibbon()
    End Sub

    Private Sub DataGridViewAnimationEvents_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewAnimationEvents.CellContentClick
        If e.RowIndex < 0 OrElse e.ColumnIndex <> ColAnimPreview.Index Then Return
        Dim animation = CStr(If(DataGridViewAnimationEvents.Rows(e.RowIndex).Cells(ColAnimAnimation.Index).Value, ""))
        If animation.Length = 0 Then Return
        AgentFloatingForm.Instance?.PlayAnimation(animation)
    End Sub

    ' コンボボックスの上でマウスホイールを回しても選択値が変わらないようにする
    ' （タスクパネルをスクロールしようとして誤って設定が変わってしまうのを防ぐ）
    Private Sub ComboBox_MouseWheel(sender As Object, e As MouseEventArgs) Handles ComboBoxCharacter.MouseWheel, ComboBoxSearch.MouseWheel, ComboBoxDefaultSearchEngine.MouseWheel
        Dim handledArgs = TryCast(e, HandledMouseEventArgs)
        If handledArgs IsNot Nothing Then handledArgs.Handled = True
    End Sub

    Private Sub LabelVersion_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LabelVersion.LinkClicked
        Dim psi As New Diagnostics.ProcessStartInfo("https://github.com/argynnini/OfficeAgent") With {
            .UseShellExecute = True
        }
        Diagnostics.Process.Start(psi)
    End Sub

    Private Sub LinkAPI_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkAPI.LinkClicked
        Dim url = If(ComboBoxSearch.SelectedIndex = 1,
                     "https://console.groq.com/keys",
                     "https://platform.openai.com/api-keys")
        Dim psi As New Diagnostics.ProcessStartInfo(url) With {.UseShellExecute = True}
        Diagnostics.Process.Start(psi)
    End Sub

End Class
