<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBudgetDirectSummary
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.GroupBox4.SuspendLayout()
        Me.gbSales.SuspendLayout()
        CType(Me.dgvSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnGenerateOnly)
        Me.GroupBox4.Controls.Add(Me.btnGenerate)
        Me.GroupBox4.Controls.Add(Me.btnCancel)
        Me.GroupBox4.Location = New System.Drawing.Point(960, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(353, 115)
        Me.GroupBox4.TabIndex = 35
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
        Me.btnCancel.Location = New System.Drawing.Point(272, 29)
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
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "From Month :"
        '
        'dtpMonth
        '
        Me.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpMonth.Location = New System.Drawing.Point(147, 81)
        Me.dtpMonth.Name = "dtpMonth"
        Me.dtpMonth.Size = New System.Drawing.Size(200, 20)
        Me.dtpMonth.TabIndex = 8
        Me.dtpMonth.Value = New Date(2014, 6, 1, 9, 59, 0, 0)
        '
        'gbSales
        '
        Me.gbSales.Controls.Add(Me.dgvSales)
        Me.gbSales.Location = New System.Drawing.Point(20, 133)
        Me.gbSales.Name = "gbSales"
        Me.gbSales.Size = New System.Drawing.Size(1293, 503)
        Me.gbSales.TabIndex = 34
        Me.gbSales.TabStop = False
        Me.gbSales.Text = "Total No Of Records :"
        '
        'dgvSales
        '
        Me.dgvSales.AllowDrop = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvSales.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSales.Location = New System.Drawing.Point(6, 19)
        Me.dgvSales.Name = "dgvSales"
        Me.dgvSales.Size = New System.Drawing.Size(1281, 483)
        Me.dgvSales.TabIndex = 1
        '
        'txtTemplate
        '
        Me.txtTemplate.Location = New System.Drawing.Point(147, 29)
        Me.txtTemplate.Name = "txtTemplate"
        Me.txtTemplate.Size = New System.Drawing.Size(771, 20)
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
        Me.GroupBox1.Size = New System.Drawing.Size(934, 115)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Budget Option"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Budget Template :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Budget Output :"
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(147, 55)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(771, 20)
        Me.txtOutput.TabIndex = 3
        '
        'frmBudgetDirectSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1333, 648)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.gbSales)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBudgetDirectSummary"
        Me.Text = "Budget Direct Summary"
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
End Class
