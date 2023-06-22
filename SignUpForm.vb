Imports System.Data.OleDb
Imports System.Data

Public Class SignUpForm
    Dim connect As New OleDbConnection
    Dim command As New OleDbCommand
    Dim sql As String = Nothing

    Private Sub SignUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\CJ\OMC\OMC database.accdb;"
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
            MessageBox.Show("Please fill in all blank fields.", "Incomplete details", 0, MessageBoxIcon.Error)
        ElseIf txtPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Please make sure the passwords are the same.", "Password Not the Same", 0, MessageBoxIcon.Error)
        Else
            Dim checkData As String = "SELECT * FROM [user] WHERE username = '" & txtUsername.Text & "'"

            command = New OleDbCommand(checkData, connect)

            Dim check = Convert.ToInt32(command.ExecuteScalar())

            If check > 0 Then
                MsgBox("User under username '" & txtUsername.Text & "'already exist!", 0, "User Already Exist")

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

                MsgBox("Account created. Go to login page.", 0 & MsgBoxStyle.Information, "Account Created")

                txtEmail.Clear()
                txtUsername.Clear()
                txtPassword.Clear()
                txtConfirmPassword.Clear()

                LoginForm.Show()
                Me.Close()
            End If


        End If
    End Sub

End Class