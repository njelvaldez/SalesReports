Imports System.Data.SqlClient

Public Class QpiAreaAssign
    Inherits System.Windows.Forms.Form
    Private RemoteDataSet2 As New MyDataSetDB
    Private EditMode As Boolean = False
    Private oldDs As String, tmpSD As String, tmpED As String   '<-- added-DBrion

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Load_PrincipalLst()
        Load_QAreaCode()
        Sub_Show()
        Load_MRcombo()
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
    Friend WithEvents lblCreateDate As System.Windows.Forms.Label
    Friend WithEvents lblUpdateDate As System.Windows.Forms.Label
    Friend WithEvents txtRowid As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDescription1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtStartDate As System.Windows.Forms.TextBox
    Friend WithEvents TxtEndDate As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DataGrid2 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGrid3 As System.Windows.Forms.DataGrid
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DGTabStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents PrincipalC As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DGridTabStyl As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents Area_Code As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents MedRepresentative As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents StartDate As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents EndDate As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents cboMedRep As System.Windows.Forms.ComboBox
    Friend WithEvents TxtAreaCode As System.Windows.Forms.TextBox
    Friend WithEvents TxtPrinCode As System.Windows.Forms.TextBox
    Friend WithEvents TxtUserID As System.Windows.Forms.TextBox
    Friend WithEvents rowidmr As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents principalmr As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents areacodemr As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents mrcodemr As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents createdatemr As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents updatedatemr As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents useridmr As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
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
        Me.rowidmr = New System.Windows.Forms.DataGridTextBoxColumn
        Me.principalmr = New System.Windows.Forms.DataGridTextBoxColumn
        Me.areacodemr = New System.Windows.Forms.DataGridTextBoxColumn
        Me.mrcodemr = New System.Windows.Forms.DataGridTextBoxColumn
        Me.MedRepresentative = New System.Windows.Forms.DataGridTextBoxColumn
        Me.StartDate = New System.Windows.Forms.DataGridTextBoxColumn
        Me.EndDate = New System.Windows.Forms.DataGridTextBoxColumn
        Me.createdatemr = New System.Windows.Forms.DataGridTextBoxColumn
        Me.updatedatemr = New System.Windows.Forms.DataGridTextBoxColumn
        Me.useridmr = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGrid3 = New System.Windows.Forms.DataGrid
        Me.DGridTabStyl = New System.Windows.Forms.DataGridTableStyle
        Me.Area_Code = New System.Windows.Forms.DataGridTextBoxColumn
        Me.txtRowid = New System.Windows.Forms.TextBox
        Me.txtDescription1 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtAreaCode = New System.Windows.Forms.TextBox
        Me.TxtStartDate = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtEndDate = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtPrinCode = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxtUserID = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.DataGrid2 = New System.Windows.Forms.DataGrid
        Me.DGTabStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.PrincipalC = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Label13 = New System.Windows.Forms.Label
        Me.cboMedRep = New System.Windows.Forms.ComboBox
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 576)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MedRep"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(435, 500)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Create Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(435, 526)
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
        Me.lblCreateDate.Location = New System.Drawing.Point(505, 501)
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
        Me.lblUpdateDate.Location = New System.Drawing.Point(505, 526)
        Me.lblUpdateDate.Name = "lblUpdateDate"
        Me.lblUpdateDate.Size = New System.Drawing.Size(112, 21)
        Me.lblUpdateDate.TabIndex = 7
        Me.lblUpdateDate.Tag = "Input"
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(349, 619)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.TabIndex = 6
        Me.cmdExit.Tag = "Exit"
        Me.cmdExit.Text = "Exit"
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(109, 619)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.TabIndex = 3
        Me.cmdAdd.Tag = "Add"
        Me.cmdAdd.Text = "Add"
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(189, 619)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.TabIndex = 4
        Me.cmdEdit.Tag = "Edit"
        Me.cmdEdit.Text = "Edit"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(189, 619)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.TabIndex = 7
        Me.cmdCancel.Tag = "Cancel"
        Me.cmdCancel.Text = "Cancel"
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(269, 619)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.TabIndex = 5
        Me.cmdDelete.Tag = "Delete"
        Me.cmdDelete.Text = "Delete"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(269, 619)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.TabIndex = 8
        Me.cmdSave.Tag = "Save"
        Me.cmdSave.Text = "Save"
        '
        'DataGrid1
        '
        Me.DataGrid1.CaptionText = "MedRep List"
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(7, 230)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(612, 264)
        Me.DataGrid1.TabIndex = 0
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.DataGrid1.Tag = "View"
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Aqua
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightCyan
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.rowidmr, Me.principalmr, Me.areacodemr, Me.mrcodemr, Me.MedRepresentative, Me.StartDate, Me.EndDate, Me.createdatemr, Me.updatedatemr, Me.useridmr})
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.AntiqueWhite
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "QAreaAssign_Show"
        '
        'rowidmr
        '
        Me.rowidmr.Format = ""
        Me.rowidmr.FormatInfo = Nothing
        Me.rowidmr.MappingName = "rowid"
        Me.rowidmr.NullText = ""
        Me.rowidmr.Width = 0
        '
        'principalmr
        '
        Me.principalmr.Format = ""
        Me.principalmr.FormatInfo = Nothing
        Me.principalmr.MappingName = "princode"
        Me.principalmr.NullText = ""
        Me.principalmr.Width = 0
        '
        'areacodemr
        '
        Me.areacodemr.Format = ""
        Me.areacodemr.FormatInfo = Nothing
        Me.areacodemr.MappingName = "areacode"
        Me.areacodemr.NullText = ""
        Me.areacodemr.Width = 0
        '
        'mrcodemr
        '
        Me.mrcodemr.Format = ""
        Me.mrcodemr.FormatInfo = Nothing
        Me.mrcodemr.MappingName = "mrcode"
        Me.mrcodemr.NullText = ""
        Me.mrcodemr.Width = 0
        '
        'MedRepresentative
        '
        Me.MedRepresentative.Format = ""
        Me.MedRepresentative.FormatInfo = Nothing
        Me.MedRepresentative.HeaderText = "Medical Representative"
        Me.MedRepresentative.MappingName = "MedRepresentative"
        Me.MedRepresentative.NullText = ""
        Me.MedRepresentative.Width = 230
        '
        'StartDate
        '
        Me.StartDate.Format = "MM/dd/yyyy"
        Me.StartDate.FormatInfo = Nothing
        Me.StartDate.HeaderText = "Start Date"
        Me.StartDate.MappingName = "Start_Date"
        Me.StartDate.NullText = ""
        Me.StartDate.Width = 75
        '
        'EndDate
        '
        Me.EndDate.Format = "MM/dd/yyyy"
        Me.EndDate.FormatInfo = Nothing
        Me.EndDate.HeaderText = "End Date"
        Me.EndDate.MappingName = "End_Date"
        Me.EndDate.NullText = ""
        Me.EndDate.Width = 75
        '
        'createdatemr
        '
        Me.createdatemr.Format = ""
        Me.createdatemr.FormatInfo = Nothing
        Me.createdatemr.MappingName = "createdate"
        Me.createdatemr.NullText = ""
        Me.createdatemr.Width = 0
        '
        'updatedatemr
        '
        Me.updatedatemr.Format = ""
        Me.updatedatemr.FormatInfo = Nothing
        Me.updatedatemr.MappingName = "updatedate"
        Me.updatedatemr.NullText = ""
        Me.updatedatemr.Width = 0
        '
        'useridmr
        '
        Me.useridmr.Format = ""
        Me.useridmr.FormatInfo = Nothing
        Me.useridmr.MappingName = "userid"
        Me.useridmr.NullText = ""
        Me.useridmr.Width = 0
        '
        'DataGrid3
        '
        Me.DataGrid3.CaptionText = "Area Code List"
        Me.DataGrid3.DataMember = ""
        Me.DataGrid3.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid3.Location = New System.Drawing.Point(315, 19)
        Me.DataGrid3.Name = "DataGrid3"
        Me.DataGrid3.ParentRowsVisible = False
        Me.DataGrid3.Size = New System.Drawing.Size(304, 208)
        Me.DataGrid3.TabIndex = 63
        Me.DataGrid3.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DGridTabStyl})
        Me.DataGrid3.Tag = "View"
        '
        'DGridTabStyl
        '
        Me.DGridTabStyl.AlternatingBackColor = System.Drawing.Color.Aqua
        Me.DGridTabStyl.BackColor = System.Drawing.Color.LightCyan
        Me.DGridTabStyl.DataGrid = Me.DataGrid3
        Me.DGridTabStyl.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.Area_Code})
        Me.DGridTabStyl.HeaderBackColor = System.Drawing.Color.AntiqueWhite
        Me.DGridTabStyl.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DGridTabStyl.MappingName = "QAreaAssignA_Show"
        '
        'Area_Code
        '
        Me.Area_Code.Format = ""
        Me.Area_Code.FormatInfo = Nothing
        Me.Area_Code.HeaderText = "QPI Area Code"
        Me.Area_Code.MappingName = "qareacode"
        Me.Area_Code.NullText = ""
        Me.Area_Code.Width = 230
        '
        'txtRowid
        '
        Me.txtRowid.Location = New System.Drawing.Point(339, 554)
        Me.txtRowid.Name = "txtRowid"
        Me.txtRowid.Size = New System.Drawing.Size(13, 20)
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
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 526)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 21)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "QPI Area Code"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtAreaCode
        '
        Me.TxtAreaCode.BackColor = System.Drawing.SystemColors.Info
        Me.TxtAreaCode.Location = New System.Drawing.Point(113, 526)
        Me.TxtAreaCode.MaxLength = 20
        Me.TxtAreaCode.Name = "TxtAreaCode"
        Me.TxtAreaCode.ReadOnly = True
        Me.TxtAreaCode.Size = New System.Drawing.Size(311, 20)
        Me.TxtAreaCode.TabIndex = 5
        Me.TxtAreaCode.Tag = "Input"
        Me.TxtAreaCode.Text = ""
        '
        'TxtStartDate
        '
        Me.TxtStartDate.Location = New System.Drawing.Point(505, 552)
        Me.TxtStartDate.MaxLength = 10
        Me.TxtStartDate.Name = "TxtStartDate"
        Me.TxtStartDate.Size = New System.Drawing.Size(112, 20)
        Me.TxtStartDate.TabIndex = 1
        Me.TxtStartDate.Tag = "Input"
        Me.TxtStartDate.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(435, 552)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 20)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Start Date"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtEndDate
        '
        Me.TxtEndDate.Location = New System.Drawing.Point(505, 578)
        Me.TxtEndDate.MaxLength = 10
        Me.TxtEndDate.Name = "TxtEndDate"
        Me.TxtEndDate.Size = New System.Drawing.Size(112, 20)
        Me.TxtEndDate.TabIndex = 2
        Me.TxtEndDate.Tag = "Input"
        Me.TxtEndDate.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(435, 576)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 20)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "End Date"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtPrinCode
        '
        Me.TxtPrinCode.BackColor = System.Drawing.SystemColors.Info
        Me.TxtPrinCode.Location = New System.Drawing.Point(113, 501)
        Me.TxtPrinCode.MaxLength = 30
        Me.TxtPrinCode.Name = "TxtPrinCode"
        Me.TxtPrinCode.ReadOnly = True
        Me.TxtPrinCode.Size = New System.Drawing.Size(311, 20)
        Me.TxtPrinCode.TabIndex = 4
        Me.TxtPrinCode.Tag = "Input"
        Me.TxtPrinCode.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(12, 500)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 21)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Principal"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtUserID
        '
        Me.TxtUserID.Location = New System.Drawing.Point(357, 554)
        Me.TxtUserID.MaxLength = 10
        Me.TxtUserID.Name = "TxtUserID"
        Me.TxtUserID.Size = New System.Drawing.Size(64, 20)
        Me.TxtUserID.TabIndex = 57
        Me.TxtUserID.Tag = "Input"
        Me.TxtUserID.Text = ""
        Me.TxtUserID.Visible = False
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Location = New System.Drawing.Point(7, 610)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(612, 2)
        Me.Label10.TabIndex = 59
        '
        'Label11
        '
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(439, 616)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(192, 14)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "Easy Date Format Entry: ""MMDDYY"""
        '
        'Label12
        '
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(439, 631)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(184, 14)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "ex.  ""112595"" = ""Nov.25,1995"""
        '
        'DataGrid2
        '
        Me.DataGrid2.CaptionText = "Principal List"
        Me.DataGrid2.DataMember = ""
        Me.DataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid2.Location = New System.Drawing.Point(8, 19)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.Size = New System.Drawing.Size(304, 208)
        Me.DataGrid2.TabIndex = 62
        Me.DataGrid2.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DGTabStyle2})
        Me.DataGrid2.Tag = "View"
        '
        'DGTabStyle2
        '
        Me.DGTabStyle2.AlternatingBackColor = System.Drawing.Color.Aqua
        Me.DGTabStyle2.BackColor = System.Drawing.Color.LightCyan
        Me.DGTabStyle2.DataGrid = Me.DataGrid2
        Me.DGTabStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.PrincipalC})
        Me.DGTabStyle2.HeaderBackColor = System.Drawing.Color.AntiqueWhite
        Me.DGTabStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DGTabStyle2.MappingName = "QAreaAssignP_Show"
        '
        'PrincipalC
        '
        Me.PrincipalC.Format = ""
        Me.PrincipalC.FormatInfo = Nothing
        Me.PrincipalC.HeaderText = "Principal"
        Me.PrincipalC.MappingName = "principallist"
        Me.PrincipalC.NullText = ""
        Me.PrincipalC.Width = 230
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(8, 2)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(605, 13)
        Me.Label13.TabIndex = 64
        Me.Label13.Text = "Select a Principal and an AreaCode before clicking Add. Plus MedRep before clicki" & _
        "ng Edit."
        '
        'cboMedRep
        '
        Me.cboMedRep.Location = New System.Drawing.Point(113, 578)
        Me.cboMedRep.MaxLength = 55
        Me.cboMedRep.Name = "cboMedRep"
        Me.cboMedRep.Size = New System.Drawing.Size(311, 21)
        Me.cboMedRep.TabIndex = 0
        Me.cboMedRep.Tag = "Input"
        '
        'QpiAreaAssign
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(624, 647)
        Me.Controls.Add(Me.cboMedRep)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtUserID)
        Me.Controls.Add(Me.TxtPrinCode)
        Me.Controls.Add(Me.TxtEndDate)
        Me.Controls.Add(Me.TxtStartDate)
        Me.Controls.Add(Me.TxtAreaCode)
        Me.Controls.Add(Me.txtRowid)
        Me.Controls.Add(Me.DataGrid3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
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
        Me.Controls.Add(Me.DataGrid2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "QpiAreaAssign"
        Me.Text = " QPI Area Assignment"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        modControlBehavior.EnableControls(Me, True)
        ControlMaintenance.ClearInputControls(Me)
        EditMode = False
        'added-DBrion --v
        btnSw = True
        TxtPrinCode.Text = DataGrid2.Item(DataGrid2.CurrentCell.RowNumber, 0).ToString
        TxtAreaCode.Text = DataGrid3.Item(DataGrid3.CurrentCell.RowNumber, 0).ToString
        lblCreateDate.Text = GetDateTimeNow("MM/dd/yyyy")
        lblUpdateDate.Text = GetDateTimeNow("MM/dd/yyyy")
        TxtStartDate.Text = GetDateTimeNow("MM") & "/01/" & GetDateTimeNow("yyyy")
        tmpSD = Format(CDate(TxtStartDate.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
        TxtEndDate.Text = "12/31/2078"
        tmpED = Format(CDate(TxtEndDate.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
        cboMedRep.Enabled = True
        cboMedRep.Select()
        'added-DBrion --^
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If Trim(cboMedRep.Text) = "" Then
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
            cboMedRep.Select()
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
        'txtCode.Enabled = True
        'txtCode.BackColor = Color.White
        'txtCode.ForeColor = Color.Black
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
        Dim Params(7) As SqlParameter

        Dim PrinCode As New SqlParameter("@PrinCode", SqlDbType.VarChar, 5)
        PrinCode.Direction = ParameterDirection.Input
        PrinCode.Value = GetCode(TxtPrinCode.Text)
        Params(0) = PrinCode

        Dim AreaCode As New SqlParameter("@AreaCode", SqlDbType.VarChar, 3)
        AreaCode.Direction = ParameterDirection.Input
        AreaCode.Value = GetCode(TxtAreaCode.Text)
        Params(1) = AreaCode

        Dim MrCode As New SqlParameter("@MrCode", SqlDbType.VarChar, 5)
        MrCode.Direction = ParameterDirection.Input
        MrCode.Value = GetCode(cboMedRep.Text)
        Params(2) = MrCode

        tmpSD = Format(CDate(TxtStartDate.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
        Dim StartDate As New SqlParameter("@Start_Date", SqlDbType.DateTime, 10)
        StartDate.Direction = ParameterDirection.Input
        StartDate.Value = tmpSD
        Params(3) = StartDate

        tmpED = Format(CDate(TxtEndDate.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
        Dim EndDate As New SqlParameter("@End_Date", SqlDbType.DateTime, 10)
        EndDate.Direction = ParameterDirection.Input
        EndDate.Value = tmpED
        Params(4) = EndDate

        Dim CreateDate As New SqlParameter("@CreateDate", SqlDbType.DateTime, 10)
        CreateDate.Direction = ParameterDirection.Input
        CreateDate.Value = GetDateTimeNow()
        Params(5) = CreateDate

        Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime, 10)
        UpdateDate.Direction = ParameterDirection.Input
        UpdateDate.Value = GetDateTimeNow()
        Params(6) = UpdateDate

        Dim UserID As New SqlParameter("@UserID", SqlDbType.VarChar, 10)
        UserID.Direction = ParameterDirection.Input
        UserID.Value = Trim(TxtUserID.Text)
        Params(7) = UserID

        Try
            BusinessObject.Sub_Insert(ServerPath2, "QAreaAssign_Insert", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Sub_Update()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(7) As SqlParameter
        Dim PrinCode As New SqlParameter("@PrinCode", SqlDbType.VarChar, 5)
        PrinCode.Direction = ParameterDirection.Input
        PrinCode.Value = GetCode(TxtPrinCode.Text)
        Params(0) = PrinCode

        Dim AreaCode As New SqlParameter("@AreaCode", SqlDbType.VarChar, 3)
        AreaCode.Direction = ParameterDirection.Input
        AreaCode.Value = GetCode(TxtAreaCode.Text)
        Params(1) = AreaCode

        Dim MrCode As New SqlParameter("@MrCode", SqlDbType.VarChar, 5)
        MrCode.Direction = ParameterDirection.Input
        MrCode.Value = GetCode(cboMedRep.Text)
        Params(2) = MrCode

        tmpSD = Format(CDate(TxtStartDate.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
        Dim StartDate As New SqlParameter("@Start_Date", SqlDbType.DateTime, 10)
        StartDate.Direction = ParameterDirection.Input
        StartDate.Value = tmpSD
        Params(3) = StartDate

        tmpED = Format(CDate(TxtEndDate.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
        Dim EndDate As New SqlParameter("@End_Date", SqlDbType.DateTime, 10)
        EndDate.Direction = ParameterDirection.Input
        EndDate.Value = tmpED
        Params(4) = EndDate

        Dim Rowid As New SqlParameter("@Rowid", SqlDbType.Int)
        Rowid.Direction = ParameterDirection.Input
        Rowid.Value = Trim(txtRowid.Text)
        Params(5) = Rowid

        Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime, 10)
        UpdateDate.Direction = ParameterDirection.Input
        UpdateDate.Value = GetDateTimeNow()
        Params(6) = UpdateDate

        Dim UserID As New SqlParameter("@UserID", SqlDbType.VarChar, 10)
        UserID.Direction = ParameterDirection.Input
        UserID.Value = Trim(TxtUserID.Text)
        Params(7) = UserID

        Try
            BusinessObject.Sub_Update(ServerPath2, "QAreaAssign_Update", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Sub_Show()
        If RemoteDataSet2.QAreaAssign_Show.Count > 0 Then RemoteDataSet2.QAreaAssign_Show.Clear()
        Dim Params(0) As SqlParameter
        Dim WerClause As New SqlParameter("@where", SqlDbType.NVarChar, 1000)
        WerClause.Direction = ParameterDirection.Input
        z = " princode = '" & GetCode(DataGrid2.Item(DataGrid2.CurrentCell.RowNumber, 0).ToString) & "' "
        z = z & " and areacode = '" & GetCode(DataGrid3.Item(DataGrid3.CurrentCell.RowNumber, 0).ToString) & "' "
        WerClause.Value = z
        Params(0) = WerClause
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "QAreaAssign_Show", CommandType.StoredProcedure, RemoteDataSet2, "QAreaAssign_Show", Params)
        DataGrid1.DataSource = RemoteDataSet2.QAreaAssign_Show
    End Sub

    Private Sub Load_PrincipalLst()
        If RemoteDataSet2.QAreaAssignP_Show.Count > 0 Then RemoteDataSet2.QAreaAssignP_Show.Clear()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "QAreaAssignP_Show", CommandType.StoredProcedure, RemoteDataSet2, "QAreaAssignP_Show")
        DataGrid2.DataSource = RemoteDataSet2.QAreaAssignP_Show
    End Sub

    Private Sub Load_QAreaCode()
        If RemoteDataSet2.QAreaAssignA_Show.Count > 0 Then RemoteDataSet2.QAreaAssignA_Show.Clear()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "QAreaAssignA_Show", CommandType.StoredProcedure, RemoteDataSet2, "QAreaAssignA_Show")
        DataGrid3.DataSource = RemoteDataSet2.QAreaAssignA_Show
    End Sub

    Private Sub Load_MRcombo()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "MRcombo", CommandType.StoredProcedure, RemoteDataSet2, "MRcombo")
        cboMedRep.DataSource = RemoteDataSet2.MRcombo
        cboMedRep.DisplayMember = "MedRepA"
    End Sub

    Private Sub Sub_Select(ByVal dbParams() As String, ByVal UpdateMode As String)
        'select case if add,edit or delete
        Dim i As Integer
        Dim myRowid As Integer
        Select Case UpdateMode
            Case "Insert"
                Dim BusinessObject As New BusinessLayer.clsFileMaintenance
                myRowid = CInt(BusinessObject.Sub_ReturnIntegerResult(ServerPath2, "PrincipalCT_GetInsertedRowid", CommandType.StoredProcedure))
            Case "Update"
                myRowid = CInt(dbParams(0))
        End Select
        For i = 0 To (RemoteDataSet2.QAreaAssign_Show.Rows.Count - 1)
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
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter
        Dim Rowid As New SqlParameter("@Rowid", SqlDbType.Int)
        Rowid.Direction = ParameterDirection.Input
        Rowid.Value = Trim(txtRowid.Text)
        Params(0) = Rowid
        Try
            BusinessObject.Sub_Delete(ServerPath2, "QAreaAssign_Delete", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub QpiAreaAssign_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        modControlBehavior.EnableControls(Me, False)
        btnSw = False    '<-- added-DBrion
        tmpSD = ""
        tmpED = ""
    End Sub

    Private Sub DataGrid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.Click, DataGrid1.CurrentCellChanged
        FldsPopulate()
    End Sub

    Private Sub DataGrid2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid2.Click
        Sub_Show()
        FldsPopulate()
    End Sub

    Private Sub DataGrid3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid3.Click
        Sub_Show()
        FldsPopulate()
    End Sub

    Private Sub FldsPopulate()
        With DataGrid1
            If RemoteDataSet2.QAreaAssign_Show.Count > 0 Then
                txtRowid.Text = .Item(.CurrentCell.RowNumber, 0).ToString
                TxtPrinCode.Text = DataGrid2.Item(DataGrid2.CurrentCell.RowNumber, 0).ToString
                TxtAreaCode.Text = DataGrid3.Item(DataGrid3.CurrentCell.RowNumber, 0).ToString
                cboMedRep.Text = .Item(.CurrentCell.RowNumber, 4).ToString
                If Trim(.Item(.CurrentCell.RowNumber, 5).ToString) <> "" Then
                    TxtStartDate.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 5).ToString), "MM/dd/yyyy")
                Else
                    TxtStartDate.Text = ""
                End If
                If Trim(.Item(.CurrentCell.RowNumber, 6).ToString) <> "" Then
                    TxtEndDate.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 6).ToString), "MM/dd/yyyy")
                Else
                    TxtEndDate.Text = ""
                End If
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
                TxtUserID.Text = .Item(.CurrentCell.RowNumber, 9).ToString
                .Select(.CurrentRowIndex)    'CurrentCell.RowNumber)
            End If
        End With
    End Sub

    Private Sub cboMedRep_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboMedRep.KeyUp
        If e.KeyData.ToString = System.Windows.Forms.Keys.Up.ToString _
           Or e.KeyData.ToString = System.Windows.Forms.Keys.Left.ToString Then 'if key pressed is the up arrow it will select the next selection before the selction
            cboMedRep.SelectedItem = cboMedRep.SelectedIndex - 1
        ElseIf e.KeyData.ToString = System.Windows.Forms.Keys.Down.ToString _
           Or e.KeyData.ToString = System.Windows.Forms.Keys.Right.ToString Then 'if key pressed is the up arrow it will select the next selection after the selction
            cboMedRep.SelectedItem = cboMedRep.SelectedIndex + 1
        ElseIf DKcodes(e.KeyData) = True Then    'checking if the key pressed is alphanumeric (to disallow typing the entry)
            cboMedRep.Text = ""     'if alphanumeric then the value of the field will be erased
        End If
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")      'moves control to the next control or field
        End If
    End Sub

    Private Sub cboMedRep_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboMedRep.Validating
        If Trim(cboMedRep.Text) = "" Then    'tests if entry is blank
            MessageBox.Show("Mandatory field!", "Critical!")  'gives message to put value
            e.Cancel() = True                  ' brings back the focus on this control/field
        End If
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
End Class