using System;
using System.Drawing;
using System.Windows.Forms;

namespace VisualTexture_v2.Sections
{
    public partial class Textures : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Textures()
        {
            InitializeComponent();
            listBox1.Items.AddRange(new object[] {
                "1.- Walls",
                "2.- Doors",
                "3.- Windows",
                "4.- Floors",
                "5.- Metals",
                "6.- Colors",
                "7.- Furnitures",
                "8.- Accesories",
                "9.- Random"
            });
            richTextBox1.Visible = false;
            panel3.Visible = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.FindString(listBox1.SelectedItem.ToString()))
            {
                case 0:
                    panel3.Show();

                    tPic_1.Image = VisualTexture_v2.Properties.Resources.a51_floorpanel1;
                    tPic_2.Image = VisualTexture_v2.Properties.Resources.a51_panel2;
                    tPic_3.Image = VisualTexture_v2.Properties.Resources.a51_panels1;
                    tPic_4.Image = VisualTexture_v2.Properties.Resources.a51_strips1;

                    break;

                case 1:
                    panel3.Hide();

                    break;
            }
        }

        private void tPic_1_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            richTextBox1.Text = "SetObjectMaterial(Var, 0, 16640,\"a51\",\"a51_floorpanel1\" 0xFFFFFFFF);";
        }
        private void tPic_2_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            richTextBox1.Text = "SetObjectMaterial(Var, 0, 16640,\"a51\",\"a51_panel2\" 0xFFFFFFFF);";
        }
        private void tPic_3_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            richTextBox1.Text = "SetObjectMaterial(Var, 0, 16640,\"a51\",\"a51_panels1\" 0xFFFFFFFF);";
        }
        private void tPic_4_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            richTextBox1.Text = "SetObjectMaterial(Var, 0, 16640,\"a51\",\"a51_strips1\" 0xFFFFFFFF);";
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
        private void panel3_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
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
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
