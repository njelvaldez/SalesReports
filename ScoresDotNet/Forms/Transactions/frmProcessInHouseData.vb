Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Text
Imports System.Configuration

Public Class frmProcessInHouseData
    Inherits System.Windows.Forms.Form
    Private parCommissionDate As String
    Private UpdateString As String
    Private strFromFile As String
    Private SalesClass, SubSaleType, SubSubSaleType As String
    Private CommissionDate As String


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnFile As System.Windows.Forms.Button
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents MonthCalendar As System.Windows.Forms.MonthCalendar
    Friend WithEvents NewCustomerCount As System.Windows.Forms.Label
    Friend WithEvents NewItemCount As System.Windows.Forms.Label
    Friend WithEvents InputCount As System.Windows.Forms.Label
    Friend WithEvents ProcessedCount As System.Windows.Forms.Label
    Friend WithEvents chkProcess As System.Windows.Forms.CheckBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents InputAmount As System.Windows.Forms.Label
    Friend WithEvents ProcessedAmount As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.btnFile = New System.Windows.Forms.Button
        Me.txtFileName = New System.Windows.Forms.TextBox
        Me.MonthCalendar = New System.Windows.Forms.MonthCalendar
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnProcess = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.NewCustomerCount = New System.Windows.Forms.Label
        Me.NewItemCount = New System.Windows.Forms.Label
        Me.InputCount = New System.Windows.Forms.Label
        Me.ProcessedCount = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.chkProcess = New System.Windows.Forms.CheckBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.InputAmount = New System.Windows.Forms.Label
        Me.ProcessedAmount = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnFile
        '
        Me.btnFile.Location = New System.Drawing.Point(424, 29)
        Me.btnFile.Name = "btnFile"
        Me.btnFile.Size = New System.Drawing.Size(24, 20)
        Me.btnFile.TabIndex = 0
        Me.btnFile.Text = "..."
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(192, 29)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(224, 20)
        Me.txtFileName.TabIndex = 1
        Me.txtFileName.Text = ""
        '
        'MonthCalendar
        '
        Me.MonthCalendar.Location = New System.Drawing.Point(8, 9)
        Me.MonthCalendar.MinDate = New Date(2009, 1, 1, 0, 0, 0, 0)
        Me.MonthCalendar.Name = "MonthCalendar"
        Me.MonthCalendar.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(192, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Please select a file to process..."
        '
        'btnProcess
        '
        Me.btnProcess.Location = New System.Drawing.Point(352, 56)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(96, 20)
        Me.btnProcess.TabIndex = 4
        Me.btnProcess.Text = "Process"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(192, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 8)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Tag = "`"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(192, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Processed Data Results :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(192, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "New Customer(s)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(192, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "New Item(s)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(192, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Input File Transactions"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(192, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Transactions Processed"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NewCustomerCount
        '
        Me.NewCustomerCount.Location = New System.Drawing.Point(328, 115)
        Me.NewCustomerCount.Name = "NewCustomerCount"
        Me.NewCustomerCount.Size = New System.Drawing.Size(88, 16)
        Me.NewCustomerCount.TabIndex = 15
        Me.NewCustomerCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NewItemCount
        '
        Me.NewItemCount.Location = New System.Drawing.Point(328, 134)
        Me.NewItemCount.Name = "NewItemCount"
        Me.NewItemCount.Size = New System.Drawing.Size(88, 16)
        Me.NewItemCount.TabIndex = 16
        Me.NewItemCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'InputCount
        '
        Me.InputCount.Location = New System.Drawing.Point(328, 153)
        Me.InputCount.Name = "InputCount"
        Me.InputCount.Size = New System.Drawing.Size(88, 16)
        Me.InputCount.TabIndex = 17
        Me.InputCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ProcessedCount
        '
        Me.ProcessedCount.Location = New System.Drawing.Point(328, 172)
        Me.ProcessedCount.Name = "ProcessedCount"
        Me.ProcessedCount.Size = New System.Drawing.Size(88, 16)
        Me.ProcessedCount.TabIndex = 18
        Me.ProcessedCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(424, 115)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 16)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "..."
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(424, 134)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(24, 16)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "..."
        '
        'chkProcess
        '
        Me.chkProcess.Location = New System.Drawing.Point(192, 56)
        Me.chkProcess.Name = "chkProcess"
        Me.chkProcess.Size = New System.Drawing.Size(104, 16)
        Me.chkProcess.TabIndex = 21
        Me.chkProcess.Text = "Full Processing"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(424, 153)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(24, 16)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "..."
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(424, 172)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(24, 16)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "..."
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(192, 191)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 16)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Input Amount"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(192, 210)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 16)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Processed Amount"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'InputAmount
        '
        Me.InputAmount.Location = New System.Drawing.Point(328, 191)
        Me.InputAmount.Name = "InputAmount"
        Me.InputAmount.Size = New System.Drawing.Size(88, 16)
        Me.InputAmount.TabIndex = 26
        Me.InputAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ProcessedAmount
        '
        Me.ProcessedAmount.Location = New System.Drawing.Point(328, 210)
        Me.ProcessedAmount.Name = "ProcessedAmount"
        Me.ProcessedAmount.Size = New System.Drawing.Size(88, 16)
        Me.ProcessedAmount.TabIndex = 27
        Me.ProcessedAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(424, 191)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(24, 16)
        Me.Button5.TabIndex = 28
        Me.Button5.Text = "..."
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(424, 210)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(24, 16)
        Me.Button6.TabIndex = 29
        Me.Button6.Text = "..."
        '
        'frmProcessInHouseData
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(456, 238)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.ProcessedAmount)
        Me.Controls.Add(Me.InputAmount)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.chkProcess)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ProcessedCount)
        Me.Controls.Add(Me.InputCount)
        Me.Controls.Add(Me.NewItemCount)
        Me.Controls.Add(Me.NewCustomerCount)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.MonthCalendar)
        Me.Controls.Add(Me.btnFile)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProcessInHouseData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Process InHouse Data"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub btnFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFile.Click

        Dim File As String
        OpenFileDialog.Filter = "Csv files (*.csv)|*.csv|All files (*.*)|*.*"
        OpenFileDialog.ShowDialog(Me)
        txtFileName.Text = OpenFileDialog.FileName
        File = Mid(OpenFileDialog.FileName, OpenFileDialog.FileName.LastIndexOf("\") + 2)

    End Sub

    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click

        If txtFileName.Text = "" Then
            Return
        Else
            Me.Cursor = Cursors.WaitCursor
            'ConvertToExcel(OpenFileDialog.FileName)
            Extract_ExcelFileData(OpenFileDialog.FileName)
            If UpdateFromFileField() = True Then
                MessageBox.Show("In-House Data processing complete!")
                Dim salesdate As DateTime
                salesdate = MonthCalendar.SelectionRange.Start.Month.ToString.Trim & _
                      "/1/" & MonthCalendar.SelectionRange.Start.Year.ToString.Trim
                RecordSubDistSales(Convert.ToDateTime(salesdate))
            Else
                MessageBox.Show("Command Execution Disrupted!")
            End If
            Me.Cursor = Cursors.Default
        End If

    End Sub

    Private Function UpdateFromFileField() As Boolean

        Dim myParameter(,) As Object

        If CommissionDate > "" Then
            strFromFile = CommissionDate & "-" & Microsoft.VisualBasic.Right(OpenFileDialog.FileName, _
            Len(OpenFileDialog.FileName) - (OpenFileDialog.FileName.LastIndexOf("\") + 1))

            'Initialize the Data to avoid duplicates
            UpdateString = "Delete from InHouseData where FromFile=" & "'" & strFromFile & "'"
            DataMaintenance.ExecuteCommand(ServerPath2, UpdateString, CommandType.Text)

            'Upload Parameters
            UpdateString = "FixInHouseRawData"
            SetupParameters(0, "@FileName", SqlDbType.VarChar, 150, "String", strFromFile)
            If DataMaintenance.ExecuteCommand(ServerPath2, UpdateString, CommandType.StoredProcedure, 1) = False Then
                Return False
                Exit Function
            End If
        Else
            MessageBox.Show("Please select a date!")
            Exit Function
        End If
        'GetNewCustomers("Count")
        'GetNewCustomers("Rows")
        'GetNewItems("Count")
        'GetNewItems("Rows")
        If chkProcess.CheckState = CheckState.Checked Then
            'Upload Parameters
            'Check Segment Rule here
            If ConfigurationSettings.AppSettings("UseSegmentRule") = "0" Then
                UpdateString = "ProcessData_InHouseData"
            Else
                UpdateString = "SegmentRule_ProcessData_InHouseData"
            End If

            SetupParameters(0, "@FileName", SqlDbType.VarChar, 100, "String", strFromFile)
            SetupParameters(1, "@CommissionDate", SqlDbType.DateTime, 10, "Date", parCommissionDate)
            DataMaintenance.ExecuteCommand(ServerPath2, UpdateString, CommandType.StoredProcedure, 2)
        End If
            GetRowCount("Input")
            GetPesoAmounts("Input")
            GetRowCount("Processed")
            GetPesoAmounts("Processed")
            Return True

    End Function

    Private Sub MonthCalendar_DateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar.DateChanged

        SetCommissionDates()

    End Sub

    Private Sub MonthCalendar_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles _
    MonthCalendar.DateSelected

        SetCommissionDates()

    End Sub

    Private Sub SetCommissionDates()

        CommissionDate = MonthCalendar.SelectionStart.Month.ToString & MonthCalendar.SelectionStart.Year.ToString
        'parCommissionDate = "'" & MonthCalendar.SelectionStart.Month.ToString & "/1/" & _
        'MonthCalendar.SelectionStart.Year.ToString & "'"
        parCommissionDate = MonthCalendar.SelectionStart.Month.ToString & "/1/" & _
        MonthCalendar.SelectionStart.Year.ToString

    End Sub

    Private Sub GetNewCustomers(ByVal ResultType As String)

        Select Case ResultType
            Case "Count"
                UpdateString = "Select count(FromFile) from InHouseData where " & _
                "CustCode not in (select custcode from newscores..customer) and " & _
                "FromFile = " & " '" & strFromFile & "'"
                NewCustomerCount.Text = CStr(CInt(DataMaintenance.GetSingleResult(ServerPath2, UpdateString, CommandType.Text)))
            Case "Rows"
                Dim MyResultSet As SqlDataReader
                UpdateString = "select CustCode ,CustName ," & _
                "Address1,Address2 from InHouseData where CustCode not in" & _
                "(select custcode from newscores..customer) and " & _
                "FromFile = " & " '" & strFromFile & "'" & _
                "group by custcode, CustName, Address1, Address2"
                MyResultSet = DataMaintenance.GetResultSet(ServerPath2, UpdateString, CommandType.Text)

                Dim myLine As String
                Dim xl As New Microsoft.Office.Interop.Excel.Application
                Dim myWorkBook As Excel.Workbook
                Dim mySheets As Excel.Sheets
                Dim myWorkSheet As Excel.Worksheet
                Dim intLine As Integer = 2
                If MyResultSet.HasRows = True Then
                    'Open a New Workbook
                    myWorkBook = xl.Workbooks.Add("C:\NewCustTemplate2.xls")
                    mySheets = myWorkBook.Sheets
                    myWorkSheet = CType(mySheets.Item("Sheet1"), Excel.Worksheet)
                    With myWorkSheet
                        While MyResultSet.Read()
                            .Range("A" & intLine).NumberFormat = "@"
                            .Cells(intLine, 1) = CStr(MyResultSet("CustCode"))
                            .Cells(intLine, 2) = CStr(MyResultSet("CustName"))
                            .Cells(intLine, 3) = CStr(MyResultSet("Address1"))
                            .Cells(intLine, 4) = CStr(MyResultSet("Address2"))
                            intLine = intLine + 1
                        End While
                    End With
                    myWorkBook.SaveAs("C:\" & "New Customer - " & strFromFile & ".xls")
                    myWorkBook.Close()

                    MessageBox.Show("File Location : " & "C:\" & vbCrLf & _
                    "File Name : " & vbCrLf & "New Customer - " & strFromFile & ".xls", _
                    "New Customer File", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
        End Select

    End Sub

    Private Sub GetNewItems(ByVal ResultType As String)

        Select Case ResultType
            Case "Count"
                UpdateString = "Select count(FromFile) from InHouseData where " & _
                "ItemNo not in (select itemcode from newscores..item where itemcode>'') and " & _
                "FromFile = " & " '" & strFromFile & "'"
                NewItemCount.Text = CStr(CInt(DataMaintenance.GetSingleResult(ServerPath2, UpdateString, CommandType.Text)))
            Case "Rows"
                Dim MyResultSet As SqlDataReader
                UpdateString = "select itemno [ItemCode],itemdesc ," & _
                "listprice [UnitPrice] from InHouseData where itemno not in" & _
                "(select itemcode from newscores..item where itemcode>'') and " & _
                "FromFile = " & " '" & strFromFile & "'" & _
                "group by itemno,itemdesc,listprice"
                MyResultSet = DataMaintenance.GetResultSet(ServerPath2, UpdateString, CommandType.Text)

                Dim myLine As String
                Dim xl As New Excel.Application
                Dim myWorkBook As Excel.Workbook
                Dim mySheets As Excel.Sheets
                Dim myWorkSheet As Excel.Worksheet
                Dim intLine As Integer = 2
                If MyResultSet.HasRows = True Then
                    'Open a New Workbook
                    myWorkBook = xl.Workbooks.Add("C:\NewItemTemplate2.xls")
                    mySheets = myWorkBook.Sheets
                    myWorkSheet = CType(mySheets.Item("Sheet1"), Excel.Worksheet)
                    With myWorkSheet
                        While MyResultSet.Read()
                            .Cells(intLine, 1) = CStr(MyResultSet("ItemCode"))
                            .Cells(intLine, 2) = CStr(MyResultSet("ItemDesc"))
                            .Cells(intLine, 3) = CStr(MyResultSet("UnitPrice"))
                            intLine = intLine + 1
                        End While
                    End With
                    myWorkBook.SaveAs("C:\" & "New Item - " & strFromFile & ".xls")
                    myWorkBook.Close()
                    MessageBox.Show("File Location : " & "C:\" & vbCrLf & _
                    "File Name : " & vbCrLf & "New Item - " & strFromFile & ".xls", _
                    "New Item File", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
        End Select

    End Sub

    Private Sub GetRowCount(ByVal CountType As String)

        UpdateString = "select SalesClass " & _
                       "from InHouseData " & _
                       " where FromFile = " & " '" & strFromFile & "'" & _
                       " group by SalesClass"

        Dim myResultSet As SqlDataReader
        myResultSet = DataMaintenance.GetResultSet(ServerPath2, UpdateString, CommandType.Text)
        If myResultSet.HasRows = True Then
            While myResultSet.Read
                SalesClass = CStr(myResultSet("SalesClass"))
            End While
        End If

        Select Case CountType
            Case "Input"
                UpdateString = "Select count(FromFile) from InHouseData where " & _
                               "FromFile = " & " '" & strFromFile & "'"
                InputCount.Text = CStr(CInt(DataMaintenance.GetSingleResult(ServerPath2, UpdateString, CommandType.Text)))
            Case "Processed"
                UpdateString = "Select count(Rowid) from IntegratedSales where " & _
                               "SalesCycleDate = '" & parCommissionDate & _
                               "' and SalesClass=" & "'" & SalesClass & "'" & _
                               " and SaleType='InHouse' "
                ProcessedCount.Text = CStr(CInt(DataMaintenance.GetSingleResult(ServerPath2, UpdateString, CommandType.Text)))
        End Select

    End Sub

    Private Sub GetPesoAmounts(ByVal AmountType As String)

        Select Case AmountType
            Case "Input"
                UpdateString = "Select sum(ValAmt) from InHouseData where " & _
                               "FromFile = " & " '" & strFromFile & "'"
                InputAmount.Text = Format(CInt(DataMaintenance.GetSingleResult(ServerPath2, UpdateString, CommandType.Text)), _
                "###,###,##0.00")
            Case "Processed"
                UpdateString = "Select sum(creditedamount) from IntegratedSales where " & _
                                               "SalesCycleDate = '" & parCommissionDate & _
                                               "' and SalesClass=" & "'" & SalesClass & "'" & _
                                               " and SaleType='InHouse'"
                ProcessedAmount.Text = Format(CInt(DataMaintenance.GetSingleResult(ServerPath2, UpdateString, CommandType.Text)), _
                "###,###,##0.00")
        End Select

    End Sub

    Private Sub Extract_ExcelFileData(ByVal strFileName As String)

        Dim xl As New Excel.Application
        Dim wb As Excel.Workbook
        Dim ws As Excel.Worksheet
        Dim range As Excel.Range
        Dim CustCode, CustName, Address1, Address2, ShipTo, ShipToAddress1, ShipToAddress2 As String
        Dim RefNo, RefDate, SoNumber, SoDate, TransType, SalesType, ItemCode, ItemDesc, CompanyCode, _
        LotNumber, ExpiryDate, QtySold, QtyFree, UnitPrice, GrossAmount, Discount, Vat, NetAmount As String
        Dim Tax, CmCode, CmRefInvoice, CmRefDate, PostingDate As String

        Dim i As Integer = 2
        Try
            wb = xl.Workbooks.Open(strFileName)
            ws = CType(wb.Worksheets.Item("SalesQuery"), Excel.Worksheet)
            ws.Range("A1", "AD1000").EntireColumn.AutoFit()
            With ws
                Do
                    CustCode = CStr(.Range("A" & i).Text)
                    CustCode = CustCode.Trim()
                    If CustCode = String.Empty Then Exit Do
                    CustName = CStr(.Range("B" & i).Text)
                    Address1 = CStr(.Range("C" & i).Text)
                    Address2 = CStr(.Range("D" & i).Text)
                    If CustCode = String.Empty And CustName > "" Then ThrowException("Customer Code", i)
                    ShipTo = CStr(.Range("E" & i).Text)
                    ShipToAddress1 = CStr(.Range("F" & i).Text)
                    ShipToAddress2 = CStr(.Range("G" & i).Text)
                    RefNo = CStr(.Range("H" & i).Text)
                    RefDate = CStr(.Range("I" & i).Text)
                    If RefDate = String.Empty Then ThrowException("Ref Date", i)
                    SoNumber = CStr(.Range("J" & i).Text)
                    SoDate = CStr(.Range("K" & i).Text)
                    TransType = CStr(.Range("L" & i).Text)
                    SalesType = CStr(.Range("M" & i).Text)
                    ItemCode = CStr(.Range("N" & i).Text)
                    ItemCode = ItemCode.Trim()
                    ItemDesc = CStr(.Range("O" & i).Text)
                    CompanyCode = CStr(.Range("P" & i).Text)
                    LotNumber = CStr(.Range("Q" & i).Text)
                    ExpiryDate = CStr(.Range("R" & i).Text)
                    If ExpiryDate = String.Empty Then ThrowException("Expiry Date", i)
                    QtySold = CStr(.Range("S" & i).Text)
                    If QtySold = String.Empty Then ThrowException("Qty Sold", i)
                    QtyFree = CStr(.Range("T" & i).Text)
                    If QtyFree = String.Empty Then ThrowException("Qty Free", i)
                    UnitPrice = CStr(.Range("U" & i).Text)
                    If UnitPrice = String.Empty Then ThrowException("Unit Price", i)
                    GrossAmount = CStr(.Range("V" & i).Text)
                    If GrossAmount = String.Empty Then ThrowException("Gross Amount", i)
                    Discount = CStr(.Range("W" & i).Text)
                    Vat = CStr(.Range("X" & i).Text)
                    NetAmount = CStr(.Range("Y" & i).Text)
                    If NetAmount = String.Empty Then ThrowException("Net Amount", i)
                    Tax = CStr(.Range("Z" & i).Text)
                    CmCode = CStr(.Range("AA" & i).Text)
                    CmRefInvoice = CStr(.Range("AB" & i).Text)
                    CmRefDate = CStr(.Range("AC" & i).Text)
                    PostingDate = CStr(.Range("AD" & i).Text)
                    If PostingDate = String.Empty Then ThrowException("Posting Date", i)

                    Insert_ExcelFile(CustCode, CustName, Address1, Address2, ShipTo, ShipToAddress1, _
                    ShipToAddress2, RefNo, RefDate, SoNumber, SoDate, TransType, SalesType, ItemCode, ItemDesc, _
                    CompanyCode, LotNumber, ExpiryDate, QtySold, QtyFree, UnitPrice, GrossAmount, Discount, _
                    Vat, NetAmount, Tax, CmCode, CmRefInvoice, CmRefDate, PostingDate, i.ToString())
                    i = i + 1
                Loop Until CustCode = ""
            End With

        Catch ex As Exception
            LogError(ex)
            MsgBox(ex.Message)
        Finally
            'xl.DisplayAlerts = False
            wb.Saved = True
            wb.Close()
            xl = Nothing
        End Try

    End Sub

    Private Sub ConvertToExcel(ByVal file As String)

        Dim xl As New Excel.Application
        Dim wb As Excel.Workbook

        Try
            wb = xl.Workbooks.Open(file)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub ThrowException(ByVal ColName As String, ByVal RowNumber As Integer)

        Throw New System.Exception(ColName & " not Found at Row Number : " & RowNumber.ToString())

    End Sub

    Private Sub Insert_ExcelFile(ByVal ParamArray SubData() As String)

        SetupParameters(0, "@CustCode", SqlDbType.VarChar, 11, "String", SubData(0).ToString)
        SetupParameters(1, "@CustName", SqlDbType.VarChar, 50, "String", SubData(1).ToString)
        SetupParameters(2, "@Address1", SqlDbType.VarChar, 50, "String", SubData(2).ToString)
        SetupParameters(3, "@Address2", SqlDbType.VarChar, 50, "String", SubData(3).ToString)
        SetupParameters(4, "@ShipToName", SqlDbType.VarChar, 50, "String", SubData(4).ToString)
        SetupParameters(5, "@ShipAddress1", SqlDbType.VarChar, 50, "String", SubData(5).ToString)
        SetupParameters(6, "@ShipAddress2", SqlDbType.VarChar, 50, "String", SubData(6).ToString)
        SetupParameters(7, "@RefCode", SqlDbType.VarChar, 10, "String", SubData(7).ToString)
        SetupParameters(8, "@RefDate", SqlDbType.DateTime, 8, "Date", SubData(8).ToString)
        SetupParameters(9, "@SoCode", SqlDbType.VarChar, 10, "String", SubData(9).ToString)
        SetupParameters(10, "@SoDate", SqlDbType.DateTime, 8, "Date", SubData(10).ToString)
        SetupParameters(11, "@TransType", SqlDbType.VarChar, 2, "String", SubData(11).ToString)
        SetupParameters(12, "@SalesType", SqlDbType.VarChar, 2, "String", SubData(12).ToString)
        SetupParameters(13, "@ItemNo", SqlDbType.VarChar, 8, "String", SubData(13).ToString)
        SetupParameters(14, "@ItemDesc", SqlDbType.VarChar, 50, "String", SubData(14).ToString)
        SetupParameters(15, "@CompanyCode", SqlDbType.VarChar, 8, "String", SubData(15).ToString)
        SetupParameters(16, "@LotNo", SqlDbType.VarChar, 15, "String", SubData(16).ToString)
        SetupParameters(17, "@ExpDate", SqlDbType.DateTime, 8, "Date", SubData(17).ToString)
        SetupParameters(18, "@QtyOrder", SqlDbType.Int, 4, "Integer", SubData(18).ToString)
        SetupParameters(19, "@QtyFree", SqlDbType.Int, 4, "Integer", SubData(19).ToString)
        SetupParameters(20, "@ListPrice", SqlDbType.Money, 4, "Integer", SubData(20).ToString)
        SetupParameters(21, "@ValAmt", SqlDbType.Money, 4, "Integer", SubData(21).ToString)
        SetupParameters(22, "@Discount", SqlDbType.Money, 4, "Integer", SubData(22).ToString)
        SetupParameters(23, "@Vat", SqlDbType.Money, 4, "Integer", SubData(23).ToString)
        SetupParameters(24, "@NetAmount", SqlDbType.Money, 4, "Integer", SubData(24).ToString)
        SetupParameters(25, "@Tax", SqlDbType.Money, 4, "Integer", SubData(25).ToString)
        SetupParameters(26, "@CmReasonCode", SqlDbType.VarChar, 3, "String", SubData(26).ToString)
        SetupParameters(27, "@CmRefInvoice", SqlDbType.VarChar, 10, "String", SubData(27).ToString)
        SetupParameters(28, "@CmRefDate", SqlDbType.DateTime, 8, "Date", SubData(28).ToString)
        SetupParameters(29, "@PostingDate", SqlDbType.DateTime, 8, "Date", SubData(29).ToString)

        Try
            DataMaintenance.ExecuteCommand(ServerPath2, "Insert_InHouseData", CommandType.StoredProcedure, 30)
        Catch ex As Exception
            Throw New Exception("There is an error inserting to InHouseData table at row(" & SubData(29).ToString() & ")." _
            & ex.Message)
        End Try

    End Sub

    Private Sub Frm_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed

        EnDisMainMenu(Me, True)
        'ChildCtr = ChildCtr - 1              '<--ready for 2forms need

    End Sub

    Private Sub Frm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated

        EnDisMainMenu(Me, False)

    End Sub

    Private Sub frmProcessInMarketData_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _
    MyBase.MouseMove

        'If CloseFrm = True Then              '<- ready
        '    CloseFrm = False                 '<- for
        '    Close()                          '<- 2forms
        'End If                               '<- need

    End Sub

    Private Sub SetupParameters(ByVal x As Integer, ByVal ParameterName As String, _
    ByVal ParameterType As SqlDbType, ByVal ParameterLength As Integer, ByVal DataType As String, ByVal ParameterValue As String)

        DataMaintenance.myParamArray(x, 0) = ParameterName
        DataMaintenance.myParamArray(x, 1) = ParameterType
        DataMaintenance.myParamArray(x, 2) = ParameterLength
        DataMaintenance.myParamArray(x, 3) = ParameterDirection.Input
        DataMaintenance.myParamArray(x, 4) = DataType
        DataMaintenance.myParamArray(x, 5) = ParameterValue

    End Sub



    Private Sub LogError(ByVal ex As Exception)

        Dim sw As StreamWriter
        If File.Exists(Application.StartupPath & "\" & "ScoresDotNet_Log.txt") Then
            sw = File.AppendText(Application.StartupPath & "\" & "ScoresDotNet_Log.txt")
        Else
            sw = New StreamWriter(Application.StartupPath & "\" & "ScoresDotNet_Log.txt")
        End If

        With sw
            Dim myStringBuilder As New StringBuilder
            With myStringBuilder
                .Append(Now.ToString())
                .Append(ControlChars.NewLine & ex.Message)
            End With
            .WriteLine(myStringBuilder.ToString())
        End With
        sw.Close()

    End Sub

    Private Sub WriteEndTags()

        Dim sw As StreamWriter
        If File.Exists(Application.StartupPath & "\" & "ScoresDotNet_Log.txt") Then
            sw = File.AppendText(Application.StartupPath & "\" & "ScoresDotNet_Log.txt")
        Else
            sw = New StreamWriter(Application.StartupPath & "\" & "ScoresDotNet_Log.txt")
        End If
        sw.WriteLine("***********************************************************")
        sw.WriteLine("Text File processing completed at (" & Now.ToString() & ")")
        sw.WriteLine("***********************************************************")
        sw.Close()

    End Sub

    Private Sub frmProcessInHouseData_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SetCommissionDates()

    End Sub
End Class
