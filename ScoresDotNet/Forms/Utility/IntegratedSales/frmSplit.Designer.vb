<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplitSalesTransaction
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSplitSalesTransaction = New System.Windows.Forms.Button()
        Me.dgvSource = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtrowid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnewrowid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtquantity1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtquantity = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtamount2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtquantity2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtamount = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtamount1 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvdestination = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtunitprice = New System.Windows.Forms.TextBox()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvdestination, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvSource)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 124)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1309, 248)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Source"
        '
        'btnSplitSalesTransaction
        '
        Me.btnSplitSalesTransaction.Location = New System.Drawing.Point(907, 18)
        Me.btnSplitSalesTransaction.Name = "btnSplitSalesTransaction"
        Me.btnSplitSalesTransaction.Size = New System.Drawing.Size(131, 38)
        Me.btnSplitSalesTransaction.TabIndex = 66
        Me.btnSplitSalesTransaction.Text = "&Split Sales"
        Me.btnSplitSalesTransaction.UseVisualStyleBackColor = True
        '
        'dgvSource
        '
        Me.dgvSource.AllowDrop = True
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvSource.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSource.Location = New System.Drawing.Point(22, 19)
        Me.dgvSource.Name = "dgvSource"
        Me.dgvSource.Size = New System.Drawing.Size(1266, 212)
        Me.dgvSource.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnclose)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtunitprice)
        Me.GroupBox2.Controls.Add(Me.btnSplitSalesTransaction)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtamount1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtamount)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtquantity2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtamount2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtquantity1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtquantity)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtnewrowid)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtrowid)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1309, 100)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Split Options"
        '
        'txtrowid
        '
        Me.txtrowid.Location = New System.Drawing.Point(92, 19)
        Me.txtrowid.Name = "txtrowid"
        Me.txtrowid.ReadOnly = True
        Me.txtrowid.Size = New System.Drawing.Size(100, 20)
        Me.txtrowid.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Row ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "New Row ID"
        '
        'txtnewrowid
        '
        Me.txtnewrowid.Location = New System.Drawing.Point(92, 45)
        Me.txtnewrowid.Name = "txtnewrowid"
        Me.txtnewrowid.ReadOnly = True
        Me.txtnewrowid.Size = New System.Drawing.Size(100, 20)
        Me.txtnewrowid.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(255, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Quantity 1"
        '
        'txtquantity1
        '
        Me.txtquantity1.Location = New System.Drawing.Point(325, 45)
        Me.txtquantity1.Name = "txtquantity1"
        Me.txtquantity1.Size = New System.Drawing.Size(100, 20)
        Me.txtquantity1.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(255, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Quantity "
        '
        'txtquantity
        '
        Me.txtquantity.Location = New System.Drawing.Point(325, 15)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.ReadOnly = True
        Me.txtquantity.Size = New System.Drawing.Size(100, 20)
        Me.txtquantity.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(467, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Amount 2"
        '
        'txtamount2
        '
        Me.txtamount2.Location = New System.Drawing.Point(537, 74)
        Me.txtamount2.Name = "txtamount2"
        Me.txtamount2.Size = New System.Drawing.Size(100, 20)
        Me.txtamount2.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(255, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Quantity 2"
        '
        'txtquantity2
        '
        Me.txtquantity2.Location = New System.Drawing.Point(325, 73)
        Me.txtquantity2.Name = "txtquantity2"
        Me.txtquantity2.Size = New System.Drawing.Size(100, 20)
        Me.txtquantity2.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(467, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Amount"
        '
        'txtamount
        '
        Me.txtamount.Location = New System.Drawing.Point(537, 19)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.ReadOnly = True
        Me.txtamount.Size = New System.Drawing.Size(100, 20)
        Me.txtamount.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(467, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Amount 1"
        '
        'txtamount1
        '
        Me.txtamount1.Location = New System.Drawing.Point(537, 48)
        Me.txtamount1.Name = "txtamount1"
        Me.txtamount1.Size = New System.Drawing.Size(100, 20)
        Me.txtamount1.TabIndex = 14
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvdestination)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 378)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1309, 248)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Destination"
        '
        'dgvdestination
        '
        Me.dgvdestination.AllowDrop = True
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvdestination.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvdestination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdestination.Location = New System.Drawing.Point(22, 19)
        Me.dgvdestination.Name = "dgvdestination"
        Me.dgvdestination.Size = New System.Drawing.Size(1266, 212)
        Me.dgvdestination.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(693, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "Unit Price"
        '
        'txtunitprice
        '
        Me.txtunitprice.Location = New System.Drawing.Point(764, 19)
        Me.txtunitprice.Name = "txtunitprice"
        Me.txtunitprice.ReadOnly = True
        Me.txtunitprice.Size = New System.Drawing.Size(100, 20)
        Me.txtunitprice.TabIndex = 67
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(1044, 18)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(131, 38)
        Me.btnclose.TabIndex = 69
        Me.btnclose.Text = "&Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'frmSplitSalesTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1333, 648)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSplitSalesTransaction"
        Me.Text = "Split Sales Transaction"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvdestination, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSplitSalesTransaction As System.Windows.Forms.Button
    Friend WithEvents dgvSource As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtquantity2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtamount2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtquantity1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtquantity As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnewrowid As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtrowid As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtamount1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvdestination As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtunitprice As System.Windows.Forms.TextBox
    Friend WithEvents btnclose As System.Windows.Forms.Button
End Class
