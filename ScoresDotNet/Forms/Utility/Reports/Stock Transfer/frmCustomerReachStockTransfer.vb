﻿Imports System.Data.SqlClient
Imports Microsoft
Imports Microsoft.Office.Interop
Imports System.Configuration
Imports System.Globalization
Imports System.Runtime.InteropServices
Public Class frmCustomerReachStockTransfer
    Private salesinvupdpath As String = System.Configuration.ConfigurationSettings.AppSettings.Item("CustomerReachPath")
    Private SalesTransDate As String = ""
    Private RemoteDataSet As New DataSet
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
        txtTemplate.Text = salesinvupdpath + "Customer Reach Analysis Stock Transfer.xlsx"
        txtOutput.Text = salesinvupdpath + "Customer Reach Analysis Stock Transfer " + currentdate + ".xlsx"
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmCustomerReachStockTransfer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RemoteDataSet.Tables.Add("IntegratedSales")
        SetDate()
        SetPath()
    End Sub

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        Dim salesinvupdfile As String = txtTemplate.Text.ToString
        SetDate()
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
            Dim commdately1 As DateTime
            Dim commdately2 As DateTime

            commdate1 = dtpMonth.Text.ToString().Trim()
            commdate2 = dtpmonthtyto.Text.ToString().Trim()

            commdately1 = dtpmonthlyfrom.Text.ToString().Trim()
            commdately2 = dtpmonthlyto.Text.ToString().Trim()

            Dim Params(3) As SqlParameter
            Dim commissiondate1 As New SqlParameter("@commissiondate1", SqlDbType.DateTime, 10) : commissiondate1.Direction = ParameterDirection.Input : commissiondate1.Value = commdate1 : Params(0) = commissiondate1
            Dim commissiondate2 As New SqlParameter("@commissiondate2", SqlDbType.DateTime, 10) : commissiondate2.Direction = ParameterDirection.Input : commissiondate2.Value = commdate2 : Params(1) = commissiondate2
            Dim commissiondately1 As New SqlParameter("@commissiondately1", SqlDbType.DateTime, 10) : commissiondately1.Direction = ParameterDirection.Input : commissiondately1.Value = commdately1 : Params(2) = commissiondately1
            Dim commissiondately2 As New SqlParameter("@commissiondately2", SqlDbType.DateTime, 10) : commissiondately2.Direction = ParameterDirection.Input : commissiondately2.Value = commdately2 : Params(3) = commissiondately2

            If Not generateonly Then
                BusinessObject.Sub_Update(ServerPath2, "Util_CustomerReachStock_Process", CommandType.StoredProcedure, Params)
            End If
            Dim Params0(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params0(0) = salescycledate

            BusinessObject.Sub_Show(ServerPath2, "Util_CustomerReachStock_Select", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params0)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            gbSales.Text = "Total No Of Records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString
            LogHelper.InsertLog("frmCustomerReachStockTransfer.ShowInvoice.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmCustomerReachStockTransfer.ShowInvoice.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub GenerateSales(ByVal strFileName As String)
        Dim xl As New Excel.Application
        Dim wb As Excel.Workbook
        Dim ws As Excel.Worksheet
        Dim wssalestrend As Excel.Worksheet
        Dim range As Excel.Range
        Dim rownumber As Integer = 0
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
            range = wssalestrend.Range("A2", "S" + reccount.ToString().Trim)

            Dim strArr(reccount, 19) As Object

            For Each dr As DataRow In dt.Rows
                'DIVISION, 
                strArr(rownumber, 0) = dr("division").ToString
                'principal, 
                strArr(rownumber, 1) = dr("principal").ToString
                'itemcode, 
                strArr(rownumber, 2) = dr("itemcode").ToString
                'itemdesc, 
                strArr(rownumber, 3) = dr("itemdesc").ToString
                'productline, 
                strArr(rownumber, 4) = dr("productline").ToString
                'districtname, 
                strArr(rownumber, 5) = dr("districtname").ToString
                'areaname
                strArr(rownumber, 6) = dr("areaname").ToString
                'supname, 
                strArr(rownumber, 7) = dr("supname").ToString
                'mrname, 
                strArr(rownumber, 8) = dr("mrname").ToString
                'region, 
                strArr(rownumber, 9) = dr("region").ToString
                'georegion, 
                strArr(rownumber, 10) = dr("georegion").ToString
                'province, 
                strArr(rownumber, 11) = dr("province").ToString
                'brickname
                strArr(rownumber, 12) = dr("brickname").ToString
                'distributor, 
                strArr(rownumber, 13) = dr("distributor").ToString
                'channel, 
                strArr(rownumber, 14) = dr("channel").ToString
                'SUBCHANNEL, 
                strArr(rownumber, 15) = dr("SUBCHANNEL").ToString
                'customername, 
                strArr(rownumber, 16) = dr("customername").ToString
                'monthname, 
                strArr(rownumber, 17) = dr("monthname").ToString
                'yearname
                strArr(rownumber, 18) = dr("yearname").ToString
                rownumber = rownumber + 1
            Next
            range.Value2 = strArr
            'Save Sales Transaction Date To Excel to Cell A4
            'Jan - May 2014 vs. Last year
            Dim monthnamefrom As String = dtpMonth.Value.ToString("MMMM", New CultureInfo("en-US"))
            Dim monthnameto As String = dtpmonthtyto.Value.ToString("MMMM", New CultureInfo("en-US"))
            ws.Range("A4").Value = monthnamefrom + " " + dtpMonth.Value.Year.ToString() + " - " + _
                                   monthnameto + " " + dtpmonthtyto.Value.Year.ToString()
            'Refresh PivotTable3
            'pivot.SourceData = "SheetName!R1C1:R18C18"
            'ws.PivotTables("PivotTable1").SourceData = "Source!R1C1:R" + (rownumber + 1).ToString.Trim + "C19"
            ws.PivotTables("PivotTable1").RefreshTable()
            xl.DisplayAlerts = False
            wb.SaveAs(salesinvupdout)
            wb.Close()
            xl.Quit()
            xl = Nothing
            MessageBox.Show("Customer Reach Stock Transfer Report generation is complete!")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "frmCustomerReachStockTransfer.GenerateSalesTrend module")
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

    Private Sub dtpMonth_ValueChanged(sender As Object, e As EventArgs) Handles dtpMonth.ValueChanged
        Dim iyear As Integer = 0
        iyear = dtpMonth.Value.Year - 1
        If iyear > 0 Then
            dtpmonthlyfrom.Text = dtpMonth.Value.Month.ToString + "/" + dtpMonth.Value.Day.ToString + "/" + Convert.ToString(iyear)
        End If
    End Sub

    Private Sub dtpmonthtyto_ValueChanged(sender As Object, e As EventArgs) Handles dtpmonthtyto.ValueChanged
        Dim iyear As Integer = 0
        iyear = dtpmonthtyto.Value.Year - 1
        If iyear > 0 Then
            dtpmonthlyto.Text = dtpmonthtyto.Value.Month.ToString + "/" + dtpmonthtyto.Value.Day.ToString + "/" + Convert.ToString(iyear)
        End If
    End Sub
End Class