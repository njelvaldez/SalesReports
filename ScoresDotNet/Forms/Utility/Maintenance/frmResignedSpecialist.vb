Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Configuration
Imports System.Globalization
Public Class frmResignedSpecialist
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
    Private Sub LoadFromSpecialist()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            ResetDataset()
            Dim Params2(0) As SqlParameter
            Dim MRNAME2 As New SqlParameter("@MRNAME", SqlDbType.VarChar, 100) : MRNAME2.Direction = ParameterDirection.Input : MRNAME2.Value = txtFromMrName.Text : Params2(0) = MRNAME2
            If txtFromMrName.Text <> "" Then
                BusinessObject.Sub_Show(ServerPath2, "MedrepCT_ShowFilter", CommandType.StoredProcedure, RemoteDataSet, "Area", Params2)
            Else
                BusinessObject.Sub_Show(ServerPath2, "MedrepCT_Show", CommandType.StoredProcedure, RemoteDataSet, "Area")
            End If
            dgvFromSpecialist.DataSource = RemoteDataSet.Tables("Area")
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
            LoadFromSpecialist()
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

    Private Sub btnTransferMercury_Click(sender As Object, e As EventArgs) Handles btnTransferMercury.Click
        If txtfromdate.Text <> "" And txttodate.Text <> "" And _
            txtfrommrcode.Text <> "" And txttomrcode.Text <> "" Then
            'Process Transfer Mercury Sales
            btnTransferMercury.Enabled = False
            If IsTrade() Then
                ProcessTransferMercurySalesTrade()
            Else
                ProcessTransferMercurySales()
            End If
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
                ListBox1.Items.Add("Mercury-Ok")
            Else
                MsgBox("Please review required fields!")
            End If
        Catch ex As Exception
            MsgBox("Error in executing Util_TransferMercurySales SP: " + ex.Message)
        End Try
    End Sub

    Private Sub ProcessTransferMercurySalesTrade()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(3) As SqlParameter
        Dim FROMMRCODE As New SqlParameter("@FROMMRCODE", SqlDbType.VarChar, 10) : FROMMRCODE.Direction = ParameterDirection.Input : FROMMRCODE.Value = GetFromMRcode() : Params(0) = FROMMRCODE
        Dim TOMRCODE As New SqlParameter("@TOMRCODE", SqlDbType.VarChar, 10) : TOMRCODE.Direction = ParameterDirection.Input : TOMRCODE.Value = GettoMRcode() : Params(1) = TOMRCODE
        Dim FROMDATE As New SqlParameter("@FROMDATE", SqlDbType.DateTime, 10) : FROMDATE.Direction = ParameterDirection.Input : FROMDATE.Value = txtfromdate.Text.Trim : Params(2) = FROMDATE
        Dim TODATE As New SqlParameter("@TODATE", SqlDbType.DateTime, 10) : TODATE.Direction = ParameterDirection.Input : TODATE.Value = txttodate.Text.Trim : Params(3) = TODATE
        Try
            If txtfromdate.Text <> "" And txttodate.Text <> "" And txtfrommrcode.Text <> "" And txttomrcode.Text <> "" Then
                BusinessObject.Sub_Update(ServerPath2, "Util_TransferMercurySalesTSSP", CommandType.StoredProcedure, Params)
                MsgBox("Transfer Mercury Sales is complete!")
                ListBox1.Items.Add("Mercury-Ok")
            Else
                MsgBox("Please review required fields!")
            End If
        Catch ex As Exception
            MsgBox("Error in executing Util_TransferMercurySalesTSSP SP: " + ex.Message)
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

    Private Sub btnTransferBudgets_Click(sender As Object, e As EventArgs) Handles btnTransferBudgets.Click
        If txtfromdate.Text <> "" And txttodate.Text <> "" And _
         txtfrommrcode.Text <> "" And txttomrcode.Text <> "" Then
            'Process Transfer SP Budget
            btnTransferBudgets.Enabled = False
            ProcessTransferSPBudget()
        Else
            MsgBox("Please review required fields!")
        End If
    End Sub

    Private Sub ProcessTransferSPBudget()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(3) As SqlParameter
        Dim FROMMRCODE As New SqlParameter("@FROMMRCODE", SqlDbType.VarChar, 10) : FROMMRCODE.Direction = ParameterDirection.Input : FROMMRCODE.Value = GetFromMRcode() : Params(0) = FROMMRCODE
        Dim TOMRCODE As New SqlParameter("@TOMRCODE", SqlDbType.VarChar, 10) : TOMRCODE.Direction = ParameterDirection.Input : TOMRCODE.Value = GetToMrcode() : Params(1) = TOMRCODE
        Dim FROMDATE As New SqlParameter("@FROMDATE", SqlDbType.DateTime, 10) : FROMDATE.Direction = ParameterDirection.Input : FROMDATE.Value = txtfromdate.Text.Trim : Params(2) = FROMDATE
        Dim TODATE As New SqlParameter("@TODATE", SqlDbType.DateTime, 10) : TODATE.Direction = ParameterDirection.Input : TODATE.Value = txttodate.Text.Trim : Params(3) = TODATE
        Try
            BusinessObject.Sub_Update(ServerPath2, "Util_TransferSPBudget", CommandType.StoredProcedure, Params)
            MsgBox("Transfer of SP Budget is complete!")
            ListBox1.Items.Add("Budget-Ok")
        Catch ex As Exception
            MsgBox("Error in executing Util_TransferSPBudget SP: " + ex.Message)
            ListBox1.Items.Add("Error in executing Util_TransferSPBudget SP: " + ex.Message)
        End Try
    End Sub

    Private Sub btnTransferIntegratedSalesToSP_Click(sender As Object, e As EventArgs) Handles btnTransferIntegratedSalesToSP.Click
        If txtfromdate.Text <> "" And txttodate.Text <> "" And _
           txtfrommrcode.Text <> "" And txttomrcode.Text <> "" Then
            btnTransferIntegratedSalesToSP.Enabled = False
            If IsTrade() Then
                ProcessTransferIntegratedSalesToSPTrade()
            Else
                ProcessTransferIntegratedSalesToSP()
            End If
        Else
            MsgBox("Please review required fields!")
        End If
    End Sub

    Private Sub ProcessTransferIntegratedSalesToSP()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(3) As SqlParameter
        Dim FROMMRCODE As New SqlParameter("@FROMMRCODE", SqlDbType.VarChar, 10) : FROMMRCODE.Direction = ParameterDirection.Input : FROMMRCODE.Value = GetFromMRcode() : Params(0) = FROMMRCODE
        Dim TOMRCODE As New SqlParameter("@TOMRCODE", SqlDbType.VarChar, 10) : TOMRCODE.Direction = ParameterDirection.Input : TOMRCODE.Value = GettoMRcode() : Params(1) = TOMRCODE
        Dim FROMDATE As New SqlParameter("@FROMDATE", SqlDbType.DateTime, 10) : FROMDATE.Direction = ParameterDirection.Input : FROMDATE.Value = txtfromdate.Text.Trim : Params(2) = FROMDATE
        Dim TODATE As New SqlParameter("@TODATE", SqlDbType.DateTime, 10) : TODATE.Direction = ParameterDirection.Input : TODATE.Value = txttodate.Text.Trim : Params(3) = TODATE
        Try
            BusinessObject.Sub_Update(ServerPath2, "Util_TransferIntegratedSalesToSP", CommandType.StoredProcedure, Params)
            MsgBox("Transfer IntegratedSales To SP is complete!")
            ListBox1.Items.Add("IntegratedSales-Ok")
        Catch ex As Exception
            MsgBox("Error in executing Util_TransferIntegratedSalesToSP: " + ex.Message)
            ListBox1.Items.Add("Error in executing Util_TransferIntegratedSalesToSP: " + ex.Message)
        End Try
    End Sub

    Private Sub ProcessTransferIntegratedSalesToSPTrade()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(3) As SqlParameter
        Dim FROMMRCODE As New SqlParameter("@FROMMRCODE", SqlDbType.VarChar, 10) : FROMMRCODE.Direction = ParameterDirection.Input : FROMMRCODE.Value = GetFromMRcode() : Params(0) = FROMMRCODE
        Dim TOMRCODE As New SqlParameter("@TOMRCODE", SqlDbType.VarChar, 10) : TOMRCODE.Direction = ParameterDirection.Input : TOMRCODE.Value = GettoMRcode() : Params(1) = TOMRCODE
        Dim FROMDATE As New SqlParameter("@FROMDATE", SqlDbType.DateTime, 10) : FROMDATE.Direction = ParameterDirection.Input : FROMDATE.Value = txtfromdate.Text.Trim : Params(2) = FROMDATE
        Dim TODATE As New SqlParameter("@TODATE", SqlDbType.DateTime, 10) : TODATE.Direction = ParameterDirection.Input : TODATE.Value = txttodate.Text.Trim : Params(3) = TODATE
        Try
            BusinessObject.Sub_Update(ServerPath2, "Util_TransferIntegratedSalesToTSSP", CommandType.StoredProcedure, Params)
            MsgBox("Transfer IntegratedSales To SP is complete!")
            ListBox1.Items.Add("IntegratedSales-Ok")
        Catch ex As Exception
            MsgBox("Error in executing Util_TransferIntegratedSalesToTSSP: " + ex.Message)
            ListBox1.Items.Add("Error in executing Util_TransferIntegratedSalesToSP: " + ex.Message)
        End Try
    End Sub

    Private Sub btnUpdateSpecialist_Click(sender As Object, e As EventArgs) Handles btnUpdateSpecialist.Click
        If txtfromdate.Text <> "" And txttodate.Text <> "" And _
           txtfrommrcode.Text <> "" And txttomrcode.Text <> "" Then
            btnUpdateSpecialist.Enabled = False
            ProcessUpdateSpecialist()
        Else
            MsgBox("Please review required fields!")
        End If
    End Sub

    Private Sub ProcessUpdateSpecialist()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(1) As SqlParameter
        Dim FROMMRCODE As New SqlParameter("@FROMMRCODE", SqlDbType.VarChar, 10) : FROMMRCODE.Direction = ParameterDirection.Input : FROMMRCODE.Value = GetFromMRcode() : Params(0) = FROMMRCODE
        Dim FROMDATE As New SqlParameter("@FROMDATE", SqlDbType.DateTime, 10) : FROMDATE.Direction = ParameterDirection.Input : FROMDATE.Value = txtfromdate.Text.Trim : Params(1) = FROMDATE
        Try
            BusinessObject.Sub_Update(ServerPath2, "Util_Medrep_Update_EndDate", CommandType.StoredProcedure, Params)
            MsgBox("Update Specialist is complete!")
            ListBox1.Items.Add("Specialist-Ok")
        Catch ex As Exception
            MsgBox("Error in executing Util_Medrep_Update_EndDate: " + ex.Message)
            ListBox1.Items.Add("Error in executing Util_Medrep_Update_EndDate: " + ex.Message)
        End Try
    End Sub

    Private Sub btnUpdateSupMr_Click(sender As Object, e As EventArgs) Handles btnUpdateSupMr.Click
        If txtfromdate.Text <> "" And txttodate.Text <> "" And _
         txtfrommrcode.Text <> "" And txttomrcode.Text <> "" Then
            'If Supmr_SPExists(Convert.ToDateTime(txtfromdate.Text.Trim), txtfrommrcode.Text.Trim) Then
            If Supmr_SPExists(Convert.ToDateTime(txtfromdate.Text.Trim), txttomrcode.Text.Trim) Then
                MsgBox("Specialist already exists in SUPMR!")
            Else
                btnUpdateSupMr.Enabled = False
                ProcessUpdateSupMr()
            End If
        Else
            MsgBox("Please review required fields!")
        End If
    End Sub

    Private Sub ProcessUpdateSupMr()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(2) As SqlParameter
        Dim FROMMRCODE As New SqlParameter("@FROMMRCODE", SqlDbType.VarChar, 10) : FROMMRCODE.Direction = ParameterDirection.Input : FROMMRCODE.Value = GetFromMRcode() : Params(0) = FROMMRCODE
        Dim TOMRCODE As New SqlParameter("@TOMRCODE", SqlDbType.VarChar, 10) : TOMRCODE.Direction = ParameterDirection.Input : TOMRCODE.Value = GettoMRcode() : Params(1) = TOMRCODE
        Dim FROMDATE As New SqlParameter("@FROMDATE", SqlDbType.DateTime, 10) : FROMDATE.Direction = ParameterDirection.Input : FROMDATE.Value = txtfromdate.Text.Trim : Params(2) = FROMDATE
        Try
            BusinessObject.Sub_Update(ServerPath2, "Util_Supmr_Update_EndDate", CommandType.StoredProcedure, Params)
            MsgBox("Update SupMr is complete!")
            ListBox1.Items.Add("SupMr-Ok")
        Catch ex As Exception
            MsgBox("Error in executing Util_Supmr_Update_EndDate: " + ex.Message)
            ListBox1.Items.Add("Error in executing Util_Supmr_Update_EndDate: " + ex.Message)
        End Try
    End Sub

    Private Sub btnTransferArea_Click(sender As Object, e As EventArgs) Handles btnTransferArea.Click
        If txtfromdate.Text <> "" And txttodate.Text <> "" And _
       txtfrommrcode.Text <> "" And txttomrcode.Text <> "" Then
            'If AreaPMR_Exists(Convert.ToDateTime(txtfromdate.Text.Trim), txtfrommrcode.Text.Trim) Then
            If AreaPMR_Exists(Convert.ToDateTime(txtfromdate.Text.Trim), txttomrcode.Text.Trim) Then
                MsgBox("Specialist already exists in AreaPMR!")
            Else
                btnTransferArea.Enabled = False
                ProcessTransferArea()
            End If
        Else
            MsgBox("Please review required fields!")
        End If
    End Sub

    Private Sub ProcessTransferArea()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(2) As SqlParameter
        Dim FROMMRCODE As New SqlParameter("@FROMMRCODE", SqlDbType.VarChar, 10) : FROMMRCODE.Direction = ParameterDirection.Input : FROMMRCODE.Value = GetFromMRcode() : Params(0) = FROMMRCODE
        Dim TOMRCODE As New SqlParameter("@TOMRCODE", SqlDbType.VarChar, 10) : TOMRCODE.Direction = ParameterDirection.Input : TOMRCODE.Value = GettoMRcode() : Params(1) = TOMRCODE
        Dim FROMDATE As New SqlParameter("@FROMDATE", SqlDbType.DateTime, 10) : FROMDATE.Direction = ParameterDirection.Input : FROMDATE.Value = txtfromdate.Text.Trim : Params(2) = FROMDATE
        Try
            BusinessObject.Sub_Update(ServerPath2, "Util_AreaPMR_TransferToSp", CommandType.StoredProcedure, Params)
            MsgBox("Transfer Area is complete!")
            ListBox1.Items.Add("Area-Ok")
        Catch ex As Exception
            MsgBox("Error in executing [Util_AreaPMR_TransferToSp: " + ex.Message)
            ListBox1.Items.Add("Error in executing [Util_AreaPMR_TransferToSp: " + ex.Message)
        End Try
    End Sub

    Private Sub btnProcessAll_Click(sender As Object, e As EventArgs) Handles btnProcessAll.Click
        If txtfromdate.Text <> "" And txttodate.Text <> "" And _
           txtfrommrcode.Text <> "" And txttomrcode.Text <> "" And _
           ListBox1.Items.Count <= 0 Then
            If (MessageBox.Show("Are you sure you want to proceed with Process All?", "Confirm Processing", _
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)) _
                     = DialogResult.Yes Then
                btnProcessAll.Enabled = False
                ProcessTransferSPBudget()
                ProcessTransferArea()
                If IsTrade() Then
                    ProcessTransferMercurySalesTrade()
                    ProcessTransferIntegratedSalesToSPTrade()
                Else
                    ProcessTransferMercurySales()
                    ProcessTransferIntegratedSalesToSP()
                End If

                ProcessUpdateSpecialist()
                ProcessUpdateSupMr()
            End If
        Else
            MsgBox("Please review required fields!")
        End If
    End Sub

    Private Sub txtfrommrcode_TextChanged(sender As Object, e As EventArgs) Handles txtfrommrcode.TextChanged
        If txtfrommrcode.Text <> "" Then
            lblfromsegment.Text = "From Segment : " & SupMr_Segment(txtfrommrcode.Text)
        End If
    End Sub

    Private Sub txttomrcode_TextChanged(sender As Object, e As EventArgs) Handles txttomrcode.TextChanged
        If txttomrcode.Text <> "" Then
            lbltosegment.Text = "To Segment : " & SupMr_Segment(txttomrcode.Text)
        End If
    End Sub

    Private Function IsTrade() As Boolean
        Dim retval As Boolean = False
        If lblfromsegment.Text.ToUpper.Contains("TRADE") Then 'new specialist does not have segment yet And lbltosegment.Text.ToUpper.Contains("TRADE") Then
            retval = True
        End If
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearEntry()
        EnableActions(True)
    End Sub
    Private Sub ClearEntry()
        txtFromMrName.Text = ""
        txtfrommrcode.Text = ""
        txtfromdate.Text = ""

        txtToMrName.Text = ""
        txttomrcode.Text = ""
        txttodate.Text = ""
    End Sub

    Private Sub EnableActions(enableflag As Boolean)
        btnTransferBudgets.Enabled = enableflag
        btnTransferArea.Enabled = enableflag
        btnTransferMercury.Enabled = enableflag
        btnTransferIntegratedSalesToSP.Enabled = enableflag
        btnUpdateSpecialist.Enabled = enableflag
        btnUpdateSupMr.Enabled = enableflag

    End Sub
End Class