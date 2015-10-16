Imports System.Data.SqlClient

Public Class TerritoryAreaUpdate
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
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBoxEncoder As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RichTextBoxAreaName As System.Windows.Forms.RichTextBox
    Friend WithEvents ComboBoxDivisionName As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxDistrictName As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxDimCode As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePickerStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxAreaCode As System.Windows.Forms.TextBox
    Friend WithEvents ButtonUpdate As System.Windows.Forms.Button
    Friend WithEvents DateTimePickerUpdateDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridAreaStartDate As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataGridAreaStartDate = New System.Windows.Forms.DataGrid
        Me.ButtonClear = New System.Windows.Forms.Button
        Me.ButtonUpdate = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBoxEncoder = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.DateTimePickerUpdateDate = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.DateTimePickerEndDate = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.RichTextBoxAreaName = New System.Windows.Forms.RichTextBox
        Me.ComboBoxDivisionName = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.ComboBoxDistrictName = New System.Windows.Forms.ComboBox
        Me.TextBoxDimCode = New System.Windows.Forms.TextBox
        Me.DateTimePickerStartDate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBoxAreaCode = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridAreaStartDate, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(322, 327)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridAreaStartDate)
        Me.GroupBox1.Controls.Add(Me.ButtonClear)
        Me.GroupBox1.Controls.Add(Me.ButtonUpdate)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TextBoxEncoder)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerUpdateDate)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerEndDate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.RichTextBoxAreaName)
        Me.GroupBox1.Controls.Add(Me.ComboBoxDivisionName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ComboBoxDistrictName)
        Me.GroupBox1.Controls.Add(Me.TextBoxDimCode)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerStartDate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxAreaCode)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(5, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 320)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'DataGridAreaStartDate
        '
        Me.DataGridAreaStartDate.DataMember = ""
        Me.DataGridAreaStartDate.Enabled = False
        Me.DataGridAreaStartDate.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridAreaStartDate.Location = New System.Drawing.Point(16, 280)
        Me.DataGridAreaStartDate.Name = "DataGridAreaStartDate"
        Me.DataGridAreaStartDate.Size = New System.Drawing.Size(32, 16)
        Me.DataGridAreaStartDate.TabIndex = 38
        Me.DataGridAreaStartDate.Visible = False
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(174, 280)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.TabIndex = 33
        Me.ButtonClear.Text = "&Clear"
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(94, 280)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.TabIndex = 32
        Me.ButtonUpdate.Text = "&Update"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(40, 246)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 17)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Encoder"
        '
        'TextBoxEncoder
        '
        Me.TextBoxEncoder.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxEncoder.Enabled = False
        Me.TextBoxEncoder.Location = New System.Drawing.Point(94, 243)
        Me.TextBoxEncoder.MaxLength = 10
        Me.TextBoxEncoder.Name = "TextBoxEncoder"
        Me.TextBoxEncoder.Size = New System.Drawing.Size(88, 21)
        Me.TextBoxEncoder.TabIndex = 30
        Me.TextBoxEncoder.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 223)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 17)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Update Date"
        '
        'DateTimePickerUpdateDate
        '
        Me.DateTimePickerUpdateDate.Enabled = False
        Me.DateTimePickerUpdateDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePickerUpdateDate.Location = New System.Drawing.Point(94, 219)
        Me.DateTimePickerUpdateDate.MaxDate = New Date(2078, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerUpdateDate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerUpdateDate.Name = "DateTimePickerUpdateDate"
        Me.DateTimePickerUpdateDate.Size = New System.Drawing.Size(120, 21)
        Me.DateTimePickerUpdateDate.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 17)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "End Date"
        '
        'DateTimePickerEndDate
        '
        Me.DateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePickerEndDate.Location = New System.Drawing.Point(94, 195)
        Me.DateTimePickerEndDate.MaxDate = New Date(2078, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerEndDate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerEndDate.Name = "DateTimePickerEndDate"
        Me.DateTimePickerEndDate.Size = New System.Drawing.Size(120, 21)
        Me.DateTimePickerEndDate.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Area Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Dim Code"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "District Name"
        '
        'RichTextBoxAreaName
        '
        Me.RichTextBoxAreaName.AutoSize = True
        Me.RichTextBoxAreaName.AutoWordSelection = True
        Me.RichTextBoxAreaName.Location = New System.Drawing.Point(94, 48)
        Me.RichTextBoxAreaName.MaxLength = 150
        Me.RichTextBoxAreaName.Name = "RichTextBoxAreaName"
        Me.RichTextBoxAreaName.Size = New System.Drawing.Size(208, 48)
        Me.RichTextBoxAreaName.TabIndex = 20
        Me.RichTextBoxAreaName.Text = ""
        '
        'ComboBoxDivisionName
        '
        Me.ComboBoxDivisionName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDivisionName.Location = New System.Drawing.Point(94, 147)
        Me.ComboBoxDivisionName.MaxDropDownItems = 15
        Me.ComboBoxDivisionName.Name = "ComboBoxDivisionName"
        Me.ComboBoxDivisionName.Size = New System.Drawing.Size(208, 21)
        Me.ComboBoxDivisionName.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 17)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Segment Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 17)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Start Date"
        '
        'ComboBoxDistrictName
        '
        Me.ComboBoxDistrictName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDistrictName.Location = New System.Drawing.Point(94, 123)
        Me.ComboBoxDistrictName.MaxDropDownItems = 15
        Me.ComboBoxDistrictName.Name = "ComboBoxDistrictName"
        Me.ComboBoxDistrictName.Size = New System.Drawing.Size(208, 21)
        Me.ComboBoxDistrictName.TabIndex = 23
        '
        'TextBoxDimCode
        '
        Me.TextBoxDimCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxDimCode.Location = New System.Drawing.Point(94, 99)
        Me.TextBoxDimCode.MaxLength = 10
        Me.TextBoxDimCode.Name = "TextBoxDimCode"
        Me.TextBoxDimCode.Size = New System.Drawing.Size(120, 21)
        Me.TextBoxDimCode.TabIndex = 22
        Me.TextBoxDimCode.Text = ""
        '
        'DateTimePickerStartDate
        '
        Me.DateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePickerStartDate.Location = New System.Drawing.Point(94, 171)
        Me.DateTimePickerStartDate.MaxDate = New Date(2078, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerStartDate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerStartDate.Name = "DateTimePickerStartDate"
        Me.DateTimePickerStartDate.Size = New System.Drawing.Size(120, 21)
        Me.DateTimePickerStartDate.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 17)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Area Name"
        '
        'TextBoxAreaCode
        '
        Me.TextBoxAreaCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxAreaCode.Location = New System.Drawing.Point(94, 24)
        Me.TextBoxAreaCode.MaxLength = 10
        Me.TextBoxAreaCode.Name = "TextBoxAreaCode"
        Me.TextBoxAreaCode.Size = New System.Drawing.Size(120, 21)
        Me.TextBoxAreaCode.TabIndex = 19
        Me.TextBoxAreaCode.Text = ""
        '
        'TerritoryAreaUpdate
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(322, 327)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "TerritoryAreaUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Territory Area Update"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridAreaStartDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private MyCodeTableDS As New CodeTablesDS
    Private BusinessObject As New BusinessLayer.clsFileMaintenance

    Private Sub TerritoryAreaUpdate_Load(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles MyBase.Load
        TextBoxAreaCode.Text = _s0TerritoryArea
        RichTextBoxAreaName.Text = _s1TerritoryArea
        TextBoxDimCode.Text = _s2TerritoryArea
        Me.DistrictSelections()
        Me.DivisionSelections()
        DateTimePickerStartDate.Value = CType(_s7TerritoryArea, DateTime)
        DateTimePickerEndDate.Value = CType(_s8TerritoryArea, DateTime)
        TextBoxEncoder.Text = UCase(Trim(gUserID))
    End Sub

    Private Sub DistrictSelections()
        Me.Cursor = Cursors.WaitCursor
        Dim _DT As DataTable = New DataTable
        Dim _DR As DataRow

        If MyCodeTableDS.sp_district_selections.Count > 0 Then _
            MyCodeTableDS.sp_district_selections.Clear()

        Try
            BusinessObject.Sub_Show(ServerPath, "sp_district_selections", CommandType.StoredProcedure, _
                MyCodeTableDS, "sp_district_selections")

            _DT = MyCodeTableDS.sp_district_selections
            _DR = _DT.NewRow()

            _DR(1) = "<- Select District Name ->"
            _DT.Rows.InsertAt(_DR, 0)

            With ComboBoxDistrictName
                .DataSource = _DT
                .DisplayMember = "District Name"
                .ValueMember = "District Code"
                .SelectedValue = _s3TerritoryArea
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub DivisionSelections()
        Me.Cursor = Cursors.WaitCursor
        Dim _DT As DataTable = New DataTable
        Dim _DR As DataRow

        If MyCodeTableDS.sp_division_selections.Count > 0 Then _
            MyCodeTableDS.sp_division_selections.Clear()

        Try
            BusinessObject.Sub_Show(ServerPath, "sp_division_selections", CommandType.StoredProcedure, _
                MyCodeTableDS, "sp_division_selections")

            _DT = MyCodeTableDS.sp_division_selections
            _DR = _DT.NewRow()

            _DR(1) = "<- Select Division Name ->"
            _DT.Rows.InsertAt(_DR, 0)

            With ComboBoxDivisionName
                .DataSource = _DT
                .DisplayMember = "Division Name"
                .ValueMember = "Division Code"
                .SelectedValue = _s5TerritoryArea
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub FromStartDate(ByVal _dtFrom As DateTime)
        With DateTimePickerStartDate
            .Value = _dtFrom.AddDays(-(_dtFrom.Day - 1))
        End With
    End Sub

    Private Sub ToEndDate(ByVal _dtTo As DateTime)
        Dim _dtNewTo As New DateTime((_dtTo.Year + 1), 1, 1)

        With DateTimePickerEndDate
            .Value = _dtNewTo.AddDays(-1)
        End With
    End Sub

    Private Sub StartDateValidate(ByVal _sValue As DateTime, ByVal _b As Boolean)
        If Format(CDate(_sValue), "yyyy") >= "2078" Then
            MessageBox.Show("The created start date with the year [" + Format(CDate(DateTimePickerStartDate.Value.ToString), "yyyy") + "] should not" & vbNewLine & _
            "be greater than or equal to year 2078.", "Start Date Error", _
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.FromStartDate(Date.Today())
            _bConfirmedSD = True
        ElseIf _sValue >= DateTimePickerEndDate.Value Then
            If _sValue = DateTimePickerEndDate.Value Or DateTimePickerEndDate.Value < _sValue Then
                MessageBox.Show("The created start date [" + Format(CDate(DateTimePickerStartDate.Value), "d") + "] should not be equal" & vbNewLine & _
                "or less than the created end date [" + Format(CDate(DateTimePickerEndDate.Value), "d") + "].", "Start & End Date Error", _
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.FromStartDate(Date.Today())
                Me.ToEndDate(Date.Today())
                _bConfirmedSD = True
            End If
        Else
            _bConfirmedSD = False
        End If
    End Sub

    Private Sub StartDateDuplicate(ByVal _sValue As DateTime, ByVal _b As Boolean)
        Dim Params(0) As SqlParameter

        Try
            Dim _areacode As New SqlParameter("@areacode", SqlDbType.Char, 10)
            _areacode.Direction = ParameterDirection.Input
            _areacode.Value = Trim(TextBoxAreaCode.Text)
            Params(0) = _areacode

            If MyCodeTableDS.sp_area_start_date.Count > 0 Then MyCodeTableDS.sp_area_start_date.Clear()

            Try
                BusinessObject.Sub_Show(ServerPath, "sp_area_start_date", CommandType.StoredProcedure, _
                    MyCodeTableDS, "sp_area_start_date", Params)

                DataGridAreaStartDate.DataSource = MyCodeTableDS.sp_area_start_date
                Dim _iCount As Integer = MyCodeTableDS.sp_area_start_date.Rows.Count

                If _iCount > 0 Then
                    For _i As Integer = 0 To _iCount - 1
                        With DataGridAreaStartDate
                            Dim _sYearMonth As String = Trim(.Item(_i, 0).ToString)

                            If _sYearMonth = Format(CDate(_sValue), "yyyy") + "" + Format(CDate(_sValue), "MM") Then
                                MessageBox.Show("The created start date with the Year of [" + Format(CDate(_sValue), "yyyy") + "]" & vbNewLine & _
                                "and a Month of [" + Format(CDate(_sValue), "MMMM") + "] should not have" & vbNewLine & _
                                "a duplicates from existed start date.", "Start Date Duplicate", _
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                Me.FromStartDate(Date.Today())
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
        TextBoxAreaCode.Text = ""
        RichTextBoxAreaName.Text = ""
        TextBoxDimCode.Text = ""
        ComboBoxDistrictName.SelectedIndex = 0
        ComboBoxDivisionName.SelectedIndex = 0
        Me.FromStartDate(Date.Today())
        Me.ToEndDate(Date.Today())
    End Sub

    Private Sub ButtonUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles ButtonUpdate.Click
        Dim Params(11) As SqlParameter
        Dim _sAreaName As String

        If TextBoxAreaCode.Text = "" Or RichTextBoxAreaName.Text = "" Or _
            ComboBoxDistrictName.SelectedIndex = 0 Or ComboBoxDivisionName.SelectedIndex = 0 Then
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

                    _sAreaName = Replace(Replace(RichTextBoxAreaName.Text, vbCr, vbNullString), vbLf, " ")

                    Try
                        Dim _areacode As New SqlParameter("@areacode", SqlDbType.Char, 10)
                        _areacode.Direction = ParameterDirection.Input
                        _areacode.Value = Trim(TextBoxAreaCode.Text)
                        Params(0) = _areacode

                        Dim _areaname As New SqlParameter("@areaname", SqlDbType.VarChar, 150)
                        _areaname.Direction = ParameterDirection.Input
                        _areaname.Value = Trim(_sAreaName)
                        Params(1) = _areaname

                        Dim _dimcode As New SqlParameter("@dimcode", SqlDbType.Char, 10)
                        _dimcode.Direction = ParameterDirection.Input
                        _dimcode.Value = Trim(TextBoxDimCode.Text)
                        Params(2) = _dimcode

                        Dim _districtcode As New SqlParameter("@districtcode", SqlDbType.Char, 10)
                        _districtcode.Direction = ParameterDirection.Input
                        _districtcode.Value = Trim(ComboBoxDistrictName.SelectedValue.ToString())
                        Params(3) = _districtcode

                        Dim _divcode As New SqlParameter("@divcode", SqlDbType.Char, 10)
                        _divcode.Direction = ParameterDirection.Input
                        _divcode.Value = Trim(ComboBoxDivisionName.SelectedValue.ToString())
                        Params(4) = _divcode

                        Dim _startdate As New SqlParameter("@startdate", SqlDbType.DateTime)
                        _startdate.Direction = ParameterDirection.Input
                        _startdate.Value = DateTimePickerStartDate.Value.ToString()
                        Params(5) = _startdate

                        Dim _endate As New SqlParameter("@endate", SqlDbType.DateTime)
                        _endate.Direction = ParameterDirection.Input
                        _endate.Value = DateTimePickerEndDate.Value.ToString()
                        Params(6) = _endate

                        Dim _updatedate As New SqlParameter("@updatedate", SqlDbType.DateTime)
                        _updatedate.Direction = ParameterDirection.Input
                        _updatedate.Value = DateTimePickerUpdateDate.Value.ToString()
                        Params(7) = _updatedate

                        Dim _encoder As New SqlParameter("@lastuser", SqlDbType.Char, 10)
                        _encoder.Direction = ParameterDirection.Input
                        _encoder.Value = Trim(TextBoxEncoder.Text)
                        Params(8) = _encoder

                        Dim _xareacode As New SqlParameter("@xareacode", SqlDbType.Char, 10)
                        _xareacode.Direction = ParameterDirection.Input
                        _xareacode.Value = Trim(_s0TerritoryArea)
                        Params(9) = _xareacode

                        Dim _xareaname As New SqlParameter("@xareaname", SqlDbType.VarChar, 150)
                        _xareaname.Direction = ParameterDirection.Input
                        _xareaname.Value = Trim(_s1TerritoryArea)
                        Params(10) = _xareaname

                        Dim _xstartdate As New SqlParameter("@xstartdate", SqlDbType.DateTime)
                        _xstartdate.Direction = ParameterDirection.Input
                        _xstartdate.Value = Format(CDate(_s7TerritoryArea), "d")
                        Params(11) = _xstartdate

                        Try
                            BusinessObject.Sub_Update(ServerPath, "sp_area_update", CommandType.StoredProcedure, Params)
                            Me.ClearEntry()
                            Me.Close()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try

                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Else
                    Return
                End If
            End If
        End If
    End Sub

    Private Sub ButtonClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles ButtonClear.Click
        Me.ClearEntry()
    End Sub

End Class
