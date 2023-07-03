<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RequestorTrackingForm
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
        Me.pnlTracking = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnPayment = New ComponentFactory.Krypton.Toolkit.KryptonButton()
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
        Me.pnlTracking.Location = New System.Drawing.Point(281, 115)
        Me.pnlTracking.Name = "pnlTracking"
        Me.pnlTracking.Size = New System.Drawing.Size(637, 499)
        Me.pnlTracking.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(55, 115)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 244)
        Me.Panel2.TabIndex = 6
        '
        'btnPayment
        '
        Me.btnPayment.Location = New System.Drawing.Point(55, 393)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.OverrideDefault.Back.Color1 = System.Drawing.Color.Gold
        Me.btnPayment.OverrideDefault.Back.Color2 = System.Drawing.Color.Gold
        Me.btnPayment.OverrideDefault.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnPayment.OverrideDefault.Border.Rounding = 10
        Me.btnPayment.Size = New System.Drawing.Size(200, 52)
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
        'RequestorTrackingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(972, 700)
        Me.Controls.Add(Me.btnPayment)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlTracking)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RequestorTrackingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RequestorTrackingForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents pnlTracking As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnPayment As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
