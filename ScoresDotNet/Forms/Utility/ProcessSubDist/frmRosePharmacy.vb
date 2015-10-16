Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports Microsoft
Imports Microsoft.Office.Interop
Imports System.Configuration
Imports System.Globalization
Imports System.IO
Imports System.Runtime.InteropServices
Public Class frmRosePharmacy
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
        Dim salesinvupdpath As String = System.Configuration.ConfigurationSettings.AppSettings.Item("ROSEPHARMACYRAWPath")
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
        txtOutput.Text = txtOutput.Text.ToString().Replace(".xls", "") + "ROSEPHARMACY RAW DATA " + currentdate + ".xls"
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
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.InitialDirectory = txtTemplate.Text
        OpenFileDialog1.Filter = "xls files (*.xlsx)|*.xlsx|Excel files (*.xlsx)|*.xlsx"
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
        Dim rowcounter As Integer = 1
        Dim realitemcode As String = ""
        Dim itemcodestr As String = ""
        Dim realcustomercode As String = ""
        Dim customercodestr As String = ""
        newcustomercount = 0
        itemerrorcount = 0
        For Each row As DataGridViewRow In dgvSales.Rows
            If Not row.IsNewRow Then
                'Check Item Data Mapping
                itemcodestr = row.Cells(2).Value.ToString
                realitemcode = GetItemCode(itemcodestr)
                If realitemcode = "" And itemcodestr <> "" Then
                    row.DefaultCellStyle.BackColor = Color.Red
                    itemerrorcount = itemerrorcount + 1
                Else
                    row.DefaultCellStyle.BackColor = Color.Green
                End If

                'Check Customer Data Mapping
                customercodestr = row.Cells(0).Value.ToString
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
        Dim SearchName As New SqlParameter("@SearchName", SqlDbType.VarChar, 50) : SearchName.Direction = ParameterDirection.Input : SearchName.Value = "ROSEPHARMACY ITEM" : Params(0) = SearchName
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
        Dim SearchName As New SqlParameter("@SearchName", SqlDbType.VarChar, 50) : SearchName.Direction = ParameterDirection.Input : SearchName.Value = "ROSEPHARMACY CUSTOMER" : Params(0) = SearchName
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
        If row > -1 Then
            myLoadedForm.CustomerCode = dgvSales.Rows(row).Cells(0).Value.ToString
            myLoadedForm.CustomerName = dgvSales.Rows(row).Cells(1).Value.ToString & " Rose Pharmacy"
            myLoadedForm.ItemCode = dgvSales.Rows(row).Cells(2).Value.ToString
            myLoadedForm.ItemName = dgvSales.Rows(row).Cells(3).Value.ToString

            'Set DataMap Search column
            myLoadedForm.gbCustomer.Text = "ROSEPHARMACY CUSTOMER"
            myLoadedForm.gbItem.Text = "ROSEPHARMACY ITEM"
            myLoadedForm.txtUnit.Text = ""
            myLoadedForm.txtUnitPrice.Text = ""

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
        Dim rowcounter As Integer = 2
        Dim realitemcode As String = ""
        Dim itemcodestr As String = ""
        Dim realcustomercode As String = ""
        Dim customercodestr As String = ""
        Dim ws As Excel.Worksheet
        Dim nunitprice As Double = 0.0
        Dim pacqty As Double = 0.0

        OpenOutputTemplate(ouputtemplate)
        ws = CType(wbtemplate.Worksheets.Item("SalesQuery"), Excel.Worksheet)
        For Each row As DataGridViewRow In dgvSales.Rows
            If Not row.IsNewRow Then
                'Get real Item Code
                itemcodestr = row.Cells(2).Value.ToString
                If itemcodestr <> "" Then
                    realitemcode = GetItemCode(itemcodestr)

                    'Get real Customer Code
                    customercodestr = row.Cells(0).Value.ToString
                    realcustomercode = GetCustomerCode(customercodestr)
                    Dim dscustomer As New DataSet
                    dscustomer = CustomerHelper.GetCustomer(realcustomercode)
                    Dim dsitem As New DataSet
                    dsitem = ItemHelper.Getitem(realitemcode)

                    With ws
                        'Set Dist_Code, SubDist_Code,Prin_Code
                        .Range("A" & rowcounter.ToString()).Value = "17"
                        .Range("B" & rowcounter.ToString()).Value = "ROS01"
                        .Range("O" & rowcounter.ToString()).Value = "MIC"
                        'A:Invoice No , SYSTEM GENERATED
                        .Range("J" & rowcounter.ToString()).Value = "17" & row.Cells(5).Value.ToString

                        'B:Customer Code
                        .Range("C" & rowcounter.ToString()).Value = realcustomercode
                        'C:Customer Name
                        .Range("D" & rowcounter.ToString()).Value = dscustomer.Tables(0).Rows(0)("custname").ToString()
                        'D:Address 1 
                        .Range("E" & rowcounter.ToString()).Value = dscustomer.Tables(0).Rows(0)("address1").ToString()
                        'Address 2 
                        .Range("F" & rowcounter.ToString()).Value = dscustomer.Tables(0).Rows(0)("address2").ToString()

                        'E:Invoice Date ,Convert String to Date
                        .Range("K" & rowcounter.ToString()).Value = ConvertStrToDate(row.Cells(5).Value.ToString)
                        'F:PO No , "17" + refdate
                        .Range("L" & rowcounter.ToString()).Value = "17" & row.Cells(5).Value.ToString

                        'G:Product Code
                        .Range("P" & rowcounter.ToString()).Value = realitemcode
                        'H:Description
                        .Range("Q" & rowcounter.ToString()).Value = dsitem.Tables(0).Rows(0)("itemdesc").ToString()
                        'K:UOM
                        .Range("R" & rowcounter.ToString()).Value = dsitem.Tables(0).Rows(0)("itemunit").ToString()

                        'I:Quantity
                        .Range("U" & rowcounter.ToString()).Value = row.Cells(4).Value.ToString
                        'J:FOC
                        .Range("V" & rowcounter.ToString()).Value = "0"
                        'L:LotNo
                        .Range("S" & rowcounter.ToString()).Value = ""
                        'M:Exp Date
                        .Range("T" & rowcounter.ToString()).Value = "12/31/9999"
                        'Packaging Quantity
                        pacqty = Convert.ToDouble(dsitem.Tables(0).Rows(0)("itemunit").ToString().Replace("'s", ""))
                        'N:Unit Price
                        nunitprice = GetRosePharmacyUnitPrice(realitemcode)
                        If pacqty > 1 And dsitem.Tables(0).Rows(0)("itemdesc").ToString().ToUpper.Contains("CAPS") Or _
                           pacqty > 1 And dsitem.Tables(0).Rows(0)("itemdesc").ToString().ToUpper.Contains("CAPLET") Or _
                           pacqty > 1 And dsitem.Tables(0).Rows(0)("itemdesc").ToString().ToUpper.Contains("TABLET") Then
                            nunitprice = nunitprice / pacqty
                        End If
                        If (nunitprice <= 0) Then
                            MsgBox("Invalid unit price for item : " & dsitem.Tables(0).Rows(0)("itemdesc").ToString())
                            nunitprice = dsitem.Tables(0).Rows(0)("unitprice")
                        End If
                        .Range("W" & rowcounter.ToString()).Value = nunitprice.ToString()
                        'O:Discount
                        'P:Net Amount
                        .Range("X" & rowcounter.ToString()).Value = Convert.ToString(row.Cells(4).Value * nunitprice)
                    End With
                End If
            End If
            rowcounter = rowcounter + 1
        Next
        wbtemplate.SaveAs(txtOutput.Text.ToString)
        wbtemplate.Close()
        wb.Close()
        xl.Quit()
        'Marshal.ReleaseComObject(wb)
        'Marshal.ReleaseComObject(xl)
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

    Private Function ConvertStrToDate(strdate As String)
        Dim retval As String = ""
        retval = strdate.Substring(2, 2) & "/" & strdate.Substring(4, 2) & "/20" & strdate.Substring(0, 2)
        Return retval
    End Function

    Public Function GetRosePharmacyUnitPrice(itmcode As String) As String
        Dim nunitprice As Double = 0.0
        Dim RemoteDataSet As New DataSet
        Try
            RemoteDataSet.Tables.Add("Table1")
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim itemcode As New SqlParameter("@itemcode", SqlDbType.VarChar, 10) : itemcode.Direction = ParameterDirection.Input : itemcode.Value = itmcode : Params(0) = itemcode
            BusinessObject.Sub_Show(ServerPath2, "Util_RosePharmacyGetUnitPrice", CommandType.StoredProcedure, RemoteDataSet, "Table1", Params)
            If RemoteDataSet.Tables(0).Rows.Count > 0 Then
                nunitprice = RemoteDataSet.Tables(0).Rows(0).Item("UnitPrice")
            End If
        Catch ex As Exception
            MsgBox("Error in GetRosePharmacyUnitPrice : " & ex.Message)
        End Try
        Return nunitprice
    End Function

End Class