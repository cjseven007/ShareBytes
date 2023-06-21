Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles
Imports System.Xml
Imports ComponentFactory.Krypton.Toolkit

Public Class DonateForm
    Dim connect As New OleDbConnection
    Dim command As New OleDbCommand
    Dim sql As String = Nothing
    Private Sub DonateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\CJ\OMC\OMC database.accdb;"
        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If

        'Retrieve data from database
        sql = "SELECT title, location, pax FROM Requests"

        command = New OleDbCommand(sql, connect)
        Dim reader As OleDbDataReader = command.ExecuteReader()

        Dim table As New TableLayoutPanel
        table.ColumnCount = 3
        table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3))
        table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3))
        table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3))
        'table.Location = New System.Drawing.Point(79, 94)
        table.Name = "TableLayoutPanel1"
        table.AutoSize = True
        table.TabIndex = 0
        While reader.Read()
            Dim customContainer As Panel = New Panel()
            customContainer.BorderStyle = BorderStyle.FixedSingle
            customContainer.Width = 200
            customContainer.Height = 150
            customContainer.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
            customContainer.BorderStyle = BorderStyle.None


            Dim titleLabel As Label = New Label()
            titleLabel.Text = reader("title").ToString()
            titleLabel.Location = New Point(10, 10)
            titleLabel.AutoSize = True
            titleLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            titleLabel.Name = "lblTitle"
            titleLabel.Size = New System.Drawing.Size(74, 28)

            Dim locationLabel As Label = New Label()
            locationLabel.Text = "Location: " & reader("location").ToString()
            locationLabel.Location = New Point(10, 30)
            locationLabel.AutoSize = True
            locationLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            locationLabel.Name = "lblDescription"
            locationLabel.Size = New System.Drawing.Size(59, 23)

            Dim paxLabel As Label = New Label()
            paxLabel.Text = "Pax: " & reader("pax").ToString()
            paxLabel.Location = New Point(10, 50)
            paxLabel.AutoSize = True
            paxLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            paxLabel.Name = "lblPax"



            Dim button As KryptonButton = New KryptonButton()
            button.Values.Text = "DONATE"

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

            customContainer.Controls.Add(titleLabel)
            customContainer.Controls.Add(locationLabel)
            customContainer.Controls.Add(paxLabel)
            customContainer.Controls.Add(button)


            ' Add the custom container to the form or container control

            table.Controls.Add(customContainer)

        End While
        pnlGridView.Controls.Add(table)
    End Sub
End Class