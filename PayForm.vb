Imports System.Data.OleDb
Imports System.Runtime.Remoting.Contexts
Imports Microsoft.VisualBasic.ApplicationServices

Public Class PayForm
    Dim connect As New OleDbConnection
    Dim command As New OleDbCommand
    Dim sql As String = Nothing

    Private _requestID As Integer

    Public Sub New(requestID As Integer)
        InitializeComponent()
        _requestID = requestID
    End Sub

    Private Sub PayFormRefreshData()
        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If

        sql = "SELECT * FROM PaymentMethod WHERE userID = @UserID"
        command = New OleDbCommand(sql, connect)
        Dim userID As String = LoginForm.globalUserID.ToString()
        command.Parameters.AddWithValue("@UserID", userID)
        Dim reader As OleDbDataReader = command.ExecuteReader()
        dgvManage.Rows.Clear()
        While reader.Read()
            Dim row As DataGridViewRow = New DataGridViewRow()
            row.CreateCells(dgvManage)
            ' Set the value for each column in the row
            row.Cells(0).Value = reader("ID").ToString()
            row.Cells(1).Value = reader("paymentType").ToString()
            row.Cells(2).Value = reader("accountType").ToString()
            row.Cells(3).Value = reader("accountNum").ToString()


            dgvManage.Rows.Add(row)

        End While
        connect.Close()
    End Sub
    Private Sub PayForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\CJ\OMC\OMC database.accdb;"

        PayFormRefreshData()
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click

        'Get paymentID
        If dgvManage.SelectedRows.Count > 0 Then
            ' Get the value of the ID column for the selected row

            Dim id As Integer = CInt(dgvManage.SelectedRows(0).Cells("ID").Value)
            If connect.State = ConnectionState.Closed Then
                connect.Open()


            End If
            sql = "UPDATE Donations SET deliverStatus = 'Paid', paymentID = @paymentID WHERE requestID = @RequestID"
            command = New OleDbCommand(sql, connect)
            command.Parameters.AddWithValue("@paymentID", id.ToString())
            command.Parameters.AddWithValue("@paymentID", _requestID)
            command.ExecuteNonQuery()
            MsgBox("Payment successful", 0 & MsgBoxStyle.Information, "PAID")
            Me.Close()
        End If


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class