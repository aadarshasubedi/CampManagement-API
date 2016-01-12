Imports System.Text

Public Class CampManagementStartup
    Private CurrentDirectory = Application.StartupPath
    Private DLCFilesPath = CurrentDirectory + "/Data/DLC_Modules"
    Private DataFilesPath = CurrentDirectory + "/Data"
    Private IniString = New StringBuilder(500)
    Private DLCModuleName As String
    Private DLCSelected, DLCQuantity, DLC1, DLC2, DLC3, DLC4, DLC5, DLC6
    Private Declare Auto Function GetPrivateProfileString Lib "kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Private Declare Auto Function WritePrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For DLCNumber As Double = 1 To 999
            If My.Computer.FileSystem.FileExists(DLCFilesPath + "/DLC_" + DLCNumber.ToString + ".ini") Then
                GetPrivateProfileString("MOD", "ModName", "", IniString, IniString.Capacity, DLCFilesPath + "/DLC_" + DLCNumber.ToString + ".ini")
                ModuleSelectionDropBox.Items.Add(IniString.ToString)

            End If
        Next
    End Sub
    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        DLCQuantity = ModuleSelectionDropBox.Items.Count
        Try
            If ModuleSelectionDropBox.SelectedIndex = 0 Then
                MsgBox("Debug")
                WritePrivateProfileString("Stats", "IsModEnabled", "False", DataFilesPath + "/GameStats.ini")
                WritePrivateProfileString("Stats", "WhichMod", ModuleSelectionDropBox.Text, DataFilesPath + "/GameStats.ini")
            Else
                For DLCNumber As Double = 1 To 999
                    If ModuleSelectionDropBox.SelectedIndex = DLCNumber Then 'Finds which Module is selected.
                        WritePrivateProfileString("Stats", "IsModEnabled", "True", DataFilesPath + "/GameStats.ini")
                        WritePrivateProfileString("Stats", "WhichMod", ModuleSelectionDropBox.Text, DataFilesPath + "/GameStats.ini")
                    End If
                Next

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("An exception occurred while detecting modules.")
        End Try

    End Sub
End Class