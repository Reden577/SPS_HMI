Imports System.Data.SqlClient

Public Class clsCheckPlan
    Public JCode As String
    Public MCId As String
    Public LoadStat As String
    Public Result As String

    Public Sub CheckPlan()

        Dim con As New SqlConnection(modSQLPath)
        Dim Proc As String = "SELECT [JOB_ORDER]
                        FROM [Production].[JOLoadedDetails]
                        WHERE [Machine_ID] = @MCId And [JOB_ORDER] = @JCode And [Load_Stats] = @LoadStat"
        Using cmd As SqlCommand = New SqlCommand(Proc, con)
            cmd.Parameters.AddWithValue("@MCId", MCId)
            cmd.Parameters.AddWithValue("@JCode", JCode)
            cmd.Parameters.AddWithValue("@LoadStat", LoadStat)
            con.Open()
            Result = cmd.ExecuteScalar
            con.Close()
        End Using




    End Sub

End Class
