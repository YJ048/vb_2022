Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intInput1 As Integer
        Dim intInput2 As Integer
        Dim strOperator As String
        Dim intResult As Integer

        intInput1 = txtInput1.Text
        intInput2 = txtInput2.Text
        strOperator = txtOperator.Text

        If strOperator = "+" Then
            Addition(intInput1, intInput2)
        ElseIf strOperator = "-" Then
            'Subroutine
            Subtraction(intInput1, intInput2)

            'Function
            'intResult = Subtraction(intInput1, intInput2)
            'MsgBox(intResult)
        ElseIf strOperator = "/" Then
            'Sub
            Division(intInput1, intInput2)
        ElseIf strOperator = "*" Then
            'Function
            intResult = Multiplication(intInput1, intInput2)
            MsgBox(intResult)
        Else
            MsgBox("Invalid Input")
        End If
    End Sub

    Private Function Multiplication(ByVal i1 As Integer, ByVal i2 As Integer) As Integer
        Return (i1 * i2)
    End Function

    Private Sub Division(ByVal i1 As Integer, ByVal i2 As Integer)
        Dim intResult As Integer
        intResult = i1 / i2
        MsgBox(intResult)
    End Sub

    Private Sub Addition(ByVal i1 As Integer, ByVal i2 As Integer)
        Dim intResult As Integer

        intResult = i1 + i2
        MsgBox(intResult)
    End Sub

    ' Function
    'Private Function Subtraction(ByVal i1 As Integer, ByVal i2 As Integer) As Integer
    '    Return (i1 - i2)
    'End Function

    ' Subroutine
    Private Sub Subtraction(ByVal i1 As Integer, ByVal i2 As Integer)
        Dim intResult As Integer

        intResult = i1 - i2
        MsgBox(intResult)
    End Sub

End Class
