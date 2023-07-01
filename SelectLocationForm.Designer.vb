<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectLocationForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnExit = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.wbbMap = New System.Windows.Forms.WebBrowser()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLocation = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSelectLocation = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLatitude = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtLongitude = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtAddress = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSave = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Location = New System.Drawing.Point(949, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.OverrideDefault.Back.Color1 = System.Drawing.Color.Red
        Me.btnExit.OverrideDefault.Back.Color2 = System.Drawing.Color.Red
        Me.btnExit.Size = New System.Drawing.Size(30, 30)
        Me.btnExit.StateCommon.Back.Color1 = System.Drawing.Color.Red
        Me.btnExit.StateCommon.Back.Color2 = System.Drawing.Color.Red
        Me.btnExit.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.btnExit.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White
        Me.btnExit.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnExit.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnExit.TabIndex = 19
        Me.btnExit.Values.Text = "X"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.wbbMap)
        Me.Panel1.Location = New System.Drawing.Point(368, 102)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(561, 511)
        Me.Panel1.TabIndex = 20
        '
        'wbbMap
        '
        Me.wbbMap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbbMap.Location = New System.Drawing.Point(0, 0)
        Me.wbbMap.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbbMap.Name = "wbbMap"
        Me.wbbMap.Size = New System.Drawing.Size(561, 511)
        Me.wbbMap.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(375, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 38)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Select Location"
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(53, 129)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(277, 40)
        Me.txtLocation.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtLocation.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.txtLocation.StateCommon.Border.Color2 = System.Drawing.Color.Gray
        Me.txtLocation.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtLocation.StateCommon.Border.Rounding = 10
        Me.txtLocation.StateCommon.Content.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocation.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 23)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Search Location"
        '
        'btnSelectLocation
        '
        Me.btnSelectLocation.Location = New System.Drawing.Point(53, 185)
        Me.btnSelectLocation.Name = "btnSelectLocation"
        Me.btnSelectLocation.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSelectLocation.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSelectLocation.OverrideDefault.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnSelectLocation.OverrideDefault.Border.Rounding = 10
        Me.btnSelectLocation.Size = New System.Drawing.Size(140, 37)
        Me.btnSelectLocation.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSelectLocation.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSelectLocation.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSelectLocation.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSelectLocation.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnSelectLocation.StateCommon.Border.Rounding = 10
        Me.btnSelectLocation.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectLocation.TabIndex = 24
        Me.btnSelectLocation.Values.Text = "Search"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(373, 630)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(306, 23)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "*Select location by clicking on the map"
        '
        'txtLatitude
        '
        Me.txtLatitude.Location = New System.Drawing.Point(53, 279)
        Me.txtLatitude.Name = "txtLatitude"
        Me.txtLatitude.ReadOnly = True
        Me.txtLatitude.Size = New System.Drawing.Size(277, 40)
        Me.txtLatitude.StateCommon.Back.Color1 = System.Drawing.Color.DarkGray
        Me.txtLatitude.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.txtLatitude.StateCommon.Border.Color2 = System.Drawing.Color.Gray
        Me.txtLatitude.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtLatitude.StateCommon.Border.Rounding = 10
        Me.txtLatitude.StateCommon.Content.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLatitude.TabIndex = 26
        '
        'txtLongitude
        '
        Me.txtLongitude.Location = New System.Drawing.Point(53, 348)
        Me.txtLongitude.Name = "txtLongitude"
        Me.txtLongitude.ReadOnly = True
        Me.txtLongitude.Size = New System.Drawing.Size(277, 40)
        Me.txtLongitude.StateCommon.Back.Color1 = System.Drawing.Color.DarkGray
        Me.txtLongitude.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.txtLongitude.StateCommon.Border.Color2 = System.Drawing.Color.Gray
        Me.txtLongitude.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtLongitude.StateCommon.Border.Rounding = 10
        Me.txtLongitude.StateCommon.Content.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLongitude.TabIndex = 27
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(53, 428)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(277, 174)
        Me.txtAddress.StateCommon.Back.Color1 = System.Drawing.Color.DarkGray
        Me.txtAddress.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.txtAddress.StateCommon.Border.Color2 = System.Drawing.Color.Gray
        Me.txtAddress.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtAddress.StateCommon.Border.Rounding = 10
        Me.txtAddress.StateCommon.Content.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(49, 253)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 23)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Latitude"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(49, 322)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 23)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Longitude"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(49, 402)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 23)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Address"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(790, 619)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSave.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSave.OverrideDefault.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnSave.OverrideDefault.Border.Rounding = 10
        Me.btnSave.Size = New System.Drawing.Size(139, 52)
        Me.btnSave.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSave.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSave.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSave.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSave.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnSave.StateCommon.Border.Rounding = 10
        Me.btnSave.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.TabIndex = 32
        Me.btnSave.Values.Text = "Save"
        '
        'SelectLocationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(978, 706)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtLongitude)
        Me.Controls.Add(Me.txtLatitude)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSelectLocation)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SelectLocationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SelectLocationForm"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents wbbMap As WebBrowser
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLocation As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSelectLocation As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLatitude As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtLongitude As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtAddress As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSave As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
