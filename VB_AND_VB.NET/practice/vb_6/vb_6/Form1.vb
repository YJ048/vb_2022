Public Class Form1
    ' Creating a function
    'Private Sub btnPassValue_Click(sender As Object, e As EventArgs) Handles btnPassValue.Click
    '    Dim intInput1, intInput2, intResult As Integer

    '    intInput1 = txtNumber1.Text
    '    intInput2 = txtNumber2.Text

    '    intResult = Sum(intInput1, intInput2) ' pass arguments and store returned value

    '    txtResult.Text = intResult ' display the result of the summation

    '    txtOrigVars.Text = intInput1 & " and " & intInput2

    'End Sub

    'Private Function Sum(ByVal intPassed1 As Integer, ByVal intPassed2 As Integer)
    '    Dim intAdd As Integer

    '    intAdd = intPassed1 + intPassed2
    '    intPassed1 = 0
    '    intPassed2 = 0
    '    Return (intAdd)
    'End Function

    ' Passing Arrays to Procedures
    Private Sub btnPassArray_Click(sender As Object, e As EventArgs) Handles btnPassArray.Click
        Dim intDataToSum(16) As Integer
        Dim intLoop, intReturnedSum As Integer

        Dim intDataToSort(16) As Integer
        Dim intReturnedArray() As Integer

        For intLoop = 1 To 16 'fill the array with sequential numbers and display them
            intDataToSum(intLoop) = intLoop
            intDataToSort(intLoop) = intLoop
            txtInitialData.Text = txtInitialData.Text & intDataToSum(intLoop) & vbCrLf
        Next

        intReturnedSum = Sum(intDataToSum) 'call the function and pass the array into it

        txtDisplaySum.Text = intReturnedSum ' display the returned value

        intReturnedArray = Sort(intDataToSort) 'call the function and pass the array into it

        For intLoop = 1 To 16
            txtDisplayArray.Text = txtDisplayArray.Text & intReturnedArray(intLoop) & vbCrLf
        Next

    End Sub

    Private Function Sum(ByVal intDataArray() As Integer) As Integer
        Dim intTemp As Integer, intIndex As Integer

        For intIndex = 1 To 16 'add all array values and store them
            intTemp = intTemp + intDataArray(intIndex)
        Next

        Return (intTemp) ' assign the sum to the return variable

    End Function

    Private Function Sort(ByVal intDataArray() As Integer) As Integer()
        Dim intTemp, intIndex As Integer

        For intIndex = 1 To 8 ' loop throught the passed data and reverse its order
            intTemp = intDataArray(intIndex)
            intDataArray(intIndex) = intDataArray(17 - intIndex)
            intDataArray(17 - intIndex) = intTemp
        Next

        Return (intDataArray) ' assignment the re-arranged array to the return variable
    End Function

End Class
