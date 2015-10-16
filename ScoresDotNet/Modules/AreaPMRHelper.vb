Imports System.Data.SqlClient
Module AreaPMRHelper
    Public Function AreaPMR_Exists(ByVal fromdateval As DateTime, mrcode As String) As Boolean
        Dim RemoteDataSet As New DataSet
        Dim retval As Boolean = False
        Try
            RemoteDataSet.Tables.Add("Table1")
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(1) As SqlParameter
            Dim FROMDATE As New SqlParameter("@FROMDATE", SqlDbType.DateTime, 10) : FROMDATE.Direction = ParameterDirection.Input : FROMDATE.Value = fromdateval : Params(0) = FROMDATE
            Dim FROMMRCODE As New SqlParameter("@FROMMRCODE", SqlDbType.VarChar, 10) : FROMMRCODE.Direction = ParameterDirection.Input : FROMMRCODE.Value = mrcode : Params(1) = FROMMRCODE
            BusinessObject.Sub_Show(ServerPath2, "Util_AreaPMR_SPExists", CommandType.StoredProcedure, RemoteDataSet, "Table1", Params)
            If RemoteDataSet.Tables(0).Rows.Count > 0 Then
                retval = True
            End If
        Catch ex As Exception
            MsgBox("Error in AreaPMR_Exists : " & ex.Message)
        End Try
        Return retval
    End Function
End Module
