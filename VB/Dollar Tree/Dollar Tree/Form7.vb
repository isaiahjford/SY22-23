Public Class Form7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SplatoonTextBox.Text = splatoon
        NBA2kTextBox.Text = nba2k23
        SaintsrowTextBox.Text = saintsrow
        GTATextBox.Text = gta
        DoomTextBox.Text = doom


    End Sub

    Private Sub SplatoonTextBox_TextChanged(sender As Object, e As EventArgs) Handles SplatoonTextBox.TextChanged

    End Sub

    Private Sub GrandtotalButton_Click(sender As Object, e As EventArgs) Handles GrandtotalButton.Click
        GrandtotalButton.Text = splatoon * 56.99 + nba2k23 * 59.99 + saintsrow * 59.99 + gta * 39.99 + doom * 39.99


    End Sub
End Class