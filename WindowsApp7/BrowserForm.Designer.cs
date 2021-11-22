using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApp7
{
    [DesignerGenerated()]
    public partial class BrowserForm : Form
    {

        // Form remplace la méthode Dispose pour nettoyer la liste des composants.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Requise par le Concepteur Windows Form
        private System.ComponentModel.IContainer components;

        // REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
        // Elle peut être modifiée à l'aide du Concepteur Windows Form.  
        // Ne la modifiez pas à l'aide de l'éditeur de code.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.Guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.CefPanel = new Guna.UI2.WinForms.Guna2Panel();
            this._Guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this._Guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this._Guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this._Guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Guna2Panel1
            // 
            this.Guna2Panel1.BackColor = System.Drawing.Color.White;
            this.Guna2Panel1.Controls.Add(this.guna2Button1);
            this.Guna2Panel1.Controls.Add(this._Guna2Button5);
            this.Guna2Panel1.Controls.Add(this.Guna2TextBox1);
            this.Guna2Panel1.Controls.Add(this._Guna2Button3);
            this.Guna2Panel1.Controls.Add(this._Guna2Button2);
            this.Guna2Panel1.Controls.Add(this._Guna2Button1);
            this.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.Guna2Panel1.Name = "Guna2Panel1";
            this.Guna2Panel1.ShadowDecoration.Parent = this.Guna2Panel1;
            this.Guna2Panel1.Size = new System.Drawing.Size(800, 48);
            this.Guna2Panel1.TabIndex = 0;
            // 
            // CefPanel
            // 
            this.CefPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CefPanel.Location = new System.Drawing.Point(0, 48);
            this.CefPanel.Name = "CefPanel";
            this.CefPanel.ShadowDecoration.Parent = this.CefPanel;
            this.CefPanel.Size = new System.Drawing.Size(800, 402);
            this.CefPanel.TabIndex = 0;
            // 
            // _Guna2Button5
            // 
            this._Guna2Button5.CheckedState.Parent = this._Guna2Button5;
            this._Guna2Button5.CustomImages.Parent = this._Guna2Button5;
            this._Guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this._Guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this._Guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this._Guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this._Guna2Button5.DisabledState.Parent = this._Guna2Button5;
            this._Guna2Button5.Dock = System.Windows.Forms.DockStyle.Right;
            this._Guna2Button5.FillColor = System.Drawing.Color.White;
            this._Guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._Guna2Button5.ForeColor = System.Drawing.Color.Black;
            this._Guna2Button5.HoverState.Parent = this._Guna2Button5;
            this._Guna2Button5.Image = global::WindowsApp7.My.Resources.Resources.icons8_go_48;
            this._Guna2Button5.ImageSize = new System.Drawing.Size(48, 48);
            this._Guna2Button5.Location = new System.Drawing.Point(748, 0);
            this._Guna2Button5.Name = "_Guna2Button5";
            this._Guna2Button5.ShadowDecoration.Parent = this._Guna2Button5;
            this._Guna2Button5.Size = new System.Drawing.Size(52, 48);
            this._Guna2Button5.TabIndex = 5;
            this._Guna2Button5.Click += new System.EventHandler(this.Guna2Button5_Click);
            // 
            // Guna2TextBox1
            // 
            this.Guna2TextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2TextBox1.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.Guna2TextBox1.BorderRadius = 6;
            this.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Guna2TextBox1.DefaultText = "";
            this.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Guna2TextBox1.DisabledState.Parent = this.Guna2TextBox1;
            this.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2TextBox1.FocusedState.Parent = this.Guna2TextBox1;
            this.Guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Guna2TextBox1.HoverState.Parent = this.Guna2TextBox1;
            this.Guna2TextBox1.IconLeft = global::WindowsApp7.My.Resources.Resources.icons8_protect_48px1;
            this.Guna2TextBox1.Location = new System.Drawing.Point(214, 3);
            this.Guna2TextBox1.Name = "Guna2TextBox1";
            this.Guna2TextBox1.PasswordChar = '\0';
            this.Guna2TextBox1.PlaceholderText = "";
            this.Guna2TextBox1.SelectedText = "";
            this.Guna2TextBox1.ShadowDecoration.Parent = this.Guna2TextBox1;
            this.Guna2TextBox1.Size = new System.Drawing.Size(528, 42);
            this.Guna2TextBox1.TabIndex = 3;
            this.Guna2TextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.guna2TextBox1_KeyDown);
            // 
            // _Guna2Button3
            // 
            this._Guna2Button3.CheckedState.Parent = this._Guna2Button3;
            this._Guna2Button3.CustomImages.Parent = this._Guna2Button3;
            this._Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this._Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this._Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this._Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this._Guna2Button3.DisabledState.Parent = this._Guna2Button3;
            this._Guna2Button3.Dock = System.Windows.Forms.DockStyle.Left;
            this._Guna2Button3.FillColor = System.Drawing.Color.White;
            this._Guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._Guna2Button3.ForeColor = System.Drawing.Color.Black;
            this._Guna2Button3.HoverState.Parent = this._Guna2Button3;
            this._Guna2Button3.Image = global::WindowsApp7.My.Resources.Resources.icons8_home_48;
            this._Guna2Button3.ImageSize = new System.Drawing.Size(48, 48);
            this._Guna2Button3.Location = new System.Drawing.Point(104, 0);
            this._Guna2Button3.Name = "_Guna2Button3";
            this._Guna2Button3.ShadowDecoration.Parent = this._Guna2Button3;
            this._Guna2Button3.Size = new System.Drawing.Size(52, 48);
            this._Guna2Button3.TabIndex = 2;
            this._Guna2Button3.Click += new System.EventHandler(this.Guna2Button3_Click);
            // 
            // _Guna2Button2
            // 
            this._Guna2Button2.CheckedState.Parent = this._Guna2Button2;
            this._Guna2Button2.CustomImages.Parent = this._Guna2Button2;
            this._Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this._Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this._Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this._Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this._Guna2Button2.DisabledState.Parent = this._Guna2Button2;
            this._Guna2Button2.Dock = System.Windows.Forms.DockStyle.Left;
            this._Guna2Button2.FillColor = System.Drawing.Color.White;
            this._Guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._Guna2Button2.ForeColor = System.Drawing.Color.Black;
            this._Guna2Button2.HoverState.Parent = this._Guna2Button2;
            this._Guna2Button2.Image = global::WindowsApp7.My.Resources.Resources.icons8_forward_48;
            this._Guna2Button2.ImageSize = new System.Drawing.Size(48, 48);
            this._Guna2Button2.Location = new System.Drawing.Point(52, 0);
            this._Guna2Button2.Name = "_Guna2Button2";
            this._Guna2Button2.ShadowDecoration.Parent = this._Guna2Button2;
            this._Guna2Button2.Size = new System.Drawing.Size(52, 48);
            this._Guna2Button2.TabIndex = 1;
            this._Guna2Button2.Click += new System.EventHandler(this.Guna2Button2_Click);
            // 
            // _Guna2Button1
            // 
            this._Guna2Button1.CheckedState.Parent = this._Guna2Button1;
            this._Guna2Button1.CustomImages.Parent = this._Guna2Button1;
            this._Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this._Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this._Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this._Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this._Guna2Button1.DisabledState.Parent = this._Guna2Button1;
            this._Guna2Button1.Dock = System.Windows.Forms.DockStyle.Left;
            this._Guna2Button1.FillColor = System.Drawing.Color.White;
            this._Guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._Guna2Button1.ForeColor = System.Drawing.Color.Black;
            this._Guna2Button1.HoverState.Parent = this._Guna2Button1;
            this._Guna2Button1.Image = global::WindowsApp7.My.Resources.Resources.icons8_back_48;
            this._Guna2Button1.ImageSize = new System.Drawing.Size(48, 48);
            this._Guna2Button1.Location = new System.Drawing.Point(0, 0);
            this._Guna2Button1.Name = "_Guna2Button1";
            this._Guna2Button1.ShadowDecoration.Parent = this._Guna2Button1;
            this._Guna2Button1.Size = new System.Drawing.Size(52, 48);
            this._Guna2Button1.TabIndex = 0;
            this._Guna2Button1.Click += new System.EventHandler(this.Guna2Button1_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::WindowsApp7.My.Resources.Resources.icons8_backend_development_48;
            this.guna2Button1.ImageSize = new System.Drawing.Size(48, 48);
            this.guna2Button1.Location = new System.Drawing.Point(156, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(52, 48);
            this.guna2Button1.TabIndex = 6;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // BrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CefPanel);
            this.Controls.Add(this.Guna2Panel1);
            this.Name = "BrowserForm";
            this.Text = "BrowserForm";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        internal Guna.UI2.WinForms.Guna2Panel Guna2Panel1;
        internal Guna.UI2.WinForms.Guna2Panel CefPanel;
        private Guna.UI2.WinForms.Guna2Button _Guna2Button2;

        internal Guna.UI2.WinForms.Guna2Button Guna2Button2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Guna2Button2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Guna2Button2 != null)
                {
                    _Guna2Button2.Click -= Guna2Button2_Click;
                }

                _Guna2Button2 = value;
                if (_Guna2Button2 != null)
                {
                    _Guna2Button2.Click += Guna2Button2_Click;
                }
            }
        }

        private Guna.UI2.WinForms.Guna2Button _Guna2Button1;

        internal Guna.UI2.WinForms.Guna2Button Guna2Button1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Guna2Button1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Guna2Button1 != null)
                {
                    _Guna2Button1.Click -= Guna2Button1_Click;
                }

                _Guna2Button1 = value;
                if (_Guna2Button1 != null)
                {
                    _Guna2Button1.Click += Guna2Button1_Click;
                }
            }
        }

        private Guna.UI2.WinForms.Guna2Button _Guna2Button5;

        internal Guna.UI2.WinForms.Guna2Button Guna2Button5
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Guna2Button5;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Guna2Button5 != null)
                {
                    _Guna2Button5.Click -= Guna2Button5_Click;
                }

                _Guna2Button5 = value;
                if (_Guna2Button5 != null)
                {
                    _Guna2Button5.Click += Guna2Button5_Click;
                }
            }
        }

        internal Guna.UI2.WinForms.Guna2TextBox Guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button _Guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;

        internal Guna.UI2.WinForms.Guna2Button Guna2Button3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Guna2Button3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Guna2Button3 != null)
                {
                    _Guna2Button3.Click -= Guna2Button3_Click;
                }

                _Guna2Button3 = value;
                if (_Guna2Button3 != null)
                {
                    _Guna2Button3.Click += Guna2Button3_Click;
                }
            }
        }
    }
}