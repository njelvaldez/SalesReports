Imports System.Data.SqlClient
Imports Microsoft
Imports Microsoft.Office.Interop
Imports System.Configuration
Imports System.Globalization
Imports System.Runtime.InteropServices
Public Class frmSalesTrendStockTransfer
    Private salesinvupdpath As String = System.Configuration.ConfigurationSettings.AppSettings.Item("SalesTrendPathStockTransfer")
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
        txtTemplate.Text = salesinvupdpath + "SOURCE Sales Trend.xlsx"
        txtOutput.Text = salesinvupdpath + "SOURCE Sales Trend " + currentdate + ".xlsx"
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
        SetDate()
        Me.Cursor = Cursors.WaitCursor
        ShowInvoice()
        'this is too slow GenerateSalesTrend(salesinvupdfile)
        Me.Cursor = Cursors.Default
        'MsgBox("Process is complete." + " Sales Trend File : " + txtOutput.Text.ToString + " is generated!")
        'KillExcellApp()
    End Sub

    Private Sub ShowInvoice()
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

            'BusinessObject.Sub_Show(ServerPath2, "Util_SalesTrend_StockTransfer", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            BusinessObject.Sub_Update(ServerPath2, "Util_SalesTrend_StockTransferProcess", CommandType.StoredProcedure, Params)
            Dim Params0(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params0(0) = salescycledate
            BusinessObject.Sub_Show(ServerPath2, "Util_SalesTrend_StockTransferSelect", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params0)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            gbSales.Text = "Total No Of Records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString
            LogHelper.InsertLog("frmSalesTrendStockTransfer.ShowInvoice.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmSalesTrendStockTransfer.ShowInvoice.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub GenerateSalesTrend(ByVal strFileName As String)
        Dim xl As New Excel.Application
        Dim wb As Excel.Workbook
        Dim ws As Excel.Worksheet
        Dim wssalestrend As Excel.Worksheet
        Dim range As Excel.Range
        Dim rownumber As Integer = 2
        Dim salesinvupdout As String = txtOutput.Text.ToString
        Dim salesinvupd As String = txtTemplate.Text.ToString
        Try
            wb = xl.Workbooks.Open(strFileName)

            ws = CType(wb.Worksheets.Item("Sales Trend Pivot"), Excel.Worksheet)
            wssalestrend = CType(wb.Worksheets.Item("Sales Trend Source"), Excel.Worksheet)

            'range = wssalestrend.Range("A2", "X" + dgvSales.Rows.Count.ToString())
            'wssalestrend.Cells.Delete(range)
            'Loop Sales Grid
            For Each row As DataGridViewRow In dgvSales.Rows
                If Not row.IsNewRow Then
                    With wssalestrend
                        'DIVISION, 
                        .Range("A" & rownumber.ToString()).Value = row.Cells("DIVISION").Value.ToString
                        'principal, 
                        .Range("B" & rownumber.ToString()).Value = row.Cells("principal").Value.ToString
                        'itemcode, 
                        .Range("C" & rownumber.ToString()).Value = row.Cells("itemcode").Value.ToString
                        'ITEMDESC, 
                        .Range("C" & rownumber.ToString()).Value = row.Cells("ITEMDESC").Value.ToString
                        'productline, 
                        .Range("D" & rownumber.ToString()).Value = row.Cells("productline").Value.ToString
                        'DISTRICTNAME, 
                        .Range("E" & rownumber.ToString()).Value = row.Cells("DISTRICTNAME").Value.ToString
                        'AREANAME, 
                        .Range("F" & rownumber.ToString()).Value = row.Cells("AREANAME").Value.ToString
                        'supname, 
                        .Range("G" & rownumber.ToString()).Value = row.Cells("supname").Value.ToString
                        'mrname,
                        .Range("H" & rownumber.ToString()).Value = row.Cells("mrname").Value.ToString
                        'region,
                        .Range("I" & rownumber.ToString()).Value = row.Cells("region").Value.ToString
                        'georegion, 
                        .Range("J" & rownumber.ToString()).Value = row.Cells("georegion").Value.ToString
                        'PROVINCE, 
                        .Range("L" & rownumber.ToString()).Value = row.Cells("PROVINCE").Value.ToString
                        'brickname, 
                        .Range("M" & rownumber.ToString()).Value = row.Cells("brickname").Value.ToString
                        'distributor, 
                        .Range("N" & rownumber.ToString()).Value = row.Cells("distributor").Value.ToString
                        'channel, 
                        .Range("O" & rownumber.ToString()).Value = row.Cells("channel").Value.ToString
                        'SUBCHANNEL, 
                        .Range("P" & rownumber.ToString()).Value = row.Cells("SUBCHANNEL").Value.ToString
                        'customername, 
                        .Range("Q" & rownumber.ToString()).Value = row.Cells("customername").Value.ToString
                        'datename(mm,commissiondate) [monthname], 
                        .Range("R" & rownumber.ToString()).Value = row.Cells("monthname").Value.ToString

                        'TYQty,
                        .Range("S" & rownumber.ToString()).Value = row.Cells("TYQty").Value.ToString
                        'LYQTY, 
                        .Range("T" & rownumber.ToString()).Value = row.Cells("LYQTY").Value.ToString
                        'TYFree, 
                        .Range("U" & rownumber.ToString()).Value = row.Cells("TYFree").Value.ToString
                        'LYFree, 
                        .Range("V" & rownumber.ToString()).Value = row.Cells("LYFree").Value.ToString
                        'TYValue, 
                        .Range("W" & rownumber.ToString()).Value = row.Cells("TYValue").Value.ToString
                        'LYValue
                        .Range("X" & rownumber.ToString()).Value = row.Cells("LYValue").Value.ToString
                        'TYCMQty, 
                        .Range("W" & rownumber.ToString()).Value = row.Cells("TYCMQty").Value.ToString
                        'TYReturn
                        .Range("X" & rownumber.ToString()).Value = row.Cells("TYReturn").Value.ToString

                    End With
                    rownumber = rownumber + 1
                End If
            Next

            'Save Sales Transaction Date To Excel to Cell A3
            'Jan - May 2014 vs. Last year
            Dim monthname As String = dtpMonth.Value.ToString("MMMM", New CultureInfo("en-US"))
            ws.Range("A3").Value = "January - " + monthname + " 2014 vs. Last year"
            'Refresh PivotTable3
            'pivot.SourceData = "SheetName!R1C1:R18C18"
            ws.PivotTables("PivotTable2").SourceData = "Sales Trend Source!R1C1:R" + (rownumber - 1).ToString.Trim + "C26"
            ws.PivotTables("PivotTable2").RefreshTable()
            xl.DisplayAlerts = False
            wb.SaveAs(salesinvupdout)
            wb.Close()
            xl.Quit()
            'Marshal.ReleaseComObject(wb)
            'Marshal.ReleaseComObject(xl)
            xl = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "frmSalesTrendDirect.GenerateSalesTrend module")
        Finally
        End Try
    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbSales.Enter

    End Sub
End Class