﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InventoryForm
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
        Me.pnlInventory = New System.Windows.Forms.Panel()
        Me.btnAdd = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(2, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(970, 50)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "INVENTORY"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlInventory
        '
        Me.pnlInventory.AutoScroll = True
        Me.pnlInventory.Location = New System.Drawing.Point(63, 112)
        Me.pnlInventory.Name = "pnlInventory"
        Me.pnlInventory.Size = New System.Drawing.Size(858, 457)
        Me.pnlInventory.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(835, 589)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.OverrideDefault.Back.Color1 = System.Drawing.Color.Gold
        Me.btnAdd.OverrideDefault.Back.Color2 = System.Drawing.Color.Gold
        Me.btnAdd.OverrideDefault.Border.Color1 = System.Drawing.Color.Black
        Me.btnAdd.OverrideDefault.Border.Color2 = System.Drawing.Color.Black
        Me.btnAdd.OverrideDefault.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnAdd.OverrideDefault.Border.Rounding = 15
        Me.btnAdd.OverrideDefault.Border.Width = 2
        Me.btnAdd.Size = New System.Drawing.Size(73, 70)
        Me.btnAdd.StateCommon.Back.Color1 = System.Drawing.Color.Gold
        Me.btnAdd.StateCommon.Back.Color2 = System.Drawing.Color.Gold
        Me.btnAdd.StateCommon.Border.Color1 = System.Drawing.Color.Black
        Me.btnAdd.StateCommon.Border.Color2 = System.Drawing.Color.Black
        Me.btnAdd.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnAdd.StateCommon.Border.Rounding = 15
        Me.btnAdd.StateCommon.Border.Width = 2
        Me.btnAdd.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.btnAdd.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI Black", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Values.Text = "+"
        '
        'InventoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(972, 700)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.pnlInventory)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InventoryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InventoryForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents pnlInventory As Panel
    Friend WithEvents btnAdd As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
