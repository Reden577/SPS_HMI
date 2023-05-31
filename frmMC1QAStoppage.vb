Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class frmMC1QAStoppage

    'Dim sqlPath As String = "Data Source=DESKTOP-4OGTIB2\DIAVIEWSQL;Initial Catalog=SPS;Persist Security Info=True;User ID=sa;Password=doc577isin"
    Dim sqlStoppageSelectCmd As String = "SELECT[Quality_Issue] FROM [Quality].[MListQualityStoppage]"

    '//
    Private Sub frmMC1QAStoppage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modINfrmMC1QAStoppage = True
        frmMC1MainPage.Close()
        frmMC1QAVerification.Close()
        LoadStoppageToDropdown()
        cboStoppage.Text = ""
        cboCountermeasure.Text = ""

        If modMC1QASendSampleFlag = True Then
            cboStoppage.Text = My.Settings.QAStoppage
            cboCountermeasure.Text = My.Settings.QACountermeasure
        Else
            cboStoppage.Text = ""
            cboCountermeasure.Text = ""
        End If

        'modMC1QASendSampleFlag = False
        tmrRstFailFlag.Start()
        detailsComplete()
    End Sub
    Private Sub frmMC1QAStoppage_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        modINfrmMC1QAStoppage = False
    End Sub
    Private Sub frmMC1QAStoppage_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.QAStoppage = cboStoppage.Text
        My.Settings.QACountermeasure = cboCountermeasure.Text
    End Sub
    '//

    '//
    Private Sub btnMainPage_Click(sender As Object, e As EventArgs) Handles btnMainPage.Click
        modInfrmMC1MainPage = True
        Me.Close()
    End Sub
    '//

    '//
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSendSample.Click
        modMC1StoppageType = "Quality"
        modMC1StoppageReason = cboStoppage.Text
        modMC1Countermeasure = cboCountermeasure.Text
        modMC1StoppageEndTime = Now()
        'modMC1QAStoppageSaveFlag = True
        modMC1QASendSampleFlag = True
        modINfrmMC1QAVerification = True
        Me.Close()
    End Sub
    '//

    '//
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cboStoppage.Text = ""
        cboCountermeasure.Text = ""
    End Sub

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
            cboStoppage.DisplayMember = "Quality_Issue"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Loading Quality Stoppage List", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    '//

    '//
    Public Sub LoaCountermeasureToDropdown()
        Try
            Dim sqlCountermeasureSelectCmd As String = "SELECT [Countermeasure] FROM [Quality].[MListQualityCountermeasure]" _
         & "where [Machine_No] = 'MC1' AND [Stoppage_Details] = '" + cboStoppage.Text + "'   "
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
            MessageBox.Show(ex.Message, "Loading Countermeasure List", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    '//

    '//
    Private Sub cboStoppage_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboStoppage.SelectedValueChanged
        LoaCountermeasureToDropdown()
        cboCountermeasure.Text = ""
    End Sub


    Public Sub detailsComplete()
        If cboStoppage.Text <> "" And cboCountermeasure.Text <> "" Then
            btnSendSample.Enabled = True
        Else
            btnSendSample.Enabled = False
        End If
    End Sub

    Private Sub tmrRealTimeCheck_Tick(sender As Object, e As EventArgs) Handles tmrRealTimeCheck.Tick
        detailsComplete()
    End Sub

    Private Sub tmrRstFailFlag_Tick(sender As Object, e As EventArgs) Handles tmrRstFailFlag.Tick
        modMC1QAVerifyFailFlag = False
        tmrRstFailFlag.Stop()
    End Sub


    '//
End Class