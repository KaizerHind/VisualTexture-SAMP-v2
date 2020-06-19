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
    public partial class wikisamp : Form
    {
        public wikisamp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void wikisamp_Load(object sender, EventArgs e)
        {
            //panels
            Shou(false);
        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shou(true);
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    {
                        Shou(false);
                        break;
                    }
                case 1:
                    {
                        richTextBox1.Text = "Tu puta madre kaiser";
                        titulo.Text = "CreateActor";
                        break;
                    }
                case 2:
                    {
                        titulo.Text = "DestroyActor";
                        break;
                    }
                case 3:
                    {
                        titulo.Text = "IsActorStreamedIn";
                        break;
                    }
                case 4:
                    {
                        titulo.Text = "SetActorVirtualWorld";
                        break;
                    }
                case 5:
                    {
                        titulo.Text = "GetActorVirtualWorld";
                        break;
                    }
                case 6:
                    {
                        titulo.Text = "ApplyActorAnimation";
                        break;
                    }
                case 7:
                    {
                        titulo.Text = "ClearActorAnimations";
                        break;
                    }
                case 8:
                    {
                        titulo.Text = "SetActorPos";
                        break;
                    }
                case 9:
                    {
                        titulo.Text = "GetActorPos";
                        break;
                    }
                case 10:
                    {
                        titulo.Text = "SetActorFacingAngle";
                        break;
                    }
                case 11:
                    {
                        titulo.Text = "GetActorFacingAngle";
                        break;
                    }
                case 12:
                    {
                        titulo.Text = "SetActorHealth";
                        break;
                    }
                case 13:
                    {
                        titulo.Text = "GetActorHealth";
                        break;
                    }
                case 14:
                    {
                        titulo.Text = "SetActorInvulnerable";
                        break;
                    }
                case 15:
                    {
                        titulo.Text = "IsActorInvulnerable";
                        break;
                    }
                case 16:
                    {
                        titulo.Text = "IsValidActor";
                        break;
                    }
                case 17:
                    {
                        Shou(false);
                        break;
                    }
                case 18:
                    {
                        Shou(false);
                        break;
                    }
            }
        }

        private void vScrollBar1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void Shou(bool type)
        {
            if (type == false)
            {
                titulo.Hide();
                label2.Hide();
                label3.Hide();
                label4.Hide();
                panel2.Hide();
                panel3.Hide();
                panel4.Hide();
                panel5.Hide();
                panel6.Hide();
            }
            if (type == true)
            {
                titulo.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                //panels
                panel2.Show();
                panel3.Show();
                panel4.Show();
                panel5.Show();
                panel6.Show();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "Tu puta madre";
        }
    }
}
