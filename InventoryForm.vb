Imports System.Data.OleDb
Imports LoginForm
Imports ComponentFactory.Krypton.Toolkit
Imports System.Windows.Forms.VisualStyles

Public Class InventoryForm
    Dim connect As New OleDbConnection
    Dim command As New OleDbCommand
    Dim sql As String = Nothing

    Private Sub btnEdit_Click(sender As Object, e As EventArgs)
        ' Handle the Edit button click event
        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If
        Dim button As KryptonButton = DirectCast(sender, KryptonButton)
        Dim productID As Integer = CInt(button.Tag)
        sql = "SELECT product, quantity, expiryDate FROM Inventory WHERE ID = @productID"
        command = New OleDbCommand(sql, connect)
        command.Parameters.AddWithValue("@productID", OleDbType.VarChar).Value = productID

        Dim reader As OleDbDataReader = command.ExecuteReader()

        If reader.Read() Then ' Check if there is a row of data
            Dim editForm As New InventoryEditForm(Me)
            ' Set the product values in the edit form
            editForm.ProductID = productID
            editForm.Product = reader("product").ToString() ' Set the retrieved product value
            editForm.Quantity = reader("quantity").ToString() ' Set the retrieved quantity value
            editForm.ExpiryDate = reader("expiryDate").ToString() ' Set the retrieved expiry date value

            ' Show the InventoryEditForm
            editForm.ShowDialog()
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
            Dim productID As Integer = CInt(button.Tag)
            sql = "DELETE FROM Inventory WHERE ID = @productID"
            command = New OleDbCommand(sql, connect)
            command.Parameters.AddWithValue("@productID", OleDbType.VarChar).Value = productID
            command.ExecuteNonQuery()
            RefreshData()
            connect.Close()
        End If

    End Sub

    Public Sub RefreshData()
        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If

        'Retrieve data from database
        sql = "SELECT ID, product, quantity, expiryDate FROM Inventory WHERE donorID = @DonorID"
        'Get donorID to retrieve data accordingly
        Dim donorID As Integer = LoginForm.globalUserID
        command = New OleDbCommand(sql, connect)
        command.Parameters.AddWithValue("@DonorID", OleDbType.VarChar).Value = donorID
        Dim reader As OleDbDataReader = command.ExecuteReader()


        Dim table As New TableLayoutPanel
        table.ColumnCount = 3
        table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3))
        table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3))
        table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3))
        table.Name = "TableLayoutPanel1"
        table.AutoSize = True
        table.ColumnStyles.Clear()
        table.RowStyles.Clear()

        ' Determine the number of columns and rows based on the data length
        Dim columnCount As Integer = 3
        Dim rowCount As Integer = Math.Ceiling(reader.FieldCount / columnCount)

        For i As Integer = 0 To rowCount - 1
            table.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        Next

        table.Controls.Clear()

        While reader.Read()
            Dim customContainer As Panel = New Panel()
            customContainer.BorderStyle = BorderStyle.FixedSingle
            customContainer.Width = 200
            customContainer.Height = 150
            customContainer.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
            customContainer.BorderStyle = BorderStyle.None


            Dim ProductLabel As Label = New Label()
            ProductLabel.Text = reader("product").ToString()
            ProductLabel.Location = New Point(10, 10)
            ProductLabel.AutoSize = True
            ProductLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ProductLabel.Name = "lblProduct"
            ProductLabel.Size = New System.Drawing.Size(74, 28)

            Dim QuantityLabel As Label = New Label()
            QuantityLabel.Text = "Quantity: " & reader("quantity").ToString()
            QuantityLabel.Location = New Point(10, 30)
            QuantityLabel.AutoSize = True
            QuantityLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            QuantityLabel.Name = "lblQuantity"
            QuantityLabel.Size = New System.Drawing.Size(59, 23)

            Dim ExpiryLabel As Label = New Label()
            'convert to date only
            Dim expiryDate As DateTime = reader("expiryDate")
            Dim expiryDateOnly As Date = expiryDate.Date
            ExpiryLabel.Text = "Expiry Date: " & expiryDateOnly
            ExpiryLabel.Location = New Point(10, 50)
            ExpiryLabel.AutoSize = True
            ExpiryLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ExpiryLabel.Name = "lblExpiryDate"

            Dim IsExpiringLabel As Label = New Label()
            Dim datNow As Date = Now()
            Dim remaining As TimeSpan = expiryDateOnly - datNow
            Dim daysLeft As Integer = CInt(remaining.Days)
            IsExpiringLabel.Text = "Expiring in " & daysLeft & " days"
            IsExpiringLabel.Location = New Point(10, 70)
            IsExpiringLabel.AutoSize = True
            IsExpiringLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            IsExpiringLabel.Name = "lblExpiring"
            If daysLeft <= 7 Then
                IsExpiringLabel.ForeColor = Color.Red
            Else
                IsExpiringLabel.ForeColor = Color.Black
            End If


            Dim btnEdit As KryptonButton = New KryptonButton()
            btnEdit.Values.Text = "Edit"

            btnEdit.Location = New System.Drawing.Point(10, 107)
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
            'get productID
            Dim productID As Integer = reader.GetInt32(reader.GetOrdinal("ID"))
            btnEdit.Tag = productID
            AddHandler btnEdit.Click, AddressOf btnEdit_Click
            '////////////////////////////////////

            'Delete Button
            Dim btnDelete As KryptonButton = New KryptonButton()
            btnDelete.Values.Text = ""
            btnDelete.StateCommon.Back.Image = Image.FromFile("D:/UTP/Foundation 3rd Sem/VP/OMC stuff/ShareBytes Prototype/Resources/binbin.png")
            btnDelete.StateCommon.Back.ImageStyle = PaletteImageStyle.CenterMiddle



            btnDelete.Location = New System.Drawing.Point(155, 107)
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
            btnDelete.Tag = productID
            AddHandler btnDelete.Click, AddressOf btnDelete_Click
            '///////////////////////////////////////


            customContainer.Controls.Add(ProductLabel)
            customContainer.Controls.Add(QuantityLabel)
            customContainer.Controls.Add(ExpiryLabel)
            customContainer.Controls.Add(IsExpiringLabel)
            customContainer.Controls.Add(btnEdit)
            customContainer.Controls.Add(btnDelete)

            ' Calculate the index for the TableLayoutPanel
            Dim columnIndex As Integer = (reader.GetOrdinal("product") - 1) Mod columnCount
            Dim rowIndex As Integer = (reader.GetOrdinal("product") - 1) \ columnCount

            ' Add the custom container to the form or container control
            table.Controls.Add(customContainer, columnIndex, rowIndex)

        End While
        pnlInventory.Controls.Clear()
        pnlInventory.Controls.Add(table)

        reader.Close()
    End Sub

    'Code starts here
    Private Sub InventoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connect.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\CJ\OMC\OMC database.accdb;"

        RefreshData()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim addInventoryForm As New AddInventoryForm(Me) ' Pass the reference of InventoryForm
        addInventoryForm.ShowDialog()
    End Sub


    Private Sub btnRefresh_Click_1(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshData()
    End Sub
End Class