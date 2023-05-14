Public Class frmMC1QAVerification

    '//
    Private Sub frmMC1QAVerification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modINfrmMC1QAVerification = True
        frmMC1QAStoppage.Close()
        lblFailedCounter.Text = modMC1FailCounters
    End Sub
    Private Sub frmMC1QAVerification_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        modINfrmMC1QAVerification = False
    End Sub
    Private Sub btnMainPage_Click(sender As Object, e As EventArgs) Handles btnMainPage.Click
        modInfrmMC1MainPage = True
        Me.Close()
    End Sub

    Private Sub btnPass_Click(sender As Object, e As EventArgs) Handles btnPass.Click
        modMC1QAVerifyPassFlag = True
        modINfrmMC1Ready = True
        Me.Close()
    End Sub

    Private Sub btnFail_Click(sender As Object, e As EventArgs) Handles btnFail.Click
        modMC1FailCounters = modMC1FailCounters + 1
        modMC1QAVerifyFailFlag = True
        modINfrmMC1QAStoppage = True
        Me.Close()
    End Sub

    Private Sub tmrRealTimeCheck_Tick(sender As Object, e As EventArgs) Handles tmrRealTimeCheck.Tick
        lblFailedCounter.Text = modMC1FailCounters
        Dim StopTimer As String
        StopTimer = Math.Round((modMC1StopTimer / 60), 3)
        lblElapsTimeMC1.Text = StopTimer & " " & "mins"
    End Sub
End Class