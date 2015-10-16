Imports System.Data.SqlClient
Public Class frmDistributeReports
    Inherits System.Windows.Forms.Form
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdGo As System.Windows.Forms.Button
    Friend WithEvents cboReportList As System.Windows.Forms.ComboBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cboSupervisors As System.Windows.Forms.ComboBox
    Friend WithEvents chkIndividual As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCommDat As System.Windows.Forms.TextBox
    Friend WithEvents txtCommDat2 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnDiv As System.Windows.Forms.Button
    Friend WithEvents txtDivision As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmDistributeReports))
        Me.cboReportList = New System.Windows.Forms.ComboBox
        Me.cmdGo = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.chkIndividual = New System.Windows.Forms.CheckBox
        Me.cboSupervisors = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCommDat = New System.Windows.Forms.TextBox
        Me.txtCommDat2 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.btnDiv = New System.Windows.Forms.Button
        Me.txtDivision = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'cboReportList
        '
        Me.cboReportList.Enabled = False
        Me.cboReportList.Items.AddRange(New Object() {"Sales Per Medical Representative", "Mercury Sales Per Medical Representative", "Commission Report Attachment (PMR)", "Commission Report Attachment (DSM)", "Medrep Commission with Recovery", "District Manager Commission with Recovery"})
        Me.cboReportList.Location = New System.Drawing.Point(9, 62)
        Me.cboReportList.MaxDropDownItems = 10
        Me.cboReportList.Name = "cboReportList"
        Me.cboReportList.Size = New System.Drawing.Size(262, 21)
        Me.cboReportList.TabIndex = 1
        '
        'cmdGo
        '
        Me.cmdGo.Location = New System.Drawing.Point(276, 62)
        Me.cmdGo.Name = "cmdGo"
        Me.cmdGo.Size = New System.Drawing.Size(59, 21)
        Me.cmdGo.TabIndex = 5
        Me.cmdGo.Text = "Go !"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Please Choose A Report to Distribute"
        '
        'chkIndividual
        '
        Me.chkIndividual.Enabled = False
        Me.chkIndividual.Location = New System.Drawing.Point(10, 122)
        Me.chkIndividual.Name = "chkIndividual"
        Me.chkIndividual.Size = New System.Drawing.Size(71, 18)
        Me.chkIndividual.TabIndex = 4
        Me.chkIndividual.Text = "Individual"
        '
        'cboSupervisors
        '
        Me.cboSupervisors.Enabled = False
        Me.cboSupervisors.Location = New System.Drawing.Point(89, 118)
        Me.cboSupervisors.Name = "cboSupervisors"
        Me.cboSupervisors.Size = New System.Drawing.Size(182, 21)
        Me.cboSupervisors.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 14)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "CommissionDate"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCommDat
        '
        Me.txtCommDat.Location = New System.Drawing.Point(106, 12)
        Me.txtCommDat.Name = "txtCommDat"
        Me.txtCommDat.Size = New System.Drawing.Size(78, 20)
        Me.txtCommDat.TabIndex = 0
        Me.txtCommDat.Text = ""
        '
        'txtCommDat2
        '
        Me.txtCommDat2.Location = New System.Drawing.Point(190, 12)
        Me.txtCommDat2.Name = "txtCommDat2"
        Me.txtCommDat2.Size = New System.Drawing.Size(78, 20)
        Me.txtCommDat2.TabIndex = 10
        Me.txtCommDat2.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 21)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Division"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDiv
        '
        Me.btnDiv.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiv.Image = CType(resources.GetObject("btnDiv.Image"), System.Drawing.Image)
        Me.btnDiv.Location = New System.Drawing.Point(252, 92)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(17, 17)
        Me.btnDiv.TabIndex = 59
        Me.btnDiv.Tag = "Input"
        '
        'txtDivision
        '
        Me.txtDivision.BackColor = System.Drawing.SystemColors.Window
        Me.txtDivision.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDivision.Location = New System.Drawing.Point(55, 90)
        Me.txtDivision.Name = "txtDivision"
        Me.txtDivision.ReadOnly = True
        Me.txtDivision.Size = New System.Drawing.Size(216, 21)
        Me.txtDivision.TabIndex = 3
        Me.txtDivision.Tag = "Input"
        Me.txtDivision.Text = ""
        '
        'frmDistributeReports
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(342, 147)
        Me.Controls.Add(Me.btnDiv)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCommDat2)
        Me.Controls.Add(Me.txtCommDat)
        Me.Controls.Add(Me.chkIndividual)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboSupervisors)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdGo)
        Me.Controls.Add(Me.cboReportList)
        Me.Controls.Add(Me.txtDivision)
        Me.MaximizeBox = False
        Me.Name = "frmDistributeReports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mail Reports"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private DiviCode As String

    Private Sub cmdGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGo.Click
        If Trim(txtCommDat.Text) = "" Then
            Disable()
            txtCommDat.Select()
        Else
            AppPath = Application.StartupPath
            CommDate = Trim(txtCommDat.Text)
            If Trim(txtCommDat2.Text) <> "" Then
                CommDate2 = Trim(txtCommDat2.Text)
            Else
                CommDate2 = Nothing
            End If
            modDistributeReports.DistributeReports(CStr(cboReportList.Text), chkIndividual.Checked, cboSupervisors.Text)
        End If
    End Sub
    Private Sub frmDistributeReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'contents transfered to "load_dsm"
        'txtDivision.Enabled = True
        'btnDiv.Enabled = True
    End Sub

    Private Sub Load_DSM()
        Dim myDataReader As SqlDataReader
        Dim mySqlString As String
        If Trim(txtDivision.Text) <> "" Then
            If chiralDist = True Then
                mySqlString = " select distinct s.supname from supervisor s "
                mySqlString = mySqlString & "inner join supmr sp on s.supcode=sp.supcode "
                mySqlString = mySqlString & "where s.email>'' "
                mySqlString = mySqlString & "  and left(s.supcode, 1) = 'X' "
                mySqlString = mySqlString & "  and '" & Trim(txtCommDat.Text) & "' "
                mySqlString = mySqlString & "      between s.hire_date and s.resign_date "
                mySqlString = mySqlString & "  and sp.division = '" & Trim(txtDivision.Text) & "' "
                mySqlString = mySqlString & "   order by s.supname "
            ElseIf MHdist = True Then
                mySqlString = " select distinct s.supname from supervisor s "
                mySqlString = mySqlString & "inner join supmr sp on s.supcode=sp.supcode "
                mySqlString = mySqlString & "where s.email>'' "
                mySqlString = mySqlString & "  and left(s.supcode, 1) = 'M' "
                mySqlString = mySqlString & "  and '" & Trim(txtCommDat.Text) & "' "
                mySqlString = mySqlString & "      between s.hire_date and s.resign_date "
                mySqlString = mySqlString & "  and sp.division = '" & Trim(txtDivision.Text) & "' "
                mySqlString = mySqlString & "   order by s.supname "
            Else
                mySqlString = " select distinct s.supname from supervisor s "
                mySqlString = mySqlString & "inner join supmr sp on s.supcode=sp.supcode "
                mySqlString = mySqlString & "where s.email>'' "
                mySqlString = mySqlString & "  and left(s.supcode, 1) <> 'X' "
                mySqlString = mySqlString & "  and left(s.supcode, 1) <> 'M' "
                mySqlString = mySqlString & "  and '" & Trim(txtCommDat.Text) & "' "
                mySqlString = mySqlString & "      between s.hire_date and s.resign_date "
                mySqlString = mySqlString & "  and sp.division = '" & Trim(txtDivision.Text) & "' "
                mySqlString = mySqlString & "   order by s.supname "
            End If
        Else
            If chiralDist = True Then
                mySqlString = " select supname from supervisor "
                mySqlString = mySqlString & "where email > '' "
                mySqlString = mySqlString & "  and left(supcode, 1) = 'X' "
                mySqlString = mySqlString & "  and '" & Trim(txtCommDat.Text) & "' "
                mySqlString = mySqlString & "      between hire_date and resign_date "
                mySqlString = mySqlString & "   order by supname "
            ElseIf MHdist = True Then
                mySqlString = " select supname from supervisor "
                mySqlString = mySqlString & "where email > '' "
                mySqlString = mySqlString & "  and left(supcode, 1) = 'M' "
                mySqlString = mySqlString & "  and '" & Trim(txtCommDat.Text) & "' "
                mySqlString = mySqlString & "      between hire_date and resign_date "
                mySqlString = mySqlString & "   order by supname "
            Else
                mySqlString = " select supname from supervisor "
                mySqlString = mySqlString & "where email>'' "
                mySqlString = mySqlString & "  and left(supcode, 1) <> 'X' "
                mySqlString = mySqlString & "  and left(supcode, 1) <> 'M' "
                mySqlString = mySqlString & "  and '" & Trim(txtCommDat.Text) & "' "
                mySqlString = mySqlString & "      between hire_date and resign_date "
                mySqlString = mySqlString & "   order by supname "
            End If
        End If
        cboSupervisors.Items.Clear()

        myDataReader = DataMaintenance.GetResultSet(ServerPath, mySqlString, CommandType.Text)
        If myDataReader.HasRows Then
            While myDataReader.Read
                With cboSupervisors
                    .Items.Add(myDataReader("SupName"))
                End With
            End While
        End If
    End Sub

    Private Sub btnDiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiv.Click
        Dim popupFrm As New frmCodDesc
        StordProcName = "DivisionCombo"
        popupFrm.ShowDialog(Me)
        DiviCode = gCode
        txtDivision.Text = gDesc
        Load_DSM()
    End Sub

    Private Sub txtCommDat_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCommDat.KeyUp
        If e.KeyValue = 13 Then      ' tests if the key pressed is the "enter key"
            SendKeys.Send("{TAB}")   ' sends the focus to the next control/tabstop
        End If
    End Sub

    Private Sub txtCommDat_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCommDat.Validating
        On Error GoTo errpt
        If Trim(txtCommDat.Text) <> "" Then       'entering w/o putting value
            txtCommDat.Text = DatValid(txtCommDat.Text)  'validating the entry. the textbox's value will be "mm/dd/yyyy" if the entry is invalid.
            If Trim(txtCommDat.Text) = "mm/dd/yyyy" Then
                GoTo errpt
            Else
                Enable()
                txtDivision.Enabled = False
                btnDiv.Enabled = False
                Load_DSM()
            End If
            Exit Sub
        End If
