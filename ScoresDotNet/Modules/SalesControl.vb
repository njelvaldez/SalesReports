Imports System.Data.SqlClient
Module SalesControl
    Public Function RecordSubDistSales(salesdate As DateTime) As Boolean
        Dim retval As Boolean = True
        Try
            SaveSubDistSales(SubDistSales(salesdate))
        Catch ex As Exception
            MsgBox("Error in : " & ex.Message)
        End Try
        Return retval
    End Function

    Public Function SubDistSales(salesdate As DateTime) As DataSet
        Dim RemoteDataSet As New DataSet
        Try
            RemoteDataSet.Tables.Add("Table1")
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = salesdate : Params(0) = salescycledate
            BusinessObject.Sub_Show(ServerPath2, "Util_Subdist_Sales", CommandType.StoredProcedure, RemoteDataSet, "Table1", Params)
        Catch ex As Exception
            MsgBox("Error in : " & "SubDistSales - " & ex.Message)
        End Try
        Return RemoteDataSet
    End Function

    Public Function SaveSubDistSales(sales As DataSet) As Boolean
        Dim retval As Boolean = True
        Try
            For Each drow As DataRow In sales.Tables(0).Rows
                'If subdist + month exists : Update , Otherwise : Insert
                Dim subdist_code As String = drow("subdist_code").ToString()
                Dim subdistributor As String = drow("subdistributor").ToString()
                Dim salesmonth As DateTime = drow("commissiondate")
                Dim amt As Double = drow("amountsold")
                If SubDistExist(subdist_code, salesmonth) Then
                    'Update Sales Control
                    UpdateSalesControl(subdist_code, subdistributor, salesmonth, amt)
                Else
                    'Insert Sales Control
                    InsertSalesControl(subdist_code, subdistributor, salesmonth, amt)
                End If
            Next
        Catch ex As Exception
            MsgBox("Error in : SaveSubDistSales - " & ex.Message)
        End Try
        Return retval
    End Function
    Public Function SubDistExist(subdist As String, salesdate As DateTime) As Boolean
        Dim retval As Boolean = False
        Dim RemoteDataSet As New DataSet
        RemoteDataSet.Tables.Add("Table1")
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        Dim Params(1) As SqlParameter
        Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = salesdate : Params(0) = salescycledate
        Dim subdist_code As New SqlParameter("@subdist_code", SqlDbType.VarChar, 10) : subdist_code.Direction = ParameterDirection.Input : subdist_code.Value = subdist : Params(1) = subdist_code
        BusinessObject.Sub_Show(ServerPath2, "Util_SalesControlExist", CommandType.StoredProcedure, RemoteDataSet, "Table1", Params)
        If RemoteDataSet.Tables(0).Rows.Count > 0 Then
            retval = True
        End If
        Return retval
    End Function
    Public Function UpdateSalesControl(subdist As String, subdistributor As String, salesdate As DateTime, amt As Double) As Boolean
        Dim retval As Boolean = True
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(3) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = salesdate : Params(0) = salescycledate
            Dim subdist_code As New SqlParameter("@subdist_code", SqlDbType.VarChar, 10) : subdist_code.Direction = ParameterDirection.Input : subdist_code.Value = subdist : Params(1) = subdist_code
            Dim amountsold As New SqlParameter("@amountsold", SqlDbType.Money, 10) : amountsold.Direction = ParameterDirection.Input : amountsold.Value = amt : Params(2) = amountsold
            Dim updateby As New SqlParameter("@updateby", SqlDbType.VarChar, 50) : updateby.Direction = ParameterDirection.Input : updateby.Value = gUserID : Params(3) = updateby
            BusinessObject.Sub_Update(ServerPath2, "Util_SalesControlUpdate", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox("Error in UpdateSalesControl : " & ex.Message)
            retval = False
        End Try
        Return retval
    End Function
    Public Function UpdateSalesControlInput(subdist As String, subdistributor As String, salesdate As DateTime, amt As Double) As Boolean
        Dim retval As Boolean = True
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(2) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = salesdate : Params(0) = salescycledate
            Dim subdist_code As New SqlParameter("@subdist_code", SqlDbType.VarChar, 10) : subdist_code.Direction = ParameterDirection.Input : subdist_code.Value = subdist : Params(1) = subdist_code
            Dim amountsoldinput As New SqlParameter("@amountsoldinput", SqlDbType.Money, 10) : amountsoldinput.Direction = ParameterDirection.Input : amountsoldinput.Value = amt : Params(2) = amountsoldinput
            BusinessObject.Sub_Update(ServerPath2, "Util_SalesControlUpdateInput", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox("Error in UpdateSalesControl : " & ex.Message)
            retval = False
        End Try
        Return retval
    End Function
    Public Function InsertSalesControl(subdist As String, subdistributorval As String, salesdate As DateTime, amt As Double) As Boolean
        Dim retval As Boolean = True
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(4) As SqlParameter
            Dim salescycledate As New SqlParameter("@salescycledate", SqlDbType.DateTime, 10) : salescycledate.Direction = ParameterDirection.Input : salescycledate.Value = salesdate : Params(0) = salescycledate
            Dim subdist_code As New SqlParameter("@subdist_code", SqlDbType.VarChar, 10) : subdist_code.Direction = ParameterDirection.Input : subdist_code.Value = subdist : Params(1) = subdist_code
            Dim amountsold As New SqlParameter("@amountsold", SqlDbType.Money, 10) : amountsold.Direction = ParameterDirection.Input : amountsold.Value = amt : Params(2) = amountsold
            Dim subdistributor As New SqlParameter("@subdistributor", SqlDbType.VarChar, 50) : subdistributor.Direction = ParameterDirection.Input : subdistributor.Value = subdistributorval : Params(3) = subdistributor
            Dim createby As New SqlParameter("@createby", SqlDbType.VarChar, 50) : createby.Direction = ParameterDirection.Input : createby.Value = gUserID : Params(4) = createby
            BusinessObject.Sub_Insert(ServerPath2, "Util_SalesControlInsert", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox("Error in InsertSalesControl : " & ex.Message)
            retval = False
        End Try

    End Function
    Public Function SalesControlDiscrepancy() As Boolean
        Dim retval As Boolean = False
        Dim RemoteDataSet As New DataSet
        RemoteDataSet.Tables.Add("Table1")
        Dim BusinessObject As New BusinessLayer.clsFileMaintenance
        BusinessObject.Sub_Show(ServerPath2, "Util_SalesControlDiscrepancy", CommandType.StoredProcedure, RemoteDataSet, "Table1")
        If RemoteDataSet.Tables(0).Rows.Count > 0 Then
            retval = True
            MsgBox("Sales Discrepancy found! Please correct discrepancy before generating Sales Report!")
        End If
        Return retval
    End Function

    Public Function AutoCorrectSalesControl() As Boolean
        Dim retval As Boolean = True
        Try
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(0) As SqlParameter
            Dim dummyparam As New SqlParameter("@dummyparam", SqlDbType.VarChar, 10) : dummyparam.Direction = ParameterDirection.Input : dummyparam.Value = "" : Params(0) = dummyparam
            BusinessObject.Sub_Update(ServerPath2, "Util_SalesControlAutoCorrect", CommandType.StoredProcedure, Params)
        Catch ex As Exception
            MsgBox("Error in UpdateSalesControl : " & ex.Message)
            retval = False
        End Try
        Return retval
    End Function
End Module
