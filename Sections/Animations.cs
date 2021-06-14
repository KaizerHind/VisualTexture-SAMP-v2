using System;
using System.IO;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;


namespace VisualTexture_v2.Sections
{
    public partial class Animations : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public ChromiumWebBrowser chromeBrowser;
        public CefSharp.WinForms.ChromiumWebBrowser browser;

        public void InitializeChromium()
        {
            //Visualization solution in Cefsharp - by DarThinking
            CefSettings settings = new CefSettings();
            //Cef.Initialize(settings);
            chromeBrowser = new ChromiumWebBrowser("http://www.thornhillbc.org.uk/wp/wp-content/uploads/2017/09/Refresh-Logo-1024x604.jpg")
            {
                Dock = DockStyle.Fill,
            };
            panel3.Controls.Add(chromeBrowser);
        }

        public Animations()
        {
            InitializeComponent();
            InitializeChromium();


            listBox1.Items.AddRange(new object[] {
            "[PED]",
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
            "-  IDLE_stance",
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
            "-  WALK_old",
            "-  WALK_player",
            "-  WALK_rocket",
            "-  WALK_shuffle",
            "-  Walk_Wuzi",
            "-  WOMAN_walkbusy",
            "-  WOMAN_walkfatold",
            "-  WOMAN_walknorm",
            "-  WOMAN_walkold",
            "-  WOMAN_walkpro",
            "-  WOMAN_walksexy",
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
            richTextBox2.Visible = false;
            panel3.Visible = false;
        }


        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (listBox1.FindString(listBox1.SelectedItem.ToString()))
            {
                case 0:

                    panel3.Visible = false;
                    richTextBox1.Visible = false;
                    richTextBox2.Visible = false;

                    break;

                case 1:
                    panel3.Visible = true;
                    richTextBox1.Visible = true;
                    richTextBox2.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/arrestgun/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, ARRESTgunt, 4.0, 1, 1, 1, 0, 0)";
                    break;

                case 2:
                    panel3.Visible = true;
                    richTextBox1.Visible = true;
                    richTextBox2.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/ATM/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, ARRESTgunit, 4.0, 1, 1, 1, 0, 0)";
                    break;

                case 3:
                    panel3.Visible = true;
                    richTextBox1.Visible = true;
                    richTextBox2.Visible = true;
                    chromeBrowser.Load("https://demo-anims.netlify.app/bomber/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, bomber, 4.0, 1, 1, 1, 0, 0)";
                    break;

                case 4:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/car_crawloutrhs/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, car_crawloutrhs, 4.0, 1, 1, 1, 0, 0)";
                    break;

                case 5:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/car_doorlocked_lhs/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, car_doorlocked_rhs, 4.0, 1, 1, 1, 0, 0)";
                    break;

                case 6:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/car_doorlocked_rhs");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, car_doorlocked_rhs, 4.0, 1, 1, 1, 0, 0)";
                    break;

