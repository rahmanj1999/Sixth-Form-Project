<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePass
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.PASS = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Back = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(61, 105)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(176, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Enter a new password"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(308, 105)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(8, 20)
        Me.MaskedTextBox1.TabIndex = 1
        '
        'PASS
        '
        Me.PASS.Location = New System.Drawing.Point(61, 131)
        Me.PASS.Name = "PASS"
        Me.PASS.Size = New System.Drawing.Size(176, 20)
        Me.PASS.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(112, 157)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(0, 0)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(75, 23)
        Me.Back.TabIndex = 3
        Me.Back.Text = "<"
        Me.Back.UseVisualStyleBackColor = True
        '
        'ChangePass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 261)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.PASS)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "ChangePass"
        Me.Text = "ChangePass"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents PASS As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Back As Button
End Class
