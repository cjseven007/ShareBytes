Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Data.OleDb
Imports System.Runtime.Remoting.Contexts

Public Class UserMessageForm
    Dim connect As New OleDbConnection
    Dim command As New OleDbCommand
    Dim sql As String = Nothing
    Dim currentSender As String
    Dim userID As String = LoginForm.globalUserID

    Private Sub UserMessageForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\CJ\OMC\OMC database.accdb;"

        LoadMessages()
    End Sub
    Public Sub LoadMessages()
        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If


        pnlMessages.Controls.Clear()
        Dim table As New TableLayoutPanel
        table.ColumnCount = 1
        'table.Location = New System.Drawing.Point(79, 94)
        table.Name = "TableLayoutPanel1"
        table.Width = 600
        table.AutoSize = True
        table.TabIndex = 0
        ' Clear the existing message panels in the container control
        table.Controls.Clear()



        ' Execute a query to fetch the messages between the two users
        Sql = "SELECT * FROM Messages WHERE (senderID = @User1 AND recipientID = @User2) OR (senderID = @User2 AND recipientID = @User1) ORDER BY Timestamp"
        Using command As New OleDbCommand(Sql, connect)
            command.Parameters.AddWithValue("@User1", userID)
            command.Parameters.AddWithValue("@User2", "admin")

            ' Retrieve the results
            Using reader1 As OleDbDataReader = command.ExecuteReader()
                ' Create custom panels for each message
                While reader1.Read()
                    currentSender = reader1("senderID").ToString()
                    Dim message As String = reader1("message").ToString()

                    ' Create a custom panel for the message
                    Dim messagePanel As New Panel()
                    messagePanel.Width = table.Width
                    messagePanel.AutoSize = True

                    ' Set the position of the message panel based on the sender
                    If currentSender = userID Then
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
                    messageLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

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
    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If txtMessage.Text = "" Then
            MsgBox("Please input a message.", 0 + MsgBoxStyle.Exclamation, "EMPTY MESSAGE")
        Else
            Dim message As String = txtMessage.Text

            If connect.State = ConnectionState.Closed Then
                connect.Open()
            End If

            sql = "INSERT INTO Messages (senderID, recipientID, [timeStamp], message) VALUES (@SenderID, @RecipientID, @TimeStamp, @Message)"

            Dim timeStamp As String = Format(DateTime.Now, "yyyy/MM/dd HH:mm:ss")
            command = New OleDbCommand(sql, connect)
            command.Parameters.AddWithValue("@SenderID", userID)
            command.Parameters.AddWithValue("@RecipientID", "admin")
            command.Parameters.AddWithValue("@TimeStamp", timeStamp)
            command.Parameters.AddWithValue("@Message", message)

            command.ExecuteNonQuery()

            LoadMessages()
            txtMessage.Clear()
        End If
    End Sub


End Class