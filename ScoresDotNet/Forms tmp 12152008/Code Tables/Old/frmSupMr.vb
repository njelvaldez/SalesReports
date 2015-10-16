Imports System.Data.SqlClient

Public Class frmSupMr
    'Inherits System.Windows.Forms.Form
    'Private EditMode As Boolean = False
    Inherits System.Windows.Forms.Form
    Private RemoteDataSet As New MyDataSetDB
    Private EditMode As Boolean = False
    Private oldDs As String, tmpSD As String, tmpED As String   '<-- added-DBrion
    Private temDiv As String, actDiv As String, tmpRowid As String
    Private currDSM As String, currPMR As String

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Sub_Show()
        Load_DSM()
        Load_PMR()
        Load_TeamDivision()
        Load_ActDivision()
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
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents TxtEndDate As System.Windows.Forms.TextBox
    Friend WithEvents TxtStartDate As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cboPMR As System.Windows.Forms.ComboBox
    Friend WithEvents cboDSM As System.Windows.Forms.ComboBox
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cboTDiv As System.Windows.Forms.ComboBox
    Friend WithEvents lblUpdateDate As System.Windows.Forms.TextBox
    Friend WithEvents lblCreateDate As System.Windows.Forms.TextBox
    Friend WithEvents txtRowid As System.Windows.Forms.TextBox
    Friend WithEvents TxtLastUser As System.Windows.Forms.TextBox
    Friend WithEvents DGTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents dgDSM As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgPMR As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgStart_Date As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgEnd_Date As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgRowid As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgTeamDivision As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgDivision As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgCreateDate As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgUpdateDate As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgLastUser As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents SqlValue As System.Windows.Forms.ComboBox
    Friend WithEvents dg_Dcode As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgPcode As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cboAcDiv As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents listYear As System.Windows.Forms.TextBox
    Friend WithEvents Chk1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents cboCompany As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSupMr))
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.DGTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.dg_Dcode = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgDSM = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgPcode = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgPMR = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgStart_Date = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgEnd_Date = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgRowid = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgTeamDivision = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgDivision = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgCreateDate = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgUpdateDate = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dgLastUser = New System.Windows.Forms.DataGridTextBoxColumn
        Me.cboPMR = New System.Windows.Forms.ComboBox
        Me.cboDSM = New System.Windows.Forms.ComboBox
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cboTDiv = New System.Windows.Forms.ComboBox
        Me.TxtEndDate = New System.Windows.Forms.TextBox
        Me.TxtStartDate = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblUpdateDate = New System.Windows.Forms.TextBox
        Me.lblCreateDate = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtRowid = New System.Windows.Forms.TextBox
        Me.TxtLastUser = New System.Windows.Forms.TextBox
        Me.SqlValue = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.cboAcDiv = New System.Windows.Forms.ComboBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.listYear = New System.Windows.Forms.TextBox
        Me.Chk1 = New System.Windows.Forms.CheckBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.cboCompany = New System.Windows.Forms.ComboBox
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 8)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(811, 235)
        Me.DataGrid1.TabIndex = 0
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DGTableStyle1})
        Me.DataGrid1.Tag = "View"
        '
        'DGTableStyle1
        '
        Me.DGTableStyle1.AlternatingBackColor = System.Drawing.Color.Aqua
        Me.DGTableStyle1.BackColor = System.Drawing.Color.LightCyan
        Me.DGTableStyle1.DataGrid = Me.DataGrid1
        Me.DGTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.dg_Dcode, Me.dgDSM, Me.dgPcode, Me.dgPMR, Me.dgStart_Date, Me.dgEnd_Date, Me.dgRowid, Me.dgTeamDivision, Me.dgDivision, Me.dgCreateDate, Me.dgUpdateDate, Me.dgLastUser})
        Me.DGTableStyle1.HeaderBackColor = System.Drawing.Color.AntiqueWhite
        Me.DGTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DGTableStyle1.MappingName = "SupMR_Show"
        Me.DGTableStyle1.ReadOnly = True
        '
        'dg_Dcode
        '
        Me.dg_Dcode.Format = ""
        Me.dg_Dcode.FormatInfo = Nothing
        Me.dg_Dcode.MappingName = "supcode"
        Me.dg_Dcode.NullText = ""
        Me.dg_Dcode.Width = 40
        '
        'dgDSM
        '
        Me.dgDSM.Format = ""
        Me.dgDSM.FormatInfo = Nothing
        Me.dgDSM.HeaderText = "DSM"
        Me.dgDSM.MappingName = "dsm"
        Me.dgDSM.NullText = ""
        Me.dgDSM.Width = 175
        '
        'dgPcode
        '
        Me.dgPcode.Format = ""
        Me.dgPcode.FormatInfo = Nothing
        Me.dgPcode.MappingName = "mrcode"
        Me.dgPcode.NullText = ""
        Me.dgPcode.Width = 40
        '
        'dgPMR
        '
        Me.dgPMR.Format = ""
        Me.dgPMR.FormatInfo = Nothing
        Me.dgPMR.HeaderText = "PMR"
        Me.dgPMR.MappingName = "pmr"
        Me.dgPMR.NullText = ""
        Me.dgPMR.Width = 175
        '
        'dgStart_Date
        '
        Me.dgStart_Date.Format = "MM/dd/yyyy"
        Me.dgStart_Date.FormatInfo = Nothing
        Me.dgStart_Date.HeaderText = "Start Date"
        Me.dgStart_Date.MappingName = "start_date"
        Me.dgStart_Date.NullText = ""
        Me.dgStart_Date.Width = 70
        '
        'dgEnd_Date
        '
        Me.dgEnd_Date.Format = "MM/dd/yyyy"
        Me.dgEnd_Date.FormatInfo = Nothing
        Me.dgEnd_Date.HeaderText = "End Date"
        Me.dgEnd_Date.MappingName = "end_date"
        Me.dgEnd_Date.NullText = ""
        Me.dgEnd_Date.Width = 70
        '
        'dgRowid
        '
        Me.dgRowid.Format = ""
        Me.dgRowid.FormatInfo = Nothing
        Me.dgRowid.MappingName = "rownumber"
        Me.dgRowid.NullText = ""
        Me.dgRowid.Width = 0
        '
        'dgTeamDivision
        '
        Me.dgTeamDivision.Format = ""
        Me.dgTeamDivision.FormatInfo = Nothing
        Me.dgTeamDivision.HeaderText = "Team Division"
        Me.dgTeamDivision.MappingName = "teamdivision"
        Me.dgTeamDivision.NullText = ""
        Me.dgTeamDivision.Width = 75
        '
        'dgDivision
        '
        Me.dgDivision.Format = ""
        Me.dgDivision.FormatInfo = Nothing
        Me.dgDivision.HeaderText = "Actual Division"
        Me.dgDivision.MappingName = "division"
        Me.dgDivision.NullText = ""
        Me.dgDivision.Width = 75
        '
        'dgCreateDate
        '
        Me.dgCreateDate.Format = "MM/dd/yyyy"
        Me.dgCreateDate.FormatInfo = Nothing
        Me.dgCreateDate.HeaderText = "Create Date"
        Me.dgCreateDate.MappingName = "createdate"
        Me.dgCreateDate.NullText = ""
        Me.dgCreateDate.Width = 70
        '
        'dgUpdateDate
        '
        Me.dgUpdateDate.Format = "MM/dd/yyyy"
        Me.dgUpdateDate.FormatInfo = Nothing
        Me.dgUpdateDate.HeaderText = "Update Date"
        Me.dgUpdateDate.MappingName = "updatedate"
        Me.dgUpdateDate.NullText = ""
        Me.dgUpdateDate.Width = 70
        '
        'dgLastUser
        '
        Me.dgLastUser.Format = ""
        Me.dgLastUser.FormatInfo = Nothing
        Me.dgLastUser.MappingName = "LastUser"
        Me.dgLastUser.NullText = ""
        Me.dgLastUser.Width = 0
        '
        'cboPMR
        '
        Me.cboPMR.Enabled = False
        Me.cboPMR.Location = New System.Drawing.Point(122, 277)
        Me.cboPMR.MaxDropDownItems = 10
        Me.cboPMR.Name = "cboPMR"
        Me.cboPMR.Size = New System.Drawing.Size(259, 21)
        Me.cboPMR.TabIndex = 1
        Me.cboPMR.Tag = "Input"
        '
        'cboDSM
        '
        Me.cboDSM.Enabled = False
        Me.cboDSM.Location = New System.Drawing.Point(122, 252)
        Me.cboDSM.MaxDropDownItems = 10
        Me.cboDSM.Name = "cboDSM"
        Me.cboDSM.Size = New System.Drawing.Size(259, 21)
        Me.cboDSM.TabIndex = 0
        Me.cboDSM.Tag = "Input"
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(148, 362)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.TabIndex = 7
        Me.cmdEdit.Tag = "Edit"
        Me.cmdEdit.Text = "Edit"
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(302, 362)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.TabIndex = 9
        Me.cmdExit.Tag = "Exit"
        Me.cmdExit.Text = "Exit"
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(71, 362)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.TabIndex = 6
        Me.cmdAdd.Tag = "Add"
        Me.cmdAdd.Text = "Add"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(147, 362)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.TabIndex = 28
        Me.cmdCancel.Tag = "Cancel"
        Me.cmdCancel.Text = "Cancel"
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(225, 362)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.TabIndex = 8
        Me.cmdDelete.Tag = "Delete"
        Me.cmdDelete.Text = "Delete"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(225, 362)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.TabIndex = 29
        Me.cmdSave.Tag = "Save"
        Me.cmdSave.Text = "Save"
        '
        'cboTDiv
        '
        Me.cboTDiv.Enabled = False
        Me.cboTDiv.Location = New System.Drawing.Point(122, 302)
        Me.cboTDiv.MaxDropDownItems = 10
        Me.cboTDiv.Name = "cboTDiv"
        Me.cboTDiv.Size = New System.Drawing.Size(259, 21)
        Me.cboTDiv.Sorted = True
        Me.cboTDiv.TabIndex = 2
        Me.cboTDiv.Tag = "Input"
        '
        'TxtEndDate
        '
        Me.TxtEndDate.Location = New System.Drawing.Point(553, 277)
        Me.TxtEndDate.MaxLength = 10
        Me.TxtEndDate.Name = "TxtEndDate"
        Me.TxtEndDate.Size = New System.Drawing.Size(104, 20)
        Me.TxtEndDate.TabIndex = 5
        Me.TxtEndDate.Tag = "Input"
        Me.TxtEndDate.Text = ""
        '
        'TxtStartDate
        '
        Me.TxtStartDate.Location = New System.Drawing.Point(553, 252)
        Me.TxtStartDate.MaxLength = 10
        Me.TxtStartDate.Name = "TxtStartDate"
        Me.TxtStartDate.Size = New System.Drawing.Size(104, 20)
        Me.TxtStartDate.TabIndex = 4
        Me.TxtStartDate.Tag = "Input"
        Me.TxtStartDate.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(480, 278)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 20)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "End Date"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(480, 253)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 20)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Start Date"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUpdateDate
        '
        Me.lblUpdateDate.BackColor = System.Drawing.SystemColors.Info
        Me.lblUpdateDate.Enabled = False
        Me.lblUpdateDate.Location = New System.Drawing.Point(553, 327)
        Me.lblUpdateDate.MaxLength = 10
        Me.lblUpdateDate.Name = "lblUpdateDate"
        Me.lblUpdateDate.ReadOnly = True
        Me.lblUpdateDate.Size = New System.Drawing.Size(104, 20)
        Me.lblUpdateDate.TabIndex = 58
        Me.lblUpdateDate.Tag = "Input"
        Me.lblUpdateDate.Text = ""
        '
        'lblCreateDate
        '
        Me.lblCreateDate.BackColor = System.Drawing.SystemColors.Info
        Me.lblCreateDate.Enabled = False
        Me.lblCreateDate.Location = New System.Drawing.Point(553, 302)
        Me.lblCreateDate.MaxLength = 10
        Me.lblCreateDate.Name = "lblCreateDate"
        Me.lblCreateDate.ReadOnly = True
        Me.lblCreateDate.Size = New System.Drawing.Size(104, 20)
        Me.lblCreateDate.TabIndex = 57
        Me.lblCreateDate.Tag = "Input"
        Me.lblCreateDate.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(480, 328)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 20)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "Update Date"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(480, 303)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 20)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Create Date"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(-2, 328)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 20)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Actual Division"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(-2, 303)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 20)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Team Division"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(-2, 278)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 20)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "Medical Representative"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(-2, 253)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(123, 20)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "District Manager"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(9, 353)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(553, 2)
        Me.Label1.TabIndex = 65
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(384, 375)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 14)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "ex.  ""112595"" = ""Nov.25,1995"""
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(384, 360)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(192, 14)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Easy Date Format Entry: ""MMDDYY"""
        '
        'txtRowid
        '
        Me.txtRowid.Location = New System.Drawing.Point(7, 364)
        Me.txtRowid.Name = "txtRowid"
        Me.txtRowid.Size = New System.Drawing.Size(13, 20)
        Me.txtRowid.TabIndex = 68
        Me.txtRowid.Tag = "Input"
        Me.txtRowid.Text = ""
        Me.txtRowid.Visible = False
        '
        'TxtLastUser
        '
        Me.TxtLastUser.Location = New System.Drawing.Point(23, 365)
        Me.TxtLastUser.MaxLength = 8
        Me.TxtLastUser.Name = "TxtLastUser"
        Me.TxtLastUser.Size = New System.Drawing.Size(43, 20)
        Me.TxtLastUser.TabIndex = 69
        Me.TxtLastUser.Tag = "Input"
        Me.TxtLastUser.Text = ""
        Me.TxtLastUser.Visible = False
        '
        'SqlValue
        '
        Me.SqlValue.Location = New System.Drawing.Point(212, 185)
        Me.SqlValue.Name = "SqlValue"
        Me.SqlValue.Size = New System.Drawing.Size(146, 21)
        Me.SqlValue.TabIndex = 70
        Me.SqlValue.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(384, 252)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 32)
        Me.Button1.TabIndex = 71
        Me.Button1.Tag = "Input"
        Me.Button1.Text = "Include InActive DSM/PMR"
        '
        'cboAcDiv
        '
        Me.cboAcDiv.Enabled = False
        Me.cboAcDiv.Location = New System.Drawing.Point(122, 327)
        Me.cboAcDiv.MaxDropDownItems = 20
        Me.cboAcDiv.Name = "cboAcDiv"
        Me.cboAcDiv.Size = New System.Drawing.Size(259, 21)
        Me.cboAcDiv.Sorted = True
        Me.cboAcDiv.TabIndex = 3
        Me.cboAcDiv.Tag = "Input"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(661, 252)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(76, 20)
        Me.Button2.TabIndex = 72
        Me.Button2.Text = "PMR History"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(661, 277)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(76, 20)
        Me.Button3.TabIndex = 73
        Me.Button3.Text = "All / by Year"
        '
        'listYear
        '
        Me.listYear.Location = New System.Drawing.Point(741, 277)
        Me.listYear.MaxLength = 10
        Me.listYear.Name = "listYear"
        Me.listYear.Size = New System.Drawing.Size(76, 20)
        Me.listYear.TabIndex = 74
        Me.listYear.Tag = ""
        Me.listYear.Text = ""
        '
        'Chk1
        '
        Me.Chk1.Location = New System.Drawing.Point(387, 291)
        Me.Chk1.Name = "Chk1"
        Me.Chk1.Size = New System.Drawing.Size(92, 16)
        Me.Chk1.TabIndex = 75
        Me.Chk1.Tag = "Input"
        Me.Chk1.Text = "Sort by Name"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(406, 308)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(62, 18)
        Me.Button4.TabIndex = 76
        Me.Button4.Tag = "Input"
        Me.Button4.Text = "Refresh"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(661, 302)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(76, 20)
        Me.Button5.TabIndex = 77
        Me.Button5.Text = "by Company"
        '
        'cboCompany
        '
        Me.cboCompany.Items.AddRange(New Object() {"", "NMPC", "QX"})
        Me.cboCompany.Location = New System.Drawing.Point(741, 302)
        Me.cboCompany.Name = "cboCompany"
        Me.cboCompany.Size = New System.Drawing.Size(76, 21)
        Me.cboCompany.TabIndex = 78
        Me.cboCompany.Tag = ""
        '
        'frmSupMr
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(825, 391)
        Me.ControlBox = False
        Me.Controls.Add(Me.cboCompany)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Chk1)
        Me.Controls.Add(Me.listYear)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cboAcDiv)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SqlValue)
        Me.Controls.Add(Me.TxtLastUser)
        Me.Controls.Add(Me.txtRowid)
        Me.Controls.Add(Me.lblUpdateDate)
        Me.Controls.Add(Me.lblCreateDate)
        Me.Controls.Add(Me.TxtEndDate)
        Me.Controls.Add(Me.TxtStartDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboTDiv)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cboPMR)
        Me.Controls.Add(Me.cboDSM)
        Me.Controls.Add(Me.DataGrid1)
        Me.Name = "frmSupMr"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DSM - PMR Assignment"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    ''Private Sub InsertMode()
    ''    ClearControlsText()
    ''    EditMode = False
    ''    EnableControls(True)
    ''    EnableButtons(True)
    ''End Sub
    ''Private Sub UpdateMode()
    ''    EditMode = True
    ''    EnableControls(True)
    ''    EnableButtons(True)
    ''End Sub
    ''Private Sub SaveChanges()
    ''    Select Case EditMode
    ''        Case True
    ''            DataMaintenance.myParamArray(0, 0) = "@RowNumber"
    ''            DataMaintenance.myParamArray(0, 1) = SqlDbType.Int
    ''            DataMaintenance.myParamArray(0, 2) = 4
    ''            DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
    ''            DataMaintenance.myParamArray(0, 4) = "Integer"
    ''            DataMaintenance.myParamArray(0, 5) = CInt(ComboBox1.Tag)

    ''            DataMaintenance.myParamArray(1, 0) = "@SupName"
    ''            DataMaintenance.myParamArray(1, 1) = SqlDbType.VarChar
    ''            DataMaintenance.myParamArray(1, 2) = 75
    ''            DataMaintenance.myParamArray(1, 3) = System.Data.ParameterDirection.Input
    ''            DataMaintenance.myParamArray(1, 4) = "String"
    ''            DataMaintenance.myParamArray(1, 5) = ComboBox1.Text

    ''            DataMaintenance.myParamArray(2, 0) = "@MrName"
    ''            DataMaintenance.myParamArray(2, 1) = SqlDbType.VarChar
    ''            DataMaintenance.myParamArray(2, 2) = 75
    ''            DataMaintenance.myParamArray(2, 3) = System.Data.ParameterDirection.Input
    ''            DataMaintenance.myParamArray(2, 4) = "String"
    ''            DataMaintenance.myParamArray(2, 5) = ComboBox2.Text

    ''            DataMaintenance.myParamArray(3, 0) = "@TeamDivision"
    ''            DataMaintenance.myParamArray(3, 1) = SqlDbType.VarChar
    ''            DataMaintenance.myParamArray(3, 2) = 50
    ''            DataMaintenance.myParamArray(3, 3) = System.Data.ParameterDirection.Input
    ''            DataMaintenance.myParamArray(3, 4) = "String"
    ''            DataMaintenance.myParamArray(3, 5) = ComboBox3.Text

    ''            'DataMaintenance.myParamArray(4, 0) = "@StartDate"
    ''            'DataMaintenance.myParamArray(4, 1) = SqlDbType.DateTime
    ''            'DataMaintenance.myParamArray(4, 2) = 10
    ''            'DataMaintenance.myParamArray(4, 3) = System.Data.ParameterDirection.Input
    ''            'DataMaintenance.myParamArray(4, 4) = "Date"
    ''            'DataMaintenance.myParamArray(4, 5) = DateTimePicker1.Text

    ''            'DataMaintenance.myParamArray(5, 0) = "@EndDate"
    ''            'DataMaintenance.myParamArray(5, 1) = SqlDbType.DateTime
    ''            'DataMaintenance.myParamArray(5, 2) = 10
    ''            'DataMaintenance.myParamArray(5, 3) = System.Data.ParameterDirection.Input
    ''            'DataMaintenance.myParamArray(5, 4) = "Date"
    ''            'DataMaintenance.myParamArray(5, 5) = DateTimePicker2.Text

    ''            If DataMaintenance.ExecuteCommand(ServerPath2, "SupMr_Update", CommandType.StoredProcedure, 6) Then
    ''                MessageBox.Show("Row Changes in DSM - PMR assignment  saved")
    ''            End If
    ''        Case False
    ''            DataMaintenance.myParamArray(0, 0) = "@SupName"
    ''            DataMaintenance.myParamArray(0, 1) = SqlDbType.VarChar
    ''            DataMaintenance.myParamArray(0, 2) = 75
    ''            DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
    ''            DataMaintenance.myParamArray(0, 4) = "String"
    ''            DataMaintenance.myParamArray(0, 5) = ComboBox1.Text

    ''            DataMaintenance.myParamArray(1, 0) = "@MrName"
    ''            DataMaintenance.myParamArray(1, 1) = SqlDbType.VarChar
    ''            DataMaintenance.myParamArray(1, 2) = 75
    ''            DataMaintenance.myParamArray(1, 3) = System.Data.ParameterDirection.Input
    ''            DataMaintenance.myParamArray(1, 4) = "String"
    ''            DataMaintenance.myParamArray(1, 5) = ComboBox2.Text

    ''            DataMaintenance.myParamArray(2, 0) = "@TeamDivision"
    ''            DataMaintenance.myParamArray(2, 1) = SqlDbType.VarChar
    ''            DataMaintenance.myParamArray(2, 2) = 50
    ''            DataMaintenance.myParamArray(2, 3) = System.Data.ParameterDirection.Input
    ''            DataMaintenance.myParamArray(2, 4) = "String"
    ''            DataMaintenance.myParamArray(2, 5) = ComboBox3.Text

    ''            'DataMaintenance.myParamArray(3, 0) = "@StartDate"
    ''            'DataMaintenance.myParamArray(3, 1) = SqlDbType.DateTime
    ''            'DataMaintenance.myParamArray(3, 2) = 10
    ''            'DataMaintenance.myParamArray(3, 3) = System.Data.ParameterDirection.Input
    ''            'DataMaintenance.myParamArray(3, 4) = "Date"
    ''            'DataMaintenance.myParamArray(3, 5) = DateTimePicker1.Text

    ''            'DataMaintenance.myParamArray(4, 0) = "@EndDate"
    ''            'DataMaintenance.myParamArray(4, 1) = SqlDbType.DateTime
    ''            'DataMaintenance.myParamArray(4, 2) = 10
    ''            'DataMaintenance.myParamArray(4, 3) = System.Data.ParameterDirection.Input
    ''            'DataMaintenance.myParamArray(4, 4) = "Date"
    ''            'DataMaintenance.myParamArray(4, 5) = DateTimePicker2.Text
    ''            If DataMaintenance.ExecuteCommand(ServerPath2, "SupMr_Insert", CommandType.StoredProcedure, 5) Then
    ''                MessageBox.Show("New DSM - PMR Assignment Row saved")
    ''            End If
    ''    End Select
    ''    Load_DataGrid()
    ''End Sub
    ''Private Sub ClearControlsText()
    ''    ComboBox1.Text = ""
    ''    ComboBox2.Text = ""
    ''    ComboBox3.Text = ""
    ''    'DateTimePicker1.Text = CStr(Now())
    ''    'DateTimePicker2.Text = CStr(Now())
    ''End Sub
    ''Private Sub EnableControls(ByVal bln As Boolean)
    ''    ComboBox1.Enabled = bln
    ''    ComboBox2.Enabled = bln
    ''    ComboBox3.Enabled = bln
    ''    'DateTimePicker1.Enabled = bln
    ''    'DateTimePicker2.Enabled = bln
    ''End Sub
    ''Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
    ''    SaveChanges()
    ''    EnableButtons(False)
    ''End Sub
    ''Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
    ''    EnableButtons(False)
    ''End Sub
    ''Private Sub EnableButtons(ByVal bln As Boolean)
    ''    'buttons
    ''    Button1.Enabled = Not (bln) 'Add
    ''    Button2.Enabled = Not (bln) 'Edit
    ''    Button3.Enabled = Not (bln) 'Delete
    ''    Button4.Enabled = Not (bln) 'Exit
    ''    Button5.Enabled = bln       'Save
    ''    Button6.Enabled = bln       'Cancel

    ''    'Button Switching
    ''    Button2.Visible = Not (bln) 'Edit
    ''    Button3.Visible = Not (bln) 'Delete 
    ''    Button5.Visible = bln  'Save
    ''    Button6.Visible = bln  'Cancel

    ''    EnableControls(bln)
    ''End Sub
    ''Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    ''    InsertMode()
    ''End Sub
    ''Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    ''    If ComboBox1.Text > "" And ComboBox2.Text > "" Then
    ''        UpdateMode()
    ''    Else
    ''        MessageBox.Show("Please select a record!")
    ''    End If

    ''End Sub
    ''Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
    ''    Me.Close()
    ''End Sub
    ''Private Sub Load_TeamDivisionCombo()
    ''    Dim myDataTable As SqlDataReader
    ''    myDataTable = DataMaintenance.GetResultSet(ServerPath2, "KeyProducts_ShowTeamDivision", CommandType.StoredProcedure)
    ''    If myDataTable.HasRows Then
    ''        While myDataTable.Read
    ''            ComboBox3.Items.Add(myDataTable.Item("Description"))
    ''        End While
    ''    End If
    ''End Sub
    ''Private Sub Load_DataGrid()
    ''    Dim myDataTable As DataTable
    ''    myDataTable = DataMaintenance.GetDataTable(ServerPath2, "SupMr_Show", CommandType.StoredProcedure)
    ''    DataGrid1.DataSource = myDataTable
    ''End Sub
    ''Private Sub DataGrid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.Click
    ''    ComboBox1.Tag = CInt(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 0))
    ''    ComboBox2.Text = CStr(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 2))
    ''    ComboBox1.Text = CStr(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 1))
    ''    ComboBox3.Text = CStr(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 3))
    ''    'DateTimePicker1.Text = CStr(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 4))
    ''    'DateTimePicker2.Text = CStr(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 5))
    ''End Sub
    ''Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
    ''    If MessageBox.Show("Delete this product line?", "Product Lines", MessageBoxButtons.YesNo) = DialogResult.Yes Then
    ''        DataMaintenance.myParamArray(0, 0) = "@Rowid"
    ''        DataMaintenance.myParamArray(0, 1) = SqlDbType.Int
    ''        DataMaintenance.myParamArray(0, 2) = 50
    ''        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
    ''        DataMaintenance.myParamArray(0, 4) = "Integer"
    ''        DataMaintenance.myParamArray(0, 5) = CInt(ComboBox1.Tag)

    ''        If DataMaintenance.ExecuteCommand(ServerPath2, "KeyProducts_Delete", CommandType.StoredProcedure, 1) = True Then
    ''            MessageBox.Show("Key Products row deleted!")
    ''            Load_DataGrid()
    ''        End If
    ''    End If
    ''End Sub
    ''Private Sub DataGrid1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.CurrentCellChanged
    ''    DataGrid1_Click(Me, e)
    ''End Sub
    ''Private Sub Load_PMRCombo()
    ''    Dim myDataReader As SqlDataReader
    ''    myDataReader = DataMaintenance.GetResultSet(ServerPath2, "SupMR_ShowPMR", CommandType.StoredProcedure)
    ''    If myDataReader.HasRows Then
    ''        While myDataReader.Read
    ''            ComboBox2.Items.Add(myDataReader.Item("MrName"))
    ''        End While
    ''    End If
    ''End Sub
    ''Private Sub Load_DSMCombo()
    ''    Dim myDataReader As SqlDataReader
    ''    myDataReader = DataMaintenance.GetResultSet(ServerPath2, "SupMR_ShowDSM", CommandType.StoredProcedure)
    ''    If myDataReader.HasRows Then
    ''        While myDataReader.Read
    ''            ComboBox1.Items.Add(myDataReader.Item("supname"))
    ''        End While
    ''    End If
    ''End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        modControlBehavior.EnableControls(Me, True)
        Button1.Tag = ""
        Chk1.Tag = ""
        Button4.Tag = ""
        ControlMaintenance.ClearInputControls(Me)
        Button1.Tag = "Input"
        Chk1.Tag = "Input"
        Button4.Tag = "Input"
        EditMode = False
        'added-DBrion --v
        btnSw = True
        lblCreateDate.Text = GetDateTimeNow("MM/dd/yyyy")
        lblUpdateDate.Text = GetDateTimeNow("MM/dd/yyyy")
        TxtStartDate.Text = GetDateTimeNow("MM") & "/01/" & GetDateTimeNow("yyyy")
        tmpSD = Format(CDate(TxtStartDate.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
        TxtEndDate.Text = "12/31/2078"
        tmpED = Format(CDate(TxtEndDate.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
        'added-DBrion --^
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If cboDSM.Text = "" And cboPMR.Text = "" Then
            MessageBox.Show("Please select a record to modify!", _
                            "Record Selection", _
                            MessageBoxButtons.OK, _
                            MessageBoxIcon.Information, _
                            MessageBoxDefaultButton.Button1)
        Else
            modControlBehavior.EnableControls(Me, True)
            EditMode = True
            'added-DBrion --v
            btnSw = True
            lblUpdateDate.Text = GetDateTimeNow("MM/dd/yyyy")
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

    Private Sub cmdCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        btnSw = False
        modControlBehavior.EnableControls(Me, False)
        Button1.Tag = ""
        Chk1.Tag = ""
        Button4.Tag = ""
        ControlMaintenance.ClearInputControls(Me)
        Button1.Tag = "Input"
        Chk1.Tag = "Input"
        Button4.Tag = "Input"
        EditMode = False
    End Sub

    Private Sub cmdSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Prms(0) As SqlParameter
        If (MessageBox.Show("Are you sure you want to Save this Entry?", "Confirm Saving", _
              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)) _
              = DialogResult.Yes Then
            Dim tmpSup As String, tmpMr As String
            z = "select supcode as fld1 from NewScores..SupMr "
            If Chk1.Checked = True Then
                tmpSup = StrTran(Mid(cboDSM.Text, Len(Trim(cboDSM.Text)) - 5, 7), "-", "")
            Else
                tmpSup = GetCode(cboDSM.Text)
            End If
            z = z & "where rtrim(supcode) = '" & Trim(tmpSup) & "' "
            If Chk1.Checked = True Then
                tmpMr = StrTran(Mid(cboPMR.Text, Len(Trim(cboPMR.Text)) - 5, 7), "-", "")
            Else
                tmpMr = GetCode(cboPMR.Text)
            End If
            z = z & "  and rtrim(mrcode) = '" & Trim(tmpMr) & "' "
            z = z & "  and ('" & Trim(TxtStartDate.Text) & "' between start_date and end_date "
            z = z & "   or '" & Trim(TxtEndDate.Text) & "' between start_date and end_date) "
            Dim SQLstmnt As New SqlParameter("@SqlQry", SqlDbType.NVarChar, 2950)
            SQLstmnt.Direction = ParameterDirection.Input
            SQLstmnt.Value = z
            Prms(0) = SQLstmnt
            If RemoteDataSet.GenericQryProc.Count > 0 Then RemoteDataSet.GenericQryProc.Clear()
            Try
                BusinessObject.Sub_Show(ServerPath2, "GenericQryProc", CommandType.StoredProcedure, _
                                        RemoteDataSet, "GenericQryProc", Prms)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            SqlValue.DataSource = RemoteDataSet.GenericQryProc
            SqlValue.DisplayMember = "fld1"

            Dim Params(0) As String
            Params(0) = txtRowid.Text
            cboAcDiv.Text = actDiv
            If EditMode = False Then
                If Trim(SqlValue.Text) <> "" Then
                    MsgBox("This Entry already exists! Please try again.")
                    Exit Sub
                Else
                    Sub_Insert()
                End If
            Else
                Sub_Update()
            End If
            DataGrid1.DataSource = Nothing    'added-DBrion --v     to refresh and enable again 
            Sub_Show()                        'added-DBrion --^     the scrollbar
            Sub_Select(Params, CStr(IIf(EditMode = False, "Insert", "Update")))
            EditMode = False
            modControlBehavior.EnableControls(Me, False)
            MsgBox("Record Successfully Saved!")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Sub_Insert()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(8) As SqlParameter

        Dim SupCode As New SqlParameter("@SupCode", SqlDbType.VarChar, 10)
        SupCode.Direction = ParameterDirection.Input
        If Chk1.Checked = True Then
            SupCode.Value = StrTran(Mid(cboDSM.Text, Len(Trim(cboDSM.Text)) - 5, 7), "-", "")
        Else
            SupCode.Value = GetCode(cboDSM.Text)
        End If
        Params(0) = SupCode

        Dim MrCode As New SqlParameter("@MrCode", SqlDbType.VarChar, 10)
        MrCode.Direction = ParameterDirection.Input
        If Chk1.Checked = True Then
            MrCode.Value = StrTran(Mid(cboPMR.Text, Len(Trim(cboPMR.Text)) - 5, 7), "-", "")
        Else
            MrCode.Value = GetCode(cboPMR.Text)
        End If
        Params(1) = MrCode

        Dim StartDate As New SqlParameter("@Start_Date", SqlDbType.DateTime)
        StartDate.Direction = ParameterDirection.Input
        StartDate.Value = Trim(TxtStartDate.Text) '& GetDateTimeNow(" h:mm:ss tt")
        Params(2) = StartDate

        Dim EndDate As New SqlParameter("@End_Date", SqlDbType.DateTime)
        EndDate.Direction = ParameterDirection.Input
        EndDate.Value = Trim(TxtEndDate.Text) '& GetDateTimeNow(" h:mm:ss tt")
        Params(3) = EndDate

        'added-DBrion --v
        Dim TeamDivision As New SqlParameter("@TeamDivision", SqlDbType.VarChar, 50)
        TeamDivision.Direction = ParameterDirection.Input
        TeamDivision.Value = Trim(cboTDiv.Text)
        Params(4) = TeamDivision

        Dim Division As New SqlParameter("@Division", SqlDbType.VarChar, 30)
        Division.Direction = ParameterDirection.Input
        Division.Value = Trim(actDiv)
        Params(5) = Division

        'added-DBrion --^
        Dim CreateDate As New SqlParameter("@CreateDate", SqlDbType.DateTime)
        CreateDate.Direction = ParameterDirection.Input
        CreateDate.Value = GetDateTimeNow()
        Params(6) = CreateDate

        Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime)
        UpdateDate.Direction = ParameterDirection.Input
        UpdateDate.Value = GetDateTimeNow()
        Params(7) = UpdateDate

        Dim LastUser As New SqlParameter("@LastUser", SqlDbType.VarChar, 10)
        LastUser.Direction = ParameterDirection.Input
        LastUser.Value = IIf(Trim(gCurrUser) = "", "", gCurrUser)     ' Trim(TxtLastUser.Text)
        Params(8) = LastUser

        Try
            BusinessObject.Sub_Insert(ServerPath2, "SupMR_Insert", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Sub_Update()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(8) As SqlParameter
        Dim s As String

        Dim SupCode As New SqlParameter("@SupCode", SqlDbType.VarChar, 10)
        SupCode.Direction = ParameterDirection.Input
        If Chk1.Checked = True Then
            SupCode.Value = StrTran(Mid(cboDSM.Text, Len(Trim(cboDSM.Text)) - 5, 7), "-", "")
        Else
            SupCode.Value = GetCode(cboDSM.Text)
        End If
        Params(0) = SupCode

        Dim MrCode As New SqlParameter("@MrCode", SqlDbType.VarChar, 10)
        MrCode.Direction = ParameterDirection.Input
        If Chk1.Checked = True Then
            MrCode.Value = StrTran(Mid(cboPMR.Text, Len(Trim(cboPMR.Text)) - 5, 7), "-", "")
        Else
            MrCode.Value = GetCode(cboPMR.Text)
        End If
        Params(1) = MrCode

        Dim StartDate As New SqlParameter("@Start_Date", SqlDbType.DateTime, 10)
        StartDate.Direction = ParameterDirection.Input
        StartDate.Value = Trim(TxtStartDate.Text) '& GetDateTimeNow(" h:mm:ss tt")
        Params(2) = StartDate

        Dim EndDate As New SqlParameter("@End_Date", SqlDbType.DateTime, 10)
        EndDate.Direction = ParameterDirection.Input
        EndDate.Value = Trim(TxtEndDate.Text) '& GetDateTimeNow(" h:mm:ss tt")
        Params(3) = EndDate

        Dim Rownumber As New SqlParameter("@Rownumber", SqlDbType.Int)
        Rownumber.Direction = ParameterDirection.Input
        Rownumber.Value = Trim(txtRowid.Text)
        Params(4) = Rownumber

        'added-DBrion --v
        Dim TeamDivision As New SqlParameter("@TeamDivision", SqlDbType.VarChar, 50)
        TeamDivision.Direction = ParameterDirection.Input
        TeamDivision.Value = Trim(temDiv)
        Params(5) = TeamDivision

        Dim Division As New SqlParameter("@Division", SqlDbType.VarChar, 30)
        Division.Direction = ParameterDirection.Input
        Division.Value = Trim(actDiv)
        Params(6) = Division
        'added-DBrion --^

        Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime, 10)
        UpdateDate.Direction = ParameterDirection.Input
        UpdateDate.Value = GetDateTimeNow()
        Params(7) = UpdateDate

        Dim LastUser As New SqlParameter("@LastUser", SqlDbType.VarChar, 10)
        LastUser.Direction = ParameterDirection.Input
        LastUser.Value = IIf(Trim(gCurrUser) = "", "", gCurrUser)      ' Trim(TxtLastUser.Text)
        Params(8) = LastUser

        Try
            BusinessObject.Sub_Update(ServerPath2, "SupMR_Update", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Sub_Show()
        If RemoteDataSet.SupMR_Show.Count > 0 Then RemoteDataSet.SupMR_Show.Clear()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "SupMR_Show", CommandType.StoredProcedure, RemoteDataSet, "SupMR_Show")
        DataGrid1.DataSource = RemoteDataSet.SupMR_Show
    End Sub

    Private Sub Sub_ShowA()
        If RemoteDataSet.SupMR_Show.Count > 0 Then RemoteDataSet.SupMR_Show.Clear()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "SupMRall_Show", CommandType.StoredProcedure, RemoteDataSet, "SupMR_Show")
        DataGrid1.DataSource = RemoteDataSet.SupMR_Show
    End Sub

    Private Sub Sub_Show2()
        If RemoteDataSet.SupMR_Show.Count > 0 Then RemoteDataSet.SupMR_Show.Clear()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter
        Dim LYear As New SqlParameter("@Year", SqlDbType.VarChar, 10)
        LYear.Direction = ParameterDirection.Input
        LYear.Value = Trim(listYear.Text)
        Params(0) = LYear
        BusinessObject.Sub_Show(ServerPath2, "SupMR2_Show", CommandType.StoredProcedure, RemoteDataSet, "SupMR_Show", Params)
        DataGrid1.DataSource = RemoteDataSet.SupMR_Show
    End Sub

    Private Sub Sub_Select(ByVal dbParams() As String, ByVal UpdateMode As String)
        'select case if add,edit or delete
        Dim i As Integer
        Dim myRowid As Integer
        Select Case UpdateMode
            Case "Insert"
                Dim BusinessObject As New BusinessLayer.clsFileMaintenance
                myRowid = CInt(BusinessObject.Sub_ReturnIntegerResult(ServerPath2, "SupMR_GetInsertedRowid", CommandType.StoredProcedure))
            Case "Update"
                myRowid = CInt(dbParams(0))
        End Select
        For i = 0 To (RemoteDataSet.SupMR_Show.Rows.Count - 1)
            With DataGrid1
                If myRowid = CInt(.Item(i, 6)) Then
                    .CurrentCell = New DataGridCell(i, 0)
                    Dim e As System.EventArgs
                    DataGrid1_Click(Me, e)
                    Exit For
                End If
            End With
        Next
    End Sub

    Private Sub Sub_Delete()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter
        Dim Rowid As New SqlParameter("@Rownumber", SqlDbType.Int)
        Rowid.Direction = ParameterDirection.Input
        Rowid.Value = txtRowid.Text
        Params(0) = Rowid
        Try
            BusinessObject.Sub_Delete(ServerPath2, "SupMR_Delete", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmSupMr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        modControlBehavior.EnableControls(Me, False)
        btnSw = False    '<-- added-DBrion
        tmpSD = ""
        tmpED = ""
        'cboDSM.Text = "" : cboPMR.Text = ""
        'cboTDiv.Text = "" : cboAcDiv.Text = "" : actDiv = ""
        DataGrid1_Click(Me, e)
    End Sub

    Private Sub Load_DSM()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        RemoteDataSet.SupMR_ShowDSM.Clear()
        BusinessObject.Sub_Show(ServerPath2, "SupMr_DSMcombo", CommandType.StoredProcedure, RemoteDataSet, "SupMR_ShowDSM")
        cboDSM.DataSource = RemoteDataSet.SupMR_ShowDSM
        cboDSM.DisplayMember = "supname"
    End Sub

    Private Sub Load_PMR()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        RemoteDataSet.SupMR_ShowPMR.Clear()
        BusinessObject.Sub_Show(ServerPath2, "SupMr_PMRcombo", CommandType.StoredProcedure, RemoteDataSet, "SupMR_ShowPMR")
        cboPMR.DataSource = RemoteDataSet.SupMR_ShowPMR
        cboPMR.DisplayMember = "mrname"
    End Sub

    Private Sub Load_DSM2()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        RemoteDataSet.SupMR_ShowDSM.Clear()
        BusinessObject.Sub_Show(ServerPath2, "SupMr_DSMcombo2", CommandType.StoredProcedure, RemoteDataSet, "SupMR_ShowDSM")
        cboDSM.DataSource = RemoteDataSet.SupMR_ShowDSM
        cboDSM.DisplayMember = "supname"
    End Sub

    Private Sub Load_PMR2()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        RemoteDataSet.SupMR_ShowPMR.Clear()
        BusinessObject.Sub_Show(ServerPath2, "SupMr_PMRcombo2", CommandType.StoredProcedure, RemoteDataSet, "SupMR_ShowPMR")
        cboPMR.DataSource = RemoteDataSet.SupMR_ShowPMR
        cboPMR.DisplayMember = "mrname"
    End Sub

    Private Sub Load_DSM3()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        RemoteDataSet.SupMR_ShowDSM.Clear()
        BusinessObject.Sub_Show(ServerPath2, "SupMr_DSMcombo3", CommandType.StoredProcedure, RemoteDataSet, "SupMR_ShowDSM")
        cboDSM.DataSource = RemoteDataSet.SupMR_ShowDSM
        cboDSM.DisplayMember = "supname"
    End Sub

    Private Sub Load_PMR3()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        RemoteDataSet.SupMR_ShowPMR.Clear()
        BusinessObject.Sub_Show(ServerPath2, "SupMr_PMRcombo3", CommandType.StoredProcedure, RemoteDataSet, "SupMR_ShowPMR")
        cboPMR.DataSource = RemoteDataSet.SupMR_ShowPMR
        cboPMR.DisplayMember = "mrname"
    End Sub

    Private Sub Load_DSM4()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        RemoteDataSet.SupMR_ShowDSM.Clear()
        BusinessObject.Sub_Show(ServerPath2, "SupMr_DSMcombo4", CommandType.StoredProcedure, RemoteDataSet, "SupMR_ShowDSM")
        cboDSM.DataSource = RemoteDataSet.SupMR_ShowDSM
        cboDSM.DisplayMember = "supname"
    End Sub

    Private Sub Load_PMR4()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        RemoteDataSet.SupMR_ShowPMR.Clear()
        BusinessObject.Sub_Show(ServerPath2, "SupMr_PMRcombo4", CommandType.StoredProcedure, RemoteDataSet, "SupMR_ShowPMR")
        cboPMR.DataSource = RemoteDataSet.SupMR_ShowPMR
        cboPMR.DisplayMember = "mrname"
    End Sub

    Private Sub Load_TeamDivision()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "SupMR_TDivCombo", CommandType.StoredProcedure, RemoteDataSet, "TeamDivision_Show")
        cboTDiv.DataSource = RemoteDataSet.TeamDivision_Show
        cboTDiv.DisplayMember = "description"
    End Sub    'ActualDivision_combo

    Private Sub Load_ActDivision()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "SupMR_ADivCombo", CommandType.StoredProcedure, RemoteDataSet, "ActDivision_Show")
        cboAcDiv.DataSource = RemoteDataSet.ActDivision_Show
        cboAcDiv.DisplayMember = "div"
    End Sub

    Private Sub DataGrid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.Click, DataGrid1.CurrentCellChanged
        With DataGrid1
            cboDSM.Text = Trim(.Item(.CurrentCell.RowNumber, 0).ToString) & "--" & .Item(.CurrentCell.RowNumber, 1).ToString
            cboPMR.Text = Trim(.Item(.CurrentCell.RowNumber, 2).ToString) & "--" & .Item(.CurrentCell.RowNumber, 3).ToString
            currDSM = Trim(.Item(.CurrentCell.RowNumber, 0).ToString) & "--" & .Item(.CurrentCell.RowNumber, 1).ToString
            currPMR = Trim(.Item(.CurrentCell.RowNumber, 2).ToString) & "--" & .Item(.CurrentCell.RowNumber, 3).ToString
            If Trim(.Item(.CurrentCell.RowNumber, 4).ToString) <> "" Then
                TxtStartDate.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 4).ToString), "MM/dd/yyyy")
            Else
                TxtStartDate.Text = ""
            End If
            If Trim(.Item(.CurrentCell.RowNumber, 5).ToString) <> "" Then
                TxtEndDate.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 5).ToString), "MM/dd/yyyy")
            Else
                TxtEndDate.Text = ""
            End If
            txtRowid.Text = .Item(.CurrentCell.RowNumber, 6).ToString
            cboTDiv.Text = .Item(.CurrentCell.RowNumber, 7).ToString
            temDiv = .Item(.CurrentCell.RowNumber, 7).ToString
            cboAcDiv.Text = .Item(.CurrentCell.RowNumber, 8).ToString
            actDiv = .Item(.CurrentCell.RowNumber, 8).ToString
            If Trim(.Item(.CurrentCell.RowNumber, 9).ToString) <> "" Then
                lblCreateDate.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 9).ToString), "MM/dd/yyyy")
            Else
                lblCreateDate.Text = ""
            End If
            If Trim(.Item(.CurrentCell.RowNumber, 10).ToString) <> "" Then
                lblUpdateDate.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 10).ToString), "MM/dd/yyyy")
            Else
                lblUpdateDate.Text = ""
            End If
            TxtLastUser.Text = .Item(.CurrentCell.RowNumber, 11).ToString
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
            TxtStartDate.Text = GetDateTimeNow("MM") & "/01/" & GetDateTimeNow("yyyy")
            tmpSD = Format(CDate(TxtStartDate.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
            TxtEndDate.Text = GetEOM(TxtStartDate.Text)
            Exit Sub
        Else
            TxtStartDate.Text = DatValid(TxtStartDate.Text)  'validating the entry. the textbox's value will be "mm/dd/yyyy" if the entry is invalid.
            If Trim(TxtStartDate.Text) = "mm/dd/yyyy" Then
                GoTo errpt
            Else
                TxtStartDate.Text = Mid(Trim(TxtStartDate.Text), 1, 2) & "/01/" & _
                                    Mid(Trim(TxtStartDate.Text), 7, 4)   'making the date the start of the month entered
                tmpSD = Format(CDate(TxtStartDate.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt") 'will use this variable in saving
                'TxtEndDate.Text = GetEOM(TxtStartDate.Text)
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
            TxtEndDate.Text = "12/31/2078"
            tmpED = Format(CDate(TxtEndDate.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
            Exit Sub
        Else
            TxtEndDate.Text = DatValid(TxtEndDate.Text)
            If Trim(TxtEndDate.Text) = "mm/dd/yyyy" Then
                GoTo errpt
            Else
                If Trim(TxtStartDate.Text) <> "" Then
                    If CDate(TxtStartDate.Text) < CDate(TxtEndDate.Text) Then
                        'TxtEndDate.Text = GetEOM(Trim(TxtEndDate.Text))
                        'tmpED = Format(CDate(TxtEndDate.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim tmpDSM As String
        Dim tmpPMR As String
        tmpDSM = Trim(cboDSM.Text)
        tmpPMR = Trim(cboPMR.Text)
        If sender.ToString = "System.Windows.Forms.Button, Text: Include InActive DSM/PMR" Then
            Button1.Text = "Exclude InActive DSM/PMR"
            If Chk1.Checked = False Then
                cboDSM.DataSource = Nothing : Load_DSM2()
                cboPMR.DataSource = Nothing : Load_PMR2()
                cboDSM.Text = tmpDSM
                cboPMR.Text = tmpPMR
            ElseIf Chk1.Checked = True Then
                cboDSM.DataSource = Nothing : Load_DSM4()
                cboPMR.DataSource = Nothing : Load_PMR4()
                cboDSM.Text = GetDescription(tmpDSM) & "--" & GetCode(tmpDSM)
                cboPMR.Text = GetDescription(tmpPMR) & "--" & GetCode(tmpPMR)
            End If
        ElseIf sender.ToString = "System.Windows.Forms.Button, Text: Exclude InActive DSM/PMR" Then
            Button1.Text = "Include InActive DSM/PMR"
            If Chk1.Checked = False Then
                cboDSM.DataSource = Nothing : Load_DSM()
                cboPMR.DataSource = Nothing : Load_PMR()
                cboDSM.Text = tmpDSM
                cboPMR.Text = tmpPMR
            ElseIf Chk1.Checked = True Then
                cboDSM.DataSource = Nothing : Load_DSM3()
                cboPMR.DataSource = Nothing : Load_PMR3()
                cboDSM.Text = GetDescription(tmpDSM) & "--" & GetCode(tmpDSM)
                cboPMR.Text = GetDescription(tmpPMR) & "--" & GetCode(tmpPMR)
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        tmpRowid = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 6).ToString
        DataGrid1.DataSource = Nothing
        If RemoteDataSet.SupMR_Show.Count > 0 Then RemoteDataSet.SupMR_Show.Clear()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter
        Dim MRCode As New SqlParameter("@mrCode", SqlDbType.VarChar, 10)
        MRCode.Direction = ParameterDirection.Input
        MRCode.Value = GetCode(cboPMR.Text)
        Params(0) = MRCode
        BusinessObject.Sub_Show(ServerPath2, "SupMr_History_Show", CommandType.StoredProcedure, RemoteDataSet, "SupMR_Show", Params)
        DataGrid1.DataSource = RemoteDataSet.SupMR_Show
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        DataGrid1.DataSource = Nothing
        If Trim(listYear.Text) <> "" Then
            Sub_Show2()
        Else
            Sub_ShowA()
        End If
        For i = 0 To (RemoteDataSet.SupMR_Show.Rows.Count - 1)
            With DataGrid1
                If Val(tmpRowid) = CInt(.Item(i, 6)) Then
                    .CurrentCell = New DataGridCell(i, 0)
                    DataGrid1_Click(sender, e)
                    Exit For
                End If
            End With
        Next
    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim tmpDSM As String
        Dim tmpPMR As String
        If Chk1.Checked = False Then
            tmpDSM = currDSM
            tmpPMR = currPMR
            If Trim(Button1.Text) = "Exclude InActive DSM/PMR" Then
                cboDSM.DataSource = Nothing : Load_DSM()
                cboPMR.DataSource = Nothing : Load_PMR()
            ElseIf Trim(Button1.Text) = "Include InActive DSM/PMR" Then
                cboDSM.DataSource = Nothing : Load_DSM2()
                cboPMR.DataSource = Nothing : Load_PMR2()
            End If
            cboDSM.Text = tmpDSM
            cboPMR.Text = tmpPMR
        ElseIf Chk1.Checked = True Then
            tmpDSM = GetDescription(currDSM) & "--" & GetCode(currDSM)
            tmpPMR = GetDescription(currPMR) & "--" & GetCode(currPMR)
            If Trim(Button1.Text) = "Exclude InActive DSM/PMR" Then
                cboDSM.DataSource = Nothing : Load_DSM3()
                cboPMR.DataSource = Nothing : Load_PMR3()
            ElseIf Trim(Button1.Text) = "Include InActive DSM/PMR" Then
                cboDSM.DataSource = Nothing : Load_DSM4()
                cboPMR.DataSource = Nothing : Load_PMR4()
            End If
            cboDSM.Text = tmpDSM
            cboPMR.Text = tmpPMR
        End If
        'cboDSM.Text = currDSM
        'cboPMR.Text = currPMR
    End Sub

    Private Sub Button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter
        DataGrid1.DataSource = Nothing
        If RemoteDataSet.SupMR_Show.Count > 0 Then RemoteDataSet.SupMR_Show.Clear()
        z = "select  "
        z = z & "rtrim(sm.supcode) [supcode], su.supname [DSM], "
        z = z & "rtrim(sm.mrcode) [mrcode], me.mrname [PMR], "
        z = z & " sm.Start_Date, "
        z = z & "sm.End_Date, "
        z = z & "sm.rownumber, "
        z = z & "isnull(sm.TeamDivision,'') [TeamDivision], "
        z = z & "isnull(sm.Division,'') [Division], "
        z = z & "sm.CreateDate, "
        z = z & "sm.UpdateDate, "
        z = z & "sm.LastUser "
        z = z & "from NewScores..SupMr sm  "
        z = z & "inner join NewScores..Supervisor su on sm.supcode=su.supcode "
        z = z & "inner join NewScores..MedRep me     on sm.mrcode=me.mrcode "
        If Trim(listYear.Text) <> "" Or Trim(cboCompany.Text) <> "" Then
            z = z & "where "
        End If
        If Trim(listYear.Text) <> "" Then
            z = z & "year(sm.end_date) = '" & Trim(listYear.Text) & "' "
            If Trim(cboCompany.Text) <> "" Then
                z = z & "and "
            End If
        End If
        If Trim(cboCompany.Text) = "QX" Then
            z = z & "sm.mrcode like 'x%' "
        ElseIf Trim(cboCompany.Text) = "NMPC" Then
            z = z & "sm.mrcode not like 'x%' "
        End If
        z = z & "order by su.supname, me.mrname "

        Dim SQLstmnt As New SqlParameter("@SqlQry", SqlDbType.NVarChar, 2950)
        SQLstmnt.Direction = ParameterDirection.Input
        SQLstmnt.Value = z
        Params(0) = SQLstmnt
        If RemoteDataSet.GenericQryProc.Count > 0 Then RemoteDataSet.GenericQryProc.Clear()
        Try
            BusinessObject.Sub_Show(ServerPath2, "GenericQryProc", CommandType.StoredProcedure, RemoteDataSet, "SupMR_Show", Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        DataGrid1.DataSource = RemoteDataSet.SupMR_Show
    End Sub

    Private Sub cboAcDiv_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboAcDiv.LostFocus
        actDiv = cboAcDiv.Text
    End Sub

    Private Sub cboTDiv_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTDiv.LostFocus
        temDiv = Trim(cboTDiv.Text)
    End Sub

    Private Sub listYear_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles listYear.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub listYear_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles listYear.Validating
        If Trim(listYear.Text) <> "" Then
            If Len(Trim(listYear.Text)) = 4 Then
                Try
                    Val(listYear.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    e.Cancel = True
                    Exit Sub
                End Try
                If Val(listYear.Text) <= 1899 And Val(listYear.Text) >= 2051 Then
                    MsgBox("Invalid Year!")
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub cboDSM_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDSM.LostFocus
        currDSM = cboDSM.Text
    End Sub

    Private Sub cboPMR_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPMR.LostFocus
        currPMR = cboPMR.Text
    End Sub
End Class