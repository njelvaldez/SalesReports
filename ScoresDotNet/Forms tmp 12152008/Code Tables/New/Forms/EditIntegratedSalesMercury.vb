Imports System.Data.SqlClient
Imports Microsoft
Public Class EditIntegratedSalesMercury
    Inherits System.Windows.Forms.Form
    Private RemoteDataSet As New CodeTablesDS
    Private RemoteDataSet2 As New MyDataSetDB
    Private EditMode As Boolean = False
    Public SearchString As String

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        'Sub_Show()
        'Load_Customer()
        'Load_Territory()
        'Load_Province()
        'Load_Group()
        Load_Medrep()
        Load_Dsm()
        'Load_Nsm()
        'Load_Division()
        'Load_Principal()
        Load_Item()


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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents cboDSM As System.Windows.Forms.ComboBox
    Friend WithEvents cboMedrep As System.Windows.Forms.ComboBox
    Friend WithEvents cboItem As System.Windows.Forms.ComboBox
    Friend WithEvents txtUnitPrice As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents datagrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents txtRowid As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTextBoxColumn27 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtDynamic As System.Windows.Forms.TextBox
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdGo As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtBranch As System.Windows.Forms.TextBox
    Friend WithEvents txtRefDate As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(EditIntegratedSalesMercury))
        Me.datagrid1 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn27 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.txtAddress1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtAddress2 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cboDSM = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cboMedrep = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.cboItem = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.txtUnitPrice = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.txtRowid = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.txtDynamic = New System.Windows.Forms.TextBox
        Me.txtRefDate = New System.Windows.Forms.TextBox
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmdSearch = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdGo = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBranch = New System.Windows.Forms.TextBox
        CType(Me.datagrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'datagrid1
        '
        Me.datagrid1.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.datagrid1.BackColor = System.Drawing.Color.Gainsboro
        Me.datagrid1.BackgroundColor = System.Drawing.Color.DarkGray
        Me.datagrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.datagrid1.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.datagrid1.CaptionForeColor = System.Drawing.Color.White
        Me.datagrid1.CaptionText = "Raw Data"
        Me.datagrid1.DataMember = ""
        Me.datagrid1.FlatMode = True
        Me.datagrid1.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.datagrid1.ForeColor = System.Drawing.Color.Black
        Me.datagrid1.GridLineColor = System.Drawing.Color.Silver
        Me.datagrid1.HeaderBackColor = System.Drawing.Color.Black
        Me.datagrid1.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.datagrid1.HeaderForeColor = System.Drawing.Color.White
        Me.datagrid1.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.datagrid1.Location = New System.Drawing.Point(9, 10)
        Me.datagrid1.Name = "datagrid1"
        Me.datagrid1.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.datagrid1.ParentRowsForeColor = System.Drawing.Color.Black
        Me.datagrid1.ReadOnly = True
        Me.datagrid1.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.datagrid1.SelectionForeColor = System.Drawing.Color.White
        Me.datagrid1.Size = New System.Drawing.Size(997, 378)
        Me.datagrid1.TabIndex = 44
        Me.datagrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.datagrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn27})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "IsMercCT"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Rowid"
        Me.DataGridTextBoxColumn1.MappingName = "Rowid"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Item"
        Me.DataGridTextBoxColumn2.MappingName = "item"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 200
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "RefDate"
        Me.DataGridTextBoxColumn9.MappingName = "refdate"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 70
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Branch"
        Me.DataGridTextBoxColumn3.MappingName = "Branch"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 200
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "Address 1"
        Me.DataGridTextBoxColumn10.MappingName = "Address1"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.Width = 0
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "Address 2"
        Me.DataGridTextBoxColumn11.MappingName = "Address2"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.Width = 0
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "Unit Price"
        Me.DataGridTextBoxColumn12.MappingName = "UnitPrice"
        Me.DataGridTextBoxColumn12.NullText = ""
        Me.DataGridTextBoxColumn12.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Qty"
        Me.DataGridTextBoxColumn6.MappingName = "Qty"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 50
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Amount"
        Me.DataGridTextBoxColumn4.MappingName = "Amount"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 120
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "MedRep"
        Me.DataGridTextBoxColumn5.MappingName = "pmr"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 190
        '
        'DataGridTextBoxColumn27
        '
        Me.DataGridTextBoxColumn27.Format = ""
        Me.DataGridTextBoxColumn27.FormatInfo = Nothing
        Me.DataGridTextBoxColumn27.HeaderText = "Supervisor"
        Me.DataGridTextBoxColumn27.MappingName = "dsm"
        Me.DataGridTextBoxColumn27.NullText = ""
        Me.DataGridTextBoxColumn27.Width = 200
        '
        'txtAddress1
        '
        Me.txtAddress1.AccessibleDescription = "Address1"
        Me.txtAddress1.Location = New System.Drawing.Point(627, 421)
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(261, 20)
        Me.txtAddress1.TabIndex = 47
        Me.txtAddress1.Tag = "Input"
        Me.txtAddress1.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(629, 404)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Address 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(629, 451)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Address 2"
        '
        'txtAddress2
        '
        Me.txtAddress2.AccessibleDescription = "Address2"
        Me.txtAddress2.Location = New System.Drawing.Point(627, 467)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(261, 20)
        Me.txtAddress2.TabIndex = 49
        Me.txtAddress2.Tag = "Input"
        Me.txtAddress2.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(335, 495)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 16)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "District Sales Manager"
        '
        'cboDSM
        '
        Me.cboDSM.AccessibleDescription = "SupCode"
        Me.cboDSM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboDSM.Location = New System.Drawing.Point(333, 511)
        Me.cboDSM.Name = "cboDSM"
        Me.cboDSM.Size = New System.Drawing.Size(261, 21)
        Me.cboDSM.TabIndex = 59
        Me.cboDSM.Tag = "Input"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(335, 451)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 16)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Medrep"
        '
        'cboMedrep
        '
        Me.cboMedrep.AccessibleDescription = "MrCode"
        Me.cboMedrep.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboMedrep.Location = New System.Drawing.Point(333, 467)
        Me.cboMedrep.Name = "cboMedrep"
        Me.cboMedrep.Size = New System.Drawing.Size(261, 21)
        Me.cboMedrep.TabIndex = 57
        Me.cboMedrep.Tag = "Input"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 451)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(26, 16)
        Me.Label13.TabIndex = 70
        Me.Label13.Text = "Item"
        '
        'cboItem
        '
        Me.cboItem.AccessibleDescription = "ItemDesc"
        Me.cboItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboItem.Location = New System.Drawing.Point(9, 467)
        Me.cboItem.Name = "cboItem"
        Me.cboItem.Size = New System.Drawing.Size(261, 21)
        Me.cboItem.TabIndex = 69
        Me.cboItem.Tag = "Input"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 404)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 16)
        Me.Label15.TabIndex = 74
        Me.Label15.Text = "Ref Date"
        '
        'txtQty
        '
        Me.txtQty.AccessibleDescription = "QtyFree"
        Me.txtQty.Location = New System.Drawing.Point(430, 421)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(42, 20)
        Me.txtQty.TabIndex = 76
        Me.txtQty.Tag = "Input"
        Me.txtQty.Text = ""
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.AccessibleDescription = "UnitPrice"
        Me.txtUnitPrice.Location = New System.Drawing.Point(333, 421)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(92, 20)
        Me.txtUnitPrice.TabIndex = 77
        Me.txtUnitPrice.Tag = "Input"
        Me.txtUnitPrice.Text = ""
        Me.txtUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(450, 404)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(22, 16)
        Me.Label17.TabIndex = 79
        Me.Label17.Text = "Qty"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(372, 404)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(53, 16)
        Me.Label18.TabIndex = 80
        Me.Label18.Text = "Unit Price"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(551, 404)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(43, 16)
        Me.Label19.TabIndex = 84
        Me.Label19.Text = "Amount"
        '
        'txtAmount
        '
        Me.txtAmount.AccessibleDescription = "CreditedAmount"
        Me.txtAmount.Location = New System.Drawing.Point(477, 421)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(117, 20)
        Me.txtAmount.TabIndex = 83
        Me.txtAmount.Tag = "Input"
        Me.txtAmount.Text = ""
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRowid
        '
        Me.txtRowid.AccessibleDescription = "Rowid"
        Me.txtRowid.Location = New System.Drawing.Point(21, 346)
        Me.txtRowid.Name = "txtRowid"
        Me.txtRowid.Size = New System.Drawing.Size(89, 20)
        Me.txtRowid.TabIndex = 94
        Me.txtRowid.Tag = "Input"
        Me.txtRowid.Text = ""
        Me.txtRowid.Visible = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(22, 329)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(39, 16)
        Me.Label27.TabIndex = 103
        Me.Label27.Text = "Row Id"
        Me.Label27.Visible = False
        '
        'txtDynamic
        '
        Me.txtDynamic.Location = New System.Drawing.Point(660, 353)
        Me.txtDynamic.Name = "txtDynamic"
        Me.txtDynamic.TabIndex = 104
        Me.txtDynamic.Text = ""
        Me.txtDynamic.Visible = False
        '
        'txtRefDate
        '
        Me.txtRefDate.AccessibleDescription = "RefDate"
        Me.txtRefDate.Location = New System.Drawing.Point(9, 421)
        Me.txtRefDate.Name = "txtRefDate"
        Me.txtRefDate.Size = New System.Drawing.Size(101, 20)
        Me.txtRefDate.TabIndex = 106
        Me.txtRefDate.Tag = "Input"
        Me.txtRefDate.Text = ""
        '
        'cmdExit
        '
        Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdExit.Location = New System.Drawing.Point(773, 511)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.TabIndex = 127
        Me.cmdExit.Tag = "Exit"
        Me.cmdExit.Text = "Exit"
        '
        'cmdEdit
        '
        Me.cmdEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdEdit.Location = New System.Drawing.Point(621, 511)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.TabIndex = 126
        Me.cmdEdit.Tag = "Edit"
        Me.cmdEdit.Text = "Edit"
        '
        'cmdAdd
        '
        Me.cmdAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdAdd.Location = New System.Drawing.Point(564, 351)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.TabIndex = 125
        Me.cmdAdd.Tag = "Add"
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.Visible = False
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(915, 419)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 48)
        Me.Button1.TabIndex = 124
        Me.Button1.Text = "Search"
        '
        'cmdSearch
        '
        Me.cmdSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.Location = New System.Drawing.Point(916, 487)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(83, 47)
        Me.cmdSearch.TabIndex = 123
        Me.cmdSearch.Tag = ""
        Me.cmdSearch.Text = "Open Parameter Fields"
        '
        'cmdCancel
        '
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdCancel.Location = New System.Drawing.Point(621, 511)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.TabIndex = 122
        Me.cmdCancel.Tag = "Cancel"
        Me.cmdCancel.Text = "Cancel"
        '
        'cmdDelete
        '
        Me.cmdDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDelete.Location = New System.Drawing.Point(697, 511)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.TabIndex = 121
        Me.cmdDelete.Tag = "Delete"
        Me.cmdDelete.Text = "Delete"
        '
        'cmdSave
        '
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSave.Location = New System.Drawing.Point(697, 511)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.TabIndex = 128
        Me.cmdSave.Tag = "Save"
        Me.cmdSave.Text = "Save"
        '
        'cmdGo
        '
        Me.cmdGo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdGo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdGo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGo.Location = New System.Drawing.Point(916, 511)
        Me.cmdGo.Name = "cmdGo"
        Me.cmdGo.Size = New System.Drawing.Size(83, 23)
        Me.cmdGo.TabIndex = 120
        Me.cmdGo.Tag = ""
        Me.cmdGo.Text = "Go !"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 495)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 130
        Me.Label1.Text = "Branch"
        '
        'txtBranch
        '
        Me.txtBranch.AccessibleDescription = "BranchCode"
        Me.txtBranch.Location = New System.Drawing.Point(9, 511)
        Me.txtBranch.Name = "txtBranch"
        Me.txtBranch.Size = New System.Drawing.Size(261, 20)
        Me.txtBranch.TabIndex = 129
        Me.txtBranch.Tag = "Input"
        Me.txtBranch.Text = ""
        '
        'EditIntegratedSalesMercury
        '
        Me.AccessibleDescription = ""
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1009, 543)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBranch)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdGo)
        Me.Controls.Add(Me.txtRefDate)
        Me.Controls.Add(Me.txtDynamic)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtUnitPrice)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAddress2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAddress1)
        Me.Controls.Add(Me.txtRowid)
        Me.Controls.Add(Me.cboItem)
        Me.Controls.Add(Me.cboDSM)
        Me.Controls.Add(Me.cboMedrep)
        Me.Controls.Add(Me.datagrid1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditIntegratedSalesMercury"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Edit Mercury Sales"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.datagrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        modControlBehavior.EnableControls(Me, True)
        ControlMaintenance.ClearInputControls(Me)
        EditMode = False
    End Sub
    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If txtRowid.Text = "" Then
            MessageBox.Show("Please select a record to modify!", "Record Selection", MessageBoxButtons.OK, _
            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            'modControlBehavior.EnableControls(Me, True)
            cboMedrep.Enabled = True : cboDSM.Enabled = True
            EditMode = True
            cmdCancel.Enabled = True : cmdCancel.Visible = True : cmdCancel.BringToFront()
            cmdSave.Enabled = True : cmdSave.Visible = True : cmdSave.BringToFront()
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
        modControlBehavior.EnableControls(Me, False)
        ControlMaintenance.ClearInputControls(Me)
        EditMode = False
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim Params(0) As String
        Params(0) = txtRowid.Text
        If EditMode = False Then
            Sub_Insert()
        Else
            Sub_Update()
        End If
        datagrid1.DataSource = Nothing
        Button1_Click(Me, Nothing)
        Sub_Select(Params, CStr(IIf(EditMode = False, "Insert", "Update")))
        EditMode = False
        modControlBehavior.EnableControls(Me, False)
    End Sub
    Private Sub Sub_Insert()
        'Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        'Dim Params(36) As SqlParameter
        'Dim CreateDate As New SqlParameter("@CreateDate", SqlDbType.DateTime) : CreateDate.Direction = ParameterDirection.Input : CreateDate.Value = Now() : Params(35) = CreateDate
        'Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime) : UpdateDate.Direction = ParameterDirection.Input : UpdateDate.Value = Now() : Params(36) = UpdateDate
        'BusinessObject.Sub_Insert(ServerPath2, "IsCT_Insert", CommandType.StoredProcedure, Params)
    End Sub
    Private Sub Sub_Update()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(2) As SqlParameter
        Dim MrCode As New SqlParameter("@MrCode", SqlDbType.VarChar, 10)
        MrCode.Direction = ParameterDirection.Input
        MrCode.Value = GetCode(cboMedrep.Text)
        Params(0) = MrCode
        Dim SupCode As New SqlParameter("@SupCode", SqlDbType.VarChar, 10)
        SupCode.Direction = ParameterDirection.Input
        SupCode.Value = GetCode(cboDSM.Text)
        Params(1) = SupCode
        Dim Rowid As New SqlParameter("@Rownumber", SqlDbType.Int)
        Rowid.Direction = ParameterDirection.Input
        Rowid.Value = txtRowid.Text
        Params(2) = Rowid
        BusinessObject.Sub_Update(ServerPath2, "IsMercCT_Update", CommandType.StoredProcedure, Params)
    End Sub
    Private Sub Sub_Show()
        If RemoteDataSet2.IsCT_Show.Count > 0 Then RemoteDataSet2.IsCT_Show.Clear()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "IsCT_Show", CommandType.StoredProcedure, RemoteDataSet2, "IsCT_Show")
        datagrid1.DataSource = RemoteDataSet2.IsCT_Show
    End Sub
    Private Sub Load_Medrep()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "Medrep_Combo", CommandType.StoredProcedure, RemoteDataSet, "Medrep_Combo")
        cboMedrep.DataSource = RemoteDataSet.Medrep_Combo
        cboMedrep.DisplayMember = "Medrep"
    End Sub
    Private Sub Load_Dsm()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "Dsm_Combo", CommandType.StoredProcedure, RemoteDataSet, "Dsm_Combo")
        cboDSM.DataSource = RemoteDataSet.DSm_Combo
        cboDSM.DisplayMember = "Dsm"
    End Sub
    Private Sub Load_Item()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "Item_Combo", CommandType.StoredProcedure, RemoteDataSet, "Item_Combo")
        cboItem.DataSource = RemoteDataSet.Item_Combo
        cboItem.DisplayMember = "Item"
    End Sub
    Private Sub Sub_Select(ByVal dbParams() As String, ByVal UpdateMode As String)
        'select case if add,edit or delete
        Dim i As Integer
        Dim myRowid As Integer
        Select Case UpdateMode
            Case "Insert"
                Dim BusinessObject As New BusinessLayer.clsFileMaintenance
                myRowid = CInt(BusinessObject.Sub_ReturnIntegerResult(ServerPath2, "IsCT_GetInsertedRowid", CommandType.StoredProcedure))
            Case "Update"
                myRowid = CInt(dbParams(0))
        End Select
        For i = 0 To (RemoteDataSet2.IsCT_Show.Rows.Count - 1)
            With datagrid1
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
        Dim Rowid As New SqlParameter("@Rowid", SqlDbType.Int) : Rowid.Direction = ParameterDirection.Input : Rowid.Value = txtRowid.Text : Params(0) = Rowid
        BusinessObject.Sub_Delete(ServerPath2, "IsCT_Delete", CommandType.StoredProcedure, Params)
    End Sub
    Private Sub IsCT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        modControlBehavior.EnableControls(Me, False)
    End Sub
    Private Sub DataGrid1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles datagrid1.Click, datagrid1.CurrentCellChanged
        With datagrid1
            If RemoteDataSet2.IsMercCT.Count > 0 Then
                txtRowid.Text = CStr(.Item(.CurrentCell.RowNumber, 0))
                cboItem.Text = CStr(.Item(.CurrentCell.RowNumber, 1))
                txtRefDate.Text = CStr(.Item(.CurrentCell.RowNumber, 2))
                txtBranch.Text = CStr(.Item(.CurrentCell.RowNumber, 3))
                txtAddress1.Text = CStr(.Item(.CurrentCell.RowNumber, 4))
                txtAddress2.Text = CStr(.Item(.CurrentCell.RowNumber, 5))
                txtUnitPrice.Text = CStr(.Item(.CurrentCell.RowNumber, 6))
                txtQty.Text = CStr(.Item(.CurrentCell.RowNumber, 7))
                txtAmount.Text = CStr(.Item(.CurrentCell.RowNumber, 8))
                cboMedrep.Text = CStr(.Item(.CurrentCell.RowNumber, 9))
                cboDSM.Text = CStr(.Item(.CurrentCell.RowNumber, 10))
                .Select(.CurrentCell.RowNumber)
            End If
        End With
        'txtRowid.Enabled = False
        'txtRefDate.Enabled = False
        'cboItem.Enabled = False
        modControlBehavior.EnableControls(Me, False)
    End Sub

    Private Function Create_SearchCondition() As String
        Dim MyControl As Control
        Dim MyString As String
        Dim Spacer As String, tmpTxt As String
        SearchString = ""
        If txtDynamic.Text = "" Then
            For Each MyControl In Me.Controls
                If TypeOf MyControl Is TextBox Or (TypeOf MyControl Is ComboBox And MyControl.Text > "") _
                Or (TypeOf MyControl Is DateTimePicker And InStr(MyControl.Text, "9998") < 1) Then
                    If MyControl.Text > "" Then
                        Spacer = VisualBasic.Space(15 - VisualBasic.Len(MyControl.AccessibleDescription)) & VisualBasic.vbTab
                        If InStr(UCase(MyControl.AccessibleDescription), "DESC") <> 0 Or InStr(UCase(MyControl.AccessibleDescription), "NAME") <> 0 Then
                            tmpTxt = GetDescription(MyControl.Text)
                        ElseIf InStr(UCase(MyControl.AccessibleDescription), "CODE") <> 0 Then
                            tmpTxt = GetCode(MyControl.Text)
                        Else
                            tmpTxt = Trim(MyControl.Text)
                        End If
                        If MyString = "" Then
                            MyString = MyControl.AccessibleDescription & " = '" & tmpTxt & "'"
                            SearchString = MyControl.AccessibleDescription & Spacer & " : " & VisualBasic.vbTab & tmpTxt
                        Else
                            MyString = MyString & " and " & MyControl.AccessibleDescription & " = '" & tmpTxt & "'"
                            SearchString = SearchString & VisualBasic.vbCrLf & MyControl.AccessibleDescription & Spacer & " : " & VisualBasic.vbTab & tmpTxt
                        End If
                    End If
                End If
                If TypeOf MyControl Is CheckBox Then
                    If SearchString = "" Then
                        MyString = MyControl.AccessibleDescription & " = "
                    Else

                    End If
                End If
            Next
            txtDynamic.Text = MyString
        Else
            MyString = txtDynamic.Text
        End If
        Return MyString
    End Function

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        txtDynamic.Text = ""
        ControlMaintenance.ClearInputControls(Me)
        cboItem.Enabled = True
        txtRefDate.Enabled = True : txtBranch.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'cboItem.Text = GetDescription(cboItem.Text)
        'Create_SearchCondition()
        If MessageBox.Show("Is this search condition correct?" & vbCrLf & SearchString, _
                           "Customer Info Confirmation", MessageBoxButtons.YesNo, _
                            MessageBoxIcon.Question) = DialogResult.Yes Then
            If Trim(txtBranch.Text) <> "" Then
                z = "select top 1 branchcode as fld1 from NewScores..mercurysale "
                z = z & "where branchcode = '" & Trim(txtBranch.Text) & "' "
                z = z & "  and refdate    = '" & Trim(txtRefDate.Text) & "' "
                If Existing(z) = False Then
                    MessageBox.Show("This Branch Code does not exist! Please try again.")
                    txtBranch.Select()
                    Exit Sub
                End If
            End If
            If Trim(cboItem.Text) <> "" Then
                z = "select top 1 b.mitemcode as fld1 "
                z = z & "from NewScores..mercurysale b "
                z = z & " inner join NewScores..item a on b.mitemcode = a.mercuryitemcode "
                z = z & "where a.itemcode = '" & Trim(GetCode2(cboItem.Text)) & "' "
                z = z & "  and b.refdate = '" & Trim(txtRefDate.Text) & "' "
                If Existing(z) = False Then
                    MessageBox.Show("This Item Code does not exist! Please try again.")
                    cboItem.Select()
                    Exit Sub
                End If
            End If
            If Trim(txtRefDate.Text) = "" Then
                MsgBox("RefDate is mandatory for this search!")
                txtRefDate.Select()
                Exit Sub
            End If

            If RemoteDataSet2.IsCT_Show.Count > 0 Then RemoteDataSet2.IsCT_Show.Clear()
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim Where As New SqlParameter("@Where", SqlDbType.NVarChar, 2000)
            Where.Direction = ParameterDirection.Input

            z = " a.refdate = '" & Trim(txtRefDate.Text) & "' and "
            If Trim(cboItem.Text) <> "" Then
                z = z & " c.itemcode = '" & GetCode2(cboItem.Text) & "' "
            ElseIf Trim(txtBranch.Text) <> "" Then
                z = z & " a.branchcode = '" & Trim(txtBranch.Text) & "' "
            End If

            Where.Value = z
            If Where.Value Is "" Or Where.Value Is Nothing Then
                MsgBox("No Search parameters. Nothing to search.")
                Exit Sub
            End If
            Params(0) = Where
            BusinessObject.Sub_Show(ServerPath2, "IsMercCT_DynamicSearch", CommandType.StoredProcedure, RemoteDataSet2, "IsMercCT", Params)
            datagrid1.DataSource = RemoteDataSet2.IsMercCT
            cboItem.Enabled = False
            txtRefDate.Enabled = False : txtBranch.Enabled = False
        End If
    End Sub

    Private Sub txtRefDate_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRefDate.KeyUp
        If e.KeyValue = 13 Then      ' tests if the key pressed is the "enter key"
            SendKeys.Send("{TAB}")   ' sends the focus to the next control/tabstop
        End If
    End Sub

    Private Sub txtRefDate_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtRefDate.Validating
        txtRefDate.Text = DatValid(txtRefDate.Text)  'validating the entry. the textbox's value will be "mm/dd/yyyy" if the entry is invalid.
        If Trim(txtRefDate.Text) <> "mm/dd/yyyy" Then
            Exit Sub
        End If
        e.Cancel() = True
    End Sub

    Private Sub txtBranch_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBranch.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtBranch_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtBranch.Validating
        If Trim(txtBranch.Text) <> "" Then
            If Trim(cboItem.Text) <> "" Then
                cboItem.Text = ""
            End If
        End If
    End Sub

    Private Sub cboItem_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboItem.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cboItem_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboItem.Validating
        If Trim(cboItem.Text) <> "" Then
            If Trim(txtBranch.Text) <> "" Then
                txtBranch.Text = ""
                'Else
                '    z = "select itemdesc from newscores..item where itemcode = '" & Trim(GetCode2(cboItem.Text)) & "' "
                '    cboItem.Text = GetCode2(cboItem.Text) & "--" & FindValue(z)
            End If
        End If
    End Sub

    Private Sub cboMedrep_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboMedrep.KeyUp
        If e.KeyData.ToString = System.Windows.Forms.Keys.Up.ToString _
           Or e.KeyData.ToString = System.Windows.Forms.Keys.Left.ToString Then 'if key pressed is the up arrow it will select the next selection before the selction
            cboMedrep.SelectedItem = cboMedrep.SelectedIndex - 1
        ElseIf e.KeyData.ToString = System.Windows.Forms.Keys.Down.ToString _
           Or e.KeyData.ToString = System.Windows.Forms.Keys.Right.ToString Then 'if key pressed is the up arrow it will select the next selection after the selction
            cboMedrep.SelectedItem = cboMedrep.SelectedIndex + 1
        ElseIf DKcodes(e.KeyData) = True Then    'checking if the key pressed is alphanumeric (to disallow typing the entry)
            cboMedrep.Text = ""     'if alphanumeric then the value of the field will be erased
        End If
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")      'moves control to the next control or field
        End If
    End Sub

    Private Sub cboMedrep_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboMedrep.Validating
        z = "SELECT d.supname, c.itemcode "
        z = z & "FROM NewScores..supmr a "
        z = z & " left outer JOIN NewScores..principal b on a.teamdivision = b.divgroup "
        z = z & " left outer join NewScores..item c on b.princode = c.princode "
        z = z & " left outer join NewScores..supervisor d on a.supcode = d.supcode "
        z = z & "where '" & Trim(txtRefDate.Text) & "' between a.start_date and a.end_date  "
        z = z & "  and rtrim(a.mrcode) = '" & GetCode(cboMedrep.Text) & "' "
        cboDSM.Text = FindValue(z)

    End Sub

    Private Sub cboDSM_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboDSM.KeyUp
        If e.KeyData.ToString = System.Windows.Forms.Keys.Up.ToString _
           Or e.KeyData.ToString = System.Windows.Forms.Keys.Left.ToString Then 'if key pressed is the up arrow it will select the next selection before the selction
            cboDSM.SelectedItem = cboDSM.SelectedIndex - 1
        ElseIf e.KeyData.ToString = System.Windows.Forms.Keys.Down.ToString _
           Or e.KeyData.ToString = System.Windows.Forms.Keys.Right.ToString Then 'if key pressed is the up arrow it will select the next selection after the selction
            cboDSM.SelectedItem = cboDSM.SelectedIndex + 1
        ElseIf DKcodes(e.KeyData) = True Then    'checking if the key pressed is alphanumeric (to disallow typing the entry)
            cboDSM.Text = ""     'if alphanumeric then the value of the field will be erased
        End If
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")      'moves control to the next control or field
        End If
    End Sub
End Class