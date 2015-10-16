Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
'Imports DataAccessHelper
Public Class Main
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
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileMaintenane As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_Reports As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEditIntegratedSales As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_ControlTotals As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMedRepBudget As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_DistributeReports As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_ProcessMdiData As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_ProcessSubDistributorData As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_ProcessInHouseData As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_QpiMercurySales As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_QpiPerTerritory As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_MdiPerMedrep As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_ProcessCallRate As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_HiiPerTerritory As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_MercurySales As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_MdiPerMedrepUntagged As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_CommissionAttachment As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_MedrepCommission As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_MedrepCommissionWithRecovery As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_CommissionAttachmentDM As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_SupervisorCommission As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_DistrictManagerCommissionWithRecovery As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_HiiMercurySales As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem33 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem34 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem35 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem36 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem37 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem38 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem39 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem40 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem41 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem43 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem44 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem45 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem46 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem47 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem48 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem49 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem50 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem51 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem52 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem53 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem54 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem55 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem56 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem57 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem58 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem59 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem60 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem66 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem70 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem71 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem72 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem73 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem74 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem75 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem76 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem77 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem78 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem79 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem80 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem81 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem82 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem83 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem84 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem86 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem87 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem88 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem90 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem62 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem63 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem64 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem85 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem89 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem91 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem92 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem93 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem94 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem95 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem96 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem97 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem98 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem61 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem100 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem65 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem42 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem69 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem67 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem68 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem99 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem101 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem102 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem103 As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_DistrictManagerCommissionWithRecovery2008 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem104 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuUserMaint As System.Windows.Forms.MenuItem
    Friend WithEvents MnuItmPriKeyProds As System.Windows.Forms.MenuItem
    Friend WithEvents MnuKeyProds As System.Windows.Forms.MenuItem
    Friend WithEvents MnuItmSecKeyProds As System.Windows.Forms.MenuItem
    Friend WithEvents MnuItmTerKeyProds As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_ProcessMercuryData As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents ExtCustZue As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Main))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.mnu_ProcessMdiData = New System.Windows.Forms.MenuItem
        Me.mnu_ProcessSubDistributorData = New System.Windows.Forms.MenuItem
        Me.mnu_ProcessInHouseData = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.Mnu_ProcessMercuryData = New System.Windows.Forms.MenuItem
        Me.mnu_ProcessCallRate = New System.Windows.Forms.MenuItem
        Me.mnu_ControlTotals = New System.Windows.Forms.MenuItem
        Me.MenuItem45 = New System.Windows.Forms.MenuItem
        Me.MenuItem50 = New System.Windows.Forms.MenuItem
        Me.MenuItem55 = New System.Windows.Forms.MenuItem
        Me.MenuItem56 = New System.Windows.Forms.MenuItem
        Me.MenuItem57 = New System.Windows.Forms.MenuItem
        Me.MenuItem58 = New System.Windows.Forms.MenuItem
        Me.MenuItem59 = New System.Windows.Forms.MenuItem
        Me.MenuItem60 = New System.Windows.Forms.MenuItem
        Me.mnuExit = New System.Windows.Forms.MenuItem
        Me.mnuFileMaintenane = New System.Windows.Forms.MenuItem
        Me.mnuEditIntegratedSales = New System.Windows.Forms.MenuItem
        Me.MenuItem104 = New System.Windows.Forms.MenuItem
        Me.mnuMedRepBudget = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem44 = New System.Windows.Forms.MenuItem
        Me.MenuItem98 = New System.Windows.Forms.MenuItem
        Me.ExtCustZue = New System.Windows.Forms.MenuItem
        Me.MenuItem102 = New System.Windows.Forms.MenuItem
        Me.mnu_Reports = New System.Windows.Forms.MenuItem
        Me.mnu_DistributeReports = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.mnu_MdiPerMedrep = New System.Windows.Forms.MenuItem
        Me.mnu_MercurySales = New System.Windows.Forms.MenuItem
        Me.mnu_MdiPerMedrepUntagged = New System.Windows.Forms.MenuItem
        Me.Mnu_CommissionAttachment = New System.Windows.Forms.MenuItem
        Me.Mnu_MedrepCommission = New System.Windows.Forms.MenuItem
        Me.Mnu_MedrepCommissionWithRecovery = New System.Windows.Forms.MenuItem
        Me.MenuItem103 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.Mnu_CommissionAttachmentDM = New System.Windows.Forms.MenuItem
        Me.Mnu_SupervisorCommission = New System.Windows.Forms.MenuItem
        Me.Mnu_DistrictManagerCommissionWithRecovery = New System.Windows.Forms.MenuItem
        Me.Mnu_DistrictManagerCommissionWithRecovery2008 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.Mnu_QpiPerTerritory = New System.Windows.Forms.MenuItem
        Me.Mnu_QpiMercurySales = New System.Windows.Forms.MenuItem
        Me.MenuItem66 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.Mnu_HiiPerTerritory = New System.Windows.Forms.MenuItem
        Me.Mnu_HiiMercurySales = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem24 = New System.Windows.Forms.MenuItem
        Me.MenuItem25 = New System.Windows.Forms.MenuItem
        Me.MenuItem26 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem27 = New System.Windows.Forms.MenuItem
        Me.MenuItem28 = New System.Windows.Forms.MenuItem
        Me.MenuItem29 = New System.Windows.Forms.MenuItem
        Me.MenuItem30 = New System.Windows.Forms.MenuItem
        Me.MenuItem31 = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.MenuItem32 = New System.Windows.Forms.MenuItem
        Me.MenuItem33 = New System.Windows.Forms.MenuItem
        Me.MenuItem34 = New System.Windows.Forms.MenuItem
        Me.MenuItem35 = New System.Windows.Forms.MenuItem
        Me.MenuItem36 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem37 = New System.Windows.Forms.MenuItem
        Me.MenuItem38 = New System.Windows.Forms.MenuItem
        Me.MenuItem39 = New System.Windows.Forms.MenuItem
        Me.MenuItem40 = New System.Windows.Forms.MenuItem
        Me.MenuItem41 = New System.Windows.Forms.MenuItem
        Me.MenuItem46 = New System.Windows.Forms.MenuItem
        Me.MenuItem47 = New System.Windows.Forms.MenuItem
        Me.MenuItem52 = New System.Windows.Forms.MenuItem
        Me.MenuItem48 = New System.Windows.Forms.MenuItem
        Me.MenuItem49 = New System.Windows.Forms.MenuItem
        Me.MenuItem51 = New System.Windows.Forms.MenuItem
        Me.MenuItem53 = New System.Windows.Forms.MenuItem
        Me.MenuItem54 = New System.Windows.Forms.MenuItem
        Me.MenuItem62 = New System.Windows.Forms.MenuItem
        Me.MenuItem63 = New System.Windows.Forms.MenuItem
        Me.MenuItem64 = New System.Windows.Forms.MenuItem
        Me.MenuItem85 = New System.Windows.Forms.MenuItem
        Me.MenuItem89 = New System.Windows.Forms.MenuItem
        Me.MenuItem91 = New System.Windows.Forms.MenuItem
        Me.MenuItem92 = New System.Windows.Forms.MenuItem
        Me.MenuItem93 = New System.Windows.Forms.MenuItem
        Me.MenuItem94 = New System.Windows.Forms.MenuItem
        Me.MenuItem70 = New System.Windows.Forms.MenuItem
        Me.MenuItem95 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem96 = New System.Windows.Forms.MenuItem
        Me.MenuItem71 = New System.Windows.Forms.MenuItem
        Me.MenuItem72 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem73 = New System.Windows.Forms.MenuItem
        Me.MenuItem74 = New System.Windows.Forms.MenuItem
        Me.MenuItem75 = New System.Windows.Forms.MenuItem
        Me.MenuItem101 = New System.Windows.Forms.MenuItem
        Me.MenuItem76 = New System.Windows.Forms.MenuItem
        Me.MenuItem77 = New System.Windows.Forms.MenuItem
        Me.MenuItem43 = New System.Windows.Forms.MenuItem
        Me.MenuItem78 = New System.Windows.Forms.MenuItem
        Me.MenuItem97 = New System.Windows.Forms.MenuItem
        Me.MenuItem79 = New System.Windows.Forms.MenuItem
        Me.MenuItem80 = New System.Windows.Forms.MenuItem
        Me.MenuItem81 = New System.Windows.Forms.MenuItem
        Me.MenuItem82 = New System.Windows.Forms.MenuItem
        Me.MenuItem83 = New System.Windows.Forms.MenuItem
        Me.MenuItem84 = New System.Windows.Forms.MenuItem
        Me.MenuItem86 = New System.Windows.Forms.MenuItem
        Me.MenuItem87 = New System.Windows.Forms.MenuItem
        Me.MenuItem88 = New System.Windows.Forms.MenuItem
        Me.MenuItem90 = New System.Windows.Forms.MenuItem
        Me.MenuItem61 = New System.Windows.Forms.MenuItem
        Me.MenuItem100 = New System.Windows.Forms.MenuItem
        Me.MenuItem99 = New System.Windows.Forms.MenuItem
        Me.MenuItem65 = New System.Windows.Forms.MenuItem
        Me.MenuItem42 = New System.Windows.Forms.MenuItem
        Me.MenuItem69 = New System.Windows.Forms.MenuItem
        Me.MenuItem67 = New System.Windows.Forms.MenuItem
        Me.MenuItem68 = New System.Windows.Forms.MenuItem
        Me.mnuUserMaint = New System.Windows.Forms.MenuItem
        Me.MnuKeyProds = New System.Windows.Forms.MenuItem
        Me.MnuItmPriKeyProds = New System.Windows.Forms.MenuItem
        Me.MnuItmSecKeyProds = New System.Windows.Forms.MenuItem
        Me.MnuItmTerKeyProds = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.mnuFileMaintenane, Me.mnu_Reports, Me.MenuItem70, Me.MenuItem5})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnu_ProcessMdiData, Me.mnu_ProcessSubDistributorData, Me.mnu_ProcessInHouseData, Me.MenuItem4, Me.Mnu_ProcessMercuryData, Me.mnu_ProcessCallRate, Me.mnu_ControlTotals, Me.MenuItem45, Me.MenuItem50, Me.MenuItem55, Me.MenuItem56, Me.MenuItem57, Me.MenuItem58, Me.MenuItem59, Me.MenuItem60, Me.mnuExit})
        Me.MenuItem1.Text = "&Transactions"
        '
        'mnu_ProcessMdiData
        '
        Me.mnu_ProcessMdiData.Index = 0
        Me.mnu_ProcessMdiData.Text = "Process MDI Data"
        '
        'mnu_ProcessSubDistributorData
        '
        Me.mnu_ProcessSubDistributorData.Index = 1
        Me.mnu_ProcessSubDistributorData.Text = "Process Sub-Distributor Data"
        '
        'mnu_ProcessInHouseData
        '
        Me.mnu_ProcessInHouseData.Index = 2
        Me.mnu_ProcessInHouseData.Text = "Process InHouse Data"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 3
        Me.MenuItem4.Text = "Process Proscar Data"
        '
        'Mnu_ProcessMercuryData
        '
        Me.Mnu_ProcessMercuryData.Index = 4
        Me.Mnu_ProcessMercuryData.Text = "Process Mercury Data"
        '
        'mnu_ProcessCallRate
        '
        Me.mnu_ProcessCallRate.Index = 5
        Me.mnu_ProcessCallRate.Text = "Process Call Rate"
        '
        'mnu_ControlTotals
        '
        Me.mnu_ControlTotals.Index = 6
        Me.mnu_ControlTotals.Text = "Control Totals"
        '
        'MenuItem45
        '
        Me.MenuItem45.Index = 7
        Me.MenuItem45.Text = "Store Commission Computations"
        '
        'MenuItem50
        '
        Me.MenuItem50.Index = 8
        Me.MenuItem50.Text = "Compute Calenderized Performance"
        '
        'MenuItem55
        '
        Me.MenuItem55.Index = 9
        Me.MenuItem55.Text = "-"
        '
        'MenuItem56
        '
        Me.MenuItem56.Index = 10
        Me.MenuItem56.Text = "Populate Stock Transfer Reports(Peso)"
        '
        'MenuItem57
        '
        Me.MenuItem57.Index = 11
        Me.MenuItem57.Text = "Populate Stock Transfer Reports(Qty)"
        '
        'MenuItem58
        '
        Me.MenuItem58.Index = 12
        Me.MenuItem58.Text = "Populate Direct Reports(Peso)"
        '
        'MenuItem59
        '
        Me.MenuItem59.Index = 13
        Me.MenuItem59.Text = "Populate Direct Reports(Qty)"
        '
        'MenuItem60
        '
        Me.MenuItem60.Index = 14
        Me.MenuItem60.Text = "-"
        '
        'mnuExit
        '
        Me.mnuExit.Index = 15
        Me.mnuExit.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.mnuExit.Text = "E&xit"
        '
        'mnuFileMaintenane
        '
        Me.mnuFileMaintenane.Index = 1
        Me.mnuFileMaintenane.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuEditIntegratedSales, Me.MenuItem104, Me.mnuMedRepBudget, Me.MenuItem11, Me.MenuItem44, Me.MenuItem98, Me.ExtCustZue, Me.MenuItem102})
        Me.mnuFileMaintenane.Text = "File Maintenance"
        '
        'mnuEditIntegratedSales
        '
        Me.mnuEditIntegratedSales.Index = 0
        Me.mnuEditIntegratedSales.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.mnuEditIntegratedSales.Text = "Edit Crediting of Personal Sales"
        '
        'MenuItem104
        '
        Me.MenuItem104.Index = 1
        Me.MenuItem104.Text = "Edit Crediting of Mercury Stock Transfer"
        '
        'mnuMedRepBudget
        '
        Me.mnuMedRepBudget.Index = 2
        Me.mnuMedRepBudget.Text = "Medical Representative Budget List"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 3
        Me.MenuItem11.Text = "Customer"
        '
        'MenuItem44
        '
        Me.MenuItem44.Index = 4
        Me.MenuItem44.Text = "Mercury Direct Budget"
        '
        'MenuItem98
        '
        Me.MenuItem98.Index = 5
        Me.MenuItem98.Text = "Excluded Customers"
        '
        'ExtCustZue
        '
        Me.ExtCustZue.Index = 6
        Me.ExtCustZue.Text = "Excluded Customers of Zuelig"
        '
        'MenuItem102
        '
        Me.MenuItem102.Index = 7
        Me.MenuItem102.Text = "Item Budget Direct List"
        '
        'mnu_Reports
        '
        Me.mnu_Reports.Index = 2
        Me.mnu_Reports.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnu_DistributeReports, Me.MenuItem17, Me.MenuItem18, Me.MenuItem16, Me.MenuItem19, Me.MenuItem7, Me.MenuItem46, Me.MenuItem47, Me.MenuItem52, Me.MenuItem48, Me.MenuItem49, Me.MenuItem51, Me.MenuItem53, Me.MenuItem54, Me.MenuItem62, Me.MenuItem63, Me.MenuItem91})
        Me.mnu_Reports.Text = "Reports"
        '
        'mnu_DistributeReports
        '
        Me.mnu_DistributeReports.Index = 0
        Me.mnu_DistributeReports.Text = "Distribute Sales and Commission Reports"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 1
        Me.MenuItem17.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnu_MdiPerMedrep, Me.mnu_MercurySales, Me.mnu_MdiPerMedrepUntagged, Me.Mnu_CommissionAttachment, Me.Mnu_MedrepCommission, Me.Mnu_MedrepCommissionWithRecovery, Me.MenuItem103})
        Me.MenuItem17.Text = "Professional Medical Representative"
        '
        'mnu_MdiPerMedrep
        '
        Me.mnu_MdiPerMedrep.Index = 0
        Me.mnu_MdiPerMedrep.Text = "Sales per Medical Representative"
        '
        'mnu_MercurySales
        '
        Me.mnu_MercurySales.Index = 1
        Me.mnu_MercurySales.Text = "Mercury Sales Per Medical Representative"
        '
        'mnu_MdiPerMedrepUntagged
        '
        Me.mnu_MdiPerMedrepUntagged.Index = 2
        Me.mnu_MdiPerMedrepUntagged.Text = "Sales per Medical Representative(Untagged)"
        '
        'Mnu_CommissionAttachment
        '
        Me.Mnu_CommissionAttachment.Index = 3
        Me.Mnu_CommissionAttachment.Text = "Commission Report Attachment"
        '
        'Mnu_MedrepCommission
        '
        Me.Mnu_MedrepCommission.Index = 4
        Me.Mnu_MedrepCommission.Text = "Medrep Commission"
        '
        'Mnu_MedrepCommissionWithRecovery
        '
        Me.Mnu_MedrepCommissionWithRecovery.Index = 5
        Me.Mnu_MedrepCommissionWithRecovery.Text = "Medrep Commission with Recovery 2006-2007"
        '
        'MenuItem103
        '
        Me.MenuItem103.Index = 6
        Me.MenuItem103.Text = "MedRep Commision with Recovery 2008"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 2
        Me.MenuItem18.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Mnu_CommissionAttachmentDM, Me.Mnu_SupervisorCommission, Me.Mnu_DistrictManagerCommissionWithRecovery, Me.Mnu_DistrictManagerCommissionWithRecovery2008})
        Me.MenuItem18.Text = "District Sales Manager"
        '
        'Mnu_CommissionAttachmentDM
        '
        Me.Mnu_CommissionAttachmentDM.Index = 0
        Me.Mnu_CommissionAttachmentDM.Text = "Commission Report Attachment (DSM)"
        '
        'Mnu_SupervisorCommission
        '
        Me.Mnu_SupervisorCommission.Index = 1
        Me.Mnu_SupervisorCommission.Text = "District Manager Commission"
        '
        'Mnu_DistrictManagerCommissionWithRecovery
        '
        Me.Mnu_DistrictManagerCommissionWithRecovery.Index = 2
        Me.Mnu_DistrictManagerCommissionWithRecovery.Text = "District Manager Commission with Recovery 2006-2007"
        '
        'Mnu_DistrictManagerCommissionWithRecovery2008
        '
        Me.Mnu_DistrictManagerCommissionWithRecovery2008.Index = 3
        Me.Mnu_DistrictManagerCommissionWithRecovery2008.Text = "District Manager Commission with Recovery 2008"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 3
        Me.MenuItem16.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Mnu_QpiPerTerritory, Me.Mnu_QpiMercurySales, Me.MenuItem66})
        Me.MenuItem16.Text = "Qpi Reports"
        '
        'Mnu_QpiPerTerritory
        '
        Me.Mnu_QpiPerTerritory.Index = 0
        Me.Mnu_QpiPerTerritory.Text = "Qpi Sales Per Territory"
        '
        'Mnu_QpiMercurySales
        '
        Me.Mnu_QpiMercurySales.Index = 1
        Me.Mnu_QpiMercurySales.Text = "Qpi Mercury Sales"
        '
        'MenuItem66
        '
        Me.MenuItem66.Index = 2
        Me.MenuItem66.Text = "Qpi Sales Summary"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 4
        Me.MenuItem19.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Mnu_HiiPerTerritory, Me.Mnu_HiiMercurySales})
        Me.MenuItem19.Text = "Hii Reports"
        '
        'Mnu_HiiPerTerritory
        '
        Me.Mnu_HiiPerTerritory.Index = 0
        Me.Mnu_HiiPerTerritory.Text = "Hii Sales Per Territory"
        '
        'Mnu_HiiMercurySales
        '
        Me.Mnu_HiiMercurySales.Index = 1
        Me.Mnu_HiiMercurySales.Text = "Hii Mercury Sales"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 5
        Me.MenuItem7.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem8, Me.MenuItem9})
        Me.MenuItem7.Text = "Performance Reports"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 0
        Me.MenuItem8.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem10, Me.MenuItem20, Me.MenuItem23})
        Me.MenuItem8.Text = "Based on Mercury Stock Transfer"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 0
        Me.MenuItem10.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem21, Me.MenuItem22, Me.MenuItem24, Me.MenuItem25, Me.MenuItem26})
        Me.MenuItem10.Text = "National Sales Manager"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 0
        Me.MenuItem21.Text = "Original Sales"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 1
        Me.MenuItem22.Text = "Adjusted Sales"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 2
        Me.MenuItem24.Text = "-"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 3
        Me.MenuItem25.Text = "Original Qty"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 4
        Me.MenuItem26.Text = "Adjusted Qty"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 1
        Me.MenuItem20.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem27, Me.MenuItem28, Me.MenuItem29, Me.MenuItem30, Me.MenuItem31})
        Me.MenuItem20.Text = "District Sales Manager"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 0
        Me.MenuItem27.Text = "Original Sales"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 1
        Me.MenuItem28.Text = "Adjusted Sales"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 2
        Me.MenuItem29.Text = "-"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 3
        Me.MenuItem30.Text = "Original Qty"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 4
        Me.MenuItem31.Text = "Adjusted Qty"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 2
        Me.MenuItem23.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem32, Me.MenuItem33, Me.MenuItem34, Me.MenuItem35, Me.MenuItem36})
        Me.MenuItem23.Text = "Professional Medical Rep"
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 0
        Me.MenuItem32.Text = "Original Sales"
        '
        'MenuItem33
        '
        Me.MenuItem33.Index = 1
        Me.MenuItem33.Text = "Adjusted Sales"
        '
        'MenuItem34
        '
        Me.MenuItem34.Index = 2
        Me.MenuItem34.Text = "-"
        '
        'MenuItem35
        '
        Me.MenuItem35.Index = 3
        Me.MenuItem35.Text = "Original Qty"
        '
        'MenuItem36
        '
        Me.MenuItem36.Index = 4
        Me.MenuItem36.Text = "Adjusted Qty"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 1
        Me.MenuItem9.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem37, Me.MenuItem38, Me.MenuItem39, Me.MenuItem40, Me.MenuItem41})
        Me.MenuItem9.Text = "Based on Mercury Direct"
        '
        'MenuItem37
        '
        Me.MenuItem37.Index = 0
        Me.MenuItem37.Text = "Original Sales"
        '
        'MenuItem38
        '
        Me.MenuItem38.Index = 1
        Me.MenuItem38.Text = "Adjusted Sales"
        '
        'MenuItem39
        '
        Me.MenuItem39.Index = 2
        Me.MenuItem39.Text = "-"
        '
        'MenuItem40
        '
        Me.MenuItem40.Index = 3
        Me.MenuItem40.Text = "Original Qty"
        '
        'MenuItem41
        '
        Me.MenuItem41.Index = 4
        Me.MenuItem41.Text = "Adjusted Qty"
        '
        'MenuItem46
        '
        Me.MenuItem46.Index = 6
        Me.MenuItem46.Text = "Ct Sales"
        Me.MenuItem46.Visible = False
        '
        'MenuItem47
        '
        Me.MenuItem47.Index = 7
        Me.MenuItem47.Text = "Ct Sales Ytd"
        Me.MenuItem47.Visible = False
        '
        'MenuItem52
        '
        Me.MenuItem52.Index = 8
        Me.MenuItem52.Text = "-"
        '
        'MenuItem48
        '
        Me.MenuItem48.Index = 9
        Me.MenuItem48.Text = "Monthly Performance Report with Rank - PMR"
        '
        'MenuItem49
        '
        Me.MenuItem49.Index = 10
        Me.MenuItem49.Text = "Monthly Performance Report with Rank - DSM"
        '
        'MenuItem51
        '
        Me.MenuItem51.Index = 11
        Me.MenuItem51.Text = "-"
        '
        'MenuItem53
        '
        Me.MenuItem53.Index = 12
        Me.MenuItem53.Text = "Calenderized Performance Report with Rank - PMR"
        '
        'MenuItem54
        '
        Me.MenuItem54.Index = 13
        Me.MenuItem54.Text = "Calenderized Performance Report with Rank - DSM"
        '
        'MenuItem62
        '
        Me.MenuItem62.Index = 14
        Me.MenuItem62.Text = "-"
        '
        'MenuItem63
        '
        Me.MenuItem63.Index = 15
        Me.MenuItem63.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem64, Me.MenuItem85, Me.MenuItem89})
        Me.MenuItem63.Text = "Calenderized Call Rate Report"
        '
        'MenuItem64
        '
        Me.MenuItem64.Index = 0
        Me.MenuItem64.Text = "National Sales Manager"
        '
        'MenuItem85
        '
        Me.MenuItem85.Index = 1
        Me.MenuItem85.Text = "District Sales Manager"
        '
        'MenuItem89
        '
        Me.MenuItem89.Index = 2
        Me.MenuItem89.Text = "Professional Medical Representative"
        '
        'MenuItem91
        '
        Me.MenuItem91.Index = 16
        Me.MenuItem91.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem92, Me.MenuItem93, Me.MenuItem94})
        Me.MenuItem91.Text = "Monthly Call Rate Report"
        '
        'MenuItem92
        '
        Me.MenuItem92.Index = 0
        Me.MenuItem92.Text = "National Sales Manager"
        '
        'MenuItem93
        '
        Me.MenuItem93.Index = 1
        Me.MenuItem93.Text = "District Sales Manager"
        '
        'MenuItem94
        '
        Me.MenuItem94.Index = 2
        Me.MenuItem94.Text = "Professional Medical Representative"
        '
        'MenuItem70
        '
        Me.MenuItem70.Index = 3
        Me.MenuItem70.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem95, Me.MenuItem12, Me.MenuItem96, Me.MenuItem71, Me.MenuItem72, Me.MenuItem15, Me.MenuItem73, Me.MenuItem74, Me.MenuItem75, Me.MenuItem101, Me.MenuItem76, Me.MenuItem77, Me.MenuItem43, Me.MenuItem78, Me.MenuItem97, Me.MenuItem79, Me.MenuItem80, Me.MenuItem81, Me.MenuItem82, Me.MenuItem83, Me.MenuItem84, Me.MenuItem86, Me.MenuItem87, Me.MenuItem88, Me.MenuItem90, Me.MenuItem61, Me.mnuUserMaint, Me.MnuKeyProds})
        Me.MenuItem70.Text = "Code Tables"
        '
        'MenuItem95
        '
        Me.MenuItem95.Index = 0
        Me.MenuItem95.Text = "Budget Out of Stock"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 1
        Me.MenuItem12.Text = "Call Rate Budget"
        '
        'MenuItem96
        '
        Me.MenuItem96.Index = 2
        Me.MenuItem96.Text = "Call Rate Transactions"
        '
        'MenuItem71
        '
        Me.MenuItem71.Index = 3
        Me.MenuItem71.Text = "Customer Type"
        '
        'MenuItem72
        '
        Me.MenuItem72.Index = 4
        Me.MenuItem72.Text = "Division"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 5
        Me.MenuItem15.Text = "DSM-PMR Assignment"
        '
        'MenuItem73
        '
        Me.MenuItem73.Index = 6
        Me.MenuItem73.Text = "Group"
        '
        'MenuItem74
        '
        Me.MenuItem74.Index = 7
        Me.MenuItem74.Text = "Item"
        '
        'MenuItem75
        '
        Me.MenuItem75.Index = 8
        Me.MenuItem75.Text = "MedRep"
        '
        'MenuItem101
        '
        Me.MenuItem101.Index = 9
        Me.MenuItem101.Text = "MR Territory Assignment"
        '
        'MenuItem76
        '
        Me.MenuItem76.Index = 10
        Me.MenuItem76.Text = "Mercury Branch"
        '
        'MenuItem77
        '
        Me.MenuItem77.Index = 11
        Me.MenuItem77.Text = "Mercury Item"
        '
        'MenuItem43
        '
        Me.MenuItem43.Index = 12
        Me.MenuItem43.Text = "National Sales Manager"
        '
        'MenuItem78
        '
        Me.MenuItem78.Index = 13
        Me.MenuItem78.Text = "Principal"
        '
        'MenuItem97
        '
        Me.MenuItem97.Index = 14
        Me.MenuItem97.Text = "Product Manager"
        '
        'MenuItem79
        '
        Me.MenuItem79.Index = 15
        Me.MenuItem79.Text = "Province"
        '
        'MenuItem80
        '
        Me.MenuItem80.Index = 16
        Me.MenuItem80.Text = "Supervisor"
        '
        'MenuItem81
        '
        Me.MenuItem81.Index = 17
        Me.MenuItem81.Text = "Territory"
        '
        'MenuItem82
        '
        Me.MenuItem82.Index = 18
        Me.MenuItem82.Text = "-"
        '
        'MenuItem83
        '
        Me.MenuItem83.Index = 19
        Me.MenuItem83.Text = "Cut Off"
        Me.MenuItem83.Visible = False
        '
        'MenuItem84
        '
        Me.MenuItem84.Index = 20
        Me.MenuItem84.Text = "Exclude Customer List"
        Me.MenuItem84.Visible = False
        '
        'MenuItem86
        '
        Me.MenuItem86.Index = 21
        Me.MenuItem86.Text = "Metro Drug Item"
        Me.MenuItem86.Visible = False
        '
        'MenuItem87
        '
        Me.MenuItem87.Index = 22
        Me.MenuItem87.Text = "Product Lines"
        '
        'MenuItem88
        '
        Me.MenuItem88.Index = 23
        Me.MenuItem88.Text = "Supervisor Email Configuration"
        Me.MenuItem88.Visible = False
        '
        'MenuItem90
        '
        Me.MenuItem90.Index = 24
        Me.MenuItem90.Text = "Team Division"
        '
        'MenuItem61
        '
        Me.MenuItem61.Index = 25
        Me.MenuItem61.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem100, Me.MenuItem99, Me.MenuItem65, Me.MenuItem42, Me.MenuItem69, Me.MenuItem67, Me.MenuItem68})
        Me.MenuItem61.Text = "Qpi Maintenance"
        '
        'MenuItem100
        '
        Me.MenuItem100.Index = 0
        Me.MenuItem100.Text = "Qpi Area Assignment"
        '
        'MenuItem99
        '
        Me.MenuItem99.Index = 1
        Me.MenuItem99.Text = "Qpi Area Code"
        '
        'MenuItem65
        '
        Me.MenuItem65.Index = 2
        Me.MenuItem65.Text = "Qpi Territory"
        '
        'MenuItem42
        '
        Me.MenuItem42.Index = 3
        Me.MenuItem42.Text = "Qpi Territory Budget"
        '
        'MenuItem69
        '
        Me.MenuItem69.Index = 4
        Me.MenuItem69.Text = "-"
        '
        'MenuItem67
        '
        Me.MenuItem67.Index = 5
        Me.MenuItem67.Text = "Insert Territory Assignment"
        '
        'MenuItem68
        '
        Me.MenuItem68.Index = 6
        Me.MenuItem68.Text = "Modify Territory Assignment"
        '
        'mnuUserMaint
        '
        Me.mnuUserMaint.Index = 26
        Me.mnuUserMaint.Text = "User Maintenance"
        '
        'MnuKeyProds
        '
        Me.MnuKeyProds.Index = 27
        Me.MnuKeyProds.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuItmPriKeyProds, Me.MnuItmSecKeyProds, Me.MnuItmTerKeyProds})
        Me.MnuKeyProds.Text = "Key Products"
        '
        'MnuItmPriKeyProds
        '
        Me.MnuItmPriKeyProds.Index = 0
        Me.MnuItmPriKeyProds.Text = "Primary Key Products"
        '
        'MnuItmSecKeyProds
        '
        Me.MnuItmSecKeyProds.Index = 1
        Me.MnuItmSecKeyProds.Text = "Secondary Key Products"
        '
        'MnuItmTerKeyProds
        '
        Me.MnuItmTerKeyProds.Index = 2
        Me.MnuItmTerKeyProds.Text = "Tertiary Key Products"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 4
        Me.MenuItem5.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem3, Me.MenuItem6})
        Me.MenuItem5.Text = "&Window"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "Tile Horizontally"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.Text = "Tile Vertically"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 2
        Me.MenuItem6.Text = "Cascade"
        '
        'Main
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(968, 9)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu1
        Me.Name = "Main"
        Me.Text = "Scores DotNet {F6346BB6-55A3-4c44-80BE-3E19F8DD9BC4}"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized

    End Sub

