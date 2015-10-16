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
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.MonthCalendar)
        Me.Controls.Add(Me.btnFile)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProcessCallRate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Process Call Rate Summary"
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

    Private Sub MonthCalendar_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) _
        Handles MonthCalendar.DateSelected
        CommissionDate = e.Start.Month.ToString & e.Start.Year.ToString
        parCommissionDate = "'" & e.Start.Month.ToString & "/1/" & e.Start.Year.ToString & "'"
    End Sub

    Private Sub Extract_ExcelFileData(ByVal strFileName As String)
        '[>>rnj_popoy**remodified
        Dim xl As New Excel.Application
        Dim wb As Excel.Workbook
        Dim ws As Excel.Worksheet
        Dim range As Excel.Range
        Dim PMRCode, PMRName, DSMCode, DSMName, NSMCode, NSMName, DivCode, DivisionName As String
        Dim CallRate4x, Target4x, Rate4x, CallRate2x, Target2x, Rate2x, CallRate, Target, Rate, LateTag, DSMnotIncluded, DSMlateTag As String
        Dim CallReach, TargetReach, RateReach As String
        Dim CallReach4x, TargetReach4x, RateReach4x, CallReach2x, TargetReach2x, RateReach2x As String
        Dim i As Integer = 2
        Try
            wb = xl.Workbooks.Open(strFileName)
            ws = CType(wb.Worksheets.Item("Sheet1"), Excel.Worksheet)
            With ws
                Do
                    PMRCode = CStr(.Range("B" & i).Text)
                    PMRName = CStr(.Range("C" & i).Text) : If PMRCode = "" And PMRName > "" Then Throw New System.Exception("PMR Code not Found at rownumber : " & i.ToString)
                    CallRate4x = CStr(.Range("D" & i).Text) : If CallRate4x = "" Then Throw New System.Exception("CallRate4x Amount not Found at rownumber : " & i.ToString)
                    Target4x = CStr(.Range("E" & i).Text) : If Target4x = "" Then Throw New System.Exception("Target4x Amount not Found at rownumber : " & i.ToString)
                    Rate4x = CStr(.Range("F" & i).Text) : If Rate4x = "" Then Throw New System.Exception("Rate4x Amount not Found at rownumber : " & i.ToString)
                    CallRate2x = CStr(.Range("G" & i).Text) : If CallRate2x = "" Then Throw New System.Exception("CallRate2x Amount not Found at rownumber : " & i.ToString)
                    Target2x = CStr(.Range("H" & i).Text) : If Target2x = "" Then Throw New System.Exception("Target2x Amount not Found at rownumber : " & i.ToString)
                    Rate2x = CStr(.Range("I" & i).Text) : If Rate2x = "" Then Throw New System.Exception("Rate2x Amount not Found at rownumber : " & i.ToString)

                    CallRate = CStr(.Range("J" & i).Text) : If CallRate = "" Then Throw New System.Exception("CallRate Amount not Found at rownumber : " & i.ToString)
                    Target = CStr(.Range("K" & i).Text) : If Target = "" Then Throw New System.Exception("Target Amount not Found at rownumber : " & i.ToString)
                    Rate = CStr(.Range("L" & i).Text) : If Rate = "" Then Throw New System.Exception("Rate Amount not Found at rownumber : " & i.ToString)

                    CallReach4x = CStr(.Range("M" & i).Text) : If CallReach4x = "" Then Throw New System.Exception("CallReach4x Amount not Found at rownumber : " & i.ToString)
                    TargetReach4x = CStr(.Range("N" & i).Text) : If TargetReach4x = "" Then Throw New System.Exception("TargetReach4x Amount not Found at rownumber : " & i.ToString)
                    RateReach4x = CStr(.Range("O" & i).Text) : If RateReach4x = "" Then Throw New System.Exception("RateReach4x Amount not Found at rownumber : " & i.ToString)

                    CallReach2x = CStr(.Range("P" & i).Text) : If CallReach2x = "" Then Throw New System.Exception("CallReach2x Amount not Found at rownumber : " & i.ToString)
                    TargetReach2x = CStr(.Range("Q" & i).Text) : If TargetReach2x = "" Then Throw New System.Exception("TargetReach2x Amount not Found at rownumber : " & i.ToString)
                    RateReach2x = CStr(.Range("R" & i).Text) : If RateReach2x = "" Then Throw New System.Exception("RateReach2x Amount not Found at rownumber : " & i.ToString)

                    CallReach = CStr(.Range("S" & i).Text) : If CallReach = "" Then Throw New System.Exception("CallReach Amount not Found at rownumber : " & i.ToString)
                    TargetReach = CStr(.Range("T" & i).Text) : If TargetReach = "" Then Throw New System.Exception("TargetReach Amount not Found at rownumber : " & i.ToString)
                    RateReach = CStr(.Range("U" & i).Text) : If RateReach = "" Then Throw New System.Exception("RateReach Amount not Found at rownumber : " & i.ToString)

                    DSMCode = CStr(.Range("V" & i).Text) : If DSMCode = "" Then Throw New System.Exception("DSM Code not Found at rownumber : " & i.ToString)
                    DSMName = CStr(.Range("W" & i).Text)
                    NSMCode = CStr(.Range("X" & i).Text) : If NSMCode = "" Then Throw New System.Exception("NSM Code not Found at rownumber : " & i.ToString)
                    NSMName = CStr(.Range("Y" & i).Text)
                    DivCode = CStr(.Range("Z" & i).Text) : If DivCode = "" Then Throw New System.Exception("Div Code not Found at rownumber : " & i.ToString)
                    DivisionName = CStr(.Range("AA" & i).Text)
                    CommissionDate = CStr(.Range("AB" & i).Text) : If CommissionDate = "" Then Throw New System.Exception("CommissionDate not Found at rownumber : " & i.ToString)
                    LateTag = CStr(.Range("AC" & i).Text)
                    DSMnotIncluded = CStr(.Range("AD" & i).Text)
                    DSMlateTag = CStr(.Range("AE" & i).Text)

                    Insert_ExcelFile(PMRCode, PMRName, CallRate4x, Target4x, Rate4x, CallRate2x, Target2x, Rate2x, CallRate, Target, Rate, _
                                    CallReach4x, TargetReach4x, RateReach4x, CallReach2x, TargetReach2x, RateReach2x, _
                                    CallReach, TargetReach, RateReach, DSMCode, DSMName, NSMCode, NSMName, _
                                    DivCode, DivisionName, CommissionDate, LateTag, DSMnotIncluded, DSMlateTag)
                    i = i + 1
                Loop Until PMRCode = "" And PMRName = "" And CallRate4x = "" And Target4x = "" And Rate4x = "" And CallRate2x = "" And Target2x = "" And Rate2x = "" And CallRate = "" And Target = "" And Rate = "" _
                    And CallReach4x = "" And TargetReach4x = "" And RateReach4x = "" And CallReach2x = "" And TargetReach2x = "" And RateReach2x = "" _
                    And CallReach = "" And TargetReach = "" And RateReach = "" And DSMCode = "" And DSMName = "" And NSMCode = "" And NSMName = ""
                InputCount.Text = CStr(i - 1)
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Extract_ExcelFileData module")
        Finally
            wb.Close()
            xl = Nothing
        End Try
        '03122013<<]


        'Dim xl As New Excel.Application
        'Dim wb As Excel.Workbook
        'Dim ws As Excel.Worksheet
        'Dim range As Excel.Range
        'Dim PMRCode, PMRName, DSMCode, DSMName, NSMCode, NSMName, DivCode, DivisionName As String
        'Dim CallRate4x, Target4x, Rate4x, CallRate2x, Target2x, Rate2x, CallRate, Target, Rate, LateTag, DSMnotIncluded, DSMlateTag As String
        'Dim CallReach, TargetReach, RateReach As String
        'Dim i As Integer = 2
        'Try
        '    wb = xl.Workbooks.Open(strFileName)
        '    ws = CType(wb.Worksheets.Item("Sheet1"), Excel.Worksheet)
        '    With ws
        '        Do
        '            PMRCode = CStr(.Range("B" & i).Text)
        '            PMRName = CStr(.Range("C" & i).Text) : If PMRCode = "" And PMRName > "" Then Throw New System.Exception("PMR Code not Found at rownumber : " & i.ToString)
        '            CallRate4x = CStr(.Range("D" & i).Text) : If CallRate4x = "" Then Throw New System.Exception("CallRate4x Amount not Found at rownumber : " & i.ToString)
        '            Target4x = CStr(.Range("E" & i).Text) : If Target4x = "" Then Throw New System.Exception("Target4x Amount not Found at rownumber : " & i.ToString)
        '            Rate4x = CStr(.Range("F" & i).Text) : If Rate4x = "" Then Throw New System.Exception("Rate4x Amount not Found at rownumber : " & i.ToString)
        '            CallRate2x = CStr(.Range("G" & i).Text) : If CallRate2x = "" Then Throw New System.Exception("CallRate2x Amount not Found at rownumber : " & i.ToString)
        '            Target2x = CStr(.Range("H" & i).Text) : If Target2x = "" Then Throw New System.Exception("Target2x Amount not Found at rownumber : " & i.ToString)
        '            Rate2x = CStr(.Range("I" & i).Text) : If Rate2x = "" Then Throw New System.Exception("Rate2x Amount not Found at rownumber : " & i.ToString)

        '            CallReach = CStr(.Range("S" & i).Text) : If CallReach = "" Then Throw New System.Exception("CallReach Amount not Found at rownumber : " & i.ToString)
        '            TargetReach = CStr(.Range("T" & i).Text) : If TargetReach = "" Then Throw New System.Exception("TargetReach Amount not Found at rownumber : " & i.ToString)
        '            RateReach = CStr(.Range("U" & i).Text) : If RateReach = "" Then Throw New System.Exception("RateReach Amount not Found at rownumber : " & i.ToString)

        '            CallRate = CStr(.Range("J" & i).Text) : If CallRate = "" Then Throw New System.Exception("CallRate Amount not Found at rownumber : " & i.ToString)
        '            Target = CStr(.Range("K" & i).Text) : If Target = "" Then Throw New System.Exception("Target Amount not Found at rownumber : " & i.ToString)
        '            Rate = CStr(.Range("L" & i).Text) : If Rate = "" Then Throw New System.Exception("Rate Amount not Found at rownumber : " & i.ToString)

        '            DSMCode = CStr(.Range("V" & i).Text) : If DSMCode = "" Then Throw New System.Exception("DSM Code not Found at rownumber : " & i.ToString)
        '            DSMName = CStr(.Range("W" & i).Text)
        '            NSMCode = CStr(.Range("X" & i).Text) : If NSMCode = "" Then Throw New System.Exception("NSM Code not Found at rownumber : " & i.ToString)
        '            NSMName = CStr(.Range("Y" & i).Text)
        '            DivCode = CStr(.Range("Z" & i).Text) : If DivCode = "" Then Throw New System.Exception("Div Code not Found at rownumber : " & i.ToString)
        '            DivisionName = CStr(.Range("AA" & i).Text)
        '            CommissionDate = CStr(.Range("AB" & i).Text) : If CommissionDate = "" Then Throw New System.Exception("CommissionDate not Found at rownumber : " & i.ToString)
        '            LateTag = CStr(.Range("AC" & i).Text)
        '            DSMnotIncluded = CStr(.Range("AD" & i).Text)
        '            DSMlateTag = CStr(.Range("AE" & i).Text)

        '            Insert_ExcelFile(PMRCode, PMRName, CallRate4x, Target4x, Rate4x, CallRate2x, Target2x, Rate2x, CallReach, TargetReach, RateReach, CallRate, Target, Rate, DSMCode, DSMName, NSMCode, NSMName, DivCode, DivisionName, CommissionDate, LateTag, DSMnotIncluded, DSMlateTag)
        '            i = i + 1
        '        Loop Until PMRCode = "" And PMRName = "" And CallRate4x = "" And Target4x = "" And Rate4x = "" And CallRate2x = "" And Target2x = "" And Rate2x = "" And CallReach = "" And TargetReach = "" And RateReach = "" And CallRate = "" And Target = "" And Rate = "" And DSMCode = "" And DSMName = "" And NSMCode = "" And NSMName = ""
        '        InputCount.Text = CStr(i - 1)
        '    End With
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Extract_ExcelFileData module")
        'Finally
        '    wb.Close()
        '    xl = Nothing
        'End Try
    End Sub
    Private Sub Insert_ExcelFile(ByVal ParamArray SubData() As String)
        '[>>rnj_popoy**remodified
        Dim cn As New SqlConnection(ServerPath2)
        Dim cm As New SqlCommand
        cm.CommandText = "Insert_CallRateData"
        cm.CommandType = CommandType.StoredProcedure

        Dim pmrcode As New SqlParameter("@pmrcode", SqlDbType.VarChar, 10) : pmrcode.Direction = ParameterDirection.Input : cm.Parameters.Add(pmrcode)
        Dim pmrname As New SqlParameter("@pmrname", SqlDbType.VarChar, 75) : pmrname.Direction = ParameterDirection.Input : cm.Parameters.Add(pmrname)

        Dim callrate4x As New SqlParameter("@callrate4x", SqlDbType.Money) : callrate4x.Direction = ParameterDirection.Input : cm.Parameters.Add(callrate4x)
        Dim target4x As New SqlParameter("@target4x", SqlDbType.Money) : target4x.Direction = ParameterDirection.Input : cm.Parameters.Add(target4x)
        Dim rate4x As New SqlParameter("@rate4x", SqlDbType.Money) : rate4x.Direction = ParameterDirection.Input : cm.Parameters.Add(rate4x)

        Dim callrate2x As New SqlParameter("@callrate2x", SqlDbType.Money) : callrate2x.Direction = ParameterDirection.Input : cm.Parameters.Add(callrate2x)
        Dim target2x As New SqlParameter("@target2x", SqlDbType.Money) : target2x.Direction = ParameterDirection.Input : cm.Parameters.Add(target2x)
        Dim rate2x As New SqlParameter("@rate2x", SqlDbType.Money) : rate2x.Direction = ParameterDirection.Input : cm.Parameters.Add(rate2x)

        Dim callrate As New SqlParameter("@callrate", SqlDbType.Money) : callrate.Direction = ParameterDirection.Input : cm.Parameters.Add(callrate)
        Dim target As New SqlParameter("@target", SqlDbType.Money) : target.Direction = ParameterDirection.Input : cm.Parameters.Add(target)
        Dim rate As New SqlParameter("@rate", SqlDbType.Money) : rate.Direction = ParameterDirection.Input : cm.Parameters.Add(rate)

        Dim callreach4x As New SqlParameter("@callreach4x", SqlDbType.Money) : callreach4x.Direction = ParameterDirection.Input : cm.Parameters.Add(callreach4x)
        Dim targetreach4x As New SqlParameter("@targetreach4x", SqlDbType.Money) : targetreach4x.Direction = ParameterDirection.Input : cm.Parameters.Add(targetreach4x)
        Dim ratereach4x As New SqlParameter("@ratereach4x", SqlDbType.Money) : ratereach4x.Direction = ParameterDirection.Input : cm.Parameters.Add(ratereach4x)

        Dim callreach2x As New SqlParameter("@callreach2x", SqlDbType.Money) : callreach4x.Direction = ParameterDirection.Input : cm.Parameters.Add(callreach2x)
        Dim targetreach2x As New SqlParameter("@targetreach2x", SqlDbType.Money) : targetreach4x.Direction = ParameterDirection.Input : cm.Parameters.Add(targetreach2x)
        Dim ratereach2x As New SqlParameter("@ratereach2x", SqlDbType.Money) : ratereach4x.Direction = ParameterDirection.Input : cm.Parameters.Add(ratereach2x)

        Dim callreach As New SqlParameter("@callreach", SqlDbType.Money) : callreach.Direction = ParameterDirection.Input : cm.Parameters.Add(callreach)
        Dim targetreach As New SqlParameter("@targetreach", SqlDbType.Money) : targetreach.Direction = ParameterDirection.Input : cm.Parameters.Add(targetreach)
        Dim ratereach As New SqlParameter("@ratereach", SqlDbType.Money) : ratereach.Direction = ParameterDirection.Input : cm.Parameters.Add(ratereach)

        Dim dsmcode As New SqlParameter("@dsmcode", SqlDbType.VarChar, 10) : dsmcode.Direction = ParameterDirection.Input : cm.Parameters.Add(dsmcode)
        Dim dsmname As New SqlParameter("@dsmname", SqlDbType.VarChar, 75) : dsmname.Direction = ParameterDirection.Input : cm.Parameters.Add(dsmname)
        Dim nsmcode As New SqlParameter("@nsmcode", SqlDbType.VarChar, 10) : nsmcode.Direction = ParameterDirection.Input : cm.Parameters.Add(nsmcode)
        Dim nsmname As New SqlParameter("@nsmname", SqlDbType.VarChar, 75) : nsmname.Direction = ParameterDirection.Input : cm.Parameters.Add(nsmname)
        Dim divcode As New SqlParameter("@divcode", SqlDbType.VarChar, 10) : divcode.Direction = ParameterDirection.Input : cm.Parameters.Add(divcode)
        Dim divisionname As New SqlParameter("@divisionname", SqlDbType.VarChar, 25) : divisionname.Direction = ParameterDirection.Input : cm.Parameters.Add(divisionname)
        Dim commissiondate As New SqlParameter("@commissiondate", SqlDbType.DateTime, 10) : commissiondate.Direction = ParameterDirection.Input : cm.Parameters.Add(commissiondate)
        Dim LateTag As New SqlParameter("@LateTag", SqlDbType.Char, 1) : LateTag.Direction = ParameterDirection.Input : cm.Parameters.Add(LateTag)
        Dim DSMnotIncluded As New SqlParameter("@DSMnotIncluded", SqlDbType.Char, 1) : DSMnotIncluded.Direction = ParameterDirection.Input : cm.Parameters.Add(DSMnotIncluded)
        Dim DSMlateTag As New SqlParameter("@DSMlateTag", SqlDbType.Char, 1) : DSMlateTag.Direction = ParameterDirection.Input : cm.Parameters.Add(DSMlateTag)

        'LateTag, DSMnotIncluded, DSMlateTag
        pmrcode.Value = SubData(0).ToString
        pmrname.Value = SubData(1).ToString

        callrate4x.Value = CDbl(SubData(2))
        target4x.Value = CDbl(SubData(3))
        rate4x.Value = CDbl(SubData(4))

        callrate2x.Value = CDbl(SubData(5))
        target2x.Value = CDbl(SubData(6))
        rate2x.Value = CDbl(SubData(7))

        callrate.Value = CDbl(SubData(8))
        target.Value = CDbl(SubData(9))
        rate.Value = CDbl(SubData(10))

        callreach4x.Value = CDbl(SubData(11))
        targetreach4x.Value = CDbl(SubData(12))
        ratereach4x.Value = CDbl(SubData(13))

        callreach2x.Value = CDbl(SubData(14))
        targetreach2x.Value = CDbl(SubData(15))
        ratereach2x.Value = CDbl(SubData(16))

        callreach.Value = CDbl(SubData(17))
        targetreach.Value = CDbl(SubData(18))
        ratereach.Value = CDbl(SubData(19))

        dsmcode.Value = SubData(20).ToString
        dsmname.Value = SubData(21).ToString
        nsmcode.Value = SubData(22).ToString
        nsmname.Value = SubData(23).ToString
        divcode.Value = SubData(24).ToString
        divisionname.Value = SubData(25).ToString
        commissiondate.Value = SubData(26).ToString
        LateTag.Value = SubData(27).ToString
        DSMnotIncluded.Value = SubData(28).ToString
        DSMlateTag.Value = SubData(29).ToString
        '03122013<<]


        'Dim pmrcode As New SqlParameter("@pmrcode", SqlDbType.VarChar, 10) : pmrcode.Direction = ParameterDirection.Input : cm.Parameters.Add(pmrcode)
        'Dim pmrname As New SqlParameter("@pmrname", SqlDbType.VarChar, 75) : pmrname.Direction = ParameterDirection.Input : cm.Parameters.Add(pmrname)

        'Dim callrate4x As New SqlParameter("@callrate4x", SqlDbType.Money) : callrate4x.Direction = ParameterDirection.Input : cm.Parameters.Add(callrate4x)
        'Dim target4x As New SqlParameter("@target4x", SqlDbType.Money) : target4x.Direction = ParameterDirection.Input : cm.Parameters.Add(target4x)
        'Dim rate4x As New SqlParameter("@rate4x", SqlDbType.Money) : rate4x.Direction = ParameterDirection.Input : cm.Parameters.Add(rate4x)

        'Dim callrate2x As New SqlParameter("@callrate2x", SqlDbType.Money) : callrate2x.Direction = ParameterDirection.Input : cm.Parameters.Add(callrate2x)
        'Dim target2x As New SqlParameter("@target2x", SqlDbType.Money) : target2x.Direction = ParameterDirection.Input : cm.Parameters.Add(target2x)
        'Dim rate2x As New SqlParameter("@rate2x", SqlDbType.Money) : rate2x.Direction = ParameterDirection.Input : cm.Parameters.Add(rate2x)

        'Dim callreach As New SqlParameter("@callreach", SqlDbType.Money) : callreach.Direction = ParameterDirection.Input : cm.Parameters.Add(callreach)
        'Dim targetreach As New SqlParameter("@targetreach", SqlDbType.Money) : targetreach.Direction = ParameterDirection.Input : cm.Parameters.Add(targetreach)
        'Dim ratereach As New SqlParameter("@ratereach", SqlDbType.Money) : ratereach.Direction = ParameterDirection.Input : cm.Parameters.Add(ratereach)

        'Dim callrate As New SqlParameter("@callrate", SqlDbType.Money) : callrate.Direction = ParameterDirection.Input : cm.Parameters.Add(callrate)
        'Dim target As New SqlParameter("@target", SqlDbType.Money) : target.Direction = ParameterDirection.Input : cm.Parameters.Add(target)
        'Dim rate As New SqlParameter("@rate", SqlDbType.Money) : rate.Direction = ParameterDirection.Input : cm.Parameters.Add(rate)

        'Dim dsmcode As New SqlParameter("@dsmcode", SqlDbType.VarChar, 10) : dsmcode.Direction = ParameterDirection.Input : cm.Parameters.Add(dsmcode)
        'Dim dsmname As New SqlParameter("@dsmname", SqlDbType.VarChar, 75) : dsmname.Direction = ParameterDirection.Input : cm.Parameters.Add(dsmname)
        'Dim nsmcode As New SqlParameter("@nsmcode", SqlDbType.VarChar, 10) : nsmcode.Direction = ParameterDirection.Input : cm.Parameters.Add(nsmcode)
        'Dim nsmname As New SqlParameter("@nsmname", SqlDbType.VarChar, 75) : nsmname.Direction = ParameterDirection.Input : cm.Parameters.Add(nsmname)
        'Dim divcode As New SqlParameter("@divcode", SqlDbType.VarChar, 10) : divcode.Direction = ParameterDirection.Input : cm.Parameters.Add(divcode)
        'Dim divisionname As New SqlParameter("@divisionname", SqlDbType.VarChar, 25) : divisionname.Direction = ParameterDirection.Input : cm.Parameters.Add(divisionname)
        'Dim commissiondate As New SqlParameter("@commissiondate", SqlDbType.DateTime, 10) : commissiondate.Direction = ParameterDirection.Input : cm.Parameters.Add(commissiondate)
        'Dim LateTag As New SqlParameter("@LateTag", SqlDbType.Char, 1) : LateTag.Direction = ParameterDirection.Input : cm.Parameters.Add(LateTag)
        'Dim DSMnotIncluded As New SqlParameter("@DSMnotIncluded", SqlDbType.Char, 1) : DSMnotIncluded.Direction = ParameterDirection.Input : cm.Parameters.Add(DSMnotIncluded)
        'Dim DSMlateTag As New SqlParameter("@DSMlateTag", SqlDbType.Char, 1) : DSMlateTag.Direction = ParameterDirection.Input : cm.Parameters.Add(DSMlateTag)

        ''LateTag, DSMnotIncluded, DSMlateTag
        'pmrcode.Value = SubData(0).ToString
        'pmrname.Value = SubData(1).ToString

        'callrate4x.Value = CDbl(SubData(2))
        'target4x.Value = CDbl(SubData(3))
        'rate4x.Value = CDbl(SubData(4))

        'callrate2x.Value = CDbl(SubData(5))
        'target2x.Value = CDbl(SubData(6))
        'rate2x.Value = CDbl(SubData(7))

        'callreach.Value = CDbl(SubData(8))
        'targetreach.Value = CDbl(SubData(9))
        'ratereach.Value = CDbl(SubData(10))

        'callrate.Value = CDbl(SubData(11))
        'target.Value = CDbl(SubData(12))
        'rate.Value = CDbl(SubData(13))

        'dsmcode.Value = SubData(14).ToString
        'dsmname.Value = SubData(15).ToString
        'nsmcode.Value = SubData(16).ToString
        'nsmname.Value = SubData(17).ToString
        'divcode.Value = SubData(18).ToString
        'divisionname.Value = SubData(19).ToString
        'commissiondate.Value = SubData(20).ToString
        'LateTag.Value = SubData(18).ToString
        'DSMnotIncluded.Value = SubData(21).ToString
        'DSMlateTag.Value = SubData(22).ToString

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