Imports System.Data.SqlClient
Public Class frmTransferSales
    Private RemoteDataSet As New DataSet
    Private Sub ShowIntegratedSalesRowID()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim rowid As New SqlParameter("@rowid", SqlDbType.VarChar, 10) : rowid.Direction = ParameterDirection.Input : rowid.Value = txtRowID.Text.Trim : Params(0) = rowid
            Me.Cursor = Cursors.WaitCursor
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_IntegratedSales_SelectRowID", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSource.DataSource = RemoteDataSet.Tables("IntegratedSales")
            dgvSource.Refresh()
            LogHelper.InsertLog("frmIntegratedSales.ShowIntegratedSales.Success")
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmIntegratedSales.ShowIntegratedSales.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub RefreshTable()
        Try
            RemoteDataSet.Tables.Remove("IntegratedSales")
        Catch ex As Exception
        End Try
        RemoteDataSet.Tables.Add("IntegratedSales")
    End Sub

    Private Sub frmTransferSales_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    End Sub

    Private Sub txtRowID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRowID.TextChanged
        ShowIntegratedSalesRowID()
        DisplaySalesToDestination()
        SetDestinationSearch()
    End Sub

    Private Sub DisplaySalesToDestination()
        Dim row As Integer = 0 'dgvSource.CurrentRow.Index
        If row > -1 Then
            txtCustomerDR.Text = dgvSource.Rows(row).Cells("CustomerDR").Value.ToString()
            txtCustomerCode.Text = dgvSource.Rows(row).Cells("CustomerCode").Value.ToString()
            txtCustomerName.Text = dgvSource.Rows(row).Cells("CustomerName").Value.ToString()
            txtAddress1.Text = dgvSource.Rows(row).Cells("Address1").Value.ToString()
            txtAddress2.Text = dgvSource.Rows(row).Cells("Address2").Value.ToString()
            txtShipTo.Text = dgvSource.Rows(row).Cells("ShipTo").Value.ToString()
            txtShipAddress1.Text = dgvSource.Rows(row).Cells("ShipAddress1").Value.ToString()
            txtShipAddress2.Text = dgvSource.Rows(row).Cells("ShipAddress2").Value.ToString()
            txtTerritoryDR.Text = dgvSource.Rows(row).Cells("TerritoryDR").Value.ToString()
            txtTerritory.Text = dgvSource.Rows(row).Cells("Territory").Value.ToString()
            txtProvinceDR.Text = dgvSource.Rows(row).Cells("ProvinceDR").Value.ToString()
            txtProvince.Text = dgvSource.Rows(row).Cells("Province").Value.ToString()
            txtGroupDR.Text = dgvSource.Rows(row).Cells("GroupDR").Value.ToString()
            txtGroup.Text = dgvSource.Rows(row).Cells("Group").Value.ToString()
            txtMrCode.Text = dgvSource.Rows(row).Cells("MrCode").Value.ToString()
            txtMrName.Text = dgvSource.Rows(row).Cells("MrName").Value.ToString()
            txtTSMrCode.Text = dgvSource.Rows(row).Cells("TSMrCode").Value.ToString()
            txtTSMrName.Text = dgvSource.Rows(row).Cells("TSMrName").Value.ToString()
            txtMrTerrCode.Text = dgvSource.Rows(row).Cells("MrTerrCode").Value.ToString()
            txtSupCode.Text = dgvSource.Rows(row).Cells("SupCode").Value.ToString()
            txtSupName.Text = dgvSource.Rows(row).Cells("SupName").Value.ToString()
            txtTSSupCode.Text = dgvSource.Rows(row).Cells("TSSupCode").Value.ToString()
            txtTSSupName.Text = dgvSource.Rows(row).Cells("TSSupName").Value.ToString()
            txtSupTeamCode.Text = dgvSource.Rows(row).Cells("SupTeamCode").Value.ToString()
            txtTSAreaCode.Text = dgvSource.Rows(row).Cells("TSAreaCode").Value.ToString()
            txtTSTeamCode.Text = dgvSource.Rows(row).Cells("TSTeamCode").Value.ToString()
            txtMrDivision.Text = dgvSource.Rows(row).Cells("MrDivision").Value.ToString()
            txtCommissionDate.Text = dgvSource.Rows(row).Cells("CommissionDate").Value.ToString()
            txtSalesCycleDate.Text = dgvSource.Rows(row).Cells("SalesCycleDate").Value.ToString()
            txtQtySold.Text = dgvSource.Rows(row).Cells("QtySold").Value.ToString()
            txtAmountSold.Text = dgvSource.Rows(row).Cells("AmountSold").Value.ToString()
            txtRefCode.Text = dgvSource.Rows(row).Cells("RefCode").Value.ToString()
            txtitemcode.Text = dgvSource.Rows(row).Cells("ItemCode").Value.ToString()
            txtitemdesc.Text = dgvSource.Rows(row).Cells("ItemDesc").Value.ToString()

            If txtSalesCycleDate.Text.ToString.Trim = "" Then
                txtSalesCycleDate.Text = "1/1/1901"
            End If

            If txtCommissionDate.Text.ToString.Trim = "" Then
                txtCommissionDate.Text = "1/1/1901"
            End If

            txtRowID.Text = dgvSource.Rows(row).Cells("ROWID").Value.ToString()
        Else
            MsgBox("Please select record to transfer!")
        End If
    End Sub

    Private Sub btnToDestination_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToDestination.Click
        DisplaySalesToDestination()
        SetDestinationSearch()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransfer.Click
        Dim result As Integer = MessageBox.Show("Are you sure , you want to update sales?", "Integrated Sales", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Yes Then
            'MessageBox.Show("Yes pressed")
            UpdateIntegratedSales()
        End If
    End Sub

    Private Sub UpdateIntegratedSales()
        Dim retval As Boolean = True
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(29) As SqlParameter
            Dim customerdr As New SqlParameter("@customerdr", SqlDbType.VarChar, 10) : customerdr.Direction = ParameterDirection.Input : customerdr.Value = txtCustomerDR.Text.Trim : Params(0) = customerdr
            Dim customercode As New SqlParameter("@customercode", SqlDbType.VarChar, 10) : customercode.Direction = ParameterDirection.Input : customercode.Value = txtCustomerCode.Text.Trim : Params(1) = customercode
            Dim customername As New SqlParameter("@customername", SqlDbType.VarChar, 75) : customername.Direction = ParameterDirection.Input : customername.Value = txtCustomerName.Text.Trim : Params(2) = customername
            Dim address1 As New SqlParameter("@address1", SqlDbType.VarChar, 150) : address1.Direction = ParameterDirection.Input : address1.Value = txtAddress1.Text.Trim : Params(3) = address1
            Dim address2 As New SqlParameter("@address2", SqlDbType.VarChar, 150) : address2.Direction = ParameterDirection.Input : address2.Value = txtAddress2.Text.Trim : Params(4) = address2
            Dim shipto As New SqlParameter("@shipto", SqlDbType.VarChar, 75) : shipto.Direction = ParameterDirection.Input : shipto.Value = txtShipTo.Text.Trim : Params(5) = shipto
            Dim shipaddress1 As New SqlParameter("@shipaddress1", SqlDbType.VarChar, 150) : shipaddress1.Direction = ParameterDirection.Input : shipaddress1.Value = txtShipAddress1.Text.Trim : Params(6) = shipaddress1
            Dim shipaddress2 As New SqlParameter("@shipaddress2", SqlDbType.VarChar, 150) : shipaddress2.Direction = ParameterDirection.Input : shipaddress2.Value = txtShipAddress2.Text.Trim : Params(7) = shipaddress2
            Dim territorydr As New SqlParameter("@territorydr", SqlDbType.VarChar, 10) : territorydr.Direction = ParameterDirection.Input : territorydr.Value = txtTerritoryDR.Text.Trim : Params(8) = territorydr
            Dim territory As New SqlParameter("@territory", SqlDbType.VarChar, 50) : territory.Direction = ParameterDirection.Input : territory.Value = txtTerritory.Text.Trim : Params(9) = territory
            Dim provincedr As New SqlParameter("@provincedr", SqlDbType.VarChar, 10) : provincedr.Direction = ParameterDirection.Input : provincedr.Value = txtProvinceDR.Text.Trim : Params(10) = provincedr
            Dim province As New SqlParameter("@province", SqlDbType.VarChar, 50) : province.Direction = ParameterDirection.Input : province.Value = txtProvince.Text.Trim : Params(11) = province
            Dim groupdr As New SqlParameter("@groupdr", SqlDbType.VarChar, 10) : groupdr.Direction = ParameterDirection.Input : groupdr.Value = txtGroupDR.Text.Trim : Params(12) = groupdr
            Dim group As New SqlParameter("@group", SqlDbType.VarChar, 50) : group.Direction = ParameterDirection.Input : group.Value = txtGroup.Text.Trim : Params(13) = group
            Dim mrcode As New SqlParameter("@mrcode", SqlDbType.VarChar, 25) : mrcode.Direction = ParameterDirection.Input : mrcode.Value = txtMrCode.Text.Trim : Params(14) = mrcode
            Dim mrname As New SqlParameter("@mrname", SqlDbType.VarChar, 75) : mrname.Direction = ParameterDirection.Input : mrname.Value = txtMrName.Text.Trim : Params(15) = mrname
            Dim mrterrcode As New SqlParameter("@mrterrcode", SqlDbType.VarChar, 10) : mrterrcode.Direction = ParameterDirection.Input : mrterrcode.Value = txtMrTerrCode.Text.Trim : Params(16) = mrterrcode
            Dim supcode As New SqlParameter("@supcode", SqlDbType.VarChar, 25) : supcode.Direction = ParameterDirection.Input : supcode.Value = txtSupCode.Text.Trim : Params(17) = supcode
            Dim supname As New SqlParameter("@supname", SqlDbType.VarChar, 75) : supname.Direction = ParameterDirection.Input : supname.Value = txtSupName.Text.Trim : Params(18) = supname
            Dim supteamcode As New SqlParameter("@supteamcode", SqlDbType.VarChar, 10) : supteamcode.Direction = ParameterDirection.Input : supteamcode.Value = txtSupTeamCode.Text.Trim : Params(19) = supteamcode
            Dim mrdivision As New SqlParameter("@mrdivision", SqlDbType.VarChar, 30) : mrdivision.Direction = ParameterDirection.Input : mrdivision.Value = txtMrDivision.Text.Trim : Params(20) = mrdivision

            Dim commissiondatevalue As DateTime = IIf(txtCommissionDate.Text.ToString.Trim = "", "1/1/1901", DateTime.Parse(txtCommissionDate.Text))
            Dim salescycledatevalue As DateTime = IIf(txtSalesCycleDate.Text.ToString.Trim = "", "1/1/1901", DateTime.Parse(txtSalesCycleDate.Text))
            Dim commissiondate As New SqlParameter("@commissiondate", SqlDbType.DateTime, 10) : commissiondate.Direction = ParameterDirection.Input : commissiondate.Value = commissiondatevalue : Params(21) = commissiondate
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = salescycledatevalue : Params(22) = salescycledate
            Dim tsmrcode As New SqlParameter("@tsmrcode", SqlDbType.VarChar, 10) : tsmrcode.Direction = ParameterDirection.Input : tsmrcode.Value = txtTSMrCode.Text.Trim : Params(23) = tsmrcode
            Dim tsmrname As New SqlParameter("@tsmrname", SqlDbType.VarChar, 50) : tsmrname.Direction = ParameterDirection.Input : tsmrname.Value = txtTSMrName.Text.Trim : Params(24) = tsmrname
            Dim tssupcode As New SqlParameter("@tssupcode", SqlDbType.VarChar, 10) : tssupcode.Direction = ParameterDirection.Input : tssupcode.Value = txtTSSupCode.Text.Trim : Params(25) = tssupcode
            Dim tssupname As New SqlParameter("@tssupname", SqlDbType.VarChar, 50) : tssupname.Direction = ParameterDirection.Input : tssupname.Value = txtTSSupName.Text.Trim : Params(26) = tssupname
            Dim rowid As New SqlParameter("@rowid", SqlDbType.VarChar, 10) : rowid.Direction = ParameterDirection.Input : rowid.Value = txtRowID.Text.Trim : Params(27) = rowid
            Dim tsareacode As New SqlParameter("@tsareacode", SqlDbType.VarChar, 10) : tsareacode.Direction = ParameterDirection.Input : tsareacode.Value = txtTSAreaCode.Text.Trim : Params(28) = tsareacode
            Dim tsteamcode As New SqlParameter("@tsteamcode", SqlDbType.VarChar, 10) : tsteamcode.Direction = ParameterDirection.Input : tsteamcode.Value = txtTSTeamCode.Text.Trim : Params(29) = tsteamcode

            'Save IntegratedSalesHistory
            SaveIntegratedSalesHistory()
            BusinessObject.Sub_Update(ServerPath2, "Util_IntegratedSales_Transfer", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox("Error in UpdateIntegratedSales : " + ex.Message)
            retval = False
        End Try
    End Sub
    Private Sub SaveIntegratedSalesHistory()
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(0) As SqlParameter
        Dim rowid As New SqlParameter("@rowid", SqlDbType.VarChar, 10) : rowid.Direction = ParameterDirection.Input : rowid.Value = txtRowID.Text.Trim : Params(0) = rowid
        Try
            BusinessObject.Sub_Update(ServerPath2, "Util_IntegratedSalesHistory_Insert", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox("Error in SaveIntegratedSalesHistory : " + ex.Message)
        End Try
    End Sub
    Private Sub SetDestinationSearch()
        Dim row As Integer = 0 'dgvSource.CurrentRow.Index
        If row > -1 Then
            'txtCustomerNameS.Text = dgvSource.Rows(row).Cells("CustomerName").Value.ToString()
            'txtAddress1S.Text = dgvSource.Rows(row).Cells("Address1").Value.ToString()
            'txtTerritoryS.Text = dgvSource.Rows(row).Cells("Territory").Value.ToString()
            'txtProvinceS.Text = dgvSource.Rows(row).Cells("Province").Value.ToString()
            'txtItemDescS.Text = dgvSource.Rows(row).Cells("ItemDesc").Value.ToString()

            'txtMRNameS.Text = dgvSource.Rows(row).Cells("MrName").Value.ToString()
            'txtTSMRNameS.Text = dgvSource.Rows(row).Cells("TSMrName").Value.ToString()
            'txtSupNameS.Text = dgvSource.Rows(row).Cells("SupName").Value.ToString()
            'txtTSSupNameS.Text = dgvSource.Rows(row).Cells("TSSupName").Value.ToString()
            'txtCommissionDateS.Text = dgvSource.Rows(row).Cells("CommissionDate").Value.ToString()
            'txtSalesCycleDateS.Text = dgvSource.Rows(row).Cells("SalesCycleDate").Value.ToString()
            If txtCommissionDateS.Text.Trim = "" Then
                txtCommissionDateS.Text = "1/1/1901"
            End If
            If txtSalesCycleDateS.Text.Trim = "" Then
                txtSalesCycleDateS.Text = "1/1/1901"
            End If

        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ShowIntegratedSalesDestination()
    End Sub

    Private Sub ShowIntegratedSalesDestination()
        Try
            Dim commissiondatevalue As DateTime = DateTime.Parse(txtCommissionDateS.Text)
            Dim salescycledatevalue As DateTime = DateTime.Parse(txtSalesCycleDateS.Text)
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(11) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = salescycledatevalue : Params(0) = salescycledate
            Dim commissiondate As New SqlParameter("@commissiondate", SqlDbType.DateTime, 10) : commissiondate.Direction = ParameterDirection.Input : commissiondate.Value = commissiondatevalue : Params(1) = commissiondate
            Dim customername As New SqlParameter("@customername", SqlDbType.VarChar, 75) : customername.Direction = ParameterDirection.Input : customername.Value = txtCustomerNameS.Text.Trim : Params(2) = customername
            Dim itemdesc As New SqlParameter("@itemdesc", SqlDbType.VarChar, 75) : itemdesc.Direction = ParameterDirection.Input : itemdesc.Value = txtItemDescS.Text.Trim : Params(3) = itemdesc
            Dim mrname As New SqlParameter("@mrname", SqlDbType.VarChar, 75) : mrname.Direction = ParameterDirection.Input : mrname.Value = txtMRNameS.Text.Trim : Params(4) = mrname
            Dim supname As New SqlParameter("@supname", SqlDbType.VarChar, 75) : supname.Direction = ParameterDirection.Input : supname.Value = txtSupNameS.Text.Trim : Params(5) = supname
            Dim tsmrname As New SqlParameter("@tsmrname", SqlDbType.VarChar, 50) : tsmrname.Direction = ParameterDirection.Input : tsmrname.Value = txtTSMRNameS.Text.Trim : Params(6) = tsmrname
            Dim tssupname As New SqlParameter("@tssupname", SqlDbType.VarChar, 50) : tssupname.Direction = ParameterDirection.Input : tssupname.Value = txtTSSupNameS.Text.Trim : Params(7) = tssupname
            Dim address1 As New SqlParameter("@address1", SqlDbType.VarChar, 150) : address1.Direction = ParameterDirection.Input : address1.Value = txtAddress1S.Text.Trim : Params(8) = address1
            Dim province As New SqlParameter("@province", SqlDbType.VarChar, 50) : province.Direction = ParameterDirection.Input : province.Value = txtProvinceS.Text.Trim : Params(9) = province
            Dim territory As New SqlParameter("@territory", SqlDbType.VarChar, 50) : territory.Direction = ParameterDirection.Input : territory.Value = txtTerritoryS.Text.Trim : Params(10) = territory
            Dim refcode As New SqlParameter("@refcode", SqlDbType.VarChar, 10) : refcode.Direction = ParameterDirection.Input : refcode.Value = txtRefCodeS.Text.Trim : Params(11) = refcode

            Me.Cursor = Cursors.WaitCursor
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_IntegratedSales_SelectDestination", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvDestination.DataSource = RemoteDataSet.Tables("IntegratedSales")
            LogHelper.InsertLog("frmIntegratedSales.ShowIntegratedSales.Success")
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmTransferSales.ShowIntegratedSalesDestination.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomer.Click
        CopyCustomer()
    End Sub
    Private Sub CopyCustomer()
        Dim row As Integer = dgvDestination.CurrentRow.Index
        If row > -1 Then
            txtCustomerDR.Text = dgvDestination.Rows(row).Cells("CustomerDR").Value.ToString()
            txtCustomerCode.Text = dgvDestination.Rows(row).Cells("CustomerCode").Value.ToString()
            txtCustomerName.Text = dgvDestination.Rows(row).Cells("CustomerName").Value.ToString()
            txtAddress1.Text = dgvDestination.Rows(row).Cells("Address1").Value.ToString()
            txtAddress2.Text = dgvDestination.Rows(row).Cells("Address2").Value.ToString()
            txtShipTo.Text = dgvDestination.Rows(row).Cells("ShipTo").Value.ToString()
            txtShipAddress1.Text = dgvDestination.Rows(row).Cells("ShipAddress1").Value.ToString()
            txtShipAddress2.Text = dgvDestination.Rows(row).Cells("ShipAddress2").Value.ToString()
        End If
    End Sub

    Private Sub btnTerritory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTerritory.Click
        CopyTerritory()
    End Sub
    Private Sub CopyTerritory()
        Dim row As Integer = dgvDestination.CurrentRow.Index
        If row > -1 Then
            txtTerritoryDR.Text = dgvDestination.Rows(row).Cells("TerritoryDR").Value.ToString()
            txtTerritory.Text = dgvDestination.Rows(row).Cells("Territory").Value.ToString()
        End If

    End Sub

    Private Sub btnProvince_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProvince.Click
        CopyProvince()
    End Sub
    Private Sub CopyProvince()
        Dim row As Integer = dgvDestination.CurrentRow.Index
        If row > -1 Then
            txtProvinceDR.Text = dgvDestination.Rows(row).Cells("ProvinceDR").Value.ToString()
            txtProvince.Text = dgvDestination.Rows(row).Cells("Province").Value.ToString()
        End If
    End Sub

    Private Sub btnGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGroup.Click
        CopyGroup()
    End Sub
    Private Sub CopyGroup()
        Dim row As Integer = dgvDestination.CurrentRow.Index
        If row > -1 Then
            txtGroupDR.Text = dgvDestination.Rows(row).Cells("GroupDR").Value.ToString()
            txtGroup.Text = dgvDestination.Rows(row).Cells("Group").Value.ToString()
        End If
    End Sub

    Private Sub btnTSAreaCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTSAreaCode.Click
        CopyTSAreaCode()
    End Sub

    Private Sub CopyTSAreaCode()
        Dim row As Integer = dgvDestination.CurrentRow.Index
        If row > -1 Then
            txtTSAreaCode.Text = dgvDestination.Rows(row).Cells("TSAreaCode").Value.ToString()
        End If
    End Sub

    Private Sub btnTSTeamCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTSTeamCode.Click
        CopyTSTeamCode()
    End Sub

    Private Sub CopyTSTeamCode()
        Dim row As Integer = dgvDestination.CurrentRow.Index
        If row > -1 Then
            txtTSTeamCode.Text = dgvDestination.Rows(row).Cells("TSTeamCode").Value.ToString()
        End If
    End Sub

    Private Sub btnMR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMR.Click
        CopyMR()
    End Sub
    Private Sub CopyMR()
        Dim row As Integer = dgvDestination.CurrentRow.Index
        If row > -1 Then
            txtMrCode.Text = dgvDestination.Rows(row).Cells("MrCode").Value.ToString()
            txtMrName.Text = dgvDestination.Rows(row).Cells("MrName").Value.ToString()
            txtMrTerrCode.Text = dgvDestination.Rows(row).Cells("MrTerrCode").Value.ToString()
        End If
    End Sub

    Private Sub btnTSMR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTSMR.Click
        CopyTSMR()
    End Sub
    Private Sub CopyTSMR()
        Dim row As Integer = dgvDestination.CurrentRow.Index
        If row > -1 Then
            txtTSMrCode.Text = dgvDestination.Rows(row).Cells("TSMrCode").Value.ToString()
            txtTSMrName.Text = dgvDestination.Rows(row).Cells("TSMrName").Value.ToString()
        End If
    End Sub

    Private Sub btnMRDiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMRDiv.Click
        CopyMRDivision()
    End Sub
    Private Sub CopyMRDivision()
        Dim row As Integer = dgvDestination.CurrentRow.Index
        If row > -1 Then
            txtMrDivision.Text = dgvDestination.Rows(row).Cells("MrDivision").Value.ToString()
        End If
    End Sub
    Private Sub btnSup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSup.Click
        CopySup()
    End Sub
    Private Sub CopySup()
        Dim row As Integer = dgvDestination.CurrentRow.Index
        If row > -1 Then
            txtSupCode.Text = dgvDestination.Rows(row).Cells("SupCode").Value.ToString()
            txtSupName.Text = dgvDestination.Rows(row).Cells("SupName").Value.ToString()
        End If
    End Sub

    Private Sub btnTSSup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTSSup.Click
        CopyTSSup()
    End Sub
    Private Sub CopyTSSup()
        Dim row As Integer = dgvDestination.CurrentRow.Index
        If row > -1 Then
            txtTSSupCode.Text = dgvDestination.Rows(row).Cells("TSSupCode").Value.ToString()
            txtTSSupName.Text = dgvDestination.Rows(row).Cells("TSSupName").Value.ToString()
        End If
    End Sub

    Private Sub btnSupTeamCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupTeamCode.Click
        CopySupTeamCode()
    End Sub
    Private Sub CopySupTeamCode()
        Dim row As Integer = dgvDestination.CurrentRow.Index
        If row > -1 Then
            txtSupTeamCode.Text = dgvDestination.Rows(row).Cells("SupTeamCode").Value.ToString()
        End If
    End Sub

    Private Sub Label26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label26.Click

    End Sub
End Class