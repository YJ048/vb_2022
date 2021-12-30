Public Class Form1
    Private Sub tbnDrawCircle_Click(sender As Object, e As EventArgs) Handles btnDrawCircle.Click
        Dim myPen As Pen
        myPen = New Pen(Drawing.Color.DarkTurquoise, 5)

        Dim myGraphics As Graphics = Me.CreateGraphics
        Dim myRectangle As New Rectangle

        myRectangle.X = 0
        myRectangle.Y = 0
        myRectangle.Width = 200
        myRectangle.Height = 200

        myGraphics.DrawEllipse(myPen, myRectangle)
    End Sub
End Class
