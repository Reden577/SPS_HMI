Imports System.ComponentModel
Imports System.Data.SqlClient
Imports EasyModbus
Public Class frmSettings

    Dim modClient As New EasyModbus.ModbusClient

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        cboMachineName.Text = My.Settings.MachineNo
        txtSQLPath.Text = My.Settings.SQLPath
        txtTAMCounterSet.Text = My.Settings.TAMSetShots
        txtIP.Text = My.Settings.IpAddress
        txtPort.Text = My.Settings.Port

        modSQLPath = txtSQLPath.Text
    End Sub
    Private Sub frmSettings_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.MachineNo = cboMachineName.Text
        My.Settings.SQLPath = txtSQLPath.Text
        My.Settings.TAMSetShots = txtTAMCounterSet.Text
        My.Settings.IpAddress = txtIP.Text
        My.Settings.Port = txtPort.Text
    End Sub

    Public Sub LoadSettingValues()
        modSQLPath = My.Settings.SQLPath
        modSetVal_IPAddress = My.Settings.IpAddress
        modSetVal_Por = My.Settings.Port
        modSettingValMachineID = My.Settings.MachineNo
        modMC1TestAutoMOdeCounterSet = My.Settings.TAMSetShots
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles btnSaveSettings.Click
        My.Settings.SQLPath = txtSQLPath.Text
        My.Settings.IpAddress = txtIP.Text
        My.Settings.Port = txtPort.Text
        My.Settings.MachineNo = cboMachineName.Text
        My.Settings.TAMCounter = txtTAMCounterSet.Text
        My.Settings.Save()
        LoadSettingValues()
        MessageBox.Show("Settings Saved to My.Settings!", "Saving Values to My.Settings...", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class
