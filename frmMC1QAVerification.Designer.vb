<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMC1QAVerification
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pnlMC1 = New System.Windows.Forms.Panel()
        Me.btnMainPage = New FontAwesome.Sharp.IconButton()
        Me.btnFail = New FontAwesome.Sharp.IconButton()
        Me.btnPass = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFailedCounter = New System.Windows.Forms.Label()
        Me.lblElapsTimeMC1 = New System.Windows.Forms.Label()
        Me.lblFPB_label = New System.Windows.Forms.Label()
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
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Machine 1"
        '
        'pnlMC1
        '
        Me.pnlMC1.BackColor = System.Drawing.Color.Yellow
        Me.pnlMC1.Controls.Add(Me.btnMainPage)
        Me.pnlMC1.Controls.Add(Me.btnFail)
        Me.pnlMC1.Controls.Add(Me.btnPass)
        Me.pnlMC1.Controls.Add(Me.Label1)
        Me.pnlMC1.Controls.Add(Me.lblFailedCounter)
        Me.pnlMC1.Controls.Add(Me.lblElapsTimeMC1)
        Me.pnlMC1.Controls.Add(Me.lblFPB_label)
        Me.pnlMC1.Controls.Add(Me.lblStatMC1)
        Me.pnlMC1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlMC1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMC1.ForeColor = System.Drawing.Color.Black
        Me.pnlMC1.Location = New System.Drawing.Point(3, 22)
        Me.pnlMC1.Name = "pnlMC1"
        Me.pnlMC1.Size = New System.Drawing.Size(466, 361)
        Me.pnlMC1.TabIndex = 0
        '
        'btnMainPage
        '
        Me.btnMainPage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMainPage.FlatAppearance.BorderSize = 0
        Me.btnMainPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMainPage.IconChar = FontAwesome.Sharp.IconChar.HomeLg
        Me.btnMainPage.IconColor = System.Drawing.Color.Black
        Me.btnMainPage.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMainPage.IconSize = 60
        Me.btnMainPage.Location = New System.Drawing.Point(391, 15)
        Me.btnMainPage.Name = "btnMainPage"
        Me.btnMainPage.Size = New System.Drawing.Size(65, 56)
        Me.btnMainPage.TabIndex = 10
        Me.btnMainPage.UseVisualStyleBackColor = True
        '
        'btnFail
        '
        Me.btnFail.BackColor = System.Drawing.Color.DarkRed
        Me.btnFail.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFail.ForeColor = System.Drawing.Color.White
        Me.btnFail.IconChar = FontAwesome.Sharp.IconChar.Xmark
        Me.btnFail.IconColor = System.Drawing.Color.White
        Me.btnFail.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnFail.Location = New System.Drawing.Point(43, 210)
        Me.btnFail.Name = "btnFail"
        Me.btnFail.Size = New System.Drawing.Size(184, 60)
        Me.btnFail.TabIndex = 9
        Me.btnFail.Text = "Fail"
        Me.btnFail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFail.UseVisualStyleBackColor = False
        '
        'btnPass
        '
        Me.btnPass.BackColor = System.Drawing.Color.Green
        Me.btnPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPass.ForeColor = System.Drawing.Color.White
        Me.btnPass.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.btnPass.IconColor = System.Drawing.Color.White
        Me.btnPass.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPass.Location = New System.Drawing.Point(233, 210)
        Me.btnPass.Name = "btnPass"
        Me.btnPass.Size = New System.Drawing.Size(184, 60)
        Me.btnPass.TabIndex = 9
        Me.btnPass.Text = "Pass"
        Me.btnPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPass.UseVisualStyleBackColor = False
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
        'lblFailedCounter
        '
        Me.lblFailedCounter.BackColor = System.Drawing.Color.Transparent
        Me.lblFailedCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFailedCounter.ForeColor = System.Drawing.Color.Black
        Me.lblFailedCounter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblFailedCounter.Location = New System.Drawing.Point(43, 273)
        Me.lblFailedCounter.Name = "lblFailedCounter"
        Me.lblFailedCounter.Size = New System.Drawing.Size(184, 35)
        Me.lblFailedCounter.TabIndex = 8
        Me.lblFailedCounter.Text = "0"
        Me.lblFailedCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'lblFPB_label
        '
        Me.lblFPB_label.BackColor = System.Drawing.Color.Transparent
        Me.lblFPB_label.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblFPB_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFPB_label.ForeColor = System.Drawing.Color.Black
        Me.lblFPB_label.Location = New System.Drawing.Point(5, 5)
        Me.lblFPB_label.Name = "lblFPB_label"
        Me.lblFPB_label.Size = New System.Drawing.Size(311, 32)
        Me.lblFPB_label.TabIndex = 6
        Me.lblFPB_label.Text = "FIRST PCS BUY OFF"
        Me.lblFPB_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStatMC1
        '
        Me.lblStatMC1.BackColor = System.Drawing.Color.Transparent
        Me.lblStatMC1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblStatMC1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatMC1.ForeColor = System.Drawing.Color.Black
        Me.lblStatMC1.Location = New System.Drawing.Point(10, 15)
        Me.lblStatMC1.Name = "lblStatMC1"
        Me.lblStatMC1.Size = New System.Drawing.Size(446, 192)
        Me.lblStatMC1.TabIndex = 6
        Me.lblStatMC1.Text = "QA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Verification"
        Me.lblStatMC1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrRealTimeCheck
        '
        Me.tmrRealTimeCheck.Enabled = True
        '
        'frmMC1QAVerification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 400)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMC1QAVerification"
        Me.Text = "frmMC1QAVerification"
        Me.GroupBox1.ResumeLayout(False)
        Me.pnlMC1.ResumeLayout(False)
        Me.pnlMC1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents pnlMC1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblElapsTimeMC1 As Label
    Friend WithEvents lblStatMC1 As Label
    Friend WithEvents btnFail As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPass As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMainPage As FontAwesome.Sharp.IconButton
    Friend WithEvents lblFailedCounter As Label
    Friend WithEvents tmrRealTimeCheck As Timer
    Friend WithEvents lblFPB_label As Label
End Class
