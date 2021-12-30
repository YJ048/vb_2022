Public Class Form1
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim intInput As Integer = CInt(txtInput.Text)
        Dim intCounter As Integer

        For intCounter = 1 To 10
            txtDisplayResult.Text = txtDisplayResult.Text & (intInput * intCounter) & vbCrLf
        Next
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDisplayResult.Text = ""
    End Sub
End Class
