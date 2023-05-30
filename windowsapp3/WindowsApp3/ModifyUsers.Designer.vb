<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModifyUsers
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
        Me.AddUser = New System.Windows.Forms.Button()
        Me.List_of_users = New System.Windows.Forms.Button()
        Me.Modify_Delete_User = New System.Windows.Forms.Button()
        Me.Back = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AddUser
        '
        Me.AddUser.Location = New System.Drawing.Point(191, 69)
        Me.AddUser.Name = "AddUser"
        Me.AddUser.Size = New System.Drawing.Size(171, 39)
        Me.AddUser.TabIndex = 0
        Me.AddUser.Text = "Create A New User"
        Me.AddUser.UseVisualStyleBackColor = True
        '
        'List_of_users
        '
        Me.List_of_users.Location = New System.Drawing.Point(191, 263)
        Me.List_of_users.Name = "List_of_users"
        Me.List_of_users.Size = New System.Drawing.Size(171, 41)
        Me.List_of_users.TabIndex = 0
        Me.List_of_users.Text = "View List Of All Users"
        Me.List_of_users.UseVisualStyleBackColor = True
        '
        'Modify_Delete_User
        '
        Me.Modify_Delete_User.Location = New System.Drawing.Point(191, 163)
        Me.Modify_Delete_User.Name = "Modify_Delete_User"
        Me.Modify_Delete_User.Size = New System.Drawing.Size(171, 40)
        Me.Modify_Delete_User.TabIndex = 0
        Me.Modify_Delete_User.Text = "Modify/Delete User"
        Me.Modify_Delete_User.UseVisualStyleBackColor = True
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(13, 3)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(75, 23)
        Me.Back.TabIndex = 1
        Me.Back.Text = "<"
        Me.Back.UseVisualStyleBackColor = True
        '
        'ModifyUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 405)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Modify_Delete_User)
        Me.Controls.Add(Me.List_of_users)
        Me.Controls.Add(Me.AddUser)
        Me.Name = "ModifyUsers"
        Me.Text = "ModifyUsers"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AddUser As Button
    Friend WithEvents List_of_users As Button
    Friend WithEvents Modify_Delete_User As Button
    Friend WithEvents Back As Button
End Class
