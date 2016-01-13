Imports System.Text

Public Class Resources
    'Gets current directory and stores into object, as to not request it everytime.
    Friend Shared MyLocation = Environment.CurrentDirectory
    'This is necessary to know where the difficulty settings are.
    Friend Shared DifficultyPath As String = MyLocation + "/Data/DifficultyInfo.txt"
    'This is necessary to know what difficulty the player is playing on.
    Friend Shared DifficultySettings As String = My.Computer.FileSystem.ReadAllText(DifficultyPath)
    'Other variables. self-explanatory
    Private Shared PlayerWealth, NewPlayerWealth, WorkForceGenerateProfitResult, WorkerAmount As String

    'Uses consts instead of static doubles
    Const EasyProfitPerWorkForceUnit As Double = 1.25
    Const HardProfitPerWorkForceUnit As Double = 1.1

    Public Shared Function Wood()
        ' Coming soon
    End Function
    Public Shared Function Water()
        ' Coming soon
    End Function
    Public Shared Function WorkForceGenerateProfits(PlayerWealth As Double, WorkerAmount As Double) As Double()
        'This is used to calculate profits from manpower (prisoners, workers, and others)
        Try
            If DifficultySettings = 0 Then
                '       EasyWPProfits(PlayerWealth, WorkerAmount)
                Return EasyWPProfits(PlayerWealth, WorkerAmount)
            Else
                '      HardWPProfits(PlayerWealth, WorkerAmount)
                Return HardWPProfits(PlayerWealth, WorkerAmount)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Failed to call MP Profits! Files must be missing from the Data folder!")
        End Try
    End Function
    Private Shared Function EasyWPProfits(PlayerWealth As Double, WorkerAmount As Double) As Double()
        'Profit = How Many Workers The Player Has * Profit Per Worker based on Difficulty
        WorkForceGenerateProfitResult = WorkerAmount * EasyProfitPerWorkForceUnit
        'PlayersMoney = Profit calculated above + old money quantity (as to not overwrite the money)
        NewPlayerWealth = WorkForceGenerateProfitResult + PlayerWealth

        Return {NewPlayerWealth, 0}

    End Function
    Private Shared Function HardWPProfits(PlayerWealth As Double, WorkerAmount As Double) As Double()
        'Profit = How Many Workers The Player Has * Profit Per Worker based on Difficulty
        WorkForceGenerateProfitResult = WorkerAmount * HardProfitPerWorkForceUnit
        'PlayersMoney = Profit calculated above + old money quantity (as to not overwrite the money)
        NewPlayerWealth = WorkForceGenerateProfitResult + PlayerWealth

        Return {NewPlayerWealth, 0}

    End Function
End Class
Public Class Mechanics

    'Other variables. self-explanatory
    Private Shared NewPlayerWealth, TaxTotal, InflationCalculus, InflationDifference As String
    Private Shared IniString = New StringBuilder
    Private Shared DifficultyLocation = Environment.CurrentDirectory + "/Data/GameStats.ini"
    Shared ReceiveProfileString = GetPrivateProfileString("Stats", "Difficulty", "", IniString, IniString.Capacity, DifficultyLocation)
    Private Shared DifficultyValue = ReceiveProfileString

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

    Private Declare Auto Function GetPrivateProfileString Lib "kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Private Declare Auto Function WritePrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer

    Public Shared Function GetDay(OldDay As Double) As Double
        'Old day = Itself + 7
        OldDay = OldDay + 7
        Return OldDay
        'It is possible for the days to go over 30, so be sure to state:
        'If OldDay > 30 then
        'OldDay = OldDay - 30
        'end if

    End Function
    Public Shared Function GetMonth(Month As Double) As String
        If Month = 0 Then
            Return "Invalid Month"
        End If
        If Month = 1 Then
            Return "January"
        End If
        If Month = 2 Then
            Return "February"
        End If
        If Month = 3 Then
            Return "March"
        End If
        If Month = 4 Then
            Return "April"
        End If
        If Month = 5 Then
            Return "May"
        End If
        If Month = 6 Then
            Return "June"
        End If
        If Month = 7 Then
            Return "July"
        End If
        If Month = 8 Then
            Return "August"
        End If
        If Month = 9 Then
            Return "September"
        End If
        If Month = 10 Then
            Return "October"
        End If
        If Month = 11 Then
            Return "November"
        End If
        If Month = 12 Then
            Return "December"
        End If

    End Function
    Public Shared Function Taxes(PlayerWealth As Double) As Double()

        'Checks what difficulty the player is playing with, and calls the correct taxes.
        If DifficultyValue = Zero Then
            '    EasyTax(PlayerWealth)
            Return EasyTax(PlayerWealth)
        Else
            '      HardTax(PlayerWealth)
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
        If DifficultyValue = 0 Then
            '  EasyInflation(PlayerWealth)
            Return EasyInflation(PlayerWealth)
        Else
            '    HardInflation(PlayerWealth)
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
        WritePrivateProfileString("Stats", "Difficulty", 0, DifficultyLocation)
    End Sub
    Public Shared Sub SetDifficultyHard()
        WritePrivateProfileString("Stats", "Difficulty", 1, DifficultyLocation)
    End Sub
End Class
Public Class Misc

End Class