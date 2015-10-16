Imports System.Data.SqlClient

Public Class frmSupMr
    'Inherits System.Windows.Forms.Form
    'Private EditMode As Boolean = False

    Inherits System.Windows.Forms.Form
    Private RemoteDataSet As New MyDataSetDB
    Private EditMode As Boolean = False
    Private oldDs As String, tmpSD As String, tmpED As String   '<-- added-DBrion
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
    Friend WithEvents cboADiv As System.Windows.Forms.ComboBox
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.DGTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.dgDSM = New System.Windows.Forms.DataGridTextBoxColumn
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
        Me.cboADiv = New System.Windows.Forms.ComboBox
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
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 8)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(555, 235)
        Me.DataGrid1.TabIndex = 0
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DGTableStyle1})
        Me.DataGrid1.Tag = "View"
        '
        'DGTableStyle1
        '
        Me.DGTableStyle1.AlternatingBackColor = System.Drawing.Color.Aqua
        Me.DGTableStyle1.BackColor = System.Drawing.Color.LightCyan
        Me.DGTableStyle1.DataGrid = Me.DataGrid1
        Me.DGTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.dgDSM, Me.dgPMR, Me.dgStart_Date, Me.dgEnd_Date, Me.dgRowid, Me.dgTeamDivision, Me.dgDivision, Me.dgCreateDate, Me.dgUpdateDate, Me.dgLastUser})
        Me.DGTableStyle1.HeaderBackColor = System.Drawing.Color.AntiqueWhite
        Me.DGTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DGTableStyle1.MappingName = "SupMR_Show"
        '
        'dgDSM
        '
        Me.dgDSM.Format = ""
        Me.dgDSM.FormatInfo = Nothing
        Me.dgDSM.HeaderText = "DSM"
        Me.dgDSM.MappingName = "dsm"
        Me.dgDSM.NullText = ""
        Me.dgDSM.Width = 75
        '
        'dgPMR
        '
        Me.dgPMR.Format = ""
        Me.dgPMR.FormatInfo = Nothing
        Me.dgPMR.HeaderText = "PMR"
        Me.dgPMR.MappingName = "pmr"
        Me.dgPMR.NullText = ""
        Me.dgPMR.Width = 75
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
        Me.cboPMR.TabIndex = 18
        Me.cboPMR.Tag = "Input"
        '
        'cboDSM
        '
        Me.cboDSM.Enabled = False
        Me.cboDSM.Location = New System.Drawing.Point(122, 252)
        Me.cboDSM.MaxDropDownItems = 10
        Me.cboDSM.Name = "cboDSM"
        Me.cboDSM.Size = New System.Drawing.Size(259, 21)
        Me.cboDSM.TabIndex = 16
        Me.cboDSM.Tag = "Input"
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(148, 362)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.TabIndex = 25
        Me.cmdEdit.Tag = "Edit"
        Me.cmdEdit.Text = "Edit"
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(302, 362)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.TabIndex = 27
        Me.cmdExit.Tag = "Exit"
        Me.cmdExit.Text = "Exit"
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(71, 362)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.TabIndex = 24
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
        Me.cmdDelete.TabIndex = 26
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
        Me.cboTDiv.TabIndex = 30
        Me.cboTDiv.Tag = "Input"
        '
        'cboADiv
        '
        Me.cboADiv.Enabled = False
        Me.cboADiv.Location = New System.Drawing.Point(122, 327)
        Me.cboADiv.MaxDropDownItems = 10
        Me.cboADiv.Name = "cboADiv"
        Me.cboADiv.Size = New System.Drawing.Size(259, 21)
        Me.cboADiv.TabIndex = 32
        Me.cboADiv.Tag = "Input"
        '
        'TxtEndDate
        '
        Me.TxtEndDate.Location = New System.Drawing.Point(458, 277)
        Me.TxtEndDate.MaxLength = 10
        Me.TxtEndDate.Name = "TxtEndDate"
        Me.TxtEndDate.Size = New System.Drawing.Size(104, 20)
        Me.TxtEndDate.TabIndex = 54
        Me.TxtEndDate.Tag = "Input"
        Me.TxtEndDate.Text = ""
        '
        'TxtStartDate
        '
        Me.TxtStartDate.Location = New System.Drawing.Point(458, 252)
        Me.TxtStartDate.MaxLength = 10
        Me.TxtStartDate.Name = "TxtStartDate"
        Me.TxtStartDate.Size = New System.Drawing.Size(104, 20)
        Me.TxtStartDate.TabIndex = 53
        Me.TxtStartDate.Tag = "Input"
        Me.TxtStartDate.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(385, 278)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 20)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "End Date"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(385, 253)
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
        Me.lblUpdateDate.Location = New System.Drawing.Point(458, 327)
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
        Me.lblCreateDate.Location = New System.Drawing.Point(458, 302)
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
        Me.Label9.Location = New System.Drawing.Point(385, 328)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 20)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "Update Date"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(385, 303)
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
        'frmSupMr
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(570, 391)
        Me.ControlBox = False
        Me.Controls.Add(Me.SqlValue)
        Me.Controls.Add(Me.TxtLastUser)
        Me.Controls.Add(Me.txtRowid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblUpdateDate)
        Me.Controls.Add(Me.lblCreateDate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtEndDate)
        Me.Controls.Add(Me.TxtStartDate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboADiv)
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
        ControlMaintenance.ClearInputControls(Me)
        EditMode = False
    End Sub

    Private Sub cmdSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If (MessageBox.Show("Are you sure you want to Save this Entry?", "Confirm Saving", _
              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)) _
              = DialogResult.Yes Then

            Dim Params(0) As String
            Params(0) = txtRowid.Text
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
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(8) As SqlParameter
        Dim SupName As New SqlParameter("@SupName", SqlDbType.VarChar, 100)
        SupName.Direction = ParameterDirection.Input
        SupName.Value = Trim(cboDSM.Text)
        Params(0) = SupName
        Dim MRname As New SqlParameter("@MRname", SqlDbType.VarChar, 100)
        MRname.Direction = ParameterDirection.Input
        MRname.Value = Trim(cboPMR.Text)
        Params(1) = MRname
        Dim StartDate As New SqlParameter("@Start_Date", SqlDbType.DateTime)
        StartDate.Direction = ParameterDirection.Input
        StartDate.Value = Trim(TxtStartDate.Text)    ' & GetDateTimeNow(" h:mm:ss tt")
        Params(2) = StartDate
        Dim EndDate As New SqlParameter("@End_Date", SqlDbType.DateTime)
        EndDate.Direction = ParameterDirection.Input
        EndDate.Value = Trim(TxtEndDate.Text)        ' & GetDateTimeNow(" h:mm:ss tt")
        Params(3) = EndDate
        'added-DBrion --v
        Dim TeamDivision As New SqlParameter("@TeamDivision", SqlDbType.VarChar, 50)
        TeamDivision.Direction = ParameterDirection.Input
        TeamDivision.Value = Trim(cboTDiv.Text)
        Params(4) = TeamDivision
        Dim Division As New SqlParameter("@Division", SqlDbType.VarChar, 30)
        Division.Direction = ParameterDirection.Input
        Division.Value = Trim(cboADiv.Text)
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
        LastUser.Value = Trim(TxtLastUser.Text)
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
        Dim Pram(0) As SqlParameter
        s = "select supcode as fld1 from NewScores..Supervisor where rtrim(supname) = rtrim('" & Trim(cboDSM.Text) & "') "
        Dim SQLstmnt1 As New SqlParameter("@SqlQry", SqlDbType.NVarChar, 2950)
        SQLstmnt1.Direction = ParameterDirection.Input
        SQLstmnt1.Value = s
        Pram(0) = SQLstmnt1
        Try
            BusinessObject.Sub_Show(ServerPath2, "GenericQryProc", CommandType.StoredProcedure, RemoteDataSet, "GenericQryProc", Pram)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        SqlValue.DataSource = RemoteDataSet.GenericQryProc
        SqlValue.DisplayMember = "fld1"
        Dim SupName As New SqlParameter("@SupCode", SqlDbType.VarChar, 10)
        SupName.Direction = ParameterDirection.Input
        SupName.Value = Trim(SqlValue.Text)
        Params(0) = SupName
        SqlValue.ResetText()
        SqlValue.DataSource = Nothing
        RemoteDataSet.GenericQryProc.Clear()

        Dim Prams(0) As SqlParameter
        s = "select mrcode as fld1 from NewScores..MedRep where rtrim(mrname) = rtrim('" & Trim(cboPMR.Text) & "') "
        Dim SQLstmnt As New SqlParameter("@SqlQry", SqlDbType.NVarChar, 2950)
        SQLstmnt.Direction = ParameterDirection.Input
        SQLstmnt.Value = s
        Prams(0) = SQLstmnt
        Try
            BusinessObject.Sub_Show(ServerPath2, "GenericQryProc", CommandType.StoredProcedure, RemoteDataSet, "GenericQryProc", Prams)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        SqlValue.DataSource = RemoteDataSet.GenericQryProc
        SqlValue.DisplayMember = "fld1"
        Dim MRcode As New SqlParameter("@MRcode", SqlDbType.VarChar, 10)
        MRcode.Direction = ParameterDirection.Input
        MRcode.Value = Trim(SqlValue.Text)
        Params(1) = MRcode
        SqlValue.ResetText()
        SqlValue.DataSource = Nothing
        RemoteDataSet.GenericQryProc.Clear()

        Dim StartDate As New SqlParameter("@Start_Date", SqlDbType.DateTime, 10)
        StartDate.Direction = ParameterDirection.Input
        StartDate.Value = Trim(TxtStartDate.Text)       ' & GetDateTimeNow(" h:mm:ss tt")
        Params(2) = StartDate
        Dim EndDate As New SqlParameter("@End_Date", SqlDbType.DateTime, 10)
        EndDate.Direction = ParameterDirection.Input
        EndDate.Value = Trim(TxtEndDate.Text)           ' & GetDateTimeNow(" h:mm:ss tt")
        Params(3) = EndDate
        Dim Rownumber As New SqlParameter("@Rownumber", SqlDbType.Int)
        Rownumber.Direction = ParameterDirection.Input
        Rownumber.Value = Trim(txtRowid.Text)
        Params(4) = Rownumber
        'added-DBrion --v
        Dim TeamDivision As New SqlParameter("@TeamDivision", SqlDbType.VarChar, 50)
        TeamDivision.Direction = ParameterDirection.Input
        TeamDivision.Value = Trim(cboTDiv.Text)
        Params(5) = TeamDivision
        Dim Division As New SqlParameter("@Division", SqlDbType.VarChar, 30)
        Division.Direction = ParameterDirection.Input
        Division.Value = Trim(cboADiv.Text)
        Params(6) = Division
        'added-DBrion --^
        Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime, 10)
        UpdateDate.Direction = ParameterDirection.Input
        UpdateDate.Value = GetDateTimeNow()
        Params(7) = UpdateDate
        Dim LastUser As New SqlParameter("@LastUser", SqlDbType.VarChar, 10)
        LastUser.Direction = ParameterDirection.Input
        LastUser.Value = Trim(TxtLastUser.Text)
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
                If myRowid = CInt(.Item(i, 4)) Then
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
    End Sub

    Private Sub Load_DSM()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "SupMr_DSMcombo", CommandType.StoredProcedure, RemoteDataSet, "SupMR_ShowDSM")
        cboDSM.DataSource = RemoteDataSet.SupMR_ShowDSM
        cboDSM.DisplayMember = "supname"
    End Sub

    Private Sub Load_PMR()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "SupMr_PMRcombo", CommandType.StoredProcedure, RemoteDataSet, "SupMR_ShowPMR")
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
        cboADiv.DataSource = RemoteDataSet.ActDivision_Show
        cboADiv.DisplayMember = "div"
    End Sub

    Private Sub DataGrid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.Click
        With DataGrid1
            cboDSM.Text = .Item(.CurrentCell.RowNumber, 0).ToString
            cboPMR.Text = .Item(.CurrentCell.RowNumber, 1).ToString
            If Trim(.Item(.CurrentCell.RowNumber, 2).ToString) <> "" Then
                TxtStartDate.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 2).ToString), "MM/dd/yyyy")
            Else
                TxtStartDate.Text = ""
            End If
            If Trim(.Item(.CurrentCell.RowNumber, 3).ToString) <> "" Then
                TxtEndDate.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 3).ToString), "MM/dd/yyyy")
            Else
                TxtEndDate.Text = ""
            End If
            txtRowid.Text = .Item(.CurrentCell.RowNumber, 4).ToString
            cboTDiv.Text = .Item(.CurrentCell.RowNumber, 5).ToString
            cboADiv.Text = .Item(.CurrentCell.RowNumber, 6).ToString
            If Trim(.Item(.CurrentCell.RowNumber, 7).ToString) <> "" Then
                lblCreateDate.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 7).ToString), "MM/dd/yyyy")
            Else
                lblCreateDate.Text = ""
            End If
            If Trim(.Item(.CurrentCell.RowNumber, 8).ToString) <> "" Then
                lblUpdateDate.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 8).ToString), "MM/dd/yyyy")
            Else
                lblUpdateDate.Text = ""
            End If
            TxtLastUser.Text = .Item(.CurrentCell.RowNumber, 9).ToString
            .Select(.CurrentRowIndex)    'CurrentCell.RowNumber)
        End With
    End Sub
End Class