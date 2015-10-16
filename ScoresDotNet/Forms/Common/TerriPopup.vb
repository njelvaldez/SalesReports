Imports System.Data.SqlClient

Public Class TerriPopup
    Inherits System.Windows.Forms.Form
    Private RemoteDataSet As New MyDataSetDB

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
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents gcRow As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents gcCode As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents gcDesc As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents gcDesc2 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.gcRow = New System.Windows.Forms.DataGridTextBoxColumn
        Me.gcCode = New System.Windows.Forms.DataGridTextBoxColumn
        Me.gcDesc = New System.Windows.Forms.DataGridTextBoxColumn
        Me.gcDesc2 = New System.Windows.Forms.DataGridTextBoxColumn
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGrid1.CaptionVisible = False
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(-1, -1)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(431, 361)
        Me.DataGrid1.TabIndex = 1
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Cyan
        Me.DataGridTableStyle1.BackColor = System.Drawing.Color.LightCyan
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.gcRow, Me.gcCode, Me.gcDesc, Me.gcDesc2})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "terCodDesc"
        '
        'gcRow
        '
        Me.gcRow.Format = ""
        Me.gcRow.FormatInfo = Nothing
        Me.gcRow.MappingName = "rowid"
        Me.gcRow.NullText = ""
        Me.gcRow.Width = 0
        '
        'gcCode
        '
        Me.gcCode.Format = ""
        Me.gcCode.FormatInfo = Nothing
        Me.gcCode.HeaderText = "Code"
        Me.gcCode.MappingName = "xcode"
        Me.gcCode.NullText = ""
        Me.gcCode.Width = 60
        '
        'gcDesc
        '
        Me.gcDesc.Format = ""
        Me.gcDesc.FormatInfo = Nothing
        Me.gcDesc.HeaderText = "Territory"
        Me.gcDesc.MappingName = "xdesc"
        Me.gcDesc.NullText = ""
        Me.gcDesc.Width = 180
        '
        'gcDesc2
        '
        Me.gcDesc2.Format = ""
        Me.gcDesc2.FormatInfo = Nothing
        Me.gcDesc2.HeaderText = "Province"
        Me.gcDesc2.MappingName = "xdesc2"
        Me.gcDesc2.NullText = ""
        Me.gcDesc2.Width = 180
        '
        'TerriPopup
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(429, 358)
        Me.Controls.Add(Me.DataGrid1)
        Me.Name = "TerriPopup"
        Me.Text = "TerriPopup"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub DataGrid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) _
                Handles DataGrid1.DoubleClick
        gCode = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 0).ToString
        territoryXCode = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 1).ToString
        gDesc = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 2).ToString
        Close()
    End Sub

    Private Sub frmCodDesc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        RemoteDataSet.dtCodDesc.Clear()
        If SPparam = False Then
            BusinessObject.Sub_Show(ServerPath2, StordProcName, CommandType.StoredProcedure, RemoteDataSet, "terCodDesc")
        Else
            BusinessObject.Sub_Show(ServerPath2, StordProcName, CommandType.Text, RemoteDataSet, "terCodDesc")
        End If
        DataGrid1.DataSource = RemoteDataSet.terCodDesc
    End Sub

    Private Sub frmCodDesc_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp, MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then    'e.KeyValue = 27 Or e.KeyCode = Keys.Cancel Or 
            Close()
        ElseIf e.KeyCode = Keys.Enter Then
            DataGrid1_DoubleClick(sender, e)
        End If
    End Sub

End Class
