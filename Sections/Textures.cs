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
                "10.- Streets",
                "11.- Walls",
                "12.- Windows"
            });

            listBox1.Visible = true;
            listBox2.Visible = false;
            InfoTextBox1.Visible = false;
            InfoTextBox2.Visible = false;
            InfoTextBox3.Visible = false;
            panel3.Visible = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.FindString(listBox1.SelectedItem.ToString()))
            {
                case 0: //Buildings
                    DisplayShow1();
                    InfoTextBox1.Visible = true;
                    InfoTextBox2.Visible = false;
                    InfoTextBox3.Visible = false;
                    Clear();

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
                    DisplayShow2();
                    InfoTextBox1.Visible = false;
                    InfoTextBox2.Visible = true;
                    InfoTextBox3.Visible = false;
                    Clear();

                    tPic_1.Image = VisualTexture_v2.Properties.Resources.roof09L256;
                    tPic_2.Image = VisualTexture_v2.Properties.Resources.sanpedock8;
                    tPic_3.Image = VisualTexture_v2.Properties.Resources.ws_corrugated1;
                    tPic_4.Image = VisualTexture_v2.Properties.Resources.ws_corrugated2;
                    break;

                case 2: //Colors
                    DisplayShow3();
                    InfoTextBox1.Visible = false;
                    InfoTextBox2.Visible = false;
                    InfoTextBox3.Visible = true;
                    Clear();

                    tPic_1.Image = VisualTexture_v2.Properties.Resources.black64;
                    tPic_2.Image = VisualTexture_v2.Properties.Resources.concreteyellow256;
                    tPic_3.Image = VisualTexture_v2.Properties.Resources.dirtywhite;
                    tPic_4.Image = VisualTexture_v2.Properties.Resources.easykerb;                
                    tPic_5.Image = VisualTexture_v2.Properties.Resources.white;
                    tPic_6.Image = VisualTexture_v2.Properties.Resources.ws_bluelino;
                    tPic_7.Image = VisualTexture_v2.Properties.Resources.ws_boothpanel;
                    tPic_8.Image = VisualTexture_v2.Properties.Resources.ws_yellowline;
                    tPic_9.Image = VisualTexture_v2.Properties.Resources.yellowscum64;
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

        public void Clear()
        {
            InfoTextBox1.SelectAll();
            InfoTextBox1.Text = "";
            InfoTextBox2.SelectAll();
            InfoTextBox2.Text = "";
            InfoTextBox3.SelectAll();
            InfoTextBox3.Text = "";
        }

        public void DisplayShow1()
        {
            panel3.Show();
            //============
            tPic_1.Show();
            tPic_2.Show();
            tPic_3.Show();
            tPic_4.Show();
            tPic_5.Show();
            tPic_6.Show();
            tPic_7.Show();
            tPic_8.Show();
            tPic_9.Show();
            tPic_10.Show();
            tPic_11.Show();
            tPic_12.Show();
            tPic_13.Show();
            tPic_14.Show();
            tPic_15.Show();
            tPic_16.Show();
            tPic_17.Show();
            tPic_18.Show();
            tPic_19.Show();
            tPic_20.Show();
            tPic_21.Show();
            tPic_22.Show();
            tPic_23.Show();
            tPic_24.Show();
            tPic_25.Show();
            tPic_26.Show();
            tPic_27.Show();
            tPic_28.Show();
            tPic_29.Show();
            tPic_30.Show();
            tPic_31.Show();
            tPic_32.Show();
            //Display PictureBox
            tPic_33.Hide();
            tPic_34.Hide();
            tPic_35.Hide();
            tPic_36.Hide();
            tPic_37.Hide();
            tPic_38.Hide();
            tPic_39.Hide();
            tPic_40.Hide();
            tPic_41.Hide();
            tPic_42.Hide();
            tPic_43.Hide();
            tPic_44.Hide();
            tPic_45.Hide();
            tPic_46.Hide();
            tPic_47.Hide();
            tPic_48.Hide();
            tPic_49.Hide();
            tPic_50.Hide();
            tPic_51.Hide();
            tPic_52.Hide();
        }
        public void DisplayShow2()
        {
            //Show PBox
            panel3.Show();
            tPic_1.Show();
            tPic_2.Show();
            tPic_3.Show();
            tPic_4.Show();
            //Hide PBox
            tPic_5.Hide();
            tPic_6.Hide();
            tPic_7.Hide();
            tPic_8.Hide();
            tPic_9.Hide();
            tPic_10.Hide();
            tPic_11.Hide();
            tPic_12.Hide();
            tPic_13.Hide();
            tPic_14.Hide();
            tPic_15.Hide();
            tPic_16.Hide();
            tPic_17.Hide();
            tPic_18.Hide();
            tPic_19.Hide();
            tPic_20.Hide();
            tPic_21.Hide();
            tPic_22.Hide();
            tPic_23.Hide();
            tPic_24.Hide();
            tPic_25.Hide();
            tPic_26.Hide();
            tPic_27.Hide();
            tPic_28.Hide();
            tPic_29.Hide();
            tPic_30.Hide();
            tPic_31.Hide();
            tPic_32.Hide();
            tPic_33.Hide();
            tPic_34.Hide();
            tPic_35.Hide();
            tPic_36.Hide();
            tPic_37.Hide();
            tPic_38.Hide();
            tPic_39.Hide();
            tPic_40.Hide();
            tPic_41.Hide();
            tPic_42.Hide();
            tPic_43.Hide();
            tPic_44.Hide();
            tPic_45.Hide();
            tPic_46.Hide();
            tPic_47.Hide();
            tPic_48.Hide();
            tPic_49.Hide();
            tPic_50.Hide();
            tPic_51.Hide();
            tPic_52.Hide();
        }
        public void DisplayShow3()
        {
            //Show PBox
            panel3.Show();
            tPic_1.Show();
            tPic_2.Show();
            tPic_3.Show();
            tPic_4.Show();        
            tPic_5.Show();
            tPic_6.Show();
            tPic_7.Show();
            tPic_8.Show();
            tPic_9.Show();
            //Hide PBox
            tPic_10.Hide();
            tPic_11.Hide();
            tPic_12.Hide();
            tPic_13.Hide();
            tPic_14.Hide();
            tPic_15.Hide();
            tPic_16.Hide();
            tPic_17.Hide();
            tPic_18.Hide();
            tPic_19.Hide();
            tPic_20.Hide();
            tPic_21.Hide();
            tPic_22.Hide();
            tPic_23.Hide();
            tPic_24.Hide();
            tPic_25.Hide();
            tPic_26.Hide();
            tPic_27.Hide();
            tPic_28.Hide();
            tPic_29.Hide();
            tPic_30.Hide();
            tPic_31.Hide();
            tPic_32.Hide();
            tPic_33.Hide();
            tPic_34.Hide();
            tPic_35.Hide();
            tPic_36.Hide();
            tPic_37.Hide();
            tPic_38.Hide();
            tPic_39.Hide();
            tPic_40.Hide();
            tPic_41.Hide();
            tPic_42.Hide();
            tPic_43.Hide();
            tPic_44.Hide();
            tPic_45.Hide();
            tPic_46.Hide();
            tPic_47.Hide();
            tPic_48.Hide();
            tPic_49.Hide();
            tPic_50.Hide();
            tPic_51.Hide();
            tPic_52.Hide();
        }


        //InfoTextBox3.Text = "SetDynamicObjectMaterial(Var, 0, Here,\"Here\",\"Here\", 0xFFFFFFFF";
        private void tPic_1_Click(object sender, EventArgs e)
        {
            InfoTextBox1.Text = "SetDynamicObjectMaterial(Var, 0, 4830,\"airport2\",\"aarprt5LAS\", 0xFFFFFFFF);";
            InfoTextBox2.Text = "SetDynamicObjectMaterial(Var, 0, 10810,\"ap_build4e\",\"roof09L256\", 0xFFFFFFFF";
            InfoTextBox3.Text = "SetDynamicObjectMaterial(Var, 0, 10765,\"airportgnd_sfse\",\"black64\", 0xFFFFFFFF";
        }
        private void tPic_2_Click(object sender, EventArgs e)
        {
            InfoTextBox1.Text = "SetDynamicObjectMaterial(Var, 0, 8391,\"ballys01\",\"ballyledge01_128\", 0xFFFFFFFF);";
            InfoTextBox2.Text = "SetDynamicObjectMaterial(Var, 0, 4828,\"airport3_las\",\"sanpedock8\", 0xFFFFFFFF";
            InfoTextBox3.Text = "SetDynamicObjectMaterial(Var, 0, 16640,\"a51\",\"concreteyellow256 copy\", 0xFFFFFFFF";
        }
        private void tPic_3_Click(object sender, EventArgs e)
        {
            InfoTextBox1.Text = "SetDynamicObjectMaterial(Var, 0, 8391,\"ballys01\",\"ballywindw01_128\", 0xFFFFFFFF);";
            InfoTextBox2.Text = "SetDynamicObjectMaterial(Var, 0, 3629,\"arprtxxref_las\",\"ws_corrugated1\", 0xFFFFFFFF";
            InfoTextBox3.Text = "SetDynamicObjectMaterial(Var, 0, 3629,\"arprtxxref_las\",\"dirtywhite\", 0xFFFFFFFF";  
        }
        private void tPic_4_Click(object sender, EventArgs e)
        {
            InfoTextBox1.Text = "SetDynamicObjectMaterial(Var, 0, 8391,\"ballys01\",\"ballywindw02_128\", 0xFFFFFFFF);";
            InfoTextBox2.Text = "SetDynamicObjectMaterial(Var, 0, 3629,\"arprtxxref_las\",\"ws_corrugated2\", 0xFFFFFFFF";
            InfoTextBox3.Text = "SetDynamicObjectMaterial(Var, 0, 4835,\"airoads_las\",\"easykerb\", 0xFFFFFFFF";
        }
        private void tPic_5_Click(object sender, EventArgs e)
        {
            InfoTextBox1.Text = "SetDynamicObjectMaterial(Var, 0, 10041,\"archybuild10\",\"bank_sfe2\", 0xFFFFFFFF);";
            InfoTextBox3.Text = "SetDynamicObjectMaterial(Var, 0, 10765,\"airportgnd_sfse\",\"white\", 0xFFFFFFFF";
        }
        private void tPic_6_Click(object sender, EventArgs e)
        {
            InfoTextBox1.Text = "SetDynamicObjectMaterial(Var, 0, 10041,\"archybuild10\",\"copshop2\", 0xFFFFFFFF);";
            InfoTextBox3.Text = "SetDynamicObjectMaterial(Var, 0, 4833,\"airprtrunway_las\",\"ws_bluelino\", 0xFFFFFFFF";
        }
        private void tPic_7_Click(object sender, EventArgs e)
        {
            InfoTextBox1.Text = "SetDynamicObjectMaterial(Var, 0, 10041,\"archybuild10\",\"copshop3\", 0xFFFFFFFF);";
            InfoTextBox3.Text = "SetDynamicObjectMaterial(Var, 0, 10778,\"airportcpark_sfse\",\"ws_boothpanel\", 0xFFFFFFFF";
        }
        private void tPic_8_Click(object sender, EventArgs e)
        {
            InfoTextBox1.Text = "SetDynamicObjectMaterial(Var, 0, 16640,\"a51\",\"des_tunnellight\", 0xFFFFFFFF);";
            InfoTextBox3.Text = "SetDynamicObjectMaterial(Var, 0, 10765,\"airportgnd_sfse\",\"ws_yellowline\", 0xFFFFFFFF";
        }
        private void tPic_9_Click(object sender, EventArgs e)
        {
            InfoTextBox1.Text = "SetDynamicObjectMaterial(Var, 0, 4552,\"ammu_lan2\",\"dior\", 0xFFFFFFFF);";
            InfoTextBox3.Text = "SetDynamicObjectMaterial(Var, 0, 10763,\"airport1_sfse\",\"yellowscum64\", 0xFFFFFFFF";   
        }
        private void tPic_10_Click(object sender, EventArgs e)
        {
            InfoTextBox1.Text = "SetDynamicObjectMaterial(Var, 0, 4552,\"ammu_lan2\",\"foodmartla1\", 0xFFFFFFFF);";      
        }
        private void tPic_11_Click(object sender, EventArgs e)
        {
            InfoTextBox1.Text = "SetDynamicObjectMaterial(Var, 0, 9920,\"anotherbuildsfe\",\"gz_vic1b\", 0xFFFFFFFF);";
        }
        private void tPic_12_Click(object sender, EventArgs e)
        {
            InfoTextBox1.Text = "SetDynamicObjectMaterial(Var, 0, 9920,\"anotherbuildsfe\",\"gz_vic2a\", 0xFFFFFFFF);";
        }
        private void tPic_13_Click(object sender, EventArgs e) 
        {
            InfoTextBox1.Text = "SetDynamicObjectMaterial(Var, 0, 4552,\"ammu_lan2\",\"mallextmid01\", 0xFFFFFFFF);";
        }
        private void tPic_14_Click(object sender, EventArgs e)
        {
            InfoTextBox1.Text = "SetDynamicObjectMaterial(Var, 0, 4552,\"ammu_lan2\",\"mallextmid01\", 0xFFFFFFFF);";
        }
        private void tPic_15_Click(object sender, EventArgs e)
        {
            InfoTextBox1.Text = "SetDynamicObjectMaterial(Var, 0, 10041,\"archybuild10 \",\"sf_shop2\", 0xFFFFFFFF);";
        }
        private void tPic_16_Click(object sender, EventArgs e)
        {
            InfoTextBox1.Text = "SetDynamicObjectMaterial(Var, 0, 10041,\"archybuild10 \",\"sf_windos_15\", 0xFFFFFFFF);";
        }
        private void tPic_17_Click(object sender, EventArgs e)
        {
            InfoTextBox1.Text = "SetDynamicObjectMaterial(Var, 0, 10041,\"archybuild10 \",\"sf_windos_15b\", 0xFFFFFFFF);";
        }
        private void tPic_18_Click(object sender, EventArgs e)
        {
            InfoTextBox1.Text = "SetDynamicObjectMaterial(Var, 0, 10041,\"archybuild10 \",\"sf_windos_7\", 0xFFFFFFFF);";
        }
        private void tPic_19_Click(object sender, EventArgs e)
        {
            InfoTextBox1.Text = "SetDynamicObjectMaterial(Var, 0, 10041,\"archybuild10 \",\"sf_windos_8\", 0xFFFFFFFF);";
        }
        private void tPic_20_Click(object sender, EventArgs e)
        {
            InfoTextBox1.Text = "SetDynamicObjectMaterial(Var, 0, 10041,\"archybuild10 \",\"sf_windos_9\", 0xFFFFFFFF);";
        }
        private void tPic_21_Click(object sender, EventArgs e)
        {
            InfoTextBox1.Text = "SetDynamicObjectMaterial(Var, 0, 10041,\"archybuild10\",\"sfe_bigbuild2\", 0xFFFFFFFF);";
        }
        private void tPic_22_Click(object sender, EventArgs e)
        {
            InfoTextBox1.Text = "SetDynamicObjectMaterial(Var, 0, 10041,\"archybuild10\",\"sfe_pinkbuild2\", 0xFFFFFFFF);";
        }
        private void tPic_23_Click(object sender, EventArgs e)
        {
            InfoTextBox1.Text = "SetDynamicObjectMaterial(Var, 0, 4552,\"ammu_lan2\",\"sl_dtbuild02win1\", 0xFFFFFFFF);";
        }
        private void tPic_24_Click(object sender, EventArgs e)
        {
            InfoTextBox1.Text = "SetDynamicObjectMaterial(Var, 0, 4552,\"ammu_lan2\",\"sl_dtrufrear2win1\", 0xFFFFFFFF);";
        }
        private void tPic_25_Click(object sender, EventArgs e)
        {
            InfoTextBox1.Text = "SetDynamicObjectMaterial(Var, 0, 4552,\"ammu_lan2\",\"sl_dtrufrear2win2\", 0xFFFFFFFF);";
        }
        private void tPic_26_Click(object sender, EventArgs e)
        {
            InfoTextBox1.Text = "SetDynamicObjectMaterial(Var, 0, 4552,\"ammu_lan2\",\"sl_dtrufrear2win3\", 0xFFFFFFFF);";
        }
        private void tPic_27_Click(object sender, EventArgs e)
        {
            InfoTextBox1.Text = "SetDynamicObjectMaterial(Var, 0, 4552,\"ammu_lan2\",\"sl_fudstore1\", 0xFFFFFFFF);";
        }
        private void tPic_28_Click(object sender, EventArgs e)
        {
            InfoTextBox1.Text = "SetDynamicObjectMaterial(Var, 0, 4552,\"ammu_lan2\",\"sl_fudstore2\", 0xFFFFFFFF);";
        }
        private void tPic_29_Click(object sender, EventArgs e)
        {
            InfoTextBox1.Text = "SetDynamicObjectMaterial(Var, 0, 10041,\"archybuild10\",\"whitedecosfe1\", 0xFFFFFFFF);";
        }
        private void tPic_30_Click(object sender, EventArgs e)
        {
            InfoTextBox1.Text = "SetDynamicObjectMaterial(Var, 0, 10041,\"archybuild10\",\"whitedecosfe2\", 0xFFFFFFFF);";
        }
        private void tPic_31_Click(object sender, EventArgs e)
        {
            InfoTextBox1.Text = "SetDynamicObjectMaterial(Var, 0, 10891,\"bakery_sfse\",\"ws_dflourmural\", 0xFFFFFFFF);";
        }
        private void tPic_32_Click(object sender, EventArgs e)
        {
            InfoTextBox1.Text = "SetDynamicObjectMaterial(Var, 0, 10856,\"bakerybit_sfse\",\"ws_dickgoblinmural\", 0xFFFFFFFF);";
        }

        private void tPic_33_Click(object sender, EventArgs e)
        {

        }
    }
}


