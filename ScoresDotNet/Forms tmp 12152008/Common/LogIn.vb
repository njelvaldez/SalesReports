Public Class LogIn
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents vUserId As System.Windows.Forms.TextBox
    Friend WithEvents vPassword As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(LogIn))
        Me.Label1 = New System.Windows.Forms.Label
        Me.vUserId = New System.Windows.Forms.TextBox
        Me.vPassword = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.PowderBlue
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(78, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.UseMnemonic = False
        '
        'vUserId
        '
        Me.vUserId.Location = New System.Drawing.Point(168, 75)
        Me.vUserId.Name = "vUserId"
        Me.vUserId.Size = New System.Drawing.Size(65, 20)
        Me.vUserId.TabIndex = 0
        Me.vUserId.Text = ""
        '
        'vPassword
        '
        Me.vPassword.Location = New System.Drawing.Point(159, 115)
        Me.vPassword.Name = "vPassword"
        Me.vPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.vPassword.Size = New System.Drawing.Size(83, 20)
        Me.vPassword.TabIndex = 1
        Me.vPassword.Text = ""
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.PowderBlue
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(78, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(246, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label2.UseMnemonic = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(358, 201)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 15)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'LogIn
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(395, 223)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.vPassword)
        Me.Controls.Add(Me.vUserId)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LogIn"
        Me.Opacity = 0.9
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LogIn"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        vUserId.BringToFront()
        vPassword.SendToBack()
    End Sub

    Private Sub Label2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.Click
        vPassword.BringToFront()
        vUserId.SendToBack()
    End Sub

    Private Sub vUserId_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vUserId.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub vUserId_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles vUserId.Validating
        Dim s As String
        If Trim(vUserId.Text) <> "" Then
            s = "select userid from NewScores..usertab where userid = '" & Trim(vUserId.Text) & "' "
            If Existing(s) = False Then
                MessageBox.Show("This ID does not exist! Please try again.", "Wrong ID!")
                e.Cancel = True
                vUserId.Clear()
            Else
                vUserId.SendToBack()
                vPassword.BringToFront()
                gCurrUser = Trim(vUserId.Text)
            End If
        End If
    End Sub

    Private Sub vPassword_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vPassword.KeyUp
        If e.KeyValue = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub vPassword_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles vPassword.Validating
        Dim s As String
        If Trim(vPassword.Text) <> "" Then
            s = "select password from NewScores..usertab where password = '" & Trim(vPassword.Text) & "' "
            If Existing(s) = False Then
                MessageBox.Show("This Password is incorrect! Please try again.", "Wrong Password!")
                e.Cancel = True
                vPassword.Clear()
            Else
                gUserID = Trim(vUserId.Text)
                s = "select username from NewScores..UserTab where userid = '" & Trim(vUserId.Text) & "' "
                gUserName = FindValue(s)
                s = "select role from NewScores..UserTab where userid = '" & Trim(vUserId.Text) & "' "
                gRole = FindValue(s)
                vPassword.SendToBack()
                MsgBox("You are now Logged In.")
                Me.Hide()
                Dim MainFrm As New Main
                MainFrm.Show()
            End If
        End If
    End Sub

    'Private Sub LogIn_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
    '    Dim MainFrm As New Main
    '    MainFrm.Show()
    '    Me.Close()
    'End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        End
    End Sub

    Private Sub LogIn_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        z = "select * from master..syscotab where fldchk = 'MICdbSVR'"
        If FindValue(z) = "" Then
            MsgBox("Please contact the Administrator to connect the Live Server.")
            End
        End If
    End Sub
End Class
