<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSegSegHead
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvSegment = New System.Windows.Forms.DataGridView()
        Me.dgvSegmentHead = New System.Windows.Forms.DataGridView()
        Me.gbAreaPMR = New System.Windows.Forms.GroupBox()
        Me.btnUpdateSegmentHead = New System.Windows.Forms.Button()
        Me.btnAddSegmentHead = New System.Windows.Forms.Button()
        Me.txtdimsh = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdivnamesh = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtdivcodesh = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNSM = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtrowidsh = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.gbArea = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtstatus = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtdivname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdimcode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtdivcode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRowID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpMonth = New System.Windows.Forms.DateTimePicker()
        Me.txtdimcodesh = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtStartDate = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtEndDate = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtNSMCode = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        CType(Me.dgvSegment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSegmentHead, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAreaPMR.SuspendLayout()
        Me.gbArea.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvSegment
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvSegment.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvSegment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSegment.Location = New System.Drawing.Point(8, 38)
        Me.dgvSegment.Name = "dgvSegment"
        Me.dgvSegment.Size = New System.Drawing.Size(1035, 227)
        Me.dgvSegment.TabIndex = 1
        '
        'dgvSegmentHead
        '
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvSegmentHead.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvSegmentHead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSegmentHead.Location = New System.Drawing.Point(12, 28)
        Me.dgvSegmentHead.Name = "dgvSegmentHead"
        Me.dgvSegmentHead.Size = New System.Drawing.Size(1033, 286)
        Me.dgvSegmentHead.TabIndex = 1
        '
        'gbAreaPMR
        '
        Me.gbAreaPMR.Controls.Add(Me.txtNSMCode)
        Me.gbAreaPMR.Controls.Add(Me.Label15)
        Me.gbAreaPMR.Controls.Add(Me.txtEndDate)
        Me.gbAreaPMR.Controls.Add(Me.Label14)
        Me.gbAreaPMR.Controls.Add(Me.txtStartDate)
        Me.gbAreaPMR.Controls.Add(Me.Label13)
        Me.gbAreaPMR.Controls.Add(Me.txtdimcodesh)
        Me.gbAreaPMR.Controls.Add(Me.Label12)
        Me.gbAreaPMR.Controls.Add(Me.btnUpdateSegmentHead)
        Me.gbAreaPMR.Controls.Add(Me.btnAddSegmentHead)
        Me.gbAreaPMR.Controls.Add(Me.txtdimsh)
        Me.gbAreaPMR.Controls.Add(Me.Label6)
        Me.gbAreaPMR.Controls.Add(Me.txtdivnamesh)
        Me.gbAreaPMR.Controls.Add(Me.Label8)
        Me.gbAreaPMR.Controls.Add(Me.txtdivcodesh)
        Me.gbAreaPMR.Controls.Add(Me.Label9)
        Me.gbAreaPMR.Controls.Add(Me.txtNSM)
        Me.gbAreaPMR.Controls.Add(Me.Label10)
        Me.gbAreaPMR.Controls.Add(Me.txtrowidsh)
        Me.gbAreaPMR.Controls.Add(Me.Label11)
        Me.gbAreaPMR.Controls.Add(Me.dgvSegmentHead)
        Me.gbAreaPMR.Location = New System.Drawing.Point(16, 307)
        Me.gbAreaPMR.Name = "gbAreaPMR"
        Me.gbAreaPMR.Size = New System.Drawing.Size(1293, 329)
        Me.gbAreaPMR.TabIndex = 33
        Me.gbAreaPMR.TabStop = False
        Me.gbAreaPMR.Text = "Total No of Area :"
        '
        'btnUpdateSegmentHead
        '
        Me.btnUpdateSegmentHead.Location = New System.Drawing.Point(1133, 291)
        Me.btnUpdateSegmentHead.Name = "btnUpdateSegmentHead"
        Me.btnUpdateSegmentHead.Size = New System.Drawing.Size(142, 23)
        Me.btnUpdateSegmentHead.TabIndex = 35
        Me.btnUpdateSegmentHead.Text = "Update Segment Head"
        Me.btnUpdateSegmentHead.UseVisualStyleBackColor = True
        '
        'btnAddSegmentHead
        '
        Me.btnAddSegmentHead.Location = New System.Drawing.Point(1133, 262)
        Me.btnAddSegmentHead.Name = "btnAddSegmentHead"
        Me.btnAddSegmentHead.Size = New System.Drawing.Size(142, 23)
        Me.btnAddSegmentHead.TabIndex = 34
        Me.btnAddSegmentHead.Text = "Insert New Segment Head"
        Me.btnAddSegmentHead.UseVisualStyleBackColor = True
        '
        'txtdimsh
        '
        Me.txtdimsh.Location = New System.Drawing.Point(1133, 158)
        Me.txtdimsh.Name = "txtdimsh"
        Me.txtdimsh.Size = New System.Drawing.Size(142, 20)
        Me.txtdimsh.TabIndex = 33
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1060, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "DIM NSM :"
        '
        'txtdivnamesh
        '
        Me.txtdivnamesh.Location = New System.Drawing.Point(1133, 132)
        Me.txtdivnamesh.Name = "txtdivnamesh"
        Me.txtdivnamesh.Size = New System.Drawing.Size(142, 20)
        Me.txtdivnamesh.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1060, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Div Name :"
        '
        'txtdivcodesh
        '
        Me.txtdivcodesh.Location = New System.Drawing.Point(1133, 106)
        Me.txtdivcodesh.Name = "txtdivcodesh"
        Me.txtdivcodesh.Size = New System.Drawing.Size(142, 20)
        Me.txtdivcodesh.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1060, 109)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Div Code :"
        '
        'txtNSM
        '
        Me.txtNSM.Location = New System.Drawing.Point(1133, 54)
        Me.txtNSM.Name = "txtNSM"
        Me.txtNSM.Size = New System.Drawing.Size(142, 20)
        Me.txtNSM.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(1060, 57)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "NSM :"
        '
        'txtrowidsh
        '
        Me.txtrowidsh.Location = New System.Drawing.Point(1133, 28)
        Me.txtrowidsh.Name = "txtrowidsh"
        Me.txtrowidsh.Size = New System.Drawing.Size(142, 20)
        Me.txtrowidsh.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(1060, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Row ID :"
        '
        'gbArea
        '
        Me.gbArea.Controls.Add(Me.Button1)
        Me.gbArea.Controls.Add(Me.btnAdd)
        Me.gbArea.Controls.Add(Me.txtstatus)
        Me.gbArea.Controls.Add(Me.Label7)
        Me.gbArea.Controls.Add(Me.txtdivname)
        Me.gbArea.Controls.Add(Me.Label4)
        Me.gbArea.Controls.Add(Me.txtdimcode)
        Me.gbArea.Controls.Add(Me.Label5)
        Me.gbArea.Controls.Add(Me.txtdivcode)
        Me.gbArea.Controls.Add(Me.Label2)
        Me.gbArea.Controls.Add(Me.txtRowID)
        Me.gbArea.Controls.Add(Me.Label1)
        Me.gbArea.Controls.Add(Me.Label3)
        Me.gbArea.Controls.Add(Me.dtpMonth)
        Me.gbArea.Controls.Add(Me.dgvSegment)
        Me.gbArea.Location = New System.Drawing.Point(18, 12)
        Me.gbArea.Name = "gbArea"
        Me.gbArea.Size = New System.Drawing.Size(1293, 280)
        Me.gbArea.TabIndex = 34
        Me.gbArea.TabStop = False
        Me.gbArea.Text = "Total No of Area :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1131, 216)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 23)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Update Segment"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(1131, 187)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(142, 23)
        Me.btnAdd.TabIndex = 22
        Me.btnAdd.Text = "Insert New Segment"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtstatus
        '
        Me.txtstatus.Location = New System.Drawing.Point(1131, 142)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Size = New System.Drawing.Size(142, 20)
        Me.txtstatus.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1058, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Status :"
        '
        'txtdivname
        '
        Me.txtdivname.Location = New System.Drawing.Point(1131, 116)
        Me.txtdivname.Name = "txtdivname"
        Me.txtdivname.Size = New System.Drawing.Size(142, 20)
        Me.txtdivname.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1058, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Div Name :"
        '
        'txtdimcode
        '
        Me.txtdimcode.Location = New System.Drawing.Point(1131, 90)
        Me.txtdimcode.Name = "txtdimcode"
        Me.txtdimcode.Size = New System.Drawing.Size(142, 20)
        Me.txtdimcode.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1058, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Dim Code :"
        '
        'txtdivcode
        '
        Me.txtdivcode.Location = New System.Drawing.Point(1131, 64)
        Me.txtdivcode.Name = "txtdivcode"
        Me.txtdivcode.Size = New System.Drawing.Size(142, 20)
        Me.txtdivcode.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1058, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Div Code :"
        '
        'txtRowID
        '
        Me.txtRowID.Location = New System.Drawing.Point(1131, 38)
        Me.txtRowID.Name = "txtRowID"
        Me.txtRowID.Size = New System.Drawing.Size(142, 20)
        Me.txtRowID.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1058, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Row ID :"
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
        'txtdimcodesh
        '
        Me.txtdimcodesh.Location = New System.Drawing.Point(1133, 184)
        Me.txtdimcodesh.Name = "txtdimcodesh"
        Me.txtdimcodesh.Size = New System.Drawing.Size(142, 20)
        Me.txtdimcodesh.TabIndex = 37
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(1060, 187)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "DIM Code:"
        '
        'txtStartDate
        '
        Me.txtStartDate.Location = New System.Drawing.Point(1133, 210)
        Me.txtStartDate.Name = "txtStartDate"
        Me.txtStartDate.Size = New System.Drawing.Size(142, 20)
        Me.txtStartDate.TabIndex = 39
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(1060, 213)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 13)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "Start Date:"
        '
        'txtEndDate
        '
        Me.txtEndDate.Location = New System.Drawing.Point(1133, 236)
        Me.txtEndDate.Name = "txtEndDate"
        Me.txtEndDate.Size = New System.Drawing.Size(142, 20)
        Me.txtEndDate.TabIndex = 41
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(1060, 239)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 13)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "End Date:"
        '
        'txtNSMCode
        '
        Me.txtNSMCode.Location = New System.Drawing.Point(1133, 80)
        Me.txtNSMCode.Name = "txtNSMCode"
        Me.txtNSMCode.Size = New System.Drawing.Size(142, 20)
        Me.txtNSMCode.TabIndex = 43
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(1060, 83)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 13)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "NSM Code :"
        '
        'frmSegSegHead
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1333, 648)
        Me.Controls.Add(Me.gbAreaPMR)
        Me.Controls.Add(Me.gbArea)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSegSegHead"
        Me.Text = "Sement - Segment Head Assignment"
        CType(Me.dgvSegment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSegmentHead, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAreaPMR.ResumeLayout(False)
        Me.gbAreaPMR.PerformLayout()
        Me.gbArea.ResumeLayout(False)
        Me.gbArea.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvSegment As System.Windows.Forms.DataGridView
    Friend WithEvents dgvSegmentHead As System.Windows.Forms.DataGridView
    Friend WithEvents gbAreaPMR As System.Windows.Forms.GroupBox
    Friend WithEvents gbArea As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpMonth As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtstatus As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtdivname As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtdimcode As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtdivcode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRowID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdateSegmentHead As System.Windows.Forms.Button
    Friend WithEvents btnAddSegmentHead As System.Windows.Forms.Button
    Friend WithEvents txtdimsh As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtdivnamesh As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtdivcodesh As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNSM As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtrowidsh As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtdimcodesh As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtEndDate As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtStartDate As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtNSMCode As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
