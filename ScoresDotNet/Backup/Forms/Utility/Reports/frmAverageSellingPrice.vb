Imports System.Data.SqlClient
Imports Microsoft
Imports Microsoft.Office.Interop
Imports System.Configuration
Imports System.Globalization
Imports System.Runtime.InteropServices
Public Class frmAverageSellingPrice

    Private SalesTransDate As String = ""
    Private RemoteDataSet As New DataSet
    Private MonthName As String = ""
    Private Sub SetDate()
        Dim currentdate As String
        currentdate = dtpMonth.Value.Month.ToString + "/1/" + dtpMonth.Value.Year.ToString
        dtpMonth.Text = currentdate
        ''Jan - May 2014 Sales'
        MonthName = "Jan - " + dtpMonth.Value.ToString("MMM", New CultureInfo("en-US")) + " " + dtpMonth.Value.Year.ToString() + " Sales"
    End Sub

    Private Sub SetPath()
        Dim salesinvupdpath As String = System.Configuration.ConfigurationSettings.AppSettings.Item("ASPSalesPath")
        Dim currentdate As String
        Dim format As String = "MMM d yyyy"
        'ASP Jan - May 2014.xlsx
        currentdate = DateTime.Now.ToString("MMM", New CultureInfo("en-US")) + " 1 - " + DateTime.Now.Date.Day.ToString() + " " + DateTime.Now.Date.Year.ToString()
        txtTemplate.Text = salesinvupdpath + "ASP" + ".xlsx"
        txtOutput.Text = salesinvupdpath + "ASP as of " + currentdate + ".xlsx"
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
        SetDate()
        Me.Cursor = Cursors.WaitCursor
        ShowInvoice()
        GenerateInvoiceToExcel(salesinvupdfile)
        Me.Cursor = Cursors.Default
        MsgBox("Process is complete." + " Average Selling Price file : " + txtOutput.Text.ToString + " is generated!")
    End Sub
    Private Sub GenerateInvoiceToExcel(ByVal strFileName As String)
        Dim xl As New Excel.Application
        Dim wb As Excel.Workbook
        Dim ws As Excel.Worksheet
        Dim wsasp As Excel.Worksheet
        Dim rownumber As Integer = 0
        Dim salesinvupdout As String = txtOutput.Text.ToString
        Dim salesinvupd As String = txtTemplate.Text.ToString
        Try
            wb = xl.Workbooks.Open(strFileName)

            ws = CType(wb.Worksheets.Item("Sheet1"), Excel.Worksheet)
            wsasp = CType(wb.Worksheets.Item("ASP"), Excel.Worksheet)

            'Get Last Row number with empty ItemCode
            rownumber = GetRowNumber(ws)
            If rownumber > 0 Then
                'Loop Sales Grid
                For Each row As DataGridViewRow In dgvSales.Rows
                    If Not row.IsNewRow Then
                        With ws
                            'salescycledate   : A
                            .Range("A" & rownumber.ToString()).Value = row.Cells("salescycledate").Value.ToString
                            'divisiondesc  : B
                            .Range("B" & rownumber.ToString()).Value = row.Cells("divisiondesc").Value.ToString
                            'itemcode : C
                            .Range("C" & rownumber.ToString()).Value = row.Cells("itemcode").Value.ToString
                            '[itemdesc]     : D
                            .Range("D" & rownumber.ToString()).Value = row.Cells("itemdesc").Value.ToString
                            '[asp]      : E
                            .Range("E" & rownumber.ToString()).Value = row.Cells("asp").Value.ToString
                        End With
                        rownumber = rownumber + 1
                    End If
                Next
                'Save Sales Transaction Date To Excel to Cell A3
                'Jan - May 2014 Sales'
                wsasp.Range("A3").Value = MonthName
                'Refresh PivotTable1
                'pivot.SourceData = "SheetName!R1C1:R18C18"
                wsasp.PivotTables("PivotTable1").SourceData = "Sheet1!R1C1:R" + (rownumber - 1).ToString.Trim + "C5"
                wsasp.PivotTables("PivotTable1").RefreshTable()
            End If
            wb.SaveAs(salesinvupdout)
            wb.Close()
            xl.Quit()
            'Marshal.ReleaseComObject(wb)
            'Marshal.ReleaseComObject(xl)
            xl = Nothing

        Catch ex As Exception
            MessageBox.Show(ex.Message, "frmAverageSellingPrice.GenerateInvoiceToExcel module")
            KillExcellApp()
        Finally
        End Try
    End Sub

    Private Sub ShowInvoice()
        Try
            If RemoteDataSet.Tables("IntegratedSales").Rows.Count > 0 Then RemoteDataSet.Tables("IntegratedSales").Clear()
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance

            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate

            BusinessObject.Sub_Show(ServerPath2, "Util_AverageSellingPrice", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            LogHelper.InsertLog("frmAverageSellingPrice.ShowInvoice.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmAverageSellingPrice.ShowInvoice.Error: " & ex.Message)
        End Try
    End Sub

    Private Function GetRowNumber(ByVal ws As Excel.Worksheet) As Integer
        Dim retval As Integer = 0
        Dim salesdate As String
        Dim datepick As String = dtpMonth.Value.Month.ToString.Trim() + "/" + dtpMonth.Value.Day.ToString.Trim() + "/" + dtpMonth.Value.Year.ToString.Trim()
        Dim rowctr As Integer = 1

        While rowctr <= 1000000
            With ws
                salesdate = CStr(.Range("A" & rowctr).Text)
                If salesdate.Trim = "" Then
                    retval = rowctr
                    Exit While
                End If
                'Check for current Month, and display a message if month already exists in excel
                If salesdate = datepick Then
                    MsgBox("Sales trnsaction date : " + datepick + " already exists in report file! Please delete rows with sales transaction date in excel and re generate report!")
                    retval = 0   ' do not generate report
                End If
            End With
            rowctr = rowctr + 1
        End While
        Return retval
    End Function
End Class