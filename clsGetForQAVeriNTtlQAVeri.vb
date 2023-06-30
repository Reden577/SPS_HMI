Imports System.Data.SqlClient

Public Class clsGetForQAVeriNTtlQAVeri
    Inherits clsDowntimeDetails
    Public Sub GetForQAVeri_N_TtlQAVeri()
        Dim con As New SqlConnection(modSQLPath)
        Dim proc As String = "SELECT [ForQAVerification] ,[ttl_QAVeri_mins]
                        FROM [Maintenance].[Downtime]
                        WHERE  [DT_Type] = @DTType And [DTStatus] = @DTStats And [Machine_ID] = @MCId"
        Using cmd As SqlCommand = New SqlCommand(proc, con)
            cmd.Parameters.AddWithValue("@DTType", DTDetails_sfDTType)
            cmd.Parameters.AddWithValue("@DTStats", DTDetails_sfDTStatus)
            cmd.Parameters.AddWithValue("@MCId", DTDetails_sfMCId)
            con.Open()
            Dim myreader As SqlDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            DTDetails_sfForQAVeri = myreader("ForQAVerification")
            DTDetails_iTtlQAVeri = myreader("ttl_QAVeri_mins")
            con.Close()
        End Using
    End Sub
End Class
