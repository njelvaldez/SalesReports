Imports System.Data.SqlClient
Imports Microsoft
Imports Microsoft.Office.Interop
Imports System.Configuration
Imports System.Globalization
Imports System.Runtime.InteropServices
Public Class frmIMSInhouseReport
    Private SalesTransDate As String = ""
    Private RemoteDataSet As New DataSet
    Private MonthName As String = ""
    Private datefilename As String = ""
    Private Sub SetDate()
        Dim currentdate As String
        Dim fmt = New String("0"c, 2)
        currentdate = dtpMonth.Value.Month.ToString + "/1/" + dtpMonth.Value.Year.ToString
        dtpMonth.Text = currentdate
        datefilename = dtpMonth.Value.Month.ToString(fmt) + dtpMonth.Value.Day.ToString(fmt) + dtpMonth.Value.Year.ToString
        ''Jan - May 2014 Sales'
        MonthName = "Jan - " + dtpMonth.Value.ToString("MMM", New CultureInfo("en-US")) + " " + dtpMonth.Value.Year.ToString() + " Sales"
    End Sub

    Private Sub SetPath()
        Dim salesinvupdpath As String = System.Configuration.ConfigurationSettings.AppSettings.Item("IMSPath")
        Dim currentdate As String
        Dim format As String = "MMM d yyyy"
        currentdate = DateTime.Now.ToString("MMM", New CultureInfo("en-US")) + " 1 - " + DateTime.Now.Date.Day.ToString() + " " + DateTime.Now.Date.Year.ToString()
        txtTemplate.Text = salesinvupdpath
        txtOutput.Text = salesinvupdpath
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
        ShowInvoice1()
        GenerateInvoiceToExcel1(salesinvupdfile + "IMS-01.xls")
        ShowInvoice2()
        GenerateInvoiceToExcel2(salesinvupdfile + "IMS-02.xls")
        ShowInvoice3()
        GenerateInvoiceToExcel3(salesinvupdfile + "IMS-03.xls")
        Me.Cursor = Cursors.Default
        MsgBox("Process is complete." + " IMS files : " + txtOutput.Text.ToString + "IMS-01 to 03.xls" + " is generated!")
        KillExcellApp()
    End Sub
    Private Sub GenerateInvoiceToExcel1(ByVal strFileName As String)
        Dim xl As New Excel.Application
        Dim wb As Excel.Workbook
        Dim ws As Excel.Worksheet
        Dim rownumber As Integer = 2
        Dim salesinvupdout As String = txtOutput.Text.ToString
        Dim salesinvupd As String = txtTemplate.Text.ToString
        Try
            wb = xl.Workbooks.Open(strFileName)

            ws = CType(wb.Worksheets.Item("SalesQuery"), Excel.Worksheet)

            'Loop Sales Grid
            For Each row As DataGridViewRow In dgvSales.Rows
                If Not row.IsNewRow Then
                    With ws
                        'refdate, customercode, itemcode, qtysold, qtyfree,'' [quantity returns], 
                        ''' [quantity returns free],amountsold
                        .Range("A" & rownumber.ToString()).Value = row.Cells("refdate").Value.ToString
                        .Range("B" & rownumber.ToString()).Value = row.Cells("customercode").Value.ToString
                        .Range("C" & rownumber.ToString()).Value = row.Cells("itemcode").Value.ToString
                        .Range("D" & rownumber.ToString()).Value = row.Cells("qtysold").Value.ToString
                        .Range("E" & rownumber.ToString()).Value = row.Cells("qtyfree").Value.ToString
                        .Range("F" & rownumber.ToString()).Value = row.Cells("quantity returns").Value.ToString
                        .Range("G" & rownumber.ToString()).Value = row.Cells("quantity returns free").Value.ToString
                        .Range("H" & rownumber.ToString()).Value = row.Cells("amountsold").Value.ToString

                    End With
                    rownumber = rownumber + 1
                End If
            Next
            wb.SaveAs(salesinvupdout + datefilename + "-01.xls")
            wb.Close()
            xl.Quit()
            'Marshal.ReleaseComObject(wb)
            'Marshal.ReleaseComObject(xl)
            xl = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "frmAverageSellingPrice.GenerateInvoiceToExcel module")
        Finally
        End Try
    End Sub
    Private Sub GenerateInvoiceToExcel2(ByVal strFileName As String)
        Dim xl As New Excel.Application
        Dim wb As Excel.Workbook
        Dim ws As Excel.Worksheet
        Dim rownumber As Integer = 2
        Dim salesinvupdout As String = txtOutput.Text.ToString
        Dim salesinvupd As String = txtTemplate.Text.ToString
        Try
            wb = xl.Workbooks.Open(strFileName)

            ws = CType(wb.Worksheets.Item("SalesQuery"), Excel.Worksheet)

            'Loop Sales Grid
            For Each row As DataGridViewRow In dgvSales.Rows
                If Not row.IsNewRow Then
                    With ws
                        'a.itemcode, a.productform, a.itemdesc, b.unitprice  
                        .Range("A" & rownumber.ToString()).Value = row.Cells("itemcode").Value.ToString
                        .Range("B" & rownumber.ToString()).Value = row.Cells("productform").Value.ToString
                        .Range("C" & rownumber.ToString()).Value = row.Cells("itemdesc").Value.ToString
                        .Range("D" & rownumber.ToString()).Value = row.Cells("unitprice").Value.ToString
                    End With
                    rownumber = rownumber + 1
                End If
            Next
            wb.SaveAs(salesinvupdout + datefilename + "-02.xls")
            wb.Close()
            xl.Quit()
            xl = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "frmAverageSellingPrice.GenerateInvoiceToExcel module")
        Finally
        End Try
    End Sub
    Private Sub GenerateInvoiceToExcel3(ByVal strFileName As String)
        Dim xl As New Excel.Application
        Dim wb As Excel.Workbook
        Dim ws As Excel.Worksheet
        Dim rownumber As Integer = 2
        Dim salesinvupdout As String = txtOutput.Text.ToString
        Dim salesinvupd As String = txtTemplate.Text.ToString
        Try
            wb = xl.Workbooks.Open(strFileName)

            ws = CType(wb.Worksheets.Item("SalesQuery"), Excel.Worksheet)

            'Loop Sales Grid
            For Each row As DataGridViewRow In dgvSales.Rows
                If Not row.IsNewRow Then
                    With ws
                        'select a.custcode, a.custname, a.address1, a.address2, b.imsclass
                        .Range("A" & rownumber.ToString()).Value = row.Cells("custcode").Value.ToString
                        .Range("B" & rownumber.ToString()).Value = row.Cells("custname").Value.ToString
                        .Range("C" & rownumber.ToString()).Value = row.Cells("address1").Value.ToString
                        .Range("D" & rownumber.ToString()).Value = row.Cells("address2").Value.ToString
                        .Range("E" & rownumber.ToString()).Value = row.Cells("imsclass").Value.ToString
                    End With
                    rownumber = rownumber + 1
                End If
            Next
            wb.SaveAs(salesinvupdout + datefilename + "-03.xls")
            wb.Close()
            xl.Quit()
            xl = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "frmAverageSellingPrice.GenerateInvoiceToExcel module")
        Finally
        End Try
    End Sub
    Private Sub ShowInvoice1()
        Try
            RefreshTable()
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance

            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate

            BusinessObject.Sub_Show(ServerPath2, "Util_IMS1_Select", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            LogHelper.InsertLog("frmAverageSellingPrice.ShowInvoice.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmAverageSellingPrice.ShowInvoice1.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ShowInvoice2()
        Try
            RefreshTable()
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance

            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate

            BusinessObject.Sub_Show(ServerPath2, "Util_IMS2_Select", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            LogHelper.InsertLog("frmAverageSellingPrice.ShowInvoice.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmAverageSellingPrice.ShowInvoice2.Error: " & ex.Message)
        End Try
    End Sub
    Private Sub ShowInvoice3()
        Try
            RefreshTable()
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance

            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate

            BusinessObject.Sub_Show(ServerPath2, "Util_IMS3_Select", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            LogHelper.InsertLog("frmAverageSellingPrice.ShowInvoice.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmAverageSellingPrice.ShowInvoice3.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub RefreshTable()
        RemoteDataSet.Tables.Remove("IntegratedSales")
        RemoteDataSet.Tables.Add("IntegratedSales")
    End Sub
End Class