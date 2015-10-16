Imports System.Data.SqlClient
Imports Microsoft
Imports Microsoft.Office.Interop
Imports System.Configuration
Imports System.Globalization
Imports System.Runtime.InteropServices
Public Class frmGenerateNMPCSalesUpdate
    Private RemoteDataSet As New DataSet
    Private RemoteDataSetCM As New DataSet
    Private RemoteDataSetInhouse As New DataSet
    Private RemoteDataSetBudget As New DataSet
    Private RemoteDataSetLY As New DataSet
    Private SalesTransDate As String
    Private totalqty As Integer = 0
    Private cmtotalqty As Integer = 0
    Private totalqtyinhouse As Integer = 0
    Private totalamtinhouse As Integer = 0
    Private totalamt As Double = 0.0
    Private cmtotalamt As Double = 0.0
    Private xl As New Excel.Application
    Private wb As Excel.Workbook
    Private ws As Excel.Worksheet


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmGenerateNMPCSalesUpdate_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'wb.Close()
        'xl.Quit()
        'xl = Nothing
    End Sub

    Private Sub frmGenerateNMPCSalesUpdate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'txtTemplate.Text = My.Resources.DailySalesSummarybyItem.ToString
        RemoteDataSet.Tables.Add("DailySalesSummarybyItem")
        RemoteDataSetInhouse.Tables.Add("DailySalesSummarybyItemInhouse")
        RemoteDataSetCM.Tables.Add("DailySalesSummarybyItemCM")
        RemoteDataSetBudget.Tables.Add("DailySalesSummarybyItemBudget")
        RemoteDataSetLY.Tables.Add("DailySalesSummarybyItemLY")
        SetDate()
        SetPath()
    End Sub
    Private Sub ShowInvoice()
        Try
            If RemoteDataSet.Tables("DailySalesSummarybyItem").Rows.Count > 0 Then RemoteDataSet.Tables("DailySalesSummarybyItem").Clear()
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance

            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate

            BusinessObject.Sub_Show(ServerPath2, "Util_DailySalesSummarybyItem", CommandType.StoredProcedure, RemoteDataSet, "DailySalesSummarybyItem", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("DailySalesSummarybyItem")
            LogHelper.InsertLog("frmGenerateNMPCSalesUpdate.ShowInvoice.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmGenerateNMPCSalesUpdate.ShowInvoice.Error: " & ex.Message)
        End Try
    End Sub
    Private Sub ShowInhouse()
        Try
            If RemoteDataSetInhouse.Tables("DailySalesSummarybyItemInhouse").Rows.Count > 0 Then RemoteDataSetInhouse.Tables("DailySalesSummarybyItemInhouse").Clear()
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance

            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate

            BusinessObject.Sub_Show(ServerPath2, "Util_DailySalesSummarybyItemInhouse", CommandType.StoredProcedure, RemoteDataSetInhouse, "DailySalesSummarybyItemInhouse", Params)
            dgvInhouse.DataSource = RemoteDataSetInhouse.Tables("DailySalesSummarybyItemInhouse")
            LogHelper.InsertLog("frmGenerateNMPCSalesUpdate.ShowInhouse.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmGenerateNMPCSalesUpdate.ShowInhouse.Error: " & ex.Message)
        End Try
    End Sub
    Private Sub ShowBudget()
        Try
            If RemoteDataSetBudget.Tables("DailySalesSummarybyItemBudget").Rows.Count > 0 Then RemoteDataSetBudget.Tables("DailySalesSummarybyItemBudget").Clear()
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance

            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate

            BusinessObject.Sub_Show(ServerPath2, "Util_DailySalesSummarybyItemBudget", CommandType.StoredProcedure, RemoteDataSetBudget, "DailySalesSummarybyItemBudget", Params)
            dgvBudget.DataSource = RemoteDataSetBudget.Tables("DailySalesSummarybyItemBudget")
            LogHelper.InsertLog("frmGenerateNMPCSalesUpdate.ShowInBudget.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmGenerateNMPCSalesUpdate.ShowInBudget.Error: " & ex.Message)
        End Try
    End Sub
    Private Sub ShowLY()
        Try
            If RemoteDataSetLY.Tables("DailySalesSummarybyItemLY").Rows.Count > 0 Then RemoteDataSetLY.Tables("DailySalesSummarybyItemLY").Clear()
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim lastyeardate = dtpMonth.Value.Month.ToString.Trim + "/1/" + (dtpMonth.Value.Year - 1).ToString()
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = lastyeardate : Params(0) = salescycledate

            BusinessObject.Sub_Show(ServerPath2, "Util_DailySalesSummarybyItem", CommandType.StoredProcedure, RemoteDataSetLY, "DailySalesSummarybyItemLY", Params)
            dgvlastyear.DataSource = RemoteDataSetLY.Tables("DailySalesSummarybyItemLY")
            LogHelper.InsertLog("frmGenerateNMPCSalesUpdate.ShowLY.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmGenerateNMPCSalesUpdate.ShowLY.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ShowReturn()
        Try
            If RemoteDataSetCM.Tables("DailySalesSummarybyItemCM").Rows.Count > 0 Then RemoteDataSetCM.Tables("DailySalesSummarybyItemCM").Clear()
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance

            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate

            BusinessObject.Sub_Show(ServerPath2, "Util_DailySalesSummarybyItemCM", CommandType.StoredProcedure, RemoteDataSetCM, "DailySalesSummarybyItemCM", Params)
            dgvReturns.DataSource = RemoteDataSetCM.Tables("DailySalesSummarybyItemCM")
            LogHelper.InsertLog("frmGenerateNMPCSalesUpdate.ShowReturn.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmGenerateNMPCSalesUpdate.ShowReturn.Error: " & ex.Message)
        End Try
    End Sub
    Private Sub SetDate()
        Dim currentdate As String
        currentdate = dtpMonth.Value.Month.ToString + "/1/" + dtpMonth.Value.Year.ToString
        dtpMonth.Text = currentdate
    End Sub

    Private Sub SetPath()
        Dim salesinvupdpath As String = System.Configuration.ConfigurationSettings.AppSettings.Item("SalesInvUpdPath")
        Dim currentdate As String
        Dim format As String = "MMM d yyyy"
        currentdate = DateTime.Now.ToString("MMM", New CultureInfo("en-US")) + " 1 - " + DateTime.Now.Date.Day.ToString() + " " + DateTime.Now.Date.Year.ToString()
        txtTemplate.Text = salesinvupdpath + "NMPC Sales Update.xls"
        txtOutput.Text = salesinvupdpath + "NMPC Sales Update " + currentdate + ".xls"
        SalesTransDate = DateTime.Now.ToString("MMM", New CultureInfo("en-US")) + " 1 - " + DateTime.Now.Date.Day.ToString() + ", " + DateTime.Now.Date.Year.ToString()
    End Sub

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        Dim salesinvupdfile As String = txtTemplate.Text.ToString
        SetDate()
        SetPath()
        Me.Cursor = Cursors.WaitCursor
        ShowInvoice()
        GenerateInvoiceToExcel(salesinvupdfile)

        ShowReturn()
        GenerateReturnToExcel(salesinvupdfile)

        ShowBudget()
        GenerateBudgetToExcel(salesinvupdfile)

        ShowLY()
        GenerateLYToExcel(salesinvupdfile)

        ShowInhouse()
        GenerateInhouseToExcel(salesinvupdfile)

        txtTotalAmtSold.Text = String.Format("{0:N}", totalamt)
        txtTotalQuantitySold.Text = String.Format("{0:N}", totalqty)
        txtCMTotalAmount.Text = String.Format("{0:N}", cmtotalamt)
        txtCMTotalQty.Text = String.Format("{0:N}", cmtotalqty)
        txtInhouseAmt.Text = String.Format("{0:N}", totalamtinhouse)
        txtInhouseQty.Text = String.Format("{0:N}", totalqtyinhouse)
        Me.Cursor = Cursors.Default
        MsgBox("Process is complete." + " Sales Update file : " + txtOutput.Text.ToString + " is generated!")
        KillExcellApp()
    End Sub
    Private Sub GenerateInvoiceToExcel(ByVal strFileName As String)
        'Dim xl As New Excel.Application
        'Dim wb As Excel.Workbook
        'Dim ws As Excel.Worksheet
        Dim range As Excel.Range
        Dim rownumber As Integer = 0
        Dim qty As Integer = 0
        Dim bonus As Integer = 0
        Dim salesinvupdout = txtOutput.Text.ToString
        Dim salesinvupd = txtTemplate.Text.ToString
        Dim mdicode As String = ""
        Try
            wb = xl.Workbooks.Open(strFileName)
            ws = CType(wb.Worksheets.Item("Sales Update"), Excel.Worksheet)
            totalqty = 0
            totalamt = 0.0

            'Loop Sales Grid
            For Each row As DataGridViewRow In dgvSales.Rows
                If Not row.IsNewRow Then
                    'MessageBox.Show(row.Cells(0).Value.ToString & "," & row.Cells(1).Value.ToString)
                    mdicode = row.Cells("OldMDICode").Value.ToString
                    rownumber = GetRowNumber(mdicode, ws)
                    If rownumber > 0 Then
                        'Update MDI Unit,Bonus,Gross Sales
                        '.Range("A" & intLine).NumberFormat = "@"
                        '.Cells(intLine, 1) = CStr(MyResultSet("CustCode"))
                        With ws
                            .Range("D" & rownumber.ToString()).Value = row.Cells("QtySold").Value.ToString
                            .Range("E" & rownumber.ToString()).Value = row.Cells("QtyFree").Value.ToString
                            .Range("F" & rownumber.ToString()).Value = row.Cells("AmountSold").Value.ToString
                        End With
                        totalqty = totalqty + row.Cells("QtySold").Value
                        totalamt = totalamt + row.Cells("AmountSold").Value
                    Else
                        MsgBox("Unable to find Item Code : " + mdicode)
                    End If
                End If
            Next
            'xl.DisplayAlerts = False
            'wb.SaveAs(salesinvupd)
            'wb.SaveAs(salesinvupdout)
            'wb.Close()
            'xl.Quit()
            'xl = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "GenerateInvoiceToExcel module")
        Finally
        End Try
    End Sub
    Private Sub GenerateInhouseToExcel(ByVal strFileName As String)
        'Dim xl As New Excel.Application
        'Dim wb As Excel.Workbook
        'Dim ws As Excel.Worksheet
        Dim range As Excel.Range
        Dim rownumber As Integer = 0
        Dim qty As Integer = 0
        Dim bonus As Integer = 0
        Dim salesinvupdout = txtOutput.Text.ToString
        Dim salesinvupd = txtTemplate.Text.ToString
        Dim mdicode As String = ""
        Try
            'wb = xl.Workbooks.Open(strFileName)
            ws = CType(wb.Worksheets.Item("Sales Update"), Excel.Worksheet)
            totalqtyinhouse = 0
            totalamtinhouse = 0.0

            'Loop Sales Grid
            For Each row As DataGridViewRow In dgvInhouse.Rows
                If Not row.IsNewRow Then
                    'MessageBox.Show(row.Cells(0).Value.ToString & "," & row.Cells(1).Value.ToString)
                    mdicode = row.Cells("OldMDICode").Value.ToString
                    rownumber = GetRowNumber(mdicode, ws)
                    If rownumber > 0 Then
                        'Update Inhouse Unit,Bonus,Gross Sales
                        With ws
                            .Range("I" & rownumber.ToString()).Value = row.Cells("QtySold").Value.ToString
                            .Range("J" & rownumber.ToString()).Value = row.Cells("QtyFree").Value.ToString
                            .Range("K" & rownumber.ToString()).Value = row.Cells("AmountSold").Value.ToString
                        End With
                        totalqtyinhouse = totalqtyinhouse + row.Cells("QtySold").Value
                        totalamtinhouse = totalamtinhouse + row.Cells("AmountSold").Value
                    Else
                        MsgBox("Unable to find Item Code : " + mdicode)
                    End If
                End If
            Next
            xl.DisplayAlerts = False
            'do not overwrite the template wb.SaveAs(salesinvupd)
            wb.SaveAs(salesinvupdout)
            wb.Close()
            xl.Quit()
            xl = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "GenerateInhouseToExcel module")
        Finally
        End Try
    End Sub

    Private Sub GenerateReturnToExcel(ByVal strFileName As String)
        'Dim xl As New Excel.Application
        'Dim wb As Excel.Workbook
        'Dim ws As Excel.Worksheet
        Dim wssummary As Excel.Worksheet
        Dim range As Excel.Range
        Dim rownumber As Integer = 0
        Dim qty As Integer = 0
        Dim bonus As Integer = 0
        Dim salesinvupdout = txtOutput.Text.ToString
        Dim salesinvupd = txtOutput.Text.ToString
        Dim mdicode As String = ""
        Try
            'wb = xl.Workbooks.Open(strFileName)
            ws = CType(wb.Worksheets.Item("Sales Update"), Excel.Worksheet)
            wssummary = CType(wb.Worksheets.Item("Sales Summary"), Excel.Worksheet)
            cmtotalqty = 0
            cmtotalamt = 0.0

            'Loop Sales Grid
            For Each row As DataGridViewRow In dgvReturns.Rows
                If Not row.IsNewRow Then
                    'MessageBox.Show(row.Cells(0).Value.ToString & "," & row.Cells(1).Value.ToString)
                    mdicode = row.Cells("OldMDICode").Value.ToString
                    rownumber = GetRowNumber(mdicode, ws)
                    If rownumber > 0 Then
                        'Update MDI Unit Return,Gross Return
                        '.Range("A" & intLine).NumberFormat = "@"
                        '.Cells(intLine, 1) = CStr(MyResultSet("CustCode"))
                        With ws
                            .Range("G" & rownumber.ToString()).Value = row.Cells("QtySold").Value.ToString
                            .Range("H" & rownumber.ToString()).Value = row.Cells("AmountSold").Value.ToString
                        End With
                        cmtotalqty = cmtotalqty + row.Cells("QtySold").Value
                        cmtotalamt = cmtotalamt + row.Cells("AmountSold").Value
                    Else
                        MsgBox("Unable to find Item Code : " + mdicode)
                    End If
                End If
            Next
            'Save Sales Transaction Date To Excel to Cell A3
            ws.Range("A3").Value = SalesTransDate
            wssummary.Range("A1").Value = "Daily Sales Update - " + SalesTransDate
            'xl.DisplayAlerts = False
            'wb.SaveAs(salesinvupd)
            'wb.SaveAs(salesinvupdout)
            'wb.Close()
            'xl.Quit()
            'xl = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "GenerateReturnToExcel module")
        Finally
        End Try
    End Sub
    Private Sub GenerateBudgetToExcel(ByVal strFileName As String)
        Dim wssummary As Excel.Worksheet
        Dim range As Excel.Range
        Dim rownumber As Integer = 0
        Dim qty As Integer = 0
        Dim bonus As Integer = 0
        Dim salesinvupdout = txtOutput.Text.ToString
        Dim salesinvupd = txtOutput.Text.ToString
        Dim mdicode As String = ""
        Try
            'wb = xl.Workbooks.Open(strFileName)
            ws = CType(wb.Worksheets.Item("Sales Update"), Excel.Worksheet)
            wssummary = CType(wb.Worksheets.Item("Sales Summary"), Excel.Worksheet)
            cmtotalqty = 0
            cmtotalamt = 0.0

            'Loop Sales Grid
            For Each row As DataGridViewRow In dgvBudget.Rows
                If Not row.IsNewRow Then
                    'MessageBox.Show(row.Cells(0).Value.ToString & "," & row.Cells(1).Value.ToString)
                    mdicode = row.Cells("OldMDICode").Value.ToString
                    rownumber = GetRowNumber(mdicode, ws)
                    If rownumber > 0 Then
                        'Update MDI Unit Return,Gross Return
                        '.Range("A" & intLine).NumberFormat = "@"
                        '.Cells(intLine, 1) = CStr(MyResultSet("CustCode"))
                        With ws
                            .Range("T" & rownumber.ToString()).Value = row.Cells("qty").Value.ToString
                            .Range("U" & rownumber.ToString()).Value = row.Cells("amount").Value.ToString
                        End With
                    Else
                        MsgBox("Unable to find Item Code : " + mdicode)
                    End If
                End If
            Next
            'Save Sales Transaction Date To Excel to Cell A3
            'ws.Range("A3").Value = SalesTransDate
            'wssummary.Range("A1").Value = "Daily Sales Update - " + SalesTransDate 
        Catch ex As Exception
            MessageBox.Show(ex.Message, "GenerateBudgetToExcel module")
        Finally
        End Try
    End Sub
    Private Sub GenerateLYToExcel(ByVal strFileName As String)
        Dim wssummary As Excel.Worksheet
        Dim range As Excel.Range
        Dim rownumber As Integer = 0
        Dim qty As Integer = 0
        Dim bonus As Integer = 0
        Dim salesinvupdout = txtOutput.Text.ToString
        Dim salesinvupd = txtOutput.Text.ToString
        Dim mdicode As String = ""
        Try
            ws = CType(wb.Worksheets.Item("Sales Update"), Excel.Worksheet)
            wssummary = CType(wb.Worksheets.Item("Sales Summary"), Excel.Worksheet)

            'Loop Sales Grid
            For Each row As DataGridViewRow In dgvlastyear.Rows
                If Not row.IsNewRow Then
                    mdicode = row.Cells("OldMDICode").Value.ToString
                    rownumber = GetRowNumber(mdicode, ws)
                    If rownumber > 0 Then
                        With ws
                            .Range("X" & rownumber.ToString()).Value = row.Cells("QtySold").Value.ToString
                            .Range("Y" & rownumber.ToString()).Value = row.Cells("QtyFree").Value.ToString
                            .Range("Z" & rownumber.ToString()).Value = row.Cells("AmountSold").Value.ToString
                        End With
                    Else
                        MsgBox("Unable to find Item Code : " + mdicode)
                    End If
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "GenerateLYToExcel module")
        Finally
        End Try
    End Sub
    Private Function GetRowNumber(ByVal mdicode As String, ByVal ws As Excel.Worksheet) As Integer
        Dim retval As Integer = 0
        Dim code As String
        Dim rowctr = 11

        While rowctr <= 400
            With ws
                code = CStr(.Range("A" & rowctr).Text)
                If code.Trim = mdicode.Trim Then
                    retval = rowctr
                    Exit While
                End If
            End With
            rowctr = rowctr + 1
        End While
        Return retval
    End Function

End Class