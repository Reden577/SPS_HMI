Public Class frmMC1Maintenance
    Private Sub tmrRealTimeCheck_Tick(sender As Object, e As EventArgs) Handles tmrRealTimeCheck.Tick
        Dim StopTimer As String
        StopTimer = Math.Round((modMC1StopTimer / 60), 3)
        lblElapsTimeMC1.Text = StopTimer & " " & "mins"
    End Sub
End Class