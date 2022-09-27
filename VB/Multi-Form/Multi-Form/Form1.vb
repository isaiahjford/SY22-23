Public Class Form1
    Private Sub GetvaluesButton_Click(sender As Object, e As EventArgs) Handles GetvaluesButton.Click
        Dim n As Integer
        Dim d As Decimal
        Dim s As Single
        Integer.TryParse(ATextBox.Text, n)
        Decimal.TryParse(BTextBox.Text, d)
        Single.TryParse(CTextBox.Text, s)
        Label1.Text = n
        Label2.Text = d
        Label3.Text = s
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.ShowDialog()
        Label3.Text = ball
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.ShowDialog()
        Label3.Text = ball
    End Sub
End Class
