Imports System.Data.OleDb
Imports ComponentFactory.Krypton.Toolkit

Public Class RequestForm
    Dim connect As New OleDbConnection
    Dim command As New OleDbCommand
    Dim sql As String = Nothing


    Private Sub btnEdit_Click(sender As Object, e As EventArgs)
        ' Handle the Edit button click event
        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If
        Dim button As KryptonButton = DirectCast(sender, KryptonButton)
        Dim requestID As Integer = CInt(button.Tag)
        sql = "SELECT title, description, location, pax FROM Requests WHERE RequestID = @RequestID"
        command = New OleDbCommand(sql, connect)
        command.Parameters.AddWithValue("@RequestID", OleDbType.VarChar).Value = requestID

        Dim reader As OleDbDataReader = command.ExecuteReader()

        If reader.Read() Then ' Check if there is a row of data
            Dim editRequestForm As New EditRequestForm(Me)
            ' Set the request values in the edit form
            editRequestForm.RequestID = requestID
            editRequestForm.Title = reader("title").ToString() ' Set the retrieved title
            editRequestForm.Description = reader("description").ToString() ' Set the retrieved description
            editRequestForm.Location = reader("location").ToString() ' Set the retrieved location
            editRequestForm.Pax = reader("pax").ToString() ' Set the retrieved pax

            ' Show the EditRequestForm
            editRequestForm.ShowDialog()
        End If

        reader.Close()
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        ' Handle the Delete button click event
        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If
        Dim res As String
        res = MsgBox("Are you sure you want to delete this item?", 4, "Delete Item")
        If res = vbYes Then
            Dim button As KryptonButton = DirectCast(sender, KryptonButton)
            Dim requestID As Integer = CInt(button.Tag)
            sql = "DELETE FROM Requests WHERE RequestID = @RequestID"
            command = New OleDbCommand(sql, connect)
            command.Parameters.AddWithValue("@RequestID", OleDbType.VarChar).Value = requestID
            command.ExecuteNonQuery()
            RefreshData()
            connect.Close()
        End If

    End Sub
    Public Sub RefreshData()
        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If

        sql = "SELECT RequestID, title, location, pax, status FROM Requests WHERE requestorID = @RequestorID"
        'Get donorID to retrieve data accordingly
        Dim requestorID As Integer = LoginForm.globalUserID
        command = New OleDbCommand(sql, connect)
        command.Parameters.AddWithValue("@RequestorID", OleDbType.VarChar).Value = requestorID
        Dim reader As OleDbDataReader = command.ExecuteReader()

        'generate table
        Dim table As New TableLayoutPanel
        table.ColumnCount = 1
        table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100))
        table.Name = "TableLayoutPanel1"
        table.AutoSize = True
        table.ColumnStyles.Clear()
        table.RowStyles.Clear()

        Dim columnCount As Integer = 1
        Dim rowCount As Integer = Math.Ceiling(reader.FieldCount / columnCount)

        For i As Integer = 0 To rowCount - 1
            table.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        Next

        table.Controls.Clear()

        While reader.Read()
            Dim status As Object = reader("status")

            If status Is DBNull.Value Then ' Check if the status column is null
                Dim customContainer As Panel = New Panel()
                customContainer.BorderStyle = BorderStyle.FixedSingle
                customContainer.Width = 550
                customContainer.Height = 150
                customContainer.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                customContainer.BorderStyle = BorderStyle.None


                Dim lblTitle As Label = New Label()
                lblTitle.Text = reader("title").ToString()
                lblTitle.Location = New Point(30, 30)
                lblTitle.AutoSize = True
                lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                lblTitle.Name = "lblTitle"
                lblTitle.Size = New System.Drawing.Size(74, 28)

                Dim lblLocation As Label = New Label()
                lblLocation.AutoSize = False
                lblLocation.AutoEllipsis = True
                lblLocation.Text = "Location: " & reader("location").ToString()
                lblLocation.Location = New Point(30, 50)
                lblLocation.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                lblLocation.Name = "lblLocation"
                lblLocation.Size = New System.Drawing.Size(350, 40)

                Dim lblPax As Label = New Label()
                'convert to date only
                Dim expiryDate As String = reader("pax").ToString

                lblPax.Text = "Pax: " & expiryDate
                lblPax.Location = New Point(30, 90)
                lblPax.AutoSize = True
                lblPax.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                lblPax.Name = "lblPax"



                Dim btnEdit As KryptonButton = New KryptonButton()
                btnEdit.Values.Text = "Edit"

                btnEdit.Location = New System.Drawing.Point(420, 30)
                btnEdit.Name = "btnEdit"
                btnEdit.OverrideDefault.Back.Color1 = System.Drawing.Color.Gold
                btnEdit.OverrideDefault.Back.Color2 = System.Drawing.Color.Gold
                btnEdit.Size = New System.Drawing.Size(100, 30)
                btnEdit.StateCommon.Back.Color1 = System.Drawing.Color.Gold
                btnEdit.StateCommon.Back.Color2 = System.Drawing.Color.Gold
                btnEdit.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
                btnEdit.StateCommon.Border.Rounding = 10
                btnEdit.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black
                btnEdit.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black
                btnEdit.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))


                'function of the button
                'get RequestID
                Dim requestID As Integer = reader.GetInt32(reader.GetOrdinal("RequestID"))
                btnEdit.Tag = requestID
                AddHandler btnEdit.Click, AddressOf btnEdit_Click
                '////////////////////////////////////

                'Delete Button
                Dim btnDelete As KryptonButton = New KryptonButton()
                btnDelete.Values.Text = ""
                btnDelete.StateCommon.Back.Image = Image.FromFile("D:/UTP/Foundation 3rd Sem/VP/OMC stuff/ShareBytes Prototype/Resources/binbin.png")
                btnDelete.StateCommon.Back.ImageStyle = PaletteImageStyle.CenterMiddle



                btnDelete.Location = New System.Drawing.Point(490, 70)
                btnDelete.Name = "btnDelete"
                btnDelete.OverrideDefault.Back.Color1 = System.Drawing.Color.Red
                btnDelete.OverrideDefault.Back.Color2 = System.Drawing.Color.Red
                btnDelete.Size = New System.Drawing.Size(30, 30)
                btnDelete.StateCommon.Back.Color1 = System.Drawing.Color.Red
                btnDelete.StateCommon.Back.Color2 = System.Drawing.Color.Red
                btnDelete.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
                btnDelete.StateCommon.Border.Rounding = 10
                btnDelete.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White
                btnDelete.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White
                btnDelete.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                'Delete function
                btnDelete.Tag = requestID
                AddHandler btnDelete.Click, AddressOf btnDelete_Click
                '///////////////////////////////////////


                customContainer.Controls.Add(lblTitle)
                customContainer.Controls.Add(lblLocation)
                customContainer.Controls.Add(lblPax)

                customContainer.Controls.Add(btnEdit)
                customContainer.Controls.Add(btnDelete)

                ' Calculate the index for the TableLayoutPanel
                Dim columnIndex As Integer = (reader.GetOrdinal("title") - 1) Mod columnCount
                Dim rowIndex As Integer = (reader.GetOrdinal("title") - 1) \ columnCount

                ' Add the custom container to the form or container control
                table.Controls.Add(customContainer, columnIndex, rowIndex)
            End If


        End While
        pnlRequest.Controls.Clear()
        pnlRequest.Controls.Add(table)

        reader.Close()
    End Sub
    Private Sub RequestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\CJ\OMC\OMC database.accdb;"
        RefreshData()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim addRequestForm As New AddRequestForm(Me) ' Pass the reference of InventoryForm
        addRequestForm.ShowDialog()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshData()
    End Sub
End Class