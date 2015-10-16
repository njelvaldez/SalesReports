Imports System.Data.SqlClient
Imports Microsoft
Imports Microsoft.Office.Interop
Imports System.Configuration
Imports System.Globalization
Imports System.Runtime.InteropServices
Public Class frmUntagged

    Private SalesTransDate As String = ""
    Public RemoteDataSet As New DataSet
    Public pubcomdate As New DateTime
    Private MonthName As String = ""

    Private Sub frmUntagged_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnTagSales.Click
        Dim retval As Boolean = True
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim dt As New DataTable
            dt = (DirectCast(dgvSales.DataSource, DataTable))
            For Each dr As DataRow In dt.Rows
                DataMaintenance.myParamArray(0, 0) = "@rowid"
                DataMaintenance.myParamArray(0, 1) = SqlDbType.VarChar
                DataMaintenance.myParamArray(0, 2) = 10
                DataMaintenance.myParamArray(0, 3) = ParameterDirection.Input
                DataMaintenance.myParamArray(0, 4) = "String"
                DataMaintenance.myParamArray(0, 5) = dr("rowid").ToString().Trim()

                DataMaintenance.myParamArray(1, 0) = "@CommissionDate"
                DataMaintenance.myParamArray(1, 1) = SqlDbType.DateTime
                DataMaintenance.myParamArray(1, 2) = 10
                DataMaintenance.myParamArray(1, 3) = ParameterDirection.Input
                DataMaintenance.myParamArray(1, 4) = "Date"
                DataMaintenance.myParamArray(1, 5) = dtpMonth.Value
                DataMaintenance.ExecuteCommand(ServerPath2, "SegmentRule_Correct_MetroDrugSale_ByRowId", CommandType.StoredProcedure, 2)
            Next
            MsgBox("Tag Sales process is complete.")
        Catch ex As Exception
            MsgBox("Error in SegmentRule_Correct_MetroDrugSale_ByRowId : " + ex.Message)
            retval = False
        End Try
    End Sub
    Public Sub EnableTagSales()
        btnTagSales.Enabled = True
        btnTagSalesTrade.Enabled = False
        btnTagPalawan.Enabled = False
    End Sub
    Public Sub EnableTagSalesTrade()
        btnTagSales.Enabled = False
        btnTagSalesTrade.Enabled = True
        btnTagPalawan.Enabled = False
    End Sub

    Public Sub EnableTagSalesPalawan()
        btnTagSales.Enabled = False
        btnTagSalesTrade.Enabled = False
        btnTagPalawan.Enabled = True
    End Sub

    Private Sub btnTagSalesTrade_Click(sender As Object, e As EventArgs) Handles btnTagSalesTrade.Click
        Dim retval As Boolean = True
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim dt As New DataTable
            dt = (DirectCast(dgvSales.DataSource, DataTable))
            For Each dr As DataRow In dt.Rows
                DataMaintenance.myParamArray(0, 0) = "@rowid"
                DataMaintenance.myParamArray(0, 1) = SqlDbType.VarChar
                DataMaintenance.myParamArray(0, 2) = 10
                DataMaintenance.myParamArray(0, 3) = ParameterDirection.Input
                DataMaintenance.myParamArray(0, 4) = "String"
                DataMaintenance.myParamArray(0, 5) = dr("rowid").ToString().Trim()

                DataMaintenance.myParamArray(1, 0) = "@CommissionDate"
                DataMaintenance.myParamArray(1, 1) = SqlDbType.DateTime
                DataMaintenance.myParamArray(1, 2) = 10
                DataMaintenance.myParamArray(1, 3) = ParameterDirection.Input
                DataMaintenance.myParamArray(1, 4) = "Date"
                DataMaintenance.myParamArray(1, 5) = dtpMonth.Value
                DataMaintenance.ExecuteCommand(ServerPath2, "SegmentRule_Correct_MetroDrugSale_ByRowId_Trade", CommandType.StoredProcedure, 2)
            Next
            MsgBox("Tag Sales process is complete.")
        Catch ex As Exception
            MsgBox("Error in SegmentRule_Correct_MetroDrugSale_ByRowId_Trade : " + ex.Message)
            retval = False
        End Try
    End Sub

    Private Sub btnTagPalawan_Click(sender As Object, e As EventArgs) Handles btnTagPalawan.Click
        Dim retval As Boolean = True
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim dt As New DataTable
            dt = (DirectCast(dgvSales.DataSource, DataTable))
            For Each dr As DataRow In dt.Rows
                DataMaintenance.myParamArray(0, 0) = "@rowid"
                DataMaintenance.myParamArray(0, 1) = SqlDbType.VarChar
                DataMaintenance.myParamArray(0, 2) = 10
                DataMaintenance.myParamArray(0, 3) = ParameterDirection.Input
                DataMaintenance.myParamArray(0, 4) = "String"
                DataMaintenance.myParamArray(0, 5) = dr("rowid").ToString().Trim()

                DataMaintenance.myParamArray(1, 0) = "@CommissionDate"
                DataMaintenance.myParamArray(1, 1) = SqlDbType.DateTime
                DataMaintenance.myParamArray(1, 2) = 10
                DataMaintenance.myParamArray(1, 3) = ParameterDirection.Input
                DataMaintenance.myParamArray(1, 4) = "Date"
                DataMaintenance.myParamArray(1, 5) = dtpMonth.Value
                DataMaintenance.ExecuteCommand(ServerPath2, "SegmentRule_Correct_MetroDrugSale_ByRowId_Palawan", CommandType.StoredProcedure, 2)
            Next
            MsgBox("Tag Sales process is complete.")
        Catch ex As Exception
            MsgBox("Error in SegmentRule_Correct_MetroDrugSale_ByRowId : " + ex.Message)
            retval = False
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim retval As Boolean = True
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim dt As New DataTable
            dt = (DirectCast(dgvSales.DataSource, DataTable))
            For Each dr As DataRow In dt.Rows
                DataMaintenance.myParamArray(0, 0) = "@rowid"
                DataMaintenance.myParamArray(0, 1) = SqlDbType.VarChar
                DataMaintenance.myParamArray(0, 2) = 10
                DataMaintenance.myParamArray(0, 3) = ParameterDirection.Input
                DataMaintenance.myParamArray(0, 4) = "String"
                DataMaintenance.myParamArray(0, 5) = dr("rowid").ToString().Trim()
                DataMaintenance.ExecuteCommand(ServerPath2, "SegmentRule_ProcessData_SubDistributorData_CorrectByRowID", CommandType.StoredProcedure, 1)
            Next
            MsgBox("Tag SubDist Sales process is complete.")
        Catch ex As Exception
            MsgBox("Error in SegmentRule_ProcessData_SubDistributorData_CorrectByRowID : " + ex.Message)
            retval = False
        End Try
    End Sub
End Class