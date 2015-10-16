Imports System.Data.SqlClient
Imports Microsoft
Imports Microsoft.Office.Interop
Imports System.Configuration
Imports System.Globalization
Imports System.Runtime.InteropServices
Public Class frmSalesPerformanceSPTMTrade
    Private salesinvupdpath As String = System.Configuration.ConfigurationSettings.AppSettings.Item("SalesPerformancePath")
    Private SalesTransDate As String = ""
    Private RemoteDataSet As New DataSet
    Private Sub SetDate()
        Dim currentdate As String
        currentdate = dtpMonth.Value.Month.ToString + "/1/" + dtpMonth.Value.Year.ToString
        dtpMonth.Text = currentdate
    End Sub

    Private Sub SetPath()
        Dim currentdate As String
        Dim format As String = "MMM d yyyy"
        currentdate = DateTime.Now.ToString("MMM", New CultureInfo("en-US")) + " 1 - " + DateTime.Now.Date.Day.ToString() + " " + DateTime.Now.Date.Year.ToString()
        txtTemplate.Text = salesinvupdpath + "Sales Performance TM SP Trade.xlsx"
        txtOutput.Text = salesinvupdpath + "Sales Performance TM SP Trade " + currentdate + ".xlsx"
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmSalesPerformanceSPTMTrade_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RemoteDataSet.Tables.Add("IntegratedSales")
        SetDate()
        SetPath()
    End Sub

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        Dim salesinvupdfile As String = txtTemplate.Text.ToString
        'SetDate()
        Me.Cursor = Cursors.WaitCursor
        ShowInvoice(False)
        'this is faster now
        GenerateSalesPerformance(salesinvupdfile)
        Me.Cursor = Cursors.Default
        KillExcellApp()
    End Sub

    Private Sub ShowInvoice(generateonly As Boolean)
        Try
            If RemoteDataSet.Tables("IntegratedSales").Rows.Count > 0 Then RemoteDataSet.Tables("IntegratedSales").Clear()
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim commdate1 As DateTime
            Dim commdate2 As DateTime
            Dim commdately1 As DateTime
            Dim commdately2 As DateTime
            Dim lastyear As String = (dtpMonth.Value.Year - 1).ToString()
            Dim thisyear As String = (dtpMonth.Value.Year).ToString()

            commdate1 = "1/1/" + thisyear
            commdate2 = dtpMonth.Text.ToString().Trim()
            commdately1 = "1/1/" + lastyear
            commdately2 = dtpMonth.Value.Month.ToString.Trim() + "/" + dtpMonth.Value.Day.ToString.Trim() + "/" + lastyear

            Dim Params(3) As SqlParameter
            Dim commissiondate1 As New SqlParameter("@commissiondate1", SqlDbType.DateTime, 10) : commissiondate1.Direction = ParameterDirection.Input : commissiondate1.Value = commdate1 : Params(0) = commissiondate1
            Dim commissiondate2 As New SqlParameter("@commissiondate2", SqlDbType.DateTime, 10) : commissiondate2.Direction = ParameterDirection.Input : commissiondate2.Value = commdate2 : Params(1) = commissiondate2
            Dim commissiondately1 As New SqlParameter("@commissiondately1", SqlDbType.DateTime, 10) : commissiondately1.Direction = ParameterDirection.Input : commissiondately1.Value = commdately1 : Params(2) = commissiondately1
            Dim commissiondately2 As New SqlParameter("@commissiondately2", SqlDbType.DateTime, 10) : commissiondately2.Direction = ParameterDirection.Input : commissiondately2.Value = commdately2 : Params(3) = commissiondately2

            'Display SP
            BusinessObject.Sub_Show(ServerPath2, "Util_SalesPerformanceSPTMTradeSelect", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            gbSales.Text = "Total No Of Records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString
            LogHelper.InsertLog("frmSalesPerformanceSPTMTrade.ShowInvoice.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmSalesPerformanceSPTMTrade.ShowInvoice.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub GenerateSalesPerformance(ByVal strFileName As String)
        Dim xl As New Excel.Application
        Dim wb As Excel.Workbook
        Dim wssp As Excel.Worksheet
        Dim wstm As Excel.Worksheet
        Dim wsspsource As Excel.Worksheet
        Dim rangesp As Excel.Range
        Dim rownumbersp As Integer = 0
        Dim salesinvupdout As String = txtOutput.Text.ToString
        Dim salesinvupd As String = txtTemplate.Text.ToString
        Dim reccountsp As Integer
        Try
            wb = xl.Workbooks.Open(strFileName)
            Dim dtsp As New DataTable
            dtsp = (DirectCast(dgvSales.DataSource, DataTable))
            reccountsp = dtsp.Rows.Count + 1
            wssp = CType(wb.Worksheets.Item("Specialist Performance"), Excel.Worksheet)
            wstm = CType(wb.Worksheets.Item("TM Performance"), Excel.Worksheet)
            wsspsource = CType(wb.Worksheets.Item("Source"), Excel.Worksheet)
            rangesp = wsspsource.Range("A2", "K" + reccountsp.ToString().Trim)

            Dim strArrsp(reccountsp, 11) As Object
            For Each dr As DataRow In dtsp.Rows
                'division
                strArrsp(rownumbersp, 0) = dr("division").ToString
                'supname, 
                strArrsp(rownumbersp, 1) = dr("supname").ToString
                'mrname, 
                strArrsp(rownumbersp, 2) = dr("mrname").ToString
                'Product, 
                strArrsp(rownumbersp, 3) = dr("Product").ToString
                'productline, 
                strArrsp(rownumbersp, 4) = dr("productline").ToString
                'Month, 
                strArrsp(rownumbersp, 5) = dr("Month").ToString
                'TYSalesQty, 
                strArrsp(rownumbersp, 6) = dr("TYSalesQty").ToString
                'TYTargetQty, 
                strArrsp(rownumbersp, 7) = dr("TYTargetQty").ToString
                'TYSalesAmount,
                strArrsp(rownumbersp, 8) = dr("TYSalesAmount").ToString
                'TYTargetAmount,
                strArrsp(rownumbersp, 9) = dr("TYTargetAmount").ToString
                'noofmos, 
                strArrsp(rownumbersp, 10) = dr("noofmos").ToString
                rownumbersp = rownumbersp + 1
            Next
            rangesp.Value2 = strArrsp
            'Save Sales Transaction Date To Excel to Cell A3
            'Jan - May 2014 vs. Last year
            Dim monthname As String = dtpMonth.Value.ToString("MMMM", New CultureInfo("en-US"))
            wssp.Range("A3").Value = "January - " + monthname + dtpMonth.Value.Year.ToString
            wstm.Range("A3").Value = "January - " + monthname + dtpMonth.Value.Year.ToString
            'Refresh PivotTable3
            'pivot.SourceData = "SheetName!R1C1:R18C18"
            wssp.PivotTables("PivotTableSP").SourceData = "Source!R1C1:R" + (rownumbersp + 1).ToString.Trim + "C11"
            wssp.PivotTables("PivotTableSP").RefreshTable()

            wstm.PivotTables("PivotTableTM").SourceData = "Source!R1C1:R" + (rownumbersp + 1).ToString.Trim + "C11"
            wstm.PivotTables("PivotTableTM").RefreshTable()

            xl.DisplayAlerts = False
            wb.SaveAs(salesinvupdout)
            wb.Close()
            xl.Quit()
            xl = Nothing
            MessageBox.Show("Sales Performance Specialists/TM Trade Report generation is complete!")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "frmSalesPerformanceSPTMTrade.GenerateSalesPerformance module")
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
        GenerateSalesPerformance(salesinvupdfile)
        Me.Cursor = Cursors.Default
        KillExcellApp()
    End Sub
End Class