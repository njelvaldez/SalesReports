Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Configuration
Imports System.Globalization
Public Class frmMercurySales
    Private RemoteDataSet As New DataSet
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub frmMercurySales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RemoteDataSet.Tables.Add("Area")
        LoadSpecialist()
    End Sub

    Private Sub LoadSpecialist()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            ResetDataset()
            Dim Params2(0) As SqlParameter
            Dim MRNAME2 As New SqlParameter("@MRNAME", SqlDbType.VarChar, 100) : MRNAME2.Direction = ParameterDirection.Input : MRNAME2.Value = txtToMrName.Text : Params2(0) = MRNAME2
            If txtToMrName.Text <> "" Then
                BusinessObject.Sub_Show(ServerPath2, "MedrepCT_ShowFilter", CommandType.StoredProcedure, RemoteDataSet, "Area", Params2)
            Else
                BusinessObject.Sub_Show(ServerPath2, "MedrepCT_Show", CommandType.StoredProcedure, RemoteDataSet, "Area")
            End If
            dgvToSpecialist.DataSource = RemoteDataSet.Tables("Area")
            LogHelper.InsertLog("LoadSpecialist.ShowArea.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("LoadSpecialist.ShowArea.Error: " & ex.Message)
        End Try
    End Sub
    Private Sub LoadSpecialistMercury()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(1) As SqlParameter
            ResetDataset()
            Dim MRNAME As New SqlParameter("@MRNAME", SqlDbType.VarChar, 100) : MRNAME.Direction = ParameterDirection.Input : MRNAME.Value = txtFromMrName.Text : Params(0) = MRNAME

            If txtFromMrName.Text <> "" And txtfromdate.Text <> "" And IsDate(txtfromdate.Text) Then
                Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = Convert.ToDateTime(txtfromdate.Text) : Params(1) = salescycledate
                BusinessObject.Sub_Show(ServerPath2, "MedrepCT_Mercury", CommandType.StoredProcedure, RemoteDataSet, "Area", Params)
            End If
            dgvFromSpecialist.DataSource = RemoteDataSet.Tables("Area")
            LogHelper.InsertLog("LoadSpecialist.ShowArea.Success")
        Catch ex As Exception
            'MsgBox(ex.Message)
            LogHelper.InsertLog("LoadSpecialist.ShowArea.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ResetDataset()
        RemoteDataSet.Tables.Remove("Area")
        RemoteDataSet.Tables.Add("Area")
    End Sub

    Private Sub txtFromMrName_TextChanged(sender As Object, e As EventArgs) Handles txtFromMrName.TextChanged
        If txtFromMrName.Text.Length >= 3 Then
            LoadSpecialistMercury()
        End If
    End Sub

    Private Sub txtToMrName_TextChanged(sender As Object, e As EventArgs) Handles txtToMrName.TextChanged
        If txtToMrName.Text.Length >= 3 Then
            LoadSpecialist()
        End If
    End Sub

    Private Sub dgvFromSpecialist_DoubleClick(sender As Object, e As EventArgs) Handles dgvFromSpecialist.DoubleClick
        Dim row As Integer = dgvFromSpecialist.CurrentRow.Index
        If row > -1 Then
            txtfrommrcode.Text = dgvFromSpecialist.Rows(row).Cells("MRCODE").Value.ToString() + " :: " + _
                dgvFromSpecialist.Rows(row).Cells("MRNAME").Value.ToString()
        End If
    End Sub

    Private Sub dgvToSpecialist_DoubleClick(sender As Object, e As EventArgs) Handles dgvToSpecialist.DoubleClick
        Dim row As Integer = dgvToSpecialist.CurrentRow.Index
        If row > -1 Then
            txttomrcode.Text = dgvToSpecialist.Rows(row).Cells("MRCODE").Value.ToString() + " :: " + _
                dgvToSpecialist.Rows(row).Cells("MRNAME").Value.ToString()
        End If
    End Sub

    Private Sub btnTRansferBudget_Click(sender As Object, e As EventArgs) Handles btnTRansferBudget.Click
        If txtfromdate.Text <> "" And txttodate.Text <> "" And _
            txtfrommrcode.Text <> "" And txttomrcode.Text <> "" Then
            'Process Transfer Mercury Sales
            ProcessTransferMercurySales()
        Else
            MsgBox("Please review required fields!")
        End If
    End Sub

    Private Sub ProcessTransferMercurySales()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(3) As SqlParameter
        Dim FROMMRCODE As New SqlParameter("@FROMMRCODE", SqlDbType.VarChar, 10) : FROMMRCODE.Direction = ParameterDirection.Input : FROMMRCODE.Value = GetFromMRcode() : Params(0) = FROMMRCODE
        Dim TOMRCODE As New SqlParameter("@TOMRCODE", SqlDbType.VarChar, 10) : TOMRCODE.Direction = ParameterDirection.Input : TOMRCODE.Value = GettoMRcode() : Params(1) = TOMRCODE
        Dim FROMDATE As New SqlParameter("@FROMDATE", SqlDbType.DateTime, 10) : FROMDATE.Direction = ParameterDirection.Input : FROMDATE.Value = txtfromdate.Text.Trim : Params(2) = FROMDATE
        Dim TODATE As New SqlParameter("@TODATE", SqlDbType.DateTime, 10) : TODATE.Direction = ParameterDirection.Input : TODATE.Value = txttodate.Text.Trim : Params(3) = TODATE
        Try
            If txtfromdate.Text <> "" And txttodate.Text <> "" And txtfrommrcode.Text <> "" And txttomrcode.Text <> "" Then
                BusinessObject.Sub_Update(ServerPath2, "Util_TransferMercurySales", CommandType.StoredProcedure, Params)
                MsgBox("Transfer Mercury Sales is complete!")
            Else
                MsgBox("Please review required fields!")
            End If
        Catch ex As Exception
            MsgBox("Error in executing Util_TransferMercurySales SP: " + ex.Message)
        End Try
    End Sub

    Private Function GetFromMRcode() As String
        Return txtfrommrcode.Text.Substring(0, txtfrommrcode.Text.IndexOf(" :: ")).Trim
    End Function

    Private Function GettoMRcode() As String
        Return txttomrcode.Text.Substring(0, txttomrcode.Text.IndexOf(" :: ")).Trim
    End Function

    Private Sub txtfromdate_TextChanged(sender As Object, e As EventArgs) Handles txtfromdate.TextChanged
        If IsDate(txtfromdate.Text) Then
            LoadSpecialistMercury()
        End If
    End Sub
End Class