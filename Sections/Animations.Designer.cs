﻿namespace VisualTexture_v2.Sections
{
    partial class Animations
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Animations));
            this.bnfElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lbl_Title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.VehBrowser = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSkins = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSpray = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCPicker = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTextures = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAnimations = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnClose = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bnfElipse
            // 
            this.bnfElipse.ElipseRadius = 20;
            this.bnfElipse.TargetControl = this;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Candara", 13F);
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(15, 2);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(133, 22);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "VisualTexture v2";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.VehBrowser);
            this.panel1.Controls.Add(this.bunifuFlatButton1);
            this.panel1.Controls.Add(this.btnSkins);
            this.panel1.Controls.Add(this.btnSpray);
            this.panel1.Controls.Add(this.btnCPicker);
            this.panel1.Controls.Add(this.btnTextures);
            this.panel1.Controls.Add(this.btnAnimations);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.lbl_Title);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 449);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // VehBrowser
            // 
            this.VehBrowser.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.VehBrowser.BackColor = System.Drawing.Color.Transparent;
            this.VehBrowser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VehBrowser.BorderRadius = 0;
            this.VehBrowser.ButtonText = "    VehicleViewer";
            this.VehBrowser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VehBrowser.DisabledColor = System.Drawing.Color.Gray;
            this.VehBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.VehBrowser.Iconcolor = System.Drawing.Color.Transparent;
            this.VehBrowser.Iconimage = global::VisualTexture_v2.Properties.Resources.car_50px;
            this.VehBrowser.Iconimage_right = null;
            this.VehBrowser.Iconimage_right_Selected = null;
            this.VehBrowser.Iconimage_Selected = null;
            this.VehBrowser.IconMarginLeft = 12;
            this.VehBrowser.IconMarginRight = 0;
            this.VehBrowser.IconRightVisible = true;
            this.VehBrowser.IconRightZoom = 0D;
            this.VehBrowser.IconVisible = true;
            this.VehBrowser.IconZoom = 60D;
            this.VehBrowser.IsTab = false;
            this.VehBrowser.Location = new System.Drawing.Point(8, 454);
            this.VehBrowser.Margin = new System.Windows.Forms.Padding(4);
            this.VehBrowser.Name = "VehBrowser";
            this.VehBrowser.Normalcolor = System.Drawing.Color.Transparent;
            this.VehBrowser.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.VehBrowser.OnHoverTextColor = System.Drawing.Color.White;
            this.VehBrowser.selected = false;
            this.VehBrowser.Size = new System.Drawing.Size(170, 57);
            this.VehBrowser.TabIndex = 14;
            this.VehBrowser.Text = "    VehicleViewer";
            this.VehBrowser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VehBrowser.Textcolor = System.Drawing.Color.White;
            this.VehBrowser.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuFlatButton1.ButtonText = "";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::VisualTexture_v2.Properties.Resources.development_50px;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 100D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(60, 37);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(50, 50);
            this.bunifuFlatButton1.TabIndex = 11;
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnSkins
            // 
            this.btnSkins.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnSkins.BackColor = System.Drawing.Color.Transparent;
            this.btnSkins.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSkins.BorderRadius = 0;
            this.btnSkins.ButtonText = "    SkinViewer";
            this.btnSkins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSkins.DisabledColor = System.Drawing.Color.Gray;
            this.btnSkins.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSkins.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSkins.Iconimage = global::VisualTexture_v2.Properties.Resources.man_50px;
            this.btnSkins.Iconimage_right = null;
            this.btnSkins.Iconimage_right_Selected = null;
            this.btnSkins.Iconimage_Selected = null;
            this.btnSkins.IconMarginLeft = 12;
            this.btnSkins.IconMarginRight = 0;
            this.btnSkins.IconRightVisible = true;
            this.btnSkins.IconRightZoom = 0D;
            this.btnSkins.IconVisible = true;
            this.btnSkins.IconZoom = 60D;
            this.btnSkins.IsTab = false;
            this.btnSkins.Location = new System.Drawing.Point(8, 394);
            this.btnSkins.Margin = new System.Windows.Forms.Padding(4);
            this.btnSkins.Name = "btnSkins";
            this.btnSkins.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSkins.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnSkins.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSkins.selected = false;
            this.btnSkins.Size = new System.Drawing.Size(170, 57);
            this.btnSkins.TabIndex = 10;
            this.btnSkins.Text = "    SkinViewer";
            this.btnSkins.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSkins.Textcolor = System.Drawing.Color.White;
            this.btnSkins.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnSpray
            // 
            this.btnSpray.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnSpray.BackColor = System.Drawing.Color.Transparent;
            this.btnSpray.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpray.BorderRadius = 0;
            this.btnSpray.ButtonText = "    SpriteViewer";
            this.btnSpray.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpray.DisabledColor = System.Drawing.Color.Gray;
            this.btnSpray.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSpray.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSpray.Iconimage = global::VisualTexture_v2.Properties.Resources.spray50px;
            this.btnSpray.Iconimage_right = null;
            this.btnSpray.Iconimage_right_Selected = null;
            this.btnSpray.Iconimage_Selected = null;
            this.btnSpray.IconMarginLeft = 12;
            this.btnSpray.IconMarginRight = 0;
            this.btnSpray.IconRightVisible = true;
            this.btnSpray.IconRightZoom = 0D;
            this.btnSpray.IconVisible = true;
            this.btnSpray.IconZoom = 60D;
            this.btnSpray.IsTab = false;
            this.btnSpray.Location = new System.Drawing.Point(8, 334);
            this.btnSpray.Margin = new System.Windows.Forms.Padding(4);
            this.btnSpray.Name = "btnSpray";
            this.btnSpray.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSpray.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnSpray.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSpray.selected = false;
            this.btnSpray.Size = new System.Drawing.Size(170, 57);
            this.btnSpray.TabIndex = 7;
            this.btnSpray.Text = "    SpriteViewer";
            this.btnSpray.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpray.Textcolor = System.Drawing.Color.White;
            this.btnSpray.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpray.Click += new System.EventHandler(this.btnSpray_Click);
            // 
            // btnCPicker
            // 
            this.btnCPicker.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnCPicker.BackColor = System.Drawing.Color.Transparent;
            this.btnCPicker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCPicker.BorderRadius = 0;
            this.btnCPicker.ButtonText = "    Color Picker";
            this.btnCPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCPicker.DisabledColor = System.Drawing.Color.Gray;
            this.btnCPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCPicker.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCPicker.Iconimage = global::VisualTexture_v2.Properties.Resources.colorpic50px;
            this.btnCPicker.Iconimage_right = null;
            this.btnCPicker.Iconimage_right_Selected = null;
            this.btnCPicker.Iconimage_Selected = null;
            this.btnCPicker.IconMarginLeft = 12;
            this.btnCPicker.IconMarginRight = 0;
            this.btnCPicker.IconRightVisible = true;
            this.btnCPicker.IconRightZoom = 0D;
            this.btnCPicker.IconVisible = true;
            this.btnCPicker.IconZoom = 60D;
            this.btnCPicker.IsTab = false;
            this.btnCPicker.Location = new System.Drawing.Point(8, 274);
            this.btnCPicker.Margin = new System.Windows.Forms.Padding(4);
            this.btnCPicker.Name = "btnCPicker";
            this.btnCPicker.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCPicker.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnCPicker.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCPicker.selected = false;
            this.btnCPicker.Size = new System.Drawing.Size(170, 57);
            this.btnCPicker.TabIndex = 6;
            this.btnCPicker.Text = "    Color Picker";
            this.btnCPicker.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCPicker.Textcolor = System.Drawing.Color.White;
            this.btnCPicker.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCPicker.Click += new System.EventHandler(this.btnCPicker_Click);
            // 
            // btnTextures
            // 
            this.btnTextures.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnTextures.BackColor = System.Drawing.Color.Transparent;
            this.btnTextures.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTextures.BorderRadius = 0;
            this.btnTextures.ButtonText = "    TextureViewer";
            this.btnTextures.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTextures.DisabledColor = System.Drawing.Color.Gray;
            this.btnTextures.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnTextures.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTextures.Iconimage = global::VisualTexture_v2.Properties.Resources.pict50px;
            this.btnTextures.Iconimage_right = null;
            this.btnTextures.Iconimage_right_Selected = null;
            this.btnTextures.Iconimage_Selected = null;
            this.btnTextures.IconMarginLeft = 12;
            this.btnTextures.IconMarginRight = 0;
            this.btnTextures.IconRightVisible = true;
            this.btnTextures.IconRightZoom = 0D;
            this.btnTextures.IconVisible = true;
            this.btnTextures.IconZoom = 60D;
            this.btnTextures.IsTab = false;
            this.btnTextures.Location = new System.Drawing.Point(8, 215);
            this.btnTextures.Margin = new System.Windows.Forms.Padding(4);
            this.btnTextures.Name = "btnTextures";
            this.btnTextures.Normalcolor = System.Drawing.Color.Transparent;
            this.btnTextures.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnTextures.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTextures.selected = false;
            this.btnTextures.Size = new System.Drawing.Size(170, 57);
            this.btnTextures.TabIndex = 3;
            this.btnTextures.Text = "    TextureViewer";
            this.btnTextures.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTextures.Textcolor = System.Drawing.Color.White;
            this.btnTextures.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTextures.Click += new System.EventHandler(this.btnTextures_Click);
            // 
            // btnAnimations
            // 
            this.btnAnimations.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnAnimations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnAnimations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnimations.BorderRadius = 0;
            this.btnAnimations.ButtonText = "    AnimViewer";
            this.btnAnimations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnimations.DisabledColor = System.Drawing.Color.Gray;
            this.btnAnimations.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnAnimations.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAnimations.Iconimage = global::VisualTexture_v2.Properties.Resources.running50px;
            this.btnAnimations.Iconimage_right = null;
            this.btnAnimations.Iconimage_right_Selected = null;
            this.btnAnimations.Iconimage_Selected = null;
            this.btnAnimations.IconMarginLeft = 12;
            this.btnAnimations.IconMarginRight = 0;
            this.btnAnimations.IconRightVisible = true;
            this.btnAnimations.IconRightZoom = 0D;
            this.btnAnimations.IconVisible = true;
            this.btnAnimations.IconZoom = 60D;
            this.btnAnimations.IsTab = false;
            this.btnAnimations.Location = new System.Drawing.Point(8, 154);
            this.btnAnimations.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnimations.Name = "btnAnimations";
            this.btnAnimations.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnAnimations.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnAnimations.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAnimations.selected = false;
            this.btnAnimations.Size = new System.Drawing.Size(170, 57);
            this.btnAnimations.TabIndex = 2;
            this.btnAnimations.Text = "    AnimViewer";
            this.btnAnimations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnimations.Textcolor = System.Drawing.Color.White;
            this.btnAnimations.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnHome
            // 
            this.btnHome.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.BorderRadius = 0;
            this.btnHome.ButtonText = "    Index";
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.DisabledColor = System.Drawing.Color.Gray;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnHome.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHome.Iconimage = global::VisualTexture_v2.Properties.Resources.home50px;
            this.btnHome.Iconimage_right = null;
            this.btnHome.Iconimage_right_Selected = null;
            this.btnHome.Iconimage_Selected = null;
            this.btnHome.IconMarginLeft = 12;
            this.btnHome.IconMarginRight = 0;
            this.btnHome.IconRightVisible = true;
            this.btnHome.IconRightZoom = 0D;
            this.btnHome.IconVisible = true;
            this.btnHome.IconZoom = 60D;
            this.btnHome.IsTab = false;
            this.btnHome.Location = new System.Drawing.Point(8, 95);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Normalcolor = System.Drawing.Color.Transparent;
            this.btnHome.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnHome.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHome.selected = false;
            this.btnHome.Size = new System.Drawing.Size(170, 57);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "    Index";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Textcolor = System.Drawing.Color.White;
            this.btnHome.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.richTextBox2);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Location = new System.Drawing.Point(169, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(680, 449);
            this.panel2.TabIndex = 3;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(33, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(143, 420);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel3.Location = new System.Drawing.Point(179, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(470, 364);
            this.panel3.TabIndex = 4;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(179, 412);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(470, 21);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(179, 383);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(470, 21);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // btnClose
            // 
            this.btnClose.Activecolor = System.Drawing.Color.DarkRed;
            this.btnClose.BackColor = System.Drawing.Color.DarkRed;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.BorderRadius = 4;
            this.btnClose.ButtonText = "X";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DisabledColor = System.Drawing.Color.Gray;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClose.Iconimage = null;
            this.btnClose.Iconimage_right = null;
            this.btnClose.Iconimage_right_Selected = null;
            this.btnClose.Iconimage_Selected = null;
            this.btnClose.IconMarginLeft = 0;
            this.btnClose.IconMarginRight = 0;
            this.btnClose.IconRightVisible = true;
            this.btnClose.IconRightZoom = 0D;
            this.btnClose.IconVisible = true;
            this.btnClose.IconZoom = 90D;
            this.btnClose.IsTab = false;
            this.btnClose.Location = new System.Drawing.Point(651, -5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Normalcolor = System.Drawing.Color.DarkRed;
            this.btnClose.OnHovercolor = System.Drawing.Color.Maroon;
            this.btnClose.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClose.selected = false;
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Textcolor = System.Drawing.Color.White;
            this.btnClose.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Animations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Animations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Animations";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bnfElipse;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnTextures;
        private Bunifu.Framework.UI.BunifuFlatButton btnAnimations;
        private Bunifu.Framework.UI.BunifuFlatButton btnHome;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnClose;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnCPicker;
        private Bunifu.Framework.UI.BunifuFlatButton btnSpray;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ListBox listBox1;
        protected internal System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton btnSkins;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton VehBrowser;
    }
}