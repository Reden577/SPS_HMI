Public Class frmPlanComplete
    Private Sub frmPlanComplete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modINfrmMC1PlanComplete = True
        frmMC1STOP.Close()
        frmMC1PlsLogin.Close()
        frmMC1MainPage.Close()
        frmMC1RUN.Close()
    End Sub

    Private Sub frmPlanComplete_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        modINfrmMC1PlanComplete = False
    End Sub

    Private Sub lblStatMC1_Click(sender As Object, e As EventArgs) Handles lblStatMC1.Click
        modInfrmMC1MainPage = True
        frmMC1MainPage.Show()
    End Sub

    Private Sub lblPlanComplete_Click(sender As Object, e As EventArgs) Handles lblPlanComplete.Click
        modInfrmMC1MainPage = True
        frmMC1MainPage.Show()
    End Sub
End Class