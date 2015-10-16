Imports System.Data.SqlClient
Imports Microsoft
Imports Microsoft.Office.Interop
Imports System.Configuration
Imports System.Globalization
Imports System.Runtime.InteropServices
Public Class frmBudgetMonthlyReport

    Private salesinvupdpath As String = System.Configuration.ConfigurationSettings.AppSettings.Item("BudgetReportPath")
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
        txtTemplate.Text = salesinvupdpath + "Specialist Budget Report Template.xlsx"
        txtOutput.Text = salesinvupdpath + "Specialist Budget Report " + currentdate + ".xlsx"
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmBudgetMonthlyReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

            commdate1 = dtpMonth.Text.ToString().Trim()

            Dim Params(0) As SqlParameter
            Dim commissiondate As New SqlParameter("@commissiondate", SqlDbType.DateTime, 10) : commissiondate.Direction = ParameterDirection.Input : commissiondate.Value = commdate1 : Params(0) = commissiondate
            'BusinessObject.Sub_Show(ServerPath2, "Util_Budget_PrevAndCurr", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            BusinessObject.Sub_Show(ServerPath2, "Util_55MonthSPBudget", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)

            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            gbSales.Text = "Total No Of Records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString
            LogHelper.InsertLog("frmBudgetMonthlyReport.ShowInvoice.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmBudgetMonthlyReport.ShowInvoice.Error: " & ex.Message)
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
            range = wssalestrend.Range("A2", "D" + reccount.ToString().Trim)

            Dim strArr(reccount, 12) As Object
            For Each dr As DataRow In dt.Rows
                'su.supname [SupName],mr.mrname,sum(bu.amount) [budget]
                strArr(rownumber, 0) = dr("supname").ToString
                strArr(rownumber, 1) = dr("mrname").ToString
                strArr(rownumber, 2) = dr("budget").ToString
                strArr(rownumber, 3) = dr("commissiondate").ToString
                rownumber = rownumber + 1
            Next
            range.Value2 = strArr
            'Save Sales Transaction Date To Excel to Cell A4
            'Jan - May 2014 vs. Last year
            Dim monthnamefrom As String = dtpMonth.Value.ToString("MMMM", New CultureInfo("en-US"))
            Dim monthnameto As String = dtpMonth.Value.ToString("MMMM", New CultureInfo("en-US"))
            ws.Range("A3").Value = "January " + dtpMonth.Value.Year.ToString() + " - " + _
                                   monthnameto + " " + dtpMonth.Value.Year.ToString()
            'Refresh PivotTable3
            ws.PivotTables("PivotTable1").SourceData = "Source!R1C1:R" + (rownumber + 1).ToString.Trim + "C3"
            ws.PivotTables("PivotTable1").RefreshTable()
            xl.DisplayAlerts = False
            wb.SaveAs(salesinvupdout)
            wb.Close()
            xl.Quit()
            xl = Nothing
            MessageBox.Show("Budget Monthly Report is generated successfully!")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "frmBudgetMonthlyReport.GenerateSalesTrend module")
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