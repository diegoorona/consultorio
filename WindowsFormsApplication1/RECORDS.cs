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
    public partial class RECORDS : Form
    {
        Microsoft.Office.Interop.Excel.Application aplicacion;
        Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
        Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
        string sourceFile = "";
        Persona_BD persona = new Persona_BD();
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
            if (User.LogOut == 0)
                User.main.Show();
        }


        private void b_create_Click(object sender, EventArgs e)
        {
            SaveFileDialog file = new SaveFileDialog();
            file.Filter = "Excel (*.xls)|*.xls";
            if (file.ShowDialog() == DialogResult.OK)
            {
                RecordExcel r = new RecordExcel(aplicacion, libros_trabajo, hoja_trabajo);
                r.ReporteExcel("DANTE FELIPE GONZÁLEZ JÁQUEZ", "JUAN PEREZ GARCÍA", sourceFile, "b", "h", file);
            }
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
                dgv.Enabled = true;
                b_search.Enabled = true;
                persona.Search_Name("DENTISTA", comboBox1);
            }
        }

        private void b_search_Click(object sender, EventArgs e)
        {
            
        }

    }
}
