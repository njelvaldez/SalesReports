Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports Microsoft
Imports Microsoft.Office.Interop
Imports System.Configuration
Imports System.Globalization
Imports System.IO
Imports System.Runtime.InteropServices
Public Class frmBudgetNatlTransfer
    Private RemoteDataSet As New DataSet
    'Private xl As New Excel.Application
    'Private wb As Excel.Workbook
    'Private ws As Excel.Worksheet
    Private budgetfileonly As String

    Private Sub frmBudgetNatlTransfer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            'wb.Close()
            'xl.Quit()
            'xl = Nothing
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmBudgetNatlTransfer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            '1256, 288
            dgvExcelBudget.Width = 1256
            dgvExcelBudget.Height = 288
            dgvExcelBudget.ScrollBars = ScrollBars.Both
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


    Private Sub SetDate()
        Dim currentdate As String
        currentdate = Now.Date.Month.ToString + "/1/" + Now.Date.Year.ToString
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
        OpenFileDialog1.Filter = "xls files (*.xls)|*.xls|Excel files (*.xls)|*.xls"
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
    Private Sub btnSaveBudget_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveBudget.Click
        Dim mrcode As String = ""
        Dim startdate As DateTime
        mrcode = txtMrCode.Text
        startdate = dtpMonth.Value
        'iF BUDGET EXIST AND MRCODE IS NOT BORILLO
        If BudgetExists(startdate) Then
            Dim result As Integer = MessageBox.Show("Budget already exists in database! Do you want to overwrite budget for specialist?", "Budget for Specialist", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
                'MessageBox.Show("Cancel pressed")
            ElseIf result = DialogResult.No Then
                'MessageBox.Show("No pressed")
            ElseIf result = DialogResult.Yes Then
                DeleteBudgetTransfers(startdate)
                'Save Budget
                Me.Cursor = Cursors.WaitCursor
                SaveBudget(dtpMonth.Value.Month)
                Me.Cursor = Cursors.Default
                MsgBox("Saving of budget for " + txtMrCode.Text + " is complete.")
            End If
        Else
            'Save Budget
            Me.Cursor = Cursors.WaitCursor
            SaveBudget(dtpMonth.Value.Month)
            Me.Cursor = Cursors.Default
            MsgBox("Saving of budget for " + txtMrCode.Text + " is complete.")
        End If

    End Sub

    Private Function BudgetExists(ByVal startdate As DateTime) As Boolean
        RemoteDataSet.Tables.Remove("Budget")
        RemoteDataSet.Tables.Add("Budget")
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter
        Dim start_date As New SqlParameter("@start_date", SqlDbType.DateTime, 10) : start_date.Direction = ParameterDirection.Input : start_date.Value = startdate : Params(0) = start_date

        BusinessObject.Sub_Show(ServerPath2, "Util_BudgetTransferExists", CommandType.StoredProcedure, RemoteDataSet, "Budget", Params)
        Return RemoteDataSet.Tables("Budget").Rows.Count > 0
    End Function

    Private Sub SaveBudget(budgetmonth As Integer)
        Dim dgvfromactivetab As DataGridView
        Dim rowcounter = 1
        Dim mrcodestr As String
        Dim itemcodestr As String
        Dim realitemcode As String
        Dim itemdesc As String
        Dim aveprice As String
        Dim columnqty As String = ""
        Dim columnamt As String = ""
        Dim govcolumnqty As String = ""
        Dim govcolumnamt As String = ""

        'Dim aveprice As Double
        Dim qtyvalue As String
        Dim amountvalue As String
        Dim govqtyvalue As String
        Dim govamountvalue As String
        Dim validdata As Boolean = True
        Dim lastdayofmonth As Integer = 1
        Dim enddate As String
        Dim createdate As String
        'lastdayofmonth = Date.DaysInMonth(dtpMonth.Value.Year, dtpMonth.Value.Month)
        'enddate = dtpMonth.Value.Month.ToString.Trim() + "/" + lastdayofmonth.ToString.Trim() + "/" + dtpMonth.Value.Year.ToString()
        'createdate = DateTime.Now.Month.ToString.Trim() + "/" + DateTime.Now.Day.ToString.Trim() + "/" + DateTime.Now.Year.ToString.Trim()
        lastdayofmonth = Date.DaysInMonth(dtpMonth.Value.Year, budgetmonth)
        enddate = budgetmonth.ToString.Trim() + "/" + lastdayofmonth.ToString.Trim() + "/" + dtpMonth.Value.Year.ToString()
        createdate = DateTime.Now.Month.ToString.Trim() + "/" + DateTime.Now.Day.ToString.Trim() + "/" + DateTime.Now.Year.ToString.Trim()

        dgvfromactivetab = TabControl1.SelectedTab.Controls(0)
        'Loop Sales Grid
        columnqty = GetColumnQty(budgetmonth)
        columnamt = GetColumnAmt(budgetmonth)

        govcolumnqty = GetGovColumnQty(budgetmonth)
        govcolumnamt = GetGovColumnAmt(budgetmonth)

        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(4) As SqlParameter
        Dim itemcode As New SqlParameter("@itemcode", SqlDbType.VarChar, 10) : itemcode.Direction = ParameterDirection.Input : itemcode.Value = "" : Params(0) = itemcode
        Dim qty As New SqlParameter("@qty", SqlDbType.Money, 16) : qty.Direction = ParameterDirection.Input : qty.Value = "0" : Params(1) = qty
        Dim amount As New SqlParameter("@amount", SqlDbType.Money, 16) : amount.Direction = ParameterDirection.Input : amount.Value = "0" : Params(2) = amount
        Dim start_date As New SqlParameter("@start_date", SqlDbType.DateTime, 10) : start_date.Direction = ParameterDirection.Input : start_date.Value = "" : Params(3) = start_date
        Dim end_date As New SqlParameter("@end_date", SqlDbType.DateTime, 10) : end_date.Direction = ParameterDirection.Input : end_date.Value = "" : Params(4) = end_date

        For Each row As DataGridViewRow In dgvfromactivetab.Rows
            If Not row.IsNewRow And rowcounter >= 9 Then
                itemcodestr = row.Cells(0).Value.ToString
                itemdesc = row.Cells("F2").Value.ToString
                aveprice = row.Cells("F3").Value.ToString
                qtyvalue = row.Cells(columnqty).Value.ToString
                amountvalue = row.Cells(columnamt).Value.ToString

                'govqtyvalue = row.Cells(govcolumnqty).Value.ToString
                'govamountvalue = row.Cells(govcolumnamt).Value.ToString

                'Check for required fields : itemcode, itemdesc, qty, amount
                If (ValidString(itemcodestr) And ValidString(itemdesc) And ValidNumber(qtyvalue.ToString()) And ValidNumber(amountvalue.ToString())) Then  'Or _
                    '(ValidString(itemcodestr) And ValidString(itemdesc) And ValidNumber(govqtyvalue.ToString()) And ValidNumber(govamountvalue.ToString())) Then
                    realitemcode = GetItemCode(itemcodestr)
                    ' Check for real item code
                    If realitemcode = "" Then
                        validdata = False
                        MsgBox("Invalid Item Code!")
                        Exit For
                    Else
                        itemcode.Value = realitemcode
                        qty.Value = row.Cells(columnqty).Value.ToString
                        amount.Value = row.Cells(columnamt).Value.ToString
                        start_date.Value = GetDateFromMonth(budgetmonth).ToString.Trim    'dtpMonth.Text
                        end_date.Value = enddate

                        Try
                            BusinessObject.Sub_Insert(ServerPath2, "Util_BudgetTransfer_Insert", CommandType.StoredProcedure, Params)
                            row.DefaultCellStyle.BackColor = Color.Green
                        Catch ex As Exception
                            row.DefaultCellStyle.BackColor = Color.Red
                            MsgBox(ex.Message)
                        End Try
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
            'SaveBudgetFile(txtBudgetPath.Text, TabControl1.SelectedTab.Name, txtMrCode.Text, dtpMonth.Value)
            'SaveBudgetFile(txtBudgetPath.Text, TabControl1.SelectedTab.Name, txtMrCode.Text, GetDateFromMonth(budgetmonth))
        End If
    End Sub
    Private Function GetDateFromMonth(nmonth As Integer) As Date
        Dim retval As Date
        retval = Convert.ToDateTime(nmonth.ToString.Trim & "/1/" & dtpMonth.Value.Year.ToString.Trim)
        Return retval
    End Function

    Private Function GetColumnQty(budgetmonth As Integer)
        'Dim budgetmonth As Integer = dtpMonth.Value.Month
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

    Private Function GetGovColumnQty(budgetmonth As Integer)
        'Dim budgetmonth As Integer = dtpMonth.Value.Month
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

    Private Function GetGovColumnAmt(budgetmonth As Integer)
        'Dim budgetmonth As Integer = dtpMonth.Value.Month
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

    Private Function GetColumnAmt(budgetmonth As Integer)
        'Dim budgetmonth As Integer = dtpMonth.Value.Month
        Dim retval As String = ""
        Select Case budgetmonth
            Case 1
                retval = "F85"
            Case 2
                retval = "F95"
            Case 3
                retval = "F105"
            Case 4
                retval = "F115"
            Case 5
                retval = "F125"
            Case 6
                retval = "F135"
            Case 7
                retval = "F145"
            Case 8
                retval = "F155"
            Case 9
                retval = "F165"
            Case 10
                retval = "F175"
            Case 11
                retval = "F185"
            Case 12
                retval = "F195"
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

    Private Sub DeleteBudgetTransfers(ByVal startdate As DateTime)
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(1) As SqlParameter
        Dim start_date As New SqlParameter("@start_date", SqlDbType.DateTime, 10) : start_date.Direction = ParameterDirection.Input : start_date.Value = startdate : Params(0) = start_date
        BusinessObject.Sub_Delete(ServerPath2, "Util_BudgetTransfer_Delete", CommandType.StoredProcedure, Params)
    End Sub

    Private Sub btnOpenBudgetFromList_Click(sender As Object, e As EventArgs) Handles btnOpenBudgetFromList.Click
        Dim row As Integer = dgvPreviousBudget.CurrentRow.Index
        Dim filename As String
        KillExcellApp()
        If row > -1 Then
            filename = dgvPreviousBudget.Rows(row).Cells("FileName").Value.ToString()
        Else
            filename = ""
        End If
        txtBudgetPath.Text = filename
        Dim fi As New FileInfo(filename)
        budgetfileonly = fi.FullName
        OpenBudgetFile(txtBudgetPath.Text)
        EnableSaveBudget(True)
    End Sub


    Private Sub TabControl1_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl1.Selected
    End Sub

    Private Sub btnSaveYearly_Click(sender As Object, e As EventArgs) Handles btnSaveYearly.Click
        Dim mrcode As String = ""
        Dim startdate As DateTime
        Dim syear As String = Now.Year.ToString
        mrcode = txtMrCode.Text
        startdate = dtpMonth.Value
        'Save Yearly Budget
        Me.Cursor = Cursors.Default
        For i As Integer = 1 To 12
            'iF BUDGET EXIST AND MRCODE IS NOT BORILLO
            startdate = i.ToString.Trim & "/1/" & syear
            ' If BudgetExists(mrcode, startdate) And Not (mrcode = "00494" Or mrcode = "T2020" Or mrcode = "00644") Then
            If BudgetExists(startdate) Then
                Dim result As Integer = MessageBox.Show("Budget already exists in database! Do you want to overwrite budget for specialist?Yes to overwrite or No to Append or Cancel to do nothing!", "Budget for Specialist", MessageBoxButtons.YesNoCancel)
                If result = DialogResult.Cancel Then
                    'MessageBox.Show("Cancel pressed")
                ElseIf result = DialogResult.No Then
                    'Append budget to existing budget
                    SaveBudget(i)
                ElseIf result = DialogResult.Yes Then
                    DeleteBudgetTransfers(startdate)
                    'Save Budget
                    Me.Cursor = Cursors.WaitCursor
                    SaveBudget(i)
                    'MsgBox("Saving of budget for " + txtMrCode.Text + " is complete.")
                End If
            Else
                'Save Budget
                Me.Cursor = Cursors.WaitCursor
                SaveBudget(i)
            End If
        Next
        Me.Cursor = Cursors.Default
        MsgBox("Saving of budget for " + txtMrCode.Text + " is complete.")
    End Sub
End Class