Imports System.Data.SqlClient
Module GovernmentLagundex
    Public Function GovernmentMonthTerritoryExist(ByVal comdate As DateTime, terdr As String) As Boolean
        Dim RemoteDataSet As New DataSet
        Dim retval As Boolean = False
        Try
            RemoteDataSet.Tables.Add("Table1")
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(1) As SqlParameter
            Dim commissiondate As New SqlParameter("@commissiondate", SqlDbType.DateTime, 10) : commissiondate.Direction = ParameterDirection.Input : commissiondate.Value = comdate : Params(0) = commissiondate
            Dim territorydr As New SqlParameter("@territorydr", SqlDbType.VarChar, 10) : territorydr.Direction = ParameterDirection.Input : territorydr.Value = terdr : Params(1) = territorydr
            BusinessObject.Sub_Show(ServerPath2, "Util_GovtMonthTerritory", CommandType.StoredProcedure, RemoteDataSet, "Table1", Params)
            If RemoteDataSet.Tables(0).Rows.Count > 0 Then
                retval = True
            End If
        Catch ex As Exception
            MsgBox("Error in GovernmentMonthTerritoryExist : " & ex.Message)
        End Try
        Return retval
    End Function

    Public Function GovernmentMonthTerritory(ByVal comdate As DateTime, terdr As String) As DataRow
        Dim RemoteDataSet As New DataSet
        Dim retval As Boolean = False
        Try
            RemoteDataSet.Tables.Add("Table1")
            Dim BusinessObject As New BusinessLayer.clsFileMaintenance
            Dim Params(1) As SqlParameter
            Dim commissiondate As New SqlParameter("@commissiondate", SqlDbType.DateTime, 10) : commissiondate.Direction = ParameterDirection.Input : commissiondate.Value = comdate : Params(0) = commissiondate
            Dim territorydr As New SqlParameter("@territorydr", SqlDbType.VarChar, 10) : territorydr.Direction = ParameterDirection.Input : territorydr.Value = terdr : Params(1) = territorydr
            BusinessObject.Sub_Show(ServerPath2, "Util_GovtMonthTerritory", CommandType.StoredProcedure, RemoteDataSet, "Table1", Params)
        Catch ex As Exception
            MsgBox("Error in GovernmentMonthTerritory : " & ex.Message)
        End Try
        Return RemoteDataSet.Tables(0).Rows(0)
    End Function

    Public Sub TransferLagundexFromPediaToGovernment(srowid As String, dr As DataRow)
        Try
            '@mrcode varchar(25), 
            DataMaintenance.myParamArray(0, 0) = "@mrcode"
            DataMaintenance.myParamArray(0, 1) = SqlDbType.VarChar
            DataMaintenance.myParamArray(0, 2) = 25
            DataMaintenance.myParamArray(0, 3) = ParameterDirection.Input
            DataMaintenance.myParamArray(0, 4) = "String"
            DataMaintenance.myParamArray(0, 5) = dr("mrcode").ToString().Trim()
            '@mrname varchar(75),
            DataMaintenance.myParamArray(1, 0) = "@mrname"
            DataMaintenance.myParamArray(1, 1) = SqlDbType.VarChar
            DataMaintenance.myParamArray(1, 2) = 75
            DataMaintenance.myParamArray(1, 3) = ParameterDirection.Input
            DataMaintenance.myParamArray(1, 4) = "String"
            DataMaintenance.myParamArray(1, 5) = dr("mrname").ToString().Trim()
            '@mrterrcode varchar(10),
            DataMaintenance.myParamArray(2, 0) = "@mrterrcode"
            DataMaintenance.myParamArray(2, 1) = SqlDbType.VarChar
            DataMaintenance.myParamArray(2, 2) = 10
            DataMaintenance.myParamArray(2, 3) = ParameterDirection.Input
            DataMaintenance.myParamArray(2, 4) = "String"
            DataMaintenance.myParamArray(2, 5) = dr("mrterrcode").ToString().Trim()
            '@supcode varchar(25),
            DataMaintenance.myParamArray(3, 0) = "@supcode"
            DataMaintenance.myParamArray(3, 1) = SqlDbType.VarChar
            DataMaintenance.myParamArray(3, 2) = 25
            DataMaintenance.myParamArray(3, 3) = ParameterDirection.Input
            DataMaintenance.myParamArray(3, 4) = "String"
            DataMaintenance.myParamArray(3, 5) = dr("supcode").ToString().Trim()
            '@supname varchar(75),
            DataMaintenance.myParamArray(4, 0) = "@supname"
            DataMaintenance.myParamArray(4, 1) = SqlDbType.VarChar
            DataMaintenance.myParamArray(4, 2) = 75
            DataMaintenance.myParamArray(4, 3) = ParameterDirection.Input
            DataMaintenance.myParamArray(4, 4) = "String"
            DataMaintenance.myParamArray(4, 5) = dr("supname").ToString().Trim()
            '@supteamcode varchar(10),
            DataMaintenance.myParamArray(5, 0) = "@supteamcode"
            DataMaintenance.myParamArray(5, 1) = SqlDbType.VarChar
            DataMaintenance.myParamArray(5, 2) = 10
            DataMaintenance.myParamArray(5, 3) = ParameterDirection.Input
            DataMaintenance.myParamArray(5, 4) = "String"
            DataMaintenance.myParamArray(5, 5) = dr("supteamcode").ToString().Trim()
            '@tsmrcode varchar(10), 
            DataMaintenance.myParamArray(6, 0) = "@tsmrcode"
            DataMaintenance.myParamArray(6, 1) = SqlDbType.VarChar
            DataMaintenance.myParamArray(6, 2) = 10
            DataMaintenance.myParamArray(6, 3) = ParameterDirection.Input
            DataMaintenance.myParamArray(6, 4) = "String"
            DataMaintenance.myParamArray(6, 5) = dr("tsmrcode").ToString().Trim()
            '@tsmrname varchar(50),
            DataMaintenance.myParamArray(7, 0) = "@tsmrname"
            DataMaintenance.myParamArray(7, 1) = SqlDbType.VarChar
            DataMaintenance.myParamArray(7, 2) = 50
            DataMaintenance.myParamArray(7, 3) = ParameterDirection.Input
            DataMaintenance.myParamArray(7, 4) = "String"
            DataMaintenance.myParamArray(7, 5) = dr("tsmrname").ToString().Trim()
            '@tssupcode varchar(10),
            DataMaintenance.myParamArray(8, 0) = "@tssupcode"
            DataMaintenance.myParamArray(8, 1) = SqlDbType.VarChar
            DataMaintenance.myParamArray(8, 2) = 10
            DataMaintenance.myParamArray(8, 3) = ParameterDirection.Input
            DataMaintenance.myParamArray(8, 4) = "String"
            DataMaintenance.myParamArray(8, 5) = dr("tssupcode").ToString().Trim()
            '@tssupname varchar(50),
            DataMaintenance.myParamArray(9, 0) = "@tssupname"
            DataMaintenance.myParamArray(9, 1) = SqlDbType.VarChar
            DataMaintenance.myParamArray(9, 2) = 50
            DataMaintenance.myParamArray(9, 3) = ParameterDirection.Input
            DataMaintenance.myParamArray(9, 4) = "String"
            DataMaintenance.myParamArray(9, 5) = dr("tssupname").ToString().Trim()
            '@tsareacode varchar(10),
            DataMaintenance.myParamArray(10, 0) = "@tsareacode"
            DataMaintenance.myParamArray(10, 1) = SqlDbType.VarChar
            DataMaintenance.myParamArray(10, 2) = 10
            DataMaintenance.myParamArray(10, 3) = ParameterDirection.Input
            DataMaintenance.myParamArray(10, 4) = "String"
            DataMaintenance.myParamArray(10, 5) = dr("tsareacode").ToString().Trim()
            '@tsteamcode varchar(10),
            DataMaintenance.myParamArray(11, 0) = "@tsteamcode"
            DataMaintenance.myParamArray(11, 1) = SqlDbType.VarChar
            DataMaintenance.myParamArray(11, 2) = 10
            DataMaintenance.myParamArray(11, 3) = ParameterDirection.Input
            DataMaintenance.myParamArray(11, 4) = "String"
            DataMaintenance.myParamArray(11, 5) = dr("tsteamcode").ToString().Trim()
            '@mrdivision varchar(30),
            DataMaintenance.myParamArray(12, 0) = "@mrdivision"
            DataMaintenance.myParamArray(12, 1) = SqlDbType.VarChar
            DataMaintenance.myParamArray(12, 2) = 30
            DataMaintenance.myParamArray(12, 3) = ParameterDirection.Input
            DataMaintenance.myParamArray(12, 4) = "String"
            DataMaintenance.myParamArray(12, 5) = dr("mrdivision").ToString().Trim()

            '@rowid varchar(10)
            DataMaintenance.myParamArray(13, 0) = "@rowid"
            DataMaintenance.myParamArray(13, 1) = SqlDbType.VarChar
            DataMaintenance.myParamArray(13, 2) = 10
            DataMaintenance.myParamArray(13, 3) = ParameterDirection.Input
            DataMaintenance.myParamArray(13, 4) = "String"
            DataMaintenance.myParamArray(13, 5) = srowid

            '@nsmcode varchar(25)
            DataMaintenance.myParamArray(14, 0) = "@nsmcode"
            DataMaintenance.myParamArray(14, 1) = SqlDbType.VarChar
            DataMaintenance.myParamArray(14, 2) = 25
            DataMaintenance.myParamArray(14, 3) = ParameterDirection.Input
            DataMaintenance.myParamArray(14, 4) = "String"
            DataMaintenance.myParamArray(14, 5) = dr("nsmcode").ToString().Trim()

            '@nsmname varchar(75)
            DataMaintenance.myParamArray(15, 0) = "@nsmname"
            DataMaintenance.myParamArray(15, 1) = SqlDbType.VarChar
            DataMaintenance.myParamArray(15, 2) = 75
            DataMaintenance.myParamArray(15, 3) = ParameterDirection.Input
            DataMaintenance.myParamArray(15, 4) = "String"
            DataMaintenance.myParamArray(15, 5) = dr("nsmname").ToString().Trim()

            '@pmcode varchar(10)
            DataMaintenance.myParamArray(16, 0) = "@pmcode"
            DataMaintenance.myParamArray(16, 1) = SqlDbType.VarChar
            DataMaintenance.myParamArray(16, 2) = 10
            DataMaintenance.myParamArray(16, 3) = ParameterDirection.Input
            DataMaintenance.myParamArray(16, 4) = "String"
            DataMaintenance.myParamArray(16, 5) = dr("pmcode").ToString().Trim()

            '@pmname varchar(50)
            DataMaintenance.myParamArray(17, 0) = "@pmname"
            DataMaintenance.myParamArray(17, 1) = SqlDbType.VarChar
            DataMaintenance.myParamArray(17, 2) = 50
            DataMaintenance.myParamArray(17, 3) = ParameterDirection.Input
            DataMaintenance.myParamArray(17, 4) = "String"
            DataMaintenance.myParamArray(17, 5) = dr("pmname").ToString().Trim()

            DataMaintenance.ExecuteCommand(ServerPath2, "Util_PediaToGov", CommandType.StoredProcedure, 18)

        Catch ex As Exception
            MsgBox("Error in executing : TransferLagundexFromPediaToGovernment " & ex.Message)
        End Try

    End Sub
End Module
