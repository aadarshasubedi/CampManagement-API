Imports System.Text

Public Class CampManagementStartup
    Private CurrentDirectory = Application.StartupPath
    Private DLCFilesPath = CurrentDirectory + "/Data/DLC_Modules"
    Private IniString = New StringBuilder(500)
    Private DLCModuleName As String

    Private Declare Auto Function GetPrivateProfileString Lib "kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Private Declare Auto Function WritePrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(DLCFilesPath + "/DLC_" + "1" + ".ini") Then
            GetPrivateProfileString("DLC_1", "ModName", "", IniString, IniString.Capacity, DLCFilesPath + "/DLC_1.ini")
            ModuleSelectionDropBox.Items.Add(IniString.ToString)

        End If
        Threading.Thread.Sleep(1000)
        If My.Computer.FileSystem.FileExists(DLCFilesPath + "/DLC_" + "2" + ".ini") Then
            GetPrivateProfileString("DLC_2", "ModName", "", IniString, IniString.Capacity, DLCFilesPath + "/DLC_2.ini")
            ModuleSelectionDropBox.Items.Add(IniString.ToString)

        End If
        Threading.Thread.Sleep(1000)
        If My.Computer.FileSystem.FileExists(DLCFilesPath + "/DLC_" + "3" + ".ini") Then
            GetPrivateProfileString("DLC_3", "ModName", "", IniString, IniString.Capacity, DLCFilesPath + "/DLC_3.ini")
            ModuleSelectionDropBox.Items.Add(IniString.ToString)

        End If
        If My.Computer.FileSystem.FileExists(DLCFilesPath + " / DLC_" + "4" + ".ini") Then
            GetPrivateProfileString("DLC_4", "ModName", "", IniString, IniString.Capacity, DLCFilesPath + "/DLC_4.ini")
            ModuleSelectionDropBox.Items.Add(IniString.ToString)


        End If
        If My.Computer.FileSystem.FileExists(DLCFilesPath + "/DLC_" + "5" + ".ini") Then
            GetPrivateProfileString("DLC_5", "ModName", "", IniString, IniString.Capacity, DLCFilesPath + "/DLC_5.ini")
            ModuleSelectionDropBox.Items.Add(IniString.ToString)

        End If
        If My.Computer.FileSystem.FileExists(DLCFilesPath + "/DLC_" + "6" + ".ini") Then
            GetPrivateProfileString("DLC_6", "ModName", "", IniString, IniString.Capacity, DLCFilesPath + "/DLC_6.ini")
            ModuleSelectionDropBox.Items.Add(IniString.ToString)

        End If

    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        'Temporary conditional
        If 1 = 1 Then

        End If

    End Sub
End Class