﻿Imports System.Data.SqlClient
Imports Microsoft
Imports Microsoft.Office.Interop
Imports System.Configuration
Imports System.Globalization
Imports System.Runtime.InteropServices
Public Class frmSalesTrendStockTransfer2015
    Private salesinvupdpath As String = System.Configuration.ConfigurationSettings.AppSettings.Item("SalesTrendPathStockTransfer")
    Private SalesTransDate As String = ""
    Private RemoteDataSet As New DataSet
    Private n10k As Integer = 10000

    Private Sub SetDate()
        Dim currentdate As String
        Dim fromdate As String
        fromdate = "1/1/" + DateTime.Now.Date.Year.ToString()
        currentdate = DateTime.Now.Date.Month.ToString() + "/1/" + DateTime.Now.Date.Year.ToString()
        dtpMonth.Text = fromdate
        dtpmonthtyto.Text = currentdate
    End Sub

    Private Sub SetPath()
        Dim currentdate As String
        Dim format As String = "MMM d yyyy"
        currentdate = DateTime.Now.ToString("MMM", New CultureInfo("en-US")) + " 1 - " + DateTime.Now.Date.Day.ToString() + " " + DateTime.Now.Date.Year.ToString()
        txtTemplate.Text = salesinvupdpath + "Sales Trend Stock Transfer YTDv10.xlsx"
        txtOutput.Text = salesinvupdpath + "Sales Trend Stock Transfer YTDv10 " + currentdate + ".xlsx"
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmSalesTrendDirect_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
        GenerateSalesTrend(salesinvupdfile)
        Me.Cursor = Cursors.Default
        'MsgBox("Process is complete." + " Sales Trend File : " + txtOutput.Text.ToString + " is generated!")
        KillExcellApp()
    End Sub

    Private Sub ShowInvoice(generateonly As Boolean)
        Try
            If RemoteDataSet.Tables("IntegratedSales").Rows.Count > 0 Then RemoteDataSet.Tables("IntegratedSales").Clear()
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim commdate1 As DateTime
            Dim commdate2 As DateTime
            Dim lastyear As String = (dtpMonth.Value.Year - 1).ToString()
            Dim thisyear As String = (dtpMonth.Value.Year).ToString()

            commdate1 = dtpMonth.Text.ToString().Trim()
            commdate2 = dtpmonthtyto.Text.ToString().Trim()



            Dim Params(1) As SqlParameter
            Dim commissiondate1 As New SqlParameter("@commissiondate1", SqlDbType.DateTime, 10) : commissiondate1.Direction = ParameterDirection.Input : commissiondate1.Value = commdate1 : Params(0) = commissiondate1
            Dim commissiondate2 As New SqlParameter("@commissiondate2", SqlDbType.DateTime, 10) : commissiondate2.Direction = ParameterDirection.Input : commissiondate2.Value = commdate2 : Params(1) = commissiondate2

            'BusinessObject.Sub_Show(ServerPath2, "Util_SalesTrend_StockTransfer", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            If Not generateonly Then
                BusinessObject.Sub_Update(ServerPath2, "Util_SalesTrend_StockTransferProcessYTDVer10", CommandType.StoredProcedure, Params)
            End If
            BusinessObject.Sub_Show(ServerPath2, "Util_SalesTrend_StockTransferSelectYTDVer10", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales")
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            gbSales.Text = "Total No Of Records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString
            LogHelper.InsertLog("Util_SalesTrend_StockTransferSelectYTDVer10.ShowInvoice.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("Util_SalesTrend_StockTransferSelectYTDVer10.ShowInvoice.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub GenerateSalesTrend(ByVal strFileName As String)
        Dim xl As New Excel.Application
        Dim wb As Excel.Workbook
        Dim ws As Excel.Worksheet
        Dim wssalestrend As Excel.Worksheet
        Dim range As Excel.Range
        Dim rownumber As Integer = 0
        Dim counter10k As Integer = 1
        Dim salesinvupdout As String = txtOutput.Text.ToString
        Dim salesinvupd As String = txtTemplate.Text.ToString
        Dim reccount As Integer
        Try
            wb = xl.Workbooks.Open(strFileName)
            Dim dt As New DataTable
            dt = (DirectCast(dgvSales.DataSource, DataTable))
            reccount = dt.Rows.Count + 1
            ws = CType(wb.Worksheets.Item("Pivot Report"), Excel.Worksheet)
            wssalestrend = CType(wb.Worksheets.Item("Source"), Excel.Worksheet)
            range = wssalestrend.Range("A2", "Y" + GetRangeEnd(counter10k, reccount).ToString().Trim)

            Dim strArr(GetArraySize(counter10k, reccount), 25) As Object

            For Each dr As DataRow In dt.Rows
                'a.SpDivision [Segment]
                strArr(rownumber, 0) = dr("Segment").ToString
                'principal, 
                strArr(rownumber, 1) = dr("principal").ToString
                'a.itemdesc [Product]
                strArr(rownumber, 2) = dr("Product").ToString
                'productline, 
                strArr(rownumber, 3) = dr("Brand").ToString
                'DISTRICTNAME, 
                strArr(rownumber, 4) = dr("Team").ToString
                'supname, 
                strArr(rownumber, 5) = dr("TeamManager").ToString
                'AREANAME, 
                strArr(rownumber, 6) = dr("Territory").ToString
                'mrname,
                strArr(rownumber, 7) = dr("Specialist").ToString
                'region,
                strArr(rownumber, 8) = dr("SalesRegion").ToString
                'georegion, 
                strArr(rownumber, 9) = dr("GeographicalRegion").ToString
                'PROVINCE, 
                strArr(rownumber, 10) = dr("PROVINCE").ToString

                'brickname, 
                strArr(rownumber, 11) = dr("Brick").ToString
                'distributor, 
                strArr(rownumber, 12) = dr("distributor").ToString
                'channel, 
                strArr(rownumber, 13) = dr("channel").ToString
                'SUBCHANNEL, 
                strArr(rownumber, 14) = dr("SUBCHANNEL").ToString
                'customername, 
                strArr(rownumber, 15) = dr("Customer").ToString
                'datename(mm,commissiondate) [monthname], 
                strArr(rownumber, 16) = dr("month").ToString

                'TYQty,
                strArr(rownumber, 17) = dr("TYQty")
                'LYQTY, 
                strArr(rownumber, 18) = dr("LYQTY")
                'TYFree, 
                strArr(rownumber, 19) = dr("TYFree")
                'LYFree, 
                strArr(rownumber, 20) = dr("LYFree")
                'TYValue, 
                strArr(rownumber, 21) = dr("TYValue")
                'LYValue
                strArr(rownumber, 22) = dr("LYValue")
                'TYCMQty, 
                strArr(rownumber, 23) = dr("TYCMQty")
                'TYReturn
                strArr(rownumber, 24) = dr("TYCMValue")
                'array is zero base , lets subtract by 1
                If rownumber >= n10k - 1 Then
                    range.Value2 = strArr
                    counter10k = counter10k + 1
                    ReDim strArr(0, 0)
                    ReDim strArr(GetArraySize(counter10k, reccount), 25)
                    range = wssalestrend.Range("A" + (GetRangeStart(counter10k, reccount)).ToString().Trim(), "Y" + GetRangeEnd(counter10k, reccount).ToString().Trim)
                    rownumber = 0
                Else
                    rownumber = rownumber + 1
                End If
            Next
            range.Value2 = strArr
            'Save Sales Transaction Date To Excel to Cell A3
            'Jan - May 2015 vs. Last year
            Dim monthname As String = dtpmonthtyto.Value.ToString("MMMM", New CultureInfo("en-US"))
            ws.Range("A3").Value = "January - " + monthname + " " + dtpmonthtyto.Value.Year.ToString + " vs. Last year"
            'Refresh PivotTable3
            'pivot.SourceData = "SheetName!R1C1:R18C18"
            ws.PivotTables("PivotTable1").SourceData = "Source!R1C1:R" + (reccount + 1).ToString.Trim + "C25"
            ws.PivotTables("PivotTable1").RefreshTable()
            xl.DisplayAlerts = False
            wb.SaveAs(salesinvupdout)
            wb.Close()
            xl.Quit()
            xl = Nothing
            MessageBox.Show("Sales Trend Stock Transfer Report V10 generation is complete!")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "frmSalesTrendDirect.GenerateSalesTrend module")
        Finally
        End Try
    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbSales.Enter

    End Sub
    Function GetArraySize(counter10k As Integer, reccount As Integer) As Integer
        Dim retval As Integer = 0
        If ((reccount - (n10k * counter10k)) >= 10000) Then
            retval = n10k
        Else
            retval = n10k   'reccount - (n10k * counter10k)
        End If
        Return retval
    End Function

    Function GetRangeStart(counter10k As Integer, reccount As Integer) As Integer
        Dim retval As Integer = 0
        retval = n10k * (counter10k - 1)
        'Plus 2 because it starts from row 2, A2
        Return retval + 2
    End Function
    Function GetRangeEnd(counter10k As Integer, reccount As Integer) As Integer
        Dim retval As Integer = 0
        If ((reccount - (n10k * (counter10k - 1))) >= 10000) Then
            retval = n10k * counter10k
        Else
            retval = reccount
        End If
        'Plus 2 because it starts from row 2, A2
        Return retval + 2
    End Function

    Private Sub btnGenerateOnly_Click(sender As Object, e As EventArgs) Handles btnGenerateOnly.Click
        Dim salesinvupdfile As String = txtTemplate.Text.ToString
        'SetDate()
        Me.Cursor = Cursors.WaitCursor
        ShowInvoice(True)
        'this is now faster
        GenerateSalesTrend(salesinvupdfile)
        Me.Cursor = Cursors.Default
        KillExcellApp()
    End Sub
End Class