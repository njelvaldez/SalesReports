Imports System.Data.SqlClient
Imports Microsoft
Imports Microsoft.Office.Interop
Imports System.Configuration
Imports System.Globalization
Imports System.Runtime.InteropServices
Public Class frmAccountCoverage

    Private salesinvupdpath As String = System.Configuration.ConfigurationSettings.AppSettings.Item("SalesTrendPath")
    Private SalesTransDate As String = ""
    Private RemoteDataSet As New DataSet
    Private MonthName As String = ""
    Private Sub SetDate()
        Dim currentdate As String
        currentdate = dtpMonth.Value.Month.ToString + "/1/" + dtpMonth.Value.Year.ToString
        dtpMonth.Text = currentdate
        MonthName = "Jan - " + dtpMonth.Value.ToString("MMM", New CultureInfo("en-US")) + " 2014 vs. Last year"
    End Sub

    Private Sub SetPath()
        Dim currentdate As String
        Dim format As String = "MMM d yyyy"
        currentdate = DateTime.Now.ToString("MMM", New CultureInfo("en-US")) + " 1 - " + DateTime.Now.Date.Day.ToString() + " " + DateTime.Now.Date.Year.ToString()
        txtTemplate.Text = salesinvupdpath + "SOURCE Accounts Coverage.xlsx"
        txtOutput.Text = salesinvupdpath + "SOURCE Accounts Coverage " + MonthName + ".xlsx"
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmAccountCoverage_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RemoteDataSet.Tables.Add("IntegratedSales")
        SetDate()
        SetPath()
    End Sub

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        Dim salesinvupdfile As String = txtTemplate.Text.ToString
        SetDate()
        SetPath()
        Me.Cursor = Cursors.WaitCursor
        ShowInvoice()
        ShowInvoice2()
        GenerateAccountCoverage(salesinvupdfile)
        Me.Cursor = Cursors.Default
        MsgBox("Process is complete." + " Account coverage File : " + txtOutput.Text.ToString + " is generated!")
    End Sub

    Private Sub ShowInvoice()
        Try
            'If RemoteDataSet.Tables("IntegratedSales").Rows.Count > 0 Then RemoteDataSet.Tables("IntegratedSales").Clear()
            RefreshTable()
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim cycledatefrom As DateTime
            Dim cycledateto As DateTime
            Dim cycledatelyfrom As DateTime
            Dim cycledatelyto As DateTime
            Dim lastyear As String = (dtpMonth.Value.Year - 1).ToString()

            cycledatefrom = "1/1/" + dtpMonth.Value.Year.ToString()
            cycledateto = dtpMonth.Text.ToString().Trim()
            cycledatelyfrom = "1/1/" + lastyear
            cycledatelyto = dtpMonth.Value.Month.ToString.Trim() + "/" + dtpMonth.Value.Day.ToString.Trim() + "/" + lastyear


            Dim Params(3) As SqlParameter
            Dim salescycledatefrom As New SqlParameter("@salescycledatefrom", SqlDbType.DateTime, 10) : salescycledatefrom.Direction = ParameterDirection.Input : salescycledatefrom.Value = cycledatefrom : Params(0) = salescycledatefrom
            Dim salescycledateto As New SqlParameter("@salescycledateto", SqlDbType.DateTime, 10) : salescycledateto.Direction = ParameterDirection.Input : salescycledateto.Value = cycledateto : Params(1) = salescycledateto
            Dim salescycledatelyfrom As New SqlParameter("@salescycledatelyfrom", SqlDbType.DateTime, 10) : salescycledatelyfrom.Direction = ParameterDirection.Input : salescycledatelyfrom.Value = cycledatelyfrom : Params(2) = salescycledatelyfrom
            Dim salescycledatelyto As New SqlParameter("@salescycledatelyto", SqlDbType.DateTime, 10) : salescycledatelyto.Direction = ParameterDirection.Input : salescycledatelyto.Value = cycledatelyto : Params(3) = salescycledatelyto

            BusinessObject.Sub_Show(ServerPath2, "Util_AccountCoverageNatl_Select", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            LogHelper.InsertLog("frmAccountCoverage.ShowInvoice.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmAccountCoverage.ShowInvoice.Error: " & ex.Message)
        End Try
    End Sub
    Private Sub ShowInvoice2()
        Try
            'If RemoteDataSet.Tables("IntegratedSales").Rows.Count > 0 Then RemoteDataSet.Tables("IntegratedSales").Clear()
            RefreshTable()
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim cycledatefrom As DateTime
            Dim cycledateto As DateTime
            Dim cycledatelyfrom As DateTime
            Dim cycledatelyto As DateTime
            Dim lastyear As String = (dtpMonth.Value.Year - 1).ToString()

            cycledatefrom = "1/1/" + dtpMonth.Value.Year.ToString()
            cycledateto = dtpMonth.Text.ToString().Trim()
            cycledatelyfrom = "1/1/" + lastyear
            cycledatelyto = dtpMonth.Value.Month.ToString.Trim() + "/" + dtpMonth.Value.Day.ToString.Trim() + "/" + lastyear


            Dim Params(3) As SqlParameter
            Dim salescycledatefrom As New SqlParameter("@salescycledatefrom", SqlDbType.DateTime, 10) : salescycledatefrom.Direction = ParameterDirection.Input : salescycledatefrom.Value = cycledatefrom : Params(0) = salescycledatefrom
            Dim salescycledateto As New SqlParameter("@salescycledateto", SqlDbType.DateTime, 10) : salescycledateto.Direction = ParameterDirection.Input : salescycledateto.Value = cycledateto : Params(1) = salescycledateto
            Dim salescycledatelyfrom As New SqlParameter("@salescycledatelyfrom", SqlDbType.DateTime, 10) : salescycledatelyfrom.Direction = ParameterDirection.Input : salescycledatelyfrom.Value = cycledatelyfrom : Params(2) = salescycledatelyfrom
            Dim salescycledatelyto As New SqlParameter("@salescycledatelyto", SqlDbType.DateTime, 10) : salescycledatelyto.Direction = ParameterDirection.Input : salescycledatelyto.Value = cycledatelyto : Params(3) = salescycledatelyto

            BusinessObject.Sub_Show(ServerPath2, "Util_AccountCoverageDiv_Select", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales2.DataSource = RemoteDataSet.Tables("IntegratedSales")
            LogHelper.InsertLog("frmAccountCoverage.ShowInvoice.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmAccountCoverage.ShowInvoice.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub GenerateAccountCoverage(ByVal strFileName As String)
        Dim xl As New Excel.Application
        Dim wb As Excel.Workbook
        Dim ws As Excel.Worksheet
        Dim wsdiv As Excel.Worksheet
        Dim wsntl As Excel.Worksheet
        Dim wscovdiv As Excel.Worksheet
        Dim range As Excel.Range
        Dim rownumber As Integer = 2
        Dim rownumberntl As Integer = 0
        Dim salesinvupdout As String = txtOutput.Text.ToString
        Dim salesinvupd As String = txtTemplate.Text.ToString
        Try
            wb = xl.Workbooks.Open(strFileName)

            ws = CType(wb.Worksheets.Item("Acct Coverage-Natl"), Excel.Worksheet)
            wsdiv = CType(wb.Worksheets.Item("Acct Coverage-Division"), Excel.Worksheet)
            wsntl = CType(wb.Worksheets.Item("Acct Cov-Natl Source"), Excel.Worksheet)
            wscovdiv = CType(wb.Worksheets.Item("Acct Cov-Div Source"), Excel.Worksheet)

            'Loop Sales Grid National
            For Each row As DataGridViewRow In dgvSales.Rows
                If Not row.IsNewRow Then

                    With wsntl
                        'Region
                        .Range("A" & rownumber.ToString()).Value = row.Cells("Region").Value.ToString

                        'Province
                        .Range("B" & rownumber.ToString()).Value = row.Cells("Province").Value.ToString

                        'Channel
                        .Range("C" & rownumber.ToString()).Value = row.Cells("Channel").Value.ToString

                        'SubChannel
                        .Range("D" & rownumber.ToString()).Value = row.Cells("SubChannel").Value.ToString

                        'Outlet
                        .Range("E" & rownumber.ToString()).Value = row.Cells("Outlet").Value.ToString

                        Dim lytotalstr As String = row.Cells("LYTotal").Value.ToString
                        'TYYTD
                        .Range("F" & rownumber.ToString()).Value = IIf(lytotalstr = "1", "", row.Cells("TYYTD").Value.ToString)

                        'LYYTD
                        .Range("G" & rownumber.ToString()).Value = IIf(lytotalstr = "1", "", row.Cells("LYYTD").Value.ToString)

                        'LYTotal
                        .Range("H" & rownumber.ToString()).Value = row.Cells("LYTotal").Value.ToString
                    End With
                    rownumber = rownumber + 1
                End If
            Next

            'Loop Sales Grid Division
            rownumberntl = rownumber
            rownumber = 2
            For Each row As DataGridViewRow In dgvSales2.Rows
                If Not row.IsNewRow Then

                    With wscovdiv
                        'Division
                        .Range("A" & rownumber.ToString()).Value = row.Cells("Division").Value.ToString

                        'Region
                        .Range("B" & rownumber.ToString()).Value = row.Cells("Region").Value.ToString

                        'Province
                        .Range("C" & rownumber.ToString()).Value = row.Cells("Province").Value.ToString

                        'Channel
                        .Range("D" & rownumber.ToString()).Value = row.Cells("Channel").Value.ToString

                        'SubChannel
                        .Range("E" & rownumber.ToString()).Value = row.Cells("SubChannel").Value.ToString

                        'Outlet
                        .Range("F" & rownumber.ToString()).Value = row.Cells("Outlet").Value.ToString

                        'TYYTD
                        Dim lytotalstr As String = row.Cells("LYTotal").Value.ToString
                        .Range("G" & rownumber.ToString()).Value = IIf(lytotalstr = "1", "", row.Cells("TYYTD").Value.ToString)

                        'LYYTD
                        .Range("H" & rownumber.ToString()).Value = IIf(lytotalstr = "1", "", row.Cells("LYYTD").Value.ToString)

                        'LYTotal
                        .Range("I" & rownumber.ToString()).Value = row.Cells("LYTotal").Value.ToString
                    End With
                    rownumber = rownumber + 1
                End If
            Next

            'Save Sales Transaction Date To Excel to Cell A3
            'SalesTransDate = DateTime.Now.ToString("MMM", New CultureInfo("en-US")) 
            ws.Range("A4").Value = MonthName
            wsdiv.Range("A4").Value = MonthName
            'Refresh PivotTable
            'pivot.SourceData = "SheetName!R1C1:R18C18"
            ws.PivotTables("PivotTable4").SourceData = "Acct Cov-Natl Source!R1C1:R" + (rownumberntl - 1).ToString.Trim + "C8"
            wsdiv.PivotTables("PivotTable5").SourceData = "Acct Cov-Div Source!R1C1:R" + (rownumber - 1).ToString.Trim + "C9"
            ws.PivotTables("PivotTable4").RefreshTable()
            wsdiv.PivotTables("PivotTable5").RefreshTable()
            xl.DisplayAlerts = False
            wb.SaveAs(salesinvupdout)
            wb.Close()
            xl.Quit()
            'Marshal.ReleaseComObject(wb)
            'Marshal.ReleaseComObject(xl)
            xl = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "frmAccountCoverage.GenerateSalesTrend module")
            KillExcellApp()
        Finally
        End Try
    End Sub

    Private Sub RefreshTable()
        RemoteDataSet.Tables.Remove("IntegratedSales")
        RemoteDataSet.Tables.Add("IntegratedSales")
    End Sub

End Class