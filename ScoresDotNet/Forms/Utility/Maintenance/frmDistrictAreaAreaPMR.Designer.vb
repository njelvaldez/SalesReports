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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbArea = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpMonth = New System.Windows.Forms.DateTimePicker()
        Me.dgvArea = New System.Windows.Forms.DataGridView()
        Me.dgvAreaPMR = New System.Windows.Forms.DataGridView()
        Me.gbAreaPMR = New System.Windows.Forms.GroupBox()
        Me.txtRowID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnUpdateAreaPMR = New System.Windows.Forms.Button()
        Me.btnInsertAreaPMR = New System.Windows.Forms.Button()
        Me.txtarearowid = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtdeleted = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtlastuser = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtend_date = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtstart_date = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtmrcode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAreaCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbArea.SuspendLayout()
        CType(Me.dgvArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAreaPMR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAreaPMR.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbArea
        '
        Me.gbArea.Controls.Add(Me.Label3)
        Me.gbArea.Controls.Add(Me.dtpMonth)
        Me.gbArea.Controls.Add(Me.dgvArea)
        Me.gbArea.Location = New System.Drawing.Point(18, 3)
        Me.gbArea.Name = "gbArea"
        Me.gbArea.Size = New System.Drawing.Size(1303, 289)
        Me.gbArea.TabIndex = 34
        Me.gbArea.TabStop = False
        Me.gbArea.Text = "Total No of District :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Sales Month :"
        '
        'dtpMonth
        '
        Me.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpMonth.Location = New System.Drawing.Point(99, 19)
        Me.dtpMonth.Name = "dtpMonth"
        Me.dtpMonth.Size = New System.Drawing.Size(147, 20)
        Me.dtpMonth.TabIndex = 10
        Me.dtpMonth.Value = New Date(2014, 10, 24, 0, 0, 0, 0)
        '
        'dgvArea
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvArea.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvArea.Location = New System.Drawing.Point(6, 56)
        Me.dgvArea.Name = "dgvArea"
        Me.dgvArea.Size = New System.Drawing.Size(899, 227)
        Me.dgvArea.TabIndex = 1
        '
        'dgvAreaPMR
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvAreaPMR.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAreaPMR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAreaPMR.Location = New System.Drawing.Point(12, 28)
        Me.dgvAreaPMR.Name = "dgvAreaPMR"
        Me.dgvAreaPMR.Size = New System.Drawing.Size(1076, 286)
        Me.dgvAreaPMR.TabIndex = 1
        '
        'gbAreaPMR
        '
        Me.gbAreaPMR.Controls.Add(Me.txtRowID)
        Me.gbAreaPMR.Controls.Add(Me.Label9)
        Me.gbAreaPMR.Controls.Add(Me.btnUpdateAreaPMR)
        Me.gbAreaPMR.Controls.Add(Me.btnInsertAreaPMR)
        Me.gbAreaPMR.Controls.Add(Me.txtarearowid)
        Me.gbAreaPMR.Controls.Add(Me.Label8)
        Me.gbAreaPMR.Controls.Add(Me.txtdeleted)
        Me.gbAreaPMR.Controls.Add(Me.Label7)
        Me.gbAreaPMR.Controls.Add(Me.txtlastuser)
        Me.gbAreaPMR.Controls.Add(Me.Label6)
        Me.gbAreaPMR.Controls.Add(Me.txtend_date)
        Me.gbAreaPMR.Controls.Add(Me.Label5)
        Me.gbAreaPMR.Controls.Add(Me.txtstart_date)
        Me.gbAreaPMR.Controls.Add(Me.Label4)
        Me.gbAreaPMR.Controls.Add(Me.txtmrcode)
        Me.gbAreaPMR.Controls.Add(Me.Label2)
        Me.gbAreaPMR.Controls.Add(Me.txtAreaCode)
        Me.gbAreaPMR.Controls.Add(Me.Label1)
        Me.gbAreaPMR.Controls.Add(Me.dgvAreaPMR)
        Me.gbAreaPMR.Location = New System.Drawing.Point(16, 307)
        Me.gbAreaPMR.Name = "gbAreaPMR"
        Me.gbAreaPMR.Size = New System.Drawing.Size(1305, 329)
        Me.gbAreaPMR.TabIndex = 33
        Me.gbAreaPMR.TabStop = False
        Me.gbAreaPMR.Text = "Total No of Area :"
        '
        'txtRowID
        '
        Me.txtRowID.Location = New System.Drawing.Point(1188, 210)
        Me.txtRowID.Name = "txtRowID"
        Me.txtRowID.Size = New System.Drawing.Size(100, 20)
        Me.txtRowID.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1094, 217)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Row ID :"
        '
        'btnUpdateAreaPMR
        '
        Me.btnUpdateAreaPMR.Location = New System.Drawing.Point(1155, 289)
        Me.btnUpdateAreaPMR.Name = "btnUpdateAreaPMR"
        Me.btnUpdateAreaPMR.Size = New System.Drawing.Size(133, 23)
        Me.btnUpdateAreaPMR.TabIndex = 18
        Me.btnUpdateAreaPMR.Text = "Update Area PMR"
        Me.btnUpdateAreaPMR.UseVisualStyleBackColor = True
        '
        'btnInsertAreaPMR
        '
        Me.btnInsertAreaPMR.Location = New System.Drawing.Point(1155, 260)
        Me.btnInsertAreaPMR.Name = "btnInsertAreaPMR"
        Me.btnInsertAreaPMR.Size = New System.Drawing.Size(133, 23)
        Me.btnInsertAreaPMR.TabIndex = 17
        Me.btnInsertAreaPMR.Text = "Insert New Area PMR"
        Me.btnInsertAreaPMR.UseVisualStyleBackColor = True
        '
        'txtarearowid
        '
        Me.txtarearowid.Location = New System.Drawing.Point(1188, 184)
        Me.txtarearowid.Name = "txtarearowid"
        Me.txtarearowid.Size = New System.Drawing.Size(100, 20)
        Me.txtarearowid.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1094, 191)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Area Row ID :"
        '
        'txtdeleted
        '
        Me.txtdeleted.Location = New System.Drawing.Point(1188, 158)
        Me.txtdeleted.Name = "txtdeleted"
        Me.txtdeleted.Size = New System.Drawing.Size(100, 20)
        Me.txtdeleted.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1094, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Deleted :"
        '
        'txtlastuser
        '
        Me.txtlastuser.Location = New System.Drawing.Point(1188, 132)
        Me.txtlastuser.Name = "txtlastuser"
        Me.txtlastuser.Size = New System.Drawing.Size(100, 20)
        Me.txtlastuser.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1094, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Last User :"
        '
        'txtend_date
        '
        Me.txtend_date.Location = New System.Drawing.Point(1188, 106)
        Me.txtend_date.Name = "txtend_date"
        Me.txtend_date.Size = New System.Drawing.Size(100, 20)
        Me.txtend_date.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1094, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "End Date :"
        '
        'txtstart_date
        '
        Me.txtstart_date.Location = New System.Drawing.Point(1188, 80)
        Me.txtstart_date.Name = "txtstart_date"
        Me.txtstart_date.Size = New System.Drawing.Size(100, 20)
        Me.txtstart_date.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1094, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Start Date :"
        '
        'txtmrcode
        '
        Me.txtmrcode.Location = New System.Drawing.Point(1188, 54)
        Me.txtmrcode.Name = "txtmrcode"
        Me.txtmrcode.Size = New System.Drawing.Size(100, 20)
        Me.txtmrcode.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1094, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Specialist Code :"
        '
        'txtAreaCode
        '
        Me.txtAreaCode.Location = New System.Drawing.Point(1188, 28)
        Me.txtAreaCode.Name = "txtAreaCode"
        Me.txtAreaCode.Size = New System.Drawing.Size(100, 20)
        Me.txtAreaCode.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1094, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Area Code :"
        '
        'frmDistrictAreaAreaPMR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1333, 648)
        Me.Controls.Add(Me.gbArea)
        Me.Controls.Add(Me.gbAreaPMR)
        Me.Name = "frmDistrictAreaAreaPMR"
        Me.Text = "District-Area-AreaPMR"
        Me.gbArea.ResumeLayout(False)
        Me.gbArea.PerformLayout()
        CType(Me.dgvArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAreaPMR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAreaPMR.ResumeLayout(False)
        Me.gbAreaPMR.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbArea As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpMonth As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgvArea As System.Windows.Forms.DataGridView
    Friend WithEvents dgvAreaPMR As System.Windows.Forms.DataGridView
    Friend WithEvents gbAreaPMR As System.Windows.Forms.GroupBox
    Friend WithEvents txtAreaCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtarearowid As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtdeleted As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtlastuser As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtend_date As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtstart_date As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtmrcode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnUpdateAreaPMR As System.Windows.Forms.Button
    Friend WithEvents btnInsertAreaPMR As System.Windows.Forms.Button
    Friend WithEvents txtRowID As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
