Public Class frmMyItemBrowse
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        'Me.Panel1.Controls.Add(New ItemBrowseControl)

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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridItemListBrowse As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataGridItemListBrowse = New System.Windows.Forms.DataGrid
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridItemListBrowse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.DockPadding.Bottom = 5
        Me.Panel1.DockPadding.Left = 5
        Me.Panel1.DockPadding.Right = 5
        Me.Panel1.DockPadding.Top = 2
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(562, 311)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridItemListBrowse)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(5, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(552, 304)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'DataGridItemListBrowse
        '
        Me.DataGridItemListBrowse.AlternatingBackColor = System.Drawing.Color.Beige
        Me.DataGridItemListBrowse.CaptionText = "Item List"
        Me.DataGridItemListBrowse.DataMember = ""
        Me.DataGridItemListBrowse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridItemListBrowse.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridItemListBrowse.Location = New System.Drawing.Point(3, 17)
        Me.DataGridItemListBrowse.Name = "DataGridItemListBrowse"
        Me.DataGridItemListBrowse.Size = New System.Drawing.Size(546, 284)
        Me.DataGridItemListBrowse.TabIndex = 0
        '
        'frmMyItemBrowse
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(562, 311)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMyItemBrowse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item List Browse"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridItemListBrowse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private MyCodeTableDS As New CodeTablesDS
    Private BusinessObject As New BusinessLayer.clsFileMaintenance
    Private _xMyTabPageControl1 As New MyTabPageControl1
    Private _sItemCode, _sOldMDICode, _sDivisionName, _sItemDesc As String

    Private Sub frmMyItemBrowse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles MyBase.Load
        Me.ItemListBrowse()
    End Sub

    Public Property xItemCode() As String
        Get
            Return Me._sItemCode
        End Get
        Set(ByVal Value As String)
            _sItemCode = Value
        End Set
    End Property

    Public Property xOldMDICode() As String
        Get
            Return Me._sOldMDICode
        End Get
        Set(ByVal Value As String)
            _sOldMDICode = Value
        End Set
    End Property

    Public Property xItemDesc() As String
        Get
            Return Me._sItemDesc
        End Get
        Set(ByVal Value As String)
            _sItemDesc = Value
        End Set
    End Property

    Public Property xDivisionName() As String
        Get
            Return Me._sDivisionName
        End Get
        Set(ByVal Value As String)
            _sDivisionName = Value
        End Set
    End Property

    Private Sub ItemListBrowse()
        Me.Cursor = Cursors.WaitCursor

        If MyCodeTableDS.sp_v_item_list.Count > 0 Then MyCodeTableDS.sp_v_item_list.Clear()

        Try
            BusinessObject.Sub_Show(ServerPath, "sp_v_item_list", CommandType.StoredProcedure, _
                MyCodeTableDS, "sp_v_item_list")

            DataGridItemListBrowse.DataSource = MyCodeTableDS.sp_v_item_list

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub DataGridItemListBrowse_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
        Handles DataGridItemListBrowse.MouseUp
        Dim _i, _iRow As Integer
        Dim _dg As DataGrid = DirectCast(sender, DataGrid)
        Dim _ht As DataGrid.HitTestInfo
        Dim _iRowIndex As Integer = DataGridItemListBrowse.CurrentRowIndex
        Dim TextBoxItemCode As TextBox = DirectCast(_xMyTabPageControl1.TextBoxItemCode, TextBox)
        Dim TextBoxItemDesc As TextBox = DirectCast(_xMyTabPageControl1.TextBoxItemDescription, TextBox)
        Dim TextBoxDivName As TextBox = DirectCast(_xMyTabPageControl1.TextBoxDivisionName, TextBox)

        _dg = DataGridItemListBrowse
        _iRow = _dg.CurrentRowIndex

        _ht = _dg.HitTest(e.X, e.Y)
        _i = _ht.Row

        If (e.Button = MouseButtons.Right) Then
            Return
        Else
            If _i = -1 Then
                Return
            Else
                _dg.Select(_ht.Row)
                If _iRowIndex = -1 Then
                    Return
                Else
                    'If MyCodeTableDS.sp_v_item_list.Count <> 0 Then
                    '    With DataGridItemListBrowse
                    '        xItemCode = Trim(.Item(_iRowIndex, 0).ToString)
                    '        xItemDesc = Trim(.Item(_iRowIndex, 2).ToString)
                    '        xDivisionName = Trim(.Item(_iRowIndex, 6).ToString)
                    '    End With
                    '    TextBoxItemCode.Text = xItemCode
                    '    TextBoxItemDesc.Text = xItemDesc
                    '    TextBoxDivName.Text = xDivisionName
                    '    Me.DialogResult = DialogResult.Ignore
                    'End If
                End If
            End If
        End If
    End Sub

    Private Sub DataGridItemListBrowse_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles DataGridItemListBrowse.CurrentCellChanged
        Dim _iRowIndex As Integer = DataGridItemListBrowse.CurrentRowIndex

        'Try
        '    If _iRowIndex = -1 Then
        '        Return
        '    Else
        '        If MyCodeTableDS.sp_v_item_list.Count <> 0 Then
        '            With DataGridItemListBrowse
        '                _delItemCode(Trim(.Item(_iRowIndex, 0).toString))
        '            End With
        '        End If
        '    End If
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub DataGridItemListBrowse_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles DataGridItemListBrowse.DoubleClick
        Dim _iRowIndex As Integer = DataGridItemListBrowse.CurrentRowIndex

        Try
            If _iRowIndex = -1 Then
                Return
            Else
                If DataGridItemListBrowse.IsSelected(_iRowIndex) Then
                    With DataGridItemListBrowse
                        xItemCode = Trim(.Item(_iRowIndex, 0).ToString)
                        xOldMDICode = Trim(.Item(_iRowIndex, 1).ToString)
                        xItemDesc = Trim(.Item(_iRowIndex, 2).ToString)
                        'xDivisionName = Trim(.Item(_iRowIndex, 6).ToString) ***removed due to change object to dynamically
                        Me.DialogResult = DialogResult.OK
                    End With
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
