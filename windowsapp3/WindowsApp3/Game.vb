Public Class Game
    'Declare variables
    Dim damagetaken As Boolean = False
    Dim waiting As Boolean = False
    Dim started As Boolean = False
    Dim startedcpu As Boolean = False
    Dim startedthread As Boolean = False
    Dim gamend As Boolean = False
    Dim winner As String

    Private Sub wait()
        'Wait function
        For i As Integer = 0 To 5
            waiting = True
            System.Threading.Thread.Sleep(15)
            Application.DoEvents()

        Next
        waiting = False
    End Sub


    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False



        Dim Thread1 As New System.Threading.Thread(AddressOf CPUMove)
        WaitKeepUpAndUpdateHealth.keepup()

        If startedcpu = False Then
            TextBox2.Visible = False
            Thread1.Start()
            startedcpu = True
        End If
        damagetaken = False
        If started = False Then
            started = True
            CurrentHealth = Health
        End If




        If e.KeyCode = Keys.Left And PictureBox6.Location.X > 0 And waiting = False Then
            'Moves players character to the left
            If PlayerFacing = "Left" Then
                PictureBox6.Visible = False
                Stance2.Visible = True

                wait()
                Stance2.Visible = False
                Stance3.Visible = True

                wait()
                Stance3.Visible = False
                PictureBox6.Visible = True

                wait()
                PictureBox6.Location = New Point(PictureBox6.Location.X - (20 * Speed), PictureBox6.Location.Y)
                WaitKeepUpAndUpdateHealth.keepup()

            ElseIf PlayerFacing = "Right" Then
                Stance1R.Visible = False
                Stance2R.Visible = True
                wait()
                Stance2R.Visible = False
                Stance3R.Visible = True
                wait()
                Stance3R.Visible = False
                Stance1R.Visible = True
                wait()
                PictureBox6.Location = New Point(PictureBox6.Location.X - (20 * Speed), PictureBox6.Location.Y)
                WaitKeepUpAndUpdateHealth.keepup()


            End If

        ElseIf e.KeyCode = Keys.Right And PictureBox6.Location.X < 569 And waiting = False Then
            'Moves players character to the right
            If PlayerFacing = "Left" Then
                PictureBox6.Visible = False
                Stance2.Visible = True
                wait()
                Stance2.Visible = False
                Stance3.Visible = True
                wait()
                Stance3.Visible = False
                PictureBox6.Visible = True
                wait()
                PictureBox6.Location = New Point(PictureBox6.Location.X + (20 * Speed), PictureBox6.Location.Y)
                WaitKeepUpAndUpdateHealth.keepup()

            ElseIf PlayerFacing = "Right" Then
                Stance1R.Visible = False
                Stance2R.Visible = True
                wait()
                Stance2R.Visible = False
                Stance3R.Visible = True
                wait()
                Stance3R.Visible = False
                Stance1R.Visible = True
                wait()
                PictureBox6.Location = New Point(PictureBox6.Location.X + (20 * Speed), PictureBox6.Location.Y)
                WaitKeepUpAndUpdateHealth.keepup()

            End If

        ElseIf e.KeyCode = Keys.Z Then
            'If the player activates the key to punch, Z key
            If PlayerFacing = "Left" Then
                'Punches to the left
                PictureBox6.Visible = False
                Punch.Visible = True
                Punch.SendToBack()
                PictureBox6.SendToBack()
                wait()
                If KickR.Bounds.IntersectsWith(Stance1RCPU.Bounds) And damagetaken = False Then
                    damagetaken = True
                    CpuHealth = CpuHealth - PunchDamage
                End If
                wait()
                If KickR.Bounds.IntersectsWith(Stance1RCPU.Bounds) And damagetaken = False Then
                    damagetaken = True
                    CpuHealth = CpuHealth - PunchDamage
                End If
                wait()
                If KickR.Bounds.IntersectsWith(Stance1RCPU.Bounds) And damagetaken = False Then
                    damagetaken = True
                    CpuHealth = CpuHealth - PunchDamage
                End If
                PictureBox6.Visible = True
                Punch.Visible = False
            ElseIf PlayerFacing = "Right" Then
                'Punches to the right
                Stance1R.Visible = False
                PunchR.Visible = True
                PunchR.SendToBack()
                Stance1R.SendToBack()
                wait()
                If KickR.Bounds.IntersectsWith(Stance1RCPU.Bounds) And damagetaken = False Then
                    damagetaken = True
                    CpuHealth = CpuHealth - PunchDamage
                End If
                wait()
                If KickR.Bounds.IntersectsWith(Stance1RCPU.Bounds) And damagetaken = False Then
                    damagetaken = True
                    CpuHealth = CpuHealth - PunchDamage
                End If
                wait()
                If KickR.Bounds.IntersectsWith(Stance1RCPU.Bounds) And damagetaken = False Then
                    damagetaken = True
                    CpuHealth = CpuHealth - PunchDamage
                End If
                Stance1R.Visible = True
                PunchR.Visible = False
            End If

        ElseIf e.KeyCode = Keys.C Then
            'If the player activates the key to kick, C key.
            If PlayerFacing = "Left" Then
                'Kick to the left
                PictureBox6.Visible = False
                Kick.Visible = True
                Kick.SendToBack()
                PictureBox6.SendToBack()
                wait()
                If KickR.Bounds.IntersectsWith(Stance1RCPU.Bounds) And damagetaken = False Then
                    damagetaken = True
                    CpuHealth = CpuHealth - KickDamage
                End If
                wait()
                If KickR.Bounds.IntersectsWith(Stance1RCPU.Bounds) And damagetaken = False Then
                    damagetaken = True
                    CpuHealth = CpuHealth - KickDamage
                End If
                wait()
                If KickR.Bounds.IntersectsWith(Stance1RCPU.Bounds) And damagetaken = False Then
                    damagetaken = True
                    CpuHealth = CpuHealth - KickDamage
                End If
                PictureBox6.Visible = True
                Kick.Visible = False
            ElseIf PlayerFacing = "Right" Then
                'Kick to the right
                Stance1R.Visible = False
                KickR.Visible = True
                KickR.SendToBack()
                Stance1R.SendToBack()
                wait()
                If KickR.Bounds.IntersectsWith(Stance1RCPU.Bounds) And damagetaken = False Then
                    damagetaken = True
                    CpuHealth = CpuHealth - KickDamage
                End If
                wait()
                If KickR.Bounds.IntersectsWith(Stance1RCPU.Bounds) And damagetaken = False Then
                    damagetaken = True
                    CpuHealth = CpuHealth - KickDamage
                End If
                wait()
                If KickR.Bounds.IntersectsWith(Stance1RCPU.Bounds) And damagetaken = False Then
                    damagetaken = True
                    CpuHealth = CpuHealth - KickDamage
                End If
                Stance1R.Visible = True
                KickR.Visible = False
            End If
        End If
        WaitKeepUpAndUpdateHealth.keepup()



    End Sub


    '------------------------------------------------------------------------------------------------

    Public Shared Sub waitCPU()
        'Sub to wait
        For i As Integer = 0 To 5
            waitingCPU = True

            System.Threading.Thread.Sleep(15)
            Application.DoEvents()

        Next
        waitingCPU = False

    End Sub
    Private Sub CPUMove()
        While gamend = False
            Dim Healthpercentageplayer As Integer
            Dim Healthpercentagecpu As Integer
            Dim OldWidth As Integer
            Dim PositionChange As Integer
            'Make CPU Versions keepup with each other
            Stance2.Location = New Point(PictureBox6.Location.X, PictureBox6.Location.Y)
            Stance3.Location = New Point(PictureBox6.Location.X, PictureBox6.Location.Y)
            Punch.Location = New Point(PictureBox6.Location.X, PictureBox6.Location.Y)
            Kick.Location = New Point(PictureBox6.Location.X, PictureBox6.Location.Y)
            KickR.Location = New Point(PictureBox6.Location.X, PictureBox6.Location.Y)
            PunchR.Location = New Point(PictureBox6.Location.X, PictureBox6.Location.Y)
            Stance3R.Location = New Point(PictureBox6.Location.X, PictureBox6.Location.Y)
            Stance2R.Location = New Point(PictureBox6.Location.X, PictureBox6.Location.Y)
            Stance1R.Location = New Point(PictureBox6.Location.X, PictureBox6.Location.Y)


            OldWidth = HealthFrontPlayer.Size.Width
            Healthpercentageplayer = HealthBackPlayer.Width * (CurrentHealth / Health)
            Healthpercentagecpu = HealthBackCpu.Width * (CpuHealth / 100)
            HealthFrontCpu.Size = New Size(Healthpercentagecpu, HealthFrontCpu.Size.Height)
            HealthFrontPlayer.Size = New Size(Healthpercentageplayer, HealthFrontPlayer.Size.Height)
            PositionChange = OldWidth - HealthFrontPlayer.Size.Width
            HealthFrontPlayer.Location = New Point(HealthFrontPlayer.Location.X + PositionChange, HealthFrontPlayer.Location.Y)
            Stance2CPU.Location = New Point(Stance1RCPU.Location.X, Stance1RCPU.Location.Y)
            Stance3CPU.Location = New Point(Stance1RCPU.Location.X, Stance1RCPU.Location.Y)
            PunchCPU.Location = New Point(Stance1RCPU.Location.X, Stance1RCPU.Location.Y)
            KickCPU.Location = New Point(Stance1RCPU.Location.X, Stance1RCPU.Location.Y)
            KickRCPU.Location = New Point(Stance1RCPU.Location.X, Stance1RCPU.Location.Y)
            PunchRCPU.Location = New Point(Stance1RCPU.Location.X, Stance1RCPU.Location.Y)
            Stance3RCPU.Location = New Point(Stance1RCPU.Location.X, Stance1RCPU.Location.Y)
            Stance2RCPU.Location = New Point(Stance1RCPU.Location.X, Stance1RCPU.Location.Y)
            PictureBox6CPU.Location = New Point(Stance1RCPU.Location.X, Stance1RCPU.Location.Y)
            DetectorLeft.Location = New Point(Stance1RCPU.Location.X, Stance1RCPU.Location.Y)
            DetectorRight.Location = New Point(Stance1RCPU.Location.X + 67, Stance1RCPU.Location.Y)

            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False

            Dim damagetaken As Boolean = False
            Dim waitingCPU As Boolean = False
            Dim started As Boolean = False
            Randomize()
            Dim Random1 As Integer = CInt(Int((101 * Rnd()) + 0)) ' Select random number to randomise computer movement


            If ((Random1 <= 15 And Random1 > 5) And CpuFacing = "Right" And waitingCPU = False And Stance1RCPU.Location.X > 0) Or ((Random1 <= 100 And Random1 > 15) And CpuFacing = "Left" And waitingCPU = False And Stance1RCPU.Location.X > 0) Then '   Prevents Cpu from going past bounds of game
                'If the random number chosen is greater than 5 and less than or equal to 15 then...
                If CpuFacing = "Left" Then
                    'cpu will move to the left if its character is facing left
                    PictureBox6CPU.Visible = False
                    Stance2CPU.Visible = True

                    waitCPU()
                    Stance2CPU.Visible = False
                    Stance3CPU.Visible = True

                    waitCPU()
                    Stance3CPU.Visible = False
                    PictureBox6CPU.Visible = True

                    waitCPU()

                    Stance1RCPU.Location = New Point(Stance1RCPU.Location.X - 20, Stance1RCPU.Location.Y)


                    If DetectorLeft.Bounds.IntersectsWith(PictureBox6.Bounds) Then


                        Dim Random2 As Integer = CInt(Int((3 * Rnd()) + 0)) ' select random number out 3
                        Stance2CPU.Location = New Point(Stance1RCPU.Location.X, Stance1RCPU.Location.Y)
                        Stance3CPU.Location = New Point(Stance1RCPU.Location.X, Stance1RCPU.Location.Y)
                        PunchCPU.Location = New Point(Stance1RCPU.Location.X, Stance1RCPU.Location.Y)
                        KickCPU.Location = New Point(Stance1RCPU.Location.X, Stance1RCPU.Location.Y)
                        KickRCPU.Location = New Point(Stance1RCPU.Location.X, Stance1RCPU.Location.Y)
                        PunchRCPU.Location = New Point(Stance1RCPU.Location.X, Stance1RCPU.Location.Y)
                        Stance3RCPU.Location = New Point(Stance1RCPU.Location.X, Stance1RCPU.Location.Y)
                        Stance2RCPU.Location = New Point(Stance1RCPU.Location.X, Stance1RCPU.Location.Y)
                        PictureBox6CPU.Location = New Point(Stance1RCPU.Location.X, Stance1RCPU.Location.Y)
                        DetectorLeft.Location = New Point(Stance1RCPU.Location.X, Stance1RCPU.Location.Y)
                        DetectorRight.Location = New Point(Stance1RCPU.Location.X + 67, Stance1RCPU.Location.Y)
                        If Random2 = 1 Then 'if the random number is 1 then cpu will perform punch action
                            PictureBox6CPU.Visible = False
                            PunchCPU.Visible = True
                            PunchCPU.SendToBack()
                            PictureBox6CPU.SendToBack()
                            waitCPU()
                            If PictureBox6.Bounds.IntersectsWith(KickRCPU.Bounds) And damagetaken = False Then
                                damagetaken = True
                                CurrentHealth = CurrentHealth - 10
                                PictureBox6.Location = New Point(PictureBox6.Location.X - 40, PictureBox6.Location.Y)
                            End If
                            waitCPU()
                            If PictureBox6.Bounds.IntersectsWith(KickRCPU.Bounds) And damagetaken = False Then
                                damagetaken = True
                                CurrentHealth = CurrentHealth - 10
                                PictureBox6.Location = New Point(PictureBox6.Location.X - 40, PictureBox6.Location.Y)
                            End If
                            waitCPU()
                            If PictureBox6.Bounds.IntersectsWith(KickRCPU.Bounds) And damagetaken = False Then
                                damagetaken = True
                                CurrentHealth = CurrentHealth - 10
                                PictureBox6.Location = New Point(PictureBox6.Location.X - 40, PictureBox6.Location.Y)
                            End If
                            PictureBox6CPU.Visible = True
                            PunchCPU.Visible = False

                        ElseIf Random2 = 2 Then ' if the random number is 2 then cpu will perform kick action
                            Stance1RCPU.Visible = False
                            KickCPU.Visible = True
                            KickCPU.SendToBack()
                            Stance1RCPU.SendToBack()
                            waitCPU()
                            If PictureBox6.Bounds.IntersectsWith(KickRCPU.Bounds) And damagetaken = False Then
                                damagetaken = True
                                CurrentHealth = CurrentHealth - 10
                                PictureBox6.Location = New Point(PictureBox6.Location.X - 40, PictureBox6.Location.Y)

                            End If
                            waitCPU()
                            If PictureBox6.Bounds.IntersectsWith(KickRCPU.Bounds) And damagetaken = False Then
                                damagetaken = True
                                CurrentHealth = CurrentHealth - 10
                                PictureBox6.Location = New Point(PictureBox6.Location.X - 40, PictureBox6.Location.Y)
                            End If
                            waitCPU()
                            If PictureBox6.Bounds.IntersectsWith(KickRCPU.Bounds) And damagetaken = False Then
                                damagetaken = True
                                CurrentHealth = CurrentHealth - 10
                                PictureBox6.Location = New Point(PictureBox6.Location.X - 40, PictureBox6.Location.Y)
                            End If
                            Stance1RCPU.Visible = True
                            KickCPU.Visible = False

                        End If
                    End If

                ElseIf CpuFacing = "Right" Then
                    'cpu will move to the right if its character is facing right
                    Stance1RCPU.Visible = False

                    Stance2RCPU.Visible = True
                    waitCPU()
                    Stance2RCPU.Visible = False
                    Stance3RCPU.Visible = True
                    waitCPU()
                    Stance3RCPU.Visible = False
                    Stance1RCPU.Visible = True
                    waitCPU()
                    Stance1RCPU.Location = New Point(Stance1RCPU.Location.X - (20), Stance1RCPU.Location.Y)


                End If

            ElseIf ((Random1 <= 100 And Random1 > 15) And CpuFacing = "Right" And waitingCPU = False And Stance1RCPU.Location.X < 544) Or ((Random1 <= 15 And Random1 > 5) And CpuFacing = "Left" And waitingCPU = False And Stance1RCPU.Location.X < 544) Then
                'If the random number chosen is greater than 15 and less than or equal to 100 the...
                If CpuFacing = "Left" Then
                    'cpu will move to the left if its character is facing left

                    PictureBox6CPU.Visible = False

                    Stance2CPU.Visible = True
                    waitCPU()
                    Stance2CPU.Visible = False
                    Stance3CPU.Visible = True
                    waitCPU()
                    Stance3CPU.Visible = False
                    PictureBox6CPU.Visible = True
                    waitCPU()
                    Stance1RCPU.Location = New Point(Stance1RCPU.Location.X + 20, Stance1RCPU.Location.Y)

                ElseIf CpuFacing = "Right" Then
                    'cpu will move to the right if its character is facing right
                    Stance1RCPU.Visible = False

                    Stance2RCPU.Visible = True
                    waitCPU()
                    Stance2RCPU.Visible = False
                    Stance3RCPU.Visible = True
                    waitCPU()
                    Stance3RCPU.Visible = False
                    Stance1RCPU.Visible = True
                    waitCPU()
                    Stance1RCPU.Location = New Point(Stance1RCPU.Location.X + 20, Stance1RCPU.Location.Y)
                    If DetectorRight.Bounds.IntersectsWith(PictureBox6.Bounds) Then
                        'If cpu touches player then

                        Dim Random2 As Integer = CInt(Int((3 * Rnd()) + 0)) ' creates another random number between 1 and 3 in which action will be performed on the basis of.
                        Stance2CPU.Location = New Point(Stance1RCPU.Location.X, Stance1RCPU.Location.Y)
                        Stance3CPU.Location = New Point(Stance1RCPU.Location.X, Stance1RCPU.Location.Y)
                        PunchCPU.Location = New Point(Stance1RCPU.Location.X, Stance1RCPU.Location.Y)
                        KickCPU.Location = New Point(Stance1RCPU.Location.X, Stance1RCPU.Location.Y)
                        KickRCPU.Location = New Point(Stance1RCPU.Location.X, Stance1RCPU.Location.Y)
                        PunchRCPU.Location = New Point(Stance1RCPU.Location.X, Stance1RCPU.Location.Y)
                        Stance3RCPU.Location = New Point(Stance1RCPU.Location.X, Stance1RCPU.Location.Y)
                        Stance2RCPU.Location = New Point(Stance1RCPU.Location.X, Stance1RCPU.Location.Y)
                        PictureBox6CPU.Location = New Point(Stance1RCPU.Location.X, Stance1RCPU.Location.Y)
                        DetectorLeft.Location = New Point(Stance1RCPU.Location.X, Stance1RCPU.Location.Y)
                        DetectorRight.Location = New Point(Stance1RCPU.Location.X + 67, Stance1RCPU.Location.Y)

                        If Random2 = 1 Then '  if the random number is 1 then cpu will perform punch action
                            Stance1RCPU.Visible = False
                            PunchRCPU.Visible = True
                            PunchRCPU.SendToBack()
                            Stance1R.SendToBack()
                            waitCPU()
                            If PictureBox6.Bounds.IntersectsWith(KickRCPU.Bounds) And damagetaken = False Then
                                damagetaken = True
                                CurrentHealth = CurrentHealth - 10
                                PictureBox6.Location = New Point(PictureBox6.Location.X + 30, PictureBox6.Location.Y)
                            End If
                            waitCPU()
                            If PictureBox6.Bounds.IntersectsWith(KickRCPU.Bounds) And damagetaken = False Then
                                damagetaken = True
                                CurrentHealth = CurrentHealth - 10
                                PictureBox6.Location = New Point(PictureBox6.Location.X + 30, PictureBox6.Location.Y)
                            End If
                            waitCPU()
                            If PictureBox6.Bounds.IntersectsWith(KickRCPU.Bounds) And damagetaken = False Then
                                damagetaken = True
                                CurrentHealth = CurrentHealth - 10
                                PictureBox6.Location = New Point(PictureBox6.Location.X + 30, PictureBox6.Location.Y)
                            End If
                            Stance1RCPU.Visible = True
                            PunchRCPU.Visible = False

                        ElseIf Random2 = 2 Then ' if the random number is 2 then cpu will perform kick action
                            Stance1RCPU.Visible = False
                            KickRCPU.Visible = True
                            waitCPU()
                            KickRCPU.SendToBack()
                            Stance1R.SendToBack()

                            If PictureBox6.Bounds.IntersectsWith(KickRCPU.Bounds) And damagetaken = False Then
                                damagetaken = True
                                CurrentHealth = CurrentHealth - 10
                                PictureBox6.Location = New Point(PictureBox6.Location.X + 30, PictureBox6.Location.Y)
                            End If
                            waitCPU()
                            If PictureBox6.Bounds.IntersectsWith(KickRCPU.Bounds) And damagetaken = False Then
                                damagetaken = True
                                CurrentHealth = CurrentHealth - 10
                                PictureBox6.Location = New Point(PictureBox6.Location.X + 30, PictureBox6.Location.Y)
                            End If
                            waitCPU()
                            If PictureBox6.Bounds.IntersectsWith(KickRCPU.Bounds) And damagetaken = False Then
                                damagetaken = True
                                CurrentHealth = CurrentHealth - 10
                                PictureBox6.Location = New Point(PictureBox6.Location.X + 30, PictureBox6.Location.Y)
                            End If
                            Stance1RCPU.Visible = True
                            KickRCPU.Visible = False
                        End If
                    End If
                End If


            ElseIf Random1 <= 2.5 And Random1 > 0 Then
                'If the random number chosen is greater than 0 and less than or equal to 2.5 then cpu will initiate punch action
                If CpuFacing = "Left" Then
                    PictureBox6CPU.Visible = False
                    PunchCPU.Visible = True
                    PunchCPU.SendToBack()
                    PictureBox6CPU.SendToBack()
                    waitCPU()
                    If PictureBox6.Bounds.IntersectsWith(KickRCPU.Bounds) And damagetaken = False Then
                        damagetaken = True
                        CurrentHealth = CurrentHealth - 10
                        PictureBox6.Location = New Point(PictureBox6.Location.X - 40, PictureBox6.Location.Y)
                    End If
                    waitCPU()
                    If PictureBox6.Bounds.IntersectsWith(KickRCPU.Bounds) And damagetaken = False Then
                        damagetaken = True
                        CurrentHealth = CurrentHealth - 10
                        PictureBox6.Location = New Point(PictureBox6.Location.X - 40, PictureBox6.Location.Y)
                    End If
                    waitCPU()
                    If PictureBox6.Bounds.IntersectsWith(KickRCPU.Bounds) And damagetaken = False Then
                        damagetaken = True
                        CurrentHealth = CurrentHealth - 10
                        PictureBox6.Location = New Point(PictureBox6.Location.X - 40, PictureBox6.Location.Y)
                    End If
                    PictureBox6CPU.Visible = True
                    PunchCPU.Visible = False
                ElseIf CpuFacing = "Right" Then
                    Stance1RCPU.Visible = False
                    PunchRCPU.Visible = True
                    PunchRCPU.SendToBack()
                    PictureBox6CPU.SendToBack()
                    waitCPU()
                    If PictureBox6.Bounds.IntersectsWith(KickRCPU.Bounds) And damagetaken = False Then
                        damagetaken = True
                        CurrentHealth = CurrentHealth - 10
                        PictureBox6.Location = New Point(PictureBox6.Location.X + 30, PictureBox6.Location.Y)
                    End If
                    waitCPU()
                    If PictureBox6.Bounds.IntersectsWith(KickRCPU.Bounds) And damagetaken = False Then
                        damagetaken = True
                        CurrentHealth = CurrentHealth - 10
                        PictureBox6.Location = New Point(PictureBox6.Location.X + 30, PictureBox6.Location.Y)
                    End If
                    waitCPU()
                    If PictureBox6.Bounds.IntersectsWith(KickRCPU.Bounds) And damagetaken = False Then
                        damagetaken = True
                        CurrentHealth = CurrentHealth - 10
                        PictureBox6.Location = New Point(PictureBox6.Location.X + 30, PictureBox6.Location.Y)
                    End If
                    Stance1RCPU.Visible = True
                    PunchRCPU.Visible = False
                End If

            ElseIf Random1 <= 5 And Random1 > 2.5 Then
                'If the random number chosen is greater than 2.5 and less than or equal to 5 then cpu will initiate kick action
                If CpuFacing = "Left" Then
                    PictureBox6CPU.Visible = False
                    KickCPU.Visible = True
                    KickCPU.SendToBack()
                    PictureBox6CPU.SendToBack()
                    waitCPU()
                    If PictureBox6.Bounds.IntersectsWith(KickRCPU.Bounds) And damagetaken = False Then
                        damagetaken = True
                        CurrentHealth = CurrentHealth - 10
                        PictureBox6.Location = New Point(PictureBox6.Location.X - 40, PictureBox6.Location.Y)
                    End If
                    waitCPU()
                    If PictureBox6.Bounds.IntersectsWith(KickRCPU.Bounds) And damagetaken = False Then
                        damagetaken = True
                        CurrentHealth = CurrentHealth - 10
                        PictureBox6.Location = New Point(PictureBox6.Location.X - 40, PictureBox6.Location.Y)
                    End If
                    waitCPU()
                    If PictureBox6.Bounds.IntersectsWith(KickRCPU.Bounds) And damagetaken = False Then
                        damagetaken = True
                        CurrentHealth = CurrentHealth - 10
                        PictureBox6.Location = New Point(PictureBox6.Location.X - 40, PictureBox6.Location.Y)
                    End If
                    PictureBox6CPU.Visible = True
                    KickCPU.Visible = False
                ElseIf CpuFacing = "Right" Then
                    Stance1RCPU.Visible = False
                    KickRCPU.Visible = True
                    KickRCPU.SendToBack()
                    PictureBox6CPU.SendToBack()
                    waitCPU()
                    If PictureBox6.Bounds.IntersectsWith(KickRCPU.Bounds) And damagetaken = False Then
                        damagetaken = True
                        CurrentHealth = CurrentHealth - 10
                        If (PictureBox6.Location.X < 569) And (PictureBox6.Location.X > 1) Then
                            PictureBox6.Location = New Point(PictureBox6.Location.X + 30, PictureBox6.Location.Y)
                        End If
                    End If
                    waitCPU()
                    If PictureBox6.Bounds.IntersectsWith(KickRCPU.Bounds) And damagetaken = False Then
                        damagetaken = True
                        CurrentHealth = CurrentHealth - 10
                        If (PictureBox6.Location.X < 569) And (PictureBox6.Location.X > 1) Then
                            PictureBox6.Location = New Point(PictureBox6.Location.X + 30, PictureBox6.Location.Y)
                        End If
                    End If
                    waitCPU()
                    If PictureBox6.Bounds.IntersectsWith(KickRCPU.Bounds) And damagetaken = False Then
                        damagetaken = True
                        CurrentHealth = CurrentHealth - 10.0
                        If (PictureBox6.Location.X < 569) And (PictureBox6.Location.X > 1) Then
                            PictureBox6.Location = New Point(PictureBox6.Location.X + 30, PictureBox6.Location.Y)
                        End If


                    End If
                    Stance1RCPU.Visible = True
                    KickRCPU.Visible = False
                End If
            End If
            Stance2CPU.Location = New Point(Stance1RCPU.Location.X, Stance1RCPU.Location.Y)
            Stance3CPU.Location = New Point(Stance1RCPU.Location.X, Stance1RCPU.Location.Y)
            PunchCPU.Location = New Point(Stance1RCPU.Location.X, Stance1RCPU.Location.Y)
            KickCPU.Location = New Point(Stance1RCPU.Location.X, Stance1RCPU.Location.Y)
            KickRCPU.Location = New Point(Stance1RCPU.Location.X, Stance1RCPU.Location.Y)
            PunchRCPU.Location = New Point(Stance1RCPU.Location.X, Stance1RCPU.Location.Y)
            Stance3RCPU.Location = New Point(Stance1RCPU.Location.X, Stance1RCPU.Location.Y)
            Stance2RCPU.Location = New Point(Stance1RCPU.Location.X, Stance1RCPU.Location.Y)
            PictureBox6CPU.Location = New Point(Stance1RCPU.Location.X, Stance1RCPU.Location.Y)
            DetectorLeft.Location = New Point(Stance1RCPU.Location.X, Stance1RCPU.Location.Y)
            DetectorRight.Location = New Point(Stance1RCPU.Location.X + 67, Stance1RCPU.Location.Y)

            If PictureBox6.Location.X < Stance1RCPU.Location.X Then
                'Makes Cpu face left and player face right if cpu is closer to right side in comparison to player
                Stance1R.Visible = True
                PictureBox6.Visible = False
                PlayerFacing = "Right"
                CpuFacing = "Left"
                Stance1RCPU.Visible = False
                PictureBox6CPU.Visible = True

            ElseIf PictureBox6.Location.X > Stance1RCPU.Location.X Then
                'Makes Cpu face right and player face left if cpu is closer to left side in comparison to player
                Stance1R.Visible = False
                PictureBox6.Visible = True
                PlayerFacing = "Left"
                CpuFacing = "Right"
                PictureBox6CPU.Visible = False
                Stance1RCPU.Visible = True
            End If
            waitCPU()
            waitCPU()
            'Checks for winner
            If CurrentHealth <= 0 And CpuHealth <= 0 Then
                HealthFrontCpu.Visible = False
                HealthFrontPlayer.Visible = False
                MessageBox.Show("No one won, better luck next time.")
                Me.Hide()
                gamend = True
            ElseIf CpuHealth <= 0 Then
                HealthFrontCpu.Visible = False
                MessageBox.Show("You Won!!! Well done.")
                Me.Hide()
                gamend = True
            ElseIf CurrentHealth <= 0 Then
                HealthFrontPlayer.Visible = False
                MessageBox.Show("You lost, you were no match for the computer.")
                Me.Hide()
                gamend = True
            End If


        End While

    End Sub

    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class