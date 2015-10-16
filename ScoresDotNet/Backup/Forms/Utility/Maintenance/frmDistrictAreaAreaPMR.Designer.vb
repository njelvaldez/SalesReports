<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDistrictAreaAreaPMR
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.gbArea = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpMonth = New System.Windows.Forms.DateTimePicker
        Me.dgvArea = New System.Windows.Forms.DataGridView
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.btnGenerate = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.dgvAreaPMR = New System.Windows.Forms.DataGridView
        Me.gbAreaPMR = New System.Windows.Forms.GroupBox
        Me.gbArea.SuspendLayout()
        CType(Me.dgvArea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvAreaPMR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAreaPMR.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbArea
        '
        Me.gbArea.Controls.Add(Me.Label3)
        Me.gbArea.Controls.Add(Me.dtpMonth)
        Me.gbArea.Controls.Add(Me.dgvArea)
        Me.gbArea.Location = New System.Drawing.Point(18, 12)
        Me.gbArea.Name = "gbArea"
        Me.gbArea.Size = New System.Drawing.Size(1293, 280)
        Me.gbArea.TabIndex = 34
        Me.gbArea.TabStop = False
        Me.gbArea.Text = "Total No of District :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Sales Month :"
        '
        'dtpMonth
        '
        Me.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpMonth.Location = New System.Drawing.Point(99, 12)
        Me.dtpMonth.Name = "dtpMonth"
        Me.dtpMonth.Size = New System.Drawing.Size(147, 20)
        Me.dtpMonth.TabIndex = 10
        Me.dtpMonth.Value = New Date(2014, 6, 1, 9, 59, 0, 0)
        '
        'dgvArea
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvArea.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvArea.Location = New System.Drawing.Point(8, 38)
        Me.dgvArea.Name = "dgvArea"
        Me.dgvArea.Size = New System.Drawing.Size(1281, 227)
        Me.dgvArea.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnGenerate)
        Me.GroupBox4.Controls.Add(Me.btnCancel)
        Me.GroupBox4.Location = New System.Drawing.Point(1062, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(255, 92)
        Me.GroupBox4.TabIndex = 35
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Action"
        '
        'btnGenerate
        '
        Me.btnGenerate.Image = Global.ScoresDotNet.My.Resources.Resources.Gear_icon
        Me.btnGenerate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenerate.Location = New System.Drawing.Point(44, 29)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(103, 38)
        Me.btnGenerate.TabIndex = 1
        Me.btnGenerate.Text = "    &Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.ScoresDotNet.My.Resources.Resources.door_out_icon
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(153, 29)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 38)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "    &Close"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'dgvAreaPMR
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvAreaPMR.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvAreaPMR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAreaPMR.Location = New System.Drawing.Point(12, 28)
        Me.dgvAreaPMR.Name = "dgvAreaPMR"
        Me.dgvAreaPMR.Size = New System.Drawing.Size(1281, 286)
        Me.dgvAreaPMR.TabIndex = 1
        '
        'gbAreaPMR
        '
        Me.gbAreaPMR.Controls.Add(Me.dgvAreaPMR)
        Me.gbAreaPMR.Location = New System.Drawing.Point(16, 307)
        Me.gbAreaPMR.Name = "gbAreaPMR"
        Me.gbAreaPMR.Size = New System.Drawing.Size(1293, 329)
        Me.gbAreaPMR.TabIndex = 33
        Me.gbAreaPMR.TabStop = False
        Me.gbAreaPMR.Text = "Total No of Area :"
        '
        'frmDistrictAreaAreaPMR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1333, 648)
        Me.Controls.Add(Me.gbArea)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.gbAreaPMR)
        Me.Name = "frmDistrictAreaAreaPMR"
        Me.Text = "District-Area-AreaPMR"
        Me.gbArea.ResumeLayout(False)
        Me.gbArea.PerformLayout()
        CType(Me.dgvArea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvAreaPMR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAreaPMR.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbArea As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpMonth As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgvArea As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents dgvAreaPMR As System.Windows.Forms.DataGridView
    Friend WithEvents gbAreaPMR As System.Windows.Forms.GroupBox
End Class
