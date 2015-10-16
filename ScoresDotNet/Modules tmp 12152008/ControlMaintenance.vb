Module ControlMaintenance
    Public Sub YearValuesForComboBox(ByVal myComboBox As ComboBox)
        Dim myYear As Integer
        Dim myCounter As Integer
        myYear = Year(Now())
        myCounter = myYear - 4
        With myComboBox
            For myCounter = myCounter To myYear
                .Items.Add(myCounter)
            Next
            For myCounter = myYear + 1 To myYear + 3
                .Items.Add(myCounter)
            Next
            .Text = CStr(Year(Now()))
        End With
    End Sub
    Public Sub FormatMoneyText(ByVal myTextBox As TextBox)
        myTextBox.Text = Format(CLng(myTextBox.Text), "#,##0.00")
    End Sub
    Public Sub EnableControls(ByVal MyForm As Form, ByVal bln As Boolean)
        Dim myControl As Control
        Dim mystring As String
        For Each myControl In MyForm.Controls
            Select Case CStr(myControl.Tag)
                Case "Input", "Numeric"
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
    Public Sub ClearInputControls(ByVal myForm As Form)
        Dim myControl As Control
        For Each myControl In myForm.Controls
            Select Case CStr(myControl.Tag)
                Case "Input"
                    myControl.Text = ""
                Case "Numeric"
                    myControl.Text = "0"
            End Select
        Next
    End Sub
End Module
