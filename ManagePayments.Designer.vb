<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagePayments
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
        Me.dgvManage = New System.Windows.Forms.DataGridView()
        Me.dgvPaymentMethod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvBankName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvAccountNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvIsDelete = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnDelete = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        CType(Me.dgvManage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Location = New System.Drawing.Point(896, 0)
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
        Me.btnExit.TabIndex = 41
        Me.btnExit.Values.Text = "X"
        '
        'dgvManage
        '
        Me.dgvManage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvManage.BackgroundColor = System.Drawing.Color.White
        Me.dgvManage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvManage.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvPaymentMethod, Me.dgvBankName, Me.dgvAccountNum, Me.dgvIsDelete})
        Me.dgvManage.Location = New System.Drawing.Point(77, 101)
        Me.dgvManage.Name = "dgvManage"
        Me.dgvManage.RowHeadersWidth = 51
        Me.dgvManage.RowTemplate.Height = 24
        Me.dgvManage.Size = New System.Drawing.Size(772, 346)
        Me.dgvManage.TabIndex = 42
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
        'dgvIsDelete
        '
        Me.dgvIsDelete.HeaderText = "Checked"
        Me.dgvIsDelete.MinimumWidth = 6
        Me.dgvIsDelete.Name = "dgvIsDelete"
        Me.dgvIsDelete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvIsDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(338, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(251, 38)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Manage Accounts"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(720, 495)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDelete.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDelete.OverrideDefault.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnDelete.OverrideDefault.Border.Rounding = 10
        Me.btnDelete.Size = New System.Drawing.Size(139, 44)
        Me.btnDelete.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDelete.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDelete.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDelete.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDelete.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnDelete.StateCommon.Border.Rounding = 10
        Me.btnDelete.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.TabIndex = 64
        Me.btnDelete.Values.Text = "Delete"
        '
        'ManagePayments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(926, 575)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgvManage)
        Me.Controls.Add(Me.btnExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManagePayments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManagePayments"
        CType(Me.dgvManage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents dgvManage As DataGridView
    Friend WithEvents dgvPaymentMethod As DataGridViewTextBoxColumn
    Friend WithEvents dgvBankName As DataGridViewTextBoxColumn
    Friend WithEvents dgvAccountNum As DataGridViewTextBoxColumn
    Friend WithEvents dgvIsDelete As DataGridViewCheckBoxColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents btnDelete As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
