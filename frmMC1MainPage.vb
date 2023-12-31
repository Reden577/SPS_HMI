﻿Imports System.Data.SqlClient

Public Class frmMC1MainPage
    Dim displayTime As Integer
    Private Sub frmMCMainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MessageBox.Show("MainPage")
        modInfrmMC1MainPage = True
        frmMC1PlsLogin.Close()
        frmMC1STOP.Close()
        frmMC1StoppageType.Close()
        frmMC1OperatorStoppage.Close()
        frmMC1MachineStoppage.Close()
        frmMC1RUN.Close()
        frmMC1QAStoppage.Close()
        frmMC1QAVerification.Close()
        frmMC1TestAutoMode.Close()
        frmPlanComplete.Close()
        tmrDisplayON.Start()

        CheckExistingQAStop()
    End Sub

    Private Sub frmMC1MainPage_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        modInfrmMC1MainPage = False
        tmrDisplayON.Stop()
    End Sub

    Public Sub LoadDetailsMC1()
        If modSettingValMachineID = "MC1" Then
            lblJODetailsUN.Text = modLoginDetails_UserName
            lblPlanQty.Text = modJODetails_PlanQty
            lblActualQty.Text = D2002 * D2014
            lblJobOrderCode.Text = modJODetails_JOCode
            lblUserID.Text = modLoginDetails_UserID
        End If
        If modSettingValMachineID = "MC2" Then
            lblJODetailsUN.Text = modLoginDetails_UserName
            lblPlanQty.Text = modJODetails_PlanQty
            lblActualQty.Text = D2004 * D2016
            lblJobOrderCode.Text = modJODetails_JOCode
            lblUserID.Text = modLoginDetails_UserID
        End If

    End Sub

    Public Sub stoppageBtnsEnableDisable()
        If modSetVal_RXPLC_RunStop = True Then
            picStoppage.Enabled = False
            picQAStoppage.Enabled = False
            picTestAutoMode.Enabled = False
        Else
            picQAStoppage.Enabled = True
            picTestAutoMode.Enabled = True
        End If
    End Sub

    Private Sub tmrRealTimeCheck_Tick(sender As Object, e As EventArgs) Handles tmrRealTimeCheck.Tick
        LoadDetailsMC1()
        displaytimeCheck()
        stoppageBtnsEnableDisable()
    End Sub

    Private Sub tmrDisplayON_Tick(sender As Object, e As EventArgs) Handles tmrDisplayON.Tick
        displayTime = displayTime + 1
    End Sub

    Public Sub displaytimeCheck()
        If modTAM_NewJOLoaded_isTrue = False Then '<-Interlock during NEw Job Order is loaded
            lblDisplayON.Text = displayTime
            If displayTime >= 10 Then
                If modSetVal_RXPLC_RunStop = False And modMC1QAStoppageSaveFlag = False _
                    And modTestAutoModeMC1Flag = False And modSetVal_RxPLC_PlanComplete = False Then
                    modINfrmMC1Stop = True
                    Me.Close()
                ElseIf modSetVal_RXPLC_RunStop = False And modMC1QAStoppageSaveFlag = True _
                    And modTestAutoModeMC1Flag = False And modSetVal_RxPLC_PlanComplete = False Then
                    modINfrmMC1QAVerification = True
                    Me.Close()
                ElseIf modSetVal_RXPLC_RunStop = False And (modMC1QAStoppageSaveFlag = True Or modMC1QAStoppageSaveFlag = False) _
                    And modTestAutoModeMC1Flag = True And modSetVal_RxPLC_PlanComplete = False Then
                    modINfrmMC1TestAutoMode = True
                    Me.Close()
                ElseIf modSetVal_RxPLC_PlanComplete = True Then
                    modINfrmMC1PlanComplete = True
                    Me.Close()
                Else
                    modINfrmMC1Run = True
                    Me.Close()
                End If
            End If
        End If

    End Sub

    Private Sub picStoppage_Click(sender As Object, e As EventArgs) Handles picStoppage.Click

        modINfrmMC1StoppageType = True
        Me.Close()
    End Sub

    Private Sub picQAStoppage_Click(sender As Object, e As EventArgs) Handles picQAStoppage.Click
        If modMC1QAStoppageSaveFlag = True Then
            modINfrmMC1QAVerification = True
            Me.Close()
        Else
            modINfrmMC1QAStoppage = True
            Me.Close()
        End If
    End Sub

    Private Sub picTestAutoMode_Click(sender As Object, e As EventArgs) Handles picTestAutoMode.Click
        modINfrmMC1TestAutoMode = True
        Me.Close()
    End Sub

    '// CHECKING FOR EXISTING QA STOPPAGE
    Public Sub CheckExistingQAStop()
        Dim Result As String
        Dim qaStop As New clsCheckQAStoppage
        qaStop.QAStop_MCId = modSettingValMachineID
        qaStop.QAStop_DTStatus = modSetVal_NewStoppage
        qaStop.CheckExistingQAStoppage()
        Result = qaStop.QAStop_Result

        If Result = "Quality" Then
            picStoppage.Enabled = False
        Else
            picStoppage.Enabled = True
        End If
    End Sub
    '//
End Class