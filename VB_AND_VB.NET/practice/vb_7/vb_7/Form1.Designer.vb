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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtText1 = New System.Windows.Forms.TextBox()
        Me.txtMultipleCase = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtText2 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LimeGreen
        Me.Button1.Location = New System.Drawing.Point(50, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 51)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Get Input"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtText1
        '
        Me.txtText1.Location = New System.Drawing.Point(50, 103)
        Me.txtText1.Multiline = True
        Me.txtText1.Name = "txtText1"
        Me.txtText1.Size = New System.Drawing.Size(176, 44)
        Me.txtText1.TabIndex = 1
        '
        'txtMultipleCase
        '
        Me.txtMultipleCase.Location = New System.Drawing.Point(275, 103)
        Me.txtMultipleCase.Multiline = True
        Me.txtMultipleCase.Name = "txtMultipleCase"
        Me.txtMultipleCase.Size = New System.Drawing.Size(176, 44)
        Me.txtMultipleCase.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LimeGreen
        Me.Button2.Location = New System.Drawing.Point(275, 29)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(177, 51)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Multiple Inputs"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txtText2
        '
        Me.txtText2.Location = New System.Drawing.Point(50, 268)
        Me.txtText2.Multiline = True
        Me.txtText2.Name = "txtText2"
        Me.txtText2.Size = New System.Drawing.Size(176, 44)
        Me.txtText2.TabIndex = 5
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LimeGreen
        Me.Button3.Location = New System.Drawing.Point(50, 194)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(177, 51)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Select Case"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtText2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtMultipleCase)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtText1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txtText1 As TextBox
    Friend WithEvents txtMultipleCase As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents txtText2 As TextBox
    Friend WithEvents Button3 As Button
End Class
