Imports System.Data.SqlClient

Public Class clsCountDTType_byDTStatusMCId
    Inherits clsInsertAllDowntimeDetails
    Public cntDTtype As Integer

    Public Sub CountDTType()
        Dim con As New SqlConnection(modSQLPath)
        Dim proc As String = "SELECT COUNT ([DT_Type])
                    FROM [Maintenance].[Downtime]
                    WHERE  [DT_Type] = @DTType And [DTStatus] = @DTStatus And [Machine_ID] = @MachineID"
        Using cmd As SqlCommand = New SqlCommand(proc, con)
            cmd.Parameters.AddWithValue("@DTType", DTType)
            cmd.Parameters.AddWithValue("@DTStatus", DTStatus)
            cmd.Parameters.AddWithValue("@MachineID", MCID)
            con.Open()
            Dim cnt = Convert.ToString(cmd.ExecuteScalar)
            cntDTtype = cnt
            con.Close()
        End Using
    End Sub

End Class
