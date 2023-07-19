Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.IO
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


            'Create a receipt
            Try

                sql = "SELECT * FROM [User] WHERE ID = @UserID"
                command = New OleDbCommand(sql, connect)
                command.Parameters.AddWithValue("@UserID", LoginForm.globalUserID)
                Dim reader As OleDbDataReader = command.ExecuteReader()

                If reader.Read() Then
                    ' Specify the file path and name
                    Dim fileName As String = "receipt_ID" & _requestID.ToString() & ".txt"

                    ' Combine the file path with the application's startup path to create the full file path
                    Dim filePath As String = Path.Combine(Application.StartupPath, fileName)

                    ' Create a new text file and write the content to it
                    Using writer As New StreamWriter(filePath)
                        writer.WriteLine("Receipt Of Payment")
                        writer.WriteLine("Request ID:" & _requestID.ToString())
                        writer.WriteLine("Paid by: " & reader("ID").ToString() & " - " & reader("username").ToString())
                        writer.WriteLine("_______________________________________________")
                        sql = "SELECT * FROM Donations WHERE requestID = @RequestID"
                        command = New OleDbCommand(sql, connect)
                        command.Parameters.AddWithValue("@ReqeustID", _requestID)
                        Dim reader1 As OleDbDataReader = command.ExecuteReader()
                        While reader1.Read()

                            writer.WriteLine("Amount: RM" & reader1("fare").ToString())
                        End While


                    End Using

                    MessageBox.Show("Text written to file successfully.", "File Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If


            Catch ex As Exception
                MessageBox.Show("Error writing to file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Me.Close()
        End If


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class