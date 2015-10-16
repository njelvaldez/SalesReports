Imports System.Data.SqlClient
Imports Microsoft
Public Class SupervisorCT
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents TxtEndDate As System.Windows.Forms.TextBox
    Friend WithEvents TxtStartDate As System.Windows.Forms.TextBox
    Friend WithEvents TxtResignDate As System.Windows.Forms.TextBox
    Friend WithEvents TxtHireDate As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents SqlValue As System.Windows.Forms.ComboBox
    Friend WithEvents DataGrid2 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents txtLastUser As System.Windows.Forms.TextBox
    Friend WithEvents DGTabStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn15 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn16 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn17 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn18 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn19 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn20 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn21 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn22 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn23 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn24 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn25 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn26 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn27 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn28 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgTabStyle6 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn29 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn30 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn31 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn32 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn33 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn34 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn35 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn36 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGrid3 As System.Windows.Forms.DataGrid
    Friend WithEvents cmdAddNSM As System.Windows.Forms.Button
    Friend WithEvents cmdEditNSM As System.Windows.Forms.Button
    Friend WithEvents cmdDeleteNSM As System.Windows.Forms.Button
    Friend WithEvents txtRowidN As System.Windows.Forms.TextBox
    Friend WithEvents txtRowidD As System.Windows.Forms.TextBox
    Friend WithEvents cmdAddDiv As System.Windows.Forms.Button
    Friend WithEvents cmdEditDiv As System.Windows.Forms.Button
    Friend WithEvents cmdDeleteDiv As System.Windows.Forms.Button
    Friend WithEvents aBtn As System.Windows.Forms.Button
    Friend WithEvents oBtn As System.Windows.Forms.Button
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
        Me.DGTabStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn17 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn18 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn19 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn20 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn21 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.txtRowid = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtMobileNo = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmdAddNSM = New System.Windows.Forms.Button
        Me.cmdEditNSM = New System.Windows.Forms.Button
        Me.cmdDeleteNSM = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.Button7 = New System.Windows.Forms.Button
        Me.cmdAddDiv = New System.Windows.Forms.Button
        Me.cmdEditDiv = New System.Windows.Forms.Button
        Me.cmdDeleteDiv = New System.Windows.Forms.Button
        Me.TxtEndDate = New System.Windows.Forms.TextBox
        Me.TxtStartDate = New System.Windows.Forms.TextBox
        Me.TxtResignDate = New System.Windows.Forms.TextBox
        Me.TxtHireDate = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.SqlValue = New System.Windows.Forms.ComboBox
        Me.DataGrid2 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.txtLastUser = New System.Windows.Forms.TextBox
        Me.DataGridTextBoxColumn22 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn23 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn24 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn25 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn26 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn27 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn28 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGrid3 = New System.Windows.Forms.DataGrid
        Me.dgTabStyle6 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn29 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn30 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn31 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn32 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn33 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn34 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn35 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn36 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.txtRowidN = New System.Windows.Forms.TextBox
        Me.txtRowidD = New System.Windows.Forms.TextBox
        Me.aBtn = New System.Windows.Forms.Button
        Me.oBtn = New System.Windows.Forms.Button
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(4, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Code"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(4, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(4, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Create Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(4, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Update Date"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCode
        '
        Me.txtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Location = New System.Drawing.Point(78, 9)
        Me.txtCode.MaxLength = 10
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(184, 20)
        Me.txtCode.TabIndex = 0
        Me.txtCode.Tag = "Input"
        Me.txtCode.Text = ""
        '
        'txtDescription
        '
        Me.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescription.Location = New System.Drawing.Point(78, 33)
        Me.txtDescription.MaxLength = 100
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(184, 20)
        Me.txtDescription.TabIndex = 1
        Me.txtDescription.Tag = "Input"
        Me.txtDescription.Text = ""
        '
        'lblCreateDate
        '
        Me.lblCreateDate.BackColor = System.Drawing.SystemColors.Info
        Me.lblCreateDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCreateDate.Location = New System.Drawing.Point(78, 202)
        Me.lblCreateDate.Name = "lblCreateDate"
        Me.lblCreateDate.Size = New System.Drawing.Size(184, 20)
        Me.lblCreateDate.TabIndex = 6
        Me.lblCreateDate.Tag = "Input"
        '
        'lblUpdateDate
        '
        Me.lblUpdateDate.BackColor = System.Drawing.SystemColors.Info
        Me.lblUpdateDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUpdateDate.Location = New System.Drawing.Point(78, 226)
        Me.lblUpdateDate.Name = "lblUpdateDate"
        Me.lblUpdateDate.Size = New System.Drawing.Size(184, 20)
        Me.lblUpdateDate.TabIndex = 7
        Me.lblUpdateDate.Tag = "Input"
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(200, 262)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(64, 23)
        Me.cmdExit.TabIndex = 11
        Me.cmdExit.Tag = "Exit"
        Me.cmdExit.Text = "Exit"
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(8, 262)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(64, 23)
        Me.cmdAdd.TabIndex = 8
        Me.cmdAdd.Tag = "Add"
        Me.cmdAdd.Text = "Add"
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(72, 262)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(64, 23)
        Me.cmdEdit.TabIndex = 9
        Me.cmdEdit.Tag = "Edit"
        Me.cmdEdit.Text = "Edit"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(72, 262)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(64, 23)
        Me.cmdCancel.TabIndex = 13
        Me.cmdCancel.Tag = "Cancel"
        Me.cmdCancel.Text = "Cancel"
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(136, 262)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(64, 23)
        Me.cmdDelete.TabIndex = 10
        Me.cmdDelete.Tag = "Delete"
        Me.cmdDelete.Text = "Delete"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(136, 262)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(64, 23)
        Me.cmdSave.TabIndex = 12
        Me.cmdSave.Tag = "Save"
        Me.cmdSave.Text = "Save"
        '
        'DataGrid1
        '
        Me.DataGrid1.AccessibleRole = System.Windows.Forms.AccessibleRole.Row
        Me.DataGrid1.AlternatingBackColor = System.Drawing.Color.Aqua
        Me.DataGrid1.BackColor = System.Drawing.Color.Azure
        Me.DataGrid1.BackgroundColor = System.Drawing.Color.PowderBlue
        Me.DataGrid1.CaptionText = "District Sales Manager"
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.GridLineColor = System.Drawing.Color.CornflowerBlue
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(271, 8)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.SelectionBackColor = System.Drawing.Color.Navy
        Me.DataGrid1.SelectionForeColor = System.Drawing.Color.White
        Me.DataGrid1.Size = New System.Drawing.Size(584, 278)
        Me.DataGrid1.TabIndex = 42
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DGTabStyle2})
        Me.DataGrid1.Tag = "View"
        '
        'DGTabStyle2
        '
        Me.DGTabStyle2.AlternatingBackColor = System.Drawing.Color.Aqua
        Me.DGTabStyle2.BackColor = System.Drawing.Color.Azure
        Me.DGTabStyle2.DataGrid = Me.DataGrid1
        Me.DGTabStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn16, Me.DataGridTextBoxColumn17, Me.DataGridTextBoxColumn18, Me.DataGridTextBoxColumn19, Me.DataGridTextBoxColumn20, Me.DataGridTextBoxColumn21})
        Me.DGTabStyle2.GridLineColor = System.Drawing.Color.CornflowerBlue
        Me.DGTabStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DGTabStyle2.MappingName = "SupervisorCT_Show"
        Me.DGTabStyle2.SelectionBackColor = System.Drawing.Color.Navy
        Me.DGTabStyle2.SelectionForeColor = System.Drawing.Color.White
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.MappingName = "Rowid"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.Width = 0
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "Code"
        Me.DataGridTextBoxColumn11.MappingName = "SupCode"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.Width = 90
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "Description"
        Me.DataGridTextBoxColumn12.MappingName = "SupName"
        Me.DataGridTextBoxColumn12.NullText = ""
        Me.DataGridTextBoxColumn12.Width = 200
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "Hire Date"
        Me.DataGridTextBoxColumn13.MappingName = "Hire_Date"
        Me.DataGridTextBoxColumn13.NullText = ""
        Me.DataGridTextBoxColumn13.Width = 70
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "Resign Date"
        Me.DataGridTextBoxColumn14.MappingName = "Resign_Date"
        Me.DataGridTextBoxColumn14.NullText = ""
        Me.DataGridTextBoxColumn14.Width = 70
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.MappingName = "Email"
        Me.DataGridTextBoxColumn15.NullText = ""
        Me.DataGridTextBoxColumn15.Width = 0
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Format = ""
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.MappingName = "Mobileno"
        Me.DataGridTextBoxColumn16.NullText = ""
        Me.DataGridTextBoxColumn16.Width = 0
        '
        'DataGridTextBoxColumn17
        '
        Me.DataGridTextBoxColumn17.Format = ""
        Me.DataGridTextBoxColumn17.FormatInfo = Nothing
        Me.DataGridTextBoxColumn17.MappingName = "CreateDate"
        Me.DataGridTextBoxColumn17.NullText = ""
        Me.DataGridTextBoxColumn17.Width = 0
        '
        'DataGridTextBoxColumn18
        '
        Me.DataGridTextBoxColumn18.Format = ""
        Me.DataGridTextBoxColumn18.FormatInfo = Nothing
        Me.DataGridTextBoxColumn18.MappingName = "UpdateDate"
        Me.DataGridTextBoxColumn18.NullText = ""
        Me.DataGridTextBoxColumn18.Width = 0
        '
        'DataGridTextBoxColumn19
        '
        Me.DataGridTextBoxColumn19.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn19.FormatInfo = Nothing
        Me.DataGridTextBoxColumn19.HeaderText = "Start Date"
        Me.DataGridTextBoxColumn19.MappingName = "StartDate"
        Me.DataGridTextBoxColumn19.NullText = ""
        Me.DataGridTextBoxColumn19.Width = 0
        '
        'DataGridTextBoxColumn20
        '
        Me.DataGridTextBoxColumn20.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn20.FormatInfo = Nothing
        Me.DataGridTextBoxColumn20.HeaderText = "End Date"
        Me.DataGridTextBoxColumn20.MappingName = "EndDate"
        Me.DataGridTextBoxColumn20.NullText = ""
        Me.DataGridTextBoxColumn20.Width = 0
        '
        'DataGridTextBoxColumn21
        '
        Me.DataGridTextBoxColumn21.Format = ""
        Me.DataGridTextBoxColumn21.FormatInfo = Nothing
        Me.DataGridTextBoxColumn21.MappingName = "LastUser"
        Me.DataGridTextBoxColumn21.NullText = ""
        Me.DataGridTextBoxColumn21.Width = 0
        '
        'txtRowid
        '
        Me.txtRowid.Location = New System.Drawing.Point(511, 35)
        Me.txtRowid.Name = "txtRowid"
        Me.txtRowid.Size = New System.Drawing.Size(46, 20)
        Me.txtRowid.TabIndex = 43
        Me.txtRowid.Tag = "Input"
        Me.txtRowid.Text = ""
        Me.txtRowid.Visible = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(4, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 20)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Hire Date"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(4, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 20)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Resign Date"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(78, 105)
        Me.txtEmail.MaxLength = 75
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(184, 20)
        Me.txtEmail.TabIndex = 4
        Me.txtEmail.Tag = "Input"
        Me.txtEmail.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(4, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 20)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Email"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(4, 129)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 20)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "MobileNo"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMobileNo
        '
        Me.txtMobileNo.Location = New System.Drawing.Point(78, 129)
        Me.txtMobileNo.MaxLength = 50
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(184, 20)
        Me.txtMobileNo.TabIndex = 5
        Me.txtMobileNo.Tag = "Input"
        Me.txtMobileNo.Text = ""
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Location = New System.Drawing.Point(6, 253)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(260, 2)
        Me.Label9.TabIndex = 55
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Location = New System.Drawing.Point(8, 567)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(260, 2)
        Me.Label10.TabIndex = 64
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(202, 576)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 23)
        Me.Button1.TabIndex = 23
        Me.Button1.Tag = ""
        '
        'cmdAddNSM
        '
        Me.cmdAddNSM.Location = New System.Drawing.Point(10, 576)
        Me.cmdAddNSM.Name = "cmdAddNSM"
        Me.cmdAddNSM.Size = New System.Drawing.Size(64, 23)
        Me.cmdAddNSM.TabIndex = 20
        Me.cmdAddNSM.Tag = ""
        Me.cmdAddNSM.Text = "Add"
        '
        'cmdEditNSM
        '
        Me.cmdEditNSM.Location = New System.Drawing.Point(74, 576)
        Me.cmdEditNSM.Name = "cmdEditNSM"
        Me.cmdEditNSM.Size = New System.Drawing.Size(64, 23)
        Me.cmdEditNSM.TabIndex = 21
        Me.cmdEditNSM.Tag = ""
        Me.cmdEditNSM.Text = "Edit"
        '
        'cmdDeleteNSM
        '
        Me.cmdDeleteNSM.Location = New System.Drawing.Point(138, 576)
        Me.cmdDeleteNSM.Name = "cmdDeleteNSM"
        Me.cmdDeleteNSM.Size = New System.Drawing.Size(64, 23)
        Me.cmdDeleteNSM.TabIndex = 22
        Me.cmdDeleteNSM.Tag = ""
        Me.cmdDeleteNSM.Text = "Delete"
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Location = New System.Drawing.Point(593, 567)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(260, 2)
        Me.Label11.TabIndex = 71
        '
        'Button7
        '
        Me.Button7.Enabled = False
        Me.Button7.Location = New System.Drawing.Point(787, 576)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(64, 23)
        Me.Button7.TabIndex = 33
        Me.Button7.Tag = ""
        '
        'cmdAddDiv
        '
        Me.cmdAddDiv.Location = New System.Drawing.Point(595, 576)
        Me.cmdAddDiv.Name = "cmdAddDiv"
        Me.cmdAddDiv.Size = New System.Drawing.Size(64, 23)
        Me.cmdAddDiv.TabIndex = 30
        Me.cmdAddDiv.Tag = ""
        Me.cmdAddDiv.Text = "Add"
        '
        'cmdEditDiv
        '
        Me.cmdEditDiv.Location = New System.Drawing.Point(659, 576)
        Me.cmdEditDiv.Name = "cmdEditDiv"
        Me.cmdEditDiv.Size = New System.Drawing.Size(64, 23)
        Me.cmdEditDiv.TabIndex = 31
        Me.cmdEditDiv.Tag = ""
        Me.cmdEditDiv.Text = "Edit"
        '
        'cmdDeleteDiv
        '
        Me.cmdDeleteDiv.Location = New System.Drawing.Point(723, 576)
        Me.cmdDeleteDiv.Name = "cmdDeleteDiv"
        Me.cmdDeleteDiv.Size = New System.Drawing.Size(64, 23)
        Me.cmdDeleteDiv.TabIndex = 32
        Me.cmdDeleteDiv.Tag = ""
        Me.cmdDeleteDiv.Text = "Delete"
        '
        'TxtEndDate
        '
        Me.TxtEndDate.Location = New System.Drawing.Point(78, 177)
        Me.TxtEndDate.MaxLength = 10
        Me.TxtEndDate.Name = "TxtEndDate"
        Me.TxtEndDate.Size = New System.Drawing.Size(184, 20)
        Me.TxtEndDate.TabIndex = 7
        Me.TxtEndDate.Tag = "Input"
        Me.TxtEndDate.Text = ""
        Me.TxtEndDate.Visible = False
        '
        'TxtStartDate
        '
        Me.TxtStartDate.Location = New System.Drawing.Point(78, 153)
        Me.TxtStartDate.MaxLength = 10
        Me.TxtStartDate.Name = "TxtStartDate"
        Me.TxtStartDate.Size = New System.Drawing.Size(184, 20)
        Me.TxtStartDate.TabIndex = 6
        Me.TxtStartDate.Tag = "Input"
        Me.TxtStartDate.Text = ""
        Me.TxtStartDate.Visible = False
        '
        'TxtResignDate
        '
        Me.TxtResignDate.Location = New System.Drawing.Point(78, 81)
        Me.TxtResignDate.MaxLength = 10
        Me.TxtResignDate.Name = "TxtResignDate"
        Me.TxtResignDate.Size = New System.Drawing.Size(184, 20)
        Me.TxtResignDate.TabIndex = 3
        Me.TxtResignDate.Tag = "Input"
        Me.TxtResignDate.Text = ""
        '
        'TxtHireDate
        '
        Me.TxtHireDate.Location = New System.Drawing.Point(78, 57)
        Me.TxtHireDate.MaxLength = 10
        Me.TxtHireDate.Name = "TxtHireDate"
        Me.TxtHireDate.Size = New System.Drawing.Size(184, 20)
        Me.TxtHireDate.TabIndex = 2
        Me.TxtHireDate.Tag = "Input"
        Me.TxtHireDate.Text = ""
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(4, 177)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 20)
        Me.Label12.TabIndex = 77
        Me.Label12.Text = "End Date"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label12.Visible = False
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(4, 154)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 20)
        Me.Label13.TabIndex = 76
        Me.Label13.Text = "Start Date"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label13.Visible = False
        '
        'SqlValue
        '
        Me.SqlValue.Location = New System.Drawing.Point(275, 34)
        Me.SqlValue.Name = "SqlValue"
        Me.SqlValue.Size = New System.Drawing.Size(146, 21)
        Me.SqlValue.TabIndex = 78
        Me.SqlValue.Visible = False
        '
        'DataGrid2
        '
        Me.DataGrid2.AccessibleRole = System.Windows.Forms.AccessibleRole.Row
        Me.DataGrid2.AlternatingBackColor = System.Drawing.Color.Aqua
        Me.DataGrid2.BackColor = System.Drawing.Color.Azure
        Me.DataGrid2.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.DataGrid2.CaptionText = "National Sales Manager"
        Me.DataGrid2.DataMember = ""
        Me.DataGrid2.GridLineColor = System.Drawing.Color.CornflowerBlue
        Me.DataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid2.Location = New System.Drawing.Point(7, 294)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.SelectionBackColor = System.Drawing.Color.Navy
        Me.DataGrid2.SelectionForeColor = System.Drawing.Color.White
        Me.DataGrid2.Size = New System.Drawing.Size(422, 265)
        Me.DataGrid2.TabIndex = 80
        Me.DataGrid2.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.DataGrid2.Tag = "View"
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Aqua
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.Azure
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid2
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9})
        Me.DataGridTableStyle1.GridLineColor = System.Drawing.Color.CornflowerBlue
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Sup_NSM_Show"
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.Navy
        Me.DataGridTableStyle1.SelectionForeColor = System.Drawing.Color.White
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.MappingName = "Rowid"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Code"
        Me.DataGridTextBoxColumn3.MappingName = "NsmCode"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 45
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Description"
        Me.DataGridTextBoxColumn4.MappingName = "NsmName"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 200
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.MappingName = "CreateDate"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 0
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.MappingName = "UpdateDate"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 0
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Start Date"
        Me.DataGridTextBoxColumn7.MappingName = "StartDate"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 70
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "End Date"
        Me.DataGridTextBoxColumn8.MappingName = "EndDate"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 70
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.MappingName = "LastUser"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 0
        '
        'txtLastUser
        '
        Me.txtLastUser.Location = New System.Drawing.Point(429, 35)
        Me.txtLastUser.Name = "txtLastUser"
        Me.txtLastUser.Size = New System.Drawing.Size(70, 20)
        Me.txtLastUser.TabIndex = 81
        Me.txtLastUser.Tag = "Input"
        Me.txtLastUser.Text = ""
        Me.txtLastUser.Visible = False
        '
        'DataGridTextBoxColumn22
        '
        Me.DataGridTextBoxColumn22.Format = ""
        Me.DataGridTextBoxColumn22.FormatInfo = Nothing
        Me.DataGridTextBoxColumn22.MappingName = "rowid"
        Me.DataGridTextBoxColumn22.NullText = ""
        Me.DataGridTextBoxColumn22.Width = 0
        '
        'DataGridTextBoxColumn23
        '
        Me.DataGridTextBoxColumn23.Format = ""
        Me.DataGridTextBoxColumn23.FormatInfo = Nothing
        Me.DataGridTextBoxColumn23.HeaderText = "Code"
        Me.DataGridTextBoxColumn23.MappingName = "divcode"
        Me.DataGridTextBoxColumn23.NullText = ""
        Me.DataGridTextBoxColumn23.Width = 45
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Description"
        Me.DataGridTextBoxColumn2.MappingName = "Division"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 200
        '
        'DataGridTextBoxColumn24
        '
        Me.DataGridTextBoxColumn24.Format = ""
        Me.DataGridTextBoxColumn24.FormatInfo = Nothing
        Me.DataGridTextBoxColumn24.MappingName = "createdate"
        Me.DataGridTextBoxColumn24.NullText = ""
        Me.DataGridTextBoxColumn24.Width = 0
        '
        'DataGridTextBoxColumn25
        '
        Me.DataGridTextBoxColumn25.Format = ""
        Me.DataGridTextBoxColumn25.FormatInfo = Nothing
        Me.DataGridTextBoxColumn25.MappingName = "updatedate"
        Me.DataGridTextBoxColumn25.NullText = ""
        Me.DataGridTextBoxColumn25.Width = 0
        '
        'DataGridTextBoxColumn26
        '
        Me.DataGridTextBoxColumn26.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn26.FormatInfo = Nothing
        Me.DataGridTextBoxColumn26.HeaderText = "Start Date"
        Me.DataGridTextBoxColumn26.MappingName = "startdate"
        Me.DataGridTextBoxColumn26.NullText = ""
        Me.DataGridTextBoxColumn26.Width = 70
        '
        'DataGridTextBoxColumn27
        '
        Me.DataGridTextBoxColumn27.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn27.FormatInfo = Nothing
        Me.DataGridTextBoxColumn27.HeaderText = "End Date"
        Me.DataGridTextBoxColumn27.MappingName = "enddate"
        Me.DataGridTextBoxColumn27.NullText = ""
        Me.DataGridTextBoxColumn27.Width = 70
        '
        'DataGridTextBoxColumn28
        '
        Me.DataGridTextBoxColumn28.Format = ""
        Me.DataGridTextBoxColumn28.FormatInfo = Nothing
        Me.DataGridTextBoxColumn28.MappingName = "lastuser"
        Me.DataGridTextBoxColumn28.NullText = ""
        Me.DataGridTextBoxColumn28.Width = 0
        '
        'DataGrid3
        '
        Me.DataGrid3.AccessibleRole = System.Windows.Forms.AccessibleRole.Row
        Me.DataGrid3.AlternatingBackColor = System.Drawing.Color.Aqua
        Me.DataGrid3.BackColor = System.Drawing.Color.Azure
        Me.DataGrid3.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.DataGrid3.CaptionText = "Division"
        Me.DataGrid3.DataMember = ""
        Me.DataGrid3.GridLineColor = System.Drawing.Color.CornflowerBlue
        Me.DataGrid3.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid3.Location = New System.Drawing.Point(433, 294)
        Me.DataGrid3.Name = "DataGrid3"
        Me.DataGrid3.SelectionBackColor = System.Drawing.Color.Navy
        Me.DataGrid3.SelectionForeColor = System.Drawing.Color.White
        Me.DataGrid3.Size = New System.Drawing.Size(422, 265)
        Me.DataGrid3.TabIndex = 82
        Me.DataGrid3.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.dgTabStyle6})
        '
        'dgTabStyle6
        '
        Me.dgTabStyle6.AlternatingBackColor = System.Drawing.Color.Aqua
        Me.dgTabStyle6.BackColor = System.Drawing.Color.Azure
        Me.dgTabStyle6.DataGrid = Me.DataGrid3
        Me.dgTabStyle6.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn29, Me.DataGridTextBoxColumn30, Me.DataGridTextBoxColumn31, Me.DataGridTextBoxColumn32, Me.DataGridTextBoxColumn33, Me.DataGridTextBoxColumn34, Me.DataGridTextBoxColumn35, Me.DataGridTextBoxColumn36})
        Me.dgTabStyle6.GridLineColor = System.Drawing.Color.CornflowerBlue
        Me.dgTabStyle6.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgTabStyle6.MappingName = "Sup_Div_Show"
        Me.dgTabStyle6.SelectionBackColor = System.Drawing.Color.Navy
        Me.dgTabStyle6.SelectionForeColor = System.Drawing.Color.White
        '
        'DataGridTextBoxColumn29
        '
        Me.DataGridTextBoxColumn29.Format = ""
        Me.DataGridTextBoxColumn29.FormatInfo = Nothing
        Me.DataGridTextBoxColumn29.MappingName = "rowid"
        Me.DataGridTextBoxColumn29.NullText = ""
        Me.DataGridTextBoxColumn29.Width = 0
        '
        'DataGridTextBoxColumn30
        '
        Me.DataGridTextBoxColumn30.Format = ""
        Me.DataGridTextBoxColumn30.FormatInfo = Nothing
        Me.DataGridTextBoxColumn30.HeaderText = "Code"
        Me.DataGridTextBoxColumn30.MappingName = "divcode"
        Me.DataGridTextBoxColumn30.NullText = ""
        Me.DataGridTextBoxColumn30.Width = 50
        '
        'DataGridTextBoxColumn31
        '
        Me.DataGridTextBoxColumn31.Format = ""
        Me.DataGridTextBoxColumn31.FormatInfo = Nothing
        Me.DataGridTextBoxColumn31.HeaderText = "Description"
        Me.DataGridTextBoxColumn31.MappingName = "division"
        Me.DataGridTextBoxColumn31.NullText = ""
        Me.DataGridTextBoxColumn31.Width = 200
        '
        'DataGridTextBoxColumn32
        '
        Me.DataGridTextBoxColumn32.Format = ""
        Me.DataGridTextBoxColumn32.FormatInfo = Nothing
        Me.DataGridTextBoxColumn32.MappingName = "createdate"
        Me.DataGridTextBoxColumn32.NullText = ""
        Me.DataGridTextBoxColumn32.Width = 0
        '
        'DataGridTextBoxColumn33
        '
        Me.DataGridTextBoxColumn33.Format = ""
        Me.DataGridTextBoxColumn33.FormatInfo = Nothing
        Me.DataGridTextBoxColumn33.MappingName = "updatedate"
        Me.DataGridTextBoxColumn33.NullText = ""
        Me.DataGridTextBoxColumn33.Width = 0
        '
        'DataGridTextBoxColumn34
        '
        Me.DataGridTextBoxColumn34.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn34.FormatInfo = Nothing
        Me.DataGridTextBoxColumn34.HeaderText = "Start Date"
        Me.DataGridTextBoxColumn34.MappingName = "startdate"
        Me.DataGridTextBoxColumn34.NullText = ""
        Me.DataGridTextBoxColumn34.Width = 70
        '
        'DataGridTextBoxColumn35
        '
        Me.DataGridTextBoxColumn35.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn35.FormatInfo = Nothing
        Me.DataGridTextBoxColumn35.HeaderText = "End Date"
        Me.DataGridTextBoxColumn35.MappingName = "enddate"
        Me.DataGridTextBoxColumn35.NullText = ""
        Me.DataGridTextBoxColumn35.Width = 70
        '
        'DataGridTextBoxColumn36
        '
        Me.DataGridTextBoxColumn36.Format = ""
        Me.DataGridTextBoxColumn36.FormatInfo = Nothing
        Me.DataGridTextBoxColumn36.MappingName = "lastuser"
        Me.DataGridTextBoxColumn36.NullText = ""
        Me.DataGridTextBoxColumn36.Width = 0
        '
        'txtRowidN
        '
        Me.txtRowidN.Location = New System.Drawing.Point(14, 320)
        Me.txtRowidN.Name = "txtRowidN"
        Me.txtRowidN.Size = New System.Drawing.Size(13, 20)
        Me.txtRowidN.TabIndex = 83
        Me.txtRowidN.Tag = "Input"
        Me.txtRowidN.Text = ""
        Me.txtRowidN.Visible = False
        '
        'txtRowidD
        '
        Me.txtRowidD.Location = New System.Drawing.Point(440, 319)
        Me.txtRowidD.Name = "txtRowidD"
        Me.txtRowidD.Size = New System.Drawing.Size(13, 20)
        Me.txtRowidD.TabIndex = 84
        Me.txtRowidD.Tag = "Input"
        Me.txtRowidD.Text = ""
        Me.txtRowidD.Visible = False
        '
        'aBtn
        '
        Me.aBtn.Location = New System.Drawing.Point(719, 10)
        Me.aBtn.Name = "aBtn"
        Me.aBtn.Size = New System.Drawing.Size(67, 19)
        Me.aBtn.TabIndex = 85
        Me.aBtn.Text = "Active only"
        '
        'oBtn
        '
        Me.oBtn.Location = New System.Drawing.Point(786, 10)
        Me.oBtn.Name = "oBtn"
        Me.oBtn.Size = New System.Drawing.Size(67, 19)
        Me.oBtn.TabIndex = 86
        Me.oBtn.Text = "View all"
        '
        'SupervisorCT
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(859, 607)
        Me.Controls.Add(Me.oBtn)
        Me.Controls.Add(Me.aBtn)
        Me.Controls.Add(Me.txtRowidD)
        Me.Controls.Add(Me.txtRowidN)
        Me.Controls.Add(Me.txtLastUser)
        Me.Controls.Add(Me.TxtEndDate)
        Me.Controls.Add(Me.TxtStartDate)
        Me.Controls.Add(Me.TxtResignDate)
        Me.Controls.Add(Me.TxtHireDate)
        Me.Controls.Add(Me.txtMobileNo)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.txtRowid)
        Me.Controls.Add(Me.DataGrid3)
        Me.Controls.Add(Me.DataGrid2)
        Me.Controls.Add(Me.SqlValue)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.cmdAddDiv)
        Me.Controls.Add(Me.cmdEditDiv)
        Me.Controls.Add(Me.cmdDeleteDiv)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdAddNSM)
        Me.Controls.Add(Me.cmdEditNSM)
        Me.Controls.Add(Me.cmdDeleteNSM)
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
        Me.Name = "SupervisorCT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "District Sales Manager maintenance"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim datNow As String, timNow As String, DatTimNow As String
        modControlBehavior.EnableControls(Me, True)
        ControlMaintenance.ClearInputControls(Me)
        EditMode = False
        'added-DBrion --v
        btnSw = True
        DatTimNow = GetDateTimeNow()
        datNow = Format(CDate(DatTimNow), "MM/dd/yyyy")
        timNow = Format(CDate(DatTimNow), "h:mm:ss tt")
        lblCreateDate.Text = datNow
        lblUpdateDate.Text = datNow
        TxtHireDate.Text = datNow
        tmpHD = Format(CDate(TxtHireDate.Text), "M/d/yyyy") & " " & timNow
        TxtStartDate.Text = Mid(datNow, 1, 2) & "/01/" & Year(CDate(datNow))
        tmpSD = Format(CDate(TxtStartDate.Text), "M/d/yyyy") & " " & timNow
        TxtEndDate.Text = "12/31/2078"
        tmpED = Format(CDate(TxtEndDate.Text), "M/d/yyyy") & " " & timNow
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
            If (MessageBox.Show("Do you really want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, _
            MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then
                Sub_Delete()
                ControlMaintenance.ClearInputControls(Me)
                DataGrid1.DataSource = Nothing
                Sub_Show()
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
            If Trim(txtCode.Text) = "" Or Trim(txtDescription.Text) = "" Or _
               Trim(TxtHireDate.Text) = ""  Then

                MessageBox.Show("One of the Mandatory fields has no value!", "Attention!")
                Exit Sub
            End If
            txtLastUser.Text = gCurrUser
            'added-DBrion --^
            If EditMode = False Then
                Sub_Insert()
            Else
                Sub_Update()
            End If
            'Sub_Show()                 '<--commented-DBrion
            Sub_Select(Params, CStr(IIf(EditMode = False, "Insert", "Update")))
            EditMode = False
            modControlBehavior.EnableControls(Me, False)
            DataGrid1.DataSource = Nothing    'added-DBrion --v     to refresh and enable again 
            Sub_Show()                        'added-DBrion --^     the scrollbar
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Sub_Insert()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(8) As SqlParameter

        Dim SupCode As New SqlParameter("@SupCode", SqlDbType.VarChar, 25)
        SupCode.Direction = ParameterDirection.Input
        SupCode.Value = Trim(txtCode.Text)
        Params(0) = SupCode

        Dim SupName As New SqlParameter("@SupName", SqlDbType.VarChar, 100)
        SupName.Direction = ParameterDirection.Input
        SupName.Value = Trim(txtDescription.Text)
        Params(1) = SupName

        Dim Hire_Date As New SqlParameter("@Hire_Date", SqlDbType.DateTime, 10)
        Hire_Date.Direction = ParameterDirection.Input
        Hire_Date.Value = Trim(TxtHireDate.Text)
        Params(2) = Hire_Date

        Dim Resign_Date As New SqlParameter("@Resign_Date", SqlDbType.DateTime, 10)
        Resign_Date.Direction = ParameterDirection.Input
        If Trim(TxtResignDate.Text) = "" Then
            Resign_Date.Value = DBNull.Value
        Else
            Resign_Date.Value = Trim(TxtResignDate.Text)
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

        Dim Email As New SqlParameter("@Email", SqlDbType.VarChar, 75)
        Email.Direction = ParameterDirection.Input
        Email.Value = Trim(txtEmail.Text)
        Params(6) = Email

        Dim MobileNo As New SqlParameter("@MobileNo", SqlDbType.VarChar, 50)
        MobileNo.Direction = ParameterDirection.Input
        MobileNo.Value = Trim(txtMobileNo.Text)
        Params(7) = MobileNo

        'Dim StartDate As New SqlParameter("@StartDate", SqlDbType.DateTime, 10)
        'StartDate.Direction = ParameterDirection.Input
        'StartDate.Value = Trim(TxtStartDate.Text)
        'Params(8) = StartDate

        'If Trim(TxtResignDate.Text) <> "" Then
        '    tmpED = Trim(TxtResignDate.Text)
        'End If
        'Dim EndDate As New SqlParameter("@EndDate", SqlDbType.DateTime, 10)
        'EndDate.Direction = ParameterDirection.Input
        'EndDate.Value = tmpED
        'Params(9) = EndDate

        Dim LastUser As New SqlParameter("@LastUser", SqlDbType.VarChar, 10)
        LastUser.Direction = ParameterDirection.Input
        LastUser.Value = IIf(Trim(gCurrUser) = "", "", gCurrUser)       ' Trim(txtLastUser.Text)
        Params(8) = LastUser

        Try
            BusinessObject.Sub_Insert(ServerPath2, "SupervisorCT_Insert", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Sub_Update()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(7) As SqlParameter

        Dim Rowid As New SqlParameter("@Rowid", SqlDbType.Int)
        Rowid.Direction = ParameterDirection.Input
        Rowid.Value = Val(txtRowid.Text)
        Params(0) = Rowid
        Dim SupName As New SqlParameter("@SupName", SqlDbType.VarChar, 100)
        SupName.Direction = ParameterDirection.Input
        SupName.Value = Trim(txtDescription.Text)
        Params(1) = SupName

        Dim Hire_Date As New SqlParameter("@Hire_Date", SqlDbType.DateTime, 10)
        Hire_Date.Direction = ParameterDirection.Input
        Hire_Date.Value = Trim(TxtHireDate.Text)
        Params(2) = Hire_Date

        Dim Resign_Date As New SqlParameter("@Resign_Date", SqlDbType.DateTime, 10)
        Resign_Date.Direction = ParameterDirection.Input
        If Trim(TxtResignDate.Text) = "" Then
            Resign_Date.Value = DBNull.Value
        Else
            Resign_Date.Value = Trim(TxtResignDate.Text)
        End If
        Params(3) = Resign_Date

        'Dim CreateDate As New SqlParameter("@CreateDate", SqlDbType.DateTime, 10)
        'CreateDate.Direction = ParameterDirection.Input
        'CreateDate.Value = GetDateTimeNow()
        'Params(4) = CreateDate

        Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime, 10)
        UpdateDate.Direction = ParameterDirection.Input
        UpdateDate.Value = GetDateTimeNow()
        Params(4) = UpdateDate

        Dim Email As New SqlParameter("@Email", SqlDbType.VarChar, 75)
        Email.Direction = ParameterDirection.Input
        Email.Value = Trim(txtEmail.Text)
        Params(5) = Email

        Dim MobileNo As New SqlParameter("@MobileNo", SqlDbType.VarChar, 50)
        MobileNo.Direction = ParameterDirection.Input
        MobileNo.Value = Trim(txtMobileNo.Text)
        Params(6) = MobileNo

        'Dim StartDate As New SqlParameter("@StartDate", SqlDbType.DateTime, 10)
        'StartDate.Direction = ParameterDirection.Input
        'StartDate.Value = Trim(TxtStartDate.Text)
        'Params(7) = StartDate

        'If Trim(TxtResignDate.Text) <> "" Then
        '    tmpED = Trim(TxtResignDate.Text)
        'End If
        'Dim EndDate As New SqlParameter("@EndDate", SqlDbType.DateTime, 10)
        'EndDate.Direction = ParameterDirection.Input
        'EndDate.Value = Trim(TxtEndDate.Text)
        'Params(8) = EndDate

        Dim LastUser As New SqlParameter("@LastUser", SqlDbType.VarChar, 10)
        LastUser.Direction = ParameterDirection.Input
        LastUser.Value = IIf(Trim(gCurrUser) = "", "", gCurrUser)      ' Trim(txtLastUser.Text)
        Params(7) = LastUser

        Try
            BusinessObject.Sub_Update(ServerPath2, "SupervisorCT_Update", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Sub_Show()
        If RemoteDataSet.SupervisorCT_Show.Count > 0 Then RemoteDataSet.SupervisorCT_Show.Clear()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "SupervisorCT_Show", CommandType.StoredProcedure, RemoteDataSet, "SupervisorCT_Show")
        DataGrid1.DataSource = RemoteDataSet.SupervisorCT_Show
    End Sub

    Private Sub Sub_Show2()
        If RemoteDataSet.SupervisorCT_Show.Count > 0 Then RemoteDataSet.SupervisorCT_Show.Clear()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "SupervisorCT2_Show", CommandType.StoredProcedure, RemoteDataSet, "SupervisorCT_Show")
        DataGrid1.DataSource = RemoteDataSet.SupervisorCT_Show
    End Sub

    Private Sub Sub_Div_Show()
        DataGrid3.DataSource = Nothing
        RemoteDataSet2.Sup_Div_Show.Clear()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter

        Dim SupCode As New SqlParameter("@SupCode", SqlDbType.VarChar, 10)
        SupCode.Direction = ParameterDirection.Input
        SupCode.Value = Trim(txtCode.Text)
        Params(0) = SupCode

        Try
            BusinessObject.Sub_Show(ServerPath2, "SupervisorCT_Div_Show", CommandType.StoredProcedure, _
                                    RemoteDataSet2, "Sup_Div_Show", Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        DataGrid3.DataSource = RemoteDataSet2.Sup_Div_Show
        DataGrid3.Update()
    End Sub

    Private Sub Sub_Nsm_Show()
        DataGrid2.DataSource = Nothing
        RemoteDataSet2.Sup_NSM_Show.Clear()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter

        Dim SupCode As New SqlParameter("@SupCode", SqlDbType.VarChar, 10)
        SupCode.Direction = ParameterDirection.Input
        SupCode.Value = Trim(txtCode.Text)
        Params(0) = SupCode

        Try
            BusinessObject.Sub_Show(ServerPath2, "SupervisorCT_Nsm_Show", CommandType.StoredProcedure, _
                                    RemoteDataSet2, "Sup_NSM_Show", Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        DataGrid2.DataSource = RemoteDataSet2.Sup_NSM_Show
        DataGrid2.Update()
    End Sub

    Private Sub Sub_Select(ByVal dbParams() As String, ByVal UpdateMode As String)
        'select case if add,edit or delete
        Dim i As Integer
        Dim myRowid As Integer
        Select Case UpdateMode
            Case "Insert"
                Dim BusinessObject As New BusinessLayer.clsFileMaintenance
                myRowid = CInt(BusinessObject.Sub_ReturnIntegerResult(ServerPath2, "SupervisorCT_GetInsertedRowid", CommandType.StoredProcedure))
            Case "Update"
                myRowid = CInt(dbParams(0))
        End Select
        For i = 0 To (RemoteDataSet.SupervisorCT_Show.Rows.Count - 1)
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
        Dim SupCode As New SqlParameter("@SupCode", SqlDbType.Int)
        SupCode.Direction = ParameterDirection.Input
        SupCode.Value = IIf(Trim(txtCode.Text) = "", Val(txtCode.Text), Trim(txtCode.Text))
        Params(0) = SupCode
        BusinessObject.Sub_Delete(ServerPath2, "SupervisorCT_Delete", CommandType.StoredProcedure, Params)
    End Sub

    Private Sub Sub_NSM_Delete()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter
        Dim Rowid As New SqlParameter("@Rowid", SqlDbType.Int)
        Rowid.Direction = ParameterDirection.Input
        Rowid.Value = txtRowidN.Text
        Params(0) = Rowid
        BusinessObject.Sub_Delete(ServerPath2, "SupervisorCT_NSM_Delete", CommandType.StoredProcedure, Params)
    End Sub

    Private Sub Sub_Div_Delete()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter
        Dim Rowid As New SqlParameter("@Rowid", SqlDbType.Int)
        Rowid.Direction = ParameterDirection.Input
        Rowid.Value = txtRowidD.Text
        Params(0) = Rowid
        BusinessObject.Sub_Delete(ServerPath2, "SupervisorCT_Div_Delete", CommandType.StoredProcedure, Params)
    End Sub

    Private Sub SupervisorCT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            txtEmail.Text = .Item(.CurrentCell.RowNumber, 5).ToString
            txtMobileNo.Text = .Item(.CurrentCell.RowNumber, 6).ToString
            If Trim(.Item(.CurrentCell.RowNumber, 7).ToString) <> "" Then
                lblCreateDate.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 7).ToString), "MM/dd/yyyy")
            Else
                lblCreateDate.Text = ""
            End If
            If Trim(.Item(.CurrentCell.RowNumber, 8).ToString) <> "" Then
                lblUpdateDate.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 8).ToString), "MM/dd/yyyy")
            Else
                lblUpdateDate.Text = ""
            End If
            If Trim(.Item(.CurrentCell.RowNumber, 9).ToString) <> "" Then
                TxtStartDate.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 9).ToString), "MM/dd/yyyy")
            Else
                TxtStartDate.Text = ""
            End If
            If Trim(.Item(.CurrentCell.RowNumber, 10).ToString) <> "" Then   '<v--added to ".ToString"
                TxtEndDate.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 10).ToString), "MM/dd/yyyy")
            Else
                TxtEndDate.Text = ""
            End If
            txtLastUser.Text = .Item(.CurrentCell.RowNumber, 11).ToString
        End With
        Sub_Nsm_Show()
        Sub_Div_Show()
    End Sub

    'added-DBrion --v

    Private Sub txtCode_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.Click
        txtCode.SelectAll()
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
        If btnSw = True And EditMode = False Then
            s = "select supname as fld1 from NewScores..supervisor where supcode = '" & Trim(txtCode.Text) & "' "
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
                MessageBox.Show("This DSM Code already exist! Please try again.", "DSM Exsists!")
                e.Cancel = True
                txtCode.Clear()
            End If
            SqlValue.ResetText()
            SqlValue.DataSource = Nothing
            RemoteDataSet2.GenericQryProc.Clear()
        End If
    End Sub

    Private Sub txtDescription_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescription.Click
        txtDescription.SelectAll()
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
        If btnSw = True And Trim(txtDescription.Text) <> Trim(oldDs) Then
            s = "select supcode as fld1 from NewScores..supervisor where supname = '" & Trim(txtDescription.Text) & "' "
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
                MessageBox.Show("This DSM name already exist! Please try again.", "DSM Exsists!")
                e.Cancel = True
                txtDescription.Clear()
            End If
            SqlValue.ResetText()
            SqlValue.DataSource = Nothing
            RemoteDataSet2.GenericQryProc.Clear()
        End If
    End Sub

    Private Sub TxtHireDate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtHireDate.Click
        TxtHireDate.SelectAll()
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

    Private Sub TxtResignDate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtResignDate.Click
        TxtResignDate.SelectAll()
    End Sub

    Private Sub TxtResignDate_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtResignDate.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TxtResignDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtResignDate.Validating
        On Error GoTo errpt
        If jTrim(TxtResignDate.Text) = "" Then
            TxtEndDate.Text = "12/31/2078"
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
                    TxtEndDate.Text = Trim(TxtResignDate.Text)
                End If
            Else
                MessageBox.Show("There must be a Hire Date before you can enter a Resign Date.")
            End If
        End If
        Exit Sub
