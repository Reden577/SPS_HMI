Public Class frmMC1STOP
    Private Sub frmMC1STOP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modINfrmMC1Stop = True
        frmMC1MainPage.Close()
        frmMC1PlsLogin.Close()
        frmMC1StoppageType.Close()
        frmMC1Ready.Close()
        If modMC1AcknowledgeFlag = True Then
            btnAcknowledge.Visible = False
        Else
            btnAcknowledge.Visible = True
        End If
    End Sub

    Private Sub frmMC1STOP_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        modINfrmMC1Stop = False
    End Sub

    Private Sub lblStatMC1_Click(sender As Object, e As EventArgs) Handles lblStatMC1.Click
        If modMC1AcknowledgeFlag = True Then
            modInfrmMC1MainPage = True
            Me.Close()
        End If
    End Sub

    Private Sub pnlMC1_Click(sender As Object, e As EventArgs) Handles pnlMC1.Click
        If modMC1AcknowledgeFlag = True Then
            modInfrmMC1MainPage = True
            Me.Close()
        End If
    End Sub

    Private Sub btnAcknowledge_Click(sender As Object, e As EventArgs) Handles btnAcknowledge.Click
        If modMC1AcknowledgeFlag = False Then
            modMC1AcknowledgeFlag = True
            modInfrmMC1MainPage = True
            modMC1AckDateandTime = Now()
            Me.Close()
        End If

    End Sub

    Private Sub tmrRealTimeCheck_Tick(sender As Object, e As EventArgs) Handles tmrRealTimeCheck.Tick
        Dim StopTimer As String
        StopTimer = Math.Round((modMC1StopTimer / 60), 3)
        lblElapsTimeMC1.Text = StopTimer & " " & "mins"
    End Sub
End Class