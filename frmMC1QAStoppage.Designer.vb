<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMC1QAStoppage
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
        Me.lblDisplayON = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pnlMC1 = New System.Windows.Forms.Panel()
        Me.lstCmeasure = New System.Windows.Forms.ListBox()
        Me.lstStoppage = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCmeasure = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnStoppage = New FontAwesome.Sharp.IconButton()
        Me.txtCMeasure = New System.Windows.Forms.TextBox()
        Me.txtStoppage = New System.Windows.Forms.TextBox()
        Me.grpStopDetails = New System.Windows.Forms.GroupBox()
        Me.cboCountermeasure = New System.Windows.Forms.ComboBox()
        Me.cboStoppage = New System.Windows.Forms.ComboBox()
        Me.btnEditDetails = New FontAwesome.Sharp.IconButton()
        Me.btnClear = New FontAwesome.Sharp.IconButton()
        Me.btnSendSample = New FontAwesome.Sharp.IconButton()
        Me.btnMainPage = New FontAwesome.Sharp.IconButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tmrRealTimeCheck = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRstFailFlag = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1.SuspendLayout()
        Me.pnlMC1.SuspendLayout()
        Me.grpStopDetails.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDisplayON
        '
        Me.lblDisplayON.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDisplayON.BackColor = System.Drawing.Color.Transparent
        Me.lblDisplayON.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayON.Location = New System.Drawing.Point(523, 12)
        Me.lblDisplayON.Name = "lblDisplayON"
        Me.lblDisplayON.Size = New System.Drawing.Size(96, 15)
        Me.lblDisplayON.TabIndex = 9
        Me.lblDisplayON.Text = "0"
        Me.lblDisplayON.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblDisplayON)
        Me.GroupBox1.Controls.Add(Me.pnlMC1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(625, 1088)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "*"
        '
        'pnlMC1
        '
        Me.pnlMC1.Controls.Add(Me.lstCmeasure)
        Me.pnlMC1.Controls.Add(Me.lstStoppage)
        Me.pnlMC1.Controls.Add(Me.Label2)
        Me.pnlMC1.Controls.Add(Me.btnCmeasure)
        Me.pnlMC1.Controls.Add(Me.Label1)
        Me.pnlMC1.Controls.Add(Me.btnStoppage)
        Me.pnlMC1.Controls.Add(Me.txtCMeasure)
        Me.pnlMC1.Controls.Add(Me.txtStoppage)
        Me.pnlMC1.Controls.Add(Me.grpStopDetails)
        Me.pnlMC1.Controls.Add(Me.btnEditDetails)
        Me.pnlMC1.Controls.Add(Me.btnClear)
        Me.pnlMC1.Controls.Add(Me.btnSendSample)
        Me.pnlMC1.Controls.Add(Me.btnMainPage)
        Me.pnlMC1.Controls.Add(Me.Label4)
        Me.pnlMC1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMC1.Location = New System.Drawing.Point(3, 22)
        Me.pnlMC1.Name = "pnlMC1"
        Me.pnlMC1.Size = New System.Drawing.Size(619, 1063)
        Me.pnlMC1.TabIndex = 0
        '
        'lstCmeasure
        '
        Me.lstCmeasure.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstCmeasure.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCmeasure.FormattingEnabled = True
        Me.lstCmeasure.ItemHeight = 33
        Me.lstCmeasure.Location = New System.Drawing.Point(9, 363)
        Me.lstCmeasure.Name = "lstCmeasure"
        Me.lstCmeasure.Size = New System.Drawing.Size(501, 334)
        Me.lstCmeasure.TabIndex = 9
        '
        'lstStoppage
        '
        Me.lstStoppage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstStoppage.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstStoppage.FormattingEnabled = True
        Me.lstStoppage.ItemHeight = 33
        Me.lstStoppage.Location = New System.Drawing.Point(9, 231)
        Me.lstStoppage.Name = "lstStoppage"
        Me.lstStoppage.Size = New System.Drawing.Size(501, 664)
        Me.lstStoppage.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 281)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 33)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Countermeasure:"
        '
        'btnCmeasure
        '
        Me.btnCmeasure.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCmeasure.IconChar = FontAwesome.Sharp.IconChar.Ellipsis
        Me.btnCmeasure.IconColor = System.Drawing.Color.Black
        Me.btnCmeasure.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCmeasure.IconSize = 40
        Me.btnCmeasure.Location = New System.Drawing.Point(511, 317)
        Me.btnCmeasure.Name = "btnCmeasure"
        Me.btnCmeasure.Size = New System.Drawing.Size(100, 40)
        Me.btnCmeasure.TabIndex = 8
        Me.btnCmeasure.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Stoppage Details:"
        '
        'btnStoppage
        '
        Me.btnStoppage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStoppage.IconChar = FontAwesome.Sharp.IconChar.Ellipsis
        Me.btnStoppage.IconColor = System.Drawing.Color.Black
        Me.btnStoppage.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnStoppage.IconSize = 40
        Me.btnStoppage.Location = New System.Drawing.Point(511, 185)
        Me.btnStoppage.Name = "btnStoppage"
        Me.btnStoppage.Size = New System.Drawing.Size(100, 40)
        Me.btnStoppage.TabIndex = 8
        Me.btnStoppage.UseVisualStyleBackColor = True
        '
        'txtCMeasure
        '
        Me.txtCMeasure.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCMeasure.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCMeasure.Location = New System.Drawing.Point(9, 317)
        Me.txtCMeasure.Name = "txtCMeasure"
        Me.txtCMeasure.Size = New System.Drawing.Size(502, 40)
        Me.txtCMeasure.TabIndex = 7
        '
        'txtStoppage
        '
        Me.txtStoppage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStoppage.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStoppage.Location = New System.Drawing.Point(9, 185)
        Me.txtStoppage.Name = "txtStoppage"
        Me.txtStoppage.Size = New System.Drawing.Size(502, 40)
        Me.txtStoppage.TabIndex = 7
        '
        'grpStopDetails
        '
        Me.grpStopDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpStopDetails.Controls.Add(Me.cboCountermeasure)
        Me.grpStopDetails.Controls.Add(Me.cboStoppage)
        Me.grpStopDetails.Location = New System.Drawing.Point(3, 619)
        Me.grpStopDetails.Name = "grpStopDetails"
        Me.grpStopDetails.Size = New System.Drawing.Size(613, 291)
        Me.grpStopDetails.TabIndex = 6
        Me.grpStopDetails.TabStop = False
        Me.grpStopDetails.Visible = False
        '
        'cboCountermeasure
        '
        Me.cboCountermeasure.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCountermeasure.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCountermeasure.FormattingEnabled = True
        Me.cboCountermeasure.Location = New System.Drawing.Point(5, 186)
        Me.cboCountermeasure.Name = "cboCountermeasure"
        Me.cboCountermeasure.Size = New System.Drawing.Size(597, 41)
        Me.cboCountermeasure.TabIndex = 2
        '
        'cboStoppage
        '
        Me.cboStoppage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboStoppage.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStoppage.FormattingEnabled = True
        Me.cboStoppage.Location = New System.Drawing.Point(5, 61)
        Me.cboStoppage.Name = "cboStoppage"
        Me.cboStoppage.Size = New System.Drawing.Size(597, 41)
        Me.cboStoppage.TabIndex = 1
        '
        'btnEditDetails
        '
        Me.btnEditDetails.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditDetails.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnEditDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditDetails.IconChar = FontAwesome.Sharp.IconChar.Pen
        Me.btnEditDetails.IconColor = System.Drawing.Color.Black
        Me.btnEditDetails.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEditDetails.IconSize = 40
        Me.btnEditDetails.Location = New System.Drawing.Point(411, 925)
        Me.btnEditDetails.Name = "btnEditDetails"
        Me.btnEditDetails.Size = New System.Drawing.Size(199, 58)
        Me.btnEditDetails.TabIndex = 3
        Me.btnEditDetails.Text = "EDIT"
        Me.btnEditDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditDetails.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.IconChar = FontAwesome.Sharp.IconChar.Eraser
        Me.btnClear.IconColor = System.Drawing.Color.Black
        Me.btnClear.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClear.IconSize = 40
        Me.btnClear.Location = New System.Drawing.Point(162, 992)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(199, 58)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnSendSample
        '
        Me.btnSendSample.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSendSample.BackColor = System.Drawing.Color.Yellow
        Me.btnSendSample.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSendSample.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSendSample.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnSendSample.IconColor = System.Drawing.Color.Black
        Me.btnSendSample.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSendSample.IconSize = 40
        Me.btnSendSample.Location = New System.Drawing.Point(367, 992)
        Me.btnSendSample.Name = "btnSendSample"
        Me.btnSendSample.Size = New System.Drawing.Size(243, 58)
        Me.btnSendSample.TabIndex = 5
        Me.btnSendSample.Text = "Send Sample"
        Me.btnSendSample.UseVisualStyleBackColor = False
        '
        'btnMainPage
        '
        Me.btnMainPage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMainPage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMainPage.FlatAppearance.BorderSize = 0
        Me.btnMainPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMainPage.IconChar = FontAwesome.Sharp.IconChar.HomeLg
        Me.btnMainPage.IconColor = System.Drawing.Color.Black
        Me.btnMainPage.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMainPage.IconSize = 60
        Me.btnMainPage.Location = New System.Drawing.Point(545, 19)
        Me.btnMainPage.Name = "btnMainPage"
        Me.btnMainPage.Size = New System.Drawing.Size(65, 56)
        Me.btnMainPage.TabIndex = 0
        Me.btnMainPage.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(249, 37)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "QA STOPPAGE"
        '
        'tmrRealTimeCheck
        '
        Me.tmrRealTimeCheck.Enabled = True
        '
        'tmrRstFailFlag
        '
        Me.tmrRstFailFlag.Enabled = True
        Me.tmrRstFailFlag.Interval = 2000
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(651, 1114)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'frmMC1QAStoppage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(651, 1114)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMC1QAStoppage"
        Me.Text = "frmQAStoppage"
        Me.GroupBox1.ResumeLayout(False)
        Me.pnlMC1.ResumeLayout(False)
        Me.pnlMC1.PerformLayout()
        Me.grpStopDetails.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblDisplayON As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents pnlMC1 As Panel
    Friend WithEvents btnClear As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSendSample As FontAwesome.Sharp.IconButton
    Friend WithEvents cboStoppage As ComboBox
    Friend WithEvents btnMainPage As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboCountermeasure As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tmrRealTimeCheck As Timer
    Friend WithEvents tmrRstFailFlag As Timer
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnEditDetails As FontAwesome.Sharp.IconButton
    Friend WithEvents grpStopDetails As GroupBox
    Friend WithEvents txtCMeasure As TextBox
    Friend WithEvents txtStoppage As TextBox
    Friend WithEvents btnStoppage As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCmeasure As FontAwesome.Sharp.IconButton
    Friend WithEvents lstCmeasure As ListBox
    Friend WithEvents lstStoppage As ListBox
End Class
