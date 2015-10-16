Imports Microsoft
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Configuration
Imports System.Threading
Imports System.Xml
Imports System.Globalization
Public Class frmProcessMdiData
    Inherits System.Windows.Forms.Form
    Private CommissionDate As String = CStr(DateTime.Today)
    Private parCommissionDate As String
    Private UpdateString As String
    Private strFromFile As String
    Private SalesClass As String
    Private oForm As NewCustomer
    Private iForm As NewItem
    Private StartTime As Date
    Private EndTime As Date
    Private newcustpath As String = ConfigurationSettings.AppSettings.Item("newcustpath").ToString()

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
    Friend WithEvents ProcessMdi_Progress As System.Windows.Forms.ProgressBar
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
        Me.ProcessMdi_Progress = New System.Windows.Forms.ProgressBar
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
        'ProcessMdi_Progress
        '
        Me.ProcessMdi_Progress.Location = New System.Drawing.Point(8, 208)
        Me.ProcessMdi_Progress.Name = "ProcessMdi_Progress"
        Me.ProcessMdi_Progress.Size = New System.Drawing.Size(176, 23)
        Me.ProcessMdi_Progress.TabIndex = 30
        '
        'frmProcessMdiData
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(456, 238)
        Me.Controls.Add(Me.ProcessMdi_Progress)
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

        UpdateProgressBar(0)

        If txtFileName.Text = "" Then '[>>rnj_popoy**added
            'TODO : Prompt user reminder to select valid file
            Return '06252012<<]
        Else
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            StartTime = Now()
            Get_TextFile()
            MonitorPerformance(StartTime, Now(), "Insert_TextFile_ForNewFieldLength")
            UpdateProgressBar(10)
            'Dim Tasks As New TasksClass
            'Dim thisThread As New System.Threading.Thread(AddressOf Tasks.UpdateProgressBar)
            'Tasks.intVal = 100
            'Tasks.thisControl = ProcessMdi_Progress
            'thisThread.Start()

            If UpdateFromFileField() = True Then
                MessageBox.Show("All transactions processed successfully.", "ScoresDotNet", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim salesdate As DateTime
                salesdate = MonthCalendar.SelectionRange.Start.Month.ToString.Trim & _
                      "/1/" & MonthCalendar.SelectionRange.Start.Year.ToString.Trim
                RecordSubDistSales(Convert.ToDateTime(salesdate))
            End If
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End If

    End Sub

    Private Function UpdateFromFileField() As Boolean

        Dim myParameter(,) As Object
        Dim BusinessLayer As New BusinessLayer.clsExtraction
        Dim Params(0) As SqlParameter

        If CommissionDate > "" Then
            strFromFile = CommissionDate & "-" & VisualBasic.Right(OpenFileDialog.FileName, _
            Len(OpenFileDialog.FileName) - (OpenFileDialog.FileName.LastIndexOf("\") + 1))

            'Save Last process filename to app.config
            Dim xmlDoc As XmlDocument = New XmlDocument
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile)
            For Each item As XmlElement In xmlDoc.DocumentElement
                For Each node As XmlNode In item.ChildNodes
                    If node.NodeType = XmlNodeType.Element Then
                        If node.Attributes.Count > 0 Then
                            If node.Attributes(0).Value = "LastFileProcessed" Then
                                node.Attributes(1).Value = strFromFile
                                Exit For
                            End If
                        End If
                    End If
                Next
            Next

            Dim thisStreamWriter As StreamWriter = New StreamWriter(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile)
            xmlDoc.Save(thisStreamWriter)
            thisStreamWriter.Close()

            Select Case Microsoft.VisualBasic.Mid(strFromFile, strFromFile.IndexOf("-") + 3, 3)
                Case "580"
                    SalesClass = "Mic"
                Case "582"
                    SalesClass = "Qpi"
                Case "584"
                    SalesClass = "Hii"
            End Select

            'Initialize the Data to avoid duplicates
            Dim FromFile As New SqlParameter("@FromFile", SqlDbType.VarChar, 150) : FromFile.Direction = ParameterDirection.Input : FromFile.Value = strFromFile : Params(0) = FromFile
            StartTime = Now()
            BusinessLayer.Process_MDIData(ServerPath2, "ProcessMdi_RemoveDuplicates", CommandType.StoredProcedure, Params)
            MonitorPerformance(StartTime, Now(), "ProcessMdi_RemoveDuplicates")

            'Step# 2
            'Fix the FromFile field
            StartTime = Now()
            ProcessDuplicates(strFromFile)
            MonitorPerformance(StartTime, Now(), "FixMdiRawData")
            UpdateProgressBar(20)
            Try
                StartTime = Now()
                DataMaintenance.ExecuteCommand(ServerPath2, "InsertLeftOvers", CommandType.StoredProcedure)
                MonitorPerformance(StartTime, Now(), "InsertLeftOvers")
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "UpdateFromFileField()", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            UpdateProgressBar(30)

        Else
            MessageBox.Show("Please select a date!")
            Exit Function
        End If

        StartTime = Now()
        GetNewCustomers("Count")
        'GetNewCustomers("Rows")
        GetNewItems("Count")
        'GetNewItems("Rows")
        MonitorPerformance(StartTime, Now(), "Customer/Item Count")
        UpdateProgressBar(40)
        Try
            If chkProcess.CheckState = CheckState.Checked Then
                'Insert the data into IntegratedSales from MetroDrugsale
                ReDim Params(1)
                Dim FileName As New SqlParameter("@FileName", SqlDbType.VarChar, 150)
                FileName.Direction = ParameterDirection.Input : FileName.Value = strFromFile : Params(0) = FileName
                Dim CommissionDate As New SqlParameter("@CommissionDate", SqlDbType.DateTime, 10)
                CommissionDate.Direction = ParameterDirection.Input : CommissionDate.Value = parCommissionDate
                Params(1) = CommissionDate
                StartTime = Now()
                'BusinessLayer.Process_MDIData(ServerPath2, "ProcessData_MetroDrugSale", CommandType.StoredProcedure, Params)

                DataMaintenance.myParamArray(0, 0) = "@FileName"
                DataMaintenance.myParamArray(0, 1) = SqlDbType.VarChar
                DataMaintenance.myParamArray(0, 2) = 150
                DataMaintenance.myParamArray(0, 3) = ParameterDirection.Input
                DataMaintenance.myParamArray(0, 4) = "String"
                DataMaintenance.myParamArray(0, 5) = strFromFile

                DataMaintenance.myParamArray(1, 0) = "@CommissionDate"
                DataMaintenance.myParamArray(1, 1) = SqlDbType.DateTime
                DataMaintenance.myParamArray(1, 2) = 10
                DataMaintenance.myParamArray(1, 3) = ParameterDirection.Input
                DataMaintenance.myParamArray(1, 4) = "Date"
                DataMaintenance.myParamArray(1, 5) = parCommissionDate
                'Check for Segment Rule here
                If ConfigurationSettings.AppSettings("UseSegmentRule") = "0" Then
                    DataMaintenance.ExecuteCommand(ServerPath2, "ProcessData_MetroDrugSale", CommandType.StoredProcedure, 2)
                Else
                    DataMaintenance.ExecuteCommand(ServerPath2, "SegmentRule_ProcessData_MetroDrugSale", _
                    CommandType.StoredProcedure, 2)
                End If

                EndTime = Now()
                MonitorPerformance(StartTime, EndTime, "ProcessDate_MetroDrugSale")

                UpdateProgressBar(80)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "UpdateFromFileField()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        StartTime = Now()
        GetRowCountPesoAmounts()
        MonitorPerformance(StartTime, Now(), "Row Count/Peso Amounts")
        UpdateProgressBar(100)

        Return True

    End Function

    Private Sub ProcessDuplicates(ByVal FromFile As String)

        DataMaintenance.myParamArray(0, 0) = "@FileName"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.VarChar
        DataMaintenance.myParamArray(0, 2) = 150
        DataMaintenance.myParamArray(0, 3) = ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "String"
        DataMaintenance.myParamArray(0, 5) = FromFile
        'BusinessLayer.Process_MDIData(ServerPath2, "FixMdiRawData", CommandType.StoredProcedure, Params)
        Try
            Dim DuplicateRows As SqlDataReader = DataMaintenance.GetResultSet(ServerPath2, "FixMdiRawData", _
            CommandType.StoredProcedure, 1)
            'Load the Duplicates Form
            Dim formDuplicates As New DuplicateTransactions
            formDuplicates.DataGridSource = DuplicateRows
            If DuplicateRows.HasRows Then formDuplicates.ShowDialog(Me)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ProcessDuplicates", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub MonthCalendar_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar.DateSelected

        CommissionDate = e.Start.Month.ToString & e.Start.Year.ToString
        'parCommissionDate = "'" & e.Start.Month.ToString & "/1/" & e.Start.Year.ToString & "'"
        parCommissionDate = e.Start.Month.ToString & "/1/" & e.Start.Year.ToString

    End Sub

    Private Sub GetNewCustomers(ByVal ResultType As String)

        Select Case ResultType
            Case "Count"
                '-- OLD CODE
                'UpdateString = "Select count(FromFile) from MetroDrugSale where " & _
                '"cus# not in (select metro_code from newscores..customer where metro_code>'') and " & _
                '"FromFile = " & " '" & strFromFile & "'"
                'NewCustomerCount.Text = CStr(CInt(DataMaintenance.GetSingleResult(ServerPath2, UpdateString, CommandType.Text)))

                'Commented code to give way to new business rule    JF-9/13/2012
                ''-- NEW CODE W/ WATSONS NEW BRANCH
                'UpdateString = "Select count(FromFile) from MetroDrugSale where " & _
                '"((cus# not in (select metro_code from newscores..customer where metro_code>'')) or " & _
                '"(cnam like '%WATSONS PERSONAL%' and left(shipto,4) not in (select left(custname,4) from newscores..customer where                   custname like '%WATSONS%')))  and " & _
                '"FromFile = " & " '" & strFromFile & "'"
                'NewCustomerCount.Text = CStr(CInt(DataMaintenance.GetSingleResult(ServerPath2, UpdateString, CommandType.Text)))

                DataMaintenance.myParamArray(0, 0) = "@FromFile"
                DataMaintenance.myParamArray(0, 1) = SqlDbType.VarChar
                DataMaintenance.myParamArray(0, 2) = 150
                DataMaintenance.myParamArray(0, 3) = ParameterDirection.Input
                DataMaintenance.myParamArray(0, 4) = "String"
                DataMaintenance.myParamArray(0, 5) = strFromFile

                Dim MyResultSet As SqlDataReader
                MyResultSet = DataMaintenance.GetResultSet(ServerPath2, "Display_NewCustomerCount", _
                CommandType.StoredProcedure, 1)

                If MyResultSet.HasRows = True Then
                    'Get the count here
                    While MyResultSet.Read()
                        NewCustomerCount.Text = CStr(MyResultSet("Count"))
                    End While
                    'Get data here for the grid
                    MyResultSet.NextResult()

                    oForm = New NewCustomer
                    oForm.DataGridSource = myResultSet
                End If
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
                    myWorkBook = xl.Workbooks.Add(newcustpath & "NewCustTemplate.xls")
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
                    myWorkBook.SaveAs(newcustpath & "New Customer - " & strFromFile & ".xlsx")
                    myWorkBook.Close()

                    MessageBox.Show("File Location : " & newcustpath & vbCrLf & _
                    "File Name : " & vbCrLf & "New Customer - " & strFromFile & ".xlsx", _
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
                    'myWorkBook2 = x2.Workbooks.Add("C:\NewWatsonsTemplate.xls")
                    myWorkBook2 = x2.Workbooks.Add(newcustpath & "NewWatsonsTemplate.xlsx")
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
                    myWorkBook2.SaveAs(newcustpath & "New Watsons Branch - " & strFromFile & ".xlsx")
                    myWorkBook2.Close()

                    MessageBox.Show("File Location : " & newcustpath & vbCrLf & _
                    "File Name : " & vbCrLf & "New Watsons Branch - " & strFromFile & ".xlsx", _
                    "New Watsons Branch File", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
        End Select

    End Sub

    Private Sub GetNewItems(ByVal ResultType As String)

        Select Case ResultType
            Case "Count"
                DataMaintenance.myParamArray(0, 0) = "@FromFile"
                DataMaintenance.myParamArray(0, 1) = SqlDbType.VarChar
                DataMaintenance.myParamArray(0, 2) = 150
                DataMaintenance.myParamArray(0, 3) = ParameterDirection.Input
                DataMaintenance.myParamArray(0, 4) = "String"
                DataMaintenance.myParamArray(0, 5) = strFromFile

                Dim MyResultSet As SqlDataReader
                MyResultSet = DataMaintenance.GetResultSet(ServerPath2, "Display_NewItemCount", _
                CommandType.StoredProcedure, 1)

                If MyResultSet.HasRows = True Then
                    'Get the count here
                    While MyResultSet.Read()
                        NewItemCount.Text = CStr(MyResultSet("Count"))
                    End While
                    'Get data here for the grid
                    MyResultSet.NextResult()

                    iForm = New NewItem
                    iForm.DataGridSource = myResultSet
                End If
            Case "Rows"
                Dim MyResultSet As SqlDataReader
                UpdateString = "select prod [MetroItemCode],pdes [ItemDesc]," & _
                "uprc [UnitPrice] from ScoresDotNet..metrodrugsale where prod not in" & _
                "(select metrodrugitemcode from ScoresDotNet..metrodrugitem where metrodrugitemcode>'') and " & _
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
                    myWorkBook = xl.Workbooks.Add(newcustpath & "NewItemTemplate.xlsx")
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
                    myWorkBook.SaveAs(newcustpath & "New Item - " & strFromFile & ".xlsx")
                    myWorkBook.Close()
                    MessageBox.Show("File Location : " & newcustpath & vbCrLf & _
                    "File Name : " & vbCrLf & "New Item - " & strFromFile & ".xlsx", _
                    "New Item File", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
        End Select

    End Sub

    Private Sub GetRowCount(ByVal CountType As String)

        Select Case CountType
            Case "Input"
                UpdateString = "Select count(FromFile) from ScoresDotNet_test..MetroDrugSale where " & _
                               "FromFile = " & " '" & strFromFile & "'"
                InputCount.Text = CStr(CInt(DataMaintenance.GetSingleResult(ServerPath2, UpdateString, CommandType.Text)))
            Case "Processed"
                UpdateString = "Select count(Rowid) from ScoresDotNet_test..IntegratedSales where " & _
                               "SalesCycleDate = '" & parCommissionDate & "'"
                '& _
                '" and SalesClass=" & "'" & SalesClass & "'" & _
                '" and left(itemcode,3)<>" & "'131'" & _
                '" and Saletype=" & "'" & SalesClass & "'"
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
                                               "SalesCycleDate = '" & parCommissionDate & "'"
                ' & _
                '" and SalesClass=" & "'" & SalesClass & "'" & _
                '" and left(itemcode,3)<>" & "'131'" & _
                '" and Saletype=" & "'" & SalesClass & "'"
                ProcessedAmount.Text = Format(CInt(DataMaintenance.GetSingleResult(ServerPath2, UpdateString, CommandType.Text)), "###,###,##0.00")
        End Select

    End Sub

    Private Sub GetRowCountPesoAmounts()

        Try
            DataMaintenance.myParamArray(0, 0) = "@FromFile"
            DataMaintenance.myParamArray(0, 1) = SqlDbType.VarChar
            DataMaintenance.myParamArray(0, 2) = 150
            DataMaintenance.myParamArray(0, 3) = ParameterDirection.Input
            DataMaintenance.myParamArray(0, 4) = "String"
            DataMaintenance.myParamArray(0, 5) = strFromFile

            Dim myReader As SqlDataReader = DataMaintenance.GetResultSet(ServerPath2, "RowCountPesoAmounts", CommandType.StoredProcedure, 1)
            While myReader.Read
                InputCount.Text = CStr(myReader("InputCount"))
            End While
            myReader.NextResult()
            While myReader.Read
                ProcessedCount.Text = CStr(myReader("ProcessedCount"))
            End While
            UpdateProgressBar(90)
            myReader.NextResult()
            Thread.CurrentThread.CurrentCulture = New CultureInfo("en-us")
            While myReader.Read
                InputAmount.Text = CDbl(myReader("InputTotal")).ToString("N")
            End While
            myReader.NextResult()
            While myReader.Read
                ProcessedAmount.Text = CDbl(CStr(myReader("ProcessedTotal"))).ToString("N")
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, "GetRowCountPesoAmounts()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Get_TextFile()

        Dim myStreamReader As New StreamReader(OpenFileDialog.FileName)
        Dim myString As String
        myString = myStreamReader.ReadToEnd

        'Start  JF 9/11/2013
        'To test field length adjustments
        'Receive_TextString(myString)
        Receive_TextString_ForNewFieldLength(myString)
        'End    JF 9/11/2013
        'TODO : Dispose StreamReader object

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

    Private Sub chkProcess_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkProcess.CheckedChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        strFromFile = GetLastFileProcessed()

        If strFromFile <> String.Empty Then
            If oForm Is Nothing Then
                GetNewCustomers("Count")
            End If
            If oForm.IsDisposed = True Then
                GetNewCustomers("Count")
            End If

            If CInt(NewCustomerCount.Text) = 0 Then
                MessageBox.Show("No new customer(s) found!", "Process MDI Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                oForm.Show()
            End If
        End If

    End Sub

    Private Function GetLastFileProcessed() As String

        Dim thisFile As String = String.Empty
        Dim xmlDoc As XmlDocument = New XmlDocument
        xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile)
        For Each item As XmlElement In xmlDoc.DocumentElement
            For Each node As XmlNode In item.ChildNodes
                If node.NodeType = XmlNodeType.Element Then
                    If node.Attributes(0).Value = "LastFileProcessed" Then
                        thisFile = node.Attributes(1).Value
                        Return thisFile
                    End If
                End If
            Next
        Next
        Return thisFile

    End Function

    Private Sub frmProcessMdiData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'parCommissionDate = "'" & e.Start.Month.ToString & "/1/" & e.Start.Year.ToString & "'"
        'modified by arv:1/21/2015,note:removed single quote parCommissionDate = "'" & System.DateTime.Now.Month.ToString() & "/1/" & System.DateTime.Now.Year.ToString() & "'"
        parCommissionDate = System.DateTime.Now.Month.ToString() & "/1/" & System.DateTime.Now.Year.ToString()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        strFromFile = GetLastFileProcessed()
        If strFromFile <> String.Empty Then
            If iForm Is Nothing Then
                GetNewItems("Count")
            End If
            If iForm.IsDisposed = True Then
                GetNewItems("Count")
            End If
            If CInt(NewItemCount.Text) = 0 Then
                MessageBox.Show("No new item(s) found!", "Process MDI Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                iForm.Show()
            End If

        End If

    End Sub

    Private Sub UpdateProgressBar(ByVal intValue As Integer)

        ProcessMdi_Progress.Value = intValue
        Me.Activate()
        'Application.DoEvents()

    End Sub

    Private Sub MonitorPerformance(ByVal StartTime As Date, ByVal EndTime As Date, ByVal Process As String)

        Dim monitorPerformance As Boolean = CType(ConfigurationSettings.AppSettings.Item("MonitorPerformance"), System.Boolean)

        If monitorPerformance = True Then
            MessageBox.Show("Time Elapsed : " & DateDiff(DateInterval.Second, StartTime, EndTime).ToString(), "Performance Monitor :" & Process, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub frmProcessMdiData_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.GotFocus

    End Sub

    Private Sub frmProcessMdiData_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint

        If Not oForm Is Nothing Then
            If oForm.Opened = True Then
                NewCustomerCount.Text = oForm.LastCount.ToString()
            End If
        End If

        If Not iForm Is Nothing Then
            If iForm.Opened = True Then
                NewItemCount.Text = iForm.LastCount.ToString()
            End If
        End If

    End Sub

    Private Sub MonthCalendar_DateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar.DateChanged

        'revised by arv:1/21/2015,note: removed single quote parCommissionDate = "'" & e.Start.Month.ToString & "/1/" & e.Start.Year.ToString & "'"
        parCommissionDate = e.Start.Month.ToString & "/1/" & e.Start.Year.ToString

    End Sub
End Class

