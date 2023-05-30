Public Class Wait
    Public Shared Sub wait2()
        Dim waiting As Boolean = False

        For i As Integer = 0 To 5
            waiting = True
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
        waiting = False
    End Sub
End Class
