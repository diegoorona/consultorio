using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            tbContra.PasswordChar = '•';
            b_help.FlatStyle = FlatStyle.Flat;
            b_help.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.BackColor = Color.FromArgb(0,0,255);
            button1.ForeColor = Color.White;


           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new MAIN();
            f.Show();
            this.Hide();

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            //83, 23
            button1.Width = 85;
            button1.Height = 25;
            button1.BackColor = Color.LimeGreen;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Width = 83;
            button1.Height = 23;
            button1.BackColor = Color.Blue;
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void b_help_MouseHover(object sender, EventArgs e)
        {
            ++b_help.Width;
            ++b_help.Height;

        }

        private void b_help_MouseLeave(object sender, EventArgs e)
        {
            --b_help.Width;
            --b_help.Height;
        }


    }

}
