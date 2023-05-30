Public Class ResetStats
    'if no pressed go back to previous page
    Private Sub Yes_Click(sender As Object, e As EventArgs) Handles Yes.Click
        'if yes erase students answers from database and go back to teacher menu
        Dim Database As New InformationDataSetTableAdapters.ScoreTableAdapter
        Dim Student As String
        For i = 0 To Database.GetData.Rows.Count - 1
            Student = Database.GetData.Rows(i).Item(0)
            Database.UpdateQuery4("", "", "", Student)
        Next
        MessageBox.Show("Scores have been cleared succesfully")
        Me.Hide()
        TeacherMenu.Show()
    End Sub

    Private Sub No_Click(sender As Object, e As EventArgs) Handles No.Click
        Me.Hide()
        Stats.Show()
    End Sub
End Class