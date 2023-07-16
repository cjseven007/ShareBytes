Imports System.Data.OleDb
Imports System.Data
Imports System.Text.RegularExpressions

Public Class SignUpForm
    Dim connect As New OleDbConnection
    Dim command As New OleDbCommand
    Dim sql As String = Nothing

    Public Function IsValidEmail(email As String) As Boolean 'Check for valid email format
        Dim pattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        Dim regex As New Regex(pattern)
        Dim match As Match = regex.Match(email)

        Return match.Success
    End Function

    Private Sub SignUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\CJ\OMC\OMC database.accdb;"
        txtPassword.PasswordChar = "*" ' Set the password character to asterisk
        txtConfirmPassword.PasswordChar = "*" ' Set the password character to asterisk
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        LoginForm.Show()
        Me.Close()
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If

        If txtEmail.Text = Nothing Or txtUsername.Text = Nothing Or txtPassword.Text = Nothing Or txtConfirmPassword.Text = Nothing Or (rbtDonor.Checked = False And rbtRequestor.Checked = False) Then
            MessageBox.Show("Please fill in all blank fields.", "Incomplete details", 0, MessageBoxIcon.Exclamation)
        ElseIf txtPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Please make sure the passwords are the same.", "Password Not the Same", 0, MessageBoxIcon.Exclamation)
        ElseIf IsValidEmail(txtEmail.Text) = False Then
            MessageBox.Show("Please enter a valid email format.", "INVALID EMAIL FORMAT", 0, MessageBoxIcon.Exclamation)
        Else
            Dim checkData As String = "SELECT * FROM [user] WHERE username = '" & txtUsername.Text & "'"

            command = New OleDbCommand(checkData, connect)

            Dim check = Convert.ToInt32(command.ExecuteScalar())

            If check > 0 Then
                MsgBox("User under username '" & txtUsername.Text & "'already exist!", 0, "USER ALREADY EXIST")

            Else
                sql = "INSERT INTO [user] (email, username, [password], usertype) VALUES (@Email, @Username, @Password, @Usertype)"

                command = New OleDbCommand(sql, connect)
                command.Parameters.AddWithValue("@Email", txtEmail.Text)
                command.Parameters.AddWithValue("@Username", txtUsername.Text)
                command.Parameters.AddWithValue("@Password", txtPassword.Text)
                If rbtDonor.Checked = True Then
                    command.Parameters.AddWithValue("@Usertype", "Donor")
                ElseIf rbtRequestor.Checked = True Then
                    command.Parameters.AddWithValue("@Usertype", "Requestor")
                End If

                command.ExecuteNonQuery()

                MsgBox("Account created. Go to login page.", 0 & MsgBoxStyle.Information, "ACCOUNT CREATED")

                txtEmail.Clear()
                txtUsername.Clear()
                txtPassword.Clear()
                txtConfirmPassword.Clear()

                LoginForm.Show()
                Me.Close()
            End If


        End If
    End Sub

    Private Sub btnEye1_MouseHover(sender As Object, e As EventArgs) Handles btnEye1.MouseHover
        txtPassword.PasswordChar = "" ' Set the password character to asterisk

    End Sub

    Private Sub btnEye2_MouseHover(sender As Object, e As EventArgs) Handles btnEye2.MouseHover
        txtConfirmPassword.PasswordChar = "" ' Set the password character to asterisk
    End Sub

    Private Sub btnEye1_MouseLeave(sender As Object, e As EventArgs) Handles btnEye1.MouseLeave
        txtPassword.PasswordChar = "*" ' Set the password character to asterisk
    End Sub
    Private Sub btnEye2_MouseLeave(sender As Object, e As EventArgs) Handles btnEye2.MouseLeave
        txtConfirmPassword.PasswordChar = "*" ' Set the password character to asterisk
    End Sub


End Class