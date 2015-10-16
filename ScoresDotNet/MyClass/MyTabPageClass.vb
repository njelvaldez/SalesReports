Public Class MyTabPageClass
    Inherits TabPage

    Private _myUC As New MyTabPageControl1

    Sub New()
        Me._myUC = New MyTabPageControl1
        Me.Controls.Add(Me._myUC)
    End Sub

End Class
