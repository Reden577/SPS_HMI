Imports System.Data.SqlClient

Public Class clsCheckQAStoppage
    Public QAStop_DTType As String
    Public QAStop_MCId As String
    Public QAStop_DTStatus As String
    Public QAStop_Result As String

    Public Sub CheckExistingQAStoppage()
        Dim con As New SqlConnection(modSQLPath)
        Dim proc As String = "SELECT [DT_Type]
                        FROM [Maintenance].[Downtime]
                        Where [Machine_ID] = @MCId And [DTStatus] = @DTStats"
        Using cmd As SqlCommand = New SqlCommand(proc, con)
            cmd.Parameters.AddWithValue("@MCId", QAStop_MCId)
            cmd.Parameters.AddWithValue("@DTStats", QAStop_DTStatus)
            con.Open()
            QAStop_Result = cmd.ExecuteScalar
            con.Close()
        End Using
    End Sub
End Class
