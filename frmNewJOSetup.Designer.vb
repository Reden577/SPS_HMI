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
        Me.btnMassPro = New System.Windows.Forms.Button()
        Me.btnFPB_TAM_ONOFF = New System.Windows.Forms.Button()
        Me.btnFPB_StartStop = New System.Windows.Forms.Button()
        Me.btnMS_TAM_ONOFF = New System.Windows.Forms.Button()
        Me.btnMS_StartStop = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tmrMSTimer = New System.Windows.Forms.Timer(Me.components)
        Me.tmrIdleTime1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrFPBTimer = New System.Windows.Forms.Timer(Me.components)
        Me.tmrIdleTime2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMassProTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(472, 386)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Machine 1  (New JO Initial Setup)"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Moccasin
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnMassPro)
        Me.Panel1.Controls.Add(Me.btnFPB_TAM_ONOFF)
        Me.Panel1.Controls.Add(Me.btnFPB_StartStop)
        Me.Panel1.Controls.Add(Me.btnMS_TAM_ONOFF)
        Me.Panel1.Controls.Add(Me.btnMS_StartStop)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(466, 361)
        Me.Panel1.TabIndex = 3
        '
        'btnMassPro
        '
        Me.btnMassPro.Location = New System.Drawing.Point(72, 261)
        Me.btnMassPro.Name = "btnMassPro"
        Me.btnMassPro.Size = New System.Drawing.Size(263, 33)
        Me.btnMassPro.TabIndex = 2
        Me.btnMassPro.Text = "Mass Pro"
        Me.btnMassPro.UseVisualStyleBackColor = True
        '
        'btnFPB_TAM_ONOFF
        '
        Me.btnFPB_TAM_ONOFF.BackColor = System.Drawing.Color.Orange
        Me.btnFPB_TAM_ONOFF.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFPB_TAM_ONOFF.ForeColor = System.Drawing.Color.White
        Me.btnFPB_TAM_ONOFF.Location = New System.Drawing.Point(208, 127)
        Me.btnFPB_TAM_ONOFF.Name = "btnFPB_TAM_ONOFF"
        Me.btnFPB_TAM_ONOFF.Size = New System.Drawing.Size(141, 55)
        Me.btnFPB_TAM_ONOFF.TabIndex = 1
        Me.btnFPB_TAM_ONOFF.Text = "TAM OFF"
        Me.btnFPB_TAM_ONOFF.UseVisualStyleBackColor = False
        '
        'btnFPB_StartStop
        '
        Me.btnFPB_StartStop.BackColor = System.Drawing.Color.DarkRed
        Me.btnFPB_StartStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFPB_StartStop.ForeColor = System.Drawing.Color.White
        Me.btnFPB_StartStop.Location = New System.Drawing.Point(63, 127)
        Me.btnFPB_StartStop.Name = "btnFPB_StartStop"
        Me.btnFPB_StartStop.Size = New System.Drawing.Size(141, 55)
        Me.btnFPB_StartStop.TabIndex = 1
        Me.btnFPB_StartStop.Text = "START"
        Me.btnFPB_StartStop.UseVisualStyleBackColor = False
        '
        'btnMS_TAM_ONOFF
        '
        Me.btnMS_TAM_ONOFF.BackColor = System.Drawing.Color.Orange
        Me.btnMS_TAM_ONOFF.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMS_TAM_ONOFF.ForeColor = System.Drawing.Color.White
        Me.btnMS_TAM_ONOFF.Location = New System.Drawing.Point(208, 3)
        Me.btnMS_TAM_ONOFF.Name = "btnMS_TAM_ONOFF"
        Me.btnMS_TAM_ONOFF.Size = New System.Drawing.Size(141, 55)
        Me.btnMS_TAM_ONOFF.TabIndex = 1
        Me.btnMS_TAM_ONOFF.Text = "TAM OFF"
        Me.btnMS_TAM_ONOFF.UseVisualStyleBackColor = False
        '
        'btnMS_StartStop
        '
        Me.btnMS_StartStop.BackColor = System.Drawing.Color.DarkRed
        Me.btnMS_StartStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMS_StartStop.ForeColor = System.Drawing.Color.White
        Me.btnMS_StartStop.Location = New System.Drawing.Point(63, 3)
        Me.btnMS_StartStop.Name = "btnMS_StartStop"
        Me.btnMS_StartStop.Size = New System.Drawing.Size(141, 55)
        Me.btnMS_StartStop.TabIndex = 1
        Me.btnMS_StartStop.Text = "START"
        Me.btnMS_StartStop.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.HMI_PCBase.My.Resources.Resources.NewJOSetup
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(466, 361)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(354, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "0.00"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(354, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "0.00"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(354, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "0.00"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(354, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "0.00"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(354, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 23)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "0.00"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'frmNewJOSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 400)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmNewJOSetup"
        Me.Text = "frmNewJOSetup"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnMassPro As Button
    Friend WithEvents btnFPB_TAM_ONOFF As Button
    Friend WithEvents btnFPB_StartStop As Button
    Friend WithEvents btnMS_TAM_ONOFF As Button
    Friend WithEvents btnMS_StartStop As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tmrMSTimer As Timer
    Friend WithEvents tmrIdleTime1 As Timer
    Friend WithEvents tmrFPBTimer As Timer
    Friend WithEvents tmrIdleTime2 As Timer
    Friend WithEvents tmrMassProTimer As Timer
End Class
