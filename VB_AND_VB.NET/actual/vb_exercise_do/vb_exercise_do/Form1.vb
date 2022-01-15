Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intCounter As Integer
        intCounter = 0

        Do
            intCounter = intCounter + 1
            txtDo.Text = txtDo.Text & intCounter
        Loop Until intCounter > 19

        ' Indefinite Loop
        'Do
        '    MsgBox("Before increment : " & intCounter)
        '    intCounter = intCounter + 2
        '    MsgBox("After increment : " & intCounter)
        '    txtDo.Text = txtDo.Text & intCounter & vbCrLf
        'Loop While True

        'Both code results in the same indefinite loop
        'For demonstration purpose
        'Do
        '    MsgBox("Before increment : " & intCounter)
        '    intCounter = intCounter + 2
        '    MsgBox("After increment : " & intCounter)
        '    txtDo.Text = txtDo.Text & intCounter & vbCrLf
        'Loop Until False

        ' Execute code for 0 to n times
        'While intCounter <> 0
        '    MsgBox("Looping")
        'End While

        ' Execute code for 1 to n times
        'Do
        '    MsgBox("Looping")
        'Loop While intCounter <> 0

    End Sub
End Class
