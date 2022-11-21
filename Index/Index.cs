using System;
using System.Windows.Forms;


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
            TLabel01();
            TLabel02();
            TLabel03();
            TLabel04();
            TLabel05();
            TLabel06();
            TLabel07();
            TLabel08();
            GBMessage();
        }

        public void GBMessage()
        {
            GroupBox GBMsg = new GroupBox();
            GBMsg.AutoSize = true;
            GBMsg.BackColor = System.Drawing.Color.Transparent;
            GBMsg.Location = new System.Drawing.Point(56,256);
            GBMsg.Size = new System.Drawing.Size(510, 165);
            GBMsg.Name = "GBMsg";
            GBMsg.Text = "";
            GBMsg.TabIndex = 0;
            GBMsg.SendToBack();
            panel2.Controls.Add(GBMsg);
        }

        public void TLabel01() {
            Label tMessage1 = new Label();
            tMessage1.AutoSize = true;
            tMessage1.ForeColor = System.Drawing.Color.White;
            tMessage1.BackColor = System.Drawing.Color.Transparent;
            tMessage1.Location = new System.Drawing.Point(70, 284);
            tMessage1.Size = new System.Drawing.Size(35, 13);
            tMessage1.Name = "tMessage1";
            tMessage1.Text = "Thanks for using VisualTextures.";
            tMessage1.BringToFront();
            tMessage1.TabIndex = 0;
            panel2.Controls.Add(tMessage1);
        }
        public void TLabel02(){
            Label tMessage2 = new Label();
            tMessage2.AutoSize = true;
            tMessage2.ForeColor = System.Drawing.Color.White;
            tMessage2.Location = new System.Drawing.Point(70, 298);
            tMessage2.Size = new System.Drawing.Size(35, 13);
            tMessage2.Name = "tMessage2";
            tMessage2.Text = "This tool has been created in order to provide much faster information, when it comes";
            tMessage2.TabIndex = 0;
            panel2.Controls.Add(tMessage2);
        }
        public void TLabel03(){
            Label tMessage3 = new Label();
            tMessage3.AutoSize = true;
            tMessage3.ForeColor = System.Drawing.Color.White;
            tMessage3.Location = new System.Drawing.Point(70, 312);
            tMessage3.Size = new System.Drawing.Size(35, 13);
            tMessage3.Name = "tMessage3";
            tMessage3.Text = "to needing any type of information, with regard to: Functions, textures, objects, sounds, among others.";
            tMessage3.TabIndex = 0;
            panel2.Controls.Add(tMessage3);
        }
        public void TLabel04(){
            Label tMessage4 = new Label();
            tMessage4.AutoSize = true;
            tMessage4.ForeColor = System.Drawing.Color.White;
            tMessage4.Location = new System.Drawing.Point(70, 326);
            tMessage4.Size = new System.Drawing.Size(35, 13);
            tMessage4.Name = "tMessage4";
            tMessage4.Text = "At the moment, this tool is in the BETA Phase, we are constantly working to update the data and the";
            tMessage4.TabIndex = 0;
            panel2.Controls.Add(tMessage4);
        }
        public void TLabel05(){
            Label tMessage5 = new Label();
            tMessage5.AutoSize = true;
            tMessage5.ForeColor = System.Drawing.Color.White;
            tMessage5.Location = new System.Drawing.Point(70, 340);
            tMessage5.Size = new System.Drawing.Size(35, 13);
            tMessage5.Name = "tMessage5";
            tMessage5.Text = "content that is provided.";
            tMessage5.TabIndex = 0;
            panel2.Controls.Add(tMessage5);
        }
        public void TLabel06(){
            Label tMessage6 = new Label();
            tMessage6.AutoSize = true;
            tMessage6.ForeColor = System.Drawing.Color.White;
            tMessage6.Location = new System.Drawing.Point(70, 354);
            tMessage6.Size = new System.Drawing.Size(35, 13);
            tMessage6.Name = "tMessage6";
            tMessage6.Text = "VisualTexture has as its only purpose, to provide data to the user, in case the person doesn't have a";
            tMessage6.TabIndex = 0;
            panel2.Controls.Add(tMessage6);
        }
        public void TLabel07(){
            Label tMessage7 = new Label();
            tMessage7.AutoSize = true;
            tMessage7.ForeColor = System.Drawing.Color.White;
            tMessage7.Location = new System.Drawing.Point(70, 368);
            tMessage7.Size = new System.Drawing.Size(35, 13);
            tMessage7.Name = "tMessage7";
            tMessage7.Text = "network available, and information regarding pwn is needed quickly, or as mentioned above, we only";
            tMessage7.TabIndex = 0;
            panel2.Controls.Add(tMessage7);
        }
        public void TLabel08(){
            Label tMessage8 = new Label();
            tMessage8.AutoSize = true;
            tMessage8.ForeColor = System.Drawing.Color.White;
            tMessage8.Location = new System.Drawing.Point(70, 382);
            tMessage8.Size = new System.Drawing.Size(35, 13);
            tMessage8.Name = "tMessage8";
            tMessage8.Text = "provide more 'quick' information.";
            tMessage8.TabIndex = 0;
            panel2.Controls.Add(tMessage8);
        }


        private void Index_Load(object sender, EventArgs e){}

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
        private void panel2_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
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

        /* #################################### Categorys/Options ########################################## */
        private void btnAnimations_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sections.Animations Component1 = new Sections.Animations();
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
