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
        public void ReporteExcel(string name_pat,string name_dent, string image, string from, string to, SaveFileDialog file)
        {
            aplicacion = new Microsoft.Office.Interop.Excel.Application();
            aplicacion.DisplayAlerts = false;
            libros_trabajo = aplicacion.Workbooks.Add();
            hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range Rango;

            hoja_trabajo.Cells[5, 8] = System.DateTime.Now.ToString("dd/MM/yyyy"); ;
            hoja_trabajo.Cells[6, 2] = "BAJO TRATAMIENTO:"; 
            hoja_trabajo.Cells[6, 4] = "TOMA MEDICAMENTO:";  hoja_trabajo.Cells[6, 6] = "ESPECIFIQUE:";
            /*     COLUMNA IZQUIERDA    */
            hoja_trabajo.Cells[8,2] = "EXAMEN DE TEJIDOS";
            /*---------------------------------------------*/
            hoja_trabajo.Cells[9,2] = "DUROS";
            hoja_trabajo.Cells[10, 2] = "ESMALTE:"; hoja_trabajo.Cells[10, 4] = "DENTINA:";
            /*---------------------------------------------*/
            hoja_trabajo.Cells[11, 2] = "RX";
            hoja_trabajo.Cells[12, 2] = "CARIES INTERPROXIMAL";
            /*---------------------------------------------*/
            hoja_trabajo.Cells[13, 2] = "RAIZ:"; hoja_trabajo.Cells[13, 4] = "HUESOS:";
            /*---------------------------------------------*/
            hoja_trabajo.Cells[14, 2] = "BLANDOS";
            /*---------------------------------------------*/
            hoja_trabajo.Cells[15, 2] = "ENCIA:";                   hoja_trabajo.Cells[15, 4] = "PULPA:";
            hoja_trabajo.Cells[16, 2] = "INSERCION EPITELIAL:";     hoja_trabajo.Cells[16, 4] = "VELO DEL PALADAR:";
            hoja_trabajo.Cells[17, 2] = "LENGUA:";                  hoja_trabajo.Cells[17, 4] = "CARRILLOS:";
            
            /*     COLUMNA DEBAJO    */
            hoja_trabajo.Cells[18, 2] = "ANTECEDENTES PERSONALES";
            /*---------------------------------------------*/
            hoja_trabajo.Cells[19, 2] = "ALERGIAS:";
            hoja_trabajo.Cells[20, 2] = "BUENA HIGIENE BUCAL:";
            /*---------------------------------------------*/
            hoja_trabajo.Cells[21, 2] = "HABITOS";
            /*---------------------------------------------*/
            hoja_trabajo.Cells[22, 2] = "BRICOMANIA:";          hoja_trabajo.Cells[22, 4] = "LENGUA:";
            hoja_trabajo.Cells[23, 2] = "CONT. MUSCULAR:";      hoja_trabajo.Cells[23, 4] = "LABIOS:";
            hoja_trabajo.Cells[24, 2] = "BUENA ALIMENTACIÓN:";  hoja_trabajo.Cells[24, 4] = "DEDOS:";
            hoja_trabajo.Cells[25, 2] = "RESP: BUCAL:";         hoja_trabajo.Cells[25, 4] = "HAB. MORDIDA:";


            // SECCIÓN DE ENCABEZADO
            hoja_trabajo.get_Range("b1", to + "3").Merge(false);
            Rango = hoja_trabajo.get_Range("b1", to + "3");
            this.Rango(hoja_trabajo, Rango, "b1", to + "3", 15, System.Drawing.Color.White, System.Drawing.Color.Black);
            Rango.FormulaR1C1 = "                                                      NOMBRE DE PACIENTE: "+name_pat+" \n "+
                                "                                                     NOMBRE DE DENTISTA: "+name_dent+"";
            

            string x = AppDomain.CurrentDomain.BaseDirectory;
            hoja_trabajo.Shapes.AddPicture(AppDomain.CurrentDomain.BaseDirectory + "Consultorio_20Dental_20Ixchel_20Logo.png", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 60, 0, 195, 55);
            hoja_trabajo.Shapes.AddPicture(image, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 550, 100, 250, 250);
            //COLORES DE FONDO
            //PIRMER FRANJA
            this.Rango(hoja_trabajo, Rango, "b5", "h5", 11, System.Drawing.Color.FromArgb(128, 128, 128), System.Drawing.Color.White);
            this.Rango(hoja_trabajo, Rango, "b6", "b6", 11, System.Drawing.Color.FromArgb(217, 217, 217), System.Drawing.Color.Black);
            this.Rango(hoja_trabajo, Rango, "d6", "d6", 11, System.Drawing.Color.FromArgb(217, 217, 217), System.Drawing.Color.Black);
            this.Rango(hoja_trabajo, Rango, "f6", "f6", 11, System.Drawing.Color.FromArgb(217, 217, 217), System.Drawing.Color.Black);
            //Columna Izquierda
            this.Rango(hoja_trabajo, Rango, "b8", "e8", 11, System.Drawing.Color.FromArgb(128, 128, 128), System.Drawing.Color.White);
            this.Rango(hoja_trabajo, Rango, "b9", "e9", 11, System.Drawing.Color.FromArgb(217, 217, 217), System.Drawing.Color.Black);

            this.Rango(hoja_trabajo, Rango, "b11", "e11", 11, System.Drawing.Color.FromArgb(128, 128, 128), System.Drawing.Color.White);
            this.Rango(hoja_trabajo, Rango, "b12", "e12", 11, System.Drawing.Color.FromArgb(217, 217, 217), System.Drawing.Color.Black);
            this.Rango(hoja_trabajo, Rango, "b14", "e14", 11, System.Drawing.Color.FromArgb(217, 217, 217), System.Drawing.Color.Black);

            //Columna debajo
            this.Rango(hoja_trabajo, Rango, "b18", "e18", 11, System.Drawing.Color.FromArgb(128, 128, 128), System.Drawing.Color.White);
            this.Rango(hoja_trabajo, Rango, "b21", "e21", 11, System.Drawing.Color.FromArgb(128, 128, 128), System.Drawing.Color.White);

            //ULTIMA FRANJA
            this.Rango(hoja_trabajo, Rango, "b26", "h26", 11, System.Drawing.Color.FromArgb(128, 128, 128), System.Drawing.Color.White);

            //TAMAÑO CELDA
            this.CellSize(hoja_trabajo, Rango, "c1", 5);
            this.CellSize(hoja_trabajo, Rango, "d1", 21);
            this.CellSize(hoja_trabajo, Rango, "e1", 5);
            this.CellSize(hoja_trabajo, Rango, "f1", 21);
            this.FinalizarArch(file);
        }

        public void Rango(Microsoft.Office.Interop.Excel.Worksheet hoja, Microsoft.Office.Interop.Excel.Range rango, string from, string to, int Size, Color cFondo, Color fuente)
        {
            rango = hoja.get_Range(from,to);
            if (from != "b10")
                rango.Font.Bold = true;
            rango.Font.Size = Size;
            rango.Font.Color = fuente;
            rango.Cells.Interior.Color = System.Drawing.ColorTranslator.ToOle(cFondo);
            rango.ColumnWidth = 21;
        }

        public void CellSize(Microsoft.Office.Interop.Excel.Worksheet hoja, Microsoft.Office.Interop.Excel.Range rango, string cell, int tam)
        {
            rango = hoja.get_Range(cell);
            rango.ColumnWidth = tam;
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
