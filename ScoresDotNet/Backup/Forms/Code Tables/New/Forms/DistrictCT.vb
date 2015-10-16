Imports System.Data.SqlClient
Public Class DistrictCT
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents vDistrictCode As System.Windows.Forms.TextBox
    Friend WithEvents vDistrictName As System.Windows.Forms.TextBox
    Friend WithEvents vRowid As System.Windows.Forms.TextBox
    Friend WithEvents vCompanyCode As System.Windows.Forms.TextBox
    Friend WithEvents vDivisionCode As System.Windows.Forms.TextBox
    Friend WithEvents vStart_Date As System.Windows.Forms.TextBox
    Friend WithEvents vEnd_Date As System.Windows.Forms.TextBox
    Friend WithEvents btnComp As System.Windows.Forms.Button
    Friend WithEvents btnDiv As System.Windows.Forms.Button
    Friend WithEvents vLastUser As System.Windows.Forms.TextBox
    Friend WithEvents txtCompany As System.Windows.Forms.TextBox
    Friend WithEvents txtDivision As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(DistrictCT))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.vDistrictCode = New System.Windows.Forms.TextBox
        Me.vDistrictName = New System.Windows.Forms.TextBox
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
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.vRowid = New System.Windows.Forms.TextBox
        Me.vCompanyCode = New System.Windows.Forms.TextBox
        Me.vDivisionCode = New System.Windows.Forms.TextBox
        Me.vStart_Date = New System.Windows.Forms.TextBox
        Me.vEnd_Date = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnComp = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnDiv = New System.Windows.Forms.Button
        Me.vLastUser = New System.Windows.Forms.TextBox
        Me.txtCompany = New System.Windows.Forms.TextBox
        Me.txtDivision = New System.Windows.Forms.TextBox
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(4, 510)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "District"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(288, 510)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Segment"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(739, 486)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Create Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(739, 510)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Update Date"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'vDistrictCode
        '
        Me.vDistrictCode.Location = New System.Drawing.Point(46, 486)
        Me.vDistrictCode.Name = "vDistrictCode"
        Me.vDistrictCode.Size = New System.Drawing.Size(66, 20)
        Me.vDistrictCode.TabIndex = 0
        Me.vDistrictCode.Tag = "Input"
        Me.vDistrictCode.Text = ""
        '
        'vDistrictName
        '
        Me.vDistrictName.Location = New System.Drawing.Point(46, 510)
        Me.vDistrictName.Name = "vDistrictName"
        Me.vDistrictName.Size = New System.Drawing.Size(235, 20)
        Me.vDistrictName.TabIndex = 1
        Me.vDistrictName.Tag = "Input"
        Me.vDistrictName.Text = ""
        '
        'lblCreateDate
        '
        Me.lblCreateDate.BackColor = System.Drawing.SystemColors.Info
        Me.lblCreateDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCreateDate.Location = New System.Drawing.Point(809, 486)
        Me.lblCreateDate.Name = "lblCreateDate"
        Me.lblCreateDate.Size = New System.Drawing.Size(75, 20)
        Me.lblCreateDate.TabIndex = 6
        Me.lblCreateDate.Tag = "Input"
        '
        'lblUpdateDate
        '
        Me.lblUpdateDate.BackColor = System.Drawing.SystemColors.Info
        Me.lblUpdateDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUpdateDate.Location = New System.Drawing.Point(809, 510)
        Me.lblUpdateDate.Name = "lblUpdateDate"
        Me.lblUpdateDate.Size = New System.Drawing.Size(75, 20)
        Me.lblUpdateDate.TabIndex = 7
        Me.lblUpdateDate.Tag = "Input"
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(208, 552)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(64, 35)
        Me.cmdExit.TabIndex = 39
        Me.cmdExit.Tag = "Exit"
        Me.cmdExit.Text = "E&xit"
        '
        'cmdAdd
        '
        Me.cmdAdd.Image = CType(resources.GetObject("cmdAdd.Image"), System.Drawing.Image)
        Me.cmdAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAdd.Location = New System.Drawing.Point(7, 552)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(64, 35)
        Me.cmdAdd.TabIndex = 36
        Me.cmdAdd.Tag = "Add"
        Me.cmdAdd.Text = "        &Add"
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdEdit.Location = New System.Drawing.Point(73, 552)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(64, 35)
        Me.cmdEdit.TabIndex = 37
        Me.cmdEdit.Tag = "Edit"
        Me.cmdEdit.Text = "       &Edit"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(74, 552)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(64, 35)
        Me.cmdCancel.TabIndex = 41
        Me.cmdCancel.Tag = "Cancel"
        Me.cmdCancel.Text = "&Cancel"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDelete.Location = New System.Drawing.Point(142, 552)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(64, 35)
        Me.cmdDelete.TabIndex = 38
        Me.cmdDelete.Tag = "Delete"
        Me.cmdDelete.Text = "        &Del"
        '
        'cmdSave
        '
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSave.Location = New System.Drawing.Point(142, 552)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(64, 35)
        Me.cmdSave.TabIndex = 40
        Me.cmdSave.Tag = "Save"
        Me.cmdSave.Text = "        &Save"
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 8)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(1311, 465)
        Me.DataGrid1.TabIndex = 42
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.DataGrid1.Tag = "View"
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "DistrictCT_Show"
        Me.DataGridTableStyle1.ReadOnly = True
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.MappingName = "Rowid"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Code"
        Me.DataGridTextBoxColumn2.MappingName = "districtCode"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 70
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "District"
        Me.DataGridTextBoxColumn3.MappingName = "districtname"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 200
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Company"
        Me.DataGridTextBoxColumn6.MappingName = "company"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 200
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Segment"
        Me.DataGridTextBoxColumn7.MappingName = "Divname"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 200
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "Start Date"
        Me.DataGridTextBoxColumn8.MappingName = "start_date"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 70
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "End Date"
        Me.DataGridTextBoxColumn9.MappingName = "end_date"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 70
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Create Date"
        Me.DataGridTextBoxColumn4.MappingName = "Create_Date"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 70
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Update Date"
        Me.DataGridTextBoxColumn5.MappingName = "Update_Date"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.ReadOnly = True
        Me.DataGridTextBoxColumn5.Width = 70
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "Encoder"
        Me.DataGridTextBoxColumn10.MappingName = "lastuser"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.Width = 75
        '
        'vRowid
        '
        Me.vRowid.Location = New System.Drawing.Point(328, 553)
        Me.vRowid.Name = "vRowid"
        Me.vRowid.Size = New System.Drawing.Size(13, 20)
        Me.vRowid.TabIndex = 43
        Me.vRowid.Tag = "Input"
        Me.vRowid.Text = ""
        Me.vRowid.Visible = False
        '
        'vCompanyCode
        '
        Me.vCompanyCode.Location = New System.Drawing.Point(344, 486)
        Me.vCompanyCode.Name = "vCompanyCode"
        Me.vCompanyCode.Size = New System.Drawing.Size(235, 20)
        Me.vCompanyCode.TabIndex = 2
        Me.vCompanyCode.Tag = "Input"
        Me.vCompanyCode.Text = ""
        '
        'vDivisionCode
        '
        Me.vDivisionCode.Location = New System.Drawing.Point(344, 510)
        Me.vDivisionCode.Name = "vDivisionCode"
        Me.vDivisionCode.Size = New System.Drawing.Size(235, 20)
        Me.vDivisionCode.TabIndex = 4
        Me.vDivisionCode.Tag = "Input"
        Me.vDivisionCode.Text = ""
        '
        'vStart_Date
        '
        Me.vStart_Date.Location = New System.Drawing.Point(656, 486)
        Me.vStart_Date.Name = "vStart_Date"
        Me.vStart_Date.Size = New System.Drawing.Size(75, 20)
        Me.vStart_Date.TabIndex = 6
        Me.vStart_Date.Tag = "Input"
        Me.vStart_Date.Text = ""
        '
        'vEnd_Date
        '
        Me.vEnd_Date.Location = New System.Drawing.Point(656, 510)
        Me.vEnd_Date.Name = "vEnd_Date"
        Me.vEnd_Date.Size = New System.Drawing.Size(75, 20)
        Me.vEnd_Date.TabIndex = 7
        Me.vEnd_Date.Tag = "Input"
        Me.vEnd_Date.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(587, 510)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 20)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "End Date"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(587, 486)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 20)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Start Date"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(288, 486)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 20)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Company"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnComp
        '
        Me.btnComp.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComp.ImageIndex = 0
        Me.btnComp.ImageList = Me.ImageList1
        Me.btnComp.Location = New System.Drawing.Point(560, 488)
        Me.btnComp.Name = "btnComp"
        Me.btnComp.Size = New System.Drawing.Size(17, 16)
        Me.btnComp.TabIndex = 3
        Me.btnComp.Tag = "Input"
        Me.btnComp.Text = ". . ."
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnDiv
        '
        Me.btnDiv.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiv.ImageIndex = 0
        Me.btnDiv.ImageList = Me.ImageList1
        Me.btnDiv.Location = New System.Drawing.Point(560, 512)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(17, 16)
        Me.btnDiv.TabIndex = 5
        Me.btnDiv.Tag = "Input"
        Me.btnDiv.Text = ". . ."
        '
        'vLastUser
        '
        Me.vLastUser.Location = New System.Drawing.Point(351, 553)
        Me.vLastUser.Name = "vLastUser"
        Me.vLastUser.Size = New System.Drawing.Size(43, 20)
        Me.vLastUser.TabIndex = 53
        Me.vLastUser.Tag = "Input"
        Me.vLastUser.Text = ""
        Me.vLastUser.Visible = False
        '
        'txtCompany
        '
        Me.txtCompany.BackColor = System.Drawing.SystemColors.Info
        Me.txtCompany.Location = New System.Drawing.Point(344, 486)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.ReadOnly = True
        Me.txtCompany.Size = New System.Drawing.Size(235, 20)
        Me.txtCompany.TabIndex = 54
        Me.txtCompany.Tag = "Input"
        Me.txtCompany.Text = ""
        '
        'txtDivision
        '
        Me.txtDivision.BackColor = System.Drawing.SystemColors.Info
        Me.txtDivision.Location = New System.Drawing.Point(344, 510)
        Me.txtDivision.Name = "txtDivision"
        Me.txtDivision.ReadOnly = True
        Me.txtDivision.Size = New System.Drawing.Size(235, 20)
        Me.txtDivision.TabIndex = 55
        Me.txtDivision.Tag = "Input"
        Me.txtDivision.Text = ""
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "Division Code"
        Me.DataGridTextBoxColumn11.MappingName = "divcode"
        Me.DataGridTextBoxColumn11.Width = 75
        '
        'DistrictCT
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1330, 598)
        Me.Controls.Add(Me.btnComp)
        Me.Controls.Add(Me.btnDiv)
        Me.Controls.Add(Me.txtDivision)
        Me.Controls.Add(Me.txtCompany)
        Me.Controls.Add(Me.vLastUser)
        Me.Controls.Add(Me.vEnd_Date)
        Me.Controls.Add(Me.vStart_Date)
        Me.Controls.Add(Me.vDivisionCode)
        Me.Controls.Add(Me.vCompanyCode)
        Me.Controls.Add(Me.vRowid)
        Me.Controls.Add(Me.vDistrictName)
        Me.Controls.Add(Me.vDistrictCode)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
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
        Me.Name = "DistrictCT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "District"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        modControlBehavior.EnableControlsGroup(Me, True)
        ControlMaintenance.ClearInputControls(Me)
        EditMode = False
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If vDistrictCode.Text = "" And vDistrictName.Text = "" Then
            MessageBox.Show("Please select a record to modify!", "Record Selection", MessageBoxButtons.OK, _
            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            modControlBehavior.EnableControlsGroup(Me, True)
            EditMode = True
            vDistrictCode.ReadOnly = True
        End If
    End Sub
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If vRowid.Text > "" Then
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
        vDistrictCode.ReadOnly = False
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If (MessageBox.Show("Are you sure you want to Save this Entry?", "Confirm Saving", _
                      MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)) _
                      = DialogResult.Yes Then

            Dim Params(0) As String
            Params(0) = vRowid.Text
            If EditMode = False Then
                Sub_Insert()
            Else
                Sub_Update()
                vDistrictCode.ReadOnly = False
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
            Dim Params(8) As SqlParameter
            Dim DistrictCode As New SqlParameter("@DistrictCode", SqlDbType.Char, 10)
            DistrictCode.Direction = ParameterDirection.Input
            DistrictCode.Value = Trim(vDistrictCode.Text)
            Params(0) = DistrictCode
            Dim DistrictName As New SqlParameter("@DistrictName", SqlDbType.VarChar, 50)
            DistrictName.Direction = ParameterDirection.Input
            DistrictName.Value = Trim(vDistrictName.Text)
            Params(1) = DistrictName
            Dim CompanyCode As New SqlParameter("@CompanyCode", SqlDbType.Char, 2)
            CompanyCode.Direction = ParameterDirection.Input
            CompanyCode.Value = Trim(vCompanyCode.Text)
            Params(2) = CompanyCode
            Dim DivisionCode As New SqlParameter("@DivisionCode", SqlDbType.Char, 3)
            DivisionCode.Direction = ParameterDirection.Input
            DivisionCode.Value = Trim(vDivisionCode.Text)
            Params(3) = DivisionCode
            Dim Start_Date As New SqlParameter("@Start_Date", SqlDbType.DateTime, 10)
            Start_Date.Direction = ParameterDirection.Input
            Start_Date.Value = Trim(vStart_Date.Text)
            Params(4) = Start_Date
            Dim End_Date As New SqlParameter("@End_Date", SqlDbType.DateTime, 10)
            End_Date.Direction = ParameterDirection.Input
            End_Date.Value = Trim(vEnd_Date.Text)
            Params(5) = End_Date
            Dim CreateDate As New SqlParameter("@Create_Date", SqlDbType.DateTime, 10)
            CreateDate.Direction = ParameterDirection.Input
            CreateDate.Value = Now()
            Params(6) = CreateDate
            Dim UpdateDate As New SqlParameter("@Update_Date", SqlDbType.DateTime, 10)
            UpdateDate.Direction = ParameterDirection.Input
            UpdateDate.Value = Now()
            Params(7) = UpdateDate
            Dim LastUser As New SqlParameter("@LastUser", SqlDbType.Char, 10)
            LastUser.Direction = ParameterDirection.Input
            LastUser.Value = Trim(gCurrUser)
            Params(8) = LastUser
            BusinessObject.Sub_Insert(ServerPath, "DistrictCT_Insert", CommandType.StoredProcedure, Params)
            LogHelper.InsertLog("DistrictCT_Insert.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("DistrictCT_Insert.Error: " & ex.Message)
        End Try
    End Sub
    Private Sub Sub_Update()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(7) As SqlParameter

            Dim DistrictCode As New SqlParameter("@DistrictCode", SqlDbType.Char, 10)
            DistrictCode.Direction = ParameterDirection.Input
            DistrictCode.Value = Trim(vDistrictCode.Text)
            Params(0) = DistrictCode

            Dim DistrictName As New SqlParameter("@DistrictName", SqlDbType.VarChar, 50)
            DistrictName.Direction = ParameterDirection.Input
            DistrictName.Value = Trim(vDistrictName.Text)
            Params(1) = DistrictName

            Dim CompanyCode As New SqlParameter("@CompanyCode", SqlDbType.Char, 2)
            CompanyCode.Direction = ParameterDirection.Input
            CompanyCode.Value = Trim(vCompanyCode.Text)
            Params(2) = CompanyCode

            Dim DivisionCode As New SqlParameter("@DivisionCode", SqlDbType.Char, 3)
            DivisionCode.Direction = ParameterDirection.Input
            DivisionCode.Value = Trim(vDivisionCode.Text)
            Params(3) = DivisionCode

            Dim Start_Date As New SqlParameter("@Start_Date", SqlDbType.DateTime)
            Start_Date.Direction = ParameterDirection.Input
            Start_Date.Value = Trim(vStart_Date.Text)
            Params(4) = Start_Date

            Dim End_Date As New SqlParameter("@End_Date", SqlDbType.DateTime)
            End_Date.Direction = ParameterDirection.Input
            End_Date.Value = Trim(vEnd_Date.Text)
            Params(5) = End_Date

            Dim Update_Date As New SqlParameter("@Update_Date", SqlDbType.DateTime)
            Update_Date.Direction = ParameterDirection.Input
            Update_Date.Value = Now()
            Params(6) = Update_Date

            Dim LastUser As New SqlParameter("@LastUser", SqlDbType.Char, 10)
            LastUser.Direction = ParameterDirection.Input
            LastUser.Value = Trim(gCurrUser)
            Params(7) = LastUser

            BusinessObject.Sub_Update(ServerPath, "DistrictCT_Update", CommandType.StoredProcedure, Params)
            LogHelper.InsertLog("DistrictCT_Update.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("DistrictCT_Update.Error: " & ex.Message)
        End Try
    End Sub
    Private Sub Sub_Show()
        Try
            If RemoteDataSet.DistrictCT_Show.Count > 0 Then RemoteDataSet.DistrictCT_Show.Clear()
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            BusinessObject.Sub_Show(ServerPath, "DistrictCT_Show", CommandType.StoredProcedure, RemoteDataSet, "DistrictCT_Show")
            DataGrid1.DataSource = RemoteDataSet.DistrictCT_Show
            LogHelper.InsertLog("DistrictCT_Show.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("DistrictCT_Show.Error: " & ex.Message)
            Me.Close()
        End Try
    End Sub
    Private Sub Sub_Select(ByVal dbParams() As String, ByVal UpdateMode As String)
        'select case if add,edit or delete
        Dim i As Integer
        Dim myRowid As Integer
        Select Case UpdateMode
            Case "Insert"
                Dim BusinessObject As New BusinessLayer.clsFileMaintenance
                myRowid = CInt(BusinessObject.Sub_ReturnIntegerResult(ServerPath, "DistrictCT_GetInsertedRowid", CommandType.StoredProcedure))
            Case "Update"
                myRowid = CInt(dbParams(0))
        End Select
        For i = 0 To (RemoteDataSet.DistrictCT_Show.Rows.Count - 1)
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
            Rowid.Value = vRowid.Text
            Params(0) = Rowid
            BusinessObject.Sub_Delete(ServerPath, "DistrictCT_Delete", CommandType.StoredProcedure, Params)
            LogHelper.InsertLog("DistrictCT_Delete.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("DistrictCT_Delete.Error: " & ex.Message)
        End Try
    End Sub
    Private Sub DistrictCT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        modControlBehavior.EnableControls(Me, False)
        vLastUser.Text = gCurrUser
    End Sub

    Private Sub vStart_Date_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vStart_Date.KeyUp
        If e.KeyValue = 13 Then      ' tests if the key pressed is the "enter key"
            SendKeys.Send("{TAB}")   ' sends the focus to the next control/tabstop
        End If
    End Sub

    Private Sub vStart_Date_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles vStart_Date.Validating
        On Error GoTo errpt
        If Trim(vStart_Date.Text) = "" Then       'entering w/o putting value
            vStart_Date.Text = GetDateTimeNow("MM") & "/01/" & GetDateTimeNow("yyyy")
            'tmpSD = Format(CDate(vStart_Date.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
            Exit Sub
        Else
            vStart_Date.Text = DatValid(vStart_Date.Text)  'validating the entry. the textbox's value will be "mm/dd/yyyy" if the entry is invalid.
            If Trim(vStart_Date.Text) = "mm/dd/yyyy" Then
                GoTo errpt
            Else
                vStart_Date.Text = Mid(Trim(vStart_Date.Text), 1, 2) & "/01/" & _
                                    Mid(Trim(vStart_Date.Text), 7, 4)   'making the date the start of the month entered
                'tmpSD = Format(CDate(vStart_Date.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt") 'will use this variable in saving
            End If
            Exit Sub
        End If
errpt:
        e.Cancel = True  'brings back the focus to TxtStartDate textbox. only in Validating event
    End Sub

    Private Sub vEnd_Date_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vEnd_Date.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub vEnd_Date_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles vEnd_Date.Validating
        On Error GoTo errpt
        If Trim(vEnd_Date.Text) = "" Then
            vEnd_Date.Text = "12/31/2078"
            'tmpED = Format(CDate(vEnd_Date.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
            Exit Sub
        Else
            vEnd_Date.Text = DatValid(vEnd_Date.Text)
            If Trim(vEnd_Date.Text) = "mm/dd/yyyy" Then
                GoTo errpt
            Else
                If Trim(vStart_Date.Text) <> "" Then
                    If CDate(vStart_Date.Text) < CDate(vEnd_Date.Text) Then
                        vEnd_Date.Text = GetEOM(Trim(vEnd_Date.Text))
                        'tmpED = Format(CDate(vEnd_Date.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
                        Exit Sub
                    ElseIf Month(CDate(vStart_Date.Text)) > Month(CDate(vEnd_Date.Text)) Then
                        MessageBox.Show("The End date should be a month later than the Start date!")
                    End If
                End If
            End If
        End If
errpt:
        e.Cancel = True
    End Sub

    Private Sub btnComp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComp.Click
        Dim popupFrm As New frmCodDesc
        StordProcName = "District_CompanyCombo"
        popupFrm.ShowDialog(Me)
        vCompanyCode.Text = gCode
        txtCompany.Text = gDesc
    End Sub

    Private Sub btnDiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiv.Click
        Dim popupFrm As New frmCodDesc
        StordProcName = "District_DivisionCombo"
        popupFrm.ShowDialog(Me)
        vDivisionCode.Text = gCode
        txtDivision.Text = gDesc
    End Sub

    Private Sub DataGrid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.Click, DataGrid1.CurrentCellChanged
        With DataGrid1
            vRowid.Text = Trim(.Item(.CurrentCell.RowNumber, 0).ToString)
            vDistrictCode.Text = Trim(.Item(.CurrentCell.RowNumber, 1).ToString)
            vDistrictName.Text = Trim(.Item(.CurrentCell.RowNumber, 2).ToString)
            txtCompany.Text = Trim(.Item(.CurrentCell.RowNumber, 3).ToString)
            txtDivision.Text = Trim(.Item(.CurrentCell.RowNumber, 4).ToString)
            vStart_Date.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 5).ToString), "MM/dd/yyyy")
            vEnd_Date.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 6).ToString), "MM/dd/yyyy")
            lblCreateDate.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 7).ToString), "MM/dd/yyyy")
            lblUpdateDate.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 8).ToString), "MM/dd/yyyy")
            vLastUser.Text = Trim(.Item(.CurrentCell.RowNumber, 9).ToString)
            'company code was removed in Stored Procedure
            'vCompanyCode.Text = Trim(.Item(.CurrentCell.RowNumber, 10).ToString)
            vDivisionCode.Text = Trim(.Item(.CurrentCell.RowNumber, 10).ToString)
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
End Class
