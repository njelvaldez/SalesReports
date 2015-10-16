Imports System.Data.SqlClient

Public Class frmBudget
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
    Friend WithEvents lvwBudgetAmounts As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboYear As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lvwBudgetAmounts = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cboYear = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lvwBudgetAmounts
        '
        Me.lvwBudgetAmounts.AllowColumnReorder = True
        Me.lvwBudgetAmounts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvwBudgetAmounts.FullRowSelect = True
        Me.lvwBudgetAmounts.GridLines = True
        Me.lvwBudgetAmounts.Location = New System.Drawing.Point(8, 8)
        Me.lvwBudgetAmounts.MultiSelect = False
        Me.lvwBudgetAmounts.Name = "lvwBudgetAmounts"
        Me.lvwBudgetAmounts.Size = New System.Drawing.Size(688, 368)
        Me.lvwBudgetAmounts.TabIndex = 0
        Me.lvwBudgetAmounts.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Item Code"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Item Desc"
        Me.ColumnHeader2.Width = 240
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Start Date"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "End Date"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Amount"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 90
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Qty"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Width = 0
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(464, 384)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.TabIndex = 1
        Me.cmdAdd.Text = "&Add"
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(542, 384)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.TabIndex = 2
        Me.cmdEdit.Text = "&Edit"
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(620, 384)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.TabIndex = 3
        Me.cmdDelete.Text = "&Delete"
        '
        'cboYear
        '
        Me.cboYear.Location = New System.Drawing.Point(304, 384)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(121, 21)
        Me.cboYear.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(264, 386)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Year"
        '
        'frmBudget
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(704, 414)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboYear)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.lvwBudgetAmounts)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmBudget"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmBudget"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim varMrCode As String
    Dim varListItem As ListViewItem
    Public Property MyMrCode() As String
        Get
            Return varMrCode
        End Get
        Set(ByVal Value As String)
            varMrCode = Value
        End Set
    End Property
    Private Sub frmBudget_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        YearValuesForComboBox(cboYear)
        Load_lvwBudgetAmounts(Year(Now()))
    End Sub
    Private Sub Load_lvwBudgetAmounts(Optional ByVal intYear As Integer = 0)
        Dim myDataset As DataSet
        Dim myDataTable As DataTable
        Dim myDataRow As DataRow
        Dim myArray(1, 3) As Object
        Dim myCounter As Integer

        With lvwBudgetAmounts
            Do While .Items.Count > 0
                .Items.RemoveAt(0)
            Loop
        End With

        myArray(0, 0) = "@MrCode"
        myArray(0, 1) = SqlDbType.VarChar
        myArray(0, 2) = 10
        myArray(0, 3) = MyMrCode

        myArray(1, 0) = "@Year"
        myArray(1, 1) = SqlDbType.SmallInt
        myArray(1, 2) = 4
        myArray(1, 3) = intYear

        myDataset = BudgetAmounts("MedrepBudgetAmounts", CommandType.StoredProcedure, myArray)
        myDataTable = myDataset.Tables("BudgetAmounts")

        Try
            For myCounter = 0 To myDataTable.Rows.Count - 1
                myDataRow = myDataTable.Rows(myCounter)
                With lvwBudgetAmounts
                    .Items.Add(CStr(myDataRow.Item("ItemCode")))
                    .Items(myCounter).SubItems.Add(CStr(myDataRow.Item("ItemDesc")))
                    .Items(myCounter).SubItems.Add(CStr(myDataRow.Item("Start_Date")))
                    .Items(myCounter).SubItems.Add(CStr(myDataRow.Item("End_Date")))
                    .Items(myCounter).SubItems.Add(Format(myDataRow.Item("Amount"), "#,##0.00"))
                    .Items(myCounter).SubItems.Add(CStr(myDataRow.Item("Qty")))
                    .Items(myCounter).SubItems.Add(CStr(myDataRow.Item("Rownumber")))
                End With
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        myDataset.Clear()

    End Sub
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim myLoadedForm As New frmBudgetItem
        Dim myListItem As ListViewItem
        myLoadedForm.EditMode = False
        myLoadedForm.myMrCode = MyMrCode
        With lvwBudgetAmounts
            .Items.Add("")
            .Items(lvwBudgetAmounts.Items.Count - 1).SubItems.Add("")
            .Items(lvwBudgetAmounts.Items.Count - 1).SubItems.Add("")
            .Items(lvwBudgetAmounts.Items.Count - 1).SubItems.Add("")
            .Items(lvwBudgetAmounts.Items.Count - 1).SubItems.Add("")
            .Items(lvwBudgetAmounts.Items.Count - 1).SubItems.Add("")
        End With
        myListItem = lvwBudgetAmounts.Items(lvwBudgetAmounts.Items.Count - 1)
        myLoadedForm.myListItem = myListItem

        If myLoadedForm.ShowDialog <> DialogResult.Cancel Then
            Load_lvwBudgetAmounts()
        End If
    End Sub
    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Dim myListItem As ListViewItem
        myListItem = lvwBudgetAmounts.SelectedItems(0)
        Dim myLoadedForm As New frmBudgetItem
        myLoadedForm.EditMode = True
        myLoadedForm.myListItem = myListItem
        myLoadedForm.ShowDialog()
    End Sub
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim myCommand As New SqlCommand
        Dim myListItem As ListViewItem
        myListItem = lvwBudgetAmounts.SelectedItems.Item(0)
        With myCommand
            .Connection = myConnection(ScoresDotNetConnectionString)
            .CommandText = "Delete from NewScores..Budget where Rownumber=" & myListItem.SubItems(6).Text
            .CommandType = CommandType.Text
            .ExecuteNonQuery()
        End With

        'Clean Up the ListView
        lvwBudgetAmounts.Items.Remove(myListItem)
    End Sub
    Private Sub lvwBudgetAmounts_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvwBudgetAmounts.ColumnClick
        'lvwBudgetAmounts.ListViewItemSorter = New ListViewItemComparer(e.Column)
        'lvwBudgetAmounts.Sort()
    End Sub
    Private Sub cboYear_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboYear.Validated
        Load_lvwBudgetAmounts(CInt(cboYear.Text))
    End Sub
    
End Class
