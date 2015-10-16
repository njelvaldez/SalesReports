Imports System.Data.SqlClient
Public Class frmIntegratedSales
    Private RemoteDataSet As New DataSet
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub InitialDate()
        Dim currentdate As String
        Dim defdate As String = "1/1/1901"
        currentdate = DateTime.Now.Month.ToString.Trim + "/1/" + DateTime.Now.Year.ToString.Trim
        dtpCommissionDate1.Text = defdate
        dtpCommissionDate2.Text = defdate
        dtpSalesCycleDate1.Text = defdate  'currentdate
        dtpSalesCycleDate2.Text = defdate
        dtpCMRefDate.Text = defdate
        dtpRefDate.Text = defdate
        dtpSODate.Text = defdate
    End Sub

    Private Sub frmIntegratedSales_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RemoteDataSet.Tables.Add("IntegratedSales")
        ClearTextBox()
        InitialDate()
    End Sub

    Private Sub ShowIntegratedSales()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(58) As SqlParameter
            Dim commissiondatevalue As DateTime = DateTime.Parse(dtpCommissionDate1.Text)
            Dim salescycledatevalue As DateTime = DateTime.Parse(dtpSalesCycleDate1.Text)

            Dim commissiondatevalue2 As DateTime = DateTime.Parse(dtpCommissionDate2.Text)
            Dim salescycledatevalue2 As DateTime = DateTime.Parse(dtpSalesCycleDate2.Text)

            Dim refdateval As DateTime = DateTime.Parse(dtpRefDate.Text)
            Dim cmrefdateval As DateTime = DateTime.Parse(dtpCMRefDate.Text)

            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = salescycledatevalue : Params(0) = salescycledate
            Dim commissiondate As New SqlParameter("@commissiondate", SqlDbType.DateTime, 10) : commissiondate.Direction = ParameterDirection.Input : commissiondate.Value = commissiondatevalue : Params(1) = commissiondate

            Dim customercode As New SqlParameter("@customercode", SqlDbType.VarChar, 10) : customercode.Direction = ParameterDirection.Input : customercode.Value = txtCustCode.Text.Trim : Params(2) = customercode
            Dim customername1 As New SqlParameter("@customername1", SqlDbType.VarChar, 75) : customername1.Direction = ParameterDirection.Input : customername1.Value = txtCustName1.Text.Trim : Params(3) = customername1
            Dim customername2 As New SqlParameter("@customername2", SqlDbType.VarChar, 75) : customername2.Direction = ParameterDirection.Input : customername2.Value = txtCustName2.Text.Trim : Params(4) = customername2

            Dim distributorcode As New SqlParameter("@distributorcode", SqlDbType.VarChar, 5) : distributorcode.Direction = ParameterDirection.Input : distributorcode.Value = txtDistCode.Text.Trim : Params(5) = distributorcode
            Dim distributordesc1 As New SqlParameter("@distributordesc1", SqlDbType.VarChar, 75) : distributordesc1.Direction = ParameterDirection.Input : distributordesc1.Value = txtDistName1.Text.Trim : Params(6) = distributordesc1
            Dim distributordesc2 As New SqlParameter("@distributordesc2", SqlDbType.VarChar, 75) : distributordesc2.Direction = ParameterDirection.Input : distributordesc2.Value = txtDistName2.Text.Trim : Params(7) = distributordesc2

            Dim divisioncode As New SqlParameter("@divisioncode", SqlDbType.VarChar, 10) : divisioncode.Direction = ParameterDirection.Input : divisioncode.Value = txtDivCode.Text.Trim : Params(8) = divisioncode
            Dim divisiondesc1 As New SqlParameter("@divisiondesc1", SqlDbType.VarChar, 50) : divisiondesc1.Direction = ParameterDirection.Input : divisiondesc1.Value = txtDivName1.Text.Trim : Params(9) = divisiondesc1
            Dim divisiondesc2 As New SqlParameter("@divisiondesc2", SqlDbType.VarChar, 50) : divisiondesc2.Direction = ParameterDirection.Input : divisiondesc2.Value = txtDivName2.Text.Trim : Params(10) = divisiondesc2

            Dim groupdr As New SqlParameter("@groupdr", SqlDbType.VarChar, 10) : groupdr.Direction = ParameterDirection.Input : groupdr.Value = txtGroupDr.Text.Trim : Params(11) = groupdr
            Dim group As New SqlParameter("@group", SqlDbType.VarChar, 50) : group.Direction = ParameterDirection.Input : group.Value = txtGroup.Text : Params(12) = group

            Dim itemcode As New SqlParameter("@itemcode", SqlDbType.VarChar, 10) : itemcode.Direction = ParameterDirection.Input : itemcode.Value = txtItemCode.Text.Trim : Params(13) = itemcode
            Dim itemdesc1 As New SqlParameter("@itemdesc1", SqlDbType.VarChar, 75) : itemdesc1.Direction = ParameterDirection.Input : itemdesc1.Value = txtItemDesc1.Text.Trim : Params(14) = itemdesc1
            Dim itemdesc2 As New SqlParameter("@itemdesc2", SqlDbType.VarChar, 75) : itemdesc2.Direction = ParameterDirection.Input : itemdesc2.Value = txtItemDesc2.Text.Trim : Params(15) = itemdesc2

            Dim kasgovcode As New SqlParameter("@kasgovcode", SqlDbType.VarChar, 25) : kasgovcode.Direction = ParameterDirection.Input : kasgovcode.Value = txtKASGOVCode.Text.Trim : Params(16) = kasgovcode
            Dim kasgovname1 As New SqlParameter("@kasgovname1", SqlDbType.VarChar, 75) : kasgovname1.Direction = ParameterDirection.Input : kasgovname1.Value = txtKASGOVName1.Text.Trim : Params(17) = kasgovname1
            Dim kasgovname2 As New SqlParameter("@kasgovname2", SqlDbType.VarChar, 75) : kasgovname2.Direction = ParameterDirection.Input : kasgovname2.Value = txtKASGOVName2.Text.Trim : Params(18) = kasgovname2

            Dim pmcode As New SqlParameter("@pmcode", SqlDbType.VarChar, 10) : pmcode.Direction = ParameterDirection.Input : pmcode.Value = txtPMCode.Text : Params(19) = pmcode
            Dim pmname1 As New SqlParameter("@pmname1", SqlDbType.VarChar, 50) : pmname1.Direction = ParameterDirection.Input : pmname1.Value = txtPMName1.Text.Trim : Params(20) = pmname1
            Dim pmname2 As New SqlParameter("@pmname2", SqlDbType.VarChar, 50) : pmname2.Direction = ParameterDirection.Input : pmname2.Value = txtPMName2.Text.Trim : Params(21) = pmname2

            Dim principalcode As New SqlParameter("@principalcode", SqlDbType.VarChar, 10) : principalcode.Direction = ParameterDirection.Input : principalcode.Value = txtPrincipalCode.Text.Trim : Params(22) = principalcode
            Dim principaldesc1 As New SqlParameter("@principaldesc1", SqlDbType.VarChar, 75) : principaldesc1.Direction = ParameterDirection.Input : principaldesc1.Value = txtPrincipalDesc1.Text.Trim : Params(23) = principaldesc1
            Dim principaldesc2 As New SqlParameter("@principaldesc2", SqlDbType.VarChar, 75) : principaldesc2.Direction = ParameterDirection.Input : principaldesc2.Value = txtPrincipalDesc2.Text.Trim : Params(24) = principaldesc2

            Dim mrcode As New SqlParameter("@mrcode", SqlDbType.VarChar, 25) : mrcode.Direction = ParameterDirection.Input : mrcode.Value = txtMRCode.Text.Trim : Params(25) = mrcode
            Dim mrname1 As New SqlParameter("@mrname1", SqlDbType.VarChar, 75) : mrname1.Direction = ParameterDirection.Input : mrname1.Value = txtMRName1.Text.Trim : Params(26) = mrname1
            Dim mrname2 As New SqlParameter("@mrname2", SqlDbType.VarChar, 75) : mrname2.Direction = ParameterDirection.Input : mrname2.Value = txtMRName2.Text.Trim : Params(27) = mrname2

            Dim supcode As New SqlParameter("@supcode", SqlDbType.VarChar, 25) : supcode.Direction = ParameterDirection.Input : supcode.Value = txtSupCode.Text : Params(28) = supcode
            Dim supname1 As New SqlParameter("@supname1", SqlDbType.VarChar, 75) : supname1.Direction = ParameterDirection.Input : supname1.Value = txtSupName1.Text.Trim : Params(29) = supname1
            Dim supname2 As New SqlParameter("@supname2", SqlDbType.VarChar, 75) : supname2.Direction = ParameterDirection.Input : supname2.Value = txtSupName2.Text.Trim : Params(30) = supname2

            Dim nsmcode As New SqlParameter("@nsmcode", SqlDbType.VarChar, 25) : nsmcode.Direction = ParameterDirection.Input : nsmcode.Value = txtNSMCode.Text.Trim : Params(31) = nsmcode
            Dim nsmname1 As New SqlParameter("@nsmname1", SqlDbType.VarChar, 75) : nsmname1.Direction = ParameterDirection.Input : nsmname1.Value = txtNSMName1.Text.Trim : Params(32) = nsmname1
            Dim nsmname2 As New SqlParameter("@nsmname2", SqlDbType.VarChar, 75) : nsmname2.Direction = ParameterDirection.Input : nsmname2.Value = txtNSMName2.Text.Trim : Params(33) = nsmname2

            Dim tsmrcode As New SqlParameter("@tsmrcode", SqlDbType.VarChar, 10) : tsmrcode.Direction = ParameterDirection.Input : tsmrcode.Value = txtTSMRCode.Text.Trim : Params(34) = tsmrcode
            Dim tsmrname1 As New SqlParameter("@tsmrname1", SqlDbType.VarChar, 50) : tsmrname1.Direction = ParameterDirection.Input : tsmrname1.Value = txtTSMRName1.Text.Trim : Params(35) = tsmrname1
            Dim tsmrname2 As New SqlParameter("@tsmrname2", SqlDbType.VarChar, 50) : tsmrname2.Direction = ParameterDirection.Input : tsmrname2.Value = txtTSMRName2.Text.Trim : Params(36) = tsmrname2

            Dim tssupcode As New SqlParameter("@tssupcode", SqlDbType.VarChar, 10) : tssupcode.Direction = ParameterDirection.Input : tssupcode.Value = txtTSSupCode.Text.Trim : Params(37) = tssupcode
            Dim tssupname1 As New SqlParameter("@tssupname1", SqlDbType.VarChar, 50) : tssupname1.Direction = ParameterDirection.Input : tssupname1.Value = txtTSSupName1.Text.Trim : Params(38) = tssupname1
            Dim tssupname2 As New SqlParameter("@tssupname2", SqlDbType.VarChar, 50) : tssupname2.Direction = ParameterDirection.Input : tssupname2.Value = txtTSSupName2.Text.Trim : Params(39) = tssupname2

            Dim address1 As New SqlParameter("@address1", SqlDbType.VarChar, 150) : address1.Direction = ParameterDirection.Input : address1.Value = txtAddress1.Text.Trim : Params(40) = address1
            Dim address2 As New SqlParameter("@address2", SqlDbType.VarChar, 150) : address2.Direction = ParameterDirection.Input : address2.Value = txtAddress2.Text.Trim : Params(41) = address2
            Dim shipaddress1 As New SqlParameter("@shipaddress1", SqlDbType.VarChar, 150) : shipaddress1.Direction = ParameterDirection.Input : shipaddress1.Value = txtShipAddress1.Text.Trim : Params(42) = shipaddress1
            Dim shipaddress2 As New SqlParameter("@shipaddress2", SqlDbType.VarChar, 150) : shipaddress2.Direction = ParameterDirection.Input : shipaddress2.Value = txtShipAddress2.Text.Trim : Params(43) = shipaddress2
            Dim provincedr As New SqlParameter("@provincedr", SqlDbType.VarChar, 18) : provincedr.Direction = ParameterDirection.Input : provincedr.Value = txtProvinceDR.Text.Trim : Params(44) = provincedr
            Dim province As New SqlParameter("@province", SqlDbType.VarChar, 50) : province.Direction = ParameterDirection.Input : province.Value = txtProvince.Text.Trim : Params(45) = province
            Dim territorydr As New SqlParameter("@territorydr", SqlDbType.VarChar, 18) : territorydr.Direction = ParameterDirection.Input : territorydr.Value = txtTerritoryDR.Text.Trim : Params(46) = territorydr
            Dim territory As New SqlParameter("@territory", SqlDbType.VarChar, 50) : territory.Direction = ParameterDirection.Input : territory.Value = txtTerritory.Text.Trim : Params(47) = territory
            Dim cmrefdate As New SqlParameter("@cmrefdate", SqlDbType.DateTime, 10) : cmrefdate.Direction = ParameterDirection.Input : cmrefdate.Value = cmrefdateval : Params(48) = cmrefdate
            Dim cmrefinvoice As New SqlParameter("@cmrefinvoice", SqlDbType.VarChar, 10) : cmrefinvoice.Direction = ParameterDirection.Input : cmrefinvoice.Value = txtCMRefInvoice.Text.Trim : Params(49) = cmrefinvoice
            Dim rowid As New SqlParameter("@rowid", SqlDbType.VarChar, 10) : rowid.Direction = ParameterDirection.Input : rowid.Value = txtRowID.Text : Params(50) = rowid
            Dim company As New SqlParameter("@company", SqlDbType.VarChar, 50) : company.Direction = ParameterDirection.Input : company.Value = txtCompany.Text.Trim : Params(51) = company
            Dim refcode As New SqlParameter("@refcode", SqlDbType.VarChar, 10) : refcode.Direction = ParameterDirection.Input : refcode.Value = txtRefCode.Text.Trim : Params(52) = refcode
            Dim refdate As New SqlParameter("@refdate", SqlDbType.DateTime, 10) : refdate.Direction = ParameterDirection.Input : refdate.Value = refdateval : Params(53) = refdate
            Dim maximumrows As New SqlParameter("@maximumrows", SqlDbType.Int, 10) : maximumrows.Direction = ParameterDirection.Input : maximumrows.Value = Integer.Parse(NumericUpDown1.Value.ToString) : Params(54) = maximumrows

            Dim salescycledate2 As New SqlParameter("@salescycledate2", SqlDbType.DateTime, 10) : salescycledate2.Direction = ParameterDirection.Input : salescycledate2.Value = salescycledatevalue2 : Params(55) = salescycledate2
            Dim commissiondate2 As New SqlParameter("@commissiondate2", SqlDbType.DateTime, 10) : commissiondate2.Direction = ParameterDirection.Input : commissiondate2.Value = commissiondatevalue2 : Params(56) = commissiondate2
            Dim qtysold As New SqlParameter("@qtysold", SqlDbType.Money, 10) : qtysold.Direction = ParameterDirection.Input : qtysold.Value = Convert.ToInt32(txtQtySold.Text) : Params(57) = qtysold
            Dim amtsold As New SqlParameter("@amtsold", SqlDbType.Money, 10) : amtsold.Direction = ParameterDirection.Input : amtsold.Value = Convert.ToInt32(txtAmtSold.Text) : Params(58) = amtsold

            Me.Cursor = Cursors.WaitCursor
            RefreshTable()
            BusinessObject.Sub_Show(ServerPath2, "Util_IntegratedSales_Select", CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params)
            dgvSales.DataSource = RemoteDataSet.Tables("IntegratedSales")
            LogHelper.InsertLog("frmIntegratedSales.ShowIntegratedSales.Success")
            Me.Cursor = Cursors.Default
            gbResults.Text = "No of records found : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmIntegratedSales.ShowIntegratedSales.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub RefreshTable()
        RemoteDataSet.Tables.Remove("IntegratedSales")
        RemoteDataSet.Tables.Add("IntegratedSales")
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ShowIntegratedSales()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim nrowid As Integer = 0
        Dim myLoadedForm As New frmTransferSales
        Dim row As Integer = dgvSales.CurrentRow.Index
        If row > -1 Then
            myLoadedForm.txtRowID.Text = dgvSales.Rows(row).Cells("ROWID").Value.ToString
            myLoadedForm.Show()
        Else
            MsgBox("Please select record to transfer!")
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ClearTextBox()
        InitialDate()
    End Sub
    Private Sub ClearTextBox()
        txtAddress1.Text = ""
        txtAddress2.Text = ""
        txtCMRefInvoice.Text = ""
        txtCompany.Text = ""
        txtCustCode.Text = ""
        txtCustName1.Text = ""
        txtCustName2.Text = ""
        txtDistCode.Text = ""
        txtDistName1.Text = ""
        txtDistName2.Text = ""
        txtDivCode.Text = ""
        txtDivName1.Text = ""
        txtDivName2.Text = ""
        txtGroup.Text = ""
        txtGroupDr.Text = ""
        txtItemCode.Text = ""
        txtItemDesc1.Text = ""
        txtItemDesc2.Text = ""
        txtKASGOVCode.Text = ""
        txtKASGOVName1.Text = ""
        txtKASGOVName2.Text = ""
        txtMRCode.Text = ""
        txtMRName1.Text = ""
        txtMRName2.Text = ""
        txtNSMCode.Text = ""
        txtNSMName1.Text = ""
        txtNSMName2.Text = ""
        txtTerritory.Text = ""
        txtTerritoryDR.Text = ""
        txtTSMRCode.Text = ""
        txtTSMRName1.Text = ""
        txtTSMRName2.Text = ""
        txtTSSupCode.Text = ""
        txtTSSupName1.Text = ""
        txtTSSupName2.Text = ""
        txtRefCode.Text = ""
    End Sub

    Private Sub btnTransferSalesToSP_Click(sender As Object, e As EventArgs) Handles btnTransferSalesToSP.Click
        Dim nrowid As Integer = 0
        Dim myLoadedForm As New frmTransferSalesToSP
        Dim dt As New DataTable
        dt = (DirectCast(dgvSales.DataSource, DataTable))
        If dt Is Nothing Then
            MsgBox("Please select record to transfer!")
        Else
            If dt.Rows.Count > 0 Then
                myLoadedForm.dgvSalesToTransfer.DataSource = dt
                myLoadedForm.Text = "Number of records to Transfer to SP : " + dt.Rows.Count.ToString
                myLoadedForm.InitializeSpecialistCombo()
                myLoadedForm.Show()
            Else
                MsgBox("Please select record to transfer!")
            End If
        End If
    End Sub

    Private Sub btnSplit_Click(sender As Object, e As EventArgs) Handles btnSplit.Click
        Dim nrowid As Integer = 0
        Dim myLoadedForm As New frmSplitSalesTransaction
        Dim dt As New DataTable
        dt = (DirectCast(dgvSales.DataSource, DataTable))
        If dt Is Nothing Then
            MsgBox("Please select record to transfer!")
        Else
            If dt.Rows.Count > 0 Then
                myLoadedForm.dgvSource.DataSource = dt
                myLoadedForm.Text = "Split Sales Transaction number of record : " + dt.Rows.Count.ToString
                myLoadedForm.Show()
            Else
                MsgBox("Please select record to split!")
            End If
        End If
    End Sub

    Private Sub btnItemSalesReport_Click(sender As Object, e As EventArgs) Handles btnItemSalesReport.Click
        Dim nrowid As Integer = 0
        Dim myLoadedForm As New frmItemSalesReportStockTransfer
        Dim dt As New DataTable
        dt = (DirectCast(dgvSales.DataSource, DataTable))
        If dt Is Nothing Then
            MsgBox("Please select record!")
        Else
            If dt.Rows.Count > 0 Then
                myLoadedForm.dgvSales.DataSource = dt
                myLoadedForm.gbSales.Text = "Item Sales number of records : " + dt.Rows.Count.ToString
                myLoadedForm.Show()
            Else
                MsgBox("Please select record!")
            End If
        End If
    End Sub

    Private Sub btnTransferTM_Click(sender As Object, e As EventArgs) Handles btnTransferTM.Click
        Dim nrowid As Integer = 0
        Dim myLoadedForm As New frmTransferSalesToTM
        Dim dt As New DataTable
        dt = (DirectCast(dgvSales.DataSource, DataTable))
        If dt Is Nothing Then
            MsgBox("Please select record to transfer!")
        Else
            If dt.Rows.Count > 0 Then
                myLoadedForm.dgvSalesToTransfer.DataSource = dt
                myLoadedForm.Text = "Number of records to Transfer to TM : " + dt.Rows.Count.ToString
                myLoadedForm.InitializeSpecialistCombo()
                myLoadedForm.Show()
            Else
                MsgBox("Please select record to transfer!")
            End If
        End If
    End Sub

    Private Sub btnUncredit_Click(sender As Object, e As EventArgs) Handles btnUncredit.Click
        Dim nrowid As Integer = 0
        Dim myLoadedForm As New frmUnCredit
        Dim dt As New DataTable
        dt = (DirectCast(dgvSales.DataSource, DataTable))
        If dt Is Nothing Then
            MsgBox("Please select record to un-credit sales!")
        Else
            If dt.Rows.Count > 0 Then
                myLoadedForm.dgvSalesToTransfer.DataSource = dt
                myLoadedForm.Text = "Number of records to Un-Credit Sales: " + dt.Rows.Count.ToString
                myLoadedForm.Show()
            Else
                MsgBox("Please select record to uncredit sales!")
            End If
        End If
    End Sub

    Private Sub btnTransferTSSP_Click(sender As Object, e As EventArgs) Handles btnTransferTSSP.Click
        Dim nrowid As Integer = 0
        Dim myLoadedForm As New frmTransferToTSSP
        Dim dt As New DataTable
        dt = (DirectCast(dgvSales.DataSource, DataTable))
        If dt Is Nothing Then
            MsgBox("Please select record to transfer!")
        Else
            If dt.Rows.Count > 0 Then
                myLoadedForm.dgvSalesToTransfer.DataSource = dt
                myLoadedForm.Text = "Number of records to Transfer to TS SP : " + dt.Rows.Count.ToString
                myLoadedForm.InitializeSpecialistCombo()
                myLoadedForm.Show()
            Else
                MsgBox("Please select record to transfer!")
            End If
        End If
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        ExportIntegratedSales(dgvSales)
    End Sub
End Class