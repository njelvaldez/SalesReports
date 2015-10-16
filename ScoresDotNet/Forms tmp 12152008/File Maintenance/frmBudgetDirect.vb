Imports System.Data.SqlClient
Public Class frmBudgetDirect
    Inherits System.Windows.Forms.Form
    Private EditMode As Boolean = False
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
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents aAmt As System.Windows.Forms.TextBox
    Friend WithEvents oAmt As System.Windows.Forms.TextBox
    Friend WithEvents aQty As System.Windows.Forms.TextBox
    Friend WithEvents oQty As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtRownumber As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmBudgetDirect))
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtEnd = New System.Windows.Forms.DateTimePicker
        Me.dtStart = New System.Windows.Forms.DateTimePicker
        Me.txtItem = New System.Windows.Forms.TextBox
        Me.aAmt = New System.Windows.Forms.TextBox
        Me.oAmt = New System.Windows.Forms.TextBox
        Me.aQty = New System.Windows.Forms.TextBox
        Me.oQty = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.txtDesc = New System.Windows.Forms.TextBox
        Me.txtRownumber = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 8)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(552, 224)
        Me.DataGrid1.TabIndex = 0
        Me.DataGrid1.Tag = "View"
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(432, 424)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.TabIndex = 84
        Me.cmdExit.Tag = "Exit"
        Me.cmdExit.Text = "Exit"
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(192, 424)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.TabIndex = 82
        Me.cmdAdd.Tag = "Add"
        Me.cmdAdd.Text = "Add"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(384, 346)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "Quantity"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(272, 346)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Amount"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(192, 392)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 23)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Adjusted"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(192, 368)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 23)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Original"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(192, 328)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(352, 8)
        Me.GroupBox1.TabIndex = 77
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(192, 296)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 23)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "End Date"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(192, 272)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 23)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "Start Date"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtEnd
        '
        Me.dtEnd.Location = New System.Drawing.Point(272, 296)
        Me.dtEnd.Name = "dtEnd"
        Me.dtEnd.TabIndex = 74
        Me.dtEnd.Tag = "Input"
        '
        'dtStart
        '
        Me.dtStart.Location = New System.Drawing.Point(272, 272)
        Me.dtStart.Name = "dtStart"
        Me.dtStart.TabIndex = 73
        Me.dtStart.Tag = "Input"
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(272, 248)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(48, 20)
        Me.txtItem.TabIndex = 72
        Me.txtItem.Tag = "Input"
        Me.txtItem.Text = ""
        '
        'aAmt
        '
        Me.aAmt.Location = New System.Drawing.Point(272, 392)
        Me.aAmt.Name = "aAmt"
        Me.aAmt.TabIndex = 68
        Me.aAmt.Tag = "Input"
        Me.aAmt.Text = ""
        Me.aAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'oAmt
        '
        Me.oAmt.Location = New System.Drawing.Point(272, 368)
        Me.oAmt.Name = "oAmt"
        Me.oAmt.TabIndex = 67
        Me.oAmt.Tag = "Input"
        Me.oAmt.Text = ""
        Me.oAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'aQty
        '
        Me.aQty.Location = New System.Drawing.Point(384, 392)
        Me.aQty.Name = "aQty"
        Me.aQty.TabIndex = 66
        Me.aQty.Tag = "Input"
        Me.aQty.Text = ""
        Me.aQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'oQty
        '
        Me.oQty.Location = New System.Drawing.Point(384, 368)
        Me.oQty.Name = "oQty"
        Me.oQty.TabIndex = 65
        Me.oQty.Tag = "Input"
        Me.oQty.Text = ""
        Me.oQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(192, 248)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 23)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Item"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(8, 408)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.TabIndex = 70
        Me.btnRefresh.Tag = "View"
        Me.btnRefresh.Text = "Refresh"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(8, 248)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 69
        Me.MonthCalendar1.Tag = "View"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(352, 424)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.TabIndex = 85
        Me.cmdCancel.Tag = "Cancel"
        Me.cmdCancel.Text = "Cancel"
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(272, 424)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.TabIndex = 83
        Me.cmdEdit.Tag = "Edit"
        Me.cmdEdit.Text = "Edit"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(272, 424)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.TabIndex = 87
        Me.cmdSave.Tag = "Save"
        Me.cmdSave.Text = "Save"
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(352, 424)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.TabIndex = 86
        Me.cmdDelete.Tag = "Delete"
        Me.cmdDelete.Text = "Delete"
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(320, 248)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(240, 20)
        Me.txtDesc.TabIndex = 88
        Me.txtDesc.Tag = "Input"
        Me.txtDesc.Text = ""
        '
        'txtRownumber
        '
        Me.txtRownumber.Location = New System.Drawing.Point(361, 272)
        Me.txtRownumber.Name = "txtRownumber"
        Me.txtRownumber.Size = New System.Drawing.Size(88, 20)
        Me.txtRownumber.TabIndex = 89
        Me.txtRownumber.Tag = "Input"
        Me.txtRownumber.Text = ""
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(208, 248)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 23)
        Me.Button1.TabIndex = 90
        Me.Button1.Tag = "Input"
        '
        'frmBudgetDirect
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(570, 456)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtEnd)
        Me.Controls.Add(Me.dtStart)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.aAmt)
        Me.Controls.Add(Me.oAmt)
        Me.Controls.Add(Me.aQty)
        Me.Controls.Add(Me.oQty)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.txtRownumber)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdEdit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmBudgetDirect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mercury Direct Budget"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Load_Grid()
    End Sub
    Private Function MyCommissionDate() As String
        Dim myString As String
        With MonthCalendar1
            myString = CStr(Month(.SelectionStart())) & "/1/" & CStr(Year(.SelectionStart()))
        End With
        Return myString
    End Function
    Private Sub Load_Grid()
        Dim LocalObject As New BusinessLayer.clsMercuryDirectBudget
        Dim LocalDs As New BudgetDirect_Show
        Dim Params(0) As SqlParameter
        Dim CommissionDate As New SqlParameter("@CommissionDate", SqlDbType.DateTime, 10)
        CommissionDate.Direction = ParameterDirection.Input : CommissionDate.Value = MyCommissionDate()
        Params(0) = CommissionDate
        LocalObject.BudgetDirect_Show(ServerPath2, "BudgetDirect_Show", CommandType.StoredProcedure, _
        LocalDs, "BudgetDirect_Show", Params)
        DataGrid1.DataSource = LocalDs.BudgetDirect_Show
    End Sub

    Private Sub frmBudgetDirect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlMaintenance.EnableControls(Me, False)
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        ControlMaintenance.EnableControls(Me, True)
        ControlMaintenance.ClearInputControls(Me)
        EditMode = False
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        ControlMaintenance.EnableControls(Me, False)
        If EditMode = False Then
            BudgetDirect_Insert()
        Else
            BudgetDirect_Update()
        End If
        Load_Grid()
    End Sub
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        ControlMaintenance.EnableControls(Me, False)
        EditMode = False
    End Sub
    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        ControlMaintenance.EnableControls(Me, True)
        EditMode = True
    End Sub
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
    Private Sub DataGrid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.Click, DataGrid1.CurrentCellChanged
        With DataGrid1
            txtItem.Text = CStr(.Item(.CurrentCell.RowNumber, 0))
            txtDesc.Text = CStr(.Item(.CurrentCell.RowNumber, 1))
            oAmt.Text = CStr(.Item(.CurrentCell.RowNumber, 2))
            oQty.Text = CStr(.Item(.CurrentCell.RowNumber, 3))
            aAmt.Text = CStr(.Item(.CurrentCell.RowNumber, 4))
            aQty.Text = CStr(.Item(.CurrentCell.RowNumber, 5))
            dtStart.Text = CStr(.Item(.CurrentCell.RowNumber, 6))
            dtEnd.Text = CStr(.Item(.CurrentCell.RowNumber, 7))
            txtRownumber.Text = CStr(.Item(.CurrentCell.RowNumber, 8))
        End With
    End Sub
    Private Sub BudgetDirect_Insert()
        Dim BusinessObject As New BusinessLayer.clsMercuryDirectBudget
        Dim Params(6) As SqlParameter
        Dim ItemCode As New SqlParameter("@ItemCode", SqlDbType.VarChar, 10) : ItemCode.Direction = ParameterDirection.Input : ItemCode.Value = txtItem.Text : Params(0) = ItemCode
        Dim StartDate As New SqlParameter("@StartDate", SqlDbType.DateTime, 10) : StartDate.Direction = ParameterDirection.Input : StartDate.Value = Format(dtStart.Value, "Short Date") : Params(1) = StartDate
        Dim EndDate As New SqlParameter("@EndDate", SqlDbType.DateTime, 10) : EndDate.Direction = ParameterDirection.Input : EndDate.Value = Format(dtEnd.Value, "Short Date") : Params(2) = EndDate
        Dim oAmount As New SqlParameter("@oAmount", SqlDbType.Money) : oAmount.Direction = ParameterDirection.Input : oAmount.Value = oAmt.Text : Params(3) = oAmount
        Dim oQuantity As New SqlParameter("@oQty", SqlDbType.Int) : oQuantity.Direction = ParameterDirection.Input : oQuantity.Value = oQty.Text : Params(4) = oQuantity
        Dim aAmount As New SqlParameter("@aAmount", SqlDbType.Money) : aAmount.Direction = ParameterDirection.Input : aAmount.Value = aAmt.Text : Params(5) = aAmount
        Dim aQuantity As New SqlParameter("@aQty", SqlDbType.Int) : aQuantity.Direction = ParameterDirection.Input : aQuantity.Value = aQty.Text : Params(6) = aQuantity
        BusinessObject.BudgetDirect_Insert(ServerPath2, "BudgetDirect_Insert", CommandType.StoredProcedure, Params)
    End Sub
    Private Sub BudgetDirect_Update()
        Dim BusinessObject As New BusinessLayer.clsMercuryDirectBudget
        Dim Params(7) As SqlParameter
        Dim ItemCode As New SqlParameter("@ItemCode", SqlDbType.VarChar, 10) : ItemCode.Direction = ParameterDirection.Input : ItemCode.Value = txtItem.Text : Params(0) = ItemCode
        Dim StartDate As New SqlParameter("@StartDate", SqlDbType.DateTime, 10) : StartDate.Direction = ParameterDirection.Input : StartDate.Value = Format(dtStart.Value, "Short Date") : Params(1) = StartDate
        Dim EndDate As New SqlParameter("@EndDate", SqlDbType.DateTime, 10) : EndDate.Direction = ParameterDirection.Input : EndDate.Value = Format(dtEnd.Value, "Short Date") : Params(2) = EndDate
        Dim oAmount As New SqlParameter("@oAmount", SqlDbType.Money) : oAmount.Direction = ParameterDirection.Input : oAmount.Value = oAmt.Text : Params(3) = oAmount
        Dim oQuantity As New SqlParameter("@oQty", SqlDbType.Int) : oQuantity.Direction = ParameterDirection.Input : oQuantity.Value = oQty.Text : Params(4) = oQuantity
        Dim aAmount As New SqlParameter("@aAmount", SqlDbType.Money) : aAmount.Direction = ParameterDirection.Input : aAmount.Value = aAmt.Text : Params(5) = aAmount
        Dim aQuantity As New SqlParameter("@aQty", SqlDbType.Int) : aQuantity.Direction = ParameterDirection.Input : aQuantity.Value = aQty.Text : Params(6) = aQuantity
        Dim RowNumber As New SqlParameter("@RowNumber", SqlDbType.Int) : RowNumber.Direction = ParameterDirection.Input : RowNumber.Value = txtRownumber.Text : Params(7) = RowNumber
        BusinessObject.BudgetDirect_Update(ServerPath2, "BudgetDirect_Update", CommandType.StoredProcedure, Params)
    End Sub
    Private Sub BudgetDirect_Delete()
        Dim BusinessObject As New BusinessLayer.clsMercuryDirectBudget
        Dim Params(0) As SqlParameter
        Dim RowNumber As New SqlParameter("@RowNumber", SqlDbType.Int) : RowNumber.Direction = ParameterDirection.Input : RowNumber.Value = txtRownumber.Text : Params(0) = RowNumber
        BusinessObject.BudgetDirect_Delete(ServerPath2, "BudgetDirect_Delete", CommandType.StoredProcedure, Params)
    End Sub
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If txtRownumber.Text > "" Then
            If MessageBox.Show("Are you sure you want to delete this record!", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                BudgetDirect_Delete()
                Load_Grid()
                ControlMaintenance.ClearInputControls(Me)
            End If
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim MyLoadedForm As New frmItem
        MyLoadedForm.ShowDialog()
        With MyLoadedForm
            If MyLoadedForm.DialogResult = DialogResult.OK Then
                txtItem.Text = .PropArray(0)
                txtDesc.Text = .PropArray(1)
            End If
        End With
    End Sub
End Class
