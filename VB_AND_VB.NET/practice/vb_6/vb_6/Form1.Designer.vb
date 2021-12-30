<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnPassValue = New System.Windows.Forms.Button()
        Me.txtNumber1 = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.lblSum = New System.Windows.Forms.Label()
        Me.lblContent = New System.Windows.Forms.Label()
        Me.txtOrigVars = New System.Windows.Forms.TextBox()
        Me.txtNumber2 = New System.Windows.Forms.TextBox()
        Me.btnPassArray = New System.Windows.Forms.Button()
        Me.lblOriginal = New System.Windows.Forms.Label()
        Me.txtInitialData = New System.Windows.Forms.TextBox()
        Me.lblArraySum = New System.Windows.Forms.Label()
        Me.txtDisplaySum = New System.Windows.Forms.TextBox()
        Me.lblSortReverse = New System.Windows.Forms.Label()
        Me.txtDisplayArray = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnPassValue
        '
        Me.btnPassValue.Location = New System.Drawing.Point(510, 23)
        Me.btnPassValue.Name = "btnPassValue"
        Me.btnPassValue.Size = New System.Drawing.Size(215, 59)
        Me.btnPassValue.TabIndex = 0
        Me.btnPassValue.Text = "Pass Values"
        Me.btnPassValue.UseVisualStyleBackColor = True
        '
        'txtNumber1
        '
        Me.txtNumber1.Location = New System.Drawing.Point(510, 120)
        Me.txtNumber1.Name = "txtNumber1"
        Me.txtNumber1.Size = New System.Drawing.Size(100, 22)
        Me.txtNumber1.TabIndex = 1
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(625, 120)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(100, 22)
        Me.txtResult.TabIndex = 2
        '
        'lblSum
        '
        Me.lblSum.AutoSize = True
        Me.lblSum.Location = New System.Drawing.Point(656, 97)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(69, 16)
        Me.lblSum.TabIndex = 3
        Me.lblSum.Text = "Sum result"
        '
        'lblContent
        '
        Me.lblContent.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lblContent.Location = New System.Drawing.Point(622, 158)
        Me.lblContent.Name = "lblContent"
        Me.lblContent.Size = New System.Drawing.Size(115, 36)
        Me.lblContent.TabIndex = 6
        Me.lblContent.Text = "Variable contents after call"
        Me.lblContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtOrigVars
        '
        Me.txtOrigVars.Location = New System.Drawing.Point(625, 197)
        Me.txtOrigVars.Name = "txtOrigVars"
        Me.txtOrigVars.Size = New System.Drawing.Size(100, 22)
        Me.txtOrigVars.TabIndex = 5
        '
        'txtNumber2
        '
        Me.txtNumber2.Location = New System.Drawing.Point(510, 197)
        Me.txtNumber2.Name = "txtNumber2"
        Me.txtNumber2.Size = New System.Drawing.Size(100, 22)
        Me.txtNumber2.TabIndex = 4
        '
        'btnPassArray
        '
        Me.btnPassArray.Location = New System.Drawing.Point(52, 27)
        Me.btnPassArray.Name = "btnPassArray"
        Me.btnPassArray.Size = New System.Drawing.Size(328, 54)
        Me.btnPassArray.TabIndex = 7
        Me.btnPassArray.Text = "Pass Array"
        Me.btnPassArray.UseVisualStyleBackColor = True
        '
        'lblOriginal
        '
        Me.lblOriginal.AutoSize = True
        Me.lblOriginal.Location = New System.Drawing.Point(58, 97)
        Me.lblOriginal.Name = "lblOriginal"
        Me.lblOriginal.Size = New System.Drawing.Size(85, 16)
        Me.lblOriginal.TabIndex = 8
        Me.lblOriginal.Text = "Original Data"
        '
        'txtInitialData
        '
        Me.txtInitialData.Location = New System.Drawing.Point(52, 122)
        Me.txtInitialData.Multiline = True
        Me.txtInitialData.Name = "txtInitialData"
        Me.txtInitialData.Size = New System.Drawing.Size(91, 268)
        Me.txtInitialData.TabIndex = 9
        '
        'lblArraySum
        '
        Me.lblArraySum.AutoSize = True
        Me.lblArraySum.Location = New System.Drawing.Point(162, 97)
        Me.lblArraySum.Name = "lblArraySum"
        Me.lblArraySum.Size = New System.Drawing.Size(92, 16)
        Me.lblArraySum.TabIndex = 10
        Me.lblArraySum.Text = "Returned Sum"
        '
        'txtDisplaySum
        '
        Me.txtDisplaySum.Location = New System.Drawing.Point(165, 122)
        Me.txtDisplaySum.Name = "txtDisplaySum"
        Me.txtDisplaySum.Size = New System.Drawing.Size(88, 22)
        Me.txtDisplaySum.TabIndex = 11
        '
        'lblSortReverse
        '
        Me.lblSortReverse.AutoSize = True
        Me.lblSortReverse.Location = New System.Drawing.Point(276, 100)
        Me.lblSortReverse.Name = "lblSortReverse"
        Me.lblSortReverse.Size = New System.Drawing.Size(86, 16)
        Me.lblSortReverse.TabIndex = 12
        Me.lblSortReverse.Text = "Sort Reverse"
        '
        'txtDisplayArray
        '
        Me.txtDisplayArray.Location = New System.Drawing.Point(279, 122)
        Me.txtDisplayArray.Multiline = True
        Me.txtDisplayArray.Name = "txtDisplayArray"
        Me.txtDisplayArray.Size = New System.Drawing.Size(91, 268)
        Me.txtDisplayArray.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtDisplayArray)
        Me.Controls.Add(Me.lblSortReverse)
        Me.Controls.Add(Me.txtDisplaySum)
        Me.Controls.Add(Me.lblArraySum)
        Me.Controls.Add(Me.txtInitialData)
        Me.Controls.Add(Me.lblOriginal)
        Me.Controls.Add(Me.btnPassArray)
        Me.Controls.Add(Me.lblContent)
        Me.Controls.Add(Me.txtOrigVars)
        Me.Controls.Add(Me.txtNumber2)
        Me.Controls.Add(Me.lblSum)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txtNumber1)
        Me.Controls.Add(Me.btnPassValue)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPassValue As Button
    Friend WithEvents txtNumber1 As TextBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents lblSum As Label
    Friend WithEvents lblContent As Label
    Friend WithEvents txtOrigVars As TextBox
    Friend WithEvents txtNumber2 As TextBox
    Friend WithEvents btnPassArray As Button
    Friend WithEvents lblOriginal As Label
    Friend WithEvents txtInitialData As TextBox
    Friend WithEvents lblArraySum As Label
    Friend WithEvents txtDisplaySum As TextBox
    Friend WithEvents lblSortReverse As Label
    Friend WithEvents txtDisplayArray As TextBox
End Class
