Public Class frmMC1RUN

    '//
    Private Sub frmMC1RUN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modINfrmMC1Run = True
        frmMC1Ready.Close()
        frmMC1MainPage.Close()
    End Sub
    Private Sub frmMC1RUN_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        modINfrmMC1Run = False
    End Sub



    Private Sub lblStatMC1_Click(sender As Object, e As EventArgs) Handles lblStatMC1.Click
        modInfrmMC1MainPage = True
        Me.Close()
    End Sub

    Private Sub pnlMC1_Click(sender As Object, e As EventArgs) Handles pnlMC1.Click
        modInfrmMC1MainPage = True
        Me.Close()
    End Sub
    '//

End Class