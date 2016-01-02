Imports System.IO

Public Class Resources
    'Gets current directory and stores into object, as to not request it everytime.
    Friend Shared MyLocation = Environment.CurrentDirectory
    'This is necessary to save on disk how much wood the player now has.
    Friend Shared WoodAmountPath As String = MyLocation + "/Data/WoodInfo.txt"
    'This is necessary to save on the disk how much workers the player now has.
    Friend Shared WorkerAmountPath As String = MyLocation + "/Data/MPInfo.txt"
    'This is necessary to find out how much workers the player has.
    Friend Shared WorkerAmount As String = My.Computer.FileSystem.ReadAllText(WorkerAmountPath)
    'This is necessary to know where the difficulty settings are.
    Friend Shared DifficultyPath As String = MyLocation + "/Data/DifficultyInfo.txt"
    'This is necessary to know what difficulty the player is playing on.
    Friend Shared DifficultySettings As String = My.Computer.FileSystem.ReadAllText(DifficultyPath)
    'This is necessary to save/read on the disk how much money the player now has.
    Private Shared PlayerWealthPath As String = MyLocation + "/Data/FinanceInfo.txt"
    'Other variables. self-explanatory
    Private Shared PlayerWealth, NewPlayerWealth, WorkForceGenerateProfitResult As String

    'Uses consts instead of static doubles
    Const EasyProfitPerWorkForceUnit As Double = 1.25
    Const HardProfitPerWorkForceUnit As Double = 1.1

    'Opens Streamwriters
    Public Shared WriteToMPInfo As StreamWriter
    Public Shared WriteToFinanceInfo As StreamWriter

    Public Shared Sub Wood()
        ' Coming soon
    End Sub
    Public Shared Sub Water()
        ' Coming soon
    End Sub
    Public Shared Sub WorkForceGenerateProfits()
        'This is used to calculate profits from manpower (prisoners, workers, and others)
        Try
            If DifficultySettings = 0 Then
                EasyWPProfits()
            Else
                HardWPProfits()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Failed to call MP Profits! Files must be missing from the Data folder!")
        End Try
    End Sub
    Private Shared Sub EasyWPProfits()
        'Profit = How Many Workers The Player Has * Profit Per Worker based on Difficulty
        WorkForceGenerateProfitResult = WorkerAmount * EasyProfitPerWorkForceUnit
        'Finds how much money the player has on call-time to make sure the amount of money is not outdated.
        PlayerWealth = My.Computer.FileSystem.ReadAllText(PlayerWealthPath)
        'PlayersMoney = Profit calculated above + old money quantity (as to not overwrite the money)
        NewPlayerWealth = WorkForceGenerateProfitResult + PlayerWealth

        'Write to disk the new player information.
        WriteToFinanceInfo = My.Computer.FileSystem.OpenTextFileWriter(PlayerWealthPath, False)
        WriteToFinanceInfo.WriteLine(NewPlayerWealth)
        WriteToFinanceInfo.Close()

    End Sub
    Private Shared Sub HardWPProfits()
        'Profit = How Many Workers The Player Has * Profit Per Worker based on Difficulty
        WorkForceGenerateProfitResult = WorkerAmount * HardProfitPerWorkForceUnit
        'Finds how much money the player has on call-time to make sure the amount of money is not outdated.
        PlayerWealth = My.Computer.FileSystem.ReadAllText(PlayerWealthPath)
        'PlayersMoney = Profit calculated above + old money quantity (as to not overwrite the money)
        NewPlayerWealth = WorkForceGenerateProfitResult + PlayerWealth

        'Write to disk the new player information.
        WriteToFinanceInfo = My.Computer.FileSystem.OpenTextFileWriter(PlayerWealthPath, False)
        WriteToFinanceInfo.WriteLine(NewPlayerWealth)
        WriteToFinanceInfo.Close()

    End Sub
