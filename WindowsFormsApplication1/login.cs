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
        Persona_BD persona = new Persona_BD();
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
            string nombre = persona.Access(tbUsuario.Text, tbContra.Text);
            string tipo = persona.TypeOfUser(tbUsuario.Text, tbContra.Text);
            if (nombre != "" && tipo != "")
            {
                User.NameOfUser = nombre;
                User.TypeOfUser = tipo;
                User.main = new MAIN();
                User.main.Show();
                User.LogOut = 0;
                this.Hide();
            }
            else
                MessageBox.Show("El usuario o contraseña no existen o no corresponden.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            

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

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tbContra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }


    }

}
