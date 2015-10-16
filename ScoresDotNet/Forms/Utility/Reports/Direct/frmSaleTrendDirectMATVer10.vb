Imports System.Data.SqlClient
Imports Microsoft
Imports Microsoft.Office.Interop
Imports System.Configuration
Imports System.Globalization
Imports System.Runtime.InteropServices
Public Class frmSaleTrendDirectMATVer10
    Private salesinvupdpath As String = System.Configuration.ConfigurationSettings.AppSettings.Item("SalesTrendPath")
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
        txtTemplate.Text = salesinvupdpath + "Sales Trend Direct MAT Ver 10.xlsx"
        txtOutput.Text = salesinvupdpath + "Sales Trend Direct MAT Ver 10 " + currentdate + ".xlsx"
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmSaleTrendDirectMATVer10_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            Dim salesfrom As DateTime
            Dim salesto As DateTime

            salesfrom = dtpMonth.Text.ToString().Trim()
            salesto = dtpmonthtyto.Text.ToString().Trim()

            Dim Params(1) As SqlParameter
            Dim salescycledatefrom As New SqlParameter("@salescycledatefrom", SqlDbType.DateTime, 10) : salescycledatefrom.Direction = ParameterDirection.Input : salescycledatefrom.Value = salesfrom : Params(0) = salescycledatefrom
            Dim salescycledateto As New SqlParameter("@salescycledateto", SqlDbType.DateTime, 10) : salescycledateto.Direction = ParameterDirection.Input : salescycledateto.Value = salesto : Params(1) = salescycledateto

            If Not generateonly Then
                BusinessObject.Sub_Update(ServerPath2, "Util_SalesTrend_Directver10Process", CommandType.StoredProcedure, Params)
            End If

            BusinessObject.Sub_Show(ServerPath2, "Util_SalesTrend_Directver10Select", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales")
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            gbSales.Text = "Total No Of Records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString
            LogHelper.InsertLog("Util_SalesTrend_Directver10Select.ShowInvoice.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("Util_SalesTrend_Directver10Select.ShowInvoice.Error: " & ex.Message)
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
            range = wssalestrend.Range("A2", "W" + reccount.ToString().Trim)

            Dim strArr(reccount, 23) As Object
            For Each dr As DataRow In dt.Rows

                'DIVISION [Segment], 
                strArr(rownumber, 0) = dr("Segment").ToString
                'PRINSHORTNAME [Principal] 
                strArr(rownumber, 1) = dr("Principal").ToString
                'ITEMDESC [Product]
                strArr(rownumber, 2) = dr("Product").ToString
                'PRODUCTLINE [Brand] 
                strArr(rownumber, 3) = dr("Brand").ToString
                'DISTRIBUTOR, 
                strArr(rownumber, 4) = dr("DISTRIBUTOR").ToString
                'CHANNEL
                strArr(rownumber, 5) = dr("CHANNEL").ToString
                'SUBCHANNEL, 
                strArr(rownumber, 6) = dr("SUBCHANNEL").ToString
                'CUSTOMERNAME [Outlet] 
                strArr(rownumber, 7) = dr("Outlet").ToString
                'REGION, 
                strArr(rownumber, 8) = dr("SALESREGION").ToString
                'GEOREGION, 
                strArr(rownumber, 9) = dr("GeoRegion").ToString
                'PROVINCE, 
                strArr(rownumber, 10) = dr("PROVINCE").ToString
                'BRICK
                strArr(rownumber, 11) = dr("BRICK").ToString
                'DATATYPE, 
                strArr(rownumber, 12) = dr("DATATYPE").ToString
                'MonthName, 
                strArr(rownumber, 13) = dr("MonthName").ToString
                'TYQTY, 
                strArr(rownumber, 14) = dr("TYQTY").ToString
                'LYQTY, 
                strArr(rownumber, 15) = dr("LYQTY").ToString
                'TYFREE, 
                strArr(rownumber, 16) = dr("TYFREE").ToString
                'LYFREE
                strArr(rownumber, 17) = dr("LYFREE").ToString
                'TYVALUE, 
                strArr(rownumber, 18) = dr("TYVALUE").ToString
                'LYVALUE, 
                strArr(rownumber, 19) = dr("LYVALUE").ToString
                'CMQTY, 
                strArr(rownumber, 20) = dr("CMQTY").ToString
                'CMFREE, 
                strArr(rownumber, 21) = dr("CMFREE").ToString
                'CMVALUE, 
                strArr(rownumber, 22) = dr("CMVALUE").ToString
                rownumber = rownumber + 1
            Next
            range.Value2 = strArr
            'Save Sales Transaction Date To Excel to Cell A3
            'Jan - May 2014 vs. Last year
            Dim monthnamefrom As String = dtpMonth.Value.ToString("MMMM", New CultureInfo("en-US"))
            Dim monthnameto As String = dtpmonthtyto.Value.ToString("MMMM", New CultureInfo("en-US"))
            ws.Range("A3").Value = monthnamefrom + " " + dtpMonth.Value.Year.ToString() + " - " + _
                                   monthnameto + " " + dtpmonthtyto.Value.Year.ToString()
            'Refresh PivotTable3
            'pivot.SourceData = "SheetName!R1C1:R18C18"
            ws.PivotTables("PivotTable1").SourceData = "Source!R1C1:R" + (rownumber + 1).ToString.Trim + "C23"
            ws.PivotTables("PivotTable1").RefreshTable()
            xl.DisplayAlerts = False
            wb.SaveAs(salesinvupdout)
            wb.Close()
            xl.Quit()
            xl = Nothing
            MessageBox.Show("Sales Trend Direct MAT Ver 10 Report generation is complete!")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "frmSalesTrendDirectMATver10.GenerateSalesTrend module")
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