Imports System.Threading

Public Class frmSplash
    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        modSQLPath = My.Settings.SQLPath
        modSetVal_IPAddress = My.Settings.IpAddress
        modSetVal_Por = My.Settings.Port
        modSettingValMachineID = My.Settings.MachineNo
    End Sub

    Private Sub tmrLoading_Tick(sender As Object, e As EventArgs) Handles tmrProgress.Tick
        Dim ProgPercent As String

        ProgressBar1.Value += 1
        ProgPercent = ProgressBar1.Value & "%"
        If ProgressBar1.Value <= 30 Then
            lblProgress.Text = "Initializing System...  " & ProgPercent
        ElseIf ProgressBar1.Value <= 50 Then
            lblProgress.Text = "Loading all Components and Settings...  " & ProgPercent
        ElseIf ProgressBar1.Value <= 60 Then
            lblProgress.Text = "SQL Path: " & modSQLPath & " " & ProgPercent
            Thread.Sleep(200)
        ElseIf ProgressBar1.Value <= 65 Then
            lblProgress.Text = "IP Address: " & modSetVal_IPAddress & " " & ProgPercent
            Thread.Sleep(200)
        ElseIf ProgressBar1.Value <= 70 Then
            lblProgress.Text = "Port: " & modSetVal_Por & " " & ProgPercent
            Thread.Sleep(200)
        ElseIf ProgressBar1.Value <= 75 Then
            lblProgress.Text = "Machine ID: " & modSettingValMachineID & " " & ProgPercent
            Thread.Sleep(200)
        ElseIf ProgressBar1.Value <= 80 Then
            lblProgress.Text = "Please wait...  " & ProgPercent
        ElseIf ProgressBar1.Value <= 100 Then
            lblProgress.Text = "Opening SPS App...  " & ProgPercent
        ElseIf ProgressBar1.Value = 100 Then
            lblProgress.Text = "Welcome to SPS App...  " & ProgPercent
        End If

        If ProgressBar1.Value = 100 Then
            'Thread.Sleep(2000)
            tmrProgress.Dispose()
            Me.Hide()
            frmMainDash.ShowDialog()
            Me.Close()
        End If
    End Sub
End Class