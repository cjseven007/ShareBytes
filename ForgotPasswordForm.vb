Imports System.Data.OleDb

Public Class ForgotPasswordForm
    Dim connect As New OleDbConnection
    Dim command As New OleDbCommand
    Dim sql As String = Nothing
    Private Sub ForgotPasswordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\CJ\OMC\OMC database.accdb;"
    End Sub
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If

        If txtUsername.Text = Nothing Or txtNewPassword.Text = Nothing Or txtConfirmNewPassword.Text = Nothing Then
            MsgBox("Please enter all necessary details.", 0 & MsgBoxStyle.Exclamation, "INCOMPLETE DETAILS")
        ElseIf txtNewPassword.Text <> txtConfirmNewPassword.Text Then
            MsgBox("New Password and Confirm New Password must be the same.", 0 & MsgBoxStyle.Exclamation, "PASSWORD NOT THE SAME")
        Else
            Dim checkData As String = "SELECT * FROM [user] WHERE username = '" & txtUsername.Text & "'"

            command = New OleDbCommand(checkData, connect)

            Dim check = Convert.ToInt32(command.ExecuteScalar())

            If check > 0 Then
                sql = "UPDATE [user] SET [password] = @Password WHERE [username] = @Username"
                command = New OleDbCommand(sql, connect)
                command.Parameters.AddWithValue("@Password", txtNewPassword.Text)
                command.Parameters.AddWithValue("@Username", txtUsername.Text)
                command.ExecuteNonQuery()

                MsgBox("Password changed successfully. Kindly proceed to login page.", 0 & MsgBoxStyle.Information, "CHANGE PASSWORD SUCCESSFUL")

                Me.Close()
            Else
                MsgBox("User with username: " & txtUsername.Text & " does not exist.", 0 & MsgBoxStyle.Exclamation, "USER NOT FOUND")
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class