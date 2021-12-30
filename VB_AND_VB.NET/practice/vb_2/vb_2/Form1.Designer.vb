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
        Me.btnFillArray = New System.Windows.Forms.Button()
        Me.btnFillDynArray = New System.Windows.Forms.Button()
        Me.txtDisplayResult = New System.Windows.Forms.TextBox()
        Me.txtLowerB = New System.Windows.Forms.TextBox()
        Me.txtUpperB = New System.Windows.Forms.TextBox()
        Me.btnGetArrayBounds = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnFillArray
        '
        Me.btnFillArray.Location = New System.Drawing.Point(168, 42)
        Me.btnFillArray.Name = "btnFillArray"
        Me.btnFillArray.Size = New System.Drawing.Size(110, 54)
        Me.btnFillArray.TabIndex = 1
        Me.btnFillArray.Text = "Fill Array"
        Me.btnFillArray.UseVisualStyleBackColor = True
        '
        'btnFillDynArray
        '
        Me.btnFillDynArray.Location = New System.Drawing.Point(166, 127)
        Me.btnFillDynArray.Name = "btnFillDynArray"
        Me.btnFillDynArray.Size = New System.Drawing.Size(111, 56)
        Me.btnFillDynArray.TabIndex = 2
        Me.btnFillDynArray.Text = "Fill Dynamic Array"
        Me.btnFillDynArray.UseVisualStyleBackColor = True
        '
        'txtDisplayResult
        '
        Me.txtDisplayResult.Location = New System.Drawing.Point(39, 39)
        Me.txtDisplayResult.Multiline = True
        Me.txtDisplayResult.Name = "txtDisplayResult"
        Me.txtDisplayResult.Size = New System.Drawing.Size(111, 144)
        Me.txtDisplayResult.TabIndex = 3
        '
        'txtLowerB
        '
        Me.txtLowerB.Location = New System.Drawing.Point(348, 43)
        Me.txtLowerB.Name = "txtLowerB"
        Me.txtLowerB.Size = New System.Drawing.Size(117, 22)
        Me.txtLowerB.TabIndex = 4
        '
        'txtUpperB
        '
        Me.txtUpperB.Location = New System.Drawing.Point(346, 94)
        Me.txtUpperB.Name = "txtUpperB"
        Me.txtUpperB.Size = New System.Drawing.Size(118, 22)
        Me.txtUpperB.TabIndex = 5
        '
        'btnGetArrayBounds
        '
        Me.btnGetArrayBounds.Location = New System.Drawing.Point(498, 43)
        Me.btnGetArrayBounds.Name = "btnGetArrayBounds"
        Me.btnGetArrayBounds.Size = New System.Drawing.Size(114, 72)
        Me.btnGetArrayBounds.TabIndex = 6
        Me.btnGetArrayBounds.Text = "Get Array bounds"
        Me.btnGetArrayBounds.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnGetArrayBounds)
        Me.Controls.Add(Me.txtUpperB)
        Me.Controls.Add(Me.txtLowerB)
        Me.Controls.Add(Me.txtDisplayResult)
        Me.Controls.Add(Me.btnFillDynArray)
        Me.Controls.Add(Me.btnFillArray)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFillArray As Button
    Friend WithEvents btnFillDynArray As Button
    Friend WithEvents txtDisplayResult As TextBox
    Friend WithEvents txtLowerB As TextBox
    Friend WithEvents txtUpperB As TextBox
    Friend WithEvents btnGetArrayBounds As Button
End Class
