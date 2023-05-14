Public Class frmMC1Ready

    '//
    Private Sub frmMCReady_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modINfrmMC1Ready = True
        frmMC1OperatorStoppage.Close()
        frmMC1MachineStoppage.Close()
        frmMC1QAVerification.Close()
        modMC1QAStoppageSaveFlag = False
        modMC1AcknowledgeFlag = False
        modMC1QASendSampleFlag = False
    End Sub
    Private Sub frmMC1Ready_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        modINfrmMC1Ready = False
    End Sub

    Private Sub tmrRealTimeCheck_Tick(sender As Object, e As EventArgs) Handles tmrRealTimeCheck.Tick
        Dim StopTimer As String
        StopTimer = Math.Round((modMC1StopTimer / 60), 3)
        lblElapsTimeMC1.Text = StopTimer & " " & "mins"
    End Sub

End Class