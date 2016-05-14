namespace WindowsFormsApplication1
{
    partial class RECORDS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RECORDS));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.b_create = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.l_dentist_name = new System.Windows.Forms.Label();
            this.cb_name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.l_id_Record = new System.Windows.Forms.Label();
            this.pb_image = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.b_search = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_delete = new System.Windows.Forms.Button();
            this.b_edit = new System.Windows.Forms.Button();
            this.rb_dentist = new System.Windows.Forms.RadioButton();
            this.rb_patient = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Blue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOMEToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(950, 24);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hOMEToolStripMenuItem
            // 
            this.hOMEToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hOMEToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.hOMEToolStripMenuItem.Text = "HOME";
            this.hOMEToolStripMenuItem.Click += new System.EventHandler(this.hOMEToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Yellow;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripMenuItem1.Size = new System.Drawing.Size(107, 20);
            this.toolStripMenuItem1.Text = "User´s Name:";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.logOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logOutToolStripMenuItem.Image")));
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // b_create
            // 
            this.b_create.BackColor = System.Drawing.Color.Blue;
            this.b_create.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.b_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_create.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_create.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b_create.Location = new System.Drawing.Point(328, 107);
            this.b_create.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.b_create.Name = "b_create";
            this.b_create.Size = new System.Drawing.Size(152, 28);
            this.b_create.TabIndex = 32;
            this.b_create.Text = "FILL REPORT";
            this.b_create.UseVisualStyleBackColor = false;
            this.b_create.Click += new System.EventHandler(this.b_create_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 47);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(216, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 61;
            this.label4.Text = "DENTIST´S NAME:";
            // 
            // l_dentist_name
            // 
            this.l_dentist_name.AutoSize = true;
            this.l_dentist_name.ForeColor = System.Drawing.Color.Navy;
            this.l_dentist_name.Location = new System.Drawing.Point(124, 59);
            this.l_dentist_name.Name = "l_dentist_name";
            this.l_dentist_name.Size = new System.Drawing.Size(13, 15);
            this.l_dentist_name.TabIndex = 63;
            this.l_dentist_name.Text = "  ";
            // 
            // cb_name
            // 
            this.cb_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_name.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_name.FormattingEnabled = true;
            this.cb_name.Location = new System.Drawing.Point(115, 21);
            this.cb_name.Name = "cb_name";
            this.cb_name.Size = new System.Drawing.Size(311, 23);
            this.cb_name.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 64;
            this.label1.Text = "PATIENT\'S NAME:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.l_id_Record);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cb_name);
            this.groupBox1.Controls.Add(this.pb_image);
            this.groupBox1.Controls.Add(this.l_dentist_name);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 411);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 66;
            this.label2.Text = "RECORD\'S ID:";
            // 
            // l_id_Record
            // 
            this.l_id_Record.AutoSize = true;
            this.l_id_Record.ForeColor = System.Drawing.Color.Navy;
            this.l_id_Record.Location = new System.Drawing.Point(335, 96);
            this.l_id_Record.Name = "l_id_Record";
            this.l_id_Record.Size = new System.Drawing.Size(13, 15);
            this.l_id_Record.TabIndex = 67;
            this.l_id_Record.Text = "  ";
            // 
            // pb_image
            // 
            this.pb_image.Location = new System.Drawing.Point(11, 125);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(339, 271);
            this.pb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_image.TabIndex = 76;
            this.pb_image.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(11, 90);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 28);
            this.button1.TabIndex = 75;
            this.button1.Text = "ADD IMAGE ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.b_search);
            this.groupBox2.Controls.Add(this.dgv);
            this.groupBox2.Controls.Add(this.b_delete);
            this.groupBox2.Controls.Add(this.b_edit);
            this.groupBox2.Controls.Add(this.rb_dentist);
            this.groupBox2.Controls.Add(this.rb_patient);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(485, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 411);
            this.groupBox2.TabIndex = 77;
            this.groupBox2.TabStop = false;
            // 
            // b_search
            // 
            this.b_search.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.b_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b_search.BackgroundImage")));
            this.b_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_search.FlatAppearance.BorderSize = 0;
            this.b_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.b_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_search.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_search.Location = new System.Drawing.Point(379, 96);
            this.b_search.Name = "b_search";
            this.b_search.Size = new System.Drawing.Size(35, 29);
            this.b_search.TabIndex = 71;
            this.b_search.UseVisualStyleBackColor = false;
            this.b_search.Click += new System.EventHandler(this.b_search_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1});
            this.dgv.Location = new System.Drawing.Point(11, 167);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.Size = new System.Drawing.Size(431, 150);
            this.dgv.TabIndex = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "RECORD\'S ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "PATIENT\'S NAME";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 325;
            // 
            // b_delete
            // 
            this.b_delete.BackColor = System.Drawing.Color.Blue;
            this.b_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.b_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_delete.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b_delete.Location = new System.Drawing.Point(183, 21);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(130, 23);
            this.b_delete.TabIndex = 69;
            this.b_delete.Text = "DELETE FILE";
            this.b_delete.UseVisualStyleBackColor = false;
            // 
            // b_edit
            // 
            this.b_edit.BackColor = System.Drawing.Color.Blue;
            this.b_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.b_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_edit.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_edit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b_edit.Location = new System.Drawing.Point(32, 21);
            this.b_edit.Name = "b_edit";
            this.b_edit.Size = new System.Drawing.Size(130, 23);
            this.b_edit.TabIndex = 68;
            this.b_edit.Text = "OPEN FILE";
            this.b_edit.UseVisualStyleBackColor = false;
            // 
            // rb_dentist
            // 
            this.rb_dentist.AutoSize = true;
            this.rb_dentist.Location = new System.Drawing.Point(115, 65);
            this.rb_dentist.Name = "rb_dentist";
            this.rb_dentist.Size = new System.Drawing.Size(82, 19);
            this.rb_dentist.TabIndex = 67;
            this.rb_dentist.TabStop = true;
            this.rb_dentist.Text = "BY DENTIST";
            this.rb_dentist.UseVisualStyleBackColor = true;
            this.rb_dentist.CheckedChanged += new System.EventHandler(this.rb_dentist_CheckedChanged);
            // 
            // rb_patient
            // 
            this.rb_patient.AutoSize = true;
            this.rb_patient.Location = new System.Drawing.Point(17, 66);
            this.rb_patient.Name = "rb_patient";
            this.rb_patient.Size = new System.Drawing.Size(83, 19);
            this.rb_patient.TabIndex = 66;
            this.rb_patient.TabStop = true;
            this.rb_patient.Text = "BY PATIENT";
            this.rb_patient.UseVisualStyleBackColor = true;
            this.rb_patient.CheckedChanged += new System.EventHandler(this.rb_patient_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(62, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(311, 23);
            this.comboBox1.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 64;
            this.label8.Text = "NAME:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(429, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 29);
            this.button2.TabIndex = 77;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RECORDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(950, 544);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.b_create);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RECORDS";
            this.Text = "           ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RECORDS_FormClosing);
            this.Load += new System.EventHandler(this.RECORDS_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Button b_create;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label l_dentist_name;
        private System.Windows.Forms.ComboBox cb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pb_image;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label l_id_Record;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rb_dentist;
        private System.Windows.Forms.RadioButton rb_patient;
        private System.Windows.Forms.Button b_delete;
        private System.Windows.Forms.Button b_edit;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button b_search;
        private System.Windows.Forms.Button button2;
    }
}