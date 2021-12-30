Public Class Form1
    Private Sub btnInputName_Click(sender As Object, e As EventArgs) Handles btnInputName.Click
        Dim stName As String = txtName.Text
        Console.WriteLine(stName)
    End Sub

    Private Sub btnID_Click(sender As Object, e As EventArgs) Handles btnID.Click
        Dim stID As String = txtID.Text
        Console.WriteLine(stID)
    End Sub

    Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click
        Dim stName As String = txtName.Text
        Dim stID As String = txtID.Text
        Dim stResult As String

        stResult = stName & " " & stID

        txtResult.Text = stResult
        Console.WriteLine(stResult)
    End Sub
End Class
