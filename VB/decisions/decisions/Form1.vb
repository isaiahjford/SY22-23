﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim age As Integer
        Integer.TryParse(TextBox1.Text, age)
        Label1.Text = age
        If age > 17 Then
            Label1.Text = "you can vote"
            Me.BackColor = Color.Green
        Else
            Label1.Text = "you can't vote"
            Me.BackColor = Color.Red
        End If
        If CheckBox1.Checked Then
            Label1.Text = "Thanks for donating"
        End If
    End Sub
End Class