End Class
Public Class Mechanics
    'This is necessary to know where the difficulty settings are.
    Private Shared DifficultyPath As String = Resources.MyLocation + "/Data/DifficultyInfo.txt"
    'This is necessary to know what difficulty the player is playing on.
    Private Shared DifficultySettings As String = My.Computer.FileSystem.ReadAllText(DifficultyPath)
    'Other variables. self-explanatory
    Private Shared NewPlayerWealth, TaxTotal, InflationCalculus, InflationDifference As String
    'WriteToDisk
    Public Shared WriteToDifficultyInfo As StreamWriter

    'Uses consts instead of static doubles
    Const Zero As Double = 0
    Const One As Double = 1

    Const EasyTaxesPercentage As Double = 0.85
    Const HardTaxesPercentage As Double = 0.65
    Const EasyInflationPercentage25000 As Double = 0.89
    Const EasyInflationPercentage5000 As Double = 0.93
    Const EasyInflationPercentage2500 As Double = 0.98
    Const HardInflationPercentage25000 As Double = 0.75
    Const HardInflationPercentage5000 As Double = 0.8
    Const HardInflationPercentage2500 As Double = 0.85

    Const InflationPlayerWealth25000 As Double = 25000
    Const InflationPlayerWealth5000 As Double = 5000
    Const InflationPlayerWealth2500 As Double = 2500
    Public Shared Function Taxes(PlayerWealth As Double) As Double()

        'Checks what difficulty the player is playing with, and calls the correct taxes.
        If My.Computer.FileSystem.ReadAllText(DifficultyPath) = Zero Then
            EasyTax(PlayerWealth)
            Return EasyTax(PlayerWealth)
        Else
            HardTax(PlayerWealth)
            Return HardTax(PlayerWealth)
        End If

    End Function
    Private Shared Function EasyTax(PlayerWealth As Double) As Double()
        Try
            'For easy difficulty: enforces 15% of taxes
            'This is necessary to know how much money the player has.
            NewPlayerWealth = PlayerWealth * EasyTaxesPercentage
            TaxTotal = PlayerWealth - NewPlayerWealth

            'Returns the new player money and how much was charged
            Return {NewPlayerWealth, TaxTotal}

        Catch EasyTaxesException As Exception
            MsgBox(EasyTaxesException.ToString)
            MsgBox("Failed To Call taxes! Files must be missing from the Data folder!")
        End Try
    End Function
    Private Shared Function HardTax(PlayerWealth As Double) As Double()
        Try
            'For hard difficulty: enforces 35% of taxes
            'This calculates how much money the player has after being charged taxes.
            NewPlayerWealth = PlayerWealth * HardTaxesPercentage
            TaxTotal = PlayerWealth - NewPlayerWealth

            'Returns the new player money and how much was charged
            Return {NewPlayerWealth, TaxTotal}

        Catch HardTaxesException As Exception
            MsgBox(HardTaxesException.ToString)
            MsgBox("Failed To Call taxes! Files must be missing from the Data folder!")
        End Try
    End Function
    Public Shared Function Inflation(PlayerWealth As Double) As Double
        'Checks what difficulty the player is playing with, and calls the correct inflation.
        If DifficultySettings = 0 Then
            EasyInflation(PlayerWealth)
            Return EasyInflation(PlayerWealth)
        Else
            HardInflation(PlayerWealth)
            Return EasyInflation(PlayerWealth)
        End If
    End Function
    Private Shared Function EasyInflation(PlayerWealth As Double) As Double
        Try
            'If the player has too much money, inflation will be more punishing
            If PlayerWealth > InflationPlayerWealth25000 Then
                InflationCalculus = EasyInflationPercentage25000
                InflationDifference = PlayerWealth * InflationCalculus

                Return InflationDifference

            End If
            'If the player has a bit of money, inflation will be less punishing.
            If PlayerWealth < InflationPlayerWealth5000 And PlayerWealth > InflationPlayerWealth2500 Then
                InflationCalculus = EasyInflationPercentage5000
                InflationDifference = PlayerWealth * InflationCalculus

                Return InflationDifference

            End If
            'If the player has a bit of money, inflation will be less punishing.
            If PlayerWealth < InflationPlayerWealth2500 Then
                InflationCalculus = EasyInflationPercentage2500
                InflationDifference = PlayerWealth * InflationCalculus

                Return InflationDifference

            End If

        Catch EasyInflationException As Exception
            'If any problems happen while calling Inflation (Usually lacking files), state it to the end-user.
            MsgBox(EasyInflationException.ToString)
            MsgBox("Failed To Call Inflation! Files must be missing from the Data folder!")
        End Try
    End Function
    Private Shared Function HardInflation(PlayerWealth As Double) As Double
        Try

            'If the player has too much money, inflation will be more punishing
            If PlayerWealth > InflationPlayerWealth25000 Then
                InflationCalculus = HardInflationPercentage25000
                InflationDifference = PlayerWealth * InflationCalculus

                Return InflationDifference

            End If
            'If the player has a bit of money, inflation will be less punishing.
            If PlayerWealth < InflationPlayerWealth5000 And PlayerWealth > InflationPlayerWealth2500 Then
                InflationCalculus = HardInflationPercentage5000
                InflationDifference = PlayerWealth * InflationCalculus

                Return InflationDifference

            End If
            'If the player has a bit of money, inflation will be less punishing.
            If PlayerWealth < InflationPlayerWealth2500 Then
                InflationCalculus = HardInflationPercentage2500
                InflationDifference = PlayerWealth * InflationCalculus

                Return InflationDifference

            End If

        Catch HardInflationException As Exception
            'If any problems happen while calling Inflation (Usually lacking files), state it to the end-user.
            MsgBox(HardInflationException.ToString)
            MsgBox("Failed To Call Inflation! Files must be missing from the Data folder!")
        End Try

    End Function

    Public Shared Sub SetDifficultyEasy()
        WriteToDifficultyInfo = My.Computer.FileSystem.OpenTextFileWriter(DifficultyPath, False)
        WriteToDifficultyInfo.WriteLine(Zero.ToString)
        WriteToDifficultyInfo.Close()
    End Sub
    Public Shared Sub SetDifficultyHard()
        WriteToDifficultyInfo = My.Computer.FileSystem.OpenTextFileWriter(DifficultyPath, False)
        WriteToDifficultyInfo.WriteLine(One.ToString)
        WriteToDifficultyInfo.Close()
    End Sub
End Class
Public Class Misc

End Class