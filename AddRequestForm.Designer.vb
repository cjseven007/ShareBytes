<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddRequestForm
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
        Me.txtRTitle = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtRDescription = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.nudRPax = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddRequest = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRLocation = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnExit = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnSelectLocation = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        CType(Me.nudRPax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtRTitle
        '
        Me.txtRTitle.Location = New System.Drawing.Point(71, 101)
        Me.txtRTitle.Name = "txtRTitle"
        Me.txtRTitle.Size = New System.Drawing.Size(457, 40)
        Me.txtRTitle.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtRTitle.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.txtRTitle.StateCommon.Border.Color2 = System.Drawing.Color.Gray
        Me.txtRTitle.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtRTitle.StateCommon.Border.Rounding = 10
        Me.txtRTitle.StateCommon.Content.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRTitle.TabIndex = 6
        '
        'txtRDescription
        '
        Me.txtRDescription.Location = New System.Drawing.Point(71, 192)
        Me.txtRDescription.Multiline = True
        Me.txtRDescription.Name = "txtRDescription"
        Me.txtRDescription.Size = New System.Drawing.Size(457, 101)
        Me.txtRDescription.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtRDescription.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.txtRDescription.StateCommon.Border.Color2 = System.Drawing.Color.Gray
        Me.txtRDescription.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtRDescription.StateCommon.Border.Rounding = 10
        Me.txtRDescription.StateCommon.Content.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRDescription.TabIndex = 7
        '
        'nudRPax
        '
        Me.nudRPax.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudRPax.Location = New System.Drawing.Point(71, 494)
        Me.nudRPax.Name = "nudRPax"
        Me.nudRPax.Size = New System.Drawing.Size(138, 30)
        Me.nudRPax.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(67, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Title"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(175, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 38)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Make A Request"
        '
        'btnAddRequest
        '
        Me.btnAddRequest.Location = New System.Drawing.Point(224, 563)
        Me.btnAddRequest.Name = "btnAddRequest"
        Me.btnAddRequest.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAddRequest.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAddRequest.Size = New System.Drawing.Size(147, 51)
        Me.btnAddRequest.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAddRequest.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAddRequest.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnAddRequest.StateCommon.Border.Rounding = 15
        Me.btnAddRequest.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddRequest.TabIndex = 13
        Me.btnAddRequest.Values.Text = "Request"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(67, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 23)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Description"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(67, 314)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 23)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Location"
        '
        'txtRLocation
        '
        Me.txtRLocation.Location = New System.Drawing.Point(71, 340)
        Me.txtRLocation.Multiline = True
        Me.txtRLocation.Name = "txtRLocation"
        Me.txtRLocation.Size = New System.Drawing.Size(457, 96)
        Me.txtRLocation.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtRLocation.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.txtRLocation.StateCommon.Border.Color2 = System.Drawing.Color.Gray
        Me.txtRLocation.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtRLocation.StateCommon.Border.Rounding = 10
        Me.txtRLocation.StateCommon.Content.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRLocation.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(67, 468)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 23)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Pax"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Location = New System.Drawing.Point(565, -1)
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
        Me.btnExit.TabIndex = 18
        Me.btnExit.Values.Text = "X"
        '
        'btnSelectLocation
        '
        Me.btnSelectLocation.Location = New System.Drawing.Point(388, 442)
        Me.btnSelectLocation.Name = "btnSelectLocation"
        Me.btnSelectLocation.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSelectLocation.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSelectLocation.OverrideDefault.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnSelectLocation.OverrideDefault.Border.Rounding = 10
        Me.btnSelectLocation.Size = New System.Drawing.Size(140, 37)
        Me.btnSelectLocation.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSelectLocation.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSelectLocation.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSelectLocation.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSelectLocation.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnSelectLocation.StateCommon.Border.Rounding = 10
        Me.btnSelectLocation.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectLocation.TabIndex = 19
        Me.btnSelectLocation.Values.Text = "Select Location"
        '
        'AddRequestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(594, 654)
        Me.Controls.Add(Me.btnSelectLocation)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtRLocation)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAddRequest)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nudRPax)
        Me.Controls.Add(Me.txtRDescription)
        Me.Controls.Add(Me.txtRTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddRequestForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddRequestForm"
        CType(Me.nudRPax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtRTitle As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtRDescription As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents nudRPax As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddRequest As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRLocation As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnExit As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnSelectLocation As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
