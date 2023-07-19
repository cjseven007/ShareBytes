Imports ComponentFactory.Krypton.Toolkit
Imports System.Data.OleDb

Public Class RiderDeliveryForm
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
        sql = "UPDATE Donations SET deliverStatus = 'Delivering' WHERE requestID = @RequestID"
        command = New OleDbCommand(sql, connect)
        command.Parameters.AddWithValue("@RequestID", OleDbType.VarChar).Value = requestID
        command.ExecuteNonQuery()

        MsgBox("Delivery added to your list.", 0 & MsgBoxStyle.Information, "RECORD ADDED")
        RefreshData()
    End Sub

    Public Sub RefreshData()
        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If

        sql = "SELECT * FROM Donations WHERE deliverStatus = 'Delivering' OR deliverStatus = 'Delivered'"

        command = New OleDbCommand(sql, connect)
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
            Dim requestID As String = reader("requestID").ToString()
            Dim donorID As String = reader("donorID").ToString()
            Dim fare As String = reader("fare").ToString()

            sql = "SELECT * FROM Requests WHERE RequestID = @RequestID"
            command = New OleDbCommand(sql, connect)
            command.Parameters.AddWithValue("@RequestID", requestID)
            Dim reader1 As OleDbDataReader = command.ExecuteReader()

            While reader1.Read()
                Dim customContainer As Panel = New Panel()
                customContainer.BorderStyle = BorderStyle.FixedSingle
                customContainer.Width = 550
                customContainer.Height = 150
                customContainer.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                customContainer.BorderStyle = BorderStyle.None


                Dim lblTitle As Label = New Label()
                lblTitle.Text = reader1("title").ToString()
                lblTitle.Location = New Point(30, 20)
                lblTitle.AutoSize = True
                lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                lblTitle.Name = "lblTitle"
                lblTitle.Size = New System.Drawing.Size(74, 28)

                Dim lblLocation As Label = New Label()
                lblLocation.AutoSize = False
                lblLocation.AutoEllipsis = True
                lblLocation.Text = "Destination: " & reader1("location").ToString()
                lblLocation.Location = New Point(30, 40)
                lblLocation.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                lblLocation.Name = "lblLocation"
                lblLocation.Size = New System.Drawing.Size(350, 40)

                'From where
                sql = "SELECT address FROM [User] WHERE ID = @ID"
                command = New OleDbCommand(sql, connect)
                command.Parameters.AddWithValue("@ID", donorID)

                Dim reader2 As OleDbDataReader = command.ExecuteReader()

                Dim lblPax As Label = New Label()
                While reader2.Read()

                    lblPax.Text = "From: " & reader2("address").ToString()
                    lblPax.Location = New Point(30, 85)
                    lblPax.AutoSize = False
                    lblPax.AutoEllipsis = True
                    lblPax.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    lblPax.Name = "lblPax"
                    lblPax.Size = New System.Drawing.Size(350, 40)
                End While

                Dim lblPrice As Label = New Label()
                lblPrice.AutoSize = True
                lblPrice.Text = "RM " & (CDbl(fare) * 0.7).ToString("0.00")
                lblPrice.Location = New Point(420, 20)
                lblPrice.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                lblPrice.Name = "lblPrice"
                'lblPrice.Size = New System.Drawing.Size(50, 40)



                'Dim btnView As KryptonButton = New KryptonButton()
                'btnView.Values.Text = "View"

                'btnView.Location = New System.Drawing.Point(420, 30)
                'btnView.Name = "btnViewt"
                'btnView.OverrideDefault.Back.Color1 = System.Drawing.Color.MediumSeaGreen
                'btnView.OverrideDefault.Back.Color2 = System.Drawing.Color.MediumSeaGreen
                'btnView.Size = New System.Drawing.Size(100, 30)
                'btnView.StateCommon.Back.Color1 = System.Drawing.Color.MediumSeaGreen
                'btnView.StateCommon.Back.Color2 = System.Drawing.Color.MediumSeaGreen
                'btnView.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                '    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                '    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
                'btnView.StateCommon.Border.Rounding = 10
                'btnView.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black
                'btnView.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black
                'btnView.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))


                'function of the button
                'get RequestID

                '////////////////////////////////////

                'Delete Button
                Dim btnAccept As KryptonButton = New KryptonButton()
                btnAccept.Values.Text = "Accept"

                btnAccept.Location = New System.Drawing.Point(420, 100)
                btnAccept.Name = "btnAccept"
                btnAccept.OverrideDefault.Back.Color1 = System.Drawing.Color.MediumSeaGreen
                btnAccept.OverrideDefault.Back.Color2 = System.Drawing.Color.MediumSeaGreen
                btnAccept.Size = New System.Drawing.Size(100, 30)
                btnAccept.StateCommon.Back.Color1 = System.Drawing.Color.MediumSeaGreen
                btnAccept.StateCommon.Back.Color2 = System.Drawing.Color.MediumSeaGreen
                btnAccept.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
                btnAccept.StateCommon.Border.Rounding = 10
                btnAccept.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black
                btnAccept.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black
                btnAccept.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                'Acccept function
                btnAccept.Tag = requestID
                AddHandler btnAccept.Click, AddressOf button_Click

                '///////////////////////////////////////


                customContainer.Controls.Add(lblTitle)
                customContainer.Controls.Add(lblLocation)
                customContainer.Controls.Add(lblPax)
                customContainer.Controls.Add(lblPrice)

                'customContainer.Controls.Add(btnView)
                customContainer.Controls.Add(btnAccept)

                ' Calculate the index for the TableLayoutPanel
                Dim columnIndex As Integer = (reader.GetOrdinal("ID") - 1) Mod columnCount
                Dim rowIndex As Integer = (reader.GetOrdinal("ID") - 1) \ columnCount

                ' Add the custom container to the form or container control
                table.Controls.Add(customContainer, columnIndex, rowIndex)
            End While




        End While
        pnlView.Controls.Clear()
        pnlView.Controls.Add(table)

        reader.Close()
    End Sub
    Private Sub RiderDeliveryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\CJ\OMC\OMC database.accdb;"

        RefreshData()
    End Sub
End Class