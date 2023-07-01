Imports System.Data.SqlClient

Public Class clsGetUserID
    Inherits clsUserDetails
    Public GetUId As String

    Public Sub GetUserID()
        If modErrFlag_GetUserID = False Then
            Try
                Dim con As New SqlConnection(modSQLPath)
                Dim proc As String = "SELECT [User_ID]
                        FROM [Production].[MListUserDetails]
                        WHERE [User_ID] = @UserID"
                Using cmd As SqlCommand = New SqlCommand(proc, con)
                    cmd.Parameters.AddWithValue("@UserID", UD_stUserID)
                    con.Open()
                    GetUId = cmd.ExecuteScalar
                    con.Close()
                End Using
            Catch ex As Exception
                modErrFlag_GetUserID = True
                MessageBox.Show(ex.Message, "Getting User ID Details...", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If DialogResult.OK = True Then
                    modErrFlag_GetUserID = False
                End If
            End Try
        End If

    End Sub
End Class
