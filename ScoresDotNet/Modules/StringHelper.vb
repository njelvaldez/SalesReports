Module StringHelper
    Public Function GetWordByIndex(ByVal words As String, ByVal index As Integer) As String
        Dim retval As String = ""
        Try
            Dim WordArray() As String = Split(words)
            retval = WordArray(index)
        Catch ex As Exception

        End Try
        Return retval
    End Function

    Public Function Get50Chars(ByVal words As String) As String
        Dim retval As String = words
        Try
            words = words.Trim
            If words.Length >= 50 Then
                words = words.Substring(0, 49)
                retval = words
            End If
        Catch ex As Exception

        End Try
        Return retval
    End Function
End Module
