Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Do something when window loads
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    ' Update Time Button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim startInfo As New ProcessStartInfo()
        startInfo.FileName = "cmd.exe"
        startInfo.Verb = "runas" ' Admin request (not working for some reason)

        Dim cmdsPath As String = "cmds\"
        Dim file1 As String = cmdsPath + "intialize.cmd"
        Dim file2 As String = cmdsPath + "start.cmd"
        Dim file3 As String = cmdsPath + "resync.cmd"

        Try
            ' Load and Run .cmd files
            startInfo.Arguments = "/c " & file1
            Dim process1 As Process = Process.Start(startInfo)
            process1.WaitForExit()

            startInfo.Arguments = "/c " & file2
            Dim process2 As Process = Process.Start(startInfo)
            process2.WaitForExit()

            startInfo.Arguments = "/c " & file3
            Dim process3 As Process = Process.Start(startInfo)
            process3.WaitForExit()

            MessageBox.Show("Arquivos .cmd executados com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Erro ao executar os arquivos .cmd: " & ex.Message, "An error occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ' TODO: Restart w32time button
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
    ' TODO: Repair w32time button
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class
