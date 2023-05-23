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
        Me.SuspendLayout()
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(17, 28)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(101, 20)
        Me.txtIP.TabIndex = 4
        Me.txtIP.Text = "169.254.190.100"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "IP Address"
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.Location = New System.Drawing.Point(14, 51)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(26, 13)
        Me.lblPort.TabIndex = 2
        Me.lblPort.Text = "Port"
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(17, 67)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(101, 20)
        Me.txtPort.TabIndex = 4
        Me.txtPort.Text = "502"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(124, 28)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(77, 59)
        Me.btnConnect.TabIndex = 5
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Location = New System.Drawing.Point(207, 28)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(77, 59)
        Me.btnDisconnect.TabIndex = 5
        Me.btnDisconnect.Text = "Disconnect"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Connection Status:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(117, 93)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(76, 13)
        Me.lblStatus.TabIndex = 2
        Me.lblStatus.Text = "Disconnected!"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "ComCheck:"
        '
        'lblComCheck
        '
        Me.lblComCheck.AutoSize = True
        Me.lblComCheck.Location = New System.Drawing.Point(74, 116)
        Me.lblComCheck.Name = "lblComCheck"
        Me.lblComCheck.Size = New System.Drawing.Size(13, 13)
        Me.lblComCheck.TabIndex = 2
        Me.lblComCheck.Text = "0"
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
        Me.Label1.Location = New System.Drawing.Point(12, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "TAM Counter Set:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTAMCounterSet
        '
        Me.txtTAMCounterSet.Location = New System.Drawing.Point(110, 186)
        Me.txtTAMCounterSet.Name = "txtTAMCounterSet"
        Me.txtTAMCounterSet.Size = New System.Drawing.Size(79, 20)
        Me.txtTAMCounterSet.TabIndex = 4
        Me.txtTAMCounterSet.Text = "5"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(14, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Machine No:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboMachineName
        '
        Me.cboMachineName.FormattingEnabled = True
        Me.cboMachineName.Items.AddRange(New Object() {"Machine 1", "Machine 2", "Machine 3", "Machine 4", "Machine 5", "Machine 6", "Machine 7", "Machine 8", "Machine 9", "Machine 10", "Machine 11", "Machine 12", "Machine 13", "Machine 14", "Machine 15", "Machine 16", "Machine 17", "Machine 18", "Machine 19"})
        Me.cboMachineName.Location = New System.Drawing.Point(88, 161)
        Me.cboMachineName.Name = "cboMachineName"
        Me.cboMachineName.Size = New System.Drawing.Size(101, 21)
        Me.cboMachineName.TabIndex = 6
        Me.cboMachineName.Text = "Machine 1"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "SQLPath:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSQLPath
        '
        Me.txtSQLPath.Location = New System.Drawing.Point(64, 135)
        Me.txtSQLPath.Name = "txtSQLPath"
        Me.txtSQLPath.Size = New System.Drawing.Size(638, 20)
        Me.txtSQLPath.TabIndex = 4
        Me.txtSQLPath.Text = "Data Source=DESKTOP-4OGTIB2\DIAVIEWSQL;Initial Catalog=SPS;Persist Security Info=" &
    "True;User ID=sa;Password=doc577isin"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 369)
        Me.Controls.Add(Me.cboMachineName)
        Me.Controls.Add(Me.btnDisconnect)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.txtSQLPath)
        Me.Controls.Add(Me.txtTAMCounterSet)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.txtIP)
        Me.Controls.Add(Me.lblComCheck)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblPort)
        Me.Controls.Add(Me.Label4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSettings"
        Me.Text = "Machine HMI"
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
End Class
