<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        AxAgent = New AxAgentObjects.AxAgent()
        NotifyIcon = New NotifyIcon(components)
        SearchBox = New TextBox()
        Search = New Button()
        Label1 = New Label()
        CloseApp = New Button()
        AgentMenu = New ContextMenuStrip(components)
        SearchEngine = New ToolStripComboBox()
        Animation = New ToolStripComboBox()
        Separator1 = New ToolStripSeparator()
        MenuSetting = New ToolStripMenuItem()
        Separator2 = New ToolStripSeparator()
        MenuExit = New ToolStripMenuItem()
        ToolTip = New ToolTip(components)
        Timer1 = New Timer(components)
        BindingSource1 = New BindingSource(components)
        ElementHost1 = New Integration.ElementHost()
        CType(AxAgent, ComponentModel.ISupportInitialize).BeginInit()
        AgentMenu.SuspendLayout()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' AxAgent
        ' 
        AxAgent.Enabled = True
        AxAgent.Location = New Point(228, 9)
        AxAgent.Margin = New Padding(4, 5, 4, 5)
        AxAgent.Name = "AxAgent"
        AxAgent.OcxState = CType(resources.GetObject("AxAgent.OcxState"), AxHost.State)
        AxAgent.Size = New Size(32, 32)
        AxAgent.TabIndex = 0
        ' 
        ' NotifyIcon
        ' 
        NotifyIcon.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon.BalloonTipText = "Google 検索できます。"
        NotifyIcon.BalloonTipTitle = "カイル君"
        NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), Icon)
        NotifyIcon.Text = "カイル君"
        NotifyIcon.Visible = True
        ' 
        ' SearchBox
        ' 
        SearchBox.AllowDrop = True
        SearchBox.BorderStyle = BorderStyle.FixedSingle
        SearchBox.Font = New Font("MS UI Gothic", 12F)
        SearchBox.Location = New Point(15, 60)
        SearchBox.Margin = New Padding(4, 5, 4, 5)
        SearchBox.MaxLength = 10000
        SearchBox.Multiline = True
        SearchBox.Name = "SearchBox"
        SearchBox.ScrollBars = ScrollBars.Vertical
        SearchBox.Size = New Size(350, 60)
        SearchBox.TabIndex = 1
        SearchBox.Text = "ここに質問文を入力し、［検索］ をクリックしてください！"
        ' 
        ' Search
        ' 
        Search.BackColor = Color.Beige
        Search.BackgroundImageLayout = ImageLayout.None
        Search.FlatStyle = FlatStyle.Flat
        Search.Font = New Font("MS UI Gothic", 11F)
        Search.Location = New Point(220, 130)
        Search.Margin = New Padding(1, 2, 1, 2)
        Search.Name = "Search"
        Search.Size = New Size(130, 35)
        Search.TabIndex = 2
        Search.Text = "検索(&S)"
        Search.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Beige
        Label1.FlatStyle = FlatStyle.System
        Label1.Font = New Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label1.Location = New Point(13, 25)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(265, 27)
        Label1.TabIndex = 0
        Label1.Text = "何について調べますか？"
        ' 
        ' CloseApp
        ' 
        CloseApp.BackColor = Color.Beige
        CloseApp.DialogResult = DialogResult.Cancel
        CloseApp.FlatStyle = FlatStyle.Flat
        CloseApp.Font = New Font("MS UI Gothic", 11F)
        CloseApp.Location = New Point(20, 130)
        CloseApp.Margin = New Padding(1, 2, 1, 2)
        CloseApp.Name = "CloseApp"
        CloseApp.Size = New Size(130, 35)
        CloseApp.TabIndex = 3
        CloseApp.Text = "閉じる(&C)"
        CloseApp.UseVisualStyleBackColor = False
        ' 
        ' AgentMenu
        ' 
        AgentMenu.ImageScalingSize = New Size(20, 20)
        AgentMenu.Items.AddRange(New ToolStripItem() {SearchEngine, Animation, Separator1, MenuSetting, Separator2, MenuExit})
        AgentMenu.Name = "AgentMenu"
        AgentMenu.ShowImageMargin = False
        AgentMenu.Size = New Size(157, 128)
        ' 
        ' SearchEngine
        ' 
        SearchEngine.DropDownStyle = ComboBoxStyle.DropDownList
        SearchEngine.FlatStyle = FlatStyle.Flat
        SearchEngine.Name = "SearchEngine"
        SearchEngine.Size = New Size(121, 28)
        ' 
        ' Animation
        ' 
        Animation.DropDownStyle = ComboBoxStyle.DropDownList
        Animation.FlatStyle = FlatStyle.Flat
        Animation.Name = "Animation"
        Animation.Size = New Size(121, 28)
        Animation.Sorted = True
        ' 
        ' Separator1
        ' 
        Separator1.Name = "Separator1"
        Separator1.Size = New Size(153, 6)
        ' 
        ' MenuSetting
        ' 
        MenuSetting.AutoToolTip = True
        MenuSetting.Name = "MenuSetting"
        MenuSetting.Size = New Size(156, 24)
        MenuSetting.Text = "設定"
        MenuSetting.ToolTipText = "設定"
        ' 
        ' Separator2
        ' 
        Separator2.Name = "Separator2"
        Separator2.Size = New Size(153, 6)
        ' 
        ' MenuExit
        ' 
        MenuExit.AutoToolTip = True
        MenuExit.DisplayStyle = ToolStripItemDisplayStyle.Text
        MenuExit.Name = "MenuExit"
        MenuExit.Size = New Size(156, 24)
        MenuExit.Text = "終了"
        ' 
        ' ToolTip
        ' 
        ToolTip.ForeColor = SystemColors.ControlText
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 800
        ' 
        ' ElementHost1
        ' 
        ElementHost1.Location = New Point(0, 0)
        ElementHost1.Name = "ElementHost1"
        ElementHost1.TabIndex = 0
        ElementHost1.Text = "ElementHost1"
        ' 
        ' MainWindow
        ' 
        AcceptButton = Search
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.Beige
        BackgroundImageLayout = ImageLayout.Zoom
        CancelButton = CloseApp
        ClientSize = New Size(380, 180)
        Controls.Add(CloseApp)
        Controls.Add(Label1)
        Controls.Add(Search)
        Controls.Add(SearchBox)
        Controls.Add(AxAgent)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 5, 4, 5)
        MaximizeBox = False
        MinimizeBox = False
        Name = "MainWindow"
        ShowIcon = False
        ShowInTaskbar = False
        SizeGripStyle = SizeGripStyle.Hide
        Text = "Form1"
        TopMost = True
        CType(AxAgent, ComponentModel.ISupportInitialize).EndInit()
        AgentMenu.ResumeLayout(False)
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents AxAgent As AxAgentObjects.AxAgent
    Friend WithEvents NotifyIcon As NotifyIcon
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents Search As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CloseApp As Button
    Friend WithEvents AgentMenu As ContextMenuStrip
    Friend WithEvents MenuExit As ToolStripMenuItem
    Friend WithEvents Animation As ToolStripComboBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents SearchEngine As ToolStripComboBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Separator2 As ToolStripSeparator
    Friend WithEvents ElementHost1 As Integration.ElementHost
    Friend WithEvents MenuSetting As ToolStripMenuItem
    Friend WithEvents Separator1 As ToolStripSeparator
End Class
