Public Class CampManagementPolicies
    Private Sub BackToGameButton_Click(sender As Object, e As EventArgs) Handles BackToGameButton.Click
        CampManagementMain.Show()
    End Sub
    Private Sub ExhaustionPolicyCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ExhaustionPolicyCheckBox.CheckedChanged
        EasierWorkPolicyCheckBox.Checked = False
    End Sub

    Private Sub EasierWorkPolicyCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles EasierWorkPolicyCheckBox.CheckedChanged
        ExhaustionPolicyCheckBox.Checked = False
    End Sub

    Private Sub EatAllYouCanPolicyCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles EatAllYouCanPolicyCheckBox.CheckedChanged
        TwoMealsPolicyCheckBox.Checked = False
    End Sub

    Private Sub TwoMealsPolicyCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles TwoMealsPolicyCheckBox.CheckedChanged
        EatAllYouCanPolicyCheckBox.Checked = False
    End Sub
    Private Sub ExecutePrisonersCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ExecutePrisonersCheckBox.CheckedChanged
        RequestPrisonersCheckBox.Checked = False
    End Sub
    Private Sub RequestPrisonersCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles RequestPrisonersCheckBox.CheckedChanged
        ExecutePrisonersCheckBox.Checked = False
    End Sub
    Private Sub WorkToDeathInfo_Click(sender As Object, e As EventArgs) Handles WorkToDeathInfo.Click
        MsgBox("All profits from workforce receive a 2x multiplier, but 6 prisoners die per week.")
    End Sub

    Private Sub TenHourInfo_Click(sender As Object, e As EventArgs) Handles TenHourInfo.Click
        MsgBox("All profits from workforce receive a 1.33x multiplier, but 2 prisoners die per week")
    End Sub

    Private Sub EatAllYouWantInfo_Click(sender As Object, e As EventArgs) Handles EatAllYouWantInfo.Click
        MsgBox("All profits from workforce receive 1.33x multiplier, but you lose 5 rations per prisoner per week.")
    End Sub

    Private Sub FourMealsADayInfo_Click(sender As Object, e As EventArgs) Handles FourMealsADayInfo.Click
        MsgBox("All profits from workforce receive a 1.22x multiplier, but you lose 2 rations per prisoner per week")
    End Sub

    Private Sub KillPrisonersInfo_Click(sender As Object, e As EventArgs) Handles KillPrisonersInfo.Click
        MsgBox("Execute 5 prisoners, and receive a small boost to your finances (20 units).")
    End Sub

    Private Sub RequestPrisonersInfo_Click(sender As Object, e As EventArgs) Handles RequestPrisonersInfo.Click
        MsgBox("Request 5 prisoners, and pay a small sum from your finances (20 units).")
    End Sub
End Class