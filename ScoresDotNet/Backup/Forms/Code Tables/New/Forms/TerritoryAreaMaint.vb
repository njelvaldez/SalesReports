Imports System.Data.SqlClient

Public Class frmTerritoryAreaMaint
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Splitter3 As System.Windows.Forms.Splitter
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonAddArea As System.Windows.Forms.Button
    Friend WithEvents ButtonEditArea As System.Windows.Forms.Button
    Friend WithEvents ButtonDeleteArea As System.Windows.Forms.Button
    Friend WithEvents ButtonClearArea As System.Windows.Forms.Button
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Splitter4 As System.Windows.Forms.Splitter
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonClearAreaBrick As System.Windows.Forms.Button
    Friend WithEvents ButtonDeleteAreaBrick As System.Windows.Forms.Button
    Friend WithEvents ButtonEditAreaBrick As System.Windows.Forms.Button
    Friend WithEvents ButtonAddAreaBrick As System.Windows.Forms.Button
    Friend WithEvents DataGridArea As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridAreaBrick As System.Windows.Forms.DataGrid
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Splitter5 As System.Windows.Forms.Splitter
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridAreaPMR As System.Windows.Forms.DataGrid
    Friend WithEvents ButtonClearAreaPMR As System.Windows.Forms.Button
    Friend WithEvents ButtonDeleteAreaPMR As System.Windows.Forms.Button
    Friend WithEvents ButtonEditAreaPMR As System.Windows.Forms.Button
    Friend WithEvents ButtonAddAreaPMR As System.Windows.Forms.Button
    Friend WithEvents ComboBoxAreaYear As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.DataGridAreaBrick = New System.Windows.Forms.DataGrid
        Me.Splitter4 = New System.Windows.Forms.Splitter
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.ButtonClearAreaBrick = New System.Windows.Forms.Button
        Me.ButtonDeleteAreaBrick = New System.Windows.Forms.Button
        Me.ButtonEditAreaBrick = New System.Windows.Forms.Button
        Me.ButtonAddAreaBrick = New System.Windows.Forms.Button
        Me.Splitter2 = New System.Windows.Forms.Splitter
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.DataGridAreaPMR = New System.Windows.Forms.DataGrid
        Me.Splitter5 = New System.Windows.Forms.Splitter
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.ButtonClearAreaPMR = New System.Windows.Forms.Button
        Me.ButtonDeleteAreaPMR = New System.Windows.Forms.Button
        Me.ButtonEditAreaPMR = New System.Windows.Forms.Button
        Me.ButtonAddAreaPMR = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DataGridArea = New System.Windows.Forms.DataGrid
        Me.Splitter3 = New System.Windows.Forms.Splitter
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ComboBoxAreaYear = New System.Windows.Forms.ComboBox
        Me.ButtonClearArea = New System.Windows.Forms.Button
        Me.ButtonDeleteArea = New System.Windows.Forms.Button
        Me.ButtonEditArea = New System.Windows.Forms.Button
        Me.ButtonAddArea = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridAreaBrick, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DataGridAreaPMR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridArea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Splitter2)
        Me.Panel1.Controls.Add(Me.Splitter1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(872, 549)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel8)
        Me.Panel4.Controls.Add(Me.Splitter4)
        Me.Panel4.Controls.Add(Me.Panel7)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 234)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(870, 159)
        Me.Panel4.TabIndex = 4
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.GroupBox4)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.DockPadding.Bottom = 5
        Me.Panel8.DockPadding.Left = 5
        Me.Panel8.DockPadding.Right = 3
        Me.Panel8.DockPadding.Top = 2
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(698, 159)
        Me.Panel8.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DataGridAreaBrick)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(5, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(690, 152)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        '
        'DataGridAreaBrick
        '
        Me.DataGridAreaBrick.AlternatingBackColor = System.Drawing.Color.OldLace
        Me.DataGridAreaBrick.CaptionText = "Area Brick List"
        Me.DataGridAreaBrick.DataMember = ""
        Me.DataGridAreaBrick.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridAreaBrick.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridAreaBrick.Location = New System.Drawing.Point(3, 17)
        Me.DataGridAreaBrick.Name = "DataGridAreaBrick"
        Me.DataGridAreaBrick.PreferredColumnWidth = 100
        Me.DataGridAreaBrick.ReadOnly = True
        Me.DataGridAreaBrick.Size = New System.Drawing.Size(684, 132)
        Me.DataGridAreaBrick.TabIndex = 0
        '
        'Splitter4
        '
        Me.Splitter4.BackColor = System.Drawing.SystemColors.WindowText
        Me.Splitter4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Splitter4.Location = New System.Drawing.Point(698, 0)
        Me.Splitter4.Name = "Splitter4"
        Me.Splitter4.Size = New System.Drawing.Size(2, 159)
        Me.Splitter4.TabIndex = 0
        Me.Splitter4.TabStop = False
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.GroupBox3)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.DockPadding.Bottom = 5
        Me.Panel7.DockPadding.Left = 3
        Me.Panel7.DockPadding.Right = 5
        Me.Panel7.DockPadding.Top = 2
        Me.Panel7.Location = New System.Drawing.Point(700, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(170, 159)
        Me.Panel7.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ButtonClearAreaBrick)
        Me.GroupBox3.Controls.Add(Me.ButtonDeleteAreaBrick)
        Me.GroupBox3.Controls.Add(Me.ButtonEditAreaBrick)
        Me.GroupBox3.Controls.Add(Me.ButtonAddAreaBrick)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(162, 152)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Area Brick Group"
        '
        'ButtonClearAreaBrick
        '
        Me.ButtonClearAreaBrick.Location = New System.Drawing.Point(45, 100)
        Me.ButtonClearAreaBrick.Name = "ButtonClearAreaBrick"
        Me.ButtonClearAreaBrick.Size = New System.Drawing.Size(72, 24)
        Me.ButtonClearAreaBrick.TabIndex = 8
        Me.ButtonClearAreaBrick.Text = "&Clear"
        '
        'ButtonDeleteAreaBrick
        '
        Me.ButtonDeleteAreaBrick.Location = New System.Drawing.Point(45, 76)
        Me.ButtonDeleteAreaBrick.Name = "ButtonDeleteAreaBrick"
        Me.ButtonDeleteAreaBrick.Size = New System.Drawing.Size(72, 24)
        Me.ButtonDeleteAreaBrick.TabIndex = 7
        Me.ButtonDeleteAreaBrick.Text = "&Delete"
        '
        'ButtonEditAreaBrick
        '
        Me.ButtonEditAreaBrick.Location = New System.Drawing.Point(45, 52)
        Me.ButtonEditAreaBrick.Name = "ButtonEditAreaBrick"
        Me.ButtonEditAreaBrick.Size = New System.Drawing.Size(72, 24)
        Me.ButtonEditAreaBrick.TabIndex = 6
        Me.ButtonEditAreaBrick.Text = "&Edit"
        '
        'ButtonAddAreaBrick
        '
        Me.ButtonAddAreaBrick.Location = New System.Drawing.Point(45, 28)
        Me.ButtonAddAreaBrick.Name = "ButtonAddAreaBrick"
        Me.ButtonAddAreaBrick.Size = New System.Drawing.Size(72, 24)
        Me.ButtonAddAreaBrick.TabIndex = 5
        Me.ButtonAddAreaBrick.Text = "&Add"
        '
        'Splitter2
        '
        Me.Splitter2.BackColor = System.Drawing.SystemColors.WindowText
        Me.Splitter2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Splitter2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter2.Location = New System.Drawing.Point(0, 393)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(870, 2)
        Me.Splitter2.TabIndex = 0
        Me.Splitter2.TabStop = False
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.SystemColors.WindowText
        Me.Splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 232)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(870, 2)
        Me.Splitter1.TabIndex = 0
        Me.Splitter1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel10)
        Me.Panel3.Controls.Add(Me.Splitter5)
        Me.Panel3.Controls.Add(Me.Panel9)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 395)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(870, 152)
        Me.Panel3.TabIndex = 1
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.GroupBox6)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.DockPadding.Bottom = 5
        Me.Panel10.DockPadding.Left = 5
        Me.Panel10.DockPadding.Right = 3
        Me.Panel10.DockPadding.Top = 2
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(698, 152)
        Me.Panel10.TabIndex = 2
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.DataGridAreaPMR)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox6.Location = New System.Drawing.Point(5, 2)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(690, 145)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        '
        'DataGridAreaPMR
        '
        Me.DataGridAreaPMR.AlternatingBackColor = System.Drawing.Color.Beige
        Me.DataGridAreaPMR.CaptionText = "Area Specialist List"
        Me.DataGridAreaPMR.DataMember = ""
        Me.DataGridAreaPMR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridAreaPMR.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridAreaPMR.Location = New System.Drawing.Point(3, 17)
        Me.DataGridAreaPMR.Name = "DataGridAreaPMR"
        Me.DataGridAreaPMR.PreferredColumnWidth = 100
        Me.DataGridAreaPMR.ReadOnly = True
        Me.DataGridAreaPMR.Size = New System.Drawing.Size(684, 125)
        Me.DataGridAreaPMR.TabIndex = 0
        '
        'Splitter5
        '
        Me.Splitter5.BackColor = System.Drawing.SystemColors.WindowText
        Me.Splitter5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Splitter5.Location = New System.Drawing.Point(698, 0)
        Me.Splitter5.Name = "Splitter5"
        Me.Splitter5.Size = New System.Drawing.Size(2, 152)
        Me.Splitter5.TabIndex = 1
        Me.Splitter5.TabStop = False
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.GroupBox5)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel9.DockPadding.Bottom = 5
        Me.Panel9.DockPadding.Left = 3
        Me.Panel9.DockPadding.Right = 5
        Me.Panel9.DockPadding.Top = 2
        Me.Panel9.Location = New System.Drawing.Point(700, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(170, 152)
        Me.Panel9.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.ButtonClearAreaPMR)
        Me.GroupBox5.Controls.Add(Me.ButtonDeleteAreaPMR)
        Me.GroupBox5.Controls.Add(Me.ButtonEditAreaPMR)
        Me.GroupBox5.Controls.Add(Me.ButtonAddAreaPMR)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Location = New System.Drawing.Point(3, 2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(162, 145)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Area PMR Group"
        '
        'ButtonClearAreaPMR
        '
        Me.ButtonClearAreaPMR.Location = New System.Drawing.Point(45, 96)
        Me.ButtonClearAreaPMR.Name = "ButtonClearAreaPMR"
        Me.ButtonClearAreaPMR.Size = New System.Drawing.Size(72, 24)
        Me.ButtonClearAreaPMR.TabIndex = 12
        Me.ButtonClearAreaPMR.Text = "&Clear"
        '
        'ButtonDeleteAreaPMR
        '
        Me.ButtonDeleteAreaPMR.Location = New System.Drawing.Point(45, 72)
        Me.ButtonDeleteAreaPMR.Name = "ButtonDeleteAreaPMR"
        Me.ButtonDeleteAreaPMR.Size = New System.Drawing.Size(72, 24)
        Me.ButtonDeleteAreaPMR.TabIndex = 11
        Me.ButtonDeleteAreaPMR.Text = "&Delete"
        '
        'ButtonEditAreaPMR
        '
        Me.ButtonEditAreaPMR.Location = New System.Drawing.Point(45, 48)
        Me.ButtonEditAreaPMR.Name = "ButtonEditAreaPMR"
        Me.ButtonEditAreaPMR.Size = New System.Drawing.Size(72, 24)
        Me.ButtonEditAreaPMR.TabIndex = 10
        Me.ButtonEditAreaPMR.Text = "&Edit"
        '
        'ButtonAddAreaPMR
        '
        Me.ButtonAddAreaPMR.Location = New System.Drawing.Point(45, 24)
        Me.ButtonAddAreaPMR.Name = "ButtonAddAreaPMR"
        Me.ButtonAddAreaPMR.Size = New System.Drawing.Size(72, 24)
        Me.ButtonAddAreaPMR.TabIndex = 9
        Me.ButtonAddAreaPMR.Text = "&Add"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Splitter3)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(870, 232)
        Me.Panel2.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.GroupBox2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.DockPadding.Bottom = 5
        Me.Panel6.DockPadding.Left = 5
        Me.Panel6.DockPadding.Right = 3
        Me.Panel6.DockPadding.Top = 2
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(698, 232)
        Me.Panel6.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridArea)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(5, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(690, 225)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'DataGridArea
        '
        Me.DataGridArea.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.DataGridArea.CaptionText = "Area List"
        Me.DataGridArea.DataMember = ""
        Me.DataGridArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridArea.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridArea.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridArea.Location = New System.Drawing.Point(3, 17)
        Me.DataGridArea.Name = "DataGridArea"
        Me.DataGridArea.PreferredColumnWidth = 100
        Me.DataGridArea.ReadOnly = True
        Me.DataGridArea.Size = New System.Drawing.Size(684, 205)
        Me.DataGridArea.TabIndex = 0
        '
        'Splitter3
        '
        Me.Splitter3.BackColor = System.Drawing.SystemColors.WindowText
        Me.Splitter3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Splitter3.Location = New System.Drawing.Point(698, 0)
        Me.Splitter3.Name = "Splitter3"
        Me.Splitter3.Size = New System.Drawing.Size(2, 232)
        Me.Splitter3.TabIndex = 0
        Me.Splitter3.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GroupBox1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.DockPadding.Bottom = 5
        Me.Panel5.DockPadding.Left = 3
        Me.Panel5.DockPadding.Right = 5
        Me.Panel5.DockPadding.Top = 2
        Me.Panel5.Location = New System.Drawing.Point(700, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(170, 232)
        Me.Panel5.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBoxAreaYear)
        Me.GroupBox1.Controls.Add(Me.ButtonClearArea)
        Me.GroupBox1.Controls.Add(Me.ButtonDeleteArea)
        Me.GroupBox1.Controls.Add(Me.ButtonEditArea)
        Me.GroupBox1.Controls.Add(Me.ButtonAddArea)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(162, 225)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Area Group"
        '
        'ComboBoxAreaYear
        '
        Me.ComboBoxAreaYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxAreaYear.Location = New System.Drawing.Point(11, 48)
        Me.ComboBoxAreaYear.MaxDropDownItems = 10
        Me.ComboBoxAreaYear.Name = "ComboBoxAreaYear"
        Me.ComboBoxAreaYear.Size = New System.Drawing.Size(140, 21)
        Me.ComboBoxAreaYear.TabIndex = 0
        '
        'ButtonClearArea
        '
        Me.ButtonClearArea.Location = New System.Drawing.Point(45, 168)
        Me.ButtonClearArea.Name = "ButtonClearArea"
        Me.ButtonClearArea.Size = New System.Drawing.Size(72, 24)
        Me.ButtonClearArea.TabIndex = 4
        Me.ButtonClearArea.Text = "&Clear"
        '
        'ButtonDeleteArea
        '
        Me.ButtonDeleteArea.Location = New System.Drawing.Point(45, 144)
        Me.ButtonDeleteArea.Name = "ButtonDeleteArea"
        Me.ButtonDeleteArea.Size = New System.Drawing.Size(72, 24)
        Me.ButtonDeleteArea.TabIndex = 3
        Me.ButtonDeleteArea.Text = "&Delete"
        '
        'ButtonEditArea
        '
        Me.ButtonEditArea.Location = New System.Drawing.Point(45, 120)
        Me.ButtonEditArea.Name = "ButtonEditArea"
        Me.ButtonEditArea.Size = New System.Drawing.Size(72, 24)
        Me.ButtonEditArea.TabIndex = 2
        Me.ButtonEditArea.Text = "&Edit"
        '
        'ButtonAddArea
        '
        Me.ButtonAddArea.Location = New System.Drawing.Point(45, 96)
        Me.ButtonAddArea.Name = "ButtonAddArea"
        Me.ButtonAddArea.Size = New System.Drawing.Size(72, 24)
        Me.ButtonAddArea.TabIndex = 1
        Me.ButtonAddArea.Text = "&Add"
        '
        'frmTerritoryAreaMaint
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(872, 549)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmTerritoryAreaMaint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TerritoryAreaMaint"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridAreaBrick, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.DataGridAreaPMR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridArea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private MyCodeTableDS As New CodeTablesDS
    Private BusinessObject As New BusinessLayer.clsFileMaintenance
    Private _sAreaCode, _sAreaStartDate, _sPrinCode, _sTerritoryDR, _sBrickStartDate, _
        _sMedRepCode, _sMedRepName, _sPMRStartDate As String

    Private Sub frmTerritoryAreaMaint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles MyBase.Load
        Me.AreaYearSelections()
    End Sub

    Private Sub AreaYearSelections()
        Me.Cursor = Cursors.WaitCursor
        Dim _DT As DataTable = New DataTable
        Dim _DR As DataRow

        If MyCodeTableDS.sp_area_year_selections.Count > 0 Then MyCodeTableDS.sp_area_year_selections.Clear()

        Try
            BusinessObject.Sub_Show(ServerPath, "sp_area_year_selections", CommandType.StoredProcedure, _
                MyCodeTableDS, "sp_area_year_selections")

            _DT = MyCodeTableDS.sp_area_year_selections
            _DR = _DT.NewRow()

            _DR(0) = "<- Select Area Year's ->"
            _DT.Rows.InsertAt(_DR, 0)

            With ComboBoxAreaYear
                .DataSource = _DT
                .DisplayMember = "Area Year"
                .ValueMember = "Area Year"
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub AreaList()
        Dim Params(0) As SqlParameter
        Me.Cursor = Cursors.WaitCursor
        If MyCodeTableDS.sp_area_list.Count > 0 Then MyCodeTableDS.sp_area_list.Clear()

        Try
            BusinessObject.Sub_Show(ServerPath, "sp_area_list", CommandType.StoredProcedure, _
                MyCodeTableDS, "sp_area_list")
            DataGridArea.DataSource = MyCodeTableDS.sp_area_list
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub AreaListPerYear(ByVal sAreaYear As String)
        Dim Params(0) As SqlParameter
        Me.Cursor = Cursors.WaitCursor

        If MyCodeTableDS.sp_area_list_per_year.Count > 0 Then MyCodeTableDS.sp_area_list_per_year.Clear()
        If MyCodeTableDS.sp_area_brick_list.Count > 0 Then MyCodeTableDS.sp_area_brick_list.Clear()
        If MyCodeTableDS.sp_area_pmr_list.Count > 0 Then MyCodeTableDS.sp_area_pmr_list.Clear()

        Try
            Dim _areayear As New SqlParameter("@areayear", SqlDbType.Char, 4)
            _areayear.Direction = ParameterDirection.Input
            _areayear.Value = sAreaYear
            Params(0) = _areayear

            Try
                BusinessObject.Sub_Show(ServerPath, "sp_area_list_per_year", CommandType.StoredProcedure, _
                    MyCodeTableDS, "sp_area_list_per_year", Params)
                DataGridArea.DataSource = MyCodeTableDS.sp_area_list_per_year
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub AreaBrickList(ByVal _sValue As String, ByVal _sValue1 As String)
        Me.Cursor = Cursors.WaitCursor
        Dim Params(1) As SqlParameter

        If MyCodeTableDS.sp_area_brick_list.Count > 0 Then MyCodeTableDS.sp_area_brick_list.Clear()

        Try
            Dim _areacode As New SqlParameter("@areacode", SqlDbType.Char, 10)
            _areacode.Direction = ParameterDirection.Input
            _areacode.Value = _sValue
            Params(0) = _areacode

            Dim _areastartdate As New SqlParameter("@areastartdate", SqlDbType.DateTime)
            _areastartdate.Direction = ParameterDirection.Input
            _areastartdate.Value = Format(CDate(_sValue1), "d")
            Params(1) = _areastartdate

            Try
                BusinessObject.Sub_Show(ServerPath, "sp_area_brick_list", CommandType.StoredProcedure, _
                    MyCodeTableDS, "sp_area_brick_list", Params)

                DataGridAreaBrick.DataSource = MyCodeTableDS.sp_area_brick_list

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub AreaPMRList(ByVal _sValue As String, ByVal _sValue1 As String)
        Me.Cursor = Cursors.WaitCursor
        Dim Params(2) As SqlParameter

        If MyCodeTableDS.sp_area_pmr_list.Count > 0 Then MyCodeTableDS.sp_area_pmr_list.Clear()

        Try
            Dim _areacode As New SqlParameter("@areacode", SqlDbType.Char, 10)
            _areacode.Direction = ParameterDirection.Input
            _areacode.Value = _sValue
            Params(0) = _areacode

            Dim _areastartdate As New SqlParameter("@areastartdate", SqlDbType.DateTime)
            _areastartdate.Direction = ParameterDirection.Input
            _areastartdate.Value = Format(CDate(_sValue1), "d")
            Params(1) = _areastartdate

            Dim _areayear As New SqlParameter("@areayear", SqlDbType.Char, 10)
            _areayear.Direction = ParameterDirection.Input
            _areayear.Value = Trim(ComboBoxAreaYear.SelectedValue.ToString())
            Params(2) = _areayear

            Try
                BusinessObject.Sub_Show(ServerPath, "sp_area_pmr_list", CommandType.StoredProcedure, _
                    MyCodeTableDS, "sp_area_pmr_list", Params)
                DataGridAreaPMR.DataSource = MyCodeTableDS.sp_area_pmr_list
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ComboBoxAreaYear_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles ComboBoxAreaYear.SelectionChangeCommitted
        If ComboBoxAreaYear.SelectedIndex = 0 Then
            If MyCodeTableDS.sp_area_list_per_year.Count > 0 Then
                If MyCodeTableDS.sp_area_list_per_year.Count > 0 Then MyCodeTableDS.sp_area_list_per_year.Clear()
                If MyCodeTableDS.sp_area_brick_list.Count > 0 Then MyCodeTableDS.sp_area_brick_list.Clear()
                If MyCodeTableDS.sp_area_pmr_list.Count > 0 Then MyCodeTableDS.sp_area_pmr_list.Clear()
            Else
                Return
            End If
        Else
            Me.AreaListPerYear(ComboBoxAreaYear.SelectedValue.ToString())
        End If
    End Sub

    Private Sub ComboBoxAreaYear_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles ComboBoxAreaYear.SelectedIndexChanged

        If ComboBoxAreaYear.SelectedIndex = 0 Then
            If MyCodeTableDS.sp_area_list_per_year.Count > 0 Then MyCodeTableDS.sp_area_list_per_year.Clear()
            If MyCodeTableDS.sp_area_brick_list.Count > 0 Then MyCodeTableDS.sp_area_brick_list.Clear()
            If MyCodeTableDS.sp_area_pmr_list.Count > 0 Then MyCodeTableDS.sp_area_pmr_list.Clear()
        End If
    End Sub

    Private Sub DataGridArea_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles DataGridArea.CurrentCellChanged
        With DataGridArea
            If ComboBoxAreaYear.SelectedIndex = 0 Then
                Return
            Else
                Me.AreaBrickList(Trim(.Item(.CurrentCell.RowNumber, 0).ToString), _
                    Trim(.Item(.CurrentCell.RowNumber, 7).ToString))
                'Me.AreaPMRList(Trim(.Item(.CurrentCell.RowNumber, 0).ToString))
                Me.AreaPMRList(Trim(.Item(.CurrentCell.RowNumber, 0).ToString), _
                    Trim(.Item(.CurrentCell.RowNumber, 7).ToString))
            End If
        End With
    End Sub

    Private Sub DataGridArea_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles DataGridArea.DoubleClick
        With DataGridArea
            If ComboBoxAreaYear.SelectedIndex = 0 Then
                Return
            Else
                Me.AreaBrickList(Trim(.Item(.CurrentCell.RowNumber, 0).ToString), _
                Trim(.Item(.CurrentCell.RowNumber, 7).ToString))
                'Me.AreaPMRList(Trim(.Item(.CurrentCell.RowNumber, 0).ToString))
                Me.AreaPMRList(Trim(.Item(.CurrentCell.RowNumber, 0).ToString), _
                    Trim(.Item(.CurrentCell.RowNumber, 7).ToString))
            End If
        End With
    End Sub

    Private Sub DataGridArea_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
        Handles DataGridArea.MouseUp
        Dim _i, _iRow As Integer
        Dim _dg As DataGrid = DirectCast(sender, DataGrid)
        Dim _ht As DataGrid.HitTestInfo

        _dg = DataGridArea
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
                With DataGridArea
                    If .IsSelected(.CurrentRowIndex) Then
                        _sAreaCode = Trim(.Item(.CurrentCell.RowNumber, 0).ToString)
                        _sAreaStartDate = Trim(.Item(.CurrentCell.RowNumber, 7).ToString)
                        Me.AreaBrickList(Trim(_sAreaCode), _sAreaStartDate)
                        'Me.AreaPMRList(Trim(_sAreaCode))
                        Me.AreaPMRList(Trim(_sAreaCode), _sAreaStartDate)
                    Else
                        Return
                    End If
                End With
            End If
        End If
    End Sub

    Private Sub DataGridAreaBrick_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
        Handles DataGridAreaBrick.MouseUp
        Dim _i, _iRow As Integer
        Dim _dg As DataGrid = DirectCast(sender, DataGrid)
        Dim _ht As DataGrid.HitTestInfo

        _dg = DataGridAreaBrick
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
            End If
        End If
    End Sub

    Private Sub DataGridAreaPMR_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
        Handles DataGridAreaPMR.MouseUp
        Dim _i, _iRow As Integer
        Dim _dg As DataGrid = DirectCast(sender, DataGrid)
        Dim _ht As DataGrid.HitTestInfo

        _dg = DataGridAreaPMR
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
            End If
        End If
    End Sub

    Private Sub ButtonAddArea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles ButtonAddArea.Click
        Dim _frmPopup As New TerritoryAreaEntry
        Dim _iRow As Integer = MyCodeTableDS.sp_area_list_per_year.Rows.Count

        Me.UnselectDataGridAreaBrickRows()
        Me.UnselectDataGridAreaPMRRows()

        If ComboBoxAreaYear.SelectedIndex = 0 Then
            Return
        Else
            If _iRow <> 0 Then
                _frmPopup.ShowDialog()
                Me.AreaListPerYear(ComboBoxAreaYear.SelectedValue.ToString())
            Else
                Return
            End If
        End If
    End Sub

    Private Sub ButtonEditArea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles ButtonEditArea.Click
        Dim _iRow As Integer = DataGridArea.CurrentRowIndex
        Dim _frmPopup As New TerritoryAreaUpdate

        Me.UnselectDataGridAreaBrickRows()
        Me.UnselectDataGridAreaPMRRows()

        If ComboBoxAreaYear.SelectedIndex = 0 Then
            Return
        Else
            If _iRow = -1 Then
                Return
            Else
                If MyCodeTableDS.sp_area_list_per_year.Rows.Count <> 0 Then
                    If DataGridArea.IsSelected(_iRow) Then
                        With DataGridArea
                            _s0TerritoryArea = Trim(.Item(.CurrentCell.RowNumber, 0).ToString)
                            _s1TerritoryArea = Trim(.Item(.CurrentCell.RowNumber, 1).ToString)
                            _s2TerritoryArea = Trim(.Item(.CurrentCell.RowNumber, 2).ToString)
                            _s3TerritoryArea = Trim(.Item(.CurrentCell.RowNumber, 3).ToString)
                            _s4TerritoryArea = Trim(.Item(.CurrentCell.RowNumber, 4).ToString)
                            _s5TerritoryArea = Trim(.Item(.CurrentCell.RowNumber, 5).ToString)
                            _s6TerritoryArea = Trim(.Item(.CurrentCell.RowNumber, 6).ToString)
                            _s7TerritoryArea = Trim(.Item(.CurrentCell.RowNumber, 7).ToString)
                            _s8TerritoryArea = Trim(.Item(.CurrentCell.RowNumber, 8).ToString)
                        End With
                        _frmPopup.ShowDialog()
                        Me.AreaListPerYear(ComboBoxAreaYear.SelectedValue.ToString())
                    End If
                Else
                    Return
                End If
            End If
        End If
    End Sub

    Private Sub ButtonDeleteArea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles ButtonDeleteArea.Click
        If ComboBoxAreaYear.SelectedIndex = 0 Then
            Return
        Else
            If MyCodeTableDS.sp_area_list_per_year.Rows.Count > 0 Then
                With DataGridArea
                    If .IsSelected(.CurrentRowIndex) Then
                        _sAreaCode = Trim(.Item(.CurrentCell.RowNumber, 0).ToString)
                        _sAreaStartDate = Trim(.Item(.CurrentCell.RowNumber, 7).ToString)
                        Me.SelectDataGridRows()
                        Me.AreaDelete(_sAreaCode, _sAreaStartDate)
                    End If
                End With
            End If
        End If
    End Sub

    Private Sub ButtonAddAreaBrick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles ButtonAddAreaBrick.Click
        Dim _iRow As Integer = DataGridArea.CurrentRowIndex
        Dim _iCount As Integer = MyCodeTableDS.sp_area_list_per_year.Rows.Count
        Dim _frmPopup As New TerritoryAreaBrickEntry

        If ComboBoxAreaYear.SelectedIndex = 0 Then
            Return
        Else
            If _iCount <> 0 Then
                If _iRow = -1 Then
                    Return
                Else
                    If DataGridArea.IsSelected(_iRow) Then
                        With DataGridArea
                            _s0TerritoryArea = Trim(.Item(.CurrentCell.RowNumber, 0).ToString)
                            _s7TerritoryArea = Trim(.Item(.CurrentCell.RowNumber, 7).ToString)
                        End With
                        _frmPopup.ShowDialog()
                        If _frmPopup.DialogResult = DialogResult.OK Then
                            Me.AreaBrickList(_s0TerritoryArea, _s7TerritoryArea)
                            Me.UnselectDataGridAreaBrickRows()
                            Me.UnselectDataGridAreaPMRRows()
                        Else
                            Return
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ButtonEditAreaBrick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles ButtonEditAreaBrick.Click
        Dim _iRow As Integer = DataGridArea.CurrentRowIndex
        Dim _iRow1 As Integer = DataGridAreaBrick.CurrentRowIndex
        Dim _frmPopup As New TerritoryAreaBrickUpdate

        If _iRow = -1 Then
            Return
        Else
            If DataGridArea.IsSelected(_iRow) Then
                With DataGridArea
                    _s0TerritoryArea = Trim(.Item(.CurrentCell.RowNumber, 0).ToString)
                    _s7TerritoryArea = Trim(.Item(.CurrentCell.RowNumber, 7).ToString)
                End With
                If MyCodeTableDS.sp_area_brick_list.Rows.Count <> 0 Then
                    If DataGridAreaBrick.IsSelected(_iRow1) Then
                        With DataGridAreaBrick
                            _s0TerritoryAreaBrick = Trim(.Item(.CurrentCell.RowNumber, 0).ToString)
                            _s1TerritoryAreaBrick = Trim(.Item(.CurrentCell.RowNumber, 1).ToString)
                            _s2TerritoryAreaBrick = Trim(.Item(.CurrentCell.RowNumber, 2).ToString)
                            _s3TerritoryAreaBrick = Trim(.Item(.CurrentCell.RowNumber, 3).ToString)
                            _s4TerritoryAreaBrick = Trim(.Item(.CurrentCell.RowNumber, 4).ToString)
                            _s5TerritoryAreaBrick = Trim(.Item(.CurrentCell.RowNumber, 5).ToString)
                        End With
                        _frmPopup.ShowDialog()

                        If _frmPopup.DialogResult = DialogResult.OK Then
                            Me.AreaBrickList(_s0TerritoryArea, _s7TerritoryArea)
                            Me.UnselectDataGridAreaBrickRows()
                            Me.UnselectDataGridAreaPMRRows()
                        Else
                            Return
                        End If
                    End If
                Else
                    Return
                End If
            End If
        End If
    End Sub

    Private Sub ButtonDeleteAreaBrick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles ButtonDeleteAreaBrick.Click
        If MyCodeTableDS.sp_area_list_per_year.Rows.Count > 0 Then
            With DataGridArea
                If .IsSelected(.CurrentRowIndex) Then
                    _sAreaCode = Trim(.Item(.CurrentCell.RowNumber, 0).ToString)
                    _sAreaStartDate = Trim(.Item(.CurrentCell.RowNumber, 7).ToString)
                End If
            End With

            If MyCodeTableDS.sp_area_brick_list.Rows.Count > 0 Then
                With DataGridAreaBrick
                    If .IsSelected(.CurrentRowIndex) Then
                        _sPrinCode = Trim(.Item(.CurrentCell.RowNumber, 0).ToString)
                        _sTerritoryDR = Trim(.Item(.CurrentCell.RowNumber, 2).ToString)
                        _sBrickStartDate = Trim(.Item(.CurrentCell.RowNumber, 4).ToString)
                        Me.AreaBrickDelete(_sAreaCode, _sAreaStartDate, _sPrinCode, _sTerritoryDR, _sBrickStartDate)
                    End If
                End With
            Else
                Return
            End If
        End If
    End Sub

    Private Sub ButtonAddAreaPMR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles ButtonAddAreaPMR.Click
        Dim _iRow As Integer = DataGridArea.CurrentRowIndex
        Dim _iCount As Integer = MyCodeTableDS.sp_area_list_per_year.Rows.Count
        Dim _frmPopup As New TerritoryAreaPMREntry

        If ComboBoxAreaYear.SelectedIndex = 0 Then
            Return
        Else
            If _iCount <> 0 Then
                If _iRow = -1 Then
                    Return
                Else
                    If DataGridArea.IsSelected(_iRow) Then
                        With DataGridArea
                            _s0TerritoryArea = Trim(.Item(.CurrentCell.RowNumber, 0).ToString)
                            _s7TerritoryArea = Trim(.Item(.CurrentCell.RowNumber, 7).ToString)
                        End With
                        _frmPopup.ShowDialog()
                        If _frmPopup.DialogResult = DialogResult.OK Then
                            Me.AreaPMRList(_s0TerritoryArea, _s7TerritoryArea)
                            Me.UnselectDataGridAreaBrickRows()
                            Me.UnselectDataGridAreaPMRRows()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ButtonEditAreaPMR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles ButtonEditAreaPMR.Click
        Dim _iRow As Integer = DataGridArea.CurrentRowIndex
        Dim _iRow1 As Integer = DataGridAreaPMR.CurrentRowIndex
        Dim _frmPopup As New TerritoryAreaPMRUpdate

        If _iRow = -1 Then
            Return
        Else
            If DataGridArea.IsSelected(_iRow) Then
                With DataGridArea
                    _s0TerritoryArea = Trim(.Item(.CurrentCell.RowNumber, 0).ToString)
                    _s7TerritoryArea = Trim(.Item(.CurrentCell.RowNumber, 7).ToString)
                End With
                If MyCodeTableDS.sp_area_pmr_list.Rows.Count <> 0 Then
                    If DataGridAreaPMR.IsSelected(_iRow1) Then
                        With DataGridAreaPMR
                            _s0TerritoryAreaPMR = Trim(.Item(.CurrentCell.RowNumber, 0).ToString)
                            _s1TerritoryAreaPMR = Trim(.Item(.CurrentCell.RowNumber, 1).ToString)
                            _s2TerritoryAreaPMR = Trim(.Item(.CurrentCell.RowNumber, 2).ToString)
                            _s3TerritoryAreaPMR = Trim(.Item(.CurrentCell.RowNumber, 3).ToString)
                            _s4TerritoryAreaPMR = Trim(.Item(.CurrentCell.RowNumber, 4).ToString)
                            _s5TerritoryAreaPMR = Trim(.Item(.CurrentCell.RowNumber, 5).ToString)
                        End With
                        _frmPopup.ShowDialog()

                        If _frmPopup.DialogResult = DialogResult.OK Then
                            Me.AreaPMRList(_s0TerritoryArea, _s7TerritoryArea)
                            Me.UnselectDataGridAreaBrickRows()
                            Me.UnselectDataGridAreaPMRRows()
                        End If
                    End If
                Else
                    Return
                End If
            End If
        End If
    End Sub

    Private Sub ButtonDeleteAreaPMR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles ButtonDeleteAreaPMR.Click
        If MyCodeTableDS.sp_area_list_per_year.Rows.Count > 0 Then
            With DataGridArea
                If .IsSelected(.CurrentRowIndex) Then
                    _sAreaCode = Trim(.Item(.CurrentCell.RowNumber, 0).ToString)
                    _sAreaStartDate = Trim(.Item(.CurrentCell.RowNumber, 7).ToString)
                End If
            End With

            If MyCodeTableDS.sp_area_pmr_list.Rows.Count > 0 Then
                With DataGridAreaPMR
                    If .IsSelected(.CurrentRowIndex) Then
                        _sMedRepCode = Trim(.Item(.CurrentCell.RowNumber, 0).ToString)
                        _sPMRStartDate = Trim(.Item(.CurrentCell.RowNumber, 2).ToString)
                        Me.AreaPMRDelete(_sAreaCode, _sAreaStartDate, _sMedRepCode, _sPMRStartDate)
                    End If
                End With
            Else
                Return
            End If
        End If
    End Sub

    Private Sub AreaDelete(ByVal _sValue1 As String, ByVal _sValue2 As String)
        Dim Params(2) As SqlParameter

        If MyCodeTableDS.sp_area_delete.Count > 0 Then MyCodeTableDS.sp_area_delete.Clear()

        If (MessageBox.Show("You're about to delete all the selected row in" & vbNewLine & _
            "Area, Area Brick and Area PMR list view!" & vbNewLine & _
            "Click Yes if you want to proceed.", "Deleting", MessageBoxButtons.YesNo, _
            MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then

            Try
                Dim _areacode As New SqlParameter("@areacode", SqlDbType.Char, 10)
                _areacode.Direction = ParameterDirection.Input
                _areacode.Value = Trim(_sValue1)
                Params(0) = _areacode

                Dim _areastartdate As New SqlParameter("@areastartdate", SqlDbType.DateTime)
                _areastartdate.Direction = ParameterDirection.Input
                _areastartdate.Value = Format(CDate(_sValue2), "d")
                Params(1) = _areastartdate

                Dim _lastuser As New SqlParameter("@lastuser", SqlDbType.Char, 10)
                _lastuser.Direction = ParameterDirection.Input
                _lastuser.Value = UCase(Trim(gUserID))
                Params(2) = _lastuser

                Try
                    BusinessObject.Sub_Show(ServerPath, "sp_area_delete", CommandType.StoredProcedure, _
                        MyCodeTableDS, "sp_area_delete", Params)

                    Me.DataGridAllRowsRemoved()

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Me.UnselectDataGridAreaRows()
            Me.UnselectDataGridAreaBrickRows()
            Me.UnselectDataGridAreaPMRRows()
            'Me.UnselectDataGridRows()
            Return
        End If
    End Sub

    Private Sub AreaBrickDelete(ByVal _sValue1 As String, ByVal _sValue2 As String, ByVal _sValue3 As String, _
        ByVal _sValue4 As String, ByVal _sValue5 As String)
        Dim Params(5) As SqlParameter

        If MyCodeTableDS.sp_area_brick_delete.Count > 0 Then MyCodeTableDS.sp_area_brick_delete.Clear()

        If (MessageBox.Show("You're about to delete the selected row in Area Brick list view!" & vbNewLine & _
            "Click Yes if you want to proceed.", "Deleting", MessageBoxButtons.YesNo, _
            MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then

            Try
                Dim _areacode As New SqlParameter("@areacode", SqlDbType.Char, 10)
                _areacode.Direction = ParameterDirection.Input
                _areacode.Value = Trim(_sValue1)
                Params(0) = _areacode

                Dim _areastartdate As New SqlParameter("@areastartdate", SqlDbType.DateTime)
                _areastartdate.Direction = ParameterDirection.Input
                _areastartdate.Value = Format(CDate(_sValue2), "d")
                Params(1) = _areastartdate

                Dim _princode As New SqlParameter("@princode", SqlDbType.Char, 5)
                _princode.Direction = ParameterDirection.Input
                _princode.Value = Trim(_sValue3)
                Params(2) = _princode

                Dim _territorydr As New SqlParameter("@territorydr", SqlDbType.VarChar, 18)
                _territorydr.Direction = ParameterDirection.Input
                _territorydr.Value = Trim(_sValue4)
                Params(3) = _territorydr

                Dim _brickstartdate As New SqlParameter("@brickstartdate", SqlDbType.DateTime)
                _brickstartdate.Direction = ParameterDirection.Input
                _brickstartdate.Value = Format(CDate(_sValue5), "d")
                Params(4) = _brickstartdate

                Dim _lastuser As New SqlParameter("@lastuser", SqlDbType.Char, 10)
                _lastuser.Direction = ParameterDirection.Input
                _lastuser.Value = UCase(Trim(gUserID))
                Params(5) = _lastuser

                Try
                    BusinessObject.Sub_Show(ServerPath, "sp_area_brick_delete", CommandType.StoredProcedure, _
                        MyCodeTableDS, "sp_area_brick_delete", Params)

                    Me.DataGridAreaBrickRowRemoved()

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Me.UnselectDataGridAreaRows()
            Me.UnselectDataGridAreaBrickRows()
            Me.UnselectDataGridAreaPMRRows()
            'Me.UnselectDataGridRows()
            Return
        End If
    End Sub

    Private Sub AreaPMRDelete(ByVal _sValue1 As String, ByVal _sValue2 As String, _
        ByVal _sValue3 As String, ByVal _sValue4 As String)
        Dim Params(3) As SqlParameter

        If MyCodeTableDS.sp_area_pmr_delete.Count > 0 Then MyCodeTableDS.sp_area_pmr_delete.Clear()

        If (MessageBox.Show("You're about to delete the selected row in Area PMR list view!" & vbNewLine & _
            "Click Yes if you want to proceed.", "Deleting", MessageBoxButtons.YesNo, _
            MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then

            Try
                Dim _areacode As New SqlParameter("@areacode", SqlDbType.Char, 10)
                _areacode.Direction = ParameterDirection.Input
                _areacode.Value = Trim(_sValue1)
                Params(0) = _areacode

                Dim _areastartdate As New SqlParameter("@areastartdate", SqlDbType.DateTime)
                _areastartdate.Direction = ParameterDirection.Input
                _areastartdate.Value = Format(CDate(_sValue2), "d")
                Params(1) = _areastartdate

                Dim _mrcode As New SqlParameter("@mrcode", SqlDbType.Char, 10)
                _mrcode.Direction = ParameterDirection.Input
                _mrcode.Value = Trim(_sValue3)
                Params(2) = _mrcode

                Dim _pmrstartdate As New SqlParameter("@pmrstartdate", SqlDbType.DateTime)
                _pmrstartdate.Direction = ParameterDirection.Input
                _pmrstartdate.Value = Format(CDate(_sValue4), "d")
                Params(3) = _pmrstartdate

                '***removed due to no need of history as per EAR style
                'Dim _lastuser As New SqlParameter("@lastuser", SqlDbType.Char, 10)
                '_lastuser.Direction = ParameterDirection.Input
                '_lastuser.Value = UCase(Trim(gUserID))
                'Params(4) = _lastuser

                Try
                    BusinessObject.Sub_Show(ServerPath, "sp_area_pmr_delete", CommandType.StoredProcedure, _
                        MyCodeTableDS, "sp_area_pmr_delete", Params)

                    Me.DataGridAreaPMRRowRemoved()

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Me.UnselectDataGridAreaRows()
            Me.UnselectDataGridAreaBrickRows()
            Me.UnselectDataGridAreaPMRRows()
            'Me.UnselectDataGridRows()
            Return
        End If
    End Sub

    Private Sub SelectDataGridRows()
        Dim _iRow As Integer = MyCodeTableDS.sp_area_brick_list.Rows.Count

        If _iRow <> 0 Then
            For _i As Integer = 0 To _iRow - 1
                With DataGridAreaBrick
                    If .IsSelected(_i) = False Then
                        .Select(_i)
                    End If
                End With
            Next _i
        End If

        Dim _iRow1 As Integer = MyCodeTableDS.sp_area_pmr_list.Rows.Count

        If _iRow1 <> 0 Then
            For _i As Integer = 0 To _iRow1 - 1
                With DataGridAreaPMR
                    If .IsSelected(_i) = False Then
                        .Select(_i)
                    End If
                End With
            Next _i
        End If
    End Sub

    Private Sub DataGridAllRowsRemoved()
        Me.Cursor = Cursors.WaitCursor
        If MyCodeTableDS.sp_area_list.Rows.Count > 0 Then
            MyCodeTableDS.sp_area_list.Rows.RemoveAt(DataGridArea.CurrentRowIndex)
            Me.AreaList()
        End If

        Dim _iRow As Integer = MyCodeTableDS.sp_area_brick_list.Rows.Count

        With DataGridAreaBrick
            For _i As Integer = 0 To _iRow - 1
                If MyCodeTableDS.sp_area_brick_list.Rows.Count <> 0 Then
                    If .IsSelected(_i) Then
                        MyCodeTableDS.sp_area_brick_list.Rows.RemoveAt(_i)
                        With DataGridArea
                            _sAreaCode = Trim(.Item(.CurrentCell.RowNumber, 0).ToString)
                            _sAreaStartDate = Trim(.Item(.CurrentCell.RowNumber, 7).ToString)
                            Me.AreaBrickList(_sAreaCode, _sAreaStartDate)
                        End With
                    End If
                Else
                    Return
                End If
            Next _i
        End With

        Dim _iRow1 As Integer = MyCodeTableDS.sp_area_pmr_list.Rows.Count

        With DataGridAreaPMR
            For _i As Integer = 0 To _iRow1 - 1
                If MyCodeTableDS.sp_area_pmr_list.Rows.Count <> 0 Then
                    If .IsSelected(_i) Then
                        MyCodeTableDS.sp_area_pmr_list.Rows.RemoveAt(_i)
                        With DataGridArea
                            _sAreaCode = Trim(.Item(.CurrentCell.RowNumber, 0).ToString)
                            _sAreaStartDate = Trim(.Item(.CurrentCell.RowNumber, 7).ToString)
                            Me.AreaPMRList(_sAreaCode, _sAreaStartDate)
                        End With
                    End If
                Else
                    Return
                End If
            Next _i
        End With
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub DataGridAreaBrickRowRemoved()
        Me.Cursor = Cursors.WaitCursor
        If MyCodeTableDS.sp_area_brick_list.Rows.Count > 0 Then
            MyCodeTableDS.sp_area_brick_list.Rows.RemoveAt(DataGridAreaBrick.CurrentRowIndex)
            Me.AreaList()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub DataGridAreaPMRRowRemoved()
        Me.Cursor = Cursors.WaitCursor
        If MyCodeTableDS.sp_area_pmr_list.Rows.Count > 0 Then
            MyCodeTableDS.sp_area_pmr_list.Rows.RemoveAt(DataGridAreaPMR.CurrentRowIndex)
            'Me.AreaList()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub DataGridRefresh()
        Me.AreaList()
    End Sub

    Private Sub UnselectDataGridRows()
        Dim _iRow1, _iRow2, _iRow0, _i As Integer
        _iRow0 = MyCodeTableDS.sp_area_list.Rows.Count

        If _iRow0 <> 0 Then
            For _i = 0 To _iRow0 - 1
                With DataGridArea
                    If .IsSelected(_i) Then
                        .UnSelect(_i)
                    End If
                End With
            Next _i
        Else
            Return
        End If

        _iRow1 = MyCodeTableDS.sp_area_brick_list.Rows.Count

        If _iRow1 <> 0 Then
            For _i = 0 To _iRow1 - 1
                With DataGridAreaBrick
                    If .IsSelected(_i) Then
                        .UnSelect(_i)
                    End If
                End With
            Next _i
        Else
            Return
        End If

        _iRow2 = MyCodeTableDS.sp_area_pmr_list.Rows.Count

        If _iRow2 <> 0 Then
            For _i = 0 To _iRow2 - 1
                With DataGridAreaPMR
                    If .IsSelected(_i) Then
                        .UnSelect(_i)
                    End If
                End With
            Next _i
        Else
            Return
        End If

    End Sub

    Private Sub UnselectDataGridAreaRows()
        Dim _iRow0, _iRow1, _i As Integer
        _iRow0 = MyCodeTableDS.sp_area_list.Rows.Count
        _iRow1 = MyCodeTableDS.sp_area_list_per_year.Rows.Count

        If ComboBoxAreaYear.SelectedIndex = 0 Then
            If _iRow0 <> 0 Then
                For _i = 0 To _iRow0 - 1
                    With DataGridArea
                        If .IsSelected(_i) Then
                            .UnSelect(_i)
                        End If
                    End With
                Next _i
            Else
                Return
            End If
        Else
            If _iRow1 <> 0 Then
                For _i = 0 To _iRow1 - 1
                    With DataGridArea
                        If .IsSelected(_i) Then
                            .UnSelect(_i)
                        End If
                    End With
                Next _i
            Else
                Return
            End If
        End If
    End Sub

    Private Sub UnselectDataGridAreaBrickRows()
        Dim _iRow, _i As Integer
        _iRow = MyCodeTableDS.sp_area_brick_list.Rows.Count()

        If _iRow <> 0 Then
            For _i = 0 To _iRow - 1
                With DataGridAreaBrick
                    If .IsSelected(_i) Then
                        .UnSelect(_i)
                    End If
                End With
            Next _i
        Else
            Return
        End If
    End Sub

    Private Sub UnselectDataGridAreaPMRRows()
        Dim _iRow, _i As Integer
        _iRow = MyCodeTableDS.sp_area_pmr_list.Rows.Count

        If _iRow <> 0 Then
            For _i = 0 To _iRow - 1
                With DataGridAreaPMR
                    If .IsSelected(_i) Then
                        .UnSelect(_i)
                    End If
                End With
            Next _i
        Else
            Return
        End If
    End Sub

    Private Sub Frm_Closed(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles MyBase.Closed
        EnDisMainMenu(Me, True)
    End Sub

    Private Sub Frm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles MyBase.Activated
        EnDisMainMenu(Me, False)
    End Sub

End Class
