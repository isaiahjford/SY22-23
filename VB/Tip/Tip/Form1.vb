Public Class Form1
    Private Sub CalcButton_Click(sender As Object, e As EventArgs) Handles CalcButton.Click

        'Declare a varibal called total
        Dim total As Decimal
        'Gets the value from the form and puts it in total
        Decimal.TryParse(TotalTextBox.Text, total)

        'Get tip amount from user
        Dim tip As Decimal
        Decimal.TryParse(TipTextBox.Text, tip)

        'Does a calculation
        Dim grandtotal As Decimal
        grandtotal = total * 1 + tip

        'This displays the result as a currency with two decimal places
        GrandtotalLabel.Text = grandtotal.ToString("C2")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
