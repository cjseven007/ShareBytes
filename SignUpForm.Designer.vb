<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUpForm
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
        Me.pnlCard = New System.Windows.Forms.Panel()
        Me.btnLogin = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.picGif = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pblBack = New System.Windows.Forms.Panel()
        Me.btnEye1 = New System.Windows.Forms.Button()
        Me.btnEye2 = New System.Windows.Forms.Button()
        Me.rbtRequestor = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.rbtDonor = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtConfirmPassword = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmail = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSignUp = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.txtPassword = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtUsername = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnExit = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.rbtRider = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.pnlCard.SuspendLayout()
        CType(Me.picGif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pblBack.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCard
        '
        Me.pnlCard.BackColor = System.Drawing.Color.Orange
        Me.pnlCard.Controls.Add(Me.btnLogin)
        Me.pnlCard.Controls.Add(Me.picGif)
        Me.pnlCard.Controls.Add(Me.Label4)
        Me.pnlCard.Controls.Add(Me.Label3)
        Me.pnlCard.Location = New System.Drawing.Point(101, 27)
        Me.pnlCard.Name = "pnlCard"
        Me.pnlCard.Size = New System.Drawing.Size(379, 539)
        Me.pnlCard.TabIndex = 1
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(34, 456)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.OverrideDefault.Back.Color1 = System.Drawing.Color.Gold
        Me.btnLogin.OverrideDefault.Back.Color2 = System.Drawing.Color.Gold
        Me.btnLogin.Size = New System.Drawing.Size(129, 50)
        Me.btnLogin.StateCommon.Back.Color1 = System.Drawing.Color.Gold
        Me.btnLogin.StateCommon.Back.Color2 = System.Drawing.Color.Gold
        Me.btnLogin.StateCommon.Border.Color1 = System.Drawing.Color.Transparent
        Me.btnLogin.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidBottomLine
        Me.btnLogin.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnLogin.StateCommon.Border.Rounding = 10
        Me.btnLogin.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnLogin.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnLogin.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Values.Text = "&LOGIN HERE"
        '
        'picGif
        '
        Me.picGif.Image = Global.ShareBytes_Prototype.My.Resources.Resources.dance
        Me.picGif.Location = New System.Drawing.Point(86, 198)
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
        Me.Label4.Location = New System.Drawing.Point(30, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(309, 106)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Share Bytes is your one-stop-centre to alleviating global hunger and pollution. S" &
    "ign up now to be part of us!"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(27, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(330, 41)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Be Part of ShareBytes!"
        '
        'pblBack
        '
        Me.pblBack.BackColor = System.Drawing.Color.White
        Me.pblBack.Controls.Add(Me.rbtRider)
        Me.pblBack.Controls.Add(Me.btnEye1)
        Me.pblBack.Controls.Add(Me.btnEye2)
        Me.pblBack.Controls.Add(Me.rbtRequestor)
        Me.pblBack.Controls.Add(Me.rbtDonor)
        Me.pblBack.Controls.Add(Me.Label6)
        Me.pblBack.Controls.Add(Me.txtConfirmPassword)
        Me.pblBack.Controls.Add(Me.Label5)
        Me.pblBack.Controls.Add(Me.txtEmail)
        Me.pblBack.Controls.Add(Me.Label2)
        Me.pblBack.Controls.Add(Me.Label1)
        Me.pblBack.Controls.Add(Me.btnSignUp)
        Me.pblBack.Controls.Add(Me.txtPassword)
        Me.pblBack.Controls.Add(Me.txtUsername)
        Me.pblBack.Controls.Add(Me.lblTitle)
        Me.pblBack.Location = New System.Drawing.Point(60, 48)
        Me.pblBack.Name = "pblBack"
        Me.pblBack.Size = New System.Drawing.Size(780, 498)
        Me.pblBack.TabIndex = 2
        '
        'btnEye1
        '
        Me.btnEye1.BackColor = System.Drawing.Color.Transparent
        Me.btnEye1.BackgroundImage = Global.ShareBytes_Prototype.My.Resources.Resources.eye
        Me.btnEye1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEye1.Location = New System.Drawing.Point(725, 243)
        Me.btnEye1.Name = "btnEye1"
        Me.btnEye1.Size = New System.Drawing.Size(35, 35)
        Me.btnEye1.TabIndex = 63
        Me.btnEye1.UseVisualStyleBackColor = False
        '
        'btnEye2
        '
        Me.btnEye2.BackColor = System.Drawing.Color.Transparent
        Me.btnEye2.BackgroundImage = Global.ShareBytes_Prototype.My.Resources.Resources.eye
        Me.btnEye2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEye2.Location = New System.Drawing.Point(725, 313)
        Me.btnEye2.Name = "btnEye2"
        Me.btnEye2.Size = New System.Drawing.Size(35, 35)
        Me.btnEye2.TabIndex = 62
        Me.btnEye2.UseVisualStyleBackColor = False
        '
        'rbtRequestor
        '
        Me.rbtRequestor.Location = New System.Drawing.Point(551, 370)
        Me.rbtRequestor.Name = "rbtRequestor"
        Me.rbtRequestor.Size = New System.Drawing.Size(93, 24)
        Me.rbtRequestor.TabIndex = 11
        Me.rbtRequestor.Values.Text = "Requestor"
        '
        'rbtDonor
        '
        Me.rbtDonor.Location = New System.Drawing.Point(478, 370)
        Me.rbtDonor.Name = "rbtDonor"
        Me.rbtDonor.Size = New System.Drawing.Size(67, 24)
        Me.rbtDonor.TabIndex = 10
        Me.rbtDonor.Values.Text = "Donor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(474, 287)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 23)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Confirm Password"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(478, 313)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(241, 40)
        Me.txtConfirmPassword.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtConfirmPassword.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.txtConfirmPassword.StateCommon.Border.Color2 = System.Drawing.Color.Gray
        Me.txtConfirmPassword.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtConfirmPassword.StateCommon.Border.Rounding = 10
        Me.txtConfirmPassword.StateCommon.Content.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPassword.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(474, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 23)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(478, 107)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(241, 40)
        Me.txtEmail.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtEmail.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.txtEmail.StateCommon.Border.Color2 = System.Drawing.Color.Gray
        Me.txtEmail.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtEmail.StateCommon.Border.Rounding = 10
        Me.txtEmail.StateCommon.Content.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(474, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(474, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Username"
        '
        'btnSignUp
        '
        Me.btnSignUp.Location = New System.Drawing.Point(478, 423)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.OverrideDefault.Back.Color1 = System.Drawing.Color.Orange
        Me.btnSignUp.OverrideDefault.Back.Color2 = System.Drawing.Color.Orange
        Me.btnSignUp.Size = New System.Drawing.Size(241, 50)
        Me.btnSignUp.StateCommon.Back.Color1 = System.Drawing.Color.Orange
        Me.btnSignUp.StateCommon.Back.Color2 = System.Drawing.Color.Orange
        Me.btnSignUp.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnSignUp.StateCommon.Border.Rounding = 10
        Me.btnSignUp.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnSignUp.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnSignUp.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignUp.TabIndex = 3
        Me.btnSignUp.Values.Text = "&SIGN UP"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(478, 243)
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
        Me.txtUsername.Location = New System.Drawing.Point(478, 174)
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
        Me.lblTitle.Location = New System.Drawing.Point(471, 18)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(138, 41)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "SIGN UP"
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
        Me.btnExit.TabIndex = 8
        Me.btnExit.Values.Text = "X"
        '
        'rbtRider
        '
        Me.rbtRider.Location = New System.Drawing.Point(650, 370)
        Me.rbtRider.Name = "rbtRider"
        Me.rbtRider.Size = New System.Drawing.Size(59, 24)
        Me.rbtRider.TabIndex = 64
        Me.rbtRider.Values.Text = "Rider"
        '
        'SignUpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(900, 600)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.pnlCard)
        Me.Controls.Add(Me.pblBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SignUpForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SignUpForm"
        Me.pnlCard.ResumeLayout(False)
        Me.pnlCard.PerformLayout()
        CType(Me.picGif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pblBack.ResumeLayout(False)
        Me.pblBack.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlCard As Panel
    Friend WithEvents btnLogin As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents picGif As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pblBack As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSignUp As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtPassword As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtUsername As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmail As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtConfirmPassword As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents rbtRequestor As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbtDonor As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents btnExit As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnEye1 As Button
    Friend WithEvents btnEye2 As Button
    Friend WithEvents rbtRider As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
End Class
