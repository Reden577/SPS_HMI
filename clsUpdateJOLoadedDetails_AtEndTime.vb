Imports System.Data.SqlClient

Public Class clsUpdateJOLoadedDetails_AtEndTime
    Inherits clsSellAllJOLoadedDetais
    Public NewProdnStat As String
    Public MCId As String

    Public Sub updateEndTimeDetails()
        If modSettingValMachineID IsNot Nothing Then
            Dim con As New SqlConnection(modSQLPath)
            Dim proc As String = "UpProJOLoadedDetails_EndTime"
            Using cmd As SqlCommand = New SqlCommand(proc, con)
                cmd.Parameters.AddWithValue("@MCId", MCId)
                cmd.Parameters.AddWithValue("@LoadStat", LoadStat)
                cmd.Parameters.AddWithValue("@ProdnStat", ProdnStat)
                cmd.Parameters.AddWithValue("@EndTime", EndTime)
                cmd.Parameters.AddWithValue("@NewProdnStat", NewProdnStat)
                cmd.Parameters.AddWithValue("@TtlShots", TtlShots)
                cmd.Parameters.AddWithValue("@PN1Out", PN1Output)
                cmd.Parameters.AddWithValue("@PN2Out", PN2Output)
                cmd.Parameters.AddWithValue("@TtlRunTime", TtlRunTime)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End If
    End Sub
End Class
