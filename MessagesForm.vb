Imports System.Data.OleDb

Public Class MessagesForm
    Dim connect As New OleDbConnection
    Dim command As New OleDbCommand
    Dim sql As String = Nothing

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub MessagesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\CJ\OMC\OMC database.accdb;"

        LoadMessages()
    End Sub

    Public Sub LoadMessages()
        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If
        Dim username As String = AdminMessagesForm.globalUserName
        Dim userID As String

        sql = "SELECT ID FROM [User] WHERE username = @Username"
        command = New OleDbCommand(sql, connect)
        command.Parameters.AddWithValue("@Username", username)
        Dim reader As OleDbDataReader = command.ExecuteReader()

        If reader.Read() Then
            userID = reader("ID").ToString()
        End If

        Dim table As New TableLayoutPanel
        table.ColumnCount = 1
        'table.Location = New System.Drawing.Point(79, 94)
        table.Name = "TableLayoutPanel1"
        table.AutoSize = True
        table.TabIndex = 0
        ' Clear the existing message panels in the container control
        table.Controls.Clear()



        ' Execute a query to fetch the messages between the two users
        sql = "SELECT * FROM Messages WHERE (senderID = @User1 AND recipientID = @User2) OR (senderID = @User2 AND recipientID = @User1) ORDER BY Timestamp"
        Using command As New OleDbCommand(sql, connect)
            command.Parameters.AddWithValue("@User1", userID)
            command.Parameters.AddWithValue("@User2", "admin")

            ' Retrieve the results
            Using reader1 As OleDbDataReader = command.ExecuteReader()
                ' Create custom panels for each message
                While reader1.Read()
                    Dim sender As String = reader1("senderID").ToString()
                    Dim message As String = reader1("message").ToString()

                    ' Create a custom panel for the message
                    Dim messagePanel As New Panel()
                    messagePanel.Width = table.Width - 20
                    messagePanel.AutoSize = True

                    ' Set the position of the message panel based on the sender
                    If sender = "admin" Then
                        messagePanel.BackColor = Color.LightBlue
                        messagePanel.Anchor = AnchorStyles.Right
                    Else
                        messagePanel.BackColor = Color.LightGreen
                        messagePanel.Anchor = AnchorStyles.Left
                    End If

                    ' Create a label for the message
                    Dim messageLabel As New Label()
                    messageLabel.Text = message
                    messageLabel.AutoSize = True

                    ' Add the label to the message panel
                    messagePanel.Controls.Add(messageLabel)

                    ' Add the message panel to the container control
                    table.Controls.Add(messagePanel)
                End While
                pnlMessages.Controls.Add(table)
            End Using
        End Using
        connect.Close()
    End Sub
End Class