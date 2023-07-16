Imports System.Data.OleDb
Imports System.Data

Public Class LoginForm
    Dim connect As New OleDbConnection
    Dim command As New OleDbCommand
    Dim sql As String = Nothing
    Dim editProfileForm As New EditProfileForm(Me)

    Public Shared globalUserID As Integer
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\CJ\OMC\OMC database.accdb;"
        txtPassword.PasswordChar = "*" ' Set the password character to asterisk
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If



        If txtUsername.Text = Nothing And txtPassword.Text = Nothing Then
            MessageBox.Show("Please enter username and password.", "INCOMPLETE DETAILS", 0, MessageBoxIcon.Error)
        ElseIf txtUsername.Text = Nothing Then
            MessageBox.Show("Please enter your username.", "USERNAME IS EMPTY", 0, MessageBoxIcon.Error)
        ElseIf txtPassword.Text = Nothing Then
            MessageBox.Show("Please enter your password.", "PASSWORD IS EMPTY", 0, MessageBoxIcon.Error)
        Else
            sql = "SELECT * FROM [user] WHERE username = @Username and password = @Password"
            command = New OleDbCommand(sql, connect)
            command.Parameters.AddWithValue("@Username", OleDbType.VarChar).Value = txtUsername.Text
            command.Parameters.AddWithValue("@Password", OleDbType.VarChar).Value = txtPassword.Text

            Dim check = Convert.ToInt32(command.ExecuteScalar())

            If check > 0 Then
                'Get userID to be used globally
                sql = "SELECT ID FROM [User] WHERE username = @Username"
                command = New OleDbCommand(sql, connect)
                command.Parameters.AddWithValue("@Username", txtUsername.Text)
                Dim reader As OleDbDataReader = command.ExecuteReader()
                If reader.Read() Then
                    globalUserID = reader.GetInt32(reader.GetOrdinal("ID"))
                End If
                reader.Close()

                MsgBox("Welcome, " & txtUsername.Text & "!", 0 + MsgBoxStyle.Information, "LOGIN SUCCESSFUL")

                sql = "SELECT * FROM [User] WHERE ID = @UserID"
                command = New OleDbCommand(sql, connect)
                command.Parameters.AddWithValue("@UserID", globalUserID)

                Dim reader1 As OleDbDataReader = command.ExecuteReader()

                If reader1.Read() Then
                    If reader1("usertype").ToString = "Donor" Then
                        MainForm.Show()
                        'Check if all details is filled in
                        If reader1("organization") Is DBNull.Value Or reader1("address") Is DBNull.Value Or reader1("latitude") Is DBNull.Value Or reader1("longitude") Is DBNull.Value Then
                            MsgBox("It appears there are additional details that you need to fill in. Please complete them to proceed.", 0, "Additional Details Required")
                            EditProfileForm.Username = reader1("username").ToString()
                            EditProfileForm.Email = reader1("email").ToString()
                            editProfileForm.ShowDialog()
                        End If

                    ElseIf reader1("usertype").ToString = "Requestor" Then
                        RequestorMainForm.Show()
                        If reader1("organization") Is DBNull.Value Or reader1("address") Is DBNull.Value Or reader1("latitude") Is DBNull.Value Or reader1("longitude") Is DBNull.Value Then
                            MsgBox("It appears there are additional details that you need to fill in. Please complete them to proceed.", 0, "Additional Details Required")
                            EditProfileForm.Username = reader1("username").ToString()
                            EditProfileForm.Email = reader1("email").ToString()
                            editProfileForm.ShowDialog()
                        End If
                    Else
                        MsgBox("Login failed")
                    End If
                    reader1.Close()

                End If


                Me.Hide()


            Else
                MsgBox("User not found. If you are not a member, kindly proceed in the sign up page.", 0 + MsgBoxStyle.Critical, "LOGIN FAILED")
            End If
        End If
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        SignUpForm.Show()
        Me.Close()
    End Sub

    Private Sub btnEye_MouseHover(sender As Object, e As EventArgs) Handles btnEye.MouseHover
        txtPassword.PasswordChar = ""
    End Sub

    Private Sub btnEye_MouseLeave(sender As Object, e As EventArgs) Handles btnEye.MouseLeave
        txtPassword.PasswordChar = "*" ' Set the password character to asterisk
    End Sub

    Private Sub lblForgotPassword_Click(sender As Object, e As EventArgs) Handles lblForgotPassword.Click
        OTPEmailForm.ShowDialog()
    End Sub
End Class