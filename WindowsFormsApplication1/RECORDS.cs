using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class RECORDS : Form
    {
        Microsoft.Office.Interop.Excel.Application aplicacion;
        Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
        Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
        string sourceFile = "";
        string nombre_paciente = "";
        Persona_BD persona = new Persona_BD();
        Record_BD expediente = new Record_BD();
        public RECORDS()
        {
            InitializeComponent();
            toolStripMenuItem1.Text = User.NameOfUser;
            rb_patient.Checked = true;
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.LogOut++;
            User.main.Close();
            User.main.Dispose();
            this.Close();
            this.Dispose();
        }

        private void RECORDS_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*if (User.LogOut == 0)
                User.main.Show();*/
            Application.Exit();
        }


        private void b_create_Click(object sender, EventArgs e)
        {
            Label id = new Label();
            string root = "";
            if (sourceFile != "")
            {
                string paciente = cb_name.Text;
                string dentista = l_dentist_name.Text;
                if (paciente != "" && dentista != "")
                {
                    SaveFileDialog file = new SaveFileDialog();
                    file.Filter = "Excel (*.xls)|*.xls";
                    file.FileName = cb_name.Text+"_"+System.DateTime.Now.ToString("dd.MM.yyyy");
                    if (file.ShowDialog() == DialogResult.OK)
                    {
                        RecordExcel r = new RecordExcel(aplicacion, libros_trabajo, hoja_trabajo);
                        r.ReporteExcel(paciente, dentista, sourceFile, "b", "h", file);
                        
                        
                        root = @file.FileName;
                        
                        persona.Searh_ID("PACIENTE", cb_name.Text, id);
                        expediente.InsertRecord(id.Text, root);
                        expediente.SearchByPatient(cb_name.Text, ref root);
                        Process.Start(@root);
                    }
                }
                else
                    MessageBox.Show("YOU MUST SELECT A PATIENT´S NAME.");
            }
            else
                MessageBox.Show("YOU MUST SELECT AN IMAGE.");
        }




        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    sourceFile = ofd.FileName;
                    pb_image.Image = Image.FromFile(sourceFile);
                }

        }

        private void rb_patient_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            if (rb_patient.Checked == true)
            {
                comboBox1.Text = "";
                dgv.Enabled = false;
                b_search.Enabled = false;
                persona.Search_Name("PACIENTE", comboBox1);
            }

        }

        private void rb_dentist_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            if (rb_dentist.Checked == true)
            {
                comboBox1.Text = "";
                dgv.Enabled = true;
                b_search.Enabled = true;
                persona.Search_Name("DENTISTA", comboBox1);
            }
        }

        private void b_search_Click(object sender, EventArgs e)
        {
                    expediente.SearchByDentist(comboBox1.Text, dgv);
        }

        private void RECORDS_Load(object sender, EventArgs e)
        {
            persona.Search_Name("PACIENTE", cb_name);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Label id = new Label();
            string nombre = "";
            if (!expediente.Exist(cb_name.Text))
            {
                if (cb_name.Text != "")
                {
                    persona.Searh_ID("PACIENTE", cb_name.Text, id);
                    persona.Search_Dentist_Patient(ref nombre, id.Text);
                    l_dentist_name.Text = nombre;
                }
            }
            else
                MessageBox.Show("THERE IS ALREADY A RECORD FILE FOR \n "+cb_name.Text);
        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            string root = "";
            string id = "";
            if (rb_patient.Checked)
            {
                if (comboBox1.Text != "")
                {
                    expediente.SearchByPatient(comboBox1.Text, ref root);
                    expediente.SearchById(comboBox1.Text, ref id);
                    expediente.DeleteRecord(comboBox1.Text, root, id);
                }
                else
                    MessageBox.Show("YOU MUST SELECT A PATIENT.");
            }
            else if (rb_dentist.Checked)
            {
                if (nombre_paciente != "")
                {
                    expediente.SearchByPatient(nombre_paciente, ref root);
                    expediente.SearchById(nombre_paciente, ref id);
                    expediente.DeleteRecord(nombre_paciente, root, id);
                }
                else
                    MessageBox.Show("YOU MUST SELECT A PATIENT FROM THE TABLE.");
            }
            dgv.Rows.Clear();
            comboBox1.Items.Clear();
            comboBox1.Text = "";

        }

        private void b_search_MouseHover(object sender, EventArgs e)
        {
            ++b_search.Height;
            ++b_search.Width;
        }

        private void b_search_MouseLeave(object sender, EventArgs e)
        {
            --b_search.Height;
            --b_search.Width;
        }

        private void dgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            nombre_paciente = dgv[1, e.RowIndex].Value.ToString();
        }

        private void b_open_Click(object sender, EventArgs e)
        {
            string root = "";
            if (rb_patient.Checked)
            {
                if (comboBox1.Text != "")
                {
                    expediente.SearchByPatient(comboBox1.Text, ref root);
                }
                else
                    MessageBox.Show("YOU MUST SELECT A PATIENT.");
            }
            else if (rb_dentist.Checked)
            {
                if (nombre_paciente != "")
                {
                    expediente.SearchByPatient(nombre_paciente, ref root);
                }
                else
                    MessageBox.Show("YOU MUST SELECT A PATIENT FROM THE TABLE.");
            }
            if (root != "")
                Process.Start(@root);
            else
                MessageBox.Show("NO FILE FOUNDED.");
        }

    }
}
