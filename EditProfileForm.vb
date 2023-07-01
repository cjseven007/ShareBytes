Imports System.Data.OleDb

Public Class EditProfileForm
    Private profileForm As ProfileForm 'referencing the profile form
    Public Shared Username, Email, Organization, Address As String

    Dim connect As New OleDbConnection
    Dim command As New OleDbCommand
    Dim sql As String = Nothing

    Public Sub New(profileForm As ProfileForm)
        InitializeComponent()
        Me.profileForm = profileForm
    End Sub

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        Dim userID As Integer = LoginForm.globalUserID
        Dim email As String = txtEmail.Text
        Dim organization As String = txtOrganization.Text
        Dim address As String = txtAddress.Text
        Dim latitude As String = SelectLocationForm.latitudeGlobal
        Dim longitude As String = SelectLocationForm.longitudeGlobal


        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If

        sql = "UPDATE [User] SET email = @Email, organization = @Organization, address = @Address"

        If latitude IsNot Nothing And longitude IsNot Nothing Then
            'Check if the location is updated, if yes then update the latitude and longitude
            sql += ",latitude = @Latitude, longitude = @longitude WHERE ID = @UserID"
            command = New OleDbCommand(sql, connect)
            command.Parameters.AddWithValue("@Email", email)
            command.Parameters.AddWithValue("@Organization", organization)
            command.Parameters.AddWithValue("@Address", address)
            command.Parameters.AddWithValue("@Latitude", latitude)
            command.Parameters.AddWithValue("@Longitude", longitude)
            command.Parameters.AddWithValue("@UserID", userID)
            command.ExecuteNonQuery()
        Else
            'if not just proceed
            sql += " WHERE ID = @UserID"
            command = New OleDbCommand(sql, connect)
            command.Parameters.AddWithValue("@Email", email)
            command.Parameters.AddWithValue("@Organization", organization)
            command.Parameters.AddWithValue("@Address", address)
            command.Parameters.AddWithValue("@UserID", userID)
            command.ExecuteNonQuery()
        End If

        MsgBox("Your details have been updated.", 0 & MsgBoxStyle.Information, "Profile Updated")

        profileForm.ProfileFormRefreshData()
        connect.Close()
        Me.Close()
    End Sub

    Private Sub EditProfileForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\CJ\OMC\OMC database.accdb;"
        txtUsername.Text = Username
        txtEmail.Text = Email
        txtOrganization.Text = Organization
        txtAddress.Text = Address
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSelectLocation_Click(sender As Object, e As EventArgs) Handles btnSelectLocation.Click
        Dim locationForm As New SelectLocationForm(Me)
        locationForm.ShowDialog()
    End Sub


End Class