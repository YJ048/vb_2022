Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim intInputVar As Integer
        'Dim strMultipleInput As String

        'intInputVar = InputBox("Enter Number 1 to 3", "Input")

        'If intInputVar = 1 Then
        '    txtText1.Text = "One Pressed"
        'ElseIf intInputVar = 2 Then
        '    txtText1.Text = "Two Pressed"
        'ElseIf intInputVar = 3 Then
        '    txtText1.Text = "Three Pressed"
        'Else
        '    txtText1.Text = "Invalid Entry"
        'End If

        'If intInputVar <= 3 Then
        '    MsgBox("Input value less than 3")
        'ElseIf intInputVar <= 4 Then
        '    MsgBox("Input value less than 4")
        'ElseIf intInputVar = 4 Then
        '    MsgBox("Input value is 4")
        'End If

        Dim intInputVar As Integer

        intInputVar = InputBox("Enter in any number", "Input")

        If intInputVar Mod 3 = 0 Then
            If intInputVar Mod 5 = 0 Then
                txtText1.Text = CStr(intInputVar) & " is divisible by 3 and 5"
            Else
                txtText1.Text = CStr(intInputVar) & " is divisible by 3 but not 5"
            End If
        Else

            If intInputVar Mod 5 = 0 Then
                txtText1.Text = CStr(intInputVar) & " is not divisible by 3 but is divisible by 5"
            Else
                txtText1.Text = CStr(intInputVar) & " is not divisible by 3 and 5"
            End If
        End If

    End Sub
End Class
