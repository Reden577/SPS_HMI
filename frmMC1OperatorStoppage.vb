Imports System.Data.SqlClient

Public Class frmMC1OperatorStoppage

    Dim sqlPath As String = "Data Source=DESKTOP-4OGTIB2\DIAVIEWSQL;Initial Catalog=SPS;Persist Security Info=True;User ID=sa;Password=doc577isin"
    Dim sqlOperatorSelectCmd As String = "SELECT[Operator_Stoppage] FROM [Production].[MListOperatorStoppage]"

    '//
    Private Sub frmMC1OperatorStoppage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modINfrmMC1OperatorStoppage = True
        frmMC1StoppageType.Close()
        LoadOperatorStoppageToDropdown()
        cboUDT.Text = ""
        DetailsCompelte_BtnEnableDisable()
    End Sub
    Private Sub frmMC1OperatorStoppage_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        modINfrmMC1OperatorStoppage = False
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
    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        modMC1OptStoppageSaveFlag = True
        modMC1StoppageType = "Operator"
        modMC1StoppageReason = cboUDT.Text
        modMC1StoppageEndTime = Now()
        modINfrmMC1Ready = True
        Me.Close()
    End Sub
    '//

    '//
    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cboUDT.Text = ""
    End Sub
    '//

    '// LOADING THE OPERATOR STOPPAGE TO DROPDOWN LIST
    Public Sub LoadOperatorStoppageToDropdown()
        Dim con As New SqlConnection(sqlPath)
        Dim cmd As New SqlCommand(sqlOperatorSelectCmd, con)
        Dim adapter As New SqlDataAdapter(cmd)
        con.Open()
        Dim table As New DataTable()
        adapter.Fill(table)
        con.Close()
        cboUDT.DataSource = table
        cboUDT.DisplayMember = "Operator_Stoppage"
    End Sub
    '//

    '// 
    Public Sub DetailsCompelte_BtnEnableDisable()
        If cboUDT.Text <> "" Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If
    End Sub

    '//
    Private Sub tmrRealTimeCheck_Tick(sender As Object, e As EventArgs) Handles tmrRealTimeCheck.Tick
        DetailsCompelte_BtnEnableDisable()
    End Sub


    '//


End Class