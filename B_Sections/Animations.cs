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
using CefSharp;
using CefSharp.WinForms;

namespace VisualTexture_v2
{
    public partial class Animations : Form
    {
        public ChromiumWebBrowser chromeBrowser;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        public Animations()
        {
            InitializeComponent();
            // Start the browser after initialize global component
            InitializeChromium();
        }

        public void InitializeChromium()
        {
            CefSettings settings = new CefSettings();
            // Initialize cef with the provided settings
            Cef.Initialize(settings);
            // Create a browser component
            chromeBrowser = new ChromiumWebBrowser("http://ourcodeworld.com");
            // Add it to the form and fill it to the form window.
            this.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;
        }

        private void Animations_Load(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(new object[] {
            "[PED]",
            "-  abseil",
            "-  ARRESTgun",
            "-  ATM",
            "-  bomber",
            "-  CAR_crawloutRHS",
            "-  CAR_doorlocked_LHS",
            "-  CAR_doorlocked_RHS",
            "-  cower",
            "-  endchat_01",
            "-  endchat_02",
            "-  endchat_03",
            "-  facgum",
            "-  factalk",
            "-  FALL_skyDive",
            "-  flee_lkaround_01",
            "-  fucku",
            "-  gas_cwr",
            "-  gum_eat",
            "-  handsup",
            "-  HIT_walk",
            "-  IDLE_chat",
            "-  IDLE_HBHB",
            "-  IDLE_ROCKET",
            "-  IDLE_taxi",
            "-  IDLE_tired",
            "-  KO_shot_face",
            "-  KO_shot_front",
            "-  KO_shot_stom",
            "-  KO_skid_front",
            "-  pass_Smoke_in_car",
            "-  phone_in",
            "-  phone_out",
            "-  phone_talk",
            "-  roadcross",
            "-  run_1armed",
            "-  run_armed",
            "-  run_civi",
            "-  run_fatold",
            "-  run_gang1",
            "-  run_old",
            "-  run_player",
            "-  Run_stop",
            "-  Run_Wuzi",
            "-  SEAT_down",
            "-  SEAT_idle",
            "-  SEAT_up",
            "-  Smoke_in_car",
            "-  Swim_Tread",
            "-  WALK_drunk",
            "-  WALK_fatold",
            "-  WALK_gang1",
            "-  WALK_gang2",
            "-  Walk_Wuzi",
            "-  WOMAN_walkpro",
            "-  WOMAN_walkshop",
            "-  XPRESSscratch",
            "",
            "[Airport]",
            "-  thrw_barl_thrw",
            "",
            "[Attractors]",
            "-  Stepsit_in",
            "-  Stepsit_loop",
            "-  Stepsit_out",
            "",
            "[Bar]",
            "-  Barcustom_get",
            "-  Barcustom_loop",
            "-  Barcustom_order",
            "-  BARman_idle",
            "-  Barserve_bottle",
            "-  Barserve_give",
            "-  Barserve_glass",
            "-  Barserve_in",
            "-  Barserve_loop",
            "-  Barserve_order",
            "-  dnk_stndF_loop",
            "-  dnk_stndM_loop",
            "",
            "[Baseball]",
            "-  Bat_1",
            "-  Bat_2",
            "-  Bat_3",
            "-  Bat_4",
            "-  Bat_IDLE",
            "-  Bat_M",
            "",
            "[Bd_Fire]",
            "-  BD_GF_Wave",
            "-  BD_Panic_01",
            "-  BD_Panic_02",
            "-  BD_Panic_03",
            "-  BD_Panic_04",
            "-  BD_Panic_Loop",
            "-  Grlfrd_Kiss_03",
            "-  M_smklean_loop",
            "-  Playa_Kiss_03",
            "-  wash_up",
            "",
            "[Beach]",
            "-  bather",
            "-  Lay_Bac_Loop",
            "-  ParkSit_M_loop",
            "-  ParkSit_W_loop",
            "-  SitnWait_loop_W",
            "",
            "[Benchpress]",
            "-  gym_bp_celebrate",
            "-  gym_bp_down",
            "-  gym_bp_getoff",
            "-  gym_bp_geton",
            "-  gym_bp_up_A",
            "-  gym_bp_up_B",
            "-  gym_bp_up_smooth",
            "",
            "[Biked]",
            "-  BIKEd_Back",
            "-  BIKEd_hit",
            "",
            "[Bikeh]",
            "-  BIKEh_Back",
            "-  BIKEh_hit",
            "",
            "[Bikeleap]",
            "-  struggle_cesar",
            "-  struggle_driver",
            "",
            "[Bikes]",
            "-  BIKEs_Back",
            "-  BIKEs_hit",
            "",
            "[Bike_Dbz]",
            "-  Pass_Driveby_BWD",
            "-  Pass_Driveby_FWD",
            "-  Pass_Driveby_LHS",
            "-  Pass_Driveby_RHS",
            "",
            "[Blowjobz]",
            "-  BJ_Car_End_P",
            "-  BJ_Car_End_W",
            "-  BJ_Car_Loop_P",
            "-  BJ_Car_Loop_W",
            "-  BJ_Car_Start_P",
            "-  BJ_Car_Start_W",
            "-  BJ_Couch_End_P",
            "-  BJ_Couch_End_W",
            "-  BJ_Couch_Loop_P",
            "-  BJ_Couch_Loop_W",
            "-  BJ_Couch_Start_P",
            "-  BJ_Couch_Start_W",
            "-  BJ_Stand_End_P",
            "-  BJ_Stand_End_W",
            "-  BJ_Stand_Loop_P",
            "-  BJ_Stand_Loop_W",
            "-  BJ_Stand_Start_P",
            "-  BJ_Stand_Start_W",
            "",
            "[Bomber]",
            "-  Plant",
            "-  Plant_2Idle",
            "-  Plant_Crouch_In",
            "-  Plant_Loop",
            "",
            "[Box]",
            "-  boxhipin",
            "-  boxhipup",
            "-  boxshdwn",
            "-  catch_box",
            "",
            ""});
            richTextBox1.Visible = false;
            pvAnims.Visible = false;
        }

