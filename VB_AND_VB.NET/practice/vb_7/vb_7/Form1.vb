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

    ' Little routine to demonstrate a If Then Else with
    ' multiple input operation and logical operations for lecture
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim intInputVar As Integer 'create a variable to hold numeric input value
        Dim strMultipleInput As String 'create a variable to hold alpha input value

        strMultipleInput = InputBox("Enter One, Two, Three, Four, Five or Six", "Input")

        If strMultipleInput = "One" Or strMultipleInput = "Two" Then             'if strMultipleInput = "One" or "Two"
            txtMultipleCase.Text = "One or Two entered"
        ElseIf strMultipleInput = "Three" Or strMultipleInput = "Four" Then         'if strMultipleInput = "Three" or "Four"
            txtMultipleCase.Text = "Three or Four entered"
        ElseIf strMultipleInput = "Five" Or strMultipleInput = "Six" Then         'if strMultipleInput = "Five" or "Six"
            txtMultipleCase.Text = "Five or Six entered"
        Else
            txtText1.Text = "Invalid entry" 'default
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim intInputVar As Integer 'create a variable to hold numeric input value

        intInputVar = InputBox("Enter Number 1 to 3", "Input")

        Select Case intInputVar
            Case 1                              'if intInputVar = 1
                txtText2.Text = "One pressed"
            Case 2                              'if intInputVar = 2
                txtText2.Text = "Two pressed"
            Case 3                              'if intInputVar = 3
                txtText2.Text = "Three pressed"
            Case Else                           ' default
                txtText2.Text = "Invalid entry"
        End Select
    End Sub
End Class
