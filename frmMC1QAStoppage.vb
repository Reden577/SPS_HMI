Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Windows.Documents

Public Class frmMC1QAStoppage

    'Dim sqlPath As String = "Data Source=DESKTOP-4OGTIB2\DIAVIEWSQL;Initial Catalog=SPS;Persist Security Info=True;User ID=sa;Password=doc577isin"
    Dim sqlStoppageSelectCmd As String = "SELECT[Quality_Issue] FROM [Quality].[MListQualityStoppage]"

    Dim listStopIsShow As Boolean
    Dim listCmeasureIsShow As Boolean
    '//
    Private Sub frmMC1QAStoppage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modINfrmMC1QAStoppage = True

        lstStoppage.Visible = False
        lstCmeasure.Visible = False
        txtCMeasure.Enabled = False
        btnCmeasure.Enabled = False

        frmMC1MainPage.Close()
        frmMC1QAVerification.Close()
        LoadStoppageToDropdown()

        If modMC1QASendSampleFlag = True Then
            txtStoppage.Text = My.Settings.QAStoppage
            txtCMeasure.Text = My.Settings.QACountermeasure
        Else
            txtStoppage.Text = ""
            txtCMeasure.Text = ""
        End If

        tmrRstFailFlag.Start()
        detailsComplete()
        CheckLoggedQualityStoppage()

        If txtStoppage.Text <> "" And txtCMeasure.Text <> "" Then
            grpStopDetails.Enabled = False
            txtStoppage.Enabled = False
            txtCMeasure.Enabled = False
            btnStoppage.Enabled = False
            btnCmeasure.Enabled = False
            btnClear.Enabled = False
        End If

    End Sub
    Private Sub frmMC1QAStoppage_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        modINfrmMC1QAStoppage = False
    End Sub
    Private Sub frmMC1QAStoppage_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.QAStoppage = txtStoppage.Text
        My.Settings.QACountermeasure = txtCMeasure.Text
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
        If txtStoppage.Text <> "" And txtCMeasure.Text <> "" And txtCMeasure.Text <> "TBA" Then
            modMC1StoppageType = "Quality"
            modMC1StoppageReason = txtStoppage.Text
            modMC1Countermeasure = txtCMeasure.Text
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
        upD8.DTReason = txtStoppage.Text
        upD8.DTCountermeasure = txtCMeasure.Text
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

        lstStoppage.SelectedItems.Clear()
        txtStoppage.Text = ""
        lstStoppage.Visible = False
        listStopIsShow = False

        lstCmeasure.SelectedItems.Clear()
        txtCMeasure.Text = ""
        lstCmeasure.Visible = False
        listCmeasureIsShow = False

        txtCMeasure.Enabled = False
        btnCmeasure.Enabled = False
    End Sub
    '// 

    '//
    Private Sub btnEditDetails_Click(sender As Object, e As EventArgs) Handles btnEditDetails.Click
        grpStopDetails.Enabled = True

        txtStoppage.Enabled = True
        txtCMeasure.Enabled = True
        btnStoppage.Enabled = True
        btnCmeasure.Enabled = True
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

            lstStoppage.DataSource = table
            lstStoppage.DisplayMember = "Quality_Issue"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Loading Quality Stoppage List", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    '//

    '//
    Public Sub LoaCountermeasureToDropdown()
        Try
            Dim sqlCountermeasureSelectCmd As String = "SELECT [Countermeasure] FROM [Quality].[MListQualityCountermeasure]" _
         & "where [Machine_No] = '" + modSettingValMachineID + "'  AND [Stoppage_Details] = '" + txtStoppage.Text + "'   "
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

            lstCmeasure.DataSource = table
            lstCmeasure.DisplayMember = "Countermeasure"
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
        If txtStoppage.Text <> "" And txtCMeasure.Text <> "" And txtCMeasure.Text <> "TBA" Then
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
            txtStoppage.Text = sel.DTReason
            txtCMeasure.Text = sel.DTCountermeasure
            modMC1FailCounters = sel.TtlFailFreq
        Else
            txtStoppage.Text = ""
            txtCMeasure.Text = ""
        End If
    End Sub

    Private Sub pnlMC1_Click(sender As Object, e As EventArgs) Handles pnlMC1.Click
        lstStoppage.Visible = False
        lstCmeasure.Visible = False
        listStopIsShow = False
        listCmeasureIsShow = False
    End Sub

    Private Sub txtStoppage_TextChanged(sender As Object, e As EventArgs) Handles txtStoppage.TextChanged
        txtCMeasure.Text = ""
        lstCmeasure.Visible = False
        listCmeasureIsShow = False
    End Sub

    Private Sub lstStoppage_Click(sender As Object, e As EventArgs) Handles lstStoppage.Click
        txtStoppage.Text = lstStoppage.GetItemText(lstStoppage.SelectedItem)
        If txtStoppage.Text <> "" Then
            listStopIsShow = False
            lstStoppage.Visible = False
            txtCMeasure.Enabled = True
            btnCmeasure.Enabled = True
        End If
    End Sub

    Private Sub lstCmeasure_Click(sender As Object, e As EventArgs) Handles lstCmeasure.Click
        txtCMeasure.Text = lstCmeasure.GetItemText(lstCmeasure.SelectedItem)
        If txtCMeasure.Text <> "" Then
            listCmeasureIsShow = False
            lstCmeasure.Visible = False

        End If
    End Sub

    Private Sub btnStoppage_Click(sender As Object, e As EventArgs) Handles btnStoppage.Click
        If listStopIsShow = False Then
            listStopIsShow = True
            LoadStoppageToDropdown()
            lstStoppage.SelectedItems.Clear()
            'txtStoppage.Text = ""
            lstStoppage.Visible = True
        ElseIf listStopIsShow = True Then
            lstStoppage.Visible = False
            listStopIsShow = False
        End If

        lstCmeasure.Visible = False
        listCmeasureIsShow = False
    End Sub

    Private Sub btnCmeasure_Click(sender As Object, e As EventArgs) Handles btnCmeasure.Click
        If lstStoppage.Visible = False Then
            If listCmeasureIsShow = False Then
                listCmeasureIsShow = True
                LoaCountermeasureToDropdown()
                lstCmeasure.SelectedItems.Clear()
                'txtCMeasure.Text = ""
                lstCmeasure.Visible = True
            ElseIf listCmeasureIsShow = True Then
                lstCmeasure.Visible = False
                listCmeasureIsShow = False
            End If
        End If
    End Sub


    '//
End Class