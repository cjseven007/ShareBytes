Imports System.Data.OleDb

Public Class ViewDonationForm
    Dim connect As New OleDbConnection
    Dim command As New OleDbCommand
    Dim sql As String = Nothing
    Dim donateID, requestTitle, donorOrg, donateDistance, donateFare, status As String

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Public Sub New(ByVal donationID As String, ByVal title As String, ByVal organization As String, ByVal distance As String, ByVal fare As String, ByVal deliverStatus As String)
        ' This constructor accepts all the parameters

        ' Perform any initialization or processing with the passed values here
        InitializeComponent()

        ' Set the values to the corresponding controls in OtherForm
        donateID = donationID
        requestTitle = title
        donorOrg = organization
        donateDistance = distance
        donateFare = fare
        status = deliverStatus
    End Sub
    Private Sub ViewDonationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\CJ\OMC\OMC database.accdb;"
        lblTitle.Text = requestTitle
        lblDonor.Text = donorOrg
        lblDistance.Text = donateDistance & " km"
        lblFare.Text = "RM " & donateFare
        lblStatus.Text = status

        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If
        sql = "SELECT * FROM Donations WHERE ID = @DonationID"
        command = New OleDbCommand(sql, connect)
        command.Parameters.AddWithValue("@DonationID", donateID)
        Dim reader As OleDbDataReader = command.ExecuteReader()
        While reader.Read()
            Dim itemString As String = reader("itemsList").ToString()
            Dim subIDs() As String = itemString.Split(" "c)
            If connect.State = ConnectionState.Closed Then
                connect.Open()
            End If
            For Each id As String In subIDs
                sql = "SELECT * FROM Inventory WHERE ID = @ProductID"
                command = New OleDbCommand(sql, connect)
                command.Parameters.AddWithValue("@ProductID", id)
                Dim reader1 As OleDbDataReader = command.ExecuteReader()
                While reader1.Read()
                    Dim itemName As String = reader1("product").ToString()
                    Dim quantity As String = reader1("quantity").ToString()
                    Dim itemText As String = String.Format("{0}, quantity: {1}", itemName, quantity)

                    lstDonationItem.Items.Add(itemText)
                End While

            Next
        End While
    End Sub
End Class