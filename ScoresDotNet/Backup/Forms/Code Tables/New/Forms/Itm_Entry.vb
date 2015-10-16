Imports System.Data.SqlClient
Imports Microsoft

Public Class Itm_Entry
    Inherits System.Windows.Forms.Form
    Private RemoteDataSet As New CodeTablesDS
    Private RemoteDataSet2 As New MyDataSetDB
    Private ProductLineDS As New DataSet
    Private ProductFormDS As New DataSet
  
    Private EditMode As Boolean = False
    Private oldDs As String, tmpLD As String, tmpID As String
    Public Minus1 As Boolean
    Public r As String
    Public PrdLineCode As String
    Public PrdFormCode As String
    'Private Itm_EditMode As Boolean = False

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Load_Division()
        Load_Principal()
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
    Friend WithEvents vDivCode As System.Windows.Forms.TextBox
    Friend WithEvents vPrinCode As System.Windows.Forms.TextBox
    Friend WithEvents vLastUser As System.Windows.Forms.TextBox
    Friend WithEvents vRowId As System.Windows.Forms.TextBox
    Friend WithEvents SqlValue As System.Windows.Forms.ComboBox
    Friend WithEvents vLine As System.Windows.Forms.TextBox
    Friend WithEvents vInActiveDate As System.Windows.Forms.TextBox
    Friend WithEvents vUpdateDate As System.Windows.Forms.TextBox
    Friend WithEvents vCreateDate As System.Windows.Forms.TextBox
    Friend WithEvents vUnitConversion As System.Windows.Forms.TextBox
    Friend WithEvents vItemUnit As System.Windows.Forms.TextBox
    Friend WithEvents vLaunchDate As System.Windows.Forms.TextBox
    Friend WithEvents vProductForm As System.Windows.Forms.TextBox
    Friend WithEvents vProductLine As System.Windows.Forms.TextBox
    Friend WithEvents vMercurySTPrice As System.Windows.Forms.TextBox
    Friend WithEvents vUnitPrice As System.Windows.Forms.TextBox
    Friend WithEvents vGenericName As System.Windows.Forms.TextBox
    Friend WithEvents vItemDesc As System.Windows.Forms.TextBox
    Friend WithEvents vMercuryItemCode As System.Windows.Forms.TextBox
    Friend WithEvents vMetroDrugCode As System.Windows.Forms.TextBox
    Friend WithEvents vItemCode As System.Windows.Forms.TextBox
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cboPrincipal As System.Windows.Forms.ComboBox
    Friend WithEvents cboDivision As System.Windows.Forms.ComboBox
    Friend WithEvents cmdSave_itm As System.Windows.Forms.Button
    Friend WithEvents cmdCancel_itm As System.Windows.Forms.Button
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents vDimcode As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboProductLine As System.Windows.Forms.ComboBox
    Friend WithEvents cboProductForm As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Itm_Entry))
        Me.vDivCode = New System.Windows.Forms.TextBox
        Me.vPrinCode = New System.Windows.Forms.TextBox
        Me.vLastUser = New System.Windows.Forms.TextBox
        Me.vRowId = New System.Windows.Forms.TextBox
        Me.SqlValue = New System.Windows.Forms.ComboBox
        Me.vLine = New System.Windows.Forms.TextBox
        Me.vInActiveDate = New System.Windows.Forms.TextBox
        Me.vUpdateDate = New System.Windows.Forms.TextBox
        Me.vCreateDate = New System.Windows.Forms.TextBox
        Me.vUnitConversion = New System.Windows.Forms.TextBox
        Me.vItemUnit = New System.Windows.Forms.TextBox
        Me.vLaunchDate = New System.Windows.Forms.TextBox
        Me.vProductForm = New System.Windows.Forms.TextBox
        Me.vProductLine = New System.Windows.Forms.TextBox
        Me.vMercurySTPrice = New System.Windows.Forms.TextBox
        Me.vUnitPrice = New System.Windows.Forms.TextBox
        Me.vGenericName = New System.Windows.Forms.TextBox
        Me.vItemDesc = New System.Windows.Forms.TextBox
        Me.vMercuryItemCode = New System.Windows.Forms.TextBox
        Me.vMetroDrugCode = New System.Windows.Forms.TextBox
        Me.vItemCode = New System.Windows.Forms.TextBox
        Me.cboStatus = New System.Windows.Forms.ComboBox
        Me.cboPrincipal = New System.Windows.Forms.ComboBox
        Me.cboDivision = New System.Windows.Forms.ComboBox
        Me.cmdSave_itm = New System.Windows.Forms.Button
        Me.cmdCancel_itm = New System.Windows.Forms.Button
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.vDimcode = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.cboProductForm = New System.Windows.Forms.ComboBox
        Me.cboProductLine = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'vDivCode
        '
        Me.vDivCode.Location = New System.Drawing.Point(206, 539)
        Me.vDivCode.Name = "vDivCode"
        Me.vDivCode.Size = New System.Drawing.Size(55, 20)
        Me.vDivCode.TabIndex = 129
        Me.vDivCode.Tag = ""
        Me.vDivCode.Text = ""
        Me.vDivCode.Visible = False
        '
        'vPrinCode
        '
        Me.vPrinCode.Location = New System.Drawing.Point(142, 539)
        Me.vPrinCode.Name = "vPrinCode"
        Me.vPrinCode.Size = New System.Drawing.Size(59, 20)
        Me.vPrinCode.TabIndex = 128
        Me.vPrinCode.Tag = ""
        Me.vPrinCode.Text = ""
        Me.vPrinCode.Visible = False
        '
        'vLastUser
        '
        Me.vLastUser.Location = New System.Drawing.Point(82, 539)
        Me.vLastUser.Name = "vLastUser"
        Me.vLastUser.Size = New System.Drawing.Size(56, 20)
        Me.vLastUser.TabIndex = 127
        Me.vLastUser.Tag = ""
        Me.vLastUser.Text = ""
        Me.vLastUser.Visible = False
        '
        'vRowId
        '
        Me.vRowId.Location = New System.Drawing.Point(29, 539)
        Me.vRowId.Name = "vRowId"
        Me.vRowId.Size = New System.Drawing.Size(48, 20)
        Me.vRowId.TabIndex = 106
        Me.vRowId.Tag = ""
        Me.vRowId.Text = ""
        Me.vRowId.Visible = False
        '
        'SqlValue
        '
        Me.SqlValue.Location = New System.Drawing.Point(305, 539)
        Me.SqlValue.Name = "SqlValue"
        Me.SqlValue.Size = New System.Drawing.Size(146, 21)
        Me.SqlValue.TabIndex = 140
        Me.SqlValue.Visible = False
        '
        'vLine
        '
        Me.vLine.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vLine.Location = New System.Drawing.Point(123, 82)
        Me.vLine.MaxLength = 40
        Me.vLine.Name = "vLine"
        Me.vLine.Size = New System.Drawing.Size(569, 20)
        Me.vLine.TabIndex = 183
        Me.vLine.Tag = "INPUT"
        Me.vLine.Text = ""
        '
        'vInActiveDate
        '
        Me.vInActiveDate.BackColor = System.Drawing.SystemColors.Info
        Me.vInActiveDate.Enabled = False
        Me.vInActiveDate.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vInActiveDate.Location = New System.Drawing.Point(123, 55)
        Me.vInActiveDate.Name = "vInActiveDate"
        Me.vInActiveDate.Size = New System.Drawing.Size(569, 20)
        Me.vInActiveDate.TabIndex = 180
        Me.vInActiveDate.Tag = "INPUT"
        Me.vInActiveDate.Text = ""
        '
        'vUpdateDate
        '
        Me.vUpdateDate.BackColor = System.Drawing.SystemColors.Info
        Me.vUpdateDate.Enabled = False
        Me.vUpdateDate.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vUpdateDate.Location = New System.Drawing.Point(123, 149)
        Me.vUpdateDate.Name = "vUpdateDate"
        Me.vUpdateDate.Size = New System.Drawing.Size(569, 20)
        Me.vUpdateDate.TabIndex = 178
        Me.vUpdateDate.Tag = "INPUT"
        Me.vUpdateDate.Text = ""
        '
        'vCreateDate
        '
        Me.vCreateDate.BackColor = System.Drawing.SystemColors.Info
        Me.vCreateDate.Enabled = False
        Me.vCreateDate.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vCreateDate.Location = New System.Drawing.Point(123, 118)
        Me.vCreateDate.Name = "vCreateDate"
        Me.vCreateDate.Size = New System.Drawing.Size(569, 20)
        Me.vCreateDate.TabIndex = 176
        Me.vCreateDate.Tag = "INPUT"
        Me.vCreateDate.Text = ""
        '
        'vUnitConversion
        '
        Me.vUnitConversion.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vUnitConversion.Location = New System.Drawing.Point(118, 130)
        Me.vUnitConversion.MaxLength = 10
        Me.vUnitConversion.Name = "vUnitConversion"
        Me.vUnitConversion.Size = New System.Drawing.Size(416, 20)
        Me.vUnitConversion.TabIndex = 149
        Me.vUnitConversion.Tag = "INPUT"
        Me.vUnitConversion.Text = ""
        '
        'vItemUnit
        '
        Me.vItemUnit.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vItemUnit.Location = New System.Drawing.Point(118, 94)
        Me.vItemUnit.MaxLength = 20
        Me.vItemUnit.Name = "vItemUnit"
        Me.vItemUnit.Size = New System.Drawing.Size(416, 20)
        Me.vItemUnit.TabIndex = 148
        Me.vItemUnit.Tag = "INPUT"
        Me.vItemUnit.Text = ""
        '
        'vLaunchDate
        '
        Me.vLaunchDate.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vLaunchDate.Location = New System.Drawing.Point(123, 24)
        Me.vLaunchDate.MaxLength = 10
        Me.vLaunchDate.Name = "vLaunchDate"
        Me.vLaunchDate.Size = New System.Drawing.Size(569, 20)
        Me.vLaunchDate.TabIndex = 156
        Me.vLaunchDate.Tag = "INPUT"
        Me.vLaunchDate.Text = ""
        '
        'vProductForm
        '
        Me.vProductForm.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vProductForm.Location = New System.Drawing.Point(123, 51)
        Me.vProductForm.MaxLength = 40
        Me.vProductForm.Name = "vProductForm"
        Me.vProductForm.Size = New System.Drawing.Size(129, 20)
        Me.vProductForm.TabIndex = 155
        Me.vProductForm.Tag = "INPUT"
        Me.vProductForm.Text = ""
        '
        'vProductLine
        '
        Me.vProductLine.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vProductLine.Location = New System.Drawing.Point(123, 19)
        Me.vProductLine.MaxLength = 40
        Me.vProductLine.Name = "vProductLine"
        Me.vProductLine.Size = New System.Drawing.Size(129, 20)
        Me.vProductLine.TabIndex = 154
        Me.vProductLine.Tag = "INPUT"
        Me.vProductLine.Text = ""
        '
        'vMercurySTPrice
        '
        Me.vMercurySTPrice.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vMercurySTPrice.Location = New System.Drawing.Point(118, 66)
        Me.vMercurySTPrice.MaxLength = 25
        Me.vMercurySTPrice.Name = "vMercurySTPrice"
        Me.vMercurySTPrice.Size = New System.Drawing.Size(415, 20)
        Me.vMercurySTPrice.TabIndex = 151
        Me.vMercurySTPrice.Tag = "INPUT"
        Me.vMercurySTPrice.Text = ""
        '
        'vUnitPrice
        '
        Me.vUnitPrice.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vUnitPrice.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.vUnitPrice.Location = New System.Drawing.Point(118, 30)
        Me.vUnitPrice.MaxLength = 25
        Me.vUnitPrice.Name = "vUnitPrice"
        Me.vUnitPrice.Size = New System.Drawing.Size(415, 20)
        Me.vUnitPrice.TabIndex = 150
        Me.vUnitPrice.Tag = "INPUT"
        Me.vUnitPrice.Text = ""
        '
        'vGenericName
        '
        Me.vGenericName.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vGenericName.Location = New System.Drawing.Point(118, 58)
        Me.vGenericName.MaxLength = 40
        Me.vGenericName.Name = "vGenericName"
        Me.vGenericName.Size = New System.Drawing.Size(416, 20)
        Me.vGenericName.TabIndex = 147
        Me.vGenericName.Tag = "INPUT"
        Me.vGenericName.Text = ""
        '
        'vItemDesc
        '
        Me.vItemDesc.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vItemDesc.Location = New System.Drawing.Point(118, 22)
        Me.vItemDesc.MaxLength = 50
        Me.vItemDesc.Name = "vItemDesc"
        Me.vItemDesc.Size = New System.Drawing.Size(416, 20)
        Me.vItemDesc.TabIndex = 146
        Me.vItemDesc.Tag = "INPUT"
        Me.vItemDesc.Text = ""
        '
        'vMercuryItemCode
        '
        Me.vMercuryItemCode.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vMercuryItemCode.Location = New System.Drawing.Point(118, 59)
        Me.vMercuryItemCode.MaxLength = 10
        Me.vMercuryItemCode.Name = "vMercuryItemCode"
        Me.vMercuryItemCode.Size = New System.Drawing.Size(416, 20)
        Me.vMercuryItemCode.TabIndex = 145
        Me.vMercuryItemCode.Tag = "INPUT"
        Me.vMercuryItemCode.Text = ""
        '
        'vMetroDrugCode
        '
        Me.vMetroDrugCode.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vMetroDrugCode.Location = New System.Drawing.Point(118, 24)
        Me.vMetroDrugCode.MaxLength = 10
        Me.vMetroDrugCode.Name = "vMetroDrugCode"
        Me.vMetroDrugCode.Size = New System.Drawing.Size(416, 20)
        Me.vMetroDrugCode.TabIndex = 144
        Me.vMetroDrugCode.Tag = "INPUT"
        Me.vMetroDrugCode.Text = ""
        '
        'vItemCode
        '
        Me.vItemCode.BackColor = System.Drawing.SystemColors.Window
        Me.vItemCode.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vItemCode.Location = New System.Drawing.Point(118, 21)
        Me.vItemCode.MaxLength = 10
        Me.vItemCode.Name = "vItemCode"
        Me.vItemCode.Size = New System.Drawing.Size(416, 20)
        Me.vItemCode.TabIndex = 143
        Me.vItemCode.Tag = "INPUT"
        Me.vItemCode.Text = ""
        '
        'cboStatus
        '
        Me.cboStatus.ItemHeight = 13
        Me.cboStatus.Items.AddRange(New Object() {"", "ACTIVE", "INACTIVE"})
        Me.cboStatus.Location = New System.Drawing.Point(123, 86)
        Me.cboStatus.MaxLength = 10
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(569, 21)
        Me.cboStatus.TabIndex = 157
        Me.cboStatus.Tag = "Input"
        '
        'cboPrincipal
        '
        Me.cboPrincipal.ItemHeight = 13
        Me.cboPrincipal.Location = New System.Drawing.Point(123, 22)
        Me.cboPrincipal.MaxLength = 55
        Me.cboPrincipal.Name = "cboPrincipal"
        Me.cboPrincipal.Size = New System.Drawing.Size(569, 21)
        Me.cboPrincipal.TabIndex = 152
        Me.cboPrincipal.Tag = "Input"
        '
        'cboDivision
        '
        Me.cboDivision.ItemHeight = 13
        Me.cboDivision.Location = New System.Drawing.Point(123, 55)
        Me.cboDivision.MaxLength = 55
        Me.cboDivision.Name = "cboDivision"
        Me.cboDivision.Size = New System.Drawing.Size(569, 21)
        Me.cboDivision.TabIndex = 153
        Me.cboDivision.Tag = "Input"
        '
        'cmdSave_itm
        '
        Me.cmdSave_itm.Image = CType(resources.GetObject("cmdSave_itm.Image"), System.Drawing.Image)
        Me.cmdSave_itm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSave_itm.Location = New System.Drawing.Point(1232, 525)
        Me.cmdSave_itm.Name = "cmdSave_itm"
        Me.cmdSave_itm.Size = New System.Drawing.Size(86, 34)
        Me.cmdSave_itm.TabIndex = 158
        Me.cmdSave_itm.Tag = "Save"
        Me.cmdSave_itm.Text = "   &Save"
        '
        'cmdCancel_itm
        '
        Me.cmdCancel_itm.Location = New System.Drawing.Point(1140, 525)
        Me.cmdCancel_itm.Name = "cmdCancel_itm"
        Me.cmdCancel_itm.Size = New System.Drawing.Size(86, 34)
        Me.cmdCancel_itm.TabIndex = 159
        Me.cmdCancel_itm.Tag = "Cancel"
        Me.cmdCancel_itm.Text = "&Cancel"
        '
        'ToolBar1
        '
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(1330, 42)
        Me.ToolBar1.TabIndex = 185
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.vDimcode)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.vItemCode)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(561, 92)
        Me.GroupBox1.TabIndex = 187
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Item / Dimension Code"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 23)
        Me.Label1.TabIndex = 144
        Me.Label1.Text = "Dimension Code :"
        '
        'vDimcode
        '
        Me.vDimcode.BackColor = System.Drawing.SystemColors.Window
        Me.vDimcode.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vDimcode.Location = New System.Drawing.Point(118, 56)
        Me.vDimcode.MaxLength = 10
        Me.vDimcode.Name = "vDimcode"
        Me.vDimcode.ReadOnly = True
        Me.vDimcode.Size = New System.Drawing.Size(416, 20)
        Me.vDimcode.TabIndex = 888
        Me.vDimcode.Tag = "INPUT"
        Me.vDimcode.Text = ""
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(10, 27)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(80, 23)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Item Code :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.vMercuryItemCode)
        Me.GroupBox2.Controls.Add(Me.vMetroDrugCode)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 124)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(561, 94)
        Me.GroupBox2.TabIndex = 188
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Metro Drug / Mercury Item Code"
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(8, 59)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(110, 23)
        Me.Label24.TabIndex = 147
        Me.Label24.Text = " Mercury Item Code :"
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(10, 24)
        Me.Label23.Name = "Label23"
        Me.Label23.TabIndex = 146
        Me.Label23.Text = "Metro Drug Code :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.vUnitConversion)
        Me.GroupBox3.Controls.Add(Me.vItemUnit)
        Me.GroupBox3.Controls.Add(Me.vGenericName)
        Me.GroupBox3.Controls.Add(Me.vItemDesc)
        Me.GroupBox3.Location = New System.Drawing.Point(21, 228)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(561, 167)
        Me.GroupBox3.TabIndex = 189
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Brand / Name / Unit"
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(10, 131)
        Me.Label26.Name = "Label26"
        Me.Label26.TabIndex = 153
        Me.Label26.Text = "Unit Conversion :"
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(10, 96)
        Me.Label25.Name = "Label25"
        Me.Label25.TabIndex = 152
        Me.Label25.Text = "Unit :"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(10, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.TabIndex = 151
        Me.Label4.Text = "Generic Name :"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(10, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 150
        Me.Label2.Text = "Brand Description :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.vMercurySTPrice)
        Me.GroupBox4.Controls.Add(Me.vUnitPrice)
        Me.GroupBox4.Location = New System.Drawing.Point(21, 406)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(561, 100)
        Me.GroupBox4.TabIndex = 190
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Prices"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(10, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 34)
        Me.Label5.TabIndex = 153
        Me.Label5.Text = "Current Mercury Price(ST) :"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(10, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 23)
        Me.Label3.TabIndex = 152
        Me.Label3.Text = "Current Price(SRP) :"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.cboDivision)
        Me.GroupBox5.Controls.Add(Me.cboPrincipal)
        Me.GroupBox5.Location = New System.Drawing.Point(601, 19)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(718, 91)
        Me.GroupBox5.TabIndex = 191
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Principal / Division"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(4, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 20)
        Me.Label7.TabIndex = 155
        Me.Label7.Text = "Current Segment :"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(4, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 23)
        Me.Label6.TabIndex = 154
        Me.Label6.Text = "Current Principal :"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cboProductForm)
        Me.GroupBox6.Controls.Add(Me.cboProductLine)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.vLine)
        Me.GroupBox6.Controls.Add(Me.vProductForm)
        Me.GroupBox6.Controls.Add(Me.vProductLine)
        Me.GroupBox6.Location = New System.Drawing.Point(601, 121)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(718, 119)
        Me.GroupBox6.TabIndex = 192
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Product Line / Form"
        '
        'cboProductForm
        '
        Me.cboProductForm.ItemHeight = 13
        Me.cboProductForm.Location = New System.Drawing.Point(265, 51)
        Me.cboProductForm.MaxLength = 55
        Me.cboProductForm.Name = "cboProductForm"
        Me.cboProductForm.Size = New System.Drawing.Size(429, 21)
        Me.cboProductForm.TabIndex = 188
        Me.cboProductForm.Tag = "Input"
        '
        'cboProductLine
        '
        Me.cboProductLine.ItemHeight = 13
        Me.cboProductLine.Location = New System.Drawing.Point(265, 19)
        Me.cboProductLine.MaxLength = 55
        Me.cboProductLine.Name = "cboProductLine"
        Me.cboProductLine.Size = New System.Drawing.Size(429, 21)
        Me.cboProductLine.TabIndex = 187
        Me.cboProductLine.Tag = "Input"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(4, 81)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 30)
        Me.Label15.TabIndex = 186
        Me.Label15.Text = "Key Product Line :"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(4, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 23)
        Me.Label9.TabIndex = 185
        Me.Label9.Text = "Product Form :"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(4, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 23)
        Me.Label8.TabIndex = 184
        Me.Label8.Text = "Product Line :"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label27)
        Me.GroupBox7.Controls.Add(Me.Label21)
        Me.GroupBox7.Controls.Add(Me.Label16)
        Me.GroupBox7.Controls.Add(Me.Label14)
        Me.GroupBox7.Controls.Add(Me.Label13)
        Me.GroupBox7.Controls.Add(Me.vUpdateDate)
        Me.GroupBox7.Controls.Add(Me.vCreateDate)
        Me.GroupBox7.Controls.Add(Me.cboStatus)
        Me.GroupBox7.Controls.Add(Me.vLaunchDate)
        Me.GroupBox7.Controls.Add(Me.vInActiveDate)
        Me.GroupBox7.Location = New System.Drawing.Point(601, 249)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(718, 186)
        Me.GroupBox7.TabIndex = 193
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Dates and Status"
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(4, 149)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(74, 23)
        Me.Label27.TabIndex = 185
        Me.Label27.Text = "Update Date :"
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(4, 118)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(74, 23)
        Me.Label21.TabIndex = 184
        Me.Label21.Text = "Create Date :"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(4, 87)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 23)
        Me.Label16.TabIndex = 183
        Me.Label16.Text = "Status :"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(4, 56)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(84, 23)
        Me.Label14.TabIndex = 182
        Me.Label14.Text = "In-Active Date :"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(4, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 23)
        Me.Label13.TabIndex = 181
        Me.Label13.Text = "Launch Date :"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.PictureBox1)
        Me.GroupBox8.Controls.Add(Me.Label10)
        Me.GroupBox8.Controls.Add(Me.Label12)
        Me.GroupBox8.Location = New System.Drawing.Point(600, 442)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(720, 63)
        Me.GroupBox8.TabIndex = 194
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Notification"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(22, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 77
        Me.PictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(80, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(192, 14)
        Me.Label10.TabIndex = 62
        Me.Label10.Text = "Easy Date Format Entry: ""MMDDYY"""
        '
        'Label12
        '
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(80, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(184, 14)
        Me.Label12.TabIndex = 63
        Me.Label12.Text = "ex.  ""112595"" = ""Nov.25,1995"""
        '
        'Itm_Entry
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1330, 574)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.cmdSave_itm)
        Me.Controls.Add(Me.cmdCancel_itm)
        Me.Controls.Add(Me.vDivCode)
        Me.Controls.Add(Me.vPrinCode)
        Me.Controls.Add(Me.vLastUser)
        Me.Controls.Add(Me.vRowId)
        Me.Controls.Add(Me.SqlValue)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Itm_Entry"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item Entry"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Itm_Entry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlMaintenance.ClearInputControlsGroup(Me)
        If Itm_EditMode = True Then
            vItemCode.ReadOnly = True
            oldDs = Trim(vItemDesc.Text)
            vItemDesc.Select()
            vItemDesc.SelectAll()
            tmpLD = Trim(vLaunchDate.Text)
            tmpID = Trim(vInActiveDate.Text)
            cboPrincipal.Text = Filds(11).ToString
            cboDivision.Text = Filds(13).ToString
            cboStatus.Text = Filds(19).ToString
        Else
            ControlMaintenance.ClearInputControlsGroup(Me)
            EditMode = False
            btnSw = True
            vItemCode.Enabled = True
            vItemCode.Select()
        End If
        ProductLineDS.Tables.Add("ProductLine_Combo")
        ProductFormDS.Tables.Add("ProductForm_Combo")
        Load_ProductLine()
        Load_ProductForm()
        If Itm_EditMode = True Then
            cboProductLine.SelectedValue = PrdLineCode
            cboProductForm.SelectedValue = PrdFormCode
        End If
    End Sub

    Private Sub Load_Division()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "Division_Combo", CommandType.StoredProcedure, RemoteDataSet, "Division_Combo")
        cboDivision.DataSource = RemoteDataSet.Division_Combo
        cboDivision.DisplayMember = "Division"
    End Sub
    Private Sub Load_ProductLine()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        If ProductLineDS.Tables("ProductLine_Combo").Rows.Count > 0 Then
            ProductLineDS.Tables("ProductLine_Combo").Clear()
        End If
        BusinessObject.Sub_Show(ServerPath2, "ProductLine_Combo", CommandType.StoredProcedure, ProductLineDS, "ProductLine_Combo")
        cboProductLine.DataSource = ProductLineDS.Tables("ProductLine_Combo")
        cboProductLine.ValueMember = "DimCode"
        cboProductLine.DisplayMember = "ProductLine"
    End Sub
    Private Sub Load_ProductForm()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        If ProductFormDS.Tables("ProductForm_Combo").Rows.Count > 0 Then
            ProductFormDS.Tables("ProductForm_Combo").Clear()
        End If
        BusinessObject.Sub_Show(ServerPath2, "ProductForm_Combo", CommandType.StoredProcedure, ProductFormDS, "ProductForm_Combo")
        cboProductForm.DataSource = ProductFormDS.Tables("ProductForm_Combo")
        cboProductForm.ValueMember = "DimCode"
        cboProductForm.DisplayMember = "ProductForm"
    End Sub

    Private Sub Load_Principal()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "Principal_Combo", CommandType.StoredProcedure, RemoteDataSet, "Principal_Combo")
        cboPrincipal.DataSource = RemoteDataSet.Principal_Combo
        cboPrincipal.DisplayMember = "Principal"
    End Sub

    Private Sub cmdSave_itm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave_itm.Click
        Dim MyLoadedForm As New ItemCT
        If (MessageBox.Show("Are you sure you want to Save this Entry?", "Confirm Saving", _
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)) _
            = DialogResult.Yes Then

            vLastUser.Text = gCurrUser
            If Itm_EditMode = False Then
                Sub_Insert()
            Else
                Sub_Update()
            End If
            Close()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Sub_Insert()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(22) As SqlParameter

        Dim ItemCode As New SqlParameter("@ItemCode", SqlDbType.VarChar, 10)
        ItemCode.Direction = ParameterDirection.Input
        ItemCode.Value = jTrim(vItemCode.Text)
        Params(0) = ItemCode

        Dim ItemDesc As New SqlParameter("@ItemDesc", SqlDbType.VarChar, 150)
        ItemDesc.Direction = ParameterDirection.Input
        ItemDesc.Value = jTrim(vItemDesc.Text)
        Params(1) = ItemDesc

        Dim ItemUnit As New SqlParameter("@ItemUnit", SqlDbType.VarChar, 10)
        ItemUnit.Direction = ParameterDirection.Input
        ItemUnit.Value = jTrim(StrTran(vItemUnit.Text, "'", """"))
        Params(2) = ItemUnit

        Dim UnitPrice As New SqlParameter("@UnitPrice", SqlDbType.Money)
        UnitPrice.Direction = ParameterDirection.Input
        UnitPrice.Value = jVal(Trim(vUnitPrice.Text))
        Params(3) = UnitPrice

        Dim PrinCode As New SqlParameter("@PrinCode", SqlDbType.VarChar, 5)
        PrinCode.Direction = ParameterDirection.Input
        PrinCode.Value = GetCode(cboPrincipal.Text)   'Trim(vPrinCode.Text)
        Params(4) = PrinCode

        Dim DivCode As New SqlParameter("@DivCode", SqlDbType.VarChar, 3)
        DivCode.Direction = ParameterDirection.Input
        DivCode.Value = GetCode(cboDivision.Text)  'Trim(vDivCode.Text)
        Params(5) = DivCode

        Dim CreateDate As New SqlParameter("@CreateDate", SqlDbType.DateTime, 10)
        CreateDate.Direction = ParameterDirection.Input
        CreateDate.Value = GetDateTimeNow()
        Params(6) = CreateDate

        Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime, 10)
        UpdateDate.Direction = ParameterDirection.Input
        UpdateDate.Value = GetDateTimeNow()
        Params(7) = UpdateDate

        Dim ProductLine As New SqlParameter("@ProductLine", SqlDbType.VarChar, 40)
        ProductLine.Direction = ParameterDirection.Input
        ProductLine.Value = jTrim(vProductLine.Text)
        Params(8) = ProductLine

        Dim ProductForm As New SqlParameter("@ProductForm", SqlDbType.VarChar, 40)
        ProductForm.Direction = ParameterDirection.Input
        ProductForm.Value = jTrim(vProductForm.Text)
        Params(9) = ProductForm

        Dim KeyProdLine As New SqlParameter("@KeyProdLine", SqlDbType.VarChar, 40)
        KeyProdLine.Direction = ParameterDirection.Input
        KeyProdLine.Value = jTrim(vLine.Text)
        Params(10) = KeyProdLine

        Dim GenericName As New SqlParameter("@GenericName", SqlDbType.VarChar, 40)
        GenericName.Direction = ParameterDirection.Input
        GenericName.Value = jTrim(vGenericName.Text)
        Params(11) = GenericName

        Dim MercurySTprice As New SqlParameter("@MercurySTprice", SqlDbType.Money)
        MercurySTprice.Direction = ParameterDirection.Input
        MercurySTprice.Value = jVal(Trim(vMercurySTPrice.Text))
        Params(12) = MercurySTprice

        Dim LaunchDate As New SqlParameter("@LaunchDate", SqlDbType.DateTime, 10)
        LaunchDate.Direction = ParameterDirection.Input
        'If jTrim(vLaunchDate.Text) = "" Then
        LaunchDate.Value = vLaunchDate.Text.ToString   'DBNull.Value
        'Else
        'LaunchDate.Value = tmpLD
        'End If
        Params(13) = LaunchDate

        Dim InactiveDate As New SqlParameter("@InactiveDate", SqlDbType.DateTime, 10)
        InactiveDate.Direction = ParameterDirection.Input
        If jTrim(vInActiveDate.Text) = "" Then
            InactiveDate.Value = DBNull.Value
        Else
            InactiveDate.Value = tmpID
        End If
        Params(14) = InactiveDate

        Dim MetroDrugCode As New SqlParameter("@MetroDrugCode", SqlDbType.VarChar, 10)
        MetroDrugCode.Direction = ParameterDirection.Input
        MetroDrugCode.Value = jTrim(vMetroDrugCode.Text)
        Params(15) = MetroDrugCode

        Dim MercuryItemCode As New SqlParameter("@MercuryItemCode", SqlDbType.VarChar, 10)
        MercuryItemCode.Direction = ParameterDirection.Input
        MercuryItemCode.Value = jTrim(vMercuryItemCode.Text)
        Params(16) = MercuryItemCode

        Dim LastUser As New SqlParameter("@LastUser", SqlDbType.VarChar, 8)
        LastUser.Direction = ParameterDirection.Input
        LastUser.Value = IIf(Trim(gCurrUser) = "", "", gCurrUser)       ' jTrim(vLastUser.Text)
        Params(17) = LastUser

        Dim Status As New SqlParameter("@Status", SqlDbType.VarChar, 7)
        Status.Direction = ParameterDirection.Input
        Status.Value = jTrim(cboStatus.Text)
        Params(18) = Status

        Dim UnitConversion As New SqlParameter("@UnitConversion", SqlDbType.SmallInt)
        UnitConversion.Direction = ParameterDirection.Input
        If Trim(vUnitConversion.Text) = "" Then
            UnitConversion.Value = DBNull.Value
        Else
            UnitConversion.Value = jVal(Trim(vUnitConversion.Text))
        End If
        Params(19) = UnitConversion

        Dim DimCode As New SqlParameter("@DimCode", SqlDbType.VarChar, 8)
        DimCode.Direction = ParameterDirection.Input
        DimCode.Value = vDimcode.Text
        Params(20) = DimCode

        Dim PrdCode As New SqlParameter("@PrdLineCode", SqlDbType.VarChar, 6)
        PrdCode.Direction = ParameterDirection.Input
        PrdCode.Value = cboProductLine.SelectedValue
        Params(21) = PrdCode

        Dim FormCode As New SqlParameter("@PrdFormCode", SqlDbType.VarChar, 6)
        FormCode.Direction = ParameterDirection.Input
        FormCode.Value = cboProductForm.SelectedValue
        Params(22) = FormCode

        Try
            BusinessObject.Sub_Insert(ServerPath2, "ItemCT_Insert", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Close()
    End Sub

    Private Sub Sub_Update()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(21) As SqlParameter

        Dim ItemCode As New SqlParameter("@ItemCode", SqlDbType.VarChar, 10)
        ItemCode.Direction = ParameterDirection.Input
        ItemCode.Value = jTrim(vItemCode.Text)
        Params(0) = ItemCode

        Dim ItemDesc As New SqlParameter("@ItemDesc", SqlDbType.VarChar, 150)
        ItemDesc.Direction = ParameterDirection.Input
        ItemDesc.Value = jTrim(vItemDesc.Text)
        Params(1) = ItemDesc

        Dim ItemUnit As New SqlParameter("@ItemUnit", SqlDbType.VarChar, 10)
        ItemUnit.Direction = ParameterDirection.Input
        ItemUnit.Value = jTrim(StrTran(vItemUnit.Text, "'", """"))
        Params(2) = ItemUnit

        Dim UnitPrice As New SqlParameter("@UnitPrice", SqlDbType.Money)
        UnitPrice.Direction = ParameterDirection.Input
        UnitPrice.Value = jVal(Trim(vUnitPrice.Text))
        Params(3) = UnitPrice

        Dim PrinCode As New SqlParameter("@PrinCode", SqlDbType.VarChar, 5)
        PrinCode.Direction = ParameterDirection.Input
        PrinCode.Value = GetCode(cboPrincipal.Text)   'Trim(vPrinCode.Text)
        Params(4) = PrinCode

        Dim DivCode As New SqlParameter("@DivCode", SqlDbType.VarChar, 3)
        DivCode.Direction = ParameterDirection.Input
        DivCode.Value = GetCode(cboDivision.Text)  'Trim(vDivCode.Text)
        Params(5) = DivCode

        Dim UpdateDate As New SqlParameter("@UpdateDate", SqlDbType.DateTime, 10)
        UpdateDate.Direction = ParameterDirection.Input
        UpdateDate.Value = GetDateTimeNow()
        Params(6) = UpdateDate

        Dim ProductLine As New SqlParameter("@ProductLine", SqlDbType.VarChar, 40)
        ProductLine.Direction = ParameterDirection.Input
        ProductLine.Value = jTrim(vProductLine.Text)
        Params(7) = ProductLine

        Dim ProductForm As New SqlParameter("@ProductForm", SqlDbType.VarChar, 40)
        ProductForm.Direction = ParameterDirection.Input
        ProductForm.Value = jTrim(vProductForm.Text)
        Params(8) = ProductForm

        Dim KeyProdLine As New SqlParameter("@KeyProdLine", SqlDbType.VarChar, 40)
        KeyProdLine.Direction = ParameterDirection.Input
        KeyProdLine.Value = jTrim(vLine.Text)
        Params(9) = KeyProdLine

        Dim GenericName As New SqlParameter("@GenericName", SqlDbType.VarChar, 40)
        GenericName.Direction = ParameterDirection.Input
        GenericName.Value = jTrim(vGenericName.Text)
        Params(10) = GenericName

        Dim MercurySTprice As New SqlParameter("@MercurySTprice", SqlDbType.Money)
        MercurySTprice.Direction = ParameterDirection.Input
        MercurySTprice.Value = jVal(Trim(vMercurySTPrice.Text))
        Params(11) = MercurySTprice

        Dim LaunchDate As New SqlParameter("@LaunchDate", SqlDbType.DateTime, 10)
        LaunchDate.Direction = ParameterDirection.Input
        If jTrim(vLaunchDate.Text) = "" Then
            LaunchDate.Value = DBNull.Value
        Else
            LaunchDate.Value = tmpLD
        End If
        Params(12) = LaunchDate

        Dim InactiveDate As New SqlParameter("@InactiveDate", SqlDbType.DateTime, 10)
        InactiveDate.Direction = ParameterDirection.Input
        If jTrim(vInActiveDate.Text) = "" Then
            InactiveDate.Value = DBNull.Value
        Else
            InactiveDate.Value = tmpID
        End If
        Params(13) = InactiveDate

        Dim MetroDrugCode As New SqlParameter("@MetroDrugCode", SqlDbType.VarChar, 10)
        MetroDrugCode.Direction = ParameterDirection.Input
        MetroDrugCode.Value = jTrim(vMetroDrugCode.Text)
        Params(14) = MetroDrugCode

        Dim MercuryItemCode As New SqlParameter("@MercuryItemCode", SqlDbType.VarChar, 10)
        MercuryItemCode.Direction = ParameterDirection.Input
        MercuryItemCode.Value = jTrim(vMercuryItemCode.Text)
        Params(15) = MercuryItemCode

        Dim LastUser As New SqlParameter("@LastUser", SqlDbType.VarChar, 8)
        LastUser.Direction = ParameterDirection.Input
        LastUser.Value = IIf(Trim(gCurrUser) = "", "", gCurrUser)     ' jTrim(vLastUser.Text)
        Params(16) = LastUser

        Dim Status As New SqlParameter("@Status", SqlDbType.VarChar, 7)
        Status.Direction = ParameterDirection.Input
        Status.Value = jTrim(cboStatus.Text)
        Params(17) = Status

        Dim UnitConversion As New SqlParameter("@UnitConversion", SqlDbType.SmallInt)
        UnitConversion.Direction = ParameterDirection.Input
        If Trim(vUnitConversion.Text) = "" Then
            UnitConversion.Value = DBNull.Value
        Else
            UnitConversion.Value = jVal(Trim(vUnitConversion.Text))
        End If
        Params(18) = UnitConversion

        Dim DimCode As New SqlParameter("@DimCode", SqlDbType.VarChar, 8)
        DimCode.Direction = ParameterDirection.Input
        DimCode.Value = vDimcode.Text
        Params(19) = DimCode

        Dim PrdCode As New SqlParameter("@PrdLineCode", SqlDbType.VarChar, 6)
        PrdCode.Direction = ParameterDirection.Input
        PrdCode.Value = cboProductLine.SelectedValue
        Params(20) = PrdCode

        Dim FormCode As New SqlParameter("@PrdFormCode", SqlDbType.VarChar, 6)
        FormCode.Direction = ParameterDirection.Input
        FormCode.Value = cboProductForm.SelectedValue
        Params(21) = FormCode


        Try
            BusinessObject.Sub_Insert(ServerPath2, "ItemCT_Update", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EditLoadedFilds()
        'vRowId.Text = Filds(0).ToString
        vItemCode.Text = Filds(1).ToString
        vMetroDrugCode.Text = Filds(2).ToString
        vMercuryItemCode.Text = Filds(3).ToString
        vItemDesc.Text = Filds(4).ToString
        vGenericName.Text = Filds(5).ToString
        vItemUnit.Text = Filds(6).ToString
        vUnitConversion.Text = Filds(7).ToString
        vUnitPrice.Text = Filds(8).ToString
        vMercurySTPrice.Text = Filds(9).ToString
        vPrinCode.Text = Filds(10).ToString
        cboPrincipal.Text = Filds(11).ToString
        vDivCode.Text = Filds(12).ToString
        cboDivision.Text = Filds(13).ToString
        vProductLine.Text = Filds(14).ToString
        vProductForm.Text = Filds(15).ToString
        vLine.Text = Filds(18).ToString
        vLaunchDate.Text = Filds(16).ToString
        vInActiveDate.Text() = Filds(17).ToString
        cboStatus.Text = Filds(19).ToString
        vUpdateDate.Text = Filds(20).ToString
    End Sub

    Private Sub vItemCode_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub vItemCode_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Dim s As String
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter
        If Trim(vItemCode.Text) = "" Then
            vItemDesc.Select()
            Exit Sub
        End If
        If btnSw = True And EditMode = False Then
            s = "select itemdesc as fld1 from NewScores_test..Item "
            s = s & "where itemcode = '" & Trim(vItemCode.Text) & "' "
            Dim SQLstmnt As New SqlParameter("@SqlQry", SqlDbType.NVarChar, 2950)
            SQLstmnt.Direction = ParameterDirection.Input
            SQLstmnt.Value = s
            Params(0) = SQLstmnt
            Try
                BusinessObject.Sub_Show(ServerPath2, "GenericQryProc", CommandType.StoredProcedure, RemoteDataSet2, "GenericQryProc", Params)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            SqlValue.DataSource = RemoteDataSet2.GenericQryProc
            SqlValue.DisplayMember = "fld1"
            If Trim(SqlValue.Text) <> "" Then
                MessageBox.Show("This Item Code already exist! Please try again.", "Item Exsists!")
                e.Cancel = True
                vItemCode.Clear()
            End If
            SqlValue.ResetText()
            SqlValue.DataSource = Nothing
            RemoteDataSet2.GenericQryProc.Clear()
        End If
    End Sub

    Private Sub vItemDesc_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub vItemDesc_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Dim s As String
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter
        If Trim(vItemDesc.Text) = "" Then
            vItemCode.Select()
            Exit Sub
        End If
        'If btnSw = True And Trim(vItemDesc.Text) <> Trim(oldDs) Then
        '    s = "select itemcode as fld1 from NewScores..Item where itemdesc = '" & Trim(vItemDesc.Text) & "' "
        '    Dim SQLstmnt As New SqlParameter("@SqlQry", SqlDbType.NVarChar, 2950)
        '    SQLstmnt.Direction = ParameterDirection.Input
        '    SQLstmnt.Value = s
        '    Params(0) = SQLstmnt
        '    Try
        '        BusinessObject.Sub_Show(ServerPath2, "GenericQryProc", CommandType.StoredProcedure, RemoteDataSet2, "GenericQryProc", Params)
        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try
        '    SqlValue.DataSource = RemoteDataSet2.GenericQryProc
        '    SqlValue.DisplayMember = "fld1"
        '    If Trim(SqlValue.Text) <> "" Then
        '        MessageBox.Show("This Item Code already exist! Please try again.", "Item Exsists!")
        '        e.Cancel = True
        '        vItemDesc.Clear()
        '    End If
        '    SqlValue.ResetText()
        '    SqlValue.DataSource = Nothing
        '    RemoteDataSet2.GenericQryProc.Clear()
        'End If
    End Sub

    Private Sub vMetroDrugCode_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
        'If NumKeys(e.KeyData, "INT") = False Then
        '    If Len(Trim(vMetroDrugCode.Text)) <> 0 Then
        '        vMetroDrugCode.Text = Mid(Trim(vMetroDrugCode.Text), 1, Len(Trim(vMetroDrugCode.Text)) - 1)
        '        vMetroDrugCode.SelectionStart = Len(Trim(vMetroDrugCode.Text))
        '        Beep()
        '    Else
        '        vMetroDrugCode.Text = ""
        '    End If
        'End If
    End Sub

    Private Sub vMetroDrugCode_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Dim s As String
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter
        If Trim(vMetroDrugCode.Text) = "" Then
            Exit Sub
        End If
        If btnSw = True And EditMode = False Then
            s = "select itemdesc as fld1 from NewScores_test..Item "
            s = s & "where MetroDrugCode = '" & Trim(vMetroDrugCode.Text) & "' "
            Dim SQLstmnt As New SqlParameter("@SqlQry", SqlDbType.NVarChar, 2950)
            SQLstmnt.Direction = ParameterDirection.Input
            SQLstmnt.Value = s
            Params(0) = SQLstmnt
            Try
                BusinessObject.Sub_Show(ServerPath2, "GenericQryProc", CommandType.StoredProcedure, RemoteDataSet2, "GenericQryProc", Params)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            SqlValue.DataSource = RemoteDataSet2.GenericQryProc
            SqlValue.DisplayMember = "fld1"
            If Trim(SqlValue.Text) <> "" Then
                MessageBox.Show("This MetroDrugCode is already connected to an Item!", "Code Exsists!")
                e.Cancel = True
                vMetroDrugCode.Clear()
            End If
            SqlValue.ResetText()
            SqlValue.DataSource = Nothing
            RemoteDataSet2.GenericQryProc.Clear()
        End If
    End Sub

    Private Sub vMercuryItemCode_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub vMercuryItemCode_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Dim s As String
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter
        If Trim(vMercuryItemCode.Text) = "" Then
            Exit Sub
        End If
        If btnSw = True And EditMode = False Then
            s = "select itemdesc as fld1 from NewScores_test..Item "
            s = s & "where MercuryItemCode = '" & Trim(vMercuryItemCode.Text) & "' "
            Dim SQLstmnt As New SqlParameter("@SqlQry", SqlDbType.NVarChar, 2950)
            SQLstmnt.Direction = ParameterDirection.Input
            SQLstmnt.Value = s
            Params(0) = SQLstmnt
            Try
                BusinessObject.Sub_Show(ServerPath2, "GenericQryProc", CommandType.StoredProcedure, RemoteDataSet2, "GenericQryProc", Params)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            SqlValue.DataSource = RemoteDataSet2.GenericQryProc
            SqlValue.DisplayMember = "fld1"
            If Trim(SqlValue.Text) <> "" Then
                MessageBox.Show("This MercuryItemCode is already connected to an Item!", "Code Exsists!")
                e.Cancel = True
                vMercuryItemCode.Clear()
            End If
            SqlValue.ResetText()
            SqlValue.DataSource = Nothing
            RemoteDataSet2.GenericQryProc.Clear()
        End If
    End Sub

    Private Sub vGenericName_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub vGenericName_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        'If Trim(vGenericName.Text) = "" Then
        '    MessageBox.Show("Mandatory field!")
        '    e.Cancel = True
        'End If
    End Sub

    Private Sub vItemUnit_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub vItemUnit_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Trim(vItemUnit.Text) = "" Then
            MessageBox.Show("Mandatory field!")
            e.Cancel = True
        End If
    End Sub

    Private Sub vUnitConversion_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
        'If NumKeys(e.KeyData) = False Then
        '    If Len(Trim(vUnitPrice.Text)) <> 0 Then
        '        vUnitPrice.Text = Mid(Trim(vUnitPrice.Text), 1, Len(Trim(vUnitPrice.Text)) - 1)
        '        vUnitPrice.SelectionStart = Len(Trim(vUnitPrice.Text))
        '        Beep()
        '    Else
        '        vUnitPrice.Text = ""
        '    End If
        'End If
    End Sub

    Private Sub vUnitConversion_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Trim(vUnitConversion.Text) = "" Or jVal(vLaunchDate.Text) = 0 Then
            Exit Sub
        End If
        If Trim(vUnitConversion.Text) <> "" Then
            If Len(Trim(vItemCode.Text)) < 6 Or Mid(Trim(vItemCode.Text), Len(Trim(vItemCode.Text)), 1) <> "L" Then
                MessageBox.Show("No UnitConversion for this Item!")
                vUnitConversion.Text = ""
            End If
        End If
    End Sub

    Private Sub vUnitPrice_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
        'If NumKeys(e.KeyData) = False Then
        '    If Len(Trim(vUnitPrice.Text)) <> 0 Then
        '        vUnitPrice.Text = Mid(Trim(vUnitPrice.Text), 1, Len(Trim(vUnitPrice.Text)) - 1)
        '        vUnitPrice.SelectionStart = Len(Trim(vUnitPrice.Text))
        '        Beep()
        '    Else
        '        vUnitPrice.Text = ""
        '    End If
        'End If
    End Sub

    Private Sub vUnitPrice_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Trim(vUnitPrice.Text) = "" Then
            MessageBox.Show("Mandatory field!")
            e.Cancel = True
        End If
    End Sub

    Private Sub vMercurySTPrice_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
        'If NumKeys(e.KeyData) = False Then
        '    If Len(Trim(vMercurySTPrice.Text)) <> 0 Then
        '        vMercurySTPrice.Text = Mid(Trim(vMercurySTPrice.Text), 1, Len(Trim(vMercurySTPrice.Text)) - 1)
        '        vMercurySTPrice.SelectionStart = Len(Trim(vMercurySTPrice.Text))
        '        Beep()
        '    Else
        '        vMercurySTPrice.Text = ""
        '    End If
        'End If
    End Sub

    Private Sub cboPrincipal_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyData.ToString = System.Windows.Forms.Keys.Up.ToString _
           Or e.KeyData.ToString = System.Windows.Forms.Keys.Left.ToString Then 'if key pressed is the up arrow it will select the next selection before the selction
            cboPrincipal.SelectedItem = cboPrincipal.SelectedIndex - 1
        ElseIf e.KeyData.ToString = System.Windows.Forms.Keys.Down.ToString _
           Or e.KeyData.ToString = System.Windows.Forms.Keys.Right.ToString Then 'if key pressed is the up arrow it will select the next selection after the selction
            cboPrincipal.SelectedItem = cboPrincipal.SelectedIndex + 1
        ElseIf DKcodes(e.KeyData) = True Then    'checking if the key pressed is alphanumeric (to disallow typing the entry)
            cboPrincipal.Text = ""     'if alphanumeric then the value of the field will be erased
        End If
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")      'moves control to the next control or field
        End If
    End Sub

    Private Sub cboPrincipal_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Trim(cboPrincipal.Text) = "" Then    'tests if entry is blank
            MessageBox.Show("Mandatory field!", "Critical!")  'gives message to put value
            e.Cancel() = True                  ' brings back the focus on this control/field
        End If
    End Sub

    Private Sub cboDivision_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyData.ToString = System.Windows.Forms.Keys.Up.ToString _
           Or e.KeyData.ToString = System.Windows.Forms.Keys.Left.ToString Then 'if key pressed is the up arrow it will select the next selection before the selction
            cboDivision.SelectedItem = cboDivision.SelectedIndex - 1
        ElseIf e.KeyData.ToString = System.Windows.Forms.Keys.Down.ToString _
           Or e.KeyData.ToString = System.Windows.Forms.Keys.Right.ToString Then 'if key pressed is the up arrow it will select the next selection after the selction
            cboDivision.SelectedItem = cboDivision.SelectedIndex + 1
        ElseIf DKcodes(e.KeyData) = True Then    'checking if the key pressed is alphanumeric (to disallow typing the entry)
            cboDivision.Text = ""     'if alphanumeric then the value of the field will be erased
        End If
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")      'moves control to the next control or field
        End If
    End Sub

    Private Sub cboDivision_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Trim(cboDivision.Text) = "" Then    'tests if entry is blank
            MessageBox.Show("Mandatory field!", "Critical!")  'gives message to put value
            e.Cancel() = True                  ' brings back the focus on this control/field
        End If
    End Sub
    Private Sub cboProductLine_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Trim(cboProductLine.Text) = "" Then    'tests if entry is blank
            MessageBox.Show("Mandatory field!", "Critical!")  'gives message to put value
            e.Cancel() = True                  ' brings back the focus on this control/field
        End If
    End Sub
    Private Sub cboProductForm_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Trim(cboProductForm.Text) = "" Then    'tests if entry is blank
            MessageBox.Show("Mandatory field!", "Critical!")  'gives message to put value
            e.Cancel() = True                  ' brings back the focus on this control/field
        End If
    End Sub
    Private Sub vProductLine_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub vProductLine_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Trim(vProductLine.Text) = "" Then
            MessageBox.Show("Mandatory field!")
            e.Cancel = True
        End If
    End Sub

    Private Sub vProductForm_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub vProductForm_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Trim(vProductForm.Text) = "" Then
            MessageBox.Show("Mandatory field!")
            e.Cancel = True
        End If
    End Sub

    Private Sub cboStatus_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyData.ToString = System.Windows.Forms.Keys.Up.ToString _
           Or e.KeyData.ToString = System.Windows.Forms.Keys.Left.ToString Then 'if key pressed is the up arrow it will select the next selection before the selction
            cboStatus.SelectedItem = cboStatus.SelectedIndex - 1
        ElseIf e.KeyData.ToString = System.Windows.Forms.Keys.Down.ToString _
           Or e.KeyData.ToString = System.Windows.Forms.Keys.Right.ToString Then 'if key pressed is the up arrow it will select the next selection after the selction
            cboStatus.SelectedItem = cboStatus.SelectedIndex + 1
        ElseIf DKcodes(e.KeyData) = True Then    'checking if the key pressed is alphanumeric (to disallow typing the entry)
            cboStatus.Text = ""     'if alphanumeric then the value of the field will be erased
        End If
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")      'moves control to the next control or field
        End If
    End Sub

    Private Sub cboStatus_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Trim(cboStatus.Text) = "" Then    'tests if entry is blank
            MessageBox.Show("Mandatory field!", "Critical!")  'gives message to put value
            e.Cancel() = True                'bringing back the focus to this field
        Else
            If Trim(cboStatus.Text) = "INACTIVE" Then
                If Trim(vLaunchDate.Text) <> "" Then
                    vInActiveDate.Enabled = True
                    vInActiveDate.BackColor = System.Drawing.Color.White
                    vInActiveDate.Select()
                Else
                    MessageBox.Show("There's no Launch date yet!")
                    cboStatus.Text = "ACTIVE"
                End If
            ElseIf Trim(cboStatus.Text) = "ACTIVE" Then
                vInActiveDate.Text = ""
                vInActiveDate.Enabled = False
                vInActiveDate.BackColor = System.Drawing.Color.LightYellow
            End If
        End If
    End Sub

    Private Sub vLaunchDate_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub vLaunchDate_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        On Error GoTo errpt
        If Trim(vLaunchDate.Text) = "" Then
            Exit Sub
        Else
            vLaunchDate.Text = DatValid(vLaunchDate.Text)
            If Trim(vLaunchDate.Text) = "mm/dd/yyyy" Then
                GoTo errpt
            Else
                tmpLD = Format(CDate(vLaunchDate.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
                Exit Sub
            End If
        End If
errpt:
        e.Cancel = True
    End Sub

    Private Sub vInActiveDate_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")      'moves control to the next control or field
        End If
    End Sub

    Private Sub vInActiveDate_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        On Error GoTo errpt
        If Trim(vInActiveDate.Text) = "" Then
            Exit Sub
        Else
            vInActiveDate.Text = DatValid(vInActiveDate.Text)
            If Trim(vInActiveDate.Text) = "mm/dd/yyyy" Then
                GoTo errpt
            Else
                If Trim(vLaunchDate.Text) <> "" Then
                    If CDate(vLaunchDate.Text) < CDate(vInActiveDate.Text) Then
                        tmpID = Format(CDate(vInActiveDate.Text), "M/d/yyyy") & " " & GetDateTimeNow("h:mm:ss tt")
                        vInActiveDate.Enabled = False
                        vInActiveDate.BackColor = System.Drawing.Color.LightYellow
                        Exit Sub
                    ElseIf CDate(vLaunchDate.Text) > CDate(vInActiveDate.Text) Then
                        MessageBox.Show("The Inactivity date should be later than the Launch date!")
                    End If
                End If
            End If
        End If
errpt:
        e.Cancel = True
    End Sub

    Private Sub vLine_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmdCancel_itm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel_itm.Click
        Close()
    End Sub

    Private Sub vItemCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vItemCode.TextChanged
        Dim Item_Code As String
        Item_Code = vItemCode.Text.Trim()
        If Item_Code.LastIndexOf("L") > 0 Then
            vDimcode.Text = "LS-" + Item_Code.Substring(0, Item_Code.Length - 1)
        Else
            vDimcode.Text = "FG-" + Item_Code
        End If
    End Sub


End Class