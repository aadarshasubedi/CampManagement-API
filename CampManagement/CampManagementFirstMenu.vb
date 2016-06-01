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
    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)
        Console.WriteLine(m.ToString())
        Select Case m.Msg
            Case WmNchittest
                If m.Result = New IntPtr(Htclient) Then
                    m.Result = New IntPtr(Htcaption)
                End If
        End Select
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Me.Close()
    End Sub

    Private Sub NewGameButton_Click(sender As Object, e As EventArgs) Handles NewGameButton.Click
        CampManagementNewGame.Show()
        Me.Close()
    End Sub
    Private Sub ContinueGameButton_Click(sender As Object, e As EventArgs) Handles ContinueGameButton.Click
        WritePrivateProfileString("Stats", "LoadGameStatsOnStartup", "True", DataFilesPath + "/GameStats.ini")
        CampManagementMain.Show()
        Me.Close()
    End Sub
End Class