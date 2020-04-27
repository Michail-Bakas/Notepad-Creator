Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

        Try
            System.Diagnostics.Process.Start(<a href="mailto: mixalis.mpakas@gmail.com">Email Me</a>)
        Catch
            'Code to handle the error.
        End Try

    End Sub
End Class