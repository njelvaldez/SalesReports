Public Class MyComboBoxIndex
    Inherits EventArgs
    Private _iNewValue As Integer

    Public Property xMyComboBoxIndex() As Integer
        Get
            Return _iNewValue
        End Get
        Set(ByVal Value As Integer)
            _iNewValue = Value
        End Set
    End Property

End Class
