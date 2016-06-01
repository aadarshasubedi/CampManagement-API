<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CampManagementPoliciesForm
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
        Me.BackToGameButton = New System.Windows.Forms.Button()
        Me.PoliciesPanel = New System.Windows.Forms.Panel()
        Me.RequestPrisonersInfo = New System.Windows.Forms.Label()
        Me.KillPrisonersInfo = New System.Windows.Forms.Label()
        Me.FourMealsADayInfo = New System.Windows.Forms.Label()
        Me.EatAllYouWantInfo = New System.Windows.Forms.Label()
        Me.TenHourInfo = New System.Windows.Forms.Label()
        Me.WorkToDeathInfo = New System.Windows.Forms.Label()
        Me.RequestPrisonersCheckBox = New System.Windows.Forms.CheckBox()
        Me.ExecutePrisonersCheckBox = New System.Windows.Forms.CheckBox()
        Me.FourMealsPolicyCheckBox = New System.Windows.Forms.CheckBox()
        Me.EatAllYouCanPolicyCheckBox = New System.Windows.Forms.CheckBox()
        Me.EasierWorkPolicyCheckBox = New System.Windows.Forms.CheckBox()
        Me.ExhaustionPolicyCheckBox = New System.Windows.Forms.CheckBox()
        Me.PolicyLabel = New System.Windows.Forms.Label()
        Me.PoliciesPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'BackToGameButton
        '
        Me.BackToGameButton.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackToGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackToGameButton.Location = New System.Drawing.Point(161, 270)
        Me.BackToGameButton.Name = "BackToGameButton"
        Me.BackToGameButton.Size = New System.Drawing.Size(113, 24)
        Me.BackToGameButton.TabIndex = 1
        Me.BackToGameButton.Text = "Go back"
        Me.BackToGameButton.UseVisualStyleBackColor = False
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
        Me.PoliciesPanel.Controls.Add(Me.RequestPrisonersCheckBox)
        Me.PoliciesPanel.Controls.Add(Me.ExecutePrisonersCheckBox)
        Me.PoliciesPanel.Controls.Add(Me.FourMealsPolicyCheckBox)
        Me.PoliciesPanel.Controls.Add(Me.EatAllYouCanPolicyCheckBox)
        Me.PoliciesPanel.Controls.Add(Me.EasierWorkPolicyCheckBox)
        Me.PoliciesPanel.Controls.Add(Me.ExhaustionPolicyCheckBox)
        Me.PoliciesPanel.Controls.Add(Me.PolicyLabel)
        Me.PoliciesPanel.Location = New System.Drawing.Point(12, 12)
        Me.PoliciesPanel.Name = "PoliciesPanel"
        Me.PoliciesPanel.Size = New System.Drawing.Size(423, 252)
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
        'RequestPrisonersCheckBox
        '
        Me.RequestPrisonersCheckBox.AutoSize = True
        Me.RequestPrisonersCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RequestPrisonersCheckBox.Location = New System.Drawing.Point(27, 187)
        Me.RequestPrisonersCheckBox.Name = "RequestPrisonersCheckBox"
        Me.RequestPrisonersCheckBox.Size = New System.Drawing.Size(124, 17)
        Me.RequestPrisonersCheckBox.TabIndex = 22
        Me.RequestPrisonersCheckBox.Text = "Receive 5 prisoners"
        Me.RequestPrisonersCheckBox.UseVisualStyleBackColor = True
        '
        'ExecutePrisonersCheckBox
        '
        Me.ExecutePrisonersCheckBox.AutoSize = True
        Me.ExecutePrisonersCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ExecutePrisonersCheckBox.Location = New System.Drawing.Point(27, 164)
        Me.ExecutePrisonersCheckBox.Name = "ExecutePrisonersCheckBox"
        Me.ExecutePrisonersCheckBox.Size = New System.Drawing.Size(135, 17)
        Me.ExecutePrisonersCheckBox.TabIndex = 21
        Me.ExecutePrisonersCheckBox.Text = "Terminate 5 prisoners"
        Me.ExecutePrisonersCheckBox.UseVisualStyleBackColor = True
        '
        'FourMealsPolicyCheckBox
        '
        Me.FourMealsPolicyCheckBox.AutoSize = True
        Me.FourMealsPolicyCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FourMealsPolicyCheckBox.Location = New System.Drawing.Point(27, 122)
        Me.FourMealsPolicyCheckBox.Name = "FourMealsPolicyCheckBox"
        Me.FourMealsPolicyCheckBox.Size = New System.Drawing.Size(134, 17)
        Me.FourMealsPolicyCheckBox.TabIndex = 20
        Me.FourMealsPolicyCheckBox.Text = "Extra meal [Nutrition]"
        Me.FourMealsPolicyCheckBox.UseVisualStyleBackColor = True
        '
        'EatAllYouCanPolicyCheckBox
        '
        Me.EatAllYouCanPolicyCheckBox.AutoSize = True
        Me.EatAllYouCanPolicyCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.EatAllYouCanPolicyCheckBox.Location = New System.Drawing.Point(27, 99)
        Me.EatAllYouCanPolicyCheckBox.Name = "EatAllYouCanPolicyCheckBox"
        Me.EatAllYouCanPolicyCheckBox.Size = New System.Drawing.Size(148, 17)
        Me.EatAllYouCanPolicyCheckBox.TabIndex = 19
        Me.EatAllYouCanPolicyCheckBox.Text = "Extra 4 meals [Nutrition]"
        Me.EatAllYouCanPolicyCheckBox.UseVisualStyleBackColor = True
        '
        'EasierWorkPolicyCheckBox
        '
        Me.EasierWorkPolicyCheckBox.AutoSize = True
        Me.EasierWorkPolicyCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.EasierWorkPolicyCheckBox.Location = New System.Drawing.Point(27, 63)
        Me.EasierWorkPolicyCheckBox.Name = "EasierWorkPolicyCheckBox"
        Me.EasierWorkPolicyCheckBox.Size = New System.Drawing.Size(150, 17)
        Me.EasierWorkPolicyCheckBox.TabIndex = 18
        Me.EasierWorkPolicyCheckBox.Text = "Double Journeys [Labor]"
        Me.EasierWorkPolicyCheckBox.UseVisualStyleBackColor = True
        '
        'ExhaustionPolicyCheckBox
        '
        Me.ExhaustionPolicyCheckBox.AutoSize = True
        Me.ExhaustionPolicyCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ExhaustionPolicyCheckBox.Location = New System.Drawing.Point(27, 40)
        Me.ExhaustionPolicyCheckBox.Name = "ExhaustionPolicyCheckBox"
        Me.ExhaustionPolicyCheckBox.Size = New System.Drawing.Size(122, 17)
        Me.ExhaustionPolicyCheckBox.TabIndex = 17
        Me.ExhaustionPolicyCheckBox.Text = "Tiring work [Labor]"
        Me.ExhaustionPolicyCheckBox.UseVisualStyleBackColor = True
        '
        'PolicyLabel
        '
        Me.PolicyLabel.AutoSize = True
        Me.PolicyLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PolicyLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.PolicyLabel.Location = New System.Drawing.Point(184, 9)
        Me.PolicyLabel.Name = "PolicyLabel"
        Me.PolicyLabel.Size = New System.Drawing.Size(59, 17)
        Me.PolicyLabel.TabIndex = 16
        Me.PolicyLabel.Text = "POLICIES"
        '
        'CampManagementPoliciesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(447, 303)
        Me.Controls.Add(Me.PoliciesPanel)
        Me.Controls.Add(Me.BackToGameButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CampManagementPoliciesForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CampManagementPolicies"
        Me.PoliciesPanel.ResumeLayout(False)
        Me.PoliciesPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BackToGameButton As Button
    Friend WithEvents PoliciesPanel As Panel
    Friend WithEvents PolicyLabel As Label
    Friend WithEvents ExhaustionPolicyCheckBox As CheckBox
    Friend WithEvents EasierWorkPolicyCheckBox As CheckBox
    Friend WithEvents FourMealsPolicyCheckBox As CheckBox
    Friend WithEvents EatAllYouCanPolicyCheckBox As CheckBox
    Friend WithEvents RequestPrisonersCheckBox As CheckBox
    Friend WithEvents ExecutePrisonersCheckBox As CheckBox
    Friend WithEvents RequestPrisonersInfo As Label
    Friend WithEvents KillPrisonersInfo As Label
    Friend WithEvents FourMealsADayInfo As Label
    Friend WithEvents EatAllYouWantInfo As Label
    Friend WithEvents TenHourInfo As Label
    Friend WithEvents WorkToDeathInfo As Label
End Class
