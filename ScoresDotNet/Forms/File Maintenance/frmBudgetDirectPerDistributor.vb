Imports System.Data.SqlClient

Public Class frmBudgetDirectPerDistributor
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
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxBudgetDirectPerYear As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxBudgetDirectPerMonth As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridItemList As System.Windows.Forms.DataGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LabelTotalQtyPerMonth As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LabelTotalAmtPerMonth As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents DataGridDistributorList As System.Windows.Forms.DataGrid
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents TabControlDistributor As System.Windows.Forms.TabControl
    Friend WithEvents DataGridDistributorBudgetDirectList As System.Windows.Forms.DataGrid
    Friend WithEvents LabelTotalAmtPerYTD As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Splitter2 = New System.Windows.Forms.Splitter
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.ButtonDelete = New System.Windows.Forms.Button
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.DataGridDistributorBudgetDirectList = New System.Windows.Forms.DataGrid
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.TabControlDistributor = New System.Windows.Forms.TabControl
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DataGridItemList = New System.Windows.Forms.DataGrid
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LabelTotalAmtPerYTD = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.LabelTotalAmtPerMonth = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.LabelTotalQtyPerMonth = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ComboBoxBudgetDirectPerMonth = New System.Windows.Forms.ComboBox
        Me.ComboBoxBudgetDirectPerYear = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridDistributorList = New System.Windows.Forms.DataGrid
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.DataGridDistributorBudgetDirectList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridDistributorList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Splitter1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 565)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.GroupBox3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.DockPadding.Bottom = 5
        Me.Panel4.DockPadding.Left = 5
        Me.Panel4.DockPadding.Right = 5
        Me.Panel4.DockPadding.Top = 2
        Me.Panel4.Location = New System.Drawing.Point(0, 266)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(780, 295)
        Me.Panel4.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Splitter2)
        Me.GroupBox3.Controls.Add(Me.Panel6)
        Me.GroupBox3.Controls.Add(Me.Panel5)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(5, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(770, 288)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Distributor Budget Direct"
        '
        'Splitter2
        '
        Me.Splitter2.Location = New System.Drawing.Point(360, 17)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(2, 268)
        Me.Splitter2.TabIndex = 0
        Me.Splitter2.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.GroupBox4)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.DockPadding.Bottom = 5
        Me.Panel6.DockPadding.Left = 5
        Me.Panel6.DockPadding.Right = 5
        Me.Panel6.Location = New System.Drawing.Point(360, 17)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(407, 268)
        Me.Panel6.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Panel9)
        Me.GroupBox4.Controls.Add(Me.Panel7)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(5, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(397, 263)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.ButtonDelete)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(3, 216)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(391, 44)
        Me.Panel9.TabIndex = 18
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(11, 9)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.TabIndex = 1
        Me.ButtonDelete.Text = "&Delete"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.DataGridDistributorBudgetDirectList)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(3, 17)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(391, 199)
        Me.Panel7.TabIndex = 17
        '
        'DataGridDistributorBudgetDirectList
        '
        Me.DataGridDistributorBudgetDirectList.AlternatingBackColor = System.Drawing.Color.Beige
        Me.DataGridDistributorBudgetDirectList.CaptionText = "Distributor Budget Direct List View"
        Me.DataGridDistributorBudgetDirectList.DataMember = ""
        Me.DataGridDistributorBudgetDirectList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridDistributorBudgetDirectList.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridDistributorBudgetDirectList.Location = New System.Drawing.Point(0, 0)
        Me.DataGridDistributorBudgetDirectList.Name = "DataGridDistributorBudgetDirectList"
        Me.DataGridDistributorBudgetDirectList.PreferredColumnWidth = 100
        Me.DataGridDistributorBudgetDirectList.ReadOnly = True
        Me.DataGridDistributorBudgetDirectList.Size = New System.Drawing.Size(391, 199)
        Me.DataGridDistributorBudgetDirectList.TabIndex = 16
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GroupBox5)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.DockPadding.Bottom = 5
        Me.Panel5.DockPadding.Left = 5
        Me.Panel5.DockPadding.Right = 5
        Me.Panel5.DockPadding.Top = 2
        Me.Panel5.Location = New System.Drawing.Point(3, 17)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(357, 268)
        Me.Panel5.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Panel8)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Location = New System.Drawing.Point(5, 2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(347, 261)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Budget Direct Item(s) Entry"
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.TabControlDistributor)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.DockPadding.Top = 2
        Me.Panel8.Location = New System.Drawing.Point(3, 17)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(341, 241)
        Me.Panel8.TabIndex = 1
        '
        'TabControlDistributor
        '
        Me.TabControlDistributor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlDistributor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlDistributor.Location = New System.Drawing.Point(0, 2)
        Me.TabControlDistributor.Name = "TabControlDistributor"
        Me.TabControlDistributor.SelectedIndex = 0
        Me.TabControlDistributor.Size = New System.Drawing.Size(341, 239)
        Me.TabControlDistributor.TabIndex = 4
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.SystemColors.Control
        Me.Splitter1.Cursor = System.Windows.Forms.Cursors.HSplit
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 264)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(780, 2)
        Me.Splitter1.TabIndex = 0
        Me.Splitter1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.DockPadding.Bottom = 5
        Me.Panel3.DockPadding.Left = 5
        Me.Panel3.DockPadding.Right = 5
        Me.Panel3.DockPadding.Top = 2
        Me.Panel3.Location = New System.Drawing.Point(0, 120)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(780, 144)
        Me.Panel3.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridItemList)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(5, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(770, 137)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'DataGridItemList
        '
        Me.DataGridItemList.AlternatingBackColor = System.Drawing.Color.Beige
        Me.DataGridItemList.CaptionText = "Item Budget Direct List View"
        Me.DataGridItemList.DataMember = ""
        Me.DataGridItemList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridItemList.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridItemList.Location = New System.Drawing.Point(3, 17)
        Me.DataGridItemList.Name = "DataGridItemList"
        Me.DataGridItemList.PreferredColumnWidth = 100
        Me.DataGridItemList.ReadOnly = True
        Me.DataGridItemList.RowHeadersVisible = False
        Me.DataGridItemList.Size = New System.Drawing.Size(764, 117)
        Me.DataGridItemList.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.DockPadding.Bottom = 5
        Me.Panel2.DockPadding.Left = 5
        Me.Panel2.DockPadding.Right = 5
        Me.Panel2.DockPadding.Top = 2
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(780, 120)
        Me.Panel2.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelTotalAmtPerYTD)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.LabelTotalAmtPerMonth)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.LabelTotalQtyPerMonth)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboBoxBudgetDirectPerMonth)
        Me.GroupBox1.Controls.Add(Me.ComboBoxBudgetDirectPerYear)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DataGridDistributorList)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(5, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(770, 113)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Budget Direct Year and Month Selections"
        '
        'LabelTotalAmtPerYTD
        '
        Me.LabelTotalAmtPerYTD.AutoSize = True
        Me.LabelTotalAmtPerYTD.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalAmtPerYTD.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LabelTotalAmtPerYTD.Location = New System.Drawing.Point(400, 86)
        Me.LabelTotalAmtPerYTD.Name = "LabelTotalAmtPerYTD"
        Me.LabelTotalAmtPerYTD.Size = New System.Drawing.Size(0, 17)
        Me.LabelTotalAmtPerYTD.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(319, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Total Amt YTD:"
        '
        'LabelTotalAmtPerMonth
        '
        Me.LabelTotalAmtPerMonth.AutoSize = True
        Me.LabelTotalAmtPerMonth.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalAmtPerMonth.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LabelTotalAmtPerMonth.Location = New System.Drawing.Point(400, 59)
        Me.LabelTotalAmtPerMonth.Name = "LabelTotalAmtPerMonth"
        Me.LabelTotalAmtPerMonth.Size = New System.Drawing.Size(0, 17)
        Me.LabelTotalAmtPerMonth.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(288, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Total Amt Per Month:"
        '
        'LabelTotalQtyPerMonth
        '
        Me.LabelTotalQtyPerMonth.AutoSize = True
        Me.LabelTotalQtyPerMonth.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalQtyPerMonth.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LabelTotalQtyPerMonth.Location = New System.Drawing.Point(400, 32)
        Me.LabelTotalQtyPerMonth.Name = "LabelTotalQtyPerMonth"
        Me.LabelTotalQtyPerMonth.Size = New System.Drawing.Size(0, 17)
        Me.LabelTotalQtyPerMonth.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(291, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Total Qty Per Month:"
        '
        'ComboBoxBudgetDirectPerMonth
        '
        Me.ComboBoxBudgetDirectPerMonth.Enabled = False
        Me.ComboBoxBudgetDirectPerMonth.Location = New System.Drawing.Point(144, 64)
        Me.ComboBoxBudgetDirectPerMonth.MaxDropDownItems = 13
        Me.ComboBoxBudgetDirectPerMonth.Name = "ComboBoxBudgetDirectPerMonth"
        Me.ComboBoxBudgetDirectPerMonth.Size = New System.Drawing.Size(130, 21)
        Me.ComboBoxBudgetDirectPerMonth.TabIndex = 2
        '
        'ComboBoxBudgetDirectPerYear
        '
        Me.ComboBoxBudgetDirectPerYear.Location = New System.Drawing.Point(8, 64)
        Me.ComboBoxBudgetDirectPerYear.MaxDropDownItems = 13
        Me.ComboBoxBudgetDirectPerYear.Name = "ComboBoxBudgetDirectPerYear"
        Me.ComboBoxBudgetDirectPerYear.Size = New System.Drawing.Size(130, 21)
        Me.ComboBoxBudgetDirectPerYear.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Budget Direct Per-Year"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(144, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Budget Direct Per-Month"
        '
        'DataGridDistributorList
        '
        Me.DataGridDistributorList.DataMember = ""
        Me.DataGridDistributorList.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridDistributorList.Location = New System.Drawing.Point(730, 56)
        Me.DataGridDistributorList.Name = "DataGridDistributorList"
        Me.DataGridDistributorList.Size = New System.Drawing.Size(32, 16)
        Me.DataGridDistributorList.TabIndex = 0
        Me.DataGridDistributorList.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox6.Location = New System.Drawing.Point(280, 17)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(487, 93)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox7.Location = New System.Drawing.Point(3, 17)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(277, 93)
        Me.GroupBox7.TabIndex = 4
        Me.GroupBox7.TabStop = False
        '
        'frmBudgetDirectPerDistributor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(784, 565)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmBudgetDirectPerDistributor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Budget Direct Per-Distributor"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.DataGridDistributorBudgetDirectList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridItemList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridDistributorList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private MyCodeTableDS As New CodeTablesDS
    Private xMyDataSets As New MyDataSets
    Private BusinessObject As New BusinessLayer.clsFileMaintenance
    Private _s0, _s1 As String
    Delegate Sub deMyEvent(ByVal _sArray() As String)
    Public Event _eMyEvent As deMyEvent
    Private WithEvents _xEventForm As New frmBudgetDirectPerDistributorUpdate

    Private Sub frmBudgetDirectPerDistributor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles MyBase.Load
        Me.BudgetDirectPerYearSelections()
        Me.BudgetDirectPerMonthSelections()
        Me.DistributorList()
        'MsgBox(GetDateTimeNow())
    End Sub

    Private Sub DistributorList()
        Me.Cursor = Cursors.WaitCursor
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
        Dim myTabPage As New MyTabPageClass
        myTabPage.Name = _sValue0 'tabpage code
        myTabPage.Text = _sValue1 'tabpage name 
        Me.TabControlDistributor.TabPages.Add(myTabPage)
    End Sub

    Private Sub BudgetDirectPerYearSelections()
        Me.Cursor = Cursors.WaitCursor
        Dim _DT As DataTable = New DataTable
        Dim _DR As DataRow

        If MyCodeTableDS.sp_budget_direct_year.Count > 0 Then MyCodeTableDS.sp_budget_direct_year.Clear()

        Try
            BusinessObject.Sub_Show(ServerPath, "sp_budget_direct_year", CommandType.StoredProcedure, _
                MyCodeTableDS, "sp_budget_direct_year")

            _DT = MyCodeTableDS.sp_budget_direct_year
            _DR = _DT.NewRow()

            _DR(0) = "<- Select Year ->"
            _DT.Rows.InsertAt(_DR, 0)

            With ComboBoxBudgetDirectPerYear
                .DataSource = _DT
                .DisplayMember = "budget_direct_year"
                .ValueMember = "budget_direct_year"
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BudgetDirectPerMonthSelections()
        Me.Cursor = Cursors.WaitCursor
        Dim _DT As DataTable = New DataTable
        Dim _DR As DataRow

        If MyCodeTableDS.sp_budget_direct_month.Count > 0 Then MyCodeTableDS.sp_budget_direct_month.Clear()

        Try
            BusinessObject.Sub_Show(ServerPath, "sp_budget_direct_month", CommandType.StoredProcedure, _
                MyCodeTableDS, "sp_budget_direct_month")

            _DT = MyCodeTableDS.sp_budget_direct_month
            _DR = _DT.NewRow()

            _DR(1) = "<- Select Month ->"
            _DT.Rows.InsertAt(_DR, 0)

            With ComboBoxBudgetDirectPerMonth
                .DataSource = _DT
                .DisplayMember = "budget_direct_month"
                .ValueMember = "budget_direct_month_code"
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ItemList(ByVal _sValue As String, ByVal _sValue1 As String)
        Me.Cursor = Cursors.WaitCursor
        Dim Params(1) As SqlParameter

        If MyCodeTableDS.sp_item_list.Count > 0 Then MyCodeTableDS.sp_item_list.Clear()

        Try
            Dim _bdyear As New SqlParameter("@bdyear", SqlDbType.Char, 4)
            _bdyear.Direction = ParameterDirection.Input
            _bdyear.Value = Trim(_sValue)
            Params(0) = _bdyear

            Dim _bdmonth As New SqlParameter("@bdmonth", SqlDbType.Char, 2)
            _bdmonth.Direction = ParameterDirection.Input
            _bdmonth.Value = Trim(_sValue1)
            Params(1) = _bdmonth

            Try
                BusinessObject.Sub_Show(ServerPath, "sp_item_list", CommandType.StoredProcedure, _
                    MyCodeTableDS, "sp_item_list", Params)

                DataGridItemList.DataSource = MyCodeTableDS.sp_item_list

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub TotalQtyPerMonth(ByVal _sValue As String, ByVal _sValue1 As String)
        Me.Cursor = Cursors.WaitCursor
        Dim Params(1) As SqlParameter

        If MyCodeTableDS.sp_total_qty_per_month.Count > 0 Then MyCodeTableDS.sp_total_qty_per_month.Clear()

        Try
            Dim _bdyear As New SqlParameter("@bdyear", SqlDbType.Char, 4)
            _bdyear.Direction = ParameterDirection.Input
            _bdyear.Value = Trim(_sValue)
            Params(0) = _bdyear

            Dim _bdmonth As New SqlParameter("@bdmonth", SqlDbType.Char, 2)
            _bdmonth.Direction = ParameterDirection.Input
            _bdmonth.Value = Trim(_sValue1)
            Params(1) = _bdmonth

            Try
                BusinessObject.Sub_Show(ServerPath, "sp_total_qty_per_month", CommandType.StoredProcedure, _
                    MyCodeTableDS, "sp_total_qty_per_month", Params)

                '***check if total qty per month is not empty else nothing to return!!
                If MyCodeTableDS.sp_item_list.Count <> 0 Then
                    LabelTotalQtyPerMonth.Text = Format(CDec(MyCodeTableDS.sp_total_qty_per_month.Compute("SUM(Quantity)", _
                        String.Empty).ToString()), "#,###")
                Else
                    LabelTotalQtyPerMonth.Text = ""
                    LabelTotalAmtPerMonth.Text = ""
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub TotalAmtPerMonth(ByVal _sValue As String, ByVal _sValue1 As String)
        Me.Cursor = Cursors.WaitCursor
        Dim Params(1) As SqlParameter

        If MyCodeTableDS.sp_total_amt_per_month.Count > 0 Then MyCodeTableDS.sp_total_amt_per_month.Clear()

        Try
            Dim _bdyear As New SqlParameter("@bdyear", SqlDbType.Char, 4)
            _bdyear.Direction = ParameterDirection.Input
            _bdyear.Value = Trim(_sValue)
            Params(0) = _bdyear

            Dim _bdmonth As New SqlParameter("@bdmonth", SqlDbType.Char, 2)
            _bdmonth.Direction = ParameterDirection.Input
            _bdmonth.Value = Trim(_sValue1)
            Params(1) = _bdmonth

            Try
                BusinessObject.Sub_Show(ServerPath, "sp_total_amt_per_month", CommandType.StoredProcedure, _
                    MyCodeTableDS, "sp_total_amt_per_month", Params)

                '***check if total amt per month is not empty else nothing to return!!
                If MyCodeTableDS.sp_item_list.Count <> 0 Then
                    LabelTotalAmtPerMonth.Text = Format(CDec(MyCodeTableDS.sp_total_amt_per_month.Compute("SUM(Amount)", _
                        String.Empty).ToString()), "#,###.00")
                Else
                    LabelTotalQtyPerMonth.Text = ""
                    LabelTotalAmtPerMonth.Text = ""
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub TotalAmtPerYTD(ByVal _sValue As String)
        Me.Cursor = Cursors.WaitCursor
        Dim Params(0) As SqlParameter

        If MyCodeTableDS.sp_total_amt_per_ytd.Count > 0 Then MyCodeTableDS.sp_total_amt_per_ytd.Clear()

        Try
            Dim _bdyear As New SqlParameter("@bdyear", SqlDbType.Char, 4)
            _bdyear.Direction = ParameterDirection.Input
            _bdyear.Value = Trim(_sValue)
            Params(0) = _bdyear

            Try
                BusinessObject.Sub_Show(ServerPath, "sp_total_amt_per_ytd", CommandType.StoredProcedure, _
                    MyCodeTableDS, "sp_total_amt_per_ytd", Params)

                LabelTotalAmtPerYTD.Text = Format(CDec(MyCodeTableDS.sp_total_amt_per_ytd.Compute("SUM(Amount)", _
                    String.Empty).ToString()), "#,###.00")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ComboBoxBudgetDirectPerYear_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles ComboBoxBudgetDirectPerYear.SelectionChangeCommitted
        Dim _sSelectedTab, _sComboBoxYear, _sComboBoxMonth As String

        _sSelectedTab = Me.TabControlDistributor.SelectedTab.Name.ToString()
        _sComboBoxYear = Me.ComboBoxBudgetDirectPerYear.SelectedValue.ToString()
        _sComboBoxMonth = Me.ComboBoxBudgetDirectPerMonth.SelectedValue.ToString()

        If ComboBoxBudgetDirectPerYear.SelectedIndex = 0 Then
            LabelTotalAmtPerYTD.Text = ""
            ComboBoxBudgetDirectPerMonth.Enabled = False

            If ComboBoxBudgetDirectPerMonth.SelectedIndex <> 0 Then
                LabelTotalQtyPerMonth.Text = ""
                LabelTotalAmtPerMonth.Text = ""
                ComboBoxBudgetDirectPerMonth.SelectedIndex = 0
                If MyCodeTableDS.sp_item_list.Count >= 0 Then DataGridItemList.DataSource = Nothing
                '***check if distributor budget direct per month is empty then
                '***dispose datagrid else nothing to return
                If Me.MyCodeTableDS.sp_distributorbudgetdirect_list.Count >= 0 Then _
                    Me.DataGridDistributorBudgetDirectList.DataSource = Nothing
            Else
                Return
            End If
        Else
            ComboBoxBudgetDirectPerMonth.Enabled = True

            If ComboBoxBudgetDirectPerMonth.SelectedIndex <> 0 Then
                Me.ItemList(ComboBoxBudgetDirectPerYear.SelectedValue.ToString(), _
                ComboBoxBudgetDirectPerMonth.SelectedValue.ToString())
                Me.DistributorBudgetDirectList(_sSelectedTab, _sComboBoxYear, _sComboBoxMonth)

                If MyCodeTableDS.sp_item_list.Count > 0 Then
                    Me.ItemList(ComboBoxBudgetDirectPerYear.SelectedValue.ToString(), _
                    ComboBoxBudgetDirectPerMonth.SelectedValue.ToString())
                    Me.TotalQtyPerMonth(ComboBoxBudgetDirectPerYear.SelectedValue.ToString(), _
                    ComboBoxBudgetDirectPerMonth.SelectedValue.ToString())
                    Me.TotalAmtPerMonth(ComboBoxBudgetDirectPerYear.SelectedValue.ToString(), _
                    ComboBoxBudgetDirectPerMonth.SelectedValue.ToString())
                    Me.TotalAmtPerYTD(ComboBoxBudgetDirectPerYear.SelectedValue.ToString())
                ElseIf Me.MyCodeTableDS.sp_distributorbudgetdirect_list.Count > 0 Then
                    Me.DistributorBudgetDirectList(_sSelectedTab, _sComboBoxYear, _sComboBoxMonth)
                Else
                    LabelTotalQtyPerMonth.Text = ""
                    LabelTotalAmtPerMonth.Text = ""
                    If MyCodeTableDS.sp_item_list.Count >= 0 Then MyCodeTableDS.sp_item_list.Clear()
                    If Me.MyCodeTableDS.sp_distributorbudgetdirect_list.Count > 0 Then _
                        Me.MyCodeTableDS.sp_distributorbudgetdirect_list.Clear()
                End If
            Else
                Me.TotalAmtPerYTD(ComboBoxBudgetDirectPerYear.SelectedValue.ToString())
            End If
        End If
    End Sub

    Private Sub ComboBoxBudgetDirectPerMonth_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles ComboBoxBudgetDirectPerMonth.SelectionChangeCommitted
        Dim _sSelectedTab, _sComboBoxYear, _sComboBoxMonth As String

        _sSelectedTab = Me.TabControlDistributor.SelectedTab.Name.ToString()
        _sComboBoxYear = Me.ComboBoxBudgetDirectPerYear.SelectedValue.ToString()
        _sComboBoxMonth = Me.ComboBoxBudgetDirectPerMonth.SelectedValue.ToString()

        If ComboBoxBudgetDirectPerMonth.SelectedIndex = 0 Then
            LabelTotalQtyPerMonth.Text = ""
            LabelTotalAmtPerMonth.Text = ""
            If MyCodeTableDS.sp_item_list.Count >= 0 Then DataGridItemList.DataSource = Nothing
            '***check if distributor budget direct per month is empty then
            '***dispose datagrid else nothing to return
            If MyCodeTableDS.sp_distributorbudgetdirect_list.Count >= 0 Then _
                Me.DataGridDistributorBudgetDirectList.DataSource = Nothing
        Else
            If ComboBoxBudgetDirectPerYear.SelectedIndex <> 0 Then
                Me.ItemList(ComboBoxBudgetDirectPerYear.SelectedValue.ToString(), _
                    ComboBoxBudgetDirectPerMonth.SelectedValue.ToString())
                Me.DistributorBudgetDirectList(_sSelectedTab, _sComboBoxYear, _sComboBoxMonth)

                If MyCodeTableDS.sp_item_list.Count = 0 Then
                    LabelTotalQtyPerMonth.Text = ""
                    LabelTotalAmtPerMonth.Text = ""
                    If MyCodeTableDS.sp_item_list.Count > 0 Then MyCodeTableDS.sp_item_list.Clear()
                    'ElseIf MyCodeTableDS.sp_distributorbudgetdirect_list.Count = 0 Then
                    '    MyCodeTableDS.sp_distributorbudgetdirect_list.Clear()
                Else
                    Me.TotalQtyPerMonth(ComboBoxBudgetDirectPerYear.SelectedValue.ToString(), _
                        ComboBoxBudgetDirectPerMonth.SelectedValue.ToString())
                    Me.TotalAmtPerMonth(ComboBoxBudgetDirectPerYear.SelectedValue.ToString(), _
                        ComboBoxBudgetDirectPerMonth.SelectedValue.ToString())
                End If
            End If
        End If
    End Sub

    Private Sub DataGridItemList_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
        Handles DataGridItemList.MouseUp
        Dim _s0 As String
        Dim _i, _iRow As Integer
        Dim _dg As DataGrid = DirectCast(sender, DataGrid)
        Dim _ht As DataGrid.HitTestInfo

        _dg = DataGridItemList
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

    Private Sub DataGridDistributorBudgetDirectList_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
        Handles DataGridDistributorBudgetDirectList.MouseUp
        Dim _s0 As String
        Dim _i, _iRow As Integer
        Dim _dg As DataGrid = DirectCast(sender, DataGrid)
        Dim _ht As DataGrid.HitTestInfo

        _dg = DataGridDistributorBudgetDirectList
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

    Private Sub TabControlDistributor_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles TabControlDistributor.Click
        Dim myTabPage As New MyTabPageClass
        Dim _iIndex As Integer = Me.TabControlDistributor.SelectedIndex
        Dim _sSelectedTab, _sComboBoxYear, _sComboBoxMonth As String

        If _iIndex = -1 Then
            Return
        Else
            If ComboBoxBudgetDirectPerYear.SelectedIndex = 0 Then
                Return
            Else
                If ComboBoxBudgetDirectPerMonth.SelectedIndex = 0 Then
                    Return
                Else
                    _sSelectedTab = Me.TabControlDistributor.SelectedTab.Name.ToString()
                    _sComboBoxYear = Me.ComboBoxBudgetDirectPerYear.SelectedValue.ToString()
                    _sComboBoxMonth = Me.ComboBoxBudgetDirectPerMonth.SelectedValue.ToString()
                    Me.DistributorBudgetDirectList(_sSelectedTab, _sComboBoxYear, _sComboBoxMonth)
                End If
            End If
        End If
    End Sub

    Private Sub ButtonDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles ButtonDelete.Click
        Dim _iRowIndex As Integer = DataGridDistributorBudgetDirectList.CurrentRowIndex
        Dim _sArrValues As String()

        Try
            If MyCodeTableDS.sp_distributorbudgetdirect_list.Count > 0 Then
                With DataGridDistributorBudgetDirectList
                    If _iRowIndex = -1 Then
                        Return
                    Else
                        If .IsSelected(_iRowIndex) Then
                            _sArrValues = New String() {Trim(.Item(_iRowIndex, 0).ToString), _
                                Trim(.Item(_iRowIndex, 4).ToString), _
                                Trim(.Item(_iRowIndex, 5).ToString), _
                                Trim(.Item(_iRowIndex, 7).ToString)}
                            Me.DistributorBudgetDirectDelete(_sArrValues)
                        End If
                    End If
                End With
            Else
                Return
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DistributorBudgetDirectList(ByVal _sValue0 As String, ByVal _sValue1 As String, ByVal _sValue2 As String)
        Me.Cursor = Cursors.WaitCursor
        Dim Params(2) As SqlParameter

        If MyCodeTableDS.sp_distributorbudgetdirect_list.Count > 0 Then MyCodeTableDS.sp_distributorbudgetdirect_list.Clear()

        Try
            Dim _distributorcode As New SqlParameter("@distributorcode", SqlDbType.VarChar, 5)
            _distributorcode.Direction = ParameterDirection.Input
            _distributorcode.Value = Trim(_sValue0)
            Params(0) = _distributorcode

            Dim _bdyear As New SqlParameter("@bdyear", SqlDbType.Char, 4)
            _bdyear.Direction = ParameterDirection.Input
            _bdyear.Value = Trim(_sValue1)
            Params(1) = _bdyear

            Dim _bdmonth As New SqlParameter("@bdmonth", SqlDbType.Char, 2)
            _bdmonth.Direction = ParameterDirection.Input
            _bdmonth.Value = Trim(_sValue2)
            Params(2) = _bdmonth

            Try
                BusinessObject.Sub_Show(ServerPath, "sp_distributorbudgetdirect_list", CommandType.StoredProcedure, _
                    MyCodeTableDS, "sp_distributorbudgetdirect_list", Params)

                DataGridDistributorBudgetDirectList.DataSource = MyCodeTableDS.sp_distributorbudgetdirect_list

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub DataGridDistributorBudgetDirectList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles DataGridDistributorBudgetDirectList.DoubleClick
        Dim _iRowIndex As Integer = DataGridDistributorBudgetDirectList.CurrentRowIndex
        Dim _sArrValues As String()

        Try
            If _iRowIndex = -1 Then
                Return
            Else
                If DataGridDistributorBudgetDirectList.IsSelected(_iRowIndex) Then
                    With DataGridDistributorBudgetDirectList
                        _sArrValues = New String() {Trim(.Item(_iRowIndex, 0).ToString), _
                            Trim(.Item(_iRowIndex, 1).ToString), _
                            Trim(.Item(_iRowIndex, 2).ToString), _
                            Trim(.Item(_iRowIndex, 3).ToString), _
                            Trim(.Item(_iRowIndex, 4).ToString), _
                            Trim(.Item(_iRowIndex, 5).ToString), _
                            Trim(.Item(_iRowIndex, 6).ToString), _
                            Trim(.Item(_iRowIndex, 7).ToString)}
                    End With

                    Me._xEventForm.TextBoxItemCode.Text = _sArrValues(0)
                    Me._xEventForm.TextBoxItemDescription.Text = _sArrValues(1)
                    Me._xEventForm.TextBoxQuantity.Text = _sArrValues(2)
                    Me._xEventForm.TextBoxAmount.Text = _sArrValues(3)
                    Me._xEventForm.DateTimePickerStartDate.Value = CDate(_sArrValues(4))
                    Me._xEventForm.DateTimePickerEndDate.Value = CDate(_sArrValues(5))
                    Me._xEventForm.TextBoxDivisionName.Text = _sArrValues(6)
                    Me._xEventForm.TextBoxDistributorCode.Text = _sArrValues(7)
                    Me._xEventForm.ShowDialog()

                    'AddHandler Me._eMyEvent, AddressOf _xMyTabPageControl1.UpdateItem
                    'RaiseEvent _eMyEvent(_sArrValues)
                    'RemoveHandler Me._eMyEvent, AddressOf _xMyTabPageControl1.UpdateItem
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DistributorBudgetDirectDelete(ByVal _sValue() As String)
        Dim Params(5) As SqlParameter

        If xMyDataSets.sp_distributorbudgetdirect_delete.Count > 0 Then _
            xMyDataSets.sp_distributorbudgetdirect_delete.Clear()

        If (MessageBox.Show("You're about to delete all the selected row in" & vbNewLine & _
            "Distributor Budget Direct list view!" & vbNewLine & _
            "Click Yes if you want to proceed.", "Deleting", MessageBoxButtons.YesNo, _
            MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then

            Try
                Dim _distributorcode As New SqlParameter("@distributorcode", SqlDbType.VarChar, 5)
                _distributorcode.Direction = ParameterDirection.Input
                _distributorcode.Value = Trim(_sValue(3))
                Params(0) = _distributorcode

                Dim _itemcode As New SqlParameter("@itemcode", SqlDbType.Char, 10)
                _itemcode.Direction = ParameterDirection.Input
                _itemcode.Value = Trim(_sValue(0))
                Params(1) = _itemcode

                Dim _startdate As New SqlParameter("@startdate", SqlDbType.DateTime)
                _startdate.Direction = ParameterDirection.Input
                _startdate.Value = Format(CDate(_sValue(1)), "d")
                Params(2) = _startdate

                Dim _enddate As New SqlParameter("@enddate", SqlDbType.DateTime)
                _enddate.Direction = ParameterDirection.Input
                _enddate.Value = Format(CDate(_sValue(2)), "d")
                Params(3) = _enddate

                Dim _modifieddate As New SqlParameter("@modifieddate", SqlDbType.DateTime)
                _modifieddate.Direction = ParameterDirection.Input
                _modifieddate.Value = GetDateTimeNow()
                Params(4) = _modifieddate

                Dim _lastuser As New SqlParameter("@lastuser", SqlDbType.Char, 10)
                _lastuser.Direction = ParameterDirection.Input
                _lastuser.Value = UCase(Trim(gUserID))
                Params(5) = _lastuser

                Try
                    BusinessObject.Sub_Show(ServerPath, "sp_distributorbudgetdirect_delete", CommandType.StoredProcedure, _
                        xMyDataSets, "sp_distributorbudgetdirect_delete", Params)

                    Me.DataGridRowsRemoved()

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

    Private Sub DataGridRowsRemoved()
        Me.Cursor = Cursors.WaitCursor
        Dim _iRowIndex As Integer = DataGridDistributorBudgetDirectList.CurrentRowIndex

        If MyCodeTableDS.sp_distributorbudgetdirect_list.Count > 0 Then
            With DataGridDistributorBudgetDirectList
                If _iRowIndex = -1 Then
                    Return
                Else
                    If .IsSelected(_iRowIndex) Then
                        MyCodeTableDS.sp_distributorbudgetdirect_list.Rows.RemoveAt(_iRowIndex)
                    End If
                End If
            End With
        Else
            Return
        End If
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
