Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Linq
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

    ' PowerPointアドイン（ThisAddIn_Startup）が、スライドショーの進行操作を実行する処理を登録する。
    ' スピーカーノート中の<slide .../>タグが発話の途中（Bookmarkイベント）で
    ' 検出されたタイミングで、(op, dir, index)を引数に呼び出される。
    ' opは"click"（PowerPointの通常のクリック送り＝現在のスライドに未実行のアニメーション
    ' ビルドが残っていればそれを進め、無ければ次/前のスライドへ進む）または"page"（残りの
    ' ビルドを無視して強制的に次/前/指定スライドへ移動する）。
    ' dirは"next"/"prev"（indexが指定されている場合は無視される）。
    ' indexは"page"のときのみ、指定があれば1始まりのスライド番号（無ければ-1）
    Public Shared PerformSlideActionAction As Action(Of String, String, Integer)

    ' PowerPointアドイン（ThisAddIn_Startup）が、スライドショーウィンドウの画面状態操作
    ' （ブラックアウト・ホワイトアウト・通常表示への復帰）を実行する処理を登録する。
    ' スピーカーノート中の<screen op="blackout|whiteout|resume"/>タグが発話の途中
    ' （Bookmarkイベント）で検出されたタイミングで、opを引数に呼び出される
    Public Shared PerformScreenActionAction As Action(Of String)

    ' PowerPointアドイン（ThisAddIn_Startup）が、レーザーポインターのON/OFFを実行する
    ' 処理を登録する。スピーカーノート中の<laser op="on|off"/>タグが発話の途中
    ' （Bookmarkイベント）で検出されたタイミングで、opを引数に呼び出される
    Public Shared PerformLaserActionAction As Action(Of String)

    ' PowerPointアドイン（ThisAddIn_Startup）が、スピーカーノート中の<var name="..."/>タグで
    ' 使えるPowerPoint固有の値（スライド番号・ファイル名等）を返す処理を登録する。
    ' SpeakSlideNotesが呼ばれるたびに（＝スライドが変わるたびに）呼び出すため、常に最新の値が返る
    Public Shared GetSlideVariablesFunc As Func(Of Dictionary(Of String, String))

    ' 各Officeアドイン（ThisAddIn_Startup）が、ホストアプリのメインウィンドウハンドルを返す
    ' 処理を登録する。初回表示位置を「エージェントが起動しているモニタ」ではなく
    ' 「Officeウィンドウが実際に開いているモニタ」基準にするために使用する
    Public Shared GetHostWindowHandleFunc As Func(Of IntPtr)

    ' PowerPointアドイン（ThisAddIn_Startup）が、現在アクティブなスライドショーウィンドウ
    ' （発表者が実際に発表画面として使っているウィンドウ）のハンドルを返す処理を登録する。
    ' スライドショー開始時にエージェントを発表者スクリーン側のモニタへ移動させ、
    ' <agent op="move".../>タグの座標をそのモニタ基準に解釈するために使用する
    Public Shared GetSlideShowWindowHandleFunc As Func(Of IntPtr)

    ' PowerPointアドイン（ThisAddIn_Startup）が、指定した名前のシェイプの矩形をスクリーン座標
    ' （ピクセル）で返す処理を登録する。<agent op="move|gesture" obj="..." pos="..."/>タグで
    ' スライド上のオブジェクトを基準にエージェントを移動させるために使用する。
    ' 該当シェイプが見つからない場合はNothingを返す
    Public Shared GetShapeScreenBoundsFunc As Func(Of String, Rectangle?)

    Protected Overrides ReadOnly Property ShowWithoutActivation As Boolean
        Get
            Return True
        End Get
    End Property

    Public response As String = Nothing

    ' 検索・AI応答の吹き出し（ResponseBalloonForm）はWebBrowserコントロールを内包しており
    ' 生成コストが大きい（実測400～568ms）。起動時に必ず使うわけではないため、
    ' 実際に応答を表示する場面まで生成を遅延させる（プロパティ経由の遅延初期化）
    Private _responseBalloonInstance As ResponseBalloonForm
    Private ReadOnly Property ResponseBalloon As ResponseBalloonForm
        Get
            If _responseBalloonInstance Is Nothing Then _responseBalloonInstance = New ResponseBalloonForm()
            Return _responseBalloonInstance
        End Get
    End Property
    Private _responseBalloonWasVisible As Boolean

    ' カイル左クリックで表示する検索吹き出し。「Word起動直後はショートカットが効かない」不具合の
    ' 調査の一環として、AxAgent（MS Agent ActiveX）を抱える本フォームからは完全に分離してある
    Private _searchBalloon As SearchBalloonForm

    ' スピーカーノート読み上げ時の吹き出しフォントサイズ（既定値。SpeakSlideNotes参照）
    Private Const NormalBalloonFontSize As Integer = 12

    ' 吹き出し（Balloon）の既定Style。ビットフィールドで、bit0=balloon-on、bit1=size-to-text
    ' （テキスト量に応じて高さ自動調整）、bit3=auto-pace（喋る速度に合わせて文字を少しずつ
    ' 出す。溢れたら自動スクロール。0の場合は全文が一気に表示される）。
    '
    ' 以前はauto-paceで吹き出しが空白のままになる不具合の切り分けのため、size-to-textを外し
    ' 固定のCharsPerLine/NumberOfLinesを指定していたが、真因はSAPIForVOICEVOX側の
    ' ブックマークイベント(wParam固定0)のバグと判明し、size-to-textとの衝突ではなかった。
    ' そのため元のsize-to-text（本文量に応じた自動リサイズ）に戻す
    Private Const BalloonStyleBalloonOn As Integer = 1
    Private Const BalloonStyleSizeToText As Integer = 2
    Private Const BalloonStyleAutoPace As Integer = 8
    Private Const BalloonStyleDefault As Integer =
        BalloonStyleBalloonOn Or BalloonStyleSizeToText Or BalloonStyleAutoPace

    ' auto-paceビットだけを外したスタイル。発表時間のお知らせ（AnnouncePresentationTime）と
    ' スライドショー中のオーバーレイ（UpdateSlideShowOverlay：スライド番号／経過時間／
    ' ラップタイム）は、逐次的に単語が出てくる演出が不要かつ見づらいため、この2箇所でだけ
    ' 一時的にこちらへ切り替える。Style（FontSize同様）はキャラクターに紐づく共有状態で
    ' 変更すると残り続けるため、その吹き出しの役目が終わったタイミングで必ず
    ' BalloonStyleDefaultへ戻すこと（他の吹き出し機能に影響してしまうため）
    Private Const BalloonStyleInstant As Integer =
        BalloonStyleBalloonOn Or BalloonStyleSizeToText

    ' 発表時間の吹き出し（AnnouncePresentationTime）を一定時間で自動的に閉じるためのタイマー
    Private Const PresentationBalloonLifetimeMs As Integer = 30000
    Private WithEvents _presentationBalloonTimer As New Windows.Forms.Timer With {.Interval = PresentationBalloonLifetimeMs}

    ' スライドショー中、スライド番号／発表時間／ラップタイムを吹き出しに常時表示するオーバーレイ用タイマー
    Private WithEvents _slideShowOverlayTimer As New Windows.Forms.Timer With {.Interval = 1000}

    ' <agent op="wait" ms="N"/>用の実時間待機タイマー。当初は.Speak("<silence msec=.../>")の
    ' 完了（Agent_RequestComplete）を待つ実装だったが、直前の<agent op="hide"/>でエージェントを
    ' 隠した直後にwaitを実行すると、非表示中のキャラクターに対するsilenceの完了通知が指定した
    ' 時間を待たずほぼ即座に発火してしまう（アニメーションエンジンが停止しているためと思われる）
    ' 不具合が実機で確認された。TTSエンジンや表示状態に依存しない、確実な待機にするため
    ' System.Windows.Forms.Timerによる実時間待機に変更した
    Private WithEvents _waitTimer As New Windows.Forms.Timer()
    Private _slideShowElapsedStopwatch As Stopwatch
    Private _slideShowLapStopwatch As Stopwatch
    Private _slideShowCurrentSlide As Integer
    Private _slideShowTotalSlides As Integer

    ' Word/Excel/PowerPointの実行ファイル名。キャラクターは複数のOfficeプロセス間で共有されるため、
    ' 「自分のプロセスだけ」ではなくこれらのいずれかが起動中かどうかで判定する
    Private Shared ReadOnly HostProcessNames() As String = {"WINWORD", "EXCEL", "POWERPNT"}

    ' コード中に直接名前で埋め込んでいるアニメーション（Greeting/Goodbye/Thinkingなど）は、
    ' カイル（Dolphin）自身のACSに収録された独自名で、Microsoft Agentの標準アニメーション
    ' セットにすら含まれない（標準名は"Greet"/"Think"）。論理名からキャラクターごとの
    ' 実際のアニメーション名を引く小さなテーブルを介して再生する。
    ' 候補を複数指定した場合はその中からランダムに1つを選ぶ
    Private Shared ReadOnly _animationRandom As New Random()

    ' カイル以外（フィンフィンを含む、探索パスで見つかった任意の.acs）はここに専用テーブルを
    ' 持たない。その場合ResolveCharacterAnimationはGenericAnimationByLogicalNameにフォールバックする
    Private Shared ReadOnly CharacterAnimationOverrides As New Dictionary(Of String, Dictionary(Of String, String()))(StringComparer.OrdinalIgnoreCase) From {
        {AnimationEvents.CharacterDolphin, New Dictionary(Of String, String()) From {
            {"Greeting", {"Greeting"}},
            {"Goodbye", {"Goodbye"}},
            {"Thinking", {"Thinking"}}
        }}
    }

    ' "Greeting"/"Goodbye"/"Thinking"にこの名前のままカイル以外のキャラクター（フィンフィンを
    ' 含む）で.Playすると「アニメーションが存在しない」エラーになりうるため、Microsoft Learnの
    ' Agent States（Required Animations）に載っている、必ず存在が保証されているアニメーションに差し替える
    Private Shared ReadOnly GenericAnimationByLogicalName As New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase) From {
        {"Greeting", "Show"},
        {"Goodbye", "Hide"},
        {"Thinking", "RestPose"}
    }

    Private Shared Function IsAsciiWordChar(c As Char) As Boolean
        Return (c >= "A"c AndAlso c <= "Z"c) OrElse (c >= "a"c AndAlso c <= "z"c) OrElse (c >= "0"c AndAlso c <= "9"c)
    End Function

    ' Speak/Thinkの吹き出しは、単語の自動折り返し・自動サイズ計算（Balloon.Styleのsize-to-text）を
    ' 空白文字の位置に頼っている。日本語にはスペースが無いため折り返し位置を認識できず、
    ' 吹き出しのサイズ計算が崩れる（Microsoft Learnのドキュメントに明記されている既知の制約。
    ' 「日本語、中国語、タイ語などスペースを使わない言語では、文字間にUnicodeのゼロ幅スペース
    ' 　文字(0x200B)を挿入して論理的な単語区切りを定義する」との記載がある）。
    ' 半角英数字の連続（"Ctrl+S"等）の間には挿入せず、単語が分断されないようにする
    Private Shared Function InsertWordBreaks(text As String) As String
        If String.IsNullOrEmpty(text) Then Return text
        Dim sb As New StringBuilder()
        For i = 0 To text.Length - 1
            Dim c = text(i)
            sb.Append(c)
            If i < text.Length - 1 Then
                Dim nextC = text(i + 1)
                If Not Char.IsWhiteSpace(c) AndAlso Not Char.IsWhiteSpace(nextC) AndAlso
                   Not (IsAsciiWordChar(c) AndAlso IsAsciiWordChar(nextC)) Then
                    sb.Append(ChrW(&H200B))
                End If
            End If
        Next
        Return sb.ToString()
    End Function

    ' InsertWordBreaksは全文字間にゼロ幅スペースを挿入するため密度が高く、VOICEVOX等の
    ' 外部TTSエンジンのテキスト解析を壊す不具合が実機で確認された（AgentFloatingForm.vb
    ' 変更履歴参照）。こちらは句読点等の「文の区切り」の直後にだけ、疎に挿入する版
    ' （TTS側に渡る特殊文字の量を大幅に減らし、解析への影響を抑える狙い）
    Private Shared ReadOnly SentenceBreakChars As New HashSet(Of Char) From {"。"c, "、"c, "！"c, "？"c, "，"c, "．"c}

    Private Shared Function InsertWordBreaksAtPunctuation(text As String) As String
        If String.IsNullOrEmpty(text) Then Return text
        Dim sb As New StringBuilder()
        For i = 0 To text.Length - 1
            Dim c = text(i)
            sb.Append(c)
            If i < text.Length - 1 Then
                Dim nextC = text(i + 1)
                If SentenceBreakChars.Contains(c) AndAlso Not Char.IsWhiteSpace(nextC) Then
                    sb.Append(ChrW(&H200B))
                End If
            End If
        Next
        Return sb.ToString()
    End Function

    ' ── <ruby yomi="読み仮名">原文</ruby>タグ（吹き出し表示≠発声内容） ──────────
    '
    ' Microsoft Agentの\Mapタグ（\Map="発声用"="吹き出し用"\）は、balloontext（2つ目の
    ' 引数）は仕様通り吹き出しに表示されるが、spokentext（1つ目の引数）はMapの中身が
    ' 常に無音になり一切発声されない、という実機挙動が判明している
    ' （docs/MicrosoftAgent/map-tag-internal-behavior.md参照）。また、1回のSpeak呼び出し内で
    ' \Mapを複数回使う場合、「\Map→地の文→\Map」のように間に地の文を挟んでから次の\Mapに
    ' 入ると、2番目以降の\Mapで吹き出し更新が完全に停止するという副作用があるが、
    ' \Mapを区切りなく連続させる分には何個でも問題ない、ということも実機で確認済み。
    '
    ' この2つの性質を組み合わせ、<ruby>タグを次のように\Mapの連なりへ変換する。
    '   1. テキスト中で最初に現れる<ruby>より前の部分は、そのまま地の文として残す
    '      （文の書き出しなので、\Mapの連続を崩さない）
    '   2. 最初の<ruby>以降（<ruby>の中身も、<ruby>と<ruby>の間にある地の文も）を、
    '      すべて\Map="x"="表示したい断片"\の連続に変換する（spokentextはダミーの"x"で
    '      よい。中身はどうせ発声されないため）。<ruby>の本文（原文）は半角スペースで
    '      単語ごとに分割し、それぞれ個別の\Mapにする。<ruby>の外の地の文は句読点
    '      （SentenceBreakChars）で区切ったまとまりごとに\Mapにする
    '   3. 最後に、実際に発声させたい内容（<ruby>はyomi属性の値、地の文はそのままの
    '      文字列）を、元の語順通りに半角スペースで連結した1つのテキストとしてまとめて
    '      \Mapの連なりの直後に続ける（\Mapの直後に地の文が続く分には吹き出し表示は
    '      壊れないため、ここが安全に発声できる）
    Private Shared ReadOnly RubyTagPattern As New Regex("<ruby\s+yomi\s*=\s*[""“”]([^""“”]*)[""“”]\s*>(.*?)</ruby>", RegexOptions.IgnoreCase Or RegexOptions.Singleline)

    ' \Map="発声用ダミー"="表示断片"\ のうち、実際に吹き出しへ表示される断片（2つ目の
    ' 引数）だけを取り出すパターン。ApplyAutoBalloonHeightの文字数計算で、
    ' \Mapのタグ記法そのもの（バックスラッシュ・引用符等）まで表示文字数に含めて
    ' 数えてしまわないようにするために使う（<...>形式ではないため既存のTagSpanPatternでは
    ' 除去できない）
    Private Shared ReadOnly MapTagPattern As New Regex("\\Map=""[^""]*""=""([^""]*)""\\", RegexOptions.IgnoreCase)

    ' 地の文を句読点（SentenceBreakChars）の直後で分割する。「の紹介と、題しまして、」
    ' のように句読点が複数あれば複数のまとまりに、末尾に句読点が無い残りがあれば
    ' それも最後のまとまりとして含める
    Private Shared Function SplitAtSentenceBreaks(text As String) As List(Of String)
        Dim result As New List(Of String)
        If String.IsNullOrEmpty(text) Then Return result
        Dim sb As New StringBuilder()
        For Each c In text
            sb.Append(c)
            If SentenceBreakChars.Contains(c) Then
                result.Add(sb.ToString())
                sb.Clear()
            End If
        Next
        If sb.Length > 0 Then result.Add(sb.ToString())
        Return result
    End Function

    Private Shared Function ConvertRubyTagsToMapChain(text As String) As String
        If Not RubyTagPattern.IsMatch(text) Then Return text

        Dim firstMatch = RubyTagPattern.Match(text)
        Dim prefix = text.Substring(0, firstMatch.Index)
        Dim rest = text.Substring(firstMatch.Index)

        ' \Mapの連なりとして並べる断片（吹き出しに表示される）
        Dim displayChunks As New List(Of String)
        ' 最後にまとめて続ける、実際に発声させる断片
        Dim spokenChunks As New List(Of String)

        Dim lastIndex = 0
        For Each m As Match In RubyTagPattern.Matches(rest)
            If m.Index > lastIndex Then
                Dim plain = rest.Substring(lastIndex, m.Index - lastIndex)
                For Each chunk In SplitAtSentenceBreaks(plain)
                    ' 改行だけ・空白だけのchunk（行末の改行文字などに由来）は、
                    ' 中身の無い\Mapを生成してしまうため除外する
                    If String.IsNullOrWhiteSpace(chunk) Then Continue For
                    displayChunks.Add(chunk)
                    spokenChunks.Add(chunk)
                Next
            End If

            Dim yomi = m.Groups(1).Value
            Dim original = m.Groups(2).Value
            For Each word In original.Split(" "c).Where(Function(w) w.Length > 0)
                displayChunks.Add(word)
            Next
            If Not String.IsNullOrEmpty(yomi) Then spokenChunks.Add(yomi)

            lastIndex = m.Index + m.Length
        Next

        If lastIndex < rest.Length Then
            Dim plain = rest.Substring(lastIndex)
            For Each chunk In SplitAtSentenceBreaks(plain)
                If String.IsNullOrWhiteSpace(chunk) Then Continue For
                displayChunks.Add(chunk)
                spokenChunks.Add(chunk)
            Next
        End If

        Dim mapChain As New StringBuilder()
        For Each chunk In displayChunks
            mapChain.Append("\Map=""x""=""").Append(chunk).Append("""\")
        Next

        Return prefix & mapChain.ToString() & String.Join(" ", spokenChunks)
    End Function

    ' 吹き出しを出す際、音声では絶対に喋らせないための分岐（あえてSpeak/Thinkが直感と逆）。
    ' .TTSModeIDを参照するとMS Agentサーバーが対応TTSエンジンを探しにいく副作用があり、
    ' LanguageIDに合うエンジンがシステムに存在すると、そのキャラクター本来の設計に関わらず
    ' 「喋れる」判定になってしまう（詳細はAgentFloatingForm.vbの変更履歴を参照）。
    ' そのため「TTSエンジンが無い」場合はどうせ音声が出ないので.Speak()を使い、
    ' 「TTSエンジンがある」場合は.Speak()を使うと実際に喋ってしまうため、
    ' 音声を一切出さない.Think()をあえて使う。これでどちらのケースも音声なし（吹き出しのみ）になる
    '
    ' InsertWordBreaks（文字間へのゼロ幅スペース挿入）は、Microsoft Agentの吹き出しが
    ' 「空白文字を単語の区切りとして扱い、単語ごとに逐次表示していく」仕様
    ' （think-method.mdの「自動単語区切り」の記述）に対して、日本語のようにスペースの
    ' ない言語でも意図した単位で単語境界を定義するためのもの。この仕組みは元々
    ' .Speak()（TTSが無い環境向け、音声合成へ単語区切りを伝える目的も兼ねる）のために
    ' 用意されたものだが、挿入したゼロ幅スペースの数だけ吹き出しが逐次的（単語ずつ）に
    ' 表示されるため、スライド番号／経過時間／ラップタイムのような短い状態表示では
    ' 「一個ずつ出てくる」見づらい演出になってしまう。呼び出し側の用途に応じて
    ' 挿入する・しないを選べるようにしておく（既定はTrueで、従来の見た目のまま）
    Private Sub SpeakOrThink(text As String, Optional useWordBreaks As Boolean = True)
        Dim outputText = If(useWordBreaks, InsertWordBreaks(text), text)
        With AxAgent.Characters("OfficeAgent")
            If .TTSModeID = "" Then
                .Speak(outputText)
            Else
                .Think(outputText)
            End If
        End With
    End Sub

    ' スピーカーノートの読み上げ（PowerPointのスライドショー機能）専用。SpeakOrThinkと違い、
    ' こちらは意図的に音声を出したい機能なので、TTSが使えるなら素直に.Speak()する
    ' （TTSが使えない環境では吹き出し表示のみになる＝Speakの標準挙動に任せる）。
    ' Speakはキューに積まれる仕様なので、.StopAll()を挟まずに次のスライドの分を呼ぶと
    ' 前のスライドの読み上げが終わるまで新しい分が再生されない（発表者がスライドを
    ' 送っても読み上げが追いつかない）。そのため必ず前の読み上げを打ち切ってから再生する。
    ' InsertWordBreaks（全文字間にゼロ幅スペース）は、VOICEVOX等の外部TTSエンジン
    ' （SAPIForVOICEVOX経由）がこの特殊文字を正しく処理できず、テキスト解析が壊れて無関係な
    ' 数値を読み上げてしまう不具合を確認した。タグの外側（地の文）だけに絞っても
    ' （InsertWordBreaksOutsideTags）実機で同じ不具合が再発したため、密な挿入は諦めた。
    ' 代わりに、句読点の直後にだけ疎に挿入する版（InsertWordBreaksAtPunctuationOutsideTags）
    ' を試している。TTS側に渡る特殊文字が大幅に減るため、解析への影響が出にくいはず
    ' （効果が無い／再発する場合はここも外すこと）
    '
    ' Microsoft Agentの.Speak()テキストには、以下の予約文字・既知の不具合がある
    ' （公式ドキュメント記載）。スピーカーノートの自由な文章にこれらが含まれていても
    ' 発話が壊れないよう、発話用に渡す直前に見た目がほぼ同じ全角文字へ置き換える。
    ' \（バックスラッシュ）はSAPI4時代の\Mrk\等のタグ記法用の予約文字だが、
    ' 実際に喋らせているSAPI5エンジン（VOICEVOX/SAPIForVOICEVOX含む）はこの記法自体を
    ' 無視する（RibbonUI.xmlのSAPI5 XMLタグ挿入の項を参照）ため、ここでは全角化しない
    ' （素の文字として読ませる）。
    ' - |（縦棒）: 「代替文字列の区切り」として扱われ、Speak呼び出しのたびにどちらか
    '   一方がランダムに選ばれてしまう。発表時間の目安として「10s | 30s」のように
    '   区切り記号として使っているスピーカーノートがこれに巻き込まれ、前後の内容が
    '   丸ごとランダムに消えてしまう不具合が実機で確認された
    ' - &（アンパサンド）: 周辺の吹き出しテキストが切り捨てられる既知の不具合がある
    '   （本来の回避策は\Map\タグの使用だが、これ自体が動作しないことを確認済みのため使えない）
    '
    ' <!-- ... -->コメント（発表者用の非表示メモ、RibbonUI.xmlの「発表者コメント」タグ）は、
    ' SAPIエンジンが読み上げ自体はスキップしてくれるものの、吹き出しの自動サイズ計算
    ' （Balloon.Style bit1=size-to-text）はSpeak()に渡した文字列全体の長さを見て行われる模様で、
    ' コメントの中身の文字数までサイズに含まれてしまい、吹き出しが不必要に巨大になる不具合が
    ' 実機で確認された。SAPI側の「読み上げない」処理に任せず、Speak()に渡す前にこちら側で
    ' コメントそのものを取り除く（複数行にまたがるコメントも正しく1つとして除去できるよう
    ' RegexOptions.Singlelineを使う）。
    ' 同じ理由で、空行（コメント除去後に残った空行や、タイミング目安・区切り用に空けている
    ' 空行）も吹き出しのサイズ計算に含まれてしまうため、あわせて取り除く
    ' <agent op="break"/>で挟む無音の長さ（ミリ秒）。breakの本質的な役割は吹き出しの
    ' リセット（Agent_RequestComplete参照）であり、音声としての間を作ることが目的ではない
    ' ため、Requestを1つ発行できる最小限の長さにしておく
    Private Const BreakSilenceMs As Integer = 1

    Public Sub SpeakSlideNotes(text As String)
        If String.IsNullOrWhiteSpace(text) Then Return
        Dim normalizedText = NormalizeSmartQuotesInTags(text)
        ' <var name="..."/>は、ノート全体を読み上げ始めるこの時点で一括置換するのではなく、
        ' 各セグメントを実際にSpeak()する直前（ProcessNextSpeakSegment）で解決する。
        ' timeやelapsed、lap（このスライドに来てからの経過時間）は時間とともに値が変わるため、
        ' <agent op="wait"/>等で間を空けたノートの後半にある<var>を先頭でまとめて解決して
        ' しまうと、実際に発声されるタイミングではなく「読み上げ開始した瞬間」の古い値の
        ' ままになってしまう不具合が実機で確認された（例：waitを挟んだ後のlapが常に0近辺）
        Dim strippedText = RemoveBlankLines(CommentTagPattern.Replace(normalizedText, ""))
        If String.IsNullOrWhiteSpace(strippedText) Then Return
        AxAgent.Characters("OfficeAgent").StopAll()
        ' StopAllで前回の発話が中断された場合、そのとき未完了だったbreakのリクエストIDや
        ' 完了待ちの状態が残り続けないようにする（本来はRequestComplete(Status=3)で
        ' クリアされるはずだが念のため）
        _pendingBreakBalloonResetIds.Clear()
        _pendingSegmentCompletionReqId = -1
        _waitTimer.Stop()
        _speakGeneration += 1
        ' Balloon.FontSizeはキャラクターに紐づく状態で、一度設定すると次にどこかで
        ' 変更されるまで残り続ける。発表時間のお知らせ（AnnouncePresentationTime）や
        ' 検索吹き出し等、他の機能がそれぞれ自分の用途向けにFontSizeを変更する箇所が
        ' 複数あり、リセットせずに使い回されるため、「1回目の発表は既定サイズなのに、
        ' 2回目（＝直前にAnnouncePresentationTimeでお疲れ様でしたを話した後）は大きく
        ' なる」という不具合が実機で確認された。スピーカーノートの読み上げは常に同じ
        ' 見た目にしたいので、他の機能の状態に依存しないよう毎回明示的にリセットする
        AxAgent.Characters("OfficeAgent").Balloon.FontSize = NormalBalloonFontSize
        ' <agent>／<slide>／<screen>／<balloon>／<laser>タグの位置でノートを分割し、
        ' 処理待ちキューに積む（理由はSplitNoteBySequentialActions手前のコメント参照）
        _pendingSpeakSegments = New Queue(Of (PlainText As String, SequentialAction As SlideNoteAction))(SplitNoteBySequentialActions(strippedText))
        ProcessNextSpeakSegment()
    End Sub

    ' _pendingSpeakSegmentsから1件取り出して処理し、そのまま次のセグメントへ進める場合は
    ' 自分自身を再帰的に呼ぶ。テキストのSpeak・breakの無音Speakなど「音声として区切りたい」
    ' ものは、そのRequestの完了（Agent_RequestComplete）を待ってから次へ進む
    ' （_pendingSegmentCompletionReqIdにRequestIDをセットして抜ける）。
    ' 吹き出し(Balloon)は「表示され始めた瞬間（BalloonShow）」のStyle（NumberOfLines）で
    ' 矩形サイズが固定され、その後Styleを変更しても表示中は再計算されないことが実機で
    ' 確認された。そのため各テキストの高さは、必ずそのテキストの.Speak()を呼ぶ直前
    ' （＝前のテキストの読み上げが完了し、Balloonが一度Hideされた後）に設定する
    Private Sub ProcessNextSpeakSegment()
        If _pendingSpeakSegments Is Nothing OrElse _pendingSpeakSegments.Count = 0 Then Return
        Dim segment = _pendingSpeakSegments.Dequeue()
        Dim generationAtStart = _speakGeneration
        With AxAgent.Characters("OfficeAgent")
            If segment.SequentialAction IsNot Nothing Then
                Dim sa = segment.SequentialAction
                Select Case sa.TypeName.ToLowerInvariant()
                    Case "balloon"
                        PerformBalloonNoteAction(sa)
                        ProcessNextSpeakSegment()
                    Case "slide"
                        PerformSlideNoteAction(sa)
                        ' PerformSlideNoteActionが実際にスライドを切り替えた場合、SpeakSlideNotesが
                        ' 再入で呼ばれ_pendingSpeakSegmentsが新しいスライド用に差し替わっている
                        ' ことがある（_speakGeneration宣言箇所のコメント参照）。その場合はここで
                        ' 処理を打ち切り、新しいキューの処理は再入した側に任せる
                        If _speakGeneration <> generationAtStart Then Return
                        ProcessNextSpeakSegment()
                    Case "screen"
                        PerformScreenActionAction?.Invoke(sa.Op.ToLowerInvariant())
                        ProcessNextSpeakSegment()
                    Case "laser"
                        PerformLaserActionAction?.Invoke(sa.Op.ToLowerInvariant())
                        ProcessNextSpeakSegment()
                    Case Else ' "agent"
                        Select Case sa.Op.ToLowerInvariant()
                            Case "wait"
                                ' 何も喋らず・エージェント操作もせず、指定ミリ秒だけキューを止める。
                                ' UIスレッドをThread.Sleep等で止めるとPowerPoint全体がフリーズするため、
                                ' Timerによる実時間待機で次へ進む（_waitTimer宣言箇所のコメント参照。
                                ' 以前は無音のSpeak呼び出しの完了待ちだったが、直前にhideした直後だと
                                ' 指定時間を待たず即座に完了してしまう不具合があったため変更した）
                                Dim msText As String = Nothing
                                Dim ms = 500
                                If sa.Attributes.TryGetValue("ms", msText) Then Integer.TryParse(msText, ms)
                                If ms > 0 Then
                                    _waitTimer.Stop()
                                    _waitTimer.Interval = ms
                                    _waitTimer.Start()
                                    Return
                                End If
                                ProcessNextSpeakSegment()
                            Case "break"
                                ' 無音を挟んで音声としての区切りを作りつつ、この無音リクエストの
                                ' 完了（Agent_RequestComplete）をトリガーに吹き出しを明示的に
                                ' リセットする（_pendingBreakBalloonResetIds参照）。単純な
                                ' 直接プロパティ代入（.Balloon.Visible = False）をここで即座に
                                ' 呼ぶと、キューでまだ再生中の前のテキストの吹き出しを
                                ' 読み上げ途中で消してしまうため使わない
                                Dim breakReq = TryCast(.Speak($"<silence msec=""{BreakSilenceMs}""/>"), AgentObjects.IAgentCtlRequest)
                                If breakReq IsNot Nothing Then
                                    _pendingBreakBalloonResetIds.Add(breakReq.ID)
                                    _pendingSegmentCompletionReqId = breakReq.ID
                                    Return
                                End If
                                ProcessNextSpeakSegment()
                            Case "play"
                                ' アニメーション再生の完了（Agent_RequestComplete）を待ってから
                                ' 次のセグメントへ進む。待たずに次へ進むと、直後の<slide>等で
                                ' アニメーション再生中にスライドが切り替わってしまう不具合が
                                ' 実機で確認された（他のagent操作と違い、playだけ再生に
                                ' 数百ms～数秒かかるため影響が顕著に出る）
                                Dim animName As String = Nothing
                                If sa.Attributes.TryGetValue("name", animName) AndAlso Not String.IsNullOrEmpty(animName) Then
                                    Dim playReq = TryCast(.Play(animName), AgentObjects.IAgentCtlRequest)
                                    If playReq IsNot Nothing Then
                                        _pendingSegmentCompletionReqId = playReq.ID
                                        Return
                                    End If
                                End If
                                ProcessNextSpeakSegment()
                            Case Else
                                PerformAgentNoteAction(sa)
                                ProcessNextSpeakSegment()
                        End Select
                End Select
            ElseIf Not String.IsNullOrEmpty(segment.PlainText) Then
                ' <var name="..."/>はここ（実際にこのセグメントをSpeak()する直前）で解決する
                ' 理由はSpeakSlideNotes側のコメント参照。time／elapsed／lapのように時間で
                ' 変わる値を、常にこの瞬間の実際の値で読み上げるようにするため
                Dim resolvedText = ResolveVariables(segment.PlainText)
                Dim safeText = resolvedText.Replace("|"c, "｜"c).Replace("&"c, "＆"c)
                ' 0幅空白挿入処理は一時的に無効化（TTS解析への影響を検証するため）
                ' safeText = InsertWordBreaksAtPunctuationOutsideTags(safeText)
                safeText = ConvertRubyTagsToMapChain(safeText)
                If Not String.IsNullOrWhiteSpace(safeText) Then
                    ApplyAutoBalloonHeight(safeText, .Balloon.CharsPerLine, .Balloon.FontName, .Balloon.FontSize)
                    Dim speakReq = TryCast(.Speak(safeText), AgentObjects.IAgentCtlRequest)
                    If speakReq IsNot Nothing Then
                        _pendingSegmentCompletionReqId = speakReq.ID
                        Return
                    End If
                End If
                ProcessNextSpeakSegment()
            Else
                ProcessNextSpeakSegment()
            End If
        End With
    End Sub

    ' スライドショー終了時など、読み上げ中の音声・吹き出しを即座に打ち切りたい場面で使う。
    ' <balloon op="style" width=.../>やApplyAutoBalloonHeightがBalloon.Styleの
    ' CharsPerLine／NumberOfLines／size-to-textビットを直接書き換えており、これらは
    ' FontSizeと同じくリセットされるまで残り続ける共有プロパティのため、次の発表やスライド
    ' ショー以外の吹き出し（カイル右クリックメニュー等）に幅・高さのカスタム値が引き継がれて
    ' しまわないよう、ここで既定値に戻す。
    '
    ' .StopAll()だけでは、SAPIForVOICEVOX（VOICEVOX）経由の場合、再生中の音声そのものは
    ' 止まらず、次に新しい.Speak()が発行されて初めて実際に打ち切られる、という挙動が実機で
    ' 確認された（発表終了時、直後にAnnouncePresentationTime側で新しくSpeak()するケースだけ
    ' 即座に止まって見えており、呼び出し元がそのまま何もしない場合は前の発話がしゃべり
    ' 終わるまで声が止まらなかった）。そのためここで無音だけの.Speak()を明示的に発行し、
    ' 呼び出し元がこの後Speak()するかどうかに関わらず確実に打ち切れるようにする
    Public Sub StopSpeaking()
        With AxAgent.Characters("OfficeAgent")
            .StopAll()
            .Speak("<silence msec=""1""/>")
            .Balloon.Style = BalloonStyleDefault
            .Balloon.FontSize = NormalBalloonFontSize
        End With
        ' .StopAll()で中断された進行中のSpeakリクエストが後からStatus=3でRequestCompleteを
        ' 発火させ、それをProcessNextSpeakSegmentの「完了待ち」と誤認して、止めたいはずの
        ' キューの続きが再生されてしまわないようにする
        _pendingSpeakSegments?.Clear()
        _pendingSegmentCompletionReqId = -1
        _pendingBreakBalloonResetIds.Clear()
        _waitTimer.Stop()
    End Sub

    ' ── スピーカーノート中の<agent .../>／<slide .../>／<screen .../>／<laser .../>／
    '    <balloon .../>タグ（発話中操作） ──────
    '
    ' 全てのタグを、ノート本文をその位置で分割する区切りとして扱い、Speak→(操作)→Speak
    ' という順序で個別にキューへ積むことで、「直前のテキストを話し終えたら操作を実行し、
    ' 続きを話す」という動作にしている（SplitNoteBySequentialActions／
    ' ProcessNextSpeakSegment参照）。<agent op="break"/>は何も実行せずただ分割するだけ、
    ' <agent op="wait"/>は無音のSpeak呼び出し（<silence>タグ）を1つキューへ積むことで、
    ' それぞれ実現している。
    '
    ' 【変更履歴】<slide>／<screen>／<laser>は当初、SAPI5のXMLブックマークタグ
    ' <bookmark mark="値"/>に変換し、AxAgent.Bookmarkイベントで検出して「発話の途中」に
    ' 割り込み実行する方式だった（PowerPoint側の操作はキャラクターの発話キューとは無関係な
    ' 処理なので、原理上はその場で割り込める）。しかし実機検証の結果、Windows標準の日本語
    ' 音声（Microsoft Haruka等）ではBookmarkイベントが一切発火せず、<slide op="page"/>に
    ' よるスライド送りが機能しないことが判明した。レジストリを確認すると、現在のWindowsでは
    ' コントロールパネル上「クラシック(Desktop)」に見える音声トークンも実体は
    ' C:\WINDOWS\Speech_OneCore\Engines\... のOneCoreエンジンへのブリッジであり、
    ' このブリッジがSPEI_TTS_BOOKMARK通知を実装していないためと判明した（ずんだもん
    ' [SAPIForVOICEVOX]はFireBookmarkEventを自前実装した本物のクラシックSAPI5エンジン
    ' だったため、Bookmark方式でも動いていた）。そのため<agent>／<balloon>と同じ
    ' 「テキストをその位置で区切ってキューに積む」方式に統一し、全ての音声で確実に
    ' 動くようにした（トレードオフとして、実行タイミングが「発話の途中」から
    ' 「直前のテキストを話し終えた後」に変わっている）。
    '
    ' 対応タグ:
    '   <slide op="click|page" dir="next|prev|N"/>
    '                                                        op省略時"click"（PowerPointの通常のクリック送り。
    '                                                        ビルドが残っていればそれを消化、無ければ次/前スライドへ）、
    '                                                        "page"は残りのビルドを無視して強制的に次/前スライドへ移動。
    '                                                        dirに数値を指定すると、opに関わらずそのスライド番号へ
    '                                                        直接ジャンプする。dir省略時"next"
    '   <agent op="move" x="N" y="N" speed="N"/>            エージェントを画面上の位置(x,y)へ移動。x/yは
    '                                                        対象スクリーンに対する0～100の割合（x="90" y="85"なら
    '                                                        横90%・縦85%の位置）。対象スクリーンはスライドショー中は
    '                                                        発表者スクリーン、それ以外はOfficeウィンドウのあるモニタ。
    '                                                        speed省略時はアニメーション無しで瞬間移動、
    '                                                        指定時はそのミリ秒かけて滑るように移動する
    '   <agent op="play" name="..."/>                       エージェントのアニメーションを再生
    '   <agent op="gesture" x="N" y="N"/>                   エージェントが画面上の位置(x,y)の方向を指す。
    '                                                        x/yはmoveと同じく対象スクリーンに対する0～100の割合
    '   <agent op="show" anim="true|false"/>                エージェント自体を表示。anim省略時"false"
    '                                                        （アニメーション無しで瞬時に表示）。"true"を
    '                                                        指定するとShowingアニメーション付きで表示する
    '   <agent op="hide" anim="true|false"/>                エージェント自体を隠す。anim省略時"false"
    '                                                        （アニメーション無しで瞬時に隠す）。"true"を
    '                                                        指定するとHidingアニメーション付きで隠す
    '   <agent op="break"/>                                 発話をここで区切るだけ（他は何もしない）。後続の
    '                                                        <slide>を、喋っている途中の割り込みではなく
    '                                                        「話し終わってから確実に実行」させたい時などに、
    '                                                        直前へ置く
    '   <agent op="wait" ms="1000"/>                        何も喋らず・操作もせず、指定ミリ秒だけ間を置く
    '   <balloon op="show"/>                                 吹き出しを表示
    '   <balloon op="hide"/>                                 吹き出しを隠す
    '   <balloon op="style" size="N" font="..." width="N"/>
    '                                                        以降の吹き出しのフォントサイズ／フォント名／横幅
    '                                                        （1行あたりの文字数）を変更する（属性は指定した
    '                                                        ものだけ変わり、他は今の設定のまま）。太字・斜体・
    '                                                        下線・取り消し線はMS Agentでは実行時に変更不可
    '                                                        （読み取り専用）なので対応していない。吹き出し
    '                                                        全体に効くプロパティなので、一部の単語だけを
    '                                                        サイズ変更する、といったこともできない
    '   <screen op="blackout"/>                             画面をブラックアウト（[B]キー相当）
    '   <screen op="whiteout"/>                              画面をホワイトアウト（[W]キー相当）
    '   <screen op="resume"/>                                ブラックアウト／ホワイトアウトを解除して通常表示に戻す
    '   <laser op="on"/>                                     レーザーポインター表示をON
    '   <laser op="off"/>                                    レーザーポインター表示をOFF（座標指定はできず、
    '                                                        実際のポインター位置はマウスに追従する点に注意）
    Private Class SlideNoteAction
        Public Property TypeName As String
        Public Property Op As String
        Public Property Attributes As New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)
    End Class

    ' <agent op="break"/>で発行した無音Speakリクエストのidを覚えておく。
    ' 吹き出し(Balloon)は「1回のSpeak()が終わるたび」ではなく「キュー全体が空になったとき」
    ' にしか自動でHideされない仕様が実機で確認された（連続する複数のSpeak呼び出しの間、
    ' 前のテキストの吹き出しが表示されっぱなしのまま次のテキストに差し替わる）。breakは
    ' 「ここで吹き出しをリセットする」意図で使われているため、このリクエストの完了
    ' （Agent_RequestComplete）を検知したタイミングで明示的にBalloon.Visibleを倒す
    Private ReadOnly _pendingBreakBalloonResetIds As New HashSet(Of Integer)

    ' SpeakSlideNotesで分割したセグメントの処理待ちキュー、および現在「完了待ち」にしている
    ' RequestのID（-1なら何も待っていない）。
    ' 吹き出し(Balloon)は「表示され始めた瞬間（BalloonShow）」のStyle（NumberOfLines）で
    ' 矩形サイズが固定され、その後Styleを変更しても表示中は再計算されないことが実機で
    ' 確認された（RequestStart／bookmarkのどちらに高さ適用のタイミングを合わせても、
    ' 一度BalloonShowされた後では手遅れだった）。そのため「次のセグメントの高さを、
    ' Speakを呼ぶより前に確定させる」ことが必須になる。ループで全セグメントのSpeakを
    ' 一気に（同期的に）呼ぶと、その場で即座に反映される.Styleへの直接代入は結局
    ' 「ループが終わった時点の最後の値」しか残らないため、前のセグメントの読み上げ
    ' （Speak）が完了する（Agent_RequestComplete）のを待ってから、次のセグメントの
    ' 高さを設定してSpeakする、という逐次処理に変更している（ProcessNextSpeakSegment参照）
    Private _pendingSpeakSegments As Queue(Of (PlainText As String, SequentialAction As SlideNoteAction))
    Private _pendingSegmentCompletionReqId As Integer = -1

    ' <slide dir="N"/>や<slide op="page|click".../>で実際にPowerPointのスライドが切り替わると、
    ' GotoSlide()／View.Next()／View.Previous()の副作用としてPowerPoint側のSlideShowNextSlide
    ' イベントが同期的に（＝呼び出しがまだ戻っていない時点で）発火し、ThisAddIn側から新しい
    ' スライドのSpeakSlideNotesが再入で呼ばれることが実機で確認された。SpeakSlideNotesは
    ' _pendingSpeakSegmentsを新しいキューに差し替えてしまうため、再入から戻ってきた直後の
    ' ProcessNextSpeakSegment（PerformSlideNoteAction呼び出し元）がそのまま続行すると、
    ' 新しいスライド用のキューを完了待ちを無視して横から荒らしてしまい、吹き出しの表示内容と
    ' 実際に再生される音声がずれる不具合になっていた（SpeakSlideNotes参照）。
    ' SpeakSlideNotesが呼ばれるたびに値を進め、再入が起きたかどうかを検出する世代カウンター
    Private _speakGeneration As Integer = 0

    ' <agent .../>／<slide .../>／<screen .../>／<balloon .../>／<laser .../>タグにマッチする。
    ' タグ名自体が種別（SlideNoteAction.TypeName）を表す（旧<action type="..." .../>形式から変更）
    Private Shared ReadOnly ActionTagPattern As New Regex("<(agent|slide|screen|balloon|laser)\s+([^>]*?)/?>", RegexOptions.IgnoreCase)
    ' PowerPointのノート欄は既定でオートコレートの「スマート引用符」が有効なため、手入力した
    ' 半角"が入力中に“”（U+201C/U+201D）へ自動変換されうる（しかも開き・閉じの一方だけ変換され
    ' 他方は半角のまま、という不揃いな状態になることもある）。半角"だけを見るとその属性が
    ' 丸ごと読み取れず無視されてしまうため、半角"と全角の“”のどちらでも（組み合わせが
    ' 不揃いでも）区切りとして受け付けるようにしておく
    Private Shared ReadOnly ActionAttrPattern As New Regex("(\w+)\s*=\s*[""“”]([^""“”]*)[""“”]", RegexOptions.IgnoreCase)

    ' <!-- ... -->コメント除去用。RegexOptions.Singlelineにより、コメントの中に改行が
    ' 含まれていても（.が改行にもマッチするようになるので）1つのコメントとして正しく除去できる
    ' （指定しない場合、複数行コメントの内側で.が改行を跨げず、閉じタグの手前で正しく止まらずに
    ' 別のコメントの終わりまで巻き込んで消してしまう等、誤動作の原因になっていた）
    Private Shared ReadOnly CommentTagPattern As New Regex("<!--.*?-->", RegexOptions.Singleline)

    ' <...>タグの内側だけを対象にスマートクォート（“”）を半角"へ正規化する。<action>／<var>タグの
    ' 属性値はActionAttrPatternが元々スマートクォートを許容しているため既に問題無いが、
    ' <volume level="50">のようなSAPI標準タグはこちらでは解析せずそのまま.Speak()へ渡している
    ' （TTSエンジン側のXMLパーサーに任せている）ため、そちらは対応できていなかった。
    ' タグの外側（実際に喋る地の文）は対象にしない。日本語の文章中に正当な引用符として
    ' “”が使われている場合に、意図せず書き換えてしまわないようにするため
    Private Shared ReadOnly TagSpanPattern As New Regex("<[^>]*>", RegexOptions.Singleline)

    Private Shared Function NormalizeSmartQuotesInTags(text As String) As String
        Return TagSpanPattern.Replace(text, Function(m As Match) As String
                                                Return m.Value.Replace(ChrW(&H201C), """"c).Replace(ChrW(&H201D), """"c)
                                            End Function)
    End Function

    ' InsertWordBreaksAtPunctuation（句読点直後だけのゼロ幅スペース挿入）を、<...>タグの
    ' 内側は避けて地の文にだけ適用する。タグの中に紛れ込むと、bookmarkのmark番号や属性値が
    ' 分断され、正規表現での解析やSAPIエンジン側のXMLタグ認識が壊れてしまうため
    Private Shared Function InsertWordBreaksAtPunctuationOutsideTags(text As String) As String
        Dim sb As New StringBuilder()
        Dim lastIndex = 0
        For Each m As Match In TagSpanPattern.Matches(text)
            sb.Append(InsertWordBreaksAtPunctuation(text.Substring(lastIndex, m.Index - lastIndex)))
            sb.Append(m.Value)
            lastIndex = m.Index + m.Length
        Next
        sb.Append(InsertWordBreaksAtPunctuation(text.Substring(lastIndex)))
        Return sb.ToString()
    End Function


    ' ── スピーカーノート中の<var name="..."/>タグ（動的な値の埋め込み） ──────────
    '
    ' 対応する変数名:
    '   slideNumber       現在のスライド番号（1始まり）
    '   slideCount        スライドの総数
    '   slidesRemaining   残りスライド数（slideCount - slideNumber)
    '   fileName          プレゼンテーションのファイル名
    '   slideTitle        現在のスライドのタイトル（タイトルプレースホルダーの文字列）
    '   sectionName       現在のスライドが属するセクション名（未使用時は空）
    '   author            プレゼンテーションのドキュメントプロパティの作成者
    '   time              現在時刻
    '   date              今日の日付
    '   elapsed           発表開始からの経過時間
    '   lap               このスライドに来てからの経過時間
    '   userName          Windowsのユーザー名
    '   computerName      コンピューター名
    '   agentName         エージェントキャラクターの名前
    '   agentDescription  エージェントキャラクターの説明
    Private Shared ReadOnly VarTagPattern As New Regex("<var\s+([^>]*?)/?>", RegexOptions.IgnoreCase)

    ' <var name="..."/>タグを、実際の値へ置き換える。PowerPoint固有の値（スライド番号・
    ' ファイル名等）はGetSlideVariablesFuncから、それ以外（時刻・ユーザー名・エージェント名等）は
    ' ここで直接取得する。存在しない変数名を指定された場合は空文字に置き換える
    ' （読み上げにタグの生文字列がそのまま混ざるのを防ぐため）
    Private Function ResolveVariables(text As String) As String
        If Not VarTagPattern.IsMatch(text) Then Return text

        Dim values As New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)
        Dim now = DateTime.Now
        values("time") = now.ToString("HH:mm")
        values("date") = now.ToString("yyyy年M月d日")
        values("userName") = Environment.UserName
        values("computerName") = Environment.MachineName
        If _slideShowElapsedStopwatch IsNot Nothing Then values("elapsed") = FormatShort(_slideShowElapsedStopwatch.Elapsed)
        If _slideShowLapStopwatch IsNot Nothing Then values("lap") = FormatShort(_slideShowLapStopwatch.Elapsed)

        Try
            With AxAgent.Characters("OfficeAgent")
                values("agentName") = .Name
                values("agentDescription") = .Description
            End With
        Catch ex As Exception
        End Try

        Dim pptValues = GetSlideVariablesFunc?.Invoke()
        If pptValues IsNot Nothing Then
            For Each kv In pptValues
                values(kv.Key) = kv.Value
            Next
        End If

        Return VarTagPattern.Replace(text, Function(m As Match) As String
                                               Dim nameText As String = Nothing
                                               For Each attrMatch As Match In ActionAttrPattern.Matches(m.Groups(1).Value)
                                                   If String.Equals(attrMatch.Groups(1).Value, "name", StringComparison.OrdinalIgnoreCase) Then
                                                       nameText = attrMatch.Groups(2).Value
                                                       Exit For
                                                   End If
                                               Next
                                               Dim value As String = Nothing
                                               If nameText IsNot Nothing AndAlso values.TryGetValue(nameText, value) Then Return value
                                               Return ""
                                           End Function)
    End Function

    ' 空行（前後の空白のみの行を含む）を取り除いて詰める。改行そのものはSpeak()での
    ' 読み上げには影響しないが、吹き出しの自動サイズ計算では空行の分も高さに数えられてしまうため
    Private Shared Function RemoveBlankLines(text As String) As String
        Dim lines = text.Split({vbCrLf, vbLf, vbCr}, StringSplitOptions.None)
        Return String.Join(vbLf, lines.Where(Function(l) Not String.IsNullOrWhiteSpace(l)))
    End Function

    Private Shared Function ParseActionTag(tagName As String, attrText As String) As SlideNoteAction
        Dim action As New SlideNoteAction() With {.TypeName = tagName.ToLowerInvariant()}
        For Each attrMatch As Match In ActionAttrPattern.Matches(attrText)
            action.Attributes(attrMatch.Groups(1).Value) = attrMatch.Groups(2).Value
        Next
        Dim op As String = Nothing
        action.Attributes.TryGetValue("op", op)
        action.Op = If(op, "")
        Return action
    End Function

    ' ノート本文を、<agent>／<slide>／<screen>／<balloon>／<laser>タグ（ActionTagPattern
    ' が対応する全種別）を区切りとして「地の文（テキスト）」と「キューを分割して実行する
    ' 操作」の並びに分解する。全てのタグをここで区切ることで、発話が完了してから
    ' 確実に操作を実行できる（詳細はこの関数群の手前のコメント参照）
    Private Shared Function SplitNoteBySequentialActions(text As String) As List(Of (PlainText As String, SequentialAction As SlideNoteAction))
        Dim result As New List(Of (PlainText As String, SequentialAction As SlideNoteAction))
        Dim lastIndex = 0
        For Each m As Match In ActionTagPattern.Matches(text)
            Dim action = ParseActionTag(m.Groups(1).Value, m.Groups(2).Value)
            result.Add((text.Substring(lastIndex, m.Index - lastIndex), Nothing))
            result.Add((Nothing, action))
            lastIndex = m.Index + m.Length
        Next
        result.Add((text.Substring(lastIndex), Nothing))
        Return result
    End Function

    ' <agent op="break"/>で発行した無音Speakリクエストの完了を検知し、吹き出しを明示的に
    ' リセットする。吹き出し(Balloon)は「1回のSpeak()ごと」ではなく「キュー全体が空に
    ' なったとき」にしか自動でHideされない仕様が実機で確認されたため（_pendingBreakBalloonResetIds参照）
    Private Sub Agent_RequestComplete(sender As Object, e As AxAgentObjects._AgentEvents_RequestCompleteEvent) Handles AxAgent.RequestComplete
        Try
            Dim req = TryCast(e.request, AgentObjects.IAgentCtlRequest)
            If req IsNot Nothing AndAlso _pendingBreakBalloonResetIds.Remove(req.ID) Then
                AxAgent.Characters("OfficeAgent").Balloon.Visible = False
            End If
            ' ProcessNextSpeakSegmentが「完了待ち」にしていたRequestなら、次のセグメントへ進める
            If req IsNot Nothing AndAlso req.ID = _pendingSegmentCompletionReqId Then
                _pendingSegmentCompletionReqId = -1
                ProcessNextSpeakSegment()
            End If
        Catch ex As Exception
        End Try
    End Sub

    ' Speak()と同じキューに積む都合上、ProcessNextSpeakSegmentから直接呼ばれる。
    ' 属性不正等で失敗しても、残りのSpeak呼び出しは続行させたいので例外を握りつぶす
    Private Sub PerformSlideNoteAction(action As SlideNoteAction)
        Try
            Dim opText As String = Nothing
            action.Attributes.TryGetValue("op", opText)
            Dim op = If(String.IsNullOrEmpty(opText), "click", opText.ToLowerInvariant())
            Dim dirText As String = Nothing
            action.Attributes.TryGetValue("dir", dirText)
            ' dirが数値ならスライド番号への直接ジャンプ、それ以外は"next"/"prev"の相対移動
            ' として扱う（index属性は廃止。dirだけで両方を表現できるようにした）
            Dim dir = "next"
            Dim indexValue = -1
            If Not String.IsNullOrEmpty(dirText) Then
                If Integer.TryParse(dirText, indexValue) Then
                    dir = "goto"
                Else
                    dir = dirText.ToLowerInvariant()
                End If
            End If
            PerformSlideActionAction?.Invoke(op, dir, indexValue)
        Catch ex As Exception
        End Try
    End Sub

    ' Speak()と同じキューに積む都合上、ProcessNextSpeakSegmentから直接呼ばれる。
    ' 属性不正等で失敗しても、残りのSpeak呼び出しは続行させたいので例外を握りつぶす
    Private Sub PerformAgentNoteAction(action As SlideNoteAction)
        Try
            Dim xText As String = Nothing, yText As String = Nothing
            With AxAgent.Characters("OfficeAgent")
                Select Case action.Op.ToLowerInvariant()
                    Case "move"
                        ' speed省略時は0（アニメーション無しで瞬間移動）扱いにする。
                        ' Left/Topへの直接代入は、Speak()等と違って「発話キュー」を経由しない
                        ' プロパティ設定のため、キューの順序を無視してその場（＝SpeakSlideNotesの
                        ' ループがこの行に来た瞬間）に即座に反映されてしまい、それより前に積んだ
                        ' はずの発話より先に動いてしまう不具合が実機で確認された。MoveTo()の
                        ' Speedに0を指定すると「アニメーション無しで瞬間移動」しつつ、通常の
                        ' Requestとして正しくキューに乗る（moveto-method.md参照）ため、
                        ' speedを問わず常にMoveTo()を使う（speedを指定すればそのミリ秒かけて
                        ' 滑るように移動する）。
                        Dim speedText As String = Nothing
                        Dim speed = 0
                        If action.Attributes.TryGetValue("speed", speedText) Then Integer.TryParse(speedText, speed)
                        Dim absX, absY As Integer
                        If ResolveMovePosition(action, isGesture:=False, absX:=absX, absY:=absY) Then
                            .MoveTo(CShort(absX), CShort(absY), speed)
                        End If
                    Case "gesture"
                        Dim absX, absY As Integer
                        If ResolveMovePosition(action, isGesture:=True, absX:=absX, absY:=absY) Then
                            .GestureAt(CShort(absX), CShort(absY))
                        End If
                    Case "show"
                        .Show(Not ReadAnimAttribute(action))
                    Case "hide"
                        .Hide(Not ReadAnimAttribute(action))
                End Select
            End With
        Catch ex As Exception
        End Try
    End Sub

    ' <agent op="show|hide" anim="..."/>のanim属性を読み取る。省略時・不正値は"false"
    ' （アニメーション無し＝Show/Hideのfastパラメーターにはその否定を渡す）扱いにする
    Private Shared Function ReadAnimAttribute(action As SlideNoteAction) As Boolean
        Dim animText As String = Nothing
        If Not action.Attributes.TryGetValue("anim", animText) Then Return False
        Dim result As Boolean
        If Not Boolean.TryParse(animText, result) Then Return False
        Return result
    End Function

    ' <balloon op="show|hide|style" .../>タグの実行。Balloon.Visible／FontName／FontSizeは
    ' いずれも「Speak()を呼んだ瞬間の値」がその発話の吹き出しに適用される（途中で変えても
    ' 今読み上げ中の吹き出しには反映されない）ため、<agent>と同じく発話を分割し、対象の
    ' Speak()より前に確実に設定されるようにしている。
    ' op="style"の属性は指定したものだけ変更し、指定しなかったものは今の設定のまま維持する。
    ' 太字・斜体・下線・取り消し線は対応していない（実行時には読み取り専用で、.acs
    ' キャラクターエディタかユーザーのMicrosoft Agentプロパティ画面でしか変更できないと
    ' Microsoft Learnのfontbold-property等に明記されている）。
    ' widthは吹き出しの横幅（1行あたりの文字数＝CharsPerLine）。専用のSetterは無く、
    ' Balloon.Styleのビット16～23に埋め込む形で設定する（style-property.md参照）。
    ' ビット16～23だけをクリアしてから新しい値を書き込むことで、balloon-on／size-to-text／
    ' auto-pace（ビット0,1,3）やNumberOfLines（ビット24～31）は変更しない
    Private Sub PerformBalloonNoteAction(action As SlideNoteAction)
        Try
            With AxAgent.Characters("OfficeAgent").Balloon
                Select Case action.Op.ToLowerInvariant()
                    Case "show"
                        .Visible = True
                    Case "hide"
                        .Visible = False
                    Case "style"
                        Dim v As String = Nothing
                        If action.Attributes.TryGetValue("size", v) Then
                            Dim n As Integer
                            If Integer.TryParse(v, n) Then .FontSize = n
                        End If
                        If action.Attributes.TryGetValue("font", v) AndAlso Not String.IsNullOrEmpty(v) Then .FontName = v
                        If action.Attributes.TryGetValue("width", v) Then
                            Dim charsPerLine As Integer
                            If Integer.TryParse(v, charsPerLine) Then
                                .Style = (.Style And &HFF00FFFF) Or (charsPerLine * (2 ^ 16))
                            End If
                        End If
                End Select
            End With
        Catch ex As Exception
        End Try
    End Sub

    ' 全角=2／半角=1という文字種による決め打ちの重み付けでは、実機で「27文字（全角）の
    ' 行がcharsPerLine=28に対して計算上2行のはずなのに実際は3行」というズレが確認された
    ' （文字ごとの実際の描画幅はフォント・文字種によって細かく異なるため、二値の重みでは
    ' 精度が足りない）。そのためBalloon.FontName／FontSizeから実フォントを作り、
    ' Graphics.MeasureStringで実測したピクセル幅を使う。ゼロ幅スペース（U+200B、
    ' InsertWordBreaksAtPunctuationOutsideTagsが句読点の後に挿入する）は見た目上
    ' 幅を持たない文字だが、フォントによってはMeasureStringが何らかの幅を返す可能性が
    ' あるため、計測前に取り除く
    Private Shared Function RemoveZeroWidthSpaces(s As String) As String
        Return s.Replace(ChrW(&H200B), "")
    End Function

    ' Balloonの吹き出し矩形が確保する内側余白（agentsvr.exeの逆コンパイル結果より判明。
    ' ウィンドウ全体幅=CharsPerLine×tmAveCharWidthとは別に、そこから20pxを引いた値を
    ' 保持するフィールドがあり、テキストの折り返し判定にはこちらが使われている）
    Private Const BalloonInnerWidthMarginPx As Integer = 20

    ' spokenTextを読み上げる直前に呼ぶ。実際に吹き出しへ表示される分量（タグ・ゼロ幅スペース
    ' を除いた地の文）から必要な行数を計算し、Balloon.Styleへ反映する。
    ' charsPerLine／fontName／fontSizeは呼び出し側でキャプチャした値を渡すこと
    ' （このメソッド内で.Balloonの現在値を都度取得しない）。呼び出しタイミングがそのテキストの
    ' 実際の再生時点までずれ込むと、<balloon op="style".../>で後続のセグメント用に変更された
    ' 値を拾ってしまい、そのセグメントの意図した設定とズレるため。
    ' 実際の計算方法はBalloonTextMetrics参照（agentsvr.exeの逆コンパイルで判明した
    ' MS Agent本体と同じ計算式・同じWin32 API系統を使う）
    Private Sub ApplyAutoBalloonHeight(spokenText As String, charsPerLine As Integer, fontName As String, fontSize As Integer)
        Try
            With AxAgent.Characters("OfficeAgent").Balloon
                If charsPerLine <= 0 OrElse String.IsNullOrEmpty(fontName) OrElse fontSize <= 0 Then Return

                ' \Map="発声用"="表示断片"\ は<...>形式ではないためTagSpanPatternでは
                ' 除去できない。先に表示断片（2つ目の引数）だけへ変換してから、
                ' 既存の<...>タグ除去処理にかける
                Dim visibleText = TagSpanPattern.Replace(MapTagPattern.Replace(spokenText, "$1"), "")
                Dim totalLines = 0

                ' Balloon.FontCharSetは128（SHIFTJIS_CHARSET）に固定されている。Font側で
                ' 文字セットを指定しないとToHfont()が既定の文字セットでLOGFONTを作ってしまい、
                ' 実際にBalloonが使うフォント（日本語文字セット指定）とは異なるメトリクス
                ' （tmAveCharWidthや個々の文字幅）になってしまうため、明示的に合わせる
                Using font As New Drawing.Font(fontName, fontSize, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(128))
                    BalloonTextMetrics.UsingScreenDC(
                        Sub(hdc)
                            Dim aveCharWidthPx As Integer, fontHeightPx As Integer
                            If Not BalloonTextMetrics.TryGetFontMetrics(hdc, font, aveCharWidthPx, fontHeightPx) Then Return

                            Dim balloonWidthPx = charsPerLine * aveCharWidthPx - BalloonInnerWidthMarginPx
                            For Each rawLine In visibleText.Split({vbCr, vbLf}, StringSplitOptions.None)
                                Dim line = RemoveZeroWidthSpaces(rawLine)
                                ' 空行は0行として扱う。breakでテキストを分割すると、分割点の
                                ' 前後に元の改行が残ったまま断片の先頭・末尾に空文字列の行が
                                ' できてしまい（RemoveBlankLinesはノート全体に対して1回しか
                                ' かけていないため、分割後に生じる空行までは除去できない）、
                                ' 無条件に最低1行を保証すると、その空行だけで1行分の余分な
                                ' 高さが積み上がってしまう不具合が実機で確認された
                                totalLines += BalloonTextMetrics.CountWrappedLines(hdc, line, font, balloonWidthPx)
                            Next
                        End Sub)
                End Using
                totalLines = Math.Max(1, totalLines)

                ' size-to-textビット(bit1)が立っていると、NumberOfLines（ビット24～31）を
                ' 設定しようとした時点でエージェント側がエラーを返す（style-property.md参照）
                ' ため、先にそのビットを下ろしてから設定する
                Dim style = .Style And Not BalloonStyleSizeToText
                style = (style And &HFFFFFF) Or (totalLines * (2 ^ 24))
                .Style = style
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Function ResolveCharacterAnimation(logicalName As String) As String
        Dim table As Dictionary(Of String, String()) = Nothing
        Dim candidates As String() = Nothing
        If CharacterAnimationOverrides.TryGetValue(AgentSettings.CharacterId, table) AndAlso table.TryGetValue(logicalName, candidates) AndAlso candidates.Length > 0 Then
            Return candidates(_animationRandom.Next(candidates.Length))
        End If
        Dim generic As String = Nothing
        If GenericAnimationByLogicalName.TryGetValue(logicalName, generic) Then Return generic
        Return logicalName
    End Function

    Function GetWindowMag() As Single
        Using g = Drawing.Graphics.FromHwnd(IntPtr.Zero)
            Return g.DpiX / 96.0F
        End Using
    End Function

    ' AI応答吹き出し（ResponseBalloonForm）・検索吹き出し（SearchBalloonForm）の追従先座標。
    ' CharacterHostCoordinator.GetActiveCharacterScreenPositionから、.acsがアクティブな時に呼ばれる
    Public Function GetAgentScreenPosition() As (Left As Integer, Top As Integer, Mag As Single)
        Dim c = AxAgent.Characters("OfficeAgent")
        Return (c.Left, c.Top, GetWindowMag())
    End Function

    ' 「考え中」「休止」等、意味ベースのアニメーション再生。CharacterHostCoordinator.PlayCommonAnimation
    ' から、.acsがアクティブな時に呼ばれる（実際のアニメーション名への変換はResolveCharacterAnimationが行う）
    Public Sub PlayLogicalAnimation(logicalName As String)
        With AxAgent.Characters("OfficeAgent")
            .StopAll()
            .Play(ResolveCharacterAnimation(logicalName))
        End With
    End Sub

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

    Private Function AcsFileNameFor(character As String) As String
        Return character & ".ACS"
    End Function

    ' 指定した.acsを（現在表示中の"OfficeAgent"とは別名で）一時的に読み込み、
    ' キャラクターに埋め込まれた本来の名前（Name）と紹介文（Description、無い場合もある）を
    ' まとめて取得する。1回の読み込みで両方読むことで、二重にロードしないようにしている。
    ' AgentCharacterCatalogがキャラクター選択リストの表示名・GPTルール生成に使う。
    ' 失敗した場合（壊れたACS、ロード失敗など）は両方Nothingを返す
    Public Function TryReadCharacterProfile(acsPath As String) As (Name As String, Description As String)
        Const ProbeId As String = "__NameProbe"
        Try
            AxAgent.Characters.Load(ProbeId, acsPath)
            Try
                Dim probe = AxAgent.Characters(ProbeId)
                probe.LanguageID = &H411
                Dim name = probe.Name
                Dim description = probe.Description
                Return (If(String.IsNullOrWhiteSpace(name), Nothing, name),
                        If(String.IsNullOrWhiteSpace(description), Nothing, description))
            Finally
                AxAgent.Characters.Unload(ProbeId)
            End Try
        Catch
            Return (Nothing, Nothing)
        End Try
    End Function

    ' キャラクターごとの.acsファイルの場所を解決する。
    ' 素のファイル名だけをCharacters.Loadに渡すと、MS Agentが独自に
    ' C:\Windows\msagent\chars を検索してしまう（DOLPHIN.ACSはOS標準でそこに
    ' 存在することが多いため今まで気づかれなかったが、FINFIN.ACSは無いため失敗する）。
    ' そのため、AgentCharacterCatalog（探索パス上の.acsを列挙するモジュール）から
    ' 実際に見つかった絶対パスを取得して渡す
    Private Function ResolveAcsPath(character As String) As String
        Dim found = AgentCharacterCatalog.DiscoverCharacters().
            FirstOrDefault(Function(c) String.Equals(c.Id, character, StringComparison.OrdinalIgnoreCase))
        If found.AcsPath IsNot Nothing Then Return found.AcsPath

        ' どこにも見つからなかった場合のみ、素のファイル名でMS Agent自身の検索に委ねる
        ' （通常はC:\Windows\msagent\charsを見に行くが、ここに来た時点で正規の配置場所には無い）
        Return AcsFileNameFor(character)
    End Function

    ' <agent op="move"/>／<agent op="gesture"/>の移動先（／指し示す先）座標を解決する。object
    ' 属性が指定されていればスライド上のオブジェクト基準（ResolveObjectPosition）、無ければ
    ' 従来通りx/y（対象スクリーンに対する0～100の割合）基準で解決する。object指定時に
    ' シェイプが見つからない場合はFalseを返し、呼び出し側は移動／ジェスチャー自体を行わない。
    '
    ' ResolveObjectPosition／ResolvePercentPositionが返す座標は、どちらも「エージェントの
    ' 中心を置きたい点」の意味で計算している。一方、実際に呼び出すAxAgentのMoveTo(x,y)は
    ' キャラクターの左上（Left/Top）を指定するAPIのため、それを補正せずそのまま渡すと
    ' キャラクターの幅・高さの半分だけ右下にずれて表示されてしまう（実機で確認済み）。
    ' そのためmove時（isGesture=False）はここでOriginalWidth/Heightの半分を引き、見た目の
    ' 中心が指定点に一致するよう補正する。gesture（GestureAt）は「指す先」の座標であり
    ' キャラクター自身の配置ではないため補正しない
    Private Function ResolveMovePosition(action As SlideNoteAction, isGesture As Boolean, ByRef absX As Integer, ByRef absY As Integer) As Boolean
        Dim resolved As Boolean
        Dim objectName As String = Nothing
        If action.Attributes.TryGetValue("obj", objectName) AndAlso Not String.IsNullOrEmpty(objectName) Then
            Dim posText As String = Nothing
            action.Attributes.TryGetValue("pos", posText)
            resolved = ResolveObjectPosition(objectName, posText, isGesture, absX, absY)
        Else
            Dim xText As String = Nothing, yText As String = Nothing
            Dim xPercent As Double = 0, yPercent As Double = 0
            action.Attributes.TryGetValue("x", xText) : Double.TryParse(xText, xPercent)
            action.Attributes.TryGetValue("y", yText) : Double.TryParse(yText, yPercent)
            ResolvePercentPosition(xPercent, yPercent, absX, absY)
            resolved = True
        End If

        If resolved AndAlso Not isGesture Then
            ' absX/absYはAxAgentの座標系（論理ピクセル）。character.OriginalWidth/Heightも
            ' 同じく論理ピクセルの値のため、ここではmagを掛けたり割ったりせずそのまま使う
            ' （magが必要なのはResolveObjectPosition内、物理ピクセルのrectと演算する箇所だけ）
            Dim character = AxAgent.Characters("OfficeAgent")
            absX -= CInt(character.OriginalWidth / 2.0)
            absY -= CInt(character.OriginalHeight / 2.0)
        End If

        Return resolved
    End Function

    ' <agent op="move|gesture" obj="シェイプ名" pos="..."/>のpos属性を、GetShapeScreenBoundsFunc
    ' が返すシェイプの矩形（スクリーン座標・物理ピクセル）上の1点に変換する。
    ' posはRのlegendのような9方位＋中央で指定する（大文字小文字は区別しない）。
    '   center                                                ：矩形の中心
    '   top/bottom/left/right/topleft/topright/
    '   bottomleft/bottomright                                ：境界線の外側（move時のみ。詳細は下記）
    '   innertop/innerbottom/innerleft/innerright/
    '   innertopleft/innertopright/innerbottomleft/
    '   innerbottomright                                      ：境界線のすぐ内側（オフセット無し。
    '                                                            オブジェクトに重ねて強調する用途）
    ' 「inner」の付かない指定は、move（キャラクターの立ち位置）ではオブジェクトに重ならない
    ' よう、キャラクター自身の現在の表示サイズ（OriginalWidth/Height）分だけ境界線の外へ
    ' 離した点にする。一方gesture（指し示す先）でこのオフセットを付けてしまうと、キャラクターが
    ' 既にその外側の位置に立っている場合、指す先がキャラクター自身の位置とほぼ重なってしまい
    ' 「指し示す」動作として機能しない（例：moveでオブジェクト上端の外側へ移動した直後、同じ
    ' pos="top"でgestureすると、本来はオブジェクトが自分より下にあるので下向きに指すべきところ、
    ' 上向きになってしまう不具合が実機で確認された）。そのためgesture指定時はinner有無に
    ' かかわらず常にオフセット無し（＝境界線上）を対象にする
    ' pos省略時はcenter扱い。GetShapeScreenBoundsFunc未登録、または該当シェイプが見つからない
    ' 場合はFalseを返す
    Private Function ResolveObjectPosition(objectName As String, posText As String, isGesture As Boolean, ByRef absX As Integer, ByRef absY As Integer) As Boolean
        Dim bounds = GetShapeScreenBoundsFunc?.Invoke(objectName)
        If Not bounds.HasValue Then Return False
        Dim rect = bounds.Value

        Dim pos = If(String.IsNullOrEmpty(posText), "center", posText.ToLowerInvariant())
        Dim inner = isGesture OrElse pos.StartsWith("inner")
        If pos.StartsWith("inner") Then pos = pos.Substring("inner".Length)

        Dim character = AxAgent.Characters("OfficeAgent")
        Dim mag = GetWindowMag()
        ' character.OriginalWidth/Heightは論理ピクセル（96 DPI基準）の値だが、rectは
        ' GetShapeScreenBoundsFuncが返すスクリーン座標＝物理ピクセルのため、両者を直接
        ' 演算する前にmagを掛けて物理ピクセルへ変換する必要がある（変換せずにそのまま
        ' 引いていたため、DPIスケールが100%を超える環境でオフセット量が実際より小さくなり、
        ' pos="left"等でキャラクターがオブジェクトに重なってしまう不具合が実機で確認された）。
        ' なおここで計算するx,yは「エージェントの中心を置きたい点」であり、ResolveMovePosition
        ' で最終的にLeft/Topへ変換する際にさらにOriginalWidth/Height「の半分」が引かれる
        ' （中心→左上への変換）。そのため、境界線からキャラクターの下端／右端等がちょうど
        ' 接するようにするには、ここでのoffsetは「境界線から中心までの距離」＝
        ' OriginalWidth/Heightの半分にする必要がある（丸ごと引くと、中心への変換分と
        ' 合わせて実質1.5倍の隙間ができてしまう不具合も実機で確認された）
        Dim offsetX = If(inner, 0, CInt(character.OriginalWidth / 2.0 * mag))
        Dim offsetY = If(inner, 0, CInt(character.OriginalHeight / 2.0 * mag))

        Dim x As Integer, y As Integer
        Select Case pos
            Case "top"
                x = rect.Left + rect.Width \ 2
                y = rect.Top - offsetY
            Case "bottom"
                x = rect.Left + rect.Width \ 2
                y = rect.Bottom + offsetY
            Case "left"
                x = rect.Left - offsetX
                y = rect.Top + rect.Height \ 2
            Case "right"
                x = rect.Right + offsetX
                y = rect.Top + rect.Height \ 2
            Case "topleft"
                x = rect.Left - offsetX
                y = rect.Top - offsetY
            Case "topright"
                x = rect.Right + offsetX
                y = rect.Top - offsetY
            Case "bottomleft"
                x = rect.Left - offsetX
                y = rect.Bottom + offsetY
            Case "bottomright"
                x = rect.Right + offsetX
                y = rect.Bottom + offsetY
            Case Else ' "center"（未指定・不正値もここに含める）
                x = rect.Left + rect.Width \ 2
                y = rect.Top + rect.Height \ 2
        End Select

        absX = CInt(x / mag)
        absY = CInt(y / mag)
        Return True
    End Function

    ' <agent op="move"/>／<agent op="gesture"/>のx/y（対象スクリーンに対する0～100の割合）を、
    ' AxAgentの座標系（プライマリモニタ基準・GetWindowMag()で割った論理ピクセル）の絶対座標に
    ' 変換する。対象スクリーンは、スライドショー中（発表者スクリーンへ移動済み）はそのモニタ、
    ' それ以外はOfficeウィンドウがあるモニタを基準にする
    Private Sub ResolvePercentPosition(xPercent As Double, yPercent As Double, ByRef absX As Integer, ByRef absY As Integer)
        Dim targetScreen = If(_positionBeforeSlideShow.HasValue,
                               ResolveScreenFromHandleFunc(GetSlideShowWindowHandleFunc),
                               GetHostScreen())
        Dim mag = GetWindowMag()
        Dim screenLeft = targetScreen.Bounds.Left / mag
        Dim screenTop = targetScreen.Bounds.Top / mag
        Dim screenWidth = targetScreen.Bounds.Width / mag
        Dim screenHeight = targetScreen.Bounds.Height / mag
        absX = CInt(screenLeft + screenWidth * (xPercent / 100.0))
        absY = CInt(screenTop + screenHeight * (yPercent / 100.0))
    End Sub

    ' 初回表示位置の基準にするモニタを決める。GetHostWindowHandleFuncからOfficeの
    ' メインウィンドウハンドルが取得できればそのウィンドウがあるモニタを、
    ' 取得できなければ（未登録・失敗時）従来通りプライマリモニタを使う
    Private Function GetHostScreen() As Screen
        Return ResolveScreenFromHandleFunc(GetHostWindowHandleFunc)
    End Function

    ' ActorFloatingForm（.actキャラ）の初回表示位置も、Kyle（AxAgent）と同じ基準
    ' （Officeウィンドウのあるモニタ）に揃えるためShared公開する
    Public Shared Function ResolveHostScreen() As Screen
        Try
            Dim hwnd = GetHostWindowHandleFunc?.Invoke()
            If hwnd.HasValue AndAlso hwnd.Value <> IntPtr.Zero Then
                Return Screen.FromHandle(hwnd.Value)
            End If
        Catch ex As Exception
        End Try
        Return Screen.PrimaryScreen
    End Function

    ' ウィンドウハンドルを返すFuncから、そのウィンドウがあるモニタを解決する共通処理。
    ' Func未登録・取得失敗（発表中以外にスライドショーウィンドウが無い等）の場合はプライマリモニタを返す
    Private Function ResolveScreenFromHandleFunc(handleFunc As Func(Of IntPtr)) As Screen
        Try
            Dim hwnd = handleFunc?.Invoke()
            If hwnd.HasValue AndAlso hwnd.Value <> IntPtr.Zero Then
                Return Screen.FromHandle(hwnd.Value)
            End If
        Catch ex As Exception
        End Try
        Return Screen.PrimaryScreen
    End Function

    ' スライドショー開始前のエージェント位置（AxAgent座標系）。スライドショー終了時に
    ' この位置へ戻すために使う。Nothingならスライドショー中ではない（＝移動していない）
    Private _positionBeforeSlideShow As Drawing.Point?

    ' PowerPointのスライドショー開始時に呼ぶ。GetSlideShowWindowHandleFuncから発表者が
    ' 実際に見ているスライドショーウィンドウのハンドルを取得し、そのモニタの右下へ
    ' エージェントを移動させる（初回表示位置と同じ計算式）。元の位置はEndSlideShowMoveで
    ' 復元できるよう保存しておく
    Public Sub MoveToSlideShowScreen()
        Try
            With AxAgent.Characters("OfficeAgent")
                _positionBeforeSlideShow = New Drawing.Point(.Left, .Top)
                Dim targetScreen = ResolveScreenFromHandleFunc(GetSlideShowWindowHandleFunc)
                Dim mag = GetWindowMag()
                Dim top = CShort((targetScreen.Bounds.Top + targetScreen.Bounds.Height - .OriginalHeight - 100) / mag)
                Dim left = CShort((targetScreen.Bounds.Left + targetScreen.Bounds.Width - .OriginalWidth - 50) / mag)
                .MoveTo(left, top, 0)
            End With
        Catch ex As Exception
        End Try
    End Sub

    ' PowerPointのスライドショー終了時に呼ぶ。MoveToSlideShowScreenで移動する前の位置へ戻す。
    ' この直後にAnnouncePresentationTime／PlayConfiguredAnimationが.StopAll()を呼ぶため、
    ' MoveTo()でキューに乗せる方式だと実行前に取り消されてしまう（実機で発生確認済み）。
    ' Left/Topへの直接代入はキューを経由せずその場で即座に反映されるため、.StopAll()の
    ' 影響を受けない
    Public Sub RestorePositionAfterSlideShow()
        If Not _positionBeforeSlideShow.HasValue Then Return
        Try
            Dim pos = _positionBeforeSlideShow.Value
            With AxAgent.Characters("OfficeAgent")
                .Left = CShort(pos.X)
                .Top = CShort(pos.Y)
            End With
        Catch ex As Exception
        End Try
        _positionBeforeSlideShow = Nothing
    End Sub

    ' このフォームはAxAgent（.acsしか読めない）を常に内部で1つ抱える設計のため、
    ' ユーザーが実際に選んでいるキャラクター（AgentSettings.CharacterId）が.act（Actor）の
    ' 場合でも、AxAgent自体にはDolphinを内部的に読み込ませておく（検索吹き出し等、AxAgentの
    ' 存在を前提にした機能のため）。表示自体・「起動時に表示」設定の反映はActorFloatingForm側
    ' （各ThisAddIn_Startup）が担うため、ここではAgentSettings.CharacterIdを書き換えず、
    ' Kyleの自動表示（ShowAgent）もスキップする
    Public ReadOnly Property IsActCharacterSelected As Boolean
        Get
            Return AgentCharacterCatalog.GetFormat(AgentSettings.CharacterId) = AgentCharacterCatalog.CharacterFormat.Act
        End Get
    End Property

    Private Sub AgentFloatingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Instance = Me
        _searchBalloon = New SearchBalloonForm(Me)

        Dim character = AgentSettings.CharacterId
        Dim characterForAxAgent = If(IsActCharacterSelected, AnimationEvents.CharacterDolphin, character)
        Dim acsPath = ResolveAcsPath(characterForAxAgent)
        ' 設定されているキャラクターの.acsがこのアプリのフォルダに無い場合
        ' （例: FinFin切り替え後、他のOfficeアプリのアドインフォルダにはFINFIN.ACSが未配置）は、
        ' 起動時にクラッシュさせずDolphinにフォールバックする
        If Not IO.File.Exists(acsPath) Then
            MessageBox.Show(
                $"{AcsFileNameFor(characterForAxAgent)} が見つからないため、Dolphinで起動します。" & Environment.NewLine &
                $"想定パス: {acsPath}",
                "OfficeAgent", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            characterForAxAgent = AnimationEvents.CharacterDolphin
            If Not IsActCharacterSelected Then AgentSettings.CharacterId = characterForAxAgent
            acsPath = ResolveAcsPath(characterForAxAgent)
        End If
        AxAgent.Characters.Load("OfficeAgent", acsPath)

        ' キャラクターはOfficeプロセス間で共有されるため、既に他のOfficeアプリが
        ' 表示中であれば、ここで強制的に非表示にしてしまわないようにする
        Dim wasAlreadyVisible = AxAgent.Characters("OfficeAgent").Visible

        With AxAgent.Characters("OfficeAgent")
            .Balloon.Style = BalloonStyleDefault
            .LanguageID = &H411
            .Balloon.FontCharSet = 128
            .Balloon.Visible = False
            .AutoPopupMenu = False
            .SoundEffectsOn = AgentSettings.DefaultSound
            .IdleOn = True
            If Not wasAlreadyVisible Then
                Dim targetScreen = GetHostScreen()
                .Top = (targetScreen.Bounds.Top + targetScreen.Bounds.Height - .OriginalHeight - 100) / GetWindowMag()
                .Left = (targetScreen.Bounds.Left + targetScreen.Bounds.Width - .OriginalWidth - 50) / GetWindowMag()
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

        ' 「起動時に表示」が有効な場合のみ、Office起動と同時にエージェントを表示する。
        ' 実際に選ばれているキャラクターが.act（Actor）の場合は、Kyle（AxAgent、ここでは
        ' ShowAgent()を直接呼ばない）ではなくActorFloatingFormが表示される
        ' （CharacterHostCoordinator.Show参照。ThisAddIn側は関与せず、ここで完結させる）
        If AgentSettings.ShowOnStartup Then
            CharacterHostCoordinator.Show(AgentSettings.CharacterId)
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
        _responseBalloonInstance?.Hide()
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
    Public Function SwitchCharacter(character As String) As Boolean
        Dim acsPath = ResolveAcsPath(character)
        If Not IO.File.Exists(acsPath) Then
            MessageBox.Show(
                $"{AcsFileNameFor(character)} が見つかりません。" & Environment.NewLine &
                $"想定パス: {acsPath}" & Environment.NewLine & Environment.NewLine &
                "agentsフォルダに.acsファイルを配置してください。",
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
            .Balloon.Style = BalloonStyleDefault
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

        ' キャラクターが変わると収録アニメーション名の一覧も変わるため、キャッシュを無効化して
        ' 右クリックメニューのアニメーション一覧を作り直す
        _cachedAnimationNames = Nothing
        _animationComboPopulated = True
        PopulateAnimationCombo()

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
        _responseBalloonInstance?.Hide()
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
                ' 右クリックメニューでアニメーションを選択した直後など、.StopAll()を経由せず
                ' .Play()だけがキューされた状態が残っていると、そのリクエストが完了しない限り
                ' 後続のGoodbye/Hideが実行されずRequestCompleteが来なくなる（実機検証で確認）。
                ' そのため新しいキューを積む前に必ず既存のキューをクリアする
                .StopAll()
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

    ' ActorFloatingForm（.actキャラ）左クリック時に呼ばれる：検索吹き出しをその実際の画面位置
    ' （物理ピクセル）に表示する。AxAgent座標系（.Left/.Topがモニタ間の論理ピクセル、magで
    ' 物理ピクセルへ変換）とは異なり、Actor側は素のスクリーン座標を渡してくるため、
    ' SearchBalloonForm.ShowNearのmagには1.0（変換なし）を渡す
    Public Sub ShowSearchBalloonNear(screenLeft As Integer, screenTop As Integer)
        _searchBalloon.ShowNear(screenLeft, screenTop, 1.0F)
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
                    _responseBalloonInstance?.Hide()
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
        _responseBalloonWasVisible = _responseBalloonInstance IsNot Nothing AndAlso _responseBalloonInstance.Visible
        _responseBalloonInstance?.Hide()
    End Sub

    'Agentドラッグ終了時
    Private Sub Agent_DragEnd(sender As Object, e As AxAgentObjects._AgentEvents_DragCompleteEvent) Handles AxAgent.DragComplete
        Dim agL2 = AxAgent.Characters("OfficeAgent").Left
        Dim agT2 = AxAgent.Characters("OfficeAgent").Top
        Dim mag3 = GetWindowMag()
        _searchBalloon.RepositionNear(agL2, agT2, mag3)
        If _responseBalloonWasVisible Then
            ResponseBalloon.MoveToAgent(agL2, agT2, mag3)
            ResponseBalloon.Show()
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
                HideAndRestoreOfficeFocus()
                CharacterHostCoordinator.PlayCommonAnimation("RestPose")
                If searchText.Trim = "" Then Return
                If searchText = "お前を消す方法" Then
                    ' 吹き出しでのセリフ表示・waveアニメーションは.acs（AxAgent）専用機能のため
                    ' そのまま直接呼ぶ（.actアクティブ時は何も起きない）
                    With AxAgent.Characters("OfficeAgent")
                        .Balloon.FontSize = 12
                        SpeakOrThink("質問の意味がわかりません。")
                        .Play("wave")
                    End With
                End If
                Dim engines = SearchEngines.List
                Dim url = engines(engineIndex, 1) & Web.HttpUtility.UrlEncode(searchText.Replace(Environment.NewLine, " ")) & engines(engineIndex, 2)
                Dim psi As New ProcessStartInfo(url) With {
                    .UseShellExecute = True
                }
                Process.Start(psi)
                CharacterHostCoordinator.PlayCommonAnimation("RestPose")
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
        HideAndRestoreOfficeFocus()
        _responseBalloonInstance?.Hide()
        CharacterHostCoordinator.PlayCommonAnimation("Thinking")

        Dim messages As New List(Of ChatMessage) From {
            New SystemChatMessage(AgentSettings.GPT_RULE),
            New UserChatMessage(userPrompt)
        }

        ' Await前に、表示中のキャラクター（.act/.acsどちらでも）の座標を取得
        Dim pos = CharacterHostCoordinator.GetActiveCharacterScreenPosition()
        Dim agL = pos.Left
        Dim agT = pos.Top
        Dim capturedMag = pos.Mag

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
                                    CharacterHostCoordinator.PlayCommonAnimation("RestPose")
                                    ResponseBalloon.StartResponse(localText, agL, agT, capturedMag)
                                End Sub)
                Else
                    Dim localChunk = chunk
                    BeginInvoke(Sub() ResponseBalloon.AppendChunk(localChunk, agL, agT, capturedMag))
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
            ' auto-paceでの逐次表示ではなく一括表示にする。表示が終わったら
            ' （PresentationBalloonTimer_Tickで吹き出しを閉じる際に）必ずデフォルトへ戻す
            .Balloon.Style = BalloonStyleInstant
            SpeakOrThink($"発表時間は{String.Join("", parts)}でした！お疲れさま！", useWordBreaks:=False)
        End With

        _presentationBalloonTimer.Stop()
        _presentationBalloonTimer.Start()
    End Sub

    ' スライドショー開始時（ThisAddIn側のSlideShowBeginハンドラから呼ぶ）。
    ' 設定でどれか1つでも表示項目が有効になっていればオーバーレイ更新タイマーを開始する
    Public Sub StartSlideShowOverlay(totalSlides As Integer, currentSlide As Integer)
        _slideShowTotalSlides = totalSlides
        _slideShowCurrentSlide = currentSlide
        _slideShowElapsedStopwatch = Stopwatch.StartNew()
        _slideShowLapStopwatch = Stopwatch.StartNew()
        _lastLapResetSlide = currentSlide

        If Not OverlayEnabled() Then Return
        UpdateSlideShowOverlay()
        _slideShowOverlayTimer.Start()
    End Sub

    ' 直近でラップタイムをリセットしたスライド番号。PowerPointのSlideShowNextSlideイベントは
    ' 1回の実際のスライド送りに対して複数回連続で発火することがある既知の癖があり
    ' （ThisAddIn.OnSlideShowNextSlideのコメント参照）、その重複発火のたびにここでラップタイムを
    ' リセットしてしまうと、実際にはスライドが変わっていないのに「このスライドに来てからの
    ' 経過時間」（lap）が0に戻り続けてしまう不具合が実機で確認された
    Private _lastLapResetSlide As Integer = -1

    ' スライドが切り替わるたび（ThisAddIn側のSlideShowNextSlideハンドラから呼ぶ）に
    ' ラップタイム（このスライドに来てからの経過時間）をリセットする
    Public Sub NotifySlideShowSlideChanged(currentSlide As Integer)
        _slideShowCurrentSlide = currentSlide
        If currentSlide <> _lastLapResetSlide Then
            _lastLapResetSlide = currentSlide
            _slideShowLapStopwatch?.Restart()
        End If
        If OverlayEnabled() Then UpdateSlideShowOverlay()
    End Sub

    ' スライドショー終了時（ThisAddIn側のSlideShowEndハンドラから、AnnouncePresentationTimeより前に呼ぶ）
    Public Sub StopSlideShowOverlay()
        _slideShowOverlayTimer.Stop()
        _slideShowElapsedStopwatch = Nothing
        _slideShowLapStopwatch = Nothing
        ' UpdateSlideShowOverlayでBalloonStyleInstantに切り替えたままにしないよう、
        ' オーバーレイ機能自体の終了（この吹き出しの役目が終わったタイミング）で
        ' 必ずデフォルトへ戻す。直後にAnnouncePresentationTime側で改めてInstantへ
        ' 切り替えるが、それとは独立にここでも一度戻しておく
        Try
            AxAgent.Characters("OfficeAgent").Balloon.Style = BalloonStyleDefault
        Catch ex As COMException
            ' 全Officeウィンドウ最小化時などAxAgentの描画サーフェスが無効な状態で
            ' 呼ばれることがあるため、失敗は無視する
        End Try
    End Sub

    ' リボンのチェックボックスが切り替えられた直後、表示中のオーバーレイに即座に反映させる
    Public Sub RefreshSlideShowOverlay()
        If _slideShowElapsedStopwatch Is Nothing Then Return
        If OverlayEnabled() Then
            UpdateSlideShowOverlay()
            If Not _slideShowOverlayTimer.Enabled Then _slideShowOverlayTimer.Start()
        Else
            _slideShowOverlayTimer.Stop()
        End If
    End Sub

    ' オーバーレイ（スライド番号／発表時間／ラップ）は、スライドが切り替わるたびに
    ' .StopAll()してSpeakOrThink()で読み上げる仕組みのため、スピーカーノート読み上げ
    ' （SpeakSlideNotes、同じキャラクターの発話キューを使う）と同時に有効だと、お互いの
    ' 発話を次々と打ち切り合ってしまう。リボン側でチェックボックスをグレーアウトして
    ' いるが、以前チェックを入れたまま読み上げをONにしたケースにも対応できるよう、
    ' ここでも機能的に無効化しておく
    Private Function OverlayEnabled() As Boolean
        If AgentSettings.SpeakSlideNotesDuringSlideShow Then Return False
        Return AgentSettings.ShowSlideNumberDuringSlideShow OrElse
               AgentSettings.ShowElapsedTimeDuringSlideShow OrElse
               AgentSettings.ShowLapTimeDuringSlideShow
    End Function

    Private Sub SlideShowOverlayTimer_Tick(sender As Object, e As EventArgs) Handles _slideShowOverlayTimer.Tick
        UpdateSlideShowOverlay()
    End Sub

    Private Sub UpdateSlideShowOverlay()
        Dim parts As New List(Of String)
        If AgentSettings.ShowSlideNumberDuringSlideShow Then parts.Add($"{_slideShowCurrentSlide}/{_slideShowTotalSlides}枚")
        If AgentSettings.ShowElapsedTimeDuringSlideShow AndAlso _slideShowElapsedStopwatch IsNot Nothing Then parts.Add($"経過{FormatShort(_slideShowElapsedStopwatch.Elapsed)}")
        If AgentSettings.ShowLapTimeDuringSlideShow AndAlso _slideShowLapStopwatch IsNot Nothing Then parts.Add($"このスライド{FormatShort(_slideShowLapStopwatch.Elapsed)}")
        If parts.Count = 0 Then Return

        Try
            With AxAgent.Characters("OfficeAgent")
                .StopAll()
                .Balloon.FontSize = 10
                ' auto-paceでの逐次表示ではなく一括表示にする。表示が終わったら
                ' （StopSlideShowOverlayでオーバーレイ機能自体を終了する際に）デフォルトへ戻す
                .Balloon.Style = BalloonStyleInstant
            End With
            SpeakOrThink(String.Join("  ", parts), useWordBreaks:=False)
        Catch ex As COMException
            ' 全Officeウィンドウ最小化時などAxAgentの描画サーフェスが無効な状態で
            ' 呼ばれることがあるため、失敗は無視する
        End Try
    End Sub

    Private Shared Function FormatShort(elapsed As TimeSpan) As String
        If elapsed.Hours > 0 Then Return $"{elapsed.Hours}:{elapsed.Minutes:D2}:{elapsed.Seconds:D2}"
        Return $"{elapsed.Minutes}:{elapsed.Seconds:D2}"
    End Function

    ' <agent op="wait" ms="N"/>の実時間待機が満了した（_waitTimer宣言箇所のコメント参照）
    Private Sub WaitTimer_Tick(sender As Object, e As EventArgs) Handles _waitTimer.Tick
        _waitTimer.Stop()
        ProcessNextSpeakSegment()
    End Sub

    ' 発表時間の吹き出しを表示してから約30秒経ったら自動的に閉じる
    Private Sub PresentationBalloonTimer_Tick(sender As Object, e As EventArgs) Handles _presentationBalloonTimer.Tick
        _presentationBalloonTimer.Stop()
        Try
            With AxAgent.Characters("OfficeAgent")
                .Balloon.Visible = False
                ' AnnouncePresentationTimeでBalloonStyleInstantに切り替えたままにしないよう、
                ' 表示終了（この吹き出しの役目が終わったタイミング）で必ずデフォルトへ戻す
                .Balloon.Style = BalloonStyleDefault
            End With
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
    ' AxAgent.Characters(...).AnimationNamesの列挙はCOM経由で1件ずつ取得するため実測72～107msかかるが、
    ' 都度取得を避けるため一度取得した結果をキャッシュする（SwitchCharacterで無効化される）
    Private _cachedAnimationNames As String()

    Private Function GetCachedAnimationNames() As String()
        If _cachedAnimationNames Is Nothing Then
            Dim names As New List(Of String)
            For Each n In AxAgent.Characters("OfficeAgent").AnimationNames
                names.Add(CStr(n))
            Next
            _cachedAnimationNames = names.ToArray()
        End If
        Return _cachedAnimationNames
    End Function

    ' 右クリックメニューのアニメーション選択コンボボックスは、実際にメニューが開かれるまで
    ' 構築を遅らせる（起動時のAnimationNames列挙コストを避けるため）。
    ' 以前この遅延化がOffice終了時のフリーズ原因と疑われロールバックしたが、実際の原因は
    ' 診断用に有効化していたFusion Log（.NETアセンブリバインディングログ）自体のオーバーヘッドで
    ' あり、この遅延化とは無関係だったことが実機検証で判明したため再度有効化する
    Private _animationComboPopulated As Boolean = False

    Private Sub AgentMenu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles AgentMenu.Opening
        If _animationComboPopulated Then Return
        _animationComboPopulated = True
        PopulateAnimationCombo()
    End Sub

    Private Sub PopulateAnimationCombo()
        With Animation
            .Items.Clear()
            .Items.Add("アニメーション")
            For Each animName In GetCachedAnimationNames()
                .Items.Add(animName)
            Next
            .SelectedIndex = .Items.Count() - 1
        End With
    End Sub

    Public Function GetAvailableAnimationNames() As String()
        Dim names As New List(Of String)(GetCachedAnimationNames())
        names.Sort(StringComparer.OrdinalIgnoreCase)
        Return names.ToArray()
    End Function


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
