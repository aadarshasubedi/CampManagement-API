<CompilerServices.DesignerGenerated()>
Partial Class CampManagementFirstMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <DebuggerNonUserCode()>
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.HelpButton = New System.Windows.Forms.Button()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.ContinueGameButton = New System.Windows.Forms.Button()
        Me.NewGameButton = New System.Windows.Forms.Button()
        Me.CopyrightLabel = New System.Windows.Forms.Label()
        Me.GameNameLabel = New System.Windows.Forms.Label()
        Me.GameDescriptionLabel = New System.Windows.Forms.Label()
        Me.GameVersionLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.HelpButton)
        Me.Panel1.Controls.Add(Me.QuitButton)
        Me.Panel1.Controls.Add(Me.ContinueGameButton)
        Me.Panel1.Controls.Add(Me.NewGameButton)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(181, 215)
        Me.Panel1.TabIndex = 0
        '
        'HelpButton
        '
        Me.HelpButton.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.HelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HelpButton.Location = New System.Drawing.Point(32, 87)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(113, 24)
        Me.HelpButton.TabIndex = 4
        Me.HelpButton.Text = "Help"
        Me.HelpButton.UseVisualStyleBackColor = False
        '
        'QuitButton
        '
        Me.QuitButton.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.QuitButton.Location = New System.Drawing.Point(32, 169)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(113, 29)
        Me.QuitButton.TabIndex = 3
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = False
        '
        'ContinueGameButton
        '
        Me.ContinueGameButton.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ContinueGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ContinueGameButton.Location = New System.Drawing.Point(32, 11)
        Me.ContinueGameButton.Name = "ContinueGameButton"
        Me.ContinueGameButton.Size = New System.Drawing.Size(113, 40)
        Me.ContinueGameButton.TabIndex = 2
        Me.ContinueGameButton.Text = "Continue"
        Me.ContinueGameButton.UseVisualStyleBackColor = False
        '
        'NewGameButton
        '
        Me.NewGameButton.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.NewGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewGameButton.Location = New System.Drawing.Point(32, 57)
        Me.NewGameButton.Name = "NewGameButton"
        Me.NewGameButton.Size = New System.Drawing.Size(113, 24)
        Me.NewGameButton.TabIndex = 1
        Me.NewGameButton.Text = "New Game"
        Me.NewGameButton.UseVisualStyleBackColor = False
        '
        'CopyrightLabel
        '
        Me.CopyrightLabel.AutoSize = True
        Me.CopyrightLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CopyrightLabel.Location = New System.Drawing.Point(9, 237)
        Me.CopyrightLabel.Name = "CopyrightLabel"
        Me.CopyrightLabel.Size = New System.Drawing.Size(184, 13)
        Me.CopyrightLabel.TabIndex = 12
        Me.CopyrightLabel.Text = "Miller Berto Simberg Anaia © 2016"
        '
        'GameNameLabel
        '
        Me.GameNameLabel.AutoSize = True
        Me.GameNameLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GameNameLabel.Location = New System.Drawing.Point(245, 12)
        Me.GameNameLabel.Name = "GameNameLabel"
        Me.GameNameLabel.Size = New System.Drawing.Size(178, 17)
        Me.GameNameLabel.TabIndex = 13
        Me.GameNameLabel.Text = "CampManagement Simulator"
        '
        'GameDescriptionLabel
        '
        Me.GameDescriptionLabel.AutoSize = True
        Me.GameDescriptionLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameDescriptionLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GameDescriptionLabel.Location = New System.Drawing.Point(263, 32)
        Me.GameDescriptionLabel.Name = "GameDescriptionLabel"
        Me.GameDescriptionLabel.Size = New System.Drawing.Size(132, 39)
        Me.GameDescriptionLabel.TabIndex = 14
        Me.GameDescriptionLabel.Text = "A ""Game"" by Miller Berto" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Made with Visual Basic" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GameVersionLabel
        '
        Me.GameVersionLabel.AutoSize = True
        Me.GameVersionLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameVersionLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GameVersionLabel.Location = New System.Drawing.Point(422, 237)
        Me.GameVersionLabel.Name = "GameVersionLabel"
        Me.GameVersionLabel.Size = New System.Drawing.Size(22, 13)
        Me.GameVersionLabel.TabIndex = 15
        Me.GameVersionLabel.Text = "1.1"
        '
        'CampManagementFirstMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(456, 259)
        Me.Controls.Add(Me.GameVersionLabel)
        Me.Controls.Add(Me.GameDescriptionLabel)
        Me.Controls.Add(Me.GameNameLabel)
        Me.Controls.Add(Me.CopyrightLabel)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CampManagementFirstMenu"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CampManagementMainMenu"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ContinueGameButton As Button
    Friend WithEvents NewGameButton As Button
    Friend WithEvents CopyrightLabel As Label
    Friend WithEvents GameNameLabel As Label
    Friend WithEvents GameDescriptionLabel As Label
    Friend WithEvents QuitButton As Button
    Friend WithEvents GameVersionLabel As Label
    Friend WithEvents HelpButton As Button
End Class
