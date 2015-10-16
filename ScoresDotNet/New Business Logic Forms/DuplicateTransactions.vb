Imports System.Data.SqlClient
Imports System.Collections
Public Class DuplicateTransactions
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnOverwriteAll As System.Windows.Forms.Button
    Friend WithEvents btnSkipAll As System.Windows.Forms.Button
    Friend WithEvents btnOverwriteSelected As System.Windows.Forms.Button
    Friend WithEvents btnSkipSelected As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnSkipSelected = New System.Windows.Forms.Button
        Me.btnOverwriteSelected = New System.Windows.Forms.Button
        Me.btnSkipAll = New System.Windows.Forms.Button
        Me.btnOverwriteAll = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(488, 64)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Message"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(262, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "• Please choose from the options below to proceed."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(325, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "• Transactions from this file are already existing in the database."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGrid1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 80)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(488, 232)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Existing Records"
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 24)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(472, 200)
        Me.DataGrid1.TabIndex = 0
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = ""
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Processed Date"
        Me.DataGridTextBoxColumn1.MappingName = "CreateDate"
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 120
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "File Name"
        Me.DataGridTextBoxColumn2.MappingName = "FromFile"
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 300
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnSkipSelected)
        Me.GroupBox3.Controls.Add(Me.btnOverwriteSelected)
        Me.GroupBox3.Controls.Add(Me.btnSkipAll)
        Me.GroupBox3.Controls.Add(Me.btnOverwriteAll)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(8, 320)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(488, 56)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Options"
        '
        'btnSkipSelected
        '
        Me.btnSkipSelected.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSkipSelected.Location = New System.Drawing.Point(368, 24)
        Me.btnSkipSelected.Name = "btnSkipSelected"
        Me.btnSkipSelected.Size = New System.Drawing.Size(110, 23)
        Me.btnSkipSelected.TabIndex = 3
        Me.btnSkipSelected.Text = "Skip Selected"
        '
        'btnOverwriteSelected
        '
        Me.btnOverwriteSelected.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOverwriteSelected.Location = New System.Drawing.Point(256, 24)
        Me.btnOverwriteSelected.Name = "btnOverwriteSelected"
        Me.btnOverwriteSelected.Size = New System.Drawing.Size(110, 23)
        Me.btnOverwriteSelected.TabIndex = 2
        Me.btnOverwriteSelected.Text = "Overwrite Selected"
        '
        'btnSkipAll
        '
        Me.btnSkipAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSkipAll.Location = New System.Drawing.Point(120, 24)
        Me.btnSkipAll.Name = "btnSkipAll"
        Me.btnSkipAll.Size = New System.Drawing.Size(110, 23)
        Me.btnSkipAll.TabIndex = 1
        Me.btnSkipAll.Text = "Skip All"
        '
        'btnOverwriteAll
        '
        Me.btnOverwriteAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOverwriteAll.Location = New System.Drawing.Point(8, 24)
        Me.btnOverwriteAll.Name = "btnOverwriteAll"
        Me.btnOverwriteAll.Size = New System.Drawing.Size(110, 23)
        Me.btnOverwriteAll.TabIndex = 0
        Me.btnOverwriteAll.Text = "Overwrite All"
        '
        'DuplicateTransactions
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(504, 381)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DuplicateTransactions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Duplicate Transactions"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private _source As SqlDataReader
    Private _filenamelist As SortedList
    Private _transactions As ArrayList

    Private SelectedRows As New ArrayList
    Private PreviouslySelectedRow As Integer = -1
    Private counter As Integer

    Public Property Transactions() As ArrayList
        Get
            Return _transactions
        End Get
        Set(ByVal Value As ArrayList)
            _transactions = Value
        End Set
    End Property

    Public Property FileNameList() As SortedList
        Get
            Return _filenamelist
        End Get
        Set(ByVal Value As SortedList)
            _filenamelist = Value
        End Set
    End Property

    Public Property DataGridSource() As SqlDataReader
        Get
            Return Me._source
        End Get
        Set(ByVal Value As SqlDataReader)
            Me._source = Value
        End Set
    End Property

    Private Sub DuplicateTransactions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        StoreDataAsLocal()
    End Sub

    Private Sub StoreDataAsLocal()

        Try
            'Store the transactions in an ArrayList
            Dim LocalTransactions As New ArrayList
            With Me.DataGridSource
                If .HasRows() Then
                    While .Read()
                        Dim TransactionRows(5) As String
                        TransactionRows(0) = CStr(Me.DataGridSource("Rowid"))
                        TransactionRows(1) = CStr(Me.DataGridSource("CreateDate"))
                        TransactionRows(2) = CStr(Me.DataGridSource("FromFile"))
                        TransactionRows(3) = CStr(Me.DataGridSource("Doc#"))
                        TransactionRows(4) = CStr(Me.DataGridSource("IndSeq"))
                        LocalTransactions.Add(TransactionRows)
                    End While
                    Me.Transactions = LocalTransactions
                End If
            End With

            'Store the filenames and process dates in Sorted List
            Dim LocalFileNameList As New SortedList
            With Me.DataGridSource
                .NextResult()
                If .HasRows() Then
                    While .Read()
                        LocalFileNameList.Add(CStr(.Item("FromFile")), CStr(.Item("CreateDate")))
                    End While
                End If
                Me.FileNameList = LocalFileNameList
                'Load data into the grid
                LoadDataToGrid()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "StoreDataAsLocal()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub LoadDataToGrid()
        Dim dt As New DataTable
        Dim dr As DataRow

        'Create the columns
        dt.Columns.Add("FromFile", GetType(String))
        dt.Columns.Add("CreateDate", GetType(String))


        For i As Integer = 0 To Me.FileNameList.Count - 1
            dr = dt.NewRow()
            dr("FromFile") = CStr(FileNameList.GetKey(i))
            dr("CreateDate") = CStr(FileNameList.GetByIndex(i))
            dt.Rows.Add(dr)
        Next

        Dim dv As New DataView(dt)
        DataGrid1.DataSource = dv
    End Sub


    Private Sub btnOverwriteAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOverwriteAll.Click

        Me.Cursor = Cursors.WaitCursor
        OverWrite_Skip("OverwriteSelected", "Event : btnOverwriteAll_Click()", "All")
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub btnSkipAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSkipAll.Click

        Me.Cursor = Cursors.WaitCursor
        OverWrite_Skip("SkipAll", "Event : btnSkipAll_Click()", "All")
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub btnOverwriteSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOverwriteSelected.Click

        Me.Cursor = Cursors.WaitCursor
        If UserHasValidSelection() = True Then
            OverWrite_Skip("OverwriteSelected", "Event : btnOverwriteSelected_Click()", "Selected")
        Else
            MessageBox.Show("Please select at least one item from the grid.", "Duplicate Transactions", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub RemoveRowFromGrid(ByVal RowList As ArrayList)

        'Remove the row item from the grid
        Dim myRowEnumerator As System.Collections.IEnumerator = RowList.GetEnumerator()
        Dim dv As DataView = CType(DataGrid1.DataSource, DataView)
        dv.Sort = "FromFile"
        Dim vals(0) As Object
        While myRowEnumerator.MoveNext
            'dv.Item(CInt(myRowEnumerator.Current)).Delete()
            vals(0) = CStr(myRowEnumerator.Current)
            dv.Item(dv.Find(vals)).Delete()
        End While

    End Sub

    Private Sub btnSkipSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSkipSelected.Click

        Me.Cursor = Cursors.WaitCursor
        If UserHasValidSelection() = True Then
            OverWrite_Skip("SkipAll", "Event : btnSkipSelected_Click()", "Selected")
        Else
            MessageBox.Show("Please select at least one item from the grid.", "Duplicate Transactions", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub OverWrite_Skip(ByVal StoredProcedureName As String, ByVal EventMessage As String, _
    ByVal OptionButton As String)
        Try
            'Loop thru the grid and get the selected rows
            Dim StringCommand As String
            Dim myEnumerator As System.Collections.IEnumerator = Me.Transactions.GetEnumerator()

            DataMaintenance.myParamArray(0, 0) = "@FromFile"
            DataMaintenance.myParamArray(0, 1) = SqlDbType.VarChar
            DataMaintenance.myParamArray(0, 2) = 150
            DataMaintenance.myParamArray(0, 3) = ParameterDirection.Input
            DataMaintenance.myParamArray(0, 4) = "String"

            DataMaintenance.myParamArray(1, 0) = "@Doc#"
            DataMaintenance.myParamArray(1, 1) = SqlDbType.VarChar
            DataMaintenance.myParamArray(1, 2) = 10
            DataMaintenance.myParamArray(1, 3) = ParameterDirection.Input
            DataMaintenance.myParamArray(1, 4) = "String"

            DataMaintenance.myParamArray(2, 0) = "@IndSeq"
            DataMaintenance.myParamArray(2, 1) = SqlDbType.VarChar
            DataMaintenance.myParamArray(2, 2) = 6
            DataMaintenance.myParamArray(2, 3) = ParameterDirection.Input
            DataMaintenance.myParamArray(2, 4) = "String"

            Dim myRowList As New ArrayList
            With DataGrid1
                For index As Integer = 0 To .VisibleRowCount - 2
                    Select Case OptionButton
                        Case "Selected"
                            If .IsSelected(index) = True Then
                                If myRowList.Count > 0 Then
                                    myRowList.Add(IterateThruGridItems(myEnumerator, StoredProcedureName, index)(0))
                                Else
                                    myRowList = IterateThruGridItems(myEnumerator, StoredProcedureName, index)
                                End If
                            End If
                        Case "All"
                            If myRowList.Count > 0 Then
                                myRowList.Add(IterateThruGridItems(myEnumerator, StoredProcedureName, index)(0))
                            Else
                                myRowList = IterateThruGridItems(myEnumerator, StoredProcedureName, index)
                            End If
                    End Select
                Next
                RemoveRowFromGrid(myRowList)

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, EventMessage, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Close the form
        If DataGrid1.VisibleRowCount = 1 Then Me.Close()
    End Sub

    Private Function IterateThruGridItems(ByVal myEnumerator As System.Collections.IEnumerator, _
    ByVal StoredProcedureName As String, ByVal index As Integer) As ArrayList


        Dim myRowList As New ArrayList
        Dim FromFile As String
        Try
            With DataGrid1
                While myEnumerator.MoveNext
                    If CStr(.Item(index, 1)) = CStr(CType(myEnumerator.Current, System.Array).GetValue(2)) Then
                        DataMaintenance.myParamArray(0, 5) = CStr(CType(myEnumerator.Current, System.Array).GetValue(2))
                        DataMaintenance.myParamArray(1, 5) = CStr(CType(myEnumerator.Current, System.Array).GetValue(3))
                        DataMaintenance.myParamArray(2, 5) = CStr(CType(myEnumerator.Current, System.Array).GetValue(4))
                        DataMaintenance.myParamArray(3, 5) = CStr(CType(myEnumerator.Current, System.Array).GetValue(5))
                        DataMaintenance.ExecuteCommand(ServerPath2, StoredProcedureName, _
                        CommandType.StoredProcedure, 3)
                        counter += 1
                        FromFile = CStr(CType(myEnumerator.Current, System.Array).GetValue(2))
                        If myRowList.Contains(FromFile) = False Then myRowList.Add(FromFile)
                    End If
                End While
                myEnumerator.Reset()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return myRowList
    End Function

    Private Sub DuplicateTransactions_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'Check to see if there are still items from the grid
        If DataGrid1.VisibleRowCount > 1 Then
            MessageBox.Show("Please choose an option for the remaining items in the grid.", "Duplicate Transactions", MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Cancel = True
        Else
            'Try
            '    DataMaintenance.ExecuteCommand(ServerPath2, "InsertLeftOvers", CommandType.StoredProcedure)
            'Catch ex As Exception
            '    MessageBox.Show(ex.Message, "DuplicateTransactions_Closing()", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End Try
        End If

    End Sub

    Private Function UserHasValidSelection() As Boolean
        Dim GridItemSelected As Boolean = False
        Try
            With DataGrid1
                For index As Integer = 0 To .VisibleRowCount - 1
                    If .IsSelected(index) = True Then
                        GridItemSelected = True
                        Return GridItemSelected
                    End If
                Next
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "UserHasValidSelection()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function
End Class
