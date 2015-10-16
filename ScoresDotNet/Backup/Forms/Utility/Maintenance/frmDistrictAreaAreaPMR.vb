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
        ShowDistrict()
    End Sub

    Private Sub ShowDistrict()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            ResetDataset()
            Dim commissiondate As New SqlParameter("@commissiondate", SqlDbType.DateTime, 10) : commissiondate.Direction = ParameterDirection.Input : commissiondate.Value = dtpMonth.Text : Params(0) = commissiondate
            BusinessObject.Sub_Show(ServerPath2, "Util_District_Select", CommandType.StoredProcedure, RemoteDataSet, "Area", Params)
            dgvArea.DataSource = RemoteDataSet.Tables("Area")
            gbArea.Text = "Total No of District :" + RemoteDataSet.Tables("Area").Rows.Count.ToString
            LogHelper.InsertLog("frmArea.ShowDistrict.Success")
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
        currentdate = dtpMonth.Value.Month.ToString + "/1/" + dtpMonth.Value.Year.ToString
        dtpMonth.Text = currentdate
        MonthName = "Jan - " + dtpMonth.Value.ToString("MMM", New CultureInfo("en-US")) + " " + dtpMonth.Value.Year.ToString() + " Sales"
    End Sub

    Private Sub ResetDataset()
        RemoteDataSet.Tables.Remove("Area")
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

    Private Sub dgvArea_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvArea.RowEnter
        'ShowAreaPMR()
    End Sub

    Private Sub dgvArea_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvArea.CellClick
        ShowDistrictAreaPMR()
    End Sub
End Class