Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim amount As Decimal
        Decimal.TryParse(USDTextbox.Text, amount)
        Dim fee As Decimal
        fee = amount * 0.85
        EGPTextBox.Text = fee.ToString("C2")

        Dim Money As Decimal
        Decimal.TryParse(USDTextbox.Text, Money)
        Dim Moremoney As Decimal
        Moremoney = Money * 19.19
        TextBox1.Text = Moremoney.ToString("C2")

        Dim Dollar As Decimal
        Decimal.TryParse(USDTextbox.Text, Dollar)
        Dim Yen As Decimal
        Yen = Dollar * 137.12
        YenTextBox.Text = Yen.ToString("C2")

        Dim Dollars As Decimal
        Decimal.TryParse(USDTextbox.Text, Dollars)
        Dim Euro As Decimal
        Euro = Dollars * 1
        EuroTextBox.Text = Euro.ToString("C2")

        Dim Bucks As Decimal
        Decimal.TryParse(USDTextbox.Text, Bucks)
        Dim Shillings As Decimal
        Shillings = Bucks * 569.5
        ShillingTextBox.Text = Shillings.ToString("C2")

        Dim Buckaroos As Decimal
        Decimal.TryParse(USDTextbox.Text, Buckaroos)
        Dim Yuan As Decimal
        Yuan = Buckaroos * 6.86
        YuanTextBox.Text = Yuan.ToString("C2")
    End Sub
End Class
