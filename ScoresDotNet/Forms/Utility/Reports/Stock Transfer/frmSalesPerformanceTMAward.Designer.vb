<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesPerformanceTMAward
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpMonthTo = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.btnProcessCombi = New System.Windows.Forms.Button()
        Me.btnGenerateCombi = New System.Windows.Forms.Button()
        Me.GroupBox4.SuspendLayout()
        Me.gbSales.SuspendLayout()
        CType(Me.dgvSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnGenerateCombi)
        Me.GroupBox4.Controls.Add(Me.btnProcessCombi)
        Me.GroupBox4.Controls.Add(Me.btnGenerateOnly)
        Me.GroupBox4.Controls.Add(Me.btnGenerate)
        Me.GroupBox4.Controls.Add(Me.btnCancel)
        Me.GroupBox4.Location = New System.Drawing.Point(960, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(353, 120)
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
        Me.btnCancel.Location = New System.Drawing.Point(263, 29)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 38)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "    &Close"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "From Month :"
        '
        'dtpMonth
        '
        Me.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpMonth.Location = New System.Drawing.Point(168, 81)
        Me.dtpMonth.Name = "dtpMonth"
        Me.dtpMonth.Size = New System.Drawing.Size(200, 20)
        Me.dtpMonth.TabIndex = 8
        Me.dtpMonth.Value = New Date(2014, 6, 1, 9, 59, 0, 0)
        '
        'gbSales
        '
        Me.gbSales.Controls.Add(Me.dgvSales)
        Me.gbSales.Location = New System.Drawing.Point(20, 138)
        Me.gbSales.Name = "gbSales"
        Me.gbSales.Size = New System.Drawing.Size(1293, 498)
        Me.gbSales.TabIndex = 25
        Me.gbSales.TabStop = False
        Me.gbSales.Text = "Total No Of Records :"
        '
        'dgvSales
        '
        Me.dgvSales.AllowDrop = True
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvSales.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSales.Location = New System.Drawing.Point(6, 23)
        Me.dgvSales.Name = "dgvSales"
        Me.dgvSales.Size = New System.Drawing.Size(1272, 474)
        Me.dgvSales.TabIndex = 1
        '
        'txtTemplate
        '
        Me.txtTemplate.Location = New System.Drawing.Point(168, 29)
        Me.txtTemplate.Name = "txtTemplate"
        Me.txtTemplate.Size = New System.Drawing.Size(751, 20)
        Me.txtTemplate.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpMonthTo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpMonth)
        Me.GroupBox1.Controls.Add(Me.txtTemplate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtOutput)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(934, 120)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sales Performance Option"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(429, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "To Month :"
        '
        'dtpMonthTo
        '
        Me.dtpMonthTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpMonthTo.Location = New System.Drawing.Point(553, 81)
        Me.dtpMonthTo.Name = "dtpMonthTo"
        Me.dtpMonthTo.Size = New System.Drawing.Size(200, 20)
        Me.dtpMonthTo.TabIndex = 10
        Me.dtpMonthTo.Value = New Date(2014, 6, 1, 9, 59, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sales Performance Template :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Sales Performance Output :"
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(168, 55)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(751, 20)
        Me.txtOutput.TabIndex = 3
        '
        'btnProcessCombi
        '
        Me.btnProcessCombi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProcessCombi.Location = New System.Drawing.Point(15, 72)
        Me.btnProcessCombi.Name = "btnProcessCombi"
        Me.btnProcessCombi.Size = New System.Drawing.Size(103, 38)
        Me.btnProcessCombi.TabIndex = 3
        Me.btnProcessCombi.Text = "    &Process and Generate Combi"
        Me.btnProcessCombi.UseVisualStyleBackColor = True
        '
        'btnGenerateCombi
        '
        Me.btnGenerateCombi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenerateCombi.Location = New System.Drawing.Point(124, 72)
        Me.btnGenerateCombi.Name = "btnGenerateCombi"
        Me.btnGenerateCombi.Size = New System.Drawing.Size(103, 38)
        Me.btnGenerateCombi.TabIndex = 4
        Me.btnGenerateCombi.Text = "    &Generate Only Combi"
        Me.btnGenerateCombi.UseVisualStyleBackColor = True
        '
        'frmSalesPerformanceTMAward
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1333, 648)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.gbSales)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSalesPerformanceTMAward"
        Me.Text = "Sales Performance TM Award"
        Me.GroupBox4.ResumeLayout(False)
        Me.gbSales.ResumeLayout(False)
        CType(Me.dgvSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpMonthTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents btnGenerateCombi As System.Windows.Forms.Button
    Friend WithEvents btnProcessCombi As System.Windows.Forms.Button
End Class
