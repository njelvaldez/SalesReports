Imports System.Data.SqlClient

Public Class MyTabPageControl1
    Inherits System.Windows.Forms.UserControl

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        With DateTimePickerStartDate
            .Value = GetFirstDayOfMonth(.Value)
        End With
        With DateTimePickerEndDate
            .Value = GetLastDayOfMonth(.Value)
        End With

        Me.DivisionSelections()
    End Sub

    'UserControl overrides dispose to clean up the component list.
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
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents ButtonEdit As System.Windows.Forms.Button
    Friend WithEvents ButtonItemBrowse As System.Windows.Forms.Button
    Friend WithEvents TextBoxAmount As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxQuantity As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxItemDescription As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxItemCode As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDivisionName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxOldMDICode As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePickerStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBoxDivisionName As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridValidationEntry As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridItemLagundexList As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ButtonItemBrowse = New System.Windows.Forms.Button
        Me.DataGridValidationEntry = New System.Windows.Forms.DataGrid
        Me.ComboBoxDivisionName = New System.Windows.Forms.ComboBox
        Me.DateTimePickerEndDate = New System.Windows.Forms.DateTimePicker
        Me.DateTimePickerStartDate = New System.Windows.Forms.DateTimePicker
        Me.TextBoxOldMDICode = New System.Windows.Forms.TextBox
        Me.DataGridItemLagundexList = New System.Windows.Forms.DataGrid
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.TextBoxAmount = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.TextBoxQuantity = New System.Windows.Forms.TextBox
        Me.TextBoxItemDescription = New System.Windows.Forms.TextBox
        Me.ButtonDelete = New System.Windows.Forms.Button
        Me.ButtonSave = New System.Windows.Forms.Button
        Me.ButtonClear = New System.Windows.Forms.Button
        Me.TextBoxItemCode = New System.Windows.Forms.TextBox
        Me.TextBoxDivisionName = New System.Windows.Forms.TextBox
        Me.ButtonEdit = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridValidationEntry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridItemLagundexList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ButtonItemBrowse)
        Me.Panel1.Controls.Add(Me.DataGridValidationEntry)
        Me.Panel1.Controls.Add(Me.ComboBoxDivisionName)
        Me.Panel1.Controls.Add(Me.DateTimePickerEndDate)
        Me.Panel1.Controls.Add(Me.DateTimePickerStartDate)
        Me.Panel1.Controls.Add(Me.TextBoxOldMDICode)
        Me.Panel1.Controls.Add(Me.DataGridItemLagundexList)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.TextBoxAmount)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.TextBoxQuantity)
        Me.Panel1.Controls.Add(Me.TextBoxItemDescription)
        Me.Panel1.Controls.Add(Me.ButtonDelete)
        Me.Panel1.Controls.Add(Me.ButtonSave)
        Me.Panel1.Controls.Add(Me.ButtonClear)
        Me.Panel1.Controls.Add(Me.TextBoxItemCode)
        Me.Panel1.Controls.Add(Me.TextBoxDivisionName)
        Me.Panel1.Controls.Add(Me.ButtonEdit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(341, 216)
        Me.Panel1.TabIndex = 0
        '
        'ButtonItemBrowse
        '
        Me.ButtonItemBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonItemBrowse.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonItemBrowse.Location = New System.Drawing.Point(299, 31)
        Me.ButtonItemBrowse.Name = "ButtonItemBrowse"
        Me.ButtonItemBrowse.Size = New System.Drawing.Size(31, 21)
        Me.ButtonItemBrowse.TabIndex = 1
        Me.ButtonItemBrowse.Text = "..."
        '
        'DataGridValidationEntry
        '
        Me.DataGridValidationEntry.DataMember = ""
        Me.DataGridValidationEntry.Enabled = False
        Me.DataGridValidationEntry.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridValidationEntry.Location = New System.Drawing.Point(276, 111)
        Me.DataGridValidationEntry.Name = "DataGridValidationEntry"
        Me.DataGridValidationEntry.Size = New System.Drawing.Size(28, 16)
        Me.DataGridValidationEntry.TabIndex = 0
        Me.DataGridValidationEntry.Visible = False
        '
        'ComboBoxDivisionName
        '
        Me.ComboBoxDivisionName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDivisionName.Location = New System.Drawing.Point(88, 12)
        Me.ComboBoxDivisionName.MaxDropDownItems = 12
        Me.ComboBoxDivisionName.Name = "ComboBoxDivisionName"
        Me.ComboBoxDivisionName.Size = New System.Drawing.Size(208, 21)
        Me.ComboBoxDivisionName.TabIndex = 2
        '
        'DateTimePickerEndDate
        '
        Me.DateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePickerEndDate.Location = New System.Drawing.Point(88, 138)
        Me.DateTimePickerEndDate.MaxDate = New Date(2078, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerEndDate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerEndDate.Name = "DateTimePickerEndDate"
        Me.DateTimePickerEndDate.Size = New System.Drawing.Size(120, 21)
        Me.DateTimePickerEndDate.TabIndex = 6
        '
        'DateTimePickerStartDate
        '
        Me.DateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePickerStartDate.Location = New System.Drawing.Point(88, 117)
        Me.DateTimePickerStartDate.MaxDate = New Date(2078, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerStartDate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerStartDate.Name = "DateTimePickerStartDate"
        Me.DateTimePickerStartDate.Size = New System.Drawing.Size(120, 21)
        Me.DateTimePickerStartDate.TabIndex = 5
        '
        'TextBoxOldMDICode
        '
        Me.TextBoxOldMDICode.Location = New System.Drawing.Point(299, 7)
        Me.TextBoxOldMDICode.Name = "TextBoxOldMDICode"
        Me.TextBoxOldMDICode.Size = New System.Drawing.Size(30, 21)
        Me.TextBoxOldMDICode.TabIndex = 0
        Me.TextBoxOldMDICode.Text = ""
        Me.TextBoxOldMDICode.Visible = False
        '
        'DataGridItemLagundexList
        '
        Me.DataGridItemLagundexList.DataMember = ""
        Me.DataGridItemLagundexList.Enabled = False
        Me.DataGridItemLagundexList.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridItemLagundexList.Location = New System.Drawing.Point(276, 127)
        Me.DataGridItemLagundexList.Name = "DataGridItemLagundexList"
        Me.DataGridItemLagundexList.Size = New System.Drawing.Size(28, 16)
        Me.DataGridItemLagundexList.TabIndex = 0
        Me.DataGridItemLagundexList.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(40, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Amount"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(36, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Quantity"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(33, 141)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 17)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "End Date"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(28, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 17)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Start Date"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(28, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 17)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Item Desc"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(27, 36)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 17)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Item Code"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 17)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Division Name"
        '
        'TextBoxAmount
        '
        Me.TextBoxAmount.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TextBoxAmount.Location = New System.Drawing.Point(88, 96)
        Me.TextBoxAmount.MaxLength = 23
        Me.TextBoxAmount.Name = "TextBoxAmount"
        Me.TextBoxAmount.Size = New System.Drawing.Size(120, 21)
        Me.TextBoxAmount.TabIndex = 4
        Me.TextBoxAmount.Text = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(83, 103)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(0, 17)
        Me.Label15.TabIndex = 80
        '
        'TextBoxQuantity
        '
        Me.TextBoxQuantity.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TextBoxQuantity.Location = New System.Drawing.Point(88, 75)
        Me.TextBoxQuantity.MaxLength = 23
        Me.TextBoxQuantity.Name = "TextBoxQuantity"
        Me.TextBoxQuantity.Size = New System.Drawing.Size(120, 21)
        Me.TextBoxQuantity.TabIndex = 3
        Me.TextBoxQuantity.Text = ""
        '
        'TextBoxItemDescription
        '
        Me.TextBoxItemDescription.Enabled = False
        Me.TextBoxItemDescription.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxItemDescription.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBoxItemDescription.Location = New System.Drawing.Point(88, 54)
        Me.TextBoxItemDescription.Name = "TextBoxItemDescription"
        Me.TextBoxItemDescription.Size = New System.Drawing.Size(243, 21)
        Me.TextBoxItemDescription.TabIndex = 7
        Me.TextBoxItemDescription.Text = ""
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Enabled = False
        Me.ButtonDelete.Location = New System.Drawing.Point(138, 178)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(65, 23)
        Me.ButtonDelete.TabIndex = 9
        Me.ButtonDelete.Text = "&Delete"
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(8, 178)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(65, 23)
        Me.ButtonSave.TabIndex = 7
        Me.ButtonSave.Text = "&Save"
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(203, 178)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(65, 23)
        Me.ButtonClear.TabIndex = 10
        Me.ButtonClear.Text = "&Clear"
        '
        'TextBoxItemCode
        '
        Me.TextBoxItemCode.Enabled = False
        Me.TextBoxItemCode.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxItemCode.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBoxItemCode.Location = New System.Drawing.Point(88, 33)
        Me.TextBoxItemCode.Name = "TextBoxItemCode"
        Me.TextBoxItemCode.Size = New System.Drawing.Size(208, 21)
        Me.TextBoxItemCode.TabIndex = 0
        Me.TextBoxItemCode.Text = ""
        '
        'TextBoxDivisionName
        '
        Me.TextBoxDivisionName.Enabled = False
        Me.TextBoxDivisionName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDivisionName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBoxDivisionName.Location = New System.Drawing.Point(88, 15)
        Me.TextBoxDivisionName.Name = "TextBoxDivisionName"
        Me.TextBoxDivisionName.Size = New System.Drawing.Size(208, 21)
        Me.TextBoxDivisionName.TabIndex = 0
        Me.TextBoxDivisionName.Text = ""
        Me.TextBoxDivisionName.Visible = False
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Enabled = False
        Me.ButtonEdit.Location = New System.Drawing.Point(73, 178)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(65, 23)
        Me.ButtonEdit.TabIndex = 8
        Me.ButtonEdit.Text = "&Edit"
        '
        'MyTabPageControl1
        '
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MyTabPageControl1"
        Me.Size = New System.Drawing.Size(341, 216)
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridValidationEntry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridItemLagundexList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private MyCodeTableDS As New CodeTablesDS
    Private xMyDataSets As New MyDataSets
    Private BusinessObject As New BusinessLayer.clsFileMaintenance

    Private Sub DivisionSelections()
        Me.Cursor = Cursors.WaitCursor
        
        If Me.MyCodeTableDS.sp_division_selections.Count > 0 Then _
            Me.MyCodeTableDS.sp_division_selections.Clear()

        Try
            Dim _DT As DataTable = New DataTable
            Dim _DR As DataRow

            BusinessObject.Sub_Show(ServerPath, "sp_division_selections", CommandType.StoredProcedure, _
                MyCodeTableDS, "sp_division_selections")

            _DT = Me.MyCodeTableDS.sp_division_selections
            '_DR = _DT.NewRow()
            '_DR(1) = "<- Select Division Name ->"
            '_DT.Rows.InsertAt(_DR, 0)

            With ComboBoxDivisionName
                .DataSource = _DT
                .DisplayMember = "Division Name"
                .ValueMember = "Division Code"
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub DivisionSelectionsLagundex()
        Me.Cursor = Cursors.WaitCursor
        Dim _DT As DataTable = New DataTable
        Dim _DR As DataRow

        If Me.xMyDataSets.sp_division_selections_lagundex.Count > 0 Then _
            Me.xMyDataSets.sp_division_selections_lagundex.Rows.Clear()

        Try
            BusinessObject.Sub_Show(ServerPath, "sp_division_selections_lagundex", CommandType.StoredProcedure, _
                Me.xMyDataSets, "sp_division_selections_lagundex")

            _DT = Me.xMyDataSets.sp_division_selections_lagundex
            '_DR = _DT.NewRow()
            '_DR(1) = "<- Select Division Name ->"
            '_DT.Rows.InsertAt(_DR, 0)

            With ComboBoxDivisionName
                .DataSource = _DT
                .DisplayMember = "Division Name"
                .ValueMember = "Division Code"
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ItemLagundexList(ByVal _sValue As String)
        Me.Cursor = Cursors.WaitCursor
        Dim Params(0) As SqlParameter

        If Me.xMyDataSets.sp_item_lagundex_list.Count > 0 Then _
            Me.xMyDataSets.sp_item_lagundex_list.Clear()

        Try
            Dim _itemcode As New SqlParameter("@itemcode", SqlDbType.Char, 10)
            _itemcode.Direction = ParameterDirection.Input
            _itemcode.Value = Trim(_sValue)
            Params(0) = _itemcode

            Try
                BusinessObject.Sub_Show(ServerPath, "sp_item_lagundex_list", CommandType.StoredProcedure, _
                    Me.xMyDataSets, "sp_item_lagundex_list", Params)

                Me.DataGridItemLagundexList.DataSource = Me.xMyDataSets.sp_item_lagundex_list

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ButtonItemBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles ButtonItemBrowse.Click
        Dim _frmMyItemBrowse As New frmMyItemBrowse
        'Me.ClearEntry()
        _frmMyItemBrowse.ShowDialog()

        If _frmMyItemBrowse.DialogResult = DialogResult.OK Then
            'TextBoxDivisionName.Text = _frmMyItemBrowse.xDivisionName ***removed due to change object to dynamically
            TextBoxItemCode.Text = _frmMyItemBrowse.xItemCode
            TextBoxItemDescription.Text = _frmMyItemBrowse.xItemDesc
            TextBoxOldMDICode.Text = _frmMyItemBrowse.xOldMDICode

            Me.ItemLagundexList(_frmMyItemBrowse.xItemCode)
            Dim _iCount As Integer = Me.xMyDataSets.sp_item_lagundex_list.Rows.Count

            '**verify if item code is for lagundex only 
            If _iCount > 0 Then
                Me.DivisionSelectionsLagundex()
            Else
                Me.DivisionSelections()
            End If
        End If
    End Sub

    Private Sub ButtonSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles ButtonSave.Click
        Dim _xTabpage As TabPage = CType(Me.Parent, TabPage)
        Dim Params(9) As SqlParameter
        Dim _sArrValues As String()
        _sArrValues = New String() {Trim(_xTabpage.Name), _
                                    Trim(Me.TextBoxItemCode.Text), _
                                    Trim(Me.ComboBoxDivisionName.SelectedValue.ToString), _
                                    Format(CDate(DateTimePickerStartDate.Value.ToString), "yyyy"), _
                                    Format(CDate(DateTimePickerStartDate.Value.ToString), "MM"), _
                                    Trim(_xTabpage.Text)}

        'If ComboBoxDivisionName.SelectedIndex = 0 Or TextBoxItemCode.Text = "" Or _
        If TextBoxItemDescription.Text = "" Or TextBoxQuantity.Text = "" Or _
            TextBoxAmount.Text = "" Then
            Return
        Else
            Me.StartDateValidate(DateTimePickerStartDate.Value, True)
            Me.ValidationEntry(_sArrValues, True)

            If _bConfirmedSD Or _bConfirmedAllEntry Then
                Return
            Else
                If (MessageBox.Show("You're about to save this entry! Click Yes if you want to proceed.", "Saving", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, _
                    MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then

                    Try
                        Dim _distributorcode As New SqlParameter("@distributorcode", SqlDbType.VarChar, 5)
                        _distributorcode.Direction = ParameterDirection.Input
                        _distributorcode.Value = Trim(_xTabpage.Name)
                        Params(0) = _distributorcode

                        Dim _itemcode As New SqlParameter("@itemcode", SqlDbType.Char, 10)
                        _itemcode.Direction = ParameterDirection.Input
                        _itemcode.Value = Trim(TextBoxItemCode.Text)
                        Params(1) = _itemcode

                        Dim _oldmdicode As New SqlParameter("@oldmdicode", SqlDbType.Char, 10)
                        _oldmdicode.Direction = ParameterDirection.Input
                        _oldmdicode.Value = Trim(TextBoxOldMDICode.Text)
                        Params(2) = _oldmdicode

                        Dim _quantity As New SqlParameter("@quantity", SqlDbType.Decimal, 9)
                        _quantity.Direction = ParameterDirection.Input
                        _quantity.Value = Decimal.Parse(Trim(TextBoxQuantity.Text))
                        Params(3) = _quantity

                        Dim _amount As New SqlParameter("@amount", SqlDbType.Money)
                        _amount.Direction = ParameterDirection.Input
                        _amount.Value = Decimal.Parse(Trim(TextBoxAmount.Text))
                        Params(4) = _amount

                        Dim _startdate As New SqlParameter("@startdate", SqlDbType.DateTime)
                        _startdate.Direction = ParameterDirection.Input
                        _startdate.Value = DateTimePickerStartDate.Value.ToString()
                        Params(5) = _startdate

                        Dim _endate As New SqlParameter("@endate", SqlDbType.DateTime)
                        _endate.Direction = ParameterDirection.Input
                        _endate.Value = DateTimePickerEndDate.Value.ToString()
                        Params(6) = _endate

                        Dim _createddate As New SqlParameter("@createddate", SqlDbType.DateTime)
                        _createddate.Direction = ParameterDirection.Input
                        _createddate.Value = GetDateTimeNow()
                        Params(7) = _createddate

                        Dim _lastuser As New SqlParameter("@lastuser", SqlDbType.Char, 10)
                        _lastuser.Direction = ParameterDirection.Input
                        _lastuser.Value = UCase(Trim(gUserID))
                        Params(8) = _lastuser

                        Dim _divcode As New SqlParameter("@divcode", SqlDbType.Char, 10)
                        _divcode.Direction = ParameterDirection.Input
                        _divcode.Value = Trim(ComboBoxDivisionName.SelectedValue.ToString())
                        Params(9) = _divcode

                        Try
                            BusinessObject.Sub_Insert(ServerPath, "sp_distributorbudgetdirect_insert", CommandType.StoredProcedure, Params)
                            Me.ClearEntry()
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

    Private Sub TextBoxQuantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles TextBoxQuantity.KeyPress
        '***no need to have a data entry and alphanumeric validation
        '***instead copy & paste approach or vice versa
        'If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
        '    e.Handled = True
        'End If
    End Sub

    Private Sub TextBoxAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles TextBoxAmount.KeyPress
        '***no need to have a data entry and alphanumeric validation
        '***instead copy & paste approach or vice versa
        'If e.KeyChar <> ControlChars.Back Then
        '    e.Handled() = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        'End If
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
                DateTimePickerEndDate.Value = GetLastDayOfMonth(Date.Today())
                _bConfirmedSD = True
            End If
        Else
            _bConfirmedSD = False
        End If
    End Sub

    Private Sub ValidationEntry(ByVal _sValue() As String, ByVal _b As Boolean)
        Dim Params(4) As SqlParameter

        Try
            Dim _distributorcode As New SqlParameter("@distributorcode", SqlDbType.VarChar, 5)
            _distributorcode.Direction = ParameterDirection.Input
            _distributorcode.Value = Trim(_sValue(0))
            Params(0) = _distributorcode

            Dim _itemcode As New SqlParameter("@itemcode", SqlDbType.Char, 10)
            _itemcode.Direction = ParameterDirection.Input
            _itemcode.Value = Trim(_sValue(1))
            Params(1) = _itemcode

            Dim _divcode As New SqlParameter("@divcode", SqlDbType.Char, 10)
            _divcode.Direction = ParameterDirection.Input
            _divcode.Value = Trim(_sValue(2))
            Params(2) = _divcode

            Dim _bdyear As New SqlParameter("@bdyear", SqlDbType.Char, 4)
            _bdyear.Direction = ParameterDirection.Input
            _bdyear.Value = Trim(_sValue(3))
            Params(3) = _bdyear

            Dim _bdmonth As New SqlParameter("@bdmonth", SqlDbType.Char, 2)
            _bdmonth.Direction = ParameterDirection.Input
            _bdmonth.Value = Trim(_sValue(4))
            Params(4) = _bdmonth

            If Me.xMyDataSets.sp_distributorbudgetdirect_validation_entry.Count > 0 Then _
                Me.xMyDataSets.sp_distributorbudgetdirect_validation_entry.Clear()

            Try
                BusinessObject.Sub_Show(ServerPath, "sp_distributorbudgetdirect_validation_entry", CommandType.StoredProcedure, _
                    xMyDataSets, "sp_distributorbudgetdirect_validation_entry", Params)

                Me.DataGridValidationEntry.DataSource = Me.xMyDataSets.sp_distributorbudgetdirect_validation_entry
                Dim _iCount As Integer = Me.xMyDataSets.sp_distributorbudgetdirect_validation_entry.Rows.Count

                If _iCount > 0 Then
                    With DataGridValidationEntry
                        If Not Trim(.Item(.CurrentCell.RowNumber, 0).ToString) = String.Empty Then
                            MessageBox.Show("The item code [" + Trim(TextBoxItemCode.Text) + "] with division name of [" + ComboBoxDivisionName.Text + "]" & vbNewLine & _
                            "and has a start date [" + Format(CDate(Me.DateTimePickerStartDate.Value), "d") + "] should not have duplicates" & vbNewLine & _
                            "from the existed [" + _sValue(5) + "] Budget Direct list or in the" & vbNewLine & _
                            "Item Budget Direct list.", "Item Duplicated", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            _bConfirmedAllEntry = True
                            Exit Sub

                        Else
                            MessageBox.Show("The item code [" + Trim(TextBoxItemCode.Text) + "] with division name of [" + ComboBoxDivisionName.Text + "]" & vbNewLine & _
                            "and has a start date [" + Format(CDate(Me.DateTimePickerStartDate.Value), "d") + "] should not have duplicates" & vbNewLine & _
                            "from the existed [" + _sValue(5) + "] Budget Direct list or in the" & vbNewLine & _
                            "Item Budget Direct list.", "Item Duplicated", _
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            _bConfirmedAllEntry = True
                            Exit Sub
                        End If
                    End With
                Else
                    _bConfirmedAllEntry = False
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ClearEntry()
        'TextBoxDivisionName.Text = String.Empty ***removed due to change object to dynamically
        ComboBoxDivisionName.SelectedIndex = 0
        TextBoxItemCode.Text = String.Empty
        TextBoxItemDescription.Text = String.Empty
        TextBoxQuantity.Text = String.Empty
        TextBoxAmount.Text = String.Empty
        'DateTimePickerStartDate.Value = GetFirstDayOfMonth(Date.Today())
        'DateTimePickerEndDate.Value = GetLastDayOfMonth(Date.Today())
    End Sub

    Private Sub ButtonEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles ButtonEdit.Click

    End Sub

    Public Sub UpdateItem(ByVal _arrayValues() As String)
        Dim _array As String() = _arrayValues

        Me.TextBoxItemCode.Text = _array(0).ToString
        Me.TextBoxItemDescription.Text = _array(1).ToString
        Me.TextBoxQuantity.Text = _array(2).ToString
        Me.TextBoxAmount.Text = _array(3).ToString
        Me.DateTimePickerStartDate.Value = CDate(_array(4).ToString)
        Me.DateTimePickerEndDate.Value = CDate(_array(5).ToString)
        Me.ComboBoxDivisionName.Text = _array(6).ToString

        'For Each _sValues As String In _array
        '    _array = New String() {_sValues.ToString()}
        'Next

        'For _i As Integer = 0 To _arrayValues.Length - 1
        '    _array = New String() {_arrayValues(_i).ToString}
        'Next _i
    End Sub

End Class
