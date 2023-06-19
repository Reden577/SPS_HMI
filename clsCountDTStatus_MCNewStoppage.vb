Imports System.Data.SqlClient

Public Class clsCountDTStatus_MCNewStoppage
    Inherits clsInsertAllDowntimeDetails
    Public CountDT As String

    Public Sub CountMCNewStoppage()
        Dim con As New SqlConnection(modSQLPath)
        Dim proc As String = "SELECT COUNT ([DTStatus])
                        FROM [Maintenance].[Downtime]
                        where [DTStatus] IS NOT NULL And [DTStatus] = @DTStatus And  [Machine_ID] = @MachineID"
        Using cmd As SqlCommand = New SqlCommand(proc, con)
            cmd.Parameters.AddWithValue("@DTStatus", DTStatus)
            cmd.Parameters.AddWithValue("@MachineID", MCID)
            con.Open()
            Dim cnt = Convert.ToString(cmd.ExecuteScalar)
            CountDT = cnt
            con.Close()
        End Using
    End Sub
End Class
