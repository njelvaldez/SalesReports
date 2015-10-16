<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransferSalesToSP
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
        Me.dgvSalesToTransfer = New System.Windows.Forms.DataGridView()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTransferSalesToSP = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtSpecialistCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvSalesToTransfer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSalesToTransfer
        '
        Me.dgvSalesToTransfer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSalesToTransfer.Location = New System.Drawing.Point(12, 79)
        Me.dgvSalesToTransfer.Name = "dgvSalesToTransfer"
        Me.dgvSalesToTransfer.Size = New System.Drawing.Size(1309, 545)
        Me.dgvSalesToTransfer.TabIndex = 59
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(132, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(326, 21)
        Me.ComboBox1.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Transfer Sales To :"
        '
        'btnTransferSalesToSP
        '
        Me.btnTransferSalesToSP.Location = New System.Drawing.Point(474, 10)
        Me.btnTransferSalesToSP.Name = "btnTransferSalesToSP"
        Me.btnTransferSalesToSP.Size = New System.Drawing.Size(85, 23)
        Me.btnTransferSalesToSP.TabIndex = 62
        Me.btnTransferSalesToSP.Text = "Transfer"
        Me.btnTransferSalesToSP.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(565, 10)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(85, 23)
        Me.btnClose.TabIndex = 63
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtSpecialistCode
        '
        Me.txtSpecialistCode.Enabled = False
        Me.txtSpecialistCode.Location = New System.Drawing.Point(132, 39)
        Me.txtSpecialistCode.Name = "txtSpecialistCode"
        Me.txtSpecialistCode.Size = New System.Drawing.Size(326, 20)
        Me.txtSpecialistCode.TabIndex = 64
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Specialist Code :"
        '
        'frmTransferSalesToSP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1333, 648)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSpecialistCode)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnTransferSalesToSP)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.dgvSalesToTransfer)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTransferSalesToSP"
        Me.Text = "Transfer Sales to SP"
        CType(Me.dgvSalesToTransfer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvSalesToTransfer As System.Windows.Forms.DataGridView
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnTransferSalesToSP As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtSpecialistCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
