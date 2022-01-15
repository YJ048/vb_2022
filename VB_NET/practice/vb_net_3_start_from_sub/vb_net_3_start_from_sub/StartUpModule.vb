Module StartUpModule
    Public Sub Main()
        MessageBox.Show("In Sub Main", "Sub Main",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information)

        Dim frm As New Form1
        frm.Show()

        MessageBox.Show("Done", "Done",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information)
    End Sub
End Module
