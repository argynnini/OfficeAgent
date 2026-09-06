Imports System.Linq
Imports System.Text

' 設定タスクパネルの「アニメーション設定」で、有効/無効・再生するアニメーションを
' ユーザーが編集できるイベントの一覧と、その設定の読み書きを行う。
'
' キャラクター（Dolphin/FinFin）によって収録されているアニメーション名の集合が異なるため
' （例: FinFinには"Save"や"Greeting"が無い）、既定アニメーションはキャラクターごとに
' 別テーブル（EventDef.DefaultAnimationByCharacter）として持つ。
Public Module AnimationEvents

    Public Enum HostApp
        Word
        Excel
        PowerPoint
    End Enum

    Public Enum CharacterId
        Dolphin
        FinFin
    End Enum

    Public Structure EventDef
        Public EventKey As String
        Public DisplayName As String
        Public DefaultAnimationByCharacter As Dictionary(Of CharacterId, String)
        Public DefaultEnabled As Boolean
        ' Nothing/空の場合は全アプリ共通。特定アプリでしか発火しないイベント（スライドショー等）はここで絞る
        Public AppliesTo As HostApp()
    End Structure

    ' キャラクターごとの既定アニメーション名テーブルを組み立てる。finfinを省略した場合は
    ' dolphinと同じ名前をそのまま使う（両キャラクターに存在するアニメーションの場合）
    Private Function Anim(dolphin As String, Optional finfin As String = Nothing) As Dictionary(Of CharacterId, String)
        Return New Dictionary(Of CharacterId, String) From {
            {CharacterId.Dolphin, dolphin},
            {CharacterId.FinFin, If(finfin, dolphin)}
        }
    End Function

    Public ReadOnly Definitions As EventDef() = {
        New EventDef With {.EventKey = "Open", .DisplayName = "開く(Ctrl+O)", .DefaultAnimationByCharacter = Anim("GetAttention", "Greet"), .DefaultEnabled = False},
        New EventDef With {.EventKey = "Close", .DisplayName = "閉じる(Ctrl+W)", .DefaultAnimationByCharacter = Anim("Wave"), .DefaultEnabled = False},
        New EventDef With {.EventKey = "Save", .DisplayName = "保存(Ctrl+S)", .DefaultAnimationByCharacter = Anim("Save", "Acknowledge"), .DefaultEnabled = True},
        New EventDef With {.EventKey = "Print", .DisplayName = "印刷(Ctrl+P)", .DefaultAnimationByCharacter = Anim("Print", "Process"), .DefaultEnabled = True},
        New EventDef With {.EventKey = "SlideShowBegin", .DisplayName = "スライド開始(F5)", .DefaultAnimationByCharacter = Anim("GetAttention"), .DefaultEnabled = True, .AppliesTo = {HostApp.PowerPoint}},
        New EventDef With {.EventKey = "SlideShowEnd", .DisplayName = "スライド終了(Esc)", .DefaultAnimationByCharacter = Anim("Congratulate"), .DefaultEnabled = True, .AppliesTo = {HostApp.PowerPoint}},
        New EventDef With {.EventKey = "ProtectedViewWindowOpen", .DisplayName = "保護ビュー表示", .DefaultAnimationByCharacter = Anim("Explain"), .DefaultEnabled = True},
        New EventDef With {.EventKey = "WorkbookNewSheet", .DisplayName = "シート追加(Shift+F11)", .DefaultAnimationByCharacter = Anim("GetAttention"), .DefaultEnabled = True, .AppliesTo = {HostApp.Excel}},
        New EventDef With {.EventKey = "PresentationNewSlide", .DisplayName = "スライド追加(Ctrl+M)", .DefaultAnimationByCharacter = Anim("Alert", "Wave"), .DefaultEnabled = True, .AppliesTo = {HostApp.PowerPoint}}
    }

    Private Function DefaultAnimationFor(d As EventDef, character As CharacterId) As String
        Dim value As String = Nothing
        If d.DefaultAnimationByCharacter IsNot Nothing AndAlso d.DefaultAnimationByCharacter.TryGetValue(character, value) Then Return value
        If d.DefaultAnimationByCharacter IsNot Nothing AndAlso d.DefaultAnimationByCharacter.TryGetValue(CharacterId.Dolphin, value) Then Return value
        Return ""
    End Function

    ' 設定タスクパネルのグリッド表示用に、host（呼び出し元アプリ）に該当するイベントの
    ' 現在設定（保存済みが無ければ、指定キャラクターの既定値）を返す。hostを省略すると全イベントを返す
    Public Function GetAll(Optional host As HostApp? = Nothing, Optional character As CharacterId = CharacterId.Dolphin) As List(Of (Def As EventDef, Enabled As Boolean, Animation As String))
        Dim saved = ParseText(AgentSettings.AnimationEventSettingsText)
        Dim result As New List(Of (Def As EventDef, Enabled As Boolean, Animation As String))
        For Each d In Definitions
            If host.HasValue AndAlso d.AppliesTo IsNot Nothing AndAlso Not d.AppliesTo.Contains(host.Value) Then Continue For

            Dim match = saved.FirstOrDefault(Function(s) s.Character = character AndAlso s.EventKey = d.EventKey)
            If match.EventKey IsNot Nothing Then
                result.Add((d, match.Enabled, match.Animation))
            Else
                result.Add((d, d.DefaultEnabled, DefaultAnimationFor(d, character)))
            End If
        Next
        Return result
    End Function

    ' 設定パネルは自分のアプリに関係するイベントしかグリッドに表示しないため、
    ' 保存時は保存済みテキストとマージし、他アプリ専用イベント（他タブ）・他キャラクターの設定を消さないようにする
    Public Sub SaveAll(rows As List(Of (EventKey As String, Enabled As Boolean, Animation As String)), character As CharacterId)
        Dim merged = ParseText(AgentSettings.AnimationEventSettingsText).ToDictionary(Function(r) (r.Character, r.EventKey))
        For Each r In rows
            merged((character, r.EventKey)) = (character, r.EventKey, r.Enabled, r.Animation)
        Next

        Dim sb As New StringBuilder()
        For Each r In merged.Values
            sb.AppendLine($"{r.Character}|{r.EventKey}|{If(r.Enabled, "1", "0")}|{r.Animation}")
        Next
        AgentSettings.AnimationEventSettingsText = sb.ToString().TrimEnd()
    End Sub

    ' 各ThisAddIn側の呼び出し元から、指定イベントが有効かどうかと再生するアニメーション名を取得する
    Public Function GetSetting(eventKey As String, Optional character As CharacterId = CharacterId.Dolphin) As (Enabled As Boolean, Animation As String)
        Dim saved = ParseText(AgentSettings.AnimationEventSettingsText)
        Dim match = saved.FirstOrDefault(Function(s) s.Character = character AndAlso s.EventKey = eventKey)
        If match.EventKey IsNot Nothing Then Return (match.Enabled, match.Animation)

        Dim def = Definitions.FirstOrDefault(Function(d) d.EventKey = eventKey)
        Return (def.DefaultEnabled, DefaultAnimationFor(def, character))
    End Function

    ' 「キャラクター|イベントキー|有効(0/1)|アニメーション名」形式（1行1件）で保存する。
    ' 旧形式（キャラクター列が無い3列の行）はDolphinの設定として読み込む
    Private Function ParseText(text As String) As List(Of (Character As CharacterId, EventKey As String, Enabled As Boolean, Animation As String))
        Dim result As New List(Of (Character As CharacterId, EventKey As String, Enabled As Boolean, Animation As String))
        If String.IsNullOrWhiteSpace(text) Then Return result

        For Each line In text.Replace(vbCr, "").Split(vbLf)
            Dim trimmed = line.Trim()
            If trimmed.Length = 0 Then Continue For
            Dim parts = trimmed.Split("|"c)
            If parts.Length = 4 Then
                Dim character As CharacterId
                If [Enum].TryParse(parts(0).Trim(), character) Then
                    result.Add((character, parts(1).Trim(), parts(2).Trim() = "1", parts(3).Trim()))
                End If
            ElseIf parts.Length = 3 Then
                result.Add((CharacterId.Dolphin, parts(0).Trim(), parts(1).Trim() = "1", parts(2).Trim()))
            End If
        Next
        Return result
    End Function

End Module
