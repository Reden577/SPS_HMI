<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblComCheck = New System.Windows.Forms.Label()
        Me.tmrComCheck = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRealTimeCheck = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTAMCounterSet = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboMachineName = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSQLPath = New System.Windows.Forms.TextBox()
        Me.btnSaveSettings = New FontAwesome.Sharp.IconButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(89, 49)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(101, 20)
        Me.txtIP.TabIndex = 4
        Me.txtIP.Text = "169.254.190.100"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "IP Address:"
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.Location = New System.Drawing.Point(8, 79)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(29, 13)
        Me.lblPort.TabIndex = 2
        Me.lblPort.Text = "Port:"
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(89, 75)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(101, 20)
        Me.txtPort.TabIndex = 4
        Me.txtPort.Text = "502"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(618, 48)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(77, 59)
        Me.btnConnect.TabIndex = 5
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        Me.btnConnect.Visible = False
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Location = New System.Drawing.Point(701, 48)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(77, 59)
        Me.btnDisconnect.TabIndex = 5
        Me.btnDisconnect.Text = "Disconnect"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        Me.btnDisconnect.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(508, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Connection Status:"
        Me.Label5.Visible = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(611, 113)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(76, 13)
        Me.lblStatus.TabIndex = 2
        Me.lblStatus.Text = "Disconnected!"
        Me.lblStatus.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(507, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "ComCheck:"
        Me.Label7.Visible = False
        '
        'lblComCheck
        '
        Me.lblComCheck.AutoSize = True
        Me.lblComCheck.Location = New System.Drawing.Point(568, 136)
        Me.lblComCheck.Name = "lblComCheck"
        Me.lblComCheck.Size = New System.Drawing.Size(13, 13)
        Me.lblComCheck.TabIndex = 2
        Me.lblComCheck.Text = "0"
        Me.lblComCheck.Visible = False
        '
        'tmrComCheck
        '
        Me.tmrComCheck.Enabled = True
        Me.tmrComCheck.Interval = 1000
        '
        'tmrRealTimeCheck
        '
        Me.tmrRealTimeCheck.Enabled = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "TAM Counter Set:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTAMCounterSet
        '
        Me.txtTAMCounterSet.Location = New System.Drawing.Point(111, 128)
        Me.txtTAMCounterSet.Name = "txtTAMCounterSet"
        Me.txtTAMCounterSet.Size = New System.Drawing.Size(79, 20)
        Me.txtTAMCounterSet.TabIndex = 4
        Me.txtTAMCounterSet.Text = "5"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Machine No:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboMachineName
        '
        Me.cboMachineName.FormattingEnabled = True
        Me.cboMachineName.Items.AddRange(New Object() {"MC1", "MC2", "MC3", "MC4", "MC5", "MC6", "MC7", "MC8", "MC9", "MC10", "MC11", "MC12", "MC13", "MC14", "MC15", "MC16", "MC17", "MC18", "MC19"})
        Me.cboMachineName.Location = New System.Drawing.Point(89, 101)
        Me.cboMachineName.Name = "cboMachineName"
        Me.cboMachineName.Size = New System.Drawing.Size(101, 21)
        Me.cboMachineName.TabIndex = 6
        Me.cboMachineName.Text = "MC1"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(5, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "SQLPath:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSQLPath
        '
        Me.txtSQLPath.Location = New System.Drawing.Point(57, 23)
        Me.txtSQLPath.Name = "txtSQLPath"
        Me.txtSQLPath.Size = New System.Drawing.Size(386, 20)
        Me.txtSQLPath.TabIndex = 4
        Me.txtSQLPath.Text = "Data Source=DESKTOP-4OGTIB2\DIAVIEWSQL;Initial Catalog=SPS;Persist Security Info=" &
    "True;User ID=sa;Password=doc577isin"
        '
        'btnSaveSettings
        '
        Me.btnSaveSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveSettings.IconChar = FontAwesome.Sharp.IconChar.Database
        Me.btnSaveSettings.IconColor = System.Drawing.Color.Black
        Me.btnSaveSettings.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSaveSettings.IconSize = 40
        Me.btnSaveSettings.Location = New System.Drawing.Point(305, 216)
        Me.btnSaveSettings.Name = "btnSaveSettings"
        Me.btnSaveSettings.Size = New System.Drawing.Size(160, 48)
        Me.btnSaveSettings.TabIndex = 7
        Me.btnSaveSettings.Text = "Save"
        Me.btnSaveSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaveSettings.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboMachineName)
        Me.GroupBox1.Controls.Add(Me.txtSQLPath)
        Me.GroupBox1.Controls.Add(Me.txtTAMCounterSet)
        Me.GroupBox1.Controls.Add(Me.txtPort)
        Me.GroupBox1.Controls.Add(Me.txtIP)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblPort)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(453, 164)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Settings"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(235, 25)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "HMI SETTING VALUES"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 281)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSaveSettings)
        Me.Controls.Add(Me.btnDisconnect)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.lblComCheck)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.Text = "Machine HMI"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtIP As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblPort As Label
    Friend WithEvents txtPort As TextBox
    Friend WithEvents btnConnect As Button
    Friend WithEvents btnDisconnect As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblComCheck As Label
    Friend WithEvents tmrComCheck As Timer
    Friend WithEvents tmrRealTimeCheck As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTAMCounterSet As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboMachineName As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSQLPath As TextBox
    Friend WithEvents btnSaveSettings As FontAwesome.Sharp.IconButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
End Class
