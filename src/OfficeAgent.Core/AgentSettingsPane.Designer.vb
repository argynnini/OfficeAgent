<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AgentSettingsPane
    Inherits System.Windows.Forms.UserControl

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
        Me.SectionAgent = New System.Windows.Forms.Label()
        Me.CheckBoxShowOnStartup = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSound = New System.Windows.Forms.CheckBox()
        Me.LabelCharacter = New System.Windows.Forms.Label()
        Me.ComboBoxCharacter = New System.Windows.Forms.ComboBox()
        Me.CheckBoxHideDuringSlideShow = New System.Windows.Forms.CheckBox()
        Me.SeparatorAgent = New System.Windows.Forms.Panel()
        Me.SectionSearch = New System.Windows.Forms.Label()
        Me.LabelSearchMethod = New System.Windows.Forms.Label()
        Me.ComboBoxSearch = New System.Windows.Forms.ComboBox()
        Me.LabelAPI = New System.Windows.Forms.Label()
        Me.LinkAPI = New System.Windows.Forms.LinkLabel()
        Me.TextBoxAPI = New System.Windows.Forms.TextBox()
        Me.LabelModel = New System.Windows.Forms.Label()
        Me.TextBoxModel = New System.Windows.Forms.TextBox()
        Me.CheckBoxIncludeSelection = New System.Windows.Forms.CheckBox()
        Me.SectionPersonality = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxRule = New System.Windows.Forms.TextBox()
        Me.LabelDefaultSearchEngine = New System.Windows.Forms.Label()
        Me.ComboBoxDefaultSearchEngine = New System.Windows.Forms.ComboBox()
        Me.LabelSearchEngines = New System.Windows.Forms.Label()
        Me.DataGridViewSearchEngines = New System.Windows.Forms.DataGridView()
        Me.ColName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPrefix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColQuery = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColSuffix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SectionAnimation = New System.Windows.Forms.Label()
        Me.DataGridViewAnimationEvents = New System.Windows.Forms.DataGridView()
        Me.ColAnimEnabled = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ColAnimName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColAnimAnimation = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ColAnimPreview = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.LabelVersion = New System.Windows.Forms.LinkLabel()
        Me.ToolTipset = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DataGridViewSearchEngines, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewAnimationEvents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SectionAgent
        '
        Me.SectionAgent.AutoSize = True
        Me.SectionAgent.Font = New System.Drawing.Font("Yu Gothic UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.SectionAgent.ForeColor = System.Drawing.Color.FromArgb(0, 120, 212)
        Me.SectionAgent.Location = New System.Drawing.Point(16, 14)
        Me.SectionAgent.Name = "SectionAgent"
        Me.SectionAgent.TabIndex = 0
        Me.SectionAgent.Text = "Agentの設定"
        '
        'LabelCharacter
        '
        Me.LabelCharacter.AutoSize = True
        Me.LabelCharacter.ForeColor = System.Drawing.Color.FromArgb(96, 94, 92)
        Me.LabelCharacter.Location = New System.Drawing.Point(16, 40)
        Me.LabelCharacter.Name = "LabelCharacter"
        Me.LabelCharacter.TabIndex = 16
        Me.LabelCharacter.Text = "キャラクター"
        '
        'ComboBoxCharacter
        '
        Me.ComboBoxCharacter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right, System.Windows.Forms.AnchorStyles)
        Me.ComboBoxCharacter.BackColor = System.Drawing.Color.White
        Me.ComboBoxCharacter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxCharacter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCharacter.FormattingEnabled = True
        Me.ComboBoxCharacter.Items.AddRange(New Object() {"カイル", "フィンフィン"})
        Me.ComboBoxCharacter.Location = New System.Drawing.Point(16, 60)
        Me.ComboBoxCharacter.Name = "ComboBoxCharacter"
        Me.ComboBoxCharacter.Size = New System.Drawing.Size(222, 23)
        Me.ComboBoxCharacter.TabIndex = 17
        '
        'CheckBoxShowOnStartup
        '
        Me.CheckBoxShowOnStartup.AutoSize = True
        Me.CheckBoxShowOnStartup.ForeColor = System.Drawing.Color.FromArgb(50, 49, 48)
        Me.CheckBoxShowOnStartup.Location = New System.Drawing.Point(16, 40)
        Me.CheckBoxShowOnStartup.Name = "CheckBoxShowOnStartup"
        Me.CheckBoxShowOnStartup.TabIndex = 1
        Me.CheckBoxShowOnStartup.Text = "起動時に表示"
        Me.CheckBoxShowOnStartup.UseVisualStyleBackColor = True
        '
        'CheckBoxSound
        '
        Me.CheckBoxSound.AutoSize = True
        Me.CheckBoxSound.ForeColor = System.Drawing.Color.FromArgb(50, 49, 48)
        Me.CheckBoxSound.Location = New System.Drawing.Point(16, 64)
        Me.CheckBoxSound.Name = "CheckBoxSound"
        Me.CheckBoxSound.TabIndex = 2
        Me.CheckBoxSound.Text = "サウンド"
        Me.CheckBoxSound.UseVisualStyleBackColor = True
        '
        'CheckBoxHideDuringSlideShow
        '
        Me.CheckBoxHideDuringSlideShow.AutoSize = True
        Me.CheckBoxHideDuringSlideShow.ForeColor = System.Drawing.Color.FromArgb(50, 49, 48)
        Me.CheckBoxHideDuringSlideShow.Location = New System.Drawing.Point(16, 88)
        Me.CheckBoxHideDuringSlideShow.Name = "CheckBoxHideDuringSlideShow"
        Me.CheckBoxHideDuringSlideShow.TabIndex = 15
        Me.CheckBoxHideDuringSlideShow.Text = "発表中は非表示にする"
        Me.CheckBoxHideDuringSlideShow.UseVisualStyleBackColor = True
        Me.CheckBoxHideDuringSlideShow.Visible = False
        '
        'SectionAnimation
        '
        Me.SectionAnimation.AutoSize = True
        Me.SectionAnimation.ForeColor = System.Drawing.Color.FromArgb(96, 94, 92)
        Me.SectionAnimation.Location = New System.Drawing.Point(16, 88)
        Me.SectionAnimation.Name = "SectionAnimation"
        Me.SectionAnimation.TabIndex = 3
        Me.SectionAnimation.Text = "アニメーション設定"
        '
        'DataGridViewAnimationEvents
        '
        Me.DataGridViewAnimationEvents.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right, System.Windows.Forms.AnchorStyles)
        Me.DataGridViewAnimationEvents.AllowUserToAddRows = False
        Me.DataGridViewAnimationEvents.AllowUserToDeleteRows = False
        Me.DataGridViewAnimationEvents.AllowUserToResizeRows = False
        Me.DataGridViewAnimationEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewAnimationEvents.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewAnimationEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGridViewAnimationEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAnimationEvents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColAnimEnabled, Me.ColAnimName, Me.ColAnimAnimation, Me.ColAnimPreview})
        Me.DataGridViewAnimationEvents.Location = New System.Drawing.Point(16, 106)
        Me.DataGridViewAnimationEvents.Name = "DataGridViewAnimationEvents"
        Me.DataGridViewAnimationEvents.RowHeadersVisible = False
        Me.DataGridViewAnimationEvents.RowTemplate.Height = 23
        Me.DataGridViewAnimationEvents.Size = New System.Drawing.Size(222, 140)
        Me.DataGridViewAnimationEvents.TabIndex = 4
        '
        'ColAnimEnabled
        '
        Me.ColAnimEnabled.HeaderText = "有効"
        Me.ColAnimEnabled.Name = "ColAnimEnabled"
        '
        'ColAnimName
        '
        Me.ColAnimName.HeaderText = "項目名"
        Me.ColAnimName.Name = "ColAnimName"
        Me.ColAnimName.ReadOnly = True
        '
        'ColAnimAnimation
        '
        Me.ColAnimAnimation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColAnimAnimation.HeaderText = "アニメーション"
        Me.ColAnimAnimation.Name = "ColAnimAnimation"
        '
        'ColAnimPreview
        '
        Me.ColAnimPreview.HeaderText = ""
        Me.ColAnimPreview.Name = "ColAnimPreview"
        Me.ColAnimPreview.Text = "▶"
        Me.ColAnimPreview.UseColumnTextForButtonValue = True
        '
        'SeparatorAgent
        '
        Me.SeparatorAgent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right, System.Windows.Forms.AnchorStyles)
        Me.SeparatorAgent.BackColor = System.Drawing.Color.FromArgb(225, 223, 221)
        Me.SeparatorAgent.Location = New System.Drawing.Point(16, 260)
        Me.SeparatorAgent.Name = "SeparatorAgent"
        Me.SeparatorAgent.Size = New System.Drawing.Size(222, 1)
        Me.SeparatorAgent.TabIndex = 5
        '
        'SectionSearch
        '
        Me.SectionSearch.AutoSize = True
        Me.SectionSearch.Font = New System.Drawing.Font("Yu Gothic UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.SectionSearch.ForeColor = System.Drawing.Color.FromArgb(0, 120, 212)
        Me.SectionSearch.Location = New System.Drawing.Point(16, 270)
        Me.SectionSearch.Name = "SectionSearch"
        Me.SectionSearch.TabIndex = 6
        Me.SectionSearch.Text = "検索設定"
        '
        'LabelSearchMethod
        '
        Me.LabelSearchMethod.AutoSize = True
        Me.LabelSearchMethod.ForeColor = System.Drawing.Color.FromArgb(96, 94, 92)
        Me.LabelSearchMethod.Location = New System.Drawing.Point(16, 294)
        Me.LabelSearchMethod.Name = "LabelSearchMethod"
        Me.LabelSearchMethod.TabIndex = 7
        Me.LabelSearchMethod.Text = "検索方法"
        '
        'ComboBoxSearch
        '
        Me.ComboBoxSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right, System.Windows.Forms.AnchorStyles)
        Me.ComboBoxSearch.BackColor = System.Drawing.Color.White
        Me.ComboBoxSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSearch.FormattingEnabled = True
        Me.ComboBoxSearch.Items.AddRange(New Object() {"ウェブ検索", "Groq", "OpenAI"})
        Me.ComboBoxSearch.Location = New System.Drawing.Point(16, 320)
        Me.ComboBoxSearch.Name = "ComboBoxSearch"
        Me.ComboBoxSearch.Size = New System.Drawing.Size(222, 23)
        Me.ComboBoxSearch.TabIndex = 8
        '
        'LabelAPI
        '
        Me.LabelAPI.AutoSize = True
        Me.LabelAPI.ForeColor = System.Drawing.Color.FromArgb(96, 94, 92)
        Me.LabelAPI.Location = New System.Drawing.Point(16, 190)
        Me.LabelAPI.Name = "LabelAPI"
        Me.LabelAPI.TabIndex = 7
        Me.LabelAPI.Text = "OpenAI API キー"
        '
        'LinkAPI
        '
        Me.LinkAPI.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
        Me.LinkAPI.AutoSize = True
        Me.LinkAPI.Font = New System.Drawing.Font("Yu Gothic UI", 7.5!)
        Me.LinkAPI.LinkColor = System.Drawing.Color.FromArgb(0, 120, 212)
        Me.LinkAPI.Location = New System.Drawing.Point(163, 191)
        Me.LinkAPI.Name = "LinkAPI"
        Me.LinkAPI.TabIndex = 8
        Me.LinkAPI.TabStop = True
        Me.LinkAPI.Text = "APIキーの取得"
        '
        'TextBoxAPI
        '
        Me.TextBoxAPI.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right, System.Windows.Forms.AnchorStyles)
        Me.TextBoxAPI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxAPI.Location = New System.Drawing.Point(16, 209)
        Me.TextBoxAPI.MaxLength = 200
        Me.TextBoxAPI.Name = "TextBoxAPI"
        Me.TextBoxAPI.Size = New System.Drawing.Size(222, 23)
        Me.TextBoxAPI.TabIndex = 9
        Me.TextBoxAPI.UseSystemPasswordChar = True
        '
        'LabelModel
        '
        Me.LabelModel.AutoSize = True
        Me.LabelModel.ForeColor = System.Drawing.Color.FromArgb(96, 94, 92)
        Me.LabelModel.Location = New System.Drawing.Point(16, 246)
        Me.LabelModel.Name = "LabelModel"
        Me.LabelModel.TabIndex = 10
        Me.LabelModel.Text = "モデル名"
        '
        'TextBoxModel
        '
        Me.TextBoxModel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right, System.Windows.Forms.AnchorStyles)
        Me.TextBoxModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxModel.Location = New System.Drawing.Point(16, 264)
        Me.TextBoxModel.MaxLength = 200
        Me.TextBoxModel.Name = "TextBoxModel"
        Me.TextBoxModel.Size = New System.Drawing.Size(222, 23)
        Me.TextBoxModel.TabIndex = 11
        '
        'CheckBoxIncludeSelection
        '
        Me.CheckBoxIncludeSelection.AutoSize = True
        Me.CheckBoxIncludeSelection.ForeColor = System.Drawing.Color.FromArgb(50, 49, 48)
        Me.CheckBoxIncludeSelection.Location = New System.Drawing.Point(16, 297)
        Me.CheckBoxIncludeSelection.Name = "CheckBoxIncludeSelection"
        Me.CheckBoxIncludeSelection.TabIndex = 17
        Me.CheckBoxIncludeSelection.Text = "検索に選択範囲を含める"
        Me.CheckBoxIncludeSelection.UseVisualStyleBackColor = True
        '
        'SectionPersonality
        '
        Me.SectionPersonality.AutoSize = True
        Me.SectionPersonality.Font = New System.Drawing.Font("Yu Gothic UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.SectionPersonality.ForeColor = System.Drawing.Color.FromArgb(0, 120, 212)
        Me.SectionPersonality.Location = New System.Drawing.Point(16, 307)
        Me.SectionPersonality.Name = "SectionPersonality"
        Me.SectionPersonality.TabIndex = 12
        Me.SectionPersonality.Text = "OfficeAgentの性格"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(96, 94, 92)
        Me.Label1.Location = New System.Drawing.Point(16, 333)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "指示（プロンプト）を自由に記述できます"
        '
        'TextBoxRule
        '
        Me.TextBoxRule.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right, System.Windows.Forms.AnchorStyles)
        Me.TextBoxRule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxRule.Location = New System.Drawing.Point(16, 353)
        Me.TextBoxRule.MaxLength = 10000
        Me.TextBoxRule.Multiline = True
        Me.TextBoxRule.Name = "TextBoxRule"
        Me.TextBoxRule.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxRule.Size = New System.Drawing.Size(222, 80)
        Me.TextBoxRule.TabIndex = 14
        '
        'LabelDefaultSearchEngine
        '
        Me.LabelDefaultSearchEngine.AutoSize = True
        Me.LabelDefaultSearchEngine.ForeColor = System.Drawing.Color.FromArgb(96, 94, 92)
        Me.LabelDefaultSearchEngine.Location = New System.Drawing.Point(16, 190)
        Me.LabelDefaultSearchEngine.Name = "LabelDefaultSearchEngine"
        Me.LabelDefaultSearchEngine.TabIndex = 15
        Me.LabelDefaultSearchEngine.Text = "デフォルト検索サイト"
        Me.LabelDefaultSearchEngine.Visible = False
        '
        'ComboBoxDefaultSearchEngine
        '
        Me.ComboBoxDefaultSearchEngine.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right, System.Windows.Forms.AnchorStyles)
        Me.ComboBoxDefaultSearchEngine.BackColor = System.Drawing.Color.White
        Me.ComboBoxDefaultSearchEngine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxDefaultSearchEngine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDefaultSearchEngine.FormattingEnabled = True
        Me.ComboBoxDefaultSearchEngine.Location = New System.Drawing.Point(16, 208)
        Me.ComboBoxDefaultSearchEngine.Name = "ComboBoxDefaultSearchEngine"
        Me.ComboBoxDefaultSearchEngine.Size = New System.Drawing.Size(222, 23)
        Me.ComboBoxDefaultSearchEngine.TabIndex = 16
        Me.ComboBoxDefaultSearchEngine.Visible = False
        '
        'LabelSearchEngines
        '
        Me.LabelSearchEngines.AutoSize = True
        Me.LabelSearchEngines.ForeColor = System.Drawing.Color.FromArgb(96, 94, 92)
        Me.LabelSearchEngines.Location = New System.Drawing.Point(16, 245)
        Me.LabelSearchEngines.Name = "LabelSearchEngines"
        Me.LabelSearchEngines.TabIndex = 17
        Me.LabelSearchEngines.Text = "検索サイト一覧"
        Me.LabelSearchEngines.Visible = False
        '
        'DataGridViewSearchEngines
        '
        Me.DataGridViewSearchEngines.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right, System.Windows.Forms.AnchorStyles)
        Me.DataGridViewSearchEngines.AllowUserToResizeRows = False
        Me.DataGridViewSearchEngines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewSearchEngines.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewSearchEngines.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGridViewSearchEngines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSearchEngines.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColName, Me.ColPrefix, Me.ColQuery, Me.ColSuffix})
        Me.DataGridViewSearchEngines.Location = New System.Drawing.Point(16, 263)
        Me.DataGridViewSearchEngines.Name = "DataGridViewSearchEngines"
        Me.DataGridViewSearchEngines.RowHeadersVisible = False
        Me.DataGridViewSearchEngines.RowTemplate.Height = 23
        Me.DataGridViewSearchEngines.Size = New System.Drawing.Size(222, 180)
        Me.DataGridViewSearchEngines.TabIndex = 18
        Me.DataGridViewSearchEngines.Visible = False
        '
        'ColName
        '
        Me.ColName.HeaderText = "名前"
        Me.ColName.Name = "ColName"
        Me.ColName.Width = 70
        '
        'ColPrefix
        '
        Me.ColPrefix.HeaderText = "URL（検索内容より前）"
        Me.ColPrefix.Name = "ColPrefix"
        Me.ColPrefix.Width = 150
        '
        'ColQuery
        '
        Me.ColQuery.HeaderText = "検索内容"
        Me.ColQuery.Name = "ColQuery"
        Me.ColQuery.ReadOnly = True
        Me.ColQuery.Width = 70
        '
        'ColSuffix
        '
        Me.ColSuffix.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColSuffix.HeaderText = "URL（検索内容より後）"
        Me.ColSuffix.Name = "ColSuffix"
        Me.ColSuffix.Width = 150
        '
        'LabelVersion
        '
        Me.LabelVersion.AutoSize = True
        Me.LabelVersion.Font = New System.Drawing.Font("Yu Gothic UI", 7.5!)
        Me.LabelVersion.LinkColor = System.Drawing.Color.FromArgb(96, 94, 92)
        Me.LabelVersion.Location = New System.Drawing.Point(16, 468)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.TabIndex = 19
        Me.LabelVersion.TabStop = True
        Me.LabelVersion.Text = "バージョン情報"
        '
        'AgentSettingsPane
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.SectionAgent)
        Me.Controls.Add(Me.CheckBoxShowOnStartup)
        Me.Controls.Add(Me.CheckBoxSound)
        Me.Controls.Add(Me.LabelCharacter)
        Me.Controls.Add(Me.ComboBoxCharacter)
        Me.Controls.Add(Me.CheckBoxHideDuringSlideShow)
        Me.Controls.Add(Me.SeparatorAgent)
        Me.Controls.Add(Me.SectionSearch)
        Me.Controls.Add(Me.LabelSearchMethod)
        Me.Controls.Add(Me.ComboBoxSearch)
        Me.Controls.Add(Me.LabelAPI)
        Me.Controls.Add(Me.LinkAPI)
        Me.Controls.Add(Me.TextBoxAPI)
        Me.Controls.Add(Me.LabelModel)
        Me.Controls.Add(Me.TextBoxModel)
        Me.Controls.Add(Me.CheckBoxIncludeSelection)
        Me.Controls.Add(Me.SectionPersonality)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxRule)
        Me.Controls.Add(Me.LabelDefaultSearchEngine)
        Me.Controls.Add(Me.ComboBoxDefaultSearchEngine)
        Me.Controls.Add(Me.LabelSearchEngines)
        Me.Controls.Add(Me.DataGridViewSearchEngines)
        Me.Controls.Add(Me.SectionAnimation)
        Me.Controls.Add(Me.DataGridViewAnimationEvents)
        Me.Controls.Add(Me.LabelVersion)
        Me.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Name = "AgentSettingsPane"
        Me.Size = New System.Drawing.Size(254, 574)
        CType(Me.DataGridViewSearchEngines, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewAnimationEvents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents SectionAgent As Label
    Friend WithEvents CheckBoxShowOnStartup As CheckBox
    Friend WithEvents CheckBoxSound As CheckBox
    Friend WithEvents LabelCharacter As Label
    Friend WithEvents ComboBoxCharacter As ComboBox
    Friend WithEvents CheckBoxHideDuringSlideShow As CheckBox
    Friend WithEvents SeparatorAgent As Panel
    Friend WithEvents SectionSearch As Label
    Friend WithEvents LabelSearchMethod As Label
    Friend WithEvents ComboBoxSearch As ComboBox
    Friend WithEvents LabelAPI As Label
    Friend WithEvents LinkAPI As LinkLabel
    Friend WithEvents TextBoxAPI As TextBox
    Friend WithEvents LabelModel As Label
    Friend WithEvents TextBoxModel As TextBox
    Friend WithEvents CheckBoxIncludeSelection As CheckBox
    Friend WithEvents SectionPersonality As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxRule As TextBox
    Friend WithEvents LabelDefaultSearchEngine As Label
    Friend WithEvents ComboBoxDefaultSearchEngine As ComboBox
    Friend WithEvents LabelSearchEngines As Label
    Friend WithEvents DataGridViewSearchEngines As DataGridView
    Friend WithEvents ColName As DataGridViewTextBoxColumn
    Friend WithEvents ColPrefix As DataGridViewTextBoxColumn
    Friend WithEvents ColQuery As DataGridViewTextBoxColumn
    Friend WithEvents ColSuffix As DataGridViewTextBoxColumn
    Friend WithEvents SectionAnimation As Label
    Friend WithEvents DataGridViewAnimationEvents As DataGridView
    Friend WithEvents ColAnimEnabled As DataGridViewCheckBoxColumn
    Friend WithEvents ColAnimName As DataGridViewTextBoxColumn
    Friend WithEvents ColAnimAnimation As DataGridViewComboBoxColumn
    Friend WithEvents ColAnimPreview As DataGridViewButtonColumn
    Friend WithEvents LabelVersion As LinkLabel
    Friend WithEvents ToolTipset As ToolTip

End Class
