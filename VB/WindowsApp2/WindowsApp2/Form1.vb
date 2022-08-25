Public Class Form1
    Private Sub BuyButton_Click(sender As Object, e As EventArgs) Handles BuyButton.Click
        Dim amount As Decimal
        Decimal.TryParse(AmountTextBox.Text, amount)
        NameTextBox.Clear()
        CreditTextBox.Clear()
        ExpTextBox.Clear()
        zipTextBox.Clear()
        AmountTextBox.Clear()
        Dim fee As Decimal
        fee = amount * 0.03
        FeeTextBox.Text = fee.ToString("C2")
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
