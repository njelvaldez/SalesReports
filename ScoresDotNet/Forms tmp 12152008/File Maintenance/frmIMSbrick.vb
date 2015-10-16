Imports System.Data.SqlClient
Imports System.EnterpriseServices

Public Class frmIMSbrick
    Inherits System.Windows.Forms.Form
    Private RemoteDataSet As New CodeTablesDS
    Private RemoteDataSet2 As New MyDataSetDB
    Private EditMode As Boolean = False
    Private oldDs As String, tmpSD As String, tmpED As String   '<-- added-DBrion
    Private xLen As Integer     '<-- added-DBrion

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
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtRowid As System.Windows.Forms.TextBox
    Friend WithEvents txtGroup As System.Windows.Forms.TextBox
    Friend WithEvents txtProvince As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGrid2 As System.Windows.Forms.DataGrid
    Friend WithEvents txtTerritory As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGrid2 = New System.Windows.Forms.DataGrid
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.txtRowid = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtGroup = New System.Windows.Forms.TextBox
        Me.txtProvince = New System.Windows.Forms.TextBox
        Me.txtTerritory = New System.Windows.Forms.TextBox
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(-1, 269)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Code - Description"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCode
        '
        Me.txtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Font = New System.Drawing.Font("Times New Roman", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(102, 259)
        Me.txtCode.MaxLength = 5
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(44, 21)
        Me.txtCode.TabIndex = 0
        Me.txtCode.Tag = "Input"
        Me.txtCode.Text = ""
        '
        'txtDescription
        '
        Me.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescription.Font = New System.Drawing.Font("Times New Roman", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(150, 259)
        Me.txtDescription.MaxLength = 50
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(262, 21)
        Me.txtDescription.TabIndex = 1
        Me.txtDescription.Tag = "Input"
        Me.txtDescription.Text = ""
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(502, 288)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.TabIndex = 6
        Me.cmdExit.Tag = "Exit"
        Me.cmdExit.Text = "Exit"
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(422, 258)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.TabIndex = 3
        Me.cmdAdd.Tag = "Add"
        Me.cmdAdd.Text = "Add"
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(502, 258)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.TabIndex = 4
        Me.cmdEdit.Tag = "Edit"
        Me.cmdEdit.Text = "Edit"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(502, 258)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.TabIndex = 41
        Me.cmdCancel.Tag = "Cancel"
        Me.cmdCancel.Text = "Cancel"
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(422, 288)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.TabIndex = 5
        Me.cmdDelete.Tag = "Delete"
        Me.cmdDelete.Text = "Delete"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(422, 288)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.TabIndex = 40
        Me.cmdSave.Tag = "Save"
        Me.cmdSave.Text = "Save"
        '
        'DataGrid1
        '
        Me.DataGrid1.AlternatingBackColor = System.Drawing.SystemColors.ScrollBar
        Me.DataGrid1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.DataGrid1.CaptionText = "IMSB"
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 4)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(570, 246)
        Me.DataGrid1.TabIndex = 0
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.DataGrid1.Tag = "View"
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Cyan
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightCyan
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8})
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.AntiqueWhite
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Territorylst"
        Me.DataGridTableStyle1.ReadOnly = True
        '
        'DataGrid2
        '
        Me.DataGrid2.AlternatingBackColor = System.Drawing.SystemColors.ScrollBar
        Me.DataGrid2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.DataGrid2.CaptionText = "Territory Selection"
        Me.DataGrid2.DataMember = ""
        Me.DataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid2.Location = New System.Drawing.Point(8, 385)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.Size = New System.Drawing.Size(570, 182)
        Me.DataGrid2.TabIndex = 133
        Me.DataGrid2.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.DataGrid2.Tag = "View"
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.MappingName = "rowid"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 10
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Code-"
        Me.DataGridTextBoxColumn3.MappingName = "territorycode"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 55
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Territory"
        Me.DataGridTextBoxColumn4.MappingName = "territory"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 200
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Code-"
        Me.DataGridTextBoxColumn5.MappingName = "code"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 55
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Group"
        Me.DataGridTextBoxColumn6.MappingName = "groupp"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 200
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Code-"
        Me.DataGridTextBoxColumn7.MappingName = "pro_code"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.ReadOnly = True
        Me.DataGridTextBoxColumn7.Width = 55
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "Province"
        Me.DataGridTextBoxColumn8.MappingName = "province"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 200
        '
        'txtRowid
        '
        Me.txtRowid.Location = New System.Drawing.Point(422, 319)
        Me.txtRowid.Name = "txtRowid"
        Me.txtRowid.Size = New System.Drawing.Size(75, 20)
        Me.txtRowid.TabIndex = 43
        Me.txtRowid.Tag = "Input"
        Me.txtRowid.Text = ""
        Me.txtRowid.Visible = False
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Location = New System.Drawing.Point(8, 379)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(568, 2)
        Me.Label9.TabIndex = 54
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 253)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "IMS Brick"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(-1, 290)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Territory"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(-1, 320)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Group"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(-1, 352)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 13)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Province"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGroup
        '
        Me.txtGroup.BackColor = System.Drawing.SystemColors.Info
        Me.txtGroup.Font = New System.Drawing.Font("Times New Roman", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroup.Location = New System.Drawing.Point(102, 318)
        Me.txtGroup.Name = "txtGroup"
        Me.txtGroup.ReadOnly = True
        Me.txtGroup.Size = New System.Drawing.Size(311, 21)
        Me.txtGroup.TabIndex = 131
        Me.txtGroup.Tag = "INPUT"
        Me.txtGroup.Text = ""
        '
        'txtProvince
        '
        Me.txtProvince.BackColor = System.Drawing.SystemColors.Info
        Me.txtProvince.Font = New System.Drawing.Font("Times New Roman", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvince.Location = New System.Drawing.Point(102, 348)
        Me.txtProvince.Name = "txtProvince"
        Me.txtProvince.ReadOnly = True
        Me.txtProvince.Size = New System.Drawing.Size(311, 21)
        Me.txtProvince.TabIndex = 132
        Me.txtProvince.Tag = "INPUT"
        Me.txtProvince.Text = ""
        '
        'txtTerritory
        '
        Me.txtTerritory.BackColor = System.Drawing.SystemColors.Info
        Me.txtTerritory.Font = New System.Drawing.Font("Times New Roman", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTerritory.Location = New System.Drawing.Point(102, 288)
        Me.txtTerritory.Name = "txtTerritory"
        Me.txtTerritory.ReadOnly = True
        Me.txtTerritory.Size = New System.Drawing.Size(311, 21)
        Me.txtTerritory.TabIndex = 134
        Me.txtTerritory.Tag = "INPUT"
        Me.txtTerritory.Text = ""
        '
        'frmIMSbrick
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(584, 571)
        Me.Controls.Add(Me.txtTerritory)
        Me.Controls.Add(Me.DataGrid2)
        Me.Controls.Add(Me.txtProvince)
        Me.Controls.Add(Me.txtGroup)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtRowid)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmIMSbrick"
        Me.Text = "IMS Bricks"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        modControlBehavior.EnableControls(Me, True)
        ControlMaintenance.ClearInputControls(Me)
        EditMode = False
        'added-DBrion --v
        DataGrid2.Enabled = True
        btnSw = True
        'lblCreateDate.Text = GetDateTimeNow("MM/dd/yyyy")
        'lblUpdateDate.Text = GetDateTimeNow("MM/dd/yyyy")
        txtCode.Enabled = True
        txtCode.Select()
        'added-DBrion --^
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If txtCode.Text = "" And txtDescription.Text = "" Then
            MessageBox.Show("Please select a record to modify!", "Record Selection", MessageBoxButtons.OK, _
            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            modControlBehavior.EnableControls(Me, True)
            EditMode = True
            'added-DBrion --v
            DataGrid2.Enabled = True
            btnSw = True
            'lblUpdateDate.Text = GetDateTimeNow("MM/dd/yyyy")
            txtCode.Enabled = False
            txtCode.BackColor = BackColor.White
            txtCode.ForeColor = BackColor.Black
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
            'added-DBrion  --v
            If Trim(txtCode.Text) = "" Or Trim(txtDescription.Text) = "" Then
                MessageBox.Show("Main fields are mandatory")
                If Trim(txtCode.Text) = "" Then
                    txtCode.Select()
                End If
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
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(2) As SqlParameter
        Dim IMSbrickCode As New SqlParameter("@IMSbrickCode", SqlDbType.Char, 5)
        IMSbrickCode.Direction = ParameterDirection.Input
        IMSbrickCode.Value = Trim(txtCode.Text)
        Params(0) = IMSbrickCode
        Dim IMSbrickDesc As New SqlParameter("@IMSbrickDesc", SqlDbType.VarChar, 50)
        IMSbrickDesc.Direction = ParameterDirection.Input
        IMSbrickDesc.Value = Trim(txtDescription.Text)
        Params(1) = IMSbrickDesc
        Dim TerritoryRowid As New SqlParameter("@TerritoryRowid", SqlDbType.VarChar, 50)
        TerritoryRowid.Direction = ParameterDirection.Input
        TerritoryRowid.Value = Trim(txtRowid.Text)
        Params(2) = TerritoryRowid
        Try
            BusinessObject.Sub_Insert(ServerPath2, "IMSB_Insert", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Sub_Update()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(2) As SqlParameter
        Dim IMSbrickCode As New SqlParameter("@IMSbrickCode", SqlDbType.Char, 5)
        IMSbrickCode.Direction = ParameterDirection.Input
        IMSbrickCode.Value = Trim(txtCode.Text)
        Params(0) = IMSbrickCode
        Dim IMSbrickDesc As New SqlParameter("@IMSbrickDesc", SqlDbType.VarChar, 50)
        IMSbrickDesc.Direction = ParameterDirection.Input
        IMSbrickDesc.Value = Trim(txtDescription.Text)
        Params(1) = IMSbrickDesc
        Dim TerritoryRowid As New SqlParameter("@TerritoryRowid", SqlDbType.VarChar, 50)
        TerritoryRowid.Direction = ParameterDirection.Input
        TerritoryRowid.Value = Trim(txtRowid.Text)
        Params(2) = TerritoryRowid
        BusinessObject.Sub_Update(ServerPath2, "IMSB_Update", CommandType.StoredProcedure, Params)
    End Sub

    Private Sub Sub_Show()
        If RemoteDataSet2.IMSB_Show.Count > 0 Then RemoteDataSet2.IMSB_Show.Clear()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Try
            BusinessObject.Sub_Show(ServerPath2, "IMSB_Show", CommandType.StoredProcedure, RemoteDataSet2, "IMSB_Show")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        DataGrid1.DataSource = RemoteDataSet2.IMSB_Show

        If RemoteDataSet2.TerritoryLst.Count > 0 Then RemoteDataSet2.TerritoryLst.Clear()
        Try
            BusinessObject.Sub_Show(ServerPath2, "TerritoryLst", CommandType.StoredProcedure, RemoteDataSet2, "TerritoryLst")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        DataGrid2.DataSource = RemoteDataSet2.TerritoryLst

    End Sub

    Private Sub Sub_Select(ByVal dbParams() As String, ByVal UpdateMode As String)
        'select case if add,edit or delete
        Dim i As Integer
        Dim myRowid As Integer
        Select Case UpdateMode
            Case "Insert"
                Dim BusinessObject As New BusinessLayer.clsFileMaintenance
                myRowid = CInt(BusinessObject.Sub_ReturnIntegerResult(ServerPath2, "IMSB_GetInsertedRowid", CommandType.StoredProcedure))
            Case "Update"
                myRowid = CInt(dbParams(0))
        End Select
        For i = 0 To (RemoteDataSet2.IMSB_Show.Rows.Count - 1)
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
        Dim Pram(0) As SqlParameter
        Dim IMSbrickCode As New SqlParameter("@IMSbrickCode", SqlDbType.VarChar, 5) '<v-- changed form Rowid to Divcode
        IMSbrickCode.Direction = ParameterDirection.Input
        IMSbrickCode.Value = Trim(txtCode.Text)
        Pram(0) = IMSbrickCode                                               '<^-- changed form Rowid to Divcode
        Try
            BusinessObject.Sub_Delete(ServerPath2, "IMSB_Delete", CommandType.StoredProcedure, Pram)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmIMSbrick_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        modControlBehavior.EnableControls(Me, False)
        btnSw = False    '<-- added-DBrion
        DataGrid2.Enabled = False
        tmpSD = ""
        tmpED = ""
    End Sub

    Private Sub frmIMSbrick_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        btnSw = False
    End Sub

    Private Sub DataGrid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.Click, DataGrid1.CurrentCellChanged
        With DataGrid1
            txtRowid.Text = .Item(.CurrentCell.RowNumber, 8).ToString       '<-added".ToString"-DBrion
            txtCode.Text = .Item(.CurrentCell.RowNumber, 0).ToString        '<-added".ToString"-DBrion
            txtDescription.Text = .Item(.CurrentCell.RowNumber, 1).ToString '<-added".ToString"-DBrion
            txtTerritory.Text = .Item(.CurrentCell.RowNumber, 2).ToString & "--" & .Item(.CurrentCell.RowNumber, 3).ToString
            txtGroup.Text = .Item(.CurrentCell.RowNumber, 4).ToString & "--" & .Item(.CurrentCell.RowNumber, 5).ToString
            txtProvince.Text = .Item(.CurrentCell.RowNumber, 6).ToString & "--" & .Item(.CurrentCell.RowNumber, 7).ToString

            .Select(.CurrentCell.RowNumber)
        End With
    End Sub

    Private Sub DataGrid2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid2.Click, DataGrid2.CurrentCellChanged
        With DataGrid2
            txtRowid.Text = .Item(.CurrentCell.RowNumber, 0).ToString
            txtTerritory.Text = .Item(.CurrentCell.RowNumber, 1).ToString & "--" & .Item(.CurrentCell.RowNumber, 2).ToString
            txtGroup.Text = .Item(.CurrentCell.RowNumber, 3).ToString & "--" & .Item(.CurrentCell.RowNumber, 4).ToString
            txtProvince.Text = .Item(.CurrentCell.RowNumber, 5).ToString & "--" & .Item(.CurrentCell.RowNumber, 6).ToString

            .Select(.CurrentCell.RowNumber)
        End With
    End Sub

    Private Sub txtCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
        If NumKeys(e.KeyData, "INT") = False Then
            If Len(Trim(txtCode.Text)) <> 0 Then
                txtCode.Text = Mid(Trim(txtCode.Text), 1, Len(Trim(txtCode.Text)) - 1)
                txtCode.SelectionStart = Len(Trim(txtCode.Text))
                Beep()
            Else
                txtCode.Text = ""
            End If
        End If
    End Sub

    Private Sub txtCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCode.Validating
        Dim s As String
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter
        If Trim(txtCode.Text) = "" Then
            txtDescription.Select()
            Exit Sub
        End If
        If btnSw = True And EditMode = False Then
            s = "select divname as fld1 from NewScores..Division where divcode = '" & Trim(txtCode.Text) & "' "
            If Existing(s) = True Then
                MessageBox.Show("This Division Code already exist! Please try again.", "Code Exsists!")
                e.Cancel = True
                txtCode.Clear()
            End If
        End If
    End Sub

    Private Sub txtDescription_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescription.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtDescription_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDescription.Validating
        Dim s As String
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter
        If Trim(txtDescription.Text) = "" Then
            txtCode.Select()
            Exit Sub
        End If
        If btnSw = True And Trim(txtDescription.Text) <> Trim(oldDs) Then
            s = "select divcode as fld1 from NewScores..Division where divname = '" & Trim(txtDescription.Text) & "' "
            If Existing(s) = True Then
                MessageBox.Show("This Division name already exist! Please try again.", "Description Exsists!")
                e.Cancel = True
                txtDescription.Clear()
            End If
        End If
    End Sub

    Private Sub TxtManager_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cboTerritory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        z = "select a.code + '--' + a.[group] TGroup from NewScores..Group a "
        z = z & " inner join NewScores..Territory b on a.rowid = b.groupdr "
        z = z & "where b.territorycode = '" & Trim(GetCode(txtTerritory.Text)) & "' "
        txtGroup.Text = CStr(CInt(DataMaintenance.GetSingleResult(ServerPath2, z, CommandType.Text)))

        z = "select a.pro_code + '--' + a.province TProvince from NewScores..Province a "
        z = z & " inner join NewScores..Territory b on a.rowid = b.provincedr "
        z = z & "where b.territorycode = '" & Trim(GetCode(txtTerritory.Text)) & "' "
        txtProvince.Text = CStr(CInt(DataMaintenance.GetSingleResult(ServerPath2, z, CommandType.Text)))
    End Sub

    Private Sub cboTerritory_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        cboTerritory_Click(txtTerritory, e)
    End Sub
End Class