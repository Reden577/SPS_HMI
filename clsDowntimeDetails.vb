Public Class clsDowntimeDetails
    Public DTDetails_sfUserName As String
    Public DTDetails_sfUserID As String
    Public DTDetails_sfDTType As String
    Public DTDetails_sfStartTime As String
    Public DTDetails_sfDTReason As String
    Public DTDetails_sfDTCmeasure As String
    Public DTDetails_sfACKDate As String
    Public DTDetails_sfEndTime As String
    Public DTDetails_sfRunTime As String
    Public DTDetails_iTtlDTMins As Integer
    Public DTDetails_iTtlRepTimeMins As Integer
    Public DTDetails_sfForQAVeri As String
    Public DTDetails_iTtlQAVeri As Integer
    Public DTDetails_iTtlFailFreq As Integer
    Public DTDetails_sfDTStatus As String
    Public DTDetails_sfJOCode As String
    Public DTDetails_sfMCId As String
    Public DTDetails_sfVeriByQA As String
    Public DTDetails_sfCreatedBy As String

    Public Sub DowntimeDetails()
        MessageBox.Show("Downtime Details")
    End Sub

End Class
