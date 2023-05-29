<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMC1TestAutoMode
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pnlMC1 = New System.Windows.Forms.Panel()
        Me.lblRxPLCMC0 = New System.Windows.Forms.Label()
        Me.lblSTOP_RUNNING = New System.Windows.Forms.Label()
        Me.btnMainPage = New FontAwesome.Sharp.IconButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblAlloweShots = New System.Windows.Forms.Label()
        Me.btnTAM_startStop = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblElapsTimeMC1 = New System.Windows.Forms.Label()
        Me.lblStatMC1 = New System.Windows.Forms.Label()
        Me.tmrRealTimeCheck = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.pnlMC1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pnlMC1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(472, 386)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Machine 1"
        '
        'pnlMC1
        '
        Me.pnlMC1.BackColor = System.Drawing.Color.DarkOrange
        Me.pnlMC1.Controls.Add(Me.lblRxPLCMC0)
        Me.pnlMC1.Controls.Add(Me.lblSTOP_RUNNING)
        Me.pnlMC1.Controls.Add(Me.btnMainPage)
        Me.pnlMC1.Controls.Add(Me.Label3)
        Me.pnlMC1.Controls.Add(Me.lblAlloweShots)
        Me.pnlMC1.Controls.Add(Me.btnTAM_startStop)
        Me.pnlMC1.Controls.Add(Me.Label1)
        Me.pnlMC1.Controls.Add(Me.lblElapsTimeMC1)
        Me.pnlMC1.Controls.Add(Me.lblStatMC1)
        Me.pnlMC1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlMC1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMC1.ForeColor = System.Drawing.Color.Black
        Me.pnlMC1.Location = New System.Drawing.Point(3, 22)
        Me.pnlMC1.Name = "pnlMC1"
        Me.pnlMC1.Size = New System.Drawing.Size(466, 361)
        Me.pnlMC1.TabIndex = 0
        '
        'lblRxPLCMC0
        '
        Me.lblRxPLCMC0.AutoSize = True
        Me.lblRxPLCMC0.Location = New System.Drawing.Point(9, 50)
        Me.lblRxPLCMC0.Name = "lblRxPLCMC0"
        Me.lblRxPLCMC0.Size = New System.Drawing.Size(48, 20)
        Me.lblRxPLCMC0.TabIndex = 10
        Me.lblRxPLCMC0.Text = "False"
        Me.lblRxPLCMC0.Visible = False
        '
        'lblSTOP_RUNNING
        '
        Me.lblSTOP_RUNNING.AutoSize = True
        Me.lblSTOP_RUNNING.BackColor = System.Drawing.Color.Red
        Me.lblSTOP_RUNNING.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSTOP_RUNNING.ForeColor = System.Drawing.Color.White
        Me.lblSTOP_RUNNING.Location = New System.Drawing.Point(9, 10)
        Me.lblSTOP_RUNNING.Name = "lblSTOP_RUNNING"
        Me.lblSTOP_RUNNING.Size = New System.Drawing.Size(98, 33)
        Me.lblSTOP_RUNNING.TabIndex = 0
        Me.lblSTOP_RUNNING.Text = "STOP"
        '
        'btnMainPage
        '
        Me.btnMainPage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMainPage.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange
        Me.btnMainPage.FlatAppearance.BorderSize = 0
        Me.btnMainPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMainPage.IconChar = FontAwesome.Sharp.IconChar.HomeLg
        Me.btnMainPage.IconColor = System.Drawing.Color.Black
        Me.btnMainPage.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMainPage.IconSize = 60
        Me.btnMainPage.Location = New System.Drawing.Point(391, 17)
        Me.btnMainPage.Name = "btnMainPage"
        Me.btnMainPage.Size = New System.Drawing.Size(65, 56)
        Me.btnMainPage.TabIndex = 8
        Me.btnMainPage.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(141, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Allowed Shots:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAlloweShots
        '
        Me.lblAlloweShots.BackColor = System.Drawing.Color.Transparent
        Me.lblAlloweShots.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlloweShots.ForeColor = System.Drawing.Color.Black
        Me.lblAlloweShots.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblAlloweShots.Location = New System.Drawing.Point(295, 264)
        Me.lblAlloweShots.Name = "lblAlloweShots"
        Me.lblAlloweShots.Size = New System.Drawing.Size(37, 35)
        Me.lblAlloweShots.TabIndex = 8
        Me.lblAlloweShots.Text = "5"
        Me.lblAlloweShots.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnTAM_startStop
        '
        Me.btnTAM_startStop.BackColor = System.Drawing.Color.DarkRed
        Me.btnTAM_startStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTAM_startStop.ForeColor = System.Drawing.Color.White
        Me.btnTAM_startStop.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnTAM_startStop.IconColor = System.Drawing.Color.White
        Me.btnTAM_startStop.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnTAM_startStop.Location = New System.Drawing.Point(139, 203)
        Me.btnTAM_startStop.Name = "btnTAM_startStop"
        Me.btnTAM_startStop.Size = New System.Drawing.Size(184, 60)
        Me.btnTAM_startStop.TabIndex = 9
        Me.btnTAM_startStop.Text = "OFF"
        Me.btnTAM_startStop.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(7, 322)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 31)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Elapsed Time:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblElapsTimeMC1
        '
        Me.lblElapsTimeMC1.BackColor = System.Drawing.Color.Transparent
        Me.lblElapsTimeMC1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblElapsTimeMC1.ForeColor = System.Drawing.Color.Black
        Me.lblElapsTimeMC1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblElapsTimeMC1.Location = New System.Drawing.Point(188, 320)
        Me.lblElapsTimeMC1.Name = "lblElapsTimeMC1"
        Me.lblElapsTimeMC1.Size = New System.Drawing.Size(272, 35)
        Me.lblElapsTimeMC1.TabIndex = 8
        Me.lblElapsTimeMC1.Text = "0"
        Me.lblElapsTimeMC1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStatMC1
        '
        Me.lblStatMC1.BackColor = System.Drawing.Color.Transparent
        Me.lblStatMC1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblStatMC1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatMC1.ForeColor = System.Drawing.Color.Black
        Me.lblStatMC1.Location = New System.Drawing.Point(10, 50)
        Me.lblStatMC1.Name = "lblStatMC1"
        Me.lblStatMC1.Size = New System.Drawing.Size(446, 150)
        Me.lblStatMC1.TabIndex = 6
        Me.lblStatMC1.Text = "Test Auto" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mode"
        Me.lblStatMC1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrRealTimeCheck
        '
        Me.tmrRealTimeCheck.Enabled = True
        '
        'frmMC1TestAutoMode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 400)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMC1TestAutoMode"
        Me.Text = " "
        Me.GroupBox1.ResumeLayout(False)
        Me.pnlMC1.ResumeLayout(False)
        Me.pnlMC1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents pnlMC1 As Panel
    Friend WithEvents btnTAM_startStop As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents lblElapsTimeMC1 As Label
    Friend WithEvents lblStatMC1 As Label
    Friend WithEvents btnMainPage As FontAwesome.Sharp.IconButton
    Friend WithEvents Label3 As Label
    Friend WithEvents lblAlloweShots As Label
    Friend WithEvents tmrRealTimeCheck As Timer
    Friend WithEvents lblSTOP_RUNNING As Label
    Friend WithEvents lblRxPLCMC0 As Label
End Class
