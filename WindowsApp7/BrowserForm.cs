using System;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace WindowsApp7
{
    public partial class BrowserForm
    {
        public BrowserForm()
        {
            InitializeComponent();
            _Guna2Button5.Name = "Guna2Button5";
            _Guna2Button3.Name = "Guna2Button3";
            _Guna2Button2.Name = "Guna2Button2";
            _Guna2Button1.Name = "Guna2Button1";
        }

        internal ChromiumWebBrowser browser;
        private CefSettings settings;
        private string appdata = Environment.GetEnvironmentVariable(((int)Environment.SpecialFolder.LocalApplicationData).ToString());

        private void Form_Load(object sender, EventArgs e)
        {
            Console.WriteLine("User Local AppData folder : " + appdata);
            settings = new CefSettings();
            settings.CachePath = Environment.GetEnvironmentVariable(((int)Environment.SpecialFolder.LocalApplicationData).ToString()) + @"\SipaaOS\Sedge\Cache";
            settings.Locale = "en-us";
            browser = new ChromiumWebBrowser(My.MySettingsProperty.Settings.DefaultHomePage);
            browser.JsDialogHandler = new CefSharp.Example.Handlers.JSDialogHandler();
            browser.DownloadHandler = new CefSharp.Example.Handlers.DownloadHandler();
            browser.Dock = DockStyle.Fill;
            browser.AddressChanged += Browser_AddressChanged;
            browser.TitleChanged += Browser_TitleChanged;
            browser.JavascriptMessageReceived += Browser_JavascriptMessageReceived;
            CefPanel.Controls.Add(browser);
        }

        private void Browser_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                BrowserTabHandler.SetCurrentTabTitle(e.Title);
            }));
        }

        private void Browser_JavascriptMessageReceived(object sender, JavascriptMessageReceivedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                var toast = new SipaFramework.SipaNotification();
                toast.showAlert(e.Message.ToString(),SipaFramework.SipaNotification.enmType.Info, "SipaaEdge : Javascript Toast", WindowsApp7.My.Resources.Resources.SipaaEdge);
            }));
        }

        private void Browser_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                Guna2TextBox1.Text = e.Address;
                if(e.Address.Contains("https://"))
                {
                    Console.WriteLine("The website " + e.Address + " contains the 'https' protocol!");
                    Guna2TextBox1.IconLeft = WindowsApp7.My.Resources.Resources.icons8_protect_48px;
                } else { Console.WriteLine("The website " + e.Address + " contains the 'http' protocol , It's not secure."); Guna2TextBox1.IconLeft = WindowsApp7.My.Resources.Resources.icons8_delete_shield_48px; }
            }));
        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            browser.Back();
        }

        private void Guna2Button2_Click(object sender, EventArgs e)
        {
            browser.Forward();
        }

        private void Guna2Button3_Click(object sender, EventArgs e)
        {
            browser.Load(My.MySettingsProperty.Settings.DefaultHomePage);
        }

        private void Guna2Button5_Click(object sender, EventArgs e)
        {
            browser.Load(Guna2TextBox1.Text);
        }

        private void guna2TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            browser.Load(Guna2TextBox1.Text);
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            browser.ShowDevTools();
        }
    }
}