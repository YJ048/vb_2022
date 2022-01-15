Public Class Form1

    ' Question 6
    Sub oneDimension()
        Dim myNumbers(3) As Integer
        myNumbers(0) = 100
        myNumbers(1) = 200
        myNumbers(2) = 300
        myNumbers(3) = 400

        MsgBox(myNumbers(2))
    End Sub

    ' Question 10
    Function myFunction(ByVal j As Integer) As Double
        Return (j * 3.142)
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        oneDimension()
        MsgBox(myFunction(2))
    End Sub
End Class
