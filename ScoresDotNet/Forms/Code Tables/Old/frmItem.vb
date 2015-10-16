Public Class frmItem
    Inherits System.Windows.Forms.Form
    Public CustomersDs As New DataSet
    Private PropertyValues As String()
    ' Define the default property.
    Default Public Property PropArray(ByVal Index As Integer) As String
        Get
            Return PropertyValues(Index)
        End Get
        Set(ByVal Value As String)
            If PropertyValues Is Nothing Then
                ' The array contains Nothing when first accessed.
                ReDim PropertyValues(0)
            Else
                ' Re-dimension the array to hold the new element.
                ReDim Preserve PropertyValues(UBound(PropertyValues) + 1)
            End If
            PropertyValues(Index) = Value
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
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents IsConnection As System.Data.SqlClient.SqlConnection
    Friend WithEvents MedrepsAdapter As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwItems As System.Windows.Forms.ListView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lvwItems = New System.Windows.Forms.ListView
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.btnCancel = New System.Windows.Forms.Button
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.IsConnection = New System.Data.SqlClient.SqlConnection
        Me.MedrepsAdapter = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SuspendLayout()
        '
        'lvwItems
        '
        Me.lvwItems.AllowColumnReorder = True
        Me.lvwItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvwItems.FullRowSelect = True
        Me.lvwItems.GridLines = True
        Me.lvwItems.Location = New System.Drawing.Point(8, 8)
        Me.lvwItems.Name = "lvwItems"
        Me.lvwItems.Size = New System.Drawing.Size(424, 424)
        Me.lvwItems.TabIndex = 0
        Me.lvwItems.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Item Code"
        Me.ColumnHeader6.Width = 82
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Item"
        Me.ColumnHeader7.Width = 320
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(357, 440)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "[SelectCustomers]"
        Me.SqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand1.Connection = Me.IsConnection
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        '
        'IsConnection
        '
        Me.IsConnection.ConnectionString = "workstation id=SHAQUILLE;packet size=4096;user id=sa;pwd=jynxz;data source=MICDB;" & _
        "persist security info=False;initial catalog=ScoresDotNet"
        '
        'MedrepsAdapter
        '
        Me.MedrepsAdapter.SelectCommand = Me.SqlSelectCommand2
        Me.MedrepsAdapter.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SelectHiiMedrep", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Rowid", "Rowid"), New System.Data.Common.DataColumnMapping("MRCode", "MRCode"), New System.Data.Common.DataColumnMapping("MRName", "MRName"), New System.Data.Common.DataColumnMapping("Hire_Date", "Hire_Date"), New System.Data.Common.DataColumnMapping("Resign_Date", "Resign_Date"), New System.Data.Common.DataColumnMapping("Create_Date", "Create_Date"), New System.Data.Common.DataColumnMapping("Type", "Type"), New System.Data.Common.DataColumnMapping("Territories", "Territories"), New System.Data.Common.DataColumnMapping("Exclusive", "Exclusive")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "[Territories]"
        Me.SqlSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand2.Connection = Me.IsConnection
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        '
        'frmPrincipal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(440, 470)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lvwItems)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Item List"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Fill_lvwItems()
        Dim myConnection As New SqlClient.SqlConnection
        With myConnection
            .ConnectionString = IsConnection.ConnectionString
            .Open()
        End With
        Dim mySelectCommand As New SqlClient.SqlCommand
        With mySelectCommand
            .Connection = myConnection
            .CommandType = CommandType.Text
            .CommandText = "Select itemcode,itemdesc from NewScores..Item"
        End With
        MedrepsAdapter.SelectCommand = mySelectCommand
        Dim i As Integer
        Try
            MedrepsAdapter.Fill(CustomersDs, "Item")
            Dim myDataView As New DataView(CustomersDs.Tables("Item"))
            For i = 0 To myDataView.Count - 1
                With lvwItems
                    .Items.Add(CStr(myDataView.Item(i).Row.Item("ItemCode")))
                    With .Items
                        .Item(i).SubItems.Add(CStr(myDataView.Item(i).Row.Item("ItemDesc")))
                    End With
                End With
            Next
        Catch ex As Exception
            MessageBox.Show("Error Occurred in Module : Fill_lvwItems" & vbCrLf & _
            "Error Message : " & ex.ToString)
        End Try
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub
    Private Sub lvwItems_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwItems.DoubleClick
        Dim myListItem As ListViewItem = lvwItems.Items.Item(lvwItems.SelectedIndices.Item(0))
        Me.PropArray(0) = myListItem.Text 'ItemCode
        Me.PropArray(1) = myListItem.SubItems(1).Text 'ItemDesc
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub frmTerritory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Fill_lvwItems()
    End Sub
    Private Sub lvwItems_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvwItems.ColumnClick
        ' Set the ListViewItemSorter property to a new ListViewItemComparer object.
        Me.lvwItems.ListViewItemSorter = New ListViewItemComparer(e.Column)
        ' Call the sort method to manually sort the column based on the ListViewItemComparer implementation.
        lvwItems.Sort()
    End Sub
End Class
