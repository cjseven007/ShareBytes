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
        sql = "SELECT requestorID, title, description, location, latitude, longitude, pax FROM Requests WHERE RequestID = @RequestID"
        command = New OleDbCommand(sql, connect)
        command.Parameters.AddWithValue("@RequestID", OleDbType.VarChar).Value = requestID

        Dim reader As OleDbDataReader = command.ExecuteReader()

        If reader.Read() Then ' Check if there is a row of data
            Dim viewRequestForm As New ViewRequestForm(Me)
            ' Set the product values in the edit form
            viewRequestForm.RequestorID = reader("requestorID").ToString()
            viewRequestForm.RequestID = requestID
            viewRequestForm.Title = reader("title").ToString()
            viewRequestForm.Description = reader("description").ToString() ' Set the retrieved product value
            viewRequestForm.Location = reader("location").ToString() ' Set the retrieved quantity value
            viewRequestForm.Pax = reader("pax").ToString() ' Set the retrieved expiry date value
            viewRequestForm.Latitude = reader("latitude").ToString()
            viewRequestForm.Longitude = reader("longitude").ToString()

            ' Show the InventoryEditForm
            viewRequestForm.ShowDialog()
        End If

        reader.Close()
    End Sub


    ' Function to calculate the distance using the Haversine formula
    ' This is for the distance label in the custom container
    Private Function CalculateDistance(lat1 As Double, lon1 As Double, lat2 As Double, lon2 As Double) As Double
        Dim R As Double = 6371 ' Earth's radius in kilometers

        Dim dLat As Double = DegreeToRadian(lat2 - lat1)
        Dim dLon As Double = DegreeToRadian(lon2 - lon1)

        Dim a As Double = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                      Math.Cos(DegreeToRadian(lat1)) * Math.Cos(DegreeToRadian(lat2)) *
                      Math.Sin(dLon / 2) * Math.Sin(dLon / 2)

        Dim c As Double = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a))

        Dim distance As Double = R * c
        Return distance
    End Function

    Private Function DegreeToRadian(deg As Double) As Double
        Return deg * (Math.PI / 180)
    End Function

    ' Create a class to store the request data and its distance
    Private Class RequestData
        Public Property RequestID As Integer
        Public Property Title As String
        Public Property Description As String
        Public Property Location As String
        Public Property Latitude As Double
        Public Property Longitude As Double
        Public Property Pax As Integer
        Public Property Status As String
        Public Property Distance As Double
    End Class

    Public Sub DonateFormRefreshData()
        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If

        'Get user latitude and longitude
        Dim userID As Integer = LoginForm.globalUserID
        sql = "SELECT latitude, longitude FROM [User] WHERE ID = @UserID"
        command = New OleDbCommand(sql, connect)
        command.Parameters.AddWithValue("@UserID", userID)
        Dim reader1 As OleDbDataReader = command.ExecuteReader()


        Dim userLatitude As Double
        Dim userLongitude As Double
        If reader1.Read() Then
            userLatitude = CDbl(reader1("latitude"))
            userLongitude = CDbl(reader1("longitude"))
            reader1.Close()
        Else
            reader1.Close()
        End If

        ' Create a list to store the request data with distance
        Dim requestDataList As New List(Of RequestData)()

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

                ' Retrieve request information from the database
                Dim latitude As Double = CDbl(reader("latitude"))
                Dim longitude As Double = CDbl(reader("longitude"))
                ' Calculate the distance using the Haversine formula
                Dim distance As Double = CalculateDistance(userLatitude, userLongitude, latitude, longitude)
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                ' Create a new RequestData object and populate it with the request information
                Dim requestData As New RequestData() With {
                        .RequestID = CInt(reader("RequestID")),
                        .Title = reader("title").ToString(),
                        .Description = reader("description").ToString(),
                        .Location = reader("location").ToString(),
                        .Latitude = latitude,
                        .Longitude = longitude,
                        .Pax = CInt(reader("pax")),
                        .Status = reader("status").ToString(),
                        .Distance = distance
                    }

                requestDataList.Add(requestData)
            End If
        End While
        ' Sort the list based on distance (from nearest to furthest)
        requestDataList = requestDataList.OrderBy(Function(data) data.Distance).ToList()

        For Each requestData As RequestData In requestDataList
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
            titleLabel.Text = requestData.Title
            titleLabel.Location = New Point(10, 10)
            titleLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            titleLabel.Name = "lblTitle"
            titleLabel.Size = New System.Drawing.Size(250, 20)
            titleLabel.AutoEllipsis = True

            Dim descriptionLabel As Label = New Label()
            descriptionLabel.Text = "Description: " & requestData.Description
            descriptionLabel.Location = New Point(10, 30)
            descriptionLabel.AutoEllipsis = True
            descriptionLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            descriptionLabel.Name = "lblDescription"
            descriptionLabel.Size = New System.Drawing.Size(250, 60)

            Dim paxLabel As Label = New Label()
            paxLabel.Text = "Pax: " & requestData.Pax
            paxLabel.Location = New Point(10, 90)
            paxLabel.AutoSize = True
            paxLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            paxLabel.Name = "lblPax"



            Dim distanceLabel As Label = New Label()
            distanceLabel.Text = "Distance: " & requestData.Distance.ToString("F2") & " km from you"
            distanceLabel.Location = New Point(10, 110)
            distanceLabel.AutoSize = True
            distanceLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            distanceLabel.Name = "lblPax"



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
            Dim requestID As Integer = requestData.RequestID
            button.Tag = requestID
            AddHandler button.Click, AddressOf button_Click


            customContainer.Controls.Add(titleLabel)
            customContainer.Controls.Add(descriptionLabel)
            customContainer.Controls.Add(paxLabel)
            customContainer.Controls.Add(distanceLabel)
            customContainer.Controls.Add(button)


            ' Add the custom container to the form or container control

            table.Controls.Add(customContainer)

            col += 1 ' Move to the next column

            ' Check if we have reached the end of the row
            If col >= table.ColumnCount Then
                col = 0 ' Reset column
                row += 1 ' Move to the next row
            End If
        Next

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