Imports System.Data.SqlClient

Public Class clsSelCountJOLoadedDetails_MCId_Loaded
    Inherits clsSellAllJOLoadedDetais
    Public CountLoaded As Integer

    Public Sub countLoadStatByMCIdAndLoaded()
        Dim con As New SqlConnection(sqlPath)
        Dim proc As String = "SelProCountJOLoadedDetails_Loaded"
        Using cmd As SqlCommand = New SqlCommand(proc, con)
            cmd.Parameters.AddWithValue("@MchineId", MachineId)
            cmd.Parameters.AddWithValue("@LoadStat", LoadStat)
            cmd.CommandType = CommandType.StoredProcedure
            con.Open()
            Dim cnt = Convert.ToString(cmd.ExecuteScalar)
            CountLoaded = cnt
            con.Close()
        End Using
    End Sub
End Class
