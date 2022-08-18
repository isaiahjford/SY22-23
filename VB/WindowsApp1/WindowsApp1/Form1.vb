Public Class speedForm1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox.Image = bronpicturebox.Image
        nameLabel4.Text = "lebron"
        heightLabel5.Text = "6'9"
        abiltyLabel6.Text = "foul"
        speedlabel.Text = "medium"
        handlesLabel7.Text = "7/10"

    End Sub

    Private Sub SpeedForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub speedForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox3.Image = bronpicturebox.Image
        nameLabel4.Text = "Ginnis"
        heightLabel5.Text = "6'11"
        abiltyLabel6.Text = "Dunk"
        speedlabel.Text = "fast"
        handlesLabel7.Text = "5/10"
    End Sub
End Class
