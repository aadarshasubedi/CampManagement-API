Imports TheckStudios_Management_Sim_API_2015
Public Class Form1
    Dim Month = "1"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Label14.Text = Label14.Text + 7
        If Label14.Text > 30 Then
            Month = Month + 1
            Label14.Text = Label14.Text - 30
            If Month = 13 Then
                Month = 1
                Label12.Text = Label12.Text + 1
                Label13.Text = "January"
            End If
        End If

        If Month = 1 Then
            Label13.Text = "January"
        End If
        If Month = 2 Then
            Label13.Text = "February"
        End If
        If Month = 3 Then
            Label13.Text = "March"
        End If
        If Month = 4 Then
            Label13.Text = "April"
        End If
        If Month = 5 Then
            Label13.Text = "May"
        End If
        If Month = 6 Then
            Label13.Text = "June"
        End If
        If Month = 7 Then
            Label13.Text = "July"
        End If
        If Month = 8 Then
            Label13.Text = "August"
        End If
        If Month = 9 Then
            Label13.Text = "September"
        End If
        If Month = 10 Then
            Label13.Text = "October"
        End If
        If Month = 11 Then
            Label13.Text = "November"
        End If
        If Month = 12 Then
            Label13.Text = "December"
        End If
        TextBox1.Text = TextBox1.Text + Environment.NewLine + "You come back to your camp to check how it is going. It is " + Label14.Text + "th of " + Label13.Text

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'This timer ensures that all values are synced with the information the API is returning to these files.
        ' That is, every time you call a function, it may modify these files, and thus, you need to keep them synced.
        Label5.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "/Data/FinanceInfo.txt")
        Label6.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "/Data/FoodInfo.txt")
        Label7.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "/Data/WoodInfo.txt")
        Label8.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "/Data/MPInfo.txt")

        Timer2.Enabled = True
        Timer2.start
        Timer1.Stop()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Label12.Text = "1950" Then
            MsgBox("You won! Congratulations!")
            TextBox1.Text = TextBox1.Text + Environment.NewLine + "You beat the game! The soldiers were acquitted from the Nuremberg Trials and you are free to go home."
            My.Settings.Save()
            Timer2.Enabled = False
            Timer1.Stop()

        End If
        Timer1.Start()
        Timer2.Stop()

    End Sub
End Class
