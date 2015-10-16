Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Public Class frmEditDataMapping
    Public ItemCode As String = ""
    Public ItemName As String = ""
    Public CustomerCode As String = ""
    Public CustomerName As String = ""

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub InitializeControls()
        txtCustomerCode.Text = CustomerCode
        txtCustomerName.Text = CustomerName
        txtItemCode.Text = ItemCode
        txtItemName.Text = ItemName
        If txtCustomerName.Text.ToUpper.Contains("ROSE PHARMACY") Then
            txtCustomerNameMap.Text = "Rose Pharmacy"
            txtCustomerNameMap2.Text = StringHelper.GetWordByIndex(CustomerName, 0)
        Else
            txtCustomerNameMap.Text = StringHelper.GetWordByIndex(CustomerName, 0)
            If txtCustomerNameMap.Text = "SSD" Or txtCustomerNameMap.Text = "MD" Then
                txtCustomerNameMap.Text = "South Star"
            End If

            txtCustomerNameMap2.Text = StringHelper.GetWordByIndex(CustomerName, 1)

            txtItemNameMap.Text = StringHelper.GetWordByIndex(ItemName, 0)
            txtItemNameMap2.Text = StringHelper.GetWordByIndex(ItemName, 1)
        End If


    End Sub

    Private Sub frmEditDataMapping_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        InitializeControls()
        ShowCustomer(txtCustomerNameMap.Text.ToString, txtCustomerNameMap2.Text.ToString)
        ShowItem(txtItemNameMap.Text.ToString, txtItemNameMap2.Text.ToString)
        SetItem()
        SetCustomer()
    End Sub

    Private Sub btnMapCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMapCustomer.Click
        Dim name As String
        Dim code As String
        Dim returnvalue As String
        name = gbCustomer.Text.ToString.Trim

        'If BarrXsel and Customer Code is Blank, use Customer Name as Customer Code
        code = txtCustomerCode.Text.ToString.Trim
        If (gbCustomer.Text = "BARRXSEL CUSTOMER" Or gbCustomer.Text = "518 CUSTOMER") And code.Trim = "" Then
            code = txtCustomerName.Text.ToString.Trim
            If code.Length >= 50 Then
                code = code.Substring(0, 49)
            End If
        End If

        returnvalue = txtCustomerCodeMap.Text.ToString.Trim
        If Not String.IsNullOrEmpty(returnvalue) Then
            If Not DataMapHelper.GetReturnCode(gbCustomer.Text.ToString, code) Then
                DataMapHelper.DataMap_Insert(name, code, returnvalue)
                MsgBox("Customer code : " + code + " is now mapped to : " + returnvalue + "!")
            Else
                MsgBox("Customer already exists in DataMap!")
            End If
        Else
            MsgBox("Please select customer code to map!")
        End If
    End Sub

    Private Sub btnMapItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMapItem.Click
        Dim name As String
        Dim code As String
        Dim returnvalue As String
        name = gbItem.Text.ToString.Trim()
        code = txtItemCode.Text.ToString.Trim()
        returnvalue = txtItemCodeMap.Text.ToString.Trim

        'If 518 and Item Code is Blank, use item Name as Item Code
        If (gbCustomer.Text = "518 CUSTOMER") And code.Trim = "" Then
            code = StringHelper.Get50Chars(txtItemName.Text.ToString.Trim())
        End If

        If Not String.IsNullOrEmpty(returnvalue) Then
            If Not DataMapHelper.GetReturnCode(gbItem.Text.ToString, code) Then
                DataMapHelper.DataMap_Insert(name, code, returnvalue)
                MsgBox("Item code : " + code + " is now mapped to : " + returnvalue + "!")
            Else
                MsgBox("Item already exists in DataMap!")
            End If
        Else
            MsgBox("Please select item code to map!")
        End If
    End Sub

    Private Sub btnSearchCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchCustomer.Click
        ShowCustomer(txtCustomerNameMap.Text.ToString, txtCustomerNameMap2.Text.ToString)
    End Sub

    Private Sub ShowCustomer(ByVal cust1 As String, ByVal cust2 As String)
        Dim RemoteDataSet As New DataSet
        RemoteDataSet.Tables.Add("Table1")
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance

            Dim Params(1) As SqlParameter
            Dim custname1 As New SqlParameter("@custname1", SqlDbType.VarChar, 80) : custname1.Direction = ParameterDirection.Input : custname1.Value = cust1 : Params(0) = custname1
            Dim custname2 As New SqlParameter("@custname2", SqlDbType.VarChar, 80) : custname2.Direction = ParameterDirection.Input : custname2.Value = cust2 : Params(1) = custname2

            BusinessObject.Sub_Show(ServerPath2, "Util_Customer_Search", CommandType.StoredProcedure, RemoteDataSet, "Table1", Params)
            dgvCustomer.DataSource = RemoteDataSet.Tables("Table1")
            LogHelper.InsertLog("frmEditDataMapping.ShowCustomer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmEditDataMapping.ShowCustomer.Error: " & ex.Message)
        End Try
    End Sub
    Private Sub ShowCustomerAddress(ByVal cust1 As String, ByVal cust2 As String, ByVal custaddress As String)
        Dim RemoteDataSet As New DataSet
        RemoteDataSet.Tables.Add("Table1")
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance

            Dim Params(2) As SqlParameter
            Dim custname1 As New SqlParameter("@custname1", SqlDbType.VarChar, 80) : custname1.Direction = ParameterDirection.Input : custname1.Value = cust1 : Params(0) = custname1
            Dim custname2 As New SqlParameter("@custname2", SqlDbType.VarChar, 80) : custname2.Direction = ParameterDirection.Input : custname2.Value = cust2 : Params(1) = custname2
            Dim custadd As New SqlParameter("@custadd", SqlDbType.VarChar, 80) : custadd.Direction = ParameterDirection.Input : custadd.Value = custaddress : Params(2) = custadd

            BusinessObject.Sub_Show(ServerPath2, "Util_Customer_Search_Address", CommandType.StoredProcedure, RemoteDataSet, "Table1", Params)
            dgvCustomer.DataSource = RemoteDataSet.Tables("Table1")
            LogHelper.InsertLog("frmEditDataMapping.ShowCustomer.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmEditDataMapping.ShowCustomer.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSearchItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchItem.Click
        ShowItem(txtItemNameMap.Text.ToString, txtItemNameMap2.Text.ToString)
    End Sub
    Private Sub ShowItem(ByVal itempar1 As String, ByVal itempar2 As String)
        Dim RemoteDataSet As New DataSet
        RemoteDataSet.Tables.Add("Table1")
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance

            Dim Params(1) As SqlParameter
            Dim itemdesc1 As New SqlParameter("@itemdesc1", SqlDbType.VarChar, 50) : itemdesc1.Direction = ParameterDirection.Input : itemdesc1.Value = itempar1 : Params(0) = itemdesc1
            Dim itemdesc2 As New SqlParameter("@itemdesc2", SqlDbType.VarChar, 50) : itemdesc2.Direction = ParameterDirection.Input : itemdesc2.Value = itempar2 : Params(1) = itemdesc2

            BusinessObject.Sub_Show(ServerPath2, "Util_Item_Search", CommandType.StoredProcedure, RemoteDataSet, "Table1", Params)
            dgvItem.DataSource = RemoteDataSet.Tables("Table1")
            LogHelper.InsertLog("frmEditDataMapping.ShowItem.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmEditDataMapping.ShowItem.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvCustomer_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCustomer.CellContentClick
        SetCustomer()
    End Sub

    Private Sub dgvCustomer_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvCustomer.MouseEnter

    End Sub

    Private Sub SetCustomer()
        Dim row As Integer = 0
        Try
            row = dgvCustomer.CurrentRow.Index
        Catch ex As Exception

        End Try

        If dgvCustomer.Rows.Count > 1 Then
            txtCustomerCodeMap.Text = dgvCustomer.Rows(row).Cells("CustCode").Value.ToString
            'just the code txtCustomerNameMap.Text = dgvCustomer.Rows(row).Cells("CustName").Value.ToString
        End If
    End Sub

    Private Sub dgvItem_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvItem.CellContentClick
        SetItem()
    End Sub

    Private Sub dgvItem_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvItem.MouseEnter

    End Sub

    Private Sub SetItem()
        Dim row As Integer = 0
        Try
            row = dgvItem.CurrentRow.Index
        Catch ex As Exception

        End Try
        If dgvItem.Rows.Count > 1 Then
            txtItemCodeMap.Text = dgvItem.Rows(row).Cells("ItemCode").Value.ToString
            'just the code txtItemNameMap.Text = dgvItem.Rows(row).Cells("ItemDesc").Value.ToString
        End If

    End Sub

    Private Sub dgvItem_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvItem.RowEnter

    End Sub

    Private Sub dgvItem_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvItem.CellClick
        SetItem()
    End Sub

    Private Sub dgvCustomer_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCustomer.CellClick
        SetCustomer()
    End Sub

    Private Sub txtCustomerNameMap_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCustomerNameMap.TextChanged
        If txtCustomerNameMap.Text.ToString.Trim.Length >= 3 Then
            ShowCustomer(txtCustomerNameMap.Text.ToString, txtCustomerNameMap2.Text.ToString)
        End If
    End Sub

    Private Sub txtCustomerNameMap2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCustomerNameMap2.TextChanged
        If txtCustomerNameMap2.Text.ToString.Trim.Length >= 3 Then
            ShowCustomer(txtCustomerNameMap.Text.ToString, txtCustomerNameMap2.Text.ToString)
        End If
    End Sub

    Private Sub txtItemNameMap_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItemNameMap.TextChanged
        If txtItemNameMap.Text.ToString.Trim.Length >= 3 Then
            ShowItem(txtItemNameMap.Text.ToString, txtItemNameMap2.Text.ToString)
        End If
    End Sub

    Private Sub txtItemNameMap2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItemNameMap2.TextChanged
        If txtItemNameMap2.Text.ToString.Trim.Length >= 3 Then
            ShowItem(txtItemNameMap.Text.ToString, txtItemNameMap2.Text.ToString)
        End If
    End Sub

    Private Sub btnUpdateMapCust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateMapCust.Click
        Dim name As String
        Dim code As String
        Dim returnvalue As String
        name = gbCustomer.Text.ToString.Trim
        code = txtCustomerCode.Text.ToString.Trim

        'If BarrXsel and Customer Code is Blank, use Customer Name as Customer Code
        If (gbCustomer.Text = "BARRXSEL CUSTOMER" Or gbCustomer.Text = "518 CUSTOMER") And code.Trim = "" Then
            code = txtCustomerName.Text.ToString.Trim
            If code.Length >= 50 Then
                code = code.Substring(0, 49)
            End If
        End If

        returnvalue = txtCustomerCodeMap.Text.ToString.Trim
        If Not String.IsNullOrEmpty(returnvalue) Then
            If DataMapHelper.GetReturnCode(gbCustomer.Text.ToString.Trim, txtCustomerCode.Text.ToString.Trim) Then
                'Delete Datamap for Customer
                DataMapHelper.DataMap_Delete(gbCustomer.Text.ToString.Trim, txtCustomerCode.Text.ToString.Trim)
            End If
            DataMapHelper.DataMap_Insert(name, code, returnvalue)
            MsgBox("Customer code : " + code + " is now mapped to : " + returnvalue + "!")
        Else
            MsgBox("Please select customer code to map!")
        End If
    End Sub

    Private Sub btnUpdateMapItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateMapItem.Click
        Dim name As String
        Dim code As String
        Dim returnvalue As String
        name = gbItem.Text.ToString.Trim
        code = txtItemCode.Text.ToString.Trim
        returnvalue = txtItemCodeMap.Text.ToString.Trim
        If Not String.IsNullOrEmpty(returnvalue) Then
            If DataMapHelper.GetReturnCode(gbItem.Text.ToString, txtItemCode.Text.ToString) Then
                'Delete Datamap for iTEM
                DataMapHelper.DataMap_Delete(gbItem.Text.ToString, txtItemCode.Text.ToString)
            End If
            DataMapHelper.DataMap_Insert(name, code, returnvalue)
            MsgBox("Item code : " + code + " is now mapped to : " + returnvalue + "!")
        Else
            MsgBox("Please select item code to map!")
        End If
    End Sub

    Private Sub txtCustomerAddressMap_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerAddressMap.TextChanged
        If txtCustomerAddressMap.Text.ToString.Trim.Length >= 3 Then
            ShowCustomerAddress(txtCustomerNameMap.Text.ToString, txtCustomerNameMap2.Text.ToString, txtCustomerAddressMap.Text.ToString.Trim)
        End If
    End Sub
End Class