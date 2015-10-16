<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResignedSpecialist
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbltosegment = New System.Windows.Forms.Label()
        Me.lblfromsegment = New System.Windows.Forms.Label()
        Me.btnProcessAll = New System.Windows.Forms.Button()
        Me.btnUpdateSupMr = New System.Windows.Forms.Button()
        Me.btnUpdateSpecialist = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnTransferIntegratedSalesToSP = New System.Windows.Forms.Button()
        Me.btnTransferArea = New System.Windows.Forms.Button()
        Me.btnTransferBudgets = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txttodate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtfromdate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnTransferMercury = New System.Windows.Forms.Button()
        Me.txttomrcode = New System.Windows.Forms.TextBox()
        Me.txtfrommrcode = New System.Windows.Forms.TextBox()
        Me.txtToMrName = New System.Windows.Forms.TextBox()
        Me.dgvToSpecialist = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFromMrName = New System.Windows.Forms.TextBox()
        Me.dgvFromSpecialist = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvToSpecialist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFromSpecialist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.lbltosegment)
        Me.GroupBox1.Controls.Add(Me.lblfromsegment)
        Me.GroupBox1.Controls.Add(Me.btnProcessAll)
        Me.GroupBox1.Controls.Add(Me.btnUpdateSupMr)
        Me.GroupBox1.Controls.Add(Me.btnUpdateSpecialist)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.btnTransferIntegratedSalesToSP)
        Me.GroupBox1.Controls.Add(Me.btnTransferArea)
        Me.GroupBox1.Controls.Add(Me.btnTransferBudgets)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txttodate)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtfromdate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnTransferMercury)
        Me.GroupBox1.Controls.Add(Me.txttomrcode)
        Me.GroupBox1.Controls.Add(Me.txtfrommrcode)
        Me.GroupBox1.Controls.Add(Me.txtToMrName)
        Me.GroupBox1.Controls.Add(Me.dgvToSpecialist)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtFromMrName)
        Me.GroupBox1.Controls.Add(Me.dgvFromSpecialist)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(12, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1309, 589)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'lbltosegment
        '
        Me.lbltosegment.AutoSize = True
        Me.lbltosegment.Location = New System.Drawing.Point(632, 80)
        Me.lbltosegment.Name = "lbltosegment"
        Me.lbltosegment.Size = New System.Drawing.Size(71, 13)
        Me.lbltosegment.TabIndex = 84
        Me.lbltosegment.Text = "To Segment :"
        '
        'lblfromsegment
        '
        Me.lblfromsegment.AutoSize = True
        Me.lblfromsegment.Location = New System.Drawing.Point(12, 80)
        Me.lblfromsegment.Name = "lblfromsegment"
        Me.lblfromsegment.Size = New System.Drawing.Size(81, 13)
        Me.lblfromsegment.TabIndex = 83
        Me.lblfromsegment.Text = "From Segment :"
        '
        'btnProcessAll
        '
        Me.btnProcessAll.Image = Global.ScoresDotNet.My.Resources.Resources.save
        Me.btnProcessAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProcessAll.Location = New System.Drawing.Point(1190, 313)
        Me.btnProcessAll.Name = "btnProcessAll"
        Me.btnProcessAll.Size = New System.Drawing.Size(113, 42)
        Me.btnProcessAll.TabIndex = 13
        Me.btnProcessAll.Text = "     Process All"
        Me.btnProcessAll.UseVisualStyleBackColor = True
        '
        'btnUpdateSupMr
        '
        Me.btnUpdateSupMr.Image = Global.ScoresDotNet.My.Resources.Resources.save
        Me.btnUpdateSupMr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdateSupMr.Location = New System.Drawing.Point(1190, 265)
        Me.btnUpdateSupMr.Name = "btnUpdateSupMr"
        Me.btnUpdateSupMr.Size = New System.Drawing.Size(113, 42)
        Me.btnUpdateSupMr.TabIndex = 12
        Me.btnUpdateSupMr.Text = "      Update SupMr"
        Me.btnUpdateSupMr.UseVisualStyleBackColor = True
        '
        'btnUpdateSpecialist
        '
        Me.btnUpdateSpecialist.Image = Global.ScoresDotNet.My.Resources.Resources.save
        Me.btnUpdateSpecialist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdateSpecialist.Location = New System.Drawing.Point(1190, 217)
        Me.btnUpdateSpecialist.Name = "btnUpdateSpecialist"
        Me.btnUpdateSpecialist.Size = New System.Drawing.Size(113, 42)
        Me.btnUpdateSpecialist.TabIndex = 11
        Me.btnUpdateSpecialist.Text = "      Update Specialist"
        Me.btnUpdateSpecialist.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(1190, 457)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(113, 121)
        Me.ListBox1.TabIndex = 16
        '
        'btnTransferIntegratedSalesToSP
        '
        Me.btnTransferIntegratedSalesToSP.Image = Global.ScoresDotNet.My.Resources.Resources.save
        Me.btnTransferIntegratedSalesToSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransferIntegratedSalesToSP.Location = New System.Drawing.Point(1190, 169)
        Me.btnTransferIntegratedSalesToSP.Name = "btnTransferIntegratedSalesToSP"
        Me.btnTransferIntegratedSalesToSP.Size = New System.Drawing.Size(113, 42)
        Me.btnTransferIntegratedSalesToSP.TabIndex = 10
        Me.btnTransferIntegratedSalesToSP.Text = "       Transfer Sales"
        Me.btnTransferIntegratedSalesToSP.UseVisualStyleBackColor = True
        '
        'btnTransferArea
        '
        Me.btnTransferArea.Image = Global.ScoresDotNet.My.Resources.Resources.save
        Me.btnTransferArea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransferArea.Location = New System.Drawing.Point(1190, 73)
        Me.btnTransferArea.Name = "btnTransferArea"
        Me.btnTransferArea.Size = New System.Drawing.Size(113, 42)
        Me.btnTransferArea.TabIndex = 8
        Me.btnTransferArea.Text = "       Transfer Area"
        Me.btnTransferArea.UseVisualStyleBackColor = True
        '
        'btnTransferBudgets
        '
        Me.btnTransferBudgets.Image = Global.ScoresDotNet.My.Resources.Resources.save
        Me.btnTransferBudgets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransferBudgets.Location = New System.Drawing.Point(1190, 25)
        Me.btnTransferBudgets.Name = "btnTransferBudgets"
        Me.btnTransferBudgets.Size = New System.Drawing.Size(113, 42)
        Me.btnTransferBudgets.TabIndex = 7
        Me.btnTransferBudgets.Text = "       Transfer Budget"
        Me.btnTransferBudgets.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(632, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "To Specialist :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "From Specialist :"
        '
        'txttodate
        '
        Me.txttodate.Location = New System.Drawing.Point(1098, 54)
        Me.txttodate.Name = "txttodate"
        Me.txttodate.Size = New System.Drawing.Size(82, 20)
        Me.txttodate.TabIndex = 6
        Me.txttodate.Text = "12/31/2015"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1027, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "To Date :"
        '
        'txtfromdate
        '
        Me.txtfromdate.Location = New System.Drawing.Point(471, 51)
        Me.txtfromdate.Name = "txtfromdate"
        Me.txtfromdate.Size = New System.Drawing.Size(92, 20)
        Me.txtfromdate.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(391, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "From Date :"
        '
        'btnClose
        '
        Me.btnClose.Image = Global.ScoresDotNet.My.Resources.Resources.door_out_icon2
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(1190, 409)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(113, 42)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "    &Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnTransferMercury
        '
        Me.btnTransferMercury.Image = Global.ScoresDotNet.My.Resources.Resources.save
        Me.btnTransferMercury.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransferMercury.Location = New System.Drawing.Point(1190, 121)
        Me.btnTransferMercury.Name = "btnTransferMercury"
        Me.btnTransferMercury.Size = New System.Drawing.Size(113, 42)
        Me.btnTransferMercury.TabIndex = 9
        Me.btnTransferMercury.Text = "       Transfer Mercury"
        Me.btnTransferMercury.UseVisualStyleBackColor = True
        '
        'txttomrcode
        '
        Me.txttomrcode.Enabled = False
        Me.txttomrcode.Location = New System.Drawing.Point(746, 51)
        Me.txttomrcode.Name = "txttomrcode"
        Me.txttomrcode.Size = New System.Drawing.Size(256, 20)
        Me.txttomrcode.TabIndex = 5
        '
        'txtfrommrcode
        '
        Me.txtfrommrcode.Enabled = False
        Me.txtfrommrcode.Location = New System.Drawing.Point(127, 51)
        Me.txtfrommrcode.Name = "txtfrommrcode"
        Me.txtfrommrcode.Size = New System.Drawing.Size(245, 20)
        Me.txtfrommrcode.TabIndex = 2
        '
        'txtToMrName
        '
        Me.txtToMrName.Location = New System.Drawing.Point(746, 25)
        Me.txtToMrName.Name = "txtToMrName"
        Me.txtToMrName.Size = New System.Drawing.Size(434, 20)
        Me.txtToMrName.TabIndex = 4
        '
        'dgvToSpecialist
        '
        Me.dgvToSpecialist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvToSpecialist.Location = New System.Drawing.Point(635, 108)
        Me.dgvToSpecialist.Name = "dgvToSpecialist"
        Me.dgvToSpecialist.Size = New System.Drawing.Size(545, 470)
        Me.dgvToSpecialist.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(632, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Search Specialist :"
        '
        'txtFromMrName
        '
        Me.txtFromMrName.Location = New System.Drawing.Point(127, 25)
        Me.txtFromMrName.Name = "txtFromMrName"
        Me.txtFromMrName.Size = New System.Drawing.Size(436, 20)
        Me.txtFromMrName.TabIndex = 1
        '
        'dgvFromSpecialist
        '
        Me.dgvFromSpecialist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFromSpecialist.Location = New System.Drawing.Point(15, 108)
        Me.dgvFromSpecialist.Name = "dgvFromSpecialist"
        Me.dgvFromSpecialist.Size = New System.Drawing.Size(548, 470)
        Me.dgvFromSpecialist.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search Specialist :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(12, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(1100, 20)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Important Reminder : Please make sure Start Date and End Date are correct. Please" & _
    " do not assign TM to new Specialist, TM will be assigned Automatically."
        '
        'btnClear
        '
        Me.btnClear.Image = Global.ScoresDotNet.My.Resources.Resources.Math_minus_icon
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.Location = New System.Drawing.Point(1190, 361)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(113, 42)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "    Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmResignedSpecialist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1333, 648)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmResignedSpecialist"
        Me.Text = "Update Resigned Specialist"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvToSpecialist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFromSpecialist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txttodate As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtfromdate As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnTransferMercury As System.Windows.Forms.Button
    Friend WithEvents txttomrcode As System.Windows.Forms.TextBox
    Friend WithEvents txtfrommrcode As System.Windows.Forms.TextBox
    Friend WithEvents txtToMrName As System.Windows.Forms.TextBox
    Friend WithEvents dgvToSpecialist As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFromMrName As System.Windows.Forms.TextBox
    Friend WithEvents dgvFromSpecialist As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnTransferBudgets As System.Windows.Forms.Button
    Friend WithEvents btnTransferArea As System.Windows.Forms.Button
    Friend WithEvents btnTransferIntegratedSalesToSP As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents btnUpdateSupMr As System.Windows.Forms.Button
    Friend WithEvents btnUpdateSpecialist As System.Windows.Forms.Button
    Friend WithEvents btnProcessAll As System.Windows.Forms.Button
    Friend WithEvents lbltosegment As System.Windows.Forms.Label
    Friend WithEvents lblfromsegment As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
End Class
