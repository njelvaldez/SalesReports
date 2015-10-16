Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Configuration

Public Class MdiWeeklySalesInvoiceExport
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnExport = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.MonthCalendar1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(208, 272)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(17, 239)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(178, 20)
        Me.NumericUpDown1.TabIndex = 16
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Week Number"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Cycle Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar1.Location = New System.Drawing.Point(16, 46)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 8
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnExport)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 280)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(208, 48)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        '
        'btnExport
        '
        Me.btnExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnExport.Location = New System.Drawing.Point(8, 17)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(192, 23)
        Me.btnExport.TabIndex = 13
        Me.btnExport.Text = "Export"
        '
        'MdiWeeklySalesInvoiceExport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(222, 339)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MdiWeeklySalesInvoiceExport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mdi Weekly Sales Invoice Export"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub MdiWeeklySalesInvoiceExport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Function GetWeekInMonth(ByVal dtDate As Date) As Integer

        Dim DateWeekNumber As Integer = DatePart(DateInterval.WeekOfYear, dtDate, FirstDayOfWeek.Monday)
        Dim MonthStartWeek As Integer = DatePart(DateInterval.WeekOfYear, New DateTime(dtDate.Year, dtDate.Month, 1), FirstDayOfWeek.Monday)
        Return DateWeekNumber - MonthStartWeek + 1

    End Function

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Dim thisCheckBox As CheckBox = CType(sender, CheckBox)

        'If thisCheckBox.Checked = True Then
        '    If thisCheckBox.Name = "CheckBox1" Then
        '        EnableOptionControls(False)
        '        CheckBox2.Checked = False
        '    Else
        '        EnableOptionControls(True)
        '        CheckBox1.Checked = False
        '    End If
        'End If

    End Sub

    'Private Sub EnableOptionControls(ByVal enabl As Boolean)

    '    DateTimePicker1.Enabled = enabl
    '    DateTimePicker2.Enabled = enabl

    '    MonthCalendar1.Enabled = Not enabl
    '    NumericUpDown1.Enabled = Not enabl

    'End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click

        Me.Cursor = Cursors.WaitCursor
        ExportToExcel()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub ExportToExcel()

        'Start a new workbook in Excel.
        Dim Excel As New Excel.Application
        Dim wBook As Excel.Workbook
        Dim wSheet As Excel.Worksheet
        'Dim range As Microsoft.Office.Interop.Excel.Range
        Dim outFileName As String = Application.StartupPath & "\" & CType(ConfigurationManager.AppSettings.Item("MDIWeeklySalesForInvoicingFileName"), System.String) & " - " & MonthCalendar1.SelectionStart.ToString("MMMM") & _
        MonthCalendar1.SelectionStart.ToString("yyyy") & "(Week" & NumericUpDown1.Value.ToString() & ")"

        wBook = Excel.Workbooks.Add()
        wSheet = CType(wBook.ActiveSheet(), Excel.Worksheet)

        Try

            'Retrieve the results here
            DataMaintenance.myParamArray(0, 0) = "@MdiCycleDate"
            DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
            DataMaintenance.myParamArray(0, 2) = 10
            DataMaintenance.myParamArray(0, 3) = ParameterDirection.Input
            DataMaintenance.myParamArray(0, 4) = "Date"
            DataMaintenance.myParamArray(0, 5) = Month(MonthCalendar1.SelectionStart).ToString() & "/1/" & _
            Year(MonthCalendar1.SelectionStart).ToString()

            DataMaintenance.myParamArray(1, 0) = "@FromDate"
            DataMaintenance.myParamArray(1, 1) = SqlDbType.DateTime
            DataMaintenance.myParamArray(1, 2) = 10
            DataMaintenance.myParamArray(1, 3) = ParameterDirection.Input
            DataMaintenance.myParamArray(1, 4) = "Date"
            DataMaintenance.myParamArray(1, 5) = MonthCalendar1.SelectionStart

            DataMaintenance.myParamArray(2, 0) = "@ToDate"
            DataMaintenance.myParamArray(2, 1) = SqlDbType.DateTime
            DataMaintenance.myParamArray(2, 2) = 10
            DataMaintenance.myParamArray(2, 3) = ParameterDirection.Input
            DataMaintenance.myParamArray(2, 4) = "Date"
            DataMaintenance.myParamArray(2, 5) = MonthCalendar1.SelectionEnd

            DataMaintenance.myParamArray(3, 0) = "@SalesWeek"
            DataMaintenance.myParamArray(3, 1) = SqlDbType.Int
            DataMaintenance.myParamArray(3, 2) = 1
            DataMaintenance.myParamArray(3, 3) = ParameterDirection.Input
            DataMaintenance.myParamArray(3, 4) = "Integer"
            DataMaintenance.myParamArray(3, 5) = NumericUpDown1.Value

            Dim myDataTable As System.Data.DataTable = DataMaintenance.GetDataTable(ServerPath2, "MdiWeeklySalesInvoiceExport", _
            CommandType.StoredProcedure, 4)

            'Export dt
            Dim dt As System.Data.DataTable = myDataTable
            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            For Each dc In dt.Columns
                colIndex = colIndex + 1
                Excel.Cells(1, colIndex) = dc.ColumnName
            Next

            'Define styles here
            Dim NumberStyle As Excel.Style = Excel.ActiveWorkbook.Styles.Add("NumberStyle")
            NumberStyle.NumberFormat = "#,##0.00"

            Dim IntegerStyle As Excel.Style = Excel.ActiveWorkbook.Styles.Add("IntegerStyle")
            IntegerStyle.NumberFormat = "0"

            Dim TextStyle As Excel.Style = Excel.ActiveWorkbook.Styles.Add("TextStyle")
            TextStyle.NumberFormat = "@"

            Dim DateStyle As Excel.Style = Excel.ActiveWorkbook.Styles.Add("DateStyle")
            DateStyle.NumberFormat = "mm/dd/yyyy"

            Dim SalesOrderNumberStyle As Excel.Style = Excel.ActiveWorkbook.Styles.Add("SalesOrderNumberStyle")
            SalesOrderNumberStyle.NumberFormat = "0000000000"

            Dim BatchNumberStyle As Excel.Style = Excel.ActiveWorkbook.Styles.Add("BatchNumberStyle")
            BatchNumberStyle.NumberFormat = "0000000-0"

            For Each dr In dt.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In dt.Columns
                    colIndex = colIndex + 1
                    'If dc.ColumnName = "NET SALES AMOUNT" Then
                    '    MessageBox.Show("Ping")
                    'End If
                    Excel.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                    Dim rangeStyles As Excel.Range = CType(Excel.Cells(rowIndex + 1, colIndex), Excel.Range)
                    Select Case dc.DataType.FullName
                        Case "System.String"
                            rangeStyles.Style = "TextStyle"
                        Case "System.Decimal"
                            Select Case dc.ColumnName
                                Case "QUANTITY SOLD", "QUANTITY FREE"
                                    rangeStyles.Style = "IntegerStyle"
                                Case Else
                                    rangeStyles.Style = "NumberStyle"
                            End Select
                        Case "System.DateTime"
                            rangeStyles.Style = "DateStyle"
                    End Select
                Next
            Next

        Catch ex As Exception
            MsgBox("Error saving data to cells", MsgBoxStyle.Critical, "Error")
        End Try

        'Formatting

        Try

            wSheet.Columns.AutoFit()
            'formatting date
            'wSheet.Range("B:B").NumberFormat = "ddMM"

        Catch ex As Exception
            MsgBox("Error in formatting cells", MsgBoxStyle.Critical, "Error")
        End Try

        'Saving

        Try

            'Check if file exists if not, save file
            Dim button As DialogResult
            Dim _sheetname As String = "sheetname"

            If File.Exists(outFileName & ".csv") Then
                button = MessageBox.Show _
                    ("There is already a file called " & System.IO.Path.GetFileName(outFileName) & ".csv", "Replace File", _
                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning, _
                     MessageBoxDefaultButton.Button1)
                If button = System.Windows.Forms.DialogResult.Yes Then
                    Excel.DisplayAlerts = False
                Else
                    Dim i As String
                    i = InputBox("Enter the file name", "", System.IO.Path.GetFileName(outFileName))
                    outFileName = Application.StartupPath & "\" & i
                End If
            End If

        Catch ex As Exception
            MsgBox("Error saving excel file", MsgBoxStyle.Exclamation, "Error")
            wSheet = Nothing
            wBook = Nothing
            Excel.Quit()
            Excel = Nothing
            GC.Collect()
            Exit Sub
        End Try


        wBook.SaveAs(outFileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlCSV)
        MessageBox.Show("The file was successfully saved.", "MDI Weekly Sales Export")
        Excel.Visible = False
        Excel.DisplayAlerts = False
        wSheet = Nothing
        wBook = Nothing
        Excel.Quit()
        Excel = Nothing
        GC.Collect()

    End Sub
End Class
