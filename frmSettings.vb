Imports System.Data.SqlClient
Imports EasyModbus
Public Class frmSettings

    Dim modClient As New EasyModbus.ModbusClient

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Public Sub ConnectToModbus()
        modClient.IPAddress = txtIP.Text
        modClient.Port = txtPort.Text
        modClient.ConnectionTimeout = 3000
        modClient.NumberOfRetries = 5

        Try
            modClient.Connect()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub DisconnetFromModbus()
        modClient.Disconnect()
    End Sub

    Public Sub Connect_Disconnect_Btn_EnableDisable()
        If modClient.Connected = True Then
            btnConnect.Enabled = False
            btnDisconnect.Enabled = True
            lblStatus.Text = "Connected!"
        Else
            btnConnect.Enabled = True
            btnDisconnect.Enabled = False
            lblStatus.Text = "Disonnected!"
        End If
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        ConnectToModbus()
        Connect_Disconnect_Btn_EnableDisable()
    End Sub

    Private Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
        DisconnetFromModbus()
        Connect_Disconnect_Btn_EnableDisable()
    End Sub

    Public Sub readCoilsRegisters()
        Try
            'Modbuss address 2048 = M0 (Delta PLC) and so on for Coil registers
            Dim rxCoil() As Boolean = modClient.ReadCoils(2048, 45)
            RxPLCM0 = rxCoil(0) '2048 MC1 ON/OFF FLAG (EXternal Triggered)
            RxPLCM1 = rxCoil(1) '2049 MC2 ON/OFF FLAG (External Triggered)
            RxPLCM2 = rxCoil(2) '2050
            RxPLCM3 = rxCoil(3) '2051 MC1 KIOSK Login & JO Flag
            RxPLCM4 = rxCoil(4) '2052 MC2 KIOSK Login & JO Flag
            RxPLCM5 = rxCoil(5) '2053
            RxPLCM6 = rxCoil(6) '2054 MC1 Machine Ready (Machine HMI)
            RxPLCM7 = rxCoil(7) '2055 MC2 Machine Ready (Machine HMI)
            RxPLCM8 = rxCoil(8) '2056
            RxPLCM9 = rxCoil(9) '2057 MC1 KIOSK CONDITION TRIGGERED Flag
            RxPLCM10 = rxCoil(10) '2058 MC2 KIOSK CONDITION TRIGGERED Flag
            RxPLCM11 = rxCoil(11) '2059
            RxPLCM12 = rxCoil(12) '2060 MC1 Test Auto Mode Flag (Machine HMI)
            RxPLCM13 = rxCoil(13) '2061 MC2 Test Auto Mode Flag (Machine HMI)
            RxPLCM14 = rxCoil(14)
            RxPLCM15 = rxCoil(15)
            RxPLCM16 = rxCoil(16)
            RxPLCM17 = rxCoil(17)
            RxPLCM18 = rxCoil(18)
            RxPLCM19 = rxCoil(19)
            RxPLCM20 = rxCoil(20)
            RxPLCM21 = rxCoil(21)
            RxPLCM22 = rxCoil(22)
            RxPLCM23 = rxCoil(23)
            RxPLCM24 = rxCoil(24)
            RxPLCM25 = rxCoil(25)
            RxPLCM26 = rxCoil(26)
            RxPLCM27 = rxCoil(27)
            RxPLCM28 = rxCoil(28)
            RxPLCM29 = rxCoil(29)
            RxPLCM30 = rxCoil(30)
            RxPLCM31 = rxCoil(31)
            RxPLCM32 = rxCoil(32)
            RxPLCM33 = rxCoil(33)
            RxPLCM34 = rxCoil(34)
            RxPLCM35 = rxCoil(35)
            RxPLCM36 = rxCoil(36)
            RxPLCM37 = rxCoil(37)
            RxPLCM38 = rxCoil(38)
            RxPLCM39 = rxCoil(39)
            RxPLCM40 = rxCoil(40)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub ReadHoldingRegs()
        'Modbuss address 6096 = D2000 (Delta PLC) and so on for holding registers
        Try
            Dim ReadValue() As Integer = modClient.ReadHoldingRegisters(6096, 100)
            lblComCheck.Text = ReadValue(0) '6096
            modComCheck = ReadValue(0)

            'Double Word Declaration for Modbus 6098,6099 which is equal to D2002,D2003 of delta PLC
            Dim dwD2002(2) As Integer 'MC1 Machine Counter (Double Register)
            dwD2002(0) = ReadValue(2) '6098
            dwD2002(1) = ReadValue(3) '6099
            D2002 = ModbusClient.ConvertRegistersToInt(dwD2002, 0)

            Dim dwD2004(2) As Integer 'MC2 Machine Counter (Double Rregister)
            dwD2004(0) = ReadValue(4) '6100
            dwD2004(1) = ReadValue(5) '6101
            D2004 = ModbusClient.ConvertRegistersToInt(dwD2004, 0)

            Dim dwD2006(2) As Integer 'MC1 User ID (Double Register)
            dwD2006(0) = ReadValue(6) '6102
            dwD2006(1) = ReadValue(7) '6103
            D2006 = ModbusClient.ConvertRegistersToInt(dwD2006, 0)

            Dim dwD2008(2) As Integer 'MC2 User ID (Double Register)
            dwD2008(0) = ReadValue(8) '6104
            dwD2008(1) = ReadValue(9) '6105
            D2008 = ModbusClient.ConvertRegistersToInt(dwD2008, 0)

            Dim dwD2010(2) As Integer 'MC1 Plan Qty (Double Register)
            dwD2010(0) = ReadValue(10) '6106
            dwD2010(1) = ReadValue(11) '6107
            D2010 = ModbusClient.ConvertRegistersToInt(dwD2010, 0)

            Dim dwD2012(2) As Integer 'MC2 Plan Qty (Double Register)
            dwD2012(0) = ReadValue(12) '6108
            dwD2012(1) = ReadValue(13) '6109
            D2012 = ModbusClient.ConvertRegistersToInt(dwD2012, 0)

            Dim dwD2014(2) As Integer 'MC1 Actual Counter (Double Register)
            dwD2014(0) = ReadValue(14) '6110
            dwD2014(1) = ReadValue(15) '6111
            D2014 = ModbusClient.ConvertRegistersToInt(dwD2014, 0)

            Dim dwD2016(2) As Integer 'MC2 Actual Counter (Double Register)
            dwD2016(0) = ReadValue(16) '6112
            dwD2016(1) = ReadValue(17) '6113
            D2016 = ModbusClient.ConvertRegistersToInt(dwD2016, 0)

            D2018 = ReadValue(18) '6114 MC1JOCode1
            D2019 = ReadValue(19) '6115 MC1JOCode2
            D2020 = ReadValue(20) '6116 MC1JOCode3
            D2021 = ReadValue(21) '6117 MC1JOCode4
            D2022 = ReadValue(22) '6118 MC1JOCode5
            D2023 = ReadValue(23) '6119 MC1JOCode6
            D2024 = ReadValue(24) '6120 Empty
            D2025 = ReadValue(25) '6121 MC2JOCode1
            D2026 = ReadValue(26) '6122 MC2JOCode2
            D2027 = ReadValue(27) '6123 MC2JOCode3
            D2028 = ReadValue(28) '6124 MC2JOCode4
            D2029 = ReadValue(29) '6125 MC2JOCode5
            D2030 = ReadValue(30) '6126 MC2JOCode6
            D2031 = ReadValue(31) '6127 EMPTY

            Dim dwD2032(2) As Integer ''MC1 Total Counter (Double Register)
            dwD2032(0) = ReadValue(32) '6128
            dwD2032(1) = ReadValue(33) '6129 
            D2032 = ModbusClient.ConvertRegistersToInt(dwD2032, 0)

            Dim dwD2034(2) As Integer ''MC2 Total Counter (Double Register)
            dwD2034(0) = ReadValue(34) '6130 
            dwD2034(1) = ReadValue(35) '6131
            D2034 = ModbusClient.ConvertRegistersToInt(dwD2034, 0)

            D2036 = ReadValue(36) '6132
            D2037 = ReadValue(37) '6133
            D2038 = ReadValue(38) '6134 
            D2039 = ReadValue(39) '6135 
            D2040 = ReadValue(40) '6136

            'lblRx4.Text = (ReadValue(5) + ReadValue(4)) * 65535.0F
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub comCheckWriteHoldingRegs()
        Try
            If lblComCheck.Text = "0" Then
                modClient.WriteSingleRegister(6096, 1)
                System.Threading.Thread.SpinWait(1000)
            ElseIf lblComCheck.Text <> "0" Then
                modClient.WriteSingleRegister(6096, 0)
                System.Threading.Thread.SpinWait(1000)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tmrRealTimeCheck_Tick(sender As Object, e As EventArgs) Handles tmrComCheck.Tick
        If modClient.Connected = True Then
            comCheckWriteHoldingRegs()
        End If
    End Sub
    Private Sub tmrRealTimeCheck_Tick_1(sender As Object, e As EventArgs) Handles tmrRealTimeCheck.Tick
        If modClient.Connected = True Then
            ReadHoldingRegs()
            readCoilsRegisters()
            'MC1StartStopFlag()
            'MC2StartStopFlag()
            MC1TestAutoModeFlag()
            MachineReadyFlag()
        End If
        modMC1TestAutoMOdeCounterSet = txtTAMCounterSet.Text
        modSettingValMachineID = cboMachineName.Text
    End Sub

    'Public Sub MC1StartStopFlag()
    '    If modClient.Connected = True Then
    '        If modStartStopMC1 = True Then
    '            modClient.WriteSingleCoil(2048, True) 'MC1 ON
    '        Else
    '            modClient.WriteSingleCoil(2048, False) 'MC1 OFF
    '        End If
    '    End If
    'End Sub

    'Public Sub MC2StartStopFlag()
    '    If modClient.Connected = True Then
    '        If modStartStopMC2 = True Then
    '            modClient.WriteSingleCoil(2049, True) 'MC2 ON
    '        Else
    '            modClient.WriteSingleCoil(2049, False) 'MC2 OFF
    '        End If
    '    End If
    'End Sub

    Public Sub MachineReadyFlag()
        If modClient.Connected = True Then
            If modINfrmMC1Ready = True Then
                modClient.WriteSingleCoil(2054, True) 'MC6 ON
            Else
                modClient.WriteSingleCoil(2054, False) 'MC6 OFF
            End If
        End If
    End Sub

    Public Sub MC1TestAutoModeFlag()
        If modClient.Connected = True Then
            If modTestAutoModeMC1Flag = True Then
                modClient.WriteSingleCoil(2060, True) 'MC12 ON
            Else
                modClient.WriteSingleCoil(2060, False) 'MC12 OFF
            End If
        End If
    End Sub

End Class
