Imports System.Runtime.InteropServices
Imports System.Text
Imports TheckStudios_Management_Sim_API_2016

Public Class CampManagementNewGame
    'Declares StringBuilders for .INI reading
    Private IniString = New StringBuilder(500)
    'Defines variables, self-explanatory
    Private CurrentDirectory = Application.StartupPath
    Private DLCFilesPath = CurrentDirectory + "/Data/DLC_Modules"
    Private DataFilesPath = CurrentDirectory + "/Data"
    Private DLCModuleName, DLCSelected, DLCQuantity

    'Defines Constants
    Const MaxCharacter As Double = 12
    Const MinCharacter As Double = 4


    Private Declare Auto Function GetPrivateProfileString Lib "kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Private Declare Auto Function WritePrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer

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
            If Not CampTextBox.Text = "" And CampTextBox.Text.Length > MaxCharacter And CampTextBox.Text.Length < MinCharacter Then
                WritePrivateProfileString("Stats", "CampName", CampTextBox.Text, DataFilesPath + "/GameStats.ini")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("An exception occured while writing Camp Name to disk.")
        End Try


        Try
            'If a playername has been chosen, and it is not above the max characters, but above the minimum.. Create Profile and Save to File.
            If Not PlayerNameTextBox.Text = "" And PlayerNameTextBox.Text.Length > MaxCharacter And CampTextBox.Text.Length < MinCharacter Then
                WritePrivateProfileString("Stats", "CEOName", CampTextBox.Text, DataFilesPath + "/GameStats.ini")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("An exception occured while writing Player Name to disk.")
        End Try


        Try
            'If Easy is Checked and Difficulty is not, assume Easy Difficulty. If the inverse happens, assume Hard Difficulty. This does work properly.
            If EasyDifficultyCheck.Checked = True And HardDifficultyCheck.Checked = False Then
                Mechanics.SetDifficultyEasy()
            Else
                Mechanics.SetDifficultyHard()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("An exception occured while interpreting difficulty settings.")
        End Try

        'Hides NewGame Window
        Me.Hide()
        CampManagementMain.Show()

    End Sub
End Class
'Public Class BeepSpecial
'    <DllImport("KERNEL32.DLL", EntryPoint:="Beep", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
'   Public Shared Function aBeep(ByVal dwFreq As Integer, ByVal dwDuration As Integer) As Boolean

'   End Function
'End Class