using System;
using System.Windows.Forms;

namespace WindowsApp7
{
    public partial class BrowserTabHandler
    {
        public BrowserTabHandler()
        {
            InitializeComponent();
            _Guna2Button1.Name = "Guna2Button1";
            _Guna2Button2.Name = "Guna2Button2";
            _Guna2Button3.Name = "Guna2Button3";
            _Guna2Button4.Name = "Guna2Button4";
            _Guna2Button5.Name = "Guna2Button5";
            _AboutSedgeToolStripMenuItem.Name = "AboutSedgeToolStripMenuItem";
            _SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Guna2Button2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void Guna2Button3_Click(object sender, EventArgs e)
        {
            var bf = new BrowserForm();
            var mtp = new TabPage();
            bf.TopLevel = false;
            bf.Dock = DockStyle.Fill;
            bf.FormBorderStyle = FormBorderStyle.None;
            mtp.Controls.Add(bf);
            MetroTabControl1.TabPages.Add(mtp);
            mtp.Text = "Tab " + MetroTabControl1.TabCount.ToString();
            bf.Show();
        }
        public static void SetCurrentTabTitle(string title)
        {
            MetroTabControl1.SelectedTab.Text = title;
        }
        private void Guna2Button4_Click(object sender, EventArgs e)
        {
            if (MetroTabControl1.TabCount == 1)
            {
                Close();
            }
            else
            {
                MetroTabControl1.TabPages.Remove(MetroTabControl1.SelectedTab);
            }
        }

        private void AboutSedgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bf = new AboutSedge();
            var mtp = new TabPage();
            bf.TopLevel = false;
            bf.Dock = DockStyle.Fill;
            bf.FormBorderStyle = FormBorderStyle.None;
            mtp.Controls.Add(bf);
            MetroTabControl1.TabPages.Add(mtp);
            mtp.Text = "About Sedge";
            bf.Show();
        }

        private void BrowserTabHandler_Load(object sender, EventArgs e)
        {
            if (MetroTabControl1.TabCount == 0)
            {
                var bf = new BrowserForm();
                var mtp = new TabPage();
                bf.TopLevel = false;
                bf.Dock = DockStyle.Fill;
                bf.FormBorderStyle = FormBorderStyle.None;
                mtp.Controls.Add(bf);
                MetroTabControl1.TabPages.Add(mtp);
                mtp.Text = "Tab " + MetroTabControl1.TabCount.ToString();
                bf.Show();
            }
        }

        private void Guna2Button5_Click(object sender, EventArgs e)
        {
            MetroContextMenu1.Show();
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bf = new Settings();
            var mtp = new TabPage();
            bf.TopLevel = false;
            bf.Dock = DockStyle.Fill;
            bf.FormBorderStyle = FormBorderStyle.None;
            mtp.Controls.Add(bf);
            MetroTabControl1.TabPages.Add(mtp);
            mtp.Text = "Tab " + MetroTabControl1.TabCount.ToString();
            bf.Show();
        }

        private void developerToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}