errpt:
        e.Cancel = True
    End Sub

    Private Sub txtEmail_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmail.Click
        txtEmail.SelectAll()
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
        If InStr(jTrim(txtEmail.Text), "@") = 0 And InStr(jTrim(txtEmail.Text), ".") = 0 Then
            MessageBox.Show("Invalid email address!")
            e.Cancel = True
            txtEmail.SelectAll()
            Exit Sub
        End If
    End Sub

    Private Sub txtMobileNo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMobileNo.Click
        txtMobileNo.SelectAll()
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

    Private Sub TxtStartDate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtStartDate.Click
        TxtStartDate.SelectAll()
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

    Private Sub TxtEndDate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtEndDate.Click
        TxtEndDate.SelectAll()
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

    Private Sub cmdAddNSM_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAddNSM.Click
        Dim MyLoadedForm As New SupNSM
        Dim datNow As String
        Itm_EditMode = False
        datNow = GetDateTimeNow("MM/dd/yyyy")
        MyLoadedForm.txtRowid.Text = Trim(txtRowid.Text)
        MyLoadedForm.txtSupCode.Text = jTrim(txtCode.Text)
        MyLoadedForm.txtStartDate.Text = Mid(datNow, 1, 2) & "/01/" & Mid(datNow, 7, 4)
        MyLoadedForm.txtEndDate.Text = "12/31/2078"
        MyLoadedForm.txtCreateDate.Text = datNow
        MyLoadedForm.txtUpdateDate.Text = datNow
        MyLoadedForm.txtLastUser.Text = jTrim(txtLastUser.Text)
        MyLoadedForm.ShowDialog(Me)
        Sub_Nsm_Show()
    End Sub

    Private Sub cmdEditNSM_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdEditNSM.Click
        Dim MyLoadedForm As New SupNSM
        Dim tmpDate As String
        Dim s As String
        With DataGrid2
            MyLoadedForm.txtRowid.Text = .Item(.CurrentCell.RowNumber, 0).ToString
            MyLoadedForm.txtSupCode.Text = Trim(txtCode.Text)
            MyLoadedForm.cboNSM.Text = (.Item(.CurrentCell.RowNumber, 1).ToString) & "--" & (.Item(.CurrentCell.RowNumber, 2).ToString)
            tmpDate = .Item(.CurrentCell.RowNumber, 3).ToString
            If Trim(tmpDate) <> "" Then
                MyLoadedForm.txtCreateDate.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
            End If
            tmpDate = .Item(.CurrentCell.RowNumber, 4).ToString
            If Trim(tmpDate) <> "" Then
                MyLoadedForm.txtUpdateDate.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
            End If
            tmpDate = .Item(.CurrentCell.RowNumber, 5).ToString
            If Trim(tmpDate) <> "" Then
                MyLoadedForm.txtStartDate.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
            End If
            tmpDate = .Item(.CurrentCell.RowNumber, 6).ToString
            If Trim(tmpDate) <> "" Then
                MyLoadedForm.txtEndDate.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
            End If
            MyLoadedForm.txtLastUser.Text = .Item(.CurrentCell.RowNumber, 7).ToString
        End With
        Itm_EditMode = True
        MyLoadedForm.ShowDialog(Me)
        Me.Refresh()
        Sub_Nsm_Show()
    End Sub

    Private Sub cmdDeleteNSM_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDeleteNSM.Click
        If txtRowidN.Text > "" Then
            If (MessageBox.Show("Do you really want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, _
            MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then
                Sub_NSM_Delete()
                DataGrid2.DataSource = Nothing
                RemoteDataSet2.Sup_NSM_Show.Clear()
                Sub_Nsm_Show()
            End If
        End If
    End Sub

    Private Sub DataGrid2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid2.Click, DataGrid2.CurrentCellChanged
        txtRowidN.Text = DataGrid2.Item(DataGrid2.CurrentCell.RowNumber, 0).ToString
    End Sub

    Private Sub DataGrid3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid3.Click, DataGrid3.CurrentCellChanged
        txtRowidD.Text = DataGrid3.Item(DataGrid3.CurrentCell.RowNumber, 0).ToString
    End Sub

    Private Sub cmdAddDiv_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAddDiv.Click
        Dim MyLoadedForm As New SupDiv
        Dim datNow As String
        Itm_EditMode = False
        datNow = GetDateTimeNow("MM/dd/yyyy")
        MyLoadedForm.txtRowid.Text = Trim(txtRowid.Text)
        MyLoadedForm.txtSupCode.Text = jTrim(txtCode.Text)
        MyLoadedForm.txtStartDate.Text = Mid(datNow, 1, 2) & "/01/" & Mid(datNow, 7, 4)
        MyLoadedForm.txtEndDate.Text = "12/31/2078"
        MyLoadedForm.txtCreateDate.Text = datNow
        MyLoadedForm.txtUpdateDate.Text = datNow
        MyLoadedForm.txtLastUser.Text = jTrim(txtLastUser.Text)
        MyLoadedForm.ShowDialog(Me)
        Sub_Div_Show()
    End Sub

    Private Sub cmdEditDiv_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdEditDiv.Click
        Dim MyLoadedForm As New SupDiv
        Dim tmpDate As String
        Dim s As String
        With DataGrid3
            MyLoadedForm.txtRowid.Text = .Item(.CurrentCell.RowNumber, 0).ToString
            MyLoadedForm.txtSupCode.Text = Trim(txtCode.Text)
            MyLoadedForm.cboDiv.Text = (.Item(.CurrentCell.RowNumber, 1).ToString) & "--" & (.Item(.CurrentCell.RowNumber, 2).ToString)
            tmpDate = .Item(.CurrentCell.RowNumber, 3).ToString
            If Trim(tmpDate) <> "" Then
                MyLoadedForm.txtCreateDate.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
            End If
            tmpDate = .Item(.CurrentCell.RowNumber, 4).ToString
            If Trim(tmpDate) <> "" Then
                MyLoadedForm.txtUpdateDate.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
            End If
            tmpDate = .Item(.CurrentCell.RowNumber, 5).ToString
            If Trim(tmpDate) <> "" Then
                MyLoadedForm.txtStartDate.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
            End If
            tmpDate = .Item(.CurrentCell.RowNumber, 6).ToString
            If Trim(tmpDate) <> "" Then
                MyLoadedForm.txtEndDate.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
            End If
            MyLoadedForm.txtLastUser.Text = .Item(.CurrentCell.RowNumber, 7).ToString
        End With
        Itm_EditMode = True
        MyLoadedForm.ShowDialog(Me)
        Me.Refresh()
        Sub_Div_Show()
    End Sub

    Private Sub cmdDeleteDiv_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDeleteDiv.Click
        If txtRowidD.Text > "" Then
            If (MessageBox.Show("Do you really want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, _
            MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then
                Sub_Div_Delete()
                DataGrid3.DataSource = Nothing
                RemoteDataSet2.Sup_Div_Show.Clear()
                Sub_Div_Show()
            End If
        End If
    End Sub

    Private Sub oBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles oBtn.Click
        Sub_Show2()
    End Sub

    Private Sub aBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aBtn.Click
        Sub_Show()
    End Sub
End Class
