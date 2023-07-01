<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DonateForm
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
        Me.pnlGridView = New System.Windows.Forms.Panel()
        Me.btnRefresh = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(0, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(970, 50)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "DONATE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlGridView
        '
        Me.pnlGridView.AutoScroll = True
        Me.pnlGridView.Location = New System.Drawing.Point(62, 100)
        Me.pnlGridView.Name = "pnlGridView"
        Me.pnlGridView.Size = New System.Drawing.Size(848, 535)
        Me.pnlGridView.TabIndex = 3
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(848, 18)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.OverrideDefault.Back.Color1 = System.Drawing.Color.Gold
        Me.btnRefresh.OverrideDefault.Back.Color2 = System.Drawing.Color.Gold
        Me.btnRefresh.OverrideDefault.Border.Color1 = System.Drawing.Color.Black
        Me.btnRefresh.OverrideDefault.Border.Color2 = System.Drawing.Color.Black
        Me.btnRefresh.OverrideDefault.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnRefresh.OverrideDefault.Border.Rounding = 15
        Me.btnRefresh.OverrideDefault.Border.Width = 2
        Me.btnRefresh.Size = New System.Drawing.Size(62, 61)
        Me.btnRefresh.StateCommon.Back.Color1 = System.Drawing.Color.Gold
        Me.btnRefresh.StateCommon.Back.Color2 = System.Drawing.Color.Gold
        Me.btnRefresh.StateCommon.Border.Color1 = System.Drawing.Color.Black
        Me.btnRefresh.StateCommon.Border.Color2 = System.Drawing.Color.Black
        Me.btnRefresh.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnRefresh.StateCommon.Border.Rounding = 15
        Me.btnRefresh.StateCommon.Border.Width = 2
        Me.btnRefresh.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.btnRefresh.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI Black", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.StateCommon.Content.ShortText.Image = Global.ShareBytes_Prototype.My.Resources.Resources._25429
        Me.btnRefresh.TabIndex = 7
        Me.btnRefresh.Values.Image = Global.ShareBytes_Prototype.My.Resources.Resources.refresh_page_option
        Me.btnRefresh.Values.Text = ""
        '
        'DonateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(972, 700)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.pnlGridView)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DonateForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DonateForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents pnlGridView As Panel
    Friend WithEvents btnRefresh As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
