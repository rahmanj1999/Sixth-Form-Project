Public Class Question
    Dim DataBase As New InformationDataSetTableAdapters.QuestionsTableAdapter
    Dim Data = DataBase.GetData()
    Dim Question As Integer = 0
    Dim CorrecrtAnswer As String
    Dim Database2 As New InformationDataSetTableAdapters.ScoreTableAdapter
    Dim Data2 = Database2.UpdateQuery1("", Login.Username.Text)
    Dim list As New List(Of Integer)
    Public Sub LoadQuestion()
        If Question = 3 Then ' checks to see if user has been through all questions then will proceed to game
            Me.Hide()
            Game.Show()
            Exit Sub

        End If
        'Presents the questions and possible answers to the users
        list.Add(1)
        list.Add(2)
        list.Add(3)

        TextBox1.Text = ("Question " & Question + 1)
        RichTextBox1.Text = (Trim(Data.Rows(Question).Item(0).ToString))
        Dim random = New Random()
        Dim randomq = list(random.Next(0, list.Count))
        Option1.Text = (Trim(Data.Rows(Question).Item(randomq).ToString))
        If randomq = 1 Then
            CorrecrtAnswer = Me.Option1.Name
        End If
        list.Remove(randomq)

        randomq = list(random.Next(0, list.Count))
        Option2.Text = (Trim(Data.Rows(Question).Item(randomq).ToString))
        If randomq = 1 Then
            CorrecrtAnswer = Me.Option2.Name
        End If
        list.Remove(randomq)

        randomq = list(random.Next(0, list.Count))
        Option3.Text = (Trim(Data.Rows(Question).Item(randomq).ToString))
        If randomq = 1 Then
            CorrecrtAnswer = Me.Option3.Name
        End If
        list.Remove(randomq)
        Question = Question + 1
    End Sub

    Private Sub incorrect() ' Updates database with incorrect depending on user and question number
        If Question = 1 Then
            Data2 = Database2.UpdateQuery1("Incorrect", Login.Username.Text)
        ElseIf Question = 2 Then
            Data2 = Database2.UpdateQuery2("Incorrect", Login.Username.Text)
        ElseIf Question = 3 Then
            Data2 = Database2.UpdateQuery3("Incorrect", Login.Username.Text)
        End If
    End Sub

    Public Sub correct() ' Updates database with correct depending on user and question number
        If Question = 1 Then
            Data2 = Database2.UpdateQuery1("Correct", Login.Username.Text)
        ElseIf Question = 2 Then
            Data2 = Database2.UpdateQuery2("Correct", Login.Username.Text)
        ElseIf Question = 3 Then
            Data2 = Database2.UpdateQuery3("Correct", Login.Username.Text)
        End If
    End Sub
    Private Sub Option1_Click(sender As Object, e As EventArgs) Handles Option1.Click

        If CorrecrtAnswer = Option1.Name Then
            MessageBox.Show("Correct Answer!")
            Me.Hide()
            Upgrades.Show()
            correct()

        Else
            MessageBox.Show("Incorrect Answer :-(")
            incorrect()
            LoadQuestion()
        End If
    End Sub

    Private Sub Option2_Click(sender As Object, e As EventArgs) Handles Option2.Click
        If CorrecrtAnswer = Option2.Name Then
            MessageBox.Show("Correct Answer!")
            Me.Hide()
            Upgrades.Show()
            correct()

        Else
            MessageBox.Show("Incorrect Answer :-(")
            incorrect()
            LoadQuestion()
        End If
    End Sub

    Private Sub Option3_Click(sender As Object, e As EventArgs) Handles Option3.Click
        If CorrecrtAnswer = Option3.Name Then
            MessageBox.Show("Correct Answer!")
            Me.Hide()
            Upgrades.Show()
            correct()
        Else
            MessageBox.Show("Incorrect Answer :-(")
            incorrect()
            LoadQuestion()

        End If
    End Sub


End Class