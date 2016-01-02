Imports System.IO

Public Class Resources
    'Gets current directory and stores into object, as to not request it everytime.
    Shared MyLocation = Environment.CurrentDirectory
    'This is necessary to save on disk how much wood the player now has.
    Private Shared WoodAmountPath As String = MyLocation + "/Data/WoodInfo.txt"
    'This is necessary to save on the disk how much workers the player now has.
    Private Shared WorkerAmountPath As String = MyLocation + "/Data/MPInfo.txt"
    'This is necessary to find out how much workers the player has.
    Private Shared WorkerAmount As String = My.Computer.FileSystem.ReadAllText(WorkerAmountPath)
    'This is necessary to know where the difficulty settings are.
    Private Shared DifficultyPath As String = MyLocation + "/Data/Difficulty.txt"
    'This is necessary to know what difficulty the player is playing on.
    Private Shared DifficultySettings As String = My.Computer.FileSystem.ReadAllText(DifficultyPath)
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
    'Gets current directory and stores into object, as to not request it everytime.
    Shared MyLocation = Environment.CurrentDirectory
    'This is necessary if the developer wishes to disclose how much was charged as taxes.
    Private Shared TaxInfo As String = MyLocation + "/Data/TaxInfo.txt"
    'This is necessary to know where the difficulty settings are.
    Private Shared DifficultyPath As String = MyLocation + "/Data/DifficultyInfo.txt"
    'This is necessary to know what difficulty the player is playing on.
    Private Shared DifficultySettings As String = My.Computer.FileSystem.ReadAllText(DifficultyPath)
    'This is necessary to save/read on the disk how much money the player now has.
    Private Shared PlayerWealthPath As String = MyLocation + "/Data/FinanceInfo.txt"
    'Other variables. self-explanatory
    Private Shared PlayerWealth, NewPlayerWealth, TaxTotal, InflationCalculus, InflationDifference As String


    'Uses consts instead of static doubles
    Const EasyTaxesPercentage As Double = 0.85
    Const HardTaxesPercentage As Double = 0.65
    Const EasyInflationPercentage25000 As Double = 0.89
    Const EasyInflationPercentage5000 As Double = 0.93
    Const EasyInflationPercentage2500 As Double = 0.98
    Const HardInflationPercentage25000 As Double = 0.75
    Const HardInflationPercentage5000 As Double = 0.8
    Const HardInflationPercentage2500 As Double = 0.85

    Const InflationPlayerWealth25000 As String = "25000"
    Const InflationPlayerWealth5000 As String = "5000"
    Const InflationPlayerWealth2500 As String = "2500"

    'Opens StreamWriters
    Public Shared WriteToDifficultyInfo As StreamWriter
    Public Shared WritetoGameInfo As StreamWriter
    Public Shared WriteToGameInfo2 As StreamWriter
    Public Shared WriteToFinanceInfo As StreamWriter
    Public Shared Sub Taxes()
        'Checks what difficulty the player is playing with, and calls the correct taxes.
        If My.Computer.FileSystem.ReadAllText(Environment.CurrentDirectory + "/Data/DifficultyInfo.txt") = 0 Then
            EasyTax()
        Else
            HardTax()
        End If
    End Sub
    Private Shared Sub EasyTax()
        Try
            'For easy difficulty: enforces 15% of taxes
            'This is necessary to know how much money the player has.
            PlayerWealth = My.Computer.FileSystem.ReadAllText(PlayerWealthPath)
            NewPlayerWealth = PlayerWealth * EasyTaxesPercentage
            TaxTotal = PlayerWealth - NewPlayerWealth

            'Write to disk the new playerwealth.
            WritetoGameInfo = My.Computer.FileSystem.OpenTextFileWriter(PlayerWealthPath, False)
            WritetoGameInfo.WriteLine(NewPlayerWealth)
            WritetoGameInfo.Close()

            'This is simply so the game knows how much tax were charged on player, if the developer wishes to disclose it..
            WriteToGameInfo2 = My.Computer.FileSystem.OpenTextFileWriter(TaxInfo, False)
            WriteToGameInfo2.WriteLine(TaxTotal)
            WriteToGameInfo2.Close()

        Catch EasyTaxesException As Exception
            'If any problems happen while calling taxes (Usually lacking files), state it to the end-user.
            MsgBox(EasyTaxesException.ToString)
            MsgBox("Failed to call taxes! Files must be missing from the Data folder!")
        End Try
    End Sub
    Private Shared Sub HardTax()
        Try
            'For hard difficulty: enforces 35% of Taxes.
            'This is necessary to know how much money the player has.
            PlayerWealth = My.Computer.FileSystem.ReadAllText(PlayerWealthPath)
            NewPlayerWealth = PlayerWealth * HardTaxesPercentage
            TaxTotal = PlayerWealth - NewPlayerWealth

            'Write to disk the new playerwealth.
            WritetoGameInfo = My.Computer.FileSystem.OpenTextFileWriter(PlayerWealthPath, False)
            WritetoGameInfo.WriteLine(NewPlayerWealth)
            WritetoGameInfo.Close()

            'This is simply so the game knows how much tax were charged on player, if the developer wishes to disclose it..
            WriteToGameInfo2 = My.Computer.FileSystem.OpenTextFileWriter(TaxInfo, False)
            WriteToGameInfo2.WriteLine(TaxTotal)
            WriteToGameInfo2.Close()

        Catch HardTaxesException As Exception
            'If any problems happen while calling taxes (Usually lacking files), state it to the end-user.
            MsgBox(HardTaxesException.ToString)
            MsgBox("Failed to call taxes! Files must be missing from the Data folder!")
        End Try
    End Sub
    Public Shared Sub Inflation()
        'Checks what difficulty the player is playing with, and calls the correct inflation.
        If DifficultySettings = 0 Then
            EasyInflation()
        Else
            HardInflation()
        End If
    End Sub
    Private Shared Sub EasyInflation()
        Try
            'This is necessary to know how much money the player has.
            PlayerWealth = My.Computer.FileSystem.ReadAllText(PlayerWealthPath)

            'If the player has too much money, inflation will be more punishing
            If PlayerWealth > InflationPlayerWealth25000 Then
                InflationCalculus = EasyInflationPercentage25000
                InflationDifference = PlayerWealth * InflationCalculus
                WriteToFinanceInfo = My.Computer.FileSystem.OpenTextFileWriter(PlayerWealthPath, False)
                WriteToFinanceInfo.WriteLine(InflationDifference)
                WriteToFinanceInfo.Close()
            End If
            'If the player has a bit of money, inflation will be less punishing.
            If PlayerWealth < InflationPlayerWealth5000 And PlayerWealth > InflationPlayerWealth2500 Then
                InflationCalculus = EasyInflationPercentage5000
                InflationDifference = PlayerWealth * InflationCalculus
                WriteToFinanceInfo = My.Computer.FileSystem.OpenTextFileWriter(PlayerWealthPath, False)
                WriteToFinanceInfo.WriteLine(InflationDifference)
                WriteToFinanceInfo.Close()
            End If
            'If the player has a bit of money, inflation will be less punishing.
            If PlayerWealth < InflationPlayerWealth2500 Then
                InflationCalculus = EasyInflationPercentage2500
                InflationDifference = PlayerWealth * InflationCalculus
                WriteToFinanceInfo = My.Computer.FileSystem.OpenTextFileWriter(PlayerWealthPath, False)
                WriteToFinanceInfo.WriteLine(InflationDifference)
                WriteToFinanceInfo.Close()
            End If

        Catch EasyInflationException As Exception
            'If any problems happen while calling Inflation (Usually lacking files), state it to the end-user.
            MsgBox(EasyInflationException.ToString)
            MsgBox("Failed to call Inflation! Files must be missing from the Data folder!")
        End Try
    End Sub
    Private Shared Sub HardInflation()
        Try
            'This is necessary to know how much money the player has.
            PlayerWealth = My.Computer.FileSystem.ReadAllText(PlayerWealthPath)

            'If the player has too much money, inflation will be more punishing
            If PlayerWealth > InflationPlayerWealth25000 Then
                InflationCalculus = HardInflationPercentage25000
                InflationDifference = PlayerWealth * InflationCalculus
                WriteToFinanceInfo = My.Computer.FileSystem.OpenTextFileWriter(PlayerWealthPath, False)
                WriteToFinanceInfo.WriteLine(InflationDifference)
                WriteToFinanceInfo.Close()
            End If
            'If the player has a bit of money, inflation will be less punishing.
            If PlayerWealth < InflationPlayerWealth5000 And PlayerWealth > InflationPlayerWealth2500 Then
                InflationCalculus = HardInflationPercentage5000
                InflationDifference = PlayerWealth * InflationCalculus
                WriteToFinanceInfo = My.Computer.FileSystem.OpenTextFileWriter(PlayerWealthPath, False)
                WriteToFinanceInfo.WriteLine(InflationDifference)
                WriteToFinanceInfo.Close()
            End If
            'If the player has a bit of money, inflation will be less punishing.
            If PlayerWealth < InflationPlayerWealth2500 Then
                InflationCalculus = HardInflationPercentage2500
                InflationDifference = PlayerWealth * InflationCalculus
                WriteToFinanceInfo = My.Computer.FileSystem.OpenTextFileWriter(PlayerWealthPath, False)
                WriteToFinanceInfo.WriteLine(InflationDifference)
                WriteToFinanceInfo.Close()
            End If

        Catch HardInflationException As Exception
            'If any problems happen while calling Inflation (Usually lacking files), state it to the end-user.
            MsgBox(HardInflationException.ToString)
            MsgBox("Failed to call Inflation! Files must be missing from the Data folder!")
        End Try
    End Sub

    Public Shared Sub SetDifficultyEasy()
        WriteToDifficultyInfo = My.Computer.FileSystem.OpenTextFileWriter(DifficultyPath, False)
        WriteToDifficultyInfo.WriteLine("0")
        WriteToDifficultyInfo.Close()
    End Sub
    Public Shared Sub SetDifficultyHard()
        WriteToDifficultyInfo = My.Computer.FileSystem.OpenTextFileWriter(DifficultyPath, False)
        WriteToDifficultyInfo.WriteLine("1")
        WriteToDifficultyInfo.Close()
    End Sub
End Class
Public Class Misc

End Class