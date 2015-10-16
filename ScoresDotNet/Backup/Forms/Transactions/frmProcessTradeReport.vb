Public Class frmProcessTradeReport

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click
        Dim tyfromdate As DateTime
        Dim tytodate As DateTime
        Dim lyfromdate As DateTime
        Dim lytodate As DateTime
        tyfromdate = dtStart.Value.Date
        tytodate = dtEnd.Value.Date
        lyfromdate = dtStartLast.Value.Date
        lytodate = dtEndLast.Value.Date
        If ProcessTradeReport(tyfromdate, tytodate, lyfromdate, lytodate) = True Then
            EnableCheck(True)
        End If
    End Sub
    Private Function ProcessTradeReport(ByVal TYFromDate As DateTime, ByVal TYToDate As DateTime, ByVal LYFromDate As DateTime, ByVal LYToDate As DateTime) As Boolean
        Dim UpdateString As String = ""
        Dim retval As Boolean = True

        'Upload Parameters
        'This Year
        UpdateString = "ProcessData_SalesTrendStkTrfPivot"
        DataMaintenance.myParamArray(0, 0) = "@TYFromDate"
        DataMaintenance.myParamArray(0, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(0, 2) = 10
        DataMaintenance.myParamArray(0, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(0, 4) = "Date"
        DataMaintenance.myParamArray(0, 5) = TYFromDate
        'This Year
        DataMaintenance.myParamArray(1, 0) = "@TYToDate"
        DataMaintenance.myParamArray(1, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(1, 2) = 10
        DataMaintenance.myParamArray(1, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(1, 4) = "Date"
        DataMaintenance.myParamArray(1, 5) = TYToDate
        'Last Year
        UpdateString = "ProcessData_SalesTrendStkTrfPivot"
        DataMaintenance.myParamArray(2, 0) = "@LYFromDate"
        DataMaintenance.myParamArray(2, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(2, 2) = 10
        DataMaintenance.myParamArray(2, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(2, 4) = "Date"
        DataMaintenance.myParamArray(2, 5) = LYFromDate
        'Last Year
        DataMaintenance.myParamArray(3, 0) = "@LYToDate"
        DataMaintenance.myParamArray(3, 1) = SqlDbType.DateTime
        DataMaintenance.myParamArray(3, 2) = 10
        DataMaintenance.myParamArray(3, 3) = System.Data.ParameterDirection.Input
        DataMaintenance.myParamArray(3, 4) = "Date"
        DataMaintenance.myParamArray(3, 5) = LYToDate


        If DataMaintenance.ExecuteCommand(ServerPath2, UpdateString, CommandType.StoredProcedure, 4) = False Then
            retval = False
        End If
        MsgBox("Trade Report process is complete.", MsgBoxStyle.Information, "Process Trade Report")
        Return retval
    End Function

    Private Sub EnableCheck(ByVal enableit As Boolean)
        chkNoTMSP.Enabled = enableit
        chkBrPrRe.Enabled = enableit
        btnCheck.Enabled = enableit
    End Sub
    Private Sub EnableUpdate(ByVal enableit As Boolean)
        chkCorrectTMSP.Enabled = enableit
        chkUpdateTerDist.Enabled = enableit
        btnUpdate.Enabled = enableit
    End Sub

    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        EnableUpdate(True)
    End Sub
End Class