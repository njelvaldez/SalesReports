Imports System.Data.SqlClient

Public Class frmDistrictSupervisorUpdate
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
    Friend WithEvents TextBoxSupervisorCode As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSupervisorName As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePickerStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerUpdateDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBoxEncoder As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents ButtonUpdate As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxStatus As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridMaxEndDate As System.Windows.Forms.DataGrid
    Friend WithEvents Label8 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TextBoxSupervisorCode = New System.Windows.Forms.TextBox
        Me.TextBoxSupervisorName = New System.Windows.Forms.TextBox
        Me.DateTimePickerStartDate = New System.Windows.Forms.DateTimePicker
        Me.DateTimePickerEndDate = New System.Windows.Forms.DateTimePicker
        Me.DateTimePickerUpdateDate = New System.Windows.Forms.DateTimePicker
        Me.TextBoxEncoder = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataGridMaxEndDate = New System.Windows.Forms.DataGrid
        Me.Label7 = New System.Windows.Forms.Label
        Me.ComboBoxStatus = New System.Windows.Forms.ComboBox
        Me.ButtonClear = New System.Windows.Forms.Button
        Me.ButtonUpdate = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridMaxEndDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxSupervisorCode
        '
        Me.TextBoxSupervisorCode.Location = New System.Drawing.Point(128, 24)
        Me.TextBoxSupervisorCode.Name = "TextBoxSupervisorCode"
        Me.TextBoxSupervisorCode.ReadOnly = True
        Me.TextBoxSupervisorCode.TabIndex = 1
        Me.TextBoxSupervisorCode.Text = ""
        '
        'TextBoxSupervisorName
        '
        Me.TextBoxSupervisorName.Location = New System.Drawing.Point(128, 48)
        Me.TextBoxSupervisorName.Name = "TextBoxSupervisorName"
        Me.TextBoxSupervisorName.ReadOnly = True
        Me.TextBoxSupervisorName.Size = New System.Drawing.Size(192, 21)
        Me.TextBoxSupervisorName.TabIndex = 2
        Me.TextBoxSupervisorName.Text = ""
        '
        'DateTimePickerStartDate
        '
        Me.DateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePickerStartDate.Location = New System.Drawing.Point(128, 72)
        Me.DateTimePickerStartDate.MaxDate = New Date(2078, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerStartDate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerStartDate.Name = "DateTimePickerStartDate"
        Me.DateTimePickerStartDate.Size = New System.Drawing.Size(100, 21)
        Me.DateTimePickerStartDate.TabIndex = 3
        '
        'DateTimePickerEndDate
        '
        Me.DateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePickerEndDate.Location = New System.Drawing.Point(128, 96)
        Me.DateTimePickerEndDate.MaxDate = New Date(2078, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerEndDate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerEndDate.Name = "DateTimePickerEndDate"
        Me.DateTimePickerEndDate.Size = New System.Drawing.Size(100, 21)
        Me.DateTimePickerEndDate.TabIndex = 4
        '
        'DateTimePickerUpdateDate
        '
        Me.DateTimePickerUpdateDate.Enabled = False
        Me.DateTimePickerUpdateDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePickerUpdateDate.Location = New System.Drawing.Point(128, 120)
        Me.DateTimePickerUpdateDate.Name = "DateTimePickerUpdateDate"
        Me.DateTimePickerUpdateDate.Size = New System.Drawing.Size(100, 21)
        Me.DateTimePickerUpdateDate.TabIndex = 5
        '
        'TextBoxEncoder
        '
        Me.TextBoxEncoder.Location = New System.Drawing.Point(128, 144)
        Me.TextBoxEncoder.Name = "TextBoxEncoder"
        Me.TextBoxEncoder.ReadOnly = True
        Me.TextBoxEncoder.TabIndex = 6
        Me.TextBoxEncoder.Text = ""
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
        Me.Panel1.Size = New System.Drawing.Size(346, 256)
        Me.Panel1.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.DataGridMaxEndDate)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.ComboBoxStatus)
        Me.GroupBox1.Controls.Add(Me.ButtonClear)
        Me.GroupBox1.Controls.Add(Me.ButtonUpdate)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerStartDate)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerEndDate)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerUpdateDate)
        Me.GroupBox1.Controls.Add(Me.TextBoxEncoder)
        Me.GroupBox1.Controls.Add(Me.TextBoxSupervisorCode)
        Me.GroupBox1.Controls.Add(Me.TextBoxSupervisorName)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(5, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(336, 249)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'DataGridMaxEndDate
        '
        Me.DataGridMaxEndDate.DataMember = ""
        Me.DataGridMaxEndDate.Enabled = False
        Me.DataGridMaxEndDate.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridMaxEndDate.Location = New System.Drawing.Point(8, 232)
        Me.DataGridMaxEndDate.Name = "DataGridMaxEndDate"
        Me.DataGridMaxEndDate.Size = New System.Drawing.Size(32, 16)
        Me.DataGridMaxEndDate.TabIndex = 20
        Me.DataGridMaxEndDate.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(81, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 17)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Status"
        '
        'ComboBoxStatus
        '
        Me.ComboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxStatus.Items.AddRange(New Object() {"<- Please select status ->", "ACTIVE", "INACTIVE"})
        Me.ComboBoxStatus.Location = New System.Drawing.Point(128, 168)
        Me.ComboBoxStatus.Name = "ComboBoxStatus"
        Me.ComboBoxStatus.Size = New System.Drawing.Size(192, 21)
        Me.ComboBoxStatus.TabIndex = 7
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(208, 203)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.TabIndex = 9
        Me.ButtonClear.Text = "&Clear"
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(128, 203)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.TabIndex = 8
        Me.ButtonUpdate.Text = "&Update"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(71, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 17)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Encoder"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Update Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "End Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Start Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Team Manager Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 17)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Team Manager Code"
        '
        'frmDistrictSupervisorUpdate
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(346, 256)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmDistrictSupervisorUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "District Team Manager Update"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridMaxEndDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private MyCodeTableDS As New CodeTablesDS

    Private Sub frmDistrictSupervisorUpdate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles MyBase.Load
        'Me.MaxEndDateList()
        TextBoxSupervisorCode.Text = _s0District
        TextBoxSupervisorName.Text = _s1District
        DateTimePickerStartDate.Text = _s2District
        DateTimePickerEndDate.Text = _s3District
        TextBoxEncoder.Text = UCase(Trim(gUserID))

        If UCase(_s7District) = "ACTIVE" Then
            ComboBoxStatus.SelectedIndex = 1
        ElseIf UCase(_s7District) = "INACTIVE" Then
            ComboBoxStatus.SelectedIndex = 2
        Else
            ComboBoxStatus.SelectedIndex = 0
        End If
    End Sub

    Private Sub ButtonUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles ButtonUpdate.Click
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(5) As SqlParameter

        If ComboBoxStatus.SelectedIndex = 0 Then
            Return
        Else
            'Me.MaxEndDateValidate(DateTimePickerEndDate.Text, True)
            Me.StartDateValidate(DateTimePickerStartDate.Value, True)

            If _bConfirmedSD Then
                Return
            Else
                If (MessageBox.Show("You're about to update this entry! Click Yes if you want to proceed.", "Updating", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, _
                    MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then

                    Try
                        Dim _districtcode As New SqlParameter("@districtcode", SqlDbType.Char, 10)
                        _districtcode.Direction = ParameterDirection.Input
                        _districtcode.Value = Trim(_gDistrictCode)
                        Params(0) = _districtcode

                        Dim _supervisorcode As New SqlParameter("@supervisorcode", SqlDbType.Char, 10)
                        _supervisorcode.Direction = ParameterDirection.Input
                        _supervisorcode.Value = Trim(TextBoxSupervisorCode.Text)
                        Params(1) = _supervisorcode

                        Dim _enddate As New SqlParameter("@enddate", SqlDbType.DateTime)
                        _enddate.Direction = ParameterDirection.Input
                        _enddate.Value = DateTimePickerEndDate.Value.ToString()
                        Params(2) = _enddate

                        Dim _updatedate As New SqlParameter("@updatedate", SqlDbType.DateTime)
                        _updatedate.Direction = ParameterDirection.Input
                        _updatedate.Value = DateTimePickerUpdateDate.Value.ToString()
                        Params(3) = _updatedate

                        Dim _encoder As New SqlParameter("@lastuser", SqlDbType.Char, 10)
                        _encoder.Direction = ParameterDirection.Input
                        _encoder.Value = Trim(gUserID)
                        Params(4) = _encoder

                        Dim _status As New SqlParameter("@status", SqlDbType.Char, 10)
                        _status.Direction = ParameterDirection.Input
                        _status.Value = ComboBoxStatus.Text
                        Params(5) = _status

                        Try
                            BusinessObject.Sub_Update(ServerPath, "sp_district_supervisor_update", CommandType.StoredProcedure, Params)
                            Me.Close()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    Me.ObjectsEnabled()
                Else
                    Return
                End If
            End If
        End If
    End Sub

    Private Sub MaxEndDateList()
        Me.Cursor = Cursors.WaitCursor
        Dim Params(0) As SqlParameter

        Dim BusinessObject As New BusinessLayer.clsFileMaintenance

        Try
            Dim _districtcode As New SqlParameter("@districtcode", SqlDbType.Char, 10)
            _districtcode.Direction = ParameterDirection.Input
            _districtcode.Value = _gDistrictCode
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
        Dim _sMaxEndDate As String
        Dim _i, _iCount As Integer

        _iCount = MyCodeTableDS.sp_get_max_end_date.Rows.Count

        If _iCount <> 0 Then
            For _i = 0 To _iCount - 1
                With DataGridMaxEndDate
                    _sMaxEndDate = .Item(_i, 0).ToString()
                    _sMaxEndDate = Format(CDate(_sMaxEndDate), "d")

                    If CDate(_sValue) <= CDate(_sMaxEndDate) Then
                        MessageBox.Show("The created end date should not be less than" & vbNewLine & _
                            "or equal to start date [" + Format(CDate(_sValue)) + "].", _
                            "Invalid Max End Date", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        _bConfirmedMED = True
                        Exit For
                    Else
                        _bConfirmedMED = False
                    End If
                End With
            Next _i
        End If
    End Sub

    Private Sub ObjectsEnabled()
        DateTimePickerStartDate.Enabled = False
        DateTimePickerEndDate.Enabled = False
        ComboBoxStatus.Enabled = False
        ButtonUpdate.Enabled = False
        ButtonClear.Enabled = False
    End Sub

    Private Sub ComboBoxStatus_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles ComboBoxStatus.SelectedIndexChanged

        If ComboBoxStatus.SelectedIndex = 1 Then
            If UCase(_s7District) = "ACTIVE" Then
                DateTimePickerStartDate.Enabled = True
                DateTimePickerEndDate.Enabled = True
            End If
        ElseIf ComboBoxStatus.SelectedIndex = 2 Then
            DateTimePickerStartDate.Enabled = False
            DateTimePickerEndDate.Enabled = False
        Else
            Return
        End If

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
End Class
