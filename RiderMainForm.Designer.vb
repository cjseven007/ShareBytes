<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RiderMainForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogOut = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnProfile = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnDelivery = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnHome = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.pnlChildForm = New System.Windows.Forms.Panel()
        Me.btnExit = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnRevenue = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.Panel1.SuspendLayout()
        Me.pnlChildForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel1.Controls.Add(Me.btnRevenue)
        Me.Panel1.Controls.Add(Me.btnLogOut)
        Me.Panel1.Controls.Add(Me.btnProfile)
        Me.Panel1.Controls.Add(Me.btnDelivery)
        Me.Panel1.Controls.Add(Me.btnHome)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(228, 700)
        Me.Panel1.TabIndex = 0
        '
        'btnLogOut
        '
        Me.btnLogOut.Location = New System.Drawing.Point(38, 518)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.OverrideDefault.Back.Color1 = System.Drawing.Color.Red
        Me.btnLogOut.OverrideDefault.Back.Color2 = System.Drawing.Color.Red
        Me.btnLogOut.Size = New System.Drawing.Size(210, 50)
        Me.btnLogOut.StateCommon.Back.Color1 = System.Drawing.Color.Red
        Me.btnLogOut.StateCommon.Back.Color2 = System.Drawing.Color.Red
        Me.btnLogOut.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnLogOut.StateCommon.Border.Rounding = 20
        Me.btnLogOut.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.btnLogOut.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White
        Me.btnLogOut.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.TabIndex = 17
        Me.btnLogOut.Values.Text = "LOG OUT"
        '
        'btnProfile
        '
        Me.btnProfile.Location = New System.Drawing.Point(38, 400)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.OverrideDefault.Back.Color1 = System.Drawing.Color.LightGreen
        Me.btnProfile.OverrideDefault.Back.Color2 = System.Drawing.Color.LightGreen
        Me.btnProfile.OverrideDefault.Border.Color1 = System.Drawing.Color.LightGreen
        Me.btnProfile.OverrideDefault.Border.Color2 = System.Drawing.Color.LightGreen
        Me.btnProfile.OverrideDefault.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnProfile.Size = New System.Drawing.Size(210, 50)
        Me.btnProfile.StateCommon.Back.Color1 = System.Drawing.Color.LightGreen
        Me.btnProfile.StateCommon.Back.Color2 = System.Drawing.Color.LightGreen
        Me.btnProfile.StateCommon.Border.Color1 = System.Drawing.Color.LightGreen
        Me.btnProfile.StateCommon.Border.Color2 = System.Drawing.Color.LightGreen
        Me.btnProfile.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnProfile.StateCommon.Border.Rounding = 20
        Me.btnProfile.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnProfile.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnProfile.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProfile.TabIndex = 16
        Me.btnProfile.Values.Text = "PROFILE"
        '
        'btnDelivery
        '
        Me.btnDelivery.Location = New System.Drawing.Point(38, 262)
        Me.btnDelivery.Name = "btnDelivery"
        Me.btnDelivery.OverrideDefault.Back.Color1 = System.Drawing.Color.LightGreen
        Me.btnDelivery.OverrideDefault.Back.Color2 = System.Drawing.Color.LightGreen
        Me.btnDelivery.OverrideDefault.Border.Color1 = System.Drawing.Color.LightGreen
        Me.btnDelivery.OverrideDefault.Border.Color2 = System.Drawing.Color.LightGreen
        Me.btnDelivery.OverrideDefault.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnDelivery.Size = New System.Drawing.Size(210, 50)
        Me.btnDelivery.StateCommon.Back.Color1 = System.Drawing.Color.LightGreen
        Me.btnDelivery.StateCommon.Back.Color2 = System.Drawing.Color.LightGreen
        Me.btnDelivery.StateCommon.Border.Color1 = System.Drawing.Color.LightGreen
        Me.btnDelivery.StateCommon.Border.Color2 = System.Drawing.Color.LightGreen
        Me.btnDelivery.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnDelivery.StateCommon.Border.Rounding = 20
        Me.btnDelivery.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnDelivery.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnDelivery.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelivery.TabIndex = 14
        Me.btnDelivery.Values.Text = "DELIVERY"
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(38, 193)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.OverrideDefault.Back.Color1 = System.Drawing.Color.LightGreen
        Me.btnHome.OverrideDefault.Back.Color2 = System.Drawing.Color.LightGreen
        Me.btnHome.OverrideDefault.Border.Color1 = System.Drawing.Color.LightGreen
        Me.btnHome.OverrideDefault.Border.Color2 = System.Drawing.Color.LightGreen
        Me.btnHome.OverrideDefault.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnHome.Size = New System.Drawing.Size(210, 50)
        Me.btnHome.StateCommon.Back.Color1 = System.Drawing.Color.LightGreen
        Me.btnHome.StateCommon.Back.Color2 = System.Drawing.Color.LightGreen
        Me.btnHome.StateCommon.Border.Color1 = System.Drawing.Color.LightGreen
        Me.btnHome.StateCommon.Border.Color2 = System.Drawing.Color.LightGreen
        Me.btnHome.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnHome.StateCommon.Border.Rounding = 20
        Me.btnHome.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnHome.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnHome.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.TabIndex = 13
        Me.btnHome.Values.Text = "HOME"
        '
        'pnlChildForm
        '
        Me.pnlChildForm.Controls.Add(Me.btnExit)
        Me.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlChildForm.Location = New System.Drawing.Point(228, 0)
        Me.pnlChildForm.Name = "pnlChildForm"
        Me.pnlChildForm.Size = New System.Drawing.Size(972, 700)
        Me.pnlChildForm.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Location = New System.Drawing.Point(942, 0)
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
        Me.btnExit.TabIndex = 12
        Me.btnExit.Values.Text = "X"
        '
        'btnRevenue
        '
        Me.btnRevenue.Location = New System.Drawing.Point(38, 332)
        Me.btnRevenue.Name = "btnRevenue"
        Me.btnRevenue.OverrideDefault.Back.Color1 = System.Drawing.Color.LightGreen
        Me.btnRevenue.OverrideDefault.Back.Color2 = System.Drawing.Color.LightGreen
        Me.btnRevenue.OverrideDefault.Border.Color1 = System.Drawing.Color.LightGreen
        Me.btnRevenue.OverrideDefault.Border.Color2 = System.Drawing.Color.LightGreen
        Me.btnRevenue.OverrideDefault.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnRevenue.Size = New System.Drawing.Size(210, 50)
        Me.btnRevenue.StateCommon.Back.Color1 = System.Drawing.Color.LightGreen
        Me.btnRevenue.StateCommon.Back.Color2 = System.Drawing.Color.LightGreen
        Me.btnRevenue.StateCommon.Border.Color1 = System.Drawing.Color.LightGreen
        Me.btnRevenue.StateCommon.Border.Color2 = System.Drawing.Color.LightGreen
        Me.btnRevenue.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnRevenue.StateCommon.Border.Rounding = 20
        Me.btnRevenue.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnRevenue.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnRevenue.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRevenue.TabIndex = 18
        Me.btnRevenue.Values.Text = "REVENUE"
        '
        'RiderMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 700)
        Me.Controls.Add(Me.pnlChildForm)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RiderMainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RiderMainForm"
        Me.Panel1.ResumeLayout(False)
        Me.pnlChildForm.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlChildForm As Panel
    Friend WithEvents btnExit As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnHome As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnProfile As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnDelivery As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnLogOut As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnRevenue As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
