Imports Microsoft
Imports System.Data.SqlClient
Public Class frmQpiTerritoryAssignment
    Inherits System.Windows.Forms.Form
    Dim RemoteDataSet As New dsQpi_AreaAssign
    Private EditMode As Boolean = False

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Show_Medrep()
        Show_Territory()
        Load_Grid()
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
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ListBox4 As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ListBox4 = New System.Windows.Forms.ListBox
        Me.ListBox3 = New System.Windows.Forms.ListBox
        Me.ListBox2 = New System.Windows.Forms.ListBox
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnInsert = New System.Windows.Forms.Button
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
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
        'ListBox4
        '
        Me.ListBox4.AllowDrop = True
        Me.ListBox4.Location = New System.Drawing.Point(359, 152)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(312, 95)
        Me.ListBox4.TabIndex = 34
        Me.ListBox4.Tag = ""
        Me.ToolTip1.SetToolTip(Me.ListBox4, "Double-Click an item to remove it from the list")
        '
        'ListBox3
        '
        Me.ListBox3.AllowDrop = True
        Me.ListBox3.Location = New System.Drawing.Point(15, 152)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(312, 95)
        Me.ListBox3.TabIndex = 32
        Me.ListBox3.Tag = ""
        Me.ToolTip1.SetToolTip(Me.ListBox3, "Drag an item to the list on the right")
        '
        'ListBox2
        '
        Me.ListBox2.AllowDrop = True
        Me.ListBox2.Location = New System.Drawing.Point(359, 32)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(312, 95)
        Me.ListBox2.TabIndex = 29
        Me.ListBox2.Tag = ""
        Me.ToolTip1.SetToolTip(Me.ListBox2, "Double-Click an item to remove it from the list")
        '
        'ListBox1
        '
        Me.ListBox1.AllowDrop = True
        Me.ListBox1.Location = New System.Drawing.Point(15, 32)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(312, 95)
        Me.ListBox1.TabIndex = 28
        Me.ListBox1.Tag = ""
        Me.ToolTip1.SetToolTip(Me.ListBox1, "Drag an item to the list on the right")
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(359, 136)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 16)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "&Clear"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(359, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 16)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "&Clear"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(455, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 16)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "End Date"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(175, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 16)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Start Date"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(305, 280)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.TabIndex = 38
        Me.btnInsert.Text = "Insert"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker2.Location = New System.Drawing.Point(359, 256)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(88, 20)
        Me.DateTimePicker2.TabIndex = 37
        Me.DateTimePicker2.Tag = ""
        Me.DateTimePicker2.Value = New Date(2006, 1, 24, 17, 56, 18, 569)
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker1.Location = New System.Drawing.Point(239, 256)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(88, 20)
        Me.DateTimePicker1.TabIndex = 36
        Me.DateTimePicker1.Tag = ""
        Me.DateTimePicker1.Value = New Date(2006, 1, 24, 17, 56, 18, 631)
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(335, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 95)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = ">>"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Territory List"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 16)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Medrep List"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(335, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 95)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = ">>"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(16, 312)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(656, 240)
        Me.DataGrid1.TabIndex = 55
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.DataGrid1.Tag = "View"
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "QpiAreaAssign_TableShow"
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
        Me.DataGridTextBoxColumn2.HeaderText = "Medrep"
        Me.DataGridTextBoxColumn2.MappingName = "medrep"
        Me.DataGridTextBoxColumn2.Width = 225
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Territory"
        Me.DataGridTextBoxColumn3.MappingName = "territorydesc"
        Me.DataGridTextBoxColumn3.Width = 225
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Start Date"
        Me.DataGridTextBoxColumn4.MappingName = "startdate"
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "End Date"
        Me.DataGridTextBoxColumn5.MappingName = "enddate"
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'frmQpiTerritoryAssignment
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(678, 556)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListBox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmQpiTerritoryAssignment"
        Me.Text = "Insert Territory Assignment"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Show_Medrep()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "QpiAreaAssign_MedrepShow", CommandType.StoredProcedure, _
        RemoteDataSet, "QpiAreaAssign_MedrepShow")
        ListBox1.BeginUpdate()
        ListBox1.DataSource = RemoteDataSet.QpiAreaAssign_MedrepShow
        ListBox1.DisplayMember = "Medrep"
        ListBox1.EndUpdate()
    End Sub
    Private Sub Show_Territory()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "QpiAreaAssign_TerritoryShow", CommandType.StoredProcedure, _
        RemoteDataSet, "QpiAreaAssign_TerritoryShow")
        ListBox3.BeginUpdate()
        ListBox3.DataSource = RemoteDataSet.QpiAreaAssign_TerritoryShow
        ListBox3.DisplayMember = "TerritoryDesc"
        ListBox3.EndUpdate()
    End Sub
    Private Sub ListBox1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseDown
        If Not ListBox1.SelectedIndex = -1 Then
            Me.DoDragDrop(RemoteDataSet.QpiAreaAssign_MedrepShow(ListBox1.SelectedIndex).Medrep(), DragDropEffects.Copy)
        End If
    End Sub
    Private Sub ListBox2_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListBox2.DragEnter
        e.Effect = DragDropEffects.Copy
        ListBox2.Items.Insert(0, e.Data.GetData(DataFormats.Text))
    End Sub
    Private Sub ListBox2_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.DoubleClick
        If Not ListBox2.SelectedIndex = -1 Then
            ListBox2.Items.Remove(ListBox2.SelectedItem)
        End If
    End Sub
    Private Sub ListBox3_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox3.MouseDown
        If Not ListBox3.SelectedIndex = -1 Then
            Me.DoDragDrop(RemoteDataSet.QpiAreaAssign_TerritoryShow(ListBox3.SelectedIndex).TerritoryDesc(), DragDropEffects.Copy)
        End If
    End Sub
    Private Sub ListBox4_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListBox4.DragEnter
        e.Effect = DragDropEffects.Copy
        ListBox4.Items.Insert(0, e.Data.GetData(DataFormats.Text))
    End Sub
    Private Sub ListBox4_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox4.DoubleClick
        If Not ListBox4.SelectedIndex = -1 Then
            ListBox4.Items.Remove(ListBox4.SelectedItem)
        End If
    End Sub
    Private Function IsDateValid() As Boolean
        Dim Valid As Boolean = True
        If DateTimePicker1.Value > DateTimePicker2.Value Then
            Valid = False
        End If
        Return Valid
    End Function
    Private Function AreListsValid() As Boolean
        Dim Valid As Boolean = True
        If Not (ListBox2.Items.Count > 0 And ListBox4.Items.Count > 0) Then
            Valid = False
        End If
        Return Valid
    End Function
    Private Function GetCode(ByVal strValue As String) As String
        Dim MyCode As String
        MyCode = VisualBasic.Left(strValue, VisualBasic.InStr(strValue, "-") - 1)
        Return MyCode
    End Function
    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        'Perform Validations
        If IsDateValid() = False Then
            MessageBox.Show("Start Date cannot be later than the End Date!", "Invalid Dates", MessageBoxButtons.OK, _
            MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        If AreListsValid() = False Then
            MessageBox.Show("Make sure listboxes on the right contain at least one item!", "Incomplete Lists", MessageBoxButtons.OK, _
            MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        'If Validations are passed
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(3) As SqlParameter
        Dim MrCode As New SqlParameter("@MrCode", SqlDbType.VarChar, 15) : MrCode.Direction = ParameterDirection.Input : Params(0) = MrCode
        Dim TerritoryCode As New SqlParameter("@TerritoryCode", SqlDbType.VarChar, 15) : TerritoryCode.Direction = ParameterDirection.Input : Params(1) = TerritoryCode
        Dim StartDate As New SqlParameter("@StartDate", SqlDbType.DateTime) : StartDate.Direction = ParameterDirection.Input : StartDate.Value = FormatDateTime(DateTimePicker1.Value, DateFormat.ShortDate) : Params(2) = StartDate
        Dim EndDate As New SqlParameter("@EndDate", SqlDbType.DateTime) : EndDate.Direction = ParameterDirection.Input : EndDate.Value = FormatDateTime(DateTimePicker2.Value, DateFormat.ShortDate) : Params(3) = EndDate

        Me.Cursor = Cursors.WaitCursor
        Dim i, j As Integer
        For i = 0 To ListBox2.Items.Count - 1
            For j = 0 To ListBox4.Items.Count - 1
                MrCode.Value = GetCode(CStr(ListBox2.Items.Item(i)))
                TerritoryCode.Value = GetCode(CStr(ListBox4.Items.Item(j)))
                Try
                    BusinessObject.Sub_Insert(ServerPath2, "QpiAreaAssign_Insert", CommandType.StoredProcedure, Params)
                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString, "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End Try
            Next
        Next
        Me.Cursor = Cursors.Default
        MessageBox.Show("Area assignments successfully inserted!", "Insert Status", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Sub_Show()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox2.Items.Clear()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListBox4.Items.Clear()
    End Sub
    Private Sub Load_Grid()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "QpiAreaAssign_TableShow", CommandType.StoredProcedure, RemoteDataSet, _
        "QpiAreaAssign_TableShow")
        DataGrid1.DataSource = RemoteDataSet.QpiAreaAssign_TableShow
    End Sub
    Private Sub Sub_Show()
        If RemoteDataSet.QpiAreaAssign_TableShow.Count > 0 Then RemoteDataSet.QpiAreaAssign_TableShow.Clear()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "QpiAreaAssign_TableShow", CommandType.StoredProcedure, RemoteDataSet, "QpiAreaAssign_TableShow")
        DataGrid1.DataSource = RemoteDataSet.QpiAreaAssign_TableShow
    End Sub
    Private Sub frmQpiTerritoryAssignment_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        modControlBehavior.EnableControls(Me, False)
    End Sub
End Class
