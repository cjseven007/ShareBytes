<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BankingForm
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCardNum = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboBanks = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPassword = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.btnEye = New System.Windows.Forms.Button()
        Me.btnPayment = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        CType(Me.cboBanks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Location = New System.Drawing.Point(478, -1)
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
        Me.btnExit.TabIndex = 40
        Me.btnExit.Values.Text = "X"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(103, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(300, 38)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Enter Banking Details"
        '
        'txtCardNum
        '
        Me.txtCardNum.Location = New System.Drawing.Point(79, 209)
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
        Me.txtCardNum.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 28)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Account Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 28)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Bank Name"
        '
        'cboBanks
        '
        Me.cboBanks.DropDownWidth = 335
        Me.cboBanks.Items.AddRange(New Object() {"Touch N' Go", "Grab Pay", "Ambank Malaysia Berhad", "Bank Islam Malaysia Berhad", "Bank Kerjasama Rakyat Malaysia Berhad", "Bank Simpanan Nasional Berhad", "CIMB Bank Berhad", "Hong Leong Bank Berhad", "Maybank Berhad", "Public Bank Berhad"})
        Me.cboBanks.Location = New System.Drawing.Point(79, 128)
        Me.cboBanks.Name = "cboBanks"
        Me.cboBanks.Size = New System.Drawing.Size(341, 38)
        Me.cboBanks.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Gray
        Me.cboBanks.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Gray
        Me.cboBanks.StateCommon.ComboBox.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.cboBanks.StateCommon.ComboBox.Border.Rounding = 10
        Me.cboBanks.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBanks.TabIndex = 57
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(74, 267)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 28)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(79, 298)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(241, 40)
        Me.txtPassword.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtPassword.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.txtPassword.StateCommon.Border.Color2 = System.Drawing.Color.Gray
        Me.txtPassword.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtPassword.StateCommon.Border.Rounding = 10
        Me.txtPassword.StateCommon.Content.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.TabIndex = 59
        '
        'btnEye
        '
        Me.btnEye.BackColor = System.Drawing.Color.Transparent
        Me.btnEye.BackgroundImage = Global.ShareBytes_Prototype.My.Resources.Resources.eye
        Me.btnEye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEye.Location = New System.Drawing.Point(326, 302)
        Me.btnEye.Name = "btnEye"
        Me.btnEye.Size = New System.Drawing.Size(35, 35)
        Me.btnEye.TabIndex = 60
        Me.btnEye.UseVisualStyleBackColor = False
        '
        'btnPayment
        '
        Me.btnPayment.Location = New System.Drawing.Point(281, 368)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.OverrideDefault.Back.Color1 = System.Drawing.Color.Gold
        Me.btnPayment.OverrideDefault.Back.Color2 = System.Drawing.Color.Gold
        Me.btnPayment.OverrideDefault.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnPayment.OverrideDefault.Border.Rounding = 10
        Me.btnPayment.Size = New System.Drawing.Size(181, 48)
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
        Me.btnPayment.TabIndex = 61
        Me.btnPayment.Values.Text = "Save Account"
        '
        'BankingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(507, 450)
        Me.Controls.Add(Me.btnPayment)
        Me.Controls.Add(Me.btnEye)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboBanks)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCardNum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BankingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BankingForm"
        CType(Me.cboBanks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCardNum As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboBanks As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPassword As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnEye As Button
    Friend WithEvents btnPayment As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
