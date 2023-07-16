Imports System.Data.OleDb

Public Class AdminUserForm
    Dim connect As New OleDbConnection
    Dim command As New OleDbCommand
    Dim sql As String = Nothing


    Private Sub LoadData(ByVal sql As String)

        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If


        command = New OleDbCommand(sql, connect)
        Dim reader As OleDbDataReader = command.ExecuteReader()
        dgvUser.Rows.Clear()
        While reader.Read()
            Dim row As DataGridViewRow = New DataGridViewRow()
            row.CreateCells(dgvUser)
            ' Set the value for each column in the row

            row.Cells(0).Value = reader("ID").ToString()
            row.Cells(1).Value = reader("email").ToString()
            row.Cells(2).Value = reader("username").ToString()
            row.Cells(3).Value = reader("usertype").ToString()
            row.Cells(4).Value = reader("organization").ToString()

            dgvUser.Rows.Add(row)

        End While
        connect.Close()
    End Sub
    Private Sub AdminUserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\CJ\OMC\OMC database.accdb;"
        sql = "SELECT * FROM [user] ORDER BY ID ASC"
        LoadData(sql)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim userName As String = txtSearch.Text
        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If

        sql = "SELECT * FROM [user] WHERE username LIKE @Username ORDER BY ID ASC"

        command = New OleDbCommand(sql, connect)
        command.Parameters.AddWithValue("@Username", "%" & userName & "%")
        Dim reader As OleDbDataReader = command.ExecuteReader()
        dgvUser.Rows.Clear()
        While reader.Read()
            Dim row As DataGridViewRow = New DataGridViewRow()
            row.CreateCells(dgvUser)
            ' Set the value for each column in the row

            row.Cells(0).Value = reader("ID").ToString()
            row.Cells(1).Value = reader("email").ToString()
            row.Cells(2).Value = reader("username").ToString()
            row.Cells(3).Value = reader("usertype").ToString()
            row.Cells(4).Value = reader("organization").ToString()

            dgvUser.Rows.Add(row)

        End While
        connect.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvUser.SelectedRows.Count > 0 Then
            ' Get the value of the ID column for the selected row
            Dim res As String = MsgBox("Are you sure you want to delete this user? This operation is irreversible.", MsgBoxStyle.YesNo, "DELETE USER")
            If res = vbYes Then
                Dim id As Integer = CInt(dgvUser.SelectedRows(0).Cells("ID").Value)
                If connect.State = ConnectionState.Closed Then
                    connect.Open()
                End If
                sql = "DELETE FROM [User] WHERE ID = @UserID"
                command = New OleDbCommand(sql, connect)
                command.Parameters.AddWithValue("@UserID", id.ToString())
                command.ExecuteNonQuery()
                MsgBox("User Deleted", 0 & MsgBoxStyle.Information, "USER DELETED")
                sql = "SELECT * FROM [user] ORDER BY ID ASC"
                LoadData(sql)
            End If



        End If
    End Sub
End Class