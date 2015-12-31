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
    Public Shared Sub EasyTaxes()
        ' HardTaxes Sub enforces 15% of Taxes.
        ' Taxes are automaticly calculated and debted from the player's wealth. Just call them in-game.
        Dim TaxInfo = Environment.CurrentDirectory + "/Data/TaxInfo.txt"
        'This is necessary to save on the disk how much money the player has after being charged taxes.
        Dim PlayerWealthPath = Environment.CurrentDirectory + "/Data/FinanceInfo.txt"
        'This is necessary to know how much money the player has.
        Dim PlayerWealth = My.Computer.FileSystem.ReadAllText(Environment.CurrentDirectory + "/Data/FinanceInfo.txt")
        'TaxTotal is the playerwealth minus 85%, so we can calculate 15% of it to charge taxes.
        Dim TaxTotal = PlayerWealth - 85%
        'TaxDebted is the player's wealth - how much taxes will be charged.
        Dim TaxDebted = PlayerWealth - TaxTotal

        ' MsgBox("The local government demands taxes from you." + " $" + TaxTotal + "Will be taken from your treasury.")

        Dim WriteToGameInfo As StreamWriter
        WriteToGameInfo = My.Computer.FileSystem.OpenTextFileWriter(PlayerWealthPath, False)
        WriteToGameInfo.WriteLine(TaxDebted)
        WriteToGameInfo.Close()

        'This is simply so the game knows how much tax were charged on player, if the developer wishes to disclose it..
        Dim WriteToGameInfo2 As StreamWriter
        WriteToGameInfo2 = My.Computer.FileSystem.OpenTextFileWriter(TaxInfo, False)
        WriteToGameInfo2.WriteLine(TaxTotal)
        WriteToGameInfo2.Close()
    End Sub
    Public Shared Sub HardTaxes()
        ' HardTaxes Sub enforces 35% of Taxes.
        ' Taxes are automaticly calculated and debted from the player's wealth. Just call them in-game.
        Dim TaxInfo = Environment.CurrentDirectory + "/Data/TaxInfo.txt"
        'This is necessary to save on the disk how much money the player has after being charged taxes.
        Dim PlayerWealthPath = Environment.CurrentDirectory + "/Data/FinanceInfo.txt"
        'This is necessary to know how much money the player has.
        Dim PlayerWealth = My.Computer.FileSystem.ReadAllText(Environment.CurrentDirectory + "/Data/FinanceInfo.txt")
        'TaxTotal is the playerwealth minus 85%, so we can calculate 15% of it to charge taxes.
        Dim TaxTotal = PlayerWealth - 65%
        'TaxDebted is the player's wealth - how much taxes will be charged.
        Dim TaxDebted = PlayerWealth - TaxTotal

        ' MsgBox("The local government demands taxes from you." + " $" + TaxTotal + "Will be taken from your treasury.")

        Dim WriteToGameInfo As StreamWriter
        WriteToGameInfo = My.Computer.FileSystem.OpenTextFileWriter(PlayerWealthPath, False)
        WriteToGameInfo.WriteLine(TaxDebted)
        WriteToGameInfo.Close()

        'This is simply so the game knows how much tax were charged on player, if the developer wishes to disclose it..
        Dim WriteToGameInfo2 As StreamWriter
        WriteToGameInfo2 = My.Computer.FileSystem.OpenTextFileWriter(TaxInfo, False)
        WriteToGameInfo2.WriteLine(TaxTotal)
        WriteToGameInfo2.Close()
    End Sub
    Public Shared Sub EasyInflation()
        Dim PlayerWealth = My.Computer.FileSystem.ReadAllText(Environment.CurrentDirectory + "/Data/FinanceInfo.txt")
        Dim PlayerWealthPath = Environment.CurrentDirectory + "/Data/FinanceInfo.txt"
        If PlayerWealth > "25000" Then
            Dim Inflation = 0.89
            Dim InflationDifference = PlayerWealth * Inflation
            Dim WriteToFinanceInfo As StreamWriter
            WriteToFinanceInfo = My.Computer.FileSystem.OpenTextFileWriter(PlayerWealthPath, False)
            WriteToFinanceInfo.WriteLine(InflationDifference)
            WriteToFinanceInfo.Close()
        End If
        If PlayerWealth < "5000" And PlayerWealth > 2500 Then
            Dim Inflation = 0.93
            Dim InflationDifference = PlayerWealth * Inflation
            Dim WriteToFinanceInfo As StreamWriter
            WriteToFinanceInfo = My.Computer.FileSystem.OpenTextFileWriter(PlayerWealthPath, False)
            WriteToFinanceInfo.WriteLine(InflationDifference)
            WriteToFinanceInfo.Close()
        End If
        If PlayerWealth < "2500" Then
            Dim Inflation = 0.98
            Dim InflationDifference = PlayerWealth * Inflation
            Dim WriteToFinanceInfo As StreamWriter
            WriteToFinanceInfo = My.Computer.FileSystem.OpenTextFileWriter(PlayerWealthPath, False)
            WriteToFinanceInfo.WriteLine(InflationDifference)
            WriteToFinanceInfo.Close()
        End If
    End Sub
    Public Shared Sub HardInflation()
        Try
            Dim PlayerWealth = My.Computer.FileSystem.ReadAllText(Environment.CurrentDirectory + "/Data/FinanceInfo.txt")
            Dim PlayerWealthPath = Environment.CurrentDirectory + "/Data/FinanceInfo.txt"

            If PlayerWealth > "25000" Then
                Dim Inflation = 0.75
                Dim InflationDifference = PlayerWealth * Inflation
                Dim WriteToFinanceInfo As StreamWriter
                WriteToFinanceInfo = My.Computer.FileSystem.OpenTextFileWriter(PlayerWealthPath, False)
                WriteToFinanceInfo.WriteLine(InflationDifference)
                WriteToFinanceInfo.Close()
            End If
            If PlayerWealth < "5000" And PlayerWealth > "2500" Then
                Dim Inflation = 0.8
                Dim InflationDifference = PlayerWealth * Inflation
                Dim WriteToFinanceInfo As StreamWriter
                WriteToFinanceInfo = My.Computer.FileSystem.OpenTextFileWriter(PlayerWealthPath, False)
                WriteToFinanceInfo.WriteLine(InflationDifference)
                WriteToFinanceInfo.Close()
            End If
            If PlayerWealth < "2500" Then
                Dim Inflation = 0.85
                Dim InflationDifference = PlayerWealth * Inflation
                Dim WriteToFinanceInfo As StreamWriter
                WriteToFinanceInfo = My.Computer.FileSystem.OpenTextFileWriter(PlayerWealthPath, False)
                WriteToFinanceInfo.WriteLine(InflationDifference)
                WriteToFinanceInfo.Close()
            End If
        Catch HardInflationException As Exception
            MsgBox(HardInflationException.ToString)
            MsgBox("Failed to call Inflation! Files must be missing from the Data folder!")
        End Try



    End Sub

End Class
Public Class Misc

End Class