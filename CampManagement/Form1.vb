Imports TheckStudios_Management_Sim_API_2016
Imports System.Text
Public Class CampManagement
    'Month must be declared Class-wise to make sure all subs and functions can access it.
    Public Month = 1
    Public LostToTaxes, MoneyTaxesApplied, LostToTaxesAndMoneyTaxesApplied
    Public PlayerWealth As Double
    Public IniString = New StringBuilder(500)
    Public IniFile = Application.StartupPath + "/Data/GameStats.ini"

    Private Declare Auto Function GetPrivateProfileString Lib "kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Private Declare Auto Function WritePrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer
    Private Function SaveValuesToIni()
        Try
            MsgBox("You can't save values to the .ini yet.")
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Information synchronizer has crashed.")
        End Try
    End Function
    Private Function RefreshValuesFromIni()
        Try
            GetPrivateProfileString("Stats", "Wood", "", IniString, IniString.Capacity, Application.StartupPath + "/Data/GameStats.ini")
            WoodInfoLabel.Text = IniString.ToString
            GetPrivateProfileString("Stats", "Water", "", IniString, IniString.Capacity, Application.StartupPath + "/Data/GameStats.ini")
            WaterInfoLabel.Text = IniString.ToString
            GetPrivateProfileString("Stats", "Money", "", IniString, IniString.Capacity, Application.StartupPath + "/Data/GameStats.ini")
            FinanceInfoLabel.Text = IniString.ToString
            GetPrivateProfileString("Stats", "Ration", "", IniString, IniString.Capacity, Application.StartupPath + "/Data/GameStats.ini")
            RationInfoLabel.Text = IniString.ToString
            GetPrivateProfileString("Stats", "ManpowerForce", "", IniString, IniString.Capacity, Application.StartupPath + "/Data/GameStats.ini")
            MPInfoLabel.Text = IniString.ToString

            MsgBox("Game Information loaded from GameStats.ini")
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Information synchronizer has crashed.")
        End Try
    End Function
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
    Private Sub CampManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If GetPrivateProfileString("Stats", "Difficulty", "", IniString, IniString.Capacity, Application.StartupPath + "/Data/GameStats.ini") = 0 Then
            TaxesLabel.Text = "15%"
        Else
            TaxesLabel.Text = "35%"
        End If
    End Sub
End Class