                case 7:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/cower/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, cower, 4.0, 1, 1, 1, 0, 0)";
                    break;

                case 8:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/endchat_01/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, endchat_01, 4.0, 1, 1, 1, 0, 0)";
                    break;

                case 9:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/endchat_02/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, endchat_02, 4.0, 1, 1, 1, 0, 0)";
                    break;

                case 10:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/endchat_03/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, endchat_03, 4.0, 1, 1, 1, 0, 0)";
                    break;

                case 11:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/facgum/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, facgum, 4.0, 1, 1, 1, 0, 0)";
                    break;

                case 12:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/fall_skydive/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, fall_skydive, 4.0, 1, 1, 1, 0, 0)";
                    break;

                case 13:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/flee_lkaround_01/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, flee_lkaround_01, 4.0, 1, 1, 1, 0, 0)";
                    break;

                case 14:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/fucku/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, fucku, 4.0, 1, 1, 1, 0, 0)";
                    break;

                case 15:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/gas_cwr/");

                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, gas_cwr, 4.0, 1, 1, 1, 0, 0)";
                    break;

                case 16:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/gum_eat/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, gum_eat, 4.0, 1, 1, 1, 0, 0)";
                    break;

                case 17:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/handsup/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, handsup, 4.0, 1, 1, 1, 0, 0)";
                    break;

                case 18:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/HIT_walk/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, HIT_walk, 4.0, 1, 1, 1, 0, 0)";
                    break;

                case 19:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/IDLE_chat/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, IDLE_chat, 4.0, 1, 1, 1, 0, 0)";
                    break;

                case 20:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/IDLE_HBHB/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, IDLE_HBHB, 4.0, 1, 1, 1, 0, 0)";
                    break;

                case 21:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/IDLE_ROCKET/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, IDLE_ROCKET, 4.0, 1, 1, 1, 0, 0)";
                    break;

                case 22:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/IDLE_stance/");

                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, IDLE_stance, 4.0, 1, 1, 1, 0, 0)";
                    break;

                case 23:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/IDLE_taxi/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, ,IDLE_taxi 4.0, 1, 1, 1, 0, 0)";
                    break;

                case 24:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/IDLE_tired/");

                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, IDLE_tired, 4.0, 1, 1, 1, 0, 0)";
                    break;

                case 25:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/KO_shot_face/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, KO_shot_face, 4.0, 1, 1, 1, 0, 0)";
                    break;

                case 26:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/KO_shot_front/");

                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, KO_shot_front, 4.0, 1, 1, 1, 0, 0)";
                    break;

                case 27:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/KO_shot_stom/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, KO_shot_stom, 4.0, 1, 1, 1, 0, 0)";
                    break;

                case 28:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/KO_skid_front/");

                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, KO_skid_front, 4.0, 1, 1, 1, 0, 0)";
                    break;

                case 29:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/pass_Smoke_in_car/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, pass_Smoke_in_car, 4.0, 1, 1, 1, 0, 0)";
                    break;

                case 30:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/phone_in/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, phone_in, 4.0, 1, 1, 1, 0, 0)";
                    break;      

                case 31:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/phone_out/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, phone_out, 4.0, 1, 1, 1, 0, 0)";
                    break; 

                 case 32:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/phone_talk/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, phone_talk, 4.0, 1, 1, 1, 0, 0)";
                    break;      

                case 33:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/roadcross/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, roadcross, 4.0, 1, 1, 1, 0, 0)";
                    break; 

                case 34:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/run_1armed/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, run_1armed, 4.0, 1, 1, 1, 0, 0)";
                    break;      

                case 35:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/run_armed/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, run_armed, 4.0, 1, 1, 1, 0, 0)";
                    break; 

                case 36:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/run_civi/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, run_civi, 4.0, 1, 1, 1, 0, 0)";
                    break;      

                case 37:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/run_fatold/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, run_fatold, 4.0, 1, 1, 1, 0, 0)";
                    break; 

                case 38:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/run_gang1/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, run_gang1, 4.0, 1, 1, 1, 0, 0)";
                    break;      

                case 39:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/run_old/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, run_old, 4.0, 1, 1, 1, 0, 0)";
                    break; 

                case 40:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/run_player/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, run_player, 4.0, 1, 1, 1, 0, 0)";
                    break;      

                case 41:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/Run_stop/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, Run_stop, 4.0, 1, 1, 1, 0, 0)";
                    break; 

                case 42:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/Run_Wuzi/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, Run_Wuzi, 4.0, 1, 1, 1, 0, 0)";
                    break;      

                case 43:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/SEAT_down/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, SEAT_down, 4.0, 1, 1, 1, 0, 0)";
                    break; 

                case 44:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/SEAT_idle/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, SEAT_idle, 4.0, 1, 1, 1, 0, 0)";
                    break;      

                case 45:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/SEAT_up/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, SEAT_up, 4.0, 1, 1, 1, 0, 0)";
                    break; 

                case 46:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/Smoke_in_car/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, Smoke_in_car, 4.0, 1, 1, 1, 0, 0)";
                    break;      

                case 47:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/Swim_Tread/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, Swim_Tread, 4.0, 1, 1, 1, 0, 0)";
                    break; 

                case 48:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/WALK_drunk/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, WALK_drunk, 4.0, 1, 1, 1, 0, 0)";
                    break;      

                case 49:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/WALK_fatold/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, WALK_fatold, 4.0, 1, 1, 1, 0, 0)";
                    break; 

                case 50:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/WALK_gang1/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, WALK_gang1, 4.0, 1, 1, 1, 0, 0)";
                    break;      

                case 51:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/WALK_gang2/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, WALK_gang2, 4.0, 1, 1, 1, 0, 0)";
                    break; 

                case 52:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/WALK_old/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, WALK_old, 4.0, 1, 1, 1, 0, 0)";
                    break;      

                case 53:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/WALK_player/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, WALK_player, 4.0, 1, 1, 1, 0, 0)";
                    break; 

                case 54:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/WALK_rocket/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, WALK_rocket, 4.0, 1, 1, 1, 0, 0)";
                    break;

                case 55:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/WALK_shuffle/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, WALK_shuffle, 4.0, 1, 1, 1, 0, 0)";
                    break; 

                case 56:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/Walk_Wuzi/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, Walk_Wuzi, 4.0, 1, 1, 1, 0, 0)";
                    break;      

                case 57:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/WOMAN_walkbusy/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, WOMAN_walkbusy, 4.0, 1, 1, 1, 0, 0)";
                    break; 

                case 58:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/WOMAN_walkfatold/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, WOMAN_walkfatold, 4.0, 1, 1, 1, 0, 0)";
                    break;      

                case 59:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/WOMAN_walknorm/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, WOMAN_walknorm, 4.0, 1, 1, 1, 0, 0)";
                    break; 

                case 60:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/WOMAN_walkold/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, WOMAN_walkold, 4.0, 1, 1, 1, 0, 0)";
                    break;      

                case 61:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/WOMAN_walkpro/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, WOMAN_walkpro, 4.0, 1, 1, 1, 0, 0)";
                    break; 

                case 62:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/WOMAN_walksexy/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, WOMAN_walksexy, 4.0, 1, 1, 1, 0, 0)";
                    break;      

                case 63:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/WOMAN_walkshop/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, WOMAN_walkshop, 4.0, 1, 1, 1, 0, 0)";
                    break; 

                 case 64:
                    richTextBox1.Visible = true;
                    richTextBox1.ReadOnly = true;
                    panel3.Visible = true;

                    chromeBrowser.Load("https://demo-anims.netlify.app/XPRESSscratch/");
                    richTextBox1.Text = "new Variable Var = CreateActor(ID, X, Y, Z, RZ);";
                    richTextBox2.Text = "ApplyActorAnimation(Variable, PED, XPRESSscratch, 4.0, 1, 1, 1, 0, 0)";
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Index Component1 = new Index();
            Component1.Show();
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
        private void btnSpray_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sections.VSprites Component1 = new Sections.VSprites();
            Component1.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Cef.Shutdown();
        }
    }
}
