<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResignedTM
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
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lbltosegment = New System.Windows.Forms.Label()
        Me.lblfromsegment = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnTransferTM = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txttodate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtfromdate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txttosupcode = New System.Windows.Forms.TextBox()
        Me.txtfromsupcode = New System.Windows.Forms.TextBox()
        Me.txtToTMName = New System.Windows.Forms.TextBox()
        Me.dgvToTM = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFromTMName = New System.Windows.Forms.TextBox()
        Me.dgvFromTM = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvToTM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFromTM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.lbltosegment)
        Me.GroupBox1.Controls.Add(Me.lblfromsegment)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.btnTransferTM)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txttodate)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtfromdate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.txttosupcode)
        Me.GroupBox1.Controls.Add(Me.txtfromsupcode)
        Me.GroupBox1.Controls.Add(Me.txtToTMName)
        Me.GroupBox1.Controls.Add(Me.dgvToTM)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtFromTMName)
        Me.GroupBox1.Controls.Add(Me.dgvFromTM)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(12, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1309, 589)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.Image = Global.ScoresDotNet.My.Resources.Resources.Math_minus_icon
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.Location = New System.Drawing.Point(1190, 73)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(113, 42)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "    Clear"
        Me.btnClear.UseVisualStyleBackColor = True
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
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(1190, 184)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(113, 394)
        Me.ListBox1.TabIndex = 16
        '
        'btnTransferTM
        '
        Me.btnTransferTM.Image = Global.ScoresDotNet.My.Resources.Resources.save
        Me.btnTransferTM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransferTM.Location = New System.Drawing.Point(1190, 25)
        Me.btnTransferTM.Name = "btnTransferTM"
        Me.btnTransferTM.Size = New System.Drawing.Size(113, 42)
        Me.btnTransferTM.TabIndex = 7
        Me.btnTransferTM.Text = "Transfer TM"
        Me.btnTransferTM.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(632, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "To TM :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "From TM :"
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
        Me.btnClose.Location = New System.Drawing.Point(1190, 121)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(113, 42)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "    &Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txttosupcode
        '
        Me.txttosupcode.Enabled = False
        Me.txttosupcode.Location = New System.Drawing.Point(746, 51)
        Me.txttosupcode.Name = "txttosupcode"
        Me.txttosupcode.Size = New System.Drawing.Size(256, 20)
        Me.txttosupcode.TabIndex = 5
        '
        'txtfromsupcode
        '
        Me.txtfromsupcode.Enabled = False
        Me.txtfromsupcode.Location = New System.Drawing.Point(127, 51)
        Me.txtfromsupcode.Name = "txtfromsupcode"
        Me.txtfromsupcode.Size = New System.Drawing.Size(245, 20)
        Me.txtfromsupcode.TabIndex = 2
        '
        'txtToTMName
        '
        Me.txtToTMName.Location = New System.Drawing.Point(746, 25)
        Me.txtToTMName.Name = "txtToTMName"
        Me.txtToTMName.Size = New System.Drawing.Size(434, 20)
        Me.txtToTMName.TabIndex = 4
        '
        'dgvToTM
        '
        Me.dgvToTM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvToTM.Location = New System.Drawing.Point(635, 108)
        Me.dgvToTM.Name = "dgvToTM"
        Me.dgvToTM.Size = New System.Drawing.Size(545, 470)
        Me.dgvToTM.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(632, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Search TM :"
        '
        'txtFromTMName
        '
        Me.txtFromTMName.Location = New System.Drawing.Point(127, 25)
        Me.txtFromTMName.Name = "txtFromTMName"
        Me.txtFromTMName.Size = New System.Drawing.Size(436, 20)
        Me.txtFromTMName.TabIndex = 1
        '
        'dgvFromTM
        '
        Me.dgvFromTM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFromTM.Location = New System.Drawing.Point(15, 108)
        Me.dgvFromTM.Name = "dgvFromTM"
        Me.dgvFromTM.Size = New System.Drawing.Size(548, 470)
        Me.dgvFromTM.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search TM :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(12, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(554, 20)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Important Reminder : Please make sure Start Date and End Date are correct."
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
        Me.Text = "Update Resigned TM"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvToTM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFromTM, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txttosupcode As System.Windows.Forms.TextBox
    Friend WithEvents txtfromsupcode As System.Windows.Forms.TextBox
    Friend WithEvents txtToTMName As System.Windows.Forms.TextBox
    Friend WithEvents dgvToTM As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFromTMName As System.Windows.Forms.TextBox
    Friend WithEvents dgvFromTM As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnTransferTM As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents lbltosegment As System.Windows.Forms.Label
    Friend WithEvents lblfromsegment As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
End Class
