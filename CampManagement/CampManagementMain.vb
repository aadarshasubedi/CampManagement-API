Imports TheckStudios_Management_Sim_API_2016
Imports System.Text
Public Class CampManagementMain
    'Declares StringBuilders for .INI reading
    Private IniString = New StringBuilder(500)
    Private IniStringDifficulty = New StringBuilder(500)
    Private IniStringIsModEnabled = New StringBuilder(500)
    Private IniStringLoadGameStatsOnStartup = New StringBuilder(500)

    'Declares variables, self-explanatory
    Private Month = 1
    Private WhichModFile, WhichMod, ModuleDetector, LostToTaxes, MoneyTaxesApplied, LostToTaxesAndMoneyTaxesApplied, DifficultySettingsFromINI
    Private PlayerWealth As Double
    'CurrentDirectory = Current Directory location
    Private CurrentDirectory = Environment.CurrentDirectory
    'GameModuleData = Modules Folder location
    Private GameModuleData = CurrentDirectory + "/Data/DLC_Modules/"
    Private GameStatsIni = CurrentDirectory + "/Data/GameStats.ini"

    Friend DifficultyValue = GetPrivateProfileString("Stats", "Difficulty", "", IniStringDifficulty, IniStringDifficulty.Capacity, GameStatsIni)
    Friend IsModEnabled = GetPrivateProfileString("Stats", "IsModEnabled", "", IniStringIsModEnabled, IniStringIsModEnabled.Capacity, GameStatsIni)
    Friend LoadGameStatsOnStartup = GetPrivateProfileString("Stats", "LoadGameStatsOnStartup", "", IniStringLoadGameStatsOnStartup, IniStringLoadGameStatsOnStartup.Capacity, GameStatsIni)

    'Yes, this is heresy, but I like it :(
    Const Zero As Double = 0
    Const One As Double = 1

    Private Declare Auto Function GetPrivateProfileString Lib "kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Private Declare Auto Function WritePrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer
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
        PlayerWealth = Convert.ToDouble(FinanceInfoLabel.Text)
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

        Try
            If Not Month = 13 Then
                MonthLabel.Text = Mechanics.GetMonth(Month)
            Else
                'Updates the money on the UI with the new value after inflation is applied.
                FinanceInfoLabel.Text = Mechanics.Inflation(PlayerWealth)
                PlayerWealth = FinanceInfoLabel.Text
                HistoryLog.AppendText(Environment.NewLine + "Your treasury master comes running to your office to warn you that inflation has destroyed a good portion of your money.")

                LostToTaxesAndMoneyTaxesApplied = Mechanics.Taxes(PlayerWealth)
                FinanceInfoLabel.Text = LostToTaxesAndMoneyTaxesApplied(0)
                LostToTaxes = LostToTaxesAndMoneyTaxesApplied(1)

                HistoryLog.AppendText(Environment.NewLine + "The local government requires payment of taxes. You lost the following: $" + LostToTaxes.ToString)
                Month = 1
                MonthLabel.Text = Mechanics.GetMonth(Month)
                YearLabel.Text = YearLabel.Text + 1
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Failed to increase month count or call Inflation/Taxes", MsgBoxStyle.Critical)
        End Try

        HistoryLog.AppendText(Environment.NewLine + "You come back to your camp to check how it is going. It is " + DayLabel.Text + "th of " + MonthLabel.Text)

    End Sub
    Private Sub CampManagementMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If
                Else

        End If

        Try
            If DifficultyValue = Zero Then
                TaxesLabel.Text = "15%"
            Else
                TaxesLabel.Text = "35%"
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Failed to define taxes information on UI")
        End Try


        Try
            If IsModEnabled.ToString = "False" Then

            Else


            End If
        Catch ex As Exception

        End Try


    End Sub
End Class