Public Class Form1
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intCounter As Integer
        intCounter = 0

        'MsgBox("Say Hi " & "Say Bye")
        'txtDisplayResult.Text = "Single Line" & vbCrLf & "Say Hi " & "Say Bye" & vbCrLf &
        '                        "Next Line" & vbCrLf & "Say Hi " & vbCrLf & "Say Bye"

        While intCounter <> 20
            txtDisplayResult.Text = txtDisplayResult.Text & intCounter & vbCrLf
            'txtDisplayResult.Text &= intCounter & vbCrLf
            intCounter = intCounter + 1
        End While


        'intCounter += 1
        'intCounter = intCounter + 1

        'While True
        '    ' code to execute
        '    intCounter = intCounter + 1
        '    MsgBox("Say Hi for " & intCounter & " times")

        '    If intCounter = 30 Then
        '        Exit While
        '    End If

        '    'intCounter += 1
        'End While

        'MsgBox("Out of While Loop")

    End Sub
End Class
