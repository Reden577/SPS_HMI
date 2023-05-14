Public Class frmMC1TestAutoMode


    Private Sub frmMC1TestAutoMode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modINfrmMC1TestAutoMode = True
        frmMC1MainPage.Close()
        modMC1TestAutoMOdeCounterSet = lblAlloweShots.Text
        If modTestAutoModeMC1Flag = True Then
            btnTAM_startStop.BackColor = Color.Green
            btnTAM_startStop.Text = "ON"
        Else
            btnTAM_startStop.BackColor = Color.DarkRed
            btnTAM_startStop.Text = "OFF"
        End If
    End Sub
    Private Sub frmMC1TestAutoMode_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        modINfrmMC1TestAutoMode = False
    End Sub

    Private Sub btnMainPage_Click(sender As Object, e As EventArgs) Handles btnMainPage.Click
        modInfrmMC1MainPage = True
        Me.Close()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles btnTAM_startStop.Click
        If modTestAutoModeMC1Flag = False Then
            modTestAutoModeMC1Flag = True
            btnTAM_startStop.BackColor = Color.Green
            btnTAM_startStop.Text = "ON"
        Else
            modTestAutoModeMC1Flag = False
            btnTAM_startStop.BackColor = Color.DarkRed
            btnTAM_startStop.Text = "OFF"
            modMC1TestAutoModeCounter = 5
        End If
    End Sub

    '//
    Public Sub TAMRunStopStats()
        If modTestAutoModeMC1Flag = True And RxPLCM0 = True Then
            lblSTOP_RUNNING.Text = "RUNNING"
            lblSTOP_RUNNING.BackColor = Color.Green
            lblSTOP_RUNNING.ForeColor = Color.Wheat
        ElseIf modTestAutoModeMC1Flag = True And RxPLCM0 = False Then
            lblSTOP_RUNNING.Text = "STOP"
            lblSTOP_RUNNING.BackColor = Color.Red
            lblSTOP_RUNNING.ForeColor = Color.Wheat
            modINfrmMC1Stop = False
        End If
    End Sub
    Private Sub lblRxPLCMC0_TextChanged(sender As Object, e As EventArgs) Handles lblRxPLCMC0.TextChanged
        TAMRunStopStats()
    End Sub
    '//

    '//
    Public Sub TAMCounter()
        lblAlloweShots.Text = modMC1TestAutoMOdeCounterSet - modMC1TestAutoModeCounter
        If lblAlloweShots.Text = "0" Then
            modTestAutoModeMC1Flag = False
            modStartStopMC1 = False
            lblAlloweShots.Text = modMC1TestAutoMOdeCounterSet
        End If
    End Sub

    Private Sub tmrRealTimeCheck_Tick(sender As Object, e As EventArgs) Handles tmrRealTimeCheck.Tick
        Dim StopTimer As String
        StopTimer = Math.Round((modMC1StopTimer / 60), 3)
        lblElapsTimeMC1.Text = StopTimer & " " & "mins"
        TAMCounter()
        lblRxPLCMC0.Text = RxPLCM0
        If modTestAutoModeMC1Flag = True Then
            btnMainPage.Enabled = False
        Else
            btnMainPage.Enabled = True
        End If
    End Sub


End Class