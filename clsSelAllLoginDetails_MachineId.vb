﻿Imports System.Data.SqlClient

Public Class clsSelAllLoginDetails_MachineId
    Public sqlPath As String = "Data Source=DESKTOP-4OGTIB2\DIAVIEWSQL;Initial Catalog=SPS;Persist Security Info=True;User ID=sa;Password=doc577isin"
    Public MachineId As String
    Public UserName As String
    Public UserID As String
    Public AccessLvl As String
    Public UPassword As String
    Public OTS As String

    Public Sub getUserLoginDetails()
        Dim con As New SqlConnection(sqlPath)
        Dim Proc As String = "SelectProLoginDetails"
        Using cmd As SqlCommand = New SqlCommand(Proc, con)
            cmd.Parameters.AddWithValue("@MachineID", MachineId)
            cmd.CommandType = CommandType.StoredProcedure
            con.Open()
            Dim myreader As SqlDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            UserName = myreader("User_Name")
            UserID = myreader("User_ID")
            AccessLvl = myreader("Access_Level")
            UPassword = myreader("Password")
            OTS = myreader("OTS")
            con.Close()
        End Using
    End Sub


End Class
