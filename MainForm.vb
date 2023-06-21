Public Class MainForm
    Private activeForm As Form = Nothing

    Private Sub OpenChildFormInPanel(childForm As Form)
        If activeForm IsNot Nothing Then
            activeForm.Hide()
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
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenChildFormInPanel(HomeForm)
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim res As String = MsgBox("Are you sure?", MessageBoxIcon.Question & 4, "Exit Program")
        If res = vbYes Then
            Application.ExitThread()
        End If

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim childForm As New HomeForm
        OpenChildFormInPanel(HomeForm)
    End Sub


    Private Sub btnDonate_Click(sender As Object, e As EventArgs) Handles btnDonate.Click
        Dim childForm As New DonateForm
        OpenChildFormInPanel(DonateForm)
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        Dim childForm As New InventoryForm
        OpenChildFormInPanel(InventoryForm)
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Dim childForm As New ProfileForm
        OpenChildFormInPanel(ProfileForm)
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        Dim childForm As New AboutForm
        OpenChildFormInPanel(AboutForm)
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim res As String = MsgBox("Are you sure?", MessageBoxIcon.Question & 4, "Log Out")
        If res = vbYes Then
            LoginForm.Show()
            Me.Close()
        End If

    End Sub


End Class