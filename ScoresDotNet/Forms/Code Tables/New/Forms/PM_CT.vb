Imports System.Data.SqlClient
Imports Microsoft
Public Class PM_CT
    Inherits System.Windows.Forms.Form
    Private RemoteDataSet As New CodeTablesDS
    Private RemoteDataSet2 As New MyDataSetDB
    Private EditMode As Boolean = False
    Private oldDs As String, tmpSD As String, tmpED As String  '<-- added-DBrion
    Private tmpHD As String, tmpRD As String
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button                   '<-- added-DBrion

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Sub_Show()
        Load_Division()
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
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblCreateDate As System.Windows.Forms.Label
    Friend WithEvents lblUpdateDate As System.Windows.Forms.Label
    Friend WithEvents txtRowid As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtMobileNo As System.Windows.Forms.TextBox
    Friend WithEvents cboDivision As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents TxtLastUser As System.Windows.Forms.TextBox
    Friend WithEvents TxtHireDate As System.Windows.Forms.TextBox
    Friend WithEvents TxtResignDate As System.Windows.Forms.TextBox
    Friend WithEvents TxtStartDate As System.Windows.Forms.TextBox
    Friend WithEvents TxtEndDate As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents SqlValue As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PM_CT))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblCreateDate = New System.Windows.Forms.Label()
        Me.lblUpdateDate = New System.Windows.Forms.Label()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.txtRowid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMobileNo = New System.Windows.Forms.TextBox()
        Me.cboDivision = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtLastUser = New System.Windows.Forms.TextBox()
        Me.TxtHireDate = New System.Windows.Forms.TextBox()
        Me.TxtResignDate = New System.Windows.Forms.TextBox()
        Me.TxtStartDate = New System.Windows.Forms.TextBox()
        Me.TxtEndDate = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SqlValue = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Code"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 392)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Create Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 416)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Update Date"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(88, 15)
        Me.txtCode.MaxLength = 10
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(232, 20)
        Me.txtCode.TabIndex = 1
        Me.txtCode.Tag = "Input"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(88, 51)
        Me.txtDescription.MaxLength = 50
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(232, 20)
        Me.txtDescription.TabIndex = 2
        Me.txtDescription.Tag = "Input"
        '
        'lblCreateDate
        '
        Me.lblCreateDate.BackColor = System.Drawing.SystemColors.Info
        Me.lblCreateDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCreateDate.Location = New System.Drawing.Point(88, 392)
        Me.lblCreateDate.Name = "lblCreateDate"
        Me.lblCreateDate.Size = New System.Drawing.Size(232, 20)
        Me.lblCreateDate.TabIndex = 6
        Me.lblCreateDate.Tag = "Input"
        '
        'lblUpdateDate
        '
        Me.lblUpdateDate.BackColor = System.Drawing.SystemColors.Info
        Me.lblUpdateDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUpdateDate.Location = New System.Drawing.Point(88, 416)
        Me.lblUpdateDate.Name = "lblUpdateDate"
        Me.lblUpdateDate.Size = New System.Drawing.Size(232, 20)
        Me.lblUpdateDate.TabIndex = 7
        Me.lblUpdateDate.Tag = "Input"
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(248, 464)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(74, 36)
        Me.cmdExit.TabIndex = 13
        Me.cmdExit.Tag = "Exit"
        Me.cmdExit.Text = "E&xit"
        '
        'cmdAdd
        '
        Me.cmdAdd.Image = CType(resources.GetObject("cmdAdd.Image"), System.Drawing.Image)
        Me.cmdAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAdd.Location = New System.Drawing.Point(8, 464)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(74, 36)
        Me.cmdAdd.TabIndex = 10
        Me.cmdAdd.Tag = "Add"
        Me.cmdAdd.Text = "      &Add"
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdEdit.Location = New System.Drawing.Point(88, 464)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(74, 36)
        Me.cmdEdit.TabIndex = 11
        Me.cmdEdit.Tag = "Edit"
        Me.cmdEdit.Text = "     &Edit"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(87, 464)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(74, 36)
        Me.cmdCancel.TabIndex = 41
        Me.cmdCancel.Tag = "Cancel"
        Me.cmdCancel.Text = "Cancel"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDelete.Location = New System.Drawing.Point(168, 464)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(74, 36)
        Me.cmdDelete.TabIndex = 12
        Me.cmdDelete.Tag = "Delete"
        Me.cmdDelete.Text = "     & Del"
        '
        'cmdSave
        '
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSave.Location = New System.Drawing.Point(168, 464)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(74, 36)
        Me.cmdSave.TabIndex = 40
        Me.cmdSave.Tag = "Save"
        Me.cmdSave.Text = "      &Save"
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(336, 6)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(976, 430)
        Me.DataGrid1.TabIndex = 0
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.DataGrid1.Tag = "View"
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.PaleTurquoise
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.Cyan
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5})
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.AntiqueWhite
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "ProdManCT_Show"
        Me.DataGridTableStyle1.ReadOnly = True
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.MappingName = "Rowid"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Code"
        Me.DataGridTextBoxColumn2.MappingName = "PMCode"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 45
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Name"
        Me.DataGridTextBoxColumn3.MappingName = "PMName"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 150
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "Email"
        Me.DataGridTextBoxColumn9.MappingName = "Email"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 75
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "Mobile"
        Me.DataGridTextBoxColumn10.MappingName = "MobileNo"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Hire Date"
        Me.DataGridTextBoxColumn6.MappingName = "Hire_Date"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 65
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Resign Date"
        Me.DataGridTextBoxColumn7.MappingName = "Resign_Date"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 65
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.MappingName = "LastUser"
        Me.DataGridTextBoxColumn14.NullText = ""
        Me.DataGridTextBoxColumn14.Width = 0
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.MappingName = "DivCode"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 0
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "Segment"
        Me.DataGridTextBoxColumn11.MappingName = "Division"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.Width = 200
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "Start Date"
        Me.DataGridTextBoxColumn12.MappingName = "StartDate"
        Me.DataGridTextBoxColumn12.NullText = ""
        Me.DataGridTextBoxColumn12.Width = 75
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "End Date"
        Me.DataGridTextBoxColumn13.MappingName = "EndDate"
        Me.DataGridTextBoxColumn13.NullText = ""
        Me.DataGridTextBoxColumn13.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Create Date"
        Me.DataGridTextBoxColumn4.MappingName = "CreateDate"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 65
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Update Date"
        Me.DataGridTextBoxColumn5.MappingName = "UpdateDate"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.ReadOnly = True
        Me.DataGridTextBoxColumn5.Width = 65
        '
        'txtRowid
        '
        Me.txtRowid.Location = New System.Drawing.Point(88, 0)
        Me.txtRowid.Name = "txtRowid"
        Me.txtRowid.Size = New System.Drawing.Size(16, 20)
        Me.txtRowid.TabIndex = 43
        Me.txtRowid.Tag = "Input"
        Me.txtRowid.Visible = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Hire Date"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(10, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 20)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Resgin Date"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(88, 168)
        Me.txtEmail.MaxLength = 75
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(232, 72)
        Me.txtEmail.TabIndex = 5
        Me.txtEmail.Tag = "Input"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(9, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 20)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Email"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 240)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 20)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "MobileNo"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMobileNo
        '
        Me.txtMobileNo.Location = New System.Drawing.Point(88, 240)
        Me.txtMobileNo.MaxLength = 50
        Me.txtMobileNo.Multiline = True
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(232, 40)
        Me.txtMobileNo.TabIndex = 6
        Me.txtMobileNo.Tag = "Input"
        '
        'cboDivision
        '
        Me.cboDivision.Location = New System.Drawing.Point(88, 280)
        Me.cboDivision.MaxLength = 55
        Me.cboDivision.Name = "cboDivision"
        Me.cboDivision.Size = New System.Drawing.Size(232, 21)
        Me.cboDivision.TabIndex = 7
        Me.cboDivision.Tag = "Input"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 280)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 20)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Segment"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 328)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 20)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Start Date"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 352)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 20)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "End Date"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtLastUser
        '
        Me.TxtLastUser.Location = New System.Drawing.Point(112, 0)
        Me.TxtLastUser.Name = "TxtLastUser"
        Me.TxtLastUser.Size = New System.Drawing.Size(48, 20)
        Me.TxtLastUser.TabIndex = 61
        Me.TxtLastUser.Tag = "Input"
        Me.TxtLastUser.Visible = False
        '
        'TxtHireDate
        '
        Me.TxtHireDate.Location = New System.Drawing.Point(88, 87)
        Me.TxtHireDate.MaxLength = 10
        Me.TxtHireDate.Name = "TxtHireDate"
        Me.TxtHireDate.Size = New System.Drawing.Size(232, 20)
        Me.TxtHireDate.TabIndex = 3
        Me.TxtHireDate.Tag = "Input"
        '
        'TxtResignDate
        '
        Me.TxtResignDate.Location = New System.Drawing.Point(88, 123)
        Me.TxtResignDate.MaxLength = 10
        Me.TxtResignDate.Name = "TxtResignDate"
        Me.TxtResignDate.Size = New System.Drawing.Size(232, 20)
        Me.TxtResignDate.TabIndex = 4
        Me.TxtResignDate.Tag = "Input"
        '
        'TxtStartDate
        '
        Me.TxtStartDate.Location = New System.Drawing.Point(88, 328)
        Me.TxtStartDate.MaxLength = 10
        Me.TxtStartDate.Name = "TxtStartDate"
        Me.TxtStartDate.Size = New System.Drawing.Size(232, 20)
        Me.TxtStartDate.TabIndex = 8
        Me.TxtStartDate.Tag = "Input"
        '
        'TxtEndDate
        '
        Me.TxtEndDate.Location = New System.Drawing.Point(88, 352)
        Me.TxtEndDate.MaxLength = 10
        Me.TxtEndDate.Name = "TxtEndDate"
        Me.TxtEndDate.Size = New System.Drawing.Size(232, 20)
        Me.TxtEndDate.TabIndex = 9
        Me.TxtEndDate.Tag = "Input"
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Location = New System.Drawing.Point(10, 451)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(318, 8)
        Me.Label14.TabIndex = 65
        '
        'Label12
        '
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(144, 520)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(184, 14)
        Me.Label12.TabIndex = 67
        Me.Label12.Text = "ex.  ""112595"" = ""Nov.25,1995"""
        '
        'Label13
        '
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(144, 504)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(192, 14)
        Me.Label13.TabIndex = 66
        Me.Label13.Text = "Easy Date Format Entry: ""MMDDYY"""
        '
        'SqlValue
        '
        Me.SqlValue.Location = New System.Drawing.Point(362, 180)
        Me.SqlValue.Name = "SqlValue"
        Me.SqlValue.Size = New System.Drawing.Size(146, 21)
        Me.SqlValue.TabIndex = 68
        Me.SqlValue.Visible = False
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(336, 473)
        Me.txtSearch.MaxLength = 50
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(232, 20)
        Me.txtSearch.TabIndex = 69
        Me.txtSearch.Tag = ""
        '
        'Button1
        '
        Me.Button1.Image = Global.ScoresDotNet.My.Resources.Resources.filter
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(574, 464)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 36)
        Me.Button1.TabIndex = 70
        Me.Button1.Tag = ""
        Me.Button1.Text = "      &Search"
        '
        'PM_CT
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1326, 540)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.SqlValue)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TxtEndDate)
        Me.Controls.Add(Me.TxtStartDate)
        Me.Controls.Add(Me.TxtResignDate)
        Me.Controls.Add(Me.TxtHireDate)
        Me.Controls.Add(Me.txtMobileNo)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.txtRowid)
        Me.Controls.Add(Me.TxtLastUser)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cboDivision)
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
        Me.Name = "PM_CT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Product Manager"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        modControlBehavior.EnableControlsGroup(Me, True)
        ControlMaintenance.ClearInputControls(Me)
        EditMode = False
        'added-DBrion --v
        btnSw = True
        lblCreateDate.Text = GetDateTimeNow("MM/dd/yyyy")
        lblUpdateDate.Text = GetDateTimeNow("MM/dd/yyyy")
        TxtHireDate.Text = GetDateTimeNow("MM/dd/yyyy")
        tmpHD = Format(CDate(TxtHireDate.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
        TxtStartDate.Text = GetDateTimeNow("MM") & "/01/" & GetDateTimeNow("yyyy")
        tmpSD = Format(CDate(TxtStartDate.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
        TxtEndDate.Text = "12/31/2078"
        tmpED = Format(CDate(TxtEndDate.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
        txtCode.Enabled = True
        txtCode.Select()
        'added-DBrion --^
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If txtCode.Text = "" And txtDescription.Text = "" Then
            MessageBox.Show("Please select a record to modify!", "Record Selection", MessageBoxButtons.OK, _
            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            modControlBehavior.EnableControlsGroup(Me, True)
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
        Try
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
                TxtLastUser.Text = gCurrUser
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

        Catch ex As Exception
            LogHelper.InsertLog("Error in cmdSave_Click : " & ex.Message)
        End Try
    End Sub

    Private Sub Sub_Insert()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(11) As SqlParameter
            Dim PMCode As New SqlParameter("@PMCode", SqlDbType.VarChar, 10)
            PMCode.Direction = ParameterDirection.Input
            PMCode.Value = Trim(txtCode.Text)
            Params(0) = PMCode
            Dim PMName As New SqlParameter("@PMName", SqlDbType.VarChar, 50)
            PMName.Direction = ParameterDirection.Input
            PMName.Value = Trim(txtDescription.Text)
            Params(1) = PMName
            Dim Email As New SqlParameter("@Email", SqlDbType.VarChar, 75)
            Email.Direction = ParameterDirection.Input
            Email.Value = Trim(txtEmail.Text)
            Params(2) = Email
            Dim MobileNo As New SqlParameter("@MobileNo", SqlDbType.VarChar, 50)
            MobileNo.Direction = ParameterDirection.Input
            MobileNo.Value = Trim(txtMobileNo.Text)
            Params(3) = MobileNo
            Dim Hire_Date As New SqlParameter("@Hire_Date", SqlDbType.DateTime, 10)
            Hire_Date.Direction = ParameterDirection.Input
            If Trim(tmpHD) = "" Then
                Hire_Date.Value = DBNull.Value
            Else
                Hire_Date.Value = tmpHD
            End If

            Params(4) = Hire_Date
            Dim Resign_Date As New SqlParameter("@Resign_Date", SqlDbType.DateTime, 10)
            Resign_Date.Direction = ParameterDirection.Input
            If Trim(TxtResignDate.Text) = "" Then
                Resign_Date.Value = DBNull.Value
            Else
                Resign_Date.Value = tmpRD
            End If
            Params(5) = Resign_Date
            Dim CreateDate As New SqlParameter("@CreateDate", SqlDbType.DateTime, 10)
            CreateDate.Direction = ParameterDirection.Input
            CreateDate.Value = GetDateTimeNow()
            Params(6) = CreateDate
            Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime, 10)
            UpdateDate.Direction = ParameterDirection.Input
            UpdateDate.Value = GetDateTimeNow()
            Params(7) = UpdateDate
            Dim LastUser As New SqlParameter("@LastUser", SqlDbType.VarChar, 8)  '<v--added-DBrion
            LastUser.Direction = ParameterDirection.Input
            LastUser.Value = IIf(Trim(gCurrUser) = "", "", gCurrUser)     ' Trim(TxtLastUser.Text)
            Params(8) = LastUser                                                 '<^--added-DBrion
            Dim DivCode As New SqlParameter("@DivCode", SqlDbType.VarChar, 3)
            DivCode.Direction = ParameterDirection.Input
            DivCode.Value = GetCode(cboDivision.Text)
            Params(9) = DivCode
            Dim StartDate As New SqlParameter("@StartDate", SqlDbType.DateTime, 10)
            StartDate.Direction = ParameterDirection.Input
            If Trim(tmpSD) = "" Then
                StartDate.Value = DBNull.Value
            Else
                StartDate.Value = tmpSD
            End If
            Params(10) = StartDate
            Dim EndDate As New SqlParameter("@EndDate", SqlDbType.DateTime, 10)
            EndDate.Direction = ParameterDirection.Input
            If Trim(tmpED) = "" Then
                EndDate.Value = DBNull.Value
            Else
                EndDate.Value = TxtEndDate.Text.ToString()     'EndDate
            End If
            Params(11) = EndDate
            BusinessObject.Sub_Insert(ServerPath2, "ProdManCT_Insert", CommandType.StoredProcedure, Params)
            LogHelper.InsertLog("ProdManCT_Insert.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("ProdManCT_Insert.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Sub_Update()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(10) As SqlParameter
            Dim PMCode As New SqlParameter("@PMCode", SqlDbType.VarChar, 10)  '<v--commented-DBrion
            PMCode.Direction = ParameterDirection.Input
            PMCode.Value = Trim(txtCode.Text)
            Params(0) = PMCode                                                 '<^--commented-Dbrion
            Dim PMName As New SqlParameter("@PMName", SqlDbType.VarChar, 50)
            PMName.Direction = ParameterDirection.Input
            PMName.Value = Trim(txtDescription.Text)
            Params(1) = PMName
            Dim Email As New SqlParameter("@Email", SqlDbType.VarChar, 75)
            Email.Direction = ParameterDirection.Input
            Email.Value = Trim(txtEmail.Text)
            Params(2) = Email
            Dim MobileNo As New SqlParameter("@MobileNo", SqlDbType.VarChar, 50)
            MobileNo.Direction = ParameterDirection.Input
            MobileNo.Value = Trim(txtMobileNo.Text)
            Params(3) = MobileNo
            Dim Hire_Date As New SqlParameter("@Hire_Date", SqlDbType.DateTime, 10)
            Hire_Date.Direction = ParameterDirection.Input
            If Trim(tmpHD) = "" Then
                Hire_Date.Value = DBNull.Value
            Else
                Hire_Date.Value = tmpHD
            End If
            Params(4) = Hire_Date
            Dim Resign_Date As New SqlParameter("@Resign_Date", SqlDbType.DateTime, 10)
            Resign_Date.Direction = ParameterDirection.Input
            If Trim(TxtResignDate.Text) = "" Then
                Resign_Date.Value = DBNull.Value
            Else
                Resign_Date.Value = tmpRD
            End If
            Params(5) = Resign_Date
            Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime, 10)
            UpdateDate.Direction = ParameterDirection.Input
            UpdateDate.Value = GetDateTimeNow()
            Params(6) = UpdateDate
            Dim LastUser As New SqlParameter("@LastUser", SqlDbType.VarChar, 8)  '<v--added-DBrion
            LastUser.Direction = ParameterDirection.Input
            LastUser.Value = IIf(Trim(gCurrUser) = "", "", gCurrUser)     ' Trim(TxtLastUser.Text)
            Params(7) = LastUser                                                 '<^--added-DBrion
            Dim DivCode As New SqlParameter("@DivCode", SqlDbType.VarChar, 3)
            DivCode.Direction = ParameterDirection.Input
            DivCode.Value = GetCode(cboDivision.Text)
            Params(8) = DivCode
            Dim StartDate As New SqlParameter("@StartDate", SqlDbType.DateTime, 10)
            StartDate.Direction = ParameterDirection.Input
            If Trim(tmpSD) = "" Then
                StartDate.Value = DBNull.Value
            Else
                StartDate.Value = tmpSD
            End If

            Params(9) = StartDate
            Dim EndDate As New SqlParameter("@EndDate", SqlDbType.DateTime, 10)
            EndDate.Direction = ParameterDirection.Input
            EndDate.Value = tmpED
            If Trim(tmpED) = "" Then
                EndDate.Value = DBNull.Value
            Else
                EndDate.Value = tmpED
            End If
            Params(10) = EndDate
            BusinessObject.Sub_Update(ServerPath2, "ProdManCT_Update", CommandType.StoredProcedure, Params)
            LogHelper.InsertLog("ProdManCT_Update.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("ProdManCT_Update.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Sub_Show()
        Try
            If RemoteDataSet.ProdManCT_Show.Count > 0 Then RemoteDataSet.ProdManCT_Show.Clear()
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            If Trim(txtSearch.Text = "") Then
                BusinessObject.Sub_Show(ServerPath2, "ProdManCT_Show", CommandType.StoredProcedure, RemoteDataSet, "ProdManCT_Show")
            Else
                Dim Params(0) As SqlParameter
                Dim pmname As New SqlParameter("@pmname", SqlDbType.VarChar, 50)
                pmname.Direction = ParameterDirection.Input
                pmname.Value = txtSearch.Text.ToString.Trim
                Params(0) = pmname
                BusinessObject.Sub_Show(ServerPath2, "ProdManCT_Show_Search", CommandType.StoredProcedure, RemoteDataSet, "ProdManCT_Show", Params)
            End If
            DataGrid1.DataSource = RemoteDataSet.ProdManCT_Show
            LogHelper.InsertLog("ProdManCT_Show.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("ProdManCT_Show.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Load_Division()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Try
            BusinessObject.Sub_Show(ServerPath2, "Division_Combo", CommandType.StoredProcedure, RemoteDataSet, "Division_Combo")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cboDivision.DataSource = RemoteDataSet.Division_Combo
        cboDivision.DisplayMember = "Division"
    End Sub

    Private Sub Sub_Select(ByVal dbParams() As String, ByVal UpdateMode As String)
        'select case if add,edit or delete
        Dim i As Integer
        Dim myRowid As Integer
        Select Case UpdateMode
            Case "Insert"
                Dim BusinessObject As New BusinessLayer.clsFileMaintenance
                myRowid = CInt(BusinessObject.Sub_ReturnIntegerResult(ServerPath2, "ProdManCT_GetInsertedRowid", CommandType.StoredProcedure))
            Case "Update"
                myRowid = CInt(dbParams(0))
        End Select
        For i = 0 To (RemoteDataSet.ProdManCT_Show.Rows.Count - 1)
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
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim PMcode As New SqlParameter("@PMcode", SqlDbType.Int)  '<v--changed from Rowid to PMcode
            PMcode.Direction = ParameterDirection.Input
            PMcode.Value = txtCode.Text
            Params(0) = PMcode                                         '<^--changed from Rowid to PMcode
            BusinessObject.Sub_Delete(ServerPath2, "ProdManCT_Delete", CommandType.StoredProcedure, Params)
            LogHelper.InsertLog("ProdManCT_Delete.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("ProdManCT_Delete.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub PM_CT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            modControlBehavior.EnableControls(Me, False)
            btnSw = False    '<-- added-DBrion
            tmpSD = ""
            tmpED = ""
            tmpHD = ""
            tmpRD = ""
            LogHelper.InsertLog("PM_CT_Load.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("PM_CT_Load.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub DataGrid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.Click, DataGrid1.CurrentCellChanged
        With DataGrid1
            txtRowid.Text = .Item(.CurrentCell.RowNumber, 0).ToString       '<v--added to ".ToString"
            txtCode.Text = .Item(.CurrentCell.RowNumber, 1).ToString
            txtDescription.Text = .Item(.CurrentCell.RowNumber, 2).ToString
            oldDs = Trim(txtDescription.Text)
            txtEmail.Text = .Item(.CurrentCell.RowNumber, 3).ToString
            txtMobileNo.Text = .Item(.CurrentCell.RowNumber, 4).ToString
            If Trim(.Item(.CurrentCell.RowNumber, 5).ToString) <> "" Then
                TxtHireDate.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 5).ToString), "MM/dd/yyyy")
            Else
                TxtHireDate.Text = ""
            End If
            If Trim(.Item(.CurrentCell.RowNumber, 6).ToString) <> "" Then
                TxtResignDate.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 6).ToString), "MM/dd/yyyy")
            Else
                TxtResignDate.Text = ""
            End If
            TxtLastUser.Text = .Item(.CurrentCell.RowNumber, 7).ToString
            cboDivision.SelectedText = .Item(.CurrentCell.RowNumber, 8).ToString & "--" & _
                                       .Item(.CurrentCell.RowNumber, 9).ToString
            If Trim(.Item(.CurrentCell.RowNumber, 10).ToString) <> "" Then
                TxtStartDate.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 10).ToString), "MM/dd/yyyy")
            Else
                TxtStartDate.Text = ""
            End If
            If Trim(.Item(.CurrentCell.RowNumber, 11).ToString) <> "" Then   '<v--added to ".ToString"
                TxtEndDate.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 13).ToString), "MM/dd/yyyy")
            Else
                TxtEndDate.Text = ""
            End If
            If Trim(.Item(.CurrentCell.RowNumber, 12).ToString) <> "" Then
                lblCreateDate.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 12).ToString), "MM/dd/yyyy")
            Else
                lblCreateDate.Text = ""
            End If
            If Trim(.Item(.CurrentCell.RowNumber, 13).ToString) <> "" Then
                lblUpdateDate.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 13).ToString), "MM/dd/yyyy")
            Else
                lblUpdateDate.Text = ""
            End If
            .Select(.CurrentCell.RowNumber)
        End With
    End Sub

    'added-DBrion --v
    Private Sub txtCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
        'If NumKeys(e.KeyData, "INT") = False Then
        '    If Len(Trim(txtCode.Text)) <> 0 Then
        '        txtCode.Text = Mid(Trim(txtCode.Text), 1, Len(Trim(txtCode.Text)) - 1)
        '        txtCode.SelectionStart = Len(Trim(txtCode.Text))
        '        Beep()
        '    Else
        '        txtCode.Text = ""
        '    End If
        'End If
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
            s = "select pmname as fld1 from NewScores..ProductManager where pmcode = '" & Trim(txtCode.Text) & "' "
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
                MessageBox.Show("This PM Code already exist! Please try again.", "PM Exsists!")
                e.Cancel = True
                txtCode.Clear()
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
        '    s = "select pmcode as fld1 from NewScores..ProductManager where pmname = '" & Trim(txtDescription.Text) & "' "
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
        '        MessageBox.Show("This PM Code already exist! Please try again.", "PM Exsists!")
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
            If Trim(TxtResignDate.Text) <> "" Then
                If CDate(TxtHireDate.Text) > CDate(TxtResignDate.Text) Then
                    MessageBox.Show("Hire date should not be later than resign date!")
                    GoTo errpt
                Else
                    tmpHD = Format(CDate(TxtHireDate.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
                End If
            Else
                tmpHD = Format(CDate(TxtHireDate.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
            End If
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

    Private Sub TxtStartDate_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtStartDate.KeyUp
        If e.KeyValue = 13 Then      ' tests if the key pressed is the "enter key"
            SendKeys.Send("{TAB}")   ' sends the focus to the next control/tabstop
        End If
    End Sub

    Private Sub TxtStartDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtStartDate.Validating
        On Error GoTo errpt
        If Trim(TxtStartDate.Text) = "" Then       'entering w/o putting value
            TxtStartDate.Text = GetDateTimeNow("MM") & "/01/" & GetDateTimeNow("yyyy")
            tmpSD = Format(CDate(TxtStartDate.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
            Exit Sub
        Else
            TxtStartDate.Text = DatValid(TxtStartDate.Text)  'validating the entry. the textbox's value will be "mm/dd/yyyy" if the entry is invalid.
            If Trim(TxtStartDate.Text) = "mm/dd/yyyy" Then
                GoTo errpt
            Else
                TxtStartDate.Text = Mid(Trim(TxtStartDate.Text), 1, 2) & "/01/" & _
                                    Mid(Trim(TxtStartDate.Text), 7, 4)   'making the date the start of the month entered
                tmpSD = Format(CDate(TxtStartDate.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt") 'will use this variable in saving
            End If
            Exit Sub
        End If
errpt:
        e.Cancel = True  'brings back the focus to TxtStartDate textbox. only in Validating event
    End Sub

    Private Sub TxtEndDate_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtEndDate.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TxtEndDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtEndDate.Validating
        On Error GoTo errpt
        If Trim(TxtEndDate.Text) = "" Then
            TxtEndDate.Text = "12/31/2078"
            tmpED = Format(CDate(TxtEndDate.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
            Exit Sub
        Else
            TxtEndDate.Text = DatValid(TxtEndDate.Text)
            If Trim(TxtEndDate.Text) = "mm/dd/yyyy" Then
                GoTo errpt
            Else
                If Trim(TxtStartDate.Text) <> "" Then
                    If CDate(TxtStartDate.Text) < CDate(TxtEndDate.Text) Then
                        TxtEndDate.Text = GetEOM(Trim(TxtEndDate.Text))
                        tmpED = Format(CDate(TxtEndDate.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
                        Exit Sub
                    ElseIf Month(CDate(TxtStartDate.Text)) > Month(CDate(TxtEndDate.Text)) Then
                        MessageBox.Show("The End date should be a month later than the Start date!")
                    End If
                End If
            End If
        End If
errpt:
        e.Cancel = True
    End Sub

    Private Sub cboDivision_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboDivision.KeyUp
        If e.KeyData.ToString = System.Windows.Forms.Keys.Up.ToString _
           Or e.KeyData.ToString = System.Windows.Forms.Keys.Left.ToString Then 'if key pressed is the up arrow it will select the next selection before the selction
            cboDivision.SelectedItem = cboDivision.SelectedIndex - 1
        ElseIf e.KeyData.ToString = System.Windows.Forms.Keys.Down.ToString _
           Or e.KeyData.ToString = System.Windows.Forms.Keys.Right.ToString Then 'if key pressed is the up arrow it will select the next selection after the selction
            cboDivision.SelectedItem = cboDivision.SelectedIndex + 1
        ElseIf DKcodes(e.KeyData) = True Then    'checking if the key pressed is alphanumeric (to disallow typing the entry)
            cboDivision.Text = ""     'if alphanumeric then the value of the field will be erased
        End If
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")      'moves control to the next control or field
        End If
    End Sub

    Private Sub cboDivision_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboDivision.Validating
        If Trim(cboDivision.Text) = "" Then    'tests if entry is blank
            MessageBox.Show("Mandatory field!", "Critical!")  'gives message to put value
            e.Cancel() = True                  ' brings back the focus on this control/field
        End If
    End Sub

    Private Sub txtEmail_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmail.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtEmail_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEmail.Validating
        If jTrim(txtEmail.Text) = "" Then
            Exit Sub
        End If
        If InStr(jTrim(txtEmail.Text), "@") = 0 And InStr(jTrim(txtEmail.Text), ".") <> 0 Then
            MessageBox.Show("Invalid email address!")
            Exit Sub
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

    Private Sub Frm_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        EnDisMainMenu(Me, True)
        'ChildCtr = ChildCtr - 1              '<--ready for 2forms need
    End Sub

    Private Sub Frm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        EnDisMainMenu(Me, False)
    End Sub

    Private Sub frmProcessInMarketData_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        'If CloseFrm = True Then              '<- ready
        '    CloseFrm = False                 '<- for
        '    Close()                          '<- 2forms
        'End If                               '<- need
    End Sub
    'added-DBrion --^

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Sub_Show()
    End Sub
End Class
