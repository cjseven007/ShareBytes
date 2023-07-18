Public Class StartupForm
    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        SplashScreen.Show()
        Me.Close()
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        AdminMainForm.Show()
        Me.Close()
    End Sub
End Class