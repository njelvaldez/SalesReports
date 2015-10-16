Imports System.Data.SqlClient
Imports Microsoft

Public Class SupMr
    Inherits System.Windows.Forms.Form
    Private RemoteDataSet As New CodeTablesDS
    Private RemoteDataSet2 As New MyDataSetDB
    Private tmpPMRx As String, tmpDSMx As String

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        PMR_Show()
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
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGrid2 As System.Windows.Forms.DataGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPMR_Add As System.Windows.Forms.Button
    Friend WithEvents btnPMR_Edit As System.Windows.Forms.Button
    Friend WithEvents btnPMR_Delete As System.Windows.Forms.Button
    Friend WithEvents btnDSM_Add As System.Windows.Forms.Button
    Friend WithEvents btnDSM_Edit As System.Windows.Forms.Button
    Friend WithEvents btnDSM_Delete As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents dg_Rowid As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dg_MrCode As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dg_MrName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dg_HireDate As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dg_ResignDate As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dg_CreateDate As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dg_UpdateDate As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dg_Email As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dg_MobileNo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dg_CompanyCode As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dg_Status As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dg_LastUser As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents dg_SupCode As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dg_DSM As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dg_StartDate As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dg_EndDate As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dg_Rowno As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dg_TeamDivision As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dg_Division As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dg_Create As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dg_Update As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dg_LastUsr As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents pmrRowid As System.Windows.Forms.TextBox
    Friend WithEvents dsmRowid As System.Windows.Forms.TextBox
    Friend WithEvents dg_Start_Date As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dg_End_Date As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dg_wCar As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dg_Emp_No As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dg_DimCode As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dg_Address1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dg_Address2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dg_PicturePath As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(SupMr))
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.dg_SupCode = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dg_DSM = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dg_StartDate = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dg_EndDate = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dg_Rowno = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dg_TeamDivision = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dg_Division = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dg_Create = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dg_Update = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dg_LastUsr = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGrid2 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.dg_Rowid = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dg_MrCode = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dg_MrName = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dg_HireDate = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dg_ResignDate = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dg_CreateDate = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dg_UpdateDate = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dg_Email = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dg_MobileNo = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dg_CompanyCode = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dg_Status = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dg_LastUser = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dg_Start_Date = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dg_End_Date = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dg_wCar = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dg_Emp_No = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dg_DimCode = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dg_Address1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dg_Address2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dg_PicturePath = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnPMR_Add = New System.Windows.Forms.Button
        Me.btnPMR_Edit = New System.Windows.Forms.Button
        Me.btnPMR_Delete = New System.Windows.Forms.Button
        Me.btnDSM_Add = New System.Windows.Forms.Button
        Me.btnDSM_Edit = New System.Windows.Forms.Button
        Me.btnDSM_Delete = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.pmrRowid = New System.Windows.Forms.TextBox
        Me.dsmRowid = New System.Windows.Forms.TextBox
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.CaptionText = "Team Manager"
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(11, 306)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(1198, 254)
        Me.DataGrid1.TabIndex = 1
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        Me.DataGrid1.Tag = "View"
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.AlternatingBackColor = System.Drawing.Color.Cyan
        Me.DataGridTableStyle2.BackColor = System.Drawing.Color.LightCyan
        Me.DataGridTableStyle2.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.dg_SupCode, Me.dg_DSM, Me.dg_StartDate, Me.dg_EndDate, Me.dg_Rowno, Me.dg_TeamDivision, Me.dg_Division, Me.dg_Create, Me.dg_Update, Me.dg_LastUsr})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "SupMr_Show5"
        '
        'dg_SupCode
        '
        Me.dg_SupCode.Format = ""
        Me.dg_SupCode.FormatInfo = Nothing
        Me.dg_SupCode.HeaderText = "Code"
        Me.dg_SupCode.MappingName = "supcode"
        Me.dg_SupCode.NullText = ""
        Me.dg_SupCode.Width = 55
        '
        'dg_DSM
        '
        Me.dg_DSM.Format = ""
        Me.dg_DSM.FormatInfo = Nothing
        Me.dg_DSM.HeaderText = "Name"
        Me.dg_DSM.MappingName = "dsm"
        Me.dg_DSM.NullText = ""
        Me.dg_DSM.Width = 210
        '
        'dg_StartDate
        '
        Me.dg_StartDate.Format = "MM/dd/yyyy"
        Me.dg_StartDate.FormatInfo = Nothing
        Me.dg_StartDate.HeaderText = "Start Date"
        Me.dg_StartDate.MappingName = "start_date"
        Me.dg_StartDate.NullText = ""
        Me.dg_StartDate.Width = 70
        '
        'dg_EndDate
        '
        Me.dg_EndDate.Format = "MM/dd/yyyy"
        Me.dg_EndDate.FormatInfo = Nothing
        Me.dg_EndDate.HeaderText = "End Date"
        Me.dg_EndDate.MappingName = "end_date"
        Me.dg_EndDate.NullText = ""
        Me.dg_EndDate.Width = 70
        '
        'dg_Rowno
        '
        Me.dg_Rowno.Format = ""
        Me.dg_Rowno.FormatInfo = Nothing
        Me.dg_Rowno.MappingName = "rownumber"
        Me.dg_Rowno.NullText = ""
        Me.dg_Rowno.Width = 50
        '
        'dg_TeamDivision
        '
        Me.dg_TeamDivision.Format = ""
        Me.dg_TeamDivision.FormatInfo = Nothing
        Me.dg_TeamDivision.HeaderText = "Team Segment"
        Me.dg_TeamDivision.MappingName = "teamdivision"
        Me.dg_TeamDivision.NullText = ""
        Me.dg_TeamDivision.Width = 200
        '
        'dg_Division
        '
        Me.dg_Division.Format = ""
        Me.dg_Division.FormatInfo = Nothing
        Me.dg_Division.HeaderText = "Segment"
        Me.dg_Division.MappingName = "division"
        Me.dg_Division.NullText = ""
        Me.dg_Division.Width = 200
        '
        'dg_Create
        '
        Me.dg_Create.Format = "MM/dd/yyyy"
        Me.dg_Create.FormatInfo = Nothing
        Me.dg_Create.HeaderText = "Create Date"
        Me.dg_Create.MappingName = "createdate"
        Me.dg_Create.NullText = ""
        Me.dg_Create.Width = 70
        '
        'dg_Update
        '
        Me.dg_Update.Format = "MM/dd/yyyy"
        Me.dg_Update.FormatInfo = Nothing
        Me.dg_Update.HeaderText = "Update Date"
        Me.dg_Update.MappingName = "updatedate"
        Me.dg_Update.NullText = ""
        Me.dg_Update.Width = 70
        '
        'dg_LastUsr
        '
        Me.dg_LastUsr.Format = ""
        Me.dg_LastUsr.FormatInfo = Nothing
        Me.dg_LastUsr.HeaderText = "Encoder"
        Me.dg_LastUsr.MappingName = "lastuser"
        Me.dg_LastUsr.NullText = ""
        Me.dg_LastUsr.Width = 75
        '
        'DataGrid2
        '
        Me.DataGrid2.CaptionText = "Specialist"
        Me.DataGrid2.DataMember = ""
        Me.DataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid2.Location = New System.Drawing.Point(11, 16)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.ReadOnly = True
        Me.DataGrid2.Size = New System.Drawing.Size(1196, 263)
        Me.DataGrid2.TabIndex = 2
        Me.DataGrid2.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.DataGrid2.Tag = "View"
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Cyan
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightCyan
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid2
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.dg_Rowid, Me.dg_MrCode, Me.dg_MrName, Me.dg_HireDate, Me.dg_ResignDate, Me.dg_CreateDate, Me.dg_UpdateDate, Me.dg_Email, Me.dg_MobileNo, Me.dg_CompanyCode, Me.dg_Status, Me.dg_LastUser, Me.dg_Start_Date, Me.dg_End_Date, Me.dg_wCar, Me.dg_Emp_No, Me.dg_DimCode, Me.dg_Address1, Me.dg_Address2, Me.dg_PicturePath})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "MedRepCT_Show"
        '
        'dg_Rowid
        '
        Me.dg_Rowid.Format = ""
        Me.dg_Rowid.FormatInfo = Nothing
        Me.dg_Rowid.MappingName = "rowid"
        Me.dg_Rowid.NullText = ""
        Me.dg_Rowid.Width = 50
        '
        'dg_MrCode
        '
        Me.dg_MrCode.Format = ""
        Me.dg_MrCode.FormatInfo = Nothing
        Me.dg_MrCode.HeaderText = "Code"
        Me.dg_MrCode.MappingName = "mrcode"
        Me.dg_MrCode.NullText = ""
        Me.dg_MrCode.Width = 55
        '
        'dg_MrName
        '
        Me.dg_MrName.Format = ""
        Me.dg_MrName.FormatInfo = Nothing
        Me.dg_MrName.HeaderText = "Name"
        Me.dg_MrName.MappingName = "mrname"
        Me.dg_MrName.NullText = ""
        Me.dg_MrName.Width = 210
        '
        'dg_HireDate
        '
        Me.dg_HireDate.Format = "MM/dd/yyyy"
        Me.dg_HireDate.FormatInfo = Nothing
        Me.dg_HireDate.HeaderText = "Hire Date"
        Me.dg_HireDate.MappingName = "hire_date"
        Me.dg_HireDate.NullText = ""
        Me.dg_HireDate.Width = 70
        '
        'dg_ResignDate
        '
        Me.dg_ResignDate.Format = "MM/dd/yyyy"
        Me.dg_ResignDate.FormatInfo = Nothing
        Me.dg_ResignDate.HeaderText = "Resign Date"
        Me.dg_ResignDate.MappingName = "resign_date"
        Me.dg_ResignDate.NullText = ""
        Me.dg_ResignDate.Width = 70
        '
        'dg_CreateDate
        '
        Me.dg_CreateDate.Format = "MM/dd/yyyy"
        Me.dg_CreateDate.FormatInfo = Nothing
        Me.dg_CreateDate.HeaderText = "Create Date"
        Me.dg_CreateDate.MappingName = "createdate"
        Me.dg_CreateDate.NullText = ""
        Me.dg_CreateDate.Width = 70
        '
        'dg_UpdateDate
        '
        Me.dg_UpdateDate.Format = "MM/dd/yyyy"
        Me.dg_UpdateDate.FormatInfo = Nothing
        Me.dg_UpdateDate.HeaderText = "Update Date"
        Me.dg_UpdateDate.MappingName = "updatedate"
        Me.dg_UpdateDate.NullText = ""
        Me.dg_UpdateDate.Width = 70
        '
        'dg_Email
        '
        Me.dg_Email.Format = ""
        Me.dg_Email.FormatInfo = Nothing
        Me.dg_Email.HeaderText = "E-mail"
        Me.dg_Email.MappingName = "email"
        Me.dg_Email.NullText = ""
        Me.dg_Email.Width = 130
        '
        'dg_MobileNo
        '
        Me.dg_MobileNo.Format = ""
        Me.dg_MobileNo.FormatInfo = Nothing
        Me.dg_MobileNo.HeaderText = "Mobile no."
        Me.dg_MobileNo.MappingName = "mobileno"
        Me.dg_MobileNo.NullText = ""
        Me.dg_MobileNo.Width = 90
        '
        'dg_CompanyCode
        '
        Me.dg_CompanyCode.Format = ""
        Me.dg_CompanyCode.FormatInfo = Nothing
        Me.dg_CompanyCode.HeaderText = "Company"
        Me.dg_CompanyCode.MappingName = "companycode"
        Me.dg_CompanyCode.NullText = ""
        Me.dg_CompanyCode.Width = 75
        '
        'dg_Status
        '
        Me.dg_Status.Format = ""
        Me.dg_Status.FormatInfo = Nothing
        Me.dg_Status.HeaderText = "Status"
        Me.dg_Status.MappingName = "status"
        Me.dg_Status.NullText = ""
        Me.dg_Status.Width = 75
        '
        'dg_LastUser
        '
        Me.dg_LastUser.Format = ""
        Me.dg_LastUser.FormatInfo = Nothing
        Me.dg_LastUser.HeaderText = "Encoder"
        Me.dg_LastUser.MappingName = "lastuser"
        Me.dg_LastUser.NullText = ""
        Me.dg_LastUser.Width = 70
        '
        'dg_Start_Date
        '
        Me.dg_Start_Date.Format = "MM/dd/yyyy"
        Me.dg_Start_Date.FormatInfo = Nothing
        Me.dg_Start_Date.HeaderText = "Start Date"
        Me.dg_Start_Date.MappingName = "start_date"
        Me.dg_Start_Date.NullText = ""
        Me.dg_Start_Date.Width = 70
        '
        'dg_End_Date
        '
        Me.dg_End_Date.Format = "MM/dd/yyyy"
        Me.dg_End_Date.FormatInfo = Nothing
        Me.dg_End_Date.HeaderText = "End Date"
        Me.dg_End_Date.MappingName = "end_date"
        Me.dg_End_Date.NullText = ""
        Me.dg_End_Date.Width = 70
        '
        'dg_wCar
        '
        Me.dg_wCar.Format = ""
        Me.dg_wCar.FormatInfo = Nothing
        Me.dg_wCar.HeaderText = "w/Car"
        Me.dg_wCar.MappingName = "wcar"
        Me.dg_wCar.NullText = ""
        Me.dg_wCar.Width = 50
        '
        'dg_Emp_No
        '
        Me.dg_Emp_No.Format = ""
        Me.dg_Emp_No.FormatInfo = Nothing
        Me.dg_Emp_No.HeaderText = "Employee No"
        Me.dg_Emp_No.MappingName = "Emp_No"
        Me.dg_Emp_No.Width = 75
        '
        'dg_DimCode
        '
        Me.dg_DimCode.Format = ""
        Me.dg_DimCode.FormatInfo = Nothing
        Me.dg_DimCode.HeaderText = "Dimension Code"
        Me.dg_DimCode.MappingName = "DimCode"
        Me.dg_DimCode.Width = 75
        '
        'dg_Address1
        '
        Me.dg_Address1.Format = ""
        Me.dg_Address1.FormatInfo = Nothing
        Me.dg_Address1.HeaderText = "Address 1"
        Me.dg_Address1.MappingName = "Address1"
        Me.dg_Address1.Width = 75
        '
        'dg_Address2
        '
        Me.dg_Address2.Format = ""
        Me.dg_Address2.FormatInfo = Nothing
        Me.dg_Address2.HeaderText = "Address 2"
        Me.dg_Address2.MappingName = "Address2"
        Me.dg_Address2.Width = 75
        '
        'dg_PicturePath
        '
        Me.dg_PicturePath.Format = ""
        Me.dg_PicturePath.FormatInfo = Nothing
        Me.dg_PicturePath.HeaderText = "Picture Path"
        Me.dg_PicturePath.MappingName = "PicturePath"
        Me.dg_PicturePath.Width = 75
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(11, 292)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1195, 3)
        Me.Label1.TabIndex = 3
        '
        'btnPMR_Add
        '
        Me.btnPMR_Add.Location = New System.Drawing.Point(1224, 14)
        Me.btnPMR_Add.Name = "btnPMR_Add"
        Me.btnPMR_Add.Size = New System.Drawing.Size(95, 24)
        Me.btnPMR_Add.TabIndex = 4
        Me.btnPMR_Add.Text = "Add"
        '
        'btnPMR_Edit
        '
        Me.btnPMR_Edit.Location = New System.Drawing.Point(1224, 44)
        Me.btnPMR_Edit.Name = "btnPMR_Edit"
        Me.btnPMR_Edit.Size = New System.Drawing.Size(95, 24)
        Me.btnPMR_Edit.TabIndex = 5
        Me.btnPMR_Edit.Text = "Edit"
        '
        'btnPMR_Delete
        '
        Me.btnPMR_Delete.Location = New System.Drawing.Point(1224, 74)
        Me.btnPMR_Delete.Name = "btnPMR_Delete"
        Me.btnPMR_Delete.Size = New System.Drawing.Size(95, 24)
        Me.btnPMR_Delete.TabIndex = 6
        Me.btnPMR_Delete.Text = "Delete"
        '
        'btnDSM_Add
        '
        Me.btnDSM_Add.Location = New System.Drawing.Point(1224, 306)
        Me.btnDSM_Add.Name = "btnDSM_Add"
        Me.btnDSM_Add.Size = New System.Drawing.Size(95, 24)
        Me.btnDSM_Add.TabIndex = 7
        Me.btnDSM_Add.Text = "Add"
        '
        'btnDSM_Edit
        '
        Me.btnDSM_Edit.Location = New System.Drawing.Point(1224, 336)
        Me.btnDSM_Edit.Name = "btnDSM_Edit"
        Me.btnDSM_Edit.Size = New System.Drawing.Size(95, 24)
        Me.btnDSM_Edit.TabIndex = 8
        Me.btnDSM_Edit.Text = "Edit"
        '
        'btnDSM_Delete
        '
        Me.btnDSM_Delete.Location = New System.Drawing.Point(1224, 366)
        Me.btnDSM_Delete.Name = "btnDSM_Delete"
        Me.btnDSM_Delete.Size = New System.Drawing.Size(95, 24)
        Me.btnDSM_Delete.TabIndex = 9
        Me.btnDSM_Delete.Text = "Delete"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(1224, 530)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(95, 24)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        '
        'pmrRowid
        '
        Me.pmrRowid.Location = New System.Drawing.Point(697, 276)
        Me.pmrRowid.Name = "pmrRowid"
        Me.pmrRowid.Size = New System.Drawing.Size(75, 20)
        Me.pmrRowid.TabIndex = 69
        Me.pmrRowid.Tag = "Input"
        Me.pmrRowid.Text = ""
        Me.pmrRowid.Visible = False
        '
        'dsmRowid
        '
        Me.dsmRowid.Location = New System.Drawing.Point(777, 276)
        Me.dsmRowid.Name = "dsmRowid"
        Me.dsmRowid.Size = New System.Drawing.Size(75, 20)
        Me.dsmRowid.TabIndex = 70
        Me.dsmRowid.Tag = "Input"
        Me.dsmRowid.Text = ""
        Me.dsmRowid.Visible = False
        '
        'SupMr
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1322, 574)
        Me.Controls.Add(Me.dsmRowid)
        Me.Controls.Add(Me.pmrRowid)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDSM_Delete)
        Me.Controls.Add(Me.btnDSM_Edit)
        Me.Controls.Add(Me.btnDSM_Add)
        Me.Controls.Add(Me.btnPMR_Delete)
        Me.Controls.Add(Me.btnPMR_Edit)
        Me.Controls.Add(Me.btnPMR_Add)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGrid2)
        Me.Controls.Add(Me.DataGrid1)
        Me.Name = "SupMr"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Specialist Maintenance"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub PMR_Show()
        Try
            If RemoteDataSet.MedRepCT_Show.Count > 0 Then RemoteDataSet.MedRepCT_Show.Clear()
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            BusinessObject.Sub_Show(ServerPath2, "MedRepCT_Show", CommandType.StoredProcedure, _
                               RemoteDataSet, "MedRepCT_Show")
            DataGrid2.DataSource = RemoteDataSet.MedRepCT_Show

            'Dim MedRepDS As New DataSet
            'MedRepDS.Tables.Add("MedRepCT_Show")
            'BusinessObject.Sub_Show(ServerPath2, "MedRepCT_Show", CommandType.StoredProcedure, _
            '                        MedRepDS, "MedRepCT_Show")
            'DataGrid2.DataSource = MedRepDS.Tables(0)

            'Hide the column with empty header
            Dim dgts As New DataGridTableStyle
            dgts.MappingName = DataGrid2.DataMember
            DataGrid2.TableStyles.Add(dgts)
            DataGrid2.TableStyles(0).GridColumnStyles(0).Width = 0
            LogHelper.InsertLog("MedRepCT_Show.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("MedRepCT_Show.Error: " & ex.Message)
        End Try
        
    End Sub

    Private Sub pmrSub_Delete()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim Rowid As New SqlParameter("@Rowid", SqlDbType.Int)
            Rowid.Direction = ParameterDirection.Input
            Rowid.Value = Trim(pmrRowid.Text)
            Params(0) = Rowid
            BusinessObject.Sub_Delete(ServerPath2, "MedRepCT_Delete", CommandType.StoredProcedure, Params)

            LogHelper.InsertLog("MedRepCT_Delete.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("MedRepCT_Delete.Error: " & ex.Message)
        End Try

    End Sub

    Private Sub pmrSub_Select(ByVal dbParams() As String, ByVal UpdateMode As String)
        'select case if add,edit or delete
        Dim i As Integer
        Dim myRowid As Integer
        Select Case UpdateMode
            Case "Insert"
                Dim BusinessObject As New BusinessLayer.clsFileMaintenance
                myRowid = CInt(BusinessObject.Sub_ReturnIntegerResult(ServerPath2, "MedRepCT_GetInsertedRowid", CommandType.StoredProcedure))
            Case "Update"
                myRowid = CInt(dbParams(0))
        End Select
        For i = 0 To (RemoteDataSet.MedRepCT_Show.Rows.Count - 1)
            With DataGrid2
                If myRowid = CInt(.Item(i, 0)) Then
                    .CurrentCell = New DataGridCell(i, 0)
                    'Dim e As System.EventArgs
                    'DataGrid1_Click(Me, e)
                    Exit For
                End If
            End With
        Next
    End Sub

    Private Sub DSM_Show()
        Try

            If RemoteDataSet2.SupMR_Show5.Count > 0 Then RemoteDataSet2.SupMR_Show5.Clear()
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim PMRcode As New SqlParameter("@MrCode", SqlDbType.Char, 10)
            PMRcode.Direction = ParameterDirection.Input
            PMRcode.Value = Trim(DataGrid2.Item(DataGrid2.CurrentCell.RowNumber, 1).ToString)
            Params(0) = PMRcode
            BusinessObject.Sub_Show(ServerPath2, "SupMR_Show5", CommandType.StoredProcedure, _
                                    RemoteDataSet2, "SupMR_Show5", Params)
            DataGrid1.DataSource = RemoteDataSet2.SupMR_Show5
            'Hide the column with empty header
            Dim dgts As New DataGridTableStyle
            dgts.MappingName = DataGrid1.DataMember
            DataGrid1.TableStyles.Add(dgts)
            DataGrid1.TableStyles(0).GridColumnStyles("RowNumber").Width = 0

            LogHelper.InsertLog("SupMR_Show5.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("SupMR_Show5.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub dsmSub_Delete()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim Rowid As New SqlParameter("@Rownumber", SqlDbType.Int)
            Rowid.Direction = ParameterDirection.Input
            Rowid.Value = Trim(dsmRowid.Text)
            Params(0) = Rowid
            BusinessObject.Sub_Delete(ServerPath2, "SupMr_Delete", CommandType.StoredProcedure, Params)

            LogHelper.InsertLog("SupMr_Delete.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("SupMr_Delete.Error: " & ex.Message)
        End Try

    End Sub

    Private Sub dsmSub_Select(ByVal dbParams() As String, ByVal UpdateMode As String)
        'select case if add,edit or delete
        Dim i As Integer
        Dim myRowid As Integer
        Select Case UpdateMode
            Case "Insert"
                Dim BusinessObject As New BusinessLayer.clsFileMaintenance
                myRowid = CInt(BusinessObject.Sub_ReturnIntegerResult(ServerPath2, "SupMr_GetInsertedRowid", CommandType.StoredProcedure))
            Case "Update"
                myRowid = CInt(dbParams(0))
        End Select
        For i = 0 To (RemoteDataSet2.SupMR_Show5.Rows.Count - 1)
            With DataGrid1
                If myRowid = CInt(.Item(i, 4)) Then
                    .CurrentCell = New DataGridCell(i, 4)
                    'Dim e As System.EventArgs
                    'DataGrid1_Click(Me, e)
                    Exit For
                End If
            End With
        Next
    End Sub

    Private Sub SupMr_Load(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles MyBase.Load
        Try


            DSM_Show()
            dsmRowid.Text = Trim(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 4).ToString)
            pmrRowid.Text = Trim(DataGrid2.Item(DataGrid2.CurrentCell.RowNumber, 0).ToString)
            LogHelper.InsertLog("SupMr_Load.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("SupMr_Load.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnExit.Click

        Close()
    End Sub

    Private Sub btnPMR_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnPMR_Add.Click

        Dim popupFrm As New MedRepCT
        PMR_EditMode = False
        cancelProcess = False
        popupFrm.ShowDialog(Me)
        If cancelProcess = False Then
            Dim Params(0) As String
            Params(0) = ""
            DataGrid2.DataSource = Nothing
            PMR_Show()
            pmrSub_Select(Params, CStr(IIf(PMR_EditMode = False, "Insert", "Update")))
            DSM_Show()
            pmrRowid.Text = Trim(DataGrid2.Item(DataGrid2.CurrentCell.RowNumber, 0).ToString)
        End If
    End Sub

    Private Sub btnPMR_Edit_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles btnPMR_Edit.Click

        Dim popupFrm As New MedRepCT
        With DataGrid2
            Fld0 = Trim(.Item(.CurrentCell.RowNumber, 0).ToString)
            Fld1 = Trim(.Item(.CurrentCell.RowNumber, 1).ToString)
            Fld2 = Trim(.Item(.CurrentCell.RowNumber, 2).ToString)
            Fld3 = Trim(.Item(.CurrentCell.RowNumber, 3).ToString)
            Fld4 = Trim(.Item(.CurrentCell.RowNumber, 4).ToString)
            Fld5 = Trim(.Item(.CurrentCell.RowNumber, 5).ToString)
            Fld6 = Trim(.Item(.CurrentCell.RowNumber, 6).ToString)
            Fld7 = Trim(.Item(.CurrentCell.RowNumber, 7).ToString)
            Fld8 = Trim(.Item(.CurrentCell.RowNumber, 8).ToString)
            Fld9 = Trim(.Item(.CurrentCell.RowNumber, 9).ToString)
            Fld10 = Trim(.Item(.CurrentCell.RowNumber, 10).ToString)
            Fld11 = Trim(.Item(.CurrentCell.RowNumber, 11).ToString)
            Fld12 = Trim(.Item(.CurrentCell.RowNumber, 12).ToString)
            Fld13 = Trim(.Item(.CurrentCell.RowNumber, 13).ToString)
            Fld14 = Trim(.Item(.CurrentCell.RowNumber, 14).ToString)
            Fld15 = Trim(.Item(.CurrentCell.RowNumber, 15).ToString)
            Fld18 = Trim(.Item(.CurrentCell.RowNumber, 16).ToString)
            Fld19 = Trim(.Item(.CurrentCell.RowNumber, 17).ToString)
            Fld20 = Trim(.Item(.CurrentCell.RowNumber, 18).ToString)
            TBMPicturePath = Trim(.Item(.CurrentCell.RowNumber, 19).ToString)
        End With
        PMR_EditMode = True
        cancelProcess = False
        popupFrm.ShowDialog(Me)
        If cancelProcess = False Then
            Dim Params(0) As String
            Params(0) = Fld0
            DataGrid2.DataSource = Nothing
            PMR_Show()
            pmrSub_Select(Params, CStr(IIf(PMR_EditMode = False, "Insert", "Update")))
            DSM_Show()
        End If
    End Sub

    Private Sub btnPMR_Delete_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles btnPMR_Delete.Click


        tmpPMRx = Trim(DataGrid2.Item(DataGrid2.CurrentCell.RowNumber, 2).ToString)
        If pmrRowid.Text > "" Then
            If (MessageBox.Show("Do you really want to remove " & UCase(tmpPMRx) & " from the DataBase?", _
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information, _
                MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then

                pmrSub_Delete()
                'ControlMaintenance.ClearInputControls(Me)
                DataGrid2.DataSource = Nothing
                PMR_Show()
            End If
        End If
    End Sub

    Private Sub DataGrid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles DataGrid1.Click

        dsmRowid.Text = Trim(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 4).ToString)
    End Sub

    Private Sub DataGrid2_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles DataGrid2.Click

        pmrRowid.Text = Trim(DataGrid2.Item(DataGrid2.CurrentCell.RowNumber, 0).ToString)
        DSM_Show()
        If RemoteDataSet2.SupMR_Show5.Count > 0 Then
            dsmRowid.Text = Trim(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 4).ToString)
        End If

    End Sub

    Private Sub btnDSM_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnDSM_Add.Click

        Dim popupFrm As New frmSupMr
        DSM_EditMode = False
        cancelProcess = False
        Fld2 = Trim(DataGrid2.Item(DataGrid2.CurrentCell.RowNumber, 1).ToString)
        Fld3 = Trim(DataGrid2.Item(DataGrid2.CurrentCell.RowNumber, 2).ToString)
        popupFrm.ShowDialog(Me)
        If cancelProcess = False Then
            Dim Params(0) As String
            Params(0) = ""
            DataGrid1.DataSource = Nothing
            DSM_Show()
            dsmSub_Select(Params, CStr(IIf(DSM_EditMode = False, "Insert", "Update")))
            dsmRowid.Text = Trim(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 4).ToString)
        End If
    End Sub

    Private Sub btnDSM_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnDSM_Edit.Click

        Dim popupFrm As New frmSupMr
        With DataGrid1
            Fld0 = Trim(.Item(.CurrentCell.RowNumber, 0).ToString)
            Fld1 = Trim(.Item(.CurrentCell.RowNumber, 1).ToString)
            Fld2 = Trim(DataGrid2.Item(DataGrid2.CurrentCell.RowNumber, 1).ToString)
            Fld3 = Trim(DataGrid2.Item(DataGrid2.CurrentCell.RowNumber, 2).ToString)
            Fld4 = Trim(.Item(.CurrentCell.RowNumber, 2).ToString)
            Fld5 = Trim(.Item(.CurrentCell.RowNumber, 3).ToString)
            Fld6 = Trim(.Item(.CurrentCell.RowNumber, 4).ToString)
            Fld7 = Trim(.Item(.CurrentCell.RowNumber, 5).ToString)
            Fld8 = Trim(.Item(.CurrentCell.RowNumber, 6).ToString)
            Fld9 = Trim(.Item(.CurrentCell.RowNumber, 7).ToString)
            Fld10 = Trim(.Item(.CurrentCell.RowNumber, 8).ToString)
            Fld11 = Trim(.Item(.CurrentCell.RowNumber, 9).ToString)
        End With
        DSM_EditMode = True
        cancelProcess = False
        popupFrm.ShowDialog(Me)
        If cancelProcess = False Then
            Dim Params(0) As String
            Params(0) = Fld6
            DataGrid1.DataSource = Nothing
            DSM_Show()
            dsmSub_Select(Params, CStr(IIf(DSM_EditMode = False, "Insert", "Update")))
        End If
    End Sub

    Private Sub btnDSM_Delete_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles btnDSM_Delete.Click

        tmpDSMx = Trim(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 1).ToString)
        If dsmRowid.Text > "" Then
            If (MessageBox.Show("Do you really want to delete " & tmpDSMx & "?", _
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information, _
                MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then

                dsmSub_Delete()
                'ControlMaintenance.ClearInputControls(Me)
                DataGrid1.DataSource = Nothing
                DSM_Show()
            End If
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
