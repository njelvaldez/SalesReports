Imports System.Data.SqlClient
Imports Microsoft
Imports Microsoft.Office.Interop
Imports System.Configuration
Imports System.Globalization
Imports System.Runtime.InteropServices
Public Class frmSalesTrendDirect
    Private salesinvupdpath As String = System.Configuration.ConfigurationSettings.AppSettings.Item("SalesTrendPath")
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
        GenerateSalesTrend(salesinvupdfile)
        Me.Cursor = Cursors.Default
        MsgBox("Process is complete." + " Sales Trend File : " + txtOutput.Text.ToString + " is generated!")
        KillExcellApp()
    End Sub

    Private Sub ShowInvoice()
        Try
            If RemoteDataSet.Tables("IntegratedSales").Rows.Count > 0 Then RemoteDataSet.Tables("IntegratedSales").Clear()
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim cycledatefrom As DateTime
            Dim cycledateto As DateTime
            Dim cycledatelyfrom As DateTime
            Dim cycledatelyto As DateTime
            Dim lastyear As String = (dtpMonth.Value.Year - 1).ToString()
            Dim thisyear As String = (dtpMonth.Value.Year).ToString()

            cycledatefrom = "1/1/" + thisyear
            cycledateto = dtpMonth.Text.ToString().Trim()
            cycledatelyfrom = "1/1/" + lastyear
            cycledatelyto = dtpMonth.Value.Month.ToString.Trim() + "/" + dtpMonth.Value.Day.ToString.Trim() + "/" + lastyear


            Dim Params(3) As SqlParameter
            Dim salescycledatefrom As New SqlParameter("@salescycledatefrom", SqlDbType.DateTime, 10) : salescycledatefrom.Direction = ParameterDirection.Input : salescycledatefrom.Value = cycledatefrom : Params(0) = salescycledatefrom
            Dim salescycledateto As New SqlParameter("@salescycledateto", SqlDbType.DateTime, 10) : salescycledateto.Direction = ParameterDirection.Input : salescycledateto.Value = cycledateto : Params(1) = salescycledateto
            Dim salescycledatelyfrom As New SqlParameter("@salescycledatelyfrom", SqlDbType.DateTime, 10) : salescycledatelyfrom.Direction = ParameterDirection.Input : salescycledatelyfrom.Value = cycledatelyfrom : Params(2) = salescycledatelyfrom
            Dim salescycledatelyto As New SqlParameter("@salescycledatelyto", SqlDbType.DateTime, 10) : salescycledatelyto.Direction = ParameterDirection.Input : salescycledatelyto.Value = cycledatelyto : Params(3) = salescycledatelyto

            BusinessObject.Sub_Update(ServerPath2, "Util_SalesTrend_Process", CommandType.StoredProcedure, Params)
            Dim Params0(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params0(0) = salescycledate
            BusinessObject.Sub_Show(ServerPath2, "Util_SalesTrend_Select", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params0)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            LogHelper.InsertLog("frmSalesTrendDirect.ShowInvoice.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmSalesTrendDirect.ShowInvoice.Error: " & ex.Message)
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
                        'PRINSHORTNAME, 
                        .Range("B" & rownumber.ToString()).Value = row.Cells("PRINSHORTNAME").Value.ToString
                        'ITEMDESC, 
                        .Range("C" & rownumber.ToString()).Value = row.Cells("ITEMDESC").Value.ToString
                        'PRODUCTFORM, 
                        .Range("D" & rownumber.ToString()).Value = row.Cells("PRODUCTFORM").Value.ToString
                        'PRODUCTLINE, 
                        .Range("E" & rownumber.ToString()).Value = row.Cells("PRODUCTLINE").Value.ToString
                        'DISTRIBUTOR, 
                        .Range("F" & rownumber.ToString()).Value = row.Cells("DISTRIBUTOR").Value.ToString
                        'CHANNEL, 
                        .Range("G" & rownumber.ToString()).Value = row.Cells("CHANNEL").Value.ToString
                        'SUBCHANNEL,
                        .Range("H" & rownumber.ToString()).Value = row.Cells("SUBCHANNEL").Value.ToString
                        'CUSTOMERNAME,
                        .Range("I" & rownumber.ToString()).Value = row.Cells("CUSTOMERNAME").Value.ToString
                        'REGION, 
                        .Range("J" & rownumber.ToString()).Value = row.Cells("REGION").Value.ToString
                        'GEOREGION, 
                        .Range("K" & rownumber.ToString()).Value = row.Cells("GEOREGION").Value.ToString
                        'PROVINCE, 
                        .Range("L" & rownumber.ToString()).Value = row.Cells("PROVINCE").Value.ToString
                        'BRICK, 
                        .Range("M" & rownumber.ToString()).Value = row.Cells("BRICK").Value.ToString
                        'DATATYPE, 
                        .Range("N" & rownumber.ToString()).Value = row.Cells("DATATYPE").Value.ToString
                        'DATENAME(MM,SALESCYCLEDATE) [MONTH], 
                        .Range("O" & rownumber.ToString()).Value = row.Cells("MONTHNAME").Value.ToString
                        'SUM(TYQTY) [TYQTY], 
                        .Range("P" & rownumber.ToString()).Value = row.Cells("TYQTY").Value.ToString
                        'SUM(LYQTY) [LYQTY], 
                        .Range("Q" & rownumber.ToString()).Value = row.Cells("LYQTY").Value.ToString
                        'SUM(TYFREE) [TYFREE], 
                        .Range("R" & rownumber.ToString()).Value = row.Cells("TYFREE").Value.ToString
                        'SUM(LYFREE) [LYFREE],
                        .Range("S" & rownumber.ToString()).Value = row.Cells("LYFREE").Value.ToString
                        'SUM(TYVALUE) [TYVALUE], 
                        .Range("T" & rownumber.ToString()).Value = row.Cells("TYVALUE").Value.ToString
                        'SUM(LYVALUE) [LYVALUE], 
                        .Range("U" & rownumber.ToString()).Value = row.Cells("LYVALUE").Value.ToString
                        'SUM(CMQTY) [CMQTY], 
                        .Range("V" & rownumber.ToString()).Value = row.Cells("CMQTY").Value.ToString
                        'SUM(CMFREE) [CMFREE], 
                        .Range("W" & rownumber.ToString()).Value = row.Cells("CMFREE").Value.ToString
                        'SUM(CMVALUE) [CMVALUE]
                        .Range("X" & rownumber.ToString()).Value = row.Cells("CMVALUE").Value.ToString
                    End With
                    rownumber = rownumber + 1
                End If
            Next

            'Save Sales Transaction Date To Excel to Cell A3
            'Jan - May 2014 vs. Last year
            ws.Range("A3").Value = "Jan - May 2014 vs. Last year"
            'Refresh PivotTable3
            'pivot.SourceData = "SheetName!R1C1:R18C18"
            ws.PivotTables("PivotTable3").SourceData = "Sales Trend Source!R1C1:R" + (rownumber - 1).ToString.Trim + "C24"
            ws.PivotTables("PivotTable3").RefreshTable()
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
End Class