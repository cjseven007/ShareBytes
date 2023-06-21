<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.components = New System.ComponentModel.Container()
        Me.pblBack = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLogin = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.txtPassword = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtUsername = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlCard = New System.Windows.Forms.Panel()
        Me.btnSignUp = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.picGif = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExit = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.pblBack.SuspendLayout()
        Me.pnlCard.SuspendLayout()
        CType(Me.picGif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pblBack
        '
        Me.pblBack.BackColor = System.Drawing.Color.White
        Me.pblBack.Controls.Add(Me.Label2)
        Me.pblBack.Controls.Add(Me.Label1)
        Me.pblBack.Controls.Add(Me.btnLogin)
        Me.pblBack.Controls.Add(Me.txtPassword)
        Me.pblBack.Controls.Add(Me.txtUsername)
        Me.pblBack.Controls.Add(Me.lblTitle)
        Me.pblBack.Location = New System.Drawing.Point(61, 50)
        Me.pblBack.Name = "pblBack"
        Me.pblBack.Size = New System.Drawing.Size(780, 450)
        Me.pblBack.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(474, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(474, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Username"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(478, 338)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.OverrideDefault.Back.Color1 = System.Drawing.Color.Gold
        Me.btnLogin.OverrideDefault.Back.Color2 = System.Drawing.Color.Gold
        Me.btnLogin.Size = New System.Drawing.Size(241, 50)
        Me.btnLogin.StateCommon.Back.Color1 = System.Drawing.Color.Gold
        Me.btnLogin.StateCommon.Back.Color2 = System.Drawing.Color.Gold
        Me.btnLogin.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnLogin.StateCommon.Border.Rounding = 10
        Me.btnLogin.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnLogin.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnLogin.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Values.Text = "LOGIN"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(478, 224)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(241, 40)
        Me.txtPassword.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPassword.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.txtPassword.StateCommon.Border.Color2 = System.Drawing.Color.Gray
        Me.txtPassword.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtPassword.StateCommon.Border.Rounding = 10
        Me.txtPassword.StateCommon.Content.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.TabIndex = 2
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(478, 150)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(241, 40)
        Me.txtUsername.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtUsername.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.txtUsername.StateCommon.Border.Color2 = System.Drawing.Color.Gray
        Me.txtUsername.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtUsername.StateCommon.Border.Rounding = 10
        Me.txtUsername.StateCommon.Content.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.TabIndex = 1
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(471, 37)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(118, 41)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "LOG IN"
        '
        'pnlCard
        '
        Me.pnlCard.BackColor = System.Drawing.Color.Gold
        Me.pnlCard.Controls.Add(Me.btnSignUp)
        Me.pnlCard.Controls.Add(Me.picGif)
        Me.pnlCard.Controls.Add(Me.Label4)
        Me.pnlCard.Controls.Add(Me.Label3)
        Me.pnlCard.Location = New System.Drawing.Point(102, 29)
        Me.pnlCard.Name = "pnlCard"
        Me.pnlCard.Size = New System.Drawing.Size(379, 496)
        Me.pnlCard.TabIndex = 0
        '
        'btnSignUp
        '
        Me.btnSignUp.Location = New System.Drawing.Point(51, 421)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.OverrideDefault.Back.Color1 = System.Drawing.Color.Orange
        Me.btnSignUp.OverrideDefault.Back.Color2 = System.Drawing.Color.Orange
        Me.btnSignUp.Size = New System.Drawing.Size(129, 50)
        Me.btnSignUp.StateCommon.Back.Color1 = System.Drawing.Color.Orange
        Me.btnSignUp.StateCommon.Back.Color2 = System.Drawing.Color.Orange
        Me.btnSignUp.StateCommon.Border.Color1 = System.Drawing.Color.Transparent
        Me.btnSignUp.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidBottomLine
        Me.btnSignUp.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnSignUp.StateCommon.Border.Rounding = 10
        Me.btnSignUp.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnSignUp.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnSignUp.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignUp.TabIndex = 6
        Me.btnSignUp.Values.Text = "SIGN UP HERE"
        '
        'picGif
        '
        Me.picGif.Image = Global.ShareBytes_Prototype.My.Resources.Resources.burger_rope
        Me.picGif.Location = New System.Drawing.Point(92, 198)
        Me.picGif.Name = "picGif"
        Me.picGif.Size = New System.Drawing.Size(200, 200)
        Me.picGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGif.TabIndex = 7
        Me.picGif.TabStop = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(47, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(268, 79)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Log in now and play your role in achieving Zero Hunger and Zero Waste."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(44, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(231, 41)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Welcome Back!"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Location = New System.Drawing.Point(870, 0)
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
        Me.btnExit.TabIndex = 1
        Me.btnExit.Values.Text = "X"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(900, 550)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.pnlCard)
        Me.Controls.Add(Me.pblBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm"
        Me.pblBack.ResumeLayout(False)
        Me.pblBack.PerformLayout()
        Me.pnlCard.ResumeLayout(False)
        Me.pnlCard.PerformLayout()
        CType(Me.picGif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pblBack As Panel
    Friend WithEvents pnlCard As Panel
    Friend WithEvents txtUsername As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtPassword As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnLogin As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnExit As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents picGif As PictureBox
    Friend WithEvents btnSignUp As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
End Class
