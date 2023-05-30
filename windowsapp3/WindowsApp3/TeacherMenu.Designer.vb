<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeacherMenu
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
        Me.Modify_Users = New System.Windows.Forms.Button()
        Me.Modify_Questions = New System.Windows.Forms.Button()
        Me.View_Statistics = New System.Windows.Forms.Button()
        Me.Change_Pass = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Modify_Users
        '
        Me.Modify_Users.Location = New System.Drawing.Point(67, 96)
        Me.Modify_Users.Name = "Modify_Users"
        Me.Modify_Users.Size = New System.Drawing.Size(187, 40)
        Me.Modify_Users.TabIndex = 0
        Me.Modify_Users.Text = "Modify Users"
        Me.Modify_Users.UseVisualStyleBackColor = True
        '
        'Modify_Questions
        '
        Me.Modify_Questions.Location = New System.Drawing.Point(67, 142)
        Me.Modify_Questions.Name = "Modify_Questions"
        Me.Modify_Questions.Size = New System.Drawing.Size(187, 40)
        Me.Modify_Questions.TabIndex = 2
        Me.Modify_Questions.Text = "Modify Questions"
        Me.Modify_Questions.UseVisualStyleBackColor = True
        '
        'View_Statistics
        '
        Me.View_Statistics.Location = New System.Drawing.Point(67, 188)
        Me.View_Statistics.Name = "View_Statistics"
        Me.View_Statistics.Size = New System.Drawing.Size(187, 40)
        Me.View_Statistics.TabIndex = 3
        Me.View_Statistics.Text = "View Statistics"
        Me.View_Statistics.UseVisualStyleBackColor = True
        '
        'Change_Pass
        '
        Me.Change_Pass.Location = New System.Drawing.Point(67, 234)
        Me.Change_Pass.Name = "Change_Pass"
        Me.Change_Pass.Size = New System.Drawing.Size(187, 40)
        Me.Change_Pass.TabIndex = 5
        Me.Change_Pass.Text = "Change you password"
        Me.Change_Pass.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.DarkGreen
        Me.TextBox1.Location = New System.Drawing.Point(53, 44)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(220, 22)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Text = "Welcome, Teacher!"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(1, 2)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "Log Out"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'TeacherMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 379)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Change_Pass)
        Me.Controls.Add(Me.View_Statistics)
        Me.Controls.Add(Me.Modify_Questions)
        Me.Controls.Add(Me.Modify_Users)
        Me.Name = "TeacherMenu"
        Me.Text = "TeacherMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Modify_Users As Button
    Friend WithEvents Modify_Questions As Button
    Friend WithEvents View_Statistics As Button
    Friend WithEvents Change_Pass As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button7 As Button
End Class
