Imports System.Data.SqlClient
Public Class frmBudgetDirectPerDistributorUpdate
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
    Friend WithEvents DateTimePickerEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBoxAmount As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxQuantity As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxItemDescription As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxItemCode As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDivisionName As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents TextBoxDistributorCode As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ButtonClear = New System.Windows.Forms.Button
        Me.ButtonSave = New System.Windows.Forms.Button
        Me.DateTimePickerEndDate = New System.Windows.Forms.DateTimePicker
        Me.DateTimePickerStartDate = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.TextBoxAmount = New System.Windows.Forms.TextBox
        Me.TextBoxQuantity = New System.Windows.Forms.TextBox
        Me.TextBoxItemDescription = New System.Windows.Forms.TextBox
        Me.TextBoxItemCode = New System.Windows.Forms.TextBox
        Me.TextBoxDivisionName = New System.Windows.Forms.TextBox
        Me.TextBoxDistributorCode = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(304, 213)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxDistributorCode)
        Me.GroupBox1.Controls.Add(Me.ButtonClear)
        Me.GroupBox1.Controls.Add(Me.ButtonSave)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerEndDate)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerStartDate)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.TextBoxAmount)
        Me.GroupBox1.Controls.Add(Me.TextBoxQuantity)
        Me.GroupBox1.Controls.Add(Me.TextBoxItemDescription)
        Me.GroupBox1.Controls.Add(Me.TextBoxItemCode)
        Me.GroupBox1.Controls.Add(Me.TextBoxDivisionName)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 213)
        Me.GroupBox1.TabIndex = 98
        Me.GroupBox1.TabStop = False
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(163, 176)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.TabIndex = 9
        Me.ButtonClear.Text = "&Clear"
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(88, 176)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.TabIndex = 8
        Me.ButtonSave.Text = "&Save"
        '
        'DateTimePickerEndDate
        '
        Me.DateTimePickerEndDate.Enabled = False
        Me.DateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePickerEndDate.Location = New System.Drawing.Point(88, 142)
        Me.DateTimePickerEndDate.MaxDate = New Date(2078, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerEndDate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerEndDate.Name = "DateTimePickerEndDate"
        Me.DateTimePickerEndDate.Size = New System.Drawing.Size(120, 21)
        Me.DateTimePickerEndDate.TabIndex = 7
        '
        'DateTimePickerStartDate
        '
        Me.DateTimePickerStartDate.Enabled = False
        Me.DateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePickerStartDate.Location = New System.Drawing.Point(88, 121)
        Me.DateTimePickerStartDate.MaxDate = New Date(2078, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerStartDate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerStartDate.Name = "DateTimePickerStartDate"
        Me.DateTimePickerStartDate.Size = New System.Drawing.Size(120, 21)
        Me.DateTimePickerStartDate.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(40, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 17)
        Me.Label8.TabIndex = 102
        Me.Label8.Text = "Amount"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(36, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 17)
        Me.Label9.TabIndex = 103
        Me.Label9.Text = "Quantity"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(33, 144)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 17)
        Me.Label10.TabIndex = 104
        Me.Label10.Text = "End Date"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(28, 123)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 17)
        Me.Label11.TabIndex = 98
        Me.Label11.Text = "Start Date"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(28, 60)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 17)
        Me.Label12.TabIndex = 97
        Me.Label12.Text = "Item Desc"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(27, 39)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 17)
        Me.Label13.TabIndex = 96
        Me.Label13.Text = "Item Code"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 17)
        Me.Label14.TabIndex = 101
        Me.Label14.Text = "Division Name"
        '
        'TextBoxAmount
        '
        Me.TextBoxAmount.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TextBoxAmount.Location = New System.Drawing.Point(88, 100)
        Me.TextBoxAmount.MaxLength = 15
        Me.TextBoxAmount.Name = "TextBoxAmount"
        Me.TextBoxAmount.Size = New System.Drawing.Size(120, 21)
        Me.TextBoxAmount.TabIndex = 5
        Me.TextBoxAmount.Text = ""
        '
        'TextBoxQuantity
        '
        Me.TextBoxQuantity.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TextBoxQuantity.Location = New System.Drawing.Point(88, 79)
        Me.TextBoxQuantity.MaxLength = 11
        Me.TextBoxQuantity.Name = "TextBoxQuantity"
        Me.TextBoxQuantity.Size = New System.Drawing.Size(120, 21)
        Me.TextBoxQuantity.TabIndex = 4
        Me.TextBoxQuantity.Text = ""
        '
        'TextBoxItemDescription
        '
        Me.TextBoxItemDescription.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxItemDescription.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBoxItemDescription.Location = New System.Drawing.Point(88, 58)
        Me.TextBoxItemDescription.Name = "TextBoxItemDescription"
        Me.TextBoxItemDescription.ReadOnly = True
        Me.TextBoxItemDescription.Size = New System.Drawing.Size(207, 21)
        Me.TextBoxItemDescription.TabIndex = 3
        Me.TextBoxItemDescription.Text = ""
        '
        'TextBoxItemCode
        '
        Me.TextBoxItemCode.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxItemCode.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBoxItemCode.Location = New System.Drawing.Point(88, 37)
        Me.TextBoxItemCode.Name = "TextBoxItemCode"
        Me.TextBoxItemCode.ReadOnly = True
        Me.TextBoxItemCode.Size = New System.Drawing.Size(207, 21)
        Me.TextBoxItemCode.TabIndex = 2
        Me.TextBoxItemCode.Text = ""
        '
        'TextBoxDivisionName
        '
        Me.TextBoxDivisionName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDivisionName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBoxDivisionName.Location = New System.Drawing.Point(88, 16)
        Me.TextBoxDivisionName.Name = "TextBoxDivisionName"
        Me.TextBoxDivisionName.ReadOnly = True
        Me.TextBoxDivisionName.Size = New System.Drawing.Size(207, 21)
        Me.TextBoxDivisionName.TabIndex = 1
        Me.TextBoxDivisionName.Text = ""
        '
        'TextBoxDistributorCode
        '
        Me.TextBoxDistributorCode.Enabled = False
        Me.TextBoxDistributorCode.Location = New System.Drawing.Point(208, 79)
        Me.TextBoxDistributorCode.Name = "TextBoxDistributorCode"
        Me.TextBoxDistributorCode.ReadOnly = True
        Me.TextBoxDistributorCode.Size = New System.Drawing.Size(24, 21)
        Me.TextBoxDistributorCode.TabIndex = 105
        Me.TextBoxDistributorCode.Text = ""
        Me.TextBoxDistributorCode.Visible = False
        '
        'frmBudgetDirectPerDistributorUpdate
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(304, 213)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmBudgetDirectPerDistributorUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Budget Direct Per Distributor Update"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private xMyDataSets As New MyDataSets
    Private BusinessObject As New BusinessLayer.clsFileMaintenance

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

    Private Sub ButtonSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles ButtonSave.Click
        Dim Params(7) As SqlParameter

        If Me.TextBoxQuantity.Text = String.Empty Or _
            Me.TextBoxAmount.Text = String.Empty Then
            Return
        Else
            If (MessageBox.Show("You're about to update this entry! Click Yes if you want to proceed.", "Updating", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, _
                        MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then

                Try
                    Dim _distributorcode As New SqlParameter("@distributorcode", SqlDbType.VarChar, 5)
                    _distributorcode.Direction = ParameterDirection.Input
                    _distributorcode.Value = Trim(Me.TextBoxDistributorCode.Text)
                    Params(0) = _distributorcode

                    Dim _itemcode As New SqlParameter("@itemcode", SqlDbType.Char, 10)
                    _itemcode.Direction = ParameterDirection.Input
                    _itemcode.Value = Trim(TextBoxItemCode.Text)
                    Params(1) = _itemcode

                    Dim _quantity As New SqlParameter("@quantity", SqlDbType.Decimal, 9)
                    _quantity.Direction = ParameterDirection.Input
                    _quantity.Value = Decimal.Parse(Trim(TextBoxQuantity.Text))
                    Params(2) = _quantity

                    Dim _amount As New SqlParameter("@amount", SqlDbType.Money)
                    _amount.Direction = ParameterDirection.Input
                    _amount.Value = Decimal.Parse(Trim(TextBoxAmount.Text))
                    Params(3) = _amount

                    Dim _startdate As New SqlParameter("@startdate", SqlDbType.DateTime)
                    _startdate.Direction = ParameterDirection.Input
                    _startdate.Value = DateTimePickerStartDate.Value.ToString()
                    Params(4) = _startdate

                    Dim _endate As New SqlParameter("@endate", SqlDbType.DateTime)
                    _endate.Direction = ParameterDirection.Input
                    _endate.Value = DateTimePickerEndDate.Value.ToString()
                    Params(5) = _endate

                    Dim _modifieddate As New SqlParameter("@modifieddate", SqlDbType.DateTime)
                    _modifieddate.Direction = ParameterDirection.Input
                    _modifieddate.Value = GetDateTimeNow()
                    Params(6) = _modifieddate

                    Dim _lastuser As New SqlParameter("@lastuser", SqlDbType.Char, 10)
                    _lastuser.Direction = ParameterDirection.Input
                    _lastuser.Value = UCase(Trim(gUserID))
                    Params(7) = _lastuser

                    Try
                        BusinessObject.Sub_Insert(ServerPath, "sp_distributorbudgetdirect_update", CommandType.StoredProcedure, Params)
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
    End Sub

    Private Sub ButtonClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles ButtonClear.Click
        Me.ClearEntry()
    End Sub

    Private Sub ClearEntry()
        Me.TextBoxQuantity.Text = String.Empty
        Me.TextBoxAmount.Text = String.Empty
    End Sub

End Class
