namespace WindowsFormsApplication1
{
    partial class MAIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAIN));
            this.b_rec = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.b_sec = new System.Windows.Forms.Button();
            this.b_app = new System.Windows.Forms.Button();
            this.b_pay = new System.Windows.Forms.Button();
            this.b_dent = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.b_pati = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pb_pay = new System.Windows.Forms.PictureBox();
            this.pb_rec = new System.Windows.Forms.PictureBox();
            this.pb_sec = new System.Windows.Forms.PictureBox();
            this.pb_den = new System.Windows.Forms.PictureBox();
            this.pb_pat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_den)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pat)).BeginInit();
            this.SuspendLayout();
            // 
            // b_rec
            // 
            this.b_rec.BackColor = System.Drawing.Color.Blue;
            this.b_rec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.b_rec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.b_rec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_rec.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_rec.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b_rec.Location = new System.Drawing.Point(105, 240);
            this.b_rec.Name = "b_rec";
            this.b_rec.Size = new System.Drawing.Size(134, 34);
            this.b_rec.TabIndex = 1;
            this.b_rec.Text = "RECORDS";
            this.b_rec.UseVisualStyleBackColor = false;
            this.b_rec.Click += new System.EventHandler(this.button6_Click);
            this.b_rec.MouseLeave += new System.EventHandler(this.b_rec_MouseLeave);
            this.b_rec.MouseHover += new System.EventHandler(this.b_rec_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(85, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // b_sec
            // 
            this.b_sec.BackColor = System.Drawing.Color.Blue;
            this.b_sec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.b_sec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.b_sec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_sec.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_sec.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b_sec.Location = new System.Drawing.Point(297, 190);
            this.b_sec.Name = "b_sec";
            this.b_sec.Size = new System.Drawing.Size(134, 34);
            this.b_sec.TabIndex = 2;
            this.b_sec.Text = "SECRETARY";
            this.b_sec.UseVisualStyleBackColor = false;
            this.b_sec.Click += new System.EventHandler(this.button5_Click);
            this.b_sec.MouseLeave += new System.EventHandler(this.b_sec_MouseLeave);
            this.b_sec.MouseHover += new System.EventHandler(this.b_sec_MouseHover);
            // 
            // b_app
            // 
            this.b_app.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.b_app.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.b_app.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.b_app.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_app.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_app.Location = new System.Drawing.Point(105, 190);
            this.b_app.Name = "b_app";
            this.b_app.Size = new System.Drawing.Size(134, 34);
            this.b_app.TabIndex = 0;
            this.b_app.Text = "APPOINTMENT";
            this.b_app.UseVisualStyleBackColor = true;
            this.b_app.Click += new System.EventHandler(this.b_Click);
            this.b_app.MouseLeave += new System.EventHandler(this.b_app_MouseLeave);
            this.b_app.MouseHover += new System.EventHandler(this.b_app_MouseHover);
            // 
            // b_pay
            // 
            this.b_pay.BackColor = System.Drawing.Color.Blue;
            this.b_pay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.b_pay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.b_pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_pay.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_pay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b_pay.Location = new System.Drawing.Point(105, 295);
            this.b_pay.Name = "b_pay";
            this.b_pay.Size = new System.Drawing.Size(134, 34);
            this.b_pay.TabIndex = 5;
            this.b_pay.Text = "PAYMENT";
            this.b_pay.UseVisualStyleBackColor = false;
            this.b_pay.Click += new System.EventHandler(this.button2_Click);
            this.b_pay.MouseLeave += new System.EventHandler(this.b_pay_MouseLeave);
            this.b_pay.MouseHover += new System.EventHandler(this.b_pay_MouseHover);
            // 
            // b_dent
            // 
            this.b_dent.BackColor = System.Drawing.Color.Blue;
            this.b_dent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.b_dent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.b_dent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_dent.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_dent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b_dent.Location = new System.Drawing.Point(297, 240);
            this.b_dent.Name = "b_dent";
            this.b_dent.Size = new System.Drawing.Size(134, 34);
            this.b_dent.TabIndex = 3;
            this.b_dent.Text = "DENTIST";
            this.b_dent.UseVisualStyleBackColor = false;
            this.b_dent.Click += new System.EventHandler(this.button1_Click);
            this.b_dent.MouseLeave += new System.EventHandler(this.b_dent_MouseLeave);
            this.b_dent.MouseHover += new System.EventHandler(this.b_dent_MouseHover);
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
            this.menuStrip1.Size = new System.Drawing.Size(509, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hOMEToolStripMenuItem
            // 
            this.hOMEToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hOMEToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.hOMEToolStripMenuItem.Text = "HOME";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Yellow;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripMenuItem1.Size = new System.Drawing.Size(99, 20);
            this.toolStripMenuItem1.Text = "User´s Name:";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.logOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logOutToolStripMenuItem.Image")));
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // b_pati
            // 
            this.b_pati.BackColor = System.Drawing.Color.Blue;
            this.b_pati.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.b_pati.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.b_pati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_pati.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_pati.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b_pati.Location = new System.Drawing.Point(297, 295);
            this.b_pati.Name = "b_pati";
            this.b_pati.Size = new System.Drawing.Size(134, 34);
            this.b_pati.TabIndex = 4;
            this.b_pati.Text = "PATIENT";
            this.b_pati.UseVisualStyleBackColor = false;
            this.b_pati.Click += new System.EventHandler(this.button4_Click);
            this.b_pati.MouseLeave += new System.EventHandler(this.b_pati_MouseLeave);
            this.b_pati.MouseHover += new System.EventHandler(this.b_pati_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Blue;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(66, 190);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pb_pay
            // 
            this.pb_pay.BackColor = System.Drawing.Color.Blue;
            this.pb_pay.Image = ((System.Drawing.Image)(resources.GetObject("pb_pay.Image")));
            this.pb_pay.Location = new System.Drawing.Point(66, 295);
            this.pb_pay.Name = "pb_pay";
            this.pb_pay.Size = new System.Drawing.Size(43, 34);
            this.pb_pay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_pay.TabIndex = 16;
            this.pb_pay.TabStop = false;
            // 
            // pb_rec
            // 
            this.pb_rec.BackColor = System.Drawing.Color.Blue;
            this.pb_rec.Image = ((System.Drawing.Image)(resources.GetObject("pb_rec.Image")));
            this.pb_rec.Location = new System.Drawing.Point(66, 240);
            this.pb_rec.Name = "pb_rec";
            this.pb_rec.Size = new System.Drawing.Size(43, 34);
            this.pb_rec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_rec.TabIndex = 17;
            this.pb_rec.TabStop = false;
            // 
            // pb_sec
            // 
            this.pb_sec.BackColor = System.Drawing.Color.Blue;
            this.pb_sec.Image = ((System.Drawing.Image)(resources.GetObject("pb_sec.Image")));
            this.pb_sec.Location = new System.Drawing.Point(258, 190);
            this.pb_sec.Name = "pb_sec";
            this.pb_sec.Size = new System.Drawing.Size(43, 34);
            this.pb_sec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_sec.TabIndex = 18;
            this.pb_sec.TabStop = false;
            // 
            // pb_den
            // 
            this.pb_den.BackColor = System.Drawing.Color.Blue;
            this.pb_den.Image = ((System.Drawing.Image)(resources.GetObject("pb_den.Image")));
            this.pb_den.Location = new System.Drawing.Point(258, 240);
            this.pb_den.Name = "pb_den";
            this.pb_den.Size = new System.Drawing.Size(43, 34);
            this.pb_den.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_den.TabIndex = 19;
            this.pb_den.TabStop = false;
            // 
            // pb_pat
            // 
            this.pb_pat.BackColor = System.Drawing.Color.Blue;
            this.pb_pat.Image = ((System.Drawing.Image)(resources.GetObject("pb_pat.Image")));
            this.pb_pat.Location = new System.Drawing.Point(258, 295);
            this.pb_pat.Name = "pb_pat";
            this.pb_pat.Size = new System.Drawing.Size(43, 34);
            this.pb_pat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_pat.TabIndex = 20;
            this.pb_pat.TabStop = false;
            // 
            // MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(509, 347);
            this.Controls.Add(this.pb_pat);
            this.Controls.Add(this.pb_den);
            this.Controls.Add(this.pb_sec);
            this.Controls.Add(this.pb_rec);
            this.Controls.Add(this.pb_pay);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.b_pati);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.b_rec);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.b_sec);
            this.Controls.Add(this.b_app);
            this.Controls.Add(this.b_pay);
            this.Controls.Add(this.b_dent);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MAIN";
            this.Text = "MAIN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MAIN_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MAIN_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_den)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_rec;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button b_sec;
        private System.Windows.Forms.Button b_app;
        private System.Windows.Forms.Button b_pay;
        private System.Windows.Forms.Button b_dent;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Button b_pati;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pb_pay;
        private System.Windows.Forms.PictureBox pb_rec;
        private System.Windows.Forms.PictureBox pb_sec;
        private System.Windows.Forms.PictureBox pb_den;
        private System.Windows.Forms.PictureBox pb_pat;
    }
}