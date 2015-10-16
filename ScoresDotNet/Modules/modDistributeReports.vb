Option Strict Off
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports Microsoft.Office.Interop.Excel
Imports Scripting
'Imports DataAccessHelper

Module modDistributeReports
    Private myDate As String, myDate2 As String, mDate As String
    Private chkIndividual As Boolean
    Private strSupervisor As String
    Dim MyExportOptions As New ExportOptions


    Public Sub DistributeReports(ByVal strReportName As String, _
    ByVal chkIndividual As Boolean, Optional ByVal strSupervisor As String = "")
        'Dim myDialogbox As New frmDialogBox
        'myDialogbox.ShowDialog()
        myDate = CommDate    ' myDialogbox.CommissionDate
        myDate2 = CommDate2
        Dim myDAHelper As New DataAccessLayer.DataAccessHelper

        Select Case strReportName
            Case "Sales Per Medical Representative"
                Try
                    If Trim(myDate2) > "" Then
                        For i = 0 To (Month(CDate(myDate2)) - Month(CDate(myDate)))
                            Dim myCommand As New SqlCommand
                            Dim myReport As New Report_MdiSalesPerMedrep
                            Dim myDataset As New dsMdiSalesPerMedrep
                            Dim myCommand2 As New SqlCommand
                            Dim myDataAdapter As New SqlDataAdapter
                            mDate = DateAdd("m", i, myDate)
                            With myCommand
                                .Connection = myDAHelper.ObjectConnection(ServerPath)
                                If MHdist = True Then
                                    .CommandText = "GetTerritoriesPerMedrepMH"
                                Else
                                    .CommandText = "GetTerritoriesPerMedrep"
                                End If
                                .CommandText = "GetTerritoriesPerMedrep"
                                .CommandType = CommandType.StoredProcedure
                                .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = mDate
                                .ExecuteNonQuery()
                            End With

                            With myCommand2
                                .Connection = myDAHelper.ObjectConnection(ServerPath2)
                                If MHdist = True Then
                                    .CommandText = "Report_MdiSalesPerMedrepMH"
                                Else
                                    .CommandText = "Report_MdiSalesPerMedrep"
                                End If
                                .CommandType = CommandType.StoredProcedure
                                .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = mDate
                            End With

                            myDataAdapter.SelectCommand = myCommand2
                            myDataAdapter.Fill(myDataset, "Report_MdiSalesPerMedrep")

                            myReport.SetDataSource(myDataset.Tables("REPORT_MdiSalesPerMedrep"))
                            'MailRouteLoop(myReport, strReportName, mDate, _
                            '              "{REPORT_MdiSalesPerMedrep.SupCode} = ", chkIndividual, _
                            '              strSupervisor)
                        Next
                    Else
                        Dim myCommand As New SqlCommand
                        Dim myReport As New Report_MdiSalesPerMedrep
                        Dim myDataset As New dsMdiSalesPerMedrep
                        Dim myCommand2 As New SqlCommand
                        Dim myDataAdapter As New SqlDataAdapter
                        With myCommand
                            .Connection = myDAHelper.ObjectConnection(ServerPath)
                            If MHdist = True Then
                                .CommandText = "GetTerritoriesPerMedrepMH"
                            Else
                                .CommandText = "GetTerritoriesPerMedrep"
                            End If
                            .CommandText = "GetTerritoriesPerMedrep"
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = myDate
                            .ExecuteNonQuery()
                        End With

                        With myCommand2
                            .Connection = myDAHelper.ObjectConnection(ServerPath2)
                            If MHdist = True Then
                                .CommandText = "Report_MdiSalesPerMedrepMH"
                            Else
                                .CommandText = "Report_MdiSalesPerMedrep"
                            End If
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = myDate
                        End With

                        myDataAdapter.SelectCommand = myCommand2
                        myDataAdapter.Fill(myDataset, "Report_MdiSalesPerMedrep")

                        myReport.SetDataSource(myDataset.Tables("REPORT_MdiSalesPerMedrep"))
                        'MailRouteLoop(myReport, strReportName, myDate, _
                        '              "{REPORT_MdiSalesPerMedrep.SupCode} = ", chkIndividual, _
                        '              strSupervisor)
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try
            Case "Mercury Sales Per Medical Representative"
                Try
                    If Trim(myDate2) > "" Then
                        For i = 0 To (Month(CDate(myDate2)) - Month(CDate(myDate)))
                            Dim myCommand As New SqlCommand
                            Dim myReport As New Report_MercurySales
                            Dim myDataset As New dsMercurySales
                            Dim myCommand2 As New SqlCommand
                            Dim myDataAdapter As New SqlDataAdapter
                            mDate = DateAdd("m", i, myDate)
                            With myCommand
                                .Connection = myDAHelper.ObjectConnection(ServerPath)
                                If MHdist = True Then
                                    .CommandText = "Transfer_MercurySalesIntoTemporaryMH"
                                Else
                                    .CommandText = "Transfer_MercurySalesIntoTemporary"
                                End If
                                .CommandType = CommandType.StoredProcedure
                                .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = mDate
                                .ExecuteNonQuery()
                            End With

                            With myCommand2
                                .Connection = myDAHelper.ObjectConnection(ServerPath)
                                .CommandText = "SELECT * FROM Tempory_Mercury "
                                .CommandType = CommandType.Text
                            End With

                            myDataAdapter.SelectCommand = myCommand2
                            myDataAdapter.Fill(myDataset, "tempory_Mercury")

                            myReport.SetDataSource(myDataset.Tables("tempory_Mercury"))
                            'MailRouteLoop(myReport, strReportName, mDate, "{tempory_Mercury.SupCode} = ", chkIndividual, strSupervisor)
                        Next i
                    Else
                        Dim myCommand As New SqlCommand
                        Dim myReport As New Report_MercurySales
                        Dim myDataset As New dsMercurySales
                        With myCommand
                            .Connection = myDAHelper.ObjectConnection(ServerPath)
                            If MHdist = True Then
                                .CommandText = "Transfer_MercurySalesIntoTemporaryMH"
                            Else
                                .CommandText = "Transfer_MercurySalesIntoTemporary"
                            End If
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
                        'MailRouteLoop(myReport, strReportName, myDate, "{tempory_Mercury.SupCode} = ", chkIndividual, strSupervisor)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try

            Case "Commission Report Attachment (PMR)"
                If Trim(myDate2) > "" Then
                    For i = 0 To (Month(CDate(myDate2)) - Month(CDate(myDate)))
                        Dim myCommand As New SqlCommand
                        Dim myReport As New Report_CommissionAttachment
                        Dim myDataset As New dsCommissionAttachment
                        mDate = DateAdd("m", i, myDate)
                        With myCommand
                            .CommandText = "COMMISSION_ComputeAttachment"
                            .CommandType = CommandType.StoredProcedure
                            .Connection = myDAHelper.ObjectConnection(ServerPath2)
                            .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = mDate
                            .ExecuteNonQuery()
                        End With

                        Dim myCommand2 As New SqlCommand
                        With myCommand2
                            .Connection = myDAHelper.ObjectConnection(ServerPath2)
                            .CommandText = "Report_CommissionAttachment"
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = mDate
                        End With
                        Dim myDataAdapter As New SqlDataAdapter
                        myDataAdapter.SelectCommand = myCommand2
                        myDataAdapter.Fill(myDataset, "Report_CommissionAttachment")

                        myReport.SetDataSource(myDataset.Tables("REPORT_CommissionAttachment"))
                        'MailRouteLoop(myReport, strReportName, mDate, "{REPORT_CommissionAttachment.SupCode} = ", chkIndividual, strSupervisor)
                    Next i
                Else
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
                    'MailRouteLoop(myReport, strReportName, myDate, "{REPORT_CommissionAttachment.SupCode} = ", chkIndividual, strSupervisor)
                End If
            Case "Commission Report Attachment (DSM)"
                If Trim(myDate2) > "" Then
                    For i = 0 To (Month(CDate(myDate2)) - Month(CDate(myDate)))
                        Dim myCommand As New SqlCommand
                        Dim myReport As New Report_CommissionAttachmentSpv
                        Dim myDataset As New dsCommissionAttachment
                        mDate = DateAdd("m", i, myDate)
                        With myCommand
                            .Connection = myDAHelper.ObjectConnection(ServerPath2)
                            .CommandText = "COMMISSION_ComputeAttachment"
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = mDate
                            .ExecuteNonQuery()
                        End With

                        Dim myCommand2 As New SqlCommand
                        With myCommand2
                            .Connection = myDAHelper.ObjectConnection(ServerPath2)
                            .CommandText = "Report_CommissionAttachment"
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add("@CommissionDate", SqlDbType.DateTime, 10).Value = mDate
                        End With
                        Dim myDataAdapter As New SqlDataAdapter
                        myDataAdapter.SelectCommand = myCommand2
                        myDataAdapter.Fill(myDataset, "Report_CommissionAttachment")

                        myReport.SetDataSource(myDataset.Tables("REPORT_CommissionAttachment"))
                        'MailRouteLoop(myReport, strReportName, mDate, "{REPORT_CommissionAttachment.SupCode} = ", chkIndividual, strSupervisor)
                    Next i
                Else
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
                    'MailRouteLoop(myReport, strReportName, myDate, "{REPORT_CommissionAttachment.SupCode} = ", chkIndividual, strSupervisor)
                End If
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
    'Private Sub MailRouteLoop(ByVal myReport As Object, ByVal strReportName As String, _
    '                          ByVal strCommissionDate As String, ByVal strParameterField As String, _
    '                          Optional ByVal blnIndividual As Boolean = False, _
    '                          Optional ByVal strSupervisor As String = "")
    '    'Loop Starts Here
    '    Dim i As Integer
    '    Dim myOlApp As New Outlook.Application
    '    Dim myItem As Outlook.MailItem
    '    Dim myNameSpace As Outlook.NameSpace
    '    myNameSpace = myOlApp.GetNamespace("MAPI")
    '    myNameSpace.Logon("Outlook", , True, True)

    '    'Export Options
    '    ' Declare variables and get the export options.
    '    Dim exportOpts As New ExportOptions
    '    Dim diskOpts As New DiskFileDestinationOptions
    '    exportOpts = myReport.ExportOptions

    '    ' Set the export format.
    '    exportOpts.ExportFormatType = ExportFormatType.Excel
    '    exportOpts.ExportDestinationType = ExportDestinationType.DiskFile


    '    Dim myDataReader As SqlDataReader
    '    Dim mySqlString As String
    '    Select Case blnIndividual
    '        Case True
    '            mySqlString = " select rtrim(supcode) [supcode],supname,email from newscores..supervisor " & _
    '                  " where email>'' and resign_date>" & myDate & _
    '                  " and supname='" & strSupervisor & "'"
    '        Case Else
    '            'mySqlString = " select rtrim(it.supcode) [supcode],it.supname,su.email,nm.email [NsEmail]" & _
    '            '            " from scoresdotnet..integratedsales it " & _
    '            '            " inner join newscores..nsmdivisionassignment ns on it.divisioncode=ns.divcode" & _
    '            '            " inner join newscores..nsm nm on ns.nsmcode=nm.nsmcode" & _
    '            '            " inner join newscores..supervisor su on it.supcode=su.supcode" & _
    '            '            " where it.supcode>'' and it.CommissionDate=" & "'" & myDate & "'" & _
    '            '            " Group by it.supcode, it.supname, su.email, nm.email"
    '            If chiralDist = True Then
    '                mySqlString = " select rtrim(supcode) [supcode],supname,email from supervisor "
    '                mySqlString = mySqlString & "where email>'' "
    '                mySqlString = mySqlString & "  and left(supcode, 1) = 'X' "
    '                mySqlString = mySqlString & "  and '" & Trim(myDate) & "' "
    '                mySqlString = mySqlString & "      between hire_date and resign_date "
    '                mySqlString = mySqlString & "   order by supname "
    '            Else
    '                mySqlString = " select rtrim(supcode) [supcode],supname,email from supervisor "
    '                mySqlString = mySqlString & "where email>'' "
    '                mySqlString = mySqlString & "  and left(supcode, 1) <> 'X' "
    '                mySqlString = mySqlString & "  and '" & Trim(myDate) & "' "
    '                mySqlString = mySqlString & "      between hire_date and resign_date "
    '                mySqlString = mySqlString & "   order by supname "
    '            End If
    '    End Select
    '    myDataReader = DataMaintenance.GetResultSet(ServerPath, mySqlString, CommandType.Text)
    '    With myDataReader
    '        If .HasRows Then
    '            While .Read
    '                myReport.RecordSelectionFormula = strParameterField & "'" & Trim(CStr(myDataReader("SupCode"))) & "'"
    '                myReport.Refresh()
    '                If Trim(myDate2) > "" Then
    '                    If Month(CDate(mDate)) = 1 Then
    '                        diskOpts.DiskFileName = CStr(ExpPath1 & "Jan" & CStr(myDataReader("SupName")) & ".xls")
    '                    ElseIf Month(CDate(mDate)) = 2 Then
    '                        diskOpts.DiskFileName = CStr(ExpPath2 & CStr(myDataReader("SupName")) & ".xls")
    '                    ElseIf Month(CDate(mDate)) = 3 Then
    '                        diskOpts.DiskFileName = CStr(ExpPath3 & CStr(myDataReader("SupName")) & ".xls")
    '                    ElseIf Month(CDate(mDate)) = 4 Then
    '                        diskOpts.DiskFileName = CStr(ExpPath4 & CStr(myDataReader("SupName")) & ".xls")
    '                    ElseIf Month(CDate(mDate)) = 5 Then
    '                        diskOpts.DiskFileName = CStr(ExpPath5 & CStr(myDataReader("SupName")) & ".xls")
    '                    ElseIf Month(CDate(mDate)) = 6 Then
    '                        diskOpts.DiskFileName = CStr(ExpPath6 & CStr(myDataReader("SupName")) & ".xls")
    '                    ElseIf Month(CDate(mDate)) = 7 Then
    '                        diskOpts.DiskFileName = CStr(ExpPath7 & CStr(myDataReader("SupName")) & ".xls")
    '                    ElseIf Month(CDate(mDate)) = 8 Then
    '                        diskOpts.DiskFileName = CStr(ExpPath8 & CStr(myDataReader("SupName")) & ".xls")
    '                    ElseIf Month(CDate(mDate)) = 9 Then
    '                        diskOpts.DiskFileName = CStr(ExpPath9 & CStr(myDataReader("SupName")) & ".xls")
    '                    ElseIf Month(CDate(mDate)) = 10 Then
    '                        diskOpts.DiskFileName = CStr(ExpPath10 & CStr(myDataReader("SupName")) & ".xls")
    '                    ElseIf Month(CDate(mDate)) = 11 Then
    '                        diskOpts.DiskFileName = CStr(ExpPath11 & CStr(myDataReader("SupName")) & ".xls")
    '                    ElseIf Month(CDate(mDate)) = 12 Then
    '                        diskOpts.DiskFileName = CStr(ExpPath12 & CStr(myDataReader("SupName")) & ".xls")
    '                    End If
    '                Else
    '                    diskOpts.DiskFileName = CStr(ExportPath & CStr(myDataReader("SupName")) & ".xls")
    '                End If
    '                'originaly here --> diskOpts.DiskFileName = CStr(ExportPath & CStr(myDataReader("SupCode")) & ".xls")
    '                exportOpts.DestinationOptions = diskOpts
    '                Try
    '                    myReport.export()
    '                Catch ex As Exception
    '                    MsgBox(ex.Message)
    '                End Try

    '                myItem = myOlApp.CreateItem(Outlook.OlItemType.olMailItem)
    '                With myItem
    '                    .To = CStr(myDataReader("Email"))

    '                    .Subject = strReportName & " as of " & strCommissionDate
    '                    If Trim(myDate2) > "" Then
    '                        If Month(CDate(mDate)) = 1 Then
    '                            myItem.Attachments.Add(CStr(ExpPath1 & CStr(myDataReader("SupName")) & ".xls"))
    '                        ElseIf Month(CDate(mDate)) = 2 Then
    '                            myItem.Attachments.Add(CStr(ExpPath2 & CStr(myDataReader("SupName")) & ".xls"))
    '                        ElseIf Month(CDate(mDate)) = 3 Then
    '                            myItem.Attachments.Add(CStr(ExpPath3 & CStr(myDataReader("SupName")) & ".xls"))
    '                        ElseIf Month(CDate(mDate)) = 4 Then
    '                            myItem.Attachments.Add(CStr(ExpPath4 & CStr(myDataReader("SupName")) & ".xls"))
    '                        ElseIf Month(CDate(mDate)) = 5 Then
    '                            myItem.Attachments.Add(CStr(ExpPath5 & CStr(myDataReader("SupName")) & ".xls"))
    '                        ElseIf Month(CDate(mDate)) = 6 Then
    '                            myItem.Attachments.Add(CStr(ExpPath6 & CStr(myDataReader("SupName")) & ".xls"))
    '                        ElseIf Month(CDate(mDate)) = 7 Then
    '                            myItem.Attachments.Add(CStr(ExpPath7 & CStr(myDataReader("SupName")) & ".xls"))
    '                        ElseIf Month(CDate(mDate)) = 8 Then
    '                            myItem.Attachments.Add(CStr(ExpPath8 & CStr(myDataReader("SupName")) & ".xls"))
    '                        ElseIf Month(CDate(mDate)) = 9 Then
    '                            myItem.Attachments.Add(CStr(ExpPath9 & CStr(myDataReader("SupName")) & ".xls"))
    '                        ElseIf Month(CDate(mDate)) = 10 Then
    '                            myItem.Attachments.Add(CStr(ExpPath10 & CStr(myDataReader("SupName")) & ".xls"))
    '                        ElseIf Month(CDate(mDate)) = 11 Then
    '                            myItem.Attachments.Add(CStr(ExpPath11 & CStr(myDataReader("SupName")) & ".xls"))
    '                        ElseIf Month(CDate(mDate)) = 12 Then
    '                            myItem.Attachments.Add(CStr(ExpPath12 & CStr(myDataReader("SupName")) & ".xls"))
    '                        End If
    '                    Else
    '                        myItem.Attachments.Add(CStr(ExportPath & CStr(myDataReader("SupName")) & ".xls"))
    '                    End If
    '                    'originaly here --> .Attachments.Add(CStr(ExportPath & CStr(myDataReader("SupCode")) & ".xls"))
    '                    .Body = "Automated email. Do not reply!"
    '                    .Save()
    '                End With
    '            End While
    '        End If
    '    End With
    '    myOlApp.Quit()
    '    myOlApp = Nothing
    '    'CleanTempFiles()
    '    'Loop Ends Here
    'End Sub
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
            'MailRouteLoop(myReport, strReportName, myDate, "{ComIncRecover.SupCode} = ", chkIndividual, strSupervisor)
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

            'Dim myReport As New ReportDocument
            'myReport.Load(AppPath & "\rpts\Report_MedrepCommissionWithRecovery2008.rpt")
            'myReport.SetDataSource(myDataset)

            Dim myReport As New Report_MedrepCommissionWithRecovery2008
            myreport.SetDataSource(myDataset)
            'MailRouteLoop(myReport, strReportName, myDate, "{ComIncRecover.SupCode} = ", chkIndividual, strSupervisor)
        ElseIf Val(Right(myDate, 4)) = 2009 Then
            Dim myCommand As New SqlCommand

            'Compute the Attachment
            DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
            DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
            DataMaintenance.myParamArray(0, 2) = 10
            DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
            DataMaintenance.myParamArray(0, 4) = "Date"
            DataMaintenance.myParamArray(0, 5) = myDate
            DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComIncAttach2009", CommandType.StoredProcedure, 1)

            'Compute the ComInc
            DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
            DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
            DataMaintenance.myParamArray(0, 2) = 10
            DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
            DataMaintenance.myParamArray(0, 4) = "Date"
            DataMaintenance.myParamArray(0, 5) = myDate
            If Month(CDate(myDate)) <= 3 And Year(CDate(myDate)) <= 2009 Then
                DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComInc2009", _
                                               CommandType.StoredProcedure, 1)
            ElseIf Month(CDate(myDate)) > 3 And Year(CDate(myDate)) >= 2009 Then
                DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComInc2009a", _
                                               CommandType.StoredProcedure, 1)
            End If
            'MsgBox("Commission is not yet available for the year entered!")
            With mycommand
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
                .Value = myDate
            End With
            With myCommand
                .Connection = DataMaintenance.objConnection(ServerPath2)
                .CommandText = "MedrepCommission_Details2009"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add(myParameter)
            End With
            myDataAdapter.SelectCommand = myCommand
            myDataAdapter.Fill(myDataset, "MedrepCommission_Details2009")

            Dim myReport As New Report_MedrepCommissionWithRecovery2009
            myreport.SetDataSource(myDataset)
            'MailRouteLoop(myReport, strReportName, myDate, "{ComIncRecover.SupCode} = ", chkIndividual, strSupervisor)
        ElseIf Val(Right(myDate, 4)) = 2010 Then
            Dim myCommand As New SqlCommand

            'Compute the Attachment
            DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
            DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
            DataMaintenance.myParamArray(0, 2) = 10
            DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
            DataMaintenance.myParamArray(0, 4) = "Date"
            DataMaintenance.myParamArray(0, 5) = myDate
            DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComIncAttach2010", CommandType.StoredProcedure, 1)

            'Compute the ComInc
            DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
            DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
            DataMaintenance.myParamArray(0, 2) = 10
            DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
            DataMaintenance.myParamArray(0, 4) = "Date"
            DataMaintenance.myParamArray(0, 5) = myDate
            DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComInc2010", _
                                               CommandType.StoredProcedure, 1)
            'MsgBox("Commission is not yet available for the year entered!")
            With mycommand
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
                .Value = myDate
            End With
            With myCommand
                .Connection = DataMaintenance.objConnection(ServerPath2)
                .CommandText = "MedrepCommission_Details2010"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add(myParameter)
            End With
            myDataAdapter.SelectCommand = myCommand
            myDataAdapter.Fill(myDataset, "MedrepCommission_Details2009")

            Dim myReport As New Report_MedrepCommissionWithRecovery2010
            myreport.SetDataSource(myDataset)
            'MailRouteLoop(myReport, strReportName, myDate, "{ComIncRecover.SupCode} = ", chkIndividual, strSupervisor)

        ElseIf Val(Right(myDate, 4)) = 2011 Then
            Dim myCommand As New SqlCommand

            'Compute the Attachment
            DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
            DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
            DataMaintenance.myParamArray(0, 2) = 10
            DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
            DataMaintenance.myParamArray(0, 4) = "Date"
            DataMaintenance.myParamArray(0, 5) = myDate
            DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComIncAttach2010", CommandType.StoredProcedure, 1)

            'Compute the ComInc
            DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
            DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
            DataMaintenance.myParamArray(0, 2) = 10
            DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
            DataMaintenance.myParamArray(0, 4) = "Date"
            DataMaintenance.myParamArray(0, 5) = myDate
            DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComInc2011", _
                                               CommandType.StoredProcedure, 1)
            'MsgBox("Commission is not yet available for the year entered!")
            With mycommand
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
                .Value = myDate
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
            myreport.SetDataSource(myDataset)
            'MailRouteLoop(myReport, strReportName, myDate, "{ComIncRecover.SupCode} = ", chkIndividual, strSupervisor)
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
            'MailRouteLoop(myReport, strReportName, myDate, "{DSM_Commission.SupCode} = ", chkIndividual, strSupervisor)
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

            'Dim myReport As New ReportDocument
            'myReport.Load(AppPath & "\rpts\Report_DSMCommissionWithRecovery2008.rpt")
            'myReport.SetDataSource(myDataSet)

            Dim myReport As New Report_DSMCommissionWithRecovery2008
            myreport.SetDataSource(mydataset)
            'MsgBox("Commission is not yet available for the year entered!")
            'MailRouteLoop(myReport, strReportName, myDate, "{DSM_Comm2008.SupCode} = ", chkIndividual, strSupervisor)
        ElseIf Val(Right(myDate, 4)) = 2009 Then
            'Compute the Attachment
            DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
            DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
            DataMaintenance.myParamArray(0, 2) = 10
            DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
            DataMaintenance.myParamArray(0, 4) = "Date"
            DataMaintenance.myParamArray(0, 5) = myDate
            DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComIncAttach2009", CommandType.StoredProcedure, 1)

            'Compute the ComInc
            DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
            DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
            DataMaintenance.myParamArray(0, 2) = 10
            DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
            DataMaintenance.myParamArray(0, 4) = "Date"
            DataMaintenance.myParamArray(0, 5) = myDate
            If Month(CDate(myDate)) <= 3 And Year(CDate(myDate)) <= 2009 Then
                DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComInc2009", _
                                               CommandType.StoredProcedure, 1)
            ElseIf Month(CDate(myDate)) > 3 And Year(CDate(myDate)) >= 2009 Then
                DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComInc2009a", _
                                               CommandType.StoredProcedure, 1)
            End If

            'Compute the DSM_Commission2008
            DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
            DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
            DataMaintenance.myParamArray(0, 2) = 10
            DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
            DataMaintenance.myParamArray(0, 4) = "Date"
            DataMaintenance.myParamArray(0, 5) = myDate
            DataMaintenance.ExecuteCommand(ServerPath2, "DSM_Commission_2009", CommandType.StoredProcedure, 1)

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
                .CommandText = "DSMPMR_ins_2009"
                .CommandType = CommandType.StoredProcedure
                .ExecuteScalar()
            End With

            Dim myCommand As New SqlCommand
            With mycommand
                .Connection = DataMaintenance.objConnection(ServerPath2)
                .CommandText = "Select * from DSM_Comm2009 order by division, supname, mrname "
                .CommandType = CommandType.Text
            End With
            Dim myDataAdapter As New SqlDataAdapter
            myDataAdapter.SelectCommand = myCommand
            Dim myDataset As New DSMCommission2009
            myDataAdapter.Fill(myDataset, "DSM_Comm2009")

            'Dim myReport As New ReportDocument
            'myReport.Load(AppPath & "\rpts\Report_DSMCommissionWithRecovery2009.rpt")
            'myreport.SetDataSource(mydataset)

            Dim myReport As New Report_DSMCommissionWithRecovery2009
            myreport.SetDataSource(mydataset)
            'MailRouteLoop(myReport, strReportName, myDate, "{DSM_Comm2008.SupCode} = ", chkIndividual, strSupervisor)
        ElseIf Val(Right(myDate, 4)) = 2010 Then
            'Compute the Attachment
            DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
            DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
            DataMaintenance.myParamArray(0, 2) = 10
            DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
            DataMaintenance.myParamArray(0, 4) = "Date"
            DataMaintenance.myParamArray(0, 5) = myDate
            DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComIncAttach2010", CommandType.StoredProcedure, 1)

            'Compute the ComInc
            DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
            DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
            DataMaintenance.myParamArray(0, 2) = 10
            DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
            DataMaintenance.myParamArray(0, 4) = "Date"
            DataMaintenance.myParamArray(0, 5) = myDate
            DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComInc2010", _
                                           CommandType.StoredProcedure, 1)

            'Compute the DSM_Commission2008
            DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
            DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
            DataMaintenance.myParamArray(0, 2) = 10
            DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
            DataMaintenance.myParamArray(0, 4) = "Date"
            DataMaintenance.myParamArray(0, 5) = myDate
            DataMaintenance.ExecuteCommand(ServerPath2, "DSM_Commission_2010", _
                                            CommandType.StoredProcedure, 1)

            'Compute the DSMPMR_det
            DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
            DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
            DataMaintenance.myParamArray(0, 2) = 10
            DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
            DataMaintenance.myParamArray(0, 4) = "Date"
            DataMaintenance.myParamArray(0, 5) = myDate
            DataMaintenance.ExecuteCommand(ServerPath2, "DSMPMR_det2010", CommandType.StoredProcedure, 1)

            'Compute the DSMPMR_ins
            Dim LocalCommand As New SqlCommand
            With LocalCommand
                .Connection = ObjectConnection(ServerPath2)
                .CommandText = "DSMPMR_ins_2010"
                .CommandType = CommandType.StoredProcedure
                .ExecuteScalar()
            End With

            Dim myCommand As New SqlCommand
            With mycommand
                .Connection = DataMaintenance.objConnection(ServerPath2)
                .CommandText = "Select * from DSM_Comm2010 order by division, supname, mrname "
                .CommandType = CommandType.Text
            End With
            Dim myDataAdapter As New SqlDataAdapter
            myDataAdapter.SelectCommand = myCommand
            Dim myDataset As New DSMCommission2009
            myDataAdapter.Fill(myDataset, "DSM_Comm2009")

            'Dim myReport As New ReportDocument
            'myReport.Load(AppPath & "\rpts\Report_DSMCommissionWithRecovery2009.rpt")
            'myreport.SetDataSource(mydataset)

            Dim myReport As New Report_DSMCommissionWithRecovery2010
            myreport.SetDataSource(mydataset)
            'MailRouteLoop(myReport, strReportName, myDate, "{DSM_Comm2008.SupCode} = ", chkIndividual, strSupervisor)

        ElseIf Val(Right(myDate, 4)) = 2011 Then
            'Compute the Attachment
            DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
            DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
            DataMaintenance.myParamArray(0, 2) = 10
            DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
            DataMaintenance.myParamArray(0, 4) = "Date"
            DataMaintenance.myParamArray(0, 5) = myDate
            DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComIncAttach2010", CommandType.StoredProcedure, 1)

            'Compute the ComInc
            DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
            DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
            DataMaintenance.myParamArray(0, 2) = 10
            DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
            DataMaintenance.myParamArray(0, 4) = "Date"
            DataMaintenance.myParamArray(0, 5) = myDate
            DataMaintenance.ExecuteCommand(ServerPath2, "Compute_ComInc2011", _
                                           CommandType.StoredProcedure, 1)

            'Compute the DSM_Commission2008
            DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
            DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
            DataMaintenance.myParamArray(0, 2) = 10
            DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
            DataMaintenance.myParamArray(0, 4) = "Date"
            DataMaintenance.myParamArray(0, 5) = myDate
            DataMaintenance.ExecuteCommand(ServerPath2, "DSM_Commission_2011", _
                                            CommandType.StoredProcedure, 1)

            'Compute the DSMPMR_det
            DataMaintenance.myParamArray(0, 0) = "@CommissionDate"
            DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
            DataMaintenance.myParamArray(0, 2) = 10
            DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
            DataMaintenance.myParamArray(0, 4) = "Date"
            DataMaintenance.myParamArray(0, 5) = myDate
            DataMaintenance.ExecuteCommand(ServerPath2, "DSMPMR_det2010", CommandType.StoredProcedure, 1)

            'Compute the DSMPMR_ins
            Dim LocalCommand As New SqlCommand
            With LocalCommand
                .Connection = ObjectConnection(ServerPath2)
                .CommandText = "DSMPMR_ins_2010"
                .CommandType = CommandType.StoredProcedure
                .ExecuteScalar()
            End With

            Dim myCommand As New SqlCommand
            With mycommand
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
            myreport.SetDataSource(mydataset)
            'MailRouteLoop(myReport, strReportName, myDate, "{DSM_Comm2008.SupCode} = ", chkIndividual, strSupervisor)
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
        Dim mnFrm As New Main
        'myReportViewer.MdiParent = MyForm
        CrystalReport.SetDataSource(LocalDs)
        myReportViewer.ReportViewer.ReportSource = CrystalReport
        myReportViewer.ShowDialog(mnFrm)
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
        Dim mnFrm As New Main
        'myReportViewer.MdiParent = MyForm
        CrystalReport.SetDataSource(LocalDs)
        myReportViewer.ReportViewer.ReportSource = CrystalReport
        myReportViewer.ShowDialog(mnFrm)
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
        Dim mnFrm As New Main
        'myReportViewer.MdiParent = MyForm
        CrystalReport.SetDataSource(LocalDs)
        myReportViewer.ReportViewer.ReportSource = CrystalReport
        myReportViewer.ShowDialog(mnFrm)
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
        Dim mnFrm As New Main
        'myReportViewer.MdiParent = MyForm
        CrystalReport.SetDataSource(LocalDs)
        myReportViewer.ReportViewer.ReportSource = CrystalReport
        myReportViewer.ShowDialog(mnFrm)
    End Sub
End Module
