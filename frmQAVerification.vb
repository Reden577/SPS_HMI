Public Class frmQAVerification
    Private Sub frmQAVerification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Public Sub QAVerification()
        Dim QAId As String
        Dim QAAcsRights As String

        'Get User ID
        Dim UId As New clsGetUserID
        UId.UD_stUserID = txtUserID.Text
        UId.GetUserID()
        QAId = UId.GetUId

        If QAId = txtUserID.Text Then
            Dim UDetails As New clsGetUserName_N_AccessRights
            UDetails.UD_stUserID = txtUserID.Text
            UDetails.GetUserName_AccessRights()

            QAAcsRights = UDetails.UD_stAccessRights
            modQA_GetUserName = UDetails.UD_stUserName
            modQA_GetUserID = UDetails.UD_stUserID
            modQA_GetPassword = UDetails.UD_stPassword
            modQA_GetOTS = UDetails.UD_stOTS

            If QAAcsRights = "QALvl1" Or QAAcsRights = "QALvl2" Then
                modQA_AccessGranted = True
                txtUserID.Text = ""
                Me.Close()
            Else
                MessageBox.Show("You are not allowed to do this Transaction." &
                                vbNewLine & "Only QA Access Rights are allowed...", "Checking User Access Rights...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtUserID.Text = ""
            End If
        Else
            MessageBox.Show("Invalid User ID." &
                                vbNewLine & "Please input a valid User ID...", "Checking User Access Rights...", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtUserID.Text = ""
        End If

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        QAVerification()

    End Sub
End Class