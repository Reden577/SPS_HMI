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
    Dim stMC1PlanComplete As String = "Plan Complete"
    Dim stMC1NewJOSetup As String = "New JO Setup"

    Dim cntLoggedUser As Integer
    Dim cntJOLoaded As Integer
    Dim cntProdnStat As Integer

    '// FORM LOAD
    Private Sub frmMainDash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        shiftUpdate()
        lblStopDateTime.Text = My.Settings.stopTime
        modMC1StopDateandTime = My.Settings.stopTime
        modSQLPath = My.Settings.SQLPath
        modSettingValMachineID = My.Settings.MachineNo
        modSQLPath = My.Settings.SQLPath

        modMSTimerCounter = My.Settings.MSTimer
        modFPBTimerCounter = My.Settings.FBTimer
        modMassProTimerCounter = My.Settings.MassProTimer

        RxPLCM3_isFalse()
        checkLoginAndJOLoaded()
        Me.CenterToScreen()
    End Sub
    '//
    Private Sub frmMainDash_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.stopTime = lblStopDateTime.Text
        My.Settings.SQLPath = modSQLPath

        My.Settings.MSTimer = modMSTimerCounter
        My.Settings.FBTimer = modFPBTimerCounter
        My.Settings.MassProTimer = modMassProTimerCounter

        tmrRepairTime.Stop()
        tmrQAVeriTime.Stop()
    End Sub
    '// 

    '// FORM MAIN DASH REAL TIME STATUS CHECK TIMER
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrRealTimeCheck.Tick
        comCheck()
        TextChangeReferenceValues()
        shiftUpdate()
        lblAckTime.Text = modMC1RepairTimer
        lblQAVeriTimer.Text = modMC1QAVeriTimer
        lblFailCounter.Text = modMC1FailCounters
        Label22.Text = modMC1StoppageReason
        checkLoginAndJOLoaded()
    End Sub
    '//

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
            Case "Plan Complete"
                showForm(frmPlanComplete)
            Case "New JO Setup"
                showForm(frmNewJOSetup)
        End Select
    End Sub
    '//

    '// COMMUNICATION CHECK PLC AND DASHBOARD
    Public Sub comCheck()
        Dim comON As Bitmap = My.Resources.indicator_green
        Dim comOFF As Bitmap = My.Resources.indicator_red

        If modComCheck = "0" Then
            picComCheck.Image = comOFF
        Else
            picComCheck.Image = comON
        End If
    End Sub
    '//

    '// CALLING FORM SETTING1 SUBS
    Private Sub btnSetting_Click(sender As Object, e As EventArgs) Handles btnSetting.Click
        frmSettings.ShowDialog()
    End Sub
    '//

    '// MONITORING SUBS FOR TEXT CHANGE
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
        lblInfmPlanComplete.Text = modINfrmMC1PlanComplete
        lblInfrmNewJOSetup.Text = modINfrmNewJOSetup

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
        lblPlanComplete.Text = RxPLCM14

        lblJOLoadedisTrue.Text = modJODetails_isTrue
        lblUserLoggedINisTrue.Text = modLoginDetails_isTrue
        lblUserLoggedAndJOLoadedisTrue.Text = modLoginAndJOLoaded_isTrue
    End Sub
    '//

    '// MACHINE STAT DISPLAY ACCORDING TO MACHINE STATUS TYPE (PLS LOGIN OR MACHINE STOP)
    Public Sub RxPLCM3_isFalse()
        'If RxPLCM3 = False Then 'Machine1 LoggedIn confirm (M3 of PLC)
        '    modINfrmMC1PlsLogin = True
        '    modINfrmMC1Stop = False
        'Else
        '    modINfrmMC1PlsLogin = False
        '    modINfrmNewJOSetup = True
        '    modINfrmMC1Stop = True
        'End If
    End Sub
    '//

    '// CHECKING FOR LOGIN AND JO LOADED SUBS
    Public Sub checkLoginAndJOLoaded()
        CountUserLogged() '<= 0
        CheckForLoadedJobOrders() '>= 1
        If cntLoggedUser <= 0 Then
            modLoginDetails_isTrue = True
        Else
            modLoginDetails_isTrue = False
        End If

        If cntJOLoaded >= 1 Then
            modJODetails_isTrue = True
        Else
            modJODetails_isTrue = False
        End If

        If modLoginDetails_isTrue = True And modJODetails_isTrue = True Then
            modLoginAndJOLoaded_isTrue = True
        Else
            modLoginAndJOLoaded_isTrue = False
        End If
    End Sub
    '//

    '// CALLING CONDITION SUB FOR SWITCHING FORMS (PLS LOGIN, STOP AND NEW JO SETUP)
    Public Sub formSwitchPlsLogin_Stop_JOLoadeSetup()
        If modLoginAndJOLoaded_isTrue = True Then
            modINfrmMC1PlsLogin = False
            If D2002 = 0 And modFPBuyOff_Done = False Then
                modINfrmNewJOSetup = True
            Else
                modINfrmMC1Stop = True
            End If
        Else
            modINfrmMC1PlsLogin = True
            modINfrmMC1Stop = False
        End If
    End Sub
    '//

    '// CALLING  KIOSK LOGIN AND JOLOADED CHECKING SUBS
    Private Sub lblRxPLCM3MC1_TextChanged(sender As Object, e As EventArgs) Handles lblRxPLCM3MC1.TextChanged
        RxPLCM3_isFalse()
    End Sub
    '// 

    '// CALLING START STOP OPERATION SUBS
    Private Sub lblRxPLCM0MC1_TextChanged(sender As Object, e As EventArgs) Handles lblRxPLCM0MC1.TextChanged
        If modTAM_NewJOLoaded_isTrue = False Then 'Interlock during NEW Job Order is Loaded.....
            PlanVsActualMonitoring()
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
        End If

    End Sub
    '//

    '// 
    Private Sub lblRxPLCM6MC1_TextChanged(sender As Object, e As EventArgs) Handles lblRxPLCM12MC1.TextChanged

    End Sub
    '//

    '// CALLING FORM PLS LOGIN SUBS
    Private Sub lblPlsLogin_TextChanged(sender As Object, e As EventArgs) Handles lblPlsLogin.TextChanged
        If modINfrmMC1PlsLogin = True Then
            change_PanelContainerFrmMC1(stMC1PlsLoginPage) 'PLS LOGIN
            showForm(frmMC1PlsLogin)
        End If
    End Sub
    '//

    '// CALLING FROM STOP SUBS
    Private Sub lblStop_TextChanged(sender As Object, e As EventArgs) Handles lblStop.TextChanged
        If modTestAutoModeMC1Flag = False Then
            If modINfrmMC1Stop = True Then
                change_PanelContainerFrmMC1(stMC1Stop) 'STOP
                showForm(frmMC1STOP)
            End If
        End If
    End Sub
    '//

    '// CALLING FORM MAIN SUBS
    Private Sub lblMain_TextChanged(sender As Object, e As EventArgs) Handles lblMain.TextChanged
        If modInfrmMC1MainPage = True Then
            change_PanelContainerFrmMC1(stMC1MainPage) 'MAIN PAGE
            showForm(frmMC1MainPage)
            GetLoginDetails()
            GetPlanDetails()
        End If
    End Sub
    '// 

    '// CALLING FORM STOPPAGE SUBS
    Private Sub lblStoppageType_TextChanged(sender As Object, e As EventArgs) Handles lblStoppageType.TextChanged
        If modINfrmMC1StoppageType = True Then
            change_PanelContainerFrmMC1(stMC1StoppageType) 'STOPPAGE TYPE PAGE
            showForm(frmMC1StoppageType)
        End If
    End Sub
    '//

    '// CALLING FORM OPERATOR STOPPAGE SUBS
    Private Sub lblOperatorStoppage_TextChanged(sender As Object, e As EventArgs) Handles lblOperatorStoppage.TextChanged
        If modINfrmMC1OperatorStoppage = True Then
            change_PanelContainerFrmMC1(stMC1OperatorStoppage) 'OPERATOR STOPPAGE PAGE
            showForm(frmMC1OperatorStoppage)
        End If
    End Sub
    '//

    '// CALLING FORM MACHINE STOPPAGE SUBS
    Private Sub lblMachineStoppage_TextChanged(sender As Object, e As EventArgs) Handles lblMachineStoppage.TextChanged
        If modINfrmMC1MachineStoppage = True Then
            change_PanelContainerFrmMC1(stMC1MachineStoppage) 'MACHINE STOPPAGE PAGE
            showForm(frmMC1MachineStoppage)
        End If
    End Sub
    '// 

    '// CALLING FROM READY SUBS
    Private Sub lblReady_TextChanged(sender As Object, e As EventArgs) Handles lblReady.TextChanged
        If modINfrmMC1Ready = True Then
            change_PanelContainerFrmMC1(stMC1Ready) 'READY PAGE
            showForm(frmMC1Ready)
        End If
    End Sub
    '//

    '// CALLING FORM RUN SUBS
    Private Sub lblRun_TextChanged(sender As Object, e As EventArgs) Handles lblRun.TextChanged
        If modTestAutoModeMC1Flag = False Then
            If modINfrmMC1Run = True Then
                change_PanelContainerFrmMC1(stMC1Running) 'RUNNING PAGE
                showForm(frmMC1RUN)
            End If
        End If
    End Sub
    '//

    '// CALLING FORM QA STOPPAGE SUBS
    Private Sub lblQAStoppage_TextChanged(sender As Object, e As EventArgs) Handles lblQAStoppage.TextChanged
        If modINfrmMC1QAStoppage = True Then
            change_PanelContainerFrmMC1(stMC1QAStoppage) 'QA STOPPAGE
            showForm(frmMC1QAStoppage)
        End If
    End Sub
    '//

    '// CALLING FORM QA VERIFICATIONSUBS
    Private Sub lblQAVerification_TextChanged(sender As Object, e As EventArgs) Handles lblQAVerification.TextChanged
        If modINfrmMC1QAVerification = True Then
            change_PanelContainerFrmMC1(stMC1QAVerification) 'QA VERIFICATION
            showForm(frmMC1QAVerification)
        End If
    End Sub
    '//

    '// CALLING FORM TEST AUTO MODESUBS
    Private Sub lblTestAutoMode_TextChanged(sender As Object, e As EventArgs) Handles lblTestAutoMode.TextChanged
        If modINfrmMC1TestAutoMode = True Then
            change_PanelContainerFrmMC1(stMC1TestAutoMode) 'QA TEST AUTO MODE
            showForm(frmMC1TestAutoMode)
        End If
    End Sub
    '//

    '// CALLING ACKNOWLEDGE SUBS
    Private Sub lblAckFlag_TextChanged(sender As Object, e As EventArgs) Handles lblAckFlag.TextChanged
        If modMC1AcknowledgeFlag = True Then
            UpdateDowntimeAtAcknowledge()
            tmrRepairTime.Enabled = True
            tmrRepairTime.Start()
        End If
    End Sub
    '//

    '// CALLING OPERATOR STOPPAGE SAVED SUBS
    Private Sub lblMC1OptStoppageSaveFlag_TextChanged(sender As Object, e As EventArgs) Handles lblMC1OptStoppageSaveFlag.TextChanged
        If modMC1OptStoppageSaveFlag = True Then
            UpdateDowntimeAtStoppageSaved()
            tmrRepairTime.Stop()
            modMC1RepairTimer = 0
        End If
    End Sub
    '//

    '// CALLING MACHINE STOPPAGE SAVED SUBS
    Private Sub lblMC1MachStoppageSaveFlag_TextChanged(sender As Object, e As EventArgs) Handles lblMC1MachStoppageSaveFlag.TextChanged
        If modMC1MachineStoppageSaveFlag = True Then
            UpdateDowntimeAtStoppageSaved()
            tmrRepairTime.Stop()
            modMC1RepairTimer = 0
        End If
    End Sub
    '//

    '// CALLING SEND SAMPLE SUBS
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
    '//

    '// CALLING QA VERIFICATION FAIL SUBS
    Private Sub lblQAVerifyFailFlag_TextChanged(sender As Object, e As EventArgs) Handles lblQAVerifyFailFlag.TextChanged
        If modMC1QAVerifyFailFlag = True Then
            UpdateDowntimeAtQAVerifyFail()
            tmrQAVeriTime.Enabled = False
            tmrQAVeriTime.Stop()
            modMC1QAVeriTimer = 0
        End If
    End Sub
    '//

    '// CALLING QA VERIFICATION PASS SUBS
    Private Sub lblQAVerifyPassFlag_TextChanged(sender As Object, e As EventArgs) Handles lblQAVerifyPassFlag.TextChanged
        If modMC1QAVerifyPassFlag = True Then
            UpdateDowntimeAtQAVerifyPass()
            tmrQAVeriTime.Stop()
            modMC1QAVeriTimer = 0
        End If
    End Sub
    '//

    '// CALLING STOPPAGE SAVED FLAG SUBS
    Private Sub lblMC1QAStoppageFlag_TextChanged(sender As Object, e As EventArgs) Handles lblMC1QAStoppageSaveFlag.TextChanged
        If modMC1QAStoppageSaveFlag = True Then

        End If
    End Sub
    '//

    '// CALLING PLAN COMPLETE SUBS
    Private Sub lblPlanComplete_TextChanged(sender As Object, e As EventArgs) Handles lblPlanComplete.TextChanged
        PlanVsActualMonitoring()
        UpdateJOLoadedDetails_At_PlanComplete()
    End Sub
    '//

    '// CALLING FROM PLAN COMPLETE SUBS
    Private Sub lblInfmPlanComplete_TextChanged(sender As Object, e As EventArgs) Handles lblInfmPlanComplete.TextChanged
        If modINfrmMC1PlanComplete = True Then
            change_PanelContainerFrmMC1(stMC1PlanComplete) 'Plan Complete
            showForm(frmPlanComplete)
        End If
    End Sub
    '//

    '// CALLING FORM NEW JO SETUP SUBS
    Private Sub lblInfrmNewJOSetup_TextChanged(sender As Object, e As EventArgs) Handles lblInfrmNewJOSetup.TextChanged
        If modINfrmNewJOSetup = True Then
            change_PanelContainerFrmMC1(stMC1NewJOSetup) 'New JO Setup
            showForm(frmNewJOSetup)
        End If
    End Sub
    '//

    '// CALLING JO LOADED IS TRUE SUBS
    Private Sub lblJOLoadedisTrue_TextChanged(sender As Object, e As EventArgs) Handles lblJOLoadedisTrue.TextChanged
        If modJODetails_isTrue = True Then

        End If
    End Sub
    '//

    '// CALLING USER LOGGED IN IS TRUE SUBS
    Private Sub lblUserLoggedINisTrue_TextChanged(sender As Object, e As EventArgs) Handles lblUserLoggedINisTrue.TextChanged
        If modLoginDetails_isTrue = True Then

        End If
    End Sub
    '//

    '// CALLING USER LOGGEN IN AND JOLOADED CONFIRMATION SUBS
    Private Sub lblUserLoggedAndJOLoadedisTrue_TextChanged(sender As Object, e As EventArgs) Handles lblUserLoggedAndJOLoadedisTrue.TextChanged
        formSwitchPlsLogin_Stop_JOLoadeSetup()
    End Sub
    '//

    '// TEST AUTO MODE COUNTER
    Public Sub TestAutoModeCounter()
        If modTAM_NewJOLoaded_isTrue = False Then
            If modTestAutoModeMC1Flag = True And RxPLCM0 = True Then
                modMC1TestAutoModeCounter += 1
            End If
        End If

    End Sub
    '//

    '// SHIFT UPDATE AND SHIFT CODES
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

    '// ASSIGNING MACHINE ID TO SHIFT CODE
    Public Sub AssignMCIdToShiftCode(mcID As String)
        Select Case mcID
            Case "Machine 1"
                modshiftCode_MCid = modShiftCode + "MC1"
            Case "Machine 2"
                modshiftCode_MCid = modShiftCode + "MC2"
        End Select
    End Sub
    '//

    '// INSERTING DOWNTIME DETAILS
    Public Sub InsertDowntimeData()
        shiftUpdate()
        AssignMCIdToShiftCode(modSettingValMachineID)
        If modSQLPath IsNot Nothing Then
            If modLoginDetails_UserName Is Nothing Then
                modLoginDetails_UserName = ""
            End If
            Dim insDT As New clsInsertAllDowntimeDetails
            insDT.ShiftCOde = modshiftCode_MCid
            insDT.UserName = modLoginDetails_UserName
            insDT.UserID = modLoginDetails_UserID
            insDT.StartTime = modMC1StopDateandTime
            insDT.InsertDowntime()
        End If
    End Sub
    '//

    '// UPDATING DOWNTIME AT ACKNOWLEDGE
    Public Sub UpdateDowntimeAtAcknowledge()
        Dim upD8 As New clsUpdateDowntimeDetails_AtAck
        upD8.AckDate = modMC1AckDateandTime
        upD8.UpdateDT_At_Ack()
    End Sub
    '//

    '// COUNTERMEASURE CONDITION IF OPERATOR, MACHINE OR QA STOPPAGE
    Public Sub CountermeasureCondition(stoppageType As String)
        Select Case stoppageType
            Case "Operator"
                modCountermeasure = "n/a"
                modVerificationDateTime = "n/a"
            Case "Machine"
                modCountermeasure = modMC1Countermeasure
                modVerificationDateTime = "n/a"
            Case "Quality"
                modCountermeasure = modMC1Countermeasure
                modVerificationDateTime = Now()
        End Select
    End Sub

    '// UPDATING DOWNTIME AT STOPPAGE SAVE
    Public Sub UpdateDowntimeAtStoppageSaved()
        Dim upD8 As New clsUpdateDTDetails_StoppageSave
        upD8.DTType = modMC1StoppageType
        upD8.DTReason = modMC1StoppageReason
        CountermeasureCondition(modMC1StoppageType)
        upD8.DTCountermeasure = modCountermeasure
        upD8.EndTime = Now()
        upD8.TtlRepairTime = Math.Round((modMC1RepairTimer / 60), 4)
        upD8.ForQAVeri = modVerificationDateTime
        upD8.TtlFailFreq = modMC1FailCounters
        upD8.UpdateDowntimeAtStoppageSaved()
    End Sub
    '//

    '// UPDATING DOWNTIME AT MACHINE RUNNING
    Public Sub UpdateDowntimeAtMachineRunning()
        If modLoginDetails_UserName IsNot Nothing Then
            Dim upd8 As New clsUdateDTDetails_MCRunning
            upd8.UserName = modLoginDetails_UserName
            upd8.UserID = modLoginDetails_UserID
            upd8.RunTime = Now()
            upd8.TtlDT = Math.Round((modMC1StopTimer / 60), 4)
            upd8.DTStatus = "MC1DTComplete"
            upd8.Update_At_MachineRunning()
        End If
    End Sub
    '//

    '// UPDATING DOWNTIME AT QA VERIFICATION FAIL
    Public Sub UpdateDowntimeAtQAVerifyFail()
        Dim upd8 As New clsUpdateDTDetails_QAVeriFail
        upd8.TtlFailFreq = modMC1FailCounters
        upd8.UpdateDTFailFreq()
    End Sub
    '//

    '// UPDATING DOWNTIME AT QA VERIFCATION PASS
    Public Sub UpdateDowntimeAtQAVerifyPass()
        Dim upd8 As New clsUpdateDTDetails_QAVeriPass
        upd8.TtlVeri = Math.Round((modMC1QAVeriTimer / 60), 4)
        upd8.TtlFailFreq = modMC1FailCounters
        upd8.UpdateDTQAVerifyPass()
    End Sub
    '//

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
        'GetPlanDetails()
        'CheckForLoadJobOrders()
    End Sub

    '// COUNTING JO LOADED DETAILS BY MACHINE ID AND LOADED STAT
    Public Sub CheckForLoadedJobOrders()
        If modSettingValMachineID <> "" Then
            Dim count As New clsSelCountJOLoadedDetails_MCId_Loaded
            count.MachineId = modSettingValMachineID
            count.LoadStat = "Loaded"
            count.countLoadStatByMCIdAndLoaded()
            modJODetails_LoadeStat = count.CountLoaded
            cntJOLoaded = count.CountLoaded
        End If
    End Sub
    '// 

    '// GETTING PLAN DETAILS FROM JO LOADED DETAILS
    Public Sub GetPlanDetails()
        Try
            CheckForLoadedJobOrders()
            If modSettingValMachineID <> "" And modJODetails_LoadeStat >= 1 Then
                Dim selDetails As New clsSelAllJOLoadedDetails_MCId_LDStat
                selDetails.MachineId = modSettingValMachineID
                selDetails.LoadStat = "Loaded"
                selDetails.SellByMCIdAndLoadStat()
                modJODetails_JOPlan = selDetails.JOPlanQty
                modJODetails_JOCode = selDetails.JOCode
                modJODetails_PlanQty = selDetails.JOPlanQty
            End If
        Catch ex As Exception
            MessageBox.Show("No Job Order Loaded at Machine1!", "Get JO Plan Qty", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    '//

    '// COUNTING THE LOGGED IN USER ACCORDING TO MACHINE ID
    Public Sub CountUserLogged()
        Dim cntResult As New clsSelCountLoginDetails_UserName
        cntResult.MachineId = modSettingValMachineID
        cntResult.UserName = "none"
        cntResult.countUNByMachineId()
        cntLoggedUser = cntResult.cntUN
    End Sub
    '//

    '// GETTING LOGIN DETAILS FROM LOGIN DETAILS
    Public Sub GetLoginDetails()
        CountUserLogged()
        If modSettingValMachineID <> "" And cntLoggedUser <= 0 Then
            Dim getUser As New clsSelAllLoginDetails_MachineId
            getUser.MachineId = modSettingValMachineID
            getUser.getUserLoginDetails()
            modLoginDetails_UserName = getUser.UserName
            modLoginDetails_UserID = getUser.UserID
            modLoginDetails_AccLvl = getUser.AccessLvl
        End If
    End Sub
    '//

    '// PLAN VS ACTUAL OUTPUT MONITORING
    Public Sub PlanVsActualMonitoring()
        If RxPLCM14 = True Then
            modPlanCOmplete = True
            modINfrmMC1PlanComplete = True
        Else
            modPlanCOmplete = False
        End If
    End Sub
    '//

    '// COUNTING THE JO LOADED DETAILS ACCORDING TO MACHINE ID AND PRODUCTION STAT (In Progress)
    Public Sub CountProdnStat()
        Dim cntPrdStat As New clsSelCountJOLoadedDetails_MCIDnPrdnStat
        cntPrdStat.MachineId = modSettingValMachineID
        cntPrdStat.ProdnStat = "In Progress"
        cntPrdStat.countLoadStatByMCIdAndLoaded()
        cntProdnStat = cntPrdStat.CountPrdnStat
    End Sub
    '//

    '//UPDATE JO LOADED DETAILS AT ENDTIME OR PLAN COMPLETE
    Public Sub UpdateJOLoadedDetails_At_PlanComplete()
        If modSettingValMachineID IsNot Nothing Then
            CountProdnStat()
            If modSettingValMachineID <> "" And cntProdnStat >= 1 Then
                Dim upd8 As New clsUpdateJOLoadedDetails_AtEndTime
                upd8.MCId = modSettingValMachineID
                upd8.LoadStat = "Loaded"
                upd8.ProdnStat = "In Progress"
                upd8.EndTime = Now()
                upd8.NewProdnStat = "Plan Complete"
                upd8.TtlShots = D2002
                upd8.PN1Output = D2002 * D2014
                upd8.PN2Output = D2002 * D2015
                upd8.TtlRunTime = 0
                upd8.updateEndTimeDetails()
            End If
        End If
    End Sub
    '//

    Private Sub tmrMSTimerCounter_Tick(sender As Object, e As EventArgs) Handles tmrMSTimerCounter.Tick
        If modMSTimerStart = True Then
            modMSTimerCounter += 1
        End If
    End Sub

    Private Sub tmrFPBTimerCounter_Tick(sender As Object, e As EventArgs) Handles tmrFPBTimerCounter.Tick
        If modFPBTimerStart = True Then
            modFPBTimerCounter += 1
        End If
    End Sub

    Private Sub tmrMPTimerCounter_Tick(sender As Object, e As EventArgs) Handles tmrMPTimerCounter.Tick
        If modMPTimerStart = True Then
            modMassProTimerCounter += 1
        End If
    End Sub
End Class