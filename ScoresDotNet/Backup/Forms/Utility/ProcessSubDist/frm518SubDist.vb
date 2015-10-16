Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports Microsoft
Imports Microsoft.Office.Interop
Imports System.Configuration
Imports System.Globalization
Imports System.IO
Imports System.Runtime.InteropServices
Public Class frm518SubDist
    Private RemoteDataSet As New DataSet
    Private xl As New Excel.Application
    Private wb As Excel.Workbook
    Private wbtemplate As Excel.Workbook
    Private ws As Excel.Worksheet
    Private budgetfileonly As String
    Private ouputtemplate As String = "'"
    Private newcustomercount As Integer = 0
    Private itemerrorcount As Integer = 0
    Private Sub SetDate()
        Dim currentdate As String
        currentdate = dtpMonth.Value.Month.ToString + "/1/" + dtpMonth.Value.Year.ToString
        dtpMonth.Text = currentdate
    End Sub

    Private Sub InitialPath()
        Dim salesinvupdpath As String = System.Configuration.ConfigurationSettings.AppSettings.Item("518RAWPath")
        Dim currentdate As String
        Dim format As String = "MMM d yyyy"
        'ASP Jan - May 2014.xlsx
        currentdate = DateTime.Now.ToString("MMM", New CultureInfo("en-US")) + " 1 - " + DateTime.Now.Date.Day.ToString() + " " + DateTime.Now.Date.Year.ToString()
        txtTemplate.Text = salesinvupdpath
        txtOutput.Text = salesinvupdpath
        ouputtemplate = salesinvupdpath + "SubDistTemplate.xls"
    End Sub
    Private Sub SetPath()
        Dim currentdate As String
        Dim format As String = "MMM d yyyy"
        currentdate = (DateTime.Now.Month - 1).ToString() + " " + DateTime.Now.Date.Year.ToString()
        txtOutput.Text = txtOutput.Text.ToString().Replace(".xls", "") + "518 RAW DATA " + currentdate + ".xls"
    End Sub

    Private Sub frmGenerateInvoiceList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RemoteDataSet.Tables.Add("Table1")
        SetDate()
        InitialPath()
        EnableGenerate(False)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub OpenAndDisplayExcel()
        Dim salesinvupdfile As String = txtTemplate.Text.ToString
        SetDate()
        Me.Cursor = Cursors.WaitCursor
        OpenRAWFile(txtTemplate.Text.ToString())
        LoadExcelToGrid(txtTemplate.Text.ToString())
        DisplayColorMapping()
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub LoadExcelToGrid(ByVal filename As String)

        Dim conn As OleDbConnection
        Dim dta As OleDbDataAdapter
        Dim dts As DataSet
        Dim sheetname As String = ""
        Dim sheetnamebracket As String = ""
        Dim sheetnametable As String = ""

        Dim i As Integer = 1
        Try
            sheetname = wb.Sheets.Item(i).Name
            sheetnamebracket = "[" + wb.Sheets.Item(i).Name + "$]"
            sheetnametable = "[Sheet" + i.ToString().Trim() + "$]"

            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filename + ";Extended Properties=Excel 12.0;")
            dta = New OleDbDataAdapter("Select * From " + sheetnamebracket, conn)
            dts = New DataSet
            dta.Fill(dts, sheetnametable)
            dgvSales.DataSource = dts
            dgvSales.DataMember = sheetnametable
            conn.Close()

        Catch ex As Exception
            MsgBox("Error Message : " + ex.Message)
        End Try
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.InitialDirectory = txtTemplate.Text
        OpenFileDialog1.Filter = "xls files (*.xls)|*.xls|Excel files (*.xls)|*.xls"
        OpenFileDialog1.FilterIndex = 2
        OpenFileDialog1.RestoreDirectory = True
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txtTemplate.Text = OpenFileDialog1.FileName
            SetPath()
            EnableGenerate(True)
            OpenAndDisplayExcel()
        Else
            EnableGenerate(False)
        End If
    End Sub

    Private Sub EnableGenerate(ByVal isenabled As Boolean)
        btnGenerateRawData.Enabled = isenabled
    End Sub

    Private Sub OpenRAWFile(ByVal strFileName As String)
        Dim rownumber As Integer = 0
        Dim qty As Integer = 0
        Dim bonus As Integer = 0
        Try
            wb = xl.Workbooks.Open(strFileName)
            xl.DisplayAlerts = False
            'wb.Close()
            'xl.Quit()
            'xl = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Extract_ExcelFileData module")
        Finally
        End Try
    End Sub

    Private Sub btnColorMapping_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnColorMapping.Click
        DisplayColorMapping()
    End Sub

    Private Sub DisplayColorMapping()
        Dim rowcounter As Integer = 2
        Dim realitemcode As String = ""
        Dim itemcodestr As String = ""
        Dim realcustomercode As String = ""
        Dim customercodestr As String = ""
        newcustomercount = 0
        itemerrorcount = 0
        For Each row As DataGridViewRow In dgvSales.Rows
            If Not row.IsNewRow Then
                'Check Item Data Mapping
                'item description is only available
                itemcodestr = StringHelper.Get50Chars(row.Cells(12).Value.ToString.Trim)
                realitemcode = GetItemCode(itemcodestr)
                If realitemcode = "" And itemcodestr <> "" Then
                    row.DefaultCellStyle.BackColor = Color.Red
                    itemerrorcount = itemerrorcount + 1
                Else
                    row.DefaultCellStyle.BackColor = Color.Green
                End If

                'Check Customer Data Mapping
                'only customer name is available
                customercodestr = StringHelper.Get50Chars(row.Cells(9).Value.ToString.Trim)
                realcustomercode = GetCustomerCode(customercodestr)
                If realcustomercode = "" And customercodestr <> "" Then
                    row.DefaultCellStyle.BackColor = Color.Red
                    newcustomercount = newcustomercount + 1
                Else
                    If row.DefaultCellStyle.BackColor <> Color.Red Then
                        row.DefaultCellStyle.BackColor = Color.Green
                    End If
                End If

            End If
            rowcounter = rowcounter + 1
            txtNewCustomer.Text = newcustomercount.ToString
            txtItemError.Text = itemerrorcount.ToString
        Next
    End Sub

    Private Function GetItemCode(ByVal itemcode As String) As String
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(1) As SqlParameter
        Dim SearchName As New SqlParameter("@SearchName", SqlDbType.VarChar, 50) : SearchName.Direction = ParameterDirection.Input : SearchName.Value = "518 ITEM" : Params(0) = SearchName
        Dim SearchCode As New SqlParameter("@SearchCode", SqlDbType.VarChar, 50) : SearchCode.Direction = ParameterDirection.Input : SearchCode.Value = itemcode : Params(1) = SearchCode
        ResetTable()
        BusinessObject.Sub_Show(ServerPath2, "Util_DataMap_Select", CommandType.StoredProcedure, RemoteDataSet, "Table1", Params)
        If RemoteDataSet.Tables("Table1").Rows.Count > 0 Then
            Return RemoteDataSet.Tables("Table1").Rows(0)("ReturnCode").ToString()
        Else
            Return ""
        End If

    End Function

    Private Function GetCustomerCode(ByVal itemcode As String) As String
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(1) As SqlParameter
        Dim SearchName As New SqlParameter("@SearchName", SqlDbType.VarChar, 50) : SearchName.Direction = ParameterDirection.Input : SearchName.Value = "518 CUSTOMER" : Params(0) = SearchName
        Dim SearchCode As New SqlParameter("@SearchCode", SqlDbType.VarChar, 50) : SearchCode.Direction = ParameterDirection.Input : SearchCode.Value = itemcode : Params(1) = SearchCode
        ResetTable()
        BusinessObject.Sub_Show(ServerPath2, "Util_DataMap_Select", CommandType.StoredProcedure, RemoteDataSet, "Table1", Params)
        If RemoteDataSet.Tables("Table1").Rows.Count > 0 Then
            Return RemoteDataSet.Tables("Table1").Rows(0)("ReturnCode").ToString()
        Else
            Return ""
        End If

    End Function

    Private Sub ResetTable()
        RemoteDataSet.Tables.Remove("Table1")
        RemoteDataSet.Tables.Add("Table1")
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim myLoadedForm As New frmEditDataMapping
        Dim row As Integer = dgvSales.CurrentRow.Index
        Dim customername As String = ""
        If row > -1 Then
            customername = dgvSales.Rows(row).Cells(9).Value.ToString.Trim
            customername = StringHelper.Get50Chars(customername)
            '518 doesn't have customer code
            myLoadedForm.CustomerCode = ""
            myLoadedForm.CustomerName = dgvSales.Rows(row).Cells(9).Value.ToString
            myLoadedForm.ItemCode = "" '518 doesn't have item code 
            myLoadedForm.ItemName = dgvSales.Rows(row).Cells(12).Value.ToString

            'Set DataMap Search column
            myLoadedForm.gbCustomer.Text = "518 CUSTOMER"
            myLoadedForm.gbItem.Text = "518 ITEM"
            myLoadedForm.txtUnit.Text = "" ' 518 no unit
            myLoadedForm.txtUnitPrice.Text = dgvSales.Rows(row).Cells(15).Value.ToString

            myLoadedForm.ShowDialog()
        Else
            MsgBox("Please select row to edit mapping!")
        End If
    End Sub

    Private Sub btnGenerateRawData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateRawData.Click
        GenerateRawFormatted()
        KillExcellApp()
    End Sub

    Private Sub GenerateRawFormatted()
        Dim rowcounter As Integer = 1
        Dim realitemcode As String = ""
        Dim itemcodestr As String = ""
        Dim realcustomercode As String = ""
        Dim customercodestr As String = ""
        Dim ws As Excel.Worksheet

        OpenOutputTemplate(ouputtemplate)
        ws = CType(wbtemplate.Worksheets.Item("SalesQuery"), Excel.Worksheet)
        For Each row As DataGridViewRow In dgvSales.Rows
            If Not row.IsNewRow Then
                'Get real Item Code
                'only item desc is available
                itemcodestr = StringHelper.Get50Chars(row.Cells(12).Value.ToString.Trim)
                If itemcodestr <> "" Then
                    realitemcode = GetItemCode(itemcodestr)

                    'Get real Customer Code
                    'only customer name is available
                    customercodestr = StringHelper.Get50Chars(row.Cells(9).Value.ToString.Trim)
                    realcustomercode = GetCustomerCode(customercodestr)
                    Dim dscustomer As New DataSet
                    dscustomer = CustomerHelper.GetCustomer(realcustomercode)
                    Dim dsitem As New DataSet
                    dsitem = ItemHelper.Getitem(realitemcode)

                    With ws
                        'Set Dist_Code, SubDist_Code,Prin_Code
                        .Range("A" & rowcounter.ToString()).Value = "01"
                        .Range("B" & rowcounter.ToString()).Value = "LZN04"
                        .Range("O" & rowcounter.ToString()).Value = "MIC"
                        'A:Invoice No 
                        'if invoice no is blank use po no
                        Dim invno As String = row.Cells(0).Value.ToString.Trim
                        If invno = "" Then
                            invno = row.Cells(5).Value.ToString
                        End If
                        .Range("J" & rowcounter.ToString()).Value = invno

                        'B:Customer Code
                        .Range("C" & rowcounter.ToString()).Value = realcustomercode
                        'C:Customer Name
                        .Range("D" & rowcounter.ToString()).Value = dscustomer.Tables(0).Rows(0)("custname").ToString()
                        'D:Address 1 
                        .Range("E" & rowcounter.ToString()).Value = dscustomer.Tables(0).Rows(0)("address1").ToString()
                        'Address 2 
                        .Range("F" & rowcounter.ToString()).Value = dscustomer.Tables(0).Rows(0)("address2").ToString()

                        'E:Invoice Date 
                        '20140101 con vert to 1/1/2014
                        Dim invdate As String = row.Cells(1).Value.ToString.Trim
                        invdate = Integer.Parse(invdate.Substring(4, 2)).ToString().Trim + "/" + _
                        Integer.Parse(invdate.Substring(6, 2)).ToString().Trim + "/" + invdate.Substring(0, 4)
                        .Range("K" & rowcounter.ToString()).Value = invdate
                        'F:PO No , 
                        .Range("L" & rowcounter.ToString()).Value = row.Cells(5).Value.ToString

                        'G:Product Code
                        .Range("P" & rowcounter.ToString()).Value = realitemcode
                        'H:Description
                        .Range("Q" & rowcounter.ToString()).Value = dsitem.Tables(0).Rows(0)("itemdesc").ToString()
                        'K:UOM
                        .Range("R" & rowcounter.ToString()).Value = dsitem.Tables(0).Rows(0)("itemunit").ToString()

                        'I:Quantity
                        .Range("U" & rowcounter.ToString()).Value = row.Cells(13).Value.ToString
                        'J:FOC
                        .Range("V" & rowcounter.ToString()).Value = row.Cells(14).Value.ToString
                        'L:LotNo
                        .Range("S" & rowcounter.ToString()).Value = ""
                        'M:Exp Date
                        .Range("T" & rowcounter.ToString()).Value = "12/31/1999"
                        'N:Unit Price
                        .Range("W" & rowcounter.ToString()).Value = row.Cells(15).Value.ToString
                        'O:Discount
                        'P:Net Amount
                        .Range("X" & rowcounter.ToString()).Value = row.Cells(16).Value.ToString
                    End With
                End If
            End If
            rowcounter = rowcounter + 1
        Next
        wbtemplate.SaveAs(txtOutput.Text.ToString)
        wbtemplate.Close()
        wb.Close()
        xl.Quit()
        xl = Nothing
        MsgBox("Formatted RAW Data : " + txtOutput.Text.ToString + " is successfully generated!")
    End Sub
    Private Sub OpenOutputTemplate(ByVal strFileName As String)
        Dim rownumber As Integer = 0
        Dim qty As Integer = 0
        Dim bonus As Integer = 0
        Try
            wbtemplate = xl.Workbooks.Open(strFileName)
            xl.DisplayAlerts = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "OpenOutputTemplate module")
        Finally
        End Try
    End Sub
End Class