using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{

    public partial class DENTIST : Form
    {
        Persona_BD dentista = new Persona_BD();
        public DENTIST()
        {
            InitializeComponent();
            tb_pass.PasswordChar = '•';
            tb_confirm.PasswordChar = '•';
            b_search.FlatAppearance.BorderSize = 0;
            dentista.Search_Name("DENTISTA", cb_name);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void b_edit_Click(object sender, EventArgs e)
        {
        }

        private void b_search_MouseHover(object sender, EventArgs e)
        {
            ++b_search.Height;
            ++b_search.Width;
        }

        private void b_search_MouseLeave(object sender, EventArgs e)
        {
            --b_search.Width;
            --b_search.Height;
        }

        private void b_add_MouseHover(object sender, EventArgs e)
        {
            //130, 23
            b_add.Width = 131;
            b_add.Height = 24;
 

        }

        private void b_add_MouseLeave(object sender, EventArgs e)
        {
            b_add.Width = 130;
            b_add.Height = 23;

        }

        private void b_edit_MouseHover(object sender, EventArgs e)
        {
            //130, 23
            b_edit.Width = 131;
            b_edit.Height = 24;


        }

        private void b_edit_MouseLeave(object sender, EventArgs e)
        {
            b_edit.Width = 130;
            b_edit.Height = 23;

        }

        private void b_delete_MouseHover(object sender, EventArgs e)
        {
            //130, 23
            b_delete.Width = 131;
            b_delete.Height = 24;

        }

        private void b_delete_MouseLeave(object sender, EventArgs e)
        {
            b_delete.Width = 130;
            b_delete.Height = 23;

        }

    }
}
