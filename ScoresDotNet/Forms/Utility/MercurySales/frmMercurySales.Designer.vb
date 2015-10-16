<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMercurySales
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txttodate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtfromdate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnTRansferBudget = New System.Windows.Forms.Button()
        Me.txttomrcode = New System.Windows.Forms.TextBox()
        Me.txtfrommrcode = New System.Windows.Forms.TextBox()
        Me.txtToMrName = New System.Windows.Forms.TextBox()
        Me.dgvToSpecialist = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFromMrName = New System.Windows.Forms.TextBox()
        Me.dgvFromSpecialist = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvToSpecialist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFromSpecialist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.txttodate.TabIndex = 73
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
        Me.txtfromdate.TabIndex = 71
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
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(1207, 82)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(92, 35)
        Me.btnClose.TabIndex = 69
        Me.btnClose.Text = "    &Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnTRansferBudget
        '
        Me.btnTRansferBudget.Image = Global.ScoresDotNet.My.Resources.Resources.save
        Me.btnTRansferBudget.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTRansferBudget.Location = New System.Drawing.Point(1207, 25)
        Me.btnTRansferBudget.Name = "btnTRansferBudget"
        Me.btnTRansferBudget.Size = New System.Drawing.Size(92, 38)
        Me.btnTRansferBudget.TabIndex = 68
        Me.btnTRansferBudget.Text = "       Transfer Sales"
        Me.btnTRansferBudget.UseVisualStyleBackColor = True
        '
        'txttomrcode
        '
        Me.txttomrcode.Enabled = False
        Me.txttomrcode.Location = New System.Drawing.Point(722, 51)
        Me.txttomrcode.Name = "txttomrcode"
        Me.txttomrcode.Size = New System.Drawing.Size(280, 20)
        Me.txttomrcode.TabIndex = 65
        '
        'txtfrommrcode
        '
        Me.txtfrommrcode.Enabled = False
        Me.txtfrommrcode.Location = New System.Drawing.Point(102, 51)
        Me.txtfrommrcode.Name = "txtfrommrcode"
        Me.txtfrommrcode.Size = New System.Drawing.Size(270, 20)
        Me.txtfrommrcode.TabIndex = 64
        '
        'txtToMrName
        '
        Me.txtToMrName.Location = New System.Drawing.Point(722, 25)
        Me.txtToMrName.Name = "txtToMrName"
        Me.txtToMrName.Size = New System.Drawing.Size(458, 20)
        Me.txtToMrName.TabIndex = 63
        '
        'dgvToSpecialist
        '
        Me.dgvToSpecialist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvToSpecialist.Location = New System.Drawing.Point(635, 82)
        Me.dgvToSpecialist.Name = "dgvToSpecialist"
        Me.dgvToSpecialist.Size = New System.Drawing.Size(545, 524)
        Me.dgvToSpecialist.TabIndex = 62
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
        Me.txtFromMrName.Location = New System.Drawing.Point(102, 25)
        Me.txtFromMrName.Name = "txtFromMrName"
        Me.txtFromMrName.Size = New System.Drawing.Size(461, 20)
        Me.txtFromMrName.TabIndex = 60
        '
        'dgvFromSpecialist
        '
        Me.dgvFromSpecialist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFromSpecialist.Location = New System.Drawing.Point(15, 82)
        Me.dgvFromSpecialist.Name = "dgvFromSpecialist"
        Me.dgvFromSpecialist.Size = New System.Drawing.Size(548, 524)
        Me.dgvFromSpecialist.TabIndex = 59
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txttodate)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtfromdate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnTRansferBudget)
        Me.GroupBox1.Controls.Add(Me.txttomrcode)
        Me.GroupBox1.Controls.Add(Me.txtfrommrcode)
        Me.GroupBox1.Controls.Add(Me.txtToMrName)
        Me.GroupBox1.Controls.Add(Me.dgvToSpecialist)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtFromMrName)
        Me.GroupBox1.Controls.Add(Me.dgvFromSpecialist)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1309, 624)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transfer Mercury Sales"
        '
        'frmMercurySales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1333, 648)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMercurySales"
        Me.Text = "Mercury Sales"
        CType(Me.dgvToSpecialist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFromSpecialist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txttodate As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtfromdate As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnTRansferBudget As System.Windows.Forms.Button
    Friend WithEvents txttomrcode As System.Windows.Forms.TextBox
    Friend WithEvents txtfrommrcode As System.Windows.Forms.TextBox
    Friend WithEvents txtToMrName As System.Windows.Forms.TextBox
    Friend WithEvents dgvToSpecialist As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFromMrName As System.Windows.Forms.TextBox
    Friend WithEvents dgvFromSpecialist As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
