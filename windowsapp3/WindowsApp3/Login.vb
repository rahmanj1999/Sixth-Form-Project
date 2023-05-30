Public Class Login

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim DataBase As New InformationDataSetTableAdapters.StudentInfoTableAdapter
        If Username.Text = Nothing Then 'checks to see if data is entered into username field
            MessageBox.Show("Nothing has been entered into username, please enter a username", "Notification")
            Exit Sub
        End If
        If Password.Text = Nothing Then 'checks to see if data is entered into password field
            MessageBox.Show("Nothing has been entered into password, please enter a password", "Notification")
            Exit Sub
        End If
        Try ' try, to see if username exists

            Dim GetUsername = DataBase.GetDataBy1(Username.Text)
            Dim UsernameEntered = Trim(GetUsername.Rows(0).Item(1))
            Dim PasswordRequired = Trim(GetUsername.Rows(0).Item(2))
            If PasswordRequired = Password.Text Then ' check to see if password of username matches that of password entered by user
                If UsernameEntered = "Administrator" Then  'check to see if username is teacher
                    TeacherMenu.Show() '  show teachermenu if teacher is operating program
                    Me.Hide()
                Else
                    PreQuestion.Show() ' show pre question if student has logged on
                    Me.Hide()
                End If


            Else
                MessageBox.Show("You have entered an incorrect password, please refer to your teacher for your password", "Notification")
            End If

        Catch ' if username not exist then user is told so
            MessageBox.Show("You have entered an incorrect username, please refer to your teacher for your username", "Notification")
        End Try

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class