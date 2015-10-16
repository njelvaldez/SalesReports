Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Public Class frmSalesControl
    Private RemoteDataSet As New DataSet
    Private Sub btn01Mercury4Segments_Click(sender As Object, e As EventArgs) Handles btn01Mercury4Segments.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_01Mercury4Segments", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub RefreshTable()
        RemoteDataSet.Tables.Remove("IntegratedSales")
        RemoteDataSet.Tables.Add("IntegratedSales")
    End Sub

    Private Sub frmSalesControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        RemoteDataSet.Tables.Add("IntegratedSales")
        SetDate()
    End Sub

    Private Sub btn02MercuryTrade_Click(sender As Object, e As EventArgs) Handles btn02MercuryTrade.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_02MercuryTrade", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn03MercuryNoItemCode_Click(sender As Object, e As EventArgs) Handles btn03MercuryNoItemCode.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_03MercuryNoItemCode", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn04MercuryWrongCrediting_Click(sender As Object, e As EventArgs) Handles btn04MercuryWrongCrediting.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_04MercuryWrongCrediting", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn05MercuryMissingBranch_Click(sender As Object, e As EventArgs) Handles btn05MercuryMissingBranch.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_05MercuryMissingBranch", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn06MercuryNoPrice_Click(sender As Object, e As EventArgs) Handles btn06MercuryNoPrice.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_06MercuryNoPrice", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn07MercuryDuplicateTM_Click(sender As Object, e As EventArgs) Handles btn07MercuryDuplicateTM.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_07MercuryDuplicateTM", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn08SPsTM_Click(sender As Object, e As EventArgs) Handles btn08SPsTM.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(1) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            Dim janofyear As New SqlParameter("@janofyear", SqlDbType.DateTime, 10) : janofyear.Direction = ParameterDirection.Input : janofyear.Value = "01/01/" + dtpMonth.Value.Year.ToString() : Params(1) = janofyear
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_08SPsTM", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn09SPWOTM_Click(sender As Object, e As EventArgs) Handles btn09SPWOTM.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_09SPWOTM", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn10NOTSSP_Click(sender As Object, e As EventArgs) Handles btn10NOTSSP.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_10NOTSSP", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn11NOTSTM_Click(sender As Object, e As EventArgs) Handles btn11NOTSTM.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_11NOTSTM", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn12SPTerritorySetup_Click(sender As Object, e As EventArgs) Handles btn12SPTerritorySetup.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_12SPTerritorySetup", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn13TMTerritorySetup_Click(sender As Object, e As EventArgs) Handles btn13TMTerritorySetup.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_13TMTerritorySetup", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn14TSSPTerritorySetup_Click(sender As Object, e As EventArgs) Handles btn14TSSPTerritorySetup.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_14TSSPTerritorySetup", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn15TSKATerritorySetup_Click(sender As Object, e As EventArgs) Handles btn15TSKATerritorySetup.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_15TSKATerritorySetup", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btn21nocommissiondate_Click(sender As Object, e As EventArgs) Handles btn21nocommissiondate.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_21nocommissiondate", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn22untagged_Click(sender As Object, e As EventArgs) Handles btn22untagged.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_22untagged", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            Dim frmuntag As New frmUntagged
            frmuntag.dgvSales.DataSource = RemoteDataSet.Tables(0)
            frmuntag.GroupBox3.Text = "Total number of untagged : " & RemoteDataSet.Tables(0).Rows.Count.ToString()
            frmuntag.dtpMonth.Value = Convert.ToDateTime(dtpMonth.Value.Month.ToString.Trim + "/" + dtpMonth.Value.Day.ToString.Trim + "/" + dtpMonth.Value.Year.ToString.Trim)
            frmuntag.pubcomdate = Convert.ToDateTime(dtpMonth.Value.Month.ToString.Trim + "/" + dtpMonth.Value.Day.ToString.Trim + "/" + dtpMonth.Value.Year.ToString.Trim)
            frmuntag.EnableTagSales()
            frmuntag.ShowDialog()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn23untaggedtrade_Click(sender As Object, e As EventArgs) Handles btn23untaggedtrade.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_23untaggedtrade", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            Dim frmuntag As New frmUntagged
            frmuntag.dgvSales.DataSource = RemoteDataSet.Tables(0)
            frmuntag.GroupBox3.Text = "Total number of untagged trade : " & RemoteDataSet.Tables(0).Rows.Count.ToString()
            frmuntag.dtpMonth.Value = Convert.ToDateTime(dtpMonth.Value.Month.ToString.Trim + "/" + dtpMonth.Value.Day.ToString.Trim + "/" + dtpMonth.Value.Year.ToString.Trim)
            frmuntag.pubcomdate = Convert.ToDateTime(dtpMonth.Value.Month.ToString.Trim + "/" + dtpMonth.Value.Day.ToString.Trim + "/" + dtpMonth.Value.Year.ToString.Trim)
            frmuntag.EnableTagSalesTrade()
            frmuntag.ShowDialog()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn24untaggedsales_Click(sender As Object, e As EventArgs) Handles btn24untaggedsales.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_24untaggedsales", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn25territoryandteam_Click(sender As Object, e As EventArgs) Handles btn25territoryandteam.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_25territoryandteam", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn26sutomernotshipto_Click(sender As Object, e As EventArgs) Handles btn26sutomernotshipto.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_26sutomernotshipto", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn27mrdivision_Click(sender As Object, e As EventArgs) Handles btn27mrdivision.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_27mrdivision", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn28nulldistributor_Click(sender As Object, e As EventArgs) Handles btn28nulldistributor.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_28nulldistributor", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn29notpalawan_Click(sender As Object, e As EventArgs) Handles btn29notpalawan.Click
        'Try
        '    Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        '    Dim Params(0) As SqlParameter
        '    Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
        '    RefreshTable()
        '    BusinessObject.Sub_Show(ServerPath2, "Util_29notpalawan", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
        '    dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
        '    GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
        '    Dim frmuntag As New frmUntagged
        '    frmuntag.dgvSales.DataSource = RemoteDataSet.Tables(0)
        '    frmuntag.GroupBox3.Text = "Total number of untagged Palawan : " & RemoteDataSet.Tables(0).Rows.Count.ToString()
        '    frmuntag.dtpMonth.Value = Convert.ToDateTime(dtpMonth.Value.Month.ToString.Trim + "/" + dtpMonth.Value.Day.ToString.Trim + "/" + dtpMonth.Value.Year.ToString.Trim)
        '    frmuntag.pubcomdate = Convert.ToDateTime(dtpMonth.Value.Month.ToString.Trim + "/" + dtpMonth.Value.Day.ToString.Trim + "/" + dtpMonth.Value.Year.ToString.Trim)
        '    ' frmuntag.EnableTagSalesPalawan()
        '    frmuntag.ShowDialog()
        '    LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        'End Try
    End Sub

    Private Sub btn30correctcrediting_Click(sender As Object, e As EventArgs) Handles btn30correctcrediting.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_30correctcrediting", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn31righttm_Click(sender As Object, e As EventArgs) Handles btn31righttm.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_31righttm", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn32spstm_Click(sender As Object, e As EventArgs) Handles btn32spstm.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_32spstm", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn33mismatchcrediting_Click(sender As Object, e As EventArgs) Handles btn33mismatchcrediting.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_33mismatchcrediting", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn34areaanddistrict_Click(sender As Object, e As EventArgs) Handles btn34areaanddistrict.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_34areaanddistrict", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn35tradeareaanddistrict_Click(sender As Object, e As EventArgs) Handles btn35tradeareaanddistrict.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_35tradeareaanddistrict", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn36govtcrediting_Click(sender As Object, e As EventArgs) Handles btn36govtcrediting.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_36govtcrediting", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn37spsetuptransfer_Click(sender As Object, e As EventArgs) Handles btn37spsetuptransfer.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_37spsetuptransfer", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn38tmsetuptransfer_Click(sender As Object, e As EventArgs) Handles btn38tmsetuptransfer.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_38tmsetuptransfer", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn39tsspsetuptransfer_Click(sender As Object, e As EventArgs) Handles btn39tsspsetuptransfer.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_39tsspsetuptransfer", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn40tstmsetuptransfer_Click(sender As Object, e As EventArgs) Handles btn40tstmsetuptransfer.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_40tstmsetuptransfer", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub
    Private Sub SetDate()
        Dim currentdate As String
        currentdate = Now.Date.Month.ToString + "/1/" + Now.Date.Year.ToString
        dtpMonth.Text = currentdate
    End Sub

    Private Sub btnTransfer_Click(sender As Object, e As EventArgs) Handles btnTransfer.Click
        Dim nrowid As Integer = 0
        Dim myLoadedForm As New frmTransferSales
        Try
            Dim row As Integer = dgvSales.CurrentRow.Index
            If row > -1 Then
                myLoadedForm.txtRowID.Text = dgvSales.Rows(row).Cells("ROWID").Value.ToString
                myLoadedForm.Show()
            Else
                MsgBox("Please select record to transfer!")
            End If
        Catch ex As Exception
            MsgBox("Error in transfer : " + ex.Message)
        End Try
    End Sub

    Private Sub btn41NullCustomer_Click(sender As Object, e As EventArgs) Handles btn41NullCustomer.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_41nullcustomer", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn42NullItemCode_Click(sender As Object, e As EventArgs) Handles btn42NullItemCode.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_42nullitemcode", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSPSNoBudget_Click(sender As Object, e As EventArgs) Handles btnSPSNoBudget.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim commissiondate As New SqlParameter("@commissiondate", SqlDbType.DateTime, 10) : commissiondate.Direction = ParameterDirection.Input : commissiondate.Value = dtpMonth.Text : Params(0) = commissiondate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_Budget_NoBudget", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDisplayMonthBudget_Click(sender As Object, e As EventArgs) Handles btnDisplayMonthBudget.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim commissiondate As New SqlParameter("@commissiondate", SqlDbType.DateTime, 10) : commissiondate.Direction = ParameterDirection.Input : commissiondate.Value = dtpMonth.Text : Params(0) = commissiondate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_Budget_DisplayBudget", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim commissiondate As New SqlParameter("@commissiondate", SqlDbType.DateTime, 10) : commissiondate.Direction = ParameterDirection.Input : commissiondate.Value = dtpMonth.Text : Params(0) = commissiondate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_Budget_TwoMonths", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnNullOldMDICode_Click(sender As Object, e As EventArgs) Handles btnNullOldMDICode.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim commissiondate As New SqlParameter("@commissiondate", SqlDbType.DateTime, 10) : commissiondate.Direction = ParameterDirection.Input : commissiondate.Value = dtpMonth.Text : Params(0) = commissiondate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_NullOldMDICode", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim commissiondate As New SqlParameter("@commissiondate", SqlDbType.DateTime, 10) : commissiondate.Direction = ParameterDirection.Input : commissiondate.Value = dtpMonth.Text : Params(0) = commissiondate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_43MDISUBMER", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn44MDIOTHER_Click(sender As Object, e As EventArgs) Handles btn44MDIOTHER.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim commissiondate As New SqlParameter("@commissiondate", SqlDbType.DateTime, 10) : commissiondate.Direction = ParameterDirection.Input : commissiondate.Value = dtpMonth.Text : Params(0) = commissiondate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_44MDIOTHER", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim commissiondate As New SqlParameter("@commissiondate", SqlDbType.DateTime, 10) : commissiondate.Direction = ParameterDirection.Input : commissiondate.Value = dtpMonth.Text : Params(0) = commissiondate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_445INHOUSEEXCUST", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnINHOUSEOTHERS_Click(sender As Object, e As EventArgs) Handles btnINHOUSEOTHERS.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim commissiondate As New SqlParameter("@commissiondate", SqlDbType.DateTime, 10) : commissiondate.Direction = ParameterDirection.Input : commissiondate.Value = dtpMonth.Text : Params(0) = commissiondate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_46INHOUSEOTHERS", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn47SUBDIST_Click(sender As Object, e As EventArgs) Handles btn47SUBDIST.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim commissiondate As New SqlParameter("@commissiondate", SqlDbType.DateTime, 10) : commissiondate.Direction = ParameterDirection.Input : commissiondate.Value = dtpMonth.Text : Params(0) = commissiondate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_47SUBDIST", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub BTN48MERCURYSTOCKTRANSFER_Click(sender As Object, e As EventArgs) Handles BTN48MERCURYSTOCKTRANSFER.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim commissiondate As New SqlParameter("@commissiondate", SqlDbType.DateTime, 10) : commissiondate.Direction = ParameterDirection.Input : commissiondate.Value = dtpMonth.Text : Params(0) = commissiondate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_48MERCURYSTOCKTRANSFER", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub
    Private Sub btn49MDIINHOUSEYTD_Click(sender As Object, e As EventArgs) Handles btn49MDIINHOUSEYTD.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim commissiondate As New SqlParameter("@commissiondate", SqlDbType.DateTime, 10) : commissiondate.Direction = ParameterDirection.Input : commissiondate.Value = dtpMonth.Text : Params(0) = commissiondate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_49MDIINHOUSEYTD", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCM_Click(sender As Object, e As EventArgs) Handles btnCM.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim commissiondate As New SqlParameter("@commissiondate", SqlDbType.DateTime, 10) : commissiondate.Direction = ParameterDirection.Input : commissiondate.Value = dtpMonth.Text : Params(0) = commissiondate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_50CM", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn48MercuryYTD_Click(sender As Object, e As EventArgs) Handles btn48MercuryYTD.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim commissiondate As New SqlParameter("@commissiondate", SqlDbType.DateTime, 10) : commissiondate.Direction = ParameterDirection.Input : commissiondate.Value = dtpMonth.Text : Params(0) = commissiondate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_48MERCURYSTOCKTRANSFER_YTD", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub GovtLagundex_Click(sender As Object, e As EventArgs) Handles GovtLagundex.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim commissiondate As New SqlParameter("@commissiondate", SqlDbType.DateTime, 10) : commissiondate.Direction = ParameterDirection.Input : commissiondate.Value = dtpMonth.Text : Params(0) = commissiondate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_50Govtlagundex", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("FrmSalesControl.GovtLagundex_Click.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmSalesControl.GovtLagundex_Click.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub GovtListMonthly_Click(sender As Object, e As EventArgs) Handles GovtListMonthly.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim commissiondate As New SqlParameter("@commissiondate", SqlDbType.DateTime, 10) : commissiondate.Direction = ParameterDirection.Input : commissiondate.Value = dtpMonth.Text : Params(0) = commissiondate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_50GovermentListMontly", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("FrmSalesControl.GovtLagundex_Click.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmSalesControl.GovtLagundex_Click.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub GOVTUPDNSMPM_Click(sender As Object, e As EventArgs) Handles GOVTUPDNSMPM.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim commissiondate As New SqlParameter("@commissiondate", SqlDbType.DateTime, 10) : commissiondate.Direction = ParameterDirection.Input : commissiondate.Value = dtpMonth.Text : Params(0) = commissiondate
            RefreshTable()
            BusinessObject.Sub_Update(ServerPath2, "Util_50GovermentUpdateNSM", CommandType.StoredProcedure, Params)
            'dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            'GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("FrmSalesControl.GOVTUPDNSMPM_Click.Success")
            MsgBox("Updating of NSM and PM for Government is complete!")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmSalesControl.GOVTUPDNSMPM_Click.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnUpdGovLagundex_Click(sender As Object, e As EventArgs) Handles btnUpdGovLagundex.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim commissiondate As New SqlParameter("@commissiondate", SqlDbType.DateTime, 10) : commissiondate.Direction = ParameterDirection.Input : commissiondate.Value = dtpMonth.Text : Params(0) = commissiondate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_50Govtlagundex", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            For Each dr As DataRow In RemoteDataSet.Tables("IntegratedSales").Rows
                'Check if there is a government sales in that territory
                If (GovernmentMonthTerritoryExist(dr("CommissionDate"), dr("TerritoryDr").ToString().Trim())) Then
                    'Transfer Lagundex from Pedia to Government
                    'MsgBox("Transfer Lagundex from Pedia to Government")
                    TransferLagundexFromPediaToGovernment(dr("rowid").ToString().Trim(), GovernmentMonthTerritory(dr("CommissionDate"), dr("TerritoryDr").ToString().Trim()))
                Else
                    MsgBox("Government Sales not found in TerritoryDR : " & dr("TerritoryDr").ToString().Trim())
                End If
            Next
            'For Each dr As DataRow In dt.Rows
            '    DataMaintenance.myParamArray(0, 0) = "@rowid"
            '    DataMaintenance.myParamArray(0, 1) = SqlDbType.VarChar
            '    DataMaintenance.myParamArray(0, 2) = 10
            '    DataMaintenance.myParamArray(0, 3) = ParameterDirection.Input
            '    DataMaintenance.myParamArray(0, 4) = "String"
            '    DataMaintenance.myParamArray(0, 5) = dr("rowid").ToString().Trim()

            '    DataMaintenance.ExecuteCommand(ServerPath2, "SegmentRule_Correct_MetroDrugSale_ByRowId", CommandType.StoredProcedure, 2)
            'Next
            LogHelper.InsertLog("FrmSalesControl.GovtLagundex_Click.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmSalesControl.GovtLagundex_Click.Error: " & ex.Message)
        End Try
    End Sub

  
    Private Sub btn53TradeGovtGMARizal_Click(sender As Object, e As EventArgs) Handles btn53TradeGovtGMARizal.Click
         Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim commissiondate As New SqlParameter("@commissiondate", SqlDbType.DateTime, 10) : commissiondate.Direction = ParameterDirection.Input : commissiondate.Value = dtpMonth.Text : Params(0) = commissiondate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_53TradeGovtGMARizalSelect", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("FrmSalesControl.GovtLagundex_Click.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmSalesControl.btn53TradeGovtGMARizal_Click.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnGovtLagundex_Click(sender As Object, e As EventArgs) Handles btnGovtLagundex.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim commissiondate As New SqlParameter("@commissiondate", SqlDbType.DateTime, 10) : commissiondate.Direction = ParameterDirection.Input : commissiondate.Value = dtpMonth.Text : Params(0) = commissiondate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_50RealGovtlagundex", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("FrmSalesControl.GovtLagundex_Click.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmSalesControl.GovtLagundex_Click.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn44monthbudget2_Click(sender As Object, e As EventArgs) Handles btn44monthbudget2.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim commissiondate As New SqlParameter("@commissiondate", SqlDbType.DateTime, 10) : commissiondate.Direction = ParameterDirection.Input : commissiondate.Value = dtpMonth.Text : Params(0) = commissiondate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_Budget_DisplayBudget", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn45currprevbudget_Click(sender As Object, e As EventArgs) Handles btn45currprevbudget.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim commissiondate As New SqlParameter("@commissiondate", SqlDbType.DateTime, 10) : commissiondate.Direction = ParameterDirection.Input : commissiondate.Value = dtpMonth.Text : Params(0) = commissiondate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_Budget_TwoMonths", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim commissiondate As New SqlParameter("@commissiondate", SqlDbType.DateTime, 10) : commissiondate.Direction = ParameterDirection.Input : commissiondate.Value = dtpMonth.Text : Params(0) = commissiondate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_54MonthTMBudget", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("Util_54MonthTMBudget.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("Util_54MonthTMBudget.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnspecialistterritories_Click(sender As Object, e As EventArgs) Handles btnspecialistterritories.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim commissiondate As New SqlParameter("@commissiondate", SqlDbType.DateTime, 10) : commissiondate.Direction = ParameterDirection.Input : commissiondate.Value = dtpMonth.Text : Params(0) = commissiondate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_56SpecialistTerritories", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("Util_56SpecialistTerritories.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("Util_56SpecialistTerritories.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim commissiondate As New SqlParameter("@commissiondate", SqlDbType.DateTime, 10) : commissiondate.Direction = ParameterDirection.Input : commissiondate.Value = dtpMonth.Text : Params(0) = commissiondate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_Budget_YearlyBudget", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("Util_Budget_YearlyBudget.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("Util_Budget_YearlyBudget.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSubDistItem_Click(sender As Object, e As EventArgs) Handles btnSubDistItem.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim commissiondate As New SqlParameter("@commissiondate", SqlDbType.DateTime, 10) : commissiondate.Direction = ParameterDirection.Input : commissiondate.Value = dtpMonth.Text : Params(0) = commissiondate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_54SubDistitems", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("FrmSalesControl.Util_54SubDistitems.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmSalesControl.Util_54SubDistitems.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        ExportToExcel(dgvSales)
    End Sub

    Private Sub btnSamarLeyteCombi_Click(sender As Object, e As EventArgs) Handles btnSamarLeyteCombi.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_SamarLeyteCombiSales", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales")
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("FrmSalesControl.Util_SamarLeyteCombiSales.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmSalesControl.Util_SamarLeyteCombiSales.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_RowacholYTD", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales")
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("FrmSalesControl.Util_SamarLeyteCombiSales.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmSalesControl.Util_SamarLeyteCombiSales.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCombiJanJun_Click(sender As Object, e As EventArgs) Handles btnCombiJanJun.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_CombiJanJun", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales")
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("FrmSalesControl.Util_CombiJanJun.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmSalesControl.Util_CombiJanJun.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnTagMRDivision_Click(sender As Object, e As EventArgs) Handles btnTagMRDivision.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_27Tagmrdivision", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("Util_27Tagmrdivision.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("Util_27Tagmrdivision.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim commissiondate As New SqlParameter("@commissiondate", SqlDbType.DateTime, 10) : commissiondate.Direction = ParameterDirection.Input : commissiondate.Value = dtpMonth.Text : Params(0) = commissiondate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_47SUBDIST2MOS", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            GroupBox3.Text = "Total number of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub
End Class