Public Class Form1
    'Public intCounter As Integer

    'Public Sub Increment()
    '    intCounter += 1
    'End Sub

    'Public Sub Addtext()
    '    txtForResult.Text = intCounter
    'End Sub

    Public Function fucIncrement(ByVal i As Integer) As Integer
        Return i + 1
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim intCounter As Integer

        If txtForResult.Text = "" Then
            txtForResult.Text = "0"
        Else
            intCounter = CInt(txtForResult.Text)
            intCounter = intCounter + 1
        End If

        txtForResult.Text = intCounter






        ' Using Sub routine to increment
        'Increment()
        'Addtext()

        ' Using Function to increment
        'Dim nCounter As Integer
        'nCounter = 1
        'nCounter = fucIncrement(nCounter)
        'txtForResult.Text = nCounter












        Dim dbCounter As Double


        'For dbCounter = 1 To 2 Step 0.05
        '    MsgBox(dbCounter)
        'Next
        'MsgBox("Value After For Next Loop : " & dbCounter)

        'For intCounter = 1 To 20
        '    txtForResult.Text = intCounter
        '    MsgBox(intCounter)
        'Next
        'MsgBox("Value After For Next Loop : " & intCounter)

        ' Visual Studio converts to same data type automatically
        ' Good to have the awareness of data type conversion
        ' CStr(expression) => converts expression to String Data Type
        'MsgBox("Value After For Next Loop : " & CStr(dbCounter))


        'Dim strCounter As String
        'strCounter = CStr(intCounter)

    End Sub
End Class
