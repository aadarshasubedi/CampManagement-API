Imports System.Text

Public Class Resources

    'Declares StringBuilders for .INI reading
    Private Shared IniString = New StringBuilder(500)

    'Declares variables, self-explanatory
    Private Shared PlayerWealth, NewPlayerWealth, WorkForceGenerateProfitResult, WorkerAmount
    Private Shared CurrentDirectory = Environment.CurrentDirectory
    Private Shared GameData = CurrentDirectory + "/Data/"
    Private Shared GameStatsIni = GameData + "/GameStats.ini"
    Shared ReceiveProfileString = GetPrivateProfileString("Stats", "Difficulty", "", IniString, IniString.Capacity, GameStatsIni)
    Private Shared DifficultyValue = ReceiveProfileString


    'Declares Constants
    Const Null As VariantType = VariantType.Null

    Const EasyProfitPerWorkForceUnit As Double = 1.25
    Const HardProfitPerWorkForceUnit As Double = 1.15


    Private Declare Auto Function GetPrivateProfileString Lib "kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Private Declare Auto Function WritePrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer
    Public Shared Function Wood()
        ' Coming soon
    End Function
    Public Shared Function Water()
        ' Coming soon
    End Function
    Public Shared Function WorkForceGenerateProfits(PlayerWealth As Double, WorkerAmount As Double) As Double()
        'This is used to calculate profits from manpower (prisoners, workers, etc)
        Try
            If DifficultyValue = 0 Then
                Return EasyWPProfits(PlayerWealth, WorkerAmount)
            Else
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

        'Second value must be ignored.
        Return {NewPlayerWealth, Null}
    End Function
    Private Shared Function HardWPProfits(PlayerWealth As Double, WorkerAmount As Double) As Double()
        'Profit = How Many Workers The Player Has * Profit Per Worker based on Difficulty
        WorkForceGenerateProfitResult = WorkerAmount * HardProfitPerWorkForceUnit
        'PlayersMoney = Profit calculated above + old money quantity (as to not overwrite the money)
        NewPlayerWealth = WorkForceGenerateProfitResult + PlayerWealth

        Return {NewPlayerWealth, Null}

    End Function
