Imports System.Data.SqlClient

Public Class clsGetAccessRights
    Inherits clsUserDetails
    Public GetAccRights As String

    Public Sub GetAccessRights()
        If modErrFlag_GetAccessRights = False Then
            Try
                Dim con As New SqlConnection(modSQLPath)
                Dim proc As String = "SELECT [Acess_Rights]
                        FROM [Production].[MListUserDetails]
                        WHERE [User_ID] = @UserId"
                Using cmd As SqlCommand = New SqlCommand(proc, con)
                    cmd.Parameters.AddWithValue("@UserId", UD_stUserID)
                    con.Open()
                    GetAccRights = cmd.ExecuteScalar
                    con.Close()
                End Using
            Catch ex As Exception
                modErrFlag_GetAccessRights = True
                MessageBox.Show(ex.Message, "Getting Access Rights...", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If DialogResult.OK = True Then
                    modErrFlag_GetAccessRights = False
                End If
            End Try
        End If

    End Sub
End Class
