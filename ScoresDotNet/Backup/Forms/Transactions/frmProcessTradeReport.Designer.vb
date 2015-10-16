<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProcessTradeReport
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtEnd = New System.Windows.Forms.DateTimePicker
        Me.dtStart = New System.Windows.Forms.DateTimePicker
        Me.btnProcess = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.btnCheck = New System.Windows.Forms.Button
        Me.chkBrPrRe = New System.Windows.Forms.CheckBox
        Me.chkNoTMSP = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.dtStartLast = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtEndLast = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.chkUpdateTerDist = New System.Windows.Forms.CheckBox
        Me.chkCorrectTMSP = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(243, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "End Date"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(17, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Start Date"
        '
        'dtEnd
        '
        Me.dtEnd.Location = New System.Drawing.Point(243, 45)
        Me.dtEnd.Name = "dtEnd"
        Me.dtEnd.Size = New System.Drawing.Size(200, 20)
        Me.dtEnd.TabIndex = 10
        '
        'dtStart
        '
        Me.dtStart.Location = New System.Drawing.Point(17, 45)
        Me.dtStart.Name = "dtStart"
        Me.dtStart.Size = New System.Drawing.Size(200, 20)
        Me.dtStart.TabIndex = 9
        '
        'btnProcess
        '
        Me.btnProcess.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnProcess.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnProcess.Location = New System.Drawing.Point(299, 439)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(75, 23)
        Me.btnProcess.TabIndex = 7
        Me.btnProcess.Text = "&Process"
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(380, 439)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "&Cancel"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtStart)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtEnd)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(460, 81)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "This Year Date Range"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.btnCheck)
        Me.GroupBox2.Controls.Add(Me.chkBrPrRe)
        Me.GroupBox2.Controls.Add(Me.chkNoTMSP)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 192)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(460, 109)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Check SalesTrendStkTrfPivot"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Location = New System.Drawing.Point(17, 74)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(185, 17)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Check Territory and District Name"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCheck.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnCheck.Enabled = False
        Me.btnCheck.Location = New System.Drawing.Point(368, 76)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(75, 23)
        Me.btnCheck.TabIndex = 8
        Me.btnCheck.Text = "&Check"
        '
        'chkBrPrRe
        '
        Me.chkBrPrRe.AutoSize = True
        Me.chkBrPrRe.Enabled = False
        Me.chkBrPrRe.Location = New System.Drawing.Point(17, 51)
        Me.chkBrPrRe.Name = "chkBrPrRe"
        Me.chkBrPrRe.Size = New System.Drawing.Size(172, 17)
        Me.chkBrPrRe.TabIndex = 1
        Me.chkBrPrRe.Text = "Check Brick, Province, Region"
        Me.chkBrPrRe.UseVisualStyleBackColor = True
        '
        'chkNoTMSP
        '
        Me.chkNoTMSP.AutoSize = True
        Me.chkNoTMSP.Enabled = False
        Me.chkNoTMSP.Location = New System.Drawing.Point(17, 28)
        Me.chkNoTMSP.Name = "chkNoTMSP"
        Me.chkNoTMSP.Size = New System.Drawing.Size(230, 17)
        Me.chkNoTMSP.TabIndex = 0
        Me.chkNoTMSP.Text = "Check Records with no current TM and SP"
        Me.chkNoTMSP.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dtStartLast)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.dtEndLast)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 105)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(460, 81)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Last Year Date Range"
        '
        'dtStartLast
        '
        Me.dtStartLast.Location = New System.Drawing.Point(17, 45)
        Me.dtStartLast.Name = "dtStartLast"
        Me.dtStartLast.Size = New System.Drawing.Size(200, 20)
        Me.dtStartLast.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(243, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "End Date"
        '
        'dtEndLast
        '
        Me.dtEndLast.Location = New System.Drawing.Point(243, 45)
        Me.dtEndLast.Name = "dtEndLast"
        Me.dtEndLast.Size = New System.Drawing.Size(200, 20)
        Me.dtEndLast.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(17, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Start Date"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CheckBox2)
        Me.GroupBox4.Controls.Add(Me.btnUpdate)
        Me.GroupBox4.Controls.Add(Me.chkUpdateTerDist)
        Me.GroupBox4.Controls.Add(Me.chkCorrectTMSP)
        Me.GroupBox4.Location = New System.Drawing.Point(14, 307)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(460, 109)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Update SalesTrendStkTrfPivot"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Enabled = False
        Me.CheckBox2.Location = New System.Drawing.Point(17, 51)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(176, 17)
        Me.CheckBox2.TabIndex = 9
        Me.CheckBox2.Text = "Update Brick, Province, Region"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Location = New System.Drawing.Point(368, 76)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "&Update"
        '
        'chkUpdateTerDist
        '
        Me.chkUpdateTerDist.AutoSize = True
        Me.chkUpdateTerDist.Enabled = False
        Me.chkUpdateTerDist.Location = New System.Drawing.Point(17, 74)
        Me.chkUpdateTerDist.Name = "chkUpdateTerDist"
        Me.chkUpdateTerDist.Size = New System.Drawing.Size(189, 17)
        Me.chkUpdateTerDist.TabIndex = 1
        Me.chkUpdateTerDist.Text = "Update Territory and District Name"
        Me.chkUpdateTerDist.UseVisualStyleBackColor = True
        '
        'chkCorrectTMSP
        '
        Me.chkCorrectTMSP.AutoSize = True
        Me.chkCorrectTMSP.Enabled = False
        Me.chkCorrectTMSP.Location = New System.Drawing.Point(17, 28)
        Me.chkCorrectTMSP.Name = "chkCorrectTMSP"
        Me.chkCorrectTMSP.Size = New System.Drawing.Size(234, 17)
        Me.chkCorrectTMSP.TabIndex = 0
        Me.chkCorrectTMSP.Text = "Update Records with no current TM and SP"
        Me.chkCorrectTMSP.UseVisualStyleBackColor = True
        '
        'frmProcessTradeReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 474)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.btnCancel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProcessTradeReport"
        Me.Text = "Process Trade Report"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dtStartLast As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtEndLast As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkBrPrRe As System.Windows.Forms.CheckBox
    Friend WithEvents chkNoTMSP As System.Windows.Forms.CheckBox
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents chkUpdateTerDist As System.Windows.Forms.CheckBox
    Friend WithEvents chkCorrectTMSP As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
End Class
