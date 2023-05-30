Public Class ModifyUsers
    Private Sub HideButtons()
        Dim Buttons As Control
        For Each Buttons In Me.Controls
            Buttons.Visible = False
        Next
    End Sub

    Private Sub AddUser_Click(sender As Object, e As EventArgs) Handles AddUser.Click
        ' Will clear all data in textboxes already and make any buttons irrelevant to creating a new user invisible
        Dim Text As Control
        For Each Text In Details.Controls
            If TypeOf Text Is TextBox Then
                Text.Visible = True
                If (Text.Name = "Username") Or (Text.Name = "Password") Or (Text.Name = "FirstName") Or (Text.Name = "LastName") Then
                    Text.Text = Nothing
                End If
            End If
        Next
        Details.Username.ReadOnly = False
        Details.CreateUser.Visible = True
        Details.SearchUser.Visible = False
        Details.UpdateUser.Visible = False
        Details.DeleteUser.Visible = False
        Me.Hide()
        Details.Show()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        TeacherMenu.Show()
    End Sub

    Private Sub Modify_Delete_User_Click(sender As Object, e As EventArgs) Handles Modify_Delete_User.Click
        ' will
        Dim Text As Control
        For Each Text In Details.Controls
            If TypeOf Text Is TextBox Then
                Text.Visible = False
                If (Text.Name = "Username") Or (Text.Name = "Password") Or (Text.Name = "FirstName") Or (Text.Name = "LastName") Then
                    Text.Text = Nothing
                End If
            End If
        Next
        Details.CreateUser.Visible = False
        Details.DeleteUser.Visible = False
        Details.UpdateUser.Visible = False
        Details.SearchUser.Visible = True
        Details.Username.Visible = True
        Details.Username.ReadOnly = False
        Details.TextBox1.Visible = True
        Me.Hide()
        Details.Show()
    End Sub

    Private Sub List_of_users_Click(sender As Object, e As EventArgs) Handles List_of_users.Click
        ListOfStudents.DataGridView1.Rows.Clear()
        Dim i As Integer
        Dim DataBase As New InformationDataSetTableAdapters.StudentInfoTableAdapter
        Dim DatabaseInfo = DataBase.GetData()


        For i = 1 To DatabaseInfo.Rows.Count - 1 ' for all the rows on the database
            '------------ Export all the data from score database to table
            Dim i2 As Integer = ListOfStudents.DataGridView1.Rows.Add()
            ListOfStudents.DataGridView1.Rows(i2).Cells(0).Value = DataBase.GetData.Rows(i).Item(1)
            ListOfStudents.DataGridView1.Rows(i2).Cells(1).Value = DataBase.GetData.Rows(i).Item(2)
            ListOfStudents.DataGridView1.Rows(i2).Cells(2).Value = DataBase.GetData.Rows(i).Item(3)
            ListOfStudents.DataGridView1.Rows(i2).Cells(3).Value = DataBase.GetData.Rows(i).Item(4)
            i = i + 1
        Next
        Me.Hide()
        ListOfStudents.Show()
    End Sub


End Class