End Class
Public Class Mechanics

    'Declares StringBuilders for .INI reading
    Private Shared IniString = New StringBuilder(500)
    Private Shared IniStringIsModEnabled = New StringBuilder(500)
    Private Shared IniStringModFilePath = New StringBuilder(500)
    Private Shared IniStringModRandomEventText = New StringBuilder(900)
    'Declares variables, self-explanatory
    Private Shared NewPlayerWealth, TaxTotal, InflationCalculus, InflationDifference, RandomEventRandomNumber, RandomEventRandomNumberDrawn, ModuleSelected,
    RandomEventSelect, NewPlayerWealthRandomEvent, NewPlayerWoodAmountRandomEvent, NewPlayerWaterAmountRandomEvent, NewPlayerWorkForceAmountRandomEvent, NewPlayerRationAmountRandomEvent
    'CurrentDirectory = Current Directory location
    Private Shared CurrentDirectory = Environment.CurrentDirectory
    'GameModuleData = Modules Folder location
    Private Shared GameModuleData = CurrentDirectory + "/Data/DLC_Modules/"
    'GameData = Data Folder location
    Private Shared GameData = CurrentDirectory + "/Data/"
    'GameStatsIni = GameStats.ini location
    Private Shared GameStatsIni = GameData + "/GameStats.ini"
    'Gets current game difficulty settings.
    Shared ReceiveProfileString = GetPrivateProfileString("Stats", "Difficulty", "", IniString, IniString.Capacity, GameStatsIni)
    Private Shared DifficultyValue = ReceiveProfileString

    'Declares Arrays which randomevents are stored into.
    Shared ArrayRE = {{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20}}

    'Yes, this is heresy, but I like it :(
    Const Zero = 0
    Const One = 1

    'Declares Null as a way of returning Null instead of 0 on Double(). A cheap workaround.
    Const Null As VariantType = VariantType.Null

    'Declares the lion's share of the total money amount.
    Const EasyTaxesPercentage As Double = 0.85
    Const HardTaxesPercentage As Double = 0.65

    'Declares the inflation used to decrease money.
    Const EasyInflationPercentage25000 As Double = 0.89
    Const EasyInflationPercentage5000 As Double = 0.93
    Const EasyInflationPercentage2500 As Double = 0.98
    Const HardInflationPercentage25000 As Double = 0.75
    Const HardInflationPercentage5000 As Double = 0.8
    Const HardInflationPercentage2500 As Double = 0.85

    'Declares the deflation used to increase money.
    Const AustrianEconomicsDeflation As Double = 1.1

    'Declares different inflation for different player wealth
    Const InflationPlayerWealth25000 As Double = 25000
    Const InflationPlayerWealth5000 As Double = 5000
    Const InflationPlayerWealth2500 As Double = 2500

    Private Declare Auto Function GetPrivateProfileString Lib "kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Private Declare Auto Function WritePrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer
    Enum RandomEventType As Integer
        Wealth = 1
        Wood = 2
        Water = 3
        Food = 4
        WorkForce = 5
    End Enum

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
    Public Shared Function RandomEvent(WorkForce As Double, PlayerWealth As Double, WoodAmount As Double, WaterAmount As Double) As Double()
        'This Function draws a RandomEvent using a loop, apply a custom or pre-defined message to it
        'and return a Double() containing:
        'EventType(0)
        'Message(1)
        'And NewPlayerResource(2)
        Dim RandomEventRandomNumber As Random = New Random
        RandomEventRandomNumberDrawn = (RandomEventRandomNumber.Next(1, 20))

        'If using a Mod, use RandomEvents from Mod store into arrays. 
        'If Not, use RandomEvents from Vanilla and store into arrays.
        GetPrivateProfileString("Stats", "IsModEnabled", "", IniStringIsModEnabled, IniStringIsModEnabled.Capacity, GameStatsIni)
        If IniStringIsModEnabled = True Then
            DLCRandomEvents()
        Else
            VanillaRandomEvents()
        End If

        'The following events are hardcoded into the API, thus the messages on the GameStats.ini or DLC_X.ini must be matching context-wise.
        If RandomEventRandomNumberDrawn = 1 Then

            Return {RandomEventType.Wealth, ArrayRE(1), NewPlayerWealthRandomEvent}
        End If
        If RandomEventRandomNumberDrawn = 2 Then

            Return {RandomEventType.Wood, ArrayRE(2), NewPlayerWaterAmountRandomEvent}
        End If
        If RandomEventRandomNumberDrawn = 3 Then

            Return {RandomEventType.WorkForce, ArrayRE(3), NewPlayerWorkForceAmountRandomEvent}
        End If
        If RandomEventRandomNumberDrawn = 4 Then

            Return {RandomEventType.Food, ArrayRE(4), NewPlayerRationAmountRandomEvent}
        End If
        If RandomEventRandomNumberDrawn = 5 Then

            Return {RandomEventType.Wood, ArrayRE(5), NewPlayerWoodAmountRandomEvent}
        End If
        If RandomEventRandomNumberDrawn = 6 Then

            Return {RandomEventType.Wealth, ArrayRE(6), NewPlayerWoodAmountRandomEvent}
        End If
        If RandomEventRandomNumberDrawn = 7 Then

            Return {RandomEventType.Wood, ArrayRE(7), NewPlayerWoodAmountRandomEvent}
        End If
        If RandomEventRandomNumberDrawn = 8 Then

            Return {RandomEventType.Water, ArrayRE(8), NewPlayerWoodAmountRandomEvent}
        End If
        If RandomEventRandomNumberDrawn = 9 Then

            Return {RandomEventType.Food, ArrayRE(9), NewPlayerWoodAmountRandomEvent}
        End If
        If RandomEventRandomNumberDrawn = 10 Then

            Return {RandomEventType.WorkForce, ArrayRE(10), NewPlayerWoodAmountRandomEvent}
        End If
        If RandomEventRandomNumberDrawn = 11 Then

            Return {RandomEventType.Wealth, ArrayRE(11), NewPlayerWoodAmountRandomEvent}
        End If
        If RandomEventRandomNumberDrawn = 12 Then

            Return {RandomEventType.Wood, ArrayRE(12), NewPlayerWoodAmountRandomEvent}
        End If
        If RandomEventRandomNumberDrawn = 13 Then

            Return {RandomEventType.Water, ArrayRE(13), NewPlayerWoodAmountRandomEvent}
        End If
        If RandomEventRandomNumberDrawn = 14 Then

            Return {RandomEventType.Food, ArrayRE(14), NewPlayerWoodAmountRandomEvent}
        End If
        If RandomEventRandomNumberDrawn = 15 Then

            Return {RandomEventType.WorkForce, ArrayRE(15), NewPlayerWoodAmountRandomEvent}
        End If
        If RandomEventRandomNumberDrawn = 16 Then

            Return {RandomEventType.Wealth, ArrayRE(16), NewPlayerWoodAmountRandomEvent}
        End If
        If RandomEventRandomNumberDrawn = 17 Then

            Return {RandomEventType.Wood, ArrayRE(17), NewPlayerWoodAmountRandomEvent}
        End If
        If RandomEventRandomNumberDrawn = 18 Then

            Return {RandomEventType.Water, ArrayRE(18), NewPlayerWoodAmountRandomEvent}
        End If
        If RandomEventRandomNumberDrawn = 19 Then

            Return {RandomEventType.Food, ArrayRE(19), NewPlayerWoodAmountRandomEvent}
        End If
        If RandomEventRandomNumberDrawn = 20 Then

            Return {RandomEventType.WorkForce, ArrayRE(20), NewPlayerWoodAmountRandomEvent}
        End If
    End Function
    Private Shared Sub VanillaRandomEvents()
        For RandomEventNumber As Double = 1 To 20
            GetPrivateProfileString("RandomEvents", "RE" + RandomEventNumber, "", IniStringModRandomEventText, IniStringModRandomEventText.Capacity, GameStatsIni)
            ArrayRE(RandomEventNumber) = IniStringModRandomEventText
        Next
    End Sub
    Private Shared Sub DLCRandomEvents()
        'Searches for mod location.
        GetPrivateProfileString("Stats", "WhichModFile", "", IniStringModFilePath, IniStringModFilePath.Capacity, GameStatsIni)
        'Creates a path to the current selected mod.
        ModuleSelected = GameModuleData + IniStringModFilePath
        For RandomEventNumber As Double = 1 To 20
            GetPrivateProfileString("RandomEvents", "RE" + RandomEventNumber, "", IniStringModRandomEventText, IniStringModRandomEventText.Capacity, ModuleSelected)
            ArrayRE(RandomEventNumber) = IniStringModRandomEventText
        Next
    End Sub
    Public Shared Function Taxes(PlayerWealth As Double) As Double()
        'Checks what difficulty the player is playing with, and calls the appropriate taxes.
        If DifficultyValue = Zero Then
            Return EasyTax(PlayerWealth)
        Else
            Return HardTax(PlayerWealth)
        End If

    End Function
    Private Shared Function EasyTax(PlayerWealth As Double) As Double()
        Try
            'For easy difficulty: enforces 15% of taxes
            'NewPlayerWealth = CurrentWealth * Taxes
            'HowMuchWasCharged = CurrentWealth - NewWealth

            NewPlayerWealth = PlayerWealth * EasyTaxesPercentage
            TaxTotal = PlayerWealth - NewPlayerWealth

            'Returns the new player money and how much was charged
            'Return must be treated as an array, store properly.
            '<Variable X> = Taxes(PlayerMoney)
            '<Variable X>(0) = <Variable for NewPlayerWealth>
            '<Variable X>(1) = <Variable for TaxTotal>
            Return {NewPlayerWealth, TaxTotal}

        Catch EasyTaxesException As Exception
            MsgBox(EasyTaxesException.ToString)
            MsgBox("Failed To Call taxes! Files must be missing from the Data folder!")
        End Try
    End Function
    Private Shared Function HardTax(PlayerWealth As Double) As Double()
        Try
            'For hard difficulty: enforces 35% of taxes
            'NewPlayerWealth = CurrentWealth * Taxes
            'HowMuchWasCharged = CurrentWealth - NewWealth

            NewPlayerWealth = PlayerWealth * HardTaxesPercentage
            TaxTotal = PlayerWealth - NewPlayerWealth

            'Returns the new player money and how much was charged
            'Return must be treated as an array, store properly.
            '<Variable X> = Taxes(PlayerMoney)
            '<Variable X>(0) = <Variable for NewPlayerWealth>
            '<Variable X>(1) = <Variable for TaxTotal>
            Return {NewPlayerWealth, TaxTotal}

        Catch HardTaxesException As Exception
            MsgBox(HardTaxesException.ToString)
            MsgBox("Failed To Call taxes! Files must be missing from the Data folder!")
        End Try
    End Function
    Public Shared Function Inflation(PlayerWealth As Double) As Double
        'Checks what difficulty the player is playing with, and calls the correct inflation.
        If DifficultyValue = 0 Then
            Return EasyInflation(PlayerWealth)
        Else
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
        WritePrivateProfileString("Stats", "Difficulty", Zero, GameStatsIni)
    End Sub
    Public Shared Sub SetDifficultyHard()
        WritePrivateProfileString("Stats", "Difficulty", One, GameStatsIni)
    End Sub
End Class
Public Class Misc

End Class