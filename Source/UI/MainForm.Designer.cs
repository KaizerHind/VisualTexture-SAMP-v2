using VisualTexture_v2.Source.Components;

namespace VisualTexture_v2.Source.UI
{
    partial class MainForm : VSWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Navbar = new VisualTexture_v2.Source.Components.NavBar();
            this.SuspendLayout();
            // 
            // Navbar
            // 
            this.Navbar.Location = new System.Drawing.Point(0, 0);
            this.Navbar.Name = "Navbar";
            this.Navbar.Size = new System.Drawing.Size(800, 450);
            this.Navbar.TabIndex = 0;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.Navbar);
            this.Name = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private NavBar Navbar;
    }
}