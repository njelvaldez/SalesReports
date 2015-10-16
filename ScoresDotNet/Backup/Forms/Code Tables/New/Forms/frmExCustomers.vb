Imports System.Data.SqlClient

Public Class frmExCustomers
    Inherits System.Windows.Forms.Form
    Private RemoteDataSet As New CodeTablesDS
    Private EditMode As Boolean = False
    Private oldDs As String, tmpSD As String, tmpED As String   '<-- added-DBrion

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Sub_Show()
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents lblCreateDate As System.Windows.Forms.Label
    Friend WithEvents lblUpdateDate As System.Windows.Forms.Label
    Friend WithEvents txtRowid As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDescription1 As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtStartDate As System.Windows.Forms.TextBox
    Friend WithEvents TxtEndDate As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtLastUser As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboSalesClass As System.Windows.Forms.ComboBox
    Friend WithEvents CustomerCode As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents CustomerName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Customer As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents SalesClass As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents SubSubSaleType As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents LastUser As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Start_Date As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents End_Date As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents CreateDate As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents UpdateDate As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents TxtSSSaleType As System.Windows.Forms.TextBox
    Friend WithEvents btnDesc As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents dgCustList As System.Windows.Forms.DataGrid
    Friend WithEvents CustCode As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents CustDesc As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Address1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Address2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Rowid As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmExCustomers))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblCreateDate = New System.Windows.Forms.Label
        Me.lblUpdateDate = New System.Windows.Forms.Label
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.Rowid = New System.Windows.Forms.DataGridTextBoxColumn
        Me.CustomerCode = New System.Windows.Forms.DataGridTextBoxColumn
        Me.CustomerName = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Customer = New System.Windows.Forms.DataGridTextBoxColumn
        Me.SalesClass = New System.Windows.Forms.DataGridTextBoxColumn
        Me.SubSubSaleType = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Start_Date = New System.Windows.Forms.DataGridTextBoxColumn
        Me.End_Date = New System.Windows.Forms.DataGridTextBoxColumn
        Me.CreateDate = New System.Windows.Forms.DataGridTextBoxColumn
        Me.UpdateDate = New System.Windows.Forms.DataGridTextBoxColumn
        Me.LastUser = New System.Windows.Forms.DataGridTextBoxColumn
        Me.txtRowid = New System.Windows.Forms.TextBox
        Me.txtDescription1 = New System.Windows.Forms.TextBox
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtSSSaleType = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtStartDate = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtEndDate = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtLastUser = New System.Windows.Forms.TextBox
        Me.cboSalesClass = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.btnDesc = New System.Windows.Forms.Button
        Me.dgCustList = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.CustCode = New System.Windows.Forms.DataGridTextBoxColumn
        Me.CustDesc = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Address1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Address2 = New System.Windows.Forms.DataGridTextBoxColumn
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCustList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(13, 282)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(359, 312)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Create Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(544, 312)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Update Date"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCreateDate
        '
        Me.lblCreateDate.BackColor = System.Drawing.SystemColors.Info
        Me.lblCreateDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCreateDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCreateDate.Location = New System.Drawing.Point(431, 313)
        Me.lblCreateDate.Name = "lblCreateDate"
        Me.lblCreateDate.Size = New System.Drawing.Size(112, 21)
        Me.lblCreateDate.TabIndex = 6
        Me.lblCreateDate.Tag = "Input"
        '
        'lblUpdateDate
        '
        Me.lblUpdateDate.BackColor = System.Drawing.SystemColors.Info
        Me.lblUpdateDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUpdateDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblUpdateDate.Location = New System.Drawing.Point(616, 313)
        Me.lblUpdateDate.Name = "lblUpdateDate"
        Me.lblUpdateDate.Size = New System.Drawing.Size(112, 21)
        Me.lblUpdateDate.TabIndex = 7
        Me.lblUpdateDate.Tag = "Input"
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(281, 383)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.TabIndex = 9
        Me.cmdExit.Tag = "Exit"
        Me.cmdExit.Text = "Exit"
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(41, 383)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.TabIndex = 6
        Me.cmdAdd.Tag = "Add"
        Me.cmdAdd.Text = "Add"
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(121, 383)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.TabIndex = 7
        Me.cmdEdit.Tag = "Edit"
        Me.cmdEdit.Text = "Edit"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(121, 383)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.TabIndex = 10
        Me.cmdCancel.Tag = "Cancel"
        Me.cmdCancel.Text = "Cancel"
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(201, 383)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.TabIndex = 8
        Me.cmdDelete.Tag = "Delete"
        Me.cmdDelete.Text = "Delete"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(201, 383)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.TabIndex = 11
        Me.cmdSave.Tag = "Save"
        Me.cmdSave.Text = "Save"
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 8)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(721, 264)
        Me.DataGrid1.TabIndex = 0
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.DataGrid1.Tag = "View"
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.LightCyan
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.Aqua
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.Rowid, Me.CustomerCode, Me.CustomerName, Me.Customer, Me.SalesClass, Me.SubSubSaleType, Me.Start_Date, Me.End_Date, Me.CreateDate, Me.UpdateDate, Me.LastUser})
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.AntiqueWhite
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "ExcludeCustomerListCT_Show"
        Me.DataGridTableStyle1.ReadOnly = True
        '
        'Rowid
        '
        Me.Rowid.Format = ""
        Me.Rowid.FormatInfo = Nothing
        Me.Rowid.MappingName = "rowid"
        Me.Rowid.NullText = ""
        Me.Rowid.Width = 0
        '
        'CustomerCode
        '
        Me.CustomerCode.Format = ""
        Me.CustomerCode.FormatInfo = Nothing
        Me.CustomerCode.HeaderText = "Code"
        Me.CustomerCode.MappingName = "CustomerCode"
        Me.CustomerCode.NullText = ""
        Me.CustomerCode.Width = 0
        '
        'CustomerName
        '
        Me.CustomerName.Format = ""
        Me.CustomerName.FormatInfo = Nothing
        Me.CustomerName.HeaderText = "Description"
        Me.CustomerName.MappingName = "CustomerName"
        Me.CustomerName.NullText = ""
        Me.CustomerName.Width = 0
        '
        'Customer
        '
        Me.Customer.Format = ""
        Me.Customer.FormatInfo = Nothing
        Me.Customer.HeaderText = "Customer"
        Me.Customer.MappingName = "Customer"
        Me.Customer.NullText = ""
        Me.Customer.Width = 350
        '
        'SalesClass
        '
        Me.SalesClass.Format = ""
        Me.SalesClass.FormatInfo = Nothing
        Me.SalesClass.HeaderText = "Sales Class"
        Me.SalesClass.MappingName = "SalesClass"
        Me.SalesClass.NullText = ""
        Me.SalesClass.Width = 70
        '
        'SubSubSaleType
        '
        Me.SubSubSaleType.Format = ""
        Me.SubSubSaleType.FormatInfo = Nothing
        Me.SubSubSaleType.HeaderText = "Sale Type"
        Me.SubSubSaleType.MappingName = "SubSubSaleType"
        Me.SubSubSaleType.NullText = ""
        Me.SubSubSaleType.Width = 175
        '
        'Start_Date
        '
        Me.Start_Date.Format = "MM/dd/yyyy"
        Me.Start_Date.FormatInfo = Nothing
        Me.Start_Date.HeaderText = "Start Date"
        Me.Start_Date.MappingName = "StartDate"
        Me.Start_Date.NullText = ""
        Me.Start_Date.Width = 65
        '
        'End_Date
        '
        Me.End_Date.Format = "MM/dd/yyyy"
        Me.End_Date.FormatInfo = Nothing
        Me.End_Date.HeaderText = "End Date"
        Me.End_Date.MappingName = "EndDate"
        Me.End_Date.NullText = ""
        Me.End_Date.Width = 65
        '
        'CreateDate
        '
        Me.CreateDate.Format = "MM/dd/yyyy"
        Me.CreateDate.FormatInfo = Nothing
        Me.CreateDate.HeaderText = "Create Date"
        Me.CreateDate.MappingName = "CreateDate"
        Me.CreateDate.NullText = ""
        Me.CreateDate.Width = 65
        '
        'UpdateDate
        '
        Me.UpdateDate.Format = "MM/dd/yyyy"
        Me.UpdateDate.FormatInfo = Nothing
        Me.UpdateDate.HeaderText = "Update Date"
        Me.UpdateDate.MappingName = "UpdateDate"
        Me.UpdateDate.NullText = ""
        Me.UpdateDate.Width = 65
        '
        'LastUser
        '
        Me.LastUser.Format = ""
        Me.LastUser.FormatInfo = Nothing
        Me.LastUser.HeaderText = "User"
        Me.LastUser.MappingName = "LastUser"
        Me.LastUser.NullText = ""
        Me.LastUser.Width = 75
        '
        'txtRowid
        '
        Me.txtRowid.Location = New System.Drawing.Point(408, 343)
        Me.txtRowid.Name = "txtRowid"
        Me.txtRowid.Size = New System.Drawing.Size(14, 20)
        Me.txtRowid.TabIndex = 43
        Me.txtRowid.Tag = "Input"
        Me.txtRowid.Text = ""
        Me.txtRowid.Visible = False
        '
        'txtDescription1
        '
        Me.txtDescription1.Location = New System.Drawing.Point(96, 400)
        Me.txtDescription1.Name = "txtDescription1"
        Me.txtDescription1.Size = New System.Drawing.Size(184, 20)
        Me.txtDescription1.TabIndex = 45
        Me.txtDescription1.Tag = "Input"
        Me.txtDescription1.Text = ""
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(70, 283)
        Me.txtDescription.MaxLength = 50
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(454, 20)
        Me.txtDescription.TabIndex = 0
        Me.txtDescription.Tag = "Input"
        Me.txtDescription.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(-1, 341)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 21)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Sales Type"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtSSSaleType
        '
        Me.TxtSSSaleType.Location = New System.Drawing.Point(70, 343)
        Me.TxtSSSaleType.MaxLength = 20
        Me.TxtSSSaleType.Name = "TxtSSSaleType"
        Me.TxtSSSaleType.Size = New System.Drawing.Size(285, 20)
        Me.TxtSSSaleType.TabIndex = 4
        Me.TxtSSSaleType.Tag = "Input"
        Me.TxtSSSaleType.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(539, 282)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 21)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Sales Class"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtStartDate
        '
        Me.TxtStartDate.Location = New System.Drawing.Point(70, 313)
        Me.TxtStartDate.MaxLength = 10
        Me.TxtStartDate.Name = "TxtStartDate"
        Me.TxtStartDate.Size = New System.Drawing.Size(112, 20)
        Me.TxtStartDate.TabIndex = 2
        Me.TxtStartDate.Tag = "Input"
        Me.TxtStartDate.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(11, 312)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 20)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Start Date"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtEndDate
        '
        Me.TxtEndDate.Location = New System.Drawing.Point(239, 313)
        Me.TxtEndDate.MaxLength = 10
        Me.TxtEndDate.Name = "TxtEndDate"
        Me.TxtEndDate.Size = New System.Drawing.Size(112, 20)
        Me.TxtEndDate.TabIndex = 3
        Me.TxtEndDate.Tag = "Input"
        Me.TxtEndDate.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(184, 312)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 20)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "End Date"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtLastUser
        '
        Me.TxtLastUser.Location = New System.Drawing.Point(434, 343)
        Me.TxtLastUser.MaxLength = 8
        Me.TxtLastUser.Name = "TxtLastUser"
        Me.TxtLastUser.Size = New System.Drawing.Size(64, 20)
        Me.TxtLastUser.TabIndex = 57
        Me.TxtLastUser.Tag = "Input"
        Me.TxtLastUser.Text = ""
        Me.TxtLastUser.Visible = False
        '
        'cboSalesClass
        '
        Me.cboSalesClass.Items.AddRange(New Object() {"", "MIC", "NMPC", "QPI", "QX"})
        Me.cboSalesClass.Location = New System.Drawing.Point(605, 283)
        Me.cboSalesClass.MaxLength = 10
        Me.cboSalesClass.Name = "cboSalesClass"
        Me.cboSalesClass.Size = New System.Drawing.Size(84, 21)
        Me.cboSalesClass.TabIndex = 5
        Me.cboSalesClass.Tag = "Input"
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Location = New System.Drawing.Point(8, 371)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(721, 2)
        Me.Label10.TabIndex = 59
        '
        'Label11
        '
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(371, 380)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(192, 14)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "Easy Date Format Entry: ""MMDDYY"""
        '
        'Label12
        '
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(371, 395)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(184, 14)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "ex.  ""112595"" = ""Nov.25,1995"""
        '
        'btnDesc
        '
        Me.btnDesc.Image = CType(resources.GetObject("btnDesc.Image"), System.Drawing.Image)
        Me.btnDesc.Location = New System.Drawing.Point(505, 285)
        Me.btnDesc.Name = "btnDesc"
        Me.btnDesc.Size = New System.Drawing.Size(17, 16)
        Me.btnDesc.TabIndex = 1
        '
        'dgCustList
        '
        Me.dgCustList.DataMember = ""
        Me.dgCustList.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgCustList.Location = New System.Drawing.Point(0, 0)
        Me.dgCustList.Name = "dgCustList"
        Me.dgCustList.Size = New System.Drawing.Size(20, 20)
        Me.dgCustList.TabIndex = 63
        Me.dgCustList.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        Me.dgCustList.Visible = False
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.dgCustList
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.CustCode, Me.CustDesc, Me.Address1, Me.Address2})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "CustLookup"
        '
        'CustCode
        '
        Me.CustCode.Format = ""
        Me.CustCode.FormatInfo = Nothing
        Me.CustCode.HeaderText = "Code"
        Me.CustCode.MappingName = "custcode"
        Me.CustCode.NullText = ""
        Me.CustCode.Width = 75
        '
        'CustDesc
        '
        Me.CustDesc.Format = ""
        Me.CustDesc.FormatInfo = Nothing
        Me.CustDesc.HeaderText = "Name"
        Me.CustDesc.MappingName = "custname"
        Me.CustDesc.NullText = ""
        Me.CustDesc.Width = 175
        '
        'Address1
        '
        Me.Address1.Format = ""
        Me.Address1.FormatInfo = Nothing
        Me.Address1.HeaderText = "Address1"
        Me.Address1.MappingName = "address1"
        Me.Address1.NullText = ""
        Me.Address1.Width = 200
        '
        'Address2
        '
        Me.Address2.Format = ""
        Me.Address2.FormatInfo = Nothing
        Me.Address2.HeaderText = "Address2"
        Me.Address2.MappingName = "Address2"
        Me.Address2.NullText = ""
        Me.Address2.Width = 200
        '
        'frmExCustomers
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(733, 413)
        Me.Controls.Add(Me.btnDesc)
        Me.Controls.Add(Me.dgCustList)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cboSalesClass)
        Me.Controls.Add(Me.TxtLastUser)
        Me.Controls.Add(Me.TxtEndDate)
        Me.Controls.Add(Me.TxtStartDate)
        Me.Controls.Add(Me.TxtSSSaleType)
        Me.Controls.Add(Me.txtRowid)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.lblUpdateDate)
        Me.Controls.Add(Me.lblCreateDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmExCustomers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Excluded Customers - MetroDrug"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCustList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        modControlBehavior.EnableControlsGroup(Me, True)
        ControlMaintenance.ClearInputControls(Me)
        EditMode = False
        'added-DBrion --v
        btnSw = True
        lblCreateDate.Text = GetDateTimeNow("MM/dd/yyyy")
        lblUpdateDate.Text = GetDateTimeNow("MM/dd/yyyy")
        TxtStartDate.Text = GetDateTimeNow("MM") & "/01/" & GetDateTimeNow("yyyy")
        tmpSD = Format(CDate(TxtStartDate.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
        TxtEndDate.Text = "12/31/2078"
        tmpED = Format(CDate(TxtEndDate.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
        txtDescription.Select()
        'added-DBrion --^
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If txtDescription.Text = "" Then
            MessageBox.Show("Please select a record to modify!", _
                            "Record Selection", _
                            MessageBoxButtons.OK, _
                            MessageBoxIcon.Information, _
                            MessageBoxDefaultButton.Button1)

        Else
            modControlBehavior.EnableControlsGroup(Me, True)
            EditMode = True
            'added-DBrion --v
            btnSw = True
            lblUpdateDate.Text = GetDateTimeNow("MM/dd/yyyy")
            txtDescription.Select()
            txtDescription.SelectAll()
            'added-DBrion --^ 
        End If
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If txtRowid.Text > "" Then
            If (MessageBox.Show("Do you really want to delete this record?", _
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information, _
                MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then

                Sub_Delete()
                ControlMaintenance.ClearInputControls(Me)
                DataGrid1.DataSource = Nothing  '<--DBrion    to remove any text left by the
                Sub_Show()                      '<--DBrion    deleted record
            End If
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        'added-DBrion --v
        btnSw = False
        'added-DBrion --^
        modControlBehavior.EnableControls(Me, False)
        ControlMaintenance.ClearInputControls(Me)
        EditMode = False
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If (MessageBox.Show("Are you sure you want to Save this Entry?", "Confirm Saving", _
              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)) _
              = DialogResult.Yes Then

            Dim Params(0) As String
            Params(0) = txtRowid.Text
            TxtLastUser.Text = gCurrUser
            'added-DBrion  --v
            If Trim(txtDescription.Text) = "" Then
                MessageBox.Show("Main fields are mandatory")
                If Trim(txtDescription.Text) = "" Then
                    txtDescription.Select()
                End If
                Exit Sub
            End If
            'added-DBrion --^
            If EditMode = False Then
                Sub_Insert()
            Else
                Sub_Update()
            End If
            'Sub_Show()                 '<--commented-DBrion
            Sub_Select(Params, CStr(IIf(EditMode = False, "Insert", "Update")))
            EditMode = False
            modControlBehavior.EnableControls(Me, False)
            DataGrid1.DataSource = Nothing    'added-DBrion --v     to refresh and enable again 
            Sub_Show()                        'added-DBrion --^     the scrollbar
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Sub_Insert()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(8) As SqlParameter
            Dim CustomerCode As New SqlParameter("@CustomerCode", SqlDbType.VarChar, 50)
            CustomerCode.Direction = ParameterDirection.Input
            CustomerCode.Value = GetCode(txtDescription.Text)
            Params(0) = CustomerCode
            Dim CustomerName As New SqlParameter("@CustomerName", SqlDbType.VarChar, 100)
            CustomerName.Direction = ParameterDirection.Input
            CustomerName.Value = GetDescription(txtDescription.Text)
            Params(1) = CustomerName
            Dim SalesClass As New SqlParameter("@SalesClass", SqlDbType.VarChar, 10)
            SalesClass.Direction = ParameterDirection.Input
            SalesClass.Value = Trim(cboSalesClass.Text)
            Params(2) = SalesClass
            'added-DBrion --v
            Dim SubSubSaleType As New SqlParameter("@SubSubSaleType", SqlDbType.VarChar, 75)
            SubSubSaleType.Direction = ParameterDirection.Input
            SubSubSaleType.Value = Trim(TxtSSSaleType.Text)
            Params(3) = SubSubSaleType
            Dim StartDate As New SqlParameter("@StartDate", SqlDbType.VarChar, 10)
            StartDate.Direction = ParameterDirection.Input
            StartDate.Value = Trim(TxtStartDate.Text)
            Params(4) = StartDate
            Dim EndDate As New SqlParameter("@EndDate", SqlDbType.VarChar, 10)
            EndDate.Direction = ParameterDirection.Input
            EndDate.Value = Trim(TxtEndDate.Text)
            Params(5) = EndDate
            'added-DBrion --^
            Dim CreateDate As New SqlParameter("@CreateDate", SqlDbType.DateTime, 10)
            CreateDate.Direction = ParameterDirection.Input
            CreateDate.Value = GetDateTimeNow()
            Params(6) = CreateDate
            Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime, 10)
            UpdateDate.Direction = ParameterDirection.Input
            UpdateDate.Value = GetDateTimeNow()
            Params(7) = UpdateDate
            Dim LastUser As New SqlParameter("@LastUser", SqlDbType.VarChar, 8)
            LastUser.Direction = ParameterDirection.Input
            LastUser.Value = IIf(Trim(gCurrUser) = "", "", gCurrUser)   ' Trim(TxtLastUser.Text)
            Params(8) = LastUser
            BusinessObject.Sub_Insert(ServerPath2, "ExcludeCustomerListCT_Insert", CommandType.StoredProcedure, Params)
            LogHelper.InsertLog("ExcludeCustomerListCT_Insert.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("ExcludeCustomerListCT_Insert.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Sub_Update()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(8) As SqlParameter
            Dim CustomerCode As New SqlParameter("@CustomerCode", SqlDbType.VarChar, 50)
            CustomerCode.Direction = ParameterDirection.Input
            CustomerCode.Value = GetCode(txtDescription.Text)
            Params(0) = CustomerCode
            Dim CustomerName As New SqlParameter("@CustomerName", SqlDbType.VarChar, 100)
            CustomerName.Direction = ParameterDirection.Input
            CustomerName.Value = GetDescription(txtDescription.Text)
            Params(1) = CustomerName
            Dim SalesClass As New SqlParameter("@SalesClass", SqlDbType.VarChar, 10)
            SalesClass.Direction = ParameterDirection.Input
            SalesClass.Value = Trim(cboSalesClass.Text)
            Params(2) = SalesClass
            'added-DBrion --v
            Dim SubSubSaleType As New SqlParameter("@SubSubSaleType", SqlDbType.VarChar, 75)
            SubSubSaleType.Direction = ParameterDirection.Input
            SubSubSaleType.Value = Trim(TxtSSSaleType.Text)
            Params(3) = SubSubSaleType
            Dim StartDate As New SqlParameter("@StartDate", SqlDbType.VarChar, 10)
            StartDate.Direction = ParameterDirection.Input
            StartDate.Value = Trim(TxtStartDate.Text)
            Params(4) = StartDate
            Dim EndDate As New SqlParameter("@EndDate", SqlDbType.VarChar, 10)
            EndDate.Direction = ParameterDirection.Input
            EndDate.Value = Trim(TxtEndDate.Text)
            Params(5) = EndDate
            'added-DBrion --^
            Dim Rowid As New SqlParameter("@Rowid", SqlDbType.Int)
            Rowid.Direction = ParameterDirection.Input
            Rowid.Value = Trim(txtRowid.Text)
            Params(6) = Rowid
            Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime, 10)
            UpdateDate.Direction = ParameterDirection.Input
            UpdateDate.Value = GetDateTimeNow()
            Params(7) = UpdateDate
            Dim LastUser As New SqlParameter("@LastUser", SqlDbType.VarChar, 8)
            LastUser.Direction = ParameterDirection.Input
            LastUser.Value = IIf(Trim(gCurrUser) = "", "", gCurrUser)     ' Trim(TxtLastUser.Text)
            Params(8) = LastUser
            BusinessObject.Sub_Insert(ServerPath2, "ExcludeCustomerListCT_Update", CommandType.StoredProcedure, Params)
            LogHelper.InsertLog("ExcludeCustomerListCT_Update.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("ExcludeCustomerListCT_Update.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Sub_Show()
        Try
            If RemoteDataSet.ExcludeCustomerListCT_Show.Count > 0 Then RemoteDataSet.ExcludeCustomerListCT_Show.Clear()
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            BusinessObject.Sub_Show(ServerPath2, "ExcludeCustomerListCT_Show", CommandType.StoredProcedure, RemoteDataSet, "ExcludeCustomerListCT_Show")
            DataGrid1.DataSource = RemoteDataSet.ExcludeCustomerListCT_Show
            LogHelper.InsertLog("ExcludeCustomerListCT_Show.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("ExcludeCustomerListCT_Show.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Sub_Select(ByVal dbParams() As String, ByVal UpdateMode As String)
        'select case if add,edit or delete
        Dim i As Integer
        Dim myRowid As Integer
        Select Case UpdateMode
            Case "Insert"
                Dim BusinessObject As New BusinessLayer.clsFileMaintenance
                myRowid = CInt(BusinessObject.Sub_ReturnIntegerResult(ServerPath2, "ExcludeCustomerListCT_GetInsertedRowid", CommandType.StoredProcedure))
            Case "Update"
                myRowid = CInt(dbParams(0))
        End Select
        For i = 0 To (RemoteDataSet.ExcludeCustomerListCT_Show.Rows.Count - 1)
            With DataGrid1
                If myRowid = CInt(.Item(i, 0)) Then
                    .CurrentCell = New DataGridCell(i, 0)
                    Dim e As System.EventArgs
                    DataGrid1_Click(Me, e)
                    Exit For
                End If
            End With
        Next
    End Sub

    Private Sub Sub_Delete()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim Rowid As New SqlParameter("@Rowid", SqlDbType.Int)
            Rowid.Direction = ParameterDirection.Input
            Rowid.Value = txtRowid.Text
            Params(0) = Rowid
            BusinessObject.Sub_Delete(ServerPath2, "ExcludeCustomerListCT_Delete", CommandType.StoredProcedure, Params)
            LogHelper.InsertLog("ExcludeCustomerListCT_Delete.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("ExcludeCustomerListCT_Delete.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub frmExCustomers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        modControlBehavior.EnableControls(Me, False)
        btnSw = False    '<-- added-DBrion
        tmpSD = ""
        tmpED = ""
    End Sub

    Private Sub DataGrid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.Click, DataGrid1.CurrentCellChanged
        With DataGrid1
            txtRowid.Text = .Item(.CurrentCell.RowNumber, 0).ToString
            txtDescription.Text = .Item(.CurrentCell.RowNumber, 3).ToString
            oldDs = Trim(txtDescription.Text)
            cboSalesClass.Text = .Item(.CurrentCell.RowNumber, 4).ToString
            TxtSSSaleType.Text = .Item(.CurrentCell.RowNumber, 5).ToString
            If Trim(.Item(.CurrentCell.RowNumber, 6).ToString) <> "" Then
                TxtStartDate.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 6).ToString), "MM/dd/yyyy")
            Else
                TxtStartDate.Text = ""
            End If
            If Trim(.Item(.CurrentCell.RowNumber, 7).ToString) <> "" Then
                TxtEndDate.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 7).ToString), "MM/dd/yyyy")
            Else
                TxtEndDate.Text = ""
            End If
            If Trim(.Item(.CurrentCell.RowNumber, 8).ToString) <> "" Then
                lblCreateDate.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 8).ToString), "MM/dd/yyyy")
            Else
                lblCreateDate.Text = ""
            End If
            If Trim(.Item(.CurrentCell.RowNumber, 9).ToString) <> "" Then
                lblUpdateDate.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 9).ToString), "MM/dd/yyyy")
            Else
                lblUpdateDate.Text = ""
            End If
            TxtLastUser.Text = .Item(.CurrentCell.RowNumber, 10).ToString
            .Select(.CurrentRowIndex)    'CurrentCell.RowNumber)
        End With
    End Sub

    Private Sub TxtStartDate_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtStartDate.KeyUp
        If e.KeyValue = 13 Then      ' tests if the key pressed is the "enter key"
            SendKeys.Send("{TAB}")   ' sends the focus to the next control/tabstop
        End If
    End Sub

    Private Sub TxtStartDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtStartDate.Validating
        On Error GoTo errpt
        If Trim(TxtStartDate.Text) = "" Then       'entering w/o putting value
            'TxtStartDate.Text = GetDateTimeNow("MM") & "/01/" & GetDateTimeNow("yyyy")
            'tmpSD = Format(CDate(TxtStartDate.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
            Exit Sub
        Else
            TxtStartDate.Text = DatValid(TxtStartDate.Text)  'validating the entry. the textbox's value will be "mm/dd/yyyy" if the entry is invalid.
            If Trim(TxtStartDate.Text) = "mm/dd/yyyy" Then
                GoTo errpt
            Else
                TxtStartDate.Text = Mid(Trim(TxtStartDate.Text), 1, 2) & "/01/" & _
                                    Mid(Trim(TxtStartDate.Text), 7, 4)   'making the date the start of the month entered
                tmpSD = Format(CDate(TxtStartDate.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt") 'will use this variable in saving
            End If
            Exit Sub
        End If
errpt:
        e.Cancel = True  'brings back the focus to TxtStartDate textbox. only in Validating event
    End Sub

    Private Sub TxtEndDate_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtEndDate.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TxtEndDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtEndDate.Validating
        On Error GoTo errpt
        If Trim(TxtEndDate.Text) = "" Then
            'TxtEndDate.Text = "12/31/2078"
            'tmpED = Format(CDate(TxtEndDate.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
            Exit Sub
        Else
            TxtEndDate.Text = DatValid(TxtEndDate.Text)
            If Trim(TxtEndDate.Text) = "mm/dd/yyyy" Then
                GoTo errpt
            Else
                If Trim(TxtStartDate.Text) <> "" Then
                    If CDate(TxtStartDate.Text) < CDate(TxtEndDate.Text) Then
                        TxtEndDate.Text = GetEOM(Trim(TxtEndDate.Text))
                        tmpED = Format(CDate(TxtEndDate.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
                        Exit Sub
                    ElseIf Month(CDate(TxtStartDate.Text)) > Month(CDate(TxtEndDate.Text)) Then
                        MessageBox.Show("The End date should be a month later than the Start date!")
                    End If
                End If
            End If
        End If
errpt:
        e.Cancel = True
    End Sub

    Private Sub txtDescription_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescription.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtDescription_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDescription.Validating
        On Error GoTo errM
        Dim s As String, i As Integer
        Dim tst As Boolean
        Dim Params(0) As SqlParameter
        i = Len(Trim(txtDescription.Text)) - 12
        If btnSw = True And Trim(txtDescription.Text) <> Trim(oldDs) Then
            If InStr(Trim(txtDescription.Text), "--") = 0 Then
                btnDescProc()
            Else
                Exit Sub
            End If
        End If
errM:
    End Sub

    Private Sub btnDescProc()
        If RemoteDataSet.CustLookup.Count > 0 Then RemoteDataSet.CustLookup.Clear()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter
        Dim Wher As New SqlParameter("@Where", SqlDbType.NVarChar, 1000)
        Wher.Direction = ParameterDirection.Input
        Wher.Value = " custname like '%" & Trim(txtDescription.Text) & "%' "
        Params(0) = Wher
        Try
            BusinessObject.Sub_Show(ServerPath2, "CustLookup", CommandType.StoredProcedure, RemoteDataSet, "CustLookup", Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        dgCustList.DataSource = RemoteDataSet.CustLookup
        dgCustList.Height = 415
        dgCustList.Width = 735
        dgCustList.Visible = True
    End Sub

    Private Sub btnDesc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDesc.Click
        btnDescProc()
    End Sub

    Private Sub CustSelect()
        txtDescription.Text = Trim(dgCustList.Item(dgCustList.CurrentCell.RowNumber, 0).ToString) & "--" & Trim(dgCustList.Item(dgCustList.CurrentCell.RowNumber, 1).ToString)
        dgCustList.Height = 20
        dgCustList.Width = 20
        dgCustList.Visible = False
        TxtStartDate.Select()
    End Sub

    Private Sub dgCustList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgCustList.DoubleClick
        CustSelect()
    End Sub

    Private Sub dgCustList_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgCustList.KeyUp
        If e.KeyValue = 13 Then
            CustSelect()
        End If
    End Sub

    Private Sub cboSalesClass_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboSalesClass.KeyUp
        If e.KeyData.ToString = System.Windows.Forms.Keys.Up.ToString _
           Or e.KeyData.ToString = System.Windows.Forms.Keys.Left.ToString Then 'if key pressed is the up arrow it will select the next selection before the selction
            cboSalesClass.SelectedItem = cboSalesClass.SelectedIndex - 1
        ElseIf e.KeyData.ToString = System.Windows.Forms.Keys.Down.ToString _
           Or e.KeyData.ToString = System.Windows.Forms.Keys.Right.ToString Then 'if key pressed is the up arrow it will select the next selection after the selction
            cboSalesClass.SelectedItem = cboSalesClass.SelectedIndex + 1
        ElseIf DKcodes(e.KeyData) = True Then    'checking if the key pressed is alphanumeric (to disallow typing the entry)
            cboSalesClass.Text = ""     'if alphanumeric then the value of the field will be erased
        End If
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")      'moves control to the next control or field
        End If
    End Sub

    Private Sub cboSalesClass_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboSalesClass.Validating
        If Trim(cboSalesClass.Text) = "" And btnSw = True Then     'tests if entry is blank
            MessageBox.Show("Mandatory field!", "Critical!")  'gives message to put value
            e.Cancel() = True                'bringing back the focus to this field
        End If
    End Sub

    Private Sub TxtSSSaleType_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSSSaleType.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
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