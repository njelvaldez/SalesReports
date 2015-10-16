Imports System.Data.SqlClient

Public Class TerritoryAreaPMRUpdate
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents TextBoxEncoder As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxMedRepCode As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxAreaCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerUpdateDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents ButtonUpdate As System.Windows.Forms.Button
    Friend WithEvents DataGridAreaPMRStartDate As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataGridAreaPMRStartDate = New System.Windows.Forms.DataGrid
        Me.ButtonClear = New System.Windows.Forms.Button
        Me.ButtonUpdate = New System.Windows.Forms.Button
        Me.TextBoxEncoder = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.DateTimePickerUpdateDate = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.DateTimePickerEndDate = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.DateTimePickerStartDate = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.ComboBoxMedRepCode = New System.Windows.Forms.ComboBox
        Me.TextBoxAreaCode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridAreaPMRStartDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.DockPadding.Bottom = 5
        Me.Panel1.DockPadding.Left = 5
        Me.Panel1.DockPadding.Right = 5
        Me.Panel1.DockPadding.Top = 2
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(320, 229)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridAreaPMRStartDate)
        Me.GroupBox1.Controls.Add(Me.ButtonClear)
        Me.GroupBox1.Controls.Add(Me.ButtonUpdate)
        Me.GroupBox1.Controls.Add(Me.TextBoxEncoder)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerUpdateDate)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerEndDate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerStartDate)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboBoxMedRepCode)
        Me.GroupBox1.Controls.Add(Me.TextBoxAreaCode)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(5, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(310, 222)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'DataGridAreaPMRStartDate
        '
        Me.DataGridAreaPMRStartDate.DataMember = ""
        Me.DataGridAreaPMRStartDate.Enabled = False
        Me.DataGridAreaPMRStartDate.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridAreaPMRStartDate.Location = New System.Drawing.Point(24, 184)
        Me.DataGridAreaPMRStartDate.Name = "DataGridAreaPMRStartDate"
        Me.DataGridAreaPMRStartDate.Size = New System.Drawing.Size(32, 16)
        Me.DataGridAreaPMRStartDate.TabIndex = 43
        Me.DataGridAreaPMRStartDate.Visible = False
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(176, 184)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.TabIndex = 40
        Me.ButtonClear.Text = "&Clear"
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(96, 184)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.TabIndex = 38
        Me.ButtonUpdate.Text = "&Update"
        '
        'TextBoxEncoder
        '
        Me.TextBoxEncoder.Enabled = False
        Me.TextBoxEncoder.Location = New System.Drawing.Point(96, 144)
        Me.TextBoxEncoder.Name = "TextBoxEncoder"
        Me.TextBoxEncoder.TabIndex = 37
        Me.TextBoxEncoder.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(43, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 17)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Encoder"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 17)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Update Date"
        '
        'DateTimePickerUpdateDate
        '
        Me.DateTimePickerUpdateDate.Enabled = False
        Me.DateTimePickerUpdateDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePickerUpdateDate.Location = New System.Drawing.Point(96, 120)
        Me.DateTimePickerUpdateDate.MaxDate = New Date(2078, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerUpdateDate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerUpdateDate.Name = "DateTimePickerUpdateDate"
        Me.DateTimePickerUpdateDate.Size = New System.Drawing.Size(120, 21)
        Me.DateTimePickerUpdateDate.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 17)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "End Date"
        '
        'DateTimePickerEndDate
        '
        Me.DateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePickerEndDate.Location = New System.Drawing.Point(96, 96)
        Me.DateTimePickerEndDate.MaxDate = New Date(2078, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerEndDate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerEndDate.Name = "DateTimePickerEndDate"
        Me.DateTimePickerEndDate.Size = New System.Drawing.Size(120, 21)
        Me.DateTimePickerEndDate.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 17)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Start Date"
        '
        'DateTimePickerStartDate
        '
        Me.DateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePickerStartDate.Location = New System.Drawing.Point(96, 72)
        Me.DateTimePickerStartDate.MaxDate = New Date(2078, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerStartDate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerStartDate.Name = "DateTimePickerStartDate"
        Me.DateTimePickerStartDate.Size = New System.Drawing.Size(120, 21)
        Me.DateTimePickerStartDate.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 17)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Specialist Name"
        '
        'ComboBoxMedRepCode
        '
        Me.ComboBoxMedRepCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxMedRepCode.Enabled = False
        Me.ComboBoxMedRepCode.Location = New System.Drawing.Point(96, 48)
        Me.ComboBoxMedRepCode.MaxDropDownItems = 15
        Me.ComboBoxMedRepCode.Name = "ComboBoxMedRepCode"
        Me.ComboBoxMedRepCode.Size = New System.Drawing.Size(208, 21)
        Me.ComboBoxMedRepCode.TabIndex = 31
        '
        'TextBoxAreaCode
        '
        Me.TextBoxAreaCode.Enabled = False
        Me.TextBoxAreaCode.Location = New System.Drawing.Point(96, 24)
        Me.TextBoxAreaCode.MaxLength = 10
        Me.TextBoxAreaCode.Name = "TextBoxAreaCode"
        Me.TextBoxAreaCode.TabIndex = 30
        Me.TextBoxAreaCode.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Area Code"
        '
        'TerritoryAreaPMRUpdate
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(320, 229)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "TerritoryAreaPMRUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Territory Area Specialist Update"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridAreaPMRStartDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private MyCodeTableDS As New CodeTablesDS
    Private BusinessObject As New BusinessLayer.clsFileMaintenance

    Private Sub TerritoryAreaPMRUpdate_Load(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles MyBase.Load
        TextBoxAreaCode.Text = _s0TerritoryArea
        Me.MedRepSelections(_s0TerritoryAreaPMR)

        With DateTimePickerStartDate
            .Value = DateTime.Parse(_s2TerritoryAreaPMR)
        End With

        With DateTimePickerEndDate
            .Value = DateTime.Parse(_s3TerritoryAreaPMR)
        End With

        TextBoxEncoder.Text = UCase(Trim(gUserID))
    End Sub

    Private Sub MedRepSelections(ByVal _sValue As String)
        Me.Cursor = Cursors.WaitCursor
        Dim _DT As DataTable = New DataTable
        Dim _DR As DataRow

        If MyCodeTableDS.sp_med_rep_selections.Count > 0 Then MyCodeTableDS.sp_med_rep_selections.Clear()

        Try
            BusinessObject.Sub_Show(ServerPath, "sp_med_rep_selections", CommandType.StoredProcedure, _
                MyCodeTableDS, "sp_med_rep_selections")

            _DT = MyCodeTableDS.sp_med_rep_selections
            _DR = _DT.NewRow()

            _DR(1) = "<- Select MedRep Name ->"
            _DT.Rows.InsertAt(_DR, 0)

            With ComboBoxMedRepCode
                .DataSource = _DT
                .DisplayMember = "MedRep Name"
                .ValueMember = "MedRep Code"
                .SelectedValue = Trim(_sValue)
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub StartDateValidate(ByVal _sValue As DateTime, ByVal _b As Boolean)
        If Format(CDate(_sValue), "yyyy") >= "2078" Then
            MessageBox.Show("The created start date with the year [" + Format(CDate(DateTimePickerStartDate.Value.ToString), "yyyy") + "] should not" & vbNewLine & _
            "be greater than or equal to year 2078.", "Start Date Error", _
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            DateTimePickerStartDate.Value = GetFirstDayOfMonth(Date.Today())
            _bConfirmedSD = True
        ElseIf _sValue >= DateTimePickerEndDate.Value Then
            If _sValue = DateTimePickerEndDate.Value Or DateTimePickerEndDate.Value < _sValue Then
                MessageBox.Show("The created start date [" + Format(CDate(DateTimePickerStartDate.Value), "d") + "] should not be equal" & vbNewLine & _
                "or less than the created end date [" + Format(CDate(DateTimePickerEndDate.Value), "d") + "].", "Start & End Date Error", _
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                DateTimePickerStartDate.Value = GetFirstDayOfMonth(Date.Today())
                DateTimePickerEndDate.Value = GetLastDayOfYear(Date.Today())
                _bConfirmedSD = True
            End If
        Else
            _bConfirmedSD = False
        End If
    End Sub

    Private Sub StartDateDuplicate(ByVal _sValue As DateTime, ByVal _b As Boolean)
        Dim Params(1) As SqlParameter

        Try
            Dim _areacode As New SqlParameter("@areacode", SqlDbType.Char, 10)
            _areacode.Direction = ParameterDirection.Input
            _areacode.Value = Trim(TextBoxAreaCode.Text)
            Params(0) = _areacode

            Dim _mrcode As New SqlParameter("@mrcode", SqlDbType.Char, 10)
            _mrcode.Direction = ParameterDirection.Input
            _mrcode.Value = Trim(ComboBoxMedRepCode.SelectedValue.ToString())
            Params(1) = _mrcode

            If MyCodeTableDS.sp_area_pmr_start_date.Count > 0 Then MyCodeTableDS.sp_area_pmr_start_date.Clear()

            Try
                BusinessObject.Sub_Show(ServerPath, "sp_area_pmr_start_date", CommandType.StoredProcedure, _
                    MyCodeTableDS, "sp_area_pmr_start_date", Params)

                DataGridAreaPMRStartDate.DataSource = MyCodeTableDS.sp_area_pmr_start_date
                Dim _iCount As Integer = MyCodeTableDS.sp_area_pmr_start_date.Rows.Count

                If _iCount >= 2 Then
                    For _i As Integer = 0 To _iCount - 1
                        With DataGridAreaPMRStartDate
                            Dim _sYearMonth As String = Trim(.Item(_i, 0).ToString)

                            If _sYearMonth = Format(CDate(_sValue), "yyyy") + "" + Format(CDate(_sValue), "MM") Then
                                MessageBox.Show("The created start date with the Year of [" + Format(CDate(_sValue), "yyyy") + "]" & vbNewLine & _
                                "and a Month of [" + Format(CDate(_sValue), "MMMM") + "] should not have" & vbNewLine & _
                                "a duplicates from existed start date.", "Start Date Duplicate", _
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                DateTimePickerStartDate.Value = GetFirstDayOfMonth(Date.Today())
                                _bConfirmedSDDuplicated = True
                                Exit Sub
                            Else
                                _bConfirmedSDDuplicated = False
                            End If
                        End With
                    Next _i
                Else
                    _bConfirmedSDDuplicated = False
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ClearEntry()
        ComboBoxMedRepCode.SelectedIndex = 0
        DateTimePickerStartDate.Value = GetFirstDayOfMonth(Date.Today())
        DateTimePickerEndDate.Value = GetLastDayOfYear(Date.Today())
    End Sub

    Private Sub ButtonUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles ButtonUpdate.Click
        Dim Params(5) As SqlParameter

        If TextBoxAreaCode.Text = "" Or ComboBoxMedRepCode.SelectedIndex = 0 Then
            Return
        Else
            Me.StartDateValidate(DateTimePickerStartDate.Value, True)
            Me.StartDateDuplicate(DateTimePickerStartDate.Value, True)

            If _bConfirmedSD Or _bConfirmedSDDuplicated Then
                Return
            Else
                If (MessageBox.Show("You're about to update this entry! Click Yes if you want to proceed.", "Saving", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, _
                    MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then

                    Try
                        Dim _areacode As New SqlParameter("@areacode", SqlDbType.Char, 10)
                        _areacode.Direction = ParameterDirection.Input
                        _areacode.Value = Trim(TextBoxAreaCode.Text)
                        Params(0) = _areacode

                        Dim _mrcode As New SqlParameter("@mrcode", SqlDbType.Char, 10)
                        _mrcode.Direction = ParameterDirection.Input
                        _mrcode.Value = Trim(ComboBoxMedRepCode.SelectedValue.ToString())
                        Params(1) = _mrcode

                        Dim _startdate As New SqlParameter("@startdate", SqlDbType.DateTime)
                        _startdate.Direction = ParameterDirection.Input
                        _startdate.Value = DateTimePickerStartDate.Value.ToString()
                        Params(2) = _startdate

                        Dim _enddate As New SqlParameter("@enddate", SqlDbType.DateTime)
                        _enddate.Direction = ParameterDirection.Input
                        _enddate.Value = DateTimePickerEndDate.Value.ToString()
                        Params(3) = _enddate

                        Dim _updatedate As New SqlParameter("@updatedate", SqlDbType.DateTime)
                        _updatedate.Direction = ParameterDirection.Input
                        _updatedate.Value = DateTimePickerUpdateDate.Value.ToString()
                        Params(4) = _updatedate

                        Dim _encoder As New SqlParameter("@lastuser", SqlDbType.Char, 10)
                        _encoder.Direction = ParameterDirection.Input
                        _encoder.Value = Trim(TextBoxEncoder.Text)
                        Params(5) = _encoder

                        Try
                            BusinessObject.Sub_Update(ServerPath, "sp_area_pmr_update", CommandType.StoredProcedure, Params)
                            Me.ClearEntry()
                            Me.DialogResult = DialogResult.OK
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try

                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub ButtonClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles ButtonClear.Click
        Me.ClearEntry()
    End Sub

End Class
