<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AgentFloatingForm
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgentFloatingForm))
        Me.AxAgent = New AxAgentObjects.AxAgent()
        Me.AgentMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SearchEngine = New System.Windows.Forms.ToolStripComboBox()
        Me.Animation = New System.Windows.Forms.ToolStripComboBox()
        Me.SeparatorSelection = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuSelectionRoot = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSelectionSummarize = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSelectionTranslate = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSelectionExplain = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSelectionProofread = New System.Windows.Forms.ToolStripMenuItem()
        Me.Separator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuSetting = New System.Windows.Forms.ToolStripMenuItem()
        Me.Separator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.AxAgent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AgentMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'AxAgent
        '
        Me.AxAgent.Enabled = True
        Me.AxAgent.Location = New System.Drawing.Point(228, 9)
        Me.AxAgent.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AxAgent.Name = "AxAgent"
        Me.AxAgent.OcxState = CType(resources.GetObject("AxAgent.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAgent.Size = New System.Drawing.Size(32, 32)
        Me.AxAgent.TabIndex = 0
        '
        'AgentMenu
        '
        Me.AgentMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.AgentMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuSelectionRoot, Me.SeparatorSelection, Me.Animation, Me.Separator1, Me.MenuSetting, Me.Separator2, Me.MenuExit})
        Me.AgentMenu.Name = "AgentMenu"
        Me.AgentMenu.ShowImageMargin = False
        Me.AgentMenu.Size = New System.Drawing.Size(157, 128)
        '
        'SearchEngine
        '
        Me.SearchEngine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SearchEngine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchEngine.Name = "SearchEngine"
        Me.SearchEngine.Size = New System.Drawing.Size(121, 28)
        '
        'Animation
        '
        Me.Animation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Animation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Animation.Name = "Animation"
        Me.Animation.Size = New System.Drawing.Size(121, 28)
        Me.Animation.Sorted = True
        '
        'SeparatorSelection
        '
        Me.SeparatorSelection.Name = "SeparatorSelection"
        Me.SeparatorSelection.Size = New System.Drawing.Size(153, 6)
        '
        'MenuSelectionRoot
        '
        Me.MenuSelectionRoot.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuSelectionSummarize, Me.MenuSelectionTranslate, Me.MenuSelectionExplain, Me.MenuSelectionProofread})
        Me.MenuSelectionRoot.Name = "MenuSelectionRoot"
        Me.MenuSelectionRoot.Size = New System.Drawing.Size(156, 24)
        Me.MenuSelectionRoot.Text = "選択範囲について"
        Me.MenuSelectionRoot.ToolTipText = "文書やシートで選択中の内容についてAIに聞きます"
        '
        'MenuSelectionSummarize
        '
        Me.MenuSelectionSummarize.Name = "MenuSelectionSummarize"
        Me.MenuSelectionSummarize.Size = New System.Drawing.Size(180, 24)
        Me.MenuSelectionSummarize.Tag = "次の文章を要約してください。"
        Me.MenuSelectionSummarize.Text = "要約する"
        '
        'MenuSelectionTranslate
        '
        Me.MenuSelectionTranslate.Name = "MenuSelectionTranslate"
        Me.MenuSelectionTranslate.Size = New System.Drawing.Size(180, 24)
        Me.MenuSelectionTranslate.Tag = "次の文章を日本語に翻訳してください。すでに日本語の場合は英語に翻訳してください。"
        Me.MenuSelectionTranslate.Text = "翻訳する"
        '
        'MenuSelectionExplain
        '
        Me.MenuSelectionExplain.Name = "MenuSelectionExplain"
        Me.MenuSelectionExplain.Size = New System.Drawing.Size(180, 24)
        Me.MenuSelectionExplain.Tag = "次の内容について、分かりやすく解説してください。"
        Me.MenuSelectionExplain.Text = "解説する"
        '
        'MenuSelectionProofread
        '
        Me.MenuSelectionProofread.Name = "MenuSelectionProofread"
        Me.MenuSelectionProofread.Size = New System.Drawing.Size(180, 24)
        Me.MenuSelectionProofread.Tag = "次の文章の誤字脱字や日本語表現のおかしい点を指摘し、修正案を示してください。"
        Me.MenuSelectionProofread.Text = "誤字脱字をチェックする"
        '
        'Separator1
        '
        Me.Separator1.Name = "Separator1"
        Me.Separator1.Size = New System.Drawing.Size(153, 6)
        '
        'MenuSetting
        '
        Me.MenuSetting.AutoToolTip = True
        Me.MenuSetting.Name = "MenuSetting"
        Me.MenuSetting.Size = New System.Drawing.Size(156, 24)
        Me.MenuSetting.Text = "設定"
        Me.MenuSetting.ToolTipText = "設定"
        '
        'Separator2
        '
        Me.Separator2.Name = "Separator2"
        Me.Separator2.Size = New System.Drawing.Size(153, 6)
        '
        'MenuExit
        '
        Me.MenuExit.AutoToolTip = True
        Me.MenuExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.MenuExit.Name = "MenuExit"
        Me.MenuExit.Size = New System.Drawing.Size(156, 24)
        Me.MenuExit.Text = "終了"
        '
        'Timer1
        '
        Me.Timer1.Interval = 150
        '
        'AgentFloatingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(380, 180)
        Me.Controls.Add(Me.AxAgent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AgentFloatingForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "OfficeAgent"
        ' 【重要】TopMost=Trueは、ShowWithoutActivation=Trueのこのフォームに設定したままにすると
        ' Wordのキーボードフォーカス管理を壊すことが実機検証で判明したため外した。
        ' このフォームはAxAgentをホストするためだけの存在で、ユーザーに表示することは無い
        ' （常にHide()されている）ため、TopMostである必要も元々無い
        CType(Me.AxAgent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AgentMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AxAgent As AxAgentObjects.AxAgent
    Friend WithEvents AgentMenu As ContextMenuStrip
    Friend WithEvents MenuExit As ToolStripMenuItem
    Friend WithEvents Animation As ToolStripComboBox
    Friend WithEvents SearchEngine As ToolStripComboBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Separator2 As ToolStripSeparator
    Friend WithEvents MenuSetting As ToolStripMenuItem
    Friend WithEvents Separator1 As ToolStripSeparator
    Friend WithEvents SeparatorSelection As ToolStripSeparator
    Friend WithEvents MenuSelectionRoot As ToolStripMenuItem
    Friend WithEvents MenuSelectionSummarize As ToolStripMenuItem
    Friend WithEvents MenuSelectionTranslate As ToolStripMenuItem
    Friend WithEvents MenuSelectionExplain As ToolStripMenuItem
    Friend WithEvents MenuSelectionProofread As ToolStripMenuItem
End Class
