Imports System.Data.SqlClient
Imports System.EnterpriseServices

Public Class frmProcessMercuryData
    Inherits System.Windows.Forms.Form
    Private RemoteDataSet As New dsMercuryData
    Private RemoteDataSet2 As New MyDataSetDB

    Dim lines As Integer, lWrit As Integer
    Dim refDat As String, refMo As String, refYr As String



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
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents btnFile As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents col_BCode As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_BName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_MItemcode As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_ItemCode As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_ItemDesc As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_MrCode As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_SupCode As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblStat As System.Windows.Forms.Label
    Friend WithEvents ProgBar As System.Windows.Forms.ProgressBar
    Friend WithEvents SqlValue As System.Windows.Forms.ComboBox
    Friend WithEvents col_RowNumber As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_Address1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents RR As System.Windows.Forms.Label
    Friend WithEvents RR_eq As System.Windows.Forms.Label
    Friend WithEvents RW_eq As System.Windows.Forms.Label
    Friend WithEvents RW As System.Windows.Forms.Label
    Friend WithEvents RD_eq As System.Windows.Forms.Label
    Friend WithEvents RD As System.Windows.Forms.Label
    Friend WithEvents RE_eq As System.Windows.Forms.Label
    Friend WithEvents RE As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmProcessMercuryData))
        Me.btnProcess = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtFileName = New System.Windows.Forms.TextBox
        Me.btnFile = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.col_RowNumber = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_BCode = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_BName = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_Address1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_MItemcode = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_ItemCode = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_ItemDesc = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_MrCode = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_SupCode = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Label3 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.ProgBar = New System.Windows.Forms.ProgressBar
        Me.lblStat = New System.Windows.Forms.Label
        Me.SqlValue = New System.Windows.Forms.ComboBox
        Me.RR = New System.Windows.Forms.Label
        Me.RR_eq = New System.Windows.Forms.Label
        Me.RW_eq = New System.Windows.Forms.Label
        Me.RW = New System.Windows.Forms.Label
        Me.RD_eq = New System.Windows.Forms.Label
        Me.RD = New System.Windows.Forms.Label
        Me.RE_eq = New System.Windows.Forms.Label
        Me.RE = New System.Windows.Forms.Label
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnProcess
        '
        Me.btnProcess.Enabled = False
        Me.btnProcess.Location = New System.Drawing.Point(182, 60)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(96, 20)
        Me.btnProcess.TabIndex = 8
        Me.btnProcess.Text = "Process"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Please select a file to process..."
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(11, 26)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(268, 20)
        Me.txtFileName.TabIndex = 6
        Me.txtFileName.Text = ""
        '
        'btnFile
        '
        Me.btnFile.Location = New System.Drawing.Point(286, 26)
        Me.btnFile.Name = "btnFile"
        Me.btnFile.Size = New System.Drawing.Size(24, 20)
        Me.btnFile.TabIndex = 5
        Me.btnFile.Text = "..."
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(9, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(304, 2)
        Me.Label2.TabIndex = 9
        '
        'DataGrid1
        '
        Me.DataGrid1.CaptionText = "Records w/ missing details"
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(11, 111)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(880, 370)
        Me.DataGrid1.TabIndex = 10
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.DataGrid1.Visible = False
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Cyan
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightCyan
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.col_RowNumber, Me.col_BCode, Me.col_BName, Me.col_Address1, Me.col_MItemcode, Me.col_ItemCode, Me.col_ItemDesc, Me.col_MrCode, Me.col_SupCode})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "MercuryStatCount"
        '
        'col_RowNumber
        '
        Me.col_RowNumber.Format = ""
        Me.col_RowNumber.FormatInfo = Nothing
        Me.col_RowNumber.HeaderText = "RowNum"
        Me.col_RowNumber.MappingName = "rownumber"
        Me.col_RowNumber.NullText = ""
        Me.col_RowNumber.Width = 60
        '
        'col_BCode
        '
        Me.col_BCode.Format = ""
        Me.col_BCode.FormatInfo = Nothing
        Me.col_BCode.HeaderText = "Code"
        Me.col_BCode.MappingName = "branchcode"
        Me.col_BCode.NullText = ""
        Me.col_BCode.Width = 30
        '
        'col_BName
        '
        Me.col_BName.Format = ""
        Me.col_BName.FormatInfo = Nothing
        Me.col_BName.HeaderText = "Mercury Branch"
        Me.col_BName.MappingName = "branchname"
        Me.col_BName.NullText = ""
        Me.col_BName.Width = 200
        '
        'col_Address1
        '
        Me.col_Address1.Format = ""
        Me.col_Address1.FormatInfo = Nothing
        Me.col_Address1.HeaderText = "Address"
        Me.col_Address1.MappingName = "address1"
        Me.col_Address1.NullText = ""
        Me.col_Address1.Width = 230
        '
        'col_MItemcode
        '
        Me.col_MItemcode.Format = ""
        Me.col_MItemcode.FormatInfo = Nothing
        Me.col_MItemcode.HeaderText = "MercCode"
        Me.col_MItemcode.MappingName = "mItemCode"
        Me.col_MItemcode.NullText = ""
        Me.col_MItemcode.Width = 60
        '
        'col_ItemCode
        '
        Me.col_ItemCode.Format = ""
        Me.col_ItemCode.FormatInfo = Nothing
        Me.col_ItemCode.HeaderText = "ItemCode"
        Me.col_ItemCode.MappingName = "itemcode"
        Me.col_ItemCode.NullText = ""
        Me.col_ItemCode.Width = 60
        '
        'col_ItemDesc
        '
        Me.col_ItemDesc.Format = ""
        Me.col_ItemDesc.FormatInfo = Nothing
        Me.col_ItemDesc.HeaderText = "Item Name"
        Me.col_ItemDesc.MappingName = "itemdesc"
        Me.col_ItemDesc.NullText = ""
        Me.col_ItemDesc.Width = 220
        '
        'col_MrCode
        '
        Me.col_MrCode.Format = ""
        Me.col_MrCode.FormatInfo = Nothing
        Me.col_MrCode.HeaderText = "MR Code"
        Me.col_MrCode.MappingName = "mrcode"
        Me.col_MrCode.NullText = ""
        Me.col_MrCode.Width = 75
        '
        'col_SupCode
        '
        Me.col_SupCode.Format = ""
        Me.col_SupCode.FormatInfo = Nothing
        Me.col_SupCode.HeaderText = "SupCode"
        Me.col_SupCode.MappingName = "supcode"
        Me.col_SupCode.NullText = ""
        Me.col_SupCode.Width = 75
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(367, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 18)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Statistics Count . . . "
        Me.Label3.Visible = False
        '
        'ProgBar
        '
        Me.ProgBar.Location = New System.Drawing.Point(11, 88)
        Me.ProgBar.Name = "ProgBar"
        Me.ProgBar.Size = New System.Drawing.Size(300, 10)
        Me.ProgBar.TabIndex = 12
        '
        'lblStat
        '
        Me.lblStat.Location = New System.Drawing.Point(10, 70)
        Me.lblStat.Name = "lblStat"
        Me.lblStat.Size = New System.Drawing.Size(168, 16)
        Me.lblStat.TabIndex = 13
        Me.lblStat.Text = "Loading data please wait. . ."
        '
        'SqlValue
        '
        Me.SqlValue.Location = New System.Drawing.Point(163, 1)
        Me.SqlValue.Name = "SqlValue"
        Me.SqlValue.Size = New System.Drawing.Size(146, 21)
        Me.SqlValue.TabIndex = 63
        Me.SqlValue.Visible = False
        '
        'RR
        '
        Me.RR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RR.Location = New System.Drawing.Point(363, 66)
        Me.RR.Name = "RR"
        Me.RR.Size = New System.Drawing.Size(162, 18)
        Me.RR.TabIndex = 64
        Me.RR.Text = "Records Read                   :"
        Me.RR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RR.Visible = False
        '
        'RR_eq
        '
        Me.RR_eq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RR_eq.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RR_eq.Location = New System.Drawing.Point(529, 67)
        Me.RR_eq.Name = "RR_eq"
        Me.RR_eq.Size = New System.Drawing.Size(92, 16)
        Me.RR_eq.TabIndex = 65
        Me.RR_eq.Visible = False
        '
        'RW_eq
        '
        Me.RW_eq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RW_eq.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RW_eq.Location = New System.Drawing.Point(529, 89)
        Me.RW_eq.Name = "RW_eq"
        Me.RW_eq.Size = New System.Drawing.Size(92, 16)
        Me.RW_eq.TabIndex = 67
        Me.RW_eq.Visible = False
        '
        'RW
        '
        Me.RW.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RW.Location = New System.Drawing.Point(363, 88)
        Me.RW.Name = "RW"
        Me.RW.Size = New System.Drawing.Size(162, 18)
        Me.RW.TabIndex = 66
        Me.RW.Text = "Records Written                :"
        Me.RW.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RW.Visible = False
        '
        'RD_eq
        '
        Me.RD_eq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RD_eq.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RD_eq.Location = New System.Drawing.Point(795, 67)
        Me.RD_eq.Name = "RD_eq"
        Me.RD_eq.Size = New System.Drawing.Size(92, 16)
        Me.RD_eq.TabIndex = 69
        Me.RD_eq.Visible = False
        '
        'RD
        '
        Me.RD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RD.Location = New System.Drawing.Point(630, 66)
        Me.RD.Name = "RD"
        Me.RD.Size = New System.Drawing.Size(162, 18)
        Me.RD.TabIndex = 68
        Me.RD.Text = "Records w/ missing details:"
        Me.RD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RD.Visible = False
        '
        'RE_eq
        '
        Me.RE_eq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RE_eq.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RE_eq.Location = New System.Drawing.Point(796, 89)
        Me.RE_eq.Name = "RE_eq"
        Me.RE_eq.Size = New System.Drawing.Size(92, 16)
        Me.RE_eq.TabIndex = 71
        Me.RE_eq.Visible = False
        '
        'RE
        '
        Me.RE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RE.Location = New System.Drawing.Point(630, 88)
        Me.RE.Name = "RE"
        Me.RE.Size = New System.Drawing.Size(162, 18)
        Me.RE.TabIndex = 70
        Me.RE.Text = "Records Excluded             :"
        Me.RE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RE.Visible = False
        '
        'frmProcessMercuryData
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(896, 486)
        Me.Controls.Add(Me.RE_eq)
        Me.Controls.Add(Me.RE)
        Me.Controls.Add(Me.RD_eq)
        Me.Controls.Add(Me.RD)
        Me.Controls.Add(Me.RW_eq)
        Me.Controls.Add(Me.RW)
        Me.Controls.Add(Me.RR_eq)
        Me.Controls.Add(Me.RR)
        Me.Controls.Add(Me.SqlValue)
        Me.Controls.Add(Me.lblStat)
        Me.Controls.Add(Me.ProgBar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.btnFile)
        Me.Name = "frmProcessMercuryData"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFile.Click
        Dim LineStr As String, mDate As String, BrStr As String, ItmStr As String, QtyStr As String
        Dim myComm As New SqlCommand
        Dim myConn As New SqlConnection
        Dim myFrm As New frmProcessMercuryData
        myFrm.TopMost = True
        myFrm.ActiveForm.Height = 523
        myFrm.ActiveForm.Width = 909
        'myFrm.WindowState = FormWindowState.Normal
        Label3.Visible = False
        RR.Visible = False : RR_eq.Visible = False
        RW.Visible = False : RW_eq.Visible = False
        RD.Visible = False : RD_eq.Visible = False
        RE.Visible = False : RE_eq.Visible = False
        DataGrid1.Visible = False

        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtFileName.Text = OpenFileDialog1.FileName

            FileOpen(1, OpenFileDialog1.FileName, OpenMode.Input)
            lines = getNumLines(1)
            ProgBar.Maximum = lines + 1
            FileClose(1)

            FileOpen(1, OpenFileDialog1.FileName, OpenMode.Input)
            mDate = ""
            ProgBar.Value = 0
            For i = 0 To (lines - 1)
                LineStr = "" : BrStr = "" : ItmStr = "" : QtyStr = ""
                Input(1, LineStr)
                If Mid(LineStr, 1, 1) = "1" Then
                    mDate = ((RightStr(LineStr, 2)) & "/01/" & Mid((RightStr(LineStr, 6)), 1, 4))
                    refDat = Format(CDate(mDate), "MM/dd/yyyy")
                    lWrit = 0
                    With myComm
                        myConn.ConnectionString = ServerPath
                        myConn.Open()
                        .Connection = myConn
                        z = "delete from newscores..mercurysaledraft "
                        z = z & "where refdate = '" & Trim(refDat) & "'"
                        .CommandText = z
                        .CommandType = CommandType.Text
                        .CommandTimeout = 1200
                        .ExecuteNonQuery()
                        myConn.Close()
                    End With
                    GoTo nxt
                End If
                If Mid(LineStr, 1, 1) = "2" Then
                    BrStr = Mid(LineStr, 2, 3)
                    ItmStr = Mid(LineStr, 5, 6)
                    QtyStr = Mid(LineStr, 11, 5)
                End If
                If Trim(mDate) <> "" And Trim(BrStr) <> "" And Trim(ItmStr) <> "" And Trim(QtyStr) <> "" Then
                    With myComm
                        myConn.ConnectionString = ServerPath
                        myConn.Open()
                        .Connection = myConn
                        z = "insert into newscores..mercurysaledraft "
                        z = z & "(branchcode, mitemcode, qty, refdate) values "
                        z = z & "('" & Trim(BrStr) & "', '" & Trim(ItmStr) & "', " & Trim(QtyStr) & ", "
                        z = z & "'" & Trim(mDate) & "')"
                        .CommandText = z
                        .CommandType = CommandType.Text
                        .CommandTimeout = 3000
                        .ExecuteNonQuery()
                        myConn.Close()
                        lWrit = lWrit + 1
                    End With
                End If
                ProgBar.Value = ProgBar.Value + 1
