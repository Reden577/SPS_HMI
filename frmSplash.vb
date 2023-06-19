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

    '// CHECKING IF NEW DOWNTIME EXIST 
    Public Sub CheckingForNewDT()
        Dim Result As Integer
        Dim newDT As New clsCountDTStatus_MCNewStoppage
        newDT.DTStatus = "MC1NewStoppage"
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
End Class