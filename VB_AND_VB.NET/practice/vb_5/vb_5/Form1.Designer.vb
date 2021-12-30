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
        Me.SuspendLayout()
        '
        'btnPassValue
        '
        Me.btnPassValue.Location = New System.Drawing.Point(22, 26)
        Me.btnPassValue.Name = "btnPassValue"
        Me.btnPassValue.Size = New System.Drawing.Size(215, 59)
        Me.btnPassValue.TabIndex = 0
        Me.btnPassValue.Text = "Pass Values"
        Me.btnPassValue.UseVisualStyleBackColor = True
        '
        'txtNumber1
        '
        Me.txtNumber1.Location = New System.Drawing.Point(22, 123)
        Me.txtNumber1.Name = "txtNumber1"
        Me.txtNumber1.Size = New System.Drawing.Size(100, 22)
        Me.txtNumber1.TabIndex = 1
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(137, 123)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(100, 22)
        Me.txtResult.TabIndex = 2
        '
        'lblSum
        '
        Me.lblSum.AutoSize = True
        Me.lblSum.Location = New System.Drawing.Point(168, 100)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(69, 16)
        Me.lblSum.TabIndex = 3
        Me.lblSum.Text = "Sum result"
        '
        'lblContent
        '
        Me.lblContent.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lblContent.Location = New System.Drawing.Point(134, 161)
        Me.lblContent.Name = "lblContent"
        Me.lblContent.Size = New System.Drawing.Size(115, 36)
        Me.lblContent.TabIndex = 6
        Me.lblContent.Text = "Variable contents after call"
        Me.lblContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtOrigVars
        '
        Me.txtOrigVars.Location = New System.Drawing.Point(137, 200)
        Me.txtOrigVars.Name = "txtOrigVars"
        Me.txtOrigVars.Size = New System.Drawing.Size(100, 22)
        Me.txtOrigVars.TabIndex = 5
        '
        'txtNumber2
        '
        Me.txtNumber2.Location = New System.Drawing.Point(22, 200)
        Me.txtNumber2.Name = "txtNumber2"
        Me.txtNumber2.Size = New System.Drawing.Size(100, 22)
        Me.txtNumber2.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
End Class
