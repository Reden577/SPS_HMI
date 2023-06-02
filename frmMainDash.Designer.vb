<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainDash
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
        Me.pnlFormContainer = New System.Windows.Forms.Panel()
        Me.btnStartStopMC1 = New System.Windows.Forms.Button()
        Me.btnStartStopMC2 = New System.Windows.Forms.Button()
        Me.tmrRealTimeCheck = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAutoManualMC1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAutoManualMC2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblShiftCode = New System.Windows.Forms.Label()
        Me.lblMachineNo = New System.Windows.Forms.Label()
        Me.picComCheck = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tmrMC1StopTimer = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRepairTime = New System.Windows.Forms.Timer(Me.components)
        Me.tmrQAVeriTime = New System.Windows.Forms.Timer(Me.components)
        Me.Label22 = New System.Windows.Forms.Label()
        Me.main = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblAckTime = New System.Windows.Forms.Label()
        Me.lblQAVeriTimer = New System.Windows.Forms.Label()
        Me.lblFailCounter = New System.Windows.Forms.Label()
        Me.lblMC1QASendSampleFlag = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblRxPLCM3MC1 = New System.Windows.Forms.Label()
        Me.lblRxPLCM12MC1 = New System.Windows.Forms.Label()
        Me.lblAckDateTime = New System.Windows.Forms.Label()
        Me.lblAckFlag = New System.Windows.Forms.Label()
        Me.lblStopDateTime = New System.Windows.Forms.Label()
        Me.lblRxPLCM0MC1 = New System.Windows.Forms.Label()
        Me.lblMaintenance = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNoplan = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPlsLogin = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblQAStop = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblReady = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblRun = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblStop = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblStoppageType = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblOperatorStoppage = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblMachineStoppage = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblQAStoppage = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblQAVerification = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lblTestAutoMode = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.lblMC1_D2002 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.lblMC1OptStoppageSaveFlag = New System.Windows.Forms.Label()
        Me.lblMC1MachStoppageSaveFlag = New System.Windows.Forms.Label()
        Me.lblQAVerifyPassFlag = New System.Windows.Forms.Label()
        Me.lblQAVerifyFailFlag = New System.Windows.Forms.Label()
        Me.lblMC1QAStoppageSaveFlag = New System.Windows.Forms.Label()
        Me.lblTesting = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblM16FlagisTrue = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.lblUserLoggedAndJOLoadedisTrue = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.lblUserLoggedINisTrue = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.lblJOLoadedisTrue = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.lblInfrmNewJOSetup = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.lblPlanComplete = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lblInfmPlanComplete = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.btnSetting = New FontAwesome.Sharp.IconButton()
        Me.tmrMSTimerCounter = New System.Windows.Forms.Timer(Me.components)
        Me.tmrFPBTimerCounter = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMPTimerCounter = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.picComCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlFormContainer
        '
        Me.pnlFormContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlFormContainer.Location = New System.Drawing.Point(0, 38)
        Me.pnlFormContainer.Name = "pnlFormContainer"
        Me.pnlFormContainer.Size = New System.Drawing.Size(488, 400)
        Me.pnlFormContainer.TabIndex = 0
        '
        'btnStartStopMC1
        '
        Me.btnStartStopMC1.BackColor = System.Drawing.Color.DarkRed
        Me.btnStartStopMC1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartStopMC1.ForeColor = System.Drawing.Color.White
        Me.btnStartStopMC1.Location = New System.Drawing.Point(6, 16)
        Me.btnStartStopMC1.Name = "btnStartStopMC1"
        Me.btnStartStopMC1.Size = New System.Drawing.Size(113, 58)
        Me.btnStartStopMC1.TabIndex = 0
        Me.btnStartStopMC1.Tag = "1"
        Me.btnStartStopMC1.Text = "OFF"
        Me.btnStartStopMC1.UseVisualStyleBackColor = False
        '
        'btnStartStopMC2
        '
        Me.btnStartStopMC2.BackColor = System.Drawing.Color.DarkRed
        Me.btnStartStopMC2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartStopMC2.ForeColor = System.Drawing.Color.White
        Me.btnStartStopMC2.Location = New System.Drawing.Point(6, 16)
        Me.btnStartStopMC2.Name = "btnStartStopMC2"
        Me.btnStartStopMC2.Size = New System.Drawing.Size(113, 58)
        Me.btnStartStopMC2.TabIndex = 0
        Me.btnStartStopMC2.Tag = "2"
        Me.btnStartStopMC2.Text = "OFF"
        Me.btnStartStopMC2.UseVisualStyleBackColor = False
        '
        'tmrRealTimeCheck
        '
        Me.tmrRealTimeCheck.Enabled = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAutoManualMC1)
        Me.GroupBox1.Controls.Add(Me.btnStartStopMC1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 444)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(266, 87)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Machine 1"
        Me.GroupBox1.Visible = False
        '
        'btnAutoManualMC1
        '
        Me.btnAutoManualMC1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAutoManualMC1.Location = New System.Drawing.Point(133, 16)
        Me.btnAutoManualMC1.Name = "btnAutoManualMC1"
        Me.btnAutoManualMC1.Size = New System.Drawing.Size(124, 58)
        Me.btnAutoManualMC1.TabIndex = 1
        Me.btnAutoManualMC1.Tag = "1"
        Me.btnAutoManualMC1.Text = "AUTO"
        Me.btnAutoManualMC1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnAutoManualMC2)
        Me.GroupBox2.Controls.Add(Me.btnStartStopMC2)
        Me.GroupBox2.Location = New System.Drawing.Point(496, 444)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(266, 87)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Machine 2"
        Me.GroupBox2.Visible = False
        '
        'btnAutoManualMC2
        '
        Me.btnAutoManualMC2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAutoManualMC2.Location = New System.Drawing.Point(134, 16)
        Me.btnAutoManualMC2.Name = "btnAutoManualMC2"
        Me.btnAutoManualMC2.Size = New System.Drawing.Size(124, 58)
        Me.btnAutoManualMC2.TabIndex = 1
        Me.btnAutoManualMC2.Tag = "2"
        Me.btnAutoManualMC2.Text = "AUTO"
        Me.btnAutoManualMC2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblShiftCode)
        Me.Panel1.Controls.Add(Me.lblMachineNo)
        Me.Panel1.Controls.Add(Me.picComCheck)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(494, 32)
        Me.Panel1.TabIndex = 5
        '
        'lblShiftCode
        '
        Me.lblShiftCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShiftCode.ForeColor = System.Drawing.Color.White
        Me.lblShiftCode.Location = New System.Drawing.Point(287, 6)
        Me.lblShiftCode.Name = "lblShiftCode"
        Me.lblShiftCode.Size = New System.Drawing.Size(160, 20)
        Me.lblShiftCode.TabIndex = 0
        Me.lblShiftCode.Text = "Shift Code"
        Me.lblShiftCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMachineNo
        '
        Me.lblMachineNo.AutoSize = True
        Me.lblMachineNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMachineNo.ForeColor = System.Drawing.Color.White
        Me.lblMachineNo.Location = New System.Drawing.Point(5, 6)
        Me.lblMachineNo.Name = "lblMachineNo"
        Me.lblMachineNo.Size = New System.Drawing.Size(160, 20)
        Me.lblMachineNo.TabIndex = 0
        Me.lblMachineNo.Text = "Machine Dashboards"
        '
        'picComCheck
        '
        Me.picComCheck.Image = Global.HMI_PCBase.My.Resources.Resources.indicator_red
        Me.picComCheck.Location = New System.Drawing.Point(457, 6)
        Me.picComCheck.Name = "picComCheck"
        Me.picComCheck.Size = New System.Drawing.Size(20, 20)
        Me.picComCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picComCheck.TabIndex = 1
        Me.picComCheck.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(282, 460)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 42)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'tmrMC1StopTimer
        '
        Me.tmrMC1StopTimer.Enabled = True
        Me.tmrMC1StopTimer.Interval = 1000
        '
        'tmrRepairTime
        '
        Me.tmrRepairTime.Interval = 1000
        '
        'tmrQAVeriTime
        '
        Me.tmrQAVeriTime.Interval = 1000
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(289, 512)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(45, 13)
        Me.Label22.TabIndex = 7
        Me.Label22.Text = "Label22"
        Me.Label22.Visible = False
        '
        'main
        '
        Me.main.Location = New System.Drawing.Point(94, 48)
        Me.main.Name = "main"
        Me.main.Size = New System.Drawing.Size(65, 13)
        Me.main.TabIndex = 0
        Me.main.Text = "4.Infrm Main"
        Me.main.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(55, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "5.Infrm Maintenance"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(95, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "2.RxPLCM3"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMain
        '
        Me.lblMain.AutoSize = True
        Me.lblMain.Location = New System.Drawing.Point(162, 48)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(32, 13)
        Me.lblMain.TabIndex = 0
        Me.lblMain.Text = "False"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(536, 22)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(95, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Acknowledge Flag"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(89, 35)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(70, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "3.RxPLCM12"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(556, 35)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(75, 13)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Ack DateTime"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(74, 269)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(85, 13)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "QA SendSample"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAckTime
        '
        Me.lblAckTime.AutoSize = True
        Me.lblAckTime.Location = New System.Drawing.Point(556, 74)
        Me.lblAckTime.Name = "lblAckTime"
        Me.lblAckTime.Size = New System.Drawing.Size(86, 13)
        Me.lblAckTime.TabIndex = 0
        Me.lblAckTime.Text = "Ack Repair Time"
        Me.lblAckTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblQAVeriTimer
        '
        Me.lblQAVeriTimer.AutoSize = True
        Me.lblQAVeriTimer.Location = New System.Drawing.Point(556, 87)
        Me.lblQAVeriTimer.Name = "lblQAVeriTimer"
        Me.lblQAVeriTimer.Size = New System.Drawing.Size(72, 13)
        Me.lblQAVeriTimer.TabIndex = 0
        Me.lblQAVeriTimer.Text = "QA Veri Timer"
        Me.lblQAVeriTimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFailCounter
        '
        Me.lblFailCounter.AutoSize = True
        Me.lblFailCounter.Location = New System.Drawing.Point(556, 100)
        Me.lblFailCounter.Name = "lblFailCounter"
        Me.lblFailCounter.Size = New System.Drawing.Size(63, 13)
        Me.lblFailCounter.TabIndex = 0
        Me.lblFailCounter.Text = "Fail Counter"
        Me.lblFailCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMC1QASendSampleFlag
        '
        Me.lblMC1QASendSampleFlag.AutoSize = True
        Me.lblMC1QASendSampleFlag.Location = New System.Drawing.Point(162, 269)
        Me.lblMC1QASendSampleFlag.Name = "lblMC1QASendSampleFlag"
        Me.lblMC1QASendSampleFlag.Size = New System.Drawing.Size(32, 13)
        Me.lblMC1QASendSampleFlag.TabIndex = 0
        Me.lblMC1QASendSampleFlag.Text = "False"
        Me.lblMC1QASendSampleFlag.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(95, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "1.RxPLCM0"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(556, 7)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(75, 13)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "StopDate&Time"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRxPLCM3MC1
        '
        Me.lblRxPLCM3MC1.AutoSize = True
        Me.lblRxPLCM3MC1.Location = New System.Drawing.Point(162, 22)
        Me.lblRxPLCM3MC1.Name = "lblRxPLCM3MC1"
        Me.lblRxPLCM3MC1.Size = New System.Drawing.Size(32, 13)
        Me.lblRxPLCM3MC1.TabIndex = 0
        Me.lblRxPLCM3MC1.Text = "False"
        '
        'lblRxPLCM12MC1
        '
        Me.lblRxPLCM12MC1.AutoSize = True
        Me.lblRxPLCM12MC1.Location = New System.Drawing.Point(162, 35)
        Me.lblRxPLCM12MC1.Name = "lblRxPLCM12MC1"
        Me.lblRxPLCM12MC1.Size = New System.Drawing.Size(32, 13)
        Me.lblRxPLCM12MC1.TabIndex = 0
        Me.lblRxPLCM12MC1.Text = "False"
        '
        'lblAckDateTime
        '
        Me.lblAckDateTime.AutoSize = True
        Me.lblAckDateTime.Location = New System.Drawing.Point(632, 34)
        Me.lblAckDateTime.Name = "lblAckDateTime"
        Me.lblAckDateTime.Size = New System.Drawing.Size(32, 13)
        Me.lblAckDateTime.TabIndex = 0
        Me.lblAckDateTime.Text = "False"
        '
        'lblAckFlag
        '
        Me.lblAckFlag.AutoSize = True
        Me.lblAckFlag.Location = New System.Drawing.Point(632, 20)
        Me.lblAckFlag.Name = "lblAckFlag"
        Me.lblAckFlag.Size = New System.Drawing.Size(32, 13)
        Me.lblAckFlag.TabIndex = 0
        Me.lblAckFlag.Text = "False"
        '
        'lblStopDateTime
        '
        Me.lblStopDateTime.AutoSize = True
        Me.lblStopDateTime.Location = New System.Drawing.Point(632, 7)
        Me.lblStopDateTime.Name = "lblStopDateTime"
        Me.lblStopDateTime.Size = New System.Drawing.Size(32, 13)
        Me.lblStopDateTime.TabIndex = 0
        Me.lblStopDateTime.Text = "False"
        '
        'lblRxPLCM0MC1
        '
        Me.lblRxPLCM0MC1.AutoSize = True
        Me.lblRxPLCM0MC1.Location = New System.Drawing.Point(162, 7)
        Me.lblRxPLCM0MC1.Name = "lblRxPLCM0MC1"
        Me.lblRxPLCM0MC1.Size = New System.Drawing.Size(32, 13)
        Me.lblRxPLCM0MC1.TabIndex = 0
        Me.lblRxPLCM0MC1.Text = "False"
        '
        'lblMaintenance
        '
        Me.lblMaintenance.AutoSize = True
        Me.lblMaintenance.Location = New System.Drawing.Point(162, 61)
        Me.lblMaintenance.Name = "lblMaintenance"
        Me.lblMaintenance.Size = New System.Drawing.Size(32, 13)
        Me.lblMaintenance.TabIndex = 0
        Me.lblMaintenance.Text = "False"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(79, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "6.Infrm No Plan"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNoplan
        '
        Me.lblNoplan.AutoSize = True
        Me.lblNoplan.Location = New System.Drawing.Point(162, 74)
        Me.lblNoplan.Name = "lblNoplan"
        Me.lblNoplan.Size = New System.Drawing.Size(32, 13)
        Me.lblNoplan.TabIndex = 0
        Me.lblNoplan.Text = "False"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(56, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "7.Infrm Please Login"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPlsLogin
        '
        Me.lblPlsLogin.AutoSize = True
        Me.lblPlsLogin.Location = New System.Drawing.Point(162, 87)
        Me.lblPlsLogin.Name = "lblPlsLogin"
        Me.lblPlsLogin.Size = New System.Drawing.Size(32, 13)
        Me.lblPlsLogin.TabIndex = 0
        Me.lblPlsLogin.Text = "False"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(53, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "8.Infrm QA Stoppage"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblQAStop
        '
        Me.lblQAStop.AutoSize = True
        Me.lblQAStop.Location = New System.Drawing.Point(162, 100)
        Me.lblQAStop.Name = "lblQAStop"
        Me.lblQAStop.Size = New System.Drawing.Size(32, 13)
        Me.lblQAStop.TabIndex = 0
        Me.lblQAStop.Text = "False"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(86, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "9.Infrm Ready"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblReady
        '
        Me.lblReady.AutoSize = True
        Me.lblReady.Location = New System.Drawing.Point(162, 113)
        Me.lblReady.Name = "lblReady"
        Me.lblReady.Size = New System.Drawing.Size(32, 13)
        Me.lblReady.TabIndex = 0
        Me.lblReady.Text = "False"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(91, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "10.Infrm Run"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRun
        '
        Me.lblRun.AutoSize = True
        Me.lblRun.Location = New System.Drawing.Point(162, 126)
        Me.lblRun.Name = "lblRun"
        Me.lblRun.Size = New System.Drawing.Size(32, 13)
        Me.lblRun.TabIndex = 0
        Me.lblRun.Text = "False"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(89, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "11.Infrm Stop"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblStop
        '
        Me.lblStop.AutoSize = True
        Me.lblStop.Location = New System.Drawing.Point(162, 139)
        Me.lblStop.Name = "lblStop"
        Me.lblStop.Size = New System.Drawing.Size(32, 13)
        Me.lblStop.TabIndex = 0
        Me.lblStop.Text = "False"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(38, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "12.Infrm Stoppage Type"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblStoppageType
        '
        Me.lblStoppageType.AutoSize = True
        Me.lblStoppageType.Location = New System.Drawing.Point(162, 152)
        Me.lblStoppageType.Name = "lblStoppageType"
        Me.lblStoppageType.Size = New System.Drawing.Size(32, 13)
        Me.lblStoppageType.TabIndex = 0
        Me.lblStoppageType.Text = "False"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(21, 165)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(138, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "13.Infrm Operator Stoppage"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblOperatorStoppage
        '
        Me.lblOperatorStoppage.AutoSize = True
        Me.lblOperatorStoppage.Location = New System.Drawing.Point(162, 165)
        Me.lblOperatorStoppage.Name = "lblOperatorStoppage"
        Me.lblOperatorStoppage.Size = New System.Drawing.Size(32, 13)
        Me.lblOperatorStoppage.TabIndex = 0
        Me.lblOperatorStoppage.Text = "False"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(24, 178)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(135, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "14.Infrm MachineStoppage"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMachineStoppage
        '
        Me.lblMachineStoppage.AutoSize = True
        Me.lblMachineStoppage.Location = New System.Drawing.Point(162, 178)
        Me.lblMachineStoppage.Name = "lblMachineStoppage"
        Me.lblMachineStoppage.Size = New System.Drawing.Size(32, 13)
        Me.lblMachineStoppage.TabIndex = 0
        Me.lblMachineStoppage.Text = "False"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(50, 191)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "15.Infrm QAStoppage"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblQAStoppage
        '
        Me.lblQAStoppage.AutoSize = True
        Me.lblQAStoppage.Location = New System.Drawing.Point(162, 191)
        Me.lblQAStoppage.Name = "lblQAStoppage"
        Me.lblQAStoppage.Size = New System.Drawing.Size(32, 13)
        Me.lblQAStoppage.TabIndex = 0
        Me.lblQAStoppage.Text = "False"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(44, 204)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(115, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "16.Infrm QAVerification"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblQAVerification
        '
        Me.lblQAVerification.AutoSize = True
        Me.lblQAVerification.Location = New System.Drawing.Point(162, 204)
        Me.lblQAVerification.Name = "lblQAVerification"
        Me.lblQAVerification.Size = New System.Drawing.Size(32, 13)
        Me.lblQAVerification.TabIndex = 0
        Me.lblQAVerification.Text = "False"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(39, 217)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(120, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "17.Infrm TestAutoMOde"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 230)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(0, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(20, 243)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(139, 13)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "OperatorStoppageSaveFlag"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(29, 230)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(130, 13)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "MC1 Counter D2002"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(8, 256)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(151, 13)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "MachineStoppageSaveFlag"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTestAutoMode
        '
        Me.lblTestAutoMode.AutoSize = True
        Me.lblTestAutoMode.Location = New System.Drawing.Point(162, 217)
        Me.lblTestAutoMode.Name = "lblTestAutoMode"
        Me.lblTestAutoMode.Size = New System.Drawing.Size(32, 13)
        Me.lblTestAutoMode.TabIndex = 0
        Me.lblTestAutoMode.Text = "False"
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(8, 281)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(151, 13)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "QAVerifyPassFlag"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(8, 294)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(151, 13)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = "QAVerifyFailFlag"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMC1_D2002
        '
        Me.lblMC1_D2002.AutoSize = True
        Me.lblMC1_D2002.Location = New System.Drawing.Point(162, 230)
        Me.lblMC1_D2002.Name = "lblMC1_D2002"
        Me.lblMC1_D2002.Size = New System.Drawing.Size(0, 13)
        Me.lblMC1_D2002.TabIndex = 0
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(8, 307)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(151, 13)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "QAStoppageFlag"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMC1OptStoppageSaveFlag
        '
        Me.lblMC1OptStoppageSaveFlag.AutoSize = True
        Me.lblMC1OptStoppageSaveFlag.Location = New System.Drawing.Point(162, 243)
        Me.lblMC1OptStoppageSaveFlag.Name = "lblMC1OptStoppageSaveFlag"
        Me.lblMC1OptStoppageSaveFlag.Size = New System.Drawing.Size(32, 13)
        Me.lblMC1OptStoppageSaveFlag.TabIndex = 0
        Me.lblMC1OptStoppageSaveFlag.Text = "False"
        '
        'lblMC1MachStoppageSaveFlag
        '
        Me.lblMC1MachStoppageSaveFlag.AutoSize = True
        Me.lblMC1MachStoppageSaveFlag.Location = New System.Drawing.Point(162, 256)
        Me.lblMC1MachStoppageSaveFlag.Name = "lblMC1MachStoppageSaveFlag"
        Me.lblMC1MachStoppageSaveFlag.Size = New System.Drawing.Size(32, 13)
        Me.lblMC1MachStoppageSaveFlag.TabIndex = 0
        Me.lblMC1MachStoppageSaveFlag.Text = "False"
        '
        'lblQAVerifyPassFlag
        '
        Me.lblQAVerifyPassFlag.AutoSize = True
        Me.lblQAVerifyPassFlag.Location = New System.Drawing.Point(162, 281)
        Me.lblQAVerifyPassFlag.Name = "lblQAVerifyPassFlag"
        Me.lblQAVerifyPassFlag.Size = New System.Drawing.Size(32, 13)
        Me.lblQAVerifyPassFlag.TabIndex = 0
        Me.lblQAVerifyPassFlag.Text = "False"
        '
        'lblQAVerifyFailFlag
        '
        Me.lblQAVerifyFailFlag.AutoSize = True
        Me.lblQAVerifyFailFlag.Location = New System.Drawing.Point(162, 294)
        Me.lblQAVerifyFailFlag.Name = "lblQAVerifyFailFlag"
        Me.lblQAVerifyFailFlag.Size = New System.Drawing.Size(32, 13)
        Me.lblQAVerifyFailFlag.TabIndex = 0
        Me.lblQAVerifyFailFlag.Text = "False"
        '
        'lblMC1QAStoppageSaveFlag
        '
        Me.lblMC1QAStoppageSaveFlag.AutoSize = True
        Me.lblMC1QAStoppageSaveFlag.Location = New System.Drawing.Point(162, 307)
        Me.lblMC1QAStoppageSaveFlag.Name = "lblMC1QAStoppageSaveFlag"
        Me.lblMC1QAStoppageSaveFlag.Size = New System.Drawing.Size(32, 13)
        Me.lblMC1QAStoppageSaveFlag.TabIndex = 0
        Me.lblMC1QAStoppageSaveFlag.Text = "False"
        '
        'lblTesting
        '
        Me.lblTesting.AutoSize = True
        Me.lblTesting.Location = New System.Drawing.Point(556, 126)
        Me.lblTesting.Name = "lblTesting"
        Me.lblTesting.Size = New System.Drawing.Size(45, 13)
        Me.lblTesting.TabIndex = 1
        Me.lblTesting.Text = "Label28"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.lblTesting)
        Me.Panel2.Controls.Add(Me.lblMC1QAStoppageSaveFlag)
        Me.Panel2.Controls.Add(Me.lblQAVerifyFailFlag)
        Me.Panel2.Controls.Add(Me.lblQAVerifyPassFlag)
        Me.Panel2.Controls.Add(Me.lblMC1MachStoppageSaveFlag)
        Me.Panel2.Controls.Add(Me.lblMC1OptStoppageSaveFlag)
        Me.Panel2.Controls.Add(Me.lblM16FlagisTrue)
        Me.Panel2.Controls.Add(Me.Label35)
        Me.Panel2.Controls.Add(Me.lblUserLoggedAndJOLoadedisTrue)
        Me.Panel2.Controls.Add(Me.Label34)
        Me.Panel2.Controls.Add(Me.lblUserLoggedINisTrue)
        Me.Panel2.Controls.Add(Me.Label33)
        Me.Panel2.Controls.Add(Me.lblJOLoadedisTrue)
        Me.Panel2.Controls.Add(Me.Label32)
        Me.Panel2.Controls.Add(Me.lblInfrmNewJOSetup)
        Me.Panel2.Controls.Add(Me.Label31)
        Me.Panel2.Controls.Add(Me.lblPlanComplete)
        Me.Panel2.Controls.Add(Me.Label29)
        Me.Panel2.Controls.Add(Me.lblInfmPlanComplete)
        Me.Panel2.Controls.Add(Me.Label28)
        Me.Panel2.Controls.Add(Me.Label27)
        Me.Panel2.Controls.Add(Me.lblMC1_D2002)
        Me.Panel2.Controls.Add(Me.Label30)
        Me.Panel2.Controls.Add(Me.Label26)
        Me.Panel2.Controls.Add(Me.lblTestAutoMode)
        Me.Panel2.Controls.Add(Me.Label25)
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.lblQAVerification)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.lblQAStoppage)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.lblMachineStoppage)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.lblOperatorStoppage)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.lblStoppageType)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.lblStop)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.lblRun)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.lblReady)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.lblQAStop)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.lblPlsLogin)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.lblNoplan)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lblMaintenance)
        Me.Panel2.Controls.Add(Me.lblRxPLCM0MC1)
        Me.Panel2.Controls.Add(Me.lblStopDateTime)
        Me.Panel2.Controls.Add(Me.lblAckFlag)
        Me.Panel2.Controls.Add(Me.lblAckDateTime)
        Me.Panel2.Controls.Add(Me.lblRxPLCM12MC1)
        Me.Panel2.Controls.Add(Me.lblRxPLCM3MC1)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.lblMC1QASendSampleFlag)
        Me.Panel2.Controls.Add(Me.lblFailCounter)
        Me.Panel2.Controls.Add(Me.lblQAVeriTimer)
        Me.Panel2.Controls.Add(Me.lblAckTime)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.lblMain)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.main)
        Me.Panel2.Location = New System.Drawing.Point(496, 38)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(692, 400)
        Me.Panel2.TabIndex = 0
        '
        'lblM16FlagisTrue
        '
        Me.lblM16FlagisTrue.Location = New System.Drawing.Point(354, 48)
        Me.lblM16FlagisTrue.Name = "lblM16FlagisTrue"
        Me.lblM16FlagisTrue.Size = New System.Drawing.Size(32, 13)
        Me.lblM16FlagisTrue.TabIndex = 0
        Me.lblM16FlagisTrue.Text = "False"
        Me.lblM16FlagisTrue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(200, 48)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(151, 13)
        Me.Label35.TabIndex = 0
        Me.Label35.Text = "InputCounterFlag_isTrue(X2=M16):"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUserLoggedAndJOLoadedisTrue
        '
        Me.lblUserLoggedAndJOLoadedisTrue.Location = New System.Drawing.Point(354, 35)
        Me.lblUserLoggedAndJOLoadedisTrue.Name = "lblUserLoggedAndJOLoadedisTrue"
        Me.lblUserLoggedAndJOLoadedisTrue.Size = New System.Drawing.Size(32, 13)
        Me.lblUserLoggedAndJOLoadedisTrue.TabIndex = 0
        Me.lblUserLoggedAndJOLoadedisTrue.Text = "False"
        Me.lblUserLoggedAndJOLoadedisTrue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(200, 35)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(151, 13)
        Me.Label34.TabIndex = 0
        Me.Label34.Text = "UserLogged And JO Loaded isTrue:"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUserLoggedINisTrue
        '
        Me.lblUserLoggedINisTrue.Location = New System.Drawing.Point(354, 22)
        Me.lblUserLoggedINisTrue.Name = "lblUserLoggedINisTrue"
        Me.lblUserLoggedINisTrue.Size = New System.Drawing.Size(32, 13)
        Me.lblUserLoggedINisTrue.TabIndex = 0
        Me.lblUserLoggedINisTrue.Text = "False"
        Me.lblUserLoggedINisTrue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label33
        '
        Me.Label33.Location = New System.Drawing.Point(200, 22)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(151, 13)
        Me.Label33.TabIndex = 0
        Me.Label33.Text = "User LoggedIn isTrue"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblJOLoadedisTrue
        '
        Me.lblJOLoadedisTrue.Location = New System.Drawing.Point(354, 7)
        Me.lblJOLoadedisTrue.Name = "lblJOLoadedisTrue"
        Me.lblJOLoadedisTrue.Size = New System.Drawing.Size(32, 13)
        Me.lblJOLoadedisTrue.TabIndex = 0
        Me.lblJOLoadedisTrue.Text = "False"
        Me.lblJOLoadedisTrue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(200, 7)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(151, 13)
        Me.Label32.TabIndex = 0
        Me.Label32.Text = "JO Loaded isTrue"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblInfrmNewJOSetup
        '
        Me.lblInfrmNewJOSetup.Location = New System.Drawing.Point(162, 346)
        Me.lblInfrmNewJOSetup.Name = "lblInfrmNewJOSetup"
        Me.lblInfrmNewJOSetup.Size = New System.Drawing.Size(32, 13)
        Me.lblInfrmNewJOSetup.TabIndex = 0
        Me.lblInfrmNewJOSetup.Text = "False"
        Me.lblInfrmNewJOSetup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(8, 346)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(151, 13)
        Me.Label31.TabIndex = 0
        Me.Label31.Text = "InfrmNewJOSetup"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPlanComplete
        '
        Me.lblPlanComplete.Location = New System.Drawing.Point(162, 333)
        Me.lblPlanComplete.Name = "lblPlanComplete"
        Me.lblPlanComplete.Size = New System.Drawing.Size(32, 13)
        Me.lblPlanComplete.TabIndex = 0
        Me.lblPlanComplete.Text = "False"
        Me.lblPlanComplete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(8, 333)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(151, 13)
        Me.Label29.TabIndex = 0
        Me.Label29.Text = "PlanComplete"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblInfmPlanComplete
        '
        Me.lblInfmPlanComplete.Location = New System.Drawing.Point(162, 320)
        Me.lblInfmPlanComplete.Name = "lblInfmPlanComplete"
        Me.lblInfmPlanComplete.Size = New System.Drawing.Size(32, 13)
        Me.lblInfmPlanComplete.TabIndex = 0
        Me.lblInfmPlanComplete.Text = "False"
        Me.lblInfmPlanComplete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(8, 320)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(151, 13)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "Infrm PlanComplete"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSetting
        '
        Me.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSetting.FlatAppearance.BorderSize = 0
        Me.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSetting.IconChar = FontAwesome.Sharp.IconChar.Gear
        Me.btnSetting.IconColor = System.Drawing.Color.Black
        Me.btnSetting.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSetting.Location = New System.Drawing.Point(426, 460)
        Me.btnSetting.Name = "btnSetting"
        Me.btnSetting.Size = New System.Drawing.Size(62, 57)
        Me.btnSetting.TabIndex = 2
        Me.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSetting.UseVisualStyleBackColor = True
        '
        'tmrMSTimerCounter
        '
        Me.tmrMSTimerCounter.Enabled = True
        Me.tmrMSTimerCounter.Interval = 1000
        '
        'tmrFPBTimerCounter
        '
        Me.tmrFPBTimerCounter.Enabled = True
        Me.tmrFPBTimerCounter.Interval = 1000
        '
        'tmrMPTimerCounter
        '
        Me.tmrMPTimerCounter.Enabled = True
        Me.tmrMPTimerCounter.Interval = 1000
        '
        'frmMainDash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(494, 528)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSetting)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pnlFormContainer)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmMainDash"
        Me.Text = "Main Dashboard"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picComCheck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlFormContainer As Panel
    Friend WithEvents btnStartStopMC1 As Button
    Friend WithEvents btnStartStopMC2 As Button
    Friend WithEvents picComCheck As PictureBox
    Friend WithEvents tmrRealTimeCheck As Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents btnSetting As FontAwesome.Sharp.IconButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnAutoManualMC1 As Button
    Friend WithEvents btnAutoManualMC2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblMachineNo As Label
    Friend WithEvents lblShiftCode As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents tmrMC1StopTimer As Timer
    Friend WithEvents tmrRepairTime As Timer
    Friend WithEvents tmrQAVeriTime As Timer
    Friend WithEvents Label22 As Label
    Friend WithEvents main As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblMain As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents lblAckTime As Label
    Friend WithEvents lblQAVeriTimer As Label
    Friend WithEvents lblFailCounter As Label
    Friend WithEvents lblMC1QASendSampleFlag As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lblRxPLCM3MC1 As Label
    Friend WithEvents lblRxPLCM12MC1 As Label
    Friend WithEvents lblAckDateTime As Label
    Friend WithEvents lblAckFlag As Label
    Friend WithEvents lblStopDateTime As Label
    Friend WithEvents lblRxPLCM0MC1 As Label
    Friend WithEvents lblMaintenance As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNoplan As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblPlsLogin As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblQAStop As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblReady As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblRun As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblStop As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblStoppageType As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblOperatorStoppage As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblMachineStoppage As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblQAStoppage As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblQAVerification As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents lblTestAutoMode As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents lblMC1_D2002 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents lblMC1OptStoppageSaveFlag As Label
    Friend WithEvents lblMC1MachStoppageSaveFlag As Label
    Friend WithEvents lblQAVerifyPassFlag As Label
    Friend WithEvents lblQAVerifyFailFlag As Label
    Friend WithEvents lblMC1QAStoppageSaveFlag As Label
    Friend WithEvents lblTesting As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblInfmPlanComplete As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents lblPlanComplete As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents lblInfrmNewJOSetup As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents lblJOLoadedisTrue As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents lblUserLoggedINisTrue As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents lblUserLoggedAndJOLoadedisTrue As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents tmrMSTimerCounter As Timer
    Friend WithEvents tmrFPBTimerCounter As Timer
    Friend WithEvents tmrMPTimerCounter As Timer
    Friend WithEvents lblM16FlagisTrue As Label
    Friend WithEvents Label35 As Label
End Class
