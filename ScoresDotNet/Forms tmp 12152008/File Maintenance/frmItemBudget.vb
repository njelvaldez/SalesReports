Imports System.Data.SqlClient
Public Class frmItemBudget3
    Inherits System.Windows.Forms.Form
    Private RemoteDataSet As New MyDataSetDB
    Private RemoteDataSet2 As New Budget
    Private EditMode As Boolean = False
    Private tmpSD As String, tmpED As String

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
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgLineItem As System.Windows.Forms.DataGrid
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtItemCode As System.Windows.Forms.TextBox
    Friend WithEvents txtItemDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtRownumber As System.Windows.Forms.TextBox
    Friend WithEvents TxtEndDate As System.Windows.Forms.TextBox
    Friend WithEvents TxtStartDate As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents dgItemBudget As System.Windows.Forms.DataGrid
    Friend WithEvents dgDivisionIBL As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgStartDateIBL As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgEndDateIBL As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgQtyIBL As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgAmountIBL As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgRownumberIBL As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgCreateDateIBL As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgUpdateDateIBL As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents txtUpdateDate As System.Windows.Forms.TextBox
    Friend WithEvents txtCreateDate As System.Windows.Forms.TextBox
    Friend WithEvents TxtLastUser As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmItemBudget3))
        Me.cboYear = New System.Windows.Forms.ComboBox
        Me.dgLineItem = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtItemCode = New System.Windows.Forms.TextBox
        Me.txtItemDesc = New System.Windows.Forms.TextBox
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.txtRownumber = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.TxtEndDate = New System.Windows.Forms.TextBox
        Me.TxtStartDate = New System.Windows.Forms.TextBox
        Me.txtUpdateDate = New System.Windows.Forms.TextBox
        Me.txtCreateDate = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.dgItemBudget = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.dgDivisionIBL = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgStartDateIBL = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgEndDateIBL = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgQtyIBL = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgAmountIBL = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgRownumberIBL = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgCreateDateIBL = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgUpdateDateIBL = New System.Windows.Forms.DataGridTextBoxColumn
        Me.TxtLastUser = New System.Windows.Forms.TextBox
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
        Me.dgLineItem.Size = New System.Drawing.Size(550, 219)
        Me.dgLineItem.TabIndex = 2
        Me.dgLineItem.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        Me.dgLineItem.Tag = "View"
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.AlternatingBackColor = System.Drawing.Color.Aqua
        Me.DataGridTableStyle2.BackColor = System.Drawing.Color.LightCyan
        Me.DataGridTableStyle2.DataGrid = Me.dgLineItem
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "LineItem"
        Me.DataGridTableStyle2.RowHeadersVisible = False
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Items"
        Me.DataGridTextBoxColumn7.MappingName = "AllItem"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 230
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "Units"
        Me.DataGridTextBoxColumn8.MappingName = "ItemUnit"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 75
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "  Principals"
        Me.DataGridTextBoxColumn9.MappingName = "ItmPrincipal"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 200
        '
        'cmdAdd
        '
        Me.cmdAdd.BackgroundImage = CType(resources.GetObject("cmdAdd.BackgroundImage"), System.Drawing.Image)
        Me.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdAdd.Location = New System.Drawing.Point(585, 366)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(90, 53)
        Me.cmdAdd.TabIndex = 97
        Me.cmdAdd.Tag = "Add"
        '
        'cmdEdit
        '
        Me.cmdEdit.BackgroundImage = CType(resources.GetObject("cmdEdit.BackgroundImage"), System.Drawing.Image)
        Me.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdEdit.Location = New System.Drawing.Point(677, 366)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(90, 53)
        Me.cmdEdit.TabIndex = 98
        Me.cmdEdit.Tag = "Edit"
        '
        'cmdDelete
        '
        Me.cmdDelete.BackgroundImage = CType(resources.GetObject("cmdDelete.BackgroundImage"), System.Drawing.Image)
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDelete.Location = New System.Drawing.Point(769, 366)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(90, 53)
        Me.cmdDelete.TabIndex = 99
        Me.cmdDelete.Tag = "Delete"
        '
        'cmdExit
        '
        Me.cmdExit.BackgroundImage = CType(resources.GetObject("cmdExit.BackgroundImage"), System.Drawing.Image)
        Me.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdExit.Location = New System.Drawing.Point(861, 366)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(90, 53)
        Me.cmdExit.TabIndex = 100
        Me.cmdExit.Tag = "Exit"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(583, 364)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(371, 66)
        Me.PictureBox2.TabIndex = 101
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Gray
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(569, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(400, 405)
        Me.PictureBox1.TabIndex = 95
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(615, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Item Code"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(615, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "Item Desc"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(615, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "Start Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(615, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 20)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "End Date"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(615, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 20)
        Me.Label5.TabIndex = 108
        Me.Label5.Text = "Qty"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(615, 272)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 20)
        Me.Label6.TabIndex = 109
        Me.Label6.Text = "Amount"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtItemCode
        '
        Me.txtItemCode.Location = New System.Drawing.Point(690, 83)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(72, 20)
        Me.txtItemCode.TabIndex = 112
        Me.txtItemCode.Tag = "Input"
        Me.txtItemCode.Text = ""
        '
        'txtItemDesc
        '
        Me.txtItemDesc.Location = New System.Drawing.Point(690, 110)
        Me.txtItemDesc.Name = "txtItemDesc"
        Me.txtItemDesc.Size = New System.Drawing.Size(240, 20)
        Me.txtItemDesc.TabIndex = 113
        Me.txtItemDesc.Tag = "Input"
        Me.txtItemDesc.Text = ""
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(690, 245)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(72, 20)
        Me.txtQty.TabIndex = 116
        Me.txtQty.Tag = "Input"
        Me.txtQty.Text = ""
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(690, 272)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(112, 20)
        Me.txtAmount.TabIndex = 117
        Me.txtAmount.Tag = "Input"
        Me.txtAmount.Text = ""
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdCancel
        '
        Me.cmdCancel.BackgroundImage = CType(resources.GetObject("cmdCancel.BackgroundImage"), System.Drawing.Image)
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdCancel.Location = New System.Drawing.Point(677, 366)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(90, 53)
        Me.cmdCancel.TabIndex = 119
        Me.cmdCancel.Tag = "Cancel"
        '
        'cmdSave
        '
        Me.cmdSave.BackgroundImage = CType(resources.GetObject("cmdSave.BackgroundImage"), System.Drawing.Image)
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSave.Location = New System.Drawing.Point(769, 366)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(90, 53)
        Me.cmdSave.TabIndex = 120
        Me.cmdSave.Tag = "Save"
        '
        'txtRownumber
        '
        Me.txtRownumber.Location = New System.Drawing.Point(858, 83)
        Me.txtRownumber.Name = "txtRownumber"
        Me.txtRownumber.Size = New System.Drawing.Size(72, 20)
        Me.txtRownumber.TabIndex = 121
        Me.txtRownumber.Tag = ""
        Me.txtRownumber.Text = ""
        Me.txtRownumber.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(765, 83)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(24, 20)
        Me.Button2.TabIndex = 122
        Me.Button2.Text = "..."
        '
        'TxtEndDate
        '
        Me.TxtEndDate.BackColor = System.Drawing.SystemColors.Info
        Me.TxtEndDate.Location = New System.Drawing.Point(690, 164)
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
        Me.TxtStartDate.Location = New System.Drawing.Point(690, 137)
        Me.TxtStartDate.MaxLength = 2
        Me.TxtStartDate.Name = "TxtStartDate"
        Me.TxtStartDate.Size = New System.Drawing.Size(200, 20)
        Me.TxtStartDate.TabIndex = 124
        Me.TxtStartDate.Tag = "Input"
        Me.TxtStartDate.Text = ""
        '
        'txtUpdateDate
        '
        Me.txtUpdateDate.BackColor = System.Drawing.SystemColors.Info
        Me.txtUpdateDate.Location = New System.Drawing.Point(690, 218)
        Me.txtUpdateDate.MaxLength = 10
        Me.txtUpdateDate.Name = "txtUpdateDate"
        Me.txtUpdateDate.ReadOnly = True
        Me.txtUpdateDate.Size = New System.Drawing.Size(200, 20)
        Me.txtUpdateDate.TabIndex = 130
        Me.txtUpdateDate.Tag = "Input"
        Me.txtUpdateDate.Text = ""
        '
        'txtCreateDate
        '
        Me.txtCreateDate.BackColor = System.Drawing.SystemColors.Info
        Me.txtCreateDate.Location = New System.Drawing.Point(690, 191)
        Me.txtCreateDate.MaxLength = 2
        Me.txtCreateDate.Name = "txtCreateDate"
        Me.txtCreateDate.ReadOnly = True
        Me.txtCreateDate.Size = New System.Drawing.Size(200, 20)
        Me.txtCreateDate.TabIndex = 129
        Me.txtCreateDate.Tag = "Input"
        Me.txtCreateDate.Text = ""
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Location = New System.Drawing.Point(615, 218)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 20)
        Me.Label9.TabIndex = 128
        Me.Label9.Text = "Update Date"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Location = New System.Drawing.Point(615, 191)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 20)
        Me.Label10.TabIndex = 127
        Me.Label10.Text = "Create Date"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(579, 51)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(382, 263)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 131
        Me.PictureBox4.TabStop = False
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(133, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Tag = "View"
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
        Me.dgItemBudget.Location = New System.Drawing.Point(5, 257)
        Me.dgItemBudget.Name = "dgItemBudget"
        Me.dgItemBudget.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgItemBudget.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgItemBudget.ReadOnly = True
        Me.dgItemBudget.RowHeaderWidth = 0
        Me.dgItemBudget.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgItemBudget.SelectionForeColor = System.Drawing.Color.White
        Me.dgItemBudget.Size = New System.Drawing.Size(550, 183)
        Me.dgItemBudget.TabIndex = 3
        Me.dgItemBudget.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.dgItemBudget.Tag = "View"
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Aqua
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.Azure
        Me.DataGridTableStyle1.ColumnHeadersVisible = False
        Me.DataGridTableStyle1.DataGrid = Me.dgItemBudget
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.dgDivisionIBL, Me.dgStartDateIBL, Me.dgEndDateIBL, Me.dgQtyIBL, Me.dgAmountIBL, Me.dgRownumberIBL, Me.dgCreateDateIBL, Me.dgUpdateDateIBL})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "ItemBudget"
        Me.DataGridTableStyle1.RowHeadersVisible = False
        Me.DataGridTableStyle1.RowHeaderWidth = 0
        '
        'dgDivisionIBL
        '
        Me.dgDivisionIBL.Format = ""
        Me.dgDivisionIBL.FormatInfo = Nothing
        Me.dgDivisionIBL.HeaderText = "Division"
        Me.dgDivisionIBL.MappingName = "divname"
        Me.dgDivisionIBL.NullText = ""
        Me.dgDivisionIBL.Width = 230
        '
        'dgStartDateIBL
        '
        Me.dgStartDateIBL.Format = "MM/dd/yyyy"
        Me.dgStartDateIBL.FormatInfo = Nothing
        Me.dgStartDateIBL.HeaderText = "Start Date"
        Me.dgStartDateIBL.MappingName = "start_date"
        Me.dgStartDateIBL.NullText = ""
        Me.dgStartDateIBL.Width = 70
        '
        'dgEndDateIBL
        '
        Me.dgEndDateIBL.Format = "MM/dd/yyyy"
        Me.dgEndDateIBL.FormatInfo = Nothing
        Me.dgEndDateIBL.HeaderText = "End Date"
        Me.dgEndDateIBL.MappingName = "end_date"
        Me.dgEndDateIBL.NullText = ""
        Me.dgEndDateIBL.Width = 70
        '
        'dgQtyIBL
        '
        Me.dgQtyIBL.Format = "#,##0.00"
        Me.dgQtyIBL.FormatInfo = Nothing
        Me.dgQtyIBL.HeaderText = "Qty"
        Me.dgQtyIBL.MappingName = "qty"
        Me.dgQtyIBL.NullText = ""
        Me.dgQtyIBL.Width = 75
        '
        'dgAmountIBL
        '
        Me.dgAmountIBL.Format = "#,##0.00"
        Me.dgAmountIBL.FormatInfo = Nothing
        Me.dgAmountIBL.HeaderText = "Amount"
        Me.dgAmountIBL.MappingName = "amount"
        Me.dgAmountIBL.NullText = ""
        Me.dgAmountIBL.Width = 125
        '
        'dgRownumberIBL
        '
        Me.dgRownumberIBL.Format = ""
        Me.dgRownumberIBL.FormatInfo = Nothing
        Me.dgRownumberIBL.MappingName = "rownumber"
        Me.dgRownumberIBL.NullText = ""
        Me.dgRownumberIBL.Width = 0
        '
        'dgCreateDateIBL
        '
        Me.dgCreateDateIBL.Format = ""
        Me.dgCreateDateIBL.FormatInfo = Nothing
        Me.dgCreateDateIBL.MappingName = "createdate"
        Me.dgCreateDateIBL.NullText = ""
        Me.dgCreateDateIBL.Width = 0
        '
        'dgUpdateDateIBL
        '
        Me.dgUpdateDateIBL.Format = ""
        Me.dgUpdateDateIBL.FormatInfo = Nothing
        Me.dgUpdateDateIBL.MappingName = "updatedate"
        Me.dgUpdateDateIBL.NullText = ""
        Me.dgUpdateDateIBL.Width = 0
        '
        'TxtLastUser
        '
        Me.TxtLastUser.Location = New System.Drawing.Point(773, 244)
        Me.TxtLastUser.Name = "TxtLastUser"
        Me.TxtLastUser.Size = New System.Drawing.Size(48, 20)
        Me.TxtLastUser.TabIndex = 132
        Me.TxtLastUser.Tag = "Input"
        Me.TxtLastUser.Text = ""
        Me.TxtLastUser.Visible = False
        '
        'frmItemBudget3
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(976, 445)
        Me.Controls.Add(Me.TxtLastUser)
        Me.Controls.Add(Me.dgItemBudget)
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
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.dgLineItem)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cboYear)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmItemBudget3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Item Budget Direct List"
        CType(Me.dgLineItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgItemBudget, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim xDat As String
        ControlMaintenance.EnableControls(Me, True)
        ControlMaintenance.ClearInputControls(Me)
        EditMode = False
        xDat = GetDateTimeNow("MM/dd/yyyy")
        TxtStartDate.Text = Mid(xDat, 1, 3) & "01" & Mid(xDat, 6, 5)
        TxtEndDate.Text = GetEOM(xDat)
        txtCreateDate.Text = xDat
        txtUpdateDate.Text = xDat
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
                'strMrCode = CStr(dgMedrepList.Item(dgMedrepList.CurrentCell.RowNumber, 0))
                With dgItemBudget
                    CommissionDate = CStr(.CurrentCell.ColumnNumber + 1) & "/1/" & CStr(cboYear.Text)
                    Budget_Pmr_ShowLineItem(strMrCode, CommissionDate)
                End With
                ControlMaintenance.ClearInputControls(Me)
            End If
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Me.Cursor = Cursors.WaitCursor
        ControlMaintenance.EnableControls(Me, False)
        If EditMode = False Then
            Budget_Pmr_Insert()
        Else
            Budget_Pmr_Update()
        End If
        Dim strMrCode As String = ""
        Dim CommissionDate As String
        'strMrCode = CStr(dgMedrepList.Item(dgMedrepList.CurrentCell.RowNumber, 0))
        With dgItemBudget
            CommissionDate = CStr(.CurrentCell.ColumnNumber + 1) & "/1/" & CStr(cboYear.Text)
            Budget_Pmr_ShowLineItem(strMrCode, CommissionDate)
        End With
        'Refresh_dgMedrepList()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Budget_Pmr_Insert()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(7) As SqlParameter

        Dim ItemCode As New SqlParameter("@ItemCode", SqlDbType.VarChar, 10)
        ItemCode.Direction = ParameterDirection.Input
        ItemCode.Value = txtItemCode.Text
        Params(0) = ItemCode

        Dim StartDate As New SqlParameter("@Start_Date", SqlDbType.DateTime)
        StartDate.Direction = ParameterDirection.Input
        StartDate.Value = Trim(TxtStartDate.Text)   'Format(dtStartDate.Value, "Short Date")
        Params(1) = StartDate
        tmpSD = Trim(TxtStartDate.Text)

        Dim EndDate As New SqlParameter("@End_Date", SqlDbType.DateTime)
        EndDate.Direction = ParameterDirection.Input
        EndDate.Value = Trim(TxtEndDate.Text)  'Format(dtEndDate.Value, "Short Date")
        Params(2) = EndDate
        tmpED = Trim(TxtEndDate.Text)

        Dim Qty As New SqlParameter("@Qty", SqlDbType.Int)
        Qty.Direction = ParameterDirection.Input
        Qty.Value = txtQty.Text
        Params(3) = Qty

        Dim Amount As New SqlParameter("@Amount", SqlDbType.Money)
        Amount.Direction = ParameterDirection.Input
        Amount.Value = txtAmount.Text
        Params(4) = Amount

        Dim CreateDate As New SqlParameter("@CreateDate", SqlDbType.DateTime, 10)
        CreateDate.Direction = ParameterDirection.Input
        CreateDate.Value = GetDateTimeNow()
        Params(5) = CreateDate

        Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime, 10)
        UpdateDate.Direction = ParameterDirection.Input
        UpdateDate.Value = GetDateTimeNow()
        Params(6) = UpdateDate

        Dim LastUser As New SqlParameter("@LastUser", SqlDbType.VarChar, 8)  '<v--added-DBrion
        LastUser.Direction = ParameterDirection.Input
        LastUser.Value = Trim(TxtLastUser.Text)
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

        Dim StartDate As New SqlParameter("@Start_Date", SqlDbType.DateTime)
        StartDate.Direction = ParameterDirection.Input
        StartDate.Value = Trim(TxtStartDate.Text)   'Format(dtStartDate.Value, "Short Date")
        Params(1) = StartDate
        tmpSD = Trim(TxtStartDate.Text)

        Dim EndDate As New SqlParameter("@End_Date", SqlDbType.DateTime)
        EndDate.Direction = ParameterDirection.Input
        EndDate.Value = Trim(TxtEndDate.Text)  'Format(dtEndDate.Value, "Short Date")
        Params(2) = EndDate
        tmpED = Trim(TxtEndDate.Text)

        Dim Qty As New SqlParameter("@Qty", SqlDbType.Int)
        Qty.Direction = ParameterDirection.Input
        Qty.Value = txtQty.Text
        Params(3) = Qty

        Dim Amount As New SqlParameter("@Amount", SqlDbType.Money)
        Amount.Direction = ParameterDirection.Input
        Amount.Value = txtAmount.Text
        Params(4) = Amount

        Dim Rownumber As New SqlParameter("@Rownumber", SqlDbType.Int)
        Rownumber.Direction = ParameterDirection.Input
        Rownumber.Value = txtRownumber.Text
        Params(5) = Rownumber

        Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime, 10)
        UpdateDate.Direction = ParameterDirection.Input
        UpdateDate.Value = GetDateTimeNow()
        Params(6) = UpdateDate

        Dim LastUser As New SqlParameter("@LastUser", SqlDbType.VarChar, 8)  '<v--added-DBrion
        LastUser.Direction = ParameterDirection.Input
        LastUser.Value = Trim(TxtLastUser.Text)
        Params(7) = LastUser

        BusinessObject.Sub_Update(ServerPath2, "ItemBudget_Update", CommandType.StoredProcedure, Params)
    End Sub
    Private Sub Budget_Pmr_Delete()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter
        Dim Rownumber As New SqlParameter("@Rownumber", SqlDbType.Int)
        Rownumber.Direction = ParameterDirection.Input
        Rownumber.Value = txtRownumber.Text
        Params(0) = Rownumber
        BusinessObject.Sub_Delete(ServerPath2, "ItemBudget_Delete", CommandType.StoredProcedure, Params)
        'Refresh_dgMedrepList()
    End Sub
    Private Sub Budget_Pmr_ShowYear()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "ItemBudget_YearCombo", _
                                           CommandType.StoredProcedure, RemoteDataSet, "Year")
        cboYear.DataSource = RemoteDataSet.Year
        cboYear.DisplayMember = "Year"
    End Sub
    Private Sub Budget_ItemList()
        RemoteDataSet.LineItem.Clear()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "ItemBudget_ShowItemList", CommandType.StoredProcedure, _
                                RemoteDataSet, "LineItem")
        dgLineItem.DataSource = RemoteDataSet.LineItem
    End Sub

    Private Sub Budget_Pmr_ShowLineItem(ByVal strMrCode As String, ByVal strCommissionDate As String)
        RemoteDataSet.LineItem.Clear()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(1) As SqlParameter
        Dim MrCode As New SqlParameter("@MrCode", SqlDbType.VarChar, 25) : MrCode.Direction = ParameterDirection.Input : MrCode.Value = strMrCode : Params(0) = MrCode
        Dim CommissionDate As New SqlParameter("@CommissionDate", SqlDbType.DateTime, 10) : CommissionDate.Direction = ParameterDirection.Input : CommissionDate.Value = strCommissionDate : Params(1) = CommissionDate
        BusinessObject.Sub_Show(ServerPath2, "ItemBudget_ShowItemBudgetList", _
                                CommandType.StoredProcedure, RemoteDataSet, "ItemBudget", Params)
        dgLineItem.DataSource = RemoteDataSet.LineItem
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If IsNumeric(cboYear.Text) Then
            Budget_ItemList()
        End If
        'cmdAdd.Enabled = False
        'cmdEdit.Enabled = False
        'cmdDelete.Enabled = False
    End Sub

    Private Sub dgLineItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgLineItem.Click, dgLineItem.CurrentCellChanged
        Dim xItm As String
        If RemoteDataSet.ItemBudget.Count > 0 Then RemoteDataSet.ItemBudget.Clear()
        Dim Params(1) As SqlParameter

        xItm = GetCode(dgLineItem.Item(dgLineItem.CurrentCell.RowNumber, 0).ToString)
        Dim MrCode As New SqlParameter("@ItemCode", SqlDbType.VarChar, 10)
        MrCode.Direction = ParameterDirection.Input
        MrCode.Value = xItm
        Params(0) = MrCode

        Dim Year As New SqlParameter("@Year", SqlDbType.Int)
        Year.Direction = ParameterDirection.Input
        Year.Value = cboYear.Text
        Params(1) = Year

        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "ItemBudget_ShowItemBudgetList", _
                                CommandType.StoredProcedure, RemoteDataSet, "ItemBudget", Params)
        dgItemBudget.DataSource = RemoteDataSet.ItemBudget
        With dgLineItem
            txtItemCode.Text = xItm
            txtItemDesc.Text = GetDescription(.Item(.CurrentCell.RowNumber, 0).ToString)
        End With
        cmdAdd.Enabled = True
        cmdEdit.Enabled = True
        cmdDelete.Enabled = True
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

    Private Sub frmItemBudget_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub dgItemBudget_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgItemBudget.Click, dgItemBudget.CurrentCellChanged
        With dgItemBudget
            TxtStartDate.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 1).ToString), "MM/dd/yyyy")
            TxtEndDate.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 2).ToString), "MM/dd/yyyy")
            txtQty.Text = Format(Val(.Item(.CurrentCell.RowNumber, 3).ToString), "#,##0.00")
            txtAmount.Text = Format(Val(.Item(.CurrentCell.RowNumber, 4).ToString), "#,##0.00")
            txtRownumber.Text = .Item(.CurrentCell.RowNumber, 5).ToString
            If Trim(.Item(.CurrentCell.RowNumber, 6).ToString) <> "" Then
                txtCreateDate.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 6).ToString), "MM/dd/yyyy")
            End If
            If Trim(.Item(.CurrentCell.RowNumber, 7).ToString) <> "" Then
                txtUpdateDate.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 7).ToString), "MM/dd/yyyy")
            End If
            cmdAdd.Enabled = True
            cmdEdit.Enabled = True
            cmdDelete.Enabled = True
        End With
    End Sub

    Private Sub dgItemBudget_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgItemBudget.MouseUp
        dgItemBudget.Select()
    End Sub
End Class
