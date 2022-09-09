Public Class Form1
    Private Sub ViewcolorButton_Click(sender As Object, e As EventArgs) Handles ViewcolorButton.Click
        'Change the squares color

        'Declare variables
        Dim inputred As Integer
        Dim inputgreen As Integer
        Dim inputblue As Integer

        'Assign input to variables
        Integer.TryParse(redTextBox.Text, inputred)
        Integer.TryParse(GreentextBox.Text, inputgreen)
        Integer.TryParse(blueTextBox.Text, inputblue)

        'Change color
        Squareshape.BackColor = Color.FromArgb(inputred, inputgreen, inputblue)
    End Sub
End Class
