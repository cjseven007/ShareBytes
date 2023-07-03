<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CardForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnCard = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnExit = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCardNum = New System.Windows.Forms.TextBox()
        Me.lblCardNum1 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCard
        '
        Me.btnCard.Location = New System.Drawing.Point(98, 63)
        Me.btnCard.Name = "btnCard"
        Me.btnCard.OverrideDefault.Back.Color1 = System.Drawing.Color.MidnightBlue
        Me.btnCard.OverrideDefault.Back.Color2 = System.Drawing.Color.MidnightBlue
        Me.btnCard.OverrideDefault.Border.Color1 = System.Drawing.Color.MidnightBlue
        Me.btnCard.OverrideDefault.Border.Color2 = System.Drawing.Color.MidnightBlue
        Me.btnCard.OverrideDefault.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnCard.OverrideDefault.Border.Rounding = 20
        Me.btnCard.Size = New System.Drawing.Size(559, 343)
        Me.btnCard.StateCommon.Back.Color1 = System.Drawing.Color.MidnightBlue
        Me.btnCard.StateCommon.Back.Color2 = System.Drawing.Color.MidnightBlue
        Me.btnCard.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Tile
        Me.btnCard.StateCommon.Border.Color1 = System.Drawing.Color.MidnightBlue
        Me.btnCard.StateCommon.Border.Color2 = System.Drawing.Color.MidnightBlue
        Me.btnCard.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnCard.StateCommon.Border.Rounding = 20
        Me.btnCard.StateCommon.Content.ShortText.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.[True]
        Me.btnCard.TabIndex = 38
        Me.btnCard.Values.Text = ""
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Location = New System.Drawing.Point(725, 0)
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
        Me.btnExit.TabIndex = 39
        Me.btnExit.Values.Text = "X"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(251, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(252, 38)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Enter Card Details"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gold
        Me.Panel1.Location = New System.Drawing.Point(152, 139)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(82, 68)
        Me.Panel1.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(469, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 38)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Kok Bank"
        '
        'txtCardNum
        '
        Me.txtCardNum.Location = New System.Drawing.Point(102, 437)
        Me.txtCardNum.Name = "txtCardNum"
        Me.txtCardNum.Size = New System.Drawing.Size(200, 22)
        Me.txtCardNum.TabIndex = 43
        '
        'lblCardNum1
        '
        Me.lblCardNum1.AutoSize = True
        Me.lblCardNum1.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblCardNum1.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardNum1.ForeColor = System.Drawing.Color.White
        Me.lblCardNum1.Location = New System.Drawing.Point(143, 254)
        Me.lblCardNum1.Name = "lblCardNum1"
        Me.lblCardNum1.Size = New System.Drawing.Size(464, 50)
        Me.lblCardNum1.TabIndex = 44
        Me.lblCardNum1.Text = "####   ####   ####   ####"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(144, 325)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(97, 38)
        Me.lblDate.TabIndex = 48
        Me.lblDate.Text = "##/##"
        '
        'CardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(755, 530)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblCardNum1)
        Me.Controls.Add(Me.txtCardNum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCard)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CardForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CardForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCard As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnExit As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCardNum As TextBox
    Friend WithEvents lblCardNum1 As Label
    Friend WithEvents lblDate As Label
End Class
