Imports Microsoft
Imports System.Data.SqlClient
Public Class frmQpiTerritoryAssignment_Modify
    Inherits System.Windows.Forms.Form
    Dim RemoteDataSet As New dsQpi_AreaAssign
    Private EditMode As Boolean = False

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Load_Medreps()
        Load_Territories()
        Load_Grid()
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
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents txtRowid As System.Windows.Forms.TextBox
    Friend WithEvents dtEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboTerritory As System.Windows.Forms.ComboBox
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents cboMedrep As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.txtRowid = New System.Windows.Forms.TextBox
        Me.dtEnd = New System.Windows.Forms.DateTimePicker
        Me.dtStart = New System.Windows.Forms.DateTimePicker
        Me.cboTerritory = New System.Windows.Forms.ComboBox
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cboMedrep = New System.Windows.Forms.ComboBox
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(597, 280)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.TabIndex = 62
        Me.cmdDelete.Tag = "Delete"
        Me.cmdDelete.Text = "Delete"
        '
        'txtRowid
        '
        Me.txtRowid.Location = New System.Drawing.Point(16, 280)
        Me.txtRowid.Name = "txtRowid"
        Me.txtRowid.Size = New System.Drawing.Size(16, 20)
        Me.txtRowid.TabIndex = 60
        Me.txtRowid.Tag = "Input"
        Me.txtRowid.Text = ""
        Me.txtRowid.Visible = False
        '
        'dtEnd
        '
        Me.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtEnd.Location = New System.Drawing.Point(560, 256)
        Me.dtEnd.Name = "dtEnd"
        Me.dtEnd.Size = New System.Drawing.Size(112, 20)
        Me.dtEnd.TabIndex = 59
        Me.dtEnd.Tag = "Input"
        '
        'dtStart
        '
        Me.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtStart.Location = New System.Drawing.Point(448, 256)
        Me.dtStart.Name = "dtStart"
        Me.dtStart.Size = New System.Drawing.Size(112, 20)
        Me.dtStart.TabIndex = 58
        Me.dtStart.Tag = "Input"
        '
        'cboTerritory
        '
        Me.cboTerritory.Location = New System.Drawing.Point(232, 256)
        Me.cboTerritory.Name = "cboTerritory"
        Me.cboTerritory.Size = New System.Drawing.Size(216, 21)
        Me.cboTerritory.TabIndex = 57
        Me.cboTerritory.Tag = "Input"
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(16, 8)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(656, 240)
        Me.DataGrid1.TabIndex = 55
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.DataGrid1.Tag = "View"
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "QpiAreaAssign_TableShow"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.MappingName = "Rowid"
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Medrep"
        Me.DataGridTextBoxColumn2.MappingName = "medrep"
        Me.DataGridTextBoxColumn2.Width = 225
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Territory"
        Me.DataGridTextBoxColumn3.MappingName = "territorydesc"
        Me.DataGridTextBoxColumn3.Width = 225
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Start Date"
        Me.DataGridTextBoxColumn4.MappingName = "startdate"
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "End Date"
        Me.DataGridTextBoxColumn5.MappingName = "enddate"
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(520, 280)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.TabIndex = 61
        Me.cmdEdit.Tag = "Edit"
        Me.cmdEdit.Text = "Edit"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(597, 280)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.TabIndex = 64
        Me.cmdSave.Tag = "Save"
        Me.cmdSave.Text = "Save"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(520, 280)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.TabIndex = 63
        Me.cmdCancel.Tag = "Cancel"
        Me.cmdCancel.Text = "Cancel"
        '
        'cboMedrep
        '
        Me.cboMedrep.Location = New System.Drawing.Point(16, 256)
        Me.cboMedrep.Name = "cboMedrep"
        Me.cboMedrep.Size = New System.Drawing.Size(216, 21)
        Me.cboMedrep.TabIndex = 65
        Me.cboMedrep.Tag = "Input"
        '
        'frmQpiTerritoryAssignment_Modify
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(678, 308)
        Me.Controls.Add(Me.cboMedrep)
        Me.Controls.Add(Me.txtRowid)
        Me.Controls.Add(Me.dtEnd)
        Me.Controls.Add(Me.dtStart)
        Me.Controls.Add(Me.cboTerritory)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdDelete)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmQpiTerritoryAssignment_Modify"
        Me.Text = "Modify Territory Assignment"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Function GetCode(ByVal strValue As String) As String
        Dim MyCode As String
        MyCode = VisualBasic.Left(strValue, VisualBasic.InStr(strValue, "-") - 1)
        Return MyCode
    End Function
    Private Sub Load_Grid()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "QpiAreaAssign_TableShow", CommandType.StoredProcedure, RemoteDataSet, _
        "QpiAreaAssign_TableShow")
        DataGrid1.DataSource = RemoteDataSet.QpiAreaAssign_TableShow
    End Sub
    Private Sub DataGrid1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid1.Click, DataGrid1.CurrentCellChanged, DataGrid1.Enter
        If RemoteDataSet.QpiAreaAssign_TableShow.Rows.Count > 0 Then
            With DataGrid1
                txtRowid.Text = CStr(.Item(.CurrentCell.RowNumber, 0))
                cboMedrep.Text = CStr(.Item(.CurrentCell.RowNumber, 1))
                cboTerritory.Text = CStr(.Item(.CurrentCell.RowNumber, 2))
                dtStart.Value = CDate(.Item(.CurrentCell.RowNumber, 3))
                dtEnd.Value = CDate(.Item(.CurrentCell.RowNumber, 4))
                .Select(.CurrentCell.RowNumber)
            End With
        End If
    End Sub
    Private Sub Load_Medreps()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "QpiAreaAssign_MedrepShow", CommandType.StoredProcedure, RemoteDataSet, _
        "QpiAreaAssign_MedrepShow1")
        cboMedrep.DataSource = RemoteDataSet.QpiAreaAssign_MedrepShow1
        cboMedrep.DisplayMember = "Medrep"
    End Sub
    Private Sub Load_Territories()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "QpiAreaAssign_TerritoryShow", CommandType.StoredProcedure, RemoteDataSet, _
        "QpiAreaAssign_TerritoryShow1")
        cboTerritory.DataSource = RemoteDataSet.QpiAreaAssign_TerritoryShow1
        cboTerritory.DisplayMember = "TerritoryDesc"
    End Sub
    Private Sub Sub_Delete()
        Dim businessobject As New BusinessLayer.clsFileMaintenance
        Dim params(0) As SqlParameter
        Dim Rowid As New SqlParameter("@Rowid", SqlDbType.Int, 4) : Rowid.Direction = ParameterDirection.Input : Rowid.Value = txtRowid.Text : params(0) = Rowid
        businessobject.Sub_Delete(ServerPath2, "QpiAreaAssign_Delete", CommandType.StoredProcedure, params)
    End Sub
    Private Sub Sub_Select(ByVal dbParams() As String, ByVal UpdateMode As String)
        'select case if add,edit or delete
        Dim i As Integer
        Dim myRowid As Integer
        Select Case UpdateMode
            Case "Insert"
                Dim BusinessObject As New BusinessLayer.clsFileMaintenance
                myRowid = CInt(BusinessObject.Sub_ReturnIntegerResult(ServerPath2, "QpiAreaAssign_GetInsertedRowid", CommandType.StoredProcedure))
            Case "Update"
                myRowid = CInt(dbParams(0))
        End Select
        For i = 0 To (RemoteDataSet.QpiAreaAssign_TableShow.Rows.Count - 1)
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
    Private Sub Sub_Show()
        If RemoteDataSet.QpiAreaAssign_TableShow.Count > 0 Then RemoteDataSet.QpiAreaAssign_TableShow.Clear()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "QpiAreaAssign_TableShow", CommandType.StoredProcedure, RemoteDataSet, "QpiAreaAssign_TableShow")
        DataGrid1.DataSource = RemoteDataSet.QpiAreaAssign_TableShow
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
    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If txtRowid.Text = "" Then
            MessageBox.Show("Please select a record to modify!", "Record Selection", MessageBoxButtons.OK, _
            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            modControlBehavior.EnableControlsGroup(Me, True)
            EditMode = True
        End If
    End Sub
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        modControlBehavior.EnableControls(Me, False)
        ControlMaintenance.ClearInputControls(Me)
        EditMode = False
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim Params(0) As String
        Params(0) = txtRowid.Text
        If EditMode = False Then
            'Sub_Insert()
        Else
            Sub_Update()
        End If
        Sub_Show()
        Sub_Select(Params, CStr(IIf(EditMode = False, "Insert", "Update")))
        EditMode = False
        modControlBehavior.EnableControls(Me, False)
    End Sub
    Private Sub Sub_Update()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(4) As SqlParameter
        Dim Rowid As New SqlParameter("@Rowid", SqlDbType.Int) : Rowid.Direction = ParameterDirection.Input : Rowid.Value = txtRowid.Text : Params(0) = Rowid
        Dim MrCode As New SqlParameter("@MrCode", SqlDbType.VarChar, 25) : MrCode.Direction = ParameterDirection.Input : MrCode.Value = VisualBasic.Left(cboMedrep.Text, VisualBasic.InStr(cboMedrep.Text, "-") - 1) : Params(1) = MrCode
        Dim TerritoryCode As New SqlParameter("@TerritoryCode", SqlDbType.VarChar, 25) : TerritoryCode.Direction = ParameterDirection.Input : TerritoryCode.Value = VisualBasic.Left(cboTerritory.Text, VisualBasic.InStr(cboTerritory.Text, "-") - 1) : Params(2) = TerritoryCode
        Dim StartDate As New SqlParameter("@StartDate", SqlDbType.DateTime) : StartDate.Direction = ParameterDirection.Input : StartDate.Value = dtStart.Text : Params(3) = StartDate
        Dim EndDate As New SqlParameter("@EndDate", SqlDbType.DateTime) : EndDate.Direction = ParameterDirection.Input : EndDate.Value = dtEnd.Text : Params(4) = EndDate
        BusinessObject.Sub_Update(ServerPath2, "QpiAreaAssign_Update", CommandType.StoredProcedure, Params)
    End Sub
    Private Sub frmQpiTerritoryAssignment_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        modControlBehavior.EnableControls(Me, False)
    End Sub
End Class
