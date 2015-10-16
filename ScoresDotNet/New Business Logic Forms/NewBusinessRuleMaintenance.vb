Public Class NewBusinessRuleMaintenance
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TerritoryDataGrid As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents NumericUpDownYear As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents EndDatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents StartDatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtItemDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtItemCode As System.Windows.Forms.TextBox
    Friend WithEvents txtRowid As System.Windows.Forms.TextBox
    Friend WithEvents ItemLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SpecialistLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents btnAddSpecialist As System.Windows.Forms.Button
    Friend WithEvents btnDeleteSpecialist As System.Windows.Forms.Button
    Friend WithEvents btnSaveSpecialist As System.Windows.Forms.Button
    Friend WithEvents btnCancelSpecialist As System.Windows.Forms.Button
    Friend WithEvents btnEditSpecialist As System.Windows.Forms.Button
    Friend WithEvents SpecialistEndDatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents SpecialistStartDatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtSpecialist As System.Windows.Forms.TextBox
    Friend WithEvents txtSpecialistCode As System.Windows.Forms.TextBox
    Friend WithEvents txtRowidSpecialist As System.Windows.Forms.TextBox
    Friend WithEvents AreaSpecialistDataGrid As System.Windows.Forms.DataGrid
    Friend WithEvents AreaBrickDataGrid As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTableStyle3 As System.Windows.Forms.DataGridTableStyle
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
    Friend WithEvents DataGridTextBoxColumn24 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn25 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn26 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn27 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn28 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn29 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn30 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn32 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn33 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn34 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn31 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TerritoryDataGrid = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.NumericUpDownYear = New System.Windows.Forms.NumericUpDown
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.AreaBrickDataGrid = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
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
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.EndDatePicker = New System.Windows.Forms.DateTimePicker
        Me.StartDatePicker = New System.Windows.Forms.DateTimePicker
        Me.ItemLinkLabel = New System.Windows.Forms.LinkLabel
        Me.txtItemDescription = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtItemCode = New System.Windows.Forms.TextBox
        Me.txtRowid = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.AreaSpecialistDataGrid = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle3 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn22 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn23 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn24 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn25 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn26 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn27 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn28 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn29 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn30 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn31 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btnDeleteSpecialist = New System.Windows.Forms.Button
        Me.btnSaveSpecialist = New System.Windows.Forms.Button
        Me.btnCancelSpecialist = New System.Windows.Forms.Button
        Me.btnEditSpecialist = New System.Windows.Forms.Button
        Me.btnAddSpecialist = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.SpecialistEndDatePicker = New System.Windows.Forms.DateTimePicker
        Me.SpecialistStartDatePicker = New System.Windows.Forms.DateTimePicker
        Me.SpecialistLinkLabel = New System.Windows.Forms.LinkLabel
        Me.txtSpecialist = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtSpecialistCode = New System.Windows.Forms.TextBox
        Me.txtRowidSpecialist = New System.Windows.Forms.TextBox
        Me.DataGridTextBoxColumn32 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn33 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn34 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.TerritoryDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownYear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.AreaBrickDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.AreaSpecialistDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TerritoryDataGrid)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1344, 200)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Territory"
        '
        'TerritoryDataGrid
        '
        Me.TerritoryDataGrid.DataMember = ""
        Me.TerritoryDataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.TerritoryDataGrid.Location = New System.Drawing.Point(8, 16)
        Me.TerritoryDataGrid.Name = "TerritoryDataGrid"
        Me.TerritoryDataGrid.Size = New System.Drawing.Size(1328, 176)
        Me.TerritoryDataGrid.TabIndex = 0
        Me.TerritoryDataGrid.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.TerritoryDataGrid
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.ReadOnly = True
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Rowid"
        Me.DataGridTextBoxColumn1.MappingName = "Rowid"
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Dim Code"
        Me.DataGridTextBoxColumn2.MappingName = "DimCode"
        Me.DataGridTextBoxColumn2.Width = 120
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Territory Code"
        Me.DataGridTextBoxColumn3.MappingName = "TerritoryCode"
        Me.DataGridTextBoxColumn3.Width = 120
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Territory"
        Me.DataGridTextBoxColumn4.MappingName = "Territory"
        Me.DataGridTextBoxColumn4.Width = 200
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Region Code"
        Me.DataGridTextBoxColumn5.MappingName = "RegionCode"
        Me.DataGridTextBoxColumn5.Width = 120
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "Region"
        Me.DataGridTextBoxColumn10.MappingName = "Region"
        Me.DataGridTextBoxColumn10.Width = 270
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "GroupDr"
        Me.DataGridTextBoxColumn6.MappingName = "GroupDr"
        Me.DataGridTextBoxColumn6.Width = 0
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Group"
        Me.DataGridTextBoxColumn7.MappingName = "Group"
        Me.DataGridTextBoxColumn7.Width = 120
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.MappingName = "IslandGroup"
        Me.DataGridTextBoxColumn11.Width = 120
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "ProvinceDr"
        Me.DataGridTextBoxColumn8.MappingName = "ProvinceDr"
        Me.DataGridTextBoxColumn8.Width = 0
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "Province"
        Me.DataGridTextBoxColumn9.MappingName = "Province"
        Me.DataGridTextBoxColumn9.Width = 200
        '
        'NumericUpDownYear
        '
        Me.NumericUpDownYear.Location = New System.Drawing.Point(1232, 8)
        Me.NumericUpDownYear.Maximum = New Decimal(New Integer() {2299, 0, 0, 0})
        Me.NumericUpDownYear.Minimum = New Decimal(New Integer() {2013, 0, 0, 0})
        Me.NumericUpDownYear.Name = "NumericUpDownYear"
        Me.NumericUpDownYear.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDownYear.TabIndex = 1
        Me.NumericUpDownYear.Value = New Decimal(New Integer() {2014, 0, 0, 0})
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.AreaBrickDataGrid)
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.btnCancel)
        Me.GroupBox2.Controls.Add(Me.btnEdit)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.EndDatePicker)
        Me.GroupBox2.Controls.Add(Me.StartDatePicker)
        Me.GroupBox2.Controls.Add(Me.ItemLinkLabel)
        Me.GroupBox2.Controls.Add(Me.txtItemDescription)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.txtItemCode)
        Me.GroupBox2.Controls.Add(Me.txtRowid)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 240)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1344, 232)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "MR Area"
        '
        'AreaBrickDataGrid
        '
        Me.AreaBrickDataGrid.DataMember = ""
        Me.AreaBrickDataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.AreaBrickDataGrid.Location = New System.Drawing.Point(8, 16)
        Me.AreaBrickDataGrid.Name = "AreaBrickDataGrid"
        Me.AreaBrickDataGrid.RowHeaderWidth = 20
        Me.AreaBrickDataGrid.Size = New System.Drawing.Size(904, 208)
        Me.AreaBrickDataGrid.TabIndex = 49
        Me.AreaBrickDataGrid.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.AreaBrickDataGrid
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn32, Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn16, Me.DataGridTextBoxColumn17, Me.DataGridTextBoxColumn18, Me.DataGridTextBoxColumn33, Me.DataGridTextBoxColumn34, Me.DataGridTextBoxColumn19, Me.DataGridTextBoxColumn20, Me.DataGridTextBoxColumn21})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "RowNumber"
        Me.DataGridTextBoxColumn12.MappingName = "RowNumber"
        Me.DataGridTextBoxColumn12.Width = 0
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "Brand Code"
        Me.DataGridTextBoxColumn13.MappingName = "BrandCode"
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "Area Code"
        Me.DataGridTextBoxColumn14.MappingName = "AreaCode"
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "TerritoryDr"
        Me.DataGridTextBoxColumn15.MappingName = "TerritoryDr"
        Me.DataGridTextBoxColumn15.Width = 0
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Format = ""
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.HeaderText = "Territory"
        Me.DataGridTextBoxColumn16.MappingName = "Territory"
        Me.DataGridTextBoxColumn16.Width = 0
        '
        'DataGridTextBoxColumn17
        '
        Me.DataGridTextBoxColumn17.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn17.Format = ""
        Me.DataGridTextBoxColumn17.FormatInfo = Nothing
        Me.DataGridTextBoxColumn17.HeaderText = "Start Date"
        Me.DataGridTextBoxColumn17.MappingName = "Start_Date"
        Me.DataGridTextBoxColumn17.Width = 101
        '
        'DataGridTextBoxColumn18
        '
        Me.DataGridTextBoxColumn18.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn18.Format = ""
        Me.DataGridTextBoxColumn18.FormatInfo = Nothing
        Me.DataGridTextBoxColumn18.HeaderText = "End Date"
        Me.DataGridTextBoxColumn18.MappingName = "End_Date"
        Me.DataGridTextBoxColumn18.Width = 101
        '
        'DataGridTextBoxColumn19
        '
        Me.DataGridTextBoxColumn19.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn19.Format = ""
        Me.DataGridTextBoxColumn19.FormatInfo = Nothing
        Me.DataGridTextBoxColumn19.HeaderText = "Create Date"
        Me.DataGridTextBoxColumn19.MappingName = "CreateDate"
        Me.DataGridTextBoxColumn19.Width = 0
        '
        'DataGridTextBoxColumn20
        '
        Me.DataGridTextBoxColumn20.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn20.Format = ""
        Me.DataGridTextBoxColumn20.FormatInfo = Nothing
        Me.DataGridTextBoxColumn20.HeaderText = "Update Date"
        Me.DataGridTextBoxColumn20.MappingName = "UpdateDate"
        Me.DataGridTextBoxColumn20.Width = 0
        '
        'DataGridTextBoxColumn21
        '
        Me.DataGridTextBoxColumn21.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn21.Format = ""
        Me.DataGridTextBoxColumn21.FormatInfo = Nothing
        Me.DataGridTextBoxColumn21.HeaderText = "Modified By"
        Me.DataGridTextBoxColumn21.MappingName = "LastUser"
        Me.DataGridTextBoxColumn21.Width = 0
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(1240, 144)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(96, 24)
        Me.btnDelete.TabIndex = 47
        Me.btnDelete.Text = "Delete"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(1240, 120)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(96, 24)
        Me.btnSave.TabIndex = 46
        Me.btnSave.Text = "Save"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(1144, 120)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 24)
        Me.btnCancel.TabIndex = 45
        Me.btnCancel.Text = "Cancel"
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(1048, 120)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(96, 24)
        Me.btnEdit.TabIndex = 44
        Me.btnEdit.Text = "Edit"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(952, 120)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(96, 24)
        Me.btnAdd.TabIndex = 43
        Me.btnAdd.Text = "Add"
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(928, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(8, 216)
        Me.GroupBox4.TabIndex = 42
        Me.GroupBox4.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SkyBlue
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(952, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 20)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "End Date"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SkyBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(952, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 20)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Start Date"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EndDatePicker
        '
        Me.EndDatePicker.Location = New System.Drawing.Point(1080, 88)
        Me.EndDatePicker.Name = "EndDatePicker"
        Me.EndDatePicker.Size = New System.Drawing.Size(256, 20)
        Me.EndDatePicker.TabIndex = 39
        '
        'StartDatePicker
        '
        Me.StartDatePicker.Location = New System.Drawing.Point(1080, 64)
        Me.StartDatePicker.Name = "StartDatePicker"
        Me.StartDatePicker.Size = New System.Drawing.Size(256, 20)
        Me.StartDatePicker.TabIndex = 38
        '
        'ItemLinkLabel
        '
        Me.ItemLinkLabel.BackColor = System.Drawing.Color.SkyBlue
        Me.ItemLinkLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ItemLinkLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.ItemLinkLabel.Location = New System.Drawing.Point(952, 16)
        Me.ItemLinkLabel.Name = "ItemLinkLabel"
        Me.ItemLinkLabel.Size = New System.Drawing.Size(120, 20)
        Me.ItemLinkLabel.TabIndex = 37
        Me.ItemLinkLabel.TabStop = True
        Me.ItemLinkLabel.Text = "Brand Code"
        Me.ItemLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtItemDescription
        '
        Me.txtItemDescription.BackColor = System.Drawing.Color.SkyBlue
        Me.txtItemDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemDescription.Location = New System.Drawing.Point(1080, 40)
        Me.txtItemDescription.Name = "txtItemDescription"
        Me.txtItemDescription.Size = New System.Drawing.Size(256, 20)
        Me.txtItemDescription.TabIndex = 36
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.SkyBlue
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label19.Location = New System.Drawing.Point(952, 40)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(120, 20)
        Me.Label19.TabIndex = 35
        Me.Label19.Text = "Area Code"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtItemCode
        '
        Me.txtItemCode.BackColor = System.Drawing.Color.SkyBlue
        Me.txtItemCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemCode.Location = New System.Drawing.Point(1080, 16)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(256, 20)
        Me.txtItemCode.TabIndex = 34
        '
        'txtRowid
        '
        Me.txtRowid.BackColor = System.Drawing.Color.SkyBlue
        Me.txtRowid.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRowid.Location = New System.Drawing.Point(1080, 16)
        Me.txtRowid.Name = "txtRowid"
        Me.txtRowid.ReadOnly = True
        Me.txtRowid.Size = New System.Drawing.Size(256, 20)
        Me.txtRowid.TabIndex = 48
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.AreaSpecialistDataGrid)
        Me.GroupBox3.Controls.Add(Me.btnDeleteSpecialist)
        Me.GroupBox3.Controls.Add(Me.btnSaveSpecialist)
        Me.GroupBox3.Controls.Add(Me.btnCancelSpecialist)
        Me.GroupBox3.Controls.Add(Me.btnEditSpecialist)
        Me.GroupBox3.Controls.Add(Me.btnAddSpecialist)
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.SpecialistEndDatePicker)
        Me.GroupBox3.Controls.Add(Me.SpecialistStartDatePicker)
        Me.GroupBox3.Controls.Add(Me.SpecialistLinkLabel)
        Me.GroupBox3.Controls.Add(Me.txtSpecialist)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtSpecialistCode)
        Me.GroupBox3.Controls.Add(Me.txtRowidSpecialist)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 480)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1344, 232)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Area PMR"
        '
        'AreaSpecialistDataGrid
        '
        Me.AreaSpecialistDataGrid.DataMember = ""
        Me.AreaSpecialistDataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.AreaSpecialistDataGrid.Location = New System.Drawing.Point(8, 16)
        Me.AreaSpecialistDataGrid.Name = "AreaSpecialistDataGrid"
        Me.AreaSpecialistDataGrid.RowHeaderWidth = 20
        Me.AreaSpecialistDataGrid.Size = New System.Drawing.Size(904, 208)
        Me.AreaSpecialistDataGrid.TabIndex = 49
        Me.AreaSpecialistDataGrid.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle3})
        '
        'DataGridTableStyle3
        '
        Me.DataGridTableStyle3.DataGrid = Me.AreaSpecialistDataGrid
        Me.DataGridTableStyle3.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn22, Me.DataGridTextBoxColumn23, Me.DataGridTextBoxColumn24, Me.DataGridTextBoxColumn25, Me.DataGridTextBoxColumn26, Me.DataGridTextBoxColumn27, Me.DataGridTextBoxColumn28, Me.DataGridTextBoxColumn29, Me.DataGridTextBoxColumn30, Me.DataGridTextBoxColumn31})
        Me.DataGridTableStyle3.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle3.RowHeaderWidth = 20
        '
        'DataGridTextBoxColumn22
        '
        Me.DataGridTextBoxColumn22.Format = ""
        Me.DataGridTextBoxColumn22.FormatInfo = Nothing
        Me.DataGridTextBoxColumn22.HeaderText = "RowId"
        Me.DataGridTextBoxColumn22.MappingName = "RowId"
        Me.DataGridTextBoxColumn22.Width = 0
        '
        'DataGridTextBoxColumn23
        '
        Me.DataGridTextBoxColumn23.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn23.Format = ""
        Me.DataGridTextBoxColumn23.FormatInfo = Nothing
        Me.DataGridTextBoxColumn23.HeaderText = "Specialist Code"
        Me.DataGridTextBoxColumn23.MappingName = "SpecialistCode"
        Me.DataGridTextBoxColumn23.Width = 88
        '
        'DataGridTextBoxColumn24
        '
        Me.DataGridTextBoxColumn24.Format = ""
        Me.DataGridTextBoxColumn24.FormatInfo = Nothing
        Me.DataGridTextBoxColumn24.HeaderText = "Specialist"
        Me.DataGridTextBoxColumn24.MappingName = "Specialist"
        Me.DataGridTextBoxColumn24.Width = 248
        '
        'DataGridTextBoxColumn25
        '
        Me.DataGridTextBoxColumn25.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn25.Format = ""
        Me.DataGridTextBoxColumn25.FormatInfo = Nothing
        Me.DataGridTextBoxColumn25.HeaderText = "Start_Date"
        Me.DataGridTextBoxColumn25.MappingName = "Start_Date"
        Me.DataGridTextBoxColumn25.Width = 117
        '
        'DataGridTextBoxColumn26
        '
        Me.DataGridTextBoxColumn26.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn26.Format = ""
        Me.DataGridTextBoxColumn26.FormatInfo = Nothing
        Me.DataGridTextBoxColumn26.HeaderText = "End_Date"
        Me.DataGridTextBoxColumn26.MappingName = "End_Date"
        Me.DataGridTextBoxColumn26.Width = 117
        '
        'DataGridTextBoxColumn27
        '
        Me.DataGridTextBoxColumn27.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn27.Format = ""
        Me.DataGridTextBoxColumn27.FormatInfo = Nothing
        Me.DataGridTextBoxColumn27.HeaderText = "CreateDate"
        Me.DataGridTextBoxColumn27.MappingName = "CreateDate"
        Me.DataGridTextBoxColumn27.Width = 117
        '
        'DataGridTextBoxColumn28
        '
        Me.DataGridTextBoxColumn28.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn28.Format = ""
        Me.DataGridTextBoxColumn28.FormatInfo = Nothing
        Me.DataGridTextBoxColumn28.HeaderText = "UpdateDate"
        Me.DataGridTextBoxColumn28.MappingName = "UpdateDate"
        Me.DataGridTextBoxColumn28.Width = 117
        '
        'DataGridTextBoxColumn29
        '
        Me.DataGridTextBoxColumn29.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn29.Format = ""
        Me.DataGridTextBoxColumn29.FormatInfo = Nothing
        Me.DataGridTextBoxColumn29.HeaderText = "Modified By"
        Me.DataGridTextBoxColumn29.MappingName = "LastUser"
        Me.DataGridTextBoxColumn29.Width = 75
        '
        'DataGridTextBoxColumn30
        '
        Me.DataGridTextBoxColumn30.Format = ""
        Me.DataGridTextBoxColumn30.FormatInfo = Nothing
        Me.DataGridTextBoxColumn30.HeaderText = "TerritoryDr"
        Me.DataGridTextBoxColumn30.MappingName = "TerritoryDr"
        Me.DataGridTextBoxColumn30.Width = 0
        '
        'DataGridTextBoxColumn31
        '
        Me.DataGridTextBoxColumn31.Format = ""
        Me.DataGridTextBoxColumn31.FormatInfo = Nothing
        Me.DataGridTextBoxColumn31.HeaderText = "AreaBrickDr"
        Me.DataGridTextBoxColumn31.MappingName = "AreaBrickDr"
        Me.DataGridTextBoxColumn31.Width = 0
        '
        'btnDeleteSpecialist
        '
        Me.btnDeleteSpecialist.Location = New System.Drawing.Point(1240, 144)
        Me.btnDeleteSpecialist.Name = "btnDeleteSpecialist"
        Me.btnDeleteSpecialist.Size = New System.Drawing.Size(96, 24)
        Me.btnDeleteSpecialist.TabIndex = 47
        Me.btnDeleteSpecialist.Text = "Delete"
        '
        'btnSaveSpecialist
        '
        Me.btnSaveSpecialist.Location = New System.Drawing.Point(1240, 120)
        Me.btnSaveSpecialist.Name = "btnSaveSpecialist"
        Me.btnSaveSpecialist.Size = New System.Drawing.Size(96, 24)
        Me.btnSaveSpecialist.TabIndex = 46
        Me.btnSaveSpecialist.Text = "Save"
        '
        'btnCancelSpecialist
        '
        Me.btnCancelSpecialist.Location = New System.Drawing.Point(1144, 120)
        Me.btnCancelSpecialist.Name = "btnCancelSpecialist"
        Me.btnCancelSpecialist.Size = New System.Drawing.Size(96, 24)
        Me.btnCancelSpecialist.TabIndex = 45
        Me.btnCancelSpecialist.Text = "Cancel"
        '
        'btnEditSpecialist
        '
        Me.btnEditSpecialist.Location = New System.Drawing.Point(1048, 120)
        Me.btnEditSpecialist.Name = "btnEditSpecialist"
        Me.btnEditSpecialist.Size = New System.Drawing.Size(96, 24)
        Me.btnEditSpecialist.TabIndex = 44
        Me.btnEditSpecialist.Text = "Edit"
        '
        'btnAddSpecialist
        '
        Me.btnAddSpecialist.Location = New System.Drawing.Point(952, 120)
        Me.btnAddSpecialist.Name = "btnAddSpecialist"
        Me.btnAddSpecialist.Size = New System.Drawing.Size(96, 24)
        Me.btnAddSpecialist.TabIndex = 43
        Me.btnAddSpecialist.Text = "Add"
        '
        'GroupBox5
        '
        Me.GroupBox5.Location = New System.Drawing.Point(928, 8)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(8, 216)
        Me.GroupBox5.TabIndex = 42
        Me.GroupBox5.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SkyBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(952, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 20)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "End Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SkyBlue
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(952, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 20)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Start Date"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SpecialistEndDatePicker
        '
        Me.SpecialistEndDatePicker.Location = New System.Drawing.Point(1080, 88)
        Me.SpecialistEndDatePicker.Name = "SpecialistEndDatePicker"
        Me.SpecialistEndDatePicker.Size = New System.Drawing.Size(256, 20)
        Me.SpecialistEndDatePicker.TabIndex = 39
        '
        'SpecialistStartDatePicker
        '
        Me.SpecialistStartDatePicker.Location = New System.Drawing.Point(1080, 64)
        Me.SpecialistStartDatePicker.Name = "SpecialistStartDatePicker"
        Me.SpecialistStartDatePicker.Size = New System.Drawing.Size(256, 20)
        Me.SpecialistStartDatePicker.TabIndex = 38
        '
        'SpecialistLinkLabel
        '
        Me.SpecialistLinkLabel.BackColor = System.Drawing.Color.SkyBlue
        Me.SpecialistLinkLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SpecialistLinkLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.SpecialistLinkLabel.Location = New System.Drawing.Point(952, 16)
        Me.SpecialistLinkLabel.Name = "SpecialistLinkLabel"
        Me.SpecialistLinkLabel.Size = New System.Drawing.Size(120, 20)
        Me.SpecialistLinkLabel.TabIndex = 37
        Me.SpecialistLinkLabel.TabStop = True
        Me.SpecialistLinkLabel.Text = "Specialist Code"
        Me.SpecialistLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSpecialist
        '
        Me.txtSpecialist.BackColor = System.Drawing.Color.SkyBlue
        Me.txtSpecialist.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSpecialist.Location = New System.Drawing.Point(1080, 40)
        Me.txtSpecialist.Name = "txtSpecialist"
        Me.txtSpecialist.Size = New System.Drawing.Size(256, 20)
        Me.txtSpecialist.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.SkyBlue
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Location = New System.Drawing.Point(952, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 20)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Specialist"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSpecialistCode
        '
        Me.txtSpecialistCode.BackColor = System.Drawing.Color.SkyBlue
        Me.txtSpecialistCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSpecialistCode.Location = New System.Drawing.Point(1080, 16)
        Me.txtSpecialistCode.Name = "txtSpecialistCode"
        Me.txtSpecialistCode.Size = New System.Drawing.Size(256, 20)
        Me.txtSpecialistCode.TabIndex = 34
        '
        'txtRowidSpecialist
        '
        Me.txtRowidSpecialist.BackColor = System.Drawing.Color.SkyBlue
        Me.txtRowidSpecialist.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRowidSpecialist.Location = New System.Drawing.Point(1080, 16)
        Me.txtRowidSpecialist.Name = "txtRowidSpecialist"
        Me.txtRowidSpecialist.ReadOnly = True
        Me.txtRowidSpecialist.Size = New System.Drawing.Size(256, 20)
        Me.txtRowidSpecialist.TabIndex = 48
        '
        'DataGridTextBoxColumn32
        '
        Me.DataGridTextBoxColumn32.Format = ""
        Me.DataGridTextBoxColumn32.FormatInfo = Nothing
        Me.DataGridTextBoxColumn32.HeaderText = "Area Name"
        Me.DataGridTextBoxColumn32.MappingName = "AreaName"
        Me.DataGridTextBoxColumn32.Width = 272
        '
        'DataGridTextBoxColumn33
        '
        Me.DataGridTextBoxColumn33.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn33.Format = ""
        Me.DataGridTextBoxColumn33.FormatInfo = Nothing
        Me.DataGridTextBoxColumn33.HeaderText = "Principal Code"
        Me.DataGridTextBoxColumn33.MappingName = "PrinCode"
        Me.DataGridTextBoxColumn33.Width = 75
        '
        'DataGridTextBoxColumn34
        '
        Me.DataGridTextBoxColumn34.Format = ""
        Me.DataGridTextBoxColumn34.FormatInfo = Nothing
        Me.DataGridTextBoxColumn34.HeaderText = "Principal Name"
        Me.DataGridTextBoxColumn34.MappingName = "PrinName"
        Me.DataGridTextBoxColumn34.Width = 200
        '
        'NewBusinessRuleMaintenance
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1366, 717)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.NumericUpDownYear)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "NewBusinessRuleMaintenance"
        Me.Text = "NewBusinessRuleMaintenance"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.TerritoryDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownYear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.AreaBrickDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.AreaSpecialistDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mAreaBrickMode As String
    Private mAreaSpecialistMode As String

    Public Property AreaBrickMode() As String
        Get
            Return mAreaBrickMode
        End Get
        Set(ByVal Value As String)
            mAreaBrickMode = Value
        End Set
    End Property

    Public Property AreaSpecialistMode() As String
        Get
            Return mAreaSpecialistMode
        End Get
        Set(ByVal Value As String)
            mAreaSpecialistMode = Value
        End Set
    End Property

    Private Sub NewBusinessRuleMaintenance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Load_TerritoryDataGrid()
        EnableAreaBrickButtons(False)
        EnableAreaSpecialistButtons(False)
        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnSaveSpecialist.Enabled = False
        btnCancelSpecialist.Enabled = False

    End Sub

    Private Sub Load_TerritoryDataGrid()

        TerritoryDataGrid.DataSource = DataMaintenance.GetDataTable(ServerPath2, "SegmentRule_GetTerritories", _
        CommandType.StoredProcedure)
        TerritoryDataGrid.CaptionText = CType(TerritoryDataGrid.DataSource, DataTable).Rows.Count.ToString() & " Record(s)"

    End Sub

    Private Sub TerritoryDataGrid_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles TerritoryDataGrid.CurrentCellChanged

        TerritoryDataGrid.Select(TerritoryDataGrid.CurrentCell.RowNumber)
        EnableAreaBrickButtons(True)
        ClearFields()
        ClearSpecialistFields()
        AreaSpecialistDataGrid.DataSource = Nothing
        Load_AreaBrickDataGrid()

    End Sub

    Private Sub Load_AreaBrickDataGrid()

        SetupParameters(0, "@Year", SqlDbType.Int, 4, "Integer", NumericUpDownYear.Value.ToString())
        SetupParameters(1, "@TerritoryDr", SqlDbType.Decimal, 18, "Integer", _
        CStr(TerritoryDataGrid.Item(TerritoryDataGrid.CurrentCell.RowNumber, 0)))
        AreaBrickDataGrid.DataSource = DataMaintenance.GetDataTable(ServerPath2, "SegmentRule_GetAreaBrick", _
        CommandType.StoredProcedure, 2)
        AreaBrickDataGrid.CaptionText = CType(AreaBrickDataGrid.DataSource, DataTable).Rows.Count.ToString() & " Record(s)"

    End Sub

    Private Sub EnableAreaSpecialistButtons(ByVal enabled As Boolean)

        btnAddSpecialist.Enabled = enabled
        btnEditSpecialist.Enabled = enabled
        btnCancelSpecialist.Enabled = Not enabled
        btnSaveSpecialist.Enabled = Not enabled
        btnDeleteSpecialist.Enabled = enabled

    End Sub

    Private Sub Load_AreaSpecialistDataGrid()

        SetupParameters(0, "@AreaCode", SqlDbType.VarChar, 10, "String", _
        CStr(AreaBrickDataGrid.Item(AreaBrickDataGrid.CurrentRowIndex, 2)))
        SetupParameters(1, "@Year", SqlDbType.Int, 4, "Integer", NumericUpDownYear.Value)
        AreaSpecialistDataGrid.DataSource = DataMaintenance.GetDataTable(ServerPath2, "SegmentRule_GetAreaSpecialist", _
        CommandType.StoredProcedure, 2)
        AreaSpecialistDataGrid.CaptionText = CType(AreaSpecialistDataGrid.DataSource, DataTable).Rows.Count.ToString() & " Record(s)"

    End Sub

    Private Sub Populate_Fields()

        ClearFields()
        Try
            With AreaBrickDataGrid
                txtRowid.Text = CStr(.Item(.CurrentCell.RowNumber, 0))
                txtItemCode.Text = CStr(.Item(.CurrentCell.RowNumber, 1))
                txtItemDescription.Text = CStr(.Item(.CurrentCell.RowNumber, 2))
                StartDatePicker.Text = CStr(.Item(.CurrentCell.RowNumber, 6))
                EndDatePicker.Text = CStr(.Item(.CurrentCell.RowNumber, 7))
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try

    End Sub

    Private Sub ClearFields()

        txtRowid.Text = ""
        txtItemCode.Text = ""
        txtItemDescription.Text = ""
        StartDatePicker.Value = Now()
        EndDatePicker.Value = Now()

    End Sub

    Private Sub ClearSpecialistFields()

        txtRowidSpecialist.Text = ""
        txtSpecialistCode.Text = ""
        txtSpecialist.Text = ""
        SpecialistStartDatePicker.Value = Now()
        SpecialistEndDatePicker.Value = Now()

    End Sub

    Private Sub EnableAreaBrickButtons(ByVal enabled As Boolean)

        btnAdd.Enabled = enabled
        btnEdit.Enabled = enabled
        btnCancel.Enabled = Not enabled
        btnSave.Enabled = Not enabled
        btnDelete.Enabled = enabled

    End Sub

    Private Sub SetupParameters(ByVal x As Integer, ByVal ParameterName As String, _
    ByVal ParameterType As SqlDbType, ByVal ParameterLength As Integer, ByVal DataType As String, ByVal ParameterValue As String)

        DataMaintenance.myParamArray(x, 0) = ParameterName
        DataMaintenance.myParamArray(x, 1) = ParameterType
        DataMaintenance.myParamArray(x, 2) = ParameterLength
        DataMaintenance.myParamArray(x, 3) = ParameterDirection.Input
        DataMaintenance.myParamArray(x, 4) = DataType
        DataMaintenance.myParamArray(x, 5) = ParameterValue

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        EnableAreaBrickButtons(False)
        ClearFields()
        AreaBrickMode = "0"

    End Sub

    Private Sub btnAddSpecialist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSpecialist.Click

        EnableAreaSpecialistButtons(False)
        ClearSpecialistFields()
        AreaSpecialistMode = "0"

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        EnableAreaBrickButtons(False)
        AreaBrickMode = "1"

    End Sub

    Private Sub btnEditSpecialist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditSpecialist.Click

        EnableAreaSpecialistButtons(False)
        AreaSpecialistMode = "1"

    End Sub

    Private Sub SaveAreaBrickData()

        If AreaBrickMode = "0" Then
            Try
                SetupParameters(0, "@Mode", SqlDbType.Int, 4, "Integer", "0")
                SetupParameters(1, "@Rowid", SqlDbType.Decimal, 18, "Integer", "0")
                SetupParameters(2, "@AreaCode", SqlDbType.Char, 10, "String", txtItemCode.Text)
                SetupParameters(3, "@BrandCode", SqlDbType.Char, 3, "String", txtItemDescription.Text)
                SetupParameters(4, "@TerritoryDr", SqlDbType.Decimal, 18, "Integer", _
                CStr(TerritoryDataGrid.Item(TerritoryDataGrid.CurrentCell.RowNumber, 0)))
                SetupParameters(5, "@StartDate", SqlDbType.DateTime, 10, "Date", StartDatePicker.Value.ToString())
                SetupParameters(6, "@EndDate", SqlDbType.DateTime, 10, "Date", EndDatePicker.Value.ToString())
                SetupParameters(7, "@LastUser", SqlDbType.VarChar, 10, "String", Environment.UserName)

                If DataMaintenance.ExecuteCommand(ServerPath2, "SegmentRule_AreaBrickUpdate", CommandType.StoredProcedure, 8) = _
                True Then
                    MessageBox.Show("Record saved successfully!", "MR Area Maintenance", MessageBoxButtons.OK, _
                    MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString(), "MR Area Maintenance", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Try
                SetupParameters(0, "@Mode", SqlDbType.Int, 4, "Integer", "1")
                SetupParameters(1, "@Rowid", SqlDbType.Decimal, 18, "Integer", txtRowid.Text)
                SetupParameters(2, "@AreaCode", SqlDbType.Char, 10, "String", txtItemCode.Text)
                SetupParameters(3, "@BrandCode", SqlDbType.Char, 3, "String", txtItemDescription.Text)
                SetupParameters(4, "@TerritoryDr", SqlDbType.Decimal, 18, "Integer", _
                CStr(TerritoryDataGrid.Item(TerritoryDataGrid.CurrentCell.RowNumber, 0)))
                SetupParameters(5, "@StartDate", SqlDbType.DateTime, 10, "Date", StartDatePicker.Value.ToString())
                SetupParameters(6, "@EndDate", SqlDbType.DateTime, 10, "Date", EndDatePicker.Value.ToString())
                SetupParameters(7, "@LastUser", SqlDbType.VarChar, 10, "String", Environment.UserName)

                If DataMaintenance.ExecuteCommand(ServerPath2, "SegmentRule_AreaBrickUpdate", CommandType.StoredProcedure, 8) = _
                True Then
                    MessageBox.Show("Record saved successfully!", "MR Area Maintenance", MessageBoxButtons.OK, _
                    MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString(), "MR Area Maintenance", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub SaveAreaSpecialistData()

        If AreaSpecialistMode = "0" Then
            Try
                SetupParameters(0, "@Mode", SqlDbType.Int, 4, "Integer", "0")
                SetupParameters(1, "@Rowid", SqlDbType.Decimal, 18, "Integer", "0")
                SetupParameters(2, "@MrCode", SqlDbType.VarChar, 10, "String", txtSpecialistCode.Text)
                SetupParameters(3, "@StartDate", SqlDbType.DateTime, 10, "Date", SpecialistStartDatePicker.Value.ToString())
                SetupParameters(4, "@EndDate", SqlDbType.DateTime, 10, "Date", SpecialistEndDatePicker.Value.ToString())
                SetupParameters(5, "@LastUser", SqlDbType.VarChar, 10, "String", Environment.UserName)
                SetupParameters(6, "@AreaBrickDr", SqlDbType.Decimal, 18, "Integer", _
                CStr(AreaBrickDataGrid.Item(AreaBrickDataGrid.CurrentCell.RowNumber, 0)))

                If DataMaintenance.ExecuteCommand(ServerPath2, "SegmentRule_AreaSpecialistUpdate", CommandType.StoredProcedure, 7) = _
                True Then
                    MessageBox.Show("Record saved successfully!", "Area/Specialist Maintenance", MessageBoxButtons.OK, _
                    MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString(), "Area/Specialist Maintenance", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Try
                SetupParameters(0, "@Mode", SqlDbType.Int, 4, "Integer", "1")
                SetupParameters(1, "@Rowid", SqlDbType.Decimal, 18, "Integer", txtRowidSpecialist.Text)
                SetupParameters(2, "@MrCode", SqlDbType.VarChar, 10, "String", txtSpecialistCode.Text)
                SetupParameters(3, "@StartDate", SqlDbType.DateTime, 10, "Date", SpecialistStartDatePicker.Value.ToString())
                SetupParameters(4, "@EndDate", SqlDbType.DateTime, 10, "Date", SpecialistEndDatePicker.Value.ToString())
                SetupParameters(5, "@LastUser", SqlDbType.VarChar, 10, "String", Environment.UserName)
                SetupParameters(6, "@AreaBrickDr", SqlDbType.Decimal, 18, "Integer", _
                CStr(AreaBrickDataGrid.Item(AreaBrickDataGrid.CurrentCell.RowNumber, 0)))

                If DataMaintenance.ExecuteCommand(ServerPath2, "SegmentRule_AreaSpecialistUpdate", CommandType.StoredProcedure, 7) = _
                True Then
                    MessageBox.Show("Record saved successfully!", "Area/Specialist Maintenance", MessageBoxButtons.OK, _
                    MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString(), "Area/Specialist Maintenance", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        EnableAreaBrickButtons(True)

    End Sub

    Private Sub btnCancelSpecialist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
    btnCancelSpecialist.Click

        EnableAreaSpecialistButtons(True)

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        EnableAreaBrickButtons(True)
        SaveAreaBrickData()
        Load_AreaBrickDataGrid()
        ClearFields()
        ClearSpecialistFields()

    End Sub

    Private Sub btnSaveSpecialist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveSpecialist.Click

        EnableAreaSpecialistButtons(True)
        SaveAreaSpecialistData()
        Load_AreaSpecialistDataGrid()
        ClearSpecialistFields()

    End Sub

    Private Sub ItemLinkLabel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItemLinkLabel.Click

        Dim thisForm As New ItemCT
        thisForm.ShowDialog(Me)

        With thisForm
            txtItemCode.Text = CStr(.DG_items.Item(.DG_items.CurrentRowIndex, 1))
            txtItemDescription.Text = CStr(.DG_items.Item(.DG_items.CurrentRowIndex, 4))
        End With

    End Sub

    Private Sub SpecialistLinkLabel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SpecialistLinkLabel.Click

        Dim thisForm As New SupMr
        thisForm.ShowDialog(Me)

        With thisForm
            txtSpecialistCode.Text = CStr(.DataGrid2.Item(.DataGrid2.CurrentRowIndex, 1))
            txtSpecialist.Text = CStr(.DataGrid2.Item(.DataGrid2.CurrentRowIndex, 2))
        End With

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        If txtRowid.Text <> String.Empty Then
            If MessageBox.Show("Are you sure you want to delete this record?", "Area/Brick Data for Deletion", _
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    SetupParameters(0, "@Rowid", SqlDbType.Decimal, 18, "Integer", txtRowid.Text)
                    If DataMaintenance.ExecuteCommand(ServerPath2, "SegmentRule_DeleteAreaBrick", CommandType.StoredProcedure, 1) = _
                    True Then
                        MessageBox.Show("Record deleted!", "Area/Brick Maintenance", MessageBoxButtons.OK, _
                        MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString(), "Area/Brick Maintenance", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
            Load_AreaBrickDataGrid()
            ClearFields()
            ClearSpecialistFields()
        Else
            MessageBox.Show("Please select a row to delete", "Area/Brick Maintenance", MessageBoxButtons.OK, _
            MessageBoxIcon.Information)
        End If
        

    End Sub

    Private Sub btnDeleteSpecialist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        btnDeleteSpecialist.Click

        If txtRowidSpecialist.Text <> String.Empty Then
            If MessageBox.Show("Are you sure you want to delete this record?", "Area/Specialist Data for Deletion", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    SetupParameters(0, "@Rowid", SqlDbType.Decimal, 18, "Integer", txtRowidSpecialist.Text)
                    If DataMaintenance.ExecuteCommand(ServerPath2, "SegmentRule_DeleteAreaSpecialist", _
                    CommandType.StoredProcedure, 1) = True Then
                        MessageBox.Show("Record deleted!", "Area/Specialist Maintenance", MessageBoxButtons.OK, _
                        MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString(), "Area/Specialist Maintenance", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
            Load_AreaSpecialistDataGrid()
            ClearSpecialistFields()
        Else
            MessageBox.Show("Please select a row to delete", "Area/Specialist Maintenance", MessageBoxButtons.OK, _
            MessageBoxIcon.Information)
        End If
        

    End Sub

    Private Sub AreaBrickDataGrid_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AreaBrickDataGrid.CurrentCellChanged

        AreaBrickDataGrid.Select(AreaBrickDataGrid.CurrentCell.RowNumber)
        Populate_Fields()

        EnableAreaSpecialistButtons(True)
        Load_AreaSpecialistDataGrid()
        ClearSpecialistFields()

    End Sub

    Private Sub AreaSpecialistDataGrid_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AreaSpecialistDataGrid.CurrentCellChanged

        AreaSpecialistDataGrid.Select(AreaSpecialistDataGrid.CurrentCell.RowNumber)
        Populate_SpecialistFields()

    End Sub

    Private Sub Populate_SpecialistFields()

        ClearSpecialistFields()
        Try
            With AreaSpecialistDataGrid
                txtRowidSpecialist.Text = CStr(.Item(.CurrentCell.RowNumber, 0))
                txtSpecialistCode.Text = CStr(.Item(.CurrentCell.RowNumber, 1))
                txtSpecialist.Text = CStr(.Item(.CurrentCell.RowNumber, 2))
                SpecialistStartDatePicker.Text = CStr(.Item(.CurrentCell.RowNumber, 3))
                SpecialistEndDatePicker.Text = CStr(.Item(.CurrentCell.RowNumber, 4))
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try

    End Sub

    Private Sub NumericUpDownYear_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumericUpDownYear.ValueChanged

        ClearFields()
        ClearSpecialistFields()
        If TerritoryDataGrid.CurrentRowIndex <> -1 Then TerritoryDataGrid.UnSelect(TerritoryDataGrid.CurrentRowIndex)
        AreaBrickDataGrid.DataSource = Nothing
        AreaSpecialistDataGrid.DataSource = Nothing

    End Sub
End Class
