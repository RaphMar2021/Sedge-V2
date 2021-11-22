Public Class Settings
    Private Sub Guna2CirclePictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox1.Click
        My.Settings.DefaultHomePage = "google.com"
    End Sub

    Private Sub Guna2CirclePictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox2.Click
        My.Settings.DefaultHomePage = "bing.com"
    End Sub

    Private Sub Guna2CirclePictureBox3_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox3.Click
        My.Settings.DefaultHomePage = "duckduckgo.com"
    End Sub
End Class