
namespace E_Book_Manager.GUI
{
    partial class home_menu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridFav = new System.Windows.Forms.DataGridView();
            this.dataGridRecent = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRecent)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridFav
            // 
            this.dataGridFav.BackgroundColor = System.Drawing.Color.White;
            this.dataGridFav.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFav.Location = new System.Drawing.Point(30, 340);
            this.dataGridFav.Name = "dataGridFav";
            this.dataGridFav.RowHeadersWidth = 62;
            this.dataGridFav.RowTemplate.Height = 28;
            this.dataGridFav.Size = new System.Drawing.Size(824, 192);
            this.dataGridFav.TabIndex = 23;
            // 
            // dataGridRecent
            // 
            this.dataGridRecent.BackgroundColor = System.Drawing.Color.White;
            this.dataGridRecent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRecent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.edit,
            this.Delete});
            this.dataGridRecent.Location = new System.Drawing.Point(30, 103);
            this.dataGridRecent.Name = "dataGridRecent";
            this.dataGridRecent.RowHeadersWidth = 62;
            this.dataGridRecent.RowTemplate.Height = 28;
            this.dataGridRecent.Size = new System.Drawing.Size(824, 192);
            this.dataGridRecent.TabIndex = 22;
            this.dataGridRecent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRecent_CellClick);
            this.dataGridRecent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRecent_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 39);
            this.label1.TabIndex = 20;
            this.label1.Text = "Recent Add";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 18);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(792, 39);
            this.textBox1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 39);
            this.label2.TabIndex = 24;
            this.label2.Text = "Favorit";
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnadd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.btnadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.ForeColor = System.Drawing.Color.Transparent;
            this.btnadd.Image = global::E_Book_Manager.Properties.Resources.hd_add_insert_white_icon_symbol_transparent_background_7017516950330038ruwjmbfye_removebg_preview__1_;
            this.btnadd.Location = new System.Drawing.Point(794, 429);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(100, 100);
            this.btnadd.TabIndex = 21;
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::E_Book_Manager.Properties.Resources.src;
            this.button1.Location = new System.Drawing.Point(822, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 63);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // edit
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.edit.DefaultCellStyle = dataGridViewCellStyle1;
            this.edit.HeaderText = "Edit";
            this.edit.MinimumWidth = 8;
            this.edit.Name = "edit";
            this.edit.Text = "Edit ";
            this.edit.ToolTipText = "Edit";
            this.edit.UseColumnTextForButtonValue = true;
            this.edit.Width = 80;
            // 
            // Delete
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle2;
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 8;
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 80;
            // 
            // home_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dataGridFav);
            this.Controls.Add(this.dataGridRecent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "home_menu";
            this.Size = new System.Drawing.Size(916, 545);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFav)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRecent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dataGridFav;
        private System.Windows.Forms.DataGridView dataGridRecent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}
