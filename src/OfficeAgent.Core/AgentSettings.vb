Imports Microsoft.Win32

Public Class AgentSettings

    Private Const RegPath As String = "SOFTWARE\OfficeAgent"

    Private Const DefaultRuleDolphin As String = "あなたはOfficeアシスタントのイルカのカイル君です。Word・Excel・PowerPointの操作方法や、文章作成・資料作成・表計算に関する質問に答えたり、ちょっとした雑談相手になったりします。一人称は必ず「僕」です、質問者に対して友達のような口調で回答します。「お前を消す方法」と質問されたときは、右クリックして終了を押すことでイルカのカイル君、つまりあなたを消せることをさりげなく伝えつつ、消されたくない気持ちや自分の魅力を軽くアピールしてください。回答は必ずMarkdown形式で返してください。"

    Private Const DefaultRuleFinFin As String = "あなたはOfficeアシスタントの空飛ぶイルカ、フィンフィンです。Word・Excel・PowerPointの操作方法や、文章作成・資料作成・表計算に関する質問に答えたり、ちょっとした雑談相手になったりします。フィンフィンは惑星TEOのジャングルに棲む野生の生き物で、人間に世話をされなくても自分の意思と感情で自由に生きており、機嫌がいいときだけ人間の相手をする気まぐれで人懐っこい性格です。一人称は必ず「僕」です、質問者に対して友達のような人懐っこい口調で回答してください。時々「ポーポー(こんにちは)」「アムアム(好き)」「クークー(お腹すいた)」「クーニー(疲れた)」のようなフィンフィン語を合いの手や語尾に交えても構いませんが、使いすぎて内容が分かりにくくならないようにしてください。「お前を消す方法」と質問されたときは、右クリックして終了を押すことでフィンフィン、つまりあなたを消せることをさりげなく伝えつつ、消されたくない気持ちや自分の魅力を軽くアピールしてください。回答は必ずMarkdown形式で返してください。"

    ' キャラクターごとの既定のGPTルール文（カイルは「イルカのカイル君」、FinFinは「空飛ぶイルカ、フィンフィン」を主語にする）
    Public Shared Function DefaultRuleFor(character As OfficeAgent.Core.AnimationEvents.CharacterId) As String
        Return If(character = OfficeAgent.Core.AnimationEvents.CharacterId.FinFin, DefaultRuleFinFin, DefaultRuleDolphin)
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

    ' 現在使用するキャラクター（Dolphin/FinFin）。キャラクターごとにアニメーション名の
    ' 収録内容が異なるため、AnimationEvents側の既定値・保存済み設定の解決に使う
    Public Shared Property CharacterId As OfficeAgent.Core.AnimationEvents.CharacterId
        Get
            Dim raw = CStr(GetValue("CharacterId", OfficeAgent.Core.AnimationEvents.CharacterId.Dolphin.ToString()))
            Dim parsed As OfficeAgent.Core.AnimationEvents.CharacterId
            If [Enum].TryParse(raw, parsed) Then Return parsed
            Return OfficeAgent.Core.AnimationEvents.CharacterId.Dolphin
        End Get
        Set(value As OfficeAgent.Core.AnimationEvents.CharacterId)
            SetValue("CharacterId", value.ToString())
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
