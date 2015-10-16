Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports Microsoft
Imports Microsoft.Office.Interop
Imports System.Configuration
Imports System.Globalization
Imports System.IO
Imports System.Runtime.InteropServices
Public Class frmCalendarizedItemSales

    Private RemoteDataSet As New DataSet
    Private RemoteDataSetCM As New DataSet
    Private RemoteDataSetBudget As New DataSet
    Private SalesTransDate As String
    Private totalqty As Integer = 0
    Private cmtotalqty As Integer = 0
    Private totalqtyBudget As Integer = 0
    Private totalamtBudget As Integer = 0
    Private totalamt As Double = 0.0
    Private cmtotalamt As Double = 0.0
    Private ytdasof As String = ""
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmGenerateNMPCSalesUpdate_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'wb.Close()
        'xl.Quit()
        'xl = Nothing
    End Sub

    Private Sub frmGenerateNMPCSalesUpdate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RemoteDataSet.Tables.Add("DailySalesSummarybyItem")
        RemoteDataSetBudget.Tables.Add("DailySalesSummarybyItemBudget")
        RemoteDataSetCM.Tables.Add("DailySalesSummarybyItemCM")
        SetDate()
        SetPath()
    End Sub
    Private Sub ShowInvoice()
        Try
            If RemoteDataSet.Tables("DailySalesSummarybyItem").Rows.Count > 0 Then RemoteDataSet.Tables("DailySalesSummarybyItem").Clear()
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance

            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate

            BusinessObject.Sub_Show(ServerPath2, "Util_Calendarized_Sales", CommandType.StoredProcedure, RemoteDataSet, "DailySalesSummarybyItem", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("DailySalesSummarybyItem")
            LogHelper.InsertLog("frmCalendarizedItemSales.ShowInvoice.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmCalendarizedItemSales.ShowInvoice.Error: " & ex.Message)
        End Try
    End Sub
    Private Sub ShowBudget()
        Try
            If RemoteDataSetBudget.Tables("DailySalesSummarybyItemBudget").Rows.Count > 0 Then RemoteDataSetBudget.Tables("DailySalesSummarybyItemBudget").Clear()
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance

            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate

            BusinessObject.Sub_Show(ServerPath2, "Util_Calendarized_Budget", CommandType.StoredProcedure, RemoteDataSetBudget, "DailySalesSummarybyItemBudget", Params)
            dgvBudget.DataSource = RemoteDataSetBudget.Tables("DailySalesSummarybyItemBudget")
            LogHelper.InsertLog("frmCalendarizedItemSales.ShowBudget.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmCalendarizedItemSales.ShowBudget.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ShowReturn()
        Try
            If RemoteDataSetCM.Tables("DailySalesSummarybyItemCM").Rows.Count > 0 Then RemoteDataSetCM.Tables("DailySalesSummarybyItemCM").Clear()
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance

            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate

            BusinessObject.Sub_Show(ServerPath2, "Util_Calendarized_Returns", CommandType.StoredProcedure, RemoteDataSetCM, "DailySalesSummarybyItemCM", Params)
            dgvReturns.DataSource = RemoteDataSetCM.Tables("DailySalesSummarybyItemCM")
            LogHelper.InsertLog("frmCalendarizedItemSales.ShowReturn.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmCalendarizedItemSales.ShowReturn.Error: " & ex.Message)
        End Try
    End Sub
    Private Sub SetDate()
        Dim currentdate As String
        currentdate = dtpMonth.Value.Month.ToString + "/1/" + dtpMonth.Value.Year.ToString
        dtpMonth.Text = currentdate
        '"Year-to-Date as of May, 2014"
        ytdasof = "Year-to-Date as of May, 2014" + dtpMonth.Value.ToString("MMM", New CultureInfo("en-US")) + dtpMonth.Value.Year.ToString

    End Sub

    Private Sub SetPath()
        Dim salesinvupdpath As String = System.Configuration.ConfigurationSettings.AppSettings.Item("CalendarizedReportPath")
        Dim currentdate As String
        Dim format As String = "MMM d yyyy"
        currentdate = DateTime.Now.ToString("MMM", New CultureInfo("en-US")) + " 1 - " + DateTime.Now.Date.Day.ToString() + " " + DateTime.Now.Date.Year.ToString()
        txtTemplate.Text = salesinvupdpath + "Calendarized Item Sales (Actual Direct).xls"
        txtOutput.Text = salesinvupdpath + "Calendarized Item Sales (Actual Direct) " + currentdate + ".xls"
        SalesTransDate = DateTime.Now.ToString("MMM", New CultureInfo("en-US")) + " 1 - " + DateTime.Now.Date.Day.ToString() + ", " + DateTime.Now.Date.Year.ToString()
    End Sub

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        Dim salesinvupdfile As String = txtTemplate.Text.ToString
        'SetDate()
        SetPath()
        Me.Cursor = Cursors.WaitCursor
        'Generate Sales
        ShowInvoice()
        GenerateInvoiceToExcel(salesinvupdfile)

        'Generate Budget
        ShowBudget()
        GenerateBudgetToExcel(salesinvupdfile)

        'Generate Returns
        ShowReturn()
        GenerateReturnToExcel(salesinvupdfile)

        txtTotalAmtSold.Text = String.Format("{0:N}", totalamt)
        txtTotalQuantitySold.Text = String.Format("{0:N}", totalqty)
        txtCMTotalAmount.Text = String.Format("{0:N}", cmtotalamt)
        txtCMTotalQty.Text = String.Format("{0:N}", cmtotalqty)
        txtBudgetAmt.Text = String.Format("{0:N}", totalamtBudget)
        txtBudgetQty.Text = String.Format("{0:N}", totalqtyBudget)
        Me.Cursor = Cursors.Default
        MsgBox("Process is complete." + " Sales Update file : " + txtOutput.Text.ToString + " is generated!")
        KillExcellApp()
    End Sub
    Private Sub GenerateInvoiceToExcel(ByVal strFileName As String)
        Dim xl As New Excel.Application
        Dim wb As Excel.Workbook
        Dim ws As Excel.Worksheet
        Dim range As Excel.Range
        Dim rownumber As Integer = 0
        Dim qty As Integer = 0
        Dim bonus As Integer = 0
        Dim salesinvupdout = txtOutput.Text.ToString
        Dim salesinvupd = txtTemplate.Text.ToString
        Dim itemcode As String = ""
        Dim rangesalesqty As String = ""
        Dim rangebonusqty As String = ""
        Dim rangesalesamt As String = ""
        Try
            wb = xl.Workbooks.Open(strFileName)
            ws = CType(wb.Worksheets.Item("YTD Sales"), Excel.Worksheet)
            totalqty = 0
            totalamt = 0.0

            'Loop Sales Grid
            For Each row As DataGridViewRow In dgvSales.Rows
                If Not row.IsNewRow Then
                    'MessageBox.Show(row.Cells(0).Value.ToString & "," & row.Cells(1).Value.ToString)
                    itemcode = row.Cells("itemcode").Value.ToString
                    rownumber = GetRowNumber(itemcode, ws)
                    If rownumber > 0 Then
                        'Update MDI Unit,Bonus,Gross Sales
                        With ws
                            rangesalesqty = GetSalesQtyColumn()
                            rangebonusqty = GetBonusQtyColumn()
                            rangesalesamt = GetSalesAmtColumn()

                            .Range(rangesalesqty & rownumber.ToString()).Value = row.Cells("QtySold").Value.ToString
                            .Range(rangebonusqty & rownumber.ToString()).Value = row.Cells("Free").Value.ToString
                            .Range(rangesalesamt & rownumber.ToString()).Value = row.Cells("Amount").Value.ToString
                        End With
                        totalqty = totalqty + row.Cells("QtySold").Value
                        totalamt = totalamt + row.Cells("Amount").Value
                    Else
                        MsgBox("Unable to find Item Code : " + itemcode)
                    End If
                End If
            Next
            xl.DisplayAlerts = False
            wb.SaveAs(salesinvupd)
            wb.SaveAs(salesinvupdout)
            wb.Close()
            xl.Quit()
            'Marshal.ReleaseComObject(wb)
            'Marshal.ReleaseComObject(xl)
            xl = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "GenerateInvoiceToExcel module")
        Finally
        End Try
    End Sub
    Private Sub GenerateBudgetToExcel(ByVal strFileName As String)
        Dim xl As New Excel.Application
        Dim wb As Excel.Workbook
        Dim ws As Excel.Worksheet
        Dim range As Excel.Range
        Dim rownumber As Integer = 0
        Dim qty As Integer = 0
        Dim bonus As Integer = 0
        Dim salesinvupdout = txtOutput.Text.ToString
        Dim salesinvupd = txtTemplate.Text.ToString
        Dim itemcode As String = ""
        Dim rangebudgetqty As String = ""
        Dim rangebudgetamt As String = ""
        Try
            wb = xl.Workbooks.Open(strFileName)
            ws = CType(wb.Worksheets.Item("YTD Sales"), Excel.Worksheet)
            totalqtyBudget = 0
            totalamtBudget = 0.0

            'Loop Sales Grid
            For Each row As DataGridViewRow In dgvBudget.Rows
                If Not row.IsNewRow Then
                    'MessageBox.Show(row.Cells(0).Value.ToString & "," & row.Cells(1).Value.ToString)
                    itemcode = row.Cells("itemcode").Value.ToString
                    rownumber = GetRowNumber(itemcode, ws)
                    If rownumber > 0 Then
                        'Update Budget Unit,Gross Sales
                        rangebudgetqty = GetBudgetQtyColumn()
                        rangebudgetamt = GetBudgetAmtColumn()
                        With ws
                            .Range(rangebudgetqty & rownumber.ToString()).Value = row.Cells("Qty").Value.ToString
                            .Range(rangebudgetamt & rownumber.ToString()).Value = row.Cells("Amount").Value.ToString
                        End With
                        totalqtyBudget = totalqtyBudget + row.Cells("Qty").Value
                        totalamtBudget = totalamtBudget + row.Cells("Amount").Value
                    Else
                        MsgBox("Unable to find Item Code : " + itemcode)
                    End If
                End If
            Next
            xl.DisplayAlerts = False
            wb.SaveAs(salesinvupd)
            wb.SaveAs(salesinvupdout)
            wb.Close()
            xl.Quit()
            xl = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "GenerateBudgetToExcel module")
        Finally
        End Try
    End Sub

    Private Sub GenerateReturnToExcel(ByVal strFileName As String)
        Dim xl As New Excel.Application
        Dim wb As Excel.Workbook
        Dim ws As Excel.Worksheet
        Dim range As Excel.Range
        Dim rownumber As Integer = 0
        Dim qty As Integer = 0
        Dim bonus As Integer = 0
        Dim salesinvupdout = txtOutput.Text.ToString
        Dim salesinvupd = txtOutput.Text.ToString
        Dim itemcode As String = ""
        Dim rangereturnamt As String = ""
        Try
            wb = xl.Workbooks.Open(strFileName)
            ws = CType(wb.Worksheets.Item("YTD Sales"), Excel.Worksheet)
            cmtotalqty = 0
            cmtotalamt = 0.0

            'Loop Sales Grid
            For Each row As DataGridViewRow In dgvReturns.Rows
                If Not row.IsNewRow Then
                    'MessageBox.Show(row.Cells(0).Value.ToString & "," & row.Cells(1).Value.ToString)
                    itemcode = row.Cells("itemcode").Value.ToString
                    rownumber = GetRowNumber(itemcode, ws)
                    If rownumber > 0 Then
                        'Update MDI Unit Return,Gross Return
                        rangereturnamt = GetReturnsAmtColumn()

                        With ws
                            .Range(rangereturnamt & rownumber.ToString()).Value = row.Cells("Amount").Value.ToString
                        End With
                        cmtotalamt = cmtotalamt + row.Cells("Amount").Value
                    Else
                        MsgBox("Unable to find Item Code : " + itemcode)
                    End If
                End If
            Next

            ws.Range("A4").Value = ytdasof
            xl.DisplayAlerts = False
            wb.SaveAs(salesinvupd)
            wb.SaveAs(salesinvupdout)
            wb.Close()
            xl.Quit()
            xl = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Extract_ExcelFileData module")
        Finally
        End Try
    End Sub

    Private Function GetRowNumber(ByVal itemcode As String, ByVal ws As Excel.Worksheet) As Integer
        Dim retval As Integer = 0
        Dim code As String
        Dim rowctr = 11

        While rowctr <= 400
            With ws
                code = CStr(.Range("A" & rowctr).Text)
                If code.Trim = itemcode.Trim Then
                    retval = rowctr
                    Exit While
                End If
            End With
            rowctr = rowctr + 1
        End While
        Return retval
    End Function

    Private Function GetSalesQtyColumn()
        Dim budgetmonth As Integer = dtpMonth.Value.Month
        Dim retval As String = ""
        Select Case budgetmonth
            Case 1
                retval = "D"
            Case 2
                retval = "S"
            Case 3
                retval = "AH"
            Case 4
                retval = "AW"
            Case 5
                retval = "BL"
            Case 6
                retval = "CA"
            Case 7
                retval = "CP"
            Case 8
                retval = "DE"
            Case 9
                retval = "DT"
            Case 10
                retval = "EI"
            Case 11
                retval = "EX"
            Case 12
                retval = "FM"
            Case Else
                MsgBox("Month not between 1 and 12, inclusive")
        End Select
        Return retval
    End Function
    Private Function GetBonusQtyColumn()
        Dim budgetmonth As Integer = dtpMonth.Value.Month
        Dim retval As String = ""
        Select Case budgetmonth
            Case 1
                retval = "E"
            Case 2
                retval = "T"
            Case 3
                retval = "AI"
            Case 4
                retval = "AX"
            Case 5
                retval = "BM"
            Case 6
                retval = "CB"
            Case 7
                retval = "CQ"
            Case 8
                retval = "DF"
            Case 9
                retval = "DU"
            Case 10
                retval = "EJ"
            Case 11
                retval = "EY"
            Case 12
                retval = "FN"
            Case Else
                MsgBox("Month not between 1 and 12, inclusive")
        End Select
        Return retval
    End Function
    Private Function GetSalesAmtColumn()
        Dim budgetmonth As Integer = dtpMonth.Value.Month
        Dim retval As String = ""
        Select Case budgetmonth
            Case 1
                retval = "F"
            Case 2
                retval = "U"
            Case 3
                retval = "AJ"
            Case 4
                retval = "AY"
            Case 5
                retval = "BN"
            Case 6
                retval = "CC"
            Case 7
                retval = "CR"
            Case 8
                retval = "DG"
            Case 9
                retval = "DV"
            Case 10
                retval = "EK"
            Case 11
                retval = "EZ"
            Case 12
                retval = "FO"
            Case Else
                MsgBox("Month not between 1 and 12, inclusive")
        End Select
        Return retval
    End Function
    Private Function GetBudgetQtyColumn()
        Dim budgetmonth As Integer = dtpMonth.Value.Month
        Dim retval As String = ""
        Select Case budgetmonth
            Case 1
                retval = "G"
            Case 2
                retval = "V"
            Case 3
                retval = "AK"
            Case 4
                retval = "AZ"
            Case 5
                retval = "BO"
            Case 6
                retval = "CD"
            Case 7
                retval = "CS"
            Case 8
                retval = "DH"
            Case 9
                retval = "DW"
            Case 10
                retval = "EL"
            Case 11
                retval = "FA"
            Case 12
                retval = "FP"
            Case Else
                MsgBox("Month not between 1 and 12, inclusive")
        End Select
        Return retval
    End Function
    Private Function GetBudgetAmtColumn()
        Dim budgetmonth As Integer = dtpMonth.Value.Month
        Dim retval As String = ""
        Select Case budgetmonth
            Case 1
                retval = "H"
            Case 2
                retval = "W"
            Case 3
                retval = "AL"
            Case 4
                retval = "BA"
            Case 5
                retval = "BP"
            Case 6
                retval = "CE"
            Case 7
                retval = "CT"
            Case 8
                retval = "DI"
            Case 9
                retval = "DX"
            Case 10
                retval = "EM"
            Case 11
                retval = "FB"
            Case 12
                retval = "FQ"
            Case Else
                MsgBox("Month not between 1 and 12, inclusive")
        End Select
        Return retval
    End Function

    Private Function GetReturnsAmtColumn()
        Dim budgetmonth As Integer = dtpMonth.Value.Month
        Dim retval As String = ""
        Select Case budgetmonth
            Case 1
                retval = "K"
            Case 2
                retval = "Z"
            Case 3
                retval = "AO"
            Case 4
                retval = "BD"
            Case 5
                retval = "BS"
            Case 6
                retval = "CH"
            Case 7
                retval = "CW"
            Case 8
                retval = "DL"
            Case 9
                retval = "EA"
            Case 10
                retval = "EP"
            Case 11
                retval = "FE"
            Case 12
                retval = "FT"
            Case Else
                MsgBox("Month not between 1 and 12, inclusive")
        End Select
        Return retval
    End Function
End Class