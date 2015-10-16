Imports System.Data.SqlClient

Module SSDCustomer
    Public Function GetCustomerAddress(ByVal customercode As String) As String
        Dim retval As String = ""
        Dim RemoteDataSet As New DataSet
        Try
            RemoteDataSet.Tables.Add("Table1")
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim storecode As New SqlParameter("@storecode", SqlDbType.VarChar, 10) : storecode.Direction = ParameterDirection.Input : storecode.Value = customercode : Params(0) = storecode
            BusinessObject.Sub_Show(ServerPath2, "Util_SSDStore_Adress", CommandType.StoredProcedure, RemoteDataSet, "Table1", Params)
            If RemoteDataSet.Tables(0).Rows.Count > 0 Then
                retval = RemoteDataSet.Tables(0).Rows(0).Item("Address").ToString()
            End If
        Catch ex As Exception
            MsgBox("Error in GetCustomerCode : " & ex.Message)
        End Try
        Return retval
    End Function
End Module

