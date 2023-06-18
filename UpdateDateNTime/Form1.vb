Public Class Form1
    Dim url As String = "https://www.github.com/retrozinndev"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Do something when the window loads
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' "Update!" Button
        Dim command As String = "update.bat"
        Shell(command)
    End Sub
    ' TODO: Restart w32time button (hidden)
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
    ' TODO: Repair w32time button (hidden)
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub githubLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles githubLink.LinkClicked
        Shell("cmd /c start " & url, AppWinStyle.NormalFocus)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Shell("cmd /c start " & url, AppWinStyle.NormalFocus)
    End Sub
End Class
