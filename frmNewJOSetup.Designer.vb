<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewJOSetup
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnByPass = New System.Windows.Forms.Button()
        Me.btnMainPage = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblFailCounter = New System.Windows.Forms.Label()
        Me.lblMPTimeCounter = New System.Windows.Forms.Label()
        Me.lblFPBTimeCounter = New System.Windows.Forms.Label()
        Me.lblMSTimeCounter = New System.Windows.Forms.Label()
        Me.btnMassPro = New System.Windows.Forms.Button()
        Me.btnFPB_StartStop = New System.Windows.Forms.Button()
        Me.btnMS_TAM_ONOFF = New System.Windows.Forms.Button()
        Me.btnMS_StartStop = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tmrMSTimer = New System.Windows.Forms.Timer(Me.components)
        Me.tmrIdleTime1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrFPBTimer = New System.Windows.Forms.Timer(Me.components)
        Me.tmrIdleTime2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMassProTimer = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRealTimeCheck = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(561, 438)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "*"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Moccasin
        Me.Panel1.Controls.Add(Me.btnByPass)
        Me.Panel1.Controls.Add(Me.btnMainPage)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(555, 413)
        Me.Panel1.TabIndex = 3
        '
        'btnByPass
        '
        Me.btnByPass.Location = New System.Drawing.Point(319, 15)
        Me.btnByPass.Name = "btnByPass"
        Me.btnByPass.Size = New System.Drawing.Size(144, 33)
        Me.btnByPass.TabIndex = 12
        Me.btnByPass.Text = "Buypass"
        Me.btnByPass.UseVisualStyleBackColor = True
        Me.btnByPass.Visible = False
        '
        'btnMainPage
        '
        Me.btnMainPage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMainPage.BackColor = System.Drawing.Color.Moccasin
        Me.btnMainPage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMainPage.FlatAppearance.BorderSize = 0
        Me.btnMainPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMainPage.IconChar = FontAwesome.Sharp.IconChar.HomeLg
        Me.btnMainPage.IconColor = System.Drawing.Color.Black
        Me.btnMainPage.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMainPage.IconSize = 60
        Me.btnMainPage.Location = New System.Drawing.Point(481, 8)
        Me.btnMainPage.Name = "btnMainPage"
        Me.btnMainPage.Size = New System.Drawing.Size(65, 56)
        Me.btnMainPage.TabIndex = 11
        Me.btnMainPage.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 36)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "NEW JOB ORDER SETUP"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblFailCounter)
        Me.GroupBox2.Controls.Add(Me.lblMPTimeCounter)
        Me.GroupBox2.Controls.Add(Me.lblFPBTimeCounter)
        Me.GroupBox2.Controls.Add(Me.lblMSTimeCounter)
        Me.GroupBox2.Controls.Add(Me.btnMassPro)
        Me.GroupBox2.Controls.Add(Me.btnFPB_StartStop)
        Me.GroupBox2.Controls.Add(Me.btnMS_TAM_ONOFF)
        Me.GroupBox2.Controls.Add(Me.btnMS_StartStop)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 66)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(538, 330)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'lblFailCounter
        '
        Me.lblFailCounter.BackColor = System.Drawing.Color.White
        Me.lblFailCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFailCounter.Location = New System.Drawing.Point(349, 127)
        Me.lblFailCounter.Name = "lblFailCounter"
        Me.lblFailCounter.Size = New System.Drawing.Size(37, 23)
        Me.lblFailCounter.TabIndex = 3
        Me.lblFailCounter.Text = "0"
        Me.lblFailCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMPTimeCounter
        '
        Me.lblMPTimeCounter.BackColor = System.Drawing.Color.White
        Me.lblMPTimeCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMPTimeCounter.Location = New System.Drawing.Point(414, 210)
        Me.lblMPTimeCounter.Name = "lblMPTimeCounter"
        Me.lblMPTimeCounter.Size = New System.Drawing.Size(60, 23)
        Me.lblMPTimeCounter.TabIndex = 3
        Me.lblMPTimeCounter.Text = "0.00"
        Me.lblMPTimeCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFPBTimeCounter
        '
        Me.lblFPBTimeCounter.BackColor = System.Drawing.Color.White
        Me.lblFPBTimeCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFPBTimeCounter.Location = New System.Drawing.Point(414, 126)
        Me.lblFPBTimeCounter.Name = "lblFPBTimeCounter"
        Me.lblFPBTimeCounter.Size = New System.Drawing.Size(60, 23)
        Me.lblFPBTimeCounter.TabIndex = 3
        Me.lblFPBTimeCounter.Text = "0.00"
        Me.lblFPBTimeCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMSTimeCounter
        '
        Me.lblMSTimeCounter.BackColor = System.Drawing.Color.White
        Me.lblMSTimeCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMSTimeCounter.Location = New System.Drawing.Point(414, 41)
        Me.lblMSTimeCounter.Name = "lblMSTimeCounter"
        Me.lblMSTimeCounter.Size = New System.Drawing.Size(60, 23)
        Me.lblMSTimeCounter.TabIndex = 3
        Me.lblMSTimeCounter.Text = "0.00"
        Me.lblMSTimeCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnMassPro
        '
        Me.btnMassPro.BackColor = System.Drawing.Color.Green
        Me.btnMassPro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMassPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMassPro.ForeColor = System.Drawing.Color.White
        Me.btnMassPro.Location = New System.Drawing.Point(87, 194)
        Me.btnMassPro.Name = "btnMassPro"
        Me.btnMassPro.Size = New System.Drawing.Size(305, 55)
        Me.btnMassPro.TabIndex = 2
        Me.btnMassPro.Text = "MASS PRO"
        Me.btnMassPro.UseVisualStyleBackColor = False
        '
        'btnFPB_StartStop
        '
        Me.btnFPB_StartStop.BackColor = System.Drawing.Color.DarkRed
        Me.btnFPB_StartStop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFPB_StartStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFPB_StartStop.ForeColor = System.Drawing.Color.White
        Me.btnFPB_StartStop.Location = New System.Drawing.Point(87, 114)
        Me.btnFPB_StartStop.Name = "btnFPB_StartStop"
        Me.btnFPB_StartStop.Size = New System.Drawing.Size(197, 55)
        Me.btnFPB_StartStop.TabIndex = 1
        Me.btnFPB_StartStop.Text = "SEND SAMPLE"
        Me.btnFPB_StartStop.UseVisualStyleBackColor = False
        '
        'btnMS_TAM_ONOFF
        '
        Me.btnMS_TAM_ONOFF.BackColor = System.Drawing.Color.Orange
        Me.btnMS_TAM_ONOFF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMS_TAM_ONOFF.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMS_TAM_ONOFF.ForeColor = System.Drawing.Color.White
        Me.btnMS_TAM_ONOFF.Location = New System.Drawing.Point(240, 28)
        Me.btnMS_TAM_ONOFF.Name = "btnMS_TAM_ONOFF"
        Me.btnMS_TAM_ONOFF.Size = New System.Drawing.Size(152, 55)
        Me.btnMS_TAM_ONOFF.TabIndex = 1
        Me.btnMS_TAM_ONOFF.Text = "TAM"
        Me.btnMS_TAM_ONOFF.UseVisualStyleBackColor = False
        '
        'btnMS_StartStop
        '
        Me.btnMS_StartStop.BackColor = System.Drawing.Color.DarkRed
        Me.btnMS_StartStop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMS_StartStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMS_StartStop.ForeColor = System.Drawing.Color.White
        Me.btnMS_StartStop.Location = New System.Drawing.Point(87, 28)
        Me.btnMS_StartStop.Name = "btnMS_StartStop"
        Me.btnMS_StartStop.Size = New System.Drawing.Size(152, 55)
        Me.btnMS_StartStop.TabIndex = 1
        Me.btnMS_StartStop.Text = "STOP"
        Me.btnMS_StartStop.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.HMI_PCBase.My.Resources.Resources.NewJOSetup_2
        Me.PictureBox1.Location = New System.Drawing.Point(3, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(530, 291)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'tmrMSTimer
        '
        Me.tmrMSTimer.Enabled = True
        Me.tmrMSTimer.Interval = 1000
        '
        'tmrIdleTime1
        '
        Me.tmrIdleTime1.Enabled = True
        Me.tmrIdleTime1.Interval = 1000
        '
        'tmrFPBTimer
        '
        Me.tmrFPBTimer.Enabled = True
        Me.tmrFPBTimer.Interval = 1000
        '
        'tmrIdleTime2
        '
        Me.tmrIdleTime2.Enabled = True
        Me.tmrIdleTime2.Interval = 1000
        '
        'tmrMassProTimer
        '
        Me.tmrMassProTimer.Enabled = True
        Me.tmrMassProTimer.Interval = 1000
        '
        'tmrRealTimeCheck
        '
        Me.tmrRealTimeCheck.Enabled = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(587, 464)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'frmNewJOSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 464)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmNewJOSetup"
        Me.Text = "frmNewJOSetup"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnMassPro As Button
    Friend WithEvents btnFPB_StartStop As Button
    Friend WithEvents btnMS_TAM_ONOFF As Button
    Friend WithEvents btnMS_StartStop As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblMPTimeCounter As Label
    Friend WithEvents lblFPBTimeCounter As Label
    Friend WithEvents lblMSTimeCounter As Label
    Friend WithEvents tmrMSTimer As Timer
    Friend WithEvents tmrIdleTime1 As Timer
    Friend WithEvents tmrFPBTimer As Timer
    Friend WithEvents tmrIdleTime2 As Timer
    Friend WithEvents tmrMassProTimer As Timer
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblFailCounter As Label
    Friend WithEvents btnMainPage As FontAwesome.Sharp.IconButton
    Friend WithEvents tmrRealTimeCheck As Timer
    Friend WithEvents btnByPass As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
