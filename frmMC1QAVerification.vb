Public Class frmMC1QAVerification

    '//
    Private Sub frmMC1QAVerification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modINfrmMC1QAVerification = True
        frmMC1QAStoppage.Close()
        lblFailedCounter.Text = modMC1FailCounters

        LabelVisibility()

    End Sub
    Private Sub frmMC1QAVerification_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        modINfrmMC1QAVerification = False
    End Sub
    Private Sub btnMainPage_Click(sender As Object, e As EventArgs) Handles btnMainPage.Click
        If modForQA_NewJOLoaded_isTrue = False Then '<- Interlock during new Job Order is loaded
            modInfrmMC1MainPage = True
            Me.Close()
        Else
            'modINfrmNewJOSetup = True
            'Me.Close()
        End If
    End Sub

    Private Sub btnPass_Click(sender As Object, e As EventArgs) Handles btnPass.Click
        If modForQA_NewJOLoaded_isTrue = False Then '<- Interlock during new Job Order is loaded
            modMC1QAVerifyPassFlag = True
            modINfrmMC1Ready = True
            Me.Close()
        Else
            modForQAPass_NewJOLoaded_isTrue = True
            modINfrmNewJOSetup = True
            Me.Close()
        End If

    End Sub

    Private Sub btnFail_Click(sender As Object, e As EventArgs) Handles btnFail.Click
        If modForQA_NewJOLoaded_isTrue = False Then '<- Interlock during new Job Order is loaded
            modMC1FailCounters = modMC1FailCounters + 1
            modMC1QAVerifyFailFlag = True
            modINfrmMC1QAStoppage = True
            Me.Close()
        Else
            modForQAFail_NewJOLoaded_isTrue = True
            modINfrmNewJOSetup = True
            Me.Close()
        End If

    End Sub

    Private Sub tmrRealTimeCheck_Tick(sender As Object, e As EventArgs) Handles tmrRealTimeCheck.Tick
        lblFailedCounter.Text = modMC1FailCounters
        If modForQA_NewJOLoaded_isTrue = False Then '<- Interlock during new Job Order is loaded
            Dim StopTimer As String
            StopTimer = Math.Round((modMC1StopTimer / 60), 3)
            lblElapsTimeMC1.Text = StopTimer & " " & "mins"
        End If
    End Sub

    Public Sub LabelVisibility()
        If modForQA_NewJOLoaded_isTrue = True Then '<- Interlock during new Job Order is loaded
            Label1.Visible = False
            lblElapsTimeMC1.Visible = False
            lblFailedCounter.Visible = False
            lblFPB_label.Visible = True
        Else
            Label1.Visible = True
            lblElapsTimeMC1.Visible = True
            lblFailedCounter.Visible = True
            lblFPB_label.Visible = False
        End If
    End Sub



End Class