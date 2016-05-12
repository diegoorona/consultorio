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
    public partial class SECRETARY : Form
    {
        Persona_BD secretaria = new Persona_BD();
        string id_destista_insert = "";
        string id_destista_delete = "";
        public SECRETARY()
        {
            InitializeComponent();
            toolStripMenuItem1.Text = User.NameOfUser;
            tb_pass.PasswordChar = '•';
            tb_confirm.PasswordChar = '•';
            secretaria.Search_Name("SECRETARIA", cb_name);
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
            cb_gender.Text = "";
            dt_date.Text = DateTime.Now.ToShortDateString();
            l_idDent.Text = "";

        }
        private void Autocomplete()
        {
            string[] list;

            //Regresa un arreglo estático con todos los nombres de la tabla Paciente para después asociarlos al combobox para que
            //estén disponibles en el autocompletado.
            list = secretaria.Search_ArrayOfNames("SECRETARIA");

            var source = new AutoCompleteStringCollection();
            source.AddRange(list);

            cb_name.AutoCompleteCustomSource = source;
            cb_name.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_name.AutoCompleteSource = AutoCompleteSource.CustomSource;
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

        private void b_search_Click(object sender, EventArgs e)
        {
            
        }

        private void b_search_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cb_name.Text != "")
                {
                    secretaria.Search_Persona("SECRETARIA", tb_name, l_idDent, null, cb_gender,
                                            dt_date, tb_address, tb_phone, tb_email, cb_name.Text);
                    secretaria.Search_USER_PASS("SECRETARIA", tb_user, tb_pass, tb_confirm, l_idDent.Text);
                    cb_name.Items.Clear();
                    secretaria.Search_Name("SECRETARIA", cb_name);

                    //LISTA DE DENTISTAS
                    secretaria.DentistList(dgvSec, "SECRETARIA", l_idDent.Text);
                }
                else
                    MessageBox.Show("YOU MUST SELECT A NAME.");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void b_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (secretaria.Confirm_Contra(tb_pass.Text, tb_confirm.Text))
                {
                    if (secretaria.Vacio_Person("SECRETARIA", "", tb_name.Text, cb_gender.Text,
                            dt_date.Value.ToShortDateString(), tb_address.Text, tb_phone.Text, tb_email.Text))
                    {
                        secretaria.INSERT_Person("SECRETARIA", "", tb_name.Text, cb_gender.Text,
                            dt_date.Value.ToShortDateString(), tb_address.Text, tb_phone.Text, tb_email.Text);

                        secretaria.Searh_ID("SECRETARIA", tb_name.Text, l_idDent);

                        secretaria.USER_PASS("SECRETARIA", l_idDent.Text, tb_user.Text, tb_pass.Text);

                        cb_name.Items.Clear();

                        secretaria.Search_Name("SECRETARIA", cb_name);

                        Autocomplete();


                        MessageBox.Show("A SECRETARY HAS BEEN SUCCESSFULLY INSERTED.");
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

        private void b_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (secretaria.Confirm_Contra(tb_pass.Text, tb_confirm.Text))
                {
                    if (secretaria.Vacio_Person("SECRETARIA", "", tb_name.Text, cb_gender.Text,
                            dt_date.Value.ToShortDateString(), tb_address.Text, tb_phone.Text, tb_email.Text))
                    {
                        secretaria.UPDATE_Person("SECRETARIA", "", tb_name.Text, cb_gender.Text,
                            dt_date.Value.ToShortDateString(), tb_address.Text, tb_phone.Text, tb_email.Text, l_idDent.Text);

                        secretaria.USER_PASS("SECRETARIA", l_idDent.Text, tb_user.Text, tb_pass.Text);

                        cb_name.Items.Clear();

                        secretaria.Search_Name("SECRETARIA", cb_name);

                        Autocomplete();

                        this.Clear_Form();

                        MessageBox.Show("A SECRETARY HAS BEEN SUCCESSFULLY UPDATED.");
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
                    secretaria.DEL_Person(l_idDent.Text, "SECRETARIA");

                    cb_name.Items.Clear();

                    secretaria.Search_Name("SECRETARIA", cb_name);

                    Autocomplete();

                    this.Clear_Form();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SECRETARY_Load(object sender, EventArgs e)
        {
            Autocomplete();
            secretaria.DentistList(dgvDent, "DENTISTA", "");
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

        private void SECRETARY_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (User.LogOut == 0)
                User.main.Show();
        }

        private void cb_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                b_search_Click_1(sender, e);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                secretaria.Searh_ID("SECRETARIA", cb_name.Text, l_idDent);
                if (l_idDent.Text != "" && id_destista_insert != "")
                {
                    secretaria.INSERT_DENTIST_SERETARY(id_destista_insert, l_idDent.Text);
                    secretaria.DentistList(dgvSec, "SECRETARIA", l_idDent.Text);
                }
                else
                    MessageBox.Show("YOU MUST SELECT A SECRETARY NAME AND A DENTIST NAME.");
            }
            catch( Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void dgvDent_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                id_destista_insert = dgvDent[0, e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                secretaria.Searh_ID("SECRETARIA", cb_name.Text, l_idDent);
                if (l_idDent.Text != "" && id_destista_delete != "")
                {
                    secretaria.DELETE_DENTIST_SERETARY(id_destista_delete, l_idDent.Text);
                    dgvSec.Rows.Clear();
                    secretaria.DentistList(dgvSec, "SECRETARIA", l_idDent.Text);
                }
                else
                    MessageBox.Show("YOU MUST SELECT A SECRETARY NAME AND A DENTIST NAME.");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void dgvSec_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                id_destista_delete = dgvDent[0, e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
