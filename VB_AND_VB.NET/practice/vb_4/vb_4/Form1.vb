Public Class Form1
    Private Sub Calculate_fall(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblDistance_1, dblDistance_2, dblDistance_3, dblDistance_4 As Double

        Const gravity = 9.81 'm/s^2

        dblDistance_1 = 0.5 * gravity * 1 ^ 2
        dblDistance_2 = 0.5 * gravity * 2 ^ 2
        dblDistance_3 = 0.5 * gravity * 3 ^ 2
        dblDistance_4 = 0.5 * gravity * 4 ^ 2

        'display running distance
        txtDisplayResult.Text = "The ball as fallen" _
            & vbCrLf & dblDistance_1 & " m in 1 second" _
            & vbCrLf & dblDistance_2 & " m in 2 second" _
            & vbCrLf & dblDistance_3 & " m in 3 second" _
            & vbCrLf & dblDistance_4 & " m in 4 second" & vbCrLf

        'display invidual distances
        txtDisplayResult.Text = txtDisplayResult.Text _
            & "During second 1, the ball fell " & dblDistance_1 & " m" & vbCrLf _
            & "During second 2, the ball fell " & (dblDistance_2 - dblDistance_1) & " m" & vbCrLf _
            & "During second 3, the ball fell " & (dblDistance_3 - dblDistance_2) & " m" & vbCrLf _
            & "During second 4, the ball fell " & (dblDistance_4 - dblDistance_3) & " m" & vbCrLf

    End Sub

    Private Sub Iterative_Calculation(sender As Object, e As EventArgs) Handles btnIterative.Click
        Dim dblDistance(0 To 4) As Double
        Dim intTime As Integer
        Const Gravity = 9.81 'm/s^2

        txtDisplayResult.Text = "The ball as fallen" & vbCrLf

        'display running distance
        For intTime = 1 To 4
            dblDistance(intTime) = 1 / 2 * Gravity * intTime ^ 2
            txtDisplayResult.Text =
                txtDisplayResult.Text & dblDistance(intTime) & " m in " & intTime & " seconds" & vbCrLf
        Next

        'display invidual distances
        For intTime = 1 To 4
            txtDisplayResult.Text =
                txtDisplayResult.Text & "During second " & intTime & ", the ball fell " &
                (dblDistance(intTime) - dblDistance(intTime - 1)) & " m" & vbCrLf
        Next

        'Console.WriteLine(dblDistance(0))
        'Console.WriteLine(dblDistance(1))
        'Console.WriteLine(dblDistance(2))
        'Console.WriteLine(dblDistance(3))
        'Console.WriteLine(dblDistance(4))

    End Sub
End Class
