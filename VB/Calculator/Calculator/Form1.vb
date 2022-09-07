Public Class Form1
    Dim num1 As Decimal
    Dim num2 As Decimal
    Dim oper As String
    Dim mem As Decimal
    Private Sub button_Click(sender As Object, e As EventArgs) Handles zerobutton.Click, twoButton.Click, threeButton.Click, sixButton.Click, sevenButton.Click, oneButton.Click, nineButton.Click, fourButton.Click, fiveButton.Click, eightbutton.Click, DecimalButton.Click
        Displaytextbox.Text = Displaytextbox.Text + sender.text
    End Sub

    Private Sub Deletebutton_Click(sender As Object, e As EventArgs) Handles Deletebutton.Click
        Displaytextbox.Text = Nothing
    End Sub

    Private Sub PlusButton_Click(sender As Object, e As EventArgs) Handles PlusButton.Click
        Decimal.TryParse(Displaytextbox.Text, num1)
        oper = "+"
        Displaytextbox.Clear()
    End Sub

    Private Sub EqualsButton_Click(sender As Object, e As EventArgs) Handles EqualsButton.Click
        Decimal.TryParse(Displaytextbox.Text, num2)
        If oper = "+" Then
            Displaytextbox.Text = num1 + num2
        End If
        If oper = "-" Then
            Displaytextbox.Text = num1 - num2
        End If
        If oper = "*" Then
            Displaytextbox.Text = num1 * num2
        End If
        If oper = "/" Then
            Displaytextbox.Text = num1 / num2
        End If
    End Sub

    Private Sub MinusButton_Click(sender As Object, e As EventArgs) Handles MinusButton.Click
        Decimal.TryParse(Displaytextbox.Text, num1)
        oper = "-"
        Displaytextbox.Clear()
    End Sub

    Private Sub timesButton_Click(sender As Object, e As EventArgs) Handles timesButton.Click
        Decimal.TryParse(Displaytextbox.Text, num1)
        oper = "*"
        Displaytextbox.Clear()
    End Sub

    Private Sub divisionButton_Click(sender As Object, e As EventArgs) Handles divisionButton.Click
        Decimal.TryParse(Displaytextbox.Text, num1)
        oper = "/"
        Displaytextbox.Clear()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Decimal.TryParse(Displaytextbox.Text, num1)
        Displaytextbox.Text = Math.Sqrt(num1)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Decimal.TryParse(Displaytextbox.Text, num1)
        Displaytextbox.Text = Math.Sin(num1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Decimal.TryParse(Displaytextbox.Text, num1)
        Displaytextbox.Text = Math.Cos(num1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Decimal.TryParse(Displaytextbox.Text, num1)
        Displaytextbox.Text = Math.Sqrt(num1)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Displaytextbox.Text = Math.PI
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Decimal.TryParse(Displaytextbox.Text, mem)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Displaytextbox.Text = mem
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        mem = 0
    End Sub
End Class