        /* #################################### Sections Control ########################################## */

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void B_Index_Click(object sender, EventArgs e)
        {
            this.Hide();
            Index Component1 = new Index();
            Component1.Show();
        }

        private void bTextures_Click(object sender, EventArgs e)
        {
            this.Hide();
            Textures Component1 = new Textures();
            Component1.Show();
        }

        private void Animations_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        /* ############################################################################################## */

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.FindString(listBox1.SelectedItem.ToString()))
            {
                case 0:
                    //listBox1.SelectedIndex = 1;
                    pvAnims.Visible = false;
                    richTextBox1.Enabled = false;
                    richTextBox1.Visible = false;

                    richTextBox1.Text = "";
                    break;

                case 1:
                    pvAnims.Visible = true;
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    richTextBox1.Enabled = true;

                    richTextBox1.Text = "new Variable" +
                    "Variable = CreateActor(ID, X, Y, Z, RZ);" +
                    "ApplyActorAnimation(Variable, PED, abseil, 4.0, 1, 1, 1, 0, 0)";
                    break;

                case 2:
                    pvAnims.Visible = true;
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    richTextBox1.Enabled = true;

                    richTextBox1.Text = "new Variable" +
                    "Variable = CreateActor(ID, X, Y, Z, RZ);" +
                    "ApplyActorAnimation(Variable, PED, ARRESTgun, 4.0, 1, 1, 1, 0, 0)";
                    break;

                case 57:
                    //listBox1.SelectedIndex = 1;

                    pvAnims.Visible = false;
                    richTextBox1.Enabled = false;
                    richTextBox1.Visible = false;

                    richTextBox1.Text = "";
                    break;

                case 58:
                    //listBox1.SelectedIndex = 1;
                    pvAnims.Visible = false;
                    richTextBox1.Enabled = false;
                    richTextBox1.Visible = false;

                    richTextBox1.Text = "";
                    break;

                case 60:
                    //listBox1.SelectedIndex = 1;
                    pvAnims.Visible = false;
                    richTextBox1.Enabled = false;
                    richTextBox1.Visible = false;

                    richTextBox1.Text = "";
                    break;

                case 61:
                    //listBox1.SelectedIndex = 1;
                    pvAnims.Visible = false;
                    richTextBox1.Enabled = false;
                    richTextBox1.Visible = false;

                    richTextBox1.Text = "";
                    break;

                case 65:
                    //listBox1.SelectedIndex = 1;
                    pvAnims.Visible = false;
                    richTextBox1.Enabled = false;
                    richTextBox1.Visible = false;

                    richTextBox1.Text = "";
                    break;

                case 66:
                    //listBox1.SelectedIndex = 1;
                    pvAnims.Visible = false;
                    richTextBox1.Enabled = false;
                    richTextBox1.Visible = false;

                    richTextBox1.Text = "";
                    break;

                case 79:
                    //listBox1.SelectedIndex = 1;
                    pvAnims.Visible = false;
                    richTextBox1.Enabled = false;
                    richTextBox1.Visible = false;

                    richTextBox1.Text = "";
                    break;

                case 80:
                    //listBox1.SelectedIndex = 1;
                    pvAnims.Visible = false;
                    richTextBox1.Enabled = false;
                    richTextBox1.Visible = false;

                    richTextBox1.Text = "";
                    break;

                case 87:
                    //listBox1.SelectedIndex = 1;
                    pvAnims.Visible = false;
                    richTextBox1.Enabled = false;
                    richTextBox1.Visible = false;

                    richTextBox1.Text = "";
                    break;

                case 88:
                    //listBox1.SelectedIndex = 1;
                    pvAnims.Visible = false;
                    richTextBox1.Enabled = false;
                    richTextBox1.Visible = false;

                    richTextBox1.Text = "";
                    break;

                case 99:
                    //listBox1.SelectedIndex = 1;
                    pvAnims.Visible = false;
                    richTextBox1.Enabled = false;
                    richTextBox1.Visible = false;

                    richTextBox1.Text = "";
                    break;

                case 100:
                    //listBox1.SelectedIndex = 1;
                    pvAnims.Visible = false;
                    richTextBox1.Enabled = false;
                    richTextBox1.Visible = false;

                    richTextBox1.Text = "";
                    break;

                case 106:
                    //listBox1.SelectedIndex = 1;
                    pvAnims.Visible = false;
                    richTextBox1.Enabled = false;
                    richTextBox1.Visible = false;

                    richTextBox1.Text = "";
                    break;

                case 107:
                    //listBox1.SelectedIndex = 1;
                    pvAnims.Visible = false;
                    richTextBox1.Enabled = false;
                    richTextBox1.Visible = false;

                    richTextBox1.Text = "";
                    break;

                case 115:
                    //listBox1.SelectedIndex = 1;
                    pvAnims.Visible = false;
                    richTextBox1.Enabled = false;
                    richTextBox1.Visible = false;

                    richTextBox1.Text = "";
                    break;

                case 116:
                    //listBox1.SelectedIndex = 1;
                    pvAnims.Visible = false;
                    richTextBox1.Enabled = false;
                    richTextBox1.Visible = false;

                    richTextBox1.Text = "";
                    break;

                case 119:
                    //listBox1.SelectedIndex = 1;
                    pvAnims.Visible = false;
                    richTextBox1.Enabled = false;
                    richTextBox1.Visible = false;

                    richTextBox1.Text = "";
                    break;

                case 120:
                    //listBox1.SelectedIndex = 1;
                    pvAnims.Visible = false;
                    richTextBox1.Enabled = false;
                    richTextBox1.Visible = false;

                    richTextBox1.Text = "";
                    break;

                case 123:
                    //listBox1.SelectedIndex = 1;
                    pvAnims.Visible = false;
                    richTextBox1.Enabled = false;
                    richTextBox1.Visible = false;

                    richTextBox1.Text = "";
                    break;

                case 124:
                    //listBox1.SelectedIndex = 1;
                    pvAnims.Visible = false;
                    richTextBox1.Enabled = false;
                    richTextBox1.Visible = false;

                    richTextBox1.Text = "";
                    break;

                case 127:
                    //listBox1.SelectedIndex = 1;
                    pvAnims.Visible = false;
                    richTextBox1.Enabled = false;
                    richTextBox1.Visible = false;

                    richTextBox1.Text = "";
                    break;

                case 128:
                    //listBox1.SelectedIndex = 1;
                    pvAnims.Visible = false;
                    richTextBox1.Enabled = false;
                    richTextBox1.Visible = false;

                    richTextBox1.Text = "";
                    break;

                case 131:
                    //listBox1.SelectedIndex = 1;
                    pvAnims.Visible = false;
                    richTextBox1.Enabled = false;
                    richTextBox1.Visible = false;

                    richTextBox1.Text = "";
                    break;

                case 132:
                    //listBox1.SelectedIndex = 1;
                    pvAnims.Visible = false;
                    richTextBox1.Enabled = false;
                    richTextBox1.Visible = false;

                    richTextBox1.Text = "";
                    break;

                case 137:
                    //listBox1.SelectedIndex = 1;
                    pvAnims.Visible = false;
                    richTextBox1.Enabled = false;
                    richTextBox1.Visible = false;

                    richTextBox1.Text = "";
                    break;

                case 138:
                    //listBox1.SelectedIndex = 1;
                    pvAnims.Visible = false;
                    richTextBox1.Enabled = false;
                    richTextBox1.Visible = false;

                    richTextBox1.Text = "";
                    break;

                case 157:
                    //listBox1.SelectedIndex = 1;
                    pvAnims.Visible = false;
                    richTextBox1.Enabled = false;
                    richTextBox1.Visible = false;

                    richTextBox1.Text = "";
                    break;

                case 158:
                    //listBox1.SelectedIndex = 1;
                    pvAnims.Visible = false;
                    richTextBox1.Enabled = false;
                    richTextBox1.Visible = false;

                    richTextBox1.Text = "";
                    break;

                case 163:
                    //listBox1.SelectedIndex = 1;
                    pvAnims.Visible = false;
                    richTextBox1.Enabled = false;
                    richTextBox1.Visible = false;

                    richTextBox1.Text = "";
                    break;

                case 164:
                    //listBox1.SelectedIndex = 1;
                    pvAnims.Visible = false;
                    richTextBox1.Enabled = false;
                    richTextBox1.Visible = false;

                    richTextBox1.Text = "";
                    break;

                case 169:
                    //listBox1.SelectedIndex = 1;
                    pvAnims.Visible = false;
                    richTextBox1.Enabled = false;
                    richTextBox1.Visible = false;

                    richTextBox1.Text = "";
                    break;

                case 170:
                    //listBox1.SelectedIndex = 1;
                    pvAnims.Visible = false;
                    richTextBox1.Enabled = false;
                    richTextBox1.Visible = false;

                    richTextBox1.Text = "";
                    break;
            }
        }

        /* #################################### Mouse Settings ########################################## */
        private void Animations_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
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
