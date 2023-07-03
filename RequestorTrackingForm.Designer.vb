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
        Me.btnPayment = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnFilterCompleted = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonButton1 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonButton2 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.lblPending = New System.Windows.Forms.Label()
        Me.lblPaid = New System.Windows.Forms.Label()
        Me.lblDelivered = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.Panel2.Location = New System.Drawing.Point(55, 312)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(209, 199)
        Me.Panel2.TabIndex = 6
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
        'btnFilterCompleted
        '
        Me.btnFilterCompleted.Location = New System.Drawing.Point(55, 169)
        Me.btnFilterCompleted.Name = "btnFilterCompleted"
        Me.btnFilterCompleted.OverrideDefault.Back.Color1 = System.Drawing.Color.GreenYellow
        Me.btnFilterCompleted.OverrideDefault.Back.Color2 = System.Drawing.Color.GreenYellow
        Me.btnFilterCompleted.OverrideDefault.Border.Color1 = System.Drawing.Color.GreenYellow
        Me.btnFilterCompleted.OverrideDefault.Border.Color2 = System.Drawing.Color.GreenYellow
        Me.btnFilterCompleted.OverrideDefault.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnFilterCompleted.OverrideDefault.Border.Rounding = 10
        Me.btnFilterCompleted.Size = New System.Drawing.Size(240, 48)
        Me.btnFilterCompleted.StateCommon.Back.Color1 = System.Drawing.Color.GreenYellow
        Me.btnFilterCompleted.StateCommon.Back.Color2 = System.Drawing.Color.GreenYellow
        Me.btnFilterCompleted.StateCommon.Border.Color1 = System.Drawing.Color.GreenYellow
        Me.btnFilterCompleted.StateCommon.Border.Color2 = System.Drawing.Color.GreenYellow
        Me.btnFilterCompleted.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnFilterCompleted.StateCommon.Border.Rounding = 20
        Me.btnFilterCompleted.StateCommon.Content.LongText.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.[True]
        Me.btnFilterCompleted.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilterCompleted.StateCommon.Content.ShortText.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.[True]
        Me.btnFilterCompleted.TabIndex = 36
        Me.btnFilterCompleted.Values.Text = "Paid"
        '
        'KryptonButton1
        '
        Me.KryptonButton1.Location = New System.Drawing.Point(55, 115)
        Me.KryptonButton1.Name = "KryptonButton1"
        Me.KryptonButton1.OverrideDefault.Back.Color1 = System.Drawing.Color.Orange
        Me.KryptonButton1.OverrideDefault.Back.Color2 = System.Drawing.Color.Orange
        Me.KryptonButton1.OverrideDefault.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonButton1.OverrideDefault.Border.Rounding = 10
        Me.KryptonButton1.Size = New System.Drawing.Size(240, 48)
        Me.KryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.Yellow
        Me.KryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.Yellow
        Me.KryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.Yellow
        Me.KryptonButton1.StateCommon.Border.Color2 = System.Drawing.Color.Yellow
        Me.KryptonButton1.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonButton1.StateCommon.Border.Rounding = 20
        Me.KryptonButton1.StateCommon.Content.LongText.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.[True]
        Me.KryptonButton1.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonButton1.StateCommon.Content.ShortText.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.[True]
        Me.KryptonButton1.TabIndex = 37
        Me.KryptonButton1.Values.Text = "Pending Payment"
        '
        'KryptonButton2
        '
        Me.KryptonButton2.Location = New System.Drawing.Point(55, 223)
        Me.KryptonButton2.Name = "KryptonButton2"
        Me.KryptonButton2.OverrideDefault.Back.Color1 = System.Drawing.Color.LightSkyBlue
        Me.KryptonButton2.OverrideDefault.Back.Color2 = System.Drawing.Color.LightSkyBlue
        Me.KryptonButton2.OverrideDefault.Border.Color1 = System.Drawing.Color.LightSkyBlue
        Me.KryptonButton2.OverrideDefault.Border.Color2 = System.Drawing.Color.LightSkyBlue
        Me.KryptonButton2.OverrideDefault.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonButton2.OverrideDefault.Border.Rounding = 10
        Me.KryptonButton2.Size = New System.Drawing.Size(240, 48)
        Me.KryptonButton2.StateCommon.Back.Color1 = System.Drawing.Color.LightSkyBlue
        Me.KryptonButton2.StateCommon.Back.Color2 = System.Drawing.Color.LightSkyBlue
        Me.KryptonButton2.StateCommon.Border.Color1 = System.Drawing.Color.LightSkyBlue
        Me.KryptonButton2.StateCommon.Border.Color2 = System.Drawing.Color.LightSkyBlue
        Me.KryptonButton2.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonButton2.StateCommon.Border.Rounding = 20
        Me.KryptonButton2.StateCommon.Content.LongText.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.[True]
        Me.KryptonButton2.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonButton2.StateCommon.Content.ShortText.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.[True]
        Me.KryptonButton2.TabIndex = 38
        Me.KryptonButton2.Values.Text = "Delivered"
        '
        'lblPending
        '
        Me.lblPending.AutoSize = True
        Me.lblPending.Location = New System.Drawing.Point(17, 55)
        Me.lblPending.Name = "lblPending"
        Me.lblPending.Size = New System.Drawing.Size(71, 16)
        Me.lblPending.TabIndex = 0
        Me.lblPending.Text = "lblPending"
        '
        'lblPaid
        '
        Me.lblPaid.AutoSize = True
        Me.lblPaid.Location = New System.Drawing.Point(17, 99)
        Me.lblPaid.Name = "lblPaid"
        Me.lblPaid.Size = New System.Drawing.Size(49, 16)
        Me.lblPaid.TabIndex = 1
        Me.lblPaid.Text = "lblPaid"
        '
        'lblDelivered
        '
        Me.lblDelivered.AutoSize = True
        Me.lblDelivered.Location = New System.Drawing.Point(18, 141)
        Me.lblDelivered.Name = "lblDelivered"
        Me.lblDelivered.Size = New System.Drawing.Size(80, 16)
        Me.lblDelivered.TabIndex = 2
        Me.lblDelivered.Text = "lblDelivered"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Status"
        '
        'RequestorTrackingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(972, 700)
        Me.Controls.Add(Me.pnlTracking)
        Me.Controls.Add(Me.KryptonButton2)
        Me.Controls.Add(Me.KryptonButton1)
        Me.Controls.Add(Me.btnFilterCompleted)
        Me.Controls.Add(Me.btnPayment)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents btnFilterCompleted As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonButton1 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonButton2 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents lblPending As Label
    Friend WithEvents lblPaid As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDelivered As Label
End Class
