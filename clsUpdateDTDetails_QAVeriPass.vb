Imports System.Data.SqlClient

Public Class clsUpdateDTDetails_QAVeriPass
    Inherits clsInsertAllDowntimeDetails

    Public Sub UpdateDTQAVerifyPass()

        Dim con As New SqlConnection(modSQLPath)
        Dim Proc As String = "UPDATE [Maintenance].[Downtime]
                        SET [ttl_QAVeri_mins] = @ttlQAVeri
                        ,[ttl_FailFreq] = @ttlFailFreq
                        ,[VerifiedBy_QA] = @VeriByQA
                        WHERE [DTStatus] = @DTStatus"

        Using cmd As SqlCommand = New SqlCommand(Proc, con)
            cmd.Parameters.AddWithValue("@ttlQAVeri", TtlVeri)
            cmd.Parameters.AddWithValue("@ttlFailFreq", TtlFailFreq)
            cmd.Parameters.AddWithValue("@DTStatus", modSetVal_NewStoppage)
            cmd.Parameters.AddWithValue("@VeriByQA", VeriByQA)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            modMC1QASendSampleFlag = False
            modMC1QAVerifyPassFlag = False
        End Using
    End Sub
End Class
