Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Configuration
Imports System.Globalization
Public Class frmDistrictAreaAreaPMR
    Private RemoteDataSet As New DataSet
    Private MonthName As String = ""
    Private strdistrictcode As String = ""

    Private Sub frmDistrictAreaAreaPMR_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RemoteDataSet.Tables.Add("Area")
        SetDate()
    End Sub

    Private Sub ShowDistrict()
        Try
            If Not String.IsNullOrEmpty(dtpMonth.Text.ToString) Then
                Dim BusinessObject As New BusinessLayer.clsFileMaintenance
                Dim Params(0) As SqlParameter
                ResetDataset()
                Dim commissiondate As New SqlParameter("@commissiondate", SqlDbType.DateTime, 10) : commissiondate.Direction = ParameterDirection.Input : commissiondate.Value = dtpMonth.Text : Params(0) = commissiondate
                BusinessObject.Sub_Show(ServerPath2, "Util_District_Select", CommandType.StoredProcedure, RemoteDataSet, "Area", Params)
                dgvArea.DataSource = RemoteDataSet.Tables("Area")
                gbArea.Text = "Total No of District :" + RemoteDataSet.Tables("Area").Rows.Count.ToString
                LogHelper.InsertLog("frmArea.ShowDistrict.Success")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmArea.ShowDistrict.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ShowDistrictAreaPMR()
        Try
            SetDistrictCode()
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(1) As SqlParameter
            Dim commissiondate As New SqlParameter("@commissiondate", SqlDbType.DateTime, 10) : commissiondate.Direction = ParameterDirection.Input : commissiondate.Value = dtpMonth.Text : Params(0) = commissiondate
            Dim districtcode As New SqlParameter("@districtcode", SqlDbType.VarChar, 10) : districtcode.Direction = ParameterDirection.Input : districtcode.Value = strdistrictcode : Params(1) = districtcode
            ResetDataset()
            BusinessObject.Sub_Show(ServerPath2, "Util_DistrictAreaPMR_Select", CommandType.StoredProcedure, RemoteDataSet, "Area", Params)
            dgvAreaPMR.DataSource = RemoteDataSet.Tables("Area")
            gbAreaPMR.Text = "Total No of Area :" + RemoteDataSet.Tables("Area").Rows.Count.ToString
            LogHelper.InsertLog("frmArea.ShowDistrictAreaPMR.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmArea.ShowDistrictAreaPMR.Error: " & ex.Message)
        End Try
    End Sub
    Private Sub SetDate()
        Dim currentdate As String
        currentdate = Now.Date.Month.ToString + "/1/" + dtpMonth.Value.Year.ToString
        dtpMonth.Text = currentdate
        MonthName = "Jan - " + dtpMonth.Value.ToString("MMM", New CultureInfo("en-US")) + " " + dtpMonth.Value.Year.ToString() + " Sales"
    End Sub

    Private Sub ResetDataset()
        If RemoteDataSet.Tables.Count > 0 Then
            RemoteDataSet.Tables.Remove("Area")
        End If
        RemoteDataSet.Tables.Add("Area")
    End Sub
    Private Sub SetDistrictCode()
        Dim row As Integer = dgvArea.CurrentRow.Index
        If row > -1 Then
            strdistrictcode = dgvArea.Rows(row).Cells("DistrictCode").Value.ToString()
        Else
            strdistrictcode = ""
        End If
    End Sub

    Private Sub dgvArea_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvArea.CellClick
        ShowDistrictAreaPMR()
    End Sub

    Private Sub dgvAreaPMR_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAreaPMR.CellClick
        ShowArePMRDetails()
    End Sub
    Private Sub ShowArePMRDetails()
        Dim row As Integer = dgvAreaPMR.CurrentRow.Index
        '--insert into newscores..areapmr (areacode,mrcode,start_date,end_date,lastuser,deleted,arearowid)
        'values('04535','00660','10/1/2014','12/31/2014','ARV','N','524')
        If row > -1 Then
            txtAreaCode.Text = dgvAreaPMR.Rows(row).Cells("areacode").Value.ToString()
            txtmrcode.Text = dgvAreaPMR.Rows(row).Cells("mrcode").Value.ToString()
            txtstart_date.Text = Convert.ToDateTime(dgvAreaPMR.Rows(row).Cells("start_date").Value.ToString())
            txtend_date.Text = Convert.ToDateTime(dgvAreaPMR.Rows(row).Cells("end_date").Value.ToString())
            txtlastuser.Text = dgvAreaPMR.Rows(row).Cells("lastuser").Value.ToString()
            txtdeleted.Text = dgvAreaPMR.Rows(row).Cells("deleted").Value.ToString()
            txtarearowid.Text = dgvAreaPMR.Rows(row).Cells("arearowid").Value.ToString()
            txtRowID.Text = dgvAreaPMR.Rows(row).Cells("rowid").Value.ToString()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnUpdateAreaPMR.Click
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(1) As SqlParameter
        Dim rowid As New SqlParameter("@rowid", SqlDbType.VarChar, 10) : rowid.Direction = ParameterDirection.Input : rowid.Value = txtRowID.Text.Trim : Params(0) = rowid
        Dim end_date As New SqlParameter("@end_date", SqlDbType.VarChar, 10) : end_date.Direction = ParameterDirection.Input : end_date.Value = txtend_date.Text : Params(1) = end_date
        Try
            If (MessageBox.Show("Are you sure you want to update AreaPMR?", "Confirm Saving", _
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)) _
                     = DialogResult.Yes Then
                BusinessObject.Sub_Update(ServerPath2, "Util_AreaPMR_Update", CommandType.StoredProcedure, Params)
            End If
        Catch ex As Exception
            MsgBox("Error in executing Util_AreaPMR_Update SP: " + ex.Message)
        End Try
    End Sub

    Private Sub btnInsertAreaPMR_Click(sender As Object, e As EventArgs) Handles btnInsertAreaPMR.Click
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(6) As SqlParameter
        Dim areacode As New SqlParameter("@areacode", SqlDbType.VarChar, 10) : areacode.Direction = ParameterDirection.Input : areacode.Value = txtAreaCode.Text.Trim : Params(0) = areacode
        Dim mrcode As New SqlParameter("@mrcode", SqlDbType.VarChar, 10) : mrcode.Direction = ParameterDirection.Input : mrcode.Value = txtmrcode.Text.Trim : Params(1) = mrcode
        Dim start_date As New SqlParameter("@start_date", SqlDbType.VarChar, 10) : start_date.Direction = ParameterDirection.Input : start_date.Value = txtstart_date.Text.Trim : Params(2) = start_date
        Dim end_date As New SqlParameter("@end_date", SqlDbType.VarChar, 10) : end_date.Direction = ParameterDirection.Input : end_date.Value = txtend_date.Text.Trim : Params(3) = end_date
        Dim lastuser As New SqlParameter("@lastuser", SqlDbType.VarChar, 10) : lastuser.Direction = ParameterDirection.Input : lastuser.Value = txtlastuser.Text.Trim : Params(4) = lastuser
        Dim deleted As New SqlParameter("@deleted", SqlDbType.VarChar, 1) : deleted.Direction = ParameterDirection.Input : deleted.Value = txtdeleted.Text.Trim : Params(5) = deleted
        Dim arearowid As New SqlParameter("@arearowid", SqlDbType.VarChar, 10) : arearowid.Direction = ParameterDirection.Input : arearowid.Value = txtarearowid.Text.Trim : Params(6) = arearowid
        Try
            If AreaPMRExists() Then
                MsgBox("Failed to insert new ArePMR, record already exists in AreaPMR!")
            Else
                If (MessageBox.Show("Are you sure you want to Save this Entry to AreaPMR?", "Confirm Saving", _
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)) _
                     = DialogResult.Yes Then
                    BusinessObject.Sub_Update(ServerPath2, "Util_AreaPMR_Insert", CommandType.StoredProcedure, Params)
                End If
            End If
        Catch ex As Exception
            MsgBox("Error in executing Util_AreaPMR_Update SP: " + ex.Message)
        End Try
    End Sub

    Private Function AreaPMRExists() As Boolean
        Dim tempds As New DataSet()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(3) As SqlParameter
        Dim areacode As New SqlParameter("@areacode", SqlDbType.VarChar, 10) : areacode.Direction = ParameterDirection.Input : areacode.Value = txtAreaCode.Text : Params(0) = areacode
        Dim mrcode As New SqlParameter("@mrcode", SqlDbType.VarChar, 10) : mrcode.Direction = ParameterDirection.Input : mrcode.Value = txtmrcode.Text : Params(1) = mrcode
        Dim start_date As New SqlParameter("@start_date", SqlDbType.VarChar, 10) : start_date.Direction = ParameterDirection.Input : start_date.Value = txtstart_date.Text : Params(2) = start_date
        Dim end_date As New SqlParameter("@end_date", SqlDbType.VarChar, 10) : end_date.Direction = ParameterDirection.Input : end_date.Value = txtend_date.Text : Params(3) = end_date
        Dim retval As Boolean = False
        tempds.Tables.Add("Area")
        BusinessObject.Sub_Show(ServerPath2, "Util_AreaPMR_Exists", CommandType.StoredProcedure, tempds, "Area", Params)
        If tempds.Tables(0).Rows.Count() > 0 Then
            retval = True
        End If
        Return retval
    End Function
    Private Sub dtpMonth_ValueChanged(sender As Object, e As EventArgs) Handles dtpMonth.ValueChanged
        ShowDistrict()
    End Sub
End Class