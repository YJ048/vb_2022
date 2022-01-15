Public Class Form1
    Private Sub Convert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim dbInput As Double
        Dim intDecimal As Integer
        Dim dbOutput As Double

        dbInput = txtInput.Text
        intDecimal = txtDecimal.Text

        'Method 1 - Math.Round
        dbOutput = Math.Round(dbInput, intDecimal)

        txtOutputM1.Text = dbOutput

        'Method 2 - Strings.Format

        Dim strOutput As String
        Dim strFormat As String

        strFormat = "." & Strings.StrDup(intDecimal, "0")
        ' For Example - intDecimal = 3
        ' strFormat = ".000"

        strOutput = Strings.Format(dbInput, strFormat)
        txtOutputM2.Text = strOutput

        'Method 3 - Strings.FormatNumber

        strOutput = Strings.FormatNumber(dbInput, intDecimal)
        txtOutputM3.Text = strOutput

        'Method 4 - For Loop & If Loop
        Dim strInput As String
        strInput = CStr(dbInput)

        Dim strSeparated As String()
        Dim strFront As String
        Dim strBack As String
        Dim strKeep As String = ""
        Dim intCounter As Integer

        ' Separate Into 2 Strings
        strSeparated = Strings.Split(strInput, ".")
        strFront = strSeparated(0)
        strBack = strSeparated(1)

        For Each c As Char In strBack
            If intCounter = intDecimal Then
                Exit For
            Else
                intCounter = intCounter + 1
                strKeep = strKeep + c
            End If
        Next

        txtOutputM4.Text = strFront + "." + strKeep

        ' Method 5 - Truncating
        Dim dblInputNbrForTruncation As Double

        dblInputNbrForTruncation = CDbl(txtInput.Text)

        Dim dblTruncatedOutput As Double
        Dim dblDivisor As Double

        dblDivisor = Math.Pow(0.1, CDbl(intDecimal))

        dblTruncatedOutput = dblInputNbrForTruncation - (dblInputNbrForTruncation Mod dblDivisor)

        txtOutputM5.Text = CStr(dblTruncatedOutput)

    End Sub
End Class
