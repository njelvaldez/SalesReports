<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditDataMapping
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCustomerCode = New System.Windows.Forms.TextBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSearchCustomer = New System.Windows.Forms.Button()
        Me.btnMapCustomer = New System.Windows.Forms.Button()
        Me.gbCustomer = New System.Windows.Forms.GroupBox()
        Me.btnUpdateMapCust = New System.Windows.Forms.Button()
        Me.txtShipTo = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtShipAdd2 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtShipAdd1 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAddress2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAddress1 = New System.Windows.Forms.TextBox()
        Me.Address1 = New System.Windows.Forms.Label()
        Me.txtCustomerNameMap2 = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.dgvCustomer = New System.Windows.Forms.DataGridView()
        Me.txtCustomerCodeMap = New System.Windows.Forms.TextBox()
        Me.txtCustomerNameMap = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gbItem = New System.Windows.Forms.GroupBox()
        Me.btnUpdateMapItem = New System.Windows.Forms.Button()
        Me.txtUnitPrice = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtItemNameMap2 = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.dgvItem = New System.Windows.Forms.DataGridView()
        Me.txtItemCodeMap = New System.Windows.Forms.TextBox()
        Me.txtItemNameMap = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtItemCode = New System.Windows.Forms.TextBox()
        Me.btnMapItem = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSearchItem = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCustomerAddressMap = New System.Windows.Forms.TextBox()
        Me.gbCustomer.SuspendLayout()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbItem.SuspendLayout()
        CType(Me.dgvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Code"
        '
        'txtCustomerCode
        '
        Me.txtCustomerCode.Enabled = False
        Me.txtCustomerCode.Location = New System.Drawing.Point(95, 13)
        Me.txtCustomerCode.Name = "txtCustomerCode"
        Me.txtCustomerCode.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerCode.TabIndex = 1
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Enabled = False
        Me.txtCustomerName.Location = New System.Drawing.Point(94, 35)
        Me.txtCustomerName.Multiline = True
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(265, 50)
        Me.txtCustomerName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Customer Name"
        '
        'btnSearchCustomer
        '
        Me.btnSearchCustomer.Location = New System.Drawing.Point(1053, 10)
        Me.btnSearchCustomer.Name = "btnSearchCustomer"
        Me.btnSearchCustomer.Size = New System.Drawing.Size(75, 47)
        Me.btnSearchCustomer.TabIndex = 8
        Me.btnSearchCustomer.Text = "&Search"
        Me.btnSearchCustomer.UseVisualStyleBackColor = True
        '
        'btnMapCustomer
        '
        Me.btnMapCustomer.Location = New System.Drawing.Point(1134, 11)
        Me.btnMapCustomer.Name = "btnMapCustomer"
        Me.btnMapCustomer.Size = New System.Drawing.Size(75, 46)
        Me.btnMapCustomer.TabIndex = 9
        Me.btnMapCustomer.Text = "&Map"
        Me.btnMapCustomer.UseVisualStyleBackColor = True
        '
        'gbCustomer
        '
        Me.gbCustomer.Controls.Add(Me.Label16)
        Me.gbCustomer.Controls.Add(Me.txtCustomerAddressMap)
        Me.gbCustomer.Controls.Add(Me.btnUpdateMapCust)
        Me.gbCustomer.Controls.Add(Me.txtShipTo)
        Me.gbCustomer.Controls.Add(Me.Label15)
        Me.gbCustomer.Controls.Add(Me.txtShipAdd2)
        Me.gbCustomer.Controls.Add(Me.Label14)
        Me.gbCustomer.Controls.Add(Me.txtShipAdd1)
        Me.gbCustomer.Controls.Add(Me.Label13)
        Me.gbCustomer.Controls.Add(Me.Label12)
        Me.gbCustomer.Controls.Add(Me.txtAddress2)
        Me.gbCustomer.Controls.Add(Me.Label9)
        Me.gbCustomer.Controls.Add(Me.txtAddress1)
        Me.gbCustomer.Controls.Add(Me.Address1)
        Me.gbCustomer.Controls.Add(Me.txtCustomerNameMap2)
        Me.gbCustomer.Controls.Add(Me.btnCancel)
        Me.gbCustomer.Controls.Add(Me.dgvCustomer)
        Me.gbCustomer.Controls.Add(Me.txtCustomerCodeMap)
        Me.gbCustomer.Controls.Add(Me.txtCustomerNameMap)
        Me.gbCustomer.Controls.Add(Me.Label3)
        Me.gbCustomer.Controls.Add(Me.Label4)
        Me.gbCustomer.Controls.Add(Me.txtCustomerCode)
        Me.gbCustomer.Controls.Add(Me.btnMapCustomer)
        Me.gbCustomer.Controls.Add(Me.Label1)
        Me.gbCustomer.Controls.Add(Me.btnSearchCustomer)
        Me.gbCustomer.Controls.Add(Me.Label2)
        Me.gbCustomer.Controls.Add(Me.txtCustomerName)
        Me.gbCustomer.Location = New System.Drawing.Point(12, 12)
        Me.gbCustomer.Name = "gbCustomer"
        Me.gbCustomer.Size = New System.Drawing.Size(1309, 330)
        Me.gbCustomer.TabIndex = 10
        Me.gbCustomer.TabStop = False
        Me.gbCustomer.Text = "Customer"
        '
        'btnUpdateMapCust
        '
        Me.btnUpdateMapCust.Location = New System.Drawing.Point(1215, 11)
        Me.btnUpdateMapCust.Name = "btnUpdateMapCust"
        Me.btnUpdateMapCust.Size = New System.Drawing.Size(75, 46)
        Me.btnUpdateMapCust.TabIndex = 27
        Me.btnUpdateMapCust.Text = "&Update Map"
        Me.btnUpdateMapCust.UseVisualStyleBackColor = True
        '
        'txtShipTo
        '
        Me.txtShipTo.Enabled = False
        Me.txtShipTo.Location = New System.Drawing.Point(441, 37)
        Me.txtShipTo.Name = "txtShipTo"
        Me.txtShipTo.Size = New System.Drawing.Size(320, 20)
        Me.txtShipTo.TabIndex = 26
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(375, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 13)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "ShipTo"
        '
        'txtShipAdd2
        '
        Me.txtShipAdd2.Enabled = False
        Me.txtShipAdd2.Location = New System.Drawing.Point(441, 86)
        Me.txtShipAdd2.Name = "txtShipAdd2"
        Me.txtShipAdd2.Size = New System.Drawing.Size(320, 20)
        Me.txtShipAdd2.TabIndex = 24
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(375, 89)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 13)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "ShipAdd2"
        '
        'txtShipAdd1
        '
        Me.txtShipAdd1.Enabled = False
        Me.txtShipAdd1.Location = New System.Drawing.Point(441, 62)
        Me.txtShipAdd1.Name = "txtShipAdd1"
        Me.txtShipAdd1.Size = New System.Drawing.Size(320, 20)
        Me.txtShipAdd1.TabIndex = 22
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(375, 65)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "ShipAdd1"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(767, 68)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Customer Name2"
        '
        'txtAddress2
        '
        Me.txtAddress2.Enabled = False
        Me.txtAddress2.Location = New System.Drawing.Point(441, 13)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(320, 20)
        Me.txtAddress2.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(375, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Address2"
        '
        'txtAddress1
        '
        Me.txtAddress1.Enabled = False
        Me.txtAddress1.Location = New System.Drawing.Point(94, 86)
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(265, 20)
        Me.txtAddress1.TabIndex = 17
        '
        'Address1
        '
        Me.Address1.AutoSize = True
        Me.Address1.Location = New System.Drawing.Point(6, 95)
        Me.Address1.Name = "Address1"
        Me.Address1.Size = New System.Drawing.Size(51, 13)
        Me.Address1.TabIndex = 16
        Me.Address1.Text = "Address1"
        '
        'txtCustomerNameMap2
        '
        Me.txtCustomerNameMap2.Location = New System.Drawing.Point(868, 65)
        Me.txtCustomerNameMap2.Name = "txtCustomerNameMap2"
        Me.txtCustomerNameMap2.Size = New System.Drawing.Size(176, 20)
        Me.txtCustomerNameMap2.TabIndex = 15
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.ScoresDotNet.My.Resources.Resources.door_out_icon
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(1215, 61)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 45)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "    &Close"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'dgvCustomer
        '
        Me.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomer.Location = New System.Drawing.Point(9, 126)
        Me.dgvCustomer.Name = "dgvCustomer"
        Me.dgvCustomer.Size = New System.Drawing.Size(1281, 189)
        Me.dgvCustomer.TabIndex = 11
        '
        'txtCustomerCodeMap
        '
        Me.txtCustomerCodeMap.Location = New System.Drawing.Point(868, 12)
        Me.txtCustomerCodeMap.Name = "txtCustomerCodeMap"
        Me.txtCustomerCodeMap.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerCodeMap.TabIndex = 11
        '
        'txtCustomerNameMap
        '
        Me.txtCustomerNameMap.Location = New System.Drawing.Point(868, 39)
        Me.txtCustomerNameMap.Name = "txtCustomerNameMap"
        Me.txtCustomerNameMap.Size = New System.Drawing.Size(176, 20)
        Me.txtCustomerNameMap.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(767, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Customer Code"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(767, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Customer Name1"
        '
        'gbItem
        '
        Me.gbItem.Controls.Add(Me.btnUpdateMapItem)
        Me.gbItem.Controls.Add(Me.txtUnitPrice)
        Me.gbItem.Controls.Add(Me.Label11)
        Me.gbItem.Controls.Add(Me.txtUnit)
        Me.gbItem.Controls.Add(Me.Label10)
        Me.gbItem.Controls.Add(Me.txtItemNameMap2)
        Me.gbItem.Controls.Add(Me.btnClose)
        Me.gbItem.Controls.Add(Me.dgvItem)
        Me.gbItem.Controls.Add(Me.txtItemCodeMap)
        Me.gbItem.Controls.Add(Me.txtItemNameMap)
        Me.gbItem.Controls.Add(Me.Label5)
        Me.gbItem.Controls.Add(Me.Label6)
        Me.gbItem.Controls.Add(Me.txtItemCode)
        Me.gbItem.Controls.Add(Me.btnMapItem)
        Me.gbItem.Controls.Add(Me.Label7)
        Me.gbItem.Controls.Add(Me.btnSearchItem)
        Me.gbItem.Controls.Add(Me.Label8)
        Me.gbItem.Controls.Add(Me.txtItemName)
        Me.gbItem.Location = New System.Drawing.Point(12, 348)
        Me.gbItem.Name = "gbItem"
        Me.gbItem.Size = New System.Drawing.Size(1309, 288)
        Me.gbItem.TabIndex = 14
        Me.gbItem.TabStop = False
        Me.gbItem.Text = "Item"
        '
        'btnUpdateMapItem
        '
        Me.btnUpdateMapItem.Location = New System.Drawing.Point(1215, 12)
        Me.btnUpdateMapItem.Name = "btnUpdateMapItem"
        Me.btnUpdateMapItem.Size = New System.Drawing.Size(75, 46)
        Me.btnUpdateMapItem.TabIndex = 21
        Me.btnUpdateMapItem.Text = "&Update Map"
        Me.btnUpdateMapItem.UseVisualStyleBackColor = True
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Enabled = False
        Me.txtUnitPrice.Location = New System.Drawing.Point(668, 74)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtUnitPrice.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(580, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Unit Price"
        '
        'txtUnit
        '
        Me.txtUnit.Enabled = False
        Me.txtUnit.Location = New System.Drawing.Point(98, 70)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(100, 20)
        Me.txtUnit.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 77)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Unit"
        '
        'txtItemNameMap2
        '
        Me.txtItemNameMap2.Location = New System.Drawing.Point(850, 47)
        Me.txtItemNameMap2.Name = "txtItemNameMap2"
        Me.txtItemNameMap2.Size = New System.Drawing.Size(176, 20)
        Me.txtItemNameMap2.TabIndex = 16
        '
        'btnClose
        '
        Me.btnClose.Image = Global.ScoresDotNet.My.Resources.Resources.door_out_icon
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(1215, 57)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 45)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "    &Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'dgvItem
        '
        Me.dgvItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItem.Location = New System.Drawing.Point(12, 108)
        Me.dgvItem.Name = "dgvItem"
        Me.dgvItem.Size = New System.Drawing.Size(1281, 170)
        Me.dgvItem.TabIndex = 11
        '
        'txtItemCodeMap
        '
        Me.txtItemCodeMap.Location = New System.Drawing.Point(669, 21)
        Me.txtItemCodeMap.Name = "txtItemCodeMap"
        Me.txtItemCodeMap.Size = New System.Drawing.Size(100, 20)
        Me.txtItemCodeMap.TabIndex = 11
        '
        'txtItemNameMap
        '
        Me.txtItemNameMap.Location = New System.Drawing.Point(668, 47)
        Me.txtItemNameMap.Name = "txtItemNameMap"
        Me.txtItemNameMap.Size = New System.Drawing.Size(176, 20)
        Me.txtItemNameMap.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(580, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Item Code"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(580, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Item Name"
        '
        'txtItemCode
        '
        Me.txtItemCode.Enabled = False
        Me.txtItemCode.Location = New System.Drawing.Point(98, 20)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(100, 20)
        Me.txtItemCode.TabIndex = 1
        '
        'btnMapItem
        '
        Me.btnMapItem.Location = New System.Drawing.Point(1134, 11)
        Me.btnMapItem.Name = "btnMapItem"
        Me.btnMapItem.Size = New System.Drawing.Size(75, 46)
        Me.btnMapItem.TabIndex = 9
        Me.btnMapItem.Text = "&Map"
        Me.btnMapItem.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Item Code"
        '
        'btnSearchItem
        '
        Me.btnSearchItem.Location = New System.Drawing.Point(1053, 11)
        Me.btnSearchItem.Name = "btnSearchItem"
        Me.btnSearchItem.Size = New System.Drawing.Size(75, 47)
        Me.btnSearchItem.TabIndex = 8
        Me.btnSearchItem.Text = "&Search"
        Me.btnSearchItem.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Item Name"
        '
        'txtItemName
        '
        Me.txtItemName.Enabled = False
        Me.txtItemName.Location = New System.Drawing.Point(98, 46)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(442, 20)
        Me.txtItemName.TabIndex = 3
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(767, 94)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(92, 13)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "Customer Address"
        '
        'txtCustomerAddressMap
        '
        Me.txtCustomerAddressMap.Location = New System.Drawing.Point(868, 91)
        Me.txtCustomerAddressMap.Name = "txtCustomerAddressMap"
        Me.txtCustomerAddressMap.Size = New System.Drawing.Size(176, 20)
        Me.txtCustomerAddressMap.TabIndex = 28
        '
        'frmEditDataMapping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1333, 648)
        Me.Controls.Add(Me.gbItem)
        Me.Controls.Add(Me.gbCustomer)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditDataMapping"
        Me.Text = "Edit Data Mapping"
        Me.gbCustomer.ResumeLayout(False)
        Me.gbCustomer.PerformLayout()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbItem.ResumeLayout(False)
        Me.gbItem.PerformLayout()
        CType(Me.dgvItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerCode As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSearchCustomer As System.Windows.Forms.Button
    Friend WithEvents btnMapCustomer As System.Windows.Forms.Button
    Friend WithEvents gbCustomer As System.Windows.Forms.GroupBox
    Friend WithEvents txtCustomerCodeMap As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerNameMap As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgvCustomer As System.Windows.Forms.DataGridView
    Friend WithEvents gbItem As System.Windows.Forms.GroupBox
    Friend WithEvents dgvItem As System.Windows.Forms.DataGridView
    Friend WithEvents txtItemCodeMap As System.Windows.Forms.TextBox
    Friend WithEvents txtItemNameMap As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtItemCode As System.Windows.Forms.TextBox
    Friend WithEvents btnMapItem As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnSearchItem As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtItemName As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtItemNameMap2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerNameMap2 As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents Address1 As System.Windows.Forms.Label
    Friend WithEvents txtAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtUnitPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtUnit As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtShipAdd2 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtShipAdd1 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtShipTo As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnUpdateMapCust As System.Windows.Forms.Button
    Friend WithEvents btnUpdateMapItem As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerAddressMap As System.Windows.Forms.TextBox
End Class
