<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Details
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.FirstName = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.LastName = New System.Windows.Forms.TextBox()
        Me.CreateUser = New System.Windows.Forms.Button()
        Me.UpdateUser = New System.Windows.Forms.Button()
        Me.DeleteUser = New System.Windows.Forms.Button()
        Me.SearchUser = New System.Windows.Forms.Button()
        Me.Back = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(197, 51)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 13)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Username"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Username
        '
        Me.Username.Location = New System.Drawing.Point(142, 70)
        Me.Username.MaxLength = 20
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(217, 20)
        Me.Username.TabIndex = 0
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Location = New System.Drawing.Point(197, 94)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(100, 13)
        Me.TextBox3.TabIndex = 0
        Me.TextBox3.Text = "Password"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox3.Visible = False
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(142, 113)
        Me.Password.MaxLength = 20
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(217, 20)
        Me.Password.TabIndex = 0
        Me.Password.Visible = False
        '
        'TextBox5
        '
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Location = New System.Drawing.Point(197, 144)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(100, 13)
        Me.TextBox5.TabIndex = 0
        Me.TextBox5.Text = "FirstName"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox5.Visible = False
        '
        'FirstName
        '
        Me.FirstName.Location = New System.Drawing.Point(142, 163)
        Me.FirstName.MaxLength = 20
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(217, 20)
        Me.FirstName.TabIndex = 0
        Me.FirstName.Visible = False
        '
        'TextBox7
        '
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox7.Location = New System.Drawing.Point(197, 192)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(100, 13)
        Me.TextBox7.TabIndex = 0
        Me.TextBox7.Text = "LastName"
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox7.Visible = False
        '
        'LastName
        '
        Me.LastName.Location = New System.Drawing.Point(142, 211)
        Me.LastName.MaxLength = 20
        Me.LastName.Name = "LastName"
        Me.LastName.Size = New System.Drawing.Size(217, 20)
        Me.LastName.TabIndex = 0
        Me.LastName.Visible = False
        '
        'CreateUser
        '
        Me.CreateUser.Location = New System.Drawing.Point(207, 261)
        Me.CreateUser.Name = "CreateUser"
        Me.CreateUser.Size = New System.Drawing.Size(75, 48)
        Me.CreateUser.TabIndex = 1
        Me.CreateUser.Text = "Add User"
        Me.CreateUser.UseVisualStyleBackColor = True
        Me.CreateUser.Visible = False
        '
        'UpdateUser
        '
        Me.UpdateUser.Location = New System.Drawing.Point(288, 261)
        Me.UpdateUser.Name = "UpdateUser"
        Me.UpdateUser.Size = New System.Drawing.Size(75, 48)
        Me.UpdateUser.TabIndex = 1
        Me.UpdateUser.Text = "Update User"
        Me.UpdateUser.UseVisualStyleBackColor = True
        Me.UpdateUser.Visible = False
        '
        'DeleteUser
        '
        Me.DeleteUser.Location = New System.Drawing.Point(126, 261)
        Me.DeleteUser.Name = "DeleteUser"
        Me.DeleteUser.Size = New System.Drawing.Size(75, 48)
        Me.DeleteUser.TabIndex = 1
        Me.DeleteUser.Text = "Delete User"
        Me.DeleteUser.UseVisualStyleBackColor = True
        Me.DeleteUser.Visible = False
        '
        'SearchUser
        '
        Me.SearchUser.Location = New System.Drawing.Point(388, 59)
        Me.SearchUser.Name = "SearchUser"
        Me.SearchUser.Size = New System.Drawing.Size(75, 48)
        Me.SearchUser.TabIndex = 1
        Me.SearchUser.Text = "Search User"
        Me.SearchUser.UseVisualStyleBackColor = True
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(-1, 0)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(75, 23)
        Me.Back.TabIndex = 2
        Me.Back.Text = "<"
        Me.Back.UseVisualStyleBackColor = True
        '
        'Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 405)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.SearchUser)
        Me.Controls.Add(Me.DeleteUser)
        Me.Controls.Add(Me.UpdateUser)
        Me.Controls.Add(Me.CreateUser)
        Me.Controls.Add(Me.LastName)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.FirstName)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Details"
        Me.Text = "Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Username As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Password As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents FirstName As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents LastName As TextBox
    Friend WithEvents CreateUser As Button
    Friend WithEvents UpdateUser As Button
    Friend WithEvents DeleteUser As Button
    Friend WithEvents SearchUser As Button
    Friend WithEvents Back As Button
End Class