nxt:        Next i
            FileClose(1)
        End If
        lblStat.Text = "Ready to process."
        btnProcess.Enabled = True
    End Sub

    Public Function getNumLines(ByVal fileName As Integer) As Integer
        Dim numLines As Integer
        Dim g As String
        numLines = 0
        While Not (EOF(1))
            Input(1, g)
            numLines = numLines + 1 'counts number of rows in the file
        End While
        Return numLines 'return the number of lines found
    End Function

    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click
        lblStat.Text = "Processing, please wait..."

        Dim myComm As New SqlCommand
        Dim myConn As New SqlConnection
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter
        Dim s As String

        ProgBar.Value = 0
        s = "select mitemcode as fld1 from NewScores..mercurysale "
        s = s & "where refdate = '" & Trim(refDat) & "' "
        Dim SQLstmnt As New SqlParameter("@SqlQry", SqlDbType.NVarChar, 2950)
        SQLstmnt.Direction = ParameterDirection.Input
        SQLstmnt.Value = s
        Params(0) = SQLstmnt
        'Try
        BusinessObject.Sub_Show(ServerPath2, "GenericQryProc", CommandType.StoredProcedure, RemoteDataSet2, "GenericQryProc", Params)
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        SqlValue.DataSource = RemoteDataSet2.GenericQryProc
        SqlValue.DisplayMember = "fld1"
        If Trim(SqlValue.Text) <> "" Then
            If MessageBox.Show(MoWord(Val(Mid(Trim(refDat), 1, 2))) & Mid(Trim(refDat), 7, 4) & _
                              " Records exsists! APPEND THIS EXTRACTION TO THE TABLE? ", _
                               refDat & " records exsists!", MessageBoxButtons.YesNo, _
                               MessageBoxIcon.Question, _
                               MessageBoxDefaultButton.Button2) = DialogResult.No Then

                DelB4Ins()
            Else
                If MessageBox.Show("Are you sure you want to APPEND this extraction?", "Confirm!", _
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                                    MessageBoxDefaultButton.Button1) = DialogResult.No Then

                    DelB4Ins()
                End If
            End If


        End If
        SqlValue.ResetText()
        SqlValue.DataSource = Nothing
        RemoteDataSet2.GenericQryProc.Clear()
        ProgBar.Maximum = 10

        With myComm
            myConn.ConnectionString = ServerPath
            myConn.Open()
            .Connection = myConn
            ProgBar.Value = 1
            z = "insert into mercurysale "
            z = z & "(branchcode, mitemcode, qty, refdate, rownumber) "
            z = z & "(select a.branchcode, a.mitemcode, a.qty, a.refdate, rownumber "
            z = z & "from mercurysaledraft a "
            z = z & "where a.refdate = '" & Trim(refDat) & "' )"
            .CommandText = z
            .CommandType = CommandType.Text
            .CommandTimeout = 3000
            ProgBar.Value = 2
            .ExecuteNonQuery()
            myConn.Close()
        End With

        ProgBar.Value = 3
        With myComm
            myConn.ConnectionString = ServerPath
            myConn.Open()
            ProgBar.Value = 4
            .Connection = myConn
            z = "update mercurysale set "
            z = z & "       unitprice     = dd.unitprice, "
            z = z & "       principalcode = dd.princode, "
            z = z & "       divisioncode  = dd.divcode, "
            z = z & "       mrcode        = ee.mrcode, "
            z = z & "       supcode       = ff.supcode "
            z = z & "from        mercurysale   aa "
            z = z & " inner join mercurybranch bb on aa.branchcode  = bb.branchcode "
            z = z & " inner join mercuryitem   cc on aa.mitemcode   = cc.mitemcode "
            z = z & " inner join item          dd on cc.itemcode    = dd.itemcode "
            z = z & " inner join mrarea        ee on bb.territorydr = ee.territorydr and "
            z = z & "                          dd.princode          = ee.princode and "
            z = z & "                          aa.refdate     between ee.start_date and ee.end_date "
            z = z & " inner join supmr         ff on ee.mrcode      = ff.mrcode "
            z = z & "where aa.refdate = '" & Trim(refDat) & "' "
            z = z & " and left(cc.itemcode,3) not in ('164', '171', '172') "
            .CommandText = z
            .CommandType = CommandType.Text
            .CommandTimeout = 3000
            ProgBar.Value = 5
            .ExecuteNonQuery()
            myConn.Close()
        End With
        ProgBar.Value = 6

        ProgBar.Value = 7
        Dim Prams(0) As SqlParameter
        Dim SPRefdat As New SqlParameter("@Refdat", SqlDbType.DateTime, 10)
        SPRefdat.Direction = ParameterDirection.Input
        SPRefdat.Value = Trim(refDat)
        Prams(0) = SPRefdat


        If RemoteDataSet.MercuryStatCount.Count > 0 Then RemoteDataSet.MercuryStatCount.Clear()
        ProgBar.Value = 8
        BusinessObject.Sub_Show(ServerPath, "MercExtExclude", CommandType.StoredProcedure, RemoteDataSet, "MercuryStatCount", Prams)
        DataGrid1.DataSource = RemoteDataSet.MercuryStatCount

        SqlValue.Text = ""
        SqlValue.DataSource = Nothing

        z = "select count(*) fld1 "
        z = z & "from (select * from newscores..mercurysale "
        z = z & "      where refdate = '" & Trim(refDat) & "' "
        z = z & "        and mitemcode in ( select mitemcode from newscores..mercurysaledraft where refdate = '" & Trim(refDat) & "' ) ) a "
        z = z & " inner join newscores..mercurybranch b on a.branchcode = b.branchcode "
        z = z & " inner join newscores..item c on a.mitemcode = c.mercuryitemcode "
        z = z & "where ( left(ltrim(rtrim(c.itemcode)),3) = '164' "
        z = z & "   or   left(ltrim(rtrim(c.itemcode)),3) = '171' "
        z = z & "   or   left(ltrim(rtrim(c.itemcode)),3) = '172' ) "
        'z = z & "  and ( isnull(a.branchcode, '') = '' "
        'z = z & "   or isnull(a.mitemcode, '') = '' "
        'z = z & "   or isnull(a.mrcode, '') = '' "
        'z = z & "   or isnull(a.supcode, '') = '' ) "
        Dim SQLstmnt2 As New SqlParameter("@SqlQry", SqlDbType.NVarChar, 2950)
        SQLstmnt2.Direction = ParameterDirection.Input
        SQLstmnt2.Value = z
        Params(0) = SQLstmnt2

        RemoteDataSet2.GenericQryProc.Clear()
        'Try
        BusinessObject.Sub_Show(ServerPath2, "GenericQryProc", CommandType.StoredProcedure, RemoteDataSet2, "GenericQryProc", Params)
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        ProgBar.Value = 9
        SqlValue.DataSource = RemoteDataSet2.GenericQryProc
        SqlValue.DisplayMember = "fld1"

        RR_eq.Text = Str(lines)
        RD_eq.Text = RemoteDataSet.MercuryStatCount.Count.ToString
        RE_eq.Text = SqlValue.Text
        RW_eq.Text = Str(lWrit) ' Str(Val(RR_eq.Text) - (Val(RD_eq.Text) + Val(RE_eq.Text)))

        ProgBar.Value = 10

        lblStat.Text = "Processing complete."
        btnProcess.Enabled = False
        'Dim myFrm As New frmProcessMercuryData
        'If Trim(DataGrid1.Item(0, 2).ToString) <> "" Then
        '   frmProcessMercuryData.ActiveForm.Height = 523
        '   frmProcessMercuryData.ActiveForm.Width = 909
        Label3.Visible = True
        RR.Visible = True : RR_eq.Visible = True
        RW.Visible = True : RW_eq.Visible = True
        RD.Visible = True : RD_eq.Visible = True
        RE.Visible = True : RE_eq.Visible = True
        DataGrid1.Visible = True
        'End If
    End Sub
    Private Sub DelB4Ins()
        Dim myComm As New SqlCommand
        Dim myConn As New SqlConnection
        With myComm
            myConn.ConnectionString = ServerPath
            myConn.Open()
            .Connection = myConn
            z = "delete from newscores..mercurysale "
            z = z & "where refdate = '" & Trim(refDat) & "'"
            .CommandText = z
            .CommandType = CommandType.Text
            .CommandTimeout = 120
            .ExecuteNonQuery()
            myConn.Close()
        End With
    End Sub
End Class
