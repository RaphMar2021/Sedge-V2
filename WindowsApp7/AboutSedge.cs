using System;

namespace WindowsApp7
{
    public partial class AboutSedge
    {
        public AboutSedge()
        {
            InitializeComponent();
        }

        private void AboutSedge_Load(object sender, EventArgs e)
        {
            Label2.Text = "Version " + CefSharp.Cef.ChromiumVersion;
            Label4.Text = "Copyright Sipa Env 2020-" + DateTime.Now.ToString("yyyy");
        }
    }
}