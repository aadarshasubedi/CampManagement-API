Imports System.Text

Public Class CampManagementFirstMenu
    Private Declare Auto Function GetPrivateProfileString Lib "kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Private Declare Auto Function WritePrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer

    'Declares StringBuilders for .INI reading
    Private IniString = New StringBuilder(500)
    'Defines variables, self-explanatory
    Private CurrentDirectory = Application.StartupPath
    Private DLCFilesPath = CurrentDirectory + "/Data/DLC_Modules"
    Private DataFilesPath = CurrentDirectory + "/Data"

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        MsgBox("Thanks for taking a look at CampManagement!")
        Me.Close()

    End Sub

    Private Sub NewGameButton_Click(sender As Object, e As EventArgs) Handles NewGameButton.Click
        MsgBox("Be careful! If you open a New Game, you'll end up corrupting the previous save files.", MsgBoxStyle.Critical)
        CampManagementNewGame.Show()
        Me.Close()
    End Sub
    Private Sub CampManagementMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub ContinueGameButton_Click(sender As Object, e As EventArgs) Handles ContinueGameButton.Click
        WritePrivateProfileString("Stats", "LoadGameStatsOnStartup", "True", DataFilesPath + "/GameStats.ini")
        CampManagementMain.Show()
        Me.Close()
    End Sub
End Class