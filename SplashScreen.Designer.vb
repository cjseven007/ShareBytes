<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
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
        Me.components = New System.ComponentModel.Container()
        Me.pnlBack = New System.Windows.Forms.Panel()
        Me.pnlProgress = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblSplashTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'pnlBack
        '
        Me.pnlBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlBack.Location = New System.Drawing.Point(0, 484)
        Me.pnlBack.Name = "pnlBack"
        Me.pnlBack.Size = New System.Drawing.Size(847, 20)
        Me.pnlBack.TabIndex = 0
        '
        'pnlProgress
        '
        Me.pnlProgress.BackColor = System.Drawing.Color.Gold
        Me.pnlProgress.Location = New System.Drawing.Point(0, 484)
        Me.pnlProgress.Name = "pnlProgress"
        Me.pnlProgress.Size = New System.Drawing.Size(29, 20)
        Me.pnlProgress.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'lblSplashTitle
        '
        Me.lblSplashTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSplashTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSplashTitle.Font = New System.Drawing.Font("Segoe UI Black", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSplashTitle.ForeColor = System.Drawing.Color.Gold
        Me.lblSplashTitle.Location = New System.Drawing.Point(0, 212)
        Me.lblSplashTitle.Name = "lblSplashTitle"
        Me.lblSplashTitle.Size = New System.Drawing.Size(847, 56)
        Me.lblSplashTitle.TabIndex = 2
        Me.lblSplashTitle.Text = """ FOOD IS THE MOST SINCERE LOVE. """
        Me.lblSplashTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ShareBytes_Prototype.My.Resources.Resources.splashDarken
        Me.ClientSize = New System.Drawing.Size(847, 503)
        Me.Controls.Add(Me.lblSplashTitle)
        Me.Controls.Add(Me.pnlProgress)
        Me.Controls.Add(Me.pnlBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SplashScreen"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBack As Panel
    Friend WithEvents pnlProgress As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblSplashTitle As Label
End Class
