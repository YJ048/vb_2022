Public Class Form1
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim dbCentigrade As Double = txtCentigrade.Text
        Dim dbFahrenheit As Double

        dbFahrenheit = dbCentigrade * (9 / 5) + 32

        txtFahrenheit.Text = dbFahrenheit
    End Sub
End Class