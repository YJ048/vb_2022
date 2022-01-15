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
        Me.txtSingle = New System.Windows.Forms.TextBox()
        Me.txtMultiple = New System.Windows.Forms.TextBox()
        Me.btnClick = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtSingle
        '
        Me.txtSingle.Location = New System.Drawing.Point(54, 156)
        Me.txtSingle.Name = "txtSingle"
        Me.txtSingle.Size = New System.Drawing.Size(134, 22)
        Me.txtSingle.TabIndex = 0
        '
        'txtMultiple
        '
        Me.txtMultiple.Location = New System.Drawing.Point(267, 156)
        Me.txtMultiple.Multiline = True
        Me.txtMultiple.Name = "txtMultiple"
        Me.txtMultiple.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMultiple.Size = New System.Drawing.Size(254, 135)
        Me.txtMultiple.TabIndex = 1
        '
        'btnClick
        '
        Me.btnClick.Location = New System.Drawing.Point(54, 47)
        Me.btnClick.Name = "btnClick"
        Me.btnClick.Size = New System.Drawing.Size(240, 57)
        Me.btnClick.TabIndex = 2
        Me.btnClick.Text = "Click"
        Me.btnClick.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClick)
        Me.Controls.Add(Me.txtMultiple)
        Me.Controls.Add(Me.txtSingle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSingle As TextBox
    Friend WithEvents txtMultiple As TextBox
    Friend WithEvents btnClick As Button
End Class
