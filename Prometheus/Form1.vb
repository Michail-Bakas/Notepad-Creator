Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox99.TextChanged, TextBox92.TextChanged, TextBox85.TextChanged, TextBox8.TextChanged, TextBox78.TextChanged, TextBox71.TextChanged, TextBox64.TextChanged, TextBox57.TextChanged, TextBox50.TextChanged, TextBox43.TextChanged, TextBox36.TextChanged, TextBox29.TextChanged, TextBox22.TextChanged, TextBox15.TextChanged, TextBox134.TextChanged, TextBox127.TextChanged, TextBox120.TextChanged, TextBox113.TextChanged, TextBox106.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged, TextBox93.TextChanged, TextBox9.TextChanged, TextBox86.TextChanged, TextBox79.TextChanged, TextBox72.TextChanged, TextBox65.TextChanged, TextBox58.TextChanged, TextBox51.TextChanged, TextBox44.TextChanged, TextBox37.TextChanged, TextBox30.TextChanged, TextBox23.TextChanged, TextBox16.TextChanged, TextBox135.TextChanged, TextBox128.TextChanged, TextBox121.TextChanged, TextBox114.TextChanged, TextBox107.TextChanged, TextBox100.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged, TextBox95.TextChanged, TextBox88.TextChanged, TextBox81.TextChanged, TextBox74.TextChanged, TextBox67.TextChanged, TextBox60.TextChanged, TextBox53.TextChanged, TextBox46.TextChanged, TextBox39.TextChanged, TextBox32.TextChanged, TextBox25.TextChanged, TextBox18.TextChanged, TextBox137.TextChanged, TextBox130.TextChanged, TextBox123.TextChanged, TextBox116.TextChanged, TextBox11.TextChanged, TextBox109.TextChanged, TextBox102.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox141.Clear()


        TextBox141.AppendText(TextBox1.Text + vbTab + TextBox8.Text + vbTab + TextBox15.Text + vbTab + TextBox22.Text + vbTab + TextBox29.Text + vbTab + TextBox36.Text + vbTab + TextBox43.Text + vbTab + TextBox50.Text + vbTab + TextBox57.Text + vbTab + TextBox64.Text + vbTab + TextBox71.Text + vbTab + TextBox78.Text + vbTab + TextBox85.Text + vbTab + TextBox92.Text + vbTab + TextBox99.Text + vbTab + TextBox106.Text + vbTab + TextBox113.Text + vbTab + TextBox120.Text + vbTab + TextBox127.Text + vbTab + TextBox134.Text + vbTab + vbNewLine)
        TextBox141.AppendText(TextBox2.Text + vbTab + TextBox9.Text + vbTab + TextBox16.Text + vbTab + TextBox23.Text + vbTab + TextBox30.Text + vbTab + TextBox37.Text + vbTab + TextBox44.Text + vbTab + TextBox51.Text + vbTab + TextBox58.Text + vbTab + TextBox65.Text + vbTab + TextBox72.Text + vbTab + TextBox79.Text + vbTab + TextBox86.Text + vbTab + TextBox93.Text + vbTab + TextBox100.Text + vbTab + TextBox107.Text + vbTab + TextBox114.Text + vbTab + TextBox121.Text + vbTab + TextBox128.Text + vbTab + TextBox135.Text + vbTab + vbNewLine)
        TextBox141.AppendText(TextBox3.Text + vbTab + TextBox10.Text + vbTab + TextBox17.Text + vbTab + TextBox24.Text + vbTab + TextBox31.Text + vbTab + TextBox38.Text + vbTab + TextBox45.Text + vbTab + TextBox52.Text + vbTab + TextBox59.Text + vbTab + TextBox66.Text + vbTab + TextBox73.Text + vbTab + TextBox80.Text + vbTab + TextBox87.Text + vbTab + TextBox94.Text + vbTab + TextBox101.Text + vbTab + TextBox108.Text + vbTab + TextBox115.Text + vbTab + TextBox122.Text + vbTab + TextBox129.Text + vbTab + TextBox136.Text + vbTab + vbNewLine)
        TextBox141.AppendText(TextBox4.Text + vbTab + TextBox11.Text + vbTab + TextBox18.Text + vbTab + TextBox25.Text + vbTab + TextBox32.Text + vbTab + TextBox39.Text + vbTab + TextBox46.Text + vbTab + TextBox53.Text + vbTab + TextBox60.Text + vbTab + TextBox67.Text + vbTab + TextBox74.Text + vbTab + TextBox81.Text + vbTab + TextBox88.Text + vbTab + TextBox95.Text + vbTab + TextBox102.Text + vbTab + TextBox109.Text + vbTab + TextBox116.Text + vbTab + TextBox123.Text + vbTab + TextBox130.Text + vbTab + TextBox137.Text + vbTab + vbNewLine)
        TextBox141.AppendText(TextBox5.Text + vbTab + TextBox12.Text + vbTab + TextBox19.Text + vbTab + TextBox26.Text + vbTab + TextBox33.Text + vbTab + TextBox40.Text + vbTab + TextBox47.Text + vbTab + TextBox54.Text + vbTab + TextBox61.Text + vbTab + TextBox68.Text + vbTab + TextBox75.Text + vbTab + TextBox82.Text + vbTab + TextBox89.Text + vbTab + TextBox96.Text + vbTab + TextBox103.Text + vbTab + TextBox110.Text + vbTab + TextBox117.Text + vbTab + TextBox124.Text + vbTab + TextBox131.Text + vbTab + TextBox138.Text + vbTab + vbNewLine)
        TextBox141.AppendText(TextBox6.Text + vbTab + TextBox13.Text + vbTab + TextBox20.Text + vbTab + TextBox27.Text + vbTab + TextBox34.Text + vbTab + TextBox41.Text + vbTab + TextBox48.Text + vbTab + TextBox55.Text + vbTab + TextBox62.Text + vbTab + TextBox69.Text + vbTab + TextBox76.Text + vbTab + TextBox83.Text + vbTab + TextBox90.Text + vbTab + TextBox97.Text + vbTab + TextBox104.Text + vbTab + TextBox111.Text + vbTab + TextBox118.Text + vbTab + TextBox125.Text + vbTab + TextBox132.Text + vbTab + TextBox139.Text + vbTab + vbNewLine)










    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click


        Dim iSave As New SaveFileDialog
        iSave.Filter = "txt files (*.txt) |*.txt"
        iSave.FilterIndex = 2
        iSave.RestoreDirectory = False

        If iSave.ShowDialog() = DialogResult.OK Then
            IO.File.WriteAllText(iSave.FileName, TextBox141.Text)



        End If




    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Help.Show()
        Me.Show()

    End Sub



    Private Sub TextBox141_TextChanged(sender As Object, e As EventArgs) Handles TextBox141.TextChanged


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()
        TextBox15.Clear()
        TextBox16.Clear()
        TextBox17.Clear()
        TextBox18.Clear()
        TextBox19.Clear()
        TextBox20.Clear()
        TextBox22.Clear()
        TextBox23.Clear()
        TextBox24.Clear()
        TextBox25.Clear()
        TextBox26.Clear()
        TextBox27.Clear()
        TextBox29.Clear()
        TextBox30.Clear()
        TextBox31.Clear()
        TextBox32.Clear()
        TextBox33.Clear()
        TextBox34.Clear()
        TextBox36.Clear()
        TextBox37.Clear()
        TextBox38.Clear()
        TextBox39.Clear()
        TextBox40.Clear()
        TextBox41.Clear()
        TextBox43.Clear()
        TextBox44.Clear()
        TextBox45.Clear()
        TextBox46.Clear()
        TextBox47.Clear()
        TextBox48.Clear()
        TextBox50.Clear()
        TextBox51.Clear()
        TextBox52.Clear()
        TextBox53.Clear()
        TextBox54.Clear()
        TextBox55.Clear()
        TextBox57.Clear()
        TextBox58.Clear()
        TextBox59.Clear()
        TextBox60.Clear()
        TextBox61.Clear()
        TextBox62.Clear()
        TextBox64.Clear()
        TextBox65.Clear()
        TextBox66.Clear()
        TextBox67.Clear()
        TextBox68.Clear()
        TextBox69.Clear()
        TextBox71.Clear()
        TextBox72.Clear()
        TextBox73.Clear()
        TextBox74.Clear()
        TextBox75.Clear()
        TextBox76.Clear()
        TextBox78.Clear()
        TextBox79.Clear()
        TextBox80.Clear()
        TextBox81.Clear()
        TextBox82.Clear()
        TextBox83.Clear()
        TextBox85.Clear()
        TextBox86.Clear()
        TextBox87.Clear()
        TextBox88.Clear()
        TextBox89.Clear()
        TextBox90.Clear()
        TextBox92.Clear()
        TextBox93.Clear()
        TextBox94.Clear()
        TextBox95.Clear()
        TextBox96.Clear()
        TextBox97.Clear()
        TextBox99.Clear()
        TextBox100.Clear()
        TextBox101.Clear()
        TextBox102.Clear()
        TextBox103.Clear()
        TextBox104.Clear()
        TextBox106.Clear()
        TextBox107.Clear()
        TextBox108.Clear()
        TextBox109.Clear()
        TextBox110.Clear()
        TextBox111.Clear()
        TextBox113.Clear()
        TextBox114.Clear()
        TextBox115.Clear()
        TextBox116.Clear()
        TextBox117.Clear()
        TextBox118.Clear()
        TextBox120.Clear()
        TextBox121.Clear()
        TextBox122.Clear()
        TextBox123.Clear()
        TextBox124.Clear()
        TextBox125.Clear()
        TextBox127.Clear()
        TextBox128.Clear()
        TextBox129.Clear()
        TextBox130.Clear()
        TextBox131.Clear()
        TextBox132.Clear()
        TextBox134.Clear()
        TextBox135.Clear()
        TextBox136.Clear()
        TextBox137.Clear()
        TextBox138.Clear()
        TextBox139.Clear()
        TextBox141.Clear()

    End Sub

    Private Sub TextBox76_TextChanged(sender As Object, e As EventArgs) Handles TextBox76.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
