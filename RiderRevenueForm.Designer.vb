<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RiderRevenueForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDelivery = New System.Windows.Forms.DataGridView()
        Me.DeliveryID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Distance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Revenue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblRevenue = New System.Windows.Forms.Label()
        CType(Me.dgvDelivery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.Label1.Location = New System.Drawing.Point(0, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(970, 50)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "REVENUE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvDelivery
        '
        Me.dgvDelivery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDelivery.BackgroundColor = System.Drawing.Color.White
        Me.dgvDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDelivery.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DeliveryID, Me.Title, Me.Distance, Me.Revenue})
        Me.dgvDelivery.Location = New System.Drawing.Point(103, 169)
        Me.dgvDelivery.Name = "dgvDelivery"
        Me.dgvDelivery.RowHeadersWidth = 51
        Me.dgvDelivery.RowTemplate.Height = 24
        Me.dgvDelivery.Size = New System.Drawing.Size(772, 379)
        Me.dgvDelivery.TabIndex = 43
        '
        'DeliveryID
        '
        Me.DeliveryID.HeaderText = "DeliveryID"
        Me.DeliveryID.MinimumWidth = 6
        Me.DeliveryID.Name = "DeliveryID"
        '
        'Title
        '
        Me.Title.HeaderText = "Title"
        Me.Title.MinimumWidth = 6
        Me.Title.Name = "Title"
        '
        'Distance
        '
        Me.Distance.HeaderText = "Distance"
        Me.Distance.MinimumWidth = 6
        Me.Distance.Name = "Distance"
        '
        'Revenue
        '
        Me.Revenue.HeaderText = "Revenue"
        Me.Revenue.MinimumWidth = 6
        Me.Revenue.Name = "Revenue"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(485, 594)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(208, 38)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Total Revenue:"
        '
        'lblRevenue
        '
        Me.lblRevenue.AutoSize = True
        Me.lblRevenue.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRevenue.Location = New System.Drawing.Point(733, 594)
        Me.lblRevenue.Name = "lblRevenue"
        Me.lblRevenue.Size = New System.Drawing.Size(142, 38)
        Me.lblRevenue.TabIndex = 69
        Me.lblRevenue.Text = "RM 00.00"
        '
        'RiderRevenueForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(972, 700)
        Me.Controls.Add(Me.lblRevenue)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgvDelivery)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RiderRevenueForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RiderRevenueForm"
        CType(Me.dgvDelivery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDelivery As DataGridView
    Friend WithEvents DeliveryID As DataGridViewTextBoxColumn
    Friend WithEvents Title As DataGridViewTextBoxColumn
    Friend WithEvents Distance As DataGridViewTextBoxColumn
    Friend WithEvents Revenue As DataGridViewTextBoxColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents lblRevenue As Label
End Class
