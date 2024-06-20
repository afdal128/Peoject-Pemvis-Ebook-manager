namespace E_Book_Manager.GUI
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.butonfav = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.home_menu2 = new E_Book_Manager.GUI.home_menu();
            this.favorit_Menu1 = new E_Book_Manager.GUI.Favorit_Menu();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.butonfav);
            this.panel1.Controls.Add(this.btnhome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 600);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::E_Book_Manager.Properties.Resources._2__1_;
            this.pictureBox2.Location = new System.Drawing.Point(70, 548);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 35);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::E_Book_Manager.Properties.Resources.abt;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(16, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "About Us";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // butonfav
            // 
            this.butonfav.BackColor = System.Drawing.Color.White;
            this.butonfav.FlatAppearance.BorderSize = 0;
            this.butonfav.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.butonfav.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.butonfav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butonfav.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonfav.ForeColor = System.Drawing.Color.Black;
            this.butonfav.Image = global::E_Book_Manager.Properties.Resources._412_removebg_preview__1_;
            this.butonfav.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butonfav.Location = new System.Drawing.Point(16, 265);
            this.butonfav.Name = "butonfav";
            this.butonfav.Size = new System.Drawing.Size(147, 35);
            this.butonfav.TabIndex = 3;
            this.butonfav.Text = "Favorit";
            this.butonfav.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butonfav.UseVisualStyleBackColor = false;
            this.butonfav.Click += new System.EventHandler(this.butonfav_Click);
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.White;
            this.btnhome.FlatAppearance.BorderSize = 0;
            this.btnhome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnhome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhome.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.ForeColor = System.Drawing.Color.Black;
            this.btnhome.Image = global::E_Book_Manager.Properties.Resources.kisspng_clip_art_computer_icons_house_vector_graphics_home_ip_svg_png_icon_free_download_23_593_onlinewe_5b74fab0db6150_9526657015343930088986_removebg_preview;
            this.btnhome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhome.Location = new System.Drawing.Point(16, 217);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(147, 35);
            this.btnhome.TabIndex = 2;
            this.btnhome.Text = "Home";
            this.btnhome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Book Manager";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::E_Book_Manager.Properties.Resources.Screenshot__130__removebg_preview__1_;
            this.pictureBox1.Location = new System.Drawing.Point(45, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 62);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // home_menu2
            // 
            this.home_menu2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.home_menu2.ForeColor = System.Drawing.Color.Black;
            this.home_menu2.Location = new System.Drawing.Point(198, 22);
            this.home_menu2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.home_menu2.Name = "home_menu2";
            this.home_menu2.Size = new System.Drawing.Size(916, 545);
            this.home_menu2.TabIndex = 2;
            // 
            // favorit_Menu1
            // 
            this.favorit_Menu1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.favorit_Menu1.ForeColor = System.Drawing.Color.Black;
            this.favorit_Menu1.Location = new System.Drawing.Point(198, 22);
            this.favorit_Menu1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.favorit_Menu1.Name = "favorit_Menu1";
            this.favorit_Menu1.Size = new System.Drawing.Size(916, 545);
            this.favorit_Menu1.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.home_menu2);
            this.Controls.Add(this.favorit_Menu1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button butonfav;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private home_menu home_menu1;
        private Favorit_Menu favorit_Menu1;
        private home_menu home_menu2;
    }
}