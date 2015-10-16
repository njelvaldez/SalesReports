Public Class CustomerShipToMaster_Tagging
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
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGrid2 As System.Windows.Forms.DataGrid
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn15 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn16 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn17 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn18 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn19 As System.Windows.Forms.DataGridTextBoxColumn
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
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn19 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGrid2 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn17 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn18 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 8)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(1352, 336)
        Me.DataGrid1.TabIndex = 0
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn19})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = ""
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Metro Code"
        Me.DataGridTextBoxColumn1.MappingName = "MetroCode"
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Customer Name"
        Me.DataGridTextBoxColumn2.MappingName = "CustomerName"
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Street"
        Me.DataGridTextBoxColumn3.MappingName = "Street"
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "District"
        Me.DataGridTextBoxColumn4.MappingName = "District"
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "City"
        Me.DataGridTextBoxColumn5.MappingName = "City"
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Region"
        Me.DataGridTextBoxColumn6.MappingName = "Region"
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "ShipTo Code"
        Me.DataGridTextBoxColumn7.MappingName = "ShipToCode"
        Me.DataGridTextBoxColumn7.Width = 75
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "ShipTo Name"
        Me.DataGridTextBoxColumn8.MappingName = "ShipToName"
        Me.DataGridTextBoxColumn8.Width = 75
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "Street2"
        Me.DataGridTextBoxColumn9.MappingName = "Street2"
        Me.DataGridTextBoxColumn9.Width = 75
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "District2"
        Me.DataGridTextBoxColumn10.MappingName = "District2"
        Me.DataGridTextBoxColumn10.Width = 75
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "Region2"
        Me.DataGridTextBoxColumn11.MappingName = "Region2"
        Me.DataGridTextBoxColumn11.Width = 75
        '
        'DataGridTextBoxColumn19
        '
        Me.DataGridTextBoxColumn19.Format = ""
        Me.DataGridTextBoxColumn19.FormatInfo = Nothing
        Me.DataGridTextBoxColumn19.HeaderText = "NMPC CustCode"
        Me.DataGridTextBoxColumn19.MappingName = "NMPCCustCode"
        Me.DataGridTextBoxColumn19.Width = 110
        '
        'DataGrid2
        '
        Me.DataGrid2.DataMember = ""
        Me.DataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid2.Location = New System.Drawing.Point(8, 384)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.Size = New System.Drawing.Size(1352, 320)
        Me.DataGrid2.TabIndex = 1
        Me.DataGrid2.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.DataGrid2
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn16, Me.DataGridTextBoxColumn17, Me.DataGridTextBoxColumn18})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = ""
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "RowID"
        Me.DataGridTextBoxColumn12.MappingName = "Rowid"
        Me.DataGridTextBoxColumn12.Width = 50
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "Customer Code"
        Me.DataGridTextBoxColumn13.MappingName = "CustCode"
        Me.DataGridTextBoxColumn13.Width = 110
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "Customer Name"
        Me.DataGridTextBoxColumn14.MappingName = "CustName"
        Me.DataGridTextBoxColumn14.Width = 250
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "Type"
        Me.DataGridTextBoxColumn15.MappingName = "Type"
        Me.DataGridTextBoxColumn15.Width = 150
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Format = ""
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.HeaderText = "Address 1"
        Me.DataGridTextBoxColumn16.MappingName = "Address1"
        Me.DataGridTextBoxColumn16.Width = 250
        '
        'DataGridTextBoxColumn17
        '
        Me.DataGridTextBoxColumn17.Format = ""
        Me.DataGridTextBoxColumn17.FormatInfo = Nothing
        Me.DataGridTextBoxColumn17.HeaderText = "Address 2"
        Me.DataGridTextBoxColumn17.MappingName = "Address2"
        Me.DataGridTextBoxColumn17.Width = 250
        '
        'DataGridTextBoxColumn18
        '
        Me.DataGridTextBoxColumn18.Format = ""
        Me.DataGridTextBoxColumn18.FormatInfo = Nothing
        Me.DataGridTextBoxColumn18.HeaderText = "Territory"
        Me.DataGridTextBoxColumn18.MappingName = "Territory"
        Me.DataGridTextBoxColumn18.Width = 150
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(8, 360)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(528, 20)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(544, 360)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 20)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "All"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1088, 360)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(272, 20)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Update"
        '
        'CustomerShipToMaster_Tagging
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1366, 721)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGrid2)
        Me.Controls.Add(Me.DataGrid1)
        Me.Name = "CustomerShipToMaster_Tagging"
        Me.Text = "CustomerShipToMaster_Tagging"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub CustomerShipToMaster_Tagging_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Load_DataGrid1()

    End Sub

    Private Sub Load_DataGrid1()

        DataGrid1.DataSource = DataMaintenance.GetDataTable(ServerPath2, "Get_CustomerShipToMaster", CommandType.StoredProcedure, 0)
        DataGrid1.CaptionText = CType(DataGrid1.DataSource, DataTable).Rows.Count.ToString() & " rows"

    End Sub

    Private Sub DataGrid1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.CurrentCellChanged

        DataGrid1.Select(DataGrid1.CurrentCell.RowNumber)
        If TextBox1.Text = "" Then
            Load_DataGrid2()
        End If

    End Sub

    Private Sub Load_DataGrid2()

        DataMaintenance.myParamArray(0, 0) = "@CustomerName"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.VarChar
        DataMaintenance.myParamArray(0, 2) = 150
        DataMaintenance.myParamArray(0, 3) = ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "String"
        DataMaintenance.myParamArray(0, 5) = CStr(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 1))

        DataGrid2.DataSource = DataMaintenance.GetDataTable(ServerPath2, "MatchCustomer", CommandType.StoredProcedure, 1)

    End Sub


    Private Sub DataGrid2_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid2.CurrentCellChanged

        DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 11) = CStr(DataGrid2.Item(DataGrid2.CurrentCell.RowNumber, 1))

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.Cursor = Cursors.WaitCursor
        DataMaintenance.myParamArray(0, 0) = "@CustomerCode"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.VarChar
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "String"

        DataMaintenance.myParamArray(1, 0) = "@SoldTo"
        DataMaintenance.myParamArray(1, 1) = SqlDbType.VarChar
        DataMaintenance.myParamArray(1, 2) = 10
        DataMaintenance.myParamArray(1, 3) = ParameterDirection.Input
        DataMaintenance.myParamArray(1, 4) = "String"

        DataMaintenance.myParamArray(2, 0) = "@ShipToCode"
        DataMaintenance.myParamArray(2, 1) = SqlDbType.VarChar
        DataMaintenance.myParamArray(2, 2) = 10
        DataMaintenance.myParamArray(2, 3) = ParameterDirection.Input
        DataMaintenance.myParamArray(2, 4) = "String"


        For i As Integer = 0 To CType(DataGrid1.DataSource, DataTable).Rows.Count - 1
            If CStr(DataGrid1.Item(i, 11)) > "" Then
                DataMaintenance.myParamArray(0, 5) = CStr(DataGrid1.Item(i, 11))
                DataMaintenance.myParamArray(1, 5) = CStr(DataGrid1.Item(i, 0))
                DataMaintenance.myParamArray(2, 5) = CStr(DataGrid1.Item(i, 6))
                DataMaintenance.ExecuteCommand(ServerPath2, "UpdateCustomerShipToMaster", CommandType.StoredProcedure, 3)
            End If
        Next
        Load_DataGrid1()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        DataMaintenance.myParamArray(0, 0) = "@CustomerName"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.VarChar
        DataMaintenance.myParamArray(0, 2) = 150
        DataMaintenance.myParamArray(0, 3) = ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "String"
        DataMaintenance.myParamArray(0, 5) = ""

        DataGrid2.DataSource = DataMaintenance.GetDataTable(ServerPath2, "MatchCustomer", CommandType.StoredProcedure, 1)

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            DataMaintenance.myParamArray(0, 0) = "@CustomerName"
            DataMaintenance.myParamArray(0, 1) = SqlDbType.VarChar
            DataMaintenance.myParamArray(0, 2) = 150
            DataMaintenance.myParamArray(0, 3) = ParameterDirection.Input
            DataMaintenance.myParamArray(0, 4) = "String"
            DataMaintenance.myParamArray(0, 5) = TextBox1.Text

            DataGrid2.DataSource = DataMaintenance.GetDataTable(ServerPath2, "MatchCustomer", CommandType.StoredProcedure, 1)
        End If
        

    End Sub
End Class
