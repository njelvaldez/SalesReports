Imports System.Data.SqlClient
Imports System.io
Module DataMaintenance
    Private m_ParamArray(9, 5) As Object
    Public Property myParamArray(ByVal index1 As Integer, ByVal index2 As Integer) As Object
        Get
            Return m_ParamArray(index1, index2)
        End Get
        Set(ByVal Value As Object)
            'Redim Preserve to increase the indices
            m_ParamArray(index1, index2) = Value
        End Set
    End Property
    Public Function objConnection(ByVal strConnection As String) As SqlConnection
        Dim myConnection As New SqlConnection
        With myConnection
            .ConnectionString = strConnection
            .Open()
        End With
        Return myConnection
        myConnection.Close()
    End Function
    Public Function ExecuteCommand(ByVal strConnection As String, _
    ByVal strCommand As String, ByVal CommandType As CommandType, _
    Optional ByVal ParamNum As Integer = 0) As Boolean
        Dim objCommand As New SqlCommand
        Dim myConnection As New SqlConnection
        Dim i As Integer
        Try
            With objCommand
                .Connection = objConnection(strConnection)
                .CommandText = strCommand
                .CommandType = CommandType
                .CommandTimeout = 120
                If CommandType = CommandType.StoredProcedure Then
                    For i = 1 To ParamNum
                        .Parameters.Add(CollectParameters(i - 1))
                    Next
                End If
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
        Return True
    End Function
    Public Function GetSingleResult(ByVal strConnection As String, _
        ByVal strCommand As String, ByVal CommandType As CommandType, _
        Optional ByVal ParamNum As Integer = 0) As Decimal
        Dim objCommand As New SqlCommand
        Dim i As Integer
        Dim mySingleResult As Decimal
        Try
            With objCommand
                .Connection = objConnection(strConnection)
                .CommandText = strCommand
                .CommandType = CommandType
                If CommandType = CommandType.StoredProcedure Then
                    For i = 1 To ParamNum
                        .Parameters.Add(CollectParameters(i - 1))
                    Next
                End If
                mySingleResult = CDec(.ExecuteScalar())
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Function
        End Try
        Return mySingleResult
    End Function
    Public Function GetResultSet(ByVal strConnection As String, _
        ByVal strCommand As String, ByVal CommandType As CommandType, _
        Optional ByVal ParamNum As Integer = 0) As SqlDataReader
        Dim objCommand As New SqlCommand
        Dim i As Integer
        Dim myResultSet As SqlDataReader

        Try
            With objCommand
                .Connection = objConnection(strConnection)
                .CommandText = strCommand
                .CommandType = CommandType
                If CommandType = CommandType.StoredProcedure Then
                    For i = 1 To ParamNum
                        .Parameters.Add(CollectParameters(i - 1))
                    Next
                End If
                myResultSet = .ExecuteReader()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Function
        End Try
        Return myResultSet
    End Function
    Private Function CollectParameters(ByVal StartAt As Integer) As SqlParameter
        Dim myParameters As New SqlParameter
        Dim myValue As Object
        With myParameters
            .ParameterName = CStr(myParamArray(StartAt, 0))
            .SqlDbType = CType(myParamArray(StartAt, 1), SqlDbType)
            .Size = CInt(myParamArray(StartAt, 2))
            .Direction = CType(myParamArray(StartAt, 3), ParameterDirection)
            Select Case CStr(myParamArray(StartAt, 4))
                Case "String"
                    .Value = CStr(myParamArray(StartAt, 5))
                Case "Date"
                    .Value = CDate(myParamArray(StartAt, 5))
                Case "Integer"
                    .Value = CInt(myParamArray(StartAt, 5))
            End Select
        End With
        Return myParameters
    End Function
    Public Function GetDataTable(ByVal strConnection As String, _
        ByVal strCommand As String, ByVal CommandType As CommandType, _
        Optional ByVal ParamNum As Integer = 0) As DataTable
        Dim objCommand As New SqlCommand
        Dim i As Integer
        Dim myResultSet As New DataTable
        Dim myDataAdapter As New SqlDataAdapter

        Try
            With objCommand
                .Connection = objConnection(strConnection)
                .CommandText = strCommand
                .CommandType = CommandType
                If CommandType = CommandType.StoredProcedure Then
                    For i = 1 To ParamNum
                        .Parameters.Add(CollectParameters(i - 1))
                    Next
                End If
            End With
            myDataAdapter.SelectCommand = objCommand
            myDataAdapter.Fill(myResultSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Function
        End Try
        Return myResultSet
    End Function
    Public Function ExecuteCommand_WithOutPut(ByVal strConnection As String, _
    ByVal strCommand As String, ByVal CommandType As CommandType, _
    Optional ByVal ParamNum As Integer = 0) As Object
        Dim myObject As Object
        Dim objCommand As New SqlCommand
        Dim i As Integer
        Try
            With objCommand
                .Connection = objConnection(strConnection)
                .CommandText = strCommand
                .CommandType = CommandType
                If CommandType = CommandType.StoredProcedure Then
                    For i = 1 To ParamNum
                        .Parameters.Add(CollectParameters(i - 1))
                    Next
                End If
                .ExecuteNonQuery()
                'find the output parameter
                Dim myparam As SqlParameter
                For Each myparam In objCommand.Parameters
                    If myparam.Direction = ParameterDirection.Output Then
                        myObject = myparam.Value
                    End If
                Next
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Function
        End Try
        Return myObject
    End Function
    Public Sub Process_TextFile(ByVal myParameters As Collection)
        Dim myParameter As SqlParameter
        For Each myParameter In myParameters
            MessageBox.Show(myParameter.ParameterName)
        Next
    End Sub
    Public Sub Receive_TextString(ByVal myString As String)
        Dim myArray() As String
        Dim delimeterChar As String = Chr(10)
        Dim delimeter As Char() = delimeterChar.ToCharArray
        Dim i As Integer
        Dim line As String = ""

        myArray = myString.Split(delimeter)
        Dim myCommand As New SqlCommand
        With myCommand
            .CommandText = "Insert_TextFile"
            .CommandType = CommandType.StoredProcedure
        End With
        'append the parameters
        Dim comp As New SqlParameter("@comp", SqlDbType.VarChar, 2) : myCommand.Parameters.Add(comp)
        Dim bran As New SqlParameter("@bran", SqlDbType.VarChar, 3) : myCommand.Parameters.Add(bran)
        Dim bnam As New SqlParameter("@bnam", SqlDbType.VarChar, 24) : myCommand.Parameters.Add(bnam)
        Dim cusno As New SqlParameter("@cusno", SqlDbType.VarChar, 6) : myCommand.Parameters.Add(cusno)
        Dim cnam As New SqlParameter("@cnam", SqlDbType.VarChar, 50) : myCommand.Parameters.Add(cnam)
        Dim cad1 As New SqlParameter("@cad1", SqlDbType.VarChar, 50) : myCommand.Parameters.Add(cad1)
        Dim cad2 As New SqlParameter("@cad2", SqlDbType.VarChar, 50) : cad2.Value = Mid(line, 136, 50) : myCommand.Parameters.Add(cad2)
        Dim dyer As New SqlParameter("@dyer", SqlDbType.Char, 10) : myCommand.Parameters.Add(dyer)
        Dim docno As New SqlParameter("@docno", SqlDbType.VarChar, 8) : myCommand.Parameters.Add(docno)
        Dim rfcd As New SqlParameter("@rfcd", SqlDbType.VarChar, 2) : myCommand.Parameters.Add(rfcd)
        Dim prod As New SqlParameter("@prod", SqlDbType.VarChar, 20) : myCommand.Parameters.Add(prod)
        Dim pdes As New SqlParameter("@pdes", SqlDbType.VarChar, 20) : myCommand.Parameters.Add(pdes)
        Dim whse As New SqlParameter("@whse", SqlDbType.VarChar, 3) : myCommand.Parameters.Add(whse)
        Dim clas As New SqlParameter("@clas", SqlDbType.VarChar, 3) : myCommand.Parameters.Add(clas)
        Dim qtso As New SqlParameter("@qtso", SqlDbType.Int) : myCommand.Parameters.Add(qtso)
        Dim qtfr As New SqlParameter("@qtfr", SqlDbType.Int) : myCommand.Parameters.Add(qtfr)
        Dim vlam As New SqlParameter("@vlam", SqlDbType.Money) : myCommand.Parameters.Add(vlam)
        Dim dsct As New SqlParameter("@dsct", SqlDbType.Int) : myCommand.Parameters.Add(dsct)
        Dim pdsc As New SqlParameter("@pdsc", SqlDbType.Money) : myCommand.Parameters.Add(pdsc)
        Dim cvat As New SqlParameter("@cvat", SqlDbType.Char, 1) : myCommand.Parameters.Add(cvat)
        Dim rout As New SqlParameter("@rout", SqlDbType.VarChar, 6) : myCommand.Parameters.Add(rout)
        Dim taxs As New SqlParameter("@taxs", SqlDbType.Money, 13) : myCommand.Parameters.Add(taxs)
        Dim fret As New SqlParameter("@fret", SqlDbType.Money, 13) : myCommand.Parameters.Add(fret)
        Dim adtl As New SqlParameter("@adtl", SqlDbType.Char, 19) : myCommand.Parameters.Add(adtl)
        Dim pnet As New SqlParameter("@pnet", SqlDbType.Money, 13) : myCommand.Parameters.Add(pnet)
        Dim uprc As New SqlParameter("@uprc", SqlDbType.Money, 9) : myCommand.Parameters.Add(uprc)
        Dim ref1 As New SqlParameter("@ref1", SqlDbType.VarChar, 8) : myCommand.Parameters.Add(ref1)
        Dim cmcd As New SqlParameter("@cmcd", SqlDbType.VarChar, 3) : myCommand.Parameters.Add(cmcd)
        Dim ref2 As New SqlParameter("@ref2", SqlDbType.VarChar, 8) : myCommand.Parameters.Add(ref2)
        Dim sodt As New SqlParameter("@sodt", SqlDbType.Char, 10) : myCommand.Parameters.Add(sodt)
        Dim term As New SqlParameter("@term", SqlDbType.VarChar, 6) : myCommand.Parameters.Add(term)
        Dim edte As New SqlParameter("@edte", SqlDbType.Char, 10) : myCommand.Parameters.Add(edte)
        Dim lotno As New SqlParameter("@lotno", SqlDbType.VarChar, 15) : myCommand.Parameters.Add(lotno)
        Dim slmno As New SqlParameter("@slmno", SqlDbType.VarChar, 3) : myCommand.Parameters.Add(slmno)
        Dim slnm As New SqlParameter("@slnm", SqlDbType.VarChar, 24) : myCommand.Parameters.Add(slnm)
        Dim shipto As New SqlParameter("@shipto", SqlDbType.VarChar, 50) : myCommand.Parameters.Add(shipto)
        Dim sad1 As New SqlParameter("@sad1", SqlDbType.VarChar, 50) : myCommand.Parameters.Add(sad1)
        Dim sad2 As New SqlParameter("@sad2", SqlDbType.VarChar, 50) : myCommand.Parameters.Add(sad2)
        Dim zipc As New SqlParameter("@zipc", SqlDbType.VarChar, 6) : myCommand.Parameters.Add(zipc)
        Dim terno As New SqlParameter("@terno", SqlDbType.VarChar, 3) : myCommand.Parameters.Add(terno)
        Dim area As New SqlParameter("@area", SqlDbType.VarChar, 3) : myCommand.Parameters.Add(area)
        Dim ccls As New SqlParameter("@ccls", SqlDbType.VarChar, 3) : myCommand.Parameters.Add(ccls)
        Dim clsn As New SqlParameter("@clsn", SqlDbType.VarChar, 24) : myCommand.Parameters.Add(clsn)
        Dim prin As New SqlParameter("@prin", SqlDbType.VarChar, 3) : myCommand.Parameters.Add(prin)
        Dim sprn As New SqlParameter("@sprn", SqlDbType.VarChar, 6) : myCommand.Parameters.Add(sprn)
        Dim prdc As New SqlParameter("@prdc", SqlDbType.VarChar, 3) : myCommand.Parameters.Add(prdc)
        Dim swek As New SqlParameter("@swek", SqlDbType.VarChar, 1) : myCommand.Parameters.Add(swek)
        myCommand.Connection = objConnection(ServerPath2)
        For i = 0 To (myArray.GetUpperBound(0)) - 1
            line = myArray(i)
            comp.Value = Mid(line, 1, 2)
            bran.Value = Mid(line, 3, 3)
            bnam.Value = Mid(line, 6, 24)
            cusno.Value = Mid(line, 30, 6)
            cnam.Value = Mid(line, 36, 50)
            cad1.Value = Mid(line, 86, 50)
            cad2.Value = Mid(line, 136, 50)
            dyer.Value = Mid(line, 186, 8)
            docno.Value = Mid(line, 194, 8)
            rfcd.Value = Mid(line, 202, 2)
            prod.Value = Mid(line, 204, 20)
            pdes.Value = Mid(line, 224, 20)
            whse.Value = Mid(line, 244, 3)
            clas.Value = Mid(line, 247, 3)
            qtso.Value = Mid(line, 250, 9)
            qtfr.Value = Mid(line, 259, 9)
            vlam.Value = Mid(line, 268, 11)
            dsct.Value = Mid(line, 281, 7)
            pdsc.Value = Mid(line, 288, 13)
            cvat.Value = Mid(line, 301, 1)
            rout.Value = Mid(line, 302, 6)
            taxs.Value = Mid(line, 308, 13)
            fret.Value = Mid(line, 321, 13)
            adtl.Value = Mid(line, 334, 13)
            pnet.Value = Mid(line, 347, 13)
            uprc.Value = Mid(line, 360, 9)
            ref1.Value = Mid(line, 369, 8)
            cmcd.Value = Mid(line, 377, 3)
            ref2.Value = Mid(line, 380, 8)
            sodt.Value = Mid(line, 388, 8)
            term.Value = Mid(line, 396, 6)
            edte.Value = Mid(line, 402, 8)
            lotno.Value = Mid(line, 410, 15)
            slmno.Value = Mid(line, 425, 3)
            slnm.Value = Mid(line, 428, 24)
            shipto.Value = Mid(line, 452, 50)
            sad1.Value = Mid(line, 502, 50)
            sad2.Value = Mid(line, 552, 50)
            zipc.Value = Mid(line, 602, 6)
            terno.Value = Mid(line, 608, 3)
            area.Value = Mid(line, 611, 3)
            ccls.Value = Mid(line, 614, 3)
            clsn.Value = Mid(line, 617, 24)
            prin.Value = Mid(line, 641, 3)
            sprn.Value = Mid(line, 644, 6)
            prdc.Value = Mid(line, 650, 3)
            swek.Value = Mid(line, 653, 1)
            Try
                myCommand.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Insert_TextFile Module")
            End Try
        Next
    End Sub
    Public Sub ExecuteNonQuery(ByVal Params() As SqlParameter, ByVal StoredProcedure As String)
        Dim myCommand As New SqlCommand
        With myCommand
            .Connection = objConnection(ServerPath2)
            .CommandText = StoredProcedure
            .CommandType = CommandType.StoredProcedure
            Dim i As Integer
            For i = 0 To Params.GetUpperBound(0)
                .Parameters.Add(Params(i))
            Next
            .ExecuteNonQuery()
        End With
    End Sub
End Module
