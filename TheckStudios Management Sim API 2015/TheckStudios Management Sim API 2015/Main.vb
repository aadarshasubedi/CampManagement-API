﻿Imports System.IO

Public Class Resources

End Class
Public Class Mechanics
    Public Shared Sub EasyTaxes()
        ' EasyTaxes Sub enforces 15% of Taxes.
        Dim TaxToBeDebted = Environment.CurrentDirectory + "/Data/TaxInfo.txt"
        Dim PlayerWealth = My.Computer.FileSystem.ReadAllText(Environment.CurrentDirectory + "/Data/FinanceInfo.txt")
        Dim TaxTotal = PlayerWealth - 85%


        '  MsgBox("The local government demands taxes from you." + " $" + TaxTotal + "Will be taken from your treasury.")

        Dim WriteToGameInfo As StreamWriter
        WriteToGameInfo = My.Computer.FileSystem.OpenTextFileWriter(TaxToBeDebted, True)
        WriteToGameInfo.WriteLine(TaxTotal)
        WriteToGameInfo.Close()
    End Sub
    Public Shared Sub HardTaxes()
        ' HardTaxes Sub enforces 35% of Taxes.
        Dim TaxToBeDebted = Environment.CurrentDirectory + "/Data/TaxInfo.txt"
        Dim PlayerWealth = My.Computer.FileSystem.ReadAllText(Environment.CurrentDirectory + "/Data/FinanceInfo.txt")
        Dim TaxTotal = PlayerWealth - 65%


        '  MsgBox("The local government demands taxes from you." + " $" + TaxTotal + "Will be taken from your treasury.")

        Dim WriteToGameInfo As StreamWriter
        WriteToGameInfo = My.Computer.FileSystem.OpenTextFileWriter(TaxToBeDebted, True)
        WriteToGameInfo.WriteLine(TaxTotal)
        WriteToGameInfo.Close()
    End Sub
    Public Shared Sub EasyInflation()
        Dim PlayerWealth = My.Computer.FileSystem.ReadAllText(Environment.CurrentDirectory + "/Data/FinanceInfo.txt")
        Dim PlayerWealthPath = Environment.CurrentDirectory + "/Data/FinanceInfo.txt"
        If PlayerWealth > 25000 Then
            Dim Inflation = "0.9"
            Dim InflationDifference = PlayerWealth * Inflation
            Dim WriteToFinanceInfo As StreamWriter
            WriteToFinanceInfo = My.Computer.FileSystem.OpenTextFileWriter(PlayerWealthPath, True)
            WriteToFinanceInfo.WriteLine(InflationDifference)
            WriteToFinanceInfo.Close()
        End If
        If PlayerWealth < 5000 And PlayerWealth > 2500 Then
            Dim Inflation = "0.99"
            Dim InflationDifference = PlayerWealth * Inflation
            Dim WriteToFinanceInfo As StreamWriter
            WriteToFinanceInfo = My.Computer.FileSystem.OpenTextFileWriter(PlayerWealthPath, True)
            WriteToFinanceInfo.WriteLine(InflationDifference)
            WriteToFinanceInfo.Close()
        End If
        If PlayerWealth < 2500 Then
            Dim Inflation = "0.95"
            Dim InflationDifference = PlayerWealth * Inflation
            Dim WriteToFinanceInfo As StreamWriter
            WriteToFinanceInfo = My.Computer.FileSystem.OpenTextFileWriter(PlayerWealthPath, True)
            WriteToFinanceInfo.WriteLine(InflationDifference)
            WriteToFinanceInfo.Close()
        End If
    End Sub
    Public Shared Sub HardInflation()
        Dim PlayerWealth = My.Computer.FileSystem.ReadAllText(Environment.CurrentDirectory + "/Data/FinanceInfo.txt")
        Dim PlayerWealthPath = Environment.CurrentDirectory + "/Data/FinanceInfo.txt"

        If PlayerWealth > 25000 Then
            Dim Inflation = "0.75"
            Dim InflationDifference = PlayerWealth * Inflation
            Dim WriteToFinanceInfo As StreamWriter
            WriteToFinanceInfo = My.Computer.FileSystem.OpenTextFileWriter(PlayerWealthPath, True)
            WriteToFinanceInfo.WriteLine(InflationDifference)
            WriteToFinanceInfo.Close()
        End If
        If PlayerWealth < 5000 And PlayerWealth > 2500 Then
            Dim Inflation = "0.80"
            Dim InflationDifference = PlayerWealth * Inflation
            Dim WriteToFinanceInfo As StreamWriter
            WriteToFinanceInfo = My.Computer.FileSystem.OpenTextFileWriter(PlayerWealthPath, True)
            WriteToFinanceInfo.WriteLine(InflationDifference)
            WriteToFinanceInfo.Close()
        End If
        If PlayerWealth < 2500 Then
            Dim Inflation = "0.85"
            Dim InflationDifference = PlayerWealth * Inflation
            Dim WriteToFinanceInfo As StreamWriter
            WriteToFinanceInfo = My.Computer.FileSystem.OpenTextFileWriter(PlayerWealthPath, True)
            WriteToFinanceInfo.WriteLine(InflationDifference)
            WriteToFinanceInfo.Close()
        End If


    End Sub
    Public Shared Sub PrisonerEasy()

    End Sub
End Class
Public Class Misc

End Class