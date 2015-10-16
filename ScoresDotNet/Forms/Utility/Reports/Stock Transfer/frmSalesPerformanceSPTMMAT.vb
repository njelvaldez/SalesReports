Imports System.Data.SqlClient
Imports Microsoft
Imports Microsoft.Office.Interop
Imports System.Configuration
Imports System.Globalization
Imports System.Runtime.InteropServices
Public Class frmSalesPerformanceSPTMMAT
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
        txtTemplate.Text = salesinvupdpath + "Sales Performance TM Specialist MAT.xlsx"
        txtOutput.Text = salesinvupdpath + "Sales Performance TM Specialist MAT " + currentdate + ".xlsx"
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmSalesPerformanceSPTM_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
                BusinessObject.Sub_Update(ServerPath2, "Util_SalesPerformanceSPTMProcess", CommandType.StoredProcedure, Params)
            End If
            Dim Params0(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params0(0) = salescycledate
            'Display SP
            BusinessObject.Sub_Show(ServerPath2, "Util_SalesPerformanceSPMATSelect", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params0)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            gbSales.Text = "Total No Of Records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString
            'Display TM
            Dim Paramstm(0) As SqlParameter
            Dim salescycledatetm As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledatetm.Direction = ParameterDirection.Input : salescycledatetm.Value = dtpMonth.Text : Paramstm(0) = salescycledatetm
            BusinessObject.Sub_Show(ServerPath2, "Util_SalesPerformanceTMMATSelect", CommandType.StoredProcedure, RemoteDataSet2, "IntegratedSales", Paramstm)
            dgvsales2.DataSource = RemoteDataSet2.Tables("IntegratedSales")
            gbsales2.Text = "Total No Of Records : " + RemoteDataSet2.Tables("IntegratedSales").Rows.Count.ToString
            LogHelper.InsertLog("frmSalesPerformanceSPTMMAT.ShowInvoice.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmSalesPerformanceSPTMMAT.ShowInvoice.Error: " & ex.Message)
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
            wssp = CType(wb.Worksheets.Item("Specialist Performance"), Excel.Worksheet)
            wstm = CType(wb.Worksheets.Item("TM Performance"), Excel.Worksheet)
            wsspsource = CType(wb.Worksheets.Item("Source-Sp"), Excel.Worksheet)
            wstmsource = CType(wb.Worksheets.Item("Source-TM"), Excel.Worksheet)
            rangesp = wsspsource.Range("A2", "U" + reccountsp.ToString().Trim)
            rangetm = wstmsource.Range("A2", "T" + reccounttm.ToString().Trim)

            Dim strArrsp(reccountsp, 21) As Object
            Dim strArrtm(reccounttm, 21) As Object
            'pOPULATE sp sOURCE
            For Each dr As DataRow In dtsp.Rows
                'SPdivision
                strArrsp(rownumbersp, 0) = dr("SPdivision").ToString
                'principal, 
                strArrsp(rownumbersp, 1) = dr("principal").ToString
                'itemdesc, 
                strArrsp(rownumbersp, 2) = dr("itemdesc").ToString
                'productline, 
                strArrsp(rownumbersp, 3) = dr("productline").ToString
                'AREANAME, 
                strArrsp(rownumbersp, 4) = dr("AREANAME").ToString
                'mrname, 
                strArrsp(rownumbersp, 5) = dr("mrname").ToString
                'cmonth, 
                strArrsp(rownumbersp, 6) = dr("cmonth").ToString
                'VacantSP, 
                strArrsp(rownumbersp, 7) = dr("VacantSP").ToString
                'TYMDI,
                strArrsp(rownumbersp, 8) = dr("TYMDI").ToString
                'LYMDI,
                strArrsp(rownumbersp, 9) = dr("LYMDI").ToString
                'TYInhouse, 
                strArrsp(rownumbersp, 10) = dr("TYInhouse").ToString
                'LYInhouse, 
                strArrsp(rownumbersp, 11) = dr("LYInhouse").ToString
                'TYMercury, 
                strArrsp(rownumbersp, 12) = dr("TYMercury").ToString
                'LYMercury, 
                strArrsp(rownumbersp, 13) = dr("LYMercury").ToString
                'TYSubdist, 
                strArrsp(rownumbersp, 14) = dr("TYSubdist").ToString
                'LYSubdist, 
                strArrsp(rownumbersp, 15) = dr("LYSubdist").ToString
                'TYSales, 
                strArrsp(rownumbersp, 16) = dr("TYSales").ToString
                'LYSales, 
                strArrsp(rownumbersp, 17) = dr("LYSales").ToString

                'TYTarget,
                strArrsp(rownumbersp, 18) = dr("TYTarget")
                'LYTarget, 
                strArrsp(rownumbersp, 19) = dr("LYTarget")
                rownumbersp = rownumbersp + 1
            Next
            'Populate TM Source
            For Each dr As DataRow In dttm.Rows
                'TMdivision
                strArrtm(rownumbertm, 0) = dr("TMdivision").ToString
                'principal, 
                strArrtm(rownumbertm, 1) = dr("principal").ToString
                'itemdesc, 
                strArrtm(rownumbertm, 2) = dr("itemdesc").ToString
                'productline, 
                strArrtm(rownumbertm, 3) = dr("productline").ToString
                'DISTRICTNAME, 
                strArrtm(rownumbertm, 4) = dr("DISTRICTNAME").ToString
                'supname, 
                strArrtm(rownumbertm, 5) = dr("supname").ToString
                'cmonth, 
                strArrtm(rownumbertm, 6) = dr("cmonth").ToString
                'VacantTM, 
                strArrtm(rownumbertm, 7) = dr("VacantTM").ToString
                'TYMDI,
                strArrtm(rownumbertm, 8) = dr("TYMDI").ToString
                'LYMDI,
                strArrtm(rownumbertm, 9) = dr("LYMDI").ToString
                'TYInhouse, 
                strArrtm(rownumbertm, 10) = dr("TYInhouse").ToString
                'LYInhouse, 
                strArrtm(rownumbertm, 11) = dr("LYInhouse").ToString
                'TYMercury, 
                strArrtm(rownumbertm, 12) = dr("TYMercury").ToString
                'LYMercury, 
                strArrtm(rownumbertm, 13) = dr("LYMercury").ToString
                'TYSubdist, 
                strArrtm(rownumbertm, 14) = dr("TYSubdist").ToString
                'LYSubdist, 
                strArrtm(rownumbertm, 15) = dr("LYSubdist").ToString
                'TYSales, 
                strArrtm(rownumbertm, 16) = dr("TYSales").ToString
                'LYSales, 
                strArrtm(rownumbertm, 17) = dr("LYSales").ToString

                'TYTarget,
                strArrtm(rownumbertm, 18) = dr("TYTarget")
                'LYTarget, 
                strArrtm(rownumbertm, 19) = dr("LYTarget")
                rownumbertm = rownumbertm + 1
            Next

            rangesp.Value2 = strArrsp
            rangetm.Value2 = strArrtm
            'Save Sales Transaction Date To Excel to Cell A3
            'Jan - May 2014 vs. Last year
            Dim monthname As String = dtpMonth.Value.ToString("MMMM", New CultureInfo("en-US"))
            wssp.Range("A3").Value = "January - " + monthname + " 2014 vs. Last year"
            wstm.Range("A3").Value = "January - " + monthname + " 2014 vs. Last year"
            'Refresh PivotTable3
            'pivot.SourceData = "SheetName!R1C1:R18C18"
            wssp.PivotTables("PivotTableSP").SourceData = "Source-Sp!R1C1:R" + (rownumbersp + 1).ToString.Trim + "C21"
            wssp.PivotTables("PivotTableSP").RefreshTable()

            wstm.PivotTables("PivotTableTM").SourceData = "Source-TM!R1C1:R" + (rownumbertm + 1).ToString.Trim + "C20"
            wstm.PivotTables("PivotTableTM").RefreshTable()

            xl.DisplayAlerts = False
            wb.SaveAs(salesinvupdout)
            wb.Close()
            xl.Quit()
            xl = Nothing
            MessageBox.Show("Sales Performance Specialist and TM MAT Report generation is complete!")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "frmSalesPerformanceSPTMMAT.GenerateSalesPerformance module")
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