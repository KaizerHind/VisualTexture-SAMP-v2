using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace VisualTexture_v2
{
    public partial class Index : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        public Index()
        {
            InitializeComponent();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            label1.Text = "Thanks for using VisualTextures.";
            label2.Text = "This tool has been created in order to provide much faster information, when it comes";
            label3.Text = "to needing any type of information, with regard to: Functions, textures, objects, sounds, among others.";
            label4.Text = "At the moment, this tool is in the BETA Phase, we are constantly working to update the data and the";
            label5.Text = "content that is provided.";
            label6.Text = "VisualTexture has as its only purpose, to provide data to the user, in case the person does not have a";
            label7.Text = "network available, and information regarding pwn is needed quickly, or as mentioned above, we only";
            label8.Text = "provide more 'quick' information.";

        }
        

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void VAnimations_Click(object sender, EventArgs e)
        {
            this.Hide();
            Animations Component1 = new Animations();
            Component1.Show();
            LOGO.Visible = false;
            gb_text.Visible = false;
        }

        private void B_Index_Click(object sender, EventArgs e)
        {
            LOGO.Visible = true;
            gb_text.Visible = true;
            /*btnClose.Location = new Point(699, 0);
            panel2.Width = 593;
            this.Size = new Size(748, 429);*/
        }
        /* #################################### Mouse Settings ########################################## */
        private void Index_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
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

        private void LOGO_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        /* ############################################################################################## */
    }
}
