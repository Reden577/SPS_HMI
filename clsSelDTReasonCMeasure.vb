Imports System.Data.SqlClient

Public Class clsSelDTReasonCMeasure
    Inherits clsInsertAllDowntimeDetails

    Public Sub SelDTReason_CMeasure()
        Dim con As New SqlConnection(modSQLPath)
        Dim proc As String = "SELECT [DT_Reason] ,[DT_Countermeasure], [ttl_FailFreq]
                    FROM [Maintenance].[Downtime]
                    WHERE [DT_Type] = @DTType And [Machine_ID] = @MachineID And [DTStatus] = @DTStatus"
        Using cmd As SqlCommand = New SqlCommand(proc, con)
            cmd.Parameters.AddWithValue("@DTType", DTType)
            cmd.Parameters.AddWithValue("@MachineID", MCID)
            cmd.Parameters.AddWithValue("@DTStatus", DTStatus)
            con.Open()
            Dim myReader As SqlDataReader
            myReader = cmd.ExecuteReader
            myReader.Read()
            If myReader("DT_Reason") IsNot DBNull.Value Then
                DTReason = myReader("DT_Reason")
            Else
                DTReason = ""
            End If
            If myReader("DT_Countermeasure") IsNot DBNull.Value Then
                DTCountermeasure = myReader("DT_Countermeasure")
            Else
                DTCountermeasure = ""
            End If
            If myReader("ttl_FailFreq") IsNot DBNull.Value Then
                TtlFailFreq = myReader("ttl_FailFreq")
            Else
                TtlFailFreq = 0
            End If
            con.Close()
        End Using
    End Sub
End Class
