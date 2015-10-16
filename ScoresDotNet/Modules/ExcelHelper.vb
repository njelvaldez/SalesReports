Imports System.Diagnostics
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports Microsoft
Imports Microsoft.Office.Interop
Imports System.Configuration
Imports System.Globalization
Imports System.IO
Imports System.Runtime.InteropServices
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

    Public Sub ExportToExcel(DataGridView1 As DataGridView)
        Dim xl As New Excel.Application
        'Dim wb As Excel.Workbook
        Dim wbtemplate As Excel.Workbook
        Dim ws As Excel.Worksheet
        Dim exporttemplatepath As String = System.Configuration.ConfigurationSettings.AppSettings.Item("ExportToExcelTemplate")
        Dim exportoutputpath As String = System.Configuration.ConfigurationSettings.AppSettings.Item("ExportToExcelOutPut")

        Dim RemoteDataSet As New DataSet
        Try
            'Open the Export to Excel Template
            Try
                wbtemplate = xl.Workbooks.Open(exporttemplatepath)
                xl.DisplayAlerts = False
            Catch ex As Exception
                MessageBox.Show(ex.Message, "OpenOutputTemplate module")
            End Try
            ws = CType(wbtemplate.Worksheets.Item("Sheet1"), Excel.Worksheet)

            'Export Header Names Start
            Dim columnsCount As Integer = DataGridView1.Columns.Count
            For Each column As DataGridViewColumn In DataGridView1.Columns
                Try
                    ws.Cells(1, column.Index + 1).Value = column.Name
                Catch ex As Exception

                End Try
            Next
            'Export Header Name End

            'Export Each Row Start
            For i As Integer = 0 To DataGridView1.Rows.Count - 2
                Dim columnIndex As Integer = 0
                Do Until columnIndex = columnsCount
                    Try
                        ws.Cells(i + 2, columnIndex + 1).Value = DataGridView1.Item(columnIndex, i).Value.ToString
                        columnIndex += 1
                    Catch ex As Exception
                    End Try
                Loop
            Next
            'Export Each Row End
            wbtemplate.SaveAs(exportoutputpath)
            wbtemplate.RefreshAll()
            wbtemplate.SaveAs(exportoutputpath)
            wbtemplate.Close()
            'wb.Close()
            xl.Quit()
            xl = Nothing
            KillExcellApp()
            MsgBox("File is exported to " & exportoutputpath)
        Catch ex As Exception
            MsgBox("Error in ExportToExcel : " & ex.Message)
        End Try
    End Sub

    Public Sub ExportIntegratedSales(DataGridView1 As DataGridView)
        Dim xl As New Excel.Application
        'Dim wb As Excel.Workbook
        Dim wbtemplate As Excel.Workbook
        Dim ws As Excel.Worksheet
        Dim integratedsalespath As String = System.Configuration.ConfigurationSettings.AppSettings.Item("IntegratedSalesTemplate")
        Dim integratedsalesoutputpath As String = System.Configuration.ConfigurationSettings.AppSettings.Item("IntegratedSalesOutPut")

        Dim RemoteDataSet As New DataSet
        Dim ouputtemplate As String = integratedsalesoutputpath
        Try
            'Open the Export to Excel Template
            Try
                wbtemplate = xl.Workbooks.Open(integratedsalespath)
                xl.DisplayAlerts = False
            Catch ex As Exception
                MessageBox.Show(ex.Message, "OpenOutputTemplate module")
            End Try
            ws = CType(wbtemplate.Worksheets.Item("Sheet1"), Excel.Worksheet)

            'Export Header Names Start
            Dim columnsCount As Integer = DataGridView1.Columns.Count
            For Each column As DataGridViewColumn In DataGridView1.Columns
                Try
                    ws.Cells(1, column.Index + 1).Value = column.Name
                Catch ex As Exception

                End Try
            Next
            'Export Header Name End

            'Export Each Row Start
            For i As Integer = 0 To DataGridView1.Rows.Count - 2
                Dim columnIndex As Integer = 0
                Do Until columnIndex = columnsCount
                    Try
                        ws.Cells(i + 2, columnIndex + 1).Value = DataGridView1.Item(columnIndex, i).Value.ToString
                        columnIndex += 1
                    Catch ex As Exception
                    End Try
                Loop
            Next
            'Export Each Row End
            wbtemplate.SaveAs(ouputtemplate)
            wbtemplate.RefreshAll()
            wbtemplate.SaveAs(ouputtemplate)
            wbtemplate.Close()
            xl.Quit()
            xl = Nothing
            MsgBox("File is exported to " & ouputtemplate)
        Catch ex As Exception
            MsgBox("Error in ExportToExcel : " & ex.Message)
        Finally
            KillExcellApp()
        End Try
    End Sub
End Module
