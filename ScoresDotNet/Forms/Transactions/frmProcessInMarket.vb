Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports Microsoft.Office.Interop

Public Class frmProcessInMarketData
    Inherits System.Windows.Forms.Form
    Private CommissionDate As String
    Private parCommissionDate As String
    Private UpdateString As String
    Private strFromFile As String
    Private SalesClass, SubSaleType, SubSubSaleType As String

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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmProcessInMarketData))
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
        Me.NewCustomerCount.Text = "456"
        Me.NewCustomerCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NewItemCount
        '
        Me.NewItemCount.Location = New System.Drawing.Point(328, 134)
        Me.NewItemCount.Name = "NewItemCount"
        Me.NewItemCount.Size = New System.Drawing.Size(88, 16)
        Me.NewItemCount.TabIndex = 16
        Me.NewItemCount.Text = "456"
        Me.NewItemCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'InputCount
        '
        Me.InputCount.Location = New System.Drawing.Point(328, 153)
        Me.InputCount.Name = "InputCount"
        Me.InputCount.Size = New System.Drawing.Size(88, 16)
        Me.InputCount.TabIndex = 17
        Me.InputCount.Text = "456"
        Me.InputCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ProcessedCount
        '
        Me.ProcessedCount.Location = New System.Drawing.Point(328, 172)
        Me.ProcessedCount.Name = "ProcessedCount"
        Me.ProcessedCount.Size = New System.Drawing.Size(88, 16)
        Me.ProcessedCount.TabIndex = 18
        Me.ProcessedCount.Text = "456"
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
        Me.InputAmount.Text = "456"
        Me.InputAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ProcessedAmount
        '
        Me.ProcessedAmount.Location = New System.Drawing.Point(328, 210)
        Me.ProcessedAmount.Name = "ProcessedAmount"
        Me.ProcessedAmount.Size = New System.Drawing.Size(88, 16)
        Me.ProcessedAmount.TabIndex = 27
        Me.ProcessedAmount.Text = "456"
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
        'frmProcessInMarketData
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
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
        Me.Name = "frmProcessInMarketData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Process MSD InMarket Data"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub btnFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFile.Click
        Dim File As String
        OpenFileDialog.Filter = "Excel files (*.xls)|*.xls"
        OpenFileDialog.ShowDialog(Me)
        txtFileName.Text = OpenFileDialog.FileName
        File = Mid(OpenFileDialog.FileName, OpenFileDialog.FileName.LastIndexOf("\") + 2)
    End Sub
    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click
        Me.Cursor = Cursors.WaitCursor
        Extract_ExcelFileData(OpenFileDialog.FileName)
        If UpdateFromFileField() = True Then
            MessageBox.Show("Command Successfully Executed!")
        Else
            MessageBox.Show("Command Execution Disrupted!")
        End If
        Me.Cursor = Cursors.Default
    End Sub
    Private Function UpdateFromFileField() As Boolean
        Dim myParameter(,) As Object

        If CommissionDate > "" Then
            strFromFile = CommissionDate & "-" & Microsoft.VisualBasic.Right(OpenFileDialog.FileName, _
            Len(OpenFileDialog.FileName) - (OpenFileDialog.FileName.LastIndexOf("\") + 1))

            'Initialize the Data to avoid duplicates
            UpdateString = "Delete from InMarketData where FromFile=" & "'" & strFromFile & "'"
            DataMaintenance.ExecuteCommand(ServerPath2, UpdateString, CommandType.Text)

            'Upload Parameters
            UpdateString = "FixInMarketRawData"
            DataMaintenance.myParamArray(0, 0) = "@FileName"
            DataMaintenance.myParamArray(0, 1) = SqlDbType.VarChar
            DataMaintenance.myParamArray(0, 2) = 50
            DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
            DataMaintenance.myParamArray(0, 4) = "String"
            DataMaintenance.myParamArray(0, 5) = strFromFile

            If DataMaintenance.ExecuteCommand(ServerPath2, UpdateString, CommandType.StoredProcedure, 1) = False Then
                Return False
                Exit Function
            End If
        Else
            MessageBox.Show("Please select a date!")
            Exit Function
        End If
        GetNewCustomers("Count")
        GetNewCustomers("Rows")
        GetNewItems("Count")
        GetNewItems("Rows")
        If chkProcess.CheckState = CheckState.Checked Then
            'Upload Parameters
            UpdateString = "ProcessData_MSD_Inmarket"      '"ProcessData_ProscarData"
            DataMaintenance.myParamArray(0, 0) = "@FileName"
            DataMaintenance.myParamArray(0, 1) = SqlDbType.VarChar
            DataMaintenance.myParamArray(0, 2) = 100
            DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
            DataMaintenance.myParamArray(0, 4) = "String"
            DataMaintenance.myParamArray(0, 5) = strFromFile

            DataMaintenance.myParamArray(1, 0) = "@CommissionDate"
            DataMaintenance.myParamArray(1, 1) = SqlDbType.DateTime
            DataMaintenance.myParamArray(1, 2) = 10
            DataMaintenance.myParamArray(1, 3) = System.Data.ParameterDirection.Input
            DataMaintenance.myParamArray(1, 4) = "String"
            DataMaintenance.myParamArray(1, 5) = parCommissionDate

            DataMaintenance.ExecuteCommand(ServerPath2, _
            UpdateString, CommandType.StoredProcedure, 2)
        End If
        GetRowCount("Input")
        GetPesoAmounts("Input")
        GetRowCount("Processed")
        GetPesoAmounts("Processed")
        Return True
    End Function
    Private Sub MonthCalendar_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar.DateSelected
        CommissionDate = e.Start.Month.ToString & e.Start.Year.ToString
        parCommissionDate = "'" & e.Start.Month.ToString & "/1/" & e.Start.Year.ToString & "'"
    End Sub
    Private Sub GetNewCustomers(ByVal ResultType As String)
        Select Case ResultType
            Case "Count"
                UpdateString = "Select count(FromFile) from InMarketData where " & _
                "CustCode not in (select custcode from newscores..customer) and " & _
                "FromFile = " & " '" & strFromFile & "'"
                Try
                    NewCustomerCount.Text = CStr(CInt(DataMaintenance.GetSingleResult(ServerPath2, UpdateString, CommandType.Text)))
                Catch
                    NewCustomerCount.Text = "0"
                End Try
            Case "Rows"
                Dim MyResultSet As SqlDataReader
                UpdateString = "select CustCode ,CustName ," & _
                "Address1,Address2 from InMarketData where CustCode not in" & _
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
                UpdateString = "Select count(FromFile) from InMarketData where " & _
                "ItemNo not in (select itemcode from newscores..item where itemcode>'') and " & _
                "FromFile = " & " '" & strFromFile & "'"
                NewItemCount.Text = CStr(CInt(DataMaintenance.GetSingleResult(ServerPath2, UpdateString, CommandType.Text)))
            Case "Rows"
                Dim MyResultSet As SqlDataReader
                UpdateString = "select itemno [ItemCode],itemdesc ," & _
                "listprice [UnitPrice] from InMarketData where itemno not in" & _
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
                       "from InMarketData " & _
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
                UpdateString = "Select count(FromFile) from InMarketData where " & _
                               "FromFile = " & " '" & strFromFile & "'"
                InputCount.Text = CStr(CInt(DataMaintenance.GetSingleResult(ServerPath2, UpdateString, CommandType.Text)))
            Case "Processed"
                UpdateString = "Select count(Rowid) from IntegratedSales where " & _
                               "CommissionDate = " & parCommissionDate & _
                               " and SalesClass=" & "'" & SalesClass & "'" & _
                               " and SaleType='MIC' and left(itemcode, 3) = '131' "
                Try
                    ProcessedCount.Text = CStr(CInt(DataMaintenance.GetSingleResult(ServerPath2, UpdateString, CommandType.Text)))
                Catch
                    ProcessedCount.Text = "0"
                End Try
        End Select
    End Sub
    Private Sub GetPesoAmounts(ByVal AmountType As String)
        Select Case AmountType
            Case "Input"
                UpdateString = "Select sum(ValAmt) from InMarketData where " & _
                               "FromFile = " & " '" & strFromFile & "'"
                InputAmount.Text = Format(CInt(DataMaintenance.GetSingleResult(ServerPath2, UpdateString, CommandType.Text)), "###,###,##0.00")
            Case "Processed"
                UpdateString = "Select sum(creditedamount) from IntegratedSales where " & _
                                               "CommissionDate = " & parCommissionDate & _
                                               " and SalesClass=" & "'" & SalesClass & "'" & _
                                               " and SaleType='MIC' and left(itemcode, 3) ='131' "
                Try
                    ProcessedAmount.Text = Format(CInt(DataMaintenance.GetSingleResult(ServerPath2, UpdateString, CommandType.Text)), "###,###,##0.00")
                Catch
                    ProcessedAmount.Text = "0"
                End Try
        End Select
    End Sub
    Private Sub Extract_ExcelFileData(ByVal strFileName As String)
        Dim xl As New Excel.Application
        Dim wb As Excel.Workbook
        Dim ws As Excel.Worksheet
        Dim range As Excel.Range
        Dim custcode, custname, address1, address2, shiptoname, shipaddress1, shipaddress2 As String
        Dim refcode, refdate, socode, xrefcode, remarks, princode, itemno, itemdesc, um, lotno, expdate, qtyorder, qtyfree As String
        Dim listprice, valamt As String
        Dim i As Integer = 2
        Try
            wb = xl.Workbooks.Open(strFileName)
            ws = CType(wb.Worksheets.Item("SalesQuery"), Excel.Worksheet)
            With ws
                Do
                    custcode = CStr(.Range("A" & i).Text)
                    If custcode = "" Then Exit Do
                    custname = CStr(.Range("B" & i).Text)
                    address1 = CStr(.Range("C" & i).Text)
                    address2 = CStr(.Range("D" & i).Text) : If custcode = "" And custname > "" Then Throw New System.Exception("Customer Code not Found at rownumber : " & i.ToString)
                    shiptoname = CStr(.Range("E" & i).Text)
                    shipaddress1 = CStr(.Range("F" & i).Text)
                    shipaddress2 = CStr(.Range("G" & i).Text)
                    refcode = CStr(.Range("H" & i).Text)
                    refdate = CStr(.Range("I" & i).Text) : If refdate = "" Then Throw New System.Exception("RefDate not Found at rownumber : " & i.ToString)
                    socode = CStr(.Range("J" & i).Text)
                    xrefcode = CStr(.Range("K" & i).Text)
                    remarks = CStr(.Range("L" & i).Text)
                    princode = CStr(.Range("M" & i).Text)
                    itemno = CStr(.Range("N" & i).Text)
                    itemdesc = CStr(.Range("O" & i).Text)
                    um = CStr(.Range("P" & i).Text)
                    lotno = CStr(.Range("Q" & i).Text)
                    expdate = CStr(.Range("R" & i).Text) : If expdate = "" Then Throw New System.Exception("ExpDate not Found at rownumber : " & i.ToString)
                    qtyorder = CStr(.Range("S" & i).Text) : If qtyorder = "" Then Throw New System.Exception("QtyOrder not Found at rownumber : " & i.ToString)
                    qtyfree = CStr(.Range("T" & i).Text) : If qtyfree = "" Then Throw New System.Exception("QtyFree not Found at rownumber : " & i.ToString)
                    listprice = CStr(.Range("U" & i).Text) : If listprice = "" Then Throw New System.Exception("ListPrice not Found at rownumber : " & i.ToString)
                    valamt = CStr(.Range("V" & i).Text) : If valamt = "" Then Throw New System.Exception("ValAmt not Found at rownumber : " & i.ToString)
                    Insert_ExcelFile(custcode, custname, address1, address2, shiptoname, shipaddress1, _
                          shipaddress2, refcode, refdate, socode, xrefcode, remarks, princode, itemno, _
                          itemdesc, um, lotno, expdate, qtyorder, qtyfree, listprice, valamt)
                    i = i + 1
                Loop Until custcode = ""
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Extract_ExcelFileData module")
        Finally
            wb.Close()
            xl = Nothing
        End Try
    End Sub
    Private Sub Insert_ExcelFile(ByVal ParamArray SubData() As String)
        Dim cn As New SqlConnection(ServerPath2)
        Dim cm As New SqlCommand
        cm.CommandText = "Insert_InMarketData"
        cm.CommandType = CommandType.StoredProcedure
        Dim custcode As New SqlParameter("@CustCode", SqlDbType.VarChar, 25)
        custcode.Direction = ParameterDirection.Input
        cm.Parameters.Add(custcode)

        Dim custname As New SqlParameter("@CustName", SqlDbType.VarChar, 150)
        custname.Direction = ParameterDirection.Input
        cm.Parameters.Add(custname)

        Dim address1 As New SqlParameter("@Address1", SqlDbType.VarChar, 100)
        address1.Direction = ParameterDirection.Input
        cm.Parameters.Add(address1)

        Dim address2 As New SqlParameter("@Address2", SqlDbType.VarChar, 100)
        address2.Direction = ParameterDirection.Input
        cm.Parameters.Add(address2)

        Dim shiptoname As New SqlParameter("@ShipToName", SqlDbType.VarChar, 150)
        shiptoname.Direction = ParameterDirection.Input
        cm.Parameters.Add(shiptoname)

        Dim shipaddress1 As New SqlParameter("@ShipAddress1", SqlDbType.VarChar, 100)
        shipaddress1.Direction = ParameterDirection.Input
        cm.Parameters.Add(shipaddress1)

        Dim shipaddress2 As New SqlParameter("@ShipAddress2", SqlDbType.VarChar, 100)
        shipaddress2.Direction = ParameterDirection.Input
        cm.Parameters.Add(shipaddress2)

        Dim refcode As New SqlParameter("@RefCode", SqlDbType.VarChar, 25)
        refcode.Direction = ParameterDirection.Input
        cm.Parameters.Add(refcode)

        Dim refdate As New SqlParameter("@RefDate", SqlDbType.VarChar, 25)
        refdate.Direction = ParameterDirection.Input
        cm.Parameters.Add(refdate)

        Dim socode As New SqlParameter("@SoCode", SqlDbType.VarChar, 25)
        socode.Direction = ParameterDirection.Input
        cm.Parameters.Add(socode)

        Dim xrefcode As New SqlParameter("@XrefCode", SqlDbType.VarChar, 25)
        xrefcode.Direction = ParameterDirection.Input
        cm.Parameters.Add(xrefcode)

        Dim remarks As New SqlParameter("@Remarks", SqlDbType.VarChar, 150)
        remarks.Direction = ParameterDirection.Input
        cm.Parameters.Add(remarks)

        Dim princode As New SqlParameter("@PrinCode", SqlDbType.VarChar, 25)
        princode.Direction = ParameterDirection.Input
        cm.Parameters.Add(princode)

        Dim itemno As New SqlParameter("@ItemNo", SqlDbType.VarChar, 25)
        itemno.Direction = ParameterDirection.Input
        cm.Parameters.Add(itemno)

        Dim itemdesc As New SqlParameter("@ItemDesc", SqlDbType.VarChar, 100)
        itemdesc.Direction = ParameterDirection.Input
        cm.Parameters.Add(itemdesc)

        Dim um As New SqlParameter("@Um", SqlDbType.VarChar, 25)
        um.Direction = ParameterDirection.Input
        cm.Parameters.Add(um)

        Dim lotno As New SqlParameter("@LotNo", SqlDbType.VarChar, 25)
        lotno.Direction = ParameterDirection.Input
        cm.Parameters.Add(lotno)

        Dim expdate As New SqlParameter("@ExpDate", SqlDbType.DateTime, 10)
        expdate.Direction = ParameterDirection.Input
        cm.Parameters.Add(expdate)

        Dim qtyorder As New SqlParameter("@QtyOrder", SqlDbType.Money)
        qtyorder.Direction = ParameterDirection.Input
        cm.Parameters.Add(qtyorder)

        Dim qtyfree As New SqlParameter("@QtyFree", SqlDbType.Money)
        qtyfree.Direction = ParameterDirection.Input
        cm.Parameters.Add(qtyfree)

        Dim listprice As New SqlParameter("@ListPrice", SqlDbType.Money)
        listprice.Direction = ParameterDirection.Input
        cm.Parameters.Add(listprice)

        Dim valamt As New SqlParameter("@ValAmt", SqlDbType.Money)
        valamt.Direction = ParameterDirection.Input
        cm.Parameters.Add(valamt)

        custcode.Value = SubData(0).ToString
        custname.Value = SubData(1).ToString
        address1.Value = SubData(2).ToString
        address2.Value = SubData(3).ToString
        shiptoname.Value = SubData(4).ToString
        shipaddress1.Value = SubData(5).ToString
        shipaddress2.Value = SubData(6).ToString
        refcode.Value = SubData(7).ToString
        refdate.Value = CDate(SubData(8))
        socode.Value = SubData(9).ToString
        xrefcode.Value = SubData(10).ToString
        remarks.Value = SubData(11).ToString
        princode.Value = SubData(12).ToString
        itemno.Value = SubData(13).ToString
        itemdesc.Value = SubData(14).ToString
        um.Value = SubData(15).ToString
        lotno.Value = SubData(16).ToString
        expdate.Value = CDate(SubData(17))
        qtyorder.Value = CDbl(SubData(18))
        qtyfree.Value = CDbl(SubData(19))
        listprice.Value = CDbl(SubData(20))
        valamt.Value = CDbl(SubData(21).ToString)
        Try
            cn.Open()
            cm.Connection = cn
            cm.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Insert_ExcelFile module")
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub Frm_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        EnDisMainMenu(Me, True)
        'ChildCtr = ChildCtr - 1              '<--ready for 2forms need
    End Sub

    Private Sub Frm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        EnDisMainMenu(Me, False)
    End Sub

    Private Sub frmProcessInMarketData_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        'If CloseFrm = True Then              '<- ready
        '    CloseFrm = False                 '<- for
        '    Close()                          '<- 2forms
        'End If                               '<- need
    End Sub
End Class
