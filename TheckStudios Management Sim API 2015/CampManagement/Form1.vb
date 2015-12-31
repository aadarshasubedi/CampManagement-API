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


    End Sub
End Class
