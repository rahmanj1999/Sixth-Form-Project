Public Class Upgrades


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'increase health
        GlobalVariables.Health = 120
        Button1.Visible = False
        MessageBox.Show("Health =" & GlobalVariables.Health)
        Me.Hide()
        Question.Show()
        Question.LoadQuestion()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'increase kick damage
        GlobalVariables.KickDamage = 20
        Button2.Visible = False
        MessageBox.Show("Kick Damage =" & GlobalVariables.KickDamage)
        Me.Hide()
        Question.Show()
        Question.LoadQuestion()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'increase punch damage
        GlobalVariables.PunchDamage = 20
        Button4.Visible = False
        MessageBox.Show("Punch Damage =" & GlobalVariables.PunchDamage)
        Me.Hide()
        Question.Show()
        Question.LoadQuestion()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'increase speed
        Button3.Visible = False
        GlobalVariables.Speed = 1.2
        MessageBox.Show("Speed Multiplier =" & GlobalVariables.Speed)
        Me.Hide()
        Question.Show()
        Question.LoadQuestion()
    End Sub

    Private Sub Upgrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Health =" & GlobalVariables.Health)
        MessageBox.Show("Kick Damage =" & GlobalVariables.KickDamage)
        MessageBox.Show("Punch Damage =" & GlobalVariables.PunchDamage)
        MessageBox.Show("Speed Multiplier =" & GlobalVariables.Speed)
    End Sub
End Class