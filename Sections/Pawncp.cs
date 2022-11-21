using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualTexture_v2.Sections
{
    public partial class Pawncp : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Pawncp()
        {
            InitializeComponent();

            ChangeBoxText();
            textBox1.Text = RGBToPAWNConverter(pictureBox1.BackColor);
            textBox2.Text = HexConverter(pictureBox1.BackColor);

            timer1.Enabled = true;
            timer1.Interval = 200;
            timer1.Start();
        }

        private void Pawncp1_Load(object sender, EventArgs e)
        {
            /*this.Opacity = 0;
            for (double i = 0; i <= 1; i += 0.1)
            {
                this.Opacity = i;
                this.Refresh();
                System.Threading.Thread.Sleep(15);
            }*/
        }

        // Change pictureBox1
        private void ChangeBoxText()
        {
            pictureBox1.BackColor = (Color.FromArgb(hScrollBar4.Value, hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value));
        }

        // RGB To PAWN Color
        private static String RGBToPAWNConverter(System.Drawing.Color c)
        {
            return "0x" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2") + c.A.ToString("X2");
        }

        // RGB To HEX Color
        private static String HexConverter(System.Drawing.Color c)
        {
            return "{" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2") + "}";
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            Color preview = Color.FromArgb(hScrollBar4.Value, hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            pictureBox1.BackColor = preview;

            textBox1.Text = RGBToPAWNConverter(pictureBox1.BackColor);
            textBox2.Text = HexConverter(pictureBox1.BackColor);
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            ChangeBoxText();
            textBox1.Text = RGBToPAWNConverter(pictureBox1.BackColor); ;
            textBox2.Text = HexConverter(pictureBox1.BackColor);

        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            ChangeBoxText();
            textBox1.Text = RGBToPAWNConverter(pictureBox1.BackColor); ;
            textBox2.Text = HexConverter(pictureBox1.BackColor);
        }

        private void hScrollBar4_Scroll(object sender, ScrollEventArgs e)
        {

            ChangeBoxText();
            textBox1.Text = RGBToPAWNConverter(pictureBox1.BackColor);
            textBox2.Text = HexConverter(pictureBox1.BackColor);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            random = new Random();
            label1.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
        }

        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            this.Opacity = 1;
            for (double i = 1; i >= 0; i -= 0.1)
            {
                this.Opacity = i;
                this.Refresh();
                System.Threading.Thread.Sleep(15);
            }
            Application.Exit();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            //this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/Zume-Zero");
        }

        private void Pawncp1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void panel1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void panel2_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Index Component1 = new Index();
            Component1.Show();
        }

        private void btnAnimations_Click(object sender, EventArgs e)
        {
            this.Hide();
            Animations Component1 = new Animations();
            Component1.Show();
            MessageBox.Show("Hello! In case the first animation you select doesn't load correctly, select another one again so that the page reloads. :)");
        }

        private void btnTextures_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sections.Textures Component1 = new Sections.Textures();
            Component1.Show();
        }
        private void btnSpray_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sections.VSprites Component1 = new Sections.VSprites();
            Component1.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
