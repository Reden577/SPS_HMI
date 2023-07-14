Imports System.ComponentModel

Public Class frmMC1NoPlan
    Private Sub frmMC1NoPlan_Load(sender As Object, e As EventArgs) Handles Me.Load
        modINfrmMC1NoPlan = True
        modINfrmMC1PlsLogin = False
        modINfrmMC1Stop = False
    End Sub

    Private Sub frmMC1NoPlan_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        modINfrmMC1NoPlan = False
    End Sub

    Private Sub frmMC1NoPlan_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        modINfrmMC1NoPlan = False
    End Sub

    Public Sub WithPlan()
        If modJODetails_isTrue = True Then
            modINfrmMC1NoPlan = False
            'modINfrmMC1PlsLogin = True
            Me.Close()
        End If
    End Sub

    Private Sub tmrRealTimeCheck_Tick(sender As Object, e As EventArgs) Handles tmrRealTimeCheck.Tick
        WithPlan()
    End Sub
End Class