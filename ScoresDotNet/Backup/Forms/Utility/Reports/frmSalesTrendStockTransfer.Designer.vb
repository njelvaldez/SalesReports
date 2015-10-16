<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesTrendStockTransfer
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.btnGenerate = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpMonth = New System.Windows.Forms.DateTimePicker
        Me.gbSales = New System.Windows.Forms.GroupBox
        Me.dgvSales = New System.Windows.Forms.DataGridView
        Me.txtTemplate = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtOutput = New System.Windows.Forms.TextBox
        Me.GroupBox4.SuspendLayout()
        Me.gbSales.SuspendLayout()
        CType(Me.dgvSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnGenerate)
        Me.GroupBox4.Controls.Add(Me.btnCancel)
        Me.GroupBox4.Location = New System.Drawing.Point(1058, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(255, 92)
        Me.GroupBox4.TabIndex = 20
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Sales Month :"
        '
        'dtpMonth
        '
        Me.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpMonth.Location = New System.Drawing.Point(151, 65)
        Me.dtpMonth.Name = "dtpMonth"
        Me.dtpMonth.Size = New System.Drawing.Size(200, 20)
        Me.dtpMonth.TabIndex = 8
        Me.dtpMonth.Value = New Date(2014, 6, 1, 9, 59, 0, 0)
        '
        'gbSales
        '
        Me.gbSales.Controls.Add(Me.dgvSales)
        Me.gbSales.Location = New System.Drawing.Point(20, 110)
        Me.gbSales.Name = "gbSales"
        Me.gbSales.Size = New System.Drawing.Size(1293, 526)
        Me.gbSales.TabIndex = 19
        Me.gbSales.TabStop = False
        Me.gbSales.Text = "Total No Of Records :"
        '
        'dgvSales
        '
        Me.dgvSales.AllowDrop = True
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvSales.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSales.Location = New System.Drawing.Point(6, 19)
        Me.dgvSales.Name = "dgvSales"
        Me.dgvSales.Size = New System.Drawing.Size(1281, 501)
        Me.dgvSales.TabIndex = 1
        '
        'txtTemplate
        '
        Me.txtTemplate.Location = New System.Drawing.Point(151, 13)
        Me.txtTemplate.Name = "txtTemplate"
        Me.txtTemplate.Size = New System.Drawing.Size(871, 20)
        Me.txtTemplate.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpMonth)
        Me.GroupBox1.Controls.Add(Me.txtTemplate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtOutput)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1032, 92)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sales Trend Option"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sales Trend Template :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Sales Trend Output :"
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(151, 39)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(871, 20)
        Me.txtOutput.TabIndex = 3
        '
        'frmSalesTrendStockTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1333, 648)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.gbSales)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSalesTrendStockTransfer"
        Me.Text = "Sales Trend - Stock Transfer"
        Me.GroupBox4.ResumeLayout(False)
        Me.gbSales.ResumeLayout(False)
        CType(Me.dgvSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpMonth As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbSales As System.Windows.Forms.GroupBox
    Friend WithEvents dgvSales As System.Windows.Forms.DataGridView
    Friend WithEvents txtTemplate As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
End Class
