Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intInputVar As Integer 'create a variable to hold numeric input value
        Dim strMultipleInput As String 'create a variable to hold alpha input value

        intInputVar = InputBox("Enter Number 1 to 3", "Input")

        If intInputVar = 1 Then             'if intInputVar = 1
            txtText1.Text = "One pressed"
        ElseIf intInputVar = 2 Then         'if intInputVar = 2
            txtText1.Text = "Two pressed"
        ElseIf intInputVar = 3 Then         'if intInputVar = 3
            txtText1.Text = "Three pressed"
        Else
            txtText1.Text = "Invalid entry" 'default
        End If

    End Sub
End Class
