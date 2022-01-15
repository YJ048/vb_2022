Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        ' Method 1 - If Construct
        'Dim dbIncome As Double
        'Dim dbTaxRate As Double
        'Dim dbTax As Double

        'dbIncome = CDbl(txtIncome.Text)

        'If dbIncome <= 30000 Then
        '    dbTaxRate = 0.02
        '    If dbIncome <= 20000 Then
        '        dbTax = 0
        '    Else
        '        dbTax = (dbIncome - 20000) * dbTaxRate
        '    End If
        'End If

        ' Condition: 20000 < dbIncome <= 30000
        ' This condition is forever True as the comparison operator do not work this way

        'If dbIncome > 20000 And dbIncome <= 30000 Then
        '    dbTaxRate = 0.02
        '    dbTax = (dbIncome - 20000) * dbTaxRate
        'ElseIf dbIncome <= 40000 Then
        '    dbTaxRate = 0.035
        '    dbTax = (dbIncome - 30000) * dbTaxRate + 200
        'End If

        'txtTax.Text = dbTax

        ' Method 2 - If Construct with 1D Array
        'Dim dbIncome As Double
        'Dim dbTaxRate(2) As Double
        'Dim dbTax As Double

        'dbIncome = CDbl(txtIncome.Text)

        'dbTaxRate(0) = 0.02
        'dbTaxRate(1) = 0.035
        'dbTaxRate(2) = 0.07

        'If dbIncome > 20000 And dbIncome <= 30000 Then
        '    dbTax = (dbIncome - 20000) * dbTaxRate(0)
        'ElseIf dbIncome <= 40000 Then
        '    dbTax = (dbIncome - 30000) * dbTaxRate(1) + 200
        'ElseIf dbIncome <= 80000 Then
        '    dbTax = (dbIncome - 40000) * dbTaxRate(2) + 550
        'End If

        'txtTax.Text = dbTax

        ' Method 3 - IIf Construct with 1D Array
        'Dim dbIncome As Double
        'Dim dbTaxRate(2) As Double
        'Dim dbTax As Double

        'dbIncome = CDbl(txtIncome.Text)

        'dbTaxRate(0) = 0.02
        'dbTaxRate(1) = 0.035
        'dbTaxRate(2) = 0.07

        'dbTax = IIf(dbIncome >= 30000, 10000 * dbTaxRate(0), Math.Max(0, (dbIncome - 20000) * dbTaxRate(0))) +
        '        IIf(dbIncome >= 40000, 10000 * dbTaxRate(1), Math.Max(0, (dbIncome - 30000) * dbTaxRate(1))) +
        '        IIf(dbIncome >= 80000, 40000 * dbTaxRate(2), Math.Max(0, (dbIncome - 40000) * dbTaxRate(2)))

        'txtTax.Text = dbTax

        'Method 4 - For Loop with 2D Array
        Dim dbIncome As Double
        Dim adbTaxValueRate(2, 2) As Double
        Dim dbTax As Double

        dbIncome = CDbl(txtIncome.Text)

        adbTaxValueRate(0, 0) = 20000
        adbTaxValueRate(1, 0) = 10000
        adbTaxValueRate(2, 0) = 0.02

        adbTaxValueRate(0, 1) = 30000
        adbTaxValueRate(1, 1) = 10000
        adbTaxValueRate(2, 1) = 0.035

        adbTaxValueRate(0, 2) = 40000
        adbTaxValueRate(1, 2) = 40000
        adbTaxValueRate(2, 2) = 0.07

        For y = 0 To 2
            If dbIncome >= (adbTaxValueRate(0, y) + adbTaxValueRate(0, y)) Then
                dbTax = dbTax + adbTaxValueRate(2, y) * adbTaxValueRate(1, y)
            Else
                dbTax = dbTax + ((dbIncome - adbTaxValueRate(0, y)) * adbTaxValueRate(2, y))
                Exit For
            End If
        Next

        txtTax.Text = dbTax

        'Method 5 - While Loop with 2D Array
        'While income is positive, calculate Tax according to incremental value & tax rates

    End Sub

End Class

