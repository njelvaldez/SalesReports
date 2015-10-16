Imports System.Data.SqlClient

Public Class QPIareacode
    Inherits System.Windows.Forms.Form
    Private RemoteDataSet As New CodeTablesDS
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
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblCreateDate As System.Windows.Forms.Label
    Friend WithEvents lblUpdateDate As System.Windows.Forms.Label
    Friend WithEvents txtRowid As System.Windows.Forms.TextBox
    Friend WithEvents TxtLastUser As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents QPIaCode As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents QPIaName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents CreateDate As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents UpdateDate As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
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
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.QPIaCode = New System.Windows.Forms.DataGridTextBoxColumn
        Me.QPIaName = New System.Windows.Forms.DataGridTextBoxColumn
        Me.CreateDate = New System.Windows.Forms.DataGridTextBoxColumn
        Me.UpdateDate = New System.Windows.Forms.DataGridTextBoxColumn
        Me.txtRowid = New System.Windows.Forms.TextBox
        Me.TxtLastUser = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(0, 303)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Code - Description"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(26, 337)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Create Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(304, 337)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Update Date"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCode
        '
        Me.txtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Location = New System.Drawing.Point(101, 303)
        Me.txtCode.MaxLength = 3
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(84, 20)
        Me.txtCode.TabIndex = 1
        Me.txtCode.Tag = "Input"
        Me.txtCode.Text = ""
        '
        'txtDescription
        '
        Me.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescription.Location = New System.Drawing.Point(193, 303)
        Me.txtDescription.MaxLength = 50
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(310, 20)
        Me.txtDescription.TabIndex = 2
        Me.txtDescription.Tag = "Input"
        Me.txtDescription.Text = ""
        '
        'lblCreateDate
        '
        Me.lblCreateDate.BackColor = System.Drawing.SystemColors.Info
        Me.lblCreateDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCreateDate.Location = New System.Drawing.Point(101, 337)
        Me.lblCreateDate.Name = "lblCreateDate"
        Me.lblCreateDate.Size = New System.Drawing.Size(121, 20)
        Me.lblCreateDate.TabIndex = 6
        Me.lblCreateDate.Tag = "Input"
        '
        'lblUpdateDate
        '
        Me.lblUpdateDate.BackColor = System.Drawing.SystemColors.Info
        Me.lblUpdateDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUpdateDate.Location = New System.Drawing.Point(379, 337)
        Me.lblUpdateDate.Name = "lblUpdateDate"
        Me.lblUpdateDate.Size = New System.Drawing.Size(121, 20)
        Me.lblUpdateDate.TabIndex = 7
        Me.lblUpdateDate.Tag = "Input"
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(241, 370)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.TabIndex = 11
        Me.cmdExit.Tag = "Exit"
        Me.cmdExit.Text = "Exit"
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(10, 370)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.TabIndex = 8
        Me.cmdAdd.Tag = "Add"
        Me.cmdAdd.Text = "Add"
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(87, 370)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.TabIndex = 9
        Me.cmdEdit.Tag = "Edit"
        Me.cmdEdit.Text = "Edit"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(87, 370)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.TabIndex = 41
        Me.cmdCancel.Tag = "Cancel"
        Me.cmdCancel.Text = "Cancel"
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(164, 370)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.TabIndex = 10
        Me.cmdDelete.Tag = "Delete"
        Me.cmdDelete.Text = "Delete"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(164, 370)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.TabIndex = 40
        Me.cmdSave.Tag = "Save"
        Me.cmdSave.Text = "Save"
        '
        'DataGrid1
        '
        Me.DataGrid1.AlternatingBackColor = System.Drawing.SystemColors.ScrollBar
        Me.DataGrid1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 8)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(496, 286)
        Me.DataGrid1.TabIndex = 0
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.DataGrid1.Tag = "View"
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.PaleTurquoise
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightCyan
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.QPIaCode, Me.QPIaName, Me.CreateDate, Me.UpdateDate})
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.AntiqueWhite
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "QPIAC_Show"
        Me.DataGridTableStyle1.ReadOnly = True
        '
        'QPIaCode
        '
        Me.QPIaCode.Format = ""
        Me.QPIaCode.FormatInfo = Nothing
        Me.QPIaCode.HeaderText = "Code"
        Me.QPIaCode.MappingName = "areacode"
        Me.QPIaCode.NullText = ""
        Me.QPIaCode.Width = 75
        '
        'QPIaName
        '
        Me.QPIaName.Format = ""
        Me.QPIaName.FormatInfo = Nothing
        Me.QPIaName.HeaderText = "Name"
        Me.QPIaName.MappingName = "areaname"
        Me.QPIaName.NullText = ""
        Me.QPIaName.ReadOnly = True
        Me.QPIaName.Width = 250
        '
        'CreateDate
        '
        Me.CreateDate.Format = "MM/dd/yyyy"
        Me.CreateDate.FormatInfo = Nothing
        Me.CreateDate.HeaderText = "CreateDate"
        Me.CreateDate.MappingName = "CreateDate"
        Me.CreateDate.NullText = ""
        Me.CreateDate.Width = 65
        '
        'UpdateDate
        '
        Me.UpdateDate.Format = "MM/dd/yyyy"
        Me.UpdateDate.FormatInfo = Nothing
        Me.UpdateDate.HeaderText = "UpdateDate"
        Me.UpdateDate.MappingName = "UpdateDate"
        Me.UpdateDate.NullText = ""
        Me.UpdateDate.ReadOnly = True
        Me.UpdateDate.Width = 65
        '
        'txtRowid
        '
        Me.txtRowid.Location = New System.Drawing.Point(384, 571)
        Me.txtRowid.Name = "txtRowid"
        Me.txtRowid.Size = New System.Drawing.Size(64, 20)
        Me.txtRowid.TabIndex = 43
        Me.txtRowid.Tag = "Input"
        Me.txtRowid.Text = ""
        '
        'TxtLastUser
        '
        Me.TxtLastUser.Location = New System.Drawing.Point(456, 571)
        Me.TxtLastUser.Name = "TxtLastUser"
        Me.TxtLastUser.Size = New System.Drawing.Size(64, 20)
        Me.TxtLastUser.TabIndex = 49
        Me.TxtLastUser.Tag = "Input"
        Me.TxtLastUser.Text = ""
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Location = New System.Drawing.Point(9, 364)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(495, 2)
        Me.Label9.TabIndex = 54
        '
        'Label12
        '
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(322, 385)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(184, 14)
        Me.Label12.TabIndex = 63
        Me.Label12.Text = "ex.  ""112595"" = ""Nov.25,1995"""
        '
        'Label11
        '
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(322, 369)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(192, 14)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "Easy Date Format Entry: ""MMDDYY"""
        '
        'QPIareacode
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(509, 404)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtLastUser)
        Me.Controls.Add(Me.txtRowid)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtCode)
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
        Me.Name = "QPIareacode"
        Me.Text = "QPI Area Code"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        modControlBehavior.EnableControls(Me, True)
        ControlMaintenance.ClearInputControls(Me)
        EditMode = False
        'added-DBrion --v
        btnSw = True
        lblCreateDate.Text = GetDateTimeNow("MM/dd/yyyy")
        lblUpdateDate.Text = GetDateTimeNow("MM/dd/yyyy")
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
            btnSw = True
            lblUpdateDate.Text = GetDateTimeNow("MM/dd/yyyy")
            txtCode.Enabled = False
            txtCode.BackColor = BackColor.White
            txtCode.ForeColor = BackColor.Black
            txtDescription.Select()
            txtDescription.SelectAll()
            'added-DBrion --^   
        End If
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If txtCode.Text > "" Then
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
        txtCode.Enabled = True
        txtCode.BackColor = Color.White
        txtCode.ForeColor = Color.Black
        'added-DBrion --^
        modControlBehavior.EnableControls(Me, False)
        ControlMaintenance.ClearInputControls(Me)
        EditMode = False
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If (MessageBox.Show("Are you sure you want to Save this Entry?", "Confirm Saving", _
              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)) _
              = DialogResult.Yes Then

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
            'Sub_Select(Params, CStr(IIf(EditMode = False, "Insert", "Update")))
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
        Dim Params(3) As SqlParameter
        Dim AreaCode As New SqlParameter("@AreaCode", SqlDbType.VarChar, 25)
        AreaCode.Direction = ParameterDirection.Input
        AreaCode.Value = Trim(txtCode.Text)
        Params(0) = AreaCode
        Dim AreaName As New SqlParameter("@AreaName", SqlDbType.VarChar, 50)
        AreaName.Direction = ParameterDirection.Input
        AreaName.Value = Trim(txtDescription.Text)
        Params(1) = AreaName
        Dim CreateDate As New SqlParameter("@CreateDate", SqlDbType.DateTime, 10)
        CreateDate.Direction = ParameterDirection.Input
        CreateDate.Value = GetDateTimeNow()
        Params(2) = CreateDate
        Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime, 10)
        UpdateDate.Direction = ParameterDirection.Input
        UpdateDate.Value = GetDateTimeNow()
        Params(3) = UpdateDate
        Try
            BusinessObject.Sub_Insert(ServerPath2, "QPIAC_Insert", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Sub_Update()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(2) As SqlParameter
        Dim AreaCode As New SqlParameter("@AreaCode", SqlDbType.VarChar, 25)
        AreaCode.Direction = ParameterDirection.Input
        AreaCode.Value = Trim(txtCode.Text)
        Params(0) = AreaCode
        Dim AreaName As New SqlParameter("@AreaName", SqlDbType.VarChar, 50)
        AreaName.Direction = ParameterDirection.Input
        AreaName.Value = Trim(txtDescription.Text)
        Params(1) = AreaName
        Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime, 10)
        UpdateDate.Direction = ParameterDirection.Input
        UpdateDate.Value = GetDateTimeNow()
        Params(2) = UpdateDate
        Try
            BusinessObject.Sub_Update(ServerPath2, "QPIAC_Update", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Sub_Show()
        If RemoteDataSet.QPIAC_Show.Count > 0 Then RemoteDataSet.QPIAC_Show.Clear()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "QPIAC_Show", CommandType.StoredProcedure, RemoteDataSet, "QPIAC_Show")
        DataGrid1.DataSource = RemoteDataSet.QPIAC_Show
    End Sub

    Private Sub Sub_Select(ByVal dbParams() As String, ByVal UpdateMode As String)
        'select case if add,edit or delete
        Dim i As Integer
        Dim myRowid As Integer
        Select Case UpdateMode
            Case "Insert"
                Dim BusinessObject As New BusinessLayer.clsFileMaintenance
                myRowid = CInt(BusinessObject.Sub_ReturnIntegerResult(ServerPath2, "QPIAC_GetInsertedRowid", CommandType.StoredProcedure))
            Case "Update"
                myRowid = CInt(dbParams(0))
        End Select
        For i = 0 To (RemoteDataSet.QPIAC_Show.Rows.Count - 1)
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
        Dim AreaCode As New SqlParameter("@AreaCode", SqlDbType.VarChar, 3) '<v-- changed form Rowid to Divcode
        AreaCode.Direction = ParameterDirection.Input
        AreaCode.Value = Trim(txtCode.Text)
        Pram(0) = AreaCode                                               '<^-- changed form Rowid to Divcode
        Try
            BusinessObject.Sub_Delete(ServerPath2, "QPIAC_Delete", CommandType.StoredProcedure, Pram)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub QPIareacode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        modControlBehavior.EnableControls(Me, False)
        btnSw = False    '<-- added-DBrion
        tmpSD = ""
        tmpED = ""
    End Sub
    
    Private Sub DataGrid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.Click, DataGrid1.CurrentCellChanged
        With DataGrid1
            txtCode.Text = .Item(.CurrentCell.RowNumber, 0).ToString       '<-added".ToString"-DBrion
            txtDescription.Text = .Item(.CurrentCell.RowNumber, 1).ToString        '<-added".ToString"-DBrion
            If Trim(.Item(.CurrentCell.RowNumber, 2).ToString) <> "" Then
                lblCreateDate.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 2).ToString), "MM/dd/yyyy")
            Else                         'formatted the date to be shown
                lblCreateDate.Text = ""
            End If
            If Trim(.Item(.CurrentCell.RowNumber, 3).ToString) <> "" Then
                lblUpdateDate.Text = Format(CDate(.Item(.CurrentCell.RowNumber, 3).ToString), "MM/dd/yyyy")
            Else
                lblUpdateDate.Text = ""
            End If
            .Select(.CurrentCell.RowNumber)
        End With
    End Sub
    'added-DBrion --v
    Private Sub txtCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCode.Validating
        On Error GoTo errM
        Dim s As String
        If Trim(txtCode.Text) = "" Then
            txtDescription.Select()
            Exit Sub
        End If
        If btnSw = True And EditMode = False Then
            s = "select areaname from qpiareacode where areacode = '" & Trim(txtCode.Text) & "' "
            If (Existing(s)) = True Then
                MessageBox.Show("This QPI Area Code already exist! Please try again.", "Area Code Exsists!")
                e.Cancel() = True
                txtCode.Clear()
            End If
        End If
errM:
    End Sub

    Private Sub txtDescription_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescription.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtDescription_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDescription.Validating
        On Error GoTo errM
        Dim s As String
        Dim tst As Boolean
        If Trim(txtDescription.Text) = "" Then
            txtCode.Select()
            Exit Sub
        End If
        If btnSw = True And Trim(txtDescription.Text) <> Trim(oldDs) Then
            s = "select areacode from qpiareacode where areaname = '" & Trim(txtDescription.Text) & "' "
            If (Existing(s)) = True Then
                MessageBox.Show("This QPI Area Name already exist! Please try again.", "Area Name Exsists!")
                e.Cancel = True
                txtDescription.Clear()
            End If
        End If
errM:
    End Sub
    'added-DBrion --^
End Class