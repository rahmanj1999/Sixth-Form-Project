Public Class PreQuestion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Question.Show() ' Show Question form
        Question.LoadQuestion()
    End Sub


End Class