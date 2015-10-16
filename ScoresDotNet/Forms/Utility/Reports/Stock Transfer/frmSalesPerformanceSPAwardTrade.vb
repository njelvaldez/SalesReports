Imports System.Data.SqlClient
Imports Microsoft
Imports Microsoft.Office.Interop
Imports System.Configuration
Imports System.Globalization
Imports System.Runtime.InteropServices
Public Class frmSalesPerformanceSPAwardTrade
    Private salesinvupdpath As String = System.Configuration.ConfigurationSettings.AppSettings.Item("SalesPerformancePath")
    Private SalesTransDate As String = ""
    Private RemoteDataSet As New DataSet
    Private Sub SetDate()
        Dim currentdate As String
        Dim fromdate As String
        fromdate = "1/1/" + DateTime.Now.Date.Year.ToString()
        currentdate = DateTime.Now.Date.Month.ToString() + "/1/" + DateTime.Now.Date.Year.ToString()
        dtpMonth.Text = fromdate
        dtpMonthTo.Text = currentdate
    End Sub

    Private Sub SetPath()
        Dim currentdate As String
        Dim format As String = "MMM d yyyy"
        currentdate = DateTime.Now.ToString("MMM", New CultureInfo("en-US")) + " 1 - " + DateTime.Now.Date.Day.ToString() + " " + DateTime.Now.Date.Year.ToString()
        txtTemplate.Text = salesinvupdpath + "Sales Performance Specialist.xls"
        txtOutput.Text = salesinvupdpath + "Sales Performance Trade Specialist " + currentdate + ".xls"
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmSalesPerformanceSPAward_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RemoteDataSet.Tables.Add("IntegratedSales")
        SetDate()
        SetPath()
    End Sub

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        Dim salesinvupdfile As String = txtTemplate.Text.ToString
        'SetDate()
        Me.Cursor = Cursors.WaitCursor
        ShowInvoice(False)
        'this is now faster
        GenerateSales(salesinvupdfile)
        Me.Cursor = Cursors.Default
        KillExcellApp()
    End Sub

    Private Sub ShowInvoice(generateonly As Boolean)
        Try
            If RemoteDataSet.Tables("IntegratedSales").Rows.Count > 0 Then RemoteDataSet.Tables("IntegratedSales").Clear()
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim commdate1 As DateTime
            Dim commdate2 As DateTime

            commdate1 = dtpMonth.Text.ToString().Trim()
            commdate2 = dtpMonthTo.Text.ToString().Trim()

            Dim Params(1) As SqlParameter
            Dim commissiondate1 As New SqlParameter("@commissiondate1", SqlDbType.DateTime, 10) : commissiondate1.Direction = ParameterDirection.Input : commissiondate1.Value = commdate1 : Params(0) = commissiondate1
            Dim commissiondate2 As New SqlParameter("@commissiondate2", SqlDbType.DateTime, 10) : commissiondate2.Direction = ParameterDirection.Input : commissiondate2.Value = commdate2 : Params(1) = commissiondate2
            BusinessObject.Sub_Show(ServerPath2, "Util_SalesPerformanceSPAwardTrade", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            gbSales.Text = "Total No Of Records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString
            LogHelper.InsertLog("frmSalesPerformanceSPAwardTrade.ShowInvoice.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmSalesPerformanceSPAwardTrade.ShowInvoice.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub GenerateSales(ByVal strFileName As String)
        Dim xl As New Excel.Application
        Dim wb As Excel.Workbook
        Dim ws As Excel.Worksheet
        Dim wssalper As Excel.Worksheet
        Dim wssalestrend As Excel.Worksheet
        Dim range As Excel.Range
        Dim rangepivot As Excel.Range
        Dim rangesalper As Excel.Range
        Dim rownumber As Integer = 0
        Dim salesinvupdout As String = txtOutput.Text.ToString
        Dim salesinvupd As String = txtTemplate.Text.ToString
        Dim reccount As Integer
        Try
            wb = xl.Workbooks.Open(strFileName)
            Dim dt As New DataTable
            dt = (DirectCast(dgvSales.DataSource, DataTable))
            reccount = dt.Rows.Count + 1
            ws = CType(wb.Worksheets.Item("Pivot"), Excel.Worksheet)
            wssalper = CType(wb.Worksheets.Item("Sales Performance"), Excel.Worksheet)
            wssalestrend = CType(wb.Worksheets.Item("Source"), Excel.Worksheet)
            range = wssalestrend.Range("A2", "F" + reccount.ToString().Trim)
            rangepivot = ws.Range("A5", "E" + reccount.ToString().Trim)
            rangesalper = wssalper.Range("B7", "F" + reccount.ToString().Trim)

            Dim strArr(reccount, 5) As Object

            For Each dr As DataRow In dt.Rows
                'commissiondate, 
                strArr(rownumber, 0) = dr("commissiondate").ToString
                'division, 
                'strArr(rownumber, 1) = dr("division").ToString
                'mrname, 
                strArr(rownumber, 2) = dr("mrname").ToString
                'originalsales, 
                strArr(rownumber, 3) = dr("originalsales").ToString
                'originaltarget, 
                strArr(rownumber, 4) = dr("originaltarget").ToString
                'NoOfMonths, 
                strArr(rownumber, 5) = dr("NoOfMonths").ToString
                rownumber = rownumber + 1
            Next
            range.Value2 = strArr
            'Save Sales Transaction Date To Excel to Cell A3
            Dim monthnamefrom As String = dtpMonth.Value.ToString("MMMM", New CultureInfo("en-US"))
            Dim monthnameto As String = dtpMonthTo.Value.ToString("MMMM", New CultureInfo("en-US"))
            wssalper.Range("A3").Value = monthnamefrom + " " + dtpMonth.Value.Year.ToString() + " - " + _
                                         monthnameto + " " + dtpMonthTo.Value.Year.ToString()
            'Refresh PivotTable3
            'pivot.SourceData = "SheetName!R1C1:R18C18"
            ws.PivotTables("PivotTable1").SourceData = "Source!R1C1:R" + (rownumber + 1).ToString.Trim + "C6"
            ws.PivotTables("PivotTable1").RefreshTable()

            'Update Sales Performance Sheet
            rangepivot.Copy(rangesalper)
            rangesalper.Sort( _
                       Key1:=rangesalper.Columns(5), Order1:=Excel.XlSortOrder.xlDescending, _
                       Key2:=rangesalper.Columns(4), Order2:=Excel.XlSortOrder.xlDescending, _
                       Orientation:=Excel.XlSortOrientation.xlSortColumns, _
                       Header:=Excel.XlYesNoGuess.xlNo, _
                       SortMethod:=Excel.XlSortMethod.xlPinYin, _
                       DataOption1:=Excel.XlSortDataOption.xlSortNormal, _
                       DataOption2:=Excel.XlSortDataOption.xlSortNormal)

            xl.DisplayAlerts = False
            wb.SaveAs(salesinvupdout)
            wb.Close()
            xl.Quit()
            xl = Nothing
            MessageBox.Show("Sales Performance Trade Specialist Award Report generation is complete!")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "frmSalesPerformanceSPAwardTrade.GenerateSalesTrend module")
        Finally
        End Try
    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbSales.Enter

    End Sub

    Private Sub btnGenerateOnly_Click(sender As Object, e As EventArgs) Handles btnGenerateOnly.Click
        Dim salesinvupdfile As String = txtTemplate.Text.ToString
        'SetDate()
        Me.Cursor = Cursors.WaitCursor
        ShowInvoice(True)
        'this is now faster
        GenerateSales(salesinvupdfile)
        Me.Cursor = Cursors.Default
        KillExcellApp()
    End Sub
End Class