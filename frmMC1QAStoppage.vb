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

        If modMC1QASendSampleFlag = True Then
            cboStoppage.Text = My.Settings.QAStoppage
            cboCountermeasure.Text = My.Settings.QACountermeasure
        Else
            cboStoppage.Text = ""
            cboCountermeasure.Text = ""
        End If

        tmrRstFailFlag.Start()
        detailsComplete()
        CheckLoggedQualityStoppage()

        If cboStoppage.Text <> "" And cboCountermeasure.Text <> "" Then
            grpStopDetails.Enabled = False
            btnClear.Enabled = False
        End If

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
        If cboStoppage.Text <> "" And cboCountermeasure.Text <> "" And cboCountermeasure.Text <> "TBA" Then
            modMC1StoppageType = "Quality"
            modMC1StoppageReason = cboStoppage.Text
            modMC1Countermeasure = cboCountermeasure.Text
            modMC1StoppageEndTime = Now()

            UpdateDowntimeAtStoppageSaved()

            modMC1QASendSampleFlag = True
            modINfrmMC1QAVerification = True
            cboStoppage.Enabled = False
            cboCountermeasure.Enabled = False

            Me.Close()
        Else
            MessageBox.Show("Invalid Stoppage Details..." &
                             vbNewLine & "Please input valid Stoppage and Countermeasure Details...",
                            "Saving Stoppage and Countermeasure Details...", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
    '//

    '// UPDATE DOWNTIME DETAILS AT SEND SAMPLE TO QA
    Public Sub UpdateDowntimeAtStoppageSaved()
        Dim upD8 As New clsUpdateDTDetails_StoppageSave
        upD8.DTType = "Quality"
        upD8.DTReason = cboStoppage.Text
        upD8.DTCountermeasure = cboCountermeasure.Text
        upD8.EndTime = Now()
        upD8.TtlRepairTime = Math.Round((modMC1RepairTimer / 60), 4)
        upD8.ForQAVeri = Now()
        upD8.TtlFailFreq = modMC1FailCounters
        upD8.UpdateDowntimeAtStoppageSaved()
    End Sub
    '//

    '//
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cboStoppage.Text = ""
        cboCountermeasure.Text = ""
    End Sub
    '// 

    '//
    Private Sub btnEditDetails_Click(sender As Object, e As EventArgs) Handles btnEditDetails.Click
        grpStopDetails.Enabled = True
        btnClear.Enabled = True
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
         & "where [Machine_No] = '" + modSettingValMachineID + "'  AND [Stoppage_Details] = '" + cboStoppage.Text + "'   "
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
        'modMC1QAVerifyFailFlag = False
        tmrRstFailFlag.Stop()
    End Sub
    '//

    '//
    '// CHECKING AND LOADING QUALITY STOPPAGE DETAILS
    Public Sub CheckLoggedQualityStoppage()
        Dim result As Integer
        Dim cnt As New clsCountDTType_byDTStatusMCId
        cnt.DTType = "Quality"
        cnt.DTStatus = modSetVal_NewStoppage
        cnt.MCID = modSettingValMachineID
        cnt.CountDTType()
        result = cnt.cntDTtype

        If result >= 1 Then
            Dim sel As New clsSelDTReasonCMeasure
            sel.DTType = "Quality"
            sel.MCID = modSettingValMachineID
            sel.DTStatus = modSetVal_NewStoppage
            sel.SelDTReason_CMeasure()
            cboStoppage.Text = sel.DTReason
            cboCountermeasure.Text = sel.DTCountermeasure
            modMC1FailCounters = sel.TtlFailFreq
        Else
            cboStoppage.SelectedIndex = -1
            cboCountermeasure.SelectedIndex = -1
        End If
    End Sub


    '//
End Class