Public Class KeepBackgroundInFront
    'Keep background to the front
    Sub Main()
        While True
            For i As Integer = 0 To 5
                System.Threading.Thread.Sleep(5)
                Application.DoEvents()

            Next
            Game.PictureBox2.BringToFront()
        End While
    End Sub
End Class