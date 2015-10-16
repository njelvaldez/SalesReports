Imports System.Runtime.InteropServices
Public Class frmBRReports

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        Me.Cursor = Cursors.WaitCursor
        Me.Cursor = Cursors.Default
    End Sub
End Class