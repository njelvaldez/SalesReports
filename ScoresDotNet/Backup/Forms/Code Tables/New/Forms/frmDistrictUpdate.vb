Imports System.Data.SqlClient

Public Class frmDistrictUpdate
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
    Friend WithEvents LabelDistrictCode As System.Windows.Forms.Label
    Friend WithEvents TextBoxDistrictCode As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxDistrictName As System.Windows.Forms.TextBox
    Friend WithEvents LabelDivisionName As System.Windows.Forms.Label
    Friend WithEvents LabelCreatedDate As System.Windows.Forms.Label
    Friend WithEvents LabelUpdateDate As System.Windows.Forms.Label
    Friend WithEvents LabelStatus As System.Windows.Forms.Label
    Friend WithEvents ComboBoxStatus As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonUpdate As System.Windows.Forms.Button
    Friend WithEvents DateTimePickerUpdateDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelDistrictName As System.Windows.Forms.Label
    Friend WithEvents DataGridDistrictCode As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridDistrictName As System.Windows.Forms.DataGrid
    Friend WithEvents LabelDimCode As System.Windows.Forms.Label
    Friend WithEvents TextBoxDimCode As System.Windows.Forms.TextBox
    Friend WithEvents LabelCompany As System.Windows.Forms.Label
    Friend WithEvents ComboBoxCompanyName As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePickerCreateDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelEndDate As System.Windows.Forms.Label
    Friend WithEvents ComboBoxDivisionName As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents DataGridDimCode As System.Windows.Forms.DataGrid
    Friend WithEvents ComboBoxStartDate As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxEndDate As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.LabelDistrictCode = New System.Windows.Forms.Label
        Me.TextBoxDistrictCode = New System.Windows.Forms.TextBox
        Me.TextBoxDistrictName = New System.Windows.Forms.TextBox
        Me.LabelDistrictName = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DateTimePickerStartDate = New System.Windows.Forms.DateTimePicker
        Me.DateTimePickerEndDate = New System.Windows.Forms.DateTimePicker
        Me.ComboBoxEndDate = New System.Windows.Forms.ComboBox
        Me.ComboBoxStartDate = New System.Windows.Forms.ComboBox
        Me.DataGridDimCode = New System.Windows.Forms.DataGrid
        Me.ButtonClear = New System.Windows.Forms.Button
        Me.ComboBoxDivisionName = New System.Windows.Forms.ComboBox
        Me.LabelEndDate = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DateTimePickerCreateDate = New System.Windows.Forms.DateTimePicker
        Me.ComboBoxCompanyName = New System.Windows.Forms.ComboBox
        Me.LabelCompany = New System.Windows.Forms.Label
        Me.TextBoxDimCode = New System.Windows.Forms.TextBox
        Me.LabelDimCode = New System.Windows.Forms.Label
        Me.DataGridDistrictName = New System.Windows.Forms.DataGrid
        Me.DataGridDistrictCode = New System.Windows.Forms.DataGrid
        Me.ButtonUpdate = New System.Windows.Forms.Button
        Me.ComboBoxStatus = New System.Windows.Forms.ComboBox
        Me.DateTimePickerUpdateDate = New System.Windows.Forms.DateTimePicker
        Me.LabelStatus = New System.Windows.Forms.Label
        Me.LabelUpdateDate = New System.Windows.Forms.Label
        Me.LabelDivisionName = New System.Windows.Forms.Label
        Me.LabelCreatedDate = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridDimCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridDistrictName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridDistrictCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelDistrictCode
        '
        Me.LabelDistrictCode.AutoSize = True
        Me.LabelDistrictCode.Location = New System.Drawing.Point(16, 24)
        Me.LabelDistrictCode.Name = "LabelDistrictCode"
        Me.LabelDistrictCode.Size = New System.Drawing.Size(68, 17)
        Me.LabelDistrictCode.TabIndex = 0
        Me.LabelDistrictCode.Text = "District Code"
        Me.LabelDistrictCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxDistrictCode
        '
        Me.TextBoxDistrictCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxDistrictCode.Location = New System.Drawing.Point(96, 24)
        Me.TextBoxDistrictCode.MaxLength = 10
        Me.TextBoxDistrictCode.Name = "TextBoxDistrictCode"
        Me.TextBoxDistrictCode.Size = New System.Drawing.Size(80, 21)
        Me.TextBoxDistrictCode.TabIndex = 1
        Me.TextBoxDistrictCode.Text = ""
        '
        'TextBoxDistrictName
        '
        Me.TextBoxDistrictName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxDistrictName.Location = New System.Drawing.Point(96, 48)
        Me.TextBoxDistrictName.MaxLength = 50
        Me.TextBoxDistrictName.Name = "TextBoxDistrictName"
        Me.TextBoxDistrictName.Size = New System.Drawing.Size(152, 21)
        Me.TextBoxDistrictName.TabIndex = 2
        Me.TextBoxDistrictName.Text = ""
        '
        'LabelDistrictName
        '
        Me.LabelDistrictName.AutoSize = True
        Me.LabelDistrictName.Location = New System.Drawing.Point(16, 48)
        Me.LabelDistrictName.Name = "LabelDistrictName"
        Me.LabelDistrictName.Size = New System.Drawing.Size(72, 17)
        Me.LabelDistrictName.TabIndex = 2
        Me.LabelDistrictName.Text = "District Name"
        Me.LabelDistrictName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.Panel1.Size = New System.Drawing.Size(306, 327)
        Me.Panel1.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePickerStartDate)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerEndDate)
        Me.GroupBox1.Controls.Add(Me.ComboBoxEndDate)
        Me.GroupBox1.Controls.Add(Me.ComboBoxStartDate)
        Me.GroupBox1.Controls.Add(Me.DataGridDimCode)
        Me.GroupBox1.Controls.Add(Me.ButtonClear)
        Me.GroupBox1.Controls.Add(Me.ComboBoxDivisionName)
        Me.GroupBox1.Controls.Add(Me.LabelEndDate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerCreateDate)
        Me.GroupBox1.Controls.Add(Me.ComboBoxCompanyName)
        Me.GroupBox1.Controls.Add(Me.LabelCompany)
        Me.GroupBox1.Controls.Add(Me.TextBoxDimCode)
        Me.GroupBox1.Controls.Add(Me.LabelDimCode)
        Me.GroupBox1.Controls.Add(Me.DataGridDistrictName)
        Me.GroupBox1.Controls.Add(Me.DataGridDistrictCode)
        Me.GroupBox1.Controls.Add(Me.ButtonUpdate)
        Me.GroupBox1.Controls.Add(Me.ComboBoxStatus)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerUpdateDate)
        Me.GroupBox1.Controls.Add(Me.LabelStatus)
        Me.GroupBox1.Controls.Add(Me.LabelUpdateDate)
        Me.GroupBox1.Controls.Add(Me.TextBoxDistrictCode)
        Me.GroupBox1.Controls.Add(Me.TextBoxDistrictName)
        Me.GroupBox1.Controls.Add(Me.LabelDistrictName)
        Me.GroupBox1.Controls.Add(Me.LabelDistrictCode)
        Me.GroupBox1.Controls.Add(Me.LabelDivisionName)
        Me.GroupBox1.Controls.Add(Me.LabelCreatedDate)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(5, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 320)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'DateTimePickerStartDate
        '
        Me.DateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePickerStartDate.Location = New System.Drawing.Point(96, 144)
        Me.DateTimePickerStartDate.MaxDate = New Date(2078, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerStartDate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerStartDate.Name = "DateTimePickerStartDate"
        Me.DateTimePickerStartDate.Size = New System.Drawing.Size(100, 21)
        Me.DateTimePickerStartDate.TabIndex = 6
        '
        'DateTimePickerEndDate
        '
        Me.DateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePickerEndDate.Location = New System.Drawing.Point(96, 168)
        Me.DateTimePickerEndDate.MaxDate = New Date(2078, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerEndDate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerEndDate.Name = "DateTimePickerEndDate"
        Me.DateTimePickerEndDate.Size = New System.Drawing.Size(100, 21)
        Me.DateTimePickerEndDate.TabIndex = 7
        '
        'ComboBoxEndDate
        '
        Me.ComboBoxEndDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEndDate.Enabled = False
        Me.ComboBoxEndDate.Location = New System.Drawing.Point(96, 168)
        Me.ComboBoxEndDate.MaxDropDownItems = 13
        Me.ComboBoxEndDate.Name = "ComboBoxEndDate"
        Me.ComboBoxEndDate.Size = New System.Drawing.Size(192, 21)
        Me.ComboBoxEndDate.TabIndex = 7
        Me.ComboBoxEndDate.Visible = False
        '
        'ComboBoxStartDate
        '
        Me.ComboBoxStartDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxStartDate.Enabled = False
        Me.ComboBoxStartDate.Location = New System.Drawing.Point(96, 144)
        Me.ComboBoxStartDate.MaxDropDownItems = 13
        Me.ComboBoxStartDate.Name = "ComboBoxStartDate"
        Me.ComboBoxStartDate.Size = New System.Drawing.Size(192, 21)
        Me.ComboBoxStartDate.TabIndex = 6
        Me.ComboBoxStartDate.Visible = False
        '
        'DataGridDimCode
        '
        Me.DataGridDimCode.DataMember = ""
        Me.DataGridDimCode.Enabled = False
        Me.DataGridDimCode.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridDimCode.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridDimCode.Location = New System.Drawing.Point(78, 296)
        Me.DataGridDimCode.Name = "DataGridDimCode"
        Me.DataGridDimCode.Size = New System.Drawing.Size(32, 16)
        Me.DataGridDimCode.TabIndex = 21
        Me.DataGridDimCode.Visible = False
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(176, 272)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.TabIndex = 12
        Me.ButtonClear.Text = "&Clear"
        '
        'ComboBoxDivisionName
        '
        Me.ComboBoxDivisionName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDivisionName.Enabled = False
        Me.ComboBoxDivisionName.Items.AddRange(New Object() {"<- Please select status ->", "ACTIVE", "INACTIVE"})
        Me.ComboBoxDivisionName.Location = New System.Drawing.Point(96, 120)
        Me.ComboBoxDivisionName.Name = "ComboBoxDivisionName"
        Me.ComboBoxDivisionName.Size = New System.Drawing.Size(192, 21)
        Me.ComboBoxDivisionName.TabIndex = 5
        '
        'LabelEndDate
        '
        Me.LabelEndDate.AutoSize = True
        Me.LabelEndDate.Location = New System.Drawing.Point(32, 168)
        Me.LabelEndDate.Name = "LabelEndDate"
        Me.LabelEndDate.Size = New System.Drawing.Size(50, 17)
        Me.LabelEndDate.TabIndex = 20
        Me.LabelEndDate.Text = "End Date"
        Me.LabelEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Start Date"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePickerCreateDate
        '
        Me.DateTimePickerCreateDate.Enabled = False
        Me.DateTimePickerCreateDate.Location = New System.Drawing.Point(96, 192)
        Me.DateTimePickerCreateDate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerCreateDate.Name = "DateTimePickerCreateDate"
        Me.DateTimePickerCreateDate.Size = New System.Drawing.Size(192, 21)
        Me.DateTimePickerCreateDate.TabIndex = 8
        '
        'ComboBoxCompanyName
        '
        Me.ComboBoxCompanyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCompanyName.Enabled = False
        Me.ComboBoxCompanyName.Items.AddRange(New Object() {"<- Please select status ->", "ACTIVE", "INACTIVE"})
        Me.ComboBoxCompanyName.Location = New System.Drawing.Point(96, 96)
        Me.ComboBoxCompanyName.Name = "ComboBoxCompanyName"
        Me.ComboBoxCompanyName.Size = New System.Drawing.Size(192, 21)
        Me.ComboBoxCompanyName.TabIndex = 4
        '
        'LabelCompany
        '
        Me.LabelCompany.AutoSize = True
        Me.LabelCompany.Location = New System.Drawing.Point(32, 96)
        Me.LabelCompany.Name = "LabelCompany"
        Me.LabelCompany.Size = New System.Drawing.Size(51, 17)
        Me.LabelCompany.TabIndex = 15
        Me.LabelCompany.Text = "Company"
        Me.LabelCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxDimCode
        '
        Me.TextBoxDimCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxDimCode.Location = New System.Drawing.Point(96, 72)
        Me.TextBoxDimCode.MaxLength = 10
        Me.TextBoxDimCode.Name = "TextBoxDimCode"
        Me.TextBoxDimCode.Size = New System.Drawing.Size(152, 21)
        Me.TextBoxDimCode.TabIndex = 3
        Me.TextBoxDimCode.Text = ""
        '
        'LabelDimCode
        '
        Me.LabelDimCode.AutoSize = True
        Me.LabelDimCode.Location = New System.Drawing.Point(32, 72)
        Me.LabelDimCode.Name = "LabelDimCode"
        Me.LabelDimCode.Size = New System.Drawing.Size(53, 17)
        Me.LabelDimCode.TabIndex = 13
        Me.LabelDimCode.Text = "Dim Code"
        Me.LabelDimCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridDistrictName
        '
        Me.DataGridDistrictName.DataMember = ""
        Me.DataGridDistrictName.Enabled = False
        Me.DataGridDistrictName.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridDistrictName.Location = New System.Drawing.Point(14, 296)
        Me.DataGridDistrictName.Name = "DataGridDistrictName"
        Me.DataGridDistrictName.Size = New System.Drawing.Size(32, 16)
        Me.DataGridDistrictName.TabIndex = 11
        Me.DataGridDistrictName.Visible = False
        '
        'DataGridDistrictCode
        '
        Me.DataGridDistrictCode.DataMember = ""
        Me.DataGridDistrictCode.Enabled = False
        Me.DataGridDistrictCode.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridDistrictCode.Location = New System.Drawing.Point(46, 296)
        Me.DataGridDistrictCode.Name = "DataGridDistrictCode"
        Me.DataGridDistrictCode.Size = New System.Drawing.Size(32, 16)
        Me.DataGridDistrictCode.TabIndex = 10
        Me.DataGridDistrictCode.Visible = False
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(96, 272)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.TabIndex = 11
        Me.ButtonUpdate.Text = "&Update"
        '
        'ComboBoxStatus
        '
        Me.ComboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxStatus.Items.AddRange(New Object() {"<- Please select status ->", "ACTIVE", "INACTIVE"})
        Me.ComboBoxStatus.Location = New System.Drawing.Point(96, 240)
        Me.ComboBoxStatus.Name = "ComboBoxStatus"
        Me.ComboBoxStatus.Size = New System.Drawing.Size(192, 21)
        Me.ComboBoxStatus.TabIndex = 10
        '
        'DateTimePickerUpdateDate
        '
        Me.DateTimePickerUpdateDate.Enabled = False
        Me.DateTimePickerUpdateDate.Location = New System.Drawing.Point(96, 216)
        Me.DateTimePickerUpdateDate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerUpdateDate.Name = "DateTimePickerUpdateDate"
        Me.DateTimePickerUpdateDate.Size = New System.Drawing.Size(192, 21)
        Me.DateTimePickerUpdateDate.TabIndex = 9
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Location = New System.Drawing.Point(48, 240)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(35, 17)
        Me.LabelStatus.TabIndex = 9
        Me.LabelStatus.Text = "Status"
        Me.LabelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelUpdateDate
        '
        Me.LabelUpdateDate.AutoSize = True
        Me.LabelUpdateDate.Location = New System.Drawing.Point(16, 216)
        Me.LabelUpdateDate.Name = "LabelUpdateDate"
        Me.LabelUpdateDate.Size = New System.Drawing.Size(67, 17)
        Me.LabelUpdateDate.TabIndex = 8
        Me.LabelUpdateDate.Text = "Update Date"
        Me.LabelUpdateDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelDivisionName
        '
        Me.LabelDivisionName.AutoSize = True
        Me.LabelDivisionName.Location = New System.Drawing.Point(8, 120)
        Me.LabelDivisionName.Name = "LabelDivisionName"
        Me.LabelDivisionName.Size = New System.Drawing.Size(81, 17)
        Me.LabelDivisionName.TabIndex = 6
        Me.LabelDivisionName.Text = "Segment Name"
        Me.LabelDivisionName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelCreatedDate
        '
        Me.LabelCreatedDate.AutoSize = True
        Me.LabelCreatedDate.Location = New System.Drawing.Point(16, 192)
        Me.LabelCreatedDate.Name = "LabelCreatedDate"
        Me.LabelCreatedDate.Size = New System.Drawing.Size(70, 17)
        Me.LabelCreatedDate.TabIndex = 7
        Me.LabelCreatedDate.Text = "Created Date"
        Me.LabelCreatedDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmDistrictUpdate
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(306, 327)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmDistrictUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "District Update"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridDimCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridDistrictName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridDistrictCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private _cbStatus As New ComboBox
    Private _frmDistrict As New frmDistrict
    Private MyCodeTableDS As New CodeTablesDS

    Private Sub frmDistrictUpdate_Load(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles MyBase.Load
        Dim _sStartYear, _sStartMonth, _sStartDay As String
        Dim _sEndMonth, _sEndDay, _sEndYear As String

        _cbStatus = ComboBoxStatus

        GroupBox1.Text = UCase(_s11District) + " " + "District"
        TextBoxDistrictCode.Text = _s0District
        TextBoxDistrictName.Text = _s1District
        TextBoxDimCode.Text = _s2District
        DateTimePickerStartDate.Text = _s6District
        DateTimePickerEndDate.Text = _s7District

        DateTimePickerCreateDate.Text = _s8District

        Me.CompanyNameList()
        ComboBoxCompanyName.SelectedIndex = 1
        Me.DivisionNameList(_s0District)
        'Me.DistrictStartDate()
        'Me.DistrictEndDate()

        If UCase(_s11District) = "ACTIVE" Then
            _cbStatus.SelectedIndex = 1
        ElseIf UCase(_s11District) = "INACTIVE" Then
            _cbStatus.SelectedIndex = 2
        Else
            _cbStatus.SelectedIndex = 0
        End If

        Me.DistrictCodeList()
        Me.DistrictNameList()
        Me.DimCodeList()

    End Sub

    Private Sub ButtonUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles ButtonUpdate.Click
        Dim _i As Integer
        Dim _sDistCode, _sDistName, _sDimCode As String

        _sDistCode = UCase(Trim(TextBoxDistrictCode.Text))
        _sDistName = UCase(Trim(TextBoxDistrictName.Text))
        _sDimCode = UCase(Trim(TextBoxDimCode.Text))

        _cbStatus = ComboBoxStatus
        _i = _cbStatus.SelectedIndex

        If TextBoxDistrictCode.Text = "" Or TextBoxDistrictName.Text = "" Or _i = 0 Then
            Return
        ElseIf _i = 1 Then
            If UCase(_s11District) = "ACTIVE" Then
                'If Trim(TextBoxDistrictCode.Text) = UCase(_s0District) Or _
                '    Trim(TextBoxDistrictName.Text) = UCase(_s1District) Or _
                '    Trim(TextBoxDimCode.Text) = UCase(_s2District) Then
                If Trim(TextBoxDistrictCode.Text) = "" Or _
                    Trim(TextBoxDistrictName.Text) = "" Or _
                    Trim(TextBoxDimCode.Text) = "" Then
                    Return
                Else
                    'Me.DistrictCodeValidate(_sDistCode, True)
                    'Me.DistrictNameValidate(_sDistName, True)
                    'Me.DimCodeValidate(_sDimCode, True)

                    'If _bConfirmedDC Or _bConfirmedDN Or _bConfirmedDim Or _
                    '    ComboBoxDivisionName.Text = "" Or _
                    'If ComboBoxStartDate.SelectedIndex = 0 Or ComboBoxEndDate.SelectedIndex = 0 Then
                    '    Return

                    'Else
                    If (MessageBox.Show("You're about to update the District Code [" + UCase(_s0District) + "] to [" + _sDistCode + "]" & vbNewLine & _
                        "and District Name [" + UCase(_s1District) + "] to [" + _sDistName + "]!." & vbNewLine & _
                        "Click Yes if you want to proceed.", "Updating", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, _
                        MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then

                        Me.DistrictUpdate()
                    Else
                        Return
                    End If
                    'End If
                End If
            Else
                If (MessageBox.Show("You're about to update the District Code [" + _s0District + "]" & vbNewLine & _
                    "and District Name [" + _s1District + "] to [" + _cbStatus.Text + "]!." & vbNewLine & _
                    "Click Yes if you want to proceed.", "Updating", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, _
                    MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then

                    Me.DistrictStatus()
                Else
                    Return
                End If
            End If
        ElseIf _i = 2 Then
            If UCase(_s11District) = "INACTIVE" Then
                Return
            Else
                If (MessageBox.Show("You're about to update the District Code [" + _s0District + "]" & vbNewLine & _
                    "and District Name [" + _s1District + "] to [" + _cbStatus.Text + "]!." & vbNewLine & _
                    "Click Yes if you want to proceed.", "Updating", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, _
                    MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then

                    Me.DistrictStatus()
                Else
                    Return
                End If
            End If
        End If
    End Sub

    Private Sub ComboBoxStatus_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles ComboBoxStatus.SelectedIndexChanged
        _cbStatus = ComboBoxStatus

        If _cbStatus.SelectedIndex = 1 Then
            If UCase(_s11District) = "INACTIVE" Then
                TextBoxDistrictCode.Text = _s0District
                TextBoxDistrictName.Text = _s1District
                TextBoxDimCode.Text = _s2District
                Me.DivisionNameList(_s0District)
                DateTimePickerStartDate.Text = _s6District
                DateTimePickerEndDate.Text = _s7District
                'ComboBoxStartDate.Enabled = False
                'ComboBoxEndDate.Enabled = False
                TextBoxDistrictCode.Enabled = False
                TextBoxDistrictName.Enabled = False
                TextBoxDimCode.Enabled = False
                DateTimePickerStartDate.Enabled = False
                DateTimePickerEndDate.Enabled = False
                ButtonClear.Enabled = False

            Else
                TextBoxDistrictCode.Enabled = True
                TextBoxDistrictName.Enabled = True
                TextBoxDimCode.Enabled = True
                DateTimePickerStartDate.Enabled = True
                DateTimePickerEndDate.Enabled = True
                'ComboBoxStartDate.Enabled = True
                'ComboBoxEndDate.Enabled = True
                ButtonClear.Enabled = True

            End If

        ElseIf _cbStatus.SelectedIndex = 2 Then
            TextBoxDistrictCode.Text = _s0District
            TextBoxDistrictName.Text = _s1District
            TextBoxDimCode.Text = _s2District
            Me.DivisionNameList(_s0District)
            DateTimePickerStartDate.Text = _s6District
            DateTimePickerEndDate.Text = _s7District
            'ComboBoxStartDate.Enabled = False
            'ComboBoxEndDate.Enabled = False
            TextBoxDistrictCode.Enabled = False
            TextBoxDistrictName.Enabled = False
            TextBoxDimCode.Enabled = False
            DateTimePickerStartDate.Enabled = False
            DateTimePickerEndDate.Enabled = False
            ButtonClear.Enabled = False

        Else
            Return

        End If
    End Sub

    Private Sub DistrictStatus()
        Me.Cursor = Cursors.WaitCursor

        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(5) As SqlParameter

        Try
            Dim _districtcode As New SqlParameter("@districtcode", SqlDbType.Char, 10)
            _districtcode.Direction = ParameterDirection.Input
            _districtcode.Value = Trim(TextBoxDistrictCode.Text)
            Params(0) = _districtcode

            Dim _districtname As New SqlParameter("@districtname", SqlDbType.VarChar, 50)
            _districtname.Direction = ParameterDirection.Input
            _districtname.Value = Trim(TextBoxDistrictName.Text)
            Params(1) = _districtname

            Dim _divisionname As New SqlParameter("@divisionname", SqlDbType.VarChar, 50)
            _divisionname.Direction = ParameterDirection.Input
            _divisionname.Value = ComboBoxDivisionName.Text
            Params(2) = _divisionname

            Dim _updatedate As New SqlParameter("@updatedate", SqlDbType.DateTime)
            _updatedate.Direction = ParameterDirection.Input
            _updatedate.Value = DateTimePickerUpdateDate.Value.ToString()
            Params(3) = _updatedate

            Dim _status As New SqlParameter("@status", SqlDbType.Char, 8)
            _status.Direction = ParameterDirection.Input
            _status.Value = LCase(Trim(ComboBoxStatus.Text))
            Params(4) = _status

            Dim _lastuser As New SqlParameter("@lastuser", SqlDbType.Char, 10)
            _lastuser.Direction = ParameterDirection.Input
            _lastuser.Value = UCase(Trim(gUserID))
            Params(5) = _lastuser

            Try
                BusinessObject.Sub_Insert(ServerPath, "sp_division_status", CommandType.StoredProcedure, Params)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.ObjectsEnabled()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub DistrictUpdate()
        Me.Cursor = Cursors.WaitCursor

        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(9) As SqlParameter

        Try
            Dim _districtcode As New SqlParameter("@districtcode", SqlDbType.Char, 10)
            _districtcode.Direction = ParameterDirection.Input
            _districtcode.Value = Trim(TextBoxDistrictCode.Text)
            Params(0) = _districtcode

            Dim _districtname As New SqlParameter("@districtname", SqlDbType.VarChar, 50)
            _districtname.Direction = ParameterDirection.Input
            _districtname.Value = Trim(TextBoxDistrictName.Text)
            Params(1) = _districtname

            Dim _dimcode As New SqlParameter("@dimcode", SqlDbType.VarChar, 10)
            _dimcode.Direction = ParameterDirection.Input
            _dimcode.Value = Trim(TextBoxDimCode.Text)
            Params(2) = _dimcode

            'Dim _divisionname As New SqlParameter("@divisionname", SqlDbType.VarChar, 50)
            '_divisionname.Direction = ParameterDirection.Input
            '_divisionname.Value = ComboBoxDivisionName.Text
            'Params(3) = _divisionname

            Dim _startdate As New SqlParameter("@startdate", SqlDbType.DateTime)
            _startdate.Direction = ParameterDirection.Input
            _startdate.Value = DateTimePickerStartDate.Value.ToString
            Params(3) = _startdate

            'Dim _startdate As New SqlParameter("@startdate", SqlDbType.DateTime)
            '_startdate.Direction = ParameterDirection.Input
            '_startdate.Value = Convert.ToDateTime(ComboBoxStartDate.Text)
            'Params(3) = _startdate

            Dim _enddate As New SqlParameter("@enddate", SqlDbType.DateTime)
            _enddate.Direction = ParameterDirection.Input
            _enddate.Value = DateTimePickerEndDate.Value.ToString
            Params(4) = _enddate

            'Dim _enddate As New SqlParameter("@enddate", SqlDbType.DateTime)
            '_enddate.Direction = ParameterDirection.Input
            '_enddate.Value = Convert.ToDateTime(ComboBoxEndDate.Text)
            'Params(4) = _enddate

            Dim _updatedate As New SqlParameter("@updatedate", SqlDbType.DateTime)
            _updatedate.Direction = ParameterDirection.Input
            _updatedate.Value = DateTimePickerUpdateDate.Value.ToString
            Params(5) = _updatedate

            Dim _status As New SqlParameter("@status", SqlDbType.Char, 8)
            _status.Direction = ParameterDirection.Input
            _status.Value = LCase(Trim(ComboBoxStatus.Text))
            Params(6) = _status

            Dim _lastuser As New SqlParameter("@lastuser", SqlDbType.Char, 10)
            _lastuser.Direction = ParameterDirection.Input
            _lastuser.Value = UCase(Trim(gUserID))
            Params(7) = _lastuser

            Dim _distcode As New SqlParameter("@distcode", SqlDbType.Char, 10)
            _distcode.Direction = ParameterDirection.Input
            _distcode.Value = UCase(_s0District)
            Params(8) = _distcode

            Dim _distname As New SqlParameter("@distname", SqlDbType.VarChar, 50)
            _distname.Direction = ParameterDirection.Input
            _distname.Value = UCase(_s1District)
            Params(9) = _distname

            Try
                BusinessObject.Sub_Update(ServerPath, "sp_district_update", CommandType.StoredProcedure, Params)
                Me.ClearEntry()
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.ObjectsEnabled()
        Me.Cursor = Cursors.Default

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

    Private Sub DistrictCodeValidate(ByVal _sValue As String, ByVal _b As Boolean)
        Dim _sDistrictCode As String
        Dim _i, _iCount As Integer

        _iCount = MyCodeTableDS.sp_district_code_list.Rows.Count

        If _iCount <> 0 Then
            For _i = 0 To _iCount - 1
                With DataGridDistrictCode
                    _sDistrictCode = .Item(_i, 0).ToString()

                    If _sValue = _sDistrictCode Then
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

    Private Sub DimCodeValidate(ByVal _sValue As String, ByVal _b As Boolean)
        Me.Cursor = Cursors.WaitCursor

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

    Private Sub DivisionNameList(ByVal _sValue As String)
        Me.Cursor = Cursors.WaitCursor

        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter
        Dim _DT As DataTable = New DataTable

        If MyCodeTableDS.sp_division_name_list.Count > 0 Then _
            MyCodeTableDS.sp_division_name_list.Clear()

        Try
            Dim _districtcode As New SqlParameter("@districtcode", SqlDbType.Char, 10)
            _districtcode.Direction = ParameterDirection.Input
            _districtcode.Value = _sValue
            Params(0) = _districtcode

            Try
                BusinessObject.Sub_Show(ServerPath, "sp_division_name_list", CommandType.StoredProcedure, _
                    MyCodeTableDS, "sp_division_name_list", Params)

                _DT = MyCodeTableDS.sp_division_name_list

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

    Private Sub ButtonClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles ButtonClear.Click
        Me.ClearEntry()
    End Sub

    Private Sub ClearEntry()
        TextBoxDistrictCode.Text = ""
        TextBoxDistrictName.Text = ""
        TextBoxDimCode.Text = ""
        DateTimePickerStartDate.Text = _s6District
        DateTimePickerEndDate.Text = _s7District
        DateTimePickerCreateDate.Text = _s8District
        DateTimePickerUpdateDate.Text = _s9District
        ComboBoxStatus.Text = UCase(_s11District)
    End Sub

    Private Sub ObjectsEnabled()
        TextBoxDistrictCode.Enabled = False
        TextBoxDistrictName.Enabled = False
        TextBoxDimCode.Enabled = False
        DateTimePickerStartDate.Enabled = False
        DateTimePickerEndDate.Enabled = False
        'ComboBoxStartDate.Enabled = False
        'ComboBoxEndDate.Enabled = False
        ComboBoxStatus.Enabled = False
        ButtonUpdate.Enabled = False
        ButtonClear.Enabled = False
    End Sub

    Private Sub DistrictStartDate()
        Me.Cursor = Cursors.WaitCursor

        Dim _DT As DataTable = New DataTable
        Dim _DR As DataRow

        Dim BusinessObject As New BusinessLayer.clsFileMaintenance

        If MyCodeTableDS.sp_district_start_date.Count > 0 Then _
            MyCodeTableDS.sp_district_start_date.Dispose()

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
End Class
