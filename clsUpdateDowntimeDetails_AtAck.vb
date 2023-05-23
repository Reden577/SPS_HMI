Imports System.Data.SqlClient

Public Class clsUpdateDowntimeDetails_AtAck
    Inherits clsInsertAllDowntimeDetails

    Public Sub UpdateDT_At_Ack()
        Dim proc As String = "UpdateProDTAck"
        Dim con As New SqlConnection(modSQLPath)
        Using cmd As SqlCommand = New SqlCommand(proc, con)
            cmd.Parameters.AddWithValue("@AckDate", AckDate)
            cmd.Parameters.AddWithValue("@DTStatus", "MC1NewStoppage")
            cmd.CommandType = CommandType.StoredProcedure
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        End Using
    End Sub
End Class
