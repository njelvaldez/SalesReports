Imports System.Data.SqlClient
Imports Microsoft
Public Class ItemCT
    Inherits System.Windows.Forms.Form
    Private RemoteDataSet As New CodeTablesDS
    Private oldDs As String
    Public itmX As String

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
    Friend WithEvents DG_ipc As System.Windows.Forms.DataGrid
    Friend WithEvents DG_div As System.Windows.Forms.DataGrid
    Friend WithEvents DG_prin As System.Windows.Forms.DataGrid
    Friend WithEvents DG_pm As System.Windows.Forms.DataGrid
    Friend WithEvents DG_nsm As System.Windows.Forms.DataGrid
    Friend WithEvents cmdExit_IPH As System.Windows.Forms.Button
    Friend WithEvents cmdAdd_IPH As System.Windows.Forms.Button
    Friend WithEvents cmdEdit_IPH As System.Windows.Forms.Button
    Friend WithEvents cmdDelete_IPH As System.Windows.Forms.Button
    Friend WithEvents cmdExit_DIV As System.Windows.Forms.Button
    Friend WithEvents cmdAdd_DIV As System.Windows.Forms.Button
    Friend WithEvents cmdEdit_DIV As System.Windows.Forms.Button
    Friend WithEvents cmdDelete_DIV As System.Windows.Forms.Button
    Friend WithEvents cmdExit_PRIN As System.Windows.Forms.Button
    Friend WithEvents cmdExit_PM As System.Windows.Forms.Button
    Friend WithEvents cmdAdd_PM As System.Windows.Forms.Button
    Friend WithEvents cmdEdit_PM As System.Windows.Forms.Button
    Friend WithEvents cmdDelete_PM As System.Windows.Forms.Button
    Friend WithEvents cmdExit_NSM As System.Windows.Forms.Button
    Friend WithEvents cmdAdd_NSM As System.Windows.Forms.Button
    Friend WithEvents cmdEdit_NSM As System.Windows.Forms.Button
    Friend WithEvents cmdDelete_NSM As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
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
    Friend WithEvents DataGridTableStyle3 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn33 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn34 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn35 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn36 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn37 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn38 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn39 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn40 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle4 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn41 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn42 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn43 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn44 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn45 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn46 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn47 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn48 As System.Windows.Forms.DataGridTextBoxColumn
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
    Friend WithEvents cmdAdd_Prin As System.Windows.Forms.Button
    Friend WithEvents cmdEdit_Prin As System.Windows.Forms.Button
    Friend WithEvents cmdDelete_Prin As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmdAdd_Dsg As System.Windows.Forms.Button
    Friend WithEvents cmdEdit_Dsg As System.Windows.Forms.Button
    Friend WithEvents cmdDelete_Dsg As System.Windows.Forms.Button
    Friend WithEvents DG_dsg As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle7 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn67 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn68 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn69 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn70 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn71 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn72 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn73 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn74 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn75 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn76 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
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
        Me.DataGridTextBoxColumn27 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn28 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn29 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn30 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn31 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn32 = New System.Windows.Forms.DataGridTextBoxColumn
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
        Me.DG_ipc = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle3 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn33 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn34 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn35 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn36 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn37 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn38 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn39 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn40 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DG_div = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DG_prin = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle4 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn41 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn44 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn45 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn42 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn43 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn46 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn47 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn48 = New System.Windows.Forms.DataGridTextBoxColumn
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
        Me.cmdExit_IPH = New System.Windows.Forms.Button
        Me.cmdAdd_IPH = New System.Windows.Forms.Button
        Me.cmdEdit_IPH = New System.Windows.Forms.Button
        Me.cmdDelete_IPH = New System.Windows.Forms.Button
        Me.cmdExit_DIV = New System.Windows.Forms.Button
        Me.cmdAdd_DIV = New System.Windows.Forms.Button
        Me.cmdEdit_DIV = New System.Windows.Forms.Button
        Me.cmdDelete_DIV = New System.Windows.Forms.Button
        Me.cmdExit_PRIN = New System.Windows.Forms.Button
        Me.cmdAdd_Prin = New System.Windows.Forms.Button
        Me.cmdEdit_Prin = New System.Windows.Forms.Button
        Me.cmdDelete_Prin = New System.Windows.Forms.Button
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmdAdd_Dsg = New System.Windows.Forms.Button
        Me.cmdEdit_Dsg = New System.Windows.Forms.Button
        Me.cmdDelete_Dsg = New System.Windows.Forms.Button
        Me.DG_dsg = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle7 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn67 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn68 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn69 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn70 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn71 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn72 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn73 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn74 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn75 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn76 = New System.Windows.Forms.DataGridTextBoxColumn
        CType(Me.DG_items, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_nsm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_ipc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_div, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_prin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_pm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_dsg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DG_items
        '
        Me.DG_items.AlternatingBackColor = System.Drawing.Color.Silver
        Me.DG_items.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_items.BackColor = System.Drawing.Color.White
        Me.DG_items.BackgroundColor = System.Drawing.Color.Lavender
        Me.DG_items.CaptionBackColor = System.Drawing.Color.Blue
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
        Me.DG_items.Location = New System.Drawing.Point(6, 30)
        Me.DG_items.Name = "DG_items"
        Me.DG_items.ParentRowsBackColor = System.Drawing.Color.Silver
        Me.DG_items.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DG_items.SelectionBackColor = System.Drawing.Color.Maroon
        Me.DG_items.SelectionForeColor = System.Drawing.Color.White
        Me.DG_items.Size = New System.Drawing.Size(880, 154)
        Me.DG_items.TabIndex = 16
        Me.DG_items.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.DG_items.Tag = ""
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Aqua
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightCyan
        Me.DataGridTableStyle1.DataGrid = Me.DG_items
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn16, Me.DataGridTextBoxColumn17, Me.DataGridTextBoxColumn18, Me.DataGridTextBoxColumn19, Me.DataGridTextBoxColumn20, Me.DataGridTextBoxColumn21, Me.DataGridTextBoxColumn22, Me.DataGridTextBoxColumn23, Me.DataGridTextBoxColumn24, Me.DataGridTextBoxColumn25, Me.DataGridTextBoxColumn26, Me.DataGridTextBoxColumn27, Me.DataGridTextBoxColumn28, Me.DataGridTextBoxColumn29, Me.DataGridTextBoxColumn30, Me.DataGridTextBoxColumn31, Me.DataGridTextBoxColumn32})
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
        Me.DataGridTextBoxColumn12.Width = 60
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "Metro Drug Code"
        Me.DataGridTextBoxColumn13.MappingName = "MetroDrugCode"
        Me.DataGridTextBoxColumn13.NullText = ""
        Me.DataGridTextBoxColumn13.Width = 200
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "Mercury Item Code"
        Me.DataGridTextBoxColumn14.MappingName = "MercuryItemCode"
        Me.DataGridTextBoxColumn14.NullText = ""
        Me.DataGridTextBoxColumn14.Width = 200
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
        Me.DataGridTextBoxColumn17.Width = 75
        '
        'DataGridTextBoxColumn18
        '
        Me.DataGridTextBoxColumn18.Format = ""
        Me.DataGridTextBoxColumn18.FormatInfo = Nothing
        Me.DataGridTextBoxColumn18.HeaderText = "Unit Conversion"
        Me.DataGridTextBoxColumn18.MappingName = "unitconversion"
        Me.DataGridTextBoxColumn18.NullText = ""
        Me.DataGridTextBoxColumn18.Width = 175
        '
        'DataGridTextBoxColumn19
        '
        Me.DataGridTextBoxColumn19.Format = ""
        Me.DataGridTextBoxColumn19.FormatInfo = Nothing
        Me.DataGridTextBoxColumn19.HeaderText = "Current Price (SRP)"
        Me.DataGridTextBoxColumn19.MappingName = "unitprice"
        Me.DataGridTextBoxColumn19.NullText = ""
        Me.DataGridTextBoxColumn19.Width = 175
        '
        'DataGridTextBoxColumn20
        '
        Me.DataGridTextBoxColumn20.Format = ""
        Me.DataGridTextBoxColumn20.FormatInfo = Nothing
        Me.DataGridTextBoxColumn20.HeaderText = "Current Mercury Price(ST)"
        Me.DataGridTextBoxColumn20.MappingName = "mercurystprice"
        Me.DataGridTextBoxColumn20.NullText = ""
        Me.DataGridTextBoxColumn20.Width = 225
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
        Me.DataGridTextBoxColumn24.HeaderText = "Current Division"
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
        Me.DataGridTextBoxColumn25.Width = 75
        '
        'DataGridTextBoxColumn26
        '
        Me.DataGridTextBoxColumn26.Format = ""
        Me.DataGridTextBoxColumn26.FormatInfo = Nothing
        Me.DataGridTextBoxColumn26.HeaderText = "Product Form"
        Me.DataGridTextBoxColumn26.MappingName = "productform"
        Me.DataGridTextBoxColumn26.NullText = ""
        Me.DataGridTextBoxColumn26.Width = 75
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
        Me.DataGridTextBoxColumn30.Width = 90
        '
        'DataGridTextBoxColumn31
        '
        Me.DataGridTextBoxColumn31.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn31.FormatInfo = Nothing
        Me.DataGridTextBoxColumn31.HeaderText = "Create Date"
        Me.DataGridTextBoxColumn31.MappingName = "createdate"
        Me.DataGridTextBoxColumn31.NullText = ""
        Me.DataGridTextBoxColumn31.Width = 75
        '
        'DataGridTextBoxColumn32
        '
        Me.DataGridTextBoxColumn32.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn32.FormatInfo = Nothing
        Me.DataGridTextBoxColumn32.HeaderText = "Update Date"
        Me.DataGridTextBoxColumn32.MappingName = "updatedate"
        Me.DataGridTextBoxColumn32.NullText = ""
        Me.DataGridTextBoxColumn32.Width = 75
        '
        'DG_nsm
        '
        Me.DG_nsm.AlternatingBackColor = System.Drawing.Color.Silver
        Me.DG_nsm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.DG_nsm.BackColor = System.Drawing.Color.White
        Me.DG_nsm.BackgroundColor = System.Drawing.Color.Lavender
        Me.DG_nsm.CaptionBackColor = System.Drawing.Color.Red
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
        Me.DG_nsm.Location = New System.Drawing.Point(6, 562)
        Me.DG_nsm.Name = "DG_nsm"
        Me.DG_nsm.ParentRowsBackColor = System.Drawing.Color.Silver
        Me.DG_nsm.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DG_nsm.SelectionBackColor = System.Drawing.Color.Maroon
        Me.DG_nsm.SelectionForeColor = System.Drawing.Color.White
        Me.DG_nsm.Size = New System.Drawing.Size(436, 156)
        Me.DG_nsm.TabIndex = 36
        Me.DG_nsm.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle5})
        Me.DG_nsm.Tag = ""
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
        'DG_ipc
        '
        Me.DG_ipc.AlternatingBackColor = System.Drawing.Color.Silver
        Me.DG_ipc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.DG_ipc.BackColor = System.Drawing.Color.White
        Me.DG_ipc.BackgroundColor = System.Drawing.Color.Lavender
        Me.DG_ipc.CaptionBackColor = System.Drawing.Color.Red
        Me.DG_ipc.CaptionForeColor = System.Drawing.Color.White
        Me.DG_ipc.CaptionText = "ITEMS PRICE HISTORY"
        Me.DG_ipc.DataMember = ""
        Me.DG_ipc.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DG_ipc.ForeColor = System.Drawing.Color.Black
        Me.DG_ipc.GridLineColor = System.Drawing.Color.Silver
        Me.DG_ipc.HeaderBackColor = System.Drawing.Color.Silver
        Me.DG_ipc.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DG_ipc.HeaderForeColor = System.Drawing.Color.Black
        Me.DG_ipc.LinkColor = System.Drawing.Color.Maroon
        Me.DG_ipc.Location = New System.Drawing.Point(6, 210)
        Me.DG_ipc.Name = "DG_ipc"
        Me.DG_ipc.ParentRowsBackColor = System.Drawing.Color.Silver
        Me.DG_ipc.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DG_ipc.SelectionBackColor = System.Drawing.Color.Maroon
        Me.DG_ipc.SelectionForeColor = System.Drawing.Color.White
        Me.DG_ipc.Size = New System.Drawing.Size(436, 144)
        Me.DG_ipc.TabIndex = 23
        Me.DG_ipc.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle3})
        Me.DG_ipc.Tag = ""
        '
        'DataGridTableStyle3
        '
        Me.DataGridTableStyle3.AlternatingBackColor = System.Drawing.Color.LavenderBlush
        Me.DataGridTableStyle3.BackColor = System.Drawing.Color.MistyRose
        Me.DataGridTableStyle3.DataGrid = Me.DG_ipc
        Me.DataGridTableStyle3.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn33, Me.DataGridTextBoxColumn34, Me.DataGridTextBoxColumn35, Me.DataGridTextBoxColumn36, Me.DataGridTextBoxColumn37, Me.DataGridTextBoxColumn38, Me.DataGridTextBoxColumn39, Me.DataGridTextBoxColumn40})
        Me.DataGridTableStyle3.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle3.MappingName = "ItemPriceHist_DS_Show"
        '
        'DataGridTextBoxColumn33
        '
        Me.DataGridTextBoxColumn33.Format = ""
        Me.DataGridTextBoxColumn33.FormatInfo = Nothing
        Me.DataGridTextBoxColumn33.MappingName = "rowid"
        Me.DataGridTextBoxColumn33.NullText = ""
        Me.DataGridTextBoxColumn33.Width = 0
        '
        'DataGridTextBoxColumn34
        '
        Me.DataGridTextBoxColumn34.Format = ""
        Me.DataGridTextBoxColumn34.FormatInfo = Nothing
        Me.DataGridTextBoxColumn34.MappingName = "itemcode"
        Me.DataGridTextBoxColumn34.NullText = ""
        Me.DataGridTextBoxColumn34.Width = 0
        '
        'DataGridTextBoxColumn35
        '
        Me.DataGridTextBoxColumn35.Format = ""
        Me.DataGridTextBoxColumn35.FormatInfo = Nothing
        Me.DataGridTextBoxColumn35.HeaderText = "Start Date"
        Me.DataGridTextBoxColumn35.MappingName = "start_date"
        Me.DataGridTextBoxColumn35.NullText = ""
        Me.DataGridTextBoxColumn35.Width = 75
        '
        'DataGridTextBoxColumn36
        '
        Me.DataGridTextBoxColumn36.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn36.FormatInfo = Nothing
        Me.DataGridTextBoxColumn36.HeaderText = "End Date"
        Me.DataGridTextBoxColumn36.MappingName = "end_date"
        Me.DataGridTextBoxColumn36.NullText = ""
        Me.DataGridTextBoxColumn36.Width = 75
        '
        'DataGridTextBoxColumn37
        '
        Me.DataGridTextBoxColumn37.Format = ""
        Me.DataGridTextBoxColumn37.FormatInfo = Nothing
        Me.DataGridTextBoxColumn37.HeaderText = "Price"
        Me.DataGridTextBoxColumn37.MappingName = "sellingprice"
        Me.DataGridTextBoxColumn37.NullText = ""
        Me.DataGridTextBoxColumn37.Width = 75
        '
        'DataGridTextBoxColumn38
        '
        Me.DataGridTextBoxColumn38.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn38.FormatInfo = Nothing
        Me.DataGridTextBoxColumn38.HeaderText = "Create Date"
        Me.DataGridTextBoxColumn38.MappingName = "createdate"
        Me.DataGridTextBoxColumn38.NullText = ""
        Me.DataGridTextBoxColumn38.Width = 75
        '
        'DataGridTextBoxColumn39
        '
        Me.DataGridTextBoxColumn39.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn39.FormatInfo = Nothing
        Me.DataGridTextBoxColumn39.HeaderText = "Update Date"
        Me.DataGridTextBoxColumn39.MappingName = "UpdateDate"
        Me.DataGridTextBoxColumn39.NullText = ""
        Me.DataGridTextBoxColumn39.Width = 75
        '
        'DataGridTextBoxColumn40
        '
        Me.DataGridTextBoxColumn40.Format = ""
        Me.DataGridTextBoxColumn40.FormatInfo = Nothing
        Me.DataGridTextBoxColumn40.HeaderText = "Encoder"
        Me.DataGridTextBoxColumn40.MappingName = "lastuser"
        Me.DataGridTextBoxColumn40.NullText = ""
        Me.DataGridTextBoxColumn40.Width = 90
        '
        'DG_div
        '
        Me.DG_div.AlternatingBackColor = System.Drawing.Color.Silver
        Me.DG_div.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.DG_div.BackColor = System.Drawing.Color.White
        Me.DG_div.BackgroundColor = System.Drawing.Color.Lavender
        Me.DG_div.CaptionBackColor = System.Drawing.Color.Red
        Me.DG_div.CaptionForeColor = System.Drawing.Color.White
        Me.DG_div.CaptionText = "DIVISIONS OF ITEM"
        Me.DG_div.DataMember = ""
        Me.DG_div.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DG_div.ForeColor = System.Drawing.Color.Black
        Me.DG_div.GridLineColor = System.Drawing.Color.Silver
        Me.DG_div.HeaderBackColor = System.Drawing.Color.Silver
        Me.DG_div.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DG_div.HeaderForeColor = System.Drawing.Color.Black
        Me.DG_div.LinkColor = System.Drawing.Color.Maroon
        Me.DG_div.Location = New System.Drawing.Point(6, 380)
        Me.DG_div.Name = "DG_div"
        Me.DG_div.ParentRowsBackColor = System.Drawing.Color.Silver
        Me.DG_div.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DG_div.SelectionBackColor = System.Drawing.Color.Maroon
        Me.DG_div.SelectionForeColor = System.Drawing.Color.White
        Me.DG_div.Size = New System.Drawing.Size(436, 156)
        Me.DG_div.TabIndex = 21
        Me.DG_div.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        Me.DG_div.Tag = ""
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.AlternatingBackColor = System.Drawing.Color.MistyRose
        Me.DataGridTableStyle2.BackColor = System.Drawing.Color.LavenderBlush
        Me.DataGridTableStyle2.DataGrid = Me.DG_div
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "ItemDivision_Show"
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.MappingName = "rowid"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.Width = 0
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.MappingName = "itemcode"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.Width = 0
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Start Date"
        Me.DataGridTextBoxColumn4.MappingName = "start_date"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "End Date"
        Me.DataGridTextBoxColumn5.MappingName = "end_date"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.MappingName = "DivCode"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 0
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Division"
        Me.DataGridTextBoxColumn3.MappingName = "Divname"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 200
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Date Created"
        Me.DataGridTextBoxColumn6.MappingName = "Createdate"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Date Updated"
        Me.DataGridTextBoxColumn7.MappingName = "updatedate"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 75
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "Encoder"
        Me.DataGridTextBoxColumn8.MappingName = "lastuser"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 90
        '
        'DG_prin
        '
        Me.DG_prin.AlternatingBackColor = System.Drawing.Color.Silver
        Me.DG_prin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.DG_prin.BackColor = System.Drawing.Color.White
        Me.DG_prin.BackgroundColor = System.Drawing.Color.Lavender
        Me.DG_prin.CaptionBackColor = System.Drawing.Color.Red
        Me.DG_prin.CaptionForeColor = System.Drawing.Color.White
        Me.DG_prin.CaptionText = "PRINCIPALS OF ITEM"
        Me.DG_prin.DataMember = ""
        Me.DG_prin.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DG_prin.ForeColor = System.Drawing.Color.Black
        Me.DG_prin.GridLineColor = System.Drawing.Color.Silver
        Me.DG_prin.HeaderBackColor = System.Drawing.Color.Silver
        Me.DG_prin.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DG_prin.HeaderForeColor = System.Drawing.Color.Black
        Me.DG_prin.LinkColor = System.Drawing.Color.Maroon
        Me.DG_prin.Location = New System.Drawing.Point(450, 210)
        Me.DG_prin.Name = "DG_prin"
        Me.DG_prin.ParentRowsBackColor = System.Drawing.Color.Silver
        Me.DG_prin.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DG_prin.SelectionBackColor = System.Drawing.Color.Maroon
        Me.DG_prin.SelectionForeColor = System.Drawing.Color.White
        Me.DG_prin.Size = New System.Drawing.Size(436, 144)
        Me.DG_prin.TabIndex = 22
        Me.DG_prin.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle4})
        Me.DG_prin.Tag = ""
        '
        'DataGridTableStyle4
        '
        Me.DataGridTableStyle4.AlternatingBackColor = System.Drawing.Color.MistyRose
        Me.DataGridTableStyle4.BackColor = System.Drawing.Color.LavenderBlush
        Me.DataGridTableStyle4.DataGrid = Me.DG_prin
        Me.DataGridTableStyle4.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn41, Me.DataGridTextBoxColumn44, Me.DataGridTextBoxColumn45, Me.DataGridTextBoxColumn42, Me.DataGridTextBoxColumn43, Me.DataGridTextBoxColumn46, Me.DataGridTextBoxColumn47, Me.DataGridTextBoxColumn48})
        Me.DataGridTableStyle4.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle4.MappingName = "ItemPrincipal_Show"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.MappingName = "rowid"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn41
        '
        Me.DataGridTextBoxColumn41.Format = ""
        Me.DataGridTextBoxColumn41.FormatInfo = Nothing
        Me.DataGridTextBoxColumn41.MappingName = "itemcode"
        Me.DataGridTextBoxColumn41.NullText = ""
        Me.DataGridTextBoxColumn41.Width = 0
        '
        'DataGridTextBoxColumn44
        '
        Me.DataGridTextBoxColumn44.Format = ""
        Me.DataGridTextBoxColumn44.FormatInfo = Nothing
        Me.DataGridTextBoxColumn44.HeaderText = "Start Date"
        Me.DataGridTextBoxColumn44.MappingName = "start_date"
        Me.DataGridTextBoxColumn44.NullText = ""
        Me.DataGridTextBoxColumn44.Width = 75
        '
        'DataGridTextBoxColumn45
        '
        Me.DataGridTextBoxColumn45.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn45.FormatInfo = Nothing
        Me.DataGridTextBoxColumn45.HeaderText = "End Date"
        Me.DataGridTextBoxColumn45.MappingName = "end_date"
        Me.DataGridTextBoxColumn45.NullText = ""
        Me.DataGridTextBoxColumn45.Width = 75
        '
        'DataGridTextBoxColumn42
        '
        Me.DataGridTextBoxColumn42.Format = ""
        Me.DataGridTextBoxColumn42.FormatInfo = Nothing
        Me.DataGridTextBoxColumn42.MappingName = "princode"
        Me.DataGridTextBoxColumn42.NullText = ""
        Me.DataGridTextBoxColumn42.Width = 0
        '
        'DataGridTextBoxColumn43
        '
        Me.DataGridTextBoxColumn43.Format = ""
        Me.DataGridTextBoxColumn43.FormatInfo = Nothing
        Me.DataGridTextBoxColumn43.HeaderText = "Principal"
        Me.DataGridTextBoxColumn43.MappingName = "prinname"
        Me.DataGridTextBoxColumn43.NullText = ""
        Me.DataGridTextBoxColumn43.Width = 200
        '
        'DataGridTextBoxColumn46
        '
        Me.DataGridTextBoxColumn46.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn46.FormatInfo = Nothing
        Me.DataGridTextBoxColumn46.HeaderText = "CreateDate"
        Me.DataGridTextBoxColumn46.MappingName = "createdate"
        Me.DataGridTextBoxColumn46.NullText = ""
        Me.DataGridTextBoxColumn46.Width = 75
        '
        'DataGridTextBoxColumn47
        '
        Me.DataGridTextBoxColumn47.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn47.FormatInfo = Nothing
        Me.DataGridTextBoxColumn47.HeaderText = "Update Date"
        Me.DataGridTextBoxColumn47.MappingName = "updatedate"
        Me.DataGridTextBoxColumn47.NullText = ""
        Me.DataGridTextBoxColumn47.Width = 75
        '
        'DataGridTextBoxColumn48
        '
        Me.DataGridTextBoxColumn48.Format = ""
        Me.DataGridTextBoxColumn48.FormatInfo = Nothing
        Me.DataGridTextBoxColumn48.HeaderText = "Encoder"
        Me.DataGridTextBoxColumn48.MappingName = "lastuser"
        Me.DataGridTextBoxColumn48.NullText = ""
        Me.DataGridTextBoxColumn48.Width = 90
        '
        'DG_pm
        '
        Me.DG_pm.AlternatingBackColor = System.Drawing.Color.Silver
        Me.DG_pm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.DG_pm.BackColor = System.Drawing.Color.White
        Me.DG_pm.BackgroundColor = System.Drawing.Color.Lavender
        Me.DG_pm.CaptionBackColor = System.Drawing.Color.Red
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
        Me.DG_pm.Location = New System.Drawing.Point(450, 562)
        Me.DG_pm.Name = "DG_pm"
        Me.DG_pm.ParentRowsBackColor = System.Drawing.Color.Silver
        Me.DG_pm.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DG_pm.SelectionBackColor = System.Drawing.Color.Maroon
        Me.DG_pm.SelectionForeColor = System.Drawing.Color.White
        Me.DG_pm.Size = New System.Drawing.Size(436, 156)
        Me.DG_pm.TabIndex = 37
        Me.DG_pm.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle6})
        Me.DG_pm.Tag = ""
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
        Me.cmdExit_Itm.Location = New System.Drawing.Point(670, 184)
        Me.cmdExit_Itm.Name = "cmdExit_Itm"
        Me.cmdExit_Itm.Size = New System.Drawing.Size(216, 18)
        Me.cmdExit_Itm.TabIndex = 20
        Me.cmdExit_Itm.Tag = "Exit"
        Me.cmdExit_Itm.Text = "Exit"
        '
        'cmdAdd_Itm
        '
        Me.cmdAdd_Itm.Location = New System.Drawing.Point(5, 184)
        Me.cmdAdd_Itm.Name = "cmdAdd_Itm"
        Me.cmdAdd_Itm.Size = New System.Drawing.Size(216, 18)
        Me.cmdAdd_Itm.TabIndex = 17
        Me.cmdAdd_Itm.Tag = "Add"
        Me.cmdAdd_Itm.Text = "Add"
        '
        'cmdEdit_Itm
        '
        Me.cmdEdit_Itm.Location = New System.Drawing.Point(227, 184)
        Me.cmdEdit_Itm.Name = "cmdEdit_Itm"
        Me.cmdEdit_Itm.Size = New System.Drawing.Size(216, 18)
        Me.cmdEdit_Itm.TabIndex = 18
        Me.cmdEdit_Itm.Tag = "Edit"
        Me.cmdEdit_Itm.Text = "Edit"
        '
        'cmdDelete_Itm
        '
        Me.cmdDelete_Itm.Location = New System.Drawing.Point(448, 184)
        Me.cmdDelete_Itm.Name = "cmdDelete_Itm"
        Me.cmdDelete_Itm.Size = New System.Drawing.Size(216, 18)
        Me.cmdDelete_Itm.TabIndex = 19
        Me.cmdDelete_Itm.Tag = "Delete"
        Me.cmdDelete_Itm.Text = "Delete"
        '
        'cmdExit_IPH
        '
        Me.cmdExit_IPH.Enabled = False
        Me.cmdExit_IPH.Location = New System.Drawing.Point(334, 354)
        Me.cmdExit_IPH.Name = "cmdExit_IPH"
        Me.cmdExit_IPH.Size = New System.Drawing.Size(108, 18)
        Me.cmdExit_IPH.TabIndex = 27
        Me.cmdExit_IPH.Tag = ""
        '
        'cmdAdd_IPH
        '
        Me.cmdAdd_IPH.Location = New System.Drawing.Point(5, 354)
        Me.cmdAdd_IPH.Name = "cmdAdd_IPH"
        Me.cmdAdd_IPH.Size = New System.Drawing.Size(108, 18)
        Me.cmdAdd_IPH.TabIndex = 24
        Me.cmdAdd_IPH.Tag = "Add"
        Me.cmdAdd_IPH.Text = "Add"
        '
        'cmdEdit_IPH
        '
        Me.cmdEdit_IPH.Location = New System.Drawing.Point(116, 354)
        Me.cmdEdit_IPH.Name = "cmdEdit_IPH"
        Me.cmdEdit_IPH.Size = New System.Drawing.Size(108, 18)
        Me.cmdEdit_IPH.TabIndex = 25
        Me.cmdEdit_IPH.Tag = "Edit"
        Me.cmdEdit_IPH.Text = "Edit"
        '
        'cmdDelete_IPH
        '
        Me.cmdDelete_IPH.Location = New System.Drawing.Point(225, 354)
        Me.cmdDelete_IPH.Name = "cmdDelete_IPH"
        Me.cmdDelete_IPH.Size = New System.Drawing.Size(108, 18)
        Me.cmdDelete_IPH.TabIndex = 26
        Me.cmdDelete_IPH.Tag = "Delete"
        Me.cmdDelete_IPH.Text = "Delete"
        '
        'cmdExit_DIV
        '
        Me.cmdExit_DIV.Enabled = False
        Me.cmdExit_DIV.Location = New System.Drawing.Point(334, 536)
        Me.cmdExit_DIV.Name = "cmdExit_DIV"
        Me.cmdExit_DIV.Size = New System.Drawing.Size(108, 18)
        Me.cmdExit_DIV.TabIndex = 31
        Me.cmdExit_DIV.Tag = ""
        '
        'cmdAdd_DIV
        '
        Me.cmdAdd_DIV.Location = New System.Drawing.Point(7, 536)
        Me.cmdAdd_DIV.Name = "cmdAdd_DIV"
        Me.cmdAdd_DIV.Size = New System.Drawing.Size(108, 18)
        Me.cmdAdd_DIV.TabIndex = 28
        Me.cmdAdd_DIV.Tag = "Add"
        Me.cmdAdd_DIV.Text = "Add"
        '
        'cmdEdit_DIV
        '
        Me.cmdEdit_DIV.Location = New System.Drawing.Point(116, 536)
        Me.cmdEdit_DIV.Name = "cmdEdit_DIV"
        Me.cmdEdit_DIV.Size = New System.Drawing.Size(108, 18)
        Me.cmdEdit_DIV.TabIndex = 29
        Me.cmdEdit_DIV.Tag = "Edit"
        Me.cmdEdit_DIV.Text = "Edit"
        '
        'cmdDelete_DIV
        '
        Me.cmdDelete_DIV.Location = New System.Drawing.Point(225, 536)
        Me.cmdDelete_DIV.Name = "cmdDelete_DIV"
        Me.cmdDelete_DIV.Size = New System.Drawing.Size(108, 18)
        Me.cmdDelete_DIV.TabIndex = 30
        Me.cmdDelete_DIV.Tag = "Delete"
        Me.cmdDelete_DIV.Text = "Delete"
        '
        'cmdExit_PRIN
        '
        Me.cmdExit_PRIN.Enabled = False
        Me.cmdExit_PRIN.Location = New System.Drawing.Point(778, 354)
        Me.cmdExit_PRIN.Name = "cmdExit_PRIN"
        Me.cmdExit_PRIN.Size = New System.Drawing.Size(108, 18)
        Me.cmdExit_PRIN.TabIndex = 35
        Me.cmdExit_PRIN.Tag = ""
        '
        'cmdAdd_Prin
        '
        Me.cmdAdd_Prin.Location = New System.Drawing.Point(450, 354)
        Me.cmdAdd_Prin.Name = "cmdAdd_Prin"
        Me.cmdAdd_Prin.Size = New System.Drawing.Size(108, 18)
        Me.cmdAdd_Prin.TabIndex = 32
        Me.cmdAdd_Prin.Tag = "Add"
        Me.cmdAdd_Prin.Text = "Add"
        '
        'cmdEdit_Prin
        '
        Me.cmdEdit_Prin.Location = New System.Drawing.Point(559, 354)
        Me.cmdEdit_Prin.Name = "cmdEdit_Prin"
        Me.cmdEdit_Prin.Size = New System.Drawing.Size(108, 18)
        Me.cmdEdit_Prin.TabIndex = 33
        Me.cmdEdit_Prin.Tag = "Edit"
        Me.cmdEdit_Prin.Text = "Edit"
        '
        'cmdDelete_Prin
        '
        Me.cmdDelete_Prin.Location = New System.Drawing.Point(668, 354)
        Me.cmdDelete_Prin.Name = "cmdDelete_Prin"
        Me.cmdDelete_Prin.Size = New System.Drawing.Size(108, 18)
        Me.cmdDelete_Prin.TabIndex = 34
        Me.cmdDelete_Prin.Tag = "Delete"
        Me.cmdDelete_Prin.Text = "Delete"
        '
        'cmdExit_PM
        '
        Me.cmdExit_PM.Enabled = False
        Me.cmdExit_PM.Location = New System.Drawing.Point(778, 718)
        Me.cmdExit_PM.Name = "cmdExit_PM"
        Me.cmdExit_PM.Size = New System.Drawing.Size(108, 18)
        Me.cmdExit_PM.TabIndex = 45
        Me.cmdExit_PM.Tag = ""
        '
        'cmdAdd_PM
        '
        Me.cmdAdd_PM.Location = New System.Drawing.Point(450, 718)
        Me.cmdAdd_PM.Name = "cmdAdd_PM"
        Me.cmdAdd_PM.Size = New System.Drawing.Size(108, 18)
        Me.cmdAdd_PM.TabIndex = 42
        Me.cmdAdd_PM.Tag = "Add"
        Me.cmdAdd_PM.Text = "Add"
        '
        'cmdEdit_PM
        '
        Me.cmdEdit_PM.Location = New System.Drawing.Point(559, 718)
        Me.cmdEdit_PM.Name = "cmdEdit_PM"
        Me.cmdEdit_PM.Size = New System.Drawing.Size(108, 18)
        Me.cmdEdit_PM.TabIndex = 43
        Me.cmdEdit_PM.Tag = "Edit"
        Me.cmdEdit_PM.Text = "Edit"
        '
        'cmdDelete_PM
        '
        Me.cmdDelete_PM.Location = New System.Drawing.Point(668, 718)
        Me.cmdDelete_PM.Name = "cmdDelete_PM"
        Me.cmdDelete_PM.Size = New System.Drawing.Size(108, 18)
        Me.cmdDelete_PM.TabIndex = 44
        Me.cmdDelete_PM.Tag = "Delete"
        Me.cmdDelete_PM.Text = "Delete"
        '
        'cmdExit_NSM
        '
        Me.cmdExit_NSM.Enabled = False
        Me.cmdExit_NSM.Location = New System.Drawing.Point(334, 718)
        Me.cmdExit_NSM.Name = "cmdExit_NSM"
        Me.cmdExit_NSM.Size = New System.Drawing.Size(108, 18)
        Me.cmdExit_NSM.TabIndex = 41
        Me.cmdExit_NSM.Tag = ""
        '
        'cmdAdd_NSM
        '
        Me.cmdAdd_NSM.Location = New System.Drawing.Point(7, 718)
        Me.cmdAdd_NSM.Name = "cmdAdd_NSM"
        Me.cmdAdd_NSM.Size = New System.Drawing.Size(108, 18)
        Me.cmdAdd_NSM.TabIndex = 38
        Me.cmdAdd_NSM.Tag = "Add"
        Me.cmdAdd_NSM.Text = "Add"
        '
        'cmdEdit_NSM
        '
        Me.cmdEdit_NSM.Location = New System.Drawing.Point(116, 718)
        Me.cmdEdit_NSM.Name = "cmdEdit_NSM"
        Me.cmdEdit_NSM.Size = New System.Drawing.Size(108, 18)
        Me.cmdEdit_NSM.TabIndex = 39
        Me.cmdEdit_NSM.Tag = "Edit"
        Me.cmdEdit_NSM.Text = "Edit"
        '
        'cmdDelete_NSM
        '
        Me.cmdDelete_NSM.Location = New System.Drawing.Point(225, 718)
        Me.cmdDelete_NSM.Name = "cmdDelete_NSM"
        Me.cmdDelete_NSM.Size = New System.Drawing.Size(108, 18)
        Me.cmdDelete_NSM.TabIndex = 40
        Me.cmdDelete_NSM.Tag = "Delete"
        Me.cmdDelete_NSM.Text = "Delete"
        '
        'txtItemCode
        '
        Me.txtItemCode.Location = New System.Drawing.Point(758, 6)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(124, 20)
        Me.txtItemCode.TabIndex = 107
        Me.txtItemCode.Tag = ""
        Me.txtItemCode.Text = "txtItemCode"
        Me.txtItemCode.Visible = False
        '
        'TxtStat1
        '
        Me.TxtStat1.BackColor = System.Drawing.SystemColors.Window
        Me.TxtStat1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtStat1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TxtStat1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStat1.Location = New System.Drawing.Point(8, 6)
        Me.TxtStat1.MaxLength = 1
        Me.TxtStat1.Name = "TxtStat1"
        Me.TxtStat1.ReadOnly = True
        Me.TxtStat1.Size = New System.Drawing.Size(14, 20)
        Me.TxtStat1.TabIndex = 108
        Me.TxtStat1.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 20)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "<--  Click here to show only  ""INACTIVE ITEMS"""
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(778, 536)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 18)
        Me.Button1.TabIndex = 113
        Me.Button1.Tag = ""
        '
        'cmdAdd_Dsg
        '
        Me.cmdAdd_Dsg.Location = New System.Drawing.Point(450, 536)
        Me.cmdAdd_Dsg.Name = "cmdAdd_Dsg"
        Me.cmdAdd_Dsg.Size = New System.Drawing.Size(108, 18)
        Me.cmdAdd_Dsg.TabIndex = 110
        Me.cmdAdd_Dsg.Tag = "Add"
        Me.cmdAdd_Dsg.Text = "Add"
        '
        'cmdEdit_Dsg
        '
        Me.cmdEdit_Dsg.Location = New System.Drawing.Point(560, 536)
        Me.cmdEdit_Dsg.Name = "cmdEdit_Dsg"
        Me.cmdEdit_Dsg.Size = New System.Drawing.Size(108, 18)
        Me.cmdEdit_Dsg.TabIndex = 111
        Me.cmdEdit_Dsg.Tag = "Edit"
        Me.cmdEdit_Dsg.Text = "Edit"
        '
        'cmdDelete_Dsg
        '
        Me.cmdDelete_Dsg.Location = New System.Drawing.Point(668, 536)
        Me.cmdDelete_Dsg.Name = "cmdDelete_Dsg"
        Me.cmdDelete_Dsg.Size = New System.Drawing.Size(108, 18)
        Me.cmdDelete_Dsg.TabIndex = 112
        Me.cmdDelete_Dsg.Tag = "Delete"
        Me.cmdDelete_Dsg.Text = "Delete"
        '
        'DG_dsg
        '
        Me.DG_dsg.BackgroundColor = System.Drawing.Color.Lavender
        Me.DG_dsg.CaptionBackColor = System.Drawing.Color.Red
        Me.DG_dsg.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.DG_dsg.CaptionText = "DIVISION SUB GROUP"
        Me.DG_dsg.DataMember = ""
        Me.DG_dsg.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DG_dsg.Location = New System.Drawing.Point(450, 380)
        Me.DG_dsg.Name = "DG_dsg"
        Me.DG_dsg.Size = New System.Drawing.Size(436, 156)
        Me.DG_dsg.TabIndex = 114
        Me.DG_dsg.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle7})
        '
        'DataGridTableStyle7
        '
        Me.DataGridTableStyle7.DataGrid = Me.DG_dsg
        Me.DataGridTableStyle7.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn67, Me.DataGridTextBoxColumn68, Me.DataGridTextBoxColumn69, Me.DataGridTextBoxColumn72, Me.DataGridTextBoxColumn73, Me.DataGridTextBoxColumn70, Me.DataGridTextBoxColumn71, Me.DataGridTextBoxColumn74, Me.DataGridTextBoxColumn75, Me.DataGridTextBoxColumn76})
        Me.DataGridTableStyle7.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle7.MappingName = "ItemDivSubGrp_Show"
        '
        'DataGridTextBoxColumn67
        '
        Me.DataGridTextBoxColumn67.Format = ""
        Me.DataGridTextBoxColumn67.FormatInfo = Nothing
        Me.DataGridTextBoxColumn67.MappingName = "rowid"
        Me.DataGridTextBoxColumn67.NullText = ""
        Me.DataGridTextBoxColumn67.Width = 0
        '
        'DataGridTextBoxColumn68
        '
        Me.DataGridTextBoxColumn68.Format = ""
        Me.DataGridTextBoxColumn68.FormatInfo = Nothing
        Me.DataGridTextBoxColumn68.MappingName = "itemcode"
        Me.DataGridTextBoxColumn68.NullText = ""
        Me.DataGridTextBoxColumn68.Width = 0
        '
        'DataGridTextBoxColumn69
        '
        Me.DataGridTextBoxColumn69.Format = ""
        Me.DataGridTextBoxColumn69.FormatInfo = Nothing
        Me.DataGridTextBoxColumn69.MappingName = "divcode"
        Me.DataGridTextBoxColumn69.NullText = ""
        Me.DataGridTextBoxColumn69.Width = 0
        '
        'DataGridTextBoxColumn70
        '
        Me.DataGridTextBoxColumn70.Format = ""
        Me.DataGridTextBoxColumn70.FormatInfo = Nothing
        Me.DataGridTextBoxColumn70.MappingName = "subcode"
        Me.DataGridTextBoxColumn70.NullText = ""
        Me.DataGridTextBoxColumn70.Width = 0
        '
        'DataGridTextBoxColumn71
        '
        Me.DataGridTextBoxColumn71.Format = ""
        Me.DataGridTextBoxColumn71.FormatInfo = Nothing
        Me.DataGridTextBoxColumn71.HeaderText = "Div Sub Group"
        Me.DataGridTextBoxColumn71.MappingName = "DivSubGrp"
        Me.DataGridTextBoxColumn71.NullText = ""
        Me.DataGridTextBoxColumn71.Width = 220
        '
        'DataGridTextBoxColumn72
        '
        Me.DataGridTextBoxColumn72.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn72.FormatInfo = Nothing
        Me.DataGridTextBoxColumn72.HeaderText = "Start_Date"
        Me.DataGridTextBoxColumn72.MappingName = "start_date"
        Me.DataGridTextBoxColumn72.NullText = ""
        Me.DataGridTextBoxColumn72.Width = 70
        '
        'DataGridTextBoxColumn73
        '
        Me.DataGridTextBoxColumn73.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn73.FormatInfo = Nothing
        Me.DataGridTextBoxColumn73.HeaderText = "End Date"
        Me.DataGridTextBoxColumn73.MappingName = "end_date"
        Me.DataGridTextBoxColumn73.NullText = ""
        Me.DataGridTextBoxColumn73.Width = 70
        '
        'DataGridTextBoxColumn74
        '
        Me.DataGridTextBoxColumn74.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn74.FormatInfo = Nothing
        Me.DataGridTextBoxColumn74.HeaderText = "Create Date"
        Me.DataGridTextBoxColumn74.MappingName = "createdate"
        Me.DataGridTextBoxColumn74.NullText = ""
        Me.DataGridTextBoxColumn74.Width = 70
        '
        'DataGridTextBoxColumn75
        '
        Me.DataGridTextBoxColumn75.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn75.FormatInfo = Nothing
        Me.DataGridTextBoxColumn75.HeaderText = "Update Date"
        Me.DataGridTextBoxColumn75.MappingName = "updatedate"
        Me.DataGridTextBoxColumn75.NullText = ""
        Me.DataGridTextBoxColumn75.Width = 70
        '
        'DataGridTextBoxColumn76
        '
        Me.DataGridTextBoxColumn76.Format = ""
        Me.DataGridTextBoxColumn76.FormatInfo = Nothing
        Me.DataGridTextBoxColumn76.MappingName = "lastuser"
        Me.DataGridTextBoxColumn76.NullText = ""
        Me.DataGridTextBoxColumn76.Width = 0
        '
        'ItemCT
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(892, 746)
        Me.Controls.Add(Me.DG_dsg)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdAdd_Dsg)
        Me.Controls.Add(Me.cmdEdit_Dsg)
        Me.Controls.Add(Me.cmdDelete_Dsg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtStat1)
        Me.Controls.Add(Me.txtItemCode)
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
        Me.Controls.Add(Me.cmdExit_PRIN)
        Me.Controls.Add(Me.cmdAdd_Prin)
        Me.Controls.Add(Me.cmdEdit_Prin)
        Me.Controls.Add(Me.cmdDelete_Prin)
        Me.Controls.Add(Me.cmdExit_DIV)
        Me.Controls.Add(Me.cmdAdd_DIV)
        Me.Controls.Add(Me.cmdEdit_DIV)
        Me.Controls.Add(Me.cmdDelete_DIV)
        Me.Controls.Add(Me.cmdExit_IPH)
        Me.Controls.Add(Me.cmdAdd_IPH)
        Me.Controls.Add(Me.cmdEdit_IPH)
        Me.Controls.Add(Me.cmdDelete_IPH)
        Me.Controls.Add(Me.DG_ipc)
        Me.Controls.Add(Me.DG_prin)
        Me.Controls.Add(Me.DG_div)
        Me.Controls.Add(Me.cmdExit_Itm)
        Me.Controls.Add(Me.cmdAdd_Itm)
        Me.Controls.Add(Me.cmdEdit_Itm)
        Me.Controls.Add(Me.cmdDelete_Itm)
        Me.Controls.Add(Me.DG_items)
        Me.MaximizeBox = False
        Me.Name = "ItemCT"
        Me.Opacity = 0.1
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.TransparencyKey = System.Drawing.Color.Transparent
        CType(Me.DG_items, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_nsm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_ipc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_div, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_prin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_pm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_dsg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub Itm_Sub_Show()
        If RemoteDataSet.ItemCodTab_Show.Count > 0 Then RemoteDataSet.ItemCodTab_Show.Clear()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        If Trim(TxtStat1.Text) = "" Then
            itmX = "ItemCodTab_Show"
        ElseIf Trim(TxtStat1.Text) = "X" Then
            itmX = "ItemCodTab_Show_X"
        End If
        Try
            BusinessObject.Sub_Show(ServerPath2, itmX, CommandType.StoredProcedure, RemoteDataSet, "ItemCodTab_Show")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        DG_items.DataSource = RemoteDataSet.ItemCodTab_Show
        PopulateGrids()
        txtItemCode.Text = DG_items.Item(DG_items.CurrentCell.RowNumber, 1).ToString
    End Sub

    Private Sub ItemCT_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        modControlBehavior.EnableControls(Me, False)

    End Sub

    Private Sub PriceHist()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter
        Dim ItemCode As New SqlParameter("@ItemCode", SqlDbType.VarChar, 10)
        ItemCode.Direction = ParameterDirection.Input
        ItemCode.Value = DG_items.Item(DG_items.CurrentCell.RowNumber, 1).ToString
        Params(0) = ItemCode

        If RemoteDataSet.ItemPriceHist_DS_Show.Count > 0 Then RemoteDataSet.ItemPriceHist_DS_Show.Clear()
        Try
            BusinessObject.Sub_Show(ServerPath2, "ItemPriceHist_Show", CommandType.StoredProcedure, RemoteDataSet, "ItemPriceHist_DS_Show", Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        DG_ipc.DataSource = RemoteDataSet.ItemPriceHist_DS_Show
    End Sub

    Private Sub DivSubList()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Param(1) As SqlParameter
        Dim ItemCode2 As New SqlParameter("@ItemCode2", SqlDbType.VarChar, 10)
        ItemCode2.Direction = ParameterDirection.Input
        ItemCode2.Value = DG_items.Item(DG_items.CurrentCell.RowNumber, 1).ToString
        Param(0) = ItemCode2
        Dim DivCode As New SqlParameter("@DivCode", SqlDbType.VarChar, 3)
        DivCode.Direction = ParameterDirection.Input
        DivCode.Value = DG_div.Item(DG_div.CurrentCell.RowNumber, 4).ToString
        Param(1) = DivCode

        If RemoteDataSet.ItemDivSubGrp_Show.Count > 0 Then RemoteDataSet.ItemDivSubGrp_Show.Clear()
        Try
            BusinessObject.Sub_Show(ServerPath2, "ItemDivSubGrp_Show", CommandType.StoredProcedure, RemoteDataSet, "ItemDivSubGrp_Show", Param)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        DG_dsg.DataSource = RemoteDataSet.ItemDivSubGrp_Show
    End Sub

    Private Sub DivList()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Param(0) As SqlParameter
        Dim ItemCode2 As New SqlParameter("@ItemCode2", SqlDbType.VarChar, 10)
        ItemCode2.Direction = ParameterDirection.Input
        ItemCode2.Value = DG_items.Item(DG_items.CurrentCell.RowNumber, 1).ToString
        Param(0) = ItemCode2

        If RemoteDataSet.ItemDivision_Show.Count > 0 Then RemoteDataSet.ItemDivision_Show.Clear()
        Try
            BusinessObject.Sub_Show(ServerPath2, "ItemDivision2_Show", CommandType.StoredProcedure, RemoteDataSet, "ItemDivision_Show", Param)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        DG_div.DataSource = RemoteDataSet.ItemDivision_Show
    End Sub

    Private Sub PrinList()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter
        Dim ItemCode As New SqlParameter("@ItemCode", SqlDbType.VarChar, 10)
        ItemCode.Direction = ParameterDirection.Input
        ItemCode.Value = DG_items.Item(DG_items.CurrentCell.RowNumber, 1).ToString
        Params(0) = ItemCode

        If RemoteDataSet.ItemPrincipal_Show.Count > 0 Then RemoteDataSet.ItemPrincipal_Show.Clear()
        Try
            BusinessObject.Sub_Show(ServerPath2, "ItemPrincipal_Show", CommandType.StoredProcedure, RemoteDataSet, "ItemPrincipal_Show", Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        DG_prin.DataSource = RemoteDataSet.ItemPrincipal_Show
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

    Private Sub DG_div_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_div.Click, DG_div.CurrentCellChanged
        DivSubList()
    End Sub

    Private Sub DG_items_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DG_items.Click, DG_items.CurrentCellChanged
        PopulateGrids()
        txtItemCode.Text = DG_items.Item(DG_items.CurrentCell.RowNumber, 1).ToString
    End Sub

    Private Sub PopulateGrids()
        PriceHist()
        DivList()
        PrinList()
        NSM_List()
        PM_List()
    End Sub

    Private Sub cmdAdd_itm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd_Itm.Click
        Dim MyLoadedForm As New Itm_Entry
        Itm_EditMode = False
        MyLoadedForm.ShowDialog(Me)
    End Sub

    Private Sub cmdEdit_itm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit_Itm.Click
        'modControlBehavior.EnableControls(Me, True)
        Dim MyLoadedForm As New Itm_Entry
        Dim tmpDate As String
        Dim s As String
        MyLoadedForm.vRowId.Text = DG_items.Item(DG_items.CurrentCell.RowNumber, 0).ToString
        MyLoadedForm.vItemCode.Text = DG_items.Item(DG_items.CurrentCell.RowNumber, 1).ToString
        MyLoadedForm.vMetroDrugCode.Text = DG_items.Item(DG_items.CurrentCell.RowNumber, 2).ToString
        MyLoadedForm.vMercuryItemCode.Text = DG_items.Item(DG_items.CurrentCell.RowNumber, 3).ToString
        MyLoadedForm.vItemDesc.Text = DG_items.Item(DG_items.CurrentCell.RowNumber, 4).ToString
        MyLoadedForm.vGenericName.Text = DG_items.Item(DG_items.CurrentCell.RowNumber, 5).ToString
        s = DG_items.Item(DG_items.CurrentCell.RowNumber, 6).ToString
        If InStr(s, "'") <> 0 Then
            s = StrTran(s, "''", "'")
        End If
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

        tmpDate = DG_items.Item(DG_items.CurrentCell.RowNumber, 16).ToString
        If Trim(tmpDate) <> "" Then
            MyLoadedForm.vLaunchDate.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
        End If

        tmpDate = DG_items.Item(DG_items.CurrentCell.RowNumber, 17).ToString
        If Trim(tmpDate) <> "" Then
            MyLoadedForm.vInActiveDate.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
        End If

        MyLoadedForm.cboStatus.Text = DG_items.Item(DG_items.CurrentCell.RowNumber, 18).ToString
        Filds(18) = DG_items.Item(DG_items.CurrentCell.RowNumber, 18).ToString

        MyLoadedForm.vLastUser.Text = DG_items.Item(DG_items.CurrentCell.RowNumber, 19).ToString

        tmpDate = DG_items.Item(DG_items.CurrentCell.RowNumber, 20).ToString
        If Trim(tmpDate) <> "" Then
            MyLoadedForm.vCreateDate.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
        End If

        tmpDate = DG_items.Item(DG_items.CurrentCell.RowNumber, 21).ToString
        If Trim(tmpDate) <> "" Then
            MyLoadedForm.vUpdateDate.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
        End If

        Itm_EditMode = True
        MyLoadedForm.ShowDialog(Me)
        Me.Refresh()
        Itm_Sub_Show()
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
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter
        Dim ItemCode As New SqlParameter("@ItemCode", SqlDbType.Int)
        ItemCode.Direction = ParameterDirection.Input
        ItemCode.Value = jTrim(txtItemCode.Text)
        Params(0) = ItemCode
        Try
            BusinessObject.Sub_Delete(ServerPath2, "ItemCT_Delete", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxtStat1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtStat1.Click
        If Trim(TxtStat1.Text) = "" Then
            TxtStat1.Text = "X"
        Else
            TxtStat1.Text = ""
        End If
        Itm_Sub_Show()
    End Sub

    Private Sub cmdExit_Itm_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdExit_Itm.Click
        Close()
    End Sub

    Private Sub cmdAdd_IPH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd_IPH.Click
        Dim MyLoadedForm As New Ipc_Entry
        Itm_EditMode = False
        MyLoadedForm.vItemCode.Text = jTrim(txtItemCode.Text)
        MyLoadedForm.vCreateDate.Text = GetDateTimeNow("MM/dd/yyyy")
        MyLoadedForm.vUpdateDate.Text = GetDateTimeNow("MM/dd/yyyy")
        MyLoadedForm.ShowDialog(Me)
    End Sub

    Private Sub cmdEdit_IPH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit_IPH.Click
        Dim MyLoadedForm As New Ipc_Entry
        Dim tmpDate As String
        Dim s As String
        MyLoadedForm.vRowId.Text = DG_ipc.Item(DG_ipc.CurrentCell.RowNumber, 0).ToString
        MyLoadedForm.vItemCode.Text = DG_ipc.Item(DG_ipc.CurrentCell.RowNumber, 1).ToString

        tmpDate = DG_ipc.Item(DG_ipc.CurrentCell.RowNumber, 2).ToString
        If Trim(tmpDate) <> "" Then
            MyLoadedForm.vStart_Date.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
            MyLoadedForm.vStart_DateO.Text = DG_ipc.Item(DG_ipc.CurrentCell.RowNumber, 2).ToString()
        End If

        tmpDate = DG_ipc.Item(DG_ipc.CurrentCell.RowNumber, 3).ToString
        If Trim(tmpDate) <> "" Then
            MyLoadedForm.vEnd_Date.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
        End If

        MyLoadedForm.vSellingPrice.Text = DG_ipc.Item(DG_ipc.CurrentCell.RowNumber, 4).ToString
        MyLoadedForm.vSellingPriceO.Text = DG_ipc.Item(DG_ipc.CurrentCell.RowNumber, 4).ToString

        tmpDate = DG_ipc.Item(DG_ipc.CurrentCell.RowNumber, 5).ToString
        If Trim(tmpDate) <> "" Then
            MyLoadedForm.vCreateDate.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
        End If

        tmpDate = DG_ipc.Item(DG_ipc.CurrentCell.RowNumber, 6).ToString
        If Trim(tmpDate) <> "" Then
            MyLoadedForm.vUpdateDate.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
        End If

        MyLoadedForm.vLastUser.Text = DG_ipc.Item(DG_ipc.CurrentCell.RowNumber, 7).ToString

        Itm_EditMode = True
        MyLoadedForm.ShowDialog(Me)
        Me.Refresh()
        PriceHist()
    End Sub

    Private Sub cmdDelete_IPH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete_IPH.Click
        If txtItemCode.Text > "" Then
            If (MessageBox.Show("Do you really want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, _
            MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then
                SubIph_Delete()
                ControlMaintenance.ClearInputControls(Me)
                PriceHist()
            End If
        End If
    End Sub

    Private Sub SubIph_Delete()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(2) As SqlParameter

        Dim ItemCode As New SqlParameter("@ItemCode", SqlDbType.VarChar, 10)
        ItemCode.Direction = ParameterDirection.Input
        ItemCode.Value = jTrim(txtItemCode.Text)
        Params(0) = ItemCode

        Dim SellingPrice As New SqlParameter("@SellingPrice", SqlDbType.Money)
        SellingPrice.Direction = ParameterDirection.Input
        SellingPrice.Value = DG_ipc.Item(DG_ipc.CurrentCell.RowNumber, 4).ToString
        Params(1) = SellingPrice

        Dim Start_Date As New SqlParameter("@Start_Date", SqlDbType.DateTime)
        Start_Date.Direction = ParameterDirection.Input
        Start_Date.Value = DG_ipc.Item(DG_ipc.CurrentCell.RowNumber, 2).ToString
        Params(2) = Start_Date

        Try
            BusinessObject.Sub_Delete(ServerPath2, "ItemPH_del", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdAdd_DIV_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd_DIV.Click
        Dim MyLoadedForm As New Idiv_Entry
        Itm_EditMode = False
        MyLoadedForm.vItemCode.Text = jTrim(txtItemCode.Text)
        MyLoadedForm.vCreateDate.Text = GetDateTimeNow("MM/dd/yyyy")
        MyLoadedForm.vUpdateDate.Text = GetDateTimeNow("MM/dd/yyyy")
        MyLoadedForm.ShowDialog(Me)
    End Sub

    Private Sub cmdEdit_DIV_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdEdit_DIV.Click
        Dim MyLoadedForm As New Idiv_Entry
        Dim tmpDate As String
        Dim s As String
        MyLoadedForm.vRowId.Text = DG_div.Item(DG_div.CurrentCell.RowNumber, 0).ToString
        MyLoadedForm.vItemCode.Text = DG_div.Item(DG_div.CurrentCell.RowNumber, 1).ToString

        tmpDate = DG_div.Item(DG_div.CurrentCell.RowNumber, 2).ToString
        If Trim(tmpDate) <> "" Then
            MyLoadedForm.vStart_Date.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
            MyLoadedForm.vStart_DateO.Text = DG_div.Item(DG_div.CurrentCell.RowNumber, 2).ToString
        End If

        tmpDate = DG_div.Item(DG_div.CurrentCell.RowNumber, 3).ToString
        If Trim(tmpDate) <> "" Then
            MyLoadedForm.vEnd_Date.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
        End If

        Filds(4) = DG_div.Item(DG_div.CurrentCell.RowNumber, 5).ToString
        MyLoadedForm.cboDivision.Text = Filds(4).ToString
        MyLoadedForm.cboDivisionO.Text = DG_div.Item(DG_div.CurrentCell.RowNumber, 5).ToString

        tmpDate = DG_div.Item(DG_div.CurrentCell.RowNumber, 6).ToString
        If Trim(tmpDate) <> "" Then
            MyLoadedForm.vCreateDate.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
        End If

        tmpDate = DG_div.Item(DG_div.CurrentCell.RowNumber, 7).ToString
        If Trim(tmpDate) <> "" Then
            MyLoadedForm.vUpdateDate.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
        End If

        MyLoadedForm.vLastUser.Text = DG_div.Item(DG_div.CurrentCell.RowNumber, 8).ToString

        Itm_EditMode = True
        MyLoadedForm.ShowDialog(Me)
        Me.Refresh()
        DivList()
    End Sub

    Private Sub cmdDelete_DIV_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete_DIV.Click
        If txtItemCode.Text > "" Then
            If (MessageBox.Show("Do you really want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, _
            MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then
                SubIdiv_Delete()
                ControlMaintenance.ClearInputControls(Me)
                DivList()
            End If
        End If
    End Sub

    Private Sub SubIdiv_Delete()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(2) As SqlParameter

        Dim ItemCode As New SqlParameter("@ItemCode", SqlDbType.VarChar, 10)
        ItemCode.Direction = ParameterDirection.Input
        ItemCode.Value = jTrim(txtItemCode.Text)
        Params(0) = ItemCode

        Dim DivCode As New SqlParameter("@DivCode", SqlDbType.VarChar, 3)
        DivCode.Direction = ParameterDirection.Input
        DivCode.Value = DG_div.Item(DG_div.CurrentCell.RowNumber, 4).ToString
        Params(1) = DivCode

        Dim Start_Date As New SqlParameter("@Start_Date", SqlDbType.DateTime)
        Start_Date.Direction = ParameterDirection.Input
        Start_Date.Value = DG_div.Item(DG_div.CurrentCell.RowNumber, 2).ToString
        Params(2) = Start_Date

        Try
            BusinessObject.Sub_Delete(ServerPath2, "ItemDiv_del", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdAdd_Prin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd_Prin.Click
        Dim MyLoadedForm As New Iprin_Entry
        Itm_EditMode = False
        MyLoadedForm.vItemCode.Text = jTrim(txtItemCode.Text)
        MyLoadedForm.vCreateDate.Text = GetDateTimeNow("MM/dd/yyyy")
        MyLoadedForm.vUpdateDate.Text = GetDateTimeNow("MM/dd/yyyy")
        MyLoadedForm.ShowDialog(Me)
    End Sub

    Private Sub cmdEdit_Prin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit_Prin.Click
        Dim MyLoadedForm As New Iprin_Entry
        Dim tmpDate As String
        Dim s As String
        MyLoadedForm.vRowId.Text = DG_prin.Item(DG_prin.CurrentCell.RowNumber, 0).ToString
        MyLoadedForm.vItemCode.Text = DG_prin.Item(DG_prin.CurrentCell.RowNumber, 1).ToString

        tmpDate = DG_prin.Item(DG_prin.CurrentCell.RowNumber, 2).ToString
        If Trim(tmpDate) <> "" Then
            MyLoadedForm.vStart_Date.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
            MyLoadedForm.vStart_DateO.Text = DG_prin.Item(DG_prin.CurrentCell.RowNumber, 2).ToString
        End If

        tmpDate = DG_prin.Item(DG_prin.CurrentCell.RowNumber, 3).ToString
        If Trim(tmpDate) <> "" Then
            MyLoadedForm.vEnd_Date.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
        End If

        Filds(4) = DG_prin.Item(DG_prin.CurrentCell.RowNumber, 5).ToString
        MyLoadedForm.cboPrincipal.Text = Filds(4).ToString
        MyLoadedForm.cboPrincipalO.Text = DG_prin.Item(DG_prin.CurrentCell.RowNumber, 5).ToString

        tmpDate = DG_prin.Item(DG_prin.CurrentCell.RowNumber, 6).ToString
        If Trim(tmpDate) <> "" Then
            MyLoadedForm.vCreateDate.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
        End If

        tmpDate = DG_prin.Item(DG_prin.CurrentCell.RowNumber, 7).ToString
        If Trim(tmpDate) <> "" Then
            MyLoadedForm.vUpdateDate.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
        End If

        MyLoadedForm.vLastUser.Text = DG_prin.Item(DG_prin.CurrentCell.RowNumber, 8).ToString

        Itm_EditMode = True
        MyLoadedForm.ShowDialog(Me)
        Me.Refresh()
        PrinList()
    End Sub

    Private Sub cmdDelete_Prin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete_Prin.Click
        If txtItemCode.Text > "" Then
            If (MessageBox.Show("Do you really want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, _
            MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then
                SubIprin_Delete()
                ControlMaintenance.ClearInputControls(Me)
                PrinList()
            End If
        End If
    End Sub

    Private Sub SubIprin_Delete()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(2) As SqlParameter

        Dim ItemCode As New SqlParameter("@ItemCode", SqlDbType.VarChar, 10)
        ItemCode.Direction = ParameterDirection.Input
        ItemCode.Value = jTrim(txtItemCode.Text)
        Params(0) = ItemCode

        Dim PrinCode As New SqlParameter("@PrinCode", SqlDbType.VarChar, 5)
        PrinCode.Direction = ParameterDirection.Input
        PrinCode.Value = DG_prin.Item(DG_prin.CurrentCell.RowNumber, 4).ToString
        Params(1) = PrinCode

        Dim Start_Date As New SqlParameter("@Start_Date", SqlDbType.DateTime, 10)
        Start_Date.Direction = ParameterDirection.Input
        Start_Date.Value = DG_prin.Item(DG_prin.CurrentCell.RowNumber, 2).ToString
        Params(2) = Start_Date

        Try
            BusinessObject.Sub_Delete(ServerPath2, "ItemPrin_del", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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

        Try
            BusinessObject.Sub_Delete(ServerPath2, "ItemNSM_del", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox(ex.Message)
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

        Try
            BusinessObject.Sub_Delete(ServerPath2, "ItemPM_del", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdAdd_Dsg_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd_Dsg.Click
        Dim MyLoadedForm As New Idsg_Entry
        Dim tmpdat As String
        Itm_EditMode = False
        tmpdat = GetDateTimeNow("MM/dd/yyyy")
        MyLoadedForm.vItemCode.Text = jTrim(txtItemCode.Text)
        MyLoadedForm.vDivCode.Text = jTrim(GetCode(DG_div.Item(DG_div.CurrentCell.RowNumber, 5).ToString))
        MyLoadedForm.vCreateDate.Text = tmpdat
        MyLoadedForm.vUpdateDate.Text = tmpdat
        MyLoadedForm.ShowDialog(Me)
        DivSubList()
    End Sub

    Private Sub cmdDelete_Dsg_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete_Dsg.Click
        If txtItemCode.Text > "" Then
            If (jTrim(GetCode(DG_div.Item(DG_div.CurrentCell.RowNumber, 5).ToString))) > "" Then
                If (MessageBox.Show("Do you really want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, _
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then

                    SubIdsg_Delete()
                    ControlMaintenance.ClearInputControls(Me)
                    DivSubList()
                End If
            End If
        End If
    End Sub

    Private Sub SubIdsg_Delete()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter

        Dim Rowid As New SqlParameter("@Rowid", SqlDbType.Int)
        Rowid.Direction = ParameterDirection.Input
        Rowid.Value = jTrim(DG_dsg.Item(DG_dsg.CurrentCell.RowNumber, 0).ToString)
        Params(0) = Rowid

        Try
            BusinessObject.Sub_Delete(ServerPath2, "ItemDivSubGrp_del", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdEdit_Dsg_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdEdit_Dsg.Click
        Dim MyLoadedForm As New Idsg_Entry
        Dim tmpDate As String
        Dim s As String
        MyLoadedForm.vRowId.Text = DG_dsg.Item(DG_dsg.CurrentCell.RowNumber, 0).ToString
        MyLoadedForm.vItemCode.Text = DG_dsg.Item(DG_dsg.CurrentCell.RowNumber, 1).ToString
        MyLoadedForm.vDivCode.Text = DG_dsg.Item(DG_dsg.CurrentCell.RowNumber, 2).ToString

        tmpDate = DG_dsg.Item(DG_dsg.CurrentCell.RowNumber, 3).ToString
        If Trim(tmpDate) <> "" Then
            MyLoadedForm.vStart_Date.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
        End If

        tmpDate = DG_dsg.Item(DG_dsg.CurrentCell.RowNumber, 4).ToString
        If Trim(tmpDate) <> "" Then
            MyLoadedForm.vEnd_Date.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
        End If

        Filds(4) = DG_dsg.Item(DG_dsg.CurrentCell.RowNumber, 6).ToString
        MyLoadedForm.cboDivisionSG.Text = Filds(4).ToString

        tmpDate = DG_dsg.Item(DG_dsg.CurrentCell.RowNumber, 7).ToString
        If Trim(tmpDate) <> "" Then
            MyLoadedForm.vCreateDate.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
        End If

        tmpDate = DG_dsg.Item(DG_dsg.CurrentCell.RowNumber, 8).ToString
        If Trim(tmpDate) <> "" Then
            MyLoadedForm.vUpdateDate.Text = Format(CDate(tmpDate), "MM/dd/yyyy")
        End If

        MyLoadedForm.vLastUser.Text = DG_dsg.Item(DG_dsg.CurrentCell.RowNumber, 9).ToString

        Itm_EditMode = True
        MyLoadedForm.ShowDialog(Me)
        Me.Refresh()
        DivList()
    End Sub
End Class
