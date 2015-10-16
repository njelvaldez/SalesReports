Imports System.Configuration
Public Class About
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents InstallationPath As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents MachineName As System.Windows.Forms.Label
    Friend WithEvents UserName As System.Windows.Forms.Label
    Friend WithEvents Platform As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblServerPath As System.Windows.Forms.Label
    Friend WithEvents lblServerPath2 As System.Windows.Forms.Label
    Friend WithEvents Product_Name As System.Windows.Forms.Label
    Friend WithEvents Product_Version As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.InstallationPath = New System.Windows.Forms.Label
        Me.Product_Version = New System.Windows.Forms.Label
        Me.Product_Name = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Platform = New System.Windows.Forms.Label
        Me.UserName = New System.Windows.Forms.Label
        Me.MachineName = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lblServerPath2 = New System.Windows.Forms.Label
        Me.lblServerPath = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.InstallationPath)
        Me.GroupBox1.Controls.Add(Me.Product_Version)
        Me.GroupBox1.Controls.Add(Me.Product_Name)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 128)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Application"
        '
        'InstallationPath
        '
        Me.InstallationPath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.InstallationPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InstallationPath.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.InstallationPath.Location = New System.Drawing.Point(120, 64)
        Me.InstallationPath.Name = "InstallationPath"
        Me.InstallationPath.Size = New System.Drawing.Size(264, 56)
        Me.InstallationPath.TabIndex = 5
        Me.InstallationPath.Text = "Label6"
        Me.InstallationPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Product_Version
        '
        Me.Product_Version.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Product_Version.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Product_Version.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Product_Version.Location = New System.Drawing.Point(120, 40)
        Me.Product_Version.Name = "Product_Version"
        Me.Product_Version.Size = New System.Drawing.Size(264, 16)
        Me.Product_Version.TabIndex = 4
        Me.Product_Version.Text = "Label5"
        Me.Product_Version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Product_Name
        '
        Me.Product_Name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Product_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Product_Name.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Product_Name.Location = New System.Drawing.Point(120, 16)
        Me.Product_Name.Name = "Product_Name"
        Me.Product_Name.Size = New System.Drawing.Size(264, 16)
        Me.Product_Name.TabIndex = 3
        Me.Product_Name.Text = "Label4"
        Me.Product_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(8, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Installation Path:"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Product Version:"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product Name:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Platform)
        Me.GroupBox2.Controls.Add(Me.UserName)
        Me.GroupBox2.Controls.Add(Me.MachineName)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(8, 144)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(392, 88)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Environment"
        '
        'Platform
        '
        Me.Platform.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Platform.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Platform.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Platform.Location = New System.Drawing.Point(120, 64)
        Me.Platform.Name = "Platform"
        Me.Platform.Size = New System.Drawing.Size(264, 16)
        Me.Platform.TabIndex = 5
        Me.Platform.Text = "Label6"
        Me.Platform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserName
        '
        Me.UserName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserName.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.UserName.Location = New System.Drawing.Point(120, 40)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(264, 16)
        Me.UserName.TabIndex = 4
        Me.UserName.Text = "Label5"
        Me.UserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MachineName
        '
        Me.MachineName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MachineName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MachineName.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.MachineName.Location = New System.Drawing.Point(120, 16)
        Me.MachineName.Name = "MachineName"
        Me.MachineName.Size = New System.Drawing.Size(264, 16)
        Me.MachineName.TabIndex = 3
        Me.MachineName.Text = "Label4"
        Me.MachineName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(8, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Platform:"
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Location = New System.Drawing.Point(8, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 16)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "User Name:"
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Location = New System.Drawing.Point(8, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Machine Name:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblServerPath2)
        Me.GroupBox3.Controls.Add(Me.lblServerPath)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox3.Location = New System.Drawing.Point(8, 240)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(392, 176)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Database"
        '
        'lblServerPath2
        '
        Me.lblServerPath2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblServerPath2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServerPath2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblServerPath2.Location = New System.Drawing.Point(120, 96)
        Me.lblServerPath2.Name = "lblServerPath2"
        Me.lblServerPath2.Size = New System.Drawing.Size(264, 70)
        Me.lblServerPath2.TabIndex = 5
        Me.lblServerPath2.Text = "Label6"
        Me.lblServerPath2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblServerPath
        '
        Me.lblServerPath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblServerPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServerPath.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblServerPath.Location = New System.Drawing.Point(120, 16)
        Me.lblServerPath.Name = "lblServerPath"
        Me.lblServerPath.Size = New System.Drawing.Size(264, 70)
        Me.lblServerPath.TabIndex = 3
        Me.lblServerPath.Text = "Label4"
        Me.lblServerPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(8, 123)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 16)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "ServerPath2:"
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label12.Location = New System.Drawing.Point(8, 43)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "ServerPath:"
        '
        'About
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(408, 419)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "About"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Application
        Product_Name.Text = Application.ProductName
        Product_Version.Text = ConfigurationSettings.AppSettings("AppVersion")
        InstallationPath.Text = Application.ExecutablePath
        'Environment
        MachineName.Text = Environment.MachineName
        UserName.Text = Environment.UserName
        Platform.Text = Environment.OSVersion.Platform.ToString()
        'Database
        lblServerPath.Text = ConfigurationSettings.AppSettings("ServerPath")
        lblServerPath2.Text = ConfigurationSettings.AppSettings("ServerPath2")



    End Sub
End Class
