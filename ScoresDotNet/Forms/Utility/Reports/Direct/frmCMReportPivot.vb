Imports System.Data.SqlClient
Imports Microsoft
Imports Microsoft.Office.Interop
Imports System.Configuration
Imports System.Globalization
Imports System.Runtime.InteropServices
Public Class frmCMReportPivot
    Private SalesTransDate As String = ""
    Private RemoteDataSet As New DataSet
    Private MonthName As String = ""
    Private Sub SetDate()
        Dim currentdate As String
        currentdate = dtpMonth.Value.Month.ToString + "/1/" + dtpMonth.Value.Year.ToString
        dtpMonth.Text = currentdate
        ''Jan - May 2014 Sales'
        MonthName = "Jan - " + dtpMonth.Value.ToString("MMM", New CultureInfo("en-US")) + " " + dtpMonth.Value.Year.ToString()
    End Sub

    Private Sub SetPath()
        Dim salesinvupdpath As String = System.Configuration.ConfigurationSettings.AppSettings.Item("CMReportPath")
        Dim currentdate As String
        Dim format As String = "MMM d yyyy"
        'CM Report  - Direct (Jan - May 2014).xlsx
        currentdate = DateTime.Now.ToString("MMM", New CultureInfo("en-US")) + " 1 - " + DateTime.Now.Date.Day.ToString() + " " + DateTime.Now.Date.Year.ToString()
        txtTemplate.Text = salesinvupdpath + "CM Report" + ".xlsx"
        txtOutput.Text = salesinvupdpath + "CM Report-Direct " + MonthName + ".xlsx"
    End Sub

    Private Sub frmGenerateInvoiceList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RemoteDataSet.Tables.Add("IntegratedSales")
        SetDate()
        SetPath()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        Dim salesinvupdfile As String = txtTemplate.Text.ToString
        'SetDate()
        Me.Cursor = Cursors.WaitCursor
        ShowInvoice()
        GenerateInvoiceToExcel(salesinvupdfile)
        Me.Cursor = Cursors.Default
        MsgBox("Process is complete." + " CM Report file : " + txtOutput.Text.ToString + " is generated!")
        KillExcellApp()
    End Sub
    Private Sub GenerateInvoiceToExcel(ByVal strFileName As String)
        Dim xl As New Excel.Application
        Dim wb As Excel.Workbook
        Dim ws As Excel.Worksheet
        Dim wspiv As Excel.Worksheet
        Dim rownumber As Integer = 2
        Dim salesinvupdout As String = txtOutput.Text.ToString
        Dim salesinvupd As String = txtTemplate.Text.ToString
        Try
            wb = xl.Workbooks.Open(strFileName)

            ws = CType(wb.Worksheets.Item("Sales Trend Source"), Excel.Worksheet)
            wspiv = CType(wb.Worksheets.Item("Sales Trend Pivot"), Excel.Worksheet)

            'Loop Sales Grid
            For Each row As DataGridViewRow In dgvSales.Rows
                If Not row.IsNewRow Then
                    With ws
                        'DIVISION, PRINSHORTNAME, ITEMDESC, PRODUCTFORM, PRODUCTLINE, DISTRIBUTOR, CHANNEL, SUBCHANNEL,
                        'CUSTOMERNAME, Region, GEOREGION, PROVINCE, BRICK, DATATYPE, CMCODE, CMREASON, CMREFINVOICE, CMREFDATE, 
                        'SALESCYCLEDATE, SUM(CMQTY), SUM(CMFREE), SUM(CMVALUE)
                        .Range("A" & rownumber.ToString()).Value = row.Cells("DIVISION").Value.ToString
                        .Range("B" & rownumber.ToString()).Value = row.Cells("PRINSHORTNAME").Value.ToString
                        .Range("C" & rownumber.ToString()).Value = row.Cells("ITEMDESC").Value.ToString
                        .Range("D" & rownumber.ToString()).Value = row.Cells("PRODUCTFORM").Value.ToString
                        .Range("E" & rownumber.ToString()).Value = row.Cells("PRODUCTLINE").Value.ToString
                        .Range("F" & rownumber.ToString()).Value = row.Cells("DISTRIBUTOR").Value.ToString
                        .Range("G" & rownumber.ToString()).Value = row.Cells("CHANNEL").Value.ToString
                        .Range("H" & rownumber.ToString()).Value = row.Cells("SUBCHANNEL").Value.ToString
                        .Range("I" & rownumber.ToString()).Value = row.Cells("CUSTOMERNAME").Value.ToString
                        .Range("J" & rownumber.ToString()).Value = row.Cells("Region").Value.ToString
                        .Range("K" & rownumber.ToString()).Value = row.Cells("GEOREGION").Value.ToString
                        .Range("L" & rownumber.ToString()).Value = row.Cells("PROVINCE").Value.ToString
                        .Range("M" & rownumber.ToString()).Value = row.Cells("BRICK").Value.ToString
                        .Range("N" & rownumber.ToString()).Value = row.Cells("DATATYPE").Value.ToString
                        .Range("O" & rownumber.ToString()).Value = row.Cells("CMCODE").Value.ToString
                        .Range("P" & rownumber.ToString()).Value = row.Cells("CMREASON").Value.ToString
                        .Range("Q" & rownumber.ToString()).Value = row.Cells("CMREFINVOICE").Value.ToString
                        .Range("R" & rownumber.ToString()).Value = row.Cells("CMREFDATE").Value.ToString
                        .Range("S" & rownumber.ToString()).Value = row.Cells("SALESCYCLEDATE").Value.ToString
                        .Range("T" & rownumber.ToString()).Value = row.Cells("CMQTY").Value.ToString
                        .Range("U" & rownumber.ToString()).Value = row.Cells("CMFREE").Value.ToString
                        .Range("V" & rownumber.ToString()).Value = row.Cells("CMVALUE").Value.ToString
                    End With
                    rownumber = rownumber + 1
                End If
            Next
            'Save Sales Transaction Date To Excel to Cell A3
            'Jan - May 2014 Sales'
            wspiv.Range("A3").Value = MonthName
            'Refresh PivotTable3
            'pivot.SourceData = "SheetName!R1C1:R18C18"
            wspiv.PivotTables("PivotTable3").SourceData = "Sales Trend Source!R1C1:R" + (rownumber - 1).ToString.Trim + "C22"
            wspiv.PivotTables("PivotTable3").RefreshTable()
            wb.SaveAs(salesinvupdout)
            wb.Close()
            xl.Quit()
            'Marshal.ReleaseComObject(wb)
            'Marshal.ReleaseComObject(xl)
            xl = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "frmCMReportPivot.GenerateInvoiceToExcel module")
        Finally
        End Try
    End Sub

    Private Sub ShowInvoice()
        Try
            If RemoteDataSet.Tables("IntegratedSales").Rows.Count > 0 Then RemoteDataSet.Tables("IntegratedSales").Clear()
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance

            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate

            BusinessObject.Sub_Update(ServerPath2, "Util_CMReport_Process", CommandType.StoredProcedure, Params)

            BusinessObject.Sub_Show(ServerPath2, "Util_CMReport_Select", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            LogHelper.InsertLog("frmCMReportPivot.ShowInvoice.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmCMReportPivot.ShowInvoice.Error: " & ex.Message)
        End Try
    End Sub


End Class