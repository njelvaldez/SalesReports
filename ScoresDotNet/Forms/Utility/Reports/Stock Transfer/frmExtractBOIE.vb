Imports System.Data.SqlClient
Imports Microsoft
Imports Microsoft.Office.Interop
Imports System.Configuration
Imports System.Globalization
Imports System.Runtime.InteropServices
Public Class frmExtractBOIE
    Private IsCustomer As Boolean = False
    Private CustomerName As String = ""
    Private ProductDesc As String = ""
    Private boeicust As New BoeiCustomer
    Private boeiprod As New BoeiProduct
    Private salesinvupdpath As String = System.Configuration.ConfigurationSettings.AppSettings.Item("BOEISalesPath")
    Private SalesTransDate As String = ""
    Private RemoteDataSet As New DataSet

    Private Sub SetDate()
        Dim currentdate As String
        currentdate = Now.Month.ToString + "/1/" + Now.Year.ToString
    End Sub
    Private Sub SetPath()
        Dim currentdate As String
        Dim format As String = "MMM d yyyy"
        currentdate = DateTime.Now.ToString("MMM", New CultureInfo("en-US")) + " 1 - " + DateTime.Now.Date.Day.ToString() + " " + DateTime.Now.Date.Year.ToString()
        txtTemplate.Text = salesinvupdpath + "BOEI Sales.xlsx"
        'txtOutput.Text = salesinvupdpath + "BOEI Sales " + currentdate + ".xlsx"
        txtOutput.Text = salesinvupdpath + "BOEI Sales.xlsx"
    End Sub
    Private Sub btnOpenPDF_Click(sender As Object, e As EventArgs) Handles btnOpenPDF.Click
        OpenFileDialog1.ShowDialog()
        AxAcroPDF1.src = OpenFileDialog1.FileName
        If (OpenFileDialog1.FileName.ToString.ToUpper.Contains("CUSTOMER")) Then
            IsCustomer = True
        Else
            IsCustomer = False
        End If
    End Sub
    Private Sub btnSelectAll_Click(sender As Object, e As EventArgs) Handles btnSelectAll.Click
        TabControl1.SelectedIndex = 0
        AxAcroPDF1.Focus()
        SendKeys.SendWait("^a")
        SendKeys.SendWait("^c")
        SendKeys.Flush()
    End Sub

    Private Sub btnCopyText_Click_1(sender As Object, e As EventArgs) Handles btnCopyText.Click
        TabControl1.SelectedIndex = 1
        RichTextBox1.Focus()
        SendKeys.SendWait("^a")
        SendKeys.SendWait("^V")
        SendKeys.Flush()
    End Sub

    Private Sub btnAppendToExcel_Click(sender As Object, e As EventArgs) Handles btnAppendToExcel.Click
        AppendToExcelFile()
    End Sub
    Private Sub AppendToExcelFile()
        Dim nline As Integer = 0
        Dim islabel As Boolean = False
        Dim isitemdetail As Boolean = False
        Dim istotal As Boolean = False
        Dim issummary As Boolean = False
        Dim isblank As Boolean = False

        Dim xl As New Excel.Application
        Dim wb As Excel.Workbook
        Dim ws As Excel.Worksheet
        Dim wspiv As Excel.Worksheet
        Dim rownumber As Integer = 2
        Dim salesinvupdout As String = txtOutput.Text.ToString
        Dim salesinvupd As String = txtTemplate.Text.ToString
        Dim dotpos As Integer = 0
        Dim last2dec As String = ""
        Try
            wb = xl.Workbooks.Open(salesinvupd)

            ws = CType(wb.Worksheets.Item("SourceCust"), Excel.Worksheet)
            wspiv = CType(wb.Worksheets.Item("PivotCust"), Excel.Worksheet)
            rownumber = GetLastRowCount(ws)
            For Each line As String In RichTextBox1.Lines
                If IsCustomer And nline >= 3 Then
                    islabel = line.ToUpper.Contains("PRODUCT DESCRIPTION")
                    istotal = line.ToUpper.Contains("TOTAL")
                    issummary = line.ToUpper.Contains("CUSTOMER SALES SUMMARY")
                    isblank = String.IsNullOrEmpty(line.Trim)
                    isitemdetail = (line.Split(".").Length - 1) > 1

                    If isitemdetail Then
                        dotpos = line.LastIndexOf(".")
                        last2dec = line.Substring(dotpos, 2)
                        'If last 2 decimal is numeric , it is really item detail
                        isitemdetail = IsNumeric(last2dec)
                    End If

                    If istotal Then
                        'Reset Customer
                        CustomerName = ""
                    Else
                        If Not islabel And Not isitemdetail And Not istotal And Not issummary And Not isblank Then
                            CustomerName = line.Trim
                        Else
                            If isitemdetail And Not istotal Then
                                boeicust = BOEIPdfHelper.GetCustomer(CustomerName, line)
                                With ws
                                    .Range("A" & rownumber.ToString()).Value = boeicust.Customer
                                    .Range("B" & rownumber.ToString()).Value = boeicust.Product
                                    .Range("C" & rownumber.ToString()).Value = boeicust.Quantity
                                    .Range("D" & rownumber.ToString()).Value = boeicust.UnitPrice
                                    .Range("E" & rownumber.ToString()).Value = boeicust.Amount
                                End With
                                rownumber = rownumber + 1
                            End If
                        End If
                    End If

                End If
                nline = nline + 1
            Next
            'Jan - May 2014 Sales'
            wspiv.Range("A3").Value = "January 2014 to October 2014"
            'Refresh PivotTable3
            'pivot.SourceData = "SheetName!R1C1:R18C18"
            wspiv.PivotTables("PivotTable1").SourceData = "SourceCust!R1C1:R" + (rownumber - 1).ToString.Trim + "C5"
            wspiv.PivotTables("PivotTable1").RefreshTable()
            wb.SaveAs(salesinvupdout)
            wb.Close()
            xl.Quit()
            xl = Nothing
            KillExcellApp()
            MsgBox("Processing of BOEI Sales Per Customer is complete!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Function GetLastRowCount(ws As Excel.Worksheet) As Integer
        Dim retval As Integer = 0
        Dim code As String
        Dim rowctr = 2

        While rowctr <= 1000000
            With ws
                code = CStr(.Range("A" & rowctr).Text)
                If String.IsNullOrEmpty(code.Trim) Then
                    retval = rowctr
                    Exit While
                End If
            End With
            rowctr = rowctr + 1
        End While
        Return retval
    End Function

    Private Sub frmExtractBOIE_Load(sender As Object, e As EventArgs) Handles Me.Load
        If RemoteDataSet.Tables.Count = 0 Then
            RemoteDataSet.Tables.Add("IntegratedSales")
        End If
        SetDate()
        SetPath()
    End Sub
End Class