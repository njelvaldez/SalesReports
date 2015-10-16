<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesPerformanceSPTMMAT
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnGenerateOnly = New System.Windows.Forms.Button()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpMonth = New System.Windows.Forms.DateTimePicker()
        Me.gbSales = New System.Windows.Forms.GroupBox()
        Me.dgvSales = New System.Windows.Forms.DataGridView()
        Me.txtTemplate = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtplyto = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtplyfrom = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtptyto = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.gbsales2 = New System.Windows.Forms.GroupBox()
        Me.dgvsales2 = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        Me.gbSales.SuspendLayout()
        CType(Me.dgvSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbsales2.SuspendLayout()
        CType(Me.dgvsales2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.btnGenerateOnly)
        Me.GroupBox4.Controls.Add(Me.btnGenerate)
        Me.GroupBox4.Controls.Add(Me.btnCancel)
        Me.GroupBox4.Location = New System.Drawing.Point(960, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(353, 176)
        Me.GroupBox4.TabIndex = 26
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Action"
        '
        'btnGenerateOnly
        '
        Me.btnGenerateOnly.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenerateOnly.Location = New System.Drawing.Point(124, 29)
        Me.btnGenerateOnly.Name = "btnGenerateOnly"
        Me.btnGenerateOnly.Size = New System.Drawing.Size(103, 38)
        Me.btnGenerateOnly.TabIndex = 2
        Me.btnGenerateOnly.Text = "    &Generate Only"
        Me.btnGenerateOnly.UseVisualStyleBackColor = True
        '
        'btnGenerate
        '
        Me.btnGenerate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenerate.Location = New System.Drawing.Point(15, 29)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(103, 38)
        Me.btnGenerate.TabIndex = 1
        Me.btnGenerate.Text = "    &Process and Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.ScoresDotNet.My.Resources.Resources.door_out_icon
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(261, 29)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 38)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "    &Close"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "From TY Month :"
        '
        'dtpMonth
        '
        Me.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpMonth.Location = New System.Drawing.Point(167, 81)
        Me.dtpMonth.Name = "dtpMonth"
        Me.dtpMonth.Size = New System.Drawing.Size(200, 20)
        Me.dtpMonth.TabIndex = 8
        Me.dtpMonth.Value = New Date(2014, 6, 1, 9, 59, 0, 0)
        '
        'gbSales
        '
        Me.gbSales.Controls.Add(Me.dgvSales)
        Me.gbSales.Location = New System.Drawing.Point(20, 194)
        Me.gbSales.Name = "gbSales"
        Me.gbSales.Size = New System.Drawing.Size(1293, 200)
        Me.gbSales.TabIndex = 25
        Me.gbSales.TabStop = False
        Me.gbSales.Text = "Total No Of Records :"
        '
        'dgvSales
        '
        Me.dgvSales.AllowDrop = True
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvSales.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSales.Location = New System.Drawing.Point(12, 19)
        Me.dgvSales.Name = "dgvSales"
        Me.dgvSales.Size = New System.Drawing.Size(1264, 174)
        Me.dgvSales.TabIndex = 1
        '
        'txtTemplate
        '
        Me.txtTemplate.Location = New System.Drawing.Point(167, 29)
        Me.txtTemplate.Name = "txtTemplate"
        Me.txtTemplate.Size = New System.Drawing.Size(751, 20)
        Me.txtTemplate.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtplyto)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dtplyfrom)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtptyto)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpMonth)
        Me.GroupBox1.Controls.Add(Me.txtTemplate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtOutput)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(934, 176)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sales Peformance Option"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(383, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "To LY Month :"
        '
        'dtplyto
        '
        Me.dtplyto.Enabled = False
        Me.dtplyto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtplyto.Location = New System.Drawing.Point(538, 108)
        Me.dtplyto.Name = "dtplyto"
        Me.dtplyto.Size = New System.Drawing.Size(200, 20)
        Me.dtplyto.TabIndex = 14
        Me.dtplyto.Value = New Date(2014, 6, 1, 9, 59, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "From LY Month :"
        '
        'dtplyfrom
        '
        Me.dtplyfrom.Enabled = False
        Me.dtplyfrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtplyfrom.Location = New System.Drawing.Point(167, 107)
        Me.dtplyfrom.Name = "dtplyfrom"
        Me.dtplyfrom.Size = New System.Drawing.Size(200, 20)
        Me.dtplyfrom.TabIndex = 12
        Me.dtplyfrom.Value = New Date(2014, 6, 1, 9, 59, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(383, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "To TY Month :"
        '
        'dtptyto
        '
        Me.dtptyto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtptyto.Location = New System.Drawing.Point(538, 82)
        Me.dtptyto.Name = "dtptyto"
        Me.dtptyto.Size = New System.Drawing.Size(200, 20)
        Me.dtptyto.TabIndex = 10
        Me.dtptyto.Value = New Date(2014, 6, 1, 9, 59, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sales Performance Template :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Sales Performance Output :"
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(167, 55)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(751, 20)
        Me.txtOutput.TabIndex = 3
        '
        'gbsales2
        '
        Me.gbsales2.Controls.Add(Me.dgvsales2)
        Me.gbsales2.Location = New System.Drawing.Point(20, 400)
        Me.gbsales2.Name = "gbsales2"
        Me.gbsales2.Size = New System.Drawing.Size(1293, 236)
        Me.gbsales2.TabIndex = 27
        Me.gbsales2.TabStop = False
        Me.gbsales2.Text = "Total No Of Records :"
        '
        'dgvsales2
        '
        Me.dgvsales2.AllowDrop = True
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvsales2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvsales2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsales2.Location = New System.Drawing.Point(6, 19)
        Me.dgvsales2.Name = "dgvsales2"
        Me.dgvsales2.Size = New System.Drawing.Size(1270, 209)
        Me.dgvsales2.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(11, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(293, 20)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Please edit TYShare and LYShare value"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(11, 109)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(205, 20)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "From Pivot as Formula Field"
        '
        'frmSalesPerformanceSPTMMAT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1333, 648)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.gbSales)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbsales2)
        Me.Name = "frmSalesPerformanceSPTMMAT"
        Me.Text = "Sales Performance SP TM MAT"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.gbSales.ResumeLayout(False)
        CType(Me.dgvSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbsales2.ResumeLayout(False)
        CType(Me.dgvsales2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGenerateOnly As System.Windows.Forms.Button
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
    Friend WithEvents gbsales2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvsales2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtplyto As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtplyfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtptyto As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
