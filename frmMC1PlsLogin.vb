Public Class frmMC1PlsLogin
    Private Sub frmMC1PlsLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modINfrmMC1PlsLogin = True
        frmMC1STOP.Close()
        frmMC1MainPage.Close()
        frmNewJOSetup.Close()
    End Sub
    Private Sub frmMC1PlsLogin_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        modINfrmMC1PlsLogin = False
    End Sub

    'Public Sub frmPlsLoginStat()
    '    If RxPLCM3 = True And modINfrmMC1PlsLogin = True Then
    '        modINfrmMC1PlsLogin = False
    '        Me.Close()
    '    End If
    'End Sub

    Private Sub tmrRealTimeCheck_Tick(sender As Object, e As EventArgs) Handles tmrRealTimeCheck.Tick
        'frmPlsLoginStat()
        Dim StopTimer As String
        StopTimer = Math.Round((modMC1StopTimer / 60), 3)
        lblElapsTimeMC1.Text = StopTimer & " " & "mins"
    End Sub
End Class