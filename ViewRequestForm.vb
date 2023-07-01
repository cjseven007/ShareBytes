Imports System.Data.OleDb

Public Class ViewRequestForm
    Private donateForm As DonateForm ' Reference to requestForm
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

    Public Sub New(donateForm As DonateForm)
        InitializeComponent()
        Me.donateForm = donateForm
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub ViewRequestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\CJ\OMC\OMC database.accdb;"
        lblTitle.Text = Title
        lblDescription.Text = Description
        lblLocation.Text = Location
        lblPax.Text = Pax
    End Sub

    Private Sub btnDonate_Click(sender As Object, e As EventArgs) Handles btnDonate.Click

        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If
        sql = "UPDATE Requests SET status = @Status where RequestID = @RequestID"
        command = New OleDbCommand(sql, connect)
        command.Parameters.AddWithValue("@Status", "Pending")
        command.Parameters.AddWithValue("@RequestID", RequestID)

        command.ExecuteNonQuery()
        MsgBox("Donation record addedd. Status: Pending", 0, "Donation Added")

        donateForm.DonateFormRefreshData()
        Me.Close()
    End Sub
End Class