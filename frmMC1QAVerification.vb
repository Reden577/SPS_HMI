Public Class frmMC1QAVerification

    '//
    Private Sub frmMC1QAVerification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modINfrmMC1QAVerification = True
        frmMC1QAStoppage.Close()
        lblFailedCounter.Text = modMC1FailCounters

        LabelVisibility()
        CheckLoggedQualityStoppage()
    End Sub
    Private Sub frmMC1QAVerification_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        modINfrmMC1QAVerification = False
    End Sub
    Private Sub btnMainPage_Click(sender As Object, e As EventArgs) Handles btnMainPage.Click
        If modForQA_NewJOLoaded_isTrue = False Then '<- Interlock during new Job Order is loaded
            modInfrmMC1MainPage = True
            Me.Close()
        Else
            'modINfrmNewJOSetup = True
            'Me.Close()
        End If
    End Sub

    Private Sub btnPass_Click(sender As Object, e As EventArgs) Handles btnPass.Click
        If modForQA_NewJOLoaded_isTrue = False Then '<- Interlock during new Job Order is loaded
            modMC1QAVerifyPassFlag = True
            Update_AT_QAPass()
            modINfrmMC1Ready = True
            Me.Close()
        Else
            modForQAPass_NewJOLoaded_isTrue = True
            modForQA_NewJOLoaded_isTrue = False
            modINfrmNewJOSetup = True
            Me.Close()
        End If

    End Sub

    '// UPDATE QA PASS
    Public Sub Update_AT_QAPass()
        If modMC1QAVerifyPassFlag = True Then
            UpdateDowntimeAtQAVerifyPass()
            'tmrQAVeriTime.Stop()
            'modMC1QAVeriTimer = 0
        End If
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

    Private Sub btnFail_Click(sender As Object, e As EventArgs) Handles btnFail.Click
        modMC1QASendSampleFlag = False

        If modForQA_NewJOLoaded_isTrue = False Then '<- Interlock during new Job Order is loaded
            modMC1FailCounters = modMC1FailCounters + 1
            modMC1QAVerifyFailFlag = True
            UpdateDT_At_QAFail()
            modINfrmMC1QAStoppage = True
            Me.Close()
        Else
            modForQAFail_NewJOLoaded_isTrue = True
            modINfrmNewJOSetup = True
            Me.Close()
        End If

    End Sub

    '// UPDATE QA FAIL
    Public Sub UpdateDT_At_QAFail()
        If modMC1QAVerifyFailFlag = True Then
            UpdateDowntimeAtQAVerifyFail()
            'tmrQAVeriTime.Enabled = False
            'tmrQAVeriTime.Stop()
            'modMC1QAVeriTimer = 0
            'modMC1QAVerifyFailFlag = False
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

    Private Sub tmrRealTimeCheck_Tick(sender As Object, e As EventArgs) Handles tmrRealTimeCheck.Tick
        lblFailedCounter.Text = modMC1FailCounters
        If modForQA_NewJOLoaded_isTrue = False Then '<- Interlock during new Job Order is loaded
            Dim StopTimer As String
            StopTimer = Math.Round((modMC1StopTimer / 60), 3)
            lblElapsTimeMC1.Text = StopTimer & " " & "mins"
        End If
        CheckingFailFreqValueChange()
        CheckPassQAVerificationAT_KIOSK()
    End Sub

    Public Sub LabelVisibility()
        If modForQA_NewJOLoaded_isTrue = True Then '<- Interlock during new Job Order is loaded
            Label1.Visible = False
            lblElapsTimeMC1.Visible = False
            lblFailedCounter.Visible = False
            lblFPB_label.Visible = True
        Else
            Label1.Visible = True
            lblElapsTimeMC1.Visible = True
            lblFailedCounter.Visible = True
            lblFPB_label.Visible = False
        End If
    End Sub

    '// CHECKING AND LOADING QUALITY STOPPAGE DETAILS
    Public Sub CheckLoggedQualityStoppage()
        Dim result As Integer
        Dim cnt As New clsCountDTType_byDTStatusMCId
        cnt.DTType = "Quality"
        cnt.DTStatus = modSetVal_NewStoppage
        cnt.MCID = modSettingValMachineID
        cnt.CountDTType()
        result = cnt.cntDTtype

        If result >= 1 Then
            Dim sel As New clsSelDTReasonCMeasure
            sel.DTType = "Quality"
            sel.MCID = modSettingValMachineID
            sel.DTStatus = modSetVal_NewStoppage
            sel.SelDTReason_CMeasure()
            modMC1FailCounters = sel.TtlFailFreq
        End If
    End Sub
    '//

    '// CHECKING CHANGES OF FAIL FREQ VALUE NEW > OLD
    Public Sub CheckingFailFreqValueChange()
        Dim ff As Integer
        Dim FailFreq As New clsGetQAFailFreq
        FailFreq.QAFailFreq_MCId = modSettingValMachineID
        FailFreq.QAFailFreq_DTStatus = modSetVal_NewStoppage
        FailFreq.QAFailFreq_DTType = "Quality"
        FailFreq.GetQAFailFreq()
        ff = FailFreq.QAFailFreq_FailFreq

        If ff > CInt(lblFailedCounter.Text) Then
            modINfrmMC1QAStoppage = True
            Me.Close()
        End If
    End Sub
    '//

    '// CHECKING QA PASS VERIFICATION FROM KIOSK SIDE
    Public Sub CheckPassQAVerificationAT_KIOSK()
        Dim qaveri As String
        Dim ttlqaveri As Integer
        Dim chk As New clsGetForQAVeriNTtlQAVeri
        chk.DTDetails_sfDTType = "Quality"
        chk.DTDetails_sfDTStatus = modSetVal_NewStoppage
        chk.DTDetails_sfMCId = modSettingValMachineID
        chk.GetForQAVeri_N_TtlQAVeri()
        qaveri = chk.DTDetails_sfForQAVeri
        ttlqaveri = chk.DTDetails_iTtlQAVeri

        If qaveri <> "" And qaveri <> "TBA" And ttlqaveri = 1 Then
            Update_AT_QAPass()
            modINfrmMC1Ready = True
            Me.Close()
        End If
    End Sub
    '//
End Class