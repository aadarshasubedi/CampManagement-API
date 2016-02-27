<CompilerServices.DesignerGenerated()>
Partial Class CampManagementMain
    Inherits Form

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
    <DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CampManagementMain))
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.WaterInfoLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TaxesLabel = New System.Windows.Forms.Label()
        Me.CountryLabel = New System.Windows.Forms.Label()
        Me.DayLabel = New System.Windows.Forms.Label()
        Me.YearLabel = New System.Windows.Forms.Label()
        Me.TaxesDescriptionLabel = New System.Windows.Forms.Label()
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
        Me.CopyrightLabel = New System.Windows.Forms.Label()
        Me.PolicyButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SellFoodLabel = New System.Windows.Forms.Label()
        Me.SellWaterLabel = New System.Windows.Forms.Label()
        Me.SellWoodLabel = New System.Windows.Forms.Label()
        Me.BuyFoodLabel = New System.Windows.Forms.Label()
        Me.BuyWaterLabel = New System.Windows.Forms.Label()
        Me.BuyWoodLabel = New System.Windows.Forms.Label()
        Me.FoodLabel = New System.Windows.Forms.Label()
        Me.WaterLabel = New System.Windows.Forms.Label()
        Me.WoodLabel = New System.Windows.Forms.Label()
        Me.MarketPanelLabel = New System.Windows.Forms.Label()
        Me.MainPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.SystemColors.Desktop
        Me.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainPanel.Controls.Add(Me.WaterInfoLabel)
        Me.MainPanel.Controls.Add(Me.Label6)
        Me.MainPanel.Controls.Add(Me.Label16)
        Me.MainPanel.Controls.Add(Me.Label15)
        Me.MainPanel.Controls.Add(Me.TaxesLabel)
        Me.MainPanel.Controls.Add(Me.CountryLabel)
        Me.MainPanel.Controls.Add(Me.DayLabel)
        Me.MainPanel.Controls.Add(Me.YearLabel)
        Me.MainPanel.Controls.Add(Me.TaxesDescriptionLabel)
        Me.MainPanel.Controls.Add(Me.MonthLabel)
        Me.MainPanel.Controls.Add(Me.MPInfoLabel)
        Me.MainPanel.Controls.Add(Me.WoodInfoLabel)
        Me.MainPanel.Controls.Add(Me.RationInfoLabel)
        Me.MainPanel.Controls.Add(Me.FinanceInfoLabel)
        Me.MainPanel.Controls.Add(Me.Label4)
        Me.MainPanel.Controls.Add(Me.Label3)
        Me.MainPanel.Controls.Add(Me.Label2)
        Me.MainPanel.Controls.Add(Me.Label1)
        Me.MainPanel.Location = New System.Drawing.Point(12, 12)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(336, 112)
        Me.MainPanel.TabIndex = 0
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
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Water barrels:"
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
        Me.TaxesLabel.Location = New System.Drawing.Point(284, 9)
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
        Me.DayLabel.Location = New System.Drawing.Point(300, 43)
        Me.DayLabel.Name = "DayLabel"
        Me.DayLabel.Size = New System.Drawing.Size(13, 13)
        Me.DayLabel.TabIndex = 5
        Me.DayLabel.Text = "1"
        '
        'YearLabel
        '
        Me.YearLabel.AutoSize = True
        Me.YearLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.YearLabel.Location = New System.Drawing.Point(282, 86)
        Me.YearLabel.Name = "YearLabel"
        Me.YearLabel.Size = New System.Drawing.Size(31, 15)
        Me.YearLabel.TabIndex = 3
        Me.YearLabel.Text = "1946"
        '
        'TaxesDescriptionLabel
        '
        Me.TaxesDescriptionLabel.AutoSize = True
        Me.TaxesDescriptionLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaxesDescriptionLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TaxesDescriptionLabel.Location = New System.Drawing.Point(216, 10)
        Me.TaxesDescriptionLabel.Name = "TaxesDescriptionLabel"
        Me.TaxesDescriptionLabel.Size = New System.Drawing.Size(67, 13)
        Me.TaxesDescriptionLabel.TabIndex = 8
        Me.TaxesDescriptionLabel.Text = "Yearly taxes:"
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
        Me.MPInfoLabel.Text = "20"
        '
        'WoodInfoLabel
        '
        Me.WoodInfoLabel.AutoSize = True
        Me.WoodInfoLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WoodInfoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.WoodInfoLabel.Location = New System.Drawing.Point(127, 43)
        Me.WoodInfoLabel.Name = "WoodInfoLabel"
        Me.WoodInfoLabel.Size = New System.Drawing.Size(25, 13)
        Me.WoodInfoLabel.TabIndex = 6
        Me.WoodInfoLabel.Text = "100"
        '
        'RationInfoLabel
        '
        Me.RationInfoLabel.AutoSize = True
        Me.RationInfoLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RationInfoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RationInfoLabel.Location = New System.Drawing.Point(127, 27)
        Me.RationInfoLabel.Name = "RationInfoLabel"
        Me.RationInfoLabel.Size = New System.Drawing.Size(25, 13)
        Me.RationInfoLabel.TabIndex = 5
        Me.RationInfoLabel.Text = "200"
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
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Wood containers:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(13, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ration sacks:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(13, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Treasury:"
        '
        'NextWeekButton
        '
        Me.NextWeekButton.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.NextWeekButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.NextWeekButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NextWeekButton.Location = New System.Drawing.Point(237, 365)
        Me.NextWeekButton.Name = "NextWeekButton"
        Me.NextWeekButton.Size = New System.Drawing.Size(111, 29)
        Me.NextWeekButton.TabIndex = 1
        Me.NextWeekButton.Text = "Go forth a week"
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
        Me.SaveButton.Location = New System.Drawing.Point(12, 314)
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
        Me.LoadButton.Location = New System.Drawing.Point(12, 349)
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.Size = New System.Drawing.Size(71, 29)
        Me.LoadButton.TabIndex = 9
        Me.LoadButton.Text = "Load"
        Me.LoadButton.UseVisualStyleBackColor = False
        '
        'CopyrightLabel
        '
        Me.CopyrightLabel.AutoSize = True
        Me.CopyrightLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CopyrightLabel.Location = New System.Drawing.Point(618, 398)
        Me.CopyrightLabel.Name = "CopyrightLabel"
        Me.CopyrightLabel.Size = New System.Drawing.Size(189, 15)
        Me.CopyrightLabel.TabIndex = 11
        Me.CopyrightLabel.Text = "Miller Berto Simberg Anaia © 2016"
        '
        'PolicyButton
        '
        Me.PolicyButton.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PolicyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PolicyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PolicyButton.Location = New System.Drawing.Point(12, 130)
        Me.PolicyButton.Name = "PolicyButton"
        Me.PolicyButton.Size = New System.Drawing.Size(88, 25)
        Me.PolicyButton.TabIndex = 13
        Me.PolicyButton.Text = "Management"
        Me.PolicyButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(12, 384)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 29)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.SellFoodLabel)
        Me.Panel1.Controls.Add(Me.SellWaterLabel)
        Me.Panel1.Controls.Add(Me.SellWoodLabel)
        Me.Panel1.Controls.Add(Me.BuyFoodLabel)
        Me.Panel1.Controls.Add(Me.BuyWaterLabel)
        Me.Panel1.Controls.Add(Me.BuyWoodLabel)
        Me.Panel1.Controls.Add(Me.FoodLabel)
        Me.Panel1.Controls.Add(Me.WaterLabel)
        Me.Panel1.Controls.Add(Me.WoodLabel)
        Me.Panel1.Controls.Add(Me.MarketPanelLabel)
        Me.Panel1.Location = New System.Drawing.Point(106, 130)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(242, 86)
        Me.Panel1.TabIndex = 19
        '
        'SellFoodLabel
        '
        Me.SellFoodLabel.AutoSize = True
        Me.SellFoodLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SellFoodLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SellFoodLabel.Location = New System.Drawing.Point(142, 60)
        Me.SellFoodLabel.Name = "SellFoodLabel"
        Me.SellFoodLabel.Size = New System.Drawing.Size(87, 13)
        Me.SellFoodLabel.TabIndex = 24
        Me.SellFoodLabel.Text = "SELL  - 10 for $3"
        '
        'SellWaterLabel
        '
        Me.SellWaterLabel.AutoSize = True
        Me.SellWaterLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SellWaterLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SellWaterLabel.Location = New System.Drawing.Point(142, 44)
        Me.SellWaterLabel.Name = "SellWaterLabel"
        Me.SellWaterLabel.Size = New System.Drawing.Size(87, 13)
        Me.SellWaterLabel.TabIndex = 23
        Me.SellWaterLabel.Text = "SELL  - 10 for $5"
        '
        'SellWoodLabel
        '
        Me.SellWoodLabel.AutoSize = True
        Me.SellWoodLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SellWoodLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SellWoodLabel.Location = New System.Drawing.Point(142, 28)
        Me.SellWoodLabel.Name = "SellWoodLabel"
        Me.SellWoodLabel.Size = New System.Drawing.Size(93, 13)
        Me.SellWoodLabel.TabIndex = 22
        Me.SellWoodLabel.Text = "SELL  - 10 for $10"
        '
        'BuyFoodLabel
        '
        Me.BuyFoodLabel.AutoSize = True
        Me.BuyFoodLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuyFoodLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BuyFoodLabel.Location = New System.Drawing.Point(44, 60)
        Me.BuyFoodLabel.Name = "BuyFoodLabel"
        Me.BuyFoodLabel.Size = New System.Drawing.Size(85, 13)
        Me.BuyFoodLabel.TabIndex = 21
        Me.BuyFoodLabel.Text = "BUY  - 10 for $5"
        '
        'BuyWaterLabel
        '
        Me.BuyWaterLabel.AutoSize = True
        Me.BuyWaterLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuyWaterLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BuyWaterLabel.Location = New System.Drawing.Point(44, 44)
        Me.BuyWaterLabel.Name = "BuyWaterLabel"
        Me.BuyWaterLabel.Size = New System.Drawing.Size(91, 13)
        Me.BuyWaterLabel.TabIndex = 20
        Me.BuyWaterLabel.Text = "BUY  - 10 for $10"
        '
        'BuyWoodLabel
        '
        Me.BuyWoodLabel.AutoSize = True
        Me.BuyWoodLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuyWoodLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BuyWoodLabel.Location = New System.Drawing.Point(44, 27)
        Me.BuyWoodLabel.Name = "BuyWoodLabel"
        Me.BuyWoodLabel.Size = New System.Drawing.Size(91, 13)
        Me.BuyWoodLabel.TabIndex = 17
        Me.BuyWoodLabel.Text = "BUY  - 10 for $20"
        '
        'FoodLabel
        '
        Me.FoodLabel.AutoSize = True
        Me.FoodLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FoodLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FoodLabel.Location = New System.Drawing.Point(3, 59)
        Me.FoodLabel.Name = "FoodLabel"
        Me.FoodLabel.Size = New System.Drawing.Size(37, 15)
        Me.FoodLabel.TabIndex = 19
        Me.FoodLabel.Text = "Food:"
        '
        'WaterLabel
        '
        Me.WaterLabel.AutoSize = True
        Me.WaterLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WaterLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.WaterLabel.Location = New System.Drawing.Point(3, 43)
        Me.WaterLabel.Name = "WaterLabel"
        Me.WaterLabel.Size = New System.Drawing.Size(41, 15)
        Me.WaterLabel.TabIndex = 18
        Me.WaterLabel.Text = "Water:"
        '
        'WoodLabel
        '
        Me.WoodLabel.AutoSize = True
        Me.WoodLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WoodLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.WoodLabel.Location = New System.Drawing.Point(3, 26)
        Me.WoodLabel.Name = "WoodLabel"
        Me.WoodLabel.Size = New System.Drawing.Size(42, 15)
        Me.WoodLabel.TabIndex = 17
        Me.WoodLabel.Text = "Wood:"
        '
        'MarketPanelLabel
        '
        Me.MarketPanelLabel.AutoSize = True
        Me.MarketPanelLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MarketPanelLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MarketPanelLabel.Location = New System.Drawing.Point(3, 5)
        Me.MarketPanelLabel.Name = "MarketPanelLabel"
        Me.MarketPanelLabel.Size = New System.Drawing.Size(58, 17)
        Me.MarketPanelLabel.TabIndex = 15
        Me.MarketPanelLabel.Text = "MARKET" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'CampManagementMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(821, 422)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PolicyButton)
        Me.Controls.Add(Me.CopyrightLabel)
        Me.Controls.Add(Me.LoadButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.HistoryLog)
        Me.Controls.Add(Me.NextWeekButton)
        Me.Controls.Add(Me.MainPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CampManagementMain"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CampManagement"
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainPanel As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MPInfoLabel As Label
    Friend WithEvents WoodInfoLabel As Label
    Friend WithEvents RationInfoLabel As Label
    Friend WithEvents FinanceInfoLabel As Label
    Friend WithEvents TaxesLabel As Label
    Friend WithEvents TaxesDescriptionLabel As Label
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
    Friend WithEvents CopyrightLabel As Label
    Friend WithEvents PolicyButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SellFoodLabel As Label
    Friend WithEvents SellWaterLabel As Label
    Friend WithEvents SellWoodLabel As Label
    Friend WithEvents BuyFoodLabel As Label
    Friend WithEvents BuyWaterLabel As Label
    Friend WithEvents BuyWoodLabel As Label
    Friend WithEvents FoodLabel As Label
    Friend WithEvents WaterLabel As Label
    Friend WithEvents WoodLabel As Label
    Friend WithEvents MarketPanelLabel As Label
End Class
