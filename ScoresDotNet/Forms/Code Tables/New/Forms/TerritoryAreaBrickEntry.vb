Imports System.Data.SqlClient

Public Class TerritoryAreaBrickEntry
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxAreaCode As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxPrincipalCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxTerritoryDR As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerCreateDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBoxEncoder As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents DataGridAreaBrickStartDate As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataGridAreaBrickStartDate = New System.Windows.Forms.DataGrid
        Me.ButtonClear = New System.Windows.Forms.Button
        Me.ButtonSave = New System.Windows.Forms.Button
        Me.TextBoxEncoder = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.DateTimePickerCreateDate = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.DateTimePickerEndDate = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.DateTimePickerStartDate = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.ComboBoxTerritoryDR = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ComboBoxPrincipalCode = New System.Windows.Forms.ComboBox
        Me.TextBoxAreaCode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridAreaBrickStartDate, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(330, 255)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridAreaBrickStartDate)
        Me.GroupBox1.Controls.Add(Me.ButtonClear)
        Me.GroupBox1.Controls.Add(Me.ButtonSave)
        Me.GroupBox1.Controls.Add(Me.TextBoxEncoder)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerCreateDate)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerEndDate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerStartDate)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboBoxTerritoryDR)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ComboBoxPrincipalCode)
        Me.GroupBox1.Controls.Add(Me.TextBoxAreaCode)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(5, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 248)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'DataGridAreaBrickStartDate
        '
        Me.DataGridAreaBrickStartDate.DataMember = ""
        Me.DataGridAreaBrickStartDate.Enabled = False
        Me.DataGridAreaBrickStartDate.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridAreaBrickStartDate.Location = New System.Drawing.Point(24, 208)
        Me.DataGridAreaBrickStartDate.Name = "DataGridAreaBrickStartDate"
        Me.DataGridAreaBrickStartDate.Size = New System.Drawing.Size(32, 16)
        Me.DataGridAreaBrickStartDate.TabIndex = 13
        Me.DataGridAreaBrickStartDate.Visible = False
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(184, 208)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.TabIndex = 9
        Me.ButtonClear.Text = "&Clear"
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(104, 208)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.TabIndex = 8
        Me.ButtonSave.Text = "&Save"
        '
        'TextBoxEncoder
        '
        Me.TextBoxEncoder.Enabled = False
        Me.TextBoxEncoder.Location = New System.Drawing.Point(104, 168)
        Me.TextBoxEncoder.Name = "TextBoxEncoder"
        Me.TextBoxEncoder.TabIndex = 7
        Me.TextBoxEncoder.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(51, 170)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Encoder"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Create Date"
        '
        'DateTimePickerCreateDate
        '
        Me.DateTimePickerCreateDate.Enabled = False
        Me.DateTimePickerCreateDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePickerCreateDate.Location = New System.Drawing.Point(104, 144)
        Me.DateTimePickerCreateDate.MaxDate = New Date(2078, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerCreateDate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerCreateDate.Name = "DateTimePickerCreateDate"
        Me.DateTimePickerCreateDate.Size = New System.Drawing.Size(120, 21)
        Me.DateTimePickerCreateDate.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "End Date"
        '
        'DateTimePickerEndDate
        '
        Me.DateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePickerEndDate.Location = New System.Drawing.Point(104, 120)
        Me.DateTimePickerEndDate.MaxDate = New Date(2078, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerEndDate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerEndDate.Name = "DateTimePickerEndDate"
        Me.DateTimePickerEndDate.Size = New System.Drawing.Size(120, 21)
        Me.DateTimePickerEndDate.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Start Date"
        '
        'DateTimePickerStartDate
        '
        Me.DateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePickerStartDate.Location = New System.Drawing.Point(104, 96)
        Me.DateTimePickerStartDate.MaxDate = New Date(2078, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerStartDate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerStartDate.Name = "DateTimePickerStartDate"
        Me.DateTimePickerStartDate.Size = New System.Drawing.Size(120, 21)
        Me.DateTimePickerStartDate.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Brick Name"
        '
        'ComboBoxTerritoryDR
        '
        Me.ComboBoxTerritoryDR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTerritoryDR.Location = New System.Drawing.Point(104, 72)
        Me.ComboBoxTerritoryDR.MaxDropDownItems = 15
        Me.ComboBoxTerritoryDR.Name = "ComboBoxTerritoryDR"
        Me.ComboBoxTerritoryDR.Size = New System.Drawing.Size(208, 21)
        Me.ComboBoxTerritoryDR.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Principal Name"
        '
        'ComboBoxPrincipalCode
        '
        Me.ComboBoxPrincipalCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPrincipalCode.Location = New System.Drawing.Point(104, 48)
        Me.ComboBoxPrincipalCode.MaxDropDownItems = 15
        Me.ComboBoxPrincipalCode.Name = "ComboBoxPrincipalCode"
        Me.ComboBoxPrincipalCode.Size = New System.Drawing.Size(208, 21)
        Me.ComboBoxPrincipalCode.TabIndex = 2
        '
        'TextBoxAreaCode
        '
        Me.TextBoxAreaCode.Enabled = False
        Me.TextBoxAreaCode.Location = New System.Drawing.Point(104, 24)
        Me.TextBoxAreaCode.MaxLength = 10
        Me.TextBoxAreaCode.Name = "TextBoxAreaCode"
        Me.TextBoxAreaCode.TabIndex = 1
        Me.TextBoxAreaCode.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Area Code"
        '
        'TerritoryAreaBrickEntry
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(330, 255)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "TerritoryAreaBrickEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Territory Area Brick Entry"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridAreaBrickStartDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private MyCodeTableDS As New CodeTablesDS
    Private BusinessObject As New BusinessLayer.clsFileMaintenance
    'Private xTerritoryAreaMaint As New frmTerritoryAreaMaint

    Private Sub TerritoryAreaBrickEntry_Load(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles MyBase.Load
        TextBoxAreaCode.Text = _s0TerritoryArea
        Me.PrincipalSelections()
        Me.TerritorySelections()
        Me.FromStartDate(DateTimePickerStartDate.Value)
        Me.ToEndDate(DateTimePickerEndDate.Value)
        TextBoxEncoder.Text = UCase(Trim(gUserID))
    End Sub

    Private Sub PrincipalSelections()
        Me.Cursor = Cursors.WaitCursor
        Dim _DT As DataTable = New DataTable
        Dim _DR As DataRow

        If MyCodeTableDS.sp_principal_selections.Count > 0 Then MyCodeTableDS.sp_principal_selections.Clear()

        Try
            BusinessObject.Sub_Show(ServerPath, "sp_principal_selections", CommandType.StoredProcedure, _
                MyCodeTableDS, "sp_principal_selections")

            _DT = MyCodeTableDS.sp_principal_selections
            _DR = _DT.NewRow()

            _DR(1) = "<- Select Principal Name ->"
            _DT.Rows.InsertAt(_DR, 0)

            With ComboBoxPrincipalCode
                .DataSource = _DT
                .DisplayMember = "Principal Name"
                .ValueMember = "Principal Code"
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub TerritorySelections()
        Me.Cursor = Cursors.WaitCursor
        Dim _DT As DataTable = New DataTable
        Dim _DR As DataRow

        If MyCodeTableDS.sp_territory_selections.Count > 0 Then MyCodeTableDS.sp_territory_selections.Clear()

        Try
            BusinessObject.Sub_Show(ServerPath, "sp_territory_selections", CommandType.StoredProcedure, _
                MyCodeTableDS, "sp_territory_selections")

            _DT = MyCodeTableDS.sp_territory_selections
            _DR = _DT.NewRow()

            _DR(1) = "<- Select Brick Name ->"
            _DT.Rows.InsertAt(_DR, 0)

            With ComboBoxTerritoryDR
                .DataSource = _DT
                .DisplayMember = "Territory Name"
                .ValueMember = "TerritoryDR"
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
        Dim Params(1) As SqlParameter

        Try
            Dim _areacode As New SqlParameter("@areacode", SqlDbType.Char, 10)
            _areacode.Direction = ParameterDirection.Input
            _areacode.Value = Trim(TextBoxAreaCode.Text)
            Params(0) = _areacode

            Dim _princode As New SqlParameter("@princode", SqlDbType.Char, 5)
            _princode.Direction = ParameterDirection.Input
            _princode.Value = Trim(ComboBoxPrincipalCode.SelectedValue.ToString())
            Params(1) = _princode

            If MyCodeTableDS.sp_area_brick_start_date.Count > 0 Then MyCodeTableDS.sp_area_brick_start_date.Clear()

            Try
                BusinessObject.Sub_Show(ServerPath, "sp_area_brick_start_date", CommandType.StoredProcedure, _
                    MyCodeTableDS, "sp_area_brick_start_date", Params)

                DataGridAreaBrickStartDate.DataSource = MyCodeTableDS.sp_area_brick_start_date
                Dim _iCount As Integer = MyCodeTableDS.sp_area_brick_start_date.Rows.Count

                If _iCount > 0 Then
                    For _i As Integer = 0 To _iCount - 1
                        With DataGridAreaBrickStartDate
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
        ComboBoxPrincipalCode.SelectedIndex = 0
        ComboBoxTerritoryDR.SelectedIndex = 0
        Me.FromStartDate(Date.Today())
        Me.ToEndDate(Date.Today())
    End Sub

    Private Sub ButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles ButtonSave.Click
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(7) As SqlParameter

        If ComboBoxPrincipalCode.SelectedIndex = 0 Or _
            ComboBoxTerritoryDR.SelectedIndex = 0 Then
            Return
        Else
            Me.StartDateValidate(DateTimePickerStartDate.Value, True)
            Me.StartDateDuplicate(DateTimePickerStartDate.Value, True)

            If _bConfirmedSD Or _bConfirmedSDDuplicated Then
                Return
            Else
                If (MessageBox.Show("You're about to save this entry! Click Yes if you want to proceed.", "Saving", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, _
                    MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then

                    Try
                        Dim _areacode As New SqlParameter("@areacode", SqlDbType.Char, 10)
                        _areacode.Direction = ParameterDirection.Input
                        _areacode.Value = Trim(TextBoxAreaCode.Text)
                        Params(0) = _areacode

                        Dim _princode As New SqlParameter("@princode", SqlDbType.Char, 5)
                        _princode.Direction = ParameterDirection.Input
                        _princode.Value = Trim(ComboBoxPrincipalCode.SelectedValue.ToString())
                        Params(1) = _princode

                        Dim _territorydr As New SqlParameter("@territorydr", SqlDbType.VarChar, 18)
                        _territorydr.Direction = ParameterDirection.Input
                        _territorydr.Value = Trim(ComboBoxTerritoryDR.SelectedValue.ToString())
                        Params(2) = _territorydr

                        Dim _startdate As New SqlParameter("@startdate", SqlDbType.DateTime)
                        _startdate.Direction = ParameterDirection.Input
                        _startdate.Value = DateTimePickerStartDate.Value.ToString()
                        Params(3) = _startdate

                        Dim _endate As New SqlParameter("@endate", SqlDbType.DateTime)
                        _endate.Direction = ParameterDirection.Input
                        _endate.Value = DateTimePickerEndDate.Value.ToString()
                        Params(4) = _endate

                        Dim _createdate As New SqlParameter("@createdate", SqlDbType.DateTime)
                        _createdate.Direction = ParameterDirection.Input
                        _createdate.Value = DateTimePickerCreateDate.Value.ToString()
                        Params(5) = _createdate

                        Dim _encoder As New SqlParameter("@lastuser", SqlDbType.Char, 10)
                        _encoder.Direction = ParameterDirection.Input
                        _encoder.Value = Trim(TextBoxEncoder.Text)
                        Params(6) = _encoder

                        Dim _areastartdate As New SqlParameter("@areastartdate", SqlDbType.DateTime)
                        _areastartdate.Direction = ParameterDirection.Input
                        _areastartdate.Value = Format(CDate(_s7TerritoryArea), "d")
                        Params(7) = _areastartdate

                        Try
                            BusinessObject.Sub_Insert(ServerPath, "sp_area_brick_insert", CommandType.StoredProcedure, Params)
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

    Private Sub ButtonClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles ButtonClear.Click
        Me.ClearEntry()
    End Sub

End Class
