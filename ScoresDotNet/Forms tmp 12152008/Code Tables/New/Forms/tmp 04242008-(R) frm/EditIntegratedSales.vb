Imports System.Data.SqlClient
Imports Microsoft
Public Class EditIntegratedSales
    Inherits System.Windows.Forms.Form
    Private RemoteDataSet As New CodeTablesDS
    Private EditMode As Boolean = False
    Public SearchString As String

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Sub_Show()
        Load_Customer()
        Load_Territory()
        Load_Province()
        Load_Group()
        Load_Medrep()
        Load_Dsm()
        Load_Nsm()
        Load_Division()
        Load_Principal()
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
    Friend WithEvents cboCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents cboTerritory As System.Windows.Forms.ComboBox
    Friend WithEvents cboProvince As System.Windows.Forms.ComboBox
    Friend WithEvents cboGroup As System.Windows.Forms.ComboBox
    Friend WithEvents cboNsm As System.Windows.Forms.ComboBox
    Friend WithEvents cboDSM As System.Windows.Forms.ComboBox
    Friend WithEvents cboMedrep As System.Windows.Forms.ComboBox
    Friend WithEvents cboPrincipal As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboDivision As System.Windows.Forms.ComboBox
    Friend WithEvents cboItem As System.Windows.Forms.ComboBox
    Friend WithEvents txtRefCode As System.Windows.Forms.TextBox
    Friend WithEvents txtQtySold As System.Windows.Forms.TextBox
    Friend WithEvents txtQtyFree As System.Windows.Forms.TextBox
    Friend WithEvents txtUnitPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtCreditedAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtAmountSold As System.Windows.Forms.TextBox
    Friend WithEvents cboSubSubSaleType As System.Windows.Forms.ComboBox
    Friend WithEvents cboSubSaleType As System.Windows.Forms.ComboBox
    Friend WithEvents cboSaleType As System.Windows.Forms.ComboBox
    Friend WithEvents cboClass As System.Windows.Forms.ComboBox
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
    Friend WithEvents datagrid1 As System.Windows.Forms.DataGrid
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
    Friend WithEvents txtRowid As System.Windows.Forms.TextBox
    Friend WithEvents lblUpdateDate As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn22 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn23 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn24 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn25 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn26 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn27 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn28 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents cboOs As System.Windows.Forms.ComboBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtDynamic As System.Windows.Forms.TextBox
    Friend WithEvents dtRefDate As System.Windows.Forms.TextBox
    Friend WithEvents dtCommissionDate As System.Windows.Forms.TextBox
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdGo As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(EditIntegratedSales))
        Me.datagrid1 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
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
        Me.DataGridTextBoxColumn22 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn23 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn24 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn25 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn26 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn27 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn28 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.cboCustomer = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtAddress1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtAddress2 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cboTerritory = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cboProvince = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cboGroup = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cboNsm = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cboDSM = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cboMedrep = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.cboPrincipal = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cboDivision = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.cboItem = New System.Windows.Forms.ComboBox
        Me.txtRefCode = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtQtySold = New System.Windows.Forms.TextBox
        Me.txtQtyFree = New System.Windows.Forms.TextBox
        Me.txtUnitPrice = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtCreditedAmount = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtAmountSold = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.cboSubSubSaleType = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.cboSubSaleType = New System.Windows.Forms.ComboBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.cboSaleType = New System.Windows.Forms.ComboBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.cboClass = New System.Windows.Forms.ComboBox
        Me.txtRowid = New System.Windows.Forms.TextBox
        Me.lblUpdateDate = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.cboOs = New System.Windows.Forms.ComboBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.txtDynamic = New System.Windows.Forms.TextBox
        Me.dtCommissionDate = New System.Windows.Forms.TextBox
        Me.dtRefDate = New System.Windows.Forms.TextBox
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmdSearch = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdGo = New System.Windows.Forms.Button
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
        Me.datagrid1.Location = New System.Drawing.Point(9, 2)
        Me.datagrid1.Name = "datagrid1"
        Me.datagrid1.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.datagrid1.ParentRowsForeColor = System.Drawing.Color.Black
        Me.datagrid1.ReadOnly = True
        Me.datagrid1.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.datagrid1.SelectionForeColor = System.Drawing.Color.White
        Me.datagrid1.Size = New System.Drawing.Size(997, 424)
        Me.datagrid1.TabIndex = 44
        Me.datagrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.datagrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn16, Me.DataGridTextBoxColumn17, Me.DataGridTextBoxColumn18, Me.DataGridTextBoxColumn19, Me.DataGridTextBoxColumn20, Me.DataGridTextBoxColumn21, Me.DataGridTextBoxColumn22, Me.DataGridTextBoxColumn23, Me.DataGridTextBoxColumn24, Me.DataGridTextBoxColumn25, Me.DataGridTextBoxColumn26, Me.DataGridTextBoxColumn27, Me.DataGridTextBoxColumn28})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "IsCT_Show"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Rowid"
        Me.DataGridTextBoxColumn1.MappingName = "Rowid"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 35
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Medrep"
        Me.DataGridTextBoxColumn2.MappingName = "Medrep"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 185
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Customer"
        Me.DataGridTextBoxColumn3.MappingName = "Customer"
        Me.DataGridTextBoxColumn3.Width = 235
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Item"
        Me.DataGridTextBoxColumn4.MappingName = "Item"
        Me.DataGridTextBoxColumn4.Width = 207
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Qty Sold"
        Me.DataGridTextBoxColumn5.MappingName = "QtySold"
        Me.DataGridTextBoxColumn5.Width = 50
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Qty Free"
        Me.DataGridTextBoxColumn6.MappingName = "QtyFree"
        Me.DataGridTextBoxColumn6.Width = 50
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn7.Format = "#,###,###.00"
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Credited Amt"
        Me.DataGridTextBoxColumn7.MappingName = "CreditedAmount"
        Me.DataGridTextBoxColumn7.Width = 75
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "Ref Code"
        Me.DataGridTextBoxColumn8.MappingName = "refcode"
        Me.DataGridTextBoxColumn8.Width = 75
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "Ref Date"
        Me.DataGridTextBoxColumn9.MappingName = "refdate"
        Me.DataGridTextBoxColumn9.Width = 75
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.MappingName = "Address1"
        Me.DataGridTextBoxColumn10.Width = 0
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.MappingName = "Address2"
        Me.DataGridTextBoxColumn11.Width = 0
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.MappingName = "UnitPrice"
        Me.DataGridTextBoxColumn12.Width = 0
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.MappingName = "AmountSold"
        Me.DataGridTextBoxColumn13.Width = 0
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.MappingName = "CommissionDate"
        Me.DataGridTextBoxColumn14.Width = 0
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.MappingName = "OutOfStock"
        Me.DataGridTextBoxColumn15.Width = 0
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Format = ""
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.MappingName = "saletype"
        Me.DataGridTextBoxColumn16.Width = 0
        '
        'DataGridTextBoxColumn17
        '
        Me.DataGridTextBoxColumn17.Format = ""
        Me.DataGridTextBoxColumn17.FormatInfo = Nothing
        Me.DataGridTextBoxColumn17.MappingName = "subsaletype"
        Me.DataGridTextBoxColumn17.Width = 0
        '
        'DataGridTextBoxColumn18
        '
        Me.DataGridTextBoxColumn18.Format = ""
        Me.DataGridTextBoxColumn18.FormatInfo = Nothing
        Me.DataGridTextBoxColumn18.MappingName = "subsubsaletype"
        Me.DataGridTextBoxColumn18.Width = 0
        '
        'DataGridTextBoxColumn19
        '
        Me.DataGridTextBoxColumn19.Format = ""
        Me.DataGridTextBoxColumn19.FormatInfo = Nothing
        Me.DataGridTextBoxColumn19.MappingName = "salesclass"
        Me.DataGridTextBoxColumn19.Width = 0
        '
        'DataGridTextBoxColumn20
        '
        Me.DataGridTextBoxColumn20.Format = ""
        Me.DataGridTextBoxColumn20.FormatInfo = Nothing
        Me.DataGridTextBoxColumn20.MappingName = "CreateDate"
        Me.DataGridTextBoxColumn20.Width = 0
        '
        'DataGridTextBoxColumn21
        '
        Me.DataGridTextBoxColumn21.Format = ""
        Me.DataGridTextBoxColumn21.FormatInfo = Nothing
        Me.DataGridTextBoxColumn21.MappingName = "UpdateDate"
        Me.DataGridTextBoxColumn21.Width = 0
        '
        'DataGridTextBoxColumn22
        '
        Me.DataGridTextBoxColumn22.Format = ""
        Me.DataGridTextBoxColumn22.FormatInfo = Nothing
        Me.DataGridTextBoxColumn22.MappingName = "TerritoryDesc"
        Me.DataGridTextBoxColumn22.Width = 0
        '
        'DataGridTextBoxColumn23
        '
        Me.DataGridTextBoxColumn23.Format = ""
        Me.DataGridTextBoxColumn23.FormatInfo = Nothing
        Me.DataGridTextBoxColumn23.MappingName = "Province"
        Me.DataGridTextBoxColumn23.Width = 0
        '
        'DataGridTextBoxColumn24
        '
        Me.DataGridTextBoxColumn24.Format = ""
        Me.DataGridTextBoxColumn24.FormatInfo = Nothing
        Me.DataGridTextBoxColumn24.MappingName = "Group"
        Me.DataGridTextBoxColumn24.Width = 0
        '
        'DataGridTextBoxColumn25
        '
        Me.DataGridTextBoxColumn25.Format = ""
        Me.DataGridTextBoxColumn25.FormatInfo = Nothing
        Me.DataGridTextBoxColumn25.MappingName = "Principal"
        Me.DataGridTextBoxColumn25.Width = 0
        '
        'DataGridTextBoxColumn26
        '
        Me.DataGridTextBoxColumn26.Format = ""
        Me.DataGridTextBoxColumn26.FormatInfo = Nothing
        Me.DataGridTextBoxColumn26.MappingName = "Division"
        Me.DataGridTextBoxColumn26.Width = 0
        '
        'DataGridTextBoxColumn27
        '
        Me.DataGridTextBoxColumn27.Format = ""
        Me.DataGridTextBoxColumn27.FormatInfo = Nothing
        Me.DataGridTextBoxColumn27.HeaderText = "Supervisor"
        Me.DataGridTextBoxColumn27.MappingName = "Supervisor"
        Me.DataGridTextBoxColumn27.NullText = ""
        Me.DataGridTextBoxColumn27.Width = 200
        '
        'DataGridTextBoxColumn28
        '
        Me.DataGridTextBoxColumn28.Format = ""
        Me.DataGridTextBoxColumn28.FormatInfo = Nothing
        Me.DataGridTextBoxColumn28.MappingName = "Nsm"
        Me.DataGridTextBoxColumn28.Width = 0
        '
        'cboCustomer
        '
        Me.cboCustomer.AccessibleDescription = "Customer"
        Me.cboCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboCustomer.Location = New System.Drawing.Point(8, 456)
        Me.cboCustomer.Name = "cboCustomer"
        Me.cboCustomer.Size = New System.Drawing.Size(248, 21)
        Me.cboCustomer.TabIndex = 45
        Me.cboCustomer.Tag = "Input"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 440)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Customer"
        '
        'txtAddress1
        '
        Me.txtAddress1.AccessibleDescription = "Address1"
        Me.txtAddress1.Location = New System.Drawing.Point(8, 496)
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(248, 20)
        Me.txtAddress1.TabIndex = 47
        Me.txtAddress1.Tag = "Input"
        Me.txtAddress1.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 480)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Address 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 520)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Address 2"
        '
        'txtAddress2
        '
        Me.txtAddress2.AccessibleDescription = "Address2"
        Me.txtAddress2.Location = New System.Drawing.Point(8, 536)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(248, 20)
        Me.txtAddress2.TabIndex = 49
        Me.txtAddress2.Tag = "Input"
        Me.txtAddress2.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 560)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 16)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Territory"
        '
        'cboTerritory
        '
        Me.cboTerritory.AccessibleDescription = "TerritoryDesc"
        Me.cboTerritory.Location = New System.Drawing.Point(8, 576)
        Me.cboTerritory.Name = "cboTerritory"
        Me.cboTerritory.Size = New System.Drawing.Size(248, 21)
        Me.cboTerritory.TabIndex = 51
        Me.cboTerritory.Tag = "Input"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 600)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Province"
        '
        'cboProvince
        '
        Me.cboProvince.AccessibleDescription = "Province"
        Me.cboProvince.Location = New System.Drawing.Point(8, 616)
        Me.cboProvince.Name = "cboProvince"
        Me.cboProvince.Size = New System.Drawing.Size(248, 21)
        Me.cboProvince.TabIndex = 53
        Me.cboProvince.Tag = "Input"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 640)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 16)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Group"
        '
        'cboGroup
        '
        Me.cboGroup.AccessibleDescription = "Group"
        Me.cboGroup.Location = New System.Drawing.Point(8, 656)
        Me.cboGroup.Name = "cboGroup"
        Me.cboGroup.Size = New System.Drawing.Size(248, 21)
        Me.cboGroup.TabIndex = 55
        Me.cboGroup.Tag = "Input"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(264, 521)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 16)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "National Sales Manager"
        '
        'cboNsm
        '
        Me.cboNsm.AccessibleDescription = "Nsm"
        Me.cboNsm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboNsm.Location = New System.Drawing.Point(264, 537)
        Me.cboNsm.Name = "cboNsm"
        Me.cboNsm.Size = New System.Drawing.Size(248, 21)
        Me.cboNsm.TabIndex = 61
        Me.cboNsm.Tag = "Input"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(264, 481)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 16)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "District Sales Manager"
        '
        'cboDSM
        '
        Me.cboDSM.AccessibleDescription = "Supervisor"
        Me.cboDSM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboDSM.Location = New System.Drawing.Point(264, 497)
        Me.cboDSM.Name = "cboDSM"
        Me.cboDSM.Size = New System.Drawing.Size(248, 21)
        Me.cboDSM.TabIndex = 59
        Me.cboDSM.Tag = "Input"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(264, 441)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 16)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Medrep"
        '
        'cboMedrep
        '
        Me.cboMedrep.AccessibleDescription = "Medrep"
        Me.cboMedrep.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboMedrep.Location = New System.Drawing.Point(264, 457)
        Me.cboMedrep.Name = "cboMedrep"
        Me.cboMedrep.Size = New System.Drawing.Size(248, 21)
        Me.cboMedrep.TabIndex = 57
        Me.cboMedrep.Tag = "Input"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(521, 600)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 16)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "Commission Date"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(264, 601)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 16)
        Me.Label11.TabIndex = 68
        Me.Label11.Text = "Principal"
        '
        'cboPrincipal
        '
        Me.cboPrincipal.AccessibleDescription = "Principal"
        Me.cboPrincipal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboPrincipal.Location = New System.Drawing.Point(264, 617)
        Me.cboPrincipal.Name = "cboPrincipal"
        Me.cboPrincipal.Size = New System.Drawing.Size(248, 21)
        Me.cboPrincipal.TabIndex = 67
        Me.cboPrincipal.Tag = "Input"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(264, 561)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 16)
        Me.Label12.TabIndex = 66
        Me.Label12.Text = "Division"
        '
        'cboDivision
        '
        Me.cboDivision.AccessibleDescription = "Division"
        Me.cboDivision.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboDivision.Location = New System.Drawing.Point(264, 577)
        Me.cboDivision.Name = "cboDivision"
        Me.cboDivision.Size = New System.Drawing.Size(248, 21)
        Me.cboDivision.TabIndex = 65
        Me.cboDivision.Tag = "Input"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(264, 640)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(26, 16)
        Me.Label13.TabIndex = 70
        Me.Label13.Text = "Item"
        '
        'cboItem
        '
        Me.cboItem.AccessibleDescription = "Item"
        Me.cboItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboItem.Location = New System.Drawing.Point(264, 656)
        Me.cboItem.Name = "cboItem"
        Me.cboItem.Size = New System.Drawing.Size(248, 21)
        Me.cboItem.TabIndex = 69
        Me.cboItem.Tag = "Input"
        '
        'txtRefCode
        '
        Me.txtRefCode.AccessibleDescription = "RefCode"
        Me.txtRefCode.Location = New System.Drawing.Point(520, 457)
        Me.txtRefCode.Name = "txtRefCode"
        Me.txtRefCode.Size = New System.Drawing.Size(80, 20)
        Me.txtRefCode.TabIndex = 72
        Me.txtRefCode.Tag = "Input"
        Me.txtRefCode.Text = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(520, 441)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 16)
        Me.Label14.TabIndex = 73
        Me.Label14.Text = "Ref Code"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(600, 441)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 16)
        Me.Label15.TabIndex = 74
        Me.Label15.Text = "Ref Date"
        '
        'txtQtySold
        '
        Me.txtQtySold.AccessibleDescription = "QtySold"
        Me.txtQtySold.Location = New System.Drawing.Point(520, 497)
        Me.txtQtySold.Name = "txtQtySold"
        Me.txtQtySold.Size = New System.Drawing.Size(80, 20)
        Me.txtQtySold.TabIndex = 75
        Me.txtQtySold.Tag = "Input"
        Me.txtQtySold.Text = ""
        Me.txtQtySold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtQtyFree
        '
        Me.txtQtyFree.AccessibleDescription = "QtyFree"
        Me.txtQtyFree.Location = New System.Drawing.Point(600, 497)
        Me.txtQtyFree.Name = "txtQtyFree"
        Me.txtQtyFree.Size = New System.Drawing.Size(80, 20)
        Me.txtQtyFree.TabIndex = 76
        Me.txtQtyFree.Tag = "Input"
        Me.txtQtyFree.Text = ""
        Me.txtQtyFree.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.AccessibleDescription = "UnitPrice"
        Me.txtUnitPrice.Location = New System.Drawing.Point(680, 497)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(88, 20)
        Me.txtUnitPrice.TabIndex = 77
        Me.txtUnitPrice.Tag = "Input"
        Me.txtUnitPrice.Text = ""
        Me.txtUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(552, 481)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 16)
        Me.Label16.TabIndex = 78
        Me.Label16.Text = "Qty Sold"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(632, 481)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(48, 16)
        Me.Label17.TabIndex = 79
        Me.Label17.Text = "Qty Free"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(715, 481)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(53, 16)
        Me.Label18.TabIndex = 80
        Me.Label18.Text = "Unit Price"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(679, 561)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(89, 16)
        Me.Label19.TabIndex = 84
        Me.Label19.Text = "Credited Amount"
        '
        'txtCreditedAmount
        '
        Me.txtCreditedAmount.AccessibleDescription = "CreditedAmount"
        Me.txtCreditedAmount.Location = New System.Drawing.Point(520, 577)
        Me.txtCreditedAmount.Name = "txtCreditedAmount"
        Me.txtCreditedAmount.Size = New System.Drawing.Size(248, 20)
        Me.txtCreditedAmount.TabIndex = 83
        Me.txtCreditedAmount.Tag = "Input"
        Me.txtCreditedAmount.Text = ""
        Me.txtCreditedAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(699, 521)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(69, 16)
        Me.Label20.TabIndex = 82
        Me.Label20.Text = "Amount Sold"
        '
        'txtAmountSold
        '
        Me.txtAmountSold.AccessibleDescription = "AmountSold"
        Me.txtAmountSold.Location = New System.Drawing.Point(520, 537)
        Me.txtAmountSold.Name = "txtAmountSold"
        Me.txtAmountSold.Size = New System.Drawing.Size(248, 20)
        Me.txtAmountSold.TabIndex = 81
        Me.txtAmountSold.Tag = "Input"
        Me.txtAmountSold.Text = ""
        Me.txtAmountSold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(776, 560)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(101, 16)
        Me.Label21.TabIndex = 92
        Me.Label21.Text = "Sub Sub Sale Type"
        '
        'cboSubSubSaleType
        '
        Me.cboSubSubSaleType.AccessibleDescription = "SubSubSaleType"
        Me.cboSubSubSaleType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboSubSubSaleType.Items.AddRange(New Object() {"", "518 Trading", "Audko Pharma", "Barr-Xsel Trading", "CodeA Pharma", "Dandee Marketing", "El San Diego", "Fraposa Trading", "Globo Asiatico", "GreenStone Trading", "My-K Marketing", "Ovlac Marketing", "Probiotic Corp", "RA Flores Jr. Trading", "RJB Sales", "Uru-Agas Enterprise", "Zcab Distributors"})
        Me.cboSubSubSaleType.Location = New System.Drawing.Point(776, 576)
        Me.cboSubSubSaleType.Name = "cboSubSubSaleType"
        Me.cboSubSubSaleType.Size = New System.Drawing.Size(224, 21)
        Me.cboSubSubSaleType.TabIndex = 91
        Me.cboSubSubSaleType.Tag = "Input"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(776, 520)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(78, 16)
        Me.Label22.TabIndex = 90
        Me.Label22.Text = "Sub Sale Type"
        '
        'cboSubSaleType
        '
        Me.cboSubSaleType.AccessibleDescription = "SubSaleType"
        Me.cboSubSaleType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboSubSaleType.Items.AddRange(New Object() {"", "Barr-Xsel Trading", "Globo Asiatico", "GreenStone Trading", "Zcab Distributors"})
        Me.cboSubSaleType.Location = New System.Drawing.Point(776, 536)
        Me.cboSubSaleType.Name = "cboSubSaleType"
        Me.cboSubSaleType.Size = New System.Drawing.Size(224, 21)
        Me.cboSubSaleType.TabIndex = 89
        Me.cboSubSaleType.Tag = "Input"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(776, 480)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(55, 16)
        Me.Label23.TabIndex = 88
        Me.Label23.Text = "Sale Type"
        '
        'cboSaleType
        '
        Me.cboSaleType.AccessibleDescription = "SaleType"
        Me.cboSaleType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboSaleType.Items.AddRange(New Object() {"", "MIC", "MDC", "QPI", "HII", "InHouse", "SubDistributor"})
        Me.cboSaleType.Location = New System.Drawing.Point(776, 496)
        Me.cboSaleType.Name = "cboSaleType"
        Me.cboSaleType.Size = New System.Drawing.Size(224, 21)
        Me.cboSaleType.TabIndex = 87
        Me.cboSaleType.Tag = "Input"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(776, 440)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(33, 16)
        Me.Label24.TabIndex = 86
        Me.Label24.Text = "Class"
        '
        'cboClass
        '
        Me.cboClass.AccessibleDescription = "SalesClass"
        Me.cboClass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboClass.Items.AddRange(New Object() {"", "MIC", "HII", "QPI"})
        Me.cboClass.Location = New System.Drawing.Point(776, 456)
        Me.cboClass.Name = "cboClass"
        Me.cboClass.Size = New System.Drawing.Size(224, 21)
        Me.cboClass.TabIndex = 85
        Me.cboClass.Tag = "Input"
        '
        'txtRowid
        '
        Me.txtRowid.Location = New System.Drawing.Point(776, 617)
        Me.txtRowid.Name = "txtRowid"
        Me.txtRowid.Size = New System.Drawing.Size(224, 20)
        Me.txtRowid.TabIndex = 94
        Me.txtRowid.Tag = "Input"
        Me.txtRowid.Text = ""
        '
        'lblUpdateDate
        '
        Me.lblUpdateDate.BackColor = System.Drawing.SystemColors.Info
        Me.lblUpdateDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUpdateDate.Location = New System.Drawing.Point(520, 656)
        Me.lblUpdateDate.Name = "lblUpdateDate"
        Me.lblUpdateDate.Size = New System.Drawing.Size(184, 20)
        Me.lblUpdateDate.TabIndex = 96
        Me.lblUpdateDate.Tag = "Input"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(521, 640)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(91, 16)
        Me.Label26.TabIndex = 98
        Me.Label26.Text = "Sales Cycle Date"
        '
        'cboOs
        '
        Me.cboOs.AccessibleDescription = "OutOfStock"
        Me.cboOs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboOs.Items.AddRange(New Object() {"", "0", "1"})
        Me.cboOs.Location = New System.Drawing.Point(776, 1616)
        Me.cboOs.Name = "cboOs"
        Me.cboOs.Size = New System.Drawing.Size(224, 21)
        Me.cboOs.TabIndex = 102
        Me.cboOs.Tag = "Input"
        Me.cboOs.Visible = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(776, 600)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(39, 16)
        Me.Label27.TabIndex = 103
        Me.Label27.Text = "Row Id"
        '
        'txtDynamic
        '
        Me.txtDynamic.Location = New System.Drawing.Point(80, 688)
        Me.txtDynamic.Name = "txtDynamic"
        Me.txtDynamic.TabIndex = 104
        Me.txtDynamic.Text = ""
        Me.txtDynamic.Visible = False
        '
        'dtCommissionDate
        '
        Me.dtCommissionDate.AccessibleDescription = "CommissionDate"
        Me.dtCommissionDate.BackColor = System.Drawing.SystemColors.Info
        Me.dtCommissionDate.Location = New System.Drawing.Point(520, 617)
        Me.dtCommissionDate.Name = "dtCommissionDate"
        Me.dtCommissionDate.ReadOnly = True
        Me.dtCommissionDate.Size = New System.Drawing.Size(184, 20)
        Me.dtCommissionDate.TabIndex = 105
        Me.dtCommissionDate.Tag = "Input"
        Me.dtCommissionDate.Text = ""
        '
        'dtRefDate
        '
        Me.dtRefDate.AccessibleDescription = "RefDate"
        Me.dtRefDate.Location = New System.Drawing.Point(600, 457)
        Me.dtRefDate.Name = "dtRefDate"
        Me.dtRefDate.Size = New System.Drawing.Size(168, 20)
        Me.dtRefDate.TabIndex = 106
        Me.dtRefDate.Tag = "Input"
        Me.dtRefDate.Text = ""
        '
        'cmdExit
        '
        Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdExit.Location = New System.Drawing.Point(480, 688)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.TabIndex = 127
        Me.cmdExit.Tag = "Exit"
        Me.cmdExit.Text = "Exit"
        '
        'cmdEdit
        '
        Me.cmdEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdEdit.Location = New System.Drawing.Point(319, 687)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.TabIndex = 126
        Me.cmdEdit.Tag = "Edit"
        Me.cmdEdit.Text = "Edit"
        '
        'cmdAdd
        '
        Me.cmdAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdAdd.Location = New System.Drawing.Point(239, 688)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.TabIndex = 125
        Me.cmdAdd.Tag = "Add"
        Me.cmdAdd.Text = "Add"
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(733, 687)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 23)
        Me.Button1.TabIndex = 124
        '
        'cmdSearch
        '
        Me.cmdSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.Location = New System.Drawing.Point(597, 687)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(136, 23)
        Me.cmdSearch.TabIndex = 123
        Me.cmdSearch.Tag = ""
        Me.cmdSearch.Text = "Search"
        '
        'cmdCancel
        '
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdCancel.Location = New System.Drawing.Point(319, 687)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.TabIndex = 122
        Me.cmdCancel.Tag = "Cancel"
        Me.cmdCancel.Text = "Cancel"
        '
        'cmdDelete
        '
        Me.cmdDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDelete.Location = New System.Drawing.Point(399, 687)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.TabIndex = 121
        Me.cmdDelete.Tag = "Delete"
        Me.cmdDelete.Text = "Delete"
        '
        'cmdSave
        '
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSave.Location = New System.Drawing.Point(399, 687)
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
        Me.cmdGo.Location = New System.Drawing.Point(597, 687)
        Me.cmdGo.Name = "cmdGo"
        Me.cmdGo.Size = New System.Drawing.Size(136, 23)
        Me.cmdGo.TabIndex = 120
        Me.cmdGo.Tag = ""
        Me.cmdGo.Text = "Go !"
        '
        'EditIntegratedSales
        '
        Me.AccessibleDescription = ""
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1009, 717)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdGo)
        Me.Controls.Add(Me.dtRefDate)
        Me.Controls.Add(Me.dtCommissionDate)
        Me.Controls.Add(Me.txtDynamic)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtCreditedAmount)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtAmountSold)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtUnitPrice)
        Me.Controls.Add(Me.txtQtyFree)
        Me.Controls.Add(Me.txtQtySold)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtRefCode)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAddress2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAddress1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRowid)
        Me.Controls.Add(Me.cboOs)
        Me.Controls.Add(Me.lblUpdateDate)
        Me.Controls.Add(Me.cboSubSubSaleType)
        Me.Controls.Add(Me.cboSubSaleType)
        Me.Controls.Add(Me.cboSaleType)
        Me.Controls.Add(Me.cboClass)
        Me.Controls.Add(Me.cboItem)
        Me.Controls.Add(Me.cboPrincipal)
        Me.Controls.Add(Me.cboDivision)
        Me.Controls.Add(Me.cboNsm)
        Me.Controls.Add(Me.cboDSM)
        Me.Controls.Add(Me.cboMedrep)
        Me.Controls.Add(Me.cboGroup)
        Me.Controls.Add(Me.cboProvince)
        Me.Controls.Add(Me.cboTerritory)
        Me.Controls.Add(Me.cboCustomer)
        Me.Controls.Add(Me.datagrid1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditIntegratedSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
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
            modControlBehavior.EnableControls(Me, True)
            EditMode = True
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
        Button1_Click(Me, Nothing)
        Sub_Select(Params, CStr(IIf(EditMode = False, "Insert", "Update")))
        EditMode = False
        modControlBehavior.EnableControls(Me, False)
    End Sub
    Private Sub Sub_Insert()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(36) As SqlParameter
        Dim CustomerCode As New SqlParameter("@CustomerCode", SqlDbType.VarChar, 10) : CustomerCode.Direction = ParameterDirection.Input : CustomerCode.Value = GetCode(cboCustomer.Text) : Params(0) = CustomerCode
        Dim CustomerName As New SqlParameter("@CustomerName", SqlDbType.VarChar, 75) : CustomerName.Direction = ParameterDirection.Input : CustomerName.Value = GetDescription(cboCustomer.Text) : Params(1) = CustomerName
        Dim Address1 As New SqlParameter("@Address1", SqlDbType.VarChar, 150) : Address1.Direction = ParameterDirection.Input : Address1.Value = txtAddress1.Text : Params(2) = Address1
        Dim Address2 As New SqlParameter("@Address2", SqlDbType.VarChar, 150) : Address2.Direction = ParameterDirection.Input : Address2.Value = txtAddress2.Text : Params(3) = Address2
        Dim Territory As New SqlParameter("@Territory", SqlDbType.VarChar, 50) : Territory.Direction = ParameterDirection.Input : Territory.Value = GetDescription(cboTerritory.Text) : Params(4) = Territory
        Dim TerritoryCode As New SqlParameter("@TerritoryCode", SqlDbType.VarChar, 25) : TerritoryCode.Direction = ParameterDirection.Input : TerritoryCode.Value = GetCode(cboTerritory.Text) : Params(5) = TerritoryCode
        Dim Province As New SqlParameter("@Province", SqlDbType.VarChar, 50) : Province.Direction = ParameterDirection.Input : Province.Value = GetDescription(cboProvince.Text) : Params(6) = Province
        Dim ProvinceCode As New SqlParameter("@ProvinceCode", SqlDbType.VarChar, 25) : ProvinceCode.Direction = ParameterDirection.Input : ProvinceCode.Value = GetCode(cboProvince.Text) : Params(7) = ProvinceCode
        Dim Group As New SqlParameter("@Group", SqlDbType.VarChar, 50) : Group.Direction = ParameterDirection.Input : Group.Value = GetDescription(cboGroup.Text) : Params(8) = Group
        Dim GroupCode As New SqlParameter("@GroupCode", SqlDbType.VarChar, 25) : GroupCode.Direction = ParameterDirection.Input : GroupCode.Value = GetCode(cboGroup.Text) : Params(9) = GroupCode
        Dim RefCode As New SqlParameter("@RefCode", SqlDbType.VarChar, 10) : RefCode.Direction = ParameterDirection.Input : RefCode.Value = txtRefCode.Text : Params(10) = RefCode
        Dim RefDate As New SqlParameter("@RefDate", SqlDbType.DateTime) : RefDate.Direction = ParameterDirection.Input : RefDate.Value = Format(CDate(dtRefDate.Text), "MM/dd/yyyy") : Params(11) = RefDate
        Dim ItemCode As New SqlParameter("@ItemCode", SqlDbType.VarChar, 10) : ItemCode.Direction = ParameterDirection.Input : ItemCode.Value = GetCode(cboItem.Text) : Params(12) = ItemCode
        Dim ItemDesc As New SqlParameter("@ItemDesc", SqlDbType.VarChar, 50) : ItemDesc.Direction = ParameterDirection.Input : ItemDesc.Value = GetDescription(cboItem.Text) : Params(13) = ItemDesc
        Dim PrincipalCode As New SqlParameter("@PrincipalCode", SqlDbType.VarChar, 10) : PrincipalCode.Direction = ParameterDirection.Input : PrincipalCode.Value = GetCode(cboPrincipal.Text) : Params(14) = PrincipalCode
        Dim PrincipalDesc As New SqlParameter("@PrincipalDesc", SqlDbType.VarChar, 50) : PrincipalDesc.Direction = ParameterDirection.Input : PrincipalDesc.Value = GetDescription(cboPrincipal.Text) : Params(15) = PrincipalDesc
        Dim DivisionCode As New SqlParameter("@DivisionCode", SqlDbType.VarChar, 10) : DivisionCode.Direction = ParameterDirection.Input : DivisionCode.Value = GetCode(cboDivision.Text) : Params(16) = DivisionCode
        Dim DivisionDesc As New SqlParameter("@DivisionDesc", SqlDbType.VarChar, 50) : DivisionDesc.Direction = ParameterDirection.Input : DivisionDesc.Value = GetDescription(cboDivision.Text) : Params(17) = DivisionDesc
        Dim QtySold As New SqlParameter("@QtySold", SqlDbType.BigInt) : QtySold.Direction = ParameterDirection.Input : QtySold.Value = txtQtySold.Text : Params(18) = QtySold
        Dim QtyFree As New SqlParameter("@QtyFree", SqlDbType.BigInt) : QtyFree.Direction = ParameterDirection.Input : QtyFree.Value = txtQtyFree.Text : Params(19) = QtyFree
        Dim UnitPrice As New SqlParameter("@UnitPrice", SqlDbType.Money) : UnitPrice.Direction = ParameterDirection.Input : UnitPrice.Value = txtUnitPrice.Text : Params(20) = UnitPrice
        Dim AmountSold As New SqlParameter("@AmountSold", SqlDbType.Money) : AmountSold.Direction = ParameterDirection.Input : AmountSold.Value = txtAmountSold.Text : Params(21) = AmountSold
        Dim CreditedAmount As New SqlParameter("@CreditedAmount", SqlDbType.Money) : CreditedAmount.Direction = ParameterDirection.Input : CreditedAmount.Value = txtCreditedAmount.Text : Params(22) = CreditedAmount
        Dim CommissionDate As New SqlParameter("@CommissionDate", SqlDbType.DateTime) : CommissionDate.Direction = ParameterDirection.Input : CommissionDate.Value = dtCommissionDate.Text : Params(23) = CommissionDate
        Dim MrCode As New SqlParameter("@MrCode", SqlDbType.VarChar, 25) : MrCode.Direction = ParameterDirection.Input : MrCode.Value = GetCode(cboMedrep.Text) : Params(24) = MrCode
        Dim MrName As New SqlParameter("@MrName", SqlDbType.VarChar, 50) : MrName.Direction = ParameterDirection.Input : MrName.Value = GetDescription(cboMedrep.Text) : Params(25) = MrName
        Dim SupCode As New SqlParameter("@SupCode", SqlDbType.VarChar, 25) : SupCode.Direction = ParameterDirection.Input : SupCode.Value = GetCode(cboDSM.Text) : Params(26) = SupCode
        Dim SupName As New SqlParameter("@SupName", SqlDbType.VarChar, 50) : SupName.Direction = ParameterDirection.Input : SupName.Value = GetDescription(cboDSM.Text) : Params(27) = SupName
        Dim NsmCode As New SqlParameter("@NsmCode", SqlDbType.VarChar, 25) : NsmCode.Direction = ParameterDirection.Input : NsmCode.Value = GetCode(cboNsm.Text) : Params(28) = NsmCode
        Dim NsmName As New SqlParameter("@NsmName", SqlDbType.VarChar, 50) : NsmName.Direction = ParameterDirection.Input : NsmName.Value = GetDescription(cboNsm.Text) : Params(29) = NsmName
        Dim OutOfStock As New SqlParameter("@OutOfStock", SqlDbType.Int) : OutOfStock.Direction = ParameterDirection.Input : OutOfStock.Value = cboOs.Text : Params(30) = OutOfStock
        Dim SaleType As New SqlParameter("@SaleType", SqlDbType.VarChar, 50) : SaleType.Direction = ParameterDirection.Input : SaleType.Value = cboSaleType.Text : Params(31) = SaleType
        Dim SubSaleType As New SqlParameter("@SubSaleType", SqlDbType.VarChar, 75) : SubSaleType.Direction = ParameterDirection.Input : SubSaleType.Value = cboSubSaleType.Text : Params(32) = SubSaleType
        Dim SubSubSaleType As New SqlParameter("@SubSubSaleType", SqlDbType.VarChar, 75) : SubSubSaleType.Direction = ParameterDirection.Input : SubSubSaleType.Value = cboSubSubSaleType.Text : Params(33) = SubSubSaleType
        Dim SalesClass As New SqlParameter("@SalesClass", SqlDbType.VarChar, 75) : SalesClass.Direction = ParameterDirection.Input : SalesClass.Value = cboClass.Text : Params(34) = SalesClass
        Dim CreateDate As New SqlParameter("@CreateDate", SqlDbType.DateTime) : CreateDate.Direction = ParameterDirection.Input : CreateDate.Value = Now() : Params(35) = CreateDate
        Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime) : UpdateDate.Direction = ParameterDirection.Input : UpdateDate.Value = Now() : Params(36) = UpdateDate
        BusinessObject.Sub_Insert(ServerPath2, "IsCT_Insert", CommandType.StoredProcedure, Params)
    End Sub
    Private Sub Sub_Update()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(36) As SqlParameter
        Dim CustomerCode As New SqlParameter("@CustomerCode", SqlDbType.VarChar, 10) : CustomerCode.Direction = ParameterDirection.Input : CustomerCode.Value = GetCode(cboCustomer.Text) : Params(0) = CustomerCode
        Dim CustomerName As New SqlParameter("@CustomerName", SqlDbType.VarChar, 75) : CustomerName.Direction = ParameterDirection.Input : CustomerName.Value = GetDescription(cboCustomer.Text) : Params(1) = CustomerName
        Dim Address1 As New SqlParameter("@Address1", SqlDbType.VarChar, 150) : Address1.Direction = ParameterDirection.Input : Address1.Value = txtAddress1.Text : Params(2) = Address1
        Dim Address2 As New SqlParameter("@Address2", SqlDbType.VarChar, 150) : Address2.Direction = ParameterDirection.Input : Address2.Value = txtAddress2.Text : Params(3) = Address2
        Dim Territory As New SqlParameter("@Territory", SqlDbType.VarChar, 50) : Territory.Direction = ParameterDirection.Input : Territory.Value = GetDescription(cboTerritory.Text) : Params(4) = Territory
        Dim TerritoryCode As New SqlParameter("@TerritoryCode", SqlDbType.VarChar, 25) : TerritoryCode.Direction = ParameterDirection.Input : TerritoryCode.Value = GetCode(cboTerritory.Text) : Params(5) = TerritoryCode
        Dim Province As New SqlParameter("@Province", SqlDbType.VarChar, 50) : Province.Direction = ParameterDirection.Input : Province.Value = GetDescription(cboProvince.Text) : Params(6) = Province
        Dim ProvinceCode As New SqlParameter("@ProvinceCode", SqlDbType.VarChar, 25) : ProvinceCode.Direction = ParameterDirection.Input : ProvinceCode.Value = GetCode(cboProvince.Text) : Params(7) = ProvinceCode
        Dim Group As New SqlParameter("@Group", SqlDbType.VarChar, 50) : Group.Direction = ParameterDirection.Input : Group.Value = GetDescription(cboGroup.Text) : Params(8) = Group
        Dim GroupCode As New SqlParameter("@GroupCode", SqlDbType.VarChar, 25) : GroupCode.Direction = ParameterDirection.Input : GroupCode.Value = GetCode(cboGroup.Text) : Params(9) = GroupCode
        Dim RefCode As New SqlParameter("@RefCode", SqlDbType.VarChar, 10) : RefCode.Direction = ParameterDirection.Input : RefCode.Value = txtRefCode.Text : Params(10) = RefCode
        Dim RefDate As New SqlParameter("@RefDate", SqlDbType.DateTime) : RefDate.Direction = ParameterDirection.Input : RefDate.Value = Format(CDate(dtRefDate.Text), "MM/dd/yyyy") : Params(11) = RefDate
        Dim ItemCode As New SqlParameter("@ItemCode", SqlDbType.VarChar, 10) : ItemCode.Direction = ParameterDirection.Input : ItemCode.Value = GetCode(cboItem.Text) : Params(12) = ItemCode
        Dim ItemDesc As New SqlParameter("@ItemDesc", SqlDbType.VarChar, 50) : ItemDesc.Direction = ParameterDirection.Input : ItemDesc.Value = GetDescription(cboItem.Text) : Params(13) = ItemDesc
        Dim PrincipalCode As New SqlParameter("@PrincipalCode", SqlDbType.VarChar, 10) : PrincipalCode.Direction = ParameterDirection.Input : PrincipalCode.Value = GetCode(cboPrincipal.Text) : Params(14) = PrincipalCode
        Dim PrincipalDesc As New SqlParameter("@PrincipalDesc", SqlDbType.VarChar, 50) : PrincipalDesc.Direction = ParameterDirection.Input : PrincipalDesc.Value = GetDescription(cboPrincipal.Text) : Params(15) = PrincipalDesc
        Dim DivisionCode As New SqlParameter("@DivisionCode", SqlDbType.VarChar, 10) : DivisionCode.Direction = ParameterDirection.Input : DivisionCode.Value = GetCode(cboDivision.Text) : Params(16) = DivisionCode
        Dim DivisionDesc As New SqlParameter("@DivisionDesc", SqlDbType.VarChar, 50) : DivisionDesc.Direction = ParameterDirection.Input : DivisionDesc.Value = GetDescription(cboDivision.Text) : Params(17) = DivisionDesc
        Dim QtySold As New SqlParameter("@QtySold", SqlDbType.BigInt) : QtySold.Direction = ParameterDirection.Input : QtySold.Value = txtQtySold.Text : Params(18) = QtySold
        Dim QtyFree As New SqlParameter("@QtyFree", SqlDbType.BigInt) : QtyFree.Direction = ParameterDirection.Input : QtyFree.Value = txtQtyFree.Text : Params(19) = QtyFree
        Dim UnitPrice As New SqlParameter("@UnitPrice", SqlDbType.Money) : UnitPrice.Direction = ParameterDirection.Input : UnitPrice.Value = txtUnitPrice.Text : Params(20) = UnitPrice
        Dim AmountSold As New SqlParameter("@AmountSold", SqlDbType.Money) : AmountSold.Direction = ParameterDirection.Input : AmountSold.Value = txtAmountSold.Text : Params(21) = AmountSold
        Dim CreditedAmount As New SqlParameter("@CreditedAmount", SqlDbType.Money) : CreditedAmount.Direction = ParameterDirection.Input : CreditedAmount.Value = txtCreditedAmount.Text : Params(22) = CreditedAmount
        Dim CommissionDate As New SqlParameter("@CommissionDate", SqlDbType.DateTime) : CommissionDate.Direction = ParameterDirection.Input : CommissionDate.Value = dtCommissionDate.Text : Params(23) = CommissionDate
        Dim MrCode As New SqlParameter("@MrCode", SqlDbType.VarChar, 25) : MrCode.Direction = ParameterDirection.Input : MrCode.Value = GetCode(cboMedrep.Text) : Params(24) = MrCode
        Dim MrName As New SqlParameter("@MrName", SqlDbType.VarChar, 50) : MrName.Direction = ParameterDirection.Input : MrName.Value = GetDescription(cboMedrep.Text) : Params(25) = MrName
        Dim SupCode As New SqlParameter("@SupCode", SqlDbType.VarChar, 25) : SupCode.Direction = ParameterDirection.Input : SupCode.Value = GetCode(cboDSM.Text) : Params(26) = SupCode
        Dim SupName As New SqlParameter("@SupName", SqlDbType.VarChar, 50) : SupName.Direction = ParameterDirection.Input : SupName.Value = GetDescription(cboDSM.Text) : Params(27) = SupName
        Dim NsmCode As New SqlParameter("@NsmCode", SqlDbType.VarChar, 25) : NsmCode.Direction = ParameterDirection.Input : NsmCode.Value = GetCode(cboNsm.Text) : Params(28) = NsmCode
        Dim NsmName As New SqlParameter("@NsmName", SqlDbType.VarChar, 50) : NsmName.Direction = ParameterDirection.Input : NsmName.Value = GetDescription(cboNsm.Text) : Params(29) = NsmName
        Dim OutOfStock As New SqlParameter("@OutOfStock", SqlDbType.Int) : OutOfStock.Direction = ParameterDirection.Input : OutOfStock.Value = cboOs.Text : Params(30) = OutOfStock
        Dim SaleType As New SqlParameter("@SaleType", SqlDbType.VarChar, 50) : SaleType.Direction = ParameterDirection.Input : SaleType.Value = cboSaleType.Text : Params(31) = SaleType
        Dim SubSaleType As New SqlParameter("@SubSaleType", SqlDbType.VarChar, 75) : SubSaleType.Direction = ParameterDirection.Input : SubSaleType.Value = cboSubSaleType.Text : Params(32) = SubSaleType
        Dim SubSubSaleType As New SqlParameter("@SubSubSaleType", SqlDbType.VarChar, 75) : SubSubSaleType.Direction = ParameterDirection.Input : SubSubSaleType.Value = cboSubSubSaleType.Text : Params(33) = SubSubSaleType
        Dim SalesClass As New SqlParameter("@SalesClass", SqlDbType.VarChar, 75) : SalesClass.Direction = ParameterDirection.Input : SalesClass.Value = cboClass.Text : Params(34) = SalesClass
        Dim Rowid As New SqlParameter("@Rowid", SqlDbType.Int) : Rowid.Direction = ParameterDirection.Input : Rowid.Value = txtRowid.Text : Params(35) = Rowid
        Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime) : UpdateDate.Direction = ParameterDirection.Input : UpdateDate.Value = Now() : Params(36) = UpdateDate
        BusinessObject.Sub_Update(ServerPath2, "IsCT_Update", CommandType.StoredProcedure, Params)
    End Sub
    Private Sub Sub_Show()
        If RemoteDataSet.IsCT_Show.Count > 0 Then RemoteDataSet.IsCT_Show.Clear()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "IsCT_Show", CommandType.StoredProcedure, RemoteDataSet, "IsCT_Show")
        datagrid1.DataSource = RemoteDataSet.IsCT_Show
    End Sub
    Private Sub Load_Customer()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "Customer_Combo", CommandType.StoredProcedure, RemoteDataSet, "Customer_Combo")
        cboCustomer.DataSource = RemoteDataSet.Customer_Combo
        cboCustomer.DisplayMember = "Customer"
    End Sub
    Private Sub Load_Medrep()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "Medrep_Combo", CommandType.StoredProcedure, RemoteDataSet, "Medrep_Combo")
        cboMedrep.DataSource = RemoteDataSet.Medrep_Combo
        cboMedrep.DisplayMember = "Medrep"
    End Sub
    Private Sub Load_Province()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "Province_Combo", CommandType.StoredProcedure, RemoteDataSet, "Province_Combo")
        cboProvince.DataSource = RemoteDataSet.Province_Combo
        cboProvince.DisplayMember = "Province"
    End Sub
    Private Sub Load_Group()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "Group_Combo", CommandType.StoredProcedure, RemoteDataSet, "Group_Combo")
        cboGroup.DataSource = RemoteDataSet.Group_Combo
        cboGroup.DisplayMember = "Group"
    End Sub
    Private Sub Load_Territory()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "Territory_Combo", CommandType.StoredProcedure, RemoteDataSet, "Territory_Combo")
        cboTerritory.DataSource = RemoteDataSet.Territory_Combo
        cboTerritory.DisplayMember = "TerritoryDesc"
    End Sub
    Private Sub Load_Dsm()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "Dsm_Combo", CommandType.StoredProcedure, RemoteDataSet, "Dsm_Combo")
        cboDSM.DataSource = RemoteDataSet.DSm_Combo
        cboDSM.DisplayMember = "Dsm"
    End Sub
    Private Sub Load_Nsm()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "Nsm_Combo", CommandType.StoredProcedure, RemoteDataSet, "Nsm_Combo")
        cboNsm.DataSource = RemoteDataSet.NSM_Combo
        cboNsm.DisplayMember = "Nsm"
    End Sub
    Private Sub Load_Division()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "Division_Combo", CommandType.StoredProcedure, RemoteDataSet, "Division_Combo")
        cboDivision.DataSource = RemoteDataSet.Division_Combo
        cboDivision.DisplayMember = "Division"
    End Sub
    Private Sub Load_Principal()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "Principal_Combo", CommandType.StoredProcedure, RemoteDataSet, "Principal_Combo")
        cboPrincipal.DataSource = RemoteDataSet.Principal_Combo
        cboPrincipal.DisplayMember = "Principal"
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
        For i = 0 To (RemoteDataSet.IsCT_Show.Rows.Count - 1)
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
            txtRowid.Text = CStr(.Item(.CurrentCell.RowNumber, 0))
            cboMedrep.Text = CStr(.Item(.CurrentCell.RowNumber, 1))
            cboCustomer.Text = CStr(.Item(.CurrentCell.RowNumber, 2))
            cboItem.Text = CStr(.Item(.CurrentCell.RowNumber, 3))
            txtQtySold.Text = CStr(.Item(.CurrentCell.RowNumber, 4))
            txtQtyFree.Text = CStr(.Item(.CurrentCell.RowNumber, 5))
            txtCreditedAmount.Text = CStr(.Item(.CurrentCell.RowNumber, 6))
            txtRefCode.Text = CStr(.Item(.CurrentCell.RowNumber, 7))
            dtRefDate.Text = CStr(.Item(.CurrentCell.RowNumber, 8))
            txtAddress1.Text = CStr(.Item(.CurrentCell.RowNumber, 9))
            txtAddress2.Text = CStr(.Item(.CurrentCell.RowNumber, 10))
            txtUnitPrice.Text = CStr(.Item(.CurrentCell.RowNumber, 11))
            txtAmountSold.Text = CStr(.Item(.CurrentCell.RowNumber, 12))
            dtCommissionDate.Text = CStr(.Item(.CurrentCell.RowNumber, 13))
            cboOs.Text = CStr(.Item(.CurrentCell.RowNumber, 14))
            cboSaleType.Text = CStr(.Item(.CurrentCell.RowNumber, 15))
            cboSubSaleType.Text = CStr(.Item(.CurrentCell.RowNumber, 16))
            cboSubSubSaleType.Text = CStr(.Item(.CurrentCell.RowNumber, 17))
            cboClass.Text = CStr(.Item(.CurrentCell.RowNumber, 18))
            'lblCreateDate.Text = .Item(.CurrentCell.RowNumber, 19).ToString
            lblUpdateDate.Text = .Item(.CurrentCell.RowNumber, 20).ToString
            cboTerritory.Text = CStr(.Item(.CurrentCell.RowNumber, 21))
            cboProvince.Text = CStr(.Item(.CurrentCell.RowNumber, 22))
            cboGroup.Text = CStr(.Item(.CurrentCell.RowNumber, 23))
            cboPrincipal.Text = CStr(.Item(.CurrentCell.RowNumber, 24))
            cboDivision.Text = CStr(.Item(.CurrentCell.RowNumber, 25))
            cboDSM.Text = CStr(.Item(.CurrentCell.RowNumber, 26))
            cboNsm.Text = CStr(.Item(.CurrentCell.RowNumber, 27))
            .Select(.CurrentCell.RowNumber)
        End With

    End Sub

    Private Function Create_SearchCondition() As String
        Dim MyControl As Control
        Dim MyString As String
        Dim Spacer As String
        SearchString = ""
        If txtDynamic.Text = "" Then
            For Each MyControl In Me.Controls
                If TypeOf MyControl Is TextBox Or (TypeOf MyControl Is ComboBox And MyControl.Text > "") _
                Or (TypeOf MyControl Is DateTimePicker And InStr(MyControl.Text, "9998") < 1) Then
                    If MyControl.Text > "" Then
                        Spacer = VisualBasic.Space(15 - VisualBasic.Len(MyControl.AccessibleDescription)) & VisualBasic.vbTab
                        If MyString = "" Then
                            MyString = MyControl.AccessibleDescription & " = '" & MyControl.Text & "'"
                            SearchString = MyControl.AccessibleDescription & Spacer & " : " & VisualBasic.vbTab & MyControl.Text
                        Else
                            MyString = MyString & " and " & MyControl.AccessibleDescription & " = '" & MyControl.Text & "'"
                            SearchString = SearchString & VisualBasic.vbCrLf & MyControl.AccessibleDescription & Spacer & " : " & VisualBasic.vbTab & MyControl.Text
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
        'Dim MyControl As Control
        'For Each MyControl In Me.Controls
        '    MyControl.Enabled = True
        'Next
        ControlMaintenance.ClearInputControls(Me)
        cboMedrep.Enabled = True : cboItem.Enabled = True
        cboDSM.Enabled = True : cboNsm.Enabled = True
        cboDivision.Enabled = True : cboPrincipal.Enabled = True
        txtRefCode.Enabled = True : dtRefDate.Enabled = True
        txtQtySold.Enabled = True : txtQtyFree.Enabled = True
        txtUnitPrice.Enabled = True : txtAmountSold.Enabled = True
        txtCreditedAmount.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Create_SearchCondition()
        If MessageBox.Show("Is this search condition correct?" & vbCrLf & SearchString, "Customer Info Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If RemoteDataSet.IsCT_Show.Count > 0 Then RemoteDataSet.IsCT_Show.Clear()
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim Where As New SqlParameter("@Where", SqlDbType.NVarChar) : Where.Direction = ParameterDirection.Input : Where.Value = Create_SearchCondition() : Params(0) = Where
            BusinessObject.Sub_Show(ServerPath2, "IsCT_DynamicSearch", CommandType.StoredProcedure, RemoteDataSet, "IsCT_Show", Params)
            datagrid1.DataSource = RemoteDataSet.IsCT_Show
        End If
    End Sub
End Class
