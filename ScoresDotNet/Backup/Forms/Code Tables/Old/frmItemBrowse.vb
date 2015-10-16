Imports System.Data.SqlClient
Public Class frmItemBrowse
    Inherits System.Windows.Forms.Form
    Private RemoteDataSet As New _Item
    Private dgItem(7) As String
    Public Property LineData(ByVal index As Integer) As String
        Get
            Return dgItem(index)
        End Get
        Set(ByVal Value As String)
            dgItem(index) = Value
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
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnCancel As System.Windows.Forms.Button
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
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btnCancel = New System.Windows.Forms.Button
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 8)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(696, 504)
        Me.DataGrid1.TabIndex = 0
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Item_Browse"
        Me.DataGridTableStyle1.ReadOnly = True
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Code"
        Me.DataGridTextBoxColumn1.MappingName = "ItemCode"
        Me.DataGridTextBoxColumn1.Width = 50
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Description"
        Me.DataGridTextBoxColumn2.MappingName = "ItemDesc"
        Me.DataGridTextBoxColumn2.Width = 175
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Unit"
        Me.DataGridTextBoxColumn3.MappingName = "ItemUnit"
        Me.DataGridTextBoxColumn3.Width = 50
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn4.Format = "#,##0.00"
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Price  "
        Me.DataGridTextBoxColumn4.MappingName = "UnitPrice"
        Me.DataGridTextBoxColumn4.Width = 76
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.MappingName = "PrinCode"
        Me.DataGridTextBoxColumn5.Width = 0
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Principal"
        Me.DataGridTextBoxColumn6.MappingName = "PrinName"
        Me.DataGridTextBoxColumn6.Width = 130
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.MappingName = "DivCode"
        Me.DataGridTextBoxColumn7.Width = 0
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "Division"
        Me.DataGridTextBoxColumn8.MappingName = "DivName"
        Me.DataGridTextBoxColumn8.Width = 158
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(628, 517)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "&Cancel"
        '
        'frmItemBrowse
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(714, 544)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.DataGrid1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmItemBrowse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Items"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Load_Grid()
        Dim BusinessObject As New BusinessLayer.clsItem
        Dim j As Integer = 8
        If (Fld0 <> "") And (Fld1 <> "") Then
            j = 3
            'GoTo ditto
        ElseIf (Fld0 <> "") Then
            j = 1
        ElseIf Fld1 <> "" Then
            j = 2
        End If
ditto:
        Dim Params(0) As SqlParameter
        z = "Select it.itemcode,it.itemdesc,it.itemunit, " & _
                   "it.unitprice,pr.princode,pr.prinname, " & _
                   "di.divcode,di.divname " & _
            "From newscores..item it " & _
                 "inner join newscores..principal pr on it.princode=pr.princode " & _
                 "inner join newscores..division di on pr.divcode=di.divcode "
        If j <> 8 Then
            If j = 3 Then
                z = z & "Where (right(rtrim(itemcode), 1) <> 'L' and itemcode like '%" & Fld0 & "%') " & _
                        "or (right(rtrim(itemcode), 1) <> 'L' and itemdesc like '%" & Fld1 & "%') "
                GoTo gohere
            ElseIf j = 1 Then
                z = z & "Where right(rtrim(itemcode), 1) <> 'L' and itemcode like '%" & Fld0 & "%' "
                GoTo gohere
            ElseIf j = 2 Then
                z = z & "Where right(rtrim(itemcode), 1) <> 'L' and itemdesc like '%" & Fld1 & "%' "
                GoTo gohere
            End If
        Else
            z = z & "Where right(rtrim(itemcode), 1) <> 'L' "
        End If
gohere:
        Dim SqlStr As New SqlParameter("@SqlQry", SqlDbType.NVarChar, 3500)
        SqlStr.Direction = ParameterDirection.Input
        SqlStr.Value = z
        Params(0) = SqlStr
        Try
            BusinessObject.Item_Browse(ServerPath2, "GenericQryProc", CommandType.StoredProcedure, _
                                       RemoteDataSet, "Item_Browse", Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        DataGrid1.DataSource = RemoteDataSet.Item_Browse
    End Sub

    Private Sub DataGrid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.Click, DataGrid1.CurrentCellChanged
        With DataGrid1
            .Select(.CurrentCell.RowNumber)
            LineData(0) = CStr(.Item(.CurrentCell.RowNumber, 0))
            LineData(1) = CStr(.Item(.CurrentCell.RowNumber, 1))
            LineData(2) = CStr(.Item(.CurrentCell.RowNumber, 2))
            LineData(3) = CStr(.Item(.CurrentCell.RowNumber, 3))
            LineData(4) = CStr(.Item(.CurrentCell.RowNumber, 4))
            LineData(5) = CStr(.Item(.CurrentCell.RowNumber, 5))
            LineData(6) = CStr(.Item(.CurrentCell.RowNumber, 6))
            LineData(7) = CStr(.Item(.CurrentCell.RowNumber, 7))
        End With
    End Sub

    Private Sub DataGrid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.DoubleClick
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub frmItemBrowse_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_Grid()
    End Sub
End Class
