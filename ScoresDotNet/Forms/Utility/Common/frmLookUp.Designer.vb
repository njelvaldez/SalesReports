<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLookUp
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnAddList = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtItemDescription = New System.Windows.Forms.TextBox()
        Me.dgvLookup = New System.Windows.Forms.DataGridView()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAddAll = New System.Windows.Forms.Button()
        Me.gb1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAddList
        '
        Me.btnAddList.Location = New System.Drawing.Point(379, 9)
        Me.btnAddList.Name = "btnAddList"
        Me.btnAddList.Size = New System.Drawing.Size(96, 23)
        Me.btnAddList.TabIndex = 0
        Me.btnAddList.Text = "Add to List"
        Me.btnAddList.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Description"
        '
        'txtItemDescription
        '
        Me.txtItemDescription.Location = New System.Drawing.Point(89, 12)
        Me.txtItemDescription.Name = "txtItemDescription"
        Me.txtItemDescription.Size = New System.Drawing.Size(279, 20)
        Me.txtItemDescription.TabIndex = 2
        '
        'dgvLookup
        '
        Me.dgvLookup.AllowDrop = True
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvLookup.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvLookup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLookup.Location = New System.Drawing.Point(6, 28)
        Me.dgvLookup.Name = "dgvLookup"
        Me.dgvLookup.Size = New System.Drawing.Size(637, 301)
        Me.dgvLookup.TabIndex = 3
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(583, 9)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnAddAll
        '
        Me.btnAddAll.Location = New System.Drawing.Point(481, 9)
        Me.btnAddAll.Name = "btnAddAll"
        Me.btnAddAll.Size = New System.Drawing.Size(96, 23)
        Me.btnAddAll.TabIndex = 5
        Me.btnAddAll.Text = "Add All to List"
        Me.btnAddAll.UseVisualStyleBackColor = True
        '
        'gb1
        '
        Me.gb1.Controls.Add(Me.dgvLookup)
        Me.gb1.Location = New System.Drawing.Point(14, 54)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(649, 335)
        Me.gb1.TabIndex = 6
        Me.gb1.TabStop = False
        Me.gb1.Text = "Total no of records : 0"
        '
        'frmLookUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 401)
        Me.Controls.Add(Me.gb1)
        Me.Controls.Add(Me.btnAddAll)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtItemDescription)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAddList)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLookUp"
        Me.Text = "LookUp"
        CType(Me.dgvLookup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddList As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtItemDescription As System.Windows.Forms.TextBox
    Friend WithEvents dgvLookup As System.Windows.Forms.DataGridView
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnAddAll As System.Windows.Forms.Button
    Friend WithEvents gb1 As System.Windows.Forms.GroupBox
End Class
