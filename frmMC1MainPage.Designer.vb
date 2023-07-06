<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMC1MainPage
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblJobOrderCode = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblPlanQty = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblActualQty = New System.Windows.Forms.Label()
        Me.picTestAutoMode = New System.Windows.Forms.PictureBox()
        Me.picQAStoppage = New System.Windows.Forms.PictureBox()
        Me.picStoppage = New System.Windows.Forms.PictureBox()
        Me.tmrRealTimeCheck = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblDisplayON = New System.Windows.Forms.Label()
        Me.pnlMC1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblJODetailsUN = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tmrDisplayON = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.picTestAutoMode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQAStoppage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStoppage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.pnlMC1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 33)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "User ID:"
        '
        'lblUserID
        '
        Me.lblUserID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.Location = New System.Drawing.Point(5, 4)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(27, 37)
        Me.lblUserID.TabIndex = 0
        Me.lblUserID.Text = "-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 305)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(230, 33)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Job Order Code:"
        '
        'lblJobOrderCode
        '
        Me.lblJobOrderCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblJobOrderCode.AutoSize = True
        Me.lblJobOrderCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobOrderCode.Location = New System.Drawing.Point(5, 4)
        Me.lblJobOrderCode.Name = "lblJobOrderCode"
        Me.lblJobOrderCode.Size = New System.Drawing.Size(27, 37)
        Me.lblJobOrderCode.TabIndex = 0
        Me.lblJobOrderCode.Text = "-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 406)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(198, 33)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Plan Quantity:"
        '
        'lblPlanQty
        '
        Me.lblPlanQty.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPlanQty.AutoSize = True
        Me.lblPlanQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlanQty.Location = New System.Drawing.Point(5, 4)
        Me.lblPlanQty.Name = "lblPlanQty"
        Me.lblPlanQty.Size = New System.Drawing.Size(27, 37)
        Me.lblPlanQty.TabIndex = 0
        Me.lblPlanQty.Text = "-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 511)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(221, 33)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Actual Quantity:"
        '
        'lblActualQty
        '
        Me.lblActualQty.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblActualQty.AutoSize = True
        Me.lblActualQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActualQty.Location = New System.Drawing.Point(5, 4)
        Me.lblActualQty.Name = "lblActualQty"
        Me.lblActualQty.Size = New System.Drawing.Size(27, 37)
        Me.lblActualQty.TabIndex = 0
        Me.lblActualQty.Text = "-"
        '
        'picTestAutoMode
        '
        Me.picTestAutoMode.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.picTestAutoMode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picTestAutoMode.Image = Global.HMI_PCBase.My.Resources.Resources.test_auto_mode
        Me.picTestAutoMode.Location = New System.Drawing.Point(417, 913)
        Me.picTestAutoMode.Name = "picTestAutoMode"
        Me.picTestAutoMode.Size = New System.Drawing.Size(196, 121)
        Me.picTestAutoMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTestAutoMode.TabIndex = 2
        Me.picTestAutoMode.TabStop = False
        '
        'picQAStoppage
        '
        Me.picQAStoppage.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.picQAStoppage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picQAStoppage.Image = Global.HMI_PCBase.My.Resources.Resources.QA_Stoppage
        Me.picQAStoppage.Location = New System.Drawing.Point(211, 913)
        Me.picQAStoppage.Name = "picQAStoppage"
        Me.picQAStoppage.Size = New System.Drawing.Size(196, 121)
        Me.picQAStoppage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQAStoppage.TabIndex = 2
        Me.picQAStoppage.TabStop = False
        '
        'picStoppage
        '
        Me.picStoppage.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.picStoppage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picStoppage.Image = Global.HMI_PCBase.My.Resources.Resources.Stoppage
        Me.picStoppage.Location = New System.Drawing.Point(6, 913)
        Me.picStoppage.Name = "picStoppage"
        Me.picStoppage.Size = New System.Drawing.Size(196, 121)
        Me.picStoppage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStoppage.TabIndex = 2
        Me.picStoppage.TabStop = False
        '
        'tmrRealTimeCheck
        '
        Me.tmrRealTimeCheck.Enabled = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lblDisplayON)
        Me.GroupBox1.Controls.Add(Me.pnlMC1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(625, 1088)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "*"
        '
        'lblDisplayON
        '
        Me.lblDisplayON.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDisplayON.BackColor = System.Drawing.Color.Transparent
        Me.lblDisplayON.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayON.Location = New System.Drawing.Point(523, 8)
        Me.lblDisplayON.Name = "lblDisplayON"
        Me.lblDisplayON.Size = New System.Drawing.Size(96, 15)
        Me.lblDisplayON.TabIndex = 4
        Me.lblDisplayON.Text = "0"
        Me.lblDisplayON.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlMC1
        '
        Me.pnlMC1.Controls.Add(Me.Panel5)
        Me.pnlMC1.Controls.Add(Me.Panel4)
        Me.pnlMC1.Controls.Add(Me.Panel3)
        Me.pnlMC1.Controls.Add(Me.Panel2)
        Me.pnlMC1.Controls.Add(Me.Panel1)
        Me.pnlMC1.Controls.Add(Me.Label1)
        Me.pnlMC1.Controls.Add(Me.Label2)
        Me.pnlMC1.Controls.Add(Me.Label4)
        Me.pnlMC1.Controls.Add(Me.picTestAutoMode)
        Me.pnlMC1.Controls.Add(Me.Label10)
        Me.pnlMC1.Controls.Add(Me.Label6)
        Me.pnlMC1.Controls.Add(Me.picStoppage)
        Me.pnlMC1.Controls.Add(Me.picQAStoppage)
        Me.pnlMC1.Controls.Add(Me.Label8)
        Me.pnlMC1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMC1.Location = New System.Drawing.Point(3, 22)
        Me.pnlMC1.Name = "pnlMC1"
        Me.pnlMC1.Size = New System.Drawing.Size(619, 1063)
        Me.pnlMC1.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.lblActualQty)
        Me.Panel5.Location = New System.Drawing.Point(14, 544)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(591, 47)
        Me.Panel5.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.lblPlanQty)
        Me.Panel4.Location = New System.Drawing.Point(14, 439)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(591, 47)
        Me.Panel4.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lblJobOrderCode)
        Me.Panel3.Location = New System.Drawing.Point(14, 337)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(591, 47)
        Me.Panel3.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblUserID)
        Me.Panel2.Location = New System.Drawing.Point(14, 235)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(591, 47)
        Me.Panel2.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblJODetailsUN)
        Me.Panel1.Location = New System.Drawing.Point(14, 138)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(591, 47)
        Me.Panel1.TabIndex = 3
        '
        'lblJODetailsUN
        '
        Me.lblJODetailsUN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblJODetailsUN.AutoSize = True
        Me.lblJODetailsUN.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJODetailsUN.Location = New System.Drawing.Point(5, 4)
        Me.lblJODetailsUN.Name = "lblJODetailsUN"
        Me.lblJODetailsUN.Size = New System.Drawing.Size(27, 37)
        Me.lblJODetailsUN.TabIndex = 0
        Me.lblJODetailsUN.Text = "-"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(373, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PRODUCTION DETAILS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 33)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "User Name :"
        '
        'tmrDisplayON
        '
        Me.tmrDisplayON.Enabled = True
        Me.tmrDisplayON.Interval = 1000
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.CadetBlue
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(651, 1114)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'frmMC1MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(651, 1114)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMC1MainPage"
        Me.Text = "MainPage"
        CType(Me.picTestAutoMode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQAStoppage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStoppage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.pnlMC1.ResumeLayout(False)
        Me.pnlMC1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents lblUserID As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblJobOrderCode As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblPlanQty As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblActualQty As Label
    Friend WithEvents picStoppage As PictureBox
    Friend WithEvents picQAStoppage As PictureBox
    Friend WithEvents picTestAutoMode As PictureBox
    Friend WithEvents tmrRealTimeCheck As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents pnlMC1 As Panel
    Friend WithEvents tmrDisplayON As Timer
    Friend WithEvents lblDisplayON As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblJODetailsUN As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
End Class
