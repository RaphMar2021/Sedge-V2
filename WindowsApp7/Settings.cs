using System;

namespace WindowsApp7
{
    public partial class Settings
    {
        public Settings()
        {
            InitializeComponent();
            _Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1";
            _Guna2CirclePictureBox2.Name = "Guna2CirclePictureBox2";
            _Guna2CirclePictureBox3.Name = "Guna2CirclePictureBox3";
        }

        private void Guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            My.MySettingsProperty.Settings.DefaultHomePage = "google.com";
        }

        private void Guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            My.MySettingsProperty.Settings.DefaultHomePage = "bing.com";
        }

        private void Guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {
            My.MySettingsProperty.Settings.DefaultHomePage = "duckduckgo.com";
        }
    }
}