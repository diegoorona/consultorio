namespace WindowsFormsApplication1
{
    partial class DENTIST
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DENTIST));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.b_delete = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_confirm = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.b_edit = new System.Windows.Forms.Button();
            this.tb_idcard = new System.Windows.Forms.TextBox();
            this.b_add = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.l_idDent = new System.Windows.Forms.Label();
            this.dt_date = new System.Windows.Forms.DateTimePicker();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_name = new System.Windows.Forms.ComboBox();
            this.b_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.b_delete);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.b_edit);
            this.groupBox2.Controls.Add(this.tb_idcard);
            this.groupBox2.Controls.Add(this.b_add);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.l_idDent);
            this.groupBox2.Controls.Add(this.dt_date);
            this.groupBox2.Controls.Add(this.cb_gender);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tb_email);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tb_phone);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tb_address);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tb_name);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(739, 398);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // b_delete
            // 
            this.b_delete.BackColor = System.Drawing.Color.Blue;
            this.b_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.b_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_delete.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b_delete.Location = new System.Drawing.Point(573, 139);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(130, 23);
            this.b_delete.TabIndex = 33;
            this.b_delete.Text = "DELETE DENTIST";
            this.b_delete.UseVisualStyleBackColor = false;
            this.b_delete.MouseLeave += new System.EventHandler(this.b_delete_MouseLeave);
            this.b_delete.MouseHover += new System.EventHandler(this.b_delete_MouseHover);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_confirm);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tb_pass);
            this.groupBox3.Controls.Add(this.tb_user);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(21, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(341, 124);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "USER AND PASSWORD";
            // 
            // tb_confirm
            // 
            this.tb_confirm.Location = new System.Drawing.Point(160, 96);
            this.tb_confirm.Name = "tb_confirm";
            this.tb_confirm.Size = new System.Drawing.Size(137, 21);
            this.tb_confirm.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "CONFIRM PASSWORD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "USER NAME:";
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(160, 60);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(137, 21);
            this.tb_pass.TabIndex = 23;
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(157, 23);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(140, 21);
            this.tb_user.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(74, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "PASSWORD:";
            // 
            // b_edit
            // 
            this.b_edit.BackColor = System.Drawing.Color.Blue;
            this.b_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.b_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_edit.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_edit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b_edit.Location = new System.Drawing.Point(573, 107);
            this.b_edit.Name = "b_edit";
            this.b_edit.Size = new System.Drawing.Size(130, 23);
            this.b_edit.TabIndex = 32;
            this.b_edit.Text = "EDIT DENTIST";
            this.b_edit.UseVisualStyleBackColor = false;
            this.b_edit.MouseLeave += new System.EventHandler(this.b_edit_MouseLeave);
            this.b_edit.MouseHover += new System.EventHandler(this.b_edit_MouseHover);
            // 
            // tb_idcard
            // 
            this.tb_idcard.Location = new System.Drawing.Point(115, 255);
            this.tb_idcard.Name = "tb_idcard";
            this.tb_idcard.Size = new System.Drawing.Size(140, 21);
            this.tb_idcard.TabIndex = 19;
            // 
            // b_add
            // 
            this.b_add.BackColor = System.Drawing.Color.Blue;
            this.b_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.b_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_add.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_add.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.b_add.Location = new System.Drawing.Point(573, 76);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(130, 23);
            this.b_add.TabIndex = 31;
            this.b_add.Text = "ADD DENTIST";
            this.b_add.UseVisualStyleBackColor = false;
            this.b_add.MouseLeave += new System.EventHandler(this.b_add_MouseLeave);
            this.b_add.MouseHover += new System.EventHandler(this.b_add_MouseHover);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "IDENTITY CARD:";
            // 
            // l_idDent
            // 
            this.l_idDent.AutoSize = true;
            this.l_idDent.Location = new System.Drawing.Point(499, 33);
            this.l_idDent.Name = "l_idDent";
            this.l_idDent.Size = new System.Drawing.Size(73, 15);
            this.l_idDent.TabIndex = 14;
            this.l_idDent.Text = "DENTIST\'S ID:";
            // 
            // dt_date
            // 
            this.dt_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_date.Location = new System.Drawing.Point(355, 216);
            this.dt_date.Name = "dt_date";
            this.dt_date.Size = new System.Drawing.Size(140, 21);
            this.dt_date.TabIndex = 13;
            // 
            // cb_gender
            // 
            this.cb_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.cb_gender.Location = new System.Drawing.Point(118, 216);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(121, 23);
            this.cb_gender.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label8.Location = new System.Drawing.Point(272, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "BIRTH DATE:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "GENDER:";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(115, 286);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(140, 21);
            this.tb_email.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "E-MAIL:";
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(114, 318);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(142, 21);
            this.tb_phone.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "PHONE NUMBER:";
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(112, 353);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(209, 21);
            this.tb_address.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "ADDRESS:";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(101, 30);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(377, 21);
            this.tb_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "FIRST NAME:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_name);
            this.groupBox1.Controls.Add(this.b_search);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(208, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 66);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SEARCH DENTIST";
            // 
            // cb_name
            // 
            this.cb_name.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_name.FormattingEnabled = true;
            this.cb_name.Location = new System.Drawing.Point(139, 26);
            this.cb_name.Name = "cb_name";
            this.cb_name.Size = new System.Drawing.Size(311, 24);
            this.cb_name.TabIndex = 20;
            // 
            // b_search
            // 
            this.b_search.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.b_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b_search.BackgroundImage")));
            this.b_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_search.FlatAppearance.BorderSize = 0;
            this.b_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_search.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_search.Location = new System.Drawing.Point(456, 26);
            this.b_search.Name = "b_search";
            this.b_search.Size = new System.Drawing.Size(35, 29);
            this.b_search.TabIndex = 2;
            this.b_search.UseVisualStyleBackColor = false;
            this.b_search.MouseLeave += new System.EventHandler(this.b_search_MouseLeave);
            this.b_search.MouseHover += new System.EventHandler(this.b_search_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "DENTIST\'S NAME:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(182, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // DENTIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(763, 526);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DENTIST";
            this.Text = "DENTIST";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label l_idDent;
        private System.Windows.Forms.DateTimePicker dt_date;
        private System.Windows.Forms.ComboBox cb_gender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button b_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_idcard;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_name;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_confirm;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button b_delete;
        private System.Windows.Forms.Button b_edit;
        private System.Windows.Forms.Button b_add;
    }
}