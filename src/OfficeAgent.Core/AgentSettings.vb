Imports Microsoft.Win32

Public Class AgentSettings

    Private Const RegPath As String = "SOFTWARE\OfficeAgent"

    Private Const DefaultRuleDolphin As String = "あなたはOfficeアシスタントのイルカのカイル君です。Word・Excel・PowerPointの操作方法や、文章作成・資料作成・表計算に関する質問に答えたり、ちょっとした雑談相手になったりします。一人称は必ず「僕」です、質問者に対して友達のような口調で回答します。「お前を消す方法」と質問されたときは、右クリックして終了を押すことでイルカのカイル君、つまりあなたを消せることをさりげなく伝えつつ、消されたくない気持ちや自分の魅力を軽くアピールしてください。回答は必ずMarkdown形式で返してください。"

    ' カイル以外（フィンフィンを含む、探索パスで見つかった任意の.acs）は、専用の人格設定文を
    ' 持たないため汎用テンプレートにキャラクターの表示名を差し込んで使う。ACSにDescription
    ' （紹介文）が埋め込まれていれば、それも一言添えることでそのキャラクターらしい人格に近づける。
    ' 一人称「僕」指定・友達口調・「消す方法」を聞かれた時の振る舞いはカイル固有の作り込みなので、
    ' 汎用テンプレートには含めない
    Private Shared Function DefaultRuleGeneric(displayName As String, description As String) As String
        Dim descriptionClause = If(String.IsNullOrWhiteSpace(description), "", $"{description}という設定のキャラクターです。")
        Return $"あなたはOfficeアシスタントの「{displayName}」です。{descriptionClause}Word・Excel・PowerPointの操作方法や、文章作成・資料作成・表計算に関する質問に答えたり、ちょっとした雑談相手になったりします。回答は必ずMarkdown形式で返してください。"
    End Function

    ' キャラクターごとの既定のGPTルール文（カイルだけ専用の人格文を持つ。それ以外は汎用テンプレート）
    Public Shared Function DefaultRuleFor(character As String) As String
        If String.Equals(character, OfficeAgent.Core.AnimationEvents.CharacterDolphin, StringComparison.OrdinalIgnoreCase) Then Return DefaultRuleDolphin
        Return DefaultRuleGeneric(
            OfficeAgent.Core.AgentCharacterCatalog.ResolveLiveDisplayName(character),
            OfficeAgent.Core.AgentCharacterCatalog.ResolveLiveDescription(character))
    End Function

    Public Shared Property DefaultSearchEngine As Integer
        Get
            Return CInt(GetValue("DefaultSearchEngine", 0))
        End Get
        Set(value As Integer)
            SetValue("DefaultSearchEngine", value)
        End Set
    End Property

    Public Shared Property DefaultSound As Boolean
        Get
            Return CBool(GetValue("DefaultSound", True))
        End Get
        Set(value As Boolean)
            SetValue("DefaultSound", value)
        End Set
    End Property

    Public Shared Property ShowOnStartup As Boolean
        Get
            Return CBool(GetValue("ShowOnStartup", True))
        End Get
        Set(value As Boolean)
            SetValue("ShowOnStartup", value)
        End Set
    End Property

    ' PowerPointのスライドショー実行中はエージェントを非表示にするかどうか（PowerPointのみ有効）
    Public Shared Property HideAgentDuringSlideShow As Boolean
        Get
            Return CBool(GetValue("HideAgentDuringSlideShow", False))
        End Get
        Set(value As Boolean)
            SetValue("HideAgentDuringSlideShow", value)
        End Set
    End Property

    ' 以下3つは、スライドショー中にカイルの吹き出しを一定間隔で更新して常時表示する
    ' オーバーレイ機能のON/OFF（PowerPointの「スライド ショー」リボンから切替）
    Public Shared Property ShowSlideNumberDuringSlideShow As Boolean
        Get
            Return CBool(GetValue("ShowSlideNumberDuringSlideShow", False))
        End Get
        Set(value As Boolean)
            SetValue("ShowSlideNumberDuringSlideShow", value)
        End Set
    End Property

    Public Shared Property ShowElapsedTimeDuringSlideShow As Boolean
        Get
            Return CBool(GetValue("ShowElapsedTimeDuringSlideShow", False))
        End Get
        Set(value As Boolean)
            SetValue("ShowElapsedTimeDuringSlideShow", value)
        End Set
    End Property

    Public Shared Property ShowLapTimeDuringSlideShow As Boolean
        Get
            Return CBool(GetValue("ShowLapTimeDuringSlideShow", False))
        End Get
        Set(value As Boolean)
            SetValue("ShowLapTimeDuringSlideShow", value)
        End Set
    End Property

    ' スライド切り替え時にスピーカーノートを音声で読み上げるかどうか（PowerPointのみ有効）。
    ' 発表中に意図せず音声が流れると困るため、既定はOFF
    Public Shared Property SpeakSlideNotesDuringSlideShow As Boolean
        Get
            Return CBool(GetValue("SpeakSlideNotesDuringSlideShow", False))
        End Get
        Set(value As Boolean)
            SetValue("SpeakSlideNotesDuringSlideShow", value)
        End Set
    End Property

    ' AI（Groq/OpenAI）への検索チャット送信時、ホストアプリで選択中のテキストがあれば
    ' それを質問文に含めて送信するかどうか（ウェブ検索モードでは使用しない）
    Public Shared Property IncludeSelectionInSearch As Boolean
        Get
            Return CBool(GetValue("IncludeSelectionInSearch", False))
        End Get
        Set(value As Boolean)
            SetValue("IncludeSelectionInSearch", value)
        End Set
    End Property

    ' 現在使用するキャラクターのID（.acsファイル名から拡張子を除き大文字化したもの。例: "DOLPHIN"）。
    ' 固定の2択ではなく、探索パスで見つかった任意の.acsを指せるよう文字列にしてある。
    ' 既定値・保存済みアニメーション設定の解決キーとしてAnimationEvents側で使う。
    ' 旧バージョン（enumだった頃）の保存値は"Dolphin"/"FinFin"という大文字小文字混在の文字列で
    ' 残っている場合があるため、読み込み時に大文字化して正規化する
    Public Shared Property CharacterId As String
        Get
            Dim raw = CStr(GetValue("CharacterId", OfficeAgent.Core.AnimationEvents.CharacterDolphin))
            If String.IsNullOrWhiteSpace(raw) Then Return OfficeAgent.Core.AnimationEvents.CharacterDolphin
            Return raw.Trim().ToUpperInvariant()
        End Get
        Set(value As String)
            SetValue("CharacterId", If(value, "").Trim().ToUpperInvariant())
        End Set
    End Property


    ' 0=ウェブ検索, 1=Groq, 2=OpenAI GPT
    Public Shared Property AiProvider As Integer
        Get
            Return CInt(GetValue("AiProvider", 2))
        End Get
        Set(value As Integer)
            SetValue("AiProvider", value)
        End Set
    End Property

    Public Shared ReadOnly Property DefaultGPT As Boolean
        Get
            Return AiProvider > 0
        End Get
    End Property

    Public Shared Property API_KEY As String
        Get
            Return CStr(GetValue("API_KEY", "Input OpenAI API key"))
        End Get
        Set(value As String)
            SetValue("API_KEY", value)
        End Set
    End Property

    Public Shared Property GROQ_API_KEY As String
        Get
            Return CStr(GetValue("GROQ_API_KEY", "Input Groq API key"))
        End Get
        Set(value As String)
            SetValue("GROQ_API_KEY", value)
        End Set
    End Property

    Public Shared Property OPENAI_MODEL As String
        Get
            Return CStr(GetValue("OPENAI_MODEL", "gpt-4-turbo"))
        End Get
        Set(value As String)
            SetValue("OPENAI_MODEL", value)
        End Set
    End Property

    Public Shared Property GROQ_MODEL As String
        Get
            Return CStr(GetValue("GROQ_MODEL", ""))
        End Get
        Set(value As String)
            SetValue("GROQ_MODEL", value)
        End Set
    End Property

    Public Shared Property GPT_RULE As String
        Get
            Return CStr(GetValue("GPT_RULE", DefaultRuleFor(CharacterId)))
        End Get
        Set(value As String)
            SetValue("GPT_RULE", value)
        End Set
    End Property

    ' ウェブ検索モードの検索エンジン一覧（「名前=URL」形式、1行1件）。
    ' ユーザーが設定タスクパネルで編集する。未設定時はSearchEngines.DefaultTextを初期値とする
    Public Shared Property SearchEngineListText As String
        Get
            Return CStr(GetValue("SearchEngineListText", OfficeAgent.Core.SearchEngines.DefaultText))
        End Get
        Set(value As String)
            SetValue("SearchEngineListText", value)
        End Set
    End Property

    ' 保存・印刷などのイベントで再生するアニメーションの設定（「イベントキー|有効(0/1)|アニメーション名」形式、1行1件）。
    ' ユーザーが設定タスクパネルで編集する。未設定（空文字）の場合はAnimationEvents.Definitionsの既定値を使用する
    Public Shared Property AnimationEventSettingsText As String
        Get
            Return CStr(GetValue("AnimationEventSettingsText", ""))
        End Get
        Set(value As String)
            SetValue("AnimationEventSettingsText", value)
        End Set
    End Property

    Private Shared Function GetValue(name As String, defaultValue As Object) As Object
        Using key = Registry.CurrentUser.OpenSubKey(RegPath)
            If key Is Nothing Then Return defaultValue
            Return If(key.GetValue(name), defaultValue)
        End Using
    End Function

    Private Shared Sub SetValue(name As String, value As Object)
        Using key = Registry.CurrentUser.CreateSubKey(RegPath)
            key.SetValue(name, value)
        End Using
    End Sub

End Class
