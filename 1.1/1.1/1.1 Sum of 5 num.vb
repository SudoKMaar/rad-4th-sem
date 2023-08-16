Public Class Form1

    Dim num1, num2, num3, num4, num5, total

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        num1 = Val(TextBox1.Text)
        num2 = Val(TextBox2.Text)
        num3 = Val(TextBox3.Text)
        num4 = Val(TextBox4.Text)
        num5 = Val(TextBox5.Text)
        total = num1 + num2 + num3 + num4 + num5
        TextBox6.Text = total

    End Sub
End Class
