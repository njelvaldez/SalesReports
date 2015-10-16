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

    Public Sub EnableControlsGroup(ByVal MyForm As Form, ByVal bln As Boolean)
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
            If myControl.GetType Is GetType(GroupBox) Then
                For Each subcontrol As Control In myControl.Controls
                    Select Case CStr(subcontrol.Tag)
                        Case "Input"
                            subcontrol.Enabled = bln
                        Case "Line", "Numeric"
                            subcontrol.Enabled = bln
                        Case "View", "Add", "Exit"
                            subcontrol.Enabled = Not (bln)
                        Case "Edit", "Delete"
                            subcontrol.Enabled = Not (bln)
                            subcontrol.Visible = Not (bln)
                        Case "Cancel", "Save"
                            subcontrol.Enabled = bln
                            subcontrol.Visible = bln
                    End Select
                Next
            End If
        Next
    End Sub

End Module

