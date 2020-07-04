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
    public partial class vTextures : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        public vTextures()
        {
            InitializeComponent();
        }

        private void vTextures_Load(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(new object[] {
                "1.- Doors", "2.- Walls", "3.- Windows", "4.- Floors", "5.-Metals", "6- Colors", "7.- Furnitures", "8.- Accesories", "9.- Random"
            });
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    {
                        // Habilitacion de RadioButtons.'
                        panel3.Show();
                        /*RadioButton1.Visible = true;
                        RadioButton2.Visible = true;
                        RadioButton3.Visible = true;
                        RadioButton4.Visible = true;
                        RadioButton5.Visible = true;
                        RadioButton6.Visible = true;
                        RadioButton7.Visible = true;
                        RadioButton8.Visible = true;
                        RadioButton9.Visible = true;
                        RadioButton10.Visible = true;
                        RadioButton11.Visible = true;
                        RadioButton12.Visible = true;
                        RadioButton13.Visible = true;
                        RadioButton14.Visible = true;
                        RadioButton15.Visible = true;
                        RadioButton16.Visible = true;
                        RadioButton17.Visible = true;
                        RadioButton18.Visible = true;
                        RadioButton19.Visible = true;
                        RadioButton20.Visible = true;
                        RadioButton21.Visible = true;
                        RadioButton22.Visible = true;
                        RadioButton23.Visible = true;
                        RadioButton24.Visible = true;
                        RadioButton25.Visible = true;
                        RadioButton26.Visible = true;
                        RadioButton27.Visible = true;
                        RadioButton28.Visible = true;
                        RadioButton29.Visible = true;
                        RadioButton30.Visible = true;
                        RadioButton31.Visible = true;
                        RadioButton32.Visible = true;
                        RadioButton33.Visible = true;
                        RadioButton34.Visible = true;
                        RadioButton35.Visible = true;
                        RadioButton36.Visible = true;
                        RadioButton37.Visible = true;
                        RadioButton38.Visible = true;
                        RadioButton39.Visible = true;
                        RadioButton40.Visible = true;
                        RadioButton41.Visible = true;
                        RadioButton42.Visible = true;
                        RadioButton43.Visible = true;
                        RadioButton44.Visible = true;
                        RadioButton45.Visible = true;
                        RadioButton46.Visible = true;
                        RadioButton47.Visible = true;
                        RadioButton48.Visible = true;
                        RadioButton49.Visible = true;
                        RadioButton50.Visible = true;
                        RadioButton51.Visible = true;
                        RadioButton52.Visible = true;
                        RadioButton53.Visible = true;
                        RadioButton54.Visible = true;
                        RadioButton55.Visible = true;
                        RadioButton56.Visible = true;
                        RadioButton57.Visible = true;
                        RadioButton58.Visible = true;
                        RadioButton59.Visible = true;
                        RadioButton60.Visible = true;
                        RadioButton61.Visible = true;
                        RadioButton62.Visible = true;
                        RadioButton63.Visible = true;
                        RadioButton64.Visible = true;
                        RadioButton65.Visible = true;
                        RadioButton66.Visible = true;
                        RadioButton67.Visible = true;
                        RadioButton68.Visible = true;
                        RadioButton69.Visible = true;
                        RadioButton70.Visible = true;
                        RadioButton71.Visible = true;
                        RadioButton72.Visible = true;
                        RadioButton73.Visible = true;
                        RadioButton74.Visible = true;
                        RadioButton75.Visible = true;
                        RadioButton76.Visible = true;
                        RadioButton77.Visible = true;
                        RadioButton78.Visible = true;
                        RadioButton79.Visible = true;
                        RadioButton80.Visible = true;
                        RadioButton81.Visible = true;
                        RadioButton82.Visible = true;
                        RadioButton83.Visible = true;
                        RadioButton84.Visible = true;
                        RadioButton85.Visible = true;
                        RadioButton86.Visible = true;
                        RadioButton87.Visible = true;
                        RadioButton88.Visible = true;
                        RadioButton89.Visible = true;
                        RadioButton90.Visible = true;
                        RadioButton91.Visible = true;
                        RadioButton92.Visible = true;
                        RadioButton93.Visible = true;
                        RadioButton94.Visible = true;
                        RadioButton95.Visible = true;
                        RadioButton96.Visible = true;
                        RadioButton97.Visible = true;
                        RadioButton98.Visible = true;
                        RadioButton99.Visible = true;
                        RadioButton100.Visible = true;
                        RadioButton101.Visible = true;
                        RadioButton102.Visible = true;
                        RadioButton103.Visible = true;
                        RadioButton104.Visible = true;
                        RadioButton105.Visible = true;
                        RadioButton106.Visible = true;
                        RadioButton107.Visible = true;
                        RadioButton108.Visible = true;
                        RadioButton109.Visible = true;
                        RadioButton110.Visible = true;
                        RadioButton111.Visible = true;
                        RadioButton112.Visible = true;
                        RadioButton113.Visible = true;
                        RadioButton114.Visible = true;
                        RadioButton115.Visible = true;
                        RadioButton116.Visible = true;
                        RadioButton117.Visible = true;
                        RadioButton118.Visible = true;
                        RadioButton119.Visible = true;
                        RadioButton120.Visible = true;
                        RadioButton121.Visible = true;
                        RadioButton122.Visible = true;
                        RadioButton123.Visible = true;
                        RadioButton124.Visible = true;
                        RadioButton125.Visible = true;
                        RadioButton126.Visible = true;
                        RadioButton127.Visible = true;
                        RadioButton128.Visible = true;
                        RadioButton129.Visible = true;
                        RadioButton130.Visible = true;
                        RadioButton131.Visible = true;
                        RadioButton132.Visible = true;
                        RadioButton133.Visible = true;
                        RadioButton134.Visible = true;
                        RadioButton135.Visible = true;
                        RadioButton136.Visible = true;
                        RadioButton137.Visible = true;
                        RadioButton138.Visible = true;
                        RadioButton139.Visible = true;
                        RadioButton140.Visible = true;
                        RadioButton141.Visible = true;
                        RadioButton142.Visible = true;
                        RadioButton143.Visible = true;
                        RadioButton144.Visible = true;
                        RadioButton145.Visible = true;
                        RadioButton146.Visible = true;
                        RadioButton147.Visible = true;
                        RadioButton148.Visible = true;
                        RadioButton149.Visible = true;
                        RadioButton150.Visible = true;
                        RadioButton151.Visible = true;
                        RadioButton152.Visible = true;
                        RadioButton153.Visible = true;
                        RadioButton154.Visible = true;
                        RadioButton155.Visible = true;
                        RadioButton156.Visible = true;
                        RadioButton157.Visible = true;
                        RadioButton158.Visible = true;
                        RadioButton159.Visible = true;
                        RadioButton160.Visible = true;
                        RadioButton161.Visible = true;
                        RadioButton162.Visible = true;
                        RadioButton163.Visible = true;
                        RadioButton164.Visible = true;
                        RadioButton165.Visible = true;
                        RadioButton166.Visible = true;
                        RadioButton167.Visible = true;
                        RadioButton168.Visible = true;
                        RadioButton169.Visible = true;
                        RadioButton170.Visible = true;
                        RadioButton171.Visible = true;
                        RadioButton172.Visible = true;
                        RadioButton173.Visible = true;
                        RadioButton174.Visible = true;
                        RadioButton175.Visible = true;
                        RadioButton176.Visible = true;
                        RadioButton177.Visible = true;
                        RichTextBox1.Text = "";

                        // Item: Puertas.
                        PictureBox1.Image = global::VisualTextures.My.Resources.a51_blastdoor;
                        PictureBox1.Visible = true;
                        PictureBox2.Image = global::VisualTextures.My.Resources.a51_intdoor;
                        PictureBox2.Visible = true;
                        PictureBox3.Image = global::VisualTextures.My.Resources.a51_weedoors;
                        PictureBox3.Visible = true;
                        PictureBox4.Image = global::VisualTextures.My.Resources.aarprt6LAS;
                        PictureBox4.Visible = true;
                        PictureBox5.Image = global::VisualTextures.My.Resources.alleydoor2;
                        PictureBox5.Visible = true;
                        PictureBox6.Image = global::VisualTextures.My.Resources.alleydoor9b;
                        PictureBox6.Visible = true;
                        PictureBox7.Image = global::VisualTextures.My.Resources.ballydoor01_128;
                        PictureBox7.Visible = true;
                        PictureBox8.Image = global::VisualTextures.My.Resources.Bow_Loadingbay_Door;
                        PictureBox8.Visible = true;
                        PictureBox9.Image = global::VisualTextures.My.Resources.compdoor2_LAe;
                        PictureBox9.Visible = true;
                        PictureBox10.Image = global::VisualTextures.My.Resources.compdoor4_LAe;
                        PictureBox10.Visible = true;
                        PictureBox11.Image = global::VisualTextures.My.Resources.comptdoor2;
                        PictureBox11.Visible = true;
                        PictureBox12.Image = global::VisualTextures.My.Resources.corporate1;
                        PictureBox12.Visible = true;
                        PictureBox13.Image = global::VisualTextures.My.Resources.corporate3green_128;
                        PictureBox13.Visible = true;
                        PictureBox14.Image = global::VisualTextures.My.Resources.des_backdoor1;
                        PictureBox14.Visible = true;
                        PictureBox15.Image = global::VisualTextures.My.Resources.flatdoor01_law;
                        PictureBox15.Visible = true;
                        PictureBox16.Image = global::VisualTextures.My.Resources.garagedoor4_law;
                        PictureBox16.Visible = true;
                        PictureBox17.Image = global::VisualTextures.My.Resources.GB_truckdepot29;
                        PictureBox17.Visible = true;
                        PictureBox18.Image = global::VisualTextures.My.Resources.gz_vicdoor1;
                        PictureBox18.Visible = true;
                        PictureBox19.Image = global::VisualTextures.My.Resources.gz_vicdoor2;
                        PictureBox19.Visible = true;
                        PictureBox20.Image = global::VisualTextures.My.Resources.lasbevcit7;
                        PictureBox20.Visible = true;
                        PictureBox21.Image = global::VisualTextures.My.Resources.lasjmdoorgud;
                        PictureBox21.Visible = true;
                        PictureBox22.Image = global::VisualTextures.My.Resources.lasmalhus92;
                        PictureBox22.Visible = true;
                        PictureBox23.Image = global::VisualTextures.My.Resources.liftdoorsac256;
                        PictureBox23.Visible = true;
                        PictureBox24.Image = global::VisualTextures.My.Resources.LoadingDoorClean;
                        PictureBox24.Visible = true;
                        PictureBox25.Image = global::VisualTextures.My.Resources.shopdoor01_law;
                        PictureBox25.Visible = true;
                        PictureBox26.Image = global::VisualTextures.My.Resources.sjmhoodalldr;
                        PictureBox26.Visible = true;
                        PictureBox27.Image = global::VisualTextures.My.Resources.staddoors1;
                        PictureBox27.Visible = true;
                        PictureBox28.Image = global::VisualTextures.My.Resources.sw_door12;
                        PictureBox28.Visible = true;
                        PictureBox29.Image = global::VisualTextures.My.Resources.sw_sheddoor2;
                        PictureBox29.Visible = true;
                        PictureBox30.Image = global::VisualTextures.My.Resources.vgncorpdoor1_512;
                        PictureBox30.Visible = true;
                        PictureBox31.Image = global::VisualTextures.My.Resources.vgsclubdoor02_128;
                        PictureBox31.Visible = true;
                        PictureBox32.Image = global::VisualTextures.My.Resources.Was_scrpyd_door_in_hngr;
                        PictureBox32.Visible = true;
                        PictureBox33.Image = global::VisualTextures.My.Resources.wilsdoor_01_la;
                        PictureBox33.Visible = true;
                        PictureBox34.Image = global::VisualTextures.My.Resources.ws_airportdoors1;
                        PictureBox34.Visible = true;
                        PictureBox35.Image = global::VisualTextures.My.Resources.ws_airportwin2;
                        PictureBox35.Visible = true;
                        PictureBox36.Image = global::VisualTextures.My.Resources.ws_altz_wall5_door;
                        PictureBox36.Visible = true;
                        PictureBox37.Image = global::VisualTextures.My.Resources.ws_doubledoor1;
                        PictureBox37.Visible = true;
                        PictureBox38.Image = global::VisualTextures.My.Resources.ws_doubledoor4;
                        PictureBox38.Visible = true;
                        PictureBox39.Image = global::VisualTextures.My.Resources.ws_guardhousedoor;
                        PictureBox39.Visible = true;
                        PictureBox40.Image = global::VisualTextures.My.Resources.ws_rollerdoor_fire;
                        PictureBox40.Visible = true;
                        PictureBox41.Image = global::VisualTextures.My.Resources.alleydoor3;
                        PictureBox41.Visible = true;
                        PictureBox42.Image = global::VisualTextures.My.Resources.alleydoor4;
                        PictureBox42.Visible = true;
                        PictureBox43.Image = global::VisualTextures.My.Resources.alleydoor6;
                        PictureBox43.Visible = true;
                        PictureBox44.Image = global::VisualTextures.My.Resources.alleydoor8;
                        PictureBox44.Visible = true;
                        PictureBox45.Image = global::VisualTextures.My.Resources.bevdoor01_law;
                        PictureBox45.Visible = true;
                        PictureBox46.Image = global::VisualTextures.My.Resources.bigwhite_4;
                        PictureBox46.Visible = true;
                        PictureBox47.Image = global::VisualTextures.My.Resources.bigwhite_5;
                        PictureBox47.Visible = true;
                        PictureBox48.Image = global::VisualTextures.My.Resources.Bow_bar_entrance_door;
                        PictureBox48.Visible = true;
                        PictureBox49.Image = global::VisualTextures.My.Resources.Bow_LoadingBayDoor;
                        PictureBox49.Visible = true;
                        PictureBox50.Image = global::VisualTextures.My.Resources.clubdoor1_256;
                        PictureBox50.Visible = true;
                        PictureBox51.Image = global::VisualTextures.My.Resources.comptdoor3;
                        PictureBox51.Visible = true;
                        PictureBox52.Image = global::VisualTextures.My.Resources.comptdoor4;
                        PictureBox52.Visible = true;
                        PictureBox53.Image = global::VisualTextures.My.Resources.garagedoor5_law;
                        PictureBox53.Visible = true;
                        PictureBox54.Image = global::VisualTextures.My.Resources.garargeb2;
                        PictureBox54.Visible = true;
                        PictureBox55.Image = global::VisualTextures.My.Resources.gz_sf_door12b;
                        PictureBox55.Visible = true;
                        PictureBox56.Image = global::VisualTextures.My.Resources.halldoor01_law;
                        PictureBox56.Visible = true;
                        PictureBox57.Image = global::VisualTextures.My.Resources.hosdoor01_law;
                        PictureBox57.Visible = true;
                        PictureBox58.Image = global::VisualTextures.My.Resources.int02_128;
                        PictureBox58.Visible = true;
                        PictureBox59.Image = global::VisualTextures.My.Resources.liftdoors_kb_256;
                        PictureBox59.Visible = true;
                        PictureBox60.Image = global::VisualTextures.My.Resources.Lombard_door1;
                        PictureBox60.Visible = true;
                        PictureBox61.Image = global::VisualTextures.My.Resources.metaldoor01_256;
                        PictureBox61.Visible = true;
                        PictureBox62.Image = global::VisualTextures.My.Resources.pawn_door01;
                        PictureBox62.Visible = true;
                        PictureBox63.Image = global::VisualTextures.My.Resources.plainwoodoor2;
                        PictureBox63.Visible = true;
                        PictureBox64.Image = global::VisualTextures.My.Resources.sf_garagedr1;
                        PictureBox64.Visible = true;
                        PictureBox65.Image = global::VisualTextures.My.Resources.shitydoor1_256;
                        PictureBox65.Visible = true;
                        PictureBox66.Image = global::VisualTextures.My.Resources.shopgrating128H;
                        PictureBox66.Visible = true;
                        PictureBox67.Image = global::VisualTextures.My.Resources.sl_grngarage1;
                        PictureBox67.Visible = true;
                        PictureBox68.Image = global::VisualTextures.My.Resources.sl_prisongate1;
                        PictureBox68.Visible = true;
                        PictureBox69.Image = global::VisualTextures.My.Resources.sl_shopshttr1;
                        PictureBox69.Visible = true;
                        PictureBox70.Image = global::VisualTextures.My.Resources.sw_backdoor02;
                        PictureBox70.Visible = true;
                        PictureBox71.Image = global::VisualTextures.My.Resources.sw_door11;
                        PictureBox71.Visible = true;
                        PictureBox72.Image = global::VisualTextures.My.Resources.sw_shutters1;
                        PictureBox72.Visible = true;
                        PictureBox73.Image = global::VisualTextures.My.Resources.vengardoor01_SFW;
                        PictureBox73.Visible = true;
                        PictureBox74.Image = global::VisualTextures.My.Resources.ws_basheddoor1;
                        PictureBox74.Visible = true;
                        PictureBox75.Image = global::VisualTextures.My.Resources.ws_bigblackdoor;
                        PictureBox75.Visible = true;
                        PictureBox76.Image = global::VisualTextures.My.Resources.ws_garagedoor2_blue;
                        PictureBox76.Visible = true;
                        PictureBox77.Image = global::VisualTextures.My.Resources.ws_garagedoor2_green;
                        PictureBox77.Visible = true;
                        PictureBox78.Image = global::VisualTextures.My.Resources.ws_garagedoor2_white;
                        PictureBox78.Visible = true;
                        PictureBox79.Image = global::VisualTextures.My.Resources.ws_garagedoor3_green;
                        PictureBox79.Visible = true;
                        PictureBox80.Image = global::VisualTextures.My.Resources.ws_garagedoor3_pink;
                        PictureBox80.Visible = true;
                        PictureBox81.Image = global::VisualTextures.My.Resources.ws_garagedoor3_white;
                        PictureBox81.Visible = true;
                        PictureBox82.Image = global::VisualTextures.My.Resources.ws_garagedoor4_peach;
                        PictureBox82.Visible = true;
                        PictureBox83.Image = global::VisualTextures.My.Resources.ws_glassnbrassdoor;
                        PictureBox83.Visible = true;
                        PictureBox84.Image = global::VisualTextures.My.Resources.ws_hangardoor;
                        PictureBox84.Visible = true;
                        PictureBox85.Image = global::VisualTextures.My.Resources.ws_painted_doors1;
                        PictureBox85.Visible = true;
                        PictureBox86.Image = global::VisualTextures.My.Resources.ws_painted_doors2;
                        PictureBox86.Visible = true;
                        PictureBox87.Image = global::VisualTextures.My.Resources.ws_painted_doors3;
                        PictureBox87.Visible = true;
                        PictureBox88.Image = global::VisualTextures.My.Resources.ws_reinforcedbutwonky;
                        PictureBox88.Visible = true;
                        PictureBox89.Image = global::VisualTextures.My.Resources.ws_rollerdoor_silver;
                        PictureBox89.Visible = true;
                        PictureBox90.Image = global::VisualTextures.My.Resources.ws_security_door;
                        PictureBox90.Visible = true;
                        PictureBox91.Image = global::VisualTextures.My.Resources.ws_wood_doors1;
                        PictureBox91.Visible = true;
                        PictureBox92.Image = global::VisualTextures.My.Resources.ws_wood_doors2;
                        PictureBox92.Visible = true;
                        PictureBox93.Image = global::VisualTextures.My.Resources._711doors1;
                        PictureBox93.Visible = true;
                        PictureBox94.Image = global::VisualTextures.My.Resources.ab_ACcarrierDoor;
                        PictureBox94.Visible = true;
                        PictureBox95.Image = global::VisualTextures.My.Resources.airportdoor1;
                        PictureBox95.Visible = true;
                        PictureBox96.Image = global::VisualTextures.My.Resources.alleydoor1;
                        PictureBox96.Visible = true;
                        PictureBox97.Image = global::VisualTextures.My.Resources.alleydoor7;
                        PictureBox97.Visible = true;
                        PictureBox98.Image = global::VisualTextures.My.Resources.alleydoorb256;
                        PictureBox98.Visible = true;
                        PictureBox99.Image = global::VisualTextures.My.Resources.alleydoorz256;
                        PictureBox99.Visible = true;
                        PictureBox100.Image = global::VisualTextures.My.Resources.bevdoor02_law;
                        PictureBox100.Visible = true;
                        PictureBox101.Image = global::VisualTextures.My.Resources.bevdoor03_law;
                        PictureBox101.Visible = true;
                        PictureBox102.Image = global::VisualTextures.My.Resources.bevdoor04_law;
                        PictureBox102.Visible = true;
                        PictureBox103.Image = global::VisualTextures.My.Resources.Bow_door_graffiti_128;
                        PictureBox103.Visible = true;
                        PictureBox104.Image = global::VisualTextures.My.Resources.Bow_Load_Door;
                        PictureBox104.Visible = true;
                        PictureBox105.Image = global::VisualTextures.My.Resources.cargodoor_128;
                        PictureBox105.Visible = true;
                        PictureBox106.Image = global::VisualTextures.My.Resources.carparkdoor1_256;
                        PictureBox106.Visible = true;
                        PictureBox107.Image = global::VisualTextures.My.Resources.casinodoor_frmnt;
                        PictureBox107.Visible = true;
                        PictureBox108.Image = global::VisualTextures.My.Resources.cityhalldoor1;
                        PictureBox108.Visible = true;
                        PictureBox109.Image = global::VisualTextures.My.Resources.CJ_DOOR6;
                        PictureBox109.Visible = true;
                        PictureBox110.Image = global::VisualTextures.My.Resources.CJ_PIZZA_DOOR;
                        PictureBox110.Visible = true;
                        PictureBox111.Image = global::VisualTextures.My.Resources.CJ_SCOR_DOOR;
                        PictureBox111.Visible = true;
                        PictureBox112.Image = global::VisualTextures.My.Resources.CJ_SUB_DOORS;
                        PictureBox112.Visible = true;
                        PictureBox113.Image = global::VisualTextures.My.Resources.compdoor1_LAe;
                        PictureBox113.Visible = true;
                        PictureBox114.Image = global::VisualTextures.My.Resources.compdoor5_LAe;
                        PictureBox114.Visible = true;
                        PictureBox115.Image = global::VisualTextures.My.Resources.compdoor6_LAe;
                        PictureBox115.Visible = true;
                        PictureBox116.Image = global::VisualTextures.My.Resources.comptdoor1;
                        PictureBox116.Visible = true;
                        PictureBox117.Image = global::VisualTextures.My.Resources.corporate2;
                        PictureBox117.Visible = true;
                        PictureBox118.Image = global::VisualTextures.My.Resources.corporate3;
                        PictureBox118.Visible = true;
                        PictureBox119.Image = global::VisualTextures.My.Resources.crapdoor1_256;
                        PictureBox119.Visible = true;
                        PictureBox120.Image = global::VisualTextures.My.Resources.des_adobedoor1;
                        PictureBox120.Visible = true;
                        PictureBox121.Image = global::VisualTextures.My.Resources.des_adobedoor2;
                        PictureBox121.Visible = true;
                        PictureBox122.Image = global::VisualTextures.My.Resources.des_adobedoor3;
                        PictureBox122.Visible = true;
                        PictureBox123.Image = global::VisualTextures.My.Resources.des_door1;
                        PictureBox123.Visible = true;
                        PictureBox124.Image = global::VisualTextures.My.Resources.des_door2;
                        PictureBox124.Visible = true;
                        PictureBox125.Image = global::VisualTextures.My.Resources.des_greendoor;
                        PictureBox125.Visible = true;
                        PictureBox126.Image = global::VisualTextures.My.Resources.des_metaldoor1;
                        PictureBox126.Visible = true;
                        PictureBox127.Image = global::VisualTextures.My.Resources.des_ntwndoor1;
                        PictureBox127.Visible = true;
                        PictureBox128.Image = global::VisualTextures.My.Resources.des_ntwndoor2;
                        PictureBox128.Visible = true;
                        PictureBox129.Image = global::VisualTextures.My.Resources.des_ntwndoor3;
                        PictureBox129.Visible = true;
                        PictureBox130.Image = global::VisualTextures.My.Resources.des_ntwnwin6;
                        PictureBox130.Visible = true;
                        PictureBox131.Image = global::VisualTextures.My.Resources.des_thfdoor;
                        PictureBox131.Visible = true;
                        PictureBox132.Image = global::VisualTextures.My.Resources.des_wigwamdoor;
                        PictureBox132.Visible = true;
                        PictureBox133.Image = global::VisualTextures.My.Resources.des_woodshopdoor1;
                        PictureBox133.Visible = true;
                        PictureBox134.Image = global::VisualTextures.My.Resources.doornvent256128;
                        PictureBox134.Visible = true;
                        PictureBox135.Image = global::VisualTextures.My.Resources.door_pan1_64_128;
                        PictureBox135.Visible = true;
                        PictureBox136.Image = global::VisualTextures.My.Resources.drvin_door1;
                        PictureBox136.Visible = true;
                        PictureBox137.Image = global::VisualTextures.My.Resources.drvin_door2;
                        PictureBox137.Visible = true;
                        PictureBox138.Image = global::VisualTextures.My.Resources.dt_ind_door;
                        PictureBox138.Visible = true;
                        PictureBox139.Image = global::VisualTextures.My.Resources.dt_scyscrap_door2;
                        PictureBox139.Visible = true;
                        PictureBox140.Image = global::VisualTextures.My.Resources.GB_doorpur01;
                        PictureBox140.Visible = true;
                        PictureBox141.Image = global::VisualTextures.My.Resources.inddoor1;
                        PictureBox141.Visible = true;
                        PictureBox142.Image = global::VisualTextures.My.Resources.inddoor5;
                        PictureBox142.Visible = true;
                        PictureBox143.Image = global::VisualTextures.My.Resources.inddoor7;
                        PictureBox143.Visible = true;
                        PictureBox144.Image = global::VisualTextures.My.Resources.inddoordark128;
                        PictureBox144.Visible = true;
                        PictureBox145.Image = global::VisualTextures.My.Resources.inddoorway128;
                        PictureBox145.Visible = true;
                        PictureBox146.Image = global::VisualTextures.My.Resources.mp_carter_doorway;
                        PictureBox146.Visible = true;
                        PictureBox147.Image = global::VisualTextures.My.Resources.sf_ship_door;
                        PictureBox147.Visible = true;
                        PictureBox148.Image = global::VisualTextures.My.Resources.shopdoor02_law;
                        PictureBox148.Visible = true;
                        PictureBox149.Image = global::VisualTextures.My.Resources.shopdoor3_64;
                        PictureBox149.Visible = true;
                        PictureBox150.Image = global::VisualTextures.My.Resources.sjmhoodoor1;
                        PictureBox150.Visible = true;
                        PictureBox151.Image = global::VisualTextures.My.Resources.slidingdoor01_128;
                        PictureBox151.Visible = true;
                        PictureBox152.Image = global::VisualTextures.My.Resources.sl_presdoor01;
                        PictureBox152.Visible = true;
                        PictureBox153.Image = global::VisualTextures.My.Resources.sl_presdoor02;
                        PictureBox153.Visible = true;
                        PictureBox154.Image = global::VisualTextures.My.Resources.sw_door03;
                        PictureBox154.Visible = true;
                        PictureBox155.Image = global::VisualTextures.My.Resources.sw_door04;
                        PictureBox155.Visible = true;
                        PictureBox156.Image = global::VisualTextures.My.Resources.sw_door05;
                        PictureBox156.Visible = true;
                        PictureBox157.Image = global::VisualTextures.My.Resources.sw_door07;
                        PictureBox157.Visible = true;
                        PictureBox158.Image = global::VisualTextures.My.Resources.sw_door08;
                        PictureBox158.Visible = true;
                        PictureBox159.Image = global::VisualTextures.My.Resources.sw_door09;
                        PictureBox158.Visible = true;
                        PictureBox160.Image = global::VisualTextures.My.Resources.sw_door10;
                        PictureBox160.Visible = true;
                        PictureBox161.Image = global::VisualTextures.My.Resources.sw_door13;
                        PictureBox161.Visible = true;
                        PictureBox162.Image = global::VisualTextures.My.Resources.sw_door14;
                        PictureBox162.Visible = true;
                        PictureBox163.Image = global::VisualTextures.My.Resources.sw_door15;
                        PictureBox163.Visible = true;
                        PictureBox164.Image = global::VisualTextures.My.Resources.sw_door16;
                        PictureBox164.Visible = true;
                        PictureBox165.Image = global::VisualTextures.My.Resources.sw_door17;
                        PictureBox165.Visible = true;
                        PictureBox166.Image = global::VisualTextures.My.Resources.sw_door18;
                        PictureBox166.Visible = true;
                        PictureBox167.Image = global::VisualTextures.My.Resources.sw_door19;
                        PictureBox167.Visible = true;
                        PictureBox168.Image = global::VisualTextures.My.Resources.trail_door;
                        PictureBox168.Visible = true;
                        PictureBox169.Image = global::VisualTextures.My.Resources.Was_scrpyd_door_dbl_grey;
                        PictureBox169.Visible = true;
                        PictureBox170.Image = global::VisualTextures.My.Resources.Was_scrpyd_trailer_door;
                        PictureBox170.Visible = true;
                        PictureBox171.Image = global::VisualTextures.My.Resources.ws_dampdoubledoor;
                        PictureBox171.Visible = true;
                        PictureBox172.Image = global::VisualTextures.My.Resources.ws_doorframe;
                        PictureBox172.Visible = true;
                        PictureBox173.Image = global::VisualTextures.My.Resources.ws_doorfront;
                        PictureBox173.Visible = true;
                        PictureBox174.Image = global::VisualTextures.My.Resources.ws_doubledoor3;
                        PictureBox174.Visible = true;
                        PictureBox175.Image = global::VisualTextures.My.Resources.ws_garagedoor2_yello;
                        PictureBox175.Visible = true;
                        PictureBox176.Image = global::VisualTextures.My.Resources.ws_rollerdoor_blue;
                        PictureBox176.Visible = true;
                        PictureBox177.Image = global::VisualTextures.My.Resources.ws_rollerdoor_silver2;
                        PictureBox177.Visible = true;*/
                        break;
                    }

                case 1:
                    {
                        panel3.Show();

                        // RadioButton1.Visible = True
                        // RadioButton2.Visible = True
                        // RadioButton3.Visible = True
                        // RadioButton4.Visible = True
                        // RadioButton5.Visible = True
                        // RadioButton6.Visible = True
                        // RadioButton7.Visible = True
                        // RadioButton8.Visible = True
                        // RadioButton9.Visible = True
                        // RadioButton10.Visible = True
                        // RadioButton11.Visible = True
                        // RadioButton12.Visible = True
                        // RadioButton13.Visible = True
                        // RadioButton14.Visible = True
                        // RadioButton15.Visible = True
                        // RadioButton16.Visible = True
                        // RadioButton17.Visible = True
                        // RadioButton18.Visible = True
                        // RadioButton19.Visible = True
                        // RadioButton20.Visible = True
                        // RadioButton21.Visible = True
                        // RadioButton22.Visible = True
                        // PictureeBox1.Visible = True
                        // PictureeBox2.Visible = True
                        // PictureeBox3.Visible = True
                        // PictureeBox4.Visible = True
                        // PictureeBox5.Visible = True
                        // PictureeBox6.Visible = True
                        // PictureeBox7.Visible = True
                        // PictureeBox8.Visible = True
                        // PictureeBox9.Visible = True
                        // PictureeBox10.Visible = True
                        // PictureeBox11.Visible = True
                        // PictureeBox12.Visible = True
                        // PictureeBox13.Visible = True
                        // PictureeBox14.Visible = True
                        // PictureeBox15.Visible = True
                        // PictureeBox16.Visible = True
                        // PictureeBox17.Visible = True
                        // PictureeBox18.Visible = True
                        // PictureeBox19.Visible = True
                        // PictureeBox20.Visible = True
                        /*PictureBox1.Image = global::VisualTextures.My.Resources.a51_floorpanel3;
                        PictureBox2.Image = global::VisualTextures.My.Resources.a51_panel2;
                        PictureBox3.Image = global::VisualTextures.My.Resources.a51_panels1;
                        PictureBox4.Image = global::VisualTextures.My.Resources.a51_strips1;
                        PictureBox5.Image = global::VisualTextures.My.Resources.a51_vent1;
                        PictureBox6.Image = global::VisualTextures.My.Resources.a51_wall1;
                        PictureBox7.Image = global::VisualTextures.My.Resources.brick;
                        PictureBox8.Image = global::VisualTextures.My.Resources.carparkwall12_256;
                        PictureBox9.Image = global::VisualTextures.My.Resources.concretegroundl1_256;
                        PictureBox10.Image = global::VisualTextures.My.Resources.concretewall22_256;
                        PictureBox11.Image = global::VisualTextures.My.Resources.concreteyellow256_copy;
                        PictureBox12.Image = global::VisualTextures.My.Resources.des_factower;
                        PictureBox13.Image = global::VisualTextures.My.Resources.ferry_build14;
                        PictureBox14.Image = global::VisualTextures.My.Resources.Metalox64;
                        PictureBox15.Image = global::VisualTextures.My.Resources.pcut_bot_law;
                        PictureBox16.Image = global::VisualTextures.My.Resources.rebrckwall_128;
                        PictureBox17.Image = global::VisualTextures.My.Resources.redmetal;
                        PictureBox18.Image = global::VisualTextures.My.Resources.shingles2;
                        PictureBox19.Image = global::VisualTextures.My.Resources.sl_vicbrikwall01;
                        PictureBox20.Image = global::VisualTextures.My.Resources.sl_vicwall01;
                        PictureBox21.Image = global::VisualTextures.My.Resources.sl_vicwall02;
                        PictureBox22.Image = global::VisualTextures.My.Resources.sw_olddrum1;
                        PictureBox23.Image = global::VisualTextures.My.Resources.wallgreyred128;*/
                        break;
                    }

                case 2:
                    {
                        panel3.Hide();
                        break;
                    }

                case 3:
                    {
                        panel3.Hide();
                        break;
                    }

                case 4:
                    {
                        panel3.Hide();
                        break;
                    }

                case 5:
                    {
                        panel3.Hide();
                        break;
                    }

                case 6:
                    {
                        panel3.Hide();
                        break;
                    }

                case 7:
                    {
                        panel3.Hide();
                        break;
                    }

                case 8:
                    {
                        panel3.Hide();
                        break;
                    }
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /* #################################### Mouse Settings ########################################## */
        private void vTextures_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
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
