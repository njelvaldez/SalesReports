Imports System.Data.SqlClient
Public Class frmSubKeyProduct
    Inherits System.Windows.Forms.Form
    Private EditMode As Boolean
    Private RemoteDataSet As New CodeTablesDS

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Load_ProductLineCombo()
        Load_TeamDivisionCombo()
        Load_DataGrid()
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
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(204, 454)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "Edit"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(358, 454)
        Me.Button4.Name = "Button4"
        Me.Button4.TabIndex = 34
        Me.Button4.Text = "Exit"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(127, 454)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Add"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(203, 454)
        Me.Button5.Name = "Button5"
        Me.Button5.TabIndex = 35
        Me.Button5.Text = "Save"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(281, 454)
        Me.Button3.Name = "Button3"
        Me.Button3.TabIndex = 33
        Me.Button3.Text = "Delete"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(281, 454)
        Me.Button6.Name = "Button6"
        Me.Button6.TabIndex = 36
        Me.Button6.Text = "Cancel"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(289, 423)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "End Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(289, 399)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Start Date"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "MMM dd, yyyy"
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(353, 421)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.TabIndex = 28
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "MMM dd, yyyy"
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(353, 397)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 423)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Team/Division"
        '
        'ComboBox2
        '
        Me.ComboBox2.Enabled = False
        Me.ComboBox2.Location = New System.Drawing.Point(89, 421)
        Me.ComboBox2.MaxDropDownItems = 10
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(192, 21)
        Me.ComboBox2.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 399)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Product Line"
        '
        'ComboBox1
        '
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.Location = New System.Drawing.Point(89, 397)
        Me.ComboBox1.MaxDropDownItems = 10
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(192, 21)
        Me.ComboBox1.TabIndex = 23
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(4, 5)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(552, 384)
        Me.DataGrid1.TabIndex = 22
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "SubKeyProduct_Show"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.MappingName = "Rowid"
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Team / Division"
        Me.DataGridTextBoxColumn2.MappingName = "TeamDivision"
        Me.DataGridTextBoxColumn2.Width = 150
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Product Line"
        Me.DataGridTextBoxColumn3.MappingName = "Line"
        Me.DataGridTextBoxColumn3.Width = 150
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Start Date"
        Me.DataGridTextBoxColumn4.MappingName = "Start_Date"
        Me.DataGridTextBoxColumn4.Width = 96
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "End Date"
        Me.DataGridTextBoxColumn5.MappingName = "End_Date"
        Me.DataGridTextBoxColumn5.Width = 96
        '
        'frmSubKeyProduct
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(560, 486)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DataGrid1)
        Me.Name = "frmSubKeyProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Sub Key Product"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub InsertMode()
        EditMode = False
        EnableControls(True)
        EnableButtons(True)
    End Sub
    Private Sub UpdateMode()
        EditMode = True
        EnableControls(True)
        EnableButtons(True)
    End Sub
    Private Sub SaveChanges()
        Select Case EditMode
            Case True
                DataMaintenance.myParamArray(0, 0) = "@Line"
                DataMaintenance.myParamArray(0, 1) = SqlDbType.VarChar
                DataMaintenance.myParamArray(0, 2) = 50
                DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
                DataMaintenance.myParamArray(0, 4) = "String"
                DataMaintenance.myParamArray(0, 5) = ComboBox1.Text

                DataMaintenance.myParamArray(1, 0) = "@TeamDivision"
                DataMaintenance.myParamArray(1, 1) = SqlDbType.VarChar
                DataMaintenance.myParamArray(1, 2) = 50
                DataMaintenance.myParamArray(1, 3) = System.Data.ParameterDirection.Input
                DataMaintenance.myParamArray(1, 4) = "String"
                DataMaintenance.myParamArray(1, 5) = ComboBox2.Text

                DataMaintenance.myParamArray(2, 0) = "@Rowid"
                DataMaintenance.myParamArray(2, 1) = SqlDbType.Int
                DataMaintenance.myParamArray(2, 2) = 4
                DataMaintenance.myParamArray(2, 3) = System.Data.ParameterDirection.Input
                DataMaintenance.myParamArray(2, 4) = "Integer"
                DataMaintenance.myParamArray(2, 5) = CInt(ComboBox1.Tag)

                DataMaintenance.myParamArray(3, 0) = "@StartDate"
                DataMaintenance.myParamArray(3, 1) = SqlDbType.DateTime
                DataMaintenance.myParamArray(3, 2) = 10
                DataMaintenance.myParamArray(3, 3) = System.Data.ParameterDirection.Input
                DataMaintenance.myParamArray(3, 4) = "Date"
                DataMaintenance.myParamArray(3, 5) = DateTimePicker1.Text

                DataMaintenance.myParamArray(4, 0) = "@EndDate"
                DataMaintenance.myParamArray(4, 1) = SqlDbType.DateTime
                DataMaintenance.myParamArray(4, 2) = 10
                DataMaintenance.myParamArray(4, 3) = System.Data.ParameterDirection.Input
                DataMaintenance.myParamArray(4, 4) = "Date"
                DataMaintenance.myParamArray(4, 5) = DateTimePicker2.Text

                If DataMaintenance.ExecuteCommand(ServerPath2, "SubKeyProduct_Update", CommandType.StoredProcedure, 5) Then
                    MessageBox.Show("Row Changes in Key Products  saved")
                End If
            Case False
                DataMaintenance.myParamArray(0, 0) = "@Line"
                DataMaintenance.myParamArray(0, 1) = SqlDbType.VarChar
                DataMaintenance.myParamArray(0, 2) = 50
                DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
                DataMaintenance.myParamArray(0, 4) = "String"
                DataMaintenance.myParamArray(0, 5) = ComboBox1.Text

                DataMaintenance.myParamArray(1, 0) = "@TeamDivision"
                DataMaintenance.myParamArray(1, 1) = SqlDbType.VarChar
                DataMaintenance.myParamArray(1, 2) = 50
                DataMaintenance.myParamArray(1, 3) = System.Data.ParameterDirection.Input
                DataMaintenance.myParamArray(1, 4) = "String"
                DataMaintenance.myParamArray(1, 5) = ComboBox2.Text

                DataMaintenance.myParamArray(2, 0) = "@StartDate"
                DataMaintenance.myParamArray(2, 1) = SqlDbType.DateTime
                DataMaintenance.myParamArray(2, 2) = 10
                DataMaintenance.myParamArray(2, 3) = System.Data.ParameterDirection.Input
                DataMaintenance.myParamArray(2, 4) = "Date"
                DataMaintenance.myParamArray(2, 5) = DateTimePicker1.Text

                DataMaintenance.myParamArray(3, 0) = "@EndDate"
                DataMaintenance.myParamArray(3, 1) = SqlDbType.DateTime
                DataMaintenance.myParamArray(3, 2) = 10
                DataMaintenance.myParamArray(3, 3) = System.Data.ParameterDirection.Input
                DataMaintenance.myParamArray(3, 4) = "Date"
                DataMaintenance.myParamArray(3, 5) = DateTimePicker2.Text
                If DataMaintenance.ExecuteCommand(ServerPath2, "SubKeyProduct_Insert", CommandType.StoredProcedure, 4) Then
                    MessageBox.Show("New Key Products Row saved")
                End If
        End Select
        Load_DataGrid()
    End Sub
    Private Sub ClearControlsText()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        DateTimePicker1.Text = CStr(Now())
        DateTimePicker2.Text = CStr(Now())
    End Sub
    Private Sub EnableControls(ByVal bln As Boolean)
        ComboBox1.Enabled = bln
        ComboBox2.Enabled = bln
        DateTimePicker1.Enabled = bln
        DateTimePicker2.Enabled = bln
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        SaveChanges()
        EnableButtons(False)
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        EnableButtons(False)
    End Sub
    Private Sub EnableButtons(ByVal bln As Boolean)
        'buttons
        Button1.Enabled = Not (bln) 'Add
        Button2.Enabled = Not (bln) 'Edit
        Button3.Enabled = Not (bln) 'Delete
        Button4.Enabled = Not (bln) 'Exit
        Button5.Enabled = bln       'Save
        Button6.Enabled = bln       'Cancel

        'Button Switching
        Button2.Visible = Not (bln) 'Edit
        Button3.Visible = Not (bln) 'Delete 
        Button5.Visible = bln  'Save
        Button6.Visible = bln  'Cancel

        EnableControls(bln)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        InsertMode()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        UpdateMode()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
    Private Sub Load_ProductLineCombo()
        Dim myDataTable As SqlDataReader
        myDataTable = DataMaintenance.GetResultSet(ServerPath2, "KeyProducts_ShowProductLine", CommandType.StoredProcedure)
        If myDataTable.HasRows Then
            While myDataTable.Read
                ComboBox1.Items.Add(myDataTable.Item("Description"))
            End While
        End If
    End Sub
    Private Sub Load_TeamDivisionCombo()
        Dim myDataTable As SqlDataReader
        myDataTable = DataMaintenance.GetResultSet(ServerPath2, "KeyProducts_ShowTeamDivision", CommandType.StoredProcedure)
        If myDataTable.HasRows Then
            While myDataTable.Read
                ComboBox2.Items.Add(myDataTable.Item("Description"))
            End While
        End If
    End Sub
    Private Sub Load_DataGrid()
        If RemoteDataSet.KeyProducts_Show.Count > 0 Then RemoteDataSet.KeyProducts_Show.Clear()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "SubKeyProduct_Show", CommandType.StoredProcedure, RemoteDataSet, "SubKeyProduct_Show")
        DataGrid1.DataSource = RemoteDataSet.SubKeyProduct_Show
    End Sub
    Private Sub DataGrid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.Click
        ComboBox1.Tag = CInt(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 0))
        ComboBox2.Text = CStr(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 1))
        ComboBox1.Text = CStr(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 2))
        DateTimePicker1.Text = CStr(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 3))
        DateTimePicker2.Text = CStr(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 4))
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MessageBox.Show("Delete this product line?", "Product Lines", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            DataMaintenance.myParamArray(0, 0) = "@Rowid"
            DataMaintenance.myParamArray(0, 1) = SqlDbType.Int
            DataMaintenance.myParamArray(0, 2) = 50
            DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
            DataMaintenance.myParamArray(0, 4) = "Integer"
            DataMaintenance.myParamArray(0, 5) = CInt(ComboBox1.Tag)

            If DataMaintenance.ExecuteCommand(ServerPath2, "SubKeyProduct_Delete", CommandType.StoredProcedure, 1) = True Then
                MessageBox.Show("Sub-Key Product row deleted!")
                Load_DataGrid()
            End If
        End If
    End Sub
End Class
