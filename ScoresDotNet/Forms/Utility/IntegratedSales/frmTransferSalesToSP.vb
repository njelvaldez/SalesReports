Imports System.Data.SqlClient
Public Class frmTransferSalesToSP
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
            Dim Params(3) As SqlParameter
            Dim mrcode As New SqlParameter("@mrcode", SqlDbType.VarChar, 10) : mrcode.Direction = ParameterDirection.Input : mrcode.Value = "" : Params(0) = mrcode
            Dim mrname As New SqlParameter("@mrname", SqlDbType.VarChar, 75) : mrname.Direction = ParameterDirection.Input : mrname.Value = "" : Params(1) = mrname
            Dim rowid As New SqlParameter("@rowid", SqlDbType.VarChar, 10) : rowid.Direction = ParameterDirection.Input : rowid.Value = "0" : Params(2) = rowid
            Dim mrterrcode As New SqlParameter("@mrterrcode", SqlDbType.VarChar, 10) : mrterrcode.Direction = ParameterDirection.Input : mrterrcode.Value = "" : Params(3) = mrterrcode
            Dim dt As New DataTable
            dt = (DirectCast(dgvSalesToTransfer.DataSource, DataTable))
            mrcode.Value = ComboBox1.SelectedValue.ToString().Trim()
            mrname.Value = ComboBox1.Text.ToString().Trim()
            mrterrcode.Value = GetMrTerrCode(mrcode.Value.ToString.Trim)
            For Each dr As DataRow In dt.Rows
                rowid.Value = dr("rowid").ToString().Trim()
                SaveIntegratedSalesHistory(rowid.Value.ToString())
                BusinessObject.Sub_Update(ServerPath2, "Util_IntegratedSales_TransferSalesToSP", CommandType.StoredProcedure, Params)
            Next
            MsgBox("Transfer of sales to SP is complete!")
        Catch ex As Exception
            MsgBox("Error in UpdateIntegratedSales : " + ex.Message)
            retval = False
        End Try
    End Sub
    Public Sub InitializeSpecialistCombo()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim mrcode As New SqlParameter("@mrcode", SqlDbType.VarChar, 10) : mrcode.Direction = ParameterDirection.Input : mrcode.Value = "0" : Params(0) = mrcode
            Dim tempds As New DataSet
            tempds.Tables.Add("Specialist")
            Me.Cursor = Cursors.WaitCursor
            BusinessObject.Sub_Show(ServerPath2, "Util_MedRep_SelectActive", CommandType.StoredProcedure, tempds, "Specialist", Params)
            ComboBox1.DataSource = tempds.Tables("Specialist")
            ComboBox1.ValueMember = "MRCODE"
            ComboBox1.DisplayMember = "MRNAME"
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmTransferSalesToSP_Load(sender As Object, e As EventArgs) Handles Me.Load
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
    Private Function GetMrTerrCode(strmrcode As String) As String
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter
        Dim mrcode As New SqlParameter("@mrcode", SqlDbType.VarChar, 10) : mrcode.Direction = ParameterDirection.Input : mrcode.Value = strmrcode : Params(0) = mrcode
        Dim tempds As New DataSet
        Dim retval As String = ""
        tempds.Tables.Add("temptbl")
        BusinessObject.Sub_Show(ServerPath2, "Util_AreaPMR_SelectAreaCode", CommandType.StoredProcedure, tempds, "temptbl", Params)
        If tempds.Tables("temptbl").Rows.Count > 0 Then
            retval = tempds.Tables("temptbl").Rows(0)("AREACODE").ToString().Trim
        End If
        Return retval
    End Function

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex >= 0 Then
            If ComboBox1.Text <> "" Then
                txtSpecialistCode.Text = ComboBox1.SelectedValue.ToString
            End If
        End If
    End Sub
End Class