Imports System.Data.SqlClient

Public Class clsSellAllJOLoadedDetais
    Public sqlPath As String = "Data Source=DESKTOP-4OGTIB2\DIAVIEWSQL;Initial Catalog=SPS;Persist Security Info=True;User ID=sa;Password=doc577isin"
    Public selAllProc As String = "SelProALLJOLoadedDetails_MachineID"
    Public MachineId As String
    Public ShiftCode As String
    Public JOCode As String
    Public MoldId As String
    Public PN1 As String
    Public PN2 As String
    Public CavPN1 As Integer
    Public CavPN2 As Integer
    Public JOPlanQty As Integer
    Public CycleTime As Integer
    Public StarTime As String
    Public EndTime As String
    Public LoadStat As String
    Public ProdnStat As String
    Public LoadedBY As String
    Public UnloadedBy As String
    Public UnldDate As String
    Public TtlShots As Integer
    Public PN1Output As Integer
    Public PN2Output As Integer
    Public PN1Reject As Integer
    Public PN2Reject As Integer
    Public ActualOutPN1 As Integer
    Public ActualOutPN2 As Integer
    Public MSStartTime As String
    Public MSEndTime As String
    Public FPBStartTime As String
    Public FPBEndTime As String
    Public TtlMSTime As Decimal
    Public TtlFPBTime As Decimal
    Public TtlRunTime As Decimal

    Public Sub SelAllJOLoadedDetails()
        Dim con As New SqlConnection(sqlPath)
        Using cmd As SqlCommand = New SqlCommand(selAllProc, con)
            cmd.Parameters.AddWithValue("@MchineId", MachineId)
            cmd.CommandType = CommandType.StoredProcedure
            con.Open()
            Dim myreader As SqlDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            ShiftCode = myreader("Shift_Code")
            JOCode = myreader("JOB_ORDER")
            MoldId = myreader("Mold_ID")
            PN1 = myreader("PART_NO_1")
            PN2 = myreader("PART_NO_2")
            CavPN1 = myreader("MOLD_CAVITY_PART_1")
            CavPN2 = myreader("MOLD_CAVITY_PART_2")
            JOPlanQty = myreader("JOB_ORDER_QTY")
            CycleTime = myreader("CYCLE_TIME_SEC")
            StarTime = myreader("START_TIME")
            EndTime = myreader("END_TIME")
            LoadStat = myreader("Load_Stats")
            ProdnStat = myreader("Prodn_Stats")
            LoadedBY = myreader("Loaded_By")
            UnloadedBy = myreader("Unloaded_By")
            UnldDate = myreader("Unld_DT")
            TtlShots = myreader("Ttl_Shots")
            PN1Output = myreader("PN1_Output")
            PN2Output = myreader("PN2_Output")
            PN1Reject = myreader("PN1_Reject")
            PN2Reject = myreader("PN2_Reject")
            ActualOutPN1 = myreader("Actual_PN1_Out")
            ActualOutPN2 = myreader("Actual_PN2_Out")
            MSStartTime = myreader("MS_Start_DT")
            MSEndTime = myreader("MS_Stop_DT")
            FPBStartTime = myreader("FPB_Start_DT")
            FPBEndTime = myreader("FPB_Stop_DT")
            TtlMSTime = myreader("Ttl_MS_Time")
            TtlFPBTime = myreader("Ttl_FPB_Time")
            TtlRunTime = myreader("Ttl_RunTime")
            con.Close()
        End Using
    End Sub

End Class
