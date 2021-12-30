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
        Me.txtWhileResult = New System.Windows.Forms.TextBox()
        Me.txtDoResult = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtForResult = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtNestedLoop = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Firebrick
        Me.Button1.Location = New System.Drawing.Point(39, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 59)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "While Demo"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtWhileResult
        '
        Me.txtWhileResult.Location = New System.Drawing.Point(38, 103)
        Me.txtWhileResult.Multiline = True
        Me.txtWhileResult.Name = "txtWhileResult"
        Me.txtWhileResult.Size = New System.Drawing.Size(133, 325)
        Me.txtWhileResult.TabIndex = 1
        '
        'txtDoResult
        '
        Me.txtDoResult.Location = New System.Drawing.Point(217, 103)
        Me.txtDoResult.Multiline = True
        Me.txtDoResult.Name = "txtDoResult"
        Me.txtDoResult.Size = New System.Drawing.Size(133, 325)
        Me.txtDoResult.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Firebrick
        Me.Button2.Location = New System.Drawing.Point(218, 23)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(133, 59)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Do Demo"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txtForResult
        '
        Me.txtForResult.Location = New System.Drawing.Point(401, 103)
        Me.txtForResult.Multiline = True
        Me.txtForResult.Name = "txtForResult"
        Me.txtForResult.Size = New System.Drawing.Size(133, 325)
        Me.txtForResult.TabIndex = 5
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Firebrick
        Me.Button3.Location = New System.Drawing.Point(402, 23)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(133, 59)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "For Demo"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txtNestedLoop
        '
        Me.txtNestedLoop.Location = New System.Drawing.Point(575, 129)
        Me.txtNestedLoop.Name = "txtNestedLoop"
        Me.txtNestedLoop.Size = New System.Drawing.Size(133, 22)
        Me.txtNestedLoop.TabIndex = 7
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Firebrick
        Me.Button4.Location = New System.Drawing.Point(575, 23)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(133, 59)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Nested Demo"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(572, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nested Loop Example"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 585)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNestedLoop)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.txtForResult)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtDoResult)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtWhileResult)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txtWhileResult As TextBox
    Friend WithEvents txtDoResult As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents txtForResult As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents txtNestedLoop As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
End Class
