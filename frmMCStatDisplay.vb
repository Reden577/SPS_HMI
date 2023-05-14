Public Class frmMCStatDisplay
    Private Sub Label2_Click(sender As Object, e As EventArgs)
        modfrmMainPage = True
        Me.Close()
    End Sub
    Private Sub frmMCStatDisplay_Click(sender As Object, e As EventArgs) Handles Me.Click
        modfrmMainPage = True
        Me.Close()
    End Sub

    Private Sub frmMCStatDisplay_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Public Sub StatusStatusDisplayMC1()


    End Sub

    Private Sub tmrRealTimeCheck_Tick(sender As Object, e As EventArgs) Handles tmrRealTimeCheck.Tick


    End Sub


End Class