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
        Me.lblCentigrade = New System.Windows.Forms.Label()
        Me.lblFahrenheit = New System.Windows.Forms.Label()
        Me.txtCentigrade = New System.Windows.Forms.TextBox()
        Me.txtFahrenheit = New System.Windows.Forms.TextBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCentigrade
        '
        Me.lblCentigrade.AutoSize = True
        Me.lblCentigrade.Location = New System.Drawing.Point(169, 85)
        Me.lblCentigrade.Name = "lblCentigrade"
        Me.lblCentigrade.Size = New System.Drawing.Size(73, 16)
        Me.lblCentigrade.TabIndex = 0
        Me.lblCentigrade.Text = "Centigrade"
        '
        'lblFahrenheit
        '
        Me.lblFahrenheit.AutoSize = True
        Me.lblFahrenheit.Location = New System.Drawing.Point(313, 85)
        Me.lblFahrenheit.Name = "lblFahrenheit"
        Me.lblFahrenheit.Size = New System.Drawing.Size(70, 16)
        Me.lblFahrenheit.TabIndex = 1
        Me.lblFahrenheit.Text = "Fahrenheit"
        '
        'txtCentigrade
        '
        Me.txtCentigrade.Location = New System.Drawing.Point(163, 119)
        Me.txtCentigrade.Name = "txtCentigrade"
        Me.txtCentigrade.Size = New System.Drawing.Size(88, 22)
        Me.txtCentigrade.TabIndex = 2
        '
        'txtFahrenheit
        '
        Me.txtFahrenheit.Location = New System.Drawing.Point(304, 119)
        Me.txtFahrenheit.Name = "txtFahrenheit"
        Me.txtFahrenheit.Size = New System.Drawing.Size(88, 22)
        Me.txtFahrenheit.TabIndex = 3
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(163, 162)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(238, 32)
        Me.btnConvert.TabIndex = 4
        Me.btnConvert.Text = "CONVERT"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txtFahrenheit)
        Me.Controls.Add(Me.txtCentigrade)
        Me.Controls.Add(Me.lblFahrenheit)
        Me.Controls.Add(Me.lblCentigrade)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCentigrade As Label
    Friend WithEvents lblFahrenheit As Label
    Friend WithEvents txtCentigrade As TextBox
    Friend WithEvents txtFahrenheit As TextBox
    Friend WithEvents btnConvert As Button
End Class
