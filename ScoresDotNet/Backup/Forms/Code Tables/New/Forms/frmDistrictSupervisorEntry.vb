Imports System.Data.SqlClient

Public Class frmDistrictSupervisorEntry
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
    Friend WithEvents ComboBoxSupervisorName As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxSupervisorCode As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePickerStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelSupervisorCode As System.Windows.Forms.Label
    Friend WithEvents LabelSupervisorName As System.Windows.Forms.Label
    Friend WithEvents LabelStartDate As System.Windows.Forms.Label
    Friend WithEvents LabelEndDate As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerCreateDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelEncoder As System.Windows.Forms.Label
    Friend WithEvents TextBoxEncoder As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents LabelCreateDate As System.Windows.Forms.Label
    Friend WithEvents DataGridMaxEndDate As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridMaxStartDate As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataGridMaxStartDate = New System.Windows.Forms.DataGrid
        Me.DataGridMaxEndDate = New System.Windows.Forms.DataGrid
        Me.ButtonClear = New System.Windows.Forms.Button
        Me.ButtonSave = New System.Windows.Forms.Button
        Me.LabelEncoder = New System.Windows.Forms.Label
        Me.TextBoxEncoder = New System.Windows.Forms.TextBox
        Me.LabelCreateDate = New System.Windows.Forms.Label
        Me.DateTimePickerCreateDate = New System.Windows.Forms.DateTimePicker
        Me.LabelEndDate = New System.Windows.Forms.Label
        Me.DateTimePickerEndDate = New System.Windows.Forms.DateTimePicker
        Me.LabelStartDate = New System.Windows.Forms.Label
        Me.DateTimePickerStartDate = New System.Windows.Forms.DateTimePicker
        Me.LabelSupervisorCode = New System.Windows.Forms.Label
        Me.TextBoxSupervisorCode = New System.Windows.Forms.TextBox
        Me.LabelSupervisorName = New System.Windows.Forms.Label
        Me.ComboBoxSupervisorName = New System.Windows.Forms.ComboBox
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridMaxStartDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridMaxEndDate, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(370, 232)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridMaxStartDate)
        Me.GroupBox1.Controls.Add(Me.DataGridMaxEndDate)
        Me.GroupBox1.Controls.Add(Me.ButtonClear)
        Me.GroupBox1.Controls.Add(Me.ButtonSave)
        Me.GroupBox1.Controls.Add(Me.LabelEncoder)
        Me.GroupBox1.Controls.Add(Me.TextBoxEncoder)
        Me.GroupBox1.Controls.Add(Me.LabelCreateDate)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerCreateDate)
        Me.GroupBox1.Controls.Add(Me.LabelEndDate)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerEndDate)
        Me.GroupBox1.Controls.Add(Me.LabelStartDate)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerStartDate)
        Me.GroupBox1.Controls.Add(Me.LabelSupervisorCode)
        Me.GroupBox1.Controls.Add(Me.TextBoxSupervisorCode)
        Me.GroupBox1.Controls.Add(Me.LabelSupervisorName)
        Me.GroupBox1.Controls.Add(Me.ComboBoxSupervisorName)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(5, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 225)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'DataGridMaxStartDate
        '
        Me.DataGridMaxStartDate.DataMember = ""
        Me.DataGridMaxStartDate.Enabled = False
        Me.DataGridMaxStartDate.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridMaxStartDate.Location = New System.Drawing.Point(40, 208)
        Me.DataGridMaxStartDate.Name = "DataGridMaxStartDate"
        Me.DataGridMaxStartDate.Size = New System.Drawing.Size(32, 16)
        Me.DataGridMaxStartDate.TabIndex = 0
        Me.DataGridMaxStartDate.Visible = False
        '
        'DataGridMaxEndDate
        '
        Me.DataGridMaxEndDate.DataMember = ""
        Me.DataGridMaxEndDate.Enabled = False
        Me.DataGridMaxEndDate.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridMaxEndDate.Location = New System.Drawing.Point(8, 208)
        Me.DataGridMaxEndDate.Name = "DataGridMaxEndDate"
        Me.DataGridMaxEndDate.Size = New System.Drawing.Size(32, 16)
        Me.DataGridMaxEndDate.TabIndex = 0
        Me.DataGridMaxEndDate.Visible = False
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(213, 182)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(72, 24)
        Me.ButtonClear.TabIndex = 8
        Me.ButtonClear.Text = "&Clear"
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(133, 182)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(72, 24)
        Me.ButtonSave.TabIndex = 7
        Me.ButtonSave.Text = "&Save"
        '
        'LabelEncoder
        '
        Me.LabelEncoder.AutoSize = True
        Me.LabelEncoder.Location = New System.Drawing.Point(52, 144)
        Me.LabelEncoder.Name = "LabelEncoder"
        Me.LabelEncoder.Size = New System.Drawing.Size(45, 17)
        Me.LabelEncoder.TabIndex = 18
        Me.LabelEncoder.Text = "Encoder"
        Me.LabelEncoder.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxEncoder
        '
        Me.TextBoxEncoder.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxEncoder.Enabled = False
        Me.TextBoxEncoder.Location = New System.Drawing.Point(132, 144)
        Me.TextBoxEncoder.Name = "TextBoxEncoder"
        Me.TextBoxEncoder.Size = New System.Drawing.Size(104, 21)
        Me.TextBoxEncoder.TabIndex = 6
        Me.TextBoxEncoder.Text = ""
        '
        'LabelCreateDate
        '
        Me.LabelCreateDate.AutoSize = True
        Me.LabelCreateDate.Location = New System.Drawing.Point(33, 120)
        Me.LabelCreateDate.Name = "LabelCreateDate"
        Me.LabelCreateDate.Size = New System.Drawing.Size(64, 17)
        Me.LabelCreateDate.TabIndex = 14
        Me.LabelCreateDate.Text = "Create Date"
        Me.LabelCreateDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePickerCreateDate
        '
        Me.DateTimePickerCreateDate.Enabled = False
        Me.DateTimePickerCreateDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePickerCreateDate.Location = New System.Drawing.Point(132, 120)
        Me.DateTimePickerCreateDate.MaxDate = New Date(2078, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerCreateDate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerCreateDate.Name = "DateTimePickerCreateDate"
        Me.DateTimePickerCreateDate.Size = New System.Drawing.Size(104, 21)
        Me.DateTimePickerCreateDate.TabIndex = 5
        Me.DateTimePickerCreateDate.Value = New Date(2012, 12, 18, 0, 0, 0, 0)
        '
        'LabelEndDate
        '
        Me.LabelEndDate.AutoSize = True
        Me.LabelEndDate.Location = New System.Drawing.Point(47, 96)
        Me.LabelEndDate.Name = "LabelEndDate"
        Me.LabelEndDate.Size = New System.Drawing.Size(50, 17)
        Me.LabelEndDate.TabIndex = 12
        Me.LabelEndDate.Text = "End Date"
        Me.LabelEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePickerEndDate
        '
        Me.DateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePickerEndDate.Location = New System.Drawing.Point(132, 96)
        Me.DateTimePickerEndDate.MaxDate = New Date(2078, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerEndDate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerEndDate.Name = "DateTimePickerEndDate"
        Me.DateTimePickerEndDate.Size = New System.Drawing.Size(104, 21)
        Me.DateTimePickerEndDate.TabIndex = 4
        Me.DateTimePickerEndDate.Value = New Date(2078, 12, 31, 0, 0, 0, 0)
        '
        'LabelStartDate
        '
        Me.LabelStartDate.AutoSize = True
        Me.LabelStartDate.Location = New System.Drawing.Point(42, 72)
        Me.LabelStartDate.Name = "LabelStartDate"
        Me.LabelStartDate.Size = New System.Drawing.Size(55, 17)
        Me.LabelStartDate.TabIndex = 10
        Me.LabelStartDate.Text = "Start Date"
        Me.LabelStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePickerStartDate
        '
        Me.DateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePickerStartDate.Location = New System.Drawing.Point(132, 72)
        Me.DateTimePickerStartDate.MaxDate = New Date(2078, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerStartDate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerStartDate.Name = "DateTimePickerStartDate"
        Me.DateTimePickerStartDate.Size = New System.Drawing.Size(104, 21)
        Me.DateTimePickerStartDate.TabIndex = 3
        Me.DateTimePickerStartDate.Value = New Date(2012, 10, 29, 0, 0, 0, 0)
        '
        'LabelSupervisorCode
        '
        Me.LabelSupervisorCode.AutoSize = True
        Me.LabelSupervisorCode.Location = New System.Drawing.Point(9, 48)
        Me.LabelSupervisorCode.Name = "LabelSupervisorCode"
        Me.LabelSupervisorCode.Size = New System.Drawing.Size(108, 17)
        Me.LabelSupervisorCode.TabIndex = 8
        Me.LabelSupervisorCode.Text = "Team Manager Code"
        Me.LabelSupervisorCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxSupervisorCode
        '
        Me.TextBoxSupervisorCode.Location = New System.Drawing.Point(132, 48)
        Me.TextBoxSupervisorCode.Name = "TextBoxSupervisorCode"
        Me.TextBoxSupervisorCode.ReadOnly = True
        Me.TextBoxSupervisorCode.Size = New System.Drawing.Size(104, 21)
        Me.TextBoxSupervisorCode.TabIndex = 2
        Me.TextBoxSupervisorCode.Text = ""
        '
        'LabelSupervisorName
        '
        Me.LabelSupervisorName.AutoSize = True
        Me.LabelSupervisorName.Location = New System.Drawing.Point(8, 24)
        Me.LabelSupervisorName.Name = "LabelSupervisorName"
        Me.LabelSupervisorName.Size = New System.Drawing.Size(112, 17)
        Me.LabelSupervisorName.TabIndex = 6
        Me.LabelSupervisorName.Text = "Team Manager Name"
        Me.LabelSupervisorName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBoxSupervisorName
        '
        Me.ComboBoxSupervisorName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSupervisorName.DropDownWidth = 230
        Me.ComboBoxSupervisorName.Location = New System.Drawing.Point(132, 24)
        Me.ComboBoxSupervisorName.MaxDropDownItems = 15
        Me.ComboBoxSupervisorName.Name = "ComboBoxSupervisorName"
        Me.ComboBoxSupervisorName.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxSupervisorName.TabIndex = 1
        '
        'frmDistrictSupervisorEntry
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(370, 232)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmDistrictSupervisorEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "District Team Manager Entry"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridMaxStartDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridMaxEndDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private MyCodeTableDS As New CodeTablesDS

    Private Sub frmDistrictSupervisorEntry_Load(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles MyBase.Load
        TextBoxEncoder.Text = UCase(Trim(gUserID))
        Me.SupervisorNameList()
        Me.MaxEndDateList()
        Me.MaxStartDateList()
    End Sub

    Private Sub SupervisorNameList()
        Me.Cursor = Cursors.WaitCursor
        Dim _DT As DataTable = New DataTable
        Dim _DR As DataRow
        Dim _sSupervisorCode As String
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance

        If MyCodeTableDS.sp_supervisor_name.Count > 0 Then _
            MyCodeTableDS.sp_supervisor_name.Clear()

        Try
            BusinessObject.Sub_Show(ServerPath, "sp_supervisor_name", CommandType.StoredProcedure, _
                MyCodeTableDS, "sp_supervisor_name")

            _DT = MyCodeTableDS.sp_supervisor_name
            _DR = _DT.NewRow()

            _DR(1) = "<- Select Supervisor Name ->"
            _DT.Rows.InsertAt(_DR, 0)

            With ComboBoxSupervisorName
                .DataSource = _DT
                .DisplayMember = "Supervisor Name"
                .ValueMember = "Supervisor Code"
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ComboBoxSupervisorName_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles ComboBoxSupervisorName.SelectedIndexChanged
        Dim _i As Integer

        _i = ComboBoxSupervisorName.SelectedIndex

        If _i <= 0 Then
            TextBoxSupervisorCode.Text = Nothing
            Return
        Else
            TextBoxSupervisorCode.Text = ComboBoxSupervisorName.SelectedValue.ToString()
        End If

    End Sub

    Private Sub ButtonSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonSave.Click
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(6) As SqlParameter

        If ComboBoxSupervisorName.SelectedIndex = 0 Or TextBoxSupervisorCode.Text = "" Then
            Return
        Else
            Me.MaxEndDateValidate(DateTimePickerEndDate.Text, True)
            'Me.MaxStartDateValidate(_s0District, True)

            'If _bConfirmedMED Or _bConfirmedMSD Then
            If _bConfirmedMED Then
                Return
            Else
                If (MessageBox.Show("You're about to save this entry! Click Yes if you want to proceed.", "Saving", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, _
                    MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then

                    Try
                        Dim _districtcode As New SqlParameter("@districtcode", SqlDbType.Char, 10)
                        _districtcode.Direction = ParameterDirection.Input
                        _districtcode.Value = UCase(_s0District)
                        Params(0) = _districtcode

                        Dim _supervisorcode As New SqlParameter("@supervisorcode", SqlDbType.Char, 10)
                        _supervisorcode.Direction = ParameterDirection.Input
                        _supervisorcode.Value = Trim(TextBoxSupervisorCode.Text)
                        Params(1) = _supervisorcode

                        Dim _startdate As New SqlParameter("@startdate", SqlDbType.DateTime)
                        _startdate.Direction = ParameterDirection.Input
                        _startdate.Value = DateTimePickerStartDate.Value.ToString()
                        Params(2) = _startdate

                        Dim _enddate As New SqlParameter("@enddate", SqlDbType.DateTime)
                        _enddate.Direction = ParameterDirection.Input
                        _enddate.Value = DateTimePickerEndDate.Value.ToString()
                        Params(3) = _enddate

                        Dim _createdate As New SqlParameter("@createdate", SqlDbType.DateTime)
                        _createdate.Direction = ParameterDirection.Input
                        _createdate.Value = DateTimePickerCreateDate.Value.ToString()
                        Params(4) = _createdate

                        Dim _encoder As New SqlParameter("@lastuser", SqlDbType.Char, 10)
                        _encoder.Direction = ParameterDirection.Input
                        _encoder.Value = Trim(gUserID)
                        Params(5) = _encoder

                        Dim _status As New SqlParameter("@status", SqlDbType.Char, 10)
                        _status.Direction = ParameterDirection.Input
                        _status.Value = "active"
                        Params(6) = _status

                        Try
                            BusinessObject.Sub_Insert(ServerPath, "sp_district_supervisor_insert", CommandType.StoredProcedure, Params)
                            Me.ClearEntry()
                            Me.Close()
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

    Private Sub ButtonClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonClear.Click
        Me.ClearEntry()
    End Sub

    Private Sub MaxEndDateList()
        Me.Cursor = Cursors.WaitCursor
        Dim Params(0) As SqlParameter

        Dim BusinessObject As New BusinessLayer.clsFileMaintenance

        Try
            Dim _districtcode As New SqlParameter("@districtcode", SqlDbType.Char, 10)
            _districtcode.Direction = ParameterDirection.Input
            _districtcode.Value = Trim(_s0District)
            Params(0) = _districtcode

            Try
                BusinessObject.Sub_Show(ServerPath, "sp_get_max_end_date", CommandType.StoredProcedure, _
                    MyCodeTableDS, "sp_get_max_end_date", Params)

                DataGridMaxEndDate.DataSource = MyCodeTableDS.sp_get_max_end_date

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Me.Cursor = Cursors.Default

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub MaxEndDateValidate(ByVal _sValue As String, ByVal _b As Boolean)
        Dim _sMaxEndDate, _sSupervisorCode As String
        Dim _i, _iCount As Integer

        _iCount = MyCodeTableDS.sp_get_max_end_date.Rows.Count

        If _iCount <> 0 Then
            For _i = 0 To _iCount - 1
                With DataGridMaxEndDate
                    _sMaxEndDate = .Item(_i, 0).ToString()
                    _sMaxEndDate = Format(CDate(_sMaxEndDate), "d")
                    _sSupervisorCode = .Item(_i, 1).ToString()

                    If CDate(_sMaxEndDate) = Nothing Then
                        _bConfirmedMED = False
                        Return

                    ElseIf Format(CDate(_sMaxEndDate), "yyyy") = "2078" Then
                        MessageBox.Show("You need to close the end date [" + Format(CDate(_sMaxEndDate), "d") + "]" & vbNewLine & _
                        "of Supervisor Code [" + Trim(_sSupervisorCode) + "] before creating a new one!", "Closing End Date", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                        _bConfirmedMED = True
                        Exit For

                    ElseIf CDate(_sValue) < CDate(_sMaxEndDate) Or _
                        CDate(DateTimePickerStartDate.Text) = CDate(DateTimePickerEndDate.Text) Then
                        MessageBox.Show("The created end date should not be less than" & vbNewLine & _
                            "or equal to start date [" + Format(CDate(DateTimePickerStartDate.Text), "d") + "].", _
                            "Invalid Max End Date", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                        _bConfirmedMED = True
                        Exit For

                    Else
                        _bConfirmedMED = False

                    End If
                End With
            Next

        Else
            If CDate(DateTimePickerStartDate.Text) = CDate(DateTimePickerEndDate.Text) Then
                MessageBox.Show("The created end date should not be less than" & vbNewLine & _
                "or equal to start date [" + Format(CDate(DateTimePickerStartDate.Text), "d") + "].", _
                "Invalid Max End Date", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                _bConfirmedMED = True

            ElseIf CDate(DateTimePickerStartDate.Text) > CDate(DateTimePickerEndDate.Text) Then
                MessageBox.Show("The created end date should not be less than" & vbNewLine & _
               "or equal to start date [" + Format(CDate(DateTimePickerStartDate.Text), "d") + "].", _
               "Invalid Max End Date", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                _bConfirmedMED = True

            Else
                _bConfirmedMED = False

            End If
        End If
    End Sub

    Private Sub MaxStartDateList()
        Me.Cursor = Cursors.WaitCursor
        Dim Params(0) As SqlParameter
        Dim _sMaxEndDate As String
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance

        Try
            Dim _districtcode As New SqlParameter("@districtcode", SqlDbType.Char, 10)
            _districtcode.Direction = ParameterDirection.Input
            _districtcode.Value = Trim(_s0District)
            Params(0) = _districtcode

            Try
                BusinessObject.Sub_Show(ServerPath, "sp_get_max_start_date", CommandType.StoredProcedure, _
                    MyCodeTableDS, "sp_get_max_start_date", Params)

                DataGridMaxStartDate.DataSource = MyCodeTableDS.sp_get_max_start_date

                '[!>>rnj_popoy
                'this will get the maximum end date of the first day then set to start date
                Dim _iRow As Integer = MyCodeTableDS.sp_get_max_end_date.Rows.Count

                If _iRow <> 0 Then
                    For _i As Integer = 0 To _iRow - 1
                        With DataGridMaxEndDate
                            _sMaxEndDate = .Item(_i, 0).ToString()
                            DateTimePickerStartDate.Text = Format(CDate(_sMaxEndDate), "d")

                            If _sMaxEndDate = "" Then
                                'Dim _dtFrom As DateTime = DateTimePickerStartDate.Value
                                '_dtFrom = _dtFrom.AddDays(-(_dtFrom.Day - 1))
                                'DateTimePickerStartDate.Value = _dtFrom
                                Me.FromStartDate(DateTimePickerStartDate.Value)
                                Exit For

                            ElseIf Format(CDate(_sMaxEndDate), "yyyy") = "2078" Then
                                'Dim _dtFrom As DateTime = DateTimePickerStartDate.Value
                                '_dtFrom = _dtFrom.AddDays(-(_dtFrom.Day - 1))
                                'DateTimePickerStartDate.Value = _dtFrom
                                Me.FromStartDate(DateTimePickerStartDate.Value)
                                Exit For

                            Else
                                DateTimePickerStartDate.Text = Format(CDate(_sMaxEndDate), "d")
                                DateTimePickerStartDate.Value = DateTimePickerStartDate.Value.AddMonths(1)
                                'Dim _dtFrom As DateTime = DateTimePickerStartDate.Value
                                '_dtFrom = _dtFrom.AddDays(-(_dtFrom.Day - 1))
                                'DateTimePickerStartDate.Value = _dtFrom
                                Me.FromStartDate(DateTimePickerStartDate.Value)
                            End If

                        End With
                    Next
                Else
                    DateTimePickerStartDate.Value = DateTime.Now
                    'Dim _dtFrom As DateTime = DateTimePickerStartDate.Value
                    '_dtFrom = _dtFrom.AddDays(-(_dtFrom.Day - 1))
                    'DateTimePickerStartDate.Value = _dtFrom

                End If
                '10252012<<]

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Me.Cursor = Cursors.Default

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub MaxStartDateValidate(ByVal _sValue As String, ByVal _b As Boolean)
        Dim _sMaxStartDate, _sSupervisorCode As String
        Dim _i, _iCount As Integer

        _iCount = MyCodeTableDS.sp_get_max_start_date.Rows.Count

        If _iCount <> 0 Then
            For _i = 0 To _iCount - 1
                With DataGridMaxStartDate
                    _sMaxStartDate = .Item(_i, 0).ToString()
                    _sSupervisorCode = .Item(_i, 1).ToString()

                    If _sMaxStartDate = "" Then
                        _bConfirmedMSD = False
                        Return

                    ElseIf Format(CDate(_sMaxStartDate), "yyyy") >= "2078" Then
                        MessageBox.Show("You need to close the start date [" + Format(CDate(_sMaxStartDate), "d") + "]" & vbNewLine & _
                        "of Supervisor Code [" + Trim(_sSupervisorCode) + "] before creating a new one!", "Closing Start Date", _
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                        _bConfirmedMSD = True
                        Exit For

                    ElseIf DateTimePickerStartDate.Text <= Format(CDate(_sMaxStartDate), "d") Then
                        MessageBox.Show("Lower than or equal to the start date [" + Format(CDate(_sMaxStartDate), "d") + "] is not valid!" & vbNewLine & _
                        "Please create a new start date.", "Close End Date", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                        _bConfirmedMSD = True
                        Exit For

                    Else
                        _bConfirmedMSD = False

                    End If
                End With
            Next

        End If
    End Sub

    Private Sub ClearEntry()
        TextBoxSupervisorCode.Text = ""
        ComboBoxSupervisorName.SelectedIndex = 0
        ComboBoxSupervisorName.Enabled = False
        'DateTimePickerStartDate.Value = DateTime.Now()
        'DateTimePickerEndDate.Value = DateTime.Now()
    End Sub

    Private Sub FromStartDate(ByVal _dtFrom As DateTime)
        _dtFrom = _dtFrom.AddDays(-(_dtFrom.Day - 1))
        DateTimePickerStartDate.Value = _dtFrom
    End Sub
End Class
