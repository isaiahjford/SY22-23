Public Class Form1
    Dim Total As Decimal
    Dim TotalPounds As Decimal
    Dim decaf As Decimal
    Dim regualar As Decimal

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Decimal.TryParse(TextBox9.Text, TotalPounds)

        totalTextBox.Text = TotalPounds * 4.99

    End Sub

    Private Sub RTextBox_TextChanged(sender As Object, e As EventArgs) Handles RTextBox.TextChanged
        Decimal.TryParse(RTextBox.Text, regualar)
        RTextBox.Text = regualar
        Decimal.TryParse(TextBox9.Text, TotalPounds)
        TextBox9.Text = TotalPounds
        TextBox9.Text = decaf + regualar

    End Sub

    Private Sub DTextBox_TextChanged(sender As Object, e As EventArgs) Handles DTextBox.TextChanged
        Decimal.TryParse(DTextBox.Text, decaf)
        DTextBox.Text = decaf
        Decimal.TryParse(TextBox9.Text, TotalPounds)
        TextBox9.Text = TotalPounds
        TextBox9.Text = decaf + regualar
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox3 = Nothing
        TextBox1 = Nothing
        TextBox6 = Nothing
        TextBox5 = Nothing
        TextBox4 = Nothing

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
