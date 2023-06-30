Imports System.Data.SqlClient

Public Class clsSelCountJOLoadedDetails_MCId_Loaded
    Inherits clsSellAllJOLoadedDetais
    Public CountLoaded As Integer

    Public Sub countLoadStatByMCIdAndLoaded()
        If modErrFlag_CntLoadStatbyMCId = False Then
            Try
                Dim con As New SqlConnection(modSQLPath)
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
            Catch ex As Exception
                modErrFlag_CntLoadStatbyMCId = True
                MessageBox.Show(ex.Message, "Count Load Stat by MachineID...", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If DialogResult.OK = True Then
                    modErrFlag_CntLoadStatbyMCId = False
                End If
            End Try
        End If

    End Sub
End Class
