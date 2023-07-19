Imports System.Data.OleDb

Public Class AdminRevenueForm
    Dim connect As New OleDbConnection
    Dim command As New OleDbCommand
    Dim sql As String = Nothing
    Dim totalRevenue As Double
    Private Sub AdminRevenueForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\CJ\OMC\OMC database.accdb;"

        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If

        sql = "SELECT * FROM Donations WHERE deliverStatus = 'Delivered'"
        command = New OleDbCommand(sql, connect)
        command.Parameters.AddWithValue("@RiderID", LoginForm.globalUserID)
        Dim reader As OleDbDataReader = command.ExecuteReader()
        dgvDelivery.Rows.Clear()
        While reader.Read()
            Dim deliveryID As String = reader("ID").ToString()
            Dim distance As String = reader("distance").ToString()
            Dim fare As String = (CDbl(reader("fare").ToString()) * 0.3).ToString("0.00")
            totalRevenue += CDbl(fare)
            Dim requestID As String = reader("requestID").ToString()
            Dim row As DataGridViewRow = New DataGridViewRow()
            row.CreateCells(dgvDelivery)
            ' Set the value for each column in the row
            sql = "SELECT * FROM Requests WHERE RequestID = @RequestID"
            command = New OleDbCommand(sql, connect)
            command.Parameters.AddWithValue("@RequestID", requestID)
            Dim reader1 As OleDbDataReader = command.ExecuteReader()
            If reader1.Read() Then
                Dim title As String = reader1("title").ToString()
                row.Cells(0).Value = deliveryID
                row.Cells(1).Value = title
                row.Cells(2).Value = distance & " km"
                row.Cells(3).Value = "RM " & fare
            End If



            dgvDelivery.Rows.Add(row)
        End While
        lblRevenue.Text = "RM " & totalRevenue.ToString("0.00")
    End Sub
End Class