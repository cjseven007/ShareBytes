<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RequestorTrackingForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlTracking = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDelivered = New System.Windows.Forms.Label()
        Me.lblPaid = New System.Windows.Forms.Label()
        Me.lblPending = New System.Windows.Forms.Label()
        Me.btnPayment = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnPaidFilter = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnPendingFilter = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnDeliveredFilter = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnAll = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(1, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(970, 50)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "TRACKING"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlTracking
        '
        Me.pnlTracking.AutoScroll = True
        Me.pnlTracking.Location = New System.Drawing.Point(281, 95)
        Me.pnlTracking.Name = "pnlTracking"
        Me.pnlTracking.Size = New System.Drawing.Size(637, 519)
        Me.pnlTracking.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lblDelivered)
        Me.Panel2.Controls.Add(Me.lblPaid)
        Me.Panel2.Controls.Add(Me.lblPending)
        Me.Panel2.Location = New System.Drawing.Point(55, 342)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(209, 199)
        Me.Panel2.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Status"
        '
        'lblDelivered
        '
        Me.lblDelivered.AutoSize = True
        Me.lblDelivered.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDelivered.Location = New System.Drawing.Point(40, 144)
        Me.lblDelivered.Name = "lblDelivered"
        Me.lblDelivered.Size = New System.Drawing.Size(99, 23)
        Me.lblDelivered.TabIndex = 2
        Me.lblDelivered.Text = "lblDelivered"
        '
        'lblPaid
        '
        Me.lblPaid.AutoSize = True
        Me.lblPaid.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaid.Location = New System.Drawing.Point(40, 105)
        Me.lblPaid.Name = "lblPaid"
        Me.lblPaid.Size = New System.Drawing.Size(60, 23)
        Me.lblPaid.TabIndex = 1
        Me.lblPaid.Text = "lblPaid"
        '
        'lblPending
        '
        Me.lblPending.AutoSize = True
        Me.lblPending.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPending.Location = New System.Drawing.Point(40, 63)
        Me.lblPending.Name = "lblPending"
        Me.lblPending.Size = New System.Drawing.Size(90, 23)
        Me.lblPending.TabIndex = 0
        Me.lblPending.Text = "lblPending"
        '
        'btnPayment
        '
        Me.btnPayment.Location = New System.Drawing.Point(55, 566)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.OverrideDefault.Back.Color1 = System.Drawing.Color.Gold
        Me.btnPayment.OverrideDefault.Back.Color2 = System.Drawing.Color.Gold
        Me.btnPayment.OverrideDefault.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnPayment.OverrideDefault.Border.Rounding = 10
        Me.btnPayment.Size = New System.Drawing.Size(209, 48)
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
        Me.btnPayment.TabIndex = 35
        Me.btnPayment.Values.Text = "Payment Method"
        '
        'btnPaidFilter
        '
        Me.btnPaidFilter.Location = New System.Drawing.Point(55, 169)
        Me.btnPaidFilter.Name = "btnPaidFilter"
        Me.btnPaidFilter.OverrideDefault.Back.Color1 = System.Drawing.Color.GreenYellow
        Me.btnPaidFilter.OverrideDefault.Back.Color2 = System.Drawing.Color.GreenYellow
        Me.btnPaidFilter.OverrideDefault.Border.Color1 = System.Drawing.Color.GreenYellow
        Me.btnPaidFilter.OverrideDefault.Border.Color2 = System.Drawing.Color.GreenYellow
        Me.btnPaidFilter.OverrideDefault.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnPaidFilter.OverrideDefault.Border.Rounding = 10
        Me.btnPaidFilter.Size = New System.Drawing.Size(240, 48)
        Me.btnPaidFilter.StateCommon.Back.Color1 = System.Drawing.Color.GreenYellow
        Me.btnPaidFilter.StateCommon.Back.Color2 = System.Drawing.Color.GreenYellow
        Me.btnPaidFilter.StateCommon.Border.Color1 = System.Drawing.Color.GreenYellow
        Me.btnPaidFilter.StateCommon.Border.Color2 = System.Drawing.Color.GreenYellow
        Me.btnPaidFilter.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnPaidFilter.StateCommon.Border.Rounding = 20
        Me.btnPaidFilter.StateCommon.Content.LongText.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.[True]
        Me.btnPaidFilter.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPaidFilter.StateCommon.Content.ShortText.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.[True]
        Me.btnPaidFilter.TabIndex = 36
        Me.btnPaidFilter.Values.Text = "Paid"
        '
        'btnPendingFilter
        '
        Me.btnPendingFilter.Location = New System.Drawing.Point(55, 115)
        Me.btnPendingFilter.Name = "btnPendingFilter"
        Me.btnPendingFilter.OverrideDefault.Back.Color1 = System.Drawing.Color.Orange
        Me.btnPendingFilter.OverrideDefault.Back.Color2 = System.Drawing.Color.Orange
        Me.btnPendingFilter.OverrideDefault.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnPendingFilter.OverrideDefault.Border.Rounding = 10
        Me.btnPendingFilter.Size = New System.Drawing.Size(240, 48)
        Me.btnPendingFilter.StateCommon.Back.Color1 = System.Drawing.Color.Yellow
        Me.btnPendingFilter.StateCommon.Back.Color2 = System.Drawing.Color.Yellow
        Me.btnPendingFilter.StateCommon.Border.Color1 = System.Drawing.Color.Yellow
        Me.btnPendingFilter.StateCommon.Border.Color2 = System.Drawing.Color.Yellow
        Me.btnPendingFilter.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnPendingFilter.StateCommon.Border.Rounding = 20
        Me.btnPendingFilter.StateCommon.Content.LongText.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.[True]
        Me.btnPendingFilter.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPendingFilter.StateCommon.Content.ShortText.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.[True]
        Me.btnPendingFilter.TabIndex = 37
        Me.btnPendingFilter.Values.Text = "Pending Payment"
        '
        'btnDeliveredFilter
        '
        Me.btnDeliveredFilter.Location = New System.Drawing.Point(55, 223)
        Me.btnDeliveredFilter.Name = "btnDeliveredFilter"
        Me.btnDeliveredFilter.OverrideDefault.Back.Color1 = System.Drawing.Color.LightSkyBlue
        Me.btnDeliveredFilter.OverrideDefault.Back.Color2 = System.Drawing.Color.LightSkyBlue
        Me.btnDeliveredFilter.OverrideDefault.Border.Color1 = System.Drawing.Color.LightSkyBlue
        Me.btnDeliveredFilter.OverrideDefault.Border.Color2 = System.Drawing.Color.LightSkyBlue
        Me.btnDeliveredFilter.OverrideDefault.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnDeliveredFilter.OverrideDefault.Border.Rounding = 10
        Me.btnDeliveredFilter.Size = New System.Drawing.Size(240, 48)
        Me.btnDeliveredFilter.StateCommon.Back.Color1 = System.Drawing.Color.LightSkyBlue
        Me.btnDeliveredFilter.StateCommon.Back.Color2 = System.Drawing.Color.LightSkyBlue
        Me.btnDeliveredFilter.StateCommon.Border.Color1 = System.Drawing.Color.LightSkyBlue
        Me.btnDeliveredFilter.StateCommon.Border.Color2 = System.Drawing.Color.LightSkyBlue
        Me.btnDeliveredFilter.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnDeliveredFilter.StateCommon.Border.Rounding = 20
        Me.btnDeliveredFilter.StateCommon.Content.LongText.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.[True]
        Me.btnDeliveredFilter.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeliveredFilter.StateCommon.Content.ShortText.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.[True]
        Me.btnDeliveredFilter.TabIndex = 38
        Me.btnDeliveredFilter.Values.Text = "Delivered"
        '
        'btnAll
        '
        Me.btnAll.Location = New System.Drawing.Point(55, 275)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.OverrideDefault.Back.Color1 = System.Drawing.Color.Pink
        Me.btnAll.OverrideDefault.Back.Color2 = System.Drawing.Color.Pink
        Me.btnAll.OverrideDefault.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnAll.OverrideDefault.Border.Rounding = 10
        Me.btnAll.Size = New System.Drawing.Size(240, 48)
        Me.btnAll.StateCommon.Back.Color1 = System.Drawing.Color.Pink
        Me.btnAll.StateCommon.Back.Color2 = System.Drawing.Color.Pink
        Me.btnAll.StateCommon.Border.Color1 = System.Drawing.Color.Pink
        Me.btnAll.StateCommon.Border.Color2 = System.Drawing.Color.Pink
        Me.btnAll.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnAll.StateCommon.Border.Rounding = 20
        Me.btnAll.StateCommon.Content.LongText.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.[True]
        Me.btnAll.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAll.StateCommon.Content.ShortText.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.[True]
        Me.btnAll.TabIndex = 39
        Me.btnAll.Values.Text = "All"
        '
        'RequestorTrackingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(972, 700)
        Me.Controls.Add(Me.pnlTracking)
        Me.Controls.Add(Me.btnDeliveredFilter)
        Me.Controls.Add(Me.btnPendingFilter)
        Me.Controls.Add(Me.btnPaidFilter)
        Me.Controls.Add(Me.btnPayment)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAll)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RequestorTrackingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RequestorTrackingForm"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents pnlTracking As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnPayment As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnPaidFilter As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnPendingFilter As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnDeliveredFilter As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents lblPending As Label
    Friend WithEvents lblPaid As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDelivered As Label
    Friend WithEvents btnAll As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
