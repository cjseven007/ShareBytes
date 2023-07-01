Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles
Imports System.Xml
Imports ComponentFactory.Krypton.Toolkit

Public Class DonateForm
    Dim connect As New OleDbConnection
    Dim command As New OleDbCommand
    Dim sql As String = Nothing

    Private Sub button_Click(sender As Object, e As EventArgs)
        ' Handle the Edit button click event
        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If
        Dim button As KryptonButton = DirectCast(sender, KryptonButton)
        Dim requestID As Integer = CInt(button.Tag)
        sql = "SELECT title, description, location, latitude, longitude, pax FROM Requests WHERE RequestID = @RequestID"
        command = New OleDbCommand(sql, connect)
        command.Parameters.AddWithValue("@RequestID", OleDbType.VarChar).Value = requestID

        Dim reader As OleDbDataReader = command.ExecuteReader()

        If reader.Read() Then ' Check if there is a row of data
            Dim viewRequestForm As New ViewRequestForm(Me)
            ' Set the product values in the edit form
            viewRequestForm.RequestID = requestID
            viewRequestForm.Title = reader("title").ToString()
            viewRequestForm.Description = reader("description").ToString() ' Set the retrieved product value
            viewRequestForm.Location = reader("location").ToString() ' Set the retrieved quantity value
            viewRequestForm.Pax = reader("pax").ToString() ' Set the retrieved expiry date value

            ' Show the InventoryEditForm
            viewRequestForm.ShowDialog()
        End If

        reader.Close()
    End Sub

    Public Sub DonateFormRefreshData()
        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If

        'Retrieve data from database
        sql = "SELECT RequestID, title, description, location, latitude, longitude, pax, status FROM Requests"

        command = New OleDbCommand(sql, connect)
        Dim reader As OleDbDataReader = command.ExecuteReader()

        Dim table As New TableLayoutPanel
        table.ColumnCount = 2
        table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50))
        table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50))
        'table.Location = New System.Drawing.Point(79, 94)
        table.Name = "TableLayoutPanel1"
        table.AutoSize = True
        table.TabIndex = 0

        Dim row As Integer = 0 ' Start with the first row
        Dim col As Integer = 0 ' Start with the first column

        While reader.Read()
            Dim status As Object = reader("status")
            If status Is DBNull.Value Then ' Check if the status column is null
                Dim customContainer As Panel = New Panel()
                customContainer.BorderStyle = BorderStyle.FixedSingle
                customContainer.Width = 300
                customContainer.Height = 180
                customContainer.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                customContainer.BorderStyle = BorderStyle.None

                ' Set the column and row location of the custom container
                table.SetColumn(customContainer, col)
                table.SetRow(customContainer, row)

                Dim titleLabel As Label = New Label()
                titleLabel.Text = reader("title").ToString()
                titleLabel.Location = New Point(10, 10)
                titleLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                titleLabel.Name = "lblTitle"
                titleLabel.Size = New System.Drawing.Size(250, 20)
                titleLabel.AutoEllipsis = True

                Dim descriptionLabel As Label = New Label()
                descriptionLabel.Text = "Description: " & reader("description").ToString()
                descriptionLabel.Location = New Point(10, 30)
                descriptionLabel.AutoEllipsis = True
                descriptionLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                descriptionLabel.Name = "lblDescription"
                descriptionLabel.Size = New System.Drawing.Size(250, 60)

                Dim paxLabel As Label = New Label()
                paxLabel.Text = "Pax: " & reader("pax").ToString()
                paxLabel.Location = New Point(10, 90)
                paxLabel.AutoSize = True
                paxLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                paxLabel.Name = "lblPax"



                Dim button As KryptonButton = New KryptonButton()
                button.Values.Text = "View"

                button.Location = New System.Drawing.Point(185, 135)
                button.Name = "btnView"
                button.OverrideDefault.Back.Color1 = System.Drawing.Color.Gold
                button.OverrideDefault.Back.Color2 = System.Drawing.Color.Gold
                button.Size = New System.Drawing.Size(100, 30)
                button.StateCommon.Back.Color1 = System.Drawing.Color.Gold
                button.StateCommon.Back.Color2 = System.Drawing.Color.Gold
                button.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
                button.StateCommon.Border.Rounding = 10
                button.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black
                button.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black
                button.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

                'Get request ID and handles the view button
                Dim requestID As Integer = reader.GetInt32(reader.GetOrdinal("RequestID"))
                button.Tag = requestID
                AddHandler button.Click, AddressOf button_Click


                customContainer.Controls.Add(titleLabel)
                customContainer.Controls.Add(descriptionLabel)
                customContainer.Controls.Add(paxLabel)
                customContainer.Controls.Add(button)


                ' Add the custom container to the form or container control

                table.Controls.Add(customContainer)

                col += 1 ' Move to the next column

                ' Check if we have reached the end of the row
                If col >= table.ColumnCount Then
                    col = 0 ' Reset column
                    row += 1 ' Move to the next row
                End If
            End If
        End While
        pnlGridView.Controls.Clear() 'Clear Existing Control
        pnlGridView.Controls.Add(table)
    End Sub
    Private Sub DonateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\CJ\OMC\OMC database.accdb;"

        DonateFormRefreshData()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        DonateFormRefreshData()
    End Sub
End Class