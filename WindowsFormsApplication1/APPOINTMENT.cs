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
    public partial class APPOINTMENT : Form
    {
        Persona_BD persona = new Persona_BD();
        Cita_BD cita = new Cita_BD();
        public APPOINTMENT()
        {
            InitializeComponent();
            persona.Search_Name("PACIENTE", cb_name);
            //persona.Search_Persona("SECRETARIA", toolStripMenuItem1.Text, lSecre);
            b_add.Enabled = true;
            b_edit.Enabled = false;
            b_delete.Enabled = false;
        }
        //Método para que se habilite la función de autocompletar del combobox (Aquí nada más lo mando llamar en el Form_Load)
        //En los de paciente, dentista y secretaria, creo aparte de mandarlo a llamar en el Form_Load, también tiene que 
        //llamarse en los botones de Add, Edit y Delete, para que se refresque el arreglo con los nuevos datos. 
        private void Autocomplete()
        {
            string[] list;
           
            //Regresa un arreglo estático con todos los nombres de la tabla Paciente para después asociarlos al combobox para que
            //estén disponibles en el autocompletado.
            list = persona.Search_ArrayOfNames("PACIENTE");

            var source = new AutoCompleteStringCollection();
            source.AddRange(list);

            cb_name.AutoCompleteCustomSource = source;
            cb_name.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_name.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void Clear_Form()
        {
            dgvAppoints.Rows.Clear();
            lAppoint.ResetText();
            lPatient.ResetText();
            tbName.ResetText();
            dDate.ResetText();
            tbDescription.ResetText();
            //persona.Search_Persona("SECRETARIA", toolStripMenuItem1.Text, lSecre);
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
            dgvAppoints.Rows.Clear();

            persona.Search_Persona("PACIENTE", cb_name.Text, lPatient);
            cita.Search_Appointments(dgvAppoints, cb_name.Text);
            tbName.Text = cb_name.Text;
        }

        private void dgvAppoints_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvAppoints.RowCount > 0)
            {
                lAppoint.Text = dgvAppoints.SelectedRows[0].Cells[0].Value.ToString();
                lSecre.Text = dgvAppoints.SelectedRows[0].Cells[1].Value.ToString();
                lPatient.Text = dgvAppoints.SelectedRows[0].Cells[2].Value.ToString();
                dDate.Text = dgvAppoints.SelectedRows[0].Cells[3].Value.ToString();
                tbDescription.Text = dgvAppoints.SelectedRows[0].Cells[4].Value.ToString();

                b_add.Enabled = false;
                b_edit.Enabled = true;
                b_delete.Enabled = true;
            }
        }

        private void b_add_Click(object sender, EventArgs e)
        {
            cita.INSERT_Appointment(lSecre.Text, lPatient.Text, dDate.Text, tbDescription.Text);

            Clear_Form();
        }

        private void b_edit_Click(object sender, EventArgs e)
        {
            cita.UPDATE_Appointment(lAppoint.Text, lSecre.Text, lPatient.Text, dDate.Text, tbDescription.Text);

            Clear_Form();

            b_add.Enabled = true;
            b_edit.Enabled = false;
            b_delete.Enabled = false;
        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            cita.DEL_Appointment(lAppoint.Text);

            Clear_Form();

            b_add.Enabled = true;
            b_edit.Enabled = false;
            b_delete.Enabled = false;
        }

        private void dgvAppoints_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void APPOINTMENT_Load(object sender, EventArgs e)
        {
            Autocomplete();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void APPOINTMENT_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
