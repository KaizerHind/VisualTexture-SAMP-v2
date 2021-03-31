using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace VisualTexture_v2
{
    public partial class Form1 : Form
    {
        public ChromiumWebBrowser chromeBrowser;

        public Form1()
        {
            InitializeComponent();
            // Iniciar explorador despues de los componentes
            InitializeChromium();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
             Cef.Shutdown();
        }
    }
}
