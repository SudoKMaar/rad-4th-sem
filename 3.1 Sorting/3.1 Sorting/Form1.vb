Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Lines = TextBox1.Lines.Select(Function(x) x.Split({","c}, StringSplitOptions.RemoveEmptyEntries).
                                                   OrderBy(Function(y) Integer.Parse(y))).
                                                   Select(Function(z) String.Join(",", z)).ToArray
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Lines = TextBox1.Lines.Select(Function(x) x.Split({","c}, StringSplitOptions.RemoveEmptyEntries).
                                                   OrderByDescending(Function(y) Integer.Parse(y))).
                                                   Select(Function(z) String.Join(",", z)).ToArray
    End Sub
End Class
