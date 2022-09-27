Public Class Form1
    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        Dim length As Integer
        Dim width As Integer
        Integer.TryParse(LengthTextBox.Text, length)
        Integer.TryParse(WidthTextBox.Text, width)
        AreaLabel.Text = area(length, width)
        PerimeterLabel.Text = perimeater(length, width)

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        clear()
        highlight(Color.Yellow)
    End Sub
    Sub clear()
        Me.LengthTextBox.Clear()
        Me.WidthTextBox.Clear()
        Me.AreaLabel.Text = ""
        Me.PerimeterLabel.Text = ""
    End Sub
    Sub highlight(C As Color)
        LengthTextBox.BackColor = C
        WidthTextBox.BackColor = C
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click
        highlight(sender.backcolor)
    End Sub
    Function area(L As Integer, W As Integer) As Integer
        Return L * W
    End Function
    Function perimeater(L As Integer, W As Integer) As Integer
        Return 2 * (L + W)
    End Function
    Function CircleArea(radius As Integer) As Decimal
        Return Math.PI * radius * radius
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Radius As Integer
        Integer.TryParse(LengthTextBox.Text, Radius)
        AreaLabel.Text = CircleArea(Radius)
    End Sub
End Class
