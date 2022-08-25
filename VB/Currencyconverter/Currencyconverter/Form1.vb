Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim amount As Decimal
        Decimal.TryParse(USDTextbox.Text, amount)
        Dim fee As Decimal
        fee = amount * 0.8467
        EGPTextBox.Text = fee.ToString("C2")
    End Sub
End Class
