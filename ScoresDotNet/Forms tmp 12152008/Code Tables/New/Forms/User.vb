Imports System.Data.SqlClient

Public Class frmUserMaint
    Inherits System.Windows.Forms.Form
    Private RemoteDataSet As New CodeTablesDS
    Private RemoteDataSet2 As New MyDataSetDB
    Private EditMode As Boolean = False
    Private oldDs As String

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
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents vRowid As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents vUserID As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents vUserName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents vPassword As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents txtUserId As System.Windows.Forms.TextBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtRowid As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRole As System.Windows.Forms.TextBox
    Friend WithEvents vRole As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents vCreateDate As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents vUpdateDate As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents vEncoder As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.vRowid = New System.Windows.Forms.DataGridTextBoxColumn
        Me.vUserID = New System.Windows.Forms.DataGridTextBoxColumn
        Me.vUserName = New System.Windows.Forms.DataGridTextBoxColumn
        Me.vPassword = New System.Windows.Forms.DataGridTextBoxColumn
        Me.txtUserId = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtUserName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.txtRowid = New System.Windows.Forms.TextBox
        Me.cmdExit = New System.Windows.Forms.Button
        Me.txtRole = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.vRole = New System.Windows.Forms.DataGridTextBoxColumn
        Me.vCreateDate = New System.Windows.Forms.DataGridTextBoxColumn
        Me.vUpdateDate = New System.Windows.Forms.DataGridTextBoxColumn
        Me.vEncoder = New System.Windows.Forms.DataGridTextBoxColumn
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.AlternatingBackColor = System.Drawing.SystemColors.ScrollBar
        Me.DataGrid1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(38, 28)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(437, 282)
        Me.DataGrid1.TabIndex = 1
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.DataGrid1.Tag = "View"
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.vRowid, Me.vUserID, Me.vUserName, Me.vPassword, Me.vRole, Me.vCreateDate, Me.vUpdateDate, Me.vEncoder})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "UserTabCT_Show"
        '
        'vRowid
        '
        Me.vRowid.Format = ""
        Me.vRowid.FormatInfo = Nothing
        Me.vRowid.MappingName = "rowid"
        Me.vRowid.NullText = ""
        Me.vRowid.Width = 0
        '
        'vUserID
        '
        Me.vUserID.Format = ""
        Me.vUserID.FormatInfo = Nothing
        Me.vUserID.HeaderText = "User's ID"
        Me.vUserID.MappingName = "userid"
        Me.vUserID.NullText = ""
        Me.vUserID.Width = 90
        '
        'vUserName
        '
        Me.vUserName.Format = ""
        Me.vUserName.FormatInfo = Nothing
        Me.vUserName.HeaderText = "Name"
        Me.vUserName.MappingName = "username"
        Me.vUserName.NullText = ""
        Me.vUserName.Width = 200
        '
        'vPassword
        '
        Me.vPassword.Format = ""
        Me.vPassword.FormatInfo = Nothing
        Me.vPassword.MappingName = "password"
        Me.vPassword.NullText = ""
        Me.vPassword.Width = 0
        '
        'txtUserId
        '
        Me.txtUserId.Location = New System.Drawing.Point(109, 323)
        Me.txtUserId.MaxLength = 10
        Me.txtUserId.Name = "txtUserId"
        Me.txtUserId.Size = New System.Drawing.Size(283, 20)
        Me.txtUserId.TabIndex = 0
        Me.txtUserId.Tag = "Input"
        Me.txtUserId.Text = ""
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Location = New System.Drawing.Point(38, 322)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "User ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(38, 352)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(109, 353)
        Me.txtUserName.MaxLength = 60
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(283, 20)
        Me.txtUserName.TabIndex = 1
        Me.txtUserName.Tag = "Input"
        Me.txtUserName.Text = ""
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(38, 382)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Password"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(109, 383)
        Me.txtPassword.MaxLength = 15
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(283, 20)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.Tag = "Input"
        Me.txtPassword.Text = "123456789012345"
        '
        'cmdAdd
        '
        Me.cmdAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAdd.Location = New System.Drawing.Point(408, 322)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(67, 21)
        Me.cmdAdd.TabIndex = 4
        Me.cmdAdd.Tag = "Add"
        Me.cmdAdd.Text = "Add"
        '
        'cmdEdit
        '
        Me.cmdEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEdit.Location = New System.Drawing.Point(408, 352)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(67, 21)
        Me.cmdEdit.TabIndex = 5
        Me.cmdEdit.Tag = "Edit"
        Me.cmdEdit.Text = "Edit"
        '
        'cmdCancel
        '
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancel.Location = New System.Drawing.Point(408, 352)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(67, 21)
        Me.cmdCancel.TabIndex = 47
        Me.cmdCancel.Tag = "Cancel"
        Me.cmdCancel.Text = "Cancel"
        '
        'cmdDelete
        '
        Me.cmdDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDelete.Location = New System.Drawing.Point(408, 382)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(67, 21)
        Me.cmdDelete.TabIndex = 6
        Me.cmdDelete.Tag = "Delete"
        Me.cmdDelete.Text = "Delete"
        '
        'cmdSave
        '
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSave.Location = New System.Drawing.Point(408, 382)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(67, 21)
        Me.cmdSave.TabIndex = 46
        Me.cmdSave.Tag = "Save"
        Me.cmdSave.Text = "Save"
        '
        'txtRowid
        '
        Me.txtRowid.Location = New System.Drawing.Point(209, 3)
        Me.txtRowid.Name = "txtRowid"
        Me.txtRowid.TabIndex = 48
        Me.txtRowid.Text = ""
        Me.txtRowid.Visible = False
        '
        'cmdExit
        '
        Me.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdExit.Location = New System.Drawing.Point(408, 412)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(67, 21)
        Me.cmdExit.TabIndex = 49
        Me.cmdExit.Tag = "Exit"
        Me.cmdExit.Text = "Exit"
        '
        'txtRole
        '
        Me.txtRole.Location = New System.Drawing.Point(109, 413)
        Me.txtRole.MaxLength = 60
        Me.txtRole.Name = "txtRole"
        Me.txtRole.Size = New System.Drawing.Size(283, 20)
        Me.txtRole.TabIndex = 50
        Me.txtRole.Tag = "Input"
        Me.txtRole.Text = ""
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(38, 412)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 21)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Role"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'vRole
        '
        Me.vRole.Format = ""
        Me.vRole.FormatInfo = Nothing
        Me.vRole.HeaderText = "Role"
        Me.vRole.MappingName = "role"
        Me.vRole.NullText = ""
        Me.vRole.Width = 0
        '
        'vCreateDate
        '
        Me.vCreateDate.Format = ""
        Me.vCreateDate.FormatInfo = Nothing
        Me.vCreateDate.HeaderText = "Create Date"
        Me.vCreateDate.MappingName = "createdate"
        Me.vCreateDate.NullText = ""
        Me.vCreateDate.Width = 70
        '
        'vUpdateDate
        '
        Me.vUpdateDate.Format = ""
        Me.vUpdateDate.FormatInfo = Nothing
        Me.vUpdateDate.HeaderText = "Update Date"
        Me.vUpdateDate.MappingName = "updatedate"
        Me.vUpdateDate.NullText = ""
        Me.vUpdateDate.Width = 70
        '
        'vEncoder
        '
        Me.vEncoder.Format = ""
        Me.vEncoder.FormatInfo = Nothing
        Me.vEncoder.HeaderText = "Encoder"
        Me.vEncoder.MappingName = "encoder"
        Me.vEncoder.NullText = ""
        Me.vEncoder.Width = 0
        '
        'frmUserMaint
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(513, 461)
        Me.Controls.Add(Me.txtRole)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.txtRowid)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.txtUserId)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGrid1)
        Me.Name = "frmUserMaint"
        Me.Text = "User Maintenance"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        modControlBehavior.EnableControls(Me, True)
        ControlMaintenance.ClearInputControls(Me)
        EditMode = False
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If txtUserId.Text = "" And txtUserName.Text = "" Then
            MessageBox.Show("Please select a record to modify!", _
                            "Record Selection", _
                            MessageBoxButtons.OK, _
                            MessageBoxIcon.Information, _
                            MessageBoxDefaultButton.Button1)

        Else
            modControlBehavior.EnableControls(Me, True)
            EditMode = True
            If gRole <> "Admin" Then
                txtUserId.Enabled = False
                txtRole.Enabled = False
            End If
        End If
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
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
        modControlBehavior.EnableControls(Me, False)
        ControlMaintenance.ClearInputControls(Me)
        EditMode = False
        If gRole <> "Admin" Then
            cmdAdd.Enabled = False
            cmdDelete.Enabled = False
        End If
    End Sub

    Private Sub cmdSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If (MessageBox.Show("Are you sure you want to Save this Entry?", "Confirm Saving", _
              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)) _
              = DialogResult.Yes Then

            Dim Params(0) As String
            Params(0) = txtRowid.Text
            'added-DBrion  --v
            If Trim(txtUserId.Text) = "" Or Trim(txtUserName.Text) = "" Then
                MessageBox.Show("Main fields are mandatory")
                If Trim(txtUserId.Text) = "" Then
                    txtUserId.Select()
                End If
                If Trim(txtUserName.Text) = "" Then
                    txtUserName.Select()
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
            If gRole <> "Admin" Then
                cmdAdd.Enabled = False
                cmdDelete.Enabled = False
            End If
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Sub_Insert()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(6) As SqlParameter
        Dim UserId As New SqlParameter("@UserId", SqlDbType.VarChar, 10)
        UserId.Direction = ParameterDirection.Input
        UserId.Value = Trim(txtUserId.Text)
        Params(0) = UserId
        Dim UserName As New SqlParameter("@UserName", SqlDbType.VarChar, 60)
        UserName.Direction = ParameterDirection.Input
        UserName.Value = Trim(txtUserName.Text)
        Params(1) = UserName
        Dim Password As New SqlParameter("@Password", SqlDbType.VarChar, 15)
        Password.Direction = ParameterDirection.Input
        Password.Value = Trim(txtPassword.Text)
        Params(2) = Password
        Dim Role As New SqlParameter("@Role", SqlDbType.VarChar, 6)
        Role.Direction = ParameterDirection.Input
        Role.Value = Trim(txtRole.Text)
        Params(3) = Role
        Dim CreateDate As New SqlParameter("@CreateDate", SqlDbType.DateTime, 10)
        CreateDate.Direction = ParameterDirection.Input
        CreateDate.Value = GetDateTimeNow("MM/dd/yyyy")
        Params(4) = CreateDate
        Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime, 10)
        UpdateDate.Direction = ParameterDirection.Input
        UpdateDate.Value = GetDateTimeNow("MM/dd/yyyy")
        Params(5) = UpdateDate
        Dim Encoder As New SqlParameter("@Encoder", SqlDbType.VarChar, 10)
        Encoder.Direction = ParameterDirection.Input
        Encoder.Value = Trim(gUserID)
        Params(6) = Encoder
        Try
            BusinessObject.Sub_Insert(ServerPath2, "UserTabCT_Insert", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Sub_Update()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(5) As SqlParameter
        Dim UserId As New SqlParameter("@UserId", SqlDbType.VarChar, 10)
        UserId.Direction = ParameterDirection.Input
        UserId.Value = Trim(txtUserId.Text)
        Params(0) = UserId
        Dim UserName As New SqlParameter("@UserName", SqlDbType.VarChar, 60)
        UserName.Direction = ParameterDirection.Input
        UserName.Value = Trim(txtUserName.Text)
        Params(1) = UserName
        Dim Password As New SqlParameter("@Password", SqlDbType.VarChar, 15)
        Password.Direction = ParameterDirection.Input
        Password.Value = Trim(txtPassword.Text)
        Params(2) = Password
        Dim Role As New SqlParameter("@Role", SqlDbType.VarChar, 6)
        Role.Direction = ParameterDirection.Input
        Role.Value = Trim(txtRole.Text)
        Params(3) = Role
        Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime, 10)
        UpdateDate.Direction = ParameterDirection.Input
        UpdateDate.Value = GetDateTimeNow("MM/dd/yyyy")
        Params(4) = UpdateDate
        Dim Encoder As New SqlParameter("@Encoder", SqlDbType.VarChar, 10)
        Encoder.Direction = ParameterDirection.Input
        Encoder.Value = Trim(gUserID)
        Params(5) = Encoder
        Try
            BusinessObject.Sub_Insert(ServerPath2, "UserTabCT_Update", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Sub_Show()
        If RemoteDataSet2.UserTabCT_Show.Count > 0 Then RemoteDataSet2.UserTabCT_Show.Clear()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "UserTabCT_Show", CommandType.StoredProcedure, RemoteDataSet2, "UserTabCT_Show")
        DataGrid1.DataSource = RemoteDataSet2.UserTabCT_Show
    End Sub

    Private Sub Sub_Select(ByVal dbParams() As String, ByVal UpdateMode As String)
        'select case if add,edit or delete
        Dim i As Integer
        Dim myRowid As Integer
        Select Case UpdateMode
            Case "Insert"
                Dim BusinessObject As New BusinessLayer.clsFileMaintenance
                myRowid = CInt(BusinessObject.Sub_ReturnIntegerResult(ServerPath2, "UserTabCT_GetInsertedRowid", CommandType.StoredProcedure))
            Case "Update"
                myRowid = CInt(dbParams(0))
        End Select
        For i = 0 To (RemoteDataSet2.UserTabCT_Show.Rows.Count - 1)
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
        Dim UserID As New SqlParameter("@UserID", SqlDbType.VarChar, 3) '<v-- changed form Rowid to Divcode
        UserID.Direction = ParameterDirection.Input
        UserID.Value = Trim(txtUserId.Text)
        Pram(0) = UserID                                               '<^-- changed form Rowid to Divcode
        Try
            BusinessObject.Sub_Delete(ServerPath2, "UserTabCT_Delete", CommandType.StoredProcedure, Pram)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGrid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.Click, DataGrid1.CurrentCellChanged
        With DataGrid1
            txtRowid.Text = .Item(.CurrentCell.RowNumber, 0).ToString       '<-added".ToString"-DBrion
            txtUserId.Text = .Item(.CurrentCell.RowNumber, 1).ToString        '<-added".ToString"-DBrion
            txtUserName.Text = .Item(.CurrentCell.RowNumber, 2).ToString '<-added".ToString"-DBrion
            'added-DBrion --v
            oldDs = Trim(txtUserName.Text)
            txtPassword.Text = .Item(.CurrentCell.RowNumber, 3).ToString
            txtRole.Text = .Item(.CurrentCell.RowNumber, 4).ToString
            .Select(.CurrentCell.RowNumber)
        End With
    End Sub

    Private Sub frmUserMaint_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        modControlBehavior.EnableControls(Me, False)
        If Trim(gRole) <> "Admin" Then
            cmdAdd.Enabled = False
            cmdDelete.Enabled = False
        End If
    End Sub
End Class
