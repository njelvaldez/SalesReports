Module modControlBehavior
    Public Sub EnableControls(ByVal MyForm As Form, ByVal bln As Boolean)
        Dim myControl As Control
        Dim mystring As String
        For Each myControl In MyForm.Controls
            Select Case CStr(myControl.Tag)
                Case "Input"
                    myControl.Enabled = bln
                Case "Line", "Numeric"
                    myControl.Enabled = bln
                Case "View", "Add", "Exit"
                    myControl.Enabled = Not (bln)
                Case "Edit", "Delete"
                    myControl.Enabled = Not (bln)
                    myControl.Visible = Not (bln)
                Case "Cancel", "Save"
                    myControl.Enabled = bln
                    myControl.Visible = bln
            End Select
        Next
    End Sub
    Public Sub EnableLineControls(ByVal MyForm As Form, ByVal bln As Boolean)
        Dim myControl As Control
        Dim mystring As String
        For Each myControl In MyForm.Controls
            Select Case CStr(myControl.Tag)
                Case "Line", "Numeric"
                    myControl.Enabled = bln
                Case "View", "Add", "Exit"
                    myControl.Enabled = Not (bln)
                Case "Edit", "Delete"
                    myControl.Enabled = Not (bln)
                    myControl.Visible = Not (bln)
                Case "Cancel", "Save"
                    myControl.Enabled = bln
                    myControl.Visible = bln
            End Select
        Next
    End Sub

End Module

