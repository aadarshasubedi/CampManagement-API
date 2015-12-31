Imports TheckStudios_Management_Sim_API_2015
Public Class CampManagement
    'Month must be declared Class-wise to make sure all subs and functions can access it.
    Dim Month = "1"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Adds 7 days to the days counter
        DayLabel.Text = DayLabel.Text + 7
        'If we add over 30 days, correct it and increase Month by 1(Jump to the next month)
        If DayLabel.Text > 30 Then
            Month = Month + 1
            'Example: If day is 36, 36 - 30 = 6. Day 6, then.
            DayLabel.Text = DayLabel.Text - 30
            'This increases the year factor if the month counter breaks 12.
            If Month = 13 Then
                Month = 1
                YearLabel.Text = YearLabel.Text + 1
                'Resets back to january.
                MonthLabel.Text = "January"
                If My.Settings.Difficulty = "0" Then
                    Mechanics.EasyInflation()
                    HistoryLog.AppendText(Environment.NewLine + "Your treasury master comes running to your office to warn you that inflation destroyed a good portion of your money.")
                    Mechanics.EasyTaxes()
                    'Reads TaxInfo to know how much will be debted
                    Dim TaxToBeDebted = My.Computer.FileSystem.ReadAllText(Environment.CurrentDirectory + "/Data/TaxInfo.txt")
                    HistoryLog.AppendText(Environment.NewLine + "The local government requires payment of taxes." + "$" + TaxToBeDebted + " will be taken from your treasury")

                Else
                    Mechanics.HardInflation()
                    HistoryLog.AppendText(Environment.NewLine + "Your treasury master kicks the door open and, yelling, tells you that inflation has taken most of your money.")
                    Mechanics.HardTaxes()
                    Dim TaxToBeDebted = My.Computer.FileSystem.ReadAllText(Environment.CurrentDirectory + "/Data/TaxInfo.txt")
                    HistoryLog.AppendText(Environment.NewLine + "The local government requires payment of taxes." + "$" + TaxToBeDebted + " will be taken from your treasury")
                End If
            End If
        End If

        'Every month (defined above) will increase the variable Month by 1. If Month been increased to 2, It will be February. And so on.
        If Month = 1 Then
            MonthLabel.Text = "January"
        End If
        If Month = 2 Then
            MonthLabel.Text = "February"
        End If
        If Month = 3 Then
            MonthLabel.Text = "March"
        End If
        If Month = 4 Then
            MonthLabel.Text = "April"
        End If
        If Month = 5 Then
            MonthLabel.Text = "May"
        End If
        If Month = 6 Then
            MonthLabel.Text = "June"
        End If
        If Month = 7 Then
            MonthLabel.Text = "July"
        End If
        If Month = 8 Then
            MonthLabel.Text = "August"
        End If
        If Month = 9 Then
            MonthLabel.Text = "September"
        End If
        If Month = 10 Then
            MonthLabel.Text = "October"
        End If
        If Month = 11 Then
            MonthLabel.Text = "November"
        End If
        If Month = 12 Then
            MonthLabel.Text = "December"
        End If
        HistoryLog.AppendText(Environment.NewLine + "You come back to your camp to check how it is going. It is " + DayLabel.Text + "th of " + MonthLabel.Text)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'This timer ensures that all values are synced with the information the API is returning to these files.
        ' That is, every time you call a function, it may modify these files, and thus, you need to keep them synced.
        FinanceInfoLabel.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "/Data/FinanceInfo.txt")
        RationInfoLabel.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "/Data/FoodInfo.txt")
        WoodInfoLabel.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "/Data/WoodInfo.txt")
        MPInfoLabel.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "/Data/MPInfo.txt")

        Timer2.Enabled = True
        Timer2.Start()
        Timer1.Stop()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If YearLabel.Text = "1950" Then
            MsgBox("You won! Congratulations!")
            HistoryLog.Text = HistoryLog.Text + Environment.NewLine + "You beat the game! The soldiers were acquitted from the Nuremberg Trials and you are free to go home."
            My.Settings.Save()
            Timer2.Enabled = False
            Timer1.Stop()

        End If
        Timer1.Start()
        Timer2.Stop()

    End Sub
End Class
