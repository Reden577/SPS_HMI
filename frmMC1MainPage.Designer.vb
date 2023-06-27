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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblJODetailsUN = New System.Windows.Forms.Label()
        Me.tmrDisplayON = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.picTestAutoMode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQAStoppage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStoppage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.pnlMC1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 74)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 33)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "USER ID:"
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.Location = New System.Drawing.Point(215, 74)
        Me.lblUserID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(25, 33)
        Me.lblUserID.TabIndex = 0
        Me.lblUserID.Text = "-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 134)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(285, 33)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "JOB ORDER CODE:"
        '
        'lblJobOrderCode
        '
        Me.lblJobOrderCode.AutoSize = True
        Me.lblJobOrderCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobOrderCode.Location = New System.Drawing.Point(387, 134)
        Me.lblJobOrderCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJobOrderCode.Name = "lblJobOrderCode"
        Me.lblJobOrderCode.Size = New System.Drawing.Size(25, 33)
        Me.lblJobOrderCode.TabIndex = 0
        Me.lblJobOrderCode.Text = "-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 194)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(254, 33)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "PLAN QUANTITY:"
        '
        'lblPlanQty
        '
        Me.lblPlanQty.AutoSize = True
        Me.lblPlanQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlanQty.Location = New System.Drawing.Point(355, 194)
        Me.lblPlanQty.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlanQty.Name = "lblPlanQty"
        Me.lblPlanQty.Size = New System.Drawing.Size(25, 33)
        Me.lblPlanQty.TabIndex = 0
        Me.lblPlanQty.Text = "-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(11, 255)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(293, 33)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "ACTUAL QUANTITY:"
        '
        'lblActualQty
        '
        Me.lblActualQty.AutoSize = True
        Me.lblActualQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActualQty.Location = New System.Drawing.Point(408, 255)
        Me.lblActualQty.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblActualQty.Name = "lblActualQty"
        Me.lblActualQty.Size = New System.Drawing.Size(25, 33)
        Me.lblActualQty.TabIndex = 0
        Me.lblActualQty.Text = "-"
        '
        'picTestAutoMode
        '
        Me.picTestAutoMode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picTestAutoMode.Image = Global.HMI_PCBase.My.Resources.Resources.test_auto_mode
        Me.picTestAutoMode.Location = New System.Drawing.Point(491, 320)
        Me.picTestAutoMode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picTestAutoMode.Name = "picTestAutoMode"
        Me.picTestAutoMode.Size = New System.Drawing.Size(232, 149)
        Me.picTestAutoMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTestAutoMode.TabIndex = 2
        Me.picTestAutoMode.TabStop = False
        '
        'picQAStoppage
        '
        Me.picQAStoppage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picQAStoppage.Image = Global.HMI_PCBase.My.Resources.Resources.QA_Stoppage
        Me.picQAStoppage.Location = New System.Drawing.Point(249, 320)
        Me.picQAStoppage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picQAStoppage.Name = "picQAStoppage"
        Me.picQAStoppage.Size = New System.Drawing.Size(232, 149)
        Me.picQAStoppage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQAStoppage.TabIndex = 2
        Me.picQAStoppage.TabStop = False
        '
        'picStoppage
        '
        Me.picStoppage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picStoppage.Image = Global.HMI_PCBase.My.Resources.Resources.Stoppage
        Me.picStoppage.Location = New System.Drawing.Point(8, 320)
        Me.picStoppage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picStoppage.Name = "picStoppage"
        Me.picStoppage.Size = New System.Drawing.Size(232, 149)
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
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.lblDisplayON)
        Me.GroupBox1.Controls.Add(Me.pnlMC1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 16)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(748, 539)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "*"
        '
        'lblDisplayON
        '
        Me.lblDisplayON.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDisplayON.BackColor = System.Drawing.Color.Transparent
        Me.lblDisplayON.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayON.Location = New System.Drawing.Point(612, 10)
        Me.lblDisplayON.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDisplayON.Name = "lblDisplayON"
        Me.lblDisplayON.Size = New System.Drawing.Size(128, 18)
        Me.lblDisplayON.TabIndex = 4
        Me.lblDisplayON.Text = "0"
        Me.lblDisplayON.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlMC1
        '
        Me.pnlMC1.Controls.Add(Me.Label2)
        Me.pnlMC1.Controls.Add(Me.Label4)
        Me.pnlMC1.Controls.Add(Me.picTestAutoMode)
        Me.pnlMC1.Controls.Add(Me.Label10)
        Me.pnlMC1.Controls.Add(Me.lblActualQty)
        Me.pnlMC1.Controls.Add(Me.Label6)
        Me.pnlMC1.Controls.Add(Me.picStoppage)
        Me.pnlMC1.Controls.Add(Me.lblJobOrderCode)
        Me.pnlMC1.Controls.Add(Me.lblJODetailsUN)
        Me.pnlMC1.Controls.Add(Me.lblUserID)
        Me.pnlMC1.Controls.Add(Me.picQAStoppage)
        Me.pnlMC1.Controls.Add(Me.Label8)
        Me.pnlMC1.Controls.Add(Me.lblPlanQty)
        Me.pnlMC1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMC1.Location = New System.Drawing.Point(4, 23)
        Me.pnlMC1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlMC1.Name = "pnlMC1"
        Me.pnlMC1.Size = New System.Drawing.Size(740, 512)
        Me.pnlMC1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 14)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 33)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "UN :"
        '
        'lblJODetailsUN
        '
        Me.lblJODetailsUN.AutoSize = True
        Me.lblJODetailsUN.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJODetailsUN.Location = New System.Drawing.Point(145, 14)
        Me.lblJODetailsUN.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJODetailsUN.Name = "lblJODetailsUN"
        Me.lblJODetailsUN.Size = New System.Drawing.Size(25, 33)
        Me.lblJODetailsUN.TabIndex = 0
        Me.lblJODetailsUN.Text = "-"
        '
        'tmrDisplayON
        '
        Me.tmrDisplayON.Enabled = True
        Me.tmrDisplayON.Interval = 1000
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(783, 571)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'frmMC1MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 571)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmMC1MainPage"
        Me.Text = "MainPage"
        CType(Me.picTestAutoMode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQAStoppage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStoppage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.pnlMC1.ResumeLayout(False)
        Me.pnlMC1.PerformLayout()
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
End Class
