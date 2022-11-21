using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

namespace VisualTexture_v2.Sections
{
    public partial class VSprites : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public IEnumerable<string> mainLocation { get; set; }

        public VSprites()
        {
            InitializeComponent();
        }

        private void VSprites1_Load(object sender, EventArgs e)
        {
            mainLocation = Directory.GetFiles(@".\Sprites\", "*.png", SearchOption.AllDirectories);
            int spriteCount = 0;
            this.MaximizeBox = false;
            foreach (string name in mainLocation)
            {
                string newLoc = Path.GetFileName(name);
                listBox1.Items.Add(newLoc);
                spriteCount += 1;
            }
            spriteCount += 1;
            label4.Text = spriteCount + " SPRITES";
        }

        private void btn_Default_Click(object sender, EventArgs e)
        {
            PictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
        private void btn_Center_Click(object sender, EventArgs e)
        {
            PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void btn_Stretch_Click(object sender, EventArgs e)
        {
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = 0;
            string imgPath = null;
            string imgLoc = null;
            foreach (string name in mainLocation)
            {
                if (count > listBox1.SelectedIndex)
                    break;
                count += 1;
                imgPath = name;
                imgLoc = Directory.GetParent(name).Name + ":" + Path.GetFileNameWithoutExtension(imgPath);
            }
            PictureBox1.Image = System.Drawing.Image.FromFile(imgPath);
            textBox1.Text = imgLoc.ToLower();
        }

        private void VSprites1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
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
        private void btnCPicker_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sections.Pawncp Component1 = new Sections.Pawncp();
            Component1.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
