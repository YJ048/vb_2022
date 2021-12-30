Public Class Form1

    Private Sub btnPassValue_Click(sender As Object, e As EventArgs) Handles btnPassValue.Click
        Dim intInput1 As Integer, intInput2 As Integer

        intInput1 = txtNumber1.Text
        intInput2 = txtNumber2.Text

        Addition(intInput1, intInput2)

        txtOrigVars.Text = intInput1 & " and " & intInput2

    End Sub
    ' ByVal Example
    'Private Sub Addition(ByVal intPassed1 As Integer, ByVal intPassed2 As Integer)
    '    Dim Add As Integer

    '    Add = intPassed1 + intPassed2
    '    intPassed1 = 0
    '    intPassed2 = 0
    '    txtResult.Text = Add

    'End Sub

    ' ByRef Example
    Private Sub Addition(ByRef intPassed1 As Integer, ByRef intPassed2 As Integer)
        Dim Add As Integer

        Add = intPassed1 + intPassed2
        intPassed1 = 0
        intPassed2 = 0
        txtResult.Text = Add

    End Sub
End Class
