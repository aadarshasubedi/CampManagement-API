Public Class CampManagementPoliciesForm
    Public Shared ExhaustionPolicy, EasierWorkPolicy, FourMealsPolicy, EatAllYouCanPolicy, RequestPrisoner, ExecutePrisoners As Boolean

    Private Const WmNchittest As Integer = &H84
    Private Const Htclient As Integer = &H1
    Private Const Htcaption As Integer = &H2

    Public Sub EventHandler()
        AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf UnhandledExceptionEventRaised
        InitializeComponent()
    End Sub
    Sub UnhandledExceptionEventRaised(ByVal sender As Object, ByVal e As UnhandledExceptionEventArgs)
        If e.IsTerminating Then
            Dim crash As Object = e.ExceptionObject
            MessageBox.Show(crash.ToString)
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
        End
    End Sub
    Private Sub BackToGameButton_Click(sender As Object, e As EventArgs) Handles BackToGameButton.Click
        Me.Close()
    End Sub
    Private Sub ExhaustionPolicyCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ExhaustionPolicyCheckBox.CheckedChanged
        EasierWorkPolicyCheckBox.Checked = False
        ExhaustionPolicyCheckBox.Checked = True
        EasierWorkPolicy = False
        ExhaustionPolicy = True
    End Sub

    Private Sub EasierWorkPolicyCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles EasierWorkPolicyCheckBox.CheckedChanged
        ExhaustionPolicyCheckBox.Checked = False
        EasierWorkPolicyCheckBox.Checked = True
        EasierWorkPolicy = True
        ExhaustionPolicy = False
    End Sub

    Private Sub EatAllYouCanPolicyCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles EatAllYouCanPolicyCheckBox.CheckedChanged
        FourMealsPolicyCheckBox.Checked = False
        EatAllYouCanPolicyCheckBox.Checked = True
        EatAllYouCanPolicy = True
        FourMealsPolicy = False
    End Sub

    Private Sub FourMealsPolicyCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles FourMealsPolicyCheckBox.CheckedChanged
        EatAllYouCanPolicyCheckBox.Checked = False
        FourMealsPolicyCheckBox.Checked = True
        EatAllYouCanPolicy = False
        FourMealsPolicy = True
    End Sub
    Private Sub ExecutePrisonersCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ExecutePrisonersCheckBox.CheckedChanged
        RequestPrisonersCheckBox.Checked = False
        ExecutePrisoners = True
    End Sub
    Private Sub RequestPrisonersCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles RequestPrisonersCheckBox.CheckedChanged
        ExecutePrisonersCheckBox.Checked = False
        RequestPrisoner = True

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
        If RequestPrisoner = False Then
            RequestPrisonersCheckBox.Checked = False
        End If
        If ExecutePrisoners = False Then
            ExecutePrisonersCheckBox.Checked = False
        End If
    End Sub
End Class