Imports System.Data.SqlClient
Imports Microsoft

Public Class Itm_Entry
    Inherits System.Windows.Forms.Form
    Private RemoteDataSet As New CodeTablesDS
    Private RemoteDataSet2 As New MyDataSetDB
    Private EditMode As Boolean = False
    Private oldDs As String, tmpLD As String, tmpID As String
    Public Minus1 As Boolean
    Public r As String
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
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents vUpdateDate As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents vCreateDate As System.Windows.Forms.TextBox
    Friend WithEvents vDivCode As System.Windows.Forms.TextBox
    Friend WithEvents vPrinCode As System.Windows.Forms.TextBox
    Friend WithEvents vLastUser As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents vUnitConversion As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdSave_itm As System.Windows.Forms.Button
    Friend WithEvents cmdCancel_itm As System.Windows.Forms.Button
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
    Friend WithEvents vRowId As System.Windows.Forms.TextBox
    Friend WithEvents cboDivision As System.Windows.Forms.ComboBox
    Friend WithEvents cboPrincipal As System.Windows.Forms.ComboBox
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents vInActiveDate As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents SqlValue As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label18 = New System.Windows.Forms.Label
        Me.vUpdateDate = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.vCreateDate = New System.Windows.Forms.TextBox
        Me.vDivCode = New System.Windows.Forms.TextBox
        Me.vPrinCode = New System.Windows.Forms.TextBox
        Me.vLastUser = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.vUnitConversion = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdSave_itm = New System.Windows.Forms.Button
        Me.cmdCancel_itm = New System.Windows.Forms.Button
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
        Me.vRowId = New System.Windows.Forms.TextBox
        Me.cboDivision = New System.Windows.Forms.ComboBox
        Me.cboPrincipal = New System.Windows.Forms.ComboBox
        Me.cboStatus = New System.Windows.Forms.ComboBox
        Me.vInActiveDate = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.SqlValue = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label18.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(475, 204)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(84, 19)
        Me.Label18.TabIndex = 133
        Me.Label18.Text = "Update Date."
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'vUpdateDate
        '
        Me.vUpdateDate.BackColor = System.Drawing.SystemColors.Info
        Me.vUpdateDate.Enabled = False
        Me.vUpdateDate.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vUpdateDate.Location = New System.Drawing.Point(562, 204)
        Me.vUpdateDate.Name = "vUpdateDate"
        Me.vUpdateDate.Size = New System.Drawing.Size(308, 20)
        Me.vUpdateDate.TabIndex = 132
        Me.vUpdateDate.Tag = "INPUT"
        Me.vUpdateDate.Text = ""
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label17.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(475, 180)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(84, 19)
        Me.Label17.TabIndex = 131
        Me.Label17.Text = "Create Date."
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'vCreateDate
        '
        Me.vCreateDate.BackColor = System.Drawing.SystemColors.Info
        Me.vCreateDate.Enabled = False
        Me.vCreateDate.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vCreateDate.Location = New System.Drawing.Point(562, 180)
        Me.vCreateDate.Name = "vCreateDate"
        Me.vCreateDate.Size = New System.Drawing.Size(308, 20)
        Me.vCreateDate.TabIndex = 130
        Me.vCreateDate.Tag = "INPUT"
        Me.vCreateDate.Text = ""
        '
        'vDivCode
        '
        Me.vDivCode.Location = New System.Drawing.Point(183, 240)
        Me.vDivCode.Name = "vDivCode"
        Me.vDivCode.Size = New System.Drawing.Size(55, 20)
        Me.vDivCode.TabIndex = 129
        Me.vDivCode.Tag = ""
        Me.vDivCode.Text = ""
        Me.vDivCode.Visible = False
        '
        'vPrinCode
        '
        Me.vPrinCode.Location = New System.Drawing.Point(119, 239)
        Me.vPrinCode.Name = "vPrinCode"
        Me.vPrinCode.Size = New System.Drawing.Size(59, 20)
        Me.vPrinCode.TabIndex = 128
        Me.vPrinCode.Tag = ""
        Me.vPrinCode.Text = ""
        Me.vPrinCode.Visible = False
        '
        'vLastUser
        '
        Me.vLastUser.Location = New System.Drawing.Point(59, 237)
        Me.vLastUser.Name = "vLastUser"
        Me.vLastUser.Size = New System.Drawing.Size(56, 20)
        Me.vLastUser.TabIndex = 127
        Me.vLastUser.Tag = ""
        Me.vLastUser.Text = ""
        Me.vLastUser.Visible = False
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 156)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 19)
        Me.Label9.TabIndex = 126
        Me.Label9.Text = "Unit Conversion."
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'vUnitConversion
        '
        Me.vUnitConversion.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vUnitConversion.Location = New System.Drawing.Point(137, 156)
        Me.vUnitConversion.MaxLength = 5
        Me.vUnitConversion.Name = "vUnitConversion"
        Me.vUnitConversion.Size = New System.Drawing.Size(313, 20)
        Me.vUnitConversion.TabIndex = 6
        Me.vUnitConversion.Tag = "INPUT"
        Me.vUnitConversion.Text = ""
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 19)
        Me.Label5.TabIndex = 124
        Me.Label5.Text = "Unit."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(475, 156)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 19)
        Me.Label10.TabIndex = 123
        Me.Label10.Text = "Status."
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(475, 132)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 19)
        Me.Label11.TabIndex = 122
        Me.Label11.Text = "InActive Date."
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(475, 108)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 19)
        Me.Label12.TabIndex = 121
        Me.Label12.Text = "Launch Date."
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(475, 84)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 19)
        Me.Label13.TabIndex = 120
        Me.Label13.Text = "Product Form."
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(475, 60)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(84, 19)
        Me.Label14.TabIndex = 119
        Me.Label14.Text = "Product Line."
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label15.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(475, 36)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(84, 19)
        Me.Label15.TabIndex = 118
        Me.Label15.Text = "Current Division."
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label16.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(475, 12)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 19)
        Me.Label16.TabIndex = 117
        Me.Label16.Text = "Current Principal."
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 19)
        Me.Label6.TabIndex = 116
        Me.Label6.Text = "Current Mercury Price(ST)."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 19)
        Me.Label7.TabIndex = 115
        Me.Label7.Text = "Current Price(SRP)."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 19)
        Me.Label8.TabIndex = 114
        Me.Label8.Text = "Generic Name."
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 19)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "Brand Description."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 19)
        Me.Label4.TabIndex = 112
        Me.Label4.Text = "Mercury Item Code."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 19)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "Metro Drug Code."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 19)
        Me.Label1.TabIndex = 110
        Me.Label1.Text = "Item Code."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdSave_itm
        '
        Me.cmdSave_itm.Location = New System.Drawing.Point(450, 232)
        Me.cmdSave_itm.Name = "cmdSave_itm"
        Me.cmdSave_itm.Size = New System.Drawing.Size(147, 23)
        Me.cmdSave_itm.TabIndex = 15
        Me.cmdSave_itm.Tag = "Save"
        Me.cmdSave_itm.Text = "Save"
        '
        'cmdCancel_itm
        '
        Me.cmdCancel_itm.Location = New System.Drawing.Point(285, 232)
        Me.cmdCancel_itm.Name = "cmdCancel_itm"
        Me.cmdCancel_itm.Size = New System.Drawing.Size(147, 23)
        Me.cmdCancel_itm.TabIndex = 16
        Me.cmdCancel_itm.Tag = "Cancel"
        Me.cmdCancel_itm.Text = "Cancel"
        '
        'vItemUnit
        '
        Me.vItemUnit.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vItemUnit.Location = New System.Drawing.Point(137, 132)
        Me.vItemUnit.MaxLength = 20
        Me.vItemUnit.Name = "vItemUnit"
        Me.vItemUnit.Size = New System.Drawing.Size(313, 20)
        Me.vItemUnit.TabIndex = 5
        Me.vItemUnit.Tag = "INPUT"
        Me.vItemUnit.Text = ""
        '
        'vLaunchDate
        '
        Me.vLaunchDate.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vLaunchDate.Location = New System.Drawing.Point(562, 108)
        Me.vLaunchDate.MaxLength = 10
        Me.vLaunchDate.Name = "vLaunchDate"
        Me.vLaunchDate.Size = New System.Drawing.Size(308, 20)
        Me.vLaunchDate.TabIndex = 13
        Me.vLaunchDate.Tag = "INPUT"
        Me.vLaunchDate.Text = ""
        '
        'vProductForm
        '
        Me.vProductForm.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vProductForm.Location = New System.Drawing.Point(562, 84)
        Me.vProductForm.MaxLength = 40
        Me.vProductForm.Name = "vProductForm"
        Me.vProductForm.Size = New System.Drawing.Size(308, 20)
        Me.vProductForm.TabIndex = 12
        Me.vProductForm.Tag = "INPUT"
        Me.vProductForm.Text = ""
        '
        'vProductLine
        '
        Me.vProductLine.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vProductLine.Location = New System.Drawing.Point(562, 60)
        Me.vProductLine.MaxLength = 40
        Me.vProductLine.Name = "vProductLine"
        Me.vProductLine.Size = New System.Drawing.Size(308, 20)
        Me.vProductLine.TabIndex = 11
        Me.vProductLine.Tag = "INPUT"
        Me.vProductLine.Text = ""
        '
        'vMercurySTPrice
        '
        Me.vMercurySTPrice.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vMercurySTPrice.Location = New System.Drawing.Point(137, 204)
        Me.vMercurySTPrice.MaxLength = 25
        Me.vMercurySTPrice.Name = "vMercurySTPrice"
        Me.vMercurySTPrice.Size = New System.Drawing.Size(313, 20)
        Me.vMercurySTPrice.TabIndex = 8
        Me.vMercurySTPrice.Tag = "INPUT"
        Me.vMercurySTPrice.Text = ""
        '
        'vUnitPrice
        '
        Me.vUnitPrice.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vUnitPrice.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.vUnitPrice.Location = New System.Drawing.Point(137, 180)
        Me.vUnitPrice.MaxLength = 25
        Me.vUnitPrice.Name = "vUnitPrice"
        Me.vUnitPrice.Size = New System.Drawing.Size(313, 20)
        Me.vUnitPrice.TabIndex = 7
        Me.vUnitPrice.Tag = "INPUT"
        Me.vUnitPrice.Text = ""
        '
        'vGenericName
        '
        Me.vGenericName.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vGenericName.Location = New System.Drawing.Point(137, 108)
        Me.vGenericName.MaxLength = 40
        Me.vGenericName.Name = "vGenericName"
        Me.vGenericName.Size = New System.Drawing.Size(313, 20)
        Me.vGenericName.TabIndex = 4
        Me.vGenericName.Tag = "INPUT"
        Me.vGenericName.Text = ""
        '
        'vItemDesc
        '
        Me.vItemDesc.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vItemDesc.Location = New System.Drawing.Point(137, 84)
        Me.vItemDesc.MaxLength = 150
        Me.vItemDesc.Name = "vItemDesc"
        Me.vItemDesc.Size = New System.Drawing.Size(313, 20)
        Me.vItemDesc.TabIndex = 3
        Me.vItemDesc.Tag = "INPUT"
        Me.vItemDesc.Text = ""
        '
        'vMercuryItemCode
        '
        Me.vMercuryItemCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.vMercuryItemCode.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vMercuryItemCode.Location = New System.Drawing.Point(137, 60)
        Me.vMercuryItemCode.MaxLength = 6
        Me.vMercuryItemCode.Name = "vMercuryItemCode"
        Me.vMercuryItemCode.Size = New System.Drawing.Size(313, 20)
        Me.vMercuryItemCode.TabIndex = 2
        Me.vMercuryItemCode.Tag = "INPUT"
        Me.vMercuryItemCode.Text = ""
        '
        'vMetroDrugCode
        '
        Me.vMetroDrugCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.vMetroDrugCode.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vMetroDrugCode.Location = New System.Drawing.Point(137, 36)
        Me.vMetroDrugCode.MaxLength = 5
        Me.vMetroDrugCode.Name = "vMetroDrugCode"
        Me.vMetroDrugCode.Size = New System.Drawing.Size(313, 20)
        Me.vMetroDrugCode.TabIndex = 1
        Me.vMetroDrugCode.Tag = "INPUT"
        Me.vMetroDrugCode.Text = ""
        '
        'vItemCode
        '
        Me.vItemCode.BackColor = System.Drawing.SystemColors.Window
        Me.vItemCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.vItemCode.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vItemCode.Location = New System.Drawing.Point(137, 12)
        Me.vItemCode.MaxLength = 10
        Me.vItemCode.Name = "vItemCode"
        Me.vItemCode.Size = New System.Drawing.Size(313, 20)
        Me.vItemCode.TabIndex = 0
        Me.vItemCode.Tag = "INPUT"
        Me.vItemCode.Text = ""
        '
        'vRowId
        '
        Me.vRowId.Location = New System.Drawing.Point(6, 236)
        Me.vRowId.Name = "vRowId"
        Me.vRowId.Size = New System.Drawing.Size(48, 20)
        Me.vRowId.TabIndex = 106
        Me.vRowId.Tag = ""
        Me.vRowId.Text = ""
        Me.vRowId.Visible = False
        '
        'cboDivision
        '
        Me.cboDivision.Location = New System.Drawing.Point(562, 36)
        Me.cboDivision.MaxLength = 55
        Me.cboDivision.Name = "cboDivision"
        Me.cboDivision.Size = New System.Drawing.Size(308, 21)
        Me.cboDivision.TabIndex = 10
        Me.cboDivision.Tag = "Input"
        '
        'cboPrincipal
        '
        Me.cboPrincipal.Location = New System.Drawing.Point(562, 12)
        Me.cboPrincipal.MaxLength = 55
        Me.cboPrincipal.Name = "cboPrincipal"
        Me.cboPrincipal.Size = New System.Drawing.Size(308, 21)
        Me.cboPrincipal.TabIndex = 9
        Me.cboPrincipal.Tag = "Input"
        '
        'cboStatus
        '
        Me.cboStatus.Items.AddRange(New Object() {"", "ACTIVE", "INACTIVE"})
        Me.cboStatus.Location = New System.Drawing.Point(562, 156)
        Me.cboStatus.MaxLength = 10
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(308, 21)
        Me.cboStatus.TabIndex = 14
        Me.cboStatus.Tag = "Input"
        '
        'vInActiveDate
        '
        Me.vInActiveDate.BackColor = System.Drawing.SystemColors.Info
        Me.vInActiveDate.Enabled = False
        Me.vInActiveDate.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vInActiveDate.Location = New System.Drawing.Point(562, 132)
        Me.vInActiveDate.Name = "vInActiveDate"
        Me.vInActiveDate.Size = New System.Drawing.Size(308, 20)
        Me.vInActiveDate.TabIndex = 137
        Me.vInActiveDate.Tag = "INPUT"
        Me.vInActiveDate.Text = ""
        '
        'Label19
        '
        Me.Label19.ForeColor = System.Drawing.Color.Blue
        Me.Label19.Location = New System.Drawing.Point(691, 246)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(184, 14)
        Me.Label19.TabIndex = 139
        Me.Label19.Text = "ex.  ""112595"" = ""Nov.25,1995"""
        '
        'Label20
        '
        Me.Label20.ForeColor = System.Drawing.Color.Blue
        Me.Label20.Location = New System.Drawing.Point(691, 231)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(192, 14)
        Me.Label20.TabIndex = 138
        Me.Label20.Text = "Easy Date Format Entry: ""MMDDYY"""
        '
        'SqlValue
        '
        Me.SqlValue.Location = New System.Drawing.Point(282, 259)
        Me.SqlValue.Name = "SqlValue"
        Me.SqlValue.Size = New System.Drawing.Size(146, 21)
        Me.SqlValue.TabIndex = 140
        Me.SqlValue.Visible = False
        '
        'Itm_Entry
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(889, 266)
        Me.Controls.Add(Me.SqlValue)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.vInActiveDate)
        Me.Controls.Add(Me.vUpdateDate)
        Me.Controls.Add(Me.vCreateDate)
        Me.Controls.Add(Me.vDivCode)
        Me.Controls.Add(Me.vPrinCode)
        Me.Controls.Add(Me.vLastUser)
        Me.Controls.Add(Me.vUnitConversion)
        Me.Controls.Add(Me.vItemUnit)
        Me.Controls.Add(Me.vLaunchDate)
        Me.Controls.Add(Me.vProductForm)
        Me.Controls.Add(Me.vProductLine)
        Me.Controls.Add(Me.vMercurySTPrice)
        Me.Controls.Add(Me.vUnitPrice)
        Me.Controls.Add(Me.vGenericName)
        Me.Controls.Add(Me.vItemDesc)
        Me.Controls.Add(Me.vMercuryItemCode)
        Me.Controls.Add(Me.vMetroDrugCode)
        Me.Controls.Add(Me.vItemCode)
        Me.Controls.Add(Me.vRowId)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.cboPrincipal)
        Me.Controls.Add(Me.cboDivision)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdSave_itm)
        Me.Controls.Add(Me.cmdCancel_itm)
        Me.Name = "Itm_Entry"
        Me.ShowInTaskbar = False
        Me.Text = "Items Entry"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Itm_Entry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlMaintenance.ClearInputControls(Me)
        If Itm_EditMode = True Then
            vItemCode.ReadOnly = True
            oldDs = Trim(vItemDesc.Text)
            vItemDesc.Select()
            vItemDesc.SelectAll()
            cboPrincipal.Text = Filds(11).ToString
            cboDivision.Text = Filds(13).ToString
            cboStatus.Text = Filds(18).ToString
        Else
            ControlMaintenance.ClearInputControls(Me)
            EditMode = False
            btnSw = True
            vItemCode.Enabled = True
            vItemCode.Select()
        End If
    End Sub

    Private Sub Load_Division()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "Division_Combo", CommandType.StoredProcedure, RemoteDataSet, "Division_Combo")
        cboDivision.DataSource = RemoteDataSet.Division_Combo
        cboDivision.DisplayMember = "Division"
    End Sub

    Private Sub Load_Principal()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "Principal_Combo", CommandType.StoredProcedure, RemoteDataSet, "Principal_Combo")
        cboPrincipal.DataSource = RemoteDataSet.Principal_Combo
        cboPrincipal.DisplayMember = "Principal"
    End Sub

    Private Sub cmdCancel_itm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel_itm.Click
        Close()
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
            MyLoadedForm.DG_items.DataSource = Nothing
            MyLoadedForm.DG_items.Refresh()
            MyLoadedForm.DG_ipc.DataSource = Nothing
            MyLoadedForm.DG_ipc.Refresh()
            MyLoadedForm.DG_div.DataSource = Nothing
            MyLoadedForm.DG_div.Refresh()
            MyLoadedForm.DG_prin.DataSource = Nothing
            MyLoadedForm.DG_prin.Refresh()
            MyLoadedForm.DG_nsm.DataSource = Nothing
            MyLoadedForm.DG_nsm.Refresh()
            MyLoadedForm.DG_pm.DataSource = Nothing
            MyLoadedForm.DG_pm.Refresh()
            'MyLoadedForm.Itm_Sub_Show()
            'Sub_Select(Params, CStr(IIf(Itm_EditMode = False, "Insert", "Update")))
            Itm_EditMode = False
            'modControlBehavior.EnableControls(Me, False)
            Close()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Sub_Insert()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(18) As SqlParameter

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
        ItemUnit.Value = jTrim(vItemUnit.Text)
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

        Dim MetroDrugCode As New SqlParameter("@MetroDrugCode", SqlDbType.VarChar, 5)
        MetroDrugCode.Direction = ParameterDirection.Input
        MetroDrugCode.Value = jTrim(vMetroDrugCode.Text)
        Params(14) = MetroDrugCode

        Dim MercuryItemCode As New SqlParameter("@MercuryItemCode", SqlDbType.VarChar, 10)
        MercuryItemCode.Direction = ParameterDirection.Input
        MercuryItemCode.Value = jTrim(vMercuryItemCode.Text)
        Params(15) = MercuryItemCode

        Dim LastUser As New SqlParameter("@LastUser", SqlDbType.VarChar, 8)
        LastUser.Direction = ParameterDirection.Input
        LastUser.Value = IIf(Trim(gCurrUser) = "", "", gCurrUser)       ' jTrim(vLastUser.Text)
        Params(16) = LastUser

        Dim Status As New SqlParameter("@Status", SqlDbType.VarChar, 7)
        Status.Direction = ParameterDirection.Input
        Status.Value = jTrim(cboStatus.Text)
        Params(17) = Status

        Dim UnitConversion As New SqlParameter("@UnitConversion", SqlDbType.SmallInt)
        UnitConversion.Direction = ParameterDirection.Input
        UnitConversion.Value = jVal(Trim(vUnitConversion.Text))
        Params(18) = UnitConversion

        Try
            BusinessObject.Sub_Insert(ServerPath2, "ItemCT_Insert", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Close()
    End Sub

    Private Sub Sub_Update()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(17) As SqlParameter

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
        ItemUnit.Value = jTrim(vItemUnit.Text)
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

        Dim GenericName As New SqlParameter("@GenericName", SqlDbType.VarChar, 40)
        GenericName.Direction = ParameterDirection.Input
        GenericName.Value = jTrim(vGenericName.Text)
        Params(9) = GenericName

        Dim MercurySTprice As New SqlParameter("@MercurySTprice", SqlDbType.Money)
        MercurySTprice.Direction = ParameterDirection.Input
        MercurySTprice.Value = jVal(Trim(vMercurySTPrice.Text))
        Params(10) = MercurySTprice

        Dim LaunchDate As New SqlParameter("@LaunchDate", SqlDbType.DateTime, 10)
        LaunchDate.Direction = ParameterDirection.Input
        If jTrim(vLaunchDate.Text) = "" Then
            LaunchDate.Value = DBNull.Value
        Else
            LaunchDate.Value = tmpLD
        End If
        Params(11) = LaunchDate

        Dim InactiveDate As New SqlParameter("@InactiveDate", SqlDbType.DateTime, 10)
        InactiveDate.Direction = ParameterDirection.Input
        If jTrim(vInActiveDate.Text) = "" Then
            InactiveDate.Value = DBNull.Value
        Else
            InactiveDate.Value = tmpID
        End If
        Params(12) = InactiveDate

        Dim MetroDrugCode As New SqlParameter("@MetroDrugCode", SqlDbType.VarChar, 5)
        MetroDrugCode.Direction = ParameterDirection.Input
        MetroDrugCode.Value = jTrim(vMetroDrugCode.Text)
        Params(13) = MetroDrugCode

        Dim MercuryItemCode As New SqlParameter("@MercuryItemCode", SqlDbType.VarChar, 10)
        MercuryItemCode.Direction = ParameterDirection.Input
        MercuryItemCode.Value = jTrim(vMercuryItemCode.Text)
        Params(14) = MercuryItemCode

        Dim LastUser As New SqlParameter("@LastUser", SqlDbType.VarChar, 8)
        LastUser.Direction = ParameterDirection.Input
        LastUser.Value = IIf(Trim(gCurrUser) = "", "", gCurrUser)     ' jTrim(vLastUser.Text)
        Params(15) = LastUser

        Dim Status As New SqlParameter("@Status", SqlDbType.VarChar, 7)
        Status.Direction = ParameterDirection.Input
        Status.Value = jTrim(cboStatus.Text)
        Params(16) = Status

        Dim UnitConversion As New SqlParameter("@UnitConversion", SqlDbType.SmallInt)
        UnitConversion.Direction = ParameterDirection.Input
        UnitConversion.Value = jVal(Trim(vUnitConversion.Text))
        Params(17) = UnitConversion

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
        vLaunchDate.Text = Filds(16).ToString
        vInActiveDate.Text() = Filds(17).ToString
        cboStatus.Text = Filds(18).ToString
        vUpdateDate.Text = Filds(19).ToString
    End Sub

    Private Sub vItemCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vItemCode.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub vItemCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles vItemCode.Validating
        Dim s As String
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter
        If Trim(vItemCode.Text) = "" Then
            vItemDesc.Select()
            Exit Sub
        End If
        If btnSw = True And EditMode = False Then
            s = "select itemdesc as fld1 from NewScores..Item where itemcode = '" & Trim(vItemCode.Text) & "' "
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

    Private Sub vItemDesc_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vItemDesc.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub vItemDesc_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles vItemDesc.Validating
        Dim s As String
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter
        If Trim(vItemDesc.Text) = "" Then
            vItemCode.Select()
            Exit Sub
        End If
        If btnSw = True And Trim(vItemDesc.Text) <> Trim(oldDs) Then
            s = "select itemcode as fld1 from NewScores..Item where itemdesc = '" & Trim(vItemDesc.Text) & "' "
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
                vItemDesc.Clear()
            End If
            SqlValue.ResetText()
            SqlValue.DataSource = Nothing
            RemoteDataSet2.GenericQryProc.Clear()
        End If
    End Sub

    Private Sub vMetroDrugCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vMetroDrugCode.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
        If NumKeys(e.KeyData, "INT") = False Then
            If Len(Trim(vMetroDrugCode.Text)) <> 0 Then
                vMetroDrugCode.Text = Mid(Trim(vMetroDrugCode.Text), 1, Len(Trim(vMetroDrugCode.Text)) - 1)
                vMetroDrugCode.SelectionStart = Len(Trim(vMetroDrugCode.Text))
                Beep()
            Else
                vMetroDrugCode.Text = ""
            End If
        End If
    End Sub

    Private Sub vMetroDrugCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles vMetroDrugCode.Validating
        Dim s As String
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter
        If Trim(vMetroDrugCode.Text) = "" Then
            Exit Sub
        End If
        If btnSw = True And EditMode = False Then
            s = "select itemdesc as fld1 from NewScores..Item "
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

    Private Sub vMercuryItemCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vMercuryItemCode.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub vMercuryItemCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles vMercuryItemCode.Validating
        Dim s As String
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter
        If Trim(vMercuryItemCode.Text) = "" Then
            Exit Sub
        End If
        If btnSw = True And EditMode = False Then
            s = "select itemdesc as fld1 from NewScores..Item "
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

    Private Sub vGenericName_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vGenericName.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub vGenericName_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles vGenericName.Validating
        If Trim(vGenericName.Text) = "" Then
            MessageBox.Show("Mandatory field!")
            e.Cancel = True
        End If
    End Sub

    Private Sub vItemUnit_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vItemUnit.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub vItemUnit_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles vItemUnit.Validating
        If Trim(vItemUnit.Text) = "" Then
            MessageBox.Show("Mandatory field!")
            e.Cancel = True
        End If
    End Sub

    Private Sub vUnitConversion_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vUnitConversion.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
        If NumKeys(e.KeyData) = False Then
            If Len(Trim(vUnitPrice.Text)) <> 0 Then
                vUnitPrice.Text = Mid(Trim(vUnitPrice.Text), 1, Len(Trim(vUnitPrice.Text)) - 1)
                vUnitPrice.SelectionStart = Len(Trim(vUnitPrice.Text))
                Beep()
            Else
                vUnitPrice.Text = ""
            End If
        End If
    End Sub

    Private Sub vUnitConversion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles vUnitConversion.Validating
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

    Private Sub vUnitPrice_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vUnitPrice.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
        If NumKeys(e.KeyData) = False Then
            If Len(Trim(vUnitPrice.Text)) <> 0 Then
                vUnitPrice.Text = Mid(Trim(vUnitPrice.Text), 1, Len(Trim(vUnitPrice.Text)) - 1)
                vUnitPrice.SelectionStart = Len(Trim(vUnitPrice.Text))
                Beep()
            Else
                vUnitPrice.Text = ""
            End If
        End If
    End Sub

    Private Sub vUnitPrice_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles vUnitPrice.Validating
        If Trim(vUnitPrice.Text) = "" Then
            MessageBox.Show("Mandatory field!")
            e.Cancel = True
        End If
    End Sub

    Private Sub vMercurySTPrice_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vMercurySTPrice.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
        If NumKeys(e.KeyData) = False Then
            If Len(Trim(vMercurySTPrice.Text)) <> 0 Then
                vMercurySTPrice.Text = Mid(Trim(vMercurySTPrice.Text), 1, Len(Trim(vMercurySTPrice.Text)) - 1)
                vMercurySTPrice.SelectionStart = Len(Trim(vMercurySTPrice.Text))
                Beep()
            Else
                vMercurySTPrice.Text = ""
            End If
        End If
    End Sub

    Private Sub cboPrincipal_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboPrincipal.KeyUp
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

    Private Sub cboPrincipal_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboPrincipal.Validating
        If Trim(cboPrincipal.Text) = "" Then    'tests if entry is blank
            MessageBox.Show("Mandatory field!", "Critical!")  'gives message to put value
            e.Cancel() = True                  ' brings back the focus on this control/field
        End If
    End Sub

    Private Sub cboDivision_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboDivision.KeyUp
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

    Private Sub cboDivision_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboDivision.Validating
        If Trim(cboDivision.Text) = "" Then    'tests if entry is blank
            MessageBox.Show("Mandatory field!", "Critical!")  'gives message to put value
            e.Cancel() = True                  ' brings back the focus on this control/field
        End If
    End Sub

    Private Sub vProductLine_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vProductLine.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub vProductLine_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles vProductLine.Validating
        If Trim(vProductLine.Text) = "" Then
            MessageBox.Show("Mandatory field!")
            e.Cancel = True
        End If
    End Sub

    Private Sub vProductForm_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vProductForm.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub vProductForm_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles vProductForm.Validating
        If Trim(vProductForm.Text) = "" Then
            MessageBox.Show("Mandatory field!")
            e.Cancel = True
        End If
    End Sub

    Private Sub cboStatus_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboStatus.KeyUp
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

    Private Sub cboStatus_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboStatus.Validating
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

    Private Sub vLaunchDate_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vLaunchDate.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub vLaunchDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles vLaunchDate.Validating
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

    Private Sub vInActiveDate_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vInActiveDate.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")      'moves control to the next control or field
        End If
    End Sub

    Private Sub vInActiveDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles vInActiveDate.Validating
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
End Class