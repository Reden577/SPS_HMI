Imports System.Data.SqlClient

Public Class clsSelCountLoginDetails_UserName
    Inherits clsSelAllLoginDetails_MachineId
    Public cntUN As String

    Public Sub countUNByMachineId()
        If modErrFlag_CntUNbyMachine = False Then
            Try
                Dim con As New SqlConnection(modSQLPath)
                Dim proc As String = "SelProCountLoginDetails_UN"
                Using cmd As SqlCommand = New SqlCommand(proc, con)
                    cmd.Parameters.AddWithValue("@MachineID", MachineId)
                    cmd.Parameters.AddWithValue("@UserName", UserName)
                    cmd.CommandType = CommandType.StoredProcedure
                    con.Open()
                    Dim cnt = Convert.ToString(cmd.ExecuteScalar)
                    cntUN = cnt
                    con.Close()
                End Using
            Catch ex As Exception
                modErrFlag_CntUNbyMachine = True
                MessageBox.Show(ex.Message, "Count UN by Machine ID...", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If DialogResult.OK = True Then
                    modErrFlag_CntUNbyMachine = False

                End If
            End Try
        End If

    End Sub

End Class
