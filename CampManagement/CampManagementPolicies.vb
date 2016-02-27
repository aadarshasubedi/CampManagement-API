Public Class CampManagementPoliciesForm
    Public Shared ExhaustionPolicy, EasierWorkPolicy, FourMealsPolicy, EatAllYouCanPolicy, RequestPrisoner, ExecutePrisoners As Boolean
    Private Sub BackToGameButton_Click(sender As Object, e As EventArgs) Handles BackToGameButton.Click
        Me.Close()
    End Sub
    Private Sub ExhaustionPolicyCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ExhaustionPolicyCheckBox.CheckedChanged
        EasierWorkPolicyCheckBox.Checked = False
        EasierWorkPolicy = False
        ExhaustionPolicy = True
    End Sub

    Private Sub EasierWorkPolicyCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles EasierWorkPolicyCheckBox.CheckedChanged
        ExhaustionPolicyCheckBox.Checked = False
        EasierWorkPolicy = True
        ExhaustionPolicy = False
    End Sub

    Private Sub EatAllYouCanPolicyCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles EatAllYouCanPolicyCheckBox.CheckedChanged
        FourMealsPolicyCheckBox.Checked = False
        EatAllYouCanPolicy = True
        FourMealsPolicy = False
    End Sub

    Private Sub FourMealsPolicyCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles FourMealsPolicyCheckBox.CheckedChanged
        EatAllYouCanPolicyCheckBox.Checked = False
        EatAllYouCanPolicy = False
        FourMealsPolicy = True
    End Sub
    Private Sub ExecutePrisonersCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ExecutePrisonersCheckBox.CheckedChanged
        RequestPrisonersCheckBox.Checked = False
    End Sub
    Private Sub RequestPrisonersCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles RequestPrisonersCheckBox.CheckedChanged
        ExecutePrisonersCheckBox.Checked = False
    End Sub
    Private Sub WorkToDeathInfo_Click(sender As Object, e As EventArgs) Handles WorkToDeathInfo.Click
        MsgBox("All profits from workforce receive a 1.25x multiplier, but 6 prisoners die per week.")
    End Sub

    Private Sub TenHourInfo_Click(sender As Object, e As EventArgs) Handles TenHourInfo.Click
        MsgBox("All profits from workforce receive a 1.15x multiplier, but 2 prisoners die per week")
    End Sub

    Private Sub EatAllYouWantInfo_Click(sender As Object, e As EventArgs) Handles EatAllYouWantInfo.Click
        MsgBox("All profits from workforce receive 1.25x multiplier, but you lose 5 rations per prisoner per week.")
    End Sub

    Private Sub FourMealsADayInfo_Click(sender As Object, e As EventArgs) Handles FourMealsADayInfo.Click
        MsgBox("All profits from workforce receive a 1.1x multiplier, but you lose 2 rations per prisoner per week")
    End Sub

    Private Sub KillPrisonersInfo_Click(sender As Object, e As EventArgs) Handles KillPrisonersInfo.Click
        MsgBox("Execute 5 prisoners, and receive a small boost ($20) to your finances.")
    End Sub

    Private Sub RequestPrisonersInfo_Click(sender As Object, e As EventArgs) Handles RequestPrisonersInfo.Click
        MsgBox("Request 5 prisoners, and pay a small sum ($20) from your finances.")
    End Sub

    Private Sub CampManagementPolicies_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class