Public Class ModifyQuestions


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Text As Control
        ' checks to see if there is data entered into all textboxes
        For Each Text In Me.Controls
            If (TypeOf Text Is TextBox) Then
                If Len(Text.Text) = 0 Then
                    If Text.Name = ("Q1Question") Or Text.Name = ("Q2Question") Or Text.Name = ("Q3Question") Then
                        MessageBox.Show("You are missing data for a question, please enter the data", "Alert")
                    Else
                        MessageBox.Show("You are missing data for a answer, please enter this data", "Alert")
                    End If
                    Exit Sub
                End If
            End If
        Next
        ' Adds questions and answers to database
        Dim DataBase As New InformationDataSetTableAdapters.QuestionsTableAdapter
        DataBase.UpdateQuery(Q1Question.Text, Q1Answer.Text, Q1AAnswer1.Text, Q1AAnswer2.Text, "1")
        DataBase.UpdateQuery(Q2Question.Text, Q2Answer.Text, Q2AAnswer1.Text, Q2AAnswer2.Text, "2")
        DataBase.UpdateQuery(Q3Question.Text, Q3Answer.Text, Q3AAnswer1.Text, Q3AAnswer2.Text, "3")
        MessageBox.Show("Questions updated successfully")

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        TeacherMenu.Show()
    End Sub


End Class