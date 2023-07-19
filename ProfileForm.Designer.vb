<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfileForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProfileForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblOrganization = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnChoosePic = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnEdit = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnChangePassword = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(2, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(970, 50)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "PROFILE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 28)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Username                :"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(271, 103)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(96, 28)
        Me.lblUsername.TabIndex = 20
        Me.lblUsername.Text = "username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(207, 28)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Email                       :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(206, 28)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Organization           :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 281)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(206, 28)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Address                   :"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(271, 158)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(59, 28)
        Me.lblEmail.TabIndex = 24
        Me.lblEmail.Text = "email"
        '
        'lblOrganization
        '
        Me.lblOrganization.AutoSize = True
        Me.lblOrganization.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrganization.Location = New System.Drawing.Point(271, 214)
        Me.lblOrganization.Name = "lblOrganization"
        Me.lblOrganization.Size = New System.Drawing.Size(176, 28)
        Me.lblOrganization.TabIndex = 25
        Me.lblOrganization.Text = "organization name"
        '
        'lblAddress
        '
        Me.lblAddress.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(271, 281)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(525, 130)
        Me.lblAddress.TabIndex = 26
        Me.lblAddress.Text = "address"
        '
        'picProfile
        '
        Me.picProfile.Image = CType(resources.GetObject("picProfile.Image"), System.Drawing.Image)
        Me.picProfile.InitialImage = CType(resources.GetObject("picProfile.InitialImage"), System.Drawing.Image)
        Me.picProfile.Location = New System.Drawing.Point(618, 40)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(156, 168)
        Me.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProfile.TabIndex = 27
        Me.picProfile.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnChoosePic)
        Me.Panel1.Controls.Add(Me.lblAddress)
        Me.Panel1.Controls.Add(Me.picProfile)
        Me.Panel1.Controls.Add(Me.lblOrganization)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblEmail)
        Me.Panel1.Controls.Add(Me.lblUsername)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(73, 104)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(838, 478)
        Me.Panel1.TabIndex = 28
        '
        'btnChoosePic
        '
        Me.btnChoosePic.Location = New System.Drawing.Point(618, 214)
        Me.btnChoosePic.Name = "btnChoosePic"
        Me.btnChoosePic.OverrideDefault.Back.Color1 = System.Drawing.Color.Gold
        Me.btnChoosePic.OverrideDefault.Back.Color2 = System.Drawing.Color.Gold
        Me.btnChoosePic.OverrideDefault.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnChoosePic.OverrideDefault.Border.Rounding = 10
        Me.btnChoosePic.Size = New System.Drawing.Size(156, 39)
        Me.btnChoosePic.StateCommon.Back.Color1 = System.Drawing.Color.Gold
        Me.btnChoosePic.StateCommon.Back.Color2 = System.Drawing.Color.Gold
        Me.btnChoosePic.StateCommon.Border.Color1 = System.Drawing.Color.Gold
        Me.btnChoosePic.StateCommon.Border.Color2 = System.Drawing.Color.Gold
        Me.btnChoosePic.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnChoosePic.StateCommon.Border.Rounding = 10
        Me.btnChoosePic.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChoosePic.TabIndex = 35
        Me.btnChoosePic.Values.Text = "Choose Picture"
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(732, 619)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.OverrideDefault.Back.Color1 = System.Drawing.Color.Gold
        Me.btnEdit.OverrideDefault.Back.Color2 = System.Drawing.Color.Gold
        Me.btnEdit.OverrideDefault.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnEdit.OverrideDefault.Border.Rounding = 10
        Me.btnEdit.Size = New System.Drawing.Size(179, 46)
        Me.btnEdit.StateCommon.Back.Color1 = System.Drawing.Color.Gold
        Me.btnEdit.StateCommon.Back.Color2 = System.Drawing.Color.Gold
        Me.btnEdit.StateCommon.Border.Color1 = System.Drawing.Color.Gold
        Me.btnEdit.StateCommon.Border.Color2 = System.Drawing.Color.Gold
        Me.btnEdit.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnEdit.StateCommon.Border.Rounding = 10
        Me.btnEdit.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.TabIndex = 34
        Me.btnEdit.Values.Text = "Edit Profile"
        '
        'btnChangePassword
        '
        Me.btnChangePassword.Location = New System.Drawing.Point(464, 619)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.OverrideDefault.Back.Color1 = System.Drawing.Color.Gold
        Me.btnChangePassword.OverrideDefault.Back.Color2 = System.Drawing.Color.Gold
        Me.btnChangePassword.OverrideDefault.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnChangePassword.OverrideDefault.Border.Rounding = 10
        Me.btnChangePassword.Size = New System.Drawing.Size(243, 46)
        Me.btnChangePassword.StateCommon.Back.Color1 = System.Drawing.Color.Gold
        Me.btnChangePassword.StateCommon.Back.Color2 = System.Drawing.Color.Gold
        Me.btnChangePassword.StateCommon.Border.Color1 = System.Drawing.Color.Gold
        Me.btnChangePassword.StateCommon.Border.Color2 = System.Drawing.Color.Gold
        Me.btnChangePassword.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnChangePassword.StateCommon.Border.Rounding = 10
        Me.btnChangePassword.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePassword.TabIndex = 35
        Me.btnChangePassword.Values.Text = "Change Password"
        '
        'ProfileForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(972, 700)
        Me.Controls.Add(Me.btnChangePassword)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ProfileForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProfileForm"
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblOrganization As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents picProfile As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnEdit As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnChoosePic As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnChangePassword As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
