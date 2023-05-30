Public Class ChangePass

    '--------Changes Teachers password------
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Len(PASS.Text) = 0 Then 'check to make sure teacher has enterd valid input
            MsgBox("Please enter a password")
            Exit Sub
        End If
        'update database with new password for teacher
        Dim DataBase As New InformationDataSetTableAdapters.StudentInfoTableAdapter
        DataBase.UpdateQuery1(PASS.Text, "1")
        MsgBox("Password updated successfully")
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        'go back
        Me.Hide()
        TeacherMenu.Show()
    End Sub


End Class