Public Class Details

    Private Function CheckUserExists(ByRef DataBase, ByRef CheckUsername)
        Try
            If Trim(CheckUsername.Rows(0).Item(1)).ToLower = Trim(Username.Text).ToLower Then
                Return True
            End If
        Catch
            Return False
        End Try
    End Function

    Private Function CheckData()
        'Checks to see if all required data has been entered
        Dim Text As Control
        For Each Text In Me.Controls
            If (TypeOf Text Is TextBox) And (Text.Visible = True) Then
                If Len(Text.Text.Trim) = 0 Then
                    MessageBox.Show("Please enter data for " & Text.Name, "Alert")
                    Return True
                End If

            End If
        Next
        Return False
    End Function

    Private Sub CreateUser_Click(sender As Object, e As EventArgs) Handles CreateUser.Click
        'Sub to add user to database
        Dim DataBase As New InformationDataSetTableAdapters.StudentInfoTableAdapter
        Dim DataBase2 As New InformationDataSetTableAdapters.ScoreTableAdapter
        Dim CheckUsername = DataBase.GetDataBy1(Trim(Username.Text))
        Dim DoesUserExist As Boolean
        Dim MissingData As Boolean

        DoesUserExist = CheckUserExists(DataBase, CheckUsername)
        MissingData = CheckData()
        If MissingData = True Then
            Exit Sub
        ElseIf DoesUserExist = True Then
            MessageBox.Show("User already exists, please enter another username")
            Exit Sub
        End If
        DataBase.InsertQueryUser(Trim(Username.Text), Password.Text, FirstName.Text, LastName.Text)
        DataBase2.InsertQueryUserScore(Trim(Username.Text))
        MessageBox.Show(Trim(Username.Text) & " has been succesfully added")
    End Sub

    Private Sub SearchUser_Click(sender As Object, e As EventArgs) Handles SearchUser.Click
        'Searches for a user
        Dim DataBase As New InformationDataSetTableAdapters.StudentInfoTableAdapter
        Dim CheckUsername = DataBase.GetDataBy1(Trim(Username.Text))
        Dim DoesUserExist As Boolean
        Dim MissingData As Boolean

        MissingData = CheckData()
        If MissingData = True Then
            Exit Sub
        End If
        DoesUserExist = CheckUserExists(DataBase, CheckUsername)
        If DoesUserExist = False Then
            MessageBox.Show("This user does not exist")
            Exit Sub
        End If
        Username.ReadOnly = True
        Password.Text = Trim(CheckUsername.Rows(0).Item(2))
        FirstName.Text = Trim(CheckUsername.Rows(0).Item(3))
        LastName.Text = Trim(CheckUsername.Rows(0).Item(4))
        Dim Text As Control
        For Each Text In Me.Controls
            If TypeOf Text Is TextBox Then
                Text.Visible = True
            End If
        Next
        SearchUser.Visible = False
        DeleteUser.Visible = True
        UpdateUser.Visible = True
    End Sub

    Private Sub DeleteUser_Click(sender As Object, e As EventArgs) Handles DeleteUser.Click
        'Deletes user from database
        Dim DataBase As New InformationDataSetTableAdapters.StudentInfoTableAdapter
        Dim DataBase2 As New InformationDataSetTableAdapters.ScoreTableAdapter
        DataBase.DeleteQuery(Trim(Username.Text))
        DataBase2.DeleteQuery(Trim(Username.Text))
        MessageBox.Show(Trim(Username.Text) & " 's details has been succesfully deleted")
        Dim Text As Control
        For Each Text In Me.Controls
            If TypeOf Text Is TextBox Then
                Text.Visible = False
            End If
        Next
        DeleteUser.Visible = False
        UpdateUser.Visible = False
        SearchUser.Visible = True
        Username.Visible = True
        Username.ReadOnly = False
        TextBox1.Visible = True
    End Sub

    Private Sub UpdateUser_Click(sender As Object, e As EventArgs) Handles UpdateUser.Click
        'Updates user on database
        Dim MissingData As Boolean
        MissingData = CheckData()
        If MissingData = True Then
            Exit Sub
        End If
        Dim DataBase As New InformationDataSetTableAdapters.StudentInfoTableAdapter
        Dim DataBase2 As New InformationDataSetTableAdapters.ScoreTableAdapter
        DataBase.UpdateQuery(Trim(Username.Text), Password.Text, FirstName.Text, LastName.Text, Trim(Username.Text))
        DataBase2.UpdateQuery(Trim(Username.Text), Trim(Username.Text))
        MessageBox.Show(Trim(Username.Text) & " details has been succesfully updated")

        Dim Text As Control
        For Each Text In Me.Controls
            If TypeOf Text Is TextBox Then
                Text.Visible = False
            End If
        Next
        DeleteUser.Visible = False
        UpdateUser.Visible = False
        SearchUser.Visible = True
        Username.Visible = True
        Username.ReadOnly = False
        TextBox1.Visible = True
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        ModifyUsers.Show()
    End Sub

    Private Sub Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class