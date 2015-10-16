<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUnCredit
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
        Me.btnUnCreditSales = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.dgvSalesToTransfer = New System.Windows.Forms.DataGridView()
        CType(Me.dgvSalesToTransfer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUnCreditSales
        '
        Me.btnUnCreditSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnCreditSales.ForeColor = System.Drawing.Color.Black
        Me.btnUnCreditSales.Location = New System.Drawing.Point(718, 11)
        Me.btnUnCreditSales.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUnCreditSales.Name = "btnUnCreditSales"
        Me.btnUnCreditSales.Size = New System.Drawing.Size(127, 37)
        Me.btnUnCreditSales.TabIndex = 69
        Me.btnUnCreditSales.Text = "Un-Credit Sales"
        Me.btnUnCreditSales.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(18, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(651, 36)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Warning : Please be careful in using this feature.  Review all sales trasactions " & _
    "below. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This process will un-credit all sales of TM,Specialist, Trade TM and Tr" & _
    "ade Specialist"
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(850, 12)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(77, 37)
        Me.btnClose.TabIndex = 71
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'dgvSalesToTransfer
        '
        Me.dgvSalesToTransfer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSalesToTransfer.Location = New System.Drawing.Point(22, 74)
        Me.dgvSalesToTransfer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvSalesToTransfer.Name = "dgvSalesToTransfer"
        Me.dgvSalesToTransfer.Size = New System.Drawing.Size(906, 445)
        Me.dgvSalesToTransfer.TabIndex = 72
        '
        'frmUnCredit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 540)
        Me.Controls.Add(Me.dgvSalesToTransfer)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUnCreditSales)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUnCredit"
        Me.Text = "Un-Credit Sales"
        CType(Me.dgvSalesToTransfer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnUnCreditSales As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents dgvSalesToTransfer As System.Windows.Forms.DataGridView
End Class
