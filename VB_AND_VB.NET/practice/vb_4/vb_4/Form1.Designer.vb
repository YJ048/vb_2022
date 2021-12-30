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
        Me.btnIterative = New System.Windows.Forms.Button()
        Me.txtDisplayResult = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(27, 33)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(165, 58)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnIterative
        '
        Me.btnIterative.Location = New System.Drawing.Point(248, 33)
        Me.btnIterative.Name = "btnIterative"
        Me.btnIterative.Size = New System.Drawing.Size(165, 58)
        Me.btnIterative.TabIndex = 1
        Me.btnIterative.Text = "Iterative"
        Me.btnIterative.UseVisualStyleBackColor = True
        '
        'txtDisplayResult
        '
        Me.txtDisplayResult.Location = New System.Drawing.Point(32, 126)
        Me.txtDisplayResult.Multiline = True
        Me.txtDisplayResult.Name = "txtDisplayResult"
        Me.txtDisplayResult.Size = New System.Drawing.Size(380, 226)
        Me.txtDisplayResult.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtDisplayResult)
        Me.Controls.Add(Me.btnIterative)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnIterative As Button
    Friend WithEvents txtDisplayResult As TextBox
End Class
