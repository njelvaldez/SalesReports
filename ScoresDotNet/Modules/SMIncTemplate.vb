Imports System.Data.SqlClient
Module SMIncTemplate
    Public Function SMIncTemplateExists(salesdate As DateTime) As Boolean
        Dim retval As Boolean = False
        Dim tmpds As New DataSet
        Try
            tmpds.Tables.Add("Table1")
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = salesdate : Params(0) = salescycledate
            BusinessObject.Sub_Show(ServerPath2, "Util_SMIncTemplateExist", CommandType.StoredProcedure, tmpds, "Table1", Params)
            If tmpds.Tables(0).Rows.Count > 0 Then
                retval = True
            End If
        Catch ex As Exception
            MsgBox("Error in SMIncTemplateExists : " & ex.Message)
        End Try
        Return retval
    End Function
    Public Function SMIncTemplateCopy(salesdate As DateTime) As Boolean
        Dim retval As Boolean = True
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = salesdate : Params(0) = salescycledate
            BusinessObject.Sub_Insert(ServerPath2, "Util_SMIncTemplateCopy", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox("Error in Util_SMIncTemplateCopy : " & ex.Message)
            retval = False
        End Try
        Return retval
    End Function
End Module

