Imports System.Data.SqlClient
Imports System.Windows.Controls

Public Class frmMC1MachineStoppage

    'Dim sqlPath As String = "Data Source=DESKTOP-4OGTIB2\DIAVIEWSQL;Initial Catalog=SPS;Persist Security Info=True;User ID=sa;Password=doc577isin"
    Dim sqlStoppageSelectCmd As String = "SELECT[Stoppage_Details] FROM [Maintenance].[MListMachineStoppage] where [Machine_No] = 'MC1'"

    Dim listStopIsShow As Boolean
    Dim listCmeasureIsShow As Boolean
    '//
    Private Sub frmMC1MachineStoppage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstStoppage.Visible = False
        lstCmeasure.Visible = False
        txtCMeasure.Enabled = False
        btnCmeasure.Enabled = False

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
        modMC1StoppageReason = txtStoppage.Text
        modMC1Countermeasure = txtCMeasure.Text
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

            lstStoppage.DataSource = table
            lstStoppage.DisplayMember = "Stoppage_Details"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Loading Machine Stoppage Details...", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    '//

    Public Sub LoaCountermeasureToDropdown()
        Try
            Dim sqlCountermeasureSelectCmd As String = "SELECT [Countermeasure] FROM [Maintenance].[MListMachineCountermeasure]" _
         & "where [Machine_No] = 'MC1'  AND [Stoppage_Details] = '" + txtStoppage.Text + "'"
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
            MessageBox.Show(ex.Message, "Loading Machine Countermeasure...", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub cboStoppage_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboStoppage.SelectedValueChanged
        LoaCountermeasureToDropdown()
        cboCountermeasure.Text = ""
    End Sub

    Public Sub detailsComplete()
        If txtStoppage.Text <> "" And txtCMeasure.Text <> "" Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub tmrRealTimeCheck_Tick(sender As Object, e As EventArgs) Handles tmrRealTimeCheck.Tick
        detailsComplete()
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

    Private Sub txtStoppage_TextChanged(sender As Object, e As EventArgs) Handles txtStoppage.TextChanged
        txtCMeasure.Text = ""
        lstCmeasure.Visible = False
        listCmeasureIsShow = False
    End Sub

    Private Sub pnlMC1_Click(sender As Object, e As EventArgs) Handles pnlMC1.Click
        lstStoppage.Visible = False
        lstCmeasure.Visible = False
        listStopIsShow = False
        listCmeasureIsShow = False
    End Sub

    '//

End Class