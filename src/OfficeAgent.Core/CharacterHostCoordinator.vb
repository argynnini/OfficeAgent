Imports System.Linq

' .acs（AgentFloatingForm／Microsoft Agent／AxAgent）と.act（ActorFloatingForm／
' Microsoft Actor／FrontierActorControl）は完全に別エンジンだが、リボンや設定タスク
' パネルから見れば「今選ばれているキャラクターの表示/非表示/切替/プレビュー再生」という
' 同じ操作の対象でしかない。呼び出し元（AgentRibbon／AgentSettingsPane）がいちいち
' AgentCharacterCatalog.GetFormatで分岐しなくて済むよう、その振り分けをここに1箇所へ集約する
Public Module CharacterHostCoordinator

    Private Function IsAct(id As String) As Boolean
        Return AgentCharacterCatalog.GetFormat(id) = AgentCharacterCatalog.CharacterFormat.Act
    End Function

    ' ActorFloatingFormは（AgentFloatingFormと違い）Officeアドイン起動時に必ず生成される
    ' わけではなく、初めて.actキャラクターが必要になった時点で遅延生成する
    Private Function EnsureActorForm() As ActorFloatingForm
        If ActorFloatingForm.Instance Is Nothing Then
            ActorFloatingForm.Instance = New ActorFloatingForm()
        End If
        Return ActorFloatingForm.Instance
    End Function

    Public Function IsVisible(id As String) As Boolean
        If IsAct(id) Then
            Return ActorFloatingForm.Instance IsNot Nothing AndAlso ActorFloatingForm.Instance.IsActorVisible
        End If
        Return AgentFloatingForm.Instance IsNot Nothing AndAlso AgentFloatingForm.Instance.IsCharacterVisible
    End Function

    Public Sub Show(id As String)
        If IsAct(id) Then
            EnsureActorForm().ShowActorAgent()
        Else
            AgentFloatingForm.Instance?.ShowAgent()
        End If
    End Sub

    ' checkOtherApps:=True は.acs（AxAgent、共有キャラクター）専用の考慮で、他のOfficeアプリが
    ' 起動中なら共有キャラクターへのGoodbye再生・非表示をスキップする（AgentFloatingForm.HideAgent
    ' 参照）。.actはOfficeプロセスごとに独立したフォームのため、このフラグに関わらず常に隠す
    Public Sub Hide(id As String, Optional checkOtherApps As Boolean = False)
        If IsAct(id) Then
            ActorFloatingForm.Instance?.HideActorAgent()
        Else
            AgentFloatingForm.Instance?.HideAgent(checkOtherApps)
        End If
    End Sub

    ' 設定タスクパネルの「キャラクター」コンボから呼ばれる：表示中のキャラクターを差し替える。
    ' 切替先・切替元が別エンジンをまたぐ場合、元エンジン側を隠し、表示状態（表示中だったか
    ' どうか）を新エンジン側に引き継ぐ（AgentFloatingForm.SwitchCharacterと同じ方針）
    Public Function SwitchTo(info As AgentCharacterCatalog.CharacterInfo) As Boolean
        If info.Format = AgentCharacterCatalog.CharacterFormat.Act Then
            Dim wasAgentVisible = AgentFloatingForm.Instance IsNot Nothing AndAlso AgentFloatingForm.Instance.IsCharacterVisible
            If wasAgentVisible Then AgentFloatingForm.Instance.HideAgent()
            Dim succeeded = EnsureActorForm().SwitchCharacter(info.AcsPath)
            If succeeded AndAlso wasAgentVisible Then ActorFloatingForm.Instance.ShowActorAgent()
            Return succeeded
        Else
            Dim wasActorVisible = ActorFloatingForm.Instance IsNot Nothing AndAlso ActorFloatingForm.Instance.IsActorVisible
            If wasActorVisible Then ActorFloatingForm.Instance.HideActorAgent()
            Dim succeeded = AgentFloatingForm.Instance IsNot Nothing AndAlso AgentFloatingForm.Instance.SwitchCharacter(info.Id)
            If succeeded AndAlso wasActorVisible Then AgentFloatingForm.Instance.ShowAgent()
            Return succeeded
        End If
    End Function

    ' 設定タスクパネルの「アニメーション設定」グリッドの選択肢一覧。
    ' .acsは収録されているアニメーション名、.actは収録数から組み立てた「番号: MsoAnimationType名」
    ' （対応する名前がない番号は「アクション N」）
    Public Function GetAnimationChoices(id As String) As List(Of String)
        If IsAct(id) Then
            Dim count = AgentCharacterCatalog.ResolveLiveActionCount(id)
            Return Enumerable.Range(0, count).Select(Function(i) FormatActAnimationChoice(i)).ToList()
        End If
        Dim names = AgentFloatingForm.Instance?.GetAvailableAnimationNames()
        Return If(names IsNot Nothing, names.ToList(), New List(Of String))
    End Function

    ' .actのアクション番号の表示名。Office97実機（DOLPHIN.ACT）を目視確認した結果、
    ' Office97のAssistantはMsoAnimationTypeの数値をそのまま.actのアクションIDとして使っていた
    ' ことが判明したため、既知の番号にはOffice本家と同じ名前を表示する（未検証の番号は
    ' キャラクター固有の拡張アクションの可能性があるため「アクション N」のまま表示する）
    Public Function FormatActAnimationChoice(actionId As Integer) As String
        If [Enum].IsDefined(GetType(MsoAnimationType), actionId) Then
            Dim name = [Enum].GetName(GetType(MsoAnimationType), actionId)
            Return $"{actionId}: {name.Substring("msoAnimation".Length)}"
        End If
        Return $"アクション {actionId}"
    End Function

    ' FormatActAnimationChoiceが返した表示文字列（"24: Thinking"または
    ' "アクション 24"）から、先頭のアクション番号を取り出す。パースできない場合は-1
    Private Function ParseActAnimationChoice(value As String) As Integer
        Dim colonIndex = value.IndexOf(":"c)
        Dim numPart = If(colonIndex >= 0, value.Substring(0, colonIndex), value.Replace("アクション", "")).Trim()
        Dim actionId As Integer
        If Integer.TryParse(numPart, actionId) Then Return actionId
        Return -1
    End Function

    ' 設定タスクパネルの「アニメーション設定」グリッドの「試しに再生」ボタンから呼ばれる。
    ' .actは整数IDとして解釈できる場合のみ再生する（不正な値は無視する）
    Public Sub PreviewAnimation(id As String, value As String)
        If String.IsNullOrEmpty(value) Then Return
        If IsAct(id) Then
            Dim actionId = ParseActAnimationChoice(value)
            If actionId >= 0 Then
                ActorFloatingForm.Instance?.PlayAction(actionId)
            End If
        Else
            AgentFloatingForm.Instance?.PlayAnimation(value)
        End If
    End Sub

    ' 現在画面に表示されているキャラクターが.actか.acsかを判定する（IsVisible(id)と違い、
    ' 呼び出し元はキャラクターIDを持たない汎用コード＝AI応答/検索吹き出し関連の共通処理から使う）
    Private Function IsActShowing() As Boolean
        Return ActorFloatingForm.Instance IsNot Nothing AndAlso ActorFloatingForm.Instance.IsActorVisible
    End Function

    ' AI応答吹き出し（ResponseBalloonForm）・検索吹き出し（SearchBalloonForm）の表示位置計算に使う、
    ' 現在表示中のキャラクターの画面上位置とmag（論理→物理ピクセル変換係数）。
    ' .actは素のスクリーン座標のためmag=1.0固定、.acsはAxAgent座標系（モニタ間の論理ピクセル）
    ' のためAgentFloatingForm.GetWindowMagで物理ピクセルへ変換する
    Public Function GetActiveCharacterScreenPosition() As (Left As Integer, Top As Integer, Mag As Single)
        If IsActShowing() Then Return (ActorFloatingForm.Instance.Left, ActorFloatingForm.Instance.Top, 1.0F)
        If AgentFloatingForm.Instance IsNot Nothing Then Return AgentFloatingForm.Instance.GetAgentScreenPosition()
        Return (0, 0, 1.0F)
    End Function

    ' 論理名(.acsのResolveCharacterAnimationと共通の呼び名)からMsoAnimationTypeへの対応。
    ' Office97実機（DOLPHIN.ACT）を目視確認した結果、.actのアクション番号はMsoAnimationTypeの
    ' 数値をそのまま使っていることが判明したため、.actでも同じ数値でPlayActionする
    Private ReadOnly LogicalNameToMsoAnimation As New Dictionary(Of String, MsoAnimationType)(StringComparer.OrdinalIgnoreCase) From {
        {"RestPose", MsoAnimationType.msoAnimationIdle},
        {"Greeting", MsoAnimationType.msoAnimationGreeting},
        {"Goodbye", MsoAnimationType.msoAnimationGoodbye},
        {"Thinking", MsoAnimationType.msoAnimationThinking}
    }

    ' 「考え中」「休止」「挨拶」「お別れ」等、意味ベースのアニメーション再生。.acsは
    ' ResolveCharacterAnimationで実際のアニメーション名へ変換してAxAgentへ渡す。.actは対応する
    ' MsoAnimationType番号があり、かつ現在のキャラクターの収録数に収まっていればPlayActionし、
    ' 無ければStopPlaybackのみ行い見た目を落ち着かせる（未知のキャラクターでの誤動作を避けるため）。
    ' 戻り値は.actで実際に再生したアクションID（ActorFloatingForm.HideActorAgentが、
    ' ActionFinishedイベントで「今再生させた本人が完了したか」を見分けるために使う。
    ' StopPlaybackが直前のアクションのActionFinishedを誤発火させても、アクションIDが
    ' 一致しなければ無視できる）。.acsの場合や再生できなかった場合はNothing
    Public Function PlayCommonAnimation(logicalName As String) As Integer?
        If IsActShowing() Then
            Dim msoType As MsoAnimationType
            Dim actor = ActorFloatingForm.Instance
            If LogicalNameToMsoAnimation.TryGetValue(logicalName, msoType) AndAlso CInt(msoType) < actor.ActionCount Then
                actor.PlayAction(CInt(msoType))
                Return CInt(msoType)
            End If
            actor.StopPlayback()
            Return Nothing
        End If
        AgentFloatingForm.Instance?.PlayLogicalAnimation(logicalName)
        Return Nothing
    End Function

End Module
