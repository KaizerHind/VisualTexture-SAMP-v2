namespace VisualTexture_v2
{
    partial class wikisamp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wikisamp));
            this.buttonSalir = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.titulo = new System.Windows.Forms.Label();
            this.descripcion1 = new System.Windows.Forms.Label();
            this.descripcion2 = new System.Windows.Forms.Label();
            this.descripcion3 = new System.Windows.Forms.Label();
            this.tags1 = new System.Windows.Forms.Label();
            this.tags2 = new System.Windows.Forms.Label();
            this.tags3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.Color.White;
            this.buttonSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSalir.FlatAppearance.BorderSize = 0;
            this.buttonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalir.ForeColor = System.Drawing.Color.Maroon;
            this.buttonSalir.Location = new System.Drawing.Point(652, 0);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(53, 24);
            this.buttonSalir.TabIndex = 0;
            this.buttonSalir.Text = "X";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.supportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(705, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.toolsToolStripMenuItem.Text = "Herramientas";
            // 
            // supportToolStripMenuItem
            // 
            this.supportToolStripMenuItem.Name = "supportToolStripMenuItem";
            this.supportToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.supportToolStripMenuItem.Text = "Soporte";
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "                       -- a_actor --",
            "- CreateActor",
            "- DestroyActor",
            "- IsActorStreamedIn",
            "- SetActorVirtualWorld",
            "- GetActorVirtualWorld",
            "- ApplyActorAnimation",
            "- ClearActorAnimations",
            "- SetActorPos",
            "- GetActorPos",
            "- SetActorFacingAngle",
            "- GetActorFacingAngle",
            "- SetActorHealth",
            "- GetActorHealth",
            "- SetActorInvulnerable",
            "- IsActorInvulnerable",
            "- IsValidActor",
            " ",
            "                       -- a_http --"});
            this.listBox1.Location = new System.Drawing.Point(0, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(188, 364);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(364, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Wiki-Samp";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(194, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 363);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, -5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(479, 381);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(479, 40);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Titulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(370, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 37);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tags";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.tags3);
            this.panel4.Controls.Add(this.tags2);
            this.panel4.Controls.Add(this.tags1);
            this.panel4.Controls.Add(this.descripcion3);
            this.panel4.Controls.Add(this.descripcion2);
            this.panel4.Controls.Add(this.descripcion1);
            this.panel4.Controls.Add(this.titulo);
            this.panel4.Location = new System.Drawing.Point(0, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(479, 64);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Location = new System.Drawing.Point(154, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 106);
            this.panel5.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Location = new System.Drawing.Point(337, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1, 106);
            this.panel6.TabIndex = 2;
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Location = new System.Drawing.Point(12, 26);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(115, 13);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "OnPlayerTakeDamage";
            // 
            // descripcion1
            // 
            this.descripcion1.AutoSize = true;
            this.descripcion1.Location = new System.Drawing.Point(167, 7);
            this.descripcion1.Name = "descripcion1";
            this.descripcion1.Size = new System.Drawing.Size(35, 13);
            this.descripcion1.TabIndex = 1;
            this.descripcion1.Text = "label6";
            // 
            // descripcion2
            // 
            this.descripcion2.AutoSize = true;
            this.descripcion2.Location = new System.Drawing.Point(167, 26);
            this.descripcion2.Name = "descripcion2";
            this.descripcion2.Size = new System.Drawing.Size(35, 13);
            this.descripcion2.TabIndex = 2;
            this.descripcion2.Text = "label7";
            // 
            // descripcion3
            // 
            this.descripcion3.AutoSize = true;
            this.descripcion3.Location = new System.Drawing.Point(167, 43);
            this.descripcion3.Name = "descripcion3";
            this.descripcion3.Size = new System.Drawing.Size(35, 13);
            this.descripcion3.TabIndex = 3;
            this.descripcion3.Text = "label8";
            // 
            // tags1
            // 
            this.tags1.AutoSize = true;
            this.tags1.Location = new System.Drawing.Point(345, 7);
            this.tags1.Name = "tags1";
            this.tags1.Size = new System.Drawing.Size(35, 13);
            this.tags1.TabIndex = 4;
            this.tags1.Text = "label9";
            // 
            // tags2
            // 
            this.tags2.AutoSize = true;
            this.tags2.Location = new System.Drawing.Point(345, 26);
            this.tags2.Name = "tags2";
            this.tags2.Size = new System.Drawing.Size(41, 13);
            this.tags2.TabIndex = 5;
            this.tags2.Text = "label10";
            // 
            // tags3
            // 
            this.tags3.AutoSize = true;
            this.tags3.BackColor = System.Drawing.Color.Transparent;
            this.tags3.Location = new System.Drawing.Point(345, 43);
            this.tags3.Name = "tags3";
            this.tags3.Size = new System.Drawing.Size(41, 13);
            this.tags3.TabIndex = 6;
            this.tags3.Text = "label11";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 111);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(479, 98);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // wikisamp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(705, 429);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "wikisamp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "wikisamp";
            this.Load += new System.EventHandler(this.wikisamp_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supportToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label tags3;
        private System.Windows.Forms.Label tags2;
        private System.Windows.Forms.Label tags1;
        private System.Windows.Forms.Label descripcion3;
        private System.Windows.Forms.Label descripcion2;
        private System.Windows.Forms.Label descripcion1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}