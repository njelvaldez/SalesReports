Imports System.Data.SqlClient
Imports Microsoft
Public Class CustomerCT
    Inherits System.Windows.Forms.Form
    Private RemoteDataSet As New CodeTablesDS
    Private EditMode As Boolean = False
    Public SearchString As String
    Public tmpTerritory As String, tmpType As String

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Load_CustomerType()
        Load_Territory()
        Load_QpiAreaCode()
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
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboType As System.Windows.Forms.ComboBox
    Friend WithEvents lblUpdateDate As System.Windows.Forms.Label
    Friend WithEvents lblCreateDate As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRowid As System.Windows.Forms.TextBox
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents txtAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents cmdGo As System.Windows.Forms.Button
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgRowid As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgCustCode As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgCustName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgAddress1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgAddress2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgTerritory As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgMetro_Code As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgCreateDate As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgUpdateDate As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgMdType As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents dgCustType As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgAreaCode As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dg_qpiAreaCode As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgAddress3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgParentCustCode As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgLastUSer As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents txtAreaCode As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress3 As System.Windows.Forms.TextBox
    Friend WithEvents txtMDtype As System.Windows.Forms.TextBox
    Friend WithEvents txtParentCustCode As System.Windows.Forms.TextBox
    Friend WithEvents txtLastUser As System.Windows.Forms.TextBox
    Friend WithEvents txtMetro_Code As System.Windows.Forms.TextBox
    Friend WithEvents cboTerritoryDR As System.Windows.Forms.ComboBox
    Friend WithEvents CboQpiAreaCode As System.Windows.Forms.ComboBox
    Friend WithEvents txtZueCode As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dgZueCode As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CustomerCT))
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.dgRowid = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgCustCode = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgCustName = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgCustType = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgAddress1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgAddress2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgAddress3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgAreaCode = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgTerritory = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgMetro_Code = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgCreateDate = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgUpdateDate = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgMdType = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dg_qpiAreaCode = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgParentCustCode = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgLastUSer = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgZueCode = New System.Windows.Forms.DataGridTextBoxColumn
        Me.cmdSearch = New System.Windows.Forms.Button
        Me.txtMetro_Code = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtAreaCode = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.cboTerritoryDR = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtAddress2 = New System.Windows.Forms.TextBox
        Me.txtAddress1 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cboType = New System.Windows.Forms.ComboBox
        Me.lblUpdateDate = New System.Windows.Forms.Label
        Me.lblCreateDate = New System.Windows.Forms.Label
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtRowid = New System.Windows.Forms.TextBox
        Me.cmdGo = New System.Windows.Forms.Button
        Me.btnGenerate = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtAddress3 = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtMDtype = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtParentCustCode = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtLastUser = New System.Windows.Forms.TextBox
        Me.CboQpiAreaCode = New System.Windows.Forms.ComboBox
        Me.txtZueCode = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdExit
        '
        Me.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdExit.Location = New System.Drawing.Point(353, 442)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(112, 23)
        Me.cmdExit.TabIndex = 14
        Me.cmdExit.Tag = "Exit"
        Me.cmdExit.Text = "Exit"
        '
        'cmdAdd
        '
        Me.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdAdd.Location = New System.Drawing.Point(11, 442)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(112, 23)
        Me.cmdAdd.TabIndex = 11
        Me.cmdAdd.Tag = "Add"
        Me.cmdAdd.Text = "Add"
        '
        'cmdEdit
        '
        Me.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdEdit.Location = New System.Drawing.Point(125, 442)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(112, 23)
        Me.cmdEdit.TabIndex = 12
        Me.cmdEdit.Tag = "Edit"
        Me.cmdEdit.Text = "Edit"
        '
        'cmdCancel
        '
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdCancel.Location = New System.Drawing.Point(125, 442)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(112, 23)
        Me.cmdCancel.TabIndex = 15
        Me.cmdCancel.Tag = "Cancel"
        Me.cmdCancel.Text = "Cancel"
        '
        'cmdDelete
        '
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDelete.Location = New System.Drawing.Point(239, 442)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(112, 23)
        Me.cmdDelete.TabIndex = 13
        Me.cmdDelete.Tag = "Delete"
        Me.cmdDelete.Text = "Delete"
        '
        'cmdSave
        '
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSave.Location = New System.Drawing.Point(239, 442)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(112, 23)
        Me.cmdSave.TabIndex = 16
        Me.cmdSave.Tag = "Save"
        Me.cmdSave.Text = "Save"
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 4)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(921, 263)
        Me.DataGrid1.TabIndex = 42
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.DataGrid1.Tag = "View"
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Aqua
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightCyan
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.dgRowid, Me.dgCustCode, Me.dgCustName, Me.dgCustType, Me.dgAddress1, Me.dgAddress2, Me.dgAddress3, Me.dgAreaCode, Me.dgTerritory, Me.dgMetro_Code, Me.dgCreateDate, Me.dgUpdateDate, Me.dgMdType, Me.dg_qpiAreaCode, Me.dgParentCustCode, Me.dgLastUSer, Me.dgZueCode})
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.AntiqueWhite
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "CustomerCodTab_Show"
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
        'dgCustCode
        '
        Me.dgCustCode.Format = ""
        Me.dgCustCode.FormatInfo = Nothing
        Me.dgCustCode.HeaderText = "Code"
        Me.dgCustCode.MappingName = "CustCode"
        Me.dgCustCode.NullText = ""
        Me.dgCustCode.ReadOnly = True
        Me.dgCustCode.Width = 75
        '
        'dgCustName
        '
        Me.dgCustName.Format = ""
        Me.dgCustName.FormatInfo = Nothing
        Me.dgCustName.HeaderText = "Name"
        Me.dgCustName.MappingName = "CustName"
        Me.dgCustName.NullText = ""
        Me.dgCustName.ReadOnly = True
        Me.dgCustName.Width = 240
        '
        'dgCustType
        '
        Me.dgCustType.Format = ""
        Me.dgCustType.FormatInfo = Nothing
        Me.dgCustType.HeaderText = "Type"
        Me.dgCustType.MappingName = "CustType"
        Me.dgCustType.NullText = ""
        Me.dgCustType.Width = 150
        '
        'dgAddress1
        '
        Me.dgAddress1.Format = ""
        Me.dgAddress1.FormatInfo = Nothing
        Me.dgAddress1.HeaderText = "Address1"
        Me.dgAddress1.MappingName = "Address1"
        Me.dgAddress1.NullText = ""
        Me.dgAddress1.Width = 175
        '
        'dgAddress2
        '
        Me.dgAddress2.Format = ""
        Me.dgAddress2.FormatInfo = Nothing
        Me.dgAddress2.HeaderText = "Address2"
        Me.dgAddress2.MappingName = "Address2"
        Me.dgAddress2.NullText = ""
        Me.dgAddress2.Width = 175
        '
        'dgAddress3
        '
        Me.dgAddress3.Format = ""
        Me.dgAddress3.FormatInfo = Nothing
        Me.dgAddress3.HeaderText = "Address3"
        Me.dgAddress3.MappingName = "Address3"
        Me.dgAddress3.NullText = ""
        Me.dgAddress3.Width = 175
        '
        'dgAreaCode
        '
        Me.dgAreaCode.Format = ""
        Me.dgAreaCode.FormatInfo = Nothing
        Me.dgAreaCode.HeaderText = "Area Code"
        Me.dgAreaCode.MappingName = "AreaCode"
        Me.dgAreaCode.NullText = ""
        Me.dgAreaCode.Width = 30
        '
        'dgTerritory
        '
        Me.dgTerritory.Format = ""
        Me.dgTerritory.FormatInfo = Nothing
        Me.dgTerritory.HeaderText = "Territory"
        Me.dgTerritory.MappingName = "TerritoryDR"
        Me.dgTerritory.NullText = ""
        Me.dgTerritory.Width = 180
        '
        'dgMetro_Code
        '
        Me.dgMetro_Code.Format = ""
        Me.dgMetro_Code.FormatInfo = Nothing
        Me.dgMetro_Code.HeaderText = "Metro Code"
        Me.dgMetro_Code.MappingName = "Metro_Code"
        Me.dgMetro_Code.NullText = ""
        Me.dgMetro_Code.Width = 75
        '
        'dgCreateDate
        '
        Me.dgCreateDate.Format = "MM/dd/yyyy"
        Me.dgCreateDate.FormatInfo = Nothing
        Me.dgCreateDate.HeaderText = "Create Date"
        Me.dgCreateDate.MappingName = "CreateDate"
        Me.dgCreateDate.NullText = ""
        Me.dgCreateDate.Width = 60
        '
        'dgUpdateDate
        '
        Me.dgUpdateDate.Format = "MM/dd/yyyy"
        Me.dgUpdateDate.FormatInfo = Nothing
        Me.dgUpdateDate.HeaderText = "Update Date"
        Me.dgUpdateDate.MappingName = "UpdateDate"
        Me.dgUpdateDate.NullText = ""
        Me.dgUpdateDate.Width = 60
        '
        'dgMdType
        '
        Me.dgMdType.Format = ""
        Me.dgMdType.FormatInfo = Nothing
        Me.dgMdType.HeaderText = "MD type"
        Me.dgMdType.MappingName = "MdType"
        Me.dgMdType.NullText = ""
        Me.dgMdType.Width = 75
        '
        'dg_qpiAreaCode
        '
        Me.dg_qpiAreaCode.Format = ""
        Me.dg_qpiAreaCode.FormatInfo = Nothing
        Me.dg_qpiAreaCode.HeaderText = "QPI Area Code"
        Me.dg_qpiAreaCode.MappingName = "qpiAreaCode"
        Me.dg_qpiAreaCode.NullText = ""
        Me.dg_qpiAreaCode.Width = 75
        '
        'dgParentCustCode
        '
        Me.dgParentCustCode.Format = ""
        Me.dgParentCustCode.FormatInfo = Nothing
        Me.dgParentCustCode.HeaderText = "Parent Code"
        Me.dgParentCustCode.MappingName = "ParentCustCode"
        Me.dgParentCustCode.NullText = ""
        Me.dgParentCustCode.Width = 75
        '
        'dgLastUSer
        '
        Me.dgLastUSer.Format = ""
        Me.dgLastUSer.FormatInfo = Nothing
        Me.dgLastUSer.HeaderText = "Encoder"
        Me.dgLastUSer.MappingName = "LastUSer"
        Me.dgLastUSer.NullText = ""
        Me.dgLastUSer.Width = 75
        '
        'dgZueCode
        '
        Me.dgZueCode.Format = ""
        Me.dgZueCode.FormatInfo = Nothing
        Me.dgZueCode.HeaderText = "ZueligCode"
        Me.dgZueCode.MappingName = "zuecode"
        Me.dgZueCode.NullText = ""
        Me.dgZueCode.Width = 75
        '
        'cmdSearch
        '
        Me.cmdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.Location = New System.Drawing.Point(769, 442)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(60, 23)
        Me.cmdSearch.TabIndex = 17
        Me.cmdSearch.Tag = ""
        Me.cmdSearch.Text = "Enable"
        '
        'txtMetro_Code
        '
        Me.txtMetro_Code.AccessibleDescription = "Metro_Code"
        Me.txtMetro_Code.AutoSize = False
        Me.txtMetro_Code.Location = New System.Drawing.Point(483, 313)
        Me.txtMetro_Code.Name = "txtMetro_Code"
        Me.txtMetro_Code.Size = New System.Drawing.Size(174, 21)
        Me.txtMetro_Code.TabIndex = 5
        Me.txtMetro_Code.Tag = "Input"
        Me.txtMetro_Code.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(416, 316)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 16)
        Me.Label10.TabIndex = 88
        Me.Label10.Text = "Metro Code"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAreaCode
        '
        Me.txtAreaCode.AccessibleDescription = "AreaCode"
        Me.txtAreaCode.AutoSize = False
        Me.txtAreaCode.Location = New System.Drawing.Point(82, 35)
        Me.txtAreaCode.Name = "txtAreaCode"
        Me.txtAreaCode.Size = New System.Drawing.Size(66, 21)
        Me.txtAreaCode.TabIndex = 6
        Me.txtAreaCode.Tag = "Input"
        Me.txtAreaCode.Text = ""
        Me.txtAreaCode.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 16)
        Me.Label9.TabIndex = 86
        Me.Label9.Text = "Area Code"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label9.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(433, 289)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 16)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "Territory"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboTerritoryDR
        '
        Me.cboTerritoryDR.AccessibleDescription = "TerritoryDR"
        Me.cboTerritoryDR.Location = New System.Drawing.Point(483, 286)
        Me.cboTerritoryDR.MaxDropDownItems = 30
        Me.cboTerritoryDR.Name = "cboTerritoryDR"
        Me.cboTerritoryDR.Size = New System.Drawing.Size(220, 21)
        Me.cboTerritoryDR.TabIndex = 4
        Me.cboTerritoryDR.Tag = "Input"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 370)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 16)
        Me.Label7.TabIndex = 83
        Me.Label7.Text = "Address 2"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 344)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 16)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "Address 1"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAddress2
        '
        Me.txtAddress2.AccessibleDescription = "Address2"
        Me.txtAddress2.AutoSize = False
        Me.txtAddress2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddress2.Location = New System.Drawing.Point(63, 367)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(341, 21)
        Me.txtAddress2.TabIndex = 3
        Me.txtAddress2.Tag = "Input"
        Me.txtAddress2.Text = ""
        '
        'txtAddress1
        '
        Me.txtAddress1.AccessibleDescription = "Address1"
        Me.txtAddress1.AutoSize = False
        Me.txtAddress1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddress1.Location = New System.Drawing.Point(63, 340)
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(341, 21)
        Me.txtAddress1.TabIndex = 2
        Me.txtAddress1.Tag = "Input"
        Me.txtAddress1.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 316)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 16)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "Type"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboType
        '
        Me.cboType.AccessibleDescription = "CustType"
        Me.cboType.Location = New System.Drawing.Point(43, 313)
        Me.cboType.MaxDropDownItems = 12
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(188, 21)
        Me.cboType.TabIndex = 1
        Me.cboType.Tag = "Input"
        '
        'lblUpdateDate
        '
        Me.lblUpdateDate.BackColor = System.Drawing.SystemColors.Info
        Me.lblUpdateDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUpdateDate.Location = New System.Drawing.Point(812, 402)
        Me.lblUpdateDate.Name = "lblUpdateDate"
        Me.lblUpdateDate.Size = New System.Drawing.Size(113, 21)
        Me.lblUpdateDate.TabIndex = 76
        Me.lblUpdateDate.Tag = "Input"
        '
        'lblCreateDate
        '
        Me.lblCreateDate.BackColor = System.Drawing.SystemColors.Info
        Me.lblCreateDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCreateDate.Location = New System.Drawing.Point(620, 402)
        Me.lblCreateDate.Name = "lblCreateDate"
        Me.lblCreateDate.Size = New System.Drawing.Size(113, 21)
        Me.lblCreateDate.TabIndex = 75
        Me.lblCreateDate.Tag = "Input"
        '
        'txtDescription
        '
        Me.txtDescription.AccessibleDescription = "CustName"
        Me.txtDescription.AutoSize = False
        Me.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescription.Location = New System.Drawing.Point(43, 286)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(361, 21)
        Me.txtDescription.TabIndex = 0
        Me.txtDescription.Tag = "Input"
        Me.txtDescription.Text = ""
        '
        'txtCode
        '
        Me.txtCode.AccessibleDescription = "CustCode"
        Me.txtCode.AutoSize = False
        Me.txtCode.BackColor = System.Drawing.SystemColors.Info
        Me.txtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Enabled = False
        Me.txtCode.Location = New System.Drawing.Point(94, 402)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(128, 21)
        Me.txtCode.TabIndex = 0
        Me.txtCode.Tag = "Input"
        Me.txtCode.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(740, 405)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Update Date"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(554, 405)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 16)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Create Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 289)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 16)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 405)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 16)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Code"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRowid
        '
        Me.txtRowid.Location = New System.Drawing.Point(166, 36)
        Me.txtRowid.Name = "txtRowid"
        Me.txtRowid.Size = New System.Drawing.Size(13, 20)
        Me.txtRowid.TabIndex = 77
        Me.txtRowid.Tag = "Input"
        Me.txtRowid.Text = ""
        Me.txtRowid.Visible = False
        '
        'cmdGo
        '
        Me.cmdGo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGo.Location = New System.Drawing.Point(814, 442)
        Me.cmdGo.Name = "cmdGo"
        Me.cmdGo.Size = New System.Drawing.Size(15, 23)
        Me.cmdGo.TabIndex = 92
        Me.cmdGo.Tag = ""
        Me.cmdGo.Text = "Go !"
        '
        'btnGenerate
        '
        Me.btnGenerate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.Location = New System.Drawing.Point(5, 402)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(59, 21)
        Me.btnGenerate.TabIndex = 7
        Me.btnGenerate.Text = "Generate"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(833, 442)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Search"
        '
        'txtAddress3
        '
        Me.txtAddress3.AccessibleDescription = "Address3"
        Me.txtAddress3.AutoSize = False
        Me.txtAddress3.BackColor = System.Drawing.SystemColors.Info
        Me.txtAddress3.Location = New System.Drawing.Point(483, 367)
        Me.txtAddress3.Name = "txtAddress3"
        Me.txtAddress3.ReadOnly = True
        Me.txtAddress3.Size = New System.Drawing.Size(174, 21)
        Me.txtAddress3.TabIndex = 5
        Me.txtAddress3.Tag = "Input"
        Me.txtAddress3.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(424, 370)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 16)
        Me.Label13.TabIndex = 98
        Me.Label13.Text = "Address 3"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMDtype
        '
        Me.txtMDtype.AccessibleDescription = "MDtype"
        Me.txtMDtype.AutoSize = False
        Me.txtMDtype.Location = New System.Drawing.Point(764, 286)
        Me.txtMDtype.Name = "txtMDtype"
        Me.txtMDtype.Size = New System.Drawing.Size(165, 21)
        Me.txtMDtype.TabIndex = 8
        Me.txtMDtype.Tag = "Input"
        Me.txtMDtype.Text = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(710, 289)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 16)
        Me.Label14.TabIndex = 99
        Me.Label14.Text = "MD Type"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(679, 344)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 16)
        Me.Label15.TabIndex = 101
        Me.Label15.Text = "QPI Area Code"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtParentCustCode
        '
        Me.txtParentCustCode.AccessibleDescription = "ParentCustCode"
        Me.txtParentCustCode.AutoSize = False
        Me.txtParentCustCode.Location = New System.Drawing.Point(764, 313)
        Me.txtParentCustCode.Name = "txtParentCustCode"
        Me.txtParentCustCode.Size = New System.Drawing.Size(165, 21)
        Me.txtParentCustCode.TabIndex = 9
        Me.txtParentCustCode.Tag = "Input"
        Me.txtParentCustCode.Text = ""
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(663, 316)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(97, 16)
        Me.Label16.TabIndex = 103
        Me.Label16.Text = "Parent Cust. Code"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Location = New System.Drawing.Point(6, 429)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(922, 2)
        Me.Label17.TabIndex = 105
        Me.Label17.Text = "Label17"
        '
        'txtLastUser
        '
        Me.txtLastUser.Location = New System.Drawing.Point(183, 36)
        Me.txtLastUser.Name = "txtLastUser"
        Me.txtLastUser.Size = New System.Drawing.Size(13, 20)
        Me.txtLastUser.TabIndex = 106
        Me.txtLastUser.Tag = "Input"
        Me.txtLastUser.Text = ""
        Me.txtLastUser.Visible = False
        '
        'CboQpiAreaCode
        '
        Me.CboQpiAreaCode.AccessibleDescription = "QpiAreaCode"
        Me.CboQpiAreaCode.Location = New System.Drawing.Point(764, 340)
        Me.CboQpiAreaCode.MaxDropDownItems = 15
        Me.CboQpiAreaCode.Name = "CboQpiAreaCode"
        Me.CboQpiAreaCode.Size = New System.Drawing.Size(165, 21)
        Me.CboQpiAreaCode.TabIndex = 10
        Me.CboQpiAreaCode.Tag = "Input"
        '
        'txtZueCode
        '
        Me.txtZueCode.AccessibleDescription = "ParentCustCode"
        Me.txtZueCode.AutoSize = False
        Me.txtZueCode.Location = New System.Drawing.Point(483, 340)
        Me.txtZueCode.Name = "txtZueCode"
        Me.txtZueCode.Size = New System.Drawing.Size(174, 21)
        Me.txtZueCode.TabIndex = 6
        Me.txtZueCode.Tag = "Input"
        Me.txtZueCode.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(414, 344)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 16)
        Me.Label11.TabIndex = 108
        Me.Label11.Text = "Zuelig Code"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CustomerCT
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(934, 476)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.txtZueCode)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtLastUser)
        Me.Controls.Add(Me.txtParentCustCode)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtMDtype)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtAddress3)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtAddress2)
        Me.Controls.Add(Me.txtAddress1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.txtMetro_Code)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtRowid)
        Me.Controls.Add(Me.txtAreaCode)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.CboQpiAreaCode)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.lblUpdateDate)
        Me.Controls.Add(Me.lblCreateDate)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cboTerritoryDR)
        Me.Controls.Add(Me.cmdGo)
        Me.Controls.Add(Me.cmdCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CustomerCT"
        Me.Text = "Customer"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        modControlBehavior.EnableControls(Me, True)
        ControlMaintenance.ClearInputControls(Me)
        EditMode = False
        btnGenerate.Enabled = True
        cmdSearch.Enabled = False
        Button1.Enabled = False
        btnSw = True
        lblCreateDate.Text = GetDateTimeNow("MM/dd/yyyy")
        lblUpdateDate.Text = GetDateTimeNow("MM/dd/yyyy")
        txtCode.Enabled = False
        txtCode.BackColor = BackColor.White
        txtCode.ForeColor = ForeColor.Black
        txtDescription.Select()
    End Sub
    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If txtCode.Text = "" And txtDescription.Text = "" Then
            MessageBox.Show("Please select a record to modify!", "Record Selection", MessageBoxButtons.OK, _
            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            modControlBehavior.EnableControls(Me, True)
            EditMode = True
            btnGenerate.Enabled = True
            cmdSearch.Enabled = False
            Button1.Enabled = False
            btnSw = True
        End If
    End Sub
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If txtRowid.Text > "" Then
            If (MessageBox.Show("Do you really want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, _
            MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then
                Sub_Delete()
                ControlMaintenance.ClearInputControls(Me)
                Sub_Show()
            End If
        End If
    End Sub
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        forCancel()
    End Sub
    Private Sub forCancel()
        btnSw = False
        modControlBehavior.EnableControls(Me, False)
        ControlMaintenance.ClearInputControls(Me)
        EditMode = False
        btnGenerate.Enabled = False
        cmdSearch.Enabled = True
        Button1.Enabled = True
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If (MessageBox.Show("Are you sure you want to Save this Entry?", "Confirm Saving", _
                      MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)) _
                      = DialogResult.Yes Then

            Dim Params(0) As String
            Params(0) = txtRowid.Text
            txtLastUser.Text = gCurrUser
            If EditMode = False Then
                Sub_Insert()
            Else
                Sub_Update()
            End If
            EditMode = False
            modControlBehavior.EnableControls(Me, False)
            DataGrid1.DataSource = Nothing
            Sub_Show()
            Sub_Select(Params, CStr(IIf(EditMode = False, "Insert", "Update")))
            btnGenerate.Enabled = False
            cmdSearch.Enabled = True
            Button1.Enabled = True
            DataGrid1.Enabled = True
        Else
            Exit Sub
        End If
    End Sub
    Private Sub Sub_Insert()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(15) As SqlParameter

        Dim CustCode As New SqlParameter("@CustCode", SqlDbType.VarChar, 10)
        CustCode.Direction = ParameterDirection.Input
        CustCode.Value = Trim(txtCode.Text)
        Params(0) = CustCode

        If Trim(txtDescription.Text) = "" Then
            MsgBox("Mandatory field! 'Customer name'")
            txtDescription.Select()
            Exit Sub
        End If
        Dim CustName As New SqlParameter("@CustName", SqlDbType.VarChar, 80)
        CustName.Direction = ParameterDirection.Input
        CustName.Value = Trim(txtDescription.Text)
        Params(1) = CustName

        Dim CustType As New SqlParameter("@CustType", SqlDbType.Int)
        CustType.Direction = ParameterDirection.Input
        CustType.Value = Val(GetCode(tmpType))    ' jVal(GetCode(cboType.Text))
        Params(2) = CustType

        Dim Address1 As New SqlParameter("@Address1", SqlDbType.VarChar, 150)
        Address1.Direction = ParameterDirection.Input
        Address1.Value = Trim(txtAddress1.Text)
        Params(3) = Address1

        Dim Address2 As New SqlParameter("@Address2", SqlDbType.VarChar, 150)
        Address2.Direction = ParameterDirection.Input
        Address2.Value = Trim(txtAddress2.Text)
        Params(4) = Address2

        Dim Address3 As New SqlParameter("@Address3", SqlDbType.VarChar, 150)
        Address3.Direction = ParameterDirection.Input
        Address3.Value = Trim(txtAddress3.Text)
        Params(5) = Address3

        Dim AreaCode As New SqlParameter("@AreaCode", SqlDbType.VarChar, 3)
        AreaCode.Direction = ParameterDirection.Input
        AreaCode.Value = Trim(txtAreaCode.Text)
        Params(6) = AreaCode

        Dim TerritoryDR As New SqlParameter("@TerritoryDR", SqlDbType.VarChar, 20)
        TerritoryDR.Direction = ParameterDirection.Input
        TerritoryDR.Value = GetCode(tmpTerritory)    ' GetCode(cboTerritoryDR.Text)
        Params(7) = TerritoryDR

        Dim Metro_Code As New SqlParameter("@Metro_Code", SqlDbType.VarChar, 50)
        Metro_Code.Direction = ParameterDirection.Input
        Metro_Code.Value = Trim(txtMetro_Code.Text)
        Params(8) = Metro_Code

        Dim CreateDate As New SqlParameter("@CreateDate", SqlDbType.DateTime)
        CreateDate.Direction = ParameterDirection.Input
        CreateDate.Value = GetDateTimeNow()
        Params(9) = CreateDate

        Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime)
        UpdateDate.Direction = ParameterDirection.Input
        UpdateDate.Value = GetDateTimeNow()
        Params(10) = UpdateDate

        Dim MdType As New SqlParameter("@MdType", SqlDbType.VarChar, 25)
        MdType.Direction = ParameterDirection.Input
        MdType.Value = Trim(txtMDtype.Text)
        Params(11) = MdType

        Dim QpiAreaCode As New SqlParameter("@QpiAreaCode", SqlDbType.VarChar, 3)
        QpiAreaCode.Direction = ParameterDirection.Input
        QpiAreaCode.Value = GetCode(CboQpiAreaCode.Text)
        Params(12) = QpiAreaCode

        Dim ParentCustCode As New SqlParameter("@ParentCustCode", SqlDbType.VarChar, 10)
        ParentCustCode.Direction = ParameterDirection.Input
        ParentCustCode.Value = Trim(txtParentCustCode.Text)
        Params(13) = ParentCustCode

        Dim LastUser As New SqlParameter("@LastUser", SqlDbType.VarChar, 8)
        LastUser.Direction = ParameterDirection.Input
        LastUser.Value = IIf(Trim(gCurrUser) = "", "", gCurrUser)    'Trim(txtLastUser.Text)
        Params(14) = LastUser

        Dim ZueCode As New SqlParameter("@ZueCode", SqlDbType.VarChar, 10)
        ZueCode.Direction = ParameterDirection.Input
        ZueCode.Value = Trim(txtZueCode.Text)
        Params(15) = ZueCode

        Try
            BusinessObject.Sub_Insert(ServerPath2, "CustomerCT_Insert", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Sub_Update()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(15) As SqlParameter

        Dim CustCode As New SqlParameter("@CustCode", SqlDbType.VarChar, 10)
        CustCode.Direction = ParameterDirection.Input
        CustCode.Value = txtCode.Text
        Params(0) = CustCode

        Dim CustName As New SqlParameter("@CustName", SqlDbType.VarChar, 80)
        CustName.Direction = ParameterDirection.Input
        CustName.Value = txtDescription.Text
        Params(1) = CustName

        Dim CustType As New SqlParameter("@CustType", SqlDbType.Float)
        CustType.Direction = ParameterDirection.Input
        CustType.Value = Val(GetCode(tmpType))      ' Val(GetCode(cboType.Text))
        Params(2) = CustType

        Dim Address1 As New SqlParameter("@Address1", SqlDbType.VarChar, 150)
        Address1.Direction = ParameterDirection.Input
        Address1.Value = txtAddress1.Text
        Params(3) = Address1

        Dim Address2 As New SqlParameter("@Address2", SqlDbType.VarChar, 150)
        Address2.Direction = ParameterDirection.Input
        Address2.Value = txtAddress2.Text
        Params(4) = Address2

        Dim Address3 As New SqlParameter("@Address3", SqlDbType.VarChar, 150)
        Address3.Direction = ParameterDirection.Input
        Address3.Value = txtAddress3.Text
        Params(5) = Address3

        Dim AreaCode As New SqlParameter("@AreaCode", SqlDbType.VarChar, 3)
        AreaCode.Direction = ParameterDirection.Input
        AreaCode.Value = txtAreaCode.Text
        Params(6) = AreaCode

        Dim TerritoryDR As New SqlParameter("@TerritoryDR", SqlDbType.VarChar, 5)
        TerritoryDR.Direction = ParameterDirection.Input
        TerritoryDR.Value = GetCode(tmpTerritory)    ' GetCode(cboTerritoryDR.Text)
        Params(7) = TerritoryDR

        Dim Metro_Code As New SqlParameter("@Metro_Code", SqlDbType.VarChar, 50)
        Metro_Code.Direction = ParameterDirection.Input
        Metro_Code.Value = txtMetro_Code.Text
        Params(8) = Metro_Code

        'Dim CreateDate As New SqlParameter("@CreateDate", SqlDbType.DateTime)
        'CreateDate.Direction = ParameterDirection.Input
        'CreateDate.Value = Now()
        'Params(9) = CreateDate

        Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime)
        UpdateDate.Direction = ParameterDirection.Input
        UpdateDate.Value = Now()
        Params(9) = UpdateDate

        Dim MdType As New SqlParameter("@MdType", SqlDbType.VarChar, 25)
        MdType.Direction = ParameterDirection.Input
        MdType.Value = txtMDtype.Text
        Params(10) = MdType

        Dim QpiAreaCode As New SqlParameter("@QpiAreaCode", SqlDbType.VarChar, 3)
        QpiAreaCode.Direction = ParameterDirection.Input
        QpiAreaCode.Value = GetCode(CboQpiAreaCode.Text)
        Params(11) = QpiAreaCode

        Dim ParentCustCode As New SqlParameter("@ParentCustCode", SqlDbType.VarChar, 10)
        ParentCustCode.Direction = ParameterDirection.Input
        ParentCustCode.Value = txtParentCustCode.Text
        Params(12) = ParentCustCode

        Dim LastUser As New SqlParameter("@LastUser", SqlDbType.VarChar, 8)
        LastUser.Direction = ParameterDirection.Input
        LastUser.Value = IIf(Trim(gCurrUser) = "", "", gCurrUser)      ' txtLastUser.Text
        Params(13) = LastUser

        Dim Rowid As New SqlParameter("@Rowid", SqlDbType.Float)
        Rowid.Direction = ParameterDirection.Input
        Rowid.Value = Val(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 0).ToString)
        Params(14) = Rowid

        Dim ZueCode As New SqlParameter("@ZueCode", SqlDbType.VarChar, 10)
        ZueCode.Direction = ParameterDirection.Input
        ZueCode.Value = txtZueCode.Text
        Params(15) = ZueCode

        Try
            BusinessObject.Sub_Update(ServerPath2, "CustomerCT_Update", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Sub_Show()
        If RemoteDataSet.CustomerCodTab_Show.Count > 0 Then RemoteDataSet.CustomerCodTab_Show.Clear()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Try
            BusinessObject.Sub_Show(ServerPath2, "CustomerCodTab_Show", CommandType.StoredProcedure, RemoteDataSet, "CustomerCodTab_Show")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        DataGrid1.DataSource = RemoteDataSet.CustomerCodTab_Show
    End Sub
    Private Sub Load_CustomerType()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "CustomerType_Combo", CommandType.StoredProcedure, RemoteDataSet, "CustomerType_Combo")
        cboType.DataSource = RemoteDataSet.CustomerType_Combo
        cboType.DisplayMember = "Type"
    End Sub
    Private Sub Load_Territory()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "Territory_Combo2", CommandType.StoredProcedure, RemoteDataSet, "Territory_Combo")
        cboTerritoryDR.DataSource = RemoteDataSet.Territory_Combo
        cboTerritoryDR.DisplayMember = "TerritoryDesc"
    End Sub

    Private Sub Load_QpiAreaCode()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "QPIareaCode_Combo", CommandType.StoredProcedure, RemoteDataSet, "QPIareaCode_Combo")
        CboQpiAreaCode.DataSource = RemoteDataSet.QPIareaCode_Combo
        CboQpiAreaCode.DisplayMember = "QareaCode"
    End Sub

    Private Sub Sub_Select(ByVal dbParams() As String, ByVal UpdateMode As String)
        'select case if add,edit or delete
        Dim i As Integer
        Dim myRowid As Integer
        Select Case UpdateMode
            Case "Insert"
                Dim BusinessObject As New BusinessLayer.clsFileMaintenance
                myRowid = CInt(BusinessObject.Sub_ReturnIntegerResult(ServerPath2, "CustomerCT_GetInsertedRowid", CommandType.StoredProcedure))
            Case "Update"
                myRowid = CInt(dbParams(0))
        End Select
        For i = 0 To (RemoteDataSet.CustomerCodTab_Show.Rows.Count - 1)
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
        Dim Rowid As New SqlParameter("@Rowid", SqlDbType.Int)
        Rowid.Direction = ParameterDirection.Input
        Rowid.Value = Trim(txtRowid.Text)
        Params(0) = Rowid
        BusinessObject.Sub_Delete(ServerPath2, "CustomerCT_Delete", CommandType.StoredProcedure, Params)
    End Sub
    Private Sub CustomerCT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        modControlBehavior.EnableControls(Me, False)
        Me.Location = New Point(0, 0)
        btnSw = False
        btnGenerate.Enabled = False
        Button1.Enabled = False
        txtLastUser.Text = gCurrUser
    End Sub
    Private Sub DataGrid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.Click     ', DataGrid1.CurrentCellChanged
        Dim xDat As Date
        forCancel()
        With DataGrid1
            txtRowid.Text = .Item(.CurrentCell.RowNumber, 0).ToString
            txtCode.Text = .Item(.CurrentCell.RowNumber, 1).ToString
            txtDescription.Text = .Item(.CurrentCell.RowNumber, 2).ToString
            cboType.Text = .Item(.CurrentCell.RowNumber, 3).ToString
            tmpType = .Item(.CurrentCell.RowNumber, 3).ToString
            txtAddress1.Text = .Item(.CurrentCell.RowNumber, 4).ToString
            txtAddress2.Text = .Item(.CurrentCell.RowNumber, 5).ToString
            txtAddress3.Text = .Item(.CurrentCell.RowNumber, 6).ToString
            txtAreaCode.Text = .Item(.CurrentCell.RowNumber, 7).ToString
            cboTerritoryDR.Text = .Item(.CurrentCell.RowNumber, 8).ToString
            tmpTerritory = .Item(.CurrentCell.RowNumber, 8).ToString
            txtMetro_Code.Text = .Item(.CurrentCell.RowNumber, 9).ToString
            z = .Item(.CurrentCell.RowNumber, 10).ToString
            If z <> "" Then
                xDat = CDate(z)
                lblCreateDate.Text = Format(xDat, "MM/dd/yyyy")
            Else
                lblCreateDate.Text = ""
            End If
            z = .Item(.CurrentCell.RowNumber, 11).ToString
            If z <> "" Then
                xDat = CDate(z)
                lblUpdateDate.Text = Format(xDat, "MM/dd/yyyy")
            Else
                lblUpdateDate.Text = ""
            End If
            txtMDtype.Text = .Item(.CurrentCell.RowNumber, 12).ToString
            CboQpiAreaCode.Text = .Item(.CurrentCell.RowNumber, 13).ToString
            txtParentCustCode.Text = .Item(.CurrentCell.RowNumber, 14).ToString
            txtLastUser.Text = .Item(.CurrentCell.RowNumber, 15).ToString
            txtZueCode.Text = .Item(.CurrentCell.RowNumber, 16).ToString
            .Select(.CurrentCell.RowNumber)
        End With
    End Sub
    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click

        If MessageBox.Show("Do you want to generate a Customer Code for this Territory : " & cboTerritoryDR.Text & "?", _
        "Customer Info Validation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(1) As SqlParameter

            Dim Territory As New SqlParameter("@Territory", SqlDbType.VarChar, 25)
            Territory.Direction = ParameterDirection.Input
            Territory.Value = GetCode(cboTerritoryDR.Text)
            Params(0) = Territory
            Dim CustomerCode As New SqlParameter("@CustomerCode", SqlDbType.VarChar, 25)
            CustomerCode.Direction = ParameterDirection.Output
            CustomerCode.Value = txtDescription.Text
            Params(1) = CustomerCode
            Try
                BusinessObject.Sub_Insert(ServerPath, "GenerateCustomerCode", CommandType.StoredProcedure, Params)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            txtCode.Text = CStr(CustomerCode.Value)
        End If
    End Sub
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Private Function Create_SearchCondition() As String
        Dim MyControl As Control
        Dim MyString As String, vTxtBox As String
        Dim Spacer As String
        SearchString = ""
        For Each MyControl In Me.Controls
            'If TypeOf MyControl Is TextBox Or (TypeOf MyControl Is ComboBox And VisualBasic.InStr(VisualBasic.UCase(MyControl.Text), "N/A") = 0) Then
            If TypeOf MyControl Is TextBox Or (TypeOf MyControl Is ComboBox And MyControl.Text > "") Then
                vTxtBox = Trim(MyControl.Text)
                If TypeOf MyControl Is ComboBox Then
                    vTxtBox = GetCode(Trim(MyControl.Text))
                Else
                    vTxtBox = Trim(MyControl.Text)
                End If
                If vTxtBox > "" Then
                    Spacer = VisualBasic.Space(15 - VisualBasic.Len(MyControl.AccessibleDescription)) & VisualBasic.vbTab
                    If MyString = "" Then
                        'If InStr(Trim(vTxtBox), "*") <> 0 Then
                        'vTxtBox = StrTran(Trim(vTxtBox), "*", "%")
                        MyString = MyControl.AccessibleDescription & " like '%" & vTxtBox & "%' "
                        SearchString = MyControl.AccessibleDescription & Spacer & " : " & VisualBasic.vbTab & vTxtBox
                        'Else
                        '    MyString = MyControl.AccessibleDescription & " = '" & vTxtBox & "'"
                        '    SearchString = MyControl.AccessibleDescription & Spacer & " : " & VisualBasic.vbTab & vTxtBox
                        'End If
                    Else
                        'If InStr(Trim(vTxtBox), "*") <> 0 Then
                        'vTxtBox = StrTran(Trim(vTxtBox), "*", "%")
                        MyString = MyString & " and " & MyControl.AccessibleDescription & " like '%" & vTxtBox & "%' "
                        SearchString = SearchString & VisualBasic.vbCrLf & MyControl.AccessibleDescription & Spacer & " : " & VisualBasic.vbTab & vTxtBox
                        'Else
                        '    MyString = MyString & " and " & MyControl.AccessibleDescription & " = '" & vTxtBox & "'"
                        '    SearchString = SearchString & VisualBasic.vbCrLf & MyControl.AccessibleDescription & Spacer & " : " & VisualBasic.vbTab & vTxtBox
                        'End If
                    End If
                End If
            End If
        Next
        If MyString = Nothing Then
            MyString = " 1=1 "
        End If
        Return MyString
    End Function

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        Dim MyControl As Control
        For Each MyControl In Me.Controls
            MyControl.Enabled = True
        Next
        ControlMaintenance.ClearInputControls(Me)
        Button1.Enabled = True
        cmdEdit.Hide()
        cmdCancel.Show()
        cmdAdd.Enabled = False
        cmdDelete.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Create_SearchCondition()
        If MessageBox.Show("Is this search condition correct?" & vbCrLf & SearchString, "Customer Info Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If RemoteDataSet.CustomerCodTab_Show.Count > 0 Then RemoteDataSet.CustomerCodTab_Show.Clear()

            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter

            Dim Where As New SqlParameter("@Where", SqlDbType.NVarChar)
            Where.Direction = ParameterDirection.Input
            Where.Value = Create_SearchCondition()
            Params(0) = Where

            DataGrid1.DataSource = Nothing

            BusinessObject.Sub_Show(ServerPath2, "CustomerCT_DynamicSearch", CommandType.StoredProcedure, RemoteDataSet, "CustomerCodTab_Show", Params)

            DataGrid1.DataSource = RemoteDataSet.CustomerCodTab_Show
        End If
    End Sub

    Private Sub txtDescription_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescription.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtDescription_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDescription.Validating
        'If Trim(txtDescription.Text) = "" Then    'tests if entry is blank
        '    MessageBox.Show("Mandatory field!", "Critical!")  'gives message to put value
        '    e.Cancel() = True                  ' brings back the focus on this control/field
        'End If
    End Sub

    Private Sub cboType_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboType.KeyUp
        If e.KeyData.ToString = System.Windows.Forms.Keys.Up.ToString _
           Or e.KeyData.ToString = System.Windows.Forms.Keys.Left.ToString Then 'if key pressed is the up arrow it will select the next selection before the selction
            cboType.SelectedItem = cboType.SelectedIndex - 1
        ElseIf e.KeyData.ToString = System.Windows.Forms.Keys.Down.ToString _
           Or e.KeyData.ToString = System.Windows.Forms.Keys.Right.ToString Then 'if key pressed is the up arrow it will select the next selection after the selction
            cboType.SelectedItem = cboType.SelectedIndex + 1
        ElseIf DKcodes(e.KeyData) = True Then    'checking if the key pressed is alphanumeric (to disallow typing the entry)
            cboType.Text = ""     'if alphanumeric then the value of the field will be erased
        End If
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")      'moves control to the next control or field
        End If
    End Sub

    Private Sub cboType_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboType.Validating
        tmpType = Trim(cboType.Text)
    End Sub

    Private Sub txtAddress1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAddress1.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtAddress2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAddress2.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtAreaCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAreaCode.KeyUp
        'If e.KeyValue = 13 Then
        '    SendKeys.Send("{TAB}")
        'End If
    End Sub

    Private Sub cboTerritoryDR_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboTerritoryDR.KeyUp
        If e.KeyData.ToString = System.Windows.Forms.Keys.Up.ToString _
           Or e.KeyData.ToString = System.Windows.Forms.Keys.Left.ToString Then 'if key pressed is the up arrow it will select the next selection before the selction
            cboTerritoryDR.SelectedItem = cboTerritoryDR.SelectedIndex - 1
        ElseIf e.KeyData.ToString = System.Windows.Forms.Keys.Down.ToString _
           Or e.KeyData.ToString = System.Windows.Forms.Keys.Right.ToString Then 'if key pressed is the up arrow it will select the next selection after the selction
            cboTerritoryDR.SelectedItem = cboTerritoryDR.SelectedIndex + 1
        ElseIf DKcodes(e.KeyData) = True Then    'checking if the key pressed is alphanumeric (to disallow typing the entry)
            cboTerritoryDR.Text = ""     'if alphanumeric then the value of the field will be erased
        End If
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")      'moves control to the next control or field
        End If
    End Sub

    Private Sub cboTerritoryDR_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboTerritoryDR.Validating
        z = "Select c.PROVINCE FROM NewScores..Customer a "
        z = z & "INNER JOIN NewScores..Territory b ON a.TerritoryDr = b.Rowid "
        z = z & "INNER JOIN NewScores..Province c ON b.ProvinceDr = c.Rowid "
        z = z & "where b.territorycode = '" & GetCode(cboTerritoryDR.Text) & "' "
        txtAddress3.Text = FindValue(z)
        tmpTerritory = Trim(cboTerritoryDR.Text)
        txtMetro_Code.Select()
    End Sub

    Private Sub txtMetro_Code_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMetro_Code.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub CboQPIareaCode_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboQpiAreaCode.KeyUp
        If e.KeyData.ToString = System.Windows.Forms.Keys.Up.ToString _
           Or e.KeyData.ToString = System.Windows.Forms.Keys.Left.ToString Then 'if key pressed is the up arrow it will select the next selection before the selction
            CboQpiAreaCode.SelectedItem = CboQpiAreaCode.SelectedIndex - 1
        ElseIf e.KeyData.ToString = System.Windows.Forms.Keys.Down.ToString _
           Or e.KeyData.ToString = System.Windows.Forms.Keys.Right.ToString Then 'if key pressed is the up arrow it will select the next selection after the selction
            CboQpiAreaCode.SelectedItem = CboQpiAreaCode.SelectedIndex + 1
        ElseIf DKcodes(e.KeyData) = True Then    'checking if the key pressed is alphanumeric (to disallow typing the entry)
            CboQpiAreaCode.Text = ""     'if alphanumeric then the value of the field will be erased
        End If
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")      'moves control to the next control or field
        End If
    End Sub

    Private Sub CboQPIareaCode_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CboQpiAreaCode.Validating
        'If Trim(CboQpiAreaCode.Text) = "" Then    'tests if entry is blank
        '    MessageBox.Show("Mandatory field!", "Critical!")  'gives message to put value
        '    e.Cancel() = True                  ' brings back the focus on this control/field
        'End If
    End Sub

    Private Sub txtMDtype_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMDtype.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtParentCustCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtParentCustCode.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtZueCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtZueCode.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class
