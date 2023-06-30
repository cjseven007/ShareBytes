Imports System.Data.OleDb

Public Class AddRequestForm
    Dim connect As New OleDbConnection
    Dim command As New OleDbCommand
    Dim sql As String = Nothing
    Private requestForm As RequestForm ' Reference to requestForm


    Public Sub New(requestForm As RequestForm)
        InitializeComponent()
        Me.requestForm = requestForm
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub AddRequestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\CJ\OMC\OMC database.accdb;"
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddRequest.Click
        Dim title As String = txtRTitle.Text
        Dim description As String = txtRDescription.Text
        Dim location As String = txtRLocation.Text
        Dim latitude As String = SelectLocationForm.latitudeGlobal
        Dim longitude As String = SelectLocationForm.longitudeGlobal
        Dim address As String = SelectLocationForm.addressGlobal
        Dim pax As String = nudRPax.Text

        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If

        Dim requestorID As Integer = LoginForm.globalUserID

        sql = "INSERT INTO Requests (requestorID, title, description, location, latitude, longitude, pax) VALUES (@RequestorID, @Title, @Description, @Location, @Latitude, @Longitude, @Pax)"

        command = New OleDbCommand(sql, connect)
        command.Parameters.AddWithValue("@RequestorID", requestorID)
        command.Parameters.AddWithValue("@Title", title)
        command.Parameters.AddWithValue("@Description", description)
        command.Parameters.AddWithValue("@Location", location)
        command.Parameters.AddWithValue("@Latitude", latitude)
        command.Parameters.AddWithValue("@Longitude", longitude)
        command.Parameters.AddWithValue("@Pax", pax)

        command.ExecuteNonQuery()
        MsgBox("Request Successful.", 0 & MsgBoxStyle.Information, "Success")
        requestForm.RefreshData()
        Me.Close()
    End Sub

    Private Sub btnSelectLocation_Click(sender As Object, e As EventArgs) Handles btnSelectLocation.Click
        Dim locationForm As New SelectLocationForm(Me)
        locationForm.ShowDialog()
    End Sub
End Class