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
    Private WithEvents _actionMenu As New ToolStripMenuItem("アクション再生")

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

        _actor.Dock = DockStyle.Fill
        _actor.AutoIdleEnabled = True
        _actor.DragEnabled = True
        _actor.DragMode = FrontierActorControl.FrontierActorControl.ActorDragMode.FreeRoamForm
        Controls.Add(_actor)

        Dim menu As New ContextMenuStrip()
        menu.Items.Add(_actionMenu)
        menu.Items.Add(New ToolStripSeparator())
        menu.Items.Add("隠す", Nothing, Sub() HideActorAgent())
        ContextMenuStrip = menu
        _actor.ContextMenuStrip = menu
    End Sub

    ' アクションIDと名前の対応付け（Microsoft Agentの.Play("名前")のような名前ベースの
    ' マッピングテーブル）はまだ無いため、フェーズ1では「アクション0」～「アクションN」という
    ' 連番のまま整数IDで選ばせる。メニューを開くたびに作り直すのは、キャラクター読み込み
    ' （CharacterAnimationCount確定）がメニュー構築より後になるケースがあるため
    Private Sub ActionMenu_DropDownOpening(sender As Object, e As EventArgs) Handles _actionMenu.DropDownOpening
        _actionMenu.DropDownItems.Clear()
        Dim count = _actor.CharacterAnimationCount
        If count <= 0 Then
            _actionMenu.DropDownItems.Add("(未読み込み)").Enabled = False
            Return
        End If
        For i = 0 To count - 1
            Dim actionId = i
            _actionMenu.DropDownItems.Add($"アクション {actionId}", Nothing, Sub() PlayAction(actionId))
        Next
    End Sub

    Public Sub PlayAction(actionId As Integer)
        _actor.StopPlayback()
        _actor.PlayAction(actionId)
    End Sub

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

    Public Sub ShowActorAgent()
        If String.IsNullOrEmpty(_loadedPath) Then
            Dim path = ResolveActPath()
            If String.IsNullOrEmpty(path) OrElse Not IO.File.Exists(path) Then
                MessageBox.Show(
                    "agentsフォルダに.actファイルが見つかりません。",
                    "OfficeAgent", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            LoadCharacterInternal(path)
        End If
        _actor.ShowActor()
        Show()
    End Sub

    Public Sub HideActorAgent()
        _actor.HideActor()
        Hide()
    End Sub

    Private _positioned As Boolean

    ' 初回表示位置のみプライマリスクリーン右下隅に置く。以降のキャラクター切替
    ' （SwitchCharacter）では位置を変えない（AgentFloatingForm.SwitchCharacterが
    ' leftPos/topPosを引き継ぐのと同じ考え方）
    Private Sub EnsurePositioned()
        If _positioned Then Return
        Dim targetScreen = Screen.PrimaryScreen
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
End Class
