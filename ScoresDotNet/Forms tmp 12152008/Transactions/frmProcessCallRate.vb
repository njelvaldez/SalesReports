Imports Microsoft
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Public Class frmProcessCallRate
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MonthCalendar As System.Windows.Forms.MonthCalendar
    Friend WithEvents InputCount As System.Windows.Forms.Label
    Friend WithEvents ProcessedCount As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.btnFile = New System.Windows.Forms.Button
        Me.txtFileName = New System.Windows.Forms.TextBox
        Me.MonthCalendar = New System.Windows.Forms.MonthCalendar
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnProcess = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.InputCount = New System.Windows.Forms.Label
        Me.ProcessedCount = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
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
        Me.btnProcess.Location = New System.Drawing.Point(192, 56)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(256, 20)
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
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(192, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Input File Transactions"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(192, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Transactions Processed"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'InputCount
        '
        Me.InputCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.InputCount.Location = New System.Drawing.Point(328, 116)
        Me.InputCount.Name = "InputCount"
        Me.InputCount.Size = New System.Drawing.Size(88, 16)
        Me.InputCount.TabIndex = 17
        Me.InputCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ProcessedCount
        '
        Me.ProcessedCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ProcessedCount.Location = New System.Drawing.Point(328, 135)
        Me.ProcessedCount.Name = "ProcessedCount"
        Me.ProcessedCount.Size = New System.Drawing.Size(88, 16)
        Me.ProcessedCount.TabIndex = 18
        Me.ProcessedCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(424, 116)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(24, 16)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "..."
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(424, 135)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(24, 16)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "..."
        '
        'frmProcessCallRate
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(456, 178)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ProcessedCount)
        Me.Controls.Add(Me.InputCount)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MonthCalendar)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.btnFile)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProcessCallRate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Process Call Rate"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub btnFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFile.Click
        Dim File As String
        OpenFileDialog.Filter = "Excel files (*.xls)|*.xls"
        OpenFileDialog.ShowDialog(Me)
        txtFileName.Text = OpenFileDialog.FileName
        File = VisualBasic.Mid(OpenFileDialog.FileName, OpenFileDialog.FileName.LastIndexOf("\") + 2)
    End Sub
    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click
        Me.Cursor = Cursors.WaitCursor
        If parCommissionDate = "" Then
            MessageBox.Show("Please select a date!")
        Else
            Try
                Initialize_CallRateData()
                Extract_ExcelFileData(OpenFileDialog.FileName)
                ProcessedCount.Text = CStr(Processed_RowCount())
            Catch ex As Exception
                MessageBox.Show(ex.InnerException.Message)
                Me.Cursor = Cursors.Default
                Exit Sub
            End Try
            MessageBox.Show("Processing Complete")
        End If
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub MonthCalendar_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar.DateSelected
        CommissionDate = e.Start.Month.ToString & e.Start.Year.ToString
        parCommissionDate = "'" & e.Start.Month.ToString & "/1/" & e.Start.Year.ToString & "'"
    End Sub
    Private Sub Extract_ExcelFileData(ByVal strFileName As String)
        Dim xl As New Excel.Application
        Dim wb As Excel.Workbook
        Dim ws As Excel.Worksheet
        Dim range As Excel.Range
        Dim PMRCode, PMRName, DSMCode, DSMName, NSMCode, NSMName, DivCode, DivisionName As String
        Dim CallRate, Target As String
        Dim i As Integer = 2
        Try
            wb = xl.Workbooks.Open(strFileName)
            ws = CType(wb.Worksheets.Item("Sheet1"), Excel.Worksheet)
            With ws
                Do
                    PMRCode = CStr(.Range("B" & i).Text)
                    PMRName = CStr(.Range("C" & i).Text) : If PMRCode = "" And PMRName > "" Then Throw New System.Exception("PMR Code not Found at rownumber : " & i.ToString)
                    CallRate = CStr(.Range("D" & i).Text) : If CallRate = "" Then Throw New System.Exception("CallRate Amount not Found at rownumber : " & i.ToString)
                    Target = CStr(.Range("E" & i).Text) : If Target = "" Then Throw New System.Exception("Target Amount not Found at rownumber : " & i.ToString)
                    DSMCode = CStr(.Range("F" & i).Text) : If DSMCode = "" Then Throw New System.Exception("DSM Code not Found at rownumber : " & i.ToString)
                    DSMName = CStr(.Range("G" & i).Text)
                    NSMCode = CStr(.Range("H" & i).Text) : If NSMCode = "" Then Throw New System.Exception("NSM Code not Found at rownumber : " & i.ToString)
                    NSMName = CStr(.Range("I" & i).Text)
                    DivCode = CStr(.Range("J" & i).Text) : If DivCode = "" Then Throw New System.Exception("Div Code not Found at rownumber : " & i.ToString)
                    DivisionName = CStr(.Range("K" & i).Text)
                    CommissionDate = CStr(.Range("L" & i).Text) : If CommissionDate = "" Then Throw New System.Exception("CommissionDate not Found at rownumber : " & i.ToString)

                    Insert_ExcelFile(PMRCode, PMRName, CallRate, Target, DSMCode, DSMName, NSMCode, NSMName, DivCode, DivisionName, CommissionDate)
                    i = i + 1
                Loop Until PMRCode = "" And PMRName = "" And CallRate = "" And Target = "" And DSMCode = "" And DSMName = "" And NSMCode = "" And NSMName = ""
                InputCount.Text = CStr(i - 1)
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
        cm.CommandText = "Insert_CallRateData"
        cm.CommandType = CommandType.StoredProcedure
        Dim pmrcode As New SqlParameter("@pmrcode", SqlDbType.VarChar, 10) : pmrcode.Direction = ParameterDirection.Input : cm.Parameters.Add(pmrcode)
        Dim pmrname As New SqlParameter("@pmrname", SqlDbType.VarChar, 75) : pmrname.Direction = ParameterDirection.Input : cm.Parameters.Add(pmrname)
        Dim callrate As New SqlParameter("@callrate", SqlDbType.Int) : callrate.Direction = ParameterDirection.Input : cm.Parameters.Add(callrate)
        Dim target As New SqlParameter("@target", SqlDbType.Money) : target.Direction = ParameterDirection.Input : cm.Parameters.Add(target)
        Dim dsmcode As New SqlParameter("@dsmcode", SqlDbType.VarChar, 10) : dsmcode.Direction = ParameterDirection.Input : cm.Parameters.Add(dsmcode)
        Dim dsmname As New SqlParameter("@dsmname", SqlDbType.VarChar, 75) : dsmname.Direction = ParameterDirection.Input : cm.Parameters.Add(dsmname)
        Dim nsmcode As New SqlParameter("@nsmcode", SqlDbType.VarChar, 10) : nsmcode.Direction = ParameterDirection.Input : cm.Parameters.Add(nsmcode)
        Dim nsmname As New SqlParameter("@nsmname", SqlDbType.VarChar, 75) : nsmname.Direction = ParameterDirection.Input : cm.Parameters.Add(nsmname)
        Dim divcode As New SqlParameter("@divcode", SqlDbType.VarChar, 10) : divcode.Direction = ParameterDirection.Input : cm.Parameters.Add(divcode)
        Dim divisionname As New SqlParameter("@divisionname", SqlDbType.VarChar, 25) : divisionname.Direction = ParameterDirection.Input : cm.Parameters.Add(divisionname)
        Dim commissiondate As New SqlParameter("@commissiondate", SqlDbType.DateTime, 10) : commissiondate.Direction = ParameterDirection.Input : cm.Parameters.Add(commissiondate)

        pmrcode.Value = SubData(0).ToString
        pmrname.Value = SubData(1).ToString
        callrate.Value = CDbl(SubData(2))
        target.Value = CDbl(SubData(3))
        dsmcode.Value = SubData(4).ToString
        dsmname.Value = SubData(5).ToString
        nsmcode.Value = SubData(6).ToString
        nsmname.Value = SubData(7).ToString
        divcode.Value = SubData(8).ToString
        divisionname.Value = SubData(9).ToString
        commissiondate.Value = SubData(10).ToString

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
    Private Sub Initialize_CallRateData()
        Dim myConnection As New SqlConnection(ServerPath2)
        Dim myCommand As New SqlCommand
        Dim myParameter As New SqlParameter("@CommissionDate", SqlDbType.DateTime, 10)
        myParameter.Direction = ParameterDirection.Input : myParameter.Value = parCommissionDate
        myConnection.Open()
        With myCommand
            .Connection = myConnection
            .CommandText = "CallRate_Initialize"
            .CommandType = CommandType.StoredProcedure
            .Parameters.Add(myParameter)
            Try
                .ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Initilize CallRate Data")
            Finally
                myConnection.Close()
            End Try
        End With
    End Sub
    Public Function Processed_RowCount() As Integer
        Dim myConnection As New SqlConnection(ServerPath2)
        Dim myCommand As New SqlCommand
        Dim myCount As Integer
        myConnection.Open()
        With myCommand
            .Connection = myConnection
            .CommandText = "select count(rowid) from CallRate where commissiondate=" & parCommissionDate
            .CommandType = CommandType.Text
            Try
                myCount = CInt(.ExecuteScalar)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Initilize CallRate Data")
            Finally
                myConnection.Close()
            End Try
        End With
        Return myCount
    End Function
End Class
