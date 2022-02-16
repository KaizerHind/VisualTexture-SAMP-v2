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
                "1.- Buildings",
                "2.- Ceiling",
                "3.- Colors",
                "4.- Decoration",
                "5.- Doors",
                "6.- Floor",
                "7.- Lights",
                "8.- Metal",
                "9.- Plants",
                "10.- Strets",
                "11.- Walls",
                "12.- Windows"
            });
            InfoTextBox.Visible = false;
            panel3.Visible = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.FindString(listBox1.SelectedItem.ToString()))
            {
                case 0: //Buildings
                    panel3.Show();
                    tPic_1.Image = VisualTexture_v2.Properties.Resources.aarprt5LAS;
                    tPic_2.Image = VisualTexture_v2.Properties.Resources.ballyledge01_128;
                    tPic_3.Image = VisualTexture_v2.Properties.Resources.ballywindw01_128;
                    tPic_4.Image = VisualTexture_v2.Properties.Resources.ballywindw02_128;
                    tPic_5.Image = VisualTexture_v2.Properties.Resources.bank_sfe2;
                    tPic_6.Image = VisualTexture_v2.Properties.Resources.copshop2;
                    tPic_7.Image = VisualTexture_v2.Properties.Resources.copshop3;
                    tPic_8.Image = VisualTexture_v2.Properties.Resources.des_tunnellight;
                    tPic_9.Image = VisualTexture_v2.Properties.Resources.dior;
                    tPic_10.Image = VisualTexture_v2.Properties.Resources.foodmartla1;
                    tPic_11.Image = VisualTexture_v2.Properties.Resources.gz_vic1b;
                    tPic_12.Image = VisualTexture_v2.Properties.Resources.gz_vic2a;
                    tPic_13.Image = VisualTexture_v2.Properties.Resources.mallextmid01;
                    tPic_14.Image = VisualTexture_v2.Properties.Resources.sf_chinashop2;
                    tPic_15.Image = VisualTexture_v2.Properties.Resources.sf_shop2;
                    tPic_16.Image = VisualTexture_v2.Properties.Resources.sf_windos_15;
                    tPic_17.Image = VisualTexture_v2.Properties.Resources.sf_windos_15b;
                    tPic_18.Image = VisualTexture_v2.Properties.Resources.sf_windos_7;
                    tPic_19.Image = VisualTexture_v2.Properties.Resources.sf_windos_8;
                    tPic_20.Image = VisualTexture_v2.Properties.Resources.sf_windos_9;
                    tPic_21.Image = VisualTexture_v2.Properties.Resources.sfe_bigbuild2;
                    tPic_22.Image = VisualTexture_v2.Properties.Resources.sfe_pinkbuild2;
                    tPic_23.Image = VisualTexture_v2.Properties.Resources.sl_dtbuild02win1;
                    tPic_24.Image = VisualTexture_v2.Properties.Resources.sl_dtrufrear2win1;
                    tPic_25.Image = VisualTexture_v2.Properties.Resources.sl_dtrufrear2win2;
                    tPic_26.Image = VisualTexture_v2.Properties.Resources.sl_dtrufrear2win3;
                    tPic_27.Image = VisualTexture_v2.Properties.Resources.sl_fudstore1;
                    tPic_28.Image = VisualTexture_v2.Properties.Resources.sl_fudstore2;
                    tPic_29.Image = VisualTexture_v2.Properties.Resources.whitedecosfe1;
                    tPic_30.Image = VisualTexture_v2.Properties.Resources.whitedecosfe2;
                    tPic_31.Image = VisualTexture_v2.Properties.Resources.ws_dflourmural;
                    tPic_32.Image = VisualTexture_v2.Properties.Resources.ws_dickgoblinmural;

                    break;

                case 1: //Ceiling
                    panel3.Hide();

                    break;

                case 2: //Colors
                    panel3.Hide();

                    break;

                case 3: //Decoration
                    panel3.Hide();

                    break;

                case 4: //Doors
                    panel3.Hide();

                    break;

                case 5: //Floor
                    panel3.Hide();

                    break;

                case 6: //Lights
                    panel3.Hide();

                    break;

                case 7: //Metal
                    panel3.Hide();

                    break;
                case 8: //Plants
                    panel3.Hide();

                    break;
                case 9: //Streets
                    panel3.Hide();

                    break;
                case 10: //Walls
                    panel3.Hide();

                    break;
                case 11: //Windows
                    panel3.Hide();

                    break;

            /*    case 1:
                    panel3.Hide();
            break;

                case 1:
                    panel3.Hide();

                    break;

                case 1:
                    panel3.Hide();

                    break;

                case 1: 
                    panel3.Hide();

                    break;

                case 1:
                    panel3.Hide();

                    break;

                case 1: 
                    panel3.Hide();

                    break;

                case 1: 
                    panel3.Hide();

                    break;

                case 1:
                    panel3.Hide();

                    break;

                case 2:
                    panel3.Hide();

                    break;

                case 2: 
                    panel3.Hide();

                    break;

                case 2: 
                    panel3.Hide();

                    break;*/

            }
        }


        private void tPic_1_Click(object sender, EventArgs e)
        {
            InfoTextBox.Visible = true;
            InfoTextBox.Text = "SetDynamicObjectMaterial(Var, 0, 16640,\"a51\",\"a51_floorpanel1\", 0xFFFFFFFF);";
        }
        private void tPic_2_Click(object sender, EventArgs e)
        {
            InfoTextBox.Visible = true;
            InfoTextBox.Text = "SetDynamicObjectMaterial(Var, 0, 16640,\"a51\",\"a51_panel2\", 0xFFFFFFFF);";
        }
        private void tPic_3_Click(object sender, EventArgs e)
        {
            InfoTextBox.Visible = true;
            InfoTextBox.Text = "SetDynamicObjectMaterial(Var, 0, 16640,\"a51\",\"a51_panels1\", 0xFFFFFFFF);";
        }
        private void tPic_4_Click(object sender, EventArgs e)
        {
            InfoTextBox.Visible = true;
            InfoTextBox.Text = "SetDynamicObjectMaterial(Var, 0, 16640,\"a51\",\"a51_strips1\", 0xFFFFFFFF);";
        }
        private void tPic_5_Click(object sender, EventArgs e)
        {
            InfoTextBox.Visible = true;
            InfoTextBox.Text = "SetDynamicObjectMaterial(Var, 0, 16640,\"a51\",\"a51_vent1\", 0xFFFFFFFF);";
        }
        private void tPic_6_Click(object sender, EventArgs e)
        {
            InfoTextBox.Visible = true;
            InfoTextBox.Text = "SetDynamicObjectMaterial(Var, 0, 16640,\"a51\",\"a51_wall1\", 0xFFFFFFFF);";
        }
        private void tPic_7_Click(object sender, EventArgs e)
        {
            InfoTextBox.Visible = true;
            InfoTextBox.Text = "SetDynamicObjectMaterial(Var, 0, 9514,\"711_sfw\",\"brick\", 0xFFFFFFFF);";
        }
        private void tPic_8_Click(object sender, EventArgs e)
        {
            InfoTextBox.Visible = true;
            InfoTextBox.Text = "SetDynamicObjectMaterial(Var, 0, 16640,\"a51\",\"carparkwall12_256\", 0xFFFFFFFF);";
        }
        private void tPic_9_Click(object sender, EventArgs e)
        {
            InfoTextBox.Visible = true;
            InfoTextBox.Text = "SetDynamicObjectMaterial(Var, 0, 16640,\"a51\",\"concretegroundl1_256\", 0xFFFFFFFF);";
        }
        private void tPic_10_Click(object sender, EventArgs e)
        {
            InfoTextBox.Visible = true;
            InfoTextBox.Text = "SetDynamicObjectMaterial(Var, 0, 16640,\"a51\",\"concretewall22_256\", 0xFFFFFFFF);";
        }
        private void tPic_11_Click(object sender, EventArgs e)
        {
            InfoTextBox.Visible = true;
            InfoTextBox.Text = "SetDynamicObjectMaterial(Var, 0, 16640,\"a51\",\"concreteyellow256_copy\", 0xFFFFFFFF);";
        }
        private void tPic_12_Click(object sender, EventArgs e)
        {
            InfoTextBox.Visible = true;
            InfoTextBox.Text = "SetDynamicObjectMaterial(Var, 0, 16640,\"a51\",\"des_factower\", 0xFFFFFFFF);";
        }
        private void tPic_13_Click(object sender, EventArgs e)
        {
            InfoTextBox.Visible = true;
            InfoTextBox.Text = "SetDynamicObjectMaterial(Var, 0, 10101,\"2notherbuildsfe\",\"ferry_build14\", 0xFFFFFFFF);";
        }
        private void tPic_14_Click(object sender, EventArgs e)
        {
            InfoTextBox.Visible = true;
            InfoTextBox.Text = "SetDynamicObjectMaterial(Var, 0, 16640,\"a51\",\"Metalox64\", 0xFFFFFFFF);";
        }
        private void tPic_15_Click(object sender, EventArgs e)
        {
            InfoTextBox.Visible = true;
            InfoTextBox.Text = "SetDynamicObjectMaterial(Var, 0, 9514,\"711_sfw\",\"pcut_bot_law\", 0xFFFFFFFF);";
        }
        private void tPic_16_Click(object sender, EventArgs e)
        {
            InfoTextBox.Visible = true;
            InfoTextBox.Text = "SetDynamicObjectMaterial(Var, 0, 9514,\"711_sfw\",\"rebrckwall_128\", 0xFFFFFFFF);";
        }
        private void tPic_17_Click(object sender, EventArgs e)
        {
            InfoTextBox.Visible = true;
            InfoTextBox.Text = "SetDynamicObjectMaterial(Var, 0, 16640,\"a51\",\"redmetal\", 0xFFFFFFFF);";
        }
        private void tPic_18_Click(object sender, EventArgs e)
        {
            InfoTextBox.Visible = true;
            InfoTextBox.Text = "SetDynamicObjectMaterial(Var, 0, 9514,\"711_sfw\",\"shingles2\", 0xFFFFFFFF);";
        }
        private void tPic_19_Click(object sender, EventArgs e)
        {
            InfoTextBox.Visible = true;
            InfoTextBox.Text = "SetDynamicObjectMaterial(Var, 0, 10101,\"2notherbuildsfe\",\"sl_vicbrikwall01\", 0xFFFFFFFF);";
        }
        private void tPic_20_Click(object sender, EventArgs e)
        {
            InfoTextBox.Visible = true;
            InfoTextBox.Text = "SetDynamicObjectMaterial(Var, 0, 10101,\"2notherbuildsfe\",\"sl_vicwall01\", 0xFFFFFFFF);";
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
            MessageBox.Show("Hello! In case the first animation you select doesn't load correctly, select another one again so that the page reloads. :)");
        }

        private void btnCPicker_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sections.Pawncp Component1 = new Sections.Pawncp();
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
