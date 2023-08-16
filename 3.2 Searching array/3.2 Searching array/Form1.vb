Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim stNum() As Integer = {14, 44, 11, 0, 31, 96, 33, 2, 91, 5}
        Dim stFind As String
        stFind = Me.txtFind.Text
        Dim bFound As Boolean
        For iCount As Integer = 0 To 9
            If stNum(iCount) = stFind Then
                bFound = True
                Exit For
            End If
        Next
        If bFound = True Then
            MsgBox("Found  " & stFind)
        Else
            MsgBox(stFind & " not found")
        End If

    End Sub
End Class
