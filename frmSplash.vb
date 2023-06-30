Imports System.Text
Imports System.Threading

Public Class frmSplash
    Dim cntJOLoaded As Integer
    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        modSQLPath = My.Settings.SQLPath
        modSetVal_IPAddress = My.Settings.IpAddress
        modSetVal_Por = My.Settings.Port
        modSettingValMachineID = My.Settings.MachineNo
        modJODetails_JOCode = My.Settings.JOCode
        MachineIdentification()
        GetPlanDetails()
        CheckingForNewDT()
    End Sub


    ''// GETTING PLAN DETAILS FROM JO LOADED DETAILS
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
    Public Sub GetPlanDetails()
        If moderrFlag_CheckLoadedJO_Splash = False Then
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
                moderrFlag_CheckLoadedJO_Splash = True
                MessageBox.Show(ex.Message, "SPLASH Checking Loaded Job Order...", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If DialogResult.OK = True Then
                    moderrFlag_CheckLoadedJO_Splash = False
                    Application.Exit()
                End If
            End Try
        End If

    End Sub
    '//

    '// CHECKING IF NEW DOWNTIME EXIST 
    Public Sub CheckingForNewDT()
        Dim Result As Integer
        Dim newDT As New clsCountDTStatus_MCNewStoppage
        newDT.DTStatus = modSetVal_NewStoppage
        newDT.MCID = modSettingValMachineID
        newDT.CountMCNewStoppage()
        Result = newDT.CountDT
        If Result <= 0 Then
            modDTDetails_NewDT_isTrue = False
        Else
            modDTDetails_NewDT_isTrue = True
        End If
    End Sub

    '//


    Private Sub tmrLoading_Tick(sender As Object, e As EventArgs) Handles tmrProgress.Tick
        Dim ProgPercent As String

        ProgressBar1.Value += 1
        ProgPercent = ProgressBar1.Value & "%"
        If ProgressBar1.Value <= 30 Then
            lblProgress.Text = "Initializing System...  " & ProgPercent
        ElseIf ProgressBar1.Value <= 40 Then
            lblProgress.Text = "Loading all Components and Settings...  " & ProgPercent
        ElseIf ProgressBar1.Value <= 50 Then
            lblProgress.Text = "SQL Path: " & modSQLPath & " " & ProgPercent
            Thread.Sleep(200)
        ElseIf ProgressBar1.Value <= 55 Then
            lblProgress.Text = "IP Address: " & modSetVal_IPAddress & " " & ProgPercent
            Thread.Sleep(200)
        ElseIf ProgressBar1.Value <= 60 Then
            lblProgress.Text = "Port: " & modSetVal_Por & " " & ProgPercent
            Thread.Sleep(200)
        ElseIf ProgressBar1.Value <= 65 Then
            lblProgress.Text = "Machine ID: " & modSettingValMachineID & " " & ProgPercent
            Thread.Sleep(200)
        ElseIf ProgressBar1.Value <= 70 Then
            lblProgress.Text = "Checking for Job Orders...  " & ProgPercent
        ElseIf ProgressBar1.Value <= 80 Then
            lblProgress.Text = "Please wait...  " & ProgPercent
        ElseIf ProgressBar1.Value <= 100 Then
            lblProgress.Text = "Opening SPS App...  " & ProgPercent
        ElseIf ProgressBar1.Value = 100 Then
            lblProgress.Text = "Welcome to SPS App...  " & ProgPercent
        End If

        If ProgressBar1.Value = 100 Then
            'Thread.Sleep(2000)
            tmrProgress.Dispose()
            Me.Hide()
            frmMainDash.ShowDialog()
            Me.Close()
        End If
    End Sub

    '// MACHINE NUMBER IDENTIFICATION
    Public Sub MachineIdentification()
        If modSettingValMachineID = "MC1" Then
            modSetVal_RXPLC_RunStop = RxPLCM0
            modSetVal_RxPLC_UNLogd_KIOSkLogd = RxPLCM3
            modSetVal_RxPLC_TestAutoModeFlag = RxPLCM12
            modSetVal_RxPLC_PlanComplete = RxPLCM14
            modSetVal_RxPLC_CounterInFlag = RxPLCM16
            modSetVal_RxPLC_QAStopKIOSK = RxPLCM20

            modSetVal_MCIdintification = "Machine 1"
            'lblMCNumber.Text = modSetVal_MCIdintification
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
            'lblMCNumber.Text = modSetVal_MCIdintification
            modSetVal_DTComplete = "MC2DTComplete"
            modSetVal_NewStoppage = "MC2NewStoppage"
        ElseIf modSettingValMachineID = "MC3" Then
            modSetVal_MCIdintification = "Machine 3"
            'lblMCNumber.Text = modSetVal_MCIdintification
            modSetVal_DTComplete = "MC3DTComplete"
            modSetVal_NewStoppage = "MC3NewStoppage"
        ElseIf modSettingValMachineID = "MC4" Then
            modSetVal_MCIdintification = "Machine 4"
            'lblMCNumber.Text = modSetVal_MCIdintification
            modSetVal_DTComplete = "MC4DTComplete"
            modSetVal_NewStoppage = "MC4NewStoppage"
        ElseIf modSettingValMachineID = "MC5" Then
            modSetVal_MCIdintification = "Machine 5"
            'lblMCNumber.Text = modSetVal_MCIdintification
            modSetVal_DTComplete = "MC5DTComplete"
            modSetVal_NewStoppage = "MC5NewStoppage"
        ElseIf modSettingValMachineID = "MC6" Then
            modSetVal_MCIdintification = "Machine 6"
            'lblMCNumber.Text = modSetVal_MCIdintification
            modSetVal_DTComplete = "MC6DTComplete"
            modSetVal_NewStoppage = "MC6NewStoppage"
        ElseIf modSettingValMachineID = "MC7" Then
            modSetVal_MCIdintification = "Machine 7"
            'lblMCNumber.Text = modSetVal_MCIdintification
            modSetVal_DTComplete = "MC7DTComplete"
            modSetVal_NewStoppage = "MC7NewStoppage"
        ElseIf modSettingValMachineID = "MC8" Then
            modSetVal_MCIdintification = "Machine 8"
            'lblMCNumber.Text = modSetVal_MCIdintification
            modSetVal_DTComplete = "MC8DTComplete"
            modSetVal_NewStoppage = "MC8NewStoppage"
        ElseIf modSettingValMachineID = "MC9" Then
            modSetVal_MCIdintification = "Machine 9"
            'lblMCNumber.Text = modSetVal_MCIdintification
            modSetVal_DTComplete = "MC9DTComplete"
            modSetVal_NewStoppage = "MC9NewStoppage"
        ElseIf modSettingValMachineID = "MC10" Then
            modSetVal_MCIdintification = "Machine 10"
            'lblMCNumber.Text = modSetVal_MCIdintification
            modSetVal_DTComplete = "MC10DTComplete"
            modSetVal_NewStoppage = "MC10NewStoppage"
        ElseIf modSettingValMachineID = "MC11" Then
            modSetVal_MCIdintification = "Machine 11"
            'lblMCNumber.Text = modSetVal_MCIdintification
            modSetVal_DTComplete = "MC11DTComplete"
            modSetVal_NewStoppage = "MC11NewStoppage"
        ElseIf modSettingValMachineID = "MC12" Then
            modSetVal_MCIdintification = "Machine 12"
            'lblMCNumber.Text = modSetVal_MCIdintification
            modSetVal_DTComplete = "MC12DTComplete"
            modSetVal_NewStoppage = "MC12NewStoppage"
        ElseIf modSettingValMachineID = "MC13" Then
            modSetVal_MCIdintification = "Machine 13"
            'lblMCNumber.Text = modSetVal_MCIdintification
            modSetVal_DTComplete = "MC13DTComplete"
            modSetVal_NewStoppage = "MC13NewStoppage"
        ElseIf modSettingValMachineID = "MC14" Then
            modSetVal_MCIdintification = "Machine 14"
            'lblMCNumber.Text = modSetVal_MCIdintification
            modSetVal_DTComplete = "MC14DTComplete"
            modSetVal_NewStoppage = "MC14NewStoppage"
        ElseIf modSettingValMachineID = "MC15" Then
            modSetVal_MCIdintification = "Machine 15"
            'lblMCNumber.Text = modSetVal_MCIdintification
            modSetVal_DTComplete = "MC15DTComplete"
            modSetVal_NewStoppage = "MC15NewStoppage"
        ElseIf modSettingValMachineID = "MC16" Then
            modSetVal_MCIdintification = "Machine 16"
            'lblMCNumber.Text = modSetVal_MCIdintification
            modSetVal_DTComplete = "MC16DTComplete"
            modSetVal_NewStoppage = "MC16NewStoppage"
        ElseIf modSettingValMachineID = "MC17" Then
            modSetVal_MCIdintification = "Machine 17"
            'lblMCNumber.Text = modSetVal_MCIdintification
            modSetVal_DTComplete = "MC17DTComplete"
            modSetVal_NewStoppage = "MC17NewStoppage"
        ElseIf modSettingValMachineID = "MC18" Then
            modSetVal_MCIdintification = "Machine 18"
            'lblMCNumber.Text = modSetVal_MCIdintification
            modSetVal_DTComplete = "MC18DTComplete"
            modSetVal_NewStoppage = "MC18NewStoppage"
        ElseIf modSettingValMachineID = "MC19" Then
            modSetVal_MCIdintification = "Machine 19"
            'lblMCNumber.Text = modSetVal_MCIdintification
            modSetVal_DTComplete = "MC19DTComplete"
            modSetVal_NewStoppage = "MC19NewStoppage"
        End If
    End Sub
End Class