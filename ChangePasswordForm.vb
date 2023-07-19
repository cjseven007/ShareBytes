Imports System.Data.OleDb

Public Class ChangePasswordForm
    Dim connect As New OleDbConnection
    Dim command As New OleDbCommand
    Dim sql As String = Nothing
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        If txtOldPassword.Text = "" Or txtNewPassword.Text = "" Or txtConfirmPassword.Text = "" Then
            MsgBox("Please enter all fields.", 0 & MsgBoxStyle.Exclamation, "INCOMPLETE DETAILS")
        Else
            If connect.State = ConnectionState.Closed Then
                connect.Open()
            End If

            sql = "SELECT * FROM [User] WHERE ID = @UserID"
            command = New OleDbCommand(sql, connect)
            command.Parameters.AddWithValue("@UserID", LoginForm.globalUserID)
            Dim reader As OleDbDataReader = command.ExecuteReader()

            While reader.Read()
                Dim oldPassword As String = reader("password").ToString()
                If txtOldPassword.Text <> oldPassword Then
                    MsgBox("Old password is not the same.", 0 & MsgBoxStyle.Exclamation, "OLD PASSWORD ERROR")
                ElseIf txtNewPassword.Text <> txtConfirmPassword.Text Then
                    MsgBox("New password and confirm password not the same.", 0 & MsgBoxStyle.Exclamation, "PASSWORD NOT THE SAME")
                Else
                    sql = "UPDATE [User] SET [password] = @Password WHERE ID = @UserID"
                    command = New OleDbCommand(sql, connect)
                    command.Parameters.AddWithValue("@Password", txtNewPassword.Text)
                    command.Parameters.AddWithValue("@UserID", LoginForm.globalUserID)
                    command.ExecuteNonQuery()

                    MsgBox("Password updated.", 0 & MsgBoxStyle.Exclamation, "PASSWORD CHANGED")
                    Me.Close()

                End If
            End While
        End If

    End Sub

    Private Sub ChangePasswordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\CJ\OMC\OMC database.accdb;"
    End Sub
End Class