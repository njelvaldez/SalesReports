Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Configuration
Imports System.Globalization

Public Class frmArea
    Private RemoteDataSet As New DataSet
    Private MonthName As String = ""
    Private strAreaCode As String = ""

    Private Sub frmArea_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RemoteDataSet.Tables.Add("Area")
        SetDate()
        ShowArea()
    End Sub

    Private Sub ShowArea()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            ResetDataset()
            Dim commissiondate As New SqlParameter("@commissiondate", SqlDbType.DateTime, 10) : commissiondate.Direction = ParameterDirection.Input : commissiondate.Value = dtpMonth.Text : Params(0) = commissiondate
            BusinessObject.Sub_Show(ServerPath2, "Util_Area_Select", CommandType.StoredProcedure, RemoteDataSet, "Area", Params)
            dgvArea.DataSource = RemoteDataSet.Tables("Area")
            gbArea.Text = "Total No of Area :" + RemoteDataSet.Tables("Area").Rows.Count.ToString
            LogHelper.InsertLog("frmArea.ShowArea.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmArea.ShowArea.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ShowAreaPMR()
        Try
            SetAreaCode()
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(1) As SqlParameter
            Dim commissiondate As New SqlParameter("@commissiondate", SqlDbType.DateTime, 10) : commissiondate.Direction = ParameterDirection.Input : commissiondate.Value = dtpMonth.Text : Params(0) = commissiondate
            Dim areacode As New SqlParameter("@areacode", SqlDbType.VarChar, 10) : areacode.Direction = ParameterDirection.Input : areacode.Value = strAreaCode : Params(1) = areacode
            ResetDataset()
            BusinessObject.Sub_Show(ServerPath2, "Util_AreaPMR_Select", CommandType.StoredProcedure, RemoteDataSet, "Area", Params)
            dgvAreaPMR.DataSource = RemoteDataSet.Tables("Area")
            gbAreaPMR.Text = "Total No of Area :" + RemoteDataSet.Tables("Area").Rows.Count.ToString
            LogHelper.InsertLog("frmArea.ShowAreaPMR.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmArea.ShowAreaPMR.Error: " & ex.Message)
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
    Private Sub SetAreaCode()
        Dim row As Integer = dgvArea.CurrentRow.Index
        If row > -1 Then
            strAreaCode = dgvArea.Rows(row).Cells("AreaCode").Value.ToString()
        Else
            strAreaCode = ""
        End If
    End Sub

    Private Sub dgvArea_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvArea.RowEnter
        'ShowAreaPMR()
    End Sub

    Private Sub dgvArea_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvArea.CellClick
        ShowAreaPMR()
    End Sub

    Private Sub dgvArea_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvArea.CellContentClick

    End Sub
End Class