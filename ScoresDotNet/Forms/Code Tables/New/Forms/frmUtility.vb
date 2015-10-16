Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class frmUtility
    Private connectionString = "Initial Catalog=NewScores; Data Source=MicDb; user id=sa; password=jynxz; Pooling=True; Max Pool Size=1000; Min Pool Size=10; Connect timeout=10000; Persist Security Info=False;"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PopulateMedrepTerritory()
    End Sub

    Private Sub PopulateMedrepTerritory()
        Dim dt As DataTable = New DataTable
        'Dim queryString As String = "SELECT DISTINCT MR.ROWID,MR.MRCODE,MR.MRNAME,TE.TERRITORY"
        'queryString = queryString + " FROM [MEDREP] MR "
        'queryString = queryString + " LEFT JOIN [MRArea] MA on MR.MRCODE = MA.MRCODE"
        'queryString = queryString + " left join Territory TE on MA.TerritoryDR = TE.ROWID"
        'queryString = queryString + " Where Mr.RESIGN_Date = '2078/12/31'AND Mr.end_Date = '2078/12/31'  "
        'queryString = queryString + " AND MR.MRNAME NOT LIKE '%VACANT%' AND TE.TERRITORY IS NOT NULL"
        'queryString = queryString + " ORDER BY MR.MRNAME,TE.TERRITORY"

        Dim queryString As String = "SELECT DISTINCT MR.ROWID,MR.MRCODE,MR.MRNAME,TE.TERRITORY "
        queryString = queryString + " FROM [MEDREP] MR "
        queryString = queryString + " LEFT JOIN [AreaPMR] AP on MR.MRCODE = AP.MRCODE"
        queryString = queryString + " LEFT JOIN [MRArea] MA on AP.AREACODE = MA.AREACODE"
        queryString = queryString + " left join Territory TE on MA.TerritoryDR = TE.ROWID"
        queryString = queryString + " Where Mr.RESIGN_Date = '2078/12/31'AND Mr.end_Date = '2078/12/31'  "
        queryString = queryString + " AND MR.MRNAME NOT LIKE '%VACANT%' AND TE.TERRITORY IS NOT NULL"
        queryString = queryString + " ORDER BY MR.MRNAME,TE.TERRITORY "

        'Dim connectionString As String = "Data Source=(local);Initial Catalog=Northwind;Integrated Security=true"

        ' Provide the query string with a parameter placeholder. 

        ' Specify the parameter value. 
        Dim paramValue As Integer = 5

        ' Create and open the connection in a using block. This 
        ' ensures that all resources will be closed and disposed 
        ' when the code exits. 
        Using connection As New SqlConnection(connectionString)

            ' Create the Command and Parameter objects. 
            Dim command As New SqlCommand(queryString, connection)
            'command.Parameters.AddWithValue("@pricePoint", paramValue)

            ' Open the connection in a try/catch block.  
            ' Create and execute the DataReader, writing the result 
            ' set to the console window. 
            Try
                connection.Open()
                Dim dataAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet
                dataAdapter.SelectCommand = command
                dataAdapter.Fill(myDataSet, "Territories")
                Dim r As DataRow
                Dim stroldcode As String = myDataSet.Tables("Territories").Rows(0)("MRCODE").ToString()
                Dim strnewcode As String = ""
                Dim strterritories = myDataSet.Tables("Territories").Rows(0)("TERRITORY").ToString()
                For Each r In myDataSet.Tables("Territories").Rows
                    strnewcode = r("MRCODE")
                    If stroldcode <> strnewcode Then
                        If (strterritories.ToString.Length > 800) Then
                            strterritories = strterritories.ToString.Substring(1, 800)
                        End If
                        Dim updqueryString As String = "UPDATE Medrep Set Territories = '" + strterritories + "' Where MRCODE='" + stroldcode.Trim() + "'"
                        Dim updcommand As New SqlCommand(updqueryString, connection)
                        Try
                            updcommand.ExecuteNonQuery()
                        Catch ex As Exception
                            MessageBox.Show("Error :" + ex.Message)
                        End Try
                        strterritories = ""
                    Else
                        If (strterritories = "") Then
                            strterritories = r("TERRITORY")
                        Else
                            strterritories = strterritories + "," + r("TERRITORY")
                        End If
                    End If
                    'Console.WriteLine(r("RecipeName").ToString())
                    stroldcode = r("MRCODE")
                Next
            Catch ex As Exception
                MessageBox.Show("Error :" + ex.Message)
            End Try
            connection.Close()
        End Using
    End Sub
End Class