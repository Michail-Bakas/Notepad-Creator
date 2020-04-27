Public Class Help
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)
        Text += "

Number of criteria:From 1 to 20
Weight: 0-1
Criterion Types:-1/1 (Where -1=MIN and 1=MAX)
Function Type:From 1 to 6
Q: Numbers
P: Numbers
S: Numbers

"
    End Sub

    Private Sub TextBox1_TextChanged_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class