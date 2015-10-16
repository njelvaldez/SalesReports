Imports System.Data.SqlClient
Imports Microsoft

Public Class SupNSM
    Inherits System.Windows.Forms.Form
    Private RemoteDataSet As New CodeTablesDS
    Private RemoteDataSet2 As New MyDataSetDB
    Private EditMode As Boolean = False
    Private oldDs As String, tmpLD As String, tmpID As String, tmpSD As String, tmpED As String

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        ComboNSM_Load()
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
    Friend WithEvents txtLastUser As System.Windows.Forms.TextBox
    Friend WithEvents txtRowid As System.Windows.Forms.TextBox
    Friend WithEvents txtSupCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtStartDate As System.Windows.Forms.TextBox
    Friend WithEvents txtEndDate As System.Windows.Forms.TextBox
    Friend WithEvents txtCreateDate As System.Windows.Forms.TextBox
    Friend WithEvents txtUpdateDate As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents SqlValue As System.Windows.Forms.ComboBox
    Friend WithEvents cboNSM As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtStartDate = New System.Windows.Forms.TextBox
        Me.txtEndDate = New System.Windows.Forms.TextBox
        Me.txtCreateDate = New System.Windows.Forms.TextBox
        Me.txtUpdateDate = New System.Windows.Forms.TextBox
        Me.txtLastUser = New System.Windows.Forms.TextBox
        Me.txtRowid = New System.Windows.Forms.TextBox
        Me.txtSupCode = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.SqlValue = New System.Windows.Forms.ComboBox
        Me.cboNSM = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'txtStartDate
        '
        Me.txtStartDate.Location = New System.Drawing.Point(80, 79)
        Me.txtStartDate.Name = "txtStartDate"
        Me.txtStartDate.Size = New System.Drawing.Size(77, 20)
        Me.txtStartDate.TabIndex = 2
        Me.txtStartDate.Tag = "Input"
        Me.txtStartDate.Text = ""
        '
        'txtEndDate
        '
        Me.txtEndDate.Location = New System.Drawing.Point(80, 110)
        Me.txtEndDate.Name = "txtEndDate"
        Me.txtEndDate.Size = New System.Drawing.Size(77, 20)
        Me.txtEndDate.TabIndex = 3
        Me.txtEndDate.Tag = "Input"
        Me.txtEndDate.Text = ""
        '
        'txtCreateDate
        '
        Me.txtCreateDate.BackColor = System.Drawing.SystemColors.Info
        Me.txtCreateDate.Enabled = False
        Me.txtCreateDate.Location = New System.Drawing.Point(256, 79)
        Me.txtCreateDate.Name = "txtCreateDate"
        Me.txtCreateDate.ReadOnly = True
        Me.txtCreateDate.Size = New System.Drawing.Size(77, 20)
        Me.txtCreateDate.TabIndex = 10
        Me.txtCreateDate.Tag = "Input"
        Me.txtCreateDate.Text = ""
        '
        'txtUpdateDate
        '
        Me.txtUpdateDate.BackColor = System.Drawing.SystemColors.Info
        Me.txtUpdateDate.Enabled = False
        Me.txtUpdateDate.Location = New System.Drawing.Point(256, 110)
        Me.txtUpdateDate.Name = "txtUpdateDate"
        Me.txtUpdateDate.ReadOnly = True
        Me.txtUpdateDate.Size = New System.Drawing.Size(77, 20)
        Me.txtUpdateDate.TabIndex = 11
        Me.txtUpdateDate.Tag = "Input"
        Me.txtUpdateDate.Text = ""
        '
        'txtLastUser
        '
        Me.txtLastUser.BackColor = System.Drawing.Color.Aquamarine
        Me.txtLastUser.Location = New System.Drawing.Point(22, 158)
        Me.txtLastUser.Name = "txtLastUser"
        Me.txtLastUser.Size = New System.Drawing.Size(70, 20)
        Me.txtLastUser.TabIndex = 83
        Me.txtLastUser.Tag = "Input"
        Me.txtLastUser.Text = ""
        Me.txtLastUser.Visible = False
        '
        'txtRowid
        '
        Me.txtRowid.BackColor = System.Drawing.Color.Aquamarine
        Me.txtRowid.Location = New System.Drawing.Point(5, 158)
        Me.txtRowid.Name = "txtRowid"
        Me.txtRowid.Size = New System.Drawing.Size(13, 20)
        Me.txtRowid.TabIndex = 82
        Me.txtRowid.Tag = "Input"
        Me.txtRowid.Text = ""
        Me.txtRowid.Visible = False
        '
        'txtSupCode
        '
        Me.txtSupCode.BackColor = System.Drawing.Color.Aquamarine
        Me.txtSupCode.Location = New System.Drawing.Point(97, 158)
        Me.txtSupCode.Name = "txtSupCode"
        Me.txtSupCode.Size = New System.Drawing.Size(70, 20)
        Me.txtSupCode.TabIndex = 84
        Me.txtSupCode.Tag = "Input"
        Me.txtSupCode.Text = ""
        Me.txtSupCode.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(4, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 20)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Description"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(4, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "Start Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(4, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "End Date"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(180, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 20)
        Me.Label5.TabIndex = 89
        Me.Label5.Text = "Create Date"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(180, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 20)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "Update Date"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(330, 32)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "Segment Head for TM"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(3, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(332, 34)
        Me.Label8.TabIndex = 92
        '
        'cmdCancel
        '
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdCancel.Location = New System.Drawing.Point(77, 143)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(92, 23)
        Me.cmdCancel.TabIndex = 5
        Me.cmdCancel.Tag = "Cancel"
        Me.cmdCancel.Text = "Cancel"
        '
        'cmdSave
        '
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSave.Location = New System.Drawing.Point(169, 143)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(92, 23)
        Me.cmdSave.TabIndex = 4
        Me.cmdSave.Tag = "Save"
        Me.cmdSave.Text = "Save"
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Location = New System.Drawing.Point(34, 137)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(270, 2)
        Me.Label10.TabIndex = 95
        '
        'SqlValue
        '
        Me.SqlValue.BackColor = System.Drawing.Color.Aquamarine
        Me.SqlValue.Location = New System.Drawing.Point(305, 158)
        Me.SqlValue.Name = "SqlValue"
        Me.SqlValue.Size = New System.Drawing.Size(146, 21)
        Me.SqlValue.TabIndex = 96
        Me.SqlValue.Visible = False
        '
        'cboNSM
        '
        Me.cboNSM.DropDownWidth = 260
        Me.cboNSM.ItemHeight = 13
        Me.cboNSM.Location = New System.Drawing.Point(80, 48)
        Me.cboNSM.Name = "cboNSM"
        Me.cboNSM.Size = New System.Drawing.Size(253, 21)
        Me.cboNSM.TabIndex = 97
        Me.cboNSM.Tag = "Input"
        '
        'SupNSM
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(338, 171)
        Me.Controls.Add(Me.cboNSM)
        Me.Controls.Add(Me.SqlValue)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSupCode)
        Me.Controls.Add(Me.txtLastUser)
        Me.Controls.Add(Me.txtRowid)
        Me.Controls.Add(Me.txtUpdateDate)
        Me.Controls.Add(Me.txtCreateDate)
        Me.Controls.Add(Me.txtEndDate)
        Me.Controls.Add(Me.txtStartDate)
        Me.Controls.Add(Me.Label8)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Name = "SupNSM"
        Me.Text = "TM's Segment Head"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub SupNSM_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Itm_EditMode = False Then
            EditMode = False
            btnSw = True
            cboNSM.Select()
        End If
    End Sub

    Private Sub ComboNSM_Load()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "NSM_Combo", CommandType.StoredProcedure, RemoteDataSet2, "NSM_Combo")
        cboNSM.DataSource = RemoteDataSet2.NSM_Combo
        cboNSM.DisplayMember = "NSMcode"
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If (MessageBox.Show("Are you sure you want to Save this Entry?", "Confirm Saving", _
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)) _
            = DialogResult.Yes Then

            If Trim(cboNSM.Text) = "" Then
                MessageBox.Show("Mandatory field!")
                cboNSM.Select()
                Exit Sub
            End If
            If Trim(txtStartDate.Text) = "" Then
                MessageBox.Show("Mandatory field!")
                txtStartDate.Select()
                Exit Sub
            End If
            If Trim(txtEndDate.Text) = "" Then
                MessageBox.Show("Mandatory field!")
                txtEndDate.Select()
                Exit Sub
            End If
            txtLastUser.Text = gCurrUser
            If Itm_EditMode = False Then
                Sub_Insert()
            Else
                Sub_Update()
            End If
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Sub_Insert()
        Try

            Dim MyLoadedForm As New SupervisorCT
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(7) As SqlParameter
            Dim Prams(0) As SqlParameter
            Dim s As String

            s = "select nsmcode as fld1 from ScoresDotNet..supervisornsm " & Chr(13)
            s = s & "where supcode = '" & Trim(txtSupCode.Text) & "' " & Chr(13)
            s = s & "  and nsmcode + '--' + nsmname = '"
            s = s & GetCode(cboNSM.Text) & "--" & GetDescription(cboNSM.Text) & "' " & Chr(13)
            s = s & "  and ('" & Trim(txtStartDate.Text) & "' between startdate and enddate " & Chr(13)
            s = s & "   or  '" & Trim(txtEndDate.Text) & "' between startdate and enddate) "
            Dim SQLstmnt As New SqlParameter("@SqlQry", SqlDbType.NVarChar, 2950)
            SQLstmnt.Direction = ParameterDirection.Input
            SQLstmnt.Value = s
            Prams(0) = SQLstmnt
            Try
                BusinessObject.Sub_Show(ServerPath2, "GenericQryProc", CommandType.StoredProcedure, _
                                        RemoteDataSet2, "GenericQryProc", Prams)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            SqlValue.DataSource = RemoteDataSet2.GenericQryProc
            SqlValue.DisplayMember = "fld1"
            If Trim(SqlValue.Text) <> "" Then
                MessageBox.Show("This entry conflicts with a previous entry! Please try again.")
                cboNSM.Select()
                cboNSM.SelectAll()
                SqlValue.ResetText()
                SqlValue.DataSource = Nothing
                RemoteDataSet2.GenericQryProc.Clear()
                Exit Sub
            Else
                SqlValue.ResetText()
                SqlValue.DataSource = Nothing
                RemoteDataSet2.GenericQryProc.Clear()
            End If

            Dim SupCode As New SqlParameter("@SupCode", SqlDbType.VarChar, 10)
            SupCode.Direction = ParameterDirection.Input
            SupCode.Value = Trim(txtSupCode.Text)
            Params(0) = SupCode

            Dim NsmCode As New SqlParameter("@NsmCode", SqlDbType.VarChar, 25)
            NsmCode.Direction = ParameterDirection.Input
            NsmCode.Value = GetCode(cboNSM.Text)
            Params(1) = NsmCode

            Dim NsmName As New SqlParameter("@NsmName", SqlDbType.VarChar, 75)
            NsmName.Direction = ParameterDirection.Input
            NsmName.Value = GetDescription(cboNSM.Text)
            Params(2) = NsmName

            Dim CreateDate As New SqlParameter("@CreateDate", SqlDbType.DateTime, 10)
            CreateDate.Direction = ParameterDirection.Input
            CreateDate.Value = GetDateTimeNow("MM/dd/yyyy")
            Params(3) = CreateDate

            Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime, 10)
            UpdateDate.Direction = ParameterDirection.Input
            UpdateDate.Value = GetDateTimeNow("MM/dd/yyyy")
            Params(4) = UpdateDate

            Dim StartDate As New SqlParameter("@StartDate", SqlDbType.DateTime, 10)
            StartDate.Direction = ParameterDirection.Input
            StartDate.Value = Trim(txtStartDate.Text)
            Params(5) = StartDate

            Dim EndDate As New SqlParameter("@EndDate", SqlDbType.DateTime, 10)
            EndDate.Direction = ParameterDirection.Input
            EndDate.Value = Trim(txtEndDate.Text)
            Params(6) = EndDate

            Dim LastUser As New SqlParameter("@LastUser", SqlDbType.VarChar, 10)
            LastUser.Direction = ParameterDirection.Input
            LastUser.Value = IIf(Trim(gCurrUser) = "", "", gCurrUser)      ' Trim(txtLastUser.Text)
            Params(7) = LastUser

            BusinessObject.Sub_Insert(ServerPath2, "SupervisorCT_NSM_Insert", CommandType.StoredProcedure, Params)
            MyLoadedForm.DataGrid2.DataSource = Nothing
            Itm_EditMode = False
            Me.Close()
            
            LogHelper.InsertLog("SupervisorCT_NSM_Insert.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("SupervisorCT_NSM_Insert.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Sub_Update()
        Try

            Dim MyLoadedForm As New SupervisorCT
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(6) As SqlParameter
            Dim Prams(0) As SqlParameter
            Dim s As String

            s = "select nsmcode as fld1 from ScoresDotNet..supervisornsm "
            s = s & "where nsmcode + '--' + nsmname = '" & _
                    GetCode(cboNSM.Text) & "--" & GetDescription(cboNSM.Text) & "' "
            s = s & "  and startdate = '" & Trim(txtStartDate.Text) & "' "
            Dim SQLstmnt As New SqlParameter("@SqlQry", SqlDbType.NVarChar, 2950)
            SQLstmnt.Direction = ParameterDirection.Input
            SQLstmnt.Value = s
            Prams(0) = SQLstmnt
            Try
                BusinessObject.Sub_Show(ServerPath2, "GenericQryProc", CommandType.StoredProcedure, _
                                        RemoteDataSet2, "GenericQryProc", Prams)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            SqlValue.DataSource = RemoteDataSet2.GenericQryProc
            SqlValue.DisplayMember = "fld1"
            If Trim(SqlValue.Text) <> "" Then
                MessageBox.Show("Conflict with this entry! Please try again.")
                cboNSM.Select()
                cboNSM.SelectAll()
                SqlValue.ResetText()
                SqlValue.DataSource = Nothing
                RemoteDataSet2.GenericQryProc.Clear()
                Exit Sub
            Else
                SqlValue.ResetText()
                SqlValue.DataSource = Nothing
                RemoteDataSet2.GenericQryProc.Clear()
            End If

            Dim Rowid As New SqlParameter("@Rowid", SqlDbType.Int)
            Rowid.Direction = ParameterDirection.Input
            Rowid.Value = Trim(txtRowid.Text)
            Params(0) = Rowid

            Dim NsmCode As New SqlParameter("@NsmCode", SqlDbType.VarChar, 75)
            NsmCode.Direction = ParameterDirection.Input
            NsmCode.Value = GetCode(cboNSM.Text)
            Params(1) = NsmCode

            Dim NsmName As New SqlParameter("@NsmName", SqlDbType.VarChar, 75)
            NsmName.Direction = ParameterDirection.Input
            NsmName.Value = GetDescription(cboNSM.Text)
            Params(2) = NsmName

            Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime, 10)
            UpdateDate.Direction = ParameterDirection.Input
            UpdateDate.Value = GetDateTimeNow("MM/dd/yyyy")
            Params(3) = UpdateDate

            Dim StartDate As New SqlParameter("@StartDate", SqlDbType.DateTime, 10)
            StartDate.Direction = ParameterDirection.Input
            StartDate.Value = Trim(txtStartDate.Text)
            Params(4) = StartDate

            Dim EndDate As New SqlParameter("@EndDate", SqlDbType.DateTime, 10)
            EndDate.Direction = ParameterDirection.Input
            EndDate.Value = Trim(txtEndDate.Text)
            Params(5) = EndDate

            Dim LastUser As New SqlParameter("@LastUser", SqlDbType.VarChar, 10)
            LastUser.Direction = ParameterDirection.Input
            LastUser.Value = IIf(Trim(gCurrUser) = "", "", gCurrUser)      ' Trim(txtLastUser.Text)
            Params(6) = LastUser

            BusinessObject.Sub_Update(ServerPath2, "SupervisorCT_NSM_Update", CommandType.StoredProcedure, Params)
            MyLoadedForm.DataGrid2.DataSource = Nothing
            Itm_EditMode = False
            Me.Close()
  
            LogHelper.InsertLog("SupervisorCT_NSM_Update.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("SupervisorCT_NSM_Update.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub cboNSM_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboNSM.KeyUp
        If e.KeyData.ToString = System.Windows.Forms.Keys.Up.ToString _
           Or e.KeyData.ToString = System.Windows.Forms.Keys.Left.ToString Then 'if key pressed is the up arrow it will select the next selection before the selction
            cboNSM.SelectedItem = cboNSM.SelectedIndex - 1
        ElseIf e.KeyData.ToString = System.Windows.Forms.Keys.Down.ToString _
           Or e.KeyData.ToString = System.Windows.Forms.Keys.Right.ToString Then 'if key pressed is the up arrow it will select the next selection after the selction
            cboNSM.SelectedItem = cboNSM.SelectedIndex + 1
        ElseIf DKcodes(e.KeyData) = True Then    'checking if the key pressed is alphanumeric (to disallow typing the entry)
            cboNSM.Text = ""     'if alphanumeric then the value of the field will be erased
        End If
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")      'moves control to the next control or field
        End If
    End Sub

    Private Sub TxtStartDate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStartDate.Click
        txtStartDate.SelectAll()
    End Sub

    Private Sub TxtStartDate_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStartDate.KeyUp
        If e.KeyValue = 13 Then      ' tests if the key pressed is the "enter key"
            SendKeys.Send("{TAB}")   ' sends the focus to the next control/tabstop
        End If
    End Sub

    Private Sub TxtStartDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtStartDate.Validating
        On Error GoTo errpt
        If Trim(txtStartDate.Text) = "" Then       'entering w/o putting value
            txtStartDate.Text = GetDateTimeNow("MM") & "/01/" & GetDateTimeNow("yyyy")
            Exit Sub
        Else
            txtStartDate.Text = DatValid(txtStartDate.Text)  'validating the entry. the textbox's value will be "mm/dd/yyyy" if the entry is invalid.
            If Trim(txtStartDate.Text) = "mm/dd/yyyy" Then
                GoTo errpt
            Else
                txtStartDate.Text = Mid(Trim(txtStartDate.Text), 1, 2) & "/01/" & _
                                    Mid(Trim(txtStartDate.Text), 7, 4)   'making the date the start of the month entered
            End If
            Exit Sub
        End If
errpt:
        e.Cancel = True  'brings back the focus to TxtStartDate textbox. only in Validating event
    End Sub

    Private Sub TxtEndDate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEndDate.Click
        txtEndDate.SelectAll()
    End Sub

    Private Sub TxtEndDate_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEndDate.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TxtEndDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEndDate.Validating
        On Error GoTo errpt
        If Trim(txtEndDate.Text) = "" Then
            txtEndDate.Text = "12/31/2078"
            Exit Sub
        Else
            txtEndDate.Text = DatValid(txtEndDate.Text)
            If Trim(txtEndDate.Text) = "mm/dd/yyyy" Then
                GoTo errpt
            Else
                If Trim(txtStartDate.Text) <> "" Then
                    If CDate(txtStartDate.Text) < CDate(txtEndDate.Text) Then
                        txtEndDate.Text = GetEOM(Trim(txtEndDate.Text))
                        Exit Sub
                    ElseIf Month(CDate(txtStartDate.Text)) > Month(CDate(txtEndDate.Text)) Then
                        MessageBox.Show("The End date should be a month later than the Start date!")
                    End If
                End If
            End If
        End If
errpt:
        e.Cancel = True
    End Sub
End Class
