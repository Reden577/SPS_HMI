Imports System.Data.SqlClient

Public Class clsSelAllJOLoadedDetails_MCId_LDStat
    Inherits clsSellAllJOLoadedDetais

    Public Sub SellByMCIdAndLoadStat()
        Dim con As New SqlConnection(sqlPath)
        Dim Proc As String = "SelProALLJOLoadedDetails_MachineID_LoadStat"
        Using cmd As SqlCommand = New SqlCommand(Proc, con)
            cmd.Parameters.AddWithValue("@MchineId", MachineId)
            cmd.Parameters.AddWithValue("@LoadStat", LoadStat)
            cmd.CommandType = CommandType.StoredProcedure
            con.Open()
            Dim myreader As SqlDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            ShiftCode = myreader("Shift_Code")
            JOCode = myreader("JOB_ORDER")
            'MoldId = myreader("Mold_ID")
            'PN1 = myreader("PART_NO_1")
            'PN2 = myreader("PART_NO_2")
            'CavPN1 = myreader("MOLD_CAVITY_PART_1")
            'CavPN2 = myreader("MOLD_CAVITY_PART_2")
            JOPlanQty = myreader("JOB_ORDER_QTY")
            'CycleTime = myreader("CYCLE_TIME_SEC")
            'StarTime = myreader("START_TIME")
            'EndTime = myreader("END_TIME")
            'ProdnStat = myreader("Prodn_Stats")
            'LoadedBY = myreader("Loaded_By")
            'UnloadedBy = myreader("Unloaded_By")
            'UnldDate = myreader("Unld_DT")
            'TtlShots = myreader("Ttl_Shots")
            'PN1Output = myreader("PN1_Output")
            'PN2Output = myreader("PN2_Output")
            'PN1Reject = myreader("PN1_Reject")
            'PN2Reject = myreader("PN2_Reject")
            'ActualOutPN1 = myreader("Actual_PN1_Out")
            'ActualOutPN2 = myreader("Actual_PN2_Out")
            'MSStartTime = myreader("MS_Start_DT")
            'MSEndTime = myreader("MS_Stop_DT")
            'FPBStartTime = myreader("FPB_Start_DT")
            'FPBEndTime = myreader("FPB_Stop_DT")
            'TtlMSTime = myreader("Ttl_MS_Time")
            'TtlFPBTime = myreader("Ttl_FPB_Time")
            'TtlRunTime = myreader("Ttl_RunTime")
            con.Close()
        End Using
    End Sub
End Class
