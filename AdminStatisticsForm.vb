Imports System.Data.OleDb
Imports System.Runtime.Remoting.Contexts

Public Class AdminStatisticsForm
    Dim connect As New OleDbConnection
    Dim command As New OleDbCommand
    Dim sql As String = Nothing
    Private Sub AdminStatisticsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\CJ\OMC\OMC database.accdb;"
        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If
        'Get number of donors
        Sql = "SELECT * FROM [user] WHERE usertype = @UserType"
        Command = New OleDbCommand(Sql, connect)
        Command.Parameters.AddWithValue("@UserType", "Donor")

        Dim reader As OleDbDataReader = Command.ExecuteReader()
        Dim donorNum As Integer
        While reader.Read()
            donorNum += 1
        End While

        lblDonor.Text = donorNum.ToString()

        'Get number of requestors
        Sql = "SELECT * FROM [user] WHERE usertype = @UserType"
        Command = New OleDbCommand(Sql, connect)
        Command.Parameters.AddWithValue("@UserType", "Requestor")
        reader = Command.ExecuteReader()

        Dim requestorNum As Integer
        While reader.Read()
            requestorNum += 1
        End While

        lblRequestor.Text = requestorNum.ToString()

        'Get number of requests made
        Sql = "SELECT * FROM Requests"
        Command = New OleDbCommand(Sql, connect)
        reader = Command.ExecuteReader()

        Dim requestsNum As Integer
        While reader.Read()
            requestsNum += 1
        End While

        lblRequests.Text = requestsNum.ToString()

        'Get number of successful donations
        Sql = "SELECT * FROM Donations"
        Command = New OleDbCommand(Sql, connect)
        reader = Command.ExecuteReader()

        Dim successfulDonationNum As Integer
        While reader.Read()
            successfulDonationNum += 1
        End While

        lblSuccess.Text = successfulDonationNum.ToString()
    End Sub
End Class