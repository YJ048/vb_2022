Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intInputVar As Integer

        'intInputVar = InputBox("Enter Any Number", "Input")

        Select Case intInputVar
            Case < 1
                txtText1.Text = "Less than 1"
            Case 2 To 4
                txtText1.Text = "Two, Three, Four Pressed"
            Case 5, 7
                txtText1.Text = "Five or Seven Pressed"
            Case Else
                txtText1.Text = "Invalid Entry"
        End Select

        Dim strInputVar As String

        strInputVar = InputBox("Enter One or Two", "Input")

        'MsgBox(strInputVar.ToUpper() & vbNewLine & strInputVar.ToLower())

        Select Case strInputVar.ToUpper()
            Case "ONE"
                txtText1.Text = "One Pressed"
            Case "TWO"
                txtText1.Text = "Two Pressed"
            Case Else
                txtText1.Text = "Invalid Entry"
        End Select
    End Sub
End Class
