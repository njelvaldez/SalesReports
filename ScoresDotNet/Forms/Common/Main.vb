Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Configuration
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
    Friend WithEvents mnu_ControlTotals As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_DistributeReports As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_ProcessMdiData As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_ProcessSubDistributorData As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_ProcessInHouseData As System.Windows.Forms.MenuItem
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
    Friend WithEvents MenuItem76 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem77 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem62 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem63 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem64 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem85 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem89 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem91 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem92 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem93 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem94 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem61 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem100 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem65 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem42 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem69 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem67 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem68 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem99 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem103 As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_DistrictManagerCommissionWithRecovery2008 As System.Windows.Forms.MenuItem
    Friend WithEvents MnuItmPriKeyProds As System.Windows.Forms.MenuItem
    Friend WithEvents MnuKeyProds As System.Windows.Forms.MenuItem
    Friend WithEvents MnuItmSecKeyProds As System.Windows.Forms.MenuItem
    Friend WithEvents MnuItmTerKeyProds As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_ProcessMercuryData As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents ExtCustZue As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_DistrictManagerCommission2008QX As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_MedrepCommissionQX2008 As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_MedrepCommissionWithRecovery2009 As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_DistrictManagerCommissionWithRecovery2009 As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_ProcessCallRateProduct As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_CommissionAttachment2009 As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_CommissionAttachmentDM2009 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem105 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem106 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem107 As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_MedrepCommissionChiral2009 As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_DistrictManagerCommission2009Chiral As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_CommissionAttachmentDSM2009Chiral As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_CommissionAttachmentDSM2008Chiral As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem108 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem109 As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_ModernTradeDSM As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_CommissionAttachmentMTD2009 As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_MdiPerMedrepMTD As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_MedrepCommissionWithRecovery2009MTD As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem110 As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_PushProds As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_YTD As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_YTDdsm As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_Company As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_District As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem111 As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_MHmrarea As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_itm4thKeyProds As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_itm5thKeyProds As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem112 As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_DistrictManagerCommission2010Chiral As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_MedrepCommissionWithRecovery2010 As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_DistrictManagerCommissionWithRecovery2010 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuOrgChrtRef As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_YTDpush As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMercBranAct As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_YTDpushDSM As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem113 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem114 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem117 As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_CommissionAttachmentMH As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_MedrepCommissionWithRecoveryMH As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_DSMCommissionAttachmentMH As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_DSMCommissionWithRecoveryMH As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_DistributeReportsMH As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_MDIperBDS As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_MercurySalesBDS As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem115 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem116 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem118 As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_CommissionAttachmentFLT As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_MedrepCommissionWithRecoveryFLT As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_MdiPerMedrepFLT As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_MercurySalesFLT As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_MedrepCommissionWithRecovery2010BioM As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_DistrictManagerCommissionWithRecovery2010Biomedica As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_MedrepCommissionWithRecovery2011 As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_DistrictManagerCommissionWithRecovery2011 As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_ProcessMercuryDataSept As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_MedrepCommissionWithRecovery2012 As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_DistrictManagerCommissionWithRecovery2012 As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_MedrepCommissionWithRecovery2013 As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_DistrictManagerCommissionWithRecovery2013 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem122 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem123 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem124 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem125 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem126 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem127 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem128 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem129 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem131 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem132 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem133 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem134 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem135 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem96 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem98 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem137 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem138 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem139 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem140 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem141 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem43 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem72 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem74 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem78 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem87 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem130 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem71 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem44 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem80 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem81 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem101 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem75 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem95 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem73 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem136 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem142 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem143 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem144 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem145 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem79 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem83 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem84 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem82 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem88 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem90 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem97 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem102 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem104 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem119 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem120 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem121 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem146 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem147 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem148 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem149 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem150 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem151 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem152 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem153 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem154 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem155 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem156 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem157 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem158 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem159 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem160 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem161 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem162 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem163 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem164 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem165 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem166 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem167 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem168 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem169 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem170 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem171 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem172 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem173 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem174 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem175 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem176 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem177 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem178 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem179 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem180 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem181 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem182 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem183 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem184 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem185 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem186 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem187 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem188 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem189 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem190 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem191 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem192 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem193 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem194 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem195 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem197 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem196 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem198 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem199 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem200 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem201 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem202 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem203 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem204 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem205 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem206 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem207 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem208 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem209 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem211 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem212 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem213 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem214 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem215 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem216 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem210 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem217 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem218 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem219 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem220 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem221 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem222 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem223 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem224 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem225 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem226 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem227 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem229 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem228 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem230 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem231 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem232 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem233 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem234 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem235 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem236 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem237 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem238 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem239 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem240 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem241 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem242 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem243 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem244 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem245 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem246 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem247 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem248 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem249 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem250 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem251 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem86 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.mnu_ProcessMdiData = New System.Windows.Forms.MenuItem()
        Me.mnu_ProcessSubDistributorData = New System.Windows.Forms.MenuItem()
        Me.mnu_ProcessInHouseData = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem108 = New System.Windows.Forms.MenuItem()
        Me.Mnu_ProcessMercuryData = New System.Windows.Forms.MenuItem()
        Me.Mnu_ProcessMercuryDataSept = New System.Windows.Forms.MenuItem()
        Me.MenuItem150 = New System.Windows.Forms.MenuItem()
        Me.mnu_ProcessCallRate = New System.Windows.Forms.MenuItem()
        Me.mnu_ProcessCallRateProduct = New System.Windows.Forms.MenuItem()
        Me.mnu_ControlTotals = New System.Windows.Forms.MenuItem()
        Me.MenuItem45 = New System.Windows.Forms.MenuItem()
        Me.MenuItem50 = New System.Windows.Forms.MenuItem()
        Me.MenuItem55 = New System.Windows.Forms.MenuItem()
        Me.MenuItem56 = New System.Windows.Forms.MenuItem()
        Me.MenuItem57 = New System.Windows.Forms.MenuItem()
        Me.MenuItem58 = New System.Windows.Forms.MenuItem()
        Me.MenuItem59 = New System.Windows.Forms.MenuItem()
        Me.MenuItem60 = New System.Windows.Forms.MenuItem()
        Me.MenuItem128 = New System.Windows.Forms.MenuItem()
        Me.MenuItem82 = New System.Windows.Forms.MenuItem()
        Me.MenuItem88 = New System.Windows.Forms.MenuItem()
        Me.MenuItem90 = New System.Windows.Forms.MenuItem()
        Me.MenuItem97 = New System.Windows.Forms.MenuItem()
        Me.MenuItem102 = New System.Windows.Forms.MenuItem()
        Me.MenuItem104 = New System.Windows.Forms.MenuItem()
        Me.MenuItem119 = New System.Windows.Forms.MenuItem()
        Me.MenuItem129 = New System.Windows.Forms.MenuItem()
        Me.mnuExit = New System.Windows.Forms.MenuItem()
        Me.MenuItem151 = New System.Windows.Forms.MenuItem()
        Me.MenuItem156 = New System.Windows.Forms.MenuItem()
        Me.MenuItem157 = New System.Windows.Forms.MenuItem()
        Me.MenuItem158 = New System.Windows.Forms.MenuItem()
        Me.MenuItem202 = New System.Windows.Forms.MenuItem()
        Me.MenuItem203 = New System.Windows.Forms.MenuItem()
        Me.MenuItem204 = New System.Windows.Forms.MenuItem()
        Me.MenuItem205 = New System.Windows.Forms.MenuItem()
        Me.MenuItem225 = New System.Windows.Forms.MenuItem()
        Me.MenuItem249 = New System.Windows.Forms.MenuItem()
        Me.MenuItem183 = New System.Windows.Forms.MenuItem()
        Me.MenuItem184 = New System.Windows.Forms.MenuItem()
        Me.MenuItem229 = New System.Windows.Forms.MenuItem()
        Me.MenuItem206 = New System.Windows.Forms.MenuItem()
        Me.MenuItem228 = New System.Windows.Forms.MenuItem()
        Me.MenuItem159 = New System.Windows.Forms.MenuItem()
        Me.MenuItem160 = New System.Windows.Forms.MenuItem()
        Me.MenuItem161 = New System.Windows.Forms.MenuItem()
        Me.MenuItem167 = New System.Windows.Forms.MenuItem()
        Me.MenuItem163 = New System.Windows.Forms.MenuItem()
        Me.MenuItem166 = New System.Windows.Forms.MenuItem()
        Me.MenuItem194 = New System.Windows.Forms.MenuItem()
        Me.MenuItem164 = New System.Windows.Forms.MenuItem()
        Me.MenuItem200 = New System.Windows.Forms.MenuItem()
        Me.MenuItem239 = New System.Windows.Forms.MenuItem()
        Me.MenuItem240 = New System.Windows.Forms.MenuItem()
        Me.MenuItem241 = New System.Windows.Forms.MenuItem()
        Me.MenuItem165 = New System.Windows.Forms.MenuItem()
        Me.MenuItem242 = New System.Windows.Forms.MenuItem()
        Me.MenuItem162 = New System.Windows.Forms.MenuItem()
        Me.MenuItem192 = New System.Windows.Forms.MenuItem()
        Me.MenuItem243 = New System.Windows.Forms.MenuItem()
        Me.MenuItem197 = New System.Windows.Forms.MenuItem()
        Me.MenuItem244 = New System.Windows.Forms.MenuItem()
        Me.MenuItem174 = New System.Windows.Forms.MenuItem()
        Me.MenuItem175 = New System.Windows.Forms.MenuItem()
        Me.MenuItem176 = New System.Windows.Forms.MenuItem()
        Me.MenuItem177 = New System.Windows.Forms.MenuItem()
        Me.MenuItem178 = New System.Windows.Forms.MenuItem()
        Me.MenuItem181 = New System.Windows.Forms.MenuItem()
        Me.MenuItem182 = New System.Windows.Forms.MenuItem()
        Me.MenuItem238 = New System.Windows.Forms.MenuItem()
        Me.MenuItem248 = New System.Windows.Forms.MenuItem()
        Me.MenuItem226 = New System.Windows.Forms.MenuItem()
        Me.MenuItem227 = New System.Windows.Forms.MenuItem()
        Me.MenuItem230 = New System.Windows.Forms.MenuItem()
        Me.MenuItem152 = New System.Windows.Forms.MenuItem()
        Me.MenuItem154 = New System.Windows.Forms.MenuItem()
        Me.MenuItem153 = New System.Windows.Forms.MenuItem()
        Me.MenuItem155 = New System.Windows.Forms.MenuItem()
        Me.MenuItem179 = New System.Windows.Forms.MenuItem()
        Me.MenuItem193 = New System.Windows.Forms.MenuItem()
        Me.MenuItem207 = New System.Windows.Forms.MenuItem()
        Me.MenuItem199 = New System.Windows.Forms.MenuItem()
        Me.MenuItem191 = New System.Windows.Forms.MenuItem()
        Me.MenuItem186 = New System.Windows.Forms.MenuItem()
        Me.MenuItem187 = New System.Windows.Forms.MenuItem()
        Me.MenuItem190 = New System.Windows.Forms.MenuItem()
        Me.MenuItem185 = New System.Windows.Forms.MenuItem()
        Me.MenuItem188 = New System.Windows.Forms.MenuItem()
        Me.MenuItem189 = New System.Windows.Forms.MenuItem()
        Me.MenuItem195 = New System.Windows.Forms.MenuItem()
        Me.MenuItem201 = New System.Windows.Forms.MenuItem()
        Me.MenuItem245 = New System.Windows.Forms.MenuItem()
        Me.MenuItem180 = New System.Windows.Forms.MenuItem()
        Me.MenuItem198 = New System.Windows.Forms.MenuItem()
        Me.MenuItem196 = New System.Windows.Forms.MenuItem()
        Me.MenuItem246 = New System.Windows.Forms.MenuItem()
        Me.MenuItem250 = New System.Windows.Forms.MenuItem()
        Me.MenuItem251 = New System.Windows.Forms.MenuItem()
        Me.MenuItem168 = New System.Windows.Forms.MenuItem()
        Me.MenuItem170 = New System.Windows.Forms.MenuItem()
        Me.MenuItem171 = New System.Windows.Forms.MenuItem()
        Me.MenuItem169 = New System.Windows.Forms.MenuItem()
        Me.MenuItem173 = New System.Windows.Forms.MenuItem()
        Me.MenuItem221 = New System.Windows.Forms.MenuItem()
        Me.MenuItem219 = New System.Windows.Forms.MenuItem()
        Me.MenuItem172 = New System.Windows.Forms.MenuItem()
        Me.MenuItem220 = New System.Windows.Forms.MenuItem()
        Me.MenuItem223 = New System.Windows.Forms.MenuItem()
        Me.MenuItem224 = New System.Windows.Forms.MenuItem()
        Me.mnuFileMaintenane = New System.Windows.Forms.MenuItem()
        Me.mnu_Company = New System.Windows.Forms.MenuItem()
        Me.mnu_District = New System.Windows.Forms.MenuItem()
        Me.MenuItem79 = New System.Windows.Forms.MenuItem()
        Me.MenuItem111 = New System.Windows.Forms.MenuItem()
        Me.mnu_MHmrarea = New System.Windows.Forms.MenuItem()
        Me.MenuItem86 = New System.Windows.Forms.MenuItem()
        Me.MenuItem84 = New System.Windows.Forms.MenuItem()
        Me.MenuItem83 = New System.Windows.Forms.MenuItem()
        Me.MenuItem44 = New System.Windows.Forms.MenuItem()
        Me.MenuItem135 = New System.Windows.Forms.MenuItem()
        Me.MenuItem134 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem98 = New System.Windows.Forms.MenuItem()
        Me.MenuItem72 = New System.Windows.Forms.MenuItem()
        Me.MenuItem74 = New System.Windows.Forms.MenuItem()
        Me.MenuItem78 = New System.Windows.Forms.MenuItem()
        Me.ExtCustZue = New System.Windows.Forms.MenuItem()
        Me.MenuItem87 = New System.Windows.Forms.MenuItem()
        Me.MenuItem130 = New System.Windows.Forms.MenuItem()
        Me.MenuItem75 = New System.Windows.Forms.MenuItem()
        Me.MenuItem43 = New System.Windows.Forms.MenuItem()
        Me.MenuItem137 = New System.Windows.Forms.MenuItem()
        Me.MenuItem141 = New System.Windows.Forms.MenuItem()
        Me.MenuItem138 = New System.Windows.Forms.MenuItem()
        Me.MenuItem139 = New System.Windows.Forms.MenuItem()
        Me.MenuItem140 = New System.Windows.Forms.MenuItem()
        Me.MenuItem131 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem132 = New System.Windows.Forms.MenuItem()
        Me.MenuItem133 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem237 = New System.Windows.Forms.MenuItem()
        Me.mnu_Reports = New System.Windows.Forms.MenuItem()
        Me.mnu_DistributeReports = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.mnu_MdiPerMedrep = New System.Windows.Forms.MenuItem()
        Me.MenuItem120 = New System.Windows.Forms.MenuItem()
        Me.mnu_MercurySales = New System.Windows.Forms.MenuItem()
        Me.MenuItem121 = New System.Windows.Forms.MenuItem()
        Me.mnu_MdiPerMedrepUntagged = New System.Windows.Forms.MenuItem()
        Me.Mnu_CommissionAttachment = New System.Windows.Forms.MenuItem()
        Me.Mnu_CommissionAttachment2009 = New System.Windows.Forms.MenuItem()
        Me.MenuItem148 = New System.Windows.Forms.MenuItem()
        Me.MenuItem215 = New System.Windows.Forms.MenuItem()
        Me.Mnu_MedrepCommission = New System.Windows.Forms.MenuItem()
        Me.Mnu_MedrepCommissionWithRecovery = New System.Windows.Forms.MenuItem()
        Me.MenuItem103 = New System.Windows.Forms.MenuItem()
        Me.Mnu_MedrepCommissionWithRecovery2009 = New System.Windows.Forms.MenuItem()
        Me.mnu_YTD = New System.Windows.Forms.MenuItem()
        Me.mnu_YTDpush = New System.Windows.Forms.MenuItem()
        Me.Mnu_MedrepCommissionWithRecovery2010 = New System.Windows.Forms.MenuItem()
        Me.Mnu_MedrepCommissionWithRecovery2010BioM = New System.Windows.Forms.MenuItem()
        Me.Mnu_MedrepCommissionWithRecovery2011 = New System.Windows.Forms.MenuItem()
        Me.Mnu_MedrepCommissionWithRecovery2012 = New System.Windows.Forms.MenuItem()
        Me.Mnu_MedrepCommissionWithRecovery2013 = New System.Windows.Forms.MenuItem()
        Me.MenuItem147 = New System.Windows.Forms.MenuItem()
        Me.MenuItem216 = New System.Windows.Forms.MenuItem()
        Me.MenuItem247 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.Mnu_CommissionAttachmentDM = New System.Windows.Forms.MenuItem()
        Me.Mnu_CommissionAttachmentDM2009 = New System.Windows.Forms.MenuItem()
        Me.Mnu_SupervisorCommission = New System.Windows.Forms.MenuItem()
        Me.Mnu_DistrictManagerCommissionWithRecovery = New System.Windows.Forms.MenuItem()
        Me.Mnu_DistrictManagerCommissionWithRecovery2008 = New System.Windows.Forms.MenuItem()
        Me.Mnu_DistrictManagerCommissionWithRecovery2009 = New System.Windows.Forms.MenuItem()
        Me.mnu_YTDdsm = New System.Windows.Forms.MenuItem()
        Me.mnu_YTDpushDSM = New System.Windows.Forms.MenuItem()
        Me.Mnu_DistrictManagerCommissionWithRecovery2010 = New System.Windows.Forms.MenuItem()
        Me.Mnu_DistrictManagerCommissionWithRecovery2010Biomedica = New System.Windows.Forms.MenuItem()
        Me.Mnu_DistrictManagerCommissionWithRecovery2011 = New System.Windows.Forms.MenuItem()
        Me.Mnu_DistrictManagerCommissionWithRecovery2012 = New System.Windows.Forms.MenuItem()
        Me.Mnu_DistrictManagerCommissionWithRecovery2013 = New System.Windows.Forms.MenuItem()
        Me.MenuItem149 = New System.Windows.Forms.MenuItem()
        Me.MenuItem222 = New System.Windows.Forms.MenuItem()
        Me.MenuItem231 = New System.Windows.Forms.MenuItem()
        Me.MenuItem232 = New System.Windows.Forms.MenuItem()
        Me.MenuItem234 = New System.Windows.Forms.MenuItem()
        Me.MenuItem233 = New System.Windows.Forms.MenuItem()
        Me.MenuItem236 = New System.Windows.Forms.MenuItem()
        Me.MenuItem235 = New System.Windows.Forms.MenuItem()
        Me.MenuItem122 = New System.Windows.Forms.MenuItem()
        Me.MenuItem123 = New System.Windows.Forms.MenuItem()
        Me.MenuItem124 = New System.Windows.Forms.MenuItem()
        Me.MenuItem125 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem109 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem106 = New System.Windows.Forms.MenuItem()
        Me.MenuItem107 = New System.Windows.Forms.MenuItem()
        Me.Mnu_MedrepCommissionQX2008 = New System.Windows.Forms.MenuItem()
        Me.Mnu_MedrepCommissionChiral2009 = New System.Windows.Forms.MenuItem()
        Me.MenuItem112 = New System.Windows.Forms.MenuItem()
        Me.MenuItem105 = New System.Windows.Forms.MenuItem()
        Me.Mnu_CommissionAttachmentDSM2008Chiral = New System.Windows.Forms.MenuItem()
        Me.Mnu_CommissionAttachmentDSM2009Chiral = New System.Windows.Forms.MenuItem()
        Me.Mnu_DistrictManagerCommission2008QX = New System.Windows.Forms.MenuItem()
        Me.Mnu_DistrictManagerCommission2009Chiral = New System.Windows.Forms.MenuItem()
        Me.Mnu_DistrictManagerCommission2010Chiral = New System.Windows.Forms.MenuItem()
        Me.MenuItem115 = New System.Windows.Forms.MenuItem()
        Me.MenuItem116 = New System.Windows.Forms.MenuItem()
        Me.MenuItem118 = New System.Windows.Forms.MenuItem()
        Me.mnu_MdiPerMedrepFLT = New System.Windows.Forms.MenuItem()
        Me.mnu_MercurySalesFLT = New System.Windows.Forms.MenuItem()
        Me.Mnu_CommissionAttachmentFLT = New System.Windows.Forms.MenuItem()
        Me.Mnu_MedrepCommissionWithRecoveryFLT = New System.Windows.Forms.MenuItem()
        Me.MenuItem113 = New System.Windows.Forms.MenuItem()
        Me.mnu_DistributeReportsMH = New System.Windows.Forms.MenuItem()
        Me.MenuItem114 = New System.Windows.Forms.MenuItem()
        Me.mnu_MDIperBDS = New System.Windows.Forms.MenuItem()
        Me.mnu_MercurySalesBDS = New System.Windows.Forms.MenuItem()
        Me.Mnu_CommissionAttachmentMH = New System.Windows.Forms.MenuItem()
        Me.Mnu_MedrepCommissionWithRecoveryMH = New System.Windows.Forms.MenuItem()
        Me.MenuItem117 = New System.Windows.Forms.MenuItem()
        Me.Mnu_DSMCommissionAttachmentMH = New System.Windows.Forms.MenuItem()
        Me.Mnu_DSMCommissionWithRecoveryMH = New System.Windows.Forms.MenuItem()
        Me.MenuItem110 = New System.Windows.Forms.MenuItem()
        Me.mnu_MdiPerMedrepMTD = New System.Windows.Forms.MenuItem()
        Me.Mnu_CommissionAttachmentMTD2009 = New System.Windows.Forms.MenuItem()
        Me.Mnu_MedrepCommissionWithRecovery2009MTD = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.Mnu_QpiPerTerritory = New System.Windows.Forms.MenuItem()
        Me.Mnu_QpiMercurySales = New System.Windows.Forms.MenuItem()
        Me.MenuItem66 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.Mnu_HiiPerTerritory = New System.Windows.Forms.MenuItem()
        Me.Mnu_HiiMercurySales = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem28 = New System.Windows.Forms.MenuItem()
        Me.MenuItem29 = New System.Windows.Forms.MenuItem()
        Me.MenuItem30 = New System.Windows.Forms.MenuItem()
        Me.MenuItem31 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem32 = New System.Windows.Forms.MenuItem()
        Me.MenuItem33 = New System.Windows.Forms.MenuItem()
        Me.MenuItem34 = New System.Windows.Forms.MenuItem()
        Me.MenuItem35 = New System.Windows.Forms.MenuItem()
        Me.MenuItem36 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem37 = New System.Windows.Forms.MenuItem()
        Me.MenuItem38 = New System.Windows.Forms.MenuItem()
        Me.MenuItem39 = New System.Windows.Forms.MenuItem()
        Me.MenuItem40 = New System.Windows.Forms.MenuItem()
        Me.MenuItem41 = New System.Windows.Forms.MenuItem()
        Me.MenuItem46 = New System.Windows.Forms.MenuItem()
        Me.MenuItem47 = New System.Windows.Forms.MenuItem()
        Me.MenuItem52 = New System.Windows.Forms.MenuItem()
        Me.MenuItem48 = New System.Windows.Forms.MenuItem()
        Me.MenuItem49 = New System.Windows.Forms.MenuItem()
        Me.MenuItem51 = New System.Windows.Forms.MenuItem()
        Me.MenuItem53 = New System.Windows.Forms.MenuItem()
        Me.MenuItem54 = New System.Windows.Forms.MenuItem()
        Me.MenuItem62 = New System.Windows.Forms.MenuItem()
        Me.MenuItem63 = New System.Windows.Forms.MenuItem()
        Me.MenuItem64 = New System.Windows.Forms.MenuItem()
        Me.MenuItem85 = New System.Windows.Forms.MenuItem()
        Me.MenuItem89 = New System.Windows.Forms.MenuItem()
        Me.MenuItem91 = New System.Windows.Forms.MenuItem()
        Me.MenuItem92 = New System.Windows.Forms.MenuItem()
        Me.MenuItem93 = New System.Windows.Forms.MenuItem()
        Me.MenuItem94 = New System.Windows.Forms.MenuItem()
        Me.mnuMercBranAct = New System.Windows.Forms.MenuItem()
        Me.MenuItem208 = New System.Windows.Forms.MenuItem()
        Me.MenuItem209 = New System.Windows.Forms.MenuItem()
        Me.MenuItem211 = New System.Windows.Forms.MenuItem()
        Me.MenuItem212 = New System.Windows.Forms.MenuItem()
        Me.MenuItem213 = New System.Windows.Forms.MenuItem()
        Me.MenuItem214 = New System.Windows.Forms.MenuItem()
        Me.MenuItem210 = New System.Windows.Forms.MenuItem()
        Me.MenuItem217 = New System.Windows.Forms.MenuItem()
        Me.MenuItem218 = New System.Windows.Forms.MenuItem()
        Me.MenuItem70 = New System.Windows.Forms.MenuItem()
        Me.mnuOrgChrtRef = New System.Windows.Forms.MenuItem()
        Me.MenuItem136 = New System.Windows.Forms.MenuItem()
        Me.MenuItem73 = New System.Windows.Forms.MenuItem()
        Me.MenuItem143 = New System.Windows.Forms.MenuItem()
        Me.MenuItem142 = New System.Windows.Forms.MenuItem()
        Me.MenuItem144 = New System.Windows.Forms.MenuItem()
        Me.MenuItem145 = New System.Windows.Forms.MenuItem()
        Me.mnu_ModernTradeDSM = New System.Windows.Forms.MenuItem()
        Me.MenuItem95 = New System.Windows.Forms.MenuItem()
        Me.MnuKeyProds = New System.Windows.Forms.MenuItem()
        Me.MnuItmPriKeyProds = New System.Windows.Forms.MenuItem()
        Me.MnuItmSecKeyProds = New System.Windows.Forms.MenuItem()
        Me.MnuItmTerKeyProds = New System.Windows.Forms.MenuItem()
        Me.mnu_itm4thKeyProds = New System.Windows.Forms.MenuItem()
        Me.mnu_itm5thKeyProds = New System.Windows.Forms.MenuItem()
        Me.Mnu_PushProds = New System.Windows.Forms.MenuItem()
        Me.MenuItem96 = New System.Windows.Forms.MenuItem()
        Me.MenuItem76 = New System.Windows.Forms.MenuItem()
        Me.MenuItem77 = New System.Windows.Forms.MenuItem()
        Me.MenuItem71 = New System.Windows.Forms.MenuItem()
        Me.MenuItem61 = New System.Windows.Forms.MenuItem()
        Me.MenuItem100 = New System.Windows.Forms.MenuItem()
        Me.MenuItem99 = New System.Windows.Forms.MenuItem()
        Me.MenuItem65 = New System.Windows.Forms.MenuItem()
        Me.MenuItem42 = New System.Windows.Forms.MenuItem()
        Me.MenuItem69 = New System.Windows.Forms.MenuItem()
        Me.MenuItem67 = New System.Windows.Forms.MenuItem()
        Me.MenuItem68 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem126 = New System.Windows.Forms.MenuItem()
        Me.MenuItem127 = New System.Windows.Forms.MenuItem()
        Me.MenuItem80 = New System.Windows.Forms.MenuItem()
        Me.MenuItem81 = New System.Windows.Forms.MenuItem()
        Me.MenuItem101 = New System.Windows.Forms.MenuItem()
        Me.MenuItem146 = New System.Windows.Forms.MenuItem()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem151, Me.mnuFileMaintenane, Me.mnu_Reports, Me.MenuItem208, Me.MenuItem70, Me.MenuItem5, Me.MenuItem126, Me.MenuItem80})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnu_ProcessMdiData, Me.mnu_ProcessSubDistributorData, Me.mnu_ProcessInHouseData, Me.MenuItem4, Me.MenuItem108, Me.Mnu_ProcessMercuryData, Me.Mnu_ProcessMercuryDataSept, Me.MenuItem150, Me.mnu_ProcessCallRate, Me.mnu_ControlTotals, Me.MenuItem45, Me.MenuItem50, Me.MenuItem55, Me.MenuItem56, Me.MenuItem57, Me.MenuItem58, Me.MenuItem59, Me.MenuItem60, Me.MenuItem128, Me.MenuItem82, Me.MenuItem88, Me.MenuItem90, Me.MenuItem97, Me.MenuItem102, Me.MenuItem104, Me.MenuItem119, Me.MenuItem129, Me.mnuExit})
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
        Me.MenuItem4.Text = "Process MSD Direct Sales Data"
        Me.MenuItem4.Visible = False
        '
        'MenuItem108
        '
        Me.MenuItem108.Index = 4
        Me.MenuItem108.Text = "Process MSD InMarket Data"
        Me.MenuItem108.Visible = False
        '
        'Mnu_ProcessMercuryData
        '
        Me.Mnu_ProcessMercuryData.Index = 5
        Me.Mnu_ProcessMercuryData.Text = "Process Mercury Data (Before Sept. 2011)"
        Me.Mnu_ProcessMercuryData.Visible = False
        '
        'Mnu_ProcessMercuryDataSept
        '
        Me.Mnu_ProcessMercuryDataSept.Index = 6
        Me.Mnu_ProcessMercuryDataSept.Text = "Process Mercury Data"
        '
        'MenuItem150
        '
        Me.MenuItem150.Index = 7
        Me.MenuItem150.Text = "Process Trade Report"
        '
        'mnu_ProcessCallRate
        '
        Me.mnu_ProcessCallRate.Index = 8
        Me.mnu_ProcessCallRate.Text = "Process Call Rate Summary"
        '
        'mnu_ProcessCallRateProduct
        '
        Me.mnu_ProcessCallRateProduct.Index = 3
        Me.mnu_ProcessCallRateProduct.Text = "Process Call Rate Product"
        '
        'mnu_ControlTotals
        '
        Me.mnu_ControlTotals.Index = 9
        Me.mnu_ControlTotals.Text = "Control Totals"
        '
        'MenuItem45
        '
        Me.MenuItem45.Index = 10
        Me.MenuItem45.Text = "Store Commission Computations"
        '
        'MenuItem50
        '
        Me.MenuItem50.Index = 11
        Me.MenuItem50.Text = "Compute Calenderized Performance"
        '
        'MenuItem55
        '
        Me.MenuItem55.Index = 12
        Me.MenuItem55.Text = "-"
        '
        'MenuItem56
        '
        Me.MenuItem56.Index = 13
        Me.MenuItem56.Text = "Populate Stock Transfer Reports(Peso)"
        '
        'MenuItem57
        '
        Me.MenuItem57.Index = 14
        Me.MenuItem57.Text = "Populate Stock Transfer Reports(Qty)"
        '
        'MenuItem58
        '
        Me.MenuItem58.Index = 15
        Me.MenuItem58.Text = "Populate Direct Reports(Peso)"
        '
        'MenuItem59
        '
        Me.MenuItem59.Index = 16
        Me.MenuItem59.Text = "Populate Direct Reports(Qty)"
        '
        'MenuItem60
        '
        Me.MenuItem60.Index = 17
        Me.MenuItem60.Text = "-"
        '
        'MenuItem128
        '
        Me.MenuItem128.Index = 18
        Me.MenuItem128.Text = "MDI Weekly Sales Invoice Export"
        '
        'MenuItem82
        '
        Me.MenuItem82.Index = 19
        Me.MenuItem82.Text = "Merged Stock Transfer Export"
        '
        'MenuItem88
        '
        Me.MenuItem88.Index = 20
        Me.MenuItem88.Text = "-"
        '
        'MenuItem90
        '
        Me.MenuItem90.Index = 21
        Me.MenuItem90.Text = "Tag"
        Me.MenuItem90.Visible = False
        '
        'MenuItem97
        '
        Me.MenuItem97.Index = 22
        Me.MenuItem97.Text = "-"
        Me.MenuItem97.Visible = False
        '
        'MenuItem102
        '
        Me.MenuItem102.Index = 23
        Me.MenuItem102.Text = "Customer Ship To Master"
        '
        'MenuItem104
        '
        Me.MenuItem104.Index = 24
        Me.MenuItem104.Text = "-"
        '
        'MenuItem119
        '
        Me.MenuItem119.Index = 25
        Me.MenuItem119.Text = "New Business Rule Maintenance"
        '
        'MenuItem129
        '
        Me.MenuItem129.Index = 26
        Me.MenuItem129.Text = "-"
        '
        'mnuExit
        '
        Me.mnuExit.Index = 27
        Me.mnuExit.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.mnuExit.Text = "E&xit"
        '
        'MenuItem151
        '
        Me.MenuItem151.Index = 1
        Me.MenuItem151.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem156, Me.MenuItem183, Me.MenuItem159, Me.MenuItem174, Me.MenuItem176, Me.MenuItem226, Me.MenuItem152, Me.MenuItem179, Me.MenuItem168, Me.MenuItem223})
        Me.MenuItem151.Text = "&Utility"
        '
        'MenuItem156
        '
        Me.MenuItem156.Index = 0
        Me.MenuItem156.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem157, Me.MenuItem158, Me.MenuItem202, Me.MenuItem203, Me.MenuItem204, Me.MenuItem205, Me.MenuItem225, Me.MenuItem249})
        Me.MenuItem156.Text = "Budget"
        '
        'MenuItem157
        '
        Me.MenuItem157.Index = 0
        Me.MenuItem157.Text = "Budget For Specialist"
        '
        'MenuItem158
        '
        Me.MenuItem158.Index = 1
        Me.MenuItem158.Text = "Budget For Disctributor"
        '
        'MenuItem202
        '
        Me.MenuItem202.Index = 2
        Me.MenuItem202.Text = "Budget Monthly Report"
        '
        'MenuItem203
        '
        Me.MenuItem203.Index = 3
        Me.MenuItem203.Text = "Budget 2 Months Report"
        '
        'MenuItem204
        '
        Me.MenuItem204.Index = 4
        Me.MenuItem204.Text = "Budget Direct Report"
        '
        'MenuItem205
        '
        Me.MenuItem205.Index = 5
        Me.MenuItem205.Text = "Budget Direct Summary Report"
        '
        'MenuItem225
        '
        Me.MenuItem225.Index = 6
        Me.MenuItem225.Text = "Transfer SP Budget "
        '
        'MenuItem249
        '
        Me.MenuItem249.Index = 7
        Me.MenuItem249.Text = "Budget National Transfers"
        '
        'MenuItem183
        '
        Me.MenuItem183.Index = 1
        Me.MenuItem183.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem184, Me.MenuItem229, Me.MenuItem206, Me.MenuItem228})
        Me.MenuItem183.Text = "Controls"
        '
        'MenuItem184
        '
        Me.MenuItem184.Index = 0
        Me.MenuItem184.Text = "Sales Control"
        '
        'MenuItem229
        '
        Me.MenuItem229.Index = 1
        Me.MenuItem229.Text = "Sales Discrepancy"
        '
        'MenuItem206
        '
        Me.MenuItem206.Index = 2
        Me.MenuItem206.Text = "Validate Bracco"
        '
        'MenuItem228
        '
        Me.MenuItem228.Index = 3
        Me.MenuItem228.Text = "Save SalesControl"
        '
        'MenuItem159
        '
        Me.MenuItem159.Index = 2
        Me.MenuItem159.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem160, Me.MenuItem161, Me.MenuItem167, Me.MenuItem163, Me.MenuItem166, Me.MenuItem194, Me.MenuItem164, Me.MenuItem200, Me.MenuItem239, Me.MenuItem165, Me.MenuItem242})
        Me.MenuItem159.Text = "Direct Reports"
        '
        'MenuItem160
        '
        Me.MenuItem160.Index = 0
        Me.MenuItem160.Text = "Account Coverage Direct"
        '
        'MenuItem161
        '
        Me.MenuItem161.Index = 1
        Me.MenuItem161.Text = "Average Selling Price"
        '
        'MenuItem167
        '
        Me.MenuItem167.Index = 2
        Me.MenuItem167.Text = "BR Reports"
        '
        'MenuItem163
        '
        Me.MenuItem163.Index = 3
        Me.MenuItem163.Text = "Calendarized Item Sales"
        '
        'MenuItem166
        '
        Me.MenuItem166.Index = 4
        Me.MenuItem166.Text = "CM Report - Pivot - Direct"
        '
        'MenuItem194
        '
        Me.MenuItem194.Index = 5
        Me.MenuItem194.Text = "Customer Reach Analysis Direct 2013"
        '
        'MenuItem164
        '
        Me.MenuItem164.Index = 6
        Me.MenuItem164.Text = "IMS In House Report"
        '
        'MenuItem200
        '
        Me.MenuItem200.Index = 7
        Me.MenuItem200.Text = "Item Sales Report"
        '
        'MenuItem239
        '
        Me.MenuItem239.Index = 8
        Me.MenuItem239.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem240, Me.MenuItem241})
        Me.MenuItem239.Text = "Sales Performance"
        '
        'MenuItem240
        '
        Me.MenuItem240.Index = 0
        Me.MenuItem240.Text = "Sales Performance Direct YTD"
        '
        'MenuItem241
        '
        Me.MenuItem241.Index = 1
        Me.MenuItem241.Text = "Sales Performance Direct MAT"
        '
        'MenuItem165
        '
        Me.MenuItem165.Index = 9
        Me.MenuItem165.Text = "Sales and Marketing Incentive"
        '
        'MenuItem242
        '
        Me.MenuItem242.Index = 10
        Me.MenuItem242.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem162, Me.MenuItem192, Me.MenuItem243, Me.MenuItem197, Me.MenuItem244})
        Me.MenuItem242.Text = "Sales Trend"
        '
        'MenuItem162
        '
        Me.MenuItem162.Index = 0
        Me.MenuItem162.Text = "Sales Trend Direct"
        '
        'MenuItem192
        '
        Me.MenuItem192.Index = 1
        Me.MenuItem192.Text = "Sales Trend Direct MAT"
        '
        'MenuItem243
        '
        Me.MenuItem243.Index = 2
        Me.MenuItem243.Text = "Sales Trend Direct MAT Ver 10"
        '
        'MenuItem197
        '
        Me.MenuItem197.Index = 3
        Me.MenuItem197.Text = "Sales Trend Direct YTD Ver 9"
        '
        'MenuItem244
        '
        Me.MenuItem244.Index = 4
        Me.MenuItem244.Text = "Sales Trend Direct YTD Ver 10"
        '
        'MenuItem174
        '
        Me.MenuItem174.Index = 3
        Me.MenuItem174.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem175})
        Me.MenuItem174.Text = "Integrated Sales"
        '
        'MenuItem175
        '
        Me.MenuItem175.Index = 0
        Me.MenuItem175.Text = "Integrated Sales"
        '
        'MenuItem176
        '
        Me.MenuItem176.Index = 4
        Me.MenuItem176.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem177, Me.MenuItem178, Me.MenuItem181, Me.MenuItem182, Me.MenuItem238, Me.MenuItem248})
        Me.MenuItem176.Text = "Maintenance"
        '
        'MenuItem177
        '
        Me.MenuItem177.Index = 0
        Me.MenuItem177.Text = "Area - AreaPMR"
        '
        'MenuItem178
        '
        Me.MenuItem178.Index = 1
        Me.MenuItem178.Text = "District - ArePMR"
        '
        'MenuItem181
        '
        Me.MenuItem181.Index = 2
        Me.MenuItem181.Text = "Segment-Segment Head"
        '
        'MenuItem182
        '
        Me.MenuItem182.Index = 3
        Me.MenuItem182.Text = "Brand-Brand Manager"
        '
        'MenuItem238
        '
        Me.MenuItem238.Index = 4
        Me.MenuItem238.Text = "Update Resigned Specialist"
        '
        'MenuItem248
        '
        Me.MenuItem248.Index = 5
        Me.MenuItem248.Text = "Update Resigned TM"
        '
        'MenuItem226
        '
        Me.MenuItem226.Index = 5
        Me.MenuItem226.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem227, Me.MenuItem230})
        Me.MenuItem226.Text = "Mercury Sales"
        '
        'MenuItem227
        '
        Me.MenuItem227.Index = 0
        Me.MenuItem227.Text = "Transfer Mercury Sales to SP"
        '
        'MenuItem230
        '
        Me.MenuItem230.Index = 1
        Me.MenuItem230.Text = "Transfer Mercury Sales to TS SP"
        '
        'MenuItem152
        '
        Me.MenuItem152.Index = 6
        Me.MenuItem152.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem154, Me.MenuItem153, Me.MenuItem155})
        Me.MenuItem152.Text = "Sales and Inventory Updates"
        '
        'MenuItem154
        '
        Me.MenuItem154.Index = 0
        Me.MenuItem154.Text = "Daily Sales Update Utility"
        '
        'MenuItem153
        '
        Me.MenuItem153.Index = 1
        Me.MenuItem153.Text = "Generate NMPC Sales  Update Excel"
        '
        'MenuItem155
        '
        Me.MenuItem155.Index = 2
        Me.MenuItem155.Text = "Generate Invoice List Excel"
        '
        'MenuItem179
        '
        Me.MenuItem179.Index = 7
        Me.MenuItem179.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem193, Me.MenuItem207, Me.MenuItem199, Me.MenuItem191, Me.MenuItem245, Me.MenuItem250})
        Me.MenuItem179.Text = "Stock Transfer Report"
        '
        'MenuItem193
        '
        Me.MenuItem193.Index = 0
        Me.MenuItem193.Text = "Customer Reach Analysis Stock Transfer 2013"
        '
        'MenuItem207
        '
        Me.MenuItem207.Index = 1
        Me.MenuItem207.Text = "Extract PDF(BOIE)"
        '
        'MenuItem199
        '
        Me.MenuItem199.Index = 2
        Me.MenuItem199.Text = "Item Sales Report"
        '
        'MenuItem191
        '
        Me.MenuItem191.Index = 3
        Me.MenuItem191.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem186, Me.MenuItem187, Me.MenuItem190, Me.MenuItem185, Me.MenuItem188, Me.MenuItem189, Me.MenuItem195, Me.MenuItem201})
        Me.MenuItem191.Text = "Sales Performance"
        '
        'MenuItem186
        '
        Me.MenuItem186.Index = 0
        Me.MenuItem186.Text = "Sales Performance Specialist Award"
        '
        'MenuItem187
        '
        Me.MenuItem187.Index = 1
        Me.MenuItem187.Text = "Sales Performance TM Award"
        '
        'MenuItem190
        '
        Me.MenuItem190.Index = 2
        Me.MenuItem190.Text = "Sales Performance TM SP MAT"
        '
        'MenuItem185
        '
        Me.MenuItem185.Index = 3
        Me.MenuItem185.Text = "Sales Performance TM SP YTD"
        '
        'MenuItem188
        '
        Me.MenuItem188.Index = 4
        Me.MenuItem188.Text = "Sales Performance Trade Specialist Award"
        '
        'MenuItem189
        '
        Me.MenuItem189.Index = 5
        Me.MenuItem189.Text = "Sales Performanace Trade TM Award"
        '
        'MenuItem195
        '
        Me.MenuItem195.Index = 6
        Me.MenuItem195.Text = "Sales Performance TM SP Trade YTD Invisible"
        Me.MenuItem195.Visible = False
        '
        'MenuItem201
        '
        Me.MenuItem201.Index = 7
        Me.MenuItem201.Text = "Sales Performance TM SP Trade Month"
        '
        'MenuItem245
        '
        Me.MenuItem245.Index = 4
        Me.MenuItem245.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem180, Me.MenuItem198, Me.MenuItem196, Me.MenuItem246})
        Me.MenuItem245.Text = "Sales Trend"
        '
        'MenuItem180
        '
        Me.MenuItem180.Index = 0
        Me.MenuItem180.Text = "Sales Trend"
        '
        'MenuItem198
        '
        Me.MenuItem198.Index = 1
        Me.MenuItem198.Text = "Sales Trend Stock Transfer MAT"
        '
        'MenuItem196
        '
        Me.MenuItem196.Index = 2
        Me.MenuItem196.Text = "Sales Trend Trade"
        '
        'MenuItem246
        '
        Me.MenuItem246.Index = 3
        Me.MenuItem246.Text = "Sales Trend YTD Ver 10"
        '
        'MenuItem250
        '
        Me.MenuItem250.Index = 5
        Me.MenuItem250.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem251})
        Me.MenuItem250.Text = "Sales and Targets"
        '
        'MenuItem251
        '
        Me.MenuItem251.Index = 0
        Me.MenuItem251.Text = "Sales and Targets"
        '
        'MenuItem168
        '
        Me.MenuItem168.Index = 8
        Me.MenuItem168.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem170, Me.MenuItem171, Me.MenuItem169, Me.MenuItem173, Me.MenuItem221, Me.MenuItem219, Me.MenuItem172, Me.MenuItem220})
        Me.MenuItem168.Text = "Sub Distributor"
        '
        'MenuItem170
        '
        Me.MenuItem170.Index = 0
        Me.MenuItem170.Text = "BarrXsel"
        '
        'MenuItem171
        '
        Me.MenuItem171.Index = 1
        Me.MenuItem171.Text = "GB"
        '
        'MenuItem169
        '
        Me.MenuItem169.Index = 2
        Me.MenuItem169.Text = "Globo Asiatech"
        '
        'MenuItem173
        '
        Me.MenuItem173.Index = 3
        Me.MenuItem173.Text = "Pharma 518 Trading"
        '
        'MenuItem221
        '
        Me.MenuItem221.Index = 4
        Me.MenuItem221.Text = "Pharma 518 Trading New"
        '
        'MenuItem219
        '
        Me.MenuItem219.Index = 5
        Me.MenuItem219.Text = "Rose Pharmacy(New)"
        '
        'MenuItem172
        '
        Me.MenuItem172.Index = 6
        Me.MenuItem172.Text = "South Star Drug(Old)"
        Me.MenuItem172.Visible = False
        '
        'MenuItem220
        '
        Me.MenuItem220.Index = 7
        Me.MenuItem220.Text = "South Star Drug"
        '
        'MenuItem223
        '
        Me.MenuItem223.Index = 9
        Me.MenuItem223.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem224})
        Me.MenuItem223.Text = "Reports"
        '
        'MenuItem224
        '
        Me.MenuItem224.Index = 0
        Me.MenuItem224.Text = "Segment Supervisor Specialist"
        '
        'mnuFileMaintenane
        '
        Me.mnuFileMaintenane.Index = 2
        Me.mnuFileMaintenane.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnu_Company, Me.mnu_District, Me.MenuItem79, Me.MenuItem111, Me.MenuItem86, Me.MenuItem84, Me.MenuItem83, Me.MenuItem44, Me.MenuItem135, Me.MenuItem134, Me.MenuItem12, Me.MenuItem98, Me.MenuItem72, Me.MenuItem74, Me.MenuItem78, Me.ExtCustZue, Me.MenuItem87, Me.MenuItem130, Me.MenuItem75, Me.MenuItem43, Me.MenuItem137, Me.MenuItem141, Me.MenuItem138, Me.MenuItem139, Me.MenuItem140, Me.MenuItem131, Me.MenuItem11, Me.MenuItem132, Me.MenuItem133, Me.MenuItem15, Me.MenuItem237})
        Me.mnuFileMaintenane.Text = "File Maintenance"
        '
        'mnu_Company
        '
        Me.mnu_Company.Index = 0
        Me.mnu_Company.Text = "Company"
        '
        'mnu_District
        '
        Me.mnu_District.Index = 1
        Me.mnu_District.Text = "District"
        '
        'MenuItem79
        '
        Me.MenuItem79.Index = 2
        Me.MenuItem79.Text = "District Team Manager Maintenance"
        '
        'MenuItem111
        '
        Me.MenuItem111.Index = 3
        Me.MenuItem111.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnu_MHmrarea})
        Me.MenuItem111.Text = "My.Health"
        '
        'mnu_MHmrarea
        '
        Me.mnu_MHmrarea.Index = 0
        Me.mnu_MHmrarea.Text = "Specialist Territory Assignment"
        '
        'MenuItem86
        '
        Me.MenuItem86.Index = 4
        Me.MenuItem86.Text = "Product Manager"
        '
        'MenuItem84
        '
        Me.MenuItem84.Index = 5
        Me.MenuItem84.Text = "Team Segment"
        '
        'MenuItem83
        '
        Me.MenuItem83.Index = 6
        Me.MenuItem83.Text = "Territory Area Maintenance"
        '
        'MenuItem44
        '
        Me.MenuItem44.Index = 7
        Me.MenuItem44.Text = "User Maintenance"
        '
        'MenuItem135
        '
        Me.MenuItem135.Index = 8
        Me.MenuItem135.Text = "-"
        '
        'MenuItem134
        '
        Me.MenuItem134.Index = 9
        Me.MenuItem134.Text = "Call Rate Budget"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 10
        Me.MenuItem12.Text = "Call Rate Transactions"
        '
        'MenuItem98
        '
        Me.MenuItem98.Index = 11
        Me.MenuItem98.Text = "-"
        '
        'MenuItem72
        '
        Me.MenuItem72.Index = 12
        Me.MenuItem72.Text = "Customer"
        '
        'MenuItem74
        '
        Me.MenuItem74.Index = 13
        Me.MenuItem74.Text = "Customer Type"
        '
        'MenuItem78
        '
        Me.MenuItem78.Index = 14
        Me.MenuItem78.Text = "Excluded Customer"
        '
        'ExtCustZue
        '
        Me.ExtCustZue.Index = 15
        Me.ExtCustZue.Text = "Excluded Customers of Zuelig"
        '
        'MenuItem87
        '
        Me.MenuItem87.Index = 16
        Me.MenuItem87.Text = "Territory"
        '
        'MenuItem130
        '
        Me.MenuItem130.Index = 17
        Me.MenuItem130.Text = "Province"
        '
        'MenuItem75
        '
        Me.MenuItem75.Index = 18
        Me.MenuItem75.Text = "Group"
        '
        'MenuItem43
        '
        Me.MenuItem43.Index = 19
        Me.MenuItem43.Text = "-"
        '
        'MenuItem137
        '
        Me.MenuItem137.Index = 20
        Me.MenuItem137.Text = "Item"
        '
        'MenuItem141
        '
        Me.MenuItem141.Index = 21
        Me.MenuItem141.Text = "Segment"
        '
        'MenuItem138
        '
        Me.MenuItem138.Index = 22
        Me.MenuItem138.Text = "Product Line"
        '
        'MenuItem139
        '
        Me.MenuItem139.Index = 23
        Me.MenuItem139.Text = "Product Form"
        '
        'MenuItem140
        '
        Me.MenuItem140.Index = 24
        Me.MenuItem140.Text = "Principal"
        '
        'MenuItem131
        '
        Me.MenuItem131.Index = 25
        Me.MenuItem131.Text = "-"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 26
        Me.MenuItem11.Text = "Specialist Territory Assignment"
        '
        'MenuItem132
        '
        Me.MenuItem132.Index = 27
        Me.MenuItem132.Text = "Specialist"
        '
        'MenuItem133
        '
        Me.MenuItem133.Index = 28
        Me.MenuItem133.Text = "Team Manager"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 29
        Me.MenuItem15.Text = "Segment Head"
        '
        'MenuItem237
        '
        Me.MenuItem237.Index = 30
        Me.MenuItem237.Text = "Sales and Marketing Incentive Template"
        '
        'mnu_Reports
        '
        Me.mnu_Reports.Index = 3
        Me.mnu_Reports.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnu_DistributeReports, Me.MenuItem17, Me.MenuItem18, Me.MenuItem231, Me.MenuItem122, Me.MenuItem13, Me.MenuItem115, Me.MenuItem113, Me.MenuItem110, Me.MenuItem16, Me.MenuItem19, Me.MenuItem7, Me.MenuItem46, Me.MenuItem47, Me.MenuItem52, Me.MenuItem48, Me.MenuItem49, Me.MenuItem51, Me.MenuItem53, Me.MenuItem54, Me.MenuItem62, Me.MenuItem63, Me.MenuItem91, Me.mnuMercBranAct})
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
        Me.MenuItem17.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnu_MdiPerMedrep, Me.MenuItem120, Me.mnu_MercurySales, Me.MenuItem121, Me.mnu_MdiPerMedrepUntagged, Me.Mnu_CommissionAttachment, Me.Mnu_CommissionAttachment2009, Me.MenuItem148, Me.MenuItem215, Me.Mnu_MedrepCommission, Me.Mnu_MedrepCommissionWithRecovery, Me.MenuItem103, Me.Mnu_MedrepCommissionWithRecovery2009, Me.mnu_YTD, Me.mnu_YTDpush, Me.Mnu_MedrepCommissionWithRecovery2010, Me.Mnu_MedrepCommissionWithRecovery2010BioM, Me.Mnu_MedrepCommissionWithRecovery2011, Me.Mnu_MedrepCommissionWithRecovery2012, Me.Mnu_MedrepCommissionWithRecovery2013, Me.MenuItem147, Me.MenuItem216, Me.MenuItem247})
        Me.MenuItem17.Text = "Specialist"
        '
        'mnu_MdiPerMedrep
        '
        Me.mnu_MdiPerMedrep.Index = 0
        Me.mnu_MdiPerMedrep.Text = "Sales per Medical Representative"
        '
        'MenuItem120
        '
        Me.MenuItem120.Index = 1
        Me.MenuItem120.Text = "Sales per Medical Representative(Trade)"
        '
        'mnu_MercurySales
        '
        Me.mnu_MercurySales.Index = 2
        Me.mnu_MercurySales.Text = "Mercury Sales Per Medical Representative"
        '
        'MenuItem121
        '
        Me.MenuItem121.Index = 3
        Me.MenuItem121.Text = "Mercury Sales Per Medical Representative(Trade)"
        '
        'mnu_MdiPerMedrepUntagged
        '
        Me.mnu_MdiPerMedrepUntagged.Index = 4
        Me.mnu_MdiPerMedrepUntagged.Text = "Sales per Medical Representative(Untagged)"
        '
        'Mnu_CommissionAttachment
        '
        Me.Mnu_CommissionAttachment.Index = 5
        Me.Mnu_CommissionAttachment.Text = "Commission Report Attachment 2008 - Below"
        '
        'Mnu_CommissionAttachment2009
        '
        Me.Mnu_CommissionAttachment2009.Index = 6
        Me.Mnu_CommissionAttachment2009.Text = "Commission Report Attachment 2009-2013"
        '
        'MenuItem148
        '
        Me.MenuItem148.Index = 7
        Me.MenuItem148.Text = "Commission Report Attachment 2014"
        '
        'MenuItem215
        '
        Me.MenuItem215.Index = 8
        Me.MenuItem215.Text = "Commission Report Attachment 2015"
        '
        'Mnu_MedrepCommission
        '
        Me.Mnu_MedrepCommission.Index = 9
        Me.Mnu_MedrepCommission.Text = "Medrep Commission"
        '
        'Mnu_MedrepCommissionWithRecovery
        '
        Me.Mnu_MedrepCommissionWithRecovery.Index = 10
        Me.Mnu_MedrepCommissionWithRecovery.Text = "Medrep Commission with Recovery 2006-2007"
        '
        'MenuItem103
        '
        Me.MenuItem103.Index = 11
        Me.MenuItem103.Text = "MedRep Commision with Recovery 2008"
        '
        'Mnu_MedrepCommissionWithRecovery2009
        '
        Me.Mnu_MedrepCommissionWithRecovery2009.Index = 12
        Me.Mnu_MedrepCommissionWithRecovery2009.Text = "MedRep Commision with Recovery 2009"
        '
        'mnu_YTD
        '
        Me.mnu_YTD.Index = 13
        Me.mnu_YTD.Text = "MedRep Year End Report"
        '
        'mnu_YTDpush
        '
        Me.mnu_YTDpush.Index = 14
        Me.mnu_YTDpush.Text = "MedRep Year End Push Report"
        '
        'Mnu_MedrepCommissionWithRecovery2010
        '
        Me.Mnu_MedrepCommissionWithRecovery2010.Index = 15
        Me.Mnu_MedrepCommissionWithRecovery2010.Text = "MedRep Commission with Recovery 2010 (Jan-Dec 2010)"
        '
        'Mnu_MedrepCommissionWithRecovery2010BioM
        '
        Me.Mnu_MedrepCommissionWithRecovery2010BioM.Index = 16
        Me.Mnu_MedrepCommissionWithRecovery2010BioM.Text = "MedRep Commission with Recovery: Uro effective Aug-Oct 2010"
        '
        'Mnu_MedrepCommissionWithRecovery2011
        '
        Me.Mnu_MedrepCommissionWithRecovery2011.Index = 17
        Me.Mnu_MedrepCommissionWithRecovery2011.Text = "MedRep Commission with Recovery 2011 (Jan 2011-Nov2011)"
        '
        'Mnu_MedrepCommissionWithRecovery2012
        '
        Me.Mnu_MedrepCommissionWithRecovery2012.Index = 18
        Me.Mnu_MedrepCommissionWithRecovery2012.Text = "MedRep Commission with Recovery 2012 (Dec2011- Dec2012)"
        '
        'Mnu_MedrepCommissionWithRecovery2013
        '
        Me.Mnu_MedrepCommissionWithRecovery2013.Index = 19
        Me.Mnu_MedrepCommissionWithRecovery2013.Text = "MedRep Commission with Recovery 2013 (Jan2013 - Dec2013)"
        '
        'MenuItem147
        '
        Me.MenuItem147.Index = 20
        Me.MenuItem147.Text = "MedRep Commission with Recovery 2014(Jan2014 - Dec2014)"
        '
        'MenuItem216
        '
        Me.MenuItem216.Index = 21
        Me.MenuItem216.Text = "MedRep Commission with Recovery 2014(Jan2015 - Dec2015)"
        '
        'MenuItem247
        '
        Me.MenuItem247.Index = 22
        Me.MenuItem247.Text = "Medrep Commission with Recovery(Combi 2015)"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 2
        Me.MenuItem18.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Mnu_CommissionAttachmentDM, Me.Mnu_CommissionAttachmentDM2009, Me.Mnu_SupervisorCommission, Me.Mnu_DistrictManagerCommissionWithRecovery, Me.Mnu_DistrictManagerCommissionWithRecovery2008, Me.Mnu_DistrictManagerCommissionWithRecovery2009, Me.mnu_YTDdsm, Me.mnu_YTDpushDSM, Me.Mnu_DistrictManagerCommissionWithRecovery2010, Me.Mnu_DistrictManagerCommissionWithRecovery2010Biomedica, Me.Mnu_DistrictManagerCommissionWithRecovery2011, Me.Mnu_DistrictManagerCommissionWithRecovery2012, Me.Mnu_DistrictManagerCommissionWithRecovery2013, Me.MenuItem149, Me.MenuItem222})
        Me.MenuItem18.Text = "Team Manager"
        '
        'Mnu_CommissionAttachmentDM
        '
        Me.Mnu_CommissionAttachmentDM.Index = 0
        Me.Mnu_CommissionAttachmentDM.Text = "Commission Report Attachment (DSM) 2008"
        '
        'Mnu_CommissionAttachmentDM2009
        '
        Me.Mnu_CommissionAttachmentDM2009.Index = 1
        Me.Mnu_CommissionAttachmentDM2009.Text = "Commission Report Attachment (TM) "
        '
        'Mnu_SupervisorCommission
        '
        Me.Mnu_SupervisorCommission.Index = 2
        Me.Mnu_SupervisorCommission.Text = "District Manager Commission"
        '
        'Mnu_DistrictManagerCommissionWithRecovery
        '
        Me.Mnu_DistrictManagerCommissionWithRecovery.Index = 3
        Me.Mnu_DistrictManagerCommissionWithRecovery.Text = "District Manager Commission with Recovery 2006-2007"
        '
        'Mnu_DistrictManagerCommissionWithRecovery2008
        '
        Me.Mnu_DistrictManagerCommissionWithRecovery2008.Index = 4
        Me.Mnu_DistrictManagerCommissionWithRecovery2008.Text = "District Manager Commission with Recovery 2008"
        '
        'Mnu_DistrictManagerCommissionWithRecovery2009
        '
        Me.Mnu_DistrictManagerCommissionWithRecovery2009.Index = 5
        Me.Mnu_DistrictManagerCommissionWithRecovery2009.Text = "District Manager Commission with Recovery 2009"
        '
        'mnu_YTDdsm
        '
        Me.mnu_YTDdsm.Index = 6
        Me.mnu_YTDdsm.Text = "District Manager Year End Report"
        '
        'mnu_YTDpushDSM
        '
        Me.mnu_YTDpushDSM.Index = 7
        Me.mnu_YTDpushDSM.Text = "District Manager Year End Push Report"
        '
        'Mnu_DistrictManagerCommissionWithRecovery2010
        '
        Me.Mnu_DistrictManagerCommissionWithRecovery2010.Index = 8
        Me.Mnu_DistrictManagerCommissionWithRecovery2010.Text = "District Manager Commission with Recovery 2010 (Jan-Dec 2010)"
        '
        'Mnu_DistrictManagerCommissionWithRecovery2010Biomedica
        '
        Me.Mnu_DistrictManagerCommissionWithRecovery2010Biomedica.Index = 9
        Me.Mnu_DistrictManagerCommissionWithRecovery2010Biomedica.Text = "District Manager Commission with Recovery: Uro effective Aug-Oct 2010"
        '
        'Mnu_DistrictManagerCommissionWithRecovery2011
        '
        Me.Mnu_DistrictManagerCommissionWithRecovery2011.Index = 10
        Me.Mnu_DistrictManagerCommissionWithRecovery2011.Text = "District Manager Commission with Recovery 2011 (Jan-Nov 2011)"
        '
        'Mnu_DistrictManagerCommissionWithRecovery2012
        '
        Me.Mnu_DistrictManagerCommissionWithRecovery2012.Index = 11
        Me.Mnu_DistrictManagerCommissionWithRecovery2012.Text = "District Manager Commission with Recovery 2012 (Dec 2012)"
        '
        'Mnu_DistrictManagerCommissionWithRecovery2013
        '
        Me.Mnu_DistrictManagerCommissionWithRecovery2013.Index = 12
        Me.Mnu_DistrictManagerCommissionWithRecovery2013.Text = "District Manager Commission with Recovery 2013 (Jan-Dec 2013)"
        '
        'MenuItem149
        '
        Me.MenuItem149.Index = 13
        Me.MenuItem149.Text = "Team Manager Commission with Recovery 2013 (Jan-Dec 2014)"
        '
        'MenuItem222
        '
        Me.MenuItem222.Index = 14
        Me.MenuItem222.Text = "Team Manager Commission with Recovery 2015 (Jan-Dec 2015)"
        '
        'MenuItem231
        '
        Me.MenuItem231.Index = 3
        Me.MenuItem231.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem232, Me.MenuItem234, Me.MenuItem233, Me.MenuItem236, Me.MenuItem235})
        Me.MenuItem231.Text = "Sales and Marketing Managers"
        '
        'MenuItem232
        '
        Me.MenuItem232.Index = 0
        Me.MenuItem232.Text = "1. SM Manager Sales Performance"
        '
        'MenuItem234
        '
        Me.MenuItem234.Index = 1
        Me.MenuItem234.Text = "2. SM ASP Computation"
        '
        'MenuItem233
        '
        Me.MenuItem233.Index = 2
        Me.MenuItem233.Text = "3. TM Hitting Target"
        '
        'MenuItem236
        '
        Me.MenuItem236.Index = 3
        Me.MenuItem236.Text = "4. SM Manager Incentive Computation Summary Long"
        '
        'MenuItem235
        '
        Me.MenuItem235.Index = 4
        Me.MenuItem235.Text = "5. SM Manager Incentive Computation"
        '
        'MenuItem122
        '
        Me.MenuItem122.Index = 4
        Me.MenuItem122.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem123, Me.MenuItem124, Me.MenuItem125})
        Me.MenuItem122.Text = "Key Accounts Specialist - Government"
        '
        'MenuItem123
        '
        Me.MenuItem123.Index = 0
        Me.MenuItem123.Text = "Sales Per Key Accounts Specialist - Govt"
        '
        'MenuItem124
        '
        Me.MenuItem124.Index = 1
        Me.MenuItem124.Text = "Commission Attachment KAS - Govt"
        '
        'MenuItem125
        '
        Me.MenuItem125.Index = 2
        Me.MenuItem125.Text = "Commission Computation KAS - Govt"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 5
        Me.MenuItem13.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem109, Me.MenuItem14, Me.MenuItem105})
        Me.MenuItem13.Text = "Chiral Reports"
        '
        'MenuItem109
        '
        Me.MenuItem109.Index = 0
        Me.MenuItem109.Text = "Distribute Sales and Commission Reports"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 1
        Me.MenuItem14.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem106, Me.MenuItem107, Me.Mnu_MedrepCommissionQX2008, Me.Mnu_MedrepCommissionChiral2009, Me.MenuItem112})
        Me.MenuItem14.Text = "Professional Medical Representatvie"
        '
        'MenuItem106
        '
        Me.MenuItem106.Index = 0
        Me.MenuItem106.Text = "Commission Report Attachment 2008"
        '
        'MenuItem107
        '
        Me.MenuItem107.Index = 1
        Me.MenuItem107.Text = "Commission Report Attachment 2009-2010"
        '
        'Mnu_MedrepCommissionQX2008
        '
        Me.Mnu_MedrepCommissionQX2008.Index = 2
        Me.Mnu_MedrepCommissionQX2008.Text = "MedRep Commission 2008"
        '
        'Mnu_MedrepCommissionChiral2009
        '
        Me.Mnu_MedrepCommissionChiral2009.Index = 3
        Me.Mnu_MedrepCommissionChiral2009.Text = "Medrep Commission 2009"
        '
        'MenuItem112
        '
        Me.MenuItem112.Index = 4
        Me.MenuItem112.Text = "MedRep Commission 2010"
        '
        'MenuItem105
        '
        Me.MenuItem105.Index = 2
        Me.MenuItem105.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Mnu_CommissionAttachmentDSM2008Chiral, Me.Mnu_CommissionAttachmentDSM2009Chiral, Me.Mnu_DistrictManagerCommission2008QX, Me.Mnu_DistrictManagerCommission2009Chiral, Me.Mnu_DistrictManagerCommission2010Chiral})
        Me.MenuItem105.Text = "District Sales Manager"
        '
        'Mnu_CommissionAttachmentDSM2008Chiral
        '
        Me.Mnu_CommissionAttachmentDSM2008Chiral.Index = 0
        Me.Mnu_CommissionAttachmentDSM2008Chiral.Text = "Commission Report Attachment 2008"
        '
        'Mnu_CommissionAttachmentDSM2009Chiral
        '
        Me.Mnu_CommissionAttachmentDSM2009Chiral.Index = 1
        Me.Mnu_CommissionAttachmentDSM2009Chiral.Text = "Commission Report Attachment 2009-2010"
        '
        'Mnu_DistrictManagerCommission2008QX
        '
        Me.Mnu_DistrictManagerCommission2008QX.Index = 2
        Me.Mnu_DistrictManagerCommission2008QX.Text = "District Manager Commission 2008"
        '
        'Mnu_DistrictManagerCommission2009Chiral
        '
        Me.Mnu_DistrictManagerCommission2009Chiral.Index = 3
        Me.Mnu_DistrictManagerCommission2009Chiral.Text = "District Manager Commission 2009"
        '
        'Mnu_DistrictManagerCommission2010Chiral
        '
        Me.Mnu_DistrictManagerCommission2010Chiral.Index = 4
        Me.Mnu_DistrictManagerCommission2010Chiral.Text = "District Manager Commission 2010"
        '
        'MenuItem115
        '
        Me.MenuItem115.Index = 6
        Me.MenuItem115.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem116, Me.MenuItem118})
        Me.MenuItem115.Text = "Floaters Reports"
        '
        'MenuItem116
        '
        Me.MenuItem116.Index = 0
        Me.MenuItem116.Text = "Distribute Sales and Commission Reports"
        '
        'MenuItem118
        '
        Me.MenuItem118.Index = 1
        Me.MenuItem118.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnu_MdiPerMedrepFLT, Me.mnu_MercurySalesFLT, Me.Mnu_CommissionAttachmentFLT, Me.Mnu_MedrepCommissionWithRecoveryFLT})
        Me.MenuItem118.Text = "Floaters Professional Medical Representatvie"
        '
        'mnu_MdiPerMedrepFLT
        '
        Me.mnu_MdiPerMedrepFLT.Index = 0
        Me.mnu_MdiPerMedrepFLT.Text = "Sales per Medical Representative"
        '
        'mnu_MercurySalesFLT
        '
        Me.mnu_MercurySalesFLT.Index = 1
        Me.mnu_MercurySalesFLT.Text = "Mercury Sales Per Medical Representative"
        '
        'Mnu_CommissionAttachmentFLT
        '
        Me.Mnu_CommissionAttachmentFLT.Index = 2
        Me.Mnu_CommissionAttachmentFLT.Text = "Commission Report Attachment 2010"
        '
        'Mnu_MedrepCommissionWithRecoveryFLT
        '
        Me.Mnu_MedrepCommissionWithRecoveryFLT.Index = 3
        Me.Mnu_MedrepCommissionWithRecoveryFLT.Text = "MedRep Commission with Recovery 2010"
        '
        'MenuItem113
        '
        Me.MenuItem113.Index = 7
        Me.MenuItem113.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnu_DistributeReportsMH, Me.MenuItem114, Me.MenuItem117})
        Me.MenuItem113.Text = "Health Harmony, Inc. Reports"
        '
        'mnu_DistributeReportsMH
        '
        Me.mnu_DistributeReportsMH.Index = 0
        Me.mnu_DistributeReportsMH.Text = "Distribute Sales and Commission Reports"
        '
        'MenuItem114
        '
        Me.MenuItem114.Index = 1
        Me.MenuItem114.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnu_MDIperBDS, Me.mnu_MercurySalesBDS, Me.Mnu_CommissionAttachmentMH, Me.Mnu_MedrepCommissionWithRecoveryMH})
        Me.MenuItem114.Text = "Business Development Specialist"
        '
        'mnu_MDIperBDS
        '
        Me.mnu_MDIperBDS.Index = 0
        Me.mnu_MDIperBDS.Text = "Sales per BDS"
        '
        'mnu_MercurySalesBDS
        '
        Me.mnu_MercurySalesBDS.Index = 1
        Me.mnu_MercurySalesBDS.Text = "Mercury Sales per BDS"
        '
        'Mnu_CommissionAttachmentMH
        '
        Me.Mnu_CommissionAttachmentMH.Index = 2
        Me.Mnu_CommissionAttachmentMH.Text = "Commiision Report Attachment 2010"
        '
        'Mnu_MedrepCommissionWithRecoveryMH
        '
        Me.Mnu_MedrepCommissionWithRecoveryMH.Index = 3
        Me.Mnu_MedrepCommissionWithRecoveryMH.Text = "BDS Commission with Recovery 2010"
        '
        'MenuItem117
        '
        Me.MenuItem117.Index = 2
        Me.MenuItem117.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Mnu_DSMCommissionAttachmentMH, Me.Mnu_DSMCommissionWithRecoveryMH})
        Me.MenuItem117.Text = "District Sales Manager"
        Me.MenuItem117.Visible = False
        '
        'Mnu_DSMCommissionAttachmentMH
        '
        Me.Mnu_DSMCommissionAttachmentMH.Index = 0
        Me.Mnu_DSMCommissionAttachmentMH.Text = "Commission Report Attachment 2010"
        '
        'Mnu_DSMCommissionWithRecoveryMH
        '
        Me.Mnu_DSMCommissionWithRecoveryMH.Index = 1
        Me.Mnu_DSMCommissionWithRecoveryMH.Text = "District Manager Commission with Recovery 2010"
        '
        'MenuItem110
        '
        Me.MenuItem110.Index = 8
        Me.MenuItem110.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnu_MdiPerMedrepMTD, Me.Mnu_CommissionAttachmentMTD2009, Me.Mnu_MedrepCommissionWithRecovery2009MTD})
        Me.MenuItem110.Text = "Modern Trade"
        '
        'mnu_MdiPerMedrepMTD
        '
        Me.mnu_MdiPerMedrepMTD.Index = 0
        Me.mnu_MdiPerMedrepMTD.Text = "ModernTrade Sales per Medical Representative"
        '
        'Mnu_CommissionAttachmentMTD2009
        '
        Me.Mnu_CommissionAttachmentMTD2009.Index = 1
        Me.Mnu_CommissionAttachmentMTD2009.Text = "Commission Report Attachment 2009 MTD"
        '
        'Mnu_MedrepCommissionWithRecovery2009MTD
        '
        Me.Mnu_MedrepCommissionWithRecovery2009MTD.Index = 2
        Me.Mnu_MedrepCommissionWithRecovery2009MTD.Text = "MedRep Commision with Recovery 2009 MTD"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 9
        Me.MenuItem16.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Mnu_QpiPerTerritory, Me.Mnu_QpiMercurySales, Me.MenuItem66})
        Me.MenuItem16.Text = "Qpi Reports"
        Me.MenuItem16.Visible = False
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
        Me.MenuItem19.Index = 10
        Me.MenuItem19.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Mnu_HiiPerTerritory, Me.Mnu_HiiMercurySales})
        Me.MenuItem19.Text = "Hii Reports"
        Me.MenuItem19.Visible = False
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
        Me.MenuItem7.Index = 11
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
        Me.MenuItem46.Index = 12
        Me.MenuItem46.Text = "Ct Sales"
        Me.MenuItem46.Visible = False
        '
        'MenuItem47
        '
        Me.MenuItem47.Index = 13
        Me.MenuItem47.Text = "Ct Sales Ytd"
        Me.MenuItem47.Visible = False
        '
        'MenuItem52
        '
        Me.MenuItem52.Index = 14
        Me.MenuItem52.Text = "-"
        '
        'MenuItem48
        '
        Me.MenuItem48.Index = 15
        Me.MenuItem48.Text = "Monthly Performance Report with Rank - PMR"
        '
        'MenuItem49
        '
        Me.MenuItem49.Index = 16
        Me.MenuItem49.Text = "Monthly Performance Report with Rank - DSM"
        '
        'MenuItem51
        '
        Me.MenuItem51.Index = 17
        Me.MenuItem51.Text = "-"
        '
        'MenuItem53
        '
        Me.MenuItem53.Index = 18
        Me.MenuItem53.Text = "Calenderized Performance Report with Rank - PMR"
        '
        'MenuItem54
        '
        Me.MenuItem54.Index = 19
        Me.MenuItem54.Text = "Calenderized Performance Report with Rank - DSM"
        '
        'MenuItem62
        '
        Me.MenuItem62.Index = 20
        Me.MenuItem62.Text = "-"
        '
        'MenuItem63
        '
        Me.MenuItem63.Index = 21
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
        Me.MenuItem91.Index = 22
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
        'mnuMercBranAct
        '
        Me.mnuMercBranAct.Index = 23
        Me.mnuMercBranAct.Text = "Active Mercury Branches"
        '
        'MenuItem208
        '
        Me.MenuItem208.Index = 4
        Me.MenuItem208.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem209, Me.MenuItem210})
        Me.MenuItem208.Text = "Reports 2015"
        Me.MenuItem208.Visible = False
        '
        'MenuItem209
        '
        Me.MenuItem209.Index = 0
        Me.MenuItem209.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem211, Me.MenuItem212, Me.MenuItem213, Me.MenuItem214})
        Me.MenuItem209.Text = "Specialist"
        '
        'MenuItem211
        '
        Me.MenuItem211.Index = 0
        Me.MenuItem211.Text = "1. Sales Per Medical Representative"
        '
        'MenuItem212
        '
        Me.MenuItem212.Index = 1
        Me.MenuItem212.Text = "2. Sales per Medical Representative(Trade)"
        '
        'MenuItem213
        '
        Me.MenuItem213.Index = 2
        Me.MenuItem213.Text = "3. Mercury Sales Per Medical Representative"
        '
        'MenuItem214
        '
        Me.MenuItem214.Index = 3
        Me.MenuItem214.Text = "4. Mercury Sales Per Medical Representative(Trade)"
        '
        'MenuItem210
        '
        Me.MenuItem210.Index = 1
        Me.MenuItem210.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem217, Me.MenuItem218})
        Me.MenuItem210.Text = "Team Manager"
        '
        'MenuItem217
        '
        Me.MenuItem217.Index = 0
        Me.MenuItem217.Text = "1. Commission Report Attachment (TM) "
        '
        'MenuItem218
        '
        Me.MenuItem218.Index = 1
        Me.MenuItem218.Text = "2. Team Manager Commission with Recovery 2015 (Jan-Dec 2015)"
        '
        'MenuItem70
        '
        Me.MenuItem70.Index = 5
        Me.MenuItem70.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuOrgChrtRef, Me.MenuItem136, Me.MenuItem73, Me.MenuItem143, Me.MenuItem142, Me.MenuItem144, Me.MenuItem145, Me.mnu_ModernTradeDSM, Me.MenuItem95, Me.MnuKeyProds, Me.Mnu_PushProds, Me.MenuItem96, Me.MenuItem76, Me.MenuItem77, Me.MenuItem71, Me.MenuItem61})
        Me.MenuItem70.Text = "Code Tables"
        '
        'mnuOrgChrtRef
        '
        Me.mnuOrgChrtRef.Index = 0
        Me.mnuOrgChrtRef.Text = "Curr OrgChart Quick Ref"
        '
        'MenuItem136
        '
        Me.MenuItem136.Index = 1
        Me.MenuItem136.Text = "Edit Crediting of Mercury Stock Transfer"
        '
        'MenuItem73
        '
        Me.MenuItem73.Index = 2
        Me.MenuItem73.Text = "Edit Crediting of Personal Sales"
        '
        'MenuItem143
        '
        Me.MenuItem143.Index = 3
        Me.MenuItem143.Text = "Item Budget Direct List"
        '
        'MenuItem142
        '
        Me.MenuItem142.Index = 4
        Me.MenuItem142.Text = "Item Budget Direct List (Per Distributor)"
        '
        'MenuItem144
        '
        Me.MenuItem144.Index = 5
        Me.MenuItem144.Text = "Medical Representative Budget List"
        '
        'MenuItem145
        '
        Me.MenuItem145.Index = 6
        Me.MenuItem145.Text = "Modern Trade Budget List"
        '
        'mnu_ModernTradeDSM
        '
        Me.mnu_ModernTradeDSM.Index = 7
        Me.mnu_ModernTradeDSM.Text = "Modern Trade DSM"
        '
        'MenuItem95
        '
        Me.MenuItem95.Index = 8
        Me.MenuItem95.Text = "-"
        '
        'MnuKeyProds
        '
        Me.MnuKeyProds.Index = 9
        Me.MnuKeyProds.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuItmPriKeyProds, Me.MnuItmSecKeyProds, Me.MnuItmTerKeyProds, Me.mnu_itm4thKeyProds, Me.mnu_itm5thKeyProds})
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
        'mnu_itm4thKeyProds
        '
        Me.mnu_itm4thKeyProds.Index = 3
        Me.mnu_itm4thKeyProds.Text = "4th Key Products"
        '
        'mnu_itm5thKeyProds
        '
        Me.mnu_itm5thKeyProds.Index = 4
        Me.mnu_itm5thKeyProds.Text = "5th Key Products"
        '
        'Mnu_PushProds
        '
        Me.Mnu_PushProds.Index = 10
        Me.Mnu_PushProds.Text = "Push Products"
        '
        'MenuItem96
        '
        Me.MenuItem96.Index = 11
        Me.MenuItem96.Text = "-"
        '
        'MenuItem76
        '
        Me.MenuItem76.Index = 12
        Me.MenuItem76.Text = "Mercury Branch"
        '
        'MenuItem77
        '
        Me.MenuItem77.Index = 13
        Me.MenuItem77.Text = "Mercury Item"
        '
        'MenuItem71
        '
        Me.MenuItem71.Index = 14
        Me.MenuItem71.Text = "Mercury Direct Budget"
        '
        'MenuItem61
        '
        Me.MenuItem61.Index = 15
        Me.MenuItem61.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem100, Me.MenuItem99, Me.MenuItem65, Me.MenuItem42, Me.MenuItem69, Me.MenuItem67, Me.MenuItem68})
        Me.MenuItem61.Text = "Qpi Maintenance"
        Me.MenuItem61.Visible = False
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
        'MenuItem5
        '
        Me.MenuItem5.Index = 6
        Me.MenuItem5.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem3, Me.MenuItem6})
        Me.MenuItem5.Text = "&Window"
        Me.MenuItem5.Visible = False
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
        'MenuItem126
        '
        Me.MenuItem126.Index = 7
        Me.MenuItem126.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem127})
        Me.MenuItem126.Text = "Help"
        '
        'MenuItem127
        '
        Me.MenuItem127.Index = 0
        Me.MenuItem127.Shortcut = System.Windows.Forms.Shortcut.F1
        Me.MenuItem127.Text = "About"
        '
        'MenuItem80
        '
        Me.MenuItem80.Index = 8
        Me.MenuItem80.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem81, Me.MenuItem101, Me.MenuItem146, Me.mnu_ProcessCallRateProduct})
        Me.MenuItem80.Text = "Hidden Menu"
        Me.MenuItem80.Visible = False
        '
        'MenuItem81
        '
        Me.MenuItem81.Index = 0
        Me.MenuItem81.Text = "Budget out Of Stock"
        '
        'MenuItem101
        '
        Me.MenuItem101.Index = 1
        Me.MenuItem101.Text = "MedRep"
        '
        'MenuItem146
        '
        Me.MenuItem146.Index = 2
        Me.MenuItem146.Text = "Utility"
        '
        'Main
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(968, 1)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu1
        Me.Name = "Main"
        Me.Text = "Scores DotNet"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Application.Exit()
        LogHelper.InsertLog("User Logout")
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
        If SalesControlDiscrepancy() Then
            Exit Sub
        End If
        Dim myDialogbox As New frmDialogBox
        myDialogbox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
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
        'myLoadedForm.MdiParent = Me                 
        'myLoadedForm.StartPosition = FormStartPosition.CenterScreen
        'myLoadedForm.ShowDialog(Me)                                   <--code before
        myLoadedForm.Report = "Mdi Sales Per Medrep"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        FrmShw(myLoadedForm)         '<--replacement of the code before
    End Sub

    Private Sub mnu_MdiPerMedrepMTD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_MdiPerMedrepMTD.Click
        'Get the respective Teritories per Medrep
        'Dim myConnection As New SqlConnection
        'Dim myCommand As New SqlCommand
        'Try
        '    With myConnection
        '        .ConnectionString = ServerPath
        '        .Open()
        '    End With
        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString)
        'End Try
        Dim myDialogbox As New frmDialogBox
        myDialogbox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        'Try
        '    With myCommand
        '        .CommandText = "GetTerritoriesPerMedrep"
        '        .CommandType = CommandType.StoredProcedure
        '        .Connection = myConnection()
        '        .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = myDialogbox.CommissionDate
        '        .ExecuteNonQuery()
        '    End With
        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString)
        'End Try
        'myConnection.Dispose()

        Dim myLoadedForm As New frmReportViewer
        'myLoadedForm.MdiParent = Me                 
        'myLoadedForm.StartPosition = FormStartPosition.CenterScreen
        'myLoadedForm.ShowDialog(Me)                                   <--code before
        myLoadedForm.Report = "Mdi Sales Per Medrep MTD"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        FrmShw(myLoadedForm)         '<--replacement of the code before
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
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
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
        myLoadedForm.Report = "Mdi Sales Per Medrep Untagged"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        FrmShw(myLoadedForm)
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
        myDialogbox.cboYear.Minimum = 2001
        myDialogbox.cboYear.Maximum = 2008
        myDialogbox.cboYear.Value = 2008
        myDialogbox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
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
        myConnection.Close()

        Dim myLoadedForm As New frmReportViewer
        'myLoadedForm.MdiParent = Me                 donot modify
        myLoadedForm.Report = "Commission Report Attachment"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        'myLoadedForm.StartPosition = FormStartPosition.CenterScreen
        FrmShw(myLoadedForm)         '.ShowDialog(Me)
        myConnection.Close()
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
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
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
        'myLoadedForm.MdiParent = Me                   donot modify
        myLoadedForm.Report = "Medrep Commission"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        'myLoadedForm.StartPosition = FormStartPosition.CenterScreen
        FrmShw(myLoadedForm)          '.ShowDialog(Me)
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
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
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
        'myLoadedForm.MdiParent = Me             donot modify
        myLoadedForm.Report = "Supervisor Commission"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        FrmShw(myLoadedForm)        '.ShowDialog(Me)
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
        If SalesControlDiscrepancy() Then
            Exit Sub
        End If
        Dim myDialogbox As New frmDialogBox
        myDialogbox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
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
        myLoadedForm.Report = "Mercury Sales"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        FrmShw(myLoadedForm)
    End Sub

    Private Sub mnuEditIntegratedSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim myLoadedForm As New EditIntegratedSales     'EditIntegratedSalesMercury
        'FrmShw(myLoadedForm)
        Dim thisForm As New SalesAdjustments
        FrmShw(thisForm)

    End Sub



    Private Sub mnu_QpiPerMedrep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim myDialogbox As New frmDialogBox
        myDialogbox.ShowDialog(Me)

        Dim myLoadedForm As New frmReportViewer
        'myLoadedForm.MdiParent = Me
        myLoadedForm.Report = "Qpi Sales Per Medrep"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        myLoadedForm.StartPosition = FormStartPosition.CenterScreen
        myLoadedForm.ShowDialog(Me)
    End Sub

    Private Sub mnu_QpiPerTerritory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_QpiPerTerritory.Click
        Dim myDialogbox As New frmDialogBox
        myDialogbox.ShowDialog(Me)

        Dim myLoadedForm As New frmReportViewer
        'myLoadedForm.MdiParent = Me
        myLoadedForm.Report = "Qpi Sales Per Territory"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        myLoadedForm.StartPosition = FormStartPosition.CenterScreen
        myLoadedForm.ShowDialog(Me)
    End Sub
    Private Sub mnu_ControlTotals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_ControlTotals.Click
        Try
            Dim myDialogbox As New frmDialogBox
            myDialogbox.ShowDialog(Me)
            If cancelProcess = True Then
                cancelProcess = False
                Exit Sub
            End If
            Dim myLoadedForm As New frmReportViewer
            ''myLoadedForm.MdiParent = Me
            'myLoadedForm.StartPosition = FormStartPosition.CenterScreen
            'myLoadedForm.ShowDialog(Me)
            myLoadedForm.Report = "Control Totals"
            myLoadedForm.CommissionDate = myDialogbox.CommissionDate
            FrmShw(myLoadedForm)
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
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
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
        'myLoadedForm.MdiParent = Me               donot modify
        myLoadedForm.Report = "Commission Report Attachment(DM)2008"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        FrmShw(myLoadedForm)          '.ShowDialog(Me)
    End Sub
    Private Sub mnuMedRepBudget_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim myLoadedForm As New frmBudgetPMR    'frmBudgetPmrModernTrade
        FrmShw(myLoadedForm)
    End Sub
    Private Sub mnu_DistributeReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_DistributeReports.Click
        chiralDist = False
        Dim myLoadedForm As New frmDistributeReports
        FrmShw(myLoadedForm)                  'replacement of commented below
        'myLoadedForm.MdiParent = Me             
        'myLoadedForm.StartPosition = FormStartPosition.CenterScreen
        'myLoadedForm.ShowDialog(Me)
    End Sub
    Private Sub mnu_ProcessMdiData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_ProcessMdiData.Click
        Dim myLoadedForm As New frmProcessMdiData
        FrmShw(myLoadedForm)
    End Sub
    Private Sub Mnu_ProcessMercuryData_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Mnu_ProcessMercuryData.Click
        'Dim myLoadedForm As New frmProcessMercuryData
        'FrmShw(myLoadedForm)
    End Sub
    Private Sub mnu_ProcessSubDistributorData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_ProcessSubDistributorData.Click
        Dim myLoadedForm As New frmProcessSubDistributorData
        FrmShw(myLoadedForm)
    End Sub
    Private Sub mnu_ProcessInHouseData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_ProcessInHouseData.Click
        Dim myLoadedForm As New frmProcessInHouseData
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MnuItmPriKeyProds_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuItmPriKeyProds.Click
        Dim myLoadedForm As New frmKeyProducts
        FrmShw(myLoadedForm)
    End Sub
    Private Sub MnuItmSecKeyProds_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuItmSecKeyProds.Click
        Dim myLoadedForm As New frmSubKeyProduct
        FrmShw(myLoadedForm)
    End Sub
    Private Sub MnuItmTerKeyProds_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuItmTerKeyProds.Click
        Dim myLoadedForm As New frmTerKeyProduct
        FrmShw(myLoadedForm)
    End Sub
    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim myLoadedForm As New SupMr
        FrmShw(myLoadedForm)
    End Sub
    Private Sub Mnu_MedrepCommissionWithRecovery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_MedrepCommissionWithRecovery.Click
        Dim myDialogBox As New frmDialogBox
        Dim myCommissionDate As String
        myDialogBox.cboYear.Minimum = 2006
        myDialogBox.cboYear.Maximum = 2007
        myDialogBox.cboYear.Value = 2007
        myDialogBox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
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
        'myReportViewer.MdiParent = Me                          donot modify
        FrmShw(myReportViewer)           '.ShowDialog(Me)
    End Sub
    Private Sub Mnu_DistrictManagerCommissionWithRecovery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_DistrictManagerCommissionWithRecovery.Click
        Dim myDialogBox As New frmDialogBox
        Dim myCommissionDate As String
        myDialogBox.cboYear.Minimum = 2006
        myDialogBox.cboYear.Maximum = 2007
        myDialogBox.cboYear.Value = 2007
        myDialogBox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
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
        'myReportViewer.MdiParent = Me                    donot modify
        FrmShw(myReportViewer)           '.ShowDialog(Me)
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
        'myLoadedForm.MdiParent = Me
        myLoadedForm.Report = "Qpi Mercury Sales"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        myLoadedForm.StartPosition = FormStartPosition.CenterScreen
        myLoadedForm.ShowDialog(Me)
    End Sub

    Private Sub Mnu_HiiPerTerritory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_HiiPerTerritory.Click
        Dim myDialogbox As New frmDialogBox
        myDialogbox.ShowDialog(Me)

        Dim myLoadedForm As New frmReportViewer
        'myLoadedForm.MdiParent = Me
        myLoadedForm.Report = "Hii Sales Per Territory"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        myLoadedForm.StartPosition = FormStartPosition.CenterScreen
        myLoadedForm.ShowDialog(Me)
    End Sub

    Private Sub mnu_ProcessCallRate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_ProcessCallRate.Click
        Dim myLoadedForm As New frmProcessCallRate
        FrmShw(myLoadedForm)
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
            myReport.SetDataSource(CType(RemoteDataSet.tempory_mercury, DataTable))
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
    Private Sub MenuItem44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim myLoadedForm As New frmBudgetDirect
        FrmShw(myLoadedForm)
    End Sub

    Private Sub FrmShw(ByVal vfrm As Form)
        vfrm.MdiParent = Me
        vfrm.StartPosition = FormStartPosition.CenterScreen
        vfrm.Show()
    End Sub

    Private Sub MenuItem43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim myLoadedForm As New NsmCT
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles MenuItem45.Click

        Me.Cursor = Cursors.WaitCursor
        Dim myDialogBox As New frmDialogBox
        myDialogBox.btnPreview.Text = "Store"
        myDialogBox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            'me.Cursor = default
            Exit Sub
        End If
        Dim BusinessLayer As New BusinessLayer.clsCommissionComputations
        Dim Params(0) As SqlParameter
        Dim CommissionDate As New SqlParameter("@CommissionDate", SqlDbType.DateTime, 10)
        CommissionDate.Direction = ParameterDirection.Input
        CommissionDate.Value = myDialogBox.CommissionDate
        Params(0) = CommissionDate
        BusinessLayer.Store_CommissionTable(ServerPath2, "Store_CommissionTables", _
                                            CommandType.StoredProcedure, Params)
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
        MyReport.SetDataSource(CType(RemoteDataSet.CtSales_Show, DataTable))
        MyReportViewer.ReportViewer.ReportSource = MyReport
        'MyReportViewer.Show()
        FrmShw(MyReportViewer)
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
        MyReport.SetDataSource(CType(RemoteDataSet.CtSales_Show, DataTable))
        MyReportViewer.ReportViewer.ReportSource = MyReport
        'MyReportViewer.Show()
        FrmShw(MyReportViewer)
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
        MyReport.SetDataSource(CType(RemoteDataSet.Performance_Generic, DataTable))
        MyReportViewer.ReportViewer.ReportSource = MyReport
        'MyReportViewer.ShowDialog(Me)
        FrmShw(MyReportViewer)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub MenuItem49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem49.Click
        Me.Cursor = Cursors.WaitCursor
        Dim RemoteDataSet As New Performance
        Dim mydialogbox As New frmDialogBox
        mydialogbox.btnPreview.Text = "Preview"
        mydialogbox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        Dim BusinessLayer As New BusinessLayer.clsPerformance
        Dim Params(0) As SqlParameter
        Dim CommissionDate As New SqlParameter("@CommissionDate", SqlDbType.DateTime, 10) : CommissionDate.Direction = ParameterDirection.Input : CommissionDate.Value = mydialogbox.CommissionDate : Params(0) = CommissionDate
        BusinessLayer.Performance_Generic(ServerPath2, "Performance_Generic", CommandType.StoredProcedure, _
        RemoteDataSet, "Performance_Generic", Params)

        Dim MyReportViewer As New frmReportViewer
        Dim MyReport As New Rpt_PerformanceGeneric_Spv
        MyReport.SetDataSource(CType(RemoteDataSet.Performance_Generic, DataTable))
        MyReportViewer.ReportViewer.ReportSource = MyReport
        'MyReportViewer.ShowDialog(Me)
        FrmShw(MyReportViewer)
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
            MyReport.SetDataSource(CType(RemoteDataSet.Performance_Calenderized, DataTable))
            MyReportViewer.ReportViewer.ReportSource = MyReport
            FrmShw(MyReportViewer)  '.ShowDialog(Me)
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
            MyReport.SetDataSource(CType(RemoteDataSet.Performance_Calenderized, DataTable))
            MyReportViewer.ReportViewer.ReportSource = MyReport
            FrmShw(MyReportViewer) '.ShowDialog(Me)
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
        'MyLoadedForm.MdiParent = Me
        MyLoadedForm.StartPosition = FormStartPosition.CenterScreen
        MyLoadedForm.ShowDialog(Me)
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
            If cancelProcess = True Then
                cancelProcess = False
                Exit Sub
            End If
            Dim CommissionDate As New SqlParameter("@CommissionDate", SqlDbType.DateTime, 10) : CommissionDate.Direction = ParameterDirection.Input : CommissionDate.Value = MyDialogBox.CommissionDate : Params(0) = CommissionDate
            With MyLoadedForm
                BusinessObject.Sub_Show(ServerPath2, "Qpi_SalesSummary", CommandType.StoredProcedure, RemoteDataSet, "Qpi_SalesSummary", Params)
                MyReport.SetDataSource(CType(RemoteDataSet.Qpi_SalesSummary, DataTable))
                .ReportViewer.ReportSource = MyReport
                ''.MdiParent = Me
                'MyLoadedForm.StartPosition = FormStartPosition.CenterScreen
                '.ShowDialog(Me)
                FrmShw(MyLoadedForm)
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub MenuItem67_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem67.Click
        Dim MyLoadedForm As New frmQpiTerritoryAssignment
        'MyLoadedForm.MdiParent = Me
        MyLoadedForm.StartPosition = FormStartPosition.CenterScreen
        MyLoadedForm.ShowDialog(Me)
    End Sub
    Private Sub MenuItem68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem68.Click
        Dim MyLoadedForm As New frmQpiTerritoryAssignment_Modify
        'MyLoadedForm.MdiParent = Me
        MyLoadedForm.StartPosition = FormStartPosition.CenterScreen
        MyLoadedForm.ShowDialog(Me)
    End Sub
    Private Sub MenuItem71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MyLoadedForm As New CustomerTypeCT
        FrmShw(MyLoadedForm)
    End Sub
    Private Sub MenuItem72_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MyLoadedForm As New DivisionCT
        FrmShw(MyLoadedForm)
    End Sub

    Private Sub MenuItem73_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MyLoadedForm As New GroupCT
        FrmShw(MyLoadedForm)
    End Sub

    Private Sub MenuItem74_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MyLoadedForm As New ItemCT
        FrmShw(MyLoadedForm)
    End Sub

    Private Sub MenuItem75_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MyLoadedForm As New MedRepCT
        'MyLoadedForm.MdiParent = Me
        'MyLoadedForm.StartPosition = FormStartPosition.CenterScreen
        FrmShw(MyLoadedForm)    '.ShowDialog(Me)
    End Sub

    Private Sub MenuItem76_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem76.Click
        Dim MyLoadedForm As New MercuryBranchCT
        FrmShw(MyLoadedForm)
    End Sub

    Private Sub MenuItem77_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem77.Click
        Dim MyLoadedForm As New MercuryItemCT
        FrmShw(MyLoadedForm)
    End Sub

    Private Sub MenuItem78_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MyLoadedForm As New PrincipalCT
        FrmShw(MyLoadedForm)
    End Sub

    Private Sub MenuItem79_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MyLoadedForm As New ProvinceCT
        FrmShw(MyLoadedForm)
    End Sub

    Private Sub MenuItem80_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MyLoadedForm As New SupervisorCT
        FrmShw(MyLoadedForm)
    End Sub

    Private Sub MenuItem81_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MyLoadedForm As New TerritoryCT
        FrmShw(MyLoadedForm)
    End Sub

    Private Sub MenuItem90_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MyLoadedForm As New TeamDivisionCT
        FrmShw(MyLoadedForm)
    End Sub

    Private Sub MenuItem87_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MyLoadedForm As New ProductLineCT
        FrmShw(MyLoadedForm)
    End Sub
    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MyLoadedForm As New CustomerCT
        FrmShw(MyLoadedForm)
    End Sub

    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MyLoadedForm As New CallRateBudgetCT
        FrmShw(MyLoadedForm)
    End Sub

    Private Sub MenuItem42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem42.Click
        Dim MyLoadedForm As New QpiTerritoryBudgetCT
        'MyLoadedForm.MdiParent = Me
        MyLoadedForm.StartPosition = FormStartPosition.CenterScreen
        MyLoadedForm.ShowDialog(Me)
    End Sub

    Private Sub MenuItem64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem64.Click
        Dim BusinessLayer As New BusinessLayer.clsFileMaintenance
        Dim RemoteDataSet As New CodeTablesDS
        Dim MyDialogBox As New frmDialogBox
        MyDialogBox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        Dim Params(0) As SqlParameter
        Dim CommissionDate As New SqlParameter("@CommissionDate", SqlDbType.DateTime) : CommissionDate.Direction = ParameterDirection.Input : CommissionDate.Value = MyDialogBox.CommissionDate : Params(0) = CommissionDate
        BusinessLayer.Sub_Select(ServerPath2, "CallRate_Calenderized", CommandType.StoredProcedure, RemoteDataSet, _
        "CallRate_Calenderized", Params)
        Dim myReportViewer As New frmReportViewer
        Dim myReport As New CallRate_CalenderizedNSM
        myReport.SetDataSource(CType(RemoteDataSet.CallRate_Calenderized, DataTable))
        myReportViewer.ReportViewer.ReportSource = myReport
        'myReportViewer.ShowDialog(Me)
        FrmShw(myReportViewer)
    End Sub

    Private Sub MenuItem85_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem85.Click
        Dim BusinessLayer As New BusinessLayer.clsFileMaintenance
        Dim RemoteDataSet As New CodeTablesDS
        Dim MyDialogBox As New frmDialogBox
        MyDialogBox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        Dim Params(0) As SqlParameter
        Dim CommissionDate As New SqlParameter("@CommissionDate", SqlDbType.DateTime) : CommissionDate.Direction = ParameterDirection.Input : CommissionDate.Value = MyDialogBox.CommissionDate : Params(0) = CommissionDate
        BusinessLayer.Sub_Select(ServerPath2, "CallRate_Calenderized", CommandType.StoredProcedure, RemoteDataSet, _
        "CallRate_Calenderized", Params)
        Dim myReportViewer As New frmReportViewer
        Dim myReport As New CallRate_CalenderizedDSM
        myReport.SetDataSource(CType(RemoteDataSet.CallRate_Calenderized, DataTable))
        myReportViewer.ReportViewer.ReportSource = myReport
        'myReportViewer.ShowDialog(Me)
        FrmShw(myReportViewer)
    End Sub

    Private Sub MenuItem89_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem89.Click
        Dim BusinessLayer As New BusinessLayer.clsFileMaintenance
        Dim RemoteDataSet As New CodeTablesDS
        Dim MyDialogBox As New frmDialogBox
        MyDialogBox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        Dim Params(0) As SqlParameter
        Dim CommissionDate As New SqlParameter("@CommissionDate", SqlDbType.DateTime) : CommissionDate.Direction = ParameterDirection.Input : CommissionDate.Value = MyDialogBox.CommissionDate : Params(0) = CommissionDate
        BusinessLayer.Sub_Select(ServerPath2, "CallRate_Calenderized", CommandType.StoredProcedure, RemoteDataSet, _
        "CallRate_Calenderized", Params)
        Dim myReportViewer As New frmReportViewer
        Dim myReport As New CallRate_CalenderizedPMR
        myReport.SetDataSource(CType(RemoteDataSet.CallRate_Calenderized, DataTable))
        myReportViewer.ReportViewer.ReportSource = myReport
        'myReportViewer.ShowDialog(Me)
        FrmShw(myReportViewer)
    End Sub
    Private Sub MenuItem92_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem92.Click
        Dim BusinessLayer As New BusinessLayer.clsFileMaintenance
        Dim RemoteDataSet As New CodeTablesDS
        Dim MyDialogBox As New frmDialogBox
        MyDialogBox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        Dim Params(0) As SqlParameter
        Dim CommissionDate As New SqlParameter("@CommissionDate", SqlDbType.DateTime) : CommissionDate.Direction = ParameterDirection.Input : CommissionDate.Value = MyDialogBox.CommissionDate : Params(0) = CommissionDate
        BusinessLayer.Sub_Select(ServerPath2, "CallRate_Monthly", CommandType.StoredProcedure, RemoteDataSet, _
        "CallRate_Calenderized", Params)
        Dim myReportViewer As New frmReportViewer
        Dim myReport As New CallRate_MonthlyNSM
        myReport.SetDataSource(CType(RemoteDataSet.CallRate_Calenderized, DataTable))
        myReportViewer.ReportViewer.ReportSource = myReport
        'myReportViewer.ShowDialog(Me)
        FrmShw(myReportViewer)
    End Sub

    Private Sub MenuItem93_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem93.Click
        Dim BusinessLayer As New BusinessLayer.clsFileMaintenance
        Dim RemoteDataSet As New CodeTablesDS
        Dim MyDialogBox As New frmDialogBox
        MyDialogBox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        Dim Params(0) As SqlParameter
        Dim CommissionDate As New SqlParameter("@CommissionDate", SqlDbType.DateTime) : CommissionDate.Direction = ParameterDirection.Input : CommissionDate.Value = MyDialogBox.CommissionDate : Params(0) = CommissionDate
        BusinessLayer.Sub_Select(ServerPath2, "CallRate_Monthly", CommandType.StoredProcedure, RemoteDataSet, _
        "CallRate_Calenderized", Params)
        Dim myReportViewer As New frmReportViewer
        Dim myReport As New CallRate_MonthlyDSM
        myReport.SetDataSource(CType(RemoteDataSet.CallRate_Calenderized, DataTable))
        myReportViewer.ReportViewer.ReportSource = myReport
        'myReportViewer.ShowDialog(Me)
        FrmShw(myReportViewer)
    End Sub

    Private Sub MenuItem94_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem94.Click
        Dim BusinessLayer As New BusinessLayer.clsFileMaintenance
        Dim RemoteDataSet As New CodeTablesDS
        Dim MyDialogBox As New frmDialogBox
        MyDialogBox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        Dim Params(0) As SqlParameter
        Dim CommissionDate As New SqlParameter("@CommissionDate", SqlDbType.DateTime) : CommissionDate.Direction = ParameterDirection.Input : CommissionDate.Value = MyDialogBox.CommissionDate : Params(0) = CommissionDate
        BusinessLayer.Sub_Select(ServerPath2, "CallRate_Monthly", CommandType.StoredProcedure, RemoteDataSet, _
        "CallRate_Calenderized", Params)
        Dim myReportViewer As New frmReportViewer
        Dim myReport As New CallRate_MonthlyPMR
        myReport.SetDataSource(CType(RemoteDataSet.CallRate_Calenderized, DataTable))
        myReportViewer.ReportViewer.ReportSource = myReport
        'myReportViewer.ShowDialog(Me)
        FrmShw(myReportViewer)
    End Sub

    Private Sub MenuItem95_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuItem96_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MyLoadedForm As New CallRateCT
        FrmShw(MyLoadedForm)
    End Sub

    Private Sub mnuExtractMDIDailySales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuItem97_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MyLoadedForm As New PM_CT
        FrmShw(MyLoadedForm)
    End Sub

    Private Sub MenuItem98_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MyLoadedForm As New frmExCustomers
        FrmShw(MyLoadedForm)
    End Sub

    Private Sub MenuItem99_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem99.Click
        Dim MyLoadedForm As New QPIareacode
        'MyLoadedForm.MdiParent = Me
        MyLoadedForm.StartPosition = FormStartPosition.CenterScreen
        MyLoadedForm.ShowDialog(Me)
    End Sub

    Private Sub MenuItem100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem100.Click
        Dim MyLoadedForm As New QpiAreaAssign
        'MyLoadedForm.MdiParent = Me
        MyLoadedForm.StartPosition = FormStartPosition.CenterScreen
        MyLoadedForm.ShowDialog(Me)
    End Sub

    Private Sub MenuItem101_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MyLoadedForm As New MedRepTerAssign
        FrmShw(MyLoadedForm)
    End Sub

    Private Sub MenuItem102_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MyLoadedForm As New frmItemBudget
        FrmShw(MyLoadedForm)
    End Sub

    Private Sub MenuItem103_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem103.Click
        Dim myDialogBox As New frmDialogBox
        Dim myCommissionDate As String
        myDialogBox.cboYear.Minimum = 2008
        myDialogBox.cboYear.Maximum = 2008
        myDialogBox.cboYear.Value = 2008
        myDialogBox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
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
        'myReportViewer.MdiParent = Me                      donot modify
        FrmShw(myReportViewer)      '.ShowDialog(Me)
    End Sub

    Private Sub Mnu_DistrictManagerCommissionWithRecovery2008_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_DistrictManagerCommissionWithRecovery2008.Click
        Dim myDialogBox As New frmDialogBox
        Dim myCommissionDate As String
        myDialogBox.cboYear.Minimum = 2008
        myDialogBox.cboYear.Maximum = 2008
        myDialogBox.cboYear.Value = 2008
        myDialogBox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
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
        'myReportViewer.MdiParent = Me                   donot modify
        FrmShw(myReportViewer)         '.ShowDialog(Me)
    End Sub

    Private Sub MenuItem104_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim myLoadedForm As New EditIntegratedSalesMercury
        FrmShw(myLoadedForm)
    End Sub

    Private Sub mnuUserMaint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim myLoadedForm As New frmUserMaint
        FrmShw(myLoadedForm)
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
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem108_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem108.Click
        Dim myLoadedForm As New frmProcessInMarketData
        FrmShw(myLoadedForm)
    End Sub

    Private Sub ExtCustZue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExtCustZue.Click
        Dim myLoadedForm As New frmExCustomersZue
        FrmShw(myLoadedForm)
    End Sub

    Private Sub Mnu_MedrepCommissionQX2008_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_MedrepCommissionQX2008.Click
        Dim myDialogBox As New frmDialogBox
        Dim myCommissionDate As String
        myDialogBox.cboYear.Minimum = 2008
        myDialogBox.cboYear.Maximum = 2008
        myDialogBox.cboYear.Value = 2008
        myDialogBox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
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
        myReportViewer.Report = "Medrep Commission QX 2008"
        myReportViewer.CommissionDate = myCommissionDate
        'myReportViewer.MdiParent = Me                   donot modify
        FrmShw(myReportViewer)        '.ShowDialog(Me)
    End Sub

    Private Sub Mnu_MedrepCommissionChiral2009_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_MedrepCommissionChiral2009.Click
        Dim myDialogBox As New frmDialogBox
        Dim myCommissionDate As String
        myDialogBox.cboYear.Minimum = 2009
        myDialogBox.cboYear.Maximum = 2010
        myDialogBox.cboYear.Value = 2010
        myDialogBox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        myCommissionDate = myDialogBox.CommissionDate

        'Compute the Attachment
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComIncAttach_Chiral", CommandType.StoredProcedure, 1)

        'Compute the ComInc
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComInc_Chiral", CommandType.StoredProcedure, 1)

        Dim myReportViewer As New frmReportViewer
        myReportViewer.Report = "Medrep Commission Chiral 2009"
        myReportViewer.CommissionDate = myCommissionDate
        'myReportViewer.MdiParent = Me                      donot modify
        FrmShw(myReportViewer)         '.ShowDialog(Me)
    End Sub

    Private Sub Mnu_DistrictManagerCommission2008QX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_DistrictManagerCommission2008QX.Click
        Dim myDialogBox As New frmDialogBox
        Dim myCommissionDate As String
        myDialogBox.cboYear.Minimum = 2008
        myDialogBox.cboYear.Maximum = 2008
        myDialogBox.cboYear.Value = 2008
        myDialogBox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
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
        DataMaintenance.ExecuteCommand(ServerPath2, "DSMPMR_det2", CommandType.StoredProcedure, 1)

        'Compute the DSMPMR_ins
        Dim LocalCommand As New SqlCommand
        With LocalCommand
            .Connection = ObjectConnection(ServerPath2)
            .CommandText = "DSMPMR_ins"
            .CommandType = CommandType.StoredProcedure
            .ExecuteScalar()
        End With

        Dim myReportViewer As New frmReportViewer
        myReportViewer.Report = "DSM Commission QX2008"
        myReportViewer.CommissionDate = myCommissionDate
        'myReportViewer.MdiParent = Me                       donot modify
        FrmShw(myReportViewer)      '.ShowDialog(Me)
    End Sub

    Private Sub Mnu_DistrictManagerCommission2009Chiral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_DistrictManagerCommission2009Chiral.Click
        Dim myDialogBox As New frmDialogBox
        Dim myCommissionDate As String
        myDialogBox.cboYear.Minimum = 2009
        myDialogBox.cboYear.Maximum = 2010
        myDialogBox.cboYear.Value = 2010
        myDialogBox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        myCommissionDate = myDialogBox.CommissionDate
        CommDate = myDialogBox.CommissionDate

        'Compute the Attachment
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComIncAttach_Chiral", CommandType.StoredProcedure, 1)

        'Compute the ComInc
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComInc_Chiral", CommandType.StoredProcedure, 1)

        'Compute the DSM_Commission2008
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "DSM_Commission_2009_Chiral", CommandType.StoredProcedure, 1)

        'Compute the DSMPMR_det
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "DsmPmr_Det_2009_Chiral", CommandType.StoredProcedure, 1)

        'Compute the DSMPMR_ins
        Dim LocalCommand As New SqlCommand
        With LocalCommand
            .Connection = ObjectConnection(ServerPath2)
            .CommandText = "DsmPmr_Ins_2009Chiral"
            .CommandType = CommandType.StoredProcedure
            .ExecuteScalar()
        End With

        Dim myReportViewer As New frmReportViewer
        myReportViewer.Report = "DSM Commission Chiral 2009"
        myReportViewer.CommissionDate = myCommissionDate
        'myReportViewer.MdiParent = Me                       donot modify
        FrmShw(myReportViewer)              '.ShowDialog(Me)
    End Sub

    Private Sub Mnu_MedrepCommissionWithRecovery2009_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_MedrepCommissionWithRecovery2009.Click
        Dim myDialogBox As New frmDialogBox
        Dim myCommissionDate As String
        myDialogBox.cboYear.Minimum = 2009
        myDialogBox.cboYear.Maximum = 2010
        myDialogBox.cboYear.Value = 2010
        myDialogBox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        myCommissionDate = myDialogBox.CommissionDate

        'Compute the Attachment
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComIncAttach2009", CommandType.StoredProcedure, 1)

        'Compute the ComInc
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        If CDate(myCommissionDate) <= CDate("03/01/2009") Then
            DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComInc2009", _
                                           CommandType.StoredProcedure, 1)
        ElseIf CDate(myCommissionDate) >= CDate("04/01/2009") Then
            DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComInc2009a", _
                                           CommandType.StoredProcedure, 1)
        End If


        Dim myReportViewer As New frmReportViewer
        myReportViewer.Report = "Medrep Commission with Recovery2009"
        myReportViewer.CommissionDate = myCommissionDate
        'myReportViewer.MdiParent = Me                      donot modify
        FrmShw(myReportViewer)        '.ShowDialog(Me)
    End Sub

    Private Sub Mnu_MedrepCommissionWithRecovery2009MTD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_MedrepCommissionWithRecovery2009MTD.Click
        Dim myDialogBox As New frmDialogBox
        Dim myCommissionDate As String
        myDialogBox.cboYear.Minimum = 2009
        myDialogBox.cboYear.Maximum = 2010
        myDialogBox.cboYear.Value = 2010
        myDialogBox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        myCommissionDate = myDialogBox.CommissionDate

        'Compute the Attachment
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComIncAttachMTD2009", CommandType.StoredProcedure, 1)

        'Compute the ComInc
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComIncMTD2009", _
                                           CommandType.StoredProcedure, 1)


        Dim myReportViewer As New frmReportViewer
        myReportViewer.Report = "Medrep Commission with RecoveryMTD2009"
        myReportViewer.CommissionDate = myCommissionDate
        'myReportViewer.MdiParent = Me                      donot modify
        FrmShw(myReportViewer)        '.ShowDialog(Me)
    End Sub

    Private Sub Mnu_DistrictManagerCommissionWithRecovery2009_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_DistrictManagerCommissionWithRecovery2009.Click
        Dim myDialogBox As New frmDialogBox
        Dim myCommissionDate As String
        myDialogBox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        myCommissionDate = myDialogBox.CommissionDate

        'Compute the Attachment
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComIncAttach2009", CommandType.StoredProcedure, 1)

        'Compute the ComInc
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        'If Month(CDate(myCommissionDate)) <= 3 And Year(CDate(myCommissionDate)) <= 2009 Then
        DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComInc2009", _
                                       CommandType.StoredProcedure, 1)
        'ElseIf Month(CDate(myCommissionDate)) > 3 And Year(CDate(myCommissionDate)) >= 2009 Then
        '    DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComInc2009a", _
        '                                   CommandType.StoredProcedure, 1)
        'End If

        'Compute the DSM_Commission2008
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        If CDate(myCommissionDate) <= CDate("03/01/2009") Then   ' Month(CDate(myCommissionDate)) <= 3 And Year(CDate(myCommissionDate)) <= 2009 Then
            DataMaintenance.ExecuteCommand(ServerPath2, "DSM_Commission_2009", CommandType.StoredProcedure, 1)
        ElseIf CDate(myCommissionDate) >= CDate("04/01/2009") Then   ' Month(CDate(myCommissionDate)) > 3 And Year(CDate(myCommissionDate)) >= 2009 Then
            DataMaintenance.ExecuteCommand(ServerPath2, "DSM_Commission_2009a", _
                                           CommandType.StoredProcedure, 1)
        End If

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
            .CommandText = "DSMPMR_ins_2009"
            .CommandType = CommandType.StoredProcedure
            .ExecuteScalar()
        End With

        Dim myReportViewer As New frmReportViewer
        myReportViewer.Report = "DSM Commission with Recovery2009"
        myReportViewer.CommissionDate = myCommissionDate
        'myReportViewer.MdiParent = Me                   donot modify
        FrmShw(myReportViewer)           '.ShowDialog(Me)
    End Sub

    Private Sub mnu_ProcessCallRateProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_ProcessCallRateProduct.Click
        Dim myLoadedForm As New frmProcessCallRateProduct
        FrmShw(myLoadedForm)
    End Sub

    Private Sub Mnu_CommissionAttachment2009_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_CommissionAttachment2009.Click
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
        myDialogbox.cboYear.Minimum = 2009
        myDialogbox.cboYear.Maximum = 2013
        myDialogbox.cboYear.Value = 2013
        myDialogbox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        Try
            With myCommand
                .CommandText = "COMMISSION_ComputeAttachment2009"
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
        ''myLoadedForm.MdiParent = Me                donot modify
        'myLoadedForm.StartPosition = FormStartPosition.CenterScreen
        'myLoadedForm.ShowDialog(Me)
        myLoadedForm.Report = "Commission Report Attachment 2009"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        FrmShw(myLoadedForm)
    End Sub

    Private Sub Mnu_CommissionAttachmentMTD2009_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_CommissionAttachmentMTD2009.Click
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
        myDialogbox.cboYear.Minimum = 2009
        myDialogbox.cboYear.Maximum = 2010
        myDialogbox.cboYear.Value = 2010
        myDialogbox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        Try
            With myCommand
                .CommandText = "COMMISSION_ComputeAttachmentMTD2009"
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
        ''myLoadedForm.MdiParent = Me                donot modify
        'myLoadedForm.StartPosition = FormStartPosition.CenterScreen
        'myLoadedForm.ShowDialog(Me)
        myLoadedForm.Report = "Commission Report Attachment MTD 2009"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        FrmShw(myLoadedForm)
    End Sub

    Private Sub Mnu_CommissionAttachmentDM2009_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_CommissionAttachmentDM2009.Click
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
        If SalesControlDiscrepancy() Then
            Exit Sub
        End If
        Dim myDialogbox As New frmDialogBox
        myDialogbox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        Try
            With myCommand
                .CommandText = "COMMISSION_ComputeAttachment2009"
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
        'myLoadedForm.MdiParent = Me             donot modify
        myLoadedForm.Report = "Commission Report Attachment(DM)2009"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        FrmShw(myLoadedForm)   '.ShowDialog(Me)
    End Sub

    Private Sub MenuItem106_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem106.Click
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
        myDialogbox.cboYear.Minimum = 2001
        myDialogbox.cboYear.Maximum = 2008
        myDialogbox.cboYear.Value = 2008
        myDialogbox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
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
        'myLoadedForm.MdiParent = Me             donot modify
        myLoadedForm.Report = "Commission Report Attachment"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        FrmShw(myLoadedForm)       '.ShowDialog(Me)
    End Sub

    Private Sub MenuItem107_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem107.Click
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
        myDialogbox.cboYear.Minimum = 2009
        myDialogbox.cboYear.Maximum = 2010
        myDialogbox.cboYear.Value = 2010
        myDialogbox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        Try
            With myCommand
                .CommandText = "COMMISSION_ComputeAttachment_Chiral"
                .CommandType = CommandType.StoredProcedure
                .Connection = myConnection
                .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = myDialogbox.CommissionDate
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        myConnection.Close()

        Dim myLoadedForm As New frmReportViewer
        'myLoadedForm.MdiParent = Me           donot modify
        myLoadedForm.Report = "Commission Report Attachment Chiral"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        FrmShw(myLoadedForm)      '.ShowDialog(Me)
    End Sub
    Private Sub Mnu_CommissionAttachmentDSM2008Chiral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_CommissionAttachmentDSM2008Chiral.Click
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
        myDialogbox.cboYear.Minimum = 2008
        myDialogbox.cboYear.Maximum = 2008
        myDialogbox.cboYear.Value = 2008
        myDialogbox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        Try
            With myCommand
                .CommandText = "COMMISSION_ComputeAttachment_Chiral"
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
        'myLoadedForm.MdiParent = Me             donot modify
        myLoadedForm.Report = "Commission Report Attachment(DSM)2008Chiral"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        FrmShw(myLoadedForm)          '.ShowDialog(Me)
    End Sub


    Private Sub Mnu_CommissionAttachmentDSM2009Chiral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_CommissionAttachmentDSM2009Chiral.Click
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
        myDialogbox.cboYear.Minimum = 2009
        myDialogbox.cboYear.Maximum = 2010
        myDialogbox.cboYear.Value = 2010
        myDialogbox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        Try
            With myCommand
                .CommandText = "COMMISSION_ComputeAttachment_Chiral"
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
        'myLoadedForm.MdiParent = Me            donot modify
        myLoadedForm.Report = "Commission Report Attachment(DSM)2009Chiral"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        FrmShw(myLoadedForm)          '.ShowDialog(Me)
    End Sub

    Private Sub MenuItem109_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem109.Click
        chiralDist = True
        Dim myLoadedForm As New frmDistributeReports
        'myLoadedForm.MdiParent = Me                   donot modify
        FrmShw(myLoadedForm)         '.ShowDialog(Me)
    End Sub

    Private Sub Main_MdiChildActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MdiChildActivate
        ChildCtr = ChildCtr + 1
        If ChildCtr > 2 Then
            CloseFrm = True
        Else
            CloseFrm = False
        End If
    End Sub

    Private Sub Main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChildCtr = 0

        Me.Text += " v" & System.Configuration.ConfigurationSettings.AppSettings.Item("AppVersion")

    End Sub

    Private Sub mnu_MTradeBudget_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim myLoadedForm As New frmBudgetPmrModernTrade
        FrmShw(myLoadedForm)
    End Sub

    Private Sub mnu_ModernTradeDSM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_ModernTradeDSM.Click
        Dim myLoadedForm As New ModTradDSM
        FrmShw(myLoadedForm)
    End Sub

    Private Sub Mnu_PushProds_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_PushProds.Click
        Dim myLoadedForm As New frmPushProducts
        FrmShw(myLoadedForm)
    End Sub

    Private Sub mnu_YTD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_YTD.Click
        Dim myDialogBox As New frmDialogBox
        Dim myCommissionDate As String
        myDialogBox.cboYear.Minimum = 2009
        myDialogBox.cboYear.Maximum = 2010
        myDialogBox.cboYear.Value = 2009
        myDialogBox.cboMonth.SelectedIndex = 11     'setting the month to december & disabling the textbox
        myDialogBox.btnPreview.Select()             'focus on the button so that the noemps field wont validate
        myDialogBox.cboMonth.Enabled = False
        myDialogBox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        myCommissionDate = myDialogBox.CommissionDate

        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "YTDcommission2009", CommandType.StoredProcedure, 1)

        Dim myReportViewer As New frmReportViewer
        myReportViewer.Report = "PMR Year to date Recovery Commission"
        myReportViewer.CommissionDate = myCommissionDate
        'myReportViewer.MdiParent = Me                      donot modify
        FrmShw(myReportViewer)        '.ShowDialog(Me)
    End Sub

    Private Sub mnu_YTDdsm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_YTDdsm.Click
        Dim myDialogBox As New frmDialogBox
        Dim myCommissionDate As String
        myDialogBox.cboYear.Minimum = 2009
        myDialogBox.cboYear.Maximum = 2010
        myDialogBox.cboYear.Value = 2009
        myDialogBox.cboMonth.SelectedIndex = 11     'setting the month to december & disabling the textbox
        myDialogBox.btnPreview.Select()             'focus on the button so that the noemps field wont validate
        myDialogBox.cboMonth.Enabled = False
        myDialogBox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        myCommissionDate = myDialogBox.CommissionDate

        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "YTDcommission2009DSM", CommandType.StoredProcedure, 1)

        Dim myReportViewer As New frmReportViewer
        myReportViewer.Report = "DSM Year End Recovery Commission"
        myReportViewer.CommissionDate = myCommissionDate
        'myReportViewer.MdiParent = Me                      donot modify
        FrmShw(myReportViewer)        '.ShowDialog(Me)
    End Sub

    Private Sub mnu_Company_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_Company.Click
        Dim myLoadedForm As New CompanyCT
        FrmShw(myLoadedForm)
    End Sub

    Private Sub mnu_District_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_District.Click
        Dim myLoadedForm As New DistrictCT
        FrmShw(myLoadedForm)
    End Sub

    Private Sub mnu_MHmrarea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_MHmrarea.Click
        Dim myLoadedForm As New MHMedRepTerAssign
        FrmShw(myLoadedForm)
    End Sub

    Private Sub mnu_itm4thKeyProds_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_itm4thKeyProds.Click
        Dim myLoadedForm As New frm4thKeyProducts
        FrmShw(myLoadedForm)
    End Sub

    Private Sub mnu_itm5thKeyProds_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_itm5thKeyProds.Click
        Dim myLoadedForm As New frm5thKeyProducts
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem112_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem112.Click
        Dim myDialogBox As New frmDialogBox
        Dim myCommissionDate As String
        myDialogBox.cboYear.Minimum = 2009
        myDialogBox.cboYear.Maximum = 2010
        myDialogBox.cboYear.Value = 2010
        myDialogBox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        myCommissionDate = myDialogBox.CommissionDate

        'Compute the Attachment
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComIncAttach_Chiral", CommandType.StoredProcedure, 1)

        'Compute the ComInc
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComInc_Chiral", CommandType.StoredProcedure, 1)

        Dim myReportViewer As New frmReportViewer
        myReportViewer.Report = "Medrep Commission Chiral 2010"
        myReportViewer.CommissionDate = myCommissionDate
        'myReportViewer.MdiParent = Me                      donot modify
        FrmShw(myReportViewer)         '.ShowDialog(Me)
    End Sub

    Private Sub Mnu_DistrictManagerCommission2010Chiral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_DistrictManagerCommission2010Chiral.Click
        Dim myDialogBox As New frmDialogBox
        Dim myCommissionDate As String
        myDialogBox.cboYear.Minimum = 2009
        myDialogBox.cboYear.Maximum = 2010
        myDialogBox.cboYear.Value = 2010
        myDialogBox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        myCommissionDate = myDialogBox.CommissionDate
        CommDate = myDialogBox.CommissionDate

        'Compute the Attachment
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComIncAttach_Chiral", CommandType.StoredProcedure, 1)

        'Compute the ComInc
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComInc_Chiral", CommandType.StoredProcedure, 1)

        'Compute the DSM_Commission2008
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "DSM_Commission_2009_Chiral", CommandType.StoredProcedure, 1)

        'Compute the DSMPMR_det
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "DsmPmr_Det_2009_Chiral", CommandType.StoredProcedure, 1)

        'Compute the DSMPMR_ins
        Dim LocalCommand As New SqlCommand
        With LocalCommand
            .Connection = ObjectConnection(ServerPath2)
            .CommandText = "DsmPmr_Ins_2009Chiral"
            .CommandType = CommandType.StoredProcedure
            .ExecuteScalar()
        End With

        Dim myReportViewer As New frmReportViewer
        myReportViewer.Report = "DSM Commission Chiral 2010"
        myReportViewer.CommissionDate = myCommissionDate
        'myReportViewer.MdiParent = Me                       donot modify
        FrmShw(myReportViewer)              '.ShowDialog(Me)
    End Sub

    Private Sub Mnu_MedrepCommissionWithRecovery2010_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_MedrepCommissionWithRecovery2010.Click
        Dim myDialogBox As New frmDialogBox
        Dim myCommissionDate As String
        myDialogBox.cboYear.Minimum = 2010
        myDialogBox.cboYear.Maximum = 2010
        myDialogBox.cboYear.Value = 2010
        myDialogBox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        myCommissionDate = myDialogBox.CommissionDate

        'Compute the Attachment
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComIncAttach2010", CommandType.StoredProcedure, 1)

        'Compute the ComInc
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComInc2010", CommandType.StoredProcedure, 1)

        Dim myReportViewer As New frmReportViewer
        myReportViewer.Report = "Medrep Commission with Recovery2010"
        myReportViewer.CommissionDate = myCommissionDate
        'myReportViewer.MdiParent = Me                      donot modify
        FrmShw(myReportViewer)        '.ShowDialog(Me)
    End Sub

    Private Sub Mnu_MedrepCommissionWithRecovery2011_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_MedrepCommissionWithRecovery2011.Click
        Dim myDialogBox As New frmDialogBox
        Dim myCommissionDate As String
        myDialogBox.cboYear.Minimum = 2011
        myDialogBox.cboYear.Maximum = 2011
        myDialogBox.cboYear.Value = 2011
        myDialogBox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        myCommissionDate = myDialogBox.CommissionDate

        'Compute the Attachment
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComIncAttach2010", CommandType.StoredProcedure, 1)

        'Compute the ComInc
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComInc2011", CommandType.StoredProcedure, 1)

        Dim myReportViewer As New frmReportViewer
        myReportViewer.Report = "Medrep Commission with Recovery2011"
        myReportViewer.CommissionDate = myCommissionDate
        'myReportViewer.MdiParent = Me                      donot modify
        FrmShw(myReportViewer)        '.ShowDialog(Me)
    End Sub

    Private Sub Mnu_MedrepCommissionWithRecovery2012_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles Mnu_MedrepCommissionWithRecovery2012.Click
        Dim myDialogBox As New frmDialogBox
        Dim myCommissionDate As String
        myDialogBox.cboYear.Minimum = 2011
        myDialogBox.cboYear.Maximum = 2012
        myDialogBox.cboYear.Value = 2012
        myDialogBox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        myCommissionDate = myDialogBox.CommissionDate

        Try
            '[>>rnj_popoy**added
            'continue if get mycommission date is not equal to nothing 
            '02282013<<]
            If Not myCommissionDate = String.Empty Then
                'Compute the Attachment
                DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
                DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
                DataMaintenance.myParamArray(0, 2) = 10
                DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
                DataMaintenance.myParamArray(0, 4) = "Date"
                DataMaintenance.myParamArray(0, 5) = myCommissionDate
                DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComIncAttach2010", CommandType.StoredProcedure, 1)

                'Compute the ComInc
                DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
                DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
                DataMaintenance.myParamArray(0, 2) = 10
                DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
                DataMaintenance.myParamArray(0, 4) = "Date"
                DataMaintenance.myParamArray(0, 5) = myCommissionDate
                DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComInc2012", CommandType.StoredProcedure, 1)

                Dim myReportViewer As New frmReportViewer
                myReportViewer.Report = "Medrep Commission with Recovery2012"
                myReportViewer.CommissionDate = myCommissionDate
                'myReportViewer.MdiParent = Me                      donot modify
                FrmShw(myReportViewer)        '.ShowDialog(Me)
            Else
                Return '**return nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    '[>>rnj_popoy**added
    Private Sub Mnu_MedrepCommissionWithRecovery2013_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles Mnu_MedrepCommissionWithRecovery2013.Click
        Dim myDialogBox As New frmDialogBox
        Dim myCommissionDate As String
        myDialogBox.cboYear.Minimum = 2013
        myDialogBox.cboYear.Maximum = 2013
        myDialogBox.cboYear.Value = 2013
        myDialogBox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If

        myCommissionDate = myDialogBox.CommissionDate

        Try
            If Not myCommissionDate = String.Empty Then
                'Compute the Attachment
                DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
                DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
                DataMaintenance.myParamArray(0, 2) = 10
                DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
                DataMaintenance.myParamArray(0, 4) = "Date"
                DataMaintenance.myParamArray(0, 5) = myCommissionDate
                DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComIncAttach2010", CommandType.StoredProcedure, 1)

                'Compute the ComInc
                DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
                DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
                DataMaintenance.myParamArray(0, 2) = 10
                DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
                DataMaintenance.myParamArray(0, 4) = "Date"
                DataMaintenance.myParamArray(0, 5) = myCommissionDate
                DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComInc2013", CommandType.StoredProcedure, 1)

                Dim myReportViewer As New frmReportViewer
                myReportViewer.Report = "Medrep Commission with Recovery2013"
                myReportViewer.CommissionDate = myCommissionDate
                'myReportViewer.MdiParent = Me                      donot modify
                FrmShw(myReportViewer)        '.ShowDialog(Me)
            Else
                Return
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub '02282013<<]

    Private Sub Mnu_DistrictManagerCommissionWithRecovery2010_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_DistrictManagerCommissionWithRecovery2010.Click
        Dim myDialogBox As New frmDialogBox
        Dim myCommissionDate As String
        myDialogBox.cboYear.Minimum = 2010
        myDialogBox.cboYear.Maximum = 2010
        myDialogBox.cboYear.Value = 2010
        myDialogBox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        myCommissionDate = myDialogBox.CommissionDate

        'Compute the Attachment
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComIncAttach2010", _
                                       CommandType.StoredProcedure, 1)

        'Compute the ComInc
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComInc2010", _
                                       CommandType.StoredProcedure, 1)

        'Compute the DSM_Commission2008
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "DSM_Commission_2010", _
                                           CommandType.StoredProcedure, 1)

        'Compute the DSMPMR_det
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "DSMPMR_det2010", CommandType.StoredProcedure, 1)

        'Compute the DSMPMR_ins
        Dim LocalCommand As New SqlCommand
        With LocalCommand
            .Connection = ObjectConnection(ServerPath2)
            .CommandText = "DsmPmr_Ins_2010"
            .CommandType = CommandType.StoredProcedure
            .ExecuteScalar()
        End With

        Dim myReportViewer As New frmReportViewer
        myReportViewer.Report = "DSM Commission with Recovery2010"
        myReportViewer.CommissionDate = myCommissionDate
        'myReportViewer.MdiParent = Me                   donot modify
        FrmShw(myReportViewer)           '.ShowDialog(Me)
    End Sub

    Private Sub mnu_YTDpush_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_YTDpush.Click
        Dim myDialogBox As New frmDialogBox
        Dim myCommissionDate As String
        myDialogBox.cboYear.Minimum = 2009
        myDialogBox.cboYear.Maximum = 2010
        myDialogBox.cboYear.Value = 2009
        myDialogBox.cboMonth.SelectedIndex = 11     'setting the month to december & disabling the textbox
        myDialogBox.btnPreview.Select()             'focus on the button so that the noemps field wont validate
        myDialogBox.cboMonth.Enabled = False
        myDialogBox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        myCommissionDate = myDialogBox.CommissionDate

        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "YTDcommission2009Push", CommandType.StoredProcedure, 1)

        Dim myReportViewer As New frmReportViewer
        myReportViewer.Report = "PMR Year to date PushRecovery Commission"
        myReportViewer.CommissionDate = myCommissionDate
        'myReportViewer.MdiParent = Me                      donot modify
        FrmShw(myReportViewer)        '.ShowDialog(Me)
    End Sub

    Private Sub mnu_YTDpushDSM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_YTDpushDSM.Click
        Dim myDialogBox As New frmDialogBox
        Dim myCommissionDate As String
        myDialogBox.cboYear.Minimum = 2009
        myDialogBox.cboYear.Maximum = 2010
        myDialogBox.cboYear.Value = 2009
        myDialogBox.cboMonth.SelectedIndex = 11     'setting the month to december & disabling the textbox
        myDialogBox.btnPreview.Select()             'focus on the button so that the noemps field wont validate
        myDialogBox.cboMonth.Enabled = False
        myDialogBox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        myCommissionDate = myDialogBox.CommissionDate

        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "YTDcommission2009PushDSM", CommandType.StoredProcedure, 1)

        Dim myReportViewer As New frmReportViewer
        myReportViewer.Report = "DSM Year to date PushRecovery Commission"
        myReportViewer.CommissionDate = myCommissionDate
        'myReportViewer.MdiParent = Me                      donot modify
        FrmShw(myReportViewer)        '.ShowDialog(Me)
    End Sub

    Private Sub mnuMercBranAct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMercBranAct.Click
        Try
            Dim BusinessLayer As New BusinessLayer.clsFileMaintenance
            Dim RemoteDataSet As MBactive
            BusinessLayer.Sub_Show(ServerPath2, "MBTT_Ins", CommandType.StoredProcedure, RemoteDataSet, "MercBranchTmpTab")
            Dim MyReportViewer As New frmReportViewer
            Dim MyReport As New Rpt_ActiveMB
            MyReport.SetDataSource(CType(RemoteDataSet.MercBranchTmpTab, DataTable))
            MyReportViewer.ReportViewer.ReportSource = MyReport
            FrmShw(MyReportViewer)  '.ShowDialog(Me)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Mnu_CommissionAttachmentMH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_CommissionAttachmentMH.Click
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
        myDialogbox.cboYear.Minimum = 2009
        myDialogbox.cboYear.Maximum = 2011
        myDialogbox.cboYear.Value = 2011
        myDialogbox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        Try
            With myCommand
                .CommandText = "COMMISSION_ComputeAttachment_MH"
                .CommandType = CommandType.StoredProcedure
                .Connection = myConnection
                .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = myDialogbox.CommissionDate
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        myConnection.Close()

        Dim myLoadedForm As New frmReportViewer
        'myLoadedForm.MdiParent = Me           donot modify
        myLoadedForm.Report = "Commission Report Attachment MH"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        FrmShw(myLoadedForm)      '.ShowDialog(Me)
    End Sub

    Private Sub Mnu_MedrepCommissionWithRecoveryMH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_MedrepCommissionWithRecoveryMH.Click
        Dim myDialogBox As New frmDialogBox
        Dim myCommissionDate As String
        Dim NumOfEmps As String
        myDialogBox.cboYear.Minimum = 2009
        myDialogBox.cboYear.Maximum = 2011
        myDialogBox.cboYear.Value = 2011
        myDialogBox.GroupBox1.Height = 150
        myDialogBox.Height = 192
        myDialogBox.noEmps.Top = 82      'myDialogBox.noEmps.Top + 1000
        myDialogBox.LnoEmps.Top = 84     'myDialogBox.LnoEmps.Top + 1000
        myDialogBox.btnPreview.Top = 108
        myDialogBox.Button1.Top = 116
        myDialogBox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        myCommissionDate = myDialogBox.CommissionDate
        NumOfEmps = myDialogBox.NoOfEmps

        'Compute the Attachment
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComIncAttach_MH", CommandType.StoredProcedure, 1)

        'Compute the ComInc
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate

        DataMaintenance.myParamArray(1, 0) = "@prm_noEmps"
        DataMaintenance.myParamArray(1, 1) = SqlDbType.Int
        DataMaintenance.myParamArray(1, 2) = 10
        DataMaintenance.myParamArray(1, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(1, 4) = "Integer"     '<-OPTIONS for this are ("String", "Date", "Integer")
        DataMaintenance.myParamArray(1, 5) = NumOfEmps

        DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComInc_MH", CommandType.StoredProcedure, 2)

        Dim myReportViewer As New frmReportViewer
        myReportViewer.Report = "Medrep Commission MH 2010"
        myReportViewer.CommissionDate = myCommissionDate
        'myReportViewer.MdiParent = Me                      donot modify
        FrmShw(myReportViewer)         '.ShowDialog(Me)
    End Sub

    Private Sub Mnu_DSMCommissionAttachmentMH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_DSMCommissionAttachmentMH.Click
        'Dim myConnection As New SqlConnection
        'Dim myCommand As New SqlCommand
        'Try
        '    With myConnection
        '        .ConnectionString = ServerPath2
        '        .Open()
        '    End With
        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString)
        'End Try
        'Dim myDialogbox As New frmDialogBox
        'myDialogbox.cboYear.Minimum = 2009
        'myDialogbox.cboYear.Maximum = 2010
        'myDialogbox.cboYear.Value = 2010
        'myDialogbox.ShowDialog(Me)
        'If cancelProcess = True Then
        '    cancelProcess = False
        '    Exit Sub
        'End If
        'Try
        '    With myCommand
        '        .CommandText = "COMMISSION_ComputeAttachment_Chiral"
        '        .CommandType = CommandType.StoredProcedure
        '        .Connection = myConnection
        '        .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = myDialogbox.CommissionDate
        '        .ExecuteNonQuery()
        '    End With
        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString)
        'End Try
        'myConnection.Dispose()

        'Dim myLoadedForm As New frmReportViewer
        ''myLoadedForm.MdiParent = Me            donot modify
        'myLoadedForm.Report = "Commission Report Attachment(DSM)2009Chiral"
        'myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        'FrmShw(myLoadedForm)          '.ShowDialog(Me)
    End Sub

    Private Sub Mnu_DSMCommissionWithRecoveryMH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_DSMCommissionWithRecoveryMH.Click
        'Dim myDialogBox As New frmDialogBox
        'Dim myCommissionDate As String
        'myDialogBox.cboYear.Minimum = 2009
        'myDialogBox.cboYear.Maximum = 2010
        'myDialogBox.cboYear.Value = 2010
        'myDialogBox.ShowDialog(Me)
        'If cancelProcess = True Then
        '    cancelProcess = False
        '    Exit Sub
        'End If
        'myCommissionDate = myDialogBox.CommissionDate
        'CommDate = myDialogBox.CommissionDate

        ''Compute the Attachment
        'DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        'DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        'DataMaintenance.myParamArray(0, 2) = 10
        'DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        'DataMaintenance.myParamArray(0, 4) = "Date"
        'DataMaintenance.myParamArray(0, 5) = myCommissionDate
        'DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComIncAttach_Chiral", CommandType.StoredProcedure, 1)

        ''Compute the ComInc
        'DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        'DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        'DataMaintenance.myParamArray(0, 2) = 10
        'DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        'DataMaintenance.myParamArray(0, 4) = "Date"
        'DataMaintenance.myParamArray(0, 5) = myCommissionDate
        'DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComInc_Chiral", CommandType.StoredProcedure, 1)

        ''Compute the DSM_Commission2008
        'DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        'DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        'DataMaintenance.myParamArray(0, 2) = 10
        'DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        'DataMaintenance.myParamArray(0, 4) = "Date"
        'DataMaintenance.myParamArray(0, 5) = myCommissionDate
        'DataMaintenance.ExecuteCommand(ServerPath2, "DSM_Commission_2009_Chiral", CommandType.StoredProcedure, 1)

        ''Compute the DSMPMR_det
        'DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        'DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        'DataMaintenance.myParamArray(0, 2) = 10
        'DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        'DataMaintenance.myParamArray(0, 4) = "Date"
        'DataMaintenance.myParamArray(0, 5) = myCommissionDate
        'DataMaintenance.ExecuteCommand(ServerPath2, "DsmPmr_Det_2009_Chiral", CommandType.StoredProcedure, 1)

        ''Compute the DSMPMR_ins
        'Dim LocalCommand As New SqlCommand
        'With LocalCommand
        '    .Connection = ObjectConnection(ServerPath2)
        '    .CommandText = "DsmPmr_Ins_2009Chiral"
        '    .CommandType = CommandType.StoredProcedure
        '    .ExecuteScalar()
        'End With

        'Dim myReportViewer As New frmReportViewer
        'myReportViewer.Report = "DSM Commission Chiral 2010"
        'myReportViewer.CommissionDate = myCommissionDate
        ''myReportViewer.MdiParent = Me                       donot modify
        'FrmShw(myReportViewer)              '.ShowDialog(Me)
    End Sub

    Private Sub mnu_DistributeReportsMH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_DistributeReportsMH.Click
        MHdist = True
        Dim myLoadedForm As New frmDistributeReports
        'myLoadedForm.MdiParent = Me                   donot modify
        FrmShw(myLoadedForm)         '.ShowDialog(Me)
    End Sub

    Private Sub mnu_MDIperBDS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_MDIperBDS.Click
        'Get the respective Teritories per BDS
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
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        Try
            With myCommand
                .CommandText = "GetTerritoriesPerMedrepMH"
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
        'myLoadedForm.MdiParent = Me                 
        'myLoadedForm.StartPosition = FormStartPosition.CenterScreen
        'myLoadedForm.ShowDialog(Me)                                   <--code before
        myLoadedForm.Report = "Mdi Sales Per Medrep MH"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        FrmShw(myLoadedForm)         '<--replacement of the code before
    End Sub

    Private Sub mnu_MercurySalesBDS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_MercurySalesBDS.Click
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
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        Try
            With myCommand
                .CommandText = "Transfer_MercurySalesIntoTemporaryMH"
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
        myLoadedForm.Report = "Mercury Sales MH"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        FrmShw(myLoadedForm)
    End Sub

    Private Sub Mnu_CommissionAttachmentFLT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_CommissionAttachmentFLT.Click
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
        myDialogbox.cboYear.Minimum = 2009
        myDialogbox.cboYear.Maximum = 2010
        myDialogbox.cboYear.Value = 2010
        myDialogbox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        Try
            With myCommand
                .CommandText = "COMMISSION_ComputeAttachment_FLT"
                .CommandType = CommandType.StoredProcedure
                .Connection = myConnection
                .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = myDialogbox.CommissionDate
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        myConnection.Close()

        Dim myLoadedForm As New frmReportViewer
        'myLoadedForm.MdiParent = Me           donot modify
        myLoadedForm.Report = "Commission Report Attachment FLT"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        FrmShw(myLoadedForm)      '.ShowDialog(Me)
    End Sub

    Private Sub Mnu_MedrepCommissionWithRecoveryFLT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_MedrepCommissionWithRecoveryFLT.Click
        Dim myDialogBox As New frmDialogBox
        Dim myCommissionDate As String
        Dim NumOfEmps As String
        myDialogBox.cboYear.Minimum = 2009
        myDialogBox.cboYear.Maximum = 2010
        myDialogBox.cboYear.Value = 2010
        'myDialogBox.GroupBox1.Height = 150
        'myDialogBox.Height = 192
        'myDialogBox.noEmps.Top = 82      'myDialogBox.noEmps.Top + 1000
        'myDialogBox.LnoEmps.Top = 84     'myDialogBox.LnoEmps.Top + 1000
        'myDialogBox.btnPreview.Top = 108
        'myDialogBox.Button1.Top = 116
        myDialogBox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        myCommissionDate = myDialogBox.CommissionDate
        'NumOfEmps = myDialogBox.NoOfEmps

        'Compute the Attachment
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComIncAttach_FLT", CommandType.StoredProcedure, 1)

        'Compute the ComInc
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComInc_FLT", CommandType.StoredProcedure, 1)

        Dim myReportViewer As New frmReportViewer
        myReportViewer.Report = "Medrep Commission FLT 2010"
        myReportViewer.CommissionDate = myCommissionDate
        'myReportViewer.MdiParent = Me                      donot modify
        FrmShw(myReportViewer)         '.ShowDialog(Me)
    End Sub

    Private Sub mnu_MdiPerMedrepFLT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_MdiPerMedrepFLT.Click
        'Get the respective Teritories per BDS
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
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        'Try                                                      <-- no territories as instructed by sir Efren
        '    With myCommand
        '        .CommandText = "GetTerritoriesPerMedrepFLT"
        '        .CommandType = CommandType.StoredProcedure
        '        .Connection = myConnection
        '        .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = myDialogbox.CommissionDate
        '        .ExecuteNonQuery()
        '    End With
        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString)
        'End Try
        myConnection.Dispose()

        Dim myLoadedForm As New frmReportViewer
        'myLoadedForm.MdiParent = Me                 
        'myLoadedForm.StartPosition = FormStartPosition.CenterScreen
        'myLoadedForm.ShowDialog(Me)                                   <--code before
        myLoadedForm.Report = "Mdi Sales Per Medrep FLT"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        FrmShw(myLoadedForm)         '<--replacement of the code before
    End Sub

    Private Sub mnu_MercurySalesFLT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_MercurySalesFLT.Click
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
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        Try
            With myCommand
                .CommandText = "Transfer_MercurySalesIntoTemporaryFLT"
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
        myLoadedForm.Report = "Mercury Sales FLT"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        FrmShw(myLoadedForm)
    End Sub

    Private Sub Mnu_MedrepCommissionWithRecovery2010BioM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_MedrepCommissionWithRecovery2010BioM.Click
        Dim myDialogBox As New frmDialogBox
        Dim myCommissionDate As String
        myDialogBox.cboYear.Minimum = 2010
        myDialogBox.cboYear.Maximum = 2010
        myDialogBox.cboYear.Value = 2010

        myDialogBox.cboMonth.Items.Clear()
        myDialogBox.cboMonth.Items.Add("August")
        myDialogBox.cboMonth.Items.Add("September")
        myDialogBox.cboMonth.Items.Add("October")
        myDialogBox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        myCommissionDate = myDialogBox.CommissionDate

        'Compute the Attachment
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComIncAttach2010", CommandType.StoredProcedure, 1)

        'Compute the ComInc
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComInc2010", CommandType.StoredProcedure, 1)

        Dim myReportViewer As New frmReportViewer
        myReportViewer.Report = "Medrep Commission with Recovery2010 Biomedica"
        myReportViewer.CommissionDate = myCommissionDate
        'myReportViewer.MdiParent = Me                      donot modify
        FrmShw(myReportViewer)        '.ShowDialog(Me)
    End Sub

    Private Sub Mnu_DistrictManagerCommissionWithRecovery2010Biomedica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_DistrictManagerCommissionWithRecovery2010Biomedica.Click
        Dim myDialogBox As New frmDialogBox
        Dim myCommissionDate As String
        myDialogBox.cboYear.Minimum = 2010
        myDialogBox.cboYear.Maximum = 2010
        myDialogBox.cboYear.Value = 2010

        myDialogBox.cboMonth.Items.Clear()
        myDialogBox.cboMonth.Items.Add("August")
        myDialogBox.cboMonth.Items.Add("September")
        myDialogBox.cboMonth.Items.Add("October")
        myDialogBox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        myCommissionDate = myDialogBox.CommissionDate

        'Compute the Attachment
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComIncAttach2010", _
                                       CommandType.StoredProcedure, 1)

        'Compute the ComInc
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComInc2010", _
                                       CommandType.StoredProcedure, 1)

        'Compute the DSM_Commission2008
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "DSM_Commission_2010", _
                                           CommandType.StoredProcedure, 1)

        'Compute the DSMPMR_det
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "DSMPMR_det2010", CommandType.StoredProcedure, 1)

        'Compute the DSMPMR_ins
        Dim LocalCommand As New SqlCommand
        With LocalCommand
            .Connection = ObjectConnection(ServerPath2)
            .CommandText = "DsmPmr_Ins_2010"
            .CommandType = CommandType.StoredProcedure
            .ExecuteScalar()
        End With

        Dim myReportViewer As New frmReportViewer
        myReportViewer.Report = "DSM Commission with Recovery2010 Biomedica"
        myReportViewer.CommissionDate = myCommissionDate
        'myReportViewer.MdiParent = Me                   donot modify
        FrmShw(myReportViewer)           '.ShowDialog(Me)
    End Sub

    Private Sub Mnu_DistrictManagerCommissionWithRecovery2011_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_DistrictManagerCommissionWithRecovery2011.Click
        Dim myDialogBox As New frmDialogBox
        Dim myCommissionDate As String
        myDialogBox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        myCommissionDate = myDialogBox.CommissionDate

        'Compute the Attachment
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComIncAttach2010", _
                                       CommandType.StoredProcedure, 1)

        'Compute the ComInc
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComInc2011", _
                                       CommandType.StoredProcedure, 1)

        'Compute the DSM_Commission2008
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "DSM_Commission_2011", _
                                           CommandType.StoredProcedure, 1)

        'Compute the DSMPMR_det
        DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = myCommissionDate
        DataMaintenance.ExecuteCommand(ServerPath2, "DSMPMR_det2010", CommandType.StoredProcedure, 1)

        'Compute the DSMPMR_ins
        Dim LocalCommand As New SqlCommand
        With LocalCommand
            .Connection = ObjectConnection(ServerPath2)
            .CommandText = "DsmPmr_Ins_2010"
            .CommandType = CommandType.StoredProcedure
            .ExecuteScalar()
        End With

        Dim myReportViewer As New frmReportViewer
        myReportViewer.Report = "DSM Commission with Recovery2011"
        myReportViewer.CommissionDate = myCommissionDate
        'myReportViewer.MdiParent = Me                   donot modify
        FrmShw(myReportViewer)           '.ShowDialog(Me)
    End Sub

    Private Sub Mnu_DistrictManagerCommissionWithRecovery2012_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles Mnu_DistrictManagerCommissionWithRecovery2012.Click
        Dim myDialogBox As New frmDialogBox
        Dim myCommissionDate As String
        myDialogBox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        myCommissionDate = myDialogBox.CommissionDate

        Try
            '[>>rnj_popoy**added
            'continue if get mycommission date is not equal to nothing 
            '02282013<<]
            If Not myCommissionDate = String.Empty Then
                'Compute the Attachment
                DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
                DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
                DataMaintenance.myParamArray(0, 2) = 10
                DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
                DataMaintenance.myParamArray(0, 4) = "Date"
                DataMaintenance.myParamArray(0, 5) = myCommissionDate
                DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComIncAttach2010", _
                                               CommandType.StoredProcedure, 1)

                'Compute the ComInc
                DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
                DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
                DataMaintenance.myParamArray(0, 2) = 10
                DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
                DataMaintenance.myParamArray(0, 4) = "Date"
                DataMaintenance.myParamArray(0, 5) = myCommissionDate
                DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComInc2012", _
                                               CommandType.StoredProcedure, 1)

                'Compute the DSM_Commission2008
                DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
                DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
                DataMaintenance.myParamArray(0, 2) = 10
                DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
                DataMaintenance.myParamArray(0, 4) = "Date"
                DataMaintenance.myParamArray(0, 5) = myCommissionDate
                DataMaintenance.ExecuteCommand(ServerPath2, "DSM_Commission_2012", _
                                                   CommandType.StoredProcedure, 1)

                'Compute the DSMPMR_det
                DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
                DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
                DataMaintenance.myParamArray(0, 2) = 10
                DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
                DataMaintenance.myParamArray(0, 4) = "Date"
                DataMaintenance.myParamArray(0, 5) = myCommissionDate
                DataMaintenance.ExecuteCommand(ServerPath2, "DSMPMR_det2010", CommandType.StoredProcedure, 1)

                'Compute the DSMPMR_ins
                Dim LocalCommand As New SqlCommand
                With LocalCommand
                    .Connection = ObjectConnection(ServerPath2)
                    .CommandText = "DsmPmr_Ins_2010"
                    .CommandType = CommandType.StoredProcedure
                    .ExecuteScalar()
                End With

                Dim myReportViewer As New frmReportViewer
                myReportViewer.Report = "DSM Commission with Recovery2012"
                myReportViewer.CommissionDate = myCommissionDate
                'myReportViewer.MdiParent = Me                   donot modify
                FrmShw(myReportViewer)           '.ShowDialog(Me)
            Else
                Return '**return nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    '[>>rnj_popoy**added
    Private Sub Mnu_DistrictManagerCommissionWithRecovery2013_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles Mnu_DistrictManagerCommissionWithRecovery2013.Click
        Dim myDialogBox As New frmDialogBox
        Dim myCommissionDate As String
        myDialogBox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        myCommissionDate = myDialogBox.CommissionDate

        Try
            If Not myCommissionDate = String.Empty Then
                'Compute the Attachment
                DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
                DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
                DataMaintenance.myParamArray(0, 2) = 10
                DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
                DataMaintenance.myParamArray(0, 4) = "Date"
                DataMaintenance.myParamArray(0, 5) = myCommissionDate
                DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComIncAttach2010", _
                                               CommandType.StoredProcedure, 1)

                'Compute the ComInc
                DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
                DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
                DataMaintenance.myParamArray(0, 2) = 10
                DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
                DataMaintenance.myParamArray(0, 4) = "Date"
                DataMaintenance.myParamArray(0, 5) = myCommissionDate
                DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComInc2013", _
                                               CommandType.StoredProcedure, 1)

                'Compute the DSM_Commission_2013
                DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
                DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
                DataMaintenance.myParamArray(0, 2) = 10
                DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
                DataMaintenance.myParamArray(0, 4) = "Date"
                DataMaintenance.myParamArray(0, 5) = myCommissionDate
                DataMaintenance.ExecuteCommand(ServerPath2, "DSM_Commission_2013", _
                                                   CommandType.StoredProcedure, 1)

                'Compute the DsmPmr_Det2013
                DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
                DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
                DataMaintenance.myParamArray(0, 2) = 10
                DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
                DataMaintenance.myParamArray(0, 4) = "Date"
                DataMaintenance.myParamArray(0, 5) = myCommissionDate
                DataMaintenance.ExecuteCommand(ServerPath2, "DsmPmr_Det2013", CommandType.StoredProcedure, 1)

                'Compute the DSMPMR_ins
                Dim LocalCommand As New SqlCommand
                With LocalCommand
                    .Connection = ObjectConnection(ServerPath2)
                    .CommandText = "DsmPmr_Ins_2010"
                    .CommandType = CommandType.StoredProcedure
                    .ExecuteScalar()
                End With

                Dim myReportViewer As New frmReportViewer
                myReportViewer.Report = "DSM Commission with Recovery2013"
                myReportViewer.CommissionDate = myCommissionDate
                'myReportViewer.MdiParent = Me                   donot modify
                FrmShw(myReportViewer)           '.ShowDialog(Me)
            Else
                Return
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub '02272013<<]

    Private Sub Mnu_ProcessMercuryDataSept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_ProcessMercuryDataSept.Click
        Dim myLoadedForm As New frmProcessMercuryDataSept
        FrmShw(myLoadedForm)
    End Sub
    '[>>rnj_popoy**added
    Private Sub MenuItem119_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim myLoadedForm As New frmDistrictSupervisorMaint
        FrmShw(myLoadedForm)
    End Sub '10012012<<]

    '[>>rnj_popoy**added
    Private Sub MenuItem120_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim myLoadedForm As New frmTerritoryAreaMaint
        FrmShw(myLoadedForm)
    End Sub '11272012<<]

    '[>>rnj_popoy**added
    Private Sub MenuItem121_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim myLoadedForm As New frmBudgetDirectPerDistributor
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem123_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles MenuItem123.Click
        Me.Cursor = Cursors.WaitCursor
        Dim Params(0) As SqlParameter
        Dim myDialogbox As New frmDialogBox
        Dim _sCommissionDate As String
        Dim xMyDataSets As New MyDataSets
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance

        myDialogbox.ShowDialog(Me)
        _sCommissionDate = myDialogbox.CommissionDate

        If cancelProcess = True Then
            cancelProcess = False
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        If xMyDataSets.GetTerritoriesPerMedrep.Count > 0 _
            Then xMyDataSets.GetTerritoriesPerMedrep.Clear()

        Try
            If Not _sCommissionDate = String.Empty Then
                Dim _CommissionDate As New SqlParameter("@CommissionDate", SqlDbType.DateTime, 10)
                _CommissionDate.Direction = ParameterDirection.Input
                _CommissionDate.Value = _sCommissionDate
                Params(0) = _CommissionDate

                BusinessObject.Sub_Show(ServerPath, "GetTerritoriesPerMedrep", CommandType.StoredProcedure, _
                    xMyDataSets, "GetTerritoriesPerMedrep", Params)

                Try
                    Dim myLoadedForm As New frmReportViewer
                    myLoadedForm.Report = "Sales per KAS Govt"
                    myLoadedForm.CommissionDate = _sCommissionDate
                    FrmShw(myLoadedForm)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            Else
                Me.Cursor = Cursors.Default
                Return
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub '03182013<<]
    '[>>rnj_popoy**added
    Private Sub MenuItem124_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles MenuItem124.Click
        Me.Cursor = Cursors.WaitCursor
        Dim Params(0) As SqlParameter
        Dim myDialogbox As New frmDialogBox
        Dim _sCommissionDate As String
        Dim xMyDataSets As New MyDataSets
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance

        myDialogbox.cboYear.Minimum = 2013
        myDialogbox.cboYear.Maximum = 2014
        myDialogbox.cboYear.Value = 2014
        myDialogbox.ShowDialog(Me)
        _sCommissionDate = myDialogbox.CommissionDate

        If cancelProcess = True Then
            cancelProcess = False
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        If xMyDataSets.commission_computeattachment_kasgovt.Count > 0 _
            Then xMyDataSets.commission_computeattachment_kasgovt.Clear()

        Try
            If Not _sCommissionDate = String.Empty Then
                Dim _CommissionDate As New SqlParameter("@CommissionDate", SqlDbType.DateTime, 10)
                _CommissionDate.Direction = ParameterDirection.Input
                _CommissionDate.Value = _sCommissionDate
                Params(0) = _CommissionDate

                BusinessObject.Sub_Show(ServerPath2, "commission_computeattachment_kasgovt", CommandType.StoredProcedure, _
                    xMyDataSets, "commission_computeattachment_kasgovt", Params)

                Try
                    Dim myLoadedForm As New frmReportViewer
                    myLoadedForm.Report = "Commission Report Attachment KAS Govt"
                    myLoadedForm.CommissionDate = _sCommissionDate
                    FrmShw(myLoadedForm)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            Else
                Me.Cursor = Cursors.Default
                Return
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub '03202013<<]
    '[>>rnj_popoy**added
    Private Sub MenuItem125_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles MenuItem125.Click
        Me.Cursor = Cursors.WaitCursor
        Dim Params(0) As SqlParameter
        Dim myDialogBox As New frmDialogBox
        Dim _sCommissionDate As String
        Dim xMyDataSets As New MyDataSets
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance

        myDialogBox.cboYear.Minimum = 2013
        myDialogBox.cboYear.Maximum = 2014
        myDialogBox.cboYear.Value = 2014
        myDialogBox.ShowDialog(Me)
        _sCommissionDate = myDialogBox.CommissionDate

        If cancelProcess = True Then
            cancelProcess = False
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        If xMyDataSets.Compute_ComIncAttachKAS.Count > 0 _
            Then xMyDataSets.Compute_ComIncAttachKAS.Clear()

        If xMyDataSets.Compute_ComIncKAS.Count > 0 _
            Then xMyDataSets.Compute_ComIncKAS.Clear()

        Try
            If Not _sCommissionDate = String.Empty Then
                Try
                    Dim _CommissionDate As New SqlParameter("@CommissionDate", SqlDbType.DateTime, 10)
                    _CommissionDate.Direction = ParameterDirection.Input
                    _CommissionDate.Value = _sCommissionDate
                    Params(0) = _CommissionDate

                    BusinessObject.Sub_Show(ServerPath2, "Compute_ComIncAttachKAS", CommandType.StoredProcedure, _
                        xMyDataSets, "Compute_ComIncAttachKAS", Params)

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                Try
                    Dim _CommissionDate As New SqlParameter("@CommissionDate", SqlDbType.DateTime, 10)
                    _CommissionDate.Direction = ParameterDirection.Input
                    _CommissionDate.Value = _sCommissionDate
                    Params(0) = _CommissionDate

                    BusinessObject.Sub_Show(ServerPath2, "Compute_ComIncKAS", CommandType.StoredProcedure, _
                        xMyDataSets, "Compute_ComIncKAS", Params)

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                Dim myReportViewer As New frmReportViewer
                myReportViewer.Report = "KAS - Government Commission Report"
                myReportViewer.CommissionDate = _sCommissionDate
                FrmShw(myReportViewer)
            Else
                Me.Cursor = Cursors.Default
                Return
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub '03212013<<]

    Private Sub MenuItem127_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem127.Click

        Dim myForm As New About
        myForm.ShowDialog(Me)
        myForm.Dispose()

    End Sub


    Private Sub MenuItem128_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem128.Click

        Dim thisForm As New MdiWeeklySalesInvoiceExport
        thisForm.ShowDialog(Me)
        thisForm.Dispose()

    End Sub

    Private Sub MenuItem130_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MyLoadedForm As New ProductFormCT
        FrmShw(MyLoadedForm)
    End Sub

    Private Sub MenuItem132_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem132.Click
        Dim myLoadedForm As New SupMr
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem133_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem133.Click
        Dim MyLoadedForm As New SupervisorCT
        FrmShw(MyLoadedForm)
    End Sub

    Private Sub MenuItem15_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        Dim myLoadedForm As New NsmCT
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem134_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem134.Click
        Dim MyLoadedForm As New CallRateBudgetCT
        FrmShw(MyLoadedForm)
    End Sub

    Private Sub MenuItem12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        Dim MyLoadedForm As New CallRateCT
        FrmShw(MyLoadedForm)
    End Sub

    Private Sub MenuItem136_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MyLoadedForm As New CustomerCT
        FrmShw(MyLoadedForm)
    End Sub

    Private Sub MenuItem11_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MyLoadedForm As New frmExCustomers
        FrmShw(MyLoadedForm)
    End Sub

    Private Sub MenuItem137_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem137.Click
        Dim MyLoadedForm As New ItemCT
        FrmShw(MyLoadedForm)
    End Sub

    Private Sub MenuItem138_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem138.Click
        Dim MyLoadedForm As New ProductLineCT
        FrmShw(MyLoadedForm)
    End Sub

    Private Sub MenuItem139_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem139.Click
        Dim MyLoadedForm As New ProductFormCT
        FrmShw(MyLoadedForm)
    End Sub

    Private Sub MenuItem140_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem140.Click
        Dim MyLoadedForm As New PrincipalCT
        FrmShw(MyLoadedForm)
    End Sub

    Private Sub MenuItem141_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem141.Click
        Dim MyLoadedForm As New DivisionCT
        FrmShw(MyLoadedForm)
    End Sub

    Private Sub MenuItem72_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem72.Click
        Dim MyLoadedForm As New CustomerCT
        FrmShw(MyLoadedForm)
    End Sub

    Private Sub MenuItem74_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem74.Click
        Dim MyLoadedForm As New CustomerTypeCT
        FrmShw(MyLoadedForm)
    End Sub

    Private Sub MenuItem78_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem78.Click
        Dim MyLoadedForm As New frmExCustomers
        FrmShw(MyLoadedForm)
    End Sub

    Private Sub MenuItem87_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem87.Click
        Dim MyLoadedForm As New TerritoryCT
        FrmShw(MyLoadedForm)
    End Sub

    Private Sub MenuItem130_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem130.Click
        Dim MyLoadedForm As New ProvinceCT
        FrmShw(MyLoadedForm)
    End Sub

    Private Sub MenuItem11_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        Dim MyLoadedForm As New MedRepTerAssign
        FrmShw(MyLoadedForm)
    End Sub

    Private Sub MenuItem71_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem71.Click
        Dim myLoadedForm As New frmBudgetDirect
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem44_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem44.Click
        Dim myLoadedForm As New frmUserMaint
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem81_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem81.Click
        Dim MyLoadedForm As New BudgetOsCT
        FrmShw(MyLoadedForm)
    End Sub

    Private Sub MenuItem101_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem101.Click
        Dim MyLoadedForm As New MedRepCT
        'MyLoadedForm.MdiParent = Me
        'MyLoadedForm.StartPosition = FormStartPosition.CenterScreen
        FrmShw(MyLoadedForm)    '.ShowDialog(Me)
    End Sub
    Private Sub MenuItem75_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem75.Click
        Dim MyLoadedForm As New GroupCT
        FrmShw(MyLoadedForm)
    End Sub

    Private Sub MenuItem73_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem73.Click
        'Dim myLoadedForm As New EditIntegratedSales     'EditIntegratedSalesMercury
        'FrmShw(myLoadedForm)
        Dim thisForm As New SalesAdjustments
        FrmShw(thisForm)

    End Sub

    Private Sub MenuItem136_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem136.Click
        Dim myLoadedForm As New EditIntegratedSalesMercury
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem142_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem142.Click
        Dim myLoadedForm As New frmBudgetDirectPerDistributor
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem143_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem143.Click
        Dim MyLoadedForm As New frmItemBudget
        FrmShw(MyLoadedForm)
    End Sub

    Private Sub MenuItem144_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem144.Click
        Dim myLoadedForm As New frmBudgetPMR    'frmBudgetPmrModernTrade
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem145_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem145.Click
        Dim myLoadedForm As New frmBudgetPmrModernTrade
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem79_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem79.Click
        Dim myLoadedForm As New frmDistrictSupervisorMaint
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem83_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem83.Click
        Dim myLoadedForm As New frmTerritoryAreaMaint
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem84_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem84.Click
        Dim MyLoadedForm As New TeamDivisionCT
        FrmShw(MyLoadedForm)
    End Sub

    Private Sub MenuItem86_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem86.Click
        Dim MyLoadedForm As New PM_CT
        FrmShw(MyLoadedForm)
    End Sub

    Private Sub MenuItem82_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem82.Click
        Dim thisForm As New MergedStockTransferExport
        thisForm.ShowDialog(Me)
        thisForm.Dispose()
    End Sub

    Private Sub MenuItem90_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem90.Click
        Dim thisForm As New CustomerShipToMaster_Tagging
        thisForm.ShowDialog(Me)
        thisForm.Dispose()
    End Sub

    Private Sub MenuItem102_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem102.Click
        Dim thisForm As New CustomerShipToMaster
        thisForm.ShowDialog(Me)
        thisForm.Dispose()
    End Sub

    Private Sub MenuItem119_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem119.Click
        Dim thisForm As New NewBusinessRuleMaintenance
        thisForm.ShowDialog(Me)
        thisForm.Dispose()
    End Sub

    Private Sub MenuItem120_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem120.Click
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
        If SalesControlDiscrepancy() Then
            Exit Sub
        End If
        Dim myDialogbox As New frmDialogBox
        myDialogbox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
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
        'myLoadedForm.MdiParent = Me                 
        'myLoadedForm.StartPosition = FormStartPosition.CenterScreen
        'myLoadedForm.ShowDialog(Me)                                   <--code before
        myLoadedForm.Report = "Mdi Sales Per Medrep(Trade)"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        FrmShw(myLoadedForm)         '<--replacement of the code before
    End Sub

    Private Sub MenuItem121_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem121.Click
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
        If SalesControlDiscrepancy() Then
            Exit Sub
        End If
        Dim myDialogbox As New frmDialogBox
        myDialogbox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        Try
            With myCommand
                .CommandText = "Transfer_TradeMercurySalesIntoTemporary"
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
        myLoadedForm.Report = "Mercury Sales(Trade)"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem146_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem146.Click
        Dim frmutil As frmUtility = New frmUtility
        frmutil.ShowDialog()
    End Sub

    Private Sub MenuItem147_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem147.Click
        Dim myDialogBox As New frmDialogBox
        Dim myCommissionDate As String
        myDialogBox.cboYear.Minimum = 2014
        myDialogBox.cboYear.Maximum = 2014
        myDialogBox.cboYear.Value = 2014
        myDialogBox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If

        myCommissionDate = myDialogBox.CommissionDate

        Try
            If Not myCommissionDate = String.Empty Then
                'Compute the Attachment
                DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
                DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
                DataMaintenance.myParamArray(0, 2) = 10
                DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
                DataMaintenance.myParamArray(0, 4) = "Date"
                DataMaintenance.myParamArray(0, 5) = myCommissionDate
                DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComIncAttach2014", CommandType.StoredProcedure, 1)

                'Compute the ComInc
                DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
                DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
                DataMaintenance.myParamArray(0, 2) = 10
                DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
                DataMaintenance.myParamArray(0, 4) = "Date"
                DataMaintenance.myParamArray(0, 5) = myCommissionDate
                DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComInc2014", CommandType.StoredProcedure, 1)

                Dim myReportViewer As New frmReportViewer
                myReportViewer.Report = "Medrep Commission with Recovery2014"
                myReportViewer.CommissionDate = myCommissionDate
                'myReportViewer.MdiParent = Me                      donot modify
                FrmShw(myReportViewer)        '.ShowDialog(Me)
            Else
                Return
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub MenuItem148_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem148.Click
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
        myDialogbox.cboYear.Minimum = 2009
        myDialogbox.cboYear.Maximum = 2014
        myDialogbox.cboYear.Value = 2014
        myDialogbox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        Try
            With myCommand
                .CommandText = "COMMISSION_ComputeAttachment2014"
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
        myLoadedForm.Report = "Commission Report Attachment 2014"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem149_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem149.Click
        Dim myDialogBox As New frmDialogBox
        Dim myCommissionDate As String
        myDialogBox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        myCommissionDate = myDialogBox.CommissionDate

        Try
            If Not myCommissionDate = String.Empty Then
                'Compute the Attachment
                DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
                DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
                DataMaintenance.myParamArray(0, 2) = 10
                DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
                DataMaintenance.myParamArray(0, 4) = "Date"
                DataMaintenance.myParamArray(0, 5) = myCommissionDate
                DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComIncAttach2010", _
                                               CommandType.StoredProcedure, 1)

                'Compute the ComInc
                DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
                DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
                DataMaintenance.myParamArray(0, 2) = 10
                DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
                DataMaintenance.myParamArray(0, 4) = "Date"
                DataMaintenance.myParamArray(0, 5) = myCommissionDate
                DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComInc2013", _
                                               CommandType.StoredProcedure, 1)

                'Compute the DSM_Commission_2013
                DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
                DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
                DataMaintenance.myParamArray(0, 2) = 10
                DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
                DataMaintenance.myParamArray(0, 4) = "Date"
                DataMaintenance.myParamArray(0, 5) = myCommissionDate
                DataMaintenance.ExecuteCommand(ServerPath2, "DSM_Commission_2014", _
                                                   CommandType.StoredProcedure, 1)

                'Compute the DsmPmr_Det2013
                DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
                DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
                DataMaintenance.myParamArray(0, 2) = 10
                DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
                DataMaintenance.myParamArray(0, 4) = "Date"
                DataMaintenance.myParamArray(0, 5) = myCommissionDate
                DataMaintenance.ExecuteCommand(ServerPath2, "DsmPmr_Det2014", CommandType.StoredProcedure, 1)

                'Compute the DSMPMR_ins
                'rename DsmPmr_Ins_2010 to DsmPmr_Ins_2014 by ARValdez 04022014
                Dim LocalCommand As New SqlCommand
                With LocalCommand
                    .Connection = ObjectConnection(ServerPath2)
                    .CommandText = "DsmPmr_Ins_2014"
                    .CommandType = CommandType.StoredProcedure
                    .ExecuteScalar()
                End With

                Dim myReportViewer As New frmReportViewer
                myReportViewer.Report = "DSM Commission with Recovery2014"
                myReportViewer.CommissionDate = myCommissionDate
                'myReportViewer.MdiParent = Me                   donot modify
                FrmShw(myReportViewer)           '.ShowDialog(Me)
            Else
                Return
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem150_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem150.Click
        Dim myLoadedForm As New frmProcessTradeReport
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem153_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem153.Click
        Dim myLoadedForm As New frmGenerateNMPCSalesUpdate
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem154_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem154.Click
        Dim myLoadedForm As New frmDailySalesUpdateUtil
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem155_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem155.Click
        Dim myLoadedForm As New frmGenerateInvoiceList
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem157_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem157.Click
        Dim myLoadedForm As New frmBudgetForSpecialist
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem166_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem166.Click
        Dim myLoadedForm As New frmCMReportPivot
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem162_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem162.Click
        Dim myLoadedForm As New frmSalesTrendDirect
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem161_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem161.Click
        Dim myLoadedForm As New frmAverageSellingPrice
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem163_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem163.Click
        Dim myLoadedForm As New frmCalendarizedItemSales
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem165_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem165.Click
        Dim myLoadedForm As New frmSalesMarketingIncentives_vb
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem167_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem167.Click
        Dim myLoadedForm As New frmBRReports
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem164_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem164.Click
        Dim myLoadedForm As New frmIMSInhouseReport
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem160_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem160.Click
        Dim myLoadedForm As New frmAccountCoverage
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem169_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem169.Click
        Dim myLoadedForm As New frmGloboSubDist
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem170_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem170.Click
        Dim myLoadedForm As New frmBarrXselSubDist
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem171_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem171.Click
        Dim myLoadedForm As New frmGBSubDist
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem172_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem172.Click
        Dim myLoadedForm As New frmSouthStarSubDist
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem173_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem173.Click
        Dim myLoadedForm As New frm518SubDist
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem158_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem158.Click
        Dim myLoadedForm As New frmBudgetForDirect
        FrmShw(myLoadedForm)

    End Sub

    Private Sub MenuItem175_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem175.Click
        Dim myLoadedForm As New frmIntegratedSales
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem177_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem177.Click
        Dim MyDate As Date
        MyDate = Now
        Dim dayinWeek As Integer
        dayinWeek = GetWeekInMonth(MyDate)
        'MessageBox.Show(dayinWeek.ToString)


        Dim myLoadedForm As New frmArea
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem178_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem178.Click
        Dim myLoadedForm As New frmDistrictAreaAreaPMR
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem180_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem180.Click
        Dim myLoadedForm As New frmSalesTrendStockTransfer
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem181_Click(sender As Object, e As EventArgs) Handles MenuItem181.Click
        Dim myLoadedForm As New frmSegSegHead
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem182_Click(sender As Object, e As EventArgs) Handles MenuItem182.Click
        Dim myLoadedForm As New frmSegSegHead
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem184_Click(sender As Object, e As EventArgs) Handles MenuItem184.Click
        Dim myLoadedForm As New frmSalesControl
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem185_Click(sender As Object, e As EventArgs) Handles MenuItem185.Click
        Dim myLoadedForm As New frmSalesPerformanceSPTM
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem186_Click(sender As Object, e As EventArgs) Handles MenuItem186.Click
        Dim myLoadedForm As New frmSalesPerformanceSPAward
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem187_Click(sender As Object, e As EventArgs) Handles MenuItem187.Click
        Dim myLoadedForm As New frmSalesPerformanceTMAward
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem188_Click(sender As Object, e As EventArgs) Handles MenuItem188.Click
        Dim myLoadedForm As New frmSalesPerformanceSPAwardTrade
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem189_Click(sender As Object, e As EventArgs) Handles MenuItem189.Click
        Dim myLoadedForm As New frmSalesPerformanceTMAwardTrade
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem190_Click(sender As Object, e As EventArgs) Handles MenuItem190.Click
        Dim myLoadedForm As New frmSalesPerformanceSPTMMAT
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem192_Click(sender As Object, e As EventArgs) Handles MenuItem192.Click
        Dim myLoadedForm As New frmSalesTrendDirectMAT
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem193_Click(sender As Object, e As EventArgs) Handles MenuItem193.Click
        Dim myLoadedForm As New frmCustomerReachStockTransfer
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem194_Click(sender As Object, e As EventArgs) Handles MenuItem194.Click
        Dim myLoadedForm As New frmCustomerReachDirect
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem195_Click(sender As Object, e As EventArgs) Handles MenuItem195.Click
        Dim myLoadedForm As New frmSalesPerformanceSPTMTrade
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem197_Click(sender As Object, e As EventArgs) Handles MenuItem197.Click
        Dim myLoadedForm As New frmSalesTrendDirectYTDver9
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem198_Click(sender As Object, e As EventArgs) Handles MenuItem198.Click
        Dim myLoadedForm As New frmSalesTrendStockTransferMAT
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem199_Click(sender As Object, e As EventArgs) Handles MenuItem199.Click
        Dim myLoadedForm As New frmItemSalesReportStockTransfer
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem200_Click(sender As Object, e As EventArgs) Handles MenuItem200.Click
        Dim myLoadedForm As New frmItemSalesReportDirect
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem201_Click(sender As Object, e As EventArgs) Handles MenuItem201.Click
        Dim myLoadedForm As New frmSalesPerformanceSPTMTradeMonth
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem202_Click(sender As Object, e As EventArgs) Handles MenuItem202.Click
        Dim myLoadedForm As New frmBudgetMonthlyReport
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem203_Click(sender As Object, e As EventArgs) Handles MenuItem203.Click
        Dim myLoadedForm As New frmBudget2MonthsReport
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem204_Click(sender As Object, e As EventArgs) Handles MenuItem204.Click
        Dim myLoadedForm As New frmBudgetDirectReport
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem205_Click(sender As Object, e As EventArgs) Handles MenuItem205.Click
        Dim myLoadedForm As New frmBudgetDirectSummary
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem206_Click(sender As Object, e As EventArgs) Handles MenuItem206.Click
        Dim myLoadedForm As New frmValidateBracco
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem207_Click(sender As Object, e As EventArgs) Handles MenuItem207.Click
        Dim myLoadedForm As New frmExtractBOIE
        FrmShw(myLoadedForm)
    End Sub
    Function GetWeekInMonth(dtDate As Date) As Integer
        Dim DateWeekNumber As Integer = DatePart(DateInterval.WeekOfYear, dtDate, FirstDayOfWeek.System)
        Dim MonthStartWeek As Integer = DatePart(DateInterval.WeekOfYear, New DateTime(dtDate.Year, dtDate.Month, 1), FirstDayOfWeek.System)
        Return DateWeekNumber - MonthStartWeek + 1
    End Function

    Private Sub MenuItem219_Click(sender As Object, e As EventArgs) Handles MenuItem219.Click
        Dim myLoadedForm As New frmRosePharmacy
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem220_Click(sender As Object, e As EventArgs) Handles MenuItem220.Click
        Dim myLoadedForm As New frmSouthStarDrugNew
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem221_Click(sender As Object, e As EventArgs) Handles MenuItem221.Click
        Dim myLoadedForm As New frm518SubDistNew
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem216_Click(sender As Object, e As EventArgs) Handles MenuItem216.Click
        If SalesControlDiscrepancy() Then
            Exit Sub
        End If
        Dim myDialogBox As New frmDialogBox
        Dim myCommissionDate As String
        myDialogBox.cboYear.Minimum = 2015
        myDialogBox.cboYear.Maximum = 2015
        myDialogBox.cboYear.Value = 2015
        myDialogBox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        myCommissionDate = myDialogBox.CommissionDate

        Try
            If Not myCommissionDate = String.Empty Then
                'Compute the Attachment
                DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
                DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
                DataMaintenance.myParamArray(0, 2) = 10
                DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
                DataMaintenance.myParamArray(0, 4) = "Date"
                DataMaintenance.myParamArray(0, 5) = myCommissionDate
                DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComIncAttach2015", CommandType.StoredProcedure, 1)

                'Compute the ComInc
                DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
                DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
                DataMaintenance.myParamArray(0, 2) = 10
                DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
                DataMaintenance.myParamArray(0, 4) = "Date"
                DataMaintenance.myParamArray(0, 5) = myCommissionDate
                DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComInc2015", CommandType.StoredProcedure, 1)

                Dim myReportViewer As New frmReportViewer
                myReportViewer.Report = "Medrep Commission with Recovery2015"
                myReportViewer.CommissionDate = myCommissionDate
                'myReportViewer.MdiParent = Me                      donot modify
                FrmShw(myReportViewer)        '.ShowDialog(Me)
            Else
                Return
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub MenuItem215_Click(sender As Object, e As EventArgs) Handles MenuItem215.Click
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
        If SalesControlDiscrepancy() Then
            Exit Sub
        End If
        Dim myDialogbox As New frmDialogBox
        myDialogbox.cboYear.Minimum = 2009
        myDialogbox.cboYear.Maximum = 2015
        myDialogbox.cboYear.Value = 2015
        myDialogbox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        Try
            With myCommand
                .CommandText = "COMMISSION_ComputeAttachment2015"
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
        myLoadedForm.Report = "Commission Report Attachment 2015"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem222_Click(sender As Object, e As EventArgs) Handles MenuItem222.Click
        Dim myDialogBox As New frmDialogBox
        Dim myCommissionDate As String
        If SalesControlDiscrepancy() Then
            Exit Sub
        End If
        myDialogBox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        myCommissionDate = myDialogBox.CommissionDate

        Try
            If Not myCommissionDate = String.Empty Then
                'Compute the Attachment
                DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
                DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
                DataMaintenance.myParamArray(0, 2) = 10
                DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
                DataMaintenance.myParamArray(0, 4) = "Date"
                DataMaintenance.myParamArray(0, 5) = myCommissionDate
                'modified by arv : 7/20/2015 DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComIncAttach2010", CommandType.StoredProcedure, 1)
                DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComIncAttach2015", CommandType.StoredProcedure, 1)

                'Compute the ComInc
                DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
                DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
                DataMaintenance.myParamArray(0, 2) = 10
                DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
                DataMaintenance.myParamArray(0, 4) = "Date"
                DataMaintenance.myParamArray(0, 5) = myCommissionDate
                'modified by arv:7/20/2015 DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComInc2013", CommandType.StoredProcedure, 1)
                DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComInc2015", CommandType.StoredProcedure, 1)

                'Compute the DSM_Commission_2013
                DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
                DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
                DataMaintenance.myParamArray(0, 2) = 10
                DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
                DataMaintenance.myParamArray(0, 4) = "Date"
                DataMaintenance.myParamArray(0, 5) = myCommissionDate
                DataMaintenance.ExecuteCommand(ServerPath2, "DSM_Commission_2015", _
                                                   CommandType.StoredProcedure, 1)

                'Compute the DsmPmr_Det2013
                DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
                DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
                DataMaintenance.myParamArray(0, 2) = 10
                DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
                DataMaintenance.myParamArray(0, 4) = "Date"
                DataMaintenance.myParamArray(0, 5) = myCommissionDate
                DataMaintenance.ExecuteCommand(ServerPath2, "DsmPmr_Det2015", CommandType.StoredProcedure, 1)

                'Compute the DSMPMR_ins
                'rename DsmPmr_Ins_2010 to DsmPmr_Ins_2014 by ARValdez 04022014
                Dim LocalCommand As New SqlCommand
                With LocalCommand
                    .Connection = ObjectConnection(ServerPath2)
                    .CommandText = "DsmPmr_Ins_2015"
                    .CommandType = CommandType.StoredProcedure
                    .ExecuteScalar()
                End With

                Dim myReportViewer As New frmReportViewer
                myReportViewer.Report = "DSM Commission with Recovery2015"
                myReportViewer.CommissionDate = myCommissionDate
                'myReportViewer.MdiParent = Me                   donot modify
                FrmShw(myReportViewer)           '.ShowDialog(Me)
            Else
                Return
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem224_Click(sender As Object, e As EventArgs) Handles MenuItem224.Click
        Dim myDialogbox As New frmDialogBox
        myDialogbox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If

        Dim myLoadedForm As New frmReportViewer
        myLoadedForm.Report = "Segment-Supervisor-Specialist"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        FrmShw(myLoadedForm)         '<--replacement of the code before
    End Sub

    Private Sub MenuItem225_Click(sender As Object, e As EventArgs) Handles MenuItem225.Click
        Dim myLoadedForm As New frmTransferSPBudget
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem227_Click(sender As Object, e As EventArgs) Handles MenuItem227.Click
        Dim myLoadedForm As New frmMercurySales
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem228_Click(sender As Object, e As EventArgs)
        'Dim commissiondate As String
        'commissiondate = "3/1/2015"
        'RecordSubDistSales(Convert.ToDateTime(commissiondate))
    End Sub

    Private Sub MenuItem229_Click(sender As Object, e As EventArgs) Handles MenuItem229.Click
        Dim myLoadedForm As New frmSalesDiscrepancy
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem228_Click_1(sender As Object, e As EventArgs) Handles MenuItem228.Click
        'Dim commissiondate As String
        'commissiondate = "1/1/2015"
        'RecordSubDistSales(Convert.ToDateTime(commissiondate))
        'commissiondate = "2/1/2015"
        'RecordSubDistSales(Convert.ToDateTime(commissiondate))
        'commissiondate = "3/1/2015"
        'RecordSubDistSales(Convert.ToDateTime(commissiondate))
        'commissiondate = "4/1/2015"
        'RecordSubDistSales(Convert.ToDateTime(commissiondate))
        'commissiondate = "5/1/2015"
        'RecordSubDistSales(Convert.ToDateTime(commissiondate))
    End Sub

    Private Sub MenuItem230_Click(sender As Object, e As EventArgs) Handles MenuItem230.Click
        Dim myLoadedForm As New frmTransferMercuryTSSP
        FrmShw(myLoadedForm)
    End Sub
    'SM Manager Sales Performance
    Private Sub MenuItem232_Click(sender As Object, e As EventArgs) Handles MenuItem232.Click
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
        If SalesControlDiscrepancy() Then
            Exit Sub
        End If
        Dim myDialogbox As New frmDialogBox
        myDialogbox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        Try
            With myCommand
                .CommandText = "Compute_SMMgrIncentive2015"
                .CommandType = CommandType.StoredProcedure
                .Connection = myConnection
                .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = myDialogbox.CommissionDate
                'SM Manager Sales Performance
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        myConnection.Dispose()
        Dim myLoadedForm As New frmReportViewer
        myLoadedForm.Report = "SM Manager Sales Performance"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        FrmShw(myLoadedForm)         '<--replacement of the code before
    End Sub
    'TM Hitting Target
    Private Sub MenuItem233_Click(sender As Object, e As EventArgs) Handles MenuItem233.Click
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
        If SalesControlDiscrepancy() Then
            'Exit Sub
        End If
        Dim myDialogbox As New frmDialogBox
        myDialogbox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        Try
            With myCommand
                .CommandText = "Compute_SMMgrIncentive2015"
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
        'myLoadedForm.MdiParent = Me                 
        'myLoadedForm.StartPosition = FormStartPosition.CenterScreen
        'myLoadedForm.ShowDialog(Me)                                   <--code before
        myLoadedForm.Report = "TM Hitting Target"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        FrmShw(myLoadedForm)         '<--replacement of the code before
    End Sub
    'SM ASP Computation
    Private Sub MenuItem234_Click(sender As Object, e As EventArgs) Handles MenuItem234.Click
        'Get the respective Teritories per Medrep
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
        If SalesControlDiscrepancy() Then
            Exit Sub
        End If
        Dim myDialogbox As New frmDialogBox
        myDialogbox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        Try
            With myCommand
                .CommandText = "Compute_SMMgrIncentive2015"
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
        'myLoadedForm.MdiParent = Me                 
        'myLoadedForm.StartPosition = FormStartPosition.CenterScreen
        'myLoadedForm.ShowDialog(Me)                                   <--code before
        myLoadedForm.Report = "SM Manager ASP Computation"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        FrmShw(myLoadedForm)         '<--replacement of the code before
    End Sub
    '1.SM Manager Incentive Computation
    Private Sub MenuItem235_Click(sender As Object, e As EventArgs) Handles MenuItem235.Click
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
        If SalesControlDiscrepancy() Then
            Exit Sub
        End If
        Dim myDialogbox As New frmDialogBox
        myDialogbox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        Try
            With myCommand
                .CommandText = "Compute_SMMgrIncentive2015"
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
        myLoadedForm.Report = "SM Manager Incentive Computation"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        FrmShw(myLoadedForm)         '<--replacement of the code before
    End Sub
    ' Sales & Marketing Incentive Computation Summary 
    Private Sub MenuItem236_Click(sender As Object, e As EventArgs) Handles MenuItem236.Click
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
        If SalesControlDiscrepancy() Then
            Exit Sub
        End If
        Dim myDialogbox As New frmDialogBox
        myDialogbox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        Try
            With myCommand
                .CommandText = "Compute_SMMgrIncentive2015"
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
        myLoadedForm.Report = "SM Manager Incentive Computation Summary"
        myLoadedForm.CommissionDate = myDialogbox.CommissionDate
        FrmShw(myLoadedForm)         '<--replacement of the code before
    End Sub

    Private Sub MenuItem237_Click(sender As Object, e As EventArgs) Handles MenuItem237.Click
        Dim myLoadedForm As New frmSMIncTemplate
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem238_Click(sender As Object, e As EventArgs) Handles MenuItem238.Click
        Dim myLoadedForm As New frmResignedSpecialist
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem240_Click(sender As Object, e As EventArgs) Handles MenuItem240.Click
        Dim myLoadedForm As New frmSalesPerformanceDirect
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem241_Click(sender As Object, e As EventArgs) Handles MenuItem241.Click
        Dim myLoadedForm As New frmSalesPerformanceDirectMAT
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem243_Click(sender As Object, e As EventArgs) Handles MenuItem243.Click
        Dim myLoadedForm As New frmSaleTrendDirectMATVer10
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem244_Click(sender As Object, e As EventArgs) Handles MenuItem244.Click
        Dim myLoadedForm As New frmSalesTrendDirectYTDVer10
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem246_Click(sender As Object, e As EventArgs) Handles MenuItem246.Click
        Dim myLoadedForm As New frmSalesTrendStockTransfer2015
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem247_Click(sender As Object, e As EventArgs) Handles MenuItem247.Click
        If SalesControlDiscrepancy() Then
            Exit Sub
        End If
        Dim myDialogBox As New frmDialogBox
        Dim myCommissionDate As String
        myDialogBox.cboYear.Minimum = 2015
        myDialogBox.cboYear.Maximum = 2015
        myDialogBox.cboYear.Value = 2015
        myDialogBox.ShowDialog(Me)
        If cancelProcess = True Then
            cancelProcess = False
            Exit Sub
        End If
        myCommissionDate = myDialogBox.CommissionDate

        Try
            If Not myCommissionDate = String.Empty Then
                'Compute the Attachment
                DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
                DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
                DataMaintenance.myParamArray(0, 2) = 10
                DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
                DataMaintenance.myParamArray(0, 4) = "Date"
                DataMaintenance.myParamArray(0, 5) = myCommissionDate
                DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComIncAttach2015", CommandType.StoredProcedure, 1)

                'Compute the ComInc
                DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
                DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
                DataMaintenance.myParamArray(0, 2) = 10
                DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
                DataMaintenance.myParamArray(0, 4) = "Date"
                DataMaintenance.myParamArray(0, 5) = myCommissionDate
                DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComIncCombi2015", CommandType.StoredProcedure, 1)

                Dim myReportViewer As New frmReportViewer
                myReportViewer.Report = "Medrep Commission with RecoveryCombi2015"
                myReportViewer.CommissionDate = myCommissionDate
                'myReportViewer.MdiParent = Me                      donot modify
                FrmShw(myReportViewer)        '.ShowDialog(Me)
            Else
                Return
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem248_Click(sender As Object, e As EventArgs) Handles MenuItem248.Click
        Dim myLoadedForm As New frmResignedTM
        FrmShw(myLoadedForm)
    End Sub

    Private Sub mnuFileMaintenane_Click(sender As Object, e As EventArgs) Handles mnuFileMaintenane.Click

    End Sub

    Private Sub MenuItem151_Click(sender As Object, e As EventArgs) Handles MenuItem151.Click

    End Sub

    Private Sub MenuItem249_Click(sender As Object, e As EventArgs) Handles MenuItem249.Click
        Dim myLoadedForm As New frmBudgetNatlTransfer
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem251_Click(sender As Object, e As EventArgs) Handles MenuItem251.Click
        Dim myLoadedForm As New frmSalesAndTargetsTransfer
        FrmShw(myLoadedForm)
    End Sub

    Private Sub MenuItem17_Click(sender As Object, e As EventArgs) Handles MenuItem17.Click

    End Sub

    Private Sub MenuItem1_Click(sender As Object, e As EventArgs) Handles MenuItem1.Click

    End Sub
End Class
