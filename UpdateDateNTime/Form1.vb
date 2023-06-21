Imports System.Reflection
<Assembly: AssemblyProduct("UpDateNTime")>
<Assembly: AssemblyCopyright("© 2023, retrozinndev")>
<Assembly: AssemblyCompany("retrozinndev")>
<Assembly: AssemblyDescription("An open-source program that syncs your time with the internet!")>
<Assembly: AssemblyFileVersion("1.0.1")>
Public Class Form1

    Dim checkedCheckBox As Boolean
    Public Sub OpenProfileLink()
        Dim profileURL As String = "https://www.github.com/retrozinndev"
        Shell("cmd /c start " & profileURL, AppWinStyle.MinimizedNoFocus)
    End Sub
    Public Sub UpdateTime()
        Dim fileName As String = "Resources\update.cmd"
        Dim command As String = "cmd /c start " & fileName
        Shell(command)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Do something when the window loads
        UpdateTime()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' "Update!" Button
        UpdateTime()
    End Sub
    ' TO DO: Restart w32time button (hidden)
    Private Sub RestartServiceButton_Click(sender As Object, e As EventArgs) Handles RestartServiceButton.Click
        Dim fileName As String = "Resources\restart.cmd"
        Dim command As String = "cmd /c start " & fileName
        Shell(command)
    End Sub
    ' TO DO: Repair w32time button (hidden)
    Private Sub RepairServiceButton_Click(sender As Object, e As EventArgs) Handles RepairServiceButton.Click
        Dim fileName As String = "Resources\repair.cmd"
        Dim command As String = "cmd /c /start " & fileName
        Shell(command)
    End Sub

    Private Sub githubLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles githubLink.LinkClicked
        OpenProfileLink()
    End Sub

    Private Sub githubLogo_Click(sender As Object, e As EventArgs) Handles githubLogo.Click
        OpenProfileLink()
    End Sub

    Private Sub AutoStartCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles AutoStartCheckBox.CheckedChanged
        ' TO DO: Make a system that makes the app starts automatically
    End Sub
End Class
