Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strInput As String
        strInput = InputBox("Enter in a value") & vbCrLf

        txtOutput.Text &= strInput
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtOutput.Text = ""
        Threading.Thread.Sleep(3000)
        Me.Close()
    End Sub
End Class
