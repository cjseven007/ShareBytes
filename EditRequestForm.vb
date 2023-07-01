Imports System.Data.OleDb
Imports System.Runtime.Remoting.Contexts

Public Class EditRequestForm
    Private requestForm As RequestForm ' Reference to requestForm
    Public Property RequestID As Integer
    Public Property Title As String
    Public Property Description As String
    Public Property Location As String
    Public Property Latitude As String
    Public Property Longitude As String
    Public Property Pax As String

    Dim connect As New OleDbConnection
    Dim command As New OleDbCommand
    Dim sql As String = Nothing

    Public Sub New(requestForm As RequestForm)
        InitializeComponent()
        Me.requestForm = requestForm
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSelectLocation_Click(sender As Object, e As EventArgs) Handles btnSelectLocation.Click
        Dim locationForm As New SelectLocationForm(Me)
        locationForm.ShowDialog()
    End Sub

    Private Sub EditRequestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\CJ\OMC\OMC database.accdb;"
        txtRTitle.Text = Title
        txtRDescription.Text = Description
        txtRLocation.Text = Location
        nudRPax.Text = Pax

    End Sub

    Private Sub btnAddRequest_Click(sender As Object, e As EventArgs) Handles btnAddRequest.Click
        Dim title As String = txtRTitle.Text
        Dim description As String = txtRDescription.Text
        Dim location As String = txtRLocation.Text
        Dim pax As String = nudRPax.Text
        Dim latitude As String = SelectLocationForm.latitudeGlobal
        Dim longitude As String = SelectLocationForm.longitudeGlobal


        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If

        sql = "UPDATE Requests SET title = @Title, description = @Description, location = @Location"

        If latitude IsNot Nothing And longitude IsNot Nothing Then
            'Check if the location is updated, if yes then update the latitude and longitude
            sql += ",latitude = @Latitude, longitude = @longitude, pax = @Pax WHERE RequestID = @RequestID"
            command = New OleDbCommand(sql, connect)
            command.Parameters.AddWithValue("@Title", title)
            command.Parameters.AddWithValue("@Description", description)
            command.Parameters.AddWithValue("@Location", location)
            command.Parameters.AddWithValue("@Latitude", latitude)
            command.Parameters.AddWithValue("@Longitude", longitude)
            command.Parameters.AddWithValue("@Pax", pax)
            command.Parameters.AddWithValue("@RequestID", RequestID)
            command.ExecuteNonQuery()
        Else
            'if not just proceed
            sql += ",pax = @Pax WHERE RequestID = @RequestID"
            command = New OleDbCommand(sql, connect)
            command.Parameters.AddWithValue("@Title", title)
            command.Parameters.AddWithValue("@Description", description)
            command.Parameters.AddWithValue("@Location", location)
            command.Parameters.AddWithValue("@Pax", pax)
            command.Parameters.AddWithValue("@RequestID", RequestID)
            command.ExecuteNonQuery()
        End If

        MsgBox("Item Updated.", 0 & MsgBoxStyle.Information, "Updated")

        requestForm.RefreshData()
        connect.Close()
        Me.Close()
    End Sub
End Class