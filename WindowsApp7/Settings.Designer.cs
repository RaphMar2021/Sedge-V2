using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApp7
{
    [DesignerGenerated()]
    public partial class Settings : Form
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
            Guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            Guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            Guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            Label1 = new Label();
            _Guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            _Guna2CirclePictureBox1.Click += new EventHandler(Guna2CirclePictureBox1_Click);
            _Guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            _Guna2CirclePictureBox2.Click += new EventHandler(Guna2CirclePictureBox2_Click);
            _Guna2CirclePictureBox3 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            _Guna2CirclePictureBox3.Click += new EventHandler(Guna2CirclePictureBox3_Click);
            Guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_Guna2CirclePictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_Guna2CirclePictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_Guna2CirclePictureBox3).BeginInit();
            SuspendLayout();
            // 
            // Guna2Button1
            // 
            Guna2Button1.CheckedState.Parent = Guna2Button1;
            Guna2Button1.CustomImages.Parent = Guna2Button1;
            Guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            Guna2Button1.DisabledState.FillColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(169)), Conversions.ToInteger(Conversions.ToByte(169)), Conversions.ToInteger(Conversions.ToByte(169)));
            Guna2Button1.DisabledState.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(141)), Conversions.ToInteger(Conversions.ToByte(141)), Conversions.ToInteger(Conversions.ToByte(141)));
            Guna2Button1.DisabledState.Parent = Guna2Button1;
            Guna2Button1.Dock = DockStyle.Top;
            Guna2Button1.FillColor = Color.White;
            Guna2Button1.Font = new Font("Segoe UI", 14.0f, FontStyle.Bold);
            Guna2Button1.ForeColor = Color.Black;
            Guna2Button1.HoverState.Parent = Guna2Button1;
            Guna2Button1.Location = new Point(0, 0);
            Guna2Button1.Name = "Guna2Button1";
            Guna2Button1.PressedColor = Color.White;
            Guna2Button1.ShadowDecoration.Parent = Guna2Button1;
            Guna2Button1.Size = new Size(800, 48);
            Guna2Button1.TabIndex = 1;
            Guna2Button1.Text = "Settings";
            Guna2Button1.TextAlign = HorizontalAlignment.Left;
            // 
            // Guna2VScrollBar1
            // 
            Guna2VScrollBar1.BindingContainer = Guna2Panel1;
            Guna2VScrollBar1.HoverState.Parent = null;
            Guna2VScrollBar1.InUpdate = false;
            Guna2VScrollBar1.LargeChange = 385;
            Guna2VScrollBar1.Location = new Point(782, 48);
            Guna2VScrollBar1.Maximum = 449;
            Guna2VScrollBar1.Name = "Guna2VScrollBar1";
            Guna2VScrollBar1.PressedState.Parent = Guna2VScrollBar1;
            Guna2VScrollBar1.ScrollbarSize = 18;
            Guna2VScrollBar1.Size = new Size(18, 402);
            Guna2VScrollBar1.SmallChange = 5;
            Guna2VScrollBar1.TabIndex = 2;
            // 
            // Guna2Panel1
            // 
            Guna2Panel1.AutoScroll = true;
            Guna2Panel1.Controls.Add(_Guna2CirclePictureBox3);
            Guna2Panel1.Controls.Add(_Guna2CirclePictureBox2);
            Guna2Panel1.Controls.Add(_Guna2CirclePictureBox1);
            Guna2Panel1.Controls.Add(Label1);
            Guna2Panel1.Dock = DockStyle.Fill;
            Guna2Panel1.Font = new Font("Segoe UI", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Guna2Panel1.Location = new Point(0, 48);
            Guna2Panel1.Name = "Guna2Panel1";
            Guna2Panel1.ShadowDecoration.Parent = Guna2Panel1;
            Guna2Panel1.Size = new Size(800, 402);
            Guna2Panel1.TabIndex = 3;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(12, 3);
            Label1.Name = "Label1";
            Label1.Size = new Size(126, 21);
            Label1.TabIndex = 0;
            Label1.Text = "Search engine :";
            // 
            // Guna2CirclePictureBox1
            // 
            _Guna2CirclePictureBox1.Image = My.Resources.Resources.icons8_google_48;
            _Guna2CirclePictureBox1.ImageRotate = 0f;
            _Guna2CirclePictureBox1.Location = new Point(16, 27);
            _Guna2CirclePictureBox1.Name = "_Guna2CirclePictureBox1";
            _Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            _Guna2CirclePictureBox1.ShadowDecoration.Parent = _Guna2CirclePictureBox1;
            _Guna2CirclePictureBox1.Size = new Size(64, 64);
            _Guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            _Guna2CirclePictureBox1.TabIndex = 1;
            _Guna2CirclePictureBox1.TabStop = false;
            // 
            // Guna2CirclePictureBox2
            // 
            _Guna2CirclePictureBox2.Image = My.Resources.Resources.icons8_bing_48;
            _Guna2CirclePictureBox2.ImageRotate = 0f;
            _Guna2CirclePictureBox2.Location = new Point(86, 27);
            _Guna2CirclePictureBox2.Name = "_Guna2CirclePictureBox2";
            _Guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            _Guna2CirclePictureBox2.ShadowDecoration.Parent = _Guna2CirclePictureBox2;
            _Guna2CirclePictureBox2.Size = new Size(64, 64);
            _Guna2CirclePictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            _Guna2CirclePictureBox2.TabIndex = 2;
            _Guna2CirclePictureBox2.TabStop = false;
            // 
            // Guna2CirclePictureBox3
            // 
            _Guna2CirclePictureBox3.Image = My.Resources.Resources.icons8_duckduckgo_48;
            _Guna2CirclePictureBox3.ImageRotate = 0f;
            _Guna2CirclePictureBox3.Location = new Point(156, 27);
            _Guna2CirclePictureBox3.Name = "_Guna2CirclePictureBox3";
            _Guna2CirclePictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            _Guna2CirclePictureBox3.ShadowDecoration.Parent = _Guna2CirclePictureBox3;
            _Guna2CirclePictureBox3.Size = new Size(64, 64);
            _Guna2CirclePictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            _Guna2CirclePictureBox3.TabIndex = 3;
            _Guna2CirclePictureBox3.TabStop = false;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Guna2VScrollBar1);
            Controls.Add(Guna2Panel1);
            Controls.Add(Guna2Button1);
            Name = "Settings";
            Text = "Settings";
            Guna2Panel1.ResumeLayout(false);
            Guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_Guna2CirclePictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)_Guna2CirclePictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)_Guna2CirclePictureBox3).EndInit();
            ResumeLayout(false);
        }

        internal Guna.UI2.WinForms.Guna2Button Guna2Button1;
        internal Guna.UI2.WinForms.Guna2VScrollBar Guna2VScrollBar1;
        internal Guna.UI2.WinForms.Guna2Panel Guna2Panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox _Guna2CirclePictureBox3;

        internal Guna.UI2.WinForms.Guna2CirclePictureBox Guna2CirclePictureBox3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Guna2CirclePictureBox3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Guna2CirclePictureBox3 != null)
                {
                    _Guna2CirclePictureBox3.Click -= Guna2CirclePictureBox3_Click;
                }

                _Guna2CirclePictureBox3 = value;
                if (_Guna2CirclePictureBox3 != null)
                {
                    _Guna2CirclePictureBox3.Click += Guna2CirclePictureBox3_Click;
                }
            }
        }

        private Guna.UI2.WinForms.Guna2CirclePictureBox _Guna2CirclePictureBox2;

        internal Guna.UI2.WinForms.Guna2CirclePictureBox Guna2CirclePictureBox2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Guna2CirclePictureBox2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Guna2CirclePictureBox2 != null)
                {
                    _Guna2CirclePictureBox2.Click -= Guna2CirclePictureBox2_Click;
                }

                _Guna2CirclePictureBox2 = value;
                if (_Guna2CirclePictureBox2 != null)
                {
                    _Guna2CirclePictureBox2.Click += Guna2CirclePictureBox2_Click;
                }
            }
        }

        private Guna.UI2.WinForms.Guna2CirclePictureBox _Guna2CirclePictureBox1;

        internal Guna.UI2.WinForms.Guna2CirclePictureBox Guna2CirclePictureBox1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Guna2CirclePictureBox1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Guna2CirclePictureBox1 != null)
                {
                    _Guna2CirclePictureBox1.Click -= Guna2CirclePictureBox1_Click;
                }

                _Guna2CirclePictureBox1 = value;
                if (_Guna2CirclePictureBox1 != null)
                {
                    _Guna2CirclePictureBox1.Click += Guna2CirclePictureBox1_Click;
                }
            }
        }

        internal Label Label1;
    }
}