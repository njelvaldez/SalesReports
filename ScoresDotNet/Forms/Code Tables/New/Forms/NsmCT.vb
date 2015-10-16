Imports System.Data.SqlClient
Imports Microsoft
Public Class NsmCT
    Inherits System.Windows.Forms.Form
    Private RemoteDataSet As New CodeTablesDS
    Private RemoteDataSet2 As New MyDataSetDB
    Private EditMode As Boolean = False
    Private oldDs As String, tmpSD As String, tmpED As String  '<-- added-DBrion
    Private tmpHD As String, tmpRD As String                   '<-- added-DBrion
    Private NSMdv As String, NsmCodeDV As String
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox

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
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
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
    Friend WithEvents SqlValue As System.Windows.Forms.ComboBox
    Friend WithEvents DataGrid2 As System.Windows.Forms.DataGrid
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cboDivisionDV As System.Windows.Forms.ComboBox
    Friend WithEvents txtEnd_DateDV As System.Windows.Forms.TextBox
    Friend WithEvents txtStart_DateDV As System.Windows.Forms.TextBox
    Friend WithEvents lblUpdateDateDV As System.Windows.Forms.Label
    Friend WithEvents lblCreateDateDV As System.Windows.Forms.Label
    Friend WithEvents cmdExitDV As System.Windows.Forms.Button
    Friend WithEvents cmdAddDV As System.Windows.Forms.Button
    Friend WithEvents cmdEditDV As System.Windows.Forms.Button
    Friend WithEvents cmdCancelDV As System.Windows.Forms.Button
    Friend WithEvents cmdDeleteDV As System.Windows.Forms.Button
    Friend WithEvents cmdSaveDV As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents dgDivision1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgDivCode1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgRowid1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgStart_Date1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgEnd_Date1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgCreateDate1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgUpdateDate1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgLastUser1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents txtRowidDV As System.Windows.Forms.TextBox
    Friend WithEvents txtNsmCodeDV As System.Windows.Forms.TextBox
    Friend WithEvents txtNSMdv As System.Windows.Forms.TextBox
    Friend WithEvents txtDivision As System.Windows.Forms.TextBox
    Friend WithEvents btnPicturePath As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtPicturePath As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtEmpNo As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtMobileNo As System.Windows.Forms.TextBox
    Friend WithEvents txtDimCode As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn15 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn16 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn17 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NsmCT))
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
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn17 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.txtRowid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboDivisionDV = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtLastUser = New System.Windows.Forms.TextBox()
        Me.TxtHireDate = New System.Windows.Forms.TextBox()
        Me.TxtResignDate = New System.Windows.Forms.TextBox()
        Me.TxtStartDate = New System.Windows.Forms.TextBox()
        Me.TxtEndDate = New System.Windows.Forms.TextBox()
        Me.SqlValue = New System.Windows.Forms.ComboBox()
        Me.DataGrid2 = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle()
        Me.dgDivision1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.dgDivCode1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.dgRowid1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.dgStart_Date1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.dgEnd_Date1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.dgCreateDate1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.dgUpdateDate1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.dgLastUser1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.txtEnd_DateDV = New System.Windows.Forms.TextBox()
        Me.txtStart_DateDV = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblUpdateDateDV = New System.Windows.Forms.Label()
        Me.lblCreateDateDV = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtRowidDV = New System.Windows.Forms.TextBox()
        Me.cmdExitDV = New System.Windows.Forms.Button()
        Me.cmdAddDV = New System.Windows.Forms.Button()
        Me.cmdEditDV = New System.Windows.Forms.Button()
        Me.cmdCancelDV = New System.Windows.Forms.Button()
        Me.cmdDeleteDV = New System.Windows.Forms.Button()
        Me.cmdSaveDV = New System.Windows.Forms.Button()
        Me.txtNsmCodeDV = New System.Windows.Forms.TextBox()
        Me.txtNSMdv = New System.Windows.Forms.TextBox()
        Me.txtDivision = New System.Windows.Forms.TextBox()
        Me.btnPicturePath = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPicturePath = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDimCode = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtEmpNo = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMobileNo = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(170, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Code :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(170, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(376, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Create Date :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(378, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Update Date :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(247, 93)
        Me.txtCode.MaxLength = 25
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(95, 20)
        Me.txtCode.TabIndex = 0
        Me.txtCode.Tag = "Input"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(247, 127)
        Me.txtDescription.MaxLength = 75
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(331, 20)
        Me.txtDescription.TabIndex = 1
        Me.txtDescription.Tag = "Input"
        '
        'lblCreateDate
        '
        Me.lblCreateDate.BackColor = System.Drawing.SystemColors.Info
        Me.lblCreateDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCreateDate.Location = New System.Drawing.Point(472, 20)
        Me.lblCreateDate.Name = "lblCreateDate"
        Me.lblCreateDate.Size = New System.Drawing.Size(68, 20)
        Me.lblCreateDate.TabIndex = 10
        Me.lblCreateDate.Tag = "Input"
        '
        'lblUpdateDate
        '
        Me.lblUpdateDate.BackColor = System.Drawing.SystemColors.Info
        Me.lblUpdateDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUpdateDate.Location = New System.Drawing.Point(472, 57)
        Me.lblUpdateDate.Name = "lblUpdateDate"
        Me.lblUpdateDate.Size = New System.Drawing.Size(68, 20)
        Me.lblUpdateDate.TabIndex = 11
        Me.lblUpdateDate.Tag = "Input"
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(247, 470)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(74, 36)
        Me.cmdExit.TabIndex = 15
        Me.cmdExit.Tag = "Exit"
        Me.cmdExit.Text = "E&xit"
        '
        'cmdAdd
        '
        Me.cmdAdd.Image = CType(resources.GetObject("cmdAdd.Image"), System.Drawing.Image)
        Me.cmdAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAdd.Location = New System.Drawing.Point(17, 470)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(74, 36)
        Me.cmdAdd.TabIndex = 12
        Me.cmdAdd.Tag = "Add"
        Me.cmdAdd.Text = "      &Add"
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdEdit.Location = New System.Drawing.Point(93, 470)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(74, 36)
        Me.cmdEdit.TabIndex = 13
        Me.cmdEdit.Tag = "Edit"
        Me.cmdEdit.Text = "      &Edit"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(91, 470)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(74, 36)
        Me.cmdCancel.TabIndex = 12
        Me.cmdCancel.Tag = "Cancel"
        Me.cmdCancel.Text = "&Cancel"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDelete.Location = New System.Drawing.Point(170, 470)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(74, 36)
        Me.cmdDelete.TabIndex = 14
        Me.cmdDelete.Tag = "Delete"
        Me.cmdDelete.Text = "      &Del"
        '
        'cmdSave
        '
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSave.Location = New System.Drawing.Point(169, 470)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(74, 36)
        Me.cmdSave.TabIndex = 13
        Me.cmdSave.Tag = "Save"
        Me.cmdSave.Text = "      &Save"
        '
        'DataGrid1
        '
        Me.DataGrid1.CaptionText = "Segment Head"
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(14, 262)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(1290, 205)
        Me.DataGrid1.TabIndex = 0
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.DataGrid1.Tag = "View"
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Aqua
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightCyan
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn16, Me.DataGridTextBoxColumn17})
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.AntiqueWhite
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "NsmCT_Show"
        Me.DataGridTableStyle1.ReadOnly = True
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.MappingName = "Rowid"
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Code"
        Me.DataGridTextBoxColumn2.MappingName = "NsmCode"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 45
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Name"
        Me.DataGridTextBoxColumn3.MappingName = "NsmName"
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
        Me.DataGridTextBoxColumn6.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Hire Date"
        Me.DataGridTextBoxColumn6.MappingName = "Hire_Date"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 65
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = "MM/dd/yyyy"
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
        Me.DataGridTextBoxColumn11.Width = 0
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "Start Date"
        Me.DataGridTextBoxColumn12.MappingName = "StartDate"
        Me.DataGridTextBoxColumn12.NullText = ""
        Me.DataGridTextBoxColumn12.Width = 65
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "End Date"
        Me.DataGridTextBoxColumn13.MappingName = "EndDate"
        Me.DataGridTextBoxColumn13.NullText = ""
        Me.DataGridTextBoxColumn13.Width = 65
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Create Date"
        Me.DataGridTextBoxColumn4.MappingName = "CreateDate"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 65
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Update Date"
        Me.DataGridTextBoxColumn5.MappingName = "UpdateDate"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.ReadOnly = True
        Me.DataGridTextBoxColumn5.Width = 65
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "Dimension Code"
        Me.DataGridTextBoxColumn15.MappingName = "DimCode"
        Me.DataGridTextBoxColumn15.Width = 75
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Format = ""
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.HeaderText = "Employee No"
        Me.DataGridTextBoxColumn16.MappingName = "Emp_No"
        Me.DataGridTextBoxColumn16.Width = 75
        '
        'DataGridTextBoxColumn17
        '
        Me.DataGridTextBoxColumn17.Format = ""
        Me.DataGridTextBoxColumn17.FormatInfo = Nothing
        Me.DataGridTextBoxColumn17.HeaderText = "Picture Path"
        Me.DataGridTextBoxColumn17.MappingName = "PicturePath"
        Me.DataGridTextBoxColumn17.Width = 75
        '
        'txtRowid
        '
        Me.txtRowid.Location = New System.Drawing.Point(20, 442)
        Me.txtRowid.Name = "txtRowid"
        Me.txtRowid.Size = New System.Drawing.Size(16, 20)
        Me.txtRowid.TabIndex = 43
        Me.txtRowid.Tag = "Input"
        Me.txtRowid.Visible = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(9, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 20)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Hire Date :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(9, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 20)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Resign Date :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboDivisionDV
        '
        Me.cboDivisionDV.Location = New System.Drawing.Point(1074, 539)
        Me.cboDivisionDV.MaxLength = 55
        Me.cboDivisionDV.Name = "cboDivisionDV"
        Me.cboDivisionDV.Size = New System.Drawing.Size(222, 21)
        Me.cboDivisionDV.TabIndex = 16
        Me.cboDivisionDV.Tag = "Input"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(1006, 538)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 21)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Segment :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(9, 165)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 20)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Start Date :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(9, 200)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 20)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "End Date :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtLastUser
        '
        Me.TxtLastUser.Location = New System.Drawing.Point(40, 442)
        Me.TxtLastUser.Name = "TxtLastUser"
        Me.TxtLastUser.Size = New System.Drawing.Size(48, 20)
        Me.TxtLastUser.TabIndex = 61
        Me.TxtLastUser.Tag = "Input"
        Me.TxtLastUser.Visible = False
        '
        'TxtHireDate
        '
        Me.TxtHireDate.Location = New System.Drawing.Point(107, 91)
        Me.TxtHireDate.MaxLength = 10
        Me.TxtHireDate.Name = "TxtHireDate"
        Me.TxtHireDate.Size = New System.Drawing.Size(68, 20)
        Me.TxtHireDate.TabIndex = 6
        Me.TxtHireDate.Tag = "Input"
        '
        'TxtResignDate
        '
        Me.TxtResignDate.Location = New System.Drawing.Point(107, 126)
        Me.TxtResignDate.MaxLength = 10
        Me.TxtResignDate.Name = "TxtResignDate"
        Me.TxtResignDate.Size = New System.Drawing.Size(68, 20)
        Me.TxtResignDate.TabIndex = 7
        Me.TxtResignDate.Tag = "Input"
        '
        'TxtStartDate
        '
        Me.TxtStartDate.Location = New System.Drawing.Point(107, 161)
        Me.TxtStartDate.MaxLength = 10
        Me.TxtStartDate.Name = "TxtStartDate"
        Me.TxtStartDate.Size = New System.Drawing.Size(68, 20)
        Me.TxtStartDate.TabIndex = 8
        Me.TxtStartDate.Tag = "Input"
        '
        'TxtEndDate
        '
        Me.TxtEndDate.Location = New System.Drawing.Point(107, 196)
        Me.TxtEndDate.MaxLength = 10
        Me.TxtEndDate.Name = "TxtEndDate"
        Me.TxtEndDate.Size = New System.Drawing.Size(68, 20)
        Me.TxtEndDate.TabIndex = 9
        Me.TxtEndDate.Tag = "Input"
        '
        'SqlValue
        '
        Me.SqlValue.Location = New System.Drawing.Point(92, 442)
        Me.SqlValue.Name = "SqlValue"
        Me.SqlValue.Size = New System.Drawing.Size(146, 21)
        Me.SqlValue.TabIndex = 65
        Me.SqlValue.Visible = False
        '
        'DataGrid2
        '
        Me.DataGrid2.CaptionText = "Segement Head's Division"
        Me.DataGrid2.DataMember = ""
        Me.DataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid2.Location = New System.Drawing.Point(13, 512)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.ReadOnly = True
        Me.DataGrid2.Size = New System.Drawing.Size(969, 148)
        Me.DataGrid2.TabIndex = 66
        Me.DataGrid2.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        Me.DataGrid2.Tag = "View"
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.DataGrid2
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.dgDivision1, Me.dgDivCode1, Me.dgRowid1, Me.dgStart_Date1, Me.dgEnd_Date1, Me.dgCreateDate1, Me.dgUpdateDate1, Me.dgLastUser1})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "GenericQryProc"
        '
        'dgDivision1
        '
        Me.dgDivision1.Format = ""
        Me.dgDivision1.FormatInfo = Nothing
        Me.dgDivision1.HeaderText = "Segment"
        Me.dgDivision1.MappingName = "fld1"
        Me.dgDivision1.NullText = ""
        Me.dgDivision1.Width = 180
        '
        'dgDivCode1
        '
        Me.dgDivCode1.Format = ""
        Me.dgDivCode1.FormatInfo = Nothing
        Me.dgDivCode1.MappingName = "fld2"
        Me.dgDivCode1.NullText = ""
        Me.dgDivCode1.Width = 0
        '
        'dgRowid1
        '
        Me.dgRowid1.Format = ""
        Me.dgRowid1.FormatInfo = Nothing
        Me.dgRowid1.MappingName = "fld3"
        Me.dgRowid1.NullText = ""
        Me.dgRowid1.Width = 0
        '
        'dgStart_Date1
        '
        Me.dgStart_Date1.Format = ""
        Me.dgStart_Date1.FormatInfo = Nothing
        Me.dgStart_Date1.HeaderText = "Start Date"
        Me.dgStart_Date1.MappingName = "fld4"
        Me.dgStart_Date1.NullText = ""
        Me.dgStart_Date1.Width = 75
        '
        'dgEnd_Date1
        '
        Me.dgEnd_Date1.Format = "MM/dd/yyyy"
        Me.dgEnd_Date1.FormatInfo = Nothing
        Me.dgEnd_Date1.HeaderText = "End Date"
        Me.dgEnd_Date1.MappingName = "fld5"
        Me.dgEnd_Date1.NullText = ""
        Me.dgEnd_Date1.Width = 75
        '
        'dgCreateDate1
        '
        Me.dgCreateDate1.Format = "MM/dd/yyyy"
        Me.dgCreateDate1.FormatInfo = Nothing
        Me.dgCreateDate1.MappingName = "fld6"
        Me.dgCreateDate1.NullText = ""
        Me.dgCreateDate1.Width = 0
        '
        'dgUpdateDate1
        '
        Me.dgUpdateDate1.Format = "MM/dd/yyyy"
        Me.dgUpdateDate1.FormatInfo = Nothing
        Me.dgUpdateDate1.MappingName = "fld7"
        Me.dgUpdateDate1.NullText = ""
        Me.dgUpdateDate1.Width = 0
        '
        'dgLastUser1
        '
        Me.dgLastUser1.Format = ""
        Me.dgLastUser1.FormatInfo = Nothing
        Me.dgLastUser1.HeaderText = "Encoder"
        Me.dgLastUser1.MappingName = "fld8"
        Me.dgLastUser1.NullText = ""
        Me.dgLastUser1.Width = 75
        '
        'txtEnd_DateDV
        '
        Me.txtEnd_DateDV.Location = New System.Drawing.Point(1074, 595)
        Me.txtEnd_DateDV.MaxLength = 10
        Me.txtEnd_DateDV.Name = "txtEnd_DateDV"
        Me.txtEnd_DateDV.Size = New System.Drawing.Size(68, 20)
        Me.txtEnd_DateDV.TabIndex = 18
        Me.txtEnd_DateDV.Tag = "Input"
        '
        'txtStart_DateDV
        '
        Me.txtStart_DateDV.Location = New System.Drawing.Point(1074, 567)
        Me.txtStart_DateDV.MaxLength = 10
        Me.txtStart_DateDV.Name = "txtStart_DateDV"
        Me.txtStart_DateDV.Size = New System.Drawing.Size(68, 20)
        Me.txtStart_DateDV.TabIndex = 17
        Me.txtStart_DateDV.Tag = "Input"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(1006, 594)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 20)
        Me.Label15.TabIndex = 74
        Me.Label15.Text = "End Date :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(1006, 567)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 20)
        Me.Label16.TabIndex = 73
        Me.Label16.Text = "Start Date :"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUpdateDateDV
        '
        Me.lblUpdateDateDV.BackColor = System.Drawing.SystemColors.Info
        Me.lblUpdateDateDV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUpdateDateDV.Location = New System.Drawing.Point(1227, 595)
        Me.lblUpdateDateDV.Name = "lblUpdateDateDV"
        Me.lblUpdateDateDV.Size = New System.Drawing.Size(68, 20)
        Me.lblUpdateDateDV.TabIndex = 70
        Me.lblUpdateDateDV.Tag = "Input"
        '
        'lblCreateDateDV
        '
        Me.lblCreateDateDV.BackColor = System.Drawing.SystemColors.Info
        Me.lblCreateDateDV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCreateDateDV.Location = New System.Drawing.Point(1227, 567)
        Me.lblCreateDateDV.Name = "lblCreateDateDV"
        Me.lblCreateDateDV.Size = New System.Drawing.Size(68, 20)
        Me.lblCreateDateDV.TabIndex = 69
        Me.lblCreateDateDV.Tag = "Input"
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(1146, 595)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(79, 20)
        Me.Label19.TabIndex = 68
        Me.Label19.Text = "Update Date :"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(1146, 567)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 20)
        Me.Label20.TabIndex = 67
        Me.Label20.Text = "Create Date :"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRowidDV
        '
        Me.txtRowidDV.Location = New System.Drawing.Point(22, 630)
        Me.txtRowidDV.Name = "txtRowidDV"
        Me.txtRowidDV.Size = New System.Drawing.Size(16, 20)
        Me.txtRowidDV.TabIndex = 79
        Me.txtRowidDV.Tag = "Input"
        Me.txtRowidDV.Visible = False
        '
        'cmdExitDV
        '
        Me.cmdExitDV.Enabled = False
        Me.cmdExitDV.Location = New System.Drawing.Point(1232, 637)
        Me.cmdExitDV.Name = "cmdExitDV"
        Me.cmdExitDV.Size = New System.Drawing.Size(64, 23)
        Me.cmdExitDV.TabIndex = 22
        Me.cmdExitDV.Tag = ""
        '
        'cmdAddDV
        '
        Me.cmdAddDV.Location = New System.Drawing.Point(1040, 637)
        Me.cmdAddDV.Name = "cmdAddDV"
        Me.cmdAddDV.Size = New System.Drawing.Size(64, 23)
        Me.cmdAddDV.TabIndex = 19
        Me.cmdAddDV.Tag = "Add"
        Me.cmdAddDV.Text = "Add"
        '
        'cmdEditDV
        '
        Me.cmdEditDV.Location = New System.Drawing.Point(1104, 637)
        Me.cmdEditDV.Name = "cmdEditDV"
        Me.cmdEditDV.Size = New System.Drawing.Size(64, 23)
        Me.cmdEditDV.TabIndex = 20
        Me.cmdEditDV.Tag = "Edit"
        Me.cmdEditDV.Text = "Edit"
        '
        'cmdCancelDV
        '
        Me.cmdCancelDV.Location = New System.Drawing.Point(1104, 637)
        Me.cmdCancelDV.Name = "cmdCancelDV"
        Me.cmdCancelDV.Size = New System.Drawing.Size(64, 23)
        Me.cmdCancelDV.TabIndex = 23
        Me.cmdCancelDV.Tag = "Cancel"
        Me.cmdCancelDV.Text = "Cancel"
        '
        'cmdDeleteDV
        '
        Me.cmdDeleteDV.Location = New System.Drawing.Point(1168, 637)
        Me.cmdDeleteDV.Name = "cmdDeleteDV"
        Me.cmdDeleteDV.Size = New System.Drawing.Size(64, 23)
        Me.cmdDeleteDV.TabIndex = 21
        Me.cmdDeleteDV.Tag = "Delete"
        Me.cmdDeleteDV.Text = "Delete"
        '
        'cmdSaveDV
        '
        Me.cmdSaveDV.Location = New System.Drawing.Point(1168, 637)
        Me.cmdSaveDV.Name = "cmdSaveDV"
        Me.cmdSaveDV.Size = New System.Drawing.Size(64, 23)
        Me.cmdSaveDV.TabIndex = 24
        Me.cmdSaveDV.Tag = "Save"
        Me.cmdSaveDV.Text = "Save"
        '
        'txtNsmCodeDV
        '
        Me.txtNsmCodeDV.Location = New System.Drawing.Point(43, 630)
        Me.txtNsmCodeDV.Name = "txtNsmCodeDV"
        Me.txtNsmCodeDV.Size = New System.Drawing.Size(48, 20)
        Me.txtNsmCodeDV.TabIndex = 87
        Me.txtNsmCodeDV.Tag = ""
        Me.txtNsmCodeDV.Visible = False
        '
        'txtNSMdv
        '
        Me.txtNSMdv.Location = New System.Drawing.Point(99, 632)
        Me.txtNSMdv.Name = "txtNSMdv"
        Me.txtNSMdv.Size = New System.Drawing.Size(117, 20)
        Me.txtNSMdv.TabIndex = 88
        Me.txtNSMdv.Tag = ""
        Me.txtNSMdv.Visible = False
        '
        'txtDivision
        '
        Me.txtDivision.Location = New System.Drawing.Point(243, 438)
        Me.txtDivision.Name = "txtDivision"
        Me.txtDivision.Size = New System.Drawing.Size(48, 20)
        Me.txtDivision.TabIndex = 89
        Me.txtDivision.Tag = "Input"
        Me.txtDivision.Visible = False
        '
        'btnPicturePath
        '
        Me.btnPicturePath.Location = New System.Drawing.Point(540, 59)
        Me.btnPicturePath.Name = "btnPicturePath"
        Me.btnPicturePath.Size = New System.Drawing.Size(40, 23)
        Me.btnPicturePath.TabIndex = 107
        Me.btnPicturePath.Text = "..."
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(172, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(157, 23)
        Me.Label13.TabIndex = 105
        Me.Label13.Text = "Profile Picture Path :"
        '
        'txtPicturePath
        '
        Me.txtPicturePath.Location = New System.Drawing.Point(174, 59)
        Me.txtPicturePath.Name = "txtPicturePath"
        Me.txtPicturePath.ReadOnly = True
        Me.txtPicturePath.Size = New System.Drawing.Size(358, 20)
        Me.txtPicturePath.TabIndex = 106
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(12, 23)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(156, 207)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 104
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDimCode)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtEmpNo)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.btnPicturePath)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtPicturePath)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(603, 244)
        Me.GroupBox1.TabIndex = 108
        Me.GroupBox1.TabStop = False
        '
        'txtDimCode
        '
        Me.txtDimCode.Location = New System.Drawing.Point(247, 195)
        Me.txtDimCode.MaxLength = 100
        Me.txtDimCode.Name = "txtDimCode"
        Me.txtDimCode.Size = New System.Drawing.Size(329, 20)
        Me.txtDimCode.TabIndex = 3
        Me.txtDimCode.Tag = "Input"
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(170, 194)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(78, 29)
        Me.Label18.TabIndex = 111
        Me.Label18.Text = "Dimension Code:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEmpNo
        '
        Me.txtEmpNo.Location = New System.Drawing.Point(247, 161)
        Me.txtEmpNo.MaxLength = 5
        Me.txtEmpNo.Name = "txtEmpNo"
        Me.txtEmpNo.Size = New System.Drawing.Size(331, 20)
        Me.txtEmpNo.TabIndex = 2
        Me.txtEmpNo.Tag = "Input"
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(170, 152)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(81, 33)
        Me.Label17.TabIndex = 109
        Me.Label17.Text = "Employee No :"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtEmail)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtMobileNo)
        Me.GroupBox2.Controls.Add(Me.TxtEndDate)
        Me.GroupBox2.Controls.Add(Me.lblUpdateDate)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.TxtHireDate)
        Me.GroupBox2.Controls.Add(Me.lblCreateDate)
        Me.GroupBox2.Controls.Add(Me.TxtResignDate)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtStartDate)
        Me.GroupBox2.Location = New System.Drawing.Point(629, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(674, 245)
        Me.GroupBox2.TabIndex = 109
        Me.GroupBox2.TabStop = False
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(107, 21)
        Me.txtEmail.MaxLength = 75
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(190, 20)
        Me.txtEmail.TabIndex = 4
        Me.txtEmail.Tag = "Input"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(9, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 20)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Email :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(9, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 20)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "MobileNo :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMobileNo
        '
        Me.txtMobileNo.Location = New System.Drawing.Point(107, 56)
        Me.txtMobileNo.MaxLength = 50
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(191, 20)
        Me.txtMobileNo.TabIndex = 5
        Me.txtMobileNo.Tag = "Input"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(1002, 512)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(64, 23)
        Me.btnSearch.TabIndex = 110
        Me.btnSearch.Tag = ""
        Me.btnSearch.Text = "&Search"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(1074, 512)
        Me.txtSearch.MaxLength = 10
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(221, 20)
        Me.txtSearch.TabIndex = 111
        Me.txtSearch.Tag = ""
        '
        'NsmCT
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1318, 670)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtDivision)
        Me.Controls.Add(Me.txtNSMdv)
        Me.Controls.Add(Me.txtNsmCodeDV)
        Me.Controls.Add(Me.txtRowidDV)
        Me.Controls.Add(Me.txtEnd_DateDV)
        Me.Controls.Add(Me.txtStart_DateDV)
        Me.Controls.Add(Me.txtRowid)
        Me.Controls.Add(Me.TxtLastUser)
        Me.Controls.Add(Me.cmdExitDV)
        Me.Controls.Add(Me.cmdAddDV)
        Me.Controls.Add(Me.cmdEditDV)
        Me.Controls.Add(Me.cmdCancelDV)
        Me.Controls.Add(Me.cmdDeleteDV)
        Me.Controls.Add(Me.cmdSaveDV)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblUpdateDateDV)
        Me.Controls.Add(Me.lblCreateDateDV)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.DataGrid2)
        Me.Controls.Add(Me.SqlValue)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cboDivisionDV)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NsmCT"
        Me.Text = "Segment Head"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        modControlBehavior.EnableControlsGroup(Me, True)
        ControlMaintenance.ClearInputControlsGroup(Me)
        EditMode = False
        Disable2()
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

    Private Sub cmdAddDV_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAddDV.Click
        modControlBehavior.EnableControlsGroup(Me, True)
        ControlMaintenance.ClearInputControlsGroup(Me)
        EditMode = False
        Disable1()
        'added-DBrion --v
        btnSw = True
        lblCreateDateDV.Text = GetDateTimeNow("MM/dd/yyyy")
        lblUpdateDateDV.Text = GetDateTimeNow("MM/dd/yyyy")
        txtStart_DateDV.Text = GetDateTimeNow("MM") & "/01/" & GetDateTimeNow("yyyy")
        tmpSD = Format(CDate(txtStart_DateDV.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
        txtEnd_DateDV.Text = "12/31/2078"
        tmpED = Format(CDate(txtEnd_DateDV.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
        cboDivisionDV.Select()
        'added-DBrion --^
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If txtCode.Text = "" And txtDescription.Text = "" Then
            MessageBox.Show("Please select a record to modify!", "Record Selection", MessageBoxButtons.OK, _
            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            modControlBehavior.EnableControlsGroup(Me, True)
            EditMode = True
            Disable2()
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

    Private Sub cmdEditDV_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdEditDV.Click
        If GetCode(cboDivisionDV.Text) = "" Then
            MessageBox.Show("Please select a record to modify!", "Record Selection", MessageBoxButtons.OK, _
            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            modControlBehavior.EnableControlsGroup(Me, True)
            EditMode = True
            Disable1()
            'added-DBrion --v
            btnSw = True
            lblUpdateDateDV.Text = GetDateTimeNow("MM/dd/yyyy")
            cboDivisionDV.Select()
            cboDivisionDV.SelectAll()
            'added-DBrion --^
        End If
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If txtRowid.Text > "" Then
            If (MessageBox.Show("Do you really want to delete this record?", _
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information, _
                MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then

                Sub_Delete()
                ControlMaintenance.ClearInputControlsGroup(Me)
                DataGrid1.DataSource = Nothing  '<--DBrion    to remove any text left by the
                Sub_Show()                      '<--DBrion    deleted record
            End If
        End If
    End Sub

    Private Sub cmdDeleteDV_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDeleteDV.Click
        If txtRowidDV.Text > "" Then
            If (MessageBox.Show("Do you really want to delete this record?", _
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information, _
                MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then

                SubDV_Delete()
                ControlMaintenance.ClearInputControlsGroup(Me)
                SubDV_Show()
            End If
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdExitDV_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdExitDV.Click
        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        'added-DBrion --v
        btnSw = False
        'txtCode.Enabled = True
        'txtCode.BackColor = Color.White
        'txtCode.ForeColor = Color.Black
        'added-DBrion --^
        modControlBehavior.EnableControlsGroup(Me, False)
        ControlMaintenance.ClearInputControlsGroup(Me)
        EditMode = False
    End Sub

    Private Sub cmdCancelDV_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancelDV.Click
        'added-DBrion --v
        btnSw = False
        'added-DBrion --^
        modControlBehavior.EnableControlsGroup(Me, False)
        ControlMaintenance.ClearInputControlsGroup(Me)
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
               Trim(TxtHireDate.Text) = "" Or _
               Trim(TxtStartDate.Text) = "" Or Trim(TxtEndDate.Text) = "" Then

                MessageBox.Show("One of the Mandatory fields has no value!", "Attention!")
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
            modControlBehavior.EnableControlsGroup(Me, False)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub cmdSaveDV_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSaveDV.Click
        If (MessageBox.Show("Are you sure you want to Save this Entry?", "Confirm Saving", _
              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)) _
              = DialogResult.Yes Then

            Dim Params(0) As String
            Params(0) = txtRowidDV.Text
            If EditMode = False Then
                SubDV_Insert()
            Else
                SubDV_Update()
            End If
            'Sub_Show()                 '<--commented-DBrion
            SubDV_Select(Params, CStr(IIf(EditMode = False, "Insert", "Update")))
            EditMode = False
            modControlBehavior.EnableControlsGroup(Me, False)
            SubDV_Show()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Sub_Insert()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(12) As SqlParameter
        Dim NsmCode As New SqlParameter("@NsmCode", SqlDbType.VarChar, 25)
        NsmCode.Direction = ParameterDirection.Input
        NsmCode.Value = Trim(txtCode.Text)
        Params(0) = NsmCode
        Dim NsmName As New SqlParameter("@NsmName", SqlDbType.VarChar, 75)
        NsmName.Direction = ParameterDirection.Input
        NsmName.Value = Trim(txtDescription.Text)
        Params(1) = NsmName
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
        Hire_Date.Value = IfEmptyReturnNull(tmpHD)
        Params(4) = Hire_Date
        Dim Resign_Date As New SqlParameter("@Resign_Date", SqlDbType.DateTime, 10)
        Resign_Date.Direction = ParameterDirection.Input
        If Trim(TxtResignDate.Text) = "" Then
            Resign_Date.Value = DBNull.Value
        Else
            Resign_Date.Value = IfEmptyReturnNull(tmpRD)
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
        'Dim DivCode As New SqlParameter("@DivCode", SqlDbType.VarChar, 3)
        'DivCode.Direction = ParameterDirection.Input
        'DivCode.Value = GetCode(cboDivision.Text)
        'Params(9) = DivCode
        Dim StartDate As New SqlParameter("@StartDate", SqlDbType.DateTime, 10)
        StartDate.Direction = ParameterDirection.Input
        StartDate.Value = IfEmptyReturnNull(tmpSD)
        Params(9) = StartDate
        Dim EndDate As New SqlParameter("@EndDate", SqlDbType.DateTime, 10)
        EndDate.Direction = ParameterDirection.Input
        EndDate.Value = IfEmptyReturnNull(tmpED)
        Params(10) = EndDate
        'DimCode
        Dim DimCode As New SqlParameter("@DimCode", SqlDbType.VarChar, 8)
        DimCode.Direction = ParameterDirection.Input
        DimCode.Value = Trim(txtDimCode.Text)
        Params(11) = DimCode

        'Emp_No was removed by Angelo as per Sir Efren's advise
        'Dim Emp_No As New SqlParameter("@Emp_No", SqlDbType.VarChar, 5)
        'Emp_No.Direction = ParameterDirection.Input
        'Emp_No.Value = Trim(txtEmpNo.Text)
        'Params(12) = Emp_No

        'PicturePath
        Dim PicturePath As New SqlParameter("@PicturePath", SqlDbType.VarChar, 150)
        PicturePath.Direction = ParameterDirection.Input
        PicturePath.Value = Trim(txtPicturePath.Text)
        Params(12) = PicturePath

        Try
            BusinessObject.Sub_Insert(ServerPath2, "NsmCT_Insert", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SubDV_Insert()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(8) As SqlParameter
            Dim NsmCode As New SqlParameter("@NsmCode", SqlDbType.VarChar, 10)
            NsmCode.Direction = ParameterDirection.Input
            NsmCode.Value = Trim(txtNsmCodeDV.Text)
            Params(0) = NsmCode

            Dim NsmName As New SqlParameter("@Nsm", SqlDbType.VarChar, 100)
            NsmName.Direction = ParameterDirection.Input
            NsmName.Value = Trim(txtNSMdv.Text)
            Params(1) = NsmName

            Dim Division As New SqlParameter("@Division", SqlDbType.VarChar, 100)
            Division.Direction = ParameterDirection.Input
            Division.Value = GetDescription(cboDivisionDV.Text)
            Params(2) = Division

            Dim DivCode As New SqlParameter("@DivCode", SqlDbType.VarChar, 10)
            DivCode.Direction = ParameterDirection.Input
            DivCode.Value = GetCode(cboDivisionDV.Text)
            Params(3) = DivCode

            Dim CreateDate As New SqlParameter("@CreateDate", SqlDbType.DateTime, 10)
            CreateDate.Direction = ParameterDirection.Input
            CreateDate.Value = GetDateTimeNow("MM/dd/yyyy")
            Params(4) = CreateDate

            Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime, 10)
            UpdateDate.Direction = ParameterDirection.Input
            UpdateDate.Value = GetDateTimeNow("MM/dd/yyyy")
            Params(5) = UpdateDate

            Dim LastUser As New SqlParameter("@LastUser", SqlDbType.VarChar, 10)  '<v--added-DBrion
            LastUser.Direction = ParameterDirection.Input
            LastUser.Value = IIf(Trim(gCurrUser) = "", "", gCurrUser)      ' Trim(TxtLastUser.Text)
            Params(6) = LastUser

            Dim StartDate As New SqlParameter("@Start_Date", SqlDbType.DateTime, 10)
            StartDate.Direction = ParameterDirection.Input
            StartDate.Value = Trim(txtStart_DateDV.Text)
            Params(7) = StartDate

            Dim EndDate As New SqlParameter("@End_Date", SqlDbType.DateTime, 10)
            EndDate.Direction = ParameterDirection.Input
            EndDate.Value = Trim(txtEnd_DateDV.Text)
            Params(8) = EndDate

            BusinessObject.Sub_Insert(ServerPath2, "NsmCT_Div_Insert", CommandType.StoredProcedure, Params)
            LogHelper.InsertLog("NsmCT_Div_Insert.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("NsmCT_Div_Insert.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Sub_Update()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(11) As SqlParameter
            Dim NsmCode As New SqlParameter("@NsmCode", SqlDbType.VarChar, 25)  '<v--commented-DBrion
            NsmCode.Direction = ParameterDirection.Input
            NsmCode.Value = Trim(txtCode.Text)
            Params(0) = NsmCode                                                 '<^--commented-Dbrion
            Dim NsmName As New SqlParameter("@NsmName", SqlDbType.VarChar, 75)
            NsmName.Direction = ParameterDirection.Input
            NsmName.Value = Trim(txtDescription.Text)
            Params(1) = NsmName
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
            Hire_Date.Value = IfEmptyReturnNull(tmpHD)
            Params(4) = Hire_Date
            Dim Resign_Date As New SqlParameter("@Resign_Date", SqlDbType.DateTime, 10)
            Resign_Date.Direction = ParameterDirection.Input
            If Trim(TxtResignDate.Text) = "" Then
                Resign_Date.Value = DBNull.Value
            Else
                Resign_Date.Value = IfEmptyReturnNull(tmpRD)
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
            'Dim DivCode As New SqlParameter("@DivCode", SqlDbType.VarChar, 3)
            'DivCode.Direction = ParameterDirection.Input
            'DivCode.Value = GetCode(cboDivision.Text)
            'Params(8) = DivCode
            Dim StartDate As New SqlParameter("@StartDate", SqlDbType.DateTime, 10)
            StartDate.Direction = ParameterDirection.Input
            StartDate.Value = IfEmptyReturnNull(tmpSD)
            Params(8) = StartDate
            Dim EndDate As New SqlParameter("@EndDate", SqlDbType.DateTime, 10)
            EndDate.Direction = ParameterDirection.Input
            EndDate.Value = IfEmptyReturnNull(tmpED)
            Params(9) = EndDate
            'DimCode
            Dim DimCode As New SqlParameter("@DimCode", SqlDbType.VarChar, 8)
            DimCode.Direction = ParameterDirection.Input
            DimCode.Value = Trim(txtDimCode.Text)
            Params(10) = DimCode

            'Emp_No was remove by Angelo as per Sir Efren's advise
            'Dim Emp_No As New SqlParameter("@Emp_No", SqlDbType.VarChar, 5)
            'Emp_No.Direction = ParameterDirection.Input
            'Emp_No.Value = Trim(txtEmpNo.Text)
            'Params(11) = Emp_No

            'PicturePath
            Dim PicturePath As New SqlParameter("@PicturePath", SqlDbType.VarChar, 150)
            PicturePath.Direction = ParameterDirection.Input
            PicturePath.Value = Trim(txtPicturePath.Text)
            Params(11) = PicturePath

            BusinessObject.Sub_Update(ServerPath2, "NsmCT_Update", CommandType.StoredProcedure, Params)
            LogHelper.InsertLog("NsmCT_Update.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("NsmCT_Update.Error:  " & ex.Message)
        End Try
    End Sub

    Private Sub SubDV_Update()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(8) As SqlParameter
            Dim NsmCode As New SqlParameter("@NsmCode", SqlDbType.VarChar, 10)
            NsmCode.Direction = ParameterDirection.Input
            NsmCode.Value = Trim(txtNsmCodeDV.Text)
            Params(0) = NsmCode

            Dim NsmName As New SqlParameter("@Nsm", SqlDbType.VarChar, 100)
            NsmName.Direction = ParameterDirection.Input
            NsmName.Value = Trim(txtNSMdv.Text)
            Params(1) = NsmName

            Dim Division As New SqlParameter("@Division", SqlDbType.VarChar, 100)
            Division.Direction = ParameterDirection.Input
            Division.Value = GetDescription(cboDivisionDV.Text)
            Params(2) = Division

            Dim DivCode As New SqlParameter("@DivCode", SqlDbType.VarChar, 10)
            DivCode.Direction = ParameterDirection.Input
            DivCode.Value = GetCode(cboDivisionDV.Text)
            Params(3) = DivCode

            Dim Rowid As New SqlParameter("@Rowid", SqlDbType.Int)
            Rowid.Direction = ParameterDirection.Input
            Rowid.Value = Trim(txtRowidDV.Text)
            Params(4) = Rowid

            Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime, 10)
            UpdateDate.Direction = ParameterDirection.Input
            UpdateDate.Value = GetDateTimeNow("MM/dd/yyyy")
            Params(5) = UpdateDate

            Dim LastUser As New SqlParameter("@LastUser", SqlDbType.VarChar, 10)  '<v--added-DBrion
            LastUser.Direction = ParameterDirection.Input
            LastUser.Value = Trim(TxtLastUser.Text)
            Params(6) = LastUser

            Dim StartDate As New SqlParameter("@Start_Date", SqlDbType.DateTime, 10)
            StartDate.Direction = ParameterDirection.Input
            StartDate.Value = Trim(txtStart_DateDV.Text)
            Params(7) = StartDate

            Dim EndDate As New SqlParameter("@End_Date", SqlDbType.DateTime, 10)
            EndDate.Direction = ParameterDirection.Input
            EndDate.Value = Trim(txtEnd_DateDV.Text)
            Params(8) = EndDate

            BusinessObject.Sub_Update(ServerPath2, "NsmCT_Div_Update", CommandType.StoredProcedure, Params)
            LogHelper.InsertLog("NsmCT_Div_Update.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("NsmCT_Div_Update.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Sub_Show()
        Try
            If RemoteDataSet.NsmCT_Show.Count > 0 Then RemoteDataSet.NsmCT_Show.Clear()
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            If Trim(txtSearch.Text = "") Then
                BusinessObject.Sub_Show(ServerPath2, "NsmCT_Show", CommandType.StoredProcedure, RemoteDataSet, "NsmCT_Show")
            Else
                Dim Params(0) As SqlParameter
                Dim nsmname As New SqlParameter("@nsmname ", SqlDbType.VarChar, 50)
                nsmname.Direction = ParameterDirection.Input
                nsmname.Value = txtSearch.Text.ToString.Trim
                Params(0) = nsmname
                BusinessObject.Sub_Show(ServerPath2, "NsmCT_Show_Search", CommandType.StoredProcedure, RemoteDataSet, "NsmCT_Show", Params)
            End If
            DataGrid1.DataSource = RemoteDataSet.NsmCT_Show
            LogHelper.InsertLog("NsmCT_Show.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("NsmCT_Show.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub SubDV_Show()
        Try
            DataGrid2.DataSource = Nothing
            RemoteDataSet2.GenericQryProc.Clear()
            z = Nothing
            z = "select Division   fld1, Divcode  fld2, Rowid      fld3, LastUser   fld8, "
            z = z & "   Start_Date fld4, End_Date fld5, CreateDate fld6, UpdateDate fld7 "
            z = z & "from newscores..NsmDivisionAssignment "
            z = z & "where nsmcode = '" & Trim(txtCode.Text) & "' "

            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter

            Dim SqlQry As New SqlParameter("@SqlQry", SqlDbType.NVarChar, 3000)
            SqlQry.Direction = ParameterDirection.Input
            SqlQry.Value = z
            Params(0) = SqlQry

            Try
                BusinessObject.Sub_Show(ServerPath2, "GenericQryProc", CommandType.StoredProcedure, _
                                        RemoteDataSet2, "GenericQryProc", Params)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            DataGrid2.DataSource = RemoteDataSet2.GenericQryProc
            DataGrid2.Update()
            LogHelper.InsertLog("GenericQryProc.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("GenericQryProc.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Load_Division()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Try
            BusinessObject.Sub_Show(ServerPath2, "Division_Combo", CommandType.StoredProcedure, RemoteDataSet, "Division_Combo")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cboDivisionDV.DataSource = RemoteDataSet.Division_Combo
        cboDivisionDV.DisplayMember = "Division"
    End Sub

    Private Sub Sub_Select(ByVal dbParams() As String, ByVal UpdateMode As String)
        'select case if add,edit or delete
        Dim i As Integer
        Dim myRowid As Integer
        Select Case UpdateMode
            Case "Insert"
                Dim BusinessObject As New BusinessLayer.clsFileMaintenance
                myRowid = CInt(BusinessObject.Sub_ReturnIntegerResult(ServerPath2, "NsmCT_GetInsertedRowid", CommandType.StoredProcedure))
            Case "Update"
                myRowid = CInt(dbParams(0))
        End Select
        For i = 0 To (RemoteDataSet.NsmCT_Show.Rows.Count - 1)
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

    Private Sub SubDV_Select(ByVal dbParams() As String, ByVal UpdateMode As String)
        'select case if add,edit or delete
        Dim i As Integer
        Dim myRowid As Integer
        Select Case UpdateMode
            Case "Insert"
                Dim BusinessObject As New BusinessLayer.clsFileMaintenance
                myRowid = CInt(BusinessObject.Sub_ReturnIntegerResult(ServerPath2, "NsmCT_Div_GetInsertedRowid", CommandType.StoredProcedure))
            Case "Update"
                myRowid = CInt(dbParams(0))
        End Select
        For i = 0 To (RemoteDataSet2.GenericQryProc.Rows.Count - 1)
            With DataGrid2
                If myRowid = CInt(.Item(i, 2)) Then
                    .CurrentCell = New DataGridCell(i, 2)
                    Dim e As System.EventArgs
                    DataGrid2_Click(Me, e)
                    Exit For
                End If
            End With
        Next
    End Sub

    Private Sub Sub_Delete()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim NSMcode As New SqlParameter("@NSMcode", SqlDbType.Int)  '<v--changed from Rowid to NSMcode
            NSMcode.Direction = ParameterDirection.Input
            NSMcode.Value = txtCode.Text
            Params(0) = NSMcode                                         '<^--changed from Rowid to NSMcode
            BusinessObject.Sub_Delete(ServerPath2, "NsmCT_Delete", CommandType.StoredProcedure, Params)
            LogHelper.InsertLog("NsmCT_Delete.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("NsmCT_Delete.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub SubDV_Delete()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim Rowid As New SqlParameter("@Rowid", SqlDbType.Int)  '<v--changed from Rowid to NSMcode
            Rowid.Direction = ParameterDirection.Input
            Rowid.Value = txtRowidDV.Text
            Params(0) = Rowid                                         '<^--changed from Rowid to NSMcode
            BusinessObject.Sub_Delete(ServerPath2, "NsmCT_Div_Delete", CommandType.StoredProcedure, Params)
            LogHelper.InsertLog("NsmCT_Div_Delete.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("NsmCT_Div_Delete.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub NsmCT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            modControlBehavior.EnableControlsGroup(Me, False)
            btnSw = False    '<-- added-DBrion
            tmpSD = ""
            tmpED = ""
            tmpHD = ""
            tmpRD = ""
            LogHelper.InsertLog("NsmCT_Load.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("NsmCT_Load.Error: " & ex.Message)
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
            'dtHireDate.Value = CDate(.Item(.CurrentCell.RowNumber, 5))
            'dtResignDate.Value = CDate(.Item(.CurrentCell.RowNumber, 6))
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
            TxtLastUser.Text = .Item(.CurrentCell.RowNumber, 7).ToString
            'cboDivision.Text = .Item(.CurrentCell.RowNumber, 8).ToString & "--" & .Item(.CurrentCell.RowNumber, 9).ToString
            If Trim(.Item(.CurrentCell.RowNumber, 10).ToString) <> "" Then
                TxtStartDate.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 10).ToString), "MM/dd/yyyy")
            Else
                TxtStartDate.Text = ""
            End If
            If Trim(.Item(.CurrentCell.RowNumber, 11).ToString) <> "" Then   '<v--added to ".ToString"
                TxtEndDate.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 11).ToString), "MM/dd/yyyy")
            Else
                TxtEndDate.Text = ""
            End If
            'DimCode
            If Trim(.Item(.CurrentCell.RowNumber, 14).ToString) <> "" Then
                txtDimCode.Text = .Item(.CurrentCell.RowNumber, 14).ToString
            Else
                txtDimCode.Text = ""
            End If

            'EmpNo was removed by Angelo as per Sir Efren's advise
            'If Trim(.Item(.CurrentCell.RowNumber, 15).ToString) <> "" Then
            '    txtEmpNo.Text = .Item(.CurrentCell.RowNumber, 15).ToString
            'Else
            '    txtEmpNo.Text = ""
            'End If

            'Picture path
            If Trim(.Item(.CurrentCell.RowNumber, 16).ToString) <> "" Then
                txtPicturePath.Text = .Item(.CurrentCell.RowNumber, 16).ToString
            Else
                txtPicturePath.Text = ""
            End If
            .Select(.CurrentCell.RowNumber)
        End With
        txtNsmCodeDV.Text = Trim(txtCode.Text)
        txtNSMdv.Text = Trim(txtDescription.Text)
        SubDV_Show()
        'DataGrid2.CurrentRowIndex = RemoteDataSet.NsmCT_Show.Count
        DataGrid2_Click(Me, e)
    End Sub

    Private Sub DataGrid2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid2.Click, DataGrid2.CurrentCellChanged
        Dim tmp As String
        With DataGrid2
            If RemoteDataSet2.GenericQryProc.Count <> 0 Then
                cboDivisionDV.Text = Trim(DataGrid2.Item(DataGrid2.CurrentCell.RowNumber, 1).ToString) & "--" & _
                                                      DataGrid2.Item(DataGrid2.CurrentCell.RowNumber, 0).ToString
                txtRowidDV.Text = .Item(.CurrentCell.RowNumber, 2).ToString
                tmp = .Item(.CurrentCell.RowNumber, 3).ToString
                If tmp <> "" Then
                    txtStart_DateDV.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 3).ToString), "MM/dd/yyyy")
                    tmp = Nothing
                Else
                    txtStart_DateDV.Text = ""
                End If
                tmp = .Item(.CurrentCell.RowNumber, 4).ToString
                If tmp <> "" Then
                    txtEnd_DateDV.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 4).ToString), "MM/dd/yyyy")
                    tmp = Nothing
                Else
                    txtEnd_DateDV.Text = ""
                End If
                tmp = .Item(.CurrentCell.RowNumber, 5).ToString
                If tmp <> "" Then
                    lblCreateDateDV.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 5).ToString), "MM/dd/yyyy")
                    tmp = Nothing
                Else
                    lblCreateDateDV.Text = ""
                End If
                tmp = .Item(.CurrentCell.RowNumber, 6).ToString
                If tmp <> "" Then
                    lblUpdateDateDV.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 6).ToString), "MM/dd/yyyy")
                    tmp = Nothing
                Else
                    lblUpdateDateDV.Text = ""
                End If
            Else
                MsgBox("No records.")
            End If

        End With
    End Sub

    'Private Sub DataGrid2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGrid2.MouseUp
    '    DataGrid2.Select()
    'End Sub

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
            s = "select nsmname as fld1 from NewScores..NSM where nsmcode = '" & Trim(txtCode.Text) & "' "
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
                MessageBox.Show("This NSM Code already exist! Please try again.", "NSM Exsists!")
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
        If btnSw = True And Trim(txtDescription.Text) <> Trim(oldDs) Then
            s = "select nsmcode as fld1 from NewScores..NSM where nsmname = '" & Trim(txtDescription.Text) & "' "
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
                MessageBox.Show("This NSM Name already exist! Please try again.", "NSM Exsists!")
                e.Cancel = True
                txtDescription.Clear()
            End If
            SqlValue.ResetText()
            SqlValue.DataSource = Nothing
            RemoteDataSet2.GenericQryProc.Clear()
        End If
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

    Private Sub TxtStart_DateDV_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStart_DateDV.KeyUp
        If e.KeyValue = 13 Then      ' tests if the key pressed is the "enter key"
            SendKeys.Send("{TAB}")   ' sends the focus to the next control/tabstop
        End If
    End Sub

    Private Sub TxtStart_DateDV_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtStart_DateDV.Validating
        On Error GoTo errpt
        If Trim(txtStart_DateDV.Text) = "" Then       'entering w/o putting value
            txtStart_DateDV.Text = GetDateTimeNow("MM") & "/01/" & GetDateTimeNow("yyyy")
            tmpSD = Format(CDate(txtStart_DateDV.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
            Exit Sub
        Else
            txtStart_DateDV.Text = DatValid(txtStart_DateDV.Text)  'validating the entry. the textbox's value will be "mm/dd/yyyy" if the entry is invalid.
            If Trim(txtStart_DateDV.Text) = "mm/dd/yyyy" Then
                GoTo errpt
            Else
                txtStart_DateDV.Text = Mid(Trim(txtStart_DateDV.Text), 1, 2) & "/01/" & _
                                    Mid(Trim(txtStart_DateDV.Text), 7, 4)   'making the date the start of the month entered
                tmpSD = Format(CDate(txtStart_DateDV.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt") 'will use this variable in saving
            End If
            Exit Sub
        End If
errpt:
        e.Cancel = True  'brings back the focus to TxtStartDate textbox. only in Validating event
    End Sub

    Private Sub TxtEnd_DateDV_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEnd_DateDV.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TxtEnd_DateDV_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEnd_DateDV.Validating
        On Error GoTo errpt
        If Trim(txtEnd_DateDV.Text) = "" Then
            txtEnd_DateDV.Text = "12/31/2078"
            tmpED = Format(CDate(txtEnd_DateDV.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
            Exit Sub
        Else
            txtEnd_DateDV.Text = DatValid(txtEnd_DateDV.Text)
            If Trim(txtEnd_DateDV.Text) = "mm/dd/yyyy" Then
                GoTo errpt
            Else
                If Trim(txtStart_DateDV.Text) <> "" Then
                    If CDate(txtStart_DateDV.Text) < CDate(txtEnd_DateDV.Text) Then
                        txtEnd_DateDV.Text = GetEOM(Trim(txtEnd_DateDV.Text))
                        tmpED = Format(CDate(txtEnd_DateDV.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
                        Exit Sub
                    ElseIf Month(CDate(txtStart_DateDV.Text)) > Month(CDate(txtEnd_DateDV.Text)) Then
                        MessageBox.Show("The End date should be a month later than the Start date!")
                    End If
                End If
            End If
        End If
errpt:
        e.Cancel = True
    End Sub

    Private Sub cboDivisionDV_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboDivisionDV.KeyUp
        If e.KeyData.ToString = System.Windows.Forms.Keys.Up.ToString _
           Or e.KeyData.ToString = System.Windows.Forms.Keys.Left.ToString Then 'if key pressed is the up arrow it will select the next selection before the selction
            cboDivisionDV.SelectedItem = cboDivisionDV.SelectedIndex - 1
        ElseIf e.KeyData.ToString = System.Windows.Forms.Keys.Down.ToString _
           Or e.KeyData.ToString = System.Windows.Forms.Keys.Right.ToString Then 'if key pressed is the up arrow it will select the next selection after the selction
            cboDivisionDV.SelectedItem = cboDivisionDV.SelectedIndex + 1
        ElseIf DKcodes(e.KeyData) = True Then    'checking if the key pressed is alphanumeric (to disallow typing the entry)
            cboDivisionDV.Text = ""     'if alphanumeric then the value of the field will be erased
        End If
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")      'moves control to the next control or field
        End If
    End Sub
    'removed by Angelo as per Sir Efren's advise
    'Private Sub cboDivisionDV_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboDivisionDV.Validating
    '    If Trim(cboDivisionDV.Text) = "" Then    'tests if entry is blank
    '        MessageBox.Show("Mandatory field!", "Critical!")  'gives message to put value
    '        e.Cancel() = True                  ' brings back the focus on this control/field
    '    End If
    'End Sub

    Private Sub txtEmail_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtEmail_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If jTrim(txtEmail.Text) = "" Then
            Exit Sub
        End If
        If InStr(jTrim(txtEmail.Text), "@") = 0 And InStr(jTrim(txtEmail.Text), ".") = 0 Then
            MessageBox.Show("Invalid email address!")
            Exit Sub
        End If
    End Sub

    Private Sub txtMobileNo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
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
    'added-DBrion --^

    Private Sub Enable2()
        cboDivisionDV.Enabled = True
        txtStart_DateDV.Enabled = True
        txtEnd_DateDV.Enabled = True
        DataGrid2.Enabled = True
        cmdCancelDV.Enabled = True
        cmdSaveDV.Enabled = True
    End Sub

    Private Sub Disable2()
        cboDivisionDV.Enabled = False
        txtStart_DateDV.Enabled = False
        txtEnd_DateDV.Enabled = False
        DataGrid2.Enabled = False
        cmdCancelDV.Enabled = False
        cmdSaveDV.Enabled = False
    End Sub

    Private Sub Enable1()
        txtCode.Enabled = True
        txtDescription.Enabled = True
        txtEmail.Enabled = True
        txtMobileNo.Enabled = True
        TxtHireDate.Enabled = True
        TxtResignDate.Enabled = True
        TxtStartDate.Enabled = True
        TxtEndDate.Enabled = True
        DataGrid1.Enabled = True
        cmdCancel.Enabled = True
        cmdSave.Enabled = True
    End Sub

    Private Sub Disable1()
        txtCode.Enabled = False
        txtDescription.Enabled = False
        txtEmail.Enabled = False
        txtMobileNo.Enabled = False
        TxtHireDate.Enabled = False
        TxtResignDate.Enabled = False
        TxtStartDate.Enabled = False
        TxtEndDate.Enabled = False
        DataGrid1.Enabled = False
        cmdCancel.Enabled = False
        cmdSave.Enabled = False
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

    Private Sub btnPicturePath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPicturePath.Click
        Dim File As String
        OpenFileDialog1.Filter = "Picture files (*.jpg)|*.jpg;*.png"
        OpenFileDialog1.InitialDirectory = "\\Micdb\FIELDFORCE\NSM PICS"
        OpenFileDialog1.ShowDialog(Me)
        txtPicturePath.Text = OpenFileDialog1.FileName
        File = VisualBasic.Mid(OpenFileDialog1.FileName, OpenFileDialog1.FileName.LastIndexOf("\") + 2)
    End Sub

    Private Sub txtEmpNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmpNo.TextChanged
        DisplaydimCode()

    End Sub
    Private Sub DisplaydimCode()
        'txtDimCode.Text = "NM-" + txtEmpNo.Text.Trim()
        'Empty Employee No
        If txtEmpNo.Text = "" Or txtDescription.Text.ToString.ToUpper.Contains("VACANT") Then
            txtDimCode.Text = "SH-" + txtCode.Text.Trim()
        Else
            txtDimCode.Text = "EE-" + txtEmpNo.Text.Trim()
        End If
    End Sub

    Private Sub txtPicturePath_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPicturePath.TextChanged
        Try
            LoadPicture()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGrid1.Navigate

    End Sub

    Private Sub TxtEndDate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtEndDate.TextChanged

    End Sub

    Private Sub txtCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCode.TextChanged
        LoadPicture()
    End Sub
    Private Sub LoadPicture()
        Try
            Dim blankprofile As String = System.Configuration.ConfigurationSettings.AppSettings.Item("BlankProfile")
            If txtPicturePath.Text <> "" Then
                PictureBox2.Image = Image.FromFile(txtPicturePath.Text)
                PictureBox2.Refresh()
            Else
                PictureBox2.Image = Image.FromFile(blankprofile)
                PictureBox2.Refresh()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Sub_Show()

    End Sub
End Class