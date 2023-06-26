Imports System.Data.SqlClient

Public Class clsUpdateDTDetails_QAVeriPass
    Inherits clsInsertAllDowntimeDetails

    Public Sub UpdateDTQAVerifyPass()
        Dim Proc As String = "UpdateProDTQAVeriPass"
        Dim con As New SqlConnection(modSQLPath)
        Using cmd As SqlCommand = New SqlCommand(Proc, con)
            cmd.Parameters.AddWithValue("@ttlQAVeri", TtlVeri)
            cmd.Parameters.AddWithValue("@ttlFailFreq", TtlFailFreq)
            cmd.Parameters.AddWithValue("@DTStatus", modSetVal_NewStoppage)
            cmd.CommandType = CommandType.StoredProcedure

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            modMC1QASendSampleFlag = False
            modMC1QAVerifyPassFlag = False
        End Using
    End Sub
End Class
