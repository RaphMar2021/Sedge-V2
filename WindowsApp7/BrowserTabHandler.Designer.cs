using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApp7
{
    [DesignerGenerated()]
    public partial class BrowserTabHandler : Form
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
            this.components = new System.ComponentModel.Container();
            MetroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this._Guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this._Guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.Guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this._Guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this._Guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.MetroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this._AboutSedgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._Guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.MetroContextMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MetroTabControl1
            // 
            MetroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            MetroTabControl1.Location = new System.Drawing.Point(0, 35);
            MetroTabControl1.Name = "MetroTabControl1";
            MetroTabControl1.Size = new System.Drawing.Size(1161, 654);
            MetroTabControl1.TabIndex = 0;
            MetroTabControl1.UseSelectable = true;
            // 
            // _Guna2Button1
            // 
            this._Guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._Guna2Button1.CheckedState.Parent = this._Guna2Button1;
            this._Guna2Button1.CustomImages.Parent = this._Guna2Button1;
            this._Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this._Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this._Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this._Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this._Guna2Button1.DisabledState.Parent = this._Guna2Button1;
            this._Guna2Button1.FillColor = System.Drawing.Color.White;
            this._Guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this._Guna2Button1.ForeColor = System.Drawing.Color.Black;
            this._Guna2Button1.HoverState.Parent = this._Guna2Button1;
            this._Guna2Button1.Location = new System.Drawing.Point(1116, -1);
            this._Guna2Button1.Name = "_Guna2Button1";
            this._Guna2Button1.ShadowDecoration.Parent = this._Guna2Button1;
            this._Guna2Button1.Size = new System.Drawing.Size(45, 30);
            this._Guna2Button1.TabIndex = 1;
            this._Guna2Button1.Text = "X";
            this._Guna2Button1.Click += new System.EventHandler(this.Guna2Button1_Click);
            // 
            // _Guna2Button2
            // 
            this._Guna2Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._Guna2Button2.CheckedState.Parent = this._Guna2Button2;
            this._Guna2Button2.CustomImages.Parent = this._Guna2Button2;
            this._Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this._Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this._Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this._Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this._Guna2Button2.DisabledState.Parent = this._Guna2Button2;
            this._Guna2Button2.FillColor = System.Drawing.Color.White;
            this._Guna2Button2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this._Guna2Button2.ForeColor = System.Drawing.Color.Black;
            this._Guna2Button2.HoverState.Parent = this._Guna2Button2;
            this._Guna2Button2.Location = new System.Drawing.Point(1065, -1);
            this._Guna2Button2.Name = "_Guna2Button2";
            this._Guna2Button2.ShadowDecoration.Parent = this._Guna2Button2;
            this._Guna2Button2.Size = new System.Drawing.Size(45, 30);
            this._Guna2Button2.TabIndex = 2;
            this._Guna2Button2.Text = "O";
            this._Guna2Button2.Click += new System.EventHandler(this.Guna2Button2_Click);
            // 
            // Guna2BorderlessForm1
            // 
            this.Guna2BorderlessForm1.BorderRadius = 11;
            this.Guna2BorderlessForm1.ContainerControl = this;
            this.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.Guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // _Guna2Button3
            // 
            this._Guna2Button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._Guna2Button3.CheckedState.Parent = this._Guna2Button3;
            this._Guna2Button3.CustomImages.Parent = this._Guna2Button3;
            this._Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this._Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this._Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this._Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this._Guna2Button3.DisabledState.Parent = this._Guna2Button3;
            this._Guna2Button3.FillColor = System.Drawing.Color.White;
            this._Guna2Button3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this._Guna2Button3.ForeColor = System.Drawing.Color.Black;
            this._Guna2Button3.HoverState.Parent = this._Guna2Button3;
            this._Guna2Button3.Location = new System.Drawing.Point(963, -1);
            this._Guna2Button3.Name = "_Guna2Button3";
            this._Guna2Button3.ShadowDecoration.Parent = this._Guna2Button3;
            this._Guna2Button3.Size = new System.Drawing.Size(45, 30);
            this._Guna2Button3.TabIndex = 3;
            this._Guna2Button3.Text = "+";
            this._Guna2Button3.Click += new System.EventHandler(this.Guna2Button3_Click);
            // 
            // _Guna2Button4
            // 
            this._Guna2Button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._Guna2Button4.CheckedState.Parent = this._Guna2Button4;
            this._Guna2Button4.CustomImages.Parent = this._Guna2Button4;
            this._Guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this._Guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this._Guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this._Guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this._Guna2Button4.DisabledState.Parent = this._Guna2Button4;
            this._Guna2Button4.FillColor = System.Drawing.Color.White;
            this._Guna2Button4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this._Guna2Button4.ForeColor = System.Drawing.Color.Black;
            this._Guna2Button4.HoverState.Parent = this._Guna2Button4;
            this._Guna2Button4.Location = new System.Drawing.Point(912, -1);
            this._Guna2Button4.Name = "_Guna2Button4";
            this._Guna2Button4.ShadowDecoration.Parent = this._Guna2Button4;
            this._Guna2Button4.Size = new System.Drawing.Size(45, 30);
            this._Guna2Button4.TabIndex = 4;
            this._Guna2Button4.Text = "-";
            this._Guna2Button4.Click += new System.EventHandler(this.Guna2Button4_Click);
            // 
            // MetroContextMenu1
            // 
            this.MetroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._SettingsToolStripMenuItem,
            this._AboutSedgeToolStripMenuItem});
            this.MetroContextMenu1.Name = "MetroContextMenu1";
            this.MetroContextMenu1.Size = new System.Drawing.Size(143, 48);
            // 
            // _AboutSedgeToolStripMenuItem
            // 
            this._AboutSedgeToolStripMenuItem.Image = global::WindowsApp7.My.Resources.Resources.icons8_info_48px;
            this._AboutSedgeToolStripMenuItem.Name = "_AboutSedgeToolStripMenuItem";
            this._AboutSedgeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this._AboutSedgeToolStripMenuItem.Text = "About Sedge";
            this._AboutSedgeToolStripMenuItem.Click += new System.EventHandler(this.AboutSedgeToolStripMenuItem_Click);
            // 
            // _SettingsToolStripMenuItem
            // 
            this._SettingsToolStripMenuItem.Image = global::WindowsApp7.My.Resources.Resources.icons8_settings_48_1_;
            this._SettingsToolStripMenuItem.Name = "_SettingsToolStripMenuItem";
            this._SettingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this._SettingsToolStripMenuItem.Text = "Settings";
            this._SettingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // _Guna2Button5
            // 
            this._Guna2Button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._Guna2Button5.CheckedState.Parent = this._Guna2Button5;
            this._Guna2Button5.CustomImages.Parent = this._Guna2Button5;
            this._Guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this._Guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this._Guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this._Guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this._Guna2Button5.DisabledState.Parent = this._Guna2Button5;
            this._Guna2Button5.FillColor = System.Drawing.Color.White;
            this._Guna2Button5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this._Guna2Button5.ForeColor = System.Drawing.Color.Black;
            this._Guna2Button5.HoverState.Parent = this._Guna2Button5;
            this._Guna2Button5.Image = global::WindowsApp7.My.Resources.Resources.icons8_menu_48_1_;
            this._Guna2Button5.Location = new System.Drawing.Point(1014, -1);
            this._Guna2Button5.Name = "_Guna2Button5";
            this._Guna2Button5.ShadowDecoration.Parent = this._Guna2Button5;
            this._Guna2Button5.Size = new System.Drawing.Size(45, 30);
            this._Guna2Button5.TabIndex = 5;
            this._Guna2Button5.Click += new System.EventHandler(this.Guna2Button5_Click);
            // 
            // BrowserTabHandler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1160, 692);
            this.Controls.Add(this._Guna2Button5);
            this.Controls.Add(this._Guna2Button4);
            this.Controls.Add(this._Guna2Button3);
            this.Controls.Add(this._Guna2Button2);
            this.Controls.Add(this._Guna2Button1);
            this.Controls.Add(MetroTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BrowserTabHandler";
            this.Text = "Sedge";
            this.Load += new System.EventHandler(this.BrowserTabHandler_Load);
            this.MetroContextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
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

        internal Guna.UI2.WinForms.Guna2BorderlessForm Guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button _Guna2Button4;

        internal Guna.UI2.WinForms.Guna2Button Guna2Button4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Guna2Button4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Guna2Button4 != null)
                {
                    _Guna2Button4.Click -= Guna2Button4_Click;
                }

                _Guna2Button4 = value;
                if (_Guna2Button4 != null)
                {
                    _Guna2Button4.Click += Guna2Button4_Click;
                }
            }
        }

        private Guna.UI2.WinForms.Guna2Button _Guna2Button3;

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

        internal MetroFramework.Controls.MetroContextMenu MetroContextMenu1;
        private ToolStripMenuItem _AboutSedgeToolStripMenuItem;

        internal ToolStripMenuItem AboutSedgeToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _AboutSedgeToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_AboutSedgeToolStripMenuItem != null)
                {
                    _AboutSedgeToolStripMenuItem.Click -= AboutSedgeToolStripMenuItem_Click;
                }

                _AboutSedgeToolStripMenuItem = value;
                if (_AboutSedgeToolStripMenuItem != null)
                {
                    _AboutSedgeToolStripMenuItem.Click += AboutSedgeToolStripMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _SettingsToolStripMenuItem;
        protected static internal MetroFramework.Controls.MetroTabControl MetroTabControl1;

        internal ToolStripMenuItem SettingsToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SettingsToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SettingsToolStripMenuItem != null)
                {
                    _SettingsToolStripMenuItem.Click -= SettingsToolStripMenuItem_Click;
                }

                _SettingsToolStripMenuItem = value;
                if (_SettingsToolStripMenuItem != null)
                {
                    _SettingsToolStripMenuItem.Click += SettingsToolStripMenuItem_Click;
                }
            }
        }
    }
}