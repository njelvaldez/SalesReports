Option Strict Off
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports Microsoft.Office.Interop.Excel
Imports Scripting
'Imports DataAccessHelper

Module modDistributeReports
    Private myDate As String
    Private chkIndividual As Boolean
    Private strSupervisor As String
    Dim MyExportOptions As New ExportOptions


    Public Sub DistributeReports(ByVal strReportName As String, _
    ByVal chkIndividual As Boolean, Optional ByVal strSupervisor As String = "")
        'Dim myDialogbox As New frmDialogBox
        'myDialogbox.ShowDialog()
        myDate = CommDate    ' myDialogbox.CommissionDate
        Dim myDAHelper As New DataAccessLayer.DataAccessHelper

        Select Case strReportName
            Case "Sales Per Medical Representative"
                Try
                    'Get the respective Teritories per Medrep
                    Dim myCommand As New SqlCommand
                    Dim myReport As New Report_MdiSalesPerMedrep
                    Dim myDataset As New dsMdiSalesPerMedrep

                    With myCommand
                        .Connection = myDAHelper.ObjectConnection(ServerPath)
                        .CommandText = "GetTerritoriesPerMedrep"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = myDate
                        .ExecuteNonQuery()
                    End With

                    Dim myCommand2 As New SqlCommand
                    With myCommand2
                        .Connection = myDAHelper.ObjectConnection(ServerPath2)
                        .CommandText = "Report_MdiSalesPerMedrep"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = myDate
                    End With

                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand2
                    myDataAdapter.Fill(myDataset, "Report_MdiSalesPerMedrep")

                    myReport.SetDataSource(myDataset.Tables("REPORT_MdiSalesPerMedrep"))
                    MailRouteLoop(myReport, strReportName, myDate, "{REPORT_MdiSalesPerMedrep.SupCode} = ", chkIndividual, strSupervisor)

                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try
            Case "Mercury Sales Per Medical Representative"
                Try
                    Dim myCommand As New SqlCommand
                    Dim myReport As New Report_MercurySales
                    Dim myDataset As New dsMercurySales
                    With myCommand
                        .Connection = myDAHelper.ObjectConnection(ServerPath)
                        .CommandText = "Transfer_MercurySalesIntoTemporary"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = myDate
                        .ExecuteNonQuery()
                    End With

                    Dim myCommand2 As New SqlCommand
                    With myCommand2
                        .Connection = myDAHelper.ObjectConnection(ServerPath)
                        .CommandText = "SELECT * FROM Tempory_Mercury "
                        .CommandType = CommandType.Text
                    End With

                    Dim myDataAdapter As New SqlDataAdapter
                    myDataAdapter.SelectCommand = myCommand2
                    myDataAdapter.Fill(myDataset, "tempory_Mercury")

                    myReport.SetDataSource(myDataset.Tables("tempory_Mercury"))
                    MailRouteLoop(myReport, strReportName, myDate, "{tempory_Mercury.SupCode} = ", chkIndividual, strSupervisor)

                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try

            Case "Commission Report Attachment (PMR)"
                Dim myCommand As New SqlCommand
                Dim myReport As New Report_CommissionAttachment
                Dim myDataset As New dsCommissionAttachment
                With myCommand
                    .CommandText = "COMMISSION_ComputeAttachment"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = myDAHelper.ObjectConnection(ServerPath2)
                    .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = myDate
                    .ExecuteNonQuery()
                End With

                Dim myCommand2 As New SqlCommand
                With myCommand2
                    .Connection = myDAHelper.ObjectConnection(ServerPath2)
                    .CommandText = "Report_CommissionAttachment"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = myDate
                End With
                Dim myDataAdapter As New SqlDataAdapter
                myDataAdapter.SelectCommand = myCommand2
                myDataAdapter.Fill(myDataset, "Report_CommissionAttachment")

                myReport.SetDataSource(myDataset.Tables("REPORT_CommissionAttachment"))
                MailRouteLoop(myReport, strReportName, myDate, "{REPORT_CommissionAttachment.SupCode} = ", chkIndividual, strSupervisor)

            Case "Commission Report Attachment (DSM)"
                Dim myCommand As New SqlCommand
                Dim myReport As New Report_CommissionAttachmentSpv
                Dim myDataset As New dsCommissionAttachment
                With myCommand
                    .Connection = myDAHelper.ObjectConnection(ServerPath2)
                    .CommandText = "COMMISSION_ComputeAttachment"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = myDate
                    .ExecuteNonQuery()
                End With

                Dim myCommand2 As New SqlCommand
                With myCommand2
                    .Connection = myDAHelper.ObjectConnection(ServerPath2)
                    .CommandText = "Report_CommissionAttachment"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = myDate
                End With
                Dim myDataAdapter As New SqlDataAdapter
                myDataAdapter.SelectCommand = myCommand2
                myDataAdapter.Fill(myDataset, "Report_CommissionAttachment")

                myReport.SetDataSource(myDataset.Tables("REPORT_CommissionAttachment"))
                MailRouteLoop(myReport, strReportName, myDate, "{REPORT_CommissionAttachment.SupCode} = ", chkIndividual, strSupervisor)

                'Case "Medrep Commission"
                'MedRepCommission_NoRecovery(strReportName, chkIndividual, strSupervisor)
            Case "Medrep Commission with Recovery"
                MedRepCommission_WithRecovery(strReportName, chkIndividual, strSupervisor)
            Case "District Manager Commission with Recovery"
                DSMCommission_WithRecovery(strReportName, chkIndividual, strSupervisor)
            Case "All"
                'Try
                '    Dim myConnection As New SqlConnection
                '    With myConnection
                '        .ConnectionString = "Data Source=MicDb; Initial Catalog=ScoresDotNet; User Id=sa;Password=jynxz"
                '        .Open()
                '    End With
                'Catch ex As Exception
                '    MessageBox.Show(ex.ToString)
                'End Try
        End Select
        MessageBox.Show("Export Finished!" & vbCrLf & "Report appended to MS Outlook Drafts.")
    End Sub
    Private Sub MailRouteLoop(ByVal myReport As Object, ByVal strReportName As String, _
    ByVal strCommissionDate As String, ByVal strParameterField As String, Optional ByVal blnIndividual As Boolean = False, _
    Optional ByVal strSupervisor As String = "")
        'Loop Starts Here
        Dim i As Integer
        Dim myOlApp As New Outlook.Application
        Dim myItem As Outlook.MailItem
        Dim myNameSpace As Outlook.NameSpace
        myNameSpace = myOlApp.GetNamespace("MAPI")
        myNameSpace.Logon("Outlook", , True, True)

        'Export Options
        ' Declare variables and get the export options.
        Dim exportOpts As New ExportOptions
        Dim diskOpts As New DiskFileDestinationOptions
        exportOpts = myReport.ExportOptions

        ' Set the export format.
        exportOpts.ExportFormatType = ExportFormatType.Excel
        exportOpts.ExportDestinationType = ExportDestinationType.DiskFile


        Dim myDataReader As SqlDataReader
        Dim mySqlString As String
        Select Case blnIndividual
            Case True
                mySqlString = " select rtrim(supcode) [supcode],supname,email from newscores..supervisor " & _
                      " where email>'' and resign_date>" & myDate & _
                      " and supname='" & strSupervisor & "'"
            Case Else
                'mySqlString = " select rtrim(it.supcode) [supcode],it.supname,su.email,nm.email [NsEmail]" & _
                '            " from scoresdotnet..integratedsales it " & _
                '            " inner join newscores..nsmdivisionassignment ns on it.divisioncode=ns.divcode" & _
                '            " inner join newscores..nsm nm on ns.nsmcode=nm.nsmcode" & _
                '            " inner join newscores..supervisor su on it.supcode=su.supcode" & _
                '            " where it.supcode>'' and it.CommissionDate=" & "'" & myDate & "'" & _
                '            " Group by it.supcode, it.supname, su.email, nm.email"
                mySqlString = " select rtrim(supcode) [supcode],supname,email from supervisor "
                mySqlString = mySqlString & "where email>'' "
                mySqlString = mySqlString & "  and left(supcode, 1) <> 'X' "
                mySqlString = mySqlString & "  and '" & Trim(myDate) & "' "
                mySqlString = mySqlString & "      between hire_date and resign_date "
                mySqlString = mySqlString & "   order by supname "
        End Select
        myDataReader = DataMaintenance.GetResultSet(ServerPath, mySqlString, CommandType.Text)
        With myDataReader
            If .HasRows Then
                While .Read
                    myReport.RecordSelectionFormula = strParameterField & "'" & Trim(CStr(myDataReader("SupCode"))) & "'"
                    myReport.Refresh()

                    diskOpts.DiskFileName = CStr(ExportPath & CStr(myDataReader("SupCode")) & ".xls")
                    exportOpts.DestinationOptions = diskOpts
                    Try
                        myReport.export()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                    myItem = myOlApp.CreateItem(Outlook.OlItemType.olMailItem)
                    With myItem
                        .To = CStr(myDataReader("Email"))

                        .Subject = strReportName & " as of " & strCommissionDate
                        .Attachments.Add(CStr(ExportPath & CStr(myDataReader("SupCode")) & ".xls"))
                        .Save()
                    End With
                End While
            End If
        End With
        myOlApp.Quit()
        myOlApp = Nothing
        'CleanTempFiles()
        'Loop Ends Here
    End Sub
    Private Sub CleanTempFiles()
        Dim myfile As File
        Dim myFolder As Folder
        Dim myFsObj As New FileSystemObject
        myFolder = myFsObj.GetFolder(ExportPath)

        For Each myfile In myFolder.Files
            myfile.Delete(True)
        Next
    End Sub
    Private Sub MedRepCommission_NoRecovery(ByVal strReportName As String, _
    ByVal chkIndividual As Boolean, Optional ByVal strSupervisor As String = "")
        'Dim myDAHelper As New DAHelper
        'Dim myAdapter As New SqlDataAdapter
        'Dim myReport As New Report_MedrepCommission
        'Dim myDataSet As New dsMedrepCommission
        'Dim myCommand As New SqlCommand
        'Dim Params(0) As SqlParameter
        'Dim CommissionDate As New SqlParameter("@CommissionDate", SqlDbType.DateTime, 10) : CommissionDate.Value = myDate : Params(0) = CommissionDate
        'Try
        '    myAdapter.SelectCommand = myDAHelper.CommandExecute(Params, ServerPath2, "REPORT_MedrepCommission", CommandType.StoredProcedure)
        '    myAdapter.Fill(myDataSet.REPORT_MedrepCommission)
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message.ToString)
        '    Exit Sub
        'End Try
        'myReport.SetDataSource(myDataSet.REPORT_MedrepCommission)
        'MailRouteLoop(myReport, strReportName, myDate, "{REPORT_MedrepCommission.SupCode} = ", chkIndividual, strSupervisor)
    End Sub
    Private Sub MedRepCommission_WithRecovery(ByVal strReportName As String, _
        ByVal chkIndividual As Boolean, Optional ByVal strSupervisor As String = "")
        If Val(Right(myDate, 4)) < 2008 Then
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
                .Value = myDate
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
            MailRouteLoop(myReport, strReportName, myDate, "{ComIncRecover.SupCode} = ", chkIndividual, strSupervisor)
        ElseIf Val(Right(myDate, 4)) = 2008 Then
            Dim myCommand As New SqlCommand

            'Compute the Attachment
            DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
            DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
            DataMaintenance.myParamArray(0, 2) = 10
            DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
            DataMaintenance.myParamArray(0, 4) = "Date"
            DataMaintenance.myParamArray(0, 5) = myDate
            DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComIncAttach", CommandType.StoredProcedure, 1)

            'Compute the ComInc
            DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
            DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
            DataMaintenance.myParamArray(0, 2) = 10
            DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
            DataMaintenance.myParamArray(0, 4) = "Date"
            DataMaintenance.myParamArray(0, 5) = myDate
            DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComInc2008", CommandType.StoredProcedure, 1)

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
                .Value = myDate
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
            myReport.Load(AppPath & "\rpts\Report_MedrepCommissionWithRecovery2008.rpt")
            myReport.SetDataSource(myDataset)
            MailRouteLoop(myReport, strReportName, myDate, "{ComIncRecover.SupCode} = ", chkIndividual, strSupervisor)
        ElseIf Val(Right(myDate, 4)) > 2008 Then
            MsgBox("Commission is not yet available for the year entered!")
        End If
    End Sub
    Private Sub DSMCommission_WithRecovery(ByVal strReportName As String, _
        ByVal chkIndividual As Boolean, Optional ByVal strSupervisor As String = "")
        If Val(Right(myDate, 4)) < 2008 Then
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
            myParameter.Value = myDate
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
            MailRouteLoop(myReport, strReportName, myDate, "{DSM_Commission.SupCode} = ", chkIndividual, strSupervisor)
        ElseIf Val(Right(myDate, 4)) = 2008 Then

            'Compute the Attachment
            DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
            DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
            DataMaintenance.myParamArray(0, 2) = 10
            DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
            DataMaintenance.myParamArray(0, 4) = "Date"
            DataMaintenance.myParamArray(0, 5) = myDate
            DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComIncAttach", CommandType.StoredProcedure, 1)

            'Compute the ComInc
            DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
            DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
            DataMaintenance.myParamArray(0, 2) = 10
            DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
            DataMaintenance.myParamArray(0, 4) = "Date"
            DataMaintenance.myParamArray(0, 5) = myDate
            DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComInc2008", CommandType.StoredProcedure, 1)

            'Compute the DSM_Commission2008
            DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
            DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
            DataMaintenance.myParamArray(0, 2) = 10
            DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
            DataMaintenance.myParamArray(0, 4) = "Date"
            DataMaintenance.myParamArray(0, 5) = myDate
            DataMaintenance.ExecuteCommand(ServerPath2, "DSM_Commission_2008", CommandType.StoredProcedure, 1)

            'Compute the DSMPMR_det
            DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
            DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
            DataMaintenance.myParamArray(0, 2) = 10
            DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
            DataMaintenance.myParamArray(0, 4) = "Date"
            DataMaintenance.myParamArray(0, 5) = myDate
            DataMaintenance.ExecuteCommand(ServerPath2, "DSMPMR_det", CommandType.StoredProcedure, 1)

            'Compute the DSMPMR_ins
            Dim LocalCommand As New SqlCommand
            With LocalCommand
                .Connection = ObjectConnection(ServerPath2)
                .CommandText = "DSMPMR_ins"
                .CommandType = CommandType.StoredProcedure
                .ExecuteScalar()
            End With

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
            myReport.Load(AppPath & "\rpts\Report_DSMCommissionWithRecovery2008.rpt")
            myReport.SetDataSource(myDataSet)
            MailRouteLoop(myReport, strReportName, myDate, "{DSM_Comm2008.SupCode} = ", chkIndividual, strSupervisor)
        ElseIf Val(Right(myDate, 4)) > 2008 Then
            MsgBox("Commission is not yet available for the year entered!")
        End If
    End Sub
    Public Sub View_jpa_Performance_Reports(ByVal CrystalReport As Object, ByVal MyForm As Form)
        Dim LocalObject As New BusinessLayer.clsSalesAndTargetsTransfer
        Dim LocalDs As New SalesAndTargets_Transfer
        Dim myDateBox As New frmDialogBox
        myDateBox.ShowDialog(MyForm)
        Dim Params(0) As SqlParameter
        Dim myDate As String = myDateBox.CommissionDate
        Dim CommissionDate As New SqlParameter("@CommissionDate", SqlDbType.DateTime, 10) : CommissionDate.Value = myDate : Params(0) = CommissionDate
        LocalObject.Show_SalesAndTargetsTransfer(ServerPath2, "Show_SalesAndTargets_Transfer", CommandType.StoredProcedure, LocalDs, "Show_SalesAndTargets_Transfer", Params)

        Dim myReportViewer As New frmReportViewer
        myReportViewer.MdiParent = MyForm
        CrystalReport.SetDataSource(LocalDs)
        myReportViewer.ReportViewer.ReportSource = CrystalReport
        myReportViewer.Show()
    End Sub
    Public Sub View_jpa_Performance_ReportsQty(ByVal CrystalReport As Object, ByVal MyForm As Form, ByVal strDataTable As String)
        Dim LocalObject As New BusinessLayer.clsSalesAndTargetsTransfer
        Dim LocalDs As New SalesAndTargets_Transfer
        Dim myDateBox As New frmDialogBox
        myDateBox.ShowDialog(MyForm)
        Dim Params(0) As SqlParameter
        Dim myDate As String = myDateBox.CommissionDate
        Dim CommissionDate As New SqlParameter("@CommissionDate", SqlDbType.DateTime, 10) : CommissionDate.Value = myDate : Params(0) = CommissionDate
        LocalObject.Show_SalesAndTargetsTransfer(ServerPath2, "Show_SalesAndTargets_Transfer_Qty", CommandType.StoredProcedure, LocalDs, strDataTable, Params)

        Dim myReportViewer As New frmReportViewer
        myReportViewer.MdiParent = MyForm
        CrystalReport.SetDataSource(LocalDs)
        myReportViewer.ReportViewer.ReportSource = CrystalReport
        myReportViewer.Show()
    End Sub
    Public Sub View_jpa_Performance_ReportsQtyDirect(ByVal CrystalReport As Object, ByVal MyForm As Form, ByVal strDataTable As String)
        Dim LocalObject As New BusinessLayer.clsSalesAndTargetsTransfer
        Dim LocalDs As New SalesAndTargets_Transfer
        Dim myDateBox As New frmDialogBox
        myDateBox.ShowDialog(MyForm)
        Dim Params(0) As SqlParameter
        Dim myDate As String = myDateBox.CommissionDate
        Dim CommissionDate As New SqlParameter("@CommissionDate", SqlDbType.DateTime, 10) : CommissionDate.Value = myDate : Params(0) = CommissionDate
        LocalObject.Show_SalesAndTargetsTransfer(ServerPath2, "Show_SalesAndTargets_Direct_Qty", CommandType.StoredProcedure, LocalDs, strDataTable, Params)

        Dim myReportViewer As New frmReportViewer
        myReportViewer.MdiParent = MyForm
        CrystalReport.SetDataSource(LocalDs)
        myReportViewer.ReportViewer.ReportSource = CrystalReport
        myReportViewer.Show()
    End Sub
    Public Sub View_jpa_Performance_Reports_Direct(ByVal CrystalReport As Object, ByVal MyForm As Form)
        Dim LocalObject As New BusinessLayer.clsSalesAndTargetsTransfer
        Dim LocalDs As New SalesAndTargets_Direct
        Dim myDateBox As New frmDialogBox
        myDateBox.ShowDialog(MyForm)
        Dim Params(0) As SqlParameter
        Dim myDate As String = myDateBox.CommissionDate
        Dim CommissionDate As New SqlParameter("@CommissionDate", SqlDbType.DateTime, 10) : CommissionDate.Value = myDate : Params(0) = CommissionDate
        LocalObject.Show_SalesAndTargetsDirect(ServerPath2, "Show_SalesAndTargets_Direct", CommandType.StoredProcedure, LocalDs, "Show_SalesAndTargets_Direct", Params)

        Dim myReportViewer As New frmReportViewer
        myReportViewer.MdiParent = MyForm
        CrystalReport.SetDataSource(LocalDs)
        myReportViewer.ReportViewer.ReportSource = CrystalReport
        myReportViewer.Show()
    End Sub
End Module
