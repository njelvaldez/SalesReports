Imports System.Data.SqlClient
Imports System.Threading
Imports System.Globalization
Public Class SalesAdjustments
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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CustomerTab As System.Windows.Forms.TabPage
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents CustomerDr As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents CustomerCode As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents CustomerName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Address1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Address2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents HeaderDataGrid As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents RefCode As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents RefDate As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents InvoiceDataGrid As System.Windows.Forms.DataGrid
    Friend WithEvents LineItemDataGrid As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle3 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents ItemCode As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ItemDesc As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents QtySold As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents QtyFree As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents UnitPrice As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents CreditedAmount As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents InvoiceLine As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Rowid As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents InvoiceTab As System.Windows.Forms.TabPage
    Friend WithEvents ItemTab As System.Windows.Forms.TabPage
    Friend WithEvents Crediting As System.Windows.Forms.TabPage
    Friend WithEvents Misc As System.Windows.Forms.TabPage
    Friend WithEvents txtSearchCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox31 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRowid As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox33 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCustomerType As System.Windows.Forms.TextBox
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents txtAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerCode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerDr As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox32 As System.Windows.Forms.GroupBox
    Friend WithEvents txtShipAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtShipAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtShipTo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox34 As System.Windows.Forms.GroupBox
    Friend WithEvents txtIslandGroup As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtGroup As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtGroupDr As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtProvince As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtProvinceDr As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTerritory As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTerritoryDr As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtInvoiceLine As System.Windows.Forms.TextBox
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents txtValueAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtTax As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtVat As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtVatCode As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtDiscRate As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtRefDate As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtRefCode As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtOldCmRefDate As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents txtOldCmRefInvoice As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents txtOldCmCode As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtCmRefItemDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtCmRefItemCode As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtCmRefAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtCmRefPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtCmRefQtyFree As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtCmRefQtySold As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtCmRefDate As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtCmRefInvoice As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtCmCode As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtSoDate As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtSoCode As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDistributor As System.Windows.Forms.TextBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents txtCompany As System.Windows.Forms.TextBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents txtDivisionDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents txtDivisionCode As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents txtPrincipalDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents txtPrincipalCode As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents txtItemDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents txtItemCode As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCreditedAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents txtAmountSold As System.Windows.Forms.TextBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents txtUnitPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents txtQtyFree As System.Windows.Forms.TextBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents txtQtySold As System.Windows.Forms.TextBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents GroupBox30 As System.Windows.Forms.GroupBox
    Friend WithEvents txtExpiryDate As System.Windows.Forms.TextBox
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents txtLotNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents txtSubDist_Code As System.Windows.Forms.TextBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents txtDist_Code As System.Windows.Forms.TextBox
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents txtOutOfStock As System.Windows.Forms.TextBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCurrentDivision As System.Windows.Forms.TextBox
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents txtQtyLoose As System.Windows.Forms.TextBox
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents txtQtyConverted As System.Windows.Forms.TextBox
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMdiSalesDate As System.Windows.Forms.TextBox
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents txtMdiCycleDate As System.Windows.Forms.TextBox
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents txtSalesCycleDate As System.Windows.Forms.TextBox
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents txtCommissionDate As System.Windows.Forms.TextBox
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSalesClass As System.Windows.Forms.TextBox
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents txtExcessSales As System.Windows.Forms.TextBox
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents txtSubSaleType As System.Windows.Forms.TextBox
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents txtTransactionType As System.Windows.Forms.TextBox
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents txtSaleType As System.Windows.Forms.TextBox
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNavTag As System.Windows.Forms.TextBox
    Friend WithEvents Label92 As System.Windows.Forms.Label
    Friend WithEvents txtMdsDr As System.Windows.Forms.TextBox
    Friend WithEvents Label91 As System.Windows.Forms.Label
    Friend WithEvents txtExcludeAttachment As System.Windows.Forms.TextBox
    Friend WithEvents Label90 As System.Windows.Forms.Label
    Friend WithEvents GroupBox24 As System.Windows.Forms.GroupBox
    Friend WithEvents txtUpdateDate As System.Windows.Forms.TextBox
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents txtCreateDate As System.Windows.Forms.TextBox
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents txtCreate_Date As System.Windows.Forms.TextBox
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNsmName As System.Windows.Forms.TextBox
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents txtNsmCode As System.Windows.Forms.TextBox
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents txtSupName As System.Windows.Forms.TextBox
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents txtSupCode As System.Windows.Forms.TextBox
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents txtMrName As System.Windows.Forms.TextBox
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents txtMrCode As System.Windows.Forms.TextBox
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents txtMrDivision As System.Windows.Forms.TextBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPmName As System.Windows.Forms.TextBox
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents txtPmCode As System.Windows.Forms.TextBox
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents txtKasGovName As System.Windows.Forms.TextBox
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents txtKasGovCode As System.Windows.Forms.TextBox
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents txtModTradeDsmName As System.Windows.Forms.TextBox
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents txtModTradeDsmCode As System.Windows.Forms.TextBox
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents GroupBox16 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFloaterMrName As System.Windows.Forms.TextBox
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents txtFloaterMrCode As System.Windows.Forms.TextBox
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents GroupBox17 As System.Windows.Forms.GroupBox
    Friend WithEvents txtQpiAreaCode As System.Windows.Forms.TextBox
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Filter As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox18 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolBarButtonSearch As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButtonUndo As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButtonSave As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButtonEdit As System.Windows.Forms.ToolBarButton
    Friend WithEvents CustomerLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents ItemLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents dtpCommissionDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpSalesCycleDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpMdiCycleDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpMdiSalesDate As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(SalesAdjustments))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtSearchCustomerName = New System.Windows.Forms.TextBox
        Me.HeaderDataGrid = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.CustomerDr = New System.Windows.Forms.DataGridTextBoxColumn
        Me.CustomerCode = New System.Windows.Forms.DataGridTextBoxColumn
        Me.CustomerName = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Address1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Address2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.CustomerTab = New System.Windows.Forms.TabPage
        Me.GroupBox34 = New System.Windows.Forms.GroupBox
        Me.txtIslandGroup = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtGroup = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtGroupDr = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtProvince = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtProvinceDr = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtTerritory = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtTerritoryDr = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox32 = New System.Windows.Forms.GroupBox
        Me.txtShipAddress2 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtShipAddress1 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtShipTo = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox33 = New System.Windows.Forms.GroupBox
        Me.CustomerLinkLabel = New System.Windows.Forms.LinkLabel
        Me.txtCustomerType = New System.Windows.Forms.TextBox
        Me.Label61 = New System.Windows.Forms.Label
        Me.txtAddress2 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtAddress1 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCustomerName = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCustomerCode = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCustomerDr = New System.Windows.Forms.TextBox
        Me.GroupBox31 = New System.Windows.Forms.GroupBox
        Me.txtRowid = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.InvoiceTab = New System.Windows.Forms.TabPage
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.txtSoDate = New System.Windows.Forms.TextBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.txtSoCode = New System.Windows.Forms.TextBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.txtOldCmRefDate = New System.Windows.Forms.TextBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.txtOldCmRefInvoice = New System.Windows.Forms.TextBox
        Me.Label37 = New System.Windows.Forms.Label
        Me.txtOldCmCode = New System.Windows.Forms.TextBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.txtCmRefItemDesc = New System.Windows.Forms.TextBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.txtCmRefItemCode = New System.Windows.Forms.TextBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.txtCmRefAmount = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.txtCmRefPrice = New System.Windows.Forms.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.txtCmRefQtyFree = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.txtCmRefQtySold = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.txtCmRefDate = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.txtCmRefInvoice = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.txtCmCode = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtInvoiceLine = New System.Windows.Forms.TextBox
        Me.Label60 = New System.Windows.Forms.Label
        Me.txtValueAmount = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.txtTax = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtVat = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtVatCode = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtDiscount = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtDiscRate = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtRefDate = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtRefCode = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.ItemTab = New System.Windows.Forms.TabPage
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.txtCurrentDivision = New System.Windows.Forms.TextBox
        Me.Label59 = New System.Windows.Forms.Label
        Me.txtQtyLoose = New System.Windows.Forms.TextBox
        Me.Label58 = New System.Windows.Forms.Label
        Me.txtQtyConverted = New System.Windows.Forms.TextBox
        Me.Label57 = New System.Windows.Forms.Label
        Me.GroupBox30 = New System.Windows.Forms.GroupBox
        Me.txtExpiryDate = New System.Windows.Forms.TextBox
        Me.Label56 = New System.Windows.Forms.Label
        Me.txtLotNumber = New System.Windows.Forms.TextBox
        Me.Label55 = New System.Windows.Forms.Label
        Me.txtSubDist_Code = New System.Windows.Forms.TextBox
        Me.Label54 = New System.Windows.Forms.Label
        Me.txtDist_Code = New System.Windows.Forms.TextBox
        Me.Label53 = New System.Windows.Forms.Label
        Me.txtOutOfStock = New System.Windows.Forms.TextBox
        Me.Label52 = New System.Windows.Forms.Label
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.txtCreditedAmount = New System.Windows.Forms.TextBox
        Me.Label51 = New System.Windows.Forms.Label
        Me.txtAmountSold = New System.Windows.Forms.TextBox
        Me.Label50 = New System.Windows.Forms.Label
        Me.txtUnitPrice = New System.Windows.Forms.TextBox
        Me.Label49 = New System.Windows.Forms.Label
        Me.txtQtyFree = New System.Windows.Forms.TextBox
        Me.Label48 = New System.Windows.Forms.Label
        Me.txtQtySold = New System.Windows.Forms.TextBox
        Me.Label47 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.ItemLinkLabel = New System.Windows.Forms.LinkLabel
        Me.txtDistributor = New System.Windows.Forms.TextBox
        Me.Label46 = New System.Windows.Forms.Label
        Me.txtCompany = New System.Windows.Forms.TextBox
        Me.Label45 = New System.Windows.Forms.Label
        Me.txtDivisionDesc = New System.Windows.Forms.TextBox
        Me.Label44 = New System.Windows.Forms.Label
        Me.txtDivisionCode = New System.Windows.Forms.TextBox
        Me.Label43 = New System.Windows.Forms.Label
        Me.txtPrincipalDesc = New System.Windows.Forms.TextBox
        Me.Label42 = New System.Windows.Forms.Label
        Me.txtPrincipalCode = New System.Windows.Forms.TextBox
        Me.Label41 = New System.Windows.Forms.Label
        Me.txtItemDesc = New System.Windows.Forms.TextBox
        Me.Label40 = New System.Windows.Forms.Label
        Me.txtItemCode = New System.Windows.Forms.TextBox
        Me.Misc = New System.Windows.Forms.TabPage
        Me.GroupBox24 = New System.Windows.Forms.GroupBox
        Me.txtUpdateDate = New System.Windows.Forms.TextBox
        Me.Label89 = New System.Windows.Forms.Label
        Me.txtCreateDate = New System.Windows.Forms.TextBox
        Me.Label88 = New System.Windows.Forms.Label
        Me.txtCreate_Date = New System.Windows.Forms.TextBox
        Me.Label86 = New System.Windows.Forms.Label
        Me.GroupBox11 = New System.Windows.Forms.GroupBox
        Me.txtNavTag = New System.Windows.Forms.TextBox
        Me.Label92 = New System.Windows.Forms.Label
        Me.txtMdsDr = New System.Windows.Forms.TextBox
        Me.Label91 = New System.Windows.Forms.Label
        Me.txtExcludeAttachment = New System.Windows.Forms.TextBox
        Me.Label90 = New System.Windows.Forms.Label
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.txtSalesClass = New System.Windows.Forms.TextBox
        Me.Label85 = New System.Windows.Forms.Label
        Me.txtExcessSales = New System.Windows.Forms.TextBox
        Me.Label84 = New System.Windows.Forms.Label
        Me.txtSubSaleType = New System.Windows.Forms.TextBox
        Me.Label83 = New System.Windows.Forms.Label
        Me.txtTransactionType = New System.Windows.Forms.TextBox
        Me.Label82 = New System.Windows.Forms.Label
        Me.txtSaleType = New System.Windows.Forms.TextBox
        Me.Label81 = New System.Windows.Forms.Label
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.txtMdiSalesDate = New System.Windows.Forms.TextBox
        Me.Label87 = New System.Windows.Forms.Label
        Me.txtMdiCycleDate = New System.Windows.Forms.TextBox
        Me.Label80 = New System.Windows.Forms.Label
        Me.txtSalesCycleDate = New System.Windows.Forms.TextBox
        Me.Label79 = New System.Windows.Forms.Label
        Me.txtCommissionDate = New System.Windows.Forms.TextBox
        Me.Label76 = New System.Windows.Forms.Label
        Me.Crediting = New System.Windows.Forms.TabPage
        Me.GroupBox17 = New System.Windows.Forms.GroupBox
        Me.txtQpiAreaCode = New System.Windows.Forms.TextBox
        Me.Label73 = New System.Windows.Forms.Label
        Me.GroupBox16 = New System.Windows.Forms.GroupBox
        Me.txtFloaterMrName = New System.Windows.Forms.TextBox
        Me.Label78 = New System.Windows.Forms.Label
        Me.txtFloaterMrCode = New System.Windows.Forms.TextBox
        Me.Label77 = New System.Windows.Forms.Label
        Me.GroupBox15 = New System.Windows.Forms.GroupBox
        Me.txtModTradeDsmName = New System.Windows.Forms.TextBox
        Me.Label75 = New System.Windows.Forms.Label
        Me.txtModTradeDsmCode = New System.Windows.Forms.TextBox
        Me.Label74 = New System.Windows.Forms.Label
        Me.GroupBox14 = New System.Windows.Forms.GroupBox
        Me.txtKasGovName = New System.Windows.Forms.TextBox
        Me.Label72 = New System.Windows.Forms.Label
        Me.txtKasGovCode = New System.Windows.Forms.TextBox
        Me.Label71 = New System.Windows.Forms.Label
        Me.GroupBox13 = New System.Windows.Forms.GroupBox
        Me.txtPmName = New System.Windows.Forms.TextBox
        Me.Label70 = New System.Windows.Forms.Label
        Me.txtPmCode = New System.Windows.Forms.TextBox
        Me.Label69 = New System.Windows.Forms.Label
        Me.GroupBox12 = New System.Windows.Forms.GroupBox
        Me.txtNsmName = New System.Windows.Forms.TextBox
        Me.Label68 = New System.Windows.Forms.Label
        Me.txtNsmCode = New System.Windows.Forms.TextBox
        Me.Label67 = New System.Windows.Forms.Label
        Me.txtSupName = New System.Windows.Forms.TextBox
        Me.Label66 = New System.Windows.Forms.Label
        Me.txtSupCode = New System.Windows.Forms.TextBox
        Me.Label65 = New System.Windows.Forms.Label
        Me.txtMrName = New System.Windows.Forms.TextBox
        Me.Label64 = New System.Windows.Forms.Label
        Me.txtMrCode = New System.Windows.Forms.TextBox
        Me.Label63 = New System.Windows.Forms.Label
        Me.txtMrDivision = New System.Windows.Forms.TextBox
        Me.Label62 = New System.Windows.Forms.Label
        Me.Filter = New System.Windows.Forms.TabPage
        Me.GroupBox18 = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.InvoiceDataGrid = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.RefCode = New System.Windows.Forms.DataGridTextBoxColumn
        Me.RefDate = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.LineItemDataGrid = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle3 = New System.Windows.Forms.DataGridTableStyle
        Me.Rowid = New System.Windows.Forms.DataGridTextBoxColumn
        Me.ItemCode = New System.Windows.Forms.DataGridTextBoxColumn
        Me.ItemDesc = New System.Windows.Forms.DataGridTextBoxColumn
        Me.QtySold = New System.Windows.Forms.DataGridTextBoxColumn
        Me.QtyFree = New System.Windows.Forms.DataGridTextBoxColumn
        Me.UnitPrice = New System.Windows.Forms.DataGridTextBoxColumn
        Me.CreditedAmount = New System.Windows.Forms.DataGridTextBoxColumn
        Me.InvoiceLine = New System.Windows.Forms.DataGridTextBoxColumn
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.ToolBarButtonSearch = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButtonEdit = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButtonUndo = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButtonSave = New System.Windows.Forms.ToolBarButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.dtpCommissionDate = New System.Windows.Forms.DateTimePicker
        Me.dtpSalesCycleDate = New System.Windows.Forms.DateTimePicker
        Me.dtpMdiCycleDate = New System.Windows.Forms.DateTimePicker
        Me.dtpMdiSalesDate = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1.SuspendLayout()
        CType(Me.HeaderDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.CustomerTab.SuspendLayout()
        Me.GroupBox34.SuspendLayout()
        Me.GroupBox32.SuspendLayout()
        Me.GroupBox33.SuspendLayout()
        Me.GroupBox31.SuspendLayout()
        Me.InvoiceTab.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.ItemTab.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox30.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.Misc.SuspendLayout()
        Me.GroupBox24.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.Crediting.SuspendLayout()
        Me.GroupBox17.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.Filter.SuspendLayout()
        Me.GroupBox18.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.InvoiceDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.LineItemDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSearchCustomerName)
        Me.GroupBox1.Controls.Add(Me.HeaderDataGrid)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(912, 328)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer"
        '
        'txtSearchCustomerName
        '
        Me.txtSearchCustomerName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSearchCustomerName.Location = New System.Drawing.Point(8, 24)
        Me.txtSearchCustomerName.Name = "txtSearchCustomerName"
        Me.txtSearchCustomerName.Size = New System.Drawing.Size(896, 20)
        Me.txtSearchCustomerName.TabIndex = 4
        Me.txtSearchCustomerName.Text = ""
        '
        'HeaderDataGrid
        '
        Me.HeaderDataGrid.DataMember = ""
        Me.HeaderDataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.HeaderDataGrid.Location = New System.Drawing.Point(8, 48)
        Me.HeaderDataGrid.Name = "HeaderDataGrid"
        Me.HeaderDataGrid.SelectionBackColor = System.Drawing.Color.Bisque
        Me.HeaderDataGrid.SelectionForeColor = System.Drawing.Color.DimGray
        Me.HeaderDataGrid.Size = New System.Drawing.Size(896, 272)
        Me.HeaderDataGrid.TabIndex = 0
        Me.HeaderDataGrid.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.LightSkyBlue
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle1.DataGrid = Me.HeaderDataGrid
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.CustomerDr, Me.CustomerCode, Me.CustomerName, Me.Address1, Me.Address2})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = ""
        Me.DataGridTableStyle1.ReadOnly = True
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.Bisque
        Me.DataGridTableStyle1.SelectionForeColor = System.Drawing.Color.DimGray
        '
        'CustomerDr
        '
        Me.CustomerDr.Format = ""
        Me.CustomerDr.FormatInfo = Nothing
        Me.CustomerDr.MappingName = "CustomerDr"
        Me.CustomerDr.NullText = ""
        Me.CustomerDr.Width = 0
        '
        'CustomerCode
        '
        Me.CustomerCode.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.CustomerCode.Format = ""
        Me.CustomerCode.FormatInfo = Nothing
        Me.CustomerCode.HeaderText = "Code"
        Me.CustomerCode.MappingName = "CustomerCode"
        Me.CustomerCode.NullText = ""
        Me.CustomerCode.Width = 80
        '
        'CustomerName
        '
        Me.CustomerName.Format = ""
        Me.CustomerName.FormatInfo = Nothing
        Me.CustomerName.HeaderText = "Name"
        Me.CustomerName.MappingName = "CustomerName"
        Me.CustomerName.NullText = ""
        Me.CustomerName.ReadOnly = True
        Me.CustomerName.Width = 305
        '
        'Address1
        '
        Me.Address1.Format = ""
        Me.Address1.FormatInfo = Nothing
        Me.Address1.HeaderText = "Address 1"
        Me.Address1.MappingName = "Address1"
        Me.Address1.NullText = ""
        Me.Address1.Width = 228
        '
        'Address2
        '
        Me.Address2.Format = ""
        Me.Address2.FormatInfo = Nothing
        Me.Address2.HeaderText = "Address 2"
        Me.Address2.MappingName = "Address2"
        Me.Address2.NullText = ""
        Me.Address2.Width = 228
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.CustomerTab)
        Me.TabControl1.Controls.Add(Me.InvoiceTab)
        Me.TabControl1.Controls.Add(Me.ItemTab)
        Me.TabControl1.Controls.Add(Me.Misc)
        Me.TabControl1.Controls.Add(Me.Crediting)
        Me.TabControl1.Controls.Add(Me.Filter)
        Me.TabControl1.Location = New System.Drawing.Point(928, 16)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(424, 672)
        Me.TabControl1.TabIndex = 1
        '
        'CustomerTab
        '
        Me.CustomerTab.Controls.Add(Me.GroupBox34)
        Me.CustomerTab.Controls.Add(Me.GroupBox32)
        Me.CustomerTab.Controls.Add(Me.GroupBox33)
        Me.CustomerTab.Controls.Add(Me.GroupBox31)
        Me.CustomerTab.Location = New System.Drawing.Point(4, 22)
        Me.CustomerTab.Name = "CustomerTab"
        Me.CustomerTab.Size = New System.Drawing.Size(416, 646)
        Me.CustomerTab.TabIndex = 0
        Me.CustomerTab.Text = "Customer"
        '
        'GroupBox34
        '
        Me.GroupBox34.Controls.Add(Me.txtIslandGroup)
        Me.GroupBox34.Controls.Add(Me.Label16)
        Me.GroupBox34.Controls.Add(Me.txtGroup)
        Me.GroupBox34.Controls.Add(Me.Label15)
        Me.GroupBox34.Controls.Add(Me.txtGroupDr)
        Me.GroupBox34.Controls.Add(Me.Label14)
        Me.GroupBox34.Controls.Add(Me.txtProvince)
        Me.GroupBox34.Controls.Add(Me.Label13)
        Me.GroupBox34.Controls.Add(Me.txtProvinceDr)
        Me.GroupBox34.Controls.Add(Me.Label12)
        Me.GroupBox34.Controls.Add(Me.txtTerritory)
        Me.GroupBox34.Controls.Add(Me.Label11)
        Me.GroupBox34.Controls.Add(Me.txtTerritoryDr)
        Me.GroupBox34.Controls.Add(Me.Label10)
        Me.GroupBox34.Location = New System.Drawing.Point(8, 416)
        Me.GroupBox34.Name = "GroupBox34"
        Me.GroupBox34.Size = New System.Drawing.Size(400, 192)
        Me.GroupBox34.TabIndex = 41
        Me.GroupBox34.TabStop = False
        Me.GroupBox34.Text = "Territory"
        '
        'txtIslandGroup
        '
        Me.txtIslandGroup.BackColor = System.Drawing.Color.SkyBlue
        Me.txtIslandGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIslandGroup.Location = New System.Drawing.Point(132, 160)
        Me.txtIslandGroup.Name = "txtIslandGroup"
        Me.txtIslandGroup.Size = New System.Drawing.Size(256, 20)
        Me.txtIslandGroup.TabIndex = 74
        Me.txtIslandGroup.Text = ""
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.SkyBlue
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Location = New System.Drawing.Point(8, 160)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(120, 19)
        Me.Label16.TabIndex = 73
        Me.Label16.Text = "IslandGroup"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGroup
        '
        Me.txtGroup.BackColor = System.Drawing.Color.SkyBlue
        Me.txtGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroup.Location = New System.Drawing.Point(132, 136)
        Me.txtGroup.Name = "txtGroup"
        Me.txtGroup.Size = New System.Drawing.Size(256, 20)
        Me.txtGroup.TabIndex = 72
        Me.txtGroup.Text = ""
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.SkyBlue
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Location = New System.Drawing.Point(8, 136)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(120, 19)
        Me.Label15.TabIndex = 71
        Me.Label15.Text = "Group"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGroupDr
        '
        Me.txtGroupDr.BackColor = System.Drawing.Color.SkyBlue
        Me.txtGroupDr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupDr.Location = New System.Drawing.Point(132, 112)
        Me.txtGroupDr.Name = "txtGroupDr"
        Me.txtGroupDr.Size = New System.Drawing.Size(256, 20)
        Me.txtGroupDr.TabIndex = 70
        Me.txtGroupDr.Text = ""
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.SkyBlue
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Location = New System.Drawing.Point(8, 112)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(120, 19)
        Me.Label14.TabIndex = 69
        Me.Label14.Text = "GroupDr"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtProvince
        '
        Me.txtProvince.BackColor = System.Drawing.Color.SkyBlue
        Me.txtProvince.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvince.Location = New System.Drawing.Point(132, 88)
        Me.txtProvince.Name = "txtProvince"
        Me.txtProvince.Size = New System.Drawing.Size(256, 20)
        Me.txtProvince.TabIndex = 68
        Me.txtProvince.Text = ""
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.SkyBlue
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Location = New System.Drawing.Point(8, 88)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 19)
        Me.Label13.TabIndex = 67
        Me.Label13.Text = "Province"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtProvinceDr
        '
        Me.txtProvinceDr.BackColor = System.Drawing.Color.SkyBlue
        Me.txtProvinceDr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvinceDr.Location = New System.Drawing.Point(132, 64)
        Me.txtProvinceDr.Name = "txtProvinceDr"
        Me.txtProvinceDr.Size = New System.Drawing.Size(256, 20)
        Me.txtProvinceDr.TabIndex = 66
        Me.txtProvinceDr.Text = ""
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.SkyBlue
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Location = New System.Drawing.Point(8, 64)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 19)
        Me.Label12.TabIndex = 65
        Me.Label12.Text = "ProvinceDr"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTerritory
        '
        Me.txtTerritory.BackColor = System.Drawing.Color.SkyBlue
        Me.txtTerritory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTerritory.Location = New System.Drawing.Point(132, 40)
        Me.txtTerritory.Name = "txtTerritory"
        Me.txtTerritory.Size = New System.Drawing.Size(256, 20)
        Me.txtTerritory.TabIndex = 64
        Me.txtTerritory.Text = ""
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.SkyBlue
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Location = New System.Drawing.Point(8, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 19)
        Me.Label11.TabIndex = 63
        Me.Label11.Text = "Territory"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTerritoryDr
        '
        Me.txtTerritoryDr.BackColor = System.Drawing.Color.SkyBlue
        Me.txtTerritoryDr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTerritoryDr.Location = New System.Drawing.Point(132, 16)
        Me.txtTerritoryDr.Name = "txtTerritoryDr"
        Me.txtTerritoryDr.Size = New System.Drawing.Size(256, 20)
        Me.txtTerritoryDr.TabIndex = 62
        Me.txtTerritoryDr.Text = ""
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.SkyBlue
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Location = New System.Drawing.Point(8, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 19)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "TerritoryDr"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox32
        '
        Me.GroupBox32.Controls.Add(Me.txtShipAddress2)
        Me.GroupBox32.Controls.Add(Me.Label9)
        Me.GroupBox32.Controls.Add(Me.txtShipAddress1)
        Me.GroupBox32.Controls.Add(Me.Label8)
        Me.GroupBox32.Controls.Add(Me.txtShipTo)
        Me.GroupBox32.Controls.Add(Me.Label7)
        Me.GroupBox32.Location = New System.Drawing.Point(8, 272)
        Me.GroupBox32.Name = "GroupBox32"
        Me.GroupBox32.Size = New System.Drawing.Size(400, 136)
        Me.GroupBox32.TabIndex = 40
        Me.GroupBox32.TabStop = False
        Me.GroupBox32.Text = "Shipping"
        '
        'txtShipAddress2
        '
        Me.txtShipAddress2.BackColor = System.Drawing.Color.SkyBlue
        Me.txtShipAddress2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShipAddress2.Location = New System.Drawing.Point(132, 84)
        Me.txtShipAddress2.Multiline = True
        Me.txtShipAddress2.Name = "txtShipAddress2"
        Me.txtShipAddress2.Size = New System.Drawing.Size(256, 40)
        Me.txtShipAddress2.TabIndex = 51
        Me.txtShipAddress2.Text = ""
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.SkyBlue
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Location = New System.Drawing.Point(8, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 19)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "ShipAddress2"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShipAddress1
        '
        Me.txtShipAddress1.BackColor = System.Drawing.Color.SkyBlue
        Me.txtShipAddress1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShipAddress1.Location = New System.Drawing.Point(132, 40)
        Me.txtShipAddress1.Multiline = True
        Me.txtShipAddress1.Name = "txtShipAddress1"
        Me.txtShipAddress1.Size = New System.Drawing.Size(256, 40)
        Me.txtShipAddress1.TabIndex = 49
        Me.txtShipAddress1.Text = ""
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.SkyBlue
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(8, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 19)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "ShipAddress1"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShipTo
        '
        Me.txtShipTo.BackColor = System.Drawing.Color.SkyBlue
        Me.txtShipTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShipTo.Location = New System.Drawing.Point(132, 16)
        Me.txtShipTo.Name = "txtShipTo"
        Me.txtShipTo.Size = New System.Drawing.Size(256, 20)
        Me.txtShipTo.TabIndex = 47
        Me.txtShipTo.Text = ""
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.SkyBlue
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(8, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 19)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "ShipTo"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox33
        '
        Me.GroupBox33.Controls.Add(Me.CustomerLinkLabel)
        Me.GroupBox33.Controls.Add(Me.txtCustomerType)
        Me.GroupBox33.Controls.Add(Me.Label61)
        Me.GroupBox33.Controls.Add(Me.txtAddress2)
        Me.GroupBox33.Controls.Add(Me.Label6)
        Me.GroupBox33.Controls.Add(Me.txtAddress1)
        Me.GroupBox33.Controls.Add(Me.Label5)
        Me.GroupBox33.Controls.Add(Me.txtCustomerName)
        Me.GroupBox33.Controls.Add(Me.Label4)
        Me.GroupBox33.Controls.Add(Me.txtCustomerCode)
        Me.GroupBox33.Controls.Add(Me.Label3)
        Me.GroupBox33.Controls.Add(Me.txtCustomerDr)
        Me.GroupBox33.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox33.Name = "GroupBox33"
        Me.GroupBox33.Size = New System.Drawing.Size(400, 206)
        Me.GroupBox33.TabIndex = 39
        Me.GroupBox33.TabStop = False
        Me.GroupBox33.Text = "Customer Info"
        '
        'CustomerLinkLabel
        '
        Me.CustomerLinkLabel.BackColor = System.Drawing.Color.SkyBlue
        Me.CustomerLinkLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomerLinkLabel.Location = New System.Drawing.Point(8, 16)
        Me.CustomerLinkLabel.Name = "CustomerLinkLabel"
        Me.CustomerLinkLabel.Size = New System.Drawing.Size(120, 20)
        Me.CustomerLinkLabel.TabIndex = 48
        Me.CustomerLinkLabel.TabStop = True
        Me.CustomerLinkLabel.Text = "CustomerDr"
        Me.CustomerLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCustomerType
        '
        Me.txtCustomerType.BackColor = System.Drawing.Color.SkyBlue
        Me.txtCustomerType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerType.Location = New System.Drawing.Point(132, 176)
        Me.txtCustomerType.Name = "txtCustomerType"
        Me.txtCustomerType.Size = New System.Drawing.Size(256, 20)
        Me.txtCustomerType.TabIndex = 47
        Me.txtCustomerType.Text = ""
        '
        'Label61
        '
        Me.Label61.BackColor = System.Drawing.Color.SkyBlue
        Me.Label61.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label61.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label61.Location = New System.Drawing.Point(8, 176)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(120, 19)
        Me.Label61.TabIndex = 46
        Me.Label61.Text = "CustomerType"
        Me.Label61.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAddress2
        '
        Me.txtAddress2.BackColor = System.Drawing.Color.SkyBlue
        Me.txtAddress2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress2.Location = New System.Drawing.Point(132, 132)
        Me.txtAddress2.Multiline = True
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(256, 40)
        Me.txtAddress2.TabIndex = 45
        Me.txtAddress2.Text = ""
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.SkyBlue
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Location = New System.Drawing.Point(8, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 19)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Address2"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAddress1
        '
        Me.txtAddress1.BackColor = System.Drawing.Color.SkyBlue
        Me.txtAddress1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress1.Location = New System.Drawing.Point(132, 88)
        Me.txtAddress1.Multiline = True
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(256, 40)
        Me.txtAddress1.TabIndex = 43
        Me.txtAddress1.Text = ""
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.SkyBlue
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Location = New System.Drawing.Point(8, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 19)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Address1"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCustomerName
        '
        Me.txtCustomerName.BackColor = System.Drawing.Color.SkyBlue
        Me.txtCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(132, 64)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(256, 20)
        Me.txtCustomerName.TabIndex = 41
        Me.txtCustomerName.Text = ""
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SkyBlue
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(8, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 19)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "CustomerName"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCustomerCode
        '
        Me.txtCustomerCode.BackColor = System.Drawing.Color.SkyBlue
        Me.txtCustomerCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerCode.Location = New System.Drawing.Point(132, 40)
        Me.txtCustomerCode.Name = "txtCustomerCode"
        Me.txtCustomerCode.Size = New System.Drawing.Size(256, 20)
        Me.txtCustomerCode.TabIndex = 39
        Me.txtCustomerCode.Text = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SkyBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(8, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 20)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "CustomerCode"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCustomerDr
        '
        Me.txtCustomerDr.BackColor = System.Drawing.Color.SkyBlue
        Me.txtCustomerDr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerDr.Location = New System.Drawing.Point(132, 16)
        Me.txtCustomerDr.Name = "txtCustomerDr"
        Me.txtCustomerDr.Size = New System.Drawing.Size(256, 20)
        Me.txtCustomerDr.TabIndex = 37
        Me.txtCustomerDr.Text = ""
        '
        'GroupBox31
        '
        Me.GroupBox31.Controls.Add(Me.txtRowid)
        Me.GroupBox31.Controls.Add(Me.Label1)
        Me.GroupBox31.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox31.Name = "GroupBox31"
        Me.GroupBox31.Size = New System.Drawing.Size(400, 40)
        Me.GroupBox31.TabIndex = 34
        Me.GroupBox31.TabStop = False
        Me.GroupBox31.Text = "Row Identfier"
        '
        'txtRowid
        '
        Me.txtRowid.BackColor = System.Drawing.Color.SkyBlue
        Me.txtRowid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRowid.Location = New System.Drawing.Point(132, 14)
        Me.txtRowid.Name = "txtRowid"
        Me.txtRowid.Size = New System.Drawing.Size(256, 20)
        Me.txtRowid.TabIndex = 3
        Me.txtRowid.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SkyBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(8, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Rowid"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'InvoiceTab
        '
        Me.InvoiceTab.Controls.Add(Me.GroupBox5)
        Me.InvoiceTab.Controls.Add(Me.GroupBox4)
        Me.InvoiceTab.Location = New System.Drawing.Point(4, 22)
        Me.InvoiceTab.Name = "InvoiceTab"
        Me.InvoiceTab.Size = New System.Drawing.Size(416, 646)
        Me.InvoiceTab.TabIndex = 1
        Me.InvoiceTab.Text = "Invoice"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtSoDate)
        Me.GroupBox5.Controls.Add(Me.Label35)
        Me.GroupBox5.Controls.Add(Me.txtSoCode)
        Me.GroupBox5.Controls.Add(Me.Label34)
        Me.GroupBox5.Controls.Add(Me.txtOldCmRefDate)
        Me.GroupBox5.Controls.Add(Me.Label38)
        Me.GroupBox5.Controls.Add(Me.txtOldCmRefInvoice)
        Me.GroupBox5.Controls.Add(Me.Label37)
        Me.GroupBox5.Controls.Add(Me.txtOldCmCode)
        Me.GroupBox5.Controls.Add(Me.Label36)
        Me.GroupBox5.Controls.Add(Me.txtCmRefItemDesc)
        Me.GroupBox5.Controls.Add(Me.Label33)
        Me.GroupBox5.Controls.Add(Me.txtCmRefItemCode)
        Me.GroupBox5.Controls.Add(Me.Label32)
        Me.GroupBox5.Controls.Add(Me.txtCmRefAmount)
        Me.GroupBox5.Controls.Add(Me.Label31)
        Me.GroupBox5.Controls.Add(Me.txtCmRefPrice)
        Me.GroupBox5.Controls.Add(Me.Label30)
        Me.GroupBox5.Controls.Add(Me.txtCmRefQtyFree)
        Me.GroupBox5.Controls.Add(Me.Label29)
        Me.GroupBox5.Controls.Add(Me.txtCmRefQtySold)
        Me.GroupBox5.Controls.Add(Me.Label28)
        Me.GroupBox5.Controls.Add(Me.txtCmRefDate)
        Me.GroupBox5.Controls.Add(Me.Label27)
        Me.GroupBox5.Controls.Add(Me.txtCmRefInvoice)
        Me.GroupBox5.Controls.Add(Me.Label26)
        Me.GroupBox5.Controls.Add(Me.txtCmCode)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 248)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(400, 376)
        Me.GroupBox5.TabIndex = 53
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "CM info"
        '
        'txtSoDate
        '
        Me.txtSoDate.BackColor = System.Drawing.Color.SkyBlue
        Me.txtSoDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSoDate.Location = New System.Drawing.Point(132, 344)
        Me.txtSoDate.Name = "txtSoDate"
        Me.txtSoDate.Size = New System.Drawing.Size(256, 20)
        Me.txtSoDate.TabIndex = 103
        Me.txtSoDate.Text = ""
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.SkyBlue
        Me.Label35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label35.Location = New System.Drawing.Point(8, 344)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(120, 20)
        Me.Label35.TabIndex = 102
        Me.Label35.Text = "SoDate"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSoCode
        '
        Me.txtSoCode.BackColor = System.Drawing.Color.SkyBlue
        Me.txtSoCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSoCode.Location = New System.Drawing.Point(132, 320)
        Me.txtSoCode.Name = "txtSoCode"
        Me.txtSoCode.Size = New System.Drawing.Size(256, 20)
        Me.txtSoCode.TabIndex = 101
        Me.txtSoCode.Text = ""
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.SkyBlue
        Me.Label34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label34.Location = New System.Drawing.Point(8, 320)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(120, 20)
        Me.Label34.TabIndex = 100
        Me.Label34.Text = "SoCode"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOldCmRefDate
        '
        Me.txtOldCmRefDate.BackColor = System.Drawing.Color.SkyBlue
        Me.txtOldCmRefDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldCmRefDate.Location = New System.Drawing.Point(132, 262)
        Me.txtOldCmRefDate.Name = "txtOldCmRefDate"
        Me.txtOldCmRefDate.Size = New System.Drawing.Size(256, 20)
        Me.txtOldCmRefDate.TabIndex = 99
        Me.txtOldCmRefDate.Text = ""
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.Color.SkyBlue
        Me.Label38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label38.Location = New System.Drawing.Point(8, 262)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(120, 20)
        Me.Label38.TabIndex = 98
        Me.Label38.Text = "OldCmRefDate"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOldCmRefInvoice
        '
        Me.txtOldCmRefInvoice.BackColor = System.Drawing.Color.SkyBlue
        Me.txtOldCmRefInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldCmRefInvoice.Location = New System.Drawing.Point(132, 238)
        Me.txtOldCmRefInvoice.Name = "txtOldCmRefInvoice"
        Me.txtOldCmRefInvoice.Size = New System.Drawing.Size(256, 20)
        Me.txtOldCmRefInvoice.TabIndex = 97
        Me.txtOldCmRefInvoice.Text = ""
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.SkyBlue
        Me.Label37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label37.Location = New System.Drawing.Point(8, 238)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(120, 20)
        Me.Label37.TabIndex = 96
        Me.Label37.Text = "OldCmRefInvoice"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOldCmCode
        '
        Me.txtOldCmCode.BackColor = System.Drawing.Color.SkyBlue
        Me.txtOldCmCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldCmCode.Location = New System.Drawing.Point(132, 214)
        Me.txtOldCmCode.Name = "txtOldCmCode"
        Me.txtOldCmCode.Size = New System.Drawing.Size(256, 20)
        Me.txtOldCmCode.TabIndex = 95
        Me.txtOldCmCode.Text = ""
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.SkyBlue
        Me.Label36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label36.Location = New System.Drawing.Point(8, 214)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(120, 20)
        Me.Label36.TabIndex = 94
        Me.Label36.Text = "OldCmCode"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCmRefItemDesc
        '
        Me.txtCmRefItemDesc.BackColor = System.Drawing.Color.SkyBlue
        Me.txtCmRefItemDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCmRefItemDesc.Location = New System.Drawing.Point(132, 190)
        Me.txtCmRefItemDesc.Name = "txtCmRefItemDesc"
        Me.txtCmRefItemDesc.Size = New System.Drawing.Size(256, 20)
        Me.txtCmRefItemDesc.TabIndex = 93
        Me.txtCmRefItemDesc.Text = ""
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.SkyBlue
        Me.Label33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label33.Location = New System.Drawing.Point(8, 190)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(120, 20)
        Me.Label33.TabIndex = 92
        Me.Label33.Text = "CmRefItemDesc"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCmRefItemCode
        '
        Me.txtCmRefItemCode.BackColor = System.Drawing.Color.SkyBlue
        Me.txtCmRefItemCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCmRefItemCode.Location = New System.Drawing.Point(132, 166)
        Me.txtCmRefItemCode.Name = "txtCmRefItemCode"
        Me.txtCmRefItemCode.Size = New System.Drawing.Size(256, 20)
        Me.txtCmRefItemCode.TabIndex = 91
        Me.txtCmRefItemCode.Text = ""
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.SkyBlue
        Me.Label32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label32.Location = New System.Drawing.Point(8, 166)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(120, 20)
        Me.Label32.TabIndex = 90
        Me.Label32.Text = "CmRefItemCode"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCmRefAmount
        '
        Me.txtCmRefAmount.BackColor = System.Drawing.Color.SkyBlue
        Me.txtCmRefAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCmRefAmount.Location = New System.Drawing.Point(132, 142)
        Me.txtCmRefAmount.Name = "txtCmRefAmount"
        Me.txtCmRefAmount.Size = New System.Drawing.Size(256, 20)
        Me.txtCmRefAmount.TabIndex = 89
        Me.txtCmRefAmount.Text = ""
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.SkyBlue
        Me.Label31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label31.Location = New System.Drawing.Point(8, 142)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(120, 20)
        Me.Label31.TabIndex = 88
        Me.Label31.Text = "CmRefAmount"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCmRefPrice
        '
        Me.txtCmRefPrice.BackColor = System.Drawing.Color.SkyBlue
        Me.txtCmRefPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCmRefPrice.Location = New System.Drawing.Point(132, 118)
        Me.txtCmRefPrice.Name = "txtCmRefPrice"
        Me.txtCmRefPrice.Size = New System.Drawing.Size(256, 20)
        Me.txtCmRefPrice.TabIndex = 87
        Me.txtCmRefPrice.Text = ""
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.SkyBlue
        Me.Label30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label30.Location = New System.Drawing.Point(8, 118)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(120, 20)
        Me.Label30.TabIndex = 86
        Me.Label30.Text = "CmRefPrice"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCmRefQtyFree
        '
        Me.txtCmRefQtyFree.BackColor = System.Drawing.Color.SkyBlue
        Me.txtCmRefQtyFree.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCmRefQtyFree.Location = New System.Drawing.Point(132, 94)
        Me.txtCmRefQtyFree.Name = "txtCmRefQtyFree"
        Me.txtCmRefQtyFree.Size = New System.Drawing.Size(256, 20)
        Me.txtCmRefQtyFree.TabIndex = 85
        Me.txtCmRefQtyFree.Text = ""
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.SkyBlue
        Me.Label29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label29.Location = New System.Drawing.Point(8, 94)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(120, 20)
        Me.Label29.TabIndex = 84
        Me.Label29.Text = "CmRefQtyFree"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCmRefQtySold
        '
        Me.txtCmRefQtySold.BackColor = System.Drawing.Color.SkyBlue
        Me.txtCmRefQtySold.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCmRefQtySold.Location = New System.Drawing.Point(132, 70)
        Me.txtCmRefQtySold.Name = "txtCmRefQtySold"
        Me.txtCmRefQtySold.Size = New System.Drawing.Size(256, 20)
        Me.txtCmRefQtySold.TabIndex = 83
        Me.txtCmRefQtySold.Text = ""
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.SkyBlue
        Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label28.Location = New System.Drawing.Point(8, 70)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(120, 20)
        Me.Label28.TabIndex = 82
        Me.Label28.Text = "CmRefQtySold"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCmRefDate
        '
        Me.txtCmRefDate.BackColor = System.Drawing.Color.SkyBlue
        Me.txtCmRefDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCmRefDate.Location = New System.Drawing.Point(132, 46)
        Me.txtCmRefDate.Name = "txtCmRefDate"
        Me.txtCmRefDate.Size = New System.Drawing.Size(256, 20)
        Me.txtCmRefDate.TabIndex = 81
        Me.txtCmRefDate.Text = ""
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.SkyBlue
        Me.Label27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label27.Location = New System.Drawing.Point(8, 46)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(120, 20)
        Me.Label27.TabIndex = 80
        Me.Label27.Text = "CmRefDate"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCmRefInvoice
        '
        Me.txtCmRefInvoice.BackColor = System.Drawing.Color.SkyBlue
        Me.txtCmRefInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCmRefInvoice.Location = New System.Drawing.Point(132, 22)
        Me.txtCmRefInvoice.Name = "txtCmRefInvoice"
        Me.txtCmRefInvoice.Size = New System.Drawing.Size(256, 20)
        Me.txtCmRefInvoice.TabIndex = 79
        Me.txtCmRefInvoice.Text = ""
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.SkyBlue
        Me.Label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label26.Location = New System.Drawing.Point(8, 22)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(120, 20)
        Me.Label26.TabIndex = 78
        Me.Label26.Text = "CmRefInvoice"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCmCode
        '
        Me.txtCmCode.BackColor = System.Drawing.Color.SkyBlue
        Me.txtCmCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCmCode.Location = New System.Drawing.Point(132, 286)
        Me.txtCmCode.Name = "txtCmCode"
        Me.txtCmCode.Size = New System.Drawing.Size(256, 20)
        Me.txtCmCode.TabIndex = 77
        Me.txtCmCode.Text = ""
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SkyBlue
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Location = New System.Drawing.Point(8, 286)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(120, 20)
        Me.Label17.TabIndex = 76
        Me.Label17.Text = "CmCode"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtInvoiceLine)
        Me.GroupBox4.Controls.Add(Me.Label60)
        Me.GroupBox4.Controls.Add(Me.txtValueAmount)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.txtTax)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.txtVat)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.txtVatCode)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.txtDiscount)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.txtDiscRate)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.txtRefDate)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.txtRefCode)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(400, 232)
        Me.GroupBox4.TabIndex = 52
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Invoice Info"
        '
        'txtInvoiceLine
        '
        Me.txtInvoiceLine.BackColor = System.Drawing.Color.SkyBlue
        Me.txtInvoiceLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceLine.Location = New System.Drawing.Point(132, 206)
        Me.txtInvoiceLine.Name = "txtInvoiceLine"
        Me.txtInvoiceLine.Size = New System.Drawing.Size(256, 20)
        Me.txtInvoiceLine.TabIndex = 69
        Me.txtInvoiceLine.Text = ""
        '
        'Label60
        '
        Me.Label60.BackColor = System.Drawing.Color.SkyBlue
        Me.Label60.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label60.Location = New System.Drawing.Point(8, 206)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(120, 20)
        Me.Label60.TabIndex = 68
        Me.Label60.Text = "InvoiceLine"
        Me.Label60.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtValueAmount
        '
        Me.txtValueAmount.BackColor = System.Drawing.Color.SkyBlue
        Me.txtValueAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValueAmount.Location = New System.Drawing.Point(132, 182)
        Me.txtValueAmount.Name = "txtValueAmount"
        Me.txtValueAmount.Size = New System.Drawing.Size(256, 20)
        Me.txtValueAmount.TabIndex = 67
        Me.txtValueAmount.Text = ""
        Me.txtValueAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.SkyBlue
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label25.Location = New System.Drawing.Point(8, 182)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(120, 20)
        Me.Label25.TabIndex = 66
        Me.Label25.Text = "ValueAmount"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTax
        '
        Me.txtTax.BackColor = System.Drawing.Color.SkyBlue
        Me.txtTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTax.Location = New System.Drawing.Point(132, 158)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(256, 20)
        Me.txtTax.TabIndex = 65
        Me.txtTax.Text = ""
        Me.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.SkyBlue
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label24.Location = New System.Drawing.Point(8, 158)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(120, 20)
        Me.Label24.TabIndex = 64
        Me.Label24.Text = "Tax"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtVat
        '
        Me.txtVat.BackColor = System.Drawing.Color.SkyBlue
        Me.txtVat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVat.Location = New System.Drawing.Point(132, 134)
        Me.txtVat.Name = "txtVat"
        Me.txtVat.Size = New System.Drawing.Size(256, 20)
        Me.txtVat.TabIndex = 63
        Me.txtVat.Text = ""
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.SkyBlue
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label23.Location = New System.Drawing.Point(8, 134)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(120, 20)
        Me.Label23.TabIndex = 62
        Me.Label23.Text = "Vat"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtVatCode
        '
        Me.txtVatCode.BackColor = System.Drawing.Color.SkyBlue
        Me.txtVatCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVatCode.Location = New System.Drawing.Point(132, 110)
        Me.txtVatCode.Name = "txtVatCode"
        Me.txtVatCode.Size = New System.Drawing.Size(256, 20)
        Me.txtVatCode.TabIndex = 61
        Me.txtVatCode.Text = ""
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.SkyBlue
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.Location = New System.Drawing.Point(8, 110)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(120, 20)
        Me.Label22.TabIndex = 60
        Me.Label22.Text = "VatCode"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDiscount
        '
        Me.txtDiscount.BackColor = System.Drawing.Color.SkyBlue
        Me.txtDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.Location = New System.Drawing.Point(132, 86)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(256, 20)
        Me.txtDiscount.TabIndex = 59
        Me.txtDiscount.Text = ""
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.SkyBlue
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label21.Location = New System.Drawing.Point(8, 86)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(120, 20)
        Me.Label21.TabIndex = 58
        Me.Label21.Text = "Discount"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDiscRate
        '
        Me.txtDiscRate.BackColor = System.Drawing.Color.SkyBlue
        Me.txtDiscRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscRate.Location = New System.Drawing.Point(132, 62)
        Me.txtDiscRate.Name = "txtDiscRate"
        Me.txtDiscRate.Size = New System.Drawing.Size(256, 20)
        Me.txtDiscRate.TabIndex = 57
        Me.txtDiscRate.Text = ""
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.SkyBlue
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.Location = New System.Drawing.Point(8, 62)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(120, 20)
        Me.Label20.TabIndex = 56
        Me.Label20.Text = "DiscRate"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRefDate
        '
        Me.txtRefDate.BackColor = System.Drawing.Color.SkyBlue
        Me.txtRefDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefDate.Location = New System.Drawing.Point(132, 38)
        Me.txtRefDate.Name = "txtRefDate"
        Me.txtRefDate.Size = New System.Drawing.Size(256, 20)
        Me.txtRefDate.TabIndex = 55
        Me.txtRefDate.Text = ""
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.SkyBlue
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.Location = New System.Drawing.Point(8, 38)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(120, 20)
        Me.Label19.TabIndex = 54
        Me.Label19.Text = "RefDate"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRefCode
        '
        Me.txtRefCode.BackColor = System.Drawing.Color.SkyBlue
        Me.txtRefCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefCode.Location = New System.Drawing.Point(132, 14)
        Me.txtRefCode.Name = "txtRefCode"
        Me.txtRefCode.Size = New System.Drawing.Size(256, 20)
        Me.txtRefCode.TabIndex = 53
        Me.txtRefCode.Text = ""
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.SkyBlue
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.Location = New System.Drawing.Point(8, 14)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(120, 20)
        Me.Label18.TabIndex = 52
        Me.Label18.Text = "RefCode"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ItemTab
        '
        Me.ItemTab.Controls.Add(Me.GroupBox8)
        Me.ItemTab.Controls.Add(Me.GroupBox30)
        Me.ItemTab.Controls.Add(Me.GroupBox7)
        Me.ItemTab.Controls.Add(Me.GroupBox6)
        Me.ItemTab.Location = New System.Drawing.Point(4, 22)
        Me.ItemTab.Name = "ItemTab"
        Me.ItemTab.Size = New System.Drawing.Size(416, 646)
        Me.ItemTab.TabIndex = 2
        Me.ItemTab.Text = "Item"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.txtCurrentDivision)
        Me.GroupBox8.Controls.Add(Me.Label59)
        Me.GroupBox8.Controls.Add(Me.txtQtyLoose)
        Me.GroupBox8.Controls.Add(Me.Label58)
        Me.GroupBox8.Controls.Add(Me.txtQtyConverted)
        Me.GroupBox8.Controls.Add(Me.Label57)
        Me.GroupBox8.Location = New System.Drawing.Point(8, 520)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(400, 96)
        Me.GroupBox8.TabIndex = 25
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Others"
        '
        'txtCurrentDivision
        '
        Me.txtCurrentDivision.BackColor = System.Drawing.Color.SkyBlue
        Me.txtCurrentDivision.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentDivision.Location = New System.Drawing.Point(132, 66)
        Me.txtCurrentDivision.Name = "txtCurrentDivision"
        Me.txtCurrentDivision.Size = New System.Drawing.Size(256, 20)
        Me.txtCurrentDivision.TabIndex = 84
        Me.txtCurrentDivision.Text = ""
        '
        'Label59
        '
        Me.Label59.BackColor = System.Drawing.Color.SkyBlue
        Me.Label59.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label59.Location = New System.Drawing.Point(8, 66)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(120, 20)
        Me.Label59.TabIndex = 83
        Me.Label59.Text = "CurrentDivision"
        Me.Label59.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtQtyLoose
        '
        Me.txtQtyLoose.BackColor = System.Drawing.Color.SkyBlue
        Me.txtQtyLoose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtyLoose.Location = New System.Drawing.Point(132, 42)
        Me.txtQtyLoose.Name = "txtQtyLoose"
        Me.txtQtyLoose.Size = New System.Drawing.Size(256, 20)
        Me.txtQtyLoose.TabIndex = 82
        Me.txtQtyLoose.Text = ""
        '
        'Label58
        '
        Me.Label58.BackColor = System.Drawing.Color.SkyBlue
        Me.Label58.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label58.Location = New System.Drawing.Point(8, 42)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(120, 20)
        Me.Label58.TabIndex = 81
        Me.Label58.Text = "QtyLoose"
        Me.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtQtyConverted
        '
        Me.txtQtyConverted.BackColor = System.Drawing.Color.SkyBlue
        Me.txtQtyConverted.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtyConverted.Location = New System.Drawing.Point(132, 18)
        Me.txtQtyConverted.Name = "txtQtyConverted"
        Me.txtQtyConverted.Size = New System.Drawing.Size(256, 20)
        Me.txtQtyConverted.TabIndex = 80
        Me.txtQtyConverted.Text = ""
        '
        'Label57
        '
        Me.Label57.BackColor = System.Drawing.Color.SkyBlue
        Me.Label57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label57.Location = New System.Drawing.Point(8, 18)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(120, 20)
        Me.Label57.TabIndex = 79
        Me.Label57.Text = "QtyConverted"
        Me.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox30
        '
        Me.GroupBox30.Controls.Add(Me.txtExpiryDate)
        Me.GroupBox30.Controls.Add(Me.Label56)
        Me.GroupBox30.Controls.Add(Me.txtLotNumber)
        Me.GroupBox30.Controls.Add(Me.Label55)
        Me.GroupBox30.Controls.Add(Me.txtSubDist_Code)
        Me.GroupBox30.Controls.Add(Me.Label54)
        Me.GroupBox30.Controls.Add(Me.txtDist_Code)
        Me.GroupBox30.Controls.Add(Me.Label53)
        Me.GroupBox30.Controls.Add(Me.txtOutOfStock)
        Me.GroupBox30.Controls.Add(Me.Label52)
        Me.GroupBox30.Location = New System.Drawing.Point(8, 368)
        Me.GroupBox30.Name = "GroupBox30"
        Me.GroupBox30.Size = New System.Drawing.Size(400, 144)
        Me.GroupBox30.TabIndex = 24
        Me.GroupBox30.TabStop = False
        Me.GroupBox30.Text = "Lot/Expiry"
        '
        'txtExpiryDate
        '
        Me.txtExpiryDate.BackColor = System.Drawing.Color.SkyBlue
        Me.txtExpiryDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpiryDate.Location = New System.Drawing.Point(132, 112)
        Me.txtExpiryDate.Name = "txtExpiryDate"
        Me.txtExpiryDate.Size = New System.Drawing.Size(256, 20)
        Me.txtExpiryDate.TabIndex = 82
        Me.txtExpiryDate.Text = ""
        '
        'Label56
        '
        Me.Label56.BackColor = System.Drawing.Color.SkyBlue
        Me.Label56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label56.Location = New System.Drawing.Point(8, 112)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(120, 20)
        Me.Label56.TabIndex = 81
        Me.Label56.Text = "ExpiryDate"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLotNumber
        '
        Me.txtLotNumber.BackColor = System.Drawing.Color.SkyBlue
        Me.txtLotNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLotNumber.Location = New System.Drawing.Point(132, 88)
        Me.txtLotNumber.Name = "txtLotNumber"
        Me.txtLotNumber.Size = New System.Drawing.Size(256, 20)
        Me.txtLotNumber.TabIndex = 80
        Me.txtLotNumber.Text = ""
        '
        'Label55
        '
        Me.Label55.BackColor = System.Drawing.Color.SkyBlue
        Me.Label55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label55.Location = New System.Drawing.Point(8, 88)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(120, 20)
        Me.Label55.TabIndex = 79
        Me.Label55.Text = "LotNumber"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSubDist_Code
        '
        Me.txtSubDist_Code.BackColor = System.Drawing.Color.SkyBlue
        Me.txtSubDist_Code.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubDist_Code.Location = New System.Drawing.Point(132, 64)
        Me.txtSubDist_Code.Name = "txtSubDist_Code"
        Me.txtSubDist_Code.Size = New System.Drawing.Size(256, 20)
        Me.txtSubDist_Code.TabIndex = 78
        Me.txtSubDist_Code.Text = ""
        '
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.Color.SkyBlue
        Me.Label54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label54.Location = New System.Drawing.Point(8, 64)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(120, 20)
        Me.Label54.TabIndex = 77
        Me.Label54.Text = "SubDist_Code"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDist_Code
        '
        Me.txtDist_Code.BackColor = System.Drawing.Color.SkyBlue
        Me.txtDist_Code.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDist_Code.Location = New System.Drawing.Point(132, 40)
        Me.txtDist_Code.Name = "txtDist_Code"
        Me.txtDist_Code.Size = New System.Drawing.Size(256, 20)
        Me.txtDist_Code.TabIndex = 76
        Me.txtDist_Code.Text = ""
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.Color.SkyBlue
        Me.Label53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label53.Location = New System.Drawing.Point(8, 40)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(120, 20)
        Me.Label53.TabIndex = 75
        Me.Label53.Text = "Dist_Code"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOutOfStock
        '
        Me.txtOutOfStock.BackColor = System.Drawing.Color.SkyBlue
        Me.txtOutOfStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutOfStock.Location = New System.Drawing.Point(132, 16)
        Me.txtOutOfStock.Name = "txtOutOfStock"
        Me.txtOutOfStock.Size = New System.Drawing.Size(256, 20)
        Me.txtOutOfStock.TabIndex = 74
        Me.txtOutOfStock.Text = ""
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.Color.SkyBlue
        Me.Label52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label52.Location = New System.Drawing.Point(8, 16)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(120, 20)
        Me.Label52.TabIndex = 73
        Me.Label52.Text = "OutOfStock"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txtCreditedAmount)
        Me.GroupBox7.Controls.Add(Me.Label51)
        Me.GroupBox7.Controls.Add(Me.txtAmountSold)
        Me.GroupBox7.Controls.Add(Me.Label50)
        Me.GroupBox7.Controls.Add(Me.txtUnitPrice)
        Me.GroupBox7.Controls.Add(Me.Label49)
        Me.GroupBox7.Controls.Add(Me.txtQtyFree)
        Me.GroupBox7.Controls.Add(Me.Label48)
        Me.GroupBox7.Controls.Add(Me.txtQtySold)
        Me.GroupBox7.Controls.Add(Me.Label47)
        Me.GroupBox7.Location = New System.Drawing.Point(8, 224)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(400, 138)
        Me.GroupBox7.TabIndex = 23
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Quantity/Amount"
        '
        'txtCreditedAmount
        '
        Me.txtCreditedAmount.BackColor = System.Drawing.Color.SkyBlue
        Me.txtCreditedAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreditedAmount.Location = New System.Drawing.Point(132, 112)
        Me.txtCreditedAmount.Name = "txtCreditedAmount"
        Me.txtCreditedAmount.Size = New System.Drawing.Size(256, 20)
        Me.txtCreditedAmount.TabIndex = 72
        Me.txtCreditedAmount.Text = ""
        Me.txtCreditedAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.Color.SkyBlue
        Me.Label51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label51.Location = New System.Drawing.Point(8, 112)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(120, 20)
        Me.Label51.TabIndex = 71
        Me.Label51.Text = "CreditedAmount"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAmountSold
        '
        Me.txtAmountSold.BackColor = System.Drawing.Color.SkyBlue
        Me.txtAmountSold.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountSold.Location = New System.Drawing.Point(132, 88)
        Me.txtAmountSold.Name = "txtAmountSold"
        Me.txtAmountSold.Size = New System.Drawing.Size(256, 20)
        Me.txtAmountSold.TabIndex = 70
        Me.txtAmountSold.Text = ""
        Me.txtAmountSold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.SkyBlue
        Me.Label50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label50.Location = New System.Drawing.Point(8, 88)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(120, 20)
        Me.Label50.TabIndex = 69
        Me.Label50.Text = "AmountSold"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.BackColor = System.Drawing.Color.SkyBlue
        Me.txtUnitPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitPrice.Location = New System.Drawing.Point(132, 64)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(256, 20)
        Me.txtUnitPrice.TabIndex = 68
        Me.txtUnitPrice.Text = ""
        Me.txtUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label49
        '
        Me.Label49.BackColor = System.Drawing.Color.SkyBlue
        Me.Label49.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label49.Location = New System.Drawing.Point(8, 64)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(120, 20)
        Me.Label49.TabIndex = 67
        Me.Label49.Text = "UnitPrice"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtQtyFree
        '
        Me.txtQtyFree.BackColor = System.Drawing.Color.SkyBlue
        Me.txtQtyFree.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtyFree.Location = New System.Drawing.Point(132, 40)
        Me.txtQtyFree.Name = "txtQtyFree"
        Me.txtQtyFree.Size = New System.Drawing.Size(256, 20)
        Me.txtQtyFree.TabIndex = 66
        Me.txtQtyFree.Text = ""
        Me.txtQtyFree.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.Color.SkyBlue
        Me.Label48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label48.Location = New System.Drawing.Point(8, 40)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(120, 20)
        Me.Label48.TabIndex = 65
        Me.Label48.Text = "QtyFree"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtQtySold
        '
        Me.txtQtySold.BackColor = System.Drawing.Color.SkyBlue
        Me.txtQtySold.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtySold.Location = New System.Drawing.Point(132, 16)
        Me.txtQtySold.Name = "txtQtySold"
        Me.txtQtySold.Size = New System.Drawing.Size(256, 20)
        Me.txtQtySold.TabIndex = 64
        Me.txtQtySold.Text = ""
        Me.txtQtySold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label47
        '
        Me.Label47.BackColor = System.Drawing.Color.SkyBlue
        Me.Label47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label47.Location = New System.Drawing.Point(8, 16)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(120, 20)
        Me.Label47.TabIndex = 63
        Me.Label47.Text = "QtySold"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.ItemLinkLabel)
        Me.GroupBox6.Controls.Add(Me.txtDistributor)
        Me.GroupBox6.Controls.Add(Me.Label46)
        Me.GroupBox6.Controls.Add(Me.txtCompany)
        Me.GroupBox6.Controls.Add(Me.Label45)
        Me.GroupBox6.Controls.Add(Me.txtDivisionDesc)
        Me.GroupBox6.Controls.Add(Me.Label44)
        Me.GroupBox6.Controls.Add(Me.txtDivisionCode)
        Me.GroupBox6.Controls.Add(Me.Label43)
        Me.GroupBox6.Controls.Add(Me.txtPrincipalDesc)
        Me.GroupBox6.Controls.Add(Me.Label42)
        Me.GroupBox6.Controls.Add(Me.txtPrincipalCode)
        Me.GroupBox6.Controls.Add(Me.Label41)
        Me.GroupBox6.Controls.Add(Me.txtItemDesc)
        Me.GroupBox6.Controls.Add(Me.Label40)
        Me.GroupBox6.Controls.Add(Me.txtItemCode)
        Me.GroupBox6.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(400, 208)
        Me.GroupBox6.TabIndex = 22
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Item Info"
        '
        'ItemLinkLabel
        '
        Me.ItemLinkLabel.BackColor = System.Drawing.Color.SkyBlue
        Me.ItemLinkLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ItemLinkLabel.Location = New System.Drawing.Point(8, 14)
        Me.ItemLinkLabel.Name = "ItemLinkLabel"
        Me.ItemLinkLabel.Size = New System.Drawing.Size(120, 20)
        Me.ItemLinkLabel.TabIndex = 49
        Me.ItemLinkLabel.TabStop = True
        Me.ItemLinkLabel.Text = "ItemCode"
        Me.ItemLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDistributor
        '
        Me.txtDistributor.BackColor = System.Drawing.Color.SkyBlue
        Me.txtDistributor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDistributor.Location = New System.Drawing.Point(132, 182)
        Me.txtDistributor.Name = "txtDistributor"
        Me.txtDistributor.Size = New System.Drawing.Size(256, 20)
        Me.txtDistributor.TabIndex = 37
        Me.txtDistributor.Text = ""
        '
        'Label46
        '
        Me.Label46.BackColor = System.Drawing.Color.SkyBlue
        Me.Label46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label46.Location = New System.Drawing.Point(8, 182)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(120, 20)
        Me.Label46.TabIndex = 36
        Me.Label46.Text = "Distributor"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCompany
        '
        Me.txtCompany.BackColor = System.Drawing.Color.SkyBlue
        Me.txtCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompany.Location = New System.Drawing.Point(132, 158)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(256, 20)
        Me.txtCompany.TabIndex = 35
        Me.txtCompany.Text = ""
        '
        'Label45
        '
        Me.Label45.BackColor = System.Drawing.Color.SkyBlue
        Me.Label45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label45.Location = New System.Drawing.Point(8, 158)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(120, 20)
        Me.Label45.TabIndex = 34
        Me.Label45.Text = "Company"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDivisionDesc
        '
        Me.txtDivisionDesc.BackColor = System.Drawing.Color.SkyBlue
        Me.txtDivisionDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDivisionDesc.Location = New System.Drawing.Point(132, 134)
        Me.txtDivisionDesc.Name = "txtDivisionDesc"
        Me.txtDivisionDesc.Size = New System.Drawing.Size(256, 20)
        Me.txtDivisionDesc.TabIndex = 33
        Me.txtDivisionDesc.Text = ""
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.Color.SkyBlue
        Me.Label44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label44.Location = New System.Drawing.Point(8, 134)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(120, 20)
        Me.Label44.TabIndex = 32
        Me.Label44.Text = "DivisionDesc"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDivisionCode
        '
        Me.txtDivisionCode.BackColor = System.Drawing.Color.SkyBlue
        Me.txtDivisionCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDivisionCode.Location = New System.Drawing.Point(132, 110)
        Me.txtDivisionCode.Name = "txtDivisionCode"
        Me.txtDivisionCode.Size = New System.Drawing.Size(256, 20)
        Me.txtDivisionCode.TabIndex = 31
        Me.txtDivisionCode.Text = ""
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.Color.SkyBlue
        Me.Label43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label43.Location = New System.Drawing.Point(8, 110)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(120, 20)
        Me.Label43.TabIndex = 30
        Me.Label43.Text = "DivisionCode"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPrincipalDesc
        '
        Me.txtPrincipalDesc.BackColor = System.Drawing.Color.SkyBlue
        Me.txtPrincipalDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrincipalDesc.Location = New System.Drawing.Point(132, 86)
        Me.txtPrincipalDesc.Name = "txtPrincipalDesc"
        Me.txtPrincipalDesc.Size = New System.Drawing.Size(256, 20)
        Me.txtPrincipalDesc.TabIndex = 29
        Me.txtPrincipalDesc.Text = ""
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.SkyBlue
        Me.Label42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label42.Location = New System.Drawing.Point(8, 86)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(120, 20)
        Me.Label42.TabIndex = 28
        Me.Label42.Text = "PrincipalDesc"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPrincipalCode
        '
        Me.txtPrincipalCode.BackColor = System.Drawing.Color.SkyBlue
        Me.txtPrincipalCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrincipalCode.Location = New System.Drawing.Point(132, 62)
        Me.txtPrincipalCode.Name = "txtPrincipalCode"
        Me.txtPrincipalCode.Size = New System.Drawing.Size(256, 20)
        Me.txtPrincipalCode.TabIndex = 27
        Me.txtPrincipalCode.Text = ""
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.Color.SkyBlue
        Me.Label41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label41.Location = New System.Drawing.Point(8, 62)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(120, 20)
        Me.Label41.TabIndex = 26
        Me.Label41.Text = "PrincipalCode"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtItemDesc
        '
        Me.txtItemDesc.BackColor = System.Drawing.Color.SkyBlue
        Me.txtItemDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemDesc.Location = New System.Drawing.Point(132, 38)
        Me.txtItemDesc.Name = "txtItemDesc"
        Me.txtItemDesc.Size = New System.Drawing.Size(256, 20)
        Me.txtItemDesc.TabIndex = 25
        Me.txtItemDesc.Text = ""
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.Color.SkyBlue
        Me.Label40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label40.Location = New System.Drawing.Point(8, 38)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(120, 20)
        Me.Label40.TabIndex = 24
        Me.Label40.Text = "ItemDesc"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtItemCode
        '
        Me.txtItemCode.BackColor = System.Drawing.Color.SkyBlue
        Me.txtItemCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemCode.Location = New System.Drawing.Point(132, 14)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(256, 20)
        Me.txtItemCode.TabIndex = 23
        Me.txtItemCode.Text = ""
        '
        'Misc
        '
        Me.Misc.Controls.Add(Me.GroupBox24)
        Me.Misc.Controls.Add(Me.GroupBox11)
        Me.Misc.Controls.Add(Me.GroupBox10)
        Me.Misc.Controls.Add(Me.GroupBox9)
        Me.Misc.Location = New System.Drawing.Point(4, 22)
        Me.Misc.Name = "Misc"
        Me.Misc.Size = New System.Drawing.Size(416, 646)
        Me.Misc.TabIndex = 4
        Me.Misc.Text = "Misc"
        '
        'GroupBox24
        '
        Me.GroupBox24.Controls.Add(Me.txtUpdateDate)
        Me.GroupBox24.Controls.Add(Me.Label89)
        Me.GroupBox24.Controls.Add(Me.txtCreateDate)
        Me.GroupBox24.Controls.Add(Me.Label88)
        Me.GroupBox24.Controls.Add(Me.txtCreate_Date)
        Me.GroupBox24.Controls.Add(Me.Label86)
        Me.GroupBox24.Location = New System.Drawing.Point(8, 368)
        Me.GroupBox24.Name = "GroupBox24"
        Me.GroupBox24.Size = New System.Drawing.Size(400, 90)
        Me.GroupBox24.TabIndex = 33
        Me.GroupBox24.TabStop = False
        Me.GroupBox24.Text = "Trail"
        '
        'txtUpdateDate
        '
        Me.txtUpdateDate.BackColor = System.Drawing.Color.SkyBlue
        Me.txtUpdateDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdateDate.Location = New System.Drawing.Point(132, 64)
        Me.txtUpdateDate.Name = "txtUpdateDate"
        Me.txtUpdateDate.Size = New System.Drawing.Size(256, 20)
        Me.txtUpdateDate.TabIndex = 103
        Me.txtUpdateDate.Text = ""
        '
        'Label89
        '
        Me.Label89.BackColor = System.Drawing.Color.SkyBlue
        Me.Label89.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label89.Location = New System.Drawing.Point(8, 64)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(120, 20)
        Me.Label89.TabIndex = 102
        Me.Label89.Text = "UpdateDate"
        Me.Label89.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCreateDate
        '
        Me.txtCreateDate.BackColor = System.Drawing.Color.SkyBlue
        Me.txtCreateDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreateDate.Location = New System.Drawing.Point(132, 40)
        Me.txtCreateDate.Name = "txtCreateDate"
        Me.txtCreateDate.Size = New System.Drawing.Size(256, 20)
        Me.txtCreateDate.TabIndex = 101
        Me.txtCreateDate.Text = ""
        '
        'Label88
        '
        Me.Label88.BackColor = System.Drawing.Color.SkyBlue
        Me.Label88.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label88.Location = New System.Drawing.Point(8, 40)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(120, 20)
        Me.Label88.TabIndex = 100
        Me.Label88.Text = "CreateDate"
        Me.Label88.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCreate_Date
        '
        Me.txtCreate_Date.BackColor = System.Drawing.Color.SkyBlue
        Me.txtCreate_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreate_Date.Location = New System.Drawing.Point(132, 16)
        Me.txtCreate_Date.Name = "txtCreate_Date"
        Me.txtCreate_Date.Size = New System.Drawing.Size(256, 20)
        Me.txtCreate_Date.TabIndex = 99
        Me.txtCreate_Date.Text = ""
        '
        'Label86
        '
        Me.Label86.BackColor = System.Drawing.Color.SkyBlue
        Me.Label86.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label86.Location = New System.Drawing.Point(8, 16)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(120, 20)
        Me.Label86.TabIndex = 98
        Me.Label86.Text = "Create_Date"
        Me.Label86.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.txtNavTag)
        Me.GroupBox11.Controls.Add(Me.Label92)
        Me.GroupBox11.Controls.Add(Me.txtMdsDr)
        Me.GroupBox11.Controls.Add(Me.Label91)
        Me.GroupBox11.Controls.Add(Me.txtExcludeAttachment)
        Me.GroupBox11.Controls.Add(Me.Label90)
        Me.GroupBox11.Location = New System.Drawing.Point(8, 272)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(400, 90)
        Me.GroupBox11.TabIndex = 32
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Others"
        '
        'txtNavTag
        '
        Me.txtNavTag.BackColor = System.Drawing.Color.SkyBlue
        Me.txtNavTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNavTag.Location = New System.Drawing.Point(132, 64)
        Me.txtNavTag.Name = "txtNavTag"
        Me.txtNavTag.Size = New System.Drawing.Size(256, 20)
        Me.txtNavTag.TabIndex = 109
        Me.txtNavTag.Text = ""
        '
        'Label92
        '
        Me.Label92.BackColor = System.Drawing.Color.SkyBlue
        Me.Label92.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label92.Location = New System.Drawing.Point(8, 64)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(120, 20)
        Me.Label92.TabIndex = 108
        Me.Label92.Text = "NavTag"
        Me.Label92.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMdsDr
        '
        Me.txtMdsDr.BackColor = System.Drawing.Color.SkyBlue
        Me.txtMdsDr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMdsDr.Location = New System.Drawing.Point(132, 40)
        Me.txtMdsDr.Name = "txtMdsDr"
        Me.txtMdsDr.Size = New System.Drawing.Size(256, 20)
        Me.txtMdsDr.TabIndex = 107
        Me.txtMdsDr.Text = ""
        '
        'Label91
        '
        Me.Label91.BackColor = System.Drawing.Color.SkyBlue
        Me.Label91.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label91.Location = New System.Drawing.Point(8, 40)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(120, 20)
        Me.Label91.TabIndex = 106
        Me.Label91.Text = "MdsDr"
        Me.Label91.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtExcludeAttachment
        '
        Me.txtExcludeAttachment.BackColor = System.Drawing.Color.SkyBlue
        Me.txtExcludeAttachment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExcludeAttachment.Location = New System.Drawing.Point(132, 16)
        Me.txtExcludeAttachment.Name = "txtExcludeAttachment"
        Me.txtExcludeAttachment.Size = New System.Drawing.Size(256, 20)
        Me.txtExcludeAttachment.TabIndex = 105
        Me.txtExcludeAttachment.Text = ""
        '
        'Label90
        '
        Me.Label90.BackColor = System.Drawing.Color.SkyBlue
        Me.Label90.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label90.Location = New System.Drawing.Point(8, 16)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(120, 20)
        Me.Label90.TabIndex = 104
        Me.Label90.Text = "ExcludeAttachment"
        Me.Label90.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.txtSalesClass)
        Me.GroupBox10.Controls.Add(Me.Label85)
        Me.GroupBox10.Controls.Add(Me.txtExcessSales)
        Me.GroupBox10.Controls.Add(Me.Label84)
        Me.GroupBox10.Controls.Add(Me.txtSubSaleType)
        Me.GroupBox10.Controls.Add(Me.Label83)
        Me.GroupBox10.Controls.Add(Me.txtTransactionType)
        Me.GroupBox10.Controls.Add(Me.Label82)
        Me.GroupBox10.Controls.Add(Me.txtSaleType)
        Me.GroupBox10.Controls.Add(Me.Label81)
        Me.GroupBox10.Location = New System.Drawing.Point(8, 128)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(400, 138)
        Me.GroupBox10.TabIndex = 31
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Categories"
        '
        'txtSalesClass
        '
        Me.txtSalesClass.BackColor = System.Drawing.Color.SkyBlue
        Me.txtSalesClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalesClass.Location = New System.Drawing.Point(132, 88)
        Me.txtSalesClass.Name = "txtSalesClass"
        Me.txtSalesClass.Size = New System.Drawing.Size(256, 20)
        Me.txtSalesClass.TabIndex = 101
        Me.txtSalesClass.Text = ""
        '
        'Label85
        '
        Me.Label85.BackColor = System.Drawing.Color.SkyBlue
        Me.Label85.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label85.Location = New System.Drawing.Point(8, 88)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(120, 20)
        Me.Label85.TabIndex = 100
        Me.Label85.Text = "SalesClass"
        Me.Label85.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtExcessSales
        '
        Me.txtExcessSales.BackColor = System.Drawing.Color.SkyBlue
        Me.txtExcessSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExcessSales.Location = New System.Drawing.Point(132, 112)
        Me.txtExcessSales.Name = "txtExcessSales"
        Me.txtExcessSales.Size = New System.Drawing.Size(256, 20)
        Me.txtExcessSales.TabIndex = 99
        Me.txtExcessSales.Text = ""
        '
        'Label84
        '
        Me.Label84.BackColor = System.Drawing.Color.SkyBlue
        Me.Label84.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label84.Location = New System.Drawing.Point(8, 112)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(120, 20)
        Me.Label84.TabIndex = 98
        Me.Label84.Text = "ExcessSales"
        Me.Label84.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSubSaleType
        '
        Me.txtSubSaleType.BackColor = System.Drawing.Color.SkyBlue
        Me.txtSubSaleType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubSaleType.Location = New System.Drawing.Point(132, 64)
        Me.txtSubSaleType.Name = "txtSubSaleType"
        Me.txtSubSaleType.Size = New System.Drawing.Size(256, 20)
        Me.txtSubSaleType.TabIndex = 97
        Me.txtSubSaleType.Text = ""
        '
        'Label83
        '
        Me.Label83.BackColor = System.Drawing.Color.SkyBlue
        Me.Label83.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label83.Location = New System.Drawing.Point(8, 64)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(120, 20)
        Me.Label83.TabIndex = 96
        Me.Label83.Text = "SubSaleType"
        Me.Label83.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTransactionType
        '
        Me.txtTransactionType.BackColor = System.Drawing.Color.SkyBlue
        Me.txtTransactionType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransactionType.Location = New System.Drawing.Point(132, 40)
        Me.txtTransactionType.Name = "txtTransactionType"
        Me.txtTransactionType.Size = New System.Drawing.Size(256, 20)
        Me.txtTransactionType.TabIndex = 95
        Me.txtTransactionType.Text = ""
        '
        'Label82
        '
        Me.Label82.BackColor = System.Drawing.Color.SkyBlue
        Me.Label82.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label82.Location = New System.Drawing.Point(8, 40)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(120, 20)
        Me.Label82.TabIndex = 94
        Me.Label82.Text = "TransactionType"
        Me.Label82.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSaleType
        '
        Me.txtSaleType.BackColor = System.Drawing.Color.SkyBlue
        Me.txtSaleType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaleType.Location = New System.Drawing.Point(132, 16)
        Me.txtSaleType.Name = "txtSaleType"
        Me.txtSaleType.Size = New System.Drawing.Size(256, 20)
        Me.txtSaleType.TabIndex = 93
        Me.txtSaleType.Text = ""
        '
        'Label81
        '
        Me.Label81.BackColor = System.Drawing.Color.SkyBlue
        Me.Label81.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label81.Location = New System.Drawing.Point(8, 16)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(120, 20)
        Me.Label81.TabIndex = 92
        Me.Label81.Text = "SaleType"
        Me.Label81.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.dtpMdiSalesDate)
        Me.GroupBox9.Controls.Add(Me.dtpMdiCycleDate)
        Me.GroupBox9.Controls.Add(Me.dtpSalesCycleDate)
        Me.GroupBox9.Controls.Add(Me.dtpCommissionDate)
        Me.GroupBox9.Controls.Add(Me.txtMdiSalesDate)
        Me.GroupBox9.Controls.Add(Me.Label87)
        Me.GroupBox9.Controls.Add(Me.txtMdiCycleDate)
        Me.GroupBox9.Controls.Add(Me.Label80)
        Me.GroupBox9.Controls.Add(Me.txtSalesCycleDate)
        Me.GroupBox9.Controls.Add(Me.Label79)
        Me.GroupBox9.Controls.Add(Me.txtCommissionDate)
        Me.GroupBox9.Controls.Add(Me.Label76)
        Me.GroupBox9.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(400, 114)
        Me.GroupBox9.TabIndex = 30
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Dates"
        '
        'txtMdiSalesDate
        '
        Me.txtMdiSalesDate.BackColor = System.Drawing.Color.SkyBlue
        Me.txtMdiSalesDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMdiSalesDate.Location = New System.Drawing.Point(132, 86)
        Me.txtMdiSalesDate.Name = "txtMdiSalesDate"
        Me.txtMdiSalesDate.Size = New System.Drawing.Size(256, 20)
        Me.txtMdiSalesDate.TabIndex = 37
        Me.txtMdiSalesDate.Text = ""
        '
        'Label87
        '
        Me.Label87.BackColor = System.Drawing.Color.SkyBlue
        Me.Label87.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label87.Location = New System.Drawing.Point(8, 86)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(120, 20)
        Me.Label87.TabIndex = 36
        Me.Label87.Text = "MdiSalesDate"
        Me.Label87.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMdiCycleDate
        '
        Me.txtMdiCycleDate.BackColor = System.Drawing.Color.SkyBlue
        Me.txtMdiCycleDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMdiCycleDate.Location = New System.Drawing.Point(132, 62)
        Me.txtMdiCycleDate.Name = "txtMdiCycleDate"
        Me.txtMdiCycleDate.Size = New System.Drawing.Size(256, 20)
        Me.txtMdiCycleDate.TabIndex = 35
        Me.txtMdiCycleDate.Text = ""
        '
        'Label80
        '
        Me.Label80.BackColor = System.Drawing.Color.SkyBlue
        Me.Label80.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label80.Location = New System.Drawing.Point(8, 62)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(120, 20)
        Me.Label80.TabIndex = 34
        Me.Label80.Text = "MdiCycleDate"
        Me.Label80.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSalesCycleDate
        '
        Me.txtSalesCycleDate.BackColor = System.Drawing.Color.SkyBlue
        Me.txtSalesCycleDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalesCycleDate.Location = New System.Drawing.Point(132, 38)
        Me.txtSalesCycleDate.Name = "txtSalesCycleDate"
        Me.txtSalesCycleDate.Size = New System.Drawing.Size(256, 20)
        Me.txtSalesCycleDate.TabIndex = 33
        Me.txtSalesCycleDate.Text = ""
        '
        'Label79
        '
        Me.Label79.BackColor = System.Drawing.Color.SkyBlue
        Me.Label79.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label79.Location = New System.Drawing.Point(8, 38)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(120, 20)
        Me.Label79.TabIndex = 32
        Me.Label79.Text = "SalesCycleDate"
        Me.Label79.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCommissionDate
        '
        Me.txtCommissionDate.BackColor = System.Drawing.Color.SkyBlue
        Me.txtCommissionDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCommissionDate.Location = New System.Drawing.Point(132, 14)
        Me.txtCommissionDate.Name = "txtCommissionDate"
        Me.txtCommissionDate.Size = New System.Drawing.Size(256, 20)
        Me.txtCommissionDate.TabIndex = 31
        Me.txtCommissionDate.Text = ""
        '
        'Label76
        '
        Me.Label76.BackColor = System.Drawing.Color.SkyBlue
        Me.Label76.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label76.Location = New System.Drawing.Point(8, 14)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(120, 20)
        Me.Label76.TabIndex = 30
        Me.Label76.Text = "CommissionDate"
        Me.Label76.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Crediting
        '
        Me.Crediting.Controls.Add(Me.GroupBox17)
        Me.Crediting.Controls.Add(Me.GroupBox16)
        Me.Crediting.Controls.Add(Me.GroupBox15)
        Me.Crediting.Controls.Add(Me.GroupBox14)
        Me.Crediting.Controls.Add(Me.GroupBox13)
        Me.Crediting.Controls.Add(Me.GroupBox12)
        Me.Crediting.Location = New System.Drawing.Point(4, 22)
        Me.Crediting.Name = "Crediting"
        Me.Crediting.Size = New System.Drawing.Size(416, 646)
        Me.Crediting.TabIndex = 3
        Me.Crediting.Text = "Crediting"
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.Add(Me.txtQpiAreaCode)
        Me.GroupBox17.Controls.Add(Me.Label73)
        Me.GroupBox17.Location = New System.Drawing.Point(8, 488)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(400, 42)
        Me.GroupBox17.TabIndex = 27
        Me.GroupBox17.TabStop = False
        '
        'txtQpiAreaCode
        '
        Me.txtQpiAreaCode.BackColor = System.Drawing.Color.SkyBlue
        Me.txtQpiAreaCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQpiAreaCode.Location = New System.Drawing.Point(132, 16)
        Me.txtQpiAreaCode.Name = "txtQpiAreaCode"
        Me.txtQpiAreaCode.Size = New System.Drawing.Size(256, 20)
        Me.txtQpiAreaCode.TabIndex = 67
        Me.txtQpiAreaCode.Text = ""
        '
        'Label73
        '
        Me.Label73.BackColor = System.Drawing.Color.SkyBlue
        Me.Label73.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label73.Location = New System.Drawing.Point(8, 16)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(120, 20)
        Me.Label73.TabIndex = 66
        Me.Label73.Text = "QpiAreaCode"
        Me.Label73.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(Me.txtFloaterMrName)
        Me.GroupBox16.Controls.Add(Me.Label78)
        Me.GroupBox16.Controls.Add(Me.txtFloaterMrCode)
        Me.GroupBox16.Controls.Add(Me.Label77)
        Me.GroupBox16.Location = New System.Drawing.Point(8, 416)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(400, 66)
        Me.GroupBox16.TabIndex = 26
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "Floater MR"
        '
        'txtFloaterMrName
        '
        Me.txtFloaterMrName.BackColor = System.Drawing.Color.SkyBlue
        Me.txtFloaterMrName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFloaterMrName.Location = New System.Drawing.Point(132, 40)
        Me.txtFloaterMrName.Name = "txtFloaterMrName"
        Me.txtFloaterMrName.Size = New System.Drawing.Size(256, 20)
        Me.txtFloaterMrName.TabIndex = 77
        Me.txtFloaterMrName.Text = ""
        '
        'Label78
        '
        Me.Label78.BackColor = System.Drawing.Color.SkyBlue
        Me.Label78.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label78.Location = New System.Drawing.Point(8, 40)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(120, 20)
        Me.Label78.TabIndex = 76
        Me.Label78.Text = "FloaterMrName"
        Me.Label78.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFloaterMrCode
        '
        Me.txtFloaterMrCode.BackColor = System.Drawing.Color.SkyBlue
        Me.txtFloaterMrCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFloaterMrCode.Location = New System.Drawing.Point(132, 16)
        Me.txtFloaterMrCode.Name = "txtFloaterMrCode"
        Me.txtFloaterMrCode.Size = New System.Drawing.Size(256, 20)
        Me.txtFloaterMrCode.TabIndex = 75
        Me.txtFloaterMrCode.Text = ""
        '
        'Label77
        '
        Me.Label77.BackColor = System.Drawing.Color.SkyBlue
        Me.Label77.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label77.Location = New System.Drawing.Point(8, 16)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(120, 20)
        Me.Label77.TabIndex = 74
        Me.Label77.Text = "FloaterMrCode"
        Me.Label77.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.txtModTradeDsmName)
        Me.GroupBox15.Controls.Add(Me.Label75)
        Me.GroupBox15.Controls.Add(Me.txtModTradeDsmCode)
        Me.GroupBox15.Controls.Add(Me.Label74)
        Me.GroupBox15.Location = New System.Drawing.Point(8, 344)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(400, 66)
        Me.GroupBox15.TabIndex = 25
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "ModTrade"
        '
        'txtModTradeDsmName
        '
        Me.txtModTradeDsmName.BackColor = System.Drawing.Color.SkyBlue
        Me.txtModTradeDsmName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModTradeDsmName.Location = New System.Drawing.Point(132, 40)
        Me.txtModTradeDsmName.Name = "txtModTradeDsmName"
        Me.txtModTradeDsmName.Size = New System.Drawing.Size(256, 20)
        Me.txtModTradeDsmName.TabIndex = 73
        Me.txtModTradeDsmName.Text = ""
        '
        'Label75
        '
        Me.Label75.BackColor = System.Drawing.Color.SkyBlue
        Me.Label75.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label75.Location = New System.Drawing.Point(8, 40)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(120, 20)
        Me.Label75.TabIndex = 72
        Me.Label75.Text = "ModTradeDsmName"
        Me.Label75.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtModTradeDsmCode
        '
        Me.txtModTradeDsmCode.BackColor = System.Drawing.Color.SkyBlue
        Me.txtModTradeDsmCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModTradeDsmCode.Location = New System.Drawing.Point(132, 16)
        Me.txtModTradeDsmCode.Name = "txtModTradeDsmCode"
        Me.txtModTradeDsmCode.Size = New System.Drawing.Size(256, 20)
        Me.txtModTradeDsmCode.TabIndex = 71
        Me.txtModTradeDsmCode.Text = ""
        '
        'Label74
        '
        Me.Label74.BackColor = System.Drawing.Color.SkyBlue
        Me.Label74.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label74.Location = New System.Drawing.Point(8, 16)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(120, 20)
        Me.Label74.TabIndex = 70
        Me.Label74.Text = "ModTradeDsmCode"
        Me.Label74.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.txtKasGovName)
        Me.GroupBox14.Controls.Add(Me.Label72)
        Me.GroupBox14.Controls.Add(Me.txtKasGovCode)
        Me.GroupBox14.Controls.Add(Me.Label71)
        Me.GroupBox14.Location = New System.Drawing.Point(8, 272)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(400, 66)
        Me.GroupBox14.TabIndex = 24
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "KasGov"
        '
        'txtKasGovName
        '
        Me.txtKasGovName.BackColor = System.Drawing.Color.SkyBlue
        Me.txtKasGovName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKasGovName.Location = New System.Drawing.Point(132, 40)
        Me.txtKasGovName.Name = "txtKasGovName"
        Me.txtKasGovName.Size = New System.Drawing.Size(256, 20)
        Me.txtKasGovName.TabIndex = 67
        Me.txtKasGovName.Text = ""
        '
        'Label72
        '
        Me.Label72.BackColor = System.Drawing.Color.SkyBlue
        Me.Label72.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label72.Location = New System.Drawing.Point(8, 40)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(120, 20)
        Me.Label72.TabIndex = 66
        Me.Label72.Text = "KasGovName"
        Me.Label72.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtKasGovCode
        '
        Me.txtKasGovCode.BackColor = System.Drawing.Color.SkyBlue
        Me.txtKasGovCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKasGovCode.Location = New System.Drawing.Point(132, 16)
        Me.txtKasGovCode.Name = "txtKasGovCode"
        Me.txtKasGovCode.Size = New System.Drawing.Size(256, 20)
        Me.txtKasGovCode.TabIndex = 65
        Me.txtKasGovCode.Text = ""
        '
        'Label71
        '
        Me.Label71.BackColor = System.Drawing.Color.SkyBlue
        Me.Label71.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label71.Location = New System.Drawing.Point(8, 16)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(120, 20)
        Me.Label71.TabIndex = 64
        Me.Label71.Text = "KasGovCode"
        Me.Label71.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.txtPmName)
        Me.GroupBox13.Controls.Add(Me.Label70)
        Me.GroupBox13.Controls.Add(Me.txtPmCode)
        Me.GroupBox13.Controls.Add(Me.Label69)
        Me.GroupBox13.Location = New System.Drawing.Point(8, 200)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(400, 66)
        Me.GroupBox13.TabIndex = 23
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Product Manager"
        '
        'txtPmName
        '
        Me.txtPmName.BackColor = System.Drawing.Color.SkyBlue
        Me.txtPmName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPmName.Location = New System.Drawing.Point(132, 40)
        Me.txtPmName.Name = "txtPmName"
        Me.txtPmName.Size = New System.Drawing.Size(256, 20)
        Me.txtPmName.TabIndex = 63
        Me.txtPmName.Text = ""
        '
        'Label70
        '
        Me.Label70.BackColor = System.Drawing.Color.SkyBlue
        Me.Label70.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label70.Location = New System.Drawing.Point(8, 40)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(120, 20)
        Me.Label70.TabIndex = 62
        Me.Label70.Text = "PmName"
        Me.Label70.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPmCode
        '
        Me.txtPmCode.BackColor = System.Drawing.Color.SkyBlue
        Me.txtPmCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPmCode.Location = New System.Drawing.Point(132, 16)
        Me.txtPmCode.Name = "txtPmCode"
        Me.txtPmCode.Size = New System.Drawing.Size(256, 20)
        Me.txtPmCode.TabIndex = 61
        Me.txtPmCode.Text = ""
        '
        'Label69
        '
        Me.Label69.BackColor = System.Drawing.Color.SkyBlue
        Me.Label69.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label69.Location = New System.Drawing.Point(8, 16)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(120, 20)
        Me.Label69.TabIndex = 60
        Me.Label69.Text = "PmCode"
        Me.Label69.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.txtNsmName)
        Me.GroupBox12.Controls.Add(Me.Label68)
        Me.GroupBox12.Controls.Add(Me.txtNsmCode)
        Me.GroupBox12.Controls.Add(Me.Label67)
        Me.GroupBox12.Controls.Add(Me.txtSupName)
        Me.GroupBox12.Controls.Add(Me.Label66)
        Me.GroupBox12.Controls.Add(Me.txtSupCode)
        Me.GroupBox12.Controls.Add(Me.Label65)
        Me.GroupBox12.Controls.Add(Me.txtMrName)
        Me.GroupBox12.Controls.Add(Me.Label64)
        Me.GroupBox12.Controls.Add(Me.txtMrCode)
        Me.GroupBox12.Controls.Add(Me.Label63)
        Me.GroupBox12.Controls.Add(Me.txtMrDivision)
        Me.GroupBox12.Controls.Add(Me.Label62)
        Me.GroupBox12.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(400, 186)
        Me.GroupBox12.TabIndex = 22
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "MR/Supervisor"
        '
        'txtNsmName
        '
        Me.txtNsmName.BackColor = System.Drawing.Color.SkyBlue
        Me.txtNsmName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNsmName.Location = New System.Drawing.Point(132, 160)
        Me.txtNsmName.Name = "txtNsmName"
        Me.txtNsmName.Size = New System.Drawing.Size(256, 20)
        Me.txtNsmName.TabIndex = 35
        Me.txtNsmName.Text = ""
        '
        'Label68
        '
        Me.Label68.BackColor = System.Drawing.Color.SkyBlue
        Me.Label68.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label68.Location = New System.Drawing.Point(8, 160)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(120, 20)
        Me.Label68.TabIndex = 34
        Me.Label68.Text = "NsmName"
        Me.Label68.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNsmCode
        '
        Me.txtNsmCode.BackColor = System.Drawing.Color.SkyBlue
        Me.txtNsmCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNsmCode.Location = New System.Drawing.Point(132, 136)
        Me.txtNsmCode.Name = "txtNsmCode"
        Me.txtNsmCode.Size = New System.Drawing.Size(256, 20)
        Me.txtNsmCode.TabIndex = 33
        Me.txtNsmCode.Text = ""
        '
        'Label67
        '
        Me.Label67.BackColor = System.Drawing.Color.SkyBlue
        Me.Label67.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label67.Location = New System.Drawing.Point(8, 136)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(120, 20)
        Me.Label67.TabIndex = 32
        Me.Label67.Text = "NsmCode"
        Me.Label67.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSupName
        '
        Me.txtSupName.BackColor = System.Drawing.Color.SkyBlue
        Me.txtSupName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupName.Location = New System.Drawing.Point(132, 112)
        Me.txtSupName.Name = "txtSupName"
        Me.txtSupName.Size = New System.Drawing.Size(256, 20)
        Me.txtSupName.TabIndex = 31
        Me.txtSupName.Text = ""
        '
        'Label66
        '
        Me.Label66.BackColor = System.Drawing.Color.SkyBlue
        Me.Label66.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label66.Location = New System.Drawing.Point(8, 112)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(120, 20)
        Me.Label66.TabIndex = 30
        Me.Label66.Text = "SupName"
        Me.Label66.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSupCode
        '
        Me.txtSupCode.BackColor = System.Drawing.Color.SkyBlue
        Me.txtSupCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupCode.Location = New System.Drawing.Point(132, 88)
        Me.txtSupCode.Name = "txtSupCode"
        Me.txtSupCode.Size = New System.Drawing.Size(256, 20)
        Me.txtSupCode.TabIndex = 29
        Me.txtSupCode.Text = ""
        '
        'Label65
        '
        Me.Label65.BackColor = System.Drawing.Color.SkyBlue
        Me.Label65.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label65.Location = New System.Drawing.Point(8, 88)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(120, 20)
        Me.Label65.TabIndex = 28
        Me.Label65.Text = "SupCode"
        Me.Label65.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMrName
        '
        Me.txtMrName.BackColor = System.Drawing.Color.SkyBlue
        Me.txtMrName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMrName.Location = New System.Drawing.Point(132, 64)
        Me.txtMrName.Name = "txtMrName"
        Me.txtMrName.Size = New System.Drawing.Size(256, 20)
        Me.txtMrName.TabIndex = 27
        Me.txtMrName.Text = ""
        '
        'Label64
        '
        Me.Label64.BackColor = System.Drawing.Color.SkyBlue
        Me.Label64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label64.Location = New System.Drawing.Point(8, 64)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(120, 20)
        Me.Label64.TabIndex = 26
        Me.Label64.Text = "MrName"
        Me.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMrCode
        '
        Me.txtMrCode.BackColor = System.Drawing.Color.SkyBlue
        Me.txtMrCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMrCode.Location = New System.Drawing.Point(132, 40)
        Me.txtMrCode.Name = "txtMrCode"
        Me.txtMrCode.Size = New System.Drawing.Size(256, 20)
        Me.txtMrCode.TabIndex = 25
        Me.txtMrCode.Text = ""
        '
        'Label63
        '
        Me.Label63.BackColor = System.Drawing.Color.SkyBlue
        Me.Label63.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label63.Location = New System.Drawing.Point(8, 40)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(120, 20)
        Me.Label63.TabIndex = 24
        Me.Label63.Text = "MrCode"
        Me.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMrDivision
        '
        Me.txtMrDivision.BackColor = System.Drawing.Color.SkyBlue
        Me.txtMrDivision.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMrDivision.Location = New System.Drawing.Point(132, 14)
        Me.txtMrDivision.Name = "txtMrDivision"
        Me.txtMrDivision.Size = New System.Drawing.Size(256, 20)
        Me.txtMrDivision.TabIndex = 23
        Me.txtMrDivision.Text = ""
        '
        'Label62
        '
        Me.Label62.BackColor = System.Drawing.Color.SkyBlue
        Me.Label62.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label62.Location = New System.Drawing.Point(8, 14)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(120, 20)
        Me.Label62.TabIndex = 22
        Me.Label62.Text = "MrDivision"
        Me.Label62.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Filter
        '
        Me.Filter.Controls.Add(Me.GroupBox18)
        Me.Filter.Location = New System.Drawing.Point(4, 22)
        Me.Filter.Name = "Filter"
        Me.Filter.Size = New System.Drawing.Size(416, 646)
        Me.Filter.TabIndex = 5
        Me.Filter.Text = "Filter"
        '
        'GroupBox18
        '
        Me.GroupBox18.Controls.Add(Me.TextBox1)
        Me.GroupBox18.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox18.Name = "GroupBox18"
        Me.GroupBox18.Size = New System.Drawing.Size(400, 224)
        Me.GroupBox18.TabIndex = 0
        Me.GroupBox18.TabStop = False
        Me.GroupBox18.Text = "Reference Code"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.SkyBlue
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(8, 16)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(384, 200)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.InvoiceDataGrid)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 344)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(240, 344)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Invoice"
        '
        'InvoiceDataGrid
        '
        Me.InvoiceDataGrid.DataMember = ""
        Me.InvoiceDataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.InvoiceDataGrid.Location = New System.Drawing.Point(8, 24)
        Me.InvoiceDataGrid.Name = "InvoiceDataGrid"
        Me.InvoiceDataGrid.RowHeadersVisible = False
        Me.InvoiceDataGrid.RowHeaderWidth = 0
        Me.InvoiceDataGrid.SelectionBackColor = System.Drawing.Color.Bisque
        Me.InvoiceDataGrid.SelectionForeColor = System.Drawing.Color.DimGray
        Me.InvoiceDataGrid.Size = New System.Drawing.Size(224, 312)
        Me.InvoiceDataGrid.TabIndex = 0
        Me.InvoiceDataGrid.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.AlternatingBackColor = System.Drawing.Color.LightSkyBlue
        Me.DataGridTableStyle2.BackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle2.DataGrid = Me.InvoiceDataGrid
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.RefCode, Me.RefDate})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = ""
        Me.DataGridTableStyle2.ReadOnly = True
        Me.DataGridTableStyle2.RowHeaderWidth = 0
        Me.DataGridTableStyle2.SelectionBackColor = System.Drawing.Color.Bisque
        Me.DataGridTableStyle2.SelectionForeColor = System.Drawing.Color.DimGray
        '
        'RefCode
        '
        Me.RefCode.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.RefCode.Format = ""
        Me.RefCode.FormatInfo = Nothing
        Me.RefCode.HeaderText = "Reference Code"
        Me.RefCode.MappingName = "RefCode"
        Me.RefCode.Width = 96
        '
        'RefDate
        '
        Me.RefDate.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.RefDate.Format = ""
        Me.RefDate.FormatInfo = Nothing
        Me.RefDate.HeaderText = "Reference Date"
        Me.RefDate.MappingName = "RefDate"
        Me.RefDate.Width = 109
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LineItemDataGrid)
        Me.GroupBox3.Location = New System.Drawing.Point(256, 344)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(664, 344)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Line Item(s)"
        '
        'LineItemDataGrid
        '
        Me.LineItemDataGrid.DataMember = ""
        Me.LineItemDataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.LineItemDataGrid.Location = New System.Drawing.Point(8, 24)
        Me.LineItemDataGrid.Name = "LineItemDataGrid"
        Me.LineItemDataGrid.RowHeadersVisible = False
        Me.LineItemDataGrid.RowHeaderWidth = 0
        Me.LineItemDataGrid.SelectionBackColor = System.Drawing.Color.Bisque
        Me.LineItemDataGrid.SelectionForeColor = System.Drawing.Color.DimGray
        Me.LineItemDataGrid.Size = New System.Drawing.Size(648, 312)
        Me.LineItemDataGrid.TabIndex = 0
        Me.LineItemDataGrid.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle3})
        '
        'DataGridTableStyle3
        '
        Me.DataGridTableStyle3.AlternatingBackColor = System.Drawing.Color.LightSkyBlue
        Me.DataGridTableStyle3.BackColor = System.Drawing.Color.Gainsboro
        Me.DataGridTableStyle3.DataGrid = Me.LineItemDataGrid
        Me.DataGridTableStyle3.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.Rowid, Me.ItemCode, Me.ItemDesc, Me.QtySold, Me.QtyFree, Me.UnitPrice, Me.CreditedAmount, Me.InvoiceLine})
        Me.DataGridTableStyle3.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle3.MappingName = ""
        Me.DataGridTableStyle3.ReadOnly = True
        Me.DataGridTableStyle3.SelectionBackColor = System.Drawing.Color.Bisque
        Me.DataGridTableStyle3.SelectionForeColor = System.Drawing.Color.DimGray
        '
        'Rowid
        '
        Me.Rowid.Format = ""
        Me.Rowid.FormatInfo = Nothing
        Me.Rowid.HeaderText = "Rowid"
        Me.Rowid.MappingName = "Rowid"
        Me.Rowid.Width = 0
        '
        'ItemCode
        '
        Me.ItemCode.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.ItemCode.Format = ""
        Me.ItemCode.FormatInfo = Nothing
        Me.ItemCode.HeaderText = "Item Code"
        Me.ItemCode.MappingName = "ItemCode"
        Me.ItemCode.Width = 60
        '
        'ItemDesc
        '
        Me.ItemDesc.Format = ""
        Me.ItemDesc.FormatInfo = Nothing
        Me.ItemDesc.HeaderText = "Description"
        Me.ItemDesc.MappingName = "ItemDesc"
        Me.ItemDesc.Width = 250
        '
        'QtySold
        '
        Me.QtySold.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.QtySold.Format = ""
        Me.QtySold.FormatInfo = Nothing
        Me.QtySold.HeaderText = "Qty"
        Me.QtySold.MappingName = "QtySold"
        Me.QtySold.Width = 50
        '
        'QtyFree
        '
        Me.QtyFree.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.QtyFree.Format = ""
        Me.QtyFree.FormatInfo = Nothing
        Me.QtyFree.HeaderText = "Free"
        Me.QtyFree.MappingName = "QtyFree"
        Me.QtyFree.Width = 50
        '
        'UnitPrice
        '
        Me.UnitPrice.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.UnitPrice.Format = ""
        Me.UnitPrice.FormatInfo = Nothing
        Me.UnitPrice.HeaderText = "Price"
        Me.UnitPrice.MappingName = "UnitPrice"
        Me.UnitPrice.Width = 78
        '
        'CreditedAmount
        '
        Me.CreditedAmount.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.CreditedAmount.Format = ""
        Me.CreditedAmount.FormatInfo = Nothing
        Me.CreditedAmount.HeaderText = "Line Total"
        Me.CreditedAmount.MappingName = "CreditedAmount"
        Me.CreditedAmount.Width = 78
        '
        'InvoiceLine
        '
        Me.InvoiceLine.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.InvoiceLine.Format = ""
        Me.InvoiceLine.FormatInfo = Nothing
        Me.InvoiceLine.HeaderText = "Line #"
        Me.InvoiceLine.MappingName = "InvoiceLine"
        Me.InvoiceLine.Width = 60
        '
        'ToolBar1
        '
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButtonSearch, Me.ToolBarButtonEdit, Me.ToolBarButtonUndo, Me.ToolBarButtonSave})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(23, 22)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.Location = New System.Drawing.Point(1256, 5)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(96, 28)
        Me.ToolBar1.TabIndex = 4
        '
        'ToolBarButtonSearch
        '
        Me.ToolBarButtonSearch.ImageIndex = 21
        Me.ToolBarButtonSearch.ToolTipText = "Search"
        '
        'ToolBarButtonEdit
        '
        Me.ToolBarButtonEdit.ImageIndex = 39
        Me.ToolBarButtonEdit.ToolTipText = "Edit"
        '
        'ToolBarButtonUndo
        '
        Me.ToolBarButtonUndo.ImageIndex = 14
        Me.ToolBarButtonUndo.ToolTipText = "Undo"
        '
        'ToolBarButtonSave
        '
        Me.ToolBarButtonSave.ImageIndex = 31
        Me.ToolBarButtonSave.ToolTipText = "Save"
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'dtpCommissionDate
        '
        Me.dtpCommissionDate.CalendarMonthBackground = System.Drawing.Color.SkyBlue
        Me.dtpCommissionDate.Location = New System.Drawing.Point(132, 14)
        Me.dtpCommissionDate.Name = "dtpCommissionDate"
        Me.dtpCommissionDate.ShowCheckBox = True
        Me.dtpCommissionDate.Size = New System.Drawing.Size(256, 20)
        Me.dtpCommissionDate.TabIndex = 38
        '
        'dtpSalesCycleDate
        '
        Me.dtpSalesCycleDate.CalendarMonthBackground = System.Drawing.Color.SkyBlue
        Me.dtpSalesCycleDate.Location = New System.Drawing.Point(132, 38)
        Me.dtpSalesCycleDate.Name = "dtpSalesCycleDate"
        Me.dtpSalesCycleDate.ShowCheckBox = True
        Me.dtpSalesCycleDate.Size = New System.Drawing.Size(256, 20)
        Me.dtpSalesCycleDate.TabIndex = 39
        '
        'dtpMdiCycleDate
        '
        Me.dtpMdiCycleDate.CalendarMonthBackground = System.Drawing.Color.SkyBlue
        Me.dtpMdiCycleDate.Location = New System.Drawing.Point(132, 62)
        Me.dtpMdiCycleDate.Name = "dtpMdiCycleDate"
        Me.dtpMdiCycleDate.ShowCheckBox = True
        Me.dtpMdiCycleDate.Size = New System.Drawing.Size(256, 20)
        Me.dtpMdiCycleDate.TabIndex = 40
        '
        'dtpMdiSalesDate
        '
        Me.dtpMdiSalesDate.CalendarMonthBackground = System.Drawing.Color.SkyBlue
        Me.dtpMdiSalesDate.Location = New System.Drawing.Point(132, 86)
        Me.dtpMdiSalesDate.Name = "dtpMdiSalesDate"
        Me.dtpMdiSalesDate.ShowCheckBox = True
        Me.dtpMdiSalesDate.Size = New System.Drawing.Size(256, 20)
        Me.dtpMdiSalesDate.TabIndex = 41
        '
        'SalesAdjustments
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1362, 698)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SalesAdjustments"
        Me.Text = "SalesAdjustments"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.HeaderDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.CustomerTab.ResumeLayout(False)
        Me.GroupBox34.ResumeLayout(False)
        Me.GroupBox32.ResumeLayout(False)
        Me.GroupBox33.ResumeLayout(False)
        Me.GroupBox31.ResumeLayout(False)
        Me.InvoiceTab.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ItemTab.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox30.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.Misc.ResumeLayout(False)
        Me.GroupBox24.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.Crediting.ResumeLayout(False)
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.Filter.ResumeLayout(False)
        Me.GroupBox18.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.InvoiceDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.LineItemDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Enum UseMode
        DefaultMode = -1
        SearchMode = 0
        EditMode = 1
    End Enum

    Private _commissionDate As Date
    Private _custCode As String
    Private _referenceCode As String
    Private _referenceDate As Date
    Private _intsRowid As Integer
    Private _lastHeaderDataGridWhereClause As String
    Private _customHeaderDataGridWhereClause As String
    Private _lastHeaderRow As Integer
    Private _lastInvoiceRow As Integer
    Private _lastLineItemRow As Integer
    Private _headerDataGridView As DataView
    Private _invoiceDataGridView As DataView
    Private _lineItemDataGridView As DataView
    Private _userMode As Integer

    Public Property UserMode() As Integer
        Get
            Return _userMode
        End Get
        Set(ByVal Value As Integer)
            _userMode = Value
        End Set
    End Property

    Public Property HeaderDataGridView() As DataView
        Get
            Return _headerDataGridView
        End Get
        Set(ByVal Value As DataView)
            _headerDataGridView = Value
        End Set
    End Property

    Public Property InvoiceDataGridView() As DataView
        Get
            Return _invoiceDataGridView
        End Get
        Set(ByVal Value As DataView)
            _invoiceDataGridView = Value
        End Set
    End Property

    Public Property LineItemDataGridView() As DataView
        Get
            Return _lineItemDataGridView
        End Get
        Set(ByVal Value As DataView)
            _lineItemDataGridView = Value
        End Set
    End Property

    Public Property LastLineItemRow() As Integer
        Get
            Return _lastLineItemRow
        End Get
        Set(ByVal Value As Integer)
            _lastLineItemRow = Value
        End Set
    End Property

    Public Property LastInvoiceRow() As Integer
        Get
            Return _lastInvoiceRow
        End Get
        Set(ByVal Value As Integer)
            _lastInvoiceRow = Value
        End Set
    End Property

    Public Property LastHeaderRow() As Integer
        Get
            Return _lastHeaderRow
        End Get
        Set(ByVal Value As Integer)
            _lastHeaderRow = Value
        End Set
    End Property

    Public Property CustomHeaderDataGridWhereClause() As String
        Get
            Return _customHeaderDataGridWhereClause
        End Get
        Set(ByVal Value As String)
            _customHeaderDataGridWhereClause = Value
        End Set
    End Property

    Public Property lastHeaderDataGridWhereClause() As String
        Get
            Return _lastHeaderDataGridWhereClause
        End Get
        Set(ByVal Value As String)
            _lastHeaderDataGridWhereClause = Value
        End Set
    End Property

    Public Property IntsRowid() As Integer
        Get
            Return _intsRowid
        End Get
        Set(ByVal Value As Integer)
            _intsRowid = Value
        End Set
    End Property

    Public Property ReferenceDate() As Date
        Get
            Return _referenceDate
        End Get
        Set(ByVal Value As Date)
            _referenceDate = Value
        End Set
    End Property

    Public Property ReferenceCode() As String
        Get
            Return _referenceCode
        End Get
        Set(ByVal Value As String)
            _referenceCode = Value
        End Set
    End Property

    Public Property CustCode() As String
        Get
            Return _custCode
        End Get
        Set(ByVal Value As String)
            _custCode = Value
        End Set
    End Property

    Public Property CommissionDate() As Date
        Get
            Return _commissionDate
        End Get
        Set(ByVal Value As Date)
            _commissionDate = Value
        End Set
    End Property

    Private Sub SalesAdjustments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LastHeaderRow = -1
        Me.LastInvoiceRow = -1
        Me.LastLineItemRow = -1
        Me.UserMode = UseMode.DefaultMode
        Load_HeaderDataGrid("SalesAdjustments_GetHeaderInfo")
        EnableTextFields(False)
        EnableToolBarButtons("Undo", False) : EnableToolBarButtons("Save", False)

    End Sub

    Private Sub Load_HeaderDataGrid(ByVal StoredProcedure As String, _
    Optional ByVal CustomerCodeName As String = "SalesAdjustments_GetHeaderInfo_Filter")
        Try
            'Retrieve the data from the database
            DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
            DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
            DataMaintenance.myParamArray(0, 2) = 10
            DataMaintenance.myParamArray(0, 3) = ParameterDirection.Input
            DataMaintenance.myParamArray(0, 4) = "Date"
            DataMaintenance.myParamArray(0, 5) = "8/1/2013"
            Me.CommissionDate = CDate("8/1/2013")
            Dim myReader As SqlDataReader
            If StoredProcedure = "SalesAdjustments_GetHeaderInfo" Then
                myReader = DataMaintenance.GetResultSet(ServerPath2, StoredProcedure, CommandType.StoredProcedure, 1)
            Else
                DataMaintenance.myParamArray(1, 0) = "@CustomerCodeName"
                DataMaintenance.myParamArray(1, 1) = SqlDbType.VarChar
                DataMaintenance.myParamArray(1, 2) = 500
                DataMaintenance.myParamArray(1, 3) = ParameterDirection.Input
                DataMaintenance.myParamArray(1, 4) = "String"
                DataMaintenance.myParamArray(1, 5) = txtSearchCustomerName.Text
                myReader = DataMaintenance.GetResultSet(ServerPath2, StoredProcedure, CommandType.StoredProcedure, 2)
            End If

            'Prepare the datagrid columns
            Dim dt As New DataTable
            Dim dr As DataRow
            Dim stringType As Type = GetType(String)

            With dt.Columns
                .Add("CustomerDr", stringType)
                .Add("CustomerCode", stringType)
                .Add("CustomerName", stringType)
                .Add("Address1", stringType)
                .Add("Address2", stringType)
                '.Add("ShipTo", stringType)
            End With

            'Populate grid from values in resultset
            With myReader
                If .HasRows() Then
                    While .Read()
                        dr = dt.NewRow()
                        dr("CustomerDr") = CInt(myReader("CustomerDr"))
                        dr("CustomerCode") = CStr(myReader("CustomerCode"))
                        dr("CustomerName") = CStr(myReader("CustomerName"))
                        dr("Address1") = CStr(myReader("Address1"))
                        dr("Address2") = CStr(myReader("Address2"))
                        'dr("ShipTo") = CStr(myReader("Address2"))
                        dt.Rows.Add(dr)
                    End While
                End If
            End With

            Dim dv As DataView = New DataView(dt)
            HeaderDataGrid.DataSource = dv
            Me.HeaderDataGridView = dv
            UpdateGroupBoxCount(GroupBox1, dv.Count)
            If dv.Count > 0 And Me.LastHeaderRow = -1 Then
                HeaderDataGrid.Select(0)
            Else
                HeaderDataGrid.Select(Me.LastHeaderRow)
            End If

            SelectCurrentHeaderRow()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Load_HeaderDataGrid()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub HeaderDataGrid_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles HeaderDataGrid.CurrentCellChanged

        Me.CustCode = CStr(HeaderDataGrid.Item(HeaderDataGrid.CurrentRowIndex, 1))
        Load_InvoiceDataGrid()
        HeaderDataGrid.Select(HeaderDataGrid.CurrentRowIndex)
        Me.LastHeaderRow = HeaderDataGrid.CurrentRowIndex

        Dim EmptyEventArgs As System.EventArgs = System.EventArgs.Empty
        InvoiceDataGrid_CurrentCellChanged(InvoiceDataGrid, EmptyEventArgs)

        'Indicate the position of the pointer
        GroupBox1.Text = "Customer(" & (HeaderDataGrid.CurrentRowIndex + 1).ToString() & " of " & Me.HeaderDataGridView.Count.ToString() & ")"
    End Sub

    Private Sub Load_InvoiceDataGrid()
        Try
            'Retrieve the data from the database
            DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
            DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
            DataMaintenance.myParamArray(0, 2) = 10
            DataMaintenance.myParamArray(0, 3) = ParameterDirection.Input
            DataMaintenance.myParamArray(0, 4) = "Date"
            DataMaintenance.myParamArray(0, 5) = "8/1/2013"

            DataMaintenance.myParamArray(1, 0) = "@CustomerCode"
            DataMaintenance.myParamArray(1, 1) = SqlDbType.VarChar
            DataMaintenance.myParamArray(1, 2) = 8
            DataMaintenance.myParamArray(1, 3) = ParameterDirection.Input
            DataMaintenance.myParamArray(1, 4) = "String"
            DataMaintenance.myParamArray(1, 5) = Me.CustCode

            Dim myReader As SqlDataReader = DataMaintenance.GetResultSet(ServerPath2, "SalesAdjustments_GetInvoiceInfo", CommandType.StoredProcedure, 2)

            'Prepare the columns
            Dim dt As New DataTable
            Dim dr As DataRow
            Dim stringType As Type = GetType(String)
            With dt
                .Columns.Add("RefCode", stringType)
                .Columns.Add("RefDate", stringType)
            End With

            'Populate the grid
            With myReader
                If .HasRows Then
                    While .Read()
                        dr = dt.NewRow()
                        dr("RefCode") = CStr(myReader("RefCode"))
                        dr("RefDate") = CStr(myReader("RefDate"))
                        dt.Rows.Add(dr)
                    End While
                End If
            End With

            Dim dv As DataView = New DataView(dt)
            InvoiceDataGrid.DataSource = dv
            Me.InvoiceDataGridView = dv
            UpdateGroupBoxCount(GroupBox2, dv.Count)

            If dv.Count > 0 Then
                InvoiceDataGrid.Select(0)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Load_InvoiceDataGrid()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub InvoiceDataGrid_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles InvoiceDataGrid.CurrentCellChanged
        InvoiceDataGrid.Select(InvoiceDataGrid.CurrentRowIndex)
        Me.ReferenceCode = CStr(InvoiceDataGrid.Item(InvoiceDataGrid.CurrentRowIndex, 0))
        Me.ReferenceDate = CDate(InvoiceDataGrid.Item(InvoiceDataGrid.CurrentRowIndex, 1))
        Load_LineItemDataGrid()
        Me.LastInvoiceRow = InvoiceDataGrid.CurrentRowIndex

        InvoiceDataGrid.Select(InvoiceDataGrid.CurrentRowIndex)

        Dim EmptyEventArgs As System.EventArgs = System.EventArgs.Empty
        LineItemDataGrid_CurrentCellChanged(LineItemDataGrid, EmptyEventArgs)

        'Indicate the position of the pointer
        GroupBox2.Text = "Invoice(" & (InvoiceDataGrid.CurrentRowIndex + 1).ToString() & " of " & Me.InvoiceDataGridView.Count.ToString() & ")"
    End Sub

    Private Sub Load_LineItemDataGrid()

        Try
            'Retrieve the data from the database
            DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
            DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
            DataMaintenance.myParamArray(0, 2) = 10
            DataMaintenance.myParamArray(0, 3) = ParameterDirection.Input
            DataMaintenance.myParamArray(0, 4) = "Date"
            DataMaintenance.myParamArray(0, 5) = Me.CommissionDate

            DataMaintenance.myParamArray(1, 0) = "@CustomerCode"
            DataMaintenance.myParamArray(1, 1) = SqlDbType.VarChar
            DataMaintenance.myParamArray(1, 2) = 8
            DataMaintenance.myParamArray(1, 3) = ParameterDirection.Input
            DataMaintenance.myParamArray(1, 4) = "String"
            DataMaintenance.myParamArray(1, 5) = Me.CustCode

            DataMaintenance.myParamArray(2, 0) = "@RefCode"
            DataMaintenance.myParamArray(2, 1) = SqlDbType.VarChar
            DataMaintenance.myParamArray(2, 2) = 10
            DataMaintenance.myParamArray(2, 3) = ParameterDirection.Input
            DataMaintenance.myParamArray(2, 4) = "String"
            DataMaintenance.myParamArray(2, 5) = Me.ReferenceCode

            DataMaintenance.myParamArray(3, 0) = "@RefDate"
            DataMaintenance.myParamArray(3, 1) = SqlDbType.DateTime
            DataMaintenance.myParamArray(3, 2) = 10
            DataMaintenance.myParamArray(3, 3) = ParameterDirection.Input
            DataMaintenance.myParamArray(3, 4) = "Date"
            DataMaintenance.myParamArray(3, 5) = Me.ReferenceDate

            Dim myReader As SqlDataReader = DataMaintenance.GetResultSet(ServerPath2, "SalesAdjustments_GetLineItems", CommandType.StoredProcedure, 4)

            'Prepare the datagrid columns
            Dim dt As New DataTable
            Dim dr As DataRow
            Dim stringType As Type = GetType(String)
            With dt
                .Columns.Add("Rowid", stringType)
                .Columns.Add("ItemCode", stringType)
                .Columns.Add("ItemDesc", stringType)
                .Columns.Add("QtySold", stringType)
                .Columns.Add("QtyFree", stringType)
                .Columns.Add("UnitPrice", stringType)
                .Columns.Add("CreditedAmount", stringType)
                .Columns.Add("InvoiceLine", stringType)
            End With

            'Populate the grid
            Threading.Thread.CurrentThread.CurrentCulture = New CultureInfo("en-us")
            With myReader
                If .HasRows Then
                    While .Read
                        dr = dt.NewRow()
                        dr("Rowid") = CStr(myReader("Rowid"))
                        dr("ItemCode") = CStr(myReader("ItemCode"))
                        dr("ItemDesc") = CStr(myReader("ItemDesc"))
                        dr("QtySold") = CInt(myReader("QtySold")).ToString()
                        dr("QtyFree") = CInt(myReader("QtyFree")).ToString()
                        dr("UnitPrice") = CDbl(myReader("UnitPrice")).ToString("N")
                        dr("CreditedAmount") = CDbl(myReader("CreditedAmount")).ToString("N")
                        dr("InvoiceLine") = CStr(myReader("InvoiceLine"))
                        dt.Rows.Add(dr)
                    End While
                End If
                Dim dv As DataView = New DataView(dt)
                LineItemDataGrid.DataSource = dv
                Me.LineItemDataGridView = dv

                UpdateGroupBoxCount(GroupBox3, dv.Count)

                If dv.Count > 0 Then
                    LineItemDataGrid.Select(0)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Load_LineItemDataGrid()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub LineItemDataGrid_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LineItemDataGrid.CurrentCellChanged

        LineItemDataGrid.Select(LineItemDataGrid.CurrentRowIndex)
        Me.IntsRowid = CInt(LineItemDataGrid.Item(LineItemDataGrid.CurrentRowIndex, 0))
        Load_FullRow()
        Me.LastLineItemRow = LineItemDataGrid.CurrentRowIndex

        'Indicate the position of the pointer
        GroupBox3.Text = "Line Item(s)(" & (LineItemDataGrid.CurrentRowIndex + 1).ToString() & " of " & Me.LineItemDataGridView.Count.ToString() & ")"

    End Sub

    Private Sub Load_FullRow()
        Try
            'Retrieve the data from the database
            DataMaintenance.myParamArray(0, 0) = "@Rowid"
            DataMaintenance.myParamArray(0, 1) = SqlDbType.Int
            DataMaintenance.myParamArray(0, 2) = 4
            DataMaintenance.myParamArray(0, 3) = ParameterDirection.Input
            DataMaintenance.myParamArray(0, 4) = "Integer"
            DataMaintenance.myParamArray(0, 5) = Me.IntsRowid

            Dim myReader As SqlDataReader
            myReader = DataMaintenance.GetResultSet(ServerPath2, "SalesAdjustments_GetFullRow", CommandType.StoredProcedure, 1)
            With myReader
                If .HasRows Then
                    While .Read
                        'Customer Tab
                        txtRowid.Text = ParseValue(myReader, "Rowid", "String")
                        txtCustomerDr.Text = ParseValue(myReader, "CustomerDr", "String")
                        txtCustomerCode.Text = ParseValue(myReader, "CustomerCode", "String")
                        txtCustomerName.Text = ParseValue(myReader, "CustomerName", "String")
                        txtAddress1.Text = ParseValue(myReader, "Address1", "String")
                        txtAddress2.Text = ParseValue(myReader, "Address2", "String")
                        txtCustomerType.Text = ParseValue(myReader, "CustomerType", "String")
                        txtShipTo.Text = ParseValue(myReader, "ShipTo", "String")
                        txtShipAddress1.Text = ParseValue(myReader, "ShipAddress1", "String")
                        txtShipAddress2.Text = ParseValue(myReader, "ShipAddress2", "String")
                        txtTerritoryDr.Text = ParseValue(myReader, "TerritoryDr", "String")
                        txtTerritory.Text = ParseValue(myReader, "Territory", "String")
                        txtProvinceDr.Text = ParseValue(myReader, "ProvinceDr", "String")
                        txtProvince.Text = ParseValue(myReader, "Province", "String")
                        txtGroupDr.Text = ParseValue(myReader, "GroupDr", "String")
                        txtGroup.Text = ParseValue(myReader, "Group", "String")
                        txtIslandGroup.Text = ParseValue(myReader, "IslandGroup", "String")
                        'Invoice Tab
                        txtRefCode.Text = ParseValue(myReader, "RefCode", "String")
                        txtRefDate.Text = ParseValue(myReader, "RefDate", "String")
                        txtDiscRate.Text = ParseValue(myReader, "DiscRate", "String")
                        txtDiscount.Text = ParseValue(myReader, "Discount", "Money")
                        txtVatCode.Text = ParseValue(myReader, "VatCode", "String")
                        txtVat.Text = ParseValue(myReader, "Vat", "String")
                        txtTax.Text = ParseValue(myReader, "Tax", "Money")
                        txtValueAmount.Text = ParseValue(myReader, "ValueAmount", "Money")
                        txtInvoiceLine.Text = ParseValue(myReader, "InvoiceLine", "String")
                        txtCmRefInvoice.Text = ParseValue(myReader, "CmRefInvoice", "String")
                        txtCmRefDate.Text = ParseValue(myReader, "CmRefDate", "String")
                        txtCmRefQtySold.Text = ParseValue(myReader, "CmRefQtySold", "String")
                        txtCmRefQtyFree.Text = ParseValue(myReader, "CmRefQtyFree", "String")
                        txtCmRefPrice.Text = ParseValue(myReader, "CmRefPrice", "String")
                        txtCmRefAmount.Text = ParseValue(myReader, "CmRefAmount", "String")
                        txtCmRefItemCode.Text = ParseValue(myReader, "CmRefItemCode", "String")
                        txtCmRefItemDesc.Text = ParseValue(myReader, "CmRefItemDesc", "String")
                        txtOldCmCode.Text = ParseValue(myReader, "OldCmCode", "String")
                        txtOldCmRefInvoice.Text = ParseValue(myReader, "OldCmRefInvoice", "String")
                        txtOldCmRefDate.Text = ParseValue(myReader, "OldCmRefDate", "String")
                        txtCmCode.Text = ParseValue(myReader, "CmCode", "String")
                        txtSoCode.Text = ParseValue(myReader, "SoCode", "String")
                        txtSoDate.Text = ParseValue(myReader, "SoDate", "String")
                        'Item Tab
                        txtItemCode.Text = ParseValue(myReader, "ItemCode", "String")
                        txtItemDesc.Text = ParseValue(myReader, "ItemDesc", "String")
                        txtPrincipalCode.Text = ParseValue(myReader, "PrincipalCode", "String")
                        txtPrincipalDesc.Text = ParseValue(myReader, "PrincipalDesc", "String")
                        txtDivisionCode.Text = ParseValue(myReader, "DivisionCode", "String")
                        txtDivisionDesc.Text = ParseValue(myReader, "DivisionDesc", "String")
                        txtCompany.Text = ParseValue(myReader, "Company", "String")
                        txtDistributor.Text = ParseValue(myReader, "Distributor", "String")
                        txtQtySold.Text = ParseValue(myReader, "QtySold", "Integer")
                        txtQtyFree.Text = ParseValue(myReader, "QtyFree", "Integer")
                        txtUnitPrice.Text = ParseValue(myReader, "UnitPrice", "Money")
                        txtAmountSold.Text = ParseValue(myReader, "AmountSold", "Money")
                        txtCreditedAmount.Text = ParseValue(myReader, "CreditedAmount", "Money")
                        txtOutOfStock.Text = ParseValue(myReader, "OutOfStock", "String")
                        txtDist_Code.Text = ParseValue(myReader, "Dist_Code", "String")
                        txtSubDist_Code.Text = ParseValue(myReader, "SubDist_Code", "String")
                        txtLotNumber.Text = ParseValue(myReader, "LotNumber", "String")
                        txtExpiryDate.Text = ParseValue(myReader, "ExpiryDate", "String")
                        txtQtyConverted.Text = ParseValue(myReader, "QtyConverted", "String")
                        txtQtyLoose.Text = ParseValue(myReader, "QtyLoose", "String")
                        txtCurrentDivision.Text = ParseValue(myReader, "CurrentDivision", "String")
                        'Crediting Tab
                        txtMrDivision.Text = ParseValue(myReader, "MrDivision", "String")
                        txtMrCode.Text = ParseValue(myReader, "MrCode", "String")
                        txtMrName.Text = ParseValue(myReader, "MrName", "String")
                        txtSupCode.Text = ParseValue(myReader, "SupCode", "String")
                        txtSupName.Text = ParseValue(myReader, "SupName", "String")
                        txtNsmCode.Text = ParseValue(myReader, "NsmCode", "String")
                        txtNsmName.Text = ParseValue(myReader, "NsmName", "String")
                        txtPmCode.Text = ParseValue(myReader, "PmCode", "String")
                        txtPmName.Text = ParseValue(myReader, "PmName", "String")
                        txtKasGovCode.Text = ParseValue(myReader, "KasGovCode", "String")
                        txtKasGovName.Text = ParseValue(myReader, "KasGovName", "String")
                        txtModTradeDsmCode.Text = ParseValue(myReader, "ModTradeDsmCode", "String")
                        txtModTradeDsmName.Text = ParseValue(myReader, "ModTradeDsmName", "String")
                        txtFloaterMrCode.Text = ParseValue(myReader, "FloaterMrCode", "String")
                        txtFloaterMrName.Text = ParseValue(myReader, "FloaterMrName", "String")
                        txtQpiAreaCode.Text = ParseValue(myReader, "QpiAreaCode", "String")
                        'Misc Tab
                        If ParseValue(myReader, "CommissionDate", "String") = String.Empty Then
                            dtpCommissionDate.Text = dtpCommissionDate.MinDate.ToString()
                            dtpCommissionDate.Checked = False
                        Else
                            dtpCommissionDate.Text = ParseValue(myReader, "CommissionDate", "String")
                            dtpCommissionDate.Checked = True
                        End If

                        If ParseValue(myReader, "SalesCycleDate", "String") = String.Empty Then
                            dtpSalesCycleDate.Text = dtpSalesCycleDate.MinDate.ToString()
                            dtpSalesCycleDate.Checked = False
                        Else
                            dtpSalesCycleDate.Text = ParseValue(myReader, "SalesCycleDate", "String")
                            dtpSalesCycleDate.Checked = True
                        End If

                        If ParseValue(myReader, "MdiCycleDate", "String") = String.Empty Then
                            dtpMdiCycleDate.Text = dtpMdiCycleDate.MinDate.ToString()
                            dtpMdiCycleDate.Checked = False
                        Else
                            dtpMdiCycleDate.Text = ParseValue(myReader, "MdiCycleDate", "String")
                            dtpMdiCycleDate.Checked = True
                        End If

                        If ParseValue(myReader, "MdiSalesDate", "String") = String.Empty Then
                            dtpMdiSalesDate.Value = dtpMdiSalesDate.MinDate
                            dtpMdiSalesDate.Checked = False
                        Else
                            dtpMdiSalesDate.Text = ParseValue(myReader, "MdiSalesDate", "String")
                            dtpMdiSalesDate.Checked = True
                        End If

                        txtSaleType.Text = ParseValue(myReader, "SaleType", "String")
                        txtTransactionType.Text = ParseValue(myReader, "TransactionType", "String")
                        txtSubSaleType.Text = ParseValue(myReader, "SubSaleType", "String")
                        txtSalesClass.Text = ParseValue(myReader, "SalesClass", "String")
                        txtExcessSales.Text = ParseValue(myReader, "ExcessSales", "String")
                        txtExcludeAttachment.Text = ParseValue(myReader, "ExcludeAttachment", "String")
                        txtMdsDr.Text = ParseValue(myReader, "MdsDr", "String")
                        txtNavTag.Text = ParseValue(myReader, "NavTag", "String")
                        txtCreate_Date.Text = ParseValue(myReader, "Create_Date", "String")
                        txtCreateDate.Text = ParseValue(myReader, "CreateDate", "String")
                        txtUpdateDate.Text = ParseValue(myReader, "UpdateDate", "String")

                    End While
                End If
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Load_FullRow()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ParseValue(ByVal DataReader As SqlDataReader, ByVal ColumnName As String, ByVal DataType As String) As String

        Select Case DataType
            Case "String"
                Return CStr(IIf(DataReader(ColumnName) Is System.DBNull.Value, "", DataReader(ColumnName)))
            Case "Integer"
                Return CInt(DataReader(ColumnName)).ToString()
            Case "Money"
                Thread.CurrentThread.CurrentCulture = New CultureInfo("en-us")
                Return CDbl(DataReader(ColumnName)).ToString("N")

        End Select

    End Function

    Private Sub txtSearchCustomerName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearchCustomerName.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Reload_HeaderDataGrid()
        End If
    End Sub

    Private Sub Reload_HeaderDataGrid()

        HeaderDataGrid.DataSource = Nothing
        HeaderDataGrid.Refresh()
        'HeaderDataGrid.DataSource = Me.HeaderDataGridView

        If txtSearchCustomerName.Text = String.Empty Then
            Load_HeaderDataGrid("SalesAdjustments_GetHeaderInfo")
        Else
            Load_HeaderDataGrid("SalesAdjustments_GetHeaderInfo_Filter")
        End If

    End Sub

    Private Sub UpdateGroupBoxCount(ByVal GroupBoxControl As GroupBox, ByVal Count As Integer)

        Dim thisLabel As String = String.Empty
        With GroupBoxControl
            Select Case GroupBoxControl.Name
                Case "GroupBox1"
                    thisLabel = "Customer"
                Case "GroupBox2"
                    thisLabel = "Invoice"
                Case "GroupBox3"
                    thisLabel = "Line Item(s)"
            End Select
            .Text = thisLabel & "(" & Count.ToString() & ")"
        End With

    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick

        Select Case e.Button.ToolTipText
            Case "Search"
                ToolBar_Search()
            Case "Edit"
                ToolBar_Edit()
            Case "Undo"
                ToolBar_Undo()
            Case "Save"
                ToolBar_Save()
        End Select

    End Sub

    Private Sub ToolBar_Search()

        Me.UserMode = UseMode.SearchMode
        ClearAllControls()
        EnableToolBarButtons("Search", False) : EnableToolBarButtons("Edit", False) : EnableToolBarButtons("Undo", True)
        EnableTextFields(True)

    End Sub

    Private Sub ToolBar_Edit()

        Me.UserMode = UseMode.EditMode
        EnableGrids(False)
        EnableToolBarButtons("Search", False) : EnableToolBarButtons("Edit", False) : EnableToolBarButtons("Undo", True) : EnableToolBarButtons("Save", True)
        EnableTextFields(True)

    End Sub

    Private Sub ToolBar_Undo()

        If Me.UserMode = UseMode.SearchMode Then
            HeaderDataGrid.DataSource = Me.HeaderDataGridView
        End If
        SelectCurrentHeaderRow()
        EnableToolBarButtons("Search", True) : EnableToolBarButtons("Edit", True) : EnableToolBarButtons("Undo", False) : EnableToolBarButtons("Save", False)
        EnableTextFields(False)
        EnableGrids(True)

        Me.UserMode = UseMode.DefaultMode

        'If Me.CustomHeaderDataGridWhereClause = String.Empty Then
        '    Reload_HeaderDataGrid()
        'Else

        'End If

    End Sub

    Private Sub ToolBar_Save()

    End Sub

    Private Sub ClearAllControls()

        'Clear all data from the grids
        For Each thisGroupBox As Control In Me.Controls
            If TypeOf (thisGroupBox) Is GroupBox Then
                For Each thisDataGrid As Control In thisGroupBox.Controls
                    If TypeOf (thisDataGrid) Is DataGrid Then
                        DirectCast(thisDataGrid, DataGrid).DataSource = Nothing
                        DirectCast(thisDataGrid, DataGrid).Refresh()
                    End If
                Next
            End If
        Next

        'Clear all values from the text fields
        For Each thisTabPage As TabPage In TabControl1.TabPages
            For Each thisControl As Control In thisTabPage.Controls
                If TypeOf (thisControl) Is GroupBox Then
                    For Each thisTextBox As Control In thisControl.Controls
                        If TypeOf (thisTextBox) Is TextBox Then
                            thisTextBox.Text = String.Empty
                        End If
                    Next
                End If
            Next
        Next

        'Reset Data Count
        GroupBox1.Text = "Customer"
        GroupBox2.Text = "Invoice"
        GroupBox3.Text = "Line Item(s)"

    End Sub

    Private Sub EnableGrids(ByVal enable As Boolean)

        'For all data grids
        For Each thisGroupBox As Control In Me.Controls
            If TypeOf (thisGroupBox) Is GroupBox Then
                For Each thisDataGrid As Control In thisGroupBox.Controls
                    If TypeOf (thisDataGrid) Is DataGrid Then
                        DirectCast(thisDataGrid, DataGrid).Enabled = enable
                    End If
                Next
            End If
        Next

    End Sub

    Private Sub EnableTextFields(ByVal enable As Boolean)

        'For all text fields
        For Each thisTabPage As TabPage In TabControl1.TabPages
            For Each thisControl As Control In thisTabPage.Controls
                If TypeOf (thisControl) Is GroupBox Then
                    For Each thisTextBox As Control In thisControl.Controls
                        If TypeOf (thisTextBox) Is TextBox Then
                            thisTextBox.Enabled = enable
                        End If
                    Next
                End If
            Next
        Next

    End Sub

    Private Sub EnableToolBarButtons(ByVal toolBarButton As String, ByVal enable As Boolean)

        'For toolbar buttons
        For Each thisToolBarButton As ToolBarButton In ToolBar1.Buttons
            If thisToolBarButton.ToolTipText = toolBarButton Then
                thisToolBarButton.Enabled = enable
            End If
        Next

    End Sub

    Private Sub PointToLastSelected()

        'Header DataGrid
        HeaderDataGrid.Select(Me.LastHeaderRow)

        'Invoice DataGrid
        InvoiceDataGrid.Select(Me.LastInvoiceRow)

        'LineItem DataGrid
        LineItemDataGrid.Select(Me.LastLineItemRow)

    End Sub

    Private Sub SelectCurrentHeaderRow()

        Dim EmptyEventArgs As System.EventArgs = System.EventArgs.Empty
        HeaderDataGrid_CurrentCellChanged(HeaderDataGrid, EmptyEventArgs)

    End Sub

    Private Sub CustomerLinkLabel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CustomerLinkLabel.Click

        Dim thisForm As New CustomerCT
        thisForm.ShowDialog(Me)

        With thisForm
            'Customer Info Tab
            txtCustomerDr.Text = .txtRowid.Text
            txtCustomerCode.Text = .txtCode.Text
            txtCustomerName.Text = .txtDescription.Text
            txtAddress1.Text = .txtAddress1.Text
            txtAddress2.Text = .txtAddress2.Text
            txtCustomerType.Text = .cboType.Text
            txtCustomerType.Tag = .tmpType

            'Territory Tab
            Dim thisTerritory As String
            thisTerritory = CStr(IIf(.cboTerritoryDR.Text <> String.Empty, thisForm.cboTerritoryDR.Text.Substring(0, thisForm.cboTerritoryDR.Text.IndexOf("-")), String.Empty))
            If thisTerritory = String.Empty Then
                txtTerritoryDr.Text = ""
                txtTerritory.Text = ""
                txtProvinceDr.Text = ""
                txtProvince.Text = ""
                txtGroupDr.Text = ""
                txtGroup.Text = ""
                txtIslandGroup.Text = ""
            Else
                Dim mySqlDataReader As SqlDataReader
                mySqlDataReader = GetTerritoryInfo(thisTerritory)

                With mySqlDataReader
                    If .HasRows Then
                        While .Read()
                            txtTerritoryDr.Text = CStr(mySqlDataReader("TerRowid"))
                            txtTerritory.Text = CStr(mySqlDataReader("Territory"))
                            txtProvinceDr.Text = CStr(mySqlDataReader("ProRowid"))
                            txtProvince.Text = CStr(mySqlDataReader("Province"))
                            txtGroupDr.Text = CStr(mySqlDataReader("GroRowid"))
                            txtGroup.Text = CStr(mySqlDataReader("Group"))
                            txtIslandGroup.Text = CStr(mySqlDataReader("IslandGroup"))
                        End While
                    End If
                End With
            End If

        End With

    End Sub

    Private Function GetTerritoryInfo(ByVal TerritoryCode As String) As SqlDataReader

        Dim mySqlDataReader As SqlDataReader
        Try
            DataMaintenance.myParamArray(0, 0) = "@TerritoryCode"
            DataMaintenance.myParamArray(0, 1) = SqlDbType.VarChar
            DataMaintenance.myParamArray(0, 2) = 50
            DataMaintenance.myParamArray(0, 3) = ParameterDirection.Input
            DataMaintenance.myParamArray(0, 4) = "String"
            DataMaintenance.myParamArray(0, 5) = TerritoryCode

            mySqlDataReader = DataMaintenance.GetResultSet(ServerPath2, "SalesAdjustments_GetTerritoryInfo", CommandType.StoredProcedure, 1)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "GetTerritoryInfo()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return mySqlDataReader

    End Function

    Private Sub SalesAdjustments_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint

        If txtCustomerDr.Enabled = True And txtCustomerDr.Modified = True Then
            txtCustomerDr.BackColor = System.Drawing.Color.Cyan
        End If

    End Sub

    Private Sub txtCustomerDr_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCustomerDr.TextChanged

        'If String.Empty < txtCustomerDr.Text Then
        '    txtCustomerDr.Modified = True
        'Else
        '    txtCustomerDr.Modified = False
        'End If

    End Sub


    Private Sub ItemLinkLabel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItemLinkLabel.Click

        Dim thisForm As New ItemCT
        thisForm.ShowDialog(Me)

        With thisForm
            txtItemCode.Text = CStr(.DG_items.Item(.DG_items.CurrentRowIndex, 1))
            txtItemDesc.Text = CStr(.DG_items.Item(.DG_items.CurrentRowIndex, 4))
            txtPrincipalCode.Text = CStr(.DG_items.Item(.DG_items.CurrentRowIndex, 10))
            txtPrincipalDesc.Text = CStr(thisForm.DG_items.Item(thisForm.DG_items.CurrentRowIndex, 11)).Substring(CStr(thisForm.DG_items.Item(thisForm.DG_items.CurrentRowIndex, 11)).LastIndexOf("-") + 1)
            txtDivisionCode.Text = CStr(.DG_items.Item(.DG_items.CurrentRowIndex, 12))
            txtDivisionDesc.Text = CStr(thisForm.DG_items.Item(thisForm.DG_items.CurrentRowIndex, 13)).Substring(CStr(thisForm.DG_items.Item(thisForm.DG_items.CurrentRowIndex, 13)).LastIndexOf("-") + 1)
        End With

    End Sub
End Class