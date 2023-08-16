Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fact, num, i As Integer
        num = TextBox1.Text
        fact = 1
        If num > 1 Then
            For i = 1 To num
                fact = fact * i
            Next
        End If
        ListBox1.Items.Add("The factorial of " & num & " is " & fact)
    End Sub
End Class
