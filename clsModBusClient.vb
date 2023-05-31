Imports EasyModbus

Public Class clsModBusClient
    Public IPAddress As String = "169.254.190.100"
    Public Port As Integer = 502

    Public Sub WriteCoilRegister()
        Dim ModClient As New EasyModbus.ModbusClient

        ModClient.IPAddress = IPAddress
        ModClient.Port = Port




    End Sub
End Class
