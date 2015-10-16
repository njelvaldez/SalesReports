Imports System.Data.SqlClient
Public Class frmSMIncTemplate
    Inherits System.Windows.Forms.Form
    Private RemoteDataSet As New CodeTablesDS
    Private EditMode As Boolean = False
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        modControlBehavior.EnableControlsGroup(Me, True)
        ControlMaintenance.ClearInputControls(Me)
        EditMode = False
    End Sub
    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If txtEmployeeID.Text = "" Then
            MessageBox.Show("Please select a record to modify!", "Record Selection", MessageBoxButtons.OK, _
            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            modControlBehavior.EnableControlsGroup(Me, True)
            EditMode = True
        End If
    End Sub
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If txtRowid.Text > "" Then
            If (MessageBox.Show("Do you really want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, _
            MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)) = DialogResult.Yes Then
                Sub_Delete()
                ControlMaintenance.ClearInputControls(Me)
                Sub_Show()
            End If
        End If
    End Sub
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        modControlBehavior.EnableControls(Me, False)
        ControlMaintenance.ClearInputControls(Me)
        EditMode = False
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim Params(0) As String
        Params(0) = txtRowid.Text
        If EditMode = False Then
            Sub_Insert()
        Else
            Sub_Update()
        End If
        Sub_Show()
        Sub_Select(Params, CStr(IIf(EditMode = False, "Insert", "Update")))
        EditMode = False
        modControlBehavior.EnableControls(Me, False)
    End Sub
    Private Sub Sub_Insert()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(4) As SqlParameter
            Dim Employee_ID As New SqlParameter("@Employee_ID", SqlDbType.VarChar, 10) : Employee_ID.Direction = ParameterDirection.Input : Employee_ID.Value = txtEmployeeID.Text : Params(0) = Employee_ID
            Dim ManagerName As New SqlParameter("@ManagerName", SqlDbType.VarChar, 50) : ManagerName.Direction = ParameterDirection.Input : ManagerName.Value = txtManagerName.Text : Params(1) = ManagerName
            Dim Position As New SqlParameter("@Position", SqlDbType.VarChar, 20) : Position.Direction = ParameterDirection.Input : Position.Value = txtPosition.Text : Params(2) = Position
            Dim DivCode As New SqlParameter("@DivCode", SqlDbType.VarChar, 10) : DivCode.Direction = ParameterDirection.Input : DivCode.Value = txtDivCode.Text : Params(3) = DivCode
            Dim DivName As New SqlParameter("@DivName", SqlDbType.VarChar, 50) : DivName.Direction = ParameterDirection.Input : DivName.Value = txtDivName.Text : Params(4) = DivName

            BusinessObject.Sub_Insert(ServerPath2, "Util_SMIncTemplateInsert", CommandType.StoredProcedure, Params)
            LogHelper.InsertLog("Util_SMIncTemplateInsert.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("Util_SMIncTemplateInsert.Error : " & ex.Message)
        End Try
    End Sub
    Private Sub Sub_Update()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(5) As SqlParameter
            Dim Employee_ID As New SqlParameter("@Employee_ID", SqlDbType.VarChar, 10) : Employee_ID.Direction = ParameterDirection.Input : Employee_ID.Value = txtEmployeeID.Text : Params(0) = Employee_ID
            Dim ManagerName As New SqlParameter("@ManagerName", SqlDbType.VarChar, 50) : ManagerName.Direction = ParameterDirection.Input : ManagerName.Value = txtManagerName.Text : Params(1) = ManagerName
            Dim Position As New SqlParameter("@Position", SqlDbType.VarChar, 20) : Position.Direction = ParameterDirection.Input : Position.Value = txtPosition.Text : Params(2) = Position
            Dim DivCode As New SqlParameter("@DivCode", SqlDbType.VarChar, 10) : DivCode.Direction = ParameterDirection.Input : DivCode.Value = txtDivCode.Text : Params(3) = DivCode
            Dim DivName As New SqlParameter("@DivName", SqlDbType.VarChar, 50) : DivName.Direction = ParameterDirection.Input : DivName.Value = txtDivName.Text : Params(4) = DivName
            Dim rowid As New SqlParameter("@rowid", SqlDbType.Int, 10) : rowid.Direction = ParameterDirection.Input : rowid.Value = txtRowid.Text : Params(5) = rowid

            BusinessObject.Sub_Insert(ServerPath2, "Util_SMIncTemplateUpdate", CommandType.StoredProcedure, Params)
            LogHelper.InsertLog("Util_SMIncTemplateUpdate.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("Util_SMIncTemplateUpdate.Error: " & ex.Message)

        End Try
    End Sub
    Private Sub Sub_Show()
        Try
            ResetDataset()
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            BusinessObject.Sub_Show(ServerPath2, "SMIncTemplate_Show", CommandType.StoredProcedure, RemoteDataSet, "Area")
            DataGrid1.DataSource = RemoteDataSet.Tables("Area")
            LogHelper.InsertLog("SMIncTemplate_Show.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("SMIncTemplate_Show.Error: " & ex.Message)
        End Try
    End Sub
    Private Sub Sub_Select(ByVal dbParams() As String, ByVal UpdateMode As String)
        'select case if add,edit or delete
        Dim i As Integer
        Dim myRowid As Integer
        Select Case UpdateMode
            Case "Insert"
                Dim BusinessObject As New BusinessLayer.clsFileMaintenance
                myRowid = CInt(BusinessObject.Sub_ReturnIntegerResult(ServerPath2, "SMIncTemplate_GetInsertedRowid", CommandType.StoredProcedure))
            Case "Update"
                myRowid = CInt(dbParams(0))
        End Select
        For i = 0 To (RemoteDataSet.Tables("Area").Rows.Count - 1)
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
    Private Sub Sub_Delete()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim Rowid As New SqlParameter("@Rowid", SqlDbType.Int) : Rowid.Direction = ParameterDirection.Input : Rowid.Value = txtRowid.Text : Params(0) = Rowid
            BusinessObject.Sub_Delete(ServerPath2, "SMIncTemplate_Delete", CommandType.StoredProcedure, Params)
            LogHelper.InsertLog("SMIncTemplate_Delete.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("SMIncTemplate_Delete.Error: " & ex.Message)
        End Try
    End Sub
    Private Sub frmSMIncTemplate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim salescycledate As String
        salescycledate = Now.Date.Month.ToString.Trim & "/1/" & Now.Date.Year.ToString.Trim

        modControlBehavior.EnableControls(Me, False)
        'Auto Create SMIncTemplate Setup for current Month
        'AutoCreateSMIncTemplate(salescycledate)
        RemoteDataSet.Tables.Add("Area")
        Sub_Show()
    End Sub
    Private Sub AutoCreateSMIncTemplate(salescycledate As String)
        Try
            If Not SMIncTemplateExists(Convert.ToDateTime(salescycledate)) Then
                SMIncTemplateCopy(Convert.ToDateTime(salescycledate))
            End If
        Catch ex As Exception
            MsgBox("Error in : " & ex.Message)
        End Try
    End Sub

    Private Sub DataGrid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.CurrentCellChanged, DataGrid1.Click
        With DataGrid1
            txtRowid.Text = CStr(.Item(.CurrentCell.RowNumber, 0))
            txtEmployeeID.Text = CStr(.Item(.CurrentCell.RowNumber, 1))
            txtManagerName.Text = CStr(.Item(.CurrentCell.RowNumber, 2))
            txtPosition.Text = CStr(.Item(.CurrentCell.RowNumber, 3))
            txtDivCode.Text = CStr(.Item(.CurrentCell.RowNumber, 4))
            txtDivName.Text = CStr(.Item(.CurrentCell.RowNumber, 5))
            .Select(.CurrentCell.RowNumber)
        End With
    End Sub

    Private Sub Frm_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        EnDisMainMenu(Me, True)
        'ChildCtr = ChildCtr - 1              '<--ready for 2forms need
    End Sub

    Private Sub Frm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        EnDisMainMenu(Me, False)
    End Sub

    Private Sub frmProcessInMarketData_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        'If CloseFrm = True Then              '<- ready
        '    CloseFrm = False                 '<- for
        '    Close()                          '<- 2forms
        'End If                               '<- need
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)
        Sub_Show()
    End Sub

    Private Sub ResetDataset()
        RemoteDataSet.Tables.Remove("Area")
        RemoteDataSet.Tables.Add("Area")
    End Sub
    Private Sub btnCopyPrevSetup_Click(sender As Object, e As EventArgs) Handles btnCopyPrevSetup.Click
        If IsDate(txtSalesDate.Text.ToString) Then
            AutoCreateSMIncTemplate(txtSalesDate.Text.ToString)
            Sub_Show()
        Else
            MsgBox("Please input valid Sales Date!")
        End If
    End Sub
End Class