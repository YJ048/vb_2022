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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.btnInputName = New System.Windows.Forms.Button()
        Me.btnID = New System.Windows.Forms.Button()
        Me.btnResult = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(39, 36)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(124, 22)
        Me.txtName.TabIndex = 0
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(39, 99)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(124, 22)
        Me.txtID.TabIndex = 1
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(39, 157)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(124, 22)
        Me.txtResult.TabIndex = 2
        '
        'btnInputName
        '
        Me.btnInputName.Location = New System.Drawing.Point(198, 36)
        Me.btnInputName.Name = "btnInputName"
        Me.btnInputName.Size = New System.Drawing.Size(96, 41)
        Me.btnInputName.TabIndex = 3
        Me.btnInputName.Text = "Input Name"
        Me.btnInputName.UseVisualStyleBackColor = True
        '
        'btnID
        '
        Me.btnID.Location = New System.Drawing.Point(198, 99)
        Me.btnID.Name = "btnID"
        Me.btnID.Size = New System.Drawing.Size(96, 41)
        Me.btnID.TabIndex = 4
        Me.btnID.Text = "Input ID"
        Me.btnID.UseVisualStyleBackColor = True
        '
        'btnResult
        '
        Me.btnResult.Location = New System.Drawing.Point(198, 157)
        Me.btnResult.Name = "btnResult"
        Me.btnResult.Size = New System.Drawing.Size(96, 41)
        Me.btnResult.TabIndex = 5
        Me.btnResult.Text = "button result"
        Me.btnResult.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnResult)
        Me.Controls.Add(Me.btnID)
        Me.Controls.Add(Me.btnInputName)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents btnInputName As Button
    Friend WithEvents btnID As Button
    Friend WithEvents btnResult As Button
End Class
