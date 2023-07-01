﻿Imports System.Data.OleDb

Public Class ProfileForm
    Dim connect As New OleDbConnection
    Dim command As New OleDbCommand
    Dim sql As String = Nothing
    Dim editProfileForm As New EditProfileForm(Me)

    Public Sub ProfileFormRefreshData()
        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If

        Dim userID As Integer = LoginForm.globalUserID
        sql = "SELECT * FROM [User] WHERE ID = @UserID "

        command = New OleDbCommand(sql, connect)
        command.Parameters.AddWithValue("@UserID", OleDbType.VarChar).Value = userID

        Dim reader As OleDbDataReader = command.ExecuteReader()

        While reader.Read()
            Dim username As String = reader.GetString(reader.GetOrdinal("username"))
            Dim email As String = reader.GetString(reader.GetOrdinal("email"))
            Dim organization As String = ""
            Dim organizationOrdinal As Integer = reader.GetOrdinal("organization")

            If Not reader.IsDBNull(organizationOrdinal) Then
                organization = reader.GetString(organizationOrdinal)
            End If

            Dim address As String = ""
            Dim addressOrdinal As Integer = reader.GetOrdinal("address")

            If Not reader.IsDBNull(addressOrdinal) Then
                address = reader.GetString(addressOrdinal)
            End If


            lblUsername.Text = username
            lblEmail.Text = email



            If organization = Nothing Then
                lblOrganization.Text = "[Pending Action] Add Organization"
                lblOrganization.ForeColor = Color.Red
            Else
                lblOrganization.Text = organization
            End If
            If address = Nothing Then
                lblAddress.Text = "[Pending Action] Add Address"
                lblAddress.ForeColor = Color.Red
            Else
                lblAddress.Text = address
                lblAddress.ForeColor = Color.Black
            End If
            EditProfileForm.Username = username
            EditProfileForm.Email = email
            EditProfileForm.Organization = organization
            EditProfileForm.Address = address
        End While

        reader.Close()
    End Sub
    Private Sub ProfileForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\CJ\OMC\OMC database.accdb;"

        ProfileFormRefreshData()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        editProfileForm.ShowDialog()
    End Sub
End Class