Imports System.Data.OleDb
Imports System.Data

Public Class LoginForm
    Dim connect As New OleDbConnection
    Dim command As New OleDbCommand
    Dim sql As String = Nothing

    Public Shared globalUserID As Integer
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\CJ\OMC\OMC database.accdb;"

    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If

        If txtUsername.Text = Nothing Or txtPassword.Text = Nothing Then
            MessageBox.Show("Please fill in all blank fields.", "Incomplete details", 0, MessageBoxIcon.Error)
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

                MsgBox("Succeeded", 0, "Successful Login")

                sql = "SELECT usertype FROM [User] WHERE ID = @UserID"
                command = New OleDbCommand(sql, connect)
                command.Parameters.AddWithValue("@UserID", globalUserID)

                Dim reader1 As OleDbDataReader = command.ExecuteReader()
                If reader1.Read() Then
                    If reader1("usertype").ToString = "Donor" Then
                        MainForm.Show()
                    ElseIf reader1("usertype").ToString = "Requestor" Then
                        RequestorMainForm.Show()
                    Else
                        MsgBox("Failed")
                    End If
                    reader1.Close()

                End If


                Me.Hide()


            Else
                MsgBox("Failed", 0, "Login Failed")
            End If
        End If
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        SignUpForm.Show()
        Me.Close()
    End Sub
End Class