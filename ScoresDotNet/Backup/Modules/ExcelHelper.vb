Imports System.Diagnostics
Module ExcelHelper
    Public Sub KillExcellApp()
        Dim xlp() As Process = Process.GetProcessesByName("EXCEL")

        For Each Process As Process In xlp
            Process.Kill()
            If Process.GetProcessesByName("EXCEL").Length = 0 Then
                Exit For
            End If
        Next
    End Sub
End Module
