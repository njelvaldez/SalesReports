Imports System.Data.SqlClient
Imports Microsoft
Imports Microsoft.Office.Interop
Imports System.Configuration
Imports System.Globalization
Imports System.Runtime.InteropServices
Public Class frmItemSalesReportStockTransfer
    Private salesinvupdpath As String = System.Configuration.ConfigurationSettings.AppSettings.Item("ItemSalesPath")
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
        txtTemplate.Text = salesinvupdpath + "Item Sales Report.xlsx"
        txtOutput.Text = salesinvupdpath + "Item Sales Report Stock Transfer " + currentdate + ".xlsx"
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmItemSalesReportStockTransfer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If RemoteDataSet.Tables.Count = 0 Then
            RemoteDataSet.Tables.Add("IntegratedSales")
        End If
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
            Dim itemcodesvalue As String = ListHelper.GetCodes(lstItems)
            Dim customercodesvalue As String = ListHelper.GetCodes(lstCustomer)

            commdate1 = dtpMonth.Text.ToString().Trim()
            commdate2 = dtpmonthtyto.Text.ToString().Trim()
            Dim Params(3) As SqlParameter
            Dim commissiondate1 As New SqlParameter("@commissiondate1", SqlDbType.VarChar, 12) : commissiondate1.Direction = ParameterDirection.Input : commissiondate1.Value = "'" + dtpMonth.Text.ToString().Trim() + "'" : Params(0) = commissiondate1
            Dim commissiondate2 As New SqlParameter("@commissiondate2", SqlDbType.VarChar, 12) : commissiondate2.Direction = ParameterDirection.Input : commissiondate2.Value = "'" + dtpmonthtyto.Text.ToString().Trim() + "'" : Params(1) = commissiondate2
            Dim itemcodes As New SqlParameter("@itemcodes", SqlDbType.VarChar, 2048) : itemcodes.Direction = ParameterDirection.Input : itemcodes.Value = itemcodesvalue : Params(2) = itemcodes
            Dim customercodes As New SqlParameter("@customercodes", SqlDbType.VarChar, 2048) : customercodes.Direction = ParameterDirection.Input : customercodes.Value = customercodesvalue : Params(3) = customercodes
            BusinessObject.Sub_Show(ServerPath2, "Util_ItemSalesStockTransfer_Select", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            gbSales.Text = "Total No Of Records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString
            LogHelper.InsertLog("frmItemSalesReportStockTransfer.ShowInvoice.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmItemSalesReportStockTransfer.ShowInvoice.Error: " & ex.Message)
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
            ws = CType(wb.Worksheets.Item("Pivot"), Excel.Worksheet)
            wssalestrend = CType(wb.Worksheets.Item("Source"), Excel.Worksheet)
            range = wssalestrend.Range("A2", "T" + GetRangeEnd(counter10k, reccount).ToString().Trim)

            Dim strArr(GetArraySize(counter10k, reccount), 20) As Object

            For Each dr As DataRow In dt.Rows
                'Customer, 
                strArr(rownumber, 0) = dr("CustomerName").ToString
                'Invoice, 
                strArr(rownumber, 1) = dr("RefCode").ToString
                'Date, 
                strArr(rownumber, 2) = dr("RefDate").ToString
                'itemcode, 
                strArr(rownumber, 3) = dr("ItemCode").ToString
                'ITEMDESC, 
                strArr(rownumber, 4) = dr("ItemDesc").ToString
                'Qty Sold, 
                strArr(rownumber, 5) = dr("QtySold").ToString
                'Amount Sold, 
                strArr(rownumber, 6) = dr("AmountSold").ToString
                'Year
                strArr(rownumber, 7) = dr("syear").ToString

                'division, principaldesc,i.group, j.region,h.province,datename(mm,commissiondate) monthname
                strArr(rownumber, 7) = dr("syear").ToString
                strArr(rownumber, 8) = dr("division").ToString
                strArr(rownumber, 9) = dr("principaldesc").ToString
                strArr(rownumber, 10) = dr("groups").ToString
                strArr(rownumber, 11) = dr("region").ToString
                strArr(rownumber, 12) = dr("province").ToString
                strArr(rownumber, 13) = dr("monthname").ToString
                strArr(rownumber, 14) = dr("productline").ToString
                'Add Brick,Channel and SUb Channel
                strArr(rownumber, 15) = dr("brick").ToString
                strArr(rownumber, 16) = dr("channel").ToString
                strArr(rownumber, 17) = dr("subchannel").ToString
                'add year and quarter
                strArr(rownumber, 18) = dr("yearname").ToString
                strArr(rownumber, 19) = dr("quartername").ToString

                'array is zero base , lets subtract by 1
                If rownumber >= n10k - 1 Then
                    range.Value2 = strArr
                    counter10k = counter10k + 1
                    ReDim strArr(0, 0)
                    ReDim strArr(GetArraySize(counter10k, reccount), 20)
                    range = wssalestrend.Range("A" + (GetRangeStart(counter10k, reccount)).ToString().Trim(), "T" + GetRangeEnd(counter10k, reccount).ToString().Trim)
                    rownumber = 0
                Else
                    rownumber = rownumber + 1
                End If
            Next
            range.Value2 = strArr
            ws.Range("A2").Value = "Item Sales Report - Stock Transfer"
            'Save Sales Transaction Date To Excel to Cell A3
            Dim frommonth As String = dtpMonth.Value.ToString("MMMM", New CultureInfo("en-US")) + " " + dtpMonth.Value.Year.ToString()
            Dim monthname As String = dtpmonthtyto.Value.ToString("MMMM", New CultureInfo("en-US")) + " " + dtpmonthtyto.Value.Year.ToString()
            ws.Range("A3").Value = frommonth + " - " + monthname
            'Refresh PivotTable3
            'pivot.SourceData = "SheetName!R1C1:R18C18"
            ws.PivotTables("PivotTable1").SourceData = "Source!R1C1:R" + (reccount + 1).ToString.Trim + "C20"
            ws.PivotTables("PivotTable1").RefreshTable()
            xl.DisplayAlerts = False
            wb.SaveAs(salesinvupdout)
            wb.Close()
            xl.Quit()
            xl = Nothing
            MessageBox.Show("Item Sales Stock Transfer Report generation is complete!")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "frmItemSalesReportStockTransfer.GenerateSalesTrend module")
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
        'ShowInvoice(True)
        'this is now faster
        GenerateSalesTrend(salesinvupdfile)
        Me.Cursor = Cursors.Default
        KillExcellApp()
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Dim myLoadedForm As New frmLookUp
        myLoadedForm.ItemLookUpForm = Me.lstItems
        myLoadedForm.lookupspname = "Util_Item_List"
        myLoadedForm.lookupcaption = "Item Look Up"
        myLoadedForm.Show()
    End Sub

    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        Dim myLoadedForm As New frmLookUp
        myLoadedForm.ItemLookUpForm = Me.lstCustomer
        myLoadedForm.lookupspname = "Util_Customer_List"
        myLoadedForm.lookupcaption = "Customer Look Up"
        myLoadedForm.Show()
    End Sub

    Private Sub btnClearItem_Click(sender As Object, e As EventArgs) Handles btnClearItem.Click
        lstItems.Items.Clear()
    End Sub

    Private Sub btnClearCustomer_Click(sender As Object, e As EventArgs) Handles btnClearCustomer.Click
        lstCustomer.Items.Clear()
    End Sub
End Class