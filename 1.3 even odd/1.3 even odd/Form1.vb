Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer
        Dim isEven As Boolean
        num = Val(TextBox1.Text)
        If num Mod 2 = 0 Then
            isEven = True
            MsgBox("The number " & " " & "  is even number.")
        Else
            MsgBox(num & " is odd number.")
        End If
    End Sub
End Class
