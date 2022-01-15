Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As Integer
        Dim y As Integer
        x = 10
        y = 10

        Console.WriteLine(x.Equals(y)) ' True
        Console.WriteLine(x = y) ' True

        Dim x2 As Integer
        Dim y2 As Integer
        x2 = 10
        y2 = x2

        Console.WriteLine(x2.Equals(y2)) ' True
        Console.WriteLine(x2 = y2) ' True

        Dim strx As String
        Dim stry As String
        strx = "a"
        stry = "a"

        Console.WriteLine(strx.Equals(stry)) ' True
        Console.WriteLine(strx = stry) ' True

        Dim strx2 As String
        Dim stry2 As String
        strx2 = "a"
        stry2 = strx2

        Console.WriteLine(strx2.Equals(stry2)) 'True
        Console.WriteLine(strx2 = stry2) ' True

        Dim t1 As TestClass
        Dim t2 As TestClass
        Dim t3 As TestClass
        t1 = New TestClass()
        t2 = New TestClass()
        t3 = t1

        Console.WriteLine(t1.Equals(t2)) ' False
        Console.WriteLine(t1.Equals(t3)) ' True
        ' Console.WriteLine(t1 = t2)

    End Sub
End Class
