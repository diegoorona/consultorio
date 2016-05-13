using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
//using System.Windows.Forms.OpenFileDialog;
//using System.Windows.Forms.FolderBrowserDialog;


namespace WindowsFormsApplication1
{
    class RecordExcel
    {
        Microsoft.Office.Interop.Excel.Application aplicacion;
        Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
        Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;

        public RecordExcel(Microsoft.Office.Interop.Excel.Application a,
                         Microsoft.Office.Interop.Excel.Workbook lt,
                         Microsoft.Office.Interop.Excel.Worksheet ht)
        {
            aplicacion = a;
            libros_trabajo = lt;
            hoja_trabajo = ht;
        }
        public RecordExcel()
        {
            aplicacion = null;
            libros_trabajo = null;
            hoja_trabajo = null;
        }
        public void ReporteExcel(int n, string name, DataGridView dgv, string from, string to, SaveFileDialog file)
        {
            int suma = 10;
            aplicacion = new Microsoft.Office.Interop.Excel.Application();
            aplicacion.DisplayAlerts = false;
            libros_trabajo = aplicacion.Workbooks.Add();
            hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range Rango;

            /*for (int i = 0; i < n; i++)
            {
                //hoja_trabajo.Cells[9, i + 2] = dgv.Columns[i].HeaderText.ToString().ToUpper();
                hoja_trabajo.Cells[9, i + 2] = "HOLA MUNDO";
            }

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    hoja_trabajo.Cells[i + 10, j + 2] = dgv.Rows[i].Cells[j].Value.ToString();
                }
            }*/
            hoja_trabajo.Cells[9, 2] = "HOLA MUNDO";
            hoja_trabajo.get_Range("c1", to + "3").Merge(false);
            Rango = hoja_trabajo.get_Range("c1", to + "3");
            this.Rango(hoja_trabajo, Rango, "c1", to + "3", 15, System.Drawing.Color.White, false);
            Rango.FormulaR1C1 = "Si Capital \n Reporte de " + name;
            string x = AppDomain.CurrentDomain.BaseDirectory;
            hoja_trabajo.Shapes.AddPicture(AppDomain.CurrentDomain.BaseDirectory + "Consultorio_20Dental_20Ixchel_20Logo.png", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 60, 0, 220, 55);

            this.Rango(hoja_trabajo, Rango, from + "9", to + "9", 11, System.Drawing.Color.WhiteSmoke, false);
            this.Rango(hoja_trabajo, Rango, from + "10", to + suma.ToString(), 11, System.Drawing.Color.White, false);
        }

        public void Rango(Microsoft.Office.Interop.Excel.Worksheet hoja, Microsoft.Office.Interop.Excel.Range rango, string from, string to, int Size, Color c, bool izq)
        {
            rango = hoja.get_Range(from, to);
            if (izq != true)
            {
                rango.HorizontalAlignment = 3;
                rango.VerticalAlignment = 3;
            }
            if (from != "b10")
                rango.Font.Bold = true;
            rango.Font.Size = Size;
            rango.Cells.Interior.Color = System.Drawing.ColorTranslator.ToOle(c);
            rango.ColumnWidth = 20;
        }
        public void ConCli(string n1, string n2, string n3, SaveFileDialog file, bool pago)
        {
            Microsoft.Office.Interop.Excel.Range Rango;
            Rango = hoja_trabajo.get_Range("b6", "g7");
            hoja_trabajo.Cells[6, 2] = n1;
            hoja_trabajo.Cells[7, 2] = n2;
            if (pago == false)
            {
                hoja_trabajo.Cells[7, 7] = "Saldo Total: " + n3;
                this.Rango(hoja_trabajo, Rango, "b5", "g7", 11, System.Drawing.Color.White, true);
            }
            else
                this.Rango(hoja_trabajo, Rango, "b5", "c7", 11, System.Drawing.Color.White, true);
            this.FinalizarArch(file);
        }

        public void FinalizarArch(SaveFileDialog file)
        {
            libros_trabajo.SaveAs(file.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
            libros_trabajo.Close(true);
            aplicacion.Quit();
            MessageBox.Show("Reporte Exportado");
        }
    }
}
