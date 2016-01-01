Imports System.IO

Public Class Resources
    Public Shared Sub Wood()
        ' ??
    End Sub
    Public Shared Sub Water()

    End Sub
    Public Shared Sub ManPower()
        Dim PrisonerAmountPath = Environment.CurrentDirectory + "/Data/MPInfo.txt"
        Dim PrisonerAmount = My.Computer.FileSystem.ReadAllText(Environment.CurrentDirectory + "/Data/MPInfo.txt")

    End Sub
End Class
Public Class Mechanics
    Private Shared Sub HardTax()
        Try
            'For hard difficulty: enforces 35% of Taxes.
            'Taxes are automaticly calculated and debted from the player's wealth. Just call them in-game.
            Dim TaxInfo = Environment.CurrentDirectory + "/Data/TaxInfo.txt"
            'This is necessary to save on the disk how much money the player has after being charged taxes.
            Dim PlayerWealthPath = Environment.CurrentDirectory + "/Data/FinanceInfo.txt"
            'This is necessary to know how much money the player has.
            Dim PlayerWealth = My.Computer.FileSystem.ReadAllText(Environment.CurrentDirectory + "/Data/FinanceInfo.txt")
            'Taxes are 35%
            Dim NewPlayerWealth = PlayerWealth - "35%"
            Dim TaxTotal = PlayerWealth - NewPlayerWealth

            'Write to disk the new playerwealth.
            Dim WriteToGameInfo As StreamWriter
            WriteToGameInfo = My.Computer.FileSystem.OpenTextFileWriter(PlayerWealthPath, False)
            WriteToGameInfo.WriteLine(NewPlayerWealth)
            WriteToGameInfo.Close()

            'This is simply so the game knows how much tax were charged on player, if the developer wishes to disclose it..
            Dim WriteToGameInfo2 As StreamWriter
            WriteToGameInfo2 = My.Computer.FileSystem.OpenTextFileWriter(TaxInfo, False)
            WriteToGameInfo2.WriteLine(Taxtotal)
            WriteToGameInfo2.Close()

        Catch HardTaxesException As Exception
            'If any problems happen while calling taxes (Usually lacking files), state it to the end-user.
            MsgBox(HardTaxesException.ToString)
            MsgBox("Failed to call taxes! Files must be missing from the Data folder!")
        End Try
    End Sub
    Private Shared Sub EasyTax()
        Try
            'Taxes are automaticly calculated and debted from the player's wealth. Just call them in-game.
            Dim TaxInfo = Environment.CurrentDirectory + "/Data/TaxInfo.txt"
            'This is necessary to save on the disk how much money the player has after being charged taxes.
            Dim PlayerWealthPath = Environment.CurrentDirectory + "/Data/FinanceInfo.txt"
            'This is necessary to know how much money the player has.
            Dim PlayerWealth = My.Computer.FileSystem.ReadAllText(Environment.CurrentDirectory + "/Data/FinanceInfo.txt")
            'Taxes are 15%
            Dim NewPlayerWealth = PlayerWealth * 0.85
            Dim TaxTotal = PlayerWealth - NewPlayerWealth

            'Write to disk the new playerwealth.
            Dim WriteToGameInfo As StreamWriter
            WriteToGameInfo = My.Computer.FileSystem.OpenTextFileWriter(PlayerWealthPath, False)
            WriteToGameInfo.WriteLine(NewPlayerWealth)
            WriteToGameInfo.Close()

            'This is simply so the game knows how much tax were charged on player, if the developer wishes to disclose it..
            Dim WriteToGameInfo2 As StreamWriter
            WriteToGameInfo2 = My.Computer.FileSystem.OpenTextFileWriter(TaxInfo, False)
            WriteToGameInfo2.WriteLine(TaxTotal)
            WriteToGameInfo2.Close()

        Catch EasyTaxesException As Exception
            'If any problems happen while calling taxes (Usually lacking files), state it to the end-user.
            MsgBox(EasyTaxesException.ToString)
            MsgBox("Failed to call taxes! Files must be missing from the Data folder!")
        End Try
    End Sub

    Public Shared Sub Taxes()
        'Checks what difficulty the player is playing with, and calls the correct taxes.
        If My.Computer.FileSystem.ReadAllText(Environment.CurrentDirectory + "/Data/DifficultyInfo.txt") = 0 Then
            EasyTax()
        Else
            HardTax()
        End If

    End Sub
    Private Shared Sub EasyInflation()
        Try
            'This is necessary to know how much money the player has.
            Dim PlayerWealth = My.Computer.FileSystem.ReadAllText(Environment.CurrentDirectory + "/Data/FinanceInfo.txt")
            'This is necessary to save on the disk how much the player has after being charged inflation.
            Dim PlayerWealthPath = Environment.CurrentDirectory + "/Data/FinanceInfo.txt"
            'If the player has too much money, inflation will be more punishing
            If PlayerWealth > "25000" Then
                Dim Inflation = 0.89
                Dim InflationDifference = PlayerWealth * Inflation
                Dim WriteToFinanceInfo As StreamWriter
                WriteToFinanceInfo = My.Computer.FileSystem.OpenTextFileWriter(PlayerWealthPath, False)
                WriteToFinanceInfo.WriteLine(InflationDifference)
                WriteToFinanceInfo.Close()
            End If
            'If the player has a bit of money, inflation will be less punishing.
            If PlayerWealth < "5000" And PlayerWealth > "2500" Then
                Dim Inflation = 0.93
                Dim InflationDifference = PlayerWealth * Inflation
                Dim WriteToFinanceInfo As StreamWriter
                WriteToFinanceInfo = My.Computer.FileSystem.OpenTextFileWriter(PlayerWealthPath, False)
                WriteToFinanceInfo.WriteLine(InflationDifference)
                WriteToFinanceInfo.Close()
            End If
            'If the player has a bit of money, inflation will be less punishing.
            If PlayerWealth < "2500" Then
                Dim Inflation = 0.98
                Dim InflationDifference = PlayerWealth * Inflation
                Dim WriteToFinanceInfo As StreamWriter
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
            Dim PlayerWealth = My.Computer.FileSystem.ReadAllText(Environment.CurrentDirectory + "/Data/FinanceInfo.txt")
            'This is necessary to save on the disk how much the player has after being charged inflation.
            Dim PlayerWealthPath = Environment.CurrentDirectory + "/Data/FinanceInfo.txt"
            'If the player has too much money, inflation will be more punishing
            If PlayerWealth > "25000" Then
                Dim Inflation = 0.75
                Dim InflationDifference = PlayerWealth * Inflation
                Dim WriteToFinanceInfo As StreamWriter
                WriteToFinanceInfo = My.Computer.FileSystem.OpenTextFileWriter(PlayerWealthPath, False)
                WriteToFinanceInfo.WriteLine(InflationDifference)
                WriteToFinanceInfo.Close()
            End If
            'If the player has a bit of money, inflation will be less punishing.
            If PlayerWealth < "5000" And PlayerWealth > "2500" Then
                Dim Inflation = 0.8
                Dim InflationDifference = PlayerWealth * Inflation
                Dim WriteToFinanceInfo As StreamWriter
                WriteToFinanceInfo = My.Computer.FileSystem.OpenTextFileWriter(PlayerWealthPath, False)
                WriteToFinanceInfo.WriteLine(InflationDifference)
                WriteToFinanceInfo.Close()
            End If
            'If the player has a bit of money, inflation will be less punishing.
            If PlayerWealth < "2500" Then
                Dim Inflation = 0.85
                Dim InflationDifference = PlayerWealth * Inflation
                Dim WriteToFinanceInfo As StreamWriter
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
    Public Shared Sub Inflation()
        'Checks what difficulty the player is playing with, and calls the correct inflation.
        If My.Computer.FileSystem.ReadAllText(Environment.CurrentDirectory + "/Data/DifficultyInfo.txt") = 0 Then
            EasyInflation()

        Else
            HardInflation()
        End If
    End Sub

    Public Shared Sub SetDifficultyEasy()
        Dim DifficultyPath = Environment.CurrentDirectory + "/Data/Difficulty.txt"
        Dim WriteToDifficultyInfo As StreamWriter
        WriteToDifficultyInfo = My.Computer.FileSystem.OpenTextFileWriter(DifficultyPath, False)
        WriteToDifficultyInfo.WriteLine("0")
        WriteToDifficultyInfo.Close()
    End Sub
    Public Shared Sub SetDifficultyHard()
        Dim DifficultyPath = Environment.CurrentDirectory + "/Data/Difficulty.txt"
        Dim WriteToDifficultyInfo As StreamWriter
        WriteToDifficultyInfo = My.Computer.FileSystem.OpenTextFileWriter(DifficultyPath, False)
        WriteToDifficultyInfo.WriteLine("1")
        WriteToDifficultyInfo.Close()
    End Sub
End Class
Public Class Misc

End Class