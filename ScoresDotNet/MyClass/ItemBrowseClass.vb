Public Class ItemBrowseClass

    Private _sItemCode, _sDivisionName, _sItemDesc As String
    Private Delegate Function _xDelMyTabpageControl1(ByVal _delValue1 As String, _
                                                ByVal _delValue2 As String, _
                                                ByVal _delValue3 As String) As String

    Public Property xItemCode() As String
        Get
            Return _sItemCode
        End Get
        Set(ByVal Value As String)
            _sItemCode = Value
        End Set
    End Property

    Public Property xItemDesc() As String
        Get
            Return _sItemDesc
        End Get
        Set(ByVal Value As String)
            _sItemDesc = Value
        End Set
    End Property

    Public Property xDivisionName() As String
        Get
            Return _sDivisionName
        End Get
        Set(ByVal Value As String)
            _sDivisionName = Value
        End Set
    End Property
End Class
