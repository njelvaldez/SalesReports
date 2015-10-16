Imports System.Data.SqlClient
Public Class NewCustomer
    Inherits System.Windows.Forms.Form
    Private _source As SqlDataReader
    Private _name As String
    Private _customerno As String
    Private _shiptocode As String
    Private cForm As CustomerCT
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
    Public Property CustomerNo() As String
        Get
            Return Me._customerno
        End Get
        Set(ByVal Value As String)
            Me._customerno = Value
        End Set
    End Property
    Public Property ShipToCode() As String
        Get
            Return Me._shiptocode
        End Get
        Set(ByVal Value As String)
            Me._shiptocode = Value
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
    Public Property FullName() As String
        Get
            Return Me._name
        End Get
        Set(ByVal Value As String)
            Me._name = Value
        End Set
    End Property
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
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn15 As System.Windows.Forms.DataGridTextBoxColumn
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
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
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
        Me.DataGrid1.Size = New System.Drawing.Size(976, 464)
        Me.DataGrid1.TabIndex = 0
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.SystemColors.InactiveBorder
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = ""
        Me.DataGridTableStyle1.RowHeadersVisible = False
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Company"
        Me.DataGridTextBoxColumn1.MappingName = "Comp"
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 60
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Branch Code"
        Me.DataGridTextBoxColumn2.MappingName = "Bran"
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Branch Name"
        Me.DataGridTextBoxColumn3.MappingName = "Bnam"
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 150
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Customer #"
        Me.DataGridTextBoxColumn4.MappingName = "Cus#"
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 95
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Customer Name"
        Me.DataGridTextBoxColumn5.MappingName = "Cnam"
        Me.DataGridTextBoxColumn5.ReadOnly = True
        Me.DataGridTextBoxColumn5.Width = 150
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Address 1"
        Me.DataGridTextBoxColumn6.MappingName = "Cad1"
        Me.DataGridTextBoxColumn6.ReadOnly = True
        Me.DataGridTextBoxColumn6.Width = 150
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Address 2"
        Me.DataGridTextBoxColumn7.MappingName = "Cad2"
        Me.DataGridTextBoxColumn7.ReadOnly = True
        Me.DataGridTextBoxColumn7.Width = 150
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "Ship To Code"
        Me.DataGridTextBoxColumn15.MappingName = "Zcda"
        Me.DataGridTextBoxColumn15.ReadOnly = True
        Me.DataGridTextBoxColumn15.Width = 95
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "Ship To"
        Me.DataGridTextBoxColumn8.MappingName = "ShipTo"
        Me.DataGridTextBoxColumn8.ReadOnly = True
        Me.DataGridTextBoxColumn8.Width = 150
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "Ship Address 1"
        Me.DataGridTextBoxColumn9.MappingName = "Sad1"
        Me.DataGridTextBoxColumn9.ReadOnly = True
        Me.DataGridTextBoxColumn9.Width = 150
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "Ship Address 2"
        Me.DataGridTextBoxColumn10.MappingName = "Sad2"
        Me.DataGridTextBoxColumn10.ReadOnly = True
        Me.DataGridTextBoxColumn10.Width = 150
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "Zip Code"
        Me.DataGridTextBoxColumn11.MappingName = "Zipc"
        Me.DataGridTextBoxColumn11.ReadOnly = True
        Me.DataGridTextBoxColumn11.Width = 60
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.MappingName = "Ter#"
        Me.DataGridTextBoxColumn12.ReadOnly = True
        Me.DataGridTextBoxColumn12.Width = 0
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "Area"
        Me.DataGridTextBoxColumn13.MappingName = "Area"
        Me.DataGridTextBoxColumn13.ReadOnly = True
        Me.DataGridTextBoxColumn13.Width = 0
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "Class Name"
        Me.DataGridTextBoxColumn14.MappingName = "Clsn"
        Me.DataGridTextBoxColumn14.ReadOnly = True
        Me.DataGridTextBoxColumn14.Width = 150
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
        Me.Button2.Location = New System.Drawing.Point(168, 480)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Add to Exception"
        Me.Button2.Visible = False
        '
        'NewCustomer
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(994, 505)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGrid1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "NewCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Customer(s)"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub NewCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Not Me.DataGridSource Is Nothing Then
            DataGrid1.DataSource = CreateDataSource()
            Me.Opened = True
        End If

    End Sub

    Function CreateDataSource() As ICollection
        Dim dt As New DataTable
        Dim dr As DataRow

        dt.Columns.Add(New DataColumn("Comp", GetType(String)))
        dt.Columns.Add(New DataColumn("Bran", GetType(String)))
        dt.Columns.Add(New DataColumn("Bnam", GetType(String)))
        dt.Columns.Add(New DataColumn("Cus#", GetType(String)))
        dt.Columns.Add(New DataColumn("Cnam", GetType(String)))
        dt.Columns.Add(New DataColumn("Cad1", GetType(String)))
        dt.Columns.Add(New DataColumn("Cad2", GetType(String)))
        dt.Columns.Add(New DataColumn("ShipTo", GetType(String)))
        dt.Columns.Add(New DataColumn("Sad1", GetType(String)))
        dt.Columns.Add(New DataColumn("Sad2", GetType(String)))
        dt.Columns.Add(New DataColumn("Zipc", GetType(String)))
        dt.Columns.Add(New DataColumn("Ter#", GetType(String)))
        dt.Columns.Add(New DataColumn("Area", GetType(String)))
        dt.Columns.Add(New DataColumn("Clsn", GetType(String)))
        dt.Columns.Add(New DataColumn("Zcda", GetType(String)))
        'dt.Columns.Add(New DataColumn("Check", GetType(Boolean)))

        While Me.DataGridSource.Read
            dr = dt.NewRow()
            dr(0) = CStr(DataGridSource("Comp"))
            dr(1) = CStr(DataGridSource("Bran"))
            dr(2) = CStr(DataGridSource("Bnam"))
            dr(3) = CStr(DataGridSource("Cus#"))
            dr(4) = CStr(DataGridSource("Cnam"))
            dr(5) = CStr(DataGridSource("Cad1"))
            dr(6) = CStr(DataGridSource("Cad2"))
            dr(7) = CStr(DataGridSource("ShipTo"))
            dr(8) = CStr(DataGridSource("Sad1"))
            dr(9) = CStr(DataGridSource("Sad2"))
            dr(10) = CStr(DataGridSource("Zipc"))
            dr(11) = CStr(DataGridSource("Ter#"))
            dr(12) = CStr(DataGridSource("Area"))
            dr(13) = CStr(DataGridSource("Clsn"))
            dr(14) = CStr(DataGridSource("Zcda"))

            dt.Rows.Add(dr)

        End While

        Dim dv As New DataView(dt)
        DataView1 = dv
        Me.LastCount = dv.Count
        Return dv
    End Function 'CreateDataSource

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
            cForm = New CustomerCT
            cForm.PassingData = True
            cForm.CustomerName = CStr(DataGrid1.Item(DataGrid1.CurrentRowIndex, 4))
            cForm.Address1 = CStr(DataGrid1.Item(DataGrid1.CurrentRowIndex, 5))
            cForm.Address2 = CStr(DataGrid1.Item(DataGrid1.CurrentRowIndex, 6))
            cForm.MetroCode = CStr(DataGrid1.Item(DataGrid1.CurrentRowIndex, 3))
            cForm.ShipToCode = CStr(DataGrid1.Item(DataGrid1.CurrentRowIndex, 7))
            cForm.FormBorderStyle = FormBorderStyle.FixedDialog
            cForm.StartPosition = FormStartPosition.CenterScreen
            cForm.MaximizeBox = False
            cForm.ShowDialog()
        Else
            MessageBox.Show("Please select a record to continue!", "New Customers", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub DataGrid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.Click
        'Try
        '    If Not cForm Is Nothing Then
        '        'If cForm.MetroCode & "-" & cForm.ShipToCode <> Me.LastDeleted Then
        '        If cForm.MetroCode <> "" And cForm.ShipToCode <> "" Then
        '            Dim dv As DataView
        '            Dim index As Integer
        '            Dim vals(1) As Object
        '            vals(0) = cForm.MetroCode
        '            vals(1) = cForm.ShipToCode
        '            dv = CType(DataGrid1.DataSource, DataView)
        '            dv.Sort = "[Cus#],Zcda"
        '            index = dv.Find(vals)
        '            'dv.RowFilter = "[Cus#] <> '" & cForm.MetroCode & "' AND Zcda <> '" & cForm.ShipToCode & "'"
        '            If index <> -1 Then dv.Delete(index)
        '            Me.LastDeleted = cForm.MetroCode & "-" & cForm.ShipToCode
        '            DataGrid1.DataSource = dv
        '        End If
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "New Customer(s) Form", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

    End Sub

    Private Sub NewCustomer_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Try
            If Not cForm Is Nothing Then
                'If cForm.MetroCode & "-" & cForm.ShipToCode <> Me.LastDeleted Then
                If cForm.MetroCode <> "" And cForm.ShipToCode <> "" Then
                    Dim dv As DataView
                    Dim index As Integer
                    Dim vals(1) As Object
                    vals(0) = cForm.MetroCode
                    vals(1) = cForm.ShipToCode
                    dv = CType(DataGrid1.DataSource, DataView)
                    dv.Sort = "[Cus#],Zcda"
                    index = dv.Find(vals)
                    'dv.RowFilter = "[Cus#] <> '" & cForm.MetroCode & "' AND Zcda <> '" & cForm.ShipToCode & "'"
                    If index <> -1 Then dv.Delete(index)
                    Me.LastDeleted = cForm.MetroCode & "-" & cForm.ShipToCode
                    DataGrid1.DataSource = dv
                    Me.LastCount = dv.Count
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "New Customer(s) Form", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
