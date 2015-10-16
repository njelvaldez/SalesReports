Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Public Class frmDailySalesUpdateUtil
    Private RemoteDataSet As New DataSet
    Private Sub frmDailySalesUpdateUtil_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RemoteDataSet.Tables.Add("IntegratedSales")
        SetDate()
        ShowNewCustomer()
    End Sub
    Private Sub RefreshTable()
        RemoteDataSet.Tables.Remove("IntegratedSales")
        RemoteDataSet.Tables.Add("IntegratedSales")
    End Sub
    Private Sub ShowNewCustomer()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_NewCustomerShipToMaster", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowNewCustomer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowNewCustomer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ShowRecordsPerInvoice()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_RecordsPerInvoice", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowRecordsPerInvoice.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowRecordsPerInvoice.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ShowMDITotalSales()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_MDITotalSales", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSales.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSales.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ShowMDITotalSalesLessPrevTransfer()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_MDITotalSalesLessPrevTransfer", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ShowMDIActualMonthSales()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_MDIActualMonthSales", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ShowNotNegativeSales()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_NotNegativeSales", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowMDITotalSalesLessPrevTransfer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ShowDuplicateTrans()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_IntegratedSales_SearchDuplicate", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowDuplicateTrans.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.ShowDuplicateTrans.Error: " & ex.Message)
        End Try
    End Sub


    Private Sub UpdateNegativeSales()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            BusinessObject.Sub_Update(ServerPath2, "Util_UpdateNotNegativeSales", CommandType.StoredProcedure, Params)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.UpdateNegativeSales.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.UpdateNegativeSales.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub GetDateRangeSales()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(2) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = dtpMonth.Text : Params(0) = salescycledate
            Dim startdate As New SqlParameter("@startdate", SqlDbType.VarChar, 10) : startdate.Direction = ParameterDirection.Input : startdate.Value = txtStartDate.Text : Params(1) = startdate
            Dim enddate As New SqlParameter("@enddate", SqlDbType.VarChar, 10) : enddate.Direction = ParameterDirection.Input : enddate.Value = txtEndDate.Text : Params(2) = enddate
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_DateRangeSales", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            LogHelper.InsertLog("frmDailySalesUpdateUtil.GetDateRangeSales.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmDailySalesUpdateUtil.GetDateRangeSales.Error: " & ex.Message)
        End Try
    End Sub
    Private Sub SetDate()
        Dim currentdate As String
        currentdate = dtpMonth.Value.Month.ToString + "/1/" + dtpMonth.Value.Year.ToString
        dtpMonth.Text = currentdate
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnNewCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewCustomers.Click
        SetDate()
        ShowNewCustomer()
    End Sub

    Private Sub btnRecordsPerInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecordsPerInvoice.Click
        ShowRecordsPerInvoice()
    End Sub

    Private Sub btnMDITotalSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMDITotalSales.Click
        ShowMDITotalSales()
    End Sub

    Private Sub btnMDITotalSalesLessPrevTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMDITotalSalesLessPrevTransfer.Click
        ShowMDITotalSalesLessPrevTransfer()
    End Sub

    Private Sub btnMDIActualMonthSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMDIActualMonthSales.Click
        ShowMDIActualMonthSales()
    End Sub

    Private Sub btnNotNegativeSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotNegativeSales.Click
        ShowNotNegativeSales()
    End Sub

    Private Sub btnCorrectNotNegative_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCorrectNotNegative.Click
        UpdateNegativeSales()
    End Sub

    Private Sub btnDateRange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDateRange.Click
        GetDateRangeSales()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDuplicateTrans.Click
        ShowDuplicateTrans()
    End Sub
End Class