#End Region

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Application.Exit()
    End Sub
    Private Sub mnu_MdiPerMedrep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_MdiPerMedrep.Click
        'Get the respective Teritories per Medrep
        Dim myConnection As New SqlConnection
        Dim myCommand As New SqlCommand
        Try
            With myConnection
                .ConnectionString = ServerPath
                .Open()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Dim myDialogbox As New frmDialogBox
        myDialogbox.ShowDialog(Me)
        Try
            With myCommand
                .CommandText = "GetTerritoriesPerMedrep"
                .CommandType = CommandType.StoredProcedure
                .Connection = myConnection
                .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = myDialogbox.CommissionDate
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        myConnection.Dispose()

        Dim myLoadedForm As New frmReportViewer
        myLoadedForm.MdiParent = Me
        myLoadedForm.Report = "Mdi Sales Per Medrep"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        myLoadedForm.Show()
    End Sub
    Private Sub mnu_MdiPerMedrepUntagged_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_MdiPerMedrepUntagged.Click
        'Get the respective Teritories per Medrep
        Dim myConnection As New SqlConnection
        Dim myCommand As New SqlCommand
        Try
            With myConnection
                .ConnectionString = ServerPath
                .Open()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Dim myDialogbox As New frmDialogBox
        myDialogbox.ShowDialog(Me)
        Try
            With myCommand
                .CommandText = "GetTerritoriesPerMedrep"
                .CommandType = CommandType.StoredProcedure
                .Connection = myConnection
                .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = myDialogbox.CommissionDate
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        myConnection.Dispose()

        Dim myLoadedForm As New frmReportViewer
        myLoadedForm.MdiParent = Me
        myLoadedForm.Report = "Mdi Sales Per Medrep Untagged"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        myLoadedForm.Show()
    End Sub
    Private Sub Mnu_CommissionAttachment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_CommissionAttachment.Click
        Dim myConnection As New SqlConnection
        Dim myCommand As New SqlCommand
        Try
            With myConnection
                .ConnectionString = ServerPath2
                .Open()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Dim myDialogbox As New frmDialogBox
        myDialogbox.ShowDialog(Me)
        Try
            With myCommand
                .CommandText = "COMMISSION_ComputeAttachment"
                .CommandType = CommandType.StoredProcedure
                .Connection = myConnection
                .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = myDialogbox.CommissionDate
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        myConnection.Dispose()

        Dim myLoadedForm As New frmReportViewer
        myLoadedForm.MdiParent = Me
        myLoadedForm.Report = "Commission Report Attachment"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        myLoadedForm.Show()
    End Sub
    Private Sub Mnu_MedrepCommission_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_MedrepCommission.Click
        Dim myConnection As New SqlConnection
        Dim myCommand As New SqlCommand
        Dim myCommand1 As New SqlCommand
        Dim myCommand2 As New SqlCommand
        Dim CommandText As String
        Try
            With myConnection
                .ConnectionString = ServerPath2
                .Open()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Dim myDialogbox As New frmDialogBox
        myDialogbox.ShowDialog(Me)
        Try
            With myCommand
                .CommandText = "COMMISSION_ComputeAttachment"
                .CommandType = CommandType.StoredProcedure
                .Connection = myConnection
                .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = myDialogbox.CommissionDate
                .ExecuteNonQuery()
            End With
            Select Case Year(CDate(myDialogbox.CommissionDate))
                Case 2004
                    CommandText = "COMMISSION_ComputeMedrepCommission"
                Case 2005
                    CommandText = ("COMMISSION_ComputeMedrepCommission_2005")
            End Select
            With myCommand1
                .CommandText = CommandText
                .CommandType = CommandType.StoredProcedure
                .Connection = myConnection
                .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = myDialogbox.CommissionDate
                .ExecuteNonQuery()
            End With
            'If CDate(myDialogbox.CommissionDate) > #4/1/2005# Then
            '    With myCommand2
            '        .CommandText = "Compute_ComInc"
            '        .CommandType = CommandType.StoredProcedure
            '        .Connection = myConnection
            '        .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = myDialogbox.CommissionDate
            '        .ExecuteNonQuery()
            '    End With
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        myConnection.Dispose()

        Dim myLoadedForm As New frmReportViewer
        myLoadedForm.MdiParent = Me
        myLoadedForm.Report = "Medrep Commission"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        myLoadedForm.Show()
    End Sub
    Private Sub Mnu_SupervisorCommission_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_SupervisorCommission.Click
        Dim myConnection As New SqlConnection
        Dim myCommand As New SqlCommand
        Dim myCommand1 As New SqlCommand
        Dim myCommand2 As New SqlCommand
        Dim myCommand3 As New SqlCommand
        Dim myCommand4 As New SqlCommand
        Dim CommandText As String
        Dim CommandText2 As String
        Try
            With myConnection
                .ConnectionString = ServerPath2
                .Open()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Dim myDialogbox As New frmDialogBox
        myDialogbox.ShowDialog(Me)
        Try
            With myCommand
                .CommandText = "COMMISSION_ComputeAttachment"
                .CommandType = CommandType.StoredProcedure
                .Connection = myConnection
                .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = myDialogbox.CommissionDate
                .ExecuteNonQuery()
            End With
            Select Case Year(CDate(myDialogbox.CommissionDate))
                Case 2004
                    CommandText = "COMMISSION_ComputeMedrepCommission"
                    CommandText2 = "COMMISSION_ComputeSupervisorCommission"
                Case 2005
                    CommandText = "COMMISSION_ComputeMedrepCommission_2005"
                    CommandText2 = ("COMMISSION_ComputeSupervisorCommission_2005")
            End Select
            With myCommand1
                .CommandText = CommandText
                .CommandType = CommandType.StoredProcedure
                .Connection = myConnection
                .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = myDialogbox.CommissionDate
                .ExecuteNonQuery()
            End With
            With myCommand2
                .CommandText = CommandText2
                .CommandType = CommandType.StoredProcedure
                .Connection = myConnection
                .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = myDialogbox.CommissionDate
                .ExecuteNonQuery()
            End With
            With myCommand3
                .CommandText = "COMMISSION_ComputeSupervisorCommissionDetails"
                .CommandType = CommandType.StoredProcedure
                .Connection = myConnection
                .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = myDialogbox.CommissionDate
                .ExecuteNonQuery()
            End With
            If CDate(myDialogbox.CommissionDate) > #1/1/2005# Then
                With myCommand4
                    .CommandText = "COMMISSION_ComputeIncentive"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = myConnection
                    .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = myDialogbox.CommissionDate
                    .ExecuteNonQuery()
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        myConnection.Dispose()

        Dim myLoadedForm As New frmReportViewer
        myLoadedForm.MdiParent = Me
        myLoadedForm.Report = "Supervisor Commission"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        myLoadedForm.Show()
    End Sub
    Private Sub mnu_MercurySales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_MercurySales.Click
        Dim myConnection As New SqlConnection
        Dim myCommand As New SqlCommand
        Try
            With myConnection
                .ConnectionString = ServerPath
                .Open()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Dim myDialogbox As New frmDialogBox
        myDialogbox.ShowDialog(Me)
        Try
            With myCommand
                .CommandText = "Transfer_MercurySalesIntoTemporary"
                .CommandType = CommandType.StoredProcedure
                .Connection = myConnection
                .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = myDialogbox.CommissionDate
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        myConnection.Dispose()

        Dim myLoadedForm As New frmReportViewer
        myLoadedForm.MdiParent = Me
        myLoadedForm.Report = "Mercury Sales"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        myLoadedForm.Show()
    End Sub

    Private Sub mnuEditIntegratedSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditIntegratedSales.Click
        Dim myLoadedForm As New EditIntegratedSales     'EditIntegratedSalesMercury
        myLoadedForm.MdiParent = Me
        myLoadedForm.Show()
    End Sub

   

    Private Sub mnu_QpiPerMedrep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim myDialogbox As New frmDialogBox
        myDialogbox.ShowDialog(Me)

        Dim myLoadedForm As New frmReportViewer
        myLoadedForm.MdiParent = Me
        myLoadedForm.Report = "Qpi Sales Per Medrep"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        myLoadedForm.Show()
    End Sub

    Private Sub mnu_QpiPerTerritory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_QpiPerTerritory.Click
        Dim myDialogbox As New frmDialogBox
        myDialogbox.ShowDialog(Me)

        Dim myLoadedForm As New frmReportViewer
        myLoadedForm.MdiParent = Me
        myLoadedForm.Report = "Qpi Sales Per Territory"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        myLoadedForm.Show()
    End Sub
    Private Sub mnu_ControlTotals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_ControlTotals.Click
        Try
            Dim myDialogbox As New frmDialogBox
            myDialogbox.ShowDialog(Me)

            Dim myLoadedForm As New frmReportViewer
            myLoadedForm.MdiParent = Me
            myLoadedForm.Report = "Control Totals"
            myLoadedForm.CommissionDate = myDialogbox.CommissionDate
            myLoadedForm.Show()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub
    Private Sub Mnu_CommissionAttachmentDM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_CommissionAttachmentDM.Click
        Dim myConnection As New SqlConnection
        Dim myCommand As New SqlCommand
        Try
            With myConnection
                .ConnectionString = ServerPath2
                .Open()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Dim myDialogbox As New frmDialogBox
        myDialogbox.ShowDialog(Me)
        Try
            With myCommand
                .CommandText = "COMMISSION_ComputeAttachment"
                .CommandType = CommandType.StoredProcedure
                .Connection = myConnection
                .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = myDialogbox.CommissionDate
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        myConnection.Dispose()

        Dim myLoadedForm As New frmReportViewer
        myLoadedForm.MdiParent = Me
        myLoadedForm.Report = "Commission Report Attachment(DM)"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        myLoadedForm.Show()
    End Sub
    Private Sub mnuMedRepBudget_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMedRepBudget.Click
        Dim myLoadedForm As New frmBudgetPmr
        myLoadedForm.MdiParent = Me
        myLoadedForm.Show()
    End Sub
    Private Sub mnu_DistributeReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_DistributeReports.Click
        Dim myLoadedForm As New frmDistributeReports
        myLoadedForm.MdiParent = Me
        myLoadedForm.Show()
    End Sub
    Private Sub mnu_ProcessMdiData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_ProcessMdiData.Click
        Dim myLoadedForm As New frmProcessMdiData
        myLoadedForm.MdiParent = Me
        myLoadedForm.Show()
    End Sub
    Private Sub Mnu_ProcessMercuryData_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Mnu_ProcessMercuryData.Click
        Dim myLoadedForm As New frmProcessMercuryData
        myLoadedForm.MdiParent = Me
        myLoadedForm.Show()
    End Sub
    Private Sub mnu_ProcessSubDistributorData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_ProcessSubDistributorData.Click
        Dim myLoadedForm As New frmProcessSubDistributorData
        myLoadedForm.MdiParent = Me
        myLoadedForm.Show()
    End Sub
    Private Sub mnu_ProcessInHouseData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_ProcessInHouseData.Click
        Dim myLoadedForm As New frmProcessInHouseData
        myLoadedForm.MdiParent = Me
        myLoadedForm.Show()
    End Sub

    Private Sub MnuItmPriKeyProds_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuItmPriKeyProds.Click
        Dim myLoadedForm As New frmKeyProducts
        myLoadedForm.MdiParent = Me
        myLoadedForm.Show()
    End Sub
    Private Sub MnuItmSecKeyProds_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuItmSecKeyProds.Click
        Dim myLoadedForm As New frmSubKeyProduct
        myLoadedForm.MdiParent = Me
        myLoadedForm.Show()
    End Sub
    Private Sub MnuItmTerKeyProds_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuItmTerKeyProds.Click
        Dim myLoadedForm As New frmTerKeyProduct
        myLoadedForm.MdiParent = Me
        myLoadedForm.Show()
    End Sub
    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        Dim myLoadedForm As New frmSupMr
        myLoadedForm.MdiParent = Me
        myLoadedForm.Show()
    End Sub
    Private Sub Mnu_MedrepCommissionWithRecovery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_MedrepCommissionWithRecovery.Click
        Dim myDialogBox As New frmDialogBox
        Dim myCommissionDate As String
        myDialogBox.ShowDialog()
        myCommissionDate = myDialogBox.CommissionDate

        'Compute the Attachment
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComIncAttach", CommandType.StoredProcedure, 1)

        'Compute the ComInc
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComInc", CommandType.StoredProcedure, 1)

        Dim myReportViewer As New frmReportViewer
        myReportViewer.Report = "Medrep Commission with Recovery"
        myReportViewer.CommissionDate = myCommissionDate
        myReportViewer.MdiParent = Me
        myReportViewer.Show()
    End Sub
    Private Sub Mnu_DistrictManagerCommissionWithRecovery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_DistrictManagerCommissionWithRecovery.Click
        Dim myDialogBox As New frmDialogBox
        Dim myCommissionDate As String
        myDialogBox.ShowDialog()
        myCommissionDate = myDialogBox.CommissionDate

        'Compute the Attachment
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComIncAttach", CommandType.StoredProcedure, 1)

        'Compute the ComInc
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComInc", CommandType.StoredProcedure, 1)

        Dim myReportViewer As New frmReportViewer
        myReportViewer.Report = "DSM Commission with Recovery"
        myReportViewer.CommissionDate = myCommissionDate
        myReportViewer.MdiParent = Me
        myReportViewer.Show()
    End Sub
    Private Sub mnu_QpiMercurySales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_QpiMercurySales.Click
        Dim myConnection As New SqlConnection
        Dim myCommand As New SqlCommand
        Try
            With myConnection
                .ConnectionString = ServerPath
                .Open()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Dim myDialogbox As New frmDialogBox
        myDialogbox.ShowDialog(Me)
        Try
            With myCommand
                .CommandText = "Transfer_MercurySalesIntoTemporary"
                .CommandType = CommandType.StoredProcedure
                .Connection = myConnection
                .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = myDialogbox.CommissionDate
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        myConnection.Dispose()

        Dim myLoadedForm As New frmReportViewer
        myLoadedForm.MdiParent = Me
        myLoadedForm.Report = "Qpi Mercury Sales"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        myLoadedForm.Show()
    End Sub

    Private Sub Mnu_HiiPerTerritory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_HiiPerTerritory.Click
        Dim myDialogbox As New frmDialogBox
        myDialogbox.ShowDialog(Me)

        Dim myLoadedForm As New frmReportViewer
        myLoadedForm.MdiParent = Me
        myLoadedForm.Report = "Hii Sales Per Territory"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        myLoadedForm.Show()
    End Sub

    Private Sub mnu_ProcessCallRate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_ProcessCallRate.Click
        Dim myLoadedForm As New frmProcessCallRate
        myLoadedForm.MdiParent = Me
        myLoadedForm.Show()
    End Sub

    Private Sub Mnu_HiiMercurySales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_HiiMercurySales.Click
        Dim myConnection As New SqlConnection(ServerPath) : myConnection.Open()
        Dim myCommand As New SqlCommand("Transfer_MercurySalesIntoTemporary", myConnection)
        Dim myDialogbox As New frmDialogBox
        myDialogbox.ShowDialog(Me)
        With myCommand
            .CommandType = CommandType.StoredProcedure
            .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = myDialogbox.CommissionDate
            .ExecuteNonQuery()
        End With

        Dim CommandText As String = "SELECT * FROM Tempory_Mercury where itemcode in(Select itemcode from newscores..item where princode='0032')"
        Dim BusinessLayer As New BusinessLayer.clsFileMaintenance
        Dim RemoteDataSet As New dsMercurySales
        BusinessLayer.Sub_Show(ServerPath, CommandText, CommandType.Text, RemoteDataSet, "Tempory_Mercury")

        If RemoteDataSet.tempory_mercury.Rows.Count < 1 Then
            MessageBox.Show("No Data available", "HII Mercury Sales", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            Dim ReportViewer As New frmReportViewer
            Dim myReport As New Report_HiiMercurySales
            myReport.SetDataSource(RemoteDataSet.tempory_mercury)
            ReportViewer.ReportViewer.ReportSource = myReport
            ReportViewer.Show()
        End If
    End Sub

    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        Dim myReport As New Report_NSMOriginalSales_StockTransfer
        modDistributeReports.View_jpa_Performance_Reports(myReport, Me)
    End Sub

    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        Dim myReport As New Report_NSMAdjustedSales_StockTransfer
        modDistributeReports.View_jpa_Performance_Reports(myReport, Me)
    End Sub

    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        Dim myReport As New Report_NSMOriginalQty_StockTransfer
        modDistributeReports.View_jpa_Performance_ReportsQty(myReport, Me, "Show_SalesAndTargets_Transfer_Qty")
    End Sub
    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        Dim myReport As New Report_NSMAdjustedQty_StockTransfer
        modDistributeReports.View_jpa_Performance_ReportsQty(myReport, Me, "Show_SalesAndTargets_Transfer_Qty1")
    End Sub

    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        Dim myReport As New Report_DSMOriginalSales_StockTransfer
        modDistributeReports.View_jpa_Performance_Reports(myReport, Me)
    End Sub
    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        Dim myReport As New Report_DSMAdjustedSales_StockTransfer
        modDistributeReports.View_jpa_Performance_Reports(myReport, Me)
    End Sub

    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        Dim myReport As New Report_DSMOriginalQty_StockTransfer
        modDistributeReports.View_jpa_Performance_ReportsQty(myReport, Me, "Show_SalesAndTargets_Transfer_Qty")
    End Sub

    Private Sub MenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem31.Click
        Dim myReport As New Report_DSMAdjustedQty_StockTransfer
        modDistributeReports.View_jpa_Performance_ReportsQty(myReport, Me, "Show_SalesAndTargets_Transfer_Qty1")
    End Sub

    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        Dim myReport As New Report_OriginalSales_StockTransfer
        modDistributeReports.View_jpa_Performance_Reports(myReport, Me)
    End Sub

    Private Sub MenuItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem33.Click
        Dim myReport As New Report_AdjustedSales_StockTransfer
        modDistributeReports.View_jpa_Performance_Reports(myReport, Me)
    End Sub

    Private Sub MenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem35.Click
        Dim myReport As New Report_OriginalQty_StockTransfer
        modDistributeReports.View_jpa_Performance_ReportsQty(myReport, Me, "Show_SalesAndTargets_Transfer_Qty")
    End Sub

    Private Sub MenuItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem36.Click
        Dim myReport As New Report_AdjustedQty_StockTransfer
        modDistributeReports.View_jpa_Performance_ReportsQty(myReport, Me, "Show_SalesAndTargets_Transfer_Qty1")
    End Sub
    Private Sub MenuItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem37.Click
        Dim myReport As New Report_NSMOriginalSales_Direct
        modDistributeReports.View_jpa_Performance_Reports_Direct(myReport, Me)
    End Sub

    Private Sub MenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem38.Click
        Dim myReport As New Report_NSMAdjustedSales_Direct
        modDistributeReports.View_jpa_Performance_Reports_Direct(myReport, Me)
    End Sub

    Private Sub MenuItem40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem40.Click
        Dim myReport As New Report_NSMOriginalQty_Direct
        modDistributeReports.View_jpa_Performance_ReportsQtyDirect(myReport, Me, "Show_SalesAndTargets_Transfer_Qty")
    End Sub

    Private Sub MenuItem41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem41.Click
        Dim myReport As New Report_NSMAdjustedQty_Direct
        modDistributeReports.View_jpa_Performance_ReportsQtyDirect(myReport, Me, "Show_SalesAndTargets_Transfer_Qty1")
    End Sub
    Private Sub MenuItem44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem44.Click
        Dim myLoadedForm As New frmBudgetDirect
        myLoadedForm.MdiParent = Me
        myLoadedForm.Show()
    End Sub



    Private Sub MenuItem43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem43.Click
        Dim myLoadedForm As New NsmCT
        myLoadedForm.MdiParent = Me
        myLoadedForm.Show()
    End Sub

    Private Sub MenuItem45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem45.Click
        Me.Cursor = Cursors.WaitCursor
        Dim myDialogBox As New frmDialogBox
        myDialogBox.btnPreview.Text = "Store"
        myDialogBox.ShowDialog(Me)
        Dim BusinessLayer As New BusinessLayer.clsCommissionComputations
        Dim Params(0) As SqlParameter
        Dim CommissionDate As New SqlParameter("@CommissionDate", SqlDbType.DateTime, 10) : CommissionDate.Direction = ParameterDirection.Input : CommissionDate.Value = myDialogBox.CommissionDate : Params(0) = CommissionDate
        BusinessLayer.Store_CommissionTable(ServerPath2, "Store_CommissionTables", CommandType.StoredProcedure, Params)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub MenuItem46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem46.Click
        Me.Cursor = Cursors.WaitCursor
        Dim RemoteDataSet As New Nsm
        Dim mydialogbox As New frmDialogBox
        mydialogbox.btnPreview.Text = "Preview"
        mydialogbox.ShowDialog(Me)
        Dim BusinessLayer As New BusinessLayer.clsNsm
        Dim Params(0) As SqlParameter
        Dim CommissionDate As New SqlParameter("@CommissionDate", SqlDbType.DateTime, 10) : CommissionDate.Direction = ParameterDirection.Input : CommissionDate.Value = mydialogbox.CommissionDate : Params(0) = CommissionDate
        BusinessLayer.Nsm_Browse(ServerPath2, "CtSales_ShowCurrent", CommandType.StoredProcedure, _
        RemoteDataSet, "CtSales_Show", Params)
        Dim MyReportViewer As New frmReportViewer
        Dim MyReport As New Report_CtSales
        MyReport.SetDataSource(RemoteDataSet.CtSales_Show)
        MyReportViewer.ReportViewer.ReportSource = MyReport
        MyReportViewer.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub MenuItem47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem47.Click
        Me.Cursor = Cursors.WaitCursor
        Dim RemoteDataSet As New Nsm
        Dim mydialogbox As New frmDialogBox
        mydialogbox.btnPreview.Text = "Preview"
        mydialogbox.ShowDialog(Me)
        Dim BusinessLayer As New BusinessLayer.clsNsm
        Dim Params(0) As SqlParameter
        Dim CommissionDate As New SqlParameter("@CommissionDate", SqlDbType.DateTime, 10) : CommissionDate.Direction = ParameterDirection.Input : CommissionDate.Value = mydialogbox.CommissionDate : Params(0) = CommissionDate
        BusinessLayer.Nsm_Browse(ServerPath2, "CtSales_ShowYtd", CommandType.StoredProcedure, _
        RemoteDataSet, "CtSales_Show", Params)
        Dim MyReportViewer As New frmReportViewer
        Dim MyReport As New Report_CtSales
        MyReport.SetDataSource(RemoteDataSet.CtSales_Show)
        MyReportViewer.ReportViewer.ReportSource = MyReport
        MyReportViewer.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub MenuItem48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem48.Click
        Me.Cursor = Cursors.WaitCursor
        Dim RemoteDataSet As New Performance
        Dim mydialogbox As New frmDialogBox
        mydialogbox.btnPreview.Text = "Preview"
        mydialogbox.ShowDialog(Me)
        Dim BusinessLayer As New BusinessLayer.clsPerformance
        Dim Params(0) As SqlParameter
        Dim CommissionDate As New SqlParameter("@CommissionDate", SqlDbType.DateTime, 10) : CommissionDate.Direction = ParameterDirection.Input : CommissionDate.Value = mydialogbox.CommissionDate : Params(0) = CommissionDate
        BusinessLayer.Performance_Generic(ServerPath2, "Performance_Generic", CommandType.StoredProcedure, _
        RemoteDataSet, "Performance_Generic", Params)

        Dim MyReportViewer As New frmReportViewer
        Dim MyReport As New Rpt_PerformanceGeneric
        MyReport.SetDataSource(RemoteDataSet.Performance_Generic)
        MyReportViewer.ReportViewer.ReportSource = MyReport
        MyReportViewer.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub MenuItem49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem49.Click
        Me.Cursor = Cursors.WaitCursor
        Dim RemoteDataSet As New Performance
        Dim mydialogbox As New frmDialogBox
        mydialogbox.btnPreview.Text = "Preview"
        mydialogbox.ShowDialog(Me)
        Dim BusinessLayer As New BusinessLayer.clsPerformance
        Dim Params(0) As SqlParameter
        Dim CommissionDate As New SqlParameter("@CommissionDate", SqlDbType.DateTime, 10) : CommissionDate.Direction = ParameterDirection.Input : CommissionDate.Value = mydialogbox.CommissionDate : Params(0) = CommissionDate
        BusinessLayer.Performance_Generic(ServerPath2, "Performance_Generic", CommandType.StoredProcedure, _
        RemoteDataSet, "Performance_Generic", Params)

        Dim MyReportViewer As New frmReportViewer
        Dim MyReport As New Rpt_PerformanceGeneric_Spv
        MyReport.SetDataSource(RemoteDataSet.Performance_Generic)
        MyReportViewer.ReportViewer.ReportSource = MyReport
        MyReportViewer.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub MenuItem50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem50.Click

        Try
            Dim BusinessLayer As New BusinessLayer.clsPerformance
            Dim MyDateRangeBox As New DateRangeBox
            MyDateRangeBox.Button1.Text = "Compute"
            MyDateRangeBox.ShowDialog(Me)
            If MyDateRangeBox.DialogResult = DialogResult.OK Then
                Me.Cursor = Cursors.WaitCursor
                Dim Params(1) As SqlParameter
                Dim StartDate As New SqlParameter("@StartDate", SqlDbType.DateTime, 10) : StartDate.Direction = ParameterDirection.Input : StartDate.Value = MyDateRangeBox.StartDate : Params(0) = StartDate
                Dim EndDate As New SqlParameter("@EndDate", SqlDbType.DateTime, 10) : EndDate.Direction = ParameterDirection.Input : EndDate.Value = MyDateRangeBox.EndDate : Params(1) = EndDate
                BusinessLayer.Performance_Calenderized_Populate(ServerPath2, "Performance_Calenderized_Populate", CommandType.StoredProcedure, Params)
                MessageBox.Show("Command executed successfully!", "Calenderized Performance", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Me.Cursor = Cursors.Default
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub MenuItem53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem53.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim BusinessLayer As New BusinessLayer.clsPerformance
            Dim RemoteDataSet As New Performance
            BusinessLayer.Performance_Calenderized_Show(ServerPath2, "Performance_Calenderized_Select", CommandType.StoredProcedure, RemoteDataSet, "Performance_Calenderized")
            Dim MyReportViewer As New frmReportViewer
            Dim MyReport As New Rpt_CalenderizedPmrRank
            MyReport.SetDataSource(RemoteDataSet.Performance_Calenderized)
            MyReportViewer.ReportViewer.ReportSource = MyReport
            MyReportViewer.Show()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub MenuItem54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem54.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim BusinessLayer As New BusinessLayer.clsPerformance
            Dim RemoteDataSet As New Performance
            BusinessLayer.Performance_Calenderized_Show(ServerPath2, "Performance_Calenderized_Select", CommandType.StoredProcedure, RemoteDataSet, "Performance_Calenderized")
            Dim MyReportViewer As New frmReportViewer
            Dim MyReport As New Rpt_CalenderizedDsmRank
            MyReport.SetDataSource(RemoteDataSet.Performance_Calenderized)
            MyReportViewer.ReportViewer.ReportSource = MyReport
            MyReportViewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub PopulateData(ByVal strSender As String)
        Dim strProcedure As String
        Select Case strSender
            Case "Transfer Peso"
                strProcedure = "SalesAndTargets_Transfer_Peso_Populate"
            Case "Transfer Qty"
                strProcedure = "SalesAndTargets_Transfer_Qty_Populate"
            Case "Direct Peso"
                strProcedure = "SalesAndTargets_Direct_Peso_Populate"
            Case "Direct Qty"
                strProcedure = "SalesAndTargets_Direct_Qty_Populate"
        End Select
        Try
            Dim BusinessLayer As New BusinessLayer.clsPerformance
            Dim MyDateRangeBox As New DateRangeBox
            MyDateRangeBox.Button1.Text = "Compute"
            MyDateRangeBox.ShowDialog(Me)
            If MyDateRangeBox.DialogResult = DialogResult.OK Then
                Me.Cursor = Cursors.WaitCursor
                Dim Params(2) As SqlParameter
                Dim StartDate As New SqlParameter("@StartDate", SqlDbType.DateTime, 10) : StartDate.Direction = ParameterDirection.Input : StartDate.Value = MyDateRangeBox.StartDate : Params(0) = StartDate
                Dim EndDate As New SqlParameter("@EndDate", SqlDbType.DateTime, 10) : EndDate.Direction = ParameterDirection.Input : EndDate.Value = MyDateRangeBox.EndDate : Params(1) = EndDate
                Dim StoredProc As New SqlParameter("@StoredProc", SqlDbType.NVarChar, 500) : StoredProc.Direction = ParameterDirection.Input : StoredProc.Value = strProcedure : Params(2) = StoredProc
                BusinessLayer.Performance_Calenderized_Populate(ServerPath2, "Populate_JPA_Reports", CommandType.StoredProcedure, Params)
                MessageBox.Show("Command executed successfully!", "Populate Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub MenuItem56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem56.Click
        PopulateData("Transfer Peso")
    End Sub
    Private Sub MenuItem57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem57.Click
        PopulateData("Transfer Qty")
    End Sub
    Private Sub MenuItem58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem58.Click
        PopulateData("Direct Peso")
    End Sub
    Private Sub MenuItem59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem59.Click
        PopulateData("Direct Qty")
    End Sub
    Private Sub MenuItem65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem65.Click
        Dim MyLoadedForm As New frmQpiTerritory
        MyLoadedForm.MdiParent = Me
        MyLoadedForm.Show()
    End Sub
    Private Sub MenuItem66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem66.Click
        Dim MyLoadedForm As New frmReportViewer
        Dim MyReport As New Report_QpiSalesSummary
        Dim RemoteDataSet As New dsQpi_SalesSummary
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter
        Dim MyDialogBox As New frmDialogBox
        Try
            MyDialogBox.ShowDialog(Me)
            Dim CommissionDate As New SqlParameter("@CommissionDate", SqlDbType.DateTime, 10) : CommissionDate.Direction = ParameterDirection.Input : CommissionDate.Value = MyDialogBox.CommissionDate : Params(0) = CommissionDate
            With MyLoadedForm
                BusinessObject.Sub_Show(ServerPath2, "Qpi_SalesSummary", CommandType.StoredProcedure, RemoteDataSet, "Qpi_SalesSummary", Params)
                MyReport.SetDataSource(RemoteDataSet.Qpi_SalesSummary)
                .ReportViewer.ReportSource = MyReport
                .MdiParent = Me
                .Show()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub MenuItem67_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem67.Click
        Dim MyLoadedForm As New frmQpiTerritoryAssignment
        MyLoadedForm.MdiParent = Me
        MyLoadedForm.Show()
    End Sub
    Private Sub MenuItem68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem68.Click
        Dim MyLoadedForm As New frmQpiTerritoryAssignment_Modify
        MyLoadedForm.MdiParent = Me
        MyLoadedForm.Show()
    End Sub
    Private Sub MenuItem71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem71.Click
        Dim MyLoadedForm As New CustomerTypeCT
        MyLoadedForm.MdiParent = Me
        MyLoadedForm.Show()
    End Sub
    Private Sub MenuItem72_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem72.Click
        Dim MyLoadedForm As New DivisionCT
        MyLoadedForm.MdiParent = Me
        MyLoadedForm.Show()
    End Sub

    Private Sub MenuItem73_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem73.Click
        Dim MyLoadedForm As New GroupCT
        MyLoadedForm.MdiParent = Me
        MyLoadedForm.Show()
    End Sub

    Private Sub MenuItem74_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem74.Click
        Dim MyLoadedForm As New ItemCT
        MyLoadedForm.MdiParent = Me
        MyLoadedForm.Show()
    End Sub

    Private Sub MenuItem75_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem75.Click
        Dim MyLoadedForm As New MedRepCT
        MyLoadedForm.MdiParent = Me
        MyLoadedForm.Show()
    End Sub

    Private Sub MenuItem76_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem76.Click
        Dim MyLoadedForm As New MercuryBranchCT
        MyLoadedForm.MdiParent = Me
        MyLoadedForm.Show()
    End Sub

    Private Sub MenuItem77_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem77.Click
        Dim MyLoadedForm As New MercuryItemCT
        MyLoadedForm.MdiParent = Me
        MyLoadedForm.Show()
    End Sub

    Private Sub MenuItem78_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem78.Click
        Dim MyLoadedForm As New PrincipalCT
        MyLoadedForm.MdiParent = Me
        MyLoadedForm.Show()
    End Sub

    Private Sub MenuItem79_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem79.Click
        Dim MyLoadedForm As New ProvinceCT
        MyLoadedForm.MdiParent = Me
        MyLoadedForm.Show()
    End Sub

    Private Sub MenuItem80_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem80.Click
        Dim MyLoadedForm As New SupervisorCT
        MyLoadedForm.MdiParent = Me
        MyLoadedForm.Show()
    End Sub

    Private Sub MenuItem81_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem81.Click
        Dim MyLoadedForm As New TerritoryCT
        MyLoadedForm.MdiParent = Me
        MyLoadedForm.Show()
    End Sub

    Private Sub MenuItem90_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem90.Click
        Dim MyLoadedForm As New TeamDivisionCT
        MyLoadedForm.MdiParent = Me
        MyLoadedForm.Show()
    End Sub

    Private Sub MenuItem87_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem87.Click
        Dim MyLoadedForm As New ProductLinesCT
        MyLoadedForm.MdiParent = Me
        MyLoadedForm.Show()
    End Sub
    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        Dim MyLoadedForm As New CustomerCT
        MyLoadedForm.MdiParent = Me
        MyLoadedForm.Show()
    End Sub

    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        Dim MyLoadedForm As New CallRateBudgetCT
        MyLoadedForm.MdiParent = Me
        MyLoadedForm.Show()
    End Sub

    Private Sub MenuItem42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem42.Click
        Dim MyLoadedForm As New QpiTerritoryBudgetCT
        MyLoadedForm.MdiParent = Me
        MyLoadedForm.Show()
    End Sub

    Private Sub MenuItem64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem64.Click
        Dim BusinessLayer As New BusinessLayer.clsFileMaintenance
        Dim RemoteDataSet As New CodeTablesDS
        Dim MyDialogBox As New frmDialogBox
        MyDialogBox.ShowDialog(Me)
        Dim Params(0) As SqlParameter
        Dim CommissionDate As New SqlParameter("@CommissionDate", SqlDbType.DateTime) : CommissionDate.Direction = ParameterDirection.Input : CommissionDate.Value = MyDialogBox.CommissionDate : Params(0) = CommissionDate
        BusinessLayer.Sub_Select(ServerPath2, "CallRate_Calenderized", CommandType.StoredProcedure, RemoteDataSet, _
        "CallRate_Calenderized", Params)
        Dim myReportViewer As New frmReportViewer
        Dim myReport As New CallRate_CalenderizedNSM
        myReport.SetDataSource(RemoteDataSet.CallRate_Calenderized)
        myReportViewer.ReportViewer.ReportSource = myReport
        myReportViewer.Show()
    End Sub

    Private Sub MenuItem85_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem85.Click
        Dim BusinessLayer As New BusinessLayer.clsFileMaintenance
        Dim RemoteDataSet As New CodeTablesDS
        Dim MyDialogBox As New frmDialogBox
        MyDialogBox.ShowDialog(Me)
        Dim Params(0) As SqlParameter
        Dim CommissionDate As New SqlParameter("@CommissionDate", SqlDbType.DateTime) : CommissionDate.Direction = ParameterDirection.Input : CommissionDate.Value = MyDialogBox.CommissionDate : Params(0) = CommissionDate
        BusinessLayer.Sub_Select(ServerPath2, "CallRate_Calenderized", CommandType.StoredProcedure, RemoteDataSet, _
        "CallRate_Calenderized", Params)
        Dim myReportViewer As New frmReportViewer
        Dim myReport As New CallRate_CalenderizedDSM
        myReport.SetDataSource(RemoteDataSet.CallRate_Calenderized)
        myReportViewer.ReportViewer.ReportSource = myReport
        myReportViewer.Show()
    End Sub

    Private Sub MenuItem89_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem89.Click
        Dim BusinessLayer As New BusinessLayer.clsFileMaintenance
        Dim RemoteDataSet As New CodeTablesDS
        Dim MyDialogBox As New frmDialogBox
        MyDialogBox.ShowDialog(Me)
        Dim Params(0) As SqlParameter
        Dim CommissionDate As New SqlParameter("@CommissionDate", SqlDbType.DateTime) : CommissionDate.Direction = ParameterDirection.Input : CommissionDate.Value = MyDialogBox.CommissionDate : Params(0) = CommissionDate
        BusinessLayer.Sub_Select(ServerPath2, "CallRate_Calenderized", CommandType.StoredProcedure, RemoteDataSet, _
        "CallRate_Calenderized", Params)
        Dim myReportViewer As New frmReportViewer
        Dim myReport As New CallRate_CalenderizedPMR
        myReport.SetDataSource(RemoteDataSet.CallRate_Calenderized)
        myReportViewer.ReportViewer.ReportSource = myReport
        myReportViewer.Show()
    End Sub
    Private Sub MenuItem92_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem92.Click
        Dim BusinessLayer As New BusinessLayer.clsFileMaintenance
        Dim RemoteDataSet As New CodeTablesDS
        Dim MyDialogBox As New frmDialogBox
        MyDialogBox.ShowDialog(Me)
        Dim Params(0) As SqlParameter
        Dim CommissionDate As New SqlParameter("@CommissionDate", SqlDbType.DateTime) : CommissionDate.Direction = ParameterDirection.Input : CommissionDate.Value = MyDialogBox.CommissionDate : Params(0) = CommissionDate
        BusinessLayer.Sub_Select(ServerPath2, "CallRate_Monthly", CommandType.StoredProcedure, RemoteDataSet, _
        "CallRate_Calenderized", Params)
        Dim myReportViewer As New frmReportViewer
        Dim myReport As New CallRate_MonthlyNSM
        myReport.SetDataSource(RemoteDataSet.CallRate_Calenderized)
        myReportViewer.ReportViewer.ReportSource = myReport
        myReportViewer.Show()
    End Sub

    Private Sub MenuItem93_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem93.Click
        Dim BusinessLayer As New BusinessLayer.clsFileMaintenance
        Dim RemoteDataSet As New CodeTablesDS
        Dim MyDialogBox As New frmDialogBox
        MyDialogBox.ShowDialog(Me)
        Dim Params(0) As SqlParameter
        Dim CommissionDate As New SqlParameter("@CommissionDate", SqlDbType.DateTime) : CommissionDate.Direction = ParameterDirection.Input : CommissionDate.Value = MyDialogBox.CommissionDate : Params(0) = CommissionDate
        BusinessLayer.Sub_Select(ServerPath2, "CallRate_Monthly", CommandType.StoredProcedure, RemoteDataSet, _
        "CallRate_Calenderized", Params)
        Dim myReportViewer As New frmReportViewer
        Dim myReport As New CallRate_MonthlyDSM
        myReport.SetDataSource(RemoteDataSet.CallRate_Calenderized)
        myReportViewer.ReportViewer.ReportSource = myReport
        myReportViewer.Show()
    End Sub

    Private Sub MenuItem94_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem94.Click
        Dim BusinessLayer As New BusinessLayer.clsFileMaintenance
        Dim RemoteDataSet As New CodeTablesDS
        Dim MyDialogBox As New frmDialogBox
        MyDialogBox.ShowDialog(Me)
        Dim Params(0) As SqlParameter
        Dim CommissionDate As New SqlParameter("@CommissionDate", SqlDbType.DateTime) : CommissionDate.Direction = ParameterDirection.Input : CommissionDate.Value = MyDialogBox.CommissionDate : Params(0) = CommissionDate
        BusinessLayer.Sub_Select(ServerPath2, "CallRate_Monthly", CommandType.StoredProcedure, RemoteDataSet, _
        "CallRate_Calenderized", Params)
        Dim myReportViewer As New frmReportViewer
        Dim myReport As New CallRate_MonthlyPMR
        myReport.SetDataSource(RemoteDataSet.CallRate_Calenderized)
        myReportViewer.ReportViewer.ReportSource = myReport
        myReportViewer.Show()
    End Sub

    Private Sub MenuItem95_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem95.Click
        Dim MyLoadedForm As New BudgetOsCT
        MyLoadedForm.MdiParent = Me
        MyLoadedForm.Show()
    End Sub

    Private Sub MenuItem96_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem96.Click
        Dim MyLoadedForm As New CallRateCT
        MyLoadedForm.MdiParent = Me
        MyLoadedForm.Show()
    End Sub

    Private Sub mnuExtractMDIDailySales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuItem97_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem97.Click
        Dim MyLoadedForm As New PM_CT
        MyLoadedForm.MdiParent = Me
        MyLoadedForm.Show()
    End Sub

    Private Sub MenuItem98_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem98.Click
        Dim MyLoadedForm As New frmExCustomers
        MyLoadedForm.MdiParent = Me
        MyLoadedForm.Show()
    End Sub

    Private Sub MenuItem99_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem99.Click
        Dim MyLoadedForm As New QPIareacode
        MyLoadedForm.MdiParent = Me
        MyLoadedForm.Show()
    End Sub

    Private Sub MenuItem100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem100.Click
        Dim MyLoadedForm As New QpiAreaAssign
        MyLoadedForm.MdiParent = Me
        MyLoadedForm.Show()
    End Sub

    Private Sub MenuItem101_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem101.Click
        Dim MyLoadedForm As New MedRepTerAssign
        MyLoadedForm.MdiParent = Me
        MyLoadedForm.Show()
    End Sub

    Private Sub MenuItem102_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem102.Click
        Dim MyLoadedForm As New frmItemBudget
        MyLoadedForm.MdiParent = Me
        MyLoadedForm.Show()
    End Sub

    Private Sub MenuItem103_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem103.Click
        Dim myDialogBox As New frmDialogBox
        Dim myCommissionDate As String
        myDialogBox.ShowDialog()
        myCommissionDate = myDialogBox.CommissionDate

        'Compute the Attachment
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComIncAttach", CommandType.StoredProcedure, 1)

        'Compute the ComInc
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComInc2008", CommandType.StoredProcedure, 1)

        Dim myReportViewer As New frmReportViewer
        myReportViewer.Report = "Medrep Commission with Recovery2008"
        myReportViewer.CommissionDate = myCommissionDate
        myReportViewer.MdiParent = Me
        myReportViewer.Show()
    End Sub

    Private Sub Mnu_DistrictManagerCommissionWithRecovery2008_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_DistrictManagerCommissionWithRecovery2008.Click
        Dim myDialogBox As New frmDialogBox
        Dim myCommissionDate As String
        myDialogBox.ShowDialog()
        myCommissionDate = myDialogBox.CommissionDate

        'Compute the Attachment
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComIncAttach", CommandType.StoredProcedure, 1)

        'Compute the ComInc
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComInc2008", CommandType.StoredProcedure, 1)

        'Compute the DSM_Commission2008
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "DSM_Commission_2008", CommandType.StoredProcedure, 1)

        'Compute the DSMPMR_det
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "DSMPMR_det", CommandType.StoredProcedure, 1)

        'Compute the DSMPMR_ins
        Dim LocalCommand As New SqlCommand
        With LocalCommand
            .Connection = ObjectConnection(ServerPath2)
            .CommandText = "DSMPMR_ins"
            .CommandType = CommandType.StoredProcedure
            .ExecuteScalar()
        End With

        Dim myReportViewer As New frmReportViewer
        myReportViewer.Report = "DSM Commission with Recovery2008"
        myReportViewer.CommissionDate = myCommissionDate
        myReportViewer.MdiParent = Me
        myReportViewer.Show()
    End Sub

    Private Sub MenuItem104_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem104.Click
        Dim myLoadedForm As New EditIntegratedSalesMercury
        myLoadedForm.MdiParent = Me
        myLoadedForm.Show()
    End Sub

    Private Sub mnuUserMaint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUserMaint.Click
        Dim myLoadedForm As New frmUserMaint
        'Dim s As String
        's = "select userid from NewScores..usertab where userid = '" & Trim(gUserID) & "' and role = 'Admin' "
        'If Existing(s) = True Then
        myLoadedForm.MdiParent = Me
        myLoadedForm.Show()
        'End If
    End Sub

    'Private Sub Main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    Dim MyLoadedForm As New LogIn
    '    MyLoadedForm.ShowDialog(Me)
    'End Sub

    Private Sub Main_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        End
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Dim myLoadedForm As New frmProcessProscarData
        myLoadedForm.MdiParent = Me
        myLoadedForm.Show()
    End Sub

    Private Sub ExtCustZue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExtCustZue.Click
        Dim myLoadedForm As New frmExCustomersZue
        myLoadedForm.MdiParent = Me
        myLoadedForm.Show()
    End Sub
End Class
