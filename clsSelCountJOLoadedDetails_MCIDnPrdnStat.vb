Imports System.Data.SqlClient

Public Class clsSelCountJOLoadedDetails_MCIDnPrdnStat
    Inherits clsSellAllJOLoadedDetais
    Public CountPrdnStat As Integer

    Public Sub countLoadStatByMCIdAndLoaded()
        If modSQLPath IsNot Nothing Then
            Dim con As New SqlConnection(modSQLPath)
            Dim proc As String = "SelProCountJOLoadedDetails_MCIDnPrdnStat"
            Using cmd As SqlCommand = New SqlCommand(proc, con)
                cmd.Parameters.AddWithValue("@MchineId", MachineId)
                cmd.Parameters.AddWithValue("@ProdnStat", ProdnStat)
                cmd.CommandType = CommandType.StoredProcedure
                con.Open()
                Dim cnt = Convert.ToString(cmd.ExecuteScalar)
                CountPrdnStat = cnt
                con.Close()
            End Using
        End If
    End Sub
End Class
