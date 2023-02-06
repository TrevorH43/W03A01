Public Class Form1




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim radius As Double = CDbl(TextBox1.Text) / 2
        Dim area As Double = Math.PI * (radius ^ 2)
        Dim slices As Integer CInt(area / 14.125)

        slicesLabel.Text = slices
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = Nothing
        slicesLabel.Text = Nothing
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dateLabel.Text = System.DateTime.Now.ToString()
    End Sub

End Class
