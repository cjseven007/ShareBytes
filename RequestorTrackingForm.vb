Imports System.Data.OleDb
Imports ComponentFactory.Krypton.Toolkit

Public Class RequestorTrackingForm
    Dim connect As New OleDbConnection
    Dim command As New OleDbCommand
    Dim sql As String = Nothing
    Private Sub RequestorTrackingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\CJ\OMC\OMC database.accdb;"

        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If

        sql = "SELECT * FROM Donations WHERE requestorID = @RequestorID"
        'Get requestorID to retrieve data accordingly
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

            Dim donationID As String = reader("ID").ToString()
            Dim donorID As String = reader("donorID").ToString()
            Dim requestID As String = reader("requestID").ToString()
            Dim distance As String = reader("distance").ToString()
            Dim fare As String = reader("fare").ToString()
            Dim status As String = reader("deliverStatus").ToString()

            sql = "SELECT organization FROM [User] WHERE ID = @DonorID"
            'Get requestorID to retrieve data accordingly
            command = New OleDbCommand(sql, connect)
            command.Parameters.AddWithValue("DonorID", OleDbType.VarChar).Value = donorID
            Dim reader1 As OleDbDataReader = command.ExecuteReader()

            Dim donorOrganization As String
            If reader1.Read() Then
                donorOrganization = reader1("organization").ToString()

            End If

            sql = "SELECT title FROM Requests WHERE RequestID = @RequestID"
            'Get requestorID to retrieve data accordingly
            command = New OleDbCommand(sql, connect)
            command.Parameters.AddWithValue("RequestID", OleDbType.VarChar).Value = requestID
            Dim reader2 As OleDbDataReader = command.ExecuteReader()

            Dim requestTitle As String
            If reader2.Read() Then
                requestTitle = reader2("title").ToString()
            End If


            Dim customContainer As Panel = New Panel()
                customContainer.BorderStyle = BorderStyle.FixedSingle
            customContainer.Width = 450
            customContainer.Height = 150
                customContainer.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                customContainer.BorderStyle = BorderStyle.None


                Dim lblTitle As Label = New Label()
            lblTitle.Text = requestTitle
            lblTitle.Location = New Point(30, 15)
            lblTitle.AutoSize = True
                lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                lblTitle.Name = "lblTitle"
                lblTitle.Size = New System.Drawing.Size(74, 28)

            Dim lblDonorOrg As Label = New Label()
            lblDonorOrg.AutoSize = False
            lblDonorOrg.AutoEllipsis = True
            lblDonorOrg.Text = "Donor: " & donorOrganization
            lblDonorOrg.Location = New Point(30, 35)
            lblDonorOrg.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            lblDonorOrg.Name = "lblDonorOrg"
            lblDonorOrg.Size = New System.Drawing.Size(350, 20)

            Dim lblFare As Label = New Label()
            lblFare.AutoSize = False
            lblFare.AutoEllipsis = True
            lblFare.Text = "Price: RM" & fare
            lblFare.Location = New Point(30, 55)
            lblFare.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            lblFare.Name = "lblFare"
            lblFare.Size = New System.Drawing.Size(350, 20)

            Dim lblStatus As Label = New Label()
            lblStatus.AutoSize = False
            lblStatus.AutoEllipsis = True
            lblStatus.Text = "Status: " & status
            lblStatus.Location = New Point(30, 75)
            lblStatus.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            lblStatus.Name = "lblStatus"
            lblStatus.Size = New System.Drawing.Size(350, 20)

            Dim btnView As KryptonButton = New KryptonButton()
            btnView.Values.Text = "View"

            btnView.Location = New System.Drawing.Point(260, 100)
            btnView.Name = "btnView"
            btnView.OverrideDefault.Back.Color1 = System.Drawing.Color.Gold
            btnView.OverrideDefault.Back.Color2 = System.Drawing.Color.Gold
            btnView.Size = New System.Drawing.Size(100, 30)
            btnView.StateCommon.Back.Color1 = System.Drawing.Color.Gold
            btnView.StateCommon.Back.Color2 = System.Drawing.Color.Gold
            btnView.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
            btnView.StateCommon.Border.Rounding = 10
            btnView.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black
            btnView.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black
            btnView.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))


            'function of the button
            'get RequestID

            btnView.Tag = requestID
            '////////////////////////////////////

            'Delete Button
            Dim btnPay As KryptonButton = New KryptonButton()
            btnPay.Values.Text = "Pay"
            btnPay.Location = New System.Drawing.Point(370, 100)
            btnPay.Name = "btnPay"
            btnPay.OverrideDefault.Back.Color1 = System.Drawing.Color.Orange
            btnPay.OverrideDefault.Back.Color2 = System.Drawing.Color.Orange
            btnPay.Size = New System.Drawing.Size(50, 30)
            btnPay.StateCommon.Back.Color1 = System.Drawing.Color.Orange
            btnPay.StateCommon.Back.Color2 = System.Drawing.Color.Orange
            btnPay.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
            btnPay.StateCommon.Border.Rounding = 10
            btnPay.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White
            btnPay.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White
            btnPay.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            'Delete function
            btnPay.Tag = requestID
            '///////////////////////////////////////


            customContainer.Controls.Add(lblTitle)
            customContainer.Controls.Add(lblDonorOrg)
            customContainer.Controls.Add(lblFare)
            customContainer.Controls.Add(lblStatus)
            customContainer.Controls.Add(btnView)
            customContainer.Controls.Add(btnPay)

            ' Calculate the index for the TableLayoutPanel
            Dim columnIndex As Integer = (reader.GetOrdinal("ID") - 1) Mod columnCount
            Dim rowIndex As Integer = (reader.GetOrdinal("ID") - 1) \ columnCount

            ' Add the custom container to the form or container control
            table.Controls.Add(customContainer, columnIndex, rowIndex)



        End While
        pnlTracking.Controls.Clear()
        pnlTracking.Controls.Add(table)

        reader.Close()
    End Sub

End Class