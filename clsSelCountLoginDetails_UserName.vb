Imports System.Data.SqlClient

Public Class clsSelCountLoginDetails_UserName
    Inherits clsSelAllLoginDetails_MachineId
    Public cntUN As String

    Public Sub countUNByMachineId()
        Dim con As New SqlConnection(modSQLPath)
        Dim proc As String = "SelProCountLoginDetails_UN"
        Using cmd As SqlCommand = New SqlCommand(proc, con)
            cmd.Parameters.AddWithValue("@MachineID", MachineId)
            cmd.Parameters.AddWithValue("@UserName", UserName)
            cmd.CommandType = CommandType.StoredProcedure
            con.Open()
            Dim cnt = Convert.ToString(cmd.ExecuteScalar)
            cntUN = cnt
            con.Close()
        End Using
    End Sub

End Class
