Imports System.Data.SqlClient
Imports Microsoft
Imports Microsoft.Office.Interop
Imports System.Configuration
Imports System.Globalization
Imports System.Runtime.InteropServices
Public Class frmGenerateInvoiceList
    Private SalesTransDate As String = ""
    Private RemoteDataSet As New DataSet
    Private Sub SetDate()
        Dim currentdate As String
        currentdate = dtpMonth.Value.Month.ToString + "/1/" + dtpMonth.Value.Year.ToString
        dtpMonth.Text = currentdate
    End Sub

    Private Sub SetPath()
        Dim salesinvupdpath As String = System.Configuration.ConfigurationSettings.AppSettings.Item("SalesInvUpdPath")
        Dim currentdate As String
        Dim format As String = "MMM d yyyy"
        'Metro Drug Invoice List as of Jun 18, 2014.xls
        currentdate = DateTime.Now.ToString("MMM", New CultureInfo("en-US")) + " 1 - " + DateTime.Now.Date.Day.ToString() + " " + DateTime.Now.Date.Year.ToString()
        txtTemplate.Text = salesinvupdpath + "Invoice\Metro Drug Invoice List.xls"
        txtOutput.Text = salesinvupdpath + "Invoice\Metro Drug Invoice List as of " + currentdate + ".xls"
        'SalesTransDate = DateTime.Now.ToString("MMM", New CultureInfo("en-US")) + " 1 - " + DateTime.Now.Date.Day.ToString() + ", " + DateTime.Now.Date.Year.ToString()
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
        MsgBox("Process is complete." + " Invoice List file : " + txtOutput.Text.ToString + " is generated!")
        KillExcellApp()
    End Sub
    Private Sub GenerateInvoiceToExcel(ByVal strFileName As String)
        Dim xl As New Excel.Application
        Dim wb As Excel.Workbook
        Dim ws As Excel.Worksheet
        Dim wssalestrend As Excel.Worksheet
        Dim range As Excel.Range
        Dim rownumber As Integer = 7
        Dim salesinvupdout As String = txtOutput.Text.ToString
        Dim salesinvupd As String = txtTemplate.Text.ToString
        Try
            wb = xl.Workbooks.Open(strFileName)

            ws = CType(wb.Worksheets.Item("Invoice List"), Excel.Worksheet)
            wssalestrend = CType(wb.Worksheets.Item("Daily Sales Trend"), Excel.Worksheet)

            'Loop Sales Grid
            For Each row As DataGridViewRow In dgvSales.Rows
                If Not row.IsNewRow Then
                    '.Range("A" & intLine).NumberFormat = "@"
                    '.Cells(intLine, 1) = CStr(MyResultSet("CustCode"))
                    With ws
                        'Invoice No    : A7
                        .Range("A" & rownumber.ToString()).Value = row.Cells("refcode").Value.ToString
                        'Invoice Date  : B7
                        .Range("B" & rownumber.ToString()).Value = row.Cells("refdate").Value.ToString
                        'Customer Name : C7
                        .Range("C" & rownumber.ToString()).Value = row.Cells("customername").Value.ToString
                        'Address1      : D7
                        .Range("D" & rownumber.ToString()).Value = row.Cells("address1").Value.ToString
                        'Address2      : E7
                        .Range("E" & rownumber.ToString()).Value = row.Cells("address2").Value.ToString
                        'Code          : F7
                        .Range("F" & rownumber.ToString()).Value = row.Cells("itemcode").Value.ToString
                        'Item Desc     : G7
                        .Range("G" & rownumber.ToString()).Value = row.Cells("ItemDesc").Value.ToString
                        'QtySold       : H7
                        .Range("H" & rownumber.ToString()).Value = row.Cells("qtysold").Value.ToString
                        'Bonus         : I7
                        .Range("I" & rownumber.ToString()).Value = row.Cells("qtyfree").Value.ToString
                        'Amount        : J7
                        .Range("J" & rownumber.ToString()).Value = row.Cells("amountsold").Value.ToString
                        'SO Date       : K7
                        .Range("K" & rownumber.ToString()).Value = row.Cells("sodate").Value.ToString
                        'Lot Number    : L7
                        .Range("L" & rownumber.ToString()).Value = row.Cells("lotnumber").Value.ToString
                        'Expiry Date   : M7
                        .Range("M" & rownumber.ToString()).Value = row.Cells("expirydate").Value.ToString
                        'CM Code       : N7
                        .Range("N" & rownumber.ToString()).Value = row.Cells("cmcode").Value.ToString
                    End With
                    rownumber = rownumber + 1
                End If
            Next
            'Create Sub Total
            Dim subtotalrange As String = "A7:N" + rownumber.ToString.Trim()
            With ws
                '.Range(subtotalrange).Subtotal(GroupBy:=2, Function:=Excel.XlConsolidationFunction.xlSum, TotalList:=New Int32() {8, 9, 10}, Replace:=True, PageBreaks:=False, SummaryBelowData:=True)
                .Range(subtotalrange).Subtotal(GroupBy:=2, Function:=Excel.XlConsolidationFunction.xlSum, TotalList:=New Int32() {8, 9, 10}, Replace:=True, PageBreaks:=False, SummaryBelowData:=True)
            End With
            'Update Sales Trend
            UpdateSalesTrend(wssalestrend)

            'Save Sales Transaction Date To Excel to Cell A3
            ws.Range("A3").Value = SalesTransDate

            wb.SaveAs(salesinvupdout)
            wb.Close()
            xl.Quit()
            'Marshal.ReleaseComObject(wb)
            'Marshal.ReleaseComObject(xl)
            xl = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "frmGenerateInvoiceList.GenerateInvoiceToExcel module")
        Finally
        End Try
    End Sub

    Private Sub ShowInvoice()
        Try
            If RemoteDataSet.Tables("IntegratedSales").Rows.Count > 0 Then RemoteDataSet.Tables("IntegratedSales").Clear()
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance

            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate

            BusinessObject.Sub_Show(ServerPath2, "Util_InvoiceList", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            LogHelper.InsertLog("frmGenerateInvoiceList.ShowInvoice.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmGenerateInvoiceList.ShowInvoice.Error: " & ex.Message)
        End Try
    End Sub
    Private Sub UpdateSalesTrend(ByVal ws As Excel.Worksheet)
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim TempDS As New DataSet
        Dim rownumber As Integer = 3
        Dim runningtotal As Double = 0.0
        Dim lastday As Integer = 0

        Dim Params(0) As SqlParameter
        Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
        Dim chartRange As Excel.Range

        Try
            TempDS.Tables.Add("TotalPerDay")
            BusinessObject.Sub_Show(ServerPath2, "Util_InvoiceListTotalPerDay", CommandType.StoredProcedure, TempDS, "TotalPerDay", Params)
            For Each row As DataRow In TempDS.Tables("TotalPerDay").Rows
                With ws
                    'Day : A3
                    .Range("A" & rownumber.ToString()).Value = row("refdate")
                    lastday = row("refdate")
                    'Daily Sales : B3
                    .Range("B" & rownumber.ToString()).Value = row("amountsold")
                    'Total Sales
                    runningtotal = runningtotal + row("amountsold")
                    .Range("C" & rownumber.ToString()).Value = runningtotal
                End With
                rownumber = rownumber + 1
            Next
            'Update Chart Range A3:C + rownumber
            SalesTransDate = DateTime.Now.ToString("MMM", New CultureInfo("en-US")) + " 1 - " + lastday.ToString() + ", " + DateTime.Now.Date.Year.ToString()
            With ws
                chartRange = .Range("A2", "C" + (rownumber - 1).ToString().Trim())
                .ChartObjects(1).Chart.SetSourceData(Source:=chartRange)
                .ChartObjects(1).Chart.ChartTitle.Text = "Daily Sales Trend " & vbCrLf & SalesTransDate
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmGenerateInvoiceList.UpdateSalesTrend.Error: " & ex.Message)
        Finally
            TempDS = Nothing
            BusinessObject = Nothing
        End Try
    End Sub
End Class
