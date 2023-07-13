Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class AdminMessagesForm
    Public Shared globalUserName As String

    Dim connect As New OleDbConnection
    Dim command As New OleDbCommand
    Dim sql As String = Nothing

    Private Sub AdminMessagesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\CJ\OMC\OMC database.accdb;"
        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If
        PopulateUserPanels()
    End Sub

    Private Sub PopulateUserPanels()
        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If
        'Retrieve data from database
        sql = "SELECT DISTINCT senderID FROM Messages"
        'Get donorID to retrieve data accordingly
        command = New OleDbCommand(sql, connect)
        Dim reader As OleDbDataReader = command.ExecuteReader()

        Dim table As New TableLayoutPanel
        table.ColumnCount = 1
        'table.Location = New System.Drawing.Point(79, 94)
        table.Name = "TableLayoutPanel1"
        table.AutoSize = True
        table.TabIndex = 0

        'Dim row As Integer = 0 ' Start with the first row
        'Dim col As Integer = 0 ' Start with the first column

        While reader.Read()
            Dim sender As String = reader("senderID").ToString()
            If sender <> "admin" Then
                Dim userID As String = reader("senderID").ToString()

                sql = "SELECT * FROM [User] WHERE ID = @UserID"
                command = New OleDbCommand(sql, connect)
                command.Parameters.AddWithValue("@UserID", userID)
                Dim reader1 As OleDbDataReader = command.ExecuteReader()

                If reader1.Read() Then
                    Dim username As String = reader1("username").ToString()
                    ' Create a custom panel
                    Dim userPanel As Panel = New Panel()
                    userPanel.BorderStyle = BorderStyle.FixedSingle
                    userPanel.Width = 350
                    userPanel.Height = 50
                    userPanel.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                    userPanel.BorderStyle = BorderStyle.None

                    ''Handler for the panel on click to display messages
                    AddHandler userPanel.Click, AddressOf UserPanel_Click


                    ' Create a label for the username
                    Dim usernameLabel As New Label()
                    usernameLabel.Text = username
                    usernameLabel.Location = New Point(10, 10)
                    usernameLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    usernameLabel.AutoSize = True

                    ' Create a label for the latest message
                    Dim latestMessageLabel As New Label()
                    latestMessageLabel.Text = ""
                    latestMessageLabel.AutoSize = True

                    ' Add the labels to the user panel
                    userPanel.Controls.Add(usernameLabel)
                    userPanel.Controls.Add(latestMessageLabel)

                    ' Add the user panel to the FlowLayoutPanel
                    table.Controls.Add(userPanel)
                End If

            End If

        End While
        pnlMessages.Controls.Add(table)

    End Sub

    Private Sub UserPanel_Click(sender As Object, e As EventArgs)
        ' Perform the logic to display chat messages for the selected user
        ' You can access the clicked user panel using the "sender" parameter
        Dim clickedUserPanel As Panel = DirectCast(sender, Panel)

        ' Retrieve the necessary information from the clicked user panel
        ' For example, you can access the username label and latest message label
        Dim usernameLabel As Label = clickedUserPanel.Controls(0)

        ' Retrieve the username and perform the necessary actions
        Dim username As String = usernameLabel.Text
        globalUserName = usernameLabel.Text
        ' ...
        MessagesForm.ShowDialog()
    End Sub

End Class