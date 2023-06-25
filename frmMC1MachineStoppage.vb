Imports System.Data.SqlClient

Public Class frmMC1MachineStoppage

    'Dim sqlPath As String = "Data Source=DESKTOP-4OGTIB2\DIAVIEWSQL;Initial Catalog=SPS;Persist Security Info=True;User ID=sa;Password=doc577isin"
    Dim sqlStoppageSelectCmd As String = "SELECT[Stoppage_Details] FROM [Maintenance].[MListMachineStoppage] where [Machine_No] = 'MC1'"

    '//
    Private Sub frmMC1MachineStoppage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modINfrmMC1MachineStoppage = True
        frmMC1StoppageType.Close()
        LoadStoppageToDropdown()
        cboStoppage.Text = ""
        cboCountermeasure.Text = ""
        detailsComplete()
    End Sub
    Private Sub frmMC1MachineStoppage_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        modINfrmMC1MachineStoppage = False
    End Sub
    '//

    '//
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        modINfrmMC1StoppageType = True
        Me.Close()
    End Sub
    '//

    '//
    Private Sub btnMainPage_Click(sender As Object, e As EventArgs) Handles btnMainPage.Click
        modInfrmMC1MainPage = True
        Me.Close()
    End Sub
    '//

    '//
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        modMC1StoppageType = "Machine"
        modMC1StoppageReason = cboStoppage.Text
        modMC1Countermeasure = cboCountermeasure.Text
        modMC1StoppageEndTime = Now()
        modMC1MachineStoppageSaveFlag = True
        modINfrmMC1Ready = True
        Me.Close()
    End Sub
    '//

    '//
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cboStoppage.Text = ""
        cboCountermeasure.Text = ""
    End Sub
    '//

    '// 
    Public Sub LoadStoppageToDropdown()
        Try
            Dim con As New SqlConnection(modSQLPath)
            Dim cmd As New SqlCommand(sqlStoppageSelectCmd, con)
            Dim adapter As New SqlDataAdapter(cmd)
            con.Open()
            Dim table As New DataTable()
            table.Clear()
            adapter.Fill(table)
            con.Close()
            cboStoppage.DataSource = table
            cboStoppage.DisplayMember = "Stoppage_Details"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    '//

    Public Sub LoaCountermeasureToDropdown()
        Try
            Dim sqlCountermeasureSelectCmd As String = "SELECT [Countermeasure] FROM [Maintenance].[MListMachineCountermeasure]" _
         & "where [Machine_No] = 'MC1'  AND [Stoppage_Details] = '" + cboStoppage.Text + "'"
            Dim con As New SqlConnection(modSQLPath)
            Dim cmd As New SqlCommand(sqlCountermeasureSelectCmd, con)
            Dim adapter As New SqlDataAdapter(cmd)
            con.Open()
            Dim table As New DataTable()
            table.Clear()
            adapter.Fill(table)
            con.Close()
            cboCountermeasure.DataSource = table
            cboCountermeasure.DisplayMember = "Countermeasure"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub cboStoppage_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboStoppage.SelectedValueChanged
        LoaCountermeasureToDropdown()
        cboCountermeasure.Text = ""
    End Sub

    Public Sub detailsComplete()
        If cboStoppage.Text <> "" And cboCountermeasure.Text <> "" Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub tmrRealTimeCheck_Tick(sender As Object, e As EventArgs) Handles tmrRealTimeCheck.Tick
        detailsComplete()
    End Sub

    '//

End Class