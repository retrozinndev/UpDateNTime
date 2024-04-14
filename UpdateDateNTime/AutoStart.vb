Imports IWshRuntimeLibrary

Public Class AutoStart
    Private Shared ReadOnly startupFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup)
    Private Shared ReadOnly currentExecutablePath = My.Application.Info.DirectoryPath
    Private Shared ReadOnly executableName = Process.GetCurrentProcess().MainModule.ModuleName

    Private AutoStartShell As WshShell
    Private StartupLink As WshShortcut

    Public Sub MakeAutoStartLink()
        Try
            AutoStartShell = New WshShell
            StartupLink = CType(AutoStartShell.CreateShortcut(GetStartupDirectory() & "\" & GetExecutableName() & ".lnk"), IWshShortcut)
            StartupLink.TargetPath = GetCurrentExecutablePath() & "\" & GetExecutableName()
            StartupLink.Save()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub RemoveAutoStartLink()
        Try
            My.Computer.FileSystem.DeleteFile(GetLinkPath())
        Catch ex As Exception
            MsgBox("Couldn't delete auto start link: " & ex.Message)
        End Try

    End Sub

    Public Shared Function GetLinkPath()
        Return CType(GetStartupDirectory() & "\" & GetExecutableName() & ".lnk", String)
    End Function

    Public Shared Function GetStartupDirectory() As String
        Return startupFolderPath
    End Function

    Public Shared Function GetCurrentExecutablePath() As String
        Return currentExecutablePath.ToString()
    End Function

    Public Shared Function GetExecutableName() As String
        Return executableName
    End Function

End Class
