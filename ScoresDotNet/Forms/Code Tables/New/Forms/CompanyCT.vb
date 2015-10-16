Imports System.Data.SqlClient
Public Class CompanyCT
    Inherits System.Windows.Forms.Form
    Private RemoteDataSet As New MyDataSetDB
    Private EditMode As Boolean = False

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
    Friend WithEvents Label2 As System.Windows.Forms.Label
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
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents lblCreateDate As System.Windows.Forms.Label
    Friend WithEvents lblUpdateDate As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents vRowid As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CompanyCT))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.vCode = New System.Windows.Forms.TextBox
        Me.vCompanyName = New System.Windows.Forms.TextBox
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
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.vLastUser = New System.Windows.Forms.TextBox
        Me.vCompany = New System.Windows.Forms.TextBox
        Me.vAddress1 = New System.Windows.Forms.TextBox
        Me.vAddress2 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.vRowid = New System.Windows.Forms.TextBox
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 445)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Code"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(313, 445)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Company Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(762, 445)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Create Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(766, 469)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Update Date"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'vCode
        '
        Me.vCode.BackColor = System.Drawing.SystemColors.Window
        Me.vCode.Location = New System.Drawing.Point(57, 445)
        Me.vCode.MaxLength = 2
        Me.vCode.Name = "vCode"
        Me.vCode.Size = New System.Drawing.Size(36, 20)
        Me.vCode.TabIndex = 0
        Me.vCode.Tag = "Input"
        Me.vCode.Text = ""
        '
        'vCompanyName
        '
        Me.vCompanyName.Location = New System.Drawing.Point(402, 443)
        Me.vCompanyName.Name = "vCompanyName"
        Me.vCompanyName.Size = New System.Drawing.Size(248, 20)
        Me.vCompanyName.TabIndex = 2
        Me.vCompanyName.Tag = "Input"
        Me.vCompanyName.Text = ""
        '
        'lblCreateDate
        '
        Me.lblCreateDate.BackColor = System.Drawing.SystemColors.Info
        Me.lblCreateDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCreateDate.Location = New System.Drawing.Point(836, 445)
        Me.lblCreateDate.Name = "lblCreateDate"
        Me.lblCreateDate.Size = New System.Drawing.Size(74, 20)
        Me.lblCreateDate.TabIndex = 6
        Me.lblCreateDate.Tag = "Input"
        '
        'lblUpdateDate
        '
        Me.lblUpdateDate.BackColor = System.Drawing.SystemColors.Info
        Me.lblUpdateDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUpdateDate.Location = New System.Drawing.Point(836, 469)
        Me.lblUpdateDate.Name = "lblUpdateDate"
        Me.lblUpdateDate.Size = New System.Drawing.Size(74, 20)
        Me.lblUpdateDate.TabIndex = 7
        Me.lblUpdateDate.Tag = "Input"
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(298, 496)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(74, 36)
        Me.cmdExit.TabIndex = 39
        Me.cmdExit.Tag = "Exit"
        Me.cmdExit.Text = "E&xit"
        '
        'cmdAdd
        '
        Me.cmdAdd.Image = CType(resources.GetObject("cmdAdd.Image"), System.Drawing.Image)
        Me.cmdAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAdd.Location = New System.Drawing.Point(58, 496)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(74, 36)
        Me.cmdAdd.TabIndex = 36
        Me.cmdAdd.Tag = "Add"
        Me.cmdAdd.Text = "    &Add"
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdEdit.Location = New System.Drawing.Point(138, 496)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(74, 36)
        Me.cmdEdit.TabIndex = 37
        Me.cmdEdit.Tag = "Edit"
        Me.cmdEdit.Text = "      &Edit"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(138, 496)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(74, 36)
        Me.cmdCancel.TabIndex = 41
        Me.cmdCancel.Tag = "Cancel"
        Me.cmdCancel.Text = "&Cancel"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDelete.Location = New System.Drawing.Point(219, 496)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(74, 36)
        Me.cmdDelete.TabIndex = 38
        Me.cmdDelete.Tag = "Delete"
        Me.cmdDelete.Text = "     &Del"
        '
        'cmdSave
        '
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSave.Location = New System.Drawing.Point(218, 496)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(74, 36)
        Me.cmdSave.TabIndex = 40
        Me.cmdSave.Tag = "Save"
        Me.cmdSave.Text = "      &Save"
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 8)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(1312, 428)
        Me.DataGrid1.TabIndex = 42
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.DataGrid1.Tag = "View"
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "CompanyCT_Show"
        Me.DataGridTableStyle1.ReadOnly = True
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "RowId"
        Me.DataGridTextBoxColumn9.MappingName = "rowid"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 0
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Code"
        Me.DataGridTextBoxColumn1.MappingName = "companycode"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 30
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Company"
        Me.DataGridTextBoxColumn2.MappingName = "Company"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Description"
        Me.DataGridTextBoxColumn3.MappingName = "companyname"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 200
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Address 1"
        Me.DataGridTextBoxColumn4.MappingName = "address1"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 200
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Address 2"
        Me.DataGridTextBoxColumn5.MappingName = "address2"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.ReadOnly = True
        Me.DataGridTextBoxColumn5.Width = 200
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Createdate"
        Me.DataGridTextBoxColumn6.MappingName = "create_date"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.ReadOnly = True
        Me.DataGridTextBoxColumn6.Width = 70
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "UpdateDate"
        Me.DataGridTextBoxColumn7.MappingName = "update_date"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.ReadOnly = True
        Me.DataGridTextBoxColumn7.Width = 70
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "Encoder"
        Me.DataGridTextBoxColumn8.MappingName = "lastuser"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.ReadOnly = True
        Me.DataGridTextBoxColumn8.Width = 50
        '
        'vLastUser
        '
        Me.vLastUser.Location = New System.Drawing.Point(379, 508)
        Me.vLastUser.Name = "vLastUser"
        Me.vLastUser.Size = New System.Drawing.Size(49, 20)
        Me.vLastUser.TabIndex = 43
        Me.vLastUser.Tag = "Input"
        Me.vLastUser.Text = ""
        Me.vLastUser.Visible = False
        '
        'vCompany
        '
        Me.vCompany.Location = New System.Drawing.Point(192, 445)
        Me.vCompany.Name = "vCompany"
        Me.vCompany.Size = New System.Drawing.Size(112, 20)
        Me.vCompany.TabIndex = 1
        Me.vCompany.Tag = "Input"
        Me.vCompany.Text = ""
        '
        'vAddress1
        '
        Me.vAddress1.Location = New System.Drawing.Point(57, 469)
        Me.vAddress1.Name = "vAddress1"
        Me.vAddress1.Size = New System.Drawing.Size(248, 20)
        Me.vAddress1.TabIndex = 3
        Me.vAddress1.Tag = "Input"
        Me.vAddress1.Text = ""
        '
        'vAddress2
        '
        Me.vAddress2.Location = New System.Drawing.Point(402, 469)
        Me.vAddress2.Name = "vAddress2"
        Me.vAddress2.Size = New System.Drawing.Size(248, 20)
        Me.vAddress2.TabIndex = 4
        Me.vAddress2.Tag = "Input"
        Me.vAddress2.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(126, 445)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 20)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Short Name"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(0, 469)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 20)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Address 1"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(344, 469)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 20)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Address 2"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'vRowid
        '
        Me.vRowid.Location = New System.Drawing.Point(432, 507)
        Me.vRowid.Name = "vRowid"
        Me.vRowid.Size = New System.Drawing.Size(49, 20)
        Me.vRowid.TabIndex = 50
        Me.vRowid.Tag = "Input"
        Me.vRowid.Text = ""
        Me.vRowid.Visible = False
        '
        'CompanyCT
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1329, 541)
        Me.Controls.Add(Me.vRowid)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.vAddress1)
        Me.Controls.Add(Me.vCompany)
        Me.Controls.Add(Me.vAddress2)
        Me.Controls.Add(Me.vLastUser)
        Me.Controls.Add(Me.vCompanyName)
        Me.Controls.Add(Me.vCode)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.lblUpdateDate)
        Me.Controls.Add(Me.lblCreateDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CompanyCT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Company"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        modControlBehavior.EnableControlsGroup(Me, True)
        ControlMaintenance.ClearInputControls(Me)
        z = "select max(code) from NewScores..Company"
        vCode.Text = FindValue(z)
        vCode.Text = Format((Val(vCode.Text) + 1), "0#")
        EditMode = False
    End Sub
    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If Trim(vCode.Text) = "" And vCompany.Text = "" Then
            MessageBox.Show("Please select a record to modify!", "Record Selection", MessageBoxButtons.OK, _
            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            modControlBehavior.EnableControlsGroup(Me, True)
            EditMode = True
            vCode.ReadOnly = True
        End If
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If Trim(vCode.Text) > "" Then
            If (MessageBox.Show("Do you really want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, _
            MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then
                Sub_Delete()
                ControlMaintenance.ClearInputControls(Me)
                DataGrid1.DataSource = Nothing
                Sub_Show()
            End If
        End If
    End Sub
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        modControlBehavior.EnableControls(Me, False)
        ControlMaintenance.ClearInputControls(Me)
        EditMode = False
        vCode.ReadOnly = False
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If (MessageBox.Show("Are you sure you want to Save this Entry?", "Confirm Saving", _
                      MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)) _
                      = DialogResult.Yes Then

            Dim Params(0) As String
            'vCode is not numeric, change it to vRowid
            'Params(0) = Trim(vCode.Text)
            Params(0) = Trim(vRowid.Text)
            If EditMode = False Then
                Sub_Insert()
            Else
                Sub_Update()
            End If
            modControlBehavior.EnableControls(Me, False)
            DataGrid1.DataSource = Nothing
            Sub_Show()
            Sub_Select(Params, CStr(IIf(EditMode = False, "Insert", "Update")))
            EditMode = False
        End If
    End Sub
    Private Sub Sub_Insert()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(7) As SqlParameter
            Dim Code As New SqlParameter("@Code", SqlDbType.Char, 2)
            Code.Direction = ParameterDirection.Input
            Code.Value = Trim(vCode.Text)
            Params(0) = Code
            Dim Company As New SqlParameter("@Company", SqlDbType.VarChar, 50)
            Company.Direction = ParameterDirection.Input
            Company.Value = Trim(vCompany.Text)
            Params(1) = Company
            Dim CompanyName As New SqlParameter("@CompanyName", SqlDbType.VarChar, 50)
            CompanyName.Direction = ParameterDirection.Input
            CompanyName.Value = Trim(vCompanyName.Text)
            Params(2) = CompanyName
            Dim Address1 As New SqlParameter("@Address1", SqlDbType.VarChar, 50)
            Address1.Direction = ParameterDirection.Input
            Address1.Value = Trim(vAddress1.Text)
            Params(3) = Address1
            Dim Address2 As New SqlParameter("@Address2", SqlDbType.VarChar, 50)
            Address2.Direction = ParameterDirection.Input
            Address2.Value = Trim(vAddress2.Text)
            Params(4) = Address2
            Dim Create_Date As New SqlParameter("@Create_Date", SqlDbType.DateTime, 10)
            Create_Date.Direction = ParameterDirection.Input
            Create_Date.Value = Now()
            Params(5) = Create_Date
            Dim Update_Date As New SqlParameter("@Update_Date", SqlDbType.DateTime, 10)
            Update_Date.Direction = ParameterDirection.Input
            Update_Date.Value = Now()
            Params(6) = Update_Date
            Dim LastUser As New SqlParameter("@LastUser", SqlDbType.Char, 10)
            LastUser.Direction = ParameterDirection.Input
            LastUser.Value = Trim(gCurrUser)
            Params(7) = LastUser
            BusinessObject.Sub_Insert(ServerPath, "CompanyCT_Insert", CommandType.StoredProcedure, Params)
            LogHelper.InsertLog("CompanyCT_Insert.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("CompanyCT_Insert.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Sub_Update()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(6) As SqlParameter
            Dim Code As New SqlParameter("@Code", SqlDbType.Char, 2)
            Code.Direction = ParameterDirection.Input
            Code.Value = Trim(vCode.Text)
            Params(0) = Code
            Dim Company As New SqlParameter("@Company", SqlDbType.VarChar, 50)
            Company.Direction = ParameterDirection.Input
            Company.Value = Trim(vCompany.Text)
            Params(1) = Company
            Dim CompanyName As New SqlParameter("@CompanyName", SqlDbType.VarChar, 50)
            CompanyName.Direction = ParameterDirection.Input
            CompanyName.Value = Trim(vCompanyName.Text)
            Params(2) = CompanyName
            Dim Address1 As New SqlParameter("@Address1", SqlDbType.VarChar, 50)
            Address1.Direction = ParameterDirection.Input
            Address1.Value = Trim(vAddress1.Text)
            Params(3) = Address1
            Dim Address2 As New SqlParameter("@Address2", SqlDbType.VarChar, 50)
            Address2.Direction = ParameterDirection.Input
            Address2.Value = Trim(vAddress2.Text)
            Params(4) = Address2
            Dim Update_Date As New SqlParameter("@Update_Date", SqlDbType.DateTime)
            Update_Date.Direction = ParameterDirection.Input
            Update_Date.Value = Now()
            Params(5) = Update_Date
            Dim LastUser As New SqlParameter("@LastUser", SqlDbType.Char, 10)
            LastUser.Direction = ParameterDirection.Input
            LastUser.Value = Trim(gCurrUser)
            Params(6) = LastUser
            BusinessObject.Sub_Update(ServerPath, "CompanyCT_Update", CommandType.StoredProcedure, Params)
            LogHelper.InsertLog("CompanyCT_Update.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("CompanyCT_Update.Error: " & ex.Message)
        End Try
    End Sub
    Private Sub Sub_Show()
        If RemoteDataSet.CompanyCT_Show.Count > 0 Then RemoteDataSet.CompanyCT_Show.Clear()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath, "CompanyCT_Show", CommandType.StoredProcedure, RemoteDataSet, "CompanyCT_Show")
        DataGrid1.DataSource = RemoteDataSet.CompanyCT_Show
    End Sub
    Private Sub Sub_Select(ByVal dbParams() As String, ByVal UpdateMode As String)
        'select case if add,edit or delete
        Dim i As Integer
        Dim myCode As Integer
        Select Case UpdateMode
            Case "Insert"
                Dim BusinessObject As New BusinessLayer.clsFileMaintenance
                myCode = CInt(BusinessObject.Sub_ReturnIntegerResult(ServerPath, "CompanyCT_GetInsertedRowid", CommandType.StoredProcedure))
            Case "Update"
                myCode = CInt(dbParams(0))
        End Select
        For i = 0 To (RemoteDataSet.CompanyCT_Show.Rows.Count - 1)
            With DataGrid1
                If myCode = CInt(.Item(i, 0)) Then
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
            Dim Code As New SqlParameter("@Code", SqlDbType.Char, 2)
            Code.Direction = ParameterDirection.Input
            Code.Value = Trim(vCode.Text)
            Params(0) = Code
            BusinessObject.Sub_Delete(ServerPath, "CompanyCT_Delete", CommandType.StoredProcedure, Params)
            LogHelper.InsertLog("CompanyCt.Sub_Delete.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("CompanyCt.Sub_Delete.Error:" & ex.Message)
        End Try
    End Sub
    Private Sub CompanyCT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        modControlBehavior.EnableControls(Me, False)
        vLastUser.Text = gCurrUser
    End Sub
    Private Sub DataGrid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.Click, DataGrid1.CurrentCellChanged
        With DataGrid1
            vRowid.Text = (.Item(.CurrentCell.RowNumber, 0).ToString)
            vCode.Text = (.Item(.CurrentCell.RowNumber, 1).ToString)
            vCompany.Text = (.Item(.CurrentCell.RowNumber, 2).ToString)
            vCompanyName.Text = (.Item(.CurrentCell.RowNumber, 3).ToString)
            vAddress1.Text = (.Item(.CurrentCell.RowNumber, 4).ToString)
            vAddress2.Text = (.Item(.CurrentCell.RowNumber, 5).ToString)
            z = Trim(.Item(.CurrentCell.RowNumber, 6).ToString)
            If z <> "" Then
                lblCreateDate.Text = Format(CDate(z), "MM/dd/yyyy")
            Else
                lblCreateDate.Text = ""
            End If
            z = Trim(.Item(.CurrentCell.RowNumber, 7).ToString)
            If z <> "" Then
                lblUpdateDate.Text = Format(CDate(z), "MM/dd/yyyy")
            Else
                lblUpdateDate.Text = ""
            End If
            vLastUser.Text = (.Item(.CurrentCell.RowNumber, 8).ToString)
            .Select(.CurrentCell.RowNumber)
        End With
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
    Friend WithEvents vAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents vAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents vCompany As System.Windows.Forms.TextBox
    Friend WithEvents vLastUser As System.Windows.Forms.TextBox
    Friend WithEvents vCompanyName As System.Windows.Forms.TextBox
    Friend WithEvents vCode As System.Windows.Forms.TextBox
End Class
