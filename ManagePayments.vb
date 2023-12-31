﻿Imports System.Data.OleDb
Imports Microsoft.VisualBasic.ApplicationServices

Public Class ManagePayments
    Dim connect As New OleDbConnection
    Dim command As New OleDbCommand
    Dim sql As String = Nothing

    Private Sub ManagePaymentRefreshData()
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
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvManage.SelectedRows.Count > 0 Then
            ' Get the value of the ID column for the selected row
            Dim res As String = MsgBox("Are you sure you want to delete account?", MsgBoxStyle.YesNo, "DELETE USER")
            If res = vbYes Then
                Dim id As Integer = CInt(dgvManage.SelectedRows(0).Cells("ID").Value)
                If connect.State = ConnectionState.Closed Then
                    connect.Open()
                End If
                sql = "DELETE FROM PaymentMethod WHERE ID = @ID"
                command = New OleDbCommand(sql, connect)
                command.Parameters.AddWithValue("@ID", id.ToString())
                command.ExecuteNonQuery()
                MsgBox("Account Deleted", 0 & MsgBoxStyle.Information, "ACCOUNT DELETED")
                ManagePaymentRefreshData()
            End If



        End If
    End Sub

    Private Sub ManagePayments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\CJ\OMC\OMC database.accdb;"

        ManagePaymentRefreshData()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()
    End Sub
End Class