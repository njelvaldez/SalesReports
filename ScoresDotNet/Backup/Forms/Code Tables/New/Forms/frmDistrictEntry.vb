Imports System.Data.SqlClient

Public Class frmDistrictEntry
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBoxDivisionName As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePickerCreateDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBoxEncoder As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDimCode As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDistrictName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDistrictCode As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents ComboBoxCompanyName As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridDistrictCode As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridDistrictName As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridDimCode As System.Windows.Forms.DataGrid
    Friend WithEvents ComboBoxStartDate As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxEndDate As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePickerEndDate1 As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DateTimePickerEndDate = New System.Windows.Forms.DateTimePicker
        Me.ComboBoxEndDate = New System.Windows.Forms.ComboBox
        Me.DataGridDimCode = New System.Windows.Forms.DataGrid
        Me.DataGridDistrictName = New System.Windows.Forms.DataGrid
        Me.DataGridDistrictCode = New System.Windows.Forms.DataGrid
        Me.ComboBoxCompanyName = New System.Windows.Forms.ComboBox
        Me.ButtonClear = New System.Windows.Forms.Button
        Me.ButtonSave = New System.Windows.Forms.Button
        Me.ComboBoxDivisionName = New System.Windows.Forms.ComboBox
        Me.DateTimePickerCreateDate = New System.Windows.Forms.DateTimePicker
        Me.TextBoxEncoder = New System.Windows.Forms.TextBox
        Me.TextBoxDimCode = New System.Windows.Forms.TextBox
        Me.TextBoxDistrictName = New System.Windows.Forms.TextBox
        Me.TextBoxDistrictCode = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBoxStartDate = New System.Windows.Forms.ComboBox
        Me.DateTimePickerStartDate = New System.Windows.Forms.DateTimePicker
        Me.DateTimePickerEndDate1 = New System.Windows.Forms.DateTimePicker
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridDimCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridDistrictName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridDistrictCode, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(320, 303)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePickerEndDate)
        Me.GroupBox1.Controls.Add(Me.ComboBoxEndDate)
        Me.GroupBox1.Controls.Add(Me.DataGridDimCode)
        Me.GroupBox1.Controls.Add(Me.DataGridDistrictName)
        Me.GroupBox1.Controls.Add(Me.DataGridDistrictCode)
        Me.GroupBox1.Controls.Add(Me.ComboBoxCompanyName)
        Me.GroupBox1.Controls.Add(Me.ButtonClear)
        Me.GroupBox1.Controls.Add(Me.ButtonSave)
        Me.GroupBox1.Controls.Add(Me.ComboBoxDivisionName)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerCreateDate)
        Me.GroupBox1.Controls.Add(Me.TextBoxEncoder)
        Me.GroupBox1.Controls.Add(Me.TextBoxDimCode)
        Me.GroupBox1.Controls.Add(Me.TextBoxDistrictName)
        Me.GroupBox1.Controls.Add(Me.TextBoxDistrictCode)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBoxStartDate)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerStartDate)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerEndDate1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(5, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(310, 296)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'DateTimePickerEndDate
        '
        Me.DateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePickerEndDate.Location = New System.Drawing.Point(104, 168)
        Me.DateTimePickerEndDate.MaxDate = New Date(2078, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerEndDate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerEndDate.Name = "DateTimePickerEndDate"
        Me.DateTimePickerEndDate.Size = New System.Drawing.Size(100, 21)
        Me.DateTimePickerEndDate.TabIndex = 7
        Me.DateTimePickerEndDate.Value = New Date(2078, 12, 31, 0, 0, 0, 0)
        '
        'ComboBoxEndDate
        '
        Me.ComboBoxEndDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEndDate.DropDownWidth = 200
        Me.ComboBoxEndDate.Enabled = False
        Me.ComboBoxEndDate.Location = New System.Drawing.Point(104, 168)
        Me.ComboBoxEndDate.MaxDropDownItems = 13
        Me.ComboBoxEndDate.Name = "ComboBoxEndDate"
        Me.ComboBoxEndDate.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxEndDate.TabIndex = 7
        Me.ComboBoxEndDate.Visible = False
        '
        'DataGridDimCode
        '
        Me.DataGridDimCode.DataMember = ""
        Me.DataGridDimCode.Enabled = False
        Me.DataGridDimCode.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridDimCode.Location = New System.Drawing.Point(16, 272)
        Me.DataGridDimCode.Name = "DataGridDimCode"
        Me.DataGridDimCode.Size = New System.Drawing.Size(32, 16)
        Me.DataGridDimCode.TabIndex = 15
        Me.DataGridDimCode.Visible = False
        '
        'DataGridDistrictName
        '
        Me.DataGridDistrictName.DataMember = ""
        Me.DataGridDistrictName.Enabled = False
        Me.DataGridDistrictName.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridDistrictName.Location = New System.Drawing.Point(80, 272)
        Me.DataGridDistrictName.Name = "DataGridDistrictName"
        Me.DataGridDistrictName.Size = New System.Drawing.Size(32, 16)
        Me.DataGridDistrictName.TabIndex = 14
        Me.DataGridDistrictName.Visible = False
        '
        'DataGridDistrictCode
        '
        Me.DataGridDistrictCode.DataMember = ""
        Me.DataGridDistrictCode.Enabled = False
        Me.DataGridDistrictCode.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridDistrictCode.Location = New System.Drawing.Point(48, 272)
        Me.DataGridDistrictCode.Name = "DataGridDistrictCode"
        Me.DataGridDistrictCode.Size = New System.Drawing.Size(32, 16)
        Me.DataGridDistrictCode.TabIndex = 13
        Me.DataGridDistrictCode.Visible = False
        '
        'ComboBoxCompanyName
        '
        Me.ComboBoxCompanyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCompanyName.DropDownWidth = 220
        Me.ComboBoxCompanyName.Enabled = False
        Me.ComboBoxCompanyName.Location = New System.Drawing.Point(104, 120)
        Me.ComboBoxCompanyName.MaxDropDownItems = 15
        Me.ComboBoxCompanyName.Name = "ComboBoxCompanyName"
        Me.ComboBoxCompanyName.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxCompanyName.TabIndex = 5
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(184, 248)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.TabIndex = 11
        Me.ButtonClear.Text = "&Clear"
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(104, 248)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.TabIndex = 10
        Me.ButtonSave.Text = "&Save"
        '
        'ComboBoxDivisionName
        '
        Me.ComboBoxDivisionName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDivisionName.DropDownWidth = 220
        Me.ComboBoxDivisionName.Enabled = False
        Me.ComboBoxDivisionName.Location = New System.Drawing.Point(104, 96)
        Me.ComboBoxDivisionName.MaxDropDownItems = 15
        Me.ComboBoxDivisionName.Name = "ComboBoxDivisionName"
        Me.ComboBoxDivisionName.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxDivisionName.TabIndex = 4
        '
        'DateTimePickerCreateDate
        '
        Me.DateTimePickerCreateDate.Enabled = False
        Me.DateTimePickerCreateDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePickerCreateDate.Location = New System.Drawing.Point(104, 192)
        Me.DateTimePickerCreateDate.MaxDate = New Date(2078, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerCreateDate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerCreateDate.Name = "DateTimePickerCreateDate"
        Me.DateTimePickerCreateDate.Size = New System.Drawing.Size(100, 21)
        Me.DateTimePickerCreateDate.TabIndex = 8
        '
        'TextBoxEncoder
        '
        Me.TextBoxEncoder.Enabled = False
        Me.TextBoxEncoder.Location = New System.Drawing.Point(104, 216)
        Me.TextBoxEncoder.Name = "TextBoxEncoder"
        Me.TextBoxEncoder.Size = New System.Drawing.Size(80, 21)
        Me.TextBoxEncoder.TabIndex = 9
        Me.TextBoxEncoder.Text = ""
        '
        'TextBoxDimCode
        '
        Me.TextBoxDimCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxDimCode.Location = New System.Drawing.Point(104, 72)
        Me.TextBoxDimCode.MaxLength = 10
        Me.TextBoxDimCode.Name = "TextBoxDimCode"
        Me.TextBoxDimCode.Size = New System.Drawing.Size(152, 21)
        Me.TextBoxDimCode.TabIndex = 3
        Me.TextBoxDimCode.Text = ""
        '
        'TextBoxDistrictName
        '
        Me.TextBoxDistrictName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxDistrictName.Location = New System.Drawing.Point(104, 48)
        Me.TextBoxDistrictName.MaxLength = 50
        Me.TextBoxDistrictName.Name = "TextBoxDistrictName"
        Me.TextBoxDistrictName.Size = New System.Drawing.Size(152, 21)
        Me.TextBoxDistrictName.TabIndex = 2
        Me.TextBoxDistrictName.Text = ""
        '
        'TextBoxDistrictCode
        '
        Me.TextBoxDistrictCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxDistrictCode.Location = New System.Drawing.Point(104, 24)
        Me.TextBoxDistrictCode.MaxLength = 10
        Me.TextBoxDistrictCode.Name = "TextBoxDistrictCode"
        Me.TextBoxDistrictCode.Size = New System.Drawing.Size(80, 21)
        Me.TextBoxDistrictCode.TabIndex = 1
        Me.TextBoxDistrictCode.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(44, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Start Date"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "SegmentName"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Company"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dim Code"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "District Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(49, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "End Date"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(35, 192)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 17)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Create Date"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(54, 216)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 17)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Encoder"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "District Code"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBoxStartDate
        '
        Me.ComboBoxStartDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxStartDate.DropDownWidth = 200
        Me.ComboBoxStartDate.Location = New System.Drawing.Point(104, 144)
        Me.ComboBoxStartDate.MaxDropDownItems = 13
        Me.ComboBoxStartDate.Name = "ComboBoxStartDate"
        Me.ComboBoxStartDate.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxStartDate.TabIndex = 6
        '
        'DateTimePickerStartDate
        '
        Me.DateTimePickerStartDate.Enabled = False
        Me.DateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerStartDate.Location = New System.Drawing.Point(104, 144)
        Me.DateTimePickerStartDate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerStartDate.Name = "DateTimePickerStartDate"
        Me.DateTimePickerStartDate.Size = New System.Drawing.Size(100, 21)
        Me.DateTimePickerStartDate.TabIndex = 6
        Me.DateTimePickerStartDate.Visible = False
        '
        'DateTimePickerEndDate1
        '
        Me.DateTimePickerEndDate1.Enabled = False
        Me.DateTimePickerEndDate1.Location = New System.Drawing.Point(104, 168)
        Me.DateTimePickerEndDate1.Name = "DateTimePickerEndDate1"
        Me.DateTimePickerEndDate1.TabIndex = 7
        Me.DateTimePickerEndDate1.Value = New Date(2078, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerEndDate1.Visible = False
        '
        'frmDistrictEntry
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(320, 303)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmDistrictEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "District Entry"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridDimCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridDistrictName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridDistrictCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private MyCodeTableDS As New CodeTablesDS
    Private _frmDistrictSupervisorMaint As New frmDistrictSupervisorMaint

    Private Sub frmDistrictEntry_Load(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles MyBase.Load
        Me.CompanyNameList()
        Me.DistrictStartDate()
        'Me.DistrictEndDate()
        TextBoxEncoder.Text = UCase(Trim(gUserID))
        Me.DistrictCodeList()
        Me.DistrictNameList()
        Me.DimCodeList()
        ComboBoxCompanyName.SelectedIndex = 1
    End Sub

    Private Sub CompanyNameList()
        Me.Cursor = Cursors.WaitCursor

        Dim _DT As DataTable = New DataTable
        Dim _DR As DataRow

        Dim BusinessObject As New BusinessLayer.clsFileMaintenance

        If MyCodeTableDS.sp_company_name.Count > 0 Then _
            MyCodeTableDS.sp_company_name.Clear()

        Try
            BusinessObject.Sub_Show(ServerPath, "sp_company_name", CommandType.StoredProcedure, _
                MyCodeTableDS, "sp_company_name")

            _DT = MyCodeTableDS.sp_company_name
            _DR = _DT.NewRow()

            _DR(1) = "<- Select Company Name ->"
            _DT.Rows.InsertAt(_DR, 0)

            With ComboBoxCompanyName
                .DataSource = _DT
                .DisplayMember = "Company"
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub DivisionNameList()
        Me.Cursor = Cursors.WaitCursor

        Dim _DT As DataTable = New DataTable
        Dim _DR As DataRow

        Dim BusinessObject As New BusinessLayer.clsFileMaintenance

        If MyCodeTableDS.sp_division_name.Count > 0 Then _
            MyCodeTableDS.sp_division_name.Clear()

        Try
            BusinessObject.Sub_Show(ServerPath, "sp_division_name", CommandType.StoredProcedure, _
                MyCodeTableDS, "sp_division_name")

            _DT = MyCodeTableDS.sp_division_name
            _DR = _DT.NewRow()

            _DR(1) = "<- Select Division Name ->"
            _DT.Rows.InsertAt(_DR, 0)

            With ComboBoxDivisionName
                .DataSource = _DT
                .DisplayMember = "Division Name"
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub ButtonClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles ButtonClear.Click
        Me.ClearEntry()
    End Sub

    Private Sub ButtonSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles ButtonSave.Click

        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(9) As SqlParameter

        If TextBoxDistrictCode.Text = "" Or TextBoxDistrictName.Text = "" Or _
            ComboBoxStartDate.SelectedIndex = 0 Then
            'ComboBoxEndDate.SelectedIndex = 0 Then
            Return

        Else
            Me.DistrictCodeValidate(UCase(Trim(TextBoxDistrictCode.Text)), True)
            'Me.DistrictNameValidate(UCase(Trim(TextBoxDistrictName.Text)), True)
            'Me.DimCodeValidate(UCase(Trim(TextBoxDimCode.Text)), True)

            'If _bConfirmedDC Or _bConfirmedDN Or _bConfirmedDim Then
            If _bConfirmedDC Then
                Return
            Else
                If (MessageBox.Show("You're about to save this entry! Click Yes if you want to proceed.", "Saving", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then

                    Try
                        Dim _districtcode As New SqlParameter("@districtcode", SqlDbType.Char, 10)
                        _districtcode.Direction = ParameterDirection.Input
                        _districtcode.Value = UCase(Trim(TextBoxDistrictCode.Text))
                        Params(0) = _districtcode

                        Dim _districtname As New SqlParameter("@districtname", SqlDbType.VarChar, 50)
                        _districtname.Direction = ParameterDirection.Input
                        _districtname.Value = UCase(Trim(TextBoxDistrictName.Text))
                        Params(1) = _districtname

                        Dim _dimcode As New SqlParameter("@dimcode", SqlDbType.VarChar, 50)
                        _dimcode.Direction = ParameterDirection.Input
                        _dimcode.Value = UCase(Trim(TextBoxDimCode.Text))
                        Params(2) = _dimcode

                        Dim _company As New SqlParameter("@company", SqlDbType.VarChar, 50)
                        _company.Direction = ParameterDirection.Input
                        _company.Value = ComboBoxCompanyName.Text
                        Params(3) = _company

                        Dim _divisionname As New SqlParameter("@divisionname", SqlDbType.VarChar, 50)
                        _divisionname.Direction = ParameterDirection.Input
                        _divisionname.Value = ComboBoxDivisionName.Text
                        Params(4) = _divisionname

                        Dim _startdate As New SqlParameter("@startdate", SqlDbType.DateTime)
                        _startdate.Direction = ParameterDirection.Input
                        '_startdate.Value = DateTimePickerStartDate.Text
                        _startdate.Value = ComboBoxStartDate.Text
                        Params(5) = _startdate

                        Dim _enddate As New SqlParameter("@enddate", SqlDbType.DateTime)
                        _enddate.Direction = ParameterDirection.Input
                        _enddate.Value = DateTimePickerEndDate.Value.ToString()
                        '_enddate.Value = ComboBoxEndDate.Text
                        Params(6) = _enddate

                        Dim _createdate As New SqlParameter("@createdate", SqlDbType.DateTime)
                        _createdate.Direction = ParameterDirection.Input
                        _createdate.Value = DateTimePickerCreateDate.Value.ToString()
                        Params(7) = _createdate

                        Dim _encoder As New SqlParameter("@lastuser", SqlDbType.Char, 10)
                        _encoder.Direction = ParameterDirection.Input
                        _encoder.Value = Trim(TextBoxEncoder.Text)
                        Params(8) = _encoder

                        Dim _status As New SqlParameter("@status", SqlDbType.Char, 10)
                        _status.Direction = ParameterDirection.Input
                        _status.Value = "active"
                        Params(9) = _status

                        Try
                            BusinessObject.Sub_Insert(ServerPath, "sp_insert_district", CommandType.StoredProcedure, Params)
                            Me.ClearEntry()
                            Me.Close()
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
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

    Private Sub TextBoxDistrictCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
        Handles TextBoxDistrictCode.KeyUp
        Dim _sPadZero As String

        If TextBoxDistrictCode.Text = "" Then
            MyCodeTableDS.sp_division_name.Clear()
            Return
        Else
            If TextBoxDistrictCode.TextLength <= 2 Then
                _sPadZero = TextBoxDistrictCode.Text.PadLeft(2, "0"c)
                Me.PopulatePerDivisionName(_sPadZero)
            Else
                Return
            End If
        End If
    End Sub

    Private Sub TextBoxDistrictCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles TextBoxDistrictCode.LostFocus
        Dim _sPadZero, _s3 As String

        If TextBoxDistrictCode.Text = "" Then
            MyCodeTableDS.sp_division_name.Clear()
            Return

        ElseIf TextBoxDistrictCode.TextLength <> 0 Then
            _s3 = TextBoxDistrictCode.Text.Substring(0, 2)
            Me.PopulatePerDivisionName(_s3)

        Else
            MyCodeTableDS.sp_division_name.Clear()
            Return

        End If
    End Sub

    Private Sub DistrictCodeValidate(ByVal _sValue As String, ByVal _b As Boolean)
        Dim _s, _sDistrictCode As String
        Dim _i, _x, _iCount As Integer

        _iCount = MyCodeTableDS.sp_district_code_list.Rows.Count

        If _iCount <> 0 Then
            For _i = 0 To _iCount - 1
                With DataGridDistrictCode
                    _sDistrictCode = .Item(_i, 0).ToString()
                    _x = _sDistrictCode.ToString.Length
                    _s = _sDistrictCode.PadLeft(_x, "0"c)

                    If _sValue = _s Then
                        MessageBox.Show("Duplicate of data entry! District code [" + _sValue + "] already existed!", "Duplication", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        _bConfirmedDC = True
                        Exit For
                    Else
                        _bConfirmedDC = False
                    End If
                End With

            Next
        End If

    End Sub

    Private Sub DistrictCodeList()
        Me.Cursor = Cursors.WaitCursor

        Dim BusinessObject As New BusinessLayer.clsFileMaintenance

        If MyCodeTableDS.sp_district_code_list.Count > 0 Then _
            MyCodeTableDS.sp_district_code_list.Clear()

        Try
            BusinessObject.Sub_Show(ServerPath, "sp_district_code_list", CommandType.StoredProcedure, _
                MyCodeTableDS, "sp_district_code_list")

            DataGridDistrictCode.DataSource = MyCodeTableDS.sp_district_code_list

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub DistrictNameValidate(ByVal _sValue As String, ByVal _b As Boolean)
        Dim _sDistrictName As String
        Dim _i, _iCount As Integer

        _iCount = MyCodeTableDS.sp_district_name_list.Rows.Count

        If _iCount <> 0 Then
            For _i = 0 To _iCount - 1
                With DataGridDistrictName
                    _sDistrictName = .Item(_i, 0).ToString()

                    If _sValue = _sDistrictName Then
                        MessageBox.Show("Duplicate of data entry! District name [" + _sValue + "] already existed!", "Duplication", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                        _bConfirmedDN = True
                        Exit For

                    Else
                        _bConfirmedDN = False

                    End If
                End With

            Next
        End If

    End Sub

    Private Sub DistrictNameList()
        Me.Cursor = Cursors.WaitCursor

        Dim BusinessObject As New BusinessLayer.clsFileMaintenance

        If MyCodeTableDS.sp_district_name_list.Count > 0 Then _
            MyCodeTableDS.sp_district_name_list.Clear()

        Try
            BusinessObject.Sub_Show(ServerPath, "sp_district_name_list", CommandType.StoredProcedure, _
                MyCodeTableDS, "sp_district_name_list")

            DataGridDistrictName.DataSource = MyCodeTableDS.sp_district_name_list

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub DimCodeList()
        Me.Cursor = Cursors.WaitCursor

        Dim BusinessObject As New BusinessLayer.clsFileMaintenance

        If MyCodeTableDS.sp_dim_code_list.Count > 0 Then _
            MyCodeTableDS.sp_dim_code_list.Clear()

        Try
            BusinessObject.Sub_Show(ServerPath, "sp_dim_code_list", CommandType.StoredProcedure, _
                MyCodeTableDS, "sp_dim_code_list")

            DataGridDimCode.DataSource = MyCodeTableDS.sp_dim_code_list

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub DimCodeValidate(ByVal _sValue As String, ByVal _b As Boolean)
        Dim _sDimCode As String
        Dim _i, _iCount As Integer

        _iCount = MyCodeTableDS.sp_dim_code_list.Rows.Count

        If _iCount <> 0 Then
            For _i = 0 To _iCount - 1
                With DataGridDimCode
                    _sDimCode = .Item(_i, 0).ToString()

                    If _sValue = _sDimCode Then
                        MessageBox.Show("Duplicate of data entry! Dim code [" + _sValue + "] already existed!", "Duplication", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                        _bConfirmedDim = True
                        Exit For

                    Else
                        _bConfirmedDim = False

                    End If
                End With

            Next
        End If

    End Sub

    Private Sub PopulatePerDivisionName(ByVal _sValue As String)
        Me.Cursor = Cursors.WaitCursor
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter
        Dim _DT As DataTable = New DataTable

        If MyCodeTableDS.sp_division_name.Count > 0 Then _
            MyCodeTableDS.sp_division_name.Clear()

        Try
            Dim _districtcode As New SqlParameter("@districtcode", SqlDbType.Char, 10)
            _districtcode.Direction = ParameterDirection.Input
            _districtcode.Value = _sValue
            Params(0) = _districtcode

            Try
                BusinessObject.Sub_Show(ServerPath, "sp_division_name", CommandType.StoredProcedure, _
                    MyCodeTableDS, "sp_division_name", Params)

                _DT = MyCodeTableDS.sp_division_name

                With ComboBoxDivisionName
                    .DataSource = _DT
                    .DisplayMember = "Division Name"
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub DistrictStartDate()
        Me.Cursor = Cursors.WaitCursor

        Dim _DT As DataTable = New DataTable
        Dim _DR As DataRow

        Dim BusinessObject As New BusinessLayer.clsFileMaintenance

        If MyCodeTableDS.sp_district_start_date.Count > 0 Then _
            MyCodeTableDS.sp_district_start_date.Clear()

        Try
            BusinessObject.Sub_Show(ServerPath, "sp_district_start_date", CommandType.StoredProcedure, _
                MyCodeTableDS, "sp_district_start_date")

            _DT = MyCodeTableDS.sp_district_start_date
            _DR = _DT.NewRow()

            _DR(0) = "<- Select Start Date ->"
            _DT.Rows.InsertAt(_DR, 0)

            With ComboBoxStartDate
                .DataSource = _DT
                .DisplayMember = "start_date"
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub DistrictEndDate()
        Me.Cursor = Cursors.WaitCursor

        Dim _DT As DataTable = New DataTable
        Dim _DR As DataRow

        Dim BusinessObject As New BusinessLayer.clsFileMaintenance

        If MyCodeTableDS.sp_district_end_date.Count > 0 Then _
            MyCodeTableDS.sp_district_end_date.Clear()

        Try
            BusinessObject.Sub_Show(ServerPath, "sp_district_end_date", CommandType.StoredProcedure, _
                MyCodeTableDS, "sp_district_end_date")

            _DT = MyCodeTableDS.sp_district_end_date
            _DR = _DT.NewRow()

            _DR(0) = "<- Select End Date ->"
            _DT.Rows.InsertAt(_DR, 0)

            With ComboBoxEndDate
                .DataSource = _DT
                .DisplayMember = "end_date"
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub DGRefresh()
        Me.Cursor = Cursors.WaitCursor

        Dim BusinessObject As New BusinessLayer.clsFileMaintenance

        If MyCodeTableDS.sp_district_list.Count > 0 Then _
            MyCodeTableDS.sp_district_list.Clear()

        Try
            BusinessObject.Sub_Show(ServerPath, "sp_district_list", CommandType.StoredProcedure, _
                MyCodeTableDS, "sp_district_list")

            _frmDistrictSupervisorMaint.DataGridDistrictList.DataSource = MyCodeTableDS.sp_district_list
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub ClearEntry()
        TextBoxDimCode.Text = ""
        TextBoxDistrictCode.Text = ""
        TextBoxDistrictName.Text = ""
        ComboBoxCompanyName.SelectedIndex = 1
        'DateTimePickerStartDate.Value = DateTime.Now()
        'DateTimePickerEndDate.Value = DateTime.Now()
        ComboBoxStartDate.SelectedIndex = 0
        'ComboBoxEndDate.SelectedIndex = 0
        MyCodeTableDS.sp_division_name.Clear()
    End Sub

End Class
