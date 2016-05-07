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
    public partial class Patient : Form
    {
        Persona_BD paciente = new Persona_BD();
        public Patient()
        {
            InitializeComponent();
            toolStripMenuItem1.Text = User.NameOfUser;
            paciente.Search_Name("PACIENTE", cb_name);
        }
        private void Autocomplete()
        {
            string[] list;

            //Regresa un arreglo estático con todos los nombres de la tabla Paciente para después asociarlos al combobox para que
            //estén disponibles en el autocompletado.
            list = paciente.Search_ArrayOfNames("PACIENTE");

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
            try
            {
                if (cb_name.Text != "")
                {
                    paciente.Search_Persona("PACIENTE", tb_name, l_idDent, null, cb_gender,
                                            dt_date, tb_address, tb_phone, tb_email, cb_name.Text);
                    cb_name.Items.Clear();

                    paciente.Search_Name("PACIENTE", cb_name);
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
                if (paciente.Vacio_Person("PACIENTE", "", tb_name.Text, cb_gender.Text,
                            dt_date.Value.ToShortDateString(), tb_address.Text, tb_phone.Text, tb_email.Text))
                {
                    paciente.INSERT_Person("PACIENTE", "", tb_name.Text, cb_gender.Text,
                        dt_date.Value.ToShortDateString(), tb_address.Text, tb_phone.Text, tb_email.Text);

                    paciente.Searh_ID("PACIENTE", tb_name.Text, l_idDent);

                    cb_name.Items.Clear();

                    paciente.Search_Name("PACIENTE", cb_name);

                    Autocomplete();

                    this.Clear_Form();

                    MessageBox.Show("A PATIENT HAS BEEN SUCCESSFULLY INSERTED.");
                }
                else
                    MessageBox.Show("YOU MUST FILL ALL THE BLANK SPACES.");
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
                if (paciente.Vacio_Person("PACIENTE", "", tb_name.Text, cb_gender.Text,
                            dt_date.Value.ToShortDateString(), tb_address.Text, tb_phone.Text, tb_email.Text))
                {
                    paciente.UPDATE_Person("PACIENTE", "", tb_name.Text, cb_gender.Text,
                        dt_date.Value.ToShortDateString(), tb_address.Text, tb_phone.Text, tb_email.Text, l_idDent.Text);

                    cb_name.Items.Clear();

                    paciente.Search_Name("PACIENTE", cb_name);

                    Autocomplete();

                    this.Clear_Form();

                    MessageBox.Show("A PATIENT HAS BEEN SUCCESSFULLY UPDATED.");
                }
                else
                    MessageBox.Show("YOU MUST FILL ALL THE BLANK SPACES.");
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
                    paciente.DEL_Person(l_idDent.Text, "PACIENTE");
                    
                    cb_name.Items.Clear();

                    paciente.Search_Name("PACIENTE", cb_name);

                    Autocomplete();

                    this.Clear_Form();
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
            tb_address.Clear();
            tb_phone.Clear();
            tb_email.Clear();
            cb_gender.Text = "";
            dt_date.Text = DateTime.Now.ToShortDateString();
            l_idDent.Text = "";

        }

        private void Patient_Load(object sender, EventArgs e)
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

        private void Patient_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (User.LogOut == 0)
                User.main.Show();
        }

    }
}
