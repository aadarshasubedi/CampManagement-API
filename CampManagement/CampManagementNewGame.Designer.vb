<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CampManagementNewGame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CampTextBox = New System.Windows.Forms.TextBox()
        Me.PlayerNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EasyDifficultyCheck = New System.Windows.Forms.RadioButton()
        Me.HardDifficultyCheck = New System.Windows.Forms.RadioButton()
        Me.ChooseaDifficulty = New System.Windows.Forms.Label()
        Me.ModuleSelectionDropBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CopyrightLabelNewGame = New System.Windows.Forms.Label()
        Me.InstalledModules = New System.Windows.Forms.Label()
        Me.DLCQuantityLabel = New System.Windows.Forms.Label()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'StartButton
        '
        Me.StartButton.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartButton.Location = New System.Drawing.Point(15, 167)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(75, 25)
        Me.StartButton.TabIndex = 0
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name your camp:"
        '
        'CampTextBox
        '
        Me.CampTextBox.Location = New System.Drawing.Point(15, 25)
        Me.CampTextBox.Name = "CampTextBox"
        Me.CampTextBox.Size = New System.Drawing.Size(266, 22)
        Me.CampTextBox.TabIndex = 2
        '
        'PlayerNameTextBox
        '
        Me.PlayerNameTextBox.Location = New System.Drawing.Point(15, 73)
        Me.PlayerNameTextBox.Name = "PlayerNameTextBox"
        Me.PlayerNameTextBox.Size = New System.Drawing.Size(266, 22)
        Me.PlayerNameTextBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(12, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name yourself:"
        '
        'EasyDifficultyCheck
        '
        Me.EasyDifficultyCheck.AutoSize = True
        Me.EasyDifficultyCheck.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.EasyDifficultyCheck.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EasyDifficultyCheck.Location = New System.Drawing.Point(15, 118)
        Me.EasyDifficultyCheck.Name = "EasyDifficultyCheck"
        Me.EasyDifficultyCheck.Size = New System.Drawing.Size(156, 17)
        Me.EasyDifficultyCheck.TabIndex = 5
        Me.EasyDifficultyCheck.TabStop = True
        Me.EasyDifficultyCheck.Text = "Initiate (Normal Difficulty)"
        Me.EasyDifficultyCheck.UseVisualStyleBackColor = False
        '
        'HardDifficultyCheck
        '
        Me.HardDifficultyCheck.AutoSize = True
        Me.HardDifficultyCheck.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.HardDifficultyCheck.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.HardDifficultyCheck.Location = New System.Drawing.Point(15, 141)
        Me.HardDifficultyCheck.Name = "HardDifficultyCheck"
        Me.HardDifficultyCheck.Size = New System.Drawing.Size(157, 17)
        Me.HardDifficultyCheck.TabIndex = 6
        Me.HardDifficultyCheck.TabStop = True
        Me.HardDifficultyCheck.Text = "Veteran (Harder Difficulty)"
        Me.HardDifficultyCheck.UseVisualStyleBackColor = False
        '
        'ChooseaDifficulty
        '
        Me.ChooseaDifficulty.AutoSize = True
        Me.ChooseaDifficulty.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ChooseaDifficulty.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ChooseaDifficulty.Location = New System.Drawing.Point(12, 102)
        Me.ChooseaDifficulty.Name = "ChooseaDifficulty"
        Me.ChooseaDifficulty.Size = New System.Drawing.Size(106, 13)
        Me.ChooseaDifficulty.TabIndex = 7
        Me.ChooseaDifficulty.Text = "Choose a difficulty:"
        '
        'ModuleSelectionDropBox
        '
        Me.ModuleSelectionDropBox.FormattingEnabled = True
        Me.ModuleSelectionDropBox.Items.AddRange(New Object() {"CampManagement"})
        Me.ModuleSelectionDropBox.Location = New System.Drawing.Point(287, 25)
        Me.ModuleSelectionDropBox.Name = "ModuleSelectionDropBox"
        Me.ModuleSelectionDropBox.Size = New System.Drawing.Size(132, 21)
        Me.ModuleSelectionDropBox.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(287, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Select Module:"
        '
        'CopyrightLabelNewGame
        '
        Me.CopyrightLabelNewGame.AutoSize = True
        Me.CopyrightLabelNewGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CopyrightLabelNewGame.Location = New System.Drawing.Point(312, 179)
        Me.CopyrightLabelNewGame.Name = "CopyrightLabelNewGame"
        Me.CopyrightLabelNewGame.Size = New System.Drawing.Size(107, 13)
        Me.CopyrightLabelNewGame.TabIndex = 10
        Me.CopyrightLabelNewGame.Text = "Miller Berto © 2016"
        '
        'InstalledModules
        '
        Me.InstalledModules.AutoSize = True
        Me.InstalledModules.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.InstalledModules.Location = New System.Drawing.Point(284, 49)
        Me.InstalledModules.Name = "InstalledModules"
        Me.InstalledModules.Size = New System.Drawing.Size(102, 13)
        Me.InstalledModules.TabIndex = 11
        Me.InstalledModules.Text = "Installed Modules:"
        '
        'DLCQuantityLabel
        '
        Me.DLCQuantityLabel.AutoSize = True
        Me.DLCQuantityLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DLCQuantityLabel.Location = New System.Drawing.Point(406, 49)
        Me.DLCQuantityLabel.Name = "DLCQuantityLabel"
        Me.DLCQuantityLabel.Size = New System.Drawing.Size(13, 13)
        Me.DLCQuantityLabel.TabIndex = 12
        Me.DLCQuantityLabel.Text = "1"
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Location = New System.Drawing.Point(96, 167)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 25)
        Me.BackButton.TabIndex = 13
        Me.BackButton.Text = "Go Back"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'CampManagementNewGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(431, 201)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.DLCQuantityLabel)
        Me.Controls.Add(Me.InstalledModules)
        Me.Controls.Add(Me.CopyrightLabelNewGame)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ModuleSelectionDropBox)
        Me.Controls.Add(Me.ChooseaDifficulty)
        Me.Controls.Add(Me.HardDifficultyCheck)
        Me.Controls.Add(Me.EasyDifficultyCheck)
        Me.Controls.Add(Me.PlayerNameTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CampTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StartButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CampManagementNewGame"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StartButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CampTextBox As TextBox
    Friend WithEvents PlayerNameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents EasyDifficultyCheck As RadioButton
    Friend WithEvents HardDifficultyCheck As RadioButton
    Friend WithEvents ChooseaDifficulty As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ModuleSelectionDropBox As ComboBox
    Friend WithEvents CopyrightLabelNewGame As Label
    Friend WithEvents InstalledModules As Label
    Friend WithEvents DLCQuantityLabel As Label
    Friend WithEvents BackButton As Button
End Class
