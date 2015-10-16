Imports System.Data.SqlClient
Imports Microsoft
Public Class ItemCT
    Inherits System.Windows.Forms.Form
    Private RemoteDataSet As New CodeTablesDS
    Private oldDs As String
    Public itmX As String
    Private tmpRowid As String

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Itm_Sub_Show()
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
    Friend WithEvents DG_items As System.Windows.Forms.DataGrid
    Friend WithEvents cmdExit_Itm As System.Windows.Forms.Button
    Friend WithEvents cmdAdd_Itm As System.Windows.Forms.Button
    Friend WithEvents cmdEdit_Itm As System.Windows.Forms.Button
    Friend WithEvents cmdDelete_Itm As System.Windows.Forms.Button
    Friend WithEvents DG_pm As System.Windows.Forms.DataGrid
    Friend WithEvents DG_nsm As System.Windows.Forms.DataGrid
    Friend WithEvents cmdExit_PM As System.Windows.Forms.Button
    Friend WithEvents cmdAdd_PM As System.Windows.Forms.Button
    Friend WithEvents cmdEdit_PM As System.Windows.Forms.Button
    Friend WithEvents cmdDelete_PM As System.Windows.Forms.Button
    Friend WithEvents cmdExit_NSM As System.Windows.Forms.Button
    Friend WithEvents cmdAdd_NSM As System.Windows.Forms.Button
    Friend WithEvents cmdEdit_NSM As System.Windows.Forms.Button
    Friend WithEvents cmdDelete_NSM As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
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
    Friend WithEvents DataGridTextBoxColumn31 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn32 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle5 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn49 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn50 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn51 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn52 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn53 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn54 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn55 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn56 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn57 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle6 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn58 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn59 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn60 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn61 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn62 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn63 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn64 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn65 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn66 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents txtItemCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtStat1 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTextBoxColumn77 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents txtRowid As System.Windows.Forms.TextBox
    Friend WithEvents txtNSMrowid As System.Windows.Forms.TextBox
    Friend WithEvents txtPMrowid As System.Windows.Forms.TextBox
    Friend WithEvents DimCode As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents PrdLineCode As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents PrdFormCode As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ItemCT))
        Me.DG_items = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
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
        Me.DataGridTextBoxColumn77 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn27 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn28 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn29 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn30 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn31 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn32 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DimCode = New System.Windows.Forms.DataGridTextBoxColumn
        Me.PrdLineCode = New System.Windows.Forms.DataGridTextBoxColumn
        Me.PrdFormCode = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DG_nsm = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle5 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn49 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn50 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn53 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn54 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn51 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn52 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn55 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn56 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn57 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DG_pm = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle6 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn58 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn59 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn62 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn63 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn60 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn61 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn64 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn65 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn66 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.cmdExit_Itm = New System.Windows.Forms.Button
        Me.cmdAdd_Itm = New System.Windows.Forms.Button
        Me.cmdEdit_Itm = New System.Windows.Forms.Button
        Me.cmdDelete_Itm = New System.Windows.Forms.Button
        Me.cmdExit_PM = New System.Windows.Forms.Button
        Me.cmdAdd_PM = New System.Windows.Forms.Button
        Me.cmdEdit_PM = New System.Windows.Forms.Button
        Me.cmdDelete_PM = New System.Windows.Forms.Button
        Me.cmdExit_NSM = New System.Windows.Forms.Button
        Me.cmdAdd_NSM = New System.Windows.Forms.Button
        Me.cmdEdit_NSM = New System.Windows.Forms.Button
        Me.cmdDelete_NSM = New System.Windows.Forms.Button
        Me.txtItemCode = New System.Windows.Forms.TextBox
        Me.TxtStat1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtRowid = New System.Windows.Forms.TextBox
        Me.txtNSMrowid = New System.Windows.Forms.TextBox
        Me.txtPMrowid = New System.Windows.Forms.TextBox
        CType(Me.DG_items, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_nsm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_pm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DG_items
        '
        Me.DG_items.AlternatingBackColor = System.Drawing.Color.Silver
        Me.DG_items.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DG_items.BackColor = System.Drawing.Color.White
        Me.DG_items.BackgroundColor = System.Drawing.Color.Lavender
        Me.DG_items.CaptionBackColor = System.Drawing.Color.CornflowerBlue
        Me.DG_items.CaptionForeColor = System.Drawing.Color.White
        Me.DG_items.CaptionText = "ITEMS"
        Me.DG_items.DataMember = ""
        Me.DG_items.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DG_items.ForeColor = System.Drawing.Color.Black
        Me.DG_items.GridLineColor = System.Drawing.Color.Silver
        Me.DG_items.HeaderBackColor = System.Drawing.Color.Silver
        Me.DG_items.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DG_items.HeaderForeColor = System.Drawing.Color.Black
        Me.DG_items.LinkColor = System.Drawing.Color.Maroon
        Me.DG_items.Location = New System.Drawing.Point(24, 28)
        Me.DG_items.Name = "DG_items"
        Me.DG_items.ParentRowsBackColor = System.Drawing.Color.Silver
        Me.DG_items.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DG_items.ReadOnly = True
        Me.DG_items.SelectionBackColor = System.Drawing.Color.Maroon
        Me.DG_items.SelectionForeColor = System.Drawing.Color.White
        Me.DG_items.Size = New System.Drawing.Size(1282, 488)
        Me.DG_items.TabIndex = 16
        Me.DG_items.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.DG_items.Tag = ""
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Aqua
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightCyan
        Me.DataGridTableStyle1.DataGrid = Me.DG_items
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn16, Me.DataGridTextBoxColumn17, Me.DataGridTextBoxColumn18, Me.DataGridTextBoxColumn19, Me.DataGridTextBoxColumn20, Me.DataGridTextBoxColumn21, Me.DataGridTextBoxColumn22, Me.DataGridTextBoxColumn23, Me.DataGridTextBoxColumn24, Me.DataGridTextBoxColumn25, Me.DataGridTextBoxColumn26, Me.DataGridTextBoxColumn77, Me.DataGridTextBoxColumn27, Me.DataGridTextBoxColumn28, Me.DataGridTextBoxColumn29, Me.DataGridTextBoxColumn30, Me.DataGridTextBoxColumn31, Me.DataGridTextBoxColumn32, Me.DimCode, Me.PrdLineCode, Me.PrdFormCode})
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.AntiqueWhite
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "ItemCodTab_Show"
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.MappingName = "rowid"
        Me.DataGridTextBoxColumn9.NullText = "0"
        Me.DataGridTextBoxColumn9.Width = 0
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "Item Code"
        Me.DataGridTextBoxColumn12.MappingName = "itemcode"
        Me.DataGridTextBoxColumn12.NullText = ""
        Me.DataGridTextBoxColumn12.Width = 45
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "Metro Drug Code"
        Me.DataGridTextBoxColumn13.MappingName = "MetroDrugCode"
        Me.DataGridTextBoxColumn13.NullText = ""
        Me.DataGridTextBoxColumn13.Width = 45
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "Mercury Item Code"
        Me.DataGridTextBoxColumn14.MappingName = "MercuryItemCode"
        Me.DataGridTextBoxColumn14.NullText = ""
        Me.DataGridTextBoxColumn14.Width = 45
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "Item Description"
        Me.DataGridTextBoxColumn15.MappingName = "itemdesc"
        Me.DataGridTextBoxColumn15.NullText = ""
        Me.DataGridTextBoxColumn15.Width = 200
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Format = ""
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.HeaderText = "Generic Name"
        Me.DataGridTextBoxColumn16.MappingName = "genericname"
        Me.DataGridTextBoxColumn16.NullText = ""
        Me.DataGridTextBoxColumn16.Width = 200
        '
        'DataGridTextBoxColumn17
        '
        Me.DataGridTextBoxColumn17.Format = ""
        Me.DataGridTextBoxColumn17.FormatInfo = Nothing
        Me.DataGridTextBoxColumn17.HeaderText = "Unit"
        Me.DataGridTextBoxColumn17.MappingName = "itemunit"
        Me.DataGridTextBoxColumn17.NullText = ""
        Me.DataGridTextBoxColumn17.Width = 40
        '
        'DataGridTextBoxColumn18
        '
        Me.DataGridTextBoxColumn18.Format = ""
        Me.DataGridTextBoxColumn18.FormatInfo = Nothing
        Me.DataGridTextBoxColumn18.HeaderText = "Unit Conversion"
        Me.DataGridTextBoxColumn18.MappingName = "unitconversion"
        Me.DataGridTextBoxColumn18.NullText = ""
        Me.DataGridTextBoxColumn18.Width = 50
        '
        'DataGridTextBoxColumn19
        '
        Me.DataGridTextBoxColumn19.Format = ""
        Me.DataGridTextBoxColumn19.FormatInfo = Nothing
        Me.DataGridTextBoxColumn19.HeaderText = "Current Price (SRP)"
        Me.DataGridTextBoxColumn19.MappingName = "unitprice"
        Me.DataGridTextBoxColumn19.NullText = ""
        Me.DataGridTextBoxColumn19.Width = 90
        '
        'DataGridTextBoxColumn20
        '
        Me.DataGridTextBoxColumn20.Format = ""
        Me.DataGridTextBoxColumn20.FormatInfo = Nothing
        Me.DataGridTextBoxColumn20.HeaderText = "Current Mercury Price(ST)"
        Me.DataGridTextBoxColumn20.MappingName = "mercurystprice"
        Me.DataGridTextBoxColumn20.NullText = ""
        Me.DataGridTextBoxColumn20.Width = 90
        '
        'DataGridTextBoxColumn21
        '
        Me.DataGridTextBoxColumn21.Format = ""
        Me.DataGridTextBoxColumn21.FormatInfo = Nothing
        Me.DataGridTextBoxColumn21.MappingName = "princode"
        Me.DataGridTextBoxColumn21.NullText = ""
        Me.DataGridTextBoxColumn21.Width = 0
        '
        'DataGridTextBoxColumn22
        '
        Me.DataGridTextBoxColumn22.Format = ""
        Me.DataGridTextBoxColumn22.FormatInfo = Nothing
        Me.DataGridTextBoxColumn22.HeaderText = "Current Principal"
        Me.DataGridTextBoxColumn22.MappingName = "prinname"
        Me.DataGridTextBoxColumn22.NullText = ""
        Me.DataGridTextBoxColumn22.Width = 200
        '
        'DataGridTextBoxColumn23
        '
        Me.DataGridTextBoxColumn23.Format = ""
        Me.DataGridTextBoxColumn23.FormatInfo = Nothing
        Me.DataGridTextBoxColumn23.MappingName = "divcode"
        Me.DataGridTextBoxColumn23.NullText = ""
        Me.DataGridTextBoxColumn23.Width = 0
        '
        'DataGridTextBoxColumn24
        '
        Me.DataGridTextBoxColumn24.Format = ""
        Me.DataGridTextBoxColumn24.FormatInfo = Nothing
        Me.DataGridTextBoxColumn24.HeaderText = "Current Segment"
        Me.DataGridTextBoxColumn24.MappingName = "divname"
        Me.DataGridTextBoxColumn24.NullText = ""
        Me.DataGridTextBoxColumn24.Width = 200
        '
        'DataGridTextBoxColumn25
        '
        Me.DataGridTextBoxColumn25.Format = ""
        Me.DataGridTextBoxColumn25.FormatInfo = Nothing
        Me.DataGridTextBoxColumn25.HeaderText = "Product Line"
        Me.DataGridTextBoxColumn25.MappingName = "productline"
        Me.DataGridTextBoxColumn25.NullText = ""
        Me.DataGridTextBoxColumn25.Width = 150
        '
        'DataGridTextBoxColumn26
        '
        Me.DataGridTextBoxColumn26.Format = ""
        Me.DataGridTextBoxColumn26.FormatInfo = Nothing
        Me.DataGridTextBoxColumn26.HeaderText = "Product Form"
        Me.DataGridTextBoxColumn26.MappingName = "productform"
        Me.DataGridTextBoxColumn26.NullText = ""
        Me.DataGridTextBoxColumn26.Width = 150
        '
        'DataGridTextBoxColumn77
        '
        Me.DataGridTextBoxColumn77.Format = ""
        Me.DataGridTextBoxColumn77.FormatInfo = Nothing
        Me.DataGridTextBoxColumn77.HeaderText = "KeyProductLine"
        Me.DataGridTextBoxColumn77.MappingName = "line"
        Me.DataGridTextBoxColumn77.NullText = ""
        Me.DataGridTextBoxColumn77.Width = 150
        '
        'DataGridTextBoxColumn27
        '
        Me.DataGridTextBoxColumn27.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn27.FormatInfo = Nothing
        Me.DataGridTextBoxColumn27.HeaderText = "Launch Date"
        Me.DataGridTextBoxColumn27.MappingName = "launchdate"
        Me.DataGridTextBoxColumn27.NullText = ""
        Me.DataGridTextBoxColumn27.Width = 70
        '
        'DataGridTextBoxColumn28
        '
        Me.DataGridTextBoxColumn28.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn28.FormatInfo = Nothing
        Me.DataGridTextBoxColumn28.HeaderText = "Inactive Date"
        Me.DataGridTextBoxColumn28.MappingName = "inactivedate"
        Me.DataGridTextBoxColumn28.NullText = ""
        Me.DataGridTextBoxColumn28.Width = 70
        '
        'DataGridTextBoxColumn29
        '
        Me.DataGridTextBoxColumn29.Format = ""
        Me.DataGridTextBoxColumn29.FormatInfo = Nothing
        Me.DataGridTextBoxColumn29.HeaderText = "Status"
        Me.DataGridTextBoxColumn29.MappingName = "status"
        Me.DataGridTextBoxColumn29.NullText = ""
        Me.DataGridTextBoxColumn29.Width = 50
        '
        'DataGridTextBoxColumn30
        '
        Me.DataGridTextBoxColumn30.Format = ""
        Me.DataGridTextBoxColumn30.FormatInfo = Nothing
        Me.DataGridTextBoxColumn30.HeaderText = "Encoder"
        Me.DataGridTextBoxColumn30.MappingName = "lastuser"
        Me.DataGridTextBoxColumn30.NullText = ""
        Me.DataGridTextBoxColumn30.Width = 60
        '
        'DataGridTextBoxColumn31
        '
        Me.DataGridTextBoxColumn31.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn31.FormatInfo = Nothing
        Me.DataGridTextBoxColumn31.HeaderText = "Create Date"
        Me.DataGridTextBoxColumn31.MappingName = "createdate"
        Me.DataGridTextBoxColumn31.NullText = ""
        Me.DataGridTextBoxColumn31.Width = 70
        '
        'DataGridTextBoxColumn32
        '
        Me.DataGridTextBoxColumn32.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn32.FormatInfo = Nothing
        Me.DataGridTextBoxColumn32.HeaderText = "Update Date"
        Me.DataGridTextBoxColumn32.MappingName = "updatedate"
        Me.DataGridTextBoxColumn32.NullText = ""
        Me.DataGridTextBoxColumn32.Width = 70
        '
        'DimCode
        '
        Me.DimCode.Format = ""
        Me.DimCode.FormatInfo = Nothing
        Me.DimCode.HeaderText = "Dimension Code"
        Me.DimCode.MappingName = "DimCode"
        Me.DimCode.Width = 75
        '
        'PrdLineCode
        '
        Me.PrdLineCode.Format = ""
        Me.PrdLineCode.FormatInfo = Nothing
        Me.PrdLineCode.HeaderText = "Product Line Code"
        Me.PrdLineCode.MappingName = "PrdLineCode"
        Me.PrdLineCode.NullText = ""
        Me.PrdLineCode.Width = 75
        '
        'PrdFormCode
        '
        Me.PrdFormCode.Format = ""
        Me.PrdFormCode.FormatInfo = Nothing
        Me.PrdFormCode.HeaderText = "Product Form Code"
        Me.PrdFormCode.MappingName = "PrdFormCode"
        Me.PrdFormCode.NullText = ""
        Me.PrdFormCode.Width = 75
        '
        'DG_nsm
        '
        Me.DG_nsm.AlternatingBackColor = System.Drawing.Color.Silver
        Me.DG_nsm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DG_nsm.BackColor = System.Drawing.Color.White
        Me.DG_nsm.BackgroundColor = System.Drawing.Color.Lavender
        Me.DG_nsm.CaptionBackColor = System.Drawing.Color.DarkSalmon
        Me.DG_nsm.CaptionForeColor = System.Drawing.Color.White
        Me.DG_nsm.CaptionText = "NSMs OF ITEM"
        Me.DG_nsm.DataMember = ""
        Me.DG_nsm.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DG_nsm.ForeColor = System.Drawing.Color.Black
        Me.DG_nsm.GridLineColor = System.Drawing.Color.Silver
        Me.DG_nsm.HeaderBackColor = System.Drawing.Color.Silver
        Me.DG_nsm.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DG_nsm.HeaderForeColor = System.Drawing.Color.Black
        Me.DG_nsm.LinkColor = System.Drawing.Color.Maroon
        Me.DG_nsm.Location = New System.Drawing.Point(267, 592)
        Me.DG_nsm.Name = "DG_nsm"
        Me.DG_nsm.ParentRowsBackColor = System.Drawing.Color.Silver
        Me.DG_nsm.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DG_nsm.ReadOnly = True
        Me.DG_nsm.SelectionBackColor = System.Drawing.Color.Maroon
        Me.DG_nsm.SelectionForeColor = System.Drawing.Color.White
        Me.DG_nsm.Size = New System.Drawing.Size(436, 120)
        Me.DG_nsm.TabIndex = 36
        Me.DG_nsm.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle5})
        Me.DG_nsm.Tag = ""
        Me.DG_nsm.Visible = False
        '
        'DataGridTableStyle5
        '
        Me.DataGridTableStyle5.AlternatingBackColor = System.Drawing.Color.MistyRose
        Me.DataGridTableStyle5.BackColor = System.Drawing.Color.LavenderBlush
        Me.DataGridTableStyle5.DataGrid = Me.DG_nsm
        Me.DataGridTableStyle5.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn49, Me.DataGridTextBoxColumn50, Me.DataGridTextBoxColumn53, Me.DataGridTextBoxColumn54, Me.DataGridTextBoxColumn51, Me.DataGridTextBoxColumn52, Me.DataGridTextBoxColumn55, Me.DataGridTextBoxColumn56, Me.DataGridTextBoxColumn57})
        Me.DataGridTableStyle5.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle5.MappingName = "ItemNSM_Show"
        '
        'DataGridTextBoxColumn49
        '
        Me.DataGridTextBoxColumn49.Format = ""
        Me.DataGridTextBoxColumn49.FormatInfo = Nothing
        Me.DataGridTextBoxColumn49.MappingName = "rowid"
        Me.DataGridTextBoxColumn49.NullText = ""
        Me.DataGridTextBoxColumn49.Width = 0
        '
        'DataGridTextBoxColumn50
        '
        Me.DataGridTextBoxColumn50.Format = ""
        Me.DataGridTextBoxColumn50.FormatInfo = Nothing
        Me.DataGridTextBoxColumn50.MappingName = "itemcode"
        Me.DataGridTextBoxColumn50.NullText = ""
        Me.DataGridTextBoxColumn50.Width = 0
        '
        'DataGridTextBoxColumn53
        '
        Me.DataGridTextBoxColumn53.Format = ""
        Me.DataGridTextBoxColumn53.FormatInfo = Nothing
        Me.DataGridTextBoxColumn53.HeaderText = "Start Date"
        Me.DataGridTextBoxColumn53.MappingName = "start_date"
        Me.DataGridTextBoxColumn53.NullText = ""
        Me.DataGridTextBoxColumn53.Width = 75
        '
        'DataGridTextBoxColumn54
        '
        Me.DataGridTextBoxColumn54.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn54.FormatInfo = Nothing
        Me.DataGridTextBoxColumn54.HeaderText = "End Date"
        Me.DataGridTextBoxColumn54.MappingName = "end_date"
        Me.DataGridTextBoxColumn54.NullText = ""
        Me.DataGridTextBoxColumn54.Width = 75
        '
        'DataGridTextBoxColumn51
        '
        Me.DataGridTextBoxColumn51.Format = ""
        Me.DataGridTextBoxColumn51.FormatInfo = Nothing
        Me.DataGridTextBoxColumn51.MappingName = "nsmcode"
        Me.DataGridTextBoxColumn51.NullText = ""
        Me.DataGridTextBoxColumn51.Width = 0
        '
        'DataGridTextBoxColumn52
        '
        Me.DataGridTextBoxColumn52.Format = ""
        Me.DataGridTextBoxColumn52.FormatInfo = Nothing
        Me.DataGridTextBoxColumn52.HeaderText = "National Sales Manager"
        Me.DataGridTextBoxColumn52.MappingName = "nsmname"
        Me.DataGridTextBoxColumn52.NullText = ""
        Me.DataGridTextBoxColumn52.Width = 200
        '
        'DataGridTextBoxColumn55
        '
        Me.DataGridTextBoxColumn55.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn55.FormatInfo = Nothing
        Me.DataGridTextBoxColumn55.HeaderText = "Create Date"
        Me.DataGridTextBoxColumn55.MappingName = "createdate"
        Me.DataGridTextBoxColumn55.NullText = ""
        Me.DataGridTextBoxColumn55.Width = 75
        '
        'DataGridTextBoxColumn56
        '
        Me.DataGridTextBoxColumn56.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn56.FormatInfo = Nothing
        Me.DataGridTextBoxColumn56.HeaderText = "Update Date"
        Me.DataGridTextBoxColumn56.MappingName = "updatedate"
        Me.DataGridTextBoxColumn56.NullText = ""
        Me.DataGridTextBoxColumn56.Width = 75
        '
        'DataGridTextBoxColumn57
        '
        Me.DataGridTextBoxColumn57.Format = ""
        Me.DataGridTextBoxColumn57.FormatInfo = Nothing
        Me.DataGridTextBoxColumn57.HeaderText = "Encoder"
        Me.DataGridTextBoxColumn57.MappingName = "lastuser"
        Me.DataGridTextBoxColumn57.NullText = ""
        Me.DataGridTextBoxColumn57.Width = 90
        '
        'DG_pm
        '
        Me.DG_pm.AlternatingBackColor = System.Drawing.Color.Silver
        Me.DG_pm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DG_pm.BackColor = System.Drawing.Color.White
        Me.DG_pm.BackgroundColor = System.Drawing.Color.Lavender
        Me.DG_pm.CaptionBackColor = System.Drawing.Color.DarkSalmon
        Me.DG_pm.CaptionForeColor = System.Drawing.Color.White
        Me.DG_pm.CaptionText = "PMs OF ITEM"
        Me.DG_pm.DataMember = ""
        Me.DG_pm.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DG_pm.ForeColor = System.Drawing.Color.Black
        Me.DG_pm.GridLineColor = System.Drawing.Color.Silver
        Me.DG_pm.HeaderBackColor = System.Drawing.Color.Silver
        Me.DG_pm.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DG_pm.HeaderForeColor = System.Drawing.Color.Black
        Me.DG_pm.LinkColor = System.Drawing.Color.Maroon
        Me.DG_pm.Location = New System.Drawing.Point(711, 592)
        Me.DG_pm.Name = "DG_pm"
        Me.DG_pm.ParentRowsBackColor = System.Drawing.Color.Silver
        Me.DG_pm.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DG_pm.ReadOnly = True
        Me.DG_pm.SelectionBackColor = System.Drawing.Color.Maroon
        Me.DG_pm.SelectionForeColor = System.Drawing.Color.White
        Me.DG_pm.Size = New System.Drawing.Size(436, 120)
        Me.DG_pm.TabIndex = 37
        Me.DG_pm.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle6})
        Me.DG_pm.Tag = ""
        Me.DG_pm.Visible = False
        '
        'DataGridTableStyle6
        '
        Me.DataGridTableStyle6.AlternatingBackColor = System.Drawing.Color.MistyRose
        Me.DataGridTableStyle6.BackColor = System.Drawing.Color.LavenderBlush
        Me.DataGridTableStyle6.DataGrid = Me.DG_pm
        Me.DataGridTableStyle6.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn58, Me.DataGridTextBoxColumn59, Me.DataGridTextBoxColumn62, Me.DataGridTextBoxColumn63, Me.DataGridTextBoxColumn60, Me.DataGridTextBoxColumn61, Me.DataGridTextBoxColumn64, Me.DataGridTextBoxColumn65, Me.DataGridTextBoxColumn66})
        Me.DataGridTableStyle6.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle6.MappingName = "ItemProdMan_Show"
        '
        'DataGridTextBoxColumn58
        '
        Me.DataGridTextBoxColumn58.Format = ""
        Me.DataGridTextBoxColumn58.FormatInfo = Nothing
        Me.DataGridTextBoxColumn58.MappingName = "rowid"
        Me.DataGridTextBoxColumn58.NullText = ""
        Me.DataGridTextBoxColumn58.Width = 0
        '
        'DataGridTextBoxColumn59
        '
        Me.DataGridTextBoxColumn59.Format = ""
        Me.DataGridTextBoxColumn59.FormatInfo = Nothing
        Me.DataGridTextBoxColumn59.MappingName = "itemcode"
        Me.DataGridTextBoxColumn59.NullText = ""
        Me.DataGridTextBoxColumn59.Width = 0
        '
        'DataGridTextBoxColumn62
        '
        Me.DataGridTextBoxColumn62.Format = ""
        Me.DataGridTextBoxColumn62.FormatInfo = Nothing
        Me.DataGridTextBoxColumn62.HeaderText = "Start Date"
        Me.DataGridTextBoxColumn62.MappingName = "start_date"
        Me.DataGridTextBoxColumn62.NullText = ""
        Me.DataGridTextBoxColumn62.Width = 75
        '
        'DataGridTextBoxColumn63
        '
        Me.DataGridTextBoxColumn63.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn63.FormatInfo = Nothing
        Me.DataGridTextBoxColumn63.HeaderText = "End Date"
        Me.DataGridTextBoxColumn63.MappingName = "end_date"
        Me.DataGridTextBoxColumn63.NullText = ""
        Me.DataGridTextBoxColumn63.Width = 75
        '
        'DataGridTextBoxColumn60
        '
        Me.DataGridTextBoxColumn60.Format = ""
        Me.DataGridTextBoxColumn60.FormatInfo = Nothing
        Me.DataGridTextBoxColumn60.MappingName = "pmcode"
        Me.DataGridTextBoxColumn60.NullText = ""
        Me.DataGridTextBoxColumn60.Width = 0
        '
        'DataGridTextBoxColumn61
        '
        Me.DataGridTextBoxColumn61.Format = ""
        Me.DataGridTextBoxColumn61.FormatInfo = Nothing
        Me.DataGridTextBoxColumn61.HeaderText = "Product Manager"
        Me.DataGridTextBoxColumn61.MappingName = "pmname"
        Me.DataGridTextBoxColumn61.NullText = ""
        Me.DataGridTextBoxColumn61.Width = 200
        '
        'DataGridTextBoxColumn64
        '
        Me.DataGridTextBoxColumn64.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn64.FormatInfo = Nothing
        Me.DataGridTextBoxColumn64.HeaderText = "Create Date"
        Me.DataGridTextBoxColumn64.MappingName = "createdate"
        Me.DataGridTextBoxColumn64.NullText = ""
        Me.DataGridTextBoxColumn64.Width = 75
        '
        'DataGridTextBoxColumn65
        '
        Me.DataGridTextBoxColumn65.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn65.FormatInfo = Nothing
        Me.DataGridTextBoxColumn65.HeaderText = "Update Date"
        Me.DataGridTextBoxColumn65.MappingName = "updatedate"
        Me.DataGridTextBoxColumn65.NullText = ""
        Me.DataGridTextBoxColumn65.Width = 75
        '
        'DataGridTextBoxColumn66
        '
        Me.DataGridTextBoxColumn66.Format = ""
        Me.DataGridTextBoxColumn66.FormatInfo = Nothing
        Me.DataGridTextBoxColumn66.HeaderText = "Encoder"
        Me.DataGridTextBoxColumn66.MappingName = "lastuser"
        Me.DataGridTextBoxColumn66.NullText = ""
        Me.DataGridTextBoxColumn66.Width = 90
        '
        'cmdExit_Itm
        '
        Me.cmdExit_Itm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdExit_Itm.Location = New System.Drawing.Point(1220, 528)
        Me.cmdExit_Itm.Name = "cmdExit_Itm"
        Me.cmdExit_Itm.Size = New System.Drawing.Size(86, 34)
        Me.cmdExit_Itm.TabIndex = 20
        Me.cmdExit_Itm.Tag = "Exit"
        Me.cmdExit_Itm.Text = "E&xit"
        '
        'cmdAdd_Itm
        '
        Me.cmdAdd_Itm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdAdd_Itm.Image = CType(resources.GetObject("cmdAdd_Itm.Image"), System.Drawing.Image)
        Me.cmdAdd_Itm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAdd_Itm.Location = New System.Drawing.Point(944, 528)
        Me.cmdAdd_Itm.Name = "cmdAdd_Itm"
        Me.cmdAdd_Itm.Size = New System.Drawing.Size(86, 34)
        Me.cmdAdd_Itm.TabIndex = 17
        Me.cmdAdd_Itm.Tag = "Add"
        Me.cmdAdd_Itm.Text = "   &Add"
        '
        'cmdEdit_Itm
        '
        Me.cmdEdit_Itm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdEdit_Itm.Image = CType(resources.GetObject("cmdEdit_Itm.Image"), System.Drawing.Image)
        Me.cmdEdit_Itm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdEdit_Itm.Location = New System.Drawing.Point(1036, 528)
        Me.cmdEdit_Itm.Name = "cmdEdit_Itm"
        Me.cmdEdit_Itm.Size = New System.Drawing.Size(86, 34)
        Me.cmdEdit_Itm.TabIndex = 18
        Me.cmdEdit_Itm.Tag = "Edit"
        Me.cmdEdit_Itm.Text = "   &Edit"
        '
        'cmdDelete_Itm
        '
        Me.cmdDelete_Itm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdDelete_Itm.Image = CType(resources.GetObject("cmdDelete_Itm.Image"), System.Drawing.Image)
        Me.cmdDelete_Itm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDelete_Itm.Location = New System.Drawing.Point(1128, 528)
        Me.cmdDelete_Itm.Name = "cmdDelete_Itm"
        Me.cmdDelete_Itm.Size = New System.Drawing.Size(86, 34)
        Me.cmdDelete_Itm.TabIndex = 19
        Me.cmdDelete_Itm.Tag = "Delete"
        Me.cmdDelete_Itm.Text = "   &Delete"
        '
        'cmdExit_PM
        '
        Me.cmdExit_PM.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdExit_PM.Enabled = False
        Me.cmdExit_PM.Location = New System.Drawing.Point(1039, 712)
        Me.cmdExit_PM.Name = "cmdExit_PM"
        Me.cmdExit_PM.Size = New System.Drawing.Size(108, 18)
        Me.cmdExit_PM.TabIndex = 45
        Me.cmdExit_PM.Tag = ""
        '
        'cmdAdd_PM
        '
        Me.cmdAdd_PM.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdAdd_PM.Location = New System.Drawing.Point(711, 712)
        Me.cmdAdd_PM.Name = "cmdAdd_PM"
        Me.cmdAdd_PM.Size = New System.Drawing.Size(108, 18)
        Me.cmdAdd_PM.TabIndex = 42
        Me.cmdAdd_PM.Tag = "Add"
        Me.cmdAdd_PM.Text = "Add"
        '
        'cmdEdit_PM
        '
        Me.cmdEdit_PM.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdEdit_PM.Location = New System.Drawing.Point(820, 712)
        Me.cmdEdit_PM.Name = "cmdEdit_PM"
        Me.cmdEdit_PM.Size = New System.Drawing.Size(108, 18)
        Me.cmdEdit_PM.TabIndex = 43
        Me.cmdEdit_PM.Tag = "Edit"
        Me.cmdEdit_PM.Text = "Edit"
        '
        'cmdDelete_PM
        '
        Me.cmdDelete_PM.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdDelete_PM.Location = New System.Drawing.Point(929, 712)
        Me.cmdDelete_PM.Name = "cmdDelete_PM"
        Me.cmdDelete_PM.Size = New System.Drawing.Size(108, 18)
        Me.cmdDelete_PM.TabIndex = 44
        Me.cmdDelete_PM.Tag = "Delete"
        Me.cmdDelete_PM.Text = "Delete"
        '
        'cmdExit_NSM
        '
        Me.cmdExit_NSM.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdExit_NSM.Enabled = False
        Me.cmdExit_NSM.Location = New System.Drawing.Point(595, 712)
        Me.cmdExit_NSM.Name = "cmdExit_NSM"
        Me.cmdExit_NSM.Size = New System.Drawing.Size(108, 18)
        Me.cmdExit_NSM.TabIndex = 41
        Me.cmdExit_NSM.Tag = ""
        '
        'cmdAdd_NSM
        '
        Me.cmdAdd_NSM.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdAdd_NSM.Location = New System.Drawing.Point(268, 712)
        Me.cmdAdd_NSM.Name = "cmdAdd_NSM"
        Me.cmdAdd_NSM.Size = New System.Drawing.Size(108, 18)
        Me.cmdAdd_NSM.TabIndex = 38
        Me.cmdAdd_NSM.Tag = "Add"
        Me.cmdAdd_NSM.Text = "Add"
        '
        'cmdEdit_NSM
        '
        Me.cmdEdit_NSM.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdEdit_NSM.Location = New System.Drawing.Point(377, 712)
        Me.cmdEdit_NSM.Name = "cmdEdit_NSM"
        Me.cmdEdit_NSM.Size = New System.Drawing.Size(108, 18)
        Me.cmdEdit_NSM.TabIndex = 39
        Me.cmdEdit_NSM.Tag = "Edit"
        Me.cmdEdit_NSM.Text = "Edit"
        '
        'cmdDelete_NSM
        '
        Me.cmdDelete_NSM.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdDelete_NSM.Location = New System.Drawing.Point(486, 712)
        Me.cmdDelete_NSM.Name = "cmdDelete_NSM"
        Me.cmdDelete_NSM.Size = New System.Drawing.Size(108, 18)
        Me.cmdDelete_NSM.TabIndex = 40
        Me.cmdDelete_NSM.Tag = "Delete"
        Me.cmdDelete_NSM.Text = "Delete"
        '
        'txtItemCode
        '
        Me.txtItemCode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtItemCode.Location = New System.Drawing.Point(962, 4)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(124, 20)
        Me.txtItemCode.TabIndex = 107
        Me.txtItemCode.Tag = ""
        Me.txtItemCode.Text = "txtItemCode"
        Me.txtItemCode.Visible = False
        '
        'TxtStat1
        '
        Me.TxtStat1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtStat1.BackColor = System.Drawing.SystemColors.Window
        Me.TxtStat1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtStat1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TxtStat1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStat1.Location = New System.Drawing.Point(24, 4)
        Me.TxtStat1.MaxLength = 1
        Me.TxtStat1.Name = "TxtStat1"
        Me.TxtStat1.ReadOnly = True
        Me.TxtStat1.Size = New System.Drawing.Size(14, 20)
        Me.TxtStat1.TabIndex = 108
        Me.TxtStat1.Text = ""
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 20)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "<--  Click here to show only  ""INACTIVE ITEMS"""
        '
        'txtRowid
        '
        Me.txtRowid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtRowid.Location = New System.Drawing.Point(894, 4)
        Me.txtRowid.Name = "txtRowid"
        Me.txtRowid.Size = New System.Drawing.Size(54, 20)
        Me.txtRowid.TabIndex = 115
        Me.txtRowid.Tag = ""
        Me.txtRowid.Text = "txtRowid"
        Me.txtRowid.Visible = False
        '
        'txtNSMrowid
        '
        Me.txtNSMrowid.Location = New System.Drawing.Point(120, 600)
        Me.txtNSMrowid.Name = "txtNSMrowid"
        Me.txtNSMrowid.Size = New System.Drawing.Size(13, 20)
        Me.txtNSMrowid.TabIndex = 120
        Me.txtNSMrowid.Tag = "Input"
        Me.txtNSMrowid.Text = ""
        Me.txtNSMrowid.Visible = False
        '
        'txtPMrowid
        '
        Me.txtPMrowid.Location = New System.Drawing.Point(556, 598)
        Me.txtPMrowid.Name = "txtPMrowid"
        Me.txtPMrowid.Size = New System.Drawing.Size(13, 20)
        Me.txtPMrowid.TabIndex = 121
        Me.txtPMrowid.Tag = "Input"
        Me.txtPMrowid.Text = ""
        Me.txtPMrowid.Visible = False
        '
        'ItemCT
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1326, 574)
        Me.Controls.Add(Me.txtPMrowid)
        Me.Controls.Add(Me.txtNSMrowid)
        Me.Controls.Add(Me.txtRowid)
        Me.Controls.Add(Me.TxtStat1)
        Me.Controls.Add(Me.txtItemCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdExit_PM)
        Me.Controls.Add(Me.cmdAdd_PM)
        Me.Controls.Add(Me.cmdEdit_PM)
        Me.Controls.Add(Me.cmdDelete_PM)
        Me.Controls.Add(Me.cmdExit_NSM)
        Me.Controls.Add(Me.cmdAdd_NSM)
        Me.Controls.Add(Me.cmdEdit_NSM)
        Me.Controls.Add(Me.cmdDelete_NSM)
        Me.Controls.Add(Me.DG_pm)
        Me.Controls.Add(Me.DG_nsm)
        Me.Controls.Add(Me.cmdExit_Itm)
        Me.Controls.Add(Me.cmdAdd_Itm)
        Me.Controls.Add(Me.cmdEdit_Itm)
        Me.Controls.Add(Me.cmdDelete_Itm)
        Me.Controls.Add(Me.DG_items)
        Me.MaximizeBox = False
        Me.Name = "ItemCT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item File Maintenance"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DG_items, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_nsm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_pm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub Itm_Sub_Show()
        Try
            If RemoteDataSet.ItemCodTab_Show.Count > 0 Then RemoteDataSet.ItemCodTab_Show.Clear()
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            If Trim(TxtStat1.Text) = "" Then
                itmX = "ItemCodTab_Show"
                'MessageBox.Show(itmX)
            ElseIf Trim(TxtStat1.Text) = "X" Then
                itmX = "ItemCodTab_Show_X"
            End If
            BusinessObject.Sub_Show(ServerPath2, itmX, CommandType.StoredProcedure, RemoteDataSet, "ItemCodTab_Show")
            DG_items.DataSource = RemoteDataSet.ItemCodTab_Show
            PopulateGrids()
            txtItemCode.Text = DG_items.Item(DG_items.CurrentCell.RowNumber, 1).ToString
            LogHelper.InsertLog("ItemCodTab_Show.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("ItemCodTab_Show.Error: " & ex.Message)
        End Try
    End Sub

    Public Sub Itm_Sub_Select(ByVal dbParams() As String, ByVal UpdateMode As String)
        Dim myRowid As Integer
        Select Case UpdateMode
            Case "Insert"
                Dim BusinessObject As New BusinessLayer.clsFileMaintenance
                myRowid = CInt(BusinessObject.Sub_ReturnIntegerResult(ServerPath2, "ItemCT_GetInsertedRowid", CommandType.StoredProcedure))
            Case "Update"
                myRowid = CInt(dbParams(0))
        End Select
        For i = 0 To (RemoteDataSet.ItemCodTab_Show.Rows.Count - 1)
            With DG_items
                If myRowid = CInt(.Item(i, 0)) Then
                    .CurrentCell = New DataGridCell(i, 0)
                    'Dim e As System.EventArgs
                    'DataGrid1_Click(Me, e)
                    Exit For
                End If
            End With
        Next
    End Sub

    Private Sub ItemCT_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        modControlBehavior.EnableControls(Me, False)

    End Sub

    Private Sub NSM_List()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter
        Dim ItemCode As New SqlParameter("@ItemCode", SqlDbType.VarChar, 10)
        ItemCode.Direction = ParameterDirection.Input
        ItemCode.Value = DG_items.Item(DG_items.CurrentCell.RowNumber, 1).ToString
        Params(0) = ItemCode

        If RemoteDataSet.ItemNSM_Show.Count > 0 Then RemoteDataSet.ItemNSM_Show.Clear()
        Try
            BusinessObject.Sub_Show(ServerPath2, "ItemNSM_Show", CommandType.StoredProcedure, RemoteDataSet, "ItemNSM_Show", Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        DG_nsm.DataSource = RemoteDataSet.ItemNSM_Show
    End Sub

    Private Sub PM_List()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter
        Dim ItemCode As New SqlParameter("@ItemCode", SqlDbType.VarChar, 10)
        ItemCode.Direction = ParameterDirection.Input
        ItemCode.Value = DG_items.Item(DG_items.CurrentCell.RowNumber, 1).ToString
        Params(0) = ItemCode

        If RemoteDataSet.ItemProdMan_Show.Count > 0 Then RemoteDataSet.ItemProdMan_Show.Clear()
        Try
            BusinessObject.Sub_Show(ServerPath2, "ItemProdMan_Show", CommandType.StoredProcedure, RemoteDataSet, "ItemProdMan_Show", Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        DG_pm.DataSource = RemoteDataSet.ItemProdMan_Show
    End Sub

    Private Sub DG_items_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DG_items.Click, DG_items.CurrentCellChanged
        PopulateGrids()
        txtRowid.Text = DG_items.Item(DG_items.CurrentCell.RowNumber, 0).ToString
        txtItemCode.Text = DG_items.Item(DG_items.CurrentCell.RowNumber, 1).ToString
    End Sub

    Private Sub PopulateGrids()
        'PriceHist()
        'DivList()
        'PrinList()
        NSM_List()
        PM_List()
    End Sub

    Private Sub cmdAdd_itm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd_Itm.Click
        Dim MyLoadedForm As New Itm_Entry
        Itm_EditMode = False
        MyLoadedForm.ShowDialog(Me)
        Dim Params(0) As String
        Params(0) = ""
        Itm_Sub_Show()
        Itm_Sub_Select(Params, CStr(IIf(Itm_EditMode = False, "Insert", "Update")))
    End Sub

    Private Sub cmdEdit_itm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit_Itm.Click
        'modControlBehavior.EnableControlsGroup(Me, True)
        Dim MyLoadedForm As New Itm_Entry
        Dim tmpDate As String, s As String
        Dim tmpRowid As String
        MyLoadedForm.vRowId.Text = DG_items.Item(DG_items.CurrentCell.RowNumber, 0).ToString
        tmpRowid = DG_items.Item(DG_items.CurrentCell.RowNumber, 0).ToString
        MyLoadedForm.vItemCode.Text = DG_items.Item(DG_items.CurrentCell.RowNumber, 1).ToString
        MyLoadedForm.vMetroDrugCode.Text = Trim(DG_items.Item(DG_items.CurrentCell.RowNumber, 2).ToString)
        MyLoadedForm.vMercuryItemCode.Text = Trim(DG_items.Item(DG_items.CurrentCell.RowNumber, 3).ToString)
        MyLoadedForm.vItemDesc.Text = DG_items.Item(DG_items.CurrentCell.RowNumber, 4).ToString
        MyLoadedForm.vGenericName.Text = DG_items.Item(DG_items.CurrentCell.RowNumber, 5).ToString
        s = DG_items.Item(DG_items.CurrentCell.RowNumber, 6).ToString
        'If InStr(s, "'") <> 0 Then
        '    s = StrTran(s, "''", "'")
        'End If
        MyLoadedForm.vItemUnit.Text = s
        MyLoadedForm.vUnitConversion.Text = DG_items.Item(DG_items.CurrentCell.RowNumber, 7).ToString
        MyLoadedForm.vUnitPrice.Text = DG_items.Item(DG_items.CurrentCell.RowNumber, 8).ToString
        MyLoadedForm.vMercurySTPrice.Text = DG_items.Item(DG_items.CurrentCell.RowNumber, 9).ToString
        MyLoadedForm.vPrinCode.Text = DG_items.Item(DG_items.CurrentCell.RowNumber, 10).ToString

        MyLoadedForm.cboPrincipal.Text = DG_items.Item(DG_items.CurrentCell.RowNumber, 11).ToString
        Filds(11) = DG_items.Item(DG_items.CurrentCell.RowNumber, 11).ToString

        MyLoadedForm.vDivCode.Text = DG_items.Item(DG_items.CurrentCell.RowNumber, 12).ToString

        MyLoadedForm.cboDivision.Text = DG_items.Item(DG_items.CurrentCell.RowNumber, 13).ToString
        Filds(13) = DG_items.Item(DG_items.CurrentCell.RowNumber, 13).ToString

        MyLoadedForm.vProductLine.Text = DG_items.Item(DG_items.CurrentCell.RowNumber, 14).ToString
        MyLoadedForm.vProductForm.Text = DG_items.Item(DG_items.CurrentCell.RowNumber, 15).ToString
        MyLoadedForm.vLine.Text = DG_items.Item(DG_items.CurrentCell.RowNumber, 16).ToString

        tmpDate = DG_items.Item(DG_items.CurrentCell.RowNumber, 17).ToString
        If Trim(tmpDate) <> "" Then
            MyLoadedForm.vLaunchDate.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
        End If

        tmpDate = DG_items.Item(DG_items.CurrentCell.RowNumber, 18).ToString
        If Trim(tmpDate) <> "" Then
            MyLoadedForm.vInActiveDate.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
        End If

        MyLoadedForm.cboStatus.Text = DG_items.Item(DG_items.CurrentCell.RowNumber, 19).ToString
        Filds(19) = DG_items.Item(DG_items.CurrentCell.RowNumber, 19).ToString

        MyLoadedForm.vLastUser.Text = DG_items.Item(DG_items.CurrentCell.RowNumber, 20).ToString

        tmpDate = DG_items.Item(DG_items.CurrentCell.RowNumber, 21).ToString
        If Trim(tmpDate) <> "" Then
            MyLoadedForm.vCreateDate.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
        End If

        tmpDate = DG_items.Item(DG_items.CurrentCell.RowNumber, 22).ToString
        MyLoadedForm.PrdLineCode = DG_items.Item(DG_items.CurrentCell.RowNumber, 24).ToString
        MyLoadedForm.PrdFormCode = DG_items.Item(DG_items.CurrentCell.RowNumber, 25).ToString

        If Trim(tmpDate) <> "" Then
            MyLoadedForm.vUpdateDate.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
        End If

        Itm_EditMode = True
        MyLoadedForm.ShowDialog(Me)
        Me.Refresh()
        Dim Params(0) As String
        Params(0) = tmpRowid
        Itm_Sub_Show()
        Itm_Sub_Select(Params, CStr(IIf(Itm_EditMode = False, "Insert", "Update")))
    End Sub

    Private Sub cmdDelete_Itm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete_Itm.Click
        If txtItemCode.Text > "" Then
            If (MessageBox.Show("Do you really want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, _
            MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then
                SubItm_Delete()
                ControlMaintenance.ClearInputControls(Me)
                Itm_Sub_Show()
            End If
        End If
    End Sub

    Private Sub SubItm_Delete()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim ItemCode As New SqlParameter("@Rowid", SqlDbType.Int)
            ItemCode.Direction = ParameterDirection.Input
            ItemCode.Value = jTrim(txtRowid.Text)
            Params(0) = ItemCode
            BusinessObject.Sub_Delete(ServerPath2, "ItemCT_Delete", CommandType.StoredProcedure, Params)
            LogHelper.InsertLog("ItemCT_Delete.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("ItemCT_Delete.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub TxtStat1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtStat1.Click
        If Trim(TxtStat1.Text) = "" Then
            TxtStat1.Text = "X"
            Label1.Text = "<--  Click here to show only  'ACTIVE ITEMS'"
        Else
            TxtStat1.Text = ""
            Label1.Text = "<--  Click here to show only  'INACTIVE ITEMS'"
        End If
        Itm_Sub_Show()
    End Sub

    Private Sub cmdExit_Itm_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdExit_Itm.Click
        Close()
    End Sub

    Private Sub cmdAdd_NSM_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd_NSM.Click
        Dim MyLoadedForm As New Insm_Entry
        Itm_EditMode = False
        MyLoadedForm.vItemCode.Text = jTrim(txtItemCode.Text)
        MyLoadedForm.vCreateDate.Text = GetDateTimeNow("MM/dd/yyyy")
        MyLoadedForm.vUpdateDate.Text = GetDateTimeNow("MM/dd/yyyy")
        MyLoadedForm.ShowDialog(Me)
    End Sub

    Private Sub cmdEdit_NSM_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdEdit_NSM.Click
        Dim MyLoadedForm As New Insm_Entry
        Dim tmpDate As String
        Dim s As String
        MyLoadedForm.vRowId.Text = DG_nsm.Item(DG_nsm.CurrentCell.RowNumber, 0).ToString
        MyLoadedForm.vItemCode.Text = DG_nsm.Item(DG_nsm.CurrentCell.RowNumber, 1).ToString

        tmpDate = DG_nsm.Item(DG_nsm.CurrentCell.RowNumber, 2).ToString
        If Trim(tmpDate) <> "" Then
            MyLoadedForm.vStart_Date.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
            MyLoadedForm.vStart_DateO.Text = DG_nsm.Item(DG_nsm.CurrentCell.RowNumber, 2).ToString
        End If

        tmpDate = DG_nsm.Item(DG_nsm.CurrentCell.RowNumber, 3).ToString
        If Trim(tmpDate) <> "" Then
            MyLoadedForm.vEnd_Date.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
        End If

        Filds(4) = DG_nsm.Item(DG_nsm.CurrentCell.RowNumber, 5).ToString
        MyLoadedForm.cboNSM.Text = Filds(4).ToString
        MyLoadedForm.cboNSMo.Text = DG_nsm.Item(DG_nsm.CurrentCell.RowNumber, 5).ToString

        tmpDate = DG_nsm.Item(DG_nsm.CurrentCell.RowNumber, 6).ToString
        If Trim(tmpDate) <> "" Then
            MyLoadedForm.vCreateDate.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
        End If

        tmpDate = DG_nsm.Item(DG_nsm.CurrentCell.RowNumber, 7).ToString
        If Trim(tmpDate) <> "" Then
            MyLoadedForm.vUpdateDate.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
        End If

        MyLoadedForm.vLastUser.Text = DG_nsm.Item(DG_nsm.CurrentCell.RowNumber, 8).ToString

        Itm_EditMode = True
        MyLoadedForm.ShowDialog(Me)
        Me.Refresh()
        NSM_List()
    End Sub

    Private Sub cmdDelete_NSM_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete_NSM.Click
        If txtItemCode.Text > "" Then
            If (MessageBox.Show("Do you really want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, _
            MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then
                SubInsm_Delete()
                ControlMaintenance.ClearInputControls(Me)
                NSM_List()
            End If
        End If
    End Sub

    Private Sub SubInsm_Delete()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(2) As SqlParameter

            Dim ItemCode As New SqlParameter("@ItemCode", SqlDbType.VarChar, 10)
            ItemCode.Direction = ParameterDirection.Input
            ItemCode.Value = jTrim(txtItemCode.Text)
            Params(0) = ItemCode

            Dim NSMCode As New SqlParameter("@NSMCode", SqlDbType.VarChar, 25)
            NSMCode.Direction = ParameterDirection.Input
            NSMCode.Value = DG_nsm.Item(DG_nsm.CurrentCell.RowNumber, 4).ToString
            Params(1) = NSMCode

            Dim Start_Date As New SqlParameter("@Start_Date", SqlDbType.DateTime)
            Start_Date.Direction = ParameterDirection.Input
            Start_Date.Value = DG_nsm.Item(DG_nsm.CurrentCell.RowNumber, 2).ToString
            Params(2) = Start_Date

            BusinessObject.Sub_Delete(ServerPath2, "ItemNSM_del", CommandType.StoredProcedure, Params)
            LogHelper.InsertLog("ItemNSM_del.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("ItemNSM_del.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub cmdAdd_PM_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd_PM.Click
        Dim MyLoadedForm As New Ipm_Entry
        Itm_EditMode = False
        MyLoadedForm.vItemCode.Text = jTrim(txtItemCode.Text)
        MyLoadedForm.vCreateDate.Text = GetDateTimeNow("MM/dd/yyyy")
        MyLoadedForm.vUpdateDate.Text = GetDateTimeNow("MM/dd/yyyy")
        MyLoadedForm.ShowDialog(Me)
    End Sub

    Private Sub cmdEdit_PM_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdEdit_PM.Click
        Dim MyLoadedForm As New Ipm_Entry
        Dim tmpDate As String
        Dim s As String
        MyLoadedForm.vRowId.Text = DG_pm.Item(DG_pm.CurrentCell.RowNumber, 0).ToString
        MyLoadedForm.vItemCode.Text = DG_pm.Item(DG_pm.CurrentCell.RowNumber, 1).ToString

        tmpDate = DG_pm.Item(DG_pm.CurrentCell.RowNumber, 2).ToString
        If Trim(tmpDate) <> "" Then
            MyLoadedForm.vStart_Date.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
            MyLoadedForm.vStart_DateO.Text = DG_pm.Item(DG_pm.CurrentCell.RowNumber, 2).ToString
        End If

        tmpDate = DG_pm.Item(DG_pm.CurrentCell.RowNumber, 3).ToString
        If Trim(tmpDate) <> "" Then
            MyLoadedForm.vEnd_Date.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
        End If

        Filds(4) = DG_pm.Item(DG_pm.CurrentCell.RowNumber, 5).ToString
        MyLoadedForm.cboPM.Text = Filds(4).ToString
        MyLoadedForm.cboPMo.Text = DG_pm.Item(DG_pm.CurrentCell.RowNumber, 5).ToString

        tmpDate = DG_pm.Item(DG_pm.CurrentCell.RowNumber, 6).ToString
        If Trim(tmpDate) <> "" Then
            MyLoadedForm.vCreateDate.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
        End If

        tmpDate = DG_pm.Item(DG_pm.CurrentCell.RowNumber, 7).ToString
        If Trim(tmpDate) <> "" Then
            MyLoadedForm.vUpdateDate.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
        End If

        MyLoadedForm.vLastUser.Text = DG_pm.Item(DG_pm.CurrentCell.RowNumber, 8).ToString

        Itm_EditMode = True
        MyLoadedForm.ShowDialog(Me)
        Me.Refresh()
        PM_List()
    End Sub

    Private Sub cmdDelete_PM_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete_PM.Click
        If txtItemCode.Text > "" Then
            If (MessageBox.Show("Do you really want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, _
            MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then
                SubIpm_Delete()
                ControlMaintenance.ClearInputControls(Me)
                PM_List()
            End If
        End If
    End Sub

    Private Sub SubIpm_Delete()
        Try

            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(2) As SqlParameter

            Dim ItemCode As New SqlParameter("@ItemCode", SqlDbType.VarChar, 10)
            ItemCode.Direction = ParameterDirection.Input
            ItemCode.Value = jTrim(txtItemCode.Text)
            Params(0) = ItemCode

            Dim PMCode As New SqlParameter("@PMCode", SqlDbType.VarChar, 3)
            PMCode.Direction = ParameterDirection.Input
            PMCode.Value = DG_pm.Item(DG_pm.CurrentCell.RowNumber, 4).ToString
            Params(1) = PMCode

            Dim Start_Date As New SqlParameter("@Start_Date", SqlDbType.DateTime)
            Start_Date.Direction = ParameterDirection.Input
            Start_Date.Value = DG_pm.Item(DG_pm.CurrentCell.RowNumber, 2).ToString
            Params(2) = Start_Date
            BusinessObject.Sub_Delete(ServerPath2, "ItemPM_del", CommandType.StoredProcedure, Params)
            LogHelper.InsertLog("ItemPM_del.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("ItemPM_del.Error: " & ex.Message)
        End Try
    End Sub

    'Private Sub DivSubList()
    '    Dim BusinessObject As New BusinessLayer.clsFileMaintenance
    '    Dim Param(1) As SqlParameter
    '    Dim ItemCode2 As New SqlParameter("@ItemCode2", SqlDbType.VarChar, 10)
    '    ItemCode2.Direction = ParameterDirection.Input
    '    ItemCode2.Value = DG_items.Item(DG_items.CurrentCell.RowNumber, 1).ToString
    '    Param(0) = ItemCode2
    '    Dim DivCode As New SqlParameter("@DivCode", SqlDbType.VarChar, 3)
    '    DivCode.Direction = ParameterDirection.Input
    '    DivCode.Value = DG_div.Item(DG_div.CurrentCell.RowNumber, 4).ToString
    '    Param(1) = DivCode

    '    If RemoteDataSet.ItemDivSubGrp_Show.Count > 0 Then RemoteDataSet.ItemDivSubGrp_Show.Clear()
    '    Try
    '        BusinessObject.Sub_Show(ServerPath2, "ItemDivSubGrp_Show", CommandType.StoredProcedure, RemoteDataSet, "ItemDivSubGrp_Show", Param)
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    '    DG_dsg.DataSource = RemoteDataSet.ItemDivSubGrp_Show
    'End Sub

    'Private Sub DG_dsg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    txtDIVSUBrowid.Text = DG_dsg.Item(DG_dsg.CurrentCell.RowNumber, 0).ToString
    'End Sub

    'Private Sub cmdAdd_Dsg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim MyLoadedForm As New Idsg_Entry
    '    Dim tmpdat As String
    '    Itm_EditMode = False
    '    tmpdat = GetDateTimeNow("MM/dd/yyyy")
    '    MyLoadedForm.vItemCode.Text = jTrim(txtItemCode.Text)
    '    MyLoadedForm.vDivCode.Text = jTrim(GetCode(DG_div.Item(DG_div.CurrentCell.RowNumber, 5).ToString))
    '    MyLoadedForm.vCreateDate.Text = tmpdat
    '    MyLoadedForm.vUpdateDate.Text = tmpdat
    '    cancelProcess = False
    '    MyLoadedForm.ShowDialog(Me)
    '    Dim Params(0) As String
    '    Params(0) = ""
    '    DivSubList()
    '    If cancelProcess = False Then
    '        'PH_Sub_Select(Params, CStr(IIf(Itm_EditMode = False, "Insert", "Update")))
    '    End If
    'End Sub

    'Private Sub cmdEdit_Dsg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim MyLoadedForm As New Idsg_Entry
    '    Dim tmpDate As String
    '    Dim s As String
    '    MyLoadedForm.vRowId.Text = DG_dsg.Item(DG_dsg.CurrentCell.RowNumber, 0).ToString
    '    MyLoadedForm.vItemCode.Text = DG_dsg.Item(DG_dsg.CurrentCell.RowNumber, 1).ToString
    '    MyLoadedForm.vDivCode.Text = DG_dsg.Item(DG_dsg.CurrentCell.RowNumber, 2).ToString

    '    tmpDate = DG_dsg.Item(DG_dsg.CurrentCell.RowNumber, 3).ToString
    '    If Trim(tmpDate) <> "" Then
    '        MyLoadedForm.vStart_Date.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
    '    End If

    '    tmpDate = DG_dsg.Item(DG_dsg.CurrentCell.RowNumber, 4).ToString
    '    If Trim(tmpDate) <> "" Then
    '        MyLoadedForm.vEnd_Date.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
    '    End If

    '    Filds(4) = DG_dsg.Item(DG_dsg.CurrentCell.RowNumber, 6).ToString
    '    MyLoadedForm.cboDivisionSG.Text = Filds(4).ToString

    '    tmpDate = DG_dsg.Item(DG_dsg.CurrentCell.RowNumber, 7).ToString
    '    If Trim(tmpDate) <> "" Then
    '        MyLoadedForm.vCreateDate.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
    '    End If

    '    tmpDate = DG_dsg.Item(DG_dsg.CurrentCell.RowNumber, 8).ToString
    '    If Trim(tmpDate) <> "" Then
    '        MyLoadedForm.vUpdateDate.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
    '    End If

    '    MyLoadedForm.vLastUser.Text = DG_dsg.Item(DG_dsg.CurrentCell.RowNumber, 9).ToString

    '    Itm_EditMode = True
    '    MyLoadedForm.ShowDialog(Me)
    '    Me.Refresh()
    '    DivList()
    'End Sub

    'Private Sub cmdDelete_Dsg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If txtItemCode.Text > "" Then
    '        If (jTrim(GetCode(DG_div.Item(DG_div.CurrentCell.RowNumber, 5).ToString))) > "" Then
    '            If (MessageBox.Show("Do you really want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, _
    '                MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then

    '                SubIdsg_Delete()
    '                ControlMaintenance.ClearInputControls(Me)
    '                DivSubList()
    '            End If
    '        End If
    '    End If
    'End Sub

    'Private Sub SubIdsg_Delete()
    '    Dim BusinessObject As New BusinessLayer.clsFileMaintenance
    '    Dim Params(0) As SqlParameter

    '    Dim Rowid As New SqlParameter("@Rowid", SqlDbType.Int)
    '    Rowid.Direction = ParameterDirection.Input
    '    Rowid.Value = jTrim(DG_dsg.Item(DG_dsg.CurrentCell.RowNumber, 0).ToString)
    '    Params(0) = Rowid

    '    Try
    '        BusinessObject.Sub_Delete(ServerPath2, "ItemDivSubGrp_del", CommandType.StoredProcedure, Params)
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Public Sub DSG_Sub_Select(ByVal dbParams() As String, ByVal UpdateMode As String)
        Dim myRowid As Integer
        Select Case UpdateMode
            Case "Insert"
                Dim BusinessObject As New BusinessLayer.clsFileMaintenance
                myRowid = CInt(BusinessObject.Sub_ReturnIntegerResult(ServerPath2, "ItemPH_GetInsertedRowid", CommandType.StoredProcedure))
            Case "Update"
                myRowid = CInt(dbParams(0))
        End Select
        For i = 0 To (RemoteDataSet.ItemPriceHist_DS_Show.Rows.Count - 1)
            With DG_items
                If myRowid = CInt(.Item(i, 0)) Then
                    .CurrentCell = New DataGridCell(i, 0)
                    'Dim e As System.EventArgs
                    'DataGrid1_Click(Me, e)
                    Exit For
                End If
            End With
        Next
    End Sub

    ''<--Division codes
    'Private Sub DivList()
    '    Dim BusinessObject As New BusinessLayer.clsFileMaintenance
    '    Dim Param(0) As SqlParameter
    '    Dim ItemCode2 As New SqlParameter("@ItemCode2", SqlDbType.VarChar, 10)
    '    ItemCode2.Direction = ParameterDirection.Input
    '    ItemCode2.Value = DG_items.Item(DG_items.CurrentCell.RowNumber, 1).ToString
    '    Param(0) = ItemCode2

    '    If RemoteDataSet.ItemDivision_Show.Count > 0 Then RemoteDataSet.ItemDivision_Show.Clear()
    '    Try
    '        BusinessObject.Sub_Show(ServerPath2, "ItemDivision2_Show", CommandType.StoredProcedure, RemoteDataSet, "ItemDivision_Show", Param)
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    '    DG_div.DataSource = RemoteDataSet.ItemDivision_Show
    'End Sub

    'Private Sub DG_div_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    txtDIVrowid.Text = DG_div.Item(DG_div.CurrentCell.RowNumber, 0).ToString
    'End Sub

    'Private Sub cmdAdd_DIV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim MyLoadedForm As New Idiv_Entry
    '    Itm_EditMode = False
    '    MyLoadedForm.vItemCode.Text = jTrim(txtItemCode.Text)
    '    MyLoadedForm.vCreateDate.Text = GetDateTimeNow("MM/dd/yyyy")
    '    MyLoadedForm.vUpdateDate.Text = GetDateTimeNow("MM/dd/yyyy")
    '    cancelProcess = False
    '    MyLoadedForm.ShowDialog(Me)
    '    Dim Params(0) As String
    '    Params(0) = ""
    '    DivList()
    '    If cancelProcess = False Then
    '        Div_Sub_Select(Params, CStr(IIf(Itm_EditMode = False, "Insert", "Update")))
    '    End If
    'End Sub

    'Private Sub cmdEdit_DIV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim MyLoadedForm As New Idiv_Entry
    '    Dim tmpDate As String
    '    Dim s As String
    '    MyLoadedForm.vRowId.Text = DG_div.Item(DG_div.CurrentCell.RowNumber, 0).ToString
    '    tmpRowid = DG_div.Item(DG_div.CurrentCell.RowNumber, 0).ToString
    '    MyLoadedForm.vItemCode.Text = DG_div.Item(DG_div.CurrentCell.RowNumber, 1).ToString

    '    tmpDate = DG_div.Item(DG_div.CurrentCell.RowNumber, 2).ToString
    '    If Trim(tmpDate) <> "" Then
    '        MyLoadedForm.vStart_Date.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
    '        MyLoadedForm.vStart_DateO.Text = DG_div.Item(DG_div.CurrentCell.RowNumber, 2).ToString
    '    End If

    '    tmpDate = DG_div.Item(DG_div.CurrentCell.RowNumber, 3).ToString
    '    If Trim(tmpDate) <> "" Then
    '        MyLoadedForm.vEnd_Date.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
    '    End If

    '    Filds(4) = DG_div.Item(DG_div.CurrentCell.RowNumber, 5).ToString
    '    MyLoadedForm.cboDivision.Text = Filds(4).ToString
    '    MyLoadedForm.cboDivisionO.Text = DG_div.Item(DG_div.CurrentCell.RowNumber, 5).ToString

    '    tmpDate = DG_div.Item(DG_div.CurrentCell.RowNumber, 6).ToString
    '    If Trim(tmpDate) <> "" Then
    '        MyLoadedForm.vCreateDate.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
    '    End If

    '    tmpDate = DG_div.Item(DG_div.CurrentCell.RowNumber, 7).ToString
    '    If Trim(tmpDate) <> "" Then
    '        MyLoadedForm.vUpdateDate.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
    '    End If

    '    MyLoadedForm.vLastUser.Text = DG_div.Item(DG_div.CurrentCell.RowNumber, 8).ToString

    '    Itm_EditMode = True
    '    MyLoadedForm.ShowDialog(Me)
    '    Me.Refresh()
    '    Dim Params(0) As String
    '    Params(0) = tmpRowid
    '    DivList()
    '    Div_Sub_Select(Params, CStr(IIf(Itm_EditMode = False, "Insert", "Update")))
    'End Sub

    'Private Sub cmdDelete_DIV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If txtItemCode.Text > "" Then
    '        If (MessageBox.Show("Do you really want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, _
    '        MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then
    '            SubIdiv_Delete()
    '            ControlMaintenance.ClearInputControls(Me)
    '            DivList()
    '        End If
    '    End If
    'End Sub

    'Private Sub SubIdiv_Delete()
    '    Dim BusinessObject As New BusinessLayer.clsFileMaintenance
    '    Dim Params(2) As SqlParameter

    '    Dim ItemCode As New SqlParameter("@ItemCode", SqlDbType.VarChar, 10)
    '    ItemCode.Direction = ParameterDirection.Input
    '    ItemCode.Value = jTrim(txtItemCode.Text)
    '    Params(0) = ItemCode

    '    Dim DivCode As New SqlParameter("@DivCode", SqlDbType.VarChar, 3)
    '    DivCode.Direction = ParameterDirection.Input
    '    DivCode.Value = DG_div.Item(DG_div.CurrentCell.RowNumber, 4).ToString
    '    Params(1) = DivCode

    '    Dim Start_Date As New SqlParameter("@Start_Date", SqlDbType.DateTime)
    '    Start_Date.Direction = ParameterDirection.Input
    '    Start_Date.Value = DG_div.Item(DG_div.CurrentCell.RowNumber, 2).ToString
    '    Params(2) = Start_Date

    '    Try
    '        BusinessObject.Sub_Delete(ServerPath2, "ItemDiv_del", CommandType.StoredProcedure, Params)
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Public Sub Div_Sub_Select(ByVal dbParams() As String, ByVal UpdateMode As String)
        Dim myRowid As Integer
        Select Case UpdateMode
            Case "Insert"
                Dim BusinessObject As New BusinessLayer.clsFileMaintenance
                myRowid = CInt(BusinessObject.Sub_ReturnIntegerResult(ServerPath2, "ItemDiv_GetInsertedRowid", CommandType.StoredProcedure))
            Case "Update"
                myRowid = CInt(dbParams(0))
        End Select
        For i = 0 To (RemoteDataSet.ItemDivision_Show.Rows.Count - 1)
            With DG_items
                If myRowid = CInt(.Item(i, 0)) Then
                    .CurrentCell = New DataGridCell(i, 0)
                    'Dim e As System.EventArgs
                    'DataGrid1_Click(Me, e)
                    Exit For
                End If
            End With
        Next
    End Sub

    '<--Principal codes
    'Private Sub PrinList()
    '    Dim BusinessObject As New BusinessLayer.clsFileMaintenance
    '    Dim Params(0) As SqlParameter
    '    Dim ItemCode As New SqlParameter("@ItemCode", SqlDbType.VarChar, 10)
    '    ItemCode.Direction = ParameterDirection.Input
    '    ItemCode.Value = DG_items.Item(DG_items.CurrentCell.RowNumber, 1).ToString
    '    Params(0) = ItemCode

    '    If RemoteDataSet.ItemPrincipal_Show.Count > 0 Then RemoteDataSet.ItemPrincipal_Show.Clear()
    '    Try
    '        BusinessObject.Sub_Show(ServerPath2, "ItemPrincipal_Show", CommandType.StoredProcedure, RemoteDataSet, "ItemPrincipal_Show", Params)
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    '    DG_prin.DataSource = RemoteDataSet.ItemPrincipal_Show
    'End Sub

    'Private Sub DG_prin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    txtPRINrowid.Text = DG_prin.Item(DG_prin.CurrentCell.RowNumber, 0).ToString
    'End Sub

    'Private Sub cmdAdd_Prin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim MyLoadedForm As New Iprin_Entry
    '    Itm_EditMode = False
    '    MyLoadedForm.vItemCode.Text = jTrim(txtItemCode.Text)
    '    MyLoadedForm.vCreateDate.Text = GetDateTimeNow("MM/dd/yyyy")
    '    MyLoadedForm.vUpdateDate.Text = GetDateTimeNow("MM/dd/yyyy")
    '    cancelProcess = False
    '    MyLoadedForm.ShowDialog(Me)
    '    Dim Params(0) As String
    '    Params(0) = ""
    '    PrinList()
    '    If cancelProcess = False Then
    '        Prin_Sub_Select(Params, CStr(IIf(Itm_EditMode = False, "Insert", "Update")))
    '    End If
    'End Sub

    'Private Sub cmdEdit_Prin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim MyLoadedForm As New Iprin_Entry
    '    Dim tmpDate As String
    '    Dim s As String
    '    MyLoadedForm.vRowId.Text = DG_prin.Item(DG_prin.CurrentCell.RowNumber, 0).ToString
    '    MyLoadedForm.vItemCode.Text = DG_prin.Item(DG_prin.CurrentCell.RowNumber, 1).ToString

    '    tmpDate = DG_prin.Item(DG_prin.CurrentCell.RowNumber, 2).ToString
    '    If Trim(tmpDate) <> "" Then
    '        MyLoadedForm.vStart_Date.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
    '        MyLoadedForm.vStart_DateO.Text = DG_prin.Item(DG_prin.CurrentCell.RowNumber, 2).ToString
    '    End If

    '    tmpDate = DG_prin.Item(DG_prin.CurrentCell.RowNumber, 3).ToString
    '    If Trim(tmpDate) <> "" Then
    '        MyLoadedForm.vEnd_Date.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
    '    End If

    '    Filds(4) = DG_prin.Item(DG_prin.CurrentCell.RowNumber, 5).ToString
    '    MyLoadedForm.cboPrincipal.Text = Filds(4).ToString
    '    MyLoadedForm.cboPrincipalO.Text = DG_prin.Item(DG_prin.CurrentCell.RowNumber, 5).ToString

    '    tmpDate = DG_prin.Item(DG_prin.CurrentCell.RowNumber, 6).ToString
    '    If Trim(tmpDate) <> "" Then
    '        MyLoadedForm.vCreateDate.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
    '    End If

    '    tmpDate = DG_prin.Item(DG_prin.CurrentCell.RowNumber, 7).ToString
    '    If Trim(tmpDate) <> "" Then
    '        MyLoadedForm.vUpdateDate.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
    '    End If

    '    MyLoadedForm.vLastUser.Text = DG_prin.Item(DG_prin.CurrentCell.RowNumber, 8).ToString

    '    Itm_EditMode = True
    '    MyLoadedForm.ShowDialog(Me)
    '    Me.Refresh()
    '    Dim Params(0) As String
    '    Params(0) = Trim(txtPRINrowid.Text)
    '    PrinList()
    '    If cancelProcess = False Then
    '        Prin_Sub_Select(Params, CStr(IIf(Itm_EditMode = False, "Insert", "Update")))
    '    End If
    'End Sub

    'Private Sub cmdDelete_Prin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If txtItemCode.Text > "" Then
    '        If (MessageBox.Show("Do you really want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, _
    '        MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then
    '            SubIprin_Delete()
    '            'ControlMaintenance.ClearInputControls(Me)
    '            PrinList()
    '            If RemoteDataSet.ItemPrincipal_Show.Count > 0 Then
    '                txtPRINrowid.Text = DG_prin.Item(DG_prin.CurrentCell.RowNumber, 0).ToString
    '            End If
    '        End If
    '    End If
    'End Sub

    'Private Sub SubIprin_Delete()
    '    Dim BusinessObject As New BusinessLayer.clsFileMaintenance
    '    Dim Params(2) As SqlParameter

    '    Dim ItemCode As New SqlParameter("@ItemCode", SqlDbType.VarChar, 10)
    '    ItemCode.Direction = ParameterDirection.Input
    '    ItemCode.Value = jTrim(txtItemCode.Text)
    '    Params(0) = ItemCode

    '    Dim PrinCode As New SqlParameter("@PrinCode", SqlDbType.VarChar, 5)
    '    PrinCode.Direction = ParameterDirection.Input
    '    PrinCode.Value = DG_prin.Item(DG_prin.CurrentCell.RowNumber, 4).ToString
    '    Params(1) = PrinCode

    '    Dim Start_Date As New SqlParameter("@Start_Date", SqlDbType.DateTime, 10)
    '    Start_Date.Direction = ParameterDirection.Input
    '    Start_Date.Value = DG_prin.Item(DG_prin.CurrentCell.RowNumber, 2).ToString
    '    Params(2) = Start_Date

    '    Try
    '        BusinessObject.Sub_Delete(ServerPath2, "ItemPrin_del", CommandType.StoredProcedure, Params)
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Public Sub Prin_Sub_Select(ByVal dbParams() As String, ByVal UpdateMode As String)
        Dim myRowid As Integer
        Select Case UpdateMode
            Case "Insert"
                Dim BusinessObject As New BusinessLayer.clsFileMaintenance
                myRowid = CInt(BusinessObject.Sub_ReturnIntegerResult(ServerPath2, "ItemPrin_GetInsertedRowid", CommandType.StoredProcedure))
            Case "Update"
                myRowid = CInt(dbParams(0))
        End Select
        For i = 0 To (RemoteDataSet.ItemPrincipal_Show.Rows.Count - 1)
            With DG_items
                If myRowid = CInt(.Item(i, 0)) Then
                    .CurrentCell = New DataGridCell(i, 0)
                    'Dim e As System.EventArgs
                    'DataGrid1_Click(Me, e)
                    Exit For
                End If
            End With
        Next
    End Sub

    ''<--Price history codes
    'Private Sub PriceHist()
    '    Dim BusinessObject As New BusinessLayer.clsFileMaintenance
    '    Dim Params(0) As SqlParameter
    '    Dim ItemCode As New SqlParameter("@ItemCode", SqlDbType.VarChar, 10)
    '    ItemCode.Direction = ParameterDirection.Input
    '    ItemCode.Value = DG_items.Item(DG_items.CurrentCell.RowNumber, 1).ToString
    '    Params(0) = ItemCode

    '    If RemoteDataSet.ItemPriceHist_DS_Show.Count > 0 Then RemoteDataSet.ItemPriceHist_DS_Show.Clear()
    '    Try
    '        BusinessObject.Sub_Show(ServerPath2, "ItemPriceHist_Show", CommandType.StoredProcedure, RemoteDataSet, "ItemPriceHist_DS_Show", Params)
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    '    DG_ipc.DataSource = RemoteDataSet.ItemPriceHist_DS_Show
    'End Sub

    'Private Sub DG_ipc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    txtPHrowid.Text = DG_ipc.Item(DG_ipc.CurrentCell.RowNumber, 0).ToString
    'End Sub

    'Private Sub cmdAdd_IPH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim MyLoadedForm As New Ipc_Entry
    '    Itm_EditMode = False
    '    MyLoadedForm.vItemCode.Text = jTrim(txtItemCode.Text)
    '    MyLoadedForm.vCreateDate.Text = GetDateTimeNow("MM/dd/yyyy")
    '    MyLoadedForm.vUpdateDate.Text = GetDateTimeNow("MM/dd/yyyy")
    '    cancelProcess = False
    '    MyLoadedForm.ShowDialog(Me)
    '    Dim Params(0) As String
    '    Params(0) = ""
    '    PriceHist()
    '    If cancelProcess = False Then
    '        PH_Sub_Select(Params, CStr(IIf(Itm_EditMode = False, "Insert", "Update")))
    '    End If
    'End Sub

    'Private Sub cmdEdit_IPH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim MyLoadedForm As New Ipc_Entry
    '    Dim tmpDate As String
    '    Dim s As String
    '    MyLoadedForm.vRowId.Text = DG_ipc.Item(DG_ipc.CurrentCell.RowNumber, 0).ToString
    '    tmpRowid = DG_ipc.Item(DG_ipc.CurrentCell.RowNumber, 0).ToString
    '    MyLoadedForm.vItemCode.Text = DG_ipc.Item(DG_ipc.CurrentCell.RowNumber, 1).ToString

    '    tmpDate = DG_ipc.Item(DG_ipc.CurrentCell.RowNumber, 2).ToString
    '    If Trim(tmpDate) <> "" Then
    '        MyLoadedForm.vStart_Date.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
    '        MyLoadedForm.vStart_DateO.Text = DG_ipc.Item(DG_ipc.CurrentCell.RowNumber, 2).ToString()
    '    End If

    '    tmpDate = DG_ipc.Item(DG_ipc.CurrentCell.RowNumber, 3).ToString
    '    If Trim(tmpDate) <> "" Then
    '        MyLoadedForm.vEnd_Date.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
    '    End If

    '    MyLoadedForm.vSellingPrice.Text = DG_ipc.Item(DG_ipc.CurrentCell.RowNumber, 4).ToString
    '    MyLoadedForm.vSellingPriceO.Text = DG_ipc.Item(DG_ipc.CurrentCell.RowNumber, 4).ToString

    '    tmpDate = DG_ipc.Item(DG_ipc.CurrentCell.RowNumber, 5).ToString
    '    If Trim(tmpDate) <> "" Then
    '        MyLoadedForm.vCreateDate.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
    '    End If

    '    tmpDate = DG_ipc.Item(DG_ipc.CurrentCell.RowNumber, 6).ToString
    '    If Trim(tmpDate) <> "" Then
    '        MyLoadedForm.vUpdateDate.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
    '    End If

    '    MyLoadedForm.vLastUser.Text = DG_ipc.Item(DG_ipc.CurrentCell.RowNumber, 7).ToString

    '    Itm_EditMode = True
    '    MyLoadedForm.ShowDialog(Me)
    '    Me.Refresh()
    '    Dim Params(0) As String
    '    Params(0) = Trim(txtPHrowid.Text)
    '    PriceHist()
    '    If cancelProcess = False Then
    '        PH_Sub_Select(Params, CStr(IIf(Itm_EditMode = False, "Insert", "Update")))
    '    End If
    'End Sub

    'Private Sub cmdDelete_IPH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If txtItemCode.Text > "" Then
    '        If (MessageBox.Show("Do you really want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, _
    '        MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then
    '            SubIph_Delete()
    '            'ControlMaintenance.ClearInputControls(Me)
    '            PriceHist()
    '            If RemoteDataSet.ItemPriceHist_DS_Show.Count > 0 Then
    '                txtPHrowid.Text = DG_ipc.Item(DG_ipc.CurrentCell.RowNumber, 0).ToString
    '            End If
    '        End If
    '    End If
    'End Sub

    'Private Sub SubIph_Delete()
    '    Dim BusinessObject As New BusinessLayer.clsFileMaintenance
    '    Dim Params(2) As SqlParameter

    '    Dim ItemCode As New SqlParameter("@ItemCode", SqlDbType.VarChar, 10)
    '    ItemCode.Direction = ParameterDirection.Input
    '    ItemCode.Value = jTrim(txtItemCode.Text)
    '    Params(0) = ItemCode

    '    Dim SellingPrice As New SqlParameter("@SellingPrice", SqlDbType.Money)
    '    SellingPrice.Direction = ParameterDirection.Input
    '    SellingPrice.Value = DG_ipc.Item(DG_ipc.CurrentCell.RowNumber, 4).ToString
    '    Params(1) = SellingPrice

    '    Dim Start_Date As New SqlParameter("@Start_Date", SqlDbType.DateTime)
    '    Start_Date.Direction = ParameterDirection.Input
    '    Start_Date.Value = DG_ipc.Item(DG_ipc.CurrentCell.RowNumber, 2).ToString
    '    Params(2) = Start_Date

    '    Try
    '        BusinessObject.Sub_Delete(ServerPath2, "ItemPH_del", CommandType.StoredProcedure, Params)
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Public Sub PH_Sub_Select(ByVal dbParams() As String, ByVal UpdateMode As String)
        Dim myRowid As Integer
        Select Case UpdateMode
            Case "Insert"
                Dim BusinessObject As New BusinessLayer.clsFileMaintenance
                myRowid = CInt(BusinessObject.Sub_ReturnIntegerResult(ServerPath2, "ItemPH_GetInsertedRowid", CommandType.StoredProcedure))
            Case "Update"
                myRowid = CInt(dbParams(0))
        End Select
        For i = 0 To (RemoteDataSet.ItemPriceHist_DS_Show.Rows.Count - 1)
            With DG_items
                If myRowid = CInt(.Item(i, 0)) Then
                    .CurrentCell = New DataGridCell(i, 0)
                    'Dim e As System.EventArgs
                    'DataGrid1_Click(Me, e)
                    Exit For
                End If
            End With
        Next
    End Sub

    Private Sub Frm_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        EnDisMainMenu(Me, True)
        'ChildCtr = ChildCtr - 1              '<--ready for 2forms need
    End Sub

    Private Sub Frm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        EnDisMainMenu(Me, False)
    End Sub

    Private Sub Frm_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        'If CloseFrm = True Then              '<- ready
        '    CloseFrm = False                 '<- for
        '    Close()                          '<- 2forms
        'End If                               '<- need
    End Sub

    Private Sub DG_items_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DG_items.Navigate

    End Sub
End Class
