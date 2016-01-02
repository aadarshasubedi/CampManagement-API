<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CampManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CampManagement))
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.HistoryLog = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
        Me.Panel1.Size = New System.Drawing.Size(444, 112)
        Me.Panel1.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label16.Location = New System.Drawing.Point(291, 40)
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
        Me.Label15.Location = New System.Drawing.Point(291, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 13)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Month:"
        '
        'TaxesLabel
        '
        Me.TaxesLabel.AutoSize = True
        Me.TaxesLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TaxesLabel.Location = New System.Drawing.Point(388, 10)
        Me.TaxesLabel.Name = "TaxesLabel"
        Me.TaxesLabel.Size = New System.Drawing.Size(29, 15)
        Me.TaxesLabel.TabIndex = 9
        Me.TaxesLabel.Text = "15%"
        '
        'CountryLabel
        '
        Me.CountryLabel.AutoSize = True
        Me.CountryLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CountryLabel.Location = New System.Drawing.Point(336, 85)
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
        Me.DayLabel.Location = New System.Drawing.Point(326, 40)
        Me.DayLabel.Name = "DayLabel"
        Me.DayLabel.Size = New System.Drawing.Size(13, 13)
        Me.DayLabel.TabIndex = 5
        Me.DayLabel.Text = "1"
        '
        'YearLabel
        '
        Me.YearLabel.AutoSize = True
        Me.YearLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.YearLabel.Location = New System.Drawing.Point(397, 85)
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
        Me.Label9.Location = New System.Drawing.Point(291, 10)
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
        Me.MonthLabel.Location = New System.Drawing.Point(338, 25)
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
        Me.MPInfoLabel.Location = New System.Drawing.Point(77, 55)
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
        Me.WoodInfoLabel.Location = New System.Drawing.Point(116, 40)
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
        Me.RationInfoLabel.Location = New System.Drawing.Point(114, 25)
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
        Me.FinanceInfoLabel.Location = New System.Drawing.Point(116, 10)
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
        Me.Label4.Location = New System.Drawing.Point(13, 55)
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
        Me.Label3.Location = New System.Drawing.Point(13, 40)
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
        Me.Label2.Location = New System.Drawing.Point(13, 25)
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(354, 365)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 29)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Next Week"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'Timer2
        '
        Me.Timer2.Interval = 45
        '
        'HistoryLog
        '
        Me.HistoryLog.BackColor = System.Drawing.SystemColors.MenuText
        Me.HistoryLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HistoryLog.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HistoryLog.ForeColor = System.Drawing.SystemColors.Window
        Me.HistoryLog.Location = New System.Drawing.Point(12, 130)
        Me.HistoryLog.Multiline = True
        Me.HistoryLog.Name = "HistoryLog"
        Me.HistoryLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.HistoryLog.Size = New System.Drawing.Size(444, 137)
        Me.HistoryLog.TabIndex = 7
        Me.HistoryLog.Text = resources.GetString("HistoryLog.Text")
        '
        'CampManagement
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(468, 406)
        Me.Controls.Add(Me.HistoryLog)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CampManagement"
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
    Friend WithEvents Button1 As Button
    Friend WithEvents CountryLabel As Label
    Friend WithEvents YearLabel As Label
    Friend WithEvents MonthLabel As Label
    Friend WithEvents DayLabel As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents HistoryLog As TextBox
End Class
