Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' runs when the program starts

        'Dim date1 As Date
        'date1 = #01/12/2022# 'Declare date in American Format MM/DD/YYYY

        'Output date in MsgBox will be in your computer's Format

        'Dim dateNext As Date
        'dateNext = NextDay()

        'MsgBox(dateNext)

        'ShowDate()

        lstOccupation.Items.Add("Housewife")

    End Sub

    Sub ShowDate()
        MsgBox(Now())
    End Sub

    Function NextDay() As Date
        Dim theNextDay As Date
        theNextDay = DateAdd(DateInterval.Month, 5, Now())
        Return (theNextDay)
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim intInputVar As Integer

        'intInputVar = InputBox("Enter in 1 or 2", "Input")

        'If intInputVar = 1 Or intInputVar = 2 Then
        '    MsgBox("1 or 2 Entered")
        'Else
        '    MsgBox("Invalid")
        'End If

        'MsgBox(IIf(intInputVar = 1 Or intInputVar = 2, "1 or 2 Entered", "Invalid"))
        'IIf(Condition, Value if Condition is True, Value if Condition is False)

        'IIf(intInputVar Mod 3 = 0, IIf(intInputVar Mod 5 = 0, "Divisible by 3 and 5", "Divisible by 3 but not 5"), "Not Divisible by 3")

        Dim stSelected As String

        stSelected = lstOccupation.SelectedItem

        MsgBox(stSelected & " has been selected")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Console.WriteLine(sender.ToString)
        'Console.WriteLine(sender.GetType)

        'Console.WriteLine("Location at " & e.X & e.Y)

    End Sub

    Private Sub Button2_MouseDown(sender As Object, e As MouseEventArgs) Handles Button2.MouseDown
        Console.WriteLine("Location at X axis : " & e.X & " at Y axis : " & e.Y)
    End Sub
End Class
