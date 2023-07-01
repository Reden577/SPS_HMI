Imports System.Data.SqlClient

Public Class clsGetUserName_N_AccessRights
    Inherits clsUserDetails

    Public Sub GetUserName_AccessRights()
        If modErrFlag_GetUNandAR = False Then
            Try
                Dim con As New SqlConnection(modSQLPath)
                Dim proc As String = "SELECT [User_ID] ,[User_Name] ,[Acess_Rights],[Password] ,[OTS]
                        FROM [Production].[MListUserDetails]
                        WHERE [User_ID] = @UserId"
                Using cmd As SqlCommand = New SqlCommand(proc, con)
                    cmd.Parameters.AddWithValue("@UserId", UD_stUserID)
                    con.Open()
                    Dim myreader As SqlDataReader
                    myreader = cmd.ExecuteReader
                    myreader.Read()
                    UD_stUserID = myreader("User_ID")
                    UD_stUserName = myreader("User_Name")
                    UD_stAccessRights = myreader("Acess_Rights")
                    UD_stPassword = myreader("Password")
                    UD_stOTS = myreader("OTS")
                End Using
            Catch ex As Exception
                modErrFlag_GetUNandAR = True
                MessageBox.Show(ex.Message, "Getting User Name and Access Rights...", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If DialogResult.OK = True Then
                    modErrFlag_GetUNandAR = False
                End If
            End Try
        End If

    End Sub
End Class
