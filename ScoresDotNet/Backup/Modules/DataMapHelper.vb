Imports System.Data.SqlClient
Module DataMapHelper
    Public Function DataMap_Insert(ByVal name As String, ByVal code As String, ByVal returnvalue As String) As Boolean
        Dim retval As Boolean = True
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(2) As SqlParameter
            Dim SearchName As New SqlParameter("@SearchName", SqlDbType.VarChar, 50) : SearchName.Direction = ParameterDirection.Input : SearchName.Value = name : Params(0) = SearchName
            Dim SearchCode As New SqlParameter("@SearchCode", SqlDbType.VarChar, 50) : SearchCode.Direction = ParameterDirection.Input : SearchCode.Value = code : Params(1) = SearchCode
            Dim ReturnCode As New SqlParameter("@ReturnCode", SqlDbType.VarChar, 50) : ReturnCode.Direction = ParameterDirection.Input : ReturnCode.Value = returnvalue : Params(2) = ReturnCode
            BusinessObject.Sub_Insert(ServerPath2, "Util_DataMap_Insert", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            retval = False
        End Try
        Return retval
    End Function
    Public Function GetReturnCode(ByVal name As String, ByVal itemcode As String) As Boolean
        Dim retval As Boolean = True
        Try
            Dim RemoteDataSet As New DataSet
            RemoteDataSet.Tables.Add("Table1")
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(1) As SqlParameter
            Dim SearchName As New SqlParameter("@SearchName", SqlDbType.VarChar, 50) : SearchName.Direction = ParameterDirection.Input : SearchName.Value = name : Params(0) = SearchName
            Dim SearchCode As New SqlParameter("@SearchCode", SqlDbType.VarChar, 50) : SearchCode.Direction = ParameterDirection.Input : SearchCode.Value = itemcode : Params(1) = SearchCode

            BusinessObject.Sub_Show(ServerPath2, "Util_DataMap_Select", CommandType.StoredProcedure, RemoteDataSet, "Table1", Params)
            If Not RemoteDataSet.Tables("Table1").Rows.Count > 0 Then
                retval = False
            End If

        Catch ex As Exception

        End Try
        Return retval

    End Function
    Public Function DataMap_Delete(ByVal name As String, ByVal code As String) As Boolean
        Dim retval As Boolean = True
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(1) As SqlParameter
            Dim SearchName As New SqlParameter("@SearchName", SqlDbType.VarChar, 50) : SearchName.Direction = ParameterDirection.Input : SearchName.Value = name : Params(0) = SearchName
            Dim SearchCode As New SqlParameter("@SearchCode", SqlDbType.VarChar, 50) : SearchCode.Direction = ParameterDirection.Input : SearchCode.Value = code : Params(1) = SearchCode
            BusinessObject.Sub_Delete(ServerPath2, "Util_DataMap_Delete", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            retval = False
        End Try
        Return retval
    End Function
End Module
