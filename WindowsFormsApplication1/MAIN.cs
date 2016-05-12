using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MAIN : Form
    {
        public MAIN()
        {
            InitializeComponent();
            b_app.FlatStyle = FlatStyle.Flat;
            b_app.FlatAppearance.BorderSize = 0;
            b_app.BackColor = Color.Blue;
            b_app.ForeColor = Color.White;
            toolStripMenuItem1.Text = User.NameOfUser;
            if (User.TypeOfUser == "DENTIST")
                b_app.Enabled = false;
            else
            {
                b_dent.Enabled = false;
                b_sec.Enabled = false;
                b_pati.Enabled = false;
            }

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.LogOut++;
            this.Close();
        }

        private void MAIN_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (User.LogOut == 0)
               Application.Exit();
            else
            {
                login log = new login();
                log.Show();
            }
        }

        private void b_Click(object sender, EventArgs e)
        {
            Form apo = new APPOINTMENT();
            apo.Show();
            User.main.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form rec = new RECORDS();
            rec.Show();
            User.main.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form sec = new SECRETARY();
            sec.Show();
            User.main.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form den = new DENTIST();
            den.Show();
            User.main.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form pat = new Patient();
            pat.Show();
            User.main.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form pay = new PAYMENT();
            pay.Show();
            User.main.Hide();
        }

        private void b_app_MouseHover(object sender, EventArgs e)
        {
            b_app.BackColor = Color.LimeGreen;
            pictureBox2.BackColor = Color.LimeGreen;
            b_app.Width =135;
            b_app.Height =35;
            pictureBox2.Height = b_app.Height;
            pictureBox2.Width = 44;
        }

        private void b_app_MouseLeave(object sender, EventArgs e)
        {
            b_app.BackColor = Color.Blue;
            pictureBox2.BackColor = Color.Blue;
            b_app.Width = 134;
            b_app.Height = 34;
            pictureBox2.Height = b_app.Height;
            pictureBox2.Width = 43;
        }

        private void b_rec_MouseHover(object sender, EventArgs e)
        {
            pb_rec.BackColor = Color.LimeGreen;
            b_rec.BackColor = Color.LimeGreen;
            b_rec.Width = 135;
            b_rec.Height = 35;
            pb_rec.Height = b_rec.Height;
            pb_rec.Width = 44;
        }

        private void b_rec_MouseLeave(object sender, EventArgs e)
        {
            pb_rec.BackColor = Color.Blue;
            b_rec.BackColor = Color.Blue;
            b_rec.Width = 134;
            b_rec.Height = 34;
            pb_rec.Height = b_rec.Height;
            pb_rec.Width = 43;
        }

        private void b_pay_MouseHover(object sender, EventArgs e)
        {
            pb_pay.BackColor = Color.LimeGreen;
            b_pay.BackColor = Color.LimeGreen;
            b_pay.Width = 135;
            b_pay.Height = 35;
            pb_pay.Height = b_pay.Height;
            pb_pay.Width = 44;
        }

        private void b_pay_MouseLeave(object sender, EventArgs e)
        {
            pb_pay.BackColor = Color.Blue;
            b_pay.BackColor = Color.Blue;
            b_pay.Width = 134;
            b_pay.Height = 34;
            pb_pay.Height = b_pay.Height;
            pb_pay.Width = 43;
        }

        private void b_sec_MouseHover(object sender, EventArgs e)
        {
            pb_sec.BackColor = Color.LimeGreen;
            b_sec.BackColor = Color.LimeGreen;
            b_sec.Width = 135;
            b_sec.Height = 35;
            pb_sec.Height = b_sec.Height;
            pb_sec.Width = 44;
        }

        private void b_sec_MouseLeave(object sender, EventArgs e)
        {
            pb_sec.BackColor = Color.Blue;
            b_sec.BackColor = Color.Blue;
            b_sec.Width = 134;
            b_sec.Height = 34;
            pb_sec.Height = pb_sec.Height;
            pb_sec.Width = 43;
        }

        private void b_dent_MouseHover(object sender, EventArgs e)
        {
            pb_den.BackColor = Color.LimeGreen;
            b_dent.BackColor = Color.LimeGreen;
            b_dent.Width = 135;
            b_dent.Height = 35;
            pb_den.Height = b_dent.Height;
            pb_den.Width = 44;
        }

        private void b_dent_MouseLeave(object sender, EventArgs e)
        {
            pb_den.BackColor = Color.Blue;
            b_dent.BackColor = Color.Blue;
            b_dent.Width = 134;
            b_dent.Height = 34;
            pb_den.Height = b_dent.Height;
            pb_den.Width = 43;
        }

        private void b_pati_MouseHover(object sender, EventArgs e)
        {
            pb_pat.BackColor = Color.LimeGreen;
            b_pati.BackColor = Color.LimeGreen;
            b_pati.Width = 135;
            b_pati.Height = 35;
            pb_pat.Height = b_pati.Height;
            pb_pat.Width = 44;
        }

        private void b_pati_MouseLeave(object sender, EventArgs e)
        {
            pb_pat.BackColor = Color.Blue;
            b_pati.BackColor = Color.Blue;
            b_pati.Width = 134;
            b_pati.Height = 34;
            pb_pat.Height = b_pati.Height;
            pb_pat.Width = 43;
        }

        private void MAIN_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Close();
        }


    }
}
