
Public Class Window
    Dim AutoStartInst As AutoStart = New AutoStart()

    Public Sub OpenProfileLink()
        Dim profileURL As String = "https://www.github.com/retrozinndev"
        Shell("cmd /k start " & profileURL, AppWinStyle.Hide)
    End Sub
    Public Sub UpdateTime()
        Dim fileName As String = "Resources\update.cmd"
        Dim command As String = "cmd /k start " & fileName
        Shell(command, AppWinStyle.Hide)
    End Sub
    Private Sub Window_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateTime()
        If My.Computer.FileSystem.FileExists(AutoStart.GetLinkPath) Then
            AutoStartCheckBox.Checked = True
        End If
    End Sub
    Private Sub Window_LoadFocused(sender As Object, e As EventArgs) Handles MyBase.GotFocus, MyBase.Load
        ' Start minimized if autostart is on
        If My.Computer.FileSystem.FileExists(AutoStart.GetLinkPath) Then
            WindowState = FormWindowState.Normal
            NotifyIcon.Visible = True
            Hide()
        End If
    End Sub

    Private Sub Window_Minimize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ' Move app to Task Bar if minimized
        If WindowState = FormWindowState.Minimized Then
            NotifyIcon.Visible = True
            NotifyIcon.ShowBalloonTip(3, "UpDateN'Time", "App minimized to Task bar. Double click in the app icon to restore window!", ToolTipIcon.Info)
            Hide()
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

    Private Sub NotifyIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon.MouseDoubleClick
        NotifyIcon.Visible = False
        Show()
        WindowState = FormWindowState.Normal
    End Sub
End Class
