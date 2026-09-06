Imports System.Drawing.Drawing2D

' カイル君（キャラクター）を左クリックした時に表示される検索吹き出し。
' 以前は AxAgent（MS Agent ActiveXコントロール）を抱える AgentFloatingForm と
' 同じFormにSearchBox等のコントロールが同居していたが、「Word起動直後はキーボード
' ショートカットが効かない」不具合の調査の一環として、AxAgentのホストとこの検索UIとを
' 完全に別のFormへ分離した。
' ResponseBalloonForm（AI応答の吹き出し）と同じく、コード上で直接コントロールを
' 組み立てる方式を踏襲している。
Public Class SearchBalloonForm
    Inherits Form

    Private ReadOnly _owner As AgentFloatingForm
    Private WithEvents _searchBox As TextBox
    Private WithEvents _searchBtn As Button
    Private WithEvents _closeBtn As Button
    Private ReadOnly _label As Label
    Private ReadOnly _tooltip As New ToolTip()

    Private Const SearchPlaceholderText As String = "ここに質問文を入力し、［検索］ をクリックしてください！"
    Private ReadOnly SearchPlaceholderColor As Drawing.Color = Drawing.Color.FromArgb(160, 160, 160)
    Private ReadOnly _searchTextColor As Drawing.Color

    Protected Overrides ReadOnly Property ShowWithoutActivation As Boolean
        Get
            Return True
        End Get
    End Property

    Public Sub New(owner As AgentFloatingForm)
        _owner = owner

        _label = New Label()
        _searchBox = New TextBox()
        _searchBtn = New Button()
        _closeBtn = New Button()

        SuspendLayout()

        ShowInTaskbar = False
        FormBorderStyle = FormBorderStyle.None
        StartPosition = FormStartPosition.Manual
        MaximizeBox = False
        MinimizeBox = False
        ShowIcon = False
        SizeGripStyle = SizeGripStyle.Hide
        ' 【重要】TopMost=Trueは、ShowWithoutActivation=Trueのフォームに設定したままにすると
        ' Wordのキーボードフォーカス管理を壊す（Alt+Tabするまでショートカットが効かない）ことが
        ' 実機検証で判明した。そのため常時ONにせず、OnVisibleChangedで実際に表示している間だけONにする
        DoubleBuffered = True
        BackColor = Drawing.Color.FromArgb(255, 255, 154)
        AcceptButton = _searchBtn
        CancelButton = _closeBtn
        Text = "OfficeAgent"

        _label.AutoSize = True
        _label.BackColor = Drawing.Color.FromArgb(255, 255, 154)
        _label.FlatStyle = FlatStyle.System
        _label.Font = New Drawing.Font("MS UI Gothic", 15.75!, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CType(128, Byte))
        _label.Location = New Drawing.Point(13, 25)
        _label.Text = "何について調べますか？"
        Controls.Add(_label)

        _searchBox.AllowDrop = True
        _searchBox.BorderStyle = BorderStyle.FixedSingle
        _searchBox.Font = New Drawing.Font("MS UI Gothic", 12.0!)
        _searchBox.Location = New Drawing.Point(15, 60)
        _searchBox.MaxLength = 10000
        _searchBox.Multiline = True
        _searchBox.ScrollBars = ScrollBars.Vertical
        _searchBox.Size = New Drawing.Size(350, 60)
        Controls.Add(_searchBox)

        _searchBtn.BackColor = Drawing.Color.FromArgb(255, 255, 154)
        _searchBtn.FlatStyle = FlatStyle.Flat
        _searchBtn.Font = New Drawing.Font("MS UI Gothic", 11.0!)
        _searchBtn.Location = New Drawing.Point(220, 130)
        _searchBtn.Size = New Drawing.Size(130, 35)
        _searchBtn.Text = "検索(&S)"
        _searchBtn.UseVisualStyleBackColor = False
        Controls.Add(_searchBtn)

        _closeBtn.BackColor = Drawing.Color.FromArgb(255, 255, 154)
        _closeBtn.DialogResult = DialogResult.Cancel
        _closeBtn.FlatStyle = FlatStyle.Flat
        _closeBtn.Font = New Drawing.Font("MS UI Gothic", 11.0!)
        _closeBtn.Location = New Drawing.Point(20, 130)
        _closeBtn.Size = New Drawing.Size(130, 35)
        _closeBtn.Text = "閉じる(&C)"
        _closeBtn.UseVisualStyleBackColor = False
        Controls.Add(_closeBtn)

        ClientSize = New Drawing.Size(390, 200)
        Region = New Drawing.Region(CreateBalloonPath(ClientSize.Width, ClientSize.Height))

        ResumeLayout(False)

        _searchTextColor = _searchBox.ForeColor
        ShowSearchPlaceholder()
        _tooltip.SetToolTip(_closeBtn, "吹き出しを閉じます")
    End Sub

    ' 【重要】TopMostは実際に表示している間だけON。非表示中もONのままにしておくと、
    ' ShowWithoutActivation=Trueと組み合わさってWordのキーボードフォーカス管理を壊すため
    Protected Overrides Sub OnVisibleChanged(e As EventArgs)
        MyBase.OnVisibleChanged(e)
        TopMost = Visible
    End Sub

    ' 検索エンジン／AIプロバイダ設定が変わった時などにAgentFloatingForm側から呼ばれる
    Public Sub SetSearchTooltip(text As String)
        _tooltip.SetToolTip(_searchBtn, text)
    End Sub

    ' カイル左クリック時に、キャラクターの現在位置の近くへ表示する
    Public Sub ShowNear(agentLogicalLeft As Integer, agentLogicalTop As Integer, mag As Single)
        RepositionNear(agentLogicalLeft, agentLogicalTop, mag)
        Opacity = 1.0
        Show()
    End Sub

    ' ドラッグ中などにキャラクターへ追従させる（非表示中に呼ばれても位置だけ更新すればよい）
    Public Sub RepositionNear(agentLogicalLeft As Integer, agentLogicalTop As Integer, mag As Single)
        Location = New Drawing.Point(CInt(agentLogicalLeft * mag) - 207, CInt(agentLogicalTop * mag) - 186)
    End Sub

    Private Sub SearchBox_TextUpdate(sender As Object, e As EventArgs) Handles _searchBox.KeyDown
        _owner.PlayWritingAnimation()
    End Sub

    Private Sub TextBox_Active(sender As Object, e As EventArgs) Handles _searchBox.GotFocus, _searchBox.MouseClick
        HideSearchPlaceholder()
    End Sub

    Private Sub SearchBox_Leave(sender As Object, e As EventArgs) Handles _searchBox.Leave
        If _searchBox.Text.Length = 0 Then ShowSearchPlaceholder()
    End Sub

    Private Sub ShowSearchPlaceholder()
        _searchBox.Text = SearchPlaceholderText
        _searchBox.ForeColor = SearchPlaceholderColor
    End Sub

    Private Sub HideSearchPlaceholder()
        If _searchBox.ForeColor = SearchPlaceholderColor Then
            _searchBox.Text = String.Empty
            _searchBox.ForeColor = _searchTextColor
        End If
    End Sub

    '検索クリック時
    Private Async Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles _searchBtn.Click
        If _searchBox.ForeColor = SearchPlaceholderColor OrElse String.IsNullOrWhiteSpace(_searchBox.Text) Then Return
        Dim searchText = _searchBox.Text.ToString()
        Await _owner.ExecuteSearch(searchText)
    End Sub

    '閉じるクリック時
    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles _closeBtn.Click
        _owner.StopAndRest()
        Hide()
    End Sub

    Private Function CreateBalloonPath(w As Integer, h As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        Dim r = 15          ' 角丸半径
        Dim tailH = 14      ' しっぽの高さ
        Dim bh = h - tailH  ' 本体の高さ
        Dim tailCx = w \ 2  ' しっぽ基部中心X（ウィンドウ中央）
        Dim tailW = 9       ' しっぽの半幅
        Dim tailTipX = tailCx + 12  ' しっぽ先端X（少し右寄り）

        path.AddArc(0, 0, r * 2, r * 2, 180, 90)                  ' 左上角
        path.AddArc(w - r * 2, 0, r * 2, r * 2, 270, 90)          ' 右上角
        path.AddArc(w - r * 2, bh - r * 2, r * 2, r * 2, 0, 90)  ' 右下角
        path.AddLine(w - r, bh, tailCx + tailW, bh)               ' 底辺右側
        path.AddLine(tailCx + tailW, bh, tailTipX, h)             ' しっぽ右斜辺
        path.AddLine(tailTipX, h, tailCx - tailW, bh)             ' しっぽ左斜辺
        path.AddArc(0, bh - r * 2, r * 2, r * 2, 90, 90)         ' 左下角
        path.CloseFigure()

        Return path
    End Function

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Using path = CreateBalloonPath(ClientSize.Width, ClientSize.Height)
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
            Using pen As New Drawing.Pen(Drawing.Color.FromArgb(160, 130, 30), 2.0F)
                e.Graphics.DrawPath(pen, path)
            End Using
        End Using
    End Sub

End Class
