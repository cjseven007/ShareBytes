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
        Me.lblBankName = New System.Windows.Forms.Label()
        Me.lblCardNum1 = New System.Windows.Forms.Label()
        Me.lblDate1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCardNum = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDate = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox()
        Me.lblCCV = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCCV = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblDate2 = New System.Windows.Forms.Label()
        Me.btnPayment = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.cboBanks = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        CType(Me.cboBanks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCard
        '
        Me.btnCard.Location = New System.Drawing.Point(98, 91)
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
        Me.Label6.Location = New System.Drawing.Point(251, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(252, 38)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Enter Card Details"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gold
        Me.Panel1.Location = New System.Drawing.Point(152, 167)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(82, 68)
        Me.Panel1.TabIndex = 41
        '
        'lblBankName
        '
        Me.lblBankName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBankName.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblBankName.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBankName.ForeColor = System.Drawing.Color.White
        Me.lblBankName.Location = New System.Drawing.Point(356, 180)
        Me.lblBankName.Name = "lblBankName"
        Me.lblBankName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBankName.Size = New System.Drawing.Size(251, 38)
        Me.lblBankName.TabIndex = 42
        Me.lblBankName.Text = "Bank Name"
        Me.lblBankName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCardNum1
        '
        Me.lblCardNum1.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblCardNum1.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardNum1.ForeColor = System.Drawing.Color.White
        Me.lblCardNum1.Location = New System.Drawing.Point(98, 282)
        Me.lblCardNum1.Name = "lblCardNum1"
        Me.lblCardNum1.Size = New System.Drawing.Size(559, 50)
        Me.lblCardNum1.TabIndex = 44
        Me.lblCardNum1.Text = "####   ####   ####   ####"
        Me.lblCardNum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDate1
        '
        Me.lblDate1.AutoSize = True
        Me.lblDate1.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblDate1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate1.ForeColor = System.Drawing.Color.White
        Me.lblDate1.Location = New System.Drawing.Point(144, 353)
        Me.lblDate1.Name = "lblDate1"
        Me.lblDate1.Size = New System.Drawing.Size(97, 38)
        Me.lblDate1.TabIndex = 48
        Me.lblDate1.Text = "##/##"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(411, 459)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 28)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Card Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(93, 459)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 28)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Bank Name"
        '
        'txtCardNum
        '
        Me.txtCardNum.Location = New System.Drawing.Point(416, 490)
        Me.txtCardNum.Name = "txtCardNum"
        Me.txtCardNum.Size = New System.Drawing.Size(241, 40)
        Me.txtCardNum.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtCardNum.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.txtCardNum.StateCommon.Border.Color2 = System.Drawing.Color.Gray
        Me.txtCardNum.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtCardNum.StateCommon.Border.Rounding = 10
        Me.txtCardNum.StateCommon.Content.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardNum.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(93, 544)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 28)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Expiry Date"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(98, 575)
        Me.txtDate.Mask = "##/##"
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(100, 41)
        Me.txtDate.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.txtDate.StateCommon.Border.Color2 = System.Drawing.Color.Gray
        Me.txtDate.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtDate.StateCommon.Border.Rounding = 10
        Me.txtDate.StateCommon.Content.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.TabIndex = 55
        Me.txtDate.Text = "  /"
        '
        'lblCCV
        '
        Me.lblCCV.AutoSize = True
        Me.lblCCV.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblCCV.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCCV.ForeColor = System.Drawing.Color.White
        Me.lblCCV.Location = New System.Drawing.Point(387, 353)
        Me.lblCCV.Name = "lblCCV"
        Me.lblCCV.Size = New System.Drawing.Size(68, 38)
        Me.lblCCV.TabIndex = 56
        Me.lblCCV.Text = "###"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(241, 544)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 28)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "CVV"
        '
        'txtCCV
        '
        Me.txtCCV.Location = New System.Drawing.Point(244, 575)
        Me.txtCCV.Name = "txtCCV"
        Me.txtCCV.Size = New System.Drawing.Size(95, 40)
        Me.txtCCV.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtCCV.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.txtCCV.StateCommon.Border.Color2 = System.Drawing.Color.Gray
        Me.txtCCV.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtCCV.StateCommon.Border.Rounding = 10
        Me.txtCCV.StateCommon.Content.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCCV.TabIndex = 58
        '
        'lblDate2
        '
        Me.lblDate2.AutoSize = True
        Me.lblDate2.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblDate2.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate2.ForeColor = System.Drawing.Color.White
        Me.lblDate2.Location = New System.Drawing.Point(216, 353)
        Me.lblDate2.Name = "lblDate2"
        Me.lblDate2.Size = New System.Drawing.Size(0, 38)
        Me.lblDate2.TabIndex = 59
        '
        'btnPayment
        '
        Me.btnPayment.Location = New System.Drawing.Point(521, 575)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.OverrideDefault.Back.Color1 = System.Drawing.Color.Gold
        Me.btnPayment.OverrideDefault.Back.Color2 = System.Drawing.Color.Gold
        Me.btnPayment.OverrideDefault.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnPayment.OverrideDefault.Border.Rounding = 10
        Me.btnPayment.Size = New System.Drawing.Size(136, 48)
        Me.btnPayment.StateCommon.Back.Color1 = System.Drawing.Color.Gold
        Me.btnPayment.StateCommon.Back.Color2 = System.Drawing.Color.Gold
        Me.btnPayment.StateCommon.Border.Color1 = System.Drawing.Color.Gold
        Me.btnPayment.StateCommon.Border.Color2 = System.Drawing.Color.Gold
        Me.btnPayment.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnPayment.StateCommon.Border.Rounding = 10
        Me.btnPayment.StateCommon.Content.LongText.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.[True]
        Me.btnPayment.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayment.StateCommon.Content.ShortText.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.[True]
        Me.btnPayment.TabIndex = 60
        Me.btnPayment.Values.Text = "Save Card"
        '
        'cboBanks
        '
        Me.cboBanks.DropDownWidth = 335
        Me.cboBanks.Items.AddRange(New Object() {"Touch N' Go", "Grab Pay", "Ambank Malaysia Berhad", "Bank Islam Malaysia Berhad", "Bank Kerjasama Rakyat Malaysia Berhad", "Bank Simpanan Nasional Berhad", "CIMB Bank Berhad", "Hong Leong Bank Berhad", "Maybank Berhad", "Public Bank Berhad"})
        Me.cboBanks.Location = New System.Drawing.Point(98, 492)
        Me.cboBanks.Name = "cboBanks"
        Me.cboBanks.Size = New System.Drawing.Size(288, 38)
        Me.cboBanks.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Gray
        Me.cboBanks.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Gray
        Me.cboBanks.StateCommon.ComboBox.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.cboBanks.StateCommon.ComboBox.Border.Rounding = 10
        Me.cboBanks.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBanks.TabIndex = 61
        '
        'CardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(755, 660)
        Me.Controls.Add(Me.cboBanks)
        Me.Controls.Add(Me.btnPayment)
        Me.Controls.Add(Me.lblDate2)
        Me.Controls.Add(Me.txtCCV)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblCCV)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCardNum)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblDate1)
        Me.Controls.Add(Me.lblCardNum1)
        Me.Controls.Add(Me.lblBankName)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCard)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CardForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CardForm"
        CType(Me.cboBanks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCard As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnExit As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblBankName As Label
    Friend WithEvents lblCardNum1 As Label
    Friend WithEvents lblDate1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCardNum As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDate As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Friend WithEvents lblCCV As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCCV As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblDate2 As Label
    Friend WithEvents btnPayment As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents cboBanks As ComponentFactory.Krypton.Toolkit.KryptonComboBox
End Class
