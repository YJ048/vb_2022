Imports System.IO

Public Class Form1
    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Using sr As StreamReader = File.OpenText(OpenFileDialog1.FileName)
                txtDisplay.Text = sr.ReadToEnd()
            End Using
        End If
    End Sub
End Class
