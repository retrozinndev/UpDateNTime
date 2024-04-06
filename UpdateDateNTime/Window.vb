Imports System.IO

Public Class Window
    Dim checkedCheckBox As Boolean
    Dim AutoStartInst As AutoStart = New AutoStart()

    Public Sub OpenProfileLink()
        Dim profileURL As String = "https://www.github.com/retrozinndev"
        Shell("cmd /k start " & profileURL, AppWinStyle.MinimizedNoFocus)
    End Sub
    Public Sub UpdateTime()
        Dim fileName As String = "Resources\update.cmd"
        Dim command As String = "cmd /k start " & fileName
        Shell(command, AppWinStyle.MinimizedNoFocus)
    End Sub
    Private Sub Window_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateTime()
        If My.Computer.FileSystem.FileExists(AutoStart.GetLinkPath) Then
            AutoStartCheckBox.Checked = True
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UpdateTime()
    End Sub

    Private Sub GitHubLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles githubLink.LinkClicked
        OpenProfileLink()
    End Sub

    Private Sub GitHubLogo_Click(sender As Object, e As EventArgs) Handles githubLogo.Click
        OpenProfileLink()
    End Sub

    Private Sub AutoStartCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles AutoStartCheckBox.CheckedChanged
        If AutoStartCheckBox.Checked = True Then
            AutoStartInst.MakeAutoStartLink()
        Else
            AutoStartInst.RemoveAutoStartLink()
        End If
    End Sub
End Class
