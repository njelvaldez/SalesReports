<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDailySalesUpdateUtil
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnDuplicateTrans = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtEndDate = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtStartDate = New System.Windows.Forms.TextBox
        Me.btnDateRange = New System.Windows.Forms.Button
        Me.btnCorrectNotNegative = New System.Windows.Forms.Button
        Me.btnNotNegativeSales = New System.Windows.Forms.Button
        Me.btnMDIActualMonthSales = New System.Windows.Forms.Button
        Me.btnMDITotalSalesLessPrevTransfer = New System.Windows.Forms.Button
        Me.btnMDITotalSales = New System.Windows.Forms.Button
        Me.btnRecordsPerInvoice = New System.Windows.Forms.Button
        Me.btnNewCustomers = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpMonth = New System.Windows.Forms.DateTimePicker
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.dgvSales = New System.Windows.Forms.DataGridView
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnDuplicateTrans)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtEndDate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtStartDate)
        Me.GroupBox1.Controls.Add(Me.btnDateRange)
        Me.GroupBox1.Controls.Add(Me.btnCorrectNotNegative)
        Me.GroupBox1.Controls.Add(Me.btnNotNegativeSales)
        Me.GroupBox1.Controls.Add(Me.btnMDIActualMonthSales)
        Me.GroupBox1.Controls.Add(Me.btnMDITotalSalesLessPrevTransfer)
        Me.GroupBox1.Controls.Add(Me.btnMDITotalSales)
        Me.GroupBox1.Controls.Add(Me.btnRecordsPerInvoice)
        Me.GroupBox1.Controls.Add(Me.btnNewCustomers)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpMonth)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1307, 124)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sales Update Option"
        '
        'btnDuplicateTrans
        '
        Me.btnDuplicateTrans.Image = Global.ScoresDotNet.My.Resources.Resources.file_copy__1_
        Me.btnDuplicateTrans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDuplicateTrans.Location = New System.Drawing.Point(369, 67)
        Me.btnDuplicateTrans.Name = "btnDuplicateTrans"
        Me.btnDuplicateTrans.Size = New System.Drawing.Size(135, 43)
        Me.btnDuplicateTrans.TabIndex = 23
        Me.btnDuplicateTrans.Text = "   Duplicate Trans"
        Me.btnDuplicateTrans.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "End Date :"
        '
        'txtEndDate
        '
        Me.txtEndDate.Location = New System.Drawing.Point(95, 94)
        Me.txtEndDate.Name = "txtEndDate"
        Me.txtEndDate.Size = New System.Drawing.Size(112, 20)
        Me.txtEndDate.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Start Date :"
        '
        'txtStartDate
        '
        Me.txtStartDate.Location = New System.Drawing.Point(95, 68)
        Me.txtStartDate.Name = "txtStartDate"
        Me.txtStartDate.Size = New System.Drawing.Size(112, 20)
        Me.txtStartDate.TabIndex = 19
        '
        'btnDateRange
        '
        Me.btnDateRange.Image = Global.ScoresDotNet.My.Resources.Resources.table_sum_icon
        Me.btnDateRange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDateRange.Location = New System.Drawing.Point(223, 67)
        Me.btnDateRange.Name = "btnDateRange"
        Me.btnDateRange.Size = New System.Drawing.Size(135, 43)
        Me.btnDateRange.TabIndex = 18
        Me.btnDateRange.Text = "    MDI & Date Range Sales"
        Me.btnDateRange.UseVisualStyleBackColor = True
        '
        'btnCorrectNotNegative
        '
        Me.btnCorrectNotNegative.Image = Global.ScoresDotNet.My.Resources.Resources.edit
        Me.btnCorrectNotNegative.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCorrectNotNegative.Location = New System.Drawing.Point(223, 19)
        Me.btnCorrectNotNegative.Name = "btnCorrectNotNegative"
        Me.btnCorrectNotNegative.Size = New System.Drawing.Size(140, 43)
        Me.btnCorrectNotNegative.TabIndex = 17
        Me.btnCorrectNotNegative.Text = "       &Update Not Negative"
        Me.btnCorrectNotNegative.UseVisualStyleBackColor = True
        '
        'btnNotNegativeSales
        '
        Me.btnNotNegativeSales.Image = Global.ScoresDotNet.My.Resources.Resources.Math_minus_icon
        Me.btnNotNegativeSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNotNegativeSales.Location = New System.Drawing.Point(369, 19)
        Me.btnNotNegativeSales.Name = "btnNotNegativeSales"
        Me.btnNotNegativeSales.Size = New System.Drawing.Size(135, 43)
        Me.btnNotNegativeSales.TabIndex = 16
        Me.btnNotNegativeSales.Text = "       Not &Negative Sales"
        Me.btnNotNegativeSales.UseVisualStyleBackColor = True
        '
        'btnMDIActualMonthSales
        '
        Me.btnMDIActualMonthSales.Image = Global.ScoresDotNet.My.Resources.Resources.calendar_icon
        Me.btnMDIActualMonthSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMDIActualMonthSales.Location = New System.Drawing.Point(510, 19)
        Me.btnMDIActualMonthSales.Name = "btnMDIActualMonthSales"
        Me.btnMDIActualMonthSales.Size = New System.Drawing.Size(135, 43)
        Me.btnMDIActualMonthSales.TabIndex = 15
        Me.btnMDIActualMonthSales.Text = "    MDI Actual &Month Sales"
        Me.btnMDIActualMonthSales.UseVisualStyleBackColor = True
        '
        'btnMDITotalSalesLessPrevTransfer
        '
        Me.btnMDITotalSalesLessPrevTransfer.Image = Global.ScoresDotNet.My.Resources.Resources.Alarm_Arrow_Left_icon
        Me.btnMDITotalSalesLessPrevTransfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMDITotalSalesLessPrevTransfer.Location = New System.Drawing.Point(651, 19)
        Me.btnMDITotalSalesLessPrevTransfer.Name = "btnMDITotalSalesLessPrevTransfer"
        Me.btnMDITotalSalesLessPrevTransfer.Size = New System.Drawing.Size(135, 43)
        Me.btnMDITotalSalesLessPrevTransfer.TabIndex = 14
        Me.btnMDITotalSalesLessPrevTransfer.Text = "     MDI Total Sales < &Prev"
        Me.btnMDITotalSalesLessPrevTransfer.UseVisualStyleBackColor = True
        '
        'btnMDITotalSales
        '
        Me.btnMDITotalSales.Image = Global.ScoresDotNet.My.Resources.Resources.table_sum_icon
        Me.btnMDITotalSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMDITotalSales.Location = New System.Drawing.Point(792, 19)
        Me.btnMDITotalSales.Name = "btnMDITotalSales"
        Me.btnMDITotalSales.Size = New System.Drawing.Size(135, 43)
        Me.btnMDITotalSales.TabIndex = 13
        Me.btnMDITotalSales.Text = "    MDI &Total Sales"
        Me.btnMDITotalSales.UseVisualStyleBackColor = True
        '
        'btnRecordsPerInvoice
        '
        Me.btnRecordsPerInvoice.Image = Global.ScoresDotNet.My.Resources.Resources.summary_icon
        Me.btnRecordsPerInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecordsPerInvoice.Location = New System.Drawing.Point(933, 19)
        Me.btnRecordsPerInvoice.Name = "btnRecordsPerInvoice"
        Me.btnRecordsPerInvoice.Size = New System.Drawing.Size(135, 43)
        Me.btnRecordsPerInvoice.TabIndex = 12
        Me.btnRecordsPerInvoice.Text = "        &Records Per Day"
        Me.btnRecordsPerInvoice.UseVisualStyleBackColor = True
        '
        'btnNewCustomers
        '
        Me.btnNewCustomers.Image = Global.ScoresDotNet.My.Resources.Resources.Actions_contact_new_icon
        Me.btnNewCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNewCustomers.Location = New System.Drawing.Point(1074, 19)
        Me.btnNewCustomers.Name = "btnNewCustomers"
        Me.btnNewCustomers.Size = New System.Drawing.Size(135, 43)
        Me.btnNewCustomers.TabIndex = 11
        Me.btnNewCustomers.Text = "    &New Customers"
        Me.btnNewCustomers.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.ScoresDotNet.My.Resources.Resources.door_out_icon1
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(1215, 19)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 43)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "    &Close"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Sales Month :"
        '
        'dtpMonth
        '
        Me.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpMonth.Location = New System.Drawing.Point(95, 19)
        Me.dtpMonth.Name = "dtpMonth"
        Me.dtpMonth.Size = New System.Drawing.Size(112, 20)
        Me.dtpMonth.TabIndex = 8
        Me.dtpMonth.Value = New Date(2014, 6, 1, 9, 59, 0, 0)
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvSales)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 142)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1307, 494)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sales for the Month"
        '
        'dgvSales
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvSales.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSales.Location = New System.Drawing.Point(6, 19)
        Me.dgvSales.Name = "dgvSales"
        Me.dgvSales.Size = New System.Drawing.Size(1295, 530)
        Me.dgvSales.TabIndex = 1
        '
        'frmDailySalesUpdateUtil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1333, 648)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDailySalesUpdateUtil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daily Sales Update Utility"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpMonth As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvSales As System.Windows.Forms.DataGridView
    Friend WithEvents btnNewCustomers As System.Windows.Forms.Button
    Friend WithEvents btnRecordsPerInvoice As System.Windows.Forms.Button
    Friend WithEvents btnMDITotalSalesLessPrevTransfer As System.Windows.Forms.Button
    Friend WithEvents btnMDITotalSales As System.Windows.Forms.Button
    Friend WithEvents btnMDIActualMonthSales As System.Windows.Forms.Button
    Friend WithEvents btnNotNegativeSales As System.Windows.Forms.Button
    Friend WithEvents btnCorrectNotNegative As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtStartDate As System.Windows.Forms.TextBox
    Friend WithEvents btnDateRange As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtEndDate As System.Windows.Forms.TextBox
    Friend WithEvents btnDuplicateTrans As System.Windows.Forms.Button
End Class
