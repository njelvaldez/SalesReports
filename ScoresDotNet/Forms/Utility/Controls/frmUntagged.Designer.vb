<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUntagged
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnTagPalawan = New System.Windows.Forms.Button()
        Me.btnTagSalesTrade = New System.Windows.Forms.Button()
        Me.btnTagSales = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvSales = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpMonth = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.btnTagPalawan)
        Me.GroupBox4.Controls.Add(Me.btnTagSalesTrade)
        Me.GroupBox4.Controls.Add(Me.btnTagSales)
        Me.GroupBox4.Controls.Add(Me.btnCancel)
        Me.GroupBox4.Location = New System.Drawing.Point(255, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1058, 126)
        Me.GroupBox4.TabIndex = 26
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Action"
        '
        'btnTagPalawan
        '
        Me.btnTagPalawan.Image = Global.ScoresDotNet.My.Resources.Resources.Gear_icon
        Me.btnTagPalawan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTagPalawan.Location = New System.Drawing.Point(326, 29)
        Me.btnTagPalawan.Name = "btnTagPalawan"
        Me.btnTagPalawan.Size = New System.Drawing.Size(135, 38)
        Me.btnTagPalawan.TabIndex = 3
        Me.btnTagPalawan.Text = "    &Tag Palawan"
        Me.btnTagPalawan.UseVisualStyleBackColor = True
        '
        'btnTagSalesTrade
        '
        Me.btnTagSalesTrade.Image = Global.ScoresDotNet.My.Resources.Resources.Gear_icon
        Me.btnTagSalesTrade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTagSalesTrade.Location = New System.Drawing.Point(185, 29)
        Me.btnTagSalesTrade.Name = "btnTagSalesTrade"
        Me.btnTagSalesTrade.Size = New System.Drawing.Size(135, 38)
        Me.btnTagSalesTrade.TabIndex = 2
        Me.btnTagSalesTrade.Text = "    &Tag Sales(Trade)"
        Me.btnTagSalesTrade.UseVisualStyleBackColor = True
        '
        'btnTagSales
        '
        Me.btnTagSales.Enabled = False
        Me.btnTagSales.Image = Global.ScoresDotNet.My.Resources.Resources.Gear_icon
        Me.btnTagSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTagSales.Location = New System.Drawing.Point(44, 29)
        Me.btnTagSales.Name = "btnTagSales"
        Me.btnTagSales.Size = New System.Drawing.Size(135, 38)
        Me.btnTagSales.TabIndex = 1
        Me.btnTagSales.Text = "    &Tag MDI Sales"
        Me.btnTagSales.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.ScoresDotNet.My.Resources.Resources.door_out_icon
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(467, 29)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(135, 38)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "    &Close"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvSales)
        Me.GroupBox3.Location = New System.Drawing.Point(20, 144)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1293, 492)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Total number of untagged : 0"
        '
        'dgvSales
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvSales.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSales.Location = New System.Drawing.Point(6, 19)
        Me.dgvSales.Name = "dgvSales"
        Me.dgvSales.Size = New System.Drawing.Size(1281, 473)
        Me.dgvSales.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpMonth)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(229, 126)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Untagged Option"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Sales Month :"
        '
        'dtpMonth
        '
        Me.dtpMonth.Enabled = False
        Me.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpMonth.Location = New System.Drawing.Point(91, 29)
        Me.dtpMonth.Name = "dtpMonth"
        Me.dtpMonth.Size = New System.Drawing.Size(112, 20)
        Me.dtpMonth.TabIndex = 10
        Me.dtpMonth.Value = New Date(2014, 12, 16, 0, 0, 0, 0)
        '
        'Button1
        '
        Me.Button1.Image = Global.ScoresDotNet.My.Resources.Resources.Gear_icon
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(44, 73)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 38)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "    &Tag Sub-Dist Sales"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmUntagged
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1333, 648)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmUntagged"
        Me.Text = "Untagged"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnTagSales As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvSales As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpMonth As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnTagPalawan As System.Windows.Forms.Button
    Friend WithEvents btnTagSalesTrade As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
