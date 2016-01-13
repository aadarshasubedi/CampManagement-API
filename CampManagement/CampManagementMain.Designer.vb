<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CampManagementMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CampManagementMain))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.WaterInfoLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TaxesLabel = New System.Windows.Forms.Label()
        Me.CountryLabel = New System.Windows.Forms.Label()
        Me.DayLabel = New System.Windows.Forms.Label()
        Me.YearLabel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MonthLabel = New System.Windows.Forms.Label()
        Me.MPInfoLabel = New System.Windows.Forms.Label()
        Me.WoodInfoLabel = New System.Windows.Forms.Label()
        Me.RationInfoLabel = New System.Windows.Forms.Label()
        Me.FinanceInfoLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NextWeekButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.HistoryLog = New System.Windows.Forms.TextBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.LoadButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.WaterInfoLabel)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.TaxesLabel)
        Me.Panel1.Controls.Add(Me.CountryLabel)
        Me.Panel1.Controls.Add(Me.DayLabel)
        Me.Panel1.Controls.Add(Me.YearLabel)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.MonthLabel)
        Me.Panel1.Controls.Add(Me.MPInfoLabel)
        Me.Panel1.Controls.Add(Me.WoodInfoLabel)
        Me.Panel1.Controls.Add(Me.RationInfoLabel)
        Me.Panel1.Controls.Add(Me.FinanceInfoLabel)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(345, 112)
        Me.Panel1.TabIndex = 0
        '
        'WaterInfoLabel
        '
        Me.WaterInfoLabel.AutoSize = True
        Me.WaterInfoLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WaterInfoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.WaterInfoLabel.Location = New System.Drawing.Point(127, 74)
        Me.WaterInfoLabel.Name = "WaterInfoLabel"
        Me.WaterInfoLabel.Size = New System.Drawing.Size(25, 13)
        Me.WaterInfoLabel.TabIndex = 13
        Me.WaterInfoLabel.Text = "150"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(13, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Water (In Liters):"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label16.Location = New System.Drawing.Point(216, 43)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(29, 13)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "Day:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label15.Location = New System.Drawing.Point(216, 27)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 13)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Month:"
        '
        'TaxesLabel
        '
        Me.TaxesLabel.AutoSize = True
        Me.TaxesLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TaxesLabel.Location = New System.Drawing.Point(306, 9)
        Me.TaxesLabel.Name = "TaxesLabel"
        Me.TaxesLabel.Size = New System.Drawing.Size(29, 15)
        Me.TaxesLabel.TabIndex = 9
        Me.TaxesLabel.Text = "15%"
        '
        'CountryLabel
        '
        Me.CountryLabel.AutoSize = True
        Me.CountryLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CountryLabel.Location = New System.Drawing.Point(216, 86)
        Me.CountryLabel.Name = "CountryLabel"
        Me.CountryLabel.Size = New System.Drawing.Size(55, 15)
        Me.CountryLabel.TabIndex = 2
        Me.CountryLabel.Text = "Germany"
        '
        'DayLabel
        '
        Me.DayLabel.AutoSize = True
        Me.DayLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DayLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.DayLabel.Location = New System.Drawing.Point(258, 43)
        Me.DayLabel.Name = "DayLabel"
        Me.DayLabel.Size = New System.Drawing.Size(13, 13)
        Me.DayLabel.TabIndex = 5
        Me.DayLabel.Text = "1"
        '
        'YearLabel
        '
        Me.YearLabel.AutoSize = True
        Me.YearLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.YearLabel.Location = New System.Drawing.Point(304, 86)
        Me.YearLabel.Name = "YearLabel"
        Me.YearLabel.Size = New System.Drawing.Size(31, 15)
        Me.YearLabel.TabIndex = 3
        Me.YearLabel.Text = "1946"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(216, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Taxes (Per Year):"
        '
        'MonthLabel
        '
        Me.MonthLabel.AutoSize = True
        Me.MonthLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MonthLabel.Location = New System.Drawing.Point(267, 27)
        Me.MonthLabel.Name = "MonthLabel"
        Me.MonthLabel.Size = New System.Drawing.Size(46, 13)
        Me.MonthLabel.TabIndex = 4
        Me.MonthLabel.Text = "January"
        '
        'MPInfoLabel
        '
        Me.MPInfoLabel.AutoSize = True
        Me.MPInfoLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MPInfoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MPInfoLabel.Location = New System.Drawing.Point(127, 59)
        Me.MPInfoLabel.Name = "MPInfoLabel"
        Me.MPInfoLabel.Size = New System.Drawing.Size(19, 13)
        Me.MPInfoLabel.TabIndex = 7
        Me.MPInfoLabel.Text = "12"
        '
        'WoodInfoLabel
        '
        Me.WoodInfoLabel.AutoSize = True
        Me.WoodInfoLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WoodInfoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.WoodInfoLabel.Location = New System.Drawing.Point(127, 43)
        Me.WoodInfoLabel.Name = "WoodInfoLabel"
        Me.WoodInfoLabel.Size = New System.Drawing.Size(19, 13)
        Me.WoodInfoLabel.TabIndex = 6
        Me.WoodInfoLabel.Text = "10"
        '
        'RationInfoLabel
        '
        Me.RationInfoLabel.AutoSize = True
        Me.RationInfoLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RationInfoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RationInfoLabel.Location = New System.Drawing.Point(127, 27)
        Me.RationInfoLabel.Name = "RationInfoLabel"
        Me.RationInfoLabel.Size = New System.Drawing.Size(19, 13)
        Me.RationInfoLabel.TabIndex = 5
        Me.RationInfoLabel.Text = "10"
        '
        'FinanceInfoLabel
        '
        Me.FinanceInfoLabel.AutoSize = True
        Me.FinanceInfoLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FinanceInfoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FinanceInfoLabel.Location = New System.Drawing.Point(127, 10)
        Me.FinanceInfoLabel.Name = "FinanceInfoLabel"
        Me.FinanceInfoLabel.Size = New System.Drawing.Size(25, 13)
        Me.FinanceInfoLabel.TabIndex = 4
        Me.FinanceInfoLabel.Text = "100"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(13, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Prisoners:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(13, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Wood (In Tonnes):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(13, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ration (In Sacks):"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(13, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Treasury (In USD):"
        '
        'NextWeekButton
        '
        Me.NextWeekButton.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.NextWeekButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.NextWeekButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NextWeekButton.Location = New System.Drawing.Point(255, 365)
        Me.NextWeekButton.Name = "NextWeekButton"
        Me.NextWeekButton.Size = New System.Drawing.Size(102, 29)
        Me.NextWeekButton.TabIndex = 1
        Me.NextWeekButton.Text = "Next Week"
        Me.NextWeekButton.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'HistoryLog
        '
        Me.HistoryLog.BackColor = System.Drawing.SystemColors.MenuText
        Me.HistoryLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HistoryLog.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HistoryLog.ForeColor = System.Drawing.SystemColors.Window
        Me.HistoryLog.Location = New System.Drawing.Point(363, 12)
        Me.HistoryLog.Multiline = True
        Me.HistoryLog.Name = "HistoryLog"
        Me.HistoryLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.HistoryLog.Size = New System.Drawing.Size(444, 382)
        Me.HistoryLog.TabIndex = 7
        Me.HistoryLog.Text = resources.GetString("HistoryLog.Text")
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveButton.Location = New System.Drawing.Point(12, 330)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(71, 29)
        Me.SaveButton.TabIndex = 8
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'LoadButton
        '
        Me.LoadButton.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LoadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LoadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoadButton.Location = New System.Drawing.Point(12, 365)
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.Size = New System.Drawing.Size(71, 29)
        Me.LoadButton.TabIndex = 9
        Me.LoadButton.Text = "Load"
        Me.LoadButton.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(618, 398)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(189, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Miller Berto Simberg Anaia © 2016"
        '
        'CampManagementMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(821, 422)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LoadButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.HistoryLog)
        Me.Controls.Add(Me.NextWeekButton)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CampManagementMain"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CampManagement"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MPInfoLabel As Label
    Friend WithEvents WoodInfoLabel As Label
    Friend WithEvents RationInfoLabel As Label
    Friend WithEvents FinanceInfoLabel As Label
    Friend WithEvents TaxesLabel As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents NextWeekButton As Button
    Friend WithEvents CountryLabel As Label
    Friend WithEvents YearLabel As Label
    Friend WithEvents MonthLabel As Label
    Friend WithEvents DayLabel As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents HistoryLog As TextBox
    Friend WithEvents WaterInfoLabel As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents SaveButton As Button
    Friend WithEvents LoadButton As Button
    Friend WithEvents Label5 As Label
End Class
