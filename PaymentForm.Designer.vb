﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentForm
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnExit = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnCard = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBanking = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnManageAcc = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(120, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(459, 38)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "SET UP YOUR PAYMENT METHOD"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Location = New System.Drawing.Point(678, -1)
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
        Me.btnExit.TabIndex = 36
        Me.btnExit.Values.Text = "X"
        '
        'btnCard
        '
        Me.btnCard.Location = New System.Drawing.Point(104, 126)
        Me.btnCard.Name = "btnCard"
        Me.btnCard.OverrideDefault.Back.Color1 = System.Drawing.Color.White
        Me.btnCard.OverrideDefault.Back.Color2 = System.Drawing.Color.White
        Me.btnCard.OverrideDefault.Border.Color1 = System.Drawing.Color.White
        Me.btnCard.OverrideDefault.Border.Color2 = System.Drawing.Color.White
        Me.btnCard.OverrideDefault.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnCard.OverrideDefault.Border.Rounding = 20
        Me.btnCard.Size = New System.Drawing.Size(220, 200)
        Me.btnCard.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.btnCard.StateCommon.Back.Color2 = System.Drawing.Color.White
        Me.btnCard.StateCommon.Back.Image = Global.ShareBytes_Prototype.My.Resources.Resources.atm_card__1_
        Me.btnCard.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch
        Me.btnCard.StateCommon.Border.Color1 = System.Drawing.Color.White
        Me.btnCard.StateCommon.Border.Color2 = System.Drawing.Color.White
        Me.btnCard.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnCard.StateCommon.Border.Rounding = 20
        Me.btnCard.StateCommon.Border.Width = 50
        Me.btnCard.StateCommon.Content.ShortText.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.[True]
        Me.btnCard.TabIndex = 37
        Me.btnCard.Values.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(172, 283)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 23)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Add Card"
        '
        'btnBanking
        '
        Me.btnBanking.Location = New System.Drawing.Point(382, 126)
        Me.btnBanking.Name = "btnBanking"
        Me.btnBanking.OverrideDefault.Back.Color1 = System.Drawing.Color.White
        Me.btnBanking.OverrideDefault.Back.Color2 = System.Drawing.Color.White
        Me.btnBanking.OverrideDefault.Border.Color1 = System.Drawing.Color.White
        Me.btnBanking.OverrideDefault.Border.Color2 = System.Drawing.Color.White
        Me.btnBanking.OverrideDefault.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnBanking.OverrideDefault.Border.Rounding = 20
        Me.btnBanking.Size = New System.Drawing.Size(220, 200)
        Me.btnBanking.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.btnBanking.StateCommon.Back.Color2 = System.Drawing.Color.White
        Me.btnBanking.StateCommon.Back.Image = Global.ShareBytes_Prototype.My.Resources.Resources.bank
        Me.btnBanking.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch
        Me.btnBanking.StateCommon.Border.Color1 = System.Drawing.Color.White
        Me.btnBanking.StateCommon.Border.Color2 = System.Drawing.Color.White
        Me.btnBanking.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnBanking.StateCommon.Border.Rounding = 20
        Me.btnBanking.StateCommon.Border.Width = 50
        Me.btnBanking.StateCommon.Content.ShortText.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.[True]
        Me.btnBanking.TabIndex = 39
        Me.btnBanking.Values.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(426, 283)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 23)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Online Banking"
        '
        'btnManageAcc
        '
        Me.btnManageAcc.Location = New System.Drawing.Point(246, 358)
        Me.btnManageAcc.Name = "btnManageAcc"
        Me.btnManageAcc.OverrideDefault.Back.Color1 = System.Drawing.Color.Gold
        Me.btnManageAcc.OverrideDefault.Back.Color2 = System.Drawing.Color.Gold
        Me.btnManageAcc.OverrideDefault.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnManageAcc.OverrideDefault.Border.Rounding = 10
        Me.btnManageAcc.Size = New System.Drawing.Size(215, 48)
        Me.btnManageAcc.StateCommon.Back.Color1 = System.Drawing.Color.Gold
        Me.btnManageAcc.StateCommon.Back.Color2 = System.Drawing.Color.Gold
        Me.btnManageAcc.StateCommon.Border.Color1 = System.Drawing.Color.Gold
        Me.btnManageAcc.StateCommon.Border.Color2 = System.Drawing.Color.Gold
        Me.btnManageAcc.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnManageAcc.StateCommon.Border.Rounding = 10
        Me.btnManageAcc.StateCommon.Content.LongText.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.[True]
        Me.btnManageAcc.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageAcc.StateCommon.Content.ShortText.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.[True]
        Me.btnManageAcc.TabIndex = 62
        Me.btnManageAcc.Values.Text = "Manage Accounts"
        '
        'PaymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(707, 464)
        Me.Controls.Add(Me.btnManageAcc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnBanking)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCard)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PaymentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PaymentForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents btnExit As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnCard As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBanking As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents Label2 As Label
    Friend WithEvents btnManageAcc As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
