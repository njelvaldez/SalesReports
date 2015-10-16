Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports Microsoft
Imports Microsoft.Office.Interop
Imports System.Configuration
Imports System.Globalization
Imports System.IO
Imports System.Runtime.InteropServices
Public Class frmSouthStarDrugNew
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
        Dim salesinvupdpath As String = System.Configuration.ConfigurationSettings.AppSettings.Item("SOUTHSTARRAWPath")
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
        txtOutput.Text = txtOutput.Text.ToString().Replace(".xls", "") + "SOUTHSTAR RAW DATA " + currentdate + ".xls"
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
        Dim rowcounter As Integer = 0
        Dim realitemcode As String = ""
        Dim itemcodestr As String = ""
        Dim realcustomercode As String = ""
        Dim customercodestr As String = ""
        newcustomercount = 0
        itemerrorcount = 0
        For Each row As DataGridViewRow In dgvSales.Rows
            If Not row.IsNewRow And rowcounter >= 15 Then
                'Check Item Data Mapping
                itemcodestr = row.Cells(0).Value.ToString
                realitemcode = GetItemCode(itemcodestr)
                If realitemcode = "" And itemcodestr <> "" And row.Cells(1).Value.ToString.Trim <> "" Then
                    row.DefaultCellStyle.BackColor = Color.Red
                    itemerrorcount = itemerrorcount + 1
                Else
                    row.DefaultCellStyle.BackColor = Color.Green
                End If

                'Check Customer Data Mapping
                customercodestr = row.Cells(2).Value.ToString
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
        Dim SearchName As New SqlParameter("@SearchName", SqlDbType.VarChar, 50) : SearchName.Direction = ParameterDirection.Input : SearchName.Value = "SOUTHSTAR ITEM" : Params(0) = SearchName
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
        Dim SearchName As New SqlParameter("@SearchName", SqlDbType.VarChar, 50) : SearchName.Direction = ParameterDirection.Input : SearchName.Value = "SOUTHSTAR CUSTOMER" : Params(0) = SearchName
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
        EditMapping()
    End Sub
    Private Sub EditMapping()
        Dim myLoadedForm As New frmEditDataMapping
        Dim row As Integer = dgvSales.CurrentRow.Index
        If row > -1 Then
            myLoadedForm.CustomerCode = dgvSales.Rows(row).Cells(2).Value.ToString
            myLoadedForm.CustomerName = dgvSales.Rows(row).Cells(3).Value.ToString
            'get customer address
            myLoadedForm.txtAddress1.Text = SSDCustomer.GetCustomerAddress(dgvSales.Rows(row).Cells(2).Value.ToString.TrimEnd)

            myLoadedForm.txtCustomerNameMap.Text = "South Star"
            myLoadedForm.ItemCode = dgvSales.Rows(row).Cells(0).Value.ToString
            myLoadedForm.ItemName = dgvSales.Rows(row).Cells(1).Value.ToString

            'Set DataMap Search column
            myLoadedForm.gbCustomer.Text = "SOUTHSTAR CUSTOMER"
            myLoadedForm.gbItem.Text = "SOUTHSTAR ITEM"
            myLoadedForm.txtUnit.Text = ""
            myLoadedForm.txtUnitPrice.Text = dgvSales.Rows(row).Cells(8).Value.ToString & "/" & dgvSales.Rows(row).Cells(5).Value.ToString

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
        'Start reading row 21
        Dim rowcounter As Integer = 0
        Dim outrowcounter As Integer = 2
        Dim realitemcode As String = ""
        Dim itemcodestr As String = ""
        Dim itemdesc As String = ""
        Dim realcustomercode As String = ""
        Dim customercodestr As String = ""
        Dim ws As Excel.Worksheet
        Dim refdate As String = ""
        Dim nunitprice As Double = 0.0
        Dim nquantity As Double = 0.0
        Dim namount As Double = 0.0

        OpenOutputTemplate(ouputtemplate)
        ws = CType(wbtemplate.Worksheets.Item("SalesQuery"), Excel.Worksheet)
        For Each row As DataGridViewRow In dgvSales.Rows
            'Start reading from row 20
            If Not row.IsNewRow Then
                'Get real Item Code
                itemcodestr = row.Cells(0).Value.ToString
                itemdesc = row.Cells(1).Value.ToString
                'Get QUantity Sold
                Try
                    nquantity = Convert.ToDouble(row.Cells(5).Value.ToString)
                Catch ex As Exception
                    nquantity = 0
                End Try

                If itemcodestr <> "" And itemdesc <> "" And Not itemdesc.Contains("SKU Description") And nquantity > 0 Then
                    realitemcode = GetItemCode(itemcodestr)

                    'Get real Customer Code
                    customercodestr = row.Cells(2).Value.ToString
                    realcustomercode = GetCustomerCode(customercodestr)
                    Dim dscustomer As New DataSet
                    dscustomer = CustomerHelper.GetCustomer(realcustomercode)
                    Dim dsitem As New DataSet
                    dsitem = ItemHelper.Getitem(realitemcode)

                    With ws
                        'Set Dist_Code, SubDist_Code,Prin_Code
                        .Range("A" & outrowcounter.ToString()).Value = "12"
                        .Range("B" & outrowcounter.ToString()).Value = "SSD02"
                        .Range("O" & outrowcounter.ToString()).Value = "MIC"
                        'A:Invoice No , SubDist Code + Date
                        .Range("J" & outrowcounter.ToString()).Value = "12" & dtpMonth.Text.ToString().Replace("/", "")

                        'B:Customer Code
                        .Range("C" & outrowcounter.ToString()).Value = realcustomercode
                        'C:Customer Name
                        .Range("D" & outrowcounter.ToString()).Value = dscustomer.Tables(0).Rows(0)("custname").ToString()
                        'D:Address 1 
                        .Range("E" & outrowcounter.ToString()).Value = dscustomer.Tables(0).Rows(0)("address1").ToString()
                        'Address 2 
                        .Range("F" & outrowcounter.ToString()).Value = dscustomer.Tables(0).Rows(0)("address2").ToString()

                        'E:Invoice Date 
                        .Range("K" & outrowcounter.ToString()).Value = dtpMonth.Text.ToString()
                        'F:PO No ,  SubDist Code + Date
                        .Range("L" & outrowcounter.ToString()).Value = "12" & dtpMonth.Text.ToString().Replace("/", "")

                        'G:Product Code
                        .Range("P" & outrowcounter.ToString()).Value = realitemcode
                        'H:Description
                        .Range("Q" & outrowcounter.ToString()).Value = dsitem.Tables(0).Rows(0)("itemdesc").ToString()
                        'K:UOM
                        .Range("R" & outrowcounter.ToString()).Value = dsitem.Tables(0).Rows(0)("itemunit").ToString()

                        'I:Quantity
                        nquantity = Convert.ToDouble(row.Cells(5).Value.ToString)
                        .Range("U" & outrowcounter.ToString()).Value = nquantity.ToString
                        'J:FOC,QTYFREE
                        .Range("V" & outrowcounter.ToString()).Value = "0"
                        'L:LotNo
                        .Range("S" & outrowcounter.ToString()).Value = ""
                        'M:Exp Date
                        .Range("T" & outrowcounter.ToString()).Value = "12/31/1999"
                        'N:Unit Price
                        If nquantity > 0 Then
                            namount = Convert.ToDouble(row.Cells(8).Value.ToString)
                            nunitprice = namount / nquantity
                        Else
                            namount = 0.0
                            nunitprice = 0.0
                        End If
                        .Range("W" & outrowcounter.ToString()).Value = nunitprice.ToString
                        'O:Discount
                        'P:Net Amount
                        .Range("X" & outrowcounter.ToString()).Value = namount.ToString
                    End With
                    outrowcounter = outrowcounter + 1
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

    Private Sub dgvSales_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSales.CellClick
        'EditMapping()
    End Sub

    Private Sub dgvSales_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvSales.CellFormatting
        Dim details As String = ""
        Dim custcode As String = ""
        Dim custname As String = ""
        Dim itemcode As String = ""
        Dim itemname As String = ""
        Dim row As Integer = dgvSales.CurrentRow.Index
        Dim dtitem As New DataSet
        Dim dtcust As New DataSet
        If (e.ColumnIndex = 5) Then
            custcode = dgvSales.Rows(row).Cells(2).Value.ToString
            custname = dgvSales.Rows(row).Cells(3).Value.ToString
            itemcode = dgvSales.Rows(row).Cells(0).Value.ToString
            itemname = dgvSales.Rows(row).Cells(1).Value.ToString
            'SOUTHSTAR CUSTOMER
            dtcust = CustomerHelper.GetCustomerDataMap("SOUTHSTAR CUSTOMER", custcode)
            dtitem = ItemHelper.GetItemDataMap("SOUTHSTAR ITEM", itemcode)
            With dtcust.Tables(0)
                If dtcust.Tables(0).Rows.Count > 0 Then
                    details = vbCrLf + vbCrLf + vbCrLf + "SSD  Cust Code : " + .Rows(0)("SearchCode") + vbCrLf + _
                              "NMPC Cust Code : " + .Rows(0)("returncode") + vbCrLf + _
                              "SSD  Cust Name : " + custname + vbCrLf + _
                              "NMPC Cust Name : " + .Rows(0)("custname") + vbCrLf + vbCrLf
                End If
            End With

            With dtitem.Tables(0)
                If dtitem.Tables(0).Rows.Count > 0 Then
                    details += "SSD Item Code : " + .Rows(0)("SearchCode") + vbCrLf + _
                               "NMPC Item Code : " + .Rows(0)("returncode") + vbCrLf + _
                               "SSD Item Name : " + itemname + vbCrLf + _
                               "NMPC Item Name : " + .Rows(0)("itemdesc")
                End If
            End With

            With Me.dgvSales.Rows(e.RowIndex).Cells(e.ColumnIndex)
                .ToolTipText = details
            End With
        End If
    End Sub
End Class