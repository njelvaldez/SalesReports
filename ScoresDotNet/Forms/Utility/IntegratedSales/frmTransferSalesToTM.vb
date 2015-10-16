Imports System.Data.SqlClient
Public Class frmTransferSalesToTM
    Private RemoteDataSet As New DataSet
    Private Sub RefreshTable()
        Try
            RemoteDataSet.Tables.Remove("IntegratedSales")
        Catch ex As Exception
        End Try
        RemoteDataSet.Tables.Add("IntegratedSales")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTransferSalesToSP.Click
        Dim result As Integer = MessageBox.Show("Are you sure , you want to Transfer sales to " + ComboBox1.Text.ToString() + "?", "Integrated Sales", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Yes Then
            UpdateIntegratedSales()
        End If
    End Sub
    Private Sub UpdateIntegratedSales()
        Dim retval As Boolean = True
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(2) As SqlParameter
            Dim tmcode As New SqlParameter("@tmcode", SqlDbType.VarChar, 10) : tmcode.Direction = ParameterDirection.Input : tmcode.Value = "" : Params(0) = tmcode
            Dim tmname As New SqlParameter("@tmname", SqlDbType.VarChar, 75) : tmname.Direction = ParameterDirection.Input : tmname.Value = "" : Params(1) = tmname
            Dim rowid As New SqlParameter("@rowid", SqlDbType.VarChar, 10) : rowid.Direction = ParameterDirection.Input : rowid.Value = "0" : Params(2) = rowid
            Dim dt As New DataTable
            dt = (DirectCast(dgvSalesToTransfer.DataSource, DataTable))
            tmcode.Value = ComboBox1.SelectedValue.ToString().Trim()
            tmname.Value = ComboBox1.Text.ToString().Trim()
            For Each dr As DataRow In dt.Rows
                rowid.Value = dr("rowid").ToString().Trim()
                SaveIntegratedSalesHistory(rowid.Value.ToString())
                BusinessObject.Sub_Update(ServerPath2, "Util_IntegratedSales_TransferSalesToTM", CommandType.StoredProcedure, Params)
            Next
            MsgBox("Transfer of sales to TM is complete!")
        Catch ex As Exception
            MsgBox("Error in UpdateIntegratedSales : " + ex.Message)
            retval = False
        End Try
    End Sub
    Public Sub InitializeSpecialistCombo()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim tempds As New DataSet
            tempds.Tables.Add("Specialist")
            Me.Cursor = Cursors.WaitCursor
            BusinessObject.Sub_Show(ServerPath2, "Util_TM_SelectActive", CommandType.StoredProcedure, tempds, "Specialist")
            ComboBox1.DataSource = tempds.Tables("Specialist")
            ComboBox1.ValueMember = "SUPCODE"
            ComboBox1.DisplayMember = "SUPNAME"
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmTransferSalesToTM_Load(sender As Object, e As EventArgs) Handles Me.Load
        'InitializeSpecialistCombo()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
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
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex >= 0 Then
            If ComboBox1.Text <> "" Then
                txtTMCode.Text = ComboBox1.SelectedValue.ToString
            End If
        End If
    End Sub
End Class