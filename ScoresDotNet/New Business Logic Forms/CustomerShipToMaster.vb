Public Class CustomerShipToMaster
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DataGrid2 As System.Windows.Forms.DataGrid
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents txtOldMdiCustCode As System.Windows.Forms.TextBox
    Friend WithEvents txtMetroCode As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtTerritory As System.Windows.Forms.TextBox
    Friend WithEvents txtShipToCode As System.Windows.Forms.TextBox
    Friend WithEvents txtOldShipToCode As System.Windows.Forms.TextBox
    Friend WithEvents txtShipToName As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtShipAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtShipTerritory As System.Windows.Forms.TextBox
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
    Friend WithEvents DataGridTextBoxColumn16 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn17 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents txtTypeDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtCusTerritory As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtCustName As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtNmpcCustCode As System.Windows.Forms.TextBox
    Friend WithEvents txtIslandGroup As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn18 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn19 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn20 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn21 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn22 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn23 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn24 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TextBox6 = New System.Windows.Forms.TextBox
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
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn17 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.DataGrid2 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn18 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn19 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn20 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn21 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn22 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn23 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn24 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCustomerName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtOldMdiCustCode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtMetroCode = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtTerritory = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtShipAddress = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtShipToName = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtOldShipToCode = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtShipToCode = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtShipTerritory = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.txtTypeDesc = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtCusTerritory = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtAddress2 = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtAddress1 = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtCustName = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtNmpcCustCode = New System.Windows.Forms.TextBox
        Me.txtIslandGroup = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1352, 392)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(8, 16)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1336, 368)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TextBox6)
        Me.TabPage1.Controls.Add(Me.DataGrid1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1328, 342)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Master List"
        '
        'TextBox6
        '
        Me.TextBox6.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox6.Location = New System.Drawing.Point(8, 7)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(1312, 20)
        Me.TextBox6.TabIndex = 6
        Me.TextBox6.Text = "Your keywords + Enter here..."
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 33)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(1312, 302)
        Me.DataGrid1.TabIndex = 5
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn16, Me.DataGridTextBoxColumn17})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = ""
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Metro Code"
        Me.DataGridTextBoxColumn1.MappingName = "MetroCode"
        Me.DataGridTextBoxColumn1.Width = 85
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.MappingName = "OldMdiCustCode"
        Me.DataGridTextBoxColumn2.Width = 0
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Customer Name"
        Me.DataGridTextBoxColumn3.MappingName = "CustomerName"
        Me.DataGridTextBoxColumn3.Width = 145
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Address"
        Me.DataGridTextBoxColumn4.MappingName = "Address"
        Me.DataGridTextBoxColumn4.Width = 195
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Territory"
        Me.DataGridTextBoxColumn5.MappingName = "Territory"
        Me.DataGridTextBoxColumn5.Width = 150
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "ShipTo Code"
        Me.DataGridTextBoxColumn6.MappingName = "ShipToCode"
        Me.DataGridTextBoxColumn6.Width = 85
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.MappingName = "OldShiptoCode"
        Me.DataGridTextBoxColumn7.Width = 0
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "ShipTo Name"
        Me.DataGridTextBoxColumn8.MappingName = "ShipToName"
        Me.DataGridTextBoxColumn8.Width = 145
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "ShipTo Address"
        Me.DataGridTextBoxColumn9.MappingName = "ShipAddress"
        Me.DataGridTextBoxColumn9.Width = 195
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "ShipTo Territory"
        Me.DataGridTextBoxColumn10.MappingName = "ShipTerritory"
        Me.DataGridTextBoxColumn10.Width = 150
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "NMPC CustCode"
        Me.DataGridTextBoxColumn11.MappingName = "NMPCCustCode"
        Me.DataGridTextBoxColumn11.Width = 107
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.MappingName = "CustName"
        Me.DataGridTextBoxColumn12.Width = 0
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.MappingName = "Address1"
        Me.DataGridTextBoxColumn13.Width = 0
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.MappingName = "Address2"
        Me.DataGridTextBoxColumn14.Width = 0
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.MappingName = "CusTerritory"
        Me.DataGridTextBoxColumn15.Width = 0
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Format = ""
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.MappingName = "IslandGroup"
        Me.DataGridTextBoxColumn16.Width = 0
        '
        'DataGridTextBoxColumn17
        '
        Me.DataGridTextBoxColumn17.Format = ""
        Me.DataGridTextBoxColumn17.FormatInfo = Nothing
        Me.DataGridTextBoxColumn17.MappingName = "TypeDesc"
        Me.DataGridTextBoxColumn17.Width = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TextBox4)
        Me.TabPage2.Controls.Add(Me.DataGrid2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(1328, 342)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Customer Search"
        '
        'TextBox4
        '
        Me.TextBox4.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox4.Location = New System.Drawing.Point(8, 8)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(1312, 20)
        Me.TextBox4.TabIndex = 3
        Me.TextBox4.Text = "Your keywords + Enter here..."
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DataGrid2
        '
        Me.DataGrid2.DataMember = ""
        Me.DataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid2.Location = New System.Drawing.Point(8, 34)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.Size = New System.Drawing.Size(1312, 302)
        Me.DataGrid2.TabIndex = 2
        Me.DataGrid2.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.DataGrid2
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn18, Me.DataGridTextBoxColumn19, Me.DataGridTextBoxColumn20, Me.DataGridTextBoxColumn21, Me.DataGridTextBoxColumn22, Me.DataGridTextBoxColumn23, Me.DataGridTextBoxColumn24})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = ""
        '
        'DataGridTextBoxColumn18
        '
        Me.DataGridTextBoxColumn18.Format = ""
        Me.DataGridTextBoxColumn18.FormatInfo = Nothing
        Me.DataGridTextBoxColumn18.MappingName = "Rowid"
        Me.DataGridTextBoxColumn18.Width = 0
        '
        'DataGridTextBoxColumn19
        '
        Me.DataGridTextBoxColumn19.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn19.Format = ""
        Me.DataGridTextBoxColumn19.FormatInfo = Nothing
        Me.DataGridTextBoxColumn19.HeaderText = "Customer Code"
        Me.DataGridTextBoxColumn19.MappingName = "CustCode"
        Me.DataGridTextBoxColumn19.Width = 116
        '
        'DataGridTextBoxColumn20
        '
        Me.DataGridTextBoxColumn20.Format = ""
        Me.DataGridTextBoxColumn20.FormatInfo = Nothing
        Me.DataGridTextBoxColumn20.HeaderText = "Customer Name"
        Me.DataGridTextBoxColumn20.MappingName = "CustName"
        Me.DataGridTextBoxColumn20.Width = 270
        '
        'DataGridTextBoxColumn21
        '
        Me.DataGridTextBoxColumn21.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn21.Format = ""
        Me.DataGridTextBoxColumn21.FormatInfo = Nothing
        Me.DataGridTextBoxColumn21.HeaderText = "Customer Type"
        Me.DataGridTextBoxColumn21.MappingName = "Type"
        Me.DataGridTextBoxColumn21.Width = 160
        '
        'DataGridTextBoxColumn22
        '
        Me.DataGridTextBoxColumn22.Format = ""
        Me.DataGridTextBoxColumn22.FormatInfo = Nothing
        Me.DataGridTextBoxColumn22.HeaderText = "Address 1"
        Me.DataGridTextBoxColumn22.MappingName = "Address1"
        Me.DataGridTextBoxColumn22.Width = 270
        '
        'DataGridTextBoxColumn23
        '
        Me.DataGridTextBoxColumn23.Format = ""
        Me.DataGridTextBoxColumn23.FormatInfo = Nothing
        Me.DataGridTextBoxColumn23.HeaderText = "Address 2"
        Me.DataGridTextBoxColumn23.MappingName = "Address2"
        Me.DataGridTextBoxColumn23.Width = 270
        '
        'DataGridTextBoxColumn24
        '
        Me.DataGridTextBoxColumn24.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn24.Format = ""
        Me.DataGridTextBoxColumn24.FormatInfo = Nothing
        Me.DataGridTextBoxColumn24.HeaderText = "Territory"
        Me.DataGridTextBoxColumn24.MappingName = "Territory"
        Me.DataGridTextBoxColumn24.Width = 170
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtAddress)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtCustomerName)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtOldMdiCustCode)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtMetroCode)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtTerritory)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(552, 416)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(400, 200)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Metro Customer"
        '
        'txtAddress
        '
        Me.txtAddress.AutoSize = False
        Me.txtAddress.BackColor = System.Drawing.Color.SkyBlue
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(136, 96)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(256, 40)
        Me.txtAddress.TabIndex = 11
        Me.txtAddress.Text = ""
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SkyBlue
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(8, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Address"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCustomerName
        '
        Me.txtCustomerName.AutoSize = False
        Me.txtCustomerName.BackColor = System.Drawing.Color.SkyBlue
        Me.txtCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(136, 72)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(256, 20)
        Me.txtCustomerName.TabIndex = 9
        Me.txtCustomerName.Text = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SkyBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(8, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Customer Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOldMdiCustCode
        '
        Me.txtOldMdiCustCode.AutoSize = False
        Me.txtOldMdiCustCode.BackColor = System.Drawing.Color.SkyBlue
        Me.txtOldMdiCustCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldMdiCustCode.Location = New System.Drawing.Point(136, 48)
        Me.txtOldMdiCustCode.Name = "txtOldMdiCustCode"
        Me.txtOldMdiCustCode.Size = New System.Drawing.Size(256, 20)
        Me.txtOldMdiCustCode.TabIndex = 7
        Me.txtOldMdiCustCode.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SkyBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(8, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Old MDI CustCode"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMetroCode
        '
        Me.txtMetroCode.AutoSize = False
        Me.txtMetroCode.BackColor = System.Drawing.Color.SkyBlue
        Me.txtMetroCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMetroCode.Location = New System.Drawing.Point(136, 24)
        Me.txtMetroCode.Name = "txtMetroCode"
        Me.txtMetroCode.Size = New System.Drawing.Size(256, 20)
        Me.txtMetroCode.TabIndex = 5
        Me.txtMetroCode.Text = ""
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SkyBlue
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(8, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Metro Code"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTerritory
        '
        Me.txtTerritory.AutoSize = False
        Me.txtTerritory.BackColor = System.Drawing.Color.SkyBlue
        Me.txtTerritory.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTerritory.Location = New System.Drawing.Point(136, 140)
        Me.txtTerritory.Name = "txtTerritory"
        Me.txtTerritory.Size = New System.Drawing.Size(256, 40)
        Me.txtTerritory.TabIndex = 13
        Me.txtTerritory.Text = ""
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.SkyBlue
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Location = New System.Drawing.Point(8, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Territory"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtShipAddress)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtShipToName)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtOldShipToCode)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtShipToCode)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtShipTerritory)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Location = New System.Drawing.Point(960, 416)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(400, 200)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Shipping"
        '
        'txtShipAddress
        '
        Me.txtShipAddress.AutoSize = False
        Me.txtShipAddress.BackColor = System.Drawing.Color.SkyBlue
        Me.txtShipAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShipAddress.Location = New System.Drawing.Point(136, 96)
        Me.txtShipAddress.Name = "txtShipAddress"
        Me.txtShipAddress.Size = New System.Drawing.Size(256, 40)
        Me.txtShipAddress.TabIndex = 11
        Me.txtShipAddress.Text = ""
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.SkyBlue
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label10.Location = New System.Drawing.Point(8, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 20)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Address"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShipToName
        '
        Me.txtShipToName.AutoSize = False
        Me.txtShipToName.BackColor = System.Drawing.Color.SkyBlue
        Me.txtShipToName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShipToName.Location = New System.Drawing.Point(136, 72)
        Me.txtShipToName.Name = "txtShipToName"
        Me.txtShipToName.Size = New System.Drawing.Size(256, 20)
        Me.txtShipToName.TabIndex = 9
        Me.txtShipToName.Text = ""
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.SkyBlue
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label11.Location = New System.Drawing.Point(8, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 20)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Ship To Name"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOldShipToCode
        '
        Me.txtOldShipToCode.AutoSize = False
        Me.txtOldShipToCode.BackColor = System.Drawing.Color.SkyBlue
        Me.txtOldShipToCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldShipToCode.Location = New System.Drawing.Point(136, 48)
        Me.txtOldShipToCode.Name = "txtOldShipToCode"
        Me.txtOldShipToCode.Size = New System.Drawing.Size(256, 20)
        Me.txtOldShipToCode.TabIndex = 7
        Me.txtOldShipToCode.Text = ""
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.SkyBlue
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label12.Location = New System.Drawing.Point(8, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 20)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Old Ship To Code"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShipToCode
        '
        Me.txtShipToCode.AutoSize = False
        Me.txtShipToCode.BackColor = System.Drawing.Color.SkyBlue
        Me.txtShipToCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShipToCode.Location = New System.Drawing.Point(136, 24)
        Me.txtShipToCode.Name = "txtShipToCode"
        Me.txtShipToCode.Size = New System.Drawing.Size(256, 20)
        Me.txtShipToCode.TabIndex = 5
        Me.txtShipToCode.Text = ""
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.SkyBlue
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label13.Location = New System.Drawing.Point(8, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 20)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Ship To Code"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShipTerritory
        '
        Me.txtShipTerritory.AutoSize = False
        Me.txtShipTerritory.BackColor = System.Drawing.Color.SkyBlue
        Me.txtShipTerritory.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShipTerritory.Location = New System.Drawing.Point(136, 140)
        Me.txtShipTerritory.Name = "txtShipTerritory"
        Me.txtShipTerritory.Size = New System.Drawing.Size(256, 40)
        Me.txtShipTerritory.TabIndex = 13
        Me.txtShipTerritory.Text = ""
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.SkyBlue
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label14.Location = New System.Drawing.Point(8, 140)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(120, 20)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Territory"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnExit)
        Me.GroupBox5.Controls.Add(Me.btnClear)
        Me.GroupBox5.Controls.Add(Me.btnUpdate)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 416)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(128, 200)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Function"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(8, 120)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(112, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit Form"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(8, 88)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(112, 23)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(8, 56)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(112, 23)
        Me.btnUpdate.TabIndex = 0
        Me.btnUpdate.Text = "Update"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LinkLabel1)
        Me.GroupBox4.Controls.Add(Me.txtTypeDesc)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.txtCusTerritory)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.txtAddress2)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.txtAddress1)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.txtCustName)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.txtNmpcCustCode)
        Me.GroupBox4.Controls.Add(Me.txtIslandGroup)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Location = New System.Drawing.Point(144, 416)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(400, 200)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "NMPC Customer"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.BackColor = System.Drawing.Color.SkyBlue
        Me.LinkLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LinkLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LinkLabel1.Location = New System.Drawing.Point(8, 24)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(120, 20)
        Me.LinkLabel1.TabIndex = 16
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Customer Code"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTypeDesc
        '
        Me.txtTypeDesc.AutoSize = False
        Me.txtTypeDesc.BackColor = System.Drawing.Color.SkyBlue
        Me.txtTypeDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTypeDesc.Location = New System.Drawing.Point(136, 168)
        Me.txtTypeDesc.Name = "txtTypeDesc"
        Me.txtTypeDesc.ReadOnly = True
        Me.txtTypeDesc.Size = New System.Drawing.Size(256, 20)
        Me.txtTypeDesc.TabIndex = 15
        Me.txtTypeDesc.Text = ""
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.SkyBlue
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label15.Location = New System.Drawing.Point(8, 168)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(120, 20)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Type"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCusTerritory
        '
        Me.txtCusTerritory.AutoSize = False
        Me.txtCusTerritory.BackColor = System.Drawing.Color.SkyBlue
        Me.txtCusTerritory.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusTerritory.Location = New System.Drawing.Point(136, 120)
        Me.txtCusTerritory.Name = "txtCusTerritory"
        Me.txtCusTerritory.ReadOnly = True
        Me.txtCusTerritory.Size = New System.Drawing.Size(256, 20)
        Me.txtCusTerritory.TabIndex = 13
        Me.txtCusTerritory.Text = ""
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.SkyBlue
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label16.Location = New System.Drawing.Point(8, 120)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(120, 20)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "Territory"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAddress2
        '
        Me.txtAddress2.AutoSize = False
        Me.txtAddress2.BackColor = System.Drawing.Color.SkyBlue
        Me.txtAddress2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress2.Location = New System.Drawing.Point(136, 96)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.ReadOnly = True
        Me.txtAddress2.Size = New System.Drawing.Size(256, 20)
        Me.txtAddress2.TabIndex = 11
        Me.txtAddress2.Text = ""
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SkyBlue
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label17.Location = New System.Drawing.Point(8, 96)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(120, 20)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "Address2"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAddress1
        '
        Me.txtAddress1.AutoSize = False
        Me.txtAddress1.BackColor = System.Drawing.Color.SkyBlue
        Me.txtAddress1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress1.Location = New System.Drawing.Point(136, 72)
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.ReadOnly = True
        Me.txtAddress1.Size = New System.Drawing.Size(256, 20)
        Me.txtAddress1.TabIndex = 9
        Me.txtAddress1.Text = ""
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.SkyBlue
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label18.Location = New System.Drawing.Point(8, 72)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(120, 20)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Address1"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCustName
        '
        Me.txtCustName.AutoSize = False
        Me.txtCustName.BackColor = System.Drawing.Color.SkyBlue
        Me.txtCustName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustName.Location = New System.Drawing.Point(136, 48)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.ReadOnly = True
        Me.txtCustName.Size = New System.Drawing.Size(256, 20)
        Me.txtCustName.TabIndex = 7
        Me.txtCustName.Text = ""
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.SkyBlue
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label19.Location = New System.Drawing.Point(8, 48)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(120, 20)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "Customer Name"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNmpcCustCode
        '
        Me.txtNmpcCustCode.AutoSize = False
        Me.txtNmpcCustCode.BackColor = System.Drawing.Color.SkyBlue
        Me.txtNmpcCustCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNmpcCustCode.Location = New System.Drawing.Point(136, 24)
        Me.txtNmpcCustCode.Name = "txtNmpcCustCode"
        Me.txtNmpcCustCode.ReadOnly = True
        Me.txtNmpcCustCode.Size = New System.Drawing.Size(256, 20)
        Me.txtNmpcCustCode.TabIndex = 5
        Me.txtNmpcCustCode.Text = ""
        '
        'txtIslandGroup
        '
        Me.txtIslandGroup.AutoSize = False
        Me.txtIslandGroup.BackColor = System.Drawing.Color.SkyBlue
        Me.txtIslandGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIslandGroup.Location = New System.Drawing.Point(136, 144)
        Me.txtIslandGroup.Name = "txtIslandGroup"
        Me.txtIslandGroup.ReadOnly = True
        Me.txtIslandGroup.Size = New System.Drawing.Size(256, 20)
        Me.txtIslandGroup.TabIndex = 13
        Me.txtIslandGroup.Text = ""
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.SkyBlue
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label21.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label21.Location = New System.Drawing.Point(8, 144)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(120, 20)
        Me.Label21.TabIndex = 12
        Me.Label21.Text = "Island"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CustomerShipToMaster
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1366, 629)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CustomerShipToMaster"
        Me.Text = "Customer - Ship To Master List"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub Load_DataGrid1()

        DataMaintenance.myParamArray(0, 0) = "@CustomerName"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.VarChar
        DataMaintenance.myParamArray(0, 2) = 150
        DataMaintenance.myParamArray(0, 3) = ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "String"
        DataMaintenance.myParamArray(0, 5) = ""
        DataGrid1.DataSource = DataMaintenance.GetDataTable(ServerPath2, "CustomerShipToMaster_Filter", _
        CommandType.StoredProcedure, 1)
        DataGrid1.CaptionText = CType(DataGrid1.DataSource, DataTable).Rows.Count.ToString() & " Record(s)"

    End Sub

    Private Sub CustomerShipToMaster_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Load_DataGrid1()

    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            DataMaintenance.myParamArray(0, 0) = "@CustomerName"
            DataMaintenance.myParamArray(0, 1) = SqlDbType.VarChar
            DataMaintenance.myParamArray(0, 2) = 150
            DataMaintenance.myParamArray(0, 3) = ParameterDirection.Input
            DataMaintenance.myParamArray(0, 4) = "String"
            DataMaintenance.myParamArray(0, 5) = TextBox6.Text

            DataGrid1.DataSource = DataMaintenance.GetDataTable(ServerPath2, "CustomerShipToMaster_Filter", _
            CommandType.StoredProcedure, 1)
        End If

    End Sub

    Private Sub Populate_Fields()

        ClearFields()
        Try
            With DataGrid1
                txtMetroCode.Text = CStr(.Item(.CurrentCell.RowNumber, 0))
                txtOldMdiCustCode.Text = CStr(.Item(.CurrentCell.RowNumber, 1))
                txtCustomerName.Text = CStr(.Item(.CurrentCell.RowNumber, 2))
                txtAddress.Text = CStr(.Item(.CurrentCell.RowNumber, 3))
                txtTerritory.Text = CStr(.Item(.CurrentCell.RowNumber, 4))
                txtShipToCode.Text = CStr(.Item(.CurrentCell.RowNumber, 5))
                txtOldShipToCode.Text = CStr(.Item(.CurrentCell.RowNumber, 6))
                txtShipToName.Text = CStr(.Item(.CurrentCell.RowNumber, 7))
                txtShipAddress.Text = CStr(.Item(.CurrentCell.RowNumber, 8))
                txtShipTerritory.Text = CStr(.Item(.CurrentCell.RowNumber, 9))
                txtNmpcCustCode.Text = CStr(.Item(.CurrentCell.RowNumber, 10))
                txtCustName.Text = CStr(.Item(.CurrentCell.RowNumber, 11))
                txtAddress1.Text = CStr(.Item(.CurrentCell.RowNumber, 12))
                txtAddress2.Text = CStr(.Item(.CurrentCell.RowNumber, 13))
                txtCusTerritory.Text = CStr(.Item(.CurrentCell.RowNumber, 14))
                txtIslandGroup.Text = CStr(.Item(.CurrentCell.RowNumber, 15))
                txtTypeDesc.Text = CStr(.Item(.CurrentCell.RowNumber, 16))
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try


    End Sub

    Private Sub DataGrid1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.CurrentCellChanged

        DataGrid1.Select(DataGrid1.CurrentCell.RowNumber)
        If TextBox4.Text = "Your keywords + Enter here..." Or TextBox4.Text = "" Then
            Load_DataGrid2(CStr(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 2)))
        End If
        Populate_Fields()

    End Sub

    Private Sub Load_DataGrid2(ByVal CustomerName As String)

        DataMaintenance.myParamArray(0, 0) = "@CustomerName"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.VarChar
        DataMaintenance.myParamArray(0, 2) = 150
        DataMaintenance.myParamArray(0, 3) = ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "String"
        DataMaintenance.myParamArray(0, 5) = CustomerName

        DataGrid2.DataSource = DataMaintenance.GetDataTable(ServerPath2, "MatchCustomer", CommandType.StoredProcedure, 1)
        DataGrid2.CaptionText = CType(DataGrid2.DataSource, DataTable).Rows.Count.ToString() & " Record(s)"

    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Load_DataGrid2(TextBox4.Text)
        End If

    End Sub

    Private Sub ClearFields()
        txtMetroCode.Text = ""
        txtOldMdiCustCode.Text = ""
        txtCustomerName.Text = ""
        txtAddress.Text = ""
        txtTerritory.Text = ""
        txtShipToCode.Text = ""
        txtOldShipToCode.Text = ""
        txtShipToName.Text = ""
        txtShipAddress.Text = ""
        txtShipTerritory.Text = ""
        txtNmpcCustCode.Text = ""
        txtCustName.Text = ""
        txtAddress1.Text = ""
        txtAddress2.Text = ""
        txtCusTerritory.Text = ""
        txtIslandGroup.Text = ""
        txtTypeDesc.Text = ""
    End Sub

    Private Sub TextBox6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox6.Click, TextBox4.Click

        Dim thisTextBox As TextBox
        thisTextBox = CType(sender, TextBox)
        thisTextBox.SelectAll()
        thisTextBox.ForeColor = Color.Black

    End Sub

    Private Sub SetupParameters(ByVal x As Integer, ByVal ParameterName As String, _
    ByVal ParameterType As SqlDbType, ByVal ParameterLength As Integer, ByVal DataType As String, ByVal ParameterValue As String)

        DataMaintenance.myParamArray(x, 0) = ParameterName
        DataMaintenance.myParamArray(x, 1) = ParameterType
        DataMaintenance.myParamArray(x, 2) = ParameterLength
        DataMaintenance.myParamArray(x, 3) = ParameterDirection.Input
        DataMaintenance.myParamArray(x, 4) = DataType
        DataMaintenance.myParamArray(x, 5) = ParameterValue

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        Try
            SetupParameters(0, "@MetroCode", SqlDbType.VarChar, 10, "String", txtMetroCode.Text)
            SetupParameters(1, "@OldMdiCustCode", SqlDbType.VarChar, 10, "String", txtOldMdiCustCode.Text)
            SetupParameters(2, "@CustomerName", SqlDbType.VarChar, 80, "String", txtCustomerName.Text)
            SetupParameters(3, "@Address", SqlDbType.VarChar, 150, "String", txtAddress.Text)
            SetupParameters(4, "@Territory", SqlDbType.VarChar, 150, "String", txtTerritory.Text)
            SetupParameters(5, "@ShipToCode", SqlDbType.VarChar, 10, "String", txtShipToCode.Text)
            SetupParameters(6, "@OldShipToCode", SqlDbType.VarChar, 10, "String", txtOldShipToCode.Text)
            SetupParameters(7, "@ShipToName", SqlDbType.VarChar, 80, "String", txtShipToName.Text)
            SetupParameters(8, "@ShipAddress", SqlDbType.VarChar, 150, "String", txtShipAddress.Text)
            SetupParameters(9, "@ShipTerritory", SqlDbType.VarChar, 150, "String", txtShipTerritory.Text)
            SetupParameters(10, "@CustomerCode", SqlDbType.VarChar, 10, "String", txtNmpcCustCode.Text)

            If DataMaintenance.ExecuteCommand(ServerPath2, "CustomerShipToMaster_Update", CommandType.StoredProcedure, 11) = True Then
                MessageBox.Show("Record saved successfully!", "Customer-ShipTo Master", MessageBoxButtons.OK, _
                MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Customer-ShipTo Master", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub LinkLabel1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkLabel1.Click

        Dim thisForm As New CustomerCT
        thisForm.ShowDialog(Me)

        If UserHasValidSelection(thisForm.DataGrid1) Then
            With thisForm
                txtNmpcCustCode.Text = CStr(.DataGrid1.Item(.DataGrid1.CurrentRowIndex, 1))
            End With
        End If

    End Sub

    Private Function UserHasValidSelection(ByVal thisDataGrid As DataGrid) As Boolean
        Dim GridItemSelected As Boolean = False
        Try
            With thisDataGrid
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

    Private Sub DataGrid2_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid2.CurrentCellChanged

        DataGrid2.Select(DataGrid2.CurrentCell.RowNumber)
        'Populate NMPC Customer text fields
        With DataGrid2
            txtNmpcCustCode.Text = ""
            txtCustName.Text = ""
            txtAddress1.Text = ""
            txtAddress2.Text = ""
            txtCusTerritory.Text = ""
            txtIslandGroup.Text = ""
            txtTypeDesc.Text = ""

            txtNmpcCustCode.Text = CStr(.Item(.CurrentRowIndex, 1))
            txtCustName.Text = CStr(.Item(.CurrentRowIndex, 2))
            txtAddress1.Text = CStr(.Item(.CurrentRowIndex, 4))
            txtAddress2.Text = CStr(.Item(.CurrentRowIndex, 5))
            txtCusTerritory.Text = CStr(.Item(.CurrentRowIndex, 6))
            txtIslandGroup.Text = ""
            txtTypeDesc.Text = ""
        End With
        

    End Sub
End Class
