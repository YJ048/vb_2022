Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim intInner, intOuter As Integer
        Dim intInner As Integer
        Dim intOuter As Integer
        Dim intTotal As Integer

        For intOuter = 0 To 99
            For intInner = 0 To 99
                intTotal = intTotal + 1
            Next
        Next

        txtNestedLoop.Text = intTotal

    End Sub
End Class
