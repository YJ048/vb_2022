Public Class Dialog
    Private Sub Dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Text = "Click Me" 'Set the name of button  
        Me.Text = "javatpoint.com" ' Set the title name for the Windows Form  
        Button1.BackColor = Color.Green ' Background color of the button  
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result1 As DialogResult = MessageBox.Show("Is VB.NET programming language easy to learn?",
    "Important Question",
    MessageBoxButtons.YesNo)
    End Sub
End Class