errpt:
        e.Cancel = True  'brings back the focus to txtCommDat textbox. only in Validating event
    End Sub

    Private Sub txtCommDat2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCommDat2.KeyUp
        If e.KeyValue = 13 Then      ' tests if the key pressed is the "enter key"
            SendKeys.Send("{TAB}")   ' sends the focus to the next control/tabstop
        End If
    End Sub

    Private Sub txtCommDat2_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCommDat2.Validating
        On Error GoTo errpt
        If Trim(txtCommDat2.Text) <> "" Then       'entering w/o putting value
            txtCommDat2.Text = DatValid(txtCommDat2.Text)  'validating the entry. the textbox's value will be "mm/dd/yyyy" if the entry is invalid.
            If Trim(txtCommDat2.Text) = "mm/dd/yyyy" Then
                GoTo errpt
            End If
            If CDate(txtCommDat.Text) > CDate(txtCommDat2.Text) Then
                MsgBox("Date from must be earlier")
                GoTo errpt
            ElseIf (Month(CDate(txtCommDat.Text)) And Year(CDate(txtCommDat.Text))) = (Month(CDate(txtCommDat2.Text)) And Year(CDate(txtCommDat2.Text))) Then
                txtCommDat2.Text = ""
                txtCommDat2.Enabled = False
                Enable()
                Load_DSM()
                cboReportList.Select()
            End If
            Exit Sub
        End If
errpt:
        e.Cancel = True  'brings back the focus to txtCommDat2 textbox. only in Validating event
    End Sub

    Private Sub Enable()
        cboReportList.Enabled = True
        cboSupervisors.Enabled = True
        txtDivision.Enabled = True
        btnDiv.Enabled = True
        chkIndividual.Enabled = True
        txtCommDat2.Enabled = True
    End Sub

    Private Sub Disable()
        cboReportList.Enabled = False
        cboSupervisors.Enabled = False
        txtDivision.Enabled = False
        btnDiv.Enabled = False
        chkIndividual.Enabled = False
        txtCommDat2.Enabled = False
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

    Private Sub chkIndividual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIndividual.CheckedChanged
        If chkIndividual.Checked = True Then
            txtDivision.Enabled = True
            btnDiv.Enabled = True
        ElseIf chkIndividual.Checked = False Then
            txtDivision.Enabled = False
            btnDiv.Enabled = False
            txtDivision.Text = ""
        End If
        Load_DSM()
    End Sub
End Class
