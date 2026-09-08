Imports System.Linq
Imports System.Text

' 設定タスクパネルの「アニメーション設定」で、有効/無効・再生するアニメーションを
' ユーザーが編集できるイベントの一覧と、その設定の読み書きを行う。
'
' 専用の既定アニメーション名テーブルを持つのはカイル（Dolphin）だけ。それ以外の
' キャラクター（フィンフィンを含む、探索パスで見つかった任意の.acs）は、Microsoft Agentの
' 標準アニメーションセットに収録が保証されていないため、Agent States（Required Animations）に
' 載っている「必ず存在するアニメーション」だけを使う汎用設定にフォールバックする。
Public Module AnimationEvents

    Public Enum HostApp
        Word
        Excel
        PowerPoint
    End Enum

    ' キャラクターIDは.acsファイル名（拡張子を除き大文字化したもの）をそのまま使う。
    ' 探索パスで見つかった任意の.acsに対応できるよう、固定enumではなく文字列にしてある
    ' （カイル以外は個別のテーブルを持たず、汎用設定にフォールバックする）
    Public Const CharacterDolphin As String = "DOLPHIN"

    Public Structure EventDef
        Public EventKey As String
        Public DisplayName As String
        Public DefaultAnimationByCharacter As Dictionary(Of String, String)
        Public DefaultEnabled As Boolean
        ' Nothing/空の場合は全アプリ共通。特定アプリでしか発火しないイベント（スライドショー等）はここで絞る
        Public AppliesTo As HostApp()
    End Structure

    ' Dolphinの既定アニメーション名テーブルを組み立てる
    Private Function Anim(dolphin As String) As Dictionary(Of String, String)
        Return New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase) From {
            {CharacterDolphin, dolphin}
        }
    End Function

    Public ReadOnly Definitions As EventDef() = {
        New EventDef With {.EventKey = "Open", .DisplayName = "開く(Ctrl+O)", .DefaultAnimationByCharacter = Anim("GetAttention"), .DefaultEnabled = False},
        New EventDef With {.EventKey = "Close", .DisplayName = "閉じる(Ctrl+W)", .DefaultAnimationByCharacter = Anim("Wave"), .DefaultEnabled = False},
        New EventDef With {.EventKey = "Save", .DisplayName = "保存(Ctrl+S)", .DefaultAnimationByCharacter = Anim("Save"), .DefaultEnabled = True},
        New EventDef With {.EventKey = "Print", .DisplayName = "印刷(Ctrl+P)", .DefaultAnimationByCharacter = Anim("Print"), .DefaultEnabled = True},
        New EventDef With {.EventKey = "SlideShowBegin", .DisplayName = "スライド開始(F5)", .DefaultAnimationByCharacter = Anim("GetAttention"), .DefaultEnabled = True, .AppliesTo = {HostApp.PowerPoint}},
        New EventDef With {.EventKey = "SlideShowEnd", .DisplayName = "スライド終了(Esc)", .DefaultAnimationByCharacter = Anim("Congratulate"), .DefaultEnabled = True, .AppliesTo = {HostApp.PowerPoint}},
        New EventDef With {.EventKey = "ProtectedViewWindowOpen", .DisplayName = "保護ビュー表示", .DefaultAnimationByCharacter = Anim("Explain"), .DefaultEnabled = True},
        New EventDef With {.EventKey = "WorkbookNewSheet", .DisplayName = "シート追加(Shift+F11)", .DefaultAnimationByCharacter = Anim("GetAttention"), .DefaultEnabled = True, .AppliesTo = {HostApp.Excel}},
        New EventDef With {.EventKey = "FormulaError", .DisplayName = "数式エラー検知", .DefaultAnimationByCharacter = Anim("Alert"), .DefaultEnabled = True, .AppliesTo = {HostApp.Excel}},
        New EventDef With {.EventKey = "PresentationNewSlide", .DisplayName = "スライド追加(Ctrl+M)", .DefaultAnimationByCharacter = Anim("Alert"), .DefaultEnabled = True, .AppliesTo = {HostApp.PowerPoint}}
    }

    ' Dolphin向けの既定名（GetAttention/Save/Print/Wave/Congratulate/Explain等）は
    ' Microsoft Agentの「標準アニメーションセット」止まりで、そのセットに準拠していない
    ' キャラクター（フィンフィンを含む）には存在しない可能性がある。一方、Microsoft Learnの
    ' Agent States（Required Animations）に載っている状態アニメーションは、状態に紐づく
    ' あらゆるキャラクターが「必ず持っていなければならない」と規定されているため、
    ' カイル以外のキャラクターにはこちらだけを既定値として使う
    Private ReadOnly GenericAnimationByEvent As New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase) From {
        {"Open", "Show"},
        {"Close", "Hide"},
        {"Save", "RestPose"},
        {"Print", "RestPose"},
        {"SlideShowBegin", "Show"},
        {"SlideShowEnd", "Hide"},
        {"ProtectedViewWindowOpen", "RestPose"},
        {"WorkbookNewSheet", "Show"},
        {"FormulaError", "Alert"},
        {"PresentationNewSlide", "Alert"}
    }

    Private Function IsKnownCharacter(character As String) As Boolean
        Return String.Equals(character, CharacterDolphin, StringComparison.OrdinalIgnoreCase)
    End Function

    ' カイルは専用テーブル（DefaultAnimationByCharacter）の値をそのまま使う。
    ' それ以外のキャラクター（フィンフィンを含む、カタログ側で発見した任意の.acs）は、
    ' Dolphinの値を流用せずGenericAnimationByEvent（必ず存在が保証されているアニメーションのみ）に
    ' フォールバックする
    Private Function DefaultAnimationFor(d As EventDef, character As String) As String
        If IsKnownCharacter(character) Then
            Dim value As String = Nothing
            If d.DefaultAnimationByCharacter IsNot Nothing AndAlso d.DefaultAnimationByCharacter.TryGetValue(character, value) Then Return value
            Return ""
        End If

        Dim generic As String = Nothing
        If GenericAnimationByEvent.TryGetValue(d.EventKey, generic) Then Return generic
        Return ""
    End Function

    ' 設定タスクパネルのグリッド表示用に、host（呼び出し元アプリ）に該当するイベントの
    ' 現在設定（保存済みが無ければ、指定キャラクターの既定値）を返す。hostを省略すると全イベントを返す
    Public Function GetAll(Optional host As HostApp? = Nothing, Optional character As String = CharacterDolphin) As List(Of (Def As EventDef, Enabled As Boolean, Animation As String))
        Dim saved = ParseText(AgentSettings.AnimationEventSettingsText)
        Dim result As New List(Of (Def As EventDef, Enabled As Boolean, Animation As String))
        For Each d In Definitions
            If host.HasValue AndAlso d.AppliesTo IsNot Nothing AndAlso Not d.AppliesTo.Contains(host.Value) Then Continue For

            Dim match = saved.FirstOrDefault(Function(s) String.Equals(s.Character, character, StringComparison.OrdinalIgnoreCase) AndAlso s.EventKey = d.EventKey)
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
    Public Sub SaveAll(rows As List(Of (EventKey As String, Enabled As Boolean, Animation As String)), character As String)
        Dim merged = ParseText(AgentSettings.AnimationEventSettingsText).ToDictionary(Function(r) (r.Character.ToUpperInvariant(), r.EventKey))
        For Each r In rows
            merged((character.ToUpperInvariant(), r.EventKey)) = (character, r.EventKey, r.Enabled, r.Animation)
        Next

        Dim sb As New StringBuilder()
        For Each r In merged.Values
            sb.AppendLine($"{r.Character}|{r.EventKey}|{If(r.Enabled, "1", "0")}|{r.Animation}")
        Next
        AgentSettings.AnimationEventSettingsText = sb.ToString().TrimEnd()
    End Sub

    ' 各ThisAddIn側の呼び出し元から、指定イベントが有効かどうかと再生するアニメーション名を取得する
    Public Function GetSetting(eventKey As String, Optional character As String = CharacterDolphin) As (Enabled As Boolean, Animation As String)
        Dim saved = ParseText(AgentSettings.AnimationEventSettingsText)
        Dim match = saved.FirstOrDefault(Function(s) String.Equals(s.Character, character, StringComparison.OrdinalIgnoreCase) AndAlso s.EventKey = eventKey)
        If match.EventKey IsNot Nothing Then Return (match.Enabled, match.Animation)

        Dim def = Definitions.FirstOrDefault(Function(d) d.EventKey = eventKey)
        Return (def.DefaultEnabled, DefaultAnimationFor(def, character))
    End Function

    ' 「キャラクター|イベントキー|有効(0/1)|アニメーション名」形式（1行1件）で保存する。
    ' 旧形式（キャラクター列が無い3列の行）はDolphinの設定として読み込む。
    ' キャラクター列は任意の文字列（.acsファイル名由来のID）を受け付ける
    Private Function ParseText(text As String) As List(Of (Character As String, EventKey As String, Enabled As Boolean, Animation As String))
        Dim result As New List(Of (Character As String, EventKey As String, Enabled As Boolean, Animation As String))
        If String.IsNullOrWhiteSpace(text) Then Return result

        For Each line In text.Replace(vbCr, "").Split(vbLf)
            Dim trimmed = line.Trim()
            If trimmed.Length = 0 Then Continue For
            Dim parts = trimmed.Split("|"c)
            If parts.Length = 4 Then
                result.Add((parts(0).Trim(), parts(1).Trim(), parts(2).Trim() = "1", parts(3).Trim()))
            ElseIf parts.Length = 3 Then
                result.Add((CharacterDolphin, parts(0).Trim(), parts(1).Trim() = "1", parts(2).Trim()))
            End If
        Next
        Return result
    End Function

End Module
