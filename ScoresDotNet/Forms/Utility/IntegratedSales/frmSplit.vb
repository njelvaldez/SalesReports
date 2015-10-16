Imports System.Data.SqlClient
Public Class frmSplitSalesTransaction

    Private Sub btnSplitSalesTransaction_Click(sender As Object, e As EventArgs) Handles btnSplitSalesTransaction.Click
        Dim result As Integer = MessageBox.Show("Are you sure , you want split sales transaction?", "Integrated Sales", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Yes Then
            If ValidEntries() Then
                SplitSalesTransaction()
            Else
                MsgBox("Please review and correct entries!")
            End If
        End If
    End Sub

    Private Sub dgvSource_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSource.CellClick
        Dim row As Integer = dgvSource.CurrentRow.Index
        If row > -1 Then
            txtrowid.Text = dgvSource.Rows(row).Cells("rowid").Value.ToString()

            txtquantity.Text = dgvSource.Rows(row).Cells("qtysold").Value.ToString()
            txtquantity1.Text = "0"
            txtquantity2.Text = "0"

            txtamount.Text = dgvSource.Rows(row).Cells("amountsold").Value.ToString()
            txtamount1.Text = "0"
            txtamount2.Text = "0"
            txtunitprice.Text = dgvSource.Rows(row).Cells("unitprice").Value.ToString()
        End If
    End Sub

    Private Function ValidEntries() As Boolean
        Dim retval As Boolean = True
        If (String.IsNullOrEmpty(txtrowid.Text.ToString()) Or String.IsNullOrEmpty(txtquantity.Text.ToString()) Or _
            String.IsNullOrEmpty(txtquantity1.Text.ToString()) Or String.IsNullOrEmpty(txtquantity2.Text.ToString()) Or _
            String.IsNullOrEmpty(txtamount.Text.ToString()) Or String.IsNullOrEmpty(txtamount1.Text.ToString()) Or _
            String.IsNullOrEmpty(txtamount2.Text.ToString())) Then
            retval = False
        Else
            'check for data integrity
            'quantity = quantity1 + quantity2
            'amount = amount1 + amount2
            Dim origquantity As Integer = 0
            Dim quantity1n2 As Integer = 0
            Dim origamount As Integer = 0
            Dim amount1n2 As Integer = 0
            origquantity = Convert.ToDouble(txtquantity.Text.ToString())
            quantity1n2 = Convert.ToDouble(txtquantity1.Text.ToString()) + Convert.ToDouble(txtquantity2.Text.ToString())

            origamount = Convert.ToDouble(txtamount.Text.ToString())
            amount1n2 = Convert.ToDouble(txtamount1.Text.ToString()) + Convert.ToDouble(txtamount2.Text.ToString())
            If origamount = amount1n2 And origquantity = quantity1n2 Then
                retval = True
            Else
                retval = False
            End If
        End If
        Return retval
    End Function

    Private Sub SplitSalesTransaction()
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(4) As SqlParameter
            Dim rowid As New SqlParameter("@rowid", SqlDbType.VarChar, 10) : rowid.Direction = ParameterDirection.Input : rowid.Value = txtrowid.Text.ToString().Trim : Params(0) = rowid
            Dim quantity1 As New SqlParameter("@quantity1", SqlDbType.Money, 10) : quantity1.Direction = ParameterDirection.Input : quantity1.Value = txtquantity1.Text.ToString().Trim : Params(1) = quantity1
            Dim quantity2 As New SqlParameter("@quantity2", SqlDbType.Money, 10) : quantity2.Direction = ParameterDirection.Input : quantity2.Value = txtquantity2.Text.ToString().Trim : Params(2) = quantity2
            Dim amount1 As New SqlParameter("@amount1", SqlDbType.Money, 10) : amount1.Direction = ParameterDirection.Input : amount1.Value = txtamount1.Text.ToString().Trim : Params(3) = amount1
            Dim amount2 As New SqlParameter("@amount2", SqlDbType.Money, 10) : amount2.Direction = ParameterDirection.Input : amount2.Value = txtamount2.Text.ToString().Trim : Params(4) = amount2
            SaveIntegratedSalesHistory(rowid.Value.ToString())
            BusinessObject.Sub_Update(ServerPath2, "Util_IntegratedSales_SplitSalesTransaction", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox("Error in SplitSalesTransaction : " + ex.Message)
        End Try
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

    Private Sub txtquantity1_TextChanged(sender As Object, e As EventArgs) Handles txtquantity1.TextChanged
        Dim qty1 As Double = 0
        Dim unitprice As Double = 0
        Dim amount1 As Double = 0
        Try
            unitprice = Convert.ToDouble(txtunitprice.Text.ToString())
            qty1 = Convert.ToDouble(txtquantity1.Text.ToString())
            amount1 = unitprice * qty1
            txtamount1.Text = amount1.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtquantity2_TextChanged(sender As Object, e As EventArgs) Handles txtquantity2.TextChanged
        Dim qty2 As Double = 0
        Dim unitprice As Double = 0
        Dim amount2 As Double = 0
        Try
            unitprice = Convert.ToDouble(txtunitprice.Text.ToString())
            qty2 = Convert.ToDouble(txtquantity2.Text.ToString())
            amount2 = unitprice * qty2
            txtamount2.Text = amount2.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
End Class