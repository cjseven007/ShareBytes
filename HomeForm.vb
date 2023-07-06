Imports System.Data.OleDb

Public Class HomeForm
    Dim connect As New OleDbConnection
    Dim command As New OleDbCommand
    Dim sql As String = Nothing
    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\CJ\OMC\OMC database.accdb;"
        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If
        'Get number of donors
        sql = "SELECT * FROM [user] WHERE usertype = @UserType"
        command = New OleDbCommand(sql, connect)
        command.Parameters.AddWithValue("@UserType", "Donor")

        Dim reader As OleDbDataReader = command.ExecuteReader()
        Dim donorNum As Integer
        While reader.Read()
            donorNum += 1
        End While

        lblDonor.Text = donorNum.ToString()

        'Get number of requestors
        sql = "SELECT * FROM [user] WHERE usertype = @UserType"
        command = New OleDbCommand(sql, connect)
        command.Parameters.AddWithValue("@UserType", "Requestor")
        reader = command.ExecuteReader()

        Dim requestorNum As Integer
        While reader.Read()
            requestorNum += 1
        End While

        lblRequestor.Text = requestorNum.ToString()

        'Get number of requests made
        sql = "SELECT * FROM Requests"
        command = New OleDbCommand(sql, connect)
        reader = command.ExecuteReader()

        Dim requestsNum As Integer
        While reader.Read()
            requestsNum += 1
        End While

        lblRequests.Text = requestsNum.ToString()

        'Get number of successful donations
        sql = "SELECT * FROM Donations"
        command = New OleDbCommand(sql, connect)
        reader = command.ExecuteReader()

        Dim successfulDonationNum As Integer
        While reader.Read()
            successfulDonationNum += 1
        End While

        lblSuccess.Text = successfulDonationNum.ToString()
    End Sub
End Class