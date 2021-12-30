Public Class Form1

    ' 15 - Fill Array
    'Private Sub btnFillArray_Click(sender As Object, e As EventArgs) Handles btnFillArray.Click
    '    Dim intDataArray(4) As Integer
    '    Dim intLoop As Integer

    '    ' Loop to read user input into array cells
    '    For intLoop = 0 To 4
    '        intDataArray(intLoop) = InputBox("Please enter an interger value ", "Numberical Input", 1)
    '    Next

    '    ' Loop to display values in the textbox
    '    For intLoop = 0 To 4
    '        txtDisplayResult.Text = txtDisplayResult.Text & intDataArray(intLoop) & vbCrLf
    '    Next
    'End Sub

    ' 16 - Fill Dynamic Array
    Private Sub btnFillDynArray_Click(sender As Object, e As EventArgs) Handles btnFillDynArray.Click
        Dim intDataArray() As Integer
        Dim intLoop As Integer

        ' Loop to read user input into array cells
        For intLoop = 0 To 4
            ReDim Preserve intDataArray(intLoop) 'add one cell to array with Preserve of data
            intDataArray(intLoop) = InputBox("Please enter an interger value ", "Numberical Input", 1)
        Next

        ' Loop to display values in the textbox
        For intLoop = 0 To 4
            txtDisplayResult.Text = txtDisplayResult.Text & intDataArray(intLoop) & vbCrLf
        Next
    End Sub

    ' 17 - Bounds 1
    Private Sub btnGetArrayBounds_Click(sender As Object, e As EventArgs) Handles btnGetArrayBounds.Click
        Dim intDataArray(4) As Integer
        Dim intLoop As Integer

        ' Loop to read user input into array cells
        For intLoop = 0 To 4
            intDataArray(intLoop) = intLoop * 2
        Next

        txtLowerB.Text = "Lower Bound is " & intDataArray.GetLowerBound(0)
        txtUpperB.Text = "Upper Bound is " & intDataArray.GetUpperBound(0)

    End Sub

    ' 18 - Fill Array with Bound For Loop Construct
    Private Sub btnFillArray_Click(sender As Object, e As EventArgs) Handles btnFillArray.Click
        Dim intDataArray(4) As Integer
        Dim intLoop As Integer

        ' Loop to read user input into array cells
        For intLoop = intDataArray.GetLowerBound(0) To intDataArray.GetUpperBound(0)
            intDataArray(intLoop) = InputBox("Please enter an interger value ", "Numberical Input", 1)
        Next

        ' Loop to display values in the textbox
        For intLoop = intDataArray.GetLowerBound(0) To intDataArray.GetUpperBound(0)
            txtDisplayResult.Text = txtDisplayResult.Text & intDataArray(intLoop) & vbCrLf
        Next
    End Sub

End Class
