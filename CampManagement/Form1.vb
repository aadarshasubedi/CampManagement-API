Imports TheckStudios_Management_Sim_API_2016
Imports System.Runtime.InteropServices
Imports System.Text
Public Class CampManagement
    'Month must be declared Class-wise to make sure all subs and functions can access it.
    Public Month = 1
    Public MoneyInflationApplied, LostToTaxes, MoneyTaxesApplied, LostToTaxesAndMoneyTaxesApplied
    Public PlayerWealth As Double
    Public IniString As StringBuilder
    Public IniFile = Application.StartupPath + "/Data/GameStats.ini"

    Private Declare Auto Function GetPrivateProfileString Lib "kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Private Declare Auto Function WritePrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PlayerWealth = Convert.ToDouble(FinanceInfoLabel.Text)
        Try
            'DayLabel.text = currentday
            'If CurrentDay + 7 > 30 then
            If Mechanics.GetDay(DayLabel.Text) > 30 Then
                'CurrentDay = CurrentDay + 7 - 30 (To make sure it doesn't go above 30 days!)
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
            'If the month isn't Month 13, continue as normal
            If Not Month = 13 Then
                MonthLabel.Text = Mechanics.GetMonth(Month)
            Else 'If we hit month 13 (which does not exist), reset year count and call taxes and inflation.
                MoneyInflationApplied = Mechanics.Inflation(PlayerWealth)
                HistoryLog.AppendText(Environment.NewLine + "Your treasury master comes running to your office to warn you that inflation destroyed a good portion of your money.")
                LostToTaxesAndMoneyTaxesApplied = Mechanics.Taxes(PlayerWealth)
                MoneyTaxesApplied = LostToTaxesAndMoneyTaxesApplied(0)
                LostToTaxes = LostToTaxesAndMoneyTaxesApplied(1)
                HistoryLog.AppendText(Environment.NewLine + "The local government requires payment of taxes. You lost the following: $" + LostToTaxes.ToString)
                Month = 1
                MonthLabel.Text = Mechanics.GetMonth(Month)
                YearLabel.Text = YearLabel.Text + 1
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Failed to increase month count or call Inflation/Taxes")
        End Try

        HistoryLog.AppendText(Environment.NewLine + "You come back to your camp to check how it is going. It is " + DayLabel.Text + "th of " + MonthLabel.Text)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            '  FinanceInfoLabel.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "/Data/FinanceInfo.txt")
            '   RationInfoLabel.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "/Data/FoodInfo.txt")
            '   WoodInfoLabel.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "/Data/WoodInfo.txt")
            '   MPInfoLabel.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "/Data/MPInfo.txt")

            'If difficulty is set to 1 (Hard), then show 35% as the taxes on the UI
            If My.Computer.FileSystem.ReadAllText(Application.StartupPath + "/Data/DifficultyInfo.txt") = 1 Then
                TaxesLabel.Text = "35%"
            Else
                TaxesLabel.Text = "15%"
            End If

            Timer2.Enabled = True
            Timer2.Start()
            Timer1.Stop()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Information synchronizer has crashed.")
        End Try

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If YearLabel.Text = "1950" Then
            HistoryLog.AppendText("You beat the game! The POWs were acquitted from the Nuremberg Trials, and their officers punished by death sentence. The Allied High Command sends you a letter to leave Germany and retire. It is all over..")
            My.Settings.Save()
            Timer2.Enabled = False
            Timer1.Stop()
        Else
            Timer1.Start()
            Timer2.Stop()
        End If

    End Sub
End Class