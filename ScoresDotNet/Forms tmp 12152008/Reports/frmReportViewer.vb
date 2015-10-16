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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'ReportViewer
        '
        Me.ReportViewer.ActiveViewIndex = -1
        Me.ReportViewer.Location = New System.Drawing.Point(8, 8)
        Me.ReportViewer.Name = "ReportViewer"
        Me.ReportViewer.ReportSource = Nothing
        Me.ReportViewer.Size = New System.Drawing.Size(1008, 704)
        Me.ReportViewer.TabIndex = 0
        '
        'frmReportViewer
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1024, 718)
        Me.Controls.Add(Me.ReportViewer)
        Me.Name = "frmReportViewer"
        Me.Text = "Report Viewer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private ReportName As String
    Private CommissionMonth As String

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
                Case "Commission Report Attachment(DM)"
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
                    With mycommand
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
                    myreport.SetDataSource(mydataset)
                    ReportViewer.ReportSource = myreport
                Case "Medrep Commission with Recovery2008"
                    Dim myCommand As New SqlCommand
                    With mycommand
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

                    Dim myReport As New ReportDocument
                    myReport.Load(x & "\rpts\Report_MedrepCommissionWithRecovery2008.rpt")
                    myreport.SetDataSource(mydataset)
                    ReportViewer.ReportSource = myreport

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
                    myparameter.Direction = ParameterDirection.Input
                    myparameter.Value = CommissionDate
                    mycommand.Parameters.Add(myparameter)

                    myAdapter.SelectCommand = mycommand
                    myAdapter.Fill(mydataset.DSM_Commission)

                    With mycommand
                        .CommandText = "Dsm_PmrDetails"
                        .CommandType = CommandType.StoredProcedure
                    End With

                    myAdapter.SelectCommand = mycommand
                    myAdapter.Fill(mydataset.Dsm_PmrDetails)

                    Dim myReport As New Report_DSMCommissionWithRecovery
                    myreport.SetDataSource(mydataset)
                    ReportViewer.ReportSource = myreport
                Case "DSM Commission with Recovery2008"
                    'Dim myCommand As New SqlCommand
                    'Dim myParameter As New SqlParameter("@CommissionDate", SqlDbType.DateTime, 10)
                    'Dim myAdapter As New SqlDataAdapter
                    'Dim myDataSet As New DSMCommission2008
                    'With myCommand
                    '    .Connection = DataMaintenance.objConnection(ServerPath2)
                    '    .CommandText = "Dsm_Commission_2008"
                    '    .CommandType = CommandType.StoredProcedure
                    'End With
                    'myparameter.Direction = ParameterDirection.Input
                    'myparameter.Value = CommissionDate
                    'mycommand.Parameters.Add(myparameter)

                    'myAdapter.SelectCommand = mycommand
                    'myAdapter.Fill(mydataset.DSM_Commission2008)

                    'With mycommand
                    '    .CommandText = "Dsm_PmrDetails"
                    '    .CommandType = CommandType.StoredProcedure
                    'End With

                    'myAdapter.SelectCommand = mycommand
                    'myAdapter.Fill(mydataset.Dsm_PmrDetails)

                    'Dim myCommand As New SqlCommand
                    'With mycommand
                    '    .Connection = DataMaintenance.objConnection(ServerPath2)
                    '    .CommandText = "Select * from DSM_Commission2008"
                    '    .CommandType = CommandType.Text
                    'End With
                    'Dim myDataAdapter As New SqlDataAdapter
                    'myDataAdapter.SelectCommand = myCommand
                    'Dim myDataset As New DSMCommission2008
                    'myDataAdapter.Fill(myDataset, "DSM_Commission2008")

                    'Dim myParameter As New SqlParameter
                    'With myParameter
                    '    .ParameterName = "@CommissionDate"
                    '    .Direction = ParameterDirection.Input
                    '    .SqlDbType = SqlDbType.DateTime
                    '    .Size = 10
                    '    .Value = CommissionDate
                    'End With
                    'With myCommand
                    '    .Connection = DataMaintenance.objConnection(ServerPath2)
                    '    .CommandText = "Dsm_PmrDetails"
                    '    .CommandType = CommandType.StoredProcedure
                    '    .Parameters.Add(myParameter)
                    'End With
                    'myDataAdapter.SelectCommand = myCommand
                    'myDataAdapter.Fill(myDataset, "Dsm_PmrDetails")
                    Dim myCommand As New SqlCommand
                    With mycommand
                        .Connection = DataMaintenance.objConnection(ServerPath2)
                        .CommandText = "Select * from DSM_Comm2008"
                        .CommandType = CommandType.Text
                    End With
                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand
                    Dim myDataset As New DSMCommission2008
                    myDataAdapter.Fill(myDataset, "DSM_Comm2008")

                    Dim myReport As New ReportDocument
                    myReport.Load(x & "\rpts\Report_DSMCommissionWithRecovery2008.rpt")
                    myreport.SetDataSource(mydataset)
                    'myreport.Refresh()
                    ReportViewer.ReportSource = myreport
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.GetBaseException.ToString)
        End Try
    End Sub
End Class
