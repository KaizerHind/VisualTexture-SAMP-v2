using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualTexture_v2
{
    public partial class Index : Form
    {
        public int xClick = 0, yClick = 0;
        private const int topArea = 50;

        public Index()
        {
            InitializeComponent();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            /*label1.Text = "Thanks for using VisualTextures.";
            label2.Text = "This tool has been created in order to provide much faster information, when it comes";
            label3.Text = "to needing any type of information, with regard to: Functions, textures, objects, sounds, among others.";
            label4.Text = "At the moment, this tool is in the BETA Phase, we are constantly working to update the data and the";
            label5.Text = "content that is provided.";
            label6.Text = "VisualTexture has as its only purpose, to provide data to the user, in case the person does not have a";
            label7.Text = "network available, and information regarding pwn is needed quickly, or as mentioned above, we only";
            label8.Text = "provide more 'quick' information.";*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void wikiSampToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            wikisamp Component1 = new wikisamp();
            Component1.Show();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void bunifuFlatButton1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button != MouseButtons.Left)
            {
                xClick = e.X;
                yClick = e.Y;
            }
            else
            {
                if (yClick <= topArea)
                {
                    this.Left = this.Left + (e.X - xClick);
                    this.Top = this.Top + (e.Y - yClick);
                }
            }
        }
    }
}
