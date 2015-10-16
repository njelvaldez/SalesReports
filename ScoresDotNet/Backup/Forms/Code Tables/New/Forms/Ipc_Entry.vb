Imports System.Data.SqlClient
Imports Microsoft

Public Class Ipc_Entry
    Inherits System.Windows.Forms.Form

    Private RemoteDataSet As New CodeTablesDS
    Private RemoteDataSet2 As New MyDataSetDB
    Private EditMode As Boolean = False
    Private oldDs As String, tmpLD As String, tmpID As String
    'Private Itm_EditMode As Boolean = False

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
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
    Friend WithEvents vUpdateDate As System.Windows.Forms.TextBox
    Friend WithEvents vCreateDate As System.Windows.Forms.TextBox
    Friend WithEvents vLastUser As System.Windows.Forms.TextBox
    Friend WithEvents vItemCode As System.Windows.Forms.TextBox
    Friend WithEvents vRowId As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cmdSave_ipc As System.Windows.Forms.Button
    Friend WithEvents cmdCancel_ipc As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents vSellingPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents vStart_Date As System.Windows.Forms.TextBox
    Friend WithEvents vEnd_Date As System.Windows.Forms.TextBox
    Friend WithEvents vSellingPriceO As System.Windows.Forms.TextBox
    Friend WithEvents vStart_DateO As System.Windows.Forms.TextBox
    Friend WithEvents SqlValue As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.vUpdateDate = New System.Windows.Forms.TextBox
        Me.vCreateDate = New System.Windows.Forms.TextBox
        Me.vLastUser = New System.Windows.Forms.TextBox
        Me.cmdSave_ipc = New System.Windows.Forms.Button
        Me.cmdCancel_ipc = New System.Windows.Forms.Button
        Me.vStart_Date = New System.Windows.Forms.TextBox
        Me.vSellingPrice = New System.Windows.Forms.TextBox
        Me.vItemCode = New System.Windows.Forms.TextBox
        Me.vRowId = New System.Windows.Forms.TextBox
        Me.vEnd_Date = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.vSellingPriceO = New System.Windows.Forms.TextBox
        Me.vStart_DateO = New System.Windows.Forms.TextBox
        Me.SqlValue = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'vUpdateDate
        '
        Me.vUpdateDate.BackColor = System.Drawing.SystemColors.Info
        Me.vUpdateDate.Enabled = False
        Me.vUpdateDate.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vUpdateDate.Location = New System.Drawing.Point(101, 151)
        Me.vUpdateDate.Name = "vUpdateDate"
        Me.vUpdateDate.Size = New System.Drawing.Size(155, 20)
        Me.vUpdateDate.TabIndex = 132
        Me.vUpdateDate.Tag = "INPUT"
        Me.vUpdateDate.Text = ""
        '
        'vCreateDate
        '
        Me.vCreateDate.BackColor = System.Drawing.SystemColors.Info
        Me.vCreateDate.Enabled = False
        Me.vCreateDate.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vCreateDate.Location = New System.Drawing.Point(101, 124)
        Me.vCreateDate.Name = "vCreateDate"
        Me.vCreateDate.Size = New System.Drawing.Size(155, 20)
        Me.vCreateDate.TabIndex = 130
        Me.vCreateDate.Tag = "INPUT"
        Me.vCreateDate.Text = ""
        '
        'vLastUser
        '
        Me.vLastUser.Location = New System.Drawing.Point(145, 256)
        Me.vLastUser.Name = "vLastUser"
        Me.vLastUser.Size = New System.Drawing.Size(56, 20)
        Me.vLastUser.TabIndex = 127
        Me.vLastUser.Tag = ""
        Me.vLastUser.Text = ""
        Me.vLastUser.Visible = False
        '
        'cmdSave_ipc
        '
        Me.cmdSave_ipc.Location = New System.Drawing.Point(24, 186)
        Me.cmdSave_ipc.Name = "cmdSave_ipc"
        Me.cmdSave_ipc.Size = New System.Drawing.Size(111, 22)
        Me.cmdSave_ipc.TabIndex = 3
        Me.cmdSave_ipc.Tag = "Save"
        Me.cmdSave_ipc.Text = "Save"
        '
        'cmdCancel_ipc
        '
        Me.cmdCancel_ipc.Location = New System.Drawing.Point(144, 186)
        Me.cmdCancel_ipc.Name = "cmdCancel_ipc"
        Me.cmdCancel_ipc.Size = New System.Drawing.Size(113, 22)
        Me.cmdCancel_ipc.TabIndex = 4
        Me.cmdCancel_ipc.Tag = "Cancel"
        Me.cmdCancel_ipc.Text = "Cancel"
        '
        'vStart_Date
        '
        Me.vStart_Date.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vStart_Date.Location = New System.Drawing.Point(101, 43)
        Me.vStart_Date.MaxLength = 10
        Me.vStart_Date.Name = "vStart_Date"
        Me.vStart_Date.Size = New System.Drawing.Size(155, 20)
        Me.vStart_Date.TabIndex = 0
        Me.vStart_Date.Tag = "INPUT"
        Me.vStart_Date.Text = ""
        '
        'vSellingPrice
        '
        Me.vSellingPrice.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vSellingPrice.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.vSellingPrice.Location = New System.Drawing.Point(101, 97)
        Me.vSellingPrice.MaxLength = 25
        Me.vSellingPrice.Name = "vSellingPrice"
        Me.vSellingPrice.Size = New System.Drawing.Size(155, 20)
        Me.vSellingPrice.TabIndex = 2
        Me.vSellingPrice.Tag = "INPUT"
        Me.vSellingPrice.Text = ""
        '
        'vItemCode
        '
        Me.vItemCode.BackColor = System.Drawing.SystemColors.Info
        Me.vItemCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.vItemCode.Enabled = False
        Me.vItemCode.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vItemCode.Location = New System.Drawing.Point(101, 16)
        Me.vItemCode.MaxLength = 10
        Me.vItemCode.Name = "vItemCode"
        Me.vItemCode.Size = New System.Drawing.Size(155, 20)
        Me.vItemCode.TabIndex = 0
        Me.vItemCode.Tag = "INPUT"
        Me.vItemCode.Text = ""
        '
        'vRowId
        '
        Me.vRowId.Location = New System.Drawing.Point(92, 256)
        Me.vRowId.Name = "vRowId"
        Me.vRowId.Size = New System.Drawing.Size(48, 20)
        Me.vRowId.TabIndex = 106
        Me.vRowId.Tag = ""
        Me.vRowId.Text = ""
        Me.vRowId.Visible = False
        '
        'vEnd_Date
        '
        Me.vEnd_Date.BackColor = System.Drawing.SystemColors.Window
        Me.vEnd_Date.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vEnd_Date.Location = New System.Drawing.Point(101, 70)
        Me.vEnd_Date.MaxLength = 10
        Me.vEnd_Date.Name = "vEnd_Date"
        Me.vEnd_Date.Size = New System.Drawing.Size(155, 20)
        Me.vEnd_Date.TabIndex = 1
        Me.vEnd_Date.Tag = "INPUT"
        Me.vEnd_Date.Text = ""
        '
        'Label19
        '
        Me.Label19.ForeColor = System.Drawing.Color.Blue
        Me.Label19.Location = New System.Drawing.Point(73, 233)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(184, 14)
        Me.Label19.TabIndex = 139
        Me.Label19.Text = "ex.  ""112595"" = ""Nov.25,1995"""
        '
        'Label20
        '
        Me.Label20.ForeColor = System.Drawing.Color.Blue
        Me.Label20.Location = New System.Drawing.Point(73, 218)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(192, 14)
        Me.Label20.TabIndex = 138
        Me.Label20.Text = "Easy Date Format Entry: ""MMDDYY"""
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label18.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(24, 151)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(73, 19)
        Me.Label18.TabIndex = 157
        Me.Label18.Text = "Update Date."
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label17.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(24, 124)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(73, 19)
        Me.Label17.TabIndex = 156
        Me.Label17.Text = "Create Date."
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(24, 70)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 19)
        Me.Label11.TabIndex = 155
        Me.Label11.Text = "End Date."
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(24, 43)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 19)
        Me.Label12.TabIndex = 154
        Me.Label12.Text = "Start Date."
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 19)
        Me.Label7.TabIndex = 153
        Me.Label7.Text = "Item Price."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 19)
        Me.Label1.TabIndex = 152
        Me.Label1.Text = "Item Code."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(16, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(250, 2)
        Me.Label2.TabIndex = 158
        '
        'vSellingPriceO
        '
        Me.vSellingPriceO.Enabled = False
        Me.vSellingPriceO.Location = New System.Drawing.Point(40, 229)
        Me.vSellingPriceO.Name = "vSellingPriceO"
        Me.vSellingPriceO.Size = New System.Drawing.Size(42, 20)
        Me.vSellingPriceO.TabIndex = 174
        Me.vSellingPriceO.Text = "TextBox2"
        Me.vSellingPriceO.Visible = False
        '
        'vStart_DateO
        '
        Me.vStart_DateO.Enabled = False
        Me.vStart_DateO.Location = New System.Drawing.Point(-1, 229)
        Me.vStart_DateO.Name = "vStart_DateO"
        Me.vStart_DateO.Size = New System.Drawing.Size(39, 20)
        Me.vStart_DateO.TabIndex = 173
        Me.vStart_DateO.Text = "TextBox1"
        Me.vStart_DateO.Visible = False
        '
        'SqlValue
        '
        Me.SqlValue.Location = New System.Drawing.Point(103, -3)
        Me.SqlValue.Name = "SqlValue"
        Me.SqlValue.Size = New System.Drawing.Size(146, 21)
        Me.SqlValue.TabIndex = 175
        Me.SqlValue.Visible = False
        '
        'Ipc_Entry
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(283, 253)
        Me.Controls.Add(Me.SqlValue)
        Me.Controls.Add(Me.vSellingPriceO)
        Me.Controls.Add(Me.vStart_DateO)
        Me.Controls.Add(Me.vEnd_Date)
        Me.Controls.Add(Me.vUpdateDate)
        Me.Controls.Add(Me.vCreateDate)
        Me.Controls.Add(Me.vLastUser)
        Me.Controls.Add(Me.vStart_Date)
        Me.Controls.Add(Me.vSellingPrice)
        Me.Controls.Add(Me.vItemCode)
        Me.Controls.Add(Me.vRowId)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.cmdSave_ipc)
        Me.Controls.Add(Me.cmdCancel_ipc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ipc_Entry"
        Me.ShowInTaskbar = False
        Me.Text = "Item's Price History"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Ipc_Entry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlMaintenance.ClearInputControls(Me)
        If Itm_EditMode = False Then
            ControlMaintenance.ClearInputControls(Me)
            EditMode = False
            btnSw = True
            vStart_Date.Select()
        End If
    End Sub

    Private Sub cmdCancel_ipc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel_ipc.Click
        cancelProcess = True
        Close()
    End Sub

    'Private Sub cmdSave_ipc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave_ipc.Click
    '    Dim BusinessObject As New BusinessLayer.clsFileMaintenance
    '    Dim Prms(0) As SqlParameter
    '    Dim MyLoadedForm As New ItemCT
    '    If (MessageBox.Show("Are you sure you want to Save this Entry?", "Confirm Saving", _
    '        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)) _
    '        = DialogResult.Yes Then
    '        If Trim(vItemCode.Text) = "" Then
    '            MessageBox.Show("Mandatory field!")
    '            vItemCode.Select()
    '            Exit Sub
    '        End If
    '        If Trim(vStart_Date.Text) = "" Then
    '            MessageBox.Show("Mandatory field!")
    '            vStart_Date.Select()
    '            Exit Sub
    '        End If
    '        If Trim(vSellingPrice.Text) = "" Then
    '            MessageBox.Show("Mandatory field!")
    '            vSellingPrice.Select()
    '            Exit Sub
    '        End If
    '        If DateDiff("d", vStart_Date.Text, vEnd_Date.Text) < 30 Then 'check if date period is 30days
    '            MessageBox.Show("The End date should be at least a month later than the Start date!")
    '            vStart_Date.Select()
    '            Exit Sub
    '        End If
    '        z = "select itemcode as fld1 from NewScores..itemsph "
    '        z = z & "where rtrim(itemcode) = '" & Trim(vItemCode.Text) & "' "
    '        z = z & "  and rtrim(sellingprice) = '" & Trim(vSellingPrice.Text) & "' "
    '        z = z & "  and ('" & Trim(vStart_Date.Text) & "' between start_date and end_date "
    '        z = z & "   or '" & Trim(vEnd_Date.Text) & "' between start_date and end_date) "
    '        Dim SQLstmnt As New SqlParameter("@SqlQry", SqlDbType.NVarChar, 2950)
    '        SQLstmnt.Direction = ParameterDirection.Input
    '        SQLstmnt.Value = z
    '        Prms(0) = SQLstmnt
    '        If RemoteDataSet2.GenericQryProc.Count > 0 Then RemoteDataSet2.GenericQryProc.Clear()
    '        Try
    '            BusinessObject.Sub_Show(ServerPath2, "GenericQryProc", CommandType.StoredProcedure, _
    '                                    RemoteDataSet, "GenericQryProc", Prms)
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '        SqlValue.DataSource = RemoteDataSet2.GenericQryProc
    '        SqlValue.DisplayMember = "fld1"


    '        MyLoadedForm.DG_ipc.DataSource = Nothing
    '        vLastUser.Text = gCurrUser
    '        If Itm_EditMode = False Then
    '            If Trim(SqlValue.Text) <> "" Then
    '                MsgBox("This Entry already exists! Please try again.")
    '                Exit Sub
    '            Else
    '                Sub_Insert()
    '            End If
    '        Else
    '            Sub_Update()
    '        End If
    '        'MyLoadedForm.Itm_Sub_Show()
    '        'Sub_Select(Params, CStr(IIf(Itm_EditMode = False, "Insert", "Update")))
    '        'Itm_EditMode = False
    '        'modControlBehavior.EnableControls(Me, False)
    '        cancelProcess = False
    '        Close()
    '    Else
    '        Exit Sub
    '    End If
    'End Sub

    Private Sub Sub_Insert()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(6) As SqlParameter

        Dim ItemCode As New SqlParameter("@ItemCode", SqlDbType.VarChar, 10)
        ItemCode.Direction = ParameterDirection.Input
        ItemCode.Value = jTrim(vItemCode.Text)
        Params(0) = ItemCode

        Dim Start_Date As New SqlParameter("@Start_Date", SqlDbType.DateTime, 10)
        Start_Date.Direction = ParameterDirection.Input
        If jTrim(vStart_Date.Text) = "" Then
            Start_Date.Value = DBNull.Value
        Else
            Start_Date.Value = tmpLD
        End If
        Params(1) = Start_Date

        Dim End_Date As New SqlParameter("@End_Date", SqlDbType.DateTime, 10)
        End_Date.Direction = ParameterDirection.Input
        If jTrim(vEnd_Date.Text) = "" Then
            End_Date.Value = DBNull.Value
        Else
            End_Date.Value = tmpID
        End If
        Params(2) = End_Date

        Dim SellingPrice As New SqlParameter("@SellingPrice", SqlDbType.Money)
        SellingPrice.Direction = ParameterDirection.Input
        SellingPrice.Value = jVal(Trim(vSellingPrice.Text))
        Params(3) = SellingPrice

        Dim CreateDate As New SqlParameter("@CreateDate", SqlDbType.DateTime, 10)
        CreateDate.Direction = ParameterDirection.Input
        CreateDate.Value = GetDateTimeNow()
        Params(4) = CreateDate

        Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime, 10)
        UpdateDate.Direction = ParameterDirection.Input
        UpdateDate.Value = GetDateTimeNow()
        Params(5) = UpdateDate

        Dim LastUser As New SqlParameter("@LastUser", SqlDbType.VarChar, 8)
        LastUser.Direction = ParameterDirection.Input
        LastUser.Value = IIf(Trim(gCurrUser) = "", "", gCurrUser)      ' jTrim(vLastUser.Text)
        Params(6) = LastUser

        Try
            BusinessObject.Sub_Insert(ServerPath2, "ItemPH_ins", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Close()
    End Sub

    Private Sub Sub_Update()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(7) As SqlParameter

        Dim ItemCode As New SqlParameter("@ItemCode", SqlDbType.VarChar, 10)
        ItemCode.Direction = ParameterDirection.Input
        ItemCode.Value = jTrim(vItemCode.Text)
        Params(0) = ItemCode

        Dim Start_Date As New SqlParameter("@Start_Date", SqlDbType.DateTime, 10)
        Start_Date.Direction = ParameterDirection.Input
        If jTrim(vStart_Date.Text) = "" Then
            Start_Date.Value = DBNull.Value
        Else
            Start_Date.Value = tmpLD
        End If
        Params(1) = Start_Date

        Dim End_Date As New SqlParameter("@End_Date", SqlDbType.DateTime, 10)
        End_Date.Direction = ParameterDirection.Input
        If jTrim(vEnd_Date.Text) = "" Then
            End_Date.Value = DBNull.Value
        Else
            End_Date.Value = tmpID
        End If
        Params(2) = End_Date

        Dim SellingPrice As New SqlParameter("@SellingPrice", SqlDbType.Money)
        SellingPrice.Direction = ParameterDirection.Input
        SellingPrice.Value = jVal(Trim(vSellingPrice.Text))
        Params(3) = SellingPrice

        Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime, 10)
        UpdateDate.Direction = ParameterDirection.Input
        UpdateDate.Value = GetDateTimeNow()
        Params(4) = UpdateDate

        Dim LastUser As New SqlParameter("@LastUser", SqlDbType.VarChar, 8)
        LastUser.Direction = ParameterDirection.Input
        LastUser.Value = IIf(Trim(gCurrUser) = "", "", gCurrUser)      ' jTrim(vLastUser.Text)
        Params(5) = LastUser

        Dim Start_Date2 As New SqlParameter("@Start_DateO", SqlDbType.DateTime, 10)
        Start_Date2.Direction = ParameterDirection.Input
        If jTrim(vStart_DateO.Text) = "" Then
            Start_Date2.Value = DBNull.Value
        Else
            Start_Date2.Value = jTrim(vStart_DateO.Text)
        End If
        Params(6) = Start_Date2

        Dim SellingPrice2 As New SqlParameter("@SellingPriceO", SqlDbType.Money)
        SellingPrice2.Direction = ParameterDirection.Input
        SellingPrice2.Value = Trim(vSellingPriceO.Text)
        Params(7) = SellingPrice2

        Try
            BusinessObject.Sub_Insert(ServerPath2, "ItemPH_upd", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EditLoadedFilds()
        'vRowId.Text = Filds(0).ToString
        vItemCode.Text = Filds(1).ToString
        vSellingPrice.Text = Filds(2).ToString
        vStart_Date.Text = Filds(3).ToString
        vEnd_Date.Text() = Filds(4).ToString
        vUpdateDate.Text = Filds(5).ToString
    End Sub

    Private Sub vSellingPrice_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vSellingPrice.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
        'If numkeys(e.KeyData) = False Then
        '    If Len(Trim(vSellingPrice.Text)) <> 0 Then
        '        vSellingPrice.Text = Mid(Trim(vSellingPrice.Text), 1, Len(Trim(vSellingPrice.Text)) - 1)
        '        vSellingPrice.SelectionStart = Len(Trim(vSellingPrice.Text))
        '        Beep() : Chr(e.KeyData)
        '    Else
        '        vSellingPrice.Text = "": e.
        '    End If
        'End If
    End Sub

    Private Sub vSellingPrice_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles vSellingPrice.Validating
        If Trim(vSellingPrice.Text) = "" Then
            MessageBox.Show("Mandatory field!")
            e.Cancel = True
        End If
    End Sub

    Private Sub vStartDate_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vStart_Date.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub vStart_Date_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles vStart_Date.Validating
        On Error GoTo errpt
        If Trim(vStart_Date.Text) = "" Then
            MessageBox.Show("Mandatory field!")
            GoTo errpt
        Else
            vStart_Date.Text = DatValid(vStart_Date.Text)
            If Trim(vStart_Date.Text) = "mm/dd/yyyy" Then
                GoTo errpt
            Else
                tmpLD = Format(CDate(vStart_Date.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
                Exit Sub
            End If
        End If
errpt:
        e.Cancel = True
    End Sub

    Private Sub vEnd_Date_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vEnd_Date.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")      'moves control to the next control or field
        End If
    End Sub

    Private Sub vEnd_Date_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles vEnd_Date.Validating
        On Error GoTo errpt
        If Trim(vEnd_Date.Text) = "" Then
            MessageBox.Show("Mandatory field!")
            GoTo errpt
        Else
            vEnd_Date.Text = DatValid(vEnd_Date.Text)
            If Trim(vEnd_Date.Text) = "mm/dd/yyyy" Then
                GoTo errpt
            Else
                tmpID = Format(CDate(vEnd_Date.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
                Exit Sub
            End If
        End If
errpt:
        e.Cancel = True
    End Sub
End Class