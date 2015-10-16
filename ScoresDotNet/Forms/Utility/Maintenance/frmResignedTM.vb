Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Configuration
Imports System.Globalization
Public Class frmResignedTM
    Private RemoteDataSet As New DataSet
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub frmMercurySales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RemoteDataSet.Tables.Add("Area")
        LoadTM()
    End Sub

    Private Sub LoadTM()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            ResetDataset()
            Dim Params2(0) As SqlParameter
            Dim supname2 As New SqlParameter("@supname", SqlDbType.VarChar, 100) : supname2.Direction = ParameterDirection.Input : supname2.Value = txtToTMName.Text : Params2(0) = supname2
            If txtToTMName.Text <> "" Then
                BusinessObject.Sub_Show(ServerPath2, "SupervisorCT_Show_Search", CommandType.StoredProcedure, RemoteDataSet, "Area", Params2)
            Else
                BusinessObject.Sub_Show(ServerPath2, "SupervisorCT_Show", CommandType.StoredProcedure, RemoteDataSet, "Area")
            End If
            dgvToTM.DataSource = RemoteDataSet.Tables("Area")
            LogHelper.InsertLog("LoadSpecialist.ShowArea.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("LoadSpecialist.ShowArea.Error: " & ex.Message)
        End Try
    End Sub
    Private Sub LoadFromTM()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            ResetDataset()
            Dim Params2(0) As SqlParameter
            Dim supname2 As New SqlParameter("@supname", SqlDbType.VarChar, 100) : supname2.Direction = ParameterDirection.Input : supname2.Value = txtFromTMName.Text : Params2(0) = supname2
            If txtFromTMName.Text <> "" Then
                BusinessObject.Sub_Show(ServerPath2, "SupervisorCT_Show_Search", CommandType.StoredProcedure, RemoteDataSet, "Area", Params2)
            Else
                BusinessObject.Sub_Show(ServerPath2, "SupervisorCT_Show", CommandType.StoredProcedure, RemoteDataSet, "Area")
            End If
            dgvFromTM.DataSource = RemoteDataSet.Tables("Area")
            LogHelper.InsertLog("LoadSpecialist.ShowArea.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("LoadSpecialist.ShowArea.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ResetDataset()
        RemoteDataSet.Tables.Remove("Area")
        RemoteDataSet.Tables.Add("Area")
    End Sub

    Private Sub txtFromTMName_TextChanged(sender As Object, e As EventArgs) Handles txtFromTMName.TextChanged
        If txtFromTMName.Text.Length >= 3 Then
            LoadFromTM()
        End If
    End Sub

    Private Sub txtToTMName_TextChanged(sender As Object, e As EventArgs) Handles txtToTMName.TextChanged
        If txtToTMName.Text.Length >= 3 Then
            LoadTM()
        End If
    End Sub

    Private Sub dgvFromTM_DoubleClick(sender As Object, e As EventArgs) Handles dgvFromTM.DoubleClick
        Dim row As Integer = dgvFromTM.CurrentRow.Index
        If row > -1 Then
            txtfromsupcode.Text = dgvFromTM.Rows(row).Cells("SUPCODE").Value.ToString() + " :: " + _
                dgvFromTM.Rows(row).Cells("SUPNAME").Value.ToString()
        End If
    End Sub

    Private Sub dgvToSpecialist_DoubleClick(sender As Object, e As EventArgs) Handles dgvToTM.DoubleClick
        Dim row As Integer = dgvToTM.CurrentRow.Index
        If row > -1 Then
            txttosupcode.Text = dgvToTM.Rows(row).Cells("SUPCODE").Value.ToString() + " :: " + _
                dgvToTM.Rows(row).Cells("SUPNAME").Value.ToString()
        End If
    End Sub

    Private Function GetFromSupcode() As String
        Return txtfromsupcode.Text.Substring(0, txtfromsupcode.Text.IndexOf(" :: ")).Trim
    End Function

    Private Function GettoSupcode() As String
        Return txttosupcode.Text.Substring(0, txttosupcode.Text.IndexOf(" :: ")).Trim
    End Function

    Private Sub txtfromdate_TextChanged(sender As Object, e As EventArgs) Handles txtfromdate.TextChanged
        If IsDate(txtfromdate.Text) Then
            ' LoadSpecialistMercury()
        End If
    End Sub
    Private Sub txtfromsupcode_TextChanged(sender As Object, e As EventArgs) Handles txtfromsupcode.TextChanged
        If txtfromsupcode.Text <> "" Then
            'lblfromsegment.Text = "From Segment : " & SupMr_Segment(txtFROMSUPCODE.Text)
        End If
    End Sub

    Private Sub txttosupcode_TextChanged(sender As Object, e As EventArgs) Handles txttosupcode.TextChanged
        If txttosupcode.Text <> "" Then
            'lbltosegment.Text = "To Segment : " & SupMr_Segment(txtTOSUPCODE.Text)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearEntry()
    End Sub
    Private Sub ClearEntry()
        txtFromTMName.Text = ""
        txtfromsupcode.Text = ""
        txtfromdate.Text = ""

        txtToTMName.Text = ""
        txttosupcode.Text = ""
        txttodate.Text = ""
    End Sub
    Private Sub btnTransferTM_Click(sender As Object, e As EventArgs) Handles btnTransferTM.Click
        ProcessTransferTM()
    End Sub

    Private Sub ProcessTransferTM()
        'End From SuperVisor  : Supervisor->Resign_date and End_date
        'Insert SPs under From Supervisor to New Supervisor
        'End All SPs under From Supervisor : SUPMR
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(3) As SqlParameter
        Dim FROMSUPCODE As New SqlParameter("@FROMSUPCODE", SqlDbType.VarChar, 10) : FROMSUPCODE.Direction = ParameterDirection.Input : FROMSUPCODE.Value = GetFROMSUPCODE() : Params(0) = FROMSUPCODE
        Dim TOSUPCODE As New SqlParameter("@TOSUPCODE", SqlDbType.VarChar, 10) : TOSUPCODE.Direction = ParameterDirection.Input : TOSUPCODE.Value = GetTOSUPCODE() : Params(1) = TOSUPCODE
        Dim FROMDATE As New SqlParameter("@FROMDATE", SqlDbType.DateTime, 10) : FROMDATE.Direction = ParameterDirection.Input : FROMDATE.Value = txtfromdate.Text.Trim : Params(2) = FROMDATE
        Dim TODATE As New SqlParameter("@TODATE", SqlDbType.DateTime, 10) : TODATE.Direction = ParameterDirection.Input : TODATE.Value = txttodate.Text.Trim : Params(3) = TODATE
        Try
            BusinessObject.Sub_Update(ServerPath2, "Util_TransferTM", CommandType.StoredProcedure, Params)
            MsgBox("Transfer of TM is complete!")
            ListBox1.Items.Add("TM-Ok")
        Catch ex As Exception
            MsgBox("Error in executing Util_TransferTM SP: " + ex.Message)
            ListBox1.Items.Add("Error in executing Util_TransferTM : " + ex.Message)
        End Try
    End Sub
End Class