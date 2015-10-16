Imports System.Data.SqlClient
Public Class NewItem
    Inherits System.Windows.Forms.Form
    Private _source As SqlDataReader
    'Private _name As String
    'Private _customerno As String
    'Private _shiptocode As String
    Private cForm As Itm_Entry
    Private _lastdeleted As String
    Private _lastCount As Integer
    Private _opened As Boolean

    Public Property Opened() As Boolean
        Get
            Return _opened
        End Get
        Set(ByVal Value As Boolean)
            _opened = Value
        End Set
    End Property

    Public Property LastCount() As Integer
        Get
            Return _lastCount
        End Get
        Set(ByVal Value As Integer)
            _lastCount = Value
        End Set
    End Property

    Public Property LastDeleted() As String
        Get
            Return Me._lastdeleted
        End Get
        Set(ByVal Value As String)
            Me._lastdeleted = Value
        End Set
    End Property
    'Public Property CustomerNo() As String
    '    Get
    '        Return Me._customerno
    '    End Get
    '    Set(ByVal Value As String)
    '        Me._customerno = Value
    '    End Set
    'End Property
    'Public Property ShipToCode() As String
    '    Get
    '        Return Me._shiptocode
    '    End Get
    '    Set(ByVal Value As String)
    '        Me._shiptocode = Value
    '    End Set
    'End Property
    Public Property DataGridSource() As SqlDataReader
        Get
            Return Me._source
        End Get
        Set(ByVal Value As SqlDataReader)
            Me._source = Value
        End Set
    End Property
    'Public Property FullName() As String
    '    Get
    '        Return Me._name
    '    End Get
    '    Set(ByVal Value As String)
    '        Me._name = Value
    '    End Set
    'End Property
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
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataView1 = New System.Data.DataView
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.AlternatingBackColor = System.Drawing.SystemColors.InactiveBorder
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 8)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(400, 464)
        Me.DataGrid1.TabIndex = 0
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.SystemColors.InactiveBorder
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = ""
        Me.DataGridTableStyle1.RowHeadersVisible = False
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Item Code"
        Me.DataGridTextBoxColumn1.MappingName = "ItemCode"
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 120
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Description"
        Me.DataGridTextBoxColumn2.MappingName = "ItemDesc"
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 259
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Unit Price"
        Me.DataGridTextBoxColumn3.MappingName = "UnitPrice"
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 150
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Lot Number"
        Me.DataGridTextBoxColumn4.MappingName = "LotNumber"
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 95
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "PrincipalCode"
        Me.DataGridTextBoxColumn5.MappingName = "PrincipalCode"
        Me.DataGridTextBoxColumn5.ReadOnly = True
        Me.DataGridTextBoxColumn5.Width = 150
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(8, 480)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Save as New Record"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(256, 480)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Add to Exception"
        Me.Button2.Visible = False
        '
        'NewItem
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(416, 505)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGrid1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "NewItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Item(s)"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub NewItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Not Me.DataGridSource Is Nothing Then
            DataGrid1.DataSource = CreateDataSource()
            Me.Opened = True
        End If

    End Sub

    Function CreateDataSource() As ICollection
        Dim dt As New DataTable
        Dim dr As DataRow

        dt.Columns.Add(New DataColumn("ItemCode", GetType(String)))
        dt.Columns.Add(New DataColumn("ItemDesc", GetType(String)))
        'dt.Columns.Add(New DataColumn("UnitPrice", GetType(String)))
        'dt.Columns.Add(New DataColumn("LotNumber", GetType(String)))
        'dt.Columns.Add(New DataColumn("PrincipalCode", GetType(String)))

        While Me.DataGridSource.Read
            dr = dt.NewRow()
            dr(0) = CStr(DataGridSource("ItemCode"))
            dr(1) = CStr(DataGridSource("ItemDesc"))
            'dr(2) = CStr(DataGridSource("UnitPrice"))
            'dr(3) = CStr(DataGridSource("LotNumber"))
            'dr(4) = CStr(DataGridSource("PrincipalCode"))

            dt.Rows.Add(dr)
        End While

        Dim dv As New DataView(dt)
        DataView1 = dv
        Me.LastCount = dv.Count
        Return dv
    End Function

    Private Sub DataGrid1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.CurrentCellChanged
        DataGrid1.Select(DataGrid1.CurrentCell.RowNumber)
    End Sub

    Private Function RowSelected() As Boolean
        If DataGrid1.IsSelected(DataGrid1.CurrentRowIndex) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If RowSelected() = True Then
            'MessageBox.Show("User Selected a Row!")
        Else
            MessageBox.Show("Please select a record to continue!")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RowSelected() = True Then
            cForm = New Itm_Entry
            'Edit Properties in Itm_Entry Form
            'cForm.PassingData = True
            cForm.vMetroDrugCode.Text = CStr(DataGrid1.Item(DataGrid1.CurrentRowIndex, 0))
            cForm.vItemDesc.Text = CStr(DataGrid1.Item(DataGrid1.CurrentRowIndex, 1))
            'cForm.vUnitPrice.Text = CStr(DataGrid1.Item(DataGrid1.CurrentRowIndex, 2))
            cForm.FormBorderStyle = FormBorderStyle.FixedDialog
            cForm.StartPosition = FormStartPosition.CenterScreen
            cForm.MaximizeBox = False
            cForm.ShowDialog()
        Else
            MessageBox.Show("Please select a record to continue!")
        End If
    End Sub

    Private Sub DataGrid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.Click
        'Try
        '    If Not cForm Is Nothing Then
        '        If cForm.vMetroDrugCode.Text <> "" Then
        '            Dim dv As DataView
        '            Dim index As Integer
        '            Dim vals(0) As Object
        '            vals(0) = cForm.vMetroDrugCode.Text
        '            dv = CType(DataGrid1.DataSource, DataView)
        '            dv.Sort = "ItemCode"
        '            index = dv.Find(vals)
        '            If index <> -1 Then dv.Delete(index)
        '            Me.LastDeleted = cForm.vMetroDrugCode.Text
        '            DataGrid1.DataSource = dv
        '            Me.LastCount = dv.Count
        '        End If
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "New Item(s) Form", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

    End Sub

    Private Sub NewItem_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Try
            If Not cForm Is Nothing Then
                If cForm.vMetroDrugCode.Text <> "" Then
                    Dim dv As DataView
                    Dim index As Integer
                    Dim vals(0) As Object
                    vals(0) = cForm.vMetroDrugCode.Text
                    dv = CType(DataGrid1.DataSource, DataView)
                    dv.Sort = "ItemCode"
                    index = dv.Find(vals)
                    If index <> -1 Then dv.Delete(index)
                    Me.LastDeleted = cForm.vMetroDrugCode.Text
                    DataGrid1.DataSource = dv
                    Me.LastCount = dv.Count
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "New Item(s) Form", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
