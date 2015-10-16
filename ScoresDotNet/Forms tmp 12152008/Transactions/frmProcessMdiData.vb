Imports Microsoft
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports System.IO
Public Class frmProcessMdiData
    Inherits System.Windows.Forms.Form
    Private CommissionDate As String
    Private parCommissionDate As String
    Private UpdateString As String
    Private strFromFile As String
    Private SalesClass As String

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
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents InputAmount As System.Windows.Forms.Label
    Friend WithEvents ProcessedAmount As System.Windows.Forms.Label
    Friend WithEvents chkProcess As System.Windows.Forms.CheckBox
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
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.InputAmount = New System.Windows.Forms.Label
        Me.ProcessedAmount = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.chkProcess = New System.Windows.Forms.CheckBox
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
        Me.MonthCalendar.Name = "MonthCalendar"
        Me.MonthCalendar.SelectionRange = New System.Windows.Forms.SelectionRange(New Date(2005, 6, 5, 0, 0, 0, 0), New Date(2005, 6, 11, 0, 0, 0, 0))
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
        Me.NewCustomerCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.NewCustomerCount.Location = New System.Drawing.Point(328, 115)
        Me.NewCustomerCount.Name = "NewCustomerCount"
        Me.NewCustomerCount.Size = New System.Drawing.Size(88, 16)
        Me.NewCustomerCount.TabIndex = 15
        Me.NewCustomerCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NewItemCount
        '
        Me.NewItemCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.NewItemCount.Location = New System.Drawing.Point(328, 134)
        Me.NewItemCount.Name = "NewItemCount"
        Me.NewItemCount.Size = New System.Drawing.Size(88, 16)
        Me.NewItemCount.TabIndex = 16
        Me.NewItemCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'InputCount
        '
        Me.InputCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.InputCount.Location = New System.Drawing.Point(328, 153)
        Me.InputCount.Name = "InputCount"
        Me.InputCount.Size = New System.Drawing.Size(88, 16)
        Me.InputCount.TabIndex = 17
        Me.InputCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ProcessedCount
        '
        Me.ProcessedCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
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
        Me.InputAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.InputAmount.Location = New System.Drawing.Point(328, 191)
        Me.InputAmount.Name = "InputAmount"
        Me.InputAmount.Size = New System.Drawing.Size(88, 16)
        Me.InputAmount.TabIndex = 26
        Me.InputAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ProcessedAmount
        '
        Me.ProcessedAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
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
        'chkProcess
        '
        Me.chkProcess.Location = New System.Drawing.Point(192, 56)
        Me.chkProcess.Name = "chkProcess"
        Me.chkProcess.Size = New System.Drawing.Size(104, 16)
        Me.chkProcess.TabIndex = 21
        Me.chkProcess.Text = "Full Processing"
        '
        'frmProcessMdiData
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
        Me.Name = "frmProcessMdiData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Process MDI Data"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub btnFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFile.Click
        Dim File As String
        OpenFileDialog.Filter = "Text files (*.txt)|*.txt"
        OpenFileDialog.ShowDialog(Me)
        txtFileName.Text = OpenFileDialog.FileName
        File = VisualBasic.Mid(OpenFileDialog.FileName, OpenFileDialog.FileName.LastIndexOf("\") + 2)
    End Sub
    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Get_TextFile()
        If UpdateFromFileField() = True Then
            MessageBox.Show("Processing Complete", "Process MDI DATA")
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
    Private Function UpdateFromFileField() As Boolean
        Dim myParameter(,) As Object
        Dim BusinessLayer As New BusinessLayer.clsExtraction
        Dim Params(0) As SqlParameter

        If CommissionDate > "" Then
            strFromFile = CommissionDate & "-" & VisualBasic.Right(OpenFileDialog.FileName, _
            Len(OpenFileDialog.FileName) - (OpenFileDialog.FileName.LastIndexOf("\") + 1))

            Select Case Microsoft.VisualBasic.Mid(strFromFile, strFromFile.IndexOf("-") + 3, 3)
                Case "580"
                    SalesClass = "Mic"
                Case "582"
                    SalesClass = "Qpi"
                Case "584"
                    SalesClass = "Hii"
            End Select

            'Initialize the Data to avoid duplicates
            Dim FromFile As New SqlParameter("@FromFile", SqlDbType.VarChar, 50) : FromFile.Direction = ParameterDirection.Input : FromFile.Value = strFromFile : Params(0) = FromFile
            BusinessLayer.Process_MDIData(ServerPath2, "ProcessMdi_RemoveDuplicates", CommandType.StoredProcedure, Params)

            'Fix the FromFile field
            Dim FileName As New SqlParameter("@FileName", SqlDbType.VarChar, 50) : FileName.Direction = ParameterDirection.Input : FileName.Value = strFromFile : Params(0) = FileName
            BusinessLayer.Process_MDIData(ServerPath2, "FixMdiRawData", CommandType.StoredProcedure, Params)
        Else
            MessageBox.Show("Please select a date!")
            Exit Function
        End If
        GetNewCustomers("Count")
        GetNewCustomers("Rows")
        GetNewItems("Count")
        GetNewItems("Rows")

        Try
            If chkProcess.CheckState = CheckState.Checked Then
                'Insert the data into IntegratedSales from MetroDrugsale
                ReDim Params(1)
                Dim FileName As New SqlParameter("@FileName", SqlDbType.VarChar, 50) : FileName.Direction = ParameterDirection.Input : FileName.Value = strFromFile : Params(0) = FileName
                Dim CommissionDate As New SqlParameter("@CommissionDate", SqlDbType.DateTime, 10) : CommissionDate.Direction = ParameterDirection.Input : CommissionDate.Value = parCommissionDate : Params(1) = CommissionDate
                BusinessLayer.Process_MDIData(ServerPath2, "ProcessData_MetroDrugSale", CommandType.StoredProcedure, Params)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
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
                '-- OLD CODE
                'UpdateString = "Select count(FromFile) from MetroDrugSale where " & _
                '"cus# not in (select metro_code from newscores..customer where metro_code>'') and " & _
                '"FromFile = " & " '" & strFromFile & "'"
                'NewCustomerCount.Text = CStr(CInt(DataMaintenance.GetSingleResult(ServerPath2, UpdateString, CommandType.Text)))

                '-- NEW CODE W/ WATSONS NEW BRANCH
                UpdateString = "Select count(FromFile) from MetroDrugSale where " & _
                "((cus# not in (select metro_code from newscores..customer where metro_code>'')) or " & _
                "(cnam like '%WATSONS PERSONAL%' and left(shipto,4) not in (select left(custname,4) from newscores..customer where custname like '%WATSONS%')))  and " & _
                "FromFile = " & " '" & strFromFile & "'"
                NewCustomerCount.Text = CStr(CInt(DataMaintenance.GetSingleResult(ServerPath2, UpdateString, CommandType.Text)))

            Case "Rows"
                '-- NEW CUSTOMERS ROUTINE
                Dim MyResultSet As SqlDataReader
                UpdateString = "select cus# [MetroCode],Cnam [CustName]," & _
                "Cad1 [Address1],Cad2 [Address2] from metrodrugsale where cus# not in" & _
                "(select metro_code from newscores..customer where metro_code>'') and " & _
                "FromFile = " & " '" & strFromFile & "'" & _
                "group by cus#, Cnam, Cad1, Cad2"
                MyResultSet = DataMaintenance.GetResultSet(ServerPath2, UpdateString, CommandType.Text)

                Dim myLine As String
                Dim xl As New Excel.Application
                Dim myWorkBook As Excel.Workbook
                Dim mySheets As Excel.Sheets
                Dim myWorkSheet As Excel.Worksheet
                Dim intLine As Integer = 2

                If MyResultSet.HasRows = True Then
                    'Open a New Workbook
                    myWorkBook = xl.Workbooks.Add("C:\NewCustTemplate.xls")
                    mySheets = myWorkBook.Sheets
                    myWorkSheet = CType(mySheets.Item("Sheet1"), Excel.Worksheet)
                    With myWorkSheet
                        While MyResultSet.Read()
                            .Range("A" & intLine).NumberFormat = "@"
                            .Cells(intLine, 1) = CStr(MyResultSet("MetroCode"))
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

                '-- NEW WATSONS BRANCH ROUTINE
                Dim MyResultSet2 As SqlDataReader
                UpdateString = "select ShipTo [CustName]," & _
                "Sad1 [Address1],Sad2 [Address2] from metrodrugsale where cnam like '%WATSONS PERSONAL%' " & _
                "and left(ShipTo,4) not in (select left(custname,4) from newscores..customer where custname like '%WATSONS%') and " & _
                "FromFile = " & " '" & strFromFile & "'" & _
                "group by ShipTo, Sad1, Sad2"
                MyResultSet2 = DataMaintenance.GetResultSet(ServerPath2, UpdateString, CommandType.Text)

                Dim myLine2 As String
                Dim x2 As New Excel.Application
                Dim myWorkBook2 As Excel.Workbook
                Dim mySheets2 As Excel.Sheets
                Dim myWorkSheet2 As Excel.Worksheet
                Dim intLine2 As Integer = 2
                If MyResultSet2.HasRows = True Then

                    'Open a New Workbook
                    myWorkBook2 = x2.Workbooks.Add("C:\NewWatsonsTemplate.xls")
                    mySheets2 = myWorkBook2.Sheets
                    myWorkSheet2 = CType(mySheets2.Item("Sheet1"), Excel.Worksheet)
                    With myWorkSheet2
                        While MyResultSet2.Read()
                            .Range("A" & intLine2).NumberFormat = "@"
                            .Cells(intLine2, 1) = CStr(MyResultSet2("CustName"))
                            .Cells(intLine2, 2) = CStr(MyResultSet2("Address1"))
                            .Cells(intLine2, 3) = CStr(MyResultSet2("Address2"))
                            intLine2 = intLine2 + 1
                        End While
                    End With
                    myWorkBook2.SaveAs("C:\" & "New Watsons Branch - " & strFromFile & ".xls")
                    myWorkBook2.Close()

                    MessageBox.Show("File Location : " & "C:\" & vbCrLf & _
                    "File Name : " & vbCrLf & "New Watsons Branch - " & strFromFile & ".xls", _
                    "New Watsons Branch File", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
        End Select
    End Sub
    Private Sub GetNewItems(ByVal ResultType As String)
        Select Case ResultType
            Case "Count"
                UpdateString = "Select count(FromFile) from MetroDrugSale where " & _
                "Prod not in (select metrodrugcode from item where metrodrugcode>'') and " & _
                "FromFile = " & " '" & strFromFile & "'"
                'UpdateString = "Select count(FromFile) from MetroDrugSale where " & _
                '"Prod not in (select metrodrugitemcode from metrodrugitem where metrodrugitemcode>'') and " & _
                '"FromFile = " & " '" & strFromFile & "'"     'revised 10232008
                NewItemCount.Text = CStr(CInt(DataMaintenance.GetSingleResult(ServerPath2, UpdateString, CommandType.Text)))
            Case "Rows"
                Dim MyResultSet As SqlDataReader
                UpdateString = "select prod [MetroItemCode],pdes [ItemDesc]," & _
                "uprc [UnitPrice] from metrodrugsale where prod not in" & _
                "(select metrodrugitemcode from metrodrugitem where metrodrugitemcode>'') and " & _
                "FromFile = " & " '" & strFromFile & "'" & _
                "group by prod,pdes,uprc"
                MyResultSet = DataMaintenance.GetResultSet(ServerPath2, UpdateString, CommandType.Text)

                Dim myLine As String
                Dim xl As New Excel.Application
                Dim myWorkBook As Excel.Workbook
                Dim mySheets As Excel.Sheets
                Dim myWorkSheet As Excel.Worksheet
                Dim intLine As Integer = 2
                If MyResultSet.HasRows = True Then
                    'Open a New Workbook
                    myWorkBook = xl.Workbooks.Add("C:\NewItemTemplate.xls")
                    mySheets = myWorkBook.Sheets
                    myWorkSheet = CType(mySheets.Item("Sheet1"), Excel.Worksheet)
                    With myWorkSheet
                        While MyResultSet.Read()
                            .Cells(intLine, 1) = CStr(MyResultSet("MetroItemCode"))
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
        Select Case CountType
            Case "Input"
                UpdateString = "Select count(FromFile) from MetroDrugSale where " & _
                               "FromFile = " & " '" & strFromFile & "'"
                InputCount.Text = CStr(CInt(DataMaintenance.GetSingleResult(ServerPath2, UpdateString, CommandType.Text)))
            Case "Processed"
                UpdateString = "Select count(Rowid) from IntegratedSales where " & _
                               "CommissionDate = " & parCommissionDate & _
                               " and SalesClass=" & "'" & SalesClass & "'" & _
                               " and Saletype=" & "'" & SalesClass & "'"
                ProcessedCount.Text = CStr(CInt(DataMaintenance.GetSingleResult(ServerPath2, UpdateString, CommandType.Text)))
        End Select
    End Sub
    Private Sub GetPesoAmounts(ByVal AmountType As String)
        Select Case AmountType
            Case "Input"
                UpdateString = "Select sum(pnet) from MetroDrugSale where " & _
                               "FromFile = " & " '" & strFromFile & "'"
                InputAmount.Text = Format(CInt(DataMaintenance.GetSingleResult(ServerPath2, UpdateString, CommandType.Text)), "###,###,##0.00")
            Case "Processed"
                UpdateString = "Select sum(creditedamount) from IntegratedSales where " & _
                                               "CommissionDate = " & parCommissionDate & _
                                               " and SalesClass=" & "'" & SalesClass & "'" & _
                                               " and Saletype=" & "'" & SalesClass & "'"
                ProcessedAmount.Text = Format(CInt(DataMaintenance.GetSingleResult(ServerPath2, UpdateString, CommandType.Text)), "###,###,##0.00")
        End Select
    End Sub
    Private Sub Get_TextFile()
        Dim myStreamReader As New StreamReader(OpenFileDialog.FileName)
        Dim myString As String
        myString = myStreamReader.ReadToEnd
        Receive_TextString(myString)
    End Sub
End Class
