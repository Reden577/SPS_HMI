<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMC1StoppageType
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
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.picMachineStoppage = New System.Windows.Forms.PictureBox()
        Me.picOperatorStoppage = New System.Windows.Forms.PictureBox()
        Me.lblDisplayON = New System.Windows.Forms.Label()
        Me.tmrDisplayON = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRealtimeCheck = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.pnlMC1.SuspendLayout()
        CType(Me.picMachineStoppage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOperatorStoppage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pnlMC1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(472, 386)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Machine 1"
        '
        'pnlMC1
        '
        Me.pnlMC1.Controls.Add(Me.IconButton1)
        Me.pnlMC1.Controls.Add(Me.Label4)
        Me.pnlMC1.Controls.Add(Me.picMachineStoppage)
        Me.pnlMC1.Controls.Add(Me.picOperatorStoppage)
        Me.pnlMC1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMC1.Location = New System.Drawing.Point(3, 22)
        Me.pnlMC1.Name = "pnlMC1"
        Me.pnlMC1.Size = New System.Drawing.Size(466, 361)
        Me.pnlMC1.TabIndex = 0
        '
        'IconButton1
        '
        Me.IconButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.HomeLg
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 60
        Me.IconButton1.Location = New System.Drawing.Point(392, 19)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(65, 56)
        Me.IconButton1.TabIndex = 3
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(250, 39)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Stoppage Type"
        '
        'picMachineStoppage
        '
        Me.picMachineStoppage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picMachineStoppage.Image = Global.HMI_PCBase.My.Resources.Resources.Operator_Stoppage
        Me.picMachineStoppage.Location = New System.Drawing.Point(243, 140)
        Me.picMachineStoppage.Name = "picMachineStoppage"
        Me.picMachineStoppage.Size = New System.Drawing.Size(214, 182)
        Me.picMachineStoppage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMachineStoppage.TabIndex = 2
        Me.picMachineStoppage.TabStop = False
        '
        'picOperatorStoppage
        '
        Me.picOperatorStoppage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picOperatorStoppage.Image = Global.HMI_PCBase.My.Resources.Resources.Machine_Stoppage
        Me.picOperatorStoppage.Location = New System.Drawing.Point(9, 140)
        Me.picOperatorStoppage.Name = "picOperatorStoppage"
        Me.picOperatorStoppage.Size = New System.Drawing.Size(214, 182)
        Me.picOperatorStoppage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOperatorStoppage.TabIndex = 2
        Me.picOperatorStoppage.TabStop = False
        '
        'lblDisplayON
        '
        Me.lblDisplayON.BackColor = System.Drawing.Color.Transparent
        Me.lblDisplayON.Location = New System.Drawing.Point(386, 0)
        Me.lblDisplayON.Name = "lblDisplayON"
        Me.lblDisplayON.Size = New System.Drawing.Size(96, 15)
        Me.lblDisplayON.TabIndex = 5
        Me.lblDisplayON.Text = "0"
        Me.lblDisplayON.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tmrDisplayON
        '
        Me.tmrDisplayON.Enabled = True
        Me.tmrDisplayON.Interval = 1000
        '
        'tmrRealtimeCheck
        '
        '
        'frmMC1StoppageType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 400)
        Me.Controls.Add(Me.lblDisplayON)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMC1StoppageType"
        Me.Text = "frmMC1StoppageType"
        Me.GroupBox1.ResumeLayout(False)
        Me.pnlMC1.ResumeLayout(False)
        Me.pnlMC1.PerformLayout()
        CType(Me.picMachineStoppage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOperatorStoppage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents pnlMC1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents picMachineStoppage As PictureBox
    Friend WithEvents picOperatorStoppage As PictureBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents lblDisplayON As Label
    Friend WithEvents tmrDisplayON As Timer
    Friend WithEvents tmrRealtimeCheck As Timer
End Class
