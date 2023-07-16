<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.pnlSideBar = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.btnHome = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnLogOut = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnAbout = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnProfile = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnInventory = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnDonate = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.pnlChildForm = New System.Windows.Forms.Panel()
        Me.btnExit = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnAdminChat = New System.Windows.Forms.Button()
        CType(Me.pnlSideBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSideBar.SuspendLayout()
        Me.pnlChildForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSideBar
        '
        Me.pnlSideBar.Controls.Add(Me.btnAdminChat)
        Me.pnlSideBar.Controls.Add(Me.btnHome)
        Me.pnlSideBar.Controls.Add(Me.btnLogOut)
        Me.pnlSideBar.Controls.Add(Me.btnAbout)
        Me.pnlSideBar.Controls.Add(Me.btnProfile)
        Me.pnlSideBar.Controls.Add(Me.btnInventory)
        Me.pnlSideBar.Controls.Add(Me.btnDonate)
        Me.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSideBar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSideBar.Name = "pnlSideBar"
        Me.pnlSideBar.Size = New System.Drawing.Size(228, 700)
        Me.pnlSideBar.StateCommon.Color1 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.pnlSideBar.StateCommon.Color2 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.pnlSideBar.TabIndex = 10
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(36, 146)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.OverrideDefault.Back.Color1 = System.Drawing.Color.Gold
        Me.btnHome.OverrideDefault.Back.Color2 = System.Drawing.Color.Gold
        Me.btnHome.Size = New System.Drawing.Size(210, 50)
        Me.btnHome.StateCommon.Back.Color1 = System.Drawing.Color.Gold
        Me.btnHome.StateCommon.Back.Color2 = System.Drawing.Color.Gold
        Me.btnHome.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnHome.StateCommon.Border.Rounding = 20
        Me.btnHome.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnHome.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnHome.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.TabIndex = 4
        Me.btnHome.Values.Text = "HOME"
        '
        'btnLogOut
        '
        Me.btnLogOut.Location = New System.Drawing.Point(36, 505)
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
        Me.btnLogOut.TabIndex = 1
        Me.btnLogOut.Values.Text = "LOG OUT"
        '
        'btnAbout
        '
        Me.btnAbout.Location = New System.Drawing.Point(36, 402)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.OverrideDefault.Back.Color1 = System.Drawing.Color.Gold
        Me.btnAbout.OverrideDefault.Back.Color2 = System.Drawing.Color.Gold
        Me.btnAbout.Size = New System.Drawing.Size(210, 50)
        Me.btnAbout.StateCommon.Back.Color1 = System.Drawing.Color.Gold
        Me.btnAbout.StateCommon.Back.Color2 = System.Drawing.Color.Gold
        Me.btnAbout.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnAbout.StateCommon.Border.Rounding = 20
        Me.btnAbout.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnAbout.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnAbout.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.TabIndex = 3
        Me.btnAbout.Values.Text = "ABOUT"
        '
        'btnProfile
        '
        Me.btnProfile.Location = New System.Drawing.Point(36, 338)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.OverrideDefault.Back.Color1 = System.Drawing.Color.Gold
        Me.btnProfile.OverrideDefault.Back.Color2 = System.Drawing.Color.Gold
        Me.btnProfile.Size = New System.Drawing.Size(210, 50)
        Me.btnProfile.StateCommon.Back.Color1 = System.Drawing.Color.Gold
        Me.btnProfile.StateCommon.Back.Color2 = System.Drawing.Color.Gold
        Me.btnProfile.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnProfile.StateCommon.Border.Rounding = 20
        Me.btnProfile.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnProfile.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnProfile.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProfile.TabIndex = 2
        Me.btnProfile.Values.Text = "PROFILE"
        '
        'btnInventory
        '
        Me.btnInventory.Location = New System.Drawing.Point(36, 274)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.OverrideDefault.Back.Color1 = System.Drawing.Color.Gold
        Me.btnInventory.OverrideDefault.Back.Color2 = System.Drawing.Color.Gold
        Me.btnInventory.Size = New System.Drawing.Size(210, 50)
        Me.btnInventory.StateCommon.Back.Color1 = System.Drawing.Color.Gold
        Me.btnInventory.StateCommon.Back.Color2 = System.Drawing.Color.Gold
        Me.btnInventory.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnInventory.StateCommon.Border.Rounding = 20
        Me.btnInventory.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnInventory.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnInventory.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.TabIndex = 1
        Me.btnInventory.Values.Text = "INVENTORY"
        '
        'btnDonate
        '
        Me.btnDonate.Location = New System.Drawing.Point(36, 210)
        Me.btnDonate.Name = "btnDonate"
        Me.btnDonate.OverrideDefault.Back.Color1 = System.Drawing.Color.Gold
        Me.btnDonate.OverrideDefault.Back.Color2 = System.Drawing.Color.Gold
        Me.btnDonate.Size = New System.Drawing.Size(210, 50)
        Me.btnDonate.StateCommon.Back.Color1 = System.Drawing.Color.Gold
        Me.btnDonate.StateCommon.Back.Color2 = System.Drawing.Color.Gold
        Me.btnDonate.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnDonate.StateCommon.Border.Rounding = 20
        Me.btnDonate.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnDonate.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnDonate.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDonate.TabIndex = 0
        Me.btnDonate.Values.Text = "DONATE"
        '
        'pnlChildForm
        '
        Me.pnlChildForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlChildForm.Controls.Add(Me.btnExit)
        Me.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlChildForm.Location = New System.Drawing.Point(228, 0)
        Me.pnlChildForm.Name = "pnlChildForm"
        Me.pnlChildForm.Size = New System.Drawing.Size(972, 700)
        Me.pnlChildForm.TabIndex = 11
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Location = New System.Drawing.Point(941, 0)
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
        Me.btnExit.TabIndex = 9
        Me.btnExit.Values.Text = "X"
        '
        'btnAdminChat
        '
        Me.btnAdminChat.BackColor = System.Drawing.Color.Gold
        Me.btnAdminChat.FlatAppearance.BorderSize = 0
        Me.btnAdminChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdminChat.Image = Global.ShareBytes_Prototype.My.Resources.Resources.customer_service
        Me.btnAdminChat.Location = New System.Drawing.Point(73, 25)
        Me.btnAdminChat.Name = "btnAdminChat"
        Me.btnAdminChat.Size = New System.Drawing.Size(90, 90)
        Me.btnAdminChat.TabIndex = 12
        Me.btnAdminChat.UseVisualStyleBackColor = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 700)
        Me.Controls.Add(Me.pnlChildForm)
        Me.Controls.Add(Me.pnlSideBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        CType(Me.pnlSideBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSideBar.ResumeLayout(False)
        Me.pnlChildForm.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlSideBar As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents btnDonate As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnLogOut As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnAbout As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnProfile As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnInventory As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnHome As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents pnlChildForm As Panel
    Friend WithEvents btnExit As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnAdminChat As Button
End Class
