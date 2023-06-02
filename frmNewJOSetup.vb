Imports System.ComponentModel
Imports System.Net.Security

Public Class frmNewJOSetup
    Private Sub frmNewJOSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modINfrmNewJOSetup = True

        frmMC1PlsLogin.Close()
        btnMS_TAM_ONOFF.Enabled = False

        If modMSTimerStart = True Then
            MSbutton_INPROGStats()
        End If
        If modFPBTimerStart = True Then
            MSbutton_INPROGStats()
            btnMS_StartStop.Text = "DONE"
            FPBButtonForQACheckStat()
        End If


        FORQAVeriResult_Failed()
        FORQAVeriResult_Pass()

        FORQAVeriResult_Failed()
    End Sub

    Private Sub frmNewJOSetup_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        modINfrmNewJOSetup = False
    End Sub

    Private Sub frmNewJOSetup_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.MSTimer = modMSTimerCounter
        My.Settings.FBTimer = modFPBTimerCounter
        My.Settings.MassProTimer = modMassProTimerCounter
    End Sub
    '// REALTIME CHECK TIMER
    Private Sub tmrRealTimeCheck_Tick(sender As Object, e As EventArgs) Handles tmrRealTimeCheck.Tick
        Dim MSTimer As Decimal = Math.Round((modMSTimerCounter / 60), 3)
        Dim FPBTimer As Decimal = Math.Round((modFPBTimerCounter / 60), 3)
        Dim MSProTimer As Decimal = Math.Round((modMassProTimerCounter / 60), 3)
        lblMSTimeCounter.Text = MSTimer
        lblFPBTimeCounter.Text = FPBTimer
        lblMPTimeCounter.Text = MSProTimer
        lblFailCounter.Text = modFPBFailCounter

        TAMButtonEnableDisable()
        MSButtonEnableDisable()
        FPBButtonEnableDisable()
        BtnMassPro_EnabelDisable()
    End Sub
    '//

    Public Sub MSButtonEnableDisable()
        If btnFPB_StartStop.Text = "FOR QA CHECK" Or btnFPB_StartStop.Text = "QA PASS!" Then
            btnMS_StartStop.Enabled = False
        Else
            btnMS_StartStop.Enabled = True
        End If
    End Sub

    '//
    Private Sub btnMS_StartStop_Click(sender As Object, e As EventArgs) Handles btnMS_StartStop.Click
        If modMSTimerStart = False Then
            MSbutton_INPROGStats()
            modMSTimerStart = True
        ElseIf modMSTimerStart = True Then
            MSbutton_STOPStat()
            modMSTimerStart = False
        End If
    End Sub
    Public Sub MSbutton_INPROGStats()
        btnMS_StartStop.BackColor = Color.Green
        btnMS_StartStop.ForeColor = Color.White
        btnMS_StartStop.Text = "IN PROG"
    End Sub
    Public Sub MSbutton_STOPStat()
        btnMS_StartStop.BackColor = Color.DarkRed
        btnMS_StartStop.ForeColor = Color.White
        btnMS_StartStop.Text = "STOP"
    End Sub
    '//

    '//
    Public Sub TAMButtonEnableDisable()
        If modMSTimerStart = True Then
            btnMS_TAM_ONOFF.Enabled = True
        Else
            btnMS_TAM_ONOFF.Enabled = False
        End If
    End Sub
    Private Sub btnMS_TAM_ONOFF_Click(sender As Object, e As EventArgs) Handles btnMS_TAM_ONOFF.Click
        modTAM_NewJOLoaded_isTrue = True
        modINfrmMC1TestAutoMode = True
        Me.Close()
    End Sub
    '//

    Public Sub FPBButtonEnableDisable()
        If (btnMS_StartStop.Text = "IN PROG" Or btnMS_StartStop.Text = "DONE") And btnFPB_StartStop.Text <> "QA PASS!" Then
            btnFPB_StartStop.Enabled = True
        Else
            btnFPB_StartStop.Enabled = False
        End If
    End Sub

    '//
    Private Sub btnFPB_StartStop_Click(sender As Object, e As EventArgs) Handles btnFPB_StartStop.Click
        If modFPBTimerStart = False Then
            FPBButtonForQACheckStat()
            btnMS_StartStop.Text = "DONE"
            modMSTimerStart = False
            modFPBTimerStart = True
            modForQA_NewJOLoaded_isTrue = True
            modINfrmMC1QAVerification = True
            Me.Close()
        ElseIf modFPBTimerStart = True Then
            FPBButtonSendSampleStat()
            modFPBTimerStart = False
            modMSTimerCounter = modMSTimerCounter + modFPBTimerCounter
            modFPBTimerCounter = 0
            MSbutton_INPROGStats()
            modMSTimerStart = True
        End If
    End Sub
    Public Sub FPBButtonForQACheckStat()
        btnFPB_StartStop.BackColor = Color.Green
        btnFPB_StartStop.ForeColor = Color.White
        btnFPB_StartStop.Text = "FOR QA CHECK"
    End Sub
    Public Sub FPBButtonSendSampleStat()
        btnFPB_StartStop.BackColor = Color.DarkRed
        btnFPB_StartStop.ForeColor = Color.White
        btnFPB_StartStop.Text = "SEND SAMPLE"
    End Sub

    Private Sub btnByPass_Click(sender As Object, e As EventArgs) Handles btnByPass.Click
        modFPBuyOff_Done = True
        modINfrmMC1PlsLogin = True
        Me.Close()
    End Sub

    Public Sub FORQAVeriResult_Failed()
        If modForQAFail_NewJOLoaded_isTrue = True Then
            modForQAFail_NewJOLoaded_isTrue = False
            modFPBFailCounter += 1

            FPBButtonSendSampleStat()
            modFPBTimerStart = False
            modMSTimerCounter = modMSTimerCounter + modFPBTimerCounter
            modFPBTimerCounter = 0
            MSbutton_INPROGStats()
            modMSTimerStart = True
        End If
    End Sub

    Public Sub FORQAVeriResult_Pass()
        If modForQAPass_NewJOLoaded_isTrue = True Then
            modForQAPass_NewJOLoaded_isTrue = False
            btnFPB_StartStop.Text = "QA PASS!"
            modFPBTimerStart = False
            modMPTimerStart = True
        End If
    End Sub


    Public Sub BtnMassPro_EnabelDisable()
        If btnFPB_StartStop.Text = "QA PASS!" Then
            btnMassPro.Enabled = True
        Else
            btnMassPro.Enabled = False
        End If
    End Sub
    Private Sub btnMassPro_Click(sender As Object, e As EventArgs) Handles btnMassPro.Click
        modFPBuyOff_Done = True
        modInfrmMC1MainPage = True
        Me.Close()
    End Sub
End Class