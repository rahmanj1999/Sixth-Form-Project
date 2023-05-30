<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stats
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Back = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Clear = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridView1.Location = New System.Drawing.Point(82, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(544, 381)
        Me.DataGridView1.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "First Name"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Last Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Q1"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Q2"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Q3"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(1, 2)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(75, 23)
        Me.Back.TabIndex = 3
        Me.Back.Text = "<"
        Me.Back.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(301, 453)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Export to text document"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Title
        '
        Me.Title.Location = New System.Drawing.Point(253, 427)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(296, 20)
        Me.Title.TabIndex = 5
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(103, 424)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(132, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Title of results"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Clear
        '
        Me.Clear.Location = New System.Drawing.Point(1, 167)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(75, 47)
        Me.Clear.TabIndex = 6
        Me.Clear.Text = "Clear Data"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(135, 389)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(419, 20)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.Text = "Text file will be located in the same folder the program is located within"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Stats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 478)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Stats"
        Me.Text = "Stats"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Back As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Title As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Clear As Button
    Friend WithEvents TextBox1 As TextBox
End Class
