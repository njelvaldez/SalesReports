Public Class MyTabpageClickEventArgs
    Inherits EventArgs
    Private _sClick As String
    Private Property xTabpageClick() As String
        Get
            Return _sClick
        End Get
        Set(ByVal Value As String)
            _sClick = Value
        End Set
    End Property
    Public Sub New(ByVal _iMyClick As String)
        _sClick = _iMyClick
    End Sub
End Class
