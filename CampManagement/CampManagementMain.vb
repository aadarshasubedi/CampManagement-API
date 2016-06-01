Imports TheckStudios_Management_Sim_API_2016
Imports System.Text
Public Class CampManagementMain
    Private Declare Auto Function GetPrivateProfileString Lib "kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Private Declare Auto Function WritePrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer

    'Declares Multithreaded Programming
    Dim ShowTaxesThreaded As New Threading.Thread(AddressOf ShowTaxesInfo)
    Dim StartContinueThreaded As New Threading.Thread(AddressOf StartThroughContinue)

    'Declares StringBuilders for .INI reading
    Private IniString = New StringBuilder(500)
    Private IniStringDifficulty = New StringBuilder(500)
    Private IniStringIsModEnabled = New StringBuilder(500)
    Private IniStringContinueGame = New StringBuilder(500)
    Private IniStringLoadGameStatsOnStartup = New StringBuilder(500)

    'Declares variables, self-explanatory
    Private Month = 11, CurrentDirectory = Environment.CurrentDirectory, DifficultyValue, WhichModFile, WhichMod, ModuleDetector, LostToTaxes, MoneyTaxesApplied, LostToTaxesAndMoneyTaxesApplied, WeekFoodProfitMultiplier, NewPlayerWealthAfterWorkForceProfits, NewFoodAfterWorkersEat
    Private GameOver As Boolean
    Private PlayerWealth, TotalWorkforce As Double

    'GameModuleData = Modules Folder location
    Private GameModuleData = CurrentDirectory + "/Data/DLC_Modules/"
    Private GameStatsIni = CurrentDirectory + "/Data/GameStats.ini"

    Friend IsModEnabled As String = GetPrivateProfileString("Stats", "IsModEnabled", "", IniStringIsModEnabled, IniStringIsModEnabled.Capacity, GameStatsIni)
    Friend LoadGameStatsOnStartup As Boolean = GetPrivateProfileString("Stats", "LoadGameStatsOnStartup", "", IniStringLoadGameStatsOnStartup, IniStringLoadGameStatsOnStartup.Capacity, GameStatsIni)

    'Yes, this is heresy, but I like it :(
    Const Zero As Double = 0
    Const One As Double = 1
    Private Const WmNchittest As Integer = &H84
    Private Const Htclient As Integer = &H1
    Private Const Htcaption As Integer = &H2

    Public Sub CrashesAndExceptions()
        AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf ApplicationException
        InitializeComponent()
    End Sub
    Sub ApplicationException(ByVal sender As Object, ByVal Application As UnhandledExceptionEventArgs)
        If Application.IsTerminating Then
            Dim ApplicationCrashed As Object = Application.ExceptionObject
            MsgBox("An error has happened! It is as follows: " + ApplicationCrashed.ToString)
        End If
    End Sub
    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)
        Console.WriteLine(m.ToString())
        Select Case m.Msg
            Case WmNchittest
                If m.Result = New IntPtr(Htclient) Then
                    m.Result = New IntPtr(Htcaption)
                End If
        End Select
    End Sub
    Private Delegate Sub RefreshValuesFromIniDelegate()
    Private Delegate Sub SaveValuesToIniDelegate()
    Private Delegate Sub GeneralPurpose()
    Private Sub CampManagementMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowTaxesThreaded.Start()
        StartContinueThreaded.Start()
    End Sub
    Private Sub ShowTaxesInfo()
        'Checks what difficulty settings the player is running on.
        Try
            If InvokeRequired = True Then
                Invoke(New SaveValuesToIniDelegate(AddressOf ShowTaxesInfoDelegated))
            Else
                ShowTaxesInfoDelegated()
            End If
        Catch ex As Exception
            MsgBox("Failed to delegate taxes check to UI Thread.", MsgBoxStyle.Critical)
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub ShowTaxesInfoDelegated()
        GetPrivateProfileString("Stats", "Difficulty", "", IniStringDifficulty, IniStringDifficulty.Capacity, GameStatsIni)
        DifficultyValue = IniStringDifficulty.ToString
        If DifficultyValue = False Then
            TaxesLabel.Text = "15%"
        Else
            TaxesLabel.Text = "35%"
        End If
    End Sub
    Private Sub StartThroughContinue()
        'Checks if the game is being loaded through Continue.
        GetPrivateProfileString("Stats", "LoadGameStatsOnStartup", "", IniStringContinueGame, IniStringContinueGame.Capacity, GameStatsIni)
        If IniStringContinueGame.ToString = "True" Then
            RefreshValuesFromIni()
            WritePrivateProfileString("Stats", "LoadGameStatsOnStartup", "False", GameStatsIni)
        End If
    End Sub
    Private Function CheckFailure()
        If MPInfoLabel.Text < 0 Or RationInfoLabel.Text < 0 Or FinanceInfoLabel.Text < 0 Then
            Return True
        Else
            Return False
            GameOver = False
            WritePrivateProfileString("Stats", "IsGameOver", GameOver, GameStatsIni)
        End If
    End Function
    Private Sub DecreeGameOver()
        HistoryLog.AppendText(Environment.NewLine)
        HistoryLog.AppendText(Environment.NewLine + "The High Command of the US Army has noticed the sheer incompetence in the management of the Camp, and has decided to exonerate you from office.")
        HistoryLog.AppendText(Environment.NewLine + "Game Over! You may now choose between loading a previous session, or starting a new game.")

        NextWeekButton.Hide()
        PolicyButton.Hide()

        GameOver = True
        WritePrivateProfileString("Stats", "IsGameOver", GameOver, GameStatsIni)
    End Sub
    Private Function StartPurchase(SoldResource As String, ReceivedResource As String)
        'The resource which will be sold. 
        'If the sold resource is Money, trade Money for the resource-to-be-received (second arg on this function)
        Select Case SoldResource
            Case "Wood"
                WoodInfoLabel.Text = WoodInfoLabel.Text - 10
                FinanceInfoLabel.Text = FinanceInfoLabel.Text + 10
            Case "Water"
                WaterInfoLabel.Text = WaterInfoLabel.Text - 10
                FinanceInfoLabel.Text = FinanceInfoLabel.Text + 5
            Case "Food"
                RationInfoLabel.Text = RationInfoLabel.Text - 10
                FinanceInfoLabel.Text = FinanceInfoLabel.Text + 3
            Case "Money"
                If ReceivedResource = "Wood" Then
                    FinanceInfoLabel.Text = FinanceInfoLabel.Text - 20
                    WoodInfoLabel.Text = WoodInfoLabel.Text + 10
                End If
                If ReceivedResource = "Water" Then
                    FinanceInfoLabel.Text = FinanceInfoLabel.Text - 10
                    WaterInfoLabel.Text = WaterInfoLabel.Text + 10
                End If
                If ReceivedResource = "Food" Then
                    FinanceInfoLabel.Text = FinanceInfoLabel.Text - 5
                    RationInfoLabel.Text = RationInfoLabel.Text + 10
                End If
        End Select

        If CheckFailure() = True Then
            DecreeGameOver()
        Else
            HistoryLog.AppendText(Environment.NewLine + "You have successfully completed a market transaction.")
        End If

    End Function
    Private Sub BuyWoodLabel_Click(sender As Object, e As EventArgs) Handles BuyWoodLabel.Click
        StartPurchase("Money", "Wood")
    End Sub
    Private Sub BuyWaterLabel_Click(sender As Object, e As EventArgs) Handles BuyWaterLabel.Click
        StartPurchase("Money", "Water")
    End Sub
    Private Sub BuyFoodLabel_Click(sender As Object, e As EventArgs) Handles BuyFoodLabel.Click
        StartPurchase("Money", "Food")
    End Sub
    Private Sub SellWoodLabel_Click(sender As Object, e As EventArgs) Handles SellWoodLabel.Click
        StartPurchase("Wood", "Money")
    End Sub
    Private Sub SellWaterLabel_Click(sender As Object, e As EventArgs) Handles SellWaterLabel.Click
        StartPurchase("Water", "Money")
    End Sub
    Private Sub SellFoodLabel_Click(sender As Object, e As EventArgs) Handles SellFoodLabel.Click
        StartPurchase("Food", "Money")
    End Sub
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If InvokeRequired = True Then
            Invoke(New SaveValuesToIniDelegate(AddressOf SaveValuesToIni))
        Else
            SaveValuesToIni()
        End If
    End Sub
    Private Sub LoadButton_Click(sender As Object, e As EventArgs) Handles LoadButton.Click
        If InvokeRequired = True Then
            Invoke(New SaveValuesToIniDelegate(AddressOf RefreshValuesFromIni))
        Else
            RefreshValuesFromIni()
        End If
    End Sub
    Private Sub SaveValuesToIni()
        Try
            If InvokeRequired = True Then
                Invoke(New SaveValuesToIniDelegate(AddressOf SaveValuesToIniDelegated))
            Else
                SaveValuesToIniDelegated()
            End If
        Catch ex As Exception
            MsgBox("Failed to delegate saving to UI Thread.", MsgBoxStyle.Critical)
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub SaveValuesToIniDelegated()
        Try
            WritePrivateProfileString("Stats", "Ration", RationInfoLabel.Text, GameStatsIni)
            WritePrivateProfileString("Stats", "Water", WaterInfoLabel.Text, GameStatsIni)
            WritePrivateProfileString("Stats", "Money", FinanceInfoLabel.Text, GameStatsIni)
            WritePrivateProfileString("Stats", "Wood", WoodInfoLabel.Text, GameStatsIni)
            WritePrivateProfileString("Stats", "ManpowerForce", MPInfoLabel.Text, GameStatsIni)
            WritePrivateProfileString("Stats", "CurrentYear", YearLabel.Text, GameStatsIni)
            WritePrivateProfileString("Stats", "CurrentMonth", MonthLabel.Text, GameStatsIni)
            WritePrivateProfileString("Stats", "CurrentDay", DayLabel.Text, GameStatsIni)


            'Writes GameOver state to savefile.
            WritePrivateProfileString("Stats", "IsGameOver", GameOver, GameStatsIni)

            HistoryLog.AppendText(Environment.NewLine + "Your current session has been saved.")
        Catch ex As Exception
            MsgBox("Failed to use delegate to save with UI Thread.", MsgBoxStyle.Critical)
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub RefreshValuesFromIni()
        Try
            If InvokeRequired = True Then
                Invoke(New RefreshValuesFromIniDelegate(AddressOf RefreshValuesFromIniDelegated))
            Else
                RefreshValuesFromIniDelegated()
            End If
        Catch ex As Exception
            MsgBox("Failed to delegate loading to UI Thread.", MsgBoxStyle.Critical)
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub RefreshValuesFromIniDelegated()
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
            MonthLabel.Text = Mechanics.GetMonth(IniString.ToString)
            GetPrivateProfileString("Stats", "CurrentDay", "", IniString, IniString.Capacity, GameStatsIni)
            DayLabel.Text = IniString.ToString


            'Checks if savefile is set in GameOver state.
            GetPrivateProfileString("Stats", "IsGameOver", "", IniString, IniString.Capacity, GameStatsIni)
            GameOver = Convert.ToBoolean(IniString.ToString)

            HistoryLog.AppendText(Environment.NewLine + "Your previous session has been loaded.")
        Catch ex As Exception
            MsgBox("Failed to use delegate to load with UI Thread.", MsgBoxStyle.Critical)
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles NextWeekButton.Click
        PlayerWealth = Convert.ToDouble(FinanceInfoLabel.Text)
        TotalWorkforce = Convert.ToDouble(MPInfoLabel.Text)

        If DayLabel.Text + 7 > 30 Then
            DayLabel.Text = DayLabel.Text + 7 - 30
            Month = Month + 1
        Else
            DayLabel.Text = DayLabel.Text + 7
        End If

        If Not Month = 13 Then
            MonthLabel.Text = Mechanics.GetMonth(Month)
        Else
            'Updates the money on the UI with the new value after inflation is applied.
            FinanceInfoLabel.Text = Mechanics.Inflation(PlayerWealth)
            PlayerWealth = FinanceInfoLabel.Text
            HistoryLog.AppendText(Environment.NewLine + "Your finances manager has received the updated inflation index, and updated your treasury.")

            LostToTaxesAndMoneyTaxesApplied = Mechanics.Taxes(PlayerWealth)
            FinanceInfoLabel.Text = LostToTaxesAndMoneyTaxesApplied(0)
            LostToTaxes = LostToTaxesAndMoneyTaxesApplied(1)
            HistoryLog.AppendText(Environment.NewLine + "You receive a letter notifying you of a High Command tax which takes effect immediately. The treasury has been debted in $" + LostToTaxes.ToString)
            Month = 1
            MonthLabel.Text = Mechanics.GetMonth(Month)
            YearLabel.Text = YearLabel.Text + 1
        End If

        HistoryLog.AppendText(Environment.NewLine + "Another week in office has passed.. Today is " + DayLabel.Text + " of " + MonthLabel.Text)



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

            'Vanilla Rates
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

        NewPlayerWealthAfterWorkForceProfits = Resources.WorkForceGenerateProfits(PlayerWealth, TotalWorkforce)
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


        'Checks what will be the new values to handle worker numbers, if extra policies were issued.
        If CampManagementPoliciesForm.RequestPrisoner = True Then
                CampManagementPoliciesForm.RequestPrisoner = False
                MPInfoLabel.Text = MPInfoLabel.Text + 5
                FinanceInfoLabel.Text = FinanceInfoLabel.Text - 20
                HistoryLog.AppendText(Environment.NewLine + "A military truck has just arrived, with 5 new POWs. For this extra shipment, High Command charged you $20")
            End If
            If CampManagementPoliciesForm.ExecutePrisoners = True Then
                CampManagementPoliciesForm.ExecutePrisoners = False
                MPInfoLabel.Text = MPInfoLabel.Text - 5
                FinanceInfoLabel.Text = FinanceInfoLabel.Text + 20
                HistoryLog.AppendText(Environment.NewLine + "A military truck has just left the camp with 5 dead POWs. For taking care of german conscripts, High Command awarded you $20")
            End If

    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitButton.Click
        Close()
    End Sub

    Private Sub PolicyButton_Click(sender As Object, e As EventArgs) Handles PolicyButton.Click
        CampManagementPoliciesForm.Show()
    End Sub
End Class