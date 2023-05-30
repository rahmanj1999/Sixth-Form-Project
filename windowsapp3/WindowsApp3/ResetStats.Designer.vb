<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResetStats
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
        Me.Yes = New System.Windows.Forms.Button()
        Me.No = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Yes
        '
        Me.Yes.Location = New System.Drawing.Point(12, 156)
        Me.Yes.Name = "Yes"
        Me.Yes.Size = New System.Drawing.Size(106, 67)
        Me.Yes.TabIndex = 1
        Me.Yes.Text = "Yes"
        Me.Yes.UseVisualStyleBackColor = True
        '
        'No
        '
        Me.No.Location = New System.Drawing.Point(166, 156)
        Me.No.Name = "No"
        Me.No.Size = New System.Drawing.Size(106, 67)
        Me.No.TabIndex = 1
        Me.No.Text = "No"
        Me.No.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 58)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(260, 20)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "Are you sure you would like to reset stats?"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ResetStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.No)
        Me.Controls.Add(Me.Yes)
        Me.Name = "ResetStats"
        Me.Text = "ResetStats"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Yes As Button
    Friend WithEvents No As Button
    Friend WithEvents TextBox1 As TextBox
End Class
