Public Class SplashScreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        pnlProgress.Width += 20

        If pnlProgress.Width >= 700 Then
            LoginForm.Show()
            Me.Close()

        End If
    End Sub
End Class
