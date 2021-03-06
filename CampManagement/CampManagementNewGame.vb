﻿Imports System.Text
Imports TheckStudios_Management_Sim_API_2016

Public Class CampManagementNewGame
    Private Declare Auto Function GetPrivateProfileString Lib "kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Private Declare Auto Function WritePrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer

    'Declares StringBuilders for .INI reading
    Private IniString = New StringBuilder(500)
    'Defines variables, self-explanatory
    Private CurrentDirectory = Application.StartupPath
    Private DataFilesPath = CurrentDirectory + "/Data"
    Private DLCFilesPath = DataFilesPath + "/DLC_Modules"
    Private GameStatsIni = DataFilesPath + "/GameStats.ini"
    Private DLCModuleName, DLCSelected, DLCQuantity, ReadyToLaunchA, ReadyToLaunchB, ReadyToLaunchC


    'Defines Constants
    Const MinCharacter = 4
    Const MaxCharacter = 16

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
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        CampManagementFirstMenu.Show()
        Me.Close()
    End Sub
    Private Sub CampManagementNewGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuleSelectionDropBox.SelectedIndex = 0

        For DLCNumber As Double = 1 To 999
            If My.Computer.FileSystem.FileExists(DLCFilesPath + "/DLC_" + DLCNumber.ToString + ".ini") Then
                GetPrivateProfileString("MOD", "ModName", "", IniString, IniString.Capacity, DLCFilesPath + "/DLC_" + DLCNumber.ToString + ".ini")
                ModuleSelectionDropBox.Items.Add(IniString.ToString)

            End If
        Next

        'The amount of modules available in the dropbox is the DLC quantity.
        DLCQuantity = ModuleSelectionDropBox.Items.Count
        DLCQuantityLabel.Text = DLCQuantity

    End Sub
    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        Try
            If ModuleSelectionDropBox.SelectedIndex = 0 Then
                WritePrivateProfileString("Stats", "IsModEnabled", False, DataFilesPath + "/GameStats.ini")
                WritePrivateProfileString("Stats", "WhichMod", ModuleSelectionDropBox.Text, DataFilesPath + "/GameStats.ini")
                WritePrivateProfileString("Stats", "WhichModFile", "", DataFilesPath + "/GameStats.ini")
            Else
                For DLCNumber As Double = 1 To 999
                    If ModuleSelectionDropBox.SelectedIndex = DLCNumber Then 'Finds which Module is selected.
                        WritePrivateProfileString("Stats", "IsModEnabled", True, DataFilesPath + "/GameStats.ini")
                        WritePrivateProfileString("Stats", "WhichMod", ModuleSelectionDropBox.Text, DataFilesPath + "/GameStats.ini")
                        WritePrivateProfileString("Stats", "WhichModFile", "DLC_" + DLCNumber.ToString + ".ini", DataFilesPath + "/GameStats.ini")
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("An exception occurred while detecting modules.")
        End Try


        Try
            'If a campname has been chosen, and it is not above the max characters, but above minimum.. Create entry on Profile and Save to File.
            If CampTextBox.Text.Length < MaxCharacter And CampTextBox.Text.Length > MinCharacter Then
                WritePrivateProfileString("Stats", "CampName", CampTextBox.Text, DataFilesPath + "/GameStats.ini")
                ReadyToLaunchA = True
            Else
                MsgBox("Your camp's name must be above " + MinCharacter.ToString + " and lower than " + MaxCharacter.ToString)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("An exception occured while writing Camp Name to disk.")
        End Try

        Try
            'If a playername has been chosen, and it is not above the max characters, but above the minimum.. Create Profile and Save to File.
            If PlayerNameTextBox.Text.Length < MaxCharacter And PlayerNameTextBox.Text.Length > MinCharacter Then
                WritePrivateProfileString("Stats", "OwnerName", CampTextBox.Text, DataFilesPath + "/GameStats.ini")
                ReadyToLaunchB = True
            Else
                MsgBox("Your name must be above " + MinCharacter.ToString + " and lower than " + MaxCharacter.ToString)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("An exception occured while writing Player Name to disk.")
        End Try

        Try
            'If Easy is Checked and Difficulty is not, assume Easy Difficulty. If the inverse happens, assume Hard Difficulty. This does work properly.
            If EasyDifficultyCheck.Checked = True And HardDifficultyCheck.Checked = False Then
                Mechanics.SetDifficultyEasy()
                ReadyToLaunchC = True
            Else
                Mechanics.SetDifficultyHard()
                ReadyToLaunchC = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("An exception occured while interpreting difficulty settings.")
        End Try


        If ReadyToLaunchA = True And ReadyToLaunchB = True And ReadyToLaunchC = True Then
            WritePrivateProfileString("Stats", "Ration", 100, GameStatsIni)
            WritePrivateProfileString("Stats", "Water", 100, GameStatsIni)
            WritePrivateProfileString("Stats", "Money", 200, GameStatsIni)
            WritePrivateProfileString("Stats", "Wood", 200, GameStatsIni)
            WritePrivateProfileString("Stats", "ManpowerForce", 20, GameStatsIni)
            WritePrivateProfileString("Stats", "CurrentYear", 1946, GameStatsIni)
            WritePrivateProfileString("Stats", "CurrentMonth", 1, GameStatsIni)
            WritePrivateProfileString("Stats", "CurrentDay", 1, GameStatsIni)
            WritePrivateProfileString("Stats", "LoadGameStatsOnStartup", "True", DataFilesPath + "/GameStats.ini")
            Me.Hide()
            CampManagementMain.Show()
        Else
            MsgBox("Please, check if all information is entered.")
        End If

    End Sub
End Class