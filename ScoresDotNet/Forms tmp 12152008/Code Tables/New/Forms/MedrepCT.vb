Imports System.Data.SqlClient
Imports Microsoft
Public Class MedRepCT
    Inherits System.Windows.Forms.Form
    Private RemoteDataSet As New CodeTablesDS
    Private RemoteDataSet2 As New MyDataSetDB
    Private EditMode As Boolean = False
    Private oldDs As String, tmpSD As String, tmpED As String  '<-- added-DBrion
    Private tmpHD As String, tmpRD As String                   '<-- added-DBrion

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Sub_Show()
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
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
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
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents SqlValue As System.Windows.Forms.ComboBox
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents dgRowid As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgMRcode As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgMRname As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgHire_Date As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgResign_Date As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgCreateDate As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgUpdateDate As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgEmail As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgMobileno As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgCompanyCode As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgStatus As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgLastUser As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents txtCompanyCode As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.lblCreateDate = New System.Windows.Forms.Label
        Me.lblUpdateDate = New System.Windows.Forms.Label
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.dgRowid = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgMRcode = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgMRname = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgHire_Date = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgResign_Date = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgCreateDate = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgUpdateDate = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgEmail = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgMobileno = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgCompanyCode = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgStatus = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgLastUser = New System.Windows.Forms.DataGridTextBoxColumn
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
        Me.Label14 = New System.Windows.Forms.Label
        Me.SqlValue = New System.Windows.Forms.ComboBox
        Me.cboStatus = New System.Windows.Forms.ComboBox
        Me.txtCompanyCode = New System.Windows.Forms.TextBox
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Code"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Create Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 247)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Update Date"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCode
        '
        Me.txtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Location = New System.Drawing.Point(88, 11)
        Me.txtCode.MaxLength = 10
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(184, 20)
        Me.txtCode.TabIndex = 1
        Me.txtCode.Tag = "Input"
        Me.txtCode.Text = ""
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(88, 37)
        Me.txtDescription.MaxLength = 100
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(184, 20)
        Me.txtDescription.TabIndex = 2
        Me.txtDescription.Tag = "Input"
        Me.txtDescription.Text = ""
        '
        'lblCreateDate
        '
        Me.lblCreateDate.BackColor = System.Drawing.SystemColors.Info
        Me.lblCreateDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCreateDate.Location = New System.Drawing.Point(88, 221)
        Me.lblCreateDate.Name = "lblCreateDate"
        Me.lblCreateDate.Size = New System.Drawing.Size(184, 20)
        Me.lblCreateDate.TabIndex = 6
        Me.lblCreateDate.Tag = "Input"
        '
        'lblUpdateDate
        '
        Me.lblUpdateDate.BackColor = System.Drawing.SystemColors.Info
        Me.lblUpdateDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUpdateDate.Location = New System.Drawing.Point(88, 247)
        Me.lblUpdateDate.Name = "lblUpdateDate"
        Me.lblUpdateDate.Size = New System.Drawing.Size(184, 20)
        Me.lblUpdateDate.TabIndex = 7
        Me.lblUpdateDate.Tag = "Input"
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(208, 279)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(64, 23)
        Me.cmdExit.TabIndex = 11
        Me.cmdExit.Tag = "Exit"
        Me.cmdExit.Text = "Exit"
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(16, 279)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(64, 23)
        Me.cmdAdd.TabIndex = 8
        Me.cmdAdd.Tag = "Add"
        Me.cmdAdd.Text = "Add"
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(80, 279)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(64, 23)
        Me.cmdEdit.TabIndex = 9
        Me.cmdEdit.Tag = "Edit"
        Me.cmdEdit.Text = "Edit"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(80, 279)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(64, 23)
        Me.cmdCancel.TabIndex = 12
        Me.cmdCancel.Tag = "Cancel"
        Me.cmdCancel.Text = "Cancel"
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(144, 279)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(64, 23)
        Me.cmdDelete.TabIndex = 10
        Me.cmdDelete.Tag = "Delete"
        Me.cmdDelete.Text = "Delete"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(144, 279)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(64, 23)
        Me.cmdSave.TabIndex = 13
        Me.cmdSave.Tag = "Save"
        Me.cmdSave.Text = "Save"
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(280, 10)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(584, 327)
        Me.DataGrid1.TabIndex = 0
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.DataGrid1.Tag = "View"
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Aqua
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightCyan
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.dgRowid, Me.dgMRcode, Me.dgMRname, Me.dgHire_Date, Me.dgResign_Date, Me.dgCreateDate, Me.dgUpdateDate, Me.dgEmail, Me.dgMobileno, Me.dgCompanyCode, Me.dgStatus, Me.dgLastUser})
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.AntiqueWhite
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "MedRepCT_Show"
        Me.DataGridTableStyle1.ReadOnly = True
        '
        'dgRowid
        '
        Me.dgRowid.Format = ""
        Me.dgRowid.FormatInfo = Nothing
        Me.dgRowid.MappingName = "Rowid"
        Me.dgRowid.NullText = ""
        Me.dgRowid.Width = 0
        '
        'dgMRcode
        '
        Me.dgMRcode.Format = ""
        Me.dgMRcode.FormatInfo = Nothing
        Me.dgMRcode.HeaderText = "Code"
        Me.dgMRcode.MappingName = "mrcode"
        Me.dgMRcode.NullText = ""
        Me.dgMRcode.ReadOnly = True
        Me.dgMRcode.Width = 45
        '
        'dgMRname
        '
        Me.dgMRname.Format = ""
        Me.dgMRname.FormatInfo = Nothing
        Me.dgMRname.HeaderText = "Name"
        Me.dgMRname.MappingName = "mrname"
        Me.dgMRname.NullText = ""
        Me.dgMRname.ReadOnly = True
        Me.dgMRname.Width = 150
        '
        'dgHire_Date
        '
        Me.dgHire_Date.Format = "MM/dd/yyyy"
        Me.dgHire_Date.FormatInfo = Nothing
        Me.dgHire_Date.HeaderText = "Hire Date"
        Me.dgHire_Date.MappingName = "hire_date"
        Me.dgHire_Date.NullText = ""
        Me.dgHire_Date.Width = 75
        '
        'dgResign_Date
        '
        Me.dgResign_Date.Format = "MM/dd/yyyy"
        Me.dgResign_Date.FormatInfo = Nothing
        Me.dgResign_Date.HeaderText = "Resign Date"
        Me.dgResign_Date.MappingName = "resign_date"
        Me.dgResign_Date.NullText = ""
        Me.dgResign_Date.Width = 75
        '
        'dgCreateDate
        '
        Me.dgCreateDate.Format = "MM/dd/yyyy"
        Me.dgCreateDate.FormatInfo = Nothing
        Me.dgCreateDate.HeaderText = "Create Date"
        Me.dgCreateDate.MappingName = "createdate"
        Me.dgCreateDate.NullText = ""
        Me.dgCreateDate.Width = 75
        '
        'dgUpdateDate
        '
        Me.dgUpdateDate.Format = "MM/dd/yyyy"
        Me.dgUpdateDate.FormatInfo = Nothing
        Me.dgUpdateDate.HeaderText = "Update Date"
        Me.dgUpdateDate.MappingName = "updatedate"
        Me.dgUpdateDate.NullText = ""
        Me.dgUpdateDate.Width = 75
        '
        'dgEmail
        '
        Me.dgEmail.Format = ""
        Me.dgEmail.FormatInfo = Nothing
        Me.dgEmail.HeaderText = "Email"
        Me.dgEmail.MappingName = "email"
        Me.dgEmail.NullText = ""
        Me.dgEmail.Width = 90
        '
        'dgMobileno
        '
        Me.dgMobileno.Format = ""
        Me.dgMobileno.FormatInfo = Nothing
        Me.dgMobileno.HeaderText = "Mobile no."
        Me.dgMobileno.MappingName = "mobileno"
        Me.dgMobileno.NullText = ""
        Me.dgMobileno.Width = 80
        '
        'dgCompanyCode
        '
        Me.dgCompanyCode.Format = ""
        Me.dgCompanyCode.FormatInfo = Nothing
        Me.dgCompanyCode.HeaderText = "Company"
        Me.dgCompanyCode.MappingName = "companycode"
        Me.dgCompanyCode.NullText = ""
        Me.dgCompanyCode.Width = 65
        '
        'dgStatus
        '
        Me.dgStatus.Format = ""
        Me.dgStatus.FormatInfo = Nothing
        Me.dgStatus.HeaderText = "Status"
        Me.dgStatus.MappingName = "Status"
        Me.dgStatus.NullText = ""
        Me.dgStatus.Width = 75
        '
        'dgLastUser
        '
        Me.dgLastUser.Format = ""
        Me.dgLastUser.FormatInfo = Nothing
        Me.dgLastUser.HeaderText = "Encoder"
        Me.dgLastUser.MappingName = "lastuser"
        Me.dgLastUser.NullText = ""
        Me.dgLastUser.Width = 80
        '
        'txtRowid
        '
        Me.txtRowid.Location = New System.Drawing.Point(8, 311)
        Me.txtRowid.Name = "txtRowid"
        Me.txtRowid.Size = New System.Drawing.Size(16, 20)
        Me.txtRowid.TabIndex = 43
        Me.txtRowid.Tag = "Input"
        Me.txtRowid.Text = ""
        Me.txtRowid.Visible = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Hire Date"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 20)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Resign Date"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(88, 115)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(184, 20)
        Me.txtEmail.TabIndex = 5
        Me.txtEmail.Tag = "Input"
        Me.txtEmail.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 20)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Email"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 142)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 20)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "MobileNo"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMobileNo
        '
        Me.txtMobileNo.Location = New System.Drawing.Point(88, 142)
        Me.txtMobileNo.MaxLength = 50
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(184, 20)
        Me.txtMobileNo.TabIndex = 6
        Me.txtMobileNo.Tag = "Input"
        Me.txtMobileNo.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 169)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 20)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Status"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 194)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 20)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Company"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtLastUser
        '
        Me.TxtLastUser.Location = New System.Drawing.Point(32, 311)
        Me.TxtLastUser.Name = "TxtLastUser"
        Me.TxtLastUser.Size = New System.Drawing.Size(48, 20)
        Me.TxtLastUser.TabIndex = 61
        Me.TxtLastUser.Tag = "Input"
        Me.TxtLastUser.Text = ""
        Me.TxtLastUser.Visible = False
        '
        'TxtHireDate
        '
        Me.TxtHireDate.Location = New System.Drawing.Point(88, 63)
        Me.TxtHireDate.MaxLength = 10
        Me.TxtHireDate.Name = "TxtHireDate"
        Me.TxtHireDate.Size = New System.Drawing.Size(184, 20)
        Me.TxtHireDate.TabIndex = 3
        Me.TxtHireDate.Tag = "Input"
        Me.TxtHireDate.Text = ""
        '
        'TxtResignDate
        '
        Me.TxtResignDate.Location = New System.Drawing.Point(88, 89)
        Me.TxtResignDate.MaxLength = 10
        Me.TxtResignDate.Name = "TxtResignDate"
        Me.TxtResignDate.Size = New System.Drawing.Size(184, 20)
        Me.TxtResignDate.TabIndex = 4
        Me.TxtResignDate.Tag = "Input"
        Me.TxtResignDate.Text = ""
        '
        'Label12
        '
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(88, 323)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(184, 14)
        Me.Label12.TabIndex = 63
        Me.Label12.Text = "ex.  ""112595"" = ""Nov.25,1995"""
        '
        'Label13
        '
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(88, 307)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(192, 14)
        Me.Label13.TabIndex = 62
        Me.Label13.Text = "Easy Date Format Entry: ""MMDDYY"""
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Location = New System.Drawing.Point(8, 272)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(264, 2)
        Me.Label14.TabIndex = 64
        '
        'SqlValue
        '
        Me.SqlValue.Location = New System.Drawing.Point(362, 144)
        Me.SqlValue.Name = "SqlValue"
        Me.SqlValue.Size = New System.Drawing.Size(146, 21)
        Me.SqlValue.TabIndex = 65
        Me.SqlValue.Visible = False
        '
        'cboStatus
        '
        Me.cboStatus.Items.AddRange(New Object() {"", "ACTIVE", "INACTIVE"})
        Me.cboStatus.Location = New System.Drawing.Point(88, 168)
        Me.cboStatus.MaxLength = 10
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(184, 21)
        Me.cboStatus.TabIndex = 7
        Me.cboStatus.Tag = "Input"
        '
        'txtCompanyCode
        '
        Me.txtCompanyCode.BackColor = System.Drawing.SystemColors.Info
        Me.txtCompanyCode.Location = New System.Drawing.Point(88, 195)
        Me.txtCompanyCode.MaxLength = 4
        Me.txtCompanyCode.Name = "txtCompanyCode"
        Me.txtCompanyCode.ReadOnly = True
        Me.txtCompanyCode.Size = New System.Drawing.Size(184, 20)
        Me.txtCompanyCode.TabIndex = 67
        Me.txtCompanyCode.Tag = "Input"
        Me.txtCompanyCode.Text = ""
        '
        'MedRepCT
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(870, 343)
        Me.Controls.Add(Me.txtCompanyCode)
        Me.Controls.Add(Me.TxtResignDate)
        Me.Controls.Add(Me.TxtHireDate)
        Me.Controls.Add(Me.txtMobileNo)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.txtRowid)
        Me.Controls.Add(Me.TxtLastUser)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.SqlValue)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.lblUpdateDate)
        Me.Controls.Add(Me.lblCreateDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MedRepCT"
        Me.Text = "MedRep List"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        modControlBehavior.EnableControls(Me, True)
        ControlMaintenance.ClearInputControls(Me)
        EditMode = False
        'added-DBrion --v
        btnSw = True
        lblCreateDate.Text = GetDateTimeNow("MM/dd/yyyy")
        lblUpdateDate.Text = GetDateTimeNow("MM/dd/yyyy")
        TxtHireDate.Text = GetDateTimeNow("MM/dd/yyyy")
        tmpHD = Format(CDate(TxtHireDate.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
        txtCode.Enabled = True
        txtCode.Select()
        'added-DBrion --^
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If txtCode.Text = "" And txtDescription.Text = "" Then
            MessageBox.Show("Please select a record to modify!", "Record Selection", MessageBoxButtons.OK, _
            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            modControlBehavior.EnableControls(Me, True)
            EditMode = True
            'added-DBrion --v
            btnSw = True
            lblUpdateDate.Text = GetDateTimeNow("MM/dd/yyyy")
            txtCode.Enabled = False
            txtCode.BackColor = BackColor.White
            txtCode.ForeColor = BackColor.Black
            txtDescription.Select()
            txtDescription.SelectAll()
            'added-DBrion --^
        End If
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If txtRowid.Text > "" Then
            If (MessageBox.Show("Do you really want to delete this record?", _
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information, _
                MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then

                Sub_Delete()
                ControlMaintenance.ClearInputControls(Me)
                DataGrid1.DataSource = Nothing  '<--DBrion    to remove any text left by the
                Sub_Show()                      '<--DBrion    deleted record
            End If
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        'added-DBrion --v
        btnSw = False
        txtCode.Enabled = True
        txtCode.BackColor = Color.White
        txtCode.ForeColor = Color.Black
        'added-DBrion --^
        modControlBehavior.EnableControls(Me, False)
        ControlMaintenance.ClearInputControls(Me)
        EditMode = False
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
            If EditMode = False Then
                Sub_Insert()
            Else
                Sub_Update()
            End If
            DataGrid1.DataSource = Nothing    'added-DBrion --v     to refresh and enable again 
            Sub_Show()                        'added-DBrion --^     the scrollbar
            Sub_Select(Params, CStr(IIf(EditMode = False, "Insert", "Update")))
            EditMode = False
            modControlBehavior.EnableControls(Me, False)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Sub_Insert()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(10) As SqlParameter
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
        Dim CompanyCode As New SqlParameter("@CompanyCode", SqlDbType.VarChar, 4)
        CompanyCode.Direction = ParameterDirection.Input
        CompanyCode.Value = Trim(txtCompanyCode.Text)
        Params(8) = CompanyCode
        Dim Status As New SqlParameter("@Status", SqlDbType.VarChar, 10)
        Status.Direction = ParameterDirection.Input
        Status.Value = Trim(cboStatus.Text)
        Params(9) = Status
        Dim LastUser As New SqlParameter("@LastUser", SqlDbType.VarChar, 10)
        LastUser.Direction = ParameterDirection.Input
        LastUser.Value = IIf(Trim(gCurrUser) = "", "", gCurrUser)      ' Trim(TxtLastUser.Text)
        Params(10) = LastUser
        Try
            BusinessObject.Sub_Insert(ServerPath2, "MedRepCT_Insert", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Sub_Update()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(9) As SqlParameter
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
        Dim CompanyCode As New SqlParameter("@CompanyCode", SqlDbType.VarChar, 4)
        CompanyCode.Direction = ParameterDirection.Input
        CompanyCode.Value = Trim(txtCompanyCode.Text)
        Params(7) = CompanyCode
        Dim Status As New SqlParameter("@Status", SqlDbType.VarChar, 10)
        Status.Direction = ParameterDirection.Input
        Status.Value = Trim(cboStatus.Text)
        Params(8) = Status
        Dim LastUser As New SqlParameter("@LastUser", SqlDbType.VarChar, 10)
        LastUser.Direction = ParameterDirection.Input
        LastUser.Value = IIf(Trim(gCurrUser) = "", "", gCurrUser)     ' Trim(TxtLastUser.Text)
        Params(9) = LastUser
        Try
            BusinessObject.Sub_Update(ServerPath2, "MedRepCT_Update", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Sub_Show()
        If RemoteDataSet.MedRepCT_Show.Count > 0 Then RemoteDataSet.MedRepCT_Show.Clear()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Try
            BusinessObject.Sub_Show(ServerPath2, "MedRepCT_Show", CommandType.StoredProcedure, RemoteDataSet, "MedRepCT_Show")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        DataGrid1.DataSource = RemoteDataSet.MedRepCT_Show
    End Sub

    Private Sub Sub_Select(ByVal dbParams() As String, ByVal UpdateMode As String)
        'select case if add,edit or delete
        Dim i As Integer
        Dim myRowid As Integer
        Select Case UpdateMode
            Case "Insert"
                Dim BusinessObject As New BusinessLayer.clsFileMaintenance
                myRowid = CInt(BusinessObject.Sub_ReturnIntegerResult(ServerPath2, "MedRepCT_GetInsertedRowid", CommandType.StoredProcedure))
            Case "Update"
                myRowid = CInt(dbParams(0))
        End Select
        For i = 0 To (RemoteDataSet.MedRepCT_Show.Rows.Count - 1)
            With DataGrid1
                If myRowid = CInt(.Item(i, 0)) Then
                    .CurrentCell = New DataGridCell(i, 0)
                    Dim e As System.EventArgs
                    DataGrid1_Click(Me, e)
                    Exit For
                End If
            End With
        Next
    End Sub

    Private Sub Sub_Delete()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter
        Dim MRcode As New SqlParameter("@MRcode", SqlDbType.VarChar, 10)  '<v--changed from Rowid to NSMcode
        MRcode.Direction = ParameterDirection.Input
        MRcode.Value = txtCode.Text
        Params(0) = MRcode                                         '<^--changed from Rowid to NSMcode
        BusinessObject.Sub_Delete(ServerPath2, "MedRepCT_Delete", CommandType.StoredProcedure, Params)
    End Sub

    Private Sub MedRepCT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        modControlBehavior.EnableControls(Me, False)
        btnSw = False    '<-- added-DBrion
        tmpSD = ""
        tmpED = ""
        tmpHD = ""
        tmpRD = ""
    End Sub

    Private Sub DataGrid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.Click, DataGrid1.CurrentCellChanged
        With DataGrid1
            txtRowid.Text = .Item(.CurrentCell.RowNumber, 0).ToString       '<v--added to ".ToString"
            txtCode.Text = .Item(.CurrentCell.RowNumber, 1).ToString
            txtDescription.Text = .Item(.CurrentCell.RowNumber, 2).ToString
            oldDs = Trim(txtDescription.Text)
            If Trim(.Item(.CurrentCell.RowNumber, 3).ToString) <> "" Then
                TxtHireDate.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 3).ToString), "MM/dd/yyyy")
            Else
                TxtHireDate.Text = ""
            End If
            If Trim(.Item(.CurrentCell.RowNumber, 4).ToString) <> "" Then
                TxtResignDate.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 4).ToString), "MM/dd/yyyy")
            Else
                TxtResignDate.Text = ""
            End If
            If Trim(.Item(.CurrentCell.RowNumber, 5).ToString) <> "" Then
                lblCreateDate.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 5).ToString), "MM/dd/yyyy")
            Else
                lblCreateDate.Text = ""
            End If
            If Trim(.Item(.CurrentCell.RowNumber, 6).ToString) <> "" Then
                lblUpdateDate.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 6).ToString), "MM/dd/yyyy")
            Else
                lblUpdateDate.Text = ""
            End If
            txtEmail.Text = .Item(.CurrentCell.RowNumber, 7).ToString
            txtMobileNo.Text = .Item(.CurrentCell.RowNumber, 8).ToString
            txtCompanyCode.Text = .Item(.CurrentCell.RowNumber, 9).ToString
            cboStatus.Text = .Item(.CurrentCell.RowNumber, 10).ToString
            TxtLastUser.Text = .Item(.CurrentCell.RowNumber, 11).ToString
            .Select(.CurrentCell.RowNumber)
        End With
    End Sub
    'added-DBrion --v
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
        If btnSw = True And EditMode = False Then
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
        'If btnSw = True And Trim(txtDescription.Text) <> Trim(oldDs) Then
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
            TxtResignDate.Text = "12/31/" & Val(GetDateTimeNow("yyyy")) + 2
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
                    MessageBox.Show("Hire date should not be later than resign date!")
                    GoTo errpt
                Else
                    tmpRD = Format(CDate(TxtResignDate.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
                End If
            Else
                MessageBox.Show("There must be a Hire Date before you can enter a Resign Date.")
            End If
        End If
        Exit Sub
errpt:
        e.Cancel = True
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
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
        If NumKeys(e.KeyData, "INT") = False Then
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
        If e.KeyData.ToString = System.Windows.Forms.Keys.Up.ToString _
           Or e.KeyData.ToString = System.Windows.Forms.Keys.Left.ToString Then 'if key pressed is the up arrow it will select the next selection before the selction
            cboStatus.SelectedItem = cboStatus.SelectedIndex - 1
        ElseIf e.KeyData.ToString = System.Windows.Forms.Keys.Down.ToString _
           Or e.KeyData.ToString = System.Windows.Forms.Keys.Right.ToString Then 'if key pressed is the up arrow it will select the next selection after the selction
            cboStatus.SelectedItem = cboStatus.SelectedIndex + 1
        ElseIf DKcodes(e.KeyData) = True Then    'checking if the key pressed is alphanumeric (to disallow typing the entry)
            cboStatus.Text = ""     'if alphanumeric then the value of the field will be erased
        End If
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")      'moves control to the next control or field
        End If
    End Sub

    Private Sub cboStatus_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboStatus.Validating
        If Trim(cboStatus.Text) = "" Then    'tests if entry is blank
            MessageBox.Show("Mandatory field!", "Critical!")  'gives message to put value
            e.Cancel() = True                'bringing back the focus to this field
        Else
            If EditMode = True Then
                If Trim(cboStatus.Text) = "INACTIVE" Then
                    TxtResignDate.Text = GetDateTimeNow("MM/dd/yyyy")
                ElseIf Trim(cboStatus.Text) = "ACTIVE" Then
                    TxtResignDate.Text = ""
                End If
            End If
        End If
    End Sub
    'added-DBrion --^
End Class