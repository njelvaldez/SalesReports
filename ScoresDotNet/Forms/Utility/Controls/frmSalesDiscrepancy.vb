Imports System.Data.SqlClient
Public Class frmSalesDiscrepancy
    Inherits System.Windows.Forms.Form
    Private RemoteDataSet As New DataSet
    Private EditMode As Boolean = False
    Private _ToolTip As New ToolTip()
    Private clickcount As Integer = 0
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        'modControlBehavior.EnableControlsGroup(Me, True)
        'ControlMaintenance.ClearInputControlsGroup(Me)
        'EditMode = False
        MsgBox("Add is not allowed!")
    End Sub
    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If txtSubdist_code.Text = "" And txtSubdistributor.Text = "" Then
            MessageBox.Show("Please select a record to modify!", "Record Selection", MessageBoxButtons.OK, _
            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            modControlBehavior.EnableControlsGroup(Me, True)
            EditMode = True
        End If
    End Sub
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        'If txtRowid.Text > "" Then
        '    If (MessageBox.Show("Do you really want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, _
        '    MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then
        '        Sub_Delete()
        '        ControlMaintenance.ClearInputControlsGroup(Me)
        '        Sub_Show()
        '    End If
        'End If
        MsgBox("Delete is not allowed!")
    End Sub
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        modControlBehavior.EnableControlsGroup(Me, False)
        ControlMaintenance.ClearInputControlsGroup(Me)
        EditMode = False
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        Dim Params(0) As String
        Params(0) = txtRowid.Text
        If EditMode = False Then
            'Sub_Insert()
        Else
            Sub_Update()
        End If
        Sub_Show()
        Sub_Select(Params, CStr(IIf(EditMode = False, "Insert", "Update")))
        EditMode = False
        modControlBehavior.EnableControlsGroup(Me, False)
    End Sub
    Private Sub Sub_Update()
        Try
            Dim subdist_code As String = ""
            Dim subdistributor As String = ""
            Dim commissiondate As DateTime
            Dim amountsoldinput As Double
            subdist_code = txtSubdist_code.Text.Trim
            subdistributor = txtSubdistributor.Text.Trim
            commissiondate = Convert.ToDateTime(txtCommissionDate.Text.Trim)
            amountsoldinput = Convert.ToDouble(txtAmountSoldInput.Text.Trim)
            SalesControl.UpdateSalesControlInput(subdist_code, subdistributor, commissiondate, amountsoldinput)
            LogHelper.InsertLog("UpdateSalesControlInput.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("UpdateSalesControlInput.Error: " & ex.Message)
        End Try

    End Sub
    Private Sub Sub_Show()
        Try
            If RemoteDataSet.Tables("ProductFormCT_Show").Rows.Count > 0 Then RemoteDataSet.Tables("ProductFormCT_Show").Clear()
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            BusinessObject.Sub_Show(ServerPath2, "Util_SalesControlSelect", CommandType.StoredProcedure, RemoteDataSet, "ProductFormCT_Show")
            DataGrid1.DataSource = RemoteDataSet.Tables("ProductFormCT_Show")
            GroupBox1.Text = "Sales Discrepancy Count : " & RemoteDataSet.Tables(0).Rows.Count.ToString
            LogHelper.InsertLog("ProductFormCT_Show.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("ProductFormCT_Show.Error: " & ex.Message)
        End Try

    End Sub
    Private Sub Sub_Select(ByVal dbParams() As String, ByVal UpdateMode As String)
        'select case if add,edit or delete
        Dim i As Integer
        Dim myRowid As Integer
        Select Case UpdateMode
            Case "Update"
                myRowid = CInt(dbParams(0))
        End Select
        For i = 0 To (RemoteDataSet.Tables("ProductFormCT_Show").Rows.Count - 1)
            With DataGrid1
                If myRowid = CInt(.Item(i, 0)) Then
                    .CurrentCell = New DataGridCell(i, 0)
                    Dim e As System.EventArgs
                    DataGrid1_Click(Me, e)
                    Exit For
                End If
            End With
        Next
    End Sub
    Private Sub ProductFormCT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        modControlBehavior.EnableControlsGroup(Me, False)
        RemoteDataSet.Tables.Add("ProductFormCT_Show")
        Sub_Show()
    End Sub
    Private Sub DataGrid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.Click, DataGrid1.CurrentCellChanged
        'rowid,commissiondate,subdist_code,subdistributor,amountsold,amountsoldinput
        Try
            With DataGrid1
                txtRowid.Text = CStr(.Item(.CurrentCell.RowNumber, 0))
                txtCommissionDate.Text = CStr(.Item(.CurrentCell.RowNumber, 1))
                txtSubdist_code.Text = CStr(.Item(.CurrentCell.RowNumber, 2))
                txtSubdistributor.Text = CStr(.Item(.CurrentCell.RowNumber, 3))
                txtamountsold.Text = CStr(.Item(.CurrentCell.RowNumber, 4))
                txtAmountSoldInput.Text = CStr(.Item(.CurrentCell.RowNumber, 5))
                .Select(.CurrentCell.RowNumber)
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Frm_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        EnDisMainMenu(Me, True)
        'ChildCtr = ChildCtr - 1              '<--ready for 2forms need
    End Sub

    Private Sub Frm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        EnDisMainMenu(Me, False)
    End Sub

    Private Sub frmProcessInMarketData_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
    End Sub

    Private Sub txtamountsoldinput_MouseHover(sender As Object, e As EventArgs) Handles txtAmountSoldInput.MouseHover
        If gUserID.ToUpper.Trim = "ARV" Then
            _ToolTip.Show(txtamountsold.Text, txtamountsold)
        End If
    End Sub

    Private Sub btnAutoCorrect_Click(sender As Object, e As EventArgs) Handles btnAutoCorrect.Click
        SalesControl.AutoCorrectSalesControl()
        MsgBox("Sales Control auto-correct is complete!")
    End Sub

    Private Sub frmSalesDiscrepancy_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Me.MouseDoubleClick
        clickcount = clickcount + 1
        If clickcount >= 8 Then
            btnAutoCorrect.Enabled = True
            btnAutoCorrect.Visible = True
        End If
    End Sub
End Class