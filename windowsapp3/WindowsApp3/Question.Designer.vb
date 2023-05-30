<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Question
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
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Option3 = New System.Windows.Forms.Button()
        Me.Option2 = New System.Windows.Forms.Button()
        Me.Option1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(536, 26)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Question 1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 44)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(536, 78)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'Option3
        '
        Me.Option3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Option3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Option3.Location = New System.Drawing.Point(77, 294)
        Me.Option3.Name = "Option3"
        Me.Option3.Size = New System.Drawing.Size(382, 66)
        Me.Option3.TabIndex = 2
        Me.Option3.Text = "Button1"
        Me.Option3.UseVisualStyleBackColor = False
        '
        'Option2
        '
        Me.Option2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Option2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Option2.Location = New System.Drawing.Point(77, 211)
        Me.Option2.Name = "Option2"
        Me.Option2.Size = New System.Drawing.Size(382, 66)
        Me.Option2.TabIndex = 2
        Me.Option2.Text = "Button1"
        Me.Option2.UseVisualStyleBackColor = False
        '
        'Option1
        '
        Me.Option1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Option1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Option1.Location = New System.Drawing.Point(77, 128)
        Me.Option1.Name = "Option1"
        Me.Option1.Size = New System.Drawing.Size(382, 66)
        Me.Option1.TabIndex = 2
        Me.Option1.Text = "Button1"
        Me.Option1.UseVisualStyleBackColor = False
        '
        'Question
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(560, 401)
        Me.Controls.Add(Me.Option1)
        Me.Controls.Add(Me.Option2)
        Me.Controls.Add(Me.Option3)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Question"
        Me.Text = "Question"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Option3 As Button
    Friend WithEvents Option2 As Button
    Friend WithEvents Option1 As Button
End Class
