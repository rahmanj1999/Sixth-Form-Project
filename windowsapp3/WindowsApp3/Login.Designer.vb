<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.components = New System.ComponentModel.Container()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Username
        '
        Me.Username.Location = New System.Drawing.Point(114, 21)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(158, 20)
        Me.Username.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(12, 21)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(96, 13)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Text = "Username"
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(114, 47)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(158, 20)
        Me.Password.TabIndex = 0
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Location = New System.Drawing.Point(12, 47)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(96, 13)
        Me.TextBox4.TabIndex = 2
        Me.TextBox4.Text = "Password"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(114, 98)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Login"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 132)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Username)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Username As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Password As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button2 As Button
End Class
