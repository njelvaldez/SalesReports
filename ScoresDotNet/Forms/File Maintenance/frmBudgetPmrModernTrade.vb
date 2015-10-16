Imports System.Data.SqlClient
Public Class frmBudgetPmrModernTrade
    Inherits System.Windows.Forms.Form
    Private RemoteDataSet As New BudgetMTD
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
    Friend WithEvents TxtEndDate As System.Windows.Forms.TextBox
    Friend WithEvents TxtStartDate As System.Windows.Forms.TextBox
    Friend WithEvents txtMrCode As System.Windows.Forms.TextBox
    Friend WithEvents txtRownumber As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents txtItemDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtItemCode As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lblPmr As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents dgLineItem As System.Windows.Forms.DataGrid
    Friend WithEvents dgMonthlyBudget2 As System.Windows.Forms.DataGrid
    Friend WithEvents dgMonthlyBudget1 As System.Windows.Forms.DataGrid
    Friend WithEvents dgMedrepList As System.Windows.Forms.DataGrid
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cboYear As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle3 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn15 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn16 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn17 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle4 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn18 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn19 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn20 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn21 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn22 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn23 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmBudgetPmrModernTrade))
        Me.TxtEndDate = New System.Windows.Forms.TextBox
        Me.TxtStartDate = New System.Windows.Forms.TextBox
        Me.txtMrCode = New System.Windows.Forms.TextBox
        Me.txtRownumber = New System.Windows.Forms.TextBox
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.txtItemDesc = New System.Windows.Forms.TextBox
        Me.txtItemCode = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.lblPmr = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.dgLineItem = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgMonthlyBudget2 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle4 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn18 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn19 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn20 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn21 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn22 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn23 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgMonthlyBudget1 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle3 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn17 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgMedrepList = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.cboYear = New System.Windows.Forms.ComboBox
        CType(Me.dgLineItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMonthlyBudget2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMonthlyBudget1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMedrepList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtEndDate
        '
        Me.TxtEndDate.BackColor = System.Drawing.SystemColors.Control
        Me.TxtEndDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEndDate.Location = New System.Drawing.Point(692, 432)
        Me.TxtEndDate.MaxLength = 10
        Me.TxtEndDate.Name = "TxtEndDate"
        Me.TxtEndDate.ReadOnly = True
        Me.TxtEndDate.Size = New System.Drawing.Size(200, 20)
        Me.TxtEndDate.TabIndex = 155
        Me.TxtEndDate.Tag = "Input"
        Me.TxtEndDate.Text = ""
        '
        'TxtStartDate
        '
        Me.TxtStartDate.Location = New System.Drawing.Point(692, 407)
        Me.TxtStartDate.MaxLength = 2
        Me.TxtStartDate.Name = "TxtStartDate"
        Me.TxtStartDate.Size = New System.Drawing.Size(200, 20)
        Me.TxtStartDate.TabIndex = 154
        Me.TxtStartDate.Tag = "Input"
        Me.TxtStartDate.Text = ""
        '
        'txtMrCode
        '
        Me.txtMrCode.Location = New System.Drawing.Point(860, 332)
        Me.txtMrCode.Name = "txtMrCode"
        Me.txtMrCode.Size = New System.Drawing.Size(72, 20)
        Me.txtMrCode.TabIndex = 153
        Me.txtMrCode.Tag = ""
        Me.txtMrCode.Text = ""
        Me.txtMrCode.Visible = False
        '
        'txtRownumber
        '
        Me.txtRownumber.Location = New System.Drawing.Point(860, 358)
        Me.txtRownumber.Name = "txtRownumber"
        Me.txtRownumber.Size = New System.Drawing.Size(72, 20)
        Me.txtRownumber.TabIndex = 151
        Me.txtRownumber.Tag = ""
        Me.txtRownumber.Text = ""
        Me.txtRownumber.Visible = False
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(692, 482)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(112, 20)
        Me.txtAmount.TabIndex = 147
        Me.txtAmount.Tag = "Input"
        Me.txtAmount.Text = ""
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(692, 457)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(72, 20)
        Me.txtQty.TabIndex = 146
        Me.txtQty.Tag = "Input"
        Me.txtQty.Text = ""
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtItemDesc
        '
        Me.txtItemDesc.Location = New System.Drawing.Point(692, 382)
        Me.txtItemDesc.Name = "txtItemDesc"
        Me.txtItemDesc.Size = New System.Drawing.Size(240, 20)
        Me.txtItemDesc.TabIndex = 145
        Me.txtItemDesc.Tag = "Input"
        Me.txtItemDesc.Text = ""
        '
        'txtItemCode
        '
        Me.txtItemCode.Location = New System.Drawing.Point(692, 357)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(72, 20)
        Me.txtItemCode.TabIndex = 144
        Me.txtItemCode.Tag = "Input"
        Me.txtItemCode.Text = ""
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(767, 357)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(24, 20)
        Me.Button2.TabIndex = 152
        Me.Button2.Text = "..."
        '
        'lblPmr
        '
        Me.lblPmr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPmr.Location = New System.Drawing.Point(692, 332)
        Me.lblPmr.Name = "lblPmr"
        Me.lblPmr.Size = New System.Drawing.Size(240, 20)
        Me.lblPmr.TabIndex = 148
        Me.lblPmr.Tag = ""
        Me.lblPmr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(588, 332)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 20)
        Me.Label7.TabIndex = 143
        Me.Label7.Text = "PMR"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(588, 482)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 20)
        Me.Label6.TabIndex = 142
        Me.Label6.Text = "Amount"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(588, 457)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 20)
        Me.Label5.TabIndex = 141
        Me.Label5.Text = "Qty"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(588, 432)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 140
        Me.Label4.Text = "End Date"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(588, 407)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 139
        Me.Label3.Text = "Start Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(588, 382)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 138
        Me.Label2.Text = "Item Desc"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(588, 357)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 137
        Me.Label1.Text = "Item Code"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(562, 317)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(387, 195)
        Me.PictureBox4.TabIndex = 136
        Me.PictureBox4.TabStop = False
        '
        'cmdExit
        '
        Me.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(851, 523)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(90, 53)
        Me.cmdExit.TabIndex = 134
        Me.cmdExit.Tag = "Exit"
        '
        'cmdAdd
        '
        Me.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdAdd.Image = CType(resources.GetObject("cmdAdd.Image"), System.Drawing.Image)
        Me.cmdAdd.Location = New System.Drawing.Point(574, 523)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(90, 53)
        Me.cmdAdd.TabIndex = 131
        Me.cmdAdd.Tag = "Add"
        '
        'dgLineItem
        '
        Me.dgLineItem.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgLineItem.BackColor = System.Drawing.Color.Gainsboro
        Me.dgLineItem.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgLineItem.CaptionBackColor = System.Drawing.Color.Crimson
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
        Me.dgLineItem.Location = New System.Drawing.Point(566, 52)
        Me.dgLineItem.Name = "dgLineItem"
        Me.dgLineItem.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgLineItem.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgLineItem.ReadOnly = True
        Me.dgLineItem.RowHeadersVisible = False
        Me.dgLineItem.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgLineItem.SelectionForeColor = System.Drawing.Color.White
        Me.dgLineItem.Size = New System.Drawing.Size(383, 264)
        Me.dgLineItem.TabIndex = 129
        Me.dgLineItem.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        Me.dgLineItem.Tag = "View"
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.dgLineItem
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "lineitem"
        Me.DataGridTableStyle2.RowHeadersVisible = False
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Code"
        Me.DataGridTextBoxColumn5.MappingName = "itemcode"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 50
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Description"
        Me.DataGridTextBoxColumn6.MappingName = "itemdesc"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 202
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Start"
        Me.DataGridTextBoxColumn7.MappingName = "start_date"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 0
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "End"
        Me.DataGridTextBoxColumn8.MappingName = "end_date"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 0
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "Qty"
        Me.DataGridTextBoxColumn9.MappingName = "qty"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 40
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn10.Format = "#,#00.00"
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "Amount"
        Me.DataGridTextBoxColumn10.MappingName = "amount"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.Width = 85
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.MappingName = "rownumber"
        Me.DataGridTextBoxColumn11.Width = 0
        '
        'dgMonthlyBudget2
        '
        Me.dgMonthlyBudget2.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgMonthlyBudget2.BackColor = System.Drawing.Color.Gainsboro
        Me.dgMonthlyBudget2.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgMonthlyBudget2.CaptionBackColor = System.Drawing.Color.Crimson
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
        Me.dgMonthlyBudget2.Location = New System.Drawing.Point(34, 533)
        Me.dgMonthlyBudget2.Name = "dgMonthlyBudget2"
        Me.dgMonthlyBudget2.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgMonthlyBudget2.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgMonthlyBudget2.ReadOnly = True
        Me.dgMonthlyBudget2.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgMonthlyBudget2.SelectionForeColor = System.Drawing.Color.White
        Me.dgMonthlyBudget2.Size = New System.Drawing.Size(515, 60)
        Me.dgMonthlyBudget2.TabIndex = 128
        Me.dgMonthlyBudget2.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle4})
        Me.dgMonthlyBudget2.Tag = "View"
        '
        'DataGridTableStyle4
        '
        Me.DataGridTableStyle4.DataGrid = Me.dgMonthlyBudget2
        Me.DataGridTableStyle4.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn18, Me.DataGridTextBoxColumn19, Me.DataGridTextBoxColumn20, Me.DataGridTextBoxColumn21, Me.DataGridTextBoxColumn22, Me.DataGridTextBoxColumn23})
        Me.DataGridTableStyle4.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle4.MappingName = "Budget"
        Me.DataGridTableStyle4.RowHeadersVisible = False
        '
        'DataGridTextBoxColumn18
        '
        Me.DataGridTextBoxColumn18.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn18.Format = "#,##0.00"
        Me.DataGridTextBoxColumn18.FormatInfo = Nothing
        Me.DataGridTextBoxColumn18.HeaderText = "Jul"
        Me.DataGridTextBoxColumn18.MappingName = "july"
        Me.DataGridTextBoxColumn18.NullText = ""
        Me.DataGridTextBoxColumn18.Width = 85
        '
        'DataGridTextBoxColumn19
        '
        Me.DataGridTextBoxColumn19.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn19.Format = "#,##0.00"
        Me.DataGridTextBoxColumn19.FormatInfo = Nothing
        Me.DataGridTextBoxColumn19.HeaderText = "Aug"
        Me.DataGridTextBoxColumn19.MappingName = "august"
        Me.DataGridTextBoxColumn19.NullText = ""
        Me.DataGridTextBoxColumn19.Width = 85
        '
        'DataGridTextBoxColumn20
        '
        Me.DataGridTextBoxColumn20.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn20.Format = "#,##0.00"
        Me.DataGridTextBoxColumn20.FormatInfo = Nothing
        Me.DataGridTextBoxColumn20.HeaderText = "Sep"
        Me.DataGridTextBoxColumn20.MappingName = "september"
        Me.DataGridTextBoxColumn20.NullText = ""
        Me.DataGridTextBoxColumn20.Width = 85
        '
        'DataGridTextBoxColumn21
        '
        Me.DataGridTextBoxColumn21.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn21.Format = "#,##0.00"
        Me.DataGridTextBoxColumn21.FormatInfo = Nothing
        Me.DataGridTextBoxColumn21.HeaderText = "Oct"
        Me.DataGridTextBoxColumn21.MappingName = "october"
        Me.DataGridTextBoxColumn21.NullText = ""
        Me.DataGridTextBoxColumn21.Width = 85
        '
        'DataGridTextBoxColumn22
        '
        Me.DataGridTextBoxColumn22.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn22.Format = "#,##0.00"
        Me.DataGridTextBoxColumn22.FormatInfo = Nothing
        Me.DataGridTextBoxColumn22.HeaderText = "Nov"
        Me.DataGridTextBoxColumn22.MappingName = "november"
        Me.DataGridTextBoxColumn22.NullText = ""
        Me.DataGridTextBoxColumn22.Width = 85
        '
        'DataGridTextBoxColumn23
        '
        Me.DataGridTextBoxColumn23.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn23.Format = "#,##0.00"
        Me.DataGridTextBoxColumn23.FormatInfo = Nothing
        Me.DataGridTextBoxColumn23.HeaderText = "Dec"
        Me.DataGridTextBoxColumn23.MappingName = "december"
        Me.DataGridTextBoxColumn23.NullText = ""
        Me.DataGridTextBoxColumn23.Width = 85
        '
        'dgMonthlyBudget1
        '
        Me.dgMonthlyBudget1.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgMonthlyBudget1.BackColor = System.Drawing.Color.Gainsboro
        Me.dgMonthlyBudget1.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgMonthlyBudget1.CaptionBackColor = System.Drawing.Color.Crimson
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
        Me.dgMonthlyBudget1.Location = New System.Drawing.Point(34, 468)
        Me.dgMonthlyBudget1.Name = "dgMonthlyBudget1"
        Me.dgMonthlyBudget1.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgMonthlyBudget1.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgMonthlyBudget1.ReadOnly = True
        Me.dgMonthlyBudget1.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgMonthlyBudget1.SelectionForeColor = System.Drawing.Color.White
        Me.dgMonthlyBudget1.Size = New System.Drawing.Size(515, 60)
        Me.dgMonthlyBudget1.TabIndex = 127
        Me.dgMonthlyBudget1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle3})
        Me.dgMonthlyBudget1.Tag = "View"
        '
        'DataGridTableStyle3
        '
        Me.DataGridTableStyle3.DataGrid = Me.dgMonthlyBudget1
        Me.DataGridTableStyle3.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn16, Me.DataGridTextBoxColumn17})
        Me.DataGridTableStyle3.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle3.MappingName = "Budget"
        Me.DataGridTableStyle3.RowHeadersVisible = False
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn12.Format = "#,##0.00"
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "Jan"
        Me.DataGridTextBoxColumn12.MappingName = "january"
        Me.DataGridTextBoxColumn12.NullText = ""
        Me.DataGridTextBoxColumn12.Width = 85
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn13.Format = "#,##0.00"
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "Feb"
        Me.DataGridTextBoxColumn13.MappingName = "february"
        Me.DataGridTextBoxColumn13.NullText = ""
        Me.DataGridTextBoxColumn13.Width = 85
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn14.Format = "#,##0.00"
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "Mar"
        Me.DataGridTextBoxColumn14.MappingName = "march"
        Me.DataGridTextBoxColumn14.NullText = ""
        Me.DataGridTextBoxColumn14.Width = 85
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn15.Format = "#,##0.00"
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "Apr"
        Me.DataGridTextBoxColumn15.MappingName = "april"
        Me.DataGridTextBoxColumn15.NullText = ""
        Me.DataGridTextBoxColumn15.Width = 85
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn16.Format = "#,##0.00"
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.HeaderText = "May"
        Me.DataGridTextBoxColumn16.MappingName = "may"
        Me.DataGridTextBoxColumn16.NullText = ""
        Me.DataGridTextBoxColumn16.Width = 85
        '
        'DataGridTextBoxColumn17
        '
        Me.DataGridTextBoxColumn17.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn17.Format = "#,##0.00"
        Me.DataGridTextBoxColumn17.FormatInfo = Nothing
        Me.DataGridTextBoxColumn17.HeaderText = "Jun"
        Me.DataGridTextBoxColumn17.MappingName = "june"
        Me.DataGridTextBoxColumn17.NullText = ""
        Me.DataGridTextBoxColumn17.Width = 85
        '
        'dgMedrepList
        '
        Me.dgMedrepList.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgMedrepList.BackColor = System.Drawing.Color.Gainsboro
        Me.dgMedrepList.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgMedrepList.CaptionBackColor = System.Drawing.Color.Crimson
        Me.dgMedrepList.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgMedrepList.CaptionForeColor = System.Drawing.Color.White
        Me.dgMedrepList.CaptionText = "Modern Trade Medrep List"
        Me.dgMedrepList.DataMember = ""
        Me.dgMedrepList.FlatMode = True
        Me.dgMedrepList.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.dgMedrepList.ForeColor = System.Drawing.Color.Black
        Me.dgMedrepList.GridLineColor = System.Drawing.Color.Silver
        Me.dgMedrepList.HeaderBackColor = System.Drawing.Color.Black
        Me.dgMedrepList.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgMedrepList.HeaderForeColor = System.Drawing.Color.White
        Me.dgMedrepList.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgMedrepList.Location = New System.Drawing.Point(34, 45)
        Me.dgMedrepList.Name = "dgMedrepList"
        Me.dgMedrepList.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgMedrepList.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgMedrepList.ReadOnly = True
        Me.dgMedrepList.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgMedrepList.SelectionForeColor = System.Drawing.Color.White
        Me.dgMedrepList.Size = New System.Drawing.Size(515, 417)
        Me.dgMedrepList.TabIndex = 126
        Me.dgMedrepList.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.dgMedrepList.Tag = "View"
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgMedrepList
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "medreplist"
        Me.DataGridTableStyle1.RowHeadersVisible = False
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Code"
        Me.DataGridTextBoxColumn1.MappingName = "supcode"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 70
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Name"
        Me.DataGridTextBoxColumn2.MappingName = "supname"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 238
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Hire Date"
        Me.DataGridTextBoxColumn3.MappingName = "hire_date"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 93
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Resign Date"
        Me.DataGridTextBoxColumn4.MappingName = "resign_date"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 93
        '
        'cmdEdit
        '
        Me.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.Location = New System.Drawing.Point(666, 523)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(90, 53)
        Me.cmdEdit.TabIndex = 132
        Me.cmdEdit.Tag = "Edit"
        '
        'cmdCancel
        '
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdCancel.Image = CType(resources.GetObject("cmdCancel.Image"), System.Drawing.Image)
        Me.cmdCancel.Location = New System.Drawing.Point(666, 523)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(90, 53)
        Me.cmdCancel.TabIndex = 149
        Me.cmdCancel.Tag = "Cancel"
        '
        'cmdDelete
        '
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.Location = New System.Drawing.Point(758, 523)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(90, 53)
        Me.cmdDelete.TabIndex = 133
        Me.cmdDelete.Tag = "Delete"
        '
        'cmdSave
        '
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.Location = New System.Drawing.Point(758, 523)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(90, 53)
        Me.cmdSave.TabIndex = 150
        Me.cmdSave.Tag = "Save"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(572, 521)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(371, 66)
        Me.PictureBox2.TabIndex = 135
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Gray
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(555, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(404, 548)
        Me.PictureBox1.TabIndex = 130
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(163, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 23)
        Me.Button1.TabIndex = 157
        Me.Button1.Tag = "View"
        '
        'cboYear
        '
        Me.cboYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYear.ForeColor = System.Drawing.Color.Black
        Me.cboYear.Location = New System.Drawing.Point(35, 16)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(120, 24)
        Me.cboYear.TabIndex = 156
        Me.cboYear.Tag = "View"
        '
        'frmBudgetPmrModernTrade
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(993, 639)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cboYear)
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
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmBudgetPmrModernTrade"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBudgetPmrModernTrade"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgLineItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMonthlyBudget2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMonthlyBudget1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMedrepList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Budget_Pmr_Insert()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
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
        BusinessObject.Sub_Insert(ServerPath2, "Budget_Pmr_InsertMTD", CommandType.StoredProcedure, Params)
    End Sub

    Private Sub Budget_Pmr_Update()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
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
        BusinessObject.Sub_Update(ServerPath2, "Budget_Pmr_UpdateMTD", CommandType.StoredProcedure, Params)
    End Sub

    Private Sub Budget_Pmr_Delete()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter
        Dim Rownumber As New SqlParameter("@Rownumber", SqlDbType.Int)
        Rownumber.Direction = ParameterDirection.Input
        Rownumber.Value = txtRownumber.Text
        Params(0) = Rownumber
        BusinessObject.Sub_Delete(ServerPath2, "Budget_Pmr_DeleteMTD", CommandType.StoredProcedure, _
                                  Params)
        Budget_Pmr_ShowLineItem(currMedRep, CommDate)
        Refresh_dgMedrepList()
    End Sub

    Private Sub Budget_Pmr_ShowYear()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "Budget_Pmr_ShowYearMTD", CommandType.StoredProcedure, _
                                RemoteDataSet, "Year")
        cboYear.DataSource = RemoteDataSet.Year
        cboYear.DisplayMember = "Year"
    End Sub

    Private Sub Budget_Pmr_ShowMedrepList()
        RemoteDataSet.MedrepList.Clear()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter
        Dim Year As New SqlParameter("@Year", SqlDbType.Int)
        Year.Direction = ParameterDirection.Input
        Year.Value = cboYear.Text
        Params(0) = Year
        BusinessObject.Sub_Show(ServerPath2, "Budget_Pmr_ShowMedrepListMTD", _
                                                 CommandType.StoredProcedure, RemoteDataSet, _
                                                 "MedrepList", Params)
        dgMedrepList.DataSource = RemoteDataSet.MedrepList
    End Sub

    Private Sub Budget_Pmr_ShowMonthlyBudget(ByVal strMrCode As String)
        RemoteDataSet.Budget.Clear()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(1) As SqlParameter
        Dim MrCode As New SqlParameter("@MrCode", SqlDbType.VarChar, 25) : MrCode.Direction = ParameterDirection.Input : MrCode.Value = strMrCode : Params(0) = MrCode
        Dim Year As New SqlParameter("@Year", SqlDbType.Int) : Year.Direction = ParameterDirection.Input : Year.Value = cboYear.Text : Params(1) = Year
        BusinessObject.Sub_Show(ServerPath2, "Budget_Pmr_ShowMonthlyBudgetMTD", _
                                                    CommandType.StoredProcedure, RemoteDataSet, _
                                                    "Budget", Params)
        dgMonthlyBudget1.DataSource = RemoteDataSet.Budget
        dgMonthlyBudget2.DataSource = RemoteDataSet.Budget
    End Sub

    Private Sub Budget_Pmr_ShowLineItem(ByVal strMrCode As String, ByVal strCommissionDate As String)
        RemoteDataSet.LineItem.Clear()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(1) As SqlParameter
        Dim MrCode As New SqlParameter("@MrCode", SqlDbType.VarChar, 25) : MrCode.Direction = ParameterDirection.Input : MrCode.Value = strMrCode : Params(0) = MrCode
        Dim CommissionDate As New SqlParameter("@CommissionDate", SqlDbType.DateTime, 10) : CommissionDate.Direction = ParameterDirection.Input : CommissionDate.Value = strCommissionDate : Params(1) = CommissionDate
        BusinessObject.Sub_Show(ServerPath2, "Budget_Pmr_ShowLineItemMTD", _
                                               CommandType.StoredProcedure, RemoteDataSet, _
                                               "LineItem", Params)
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

    Private Sub frmBudgetPmrModernTrade_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
