Imports System.Data.SqlClient

Public Class frmDistrict
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
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonEdit As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePickerCreateDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridDistrictList As System.Windows.Forms.DataGrid
    Friend WithEvents TextBoxDistrictName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDistrictCode As System.Windows.Forms.TextBox
    Friend WithEvents LabelDivisionName As System.Windows.Forms.Label
    Friend WithEvents ComboBoxDivisionName As System.Windows.Forms.ComboBox
    Friend WithEvents LabelDistrictCode As System.Windows.Forms.Label
    Friend WithEvents LabelCreateDate As System.Windows.Forms.Label
    Friend WithEvents LabelDistrictName As System.Windows.Forms.Label
    Friend WithEvents LabelStatus As System.Windows.Forms.Label
    Friend WithEvents ComboBoxStatus As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridDistrictCode As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridDistrictName As System.Windows.Forms.DataGrid
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataGridDistrictName = New System.Windows.Forms.DataGrid
        Me.DataGridDistrictList = New System.Windows.Forms.DataGrid
        Me.ButtonEdit = New System.Windows.Forms.Button
        Me.DataGridDistrictCode = New System.Windows.Forms.DataGrid
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.ButtonAdd = New System.Windows.Forms.Button
        Me.ButtonSave = New System.Windows.Forms.Button
        Me.DateTimePickerCreateDate = New System.Windows.Forms.DateTimePicker
        Me.TextBoxDistrictName = New System.Windows.Forms.TextBox
        Me.TextBoxDistrictCode = New System.Windows.Forms.TextBox
        Me.LabelDistrictCode = New System.Windows.Forms.Label
        Me.LabelCreateDate = New System.Windows.Forms.Label
        Me.LabelDistrictName = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ComboBoxStatus = New System.Windows.Forms.ComboBox
        Me.ComboBoxDivisionName = New System.Windows.Forms.ComboBox
        Me.LabelStatus = New System.Windows.Forms.Label
        Me.LabelDivisionName = New System.Windows.Forms.Label
        Me.ButtonClear = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridDistrictName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridDistrictList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridDistrictCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.DockPadding.All = 5
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(346, 504)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.DockPadding.Bottom = 5
        Me.Panel2.DockPadding.Left = 5
        Me.Panel2.DockPadding.Right = 5
        Me.Panel2.DockPadding.Top = 10
        Me.Panel2.Location = New System.Drawing.Point(5, 192)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(336, 307)
        Me.Panel2.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridDistrictName)
        Me.GroupBox1.Controls.Add(Me.DataGridDistrictList)
        Me.GroupBox1.Controls.Add(Me.ButtonEdit)
        Me.GroupBox1.Controls.Add(Me.DataGridDistrictCode)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(5, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(326, 292)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "District List"
        '
        'DataGridDistrictName
        '
        Me.DataGridDistrictName.DataMember = ""
        Me.DataGridDistrictName.Enabled = False
        Me.DataGridDistrictName.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridDistrictName.Location = New System.Drawing.Point(176, 256)
        Me.DataGridDistrictName.Name = "DataGridDistrictName"
        Me.DataGridDistrictName.Size = New System.Drawing.Size(48, 24)
        Me.DataGridDistrictName.TabIndex = 15
        Me.DataGridDistrictName.Visible = False
        '
        'DataGridDistrictList
        '
        Me.DataGridDistrictList.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridDistrictList.BackColor = System.Drawing.Color.White
        Me.DataGridDistrictList.CaptionBackColor = System.Drawing.Color.Maroon
        Me.DataGridDistrictList.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DataGridDistrictList.CaptionForeColor = System.Drawing.Color.White
        Me.DataGridDistrictList.CaptionVisible = False
        Me.DataGridDistrictList.DataMember = ""
        Me.DataGridDistrictList.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridDistrictList.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DataGridDistrictList.ForeColor = System.Drawing.Color.Black
        Me.DataGridDistrictList.GridLineColor = System.Drawing.Color.Silver
        Me.DataGridDistrictList.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DataGridDistrictList.HeaderForeColor = System.Drawing.Color.Black
        Me.DataGridDistrictList.LinkColor = System.Drawing.Color.Maroon
        Me.DataGridDistrictList.Location = New System.Drawing.Point(3, 17)
        Me.DataGridDistrictList.Name = "DataGridDistrictList"
        Me.DataGridDistrictList.ParentRowsBackColor = System.Drawing.Color.Silver
        Me.DataGridDistrictList.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DataGridDistrictList.ParentRowsVisible = False
        Me.DataGridDistrictList.PreferredColumnWidth = 100
        Me.DataGridDistrictList.ReadOnly = True
        Me.DataGridDistrictList.RowHeadersVisible = False
        Me.DataGridDistrictList.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.DataGridDistrictList.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridDistrictList.Size = New System.Drawing.Size(320, 231)
        Me.DataGridDistrictList.TabIndex = 0
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Location = New System.Drawing.Point(16, 256)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.TabIndex = 7
        Me.ButtonEdit.Text = "&Edit"
        '
        'DataGridDistrictCode
        '
        Me.DataGridDistrictCode.DataMember = ""
        Me.DataGridDistrictCode.Enabled = False
        Me.DataGridDistrictCode.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridDistrictCode.Location = New System.Drawing.Point(120, 256)
        Me.DataGridDistrictCode.Name = "DataGridDistrictCode"
        Me.DataGridDistrictCode.Size = New System.Drawing.Size(48, 24)
        Me.DataGridDistrictCode.TabIndex = 14
        Me.DataGridDistrictCode.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ButtonAdd)
        Me.Panel3.Controls.Add(Me.ButtonSave)
        Me.Panel3.Controls.Add(Me.DateTimePickerCreateDate)
        Me.Panel3.Controls.Add(Me.TextBoxDistrictName)
        Me.Panel3.Controls.Add(Me.TextBoxDistrictCode)
        Me.Panel3.Controls.Add(Me.LabelDistrictCode)
        Me.Panel3.Controls.Add(Me.LabelCreateDate)
        Me.Panel3.Controls.Add(Me.LabelDistrictName)
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.DockPadding.All = 5
        Me.Panel3.Location = New System.Drawing.Point(5, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(336, 187)
        Me.Panel3.TabIndex = 0
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(104, 144)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(56, 23)
        Me.ButtonAdd.TabIndex = 5
        Me.ButtonAdd.Text = "&Add"
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(167, 144)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(56, 23)
        Me.ButtonSave.TabIndex = 6
        Me.ButtonSave.Text = "&Save"
        '
        'DateTimePickerCreateDate
        '
        Me.DateTimePickerCreateDate.Enabled = False
        Me.DateTimePickerCreateDate.Location = New System.Drawing.Point(103, 89)
        Me.DateTimePickerCreateDate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerCreateDate.Name = "DateTimePickerCreateDate"
        Me.DateTimePickerCreateDate.Size = New System.Drawing.Size(214, 21)
        Me.DateTimePickerCreateDate.TabIndex = 4
        '
        'TextBoxDistrictName
        '
        Me.TextBoxDistrictName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxDistrictName.Enabled = False
        Me.TextBoxDistrictName.Location = New System.Drawing.Point(104, 43)
        Me.TextBoxDistrictName.MaxLength = 50
        Me.TextBoxDistrictName.Name = "TextBoxDistrictName"
        Me.TextBoxDistrictName.Size = New System.Drawing.Size(214, 21)
        Me.TextBoxDistrictName.TabIndex = 2
        Me.TextBoxDistrictName.Text = ""
        '
        'TextBoxDistrictCode
        '
        Me.TextBoxDistrictCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxDistrictCode.Enabled = False
        Me.TextBoxDistrictCode.Location = New System.Drawing.Point(104, 20)
        Me.TextBoxDistrictCode.MaxLength = 10
        Me.TextBoxDistrictCode.Name = "TextBoxDistrictCode"
        Me.TextBoxDistrictCode.Size = New System.Drawing.Size(96, 21)
        Me.TextBoxDistrictCode.TabIndex = 1
        Me.TextBoxDistrictCode.Text = ""
        '
        'LabelDistrictCode
        '
        Me.LabelDistrictCode.Location = New System.Drawing.Point(28, 24)
        Me.LabelDistrictCode.Name = "LabelDistrictCode"
        Me.LabelDistrictCode.Size = New System.Drawing.Size(80, 16)
        Me.LabelDistrictCode.TabIndex = 1
        Me.LabelDistrictCode.Text = "District Code"
        '
        'LabelCreateDate
        '
        Me.LabelCreateDate.Location = New System.Drawing.Point(32, 96)
        Me.LabelCreateDate.Name = "LabelCreateDate"
        Me.LabelCreateDate.Size = New System.Drawing.Size(64, 16)
        Me.LabelCreateDate.TabIndex = 4
        Me.LabelCreateDate.Text = "Create Date"
        '
        'LabelDistrictName
        '
        Me.LabelDistrictName.Location = New System.Drawing.Point(24, 45)
        Me.LabelDistrictName.Name = "LabelDistrictName"
        Me.LabelDistrictName.Size = New System.Drawing.Size(80, 18)
        Me.LabelDistrictName.TabIndex = 3
        Me.LabelDistrictName.Text = "District Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBoxStatus)
        Me.GroupBox2.Controls.Add(Me.ComboBoxDivisionName)
        Me.GroupBox2.Controls.Add(Me.LabelStatus)
        Me.GroupBox2.Controls.Add(Me.LabelDivisionName)
        Me.GroupBox2.Controls.Add(Me.ButtonClear)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(5, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(326, 177)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'ComboBoxStatus
        '
        Me.ComboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxStatus.Items.AddRange(New Object() {"<- Please select status ->", "ACTIVE", "INACTIVE"})
        Me.ComboBoxStatus.Location = New System.Drawing.Point(98, 107)
        Me.ComboBoxStatus.Name = "ComboBoxStatus"
        Me.ComboBoxStatus.Size = New System.Drawing.Size(214, 21)
        Me.ComboBoxStatus.TabIndex = 5
        '
        'ComboBoxDivisionName
        '
        Me.ComboBoxDivisionName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDivisionName.Enabled = False
        Me.ComboBoxDivisionName.Location = New System.Drawing.Point(98, 61)
        Me.ComboBoxDivisionName.MaxDropDownItems = 15
        Me.ComboBoxDivisionName.Name = "ComboBoxDivisionName"
        Me.ComboBoxDivisionName.Size = New System.Drawing.Size(214, 21)
        Me.ComboBoxDivisionName.TabIndex = 3
        '
        'LabelStatus
        '
        Me.LabelStatus.Location = New System.Drawing.Point(56, 110)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(40, 16)
        Me.LabelStatus.TabIndex = 13
        Me.LabelStatus.Text = "Status"
        '
        'LabelDivisionName
        '
        Me.LabelDivisionName.Location = New System.Drawing.Point(16, 64)
        Me.LabelDivisionName.Name = "LabelDivisionName"
        Me.LabelDivisionName.Size = New System.Drawing.Size(80, 23)
        Me.LabelDivisionName.TabIndex = 11
        Me.LabelDivisionName.Text = "Segment Name"
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(224, 139)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(56, 23)
        Me.ButtonClear.TabIndex = 7
        Me.ButtonClear.Text = "&Clear"
        '
        'frmDistrict
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(346, 504)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDistrict"
        Me.Text = "District"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridDistrictName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridDistrictList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridDistrictCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private _sDistrictCode As String
    Private _sDistrictName As String
    Private _sDivisionName As String
    Private _sCreateDate As String
    Private _sqlConn As New SqlConnection
    Private _sqlCmd As New SqlCommand
    Private MyCodeTableDS As New CodeTablesDS
    Private _cm1, _cm2 As CurrencyManager
    Private _dgDistrictList As DataGrid
    Private _cbDivisionName, _cbStatus As ComboBox

    Private Sub frmDistrict_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _cbStatus = ComboBoxStatus
        '_cbStatus.SelectedIndex = 0

        Me.DistrictList()

        Try
            With _sqlConn
                .ConnectionString = ServerPath
                .Open()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Try
        '    With _sqlCmd
        '        .CommandText = "sp_division_name"
        '        .CommandType = CommandType.StoredProcedure
        '        .Connection = _sqlConn
        '        .ExecuteNonQuery()
        '    End With
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

        Dim _sSQL As String = "SELECT DISTINCT divname FROM division ORDER BY divname ASC"
        Dim _sqlDA As New SqlDataAdapter(_sSQL, _sqlConn)
        Dim _DS As New DataSet
        Dim _DT As New DataTable
        Dim _DR As DataRow

        _DR = _DT.NewRow()

        _sqlDA.Fill(_DS, "Division")

        With ComboBoxDivisionName
            .DataSource = _DS.Tables("Division")
            .DisplayMember = "divname"
            .SelectedIndex = 0
        End With

        _sqlConn.Dispose()

        Me.DistrictCodeList()
        Me.DistrictNameList()

    End Sub

    Private Sub DataGridDistrictList_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
        Handles DataGridDistrictList.MouseUp
        Dim _i, _iRow As Integer
        Dim _dg As DataGrid = DirectCast(sender, DataGrid)
        Dim _ht As DataGrid.HitTestInfo

        _dgDistrictList = DataGridDistrictList
        _iRow = _dgDistrictList.CurrentRowIndex

        _ht = _dg.HitTest(e.X, e.Y)
        _i = _ht.Row

        If (e.Button = MouseButtons.Right) Then
            Return
        Else
            If _i = -1 Then
                Return
            Else
                _dg.Select(_ht.Row)
            End If
        End If

    End Sub

    Private Sub ButtonAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click
        _cbDivisionName = ComboBoxDivisionName
        _cbStatus = ComboBoxStatus

        TextBoxDistrictCode.Enabled = True
        TextBoxDistrictName.Enabled = True
        _cbDivisionName.Enabled = True
        _cbStatus.Enabled = False

        Me.RemoveSelectedRow()

    End Sub

    Private Sub ButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSave.Click
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(4) As SqlParameter

        _sDistrictCode = TextBoxDistrictCode.Text
        _sDistrictName = TextBoxDistrictName.Text
        _sDivisionName = ComboBoxDivisionName.Text
        _sCreateDate = DateTimePickerCreateDate.Text
        _cbDivisionName = ComboBoxDivisionName

        Me.RemoveSelectedRow()

        If _sDistrictCode = "" Or _sDistrictName = "" Then
            Return
        Else

            Me.DistrictCodeValidate(UCase(Trim(_sDistrictCode)), True)
            Me.DistrictNameValidate(UCase(Trim(_sDistrictName)), True)

            If _bConfirmedDC Or _bConfirmedDN Then
                Return

            Else
                If (MessageBox.Show("You're about to save this entry! Click Yes if you want to proceed.", "Saving", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then

                    Try
                        Dim _districtcode As New SqlParameter("@districtcode", SqlDbType.Char, 10)
                        _districtcode.Direction = ParameterDirection.Input
                        _districtcode.Value = Trim(_sDistrictCode)
                        Params(0) = _districtcode

                        Dim _districtname As New SqlParameter("@districtname", SqlDbType.VarChar, 50)
                        _districtname.Direction = ParameterDirection.Input
                        _districtname.Value = Trim(_sDistrictName)
                        Params(1) = _districtname

                        Dim _divisionname As New SqlParameter("@divisionname", SqlDbType.VarChar, 50)
                        _divisionname.Direction = ParameterDirection.Input
                        _divisionname.Value = Trim(_sDivisionName)
                        Params(2) = _divisionname

                        Dim _createdate As New SqlParameter("@createdate", SqlDbType.DateTime)
                        _createdate.Direction = ParameterDirection.Input
                        _createdate.Value = _sCreateDate.ToString()
                        Params(3) = _createdate

                        Dim _encoder As New SqlParameter("@lastuser", SqlDbType.Char, 10)
                        _encoder.Direction = ParameterDirection.Input
                        _encoder.Value = Trim(gUserID)
                        Params(4) = _encoder

                        Try
                            BusinessObject.Sub_Insert(ServerPath, "sp_insert_district", CommandType.StoredProcedure, Params)
                            Me.DistrictList()
                            Me.ClearEntry()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try

                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                Else
                    Me.ClearEntry()

                End If

            End If

        End If

    End Sub

    Private Sub ComboBoxCompanyName_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Frm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        EnDisMainMenu(Me, False)
    End Sub

    Private Sub Frm_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        EnDisMainMenu(Me, True)
    End Sub

    Private Sub ButtonEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonEdit.Click
        Dim _iRow, _i As Integer
        Dim _s0, _s1, _s2, _s3, _s4 As String
        Dim _frmPopup As New frmDistrictUpdate

        _dgDistrictList = DataGridDistrictList
        _iRow = _dgDistrictList.CurrentRowIndex

        If _iRow = -1 Then
            Return

        Else
            If _dgDistrictList.IsSelected(_iRow) Then
                With _dgDistrictList
                    _s0District = Trim(.Item(.CurrentCell.RowNumber, 0).ToString)
                    _s1District = Trim(.Item(.CurrentCell.RowNumber, 1).ToString)
                    _s2District = Trim(.Item(.CurrentCell.RowNumber, 2).ToString)
                    _s3District = Trim(.Item(.CurrentCell.RowNumber, 3).ToString)
                    _s4District = Trim(.Item(.CurrentCell.RowNumber, 4).ToString)
                    _s5District = Trim(.Item(.CurrentCell.RowNumber, 5).ToString)
                End With

                _frmPopup.ShowDialog(Me)

            End If
            'MsgBox(_dgDistrictList.CurrentRowIndex.ToString())
            '_cm1 = CType(Me.BindingContext(_dgDistrictList.DataSource), CurrencyManager)
            '_i = _cm.Count
            'MsgBox(_i.ToString())
        End If

    End Sub

    Private Sub ComboBoxStatus_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles ComboBoxStatus.SelectedIndexChanged

        If _cbStatus.SelectedIndex = 1 Then
            Me.DistrictPerStatus(UCase(Trim(ComboBoxStatus.Text)))

        ElseIf _cbStatus.SelectedIndex = 2 Then
            Me.DistrictPerStatus(UCase(Trim(ComboBoxStatus.Text)))

        Else
            Me.DistrictList()

        End If
    End Sub

    Private Sub DistrictList()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance

        If MyCodeTableDS.sp_district_list.Count > 0 Then _
            MyCodeTableDS.sp_district_list.Clear()

        Try
            BusinessObject.Sub_Show(ServerPath, "sp_district_list", CommandType.StoredProcedure, _
                MyCodeTableDS, "sp_district_list")

            DataGridDistrictList.DataSource = MyCodeTableDS.sp_district_list
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DistrictPerStatus(ByVal _sStatus As String)
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter

        If MyCodeTableDS.sp_district_per_status_list.Count > 0 Then _
            MyCodeTableDS.sp_district_per_status_list.Clear()

        Try
            Dim _status As New SqlParameter("@status", SqlDbType.Char, 8)
            _status.Direction = ParameterDirection.Input
            _status.Value = _sStatus
            Params(0) = _status

            Try
                BusinessObject.Sub_Show(ServerPath, "sp_district_per_status_list", CommandType.StoredProcedure, _
                    MyCodeTableDS, "sp_district_per_status_list", Params)

                DataGridDistrictList.DataSource = MyCodeTableDS.sp_district_per_status_list

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ClearEntry()
        _cbStatus = ComboBoxStatus

        TextBoxDistrictCode.Clear()
        TextBoxDistrictName.Clear()

        TextBoxDistrictCode.Enabled = False
        TextBoxDistrictName.Enabled = False
        ComboBoxDivisionName.Enabled = False
        _cbStatus.Enabled = True
        _cbStatus.SelectedIndex = 0

    End Sub

    Private Sub RemoveSelectedRow()
        _dgDistrictList = DataGridDistrictList
        _dgDistrictList.UnSelect(_dgDistrictList.CurrentRowIndex)
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

    Private Sub DistrictCodeList()
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
    End Sub

    Private Sub DistrictNameList()
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
    End Sub

    Private Sub ButtonClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonClear.Click
        Me.ClearEntry()
    End Sub
End Class
