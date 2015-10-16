Imports System.Data.SqlClient
Imports Microsoft
Imports Microsoft.Office.Interop
Imports System.Configuration
Imports System.Globalization
Imports System.Runtime.InteropServices
Public Class frmSalesPerformanceSPTMTradeMonth
    Private salesinvupdpath As String = System.Configuration.ConfigurationSettings.AppSettings.Item("SalesPerformancePath")
    Private SalesTransDate As String = ""
    Private RemoteDataSet As New DataSet
    Private RemoteDataSet2 As New DataSet
    Private Sub SetDate()
        Dim currentdate As String
        Dim fromdate As String
        fromdate = "1/1/" + DateTime.Now.Date.Year.ToString()
        currentdate = DateTime.Now.Date.Month.ToString() + "/1/" + DateTime.Now.Date.Year.ToString()
        dtpMonth.Text = fromdate
        dtptyto.Text = currentdate
    End Sub

    Private Sub SetPath()
        Dim currentdate As String
        Dim format As String = "MMM d yyyy"
        currentdate = DateTime.Now.ToString("MMM", New CultureInfo("en-US")) + " 1 - " + DateTime.Now.Date.Day.ToString() + " " + DateTime.Now.Date.Year.ToString()
        txtTemplate.Text = salesinvupdpath + "Sales Performance TM SP Monthly.xlsx"
        txtOutput.Text = salesinvupdpath + "Sales Performance TM SP Monthly " + currentdate + ".xlsx"
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmSalesPerformanceSPTMTradeMonth_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RemoteDataSet.Tables.Add("IntegratedSales")
        RemoteDataSet2.Tables.Add("IntegratedSales")
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

            commdate1 = dtpMonth.Text.ToString().Trim()
            commdate2 = dtptyto.Text.ToString().Trim()
            commdately1 = dtplyfrom.Text.ToString().Trim()
            commdately2 = dtplyto.Text.ToString().Trim()

            Dim Params(3) As SqlParameter
            Dim commissiondate1 As New SqlParameter("@commissiondate1", SqlDbType.DateTime, 10) : commissiondate1.Direction = ParameterDirection.Input : commissiondate1.Value = commdate1 : Params(0) = commissiondate1
            Dim commissiondate2 As New SqlParameter("@commissiondate2", SqlDbType.DateTime, 10) : commissiondate2.Direction = ParameterDirection.Input : commissiondate2.Value = commdate2 : Params(1) = commissiondate2
            Dim commissiondately1 As New SqlParameter("@commissiondately1", SqlDbType.DateTime, 10) : commissiondately1.Direction = ParameterDirection.Input : commissiondately1.Value = commdately1 : Params(2) = commissiondately1
            Dim commissiondately2 As New SqlParameter("@commissiondately2", SqlDbType.DateTime, 10) : commissiondately2.Direction = ParameterDirection.Input : commissiondately2.Value = commdately2 : Params(3) = commissiondately2

            'BusinessObject.Sub_Show(ServerPath2, "Util_SalesTrend_StockTransfer", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            If Not generateonly Then
                BusinessObject.Sub_Update(ServerPath2, "Util_SalesPerformanceSPTMTradeMonthProcess", CommandType.StoredProcedure, Params)
            End If
            Dim Params0(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params0(0) = salescycledate
            'Display SP
            BusinessObject.Sub_Show(ServerPath2, "Util_SalesPerformanceSPTMTradeMonthSelectSP", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params0)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            gbSales.Text = "Total No Of Records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString
            'Display TM
            Dim Paramstm(0) As SqlParameter
            Dim salescycledatetm As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledatetm.Direction = ParameterDirection.Input : salescycledatetm.Value = dtpMonth.Text : Paramstm(0) = salescycledatetm
            BusinessObject.Sub_Show(ServerPath2, "Util_SalesPerformanceSPTMTradeMonthSelectTM", CommandType.StoredProcedure, RemoteDataSet2, "IntegratedSales", Paramstm)
            dgvsales2.DataSource = RemoteDataSet2.Tables("IntegratedSales")
            gbsales2.Text = "Total No Of Records : " + RemoteDataSet2.Tables("IntegratedSales").Rows.Count.ToString
            LogHelper.InsertLog("frmSalesPerformanceSPTMTradeMonth.ShowInvoice.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmSalesPerformanceSPTMTradeMonth.ShowInvoice.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub GenerateSalesPerformance(ByVal strFileName As String)
        Dim xl As New Excel.Application
        Dim wb As Excel.Workbook
        Dim wssp As Excel.Worksheet
        Dim wstm As Excel.Worksheet
        Dim wsspsource As Excel.Worksheet
        Dim wstmsource As Excel.Worksheet
        Dim rangesp As Excel.Range
        Dim rangetm As Excel.Range
        Dim rownumbersp As Integer = 0
        Dim rownumbertm As Integer = 0
        Dim salesinvupdout As String = txtOutput.Text.ToString
        Dim salesinvupd As String = txtTemplate.Text.ToString
        Dim reccountsp As Integer
        Dim reccounttm As Integer
        Try
            wb = xl.Workbooks.Open(strFileName)
            Dim dtsp As New DataTable
            Dim dttm As New DataTable
            dtsp = (DirectCast(dgvSales.DataSource, DataTable))
            dttm = (DirectCast(dgvsales2.DataSource, DataTable))
            reccountsp = dtsp.Rows.Count + 1
            reccounttm = dttm.Rows.Count + 1
            wssp = CType(wb.Worksheets.Item("SP Performance"), Excel.Worksheet)
            wstm = CType(wb.Worksheets.Item("TM Performance"), Excel.Worksheet)
            wsspsource = CType(wb.Worksheets.Item("SourceSP"), Excel.Worksheet)
            wstmsource = CType(wb.Worksheets.Item("SourceTM"), Excel.Worksheet)
            rangesp = wsspsource.Range("A2", "U" + reccountsp.ToString().Trim)
            rangetm = wstmsource.Range("A2", "T" + reccounttm.ToString().Trim)

            Dim strArrsp(reccountsp, 21) As Object
            Dim strArrtm(reccounttm, 21) As Object
            'Populate SP Source
            For Each dr As DataRow In dtsp.Rows
                strArrsp(rownumbersp, 0) = dr("division").ToString
                strArrsp(rownumbersp, 1) = dr("principal").ToString
                strArrsp(rownumbersp, 2) = dr("itemdesc").ToString
                strArrsp(rownumbersp, 3) = dr("productline").ToString
                strArrsp(rownumbersp, 4) = dr("AREANAME").ToString
                strArrsp(rownumbersp, 5) = dr("mrname").ToString
                strArrsp(rownumbersp, 6) = dr("cmonth").ToString
                strArrsp(rownumbersp, 7) = dr("VacantSP").ToString
                strArrsp(rownumbersp, 8) = dr("TYMDI").ToString
                strArrsp(rownumbersp, 9) = dr("LYMDI").ToString
                strArrsp(rownumbersp, 10) = dr("TYInhouse").ToString
                strArrsp(rownumbersp, 11) = dr("LYInhouse").ToString
                strArrsp(rownumbersp, 12) = dr("TYMercury").ToString
                strArrsp(rownumbersp, 13) = dr("LYMercury").ToString
                strArrsp(rownumbersp, 14) = dr("TYSubdist").ToString
                strArrsp(rownumbersp, 15) = dr("LYSubdist").ToString
                strArrsp(rownumbersp, 16) = dr("TYSales").ToString
                strArrsp(rownumbersp, 17) = dr("LYSales").ToString
                strArrsp(rownumbersp, 18) = dr("TYTarget")
                strArrsp(rownumbersp, 19) = dr("LYTarget")
                rownumbersp = rownumbersp + 1
            Next
            'Populate TM Source
            For Each dr As DataRow In dttm.Rows
                strArrtm(rownumbertm, 0) = dr("division").ToString
                strArrtm(rownumbertm, 1) = dr("principal").ToString
                strArrtm(rownumbertm, 2) = dr("itemdesc").ToString
                strArrtm(rownumbertm, 3) = dr("productline").ToString
                strArrtm(rownumbertm, 4) = dr("DISTRICTNAME").ToString
                strArrtm(rownumbertm, 5) = dr("supname").ToString
                strArrtm(rownumbertm, 6) = dr("cmonth").ToString
                strArrtm(rownumbertm, 7) = dr("VacantTM").ToString
                strArrtm(rownumbertm, 8) = dr("TYMDI").ToString
                strArrtm(rownumbertm, 9) = dr("LYMDI").ToString
                strArrtm(rownumbertm, 10) = dr("TYInhouse").ToString
                strArrtm(rownumbertm, 11) = dr("LYInhouse").ToString
                strArrtm(rownumbertm, 12) = dr("TYMercury").ToString
                strArrtm(rownumbertm, 13) = dr("LYMercury").ToString
                strArrtm(rownumbertm, 14) = dr("TYSubdist").ToString
                strArrtm(rownumbertm, 15) = dr("LYSubdist").ToString
                strArrtm(rownumbertm, 16) = dr("TYSales").ToString
                strArrtm(rownumbertm, 17) = dr("LYSales").ToString
                strArrtm(rownumbertm, 18) = dr("TYTarget")
                strArrtm(rownumbertm, 19) = dr("LYTarget")
                rownumbertm = rownumbertm + 1
            Next

            rangesp.Value2 = strArrsp
            rangetm.Value2 = strArrtm
            'Save Sales Transaction Date To Excel to Cell A3
            'Jan - May 2014 vs. Last year
            Dim monthname As String = dtpMonth.Value.ToString("MMMM", New CultureInfo("en-US"))
            wssp.Range("A3").Value = "January - " + monthname + " " + dtpMonth.Value.Year.ToString()
            wstm.Range("A3").Value = "January - " + monthname + " " + dtpMonth.Value.Year.ToString()
            'Refresh PivotTable3
            'pivot.SourceData = "SheetName!R1C1:R18C18"
            wssp.PivotTables("PivotTableSP").SourceData = "SourceSP!R1C1:R" + (rownumbersp + 1).ToString.Trim + "C21"
            wssp.PivotTables("PivotTableSP").RefreshTable()

            wstm.PivotTables("PivotTableTM").SourceData = "SourceTM!R1C1:R" + (rownumbertm + 1).ToString.Trim + "C20"
            wstm.PivotTables("PivotTableTM").RefreshTable()

            xl.DisplayAlerts = False
            wb.SaveAs(salesinvupdout)
            wb.Close()
            xl.Quit()
            xl = Nothing
            MessageBox.Show("Sales Performance Specialist and TM MAT Report generation is complete!")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "frmSalesPerformanceSPTMTradeMonth.GenerateSalesPerformance module")
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

    Private Sub dtpMonth_ValueChanged(sender As Object, e As EventArgs) Handles dtpMonth.ValueChanged
        Dim iyear As Integer = 0
        iyear = dtpMonth.Value.Year - 1
        If iyear > 0 Then
            dtplyfrom.Text = dtpMonth.Value.Month.ToString + "/" + dtpMonth.Value.Day.ToString + "/" + Convert.ToString(iyear)
        End If
    End Sub

    Private Sub dtpmonthtyto_ValueChanged(sender As Object, e As EventArgs) Handles dtptyto.ValueChanged
        Dim iyear As Integer = 0
        iyear = dtptyto.Value.Year - 1
        If iyear > 0 Then
            dtplyto.Text = dtptyto.Value.Month.ToString + "/" + dtptyto.Value.Day.ToString + "/" + Convert.ToString(iyear)
        End If
    End Sub
End Class