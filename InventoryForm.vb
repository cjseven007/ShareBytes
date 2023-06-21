Imports System.Data.OleDb
Imports LoginForm
Imports ComponentFactory.Krypton.Toolkit

Public Class InventoryForm
    Dim connect As New OleDbConnection
    Dim command As New OleDbCommand
    Dim sql As String = Nothing


    Public Sub RefreshData()


        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If

        'Retrieve data from database
        sql = "SELECT product, quantity, expiryDate FROM Inventory WHERE donorID = @DonorID"
        'Get donorID to retrieve data accordingly
        Dim donorID As Integer = LoginForm.globalUserID
        command = New OleDbCommand(sql, connect)
        command.Parameters.AddWithValue("@DonorID", OleDbType.VarChar).Value = donorID
        Dim reader As OleDbDataReader = Command.ExecuteReader()


        Dim table As New TableLayoutPanel
        table.ColumnCount = 3
        table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3))
        table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3))
        table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3))
        table.Name = "TableLayoutPanel1"
        table.AutoSize = True

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


            Dim button As KryptonButton = New KryptonButton()
            button.Values.Text = "Edit"

            button.Location = New System.Drawing.Point(81, 107)
            button.Name = "btnConfirmDonate"
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

            customContainer.Controls.Add(ProductLabel)
            customContainer.Controls.Add(QuantityLabel)
            customContainer.Controls.Add(ExpiryLabel)
            customContainer.Controls.Add(IsExpiringLabel)
            customContainer.Controls.Add(button)


            ' Add the custom container to the form or container control


            table.Controls.Add(customContainer)

        End While

        pnlInventory.Controls.Add(table)
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
End Class