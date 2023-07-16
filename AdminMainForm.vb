Imports System.Runtime.Remoting.Contexts

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
        OpenChildFormInPanel(AdminUserForm)
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim res As String = MsgBox("Are you sure?", MessageBoxIcon.Question & 4, "Log Out")
        If res = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnMessages_Click(sender As Object, e As EventArgs) Handles btnMessages.Click
        OpenChildFormInPanel(AdminMessagesForm)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim res As String = MsgBox("Are you sure?", MessageBoxIcon.Question & 4, "Exit Program")
        If res = vbYes Then
            Application.ExitThread()
        End If
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        OpenChildFormInPanel(AdminUserForm)
    End Sub

    Private Sub btnStatistics_Click(sender As Object, e As EventArgs) Handles btnStatistics.Click

    End Sub
End Class