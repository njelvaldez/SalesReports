Imports System.Data.SqlClient
Public Class MercuryItemCT
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
        Load_Item()
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
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents lblCreateDate As System.Windows.Forms.Label
    Friend WithEvents lblUpdateDate As System.Windows.Forms.Label
    Friend WithEvents txtRowid As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents cboItem As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtUntConv As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
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
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.txtRowid = New System.Windows.Forms.TextBox
        Me.cboItem = New System.Windows.Forms.ComboBox
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.txtUntConv = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 336)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Code"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 360)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Description"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 411)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Create Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 435)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Update Date"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(96, 336)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(184, 20)
        Me.txtCode.TabIndex = 4
        Me.txtCode.Tag = "Input"
        Me.txtCode.Text = ""
        '
        'lblCreateDate
        '
        Me.lblCreateDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCreateDate.Location = New System.Drawing.Point(96, 411)
        Me.lblCreateDate.Name = "lblCreateDate"
        Me.lblCreateDate.Size = New System.Drawing.Size(184, 20)
        Me.lblCreateDate.TabIndex = 6
        Me.lblCreateDate.Tag = "Input"
        '
        'lblUpdateDate
        '
        Me.lblUpdateDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUpdateDate.Location = New System.Drawing.Point(96, 435)
        Me.lblUpdateDate.Name = "lblUpdateDate"
        Me.lblUpdateDate.Size = New System.Drawing.Size(184, 20)
        Me.lblUpdateDate.TabIndex = 7
        Me.lblUpdateDate.Tag = "Input"
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(256, 467)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.TabIndex = 39
        Me.cmdExit.Tag = "Exit"
        Me.cmdExit.Text = "Exit"
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(16, 467)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.TabIndex = 36
        Me.cmdAdd.Tag = "Add"
        Me.cmdAdd.Text = "Add"
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(96, 467)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.TabIndex = 37
        Me.cmdEdit.Tag = "Edit"
        Me.cmdEdit.Text = "Edit"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(96, 467)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.TabIndex = 41
        Me.cmdCancel.Tag = "Cancel"
        Me.cmdCancel.Text = "Cancel"
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(176, 467)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.TabIndex = 38
        Me.cmdDelete.Tag = "Delete"
        Me.cmdDelete.Text = "Delete"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(176, 467)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.TabIndex = 40
        Me.cmdSave.Tag = "Save"
        Me.cmdSave.Text = "Save"
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 8)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(336, 322)
        Me.DataGrid1.TabIndex = 42
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.DataGrid1.Tag = "View"
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "MercuryItemCT_Show"
        Me.DataGridTableStyle1.ReadOnly = True
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
        Me.DataGridTextBoxColumn2.HeaderText = "Code"
        Me.DataGridTextBoxColumn2.MappingName = "MItemCode"
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Description"
        Me.DataGridTextBoxColumn3.MappingName = "Item"
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 188
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.MappingName = "CreateDate"
        Me.DataGridTextBoxColumn4.Width = 0
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.MappingName = "UpdateDate"
        Me.DataGridTextBoxColumn5.ReadOnly = True
        Me.DataGridTextBoxColumn5.Width = 0
        '
        'txtRowid
        '
        Me.txtRowid.Location = New System.Drawing.Point(312, 336)
        Me.txtRowid.Name = "txtRowid"
        Me.txtRowid.Size = New System.Drawing.Size(13, 20)
        Me.txtRowid.TabIndex = 43
        Me.txtRowid.Tag = "Input"
        Me.txtRowid.Text = ""
        Me.txtRowid.Visible = False
        '
        'cboItem
        '
        Me.cboItem.Location = New System.Drawing.Point(96, 360)
        Me.cboItem.Name = "cboItem"
        Me.cboItem.Size = New System.Drawing.Size(240, 21)
        Me.cboItem.TabIndex = 44
        Me.cboItem.Tag = "Input"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(96, 400)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(184, 20)
        Me.txtDescription.TabIndex = 45
        Me.txtDescription.Tag = "Input"
        Me.txtDescription.Text = ""
        '
        'txtUntConv
        '
        Me.txtUntConv.Location = New System.Drawing.Point(96, 385)
        Me.txtUntConv.Name = "txtUntConv"
        Me.txtUntConv.Size = New System.Drawing.Size(184, 20)
        Me.txtUntConv.TabIndex = 46
        Me.txtUntConv.Tag = "Input"
        Me.txtUntConv.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(1, 385)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 20)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Unit Conversion"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Unit Conversion"
        Me.DataGridTextBoxColumn6.MappingName = "unitconversion"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'MercuryItemCT
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(350, 498)
        Me.Controls.Add(Me.txtUntConv)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboItem)
        Me.Controls.Add(Me.txtRowid)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.lblUpdateDate)
        Me.Controls.Add(Me.lblCreateDate)
        Me.Controls.Add(Me.txtCode)
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
        Me.Name = "MercuryItemCT"
        Me.Text = "Mercury Item"
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
        If txtCode.Text = "" And cboItem.Text = "" Then
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
                ControlMaintenance.ClearInputControls(Me)
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
            Dim Params(4) As SqlParameter
            Dim MItemCode As New SqlParameter("@MItemCode", SqlDbType.VarChar, 25) : MItemCode.Direction = ParameterDirection.Input : MItemCode.Value = txtCode.Text : Params(0) = MItemCode
            Dim ItemCode As New SqlParameter("@ItemCode", SqlDbType.VarChar, 25) : ItemCode.Direction = ParameterDirection.Input : ItemCode.Value = Public_Functions.GetCode(cboItem.Text) : Params(1) = ItemCode
            Dim UntConv As New SqlParameter("@UntConv", SqlDbType.Money) : UntConv.Direction = ParameterDirection.Input : UntConv.Value = Trim(txtUntConv.Text) : Params(2) = UntConv
            Dim CreateDate As New SqlParameter("@CreateDate", SqlDbType.DateTime, 10) : CreateDate.Direction = ParameterDirection.Input : CreateDate.Value = Now() : Params(3) = CreateDate
            Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime, 10) : UpdateDate.Direction = ParameterDirection.Input : UpdateDate.Value = Now() : Params(4) = UpdateDate
            BusinessObject.Sub_Insert(ServerPath2, "MercuryItemCT_Insert", CommandType.StoredProcedure, Params)
            LogHelper.InsertLog("MercuryItemCT_Insert.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("MercuryItemCT_Insert.Error: " & ex.Message)
        End Try
        
    End Sub
    Private Sub Sub_Update()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(4) As SqlParameter
            Dim MItemCode As New SqlParameter("@MItemCode", SqlDbType.VarChar, 25) : MItemCode.Direction = ParameterDirection.Input : MItemCode.Value = txtCode.Text : Params(0) = MItemCode
            Dim ItemCode As New SqlParameter("@ItemCode", SqlDbType.VarChar, 25) : ItemCode.Direction = ParameterDirection.Input : ItemCode.Value = Public_Functions.GetCode(cboItem.Text) : Params(1) = ItemCode
            Dim UntConv As New SqlParameter("@UntConv", SqlDbType.Money) : UntConv.Direction = ParameterDirection.Input : UntConv.Value = Trim(txtUntConv.Text) : Params(2) = UntConv
            Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime, 10) : UpdateDate.Direction = ParameterDirection.Input : UpdateDate.Value = Now() : Params(3) = UpdateDate
            Dim Rowid As New SqlParameter("@Rowid", SqlDbType.Int) : Rowid.Direction = ParameterDirection.Input : Rowid.Value = txtRowid.Text : Params(4) = Rowid
            BusinessObject.Sub_Update(ServerPath2, "MercuryItemCT_Update", CommandType.StoredProcedure, Params)
            LogHelper.InsertLog("MercuryItemCT_Update.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("MercuryItemCT_Update.Error: " & ex.Message)
        End Try
    End Sub
    Private Sub Sub_Show()
        Try
            If RemoteDataSet2.MercuryItemCT_Show.Count > 0 Then RemoteDataSet2.MercuryItemCT_Show.Clear()
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            BusinessObject.Sub_Show(ServerPath2, "MercuryItemCT_Show", CommandType.StoredProcedure, RemoteDataSet2, "MercuryItemCT_Show")
            DataGrid1.DataSource = RemoteDataSet2.MercuryItemCT_Show
            LogHelper.InsertLog("MercuryItemCT_Show.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("MercuryItemCT_Show.Error: " & ex.Message)
        End Try
    End Sub
    Private Sub Load_Item()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            BusinessObject.Sub_Show(ServerPath2, "Item_Combo", CommandType.StoredProcedure, RemoteDataSet, "Item_Combo")
            cboItem.DataSource = RemoteDataSet.Item_Combo
            cboItem.DisplayMember = "Item"
            LogHelper.InsertLog("Item_Combo.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("Item_Combo.Error: " & ex.Message)
        End Try
    End Sub
    Private Sub Sub_Select(ByVal dbParams() As String, ByVal UpdateMode As String)
        'select case if add,edit or delete
        Dim i As Integer
        Dim myRowid As Integer
        Select Case UpdateMode
            Case "Insert"
                Dim BusinessObject As New BusinessLayer.clsFileMaintenance
                myRowid = CInt(BusinessObject.Sub_ReturnIntegerResult(ServerPath2, "MercuryItemCT_GetInsertedRowid", CommandType.StoredProcedure))
            Case "Update"
                myRowid = CInt(dbParams(0))
        End Select
        For i = 0 To (RemoteDataSet2.MercuryItemCT_Show.Rows.Count - 1)
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
            BusinessObject.Sub_Delete(ServerPath2, "MercuryItemCT_Delete", CommandType.StoredProcedure, Params)
            LogHelper.InsertLog("MercuryItemCT_Delete.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("MercuryItemCT_Delete.Error: " & ex.Message)
        End Try
    End Sub
    Private Sub MercuryItemCT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        modControlBehavior.EnableControls(Me, False)
    End Sub
    Private Sub DataGrid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.Click, DataGrid1.CurrentCellChanged
        With DataGrid1
            txtRowid.Text = Trim(.Item(.CurrentCell.RowNumber, 0).ToString)
            txtCode.Text = Trim(.Item(.CurrentCell.RowNumber, 1).ToString)
            cboItem.Text = Trim(.Item(.CurrentCell.RowNumber, 2).ToString)
            txtUntConv.Text = Trim(.Item(.CurrentCell.RowNumber, 3).ToString)
            lblCreateDate.Text = Trim(.Item(.CurrentCell.RowNumber, 4).ToString)
            lblUpdateDate.Text = Trim(.Item(.CurrentCell.RowNumber, 5).ToString)
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
