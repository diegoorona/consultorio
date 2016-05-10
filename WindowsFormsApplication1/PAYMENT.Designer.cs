namespace WindowsFormsApplication1
{
    partial class PAYMENT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PAYMENT));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_reason = new System.Windows.Forms.ComboBox();
            this.cb_name = new System.Windows.Forms.ComboBox();
            this.bt_search = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.bt_clearall = new System.Windows.Forms.Button();
            this.bt_pay = new System.Windows.Forms.Button();
            this.tb_reBalance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_curBalance = new System.Windows.Forms.TextBox();
            this.tb_amountPaid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cb_option = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_7 = new System.Windows.Forms.Button();
            this.bt_clear = new System.Windows.Forms.Button();
            this.bt_div = new System.Windows.Forms.Button();
            this.bt_equal = new System.Windows.Forms.Button();
            this.bt_times = new System.Windows.Forms.Button();
            this.bt_sub = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_point = new System.Windows.Forms.Button();
            this.bt_0 = new System.Windows.Forms.Button();
            this.bt_1 = new System.Windows.Forms.Button();
            this.bt_2 = new System.Windows.Forms.Button();
            this.bt_3 = new System.Windows.Forms.Button();
            this.bt_6 = new System.Windows.Forms.Button();
            this.bt_5 = new System.Windows.Forms.Button();
            this.bt_4 = new System.Windows.Forms.Button();
            this.bt_9 = new System.Windows.Forms.Button();
            this.bt_8 = new System.Windows.Forms.Button();
            this.tb_amount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_reason);
            this.groupBox1.Controls.Add(this.cb_name);
            this.groupBox1.Controls.Add(this.bt_search);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.bt_clearall);
            this.groupBox1.Controls.Add(this.bt_pay);
            this.groupBox1.Controls.Add(this.tb_reBalance);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_curBalance);
            this.groupBox1.Controls.Add(this.tb_amountPaid);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_id);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 303);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Information";
            // 
            // cb_reason
            // 
            this.cb_reason.FormattingEnabled = true;
            this.cb_reason.Location = new System.Drawing.Point(82, 224);
            this.cb_reason.Name = "cb_reason";
            this.cb_reason.Size = new System.Drawing.Size(184, 24);
            this.cb_reason.TabIndex = 21;
            this.cb_reason.TextChanged += new System.EventHandler(this.cb_reason_TextChanged);
            this.cb_reason.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cb_reason_MouseClick);
            // 
            // cb_name
            // 
            this.cb_name.FormattingEnabled = true;
            this.cb_name.Location = new System.Drawing.Point(125, 56);
            this.cb_name.Name = "cb_name";
            this.cb_name.Size = new System.Drawing.Size(184, 24);
            this.cb_name.TabIndex = 20;
            this.cb_name.TextChanged += new System.EventHandler(this.cb_name_TextChanged);
            // 
            // bt_search
            // 
            this.bt_search.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_search.BackgroundImage")));
            this.bt_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_search.FlatAppearance.BorderSize = 0;
            this.bt_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_search.Location = new System.Drawing.Point(310, 13);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(35, 29);
            this.bt_search.TabIndex = 19;
            this.bt_search.UseVisualStyleBackColor = false;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "REASON:";
            // 
            // bt_clearall
            // 
            this.bt_clearall.BackColor = System.Drawing.Color.Blue;
            this.bt_clearall.FlatAppearance.BorderSize = 0;
            this.bt_clearall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.bt_clearall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.bt_clearall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_clearall.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_clearall.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_clearall.Location = new System.Drawing.Point(194, 265);
            this.bt_clearall.Name = "bt_clearall";
            this.bt_clearall.Size = new System.Drawing.Size(131, 23);
            this.bt_clearall.TabIndex = 14;
            this.bt_clearall.Text = "Clear All";
            this.bt_clearall.UseVisualStyleBackColor = false;
            this.bt_clearall.Click += new System.EventHandler(this.bt_clearall_Click);
            // 
            // bt_pay
            // 
            this.bt_pay.BackColor = System.Drawing.Color.Blue;
            this.bt_pay.FlatAppearance.BorderSize = 0;
            this.bt_pay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.bt_pay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.bt_pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_pay.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_pay.Location = new System.Drawing.Point(21, 265);
            this.bt_pay.Name = "bt_pay";
            this.bt_pay.Size = new System.Drawing.Size(131, 23);
            this.bt_pay.TabIndex = 13;
            this.bt_pay.Text = "Pay";
            this.bt_pay.UseVisualStyleBackColor = false;
            this.bt_pay.Click += new System.EventHandler(this.bt_pay_Click);
            // 
            // tb_reBalance
            // 
            this.tb_reBalance.Location = new System.Drawing.Point(161, 196);
            this.tb_reBalance.Name = "tb_reBalance";
            this.tb_reBalance.Size = new System.Drawing.Size(157, 22);
            this.tb_reBalance.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "REMAINING BALANCE:";
            // 
            // tb_curBalance
            // 
            this.tb_curBalance.Location = new System.Drawing.Point(155, 128);
            this.tb_curBalance.Name = "tb_curBalance";
            this.tb_curBalance.Size = new System.Drawing.Size(170, 22);
            this.tb_curBalance.TabIndex = 10;
            this.tb_curBalance.TextChanged += new System.EventHandler(this.tb_curBalance_TextChanged);
            // 
            // tb_amountPaid
            // 
            this.tb_amountPaid.Location = new System.Drawing.Point(155, 161);
            this.tb_amountPaid.Name = "tb_amountPaid";
            this.tb_amountPaid.Size = new System.Drawing.Size(170, 22);
            this.tb_amountPaid.TabIndex = 9;
            this.tb_amountPaid.TextChanged += new System.EventHandler(this.tb_amountPaid_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "AMOUNT PAID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "CURRENT BALANCE:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(67, 86);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(179, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "DATE:";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(104, 29);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(188, 22);
            this.tb_id.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "PAYMENT ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "PATIENT\'S NAME:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cb_option);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(25, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(351, 53);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Payment Options";
            // 
            // cb_option
            // 
            this.cb_option.FormattingEnabled = true;
            this.cb_option.Items.AddRange(new object[] {
            "NEW PAYMENT",
            "CHECK BALANCE"});
            this.cb_option.Location = new System.Drawing.Point(131, 17);
            this.cb_option.Name = "cb_option";
            this.cb_option.Size = new System.Drawing.Size(143, 24);
            this.cb_option.TabIndex = 18;
            this.cb_option.SelectedIndexChanged += new System.EventHandler(this.cb_option_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "SELECT AN OPTION:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.bt_7);
            this.groupBox3.Controls.Add(this.bt_clear);
            this.groupBox3.Controls.Add(this.bt_div);
            this.groupBox3.Controls.Add(this.bt_equal);
            this.groupBox3.Controls.Add(this.bt_times);
            this.groupBox3.Controls.Add(this.bt_sub);
            this.groupBox3.Controls.Add(this.bt_add);
            this.groupBox3.Controls.Add(this.bt_point);
            this.groupBox3.Controls.Add(this.bt_0);
            this.groupBox3.Controls.Add(this.bt_1);
            this.groupBox3.Controls.Add(this.bt_2);
            this.groupBox3.Controls.Add(this.bt_3);
            this.groupBox3.Controls.Add(this.bt_6);
            this.groupBox3.Controls.Add(this.bt_5);
            this.groupBox3.Controls.Add(this.bt_4);
            this.groupBox3.Controls.Add(this.bt_9);
            this.groupBox3.Controls.Add(this.bt_8);
            this.groupBox3.Controls.Add(this.tb_amount);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(424, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(341, 344);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CALCULATOR";
            // 
            // bt_7
            // 
            this.bt_7.BackColor = System.Drawing.SystemColors.Menu;
            this.bt_7.FlatAppearance.BorderSize = 0;
            this.bt_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_7.Location = new System.Drawing.Point(7, 75);
            this.bt_7.Name = "bt_7";
            this.bt_7.Size = new System.Drawing.Size(61, 61);
            this.bt_7.TabIndex = 35;
            this.bt_7.Text = "7";
            this.bt_7.UseVisualStyleBackColor = false;
            this.bt_7.Click += new System.EventHandler(this.bt_7_Click);
            // 
            // bt_clear
            // 
            this.bt_clear.BackColor = System.Drawing.Color.LightCyan;
            this.bt_clear.FlatAppearance.BorderSize = 0;
            this.bt_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_clear.ForeColor = System.Drawing.Color.DarkRed;
            this.bt_clear.Location = new System.Drawing.Point(273, 137);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(61, 61);
            this.bt_clear.TabIndex = 34;
            this.bt_clear.Text = "Clear";
            this.bt_clear.UseVisualStyleBackColor = false;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // bt_div
            // 
            this.bt_div.BackColor = System.Drawing.Color.LightCyan;
            this.bt_div.FlatAppearance.BorderSize = 0;
            this.bt_div.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_div.Location = new System.Drawing.Point(273, 75);
            this.bt_div.Name = "bt_div";
            this.bt_div.Size = new System.Drawing.Size(61, 61);
            this.bt_div.TabIndex = 33;
            this.bt_div.Text = "/";
            this.bt_div.UseVisualStyleBackColor = false;
            this.bt_div.Click += new System.EventHandler(this.bt_div_Click);
            // 
            // bt_equal
            // 
            this.bt_equal.BackColor = System.Drawing.Color.PaleGreen;
            this.bt_equal.FlatAppearance.BorderSize = 0;
            this.bt_equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_equal.Location = new System.Drawing.Point(139, 262);
            this.bt_equal.Name = "bt_equal";
            this.bt_equal.Size = new System.Drawing.Size(61, 61);
            this.bt_equal.TabIndex = 32;
            this.bt_equal.Text = "=";
            this.bt_equal.UseVisualStyleBackColor = false;
            this.bt_equal.Click += new System.EventHandler(this.bt_equal_Click);
            // 
            // bt_times
            // 
            this.bt_times.BackColor = System.Drawing.Color.LightCyan;
            this.bt_times.FlatAppearance.BorderSize = 0;
            this.bt_times.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_times.Location = new System.Drawing.Point(206, 75);
            this.bt_times.Name = "bt_times";
            this.bt_times.Size = new System.Drawing.Size(61, 61);
            this.bt_times.TabIndex = 31;
            this.bt_times.Text = "x";
            this.bt_times.UseVisualStyleBackColor = false;
            this.bt_times.Click += new System.EventHandler(this.bt_times_Click);
            // 
            // bt_sub
            // 
            this.bt_sub.BackColor = System.Drawing.Color.LightCyan;
            this.bt_sub.FlatAppearance.BorderSize = 0;
            this.bt_sub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sub.Location = new System.Drawing.Point(206, 137);
            this.bt_sub.Name = "bt_sub";
            this.bt_sub.Size = new System.Drawing.Size(61, 61);
            this.bt_sub.TabIndex = 30;
            this.bt_sub.Text = "-";
            this.bt_sub.UseVisualStyleBackColor = false;
            this.bt_sub.Click += new System.EventHandler(this.bt_sub_Click);
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.LightCyan;
            this.bt_add.FlatAppearance.BorderSize = 0;
            this.bt_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_add.Location = new System.Drawing.Point(206, 199);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(61, 127);
            this.bt_add.TabIndex = 28;
            this.bt_add.Text = "+";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_point
            // 
            this.bt_point.BackColor = System.Drawing.SystemColors.Menu;
            this.bt_point.FlatAppearance.BorderSize = 0;
            this.bt_point.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_point.Location = new System.Drawing.Point(73, 262);
            this.bt_point.Name = "bt_point";
            this.bt_point.Size = new System.Drawing.Size(62, 61);
            this.bt_point.TabIndex = 27;
            this.bt_point.Text = ".";
            this.bt_point.UseVisualStyleBackColor = false;
            this.bt_point.Click += new System.EventHandler(this.bt_point_Click);
            // 
            // bt_0
            // 
            this.bt_0.BackColor = System.Drawing.SystemColors.Menu;
            this.bt_0.FlatAppearance.BorderSize = 0;
            this.bt_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_0.Location = new System.Drawing.Point(7, 262);
            this.bt_0.Name = "bt_0";
            this.bt_0.Size = new System.Drawing.Size(62, 61);
            this.bt_0.TabIndex = 26;
            this.bt_0.Text = "0";
            this.bt_0.UseVisualStyleBackColor = false;
            this.bt_0.Click += new System.EventHandler(this.bt_0_Click);
            // 
            // bt_1
            // 
            this.bt_1.BackColor = System.Drawing.SystemColors.Menu;
            this.bt_1.FlatAppearance.BorderSize = 0;
            this.bt_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_1.Location = new System.Drawing.Point(139, 199);
            this.bt_1.Name = "bt_1";
            this.bt_1.Size = new System.Drawing.Size(61, 61);
            this.bt_1.TabIndex = 25;
            this.bt_1.Text = "1";
            this.bt_1.UseVisualStyleBackColor = false;
            this.bt_1.Click += new System.EventHandler(this.bt_1_Click);
            // 
            // bt_2
            // 
            this.bt_2.BackColor = System.Drawing.SystemColors.Menu;
            this.bt_2.FlatAppearance.BorderSize = 0;
            this.bt_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_2.Location = new System.Drawing.Point(73, 199);
            this.bt_2.Name = "bt_2";
            this.bt_2.Size = new System.Drawing.Size(61, 61);
            this.bt_2.TabIndex = 24;
            this.bt_2.Text = "2";
            this.bt_2.UseVisualStyleBackColor = false;
            this.bt_2.Click += new System.EventHandler(this.bt_2_Click);
            // 
            // bt_3
            // 
            this.bt_3.BackColor = System.Drawing.SystemColors.Menu;
            this.bt_3.FlatAppearance.BorderSize = 0;
            this.bt_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_3.Location = new System.Drawing.Point(7, 199);
            this.bt_3.Name = "bt_3";
            this.bt_3.Size = new System.Drawing.Size(62, 61);
            this.bt_3.TabIndex = 23;
            this.bt_3.Text = "3";
            this.bt_3.UseVisualStyleBackColor = false;
            this.bt_3.Click += new System.EventHandler(this.bt_3_Click);
            // 
            // bt_6
            // 
            this.bt_6.BackColor = System.Drawing.SystemColors.Menu;
            this.bt_6.FlatAppearance.BorderSize = 0;
            this.bt_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_6.Location = new System.Drawing.Point(139, 137);
            this.bt_6.Name = "bt_6";
            this.bt_6.Size = new System.Drawing.Size(61, 61);
            this.bt_6.TabIndex = 22;
            this.bt_6.Text = "6";
            this.bt_6.UseVisualStyleBackColor = false;
            this.bt_6.Click += new System.EventHandler(this.bt_6_Click);
            // 
            // bt_5
            // 
            this.bt_5.BackColor = System.Drawing.SystemColors.Menu;
            this.bt_5.FlatAppearance.BorderSize = 0;
            this.bt_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_5.Location = new System.Drawing.Point(73, 137);
            this.bt_5.Name = "bt_5";
            this.bt_5.Size = new System.Drawing.Size(61, 61);
            this.bt_5.TabIndex = 21;
            this.bt_5.Text = "5";
            this.bt_5.UseVisualStyleBackColor = false;
            this.bt_5.Click += new System.EventHandler(this.bt_5_Click);
            // 
            // bt_4
            // 
            this.bt_4.BackColor = System.Drawing.SystemColors.Menu;
            this.bt_4.FlatAppearance.BorderSize = 0;
            this.bt_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_4.Location = new System.Drawing.Point(7, 137);
            this.bt_4.Name = "bt_4";
            this.bt_4.Size = new System.Drawing.Size(61, 61);
            this.bt_4.TabIndex = 20;
            this.bt_4.Text = "4";
            this.bt_4.UseVisualStyleBackColor = false;
            this.bt_4.Click += new System.EventHandler(this.bt_4_Click);
            // 
            // bt_9
            // 
            this.bt_9.BackColor = System.Drawing.SystemColors.Menu;
            this.bt_9.FlatAppearance.BorderSize = 0;
            this.bt_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_9.Location = new System.Drawing.Point(139, 75);
            this.bt_9.Name = "bt_9";
            this.bt_9.Size = new System.Drawing.Size(61, 61);
            this.bt_9.TabIndex = 19;
            this.bt_9.Text = "9";
            this.bt_9.UseVisualStyleBackColor = false;
            this.bt_9.Click += new System.EventHandler(this.bt_9_Click);
            // 
            // bt_8
            // 
            this.bt_8.BackColor = System.Drawing.SystemColors.Menu;
            this.bt_8.FlatAppearance.BorderSize = 0;
            this.bt_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_8.Location = new System.Drawing.Point(73, 75);
            this.bt_8.Name = "bt_8";
            this.bt_8.Size = new System.Drawing.Size(61, 61);
            this.bt_8.TabIndex = 18;
            this.bt_8.Text = "8";
            this.bt_8.UseVisualStyleBackColor = false;
            this.bt_8.Click += new System.EventHandler(this.bt_8_Click);
            // 
            // tb_amount
            // 
            this.tb_amount.Location = new System.Drawing.Point(75, 26);
            this.tb_amount.Name = "tb_amount";
            this.tb_amount.Size = new System.Drawing.Size(170, 22);
            this.tb_amount.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "AMOUNT:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(25, 383);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(682, 235);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction History";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 179);
            this.dataGridView1.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Blue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(98, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Print History";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // PAYMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(794, 628);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "PAYMENT";
            this.Text = "PAYMENT";
            this.Load += new System.EventHandler(this.PAYMENT_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_reason;
        private System.Windows.Forms.ComboBox cb_name;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bt_clearall;
        private System.Windows.Forms.Button bt_pay;
        private System.Windows.Forms.TextBox tb_reBalance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_curBalance;
        private System.Windows.Forms.TextBox tb_amountPaid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cb_option;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_7;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Button bt_div;
        private System.Windows.Forms.Button bt_equal;
        private System.Windows.Forms.Button bt_times;
        private System.Windows.Forms.Button bt_sub;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_point;
        private System.Windows.Forms.Button bt_0;
        private System.Windows.Forms.Button bt_1;
        private System.Windows.Forms.Button bt_2;
        private System.Windows.Forms.Button bt_3;
        private System.Windows.Forms.Button bt_6;
        private System.Windows.Forms.Button bt_5;
        private System.Windows.Forms.Button bt_4;
        private System.Windows.Forms.Button bt_9;
        private System.Windows.Forms.Button bt_8;
        private System.Windows.Forms.TextBox tb_amount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;

    }
}