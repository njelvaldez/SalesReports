Option Strict Off
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmReportViewer
    Inherits System.Windows.Forms.Form
    Public Const ExportPath As String = "D:\Temp\ExportReports\"

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
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
    Friend WithEvents ReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer
        '
        Me.ReportViewer.ActiveViewIndex = -1
        Me.ReportViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer.AutoScroll = True
        Me.ReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReportViewer.Location = New System.Drawing.Point(8, 8)
        Me.ReportViewer.Name = "ReportViewer"
        Me.ReportViewer.SelectionFormula = ""
        Me.ReportViewer.Size = New System.Drawing.Size(1010, 733)
        Me.ReportViewer.TabIndex = 0
        Me.ReportViewer.ViewTimeSelectionFormula = ""
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(172, 226)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(730, 80)
        Me.DataGrid1.TabIndex = 1
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.DataGrid1.Visible = False
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "ComincRecover2009"
        '
        'frmReportViewer
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1024, 746)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.ReportViewer)
        Me.Name = "frmReportViewer"
        Me.Text = "Report Viewer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private ReportName As String
    Private CommissionMonth As String
    Private xMyDataSets As New MyDataSets
    Private BusinessObject As New BusinessLayer.clsFileMaintenance

    Property Report() As String
        Get
            Return ReportName
        End Get
        Set(ByVal Value As String)
            ReportName = Value
        End Set
    End Property   ' Month

    Property CommissionDate() As String
        Get
            Return CommissionMonth
        End Get
        Set(ByVal Value As String)
            CommissionMonth = Value
        End Set
    End Property

    Private Sub frmReportViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim x As String
        x = Application.StartupPath
        Try
            Select Case Report
                Case "Mdi Sales Per Medrep"
                    Dim myDialogBox As New frmDialogBox
                    Dim myConnection As New SqlConnection
                    With myConnection
                        .ConnectionString = ServerPath2
                        .Open()
                    End With

                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = myConnection
                        .CommandText = "Report_MdiSalesPerMedrep"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = CommissionDate
                    End With

                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New dsMdiSalesPerMedrep
                    myDataAdapter.Fill(myDataset, "Report_MdiSalesPerMedrep")

                    Dim myReport As New Report_MdiSalesPerMedrep
                    myReport.SetDataSource(myDataset.Tables("REPORT_MdiSalesPerMedrep"))
                    ReportViewer.ReportSource = myReport

                Case "Mdi Sales Per Medrep(Trade)"
                    Dim myDialogBox As New frmDialogBox
                    Dim myConnection As New SqlConnection
                    With myConnection
                        .ConnectionString = ServerPath2
                        .Open()
                    End With

                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = myConnection
                        .CommandText = "Report_MdiSalesPerMedrepTrade"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = CommissionDate
                    End With

                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New dsMdiSalesPerMedrep
                    myDataAdapter.Fill(myDataset, "Report_MdiSalesPerMedrep")

                    Dim myReport As New Report_MdiSalesPerMedrepTrade
                    myReport.SetDataSource(myDataset.Tables("REPORT_MdiSalesPerMedrep"))
                    ReportViewer.ReportSource = myReport

                Case "Mdi Sales Per Medrep MTD"
                    Dim myDialogBox As New frmDialogBox
                    Dim myConnection As New SqlConnection
                    With myConnection
                        .ConnectionString = ServerPath2
                        .Open()
                    End With
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = myConnection
                        .CommandText = "Report_MdiSalesPerMedrepMTD"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = CommissionDate
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New dsMdiSalesPerMedrep
                    myDataAdapter.Fill(myDataset, "Report_MdiSalesPerMedrep")

                    Dim myReport As New Report_MdiSalesPerMedrepMTD
                    myReport.SetDataSource(myDataset.Tables("REPORT_MdiSalesPerMedrep"))
                    ReportViewer.ReportSource = myReport
                Case "Mdi Sales Per Medrep Untagged"
                    Dim myDialogBox As New frmDialogBox
                    Dim myConnection As New SqlConnection
                    With myConnection
                        .ConnectionString = ServerPath2
                        .Open()
                    End With
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = myConnection
                        .CommandText = "Report_MdiSalesPerMedrepUntagged"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = CommissionDate
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New dsMdiSalesPerMedrep
                    myDataAdapter.Fill(myDataset, "Report_MdiSalesPerMedrep")

                    Dim myReport As New Report_MdiSalesPerMedrepUntagged
                    myReport.SetDataSource(myDataset.Tables("REPORT_MdiSalesPerMedrep"))
                    ReportViewer.ReportSource = myReport
                Case "Mdi Sales Per Medrep MH"
                    Dim myDialogBox As New frmDialogBox
                    Dim myConnection As New SqlConnection
                    With myConnection
                        .ConnectionString = ServerPath2
                        .Open()
                    End With
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = myConnection
                        .CommandText = "Report_MdiSalesPerMedrepMH"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = CommissionDate
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New dsMdiSalesPerMedrep
                    myDataAdapter.Fill(myDataset, "Report_MdiSalesPerMedrep")

                    Dim myReport As New Report_MdiSalesPerMedrepMH
                    myReport.SetDataSource(myDataset.Tables("REPORT_MdiSalesPerMedrep"))
                    ReportViewer.ReportSource = myReport
                Case "Mdi Sales Per Medrep FLT"
                    Dim myDialogBox As New frmDialogBox
                    Dim myConnection As New SqlConnection
                    With myConnection
                        .ConnectionString = ServerPath2
                        .Open()
                    End With
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = myConnection
                        .CommandText = "Report_MdiSalesPerMedrepFLT"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = CommissionDate
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New dsMdiSalesPerMedrep
                    myDataAdapter.Fill(myDataset, "Report_MdiSalesPerMedrep")

                    Dim myReport As New Report_MdiSalesPerMedrep
                    myReport.SetDataSource(myDataset.Tables("REPORT_MdiSalesPerMedrep"))
                    ReportViewer.ReportSource = myReport

                Case "Commission Report Attachment Chiral"
                    Dim myDialogBox As New frmDialogBox
                    Dim myConnection As New SqlConnection
                    With myConnection
                        .ConnectionString = ServerPath2
                        .Open()
                    End With
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = myConnection
                        .CommandText = "Report_CommissionAttachmentChiral"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = CommissionDate
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New dsCommissionAttachment
                    myDataAdapter.Fill(myDataset, "Report_CommissionAttachment")

                    'With myCommand
                    '    .Connection = DataMaintenance.objConnection(ServerPath2)
                    '    .CommandText = "MedrepCommission_Details"
                    '    .CommandType = CommandType.StoredProcedure
                    '    .Parameters.Add(myParameter)
                    'End With
                    'myDataAdapter.SelectCommand = myCommand
                    'myDataAdapter.Fill(myDataset, "MedrepCommission_Details")
                    'Dim myReport As New ReportDocument
                    'myReport.Load(x & "\rpts\Report_CommissionAttachmentChiral.rpt")
                    'myreport.SetDataSource(mydataset)
                    'ReportViewer.ReportSource = myreport

                    Dim myReport As New Report_CommissionAttachment
                    myReport.SetDataSource(myDataset.Tables("REPORT_CommissionAttachment"))
                    ReportViewer.ReportSource = myReport
                Case "Commission Report Attachment MH"
                    Dim myDialogBox As New frmDialogBox
                    Dim myConnection As New SqlConnection
                    With myConnection
                        .ConnectionString = ServerPath2
                        .Open()
                    End With
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = myConnection
                        .CommandText = "Report_CommissionAttachmentMH"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = CommissionDate
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New dsCommissionAttachment
                    myDataAdapter.Fill(myDataset, "Report_CommissionAttachment")

                    Dim myReport As New Report_CommissionAttachment
                    myReport.SetDataSource(myDataset.Tables("REPORT_CommissionAttachment"))
                    ReportViewer.ReportSource = myReport
                Case "Commission Report Attachment FLT"
                    Dim myDialogBox As New frmDialogBox
                    Dim myConnection As New SqlConnection
                    With myConnection
                        .ConnectionString = ServerPath2
                        .Open()
                    End With
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = myConnection
                        .CommandText = "Report_CommissionAttachmentFLT"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = CommissionDate
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New dsCommissionAttachment
                    myDataAdapter.Fill(myDataset, "Report_CommissionAttachment")

                    Dim myReport As New Report_CommissionAttachment
                    myReport.SetDataSource(myDataset.Tables("REPORT_CommissionAttachment"))
                    ReportViewer.ReportSource = myReport
                Case "Commission Report Attachment MTD 2009"
                    Dim myDialogBox As New frmDialogBox
                    Dim myConnection As New SqlConnection
                    With myConnection
                        .ConnectionString = ServerPath2
                        .Open()
                    End With
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = myConnection
                        .CommandText = "Report_CommissionAttachmentMTD2009"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = CommissionDate
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New dsCommissionAttachment
                    myDataAdapter.Fill(myDataset, "Report_CommissionAttachment")

                    Dim myReport As New Report_CommissionAttachmentMTD
                    myReport.SetDataSource(myDataset.Tables("REPORT_CommissionAttachment"))
                    ReportViewer.ReportSource = myReport
                Case "Commission Report Attachment"
                    Dim myDialogBox As New frmDialogBox
                    Dim myConnection As New SqlConnection
                    With myConnection
                        .ConnectionString = ServerPath2
                        .Open()
                    End With
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = myConnection
                        .CommandText = "Report_CommissionAttachment"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = CommissionDate
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New dsCommissionAttachment
                    myDataAdapter.Fill(myDataset, "Report_CommissionAttachment")

                    Dim myReport As New Report_CommissionAttachment
                    myReport.SetDataSource(myDataset.Tables("REPORT_CommissionAttachment"))
                    ReportViewer.ReportSource = myReport
                    myConnection.Close()

                Case "Commission Report Attachment 2009"
                    Dim myDialogBox As New frmDialogBox
                    Dim myConnection As New SqlConnection
                    With myConnection
                        .ConnectionString = ServerPath2
                        .Open()
                    End With
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = myConnection
                        .CommandText = "Report_CommissionAttachment2009"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = CommissionDate
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New dsCommissionAttachment
                    myDataAdapter.Fill(myDataset, "Report_CommissionAttachment")

                    Dim myReport As New Report_CommissionAttachment
                    myReport.SetDataSource(myDataset.Tables("REPORT_CommissionAttachment"))
                    ReportViewer.ReportSource = myReport
                    'Added by Angelo
                Case "Commission Report Attachment 2014"
                    Dim myDialogBox As New frmDialogBox
                    Dim myConnection As New SqlConnection
                    With myConnection
                        .ConnectionString = ServerPath2
                        .Open()
                    End With
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = myConnection
                        .CommandText = "Report_CommissionAttachment2014"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = CommissionDate
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New dsCommissionAttachment
                    myDataAdapter.Fill(myDataset, "Report_CommissionAttachment")

                    Dim myReport As New Report_CommissionAttachment2014
                    myReport.SetDataSource(myDataset.Tables("REPORT_CommissionAttachment"))
                    ReportViewer.ReportSource = myReport


                Case "Commission Report Attachment(DM)2008"
                    Dim myDialogBox As New frmDialogBox
                    Dim myConnection As New SqlConnection
                    With myConnection
                        .ConnectionString = ServerPath2
                        .Open()
                    End With
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = myConnection
                        .CommandText = "Report_CommissionAttachment"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = CommissionDate
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New dsCommissionAttachment
                    myDataAdapter.Fill(myDataset, "Report_CommissionAttachment")

                    Dim myReport As New Report_CommissionAttachmentSpv
                    myReport.SetDataSource(myDataset.Tables("REPORT_CommissionAttachment"))
                    ReportViewer.ReportSource = myReport
                Case "Commission Report Attachment(DM)2009"
                    Dim myDialogBox As New frmDialogBox
                    Dim myConnection As New SqlConnection
                    With myConnection
                        .ConnectionString = ServerPath2
                        .Open()
                    End With
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = myConnection
                        .CommandText = "REPORT_CommissionAttachment2009"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = CommissionDate
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New dsCommissionAttachment
                    myDataAdapter.Fill(myDataset, "Report_CommissionAttachment2009")

                    Dim myReport As New Report_CommissionAttachmentSpv
                    myReport.SetDataSource(myDataset.Tables("REPORT_CommissionAttachment2009"))
                    ReportViewer.ReportSource = myReport

                Case "Commission Report Attachment(DSM)2008Chiral"
                    Dim myDialogBox As New frmDialogBox
                    Dim myConnection As New SqlConnection
                    With myConnection
                        .ConnectionString = ServerPath2
                        .Open()
                    End With
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = myConnection
                        .CommandText = "REPORT_CommissionAttachmentChiral"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = CommissionDate
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New dsCommissionAttachment
                    myDataAdapter.Fill(myDataset, "Report_CommissionAttachment2008Chiral")

                    Dim myReport As New Report_CommissionAttachmentSpv
                    myReport.SetDataSource(myDataset.Tables("REPORT_CommissionAttachment2008Chiral"))
                    ReportViewer.ReportSource = myReport

                Case "Commission Report Attachment(DSM)2009Chiral"
                    Dim myDialogBox As New frmDialogBox
                    Dim myConnection As New SqlConnection
                    With myConnection
                        .ConnectionString = ServerPath2
                        .Open()
                    End With
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = myConnection
                        .CommandText = "REPORT_CommissionAttachmentChiral"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = CommissionDate
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New dsCommissionAttachment
                    myDataAdapter.Fill(myDataset, "Report_CommissionAttachment2009Chiral")

                    Dim myReport As New Report_CommissionAttachmentSpv
                    myReport.SetDataSource(myDataset.Tables("REPORT_CommissionAttachment2009Chiral"))
                    ReportViewer.ReportSource = myReport

                Case "Medrep Commission"
                    Dim myDialogBox As New frmDialogBox
                    Dim myConnection As New SqlConnection
                    With myConnection
                        .ConnectionString = ServerPath2
                        .Open()
                    End With
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = myConnection
                        .CommandText = "Report_MedrepCommission"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = CommissionDate
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New dsMedrepCommission
                    myDataAdapter.Fill(myDataset, "Report_MedrepCommission")

                    'If CDate(CommissionDate) > #6/1/2005# Then
                    '    Dim myReport As New Report_MedrepCommissionWithRecovery
                    '    myReport.SetDataSource(mydataset.Tables("Report_MedrepCommission"))
                    '    ReportViewer.ReportSource = myReport
                    'Else
                    Dim myReport As New Report_MedrepCommission
                    myReport.SetDataSource(myDataset.Tables("REPORT_MedrepCommission"))
                    ReportViewer.ReportSource = myReport
                    'End If


                Case "Supervisor Commission"
                    Dim myDialogBox As New frmDialogBox
                    Dim myConnection As New SqlConnection
                    With myConnection
                        .ConnectionString = ServerPath2
                        .Open()
                    End With
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = myConnection
                        .CommandText = "Report_SupervisorCommission"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = CommissionDate
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New dsSupervisorCommission
                    myDataAdapter.Fill(myDataset, "Report_SupervisorCommission")

                    Dim myReport As New Report_SupervisorCommission
                    myReport.SetDataSource(myDataset.Tables("REPORT_SupervisorCommission"))
                    ReportViewer.ReportSource = myReport
                Case "Mercury Sales"
                    Dim myDialogBox As New frmDialogBox
                    Dim myConnection As New SqlConnection
                    With myConnection
                        .ConnectionString = ServerPath
                        .Open()
                    End With
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = myConnection
                        .CommandText = "SELECT * FROM Tempory_Mercury"
                        .CommandType = CommandType.Text
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New dsMercurySales
                    myDataAdapter.Fill(myDataset, "tempory_Mercury")

                    Dim myReport As New Report_MercurySales
                    myReport.SetDataSource(myDataset.Tables("tempory_Mercury"))
                    ReportViewer.ReportSource = myReport
                Case "Mercury Sales(Trade)"
                    Dim myDialogBox As New frmDialogBox
                    Dim myConnection As New SqlConnection
                    With myConnection
                        .ConnectionString = ServerPath
                        .Open()
                    End With
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = myConnection
                        .CommandText = "SELECT * FROM Tempory_Mercury"
                        .CommandType = CommandType.Text
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New dsMercurySales
                    myDataAdapter.Fill(myDataset, "tempory_Mercury")

                    Dim myReport As New Report_MercurySalesTrade
                    myReport.SetDataSource(myDataset.Tables("tempory_Mercury"))
                    ReportViewer.ReportSource = myReport
                Case "Mercury Sales MH"
                    Dim myDialogBox As New frmDialogBox
                    Dim myConnection As New SqlConnection
                    With myConnection
                        .ConnectionString = ServerPath
                        .Open()
                    End With
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = myConnection
                        .CommandText = "SELECT * FROM Tempory_Mercury"
                        .CommandType = CommandType.Text
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New dsMercurySales
                    myDataAdapter.Fill(myDataset, "tempory_Mercury")

                    Dim myReport As New Report_MercurySalesMH
                    myReport.SetDataSource(myDataset.Tables("tempory_Mercury"))
                    ReportViewer.ReportSource = myReport
                Case "Mercury Sales FLT"
                    Dim myDialogBox As New frmDialogBox
                    Dim myConnection As New SqlConnection
                    With myConnection
                        .ConnectionString = ServerPath
                        .Open()
                    End With
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = myConnection
                        .CommandText = "SELECT * FROM Tempory_Mercury"
                        .CommandType = CommandType.Text
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New dsMercurySales
                    myDataAdapter.Fill(myDataset, "tempory_Mercury")

                    Dim myReport As New Report_MercurySales
                    myReport.SetDataSource(myDataset.Tables("tempory_Mercury"))
                    ReportViewer.ReportSource = myReport
                Case "Qpi Mercury Sales"
                    Dim myDialogBox As New frmDialogBox
                    Dim myConnection As New SqlConnection
                    With myConnection
                        .ConnectionString = ServerPath
                        .Open()
                    End With
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = myConnection
                        .CommandText = "SELECT * FROM Tempory_Mercury where itemcode in(Select itemcode from newscores..item where princode='0044')"
                        .CommandType = CommandType.Text
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New dsMercurySales
                    myDataAdapter.Fill(myDataset, "tempory_Mercury")

                    Dim myReport As New Report_QpiMercurySales
                    myReport.SetDataSource(myDataset.Tables("tempory_Mercury"))
                    ReportViewer.ReportSource = myReport
                Case "Qpi Sales Per Medrep"
                    Dim myDialogBox As New frmDialogBox
                    Dim myConnection As New SqlConnection
                    With myConnection
                        .ConnectionString = ServerPath2
                        .Open()
                    End With
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = myConnection
                        .CommandText = "Report_QpiSalesPerMedrep"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = CommissionDate
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New dsMdiSalesPerMedrep
                    myDataAdapter.Fill(myDataset, "Report_MdiSalesPerMedrep")

                    Dim myReport As New Report_QpiSalesPerMedrep
                    myReport.SetDataSource(myDataset.Tables("REPORT_MdiSalesPerMedrep"))
                    ReportViewer.ReportSource = myReport
                Case "Qpi Sales Per Territory"
                    Dim myDialogBox As New frmDialogBox
                    Dim myConnection As New SqlConnection
                    With myConnection
                        .ConnectionString = ServerPath2
                        .Open()
                    End With
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = myConnection
                        .CommandText = "Report_QpiSalesPerTerritory"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = CommissionDate
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New dsMdiSalesPerMedrep
                    myDataAdapter.Fill(myDataset, "Report_QpiSalesPerTerritory")

                    Dim myReport As New Report_QpiSalesPerTerritory
                    myReport.SetDataSource(myDataset.Tables("Report_QpiSalesPerTerritory"))
                    ReportViewer.ReportSource = myReport
                Case "Hii Sales Per Territory"
                    Dim myDialogBox As New frmDialogBox
                    Dim myConnection As New SqlConnection
                    With myConnection
                        .ConnectionString = ServerPath2
                        .Open()
                    End With
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = myConnection
                        .CommandText = "Report_HiiSalesPerTerritory"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = CommissionDate
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New dsMdiSalesPerMedrep
                    myDataAdapter.Fill(myDataset, "Report_HiiSalesPerTerritory")

                    Dim myReport As New Report_HiiSalesPerTerritory
                    myReport.SetDataSource(myDataset.Tables("Report_HiiSalesPerTerritory"))
                    ReportViewer.ReportSource = myReport
                Case "Hii Mercury Sales"
                    Dim myDialogBox As New frmDialogBox
                    Dim myConnection As New SqlConnection
                    With myConnection
                        .ConnectionString = ServerPath
                        .Open()
                    End With
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = myConnection
                        .CommandText = "SELECT * FROM Tempory_Mercury where itemcode in(Select itemcode from newscores..item where princode='0032')"
                        .CommandType = CommandType.Text
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New dsMercurySales
                    myDataAdapter.Fill(myDataset, "tempory_Mercury")

                    Dim myReport As New Report_HiiMercurySales
                    myReport.SetDataSource(myDataset.Tables("tempory_Mercury"))
                    ReportViewer.ReportSource = myReport

                Case "Control Totals"
                    Dim myConnection As New SqlConnection
                    With myConnection
                        .ConnectionString = ServerPath2
                        .Open()
                    End With
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = myConnection
                        .CommandText = "Select * from ControlTotals where CommissionDate=" & "'" & CommissionDate & "'"
                        .CommandType = CommandType.Text
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New dsEditIntegratedSales
                    myDataAdapter.Fill(myDataset, "ControlTotals")

                    Dim myReport As New Report_ControlTotals
                    myReport.SetDataSource(myDataset.Tables("ControlTotals"))
                    ReportViewer.ReportSource = myReport
                Case "Medrep Commission with Recovery"
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = DataMaintenance.objConnection(ServerPath2)
                        .CommandText = "Select * from ComIncRecover"
                        .CommandType = CommandType.Text
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New dsComIncRecover
                    myDataAdapter.Fill(myDataset, "ComIncRecover")

                    Dim myParameter As New SqlParameter
                    With myParameter
                        .ParameterName = "@CommissionDate"
                        .Direction = ParameterDirection.Input
                        .SqlDbType = SqlDbType.DateTime
                        .Size = 10
                        .Value = CommissionDate
                    End With
                    With myCommand
                        .Connection = DataMaintenance.objConnection(ServerPath2)
                        .CommandText = "MedrepCommission_Details"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add(myParameter)
                    End With
                    myDataAdapter.SelectCommand = myCommand
                    myDataAdapter.Fill(myDataset, "MedrepCommission_Details")

                    Dim myReport As New Report_MedrepCommissionWithRecovery
                    myReport.SetDataSource(myDataset)
                    ReportViewer.ReportSource = myReport

                Case "Medrep Commission with Recovery2008"
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = DataMaintenance.objConnection(ServerPath2)
                        .CommandText = "Select * from ComIncRecover"
                        .CommandType = CommandType.Text
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New ComIncRecover2008
                    myDataAdapter.Fill(myDataset, "ComIncRecover")

                    Dim myParameter As New SqlParameter
                    With myParameter
                        .ParameterName = "@CommissionDate"
                        .Direction = ParameterDirection.Input
                        .SqlDbType = SqlDbType.DateTime
                        .Size = 10
                        .Value = CommissionDate
                    End With
                    With myCommand
                        .Connection = DataMaintenance.objConnection(ServerPath2)
                        .CommandText = "MedrepCommission_Details"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add(myParameter)
                    End With
                    myDataAdapter.SelectCommand = myCommand
                    myDataAdapter.Fill(myDataset, "MedrepCommission_Details")

                    'Dim myReport As New ReportDocument
                    'myReport.Load(x & "\rpts\Report_MedrepCommissionWithRecovery2008.rpt")
                    'myreport.SetDataSource(mydataset)
                    'ReportViewer.ReportSource = myreport

                    Dim myReport As New Report_MedrepCommissionWithRecovery2008
                    myReport.SetDataSource(myDataset)
                    ReportViewer.ReportSource = myReport

                Case "Medrep Commission with Recovery2009"
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = DataMaintenance.objConnection(ServerPath2)
                        .CommandText = "Select * from ComIncRecover"
                        .CommandType = CommandType.Text
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New ComincRecover2009
                    myDataAdapter.Fill(myDataset, "ComIncRecover")

                    Dim myParameter As New SqlParameter
                    With myParameter
                        .ParameterName = "@CommissionDate"
                        .Direction = ParameterDirection.Input
                        .SqlDbType = SqlDbType.DateTime
                        .Size = 10
                        .Value = CommissionDate
                    End With
                    With myCommand
                        .Connection = DataMaintenance.objConnection(ServerPath2)
                        .CommandText = "MedrepCommission_Details2009"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add(myParameter)
                    End With
                    myDataAdapter.SelectCommand = myCommand
                    myDataAdapter.Fill(myDataset, "MedrepCommission_Details2009")

                    'Dim myReport As New ReportDocument
                    'myReport.Load(x & "\rpts\Report_MedrepCommissionWithRecovery2009.rpt")
                    'myreport.SetDataSource(mydataset)
                    'ReportViewer.ReportSource = myreport
                    If CDate(CommissionDate) >= CDate("11/01/2009") Then   'And CDate(CommissionDate) <= CDate("12/31/2009")) Then
                        Dim myReport As New Report_MedrepCommissionWithRecovery2009P
                        myReport.SetDataSource(myDataset)
                        ReportViewer.ReportSource = myReport
                    Else
                        Dim myReport As New Report_MedrepCommissionWithRecovery2009
                        myReport.SetDataSource(myDataset)
                        ReportViewer.ReportSource = myReport
                    End If

                    'Dim myReport As New Report_MedrepCommissionWithRecovery2009
                    'myreport.SetDataSource(myDataset)
                    'ReportViewer.ReportSource = myreport

                Case "Medrep Commission with Recovery2010"
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = DataMaintenance.objConnection(ServerPath2)
                        .CommandText = "Select * from ComIncRecover"
                        .CommandType = CommandType.Text
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New ComincRecover2009
                    myDataAdapter.Fill(myDataset, "ComIncRecover")

                    Dim myParameter As New SqlParameter
                    With myParameter
                        .ParameterName = "@CommissionDate"
                        .Direction = ParameterDirection.Input
                        .SqlDbType = SqlDbType.DateTime
                        .Size = 10
                        .Value = CommissionDate
                    End With
                    With myCommand
                        .Connection = DataMaintenance.objConnection(ServerPath2)
                        .CommandText = "MedrepCommission_Details2010"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add(myParameter)
                    End With
                    myDataAdapter.SelectCommand = myCommand
                    myDataAdapter.Fill(myDataset, "MedrepCommission_Details2009")

                    'Dim myReport As New ReportDocument
                    'myReport.Load(x & "\rpts\Report_MedrepCommissionWithRecovery2009.rpt")
                    'myreport.SetDataSource(mydataset)
                    'ReportViewer.ReportSource = myreport
                    'If CDate(CommissionDate) >= CDate("11/01/2009") Then   'And CDate(CommissionDate) <= CDate("12/31/2009")) Then
                    Dim myReport As New Report_MedrepCommissionWithRecovery2010
                    myReport.SetDataSource(myDataset)
                    ReportViewer.ReportSource = myReport
                    'Else
                    '    Dim myReport As New Report_MedrepCommissionWithRecovery2009
                    '    myreport.SetDataSource(myDataset)
                    '    ReportViewer.ReportSource = myreport
                    'End If

                Case "Medrep Commission with Recovery2011"
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = DataMaintenance.objConnection(ServerPath2)
                        .CommandText = "Select * from ComIncRecover"
                        .CommandType = CommandType.Text
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New ComincRecover2009
                    myDataAdapter.Fill(myDataset, "ComIncRecover")

                    Dim myParameter As New SqlParameter
                    With myParameter
                        .ParameterName = "@CommissionDate"
                        .Direction = ParameterDirection.Input
                        .SqlDbType = SqlDbType.DateTime
                        .Size = 10
                        .Value = CommissionDate
                    End With
                    With myCommand
                        .Connection = DataMaintenance.objConnection(ServerPath2)
                        .CommandText = "MedrepCommission_Details2011"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add(myParameter)
                    End With
                    myDataAdapter.SelectCommand = myCommand
                    myDataAdapter.Fill(myDataset, "MedrepCommission_Details2009")
                    Dim myReport As New Report_MedrepCommissionWithRecovery2011
                    myReport.SetDataSource(myDataset)
                    ReportViewer.ReportSource = myReport

                Case "Medrep Commission with Recovery2012"
                    Try
                        If Not CommissionDate = Nothing Then    '[>>rnj_popoy**added
                            Dim myCommand As New SqlCommand     'continue if get commission date is not equal to nothing
                            With myCommand                      '02282013<<]
                                .Connection = DataMaintenance.objConnection(ServerPath2)
                                .CommandText = "Select * from ComIncRecover"
                                .CommandType = CommandType.Text
                            End With
                            Dim myDataAdapter As New SqlDataAdapter
                            myDataAdapter.SelectCommand = myCommand
                            Dim myDataset As New ComincRecover2009
                            myDataAdapter.Fill(myDataset, "ComIncRecover")

                            Dim myParameter As New SqlParameter
                            With myParameter
                                .ParameterName = "@CommissionDate"
                                .Direction = ParameterDirection.Input
                                .SqlDbType = SqlDbType.DateTime
                                .Size = 10
                                .Value = CommissionDate
                            End With

                            With myCommand
                                .Connection = DataMaintenance.objConnection(ServerPath2)
                                .CommandText = "MedrepCommission_Details2012"
                                .CommandType = CommandType.StoredProcedure
                                .Parameters.Add(myParameter)
                            End With
                            myDataAdapter.SelectCommand = myCommand
                            myDataAdapter.Fill(myDataset, "MedrepCommission_Details2009")
                            Dim myReport As New Report_MedrepCommissionWithRecovery2012
                            myReport.SetDataSource(myDataset)
                            ReportViewer.ReportSource = myReport

                        Else
                            Return '**return nothing
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                    '[>>rnj_popoy**added
                Case "Medrep Commission with Recovery2013"
                    Try
                        If Not CommissionDate = Nothing Then
                            Dim myCommand As New SqlCommand
                            With myCommand
                                .Connection = DataMaintenance.objConnection(ServerPath2)
                                .CommandText = "Select * from ComIncRecover"
                                .CommandType = CommandType.Text
                            End With
                            Dim myDataAdapter As New SqlDataAdapter
                            myDataAdapter.SelectCommand = myCommand
                            Dim myDataset As New ComincRecover2009
                            myDataAdapter.Fill(myDataset, "ComIncRecover")

                            Dim myParameter As New SqlParameter
                            With myParameter
                                .ParameterName = "@CommissionDate"
                                .Direction = ParameterDirection.Input
                                .SqlDbType = SqlDbType.DateTime
                                .Size = 10
                                .Value = CommissionDate
                            End With
                            With myCommand
                                .Connection = DataMaintenance.objConnection(ServerPath2)
                                .CommandText = "SegmentRule_MedrepCommission_Details2013"
                                .CommandType = CommandType.StoredProcedure
                                .Parameters.Add(myParameter)
                            End With
                            myDataAdapter.SelectCommand = myCommand
                            myDataAdapter.Fill(myDataset, "MedrepCommission_Details2009")
                            Dim myReport As New Report_MedrepCommissionWithRecovery2013
                            myReport.SetDataSource(myDataset)
                            ReportViewer.ReportSource = myReport
                        Else
                            Return '**return nothing
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try '02272013<<]
                    'Added by ARValdez
                Case "Medrep Commission with Recovery2014"
                    Try
                        If Not CommissionDate = Nothing Then
                            Dim myCommand As New SqlCommand
                            With myCommand
                                .Connection = DataMaintenance.objConnection(ServerPath2)
                                .CommandText = "Select * from ComIncRecover"
                                .CommandType = CommandType.Text
                            End With
                            Dim myDataAdapter As New SqlDataAdapter
                            myDataAdapter.SelectCommand = myCommand
                            Dim myDataset As New ComincRecover2009
                            myDataAdapter.Fill(myDataset, "ComIncRecover")

                            Dim myParameter As New SqlParameter
                            With myParameter
                                .ParameterName = "@CommissionDate"
                                .Direction = ParameterDirection.Input
                                .SqlDbType = SqlDbType.DateTime
                                .Size = 10
                                .Value = CommissionDate
                            End With
                            With myCommand
                                .Connection = DataMaintenance.objConnection(ServerPath2)
                                .CommandText = "SegmentRule_MedrepCommission_Details2014"
                                .CommandType = CommandType.StoredProcedure
                                .Parameters.Add(myParameter)
                            End With
                            myDataAdapter.SelectCommand = myCommand
                            myDataAdapter.Fill(myDataset, "MedrepCommission_Details2009")
                            Dim myReport As New Report_MedrepCommissionWithRecovery2014
                            myReport.SetDataSource(myDataset)
                            ReportViewer.ReportSource = myReport
                        Else
                            Return '**return nothing
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try '02272013<<]

                Case "Medrep Commission with Recovery2010 Biomedica"
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = DataMaintenance.objConnection(ServerPath2)
                        .CommandText = "Select * from ComIncRecover"
                        .CommandType = CommandType.Text
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New ComincRecover2009
                    myDataAdapter.Fill(myDataset, "ComIncRecover")

                    Dim myParameter As New SqlParameter
                    With myParameter
                        .ParameterName = "@CommissionDate"
                        .Direction = ParameterDirection.Input
                        .SqlDbType = SqlDbType.DateTime
                        .Size = 10
                        .Value = CommissionDate
                    End With
                    With myCommand
                        .Connection = DataMaintenance.objConnection(ServerPath2)
                        .CommandText = "MedrepCommission_Details2010"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add(myParameter)
                    End With
                    myDataAdapter.SelectCommand = myCommand
                    myDataAdapter.Fill(myDataset, "MedrepCommission_Details2009")

                    Dim myReport As New Report_MedrepCommissionWithRecovery2010BioM
                    myReport.SetDataSource(myDataset)
                    ReportViewer.ReportSource = myReport

                Case "Medrep Commission with RecoveryMTD2009"
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = DataMaintenance.objConnection(ServerPath2)
                        .CommandText = "Select * from ComIncRecoverMTD"
                        .CommandType = CommandType.Text
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New ComincRecover2009
                    myDataAdapter.Fill(myDataset, "ComIncRecover")

                    DataGrid1.DataSource = myDataset.ComIncRecover
                    Dim myParameter As New SqlParameter
                    With myParameter
                        .ParameterName = "@CommissionDate"
                        .Direction = ParameterDirection.Input
                        .SqlDbType = SqlDbType.DateTime
                        .Size = 10
                        .Value = CommissionDate
                    End With
                    With myCommand
                        .Connection = DataMaintenance.objConnection(ServerPath2)
                        .CommandText = "MedrepCommission_DetailsMTD2009"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add(myParameter)
                    End With
                    myDataAdapter.SelectCommand = myCommand
                    myDataAdapter.Fill(myDataset, "MedrepCommission_Details2009")

                    'Dim myReport As New ReportDocument
                    'myReport.Load(x & "\rpts\Report_MedrepCommissionWithRecovery2009.rpt")
                    'myreport.SetDataSource(mydataset)
                    'ReportViewer.ReportSource = myreport

                    Dim myReport As New Report_MedrepCommissionWithRecovery2009
                    myReport.SetDataSource(myDataset)
                    ReportViewer.ReportSource = myReport

                Case "DSM Commission with Recovery"
                    Dim myCommand As New SqlCommand
                    Dim myParameter As New SqlParameter("@CommissionDate", SqlDbType.DateTime, 10)
                    Dim myAdapter As New SqlDataAdapter
                    Dim myDataSet As New dsComIncRecover
                    With myCommand
                        .Connection = DataMaintenance.objConnection(ServerPath2)
                        .CommandText = "Dsm_Commission"
                        .CommandType = CommandType.StoredProcedure
                    End With
                    myParameter.Direction = ParameterDirection.Input
                    myParameter.Value = CommissionDate
                    myCommand.Parameters.Add(myParameter)

                    myAdapter.SelectCommand = myCommand
                    myAdapter.Fill(myDataSet.DSM_Commission)

                    With myCommand
                        .CommandText = "Dsm_PmrDetails"
                        .CommandType = CommandType.StoredProcedure
                    End With

                    myAdapter.SelectCommand = myCommand
                    myAdapter.Fill(myDataSet.Dsm_PmrDetails)

                    Dim myReport As New Report_DSMCommissionWithRecovery
                    myReport.SetDataSource(myDataSet)
                    ReportViewer.ReportSource = myReport
                Case "DSM Commission with Recovery2008"
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = DataMaintenance.objConnection(ServerPath2)
                        .CommandText = "Select * from DSM_Comm2008"
                        .CommandType = CommandType.Text
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New DSMCommission2008
                    myDataAdapter.Fill(myDataset, "DSM_Comm2008")

                    'Dim myReport As New ReportDocument
                    'myReport.Load(x & "\rpts\Report_DSMCommissionWithRecovery2008.rpt")
                    'myreport.SetDataSource(mydataset)
                    'ReportViewer.ReportSource = myreport

                    Dim myReport As New Report_DSMCommissionWithRecovery2008
                    myReport.SetDataSource(myDataset)
                    ReportViewer.ReportSource = myReport

                Case "DSM Commission with Recovery2009"
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = DataMaintenance.objConnection(ServerPath2)
                        .CommandText = "Select * from DSM_Comm2009 order by division, supname, mrname "
                        .CommandType = CommandType.Text
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New DSMCommission2009
                    myDataAdapter.Fill(myDataset, "DSM_Comm2009")

                    'Dim myReport As New ReportDocument
                    'myReport.Load(x & "\rpts\Report_DSMCommissionWithRecovery2009.rpt")
                    'myreport.SetDataSource(mydataset)
                    'ReportViewer.ReportSource = myreport

                    If CDate(CommissionDate) >= CDate("11/01/2009") Then  ' And CDate(CommissionDate) <= CDate("12/31/2009")) Then
                        Dim myReport As New Report_DSMCommissionWithRecovery2009PP
                        myReport.SetDataSource(myDataset)
                        ReportViewer.ReportSource = myReport
                    Else
                        Dim myReport As New Report_DSMCommissionWithRecovery2009
                        myReport.SetDataSource(myDataset)
                        ReportViewer.ReportSource = myReport
                    End If

                Case "DSM Commission with Recovery2010"
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = DataMaintenance.objConnection(ServerPath2)
                        .CommandText = "Select * from DSM_Comm2010 order by division, supname, mrname "
                        .CommandType = CommandType.Text
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New DSMCommission2009
                    myDataAdapter.Fill(myDataset, "DSM_Comm2009")

                    'Dim myReport As New ReportDocument
                    'myReport.Load(x & "\rpts\Report_DSMCommissionWithRecovery2009.rpt")
                    'myreport.SetDataSource(mydataset)
                    'ReportViewer.ReportSource = myreport

                    Dim myReport As New Report_DSMCommissionWithRecovery2010
                    myReport.SetDataSource(myDataset)
                    ReportViewer.ReportSource = myReport

                Case "DSM Commission with Recovery2011"
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = DataMaintenance.objConnection(ServerPath2)
                        .CommandText = "Select * from DSM_Comm2010 " & _
                                       "where division <> 'MyHealth' and left(supname, 3) <> 'PCH'  or division = '.'" & _
                                       "order by division, supname, mrname "
                        .CommandType = CommandType.Text
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New DSMCommission2009
                    myDataAdapter.Fill(myDataset, "DSM_Comm2009")

                    Dim myReport As New Report_DSMCommissionWithRecovery2011
                    myReport.SetDataSource(myDataset)
                    ReportViewer.ReportSource = myReport

                Case "DSM Commission with Recovery2012"
                    Try
                        If Not CommissionDate = Nothing Then    '[>>rnj_popoy**added
                            Dim myCommand As New SqlCommand     'continue if get commission date is not equal to nothing
                            With myCommand                      '02282013<<]
                                .Connection = DataMaintenance.objConnection(ServerPath2)
                                .CommandText = "Select * from DSM_Comm2010 " & _
                                                "where division <> 'MyHealth' and left(supname, 3) <> 'PCH'  or division = '.'" & _
                                                "order by division, supname, mrname "
                                .CommandType = CommandType.Text
                            End With
                            Dim myDataAdapter As New SqlDataAdapter
                            myDataAdapter.SelectCommand = myCommand
                            Dim myDataset As New DSMCommission2009
                            myDataAdapter.Fill(myDataset, "DSM_Comm2009")

                            Dim myReport As New Report_DSMCommissionWithRecovery2012
                            myReport.SetDataSource(myDataset)
                            ReportViewer.ReportSource = myReport
                        Else
                            Return
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                    '[>>rnj_popoy**added
                Case "DSM Commission with Recovery2013"
                    Try
                        If Not CommissionDate = Nothing Then
                            Dim myCommand As New SqlCommand
                            With myCommand
                                .Connection = DataMaintenance.objConnection(ServerPath2)
                                .CommandText = "Select * from DSM_Comm2010 " & _
                                                "where division <> 'MyHealth' and left(supname, 3) <> 'PCH'  or division = '.'" & _
                                                "order by division, supname, mrname "
                                .CommandType = CommandType.Text
                            End With
                            Dim myDataAdapter As New SqlDataAdapter
                            myDataAdapter.SelectCommand = myCommand
                            Dim myDataset As New DSMCommission2009
                            myDataAdapter.Fill(myDataset, "DSM_Comm2009")

                            Dim myReport As New Report_DSMCommissionWithRecovery2013
                            myReport.SetDataSource(myDataset)
                            ReportViewer.ReportSource = myReport

                            'BusinessObject.Sub_Show(ServerPath, "sp_v_dsm_comm2013", CommandType.StoredProcedure, _
                            '    xMyDataSets, "sp_v_dsm_comm2013")

                            'Dim _sqlDA As New SqlDataAdapter
                            'Dim _myNewDataSet As New DSMCommission2013
                            'Dim _myReport As New Report_DSMCommissionWithRecovery2013

                            '_myNewDataSet = xMyDataSets.sp_v_dsm_comm2013.DataSet
                            '_sqlDA.Fill(_myNewDataSet, "dsm_commission_2013")
                            '_myReport.SetDataSource(_myNewDataSet)
                            'ReportViewer.ReportSource = _myReport
                        Else
                            Return
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try '02272013<<]
                Case "DSM Commission with Recovery2014"
                    Try
                        If Not CommissionDate = Nothing Then
                            Dim myCommand As New SqlCommand
                            With myCommand
                                .Connection = DataMaintenance.objConnection(ServerPath2)
                                .CommandText = "Select * from DSM_Comm2010 " & _
                                                "where division <> 'MyHealth' and left(supname, 3) <> 'PCH'  or division = '.'" & _
                                                "order by division, supname, mrname "
                                .CommandType = CommandType.Text
                            End With
                            Dim myDataAdapter As New SqlDataAdapter
                            myDataAdapter.SelectCommand = myCommand
                            Dim myDataset As New DSMCommission2009
                            myDataAdapter.Fill(myDataset, "DSM_Comm2009")

                            Dim myReport As New Report_DSMCommissionWithRecovery2014
                            myReport.SetDataSource(myDataset)
                            ReportViewer.ReportSource = myReport

                            'BusinessObject.Sub_Show(ServerPath, "sp_v_dsm_comm2013", CommandType.StoredProcedure, _
                            '    xMyDataSets, "sp_v_dsm_comm2013")

                            'Dim _sqlDA As New SqlDataAdapter
                            'Dim _myNewDataSet As New DSMCommission2013
                            'Dim _myReport As New Report_DSMCommissionWithRecovery2013

                            '_myNewDataSet = xMyDataSets.sp_v_dsm_comm2013.DataSet
                            '_sqlDA.Fill(_myNewDataSet, "dsm_commission_2013")
                            '_myReport.SetDataSource(_myNewDataSet)
                            'ReportViewer.ReportSource = _myReport
                        Else
                            Return
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try '02272013<<]
                Case "DSM Commission with Recovery2010 Biomedica"
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = DataMaintenance.objConnection(ServerPath2)
                        .CommandText = "Select * from DSM_Comm2010 order by division, supname, mrname "
                        .CommandType = CommandType.Text
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New DSMCommission2009
                    myDataAdapter.Fill(myDataset, "DSM_Comm2009")

                    'Dim myReport As New ReportDocument
                    'myReport.Load(x & "\rpts\Report_DSMCommissionWithRecovery2009.rpt")
                    'myreport.SetDataSource(mydataset)
                    'ReportViewer.ReportSource = myreport

                    Dim myReport As New Report_DSMCommissionWithRecovery2010BioM
                    myReport.SetDataSource(myDataset)
                    ReportViewer.ReportSource = myReport

                Case "Medrep Commission QX 2008"
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = DataMaintenance.objConnection(ServerPath2)
                        .CommandText = "Select * from ComIncRecover"
                        .CommandType = CommandType.Text
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New ComIncRecover2008
                    myDataAdapter.Fill(myDataset, "ComIncRecover")

                    Dim myParameter As New SqlParameter
                    With myParameter
                        .ParameterName = "@CommissionDate"
                        .Direction = ParameterDirection.Input
                        .SqlDbType = SqlDbType.DateTime
                        .Size = 10
                        .Value = CommissionDate
                    End With
                    With myCommand
                        .Connection = DataMaintenance.objConnection(ServerPath2)
                        .CommandText = "MedrepCommission_Details"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add(myParameter)
                    End With
                    myDataAdapter.SelectCommand = myCommand
                    myDataAdapter.Fill(myDataset, "MedrepCommission_Details")

                    'Dim myReport As New ReportDocument
                    'myReport.Load(x & "\rpts\Report_MedrepCommission2008QX.rpt")
                    'myreport.SetDataSource(mydataset)
                    'ReportViewer.ReportSource = myreport

                    Dim myReport As New Report_MedrepCommission2008QX
                    myReport.SetDataSource(myDataset)
                    ReportViewer.ReportSource = myReport

                Case "Medrep Commission Chiral 2009"
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = DataMaintenance.objConnection(ServerPath2)
                        .CommandText = "Select * from ComIncRecoverChiral"
                        .CommandType = CommandType.Text
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New ComincRecover2009
                    myDataAdapter.Fill(myDataset, "ComIncRecover")

                    Dim myParameter As New SqlParameter
                    With myParameter
                        .ParameterName = "@CommissionDate"
                        .Direction = ParameterDirection.Input
                        .SqlDbType = SqlDbType.DateTime
                        .Size = 10
                        .Value = CommissionDate
                    End With
                    With myCommand
                        .Connection = DataMaintenance.objConnection(ServerPath2)
                        .CommandText = "MrCommDet_Chiral"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add(myParameter)
                    End With
                    myDataAdapter.SelectCommand = myCommand
                    myDataAdapter.Fill(myDataset, "ChiralPMR_2009SaleTarget")

                    Dim myReport As New Report_MedrepCommission2009_Chiral
                    myReport.SetDataSource(myDataset)
                    ReportViewer.ReportSource = myReport


                    'With myCommand
                    '    .Connection = DataMaintenance.objConnection(ServerPath2)
                    '    .CommandText = "MedrepCommission_Details_Chiral"
                    '    .CommandType = CommandType.StoredProcedure
                    '    .Parameters.Add(myParameter)
                    'End With
                    'myDataAdapter.SelectCommand = myCommand
                    'myDataAdapter.Fill(myDataset, "MedrepCommission_Details2009")

                    'mycommand.Parameters.Clear()

                    'Dim myPrams As New SqlParameter
                    'With myPrams
                    '    .ParameterName = "@CommissionDate"
                    '    .Direction = ParameterDirection.Input
                    '    .SqlDbType = SqlDbType.DateTime
                    '    .Size = 10
                    '    .Value = CommissionDate
                    'End With

                    'Dim myReport As New ReportDocument
                    'myReport.Load(x & "\rpts\Report_MedrepCommission2009_Chiral.rpt")
                    'myreport.SetDataSource(mydataset)
                    'ReportViewer.ReportSource = myreport

                Case "Medrep Commission Chiral 2010"
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = DataMaintenance.objConnection(ServerPath2)
                        .CommandText = "Select * from ComIncRecoverChiral"
                        .CommandType = CommandType.Text
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New ComincRecover2009
                    myDataAdapter.Fill(myDataset, "ComIncRecover")

                    Dim myParameter As New SqlParameter
                    With myParameter
                        .ParameterName = "@CommissionDate"
                        .Direction = ParameterDirection.Input
                        .SqlDbType = SqlDbType.DateTime
                        .Size = 10
                        .Value = CommissionDate
                    End With
                    With myCommand
                        .Connection = DataMaintenance.objConnection(ServerPath2)
                        .CommandText = "MrCommDet_Chiral"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add(myParameter)
                    End With
                    myDataAdapter.SelectCommand = myCommand
                    myDataAdapter.Fill(myDataset, "ChiralPMR_2009SaleTarget")

                    Dim myReport As New Report_MedrepCommission2010_Chiral
                    myReport.SetDataSource(myDataset)
                    ReportViewer.ReportSource = myReport

                Case "Medrep Commission MH 2010"
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = DataMaintenance.objConnection(ServerPath2)
                        .CommandText = "Select * from ComIncRecoverMH"
                        .CommandType = CommandType.Text
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New ComincRecover2009
                    myDataAdapter.Fill(myDataset, "ComIncRecover")

                    Dim myParameter As New SqlParameter
                    With myParameter
                        .ParameterName = "@CommissionDate"
                        .Direction = ParameterDirection.Input
                        .SqlDbType = SqlDbType.DateTime
                        .Size = 10
                        .Value = CommissionDate
                    End With
                    With myCommand
                        .Connection = DataMaintenance.objConnection(ServerPath2)
                        .CommandText = "MedrepCommission_DetailsMH"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add(myParameter)
                    End With
                    myDataAdapter.SelectCommand = myCommand
                    myDataAdapter.Fill(myDataset, "MedrepCommission_Details2009")

                    Dim myReport As New Report_MedrepCommission2010_MH
                    myReport.SetDataSource(myDataset)
                    ReportViewer.ReportSource = myReport

                Case "Medrep Commission FLT 2010"
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = DataMaintenance.objConnection(ServerPath2)
                        .CommandText = "Select * from ComIncRecoverFLT"
                        .CommandType = CommandType.Text
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New ComincRecover2009
                    myDataAdapter.Fill(myDataset, "ComIncRecover")

                    Dim myParameter As New SqlParameter
                    With myParameter
                        .ParameterName = "@CommissionDate"
                        .Direction = ParameterDirection.Input
                        .SqlDbType = SqlDbType.DateTime
                        .Size = 10
                        .Value = CommissionDate
                    End With
                    With myCommand
                        .Connection = DataMaintenance.objConnection(ServerPath2)
                        .CommandText = "MedrepCommission_DetailsFLT"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add(myParameter)
                    End With
                    myDataAdapter.SelectCommand = myCommand
                    myDataAdapter.Fill(myDataset, "MedrepCommission_Details2009")

                    Dim myReport As New Report_MedrepCommission2010_FLT
                    myReport.SetDataSource(myDataset)
                    ReportViewer.ReportSource = myReport

                Case "DSM Commission QX2008"
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = DataMaintenance.objConnection(ServerPath2)
                        .CommandText = "Select * from DSM_Comm2008"
                        .CommandType = CommandType.Text
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New DSMCommission2008
                    myDataAdapter.Fill(myDataset, "DSM_Comm2008")

                    'Dim myReport As New ReportDocument
                    'myReport.Load(x & "\rpts\Report_DSMCommission2008QX.rpt")
                    'myreport.SetDataSource(mydataset)
                    'ReportViewer.ReportSource = myreport

                    Dim myReport As New Report_DSMCommission2008QX
                    myReport.SetDataSource(myDataset)
                    ReportViewer.ReportSource = myReport

                Case "DSM Commission Chiral 2009"
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = DataMaintenance.objConnection(ServerPath2)
                        .CommandText = "Select * from DSM_Comm2009Chiral"
                        .CommandType = CommandType.Text
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New DSMCommission2009
                    myDataAdapter.Fill(myDataset, "DSM_Comm2009Chiral")

                    With myCommand
                        .Connection = DataMaintenance.objConnection(ServerPath2)
                        .CommandText = "DSMCommission_Details_Chiral"
                        .CommandType = CommandType.StoredProcedure
                        '.Parameters.Add(myParameter)
                    End With
                    myDataAdapter.SelectCommand = myCommand
                    myDataAdapter.Fill(myDataset, "Chiral2009_SalesTarget")

                    Dim myReport As New Report_DSMCommission2009_Chiral
                    myReport.SetDataSource(myDataset)
                    ReportViewer.ReportSource = myReport

                    'Dim myParameter As New SqlParameter
                    'With myParameter
                    '    .ParameterName = "@CommissionDate"
                    '    .Direction = ParameterDirection.Input
                    '    .SqlDbType = SqlDbType.DateTime
                    '    .Size = 10
                    '    .Value = CommDate
                    'End With

                    'Dim myReport As New ReportDocument                       <<temporarily made this
                    'myReport.Load(x & "\rpts\Report_DSMCommission2008QX.rpt")<<to add a report
                    'myreport.SetDataSource(mydataset)
                    'ReportViewer.ReportSource = myreport

                Case "DSM Commission Chiral 2010"
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = DataMaintenance.objConnection(ServerPath2)
                        .CommandText = "Select * from DSM_Comm2009Chiral"
                        .CommandType = CommandType.Text
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New DSMCommission2009
                    myDataAdapter.Fill(myDataset, "DSM_Comm2009Chiral")

                    With myCommand
                        .Connection = DataMaintenance.objConnection(ServerPath2)
                        .CommandText = "DSMCommission_Details_Chiral"
                        .CommandType = CommandType.StoredProcedure
                        '.Parameters.Add(myParameter)
                    End With
                    myDataAdapter.SelectCommand = myCommand
                    myDataAdapter.Fill(myDataset, "Chiral2009_SalesTarget")

                    Dim myReport As New Report_DSMCommission2010_Chiral
                    myReport.SetDataSource(myDataset)
                    ReportViewer.ReportSource = myReport

                Case "PMR Year to date Recovery Commission"
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = DataMaintenance.objConnection(ServerPath2)
                        .CommandText = "Select * from YTDrecoveryTab order by division, supcode, mrcode, commissiondate"
                        .CommandType = CommandType.Text
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New dsYTDrecovery
                    myDataAdapter.Fill(myDataset, "YTDrecoveryTab")

                    Dim myReport As New Report_YTDrecovery
                    myReport.SetDataSource(myDataset)
                    ReportViewer.ReportSource = myReport
                Case "DSM Year End Recovery Commission"
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = DataMaintenance.objConnection(ServerPath2)
                        .CommandText = "Select * from YTDrecoveryTab order by division, supcode, commissiondate"
                        .CommandType = CommandType.Text
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New dsYTDrecovery
                    myDataAdapter.Fill(myDataset, "YTDrecoveryTabDSM")

                    Dim myReport As New Report_YTDrecoveryDSM
                    myReport.SetDataSource(myDataset)
                    ReportViewer.ReportSource = myReport

                Case "PMR Year to date PushRecovery Commission"
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = DataMaintenance.objConnection(ServerPath2)
                        .CommandText = "Select * from YTDrecoveryTab order by division, supcode, mrcode, commissiondate"
                        .CommandType = CommandType.Text
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New dsYTDrecovery
                    myDataAdapter.Fill(myDataset, "YTDrecoveryTab")

                    Dim myReport As New Report_YTDrecoveryPush
                    myReport.SetDataSource(myDataset)
                    ReportViewer.ReportSource = myReport

                Case "DSM Year to date PushRecovery Commission"
                    Dim myCommand As New SqlCommand
                    With myCommand
                        .Connection = DataMaintenance.objConnection(ServerPath2)
                        .CommandText = "Select * from YTDrecoveryTab order by division, supcode, commissiondate"
                        .CommandType = CommandType.Text
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New dsYTDrecovery
                    myDataAdapter.Fill(myDataset.YTDrecoveryTab)   ', "YTDrecoveryTab")
                    'myDataset.YTDrecoveryTab.Columns.Item("division").ToString()
                    Dim myReport As New Report_YTDrecoveryDSMpush
                    myReport.SetDataSource(myDataset)
                    ReportViewer.ReportSource = myReport

                    '[>>rnj_popoy**added
                Case "Sales per KAS Govt"
                    Me.Cursor = Cursors.WaitCursor
                    Dim _sCommissionDate As String = CommissionDate

                    Try
                        If Not _sCommissionDate = Nothing Then
                            Dim myConnection As New SqlConnection
                            With myConnection
                                .ConnectionString = ServerPath2
                                .Open()
                            End With

                            Dim myCommand As New SqlCommand
                            With myCommand
                                .Connection = myConnection
                                .CommandText = "report_salesperkasgovt"
                                .CommandType = CommandType.StoredProcedure
                                .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = _sCommissionDate
                            End With

                            Dim myDataAdapter As New SqlDataAdapter
                            myDataAdapter.SelectCommand = myCommand

                            Dim myDataset As New dsMdiSalesPerMedrep
                            myDataAdapter.Fill(myDataset, "Report_MdiSalesPerMedrep")

                            Dim myReport As New Report_SalesPerKASGovt
                            myReport.SetDataSource(myDataset.Tables("REPORT_MdiSalesPerMedrep"))
                            ReportViewer.ReportSource = myReport
                        Else
                            Me.Cursor = Cursors.Default
                            Return
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    Me.Cursor = Cursors.Default '03182013<<]

                    '[>>rnj_popoy**added
                Case "Commission Report Attachment KAS Govt"
                    Me.Cursor = Cursors.WaitCursor
                    Dim _sCommissionDate As String = CommissionDate

                    Try
                        If Not _sCommissionDate = Nothing Then
                            Dim myConnection As New SqlConnection
                            With myConnection
                                .ConnectionString = ServerPath2
                                .Open()
                            End With
                            Dim myCommand As New SqlCommand
                            With myCommand
                                .Connection = myConnection
                                .CommandText = "report_commissionattachment_kasgovt2013"
                                .CommandType = CommandType.StoredProcedure
                                .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = _sCommissionDate
                            End With

                            Dim myDataAdapter As New SqlDataAdapter
                            myDataAdapter.SelectCommand = myCommand

                            Dim myDataset As New dsCommissionAttachment
                            myDataAdapter.Fill(myDataset, "Report_CommissionAttachment")

                            Dim myReport As New Report_CommissionAttachmentKASGovt
                            myReport.SetDataSource(myDataset.Tables("REPORT_CommissionAttachment"))
                            ReportViewer.ReportSource = myReport
                        Else
                            Me.Cursor = Cursors.Default
                            Return
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    Me.Cursor = Cursors.Default '03202013<<]

                    '[>>rnj_popoy**added
                Case "KAS - Government Commission Report"
                    Me.Cursor = Cursors.WaitCursor
                    Dim _sCommissionDate As String = CommissionDate

                    Try
                        If Not CommissionDate = Nothing Then
                            Dim myCommand As New SqlCommand
                            With myCommand
                                .Connection = DataMaintenance.objConnection(ServerPath2)
                                .CommandText = "Select * from ComIncRecover"
                                .CommandType = CommandType.Text
                            End With

                            Dim myDataAdapter As New SqlDataAdapter
                            myDataAdapter.SelectCommand = myCommand

                            Dim myDataset As New ComincRecover2009
                            myDataAdapter.Fill(myDataset, "ComIncRecover")

                            Dim myParameter As New SqlParameter
                            With myParameter
                                .ParameterName = "@CommissionDate"
                                .Direction = ParameterDirection.Input
                                .SqlDbType = SqlDbType.DateTime
                                .Size = 10
                                .Value = CommissionDate
                            End With

                            With myCommand
                                .Connection = DataMaintenance.objConnection(ServerPath2)
                                .CommandText = "KASGovtCommission_Details"
                                .CommandType = CommandType.StoredProcedure
                                .Parameters.Add(myParameter)
                            End With

                            myDataAdapter.SelectCommand = myCommand
                            myDataAdapter.Fill(myDataset, "MedrepCommission_Details2009")

                            Dim myReport As New Report_KASGovtCommission
                            myReport.SetDataSource(myDataset)
                            ReportViewer.ReportSource = myReport

                        Else
                            Me.Cursor = Cursors.Default
                            Return '**return nothing
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    Me.Cursor = Cursors.Default '03212013<<]

            End Select
        Catch ex As Exception
            MessageBox.Show(ex.GetBaseException.ToString)
        End Try
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
End Class
