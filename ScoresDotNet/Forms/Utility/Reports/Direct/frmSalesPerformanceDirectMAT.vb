Imports System.Data.SqlClient
Imports Microsoft
Imports Microsoft.Office.Interop
Imports System.Configuration
Imports System.Globalization
Imports System.Runtime.InteropServices
Public Class frmSalesPerformanceDirectMAT
    Private salesinvupdpath As String = System.Configuration.ConfigurationSettings.AppSettings.Item("SalesPerformancePath")
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
        txtTemplate.Text = salesinvupdpath + "Sales Performance Direct MAT.xlsx"
        txtOutput.Text = salesinvupdpath + "Sales Performance Direct MAT " + currentdate + ".xlsx"
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmSalesPerformanceDirectMAT_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            Dim salesdatefromty As DateTime
            Dim salesdatetoty As DateTime

            salesdatefromty = dtpMonth.Text.ToString().Trim()
            salesdatetoty = dtpmonthtyto.Text.ToString().Trim()

            Dim Params(1) As SqlParameter
            Dim salescycledatefromty As New SqlParameter("@salescycledatefromty", SqlDbType.DateTime, 10) : salescycledatefromty.Direction = ParameterDirection.Input : salescycledatefromty.Value = salesdatefromty : Params(0) = salescycledatefromty
            Dim salescycledatetoty As New SqlParameter("@salescycledatetoty", SqlDbType.DateTime, 10) : salescycledatetoty.Direction = ParameterDirection.Input : salescycledatetoty.Value = salesdatetoty : Params(1) = salescycledatetoty

            If Not generateonly Then
                BusinessObject.Sub_Update(ServerPath2, "Util_SalesPerformanceDirectProcess", CommandType.StoredProcedure, Params)
            End If

            BusinessObject.Sub_Show(ServerPath2, "Util_SalesPerformanceDirectSelect", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales")
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            gbSales.Text = "Total No Of Records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString
            LogHelper.InsertLog("frmSalesPerformanceDirect.ShowInvoice.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmSalesPerformanceDirect.ShowInvoice.Error: " & ex.Message)
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
            ws = CType(wb.Worksheets.Item("Pivot"), Excel.Worksheet)
            wssalestrend = CType(wb.Worksheets.Item("Source"), Excel.Worksheet)
            range = wssalestrend.Range("A2", "N" + reccount.ToString().Trim)

            Dim strArr(reccount, 14) As Object

            For Each dr As DataRow In dt.Rows
                'DIVISION [Segment] 
                strArr(rownumber, 0) = dr("Segment").ToString

                'PRINSHORTNAME [Principal]
                strArr(rownumber, 1) = dr("Principal").ToString

                'ITEMDESC [Product], 
                strArr(rownumber, 2) = dr("Product").ToString

                'PRODUCTLINE [Brand], 
                strArr(rownumber, 3) = dr("Brand").ToString

                'DATATYPE [Data Type] 
                strArr(rownumber, 4) = dr("Data Type").ToString

                'DATENAME(MM,SALESCYCLEDATE)[Month]
                strArr(rownumber, 5) = dr("Month").ToString

                'SUM(TYQTY) [TyQty]
                strArr(rownumber, 6) = dr("TyQty").ToString

                ' SUM(LYQTY) [LYQty]
                strArr(rownumber, 7) = dr("LYQty").ToString

                'SUM(TYVALUE) [TYValue] 
                strArr(rownumber, 8) = dr("TYValue").ToString

                'SUM(LYVALUE) [LYValue],
                strArr(rownumber, 9) = dr("LYValue").ToString

                'SUM(TYTARGETQTY)[TYTargetQty] 
                strArr(rownumber, 10) = dr("TYTargetQty").ToString

                'SUM(LYTARGETQTY)[LYTargetQty]
                strArr(rownumber, 11) = dr("LYTargetQty").ToString

                'SUM(TYTARGETVALUE)[TYTargetValue]
                strArr(rownumber, 12) = dr("TYTargetValue").ToString

                'SUM(LYTARGETVALUE) [LYTargetValue]
                strArr(rownumber, 13) = dr("LYTargetValue").ToString

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
            ws.PivotTables("PivotTable9").SourceData = "Source!R1C1:R" + (rownumber + 1).ToString.Trim + "C14"
            ws.PivotTables("PivotTable9").RefreshTable()
            xl.DisplayAlerts = False
            wb.SaveAs(salesinvupdout)
            wb.Close()
            xl.Quit()
            xl = Nothing
            MessageBox.Show("Sales Performance Direct YTD Report generation is complete!")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "frmSalesPerformanceDirectYTD.GenerateSalesTrend module")
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