Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim myArray(2, 4) As Integer

        MsgBox("0" & myArray.GetUpperBound(0) &
               vbCrLf & "1" & myArray.GetUpperBound(1))

    End Sub
End Class
