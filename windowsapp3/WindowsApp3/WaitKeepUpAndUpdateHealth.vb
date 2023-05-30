Public Class WaitKeepUpAndUpdateHealth

    Public Shared Sub waitUpdate()
        '-------Wait Function-------
        For i As Integer = 0 To 5
            waitingCPU = True

            System.Threading.Thread.Sleep(30)
            Application.DoEvents()

        Next
        waitingCPU = False

    End Sub

    Public Shared Sub keepup()
        '--------Make different phases of player's character be in same position as character------- 
        Dim Healthpercentageplayer As Integer
        Dim Healthpercentagecpu As Integer
        Dim OldWidth As Integer
        Dim PositionChange As Integer
        Game.Stance2.Location = New Point(Game.PictureBox6.Location.X, Game.PictureBox6.Location.Y)
        Game.Stance3.Location = New Point(Game.PictureBox6.Location.X, Game.PictureBox6.Location.Y)
        Game.Punch.Location = New Point(Game.PictureBox6.Location.X, Game.PictureBox6.Location.Y)
        Game.Kick.Location = New Point(Game.PictureBox6.Location.X, Game.PictureBox6.Location.Y)
        Game.KickR.Location = New Point(Game.PictureBox6.Location.X, Game.PictureBox6.Location.Y)
        Game.PunchR.Location = New Point(Game.PictureBox6.Location.X, Game.PictureBox6.Location.Y)
        Game.Stance3R.Location = New Point(Game.PictureBox6.Location.X, Game.PictureBox6.Location.Y)
        Game.Stance2R.Location = New Point(Game.PictureBox6.Location.X, Game.PictureBox6.Location.Y)
        Game.Stance1R.Location = New Point(Game.PictureBox6.Location.X, Game.PictureBox6.Location.Y)

        '------Update health bar for player and cpu----------
        OldWidth = Game.HealthFrontPlayer.Size.Width
        Healthpercentageplayer = Game.HealthBackPlayer.Width * (CurrentHealth / Health)
        Healthpercentagecpu = Game.HealthBackCpu.Width * (CpuHealth / 100)
        Game.HealthFrontCpu.Size = New Size(Healthpercentagecpu, Game.HealthFrontCpu.Size.Height)
        Game.HealthFrontPlayer.Size = New Size(Healthpercentageplayer, Game.HealthFrontPlayer.Size.Height)
        PositionChange = OldWidth - Game.HealthFrontPlayer.Size.Width
        Game.HealthFrontPlayer.Location = New Point(Game.HealthFrontPlayer.Location.X + PositionChange, Game.HealthFrontPlayer.Location.Y)
    End Sub


End Class
