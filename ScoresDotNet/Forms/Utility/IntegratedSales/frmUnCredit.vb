Imports System.Data.SqlClient
Public Class frmUnCredit
    Private RemoteDataSet As New DataSet
    Private Sub RefreshTable()
        Try
            RemoteDataSet.Tables.Remove("IntegratedSales")
        Catch ex As Exception
        End Try
        RemoteDataSet.Tables.Add("IntegratedSales")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnUnCreditSales.Click
        Dim result As Integer = MessageBox.Show("Are you sure , you want to Un-Credit sales as shown below?", "Integrated Sales", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Yes Then
            UncreditSales()
        End If
    End Sub
    Private Sub UncreditSales()
        Dim retval As Boolean = True
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim rowid As New SqlParameter("@rowid", SqlDbType.VarChar, 10) : rowid.Direction = ParameterDirection.Input : rowid.Value = "0" : Params(0) = rowid
            Dim dt As New DataTable
            dt = (DirectCast(dgvSalesToTransfer.DataSource, DataTable))
            For Each dr As DataRow In dt.Rows
                rowid.Value = dr("rowid").ToString().Trim()
                SaveIntegratedSalesHistory(rowid.Value.ToString())
                BusinessObject.Sub_Update(ServerPath2, "Util_IntegratedSales_UnCredit", CommandType.StoredProcedure, Params)
            Next
            MsgBox("Un-Credit of Sales is complete!")
        Catch ex As Exception
            MsgBox("Error in UncreditSales : " + ex.Message)
            retval = False
        End Try
    End Sub
    Private Sub frmUnCredit_Load(sender As Object, e As EventArgs) Handles Me.Load
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub SaveIntegratedSalesHistory(strrowid As String)
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter
        Dim rowid As New SqlParameter("@rowid", SqlDbType.VarChar, 10) : rowid.Direction = ParameterDirection.Input : rowid.Value = strrowid : Params(0) = rowid
        Try
            BusinessObject.Sub_Update(ServerPath2, "Util_IntegratedSalesHistory_Insert", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox("Error in SaveIntegratedSalesHistory : " + ex.Message)
        End Try
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class