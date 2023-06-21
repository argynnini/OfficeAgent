<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AxAgent = New AxAgentObjects.AxAgent()
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.Search = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CloseApp = New System.Windows.Forms.Button()
        Me.AgentMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SearchEngine = New System.Windows.Forms.ToolStripComboBox()
        Me.Sound = New System.Windows.Forms.ToolStripComboBox()
        Me.Animation = New System.Windows.Forms.ToolStripComboBox()
        Me.SearchOrGPT = New System.Windows.Forms.ToolStripComboBox()
        Me.Separator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.api_key_input = New System.Windows.Forms.ToolStripTextBox()
        Me.gpt_rule_input = New System.Windows.Forms.ToolStripTextBox()
        Me.Separator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.AxAgent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AgentMenu.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxAgent
        '
        Me.AxAgent.Enabled = True
        Me.AxAgent.Location = New System.Drawing.Point(228, 9)
        Me.AxAgent.Name = "AxAgent"
        Me.AxAgent.OcxState = CType(resources.GetObject("AxAgent.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAgent.Size = New System.Drawing.Size(32, 32)
        Me.AxAgent.TabIndex = 0
        '
        'NotifyIcon
        '
        Me.NotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon.BalloonTipText = "Google 検索できます。"
        Me.NotifyIcon.BalloonTipTitle = "カイル君"
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "カイル君"
        Me.NotifyIcon.Visible = True
        '
        'SearchBox
        '
        Me.SearchBox.AllowDrop = True
        Me.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SearchBox.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.SearchBox.Location = New System.Drawing.Point(10, 45)
        Me.SearchBox.MaxLength = 35
        Me.SearchBox.Multiline = True
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(280, 50)
        Me.SearchBox.TabIndex = 1
        Me.SearchBox.Text = "ここに質問文を入力し、［検索］ をクリックしてください！"
        '
        'Search
        '
        Me.Search.BackColor = System.Drawing.Color.Beige
        Me.Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Search.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Search.Location = New System.Drawing.Point(175, 105)
        Me.Search.Margin = New System.Windows.Forms.Padding(1)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(110, 25)
        Me.Search.TabIndex = 2
        Me.Search.Text = "検索(&S)"
        Me.Search.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Beige
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "何について調べますか？"
        '
        'CloseApp
        '
        Me.CloseApp.BackColor = System.Drawing.Color.Beige
        Me.CloseApp.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseApp.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.CloseApp.Location = New System.Drawing.Point(15, 105)
        Me.CloseApp.Margin = New System.Windows.Forms.Padding(1)
        Me.CloseApp.Name = "CloseApp"
        Me.CloseApp.Size = New System.Drawing.Size(110, 25)
        Me.CloseApp.TabIndex = 3
        Me.CloseApp.Text = "閉じる(&C)"
        Me.CloseApp.UseVisualStyleBackColor = False
        '
        'AgentMenu
        '
        Me.AgentMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchEngine, Me.Sound, Me.Animation, Me.SearchOrGPT, Me.Separator1, Me.api_key_input, Me.gpt_rule_input, Me.Separator2, Me.MenuExit})
        Me.AgentMenu.Name = "AgentMenu"
        Me.AgentMenu.ShowImageMargin = False
        Me.AgentMenu.Size = New System.Drawing.Size(161, 214)
        '
        'SearchEngine
        '
        Me.SearchEngine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SearchEngine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchEngine.Name = "SearchEngine"
        Me.SearchEngine.Size = New System.Drawing.Size(121, 23)
        '
        'Sound
        '
        Me.Sound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Sound.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sound.Name = "Sound"
        Me.Sound.Size = New System.Drawing.Size(121, 23)
        '
        'Animation
        '
        Me.Animation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Animation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Animation.Name = "Animation"
        Me.Animation.Size = New System.Drawing.Size(121, 23)
        Me.Animation.Sorted = True
        '
        'SearchOrGPT
        '
        Me.SearchOrGPT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SearchOrGPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchOrGPT.Name = "SearchOrGPT"
        Me.SearchOrGPT.Size = New System.Drawing.Size(121, 23)
        Me.SearchOrGPT.Sorted = True
        '
        'Separator1
        '
        Me.Separator1.Name = "Separator1"
        Me.Separator1.Size = New System.Drawing.Size(157, 6)
        '
        'api_key_input
        '
        Me.api_key_input.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!)
        Me.api_key_input.Name = "api_key_input"
        Me.api_key_input.Size = New System.Drawing.Size(125, 23)
        '
        'gpt_rule_input
        '
        Me.gpt_rule_input.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!)
        Me.gpt_rule_input.Name = "gpt_rule_input"
        Me.gpt_rule_input.Size = New System.Drawing.Size(125, 23)
        '
        'Separator2
        '
        Me.Separator2.Name = "Separator2"
        Me.Separator2.Size = New System.Drawing.Size(157, 6)
        '
        'MenuExit
        '
        Me.MenuExit.AutoToolTip = True
        Me.MenuExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MenuExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.MenuExit.Name = "MenuExit"
        Me.MenuExit.Size = New System.Drawing.Size(160, 22)
        Me.MenuExit.Text = "終了"
        '
        'ToolTip
        '
        Me.ToolTip.ForeColor = System.Drawing.SystemColors.ControlText
        '
        'Timer1
        '
        Me.Timer1.Interval = 800
        '
        'Form1
        '
        Me.AcceptButton = Me.Search
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CancelButton = Me.CloseApp
        Me.ClientSize = New System.Drawing.Size(300, 140)
        Me.Controls.Add(Me.CloseApp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.SearchBox)
        Me.Controls.Add(Me.AxAgent)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Form1"
        Me.TopMost = True
        CType(Me.AxAgent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AgentMenu.ResumeLayout(False)
        Me.AgentMenu.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AxAgent As AxAgentObjects.AxAgent
    Friend WithEvents NotifyIcon As NotifyIcon
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents Search As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CloseApp As Button
    Friend WithEvents AgentMenu As ContextMenuStrip
    Friend WithEvents Separator1 As ToolStripSeparator
    Friend WithEvents MenuExit As ToolStripMenuItem
    Friend WithEvents Animation As ToolStripComboBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents SearchEngine As ToolStripComboBox
    Friend WithEvents Sound As ToolStripComboBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SearchOrGPT As ToolStripComboBox
    Friend WithEvents Separator2 As ToolStripSeparator
    Friend WithEvents api_key_input As ToolStripTextBox
    Friend WithEvents gpt_rule_input As ToolStripTextBox
End Class
