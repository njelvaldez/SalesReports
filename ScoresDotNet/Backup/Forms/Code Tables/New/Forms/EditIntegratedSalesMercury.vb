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
        'Load_Medrep()
        'Load_Dsm()
        'Load_Nsm()
        'Load_Division()
        'Load_Principal()
        'Load_Item()


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
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress2 As System.Windows.Forms.TextBox
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
    Friend WithEvents txtItemdesc As System.Windows.Forms.TextBox
    Friend WithEvents txtItemcode As System.Windows.Forms.TextBox
    Friend WithEvents btnItem As System.Windows.Forms.Button
    Friend WithEvents txtPMRdesc As System.Windows.Forms.TextBox
    Friend WithEvents txtPMRcode As System.Windows.Forms.TextBox
    Friend WithEvents txtDSMdesc As System.Windows.Forms.TextBox
    Friend WithEvents txtDSMcode As System.Windows.Forms.TextBox
    Friend WithEvents btnDSM As System.Windows.Forms.Button
    Friend WithEvents btnPMR As System.Windows.Forms.Button
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(EditIntegratedSalesMercury))
        Me.datagrid1 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
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
        Me.txtItemdesc = New System.Windows.Forms.TextBox
        Me.txtItemcode = New System.Windows.Forms.TextBox
        Me.btnItem = New System.Windows.Forms.Button
        Me.txtPMRdesc = New System.Windows.Forms.TextBox
        Me.txtPMRcode = New System.Windows.Forms.TextBox
        Me.txtDSMdesc = New System.Windows.Forms.TextBox
        Me.txtDSMcode = New System.Windows.Forms.TextBox
        Me.btnDSM = New System.Windows.Forms.Button
        Me.btnPMR = New System.Windows.Forms.Button
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
        Me.datagrid1.Tag = "View"
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.datagrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn27})
        Me.DataGridTableStyle1.GridLineColor = System.Drawing.Color.Coral
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "IsMercCT"
        Me.DataGridTableStyle1.ReadOnly = True
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
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.MappingName = "itemcode"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 0
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
        Me.DataGridTextBoxColumn5.HeaderText = "Specialist"
        Me.DataGridTextBoxColumn5.MappingName = "pmr"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 190
        '
        'DataGridTextBoxColumn27
        '
        Me.DataGridTextBoxColumn27.Format = ""
        Me.DataGridTextBoxColumn27.FormatInfo = Nothing
        Me.DataGridTextBoxColumn27.HeaderText = "Team Manager"
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
        Me.cmdExit.Location = New System.Drawing.Point(780, 511)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.TabIndex = 127
        Me.cmdExit.Tag = "Exit"
        Me.cmdExit.Text = "Exit"
        '
        'cmdEdit
        '
        Me.cmdEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdEdit.Location = New System.Drawing.Point(628, 511)
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
        Me.cmdSearch.Text = "Enable Parameter Fields"
        '
        'cmdCancel
        '
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdCancel.Location = New System.Drawing.Point(628, 511)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.TabIndex = 122
        Me.cmdCancel.Tag = "Cancel"
        Me.cmdCancel.Text = "Cancel"
        '
        'cmdDelete
        '
        Me.cmdDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDelete.Location = New System.Drawing.Point(704, 511)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.TabIndex = 121
        Me.cmdDelete.Tag = "Delete"
        Me.cmdDelete.Text = "Delete"
        '
        'cmdSave
        '
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSave.Location = New System.Drawing.Point(704, 511)
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
        Me.Label1.Location = New System.Drawing.Point(12, 451)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 130
        Me.Label1.Text = "Branch"
        '
        'txtBranch
        '
        Me.txtBranch.AccessibleDescription = "BranchCode"
        Me.txtBranch.Location = New System.Drawing.Point(10, 467)
        Me.txtBranch.Name = "txtBranch"
        Me.txtBranch.Size = New System.Drawing.Size(101, 20)
        Me.txtBranch.TabIndex = 129
        Me.txtBranch.Tag = "Input"
        Me.txtBranch.Text = ""
        '
        'txtItemdesc
        '
        Me.txtItemdesc.BackColor = System.Drawing.SystemColors.Info
        Me.txtItemdesc.Location = New System.Drawing.Point(69, 512)
        Me.txtItemdesc.Name = "txtItemdesc"
        Me.txtItemdesc.ReadOnly = True
        Me.txtItemdesc.Size = New System.Drawing.Size(225, 20)
        Me.txtItemdesc.TabIndex = 132
        Me.txtItemdesc.Tag = "Input"
        Me.txtItemdesc.Text = ""
        '
        'txtItemcode
        '
        Me.txtItemcode.BackColor = System.Drawing.SystemColors.Info
        Me.txtItemcode.Location = New System.Drawing.Point(9, 512)
        Me.txtItemcode.Name = "txtItemcode"
        Me.txtItemcode.ReadOnly = True
        Me.txtItemcode.Size = New System.Drawing.Size(60, 20)
        Me.txtItemcode.TabIndex = 131
        Me.txtItemcode.Tag = "Input"
        Me.txtItemcode.Text = ""
        '
        'btnItem
        '
        Me.btnItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItem.Location = New System.Drawing.Point(9, 493)
        Me.btnItem.Name = "btnItem"
        Me.btnItem.Size = New System.Drawing.Size(60, 18)
        Me.btnItem.TabIndex = 133
        Me.btnItem.Tag = "Input"
        Me.btnItem.Text = "Item"
        Me.btnItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPMRdesc
        '
        Me.txtPMRdesc.BackColor = System.Drawing.SystemColors.Info
        Me.txtPMRdesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPMRdesc.Location = New System.Drawing.Point(376, 512)
        Me.txtPMRdesc.Name = "txtPMRdesc"
        Me.txtPMRdesc.ReadOnly = True
        Me.txtPMRdesc.Size = New System.Drawing.Size(225, 20)
        Me.txtPMRdesc.TabIndex = 138
        Me.txtPMRdesc.Tag = "Input"
        Me.txtPMRdesc.Text = ""
        '
        'txtPMRcode
        '
        Me.txtPMRcode.BackColor = System.Drawing.SystemColors.Info
        Me.txtPMRcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPMRcode.Location = New System.Drawing.Point(316, 512)
        Me.txtPMRcode.Name = "txtPMRcode"
        Me.txtPMRcode.ReadOnly = True
        Me.txtPMRcode.Size = New System.Drawing.Size(60, 20)
        Me.txtPMRcode.TabIndex = 137
        Me.txtPMRcode.Tag = "Input"
        Me.txtPMRcode.Text = ""
        '
        'txtDSMdesc
        '
        Me.txtDSMdesc.BackColor = System.Drawing.SystemColors.Info
        Me.txtDSMdesc.Location = New System.Drawing.Point(376, 467)
        Me.txtDSMdesc.Name = "txtDSMdesc"
        Me.txtDSMdesc.ReadOnly = True
        Me.txtDSMdesc.Size = New System.Drawing.Size(225, 20)
        Me.txtDSMdesc.TabIndex = 135
        Me.txtDSMdesc.Tag = "Input"
        Me.txtDSMdesc.Text = ""
        '
        'txtDSMcode
        '
        Me.txtDSMcode.BackColor = System.Drawing.SystemColors.Info
        Me.txtDSMcode.Location = New System.Drawing.Point(316, 467)
        Me.txtDSMcode.Name = "txtDSMcode"
        Me.txtDSMcode.ReadOnly = True
        Me.txtDSMcode.Size = New System.Drawing.Size(60, 20)
        Me.txtDSMcode.TabIndex = 134
        Me.txtDSMcode.Tag = "Input"
        Me.txtDSMcode.Text = ""
        '
        'btnDSM
        '
        Me.btnDSM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDSM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDSM.Location = New System.Drawing.Point(316, 448)
        Me.btnDSM.Name = "btnDSM"
        Me.btnDSM.Size = New System.Drawing.Size(102, 18)
        Me.btnDSM.TabIndex = 136
        Me.btnDSM.Tag = "Input"
        Me.btnDSM.Text = "Team Manager"
        Me.btnDSM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnPMR
        '
        Me.btnPMR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPMR.Location = New System.Drawing.Point(316, 493)
        Me.btnPMR.Name = "btnPMR"
        Me.btnPMR.Size = New System.Drawing.Size(103, 18)
        Me.btnPMR.TabIndex = 140
        Me.btnPMR.Tag = "Input"
        Me.btnPMR.Text = "Specialist"
        Me.btnPMR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EditIntegratedSalesMercury
        '
        Me.AccessibleDescription = ""
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1009, 543)
        Me.Controls.Add(Me.btnPMR)
        Me.Controls.Add(Me.txtPMRdesc)
        Me.Controls.Add(Me.txtPMRcode)
        Me.Controls.Add(Me.txtDSMdesc)
        Me.Controls.Add(Me.txtDSMcode)
        Me.Controls.Add(Me.btnDSM)
        Me.Controls.Add(Me.txtItemdesc)
        Me.Controls.Add(Me.txtItemcode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBranch)
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
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAddress2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAddress1)
        Me.Controls.Add(Me.txtRowid)
        Me.Controls.Add(Me.btnItem)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdGo)
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
        modControlBehavior.EnableControlsGroup(Me, True)
        ControlMaintenance.ClearInputControls(Me)
        EditMode = False
    End Sub
    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If Trim(txtRowid.Text) = "" Then
            MessageBox.Show("Please select a record to modify!", "Record Selection", MessageBoxButtons.OK, _
            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            'modControlBehavior.EnableControlsGroup(Me, True)
            btnPMR.Enabled = True : btnDSM.Enabled = True
            EditMode = True
            datagrid1.Enabled = False
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
                btnDSM.Text = "DSM" : btnPMR.Text = "PMR" : btnItem.Text = "Item"
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
        btnDSM.Text = "DSM" : btnPMR.Text = "PMR" : btnItem.Text = "Item"
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
        fillGridFrSearchParam()
        'Button1_Click(Me, Nothing)
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
        MrCode.Value = Trim(txtPMRcode.Text)
        Params(0) = MrCode
        Dim SupCode As New SqlParameter("@SupCode", SqlDbType.VarChar, 10)
        SupCode.Direction = ParameterDirection.Input
        SupCode.Value = Trim(txtDSMcode.Text)
        Params(1) = SupCode
        Dim Rowid As New SqlParameter("@Rownumber", SqlDbType.Int)
        Rowid.Direction = ParameterDirection.Input
        Rowid.Value = Trim(txtRowid.Text)
        Params(2) = Rowid
        BusinessObject.Sub_Update(ServerPath2, "IsMercCT_Update", CommandType.StoredProcedure, Params)
    End Sub
    Private Sub Sub_Show()
        If RemoteDataSet2.IsCT_Show.Count > 0 Then RemoteDataSet2.IsCT_Show.Clear()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "IsCT_Show", CommandType.StoredProcedure, RemoteDataSet2, "IsCT_Show")
        datagrid1.DataSource = RemoteDataSet2.IsCT_Show
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
        For i = 0 To (RemoteDataSet2.IsMercCT.Rows.Count - 1)
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
                txtRowid.Text = Trim(.Item(.CurrentCell.RowNumber, 0).ToString)
                txtItemcode.Text = Trim(.Item(.CurrentCell.RowNumber, 1).ToString)
                z = Trim(.Item(.CurrentCell.RowNumber, 2).ToString)
                If z <> "" Then
                    txtItemdesc.Text = Mid(z, 1, InStr(z, "-") - 1)
                Else
                    txtItemdesc.Text = ""
                End If

                txtRefDate.Text = Format(CDate(Trim(.Item(.CurrentCell.RowNumber, 3).ToString)), "MM/dd/yyyy")
                txtBranch.Text = Mid(Trim(.Item(.CurrentCell.RowNumber, 4).ToString), 1, 3)
                txtAddress1.Text = Trim(.Item(.CurrentCell.RowNumber, 5).ToString)
                txtAddress2.Text = Trim(.Item(.CurrentCell.RowNumber, 6).ToString)
                txtUnitPrice.Text = Trim(.Item(.CurrentCell.RowNumber, 7).ToString)
                txtQty.Text = Trim(.Item(.CurrentCell.RowNumber, 8).ToString)
                txtAmount.Text = Trim(.Item(.CurrentCell.RowNumber, 9).ToString)
                z = Trim(.Item(.CurrentCell.RowNumber, 10).ToString)
                If z <> "" Then
                    txtPMRcode.Text = Mid(z, 1, InStr(z, "-") - 1)
                    txtPMRdesc.Text = Mid(z, InStr(z, "-") + 2, Len(z) - InStr(z, "-") + 1)
                Else
                    txtPMRcode.Text = ""
                    txtPMRdesc.Text = ""
                End If
                z = Trim(.Item(.CurrentCell.RowNumber, 11).ToString)
                If z <> "" Then
                    txtDSMcode.Text = Mid(z, 1, InStr(z, "-") - 1)
                    txtDSMdesc.Text = Mid(z, InStr(z, "-") + 2, Len(z) - InStr(z, "-") + 1)
                Else
                    txtDSMcode.Text = ""
                    txtDSMdesc.Text = ""
                End If
                .Select(.CurrentCell.RowNumber)
            End If
        End With
        'txtRowid.Enabled = False
        'txtRefDate.Enabled = False
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
        btnDSM.Text = "DSM"
        btnPMR.Text = "PMR"
        btnItem.Text = "Item"
        btnItem.Enabled = True
        txtRefDate.Enabled = True : txtBranch.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Create_SearchCondition()
        If MessageBox.Show("Is this search condition correct?" & vbCrLf & SearchString, _
                           "Customer Info Confirmation", MessageBoxButtons.YesNo, _
                            MessageBoxIcon.Question) = DialogResult.Yes Then
            If Trim(txtRefDate.Text) = "" Then
                MsgBox("RefDate is mandatory for searching!")
                txtRefDate.Select()
                Exit Sub
            End If
            If Trim(txtBranch.Text) <> "" Then
                z = "select top 1 branchcode as fld1 from NewScores..mercurysale "
                z = z & "where branchcode = '" & Trim(txtBranch.Text) & "' "
                z = z & "  and refdate    = '" & Trim(txtRefDate.Text) & "' "
                If Existing(z) = False Then
                    MessageBox.Show("This Branch Code does not exist! Please try again.")
                    'txtBranch.Select()
                    Exit Sub
                End If
            End If
            If Trim(txtItemcode.Text) <> "" Then
                z = "select top 1 b.mitemcode as fld1 "
                z = z & "from NewScores..mercurysale b "
                z = z & " inner join NewScores..item a on b.mitemcode = a.mercuryitemcode "
                z = z & "where a.itemcode = '" & Trim(txtItemcode.Text) & "' "
                z = z & "  and b.refdate = '" & Trim(txtRefDate.Text) & "' "
                If Existing(z) = False Then
                    MessageBox.Show("This Item Code does not exist! Please try again.")
                    Exit Sub
                End If
            End If
            fillGridFrSearchParam()
            txtRefDate.Enabled = False : txtBranch.Enabled = False

            'DataMaintenance.myParamArray(0, 0) = "@refDate"
            'DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
            'DataMaintenance.myParamArray(0, 2) = 10
            'DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
            'DataMaintenance.myParamArray(0, 4) = "Date"
            'DataMaintenance.myParamArray(0, 5) = Trim(txtRefDate.Text)
            'DataMaintenance.ExecuteCommand(ServerPath2, "FillMercTemp", CommandType.StoredProcedure, 1)

            'If RemoteDataSet2.IsMercCT.Count > 0 Then RemoteDataSet2.IsMercCT.Clear() 'former dataset IsCT_Show
            'Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            ''Dim Params(0) As SqlParameter
            ''Dim Where As New SqlParameter("@Where", SqlDbType.NVarChar, 2000)
            ''Where.Direction = ParameterDirection.Input


            'Dim Params(1) As SqlParameter
            'Dim ItemCode As New SqlParameter("@ItemCode", SqlDbType.VarChar, 10)
            'ItemCode.Direction = ParameterDirection.Input
            'ItemCode.Value = IIf(Trim(txtItemcode.Text) = "", " ", Trim(txtItemcode.Text))
            'Params(0) = ItemCode
            'Dim Branch As New SqlParameter("@Branch", SqlDbType.Char, 3)
            'Branch.Direction = ParameterDirection.Input
            'Branch.Value = IIf(Trim(txtBranch.Text) = "", " ", Trim(txtBranch.Text))
            'Params(1) = Branch

            ''z = " a.refdate = '" & Trim(txtRefDate.Text) & "' "
            ''If Trim(txtItemcode.Text) <> "" Then
            ''    z = z & " and c.itemcode = '" & Trim(txtItemcode.Text) & "' "
            ''ElseIf Trim(txtBranch.Text) <> "" Then
            ''    z = z & " and RTRIM(a.BranchCode) = '" & Trim(txtBranch.Text) & "' "
            ''End If

            ''Where.Value = z
            ''If Where.Value Is "" Or Where.Value Is Nothing Then
            ''    MsgBox("No Search parameters. Nothing to search.")
            ''    Exit Sub
            ''End If
            ''Params(0) = Where

            ''datagrid1.DataSource = Nothing
            'BusinessObject.Sub_Show(ServerPath2, "IsMercCT_DynamicSearch", CommandType.StoredProcedure, RemoteDataSet2, "IsMercCT", Params)
            'datagrid1.DataSource = RemoteDataSet2.IsMercCT
            'txtRefDate.Enabled = False : txtBranch.Enabled = False
        End If
    End Sub

    Private Sub fillGridFrSearchParam()
        DataMaintenance.myParamArray(0, 0) = "@refDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = Trim(txtRefDate.Text)
        DataMaintenance.ExecuteCommand(ServerPath2, "FillMercTemp", CommandType.StoredProcedure, 1)

        If RemoteDataSet2.IsMercCT.Count > 0 Then RemoteDataSet2.IsMercCT.Clear() 'former dataset IsCT_Show
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(1) As SqlParameter
        Dim ItemCode As New SqlParameter("@ItemCode", SqlDbType.VarChar, 10)
        ItemCode.Direction = ParameterDirection.Input
        ItemCode.Value = IIf(Trim(txtItemcode.Text) = "", " ", Trim(txtItemcode.Text))
        Params(0) = ItemCode
        Dim Branch As New SqlParameter("@Branch", SqlDbType.Char, 3)
        Branch.Direction = ParameterDirection.Input
        Branch.Value = IIf(Trim(txtBranch.Text) = "", " ", Trim(txtBranch.Text))
        Params(1) = Branch
        BusinessObject.Sub_Show(ServerPath2, "IsMercCT_DynamicSearch", CommandType.StoredProcedure, RemoteDataSet2, "IsMercCT", Params)
        datagrid1.DataSource = RemoteDataSet2.IsMercCT
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

    Private Sub btnItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItem.Click
        Dim popupFrm As New frmCodDesc
        gCode = txtItemcode.Text : gDesc = txtItemdesc.Text
        z = "select itemcode xcode, itemdesc xdesc from NewScores..item where mercuryitemcode in "
        z = z & "(select distinct mitemcode from NewScores..mercurysale where refdate = '" & Trim(txtRefDate.Text) & "') "
        StordProcName = z
        SPparam = True
        popupFrm.ShowDialog(Me)
        txtItemcode.Text = gCode
        txtItemdesc.Text = gDesc
    End Sub

    Private Sub btnPMR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPMR.Click
        Dim popupFrm As New frmCodDesc
        gCode = txtPMRcode.Text : gDesc = txtPMRdesc.Text
        z = "select mrcode xcode, mrname xdesc from NewScores..medrep where mrcode in "
        z = z & "(select distinct mrcode from NewScores..mercurysale where refdate = '" & Trim(txtRefDate.Text) & "')"
        StordProcName = z
        SPparam = True
        popupFrm.ShowDialog(Me)
        txtPMRcode.Text = gCode
        txtPMRdesc.Text = gDesc
    End Sub

    Private Sub btnDSM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDSM.Click
        Dim popupFrm As New frmCodDesc
        gCode = txtDSMcode.Text : gDesc = txtDSMdesc.Text
        z = "select supcode xcode, supname xdesc from NewScores..supervisor where supcode in "
        z = z & "(select distinct supcode from NewScores..mercurysale where refdate = '" & Trim(txtRefDate.Text) & "')"
        StordProcName = z
        SPparam = True
        popupFrm.ShowDialog(Me)
        txtDSMcode.Text = gCode
        txtDSMdesc.Text = gDesc
    End Sub
End Class