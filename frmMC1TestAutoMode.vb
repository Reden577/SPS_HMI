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
        ElapseTimeVisibility()
    End Sub
    Private Sub frmMC1TestAutoMode_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        modINfrmMC1TestAutoMode = False
    End Sub
    '//

    '//
    Private Sub btnMainPage_Click(sender As Object, e As EventArgs) Handles btnMainPage.Click
        If modTAM_NewJOLoaded_isTrue = False Then
            modInfrmMC1MainPage = True
            Me.Close()
        Else
            btnTAM_startStop.BackColor = Color.DarkRed
            btnTAM_startStop.Text = "OFF"
            modTestAutoModeMC1Flag = False
            modTAM_NewJOLoaded_isTrue = False
            modINfrmNewJOSetup = True
            Me.Close()
        End If
    End Sub
    '//

    '// TAM BUTTON STATUS AND STATUS FLAG
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles btnTAM_startStop.Click
        If btnTAM_startStop.BackColor = Color.DarkRed Then
            btnTAM_startStop.BackColor = Color.Green
            btnTAM_startStop.Text = "ON"
            modTestAutoModeMC1Flag = True
        Else
            'modTestAutoModeMC1Flag = False
            btnTAM_startStop.BackColor = Color.DarkRed
            btnTAM_startStop.Text = "OFF"
            modTestAutoModeMC1Flag = False
            modMC1TestAutoModeCounter = 5
        End If
    End Sub
    '//

    '// RUNNING / STOP STATUS OF TAM
    Public Sub TAMRunStopStats()
        If modTestAutoModeMC1Flag = True And RxPLCM0 = True Then
            lblSTOP_RUNNING.Text = "RUNNING"
            lblSTOP_RUNNING.BackColor = Color.Green
            lblSTOP_RUNNING.ForeColor = Color.White
        ElseIf modTestAutoModeMC1Flag = True And RxPLCM0 = False Then
            lblSTOP_RUNNING.Text = "STOP"
            lblSTOP_RUNNING.BackColor = Color.Red
            lblSTOP_RUNNING.ForeColor = Color.White
            'modINfrmMC1Stop = False
        End If
    End Sub
    Private Sub lblRxPLCMC0_TextChanged(sender As Object, e As EventArgs) Handles lblRxPLCMC0.TextChanged
        TAMRunStopStats()
    End Sub
    '//

    '// TURNS OFF THE TEST AUTO MODED FLAG ANG START STOP ONCE ALLOWED TAM COUNTER IS REACHED
    Public Sub TAMCounter()
        lblAlloweShots.Text = modMC1TestAutoMOdeCounterSet - modMC1TestAutoModeCounter
        If lblAlloweShots.Text = 0 Then
            modTestAutoModeMC1Flag = False
            modStartStopMC1 = False
            modMC1TestAutoModeCounter = 0
            lblAlloweShots.Text = modMC1TestAutoMOdeCounterSet
        End If
    End Sub
    '//

    '// REALTIME TIMER CHECK
    Private Sub tmrRealTimeCheck_Tick(sender As Object, e As EventArgs) Handles tmrRealTimeCheck.Tick
        ElapseTimeVisibility()
        lblRxPLCMC0.Text = RxPLCM0
        lblTesting.Text = modTestAutoModeMC1Flag
        If modTAM_NewJOLoaded_isTrue = False Then '<- Interloack when New Job Order is being loaded
            Dim StopTimer As String
            StopTimer = Math.Round((modMC1StopTimer / 60), 3)
            lblElapsTimeMC1.Text = StopTimer & " " & "mins"
            TAMCounter()
            If modTestAutoModeMC1Flag = True Then
                btnMainPage.Enabled = False
            Else
                btnMainPage.Enabled = True
            End If
        End If
    End Sub
    Public Sub ElapseTimeVisibility()
        If modTAM_NewJOLoaded_isTrue = False Then
            lblElapsTimeMC1.Visible = True
            Label1.Visible = True
            Label3.Visible = True
            lblAlloweShots.Visible = True
        Else
            lblElapsTimeMC1.Visible = False
            Label1.Visible = False
            Label3.Visible = False
            lblAlloweShots.Visible = False
        End If
    End Sub
    '//


End Class