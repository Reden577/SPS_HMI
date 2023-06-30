Imports System.CodeDom
Imports System.Data.SqlClient

Public Class clsGetQAFailFreq
    Public QAFailFreq_MCId As String
    Public QAFailFreq_DTStatus As String
    Public QAFailFreq_DTType As String
    Public QAFailFreq_FailFreq As Integer

    Public Sub GetQAFailFreq()
        If modErrFlag_GetFailFreq = False Then
            Try
                Dim con As New SqlConnection(modSQLPath)
                Dim proc As String = "SELECT [ttl_FailFreq]
                        FROM [Maintenance].[Downtime]
                        Where [Machine_ID] = @MCId And [DTStatus] = @DTStats And [DT_Type] = @DTType"
                Using cmd As SqlCommand = New SqlCommand(proc, con)
                    cmd.Parameters.AddWithValue("@MCId", QAFailFreq_MCId)
                    cmd.Parameters.AddWithValue("@DTStats", QAFailFreq_DTStatus)
                    cmd.Parameters.AddWithValue("@DTType", QAFailFreq_DTType)
                    con.Open()
                    QAFailFreq_FailFreq = cmd.ExecuteScalar
                    con.Close()
                End Using
            Catch ex As Exception
                modErrFlag_GetFailFreq = True
                MessageBox.Show(ex.Message, "Get QA Fail Frequency...", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If DialogResult.OK = True Then
                    modErrFlag_GetFailFreq = False
                End If
            End Try
        End If

    End Sub
End Class
