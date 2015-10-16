Imports System.Data.SqlClient
Imports Microsoft
Imports Microsoft.Office.Interop
Imports System.Configuration
Imports System.Globalization
Imports System.Runtime.InteropServices
Public Class frmSalesTrendStockTransferMAT
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
        txtTemplate.Text = salesinvupdpath + "Segment Sales Trend Stock Transfer MAT.xlsx"
        txtOutput.Text = salesinvupdpath + "Segment Sales Trend Stock Transfer MAT " + currentdate + ".xlsx"
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmSalesTrendStockTransferMAT_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
                BusinessObject.Sub_Update(ServerPath2, "Util_SalesTrendStockTransferMATProcess", CommandType.StoredProcedure, Params)
            End If
            Dim Params0(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params0(0) = salescycledate

            BusinessObject.Sub_Show(ServerPath2, "Util_SalesTrendStockTransferMATSelect", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params0)
            'dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            gbSales.Text = "Total No Of Records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString
            LogHelper.InsertLog("frmSalesPerformanceSPAward.ShowInvoice.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmSalesTrendStockTransferMAT.ShowInvoice.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub GenerateSales(ByVal strFileName As String)
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
            'Dim dt As New DataTable
            'dt = (DirectCast(dgvSales.DataSource, DataTable))
            reccount = RemoteDataSet.Tables(0).Rows.Count + 1
            ws = CType(wb.Worksheets.Item("Sales Trend Pivot"), Excel.Worksheet)
            wssalestrend = CType(wb.Worksheets.Item("Source"), Excel.Worksheet)
            range = wssalestrend.Range("A2", "Z" + GetRangeEnd(counter10k, reccount).ToString().Trim)

            Dim strArr(GetArraySize(counter10k, reccount), 26) As Object
            For Each dr As DataRow In RemoteDataSet.Tables(0).Rows
                strArr(rownumber, 0) = dr("spdivision").ToString
                strArr(rownumber, 1) = dr("principal").ToString
                strArr(rownumber, 2) = dr("itemcode").ToString
                strArr(rownumber, 3) = dr("itemdesc").ToString
                strArr(rownumber, 4) = dr("productline").ToString
                strArr(rownumber, 5) = dr("DISTRICTNAME").ToString
                strArr(rownumber, 6) = dr("AREANAME").ToString
                strArr(rownumber, 7) = dr("supname").ToString
                strArr(rownumber, 8) = dr("mrname").ToString
                strArr(rownumber, 9) = dr("region").ToString
                strArr(rownumber, 10) = dr("georegion").ToString
                strArr(rownumber, 11) = dr("PROVINCE").ToString
                strArr(rownumber, 12) = dr("brickname").ToString
                strArr(rownumber, 13) = dr("distributor").ToString
                strArr(rownumber, 14) = dr("channel").ToString
                strArr(rownumber, 15) = dr("SUBCHANNEL").ToString
                strArr(rownumber, 16) = dr("customername").ToString
                strArr(rownumber, 17) = dr("cmonth").ToString
                strArr(rownumber, 18) = dr("TYQty").ToString
                strArr(rownumber, 19) = dr("LYQTY").ToString
                strArr(rownumber, 20) = dr("TYFree").ToString
                strArr(rownumber, 21) = dr("LYFree").ToString
                strArr(rownumber, 22) = dr("TYValue").ToString
                strArr(rownumber, 23) = dr("LYValue").ToString
                strArr(rownumber, 24) = dr("TYCMQty").ToString
                strArr(rownumber, 25) = dr("TYReturn").ToString
                'array is zero base , lets subtract by 1
                If rownumber >= n10k - 1 Then
                    range.Value2 = strArr
                    counter10k = counter10k + 1
                    ReDim strArr(0, 0)
                    ReDim strArr(GetArraySize(counter10k, reccount), 26)
                    range = wssalestrend.Range("A" + (GetRangeStart(counter10k, reccount)).ToString().Trim(), "Z" + GetRangeEnd(counter10k, reccount).ToString().Trim)
                    rownumber = 0
                Else
                    rownumber = rownumber + 1
                End If
            Next
            range.Value2 = strArr
            'Save Sales Transaction Date To Excel to Cell A3
            'Jan - May 2014 vs. Last year
            Dim monthnamefrom As String = dtpMonth.Value.ToString("MMMM", New CultureInfo("en-US"))
            Dim monthnameto As String = dtpmonthtyto.Value.ToString("MMMM", New CultureInfo("en-US"))
            ws.Range("A4").Value = monthnamefrom + " " + dtpMonth.Value.Year.ToString() + " - " + _
                                   monthnameto + " " + dtpmonthtyto.Value.Year.ToString()
            'Refresh PivotTable3
            'pivot.SourceData = "SheetName!R1C1:R18C18"
            ws.PivotTables("PivotTable2").SourceData = "Source!R1C1:R" + (reccount + 1).ToString.Trim + "C26"
            ws.PivotTables("PivotTable2").RefreshTable()
            xl.DisplayAlerts = False
            wb.SaveAs(salesinvupdout)
            wb.Close()
            xl.Quit()
            xl = Nothing
            MessageBox.Show("Sales Trend Stock Transfer MAT Report generation is complete!")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "frmSalesTrendStockTransferMAT.GenerateSalesTrend module")
        Finally
        End Try
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