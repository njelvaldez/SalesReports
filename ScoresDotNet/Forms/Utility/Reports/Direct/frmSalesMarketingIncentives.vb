Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports Microsoft
Imports Microsoft.Office.Interop
Imports System.Configuration
Imports System.Globalization
Imports System.IO
Imports System.Runtime.InteropServices
Public Class frmSalesMarketingIncentives_vb
    Private RemoteDataSet As New DataSet
    Private MonthName As String = ""
    Private xl As New Excel.Application
    Private wb As Excel.Workbook
    Private ws As Excel.Worksheet
    Private previousmonth As String = ""
    Private currentmonthyear = ""
    Private previousmonthyear = ""
    Private Sub SetDate()
        Dim currentdate As String
        Dim prevmonth As DateTime = DateAdd(DateInterval.Month, -1, dtpMonth.Value)
        currentdate = dtpMonth.Value.Month.ToString + "/1/" + dtpMonth.Value.Year.ToString
        currentmonthyear = dtpMonth.Value.ToString("MMM", New CultureInfo("en-US")) + " " + dtpMonth.Value.Year.ToString
        If (dtpMonth.Value.Month > 1) Then
            previousmonth = Convert.ToString(dtpMonth.Value.Month - 1).ToString + "/1/" + dtpMonth.Value.Year.ToString
            previousmonthyear = prevmonth.ToString("MMM", New CultureInfo("en-US")) + " " + dtpMonth.Value.Year.ToString
        Else
            previousmonth = "12/" + dtpMonth.Value.Day.ToString + "/" + (dtpMonth.Value.Year - 1).ToString
            previousmonthyear = "Dec " + (dtpMonth.Value.Year - 1).ToString
        End If
        dtpMonth.Text = currentdate
        MonthName = "Jan - " + dtpMonth.Value.ToString("MMM", New CultureInfo("en-US")) + " " + dtpMonth.Value.Year.ToString() + " Sales"
    End Sub

    Private Sub SetPath()
        Dim salesinvupdpath As String = System.Configuration.ConfigurationSettings.AppSettings.Item("SalesMarketingIncentivesPath")
        Dim currentdate As String
        Dim format As String = "MMM d yyyy"
        currentdate = DateTime.Now.ToString("MMM", New CultureInfo("en-US")) + " 1 - " + DateTime.Now.Date.Day.ToString() + " " + DateTime.Now.Date.Year.ToString()
        If txtTemplate.Text.ToString.Trim = "" Then
            txtTemplate.Text = salesinvupdpath
        End If
        txtOutput.Text = txtTemplate.Text.ToString.Replace(".xls", "") + " as of " + currentdate + ".xls"
    End Sub

    Private Sub frmGenerateInvoiceList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RemoteDataSet.Tables.Add("NATIONAL")
        RemoteDataSet.Tables.Add("NATIONALBUDGET")
        RemoteDataSet.Tables.Add("ASP")
        RemoteDataSet.Tables.Add("HITTING")
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
        MsgBox("Process is complete." + " Sales Marketing Incentive file : " + txtOutput.Text.ToString + " is generated!")
        KillExcellApp()
    End Sub
    Private Sub GenerateInvoiceToExcel(ByVal strFileName As String)
        Dim xl As New Excel.Application
        Dim wb As Excel.Workbook
        Dim wssminc As Excel.Worksheet
        Dim wsnatl As Excel.Worksheet
        Dim wsasp As Excel.Worksheet
        Dim wshitting As Excel.Worksheet
        Dim salesinvupdout As String = txtOutput.Text.ToString
        Dim salesinvupd As String = txtTemplate.Text.ToString
        Dim mdicode As String = ""
        Dim itemcode As String = ""
        Dim itemdesc As String = ""
        Try
            wb = xl.Workbooks.Open(strFileName)

            wssminc = CType(wb.Worksheets.Item("S&M Incentive"), Excel.Worksheet)
            wsnatl = CType(wb.Worksheets.Item("Natl Sales Perf"), Excel.Worksheet)
            wsasp = CType(wb.Worksheets.Item("Average Selling Price"), Excel.Worksheet)
            wshitting = CType(wb.Worksheets.Item("Team Leader Hitting Target"), Excel.Worksheet)

            'This is for National Sales Performance Sheet,Copy previous month from DE to GH columns
            'Start from row 11 to 240
            For rowctr As Integer = 11 To 240
                With wsnatl
                    'If Itemcode and desc are not blank
                    itemcode = .Range("A" & rowctr.ToString()).Value
                    itemdesc = .Range("B" & rowctr.ToString()).Value
                    If itemcode <> "" And itemdesc <> "" Then
                        .Range("G" & rowctr.ToString()).Value = .Range("D" & rowctr.ToString()).Value
                        .Range("H" & rowctr.ToString()).Value = .Range("E" & rowctr.ToString()).Value
                        'lets empty cells
                        .Range("D" & rowctr.ToString()).Value = ""
                        .Range("E" & rowctr.ToString()).Value = ""
                    End If
                End With
            Next

            'Loop Sales Grid
            Dim rownumber As Integer = 0
            For Each row As DataGridViewRow In dgvSales.Rows
                If Not row.IsNewRow Then
                    mdicode = row.Cells("itemcode").Value.ToString
                    itemdesc = row.Cells("itemdesc").Value.ToString
                    rownumber = GetRowNumber(mdicode, wsnatl)
                    If rownumber > 0 Then
                        With wsnatl
                            'Sales Amount
                            .Range("D" & rownumber.ToString()).Value = row.Cells("Amount").Value.ToString
                        End With
                    Else
                        MsgBox("Unable to find Item Code : " + mdicode + vbCrLf + " Item Desc : " + itemdesc)
                    End If
                End If
            Next

            'Populate National Budget
            PopulateNationalBudget(wsnatl)

            'Average Selling Price
            'Clean up Qty and Sales Column
            CleanASP(wsasp)
            'Populate Qty and Sales Column
            PopulateASP(wsasp)

            'DSM hitting target
            'Copy previous month from DE to GH columns
            'Start from row 11 to 240
            Dim tmname As String = ""
            Dim segment As String = ""
            For rowctr As Integer = 9 To 80
                With wshitting
                    'If TM and Segment are not blank
                    tmname = .Range("B" & rowctr.ToString()).Value
                    segment = .Range("C" & rowctr.ToString()).Value
                    If tmname <> "" And segment <> "" Then
                        .Range("G" & rowctr.ToString()).Value = .Range("D" & rowctr.ToString()).Value
                        .Range("H" & rowctr.ToString()).Value = .Range("E" & rowctr.ToString()).Value
                        'lets empty cells
                        .Range("D" & rowctr.ToString()).Value = ""
                        .Range("E" & rowctr.ToString()).Value = ""
                    End If
                End With
            Next

            'Populate sales and target of current month
            'Loop Sales Grid
            rownumber = 0
            For Each row As DataRow In RemoteDataSet.Tables("HITTING").Rows
                mdicode = row("supname").ToString
                rownumber = GetTMRowNumber(mdicode, wshitting)
                If rownumber > 0 Then
                    With wshitting
                        'Sales Amount
                        .Range("D" & rownumber.ToString()).Value = row("originalsales").ToString
                        .Range("E" & rownumber.ToString()).Value = row("originaltarget").ToString
                    End With
                Else
                    MsgBox("Unable to find TM Name : " + mdicode + vbCrLf + _
                           "Original Sales : " + row("originalsales").ToString + vbCrLf + _
                           "Original Target : " + row("originaltarget").ToString + vbCrLf, MsgBoxStyle.Information, "National Sales Performance")
                End If
            Next
            'Update Header or Labels
            wssminc.Range("B3").Value = dtpMonth.Text.ToString
            wssminc.Range("D6").Value = dtpMonth.Text.ToString
            wssminc.Range("E6").Value = previousmonth
            wssminc.Range("J5").Value = "Call Rate " + currentmonthyear
            wssminc.Range("K5").Value = "TMs Hitting Target-" + previousmonthyear          'TMs Hitting Target-Aug.2014

            wsnatl.Range("A3").Value = dtpMonth.Text.ToString
            wsnatl.Range("D5").Value = dtpMonth.Text.ToString
            wsnatl.Range("G5").Value = previousmonth

            'If dtpMonth.Value.Month > 1 Then
            '    wsnatl.Range("G5").Value = (dtpMonth.Value.Month - 1).ToString + "/" + dtpMonth.Value.Day.ToString + "/" + dtpMonth.Value.Year.ToString
            'Else
            '    wsnatl.Range("G5").Value = "12/" + dtpMonth.Value.Day.ToString + "/" + (dtpMonth.Value.Year - 1).ToString
            'End If

            wsasp.Range("A3").Value = dtpMonth.Text.ToString
            wsasp.Range("D5").Value = dtpMonth.Text.ToString
            wsasp.Range("F6").Value = "ASP " + previousmonthyear

            wshitting.Range("B4").Value = DateAdd(DateInterval.Month, -1, dtpMonth.Value).ToString()
            wshitting.Range("D6").Value = DateAdd(DateInterval.Month, -1, dtpMonth.Value).ToString("MMM", New CultureInfo("en-US")) + " " + dtpMonth.Value.Year.ToString
            If dtpMonth.Value.Month > 1 Then
                Dim prevmonth As DateTime = DateAdd(DateInterval.Month, -2, dtpMonth.Value)
                wshitting.Range("G6").Value = prevmonth.ToString("MMM", New CultureInfo("en-US")) + " " + dtpMonth.Value.Year.ToString
            Else
                wshitting.Range("G6").Value = "DEC " + (dtpMonth.Value.Year - 1).ToString
            End If
            xl.DisplayAlerts = False
            wb.SaveAs(salesinvupdout)
            wb.Close()
            xl.Quit()
            'Marshal.ReleaseComObject(wb)
            'Marshal.ReleaseComObject(xl)
            xl = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "frmSalesMarketingIncentives.GenerateInvoiceToExcel module")
        Finally
        End Try
    End Sub

    Private Sub ShowInvoice()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim ParamsHitting(0) As SqlParameter
            Dim ParamsASP(0) As SqlParameter
            Dim ParamsNatlBudget(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            Dim salescycledatehitting As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledatehitting.Direction = ParameterDirection.Input : salescycledatehitting.Value = DateAdd(DateInterval.Month, -1, dtpMonth.Value) : ParamsHitting(0) = salescycledatehitting
            Dim salescycledateasp As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledateasp.Direction = ParameterDirection.Input : salescycledateasp.Value = dtpMonth.Value : ParamsASP(0) = salescycledateasp
            Dim salescycledatebudget As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledatebudget.Direction = ParameterDirection.Input : salescycledatebudget.Value = dtpMonth.Value : ParamsNatlBudget(0) = salescycledatebudget
            BusinessObject.Sub_Show(ServerPath2, "Util_SalesMarketingItem", CommandType.StoredProcedure, RemoteDataSet, "NATIONAL", Params)
            BusinessObject.Sub_Show(ServerPath2, "Util_SalesMarketingASP", CommandType.StoredProcedure, RemoteDataSet, "ASP", ParamsASP)
            BusinessObject.Sub_Show(ServerPath2, "Util_DSMHittingTarget", CommandType.StoredProcedure, RemoteDataSet, "HITTING", ParamsHitting)
            BusinessObject.Sub_Show(ServerPath2, "Util_Calendarized_Budget", CommandType.StoredProcedure, RemoteDataSet, "NATIONALBUDGET", ParamsNatlBudget)
            dgvSales.DataSource = RemoteDataSet.Tables("NATIONAL")
            LogHelper.InsertLog("frmSalesMarketingIncentives.ShowInvoice.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmSalesMarketingIncentives.ShowInvoice.Error: " & ex.Message)
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
    Private Function GetRowNumberDivCode(ByVal mdicode As String, ByVal ws As Excel.Worksheet, divcd As String) As Integer
        Dim retval As Integer = 0
        Dim code As String
        Dim divcode As String = ""
        Dim rowctr = 11

        While rowctr <= 400
            With ws
                code = CStr(.Range("A" & rowctr).Text)
                divcode = CStr(.Range("M" & rowctr).Text)
                If code.Trim = mdicode.Trim And divcode.Trim = divcd.Trim Then
                    retval = rowctr
                    Exit While
                End If
            End With
            rowctr = rowctr + 1
        End While
        Return retval
    End Function

    Private Function GetTMRowNumber(ByVal tmname As String, ByVal ws As Excel.Worksheet) As Integer
        Dim retval As Integer = 0
        Dim code As String
        Dim rowctr = 9

        While rowctr <= 400
            With ws
                code = CStr(.Range("B" & rowctr).Text)
                code = code.Replace(" ", "").Replace(",", "").Replace(".", "")
                tmname = tmname.Replace(" ", "").Replace(",", "").Replace(".", "")
                If code.Trim = tmname.Trim Then
                    retval = rowctr
                    Exit While
                End If
            End With
            rowctr = rowctr + 1
        End While
        Return retval
    End Function
    'Clean up Qty and Sales Column
    Private Sub CleanASP(ByVal wsasp As Excel.Worksheet)
        Dim retval As Integer = 0
        Dim code As String = ""
        Dim desc As String = ""
        Dim rowctr = 11

        While rowctr <= 400
            With wsasp
                code = CStr(.Range("A" & rowctr).Text)
                desc = CStr(.Range("B" & rowctr).Text)
                If code.Trim <> "" And desc.Trim <> "" Then
                    .Range("D" & rowctr.ToString()).Value = ""
                    .Range("E" & rowctr.ToString()).Value = ""
                End If
            End With
            rowctr = rowctr + 1
        End While
    End Sub
    'Populate Qty and Sales Column
    Private Sub PopulateASP(ByVal wsasp As Excel.Worksheet)
        'Loop Sales Grid
        Dim rownumber As Integer = 0
        Dim mdicode As String = ""
        Dim itemdesc As String = ""
        For Each row As DataRow In RemoteDataSet.Tables("ASP").Rows
            mdicode = row("itemcode").ToString
            itemdesc = row("itemdesc").ToString
            rownumber = GetRowNumber(mdicode, wsasp)
            If rownumber > 0 Then
                With wsasp
                    'Sales Qty,Amount
                    .Range("D" & rownumber.ToString()).Value = row("QtySold").ToString
                    .Range("E" & rownumber.ToString()).Value = row("Amount").ToString
                End With
            Else
                MsgBox("Unable to find Item Code : " + mdicode + vbCrLf + "Item Desc : " + itemdesc, MsgBoxStyle.Information, "Average Selling Price")
            End If
        Next
    End Sub

    'Populate National Budget
    Private Sub PopulateNationalBudget(ByVal wsntl As Excel.Worksheet)
        'Loop Sales Grid
        Dim rownumber As Integer = 0
        Dim mdicode As String = ""
        Dim itemdesc As String = ""
        Dim divcode As String = ""
        For Each row As DataRow In RemoteDataSet.Tables("NATIONALBUDGET").Rows
            mdicode = row("itemcode").ToString
            itemdesc = row("itemdesc").ToString
            divcode = row("divcode").ToString
            'modified by angelo 02122015, rownumber = GetRowNumber(mdicode, wsntl)
            rownumber = GetRowNumberDivCode(mdicode, wsntl, divcode)
            If rownumber > 0 Then
                With wsntl
                    'Budget Amount
                    .Range("E" & rownumber.ToString()).Value = row("Amount").ToString
                End With
            Else
                MsgBox("Unable to find Item Code : " + mdicode + vbCrLf + "Item Desc : " + itemdesc, MsgBoxStyle.Information, "National Sales Performance")
            End If
        Next
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.InitialDirectory = txtTemplate.Text
        OpenFileDialog1.Filter = "xls files (*.xls)|*.xls|Excel files (*.xls)|*.xls"
        OpenFileDialog1.FilterIndex = 2
        OpenFileDialog1.RestoreDirectory = True
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txtTemplate.Text = OpenFileDialog1.FileName
            SetPath()
        End If
    End Sub

End Class
