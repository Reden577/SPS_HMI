﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMC1NoPlan
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pnlMC1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblElapsTimeMC1 = New System.Windows.Forms.Label()
        Me.lblStatMC1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tmrRealTimeCheck = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.pnlMC1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pnlMC1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(629, 1092)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "*"
        '
        'pnlMC1
        '
        Me.pnlMC1.BackColor = System.Drawing.Color.MediumPurple
        Me.pnlMC1.Controls.Add(Me.Label1)
        Me.pnlMC1.Controls.Add(Me.lblElapsTimeMC1)
        Me.pnlMC1.Controls.Add(Me.lblStatMC1)
        Me.pnlMC1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMC1.ForeColor = System.Drawing.Color.Black
        Me.pnlMC1.Location = New System.Drawing.Point(3, 22)
        Me.pnlMC1.Name = "pnlMC1"
        Me.pnlMC1.Size = New System.Drawing.Size(623, 1067)
        Me.pnlMC1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(14, 1013)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 31)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Elapsed Time:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.Visible = False
        '
        'lblElapsTimeMC1
        '
        Me.lblElapsTimeMC1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblElapsTimeMC1.BackColor = System.Drawing.Color.Transparent
        Me.lblElapsTimeMC1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblElapsTimeMC1.ForeColor = System.Drawing.Color.White
        Me.lblElapsTimeMC1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblElapsTimeMC1.Location = New System.Drawing.Point(209, 1011)
        Me.lblElapsTimeMC1.Name = "lblElapsTimeMC1"
        Me.lblElapsTimeMC1.Size = New System.Drawing.Size(272, 35)
        Me.lblElapsTimeMC1.TabIndex = 8
        Me.lblElapsTimeMC1.Text = "0"
        Me.lblElapsTimeMC1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblElapsTimeMC1.Visible = False
        '
        'lblStatMC1
        '
        Me.lblStatMC1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatMC1.BackColor = System.Drawing.Color.Transparent
        Me.lblStatMC1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatMC1.ForeColor = System.Drawing.Color.White
        Me.lblStatMC1.Location = New System.Drawing.Point(3, 311)
        Me.lblStatMC1.Name = "lblStatMC1"
        Me.lblStatMC1.Size = New System.Drawing.Size(613, 298)
        Me.lblStatMC1.TabIndex = 6
        Me.lblStatMC1.Text = "NO PLAN"
        Me.lblStatMC1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(651, 1114)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'tmrRealTimeCheck
        '
        Me.tmrRealTimeCheck.Enabled = True
        '
        'frmMC1NoPlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(651, 1114)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMC1NoPlan"
        Me.Text = "MC1NoPlan"
        Me.GroupBox1.ResumeLayout(False)
        Me.pnlMC1.ResumeLayout(False)
        Me.pnlMC1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents pnlMC1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblElapsTimeMC1 As Label
    Friend WithEvents lblStatMC1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents tmrRealTimeCheck As Timer
End Class
