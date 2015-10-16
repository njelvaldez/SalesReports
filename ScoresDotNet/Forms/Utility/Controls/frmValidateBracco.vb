Imports System.Data.SqlClient
Imports Microsoft
Imports Microsoft.Office.Interop
Imports System.Configuration
Imports System.Globalization
Imports System.Runtime.InteropServices
Imports System.Collections.Generic

Public Class frmValidateBracco
    Private salesinvupdpath As String = System.Configuration.ConfigurationSettings.AppSettings.Item("ValidateBraccoPath")
    Private SalesTransDate As String = ""
    Private RemoteDataSet As New DataSet
    Private braccoitems As New Dictionary(Of Integer, String)

    Private Sub SetDate()
        Dim currentdate As String
        currentdate = dtpMonth.Value.Month.ToString + "/1/" + dtpMonth.Value.Year.ToString
        dtpMonth.Text = currentdate
    End Sub

    Private Sub SetPath()
        Dim currentdate As String
        Dim format As String = "MMM d yyyy"
        currentdate = DateTime.Now.ToString("MMM", New CultureInfo("en-US")) + " 1 - " + DateTime.Now.Date.Day.ToString() + " " + DateTime.Now.Date.Year.ToString()
        txtTemplate.Text = salesinvupdpath + "BRACCO SALES.xls"
        txtOutput.Text = salesinvupdpath + "BRACCO SALES " + currentdate + ".xls"
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmSalesPerformanceSPAward_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RemoteDataSet.Tables.Add("IntegratedSales")
        SetDate()
        SetPath()
        braccoitems.Add(11225, "IOPAMIRO 300 1x100 ml")
        braccoitems.Add(11216, "IOPAMIRO 300 1x50 ml")
        braccoitems.Add(11224, "IOPAMIRO 370 1x100 ml")
        braccoitems.Add(11221, "IOPAMIRO 370 1x50 ml")
        braccoitems.Add(11226, "MULTIHANCE 1x10 ml VL")
        ' Get count.
        'Console.WriteLine(Dictionary.Count)
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
            Dim commdate2 As DateTime
            Dim commdately1 As DateTime
            Dim commdately2 As DateTime
            Dim lastyear As Integer

            commdate1 = dtpMonth.Text.ToString().Trim()
            commdate2 = dtpMonthTo.Text.ToString().Trim()
            lastyear = dtpMonthTo.Value.Year - 1

            commdately1 = dtpMonth.Value.Month.ToString.Trim + "/" + dtpMonth.Value.Day.ToString.Trim + "/" + lastyear.ToString.Trim
            commdately2 = dtpMonthTo.Value.Month.ToString.Trim + "/" + dtpMonthTo.Value.Day.ToString.Trim + "/" + lastyear.ToString.Trim

            Dim Params(3) As SqlParameter
            Dim commissiondate1 As New SqlParameter("@commissiondate1", SqlDbType.DateTime, 10) : commissiondate1.Direction = ParameterDirection.Input : commissiondate1.Value = commdate1 : Params(0) = commissiondate1
            Dim commissiondate2 As New SqlParameter("@commissiondate2", SqlDbType.DateTime, 10) : commissiondate2.Direction = ParameterDirection.Input : commissiondate2.Value = commdate2 : Params(1) = commissiondate2
            Dim commissiondately1 As New SqlParameter("@commissiondately1", SqlDbType.DateTime, 10) : commissiondately1.Direction = ParameterDirection.Input : commissiondately1.Value = commdately1 : Params(2) = commissiondately1
            Dim commissiondately2 As New SqlParameter("@commissiondately2", SqlDbType.DateTime, 10) : commissiondately2.Direction = ParameterDirection.Input : commissiondately2.Value = commdately2 : Params(3) = commissiondately2

            If Not generateonly Then
                BusinessObject.Sub_Update(ServerPath2, "Util_SalesTrend_Directver9Process", CommandType.StoredProcedure, Params)
            End If
            Dim Params0(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params0(0) = salescycledate

            BusinessObject.Sub_Show(ServerPath2, "Util_ValidateBraccoSelect", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params0)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            gbSales.Text = "Total No Of Records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString
            LogHelper.InsertLog("frmSalesTrendDirectYTDver9.ShowInvoice.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmValidateBracco.ShowInvoice.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub GenerateSales(ByVal strFileName As String)
        Dim xl As New Excel.Application
        Dim wb As Excel.Workbook
        Dim ws As Excel.Worksheet
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
            ws = CType(wb.Worksheets.Item("From NMPC Sales Data"), Excel.Worksheet)
            Dim itemdesc As String = ""
            Dim imonth As Integer = 0
            Dim scolumname As String = ""
            Dim qtyencoded As Integer = 0
            Dim amtencoded As Integer = 0
            Dim qtyfromdb As Integer = 0
            Dim amtfromdb As Integer = 0
            For Each drow As DataRow In dt.Rows
                'dictionary.Item(int)
                imonth = Month(drow("salescycledate"))
                itemdesc = braccoitems.Item(Convert.ToInt16(drow("itemcode")))
                rownumber = GetRowNumber(itemdesc, ws)

                If rownumber > 0 Then
                    scolumname = GetColumnName(imonth)
                    With ws
                        qtyencoded = .Range(scolumname & rownumber.ToString.Trim).Value
                        amtencoded = .Range(scolumname & (rownumber + 1).ToString.Trim).Value
                        qtyfromdb = drow("QtySold")
                        amtfromdb = drow("AmountSold")
                        'Compare Qty Sold
                        If Math.Abs(qtyencoded - qtyfromdb) > 1 Then
                            .Range(scolumname & rownumber.ToString.Trim).Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow)
                            .Range(scolumname & rownumber.ToString.Trim).Value = qtyfromdb.ToString.Trim
                        End If
                        'Compare Amount Sold
                        If Math.Abs(amtencoded - amtfromdb) > 1 Then
                            .Range(scolumname & (rownumber + 1).ToString.Trim).Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow)
                            .Range(scolumname & (rownumber + 1).ToString.Trim).Value = amtfromdb.ToString.Trim
                        End If
                        '.Range(scolumname & rownumber.ToString.Trim).Value = drow("QtySold").ToString.Trim
                        '.Range(scolumname & (rownumber + 1).ToString.Trim).Value = drow("AmountSold").ToString.Trim
                    End With
                Else
                    MsgBox("Item : " + itemdesc + " was not found!")
                End If
            Next
            xl.DisplayAlerts = False
            wb.SaveAs(salesinvupdout)
            wb.Close()
            xl.Quit()
            xl = Nothing
            MessageBox.Show("Bracco Sales validation is complete!")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "frmValidateBracco.GenerateSalesTrend module")
        Finally
        End Try
    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbSales.Enter

    End Sub

    Private Sub btnGenerateOnly_Click(sender As Object, e As EventArgs) Handles btnGenerateOnly.Click
        Dim salesinvupdfile As String = txtTemplate.Text.ToString
        SetDate()
        Me.Cursor = Cursors.WaitCursor
        ShowInvoice(True)
        'this is now faster
        GenerateSales(salesinvupdfile)
        Me.Cursor = Cursors.Default
        KillExcellApp()
    End Sub

    Private Function GetRowNumber(ByVal itemcode As String, ByVal ws As Excel.Worksheet) As Integer
        Dim retval As Integer = 0
        Dim code As String
        Dim rowctr = 4

        While rowctr <= 20
            With ws
                code = CStr(.Range("B" & rowctr).Text)
                If code.Trim = itemcode.Trim Then
                    retval = rowctr
                    Exit While
                End If
            End With
            rowctr = rowctr + 1
        End While
        Return retval
    End Function

    Private Function GetColumnName(imonth As Integer) As String
        Dim retval As String = ""
        Select Case imonth
            Case 1
                retval = "D"
            Case 2
                retval = "E"
            Case 3
                retval = "F"
            Case 4
                retval = "H"
            Case 5
                retval = "I"
            Case 6
                retval = "J"
            Case 7
                retval = "L"
            Case 8
                retval = "M"
            Case 9
                retval = "N"
            Case 10
                retval = "P"
            Case 11
                retval = "Q"
            Case 12
                retval = "R"
            Case Else
                MsgBox("Month not between 1 and 12, inclusive")
        End Select
        Return retval
    End Function
End Class