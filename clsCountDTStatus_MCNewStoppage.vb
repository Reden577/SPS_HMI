Imports System.Data.SqlClient

Public Class clsCountDTStatus_MCNewStoppage
    Inherits clsInsertAllDowntimeDetails
    Public CountDT As String

    Public Sub CountMCNewStoppage()
        If modErrFlag_CountMCNewStoppage = False Then
            Try
                Dim con As New SqlConnection(modSQLPath)
                Dim proc As String = "SELECT COUNT ([DTStatus])
                        FROM [Maintenance].[Downtime]
                        where [DTStatus] IS NOT NULL And [DTStatus] = @DTStatus And  [Machine_ID] = @MachineID"
                Using cmd As SqlCommand = New SqlCommand(proc, con)
                    cmd.Parameters.AddWithValue("@DTStatus", DTStatus)
                    cmd.Parameters.AddWithValue("@MachineID", MCID)
                    con.Open()
                    Dim cnt = Convert.ToString(cmd.ExecuteScalar)
                    CountDT = cnt
                    con.Close()
                End Using
            Catch ex As Exception
                modErrFlag_CountMCNewStoppage = True
                MessageBox.Show(ex.Message, "Counting MC New Stoppage...", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If DialogResult.OK = True Then
                    modErrFlag_CountMCNewStoppage = False
                End If
            End Try
        End If

    End Sub
End Class
