Imports System.Data.SqlClient
Public Class frmBudgetPMR
    Inherits System.Windows.Forms.Form
    Private RemoteDataSet As New Budget
    Private EditMode As Boolean = False
    Private tmpSD As String, tmpED As String
    Private currMedRep As String = ""
    Private currCommDat As String

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
    Friend WithEvents dgMedrepList As System.Windows.Forms.DataGrid
    Friend WithEvents dgMonthlyBudget1 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgMonthlyBudget2 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle3 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn15 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn16 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTableStyle4 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn17 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn18 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn19 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn20 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn21 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn22 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgLineItem As System.Windows.Forms.DataGrid
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtItemCode As System.Windows.Forms.TextBox
    Friend WithEvents txtItemDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lblPmr As System.Windows.Forms.Label
    Friend WithEvents txtRownumber As System.Windows.Forms.TextBox
    Friend WithEvents txtMrCode As System.Windows.Forms.TextBox
    Friend WithEvents TxtEndDate As System.Windows.Forms.TextBox
    Friend WithEvents TxtStartDate As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgItemCodeMR As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgItemDescMR As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgStartDateMR As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgEndDateMR As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgQtyMR As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgAmtMR As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgRownumberMR As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmBudgetPMR))
        Me.cboYear = New System.Windows.Forms.ComboBox
        Me.dgMedrepList = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle3 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgMonthlyBudget1 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
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
        Me.dgLineItem = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.dgItemCodeMR = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgItemDescMR = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgStartDateMR = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgEndDateMR = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgQtyMR = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgAmtMR = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgRownumberMR = New System.Windows.Forms.DataGridTextBoxColumn
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtItemCode = New System.Windows.Forms.TextBox
        Me.txtItemDesc = New System.Windows.Forms.TextBox
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.lblPmr = New System.Windows.Forms.Label
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.txtRownumber = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.txtMrCode = New System.Windows.Forms.TextBox
        Me.TxtEndDate = New System.Windows.Forms.TextBox
        Me.TxtStartDate = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.dgMedrepList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMonthlyBudget1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMonthlyBudget2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgLineItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboYear
        '
        Me.cboYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYear.ForeColor = System.Drawing.Color.Black
        Me.cboYear.Location = New System.Drawing.Point(49, 43)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(120, 24)
        Me.cboYear.TabIndex = 0
        Me.cboYear.Tag = "View"
        '
        'dgMedrepList
        '
        Me.dgMedrepList.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgMedrepList.BackColor = System.Drawing.Color.Gainsboro
        Me.dgMedrepList.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgMedrepList.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgMedrepList.CaptionForeColor = System.Drawing.Color.White
        Me.dgMedrepList.CaptionText = "Medrep List"
        Me.dgMedrepList.DataMember = ""
        Me.dgMedrepList.FlatMode = True
        Me.dgMedrepList.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.dgMedrepList.ForeColor = System.Drawing.Color.Black
        Me.dgMedrepList.GridLineColor = System.Drawing.Color.Silver
        Me.dgMedrepList.HeaderBackColor = System.Drawing.Color.Black
        Me.dgMedrepList.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgMedrepList.HeaderForeColor = System.Drawing.Color.White
        Me.dgMedrepList.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgMedrepList.Location = New System.Drawing.Point(48, 70)
        Me.dgMedrepList.Name = "dgMedrepList"
        Me.dgMedrepList.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgMedrepList.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgMedrepList.ReadOnly = True
        Me.dgMedrepList.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgMedrepList.SelectionForeColor = System.Drawing.Color.White
        Me.dgMedrepList.Size = New System.Drawing.Size(515, 417)
        Me.dgMedrepList.TabIndex = 1
        Me.dgMedrepList.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle3})
        Me.dgMedrepList.Tag = "View"
        '
        'DataGridTableStyle3
        '
        Me.DataGridTableStyle3.AlternatingBackColor = System.Drawing.Color.Aqua
        Me.DataGridTableStyle3.BackColor = System.Drawing.Color.LightCyan
        Me.DataGridTableStyle3.DataGrid = Me.dgMedrepList
        Me.DataGridTableStyle3.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn16})
        Me.DataGridTableStyle3.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle3.MappingName = "MedrepList"
        Me.DataGridTableStyle3.RowHeadersVisible = False
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "Code"
        Me.DataGridTextBoxColumn13.MappingName = "MrCode"
        Me.DataGridTextBoxColumn13.Width = 70
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "Name"
        Me.DataGridTextBoxColumn14.MappingName = "MrName"
        Me.DataGridTextBoxColumn14.Width = 238
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "Hire Date"
        Me.DataGridTextBoxColumn15.MappingName = "Hire_Date"
        Me.DataGridTextBoxColumn15.Width = 93
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn16.Format = ""
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.HeaderText = "Resign Date"
        Me.DataGridTextBoxColumn16.MappingName = "Resign_Date"
        Me.DataGridTextBoxColumn16.Width = 93
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
        Me.dgMonthlyBudget1.Location = New System.Drawing.Point(48, 493)
        Me.dgMonthlyBudget1.Name = "dgMonthlyBudget1"
        Me.dgMonthlyBudget1.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgMonthlyBudget1.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgMonthlyBudget1.ReadOnly = True
        Me.dgMonthlyBudget1.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgMonthlyBudget1.SelectionForeColor = System.Drawing.Color.White
        Me.dgMonthlyBudget1.Size = New System.Drawing.Size(515, 60)
        Me.dgMonthlyBudget1.TabIndex = 92
        Me.dgMonthlyBudget1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.dgMonthlyBudget1.Tag = "View"
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Aqua
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightCyan
        Me.DataGridTableStyle1.DataGrid = Me.dgMonthlyBudget1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Budget"
        Me.DataGridTableStyle1.RowHeadersVisible = False
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn1.Format = "#,##0.00"
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Jan"
        Me.DataGridTextBoxColumn1.MappingName = "January"
        Me.DataGridTextBoxColumn1.Width = 85
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn2.Format = "#,##0.00"
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Feb"
        Me.DataGridTextBoxColumn2.MappingName = "February"
        Me.DataGridTextBoxColumn2.Width = 85
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn3.Format = "#,##0.00"
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Mar"
        Me.DataGridTextBoxColumn3.MappingName = "March"
        Me.DataGridTextBoxColumn3.Width = 85
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn4.Format = "#,##0.00"
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Apr"
        Me.DataGridTextBoxColumn4.MappingName = "April"
        Me.DataGridTextBoxColumn4.Width = 85
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn5.Format = "#,##0.00"
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "May"
        Me.DataGridTextBoxColumn5.MappingName = "May"
        Me.DataGridTextBoxColumn5.Width = 85
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn6.Format = "#,##0.00"
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Jun"
        Me.DataGridTextBoxColumn6.MappingName = "June"
        Me.DataGridTextBoxColumn6.Width = 85
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
        Me.dgMonthlyBudget2.Location = New System.Drawing.Point(48, 558)
        Me.dgMonthlyBudget2.Name = "dgMonthlyBudget2"
        Me.dgMonthlyBudget2.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgMonthlyBudget2.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgMonthlyBudget2.ReadOnly = True
        Me.dgMonthlyBudget2.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgMonthlyBudget2.SelectionForeColor = System.Drawing.Color.White
        Me.dgMonthlyBudget2.Size = New System.Drawing.Size(515, 60)
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
        Me.DataGridTextBoxColumn17.Width = 85
        '
        'DataGridTextBoxColumn18
        '
        Me.DataGridTextBoxColumn18.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn18.Format = "#,##0.00"
        Me.DataGridTextBoxColumn18.FormatInfo = Nothing
        Me.DataGridTextBoxColumn18.HeaderText = "Aug"
        Me.DataGridTextBoxColumn18.MappingName = "August"
        Me.DataGridTextBoxColumn18.Width = 85
        '
        'DataGridTextBoxColumn19
        '
        Me.DataGridTextBoxColumn19.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn19.Format = "#,##0.00"
        Me.DataGridTextBoxColumn19.FormatInfo = Nothing
        Me.DataGridTextBoxColumn19.HeaderText = "Sep"
        Me.DataGridTextBoxColumn19.MappingName = "September"
        Me.DataGridTextBoxColumn19.Width = 85
        '
        'DataGridTextBoxColumn20
        '
        Me.DataGridTextBoxColumn20.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn20.Format = "#,##0.00"
        Me.DataGridTextBoxColumn20.FormatInfo = Nothing
        Me.DataGridTextBoxColumn20.HeaderText = "Oct"
        Me.DataGridTextBoxColumn20.MappingName = "October"
        Me.DataGridTextBoxColumn20.Width = 85
        '
        'DataGridTextBoxColumn21
        '
        Me.DataGridTextBoxColumn21.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn21.Format = "#,##0.00"
        Me.DataGridTextBoxColumn21.FormatInfo = Nothing
        Me.DataGridTextBoxColumn21.HeaderText = "Nov"
        Me.DataGridTextBoxColumn21.MappingName = "November"
        Me.DataGridTextBoxColumn21.Width = 85
        '
        'DataGridTextBoxColumn22
        '
        Me.DataGridTextBoxColumn22.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn22.Format = "#,##0.00"
        Me.DataGridTextBoxColumn22.FormatInfo = Nothing
        Me.DataGridTextBoxColumn22.HeaderText = "Dec"
        Me.DataGridTextBoxColumn22.MappingName = "December"
        Me.DataGridTextBoxColumn22.Width = 85
        '
        'dgLineItem
        '
        Me.dgLineItem.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgLineItem.BackColor = System.Drawing.Color.Gainsboro
        Me.dgLineItem.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgLineItem.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgLineItem.CaptionForeColor = System.Drawing.Color.White
        Me.dgLineItem.CaptionText = "Item Budget List"
        Me.dgLineItem.DataMember = ""
        Me.dgLineItem.FlatMode = True
        Me.dgLineItem.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.dgLineItem.ForeColor = System.Drawing.Color.Black
        Me.dgLineItem.GridLineColor = System.Drawing.Color.Silver
        Me.dgLineItem.HeaderBackColor = System.Drawing.Color.Black
        Me.dgLineItem.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgLineItem.HeaderForeColor = System.Drawing.Color.White
        Me.dgLineItem.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgLineItem.Location = New System.Drawing.Point(580, 77)
        Me.dgLineItem.Name = "dgLineItem"
        Me.dgLineItem.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgLineItem.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgLineItem.ReadOnly = True
        Me.dgLineItem.RowHeadersVisible = False
        Me.dgLineItem.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgLineItem.SelectionForeColor = System.Drawing.Color.White
        Me.dgLineItem.Size = New System.Drawing.Size(383, 264)
        Me.dgLineItem.TabIndex = 94
        Me.dgLineItem.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        Me.dgLineItem.Tag = "View"
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.AlternatingBackColor = System.Drawing.Color.Aqua
        Me.DataGridTableStyle2.BackColor = System.Drawing.Color.LightCyan
        Me.DataGridTableStyle2.DataGrid = Me.dgLineItem
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.dgItemCodeMR, Me.dgItemDescMR, Me.dgStartDateMR, Me.dgEndDateMR, Me.dgQtyMR, Me.dgAmtMR, Me.dgRownumberMR})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "LineItem"
        Me.DataGridTableStyle2.RowHeadersVisible = False
        '
        'dgItemCodeMR
        '
        Me.dgItemCodeMR.Format = ""
        Me.dgItemCodeMR.FormatInfo = Nothing
        Me.dgItemCodeMR.HeaderText = "Code"
        Me.dgItemCodeMR.MappingName = "ItemCode"
        Me.dgItemCodeMR.NullText = ""
        Me.dgItemCodeMR.Width = 50
        '
        'dgItemDescMR
        '
        Me.dgItemDescMR.Format = ""
        Me.dgItemDescMR.FormatInfo = Nothing
        Me.dgItemDescMR.HeaderText = "Description"
        Me.dgItemDescMR.MappingName = "ItemDesc"
        Me.dgItemDescMR.NullText = ""
        Me.dgItemDescMR.Width = 202
        '
        'dgStartDateMR
        '
        Me.dgStartDateMR.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.dgStartDateMR.Format = ""
        Me.dgStartDateMR.FormatInfo = Nothing
        Me.dgStartDateMR.HeaderText = "Start"
        Me.dgStartDateMR.MappingName = "Start_Date"
        Me.dgStartDateMR.NullText = ""
        Me.dgStartDateMR.Width = 0
        '
        'dgEndDateMR
        '
        Me.dgEndDateMR.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.dgEndDateMR.Format = ""
        Me.dgEndDateMR.FormatInfo = Nothing
        Me.dgEndDateMR.HeaderText = "End"
        Me.dgEndDateMR.MappingName = "End_Date"
        Me.dgEndDateMR.NullText = ""
        Me.dgEndDateMR.Width = 0
        '
        'dgQtyMR
        '
        Me.dgQtyMR.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.dgQtyMR.Format = ""
        Me.dgQtyMR.FormatInfo = Nothing
        Me.dgQtyMR.HeaderText = "Qty"
        Me.dgQtyMR.MappingName = "Qty"
        Me.dgQtyMR.NullText = ""
        Me.dgQtyMR.Width = 40
        '
        'dgAmtMR
        '
        Me.dgAmtMR.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.dgAmtMR.Format = "#,#00.00"
        Me.dgAmtMR.FormatInfo = Nothing
        Me.dgAmtMR.HeaderText = "Amount"
        Me.dgAmtMR.MappingName = "Amount"
        Me.dgAmtMR.NullText = ""
        Me.dgAmtMR.Width = 85
        '
        'dgRownumberMR
        '
        Me.dgRownumberMR.Format = ""
        Me.dgRownumberMR.FormatInfo = Nothing
        Me.dgRownumberMR.MappingName = "rownumber"
        Me.dgRownumberMR.Width = 0
        '
        'cmdAdd
        '
        Me.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdAdd.Image = CType(resources.GetObject("cmdAdd.Image"), System.Drawing.Image)
        Me.cmdAdd.Location = New System.Drawing.Point(588, 548)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(90, 53)
        Me.cmdAdd.TabIndex = 97
        Me.cmdAdd.Tag = "Add"
        '
        'cmdEdit
        '
        Me.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.Location = New System.Drawing.Point(680, 548)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(90, 53)
        Me.cmdEdit.TabIndex = 98
        Me.cmdEdit.Tag = "Edit"
        '
        'cmdDelete
        '
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.Location = New System.Drawing.Point(772, 548)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(90, 53)
        Me.cmdDelete.TabIndex = 99
        Me.cmdDelete.Tag = "Delete"
        '
        'cmdExit
        '
        Me.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(865, 548)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(90, 53)
        Me.cmdExit.TabIndex = 100
        Me.cmdExit.Tag = "Exit"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(586, 546)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(371, 66)
        Me.PictureBox2.TabIndex = 101
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Gray
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(569, 70)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(404, 548)
        Me.PictureBox1.TabIndex = 95
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(576, 342)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(387, 195)
        Me.PictureBox4.TabIndex = 103
        Me.PictureBox4.TabStop = False
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(602, 382)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Item Code"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(602, 407)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "Item Desc"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(602, 432)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "Start Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(602, 457)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "End Date"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(602, 482)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 20)
        Me.Label5.TabIndex = 108
        Me.Label5.Text = "Qty"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(602, 507)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 20)
        Me.Label6.TabIndex = 109
        Me.Label6.Text = "Amount"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(602, 357)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 20)
        Me.Label7.TabIndex = 110
        Me.Label7.Text = "PMR"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtItemCode
        '
        Me.txtItemCode.Location = New System.Drawing.Point(706, 382)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(72, 20)
        Me.txtItemCode.TabIndex = 112
        Me.txtItemCode.Tag = "Input"
        Me.txtItemCode.Text = ""
        '
        'txtItemDesc
        '
        Me.txtItemDesc.Location = New System.Drawing.Point(706, 407)
        Me.txtItemDesc.Name = "txtItemDesc"
        Me.txtItemDesc.Size = New System.Drawing.Size(240, 20)
        Me.txtItemDesc.TabIndex = 113
        Me.txtItemDesc.Tag = "Input"
        Me.txtItemDesc.Text = ""
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(706, 482)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(72, 20)
        Me.txtQty.TabIndex = 116
        Me.txtQty.Tag = "Input"
        Me.txtQty.Text = ""
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(706, 507)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(112, 20)
        Me.txtAmount.TabIndex = 117
        Me.txtAmount.Tag = "Input"
        Me.txtAmount.Text = ""
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPmr
        '
        Me.lblPmr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPmr.Location = New System.Drawing.Point(706, 357)
        Me.lblPmr.Name = "lblPmr"
        Me.lblPmr.Size = New System.Drawing.Size(240, 20)
        Me.lblPmr.TabIndex = 118
        Me.lblPmr.Tag = ""
        Me.lblPmr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdCancel
        '
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdCancel.Image = CType(resources.GetObject("cmdCancel.Image"), System.Drawing.Image)
        Me.cmdCancel.Location = New System.Drawing.Point(680, 548)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(90, 53)
        Me.cmdCancel.TabIndex = 119
        Me.cmdCancel.Tag = "Cancel"
        '
        'cmdSave
        '
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.Location = New System.Drawing.Point(772, 548)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(90, 53)
        Me.cmdSave.TabIndex = 120
        Me.cmdSave.Tag = "Save"
        '
        'txtRownumber
        '
        Me.txtRownumber.Location = New System.Drawing.Point(874, 383)
        Me.txtRownumber.Name = "txtRownumber"
        Me.txtRownumber.Size = New System.Drawing.Size(72, 20)
        Me.txtRownumber.TabIndex = 121
        Me.txtRownumber.Tag = ""
        Me.txtRownumber.Text = ""
        Me.txtRownumber.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(781, 382)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(24, 20)
        Me.Button2.TabIndex = 122
        Me.Button2.Text = "..."
        '
        'txtMrCode
        '
        Me.txtMrCode.Location = New System.Drawing.Point(874, 357)
        Me.txtMrCode.Name = "txtMrCode"
        Me.txtMrCode.Size = New System.Drawing.Size(72, 20)
        Me.txtMrCode.TabIndex = 123
        Me.txtMrCode.Tag = ""
        Me.txtMrCode.Text = ""
        Me.txtMrCode.Visible = False
        '
        'TxtEndDate
        '
        Me.TxtEndDate.BackColor = System.Drawing.SystemColors.Control
        Me.TxtEndDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEndDate.Location = New System.Drawing.Point(706, 457)
        Me.TxtEndDate.MaxLength = 10
        Me.TxtEndDate.Name = "TxtEndDate"
        Me.TxtEndDate.ReadOnly = True
        Me.TxtEndDate.Size = New System.Drawing.Size(200, 20)
        Me.TxtEndDate.TabIndex = 125
        Me.TxtEndDate.Tag = "Input"
        Me.TxtEndDate.Text = ""
        '
        'TxtStartDate
        '
        Me.TxtStartDate.Location = New System.Drawing.Point(706, 432)
        Me.TxtStartDate.MaxLength = 2
        Me.TxtStartDate.Name = "TxtStartDate"
        Me.TxtStartDate.Size = New System.Drawing.Size(200, 20)
        Me.TxtStartDate.TabIndex = 124
        Me.TxtStartDate.Tag = "Input"
        Me.TxtStartDate.Text = ""
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(177, 43)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 23)
        Me.Button1.TabIndex = 127
        Me.Button1.Tag = "View"
        '
        'frmBudgetPMR
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(991, 637)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtEndDate)
        Me.Controls.Add(Me.TxtStartDate)
        Me.Controls.Add(Me.txtMrCode)
        Me.Controls.Add(Me.txtRownumber)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.txtItemDesc)
        Me.Controls.Add(Me.txtItemCode)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblPmr)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.dgLineItem)
        Me.Controls.Add(Me.dgMonthlyBudget2)
        Me.Controls.Add(Me.dgMonthlyBudget1)
        Me.Controls.Add(Me.dgMedrepList)
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
        Me.Name = "frmBudgetPMR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PMR Budget"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgMedrepList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMonthlyBudget1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMonthlyBudget2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgLineItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Budget_Pmr_Insert()
        Dim BusinessObject As New BusinessLayer.clsBudgetPmr
        Dim Params(5) As SqlParameter
        Dim MrCode As New SqlParameter("@Mrcode", SqlDbType.VarChar, 25)
        MrCode.Direction = ParameterDirection.Input
        MrCode.Value = txtMrCode.Text
        Params(0) = MrCode
        Dim ItemCode As New SqlParameter("@ItemCode", SqlDbType.VarChar, 25)
        ItemCode.Direction = ParameterDirection.Input
        ItemCode.Value = txtItemCode.Text
        Params(1) = ItemCode
        Dim StartDate As New SqlParameter("@Start_Date", SqlDbType.DateTime, 10)
        StartDate.Direction = ParameterDirection.Input
        StartDate.Value = Trim(TxtStartDate.Text)   'Format(dtStartDate.Value, "Short Date")
        Params(2) = StartDate
        tmpSD = Trim(TxtStartDate.Text)
        Dim EndDate As New SqlParameter("@End_Date", SqlDbType.DateTime, 10)
        EndDate.Direction = ParameterDirection.Input
        EndDate.Value = Trim(TxtEndDate.Text)   'Format(dtEndDate.Value, "Short Date")
        Params(3) = EndDate
        tmpED = Trim(TxtEndDate.Text)
        Dim Qty As New SqlParameter("@Qty", SqlDbType.Int)
        Qty.Direction = ParameterDirection.Input
        Qty.Value = txtQty.Text
        Params(4) = Qty
        Dim Amount As New SqlParameter("@Amount", SqlDbType.Money)
        Amount.Direction = ParameterDirection.Input
        Amount.Value = txtAmount.Text
        Params(5) = Amount
        BusinessObject.Budget_Pmr_Insert(ServerPath2, "Budget_Pmr_Insert", CommandType.StoredProcedure, Params)
    End Sub

    Private Sub Budget_Pmr_Update()
        Dim BusinessObject As New BusinessLayer.clsBudgetPmr
        Dim Params(6) As SqlParameter
        Dim MrCode As New SqlParameter("@Mrcode", SqlDbType.VarChar, 25)
        MrCode.Direction = ParameterDirection.Input
        MrCode.Value = txtMrCode.Text
        Params(0) = MrCode
        Dim ItemCode As New SqlParameter("@ItemCode", SqlDbType.VarChar, 25)
        ItemCode.Direction = ParameterDirection.Input
        ItemCode.Value = txtItemCode.Text
        Params(1) = ItemCode
        Dim StartDate As New SqlParameter("@Start_Date", SqlDbType.DateTime, 10)
        StartDate.Direction = ParameterDirection.Input
        StartDate.Value = Trim(TxtStartDate.Text)   'Format(dtStartDate.Value, "Short Date")
        Params(2) = StartDate
        Dim EndDate As New SqlParameter("@End_Date", SqlDbType.DateTime, 10)
        EndDate.Direction = ParameterDirection.Input
        EndDate.Value = Trim(TxtEndDate.Text)   'Format(dtEndDate.Value, "Short Date")
        Params(3) = EndDate
        Dim Qty As New SqlParameter("@Qty", SqlDbType.Int)
        Qty.Direction = ParameterDirection.Input
        Qty.Value = txtQty.Text
        Params(4) = Qty
        Dim Amount As New SqlParameter("@Amount", SqlDbType.Money)
        Amount.Direction = ParameterDirection.Input
        Amount.Value = txtAmount.Text
        Params(5) = Amount
        Dim Rownumber As New SqlParameter("@Rownumber", SqlDbType.Int)
        Rownumber.Direction = ParameterDirection.Input
        Rownumber.Value = txtRownumber.Text
        Params(6) = Rownumber
        BusinessObject.Budget_Pmr_Update(ServerPath2, "Budget_Pmr_Update", CommandType.StoredProcedure, Params)
    End Sub

    Private Sub Budget_Pmr_Delete()
        Dim BusinessObject As New BusinessLayer.clsBudgetPmr
        Dim Params(0) As SqlParameter
        Dim Rownumber As New SqlParameter("@Rownumber", SqlDbType.Int)
        Rownumber.Direction = ParameterDirection.Input
        Rownumber.Value = txtRownumber.Text
        Params(0) = Rownumber
        BusinessObject.Budget_Pmr_Delete(ServerPath2, "Budget_Pmr_Delete", CommandType.StoredProcedure, Params)
        Budget_Pmr_ShowLineItem(currMedRep, CommDate)
        Refresh_dgMedrepList()
    End Sub

    Private Sub Budget_Pmr_ShowYear()
        Dim BusinessObject As New BusinessLayer.clsBudgetPmr
        BusinessObject.Budget_Pmr_ShowYear(ServerPath2, "Budget_Pmr_ShowYear", CommandType.StoredProcedure, _
        RemoteDataSet, "Year")
        cboYear.DataSource = RemoteDataSet.Year
        cboYear.DisplayMember = "Year"
    End Sub

    Private Sub Budget_Pmr_ShowMedrepList()
        RemoteDataSet.MedrepList.Clear()
        Dim BusinessObject As New BusinessLayer.clsBudgetPmr
        Dim Params(0) As SqlParameter
        Dim Year As New SqlParameter("@Year", SqlDbType.Int)
        Year.Direction = ParameterDirection.Input
        Year.Value = cboYear.Text
        Params(0) = Year
        BusinessObject.Budget_Pmr_ShowMedrepList(ServerPath2, "Budget_Pmr_ShowMedrepList", CommandType.StoredProcedure, _
        RemoteDataSet, "MedrepList", Params)
        dgMedrepList.DataSource = RemoteDataSet.MedrepList
    End Sub

    Private Sub Budget_Pmr_ShowMonthlyBudget(ByVal strMrCode As String)
        RemoteDataSet.Budget.Clear()
        Dim BusinessObject As New BusinessLayer.clsBudgetPmr
        Dim Params(1) As SqlParameter
        Dim MrCode As New SqlParameter("@MrCode", SqlDbType.VarChar, 25) : MrCode.Direction = ParameterDirection.Input : MrCode.Value = strMrCode : Params(0) = MrCode
        Dim Year As New SqlParameter("@Year", SqlDbType.Int) : Year.Direction = ParameterDirection.Input : Year.Value = cboYear.Text : Params(1) = Year
        BusinessObject.Budget_Pmr_ShowMonthlyBudget(ServerPath2, "Budget_Pmr_ShowMonthlyBudget", CommandType.StoredProcedure, _
        RemoteDataSet, "Budget", Params)
        dgMonthlyBudget1.DataSource = RemoteDataSet.Budget
        dgMonthlyBudget2.DataSource = RemoteDataSet.Budget
    End Sub

    Private Sub Budget_Pmr_ShowLineItem(ByVal strMrCode As String, ByVal strCommissionDate As String)
        RemoteDataSet.LineItem.Clear()
        Dim BusinessObject As New BusinessLayer.clsBudgetPmr
        Dim Params(1) As SqlParameter
        Dim MrCode As New SqlParameter("@MrCode", SqlDbType.VarChar, 25) : MrCode.Direction = ParameterDirection.Input : MrCode.Value = strMrCode : Params(0) = MrCode
        Dim CommissionDate As New SqlParameter("@CommissionDate", SqlDbType.DateTime, 10) : CommissionDate.Direction = ParameterDirection.Input : CommissionDate.Value = strCommissionDate : Params(1) = CommissionDate
        BusinessObject.Budget_Pmr_ShowLineItem(ServerPath2, "Budget_Pmr_ShowLineItem", CommandType.StoredProcedure, _
        RemoteDataSet, "LineItem", Params)
        dgLineItem.DataSource = RemoteDataSet.LineItem
    End Sub

    Private Sub Button1_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        If IsNumeric(cboYear.Text) Then
            Budget_Pmr_ShowMedrepList()
        End If
        cmdAdd.Enabled = False
        cmdEdit.Enabled = False
        cmdDelete.Enabled = False
    End Sub

    Private Sub dgMedrepList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgMedrepList.CurrentCellChanged, dgMedrepList.Click
        Refresh_dgMedrepList()
        cmdAdd.Enabled = True
        cmdEdit.Enabled = True
        cmdDelete.Enabled = True
        currMedRep = dgMedrepList.Item(dgMedrepList.CurrentCell.RowNumber, 0).ToString
    End Sub

    Private Sub dgMedrepList_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgMedrepList.MouseUp
        dgMedrepList.Select()
    End Sub

    Private Sub dgMonthlyBudget1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgMonthlyBudget1.CurrentCellChanged, dgMonthlyBudget1.Enter
        With dgMonthlyBudget1
            CommDate = CStr(.CurrentCell.ColumnNumber + 1) & "/1/" & CStr(cboYear.Text)
            Budget_Pmr_ShowLineItem(currMedRep, CommDate)
            dgLineItem.CaptionText = "Item Budget List" & " (" & CommDate & ")"
            cmdAdd.Enabled = True
            cmdEdit.Enabled = True
            cmdDelete.Enabled = True
        End With
    End Sub

    Private Sub dgMonthlyBudget2_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgMonthlyBudget2.CurrentCellChanged, dgMonthlyBudget2.Enter
        With dgMonthlyBudget2
            CommDate = CStr(.CurrentCell.ColumnNumber + 7) & "/1/" & CStr(cboYear.Text)
            Budget_Pmr_ShowLineItem(currMedRep, CommDate)
            dgLineItem.CaptionText = "Item Budget List" & " (" & CommDate & ")"
            cmdAdd.Enabled = True
            cmdEdit.Enabled = True
            cmdDelete.Enabled = True
        End With
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub dgLineItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgLineItem.Click, dgLineItem.CurrentCellChanged
        With dgLineItem
            txtItemCode.Text = .Item(.CurrentCell.RowNumber, 0).ToString
            txtItemDesc.Text = .Item(.CurrentCell.RowNumber, 1).ToString
            TxtStartDate.Text = .Item(.CurrentCell.RowNumber, 2).ToString
            TxtEndDate.Text = .Item(.CurrentCell.RowNumber, 3).ToString
            txtQty.Text = .Item(.CurrentCell.RowNumber, 4).ToString
            txtAmount.Text = Format((jVal(.Item(.CurrentCell.RowNumber, 5).ToString)), "#,##0.00")
            txtRownumber.Text = .Item(.CurrentCell.RowNumber, 6).ToString
        End With
    End Sub

    Private Sub dgLineItem_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgLineItem.MouseUp
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
        ControlMaintenance.EnableControls(Me, True)
        ControlMaintenance.ClearInputControls(Me)
        EditMode = False
        TxtStartDate.Text = tmpSD
        TxtEndDate.Text = tmpED
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Me.Cursor = Cursors.WaitCursor
        ControlMaintenance.EnableControls(Me, False)
        If EditMode = False Then
            Budget_Pmr_Insert()
        Else
            Budget_Pmr_Update()
        End If
        Budget_Pmr_ShowLineItem(currMedRep, CommDate)
        Refresh_dgMedrepList()
        Budget_Pmr_ShowMonthlyBudget(Trim(txtMrCode.Text)) '<-- added this to refresh the added value to the monthly grid
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
                Dim strMrCode As String = ""
                Dim CommissionDate As String
                strMrCode = CStr(dgMedrepList.Item(dgMedrepList.CurrentCell.RowNumber, 0))
                With dgMonthlyBudget1
                    CommissionDate = CStr(.CurrentCell.ColumnNumber + 1) & "/1/" & CStr(cboYear.Text)
                    Budget_Pmr_ShowLineItem(strMrCode, CommissionDate)
                End With
                ControlMaintenance.ClearInputControls(Me)
            End If
        End If
    End Sub

    Private Sub Refresh_dgMedrepList()
        Dim strMrCode As String = ""

        With dgMedrepList
            .Select(.CurrentCell.RowNumber)
            Try
                strMrCode = CStr(.Item(.CurrentCell.RowNumber, 0))
                Budget_Pmr_ShowMonthlyBudget(strMrCode)
                lblPmr.Text = CStr(.Item(.CurrentCell.RowNumber, 1))
                txtMrCode.Text = CStr(.Item(.CurrentCell.RowNumber, 0))
            Catch ex As Exception
                MessageBox.Show("Invalid Mrcode selection!", "Cast Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End With
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

    Private Sub TxtStartDate_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtStartDate.KeyUp
        If e.KeyValue = 13 Then      ' tests if the key pressed is the "enter key"
            SendKeys.Send("{TAB}")   ' sends the focus to the next control/tabstop
        End If
    End Sub

    Private Sub TxtStartDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtStartDate.Validating
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

    Private Sub Frm_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        EnDisMainMenu(Me, True)
        'ChildCtr = ChildCtr - 1              '<--ready for 2forms need
    End Sub

    Private Sub Frm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        EnDisMainMenu(Me, False)
    End Sub

    Private Sub frmProcessInMarketData_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        'If CloseFrm = True Then              '<- ready
        '    CloseFrm = False                 '<- for
        '    Close()                          '<- 2forms
        'End If                               '<- need
    End Sub
End Class