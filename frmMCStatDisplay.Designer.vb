﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMCStatDisplay
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tmrRealTimeCheck = New System.Windows.Forms.Timer(Me.components)
        Me.pnlMC1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblElapsTimeMC1 = New System.Windows.Forms.Label()
        Me.lblStatMC1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pnlMC1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrRealTimeCheck
        '
        Me.tmrRealTimeCheck.Enabled = True
        '
        'pnlMC1
        '
        Me.pnlMC1.BackColor = System.Drawing.Color.DarkOrange
        Me.pnlMC1.Controls.Add(Me.Label1)
        Me.pnlMC1.Controls.Add(Me.lblElapsTimeMC1)
        Me.pnlMC1.Controls.Add(Me.lblStatMC1)
        Me.pnlMC1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMC1.Location = New System.Drawing.Point(3, 22)
        Me.pnlMC1.Name = "pnlMC1"
        Me.pnlMC1.Size = New System.Drawing.Size(466, 361)
        Me.pnlMC1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 314)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Elapsed Time:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblElapsTimeMC1
        '
        Me.lblElapsTimeMC1.BackColor = System.Drawing.Color.Transparent
        Me.lblElapsTimeMC1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblElapsTimeMC1.ForeColor = System.Drawing.Color.Black
        Me.lblElapsTimeMC1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblElapsTimeMC1.Location = New System.Drawing.Point(184, 312)
        Me.lblElapsTimeMC1.Name = "lblElapsTimeMC1"
        Me.lblElapsTimeMC1.Size = New System.Drawing.Size(272, 35)
        Me.lblElapsTimeMC1.TabIndex = 5
        Me.lblElapsTimeMC1.Text = "0"
        Me.lblElapsTimeMC1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStatMC1
        '
        Me.lblStatMC1.BackColor = System.Drawing.Color.Transparent
        Me.lblStatMC1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatMC1.ForeColor = System.Drawing.Color.Black
        Me.lblStatMC1.Location = New System.Drawing.Point(10, 43)
        Me.lblStatMC1.Name = "lblStatMC1"
        Me.lblStatMC1.Size = New System.Drawing.Size(446, 192)
        Me.lblStatMC1.TabIndex = 3
        Me.lblStatMC1.Text = "Please Login" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "@ KIOSK"
        Me.lblStatMC1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pnlMC1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(472, 386)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Machine 1"
        '
        'frmMCStatDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(488, 400)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMCStatDisplay"
        Me.Text = "frmMachineRunning"
        Me.pnlMC1.ResumeLayout(False)
        Me.pnlMC1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrRealTimeCheck As Timer
    Friend WithEvents pnlMC1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblElapsTimeMC1 As Label
    Friend WithEvents lblStatMC1 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
