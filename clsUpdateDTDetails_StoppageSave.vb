Imports System.Data.SqlClient

Public Class clsUpdateDTDetails_StoppageSave
    Inherits clsInsertAllDowntimeDetails

    Public Sub UpdateDowntimeAtStoppageSaved()
        Dim Proc As String = "UpdateProDTSave"
        Dim con As New SqlConnection(modSQLPath)
        Using cmd As SqlCommand = New SqlCommand(Proc, con)
            cmd.Parameters.AddWithValue("@DTType", DTType)
            cmd.Parameters.AddWithValue("@DTReason", DTReason)
            cmd.Parameters.AddWithValue("@DTCountermeasure", DTCountermeasure)
            cmd.Parameters.AddWithValue("@EndTime", EndTime)
            cmd.Parameters.AddWithValue("@ttlRprT", TtlRepairTime)
            cmd.Parameters.AddWithValue("@ForQAVeri", ForQAVeri)
            cmd.Parameters.AddWithValue("@ttlQAVeri", "0")
            cmd.Parameters.AddWithValue("@ttlFailFreq", TtlFailFreq)
            cmd.Parameters.AddWithValue("@DTStatus", modSetVal_NewStoppage)
            cmd.CommandType = CommandType.StoredProcedure
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            modMC1StoppageType = Nothing
            modMC1StoppageReason = Nothing
            modMC1Countermeasure = Nothing
            modMC1AckDateandTime = Nothing
            modMC1AcknowledgeFlag = False
            modMC1OptStoppageSaveFlag = False
            modMC1MachineStoppageSaveFlag = False
        End Using
    End Sub
End Class
