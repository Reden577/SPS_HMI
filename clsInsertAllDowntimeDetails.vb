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

    Public Sub InsertDowntime()
        Dim con As New SqlConnection(modSQLPath)
        Dim proc As String = "InsertProDT"
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
            cmd.Parameters.AddWithValue("@DTStatus", "MC1NewStoppage")
            cmd.CommandType = CommandType.StoredProcedure
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        End Using
    End Sub
End Class
