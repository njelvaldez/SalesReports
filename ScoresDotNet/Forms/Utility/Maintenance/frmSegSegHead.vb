Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Configuration
Imports System.Globalization

Public Class frmSegSegHead
    Private RemoteDataSet As New DataSet
    Private MonthName As String = ""
    Private strCode As String = ""

    Private Sub frmSegSegHead_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RemoteDataSet.Tables.Add("Segment")
        SetDate()
        ShowSegment()
    End Sub

    Private Sub ShowSegment()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            ResetDataset()
            Dim commissiondate As New SqlParameter("@commissiondate", SqlDbType.DateTime, 10) : commissiondate.Direction = ParameterDirection.Input : commissiondate.Value = dtpMonth.Text : Params(0) = commissiondate
            BusinessObject.Sub_Show(ServerPath2, "Util_Division_Select", CommandType.StoredProcedure, RemoteDataSet, "Segment", Params)
            dgvSegment.DataSource = RemoteDataSet.Tables("Segment")
            gbArea.Text = "Total No of Segment :" + RemoteDataSet.Tables("Segment").Rows.Count.ToString
            LogHelper.InsertLog("frmSegSegHead.ShowSegment.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmSegSegHead.ShowSegment.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ShowSegmentHead()
        Try
            SetCode()
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(1) As SqlParameter
            Dim commissiondate As New SqlParameter("@commissiondate", SqlDbType.DateTime, 10) : commissiondate.Direction = ParameterDirection.Input : commissiondate.Value = dtpMonth.Text : Params(0) = commissiondate
            Dim divcode As New SqlParameter("@divcode", SqlDbType.VarChar, 10) : divcode.Direction = ParameterDirection.Input : divcode.Value = strCode : Params(1) = divcode
            ResetDataset()
            BusinessObject.Sub_Show(ServerPath2, "Util_NsmDivisionAssignment_Select", CommandType.StoredProcedure, RemoteDataSet, "Segment", Params)
            dgvSegmentHead.DataSource = RemoteDataSet.Tables("Segment")
            gbAreaPMR.Text = "Total No of Segment :" + RemoteDataSet.Tables("Segment").Rows.Count.ToString
            LogHelper.InsertLog("frmSegSegHead.ShowSegmentHead.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmSegSegHead.ShowSegmentHead.Error: " & ex.Message)
        End Try
    End Sub
    Private Sub SetDate()
        Dim currentdate As String
        currentdate = Now.Date.Month.ToString + "/1/" + dtpMonth.Value.Year.ToString
        dtpMonth.Text = currentdate
        MonthName = "Jan - " + dtpMonth.Value.ToString("MMM", New CultureInfo("en-US")) + " " + dtpMonth.Value.Year.ToString() + " Sales"
    End Sub

    Private Sub ResetDataset()
        RemoteDataSet.Tables.Remove("Segment")
        RemoteDataSet.Tables.Add("Segment")
    End Sub
    Private Sub SetCode()
        Dim row As Integer = dgvSegment.CurrentRow.Index
        If row > -1 Then
            strCode = dgvSegment.Rows(row).Cells("DivCode").Value.ToString()
        Else
            strCode = ""
        End If
    End Sub

    Private Sub dgvSegment_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSegment.RowEnter
        'ShowSegmentHead()
    End Sub

    Private Sub dgvSegment_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSegment.CellClick
        ShowSegmentHead()
        ShowSegmentDetails()
    End Sub

    Private Sub ShowSegmentDetails()
        Try
            Dim row As Integer = dgvSegment.CurrentRow.Index
            If row > -1 Then
                txtRowID.Text = dgvSegment.Rows(row).Cells("RowID").Value.ToString()
                txtdivcode.Text = dgvSegment.Rows(row).Cells("DivCode").Value.ToString()
                txtdimcode.Text = dgvSegment.Rows(row).Cells("DimCode").Value.ToString()
                txtdivname.Text = dgvSegment.Rows(row).Cells("DivName").Value.ToString()
                txtstatus.Text = dgvSegment.Rows(row).Cells("Status").Value.ToString()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmSegSegHead.ShowSegmentDetails.Error: " & ex.Message)
        End Try
    End Sub
    Private Sub ShowSegmentHeadDetails()
        Try
            Dim row As Integer = dgvSegmentHead.CurrentRow.Index
            If row > -1 Then
                txtrowidsh.Text = dgvSegmentHead.Rows(row).Cells("RowID").Value.ToString()
                txtNSM.Text = dgvSegmentHead.Rows(row).Cells("NSM").Value.ToString()
                txtNSMCode.Text = dgvSegmentHead.Rows(row).Cells("NSMCode").Value.ToString()
                txtdivcodesh.Text = dgvSegmentHead.Rows(row).Cells("DivCode").Value.ToString()
                txtdivnamesh.Text = dgvSegmentHead.Rows(row).Cells("Division").Value.ToString()
                txtdimsh.Text = dgvSegmentHead.Rows(row).Cells("Dim").Value.ToString()
                txtdimcodesh.Text = dgvSegmentHead.Rows(row).Cells("DimCode").Value.ToString()
                txtStartDate.Text = Convert.ToDateTime(dgvSegmentHead.Rows(row).Cells("Start_Date").Value.ToString())
                txtEndDate.Text = Convert.ToDateTime(dgvSegmentHead.Rows(row).Cells("End_Date").Value.ToString())
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmSegSegHead.ShowSegmentHeadDetails.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(3) As SqlParameter
        Dim divcode As New SqlParameter("@divcode", SqlDbType.VarChar, 3) : divcode.Direction = ParameterDirection.Input : divcode.Value = txtdivcode.Text.Trim : Params(0) = divcode
        Dim dimcode As New SqlParameter("@dimcode", SqlDbType.VarChar, 6) : dimcode.Direction = ParameterDirection.Input : dimcode.Value = txtdimcode.Text.Trim : Params(1) = dimcode
        Dim divname As New SqlParameter("@divname", SqlDbType.VarChar, 50) : divname.Direction = ParameterDirection.Input : divname.Value = txtdivname.Text.Trim : Params(2) = divname
        Dim status As New SqlParameter("@status", SqlDbType.VarChar, 10) : status.Direction = ParameterDirection.Input : status.Value = txtstatus.Text.Trim : Params(3) = status
        Try
            If (MessageBox.Show("Are you sure you want to Save new Segment?", "Confirm Saving", _
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)) _
                     = DialogResult.Yes Then
                BusinessObject.Sub_Update(ServerPath2, "Util_Division_Insert", CommandType.StoredProcedure, Params)
                ShowSegment()
            End If
        Catch ex As Exception
            MsgBox("Error in executing Util_Division_Insert SP: " + ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(4) As SqlParameter
        Dim divcode As New SqlParameter("@divcode", SqlDbType.VarChar, 3) : divcode.Direction = ParameterDirection.Input : divcode.Value = txtdivcode.Text.Trim : Params(0) = divcode
        Dim dimcode As New SqlParameter("@dimcode", SqlDbType.VarChar, 6) : dimcode.Direction = ParameterDirection.Input : dimcode.Value = txtdimcode.Text.Trim : Params(1) = dimcode
        Dim divname As New SqlParameter("@divname", SqlDbType.VarChar, 50) : divname.Direction = ParameterDirection.Input : divname.Value = txtdivname.Text.Trim : Params(2) = divname
        Dim status As New SqlParameter("@status", SqlDbType.VarChar, 10) : status.Direction = ParameterDirection.Input : status.Value = txtstatus.Text.Trim : Params(3) = status
        Dim rowid As New SqlParameter("@rowid", SqlDbType.Int, 10) : rowid.Direction = ParameterDirection.Input : rowid.Value = txtRowID.Text.Trim : Params(4) = rowid
        Try
            If (MessageBox.Show("Are you sure you want to Save changes?", "Confirm Saving", _
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)) _
                     = DialogResult.Yes Then
                BusinessObject.Sub_Update(ServerPath2, "Util_Division_Update", CommandType.StoredProcedure, Params)
                ShowSegment()
            End If
        Catch ex As Exception
            MsgBox("Error in executing Util_Division_Update SP: " + ex.Message)
        End Try
    End Sub

    Private Sub dgvSegmentHead_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSegmentHead.CellClick
        ShowSegmentHeadDetails()
    End Sub
    Private Sub btnAddSegmentHead_Click(sender As Object, e As EventArgs) Handles btnAddSegmentHead.Click
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(7) As SqlParameter
        Dim NSM As New SqlParameter("@NSM", SqlDbType.VarChar, 50) : NSM.Direction = ParameterDirection.Input : NSM.Value = txtNSM.Text.Trim : Params(0) = NSM
        Dim NsmCode As New SqlParameter("@NsmCode", SqlDbType.VarChar, 6) : NsmCode.Direction = ParameterDirection.Input : NsmCode.Value = txtNSMCode.Text.Trim : Params(1) = NsmCode
        Dim Dimm As New SqlParameter("@Dimm", SqlDbType.VarChar, 8) : Dimm.Direction = ParameterDirection.Input : Dimm.Value = txtdimsh.Text.Trim : Params(2) = Dimm
        Dim Division As New SqlParameter("@Division", SqlDbType.VarChar, 30) : Division.Direction = ParameterDirection.Input : Division.Value = txtdivnamesh.Text.Trim : Params(3) = Division
        Dim DimCode As New SqlParameter("@DimCode", SqlDbType.VarChar, 6) : DimCode.Direction = ParameterDirection.Input : DimCode.Value = txtdimcodesh.Text.Trim : Params(4) = DimCode
        Dim Start_Date As New SqlParameter("@Start_Date", SqlDbType.VarChar, 10) : Start_Date.Direction = ParameterDirection.Input : Start_Date.Value = txtStartDate.Text.Trim : Params(5) = Start_Date
        Dim End_Date As New SqlParameter("@End_Date", SqlDbType.VarChar, 10) : End_Date.Direction = ParameterDirection.Input : End_Date.Value = txtEndDate.Text.Trim : Params(6) = End_Date
        Dim DivCode As New SqlParameter("@DivCode", SqlDbType.VarChar, 6) : DivCode.Direction = ParameterDirection.Input : DivCode.Value = txtdivcodesh.Text.Trim : Params(7) = DivCode
        Try
            If (MessageBox.Show("Are you sure you want to Save new Segment Head?", "Confirm Saving", _
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)) _
                     = DialogResult.Yes Then
                BusinessObject.Sub_Update(ServerPath2, "Util_NSMDivisionAssignment_Insert", CommandType.StoredProcedure, Params)
                ShowSegmentHead()
            End If
        Catch ex As Exception
            MsgBox("Error in executing Util_NSMDivisionAssignment_Insert SP: " + ex.Message)
        End Try
    End Sub

    Private Sub btnUpdateSegmentHead_Click(sender As Object, e As EventArgs) Handles btnUpdateSegmentHead.Click
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(8) As SqlParameter
        Dim NSM As New SqlParameter("@NSM", SqlDbType.VarChar, 50) : NSM.Direction = ParameterDirection.Input : NSM.Value = txtNSM.Text.Trim : Params(0) = NSM
        Dim NsmCode As New SqlParameter("@NsmCode", SqlDbType.VarChar, 6) : NsmCode.Direction = ParameterDirection.Input : NsmCode.Value = txtNSMCode.Text.Trim : Params(1) = NsmCode
        Dim Dimm As New SqlParameter("@Dimm", SqlDbType.VarChar, 8) : Dimm.Direction = ParameterDirection.Input : Dimm.Value = txtdimsh.Text.Trim : Params(2) = Dimm
        Dim Division As New SqlParameter("@Division", SqlDbType.VarChar, 30) : Division.Direction = ParameterDirection.Input : Division.Value = txtdivnamesh.Text.Trim : Params(3) = Division
        Dim DimCode As New SqlParameter("@DimCode", SqlDbType.VarChar, 6) : DimCode.Direction = ParameterDirection.Input : DimCode.Value = txtdimcodesh.Text.Trim : Params(4) = DimCode
        Dim Start_Date As New SqlParameter("@Start_Date", SqlDbType.VarChar, 10) : Start_Date.Direction = ParameterDirection.Input : Start_Date.Value = txtStartDate.Text.Trim : Params(5) = Start_Date
        Dim End_Date As New SqlParameter("@End_Date", SqlDbType.VarChar, 10) : End_Date.Direction = ParameterDirection.Input : End_Date.Value = txtEndDate.Text.Trim : Params(6) = End_Date
        Dim DivCode As New SqlParameter("@DivCode", SqlDbType.VarChar, 6) : DivCode.Direction = ParameterDirection.Input : DivCode.Value = txtdivcodesh.Text.Trim : Params(7) = DivCode
        Dim RowID As New SqlParameter("@RowID", SqlDbType.VarChar, 6) : RowID.Direction = ParameterDirection.Input : RowID.Value = txtrowidsh.Text.Trim : Params(8) = RowID
        Try
            If (MessageBox.Show("Are you sure you want to Update Segment Head?", "Confirm Saving", _
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)) _
                     = DialogResult.Yes Then
                BusinessObject.Sub_Update(ServerPath2, "Util_NSMDivisionAssignment_Update", CommandType.StoredProcedure, Params)
                ShowSegmentHead()
            End If
        Catch ex As Exception
            MsgBox("Error in executing Util_NSMDivisionAssignment_Insert SP: " + ex.Message)
        End Try
    End Sub
End Class