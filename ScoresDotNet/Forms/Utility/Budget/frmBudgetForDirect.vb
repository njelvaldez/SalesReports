Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports Microsoft
Imports Microsoft.Office.Interop
Imports System.Configuration
Imports System.Globalization
Imports System.IO
Imports System.Runtime.InteropServices
Public Class frmBudgetForDirect
    Private RemoteDataSet As New DataSet
    Private budgetfileonly As String

    Private Sub frmBudgetForSpecialist_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmBudgetForSpecialist_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RemoteDataSet.Tables.Add("Budget")
        SetDate()
    End Sub

    Private Sub AddTab(ByVal tabname As String)
        TabControl1.TabPages.Add(tabname)
    End Sub

    Private Sub CreateTabs(ByVal filename As String, ByVal wb As Excel.Workbook)
        Dim conn As OleDbConnection
        Dim dtr As OleDbDataReader
        Dim dta As OleDbDataAdapter
        Dim cmd As OleDbCommand
        Dim dts As DataSet
        Dim sheetname As String = ""
        Dim sheetnamebracket As String = ""
        Dim sheetnametable As String = ""

        For i = 1 To wb.Sheets.Count
            'MsgBox(WorkSheets(i).Name)
            'AddTab(WorkSheets(i).Name)
            sheetname = wb.Sheets.Item(i).Name
            sheetnamebracket = "[" + wb.Sheets.Item(i).Name + "$]"
            sheetnametable = "[Sheet" + i.ToString().Trim() + "$]"
            Dim NewTab As New TabPage
            Dim dgvExcelBudget As New DataGridView
            dgvExcelBudget.Width = 1250
            dgvExcelBudget.Height = 470
            dgvExcelBudget.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filename + ";Extended Properties=Excel 12.0;")
            dta = New OleDbDataAdapter("Select * From " + sheetnamebracket, conn)
            dts = New DataSet
            dta.Fill(dts, sheetnametable)
            dgvExcelBudget.DataSource = dts
            dgvExcelBudget.DataMember = sheetnametable
            conn.Close()

            NewTab.Name = sheetname
            NewTab.Text = NewTab.Name
            Me.TabControl1.Controls.Add(NewTab)
            NewTab.Controls.Add(dgvExcelBudget)
            Me.TabControl1.SelectedIndex = Me.TabControl1.TabCount - 1
        Next
    End Sub
    Private Sub DeleteTabs()
        Me.TabControl1.TabPages.Clear()
        Me.TabControl1.TabPages.Add("Budget")
    End Sub

    Private Sub ShowInvoice()
        Try
            If RemoteDataSet.Tables("DailySalesSummarybyItem").Rows.Count > 0 Then RemoteDataSet.Tables("DailySalesSummarybyItem").Clear()
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance

            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate

            BusinessObject.Sub_Show(ServerPath2, "Util_DailySalesSummarybyItem", CommandType.StoredProcedure, RemoteDataSet, "DailySalesSummarybyItem", Params)
            dgvBudget.DataSource = RemoteDataSet.Tables("DailySalesSummarybyItem")
            LogHelper.InsertLog("frmGenerateNMPCSalesUpdate.ShowInvoice.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmGenerateNMPCSalesUpdate.ShowInvoice.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub SetDate()
        Dim currentdate As String
        currentdate = dtpMonth.Value.Month.ToString + "/1/" + dtpMonth.Value.Year.ToString
        dtpMonth.Text = currentdate
    End Sub

    Private Sub OpenBudgetFile(ByVal strFileName As String)
        Dim rownumber As Integer = 0
        Dim qty As Integer = 0
        Dim bonus As Integer = 0
        Dim xl As New Excel.Application
        Dim wb As Excel.Workbook
        Dim ws As Excel.Worksheet
        Try
            wb = xl.Workbooks.Open(strFileName)
            'ws = CType(wb.Worksheets.Item("Sales Update"), Excel.Worksheet)

            DeleteTabs()

            'Create Tab for each WorkSheet
            CreateTabs(strFileName, wb)
            xl.DisplayAlerts = False
            wb.Close()
            xl.Quit()
            Marshal.ReleaseComObject(wb)
            Marshal.ReleaseComObject(xl)
            xl = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Extract_ExcelFileData module")
        Finally
        End Try
    End Sub

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        OpenBudgetFile(txtBudgetPath.Text)
        EnableSaveBudget(True)
    End Sub
    Private Sub SetPath()
        Dim salesinvupdpath As String = System.Configuration.ConfigurationSettings.AppSettings.Item("SpecialistsBudgetPath")
        Dim currentdate As String
        Dim format As String = "MMM d yyyy"
        currentdate = DateTime.Now.ToString("MMM", New CultureInfo("en-US")) + " 1 - " + DateTime.Now.Date.Day.ToString() + " " + DateTime.Now.Date.Year.ToString()
        txtBudgetPath.Text = salesinvupdpath + "NMPC Sales Update.xls"
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.InitialDirectory = txtBudgetPath.Text
        OpenFileDialog1.Filter = "xlsx files (*.xlsx)|*.xlsx|Excel files (*.xlsx)|*.xlsx"
        OpenFileDialog1.FilterIndex = 2
        OpenFileDialog1.RestoreDirectory = True
        EnableSaveBudget(False)
        ExcelHelper.KillExcellApp()
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txtBudgetPath.Text = OpenFileDialog1.FileName
            Dim fi As New FileInfo(OpenFileDialog1.FileName)
            budgetfileonly = fi.FullName
            OpenBudgetFile(txtBudgetPath.Text)
            EnableSaveBudget(True)
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        'Clear MR Code
        'txtMrCode.Text = ""
    End Sub

    Private Sub btnSaveBudget_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveBudget.Click
        Dim mrcode As String = ""
        Dim startdate As DateTime
        'mrcode = txtMrCode.Text
        startdate = dtpMonth.Value
        'If mrcode = "" Or Not ValidSpecialist(mrcode) Then
        'MsgBox("Please enter valid Specialist Code!")
        'Else
        'iF BUDGET EXIST AND MRCODE IS NOT BORILLO
        If BudgetExists(mrcode, startdate) Then
            Dim result As Integer = MessageBox.Show("Budget already exists in database! Do you want to overwrite budget for specialist?", "Budget for Specialist", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
                'MessageBox.Show("Cancel pressed")
            ElseIf result = DialogResult.No Then
                'MessageBox.Show("No pressed")
            ElseIf result = DialogResult.Yes Then
                DeleteBudget(mrcode, startdate)
                'Save Budget
                Me.Cursor = Cursors.WaitCursor
                SaveBudget()
                Me.Cursor = Cursors.Default
                MsgBox("Saving of budget is complete.")
            End If
        Else
            'Save Budget
            Me.Cursor = Cursors.WaitCursor
            SaveBudget()
            Me.Cursor = Cursors.Default
            MsgBox("Saving of budget is complete.")
        End If
        'End If
    End Sub

    Private Function BudgetExists(ByVal mrcodestr As String, ByVal startdate As DateTime) As Boolean
        RemoteDataSet.Tables.Remove("Budget")
        RemoteDataSet.Tables.Add("Budget")
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter
        Dim start_date As New SqlParameter("@start_date", SqlDbType.DateTime, 10) : start_date.Direction = ParameterDirection.Input : start_date.Value = startdate : Params(0) = start_date

        BusinessObject.Sub_Show(ServerPath2, "Util_BudgetDirectExists", CommandType.StoredProcedure, RemoteDataSet, "Budget", Params)
        Return RemoteDataSet.Tables("Budget").Rows.Count > 0
    End Function

    Private Sub SaveBudget()
        Dim dgvfromactivetab As DataGridView
        Dim rowcounter = 1
        Dim mrcodestr As String
        Dim itemcodestr As String
        Dim mdicodestr As String
        Dim divcodestr As String
        Dim realitemcode As String
        Dim itemdesc As String
        Dim aveprice As String
        Dim columnmdiqty As String = ""
        Dim columnmdiamt As String = ""
        Dim columnmerqty As String = ""
        Dim columnmeramt As String = ""
        Dim columngb_qty As String = ""
        Dim columngb_amt As String = ""

        'Dim aveprice As Double
        Dim qtyvalue As String
        Dim amountvalue As String
        Dim validdata As Boolean = True
        Dim lastdayofmonth As Integer = 1
        Dim end_date As String
        Dim create_date As String
        lastdayofmonth = Date.DaysInMonth(dtpMonth.Value.Year, dtpMonth.Value.Month)
        end_date = dtpMonth.Value.Month.ToString.Trim() + "/" + lastdayofmonth.ToString.Trim() + "/" + dtpMonth.Value.Year.ToString()
        create_date = DateTime.Now.Month.ToString.Trim() + "/" + DateTime.Now.Day.ToString.Trim() + "/" + DateTime.Now.Year.ToString.Trim()
        dgvfromactivetab = TabControl1.SelectedTab.Controls(0)
        'Loop Sales Grid

        'Get MDI Columns
        columnmdiqty = GetColumnMDIQty()
        columnmdiamt = GetColumnMDIAmt()

        'Get Mercury Columns
        columnmerqty = GetColumnMercuryQty()
        columnmeramt = GetColumnMercuryAmt()

        'Get GB Columns
        columngb_qty = GetColumnGBQty()
        columngb_amt = GetColumnGBAmt()

        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Paramsmdi(8) As SqlParameter
        Dim Paramsmer(8) As SqlParameter
        Dim Params_gb(8) As SqlParameter

        Dim distributorcode As New SqlParameter("@distributorcode", SqlDbType.VarChar, 5) : distributorcode.Direction = ParameterDirection.Input : distributorcode.Value = "" : Paramsmdi(0) = distributorcode
        Dim itemcode As New SqlParameter("@itemcode", SqlDbType.VarChar, 10) : itemcode.Direction = ParameterDirection.Input : itemcode.Value = "" : Paramsmdi(1) = itemcode
        Dim oldmdicode As New SqlParameter("@oldmdicode", SqlDbType.VarChar, 10) : oldmdicode.Direction = ParameterDirection.Input : oldmdicode.Value = "" : Paramsmdi(2) = oldmdicode
        Dim divcode As New SqlParameter("@divcode", SqlDbType.VarChar, 10) : divcode.Direction = ParameterDirection.Input : divcode.Value = "" : Paramsmdi(3) = divcode
        Dim quantity As New SqlParameter("@quantity", SqlDbType.Money, 16) : quantity.Direction = ParameterDirection.Input : quantity.Value = "0" : Paramsmdi(4) = quantity
        Dim amount As New SqlParameter("@amount", SqlDbType.Money, 16) : amount.Direction = ParameterDirection.Input : amount.Value = "0" : Paramsmdi(5) = amount
        Dim startdate As New SqlParameter("@startdate", SqlDbType.DateTime, 10) : startdate.Direction = ParameterDirection.Input : startdate.Value = "" : Paramsmdi(6) = startdate
        Dim enddate As New SqlParameter("@enddate", SqlDbType.DateTime, 10) : enddate.Direction = ParameterDirection.Input : enddate.Value = "" : Paramsmdi(7) = enddate
        Dim createddate As New SqlParameter("@createddate", SqlDbType.DateTime, 10) : createddate.Direction = ParameterDirection.Input : createddate.Value = "" : Paramsmdi(8) = createddate

        Paramsmdi(0) = distributorcode
        Paramsmdi(1) = itemcode
        Paramsmdi(2) = oldmdicode
        Paramsmdi(3) = divcode
        Paramsmdi(4) = quantity
        Paramsmdi(5) = amount
        Paramsmdi(6) = startdate
        Paramsmdi(7) = enddate
        Paramsmdi(8) = createddate

        Paramsmer(0) = distributorcode
        Paramsmer(1) = itemcode
        Paramsmer(2) = oldmdicode
        Paramsmer(3) = divcode
        Paramsmer(4) = quantity
        Paramsmer(5) = amount
        Paramsmer(6) = startdate
        Paramsmer(7) = enddate
        Paramsmer(8) = createddate

        Params_gb(0) = distributorcode
        Params_gb(1) = itemcode
        Params_gb(2) = oldmdicode
        Params_gb(3) = divcode
        Params_gb(4) = quantity
        Params_gb(5) = amount
        Params_gb(6) = startdate
        Params_gb(7) = enddate
        Params_gb(8) = createddate

        For Each row As DataGridViewRow In dgvfromactivetab.Rows
            If Not row.IsNewRow And rowcounter >= 10 Then
                itemcodestr = row.Cells(0).Value.ToString
                mdicodestr = row.Cells(1).Value.ToString
                divcodestr = row.Cells(2).Value.ToString
                itemdesc = row.Cells(4).Value.ToString
                aveprice = row.Cells(5).Value.ToString

                'Get MDI
                qtyvalue = row.Cells(columnmdiqty).Value.ToString
                amountvalue = row.Cells(columnmdiamt).Value.ToString

                'Check for required fields : itemcode, itemdesc, qty, amount
                If (ValidString(itemcodestr) And ValidString(itemdesc) And ValidNumber(qtyvalue.ToString()) And ValidNumber(amountvalue.ToString())) Then
                    realitemcode = GetItemCode(mdicodestr)
                    ' Check for real item code
                    If realitemcode = "" Then
                        validdata = False
                        MsgBox("Invalid Item Code : " + mdicodestr)
                        'Exit For
                    Else
                        distributorcode.Value = "MDI00"
                        itemcode.Value = itemcodestr
                        oldmdicode.Value = mdicodestr
                        divcode.Value = divcodestr
                        quantity.Value = row.Cells(columnmdiqty).Value.ToString
                        amount.Value = row.Cells(columnmdiamt).Value.ToString
                        startdate.Value = dtpMonth.Text
                        enddate.Value = end_date
                        createddate.Value = create_date
                        'Insert MDI
                        BusinessObject.Sub_Insert(ServerPath2, "Util_BudgetDirect_Insert", CommandType.StoredProcedure, Paramsmdi)
                        row.DefaultCellStyle.BackColor = Color.Green
                    End If

                Else
                    row.DefaultCellStyle.BackColor = Color.Yellow
                    'Check row where Unit and Amount are greater than 0
                    If (Val(amountvalue) > 0 And Val(qtyvalue) > 0 And Val(aveprice) > 0) Then
                        row.DefaultCellStyle.BackColor = Color.Red
                        'MsgBox("Invalid Item Code : " + itemcodestr + " of item : " + itemdesc)
                    End If
                End If

                'Get Mercury
                qtyvalue = row.Cells(columnmerqty).Value.ToString
                amountvalue = row.Cells(columnmeramt).Value.ToString

                'Check for required fields : itemcode, itemdesc, qty, amount
                If (ValidString(itemcodestr) And ValidString(itemdesc) And ValidNumber(qtyvalue.ToString()) And ValidNumber(amountvalue.ToString())) Then
                    realitemcode = GetItemCode(mdicodestr)
                    ' Check for real item code
                    If realitemcode = "" Then
                        validdata = False
                        MsgBox("Invalid Item Code : " + mdicodestr)
                        'Exit For
                    Else
                        distributorcode.Value = "MER00"
                        itemcode.Value = itemcodestr
                        oldmdicode.Value = mdicodestr
                        divcode.Value = divcodestr
                        quantity.Value = row.Cells(columnmerqty).Value.ToString
                        amount.Value = row.Cells(columnmeramt).Value.ToString
                        startdate.Value = dtpMonth.Text
                        enddate.Value = end_date
                        createddate.Value = create_date
                        'Insert MDI
                        BusinessObject.Sub_Insert(ServerPath2, "Util_BudgetDirect_Insert", CommandType.StoredProcedure, Paramsmer)
                        row.DefaultCellStyle.BackColor = Color.Green
                    End If

                Else
                    row.DefaultCellStyle.BackColor = Color.Yellow
                    'Check row where Unit and Amount are greater than 0
                    If (Val(amountvalue) > 0 And Val(qtyvalue) > 0 And Val(aveprice) > 0) Then
                        row.DefaultCellStyle.BackColor = Color.Red
                        'MsgBox("Invalid Item Code : " + itemcodestr + " of item : " + itemdesc)
                    End If
                End If

                'Get GB
                qtyvalue = row.Cells(columngb_qty).Value.ToString
                amountvalue = row.Cells(columngb_amt).Value.ToString

                'Check for required fields : itemcode, itemdesc, qty, amount
                If (ValidString(itemcodestr) And ValidString(itemdesc) And ValidNumber(qtyvalue.ToString()) And ValidNumber(amountvalue.ToString())) Then
                    realitemcode = GetItemCode(mdicodestr)
                    ' Check for real item code
                    If realitemcode = "" Then
                        validdata = False
                        MsgBox("Invalid Item Code : " + mdicodestr)
                        'Exit For
                    Else
                        distributorcode.Value = "GB000"
                        itemcode.Value = itemcodestr
                        oldmdicode.Value = mdicodestr
                        divcode.Value = divcodestr
                        quantity.Value = row.Cells(columngb_qty).Value.ToString
                        amount.Value = row.Cells(columngb_amt).Value.ToString
                        startdate.Value = dtpMonth.Text
                        enddate.Value = end_date
                        createddate.Value = create_date
                        'Insert MDI
                        BusinessObject.Sub_Insert(ServerPath2, "Util_BudgetDirect_Insert", CommandType.StoredProcedure, Params_gb)
                        row.DefaultCellStyle.BackColor = Color.Green
                    End If

                Else
                    row.DefaultCellStyle.BackColor = Color.Yellow
                    'Check row where Unit and Amount are greater than 0
                    If (Val(amountvalue) > 0 And Val(qtyvalue) > 0 And Val(aveprice) > 0) Then
                        row.DefaultCellStyle.BackColor = Color.Red
                        'MsgBox("Invalid Item Code : " + itemcodestr + " of item : " + itemdesc)
                    End If
                End If
            End If
            rowcounter = rowcounter + 1
        Next
        If Not validdata Then
            'DeleteBudget(txtMrCode.Text.ToString(), dtpMonth.Value)
        Else
            'Save BudgetFile
            SaveBudgetFile(txtBudgetPath.Text, TabControl1.SelectedTab.Name, "Direct Budget", dtpMonth.Value)
        End If
    End Sub

    Private Function GetColumnMDIQty()
        Dim budgetmonth As Integer = dtpMonth.Value.Month
        Dim retval As String = ""
        Select Case budgetmonth
            Case 1
                retval = "F79"
            Case 2
                retval = "F89"
            Case 3
                retval = "F99"
            Case 4
                retval = "F109"
            Case 5
                retval = "F119"
            Case 6
                retval = "F129"
            Case 7
                retval = "F139"
            Case 8
                retval = "F149"
            Case 9
                retval = "F159"
            Case 10
                retval = "F169"
            Case 11
                retval = "F179"
            Case 12
                retval = "F189"
            Case Else
                MsgBox("Month not between 1 and 12, inclusive")
        End Select
        Return retval
    End Function
    Private Function GetColumnMercuryQty()
        Dim budgetmonth As Integer = dtpMonth.Value.Month
        Dim retval As String = ""
        Select Case budgetmonth
            Case 1
                retval = "F81"
            Case 2
                retval = "F91"
            Case 3
                retval = "F101"
            Case 4
                retval = "F111"
            Case 5
                retval = "F121"
            Case 6
                retval = "F131"
            Case 7
                retval = "F141"
            Case 8
                retval = "F151"
            Case 9
                retval = "F161"
            Case 10
                retval = "F171"
            Case 11
                retval = "F181"
            Case 12
                retval = "F191"
            Case Else
                MsgBox("Month not between 1 and 12, inclusive")
        End Select
        Return retval
    End Function
    Private Function GetColumnGBQty()
        Dim budgetmonth As Integer = dtpMonth.Value.Month
        Dim retval As String = ""
        Select Case budgetmonth
            Case 1
                retval = "F83"
            Case 2
                retval = "F93"
            Case 3
                retval = "F103"
            Case 4
                retval = "F113"
            Case 5
                retval = "F123"
            Case 6
                retval = "F133"
            Case 7
                retval = "F143"
            Case 8
                retval = "F153"
            Case 9
                retval = "F163"
            Case 10
                retval = "F173"
            Case 11
                retval = "F183"
            Case 12
                retval = "F193"
            Case Else
                MsgBox("Month not between 1 and 12, inclusive")
        End Select
        Return retval
    End Function

    Private Function GetColumnMDIAmt()
        Dim budgetmonth As Integer = dtpMonth.Value.Month
        Dim retval As String = ""
        Select Case budgetmonth
            Case 1
                retval = "F80"
            Case 2
                retval = "F90"
            Case 3
                retval = "F100"
            Case 4
                retval = "F110"
            Case 5
                retval = "F120"
            Case 6
                retval = "F130"
            Case 7
                retval = "F140"
            Case 8
                retval = "F150"
            Case 9
                retval = "F160"
            Case 10
                retval = "F170"
            Case 11
                retval = "F180"
            Case 12
                retval = "F190"
            Case Else
                MsgBox("Month not between 1 and 12, inclusive")
        End Select
        Return retval
    End Function
    Private Function GetColumnMercuryAmt()
        Dim budgetmonth As Integer = dtpMonth.Value.Month
        Dim retval As String = ""
        Select Case budgetmonth
            Case 1
                retval = "F82"
            Case 2
                retval = "F92"
            Case 3
                retval = "F102"
            Case 4
                retval = "F112"
            Case 5
                retval = "F122"
            Case 6
                retval = "F132"
            Case 7
                retval = "F142"
            Case 8
                retval = "F152"
            Case 9
                retval = "F162"
            Case 10
                retval = "F172"
            Case 11
                retval = "F182"
            Case 12
                retval = "F192"
            Case Else
                MsgBox("Month not between 1 and 12, inclusive")
        End Select
        Return retval
    End Function
    Private Function GetColumnGBAmt()
        Dim budgetmonth As Integer = dtpMonth.Value.Month
        Dim retval As String = ""
        Select Case budgetmonth
            Case 1
                retval = "F84"
            Case 2
                retval = "F94"
            Case 3
                retval = "F104"
            Case 4
                retval = "F114"
            Case 5
                retval = "F124"
            Case 6
                retval = "F134"
            Case 7
                retval = "F144"
            Case 8
                retval = "F154"
            Case 9
                retval = "F164"
            Case 10
                retval = "F174"
            Case 11
                retval = "F184"
            Case 12
                retval = "F194"
            Case Else
                MsgBox("Month not between 1 and 12, inclusive")
        End Select
        Return retval
    End Function

    Private Function ValidString(ByVal checkstring As String) As Boolean
        Dim retval As Boolean = True
        If String.IsNullOrEmpty(checkstring) Or checkstring.Trim() = "0" Or checkstring.Trim() = "-" Then
            retval = False
        End If
        Return retval
    End Function
    Private Function ValidNumber(ByVal checkstring As String) As Boolean
        Dim retval As Boolean = True
        Try
            If Not Double.Parse(checkstring) > 0 Then
                retval = False
            End If
        Catch ex As Exception
            retval = False
        End Try
        Return retval
    End Function


    Private Sub EnableSaveBudget(ByVal isenabled As Boolean)
        btnSaveBudget.Enabled = isenabled
    End Sub
    Private Function GetItemCode(ByVal itemcode As String) As String
        RemoteDataSet.Tables.Remove("Budget")
        RemoteDataSet.Tables.Add("Budget")
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(1) As SqlParameter
        Dim SearchName As New SqlParameter("@SearchName", SqlDbType.VarChar, 50) : SearchName.Direction = ParameterDirection.Input : SearchName.Value = "ITEMCODE" : Params(0) = SearchName
        Dim SearchCode As New SqlParameter("@SearchCode", SqlDbType.VarChar, 50) : SearchCode.Direction = ParameterDirection.Input : SearchCode.Value = itemcode : Params(1) = SearchCode

        BusinessObject.Sub_Show(ServerPath2, "Util_DataMap_Select", CommandType.StoredProcedure, RemoteDataSet, "Budget", Params)
        If RemoteDataSet.Tables("Budget").Rows.Count > 0 Then
            Return RemoteDataSet.Tables("Budget").Rows(0)("ReturnCode").ToString()
        Else
            Return ""
        End If

    End Function

    Private Sub DeleteBudget(ByVal mrcodestr As String, ByVal startdate As DateTime)
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter
        Dim start_date As New SqlParameter("@start_date", SqlDbType.DateTime, 10) : start_date.Direction = ParameterDirection.Input : start_date.Value = startdate : Params(0) = start_date
        BusinessObject.Sub_Delete(ServerPath2, "Util_BudgetDirect_Delete", CommandType.StoredProcedure, Params)
    End Sub
    Private Function ValidSpecialist(ByVal mrcodestr As String) As Boolean
        Dim retval As Boolean = True
        RemoteDataSet.Tables.Remove("Budget")
        RemoteDataSet.Tables.Add("Budget")
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter
        Dim mrcode As New SqlParameter("@mrcode", SqlDbType.VarChar, 10) : mrcode.Direction = ParameterDirection.Input : mrcode.Value = mrcodestr : Params(0) = mrcode

        BusinessObject.Sub_Show(ServerPath2, "Util_Specialist_Select", CommandType.StoredProcedure, RemoteDataSet, "Budget", Params)
        If Not RemoteDataSet.Tables("Budget").Rows.Count > 0 Then
            retval = False
        End If
        Return retval
    End Function

    Private Sub SaveBudgetFile(ByVal filestr As String, ByVal sheetstr As String, ByVal mrcodestr As String, ByVal cycledate As DateTime)
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(3) As SqlParameter

        Dim filename As New SqlParameter("@filename", SqlDbType.VarChar, 250) : filename.Direction = ParameterDirection.Input : filename.Value = filestr : Params(0) = filename
        Dim sheetname As New SqlParameter("@sheetname", SqlDbType.VarChar, 150) : sheetname.Direction = ParameterDirection.Input : sheetname.Value = sheetstr : Params(1) = sheetname
        Dim mrcode As New SqlParameter("@mrcode", SqlDbType.VarChar, 10) : mrcode.Direction = ParameterDirection.Input : mrcode.Value = mrcodestr : Params(2) = mrcode
        Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 2) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = cycledate : Params(3) = salescycledate

        BusinessObject.Sub_Insert(ServerPath2, "Util_BudgetFile_Insert", CommandType.StoredProcedure, Params)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub
End Class