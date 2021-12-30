Public Class Form1

    ' While Loop
    Private Sub While_Demo(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intCounter As Integer   ' Declare variable
        intCounter = 0              ' Initialise variables

        While intCounter < 20        ' Test value
            intCounter = intCounter + 1 ' Increment variables
            txtWhileResult.Text = txtWhileResult.Text & intCounter & vbCrLf
        End While ' End While loop when intCounter > 19

        MsgBox(intCounter) 'Prints total count in message box
    End Sub

    ' Do Loop
    Private Sub Do_Demo(sender As Object, e As EventArgs) Handles Button2.Click
        Dim intCounter As Integer   ' Declare variable
        intCounter = 0              ' Initialise variables

        Do
            intCounter = intCounter + 1
            txtDoResult.Text = txtDoResult.Text & intCounter & vbCrLf
        Loop Until intCounter > 19 ' Test value of Counter

        MsgBox(intCounter) 'Prints 20 in message box
    End Sub

    ' For Next Loop
    Private Sub For_Demo(sender As Object, e As EventArgs) Handles Button3.Click
        Dim intCounter As Integer   ' Declare variable

        For intCounter = 1 To 20
            txtForResult.Text = txtForResult.Text & intCounter & vbCrLf
        Next

        MsgBox(intCounter) 'Prints 21 in message box
    End Sub

    ' Nested Loop
    Private Sub Nested_Demo(sender As Object, e As EventArgs) Handles Button4.Click
        Dim intInner, intOuter, intTotal As Integer

        For intOuter = 0 To 99
            For intInner = 0 To 99
                intTotal = intTotal + 1 'count number of times this line is run
            Next
        Next

        txtNestedLoop.Text = intTotal
    End Sub
End Class
