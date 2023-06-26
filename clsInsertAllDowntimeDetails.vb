Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports System.Security.Cryptography

Public Class clsInsertAllDowntimeDetails
    Public ShiftCOde As String
    Public UserName As String
    Public UserID As String
    Public DTType As String
    Public StartTime As String
    Public DTReason As String
    Public DTCountermeasure As String
    Public AckDate As String
    Public EndTime As String
    Public RunTime As String
    Public TtlDT As Double
    Public TtlRepairTime As Double
    Public ForQAVeri As String
    Public TtlVeri As Double
    Public TtlFailFreq As Integer
    Public DTStatus As String
    Public DT_JOCode
    Public MCID As String

    Public Sub InsertDowntime()
        Dim con As New SqlConnection(modSQLPath)
        Dim proc As String = "INSERT INTO [Maintenance].[Downtime]
           ([Shift_CodeFK] ,[User_Name] ,[User_ID] ,[DT_Type] ,[Start_Time]
           ,[DT_Reason] ,[DT_Countermeasure] ,[Ack_Date] ,[End_Time] ,[Run_Time]
           ,[ttl_DT_mins] ,[ttl_RprT_mins] ,[ForQAVerification] ,[ttl_QAVeri_mins] ,[ttl_FailFreq]
           ,[DTStatus] ,[JO_Code] ,[Machine_ID])
           VALUES
           (@ShiftCode ,@UName ,@UNID ,@DTType ,@StartTime
           ,@DTReason ,@DTCountermeasure ,@AckDate ,@EndTime ,@RunTime
           ,@ttlDT ,@ttlRprT ,@ForQAVeri ,@ttlQAVeri ,@ttlFailFreq
           ,@DTStatus ,@JOCode, @MCId)"

        Using cmd As SqlCommand = New SqlCommand(proc, con)
            cmd.Parameters.AddWithValue("@ShiftCode", ShiftCOde)
            cmd.Parameters.AddWithValue("@UName", UserName)
            cmd.Parameters.AddWithValue("@UNID", UserID)
            cmd.Parameters.AddWithValue("@DTType", "TBA")
            cmd.Parameters.AddWithValue("@StartTime", StartTime)
            cmd.Parameters.AddWithValue("@DTReason", "TBA")
            cmd.Parameters.AddWithValue("@DTCountermeasure", "TBA")
            cmd.Parameters.AddWithValue("@AckDate", "Not Yet Ack")
            cmd.Parameters.AddWithValue("@EndTime", "TBA")
            cmd.Parameters.AddWithValue("@RunTime", "0")
            cmd.Parameters.AddWithValue("@ttlDT", "0")
            cmd.Parameters.AddWithValue("@ttlRprT", "0")
            cmd.Parameters.AddWithValue("@ForQAVeri", "0")
            cmd.Parameters.AddWithValue("@ttlQAVeri", "0")
            cmd.Parameters.AddWithValue("@ttlFailFreq", "0")
            cmd.Parameters.AddWithValue("@DTStatus", modSetVal_NewStoppage)
            cmd.Parameters.AddWithValue("@JOCode", DT_JOCode)
            cmd.Parameters.AddWithValue("@MCId", MCID)
            'cmd.CommandType = CommandType.StoredProcedure
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        End Using
    End Sub
End Class
