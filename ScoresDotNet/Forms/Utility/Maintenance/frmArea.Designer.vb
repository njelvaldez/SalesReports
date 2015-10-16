<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArea
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvAreaPMR = New System.Windows.Forms.DataGridView()
        Me.gbAreaPMR = New System.Windows.Forms.GroupBox()
        Me.gbArea = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpMonth = New System.Windows.Forms.DateTimePicker()
        Me.dgvArea = New System.Windows.Forms.DataGridView()
        CType(Me.dgvAreaPMR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAreaPMR.SuspendLayout()
        Me.gbArea.SuspendLayout()
        CType(Me.dgvArea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAreaPMR
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvAreaPMR.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAreaPMR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAreaPMR.Location = New System.Drawing.Point(12, 28)
        Me.dgvAreaPMR.Name = "dgvAreaPMR"
        Me.dgvAreaPMR.Size = New System.Drawing.Size(1281, 286)
        Me.dgvAreaPMR.TabIndex = 1
        '
        'gbAreaPMR
        '
        Me.gbAreaPMR.Controls.Add(Me.dgvAreaPMR)
        Me.gbAreaPMR.Location = New System.Drawing.Point(12, 307)
        Me.gbAreaPMR.Name = "gbAreaPMR"
        Me.gbAreaPMR.Size = New System.Drawing.Size(1293, 329)
        Me.gbAreaPMR.TabIndex = 31
        Me.gbAreaPMR.TabStop = False
        Me.gbAreaPMR.Text = "Total No of Area :"
        '
        'gbArea
        '
        Me.gbArea.Controls.Add(Me.Label3)
        Me.gbArea.Controls.Add(Me.dtpMonth)
        Me.gbArea.Controls.Add(Me.dgvArea)
        Me.gbArea.Location = New System.Drawing.Point(14, 12)
        Me.gbArea.Name = "gbArea"
        Me.gbArea.Size = New System.Drawing.Size(1293, 280)
        Me.gbArea.TabIndex = 32
        Me.gbArea.TabStop = False
        Me.gbArea.Text = "Total No of Area :"
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
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvArea.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvArea.Location = New System.Drawing.Point(8, 38)
        Me.dgvArea.Name = "dgvArea"
        Me.dgvArea.Size = New System.Drawing.Size(1281, 227)
        Me.dgvArea.TabIndex = 1
        '
        'frmArea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1333, 648)
        Me.Controls.Add(Me.gbArea)
        Me.Controls.Add(Me.gbAreaPMR)
        Me.Name = "frmArea"
        Me.Text = "Area-AreaPMR"
        CType(Me.dgvAreaPMR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAreaPMR.ResumeLayout(False)
        Me.gbArea.ResumeLayout(False)
        Me.gbArea.PerformLayout()
        CType(Me.dgvArea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvAreaPMR As System.Windows.Forms.DataGridView
    Friend WithEvents gbAreaPMR As System.Windows.Forms.GroupBox
    Friend WithEvents gbArea As System.Windows.Forms.GroupBox
    Friend WithEvents dgvArea As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpMonth As System.Windows.Forms.DateTimePicker
End Class
