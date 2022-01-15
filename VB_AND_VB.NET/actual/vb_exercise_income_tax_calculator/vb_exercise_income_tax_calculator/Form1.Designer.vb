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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtIncome = New System.Windows.Forms.TextBox()
        Me.lblIncome = New System.Windows.Forms.Label()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(285, 97)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(374, 65)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate Tax"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtIncome
        '
        Me.txtIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIncome.Location = New System.Drawing.Point(265, 16)
        Me.txtIncome.Name = "txtIncome"
        Me.txtIncome.Size = New System.Drawing.Size(394, 45)
        Me.txtIncome.TabIndex = 1
        '
        'lblIncome
        '
        Me.lblIncome.AutoSize = True
        Me.lblIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncome.Location = New System.Drawing.Point(37, 22)
        Me.lblIncome.Name = "lblIncome"
        Me.lblIncome.Size = New System.Drawing.Size(201, 38)
        Me.lblIncome.TabIndex = 2
        Me.lblIncome.Text = "Your Income"
        '
        'txtTax
        '
        Me.txtTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTax.Location = New System.Drawing.Point(428, 193)
        Me.txtTax.Multiline = True
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(229, 245)
        Me.txtTax.TabIndex = 3
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(37, 193)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(327, 38)
        Me.lblTax.TabIndex = 4
        Me.lblTax.Text = "Your Chargeable Tax"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.lblIncome)
        Me.Controls.Add(Me.txtIncome)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtIncome As TextBox
    Friend WithEvents lblIncome As Label
    Friend WithEvents txtTax As TextBox
    Friend WithEvents lblTax As Label
End Class
