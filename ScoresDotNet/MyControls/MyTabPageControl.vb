Public Class MyTabPageControl
    Inherits System.Windows.Forms.UserControl

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        'Me.DistributorList()
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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TextBoxAmount As System.Windows.Forms.TextBox
    Friend WithEvents LabelAmount As System.Windows.Forms.Label
    Friend WithEvents TextBoxQuantity As System.Windows.Forms.TextBox
    Friend WithEvents LabelQuantity As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBoxItemDesc As System.Windows.Forms.TextBox
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents LabelEndDate As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelStartDate As System.Windows.Forms.Label
    Friend WithEvents LabelItemDesc As System.Windows.Forms.Label
    Friend WithEvents TextBoxItemCode As System.Windows.Forms.TextBox
    Friend WithEvents LabelItemCode As System.Windows.Forms.Label
    Friend WithEvents TextBoxDivisionName As System.Windows.Forms.TextBox
    Friend WithEvents LabelDivisionName As System.Windows.Forms.Label
    Friend WithEvents ButtonEdit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGridDistributorList As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.DataGridDistributorList = New System.Windows.Forms.DataGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBoxAmount = New System.Windows.Forms.TextBox
        Me.LabelAmount = New System.Windows.Forms.Label
        Me.TextBoxQuantity = New System.Windows.Forms.TextBox
        Me.LabelQuantity = New System.Windows.Forms.Label
        Me.DateTimePickerStartDate = New System.Windows.Forms.DateTimePicker
        Me.TextBoxItemDesc = New System.Windows.Forms.TextBox
        Me.ButtonDelete = New System.Windows.Forms.Button
        Me.ButtonSave = New System.Windows.Forms.Button
        Me.ButtonClear = New System.Windows.Forms.Button
        Me.LabelEndDate = New System.Windows.Forms.Label
        Me.DateTimePickerEndDate = New System.Windows.Forms.DateTimePicker
        Me.LabelStartDate = New System.Windows.Forms.Label
        Me.LabelItemDesc = New System.Windows.Forms.Label
        Me.TextBoxItemCode = New System.Windows.Forms.TextBox
        Me.LabelItemCode = New System.Windows.Forms.Label
        Me.TextBoxDivisionName = New System.Windows.Forms.TextBox
        Me.LabelDivisionName = New System.Windows.Forms.Label
        Me.ButtonEdit = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridDistributorList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.DockPadding.Top = 2
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(341, 273)
        Me.Panel1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(0, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(342, 271)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridDistributorList)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.TextBoxAmount)
        Me.TabPage1.Controls.Add(Me.LabelAmount)
        Me.TabPage1.Controls.Add(Me.TextBoxQuantity)
        Me.TabPage1.Controls.Add(Me.LabelQuantity)
        Me.TabPage1.Controls.Add(Me.DateTimePickerStartDate)
        Me.TabPage1.Controls.Add(Me.TextBoxItemDesc)
        Me.TabPage1.Controls.Add(Me.ButtonDelete)
        Me.TabPage1.Controls.Add(Me.ButtonSave)
        Me.TabPage1.Controls.Add(Me.ButtonClear)
        Me.TabPage1.Controls.Add(Me.LabelEndDate)
        Me.TabPage1.Controls.Add(Me.DateTimePickerEndDate)
        Me.TabPage1.Controls.Add(Me.LabelStartDate)
        Me.TabPage1.Controls.Add(Me.LabelItemDesc)
        Me.TabPage1.Controls.Add(Me.TextBoxItemCode)
        Me.TabPage1.Controls.Add(Me.LabelItemCode)
        Me.TabPage1.Controls.Add(Me.TextBoxDivisionName)
        Me.TabPage1.Controls.Add(Me.LabelDivisionName)
        Me.TabPage1.Controls.Add(Me.ButtonEdit)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(334, 245)
        Me.TabPage1.TabIndex = 0
        '
        'DataGridDistributorList
        '
        Me.DataGridDistributorList.DataMember = ""
        Me.DataGridDistributorList.Enabled = False
        Me.DataGridDistributorList.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridDistributorList.Location = New System.Drawing.Point(272, 160)
        Me.DataGridDistributorList.Name = "DataGridDistributorList"
        Me.DataGridDistributorList.Size = New System.Drawing.Size(40, 16)
        Me.DataGridDistributorList.TabIndex = 46
        Me.DataGridDistributorList.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Amount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 17)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 17)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "End Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 17)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Start Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 17)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Item Desc"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 17)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Item Code"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 17)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Division Name"
        '
        'TextBoxAmount
        '
        Me.TextBoxAmount.Location = New System.Drawing.Point(85, 115)
        Me.TextBoxAmount.MaxLength = 13
        Me.TextBoxAmount.Name = "TextBoxAmount"
        Me.TextBoxAmount.Size = New System.Drawing.Size(128, 21)
        Me.TextBoxAmount.TabIndex = 21
        Me.TextBoxAmount.Text = ""
        '
        'LabelAmount
        '
        Me.LabelAmount.AutoSize = True
        Me.LabelAmount.Location = New System.Drawing.Point(79, 128)
        Me.LabelAmount.Name = "LabelAmount"
        Me.LabelAmount.Size = New System.Drawing.Size(0, 17)
        Me.LabelAmount.TabIndex = 38
        '
        'TextBoxQuantity
        '
        Me.TextBoxQuantity.Location = New System.Drawing.Point(85, 91)
        Me.TextBoxQuantity.MaxLength = 11
        Me.TextBoxQuantity.Name = "TextBoxQuantity"
        Me.TextBoxQuantity.Size = New System.Drawing.Size(128, 21)
        Me.TextBoxQuantity.TabIndex = 37
        Me.TextBoxQuantity.Text = ""
        '
        'LabelQuantity
        '
        Me.LabelQuantity.AutoSize = True
        Me.LabelQuantity.Location = New System.Drawing.Point(32, 95)
        Me.LabelQuantity.Name = "LabelQuantity"
        Me.LabelQuantity.Size = New System.Drawing.Size(0, 17)
        Me.LabelQuantity.TabIndex = 36
        '
        'DateTimePickerStartDate
        '
        Me.DateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePickerStartDate.Location = New System.Drawing.Point(85, 139)
        Me.DateTimePickerStartDate.MaxDate = New Date(2078, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerStartDate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerStartDate.Name = "DateTimePickerStartDate"
        Me.DateTimePickerStartDate.Size = New System.Drawing.Size(120, 21)
        Me.DateTimePickerStartDate.TabIndex = 35
        Me.DateTimePickerStartDate.Value = New Date(2013, 1, 28, 16, 55, 29, 197)
        '
        'TextBoxItemDesc
        '
        Me.TextBoxItemDesc.Location = New System.Drawing.Point(85, 67)
        Me.TextBoxItemDesc.MaxLength = 150
        Me.TextBoxItemDesc.Name = "TextBoxItemDesc"
        Me.TextBoxItemDesc.Size = New System.Drawing.Size(243, 21)
        Me.TextBoxItemDesc.TabIndex = 34
        Me.TextBoxItemDesc.Text = ""
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(178, 203)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(65, 23)
        Me.ButtonDelete.TabIndex = 32
        Me.ButtonDelete.Text = "&Delete"
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(40, 203)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(65, 23)
        Me.ButtonSave.TabIndex = 22
        Me.ButtonSave.Text = "&Save"
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(247, 203)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(65, 23)
        Me.ButtonClear.TabIndex = 23
        Me.ButtonClear.Text = "&Clear"
        '
        'LabelEndDate
        '
        Me.LabelEndDate.AutoSize = True
        Me.LabelEndDate.Location = New System.Drawing.Point(29, 165)
        Me.LabelEndDate.Name = "LabelEndDate"
        Me.LabelEndDate.Size = New System.Drawing.Size(0, 17)
        Me.LabelEndDate.TabIndex = 31
        '
        'DateTimePickerEndDate
        '
        Me.DateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePickerEndDate.Location = New System.Drawing.Point(85, 163)
        Me.DateTimePickerEndDate.MaxDate = New Date(2078, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerEndDate.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerEndDate.Name = "DateTimePickerEndDate"
        Me.DateTimePickerEndDate.Size = New System.Drawing.Size(120, 21)
        Me.DateTimePickerEndDate.TabIndex = 30
        Me.DateTimePickerEndDate.Value = New Date(2013, 1, 28, 16, 55, 29, 244)
        '
        'LabelStartDate
        '
        Me.LabelStartDate.AutoSize = True
        Me.LabelStartDate.Location = New System.Drawing.Point(20, 143)
        Me.LabelStartDate.Name = "LabelStartDate"
        Me.LabelStartDate.Size = New System.Drawing.Size(0, 17)
        Me.LabelStartDate.TabIndex = 29
        '
        'LabelItemDesc
        '
        Me.LabelItemDesc.AutoSize = True
        Me.LabelItemDesc.Location = New System.Drawing.Point(24, 71)
        Me.LabelItemDesc.Name = "LabelItemDesc"
        Me.LabelItemDesc.Size = New System.Drawing.Size(0, 17)
        Me.LabelItemDesc.TabIndex = 28
        '
        'TextBoxItemCode
        '
        Me.TextBoxItemCode.Location = New System.Drawing.Point(85, 43)
        Me.TextBoxItemCode.MaxLength = 10
        Me.TextBoxItemCode.Name = "TextBoxItemCode"
        Me.TextBoxItemCode.Size = New System.Drawing.Size(128, 21)
        Me.TextBoxItemCode.TabIndex = 27
        Me.TextBoxItemCode.Text = ""
        '
        'LabelItemCode
        '
        Me.LabelItemCode.AutoSize = True
        Me.LabelItemCode.Location = New System.Drawing.Point(23, 46)
        Me.LabelItemCode.Name = "LabelItemCode"
        Me.LabelItemCode.Size = New System.Drawing.Size(0, 17)
        Me.LabelItemCode.TabIndex = 26
        '
        'TextBoxDivisionName
        '
        Me.TextBoxDivisionName.Location = New System.Drawing.Point(85, 19)
        Me.TextBoxDivisionName.MaxLength = 50
        Me.TextBoxDivisionName.Name = "TextBoxDivisionName"
        Me.TextBoxDivisionName.Size = New System.Drawing.Size(128, 21)
        Me.TextBoxDivisionName.TabIndex = 25
        Me.TextBoxDivisionName.Text = ""
        '
        'LabelDivisionName
        '
        Me.LabelDivisionName.AutoSize = True
        Me.LabelDivisionName.Location = New System.Drawing.Point(4, 23)
        Me.LabelDivisionName.Name = "LabelDivisionName"
        Me.LabelDivisionName.Size = New System.Drawing.Size(0, 17)
        Me.LabelDivisionName.TabIndex = 24
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Location = New System.Drawing.Point(109, 203)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(65, 23)
        Me.ButtonEdit.TabIndex = 33
        Me.ButtonEdit.Text = "&Edit"
        '
        'MyTabPageControl
        '
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MyTabPageControl"
        Me.Size = New System.Drawing.Size(341, 273)
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridDistributorList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private MyCodeTableDS As New CodeTablesDS
    Private BusinessObject As New BusinessLayer.clsFileMaintenance
    Private _s0, _s1 As String

    Private Sub DistributorList()
        Me.Cursor = Cursors.WaitCursor
        Dim _DT As DataTable = New DataTable
        Dim _DR As DataRow

        If MyCodeTableDS.sp_distributor_list.Count > 0 Then MyCodeTableDS.sp_distributor_list.Clear()

        Try
            BusinessObject.Sub_Show(ServerPath, "sp_distributor_list", CommandType.StoredProcedure, _
                MyCodeTableDS, "sp_distributor_list")

            DataGridDistributorList.DataSource = MyCodeTableDS.sp_distributor_list
            Me.DistributorTabPages()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub DistributorTabPages()
        Dim _iRow As Integer = MyCodeTableDS.sp_distributor_list.Rows.Count
        Dim myTabPage As TabPage

        If _iRow <> 0 Then
            For _i As Integer = 0 To _iRow - 1
                With DataGridDistributorList
                    _s0 = Trim(.Item(_i, 0).ToString)
                    _s1 = Trim(.Item(_i, 1).ToString)
                End With
                Me.DistributorLoadTabPages(_s0, _s1)
            Next _i
        End If
    End Sub

    Private Sub DistributorLoadTabPages(ByVal _sValue0 As String, ByVal _sValue1 As String)
        Dim myTabPage As New TabPage


        myTabPage.Name = _sValue0 'tabpage code
        myTabPage.Text = _sValue1 'tabpage name

        'myTabControl.TabControl1.TabPages.Add(myTabPage)

        TabControl1.TabPages.Add(myTabPage)

        'TabControl1.Visible = False

        'TabControl1.TabPages.AddRange(New TabPage() {myTabPage})
        '_iTab = TabControl1.TabCount()
        'MsgBox(TabControl1.TabCount().ToString())

        'With TabControl1
        '    For Each myTabPage In TabControl1.TabPages
        '        With myTabPage
        '            'MsgBox(.Name.ToString())

        '        End With
        '    Next
        'End With
    End Sub

End Class
