Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Threading
Imports System.Windows.Documents
Imports FontAwesome.Sharp
Imports MS.Internal.WindowsRuntime.Windows

Public Class frmMainDash
    Dim stMC1MainPage As String = "Main"
    Dim stMC1PlsLoginPage As String = "Please Login"
    Dim stMC1Stop As String = "Stop"
    Dim stMC1Running As String = "Running"
    Dim stMC1Ready As String = "Ready"
    Dim stMC1NoPlan As String = "No Plan"
    Dim stMC1QAStop As String = "QA Stop"
    Dim stMC1Maintenance As String = "Maintenance"
    Dim stMC1StoppageType As String = "Stoppage Type"
    Dim stMC1OperatorStoppage As String = "Operator Stoppage"
    Dim stMC1MachineStoppage As String = "Machine Stoppage"
    Dim stMC1QAStoppage As String = "QA Stoppage"
    Dim stMC1QAVerification As String = "QA Verification"
    Dim stMC1TestAutoMode As String = "Test Auto Mode"


    '// SWITHC FORM INSIDE FORM PANEL
    Private Sub showForm(frm As Form)
        pnlFormContainer.Controls.Clear()
        frm.TopLevel = False
        frm.TopMost = True
        frm.Dock = DockStyle.Fill
        pnlFormContainer.Controls.Add(frm)
        frm.Show()
    End Sub
    Private Sub change_PanelContainerFrmMC1(page As String)
        Select Case page
            Case "Main"
                showForm(frmMC1MainPage)
            Case "Please Login"
                showForm(frmMC1PlsLogin)
            Case "Stop"
                showForm(frmMC1STOP)
            Case "Running"
                showForm(frmMC1RUN)
            Case "Ready"
                showForm(frmMC1Ready)
            Case "No Plan"
                showForm(frmMC1NoPlan)
            Case "QA Stop"
                showForm(frmMC1QAStoppage)
            Case "Maintenance"
                showForm(frmMC1Maintenance)
            Case "Stoppage Type"
                showForm(frmMC1StoppageType)
            Case "Operator Stoppage"
                showForm(frmMC1OperatorStoppage)
            Case "Machine Stoppage"
                showForm(frmMC1MachineStoppage)
            Case "QA Stoppage"
                showForm(frmMC1QAStoppage)
            Case "QA Verification"
                showForm(frmMC1QAVerification)
            Case "Test Auto Mode"
                showForm(frmMC1TestAutoMode)
        End Select
    End Sub
    Private Sub change_PanelContainerFrmMC2(page As String)
        'Select Case page
        '    Case "Main"
        '        showForm(frmMC2MainPage)
        '    Case "Please Login"
        '        showForm(frmMC2PlsLogin)
        '    Case "Stop"
        '        showForm(frmMC2STOP)
        '    Case "Running"
        '        showForm(frmMC2RUN)
        '    Case "Ready"
        '        showForm(frmMC2Ready)
        '    Case "No Plan"
        '        showForm(frmMC2NoPlan)
        '    Case "QA Stop"
        '        showForm(frmMC2QAStoppage)
        '    Case "Maintenance"
        '        showForm(frmMC2Maintenance)
        'End Select
    End Sub
    '//

    '// COMMUNICATION CHECK PLC AND DASHBOARD
    Public Sub comCheck()
        Dim comON As String
        Dim comOFF As String
        comON = "C:\Users\TuF GaminG\Documents\000 projects\001VB.Net\HMI_PCBase\Resources\indicator red.png"
        comOFF = "C:\Users\TuF GaminG\Documents\000 projects\001VB.Net\HMI_PCBase\Resources\indicator green.png"

        If modComCheck = "0" Then
            picComCheck.Image = Image.FromFile(comOFF)
        Else
            picComCheck.Image = Image.FromFile(comON)
        End If
    End Sub
    '//

    '// FORM LOAD
    Private Sub frmMainDash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        shiftUpdate()
        lblStopDateTime.Text = My.Settings.stopTime
        modMC1StopDateandTime = My.Settings.stopTime
        Me.CenterToScreen()
    End Sub
    '//
    Private Sub frmMainDash_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.stopTime = lblStopDateTime.Text
        tmrRepairTime.Stop()
        tmrQAVeriTime.Stop()
    End Sub
    '// 
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrRealTimeCheck.Tick
        comCheck()
        TextChangeReferenceValues()
        MachineButtonEnableDisable()
        shiftUpdate()
        lblAckTime.Text = modMC1RepairTimer
        lblQAVeriTimer.Text = modMC1QAVeriTimer
        lblFailCounter.Text = modMC1FailCounters
        Label22.Text = modMC1StoppageReason
    End Sub
    '//

    '// SHOW FORM SETTING
    Private Sub btnSetting_Click(sender As Object, e As EventArgs) Handles btnSetting.Click
        frmSettings.ShowDialog()
    End Sub
    '//

    '//FUNCTION AS EXTERNAL MACHINE START/STOP
    Private Sub btnStartStopMC1_Click(sender As Object, e As EventArgs) Handles btnStartStopMC1.Click
        If modStartStopMC1 = False Then
            modStartStopMC1 = True
            btnStartStopMC1.BackColor = Color.Green
            btnStartStopMC1.ForeColor = Color.White
            btnStartStopMC1.Text = "ON"
        Else
            modStartStopMC1 = False
            btnStartStopMC1.BackColor = Color.DarkRed
            btnStartStopMC1.ForeColor = Color.White
            btnStartStopMC1.Text = "OFF"
        End If
    End Sub
    Private Sub btnStartStopMC2_Click(sender As Object, e As EventArgs) Handles btnStartStopMC2.Click
        If modStartStopMC2 = False Then
            modStartStopMC2 = True
            btnStartStopMC2.BackColor = Color.Green
            btnStartStopMC2.ForeColor = Color.White
            btnStartStopMC2.Text = "ON"
        Else
            modStartStopMC2 = False
            btnStartStopMC2.BackColor = Color.DarkRed
            btnStartStopMC2.ForeColor = Color.White
            btnStartStopMC2.Text = "OFF"
        End If
    End Sub
    '//

    '// FUNCTION EXTERNAL MACHINE MANUAL AUTO OPERATION
    Private Sub ManualAuto_Buttons_Click(ByVal sender As Object, e As System.EventArgs) Handles btnAutoManualMC1.Click, btnAutoManualMC2.Click

        Dim currentBtn As Button = sender
        If currentBtn.Tag = 1 Then
            modAutoManualMC1 = True
            btnAutoManualMC1.Text = "MANUAL"
        Else
            modAutoManualMC1 = False
            btnAutoManualMC1.Text = "AUTO"
        End If
        If currentBtn.Tag = 2 Then
            modAutoManualMC2 = True
            btnAutoManualMC2.Text = "MANUAL"
        Else
            modAutoManualMC2 = False
            btnAutoManualMC2.Text = "AUTO"
        End If
    End Sub
    '//

    Public Sub TextChangeReferenceValues()
        lblRxPLCM0MC1.Text = RxPLCM0
        lblRxPLCM3MC1.Text = RxPLCM3
        lblRxPLCM12MC1.Text = RxPLCM12

        lblMain.Text = modInfrmMC1MainPage
        lblMaintenance.Text = modINfrmMC1Maintenance
        lblNoplan.Text = modINfrmMC1NoPlan
        lblPlsLogin.Text = modINfrmMC1PlsLogin
        'lblQAStop.Text = modINfrmMC1QAStoppage
        lblReady.Text = modINfrmMC1Ready
        lblRun.Text = modINfrmMC1Run
        lblStop.Text = modINfrmMC1Stop
        lblStoppageType.Text = modINfrmMC1StoppageType
        lblOperatorStoppage.Text = modINfrmMC1OperatorStoppage
        lblMachineStoppage.Text = modINfrmMC1MachineStoppage
        lblQAStoppage.Text = modINfrmMC1QAStoppage
        lblQAVerification.Text = modINfrmMC1QAVerification
        lblTestAutoMode.Text = modINfrmMC1TestAutoMode

        lblAckDateTime.Text = modMC1AckDateandTime
        lblAckFlag.Text = modMC1AcknowledgeFlag
        lblStopDateTime.Text = modMC1StopDateandTime
        lblShiftCode.Text = modShiftCode
        lblMC1_D2002.Text = D2002
        lblMC1OptStoppageSaveFlag.Text = modMC1OptStoppageSaveFlag
        lblMC1MachStoppageSaveFlag.Text = modMC1MachineStoppageSaveFlag
        lblMC1QASendSampleFlag.Text = modMC1QASendSampleFlag
        lblQAVerifyFailFlag.Text = modMC1QAVerifyFailFlag
        lblQAVerifyPassFlag.Text = modMC1QAVerifyPassFlag
        lblMC1QAStoppageSaveFlag.Text = modMC1QAStoppageSaveFlag
    End Sub

    '// MACHINE STAT DISPLAY ACCORDING TO MACHINE STATUS TYPE
    Private Sub lblRxPLCM3MC1_TextChanged(sender As Object, e As EventArgs) Handles lblRxPLCM3MC1.TextChanged
        If RxPLCM3 = False Then 'Machine1 LoggedIn confirm (M3 of PLC)
            modINfrmMC1PlsLogin = True
            modINfrmMC1Stop = False
        Else
            modINfrmMC1PlsLogin = False
            modINfrmMC1Stop = True
        End If
    End Sub
    Private Sub lblRxPLCM0MC1_TextChanged(sender As Object, e As EventArgs) Handles lblRxPLCM0MC1.TextChanged
        If RxPLCM0 = True Then 'Machine1 Start/Stop  (M0 of PLC)
            UpdateDowntimeAtMachineRunning()
            tmrMC1StopTimer.Stop()
            tmrRepairTime.Stop()
            tmrQAVeriTime.Stop()
            modMC1StopTimer = 0
            modMC1RepairTimer = 0
            modMC1QAVeriTimer = 0
            modMC1FailCounters = 0
            If modTestAutoModeMC1Flag = False Then
                modINfrmMC1Run = True
                modINfrmMC1Ready = False
            End If
        Else
            tmrMC1StopTimer.Start()
            modINfrmMC1Run = False
            If modMC1StopDateandTime = Nothing Then
                modMC1StopDateandTime = Now()
            End If
            If modTestAutoModeMC1Flag = False Then
                modINfrmMC1Stop = True
            End If
            InsertDowntimeData()
        End If
    End Sub
    Private Sub lblRxPLCM6MC1_TextChanged(sender As Object, e As EventArgs) Handles lblRxPLCM12MC1.TextChanged

    End Sub
    Private Sub lblPlsLogin_TextChanged(sender As Object, e As EventArgs) Handles lblPlsLogin.TextChanged
        If modINfrmMC1PlsLogin = True Then
            change_PanelContainerFrmMC1(stMC1PlsLoginPage) 'PLS LOGIN
            showForm(frmMC1PlsLogin)
        End If
    End Sub
    Private Sub lblStop_TextChanged(sender As Object, e As EventArgs) Handles lblStop.TextChanged
        If modTestAutoModeMC1Flag = False Then
            If modINfrmMC1Stop = True Then
                change_PanelContainerFrmMC1(stMC1Stop) 'STOP
                showForm(frmMC1STOP)
            End If
        End If
    End Sub
    Private Sub lblMain_TextChanged(sender As Object, e As EventArgs) Handles lblMain.TextChanged
        If modInfrmMC1MainPage = True Then
            change_PanelContainerFrmMC1(stMC1MainPage) 'MAIN PAGE
            showForm(frmMC1MainPage)
        End If
    End Sub
    Private Sub lblStoppageType_TextChanged(sender As Object, e As EventArgs) Handles lblStoppageType.TextChanged
        If modINfrmMC1StoppageType = True Then
            change_PanelContainerFrmMC1(stMC1StoppageType) 'STOPPAGE TYPE PAGE
            showForm(frmMC1StoppageType)
        End If
    End Sub
    Private Sub lblOperatorStoppage_TextChanged(sender As Object, e As EventArgs) Handles lblOperatorStoppage.TextChanged
        If modINfrmMC1OperatorStoppage = True Then
            change_PanelContainerFrmMC1(stMC1OperatorStoppage) 'OPERATOR STOPPAGE PAGE
            showForm(frmMC1OperatorStoppage)
        End If
    End Sub
    Private Sub lblMachineStoppage_TextChanged(sender As Object, e As EventArgs) Handles lblMachineStoppage.TextChanged
        If modINfrmMC1MachineStoppage = True Then
            change_PanelContainerFrmMC1(stMC1MachineStoppage) 'MACHINE STOPPAGE PAGE
            showForm(frmMC1MachineStoppage)
        End If
    End Sub
    Private Sub lblReady_TextChanged(sender As Object, e As EventArgs) Handles lblReady.TextChanged
        If modINfrmMC1Ready = True Then
            change_PanelContainerFrmMC1(stMC1Ready) 'READY PAGE
            showForm(frmMC1Ready)
        End If
    End Sub
    Private Sub lblRun_TextChanged(sender As Object, e As EventArgs) Handles lblRun.TextChanged
        If modTestAutoModeMC1Flag = False Then
            If modINfrmMC1Run = True Then
                change_PanelContainerFrmMC1(stMC1Running) 'RUNNING PAGE
                showForm(frmMC1RUN)
            End If
        End If
    End Sub
    Private Sub lblQAStoppage_TextChanged(sender As Object, e As EventArgs) Handles lblQAStoppage.TextChanged
        If modINfrmMC1QAStoppage = True Then
            change_PanelContainerFrmMC1(stMC1QAStoppage) 'QA STOPPAGE
            showForm(frmMC1QAStoppage)
        End If
    End Sub
    Private Sub lblQAVerification_TextChanged(sender As Object, e As EventArgs) Handles lblQAVerification.TextChanged
        If modINfrmMC1QAVerification = True Then
            change_PanelContainerFrmMC1(stMC1QAVerification) 'QA VERIFICATION
            showForm(frmMC1QAVerification)
        End If
    End Sub
    Private Sub lblTestAutoMode_TextChanged(sender As Object, e As EventArgs) Handles lblTestAutoMode.TextChanged
        If modINfrmMC1TestAutoMode = True Then
            change_PanelContainerFrmMC1(stMC1TestAutoMode) 'QA TEST AUTO MODE
            showForm(frmMC1TestAutoMode)
        End If
    End Sub
    Private Sub lblAckFlag_TextChanged(sender As Object, e As EventArgs) Handles lblAckFlag.TextChanged
        If modMC1AcknowledgeFlag = True Then
            UpdateDowntimeAtAcknowledge()
            tmrRepairTime.Enabled = True
            tmrRepairTime.Start()
        End If
    End Sub
    Private Sub lblMC1OptStoppageSaveFlag_TextChanged(sender As Object, e As EventArgs) Handles lblMC1OptStoppageSaveFlag.TextChanged
        If modMC1OptStoppageSaveFlag = True Then
            UpdateDowntimeAtStoppageSaved()
            tmrRepairTime.Stop()
            modMC1RepairTimer = 0
        End If
    End Sub
    Private Sub lblMC1MachStoppageSaveFlag_TextChanged(sender As Object, e As EventArgs) Handles lblMC1MachStoppageSaveFlag.TextChanged
        If modMC1MachineStoppageSaveFlag = True Then
            UpdateDowntimeAtStoppageSaved()
            tmrRepairTime.Stop()
            modMC1RepairTimer = 0
        End If
    End Sub
    Private Sub lblQASendSampleFlag_TextChanged(sender As Object, e As EventArgs) Handles lblMC1QASendSampleFlag.TextChanged
        If modMC1QASendSampleFlag = True Then
            tmrQAVeriTime.Enabled = True
            tmrQAVeriTime.Start()
            UpdateDowntimeAtStoppageSaved()
        ElseIf modINfrmMC1Ready = False And modMC1QASendSampleFlag = False Then
            tmrQAVeriTime.Enabled = False
            tmrQAVeriTime.Stop()
            modMC1QAVeriTimer = 0
        End If
    End Sub
    Private Sub lblQAVerifyFailFlag_TextChanged(sender As Object, e As EventArgs) Handles lblQAVerifyFailFlag.TextChanged
        If modMC1QAVerifyFailFlag = True Then
            UpdateDowntimeAtQAVerifyFail()
            tmrQAVeriTime.Enabled = False
            tmrQAVeriTime.Stop()
            modMC1QAVeriTimer = 0
        End If
    End Sub
    Private Sub lblQAVerifyPassFlag_TextChanged(sender As Object, e As EventArgs) Handles lblQAVerifyPassFlag.TextChanged
        If modMC1QAVerifyPassFlag = True Then
            UpdateDowntimeAtQAVerifyPass()
            tmrQAVeriTime.Stop()
            modMC1QAVeriTimer = 0
        End If
    End Sub
    Private Sub lblMC1QAStoppageFlag_TextChanged(sender As Object, e As EventArgs) Handles lblMC1QAStoppageSaveFlag.TextChanged
        If modMC1QAStoppageSaveFlag = True Then

        End If
    End Sub
    '//


    '//
    Public Sub MachineButtonEnableDisable()
        If modINfrmMC1Ready = True Then
            btnStartStopMC1.Enabled = True
        ElseIf RxPLCM0 = True Then
            btnStartStopMC1.Enabled = True
        ElseIf modTestAutoModeMC1Flag = True Then
            btnStartStopMC1.Enabled = True
        Else
            btnStartStopMC1.Enabled = False
        End If
    End Sub
    '//

    '//
    Public Sub TestAutoModeCounter()
        If modTestAutoModeMC1Flag = True And RxPLCM0 = True Then
            modMC1TestAutoModeCounter += 1
        End If
    End Sub
    Private Sub lblMC1_D2002_TextChanged(sender As Object, e As EventArgs) Handles lblMC1_D2002.TextChanged
        TestAutoModeCounter()
    End Sub
    '//

    '//
    Public Sub shiftUpdate()
        Dim sc As Date
        modsftHours = Date.Now.ToString("HH")
        modsftMonth = Date.Now.ToString("MM")
        modsftYear = Date.Now.ToString("yy")

        'Shift change Day to Nigh and vice versa
        If modsftHours >= 8 And modsftHours < 20 Then
            modsShift = "D"
        ElseIf modsftHours >= 20 Or (modsftHours >= 0 And modsftHours < 8) Then
            modsShift = "N"
        End If

        'Shift Date, continue the same date and will change on the next morning shift schedule
        If modsftHours >= 0 And modsftHours < 8 Then
            'adding date set 1 to 1
            'subtracting date set 1 to -1 
            '1 is just as sample i used since im only adding or subtracting 1 day to the current date and time
            sc = DateAdd(DateInterval.Day, -1, Now())
            modsftDay = sc.Date.ToString("dd")
        Else
            modsftDay = Date.Now.ToString("dd")
        End If
        'shiftcode format D/N & dd & MM & yy & MC#
        modShiftCode = modsShift & modsftDay & modsftMonth & modsftYear
    End Sub
    '//

    '//
    Public Sub InsertDowntimeData()
        shiftUpdate()
        Dim uID As String
        Dim sfCode As String
        sfCode = modShiftCode & "MC1"
        uID = D2006

        Dim sqlPath As String = "Data Source=DESKTOP-4OGTIB2\DIAVIEWSQL;Initial Catalog=SPS;Persist Security Info=True;User ID=sa;Password=doc577isin"
        Dim sqlProcedure As String = "InsertProDT"
        Dim con As New SqlConnection(sqlPath)
        Using cmd As SqlCommand = New SqlCommand(sqlProcedure, con)
            cmd.Parameters.AddWithValue("@ShiftCode", sfCode)
            cmd.Parameters.AddWithValue("@UName", "")
            cmd.Parameters.AddWithValue("@UNID", uID)
            cmd.Parameters.AddWithValue("@DTType", "TBA") 'modMC1StoppageType
            cmd.Parameters.AddWithValue("@StartTime", modMC1StopDateandTime)
            cmd.Parameters.AddWithValue("@DTReason", "TBA") 'modMC1StoppageReason
            cmd.Parameters.AddWithValue("@DTCountermeasure", "TBA") 'CM
            cmd.Parameters.AddWithValue("@AckDate", "Not Yet Ack") 'modMC1AckDateandTime
            cmd.Parameters.AddWithValue("@EndTime", "TBA") 'modMC1StoppageEndTime
            cmd.Parameters.AddWithValue("@RunTime", "0") 'RunT
            cmd.Parameters.AddWithValue("@ttlDT", "0") 'ttlDT
            cmd.Parameters.AddWithValue("@ttlRprT", "0") 'ttlRprT
            cmd.Parameters.AddWithValue("@ForQAVeri", "0")
            cmd.Parameters.AddWithValue("@ttlQAVeri", "0") 'ttlQAVeriT
            cmd.Parameters.AddWithValue("@ttlFailFreq", "0") 'modMC1FailCounters
            cmd.Parameters.AddWithValue("@DTStatus", "MC1NewStoppage")
            cmd.CommandType = CommandType.StoredProcedure

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        End Using
    End Sub

    Public Sub UpdateDowntimeAtAcknowledge()
        Dim sqlPath As String = "Data Source=DESKTOP-4OGTIB2\DIAVIEWSQL;Initial Catalog=SPS;Persist Security Info=True;User ID=sa;Password=doc577isin"
        Dim UpdateProDT As String = "UpdateProDTAck"
        Dim con As New SqlConnection(sqlPath)
        Using cmd As SqlCommand = New SqlCommand(UpdateProDT, con)
            cmd.Parameters.AddWithValue("@AckDate", modMC1AckDateandTime)
            cmd.Parameters.AddWithValue("@DTStatus", "MC1NewStoppage")
            cmd.CommandType = CommandType.StoredProcedure

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        End Using
    End Sub

    Public Sub UpdateDowntimeAtStoppageSaved()
        Dim stCM As String
        Dim EndTime As String
        Dim ttlRprT As String
        Dim qaVeriDateTime As String

        ttlRprT = Math.Round((modMC1RepairTimer / 60), 4)
        EndTime = Now()
        If modMC1StoppageType = "Operator" Then
            stCM = "n/a"
            qaVeriDateTime = "n/a"
        ElseIf modMC1StoppageType = "Machine" Then
            stCM = modMC1Countermeasure
            qaVeriDateTime = "n/a"
        ElseIf modMC1StoppageType = "Quality" Then
            stCM = modMC1Countermeasure
            qaVeriDateTime = Now()
        End If

        Dim sqlPath As String = "Data Source=DESKTOP-4OGTIB2\DIAVIEWSQL;Initial Catalog=SPS;Persist Security Info=True;User ID=sa;Password=doc577isin"
        Dim UpdateProDT As String = "UpdateProDTSave"
        Dim con As New SqlConnection(sqlPath)
        Using cmd As SqlCommand = New SqlCommand(UpdateProDT, con)
            cmd.Parameters.AddWithValue("@DTType", modMC1StoppageType)
            cmd.Parameters.AddWithValue("@DTReason", modMC1StoppageReason)
            cmd.Parameters.AddWithValue("@DTCountermeasure", stCM)
            cmd.Parameters.AddWithValue("@EndTime", EndTime)
            cmd.Parameters.AddWithValue("@ttlRprT", ttlRprT)
            cmd.Parameters.AddWithValue("@ForQAVeri", qaVeriDateTime)
            cmd.Parameters.AddWithValue("@ttlQAVeri", "0")
            cmd.Parameters.AddWithValue("@ttlFailFreq", modMC1FailCounters)
            cmd.Parameters.AddWithValue("@DTStatus", "MC1NewStoppage")
            cmd.CommandType = CommandType.StoredProcedure

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            modMC1StoppageType = Nothing
            modMC1StoppageReason = Nothing
            modMC1Countermeasure = Nothing
            modMC1AckDateandTime = Nothing
            modMC1AcknowledgeFlag = False
            modMC1OptStoppageSaveFlag = False
            modMC1MachineStoppageSaveFlag = False
        End Using
    End Sub

    Public Sub UpdateDowntimeAtMachineRunning()
        Dim ttlDT As String
        Dim RunT As String
        Dim uID As String
        uID = D2006
        RunT = Now()
        ttlDT = Math.Round((modMC1StopTimer / 60), 4)

        Dim dtComplete As String = "MC1DTComplete"
        Dim sqlPath As String = "Data Source=DESKTOP-4OGTIB2\DIAVIEWSQL;Initial Catalog=SPS;Persist Security Info=True;User ID=sa;Password=doc577isin"
        Dim UpdateProDT As String = "UpdateProDTMCRun"
        Dim con As New SqlConnection(sqlPath)
        Using cmd As SqlCommand = New SqlCommand(UpdateProDT, con)
            cmd.Parameters.AddWithValue("@UNID", uID)
            cmd.Parameters.AddWithValue("@RunTime", RunT)
            cmd.Parameters.AddWithValue("@ttlDT", ttlDT)
            cmd.Parameters.AddWithValue("@DTComplete", dtComplete)
            cmd.Parameters.AddWithValue("@DTStatus", "MC1NewStoppage")
            cmd.CommandType = CommandType.StoredProcedure

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            modMC1StoppageType = Nothing
            modMC1StopDateandTime = Nothing
            modMC1StoppageReason = Nothing
            modMC1Countermeasure = Nothing
            modMC1AckDateandTime = Nothing
            modMC1StoppageEndTime = Nothing
            modMC1FailCounters = 0
        End Using
    End Sub

    Public Sub UpdateDowntimeAtQAVerifyFail()
        Dim sqlPath As String = "Data Source=DESKTOP-4OGTIB2\DIAVIEWSQL;Initial Catalog=SPS;Persist Security Info=True;User ID=sa;Password=doc577isin"
        Dim UpdateProDT As String = "UpdateProDTQAVeriFail"
        Dim con As New SqlConnection(sqlPath)
        Using cmd As SqlCommand = New SqlCommand(UpdateProDT, con)
            cmd.Parameters.AddWithValue("@ForQAVeri", "TBA")
            cmd.Parameters.AddWithValue("@ttlFailFreq", modMC1FailCounters)
            cmd.Parameters.AddWithValue("@DTStatus", "MC1NewStoppage")
            cmd.CommandType = CommandType.StoredProcedure

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        End Using
    End Sub

    Public Sub UpdateDowntimeAtQAVerifyPass()
        Dim ttlVeri As String
        ttlVeri = Math.Round((modMC1QAVeriTimer / 60), 4)
        Dim sqlPath As String = "Data Source=DESKTOP-4OGTIB2\DIAVIEWSQL;Initial Catalog=SPS;Persist Security Info=True;User ID=sa;Password=doc577isin"
        Dim UpdateProDT As String = "UpdateProDTQAVeriPass"
        Dim con As New SqlConnection(sqlPath)
        Using cmd As SqlCommand = New SqlCommand(UpdateProDT, con)
            cmd.Parameters.AddWithValue("@ttlQAVeri", ttlVeri)
            cmd.Parameters.AddWithValue("@ttlFailFreq", modMC1FailCounters)
            cmd.Parameters.AddWithValue("@DTStatus", "MC1NewStoppage")
            cmd.CommandType = CommandType.StoredProcedure

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            modMC1QASendSampleFlag = False
            modMC1QAVerifyPassFlag = False
        End Using
    End Sub

    Private Sub tmrMC1StopTimer_Tick(sender As Object, e As EventArgs) Handles tmrMC1StopTimer.Tick
        modMC1StopTimer += 1
    End Sub

    Private Sub tmrRepairTime_Tick(sender As Object, e As EventArgs) Handles tmrRepairTime.Tick
        modMC1RepairTimer += 1
    End Sub

    Private Sub tmrQAVeriTime_Tick(sender As Object, e As EventArgs) Handles tmrQAVeriTime.Tick
        modMC1QAVeriTimer += 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GetPlanDetails()
    End Sub


    Public Sub GetPlanDetails()
        Try
            Dim sqlPath As String = "Data Source=DESKTOP-4OGTIB2\DIAVIEWSQL;Initial Catalog=SPS;Persist Security Info=True;User ID=sa;Password=doc577isin"
            Dim sqlProc As String = "SelectProJOPlan"
            Dim con As New SqlConnection(sqlPath)
            Using cmd As SqlCommand = New SqlCommand(sqlProc, con)
                cmd.Parameters.AddWithValue("@MachineID", "Machine 1")
                cmd.Parameters.AddWithValue("@LoadStat", "Loaded")
                cmd.CommandType = CommandType.StoredProcedure

                con.Open()
                Dim myreader As SqlDataReader
                myreader = cmd.ExecuteReader
                myreader.Read()
                modJOPlan = myreader("JOB_ORDER_QTY")
                con.Close()
                'MsgBox(modJOPlan)
            End Using
        Catch ex As Exception
            MessageBox.Show("No Job Order Loaded at Machine1!", "Get JO Plan Qty", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Public Sub JOPlanVSActualTriggering()
        'Max no. of Part No. in a Mould = 2
        'Max no. of Cavity per Part No in a Mould = 4

    End Sub




End Class