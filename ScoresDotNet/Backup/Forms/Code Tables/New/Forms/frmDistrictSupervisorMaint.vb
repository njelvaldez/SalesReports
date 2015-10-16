Imports System.Data.SqlClient

Public Class frmDistrictSupervisorMaint
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
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents ComboBoxDistrictSupervisor As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxDistrict As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridDistrictList As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridSupervisorList As System.Windows.Forms.DataGrid
    Friend WithEvents ButtonDistClear As System.Windows.Forms.Button
    Friend WithEvents ButtonDistDelete As System.Windows.Forms.Button
    Friend WithEvents ButtonDistEdit As System.Windows.Forms.Button
    Friend WithEvents ButtonDistAdd As System.Windows.Forms.Button
    Friend WithEvents ButtonSupClear As System.Windows.Forms.Button
    Friend WithEvents ButtonSupDelete As System.Windows.Forms.Button
    Friend WithEvents ButtonSupEdit As System.Windows.Forms.Button
    Friend WithEvents ButtonSupAdd As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataGridDistrictList = New System.Windows.Forms.DataGrid
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DataGridSupervisorList = New System.Windows.Forms.DataGrid
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.ComboBoxDistrict = New System.Windows.Forms.ComboBox
        Me.ButtonDistClear = New System.Windows.Forms.Button
        Me.ButtonDistDelete = New System.Windows.Forms.Button
        Me.ButtonDistEdit = New System.Windows.Forms.Button
        Me.ButtonDistAdd = New System.Windows.Forms.Button
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.ComboBoxDistrictSupervisor = New System.Windows.Forms.ComboBox
        Me.ButtonSupClear = New System.Windows.Forms.Button
        Me.ButtonSupDelete = New System.Windows.Forms.Button
        Me.ButtonSupEdit = New System.Windows.Forms.Button
        Me.ButtonSupAdd = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridDistrictList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridSupervisorList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Splitter1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(896, 518)
        Me.Panel1.TabIndex = 0
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.SystemColors.WindowText
        Me.Splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter1.Location = New System.Drawing.Point(0, 254)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(750, 2)
        Me.Splitter1.TabIndex = 0
        Me.Splitter1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.DockPadding.Bottom = 5
        Me.Panel2.DockPadding.Left = 5
        Me.Panel2.DockPadding.Right = 5
        Me.Panel2.DockPadding.Top = 2
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(750, 256)
        Me.Panel2.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridDistrictList)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(5, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(740, 249)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'DataGridDistrictList
        '
        Me.DataGridDistrictList.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridDistrictList.CaptionText = "District List"
        Me.DataGridDistrictList.DataMember = ""
        Me.DataGridDistrictList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridDistrictList.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridDistrictList.Location = New System.Drawing.Point(3, 17)
        Me.DataGridDistrictList.Name = "DataGridDistrictList"
        Me.DataGridDistrictList.ParentRowsBackColor = System.Drawing.Color.Silver
        Me.DataGridDistrictList.PreferredColumnWidth = 100
        Me.DataGridDistrictList.ReadOnly = True
        Me.DataGridDistrictList.Size = New System.Drawing.Size(734, 229)
        Me.DataGridDistrictList.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.DockPadding.All = 5
        Me.Panel3.Location = New System.Drawing.Point(0, 256)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(750, 260)
        Me.Panel3.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridSupervisorList)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(5, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(740, 250)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'DataGridSupervisorList
        '
        Me.DataGridSupervisorList.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridSupervisorList.CaptionText = "District Team Manager List"
        Me.DataGridSupervisorList.DataMember = ""
        Me.DataGridSupervisorList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridSupervisorList.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridSupervisorList.Location = New System.Drawing.Point(3, 17)
        Me.DataGridSupervisorList.Name = "DataGridSupervisorList"
        Me.DataGridSupervisorList.ParentRowsBackColor = System.Drawing.Color.Silver
        Me.DataGridSupervisorList.PreferredColumnWidth = 100
        Me.DataGridSupervisorList.ReadOnly = True
        Me.DataGridSupervisorList.Size = New System.Drawing.Size(734, 230)
        Me.DataGridSupervisorList.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(750, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(144, 516)
        Me.Panel4.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GroupBox3)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.DockPadding.Bottom = 5
        Me.Panel5.DockPadding.Left = 5
        Me.Panel5.DockPadding.Right = 5
        Me.Panel5.DockPadding.Top = 2
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(144, 256)
        Me.Panel5.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ComboBoxDistrict)
        Me.GroupBox3.Controls.Add(Me.ButtonDistClear)
        Me.GroupBox3.Controls.Add(Me.ButtonDistDelete)
        Me.GroupBox3.Controls.Add(Me.ButtonDistEdit)
        Me.GroupBox3.Controls.Add(Me.ButtonDistAdd)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(5, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(134, 249)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "District Group"
        '
        'ComboBoxDistrict
        '
        Me.ComboBoxDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDistrict.Items.AddRange(New Object() {"<- Select Status ->", "ACTIVE", "INACTIVE"})
        Me.ComboBoxDistrict.Location = New System.Drawing.Point(9, 192)
        Me.ComboBoxDistrict.Name = "ComboBoxDistrict"
        Me.ComboBoxDistrict.TabIndex = 4
        '
        'ButtonDistClear
        '
        Me.ButtonDistClear.Location = New System.Drawing.Point(32, 144)
        Me.ButtonDistClear.Name = "ButtonDistClear"
        Me.ButtonDistClear.TabIndex = 3
        Me.ButtonDistClear.Text = "&Unselect"
        '
        'ButtonDistDelete
        '
        Me.ButtonDistDelete.Location = New System.Drawing.Point(32, 112)
        Me.ButtonDistDelete.Name = "ButtonDistDelete"
        Me.ButtonDistDelete.TabIndex = 2
        Me.ButtonDistDelete.Text = "&Delete"
        '
        'ButtonDistEdit
        '
        Me.ButtonDistEdit.Location = New System.Drawing.Point(32, 80)
        Me.ButtonDistEdit.Name = "ButtonDistEdit"
        Me.ButtonDistEdit.TabIndex = 1
        Me.ButtonDistEdit.Text = "&Edit"
        '
        'ButtonDistAdd
        '
        Me.ButtonDistAdd.Location = New System.Drawing.Point(32, 48)
        Me.ButtonDistAdd.Name = "ButtonDistAdd"
        Me.ButtonDistAdd.TabIndex = 0
        Me.ButtonDistAdd.Text = "&Add"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.GroupBox4)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.DockPadding.Bottom = 5
        Me.Panel6.DockPadding.Left = 5
        Me.Panel6.DockPadding.Right = 5
        Me.Panel6.DockPadding.Top = 2
        Me.Panel6.Location = New System.Drawing.Point(0, 256)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(144, 260)
        Me.Panel6.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ComboBoxDistrictSupervisor)
        Me.GroupBox4.Controls.Add(Me.ButtonSupClear)
        Me.GroupBox4.Controls.Add(Me.ButtonSupDelete)
        Me.GroupBox4.Controls.Add(Me.ButtonSupEdit)
        Me.GroupBox4.Controls.Add(Me.ButtonSupAdd)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(5, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(134, 253)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "District Team Manager Group"
        '
        'ComboBoxDistrictSupervisor
        '
        Me.ComboBoxDistrictSupervisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDistrictSupervisor.Enabled = False
        Me.ComboBoxDistrictSupervisor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxDistrictSupervisor.ItemHeight = 13
        Me.ComboBoxDistrictSupervisor.Items.AddRange(New Object() {"<- Select Status ->", "ACTIVE", "INACTIVE"})
        Me.ComboBoxDistrictSupervisor.Location = New System.Drawing.Point(7, 189)
        Me.ComboBoxDistrictSupervisor.Name = "ComboBoxDistrictSupervisor"
        Me.ComboBoxDistrictSupervisor.TabIndex = 9
        '
        'ButtonSupClear
        '
        Me.ButtonSupClear.Location = New System.Drawing.Point(30, 141)
        Me.ButtonSupClear.Name = "ButtonSupClear"
        Me.ButtonSupClear.TabIndex = 8
        Me.ButtonSupClear.Text = "&Unselect"
        '
        'ButtonSupDelete
        '
        Me.ButtonSupDelete.Location = New System.Drawing.Point(30, 109)
        Me.ButtonSupDelete.Name = "ButtonSupDelete"
        Me.ButtonSupDelete.TabIndex = 7
        Me.ButtonSupDelete.Text = "&Delete"
        '
        'ButtonSupEdit
        '
        Me.ButtonSupEdit.Location = New System.Drawing.Point(30, 77)
        Me.ButtonSupEdit.Name = "ButtonSupEdit"
        Me.ButtonSupEdit.TabIndex = 6
        Me.ButtonSupEdit.Text = "&Edit"
        '
        'ButtonSupAdd
        '
        Me.ButtonSupAdd.Location = New System.Drawing.Point(30, 45)
        Me.ButtonSupAdd.Name = "ButtonSupAdd"
        Me.ButtonSupAdd.TabIndex = 5
        Me.ButtonSupAdd.Text = "&Add"
        '
        'frmDistrictSupervisorMaint
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(896, 518)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmDistrictSupervisorMaint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "District Team Manager Maintenance"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridDistrictList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridSupervisorList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private MyCodeTableDS As New CodeTablesDS
    Private _myHitTestInfo As DataGrid.HitTestInfo

    Private Sub frmDistrictSupervisorMaint_Load(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles MyBase.Load
        Me.DistrictList()
        'Me.DistrictSupervisorList()
        ComboBoxDistrict.SelectedIndex = 0
        ComboBoxDistrictSupervisor.SelectedIndex = 0
    End Sub

    Private Sub DataGridDistrictList_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
        Handles DataGridDistrictList.MouseUp
        Dim _s0 As String
        Dim _i, _iRow As Integer
        Dim _dg As DataGrid = DirectCast(sender, DataGrid)
        Dim _ht As DataGrid.HitTestInfo

        _dg = DataGridDistrictList
        _iRow = _dg.CurrentRowIndex

        _ht = _dg.HitTest(e.X, e.Y)
        _i = _ht.Row

        If (e.Button = MouseButtons.Right) Then
            Return
        Else
            If _i = -1 Then
                Return
            Else
                _dg.Select(_ht.Row)
                With DataGridDistrictList
                    If .IsSelected(.CurrentRowIndex) Then
                        _s0 = Trim(.Item(.CurrentCell.RowNumber, 0).ToString)
                        Me.DistrictSupervisorList(Trim(_s0))
                    Else
                        Return
                    End If
                End With
            End If
        End If
    End Sub

    Private Sub DataGridSupervisorList_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
        Handles DataGridSupervisorList.MouseUp
        Dim _i, _iRow As Integer
        Dim _dg As DataGrid = DirectCast(sender, DataGrid)
        Dim _ht As DataGrid.HitTestInfo

        _dg = DataGridSupervisorList
        _iRow = _dg.CurrentRowIndex

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

    Private Sub DataGridDistrictList_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles DataGridDistrictList.Click

        'Dim _iRow As Integer = MyCodeTableDS.sp_district_list.Rows.Count
        'Dim _i As Integer
        'Dim _s0 As String

        'If _iRow <> 0 Then
        '    For _i = 0 To _iRow - 1
        '        With DataGridDistrictList
        '            If .IsSelected(_i) Then
        '                _s0 = .Item(_i, 0).ToString()
        '                '_s0 = .Item(.CurrentCell.RowNumber, 0).ToString()
        '                Me.DistrictSupervisorList(Trim(_s0))

        '            End If
        '        End With
        '    Next
        'End If

    End Sub

    Private Sub DistrictSupervisorList(ByVal _sDistrictCode As String)
        Me.Cursor = Cursors.WaitCursor

        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter

        If MyCodeTableDS.sp_district_supervisor_list.Count > 0 Then _
            MyCodeTableDS.sp_district_supervisor_list.Clear()

        Try
            Dim _district_code As New SqlParameter("@district_code", SqlDbType.Char, 10)
            _district_code.Direction = ParameterDirection.Input
            _district_code.Value = _sDistrictCode
            Params(0) = _district_code

            Try
                BusinessObject.Sub_Show(ServerPath, "sp_district_supervisor_list", CommandType.StoredProcedure, _
                    MyCodeTableDS, "sp_district_supervisor_list", Params)

                DataGridSupervisorList.DataSource = MyCodeTableDS.sp_district_supervisor_list

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        _gDistrictCode = _sDistrictCode

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub ComboBoxDistrict_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles ComboBoxDistrict.SelectedIndexChanged

        If ComboBoxDistrict.SelectedIndex = 1 Then
            Me.DistrictPerStatus(UCase(Trim(ComboBoxDistrict.Text)))
            DataGridSupervisorList.DataSource = Nothing
        ElseIf ComboBoxDistrict.SelectedIndex = 2 Then
            Me.DistrictPerStatus(UCase(Trim(ComboBoxDistrict.Text)))
            DataGridSupervisorList.DataSource = Nothing
        Else
            Me.DistrictList()
            DataGridSupervisorList.DataSource = Nothing
        End If

        If MyCodeTableDS.sp_district_supervisor_list.Count > 0 Then _
            MyCodeTableDS.sp_district_supervisor_list.Clear()
    End Sub

    Private Sub ComboBoxDistrictSupervisor_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles ComboBoxDistrictSupervisor.SelectedIndexChanged

        Dim _iRow As Integer = MyCodeTableDS.sp_district_list.Rows.Count
        Dim _i As Integer
        Dim _s0 As String

        If ComboBoxDistrictSupervisor.SelectedIndex = 1 Then
            Me.DistrictSupervisorPerStatus(UCase(Trim(ComboBoxDistrictSupervisor.Text)))

        ElseIf ComboBoxDistrictSupervisor.SelectedIndex = 2 Then
            Me.DistrictSupervisorPerStatus(UCase(Trim(ComboBoxDistrictSupervisor.Text)))

        Else
            If _iRow <> 0 Then
                For _i = 0 To _iRow - 1
                    With DataGridDistrictList
                        If .IsSelected(_i) Then
                            _s0 = .Item(_i, 0).ToString()
                            '_s0 = .Item(.CurrentCell.RowNumber, 0).ToString()
                            Me.DistrictSupervisorList(Trim(_s0))
                        End If
                    End With
                Next
            End If

        End If
    End Sub

    Private Sub DistrictSupervisorPerStatus(ByVal _sStatus As String)
        Me.Cursor = Cursors.WaitCursor

        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(1) As SqlParameter

        Dim _iRow As Integer = MyCodeTableDS.sp_district_list.Rows.Count
        Dim _i As Integer
        Dim _s0 As String

        If _iRow <> 0 Then
            For _i = 0 To _iRow - 1
                With DataGridDistrictList
                    If .IsSelected(_i) Then
                        _s0 = .Item(_i, 0).ToString()

                    End If
                End With
            Next

        End If

        If MyCodeTableDS.sp_district_supervisor_per_status.Count > 0 Then _
            MyCodeTableDS.sp_district_supervisor_per_status.Clear()

        Try
            Dim _districtcode As New SqlParameter("@districtcode", SqlDbType.Char, 10)
            _districtcode.Direction = ParameterDirection.Input
            _districtcode.Value = _s0
            Params(0) = _districtcode

            Dim _status As New SqlParameter("@status", SqlDbType.Char, 8)
            _status.Direction = ParameterDirection.Input
            _status.Value = _sStatus
            Params(1) = _status

            Try
                BusinessObject.Sub_Show(ServerPath, "sp_district_supervisor_per_status", CommandType.StoredProcedure, _
                    MyCodeTableDS, "sp_district_supervisor_per_status", Params)

                DataGridSupervisorList.DataSource = MyCodeTableDS.sp_district_supervisor_per_status

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub ButtonDistAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles ButtonDistAdd.Click
        Dim _frmDistrictEntry As New frmDistrictEntry

        Me.UnSelectSupervisorListRow()
        _frmDistrictEntry.ShowDialog(Me)

    End Sub

    Private Sub ButtonDistEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles ButtonDistEdit.Click
        Dim _iRow As Integer
        Dim _frmPopup As New frmDistrictUpdate
        'Me.UnSelectSupervisorListRow()
        _iRow = DataGridDistrictList.CurrentRowIndex

        If _iRow = -1 Then
            Return
        Else
            If DataGridDistrictList.IsSelected(_iRow) Then
                With DataGridDistrictList
                    _s0District = Trim(.Item(.CurrentCell.RowNumber, 0).ToString)
                    _s1District = Trim(.Item(.CurrentCell.RowNumber, 1).ToString)
                    _s2District = Trim(.Item(.CurrentCell.RowNumber, 2).ToString)
                    _s3District = Trim(.Item(.CurrentCell.RowNumber, 3).ToString)
                    _s4District = Trim(.Item(.CurrentCell.RowNumber, 4).ToString)
                    _s5District = Trim(.Item(.CurrentCell.RowNumber, 5).ToString)
                    _s6District = Trim(.Item(.CurrentCell.RowNumber, 6).ToString)
                    _s7District = Trim(.Item(.CurrentCell.RowNumber, 7).ToString)
                    _s8District = Trim(.Item(.CurrentCell.RowNumber, 8).ToString)
                    _s9District = Trim(.Item(.CurrentCell.RowNumber, 9).ToString)
                    _s10District = Trim(.Item(.CurrentCell.RowNumber, 10).ToString)
                    _s11District = Trim(.Item(.CurrentCell.RowNumber, 11).ToString)
                End With
                _frmPopup.ShowDialog(Me)
            Else
                Return
            End If
        End If
    End Sub

    Private Sub ButtonDistDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles ButtonDistDelete.Click
        Dim _s0 As String

        If MyCodeTableDS.sp_district_list.Rows.Count > 0 Then
            With DataGridDistrictList
                If .IsSelected(.CurrentRowIndex) Then
                    _s0 = Trim(.Item(.CurrentCell.RowNumber, 0).ToString)
                    Me.SelectSupervisorListRow()
                    Me.DistrictSupervisorDelete(_s0)
                Else
                    Return
                End If
            End With
        End If
    End Sub

    Private Sub ButtonDistClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles ButtonDistClear.Click
        Me.RemoveSelectedRow()

    End Sub

    Private Sub RemoveSelectedRow()
        Dim _iCount1, _iCount2, _i As Integer

        _iCount1 = MyCodeTableDS.sp_district_list.Rows.Count

        If _iCount1 <> 0 Then
            For _i = 0 To _iCount1 - 1
                With DataGridDistrictList
                    If .IsSelected(_i) Then
                        .UnSelect(_i)
                    End If
                End With
            Next
        End If

        _iCount2 = MyCodeTableDS.sp_district_supervisor_list.Rows.Count

        If _iCount2 <> 0 Then
            For _i = 0 To _iCount2 - 1
                With DataGridSupervisorList
                    If .IsSelected(_i) Then
                        .UnSelect(_i)
                    End If
                End With
            Next
        End If

    End Sub

    Private Sub DataGridDistrictList_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles DataGridDistrictList.CurrentCellChanged
        Dim _s0 As String

        With DataGridDistrictList
            _s0 = Trim(.Item(.CurrentCell.RowNumber, 0).ToString)
            Me.DistrictSupervisorList(Trim(_s0))
        End With
    End Sub

    Private Sub DataGridDistrictList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles DataGridDistrictList.DoubleClick

        With DataGridDistrictList
            Me.DistrictSupervisorList(.Item(.CurrentCell.RowNumber, 0).ToString)
        End With
    End Sub

    Private Sub DistrictSupervisorDelete(ByVal _sValue As String)
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter

        If MyCodeTableDS.sp_district_supervisor_delete.Count > 0 Then _
            MyCodeTableDS.sp_district_supervisor_delete.Clear()

        If (MessageBox.Show("You're about to delete the selected row in District list view" & vbNewLine & _
            "inline with the selected row(s) in Supervisor list view!" & vbNewLine & _
            "Click Yes if you want to proceed.", "Deleting", MessageBoxButtons.YesNo, _
            MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then

            Try
                Dim _districtcode As New SqlParameter("@districtcode", SqlDbType.Char, 10)
                _districtcode.Direction = ParameterDirection.Input
                _districtcode.Value = _sValue
                Params(0) = _districtcode

                Try
                    BusinessObject.Sub_Show(ServerPath, "sp_district_supervisor_delete", CommandType.StoredProcedure, _
                        MyCodeTableDS, "sp_district_supervisor_delete", Params)

                    Me.DGRowRemoved()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Me.RemoveSelectedRow()
            Return
        End If
    End Sub

    Private Sub DistrictSupervisorDelete2(ByVal _sValue1 As String, ByVal _sValue2 As String)
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(1) As SqlParameter

        If MyCodeTableDS.sp_district_supervisor_delete2.Count > 0 Then _
            MyCodeTableDS.sp_district_supervisor_delete2.Clear()

        If (MessageBox.Show("You're about to delete the selected row" & vbNewLine & _
            "in supervisor lists view!" & vbNewLine & _
            "Click Yes if you want to proceed.", "Deleting", MessageBoxButtons.YesNo, _
            MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then

            Try
                Dim _districtcode As New SqlParameter("@districtcode", SqlDbType.Char, 10)
                _districtcode.Direction = ParameterDirection.Input
                _districtcode.Value = _sValue1
                Params(0) = _districtcode

                Dim _supcode As New SqlParameter("@supcode", SqlDbType.Char, 10)
                _supcode.Direction = ParameterDirection.Input
                _supcode.Value = _sValue2
                Params(1) = _supcode

                Try
                    BusinessObject.Sub_Show(ServerPath, "sp_district_supervisor_delete2", CommandType.StoredProcedure, _
                        MyCodeTableDS, "sp_district_supervisor_delete2", Params)

                    Me.DGRowRemoved2()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Return
        End If
    End Sub

    Private Sub DGRowRemoved()
        Me.Cursor = Cursors.WaitCursor

        If MyCodeTableDS.sp_district_list.Rows.Count > 0 Then
            MyCodeTableDS.sp_district_list.Rows.RemoveAt(DataGridDistrictList.CurrentRowIndex)
        End If

        Dim _iRow As Integer = MyCodeTableDS.sp_district_supervisor_list.Rows.Count

        If _iRow > 0 Then
            For _i As Integer = 0 To _iRow - 1
                With DataGridSupervisorList
                    If .IsSelected(_i) Then
                        MyCodeTableDS.sp_district_supervisor_list.Rows.RemoveAt(_i)
                    End If
                End With
            Next _i
        End If

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub DGRowRemoved2()
        Me.Cursor = Cursors.WaitCursor

        If MyCodeTableDS.sp_district_supervisor_list.Rows.Count > 0 Then
            MyCodeTableDS.sp_district_supervisor_list.Rows.RemoveAt(DataGridSupervisorList.CurrentRowIndex)
        End If

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ButtonSupAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles ButtonSupAdd.Click
        Dim _i As Integer = DataGridDistrictList.CurrentRowIndex
        Dim _iRow As Integer = MyCodeTableDS.sp_district_supervisor_list.Rows.Count
        Dim _frmPopup As New frmDistrictSupervisorEntry

        Me.UnSelectSupervisorListRow()

        If _iRow <> 0 Then
            If _i = -1 Then
                Return
            Else
                If DataGridDistrictList.IsSelected(_i) Then
                    With DataGridDistrictList
                        _s0District = Trim(.Item(.CurrentCell.RowNumber, 0).ToString)
                        _s6District = Trim(.Item(.CurrentCell.RowNumber, 6).ToString)
                        _s7District = Trim(.Item(.CurrentCell.RowNumber, 7).ToString)

                    End With
                    _frmPopup.ShowDialog(Me)
                Else
                    Return
                End If
            End If

        Else
            With DataGridDistrictList
                _s0District = Trim(.Item(.CurrentCell.RowNumber, 0).ToString)
                _s6District = Trim(.Item(.CurrentCell.RowNumber, 6).ToString)
                _s7District = Trim(.Item(.CurrentCell.RowNumber, 7).ToString)
            End With
            _frmPopup.ShowDialog(Me)
        End If
    End Sub

    Private Sub ButtonSupEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles ButtonSupEdit.Click
        Dim _iRow As Integer
        Dim _frmPopup As New frmDistrictSupervisorUpdate
        'Me.UnSelectDistrictListRow()

        _iRow = DataGridSupervisorList.CurrentRowIndex

        If _iRow = -1 Then
            Return
        Else
            If DataGridSupervisorList.IsSelected(_iRow) Then
                With DataGridSupervisorList
                    _s0District = Trim(.Item(.CurrentCell.RowNumber, 0).ToString)
                    _s1District = Trim(.Item(.CurrentCell.RowNumber, 1).ToString)
                    _s2District = Trim(.Item(.CurrentCell.RowNumber, 2).ToString)
                    _s3District = Trim(.Item(.CurrentCell.RowNumber, 3).ToString)
                    _s4District = Trim(.Item(.CurrentCell.RowNumber, 4).ToString)
                    _s5District = Trim(.Item(.CurrentCell.RowNumber, 5).ToString)
                    _s6District = Trim(.Item(.CurrentCell.RowNumber, 6).ToString)
                    _s7District = Trim(.Item(.CurrentCell.RowNumber, 7).ToString)
                End With
                _frmPopup.ShowDialog(Me)
            Else
                Return
            End If
        End If
    End Sub

    Private Sub ButtonSupDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles ButtonSupDelete.Click
        Dim _i As Integer
        Dim _sDistCode, _sSupCode As String

        If MyCodeTableDS.sp_district_list.Rows.Count > 0 Then
            With DataGridDistrictList
                If .IsSelected(.CurrentRowIndex) Then
                    _sDistCode = Trim(.Item(.CurrentCell.RowNumber, 0).ToString)
                End If
            End With

            If MyCodeTableDS.sp_district_supervisor_list.Rows.Count > 0 Then
                With DataGridSupervisorList
                    If .IsSelected(.CurrentRowIndex) Then
                        _sSupCode = Trim(.Item(.CurrentCell.RowNumber, 0).ToString)
                        Me.DistrictSupervisorDelete2(_sDistCode, _sSupCode)
                    Else
                        Return
                    End If
                End With
            End If
        End If
    End Sub

    Private Sub ButtonSupClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles ButtonSupClear.Click
        Me.RemoveSelectedRow()
    End Sub

    Private Sub SelectSupervisorListRow()
        Dim _iRow As Integer = MyCodeTableDS.sp_district_supervisor_list.Rows.Count

        If _iRow <> 0 Then
            For _i As Integer = 0 To _iRow - 1
                With DataGridSupervisorList
                    If .IsSelected(_i) = False Then
                        .Select(_i)
                    End If
                End With
            Next _i
        End If
    End Sub

    Private Sub UnSelectSupervisorListRow()
        Dim _iRow As Integer = MyCodeTableDS.sp_district_supervisor_list.Rows.Count
        If _iRow <> 0 Then
            For _i As Integer = 0 To _iRow - 1
                With DataGridSupervisorList
                    If .IsSelected(_i) Then
                        .UnSelect(_i)
                    End If
                End With
            Next
        Else
            Return
        End If
    End Sub

    Private Sub UnSelectDistrictListRow()
        Dim _iRow As Integer = MyCodeTableDS.sp_district_list.Rows.Count

        If _iRow <> 0 Then
            For _i As Integer = 0 To _iRow - 1
                With DataGridDistrictList
                    If .IsSelected(_i) Then
                        .UnSelect(_i)
                    End If
                End With
            Next
        End If
    End Sub

    Private Sub DistrictList()
        Me.Cursor = Cursors.WaitCursor

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

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub DistrictPerStatus(ByVal _sStatus As String)
        Me.Cursor = Cursors.WaitCursor

        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter

        If MyCodeTableDS.sp_district_list.Count > 0 Then _
            MyCodeTableDS.sp_district_list.Clear()

        Try
            Dim _status As New SqlParameter("@status", SqlDbType.Char, 8)
            _status.Direction = ParameterDirection.Input
            _status.Value = _sStatus
            Params(0) = _status

            Try
                BusinessObject.Sub_Show(ServerPath, "sp_district_list", CommandType.StoredProcedure, _
                    MyCodeTableDS, "sp_district_list", Params)

                DataGridDistrictList.DataSource = MyCodeTableDS.sp_district_list

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Frm_Closed(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles MyBase.Closed
        EnDisMainMenu(Me, True)
    End Sub

    Private Sub Frm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles MyBase.Activated
        EnDisMainMenu(Me, False)
    End Sub

End Class
