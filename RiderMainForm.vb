Public Class RiderMainForm
    Private activeForm As Form = Nothing
    Private Sub OpenChildFormInPanel(childForm As Form)
        If ActiveForm IsNot Nothing Then
            ActiveForm.Hide()
        End If

        ActiveForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        pnlChildForm.Controls.Add(childForm)
        pnlChildForm.Tag = childForm
        'childForm.BringToFront()
        childForm.Show()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim res As String = MsgBox("Are you sure?", MessageBoxIcon.Question & 4, "Exit Program")
        If res = vbYes Then
            Application.ExitThread()
        End If
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        OpenChildFormInPanel(ProfileForm)
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        OpenChildFormInPanel(RiderHomeForm)
    End Sub

    Private Sub RiderMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenChildFormInPanel(RiderHomeForm)
    End Sub

    Private Sub btnDelivery_Click(sender As Object, e As EventArgs) Handles btnDelivery.Click
        OpenChildFormInPanel(RiderDeliveryForm)
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim res As String = MsgBox("Are you sure?", MessageBoxIcon.Question & 4, "Log Out")
        If res = vbYes Then
            LoginForm.Show()
            Me.Close()
        End If

    End Sub
End Class