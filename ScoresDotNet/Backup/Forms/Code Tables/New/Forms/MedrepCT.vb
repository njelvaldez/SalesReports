Imports System.Data.SqlClient
Imports Microsoft
Public Class MedRepCT
    Inherits System.Windows.Forms.Form
    Private RemoteDataSet As New CodeTablesDS
    Private RemoteDataSet2 As New MyDataSetDB
    Private varStatus As String

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblCreateDate As System.Windows.Forms.Label
    Friend WithEvents lblUpdateDate As System.Windows.Forms.Label
    Friend WithEvents txtRowid As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtMobileNo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtLastUser As System.Windows.Forms.TextBox
    Friend WithEvents TxtHireDate As System.Windows.Forms.TextBox
    Friend WithEvents TxtResignDate As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents SqlValue As System.Windows.Forms.ComboBox
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents txtCompanyCode As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ChkWcar As System.Windows.Forms.CheckBox
    Friend WithEvents TxtEnd_Date As System.Windows.Forms.TextBox
    Friend WithEvents TxtStart_Date As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtEmpNo As System.Windows.Forms.TextBox
    Friend WithEvents txtDimCode As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents btnPicturePath As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtPicturePath As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MedRepCT))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.lblCreateDate = New System.Windows.Forms.Label
        Me.lblUpdateDate = New System.Windows.Forms.Label
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.txtRowid = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtMobileNo = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtLastUser = New System.Windows.Forms.TextBox
        Me.TxtHireDate = New System.Windows.Forms.TextBox
        Me.TxtResignDate = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.SqlValue = New System.Windows.Forms.ComboBox
        Me.cboStatus = New System.Windows.Forms.ComboBox
        Me.txtCompanyCode = New System.Windows.Forms.TextBox
        Me.TxtEnd_Date = New System.Windows.Forms.TextBox
        Me.TxtStart_Date = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.ChkWcar = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtEmpNo = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtDimCode = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtAddress2 = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtAddress1 = New System.Windows.Forms.TextBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.btnPicturePath = New System.Windows.Forms.Button
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtPicturePath = New System.Windows.Forms.TextBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Code :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Create Date :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Update Date :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(109, 26)
        Me.txtCode.MaxLength = 10
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(480, 20)
        Me.txtCode.TabIndex = 1
        Me.txtCode.Tag = "Input"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(109, 61)
        Me.txtDescription.MaxLength = 100
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(480, 20)
        Me.txtDescription.TabIndex = 2
        Me.txtDescription.Tag = "Input"
        '
        'lblCreateDate
        '
        Me.lblCreateDate.BackColor = System.Drawing.SystemColors.Info
        Me.lblCreateDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCreateDate.Location = New System.Drawing.Point(104, 58)
        Me.lblCreateDate.Name = "lblCreateDate"
        Me.lblCreateDate.Size = New System.Drawing.Size(302, 20)
        Me.lblCreateDate.TabIndex = 15
        Me.lblCreateDate.Tag = "Input"
        '
        'lblUpdateDate
        '
        Me.lblUpdateDate.BackColor = System.Drawing.SystemColors.Info
        Me.lblUpdateDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUpdateDate.Location = New System.Drawing.Point(105, 93)
        Me.lblUpdateDate.Name = "lblUpdateDate"
        Me.lblUpdateDate.Size = New System.Drawing.Size(302, 20)
        Me.lblUpdateDate.TabIndex = 16
        Me.lblUpdateDate.Tag = "Input"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(1214, 573)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(86, 34)
        Me.cmdCancel.TabIndex = 17
        Me.cmdCancel.Tag = "Cancel"
        Me.cmdCancel.Text = "&Cancel"
        '
        'cmdSave
        '
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSave.Location = New System.Drawing.Point(1124, 573)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(86, 34)
        Me.cmdSave.TabIndex = 18
        Me.cmdSave.Tag = "Save"
        Me.cmdSave.Text = "   &Save"
        '
        'txtRowid
        '
        Me.txtRowid.Location = New System.Drawing.Point(18, 546)
        Me.txtRowid.Name = "txtRowid"
        Me.txtRowid.Size = New System.Drawing.Size(16, 20)
        Me.txtRowid.TabIndex = 43
        Me.txtRowid.Tag = "Input"
        Me.txtRowid.Visible = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 20)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Hire Date :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 20)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Resign Date :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(111, 26)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(302, 20)
        Me.txtEmail.TabIndex = 11
        Me.txtEmail.Tag = "Input"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 20)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Email :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 20)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "MobileNo :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMobileNo
        '
        Me.txtMobileNo.Location = New System.Drawing.Point(111, 67)
        Me.txtMobileNo.MaxLength = 50
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(302, 20)
        Me.txtMobileNo.TabIndex = 12
        Me.txtMobileNo.Tag = "Input"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(9, 545)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 20)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Status"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label9.Visible = False
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 20)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Company :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtLastUser
        '
        Me.TxtLastUser.Location = New System.Drawing.Point(42, 547)
        Me.TxtLastUser.Name = "TxtLastUser"
        Me.TxtLastUser.Size = New System.Drawing.Size(48, 20)
        Me.TxtLastUser.TabIndex = 61
        Me.TxtLastUser.Tag = "Input"
        Me.TxtLastUser.Visible = False
        '
        'TxtHireDate
        '
        Me.TxtHireDate.Location = New System.Drawing.Point(108, 27)
        Me.TxtHireDate.MaxLength = 10
        Me.TxtHireDate.Name = "TxtHireDate"
        Me.TxtHireDate.Size = New System.Drawing.Size(302, 20)
        Me.TxtHireDate.TabIndex = 7
        Me.TxtHireDate.Tag = "Input"
        '
        'TxtResignDate
        '
        Me.TxtResignDate.Location = New System.Drawing.Point(108, 58)
        Me.TxtResignDate.MaxLength = 10
        Me.TxtResignDate.Name = "TxtResignDate"
        Me.TxtResignDate.Size = New System.Drawing.Size(302, 20)
        Me.TxtResignDate.TabIndex = 8
        Me.TxtResignDate.Tag = "Input"
        '
        'Label12
        '
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(80, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(184, 14)
        Me.Label12.TabIndex = 63
        Me.Label12.Text = "ex.  ""112595"" = ""Nov.25,1995"""
        '
        'Label13
        '
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(80, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(192, 14)
        Me.Label13.TabIndex = 62
        Me.Label13.Text = "Easy Date Format Entry: ""MMDDYY"""
        '
        'SqlValue
        '
        Me.SqlValue.Location = New System.Drawing.Point(16, 515)
        Me.SqlValue.Name = "SqlValue"
        Me.SqlValue.Size = New System.Drawing.Size(146, 21)
        Me.SqlValue.TabIndex = 65
        Me.SqlValue.Visible = False
        '
        'cboStatus
        '
        Me.cboStatus.Items.AddRange(New Object() {"", "ACTIVE", "INACTIVE"})
        Me.cboStatus.Location = New System.Drawing.Point(172, 514)
        Me.cboStatus.MaxLength = 10
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(184, 21)
        Me.cboStatus.TabIndex = 7
        Me.cboStatus.Tag = "Input"
        Me.cboStatus.Visible = False
        '
        'txtCompanyCode
        '
        Me.txtCompanyCode.BackColor = System.Drawing.SystemColors.Info
        Me.txtCompanyCode.Location = New System.Drawing.Point(104, 27)
        Me.txtCompanyCode.MaxLength = 4
        Me.txtCompanyCode.Name = "txtCompanyCode"
        Me.txtCompanyCode.ReadOnly = True
        Me.txtCompanyCode.Size = New System.Drawing.Size(302, 20)
        Me.txtCompanyCode.TabIndex = 14
        Me.txtCompanyCode.Tag = "Input"
        '
        'TxtEnd_Date
        '
        Me.TxtEnd_Date.Location = New System.Drawing.Point(108, 126)
        Me.TxtEnd_Date.MaxLength = 10
        Me.TxtEnd_Date.Name = "TxtEnd_Date"
        Me.TxtEnd_Date.Size = New System.Drawing.Size(302, 20)
        Me.TxtEnd_Date.TabIndex = 10
        Me.TxtEnd_Date.Tag = "Input"
        '
        'TxtStart_Date
        '
        Me.TxtStart_Date.Location = New System.Drawing.Point(108, 92)
        Me.TxtStart_Date.MaxLength = 10
        Me.TxtStart_Date.Name = "TxtStart_Date"
        Me.TxtStart_Date.Size = New System.Drawing.Size(302, 20)
        Me.TxtStart_Date.TabIndex = 9
        Me.TxtStart_Date.Tag = "Input"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 123)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 20)
        Me.Label11.TabIndex = 71
        Me.Label11.Text = "End Date :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(8, 90)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 20)
        Me.Label15.TabIndex = 70
        Me.Label15.Text = "Starting Date :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ChkWcar
        '
        Me.ChkWcar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkWcar.Location = New System.Drawing.Point(9, 106)
        Me.ChkWcar.Name = "ChkWcar"
        Me.ChkWcar.Size = New System.Drawing.Size(112, 13)
        Me.ChkWcar.TabIndex = 13
        Me.ChkWcar.Text = "With Car :                      "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtEmpNo)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 277)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(613, 134)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Specialist"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(8, 105)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 20)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Employee No. :"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEmpNo
        '
        Me.txtEmpNo.Location = New System.Drawing.Point(109, 96)
        Me.txtEmpNo.MaxLength = 5
        Me.txtEmpNo.Name = "txtEmpNo"
        Me.txtEmpNo.Size = New System.Drawing.Size(480, 20)
        Me.txtEmpNo.TabIndex = 3
        Me.txtEmpNo.Tag = "Input"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(6, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 20)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Dimension Code :"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDimCode
        '
        Me.txtDimCode.Location = New System.Drawing.Point(111, 22)
        Me.txtDimCode.MaxLength = 100
        Me.txtDimCode.Name = "txtDimCode"
        Me.txtDimCode.ReadOnly = True
        Me.txtDimCode.Size = New System.Drawing.Size(479, 20)
        Me.txtDimCode.TabIndex = 4
        Me.txtDimCode.Tag = "Input"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtHireDate)
        Me.GroupBox2.Controls.Add(Me.TxtEnd_Date)
        Me.GroupBox2.Controls.Add(Me.TxtResignDate)
        Me.GroupBox2.Controls.Add(Me.TxtStart_Date)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(649, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(649, 162)
        Me.GroupBox2.TabIndex = 73
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Hire / Resign / Start/ End Date"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ChkWcar)
        Me.GroupBox3.Controls.Add(Me.txtEmail)
        Me.GroupBox3.Controls.Add(Me.txtMobileNo)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(649, 189)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(651, 141)
        Me.GroupBox3.TabIndex = 74
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Email / Mobile No. / Car"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtCompanyCode)
        Me.GroupBox4.Controls.Add(Me.lblCreateDate)
        Me.GroupBox4.Controls.Add(Me.lblUpdateDate)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Location = New System.Drawing.Point(649, 341)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(651, 141)
        Me.GroupBox4.TabIndex = 75
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Company / Create / Update Date"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(22, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 77
        Me.PictureBox1.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.PictureBox1)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Location = New System.Drawing.Point(649, 493)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(652, 69)
        Me.GroupBox5.TabIndex = 78
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Notification"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.Controls.Add(Me.txtAddress2)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.txtAddress1)
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Controls.Add(Me.txtDimCode)
        Me.GroupBox6.Location = New System.Drawing.Point(19, 427)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(613, 134)
        Me.GroupBox6.TabIndex = 79
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Dimension Code / Address 1 / Address 2"
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(7, 89)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 20)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "Address 2 :"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAddress2
        '
        Me.txtAddress2.Location = New System.Drawing.Point(111, 91)
        Me.txtAddress2.MaxLength = 50
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(479, 20)
        Me.txtAddress2.TabIndex = 6
        Me.txtAddress2.Tag = "Input"
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(7, 51)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(96, 20)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Address 1:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAddress1
        '
        Me.txtAddress1.Location = New System.Drawing.Point(111, 53)
        Me.txtAddress1.MaxLength = 50
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(479, 20)
        Me.txtAddress1.TabIndex = 5
        Me.txtAddress1.Tag = "Input"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.btnPicturePath)
        Me.GroupBox7.Controls.Add(Me.Label19)
        Me.GroupBox7.Controls.Add(Me.txtPicturePath)
        Me.GroupBox7.Controls.Add(Me.PictureBox2)
        Me.GroupBox7.Location = New System.Drawing.Point(19, 16)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(613, 245)
        Me.GroupBox7.TabIndex = 80
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Profile Picture"
        '
        'btnPicturePath
        '
        Me.btnPicturePath.Location = New System.Drawing.Point(544, 56)
        Me.btnPicturePath.Name = "btnPicturePath"
        Me.btnPicturePath.Size = New System.Drawing.Size(40, 23)
        Me.btnPicturePath.TabIndex = 100
        Me.btnPicturePath.Text = "..."
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(193, 24)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(157, 23)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Profile Picture Path :"
        '
        'txtPicturePath
        '
        Me.txtPicturePath.Location = New System.Drawing.Point(194, 56)
        Me.txtPicturePath.Name = "txtPicturePath"
        Me.txtPicturePath.ReadOnly = True
        Me.txtPicturePath.Size = New System.Drawing.Size(337, 20)
        Me.txtPicturePath.TabIndex = 99
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(19, 20)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(156, 207)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'MedRepCT
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1325, 616)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtRowid)
        Me.Controls.Add(Me.TxtLastUser)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.SqlValue)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MedRepCT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Specialist Entry"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        'txtCode.Enabled = True
        'txtCode.BackColor = Color.White
        'txtCode.ForeColor = Color.Black
        modControlBehavior.EnableControls(Me, False)
        ControlMaintenance.ClearInputControlsGroup(Me)
        cancelProcess = True
        Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If (MessageBox.Show("Are you sure you want to Save this Entry?", "Confirm Saving", _
              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)) _
              = DialogResult.Yes Then

            Dim Params(0) As String
            Params(0) = txtRowid.Text
            'added-DBrion  --v
            If Trim(txtCode.Text) = "" Or Trim(txtDescription.Text) = "" Then
                MessageBox.Show("Main fields are mandatory")
                Exit Sub
            End If
            'added-DBrion --^
            If PMR_EditMode = False Then
                Sub_Insert()
            Else
                Sub_Update()
            End If
            modControlBehavior.EnableControls(Me, False)
            cancelProcess = False
            Close()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Sub_Insert()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(18) As SqlParameter
            Dim MrCode As New SqlParameter("@MrCode", SqlDbType.VarChar, 10)
            MrCode.Direction = ParameterDirection.Input
            MrCode.Value = Trim(txtCode.Text)
            Params(0) = MrCode
            Dim MrName As New SqlParameter("@MrName", SqlDbType.VarChar, 100)
            MrName.Direction = ParameterDirection.Input
            MrName.Value = Trim(txtDescription.Text)
            Params(1) = MrName
            Dim Hire_Date As New SqlParameter("@Hire_Date", SqlDbType.DateTime, 10)
            Hire_Date.Direction = ParameterDirection.Input
            Hire_Date.Value = Trim(TxtHireDate.Text) '& GetDateTimeNow(" h:m:s tt")
            Params(2) = Hire_Date
            Dim Resign_Date As New SqlParameter("@Resign_Date", SqlDbType.DateTime, 10)
            Resign_Date.Direction = ParameterDirection.Input
            If Trim(TxtResignDate.Text) = "" Then
                Resign_Date.Value = DBNull.Value
            Else
                Resign_Date.Value = Trim(TxtResignDate.Text) '& GetDateTimeNow(" h:m:s tt")
            End If
            Params(3) = Resign_Date
            Dim CreateDate As New SqlParameter("@CreateDate", SqlDbType.DateTime, 10)
            CreateDate.Direction = ParameterDirection.Input
            CreateDate.Value = GetDateTimeNow()
            Params(4) = CreateDate
            Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime, 10)
            UpdateDate.Direction = ParameterDirection.Input
            UpdateDate.Value = GetDateTimeNow()
            Params(5) = UpdateDate
            Dim Email As New SqlParameter("@Email", SqlDbType.VarChar, 50)
            Email.Direction = ParameterDirection.Input
            Email.Value = Trim(txtEmail.Text)
            Params(6) = Email
            Dim MobileNo As New SqlParameter("@MobileNo", SqlDbType.VarChar, 50)
            MobileNo.Direction = ParameterDirection.Input
            MobileNo.Value = Trim(txtMobileNo.Text)
            Params(7) = MobileNo
            Dim CompanyCode As New SqlParameter("@CompanyCode", SqlDbType.VarChar, 50)
            CompanyCode.Direction = ParameterDirection.Input
            CompanyCode.Value = Trim(txtCompanyCode.Text)
            Params(8) = CompanyCode
            Dim Status As New SqlParameter("@Status", SqlDbType.VarChar, 10)
            Status.Direction = ParameterDirection.Input
            If (Month(CDate(Trim(TxtResignDate.Text))) > Month(CDate(GetDateTimeNow())) And _
               Year(CDate(Trim(TxtResignDate.Text))) > Year(CDate(GetDateTimeNow()))) Then
                varStatus = "ACTIVE"
            Else
                varStatus = "INACTIVE"
            End If
            Status.Value = varStatus
            Params(9) = Status
            Dim LastUser As New SqlParameter("@LastUser", SqlDbType.VarChar, 10)
            LastUser.Direction = ParameterDirection.Input
            LastUser.Value = IIf(Trim(gCurrUser) = "", "", gCurrUser)      ' Trim(TxtLastUser.Text)
            Params(10) = LastUser
            Dim Start_Date As New SqlParameter("@Start_Date", SqlDbType.DateTime, 10)
            Start_Date.Direction = ParameterDirection.Input
            Start_Date.Value = Trim(TxtStart_Date.Text) '& GetDateTimeNow(" h:m:s tt")
            Params(11) = Start_Date
            Dim End_Date As New SqlParameter("@End_Date", SqlDbType.DateTime, 10)
            End_Date.Direction = ParameterDirection.Input
            End_Date.Value = Trim(TxtEnd_Date.Text) '& GetDateTimeNow(" h:m:s tt")
            Params(12) = End_Date
            Dim wCar As New SqlParameter("@wCar", SqlDbType.Char, 1)
            wCar.Direction = ParameterDirection.Input
            If ChkWcar.Checked = True Then
                wCar.Value = "Y"
            Else
                wCar.Value = "N"
            End If
            Params(13) = wCar
            'EmpNo
            Dim Emp_No As New SqlParameter("@Emp_No", SqlDbType.VarChar, 10)
            Emp_No.Direction = ParameterDirection.Input
            Emp_No.Value = Trim(txtEmpNo.Text)
            Params(14) = Emp_No
            'Dimension code
            Dim DimCode As New SqlParameter("@DimCode", SqlDbType.VarChar, 8)
            DimCode.Direction = ParameterDirection.Input
            DimCode.Value = Trim(txtDimCode.Text)
            Params(15) = DimCode
            Dim Address1 As New SqlParameter("@Address1", SqlDbType.VarChar, 50)
            Address1.Direction = ParameterDirection.Input
            Address1.Value = Trim(txtAddress1.Text)
            Params(16) = Address1
            Dim Address2 As New SqlParameter("@Address2", SqlDbType.VarChar, 50)
            Address2.Direction = ParameterDirection.Input
            Address2.Value = Trim(txtAddress2.Text)
            Params(17) = Address2
            Dim PicturePath As New SqlParameter("@PicturePath", SqlDbType.VarChar, 150)
            PicturePath.Direction = ParameterDirection.Input
            PicturePath.Value = Trim(txtPicturePath.Text)
            Params(18) = PicturePath
            BusinessObject.Sub_Insert(ServerPath2, "MedRepCT_Insert", CommandType.StoredProcedure, Params)
            LogHelper.InsertLog("MedRepCT_Insert.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("MedRepCT_Insert.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Sub_Update()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(17) As SqlParameter
            Dim MrCode As New SqlParameter("@MrCode", SqlDbType.VarChar, 10)
            MrCode.Direction = ParameterDirection.Input
            MrCode.Value = Trim(txtCode.Text)
            Params(0) = MrCode
            Dim MrName As New SqlParameter("@MrName", SqlDbType.VarChar, 100)
            MrName.Direction = ParameterDirection.Input
            MrName.Value = Trim(txtDescription.Text)
            Params(1) = MrName
            Dim Hire_Date As New SqlParameter("@Hire_Date", SqlDbType.DateTime, 10)
            Hire_Date.Direction = ParameterDirection.Input
            Hire_Date.Value = Trim(TxtHireDate.Text) '& GetDateTimeNow(" h:m:s tt")
            Params(2) = Hire_Date
            Dim Resign_Date As New SqlParameter("@Resign_Date", SqlDbType.DateTime, 10)
            Resign_Date.Direction = ParameterDirection.Input
            If Trim(TxtResignDate.Text) = "" Then
                Resign_Date.Value = DBNull.Value
            Else
                Resign_Date.Value = Trim(TxtResignDate.Text) '& GetDateTimeNow(" h:m:s tt")
            End If
            Params(3) = Resign_Date

            Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime, 10)
            UpdateDate.Direction = ParameterDirection.Input
            UpdateDate.Value = GetDateTimeNow()
            Params(4) = UpdateDate
            Dim Email As New SqlParameter("@Email", SqlDbType.VarChar, 50)
            Email.Direction = ParameterDirection.Input
            Email.Value = Trim(txtEmail.Text)
            Params(5) = Email
            Dim MobileNo As New SqlParameter("@MobileNo", SqlDbType.VarChar, 50)
            MobileNo.Direction = ParameterDirection.Input
            MobileNo.Value = Trim(txtMobileNo.Text)
            Params(6) = MobileNo
            Dim CompanyCode As New SqlParameter("@CompanyCode", SqlDbType.VarChar, 50)
            CompanyCode.Direction = ParameterDirection.Input
            CompanyCode.Value = Trim(txtCompanyCode.Text)
            Params(7) = CompanyCode
            Dim Status As New SqlParameter("@Status", SqlDbType.VarChar, 10)
            Status.Direction = ParameterDirection.Input
            If (Month(CDate(Trim(TxtResignDate.Text))) > Month(CDate(GetDateTimeNow())) And _
               Year(CDate(Trim(TxtResignDate.Text))) > Year(CDate(GetDateTimeNow()))) Then
                varStatus = "ACTIVE"
            Else
                varStatus = "INACTIVE"
            End If
            Status.Value = varStatus
            Params(8) = Status
            Dim LastUser As New SqlParameter("@LastUser", SqlDbType.VarChar, 10)
            LastUser.Direction = ParameterDirection.Input
            LastUser.Value = IIf(Trim(gCurrUser) = "", "", gCurrUser)     ' Trim(TxtLastUser.Text)
            Params(9) = LastUser
            Dim Start_Date As New SqlParameter("@Start_Date", SqlDbType.DateTime, 10)
            Start_Date.Direction = ParameterDirection.Input
            Start_Date.Value = Trim(TxtStart_Date.Text) '& GetDateTimeNow(" h:m:s tt")
            Params(10) = Start_Date
            Dim End_Date As New SqlParameter("@End_Date", SqlDbType.DateTime, 10)
            End_Date.Direction = ParameterDirection.Input
            End_Date.Value = Trim(TxtEnd_Date.Text) '& GetDateTimeNow(" h:m:s tt")
            Params(11) = End_Date
            Dim wCar As New SqlParameter("@wCar", SqlDbType.Char, 1)
            wCar.Direction = ParameterDirection.Input
            If ChkWcar.Checked = True Then
                wCar.Value = "Y"
            Else
                wCar.Value = "N"
            End If
            Params(12) = wCar
            'EmpNo
            Dim Emp_No As New SqlParameter("@Emp_No", SqlDbType.VarChar, 10)
            Emp_No.Direction = ParameterDirection.Input
            Emp_No.Value = Trim(txtEmpNo.Text)
            Params(13) = Emp_No

            'Dimension code
            Dim DimCode As New SqlParameter("@DimCode", SqlDbType.VarChar, 8)
            DimCode.Direction = ParameterDirection.Input
            DimCode.Value = Trim(txtDimCode.Text)
            Params(14) = DimCode
            Dim Address1 As New SqlParameter("@Address1", SqlDbType.VarChar, 50)
            Address1.Direction = ParameterDirection.Input
            Address1.Value = Trim(txtAddress1.Text)
            Params(15) = Address1
            Dim Address2 As New SqlParameter("@Address2", SqlDbType.VarChar, 50)
            Address2.Direction = ParameterDirection.Input
            Address2.Value = Trim(txtAddress2.Text)
            Params(16) = Address2
            Dim PicturePath As New SqlParameter("@PicturePath", SqlDbType.VarChar, 150)
            PicturePath.Direction = ParameterDirection.Input
            PicturePath.Value = Trim(txtPicturePath.Text)
            Params(17) = PicturePath
            BusinessObject.Sub_Update(ServerPath2, "MedRepCT_Update", CommandType.StoredProcedure, Params)
            LogHelper.InsertLog("MedRepCT_Update.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("MedRepCT_Update.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub MedRepCT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        modControlBehavior.EnableControlsGroup(Me, True)
        Dim HD As String, RD As String, SD As String, ED As String
        If PMR_EditMode = True Then
            txtRowid.Text = Fld0
            txtCode.Text = Fld1
            txtDescription.Text = Fld2
            If (Fld3 Is DBNull.Value) Or (Fld3 Is Nothing) Then
                HD = ""
            Else
                HD = Format(CDate(Fld3), "MM/dd/yyyy")
            End If
            TxtHireDate.Text = HD
            If (Fld4 Is DBNull.Value) Or (Fld4 Is Nothing) Or (Fld4 = "") Then
                RD = ""
            Else
                RD = Format(CDate(Fld4), "MM/dd/yyyy")
            End If
            TxtResignDate.Text = RD
            lblCreateDate.Text = Fld5
            lblUpdateDate.Text = Fld6
            txtEmail.Text = Fld7
            txtMobileNo.Text = Fld8
            txtCompanyCode.Text = Fld9
            If UCase(Fld10) = "ACTIVE" Then
                cboStatus.SelectedIndex = 1
            ElseIf UCase(Fld10) = "INACTIVE" Then
                cboStatus.SelectedIndex = 2
            ElseIf Trim(Fld10) = "" Then
                cboStatus.SelectedIndex = 0
            End If
            TxtLastUser.Text = Fld11
            If (Fld12 Is DBNull.Value) Or (Fld12 Is Nothing) Then
                SD = ""
            Else
                SD = Format(CDate(Fld12), "MM/dd/yyyy")
            End If
            TxtStart_Date.Text = SD
            If (Fld13 Is DBNull.Value) Or (Fld13 Is Nothing) Or (Fld13 = "") Then
                ED = ""
            Else
                ED = Format(CDate(Fld13), "MM/dd/yyyy")
            End If
            TxtEnd_Date.Text = ED
            If Trim(Fld14) = "Y" Then
                ChkWcar.Checked = True
            Else
                ChkWcar.Checked = False
            End If
            txtEmpNo.Text = Fld15
            txtDimCode.Text = Fld18
            txtAddress1.Text = Fld19
            txtAddress2.Text = Fld20
            txtPicturePath.Text = TBMPicturePath
            If txtPicturePath.Text = "" Then
                txtPicturePath.Text = "\\Micdb\FIELDFORCE\BlankProfile.jpg"
            End If
            If txtDimCode.Text = "" Then
                DisplayDimCode()
            End If
        Else
            'When adding new specialist date should be "12/31/2078" by ARValdez 03/13/2014
            TxtResignDate.Text = "12/31/2078"
            TxtEnd_Date.Text = "12/31/2078"
        End If
    End Sub

    Private Sub txtCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCode.Validating
        Dim s As String
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter
        If Trim(txtCode.Text) = "" Then
            txtDescription.Select()
            Exit Sub
        End If
        If PMR_EditMode = False Then
            s = "select mrname as fld1 from NewScores..MedRep where rtrim(mrcode) = '" & Trim(txtCode.Text) & "' "
            Dim SQLstmnt As New SqlParameter("@SqlQry", SqlDbType.NVarChar, 2950)
            SQLstmnt.Direction = ParameterDirection.Input
            SQLstmnt.Value = s
            Params(0) = SQLstmnt
            Try
                BusinessObject.Sub_Show(ServerPath2, "GenericQryProc", CommandType.StoredProcedure, RemoteDataSet2, "GenericQryProc", Params)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            SqlValue.DataSource = RemoteDataSet2.GenericQryProc
            SqlValue.DisplayMember = "fld1"
            If Trim(SqlValue.Text) <> "" Then
                MessageBox.Show("This MedRep Code already exist! Please try again.", "MedRep Exsists!")
                e.Cancel = True
                txtCode.Clear()
            Else
                If Mid(Trim(txtCode.Text), 1, 1) = "H" Then
                    txtCompanyCode.Text = "HS"
                ElseIf Mid(Trim(txtCode.Text), 1, 1) = "X" Then
                    txtCompanyCode.Text = "QX"
                ElseIf Mid(Trim(txtCode.Text), 1, 1) = "Q" Then
                    txtCompanyCode.Text = "QPI"
                Else
                    txtCompanyCode.Text = "NMPC"
                End If
            End If
            SqlValue.ResetText()
            SqlValue.DataSource = Nothing
            RemoteDataSet2.GenericQryProc.Clear()
        Else
            If Trim(txtCompanyCode.Text) = "" Then
                If Mid(Trim(txtCode.Text), 1, 1) = "H" Then
                    txtCompanyCode.Text = "HS"
                ElseIf Mid(Trim(txtCode.Text), 1, 1) = "X" Then
                    txtCompanyCode.Text = "QX"
                ElseIf Mid(Trim(txtCode.Text), 1, 1) = "Q" Then
                    txtCompanyCode.Text = "QPI"
                Else
                    txtCompanyCode.Text = "NMPC"
                End If
            End If

        End If
    End Sub

    Private Sub txtDescription_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescription.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtDescription_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDescription.Validating
        Dim s As String
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter
        If Trim(txtDescription.Text) = "" Then
            txtCode.Select()
            Exit Sub
        End If
        'If Trim(txtDescription.Text) <> Trim(oldDs) Then
        '    s = "select mrcode as fld1 from NewScores..MedRep where rtrim(mrname) = '" & Trim(txtDescription.Text) & "' "
        '    Dim SQLstmnt As New SqlParameter("@SqlQry", SqlDbType.NVarChar, 2950)
        '    SQLstmnt.Direction = ParameterDirection.Input
        '    SQLstmnt.Value = s
        '    Params(0) = SQLstmnt
        '    Try
        '        BusinessObject.Sub_Show(ServerPath2, "GenericQryProc", CommandType.StoredProcedure, RemoteDataSet2, "GenericQryProc", Params)
        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try
        '    SqlValue.DataSource = RemoteDataSet2.GenericQryProc
        '    SqlValue.DisplayMember = "fld1"
        '    If Trim(SqlValue.Text) <> "" Then
        '        MessageBox.Show("This MedRep Name already exist! Please try again.", "MedRep Exsists!")
        '        e.Cancel = True
        '        txtDescription.Clear()
        '    End If
        '    SqlValue.ResetText()
        '    SqlValue.DataSource = Nothing
        '    RemoteDataSet2.GenericQryProc.Clear()
        'End If
    End Sub

    Private Sub TxtHireDate_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtHireDate.KeyUp
        If e.KeyValue = 13 Then      ' tests if the key pressed is the "enter key"
            SendKeys.Send("{TAB}")   ' sends the focus to the next control/tabstop
        End If
    End Sub

    Private Sub TxtHireDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtHireDate.Validating
        On Error GoTo errpt
        If Trim(TxtHireDate.Text) = "" Then       'entering w/o putting value
            MessageBox.Show("Hire date must not be null.")
            GoTo errpt
        End If
        TxtHireDate.Text = DatValid(TxtHireDate.Text)  'validating the entry. the textbox's value will be "mm/dd/yyyy" if the entry is invalid.
        If Trim(TxtHireDate.Text) = "mm/dd/yyyy" Then
            GoTo errpt
        Else
            If PMR_EditMode = False Then
                'TxtResignDate.Text = "12/31/" & Val(GetDateTimeNow("yyyy")) + 2
                TxtResignDate.Select()
            End If
            'If Trim(TxtResignDate.Text) <> "" Then
            '    If CDate(TxtHireDate.Text) > CDate(TxtResignDate.Text) Then
            '        MessageBox.Show("Hire date should not be later than resign date!")
            '        GoTo errpt
            '    Else
            '        tmpHD = Format(CDate(TxtHireDate.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
            '    End If
            'Else
            '    tmpHD = Format(CDate(TxtHireDate.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
            'End If
        End If
        Exit Sub
errpt:
        e.Cancel = True  'brings back the focus to TxtHireDate textbox. only in Validating event
    End Sub

    Private Sub TxtResignDate_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtResignDate.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TxtResignDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtResignDate.Validating
        On Error GoTo errpt
        If jTrim(TxtResignDate.Text) = "" Then
            Exit Sub
        End If
        TxtResignDate.Text = DatValid(TxtResignDate.Text)
        If Trim(TxtResignDate.Text) = "mm/dd/yyyy" Then
            GoTo errpt
        Else
            If Trim(TxtHireDate.Text) <> "" Then
                If CDate(TxtHireDate.Text) > CDate(TxtResignDate.Text) Then
                    MessageBox.Show("Hire date should NOT be later than resign date!")
                    GoTo errpt
                End If
            Else
                MessageBox.Show("There must be a Hire Date before you can enter a Resign Date.")
            End If
        End If
        Exit Sub
errpt:
        e.Cancel = True
    End Sub

    Private Sub TxtStart_Date_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtStart_Date.KeyUp
        If e.KeyValue = 13 Then      ' tests if the key pressed is the "enter key"
            SendKeys.Send("{TAB}")   ' sends the focus to the next control/tabstop
        End If
    End Sub

    Private Sub TxtStart_Date_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtStart_Date.Validating
        On Error GoTo errpt
        If Trim(TxtStart_Date.Text) = "" Then       'entering w/o putting value
            MessageBox.Show("Start date must not be null.")
            GoTo errpt
        End If
        TxtStart_Date.Text = DatValid(TxtStart_Date.Text)  'validating the entry. the textbox's value will be "mm/dd/yyyy" if the entry is invalid.
        If Trim(TxtStart_Date.Text) = "mm/dd/yyyy" Then
            GoTo errpt
        Else
            If PMR_EditMode = False Then
                'TxtEnd_Date.Text = "12/31/" & Val(GetDateTimeNow("yyyy")) + 2
                TxtEnd_Date.Select()
            End If
            'If Trim(TxtEnd_Date.Text) <> "" Then
            '    If CDate(TxtStart_Date.Text) > CDate(TxtEnd_Date.Text) Then
            '        MessageBox.Show("Hire date should not be later than resign date!")
            '        GoTo errpt
            '    Else
            '        tmpHD = Format(CDate(TxtStart_Date.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
            '    End If
            'Else
            '    tmpHD = Format(CDate(TxtStart_Date.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
            'End If
        End If
        Exit Sub
errpt:
        e.Cancel = True  'brings back the focus to TxtStart_Date textbox. only in Validating event
    End Sub

    Private Sub TxtEnd_Date_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtEnd_Date.KeyUp
        If e.KeyValue = 13 Then      ' tests if the key pressed is the "enter key"
            SendKeys.Send("{TAB}")   ' sends the focus to the next control/tabstop
        End If
    End Sub

    Private Sub TxtEnd_Date_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtEnd_Date.Validating
        On Error GoTo errpt
        If Trim(TxtEnd_Date.Text) = "" Then       'entering w/o putting value
            MessageBox.Show("End date must not be null.")
            GoTo errpt
        End If
        TxtEnd_Date.Text = DatValid(TxtEnd_Date.Text)  'validating the entry. the textbox's value will be "mm/dd/yyyy" if the entry is invalid.
        If Trim(TxtEnd_Date.Text) = "mm/dd/yyyy" Then
            GoTo errpt
            'Else
            '    If PMR_EditMode = False Then
            '        TxtEnd_Date.Text = "12/31/" & Val(GetDateTimeNow("yyyy")) + 2
            '        TxtEnd_Date.Select()
            '    End If
            '    'If Trim(TxtEnd_Date.Text) <> "" Then
            '    '    If CDate(TxtEnd_Date.Text) > CDate(TxtEnd_Date.Text) Then
            '    '        MessageBox.Show("Hire date should not be later than resign date!")
            '    '        GoTo errpt
            '    '    Else
            '    '        tmpHD = Format(CDate(TxtEnd_Date.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
            '    '    End If
            '    'Else
            '    '    tmpHD = Format(CDate(TxtEnd_Date.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
            '    'End If
        End If
        Exit Sub
errpt:
        e.Cancel = True  'brings back the focus to TxtEnd_Date textbox. only in Validating event
    End Sub

    Private Sub txtEmail_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmail.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
            txtEmail.Text = Mid(txtEmail.Text, 1, Len(Trim(txtEmail.Text)))
        End If
    End Sub

    Private Sub txtEmail_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEmail.Validating
        If Trim(txtEmail.Text) = "" Then
            Exit Sub
        End If
        If InStr(1, Trim(txtEmail.Text), "@") = 0 Or InStr(1, Trim(txtEmail.Text), ".") = 0 Then
            MessageBox.Show("Invalid email address!")
            e.Cancel = True
            txtEmail.SelectAll()
        End If
    End Sub

    Private Sub txtMobileNo_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMobileNo.KeyUp
        Dim aChr As String
        If Len(Trim(txtMobileNo.Text)) = 1 Then
            aChr = Trim(txtMobileNo.Text)
        ElseIf Len(Trim(txtMobileNo.Text)) > 1 Then
            aChr = Mid(Trim(txtMobileNo.Text), Len(Trim(txtMobileNo.Text)) - 1, 1)
        ElseIf Len(Trim(txtMobileNo.Text)) = 0 Then
            Exit Sub
        End If
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
        If NumKeys(aChr, e.KeyData, "INT") = False Then
            If Len(Trim(txtMobileNo.Text)) <> 0 Then
                txtMobileNo.Text = Mid(Trim(txtMobileNo.Text), 1, Len(Trim(txtMobileNo.Text)) - 1)
                txtMobileNo.SelectionStart = Len(Trim(txtMobileNo.Text))
                Beep()
            Else
                txtMobileNo.Text = ""
            End If
        End If
    End Sub

    Private Sub cboStatus_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboStatus.KeyUp
        'If e.KeyData.ToString = System.Windows.Forms.Keys.Up.ToString _
        '   Or e.KeyData.ToString = System.Windows.Forms.Keys.Left.ToString Then 'if key pressed is the up arrow it will select the next selection before the selction
        '    cboStatus.SelectedItem = cboStatus.SelectedIndex - 1
        'ElseIf e.KeyData.ToString = System.Windows.Forms.Keys.Down.ToString _
        '   Or e.KeyData.ToString = System.Windows.Forms.Keys.Right.ToString Then 'if key pressed is the up arrow it will select the next selection after the selction
        '    cboStatus.SelectedItem = cboStatus.SelectedIndex + 1
        'ElseIf DKcodes(e.KeyData) = True Then    'checking if the key pressed is alphanumeric (to disallow typing the entry)
        '    cboStatus.Text = ""     'if alphanumeric then the value of the field will be erased
        'End If
        'If e.KeyValue = 13 Then
        '    SendKeys.Send("{TAB}")      'moves control to the next control or field
        'End If
    End Sub

    Private Sub cboStatus_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboStatus.Validating
        'If Trim(cboStatus.Text) = "" Then    'tests if entry is blank
        '    MessageBox.Show("Mandatory field!", "Critical!")  'gives message to put value
        '    e.Cancel() = True                'bringing back the focus to this field
        'Else
        '    If PMR_EditMode = True Then
        '        If Trim(cboStatus.Text) = "INACTIVE" Then
        '            TxtResignDate.Text = GetDateTimeNow("MM/dd/yyyy")
        '        ElseIf Trim(cboStatus.Text) = "ACTIVE" Then
        '            TxtResignDate.Text = ""
        '        End If
        '    End If
        'End If
    End Sub

    Private Sub txtEmpNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmpNo.TextChanged
        DisplayDimCode()
    End Sub
    Private Sub DisplayDimCode()
        'Empty Employee No
        If txtEmpNo.Text = "" Or txtDescription.Text.ToUpper.Contains("VACANT") Then
            txtDimCode.Text = "TV-" + txtCode.Text.Trim()
        Else
            txtDimCode.Text = "EE-" + txtEmpNo.Text.Trim()
        End If
    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click

    End Sub

    Private Sub btnPicturePath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPicturePath.Click
        Dim File As String
        OpenFileDialog1.Filter = "Picture files (*.jpg)|*.jpg;*.png"
        OpenFileDialog1.InitialDirectory = "\\Micdb\FIELDFORCE\TBM PICS"
        OpenFileDialog1.ShowDialog(Me)
        txtPicturePath.Text = OpenFileDialog1.FileName
        File = VisualBasic.Mid(OpenFileDialog1.FileName, OpenFileDialog1.FileName.LastIndexOf("\") + 2)
    End Sub

    Private Sub txtPicturePath_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPicturePath.TextChanged
        Try
            If txtPicturePath.Text <> "" Then
                PictureBox2.Image = Image.FromFile(txtPicturePath.Text)
                PictureBox2.Refresh()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub TxtResignDate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtResignDate.TextChanged

    End Sub
End Class