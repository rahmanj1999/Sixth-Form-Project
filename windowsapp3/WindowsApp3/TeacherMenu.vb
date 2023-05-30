Public Class TeacherMenu
    Private Sub Modify_User_Click(sender As Object, e As EventArgs) Handles Modify_Users.Click
        'Show modify user screen
        Me.Hide()
        ModifyUsers.Show()

    End Sub

    Private Sub Modify_Questions_Click(sender As Object, e As EventArgs) Handles Modify_Questions.Click
        'get all the questions from database and export them accordingly to the text boxes on question screen and also make question screen visible
        Me.Hide()
        Dim DataBase As New InformationDataSetTableAdapters.QuestionsTableAdapter
        Dim Data = DataBase.GetData()
        ModifyQuestions.Q1Question.Text = Trim(Data.Rows(0).Item(0).ToString)
        ModifyQuestions.Q1Answer.Text = Trim(Data.Rows(0).Item(1).ToString)
        ModifyQuestions.Q1AAnswer1.Text = Trim(Data.Rows(0).Item(2).ToString)
        ModifyQuestions.Q1AAnswer2.Text = Trim(Data.Rows(0).Item(3).ToString)

        ModifyQuestions.Q2Question.Text = Trim(Data.Rows(1).Item(0).ToString)
        ModifyQuestions.Q2Answer.Text = Trim(Data.Rows(1).Item(1).ToString)
        ModifyQuestions.Q2AAnswer1.Text = Trim(Data.Rows(1).Item(2).ToString)
        ModifyQuestions.Q2AAnswer2.Text = Trim(Data.Rows(1).Item(3).ToString)

        ModifyQuestions.Q3Question.Text = Trim(Data.Rows(2).Item(0).ToString)
        ModifyQuestions.Q3Answer.Text = Trim(Data.Rows(2).Item(1).ToString)
        ModifyQuestions.Q3AAnswer1.Text = Trim(Data.Rows(2).Item(2).ToString)
        ModifyQuestions.Q3AAnswer2.Text = Trim(Data.Rows(2).Item(3).ToString)

        ModifyQuestions.Show()
    End Sub

    Private Sub View_Statistics_Click(sender As Object, e As EventArgs) Handles View_Statistics.Click
        'Add user statistics to tables and show statiscs menu
        Dim i As Integer
        Dim DataBase As New InformationDataSetTableAdapters.StudentInfoTableAdapter
        Dim Database2 As New InformationDataSetTableAdapters.ScoreTableAdapter
        Dim DatabaseInfo = DataBase.GetData()
        Stats.DataGridView1.Rows.Clear()

        For i = 1 To DatabaseInfo.Rows.Count - 1
            Dim i2 As Integer = Stats.DataGridView1.Rows.Add()

            Stats.DataGridView1.Rows(i2).Cells(0).Value = DataBase.GetData.Rows(i).Item(3)
            Stats.DataGridView1.Rows(i2).Cells(1).Value = DataBase.GetData.Rows(i).Item(4)
            Stats.DataGridView1.Rows(i2).Cells(2).Value = Database2.GetData.Rows(i - 1).Item(1).ToString
            Stats.DataGridView1.Rows(i2).Cells(3).Value = Database2.GetData.Rows(i - 1).Item(2).ToString
            Stats.DataGridView1.Rows(i2).Cells(4).Value = Database2.GetData.Rows(i - 1).Item(3).ToString
            i = i + 1
        Next
        Me.Hide()
        Stats.Show()
    End Sub

    Private Sub Change_Pass_Click(sender As Object, e As EventArgs) Handles Change_Pass.Click
        ' show form for teacher to change her pass
        Me.Hide()
        ChangePass.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'show login menu and make username and password field empty
        Me.Hide()
        Login.Username.Text = ""
        Login.Password.Text = ""
        Login.Show()
    End Sub

    Private Sub TeacherMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub
End Class