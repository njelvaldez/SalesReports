Imports System.Data.SqlClient
Public Class frmMedrepBudgetList
    Inherits System.Windows.Forms.Form
    Private blnPainted As Boolean
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
    Friend WithEvents cmdView As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboYear As System.Windows.Forms.ComboBox
    Friend WithEvents lvwMedreps As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lvwMedreps = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader14 = New System.Windows.Forms.ColumnHeader
        Me.cmdView = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cboYear = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvwMedreps
        '
        Me.lvwMedreps.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14})
        Me.lvwMedreps.FullRowSelect = True
        Me.lvwMedreps.GridLines = True
        Me.lvwMedreps.Location = New System.Drawing.Point(8, 8)
        Me.lvwMedreps.Name = "lvwMedreps"
        Me.lvwMedreps.Size = New System.Drawing.Size(1008, 576)
        Me.lvwMedreps.TabIndex = 0
        Me.lvwMedreps.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Mr Code"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Mr Name"
        Me.ColumnHeader2.Width = 142
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Jan"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 70
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Feb"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 70
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Mar"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 70
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Apr"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 70
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "May"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 70
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Jun"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader8.Width = 70
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Jul"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader9.Width = 70
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Aug"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader10.Width = 70
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Sep"
        Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader11.Width = 70
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Oct"
        Me.ColumnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader12.Width = 70
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Nov"
        Me.ColumnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader13.Width = 70
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Dec"
        Me.ColumnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader14.Width = 80
        '
        'cmdView
        '
        Me.cmdView.Location = New System.Drawing.Point(8, 593)
        Me.cmdView.Name = "cmdView"
        Me.cmdView.TabIndex = 1
        Me.cmdView.Text = "&View"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboYear)
        Me.GroupBox1.Location = New System.Drawing.Point(88, 585)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(168, 40)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Year"
        '
        'cboYear
        '
        Me.cboYear.Location = New System.Drawing.Point(40, 12)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(121, 21)
        Me.cboYear.TabIndex = 3
        '
        'frmMedrepBudgetList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1028, 630)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdView)
        Me.Controls.Add(Me.lvwMedreps)
        Me.Name = "frmMedrepBudgetList"
        Me.Text = "Medrep Budget List"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub frmMedrepBudgetList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        YearValuesForComboBox(cboYear)
        Load_lvwMedreps(cboYear.Text)
    End Sub
    Private Sub Load_lvwMedreps(ByVal intYear As String)
        Dim myDataSet As DataSet
        Dim myDataTable As DataTable
        Dim myArray(0, 3) As Object
        Dim myRowCounter As Integer
        Dim myDataRow As DataRow


        lvwMedreps.BeginUpdate()
        'Clear the ListView
        Do While lvwMedreps.Items.Count > 0
            With lvwMedreps
                .Items.RemoveAt(0)
            End With
        Loop
        'Collect the parameters to Pass
        myArray(0, 0) = "@Year"
        myArray(0, 1) = SqlDbType.Int
        myArray(0, 2) = 4
        myArray(0, 3) = IIf(cboYear.Text = "All", 0, CInt(intYear))

        myDataSet = MedrepBudgetListRows("MedrepBudgetList", CommandType.StoredProcedure, myArray)
        myDataTable = myDataSet.Tables("MedrepBudgetList")

        For myRowCounter = 0 To myDataTable.Rows.Count - 1
            myDataRow = myDataTable.Rows(myRowCounter)
            With lvwMedreps
                .Items.Add(CStr(myDataRow.Item("MrCode")))
                .Items(myRowCounter).SubItems.Add(CStr(myDataRow.Item("MrName")))
                .Items(myRowCounter).SubItems.Add(Format(myDataRow.Item("Jan"), "#,##0.00"))
                .Items(myRowCounter).SubItems.Add(Format(myDataRow.Item("Feb"), "#,##0.00"))
                .Items(myRowCounter).SubItems.Add(Format(myDataRow.Item("Mar"), "#,##0.00"))
                .Items(myRowCounter).SubItems.Add(Format(myDataRow.Item("Apr"), "#,##0.00"))
                .Items(myRowCounter).SubItems.Add(Format(myDataRow.Item("May"), "#,##0.00"))
                .Items(myRowCounter).SubItems.Add(Format(myDataRow.Item("Jun"), "#,##0.00"))
                .Items(myRowCounter).SubItems.Add(Format(myDataRow.Item("Jul"), "#,##0.00"))
                .Items(myRowCounter).SubItems.Add(Format(myDataRow.Item("Aug"), "#,##0.00"))
                .Items(myRowCounter).SubItems.Add(Format(myDataRow.Item("Sep"), "#,##0.00"))
                .Items(myRowCounter).SubItems.Add(Format(myDataRow.Item("Oct"), "#,##0.00"))
                .Items(myRowCounter).SubItems.Add(Format(myDataRow.Item("Nov"), "#,##0.00"))
                .Items(myRowCounter).SubItems.Add(Format(myDataRow.Item("Dec"), "#,##0.00"))
            End With
        Next
        lvwMedreps.EndUpdate()
        myDataSet.Clear()
    End Sub
    Private Sub cmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdView.Click
        Dim myLoadedForm As New frmBudget
        If lvwMedreps.SelectedItems(0).Text > "" Then
            myLoadedForm.MyMrCode = lvwMedreps.SelectedItems(0).Text
            myLoadedForm.Text = lvwMedreps.SelectedItems(0).Text & " " & lvwMedreps.SelectedItems(0).SubItems(1).Text
            myLoadedForm.ShowDialog()
            Load_lvwMedreps(cboYear.Text)
        End If
    End Sub
    Private Sub lvwMedreps_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvwMedreps.ColumnClick
        lvwMedreps.ListViewItemSorter = New ListViewItemComparer(e.Column)
        lvwMedreps.Sort()
    End Sub
    Private Sub cboYear_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboYear.SelectedValueChanged
        Load_lvwMedreps(cboYear.Text)
    End Sub
End Class
