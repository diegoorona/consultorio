namespace WindowsFormsApplication1
{
    partial class APPOINTMENT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APPOINTMENT));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lPatient = new System.Windows.Forms.Label();
            this.lAppoint = new System.Windows.Forms.Label();
            this.lSecre = new System.Windows.Forms.Label();
            this.b_delete = new System.Windows.Forms.Button();
            this.b_edit = new System.Windows.Forms.Button();
            this.b_add = new System.Windows.Forms.Button();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.b_search = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvAppoints = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppoints)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lPatient);
            this.groupBox2.Controls.Add(this.lAppoint);
            this.groupBox2.Controls.Add(this.lSecre);
            this.groupBox2.Controls.Add(this.b_delete);
            this.groupBox2.Controls.Add(this.b_edit);
            this.groupBox2.Controls.Add(this.b_add);
            this.groupBox2.Controls.Add(this.tbDescription);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dDate);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 341);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(696, 219);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "APPOINTMENT DATA";
            // 
            // lPatient
            // 
            this.lPatient.AutoSize = true;
            this.lPatient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lPatient.Location = new System.Drawing.Point(585, 60);
            this.lPatient.Name = "lPatient";
            this.lPatient.Size = new System.Drawing.Size(2, 15);
            this.lPatient.TabIndex = 37;
            // 
            // lAppoint
            // 
            this.lAppoint.AutoSize = true;
            this.lAppoint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lAppoint.Location = new System.Drawing.Point(585, 29);
            this.lAppoint.Name = "lAppoint";
            this.lAppoint.Size = new System.Drawing.Size(2, 15);
            this.lAppoint.TabIndex = 36;
            // 
            // lSecre
            // 
            this.lSecre.AutoSize = true;
            this.lSecre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lSecre.Location = new System.Drawing.Point(122, 29);
            this.lSecre.Name = "lSecre";
            this.lSecre.Size = new System.Drawing.Size(2, 15);
            this.lSecre.TabIndex = 35;
            // 
            // b_delete
            // 
            this.b_delete.BackColor = System.Drawing.Color.Blue;
            this.b_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.b_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b_delete.Location = new System.Drawing.Point(531, 164);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(130, 23);
            this.b_delete.TabIndex = 34;
            this.b_delete.Text = "DELETE APPOINTMENT";
            this.b_delete.UseVisualStyleBackColor = false;
            this.b_delete.Click += new System.EventHandler(this.b_delete_Click);
            this.b_delete.MouseLeave += new System.EventHandler(this.b_delete_MouseLeave);
            this.b_delete.MouseHover += new System.EventHandler(this.b_delete_MouseHover);
            // 
            // b_edit
            // 
            this.b_edit.BackColor = System.Drawing.Color.Blue;
            this.b_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.b_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_edit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b_edit.Location = new System.Drawing.Point(531, 132);
            this.b_edit.Name = "b_edit";
            this.b_edit.Size = new System.Drawing.Size(130, 23);
            this.b_edit.TabIndex = 33;
            this.b_edit.Text = "EDIT APPOINTMENT";
            this.b_edit.UseVisualStyleBackColor = false;
            this.b_edit.Click += new System.EventHandler(this.b_edit_Click);
            this.b_edit.MouseLeave += new System.EventHandler(this.b_edit_MouseLeave);
            this.b_edit.MouseHover += new System.EventHandler(this.b_edit_MouseHover);
            // 
            // b_add
            // 
            this.b_add.BackColor = System.Drawing.Color.Blue;
            this.b_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.b_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_add.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b_add.Location = new System.Drawing.Point(531, 101);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(130, 23);
            this.b_add.TabIndex = 32;
            this.b_add.Text = "ADD APPOINTMENT";
            this.b_add.UseVisualStyleBackColor = false;
            this.b_add.Click += new System.EventHandler(this.b_add_Click);
            this.b_add.MouseLeave += new System.EventHandler(this.b_add_MouseLeave);
            this.b_add.MouseHover += new System.EventHandler(this.b_add_MouseHover);
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(21, 157);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(418, 46);
            this.tbDescription.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "DESCRIPTION:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "SECRETARY´S ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "APPOINTMENT´S ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(503, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "PATIENT´S ID:";
            // 
            // dDate
            // 
            this.dDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dDate.Location = new System.Drawing.Point(71, 95);
            this.dDate.Name = "dDate";
            this.dDate.Size = new System.Drawing.Size(140, 20);
            this.dDate.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "DATE:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(63, 57);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(376, 20);
            this.tbName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "NAME:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.b_search);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dgvAppoints);
            this.groupBox1.Controls.Add(this.cb_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 305);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SEARCH PATIENT";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(182, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // b_search
            // 
            this.b_search.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.b_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b_search.BackgroundImage")));
            this.b_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_search.FlatAppearance.BorderSize = 0;
            this.b_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.b_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_search.Location = new System.Drawing.Point(609, 65);
            this.b_search.Name = "b_search";
            this.b_search.Size = new System.Drawing.Size(35, 29);
            this.b_search.TabIndex = 31;
            this.b_search.UseVisualStyleBackColor = false;
            this.b_search.Click += new System.EventHandler(this.b_search_Click);
            this.b_search.MouseLeave += new System.EventHandler(this.b_search_MouseLeave);
            this.b_search.MouseHover += new System.EventHandler(this.b_search_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "PATIENT\'S APPOINTMENTS:";
            // 
            // dgvAppoints
            // 
            this.dgvAppoints.AllowUserToAddRows = false;
            this.dgvAppoints.AllowUserToDeleteRows = false;
            this.dgvAppoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppoints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvAppoints.Location = new System.Drawing.Point(12, 119);
            this.dgvAppoints.Name = "dgvAppoints";
            this.dgvAppoints.ReadOnly = true;
            this.dgvAppoints.RowHeadersVisible = false;
            this.dgvAppoints.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppoints.Size = new System.Drawing.Size(678, 180);
            this.dgvAppoints.TabIndex = 4;
            this.dgvAppoints.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppoints_CellContentClick);
            this.dgvAppoints.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvAppoints_MouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID APPOINTMENT";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID SECRETARY";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ID PATIENT";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "DATE";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "DESCRIPTION";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // cb_name
            // 
            this.cb_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cb_name.FormattingEnabled = true;
            this.cb_name.Location = new System.Drawing.Point(301, 68);
            this.cb_name.Name = "cb_name";
            this.cb_name.Size = new System.Drawing.Size(302, 23);
            this.cb_name.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "PATIENT\'S NAME:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Blue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOMEToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(722, 24);
            this.menuStrip1.TabIndex = 5;
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
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // APPOINTMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(722, 564);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "APPOINTMENT";
            this.Text = "APPOINTMENT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.APPOINTMENT_FormClosing);
            this.Load += new System.EventHandler(this.APPOINTMENT_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppoints)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvAppoints;
        private System.Windows.Forms.ComboBox cb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_delete;
        private System.Windows.Forms.Button b_edit;
        private System.Windows.Forms.Button b_add;
        private System.Windows.Forms.Button b_search;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label lPatient;
        private System.Windows.Forms.Label lAppoint;
        private System.Windows.Forms.Label lSecre;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}