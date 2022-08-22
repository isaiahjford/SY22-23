Public Class speedForm1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        bronpicturebox.Image = PictureBox.Image
        nameLabel4.Text = "lebron james"
        heightLabel5.Text = "6'9"
        abiltyLabel6.Text = "7/10"
        speedlabel.Text = "medium"
        handlesLabel7.Text = "foul"
        Me.BackColor = Color.MediumPurple



    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        bronpicturebox.Image = PictureBox3.Image
        nameLabel4.Text = "Ginnis Antetounkunmpo"
        heightLabel5.Text = "6'11"
        abiltyLabel6.Text = "5/10"
        speedlabel.Text = "fast"
        handlesLabel7.Text = "Dunk"
        Me.BackColor = Color.Green

    End Sub

    Private Sub speedForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        bronpicturebox.Image = PictureBox2.Image
        nameLabel4.Text = "Kevin durant"
        heightLabel5.Text = "6'10"
        abiltyLabel6.Text = "5/10"
        speedlabel.Text = "slow"
        handlesLabel7.Text = "jumpshot"
        Me.BackColor = Color.Gray
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        bronpicturebox.Image = PictureBox1.Image
        nameLabel4.Text = "Kyrie irving"
        heightLabel5.Text = "6'2"
        abiltyLabel6.Text = "11/10"
        speedlabel.Text = "Fast"
        handlesLabel7.Text = "ankle breaker"
        Me.BackColor = Color.LightYellow
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        bronpicturebox.Image = PictureBox4.Image
        nameLabel4.Text = "Steph curry"
        heightLabel5.Text = "6'2"
        abiltyLabel6.Text = "9/10"
        speedlabel.Text = "Fast"
        handlesLabel7.Text = "3 pointer"
        Me.BackColor = Color.Blue

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub
End Class
