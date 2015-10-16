Imports System.Data.SqlClient

Public Class MedRepTerAssign
    Inherits System.Windows.Forms.Form
    Private RemoteDataSet2 As New MyDataSetDB
    Private EditMode As Boolean = False
    Private LoadSw As Boolean = False
    Private GrdCount As Integer, TerCount As Integer
    Private selcnt As Integer, ij As Integer
    Private currTerr As String
    Private oldDs As String, tmpSD As String, tmpED As String   '<-- added-DBrion
    Private forCancel_Prin As String, forCancel_Terr As String

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Load_PrincipalLst()
        Load_Territory()
        Sub_Show()
        Load_MRcombo()
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents lblCreateDate As System.Windows.Forms.Label
    Friend WithEvents lblUpdateDate As System.Windows.Forms.Label
    Friend WithEvents txtRowid As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDescription1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtStartDate As System.Windows.Forms.TextBox
    Friend WithEvents TxtEndDate As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DataGrid2 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGrid3 As System.Windows.Forms.DataGrid
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DGTabStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DGridTabStyl As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents MedRepresentative As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents StartDate As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents EndDate As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents cboMedRep As System.Windows.Forms.ComboBox
    Friend WithEvents TxtPrinCode As System.Windows.Forms.TextBox
    Friend WithEvents rowidmr As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents principalmr As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents mrcodemr As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents createdatemr As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents updatedatemr As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents useridmr As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgTerritory As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgPrincipal As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents territorydrmr As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents TxtLastUser As System.Windows.Forms.TextBox
    Friend WithEvents TxtTerritory As System.Windows.Forms.TextBox
    Friend WithEvents SqlValue As System.Windows.Forms.ComboBox
    Friend WithEvents dgTerritoryCode As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgPrinCode As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dg4 As System.Windows.Forms.DataGrid
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PTselected As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgProvince As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgRowid As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents SqlValue2 As System.Windows.Forms.ComboBox
    Friend WithEvents btnPMR As System.Windows.Forms.Button
    Friend WithEvents txtPMRname As System.Windows.Forms.TextBox
    Friend WithEvents txtPMRcode As System.Windows.Forms.TextBox
    Friend WithEvents TGsort As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
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
        Me.principalmr = New System.Windows.Forms.DataGridTextBoxColumn
        Me.StartDate = New System.Windows.Forms.DataGridTextBoxColumn
        Me.EndDate = New System.Windows.Forms.DataGridTextBoxColumn
        Me.mrcodemr = New System.Windows.Forms.DataGridTextBoxColumn
        Me.MedRepresentative = New System.Windows.Forms.DataGridTextBoxColumn
        Me.rowidmr = New System.Windows.Forms.DataGridTextBoxColumn
        Me.territorydrmr = New System.Windows.Forms.DataGridTextBoxColumn
        Me.createdatemr = New System.Windows.Forms.DataGridTextBoxColumn
        Me.updatedatemr = New System.Windows.Forms.DataGridTextBoxColumn
        Me.useridmr = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGrid3 = New System.Windows.Forms.DataGrid
        Me.DGridTabStyl = New System.Windows.Forms.DataGridTableStyle
        Me.dgTerritoryCode = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgTerritory = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgProvince = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgRowid = New System.Windows.Forms.DataGridTextBoxColumn
        Me.txtRowid = New System.Windows.Forms.TextBox
        Me.txtDescription1 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtTerritory = New System.Windows.Forms.TextBox
        Me.TxtStartDate = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtEndDate = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtPrinCode = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxtLastUser = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.DataGrid2 = New System.Windows.Forms.DataGrid
        Me.DGTabStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.dgPrinCode = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgPrincipal = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Label13 = New System.Windows.Forms.Label
        Me.cboMedRep = New System.Windows.Forms.ComboBox
        Me.SqlValue = New System.Windows.Forms.ComboBox
        Me.dg4 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Label2 = New System.Windows.Forms.Label
        Me.PTselected = New System.Windows.Forms.TextBox
        Me.SqlValue2 = New System.Windows.Forms.ComboBox
        Me.btnPMR = New System.Windows.Forms.Button
        Me.txtPMRname = New System.Windows.Forms.TextBox
        Me.txtPMRcode = New System.Windows.Forms.TextBox
        Me.TGsort = New System.Windows.Forms.Button
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(380, 639)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MedRep"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Visible = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(412, 506)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Create Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(610, 506)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Update Date"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCreateDate
        '
        Me.lblCreateDate.BackColor = System.Drawing.SystemColors.Info
        Me.lblCreateDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCreateDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCreateDate.Location = New System.Drawing.Point(484, 507)
        Me.lblCreateDate.Name = "lblCreateDate"
        Me.lblCreateDate.Size = New System.Drawing.Size(118, 21)
        Me.lblCreateDate.TabIndex = 6
        Me.lblCreateDate.Tag = "Input"
        '
        'lblUpdateDate
        '
        Me.lblUpdateDate.BackColor = System.Drawing.SystemColors.Info
        Me.lblUpdateDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUpdateDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblUpdateDate.Location = New System.Drawing.Point(682, 507)
        Me.lblUpdateDate.Name = "lblUpdateDate"
        Me.lblUpdateDate.Size = New System.Drawing.Size(118, 21)
        Me.lblUpdateDate.TabIndex = 7
        Me.lblUpdateDate.Tag = "Input"
        '
        'cmdExit
        '
        Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdExit.Location = New System.Drawing.Point(349, 567)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.TabIndex = 9
        Me.cmdExit.Tag = "Exit"
        Me.cmdExit.Text = "Exit"
        '
        'cmdAdd
        '
        Me.cmdAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAdd.Location = New System.Drawing.Point(109, 567)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.TabIndex = 6
        Me.cmdAdd.Tag = "Add"
        Me.cmdAdd.Text = "Add"
        '
        'cmdEdit
        '
        Me.cmdEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdEdit.Location = New System.Drawing.Point(189, 567)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.TabIndex = 7
        Me.cmdEdit.Tag = "Edit"
        Me.cmdEdit.Text = "Edit"
        '
        'cmdCancel
        '
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCancel.Location = New System.Drawing.Point(189, 567)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.TabIndex = 7
        Me.cmdCancel.Tag = "Cancel"
        Me.cmdCancel.Text = "Cancel"
        '
        'cmdDelete
        '
        Me.cmdDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdDelete.Location = New System.Drawing.Point(269, 567)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.TabIndex = 8
        Me.cmdDelete.Tag = "Delete"
        Me.cmdDelete.Text = "Delete"
        '
        'cmdSave
        '
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSave.Location = New System.Drawing.Point(269, 567)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.TabIndex = 8
        Me.cmdSave.Tag = "Save"
        Me.cmdSave.Text = "Save"
        '
        'DataGrid1
        '
        Me.DataGrid1.CaptionText = "Specialist List"
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(7, 209)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.RowHeaderWidth = 17
        Me.DataGrid1.Size = New System.Drawing.Size(805, 239)
        Me.DataGrid1.TabIndex = 0
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.DataGrid1.Tag = "View"
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Aqua
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightCyan
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.principalmr, Me.StartDate, Me.EndDate, Me.mrcodemr, Me.MedRepresentative, Me.rowidmr, Me.territorydrmr, Me.createdatemr, Me.updatedatemr, Me.useridmr})
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.AntiqueWhite
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "MRterri_Show"
        '
        'principalmr
        '
        Me.principalmr.Format = ""
        Me.principalmr.FormatInfo = Nothing
        Me.principalmr.MappingName = "princode"
        Me.principalmr.NullText = ""
        Me.principalmr.Width = 0
        '
        'StartDate
        '
        Me.StartDate.Format = "MM/dd/yyyy"
        Me.StartDate.FormatInfo = Nothing
        Me.StartDate.HeaderText = "Start Date"
        Me.StartDate.MappingName = "Start_Date"
        Me.StartDate.NullText = ""
        Me.StartDate.Width = 75
        '
        'EndDate
        '
        Me.EndDate.Format = "MM/dd/yyyy"
        Me.EndDate.FormatInfo = Nothing
        Me.EndDate.HeaderText = "End Date"
        Me.EndDate.MappingName = "End_Date"
        Me.EndDate.NullText = ""
        Me.EndDate.Width = 75
        '
        'mrcodemr
        '
        Me.mrcodemr.Format = ""
        Me.mrcodemr.FormatInfo = Nothing
        Me.mrcodemr.MappingName = "mrcode"
        Me.mrcodemr.NullText = ""
        Me.mrcodemr.Width = 0
        '
        'MedRepresentative
        '
        Me.MedRepresentative.Format = ""
        Me.MedRepresentative.FormatInfo = Nothing
        Me.MedRepresentative.HeaderText = "Specialist"
        Me.MedRepresentative.MappingName = "MedRepresentative"
        Me.MedRepresentative.NullText = ""
        Me.MedRepresentative.Width = 300
        '
        'rowidmr
        '
        Me.rowidmr.Format = ""
        Me.rowidmr.FormatInfo = Nothing
        Me.rowidmr.MappingName = "rownumber"
        Me.rowidmr.NullText = ""
        Me.rowidmr.Width = 0
        '
        'territorydrmr
        '
        Me.territorydrmr.Format = ""
        Me.territorydrmr.FormatInfo = Nothing
        Me.territorydrmr.HeaderText = "Territory"
        Me.territorydrmr.MappingName = "territorydr"
        Me.territorydrmr.NullText = ""
        Me.territorydrmr.Width = 0
        '
        'createdatemr
        '
        Me.createdatemr.Format = "MM/dd/yyyy"
        Me.createdatemr.FormatInfo = Nothing
        Me.createdatemr.MappingName = "createdate"
        Me.createdatemr.NullText = ""
        Me.createdatemr.Width = 0
        '
        'updatedatemr
        '
        Me.updatedatemr.Format = "MM/dd/yyyy"
        Me.updatedatemr.FormatInfo = Nothing
        Me.updatedatemr.MappingName = "updatedate"
        Me.updatedatemr.NullText = ""
        Me.updatedatemr.Width = 0
        '
        'useridmr
        '
        Me.useridmr.Format = ""
        Me.useridmr.FormatInfo = Nothing
        Me.useridmr.MappingName = "lastuser"
        Me.useridmr.NullText = ""
        Me.useridmr.Width = 0
        '
        'DataGrid3
        '
        Me.DataGrid3.CaptionText = "Territory List"
        Me.DataGrid3.DataMember = ""
        Me.DataGrid3.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid3.Location = New System.Drawing.Point(337, 19)
        Me.DataGrid3.Name = "DataGrid3"
        Me.DataGrid3.ParentRowsVisible = False
        Me.DataGrid3.ReadOnly = True
        Me.DataGrid3.RowHeaderWidth = 17
        Me.DataGrid3.Size = New System.Drawing.Size(475, 187)
        Me.DataGrid3.TabIndex = 63
        Me.DataGrid3.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DGridTabStyl})
        Me.DataGrid3.Tag = "View"
        '
        'DGridTabStyl
        '
        Me.DGridTabStyl.AlternatingBackColor = System.Drawing.Color.Aqua
        Me.DGridTabStyl.BackColor = System.Drawing.Color.LightCyan
        Me.DGridTabStyl.DataGrid = Me.DataGrid3
        Me.DGridTabStyl.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.dgTerritoryCode, Me.dgTerritory, Me.dgProvince, Me.dgRowid})
        Me.DGridTabStyl.HeaderBackColor = System.Drawing.Color.AntiqueWhite
        Me.DGridTabStyl.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DGridTabStyl.MappingName = "MRterriT_Show"
        '
        'dgTerritoryCode
        '
        Me.dgTerritoryCode.Format = ""
        Me.dgTerritoryCode.FormatInfo = Nothing
        Me.dgTerritoryCode.HeaderText = "Code"
        Me.dgTerritoryCode.MappingName = "territorycode"
        Me.dgTerritoryCode.NullText = ""
        Me.dgTerritoryCode.Width = 70
        '
        'dgTerritory
        '
        Me.dgTerritory.Format = ""
        Me.dgTerritory.FormatInfo = Nothing
        Me.dgTerritory.HeaderText = "Territory"
        Me.dgTerritory.MappingName = "territory"
        Me.dgTerritory.NullText = ""
        Me.dgTerritory.Width = 200
        '
        'dgProvince
        '
        Me.dgProvince.Format = ""
        Me.dgProvince.FormatInfo = Nothing
        Me.dgProvince.HeaderText = "Province"
        Me.dgProvince.MappingName = "province"
        Me.dgProvince.NullText = ""
        Me.dgProvince.Width = 75
        '
        'dgRowid
        '
        Me.dgRowid.Format = ""
        Me.dgRowid.FormatInfo = Nothing
        Me.dgRowid.MappingName = "rowid"
        Me.dgRowid.NullText = ""
        Me.dgRowid.Width = 0
        '
        'txtRowid
        '
        Me.txtRowid.Location = New System.Drawing.Point(412, 370)
        Me.txtRowid.Name = "txtRowid"
        Me.txtRowid.Size = New System.Drawing.Size(13, 20)
        Me.txtRowid.TabIndex = 43
        Me.txtRowid.Tag = "Input"
        Me.txtRowid.Text = ""
        Me.txtRowid.Visible = False
        '
        'txtDescription1
        '
        Me.txtDescription1.Location = New System.Drawing.Point(96, 400)
        Me.txtDescription1.Name = "txtDescription1"
        Me.txtDescription1.Size = New System.Drawing.Size(184, 20)
        Me.txtDescription1.TabIndex = 45
        Me.txtDescription1.Tag = "Input"
        Me.txtDescription1.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 532)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 21)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Territory"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtTerritory
        '
        Me.TxtTerritory.BackColor = System.Drawing.SystemColors.Info
        Me.TxtTerritory.Location = New System.Drawing.Point(71, 532)
        Me.TxtTerritory.MaxLength = 20
        Me.TxtTerritory.Name = "TxtTerritory"
        Me.TxtTerritory.ReadOnly = True
        Me.TxtTerritory.Size = New System.Drawing.Size(532, 20)
        Me.TxtTerritory.TabIndex = 5
        Me.TxtTerritory.Tag = "Input"
        Me.TxtTerritory.Text = ""
        '
        'TxtStartDate
        '
        Me.TxtStartDate.Location = New System.Drawing.Point(484, 480)
        Me.TxtStartDate.MaxLength = 10
        Me.TxtStartDate.Name = "TxtStartDate"
        Me.TxtStartDate.Size = New System.Drawing.Size(118, 20)
        Me.TxtStartDate.TabIndex = 4
        Me.TxtStartDate.Tag = "Input"
        Me.TxtStartDate.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(424, 480)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 20)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Start Date"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtEndDate
        '
        Me.TxtEndDate.Location = New System.Drawing.Point(682, 480)
        Me.TxtEndDate.MaxLength = 10
        Me.TxtEndDate.Name = "TxtEndDate"
        Me.TxtEndDate.Size = New System.Drawing.Size(118, 20)
        Me.TxtEndDate.TabIndex = 5
        Me.TxtEndDate.Tag = "Input"
        Me.TxtEndDate.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(622, 480)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 20)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "End Date"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtPrinCode
        '
        Me.TxtPrinCode.BackColor = System.Drawing.SystemColors.Info
        Me.TxtPrinCode.Location = New System.Drawing.Point(71, 507)
        Me.TxtPrinCode.MaxLength = 30
        Me.TxtPrinCode.Name = "TxtPrinCode"
        Me.TxtPrinCode.ReadOnly = True
        Me.TxtPrinCode.Size = New System.Drawing.Size(336, 20)
        Me.TxtPrinCode.TabIndex = 4
        Me.TxtPrinCode.Tag = "Input"
        Me.TxtPrinCode.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(12, 506)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 21)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Principal"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtLastUser
        '
        Me.TxtLastUser.Location = New System.Drawing.Point(430, 370)
        Me.TxtLastUser.MaxLength = 10
        Me.TxtLastUser.Name = "TxtLastUser"
        Me.TxtLastUser.Size = New System.Drawing.Size(64, 20)
        Me.TxtLastUser.TabIndex = 57
        Me.TxtLastUser.Tag = "Input"
        Me.TxtLastUser.Text = ""
        Me.TxtLastUser.Visible = False
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Location = New System.Drawing.Point(7, 558)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(612, 2)
        Me.Label10.TabIndex = 59
        '
        'Label11
        '
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(439, 564)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(192, 14)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "Easy Date Format Entry: ""MMDDYY"""
        '
        'Label12
        '
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(439, 579)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(184, 14)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "ex.  ""112595"" = ""Nov.25,1995"""
        '
        'DataGrid2
        '
        Me.DataGrid2.CaptionText = "Principal List"
        Me.DataGrid2.DataMember = ""
        Me.DataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid2.Location = New System.Drawing.Point(8, 19)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.ReadOnly = True
        Me.DataGrid2.RowHeaderWidth = 17
        Me.DataGrid2.Size = New System.Drawing.Size(325, 187)
        Me.DataGrid2.TabIndex = 62
        Me.DataGrid2.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DGTabStyle2})
        Me.DataGrid2.Tag = "View"
        '
        'DGTabStyle2
        '
        Me.DGTabStyle2.AlternatingBackColor = System.Drawing.Color.Aqua
        Me.DGTabStyle2.BackColor = System.Drawing.Color.LightCyan
        Me.DGTabStyle2.DataGrid = Me.DataGrid2
        Me.DGTabStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.dgPrinCode, Me.dgPrincipal})
        Me.DGTabStyle2.HeaderBackColor = System.Drawing.Color.AntiqueWhite
        Me.DGTabStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DGTabStyle2.MappingName = "MRterriP_Show"
        '
        'dgPrinCode
        '
        Me.dgPrinCode.Format = ""
        Me.dgPrinCode.FormatInfo = Nothing
        Me.dgPrinCode.HeaderText = "Code"
        Me.dgPrinCode.MappingName = "PrinCode"
        Me.dgPrinCode.NullText = ""
        Me.dgPrinCode.Width = 70
        '
        'dgPrincipal
        '
        Me.dgPrincipal.Format = ""
        Me.dgPrincipal.FormatInfo = Nothing
        Me.dgPrincipal.HeaderText = "Principal"
        Me.dgPrincipal.MappingName = "prinname"
        Me.dgPrincipal.NullText = ""
        Me.dgPrincipal.Width = 200
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(8, 2)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(605, 13)
        Me.Label13.TabIndex = 64
        Me.Label13.Text = "Select a Principal and a Territory before clicking Add. Plus Specialist before cl" & _
        "icking Edit."
        '
        'cboMedRep
        '
        Me.cboMedRep.Location = New System.Drawing.Point(450, 650)
        Me.cboMedRep.MaxLength = 55
        Me.cboMedRep.Name = "cboMedRep"
        Me.cboMedRep.Size = New System.Drawing.Size(336, 21)
        Me.cboMedRep.TabIndex = 0
        Me.cboMedRep.Tag = "Input"
        Me.cboMedRep.Visible = False
        '
        'SqlValue
        '
        Me.SqlValue.Location = New System.Drawing.Point(239, 313)
        Me.SqlValue.Name = "SqlValue"
        Me.SqlValue.Size = New System.Drawing.Size(146, 21)
        Me.SqlValue.TabIndex = 71
        Me.SqlValue.Visible = False
        '
        'dg4
        '
        Me.dg4.DataMember = ""
        Me.dg4.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dg4.Location = New System.Drawing.Point(367, 209)
        Me.dg4.Name = "dg4"
        Me.dg4.TabIndex = 73
        Me.dg4.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        Me.dg4.Visible = False
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.dg4
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "GenericQryProc"
        Me.DataGridTableStyle2.ReadOnly = True
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.MappingName = "fld1"
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.MappingName = "fld2"
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(6, 471)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(612, 2)
        Me.Label2.TabIndex = 74
        '
        'PTselected
        '
        Me.PTselected.BackColor = System.Drawing.Color.FloralWhite
        Me.PTselected.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PTselected.Location = New System.Drawing.Point(6, 454)
        Me.PTselected.Name = "PTselected"
        Me.PTselected.Size = New System.Drawing.Size(804, 13)
        Me.PTselected.TabIndex = 76
        Me.PTselected.Text = ""
        '
        'SqlValue2
        '
        Me.SqlValue2.Location = New System.Drawing.Point(231, 370)
        Me.SqlValue2.Name = "SqlValue2"
        Me.SqlValue2.Size = New System.Drawing.Size(146, 21)
        Me.SqlValue2.TabIndex = 77
        Me.SqlValue2.Visible = False
        '
        'btnPMR
        '
        Me.btnPMR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPMR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPMR.Location = New System.Drawing.Point(4, 480)
        Me.btnPMR.Name = "btnPMR"
        Me.btnPMR.Size = New System.Drawing.Size(63, 20)
        Me.btnPMR.TabIndex = 1
        Me.btnPMR.Tag = ""
        Me.btnPMR.Text = "Specialist"
        '
        'txtPMRname
        '
        Me.txtPMRname.Location = New System.Drawing.Point(141, 480)
        Me.txtPMRname.Name = "txtPMRname"
        Me.txtPMRname.Size = New System.Drawing.Size(263, 20)
        Me.txtPMRname.TabIndex = 3
        Me.txtPMRname.Tag = "Input"
        Me.txtPMRname.Text = ""
        '
        'txtPMRcode
        '
        Me.txtPMRcode.Location = New System.Drawing.Point(71, 480)
        Me.txtPMRcode.Name = "txtPMRcode"
        Me.txtPMRcode.Size = New System.Drawing.Size(69, 20)
        Me.txtPMRcode.TabIndex = 2
        Me.txtPMRcode.Tag = "Input"
        Me.txtPMRcode.Text = ""
        '
        'TGsort
        '
        Me.TGsort.Location = New System.Drawing.Point(787, 21)
        Me.TGsort.Name = "TGsort"
        Me.TGsort.Size = New System.Drawing.Size(22, 18)
        Me.TGsort.TabIndex = 78
        Me.TGsort.Text = "..."
        Me.TGsort.Visible = False
        '
        'MedRepTerAssign
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(818, 601)
        Me.Controls.Add(Me.TGsort)
        Me.Controls.Add(Me.btnPMR)
        Me.Controls.Add(Me.txtPMRname)
        Me.Controls.Add(Me.txtPMRcode)
        Me.Controls.Add(Me.PTselected)
        Me.Controls.Add(Me.TxtLastUser)
        Me.Controls.Add(Me.TxtPrinCode)
        Me.Controls.Add(Me.TxtEndDate)
        Me.Controls.Add(Me.TxtStartDate)
        Me.Controls.Add(Me.TxtTerritory)
        Me.Controls.Add(Me.txtRowid)
        Me.Controls.Add(Me.DataGrid3)
        Me.Controls.Add(Me.SqlValue2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dg4)
        Me.Controls.Add(Me.SqlValue)
        Me.Controls.Add(Me.cboMedRep)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.lblUpdateDate)
        Me.Controls.Add(Me.lblCreateDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.DataGrid2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MedRepTerAssign"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Specialist Territory Assignment"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        modControlBehavior.EnableControlsGroup(Me, True)
        'ControlMaintenance.ClearInputControls(Me)
        EditMode = False
        'added-DBrion --v
        btnSw = True
        'TxtPrinCode.Text = DataGrid2.Item(DataGrid2.CurrentCell.RowNumber, 0).ToString
        'TxtTerritory.Text = DataGrid3.Item(DataGrid3.CurrentCell.RowNumber, 0).ToString
        lblCreateDate.Text = GetDateTimeNow("MM/dd/yyyy")
        lblUpdateDate.Text = GetDateTimeNow("MM/dd/yyyy")
        TxtStartDate.Text = GetDateTimeNow("MM") & "/01/" & GetDateTimeNow("yyyy")
        tmpSD = Format(CDate(TxtStartDate.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
        TxtEndDate.Text = "12/31/2078"
        tmpED = Format(CDate(TxtEndDate.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
        forCancel_Prin = Trim(TxtPrinCode.Text)
        forCancel_Terr = Trim(TxtTerritory.Text)
        btnPMR.Enabled = True
        txtPMRcode.Select()
        'cboMedRep.Enabled = True
        'cboMedRep.Select()
        'added-DBrion --^
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If Trim(txtPMRcode.Text) = "" Then
            MessageBox.Show("Please select a record to modify!", _
                            "Record Selection", _
                            MessageBoxButtons.OK, _
                            MessageBoxIcon.Information, _
                            MessageBoxDefaultButton.Button1)

        Else
            modControlBehavior.EnableControlsGroup(Me, True)
            EditMode = True
            'added-DBrion --v
            btnSw = True
            lblUpdateDate.Text = GetDateTimeNow("MM/dd/yyyy")
            forCancel_Prin = Trim(TxtPrinCode.Text)
            forCancel_Terr = Trim(TxtTerritory.Text)
            btnPMR.Enabled = True
            txtPMRcode.Select()
            'cboMedRep.Select()
            'added-DBrion --^ 
        End If
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If txtRowid.Text > "" Then
            If (MessageBox.Show("Do you really want to delete this record?", _
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information, _
                MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then

                If InStr(Trim(TxtTerritory.Text), ",") = 0 Then
                    Sub_Delete()
                Else
                    For i = 0 To TerCount - 1
                        TxtTerritory.Text = dg4.Item(i, 0).ToString
                        Sub_Delete()
                    Next
                End If

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
        'txtCode.Enabled = True
        'txtCode.BackColor = Color.White
        'txtCode.ForeColor = Color.Black
        'added-DBrion --^
        modControlBehavior.EnableControls(Me, False)
        ControlMaintenance.ClearInputControls(Me)
        TxtPrinCode.Text = Trim(forCancel_Prin)
        TxtTerritory.Text = Trim(forCancel_Terr)
        EditMode = False
        btnPMR.Enabled = False
    End Sub

    Function tstRecord(ByVal vTer As String) As Boolean
        z = "select mrcode as fld1 from NewScores..MrArea "
        z = z & "where rtrim(princode) = '" & Trim(TxtPrinCode.Text) & "' "
        z = z & "  and rtrim(territorydr)   = '" & Trim(vTer) & "' "
        'If EditMode = True Then
        '    z = z & "  and rtrim(mrcode) = '" & Trim(txtPMRcode.Text) & "' "
        'End If
        z = z & "  and ( ('" & Trim(TxtStartDate.Text) & "' between start_date and end_date) "
        z = z & "       or ('" & Trim(TxtEndDate.Text) & "' between start_date and end_date) ) "
        If EditMode = True Then
            z = z & "  and rownumber <> '" & Trim(txtRowid.Text) & "' "
        End If
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Pram(0) As SqlParameter
        Dim SQLstmnt2 As New SqlParameter("@SqlQry", SqlDbType.NVarChar, 2950)
        SQLstmnt2.Direction = ParameterDirection.Input
        SQLstmnt2.Value = z
        Pram(0) = SQLstmnt2
        If RemoteDataSet2.GenericQryProc.Count > 0 Then RemoteDataSet2.GenericQryProc.Clear()
        Try
            BusinessObject.Sub_Show(ServerPath2, "GenericQryProc", CommandType.StoredProcedure, RemoteDataSet2, "GenericQryProc", Pram)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        SqlValue.DataSource = RemoteDataSet2.GenericQryProc
        SqlValue.DisplayMember = "fld1"
        If Trim(SqlValue.Text) <> "" Then
            MessageBox.Show("This Entry already exist! " & dg4.Item(i, 1).ToString, "Record Exsists!")
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If (MessageBox.Show("Are you sure you want to Save this Entry?", "Confirm Saving", _
              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)) _
              = DialogResult.Yes Then

            Dim Params(0) As String
            Params(0) = txtRowid.Text

            If EditMode = False Then
                'If InStr(Trim(TxtTerritory.Text), ", ") = 0 Then
                '    If tstRecord(Trim(TxtTerritory.Text)) = False Then
                '        Sub_Insert()
                '    Else
                '        Exit Sub
                '    End If
                'Else
                For i = 0 To TerCount - 1
                    TxtTerritory.Text = dg4.Item(i, 0).ToString
                    If tstRecord(Trim(TxtTerritory.Text)) = False Then
                        Sub_Insert()
                    End If
                Next
                'End If
            Else
                'If InStr(Trim(TxtTerritory.Text), ",") = 0 Then
                '    If tstRecord(Trim(TxtTerritory.Text)) = False Then
                '        Sub_Update()
                '    Else
                '        Exit Sub
                '    End If
                'Else
                For i = 0 To TerCount - 1
                    TxtTerritory.Text = dg4.Item(i, 0).ToString
                    If tstRecord(Trim(TxtTerritory.Text)) = False Then
                        Sub_Update()
                    End If
                Next
                'End If
            End If
            MessageBox.Show("Record/s successfully saved.", "Successful save!")
            EditMode = False                       'added-DBrion --^     the scrollbar
            modControlBehavior.EnableControls(Me, False)
            DataGrid1.DataSource = Nothing    'added-DBrion --v     to refresh and enable again 
            Sub_Show()
            Sub_Select(Params, CStr(IIf(EditMode = False, "Insert", "Update")))
            btnPMR.Enabled = False
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Sub_Insert()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(7) As SqlParameter

        Dim PrinCode As New SqlParameter("@PrinCode", SqlDbType.Char, 5)
        PrinCode.Direction = ParameterDirection.Input
        PrinCode.Value = Trim(TxtPrinCode.Text)
        Params(0) = PrinCode

        tmpSD = Format(CDate(TxtStartDate.Text), "M/d/yyyy") '& " " & GetDateTimeNow("h:mm:ss tt")
        Dim StartDate As New SqlParameter("@Start_Date", SqlDbType.DateTime)
        StartDate.Direction = ParameterDirection.Input
        StartDate.Value = Trim(TxtStartDate.Text)
        Params(1) = StartDate

        tmpED = Format(CDate(TxtEndDate.Text), "M/d/yyyy") '& " " & GetDateTimeNow("h:mm:ss tt")
        Dim EndDate As New SqlParameter("@End_Date", SqlDbType.DateTime)
        EndDate.Direction = ParameterDirection.Input
        EndDate.Value = Trim(TxtEndDate.Text)
        Params(2) = EndDate

        Dim MrCode As New SqlParameter("@MrCode", SqlDbType.Char, 10)
        MrCode.Direction = ParameterDirection.Input
        MrCode.Value = Trim(txtPMRcode.Text)
        Params(3) = MrCode

        'Dim s As String
        'Dim Pram(0) As SqlParameter
        's = "select rowid as fld1 from NewScores..Territory where rtrim(territorycode) = rtrim('" & Trim(TxtTerritory.Text) & "') "
        'Dim SQLstmnt1 As New SqlParameter("@SqlQry", SqlDbType.NVarChar, 2950)
        'SQLstmnt1.Direction = ParameterDirection.Input
        'SQLstmnt1.Value = s
        'Pram(0) = SQLstmnt1
        'Try
        '    BusinessObject.Sub_Show(ServerPath2, "GenericQryProc", CommandType.StoredProcedure, RemoteDataSet2, "GenericQryProc", Pram)
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'SqlValue.DataSource = RemoteDataSet2.GenericQryProc
        'SqlValue.DisplayMember = "fld1"
        Dim AreaCode As New SqlParameter("@Territorydr", SqlDbType.Int)
        AreaCode.Direction = ParameterDirection.Input
        AreaCode.Value = Trim(TxtTerritory.Text)     'Trim(SqlValue.Text)
        Params(4) = AreaCode
        'SqlValue.ResetText()
        'SqlValue.DataSource = Nothing
        'RemoteDataSet2.GenericQryProc.Clear()

        Dim CreateDate As New SqlParameter("@CreateDate", SqlDbType.DateTime)
        CreateDate.Direction = ParameterDirection.Input
        CreateDate.Value = GetDateTimeNow()
        Params(5) = CreateDate

        Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime)
        UpdateDate.Direction = ParameterDirection.Input
        UpdateDate.Value = GetDateTimeNow()
        Params(6) = UpdateDate

        Dim UserID As New SqlParameter("@LastUser", SqlDbType.Char, 10)
        UserID.Direction = ParameterDirection.Input
        UserID.Value = IIf(Trim(gCurrUser) = "", "", gCurrUser)
        Params(7) = UserID

        Try
            BusinessObject.Sub_Insert(ServerPath2, "MRterri_Insert", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Sub_Update()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(7) As SqlParameter

        Dim PrinCode As New SqlParameter("@PrinCode", SqlDbType.Char, 5)
        PrinCode.Direction = ParameterDirection.Input
        PrinCode.Value = Trim(TxtPrinCode.Text)
        Params(0) = PrinCode

        tmpSD = Format(CDate(TxtStartDate.Text), "M/d/yyyy")     '& " " & GetDateTimeNow("h:mm:ss tt")
        Dim StartDate As New SqlParameter("@Start_Date", SqlDbType.DateTime)
        StartDate.Direction = ParameterDirection.Input
        StartDate.Value = Trim(TxtStartDate.Text)
        Params(1) = StartDate

        tmpED = Format(CDate(TxtEndDate.Text), "M/d/yyyy")      '& " " & GetDateTimeNow("h:mm:ss tt")
        Dim EndDate As New SqlParameter("@End_Date", SqlDbType.DateTime)
        EndDate.Direction = ParameterDirection.Input
        EndDate.Value = Trim(TxtEndDate.Text)
        Params(2) = EndDate

        Dim MrCode As New SqlParameter("@MrCode", SqlDbType.Char, 10)
        MrCode.Direction = ParameterDirection.Input
        MrCode.Value = Trim(txtPMRcode.Text)
        Params(3) = MrCode

        'Dim s As String
        'Dim Pram(0) As SqlParameter
        's = "select rowid as fld1 from NewScores..Territory where rtrim(territorycode) = rtrim('" & GetCode(TxtTerritory.Text) & "') "
        'Dim SQLstmnt1 As New SqlParameter("@SqlQry", SqlDbType.NVarChar, 2950)
        'SQLstmnt1.Direction = ParameterDirection.Input
        'SQLstmnt1.Value = s
        'Pram(0) = SQLstmnt1
        'Try
        '    BusinessObject.Sub_Show(ServerPath2, "GenericQryProc", CommandType.StoredProcedure, RemoteDataSet2, "GenericQryProc", Pram)
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'SqlValue.DataSource = RemoteDataSet2.GenericQryProc
        'SqlValue.DisplayMember = "fld1"
        Dim AreaCode As New SqlParameter("@Territorydr", SqlDbType.Int)
        AreaCode.Direction = ParameterDirection.Input
        AreaCode.Value = Trim(TxtTerritory.Text)     'Trim(SqlValue.Text)
        Params(4) = AreaCode
        'SqlValue.ResetText()
        'SqlValue.DataSource = Nothing
        'RemoteDataSet2.GenericQryProc.Clear()

        Dim Rowid As New SqlParameter("@Rownumber", SqlDbType.Int)
        Rowid.Direction = ParameterDirection.Input
        Rowid.Value = Trim(txtRowid.Text)
        Params(5) = Rowid

        Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime)
        UpdateDate.Direction = ParameterDirection.Input
        UpdateDate.Value = GetDateTimeNow()
        Params(6) = UpdateDate

        Dim UserID As New SqlParameter("@LastUser", SqlDbType.Char, 10)
        UserID.Direction = ParameterDirection.Input
        UserID.Value = IIf(Trim(gCurrUser) = "", "", gCurrUser)
        Params(7) = UserID

        Try
            BusinessObject.Sub_Update(ServerPath2, "MRterri_Update", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub partofSubShow()
        'GrdCount = RemoteDataSet2.MRterriT_Show.Count
        'SqlValue.ResetText() : arrCtr = 0
        'For i = 0 To GrdCount - 1
        '    If DataGrid3.IsSelected(i) Then
        '        SqlValue.Items.Add(DataGrid3.Item(i, 0).ToString())  ': s = SqlValue.Items(0).ToString
        '        arrCtr = arrCtr + 1
        '    End If
        'Next i

        'RemoteDataSet2.GenericQryProc.Clear()
        ''SqlValue.Items.Add(DataGrid3.Item(DataGrid3.CurrentCell.RowNumber, 0).ToString)
        's = "select rowid as fld1, territory as fld2 from NewScores..Territory "
        's = s & "where rtrim(territorycode) = rtrim('" & DataGrid3.Item(DataGrid3.CurrentCell.RowNumber, 0).ToString & "') "
        'If SqlValue.Items.Count > 1 Then
        '    For i = 0 To SqlValue.Items.Count - 1
        '        If SqlValue.Items(i).ToString <> DataGrid3.Item(DataGrid3.CurrentCell.RowNumber, 0).ToString Then
        '            s = s & "  or rtrim(territorycode) = rtrim('" & SqlValue.Items(i).ToString & "') "
        '        End If
        '    Next i
        'End If
        'If SqlValue.Items.Count <> 0 Then SqlValue.Items.Clear()
        'Dim SQLstmnt1 As New SqlParameter("@SqlQry", SqlDbType.NVarChar, 2950)
        'SQLstmnt1.Direction = ParameterDirection.Input
        'SQLstmnt1.Value = s
        'Prm(0) = SQLstmnt1
        'Try
        '    BusinessObject.Sub_Show(ServerPath2, "GenericQryProc", CommandType.StoredProcedure, RemoteDataSet2, "GenericQryProc", Prm)
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'TerCount = RemoteDataSet2.GenericQryProc.Count
        'dg4.DataSource = RemoteDataSet2.GenericQryProc
        'Dim WerClause As New SqlParameter("@where", SqlDbType.NVarChar, 1000)
        'WerClause.Direction = ParameterDirection.Input
        'z = " princode = '" & DataGrid2.Item(DataGrid2.CurrentCell.RowNumber, 0).ToString & "' "
        'z = z & " and (convert(char, territorydr) = '" & dg4.Item(0, 0).ToString & "' "
        'If RemoteDataSet2.GenericQryProc.Count > 1 Then
        '    For i = 1 To RemoteDataSet2.GenericQryProc.Count - 1
        '        z = z & " or convert(char, territorydr) = '" & dg4.Item(i, 0).ToString & "' "
        '    Next i
        'End If
        'z = z & ") "
        'WerClause.Value = z
        'Params(0) = WerClause
        'Try
        '    BusinessObject.Sub_Show(ServerPath2, "MRterri_Show", CommandType.StoredProcedure, RemoteDataSet2, "MRterri_Show", Params)
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'TxtTerritory.Text = ""
        'TxtPrinCode.Text = ""
        'PTselected.Text = DataGrid2.Item(DataGrid2.CurrentCell.RowNumber, 1).ToString & "/"
        'TxtPrinCode.Text = DataGrid2.Item(DataGrid2.CurrentCell.RowNumber, 0).ToString
        'For i = 0 To RemoteDataSet2.GenericQryProc.Count - 1
        '    PTselected.Text = PTselected.Text & Trim(dg4.Item(i, 1).ToString) & ","
        '    TxtTerritory.Text = TxtTerritory.Text & Trim(dg4.Item(i, 0).ToString) & ", "
        'Next
        'SqlValue.ResetText()
        'SqlValue.DataSource = Nothing
    End Sub

    Private Sub Sub_Show()
        If RemoteDataSet2.MRterri_Show.Count > 0 Then RemoteDataSet2.MRterri_Show.Clear()
        Dim Params(0) As SqlParameter
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim s As String, terCodTmp As String, terRowTmp As String
        Dim Prm(0) As SqlParameter
        Dim arrCtr As Integer

        TxtTerritory.Text = "" : terCodTmp = "" : terRowTmp = ""
        TxtPrinCode.Text = ""
        PTselected.Text = DataGrid2.Item(DataGrid2.CurrentCell.RowNumber, 1).ToString & "/"
        TxtPrinCode.Text = DataGrid2.Item(DataGrid2.CurrentCell.RowNumber, 0).ToString
        If LoadSw = False Then
            TxtTerritory.Text = DataGrid3.Item(DataGrid3.CurrentCell.RowNumber, 0).ToString
            LoadSw = True
        End If
        GrdCount = RemoteDataSet2.MRterriT_Show.Count
        'SqlValue.DataSource = Nothing : SqlValue.DisplayMember = "" : SqlValue.ResetText()
        'SqlValue2.DataSource = Nothing : SqlValue2.DisplayMember = "" : SqlValue2.ResetText()
        arrCtr = 0
        For i = 0 To GrdCount - 1
            If DataGrid3.IsSelected(i) Then
                PTselected.Text = PTselected.Text & Trim(DataGrid3.Item(i, 1).ToString) & ","
                TxtTerritory.Text = TxtTerritory.Text & Trim(DataGrid3.Item(i, 0).ToString) & ", "
                terCodTmp = terCodTmp & Trim(DataGrid3.Item(i, 0).ToString) & ", "
                terRowTmp = terRowTmp & Trim(DataGrid3.Item(i, 3).ToString) & ", "
                'SqlValue.Items.Add(DataGrid3.Item(i, 0).ToString)
                'SqlValue2.Items.Add(DataGrid3.Item(i, 3).ToString)
                arrCtr = arrCtr + 1
            End If
        Next i
        terCodTmp = NxtLineFromComma(terCodTmp, "STR")
        terRowTmp = NxtLineFromComma(terRowTmp, "NUM")
        If terCodTmp = "''" Then
            terCodTmp = "'" & DataGrid3.Item(DataGrid3.CurrentCell.RowNumber, 0).ToString & "'"
        End If
        If terRowTmp = "''" Then
            terRowTmp = DataGrid3.Item(DataGrid3.CurrentCell.RowNumber, 3).ToString
        End If
        TerCount = arrCtr
        Dim tmpstr As String, xz As String
        Dim cutlen As Integer
        tmpstr = "" : cutlen = 0
        'If arrCtr > 1 Then
        '    s = "'" & SqlValue.Items.Item(0).ToString() & "'"
        '    xz = "'" & SqlValue2.Items.Item(0).ToString() & "'"
        '    For i = 1 To arrCtr - 1
        '        If cutlen = 5 Then
        '            s = s & Chr(13) & ", '" & SqlValue.Items.Item(i).ToString() & "'"
        '            xz = xz & Chr(13) & ", '" & SqlValue2.Items.Item(i).ToString() & "'"
        '            cutlen = 0
        '        Else
        '            s = s & ", '" & SqlValue.Items.Item(i).ToString() & "'"
        '            xz = xz & ", '" & SqlValue2.Items.Item(i).ToString() & "'"
        '            cutlen = cutlen + 1
        '        End If
        '    Next
        'Else
        '    s = "'" & Trim(DataGrid3.Item(DataGrid3.CurrentCell.RowNumber, 0).ToString) & "'"
        '    xz = "'" & Trim(DataGrid3.Item(DataGrid3.CurrentCell.RowNumber, 3).ToString) & "'"
        '    PTselected.Text = DataGrid2.Item(DataGrid2.CurrentCell.RowNumber, 1).ToString & "/" & _
        '                      Trim(DataGrid3.Item(DataGrid3.CurrentCell.RowNumber, 1).ToString)
        '    TxtTerritory.Text = Trim(DataGrid3.Item(DataGrid3.CurrentCell.RowNumber, 0).ToString)
        'End If
        dg4.DataSource = Nothing

        z = "select rowid as fld1, territory as fld2 from NewScores..Territory "
        z = z & "where rtrim(territorycode) in (" & terCodTmp & ") "

        'If SqlValue.Items.Count <> 0 Then SqlValue.Items.Clear()
        Dim SQLstmnt1 As New SqlParameter("@SqlQry", SqlDbType.NVarChar, 2950)
        SQLstmnt1.Direction = ParameterDirection.Input
        SQLstmnt1.Value = z
        Prm(0) = SQLstmnt1
        If RemoteDataSet2.dg4list.Count > 0 Then RemoteDataSet2.dg4list.Clear()
        Try
            BusinessObject.Sub_Show(ServerPath2, "GenericQryProc", CommandType.StoredProcedure, RemoteDataSet2, "dg4list", Prm)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        dg4.DataSource = RemoteDataSet2.dg4list
        DataGrid1.DataSource = Nothing
        Dim WerClause As New SqlParameter("@where", SqlDbType.NVarChar, 1000)
        WerClause.Direction = ParameterDirection.Input
        z = Chr(13) & " princode = '" & DataGrid2.Item(DataGrid2.CurrentCell.RowNumber, 0).ToString & "' "
        z = z & " and convert(char, territorydr) in (" & terRowTmp & ") "
        WerClause.Value = z
        Params(0) = WerClause
        Try
            BusinessObject.Sub_Show(ServerPath2, "MRterri_Show", CommandType.StoredProcedure, RemoteDataSet2, "MRterri_Show", Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        DataGrid1.DataSource = RemoteDataSet2.MRterri_Show
        'SqlValue.DataSource = Nothing : SqlValue.DisplayMember = "" : SqlValue.ResetText()
        'SqlValue2.DataSource = Nothing : SqlValue2.DisplayMember = "" : SqlValue2.ResetText()
    End Sub

    Private Sub SortTerritory()
        DataGrid3.DataSource = Nothing
        If RemoteDataSet2.MRterriT_Show.Count > 0 Then RemoteDataSet2.MRterriT_Show.Clear()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "MRterriTg_Show", CommandType.StoredProcedure, RemoteDataSet2, "MRterriT_Show")
        DataGrid3.DataSource = RemoteDataSet2.MRterriT_Show
    End Sub

    Private Sub Load_PrincipalLst()
        If RemoteDataSet2.MRterriP_Show.Count > 0 Then RemoteDataSet2.MRterriP_Show.Clear()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "MRterriP_Show", CommandType.StoredProcedure, RemoteDataSet2, "MRterriP_Show")
        DataGrid2.DataSource = RemoteDataSet2.MRterriP_Show
    End Sub

    Private Sub Load_Territory()
        If RemoteDataSet2.MRterriT_Show.Count > 0 Then RemoteDataSet2.MRterriT_Show.Clear()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "MRterriT_Show", CommandType.StoredProcedure, RemoteDataSet2, "MRterriT_Show")
        DataGrid3.DataSource = RemoteDataSet2.MRterriT_Show
    End Sub

    Private Sub Load_MRcombo()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "MRcombo2", CommandType.StoredProcedure, RemoteDataSet2, "MRcombo2")
        cboMedRep.DataSource = RemoteDataSet2.MRcombo2
        cboMedRep.DisplayMember = "MedRepA"
        GrdCount = RemoteDataSet2.MRcombo2.Count
    End Sub

    Private Sub Sub_Select(ByVal dbParams() As String, ByVal UpdateMode As String)
        'select case if add,edit or delete
        Dim i As Integer
        Dim myRowid As Integer
        Select Case UpdateMode
            Case "Insert"
                Dim BusinessObject As New BusinessLayer.clsFileMaintenance
                myRowid = CInt(BusinessObject.Sub_ReturnIntegerResult(ServerPath2, "MRterri_GetInsertedRowid", CommandType.StoredProcedure))
            Case "Update"
                myRowid = CInt(dbParams(0))
        End Select
        For i = 0 To (RemoteDataSet2.MRterri_Show.Rows.Count - 1)
            With DataGrid1
                If myRowid = CInt(.Item(i, 5)) Then
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
        Dim Rowid As New SqlParameter("@Rownumber", SqlDbType.Int)
        Rowid.Direction = ParameterDirection.Input
        Rowid.Value = Trim(txtRowid.Text)
        Params(0) = Rowid
        Try
            BusinessObject.Sub_Delete(ServerPath2, "MRterri_Delete", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MedRepTerAssign_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        modControlBehavior.EnableControls(Me, False)
        btnSw = False    '<-- added-DBrion
        tmpSD = ""
        tmpED = ""
        btnPMR.Enabled = False
        btnPMR.Select()
    End Sub

    Private Sub DataGrid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.Click, DataGrid1.CurrentCellChanged
        FldsPopulate()
    End Sub

    Private Sub DataGrid2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid2.Click
        Sub_Show()
        FldsPopulate()
    End Sub

    Private Sub DataGrid3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid3.Click
        selcnt = 1
        GrdCount = RemoteDataSet2.MRterriT_Show.Count
        For i = 0 To GrdCount - 1
            With DataGrid3
                If .IsSelected(i) Then
                    VarArr(selcnt) = .Item(i, 3).ToString
                    selcnt = selcnt + 1
                End If
            End With
        Next i
        Sub_Show()
        FldsPopulate()
    End Sub

    Public Function GetSelectedRows(ByVal dg As DataGrid) As System.Collections.ArrayList
        Dim al As New ArrayList

        'Dim cm As CurrencyManager = Me.BindingContext(dg.DataSource, dg.DataMember)
        'Dim dv As DataView = CType(cm.List, DataView)

        'For i = 0 To dv.Count - 1
        '    If dg.IsSelected(i) Then
        '        al.Add(i)
        '    End If
        'Next i
        'Return al
    End Function 'GetSelectedRows

    'Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim s As String = "Selected rows:"
    '    Dim o As Object
    '    For Each o In GetSelectedRows(dataGrid1)
    '        s += " " + o.ToString()
    '    Next o
    '    MessageBox.Show(s)
    'End Sub 'button1_Click

    Private Sub FldsPopulate()
        Dim tmpMR As String
        Dim descSt As Integer
        With DataGrid1
            If RemoteDataSet2.MRterri_Show.Count > 0 Then
                txtRowid.Text = .Item(.CurrentCell.RowNumber, 5).ToString
                'TxtPrinCode.Text = DataGrid2.Item(DataGrid2.CurrentCell.RowNumber, 0).ToString
                'TxtTerritory.Text = DataGrid3.Item(DataGrid3.CurrentCell.RowNumber, 0).ToString
                'cboMedRep.Text = .Item(.CurrentCell.RowNumber, 4).ToString
                tmpMR = .Item(.CurrentCell.RowNumber, 4).ToString
                descSt = InStr(tmpMR, "--") + 2
                txtPMRname.Text = Mid(tmpMR, descSt, (Len(tmpMR) - descSt) + 1)
                txtPMRcode.Text = .Item(.CurrentCell.RowNumber, 3).ToString
                If Trim(.Item(.CurrentCell.RowNumber, 1).ToString) <> "" Then
                    TxtStartDate.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 1).ToString), "MM/dd/yyyy")
                Else
                    TxtStartDate.Text = ""
                End If
                If Trim(.Item(.CurrentCell.RowNumber, 2).ToString) <> "" Then
                    TxtEndDate.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 2).ToString), "MM/dd/yyyy")
                Else
                    TxtEndDate.Text = ""
                End If
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
                TxtLastUser.Text = .Item(.CurrentCell.RowNumber, 9).ToString
                .Select(.CurrentRowIndex)    'CurrentCell.RowNumber)
            End If
        End With
    End Sub

    Private Sub cboMedRep_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboMedRep.KeyUp
        'If e.KeyData.ToString = System.Windows.Forms.Keys.Up.ToString _
        '   Or e.KeyData.ToString = System.Windows.Forms.Keys.Left.ToString Then 'if key pressed is the up arrow it will select the next selection before the selction
        '    cboMedRep.SelectedItem = cboMedRep.SelectedIndex - 1
        'ElseIf e.KeyData.ToString = System.Windows.Forms.Keys.Down.ToString _
        '   Or e.KeyData.ToString = System.Windows.Forms.Keys.Right.ToString Then 'if key pressed is the up arrow it will select the next selection after the selction
        '    cboMedRep.SelectedItem = cboMedRep.SelectedIndex + 1
        'ElseIf DKcodes(e.KeyData) = True Then    'checking if the key pressed is alphanumeric (to disallow typing the entry)
        '    cboMedRep.Text = ""     'if alphanumeric then the value of the field will be erased
        'End If
        'If e.KeyValue = 13 Then
        '    SendKeys.Send("{TAB}")      'moves control to the next control or field
        'End If
    End Sub

    Private Sub cboMedRep_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboMedRep.Validating
        'If Trim(.Text) = "" Then    'tests if entry is blank
        '    MessageBox.Show("Mandatory field!", "Critical!")  'gives message to put value
        '    e.Cancel() = True                  ' brings back the focus on this control/field
        'End If
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

    Private Sub DataGrid1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGrid1.MouseUp
        'Dim pt As New Point(e.X, e.Y)
        'Dim hit As DataGrid.HitTestInfo = DataGrid1.HitTest(pt)

        'If hit.Type = DataGrid.HitTestType.Cell Then
        '    DataGrid1.CurrentCell = New DataGridCell(hit.Row, hit.Column)
        '    DataGrid1.Select(hit.Row)
        'End If
    End Sub

    Private Sub DataGrid2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGrid2.MouseUp
        'Dim pt As New Point(e.X, e.Y)
        'Dim hit As DataGrid.HitTestInfo = DataGrid2.HitTest(pt)

        'If hit.Type = DataGrid.HitTestType.Cell Then
        '    DataGrid2.CurrentCell = New DataGridCell(hit.Row, hit.Column)
        '    DataGrid2.Select(hit.Row)
        'End If
    End Sub

    Private Sub DataGrid3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGrid3.MouseDown
        Dim pt As New Point(e.X, e.Y)
        Dim hti As DataGrid.HitTestInfo = DataGrid3.HitTest(pt)

        If hti.Type = DataGrid.HitTestType.ColumnHeader Then
            GrdCount = RemoteDataSet2.MRterriT_Show.Count
            For i = 0 To GrdCount - 1
                With DataGrid3
                    For ij = 1 To selcnt
                        If .Item(i, 3).ToString = VarArr(ij) Then
                            .CurrentCell = New DataGridCell(i, 0)
                            .Select(i)
                        End If
                    Next
                End With
            Next i
            'DataGrid3.Select(4)
            'DataGrid3.Item(3)
        End If
    End Sub

    Private Sub DataGrid3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGrid3.MouseUp
        'Dim pt As New Point(e.X, e.Y)
        'Dim hit As DataGrid.HitTestInfo = DataGrid3.HitTest(pt)

        'If hit.Type = DataGrid.HitTestType.Cell Then
        '    DataGrid3.CurrentCell = New DataGridCell(hit.Row, hit.Column)
        '    DataGrid3.Select(hit.Row)
        'End If
    End Sub

    Private Sub btnPMR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPMR.Click
        Dim popupFrm As New frmCodDesc
        StordProcName = "PMRcomboAll"
        'SvrPath = ServerPath2
        SPparam = False
        popupFrm.ShowDialog(Me)
        txtPMRname.Text = gDesc
        txtPMRcode.Text = gCode
        TxtStartDate.Select()
    End Sub

    Private Sub txtPMRcode_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPMRcode.GotFocus
        txtPMRcode.SelectAll()
    End Sub

    Private Sub txtPMRcode_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPMRcode.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtPMRcode_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPMRcode.Validating
        Dim s As String
        If Trim(txtPMRcode.Text) = "" Or Trim(txtPMRcode.Text) Is DBNull.Value Then
            txtPMRname.Select()
            txtPMRname.SelectAll()
        Else
            z = "select mrname from newscores..medrep "
            z = z & "where mrcode = '" & Trim(txtPMRcode.Text) & "' "
            s = FindValue(z)
            If s = "" Then
                MsgBox("This PMR code does not exist!")
                Exit Sub
            Else
                txtPMRname.Text = s
                TxtStartDate.Select()
            End If
        End If
    End Sub

    Private Sub txtPMRname_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPMRname.GotFocus
        txtPMRname.SelectAll()
    End Sub

    Private Sub txtPMRname_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPMRname.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtPMRname_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPMRname.Validating
        Dim s As String
        Dim popupFrm As New frmCodDesc   '<--codes & description/names luk-up form
        If Trim(txtPMRname.Text) = "" Then
            txtPMRcode.Select()
            txtPMRcode.SelectAll()
            Exit Sub
        Else
            z = "select rtrim(mrcode) xcode, rtrim(mrname) xdesc from newscores..medrep "
            z = z & "where mrname like '" & Trim(StrTran(txtPMRname.Text, "*", "%")) & "' "
            s = FindValue(z)
            If s = "" Then
                MsgBox("This PMR name does not exist.") : GoTo err
            Else
                StordProcName = z
                'SvrPath = ServerPath2
                SPparam = True
                popupFrm.ShowDialog(Me)
                txtPMRname.Text = gDesc
                txtPMRcode.Text = gCode
                TxtStartDate.Select()
                Exit Sub
            End If
        End If
err:
        e.Cancel = True
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

    Private Sub TGsort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TGsort.Click
        SortTerritory()
    End Sub
End Class