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
            toolStripMenuItem1.Text = User.NameOfUser;
            tb_pass.PasswordChar = '•';
            tb_confirm.PasswordChar = '•';
            b_search.FlatAppearance.BorderSize = 0;
            dentista.Search_Name("DENTISTA", cb_name);
        }
        private void Autocomplete()
        {
            string[] list;

            //Regresa un arreglo estático con todos los nombres de la tabla Paciente para después asociarlos al combobox para que
            //estén disponibles en el autocompletado.
            list = dentista.Search_ArrayOfNames("DENTISTA");

            var source = new AutoCompleteStringCollection();
            source.AddRange(list);

            cb_name.AutoCompleteCustomSource = source;
            cb_name.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_name.AutoCompleteSource = AutoCompleteSource.CustomSource;
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

        private void b_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (dentista.Confirm_Contra(tb_pass.Text, tb_confirm.Text))
                {
                    if (dentista.Vacio_Person("DENTISTA", tb_idcard.Text, tb_name.Text, cb_gender.Text,
                            dt_date.Value.ToShortDateString(), tb_address.Text, tb_phone.Text, tb_email.Text))
                    {
                        dentista.INSERT_Person("DENTISTA", tb_idcard.Text, tb_name.Text, cb_gender.Text,
                            dt_date.Value.ToShortDateString(), tb_address.Text, tb_phone.Text, tb_email.Text);

                        dentista.Searh_ID("DENTISTA", tb_name.Text, l_idDent);

                        dentista.USER_PASS("DENTISTA", l_idDent.Text, tb_user.Text, tb_pass.Text);

                        cb_name.Items.Clear();

                        dentista.Search_Name("DENTISTA", cb_name);

                        Autocomplete();

                        this.Clear_Form();

                        MessageBox.Show("A DENTIST HAS BEEN SUCCESSFULLY INSERTED.");
                    }
                    else
                        MessageBox.Show("YOU MUST FILL ALL THE BLANK SPACES.");
                }
                else
                    MessageBox.Show("PASSWORD IS INCORRECT.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void b_edit_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dentista.Confirm_Contra(tb_pass.Text, tb_confirm.Text))
                {
                    if (dentista.Vacio_Person("DENTISTA", tb_idcard.Text, tb_name.Text, cb_gender.Text,
                            dt_date.Value.ToShortDateString(), tb_address.Text, tb_phone.Text, tb_email.Text))
                    {
                        dentista.UPDATE_Person("DENTISTA", tb_idcard.Text, tb_name.Text, cb_gender.Text,
                            dt_date.Value.ToShortDateString(), tb_address.Text, tb_phone.Text, tb_email.Text, l_idDent.Text);

                        dentista.USER_PASS("DENTISTA", l_idDent.Text, tb_user.Text, tb_pass.Text);

                        cb_name.Items.Clear();

                        dentista.Search_Name("DENTISTA", cb_name);

                        Autocomplete();

                        this.Clear_Form();

                        MessageBox.Show("A DENTIST HAS BEEN SUCCESSFULLY UPDATED.");
                    }
                    else
                        MessageBox.Show("YOU MUST FILL ALL THE BLANK SPACES.");
                }
                else
                    MessageBox.Show("PASSWORD IS INCORRECT.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (l_idDent.Text != "")
                {
                    dentista.DEL_Person(l_idDent.Text, "DENTISTA");
                    cb_name.Items.Clear();
                    dentista.Search_Name("DENTISTA", cb_name);
                    this.Clear_Form();
                    Autocomplete();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Clear_Form()
        {
            cb_name.Text = "";
            tb_name.Clear();
            tb_user.Clear();
            tb_pass.Clear();
            tb_confirm.Clear();
            tb_address.Clear();
            tb_phone.Clear();
            tb_email.Clear();
            tb_idcard.Clear();
            cb_gender.Text = "";
            dt_date.Text = DateTime.Now.ToShortDateString();
            l_idDent.Text = "";

        }

        private void b_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_name.Text != "")
                {
                    dentista.Search_Persona("DENTISTA", tb_name, l_idDent, tb_idcard, cb_gender,
                                            dt_date, tb_address, tb_phone, tb_email, cb_name.Text);
                    dentista.Search_USER_PASS("DENTISTA", tb_user, tb_pass, tb_confirm, l_idDent.Text);
                    cb_name.Items.Clear();
                    dentista.Search_Name("DENTISTA", cb_name);
                }
                else
                    MessageBox.Show("YOU MUST SELECT A NAME.");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void DENTIST_Load(object sender, EventArgs e)
        {
            Autocomplete();
        }

        private void cb_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                b_search_Click(sender, e);
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.LogOut++;
            User.main.Close();
            User.main.Dispose();
            this.Close();
            this.Dispose();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void DENTIST_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (User.LogOut == 0)
                User.main.Show();
        }

    }
}
