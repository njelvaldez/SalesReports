Imports System.Data.SqlClient
Public Class frmItemBudget
    Inherits System.Windows.Forms.Form
    Private RemoteDataSet As New MyDataSetDB
    Private RemoteDataSet2 As New Budget
    Private EditMode As Boolean = False
    Private tmpSD As String, tmpED As String
    Private currItem As String
    Private currMon As Integer


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        Budget_Pmr_ShowYear()
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
    Friend WithEvents cboYear As System.Windows.Forms.ComboBox
    Friend WithEvents dgMonthlyBudget1 As System.Windows.Forms.DataGrid
    Friend WithEvents dgMonthlyBudget2 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle4 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn17 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn18 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn19 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn20 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn21 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn22 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgLineItem As System.Windows.Forms.DataGrid
    Friend WithEvents TxtLastUser As System.Windows.Forms.TextBox
    Friend WithEvents txtUpdateDate As System.Windows.Forms.TextBox
    Friend WithEvents txtCreateDate As System.Windows.Forms.TextBox
    Friend WithEvents TxtEndDate As System.Windows.Forms.TextBox
    Friend WithEvents TxtStartDate As System.Windows.Forms.TextBox
    Friend WithEvents txtRownumber As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents txtItemDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtItemCode As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgItemBudget As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents dgDiv As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgStart As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgEnd As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgQty As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgAmt As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents txtDivname As System.Windows.Forms.TextBox
    Friend WithEvents dgrow As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgCreate As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgUpdate As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle3 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmItemBudget))
        Me.cboYear = New System.Windows.Forms.ComboBox
        Me.dgMonthlyBudget1 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgMonthlyBudget2 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle4 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn17 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn18 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn19 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn20 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn21 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn22 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.dgLineItem = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle3 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.TxtLastUser = New System.Windows.Forms.TextBox
        Me.txtUpdateDate = New System.Windows.Forms.TextBox
        Me.txtCreateDate = New System.Windows.Forms.TextBox
        Me.TxtEndDate = New System.Windows.Forms.TextBox
        Me.TxtStartDate = New System.Windows.Forms.TextBox
        Me.txtRownumber = New System.Windows.Forms.TextBox
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.txtItemDesc = New System.Windows.Forms.TextBox
        Me.txtItemCode = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDivname = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.dgItemBudget = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.dgDiv = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgStart = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgEnd = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgQty = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgAmt = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgrow = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgCreate = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgUpdate = New System.Windows.Forms.DataGridTextBoxColumn
        CType(Me.dgMonthlyBudget1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMonthlyBudget2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgLineItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgItemBudget, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboYear
        '
        Me.cboYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYear.ForeColor = System.Drawing.Color.Black
        Me.cboYear.Location = New System.Drawing.Point(5, 3)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(120, 24)
        Me.cboYear.TabIndex = 0
        Me.cboYear.Tag = "View"
        '
        'dgMonthlyBudget1
        '
        Me.dgMonthlyBudget1.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgMonthlyBudget1.BackColor = System.Drawing.Color.Gainsboro
        Me.dgMonthlyBudget1.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgMonthlyBudget1.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgMonthlyBudget1.CaptionForeColor = System.Drawing.Color.White
        Me.dgMonthlyBudget1.CaptionText = "Monthly Budget (1st Semester)"
        Me.dgMonthlyBudget1.DataMember = ""
        Me.dgMonthlyBudget1.FlatMode = True
        Me.dgMonthlyBudget1.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.dgMonthlyBudget1.ForeColor = System.Drawing.Color.Black
        Me.dgMonthlyBudget1.GridLineColor = System.Drawing.Color.Silver
        Me.dgMonthlyBudget1.HeaderBackColor = System.Drawing.Color.Black
        Me.dgMonthlyBudget1.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgMonthlyBudget1.HeaderForeColor = System.Drawing.Color.White
        Me.dgMonthlyBudget1.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgMonthlyBudget1.Location = New System.Drawing.Point(5, 256)
        Me.dgMonthlyBudget1.Name = "dgMonthlyBudget1"
        Me.dgMonthlyBudget1.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgMonthlyBudget1.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgMonthlyBudget1.ReadOnly = True
        Me.dgMonthlyBudget1.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgMonthlyBudget1.SelectionForeColor = System.Drawing.Color.White
        Me.dgMonthlyBudget1.Size = New System.Drawing.Size(578, 106)
        Me.dgMonthlyBudget1.TabIndex = 92
        Me.dgMonthlyBudget1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        Me.dgMonthlyBudget1.Tag = "View"
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.dgMonthlyBudget1
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "budget"
        Me.DataGridTableStyle2.RowHeadersVisible = False
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn1.Format = "#,##0.00"
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Jan"
        Me.DataGridTextBoxColumn1.MappingName = "January"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 110
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn2.Format = "#,##0.00"
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Feb"
        Me.DataGridTextBoxColumn2.MappingName = "February"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 110
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn3.Format = "#,##0.00"
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Mar"
        Me.DataGridTextBoxColumn3.MappingName = "march"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 110
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn4.Format = "#,##0.00"
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Apr"
        Me.DataGridTextBoxColumn4.MappingName = "april"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 110
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn5.Format = "#,##0.00"
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "May"
        Me.DataGridTextBoxColumn5.MappingName = "may"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 110
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn6.Format = "#,##0.00"
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Jun"
        Me.DataGridTextBoxColumn6.MappingName = "june"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 110
        '
        'dgMonthlyBudget2
        '
        Me.dgMonthlyBudget2.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgMonthlyBudget2.BackColor = System.Drawing.Color.Gainsboro
        Me.dgMonthlyBudget2.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgMonthlyBudget2.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgMonthlyBudget2.CaptionForeColor = System.Drawing.Color.White
        Me.dgMonthlyBudget2.CaptionText = "Monthly Budget (2nd Semester)"
        Me.dgMonthlyBudget2.DataMember = ""
        Me.dgMonthlyBudget2.FlatMode = True
        Me.dgMonthlyBudget2.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.dgMonthlyBudget2.ForeColor = System.Drawing.Color.Black
        Me.dgMonthlyBudget2.GridLineColor = System.Drawing.Color.Silver
        Me.dgMonthlyBudget2.HeaderBackColor = System.Drawing.Color.Black
        Me.dgMonthlyBudget2.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgMonthlyBudget2.HeaderForeColor = System.Drawing.Color.White
        Me.dgMonthlyBudget2.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgMonthlyBudget2.Location = New System.Drawing.Point(5, 367)
        Me.dgMonthlyBudget2.Name = "dgMonthlyBudget2"
        Me.dgMonthlyBudget2.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgMonthlyBudget2.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgMonthlyBudget2.ReadOnly = True
        Me.dgMonthlyBudget2.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgMonthlyBudget2.SelectionForeColor = System.Drawing.Color.White
        Me.dgMonthlyBudget2.Size = New System.Drawing.Size(578, 106)
        Me.dgMonthlyBudget2.TabIndex = 93
        Me.dgMonthlyBudget2.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle4})
        Me.dgMonthlyBudget2.Tag = "View"
        '
        'DataGridTableStyle4
        '
        Me.DataGridTableStyle4.AlternatingBackColor = System.Drawing.Color.Aqua
        Me.DataGridTableStyle4.BackColor = System.Drawing.Color.LightCyan
        Me.DataGridTableStyle4.DataGrid = Me.dgMonthlyBudget2
        Me.DataGridTableStyle4.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn17, Me.DataGridTextBoxColumn18, Me.DataGridTextBoxColumn19, Me.DataGridTextBoxColumn20, Me.DataGridTextBoxColumn21, Me.DataGridTextBoxColumn22})
        Me.DataGridTableStyle4.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle4.MappingName = "Budget"
        Me.DataGridTableStyle4.RowHeadersVisible = False
        '
        'DataGridTextBoxColumn17
        '
        Me.DataGridTextBoxColumn17.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn17.Format = "#,##0.00"
        Me.DataGridTextBoxColumn17.FormatInfo = Nothing
        Me.DataGridTextBoxColumn17.HeaderText = "Jul"
        Me.DataGridTextBoxColumn17.MappingName = "July"
        Me.DataGridTextBoxColumn17.Width = 110
        '
        'DataGridTextBoxColumn18
        '
        Me.DataGridTextBoxColumn18.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn18.Format = "#,##0.00"
        Me.DataGridTextBoxColumn18.FormatInfo = Nothing
        Me.DataGridTextBoxColumn18.HeaderText = "Aug"
        Me.DataGridTextBoxColumn18.MappingName = "August"
        Me.DataGridTextBoxColumn18.Width = 110
        '
        'DataGridTextBoxColumn19
        '
        Me.DataGridTextBoxColumn19.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn19.Format = "#,##0.00"
        Me.DataGridTextBoxColumn19.FormatInfo = Nothing
        Me.DataGridTextBoxColumn19.HeaderText = "Sep"
        Me.DataGridTextBoxColumn19.MappingName = "September"
        Me.DataGridTextBoxColumn19.Width = 110
        '
        'DataGridTextBoxColumn20
        '
        Me.DataGridTextBoxColumn20.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn20.Format = "#,##0.00"
        Me.DataGridTextBoxColumn20.FormatInfo = Nothing
        Me.DataGridTextBoxColumn20.HeaderText = "Oct"
        Me.DataGridTextBoxColumn20.MappingName = "October"
        Me.DataGridTextBoxColumn20.Width = 110
        '
        'DataGridTextBoxColumn21
        '
        Me.DataGridTextBoxColumn21.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn21.Format = "#,##0.00"
        Me.DataGridTextBoxColumn21.FormatInfo = Nothing
        Me.DataGridTextBoxColumn21.HeaderText = "Nov"
        Me.DataGridTextBoxColumn21.MappingName = "November"
        Me.DataGridTextBoxColumn21.Width = 110
        '
        'DataGridTextBoxColumn22
        '
        Me.DataGridTextBoxColumn22.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn22.Format = "#,##0.00"
        Me.DataGridTextBoxColumn22.FormatInfo = Nothing
        Me.DataGridTextBoxColumn22.HeaderText = "Dec"
        Me.DataGridTextBoxColumn22.MappingName = "December"
        Me.DataGridTextBoxColumn22.Width = 110
        '
        'cmdAdd
        '
        Me.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdAdd.Image = CType(resources.GetObject("cmdAdd.Image"), System.Drawing.Image)
        Me.cmdAdd.Location = New System.Drawing.Point(600, 401)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(90, 53)
        Me.cmdAdd.TabIndex = 97
        Me.cmdAdd.Tag = "Add"
        '
        'cmdEdit
        '
        Me.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.Location = New System.Drawing.Point(692, 401)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(90, 53)
        Me.cmdEdit.TabIndex = 98
        Me.cmdEdit.Tag = "Edit"
        '
        'cmdDelete
        '
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.Location = New System.Drawing.Point(784, 401)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(90, 53)
        Me.cmdDelete.TabIndex = 99
        Me.cmdDelete.Tag = "Delete"
        '
        'cmdExit
        '
        Me.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(877, 401)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(90, 53)
        Me.cmdExit.TabIndex = 100
        Me.cmdExit.Tag = "Exit"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(598, 399)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(371, 66)
        Me.PictureBox2.TabIndex = 101
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Gray
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(595, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(377, 439)
        Me.PictureBox1.TabIndex = 95
        Me.PictureBox1.TabStop = False
        '
        'cmdCancel
        '
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdCancel.Image = CType(resources.GetObject("cmdCancel.Image"), System.Drawing.Image)
        Me.cmdCancel.Location = New System.Drawing.Point(692, 401)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(90, 53)
        Me.cmdCancel.TabIndex = 119
        Me.cmdCancel.Tag = "Cancel"
        '
        'cmdSave
        '
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.Location = New System.Drawing.Point(784, 401)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(90, 53)
        Me.cmdSave.TabIndex = 120
        Me.cmdSave.Tag = "Save"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(133, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 23)
        Me.Button1.TabIndex = 127
        Me.Button1.Tag = "View"
        '
        'dgLineItem
        '
        Me.dgLineItem.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgLineItem.BackColor = System.Drawing.Color.Gainsboro
        Me.dgLineItem.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgLineItem.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgLineItem.CaptionForeColor = System.Drawing.Color.White
        Me.dgLineItem.CaptionText = "Item List"
        Me.dgLineItem.DataMember = ""
        Me.dgLineItem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgLineItem.ForeColor = System.Drawing.Color.Black
        Me.dgLineItem.GridLineColor = System.Drawing.Color.Silver
        Me.dgLineItem.HeaderBackColor = System.Drawing.Color.Black
        Me.dgLineItem.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgLineItem.HeaderForeColor = System.Drawing.Color.White
        Me.dgLineItem.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgLineItem.Location = New System.Drawing.Point(5, 34)
        Me.dgLineItem.Name = "dgLineItem"
        Me.dgLineItem.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgLineItem.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgLineItem.ReadOnly = True
        Me.dgLineItem.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgLineItem.SelectionForeColor = System.Drawing.Color.White
        Me.dgLineItem.Size = New System.Drawing.Size(578, 215)
        Me.dgLineItem.TabIndex = 128
        Me.dgLineItem.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle3})
        Me.dgLineItem.Tag = "View"
        '
        'DataGridTableStyle3
        '
        Me.DataGridTableStyle3.DataGrid = Me.dgLineItem
        Me.DataGridTableStyle3.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9})
        Me.DataGridTableStyle3.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle3.MappingName = "lineitem"
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Items"
        Me.DataGridTextBoxColumn7.MappingName = "allitem"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 250
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "Units"
        Me.DataGridTextBoxColumn8.MappingName = "itemunit"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 75
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = " Principals"
        Me.DataGridTextBoxColumn9.MappingName = "itmprincipal"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 215
        '
        'TxtLastUser
        '
        Me.TxtLastUser.Location = New System.Drawing.Point(781, 341)
        Me.TxtLastUser.Name = "TxtLastUser"
        Me.TxtLastUser.Size = New System.Drawing.Size(48, 20)
        Me.TxtLastUser.TabIndex = 152
        Me.TxtLastUser.Tag = "Input"
        Me.TxtLastUser.Text = ""
        Me.TxtLastUser.Visible = False
        '
        'txtUpdateDate
        '
        Me.txtUpdateDate.BackColor = System.Drawing.SystemColors.Info
        Me.txtUpdateDate.Location = New System.Drawing.Point(698, 315)
        Me.txtUpdateDate.MaxLength = 10
        Me.txtUpdateDate.Name = "txtUpdateDate"
        Me.txtUpdateDate.ReadOnly = True
        Me.txtUpdateDate.Size = New System.Drawing.Size(200, 20)
        Me.txtUpdateDate.TabIndex = 150
        Me.txtUpdateDate.Tag = "Input"
        Me.txtUpdateDate.Text = ""
        '
        'txtCreateDate
        '
        Me.txtCreateDate.BackColor = System.Drawing.SystemColors.Info
        Me.txtCreateDate.Location = New System.Drawing.Point(698, 288)
        Me.txtCreateDate.MaxLength = 2
        Me.txtCreateDate.Name = "txtCreateDate"
        Me.txtCreateDate.ReadOnly = True
        Me.txtCreateDate.Size = New System.Drawing.Size(200, 20)
        Me.txtCreateDate.TabIndex = 149
        Me.txtCreateDate.Tag = "Input"
        Me.txtCreateDate.Text = ""
        '
        'TxtEndDate
        '
        Me.TxtEndDate.BackColor = System.Drawing.SystemColors.Info
        Me.TxtEndDate.Location = New System.Drawing.Point(698, 261)
        Me.TxtEndDate.MaxLength = 10
        Me.TxtEndDate.Name = "TxtEndDate"
        Me.TxtEndDate.ReadOnly = True
        Me.TxtEndDate.Size = New System.Drawing.Size(200, 20)
        Me.TxtEndDate.TabIndex = 146
        Me.TxtEndDate.Tag = "Input"
        Me.TxtEndDate.Text = ""
        '
        'TxtStartDate
        '
        Me.TxtStartDate.Location = New System.Drawing.Point(698, 234)
        Me.TxtStartDate.MaxLength = 2
        Me.TxtStartDate.Name = "TxtStartDate"
        Me.TxtStartDate.Size = New System.Drawing.Size(200, 20)
        Me.TxtStartDate.TabIndex = 145
        Me.TxtStartDate.Tag = "Input"
        Me.TxtStartDate.Text = ""
        '
        'txtRownumber
        '
        Me.txtRownumber.Location = New System.Drawing.Point(866, 180)
        Me.txtRownumber.Name = "txtRownumber"
        Me.txtRownumber.Size = New System.Drawing.Size(72, 20)
        Me.txtRownumber.TabIndex = 143
        Me.txtRownumber.Tag = ""
        Me.txtRownumber.Text = ""
        Me.txtRownumber.Visible = False
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(698, 369)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(112, 20)
        Me.txtAmount.TabIndex = 142
        Me.txtAmount.Tag = "Input"
        Me.txtAmount.Text = ""
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(698, 342)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(72, 20)
        Me.txtQty.TabIndex = 141
        Me.txtQty.Tag = "Input"
        Me.txtQty.Text = ""
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtItemDesc
        '
        Me.txtItemDesc.Location = New System.Drawing.Point(698, 207)
        Me.txtItemDesc.Name = "txtItemDesc"
        Me.txtItemDesc.Size = New System.Drawing.Size(240, 20)
        Me.txtItemDesc.TabIndex = 140
        Me.txtItemDesc.Tag = "Input"
        Me.txtItemDesc.Text = ""
        '
        'txtItemCode
        '
        Me.txtItemCode.Location = New System.Drawing.Point(698, 180)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(72, 20)
        Me.txtItemCode.TabIndex = 139
        Me.txtItemCode.Tag = "Input"
        Me.txtItemCode.Text = ""
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Location = New System.Drawing.Point(623, 315)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 20)
        Me.Label9.TabIndex = 148
        Me.Label9.Text = "Update Date"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Location = New System.Drawing.Point(623, 288)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 20)
        Me.Label10.TabIndex = 147
        Me.Label10.Text = "Create Date"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(773, 181)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(24, 20)
        Me.Button2.TabIndex = 144
        Me.Button2.Text = "..."
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(623, 369)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 20)
        Me.Label6.TabIndex = 138
        Me.Label6.Text = "Amount"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(623, 342)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 20)
        Me.Label5.TabIndex = 137
        Me.Label5.Text = "Qty"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(623, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 20)
        Me.Label4.TabIndex = 136
        Me.Label4.Text = "End Date"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(623, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.TabIndex = 135
        Me.Label3.Text = "Start Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(623, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 134
        Me.Label2.Text = "Item Desc"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(623, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 133
        Me.Label1.Text = "Item Code"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDivname
        '
        Me.txtDivname.BackColor = System.Drawing.SystemColors.Info
        Me.txtDivname.Location = New System.Drawing.Point(698, 153)
        Me.txtDivname.Name = "txtDivname"
        Me.txtDivname.ReadOnly = True
        Me.txtDivname.Size = New System.Drawing.Size(240, 20)
        Me.txtDivname.TabIndex = 154
        Me.txtDivname.Tag = "Input"
        Me.txtDivname.Text = ""
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(623, 153)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 20)
        Me.Label7.TabIndex = 153
        Me.Label7.Text = "Division"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgItemBudget
        '
        Me.dgItemBudget.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgItemBudget.BackColor = System.Drawing.Color.Gainsboro
        Me.dgItemBudget.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgItemBudget.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgItemBudget.CaptionForeColor = System.Drawing.Color.White
        Me.dgItemBudget.CaptionText = "Item Budget"
        Me.dgItemBudget.DataMember = ""
        Me.dgItemBudget.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.dgItemBudget.ForeColor = System.Drawing.Color.Black
        Me.dgItemBudget.GridLineColor = System.Drawing.Color.Silver
        Me.dgItemBudget.HeaderBackColor = System.Drawing.Color.Black
        Me.dgItemBudget.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgItemBudget.HeaderForeColor = System.Drawing.Color.White
        Me.dgItemBudget.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgItemBudget.Location = New System.Drawing.Point(597, 35)
        Me.dgItemBudget.Name = "dgItemBudget"
        Me.dgItemBudget.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgItemBudget.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgItemBudget.ReadOnly = True
        Me.dgItemBudget.RowHeaderWidth = 0
        Me.dgItemBudget.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgItemBudget.SelectionForeColor = System.Drawing.Color.White
        Me.dgItemBudget.Size = New System.Drawing.Size(372, 106)
        Me.dgItemBudget.TabIndex = 155
        Me.dgItemBudget.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.dgItemBudget.Tag = "View"
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgItemBudget
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.dgDiv, Me.dgStart, Me.dgEnd, Me.dgQty, Me.dgAmt, Me.dgrow, Me.dgCreate, Me.dgUpdate})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "ItemBudget"
        '
        'dgDiv
        '
        Me.dgDiv.Format = ""
        Me.dgDiv.FormatInfo = Nothing
        Me.dgDiv.MappingName = "divname"
        Me.dgDiv.NullText = ""
        Me.dgDiv.Width = 0
        '
        'dgStart
        '
        Me.dgStart.Format = "MM/dd/yyyy"
        Me.dgStart.FormatInfo = Nothing
        Me.dgStart.HeaderText = "StartDate"
        Me.dgStart.MappingName = "start_date"
        Me.dgStart.NullText = ""
        Me.dgStart.Width = 75
        '
        'dgEnd
        '
        Me.dgEnd.Format = "MM/dd/yyyy"
        Me.dgEnd.FormatInfo = Nothing
        Me.dgEnd.HeaderText = "EndDate"
        Me.dgEnd.MappingName = "end_date"
        Me.dgEnd.NullText = ""
        Me.dgEnd.Width = 75
        '
        'dgQty
        '
        Me.dgQty.Format = "#,##0"
        Me.dgQty.FormatInfo = Nothing
        Me.dgQty.HeaderText = "Qty"
        Me.dgQty.MappingName = "qty"
        Me.dgQty.NullText = ""
        Me.dgQty.Width = 60
        '
        'dgAmt
        '
        Me.dgAmt.Format = "#,##0.00"
        Me.dgAmt.FormatInfo = Nothing
        Me.dgAmt.HeaderText = "Amount"
        Me.dgAmt.MappingName = "amount"
        Me.dgAmt.NullText = ""
        '
        'dgrow
        '
        Me.dgrow.Format = ""
        Me.dgrow.FormatInfo = Nothing
        Me.dgrow.MappingName = "rownumber"
        Me.dgrow.NullText = ""
        Me.dgrow.Width = 0
        '
        'dgCreate
        '
        Me.dgCreate.Format = ""
        Me.dgCreate.FormatInfo = Nothing
        Me.dgCreate.MappingName = "createdate"
        Me.dgCreate.NullText = ""
        Me.dgCreate.Width = 0
        '
        'dgUpdate
        '
        Me.dgUpdate.Format = ""
        Me.dgUpdate.FormatInfo = Nothing
        Me.dgUpdate.MappingName = "updatedate"
        Me.dgUpdate.NullText = ""
        Me.dgUpdate.Width = 0
        '
        'frmItemBudget
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(975, 485)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgItemBudget)
        Me.Controls.Add(Me.txtDivname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtLastUser)
        Me.Controls.Add(Me.txtUpdateDate)
        Me.Controls.Add(Me.txtCreateDate)
        Me.Controls.Add(Me.TxtEndDate)
        Me.Controls.Add(Me.TxtStartDate)
        Me.Controls.Add(Me.txtRownumber)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.txtItemDesc)
        Me.Controls.Add(Me.txtItemCode)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgLineItem)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.dgMonthlyBudget2)
        Me.Controls.Add(Me.dgMonthlyBudget1)
        Me.Controls.Add(Me.cboYear)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmItemBudget"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PMR Budget"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgMonthlyBudget1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMonthlyBudget2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgLineItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgItemBudget, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Budget_Pmr_Insert()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(7) As SqlParameter

        z = "select itemcode as fld1 from NewScores..BudgetDirect "
        z = z & "where itemcode = '" & Trim(txtItemCode.Text) & "' "
        z = z & "  and month(start_date) = '" & currMon & "' "
        z = z & "  and year(start_date) = '" & Trim(cboYear.Text) & "' "
        If Existing(z) = True Then
            MessageBox.Show("This Product already exist for this month! Please try again.", "Code Exsists!")
            Exit Sub
        End If

        Dim ItemCode As New SqlParameter("@ItemCode", SqlDbType.VarChar, 10)
        ItemCode.Direction = ParameterDirection.Input
        ItemCode.Value = txtItemCode.Text
        Params(0) = ItemCode
        currItem = Trim(txtItemCode.Text)

        Dim StartDate As New SqlParameter("@Start_Date", SqlDbType.DateTime, 10)
        StartDate.Direction = ParameterDirection.Input
        StartDate.Value = Trim(TxtStartDate.Text)   'Format(dtStartDate.Value, "Short Date")
        Params(1) = StartDate
        tmpSD = Trim(TxtStartDate.Text)

        Dim EndDate As New SqlParameter("@End_Date", SqlDbType.DateTime, 10)
        EndDate.Direction = ParameterDirection.Input
        EndDate.Value = Trim(TxtEndDate.Text)  'Format(dtEndDate.Value, "Short Date")
        Params(2) = EndDate
        tmpED = Trim(TxtEndDate.Text)

        Dim Qty As New SqlParameter("@Qty", SqlDbType.Int)
        Qty.Direction = ParameterDirection.Input
        Qty.Value = Val(txtQty.Text)
        Params(3) = Qty

        Dim Amount As New SqlParameter("@Amount", SqlDbType.Money)
        Amount.Direction = ParameterDirection.Input
        Amount.Value = Val(txtAmount.Text)
        Params(4) = Amount

        Dim CreateDate As New SqlParameter("@CreateDate", SqlDbType.DateTime, 10)
        CreateDate.Direction = ParameterDirection.Input
        CreateDate.Value = GetDateTimeNow()
        Params(5) = CreateDate

        Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime, 10)
        UpdateDate.Direction = ParameterDirection.Input
        UpdateDate.Value = GetDateTimeNow()
        Params(6) = UpdateDate

        Dim LastUser As New SqlParameter("@LastUser", SqlDbType.VarChar, 10)  '<v--added-DBrion
        LastUser.Direction = ParameterDirection.Input
        LastUser.Value = IIf(Trim(gCurrUser) = "", "", gCurrUser)
        Params(7) = LastUser

        BusinessObject.Sub_Insert(ServerPath2, "ItemBudget_Insert", CommandType.StoredProcedure, Params)
    End Sub

    Private Sub Budget_Pmr_Update()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(7) As SqlParameter

        Dim ItemCode As New SqlParameter("@ItemCode", SqlDbType.VarChar, 10)
        ItemCode.Direction = ParameterDirection.Input
        ItemCode.Value = txtItemCode.Text
        Params(0) = ItemCode

        Dim StartDate As New SqlParameter("@Start_Date", SqlDbType.DateTime, 10)
        StartDate.Direction = ParameterDirection.Input
        StartDate.Value = Trim(TxtStartDate.Text)   'Format(dtStartDate.Value, "Short Date")
        Params(1) = StartDate
        tmpSD = Trim(TxtStartDate.Text)

        Dim EndDate As New SqlParameter("@End_Date", SqlDbType.DateTime, 10)
        EndDate.Direction = ParameterDirection.Input
        EndDate.Value = Trim(TxtEndDate.Text)  'Format(dtEndDate.Value, "Short Date")
        Params(2) = EndDate
        tmpED = Trim(TxtEndDate.Text)

        Dim Qty As New SqlParameter("@Qty", SqlDbType.Int)
        Qty.Direction = ParameterDirection.Input
        Qty.Value = Val(txtQty.Text)
        Params(3) = Qty

        Dim Amount As New SqlParameter("@Amount", SqlDbType.Money)
        Amount.Direction = ParameterDirection.Input
        Amount.Value = Val(txtAmount.Text)
        Params(4) = Amount

        Dim Rownumber As New SqlParameter("@Rownumber", SqlDbType.Float)
        Rownumber.Direction = ParameterDirection.Input
        Rownumber.Value = Val(txtRownumber.Text)
        Params(5) = Rownumber

        Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime, 10)
        UpdateDate.Direction = ParameterDirection.Input
        UpdateDate.Value = GetDateTimeNow()
        Params(6) = UpdateDate

        Dim LastUser As New SqlParameter("@LastUser", SqlDbType.VarChar, 10)  '<v--added-DBrion
        LastUser.Direction = ParameterDirection.Input
        LastUser.Value = Trim(TxtLastUser.Text)
        Params(7) = LastUser
        Try
            BusinessObject.Sub_Update(ServerPath2, "ItemBudget_Update", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Budget_Pmr_Delete()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter
        Dim Rownumber As New SqlParameter("@Rownumber", SqlDbType.Int)
        Rownumber.Direction = ParameterDirection.Input
        Rownumber.Value = txtRownumber.Text
        Params(0) = Rownumber
        BusinessObject.Sub_Delete(ServerPath2, "ItemBudget_Delete", CommandType.StoredProcedure, Params)
    End Sub

    Private Sub Budget_Pmr_ShowYear()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "ItemBudget_YearCombo", _
                                           CommandType.StoredProcedure, RemoteDataSet, "Year")
        cboYear.DataSource = RemoteDataSet.Year
        cboYear.DisplayMember = "Year"
    End Sub

    Private Sub Button1_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        If IsNumeric(cboYear.Text) Then
            'Budget_ItemList()
            ItemBudget_ShowMonthlyBudget()
        End If
    End Sub

    Private Sub ItemBudget_ShowMonthlyBudget()
        RemoteDataSet.Budget.Clear()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter
        Dim Year As New SqlParameter("@Year", SqlDbType.Int)
        Year.Direction = ParameterDirection.Input
        Year.Value = cboYear.Text
        Params(0) = Year
        Try
            BusinessObject.Sub_Show(ServerPath2, "ItemBudget_ShowMonthly", _
                                CommandType.StoredProcedure, RemoteDataSet, "Budget", Params)
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
        dgMonthlyBudget1.DataSource = RemoteDataSet.Budget
        dgMonthlyBudget2.DataSource = RemoteDataSet.Budget
    End Sub

    Private Sub dgMonthlyBudget1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgMonthlyBudget1.CurrentCellChanged, dgMonthlyBudget1.Enter
        currMon = dgMonthlyBudget1.CurrentCell.ColumnNumber + 1
        Budget_ItemList()
    End Sub

    Private Sub dgMonthlyBudget2_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgMonthlyBudget2.CurrentCellChanged, dgMonthlyBudget2.Enter
        currMon = dgMonthlyBudget2.CurrentCell.ColumnNumber + 7
        Budget_ItemList()
    End Sub

    Private Sub Budget_ItemList()
        RemoteDataSet.LineItem.Clear()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(1) As SqlParameter
        Dim Month As New SqlParameter("@Month", SqlDbType.Float)
        Month.Direction = ParameterDirection.Input
        Month.Value = currMon
        Params(0) = Month
        Dim Year As New SqlParameter("@Year", SqlDbType.Float)
        Year.Direction = ParameterDirection.Input
        Year.Value = Trim(cboYear.Text)
        Params(1) = Year
        BusinessObject.Sub_Show(ServerPath2, "ItemBudget_ShowItemList", CommandType.StoredProcedure, _
                                RemoteDataSet, "LineItem", Params)
        dgLineItem.DataSource = RemoteDataSet.LineItem
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub dgLineItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgLineItem.Click, dgLineItem.CurrentCellChanged
        currItem = GetCode(dgLineItem.Item(dgLineItem.CurrentCell.RowNumber, 0).ToString)
        With dgLineItem
            txtItemCode.Text = currItem
            txtItemDesc.Text = GetDescription(.Item(.CurrentCell.RowNumber, 0).ToString)
        End With
        Budget_ShowItemBudget()
        With dgItemBudget
            txtDivname.Text = .Item(.CurrentCell.RowNumber, 0).ToString
            TxtStartDate.Text = .Item(.CurrentCell.RowNumber, 1).ToString
            TxtStartDate.Text = Format(CDate(TxtStartDate.Text), "MM/dd/yyyy")
            TxtEndDate.Text = .Item(.CurrentCell.RowNumber, 2).ToString
            TxtEndDate.Text = Format(CDate(TxtEndDate.Text), "MM/dd/yyyy")
            txtCreateDate.Text = .Item(.CurrentCell.RowNumber, 6).ToString
            txtCreateDate.Text = Format(CDate(txtCreateDate.Text), "MM/dd/yyyy")
            txtUpdateDate.Text = .Item(.CurrentCell.RowNumber, 7).ToString
            txtUpdateDate.Text = Format(CDate(txtUpdateDate.Text), "MM/dd/yyyy")
            txtQty.Text = .Item(.CurrentCell.RowNumber, 3).ToString
            txtQty.Text = Format(Val(txtQty.Text), "#,##0")
            txtAmount.Text = .Item(.CurrentCell.RowNumber, 4).ToString
            txtAmount.Text = Format(Val(txtAmount.Text), "#,##0.00")
            txtRownumber.Text = .Item(.CurrentCell.RowNumber, 5).ToString
        End With
        'ItemBudget_ShowMonthlyBudget()
        cmdAdd.Enabled = True
        cmdEdit.Enabled = True
        cmdDelete.Enabled = True
    End Sub

    Private Sub Budget_ShowItemBudget()
        RemoteDataSet.ItemBudget.Clear()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(2) As SqlParameter
        Dim ItemCode As New SqlParameter("@ItemCode", SqlDbType.VarChar, 10)
        ItemCode.Direction = ParameterDirection.Input
        ItemCode.Value = currItem
        Params(0) = ItemCode
        Dim Month As New SqlParameter("@Month", SqlDbType.Float)
        Month.Direction = ParameterDirection.Input
        Month.Value = currMon
        Params(1) = Month
        Dim Year As New SqlParameter("@Year", SqlDbType.Float)
        Year.Direction = ParameterDirection.Input
        Year.Value = Trim(cboYear.Text)
        Params(2) = Year
        Try
            BusinessObject.Sub_Show(ServerPath2, "ItemBudget_ShowItemBudgetList", _
                                    CommandType.StoredProcedure, RemoteDataSet, "ItemBudget", Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        dgItemBudget.DataSource = RemoteDataSet.ItemBudget
    End Sub

    Private Sub dgLineItem_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgLineItem.MouseUp
        dgLineItem.Select()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim MyDialogBox As New frmItemBrowse
        Fld0 = Nothing
        Fld1 = Nothing
        If Trim(txtItemCode.Text) <> "" Then
            Fld0 = Trim(txtItemCode.Text)
        End If
        If Trim(txtItemDesc.Text) <> "" Then
            Fld1 = Trim(txtItemDesc.Text)
        End If
        MyDialogBox.ShowDialog(Me)
        If Not MyDialogBox.DialogResult = DialogResult.Cancel Then
            txtItemCode.Text = CStr(MyDialogBox.LineData(0))
            txtItemDesc.Text = CStr(MyDialogBox.LineData(1))
        End If
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim xDat As String
        ControlMaintenance.EnableControls(Me, True)
        ControlMaintenance.ClearInputControls(Me)
        EditMode = False
        xDat = GetDateTimeNow("MM/dd/yyyy")
        TxtStartDate.Text = Format(currMon, "0#") & "/01/" & Trim(cboYear.Text)
        TxtEndDate.Text = GetEOM(Trim(TxtStartDate.Text))
        txtCreateDate.Text = xDat
        txtUpdateDate.Text = xDat
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Me.Cursor = Cursors.WaitCursor
        ControlMaintenance.EnableControls(Me, False)
        If EditMode = False Then
            Budget_Pmr_Insert()
        Else
            Budget_Pmr_Update()
        End If
        Budget_ItemList()
        Budget_ShowItemBudget()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        ControlMaintenance.EnableControls(Me, True)
        EditMode = True
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        ControlMaintenance.EnableControls(Me, False)
        EditMode = False
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If txtRownumber.Text > "" Then
            If MessageBox.Show("Are you sure you want to delete this record!", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                Budget_Pmr_Delete()
                Budget_ItemList()
                Budget_ShowItemBudget()
                ControlMaintenance.ClearInputControls(Me)
            End If
        End If
    End Sub

    Private Sub frmBudgetPmr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlMaintenance.EnableControls(Me, False)
        cmdAdd.Enabled = False
        cmdEdit.Enabled = False
        cmdDelete.Enabled = False
        tmpSD = ""
        tmpED = ""
    End Sub

    Private Sub cboYear_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboYear.Validating
        If Val(cboYear.Text) <= (Val(GetDateTimeNow("yyyy")) - 2) Then
            cmdAdd.Enabled = False
            cmdEdit.Enabled = False
            cmdDelete.Enabled = False
        ElseIf Val(cboYear.Text) = (Val(GetDateTimeNow("yyyy")) - 1) Or _
               Val(cboYear.Text) = Val(GetDateTimeNow("yyyy")) Then
            cmdAdd.Enabled = True
            cmdEdit.Enabled = True
            cmdDelete.Enabled = True
        End If
    End Sub

    Private Sub TxtStartDate_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtStartDate.KeyUp
        If e.KeyValue = 13 Then      ' tests if the key pressed is the "enter key"
            SendKeys.Send("{TAB}")   ' sends the focus to the next control/tabstop
        End If
    End Sub

    Private Sub TxtStartDate_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtStartDate.Validating
        On Error GoTo errpt
        TxtStartDate.Text = Trim(TxtStartDate.Text) & "/01/" & Trim(cboYear.Text)
        TxtStartDate.Text = DatValid(TxtStartDate.Text)  'validating the entry. the textbox's value will be "mm/dd/yyyy" if the entry is invalid.
        If Trim(TxtStartDate.Text) = "mm/dd/yyyy" Then
            GoTo errpt
        Else
            TxtEndDate.Text = GetEOM(Trim(TxtStartDate.Text))
            Exit Sub
        End If
errpt:
        e.Cancel = True  'brings back the focus to TxtStartDate textbox. only in Validating event
    End Sub

    Private Sub txtAmount_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAmount.GotFocus
        txtAmount.Text = StrTran(Trim(txtAmount.Text), ",", "")
    End Sub

    Private Sub txtAmount_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAmount.KeyUp
        'If e.KeyValue = 13 Then      ' tests if the key pressed is the "enter key"
        '    SendKeys.Send("{TAB}")   ' sends the focus to the next control/tabstop
        'End If
        If NumKeys(e.KeyData, "NORM") = False Then
            MsgBox("Please check your entry!!")
            Beep()
            'If Len(Trim(txtAmount.Text)) <> 0 Then
            '    MsgBox("Please check your entry!!")
            '    'txtAmount.Text = Mid(Trim(txtAmount.Text), 1, Len(Trim(txtAmount.Text)) - 1)
            '    'txtAmount.SelectionStart = Len(Trim(txtAmount.Text))
            '    Beep()
            'Else
            '    txtAmount.Text = ""
            'End If
        End If
    End Sub

    Private Sub txtAmount_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAmount.Validating

    End Sub

    Private Sub txtQty_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQty.GotFocus
        txtQty.Text = StrTran(Trim(txtAmount.Text), ",", "")
    End Sub

    Private Sub txtQty_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyUp
        'If e.KeyValue = 13 Then      ' tests if the key pressed is the "enter key"
        '    SendKeys.Send("{TAB}")   ' sends the focus to the next control/tabstop
        'End If
        If NumKeys(e.KeyData, "INT") = False Then
            MsgBox("Please check your entry!!")
            Beep()
            'If Len(Trim(txtQty.Text)) <> 0 Then
            '    MsgBox("Please check your entry!!")
            '    'txtQty.Text = Mid(Trim(txtQty.Text), 1, Len(Trim(txtQty.Text)) - 1)
            '    'txtQty.SelectionStart = Len(Trim(txtQty.Text))
            '    Beep()
            'Else
            '    txtQty.Text = ""
            'End If
        End If
    End Sub
End Class