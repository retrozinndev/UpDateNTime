Public Class Form1
    Public Sub OpenProfileLink()
        Dim profileURL As String = "https://www.github.com/retrozinndev"
        Shell("cmd /c start " & profileURL, AppWinStyle.MinimizedNoFocus)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Do something when the window loads
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' "Update!" Button
        Dim fileName As String = "Resources\update.cmd"
        Dim command As String = "cmd /c start " & fileName
        Shell(command)
    End Sub
    ' TO DO: Restart w32time button (hidden)
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
    ' TO DO: Repair w32time button (hidden)
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub githubLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles githubLink.LinkClicked
        OpenProfileLink()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        OpenProfileLink()
    End Sub
End Class
