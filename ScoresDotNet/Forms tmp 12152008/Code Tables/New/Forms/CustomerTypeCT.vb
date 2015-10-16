Imports System.Data.SqlClient
Public Class CustomerTypeCT
    Inherits System.Windows.Forms.Form
    Private RemoteDataSet As New CustomerType
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
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblCreateDate As System.Windows.Forms.Label
    Friend WithEvents lblUpdateDate As System.Windows.Forms.Label
    Friend WithEvents txtRowid As System.Windows.Forms.TextBox
    Friend WithEvents cboIMSclass As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtLastUser As System.Windows.Forms.TextBox
    Friend WithEvents SqlValue As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.lblCreateDate = New System.Windows.Forms.Label
        Me.lblUpdateDate = New System.Windows.Forms.Label
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.txtRowid = New System.Windows.Forms.TextBox
        Me.cboIMSclass = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtLastUser = New System.Windows.Forms.TextBox
        Me.SqlValue = New System.Windows.Forms.ComboBox
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(3, 336)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Code"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(168, 336)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Description"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(163, 398)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Create Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(369, 398)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Update Date"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.SystemColors.Info
        Me.txtCode.Location = New System.Drawing.Point(40, 336)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(112, 20)
        Me.txtCode.TabIndex = 4
        Me.txtCode.Tag = "Input"
        Me.txtCode.Text = ""
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(236, 336)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(329, 20)
        Me.txtDescription.TabIndex = 0
        Me.txtDescription.Tag = "Input"
        Me.txtDescription.Text = ""
        '
        'lblCreateDate
        '
        Me.lblCreateDate.BackColor = System.Drawing.SystemColors.Info
        Me.lblCreateDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCreateDate.Location = New System.Drawing.Point(236, 398)
        Me.lblCreateDate.Name = "lblCreateDate"
        Me.lblCreateDate.Size = New System.Drawing.Size(121, 20)
        Me.lblCreateDate.TabIndex = 6
        Me.lblCreateDate.Tag = "Input"
        '
        'lblUpdateDate
        '
        Me.lblUpdateDate.BackColor = System.Drawing.SystemColors.Info
        Me.lblUpdateDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUpdateDate.Location = New System.Drawing.Point(443, 398)
        Me.lblUpdateDate.Name = "lblUpdateDate"
        Me.lblUpdateDate.Size = New System.Drawing.Size(121, 20)
        Me.lblUpdateDate.TabIndex = 7
        Me.lblUpdateDate.Tag = "Input"
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(480, 438)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.TabIndex = 5
        Me.cmdExit.Tag = "Exit"
        Me.cmdExit.Text = "Exit"
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(240, 438)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.TabIndex = 2
        Me.cmdAdd.Tag = "Add"
        Me.cmdAdd.Text = "Add"
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(320, 438)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.TabIndex = 3
        Me.cmdEdit.Tag = "Edit"
        Me.cmdEdit.Text = "Edit"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(320, 438)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.TabIndex = 6
        Me.cmdCancel.Tag = "Cancel"
        Me.cmdCancel.Text = "Cancel"
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(400, 438)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.TabIndex = 4
        Me.cmdDelete.Tag = "Delete"
        Me.cmdDelete.Text = "Delete"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(400, 438)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.TabIndex = 7
        Me.cmdSave.Tag = "Save"
        Me.cmdSave.Text = "Save"
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 8)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(560, 320)
        Me.DataGrid1.TabIndex = 42
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.DataGrid1.Tag = "View"
        '
        'txtRowid
        '
        Me.txtRowid.Location = New System.Drawing.Point(86, 391)
        Me.txtRowid.Name = "txtRowid"
        Me.txtRowid.Size = New System.Drawing.Size(13, 20)
        Me.txtRowid.TabIndex = 43
        Me.txtRowid.Tag = "Input"
        Me.txtRowid.Text = ""
        Me.txtRowid.Visible = False
        '
        'cboIMSclass
        '
        Me.cboIMSclass.Items.AddRange(New Object() {"", "Dispensing MDs and Clinics", "Drug Store", "Hospital - Government", "Hospital - Private", "Industrials, Govt Agencies, LGUs and Others"})
        Me.cboIMSclass.Location = New System.Drawing.Point(236, 366)
        Me.cboIMSclass.MaxLength = 55
        Me.cboIMSclass.Name = "cboIMSclass"
        Me.cboIMSclass.Size = New System.Drawing.Size(329, 21)
        Me.cboIMSclass.TabIndex = 1
        Me.cboIMSclass.Tag = "Input"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(167, 366)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 20)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "IMS Class"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(8, 429)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(556, 2)
        Me.Label6.TabIndex = 46
        '
        'TxtLastUser
        '
        Me.TxtLastUser.Location = New System.Drawing.Point(108, 392)
        Me.TxtLastUser.Name = "TxtLastUser"
        Me.TxtLastUser.Size = New System.Drawing.Size(33, 20)
        Me.TxtLastUser.TabIndex = 47
        Me.TxtLastUser.Tag = "Input"
        Me.TxtLastUser.Text = ""
        Me.TxtLastUser.Visible = False
        '
        'SqlValue
        '
        Me.SqlValue.Location = New System.Drawing.Point(25, 438)
        Me.SqlValue.Name = "SqlValue"
        Me.SqlValue.Size = New System.Drawing.Size(146, 21)
        Me.SqlValue.TabIndex = 50
        Me.SqlValue.Visible = False
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "CustomerTypeCT_Show"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.MappingName = "rowid"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Code"
        Me.DataGridTextBoxColumn2.MappingName = "typecode"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Description"
        Me.DataGridTextBoxColumn3.MappingName = "typedesc"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 200
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "IMS Class"
        Me.DataGridTextBoxColumn4.MappingName = "imsclass"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 80
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Create Date"
        Me.DataGridTextBoxColumn5.MappingName = "createdate"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 70
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = "MM/dd/yyyy"
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Update Date"
        Me.DataGridTextBoxColumn6.MappingName = "updatedate"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 70
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Encoder"
        Me.DataGridTextBoxColumn7.MappingName = "lastuser"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 75
        '
        'CustomerTypeCT
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(574, 467)
        Me.Controls.Add(Me.SqlValue)
        Me.Controls.Add(Me.TxtLastUser)
        Me.Controls.Add(Me.txtRowid)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboIMSclass)
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
        Me.Name = "CustomerTypeCT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Customer Type"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        modControlBehavior.EnableControls(Me, True)
        ControlMaintenance.ClearInputControls(Me)
        EditMode = False
        btnSw = True
        z = "SELECT MAX(CONVERT(int, TypeCode)) FROM NewScores..CustType"
        z = FindValue(z).ToString
        z = Str(jVal(z) + 1)
        txtCode.Text = z
        lblCreateDate.Text = GetDateTimeNow("MM/dd/yyyy")
        lblUpdateDate.Text = GetDateTimeNow("MM/dd/yyyy")
        txtDescription.Select()
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If txtCode.Text = "" And txtDescription.Text = "" Then
            MessageBox.Show("Please select a record to modify!", "Record Selection", MessageBoxButtons.OK, _
            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            modControlBehavior.EnableControls(Me, True)
            EditMode = True
            btnSw = True
            lblUpdateDate.Text = GetDateTimeNow("MM/dd/yyyy")
            txtDescription.Select()
        End If
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If txtRowid.Text > "" Then
            If (MessageBox.Show("Do you really want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, _
            MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then
                Sub_Delete()
                ControlMaintenance.ClearInputControls(Me)
                Sub_Show()
            End If
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        btnSw = False
        modControlBehavior.EnableControls(Me, False)
        ControlMaintenance.ClearInputControls(Me)
        EditMode = False
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim Params(0) As String
        Params(0) = txtRowid.Text
        TxtLastUser.Text = gCurrUser
        If EditMode = False Then
            Sub_Insert()
        Else
            Sub_Update()
        End If
        DataGrid1.DataSource = Nothing
        Sub_Show()
        Sub_Select(Params, CStr(IIf(EditMode = False, "Insert", "Update")))
        EditMode = False
        modControlBehavior.EnableControls(Me, False)
    End Sub

    Private Sub Sub_Insert()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(5) As SqlParameter

        Dim TypeCode As New SqlParameter("@TypeCode", SqlDbType.VarChar, 10)
        TypeCode.Direction = ParameterDirection.Input
        TypeCode.Value = txtCode.Text
        Params(0) = TypeCode

        Dim TypeDesc As New SqlParameter("@TypeDesc", SqlDbType.VarChar, 50)
        TypeDesc.Direction = ParameterDirection.Input
        TypeDesc.Value = txtDescription.Text
        Params(1) = TypeDesc

        Dim IMSclass As New SqlParameter("@IMSclass", SqlDbType.VarChar, 50)
        IMSclass.Direction = ParameterDirection.Input
        IMSclass.Value = cboIMSclass.Text
        Params(2) = IMSclass

        Dim CreateDate As New SqlParameter("@CreateDate", SqlDbType.DateTime, 10)
        CreateDate.Direction = ParameterDirection.Input
        CreateDate.Value = Now()
        Params(3) = CreateDate

        Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime, 10)
        UpdateDate.Direction = ParameterDirection.Input
        UpdateDate.Value = Now()
        Params(4) = UpdateDate

        Dim LastUser As New SqlParameter("@LastUser", SqlDbType.VarChar, 8)
        LastUser.Direction = ParameterDirection.Input
        LastUser.Value = IIf(Trim(gCurrUser) = "", "", gCurrUser)     ' TxtLastUser.Text
        Params(5) = LastUser

        BusinessObject.Sub_Insert(ServerPath2, "CustomerTypeCT_Insert", CommandType.StoredProcedure, Params)
    End Sub

    Private Sub Sub_Update()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(4) As SqlParameter

        Dim TypeCode As New SqlParameter("@TypeCode", SqlDbType.VarChar, 10)
        TypeCode.Direction = ParameterDirection.Input
        TypeCode.Value = txtCode.Text
        Params(0) = TypeCode

        Dim TypeDesc As New SqlParameter("@TypeDesc", SqlDbType.VarChar, 50)
        TypeDesc.Direction = ParameterDirection.Input
        TypeDesc.Value = txtDescription.Text
        Params(1) = TypeDesc

        Dim IMSclass As New SqlParameter("@IMSclass", SqlDbType.VarChar, 50)
        IMSclass.Direction = ParameterDirection.Input
        IMSclass.Value = cboIMSclass.Text
        Params(2) = IMSclass

        Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime, 10)
        UpdateDate.Direction = ParameterDirection.Input
        UpdateDate.Value = Now()
        Params(3) = UpdateDate

        Dim LastUser As New SqlParameter("@LastUser", SqlDbType.VarChar, 8)
        LastUser.Direction = ParameterDirection.Input
        LastUser.Value = IIf(Trim(gCurrUser) = "", "", gCurrUser)     ' TxtLastUser.Text
        Params(4) = LastUser

        Try
            BusinessObject.Sub_Update(ServerPath2, "CustomerTypeCT_Update", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Sub_Show()
        If RemoteDataSet.CustomerTypeCT_Show.Count > 0 Then RemoteDataSet.CustomerTypeCT_Show.Clear()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance

        BusinessObject.Sub_Show(ServerPath2, "CustomerTypeCT_Show", CommandType.StoredProcedure, RemoteDataSet, "CustomerTypeCT_Show")
        DataGrid1.DataSource = RemoteDataSet.CustomerTypeCT_Show
    End Sub

    Private Sub Sub_Select(ByVal dbParams() As String, ByVal UpdateMode As String)
        'select case if add,edit or delete
        Dim i As Integer
        Dim myRowid As Integer
        Select Case UpdateMode
            Case "Insert"
                Dim BusinessObject As New BusinessLayer.clsFileMaintenance
                myRowid = CInt(BusinessObject.Sub_ReturnIntegerResult(ServerPath2, "CustomerTypeCT_GetInsertedRowid", CommandType.StoredProcedure))
            Case "Update"
                myRowid = CInt(dbParams(0))
        End Select
        For i = 0 To (RemoteDataSet.CustomerTypeCT_Show.Rows.Count - 1)
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

        Dim TypeCode As New SqlParameter("@TypeCode", SqlDbType.VarChar, 10)
        TypeCode.Direction = ParameterDirection.Input
        TypeCode.Value = txtCode.Text
        Params(0) = TypeCode

        BusinessObject.Sub_Delete(ServerPath2, "CustomerTypeCT_Delete", CommandType.StoredProcedure, Params)
    End Sub

    Private Sub CustomerTypeCT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        modControlBehavior.EnableControls(Me, False)
        btnSw = False
        TxtLastUser.Text = gCurrUser
    End Sub

    Private Sub DataGrid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.Click, DataGrid1.CurrentCellChanged
        With DataGrid1
            txtRowid.Text = .Item(.CurrentCell.RowNumber, 0).ToString
            txtCode.Text = .Item(.CurrentCell.RowNumber, 1).ToString
            txtDescription.Text = .Item(.CurrentCell.RowNumber, 2).ToString
            oldDs = Trim(txtDescription.Text)
            cboIMSclass.Text = .Item(.CurrentCell.RowNumber, 3).ToString
            lblCreateDate.Text = .Item(.CurrentCell.RowNumber, 4).ToString
            lblUpdateDate.Text = .Item(.CurrentCell.RowNumber, 5).ToString
            TxtLastUser.Text = .Item(.CurrentCell.RowNumber, 6).ToString
            .Select(.CurrentCell.RowNumber)
        End With
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

            s = "select typecode as fld1 from NewScores..CustType where typedesc = '" & Trim(txtDescription.Text) & "' "
            Dim SQLstmnt As New SqlParameter("@SqlQry", SqlDbType.NVarChar, 2950)
            SQLstmnt.Direction = ParameterDirection.Input
            SQLstmnt.Value = s
            Params(0) = SQLstmnt
            Try
                BusinessObject.Sub_Show(ServerPath2, "GenericQryProc", CommandType.StoredProcedure, RemoteDataSet2, "GenericQryProc", Params)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            SqlValue.DataSource = RemoteDataSet2.GenericQryProc
            SqlValue.DisplayMember = "fld1"
            If Trim(SqlValue.Text) <> "" Then
                MessageBox.Show("This Customer Type Description already exist! Please try again.", "Description Exsists!")
                e.Cancel = True
                txtDescription.Clear()
            End If
            SqlValue.ResetText()
            SqlValue.DataSource = Nothing
            RemoteDataSet2.GenericQryProc.Clear()
        End If
    End Sub

    Private Sub cboIMSclass_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboIMSclass.KeyUp
        If e.KeyData.ToString = System.Windows.Forms.Keys.Up.ToString _
           Or e.KeyData.ToString = System.Windows.Forms.Keys.Left.ToString Then 'if key pressed is the up arrow it will select the next selection before the selction
            cboIMSclass.SelectedItem = cboIMSclass.SelectedIndex - 1
        ElseIf e.KeyData.ToString = System.Windows.Forms.Keys.Down.ToString _
           Or e.KeyData.ToString = System.Windows.Forms.Keys.Right.ToString Then 'if key pressed is the up arrow it will select the next selection after the selction
            cboIMSclass.SelectedItem = cboIMSclass.SelectedIndex + 1
        ElseIf DKcodes(e.KeyData) = True Then    'checking if the key pressed is alphanumeric (to disallow typing the entry)
            cboIMSclass.Text = ""     'if alphanumeric then the value of the field will be erased
        End If
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")    'moves control to the next control or field
        End If
    End Sub

    Private Sub cboIMSclass_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboIMSclass.Validating
        If Trim(cboIMSclass.Text) = "" Then    'tests if entry is blank
            MessageBox.Show("Mandatory field!", "Critical!")  'gives message to put value
            e.Cancel() = True                  ' brings back the focus on this control/field
        End If
    End Sub
End Class
