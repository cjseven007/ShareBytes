<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayForm
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
        Me.btnPay = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.dgvManage = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvPaymentMethod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvBankName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvAccountNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnExit = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        CType(Me.dgvManage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPay
        '
        Me.btnPay.Location = New System.Drawing.Point(690, 378)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnPay.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnPay.OverrideDefault.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnPay.OverrideDefault.Border.Rounding = 10
        Me.btnPay.Size = New System.Drawing.Size(139, 44)
        Me.btnPay.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnPay.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnPay.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnPay.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnPay.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnPay.StateCommon.Border.Rounding = 10
        Me.btnPay.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.TabIndex = 66
        Me.btnPay.Values.Text = "Pay"
        '
        'dgvManage
        '
        Me.dgvManage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvManage.BackgroundColor = System.Drawing.Color.White
        Me.dgvManage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvManage.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.dgvPaymentMethod, Me.dgvBankName, Me.dgvAccountNum})
        Me.dgvManage.Location = New System.Drawing.Point(57, 89)
        Me.dgvManage.Name = "dgvManage"
        Me.dgvManage.RowHeadersWidth = 51
        Me.dgvManage.RowTemplate.Height = 24
        Me.dgvManage.Size = New System.Drawing.Size(772, 258)
        Me.dgvManage.TabIndex = 65
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        '
        'dgvPaymentMethod
        '
        Me.dgvPaymentMethod.HeaderText = "Payment Method"
        Me.dgvPaymentMethod.MinimumWidth = 6
        Me.dgvPaymentMethod.Name = "dgvPaymentMethod"
        '
        'dgvBankName
        '
        Me.dgvBankName.HeaderText = "Bank Name"
        Me.dgvBankName.MinimumWidth = 6
        Me.dgvBankName.Name = "dgvBankName"
        '
        'dgvAccountNum
        '
        Me.dgvAccountNum.HeaderText = "Account Number"
        Me.dgvAccountNum.MinimumWidth = 6
        Me.dgvAccountNum.Name = "dgvAccountNum"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(410, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 38)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Pay"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Location = New System.Drawing.Point(856, 0)
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
        Me.btnExit.TabIndex = 68
        Me.btnExit.Values.Text = "X"
        '
        'PayForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(886, 465)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.dgvManage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PayForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PayForm"
        CType(Me.dgvManage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPay As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents dgvManage As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents dgvPaymentMethod As DataGridViewTextBoxColumn
    Friend WithEvents dgvBankName As DataGridViewTextBoxColumn
    Friend WithEvents dgvAccountNum As DataGridViewTextBoxColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents btnExit As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
