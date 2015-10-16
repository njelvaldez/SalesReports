<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBudgetNatlTransfer
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnSaveYearly = New System.Windows.Forms.Button()
        Me.btnOpenBudgetFromList = New System.Windows.Forms.Button()
        Me.dgvPreviousBudget = New System.Windows.Forms.DataGridView()
        Me.txtBudgetPath = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSaveBudget = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpMonth = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Specialist = New System.Windows.Forms.Label()
        Me.txtSpecialist = New System.Windows.Forms.TextBox()
        Me.txtMrCode = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpMonth2 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMrCode2 = New System.Windows.Forms.TextBox()
        Me.txtSpecialist2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvBudget = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvPreviousBudget, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvBudget, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 280)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1309, 356)
        Me.TabControl1.TabIndex = 16
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Location = New System.Drawing.Point(13, 12)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1304, 262)
        Me.TabControl2.TabIndex = 17
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnSaveYearly)
        Me.TabPage2.Controls.Add(Me.btnOpenBudgetFromList)
        Me.TabPage2.Controls.Add(Me.dgvPreviousBudget)
        Me.TabPage2.Controls.Add(Me.txtBudgetPath)
        Me.TabPage2.Controls.Add(Me.btnClose)
        Me.TabPage2.Controls.Add(Me.btnSaveBudget)
        Me.TabPage2.Controls.Add(Me.btnBrowse)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.dtpMonth)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Specialist)
        Me.TabPage2.Controls.Add(Me.txtSpecialist)
        Me.TabPage2.Controls.Add(Me.txtMrCode)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1296, 236)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Current Budget"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnSaveYearly
        '
        Me.btnSaveYearly.Image = Global.ScoresDotNet.My.Resources.Resources.Gear_icon
        Me.btnSaveYearly.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaveYearly.Location = New System.Drawing.Point(1086, 16)
        Me.btnSaveYearly.Name = "btnSaveYearly"
        Me.btnSaveYearly.Size = New System.Drawing.Size(91, 38)
        Me.btnSaveYearly.TabIndex = 19
        Me.btnSaveYearly.Text = "        &Save Yearly"
        Me.btnSaveYearly.UseVisualStyleBackColor = True
        '
        'btnOpenBudgetFromList
        '
        Me.btnOpenBudgetFromList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOpenBudgetFromList.Location = New System.Drawing.Point(880, 16)
        Me.btnOpenBudgetFromList.Name = "btnOpenBudgetFromList"
        Me.btnOpenBudgetFromList.Size = New System.Drawing.Size(103, 38)
        Me.btnOpenBudgetFromList.TabIndex = 18
        Me.btnOpenBudgetFromList.Text = "Open Budget File From List"
        Me.btnOpenBudgetFromList.UseVisualStyleBackColor = True
        '
        'dgvPreviousBudget
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvPreviousBudget.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPreviousBudget.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPreviousBudget.Location = New System.Drawing.Point(17, 78)
        Me.dgvPreviousBudget.Name = "dgvPreviousBudget"
        Me.dgvPreviousBudget.RowHeadersWidth = 62
        Me.dgvPreviousBudget.Size = New System.Drawing.Size(1256, 141)
        Me.dgvPreviousBudget.TabIndex = 17
        '
        'txtBudgetPath
        '
        Me.txtBudgetPath.Location = New System.Drawing.Point(148, 16)
        Me.txtBudgetPath.Name = "txtBudgetPath"
        Me.txtBudgetPath.Size = New System.Drawing.Size(686, 20)
        Me.txtBudgetPath.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(1191, 16)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(82, 38)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "    &Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSaveBudget
        '
        Me.btnSaveBudget.Enabled = False
        Me.btnSaveBudget.Image = Global.ScoresDotNet.My.Resources.Resources.Gear_icon
        Me.btnSaveBudget.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaveBudget.Location = New System.Drawing.Point(989, 16)
        Me.btnSaveBudget.Name = "btnSaveBudget"
        Me.btnSaveBudget.Size = New System.Drawing.Size(91, 38)
        Me.btnSaveBudget.TabIndex = 15
        Me.btnSaveBudget.Text = "        &Save Monthly"
        Me.btnSaveBudget.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBrowse.Location = New System.Drawing.Point(840, 16)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(34, 20)
        Me.btnBrowse.TabIndex = 16
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Budget File Path:"
        '
        'dtpMonth
        '
        Me.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpMonth.Location = New System.Drawing.Point(148, 42)
        Me.dtpMonth.Name = "dtpMonth"
        Me.dtpMonth.Size = New System.Drawing.Size(200, 20)
        Me.dtpMonth.TabIndex = 8
        Me.dtpMonth.Value = New Date(2014, 6, 1, 9, 59, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Budget Month :"
        '
        'Specialist
        '
        Me.Specialist.AutoSize = True
        Me.Specialist.Location = New System.Drawing.Point(407, 46)
        Me.Specialist.Name = "Specialist"
        Me.Specialist.Size = New System.Drawing.Size(58, 13)
        Me.Specialist.TabIndex = 10
        Me.Specialist.Text = "Specialist :"
        '
        'txtSpecialist
        '
        Me.txtSpecialist.Location = New System.Drawing.Point(571, 42)
        Me.txtSpecialist.Name = "txtSpecialist"
        Me.txtSpecialist.Size = New System.Drawing.Size(263, 20)
        Me.txtSpecialist.TabIndex = 12
        '
        'txtMrCode
        '
        Me.txtMrCode.Location = New System.Drawing.Point(484, 42)
        Me.txtMrCode.Name = "txtMrCode"
        Me.txtMrCode.Size = New System.Drawing.Size(71, 20)
        Me.txtMrCode.TabIndex = 11
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1296, 287)
        Me.TabPage3.TabIndex = 1
        Me.TabPage3.Text = "Previous Budget"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Location = New System.Drawing.Point(48, 92)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(371, 33)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Budget Details"
        Me.GroupBox3.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.txtSpecialist2)
        Me.GroupBox2.Controls.Add(Me.txtMrCode2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.dtpMonth2)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(103, 97)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Options"
        Me.GroupBox2.Visible = False
        '
        'dtpMonth2
        '
        Me.dtpMonth2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpMonth2.Location = New System.Drawing.Point(104, 51)
        Me.dtpMonth2.Name = "dtpMonth2"
        Me.dtpMonth2.Size = New System.Drawing.Size(112, 20)
        Me.dtpMonth2.TabIndex = 10
        Me.dtpMonth2.Value = New Date(2014, 6, 1, 9, 59, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Budget Month :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Specialist :"
        '
        'txtMrCode2
        '
        Me.txtMrCode2.Location = New System.Drawing.Point(105, 19)
        Me.txtMrCode2.Name = "txtMrCode2"
        Me.txtMrCode2.Size = New System.Drawing.Size(111, 20)
        Me.txtMrCode2.TabIndex = 14
        '
        'txtSpecialist2
        '
        Me.txtSpecialist2.Location = New System.Drawing.Point(222, 19)
        Me.txtSpecialist2.Name = "txtSpecialist2"
        Me.txtSpecialist2.Size = New System.Drawing.Size(266, 20)
        Me.txtSpecialist2.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Image = Global.ScoresDotNet.My.Resources.Resources.Search_icon
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(509, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 38)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "        S&earch"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Image = Global.ScoresDotNet.My.Resources.Resources.save
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(597, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(171, 38)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "       Save Budget For &All SPs"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.dgvBudget)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1301, 330)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Budget"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgvBudget
        '
        Me.dgvBudget.AllowUserToAddRows = False
        Me.dgvBudget.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvBudget.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBudget.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBudget.Location = New System.Drawing.Point(18, 19)
        Me.dgvBudget.Name = "dgvBudget"
        Me.dgvBudget.ReadOnly = True
        Me.dgvBudget.Size = New System.Drawing.Size(1256, 288)
        Me.dgvBudget.TabIndex = 16
        '
        'frmBudgetForSpecialist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1333, 648)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBudgetForSpecialist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Budget For Specialist"
        Me.TabControl1.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvPreviousBudget, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvBudget, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtBudgetPath As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSaveBudget As System.Windows.Forms.Button
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpMonth As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Specialist As System.Windows.Forms.Label
    Friend WithEvents txtSpecialist As System.Windows.Forms.TextBox
    Friend WithEvents txtMrCode As System.Windows.Forms.TextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents dgvPreviousBudget As System.Windows.Forms.DataGridView
    Friend WithEvents btnOpenBudgetFromList As System.Windows.Forms.Button
    Friend WithEvents btnSaveYearly As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgvBudget As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtSpecialist2 As System.Windows.Forms.TextBox
    Friend WithEvents txtMrCode2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpMonth2 As System.Windows.Forms.DateTimePicker
End Class
