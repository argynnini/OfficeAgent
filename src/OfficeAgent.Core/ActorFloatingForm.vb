Imports System.Windows.Forms

' .act形式（Microsoft Actor）キャラクターの表示用フォーム（フェーズ1・最小実装）。
' AgentFloatingForm（AxAgent／Microsoft Agent専用）とは完全に別系統とし、
' スピーカーノート読み上げ等の発話中操作タグ連携はまだ対応しない。
' 「デスクトップ上にキャラクターを表示し、ドラッグで動かし、アクションを再生できる」
' という最小限の体験のみを提供する。
Public Class ActorFloatingForm
    Inherits Form

    Public Shared Instance As ActorFloatingForm

    Private WithEvents _actor As New FrontierActorControl.FrontierActorControl()
    Private _loadedPath As String

    ' 右クリックメニューの構成は、AgentFloatingFormのAgentMenu（アニメーションコンボ／設定／終了）に
    ' 合わせる。アクションはMicrosoft Agentの名前指定と違い整数IDでしか指定できないため、
    ' 同じ位置に置く一覧コンボの中身が「アニメーション名の一覧」ではなく「アクション0～N」になる
    Private WithEvents _actionCombo As New ToolStripComboBox() With {.DropDownStyle = ComboBoxStyle.DropDownList}
    Private WithEvents _menuSetting As New ToolStripMenuItem("設定")
    Private WithEvents _menuExit As New ToolStripMenuItem("終了")
    Private WithEvents _contextMenu As New ContextMenuStrip()

    Protected Overrides ReadOnly Property ShowWithoutActivation As Boolean
        Get
            Return True
        End Get
    End Property

    Public Sub New()
        Instance = Me

        ShowInTaskbar = False
        FormBorderStyle = FormBorderStyle.None
        StartPosition = FormStartPosition.Manual
        TopMost = True

        ' FrontierActorControl.TransparentBackground（既定True）は「親コントロールの背景を
        ' そのまま描画する」疑似透過でしかなく、デスクトップに対してはこのフォーム自体の
        ' 背景色がそのまま見えてしまう（何も設定しないとWindows既定の白系になる）。
        ' TransparencyKeyでフォームをこのキーカラーごとデスクトップへ透過させることで、
        ' _actorが描画する（親の背景色=このキーカラーを引き継いだ）余白部分も透けるようにする
        BackColor = Drawing.Color.Magenta
        TransparencyKey = Drawing.Color.Magenta

        _actor.Dock = DockStyle.Fill
        _actor.AutoIdleEnabled = True
        _actor.DragEnabled = True
        _actor.DragMode = FrontierActorControl.FrontierActorControl.ActorDragMode.FreeRoamForm
        Controls.Add(_actor)

        _contextMenu.Items.AddRange({
            CType(_actionCombo, ToolStripItem),
            New ToolStripSeparator(),
            _menuSetting,
            New ToolStripSeparator(),
            _menuExit
        })
        ContextMenuStrip = _contextMenu
        _actor.ContextMenuStrip = _contextMenu

        HookClickDetection()
    End Sub

    ' FrontierActorControlは内部にDockStyle.Fillの子PictureBoxを持ち、実際のマウス入力は
    ' すべてその子コントロールが受け取る（WinFormsでは子のマウスイベントは親にバブルしない
    ' ため、_actor自身のClick/MouseDownをHandlesしても発火しない）。
    ' FrontierActorControl自身がドラッグ機能のために子孫コントロールツリーへ直接
    ' MouseDown/MouseUpハンドラをアタッチし、MouseDown時にCaptureを自分自身へ移す実装に
    ' なっている（実機のDLLを逆コンパイルして確認済み）ため、同じ手法でクリックを検出する。
    ' Capture中はMouseUpが子ではなく_actor自身に配送されるため、移動量が小さければ
    ' クリックとみなす自前判定を行う（サブクラス化／WndProcフックは実機で不具合が
    ' 出たため使わない）
    Private _clickCandidate As Boolean
    Private _clickStartScreen As Drawing.Point
    Private Const ClickMoveThreshold As Integer = 4

    Private Sub HookClickDetection()
        HookClickDetectionRecursive(_actor)
    End Sub

    Private Sub HookClickDetectionRecursive(root As Control)
        If root Is Nothing Then Return
        AddHandler root.MouseDown, AddressOf AnySurface_MouseDown
        AddHandler root.MouseUp, AddressOf AnySurface_MouseUp
        For Each child As Control In root.Controls
            HookClickDetectionRecursive(child)
        Next
    End Sub

    Private Sub AnySurface_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            _clickCandidate = True
            _clickStartScreen = Cursor.Position
        End If
    End Sub

    Private Sub AnySurface_MouseUp(sender As Object, e As MouseEventArgs)
        If Not _clickCandidate Then Return
        _clickCandidate = False
        If e.Button <> MouseButtons.Left Then Return

        Dim current = Cursor.Position
        If Math.Abs(current.X - _clickStartScreen.X) <= ClickMoveThreshold AndAlso
           Math.Abs(current.Y - _clickStartScreen.Y) <= ClickMoveThreshold Then
            _actor.StopPlayback()
            AgentFloatingForm.Instance?.ShowSearchBalloonNear(Left, Top)
        End If
    End Sub

    ' アクションIDと名前の対応付けは、Office97実機解析で判明したMsoAnimationType（.act共通の
    ' 番号体系）をCharacterHostCoordinator.FormatActAnimationChoiceに集約している。対応する
    ' 名前がない番号（キャラクター固有の拡張アクション等）は「アクション N」のまま表示する
    Private Sub PopulateActionCombo()
        With _actionCombo
            .Items.Clear()
            .Items.Add("アクション")
            Dim count = _actor.CharacterAnimationCount
            For i = 0 To count - 1
                .Items.Add(CharacterHostCoordinator.FormatActAnimationChoice(i))
            Next
            .SelectedIndex = .Items.Count - 1
        End With
    End Sub

    ' AgentFloatingFormのAnimation_Click（Handles Animation.DropDownClosed）と同じ挙動：
    ' プレースホルダーのままなら再生中のアクションを止めるだけ、選んでいれば再生する
    Private Sub ActionCombo_DropDownClosed(sender As Object, e As EventArgs) Handles _actionCombo.DropDownClosed
        _actor.StopPlayback()
        If _actionCombo.SelectedIndex > 0 Then
            _actor.PlayAction(_actionCombo.SelectedIndex - 1)
        End If
    End Sub

    Private Sub MenuSetting_Click(sender As Object, e As EventArgs) Handles _menuSetting.Click
        AgentFloatingForm.OpenSettingsPaneAction?.Invoke()
    End Sub

    Private Sub MenuExit_Click(sender As Object, e As EventArgs) Handles _menuExit.Click
        HideActorAgent()
    End Sub

    Public Sub PlayAction(actionId As Integer)
        _actor.StopPlayback()
        _actor.PlayAction(actionId)
    End Sub

    ' CharacterHostCoordinator.PlayCommonAnimationから、.actアクティブ時に呼ばれる
    Public Sub StopPlayback()
        _actor.StopPlayback()
    End Sub

    ' CharacterHostCoordinator.PlayCommonAnimationが、MsoAnimationTypeの番号が
    ' 現在のキャラクターの収録数に収まっているか確認するために参照する
    Public ReadOnly Property ActionCount As Integer
        Get
            Return _actor.CharacterAnimationCount
        End Get
    End Property

    Private Sub Actor_ActorLoadFailed(message As String) Handles _actor.ActorLoadFailed
        MessageBox.Show(
            $"{IO.Path.GetFileName(_loadedPath)} の読み込みに失敗しました。" & Environment.NewLine & message,
            "OfficeAgent", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    ' 読み込み完了後、実サイズに合わせてフォームをリサイズする（読み込み前はPixelWidth/Height
    ' が確定しないため、ActorLoadedを待って行う）。
    ' デスクトップに背景無しで浮かせる透過表示（TransparencyColor）は、手元の.actファイルでは
    ' 値が取得できない（Color.Empty）ケースが実機で確認されており、フェーズ1では見送る
    ' （挙動が不安定なTransparencyKeyを設定するより、単色背景のウィンドウとして表示する方が安全）
    Private Sub Actor_ActorLoaded() Handles _actor.ActorLoaded
        If _actor.PixelWidth > 0 AndAlso _actor.PixelHeight > 0 Then
            ClientSize = New Drawing.Size(_actor.PixelWidth, _actor.PixelHeight)
        End If
        ' CharacterAnimationCountは読み込み完了（ここ）まで確定しない（.actの読み込みは非同期の
        ' ため、AgentFloatingForm.SwitchCharacterのように切替直後に同期的な再構築ができない）
        PopulateActionCombo()

        ' 初回表示（ShowActorAgentが読み込みも兼ねた場合）はロード完了がShowActorAgentの
        ' 呼び出しより後になるため、Greetingの再生をここまで遅延させる
        If _pendingGreetingOnLoad Then
            _pendingGreetingOnLoad = False
            CharacterHostCoordinator.PlayCommonAnimation("Greeting")
        End If
    End Sub

    Private Function ResolveActPath() As String
        Dim found = AgentCharacterCatalog.DiscoverCharacters().
            FirstOrDefault(Function(c) c.Format = AgentCharacterCatalog.CharacterFormat.Act)
        Return found.AcsPath
    End Function

    Public ReadOnly Property IsActorVisible As Boolean
        Get
            Return Visible
        End Get
    End Property

    ' ShowActorAgentが読み込みも兼ねた場合、.actの読み込みは非同期なため、この時点では
    ' まだCharacterAnimationCountが確定していない。ロード完了（Actor_ActorLoaded）まで
    ' Greeting再生を持ち越すためのフラグ
    Private _pendingGreetingOnLoad As Boolean

    ' AgentFloatingForm.ShowAgentと同じく、表示のたびにGreetingを再生する。
    ' LoadCharacterInternal（_actor.SourceFileのセット）は多くの場合非同期ロードだが、
    ' キャッシュ等の条件次第ではActorLoadedイベントがほぼ即座（同期的）に発火することがあるため、
    ' フラグは必ずロード開始より前に立てておく（後から立てると、その前にイベントが
    ' 発火してGreetingの再生自体が永遠に取りこぼされるレースコンディションになる）
    Public Sub ShowActorAgent()
        Dim needsLoad = String.IsNullOrEmpty(_loadedPath)
        If needsLoad Then
            Dim path = ResolveActPath()
            If String.IsNullOrEmpty(path) OrElse Not IO.File.Exists(path) Then
                MessageBox.Show(
                    "agentsフォルダに.actファイルが見つかりません。",
                    "OfficeAgent", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            _pendingGreetingOnLoad = True
            LoadCharacterInternal(path)
        End If
        _actor.ShowActor()
        Show()
        If Not needsLoad Then
            CharacterHostCoordinator.PlayCommonAnimation("Greeting")
        End If
    End Sub

    ' AgentFloatingForm.HideAgentと同じく、非表示にする前にGoodbyeを再生し、再生が完了したら
    ' 実際に隠す。ActionFinished発生時は「DoEventsループの次の周回を待たず」イベントハンドラの
    ' 中で即座にHideActor/Hideを呼ぶ（ループ側のポーリング間隔（最大16ms）の分だけ、完了して
    ' から隠れるまでに間が空いてIdle姿勢が一瞬見えてしまっていたため）。
    ' AutoIdleEnabled（アクション完了後に自動でIdleループへ戻る設定）が有効なままだと、
    ' Goodbye完了直後・Hideするまでの間に一瞬Idle姿勢へ切り替わってしまうため、
    ' 隠し終わるまで一時的に無効化する。
    ' ActorFloatingForm.PlayAction（PlayCommonAnimationが内部で呼ぶ）は、新しいアクションを
    ' 再生する前に必ずStopPlaybackを呼んでいる。もしStopPlaybackが「中断された直前のアクション
    ' （Idleループ等）」のActionFinishedを即座に発火させる実装だと、これから始まるGoodbye自体が
    ' 再生されるより前に完了扱いになってしまい、再生し切る前に隠れてしまう
    ' （実機で「アニメーションが見えない」不具合として確認）。そのためactionIdが今回
    ' 再生させた本人（Goodbyeのアクション番号）と一致した場合のみ完了とみなす。
    ' 万一ActionFinishedが来ない場合に備え、最大5秒のタイムアウトも残す
    ' （Shutdown処理を無期限にブロックしないため）
    Public Sub HideActorAgent()
        Dim originalAutoIdle = _actor.AutoIdleEnabled
        _actor.AutoIdleEnabled = False

        Dim targetActionId As Integer? = Nothing
        Dim hidden As Boolean = False
        Dim handler As FrontierActorControl.FrontierActorControl.ActionFinishedEventHandler = Nothing

        Dim doHide =
            Sub()
                If hidden Then Return
                hidden = True
                RemoveHandler _actor.ActionFinished, handler
                _actor.HideActor()
                Hide()
                _actor.AutoIdleEnabled = originalAutoIdle
            End Sub

        handler = Sub(actionId)
                      If targetActionId.HasValue AndAlso actionId = targetActionId.Value Then doHide()
                  End Sub
        AddHandler _actor.ActionFinished, handler

        targetActionId = CharacterHostCoordinator.PlayCommonAnimation("Goodbye")
        If targetActionId.HasValue Then
            Dim sw = Diagnostics.Stopwatch.StartNew()
            While Not hidden AndAlso sw.ElapsedMilliseconds < 5000
                Application.DoEvents()
                Threading.Thread.Sleep(16)
            End While
        End If
        doHide()
    End Sub

    Private _positioned As Boolean

    ' 初回表示位置のみ、Kyle（AxAgent）と同じ基準（Officeウィンドウのあるモニタ）の
    ' 右下隅に置く（AgentFloatingForm.ResolveHostScreen参照）。以降のキャラクター切替
    ' （SwitchCharacter）では位置を変えない（AgentFloatingForm.SwitchCharacterが
    ' leftPos/topPosを引き継ぐのと同じ考え方）
    Private Sub EnsurePositioned()
        If _positioned Then Return
        Dim targetScreen = AgentFloatingForm.ResolveHostScreen()
        Left = targetScreen.Bounds.Left + targetScreen.Bounds.Width - 200
        Top = targetScreen.Bounds.Top + targetScreen.Bounds.Height - 250
        _positioned = True
    End Sub

    Private Sub LoadCharacterInternal(path As String)
        _loadedPath = path
        _actor.SourceFile = path
        EnsurePositioned()
    End Sub

    ' 設定タスクパネルの「キャラクター」欄から呼ばれる：表示中のキャラクター(.act)を差し替える。
    ' 表示中／非表示中のどちらの状態だったかは維持する（AgentFloatingForm.SwitchCharacterと同じ方針）。
    ' 別のキャラクター形式(.acs)からの切替でこのフォーム自体をまだ表示すべきかどうかは、
    ' 呼び出し元（AgentSettingsPane）がShowActorAgent/HideActorAgentで別途制御する
    Public Function SwitchCharacter(acsPath As String) As Boolean
        If String.IsNullOrEmpty(acsPath) OrElse Not IO.File.Exists(acsPath) Then
            MessageBox.Show(
                $"{IO.Path.GetFileName(acsPath)} が見つかりません。",
                "OfficeAgent", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Dim wasVisible = Visible
        LoadCharacterInternal(acsPath)
        If wasVisible Then
            _actor.ShowActor()
            Show()
        End If
        Return True
    End Function

    ' AgentCharacterCatalog（キャラクター選択コンボの表示名／GPTルール既定文の生成）から呼ばれる、
    ' .actに埋め込まれたCharacterName/CharacterDescriptionの取得。表示中のキャラクターに
    ' 影響を与えないよう、画面外に置いた専用の一時コントロールで読み込む。
    ' 読み込みは非同期（ActorLoadedイベント）のため、呼び出し元のメッセージポンプを
    ' DoEventsで回しながら完了を待つ（最大2秒でタイムアウト）。
    ' 一部の.actファイルではCharacterNameが埋め込まれておらず、コントロールが代わりに
    ' プレースホルダー"???"を返すことを実機（dolphin.act）で確認しているため、その場合は
    ' 「取得できなかった」扱い（Nothing）にし、呼び出し元のファイル名ベースの表示名に委ねる
    Public Shared Function TryReadCharacterProfile(actPath As String) As (Name As String, Description As String, ActionCount As Integer)
        Try
            Dim probe As New FrontierActorControl.FrontierActorControl()
            Dim loaded = False
            Dim failed = False
            AddHandler probe.ActorLoaded, Sub() loaded = True
            AddHandler probe.ActorLoadFailed, Sub(message As String) failed = True

            Using host As New Form()
                host.ShowInTaskbar = False
                host.FormBorderStyle = FormBorderStyle.None
                host.StartPosition = FormStartPosition.Manual
                host.Bounds = New Drawing.Rectangle(-4000, -4000, 10, 10)
                host.Controls.Add(probe)
                host.Show()
                Try
                    probe.SourceFile = actPath
                    Dim deadline = Environment.TickCount + 2000
                    While Not loaded AndAlso Not failed AndAlso Environment.TickCount < deadline
                        Application.DoEvents()
                        Threading.Thread.Sleep(10)
                    End While
                    If Not loaded Then Return (Nothing, Nothing, 0)
                    Dim name = If(String.IsNullOrWhiteSpace(probe.CharacterName) OrElse probe.CharacterName = "???", Nothing, probe.CharacterName)
                    Dim description = If(String.IsNullOrWhiteSpace(probe.CharacterDescription) OrElse probe.CharacterDescription = "???", Nothing, probe.CharacterDescription)
                    Return (name, description, probe.CharacterAnimationCount)
                Finally
                    host.Hide()
                End Try
            End Using
        Catch
            Return (Nothing, Nothing, 0)
        End Try
    End Function
End Class
