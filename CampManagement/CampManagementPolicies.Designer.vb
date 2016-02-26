<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CampManagementPolicies
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MarketPanel = New System.Windows.Forms.Panel()
        Me.MarketLabel = New System.Windows.Forms.Label()
        Me.NewGameButton = New System.Windows.Forms.Button()
        Me.PoliciesPanel = New System.Windows.Forms.Panel()
        Me.RequestPrisonersInfo = New System.Windows.Forms.Label()
        Me.KillPrisonersInfo = New System.Windows.Forms.Label()
        Me.FourMealsADayInfo = New System.Windows.Forms.Label()
        Me.EatAllYouWantInfo = New System.Windows.Forms.Label()
        Me.TenHourInfo = New System.Windows.Forms.Label()
        Me.WorkToDeathInfo = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.TwoMealsPolicyCheckBox = New System.Windows.Forms.CheckBox()
        Me.EatAllYouCanPolicyCheckBox = New System.Windows.Forms.CheckBox()
        Me.EasierWorkPolicyCheckBox = New System.Windows.Forms.CheckBox()
        Me.ExhaustionPolicyCheckBox = New System.Windows.Forms.CheckBox()
        Me.PolicyLabel = New System.Windows.Forms.Label()
        Me.MarketPanel.SuspendLayout()
        Me.PoliciesPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MarketPanel
        '
        Me.MarketPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MarketPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MarketPanel.Controls.Add(Me.MarketLabel)
        Me.MarketPanel.Location = New System.Drawing.Point(12, 12)
        Me.MarketPanel.Name = "MarketPanel"
        Me.MarketPanel.Size = New System.Drawing.Size(212, 252)
        Me.MarketPanel.TabIndex = 1
        '
        'MarketLabel
        '
        Me.MarketLabel.AutoSize = True
        Me.MarketLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MarketLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MarketLabel.Location = New System.Drawing.Point(64, 9)
        Me.MarketLabel.Name = "MarketLabel"
        Me.MarketLabel.Size = New System.Drawing.Size(58, 17)
        Me.MarketLabel.TabIndex = 15
        Me.MarketLabel.Text = "MARKET" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'NewGameButton
        '
        Me.NewGameButton.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.NewGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewGameButton.Location = New System.Drawing.Point(171, 324)
        Me.NewGameButton.Name = "NewGameButton"
        Me.NewGameButton.Size = New System.Drawing.Size(113, 24)
        Me.NewGameButton.TabIndex = 1
        Me.NewGameButton.Text = "Go back."
        Me.NewGameButton.UseVisualStyleBackColor = False
        '
        'PoliciesPanel
        '
        Me.PoliciesPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PoliciesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PoliciesPanel.Controls.Add(Me.RequestPrisonersInfo)
        Me.PoliciesPanel.Controls.Add(Me.KillPrisonersInfo)
        Me.PoliciesPanel.Controls.Add(Me.FourMealsADayInfo)
        Me.PoliciesPanel.Controls.Add(Me.EatAllYouWantInfo)
        Me.PoliciesPanel.Controls.Add(Me.TenHourInfo)
        Me.PoliciesPanel.Controls.Add(Me.WorkToDeathInfo)
        Me.PoliciesPanel.Controls.Add(Me.CheckBox1)
        Me.PoliciesPanel.Controls.Add(Me.CheckBox2)
        Me.PoliciesPanel.Controls.Add(Me.TwoMealsPolicyCheckBox)
        Me.PoliciesPanel.Controls.Add(Me.EatAllYouCanPolicyCheckBox)
        Me.PoliciesPanel.Controls.Add(Me.EasierWorkPolicyCheckBox)
        Me.PoliciesPanel.Controls.Add(Me.ExhaustionPolicyCheckBox)
        Me.PoliciesPanel.Controls.Add(Me.PolicyLabel)
        Me.PoliciesPanel.Location = New System.Drawing.Point(230, 12)
        Me.PoliciesPanel.Name = "PoliciesPanel"
        Me.PoliciesPanel.Size = New System.Drawing.Size(205, 252)
        Me.PoliciesPanel.TabIndex = 2
        '
        'RequestPrisonersInfo
        '
        Me.RequestPrisonersInfo.AutoSize = True
        Me.RequestPrisonersInfo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RequestPrisonersInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RequestPrisonersInfo.Location = New System.Drawing.Point(3, 185)
        Me.RequestPrisonersInfo.Name = "RequestPrisonersInfo"
        Me.RequestPrisonersInfo.Size = New System.Drawing.Size(22, 17)
        Me.RequestPrisonersInfo.TabIndex = 28
        Me.RequestPrisonersInfo.Text = "[?]"
        '
        'KillPrisonersInfo
        '
        Me.KillPrisonersInfo.AutoSize = True
        Me.KillPrisonersInfo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KillPrisonersInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.KillPrisonersInfo.Location = New System.Drawing.Point(3, 162)
        Me.KillPrisonersInfo.Name = "KillPrisonersInfo"
        Me.KillPrisonersInfo.Size = New System.Drawing.Size(22, 17)
        Me.KillPrisonersInfo.TabIndex = 27
        Me.KillPrisonersInfo.Text = "[?]"
        '
        'FourMealsADayInfo
        '
        Me.FourMealsADayInfo.AutoSize = True
        Me.FourMealsADayInfo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FourMealsADayInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FourMealsADayInfo.Location = New System.Drawing.Point(3, 120)
        Me.FourMealsADayInfo.Name = "FourMealsADayInfo"
        Me.FourMealsADayInfo.Size = New System.Drawing.Size(22, 17)
        Me.FourMealsADayInfo.TabIndex = 26
        Me.FourMealsADayInfo.Text = "[?]"
        '
        'EatAllYouWantInfo
        '
        Me.EatAllYouWantInfo.AutoSize = True
        Me.EatAllYouWantInfo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EatAllYouWantInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.EatAllYouWantInfo.Location = New System.Drawing.Point(3, 97)
        Me.EatAllYouWantInfo.Name = "EatAllYouWantInfo"
        Me.EatAllYouWantInfo.Size = New System.Drawing.Size(22, 17)
        Me.EatAllYouWantInfo.TabIndex = 25
        Me.EatAllYouWantInfo.Text = "[?]"
        '
        'TenHourInfo
        '
        Me.TenHourInfo.AutoSize = True
        Me.TenHourInfo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TenHourInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TenHourInfo.Location = New System.Drawing.Point(3, 61)
        Me.TenHourInfo.Name = "TenHourInfo"
        Me.TenHourInfo.Size = New System.Drawing.Size(22, 17)
        Me.TenHourInfo.TabIndex = 24
        Me.TenHourInfo.Text = "[?]"
        '
        'WorkToDeathInfo
        '
        Me.WorkToDeathInfo.AutoSize = True
        Me.WorkToDeathInfo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkToDeathInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.WorkToDeathInfo.Location = New System.Drawing.Point(3, 37)
        Me.WorkToDeathInfo.Name = "WorkToDeathInfo"
        Me.WorkToDeathInfo.Size = New System.Drawing.Size(22, 17)
        Me.WorkToDeathInfo.TabIndex = 23
        Me.WorkToDeathInfo.Text = "[?]"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CheckBox1.Location = New System.Drawing.Point(27, 187)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(159, 17)
        Me.CheckBox1.TabIndex = 22
        Me.CheckBox1.Text = "Request 5 prisoners [misc]"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CheckBox2.Location = New System.Drawing.Point(27, 164)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(156, 17)
        Me.CheckBox2.TabIndex = 21
        Me.CheckBox2.Text = "Execute 5 prisoners [misc]"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'TwoMealsPolicyCheckBox
        '
        Me.TwoMealsPolicyCheckBox.AutoSize = True
        Me.TwoMealsPolicyCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TwoMealsPolicyCheckBox.Location = New System.Drawing.Point(27, 122)
        Me.TwoMealsPolicyCheckBox.Name = "TwoMealsPolicyCheckBox"
        Me.TwoMealsPolicyCheckBox.Size = New System.Drawing.Size(139, 17)
        Me.TwoMealsPolicyCheckBox.TabIndex = 20
        Me.TwoMealsPolicyCheckBox.Text = "4 meals a day [rations]"
        Me.TwoMealsPolicyCheckBox.UseVisualStyleBackColor = True
        '
        'EatAllYouCanPolicyCheckBox
        '
        Me.EatAllYouCanPolicyCheckBox.AutoSize = True
        Me.EatAllYouCanPolicyCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.EatAllYouCanPolicyCheckBox.Location = New System.Drawing.Point(27, 99)
        Me.EatAllYouCanPolicyCheckBox.Name = "EatAllYouCanPolicyCheckBox"
        Me.EatAllYouCanPolicyCheckBox.Size = New System.Drawing.Size(156, 17)
        Me.EatAllYouCanPolicyCheckBox.TabIndex = 19
        Me.EatAllYouCanPolicyCheckBox.Text = "Eat-all-you-want [rations]"
        Me.EatAllYouCanPolicyCheckBox.UseVisualStyleBackColor = True
        '
        'EasierWorkPolicyCheckBox
        '
        Me.EasierWorkPolicyCheckBox.AutoSize = True
        Me.EasierWorkPolicyCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.EasierWorkPolicyCheckBox.Location = New System.Drawing.Point(27, 63)
        Me.EasierWorkPolicyCheckBox.Name = "EasierWorkPolicyCheckBox"
        Me.EasierWorkPolicyCheckBox.Size = New System.Drawing.Size(167, 17)
        Me.EasierWorkPolicyCheckBox.TabIndex = 18
        Me.EasierWorkPolicyCheckBox.Text = "10h-a-day work [workforce]"
        Me.EasierWorkPolicyCheckBox.UseVisualStyleBackColor = True
        '
        'ExhaustionPolicyCheckBox
        '
        Me.ExhaustionPolicyCheckBox.AutoSize = True
        Me.ExhaustionPolicyCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ExhaustionPolicyCheckBox.Location = New System.Drawing.Point(27, 40)
        Me.ExhaustionPolicyCheckBox.Name = "ExhaustionPolicyCheckBox"
        Me.ExhaustionPolicyCheckBox.Size = New System.Drawing.Size(162, 17)
        Me.ExhaustionPolicyCheckBox.TabIndex = 17
        Me.ExhaustionPolicyCheckBox.Text = "Work to death [workforce]"
        Me.ExhaustionPolicyCheckBox.UseVisualStyleBackColor = True
        '
        'PolicyLabel
        '
        Me.PolicyLabel.AutoSize = True
        Me.PolicyLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PolicyLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.PolicyLabel.Location = New System.Drawing.Point(71, 9)
        Me.PolicyLabel.Name = "PolicyLabel"
        Me.PolicyLabel.Size = New System.Drawing.Size(59, 17)
        Me.PolicyLabel.TabIndex = 16
        Me.PolicyLabel.Text = "POLICIES"
        '
        'CampManagementPolicies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(447, 360)
        Me.Controls.Add(Me.PoliciesPanel)
        Me.Controls.Add(Me.MarketPanel)
        Me.Controls.Add(Me.NewGameButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CampManagementPolicies"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CampManagementPolicies"
        Me.MarketPanel.ResumeLayout(False)
        Me.MarketPanel.PerformLayout()
        Me.PoliciesPanel.ResumeLayout(False)
        Me.PoliciesPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MarketPanel As Panel
    Friend WithEvents NewGameButton As Button
    Friend WithEvents PoliciesPanel As Panel
    Friend WithEvents MarketLabel As Label
    Friend WithEvents PolicyLabel As Label
    Friend WithEvents ExhaustionPolicyCheckBox As CheckBox
    Friend WithEvents EasierWorkPolicyCheckBox As CheckBox
    Friend WithEvents TwoMealsPolicyCheckBox As CheckBox
    Friend WithEvents EatAllYouCanPolicyCheckBox As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents RequestPrisonersInfo As Label
    Friend WithEvents KillPrisonersInfo As Label
    Friend WithEvents FourMealsADayInfo As Label
    Friend WithEvents EatAllYouWantInfo As Label
    Friend WithEvents TenHourInfo As Label
    Friend WithEvents WorkToDeathInfo As Label
End Class
