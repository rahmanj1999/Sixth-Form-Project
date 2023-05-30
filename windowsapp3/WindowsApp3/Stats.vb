Imports System.IO
Public Class Stats


    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        TeacherMenu.Show()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button3.Click
        'Exports data to text file
        If Title.Text = Nothing Then
            MessageBox.Show("Please enter a title for the data")
            Exit Sub
        End If


        Dim txtfile As System.IO.StreamWriter
        txtfile = My.Computer.FileSystem.OpenTextFileWriter("Statistics.txt", True) 'Opens file statistics
        txtfile.WriteLine("---------------------------" & Title.Text & "----------------------------------------------------")
        txtfile.WriteLine("First Name|Last Name|Q1|Q2|Q3")
        For row As Integer = 0 To DataGridView1.Rows.Count - 2 Step +1
            For collum As Integer = 0 To DataGridView1.Columns.Count - 1 Step +1

                txtfile.Write(" " & DataGridView1.Rows(row).Cells(collum).Value.ToString() & "  |")
            Next
            txtfile.WriteLine("")
            txtfile.WriteLine("--------------------------------------------------------------------------------------------")
        Next
        txtfile.WriteLine("")
        txtfile.WriteLine("")
        txtfile.Close()
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        Me.Hide()
        ResetStats.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class