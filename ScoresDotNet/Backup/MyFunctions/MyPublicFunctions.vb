'=============================================================================
'-- Author:		 Jhun Niemo
'-- CREATE date: 02012013
'-- ALTER  date: 03052013
'-- Description: SubMenus: DistributorBudgetDirect
'=============================================================================
Imports System.Data.SqlClient

Module MyPublicFunctions
    Public Function GetFirstDayOfMonth(ByVal _dtDate As DateTime) As DateTime
        Dim _dtFrom As DateTime = _dtDate
        _dtFrom = _dtFrom.AddDays(-(_dtFrom.Day - 1))
        Return _dtFrom
    End Function

    Public Function GetLastDayOfMonth(ByVal _dtDate As DateTime) As DateTime
        Dim _dtTo As New DateTime(_dtDate.Year, _dtDate.Month, 1)
        _dtTo = _dtTo.AddMonths(1)
        _dtTo = _dtTo.AddDays(-(_dtTo.Day))
        Return _dtTo
    End Function

    Public Function GetLastDayOfYear(ByVal _dtDate As DateTime) As DateTime
        Dim _dtNewTo As New DateTime((_dtDate.Year + 1), 1, 1)
        _dtNewTo = _dtNewTo.AddDays(-1)
        Return _dtNewTo
    End Function

    Public Function IfEmptyReturnNull(ByVal datestr As String) As Object
        Dim retval As Object
        If datestr = "" Then
            retval = DBNull.Value
        Else
            retval = datestr
        End If
        Return retval
    End Function

End Module
