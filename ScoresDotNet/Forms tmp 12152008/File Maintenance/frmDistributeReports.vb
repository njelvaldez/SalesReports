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
        Me.SuspendLayout()
        '
        'cboReportList
        '
        Me.cboReportList.Enabled = False
        Me.cboReportList.Items.AddRange(New Object() {"Sales Per Medical Representative", "Mercury Sales Per Medical Representative", "Commission Report Attachment (PMR)", "Commission Report Attachment (DSM)", "Medrep Commission with Recovery", "District Manager Commission with Recovery"})
        Me.cboReportList.Location = New System.Drawing.Point(19, 64)
        Me.cboReportList.MaxDropDownItems = 10
        Me.cboReportList.Name = "cboReportList"
        Me.cboReportList.Size = New System.Drawing.Size(241, 21)
        Me.cboReportList.TabIndex = 1
        '
        'cmdGo
        '
        Me.cmdGo.Location = New System.Drawing.Point(270, 64)
        Me.cmdGo.Name = "cmdGo"
        Me.cmdGo.Size = New System.Drawing.Size(59, 21)
        Me.cmdGo.TabIndex = 4
        Me.cmdGo.Text = "Go !"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Please Choose A Report to Distribute"
        '
        'chkIndividual
        '
        Me.chkIndividual.Checked = True
        Me.chkIndividual.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIndividual.Enabled = False
        Me.chkIndividual.Location = New System.Drawing.Point(19, 94)
        Me.chkIndividual.Name = "chkIndividual"
        Me.chkIndividual.Size = New System.Drawing.Size(77, 18)
        Me.chkIndividual.TabIndex = 3
        Me.chkIndividual.Text = "Individual"
        '
        'cboSupervisors
        '
        Me.cboSupervisors.Enabled = False
        Me.cboSupervisors.Location = New System.Drawing.Point(100, 90)
        Me.cboSupervisors.Name = "cboSupervisors"
        Me.cboSupervisors.Size = New System.Drawing.Size(160, 21)
        Me.cboSupervisors.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 14)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "CommissionDate"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCommDat
        '
        Me.txtCommDat.Location = New System.Drawing.Point(106, 12)
        Me.txtCommDat.Name = "txtCommDat"
        Me.txtCommDat.Size = New System.Drawing.Size(120, 20)
        Me.txtCommDat.TabIndex = 0
        Me.txtCommDat.Text = ""
        '
        'frmDistributeReports
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(344, 121)
        Me.Controls.Add(Me.txtCommDat)
        Me.Controls.Add(Me.chkIndividual)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboSupervisors)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdGo)
        Me.Controls.Add(Me.cboReportList)
        Me.MaximizeBox = False
        Me.Name = "frmDistributeReports"
        Me.Opacity = 0.5
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mail Reports"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub cmdGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGo.Click
        If Trim(txtCommDat.Text) = "" Then
            Disable()
            txtCommDat.Select()
        Else
            AppPath = Application.StartupPath
            CommDate = Trim(txtCommDat.Text)
            modDistributeReports.DistributeReports(CStr(cboReportList.Text), chkIndividual.Checked, cboSupervisors.Text)
        End If
    End Sub
    Private Sub frmDistributeReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'contents transfered to "load_dsm"
    End Sub

    Private Sub Load_DSM()
        Dim myDataReader As SqlDataReader
        Dim mySqlString As String
        mySqlString = " select supname from supervisor "
        mySqlString = mySqlString & "where email>'' "
        mySqlString = mySqlString & "  and left(supcode, 1) <> 'X' "
        mySqlString = mySqlString & "  and '" & Trim(txtCommDat.Text) & "' "
        mySqlString = mySqlString & "      between hire_date and resign_date "
        mySqlString = mySqlString & "   order by supname "

        myDataReader = DataMaintenance.GetResultSet(ServerPath, mySqlString, CommandType.Text)
        If myDataReader.HasRows Then
            While myDataReader.Read
                With cboSupervisors
                    .Items.Add(myDataReader("SupName"))
                End With
            End While
        End If
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
                Load_DSM()
            End If
            Exit Sub
        End If
errpt:
        e.Cancel = True  'brings back the focus to txtCommDat textbox. only in Validating event
    End Sub

    Private Sub Enable()
        cboReportList.Enabled = True
        cboSupervisors.Enabled = True
        chkIndividual.Enabled = True
    End Sub

    Private Sub Disable()
        cboReportList.Enabled = False
        cboSupervisors.Enabled = False
        chkIndividual.Enabled = False
    End Sub
End Class
