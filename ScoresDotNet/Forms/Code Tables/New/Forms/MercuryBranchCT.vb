Imports System.Data.SqlClient
Imports Microsoft
Public Class MercuryBranchCT
    Inherits System.Windows.Forms.Form
    Private RemoteDataSet As New CodeTablesDS
    Private RemoteDataSet2 As New MyDataSetDB
    Private EditMode As Boolean = False

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Sub_Show()
        Load_Territory()

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
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtRowid As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents cboTerritory As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblCreateDate As System.Windows.Forms.Label
    Friend WithEvents lblUpdateDate As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents txtDimCode As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MercuryBranchCT))
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtDimCode = New System.Windows.Forms.TextBox
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.txtRowid = New System.Windows.Forms.TextBox
        Me.txtAddress1 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.txtAddress2 = New System.Windows.Forms.TextBox
        Me.cboTerritory = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblCreateDate = New System.Windows.Forms.Label
        Me.lblUpdateDate = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(279, 522)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(72, 40)
        Me.cmdExit.TabIndex = 15
        Me.cmdExit.Tag = "Exit"
        Me.cmdExit.Text = "E&xit"
        '
        'cmdAdd
        '
        Me.cmdAdd.Image = CType(resources.GetObject("cmdAdd.Image"), System.Drawing.Image)
        Me.cmdAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAdd.Location = New System.Drawing.Point(39, 522)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(72, 40)
        Me.cmdAdd.TabIndex = 12
        Me.cmdAdd.Tag = "Add"
        Me.cmdAdd.Text = "   &Add"
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdEdit.Location = New System.Drawing.Point(119, 522)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(72, 40)
        Me.cmdEdit.TabIndex = 13
        Me.cmdEdit.Tag = "Edit"
        Me.cmdEdit.Text = "   &Edit"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(118, 522)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(72, 40)
        Me.cmdCancel.TabIndex = 16
        Me.cmdCancel.Tag = "Cancel"
        Me.cmdCancel.Text = "Cancel"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDelete.Location = New System.Drawing.Point(200, 522)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(72, 40)
        Me.cmdDelete.TabIndex = 14
        Me.cmdDelete.Tag = "Delete"
        Me.cmdDelete.Text = "       &Del"
        '
        'cmdSave
        '
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSave.Location = New System.Drawing.Point(197, 522)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(72, 40)
        Me.cmdSave.TabIndex = 17
        Me.cmdSave.Tag = "Save"
        Me.cmdSave.Text = "   &Save"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(16, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 24)
        Me.Label6.TabIndex = 140
        Me.Label6.Text = "Dimension Code"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDimCode
        '
        Me.txtDimCode.Location = New System.Drawing.Point(96, 80)
        Me.txtDimCode.Name = "txtDimCode"
        Me.txtDimCode.Size = New System.Drawing.Size(224, 20)
        Me.txtDimCode.TabIndex = 130
        Me.txtDimCode.Tag = "Input"
        Me.txtDimCode.Text = ""
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(96, 56)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(224, 20)
        Me.txtDescription.TabIndex = 129
        Me.txtDescription.Tag = "Input"
        Me.txtDescription.Text = ""
        '
        'txtRowid
        '
        Me.txtRowid.Location = New System.Drawing.Point(160, 24)
        Me.txtRowid.Name = "txtRowid"
        Me.txtRowid.Size = New System.Drawing.Size(13, 20)
        Me.txtRowid.TabIndex = 136
        Me.txtRowid.Tag = "Input"
        Me.txtRowid.Text = ""
        Me.txtRowid.Visible = False
        '
        'txtAddress1
        '
        Me.txtAddress1.Location = New System.Drawing.Point(96, 136)
        Me.txtAddress1.Multiline = True
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(224, 40)
        Me.txtAddress1.TabIndex = 131
        Me.txtAddress1.Tag = "Input"
        Me.txtAddress1.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 296)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 126
        Me.Label3.Text = "Create Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 328)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 127
        Me.Label4.Text = "Update Date"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(16, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 20)
        Me.Label8.TabIndex = 138
        Me.Label8.Text = "Address 2"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(96, 24)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(224, 20)
        Me.txtCode.TabIndex = 128
        Me.txtCode.Tag = "Input"
        Me.txtCode.Text = ""
        '
        'txtAddress2
        '
        Me.txtAddress2.Location = New System.Drawing.Point(96, 184)
        Me.txtAddress2.Multiline = True
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(224, 40)
        Me.txtAddress2.TabIndex = 132
        Me.txtAddress2.Tag = "Input"
        Me.txtAddress2.Text = ""
        '
        'cboTerritory
        '
        Me.cboTerritory.Location = New System.Drawing.Point(96, 256)
        Me.cboTerritory.Name = "cboTerritory"
        Me.cboTerritory.Size = New System.Drawing.Size(224, 21)
        Me.cboTerritory.TabIndex = 133
        Me.cboTerritory.Tag = "Input"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 139
        Me.Label5.Text = "Territory"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCreateDate
        '
        Me.lblCreateDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCreateDate.Location = New System.Drawing.Point(96, 296)
        Me.lblCreateDate.Name = "lblCreateDate"
        Me.lblCreateDate.Size = New System.Drawing.Size(224, 20)
        Me.lblCreateDate.TabIndex = 134
        Me.lblCreateDate.Tag = "Input"
        '
        'lblUpdateDate
        '
        Me.lblUpdateDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUpdateDate.Location = New System.Drawing.Point(96, 328)
        Me.lblUpdateDate.Name = "lblUpdateDate"
        Me.lblUpdateDate.Size = New System.Drawing.Size(224, 20)
        Me.lblUpdateDate.TabIndex = 135
        Me.lblUpdateDate.Tag = "Input"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 20)
        Me.Label2.TabIndex = 125
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(16, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 20)
        Me.Label7.TabIndex = 137
        Me.Label7.Text = "Address 1"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "Code"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboTerritory)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblCreateDate)
        Me.GroupBox1.Controls.Add(Me.txtAddress1)
        Me.GroupBox1.Controls.Add(Me.lblUpdateDate)
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtDimCode)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.txtRowid)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtAddress2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(336, 488)
        Me.GroupBox1.TabIndex = 141
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGrid1)
        Me.GroupBox2.Location = New System.Drawing.Point(368, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(952, 488)
        Me.GroupBox2.TabIndex = 142
        Me.GroupBox2.TabStop = False
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 16)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(928, 464)
        Me.DataGrid1.TabIndex = 43
        Me.DataGrid1.Tag = "View"
        '
        'MercuryBranchCT
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1326, 572)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MercuryBranchCT"
        Me.Text = "Mercury Branch"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        modControlBehavior.EnableControlsGroup(Me, True)
        ControlMaintenance.ClearInputControlsGroup(Me)
        EditMode = False
    End Sub
    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If txtCode.Text = "" And txtDescription.Text = "" Then
            MessageBox.Show("Please select a record to modify!", "Record Selection", MessageBoxButtons.OK, _
            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            modControlBehavior.EnableControlsGroup(Me, True)
            EditMode = True
        End If
    End Sub
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If txtRowid.Text > "" Then
            If (MessageBox.Show("Do you really want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, _
            MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then
                Sub_Delete()
                ControlMaintenance.ClearInputControlsGroup(Me)
                Sub_Show()
            End If
        End If
    End Sub
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        modControlBehavior.EnableControls(Me, False)
        ControlMaintenance.ClearInputControlsGroup(Me)
        EditMode = False
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        Dim Params(0) As String
        Params(0) = txtRowid.Text
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
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(7) As SqlParameter
            Dim BranchCode As New SqlParameter("@BranchCode", SqlDbType.VarChar, 25) : BranchCode.Direction = ParameterDirection.Input : BranchCode.Value = txtCode.Text : Params(0) = BranchCode
            Dim BranchName As New SqlParameter("@BranchName", SqlDbType.VarChar, 100) : BranchName.Direction = ParameterDirection.Input : BranchName.Value = txtDescription.Text : Params(1) = BranchName
            Dim Address1 As New SqlParameter("@Address1", SqlDbType.VarChar, 50) : Address1.Direction = ParameterDirection.Input : Address1.Value = txtAddress1.Text : Params(2) = Address1
            Dim Address2 As New SqlParameter("@Address2", SqlDbType.VarChar, 50) : Address2.Direction = ParameterDirection.Input : Address2.Value = txtAddress2.Text : Params(3) = Address2
            Dim TerritoryCode As New SqlParameter("@TerritoryCode", SqlDbType.VarChar, 25) : TerritoryCode.Direction = ParameterDirection.Input : TerritoryCode.Value = Public_Functions.GetCode(cboTerritory.Text) : Params(4) = TerritoryCode
            Dim CreateDate As New SqlParameter("@CreateDate", SqlDbType.DateTime, 10) : CreateDate.Direction = ParameterDirection.Input : CreateDate.Value = Now() : Params(5) = CreateDate
            Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime, 10) : UpdateDate.Direction = ParameterDirection.Input : UpdateDate.Value = Now() : Params(6) = UpdateDate
            Dim DimCode As New SqlParameter("@DimCode", SqlDbType.VarChar, 11) : DimCode.Direction = ParameterDirection.Input : DimCode.Value = txtDimCode.Text : Params(7) = DimCode
            BusinessObject.Sub_Insert(ServerPath2, "MercuryBranchCT_Insert", CommandType.StoredProcedure, Params)
            LogHelper.InsertLog("MercuryBranchCT_Insert.Success")

            '@BranchCode char(4),
            '@BranchName varchar(50),
            '@Address1 varchar(50),
            '@Address2 varchar(50),
            '@TerritoryCode varchar(25),
            '@CreateDate datetime,
            '@UpdateDate datetime,
            '@DimCode varchar(11)

        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("MercuryBranchCT_Insert.Error: " & ex.Message)
        End Try
    End Sub
    Private Sub Sub_Update()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(7) As SqlParameter
            '@Rowid int,
            '@BranchCode char(4),
            '@BranchName varchar(50),
            '@Address1 varchar(50),
            '@Address2 varchar(50),
            '@Territorycode varchar(25),
            '@UpdateDate datetime,
            '@DimCode varchar(11)
            Dim Rowid As New SqlParameter("@Rowid", SqlDbType.Int) : Rowid.Direction = ParameterDirection.Input : Rowid.Value = txtRowid.Text : Params(0) = Rowid
            Dim BranchCode As New SqlParameter("@BranchCode", SqlDbType.VarChar, 25) : BranchCode.Direction = ParameterDirection.Input : BranchCode.Value = txtCode.Text : Params(1) = BranchCode
            Dim BranchName As New SqlParameter("@BranchName", SqlDbType.VarChar, 100) : BranchName.Direction = ParameterDirection.Input : BranchName.Value = txtDescription.Text : Params(2) = BranchName
            Dim Address1 As New SqlParameter("@Address1", SqlDbType.VarChar, 50) : Address1.Direction = ParameterDirection.Input : Address1.Value = txtAddress1.Text : Params(3) = Address1
            Dim Address2 As New SqlParameter("@Address2", SqlDbType.VarChar, 50) : Address2.Direction = ParameterDirection.Input : Address2.Value = txtAddress2.Text : Params(4) = Address2
            Dim TerritoryCode As New SqlParameter("@TerritoryCode", SqlDbType.VarChar, 25) : TerritoryCode.Direction = ParameterDirection.Input : TerritoryCode.Value = Public_Functions.GetCode(cboTerritory.Text) : Params(5) = TerritoryCode
            Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime, 10) : UpdateDate.Direction = ParameterDirection.Input : UpdateDate.Value = Now() : Params(6) = UpdateDate
            Dim DimCode As New SqlParameter("@DimCode", SqlDbType.VarChar, 11) : DimCode.Direction = ParameterDirection.Input : DimCode.Value = txtDimCode.Text : Params(7) = DimCode
            BusinessObject.Sub_Update(ServerPath2, "MercuryBranchCT_Update", CommandType.StoredProcedure, Params)
            LogHelper.InsertLog("MercuryBranchCT_Update.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("MercuryBranchCT_Update.Error: " & ex.Message)
        End Try
    End Sub
    Private Sub Sub_Show()
        Try
            If RemoteDataSet2.MercuryBranchCT_Show.Count > 0 Then RemoteDataSet2.MercuryBranchCT_Show.Clear()
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            BusinessObject.Sub_Show(ServerPath2, "MercuryBranchCT_Show", CommandType.StoredProcedure, RemoteDataSet2, "MercuryBranchCT_Show")
            DataGrid1.DataSource = RemoteDataSet2.MercuryBranchCT_Show
            LogHelper.InsertLog("MercuryBranchCT_Show.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("MercuryBranchCT_Show.Success")
        End Try
    End Sub

    Private Sub Load_Territory()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "Territory_Combo", CommandType.StoredProcedure, RemoteDataSet, "Territory_Combo")
        cboTerritory.DataSource = RemoteDataSet.Territory_Combo
        cboTerritory.DisplayMember = "TerritoryDesc"
    End Sub
    Private Sub Sub_Select(ByVal dbParams() As String, ByVal UpdateMode As String)
        'select case if add,edit or delete
        Dim i As Integer
        Dim myRowid As Integer
        Select Case UpdateMode
            Case "Insert"
                Dim BusinessObject As New BusinessLayer.clsFileMaintenance
                myRowid = CInt(BusinessObject.Sub_ReturnIntegerResult(ServerPath2, "MercuryBranchCT_GetInsertedRowid", CommandType.StoredProcedure))
            Case "Update"
                myRowid = CInt(dbParams(0))
        End Select
        For i = 0 To (RemoteDataSet2.MercuryBranchCT_Show.Rows.Count - 1)
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
            Dim Rowid As New SqlParameter("@Rowid", SqlDbType.Int) : Rowid.Direction = ParameterDirection.Input : Rowid.Value = txtRowid.Text : Params(0) = Rowid
            BusinessObject.Sub_Delete(ServerPath2, "MercuryBranchCT_Delete", CommandType.StoredProcedure, Params)
            LogHelper.InsertLog("MercuryBranchCT_Delete.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("MercuryBranchCT_Delete.Error: " & ex.Message)
        End Try
    End Sub
    Private Sub MercuryBranchCT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        modControlBehavior.EnableControls(Me, False)
    End Sub
    Private Sub DataGrid1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid1.Click
        With DataGrid1
            txtRowid.Text = Trim(.Item(.CurrentCell.RowNumber, 0).ToString)
            txtCode.Text = Trim(.Item(.CurrentCell.RowNumber, 1).ToString)
            txtDescription.Text = Trim(.Item(.CurrentCell.RowNumber, 2).ToString)
            txtAddress1.Text = Trim(.Item(.CurrentCell.RowNumber, 3).ToString)
            txtAddress2.Text = Trim(.Item(.CurrentCell.RowNumber, 4).ToString)
            cboTerritory.Text = Trim(.Item(.CurrentCell.RowNumber, 6).ToString)
            lblCreateDate.Text = Trim(.Item(.CurrentCell.RowNumber, 7).ToString)
            lblUpdateDate.Text = Trim(.Item(.CurrentCell.RowNumber, 8).ToString)
            txtDimCode.Text = Trim(.Item(.CurrentCell.RowNumber, 9).ToString)
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

    Private Sub txtCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCode.TextChanged
        DisplayDimCode()
    End Sub
    Private Sub DisplayDimCode()
        'TextBoxDistrictCode.Text.PadLeft(2, "0"c)
        txtDimCode.Text = "MDC" + txtCode.Text.Trim().PadLeft(5, "0"c)
    End Sub
End Class
