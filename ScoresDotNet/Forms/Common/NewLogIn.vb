Public Class NewLogIn
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
    Friend WithEvents GroupBoxUserLogIn As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxPassword As System.Windows.Forms.TextBox
    Friend WithEvents LabelPassword As System.Windows.Forms.Label
    Friend WithEvents TextBoxUser As System.Windows.Forms.TextBox
    Friend WithEvents LabelUser As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ButtonLogIn As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents ButtonUpdate As System.Windows.Forms.Button
    Friend WithEvents ButtonEdit As System.Windows.Forms.Button
    Friend WithEvents TextBoxDatabaseName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxServerName As System.Windows.Forms.TextBox
    Friend WithEvents LabelServerName As System.Windows.Forms.Label
    Friend WithEvents LabelDBName As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents LabelDBPassword As System.Windows.Forms.Label
    Friend WithEvents GroupBoxDatabaseServerConnection As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBoxUserLogIn = New System.Windows.Forms.GroupBox
        Me.ButtonCancel = New System.Windows.Forms.Button
        Me.ButtonLogIn = New System.Windows.Forms.Button
        Me.TextBoxPassword = New System.Windows.Forms.TextBox
        Me.TextBoxUser = New System.Windows.Forms.TextBox
        Me.LabelUser = New System.Windows.Forms.Label
        Me.LabelPassword = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBoxDatabaseServerConnection = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.LabelDBPassword = New System.Windows.Forms.Label
        Me.TextBoxDatabaseName = New System.Windows.Forms.TextBox
        Me.TextBoxServerName = New System.Windows.Forms.TextBox
        Me.LabelServerName = New System.Windows.Forms.Label
        Me.LabelDBName = New System.Windows.Forms.Label
        Me.ButtonUpdate = New System.Windows.Forms.Button
        Me.ButtonEdit = New System.Windows.Forms.Button
        Me.GroupBoxUserLogIn.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBoxDatabaseServerConnection.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxUserLogIn
        '
        Me.GroupBoxUserLogIn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBoxUserLogIn.Controls.Add(Me.ButtonCancel)
        Me.GroupBoxUserLogIn.Controls.Add(Me.ButtonLogIn)
        Me.GroupBoxUserLogIn.Controls.Add(Me.TextBoxPassword)
        Me.GroupBoxUserLogIn.Controls.Add(Me.TextBoxUser)
        Me.GroupBoxUserLogIn.Controls.Add(Me.LabelUser)
        Me.GroupBoxUserLogIn.Controls.Add(Me.LabelPassword)
        Me.GroupBoxUserLogIn.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBoxUserLogIn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxUserLogIn.Location = New System.Drawing.Point(5, 5)
        Me.GroupBoxUserLogIn.Name = "GroupBoxUserLogIn"
        Me.GroupBoxUserLogIn.Size = New System.Drawing.Size(299, 136)
        Me.GroupBoxUserLogIn.TabIndex = 4
        Me.GroupBoxUserLogIn.TabStop = False
        Me.GroupBoxUserLogIn.Text = "User Log-In"
        '
        'ButtonCancel
        '
        Me.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonCancel.Location = New System.Drawing.Point(177, 80)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.TabIndex = 5
        Me.ButtonCancel.Text = "Cancel"
        '
        'ButtonLogIn
        '
        Me.ButtonLogIn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonLogIn.Location = New System.Drawing.Point(96, 80)
        Me.ButtonLogIn.Name = "ButtonLogIn"
        Me.ButtonLogIn.TabIndex = 4
        Me.ButtonLogIn.Text = "Log-In"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPassword.Location = New System.Drawing.Point(96, 50)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(155, 21)
        Me.TextBoxPassword.TabIndex = 3
        Me.TextBoxPassword.Text = ""
        '
        'TextBoxUser
        '
        Me.TextBoxUser.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUser.Location = New System.Drawing.Point(96, 27)
        Me.TextBoxUser.Name = "TextBoxUser"
        Me.TextBoxUser.Size = New System.Drawing.Size(155, 21)
        Me.TextBoxUser.TabIndex = 1
        Me.TextBoxUser.Text = ""
        '
        'LabelUser
        '
        Me.LabelUser.AutoSize = True
        Me.LabelUser.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LabelUser.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LabelUser.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUser.Location = New System.Drawing.Point(67, 30)
        Me.LabelUser.Name = "LabelUser"
        Me.LabelUser.Size = New System.Drawing.Size(31, 17)
        Me.LabelUser.TabIndex = 0
        Me.LabelUser.Text = "User:"
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LabelPassword.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LabelPassword.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPassword.Location = New System.Drawing.Point(43, 51)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(55, 17)
        Me.LabelPassword.TabIndex = 2
        Me.LabelPassword.Text = "Password:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBoxDatabaseServerConnection)
        Me.Panel1.Controls.Add(Me.GroupBoxUserLogIn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.DockPadding.All = 5
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(309, 288)
        Me.Panel1.TabIndex = 5
        '
        'GroupBoxDatabaseServerConnection
        '
        Me.GroupBoxDatabaseServerConnection.Controls.Add(Me.TextBox1)
        Me.GroupBoxDatabaseServerConnection.Controls.Add(Me.LabelDBPassword)
        Me.GroupBoxDatabaseServerConnection.Controls.Add(Me.TextBoxDatabaseName)
        Me.GroupBoxDatabaseServerConnection.Controls.Add(Me.TextBoxServerName)
        Me.GroupBoxDatabaseServerConnection.Controls.Add(Me.LabelServerName)
        Me.GroupBoxDatabaseServerConnection.Controls.Add(Me.LabelDBName)
        Me.GroupBoxDatabaseServerConnection.Controls.Add(Me.ButtonUpdate)
        Me.GroupBoxDatabaseServerConnection.Controls.Add(Me.ButtonEdit)
        Me.GroupBoxDatabaseServerConnection.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBoxDatabaseServerConnection.Location = New System.Drawing.Point(5, 131)
        Me.GroupBoxDatabaseServerConnection.Name = "GroupBoxDatabaseServerConnection"
        Me.GroupBoxDatabaseServerConnection.Size = New System.Drawing.Size(299, 152)
        Me.GroupBoxDatabaseServerConnection.TabIndex = 5
        Me.GroupBoxDatabaseServerConnection.TabStop = False
        Me.GroupBoxDatabaseServerConnection.Text = "Connection Profile"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(97, 73)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(155, 21)
        Me.TextBox1.TabIndex = 13
        Me.TextBox1.Text = ""
        '
        'LabelDBPassword
        '
        Me.LabelDBPassword.AutoSize = True
        Me.LabelDBPassword.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LabelDBPassword.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LabelDBPassword.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDBPassword.Location = New System.Drawing.Point(25, 74)
        Me.LabelDBPassword.Name = "LabelDBPassword"
        Me.LabelDBPassword.Size = New System.Drawing.Size(73, 17)
        Me.LabelDBPassword.TabIndex = 12
        Me.LabelDBPassword.Text = "DB Password:"
        '
        'TextBoxDatabaseName
        '
        Me.TextBoxDatabaseName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDatabaseName.Location = New System.Drawing.Point(97, 50)
        Me.TextBoxDatabaseName.Name = "TextBoxDatabaseName"
        Me.TextBoxDatabaseName.Size = New System.Drawing.Size(155, 21)
        Me.TextBoxDatabaseName.TabIndex = 9
        Me.TextBoxDatabaseName.Text = ""
        '
        'TextBoxServerName
        '
        Me.TextBoxServerName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxServerName.Location = New System.Drawing.Point(97, 27)
        Me.TextBoxServerName.Name = "TextBoxServerName"
        Me.TextBoxServerName.Size = New System.Drawing.Size(155, 21)
        Me.TextBoxServerName.TabIndex = 7
        Me.TextBoxServerName.Text = ""
        '
        'LabelServerName
        '
        Me.LabelServerName.AutoSize = True
        Me.LabelServerName.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LabelServerName.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LabelServerName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelServerName.Location = New System.Drawing.Point(25, 30)
        Me.LabelServerName.Name = "LabelServerName"
        Me.LabelServerName.Size = New System.Drawing.Size(73, 17)
        Me.LabelServerName.TabIndex = 6
        Me.LabelServerName.Text = "Server Name:"
        '
        'LabelDBName
        '
        Me.LabelDBName.AutoSize = True
        Me.LabelDBName.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LabelDBName.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LabelDBName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDBName.Location = New System.Drawing.Point(43, 52)
        Me.LabelDBName.Name = "LabelDBName"
        Me.LabelDBName.Size = New System.Drawing.Size(55, 17)
        Me.LabelDBName.TabIndex = 8
        Me.LabelDBName.Text = "DB Name:"
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonUpdate.Location = New System.Drawing.Point(176, 105)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.TabIndex = 11
        Me.ButtonUpdate.Text = "Update"
        '
        'ButtonEdit
        '
        Me.ButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonEdit.Location = New System.Drawing.Point(96, 105)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.TabIndex = 10
        Me.ButtonEdit.Text = "Edit"
        '
        'NewLogIn
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(309, 288)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "NewLogIn"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewLogIn"
        Me.GroupBoxUserLogIn.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBoxDatabaseServerConnection.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub NewLogIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

End Class
