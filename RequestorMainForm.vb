Public Class RequestorMainForm
    Private activeForm As Form = Nothing
    Private Sub OpenChildFormInPanel(childForm As Form)
        If ActiveForm IsNot Nothing Then
            ActiveForm.Hide()
        End If

        activeForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        pnlChildForm.Controls.Add(childForm)
        pnlChildForm.Tag = childForm
        'childForm.BringToFront()
        childForm.Show()
    End Sub
    Private Sub btnExit_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.ExitThread()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        OpenChildFormInPanel(HomeForm)
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        OpenChildFormInPanel(AboutForm)
    End Sub

    Private Sub btnRequest_Click(sender As Object, e As EventArgs) Handles btnRequest.Click
        OpenChildFormInPanel(RequestForm)
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        OpenChildFormInPanel(ProfileForm)
    End Sub

    Private Sub btnTracking_Click(sender As Object, e As EventArgs) Handles btnTracking.Click
        OpenChildFormInPanel(RequestorTrackingForm)
    End Sub
End Class