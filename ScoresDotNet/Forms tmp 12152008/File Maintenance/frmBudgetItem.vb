Imports System.Data.SqlClient
Public Class frmBudgetItem
    Inherits System.Windows.Forms.Form
    Dim varMode As Boolean
    Dim varListItem As ListViewItem
    Dim varMrCode As String
    Public Property EditMode() As Boolean
        Get
            Return varMode
        End Get
        Set(ByVal Value As Boolean)
            varMode = Value
        End Set
    End Property
    Public Property myListItem() As ListViewItem
        Get
            Return varListItem
        End Get
        Set(ByVal Value As ListViewItem)
            varListItem = Value
        End Set
    End Property
    Public Property myMrCode() As String
        Get
            Return varMrCode
        End Get
        Set(ByVal Value As String)
            varMrCode = Value
        End Set
    End Property

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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnItem As System.Windows.Forms.Button
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents dtStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.txtItem = New System.Windows.Forms.TextBox
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.btnItem = New System.Windows.Forms.Button
        Me.dtStart = New System.Windows.Forms.DateTimePicker
        Me.dtEnd = New System.Windows.Forms.DateTimePicker
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(34, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Start_Date"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "End_Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Amount"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Qty"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(144, 136)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(224, 136)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "&Cancel"
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(93, 16)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(208, 20)
        Me.txtItem.TabIndex = 7
        Me.txtItem.Text = ""
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(93, 85)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(208, 20)
        Me.txtAmount.TabIndex = 8
        Me.txtAmount.Text = ""
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnItem
        '
        Me.btnItem.Location = New System.Drawing.Point(306, 16)
        Me.btnItem.Name = "btnItem"
        Me.btnItem.Size = New System.Drawing.Size(24, 20)
        Me.btnItem.TabIndex = 10
        Me.btnItem.Text = "..."
        '
        'dtStart
        '
        Me.dtStart.CustomFormat = "MMM dd, yyyy"
        Me.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtStart.Location = New System.Drawing.Point(93, 40)
        Me.dtStart.Name = "dtStart"
        Me.dtStart.Size = New System.Drawing.Size(115, 20)
        Me.dtStart.TabIndex = 11
        Me.dtStart.Value = New Date(2005, 3, 9, 0, 0, 0, 0)
        '
        'dtEnd
        '
        Me.dtEnd.CustomFormat = "MMM dd, yyyy"
        Me.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtEnd.Location = New System.Drawing.Point(93, 64)
        Me.dtEnd.Name = "dtEnd"
        Me.dtEnd.Size = New System.Drawing.Size(115, 20)
        Me.dtEnd.TabIndex = 12
        Me.dtEnd.Value = New Date(2005, 3, 9, 0, 0, 0, 0)
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(93, 110)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(208, 20)
        Me.txtQty.TabIndex = 9
        Me.txtQty.Text = ""
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmBudgetItem
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(344, 166)
        Me.Controls.Add(Me.dtEnd)
        Me.Controls.Add(Me.dtStart)
        Me.Controls.Add(Me.btnItem)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmBudgetItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Budget Item"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItem.Click
        Dim myLoadedForm As New frmItem
        myLoadedForm.ShowDialog()
        txtItem.Tag = myLoadedForm.PropArray(0)
        txtItem.Text = myLoadedForm.PropArray(1)
    End Sub
    Private Sub txtAmount_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAmount.LostFocus
        FormatMoneyText(txtAmount)
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            Dim myCommand As New SqlCommand
            With myCommand
                .Connection = myConnection(ScoresDotNetConnectionString)
                Select Case EditMode
                    Case True
                        .CommandText = "Update NewScores..Budget set ItemCode=" & "'" & CStr(txtItem.Tag) & "'" & _
                                        ", Start_Date=" & dtStart.Value & ", End_Date=" & dtEnd.Value & _
                                        ", Amount=" & CLng(txtAmount.Text) & ", Qty=" & txtQty.Text & _
                                        " where Rownumber=" & CInt(myListItem.SubItems(6).Text)
                        .CommandType = CommandType.Text
                        .ExecuteNonQuery()
                        'Fill up the ListviewItem property passed
                        myListItem.Text = CStr(txtItem.Tag)
                        myListItem.SubItems(1).Text = txtItem.Text
                        myListItem.SubItems(2).Text = CStr(dtStart.Value)
                        myListItem.SubItems(3).Text = CStr(dtEnd.Value)
                        myListItem.SubItems(4).Text = txtAmount.Text
                        myListItem.SubItems(5).Text = txtQty.Text
                    Case False
                        .CommandText = "Budget_InsertItem"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@MrCode", SqlDbType.VarChar, 10).Value = myMrCode
                        .Parameters.Add("@ItemCode", SqlDbType.VarChar, 10).Value = CStr(txtItem.Tag)
                        .Parameters.Add("@StartDate", SqlDbType.DateTime).Value = dtStart.Value
                        .Parameters.Add("@EndDate", SqlDbType.DateTime).Value = dtEnd.Value
                        .Parameters.Add("@Amount", SqlDbType.Money).Value = txtAmount.Text
                        .Parameters.Add("@Qty", SqlDbType.Int).Value = txtQty.Text
                        .Parameters.Add("@Rownumber", SqlDbType.Decimal).Value = 0
                        .ExecuteNonQuery()

                        myListItem.Text = (CStr(txtItem.Tag))
                        myListItem.SubItems(1).Text = txtItem.Text
                        myListItem.SubItems(2).Text = CStr(dtStart.Value)
                        myListItem.SubItems(3).Text = CStr(dtEnd.Value)
                        myListItem.SubItems(4).Text = txtAmount.Text
                        myListItem.SubItems(5).Text = txtQty.Text
                End Select
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Me.Close()
    End Sub
    Private Sub frmBudgetItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case EditMode
            Case True
                txtItem.Tag = myListItem.Text
                txtItem.Text = myListItem.SubItems(1).Text
                dtStart.Value = CDate(myListItem.SubItems(2).Text)
                dtEnd.Value = CDate(myListItem.SubItems(3).Text)
                txtAmount.Text = myListItem.SubItems(4).Text
                txtQty.Text() = myListItem.SubItems(5).Text
        End Select
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
