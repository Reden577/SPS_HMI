Imports System.Data.SqlClient

Public Class clsUdateDTDetails_MCRunning
    Inherits clsInsertAllDowntimeDetails

    Public Sub Update_At_MachineRunning()
        Dim Proc As String = "UpdateProDTMCRun"
        Dim con As New SqlConnection(modSQLPath)
        Using cmd As SqlCommand = New SqlCommand(Proc, con)
            cmd.Parameters.AddWithValue("@UserName", UserName)
            cmd.Parameters.AddWithValue("@UNID", UserID)
            cmd.Parameters.AddWithValue("@RunTime", RunTime)
            cmd.Parameters.AddWithValue("@ttlDT", TtlDT)
            cmd.Parameters.AddWithValue("@DTComplete", DTStatus)
            cmd.Parameters.AddWithValue("@DTStatus", modSetVal_NewStoppage)
            cmd.CommandType = CommandType.StoredProcedure
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            modMC1StoppageType = Nothing
            modMC1StopDateandTime = Nothing
            modMC1StoppageReason = Nothing
            modMC1Countermeasure = Nothing
            modMC1AckDateandTime = Nothing
            modMC1StoppageEndTime = Nothing
            modMC1FailCounters = 0
        End Using
    End Sub

End Class
