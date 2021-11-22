using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApp7
{
    [DesignerGenerated()]
    public partial class AboutSedge : Form
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
            Label1 = new Label();
            PictureBox1 = new PictureBox();
            Label2 = new Label();
            Label3 = new Label();
            Label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
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
            Guna2Button1.TabIndex = 0;
            Guna2Button1.Text = "About Sipaa Edge";
            Guna2Button1.TextAlign = HorizontalAlignment.Left;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Comic Sans MS", 16.25f);
            Label1.Location = new Point(12, 59);
            Label1.Name = "Label1";
            Label1.Size = new Size(68, 30);
            Label1.TabIndex = 1;
            Label1.Text = "Sipaa";
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.SipaaEdge;
            PictureBox1.Location = new Point(76, 59);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(30, 30);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 2;
            PictureBox1.TabStop = false;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI", 16.25f, FontStyle.Bold);
            Label2.Location = new Point(12, 92);
            Label2.Name = "Label2";
            Label2.Size = new Size(281, 30);
            Label2.TabIndex = 3;
            Label2.Text = "Version ChromiumVersion";
            // 
            // Label3
            // 
            Label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI", 16.25f, FontStyle.Bold);
            Label3.Location = new Point(12, 381);
            Label3.Name = "Label3";
            Label3.Size = new Size(627, 30);
            Label3.TabIndex = 4;
            Label3.Text = "Sipaa Edge use the Chromium open source project to work.";
            // 
            // Label4
            // 
            Label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Label4.AutoSize = true;
            Label4.Font = new Font("Segoe UI", 16.25f, FontStyle.Bold);
            Label4.Location = new Point(12, 411);
            Label4.Name = "Label4";
            Label4.Size = new Size(398, 30);
            Label4.TabIndex = 5;
            Label4.Text = "Copyright Sipa Env 2020-currentyear";
            // 
            // AboutSedge
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(PictureBox1);
            Controls.Add(Label1);
            Controls.Add(Guna2Button1);
            Name = "AboutSedge";
            Text = "AboutSedge";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(AboutSedge_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal Guna.UI2.WinForms.Guna2Button Guna2Button1;
        internal Label Label1;
        internal PictureBox PictureBox1;
        internal Label Label2;
        internal Label Label3;
        internal Label Label4;
    }
}