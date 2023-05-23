Imports System.Data.SqlClient

Public Class clsUpdateDTDetails_QAVeriFail
    Inherits clsInsertAllDowntimeDetails

    Public Sub UpdateDTFailFreq()
        Dim Proc As String = "UpdateProDTQAVeriFail"
        Dim con As New SqlConnection(modSQLPath)
        Using cmd As SqlCommand = New SqlCommand(Proc, con)
            cmd.Parameters.AddWithValue("@ForQAVeri", "TBA")
            cmd.Parameters.AddWithValue("@ttlFailFreq", TtlFailFreq)
            cmd.Parameters.AddWithValue("@DTStatus", "MC1NewStoppage")
            cmd.CommandType = CommandType.StoredProcedure

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        End Using
    End Sub
End Class
