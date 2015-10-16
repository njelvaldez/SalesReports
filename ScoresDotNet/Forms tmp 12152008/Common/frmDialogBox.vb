Public Class frmDialogBox
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        cboYear.Value = Year(Now())
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboYear As System.Windows.Forms.NumericUpDown
    Friend WithEvents cboMonth As System.Windows.Forms.ComboBox
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnPreview = New System.Windows.Forms.Button
        Me.cboYear = New System.Windows.Forms.NumericUpDown
        Me.cboMonth = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.cboYear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnPreview)
        Me.GroupBox1.Controls.Add(Me.cboYear)
        Me.GroupBox1.Controls.Add(Me.cboMonth)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 120)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Commission Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Month :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Year :"
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(158, 80)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.TabIndex = 5
        Me.btnPreview.Text = "&Preview"
        '
        'cboYear
        '
        Me.cboYear.Location = New System.Drawing.Point(112, 32)
        Me.cboYear.Maximum = New Decimal(New Integer() {2099, 0, 0, 0})
        Me.cboYear.Minimum = New Decimal(New Integer() {2001, 0, 0, 0})
        Me.cboYear.Name = "cboYear"
        Me.cboYear.TabIndex = 4
        Me.cboYear.Value = New Decimal(New Integer() {2004, 0, 0, 0})
        '
        'cboMonth
        '
        Me.cboMonth.DropDownWidth = 121
        Me.cboMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cboMonth.Location = New System.Drawing.Point(112, 56)
        Me.cboMonth.MaxDropDownItems = 12
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(121, 21)
        Me.cboMonth.TabIndex = 3
        '
        'frmDialogBox
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 134)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDialogBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Report Parameters"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.cboYear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Dim myMain As New Main
        CommissionDate = CStr(cboMonth.SelectedIndex + 1) & "/1/" & cboYear.Text

        'If CDate(CommissionDate) < #8/1/2004# Then
        '    MessageBox.Show("Scores DotNet System will only process data not earlier than August 2004!", "System Information", _
        '    MessageBoxButtons.OK)
        'Else
        '    Me.Dispose()
        'End If
        Me.Close()
    End Sub
    Public myCommissionDate As String
    Public Property CommissionDate() As String
        Get
            Return myCommissionDate
        End Get
        Set(ByVal Value As String)
            myCommissionDate = Value
        End Set
    End Property
End Class
