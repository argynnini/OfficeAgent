<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingWindow
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingWindow))
        Me.CheckBoxSound = New System.Windows.Forms.CheckBox()
        Me.ComboBoxSearch = New System.Windows.Forms.ComboBox()
        Me.LabelSearchMethod = New System.Windows.Forms.Label()
        Me.LabelAPI = New System.Windows.Forms.Label()
        Me.TextBoxAPI = New System.Windows.Forms.TextBox()
        Me.LinkAPI = New System.Windows.Forms.LinkLabel()
        Me.TextBoxRule = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.LinkLabelGitHub = New System.Windows.Forms.LinkLabel()
        Me.ToolTipset = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'CheckBoxSound
        '
        Me.CheckBoxSound.AutoSize = True
        Me.CheckBoxSound.Checked = True
        Me.CheckBoxSound.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxSound.Location = New System.Drawing.Point(10, 10)
        Me.CheckBoxSound.Name = "CheckBoxSound"
        Me.CheckBoxSound.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBoxSound.Size = New System.Drawing.Size(62, 19)
        Me.CheckBoxSound.TabIndex = 0
        Me.CheckBoxSound.Text = "サウンド"
        Me.CheckBoxSound.UseVisualStyleBackColor = True
        '
        'ComboBoxSearch
        '
        Me.ComboBoxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSearch.FormattingEnabled = True
        Me.ComboBoxSearch.Items.AddRange(New Object() {"Chat GPT", "ウェブ検索"})
        Me.ComboBoxSearch.Location = New System.Drawing.Point(10, 55)
        Me.ComboBoxSearch.Name = "ComboBoxSearch"
        Me.ComboBoxSearch.Size = New System.Drawing.Size(200, 23)
        Me.ComboBoxSearch.TabIndex = 1
        '
        'LabelSearchMethod
        '
        Me.LabelSearchMethod.AutoSize = True
        Me.LabelSearchMethod.Location = New System.Drawing.Point(10, 35)
        Me.LabelSearchMethod.Name = "LabelSearchMethod"
        Me.LabelSearchMethod.Size = New System.Drawing.Size(55, 15)
        Me.LabelSearchMethod.TabIndex = 3
        Me.LabelSearchMethod.Text = "検索方法"
        '
        'LabelAPI
        '
        Me.LabelAPI.AutoSize = True
        Me.LabelAPI.Location = New System.Drawing.Point(10, 85)
        Me.LabelAPI.Name = "LabelAPI"
        Me.LabelAPI.Size = New System.Drawing.Size(88, 15)
        Me.LabelAPI.TabIndex = 3
        Me.LabelAPI.Text = "OpenAI API キー"
        '
        'TextBoxAPI
        '
        Me.TextBoxAPI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxAPI.Location = New System.Drawing.Point(10, 105)
        Me.TextBoxAPI.MaxLength = 100
        Me.TextBoxAPI.Name = "TextBoxAPI"
        Me.TextBoxAPI.Size = New System.Drawing.Size(200, 23)
        Me.TextBoxAPI.TabIndex = 4
        '
        'LinkAPI
        '
        Me.LinkAPI.AutoSize = True
        Me.LinkAPI.Font = New System.Drawing.Font("Yu Gothic UI", 8.0!)
        Me.LinkAPI.Location = New System.Drawing.Point(100, 85)
        Me.LinkAPI.Name = "LinkAPI"
        Me.LinkAPI.Size = New System.Drawing.Size(111, 13)
        Me.LinkAPI.TabIndex = 5
        Me.LinkAPI.TabStop = True
        Me.LinkAPI.Text = "OpenAI API キーの取得"
        '
        'TextBoxRule
        '
        Me.TextBoxRule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxRule.Location = New System.Drawing.Point(10, 155)
        Me.TextBoxRule.MaxLength = 10000
        Me.TextBoxRule.Multiline = True
        Me.TextBoxRule.Name = "TextBoxRule"
        Me.TextBoxRule.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxRule.Size = New System.Drawing.Size(200, 100)
        Me.TextBoxRule.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "カイル君の性格"
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(13, 261)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(190, 30)
        Me.ButtonClose.TabIndex = 2
        Me.ButtonClose.Text = "閉じる"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'LinkLabelGitHub
        '
        Me.LinkLabelGitHub.AutoSize = True
        Me.LinkLabelGitHub.Font = New System.Drawing.Font("Yu Gothic UI", 7.0!)
        Me.LinkLabelGitHub.Location = New System.Drawing.Point(100, 10)
        Me.LinkLabelGitHub.Name = "LinkLabelGitHub"
        Me.LinkLabelGitHub.Size = New System.Drawing.Size(60, 12)
        Me.LinkLabelGitHub.TabIndex = 7
        Me.LinkLabelGitHub.TabStop = True
        Me.LinkLabelGitHub.Text = "バージョン情報"
        '
        'SettingWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(219, 301)
        Me.Controls.Add(Me.LinkLabelGitHub)
        Me.Controls.Add(Me.TextBoxRule)
        Me.Controls.Add(Me.LinkAPI)
        Me.Controls.Add(Me.TextBoxAPI)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelAPI)
        Me.Controls.Add(Me.LabelSearchMethod)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ComboBoxSearch)
        Me.Controls.Add(Me.CheckBoxSound)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SettingWindow"
        Me.Text = "設定"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckBoxSound As CheckBox
    Friend WithEvents ComboBoxSearch As ComboBox
    Friend WithEvents LabelSearchMethod As Label
    Friend WithEvents LabelAPI As Label
    Friend WithEvents TextBoxAPI As TextBox
    Friend WithEvents LinkAPI As LinkLabel
    Friend WithEvents TextBoxRule As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonClose As Button
    Friend WithEvents LinkLabelGitHub As LinkLabel
    Friend WithEvents ToolTipset As ToolTip
End Class
