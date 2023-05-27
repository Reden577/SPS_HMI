Imports System.ComponentModel

Public Class frmNewJOSetup
    Private Sub frmNewJOSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modINfrmNewJOSetup = True
        frmMC1PlsLogin.Close()
    End Sub

    Private Sub frmNewJOSetup_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        modINfrmNewJOSetup = False
    End Sub

    Private Sub frmNewJOSetup_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    End Sub

    Private Sub btnMS_StartStop_Click(sender As Object, e As EventArgs) Handles btnMS_StartStop.Click
        If btnMS_StartStop.BackColor = Color.DarkRed Then
            btnMS_StartStop.BackColor = Color.Green
            btnMS_StartStop.ForeColor = Color.White
            btnMS_StartStop.Text = "IN PROG"
        Else
            btnMS_StartStop.BackColor = Color.DarkRed
            btnMS_StartStop.ForeColor = Color.White
            btnMS_StartStop.Text = "STOP"
        End If
    End Sub

    Private Sub btnMS_TAM_ONOFF_Click(sender As Object, e As EventArgs) Handles btnMS_TAM_ONOFF.Click

    End Sub

    Private Sub btnFPB_StartStop_Click(sender As Object, e As EventArgs) Handles btnFPB_StartStop.Click
        If btnFPB_StartStop.BackColor = Color.DarkRed Then
            btnFPB_StartStop.BackColor = Color.Green
            btnFPB_StartStop.ForeColor = Color.White
            btnFPB_StartStop.Text = "IN PROG"
        Else
            btnFPB_StartStop.BackColor = Color.DarkRed
            btnFPB_StartStop.ForeColor = Color.White
            btnFPB_StartStop.Text = "STOP"
        End If
    End Sub

    Private Sub btnFPB_TAM_ONOFF_Click(sender As Object, e As EventArgs) Handles btnFPB_TAM_ONOFF.Click

    End Sub

    Private Sub tmrMSTimer_Tick(sender As Object, e As EventArgs) Handles tmrMSTimer.Tick
        modMSTimerCounter += 1
    End Sub

    Private Sub tmrIdleTime1_Tick(sender As Object, e As EventArgs) Handles tmrIdleTime1.Tick
        modIdleTimer1Counter += 1
    End Sub

    Private Sub tmrFPBTimer_Tick(sender As Object, e As EventArgs) Handles tmrFPBTimer.Tick
        modFPBTimerCounter += 1
    End Sub

    Private Sub tmrIdleTime2_Tick(sender As Object, e As EventArgs) Handles tmrIdleTime2.Tick
        modidleTimer2Counter += 1
    End Sub

    Private Sub tmrMassProTimer_Tick(sender As Object, e As EventArgs) Handles tmrMassProTimer.Tick
        modMassProTimerCounter += 1
    End Sub
End Class