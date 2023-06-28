Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Threading
Imports System.Windows.Documents
Imports FontAwesome.Sharp
Imports MS.Internal.WindowsRuntime.Windows
Imports EasyModbus

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

    Dim ModClient As New EasyModbus.ModbusClient

    '// FORM LOAD
    Private Sub frmMainDash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblStopDateTime.Text = My.Settings.stopTime
        modMC1StopDateandTime = My.Settings.stopTime
        modSettingValMachineID = My.Settings.MachineNo

        modMSTimerCounter = My.Settings.MSTimer
        modFPBTimerCounter = My.Settings.FBTimer
        modMassProTimerCounter = My.Settings.MassProTimer

        modSQLPath = My.Settings.SQLPath
        modSetVal_IPAddress = My.Settings.IpAddress
        modSetVal_Por = My.Settings.Port

        modMC1TestAutoModeCounter = 0

        GetPlanDetails()

        shiftUpdate()
        RxPLCM3_isFalse()
        checkLoginAndJOLoaded()
        ConnectToModbus()

        Me.CenterToScreen()
    End Sub
    '//
    Private Sub frmMainDash_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.stopTime = lblStopDateTime.Text
        My.Settings.SQLPath = modSQLPath

        My.Settings.MSTimer = modMSTimerCounter
        My.Settings.FBTimer = modFPBTimerCounter
        My.Settings.MassProTimer = modMassProTimerCounter
        My.Settings.TAMSetShots = modMC1TestAutoMOdeCounterSet
        My.Settings.MachineNo = modSettingValMachineID

        tmrRepairTime.Stop()
        tmrQAVeriTime.Stop()
    End Sub
    '// 

    '// FORM MAIN DASH REAL TIME STATUS CHECK TIMER
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrRealTimeCheck.Tick
        Label22.Text = RxPLCM1
        Label39.Text = modINfrmMC1Run
        Label40.Text = modMC1QASendSampleFlag
        Label38.Text = RxPLCM0
        Label37.Text = RxPLCM4
        MachineIdentification()
        comCheck()

        'MessageBox.Show("timer tick")
        shiftUpdate()
        lblAckTime.Text = modMC1RepairTimer
        lblQAVeriTimer.Text = modMC1QAVeriTimer
        lblFailCounter.Text = modMC1FailCounters
        checkLoginAndJOLoaded()
        TestAutoModeCounterSub()

        ReadHoldingRegs()
        readCoilsRegisters()
        MC1TestAutoModeFlag()
        MachineReadyFlag()
        MachineStopPlanComplete()
        InputCounterM16_M17_Via_X2_X5()

        TextChangeReferenceValues()
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
        lblRxPLCM0MC1.Text = modSetVal_RXPLC_RunStop 'Machine Run/Stop
        lblRxPLCM3MC1.Text = modSetVal_RxPLC_UNLogd_KIOSkLogd 'Machine Logged In and JO Loaded Flag
        lblRxPLCM12MC1.Text = modSetVal_RxPLC_TestAutoModeFlag 'Test Auto Mode Flag

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
        lblShiftCode.Text = modShiftCode & modSettingValMachineID
        lblMC1_D2002.Text = D2002
        lblMC1OptStoppageSaveFlag.Text = modMC1OptStoppageSaveFlag
        lblMC1MachStoppageSaveFlag.Text = modMC1MachineStoppageSaveFlag
        lblMC1QASendSampleFlag.Text = modMC1QASendSampleFlag
        lblQAVerifyFailFlag.Text = modMC1QAVerifyFailFlag
        lblQAVerifyPassFlag.Text = modMC1QAVerifyPassFlag
        lblMC1QAStoppageSaveFlag.Text = modMC1QAStoppageSaveFlag
        lblPlanComplete.Text = modSetVal_RxPLC_PlanComplete

        lblM16FlagisTrue.Text = M16Flag_isTrue

        lblJOLoadedisTrue.Text = modJODetails_isTrue
        lblUserLoggedINisTrue.Text = modLoginDetails_isTrue
        lblUserLoggedAndJOLoadedisTrue.Text = modLoginAndJOLoaded_isTrue

        lblNewDTisTrue.Text = modDTDetails_NewDT_isTrue
        'MessageBox.Show("timer tick")
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

    '// CALLING CONDITION SUB FOR SWITCHING FORMS (PLS LOGIN, STOP AND NEW JO SETUP, NO PLAN)
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

    '// CALLING RXPLCM0_M1 CONDSTIONS SUB
    Public Sub RxPLCM_Condtion()

    End Sub

    '//

    '// CALLING MACHINE RUN/STOP OPERATION SUBS Ver.2
    Public Sub MachineRunStopFlag_M0_M1()
        'MACHINE RUN
        If modSetVal_RXPLC_RunStop = True And modTAM_NewJOLoaded_isTrue = False _
            And modRxPLCM0_isON = False Then 'Interlock during NEW Job Order is Loaded.....
            modRxPLCM0_isON = True
            modRxPLCM0_isOFF = False

            PlanVsActualMonitoring()
            modDTDetails_NewDT_isTrue = False
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

            'MACHINE STOP
        ElseIf modSetVal_RXPLC_RunStop = False And modTAM_NewJOLoaded_isTrue = False _
            And modRxPLCM0_isOFF = False Then 'Interlock during NEW Job Order is Loaded.....
            modRxPLCM0_isOFF = True
            modRxPLCM0_isON = False

            tmrMC1StopTimer.Start()
            modINfrmMC1Run = False

            If modMC1StopDateandTime = Nothing Then
                modMC1StopDateandTime = Now()
            End If

            If modTestAutoModeMC1Flag = False Then
                modINfrmMC1Stop = True
            End If

            'Note:
            '1. KIOSK downtime must be prioritize before (InsertDowntimeData())
            '   during QA Machine Stop Flag from KIOSK...
            If modSetVal_RxPLC_QAStopKIOSK = True Then '2068 QA STOPPAGE TRIGGERED MC1 @KIOSK

            Else
                InsertDowntimeData()
            End If

        End If
    End Sub
    '//


    '// CALLING MACHINE RUN/STOP OPERATION SUBS Ver.1
    Private Sub lblRxPLCM0MC1_TextChanged(sender As Object, e As EventArgs) Handles lblRxPLCM0MC1.TextChanged
        'MessageBox.Show("TextChange")
        If modTAM_NewJOLoaded_isTrue = False Then 'Interlock during NEW Job Order is Loaded.....
            PlanVsActualMonitoring()

            'If modSetVal_RXPLC_RunStop = True Then 'Machine1 Start/Stop  (M0 of PLC)
            If modSetVal_RXPLC_RunStop = True Then 'Machine1 Start/Stop  (M0 of PLC)
                modDTDetails_NewDT_isTrue = False
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

                'Note:
                '1. KIOSK downtime must be prioritize before (InsertDowntimeData())
                '   during QA Machine Stop Flag from KIOSK...
                If modSetVal_RxPLC_QAStopKIOSK = True Then

                Else
                    InsertDowntimeData()
                End If

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
            'UpdateDowntimeAtQAVerifyFail()
            tmrQAVeriTime.Enabled = False
            tmrQAVeriTime.Stop()
            modMC1QAVeriTimer = 0
            modMC1QAVerifyFailFlag = False
        End If
    End Sub
    '//

    '// CALLING QA VERIFICATION PASS SUBS
    Private Sub lblQAVerifyPassFlag_TextChanged(sender As Object, e As EventArgs) Handles lblQAVerifyPassFlag.TextChanged
        If modMC1QAVerifyPassFlag = True Then
            'UpdateDowntimeAtQAVerifyPass()
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
        If modJODetails_isTrue = False Then
            modMPTimerStart = False
            modMSTimerCounter = 0
            modFPBTimerCounter = 0
            modFPBFailCounter = 0
            modMassProTimerCounter = 0
            modFPBuyOff_Done = False

            change_PanelContainerFrmMC1(stMC1NoPlan) 'No Plan
            showForm(frmMC1NoPlan)
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

    '//
    Private Sub lblM16FlagisTrue_TextAlignChanged(sender As Object, e As EventArgs) Handles lblM16FlagisTrue.TextAlignChanged
        'If M16Flag_isTrue = True Then
        '    modMC1TestAutoModeCounter += 1
        'End If
    End Sub
    '//

    '// TEST AUTO MODE COUNTER
    Public Sub TestAutoModeCounterSub()
        If modTestAutoModeMC1Flag = True And modSetVal_RXPLC_RunStop = True Then
            If modSetVal_RxPLC_CounterInFlag = True And M16Flag_isTrue = False Then
                M16Flag_isTrue = True
            ElseIf modSetVal_RxPLC_CounterInFlag = False Then
                M16Flag_isTrue = False
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
    'Public Sub AssignMCIdToShiftCode(mcID As String)
    '    Select Case mcID
    '        Case "Machine 1"
    '            modshiftCode_MCid = modShiftCode + "MC1"
    '        Case "Machine 2"
    '            modshiftCode_MCid = modShiftCode + "MC2"
    '    End Select
    'End Sub
    '//

    '// INSERTING DOWNTIME DETAILS
    Public Sub InsertDowntimeData()
        If modDTDetails_NewDT_isTrue = False Then
            shiftUpdate()
            'AssignMCIdToShiftCode(modSettingValMachineID)
            Dim UID As String
            Dim JCod As String
            If modLoginDetails_UserID = "" Then
                UID = "TBA"
            Else
                UID = modLoginDetails_UserID
            End If
            If modJODetails_JOCode = "" Then
                JCod = "TBA"
            Else
                JCod = modJODetails_JOCode
            End If
            If modSQLPath IsNot Nothing Then
                If modLoginDetails_UserName Is Nothing Then
                    modLoginDetails_UserName = ""
                End If
                Dim insDT As New clsInsertAllDowntimeDetails
                insDT.ShiftCOde = modShiftCode + modSettingValMachineID
                insDT.UserName = modLoginDetails_UserName
                insDT.UserID = UID
                insDT.StartTime = modMC1StopDateandTime
                insDT.DT_JOCode = JCod
                insDT.MCID = modSettingValMachineID
                insDT.InsertDowntime()
            End If
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
            upd8.DTStatus = modSetVal_DTComplete
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

    Private Sub Button1_Click(sender As Object, e As EventArgs)
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
        If modSetVal_RxPLC_PlanComplete = True Then
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
        If modSettingValMachineID IsNot Nothing And modPlanCOmplete = True Then
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

    '// TIMER COUNTERS USED DURING SETUP AT NEW JOB ORDER LAODING
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
    '//

    '// CONNECT TO PLC MODBUS (DELTA)
    Public Sub ConnectToModbus()
        ModClient.IPAddress = modSetVal_IPAddress
        ModClient.Port = modSetVal_Por
        ModClient.ConnectionTimeout = 3000
        ModClient.NumberOfRetries = 5

        Try
            ModClient.Connect()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Connecting to ModbusClient...", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    '//

    '// READING COIL REGISTERS OF DELTA PLC
    Public Sub readCoilsRegisters()
        Try
            'Modbuss address 2048 = M0 (Delta PLC) and so on for Coil registers
            Dim rxCoil() As Boolean = ModClient.ReadCoils(2048, 45)
            RxPLCM0 = rxCoil(0) '2048 MC1 ON/OFF FLAG (EXternal Triggered)
            RxPLCM1 = rxCoil(1) '2049 MC2 ON/OFF FLAG (External Triggered)
            RxPLCM2 = rxCoil(2) '2050
            RxPLCM3 = rxCoil(3) '2051 MC1 KIOSK Login & JO Fla
            RxPLCM4 = rxCoil(4) '2052 MC2 KIOSK Login & JO Flag
            RxPLCM5 = rxCoil(5) '2053
            RxPLCM6 = rxCoil(6) '2054 MC1 Machine Ready (Machine HMI)
            RxPLCM7 = rxCoil(7) '2055 MC2 Machine Ready (Machine HMI)
            RxPLCM8 = rxCoil(8) '2056
            RxPLCM9 = rxCoil(9) '2057 
            RxPLCM10 = rxCoil(10) '2058
            RxPLCM11 = rxCoil(11) '2059
            RxPLCM12 = rxCoil(12) '2060 MC1 Test Auto Mode Flag (Machine HMI)
            RxPLCM13 = rxCoil(13) '2061 MC2 Test Auto Mode Flag (Machine HMI)
            RxPLCM14 = rxCoil(14) '2062 MC1 Plan Complete
            RxPLCM15 = rxCoil(15) '2063 MC2 Plan Complete
            RxPLCM16 = rxCoil(16) '2064 MC1 CounterInputFlag (X2)
            RxPLCM17 = rxCoil(17) '2065 MC2 CounterInputFlag (X5)
            RxPLCM18 = rxCoil(18) '2066 TAM Counter Reached MC1
            RxPLCM19 = rxCoil(19) '2067 TAM Counter Reached MC2
            RxPLCM20 = rxCoil(20) '2068 QA STOPPAGE TRIGGERED MC1 @KIOSK
            RxPLCM21 = rxCoil(21) '2069 QA STOPPAGE TRIGGERED MC2 @KIOSK
            RxPLCM22 = rxCoil(22) '2070 PM STOPPAGE TRIGGERED MC1 @KIOSK
            RxPLCM23 = rxCoil(23) '2071 PM STOPPAGE TRIGGERED MC2 @KIOSK
            RxPLCM24 = rxCoil(24) '2072 TOOLING STOPPAGE TRIGGERED MC1 @KIOSK
            RxPLCM25 = rxCoil(25) '2073 TOOLING STOPPAGE TRIGGERED MC2 @KIOSK
            RxPLCM26 = rxCoil(26)
            RxPLCM27 = rxCoil(27)
            RxPLCM28 = rxCoil(28)
            RxPLCM29 = rxCoil(29)
            RxPLCM30 = rxCoil(30)
            RxPLCM31 = rxCoil(31)
            RxPLCM32 = rxCoil(32)
            RxPLCM33 = rxCoil(33)
            RxPLCM34 = rxCoil(34)
            RxPLCM35 = rxCoil(35)
            RxPLCM36 = rxCoil(36)
            RxPLCM37 = rxCoil(37)
            RxPLCM38 = rxCoil(38)
            RxPLCM39 = rxCoil(39)
            RxPLCM40 = rxCoil(40)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    '//

    '// READING HOLDING REGISTERS OF DELTA PLC
    Public Sub ReadHoldingRegs()
        'Modbuss address 6096 = D2000 (Delta PLC) and so on for holding registers
        Try
            Dim ReadValue() As Integer = ModClient.ReadHoldingRegisters(6096, 100)
            modComCheck = ReadValue(0) '6096

            'Double Word Declaration for Modbus 6098,6099 which is equal to D2002,D2003 of delta PLC
            Dim dwD2002(2) As Integer 'MC1 Machine Counter (Double Register)
            dwD2002(0) = ReadValue(2) '6098
            dwD2002(1) = ReadValue(3) '6099
            D2002 = ModbusClient.ConvertRegistersToInt(dwD2002, 0)

            Dim dwD2004(2) As Integer 'MC2 Machine Counter (Double Rregister)
            dwD2004(0) = ReadValue(4) '6100
            dwD2004(1) = ReadValue(5) '6101
            D2004 = ModbusClient.ConvertRegistersToInt(dwD2004, 0)

            Dim dwD2006(2) As Integer 'MC1 User ID (Double Register)
            dwD2006(0) = ReadValue(6) '6102
            dwD2006(1) = ReadValue(7) '6103
            D2006 = ModbusClient.ConvertRegistersToInt(dwD2006, 0)

            Dim dwD2008(2) As Integer 'MC2 User ID (Double Register)
            dwD2008(0) = ReadValue(8) '6104
            dwD2008(1) = ReadValue(9) '6105
            D2008 = ModbusClient.ConvertRegistersToInt(dwD2008, 0)

            Dim dwD2010(2) As Integer 'MC1 Plan Qty (Double Register)
            dwD2010(0) = ReadValue(10) '6106
            dwD2010(1) = ReadValue(11) '6107
            D2010 = ModbusClient.ConvertRegistersToInt(dwD2010, 0)

            Dim dwD2012(2) As Integer 'MC2 Plan Qty (Double Register)
            dwD2012(0) = ReadValue(12) '6108
            dwD2012(1) = ReadValue(13) '6109
            D2012 = ModbusClient.ConvertRegistersToInt(dwD2012, 0)

            Dim dwD2014(2) As Integer 'MC1 Actual Counter (Double Register)
            dwD2014(0) = ReadValue(14) '6110
            dwD2014(1) = ReadValue(15) '6111
            D2014 = ModbusClient.ConvertRegistersToInt(dwD2014, 0)

            Dim dwD2016(2) As Integer 'MC2 Actual Counter (Double Register)
            dwD2016(0) = ReadValue(16) '6112
            dwD2016(1) = ReadValue(17) '6113
            D2016 = ModbusClient.ConvertRegistersToInt(dwD2016, 0)

            D2018 = ReadValue(18) '6114 MC1JOCode1
            D2019 = ReadValue(19) '6115 MC1JOCode2
            D2020 = ReadValue(20) '6116 MC1JOCode3
            D2021 = ReadValue(21) '6117 MC1JOCode4
            D2022 = ReadValue(22) '6118 MC1JOCode5
            D2023 = ReadValue(23) '6119 MC1JOCode6
            D2024 = ReadValue(24) '6120 Empty
            D2025 = ReadValue(25) '6121 MC2JOCode1
            D2026 = ReadValue(26) '6122 MC2JOCode2
            D2027 = ReadValue(27) '6123 MC2JOCode3
            D2028 = ReadValue(28) '6124 MC2JOCode4
            D2029 = ReadValue(29) '6125 MC2JOCode5
            D2030 = ReadValue(30) '6126 MC2JOCode6
            D2031 = ReadValue(31) '6127 EMPTY

            Dim dwD2032(2) As Integer ''MC1 Total Counter (Double Register)
            dwD2032(0) = ReadValue(32) '6128
            dwD2032(1) = ReadValue(33) '6129 
            D2032 = ModbusClient.ConvertRegistersToInt(dwD2032, 0)

            Dim dwD2034(2) As Integer ''MC2 Total Counter (Double Register)
            dwD2034(0) = ReadValue(34) '6130 
            dwD2034(1) = ReadValue(35) '6131
            D2034 = ModbusClient.ConvertRegistersToInt(dwD2034, 0)

            D2036 = ReadValue(36) '6132
            D2037 = ReadValue(37) '6133
            D2038 = ReadValue(38) '6134 
            D2039 = ReadValue(39) '6135 
            D2040 = ReadValue(40) '6136

            'lblRx4.Text = (ReadValue(5) + ReadValue(4)) * 65535.0F
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    '//

    '// MACHINE STOP AT PLAN COMPLETE
    Public Sub MachineStopPlanComplete()
        If modPlanCOmplete = True Then
            modMSTimerStart = False
            ModClient.WriteSingleCoil(2348, False) 'PLC M300  MC1 OFF 
        End If
    End Sub
    '//

    '// MACHINE READY FLAG
    Public Sub MachineReadyFlag()
        If ModClient.Connected = True Then
            If modSettingValMachineID = "MC1" Then
                If modINfrmMC1Ready = True Then
                    ModClient.WriteSingleCoil(2054, True) 'MC6 ON
                ElseIf modINfrmMC1Run = True Then
                    ModClient.WriteSingleCoil(2054, False) 'MC6 OFF
                Else
                    ModClient.WriteSingleCoil(2054, False) 'MC6 OFF
                End If
            ElseIf modSettingValMachineID = "MC2" Then
                If modINfrmMC1Ready = True Then
                    ModClient.WriteSingleCoil(2055, True) 'MC7 ON
                ElseIf modINfrmMC1Run = True Then
                    ModClient.WriteSingleCoil(2055, False) 'MC7 OFF
                Else
                    ModClient.WriteSingleCoil(2055, False) 'MC7 OFF
                End If
            End If

        End If
    End Sub
    '//

    '// TEST AUTO MODE FLAG
    Public Sub MC1TestAutoModeFlag()
        If ModClient.Connected = True Then
            If modSettingValMachineID = "MC1" Then
                If modTestAutoModeMC1Flag = True Then
                    ModClient.WriteSingleCoil(2060, True) 'MC12 ON
                Else
                    ModClient.WriteSingleCoil(2060, False) 'MC12 OFF
                End If
            ElseIf modSettingValMachineID = "MC2" Then
                If modTestAutoModeMC1Flag = True Then
                    ModClient.WriteSingleCoil(2061, True) 'MC12 ON
                Else
                    ModClient.WriteSingleCoil(2061, False) 'MC12 OFF
                End If
            End If

        End If
    End Sub
    '//

    '// INPUT COUNTER FLAG FOR TAM COUNTER
    Public Sub InputCounterM16_M17_Via_X2_X5()
        If ModClient.Connected = True Then
            If modSetVal_RxPLC_CounterInFlag = True And M16Flag_isTrue = True Then
                M16Flag_isTrue = False
                ModClient.WriteSingleCoil(2064, False) '2064 M16  MC1 CounterInputFlag (X2)
                modMC1TestAutoModeCounter += 1
            End If
        End If
    End Sub
    '//

    '// MACHINE NUMBER IDENTIFICATION
    Public Sub MachineIdentification()
        If modSettingValMachineID = "MC1" Then
            modSetVal_RXPLC_RunStop = RxPLCM0
            modSetVal_RxPLC_UNLogd_KIOSkLogd = RxPLCM3
            modSetVal_RxPLC_TestAutoModeFlag = RxPLCM12
            modSetVal_RxPLC_PlanComplete = RxPLCM14
            modSetVal_RxPLC_CounterInFlag = RxPLCM16
            modSetVal_RxPLC_QAStopKIOSK = RxPLCM20
            modSetVal_TAMFlag = modTestAutoModeMC1Flag

            modSetVal_MCIdintification = "Machine 1"
            lblMCNumber.Text = modSetVal_MCIdintification
            modSetVal_DTComplete = "MC1DTComplete"
            modSetVal_NewStoppage = "MC1NewStoppage"
        ElseIf modSettingValMachineID = "MC2" Then
            modSetVal_RXPLC_RunStop = RxPLCM1
            modSetVal_RxPLC_UNLogd_KIOSkLogd = RxPLCM4
            modSetVal_RxPLC_TestAutoModeFlag = RxPLCM13
            modSetVal_RxPLC_PlanComplete = RxPLCM15
            modSetVal_RxPLC_CounterInFlag = RxPLCM17
            modSetVal_RxPLC_QAStopKIOSK = RxPLCM21

            modSetVal_MCIdintification = "Machine 2"
            lblMCNumber.Text = modSetVal_MCIdintification
            modSetVal_DTComplete = "MC2DTComplete"
            modSetVal_NewStoppage = "MC2NewStoppage"
        ElseIf modSettingValMachineID = "MC3" Then
            modSetVal_MCIdintification = "Machine 3"
            lblMCNumber.Text = modSetVal_MCIdintification
            modSetVal_DTComplete = "MC3DTComplete"
            modSetVal_NewStoppage = "MC3NewStoppage"
        ElseIf modSettingValMachineID = "MC4" Then
            modSetVal_MCIdintification = "Machine 4"
            lblMCNumber.Text = modSetVal_MCIdintification
            modSetVal_DTComplete = "MC4DTComplete"
            modSetVal_NewStoppage = "MC4NewStoppage"
        ElseIf modSettingValMachineID = "MC5" Then
            modSetVal_MCIdintification = "Machine 5"
            lblMCNumber.Text = modSetVal_MCIdintification
            modSetVal_DTComplete = "MC5DTComplete"
            modSetVal_NewStoppage = "MC5NewStoppage"
        ElseIf modSettingValMachineID = "MC6" Then
            modSetVal_MCIdintification = "Machine 6"
            lblMCNumber.Text = modSetVal_MCIdintification
            modSetVal_DTComplete = "MC6DTComplete"
            modSetVal_NewStoppage = "MC6NewStoppage"
        ElseIf modSettingValMachineID = "MC7" Then
            modSetVal_MCIdintification = "Machine 7"
            lblMCNumber.Text = modSetVal_MCIdintification
            modSetVal_DTComplete = "MC7DTComplete"
            modSetVal_NewStoppage = "MC7NewStoppage"
        ElseIf modSettingValMachineID = "MC8" Then
            modSetVal_MCIdintification = "Machine 8"
            lblMCNumber.Text = modSetVal_MCIdintification
            modSetVal_DTComplete = "MC8DTComplete"
            modSetVal_NewStoppage = "MC8NewStoppage"
        ElseIf modSettingValMachineID = "MC9" Then
            modSetVal_MCIdintification = "Machine 9"
            lblMCNumber.Text = modSetVal_MCIdintification
            modSetVal_DTComplete = "MC9DTComplete"
            modSetVal_NewStoppage = "MC9NewStoppage"
        ElseIf modSettingValMachineID = "MC10" Then
            modSetVal_MCIdintification = "Machine 10"
            lblMCNumber.Text = modSetVal_MCIdintification
            modSetVal_DTComplete = "MC10DTComplete"
            modSetVal_NewStoppage = "MC10NewStoppage"
        ElseIf modSettingValMachineID = "MC11" Then
            modSetVal_MCIdintification = "Machine 11"
            lblMCNumber.Text = modSetVal_MCIdintification
            modSetVal_DTComplete = "MC11DTComplete"
            modSetVal_NewStoppage = "MC11NewStoppage"
        ElseIf modSettingValMachineID = "MC12" Then
            modSetVal_MCIdintification = "Machine 12"
            lblMCNumber.Text = modSetVal_MCIdintification
            modSetVal_DTComplete = "MC12DTComplete"
            modSetVal_NewStoppage = "MC12NewStoppage"
        ElseIf modSettingValMachineID = "MC13" Then
            modSetVal_MCIdintification = "Machine 13"
            lblMCNumber.Text = modSetVal_MCIdintification
            modSetVal_DTComplete = "MC13DTComplete"
            modSetVal_NewStoppage = "MC13NewStoppage"
        ElseIf modSettingValMachineID = "MC14" Then
            modSetVal_MCIdintification = "Machine 14"
            lblMCNumber.Text = modSetVal_MCIdintification
            modSetVal_DTComplete = "MC14DTComplete"
            modSetVal_NewStoppage = "MC14NewStoppage"
        ElseIf modSettingValMachineID = "MC15" Then
            modSetVal_MCIdintification = "Machine 15"
            lblMCNumber.Text = modSetVal_MCIdintification
            modSetVal_DTComplete = "MC15DTComplete"
            modSetVal_NewStoppage = "MC15NewStoppage"
        ElseIf modSettingValMachineID = "MC16" Then
            modSetVal_MCIdintification = "Machine 16"
            lblMCNumber.Text = modSetVal_MCIdintification
            modSetVal_DTComplete = "MC16DTComplete"
            modSetVal_NewStoppage = "MC16NewStoppage"
        ElseIf modSettingValMachineID = "MC17" Then
            modSetVal_MCIdintification = "Machine 17"
            lblMCNumber.Text = modSetVal_MCIdintification
            modSetVal_DTComplete = "MC17DTComplete"
            modSetVal_NewStoppage = "MC17NewStoppage"
        ElseIf modSettingValMachineID = "MC18" Then
            modSetVal_MCIdintification = "Machine 18"
            lblMCNumber.Text = modSetVal_MCIdintification
            modSetVal_DTComplete = "MC18DTComplete"
            modSetVal_NewStoppage = "MC18NewStoppage"
        ElseIf modSettingValMachineID = "MC19" Then
            modSetVal_MCIdintification = "Machine 19"
            lblMCNumber.Text = modSetVal_MCIdintification
            modSetVal_DTComplete = "MC19DTComplete"
            modSetVal_NewStoppage = "MC19NewStoppage"
        End If
    End Sub

    '// CHECK IF HAVE PLAN
    'Public Sub CheckIfHavePlan()
    '    If modSettingValMachineID = "MC1" Then
    '        Dim MC1PlanCheck As New clsCheckPlan
    '        MC1PlanCheck.MCId = "MC1"
    '        MC1PlanCheck.JCode = modJODetails_JOCode
    '        MC1PlanCheck.
    '    End If
    'End Sub

End Class