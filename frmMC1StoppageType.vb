Public Class frmMC1StoppageType
    Dim displayTime As Integer

    '// FORM LOAD AND FORM CLOSE
    Private Sub frmMC1StoppageType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modINfrmMC1StoppageType = True
        frmMC1MainPage.Close()
        frmMC1OperatorStoppage.Close()
        frmMC1MachineStoppage.Close()
    End Sub
    Private Sub frmMC1StoppageType_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        modINfrmMC1StoppageType = False
    End Sub
    '//

    '// SELECTING OPERATTOR STOPPAGE
    Private Sub picOperatorStoppage_Click(sender As Object, e As EventArgs) Handles picOperatorStoppage.Click
        modINfrmMC1OperatorStoppage = True
        Me.Close()
    End Sub
    '//

    '// SELECTING MACHINE STOPPAGE
    Private Sub picMachineStoppage_Click(sender As Object, e As EventArgs) Handles picMachineStoppage.Click
        modINfrmMC1MachineStoppage = True
        Me.Close()
    End Sub
    '//

    '// REALTIME STATUS CHECKING
    Private Sub tmrRealtimeCheck_Tick(sender As Object, e As EventArgs) Handles tmrRealtimeCheck.Tick
        displaytimeCheck()
    End Sub
    '//

    '// PAGE DISPLAY ON TIMER
    Private Sub tmrDisplayON_Tick(sender As Object, e As EventArgs) Handles tmrDisplayON.Tick
        displayTime = displayTime + 1
    End Sub
    Public Sub displaytimeCheck()
        lblDisplayON.Text = displayTime
        If displayTime >= 20 Then
            modINfrmMC1Stop = True
        End If
    End Sub
    '//

    '//
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        modInfrmMC1MainPage = True
        Me.Close()
    End Sub
    '//


End Class