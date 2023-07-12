Public Class AdminMainForm
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
    Private Sub AdminMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim res As String = MsgBox("Are you sure?", MessageBoxIcon.Question & 4, "Log Out")
        If res = vbYes Then
            LoginForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnMessages_Click(sender As Object, e As EventArgs) Handles btnMessages.Click
        OpenChildFormInPanel(AdminMessagesForm)
    End Sub
End Class