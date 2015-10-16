Imports System.Data.SqlClient

Public Class frmSupMr
    'Inherits System.Windows.Forms.Form
    'Private EditMode As Boolean = False
    Inherits System.Windows.Forms.Form
    Private RemoteDataSet As New MyDataSetDB
    Private EditMode As Boolean = False
    Private oldDs As String, tmpSD As String, tmpED As String   '<-- added-DBrion
    Private temDiv As String, actDiv As String, tmpRowid As String
    Private currDSM As String, currPMR As String
    Friend WithEvents txtADivCode As System.Windows.Forms.TextBox

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
    Friend WithEvents TxtEndDate As System.Windows.Forms.TextBox
    Friend WithEvents TxtStartDate As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents lblUpdateDate As System.Windows.Forms.TextBox
    Friend WithEvents lblCreateDate As System.Windows.Forms.TextBox
    Friend WithEvents txtRowid As System.Windows.Forms.TextBox
    Friend WithEvents TxtLastUser As System.Windows.Forms.TextBox
    Friend WithEvents SqlValue As System.Windows.Forms.ComboBox
    Friend WithEvents btnDSM As System.Windows.Forms.Button
    Friend WithEvents txtDSMcode As System.Windows.Forms.TextBox
    Friend WithEvents txtDSMdesc As System.Windows.Forms.TextBox
    Friend WithEvents txtPMRdesc As System.Windows.Forms.TextBox
    Friend WithEvents txtPMRcode As System.Windows.Forms.TextBox
    Friend WithEvents txtTDiv As System.Windows.Forms.TextBox
    Friend WithEvents txtADiv As System.Windows.Forms.TextBox
    Friend WithEvents btnTDiv As System.Windows.Forms.Button
    Friend WithEvents btnADiv As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSupMr))
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.TxtEndDate = New System.Windows.Forms.TextBox()
        Me.TxtStartDate = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblUpdateDate = New System.Windows.Forms.TextBox()
        Me.lblCreateDate = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRowid = New System.Windows.Forms.TextBox()
        Me.TxtLastUser = New System.Windows.Forms.TextBox()
        Me.SqlValue = New System.Windows.Forms.ComboBox()
        Me.txtDSMcode = New System.Windows.Forms.TextBox()
        Me.txtDSMdesc = New System.Windows.Forms.TextBox()
        Me.btnDSM = New System.Windows.Forms.Button()
        Me.txtPMRdesc = New System.Windows.Forms.TextBox()
        Me.txtPMRcode = New System.Windows.Forms.TextBox()
        Me.txtTDiv = New System.Windows.Forms.TextBox()
        Me.txtADiv = New System.Windows.Forms.TextBox()
        Me.btnTDiv = New System.Windows.Forms.Button()
        Me.btnADiv = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtADivCode = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCancel.Location = New System.Drawing.Point(218, 118)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 6
        Me.cmdCancel.Tag = "Cancel"
        Me.cmdCancel.Text = "Cancel"
        '
        'cmdSave
        '
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSave.Location = New System.Drawing.Point(296, 118)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 7
        Me.cmdSave.Tag = "Save"
        Me.cmdSave.Text = "Save"
        '
        'TxtEndDate
        '
        Me.TxtEndDate.Location = New System.Drawing.Point(458, 33)
        Me.TxtEndDate.MaxLength = 10
        Me.TxtEndDate.Name = "TxtEndDate"
        Me.TxtEndDate.Size = New System.Drawing.Size(104, 20)
        Me.TxtEndDate.TabIndex = 5
        Me.TxtEndDate.Tag = "Input"
        '
        'TxtStartDate
        '
        Me.TxtStartDate.Location = New System.Drawing.Point(458, 8)
        Me.TxtStartDate.MaxLength = 10
        Me.TxtStartDate.Name = "TxtStartDate"
        Me.TxtStartDate.Size = New System.Drawing.Size(104, 20)
        Me.TxtStartDate.TabIndex = 4
        Me.TxtStartDate.Tag = "Input"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(388, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 20)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "End Date"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(388, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 20)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Start Date"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUpdateDate
        '
        Me.lblUpdateDate.BackColor = System.Drawing.SystemColors.Info
        Me.lblUpdateDate.Enabled = False
        Me.lblUpdateDate.Location = New System.Drawing.Point(458, 83)
        Me.lblUpdateDate.MaxLength = 10
        Me.lblUpdateDate.Name = "lblUpdateDate"
        Me.lblUpdateDate.ReadOnly = True
        Me.lblUpdateDate.Size = New System.Drawing.Size(104, 20)
        Me.lblUpdateDate.TabIndex = 58
        Me.lblUpdateDate.Tag = "Input"
        '
        'lblCreateDate
        '
        Me.lblCreateDate.BackColor = System.Drawing.SystemColors.Info
        Me.lblCreateDate.Enabled = False
        Me.lblCreateDate.Location = New System.Drawing.Point(458, 58)
        Me.lblCreateDate.MaxLength = 10
        Me.lblCreateDate.Name = "lblCreateDate"
        Me.lblCreateDate.ReadOnly = True
        Me.lblCreateDate.Size = New System.Drawing.Size(104, 20)
        Me.lblCreateDate.TabIndex = 57
        Me.lblCreateDate.Tag = "Input"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(388, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 20)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "Update Date"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(388, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 20)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Create Date"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(7, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(553, 2)
        Me.Label1.TabIndex = 65
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(382, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 14)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "ex.  ""112595"" = ""Nov.25,1995"""
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(382, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(192, 14)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Easy Date Format Entry: ""MMDDYY"""
        '
        'txtRowid
        '
        Me.txtRowid.Location = New System.Drawing.Point(5, 118)
        Me.txtRowid.Name = "txtRowid"
        Me.txtRowid.Size = New System.Drawing.Size(13, 20)
        Me.txtRowid.TabIndex = 68
        Me.txtRowid.Tag = "Input"
        Me.txtRowid.Visible = False
        '
        'TxtLastUser
        '
        Me.TxtLastUser.Location = New System.Drawing.Point(21, 118)
        Me.TxtLastUser.MaxLength = 8
        Me.TxtLastUser.Name = "TxtLastUser"
        Me.TxtLastUser.Size = New System.Drawing.Size(43, 20)
        Me.TxtLastUser.TabIndex = 69
        Me.TxtLastUser.Tag = "Input"
        Me.TxtLastUser.Visible = False
        '
        'SqlValue
        '
        Me.SqlValue.Location = New System.Drawing.Point(67, 118)
        Me.SqlValue.Name = "SqlValue"
        Me.SqlValue.Size = New System.Drawing.Size(146, 21)
        Me.SqlValue.TabIndex = 70
        Me.SqlValue.Visible = False
        '
        'txtDSMcode
        '
        Me.txtDSMcode.Location = New System.Drawing.Point(98, 8)
        Me.txtDSMcode.Name = "txtDSMcode"
        Me.txtDSMcode.Size = New System.Drawing.Size(60, 20)
        Me.txtDSMcode.TabIndex = 0
        Me.txtDSMcode.Tag = "Input"
        '
        'txtDSMdesc
        '
        Me.txtDSMdesc.Location = New System.Drawing.Point(158, 8)
        Me.txtDSMdesc.Name = "txtDSMdesc"
        Me.txtDSMdesc.Size = New System.Drawing.Size(225, 20)
        Me.txtDSMdesc.TabIndex = 1
        Me.txtDSMdesc.Tag = "Input"
        '
        'btnDSM
        '
        Me.btnDSM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDSM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDSM.Location = New System.Drawing.Point(6, 8)
        Me.btnDSM.Name = "btnDSM"
        Me.btnDSM.Size = New System.Drawing.Size(90, 20)
        Me.btnDSM.TabIndex = 81
        Me.btnDSM.Tag = "Input"
        Me.btnDSM.Text = "DSM"
        '
        'txtPMRdesc
        '
        Me.txtPMRdesc.BackColor = System.Drawing.SystemColors.Info
        Me.txtPMRdesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPMRdesc.Location = New System.Drawing.Point(158, 33)
        Me.txtPMRdesc.Name = "txtPMRdesc"
        Me.txtPMRdesc.ReadOnly = True
        Me.txtPMRdesc.Size = New System.Drawing.Size(225, 20)
        Me.txtPMRdesc.TabIndex = 83
        Me.txtPMRdesc.Tag = "Input"
        '
        'txtPMRcode
        '
        Me.txtPMRcode.BackColor = System.Drawing.SystemColors.Info
        Me.txtPMRcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPMRcode.Location = New System.Drawing.Point(98, 33)
        Me.txtPMRcode.Name = "txtPMRcode"
        Me.txtPMRcode.ReadOnly = True
        Me.txtPMRcode.Size = New System.Drawing.Size(60, 20)
        Me.txtPMRcode.TabIndex = 82
        Me.txtPMRcode.Tag = "Input"
        '
        'txtTDiv
        '
        Me.txtTDiv.BackColor = System.Drawing.SystemColors.Info
        Me.txtTDiv.Location = New System.Drawing.Point(98, 58)
        Me.txtTDiv.Name = "txtTDiv"
        Me.txtTDiv.ReadOnly = True
        Me.txtTDiv.Size = New System.Drawing.Size(285, 20)
        Me.txtTDiv.TabIndex = 2
        Me.txtTDiv.Tag = "Input"
        '
        'txtADiv
        '
        Me.txtADiv.BackColor = System.Drawing.SystemColors.Info
        Me.txtADiv.Location = New System.Drawing.Point(98, 83)
        Me.txtADiv.Name = "txtADiv"
        Me.txtADiv.ReadOnly = True
        Me.txtADiv.Size = New System.Drawing.Size(285, 20)
        Me.txtADiv.TabIndex = 3
        Me.txtADiv.Tag = "Input"
        '
        'btnTDiv
        '
        Me.btnTDiv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTDiv.Location = New System.Drawing.Point(6, 58)
        Me.btnTDiv.Name = "btnTDiv"
        Me.btnTDiv.Size = New System.Drawing.Size(90, 20)
        Me.btnTDiv.TabIndex = 87
        Me.btnTDiv.Tag = "Input"
        Me.btnTDiv.Text = "Team Division"
        '
        'btnADiv
        '
        Me.btnADiv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnADiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnADiv.Location = New System.Drawing.Point(6, 83)
        Me.btnADiv.Name = "btnADiv"
        Me.btnADiv.Size = New System.Drawing.Size(90, 20)
        Me.btnADiv.TabIndex = 88
        Me.btnADiv.Tag = "Input"
        Me.btnADiv.Text = "Actual Division"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(6, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "PMR"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtADivCode
        '
        Me.txtADivCode.BackColor = System.Drawing.SystemColors.Info
        Me.txtADivCode.Location = New System.Drawing.Point(102, 83)
        Me.txtADivCode.Name = "txtADivCode"
        Me.txtADivCode.ReadOnly = True
        Me.txtADivCode.Size = New System.Drawing.Size(37, 20)
        Me.txtADivCode.TabIndex = 90
        Me.txtADivCode.Tag = "Input"
        Me.txtADivCode.Visible = False
        '
        'frmSupMr
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(568, 149)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtADivCode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnADiv)
        Me.Controls.Add(Me.btnTDiv)
        Me.Controls.Add(Me.txtADiv)
        Me.Controls.Add(Me.txtTDiv)
        Me.Controls.Add(Me.txtPMRdesc)
        Me.Controls.Add(Me.txtPMRcode)
        Me.Controls.Add(Me.txtDSMdesc)
        Me.Controls.Add(Me.txtDSMcode)
        Me.Controls.Add(Me.TxtLastUser)
        Me.Controls.Add(Me.txtRowid)
        Me.Controls.Add(Me.lblUpdateDate)
        Me.Controls.Add(Me.lblCreateDate)
        Me.Controls.Add(Me.TxtEndDate)
        Me.Controls.Add(Me.TxtStartDate)
        Me.Controls.Add(Me.btnDSM)
        Me.Controls.Add(Me.SqlValue)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdSave)
        Me.Name = "frmSupMr"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DSM - PMR Assignment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub cmdCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        modControlBehavior.EnableControls(Me, False)
        btnDSM.Tag = ""
        btnTDiv.Tag = ""
        btnADiv.Tag = ""
        ControlMaintenance.ClearInputControls(Me)
        btnDSM.Tag = "Input"
        btnTDiv.Tag = "Input"
        btnADiv.Tag = "Input"

        cancelProcess = True
        Close()
    End Sub

    Function tstRecord(ByVal vDSM As String) As Boolean
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Prms(0) As SqlParameter
        z = "select supcode as fld1 from NewScores..SupMr "
        z = z & "where rtrim(mrcode) = '" & Trim(txtPMRcode.Text) & "' "
        'z = z & "  and rtrim(supcode) = '" & Trim(txtDSMcode.Text) & "' "
        z = z & "  and ( ('" & Trim(TxtStartDate.Text) & "' between start_date and end_date) "
        z = z & "       or ('" & Trim(TxtEndDate.Text) & "' between start_date and end_date) ) "
        If DSM_EditMode = True Then
            z = z & "  and rownumber <> '" & Trim(Fld6) & "' "
        End If
        Dim SQLstmnt As New SqlParameter("@SqlQry", SqlDbType.NVarChar, 2950)
        SQLstmnt.Direction = ParameterDirection.Input
        SQLstmnt.Value = z
        Prms(0) = SQLstmnt
        If RemoteDataSet.GenericQryProc.Count > 0 Then RemoteDataSet.GenericQryProc.Clear()
        Try
            BusinessObject.Sub_Show(ServerPath2, "GenericQryProc", CommandType.StoredProcedure, _
                                    RemoteDataSet, "GenericQryProc", Prms)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        SqlValue.DataSource = RemoteDataSet.GenericQryProc
        SqlValue.DisplayMember = "fld1"
        If Trim(SqlValue.Text) <> "" Then
            MsgBox("There is a conflict with this Entry! Please try again.")
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub cmdSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If (MessageBox.Show("Are you sure you want to Save this Entry?", "Confirm Saving", _
              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)) _
              = DialogResult.Yes Then
            'Dim tmpSup As String, tmpMr As String
            'Dim Params(0) As String
            'Params(0) = txtRowid.Text
            If DSM_EditMode = False Then
                If tstRecord(Trim(txtDSMcode.Text)) = True Then
                    'Display warning message
                    If (MessageBox.Show("Are you sure you want to Save this Entry?", "Confirm Saving", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)) _
                        = DialogResult.Yes Then
                        Sub_Insert()
                    End If
                Else
                    Sub_Insert()
                End If
            Else
                If tstRecord(Trim(txtDSMcode.Text)) = True Then
                    'Display warning message
                    If (MessageBox.Show("Are you sure you want to Save this Entry?", "Confirm Saving", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)) _
                        = DialogResult.Yes Then
                        Sub_Update()
                    End If
                Else
                    Sub_Update()
                End If
            End If
            MsgBox("Record Successfully Saved!")
            modControlBehavior.EnableControls(Me, False)
            cancelProcess = False
            Close()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Sub_Insert()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(9) As SqlParameter

        Dim SupCode As New SqlParameter("@SupCode", SqlDbType.VarChar, 10)
        SupCode.Direction = ParameterDirection.Input
        SupCode.Value = Trim(txtDSMcode.Text)
        Params(0) = SupCode

        Dim MrCode As New SqlParameter("@MrCode", SqlDbType.VarChar, 10)
        MrCode.Direction = ParameterDirection.Input
        MrCode.Value = Trim(txtPMRcode.Text)
        Params(1) = MrCode

        Dim StartDate As New SqlParameter("@Start_Date", SqlDbType.DateTime)
        StartDate.Direction = ParameterDirection.Input
        StartDate.Value = Trim(TxtStartDate.Text) '& GetDateTimeNow(" h:mm:ss tt")
        Params(2) = StartDate

        Dim EndDate As New SqlParameter("@End_Date", SqlDbType.DateTime)
        EndDate.Direction = ParameterDirection.Input
        EndDate.Value = Trim(TxtEndDate.Text) '& GetDateTimeNow(" h:mm:ss tt")
        Params(3) = EndDate

        'added-DBrion --v
        Dim TeamDivision As New SqlParameter("@TeamDivision", SqlDbType.VarChar, 50)
        TeamDivision.Direction = ParameterDirection.Input
        TeamDivision.Value = Trim(txtTDiv.Text)
        Params(4) = TeamDivision

        Dim Division As New SqlParameter("@Division", SqlDbType.VarChar, 30)
        Division.Direction = ParameterDirection.Input
        Division.Value = Trim(txtADiv.Text)
        Params(5) = Division

        'added-DBrion --^
        Dim CreateDate As New SqlParameter("@CreateDate", SqlDbType.DateTime)
        CreateDate.Direction = ParameterDirection.Input
        CreateDate.Value = GetDateTimeNow()
        Params(6) = CreateDate

        Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime)
        UpdateDate.Direction = ParameterDirection.Input
        UpdateDate.Value = GetDateTimeNow()
        Params(7) = UpdateDate

        Dim LastUser As New SqlParameter("@LastUser", SqlDbType.VarChar, 10)
        LastUser.Direction = ParameterDirection.Input
        LastUser.Value = IIf(Trim(gCurrUser) = "", "", gCurrUser)     ' Trim(TxtLastUser.Text)
        Params(8) = LastUser

        'inserted by angelo , divcode
        Dim DivCode As New SqlParameter("@DivCode", SqlDbType.VarChar, 10)
        DivCode.Direction = ParameterDirection.Input
        DivCode.Value = txtADivCode.Text.ToString.Trim
        Params(9) = DivCode

        Try
            BusinessObject.Sub_Insert(ServerPath2, "SupMR_Insert", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Sub_Update()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim DSMtmp As String, PMRtmp As String, recDSM As String, recPMR As String, recSD As String

        'recDSM = Trim(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 0).ToString)
        'recPMR = Trim(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 2).ToString)
        'recSD = Format(CDate(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 4).ToString), "MM/dd/yyyy")
        DSMtmp = Trim(txtDSMcode.Text)
        PMRtmp = Trim(txtPMRcode.Text)

        If DSMtmp = recDSM And PMRtmp = recPMR And TxtStartDate.Text = recSD Then

            Dim Params(8) As SqlParameter
            Dim s As String

            Dim SupCode As New SqlParameter("@SupCode", SqlDbType.VarChar, 10)
            SupCode.Direction = ParameterDirection.Input
            SupCode.Value = Trim(txtDSMcode.Text)
            Params(0) = SupCode

            Dim MrCode As New SqlParameter("@MrCode", SqlDbType.VarChar, 10)
            MrCode.Direction = ParameterDirection.Input
            MrCode.Value = Trim(txtPMRcode.Text)
            Params(1) = MrCode

            Dim EndDate As New SqlParameter("@End_Date", SqlDbType.DateTime, 10)
            EndDate.Direction = ParameterDirection.Input
            EndDate.Value = Trim(TxtEndDate.Text) '& GetDateTimeNow(" h:mm:ss tt")
            Params(2) = EndDate

            Dim Rownumber As New SqlParameter("@Rownumber", SqlDbType.Int)
            Rownumber.Direction = ParameterDirection.Input
            Rownumber.Value = Trim(txtRowid.Text)
            Params(3) = Rownumber

            'added-DBrion --v
            Dim TeamDivision As New SqlParameter("@TeamDivision", SqlDbType.VarChar, 50)
            TeamDivision.Direction = ParameterDirection.Input
            TeamDivision.Value = Trim(txtTDiv.Text)
            Params(4) = TeamDivision

            Dim Division As New SqlParameter("@Division", SqlDbType.VarChar, 30)
            Division.Direction = ParameterDirection.Input
            Division.Value = Trim(txtADiv.Text)
            Params(5) = Division
            'added-DBrion --^

            Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime, 10)
            UpdateDate.Direction = ParameterDirection.Input
            UpdateDate.Value = GetDateTimeNow()
            Params(6) = UpdateDate

            Dim LastUser As New SqlParameter("@LastUser", SqlDbType.VarChar, 10)
            LastUser.Direction = ParameterDirection.Input
            LastUser.Value = IIf(Trim(gCurrUser) = "", "", gCurrUser)      ' Trim(TxtLastUser.Text)
            Params(7) = LastUser

            Dim DivCode As New SqlParameter("@DivCode", SqlDbType.VarChar, 10)
            DivCode.Direction = ParameterDirection.Input
            DivCode.Value = txtADivCode.Text.ToString.Trim
            Params(8) = DivCode

            Try
                BusinessObject.Sub_Update(ServerPath2, "SupMR_Update2", CommandType.StoredProcedure, _
                                          Params)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Dim Params(9) As SqlParameter
            Dim s As String

            Dim SupCode As New SqlParameter("@SupCode", SqlDbType.VarChar, 10)
            SupCode.Direction = ParameterDirection.Input
            SupCode.Value = Trim(txtDSMcode.Text)
            Params(0) = SupCode

            Dim MrCode As New SqlParameter("@MrCode", SqlDbType.VarChar, 10)
            MrCode.Direction = ParameterDirection.Input
            MrCode.Value = Trim(txtPMRcode.Text)
            Params(1) = MrCode

            Dim StartDate As New SqlParameter("@Start_Date", SqlDbType.DateTime, 10)
            StartDate.Direction = ParameterDirection.Input
            StartDate.Value = Trim(TxtStartDate.Text) '& GetDateTimeNow(" h:mm:ss tt")
            Params(2) = StartDate

            Dim EndDate As New SqlParameter("@End_Date", SqlDbType.DateTime, 10)
            EndDate.Direction = ParameterDirection.Input
            EndDate.Value = Trim(TxtEndDate.Text) '& GetDateTimeNow(" h:mm:ss tt")
            Params(3) = EndDate

            Dim Rownumber As New SqlParameter("@Rownumber", SqlDbType.Int)
            Rownumber.Direction = ParameterDirection.Input
            Rownumber.Value = Trim(txtRowid.Text)
            Params(4) = Rownumber

            'added-DBrion --v
            Dim TeamDivision As New SqlParameter("@TeamDivision", SqlDbType.VarChar, 50)
            TeamDivision.Direction = ParameterDirection.Input
            TeamDivision.Value = Trim(txtTDiv.Text)
            Params(5) = TeamDivision

            Dim Division As New SqlParameter("@Division", SqlDbType.VarChar, 30)
            Division.Direction = ParameterDirection.Input
            Division.Value = Trim(txtADiv.Text)
            Params(6) = Division
            'added-DBrion --^

            Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime, 10)
            UpdateDate.Direction = ParameterDirection.Input
            UpdateDate.Value = GetDateTimeNow()
            Params(7) = UpdateDate

            Dim LastUser As New SqlParameter("@LastUser", SqlDbType.VarChar, 10)
            LastUser.Direction = ParameterDirection.Input
            LastUser.Value = IIf(Trim(gCurrUser) = "", "", gCurrUser)      ' Trim(TxtLastUser.Text)
            Params(8) = LastUser

            Dim DivCode As New SqlParameter("@DivCode", SqlDbType.VarChar, 10)
            DivCode.Direction = ParameterDirection.Input
            DivCode.Value = txtADivCode.Text.ToString.Trim
            Params(9) = DivCode

            Try
                BusinessObject.Sub_Update(ServerPath2, "SupMR_Update", CommandType.StoredProcedure, _
                                          Params)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub frmSupMr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        modControlBehavior.EnableControlsGroup(Me, True)
        If DSM_EditMode = True Then
            txtDSMcode.Text = Fld0
            txtDSMdesc.Text = Fld1
            If Trim(Fld4) = "" Or Fld4 Is DBNull.Value Then
                TxtStartDate.Text = ""
            Else
                TxtStartDate.Text = Format(CDate(Fld4), "MM/dd/yyyy")
            End If
            If Trim(Fld5) = "" Or Fld5 Is DBNull.Value Then
                TxtEndDate.Text = ""
            Else
                TxtEndDate.Text = Format(CDate(Fld5), "MM/dd/yyyy")
            End If
            txtRowid.Text = Fld6
            txtTDiv.Text = Fld7
            txtADiv.Text = Fld8
            If Trim(Fld9) = "" Or Fld9 Is DBNull.Value Then
                lblCreateDate.Text = ""
            Else
                lblCreateDate.Text = Format(CDate(Fld9), "MM/dd/yyyy")
            End If
            If Trim(Fld10) = "" Or Fld10 Is DBNull.Value Then
                lblUpdateDate.Text = ""
            Else
                lblUpdateDate.Text = Format(CDate(Fld10), "MM/dd/yyyy")
            End If
            TxtLastUser.Text = Fld11
            'inserted by angelo, divcode
            txtADivCode.Text = Fld21
        Else
            'End Date should be 12/31/2078 when Add mode by ARValdez 0313/2014
            TxtEndDate.Text = "12/31/2078"
        End If
        txtPMRcode.Text = Fld2
        txtPMRdesc.Text = Fld3
    End Sub

    Private Sub TxtStartDate_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtStartDate.KeyUp
        If e.KeyValue = 13 Then      ' tests if the key pressed is the "enter key"
            SendKeys.Send("{TAB}")   ' sends the focus to the next control/tabstop
        End If
    End Sub

    Private Sub TxtStartDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtStartDate.Validating
        On Error GoTo errpt
        If Trim(TxtStartDate.Text) = "" Then       'entering w/o putting value
            TxtStartDate.Text = GetDateTimeNow("MM") & "/01/" & GetDateTimeNow("yyyy")
            tmpSD = Format(CDate(TxtStartDate.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
            TxtEndDate.Text = GetEOM(TxtStartDate.Text)
            Exit Sub
        Else
            TxtStartDate.Text = DatValid(TxtStartDate.Text)  'validating the entry. the textbox's value will be "mm/dd/yyyy" if the entry is invalid.
            If Trim(TxtStartDate.Text) = "mm/dd/yyyy" Then
                GoTo errpt
            Else
                TxtStartDate.Text = Mid(Trim(TxtStartDate.Text), 1, 2) & "/01/" & _
                                    Mid(Trim(TxtStartDate.Text), 7, 4)   'making the date the start of the month entered
                tmpSD = Format(CDate(TxtStartDate.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt") 'will use this variable in saving
                'TxtEndDate.Text = GetEOM(TxtStartDate.Text)
            End If
            Exit Sub
        End If
errpt:
        e.Cancel = True  'brings back the focus to TxtStartDate textbox. only in Validating event
    End Sub

    Private Sub TxtEndDate_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtEndDate.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TxtEndDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtEndDate.Validating
        On Error GoTo errpt
        If Trim(TxtEndDate.Text) = "" Then
            TxtEndDate.Text = "12/31/2078"
            tmpED = Format(CDate(TxtEndDate.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
            Exit Sub
        Else
            TxtEndDate.Text = DatValid(TxtEndDate.Text)
            If Trim(TxtEndDate.Text) = "mm/dd/yyyy" Then
                GoTo errpt
            Else
                If Trim(TxtStartDate.Text) <> "" Then
                    If CDate(TxtStartDate.Text) < CDate(TxtEndDate.Text) Then
                        'TxtEndDate.Text = GetEOM(Trim(TxtEndDate.Text))
                        'tmpED = Format(CDate(TxtEndDate.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
                        Exit Sub
                    ElseIf Month(CDate(TxtStartDate.Text)) > Month(CDate(TxtEndDate.Text)) Then
                        MessageBox.Show("The End date should be a month later than the Start date!")
                    End If
                End If
            End If
        End If
errpt:
        e.Cancel = True
    End Sub

    Private Sub btnDSM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDSM.Click
        Dim popupFrm As New frmCodDesc
        StordProcName = "SupMr_DSMcombo_i"
        popupFrm.ShowDialog(Me)
        txtDSMcode.Text = gCode
        txtDSMdesc.Text = gDesc
    End Sub

    Private Sub txtDSMcode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDSMcode.GotFocus
        txtDSMcode.SelectAll()
    End Sub

    Private Sub txtDSMcode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDSMcode.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtDSMcode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDSMcode.Validating
        If Trim(txtDSMcode.Text) = "" Or Trim(txtDSMcode.Text) Is DBNull.Value Then
            txtDSMdesc.Select()
            txtDSMdesc.SelectAll()
        Else
            'If Trim(txtDSMdesc.Text) = "" Or Trim(txtDSMdesc.Text) Is DBNull.Value Then
            z = "select supname from newscores..supervisor "
            z = z & "where supcode = '" & Trim(txtDSMcode.Text) & "' "
            txtDSMdesc.Text = FindValue(z)
            'End If
        End If
    End Sub

    Private Sub txtDSMdesc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDSMdesc.GotFocus
        txtDSMdesc.SelectAll()
    End Sub

    Private Sub txtDSMdesc_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDSMdesc.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtDSMdesc_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDSMdesc.Validating
        Dim popupFrm As New frmCodDesc
        If Trim(txtDSMdesc.Text) = "" Then
            txtDSMcode.Select()
            txtDSMcode.SelectAll()
        Else
            If InStr(Trim(txtDSMdesc.Text), "*") > 0 Then
                z = "select rtrim(supcode) xcode, rtrim(supname) xdesc from newscores..supervisor "
                z = z & "where supname like '" & Trim(StrTran(txtDSMdesc.Text, "*", "%")) & "' "
                StordProcName = z
                SPparam = True
                popupFrm.ShowDialog(Me)
                txtDSMcode.Text = gCode
                txtDSMdesc.Text = gDesc
            End If
        End If
    End Sub

    Private Sub btnADiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnADiv.Click
        'Dim popupFrm As New frmDesc
        Dim popupFrm As New frmCodDesc
        StordProcName = "SupMR_ADivCombo_a"
        popupFrm.ShowDialog(Me)
        txtADiv.Text = gDesc
        txtADivCode.Text = gCode
    End Sub

    Private Sub txtADiv_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtADiv.GotFocus
        txtADiv.SelectAll()
    End Sub

    Private Sub btnTDiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTDiv.Click
        'modified by angelo,02/10/2015 Dim popupFrm As New frmDesc
        Dim popupFrm As New frmCodDesc
        StordProcName = "SupMR_TDivCombo_a"
        popupFrm.ShowDialog(Me)
        txtTDiv.Text = gDesc
    End Sub

    Private Sub txtTDiv_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTDiv.GotFocus
        txtTDiv.SelectAll()
    End Sub
End Class