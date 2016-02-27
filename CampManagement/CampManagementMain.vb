Imports TheckStudios_Management_Sim_API_2016
Imports System.Text
Public Class CampManagementMain
    'Declares StringBuilders for .INI reading
    Private IniString = New StringBuilder(500)
    Private IniStringDifficulty = New StringBuilder(500)
    Private IniStringIsModEnabled = New StringBuilder(500)
    Private IniStringContinueGame = New StringBuilder(500)
    Private IniStringLoadGameStatsOnStartup = New StringBuilder(500)

    'Declares variables, self-explanatory
    Private Month = 1
    Private GameOver, WhichModFile, WhichMod, ModuleDetector, LostToTaxes, MoneyTaxesApplied, LostToTaxesAndMoneyTaxesApplied, WeekFoodProfitMultiplier, NewPlayerWealthAfterWorkForceProfits, NewFoodAfterWorkersEat
    Private DifficultyValue, PlayerWealth, TotalWorkForce As Double
    'CurrentDirectory = Current Directory location
    Private CurrentDirectory = Environment.CurrentDirectory
    'GameModuleData = Modules Folder location
    Private GameModuleData = CurrentDirectory + "/Data/DLC_Modules/"
    Private GameStatsIni = CurrentDirectory + "/Data/GameStats.ini"

    Friend IsModEnabled As String = GetPrivateProfileString("Stats", "IsModEnabled", "", IniStringIsModEnabled, IniStringIsModEnabled.Capacity, GameStatsIni)
    Friend LoadGameStatsOnStartup As Boolean = GetPrivateProfileString("Stats", "LoadGameStatsOnStartup", "", IniStringLoadGameStatsOnStartup, IniStringLoadGameStatsOnStartup.Capacity, GameStatsIni)

    'Yes, this is heresy, but I like it :(
    Const Zero As Double = 0
    Const One As Double = 1
    
    Private Declare Auto Function GetPrivateProfileString Lib "kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Private Declare Auto Function WritePrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer


    Private Sub BuyWoodLabel_Click(sender As Object, e As EventArgs) Handles BuyWoodLabel.Click
        WoodInfoLabel.Text = WoodInfoLabel.Text + 10
        FinanceInfoLabel.Text = FinanceInfoLabel.Text - 20
        CheckFailure()
    End Sub

    Private Sub SellWoodLabel_Click(sender As Object, e As EventArgs) Handles SellWoodLabel.Click
        If WaterInfoLabel.Text > 0 And WaterInfoLabel.Text < 40 Then
            HistoryLog.AppendText(Environment.NewLine + "You do not have enough resources to sell safely.")
        Else
            WoodInfoLabel.Text = WoodInfoLabel.Text - 10
            FinanceInfoLabel.Text = FinanceInfoLabel.Text + 10
        End If
    End Sub

    Private Sub SellWaterLabel_Click(sender As Object, e As EventArgs) Handles SellWaterLabel.Click
        If WaterInfoLabel.Text > 0 And WaterInfoLabel.Text < 40 Then
            HistoryLog.AppendText(Environment.NewLine + "You do not have enough resources to sell safely.")
        Else
            WaterInfoLabel.Text = WaterInfoLabel.Text - 10
            FinanceInfoLabel.Text = FinanceInfoLabel.Text + 5
        End If
    End Sub

    Private Sub SellFoodLabel_Click(sender As Object, e As EventArgs) Handles SellFoodLabel.Click
        If RationInfoLabel.Text > 0 And RationInfoLabel.Text < 40 Then
            HistoryLog.AppendText(Environment.NewLine + "You do not have enough resources to sell safely.")
        Else
            RationInfoLabel.Text = RationInfoLabel.Text - 10
            FinanceInfoLabel.Text = FinanceInfoLabel.Text + 3
        End If
    End Sub

    Private Sub BuyWaterLabel_Click(sender As Object, e As EventArgs) Handles BuyWaterLabel.Click
        WaterInfoLabel.Text = WaterInfoLabel.Text + 10
        FinanceInfoLabel.Text = FinanceInfoLabel.Text - 10
        CheckFailure()
    End Sub

    Private Sub BuyFoodLabel_Click(sender As Object, e As EventArgs) Handles BuyFoodLabel.Click
        RationInfoLabel.Text = RationInfoLabel.Text + 10
        FinanceInfoLabel.Text = FinanceInfoLabel.Text - 5
        CheckFailure()
    End Sub
    Private Sub CheckFailure()
        Try
            If MPInfoLabel.Text < 0 Then
                HistoryLog.AppendText(Environment.NewLine + "You have failed. All your prisoners are dead, and, by order of the High Command, you are to be court-martialed for incompetence.")
                GameOver = True
            End If
            If RationInfoLabel.Text < 0 Then
                HistoryLog.AppendText(Environment.NewLine + "You have failed. All your prisoners died due to starvation, and, by order of the High Command, you are to be court-martialed for incompetence.")
                GameOver = True
            End If
            If FinanceInfoLabel.Text < 0 Then
                HistoryLog.AppendText(Environment.NewLine + "You have failed. You have gone bankrupt, and, by order of the High Command, you are to be court-martialed for incompetence.")
                GameOver = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Error while checking if Camp is still working.")
        End Try
    End Sub
    Private Sub SaveValuesToIni()
        Try
            WritePrivateProfileString("Stats", "Ration", RationInfoLabel.Text, GameStatsIni)
            WritePrivateProfileString("Stats", "Water", WaterInfoLabel.Text, GameStatsIni)
            WritePrivateProfileString("Stats", "Money", FinanceInfoLabel.Text, GameStatsIni)
            WritePrivateProfileString("Stats", "Wood", WoodInfoLabel.Text, GameStatsIni)
            WritePrivateProfileString("Stats", "ManpowerForce", MPInfoLabel.Text, GameStatsIni)
            WritePrivateProfileString("Stats", "CurrentYear", YearLabel.Text, GameStatsIni)
            WritePrivateProfileString("Stats", "CurrentMonth", MonthLabel.Text, GameStatsIni)
            WritePrivateProfileString("Stats", "CurrentDay", DayLabel.Text, GameStatsIni)
            HistoryLog.AppendText(Environment.NewLine + "Game successfully saved.")

            MsgBox("Game Status saved.")
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Information synchronizer has crashed.")
        End Try
    End Sub
    Private Sub RefreshValuesFromIni()
        Try
            GetPrivateProfileString("Stats", "Wood", "", IniString, IniString.Capacity, GameStatsIni)
            WoodInfoLabel.Text = IniString.ToString
            GetPrivateProfileString("Stats", "Water", "", IniString, IniString.Capacity, GameStatsIni)
            WaterInfoLabel.Text = IniString.ToString
            GetPrivateProfileString("Stats", "Money", "", IniString, IniString.Capacity, GameStatsIni)
            FinanceInfoLabel.Text = IniString.ToString
            GetPrivateProfileString("Stats", "Ration", "", IniString, IniString.Capacity, GameStatsIni)
            RationInfoLabel.Text = IniString.ToString
            GetPrivateProfileString("Stats", "ManpowerForce", "", IniString, IniString.Capacity, GameStatsIni)
            MPInfoLabel.Text = IniString.ToString
            GetPrivateProfileString("Stats", "CurrentYear", "", IniString, IniString.Capacity, GameStatsIni)
            YearLabel.Text = IniString.ToString
            GetPrivateProfileString("Stats", "CurrentMonth", "", IniString, IniString.Capacity, GameStatsIni)
            MonthLabel.Text = IniString.ToString
            GetPrivateProfileString("Stats", "CurrentDay", "", IniString, IniString.Capacity, GameStatsIni)
            DayLabel.Text = IniString.ToString
            HistoryLog.AppendText(Environment.NewLine + "Game successfully loaded.")

            MsgBox("Game Status loaded.")
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Information synchronizer has crashed.")
        End Try
    End Sub
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        SaveValuesToIni()
    End Sub
    Private Sub LoadButton_Click(sender As Object, e As EventArgs) Handles LoadButton.Click
        RefreshValuesFromIni()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles NextWeekButton.Click
        If Not GameOver = True Then
            PlayerWealth = Convert.ToDouble(FinanceInfoLabel.Text)
            TotalWorkForce = Convert.ToDouble(MPInfoLabel.Text)
            Try
                If Mechanics.GetDay(DayLabel.Text) > 30 Then
                    DayLabel.Text = Mechanics.GetDay(DayLabel.Text) - 30
                    Month = Month + 1
                Else
                    DayLabel.Text = Mechanics.GetDay(DayLabel.Text)
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
                MsgBox("Failed to increase day count.", MsgBoxStyle.Critical)
            End Try
            'Checks and handles the variables to keep the correct --and current-- year in check.
            Try
                If Not Month = 13 Then
                    MonthLabel.Text = Mechanics.GetMonth(Month)
                Else
                    'Updates the money on the UI with the new value after inflation is applied.
                    FinanceInfoLabel.Text = Mechanics.Inflation(PlayerWealth)
                    PlayerWealth = FinanceInfoLabel.Text
                    HistoryLog.AppendText(Environment.NewLine)
                    HistoryLog.AppendText(Environment.NewLine + "Your treasury master comes running to your office to warn you that inflation has destroyed a good portion of your money.")

                    LostToTaxesAndMoneyTaxesApplied = Mechanics.Taxes(PlayerWealth)
                    FinanceInfoLabel.Text = LostToTaxesAndMoneyTaxesApplied(0)
                    LostToTaxes = LostToTaxesAndMoneyTaxesApplied(1)
                    HistoryLog.AppendText(Environment.NewLine)
                    HistoryLog.AppendText(Environment.NewLine + "The local government requires payment of taxes. You lost the following: $" + LostToTaxes.ToString)
                    Month = 1
                    MonthLabel.Text = Mechanics.GetMonth(Month)
                    YearLabel.Text = YearLabel.Text + 1
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
                MsgBox("Failed to increase month count or call Inflation/Taxes", MsgBoxStyle.Critical)
            End Try

            HistoryLog.AppendText(Environment.NewLine)
            HistoryLog.AppendText(Environment.NewLine + "You come back to your camp to check how it is going. It is " + DayLabel.Text + "th of " + MonthLabel.Text)

            'Checks what will be the values used to handle food consumption, and apply them to a variable.
            Try
                If CampManagementPoliciesForm.EatAllYouCanPolicy = True Then
                    WeekFoodProfitMultiplier = 1.25
                    NewFoodAfterWorkersEat = MPInfoLabel.Text * 6
                    RationInfoLabel.Text = RationInfoLabel.Text - NewFoodAfterWorkersEat
                End If
                If CampManagementPoliciesForm.FourMealsPolicy = True Then
                    WeekFoodProfitMultiplier = 1.1
                    NewFoodAfterWorkersEat = MPInfoLabel.Text * 4
                    RationInfoLabel.Text = RationInfoLabel.Text - NewFoodAfterWorkersEat
                End If
                If CampManagementPoliciesForm.EatAllYouCanPolicy = False And CampManagementPoliciesForm.FourMealsPolicy = False Then
                    WeekFoodProfitMultiplier = 1
                    NewFoodAfterWorkersEat = MPInfoLabel.Text * 2
                    RationInfoLabel.Text = RationInfoLabel.Text - NewFoodAfterWorkersEat
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
                MsgBox("Failed to calculate food consumption by workers.")
            End Try

            'Checks what will be the values used to handle worker profit, and apply them to a variable. Also uses the food consumption variable multipliers.
            Try
                NewPlayerWealthAfterWorkForceProfits = Resources.WorkForceGenerateProfits(PlayerWealth, TotalWorkForce)
                If CampManagementPoliciesForm.ExhaustionPolicy = True Then
                    FinanceInfoLabel.Text = NewPlayerWealthAfterWorkForceProfits(0) * 1.25 * WeekFoodProfitMultiplier
                    HistoryLog.AppendText(Environment.NewLine + "The smell of death is strong. 6 prisoners died due to exhaustion while working to death, but you received twice as much profit.")
                    MPInfoLabel.Text = MPInfoLabel.Text - 6
                End If
                If CampManagementPoliciesForm.EasierWorkPolicy = True Then
                    FinanceInfoLabel.Text = NewPlayerWealthAfterWorkForceProfits(0) * 1.15 * WeekFoodProfitMultiplier
                    HistoryLog.AppendText(Environment.NewLine + "2 prisoners died due to exhaustion while working to death, but you received a bit more profit.")
                    MPInfoLabel.Text = MPInfoLabel.Text - 2
                End If
                If CampManagementPoliciesForm.EasierWorkPolicy = False And CampManagementPoliciesForm.ExhaustionPolicy = False Then
                    FinanceInfoLabel.Text = NewPlayerWealthAfterWorkForceProfits(0) * 1 * WeekFoodProfitMultiplier
                    HistoryLog.AppendText(Environment.NewLine + "The prisoners have been working hard under the military police.")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
                MsgBox("Error while working prisoners to death.")
            End Try

            'Checks what will be the new values to handle worker numbers, if extra policies were issued.
            Try
                If CampManagementPoliciesForm.RequestPrisoner = True Then
                    CampManagementPoliciesForm.RequestPrisoner = False
                    MPInfoLabel.Text = MPInfoLabel.Text + 5
                    FinanceInfoLabel.Text = FinanceInfoLabel.Text - 20
                    HistoryLog.AppendText(Environment.NewLine + "A military truck just arrived, with 5 new POWs. For this extra shipment, High Command charged you $20")
                End If
                If CampManagementPoliciesForm.ExecutePrisoners = True Then
                    CampManagementPoliciesForm.ExecutePrisoners = False
                    MPInfoLabel.Text = MPInfoLabel.Text - 5
                    FinanceInfoLabel.Text = FinanceInfoLabel.Text + 20
                    HistoryLog.AppendText(Environment.NewLine + "A military truck just left the camp with 5 dead POWs. For taking care of german conscripts, High Command awarded you $20")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
                MsgBox("Error while greeting POWs from new shipment")
            End Try

            'Checks if there are any values below the necessary for the camp to survive, and issue a Game Over.
            CheckFailure()



        Else
            MsgBox("You have lost the game, please, re-open the game, and start a new game.")
        End If
    End Sub
    Private Sub CampManagementMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Checks what difficulty settings the player is running on.
        Try
            GetPrivateProfileString("Stats", "Difficulty", "", IniStringDifficulty, IniStringDifficulty.Capacity, GameStatsIni)
            DifficultyValue = Convert.ToDouble(IniStringDifficulty.ToString)
            If DifficultyValue = Zero Then
                TaxesLabel.Text = "15%"
            Else
                TaxesLabel.Text = "35%"
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Failed to define taxes information on UI")
        End Try

        'Checks if the game is being loaded through Continue.
        GetPrivateProfileString("Stats", "LoadGameStatsOnStartup", "", IniStringContinueGame, IniStringContinueGame.Capacity, GameStatsIni)
        WritePrivateProfileString("Stats", "LoadGameStatsOnStartup", "False", GameStatsIni)

        If IniStringContinueGame.ToString = "True" Then
            RefreshValuesFromIni()
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub PolicyButton_Click(sender As Object, e As EventArgs) Handles PolicyButton.Click
        CampManagementPoliciesForm.Show()
    End Sub
End Class