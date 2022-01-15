Public Class Form1
    Private Sub findButton_Click(sender As Object, e As EventArgs) Handles findButton.Click

        Dim searchString As String
        Dim findPos As Integer

        Try
            searchString = TextBoxSearch.Text
            findPos = InStr(txtClientArea.Text, searchString)

            If findPos > 0 Then txtClientArea.Focus()
            txtClientArea.SelectionStart = findPos - 1
            txtClientArea.SelectionLength = searchString.Length
            txtClientArea.ScrollToCaret()

        Catch ex As Exception
            MessageBox.Show(String.Concat("An error occurred: ", ex.Message))
        End Try

    End Sub
End Class
