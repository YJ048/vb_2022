Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Integer

        x = 4

        MsgBox("Before x = " & x)

        Change(x)

        MsgBox("After x = " & x)

    End Sub

    Private Sub Change(ByRef y As Integer)
        y = 5
    End Sub


    'Private Sub Change(ByRef y As Integer)
    '    y = 5
    'End Sub

End Class
