Imports System.Data.SqlClient
Imports Microsoft
Imports Microsoft.Office.Interop
Imports System.Configuration
Imports System.Globalization
Imports System.Runtime.InteropServices
Public Class frmLookUp
    Private RemoteDataSet As New DataSet
    Private Shared m_lstitem As ListBox
    Public lookupspname As String = "Util_Item_List"
    Public lookupcaption As String = "Look Up"
    Public Shared Property ItemLookUpForm() As ListBox
        Get
            Return m_lstitem
        End Get
        Set(ByVal Value As ListBox)
            m_lstitem = Value
        End Set
    End Property
    Private Sub ShowGrid()
        Try
            If RemoteDataSet.Tables("IntegratedSales").Rows.Count > 0 Then RemoteDataSet.Tables("IntegratedSales").Clear()
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance

            Dim Params0(0) As SqlParameter
            Dim searchstring As New SqlParameter("@searchstring", SqlDbType.VarChar, 50) : searchstring.Direction = ParameterDirection.Input : searchstring.Value = txtItemDescription.Text.ToString.Trim() : Params0(0) = searchstring
            BusinessObject.Sub_Show(ServerPath2, lookupspname, CommandType.StoredProcedure, RemoteDataSet, "IntegratedSales", Params0)
            dgvLookup.DataSource = RemoteDataSet.Tables("IntegratedSales")
            gb1.Text = "Total no of records : " + RemoteDataSet.Tables("IntegratedSales").Rows.Count.ToString()
            LogHelper.InsertLog("frmItemLookUp.ShowInvoice.Success")
        Catch ex As Exception
            MsgBox(ex.Message)
            LogHelper.InsertLog("frmItemLookUp.ShowInvoice.Error: " & ex.Message)
        End Try
    End Sub

    Private Sub frmItemLookUp_Load(sender As Object, e As EventArgs) Handles Me.Load
        RemoteDataSet.Tables.Add("IntegratedSales")
        Me.Text = lookupcaption
    End Sub

    Private Sub txtItemDescription_TextChanged(sender As Object, e As EventArgs) Handles txtItemDescription.TextChanged
        Dim itemdesclen As Integer = txtItemDescription.Text.ToString.Trim().Length
        If itemdesclen >= 3 Then
            ShowGrid()
        End If
    End Sub

    Private Sub btnAddList_Click(sender As Object, e As EventArgs) Handles btnAddList.Click
        Try
            Dim nrowid As Integer = 0
            Dim row As Integer = dgvLookup.CurrentRow.Index
            If row > -1 Then
                Dim itemdesc As String
                itemdesc = dgvLookup.Rows(row).Cells("CODE").Value.ToString + ":" + dgvLookup.Rows(row).Cells("DESCRIPTION").Value.ToString
                m_lstitem.Items.Add(itemdesc)
            Else
                MsgBox("Please select item to add in item list")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnAddAll_Click(sender As Object, e As EventArgs) Handles btnAddAll.Click
        Dim dt As New DataTable
        Dim itemdesc As String = ""
        dt = (DirectCast(dgvLookup.DataSource, DataTable))
        Try
            For Each drow As DataRow In dt.Rows
                itemdesc = drow("CODE").ToString() + ":" + drow("DESCRIPTION").ToString()
                m_lstitem.Items.Add(itemdesc)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class